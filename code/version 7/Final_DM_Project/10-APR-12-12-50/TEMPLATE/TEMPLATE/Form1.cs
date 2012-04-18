using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ComponentAce.Compression.Archiver;
using ComponentAce.Compression.ZipForge;
namespace TEMPLATE
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Image image = Image.FromFile("C:\\Users\\Vyshak\\Desktop\\IMAGES\\TEMPLATE1.jpg");
            pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;
            Image image2 = Image.FromFile("C:\\Users\\Vyshak\\Desktop\\IMAGES\\TEMPLATE2.jpg");
            pictureBox3.Image = image2;
            pictureBox3.Height = image2.Height;
            pictureBox3.Width = image2.Width;
            Image image3 = Image.FromFile("C:\\Users\\Vyshak\\Desktop\\IMAGES\\TEMPLATE3.jpg");
            pictureBox4.Image = image3;
            pictureBox4.Height = image3.Height;
            pictureBox4.Width = image3.Width;
            Image image4 = Image.FromFile("C:\\Users\\Vyshak\\Desktop\\IMAGES\\TEMPLATE4.jpg");
            pictureBox5.Image = image4;
            pictureBox5.Height = image4.Height;
            pictureBox5.Width = image4.Width;

            pictureBox3.Visible = false;
            pictureBox3.Size = new Size(100, 100);
            pictureBox2.Size = new Size(100, 100);
            pictureBox4.Size = new Size(100, 100);
            pictureBox5.Size = new Size(100, 100);
            button1.Visible = false;
            pictureBox1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            textBox3.Visible = false;
            richTextBox2.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            groupBox1.Visible = false;
            textBox1.Visible = false;
            label1.Visible = false;
            button2.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox10.Visible = false;
            label6.Visible = false;
            richTextBox1.Clear();
            textBox16.Visible = false;
            groupBox2.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            toolStripButton4.Enabled = false;
            button14.Visible = false;
            button18.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button11.Visible = false;
            textBox5.Visible = false;
            groupBox6.Visible = false;
            button15.Visible = false;
            button19.Visible = false;
            richTextBox1.Clear();
            button12.Visible = false;
            button13.Visible = false;

            
            // groupBox6.Visible = false;
            //start of template one
            // int count = 0;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button9.Visible = true;
            button5.Visible = true;
            button10.Visible = true;
            Class1.tempnum = 1;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            button15.Visible = true;

            // MessageBox.Show("hello hai");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
        "All files (*.*)|*.*";
            browseFile.Title = "Browse Image file";
            if (browseFile.ShowDialog() == DialogResult.Cancel)
                return;
            string imagepath;
            imagepath = browseFile.FileName;
            string sourcePath = imagepath;
            string avail_directory = "C:\\Users\\Vyshak\\Desktop\\PROJECT";
            string newpath = Path.Combine(avail_directory, textBox1.Text);
            Directory.CreateDirectory(newpath);
            string targetPath = Path.Combine(newpath, Path.GetFileName(sourcePath));
            System.IO.File.Copy(sourcePath, targetPath, true);
            string imagepath1 = Path.Combine(newpath, Path.GetFileName(imagepath));
            Image image = Image.FromFile(imagepath1);
            if (Class1.tempnum == 1)
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Size = new Size(100, 100);

                //pictureBox2.Height = image.Height;
                // pictureBox2.Width = image.Width;
                pictureBox2.Image = image;
            }
            if (Class1.tempnum == 3)
            {
                pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox6.Size = new Size(100, 100);

                //pictureBox2.Height = image.Height;
                // pictureBox2.Width = image.Width;
                pictureBox6.Image = image;

            }
            if (Class1.tempnum == 4)
            {

                pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox7.Size = new Size(100, 100);
                pictureBox7.Image = image;
            }
            string filename = textBox1.Text;
            // string filename = textBox2.Text;
            filename += ".xml";
            string newfilename1 = Path.Combine("C:\\Users\\Vyshak\\Desktop\\PROJECT", textBox1.Text);
            string newfilename = Path.Combine(newfilename1, filename);
            FileStream aFile = new FileStream(newfilename, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);
            Class1.imagefilename = Path.GetFileName(sourcePath);
           // sw.WriteLine();
           // sw.Write("<Image>");
           // sw.Write(Path.GetFileName(sourcePath));
            //sw.WriteLine("</Image>");
            sw.Close();
            aFile.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button18.Visible = true;
            string filename = textBox1.Text;
            // string filename = textBox2.Text;
            filename += ".xml";
            string newfilename1 = Path.Combine("C:\\Users\\Vyshak\\Desktop\\PROJECT", textBox1.Text);
            Directory.CreateDirectory(newfilename1);
            string newfilename = Path.Combine(newfilename1, filename);
            FileStream aFile = new FileStream(newfilename, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);
            
            sw.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            sw.WriteLine("<Manual xmlns=\"http://www.manual.org\"");
            sw.WriteLine("xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"");
            sw.WriteLine("xsi:schemaLocation=\"http://www.manual.org proj.xsd\">");
            sw.WriteLine("<doc>");
            sw.WriteLine("");
           
            sw.Close();
            aFile.Close();
            pictureBox1.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            label1.Visible = false;
            textBox1.Visible = false;
            button2.Visible = false;
            MessageBox.Show("choose a template");


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button19.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


            if (Class1.tempnum == 1)
                textBox2.Text = textBox3.Text;
            if (Class1.tempnum == 2)
                textBox13.Text = textBox3.Text;
            if (Class1.tempnum == 3)
                textBox17.Text = textBox3.Text;

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

            //richTextBox1.(richTextBox2.Text);
            // richTextBox1.Text= richTextBox2.SelectedRtf;
            // Clipboard.SetText(richTextBox2.Text);
            //(Clipboard.SetText);
            // richTextBox1.Paste();
            //Clipboard.GetData= richTextBox2.DataBindings;
            // richTextBox1.Font = richTextBox1.Font;
            // richTextBox1.ForeColor = richTextBox2.ForeColor;
            //richTextBox1.SelectAll = richTextBox2.SelectAll;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // int a = 0;
            Class1.a++;

            if(((Class1.a)%2)==0){
            richTextBox2.SelectionFont = new Font(richTextBox2.SelectionFont, FontStyle.Bold);
            
            
            }
            else
            {
                richTextBox2.SelectionFont = new Font(richTextBox2.SelectionFont, FontStyle.Regular);
            }//richTextBox2.SelectionColor = Color.Black;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //int b
            Class1.b++;
            if (((Class1.b)%2) == 0)
            {
            richTextBox2.SelectionFont = new Font(richTextBox2.SelectionFont, FontStyle.Italic);
            //richTextBox2.SelectionColor = Color.Black;
            //Class1.b = 1;
            }
            else
            {
                 richTextBox2.SelectionFont = new Font(richTextBox2.SelectionFont, FontStyle.Regular);
                // Class1.b = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //int c = 0;
            Class1.c++;
            if(((Class1.c)%2)==0)
            {
            richTextBox2.SelectionColor = Color.Red;
            //richTextBox2.SelectionFont = new Font(richTextBox2.SelectionFont, FontStyle.Regular);
           //Class1.c = 1;
            }
            else
            {
                richTextBox2.SelectionColor = Color.Black;
                //Class1.c = 0;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {

            if (Class1.tempnum == 1)
            {//richTextBox2.Clear();
                richTextBox1.Clear();
                richTextBox2.SelectAll();
                richTextBox2.Copy();
                richTextBox1.Clear();
                richTextBox1.Paste();
            }
            if (Class1.tempnum == 3)
            {
               
                richTextBox3.Clear();
                richTextBox2.SelectAll();
                richTextBox2.Copy();
                richTextBox3.Clear();
                richTextBox3.Paste();

            }
            if (Class1.tempnum == 1)

                groupBox1.Visible = true;
            if (Class1.tempnum == 2)
            {
                richTextBox5.Clear();
                richTextBox2.SelectAll();
                richTextBox2.Copy();
                richTextBox5.Clear();
                richTextBox5.Paste();
                groupBox2.Visible = true;
            }
            if (Class1.tempnum == 3)
            {
                groupBox4.Visible = true;
                groupBox5.Visible = true;
            }
            if (Class1.tempnum == 4)
            {
                groupBox6.Visible = true;
                richTextBox4.Clear();
                richTextBox2.SelectAll();
                richTextBox2.Copy();
                richTextBox4.Clear();
                richTextBox4.Paste();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
            button2.Visible = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            textBox10.Visible = true;
            label6.Visible = true;
            button11.Visible = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Class1.correctans=textBox10.Text;
           // StringComparer("a", "");
            if ((Class1.correctans == "a") || (Class1.correctans == "A") || (Class1.correctans == "b") || (Class1.correctans == "B") || (Class1.correctans == "c") || (Class1.correctans == "C") || (Class1.correctans == "d") || (Class1.correctans == "D"))
            {
               
            }
            else
            {
                MessageBox.Show("Enter Valid Option!");
            }
            if (Class1.tempnum == 1)
            {
                textBox11.Text = textBox5.Text;
                radioButton1.Text = textBox6.Text;
                radioButton2.Text = textBox7.Text;
                radioButton3.Text = textBox8.Text;
                radioButton4.Text = textBox9.Text;
            }
            if (Class1.tempnum == 2)
            {
                textBox15.Text = textBox5.Text;
                radioButton5.Text = textBox6.Text;
                radioButton6.Text = textBox7.Text;
                radioButton7.Text = textBox8.Text;
                radioButton8.Text = textBox9.Text;
            }
            if (Class1.tempnum == 3)
            {
                textBox18.Text = textBox5.Text;
                radioButton9.Text = textBox6.Text;
                radioButton10.Text = textBox7.Text;
                radioButton11.Text = textBox8.Text;
                radioButton12.Text = textBox9.Text;
            }
            // try
            /*{

                string filename = textBox1.Text;
                filename += ".xml";
               // int k = 0;
                string newfilename1 = Path.Combine("C:\\Users\\Vyshak\\Desktop\\PROJECT", textBox1.Text);
                Directory.CreateDirectory(newfilename1);
                string newfilename = Path.Combine(newfilename1, filename);
                FileStream aFile = new FileStream(newfilename, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(aFile);
                
            }*/
            //  catch (Exception ex)
            // {
            // MessageBox.Show("ENTER FOUR OPTIONS FOR ANSWER");
            // }

        }


        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to request a file to open.
            OpenFileDialog openFile1 = new OpenFileDialog();
            //this.button13.Click += new System.EventHandler(this.button13_Click);
            // Initialize the OpenFileDialog to look for RTF files.

            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                richTextBox2.LoadFile(openFile1.FileName, RichTextBoxStreamType.RichText);

            }


        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            // browseFile.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
            //"All files (*.*)|*.*";
            browseFile.Filter = "Video Files (.ASF, .AVI, .MPG, .MPEG, .VOB, .QT, .WMV)|*.ASF;*.AVI;*.MPG;*.MPEG;*" +
        ".VOB;*.QT;*.WMV|All Files (*.*)|*.*";
            browseFile.Title = "Browse Video file";
            if (browseFile.ShowDialog() == DialogResult.Cancel)
                return;
            string imagepath;
            imagepath = browseFile.FileName;
            string sourcePath = imagepath;
            string avail_directory = "C:\\Users\\Vyshak\\Desktop\\PROJECT";
            string newpath = Path.Combine(avail_directory, textBox1.Text);
            Directory.CreateDirectory(newpath);
            string targetPath = Path.Combine(newpath, Path.GetFileName(sourcePath));
            System.IO.File.Copy(sourcePath, targetPath, true);
            textBox16.Text = targetPath;
            Class1.videopath = targetPath;
            toolStripButton1.Enabled = true;
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;

            // axWindowsMediaPlayer1.URL = textBox16.Text;

            string filename = textBox1.Text;
            // string filename = textBox2.Text;
            filename += ".xml";
            string newfilename1 = Path.Combine("C:\\Users\\Vyshak\\Desktop\\PROJECT", textBox1.Text);
            string newfilename = Path.Combine(newfilename1, filename);
            FileStream aFile = new FileStream(newfilename, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);

           
            Class1.videofilename = Path.GetFileName(sourcePath);
           // sw.WriteLine();
           // sw.Write("<Video>");
            //sw.Write(Class1.videofilename);
           // sw.WriteLine("</Video>");
            //sw.Close();
            aFile.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Class1.count++;
            if (Class1.count == 1)
            {
                axWindowsMediaPlayer1.URL =Class1.videopath;
                toolStripButton1.Enabled = false;
                toolStripButton2.Enabled = true;
                toolStripButton3.Enabled = true;
            }
            else
            { // axWindowsMediaPlayer1.URL = textBox16.Text;
                toolStripButton1.Enabled = false;
                toolStripButton2.Enabled = true;
                toolStripButton3.Enabled = true;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            toolStripButton1.Enabled = true;
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = true;
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            toolStripButton2.Enabled = false;
            toolStripButton1.Enabled = true;
            toolStripButton3.Enabled = false;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            button14.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button9.Visible = true;
            button5.Visible = true;
            button15.Visible = true;
            button10.Visible = true;


            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            Class1.tempnum = 2;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //****************************
            string filename = textBox1.Text;
            string filename1 = filename;
            filename += ".xml";
            filename1 += ".rtf";
            string newfilename1 = Path.Combine("C:\\Users\\Vyshak\\Desktop\\PROJECT", textBox1.Text);
            Directory.CreateDirectory(newfilename1);
            string newfilename = Path.Combine(newfilename1, filename);
            string newfilenamertf = Path.Combine(newfilename1, filename1);
            FileStream aFile = new FileStream(newfilename, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);
            sw.WriteLine("<Tempnum>"+Class1.tempnum+"</Tempnum>");
            sw.WriteLine("<Text>" + textBox3.Text + "</Text>");
            sw.WriteLine("<Richtext>" + filename1 + "</Richtext>");

            string str = richTextBox1.Text;
            richTextBox2.SaveFile(newfilenamertf, RichTextBoxStreamType.RichText);

            sw.Close();
            this.Close();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            // groupBox8.Visible = true;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            button1.Visible = true;
            button3.Visible = true;
            button14.Visible = true;
            button17.Visible = true;
            button9.Visible = true;
            button15.Visible = true;
            Class1.tempnum = 4;

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            button1.Visible = true;
            button3.Visible = true;
            button16.Visible = true;
            button15.Visible = true;
            button5.Visible = true;
            button9.Visible = true;
            button5.Visible = true;
            button10.Visible = true;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            Class1.tempnum = 3;
           
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Filter =  "All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | WMAs | *.wma";
            // browseFile.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
            //"All files (*.*)|*.*";
            browseFile.Title = "Browse Audio file";
            if (browseFile.ShowDialog() == DialogResult.Cancel)
                return;
            string imagepath;
            imagepath = browseFile.FileName;
            string sourcePath = imagepath;
            string avail_directory = "C:\\Users\\Vyshak\\Desktop\\PROJECT";
            string newpath = Path.Combine(avail_directory, textBox1.Text);
            Directory.CreateDirectory(newpath);
            string targetPath = Path.Combine(newpath, Path.GetFileName(sourcePath));
            System.IO.File.Copy(sourcePath, targetPath, true);
            toolStripButton4.Enabled = true;
            toolStripButton5.Enabled = false;
            toolStripButton6.Enabled = false;

            Class1.audiopath = targetPath;
            string filename = textBox1.Text;
            // string filename = textBox2.Text;
            filename += ".xml";
            string newfilename1 = Path.Combine("C:\\Users\\Vyshak\\Desktop\\PROJECT", textBox1.Text);
            string newfilename = Path.Combine(newfilename1, filename);
            FileStream aFile = new FileStream(newfilename, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);
            //sw.WriteLine();
            //sw.Write("<Audio>");
            //Class1.audiopath = Path.GetFileName(sourcePath);

            //sw.Write(Class1.audiopath);
            //sw.WriteLine("</Audio>");
            sw.Close();
            aFile.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            //axWindowsMediaPlayer2.URL = Class1.audiopath;
            Class1.countaudio++;
            if (Class1.countaudio == 1)
            {
                axWindowsMediaPlayer2.URL = Class1.audiopath;
                toolStripButton4.Enabled = false;
                toolStripButton5.Enabled = true;
                toolStripButton6.Enabled = true;
            }
            else
            { // axWindowsMediaPlayer1.URL = textBox16.Text;
                toolStripButton4.Enabled = false;
                toolStripButton5.Enabled = true;
                toolStripButton6.Enabled = true;
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            toolStripButton4.Enabled = true;
            toolStripButton5.Enabled = false;
            toolStripButton6.Enabled = true;
            axWindowsMediaPlayer2.Ctlcontrols.pause();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.stop();
            toolStripButton4.Enabled = true;
            toolStripButton5.Enabled = false;
            toolStripButton6.Enabled = false;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void axShockwaveFlash1_Enter(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            //browseFile.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
        //"All files (*.*)|*.*";
            browseFile.Filter = "Flash (.swf)|*.swf" ;
            browseFile.Title = "Browse Flash file";
            if (browseFile.ShowDialog() == DialogResult.Cancel)
                return;
            string imagepath;
            imagepath = browseFile.FileName;
            string sourcePath = imagepath;
            string avail_directory = "C:\\Users\\Vyshak\\Desktop\\PROJECT";
            string newpath = Path.Combine(avail_directory, textBox1.Text);
            Directory.CreateDirectory(newpath);
            string targetPath = Path.Combine(newpath, Path.GetFileName(sourcePath));
            System.IO.File.Copy(sourcePath, targetPath, true);
            string filename = textBox1.Text;
            Class1.flashpath = targetPath;
            // string filename = textBox2.Text;
            filename += ".xml";
            string newfilename1 = Path.Combine("C:\\Users\\Vyshak\\Desktop\\PROJECT", textBox1.Text);
            string newfilename = Path.Combine(newfilename1, filename);
            FileStream aFile = new FileStream(newfilename, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);
            sw.WriteLine();
            sw.Write("<Flash>");
            sw.Write(Path.GetFileName(sourcePath));
            sw.Write("</Flash>");
            sw.Close();
            aFile.Close();
            axShockwaveFlash1.Movie = Class1.flashpath;
            axShockwaveFlash1.Size = new System.Drawing.Size(100, 100);
            axShockwaveFlash1.Play();
        }

        private void axShockwaveFlash1_Enter_1(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer3_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Class1.count++;
            if (Class1.count == 1)
            {
                axWindowsMediaPlayer3.URL = Class1.videopath;
                toolStripButton7.Enabled = false;
                toolStripButton8.Enabled = true;
                toolStripButton9.Enabled = true;
            }
            else
            { // axWindowsMediaPlayer1.URL = textBox16.Text;
                toolStripButton7.Enabled = false;
                toolStripButton8.Enabled = true;
                toolStripButton9.Enabled = true;
                axWindowsMediaPlayer3.Ctlcontrols.play();
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            toolStripButton7.Enabled = true;
            toolStripButton8.Enabled = false;
            toolStripButton9.Enabled = true;
            axWindowsMediaPlayer3.Ctlcontrols.pause();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.Ctlcontrols.stop();
            toolStripButton8.Enabled = false;
            toolStripButton7.Enabled = true;
            toolStripButton9.Enabled = false;
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {


        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            //****************************
            string filename = textBox1.Text;
            string filename1 = filename;
            string filename2 = textBox1.Text;
            filename += ".xml";
            filename1 += ".rtf";
            filename2 += ".zip";
            string newfilename1 = Path.Combine("C:\\Users\\Vyshak\\Desktop\\PROJECT", textBox1.Text);
            string newfilenamezip = Path.Combine("C:\\Users\\Vyshak\\Desktop\\PROJECT", filename2);
            Directory.CreateDirectory(newfilename1);
            string newfilename = Path.Combine(newfilename1, filename);
            string newfilenamertf = Path.Combine(newfilename1, filename1);
            FileStream aFile = new FileStream(newfilename, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);
            sw.WriteLine("<Tempnum>" + Class1.tempnum + "</Tempnum>");
            if ((Class1.tempnum == 1) || (Class1.tempnum == 2))
                sw.WriteLine("<Text>" + textBox3.Text + "</Text>");
            if((Class1.tempnum==2)||(Class1.tempnum==4))
            {
            //
            sw.WriteLine();
            sw.Write("<Video>");
            sw.Write(Class1.videofilename);
            sw.WriteLine("</Video>");
           


            //
            }
            if((Class1.tempnum==1)||(Class1.tempnum==3)||(Class1.tempnum==4))
            {
            //
                 sw.WriteLine();
            sw.Write("<Image>");
            sw.Write(Class1.imagefilename);
            sw.WriteLine("</Image>");
            //
            }
            if(Class1.tempnum==3)
            {
            //
            sw.WriteLine();
            sw.Write("<Audio>");
            //Class1.audiopath = Path.GetFileName(sourcePath);

            sw.Write(Class1.audiopath);
            sw.WriteLine("</Audio>");

            //
            }

            sw.WriteLine("<Richtext>" + filename1 + "</Richtext>");
            if ((Class1.tempnum == 1) || (Class1.tempnum == 2) || (Class1.tempnum == 3))
            {
                string question = textBox5.Text;
                sw.WriteLine("<QA><QUESTION>" + question + "</QUESTION>");
                string answer1 = textBox6.Text;
                string answer2 = textBox7.Text;
                string answer3 = textBox8.Text;
                string answer4 = textBox9.Text;
                string correctanswer = textBox10.Text;

                                
                    sw.WriteLine("<ANSWER1>" + answer1 + "</ANSWER1>");
                    sw.WriteLine("<ANSWER2>" + answer2 + "</ANSWER2>");
                    sw.WriteLine("<ANSWER3>" + answer3 + "</ANSWER3>");
                    sw.WriteLine("<ANSWER4>" + answer4 + "</ANSWER4>");
                    sw.WriteLine("<CORRECTANSWER>" + correctanswer + "</CORRECTANSWER></QA>");
                    

                                
            }
            sw.WriteLine("</doc></Manual>");
            string str = richTextBox1.Text;
            richTextBox2.SaveFile(newfilenamertf, RichTextBoxStreamType.RichText);
            sw.Close();
            //ZIPPING FILE
            ZipForge archiver = new ZipForge();

            try
            {
                // Set the name of the archive file we want to create
                archiver.FileName = newfilenamezip;
                // Because we create a new archive, 
                archiver.Password = "iiitb";
                // we set fileMode to System.IO.FileMode.Create
                archiver.OpenArchive(System.IO.FileMode.Create);
                // Set base (default) directory for all archive operations
                archiver.BaseDir = @"C:\Users\Vyshak\Desktop\PROJECT";
                // Add the c:\Test folder to the archive with all subfolders
                archiver.AddFiles(newfilename1);
                archiver.CloseArchive();
            }
            // Catch all exceptions of the ArchiverException type
            catch (ArchiverException ae)
            {
                Console.WriteLine("Message: {0}\t Error code: {1}",
                                  ae.Message, ae.ErrorCode);
                // Wait for the  key to be pressed
                Console.ReadLine();
            }
            //ZIP COMPLETE
            this.Close();
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Class1.d++;
            if (((Class1.d) % 2) == 0)
            {
                richTextBox2.SelectionFont = new Font(richTextBox2.SelectionFont, FontStyle.Underline);
                //richTextBox2.SelectionColor = Color.Black;
                //Class1.b = 1;
            }
            else
            {
                richTextBox2.SelectionFont = new Font(richTextBox2.SelectionFont, FontStyle.Regular);
                // Class1.b = 0;
            }
        }
    }
}