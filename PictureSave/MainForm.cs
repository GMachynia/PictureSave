using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PictureSave
{ 
    public partial class MainForm : Form

    {
        private string myPath;
        private string myNewPath;   
        private string myPicturePath;
        private string myPictureNewPath;
        private int pictureNum = 0;
        private Bitmap myBitMap;

        public static void InfoToFile(string pathA, string pathB, string pathAN)
        {
            
            string Data = String.Empty;
            string path = $"{pathA}\\PictureSaveInfo.txt";
            DateTime thisDay = DateTime.Now;
            Data = thisDay.ToString("g");
            using (StreamWriter stream = new StreamWriter(path, true))
            {
                stream.WriteLine( $"Data: {Data} - PathA: {pathAN} -> PathB: {pathB}");
            }    
        }

        public MainForm()
        {       
            InitializeComponent();     
        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChooseSourceBtn_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {      
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    ChooseSourceBtn.BackColor = Color.MediumSeaGreen;
                    ChooseSourceLabel.Text = fbd.SelectedPath;
                    myPath = ChooseSourceLabel.Text;
                    
                }
            }
            try
            {
                DirectoryInfo di = new DirectoryInfo(myPath);
                FileInfo[] fi = di.GetFiles("*.jpg");
                pictureBox1.Load(myPath + "\\" + fi.First());
                myPictureNewPath = myPath + "\\" + fi.First();
                myBitMap = new Bitmap(myPictureNewPath);
                PreviousPicBtn.BackColor = Color.OrangeRed;
            }
            catch (PathTooLongException)
            {
                ChooseSourceBtn.BackColor = Color.OrangeRed;
                MessageBox.Show("Name of path is too long. ");
            }
            catch (Exception)
            {
                ChooseSourceBtn.BackColor = Color.OrangeRed;
                MessageBox.Show("This path does not contain a jpg files.");
            }
        }

        private void ChooseDestBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    ChooseDestBtn.BackColor = Color.MediumSeaGreen;
                    ChooseDestLabel.Text = fbd.SelectedPath;
                    myNewPath = ChooseDestLabel.Text;
                }
            }
        }

        private void NextPicBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PreviousPicBtn.UseVisualStyleBackColor = true;
                SavePicBtn.UseVisualStyleBackColor = true;
                DirectoryInfo di = new DirectoryInfo(myPath);
                FileInfo[] fi = di.GetFiles("*.jpg");
                if (pictureNum > fi.Length-1) pictureNum = fi.Length-1;
                if (pictureNum >= 0 || pictureNum < fi.Length-1)
                {
                    pictureNum++;
                    myPicturePath = (string)fi[pictureNum].Name;
                    pictureBox1.Load(myPath + "\\" + myPicturePath);
                }
                if (pictureNum == fi.Length - 1)
                {
                    NextPicBtn.BackColor = Color.OrangeRed;
                }
                myPictureNewPath = myPath + "\\" + myPicturePath;
                myBitMap = new Bitmap(myPictureNewPath);
            }

            catch (ArgumentNullException ){MessageBox.Show("Choose paths of files."); }

            catch (FileNotFoundException){MessageBox.Show("Paths does not contain jpg files. "); }

            catch (PathTooLongException){MessageBox.Show("Names of paths are too long. "); }

            catch (Exception) { MessageBox.Show("There are no more jpg files. "); }

        }

        private void PreviousPicBtn_Click(object sender, EventArgs e)
        {
            try
            {
                NextPicBtn.UseVisualStyleBackColor = true;
                SavePicBtn.UseVisualStyleBackColor = true;
                DirectoryInfo di = new DirectoryInfo(myPath);
                FileInfo[] fi = di.GetFiles("*.jpg");
                if (pictureNum < 0) pictureNum = 0;
                if (pictureNum >= 0 && pictureNum <= fi.Length-1)
                {
                    pictureNum--;
                    myPicturePath = (string)fi[pictureNum].Name;
                    pictureBox1.Load(myPath + "\\" + myPicturePath);
                }
                if (pictureNum == 0)
                {
                    PreviousPicBtn.BackColor = Color.OrangeRed;
                }
                myPictureNewPath = myPath + "\\" + myPicturePath;
                
            }
            catch (ArgumentNullException){MessageBox.Show("Choose paths of files."); }

            catch (PathTooLongException) {MessageBox.Show("Names of paths are too long. "); }

            catch (Exception){ pictureNum = 0; }

        }

        private void SavePicBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SavePicBtn.BackColor = Color.MediumSeaGreen;
                FileInfo fi1 = new FileInfo(myPictureNewPath);
                FileInfo fi2 = new FileInfo(myNewPath + "\\" + "newfile.jpg");
                    if (File.Exists(myNewPath + "\\" + "newfile.jpg"))
                    {
                        fi2.Delete();
                    }
                    FileStream fs = fi2.Create();
                        fs.Close(); 
                    File.Copy(myPictureNewPath, $"{myNewPath}\\newfile.jpg", true);
                Random liczba = new Random(pictureNum);
                int nm1 = liczba.Next(1, 999);
                Random liczba1 = new Random(pictureNum);
                int nm2 = liczba1.Next(1, 1500);
                    while (File.Exists(myNewPath + "\\" + nm1 + "_" + nm2 + ".jpg"))
                    {
                        nm1 = liczba.Next(1, 999);
                        nm2 = liczba1.Next(1, 1500);
                    }
                    File.Move($"{myNewPath}\\newfile.jpg", $"{myNewPath}\\{nm1}_{nm2}.jpg");
                string pathA = myPath;
                string pathB = $"{myNewPath}\\{nm1}_{nm2}.jpg";

                InfoToFile(pathA, pathB, myPictureNewPath);
                
            }
            catch (ArgumentNullException){ ShowWarning(ChooseDestBtn, SavePicBtn, "Choose paths of files."); }

            catch (PathTooLongException) { ShowWarning(ChooseDestBtn, SavePicBtn, "Names of paths are too long. "); }

            catch (Exception) {ShowWarning(ChooseDestBtn,SavePicBtn, "Paths does not contain jpg files."); }
        }

        private void ShowWarning(Button b1, Button b2, string message)
        {
            b1.BackColor = Color.OrangeRed;
            b2.UseVisualStyleBackColor = true;
            MessageBox.Show(message);
        }

        private void RotateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
               pictureBox1.Image = myBitMap;
                if (myBitMap != null)
                {
                    myBitMap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    pictureBox1.Image = myBitMap;
                }
                
            }
            catch (ArgumentNullException){MessageBox.Show("Choose paths of files."); }

            catch (PathTooLongException){ MessageBox.Show("Names of paths are too long. "); }

            catch (Exception){MessageBox.Show("Paths does not contain jpg files."); }
        }

       
    }
}
