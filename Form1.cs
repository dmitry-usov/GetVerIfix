using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace GetVerIfix
{
    public partial class Form1 : Form
    {

        private string filename; //текущий файл
        //private byte[] etalon = { 221, 221, 221, 221, 221, 221, 221, 221 }; //DD DD DD.. в числовом виде
        private byte[] etalon = { 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD }; 
        private byte[] buildByteAr;
        private int picBuild; // билд текущего файла
        private int picBuildPosition; //Где лежит билд в файле 
        Dictionary<int, string> pictureBuildsDic;//Словарь билдов и номеров версий

        public Form1()
        {
            InitializeComponent();
            this.Width = 355;

            pictureBuildsDic = new Dictionary<int, string>();
            init();
        }

        private void init()
        {
            //заполняем словарь
            pictureBuildsDic.Add(5179, "3.0");
            pictureBuildsDic.Add(5717, "3.5");
            pictureBuildsDic.Add(6192, "4.0");
            pictureBuildsDic.Add(6491, "4.5");
            pictureBuildsDic.Add(6537, "5.0");
            pictureBuildsDic.Add(6667, "5.0");
            pictureBuildsDic.Add(6846, "5.1");
            pictureBuildsDic.Add(10179, "5.5");
            pictureBuildsDic.Add(10383, "5.8");
            pictureBuildsDic.Add(10843, "5.9");
            pictureBuildsDic.Add(11109, "6.0");
            pictureBuildsDic.Add(11407, "6.1");

            foreach (int build in pictureBuildsDic.Keys)
            {
                picBuildsComboBox.Items.Add(build + " = " + pictureBuildsDic[build]);
                lbPicBuilds.Items.Add(build + " = " + pictureBuildsDic[build]);
            }
        }

        private void readFile(string filename)
        {
            if (filename.EndsWith(".grf"))
            {
                lblPath.ForeColor = Color.Black;
                lblPath.Text = filename;
            }
            else
            {
                lblPath.ForeColor = Color.Red;
                lblPath.Text = "Нажми или перетащи картинку *.grf на область ниже";
                lblVersion.Text = "";
                lblFixBuild.Text = "";
            }

            FileStream fs = File.OpenRead(filename);
            byte[] b = new byte[8];

            int counter = 0; //счетчик по 8 байт

            while (fs.Read(b, 0, b.Length) > 0)
            {
                counter += 8; //+8 к каждому чтению 8 байт
                if (Enumerable.SequenceEqual(b, etalon))
                {
                    byte[] m = new byte[8]; //пропускаем 8 байт
                    fs.Read(m, 0, m.Length);
                    counter += 8;

                    picBuildPosition = counter; //Запоминаяем позицию билда
                    buildByteAr = new byte[8]; //нужные 8 байт
                    fs.Read(buildByteAr, 0, buildByteAr.Length);
                    counter += 8;

                    picBuild = buildByteAr[0] + (buildByteAr[1] << 8);

                    lblFixBuild.Text = "picture build: " + picBuild.ToString();

                    if (pictureBuildsDic.ContainsKey(picBuild))
                    {
                        lblVersion.Text = pictureBuildsDic[picBuild];
                    }
                    else
                    {
                        lblVersion.Text = "XZ";
                    }
                }
            }
            fs.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Strider757/GetVerIfix");
        }

        private void picBuildsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int picbuildMenu = (this.Width == 355) ? this.Width = 505 : this.Width = 355;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Width = 355;
        }

        private void picBuildsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (filename == null) return;
            toolStripMenuItem1.HideDropDown();
            if (MessageBox.Show(this, "Are you sure about that?", "Confirm plz", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            FileStream fs = File.OpenWrite(filename);

            fs.Seek(picBuildPosition, SeekOrigin.Begin); //Смещаемся до байтов которые содержат билд 

            int selectedBuild = int.Parse(picBuildsComboBox.SelectedItem.ToString().Split('=')[0]);

            byte[] newBuild = buildByteAr;

            newBuild[0] = (byte)(selectedBuild & 0xFF);
            newBuild[1] = (byte)((selectedBuild >> 8) & 0xFF);

            fs.Write(newBuild, 0, 8);
            fs.Close();
            readFile(filename);

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFile = new OpenFileDialog();
            chooseFile.Title = "Выберите картинку iFIX";
            chooseFile.Filter = "Рисунок iFIX|*.grf";

            if (chooseFile.ShowDialog() == DialogResult.OK)
            {
                filename = chooseFile.FileName;
                readFile(filename);
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            string[] pic = (string[])e.Data.GetData(DataFormats.FileDrop);
            filename = pic[0].ToString();
            readFile(filename);
        }
    }
}


