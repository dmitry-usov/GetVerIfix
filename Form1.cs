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
        public Form1()
        {
            InitializeComponent();
            this.Width = 349;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFile = new OpenFileDialog();
            chooseFile.Title = "Выберите картинку iFIX";
            chooseFile.Filter = "Рисунок iFIX|*.grf";

            if (chooseFile.ShowDialog() == DialogResult.OK)
            {
                lblPath.Text = chooseFile.FileName;


                FileStream openFile = new FileStream(chooseFile.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                //DD DD DD.. в числовом виде
                byte[] etalon = { 221, 221, 221, 221, 221, 221, 221, 221 };

                int counter = 0;
                FileStream fs = File.OpenRead(chooseFile.FileName);
                byte[] b = new byte[8];

                while (fs.Read(b, 0, b.Length) > 0)
                {
                    if (Enumerable.SequenceEqual(b, etalon))
                    {
                        byte[] m = new byte[8]; //пропускаем 8 байт
                        byte[] n = new byte[8]; //нужные 8 байт
                        fs.Read(m, 0, m.Length);
                        fs.Read(n, 0, n.Length);

                        lblFixBuild.Text = "picture build: " + (n[0] + (n[1] << 8)).ToString();
                        switch (n[0] + (n[1] << 8))
                        {
                            case 5179:
                                lblVersion.Text = "3.0";
                                break;
                            case 5717:
                                lblVersion.Text = "3.5";
                                break;
                            case 6192:
                                lblVersion.Text = "4.0";
                                break;
                            case 6491:
                                lblVersion.Text = "4.5";
                                break;
                            case 6846:
                                lblVersion.Text = "5.1";
                                break;
                            case 10179:
                                lblVersion.Text = "5.5";
                                break;
                            case 10383:
                                lblVersion.Text = "5.8";
                                break;
                            case 10843:
                                lblVersion.Text = "5.9";
                                break;
                            case 11109:
                                lblVersion.Text = "6.0";
                                break;
                            default:
                                lblVersion.Text = "XZ";
                                break;
                        }
                    }

                    counter = counter + 8;

                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Strider757/GetVerIfix");
        }

        private void picBuildsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int picbuildMenu = (this.Width == 349) ? this.Width = 470 : this.Width = 349;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Width = 349;
        }
    }
}


