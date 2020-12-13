using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exception_2_Prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void collapse_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        string path = null;

        Button turn = new Button();
        Button change = new Button();

        private void chose_Click(object sender, EventArgs e)
        {            
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.SelectedPath;
            }

            if (path != null)
            {
                chose.Location = new Point(154, 61);

                turn.BackColor = Color.White;
                turn.FlatStyle = FlatStyle.Popup;
                turn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
                turn.Location = new Point(54, 181);
                turn.Name = "turn";
                turn.Size = new Size(159, 88);
                turn.TabIndex = 8;
                turn.Text = "Повернути картинку";
                turn.UseVisualStyleBackColor = false;
                turn.Click += new EventHandler(turn_Click);
                Controls.Add(turn);

                change.BackColor = Color.White;
                change.FlatStyle = FlatStyle.Popup;
                change.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
                change.Location = new Point(254, 181);
                change.Name = "change";
                change.Size = new Size(159, 88);
                change.TabIndex = 9;
                change.Text = "Змінити картинку";
                change.UseVisualStyleBackColor = false;
                change.Click += new EventHandler(change_Click);
                Controls.Add(change);
            }

            

        }

        string[] array;
        string[] fileName;        

        Regex regexExtForImage = new Regex("^((.bmp)|(.gif)|(.tiff?)|(.jpe?g)|(.png))$", RegexOptions.IgnoreCase);
        Bitmap bitmap;

        private void turn_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                array = Directory.GetFiles(path);
                fileName = Directory.GetFiles(path).Select(Path.GetFileName).ToArray();
                int n = 0;

                MessageBox.Show("Виберіть куди зберегти файли, якщо не вибрати, то програма збереже їх автоматично!");

                FolderBrowserDialog ofd = new FolderBrowserDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.SelectedPath;

                }

                foreach (String i in fileName)
                {
                    try
                    {
                        if (regexExtForImage.IsMatch(Path.GetExtension(i)))
                        {
                            bitmap = (Bitmap)Bitmap.FromFile(array[n]);

                            bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
                            bitmap.Save(path + "\\" + i.Split('.')[0] + "-mirrored.gif", ImageFormat.Png);
                        }
                    }
                    catch (OutOfMemoryException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        MessageBox.Show("Ваша картинка успішно повернута!");
                        n++;
                    }
                }

                Controls.Remove(turn);
                Controls.Remove(change);
                chose.Location = new Point(154, 121);
                path = null;
            }            

        }

        private void change_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                array = Directory.GetFiles(path);
                fileName = Directory.GetFiles(path).Select(Path.GetFileName).ToArray();
                int n = 0;

                MessageBox.Show("Виберіть куди зберегти файли, якщо не вибрати, то програма збереже їх автоматично!");

                FolderBrowserDialog ofd = new FolderBrowserDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.SelectedPath;
                }

                foreach (String i in fileName)
                {
                    try
                    {
                        if (regexExtForImage.IsMatch(Path.GetExtension(i)))
                        {
                            Bitmap bitmap = (Bitmap)Bitmap.FromFile(array[n]);
                            for (int j = 0; j < 200; ++j)
                            {
                                for (int j2 = 0; j2 < 200; ++j2)
                                {
                                    bitmap.SetPixel(100 + j, 400 + j2, Color.Red);
                                    bitmap.SetPixel(400 + j, 400 + j2, Color.Red);
                                }
                            }

                            bitmap.Save(path + "\\" + i.Split('.')[0] + "-mirrored.gif", ImageFormat.Png);
                        }
                    }
                    catch (OutOfMemoryException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        MessageBox.Show("Ваша картинка успішно змінена!");
                        n++;
                    }
                }

                Controls.Remove(turn);
                Controls.Remove(change);
                chose.Location = new Point(154, 121);
                path = null;
            }      

        }
        
    }
}
