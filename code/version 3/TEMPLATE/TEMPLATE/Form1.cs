using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace TEMPLATE
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Image image = Image.FromFile("C:\\Users\\anilgontla\\Desktop\\TEMPLATE1.jpg");
            pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;
            Image image2 = Image.FromFile("C:\\Users\\anilgontla\\Desktop\\template2.jpg");
            pictureBox3.Image = image2;
            pictureBox3.Height = image2.Height;
            pictureBox3.Width = image2.Width;
            Image image3 = Image.FromFile("C:\\Users\\anilgontla\\Desktop\\template3.jpg");
            pictureBox4.Image = image3;
            pictureBox4.Height = image3.Height;
            pictureBox4.Width = image3.Width;
            Image image4 = Image.FromFile("C:\\Users\\anilgontla\\Desktop\\template4.jpg");
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
            string avail_directory = "C:\\Users\\anilgontla\\Desktop\\PROJECT";
            string newpath = Path.Combine(avail_directory, textBox1.Text);
            Directory.CreateDirectory(newpath);
            string targetPath = Path.Combine(newpath, Path.GetFileName(sourcePath));
            System.IO.File.Copy(sourcePath, targetPath, true);
            string imagepath1 = Path.Combine(newpath, Path.GetFileName(imagepath));
            Image image = Image.FromFile(imagepath1);

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Size = new Size(100, 100);

            //pictureBox2.Height = image.Height;
            // pictureBox2.Width = image.Width;
            pictureBox2.Image = image;
            string filename = textBox1.Text;
            // string filename = textBox2.Text;
            filename += ".xml";
            string newfilename1 = Path.Combine("C:\\Users\\anilgontla\\Desktop\\PROJECT", textBox1.Text);
            string newfilename = Path.Combine(newfilename1, filename);
            FileStream aFile = new FileStream(newfilename, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);
            sw.WriteLine();
            sw.Write("<Item><Image>");
            sw.Write(Path.GetFileName(sourcePath));
            sw.Write("</Image></Item>");
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
            pictureBox1.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
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
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
            
            if(Class1.tempnum==1)
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
            richTextBox2.SelectionFont = new Font(richTextBox2.SelectionFont, FontStyle.Bold);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox2.SelectionFont = new Font(richTextBox2.SelectionFont, FontStyle.Italic);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox2.SelectionColor = Color.Red;
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
            if(Class1.tempnum==1)

            groupBox1.Visible = true;
            if (Class1.tempnum == 2)
                groupBox2.Visible = true;
            if (Class1.tempnum == 3)
            {
                groupBox4.Visible = true;
                groupBox5.Visible = true;
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
            {
               
                string filename = textBox1.Text;
                filename += ".xml";
                int k=0;
                string newfilename1 = Path.Combine("C:\\Users\\anilgontla\\Desktop\\PROJECT", textBox1.Text);
                Directory.CreateDirectory(newfilename1);
                string newfilename = Path.Combine(newfilename1, filename);
                FileStream aFile = new FileStream(newfilename, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(aFile);
                string question = textBox5.Text;
                sw.WriteLine("<Item><QUESTION>" + question + "</QUESTION></Item>");
                string answer1 = textBox6.Text;
                string answer2 = textBox7.Text;
                string answer3 = textBox8.Text;
                string answer4 = textBox9.Text;
                string correctanswer = textBox10.Text;
               // if ((textBox10.Text=="A") || (textBox10.Text != "B") || (textBox10.Text != "C") || (textBox10.Text != "D") || (textBox10.Text != "a") || (textBox10.Text != "b") || (textBox10.Text != "c") || (textBox10.Text != "d"))
               // {
                    
                   // MessageBox.Show("ENTER CORRECT OPTION FOR CHOICE");

                   // sw.Close();
                   // k=1;
                    
              //  }
              //  else
                {
                    if (k == 1)
                    {
                        FileStream aFile1 = new FileStream(newfilename1, FileMode.Append, FileAccess.Write);
                        StreamWriter sw1 = new StreamWriter(aFile1);
                        sw1.WriteLine("<Item><ANSWER>" + answer1 + "</ANSWER></Item>");
                        sw1.WriteLine("<Item><ANSWER>" + answer2 + "</ANSWER></Item>");
                        sw1.WriteLine("<Item><ANSWER>" + answer3 + "</ANSWER></Item>");
                        sw1.WriteLine("<Item><ANSWER>" + answer4 + "</ANSWER></Item>");
                        sw1.WriteLine("<Item><CORRECTANSWER>" + correctanswer + "</CORRECTANSWER></Item>");
                        sw1.Close();
                    }
                    else if (k == 0)
                    {
                        sw.WriteLine("<Item><ANSWER>" + answer1 + "</ANSWER></Item>");
                        sw.WriteLine("<Item><ANSWER>" + answer2 + "</ANSWER></Item>");
                        sw.WriteLine("<Item><ANSWER>" + answer3 + "</ANSWER></Item>");
                        sw.WriteLine("<Item><ANSWER>" + answer4 + "</ANSWER></Item>");
                        sw.WriteLine("<Item><CORRECTANSWER>" + correctanswer + "</CORRECTANSWER></Item>");
                        sw.Close();

                    }
                }
            }
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
            string str = richTextBox1.Text;
            // Create a new SaveFileDialog object
            using (SaveFileDialog dlgSave = new SaveFileDialog())
                try
                {
                    // Available file extensions
                    //dlgSave.Filter = "All Files (*.*)|*.*";
                    // SaveFileDialog title
                    dlgSave.DefaultExt = "*.rtf";
                    dlgSave.Filter = "RTF Files|*.rtf";
                    dlgSave.Title = "Save";
                    // Show SaveFileDialog
                    if (dlgSave.ShowDialog() == DialogResult.OK && dlgSave.FileName.Length > 0)
                    {
                        // Save file as utf8 without byte order mark (BOM)
                        // ref: http://msdn.microsoft.com/en-us/library/s064f8w2.aspx
                        UTF8Encoding utf8 = new UTF8Encoding();
                        StreamWriter sw = new StreamWriter(dlgSave.FileName, false, utf8);
                        sw.Write(str);
                        sw.Close();
                    }

                }
                catch (Exception E)
                {
                    System.Console.Write("HEYYYYYYYYY");
                }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to request a file to open.
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.DefaultExt = "*.rtf";
            //openFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                richTextBox2.LoadFile(openFile1.FileName);

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
            browseFile.Title = "Browse Video file";
            if (browseFile.ShowDialog() == DialogResult.Cancel)
                return;
            string imagepath;
            imagepath = browseFile.FileName;
            string sourcePath = imagepath;
            string avail_directory = "C:\\Users\\anilgontla\\Desktop\\PROJECT";
            string newpath = Path.Combine(avail_directory, textBox1.Text);
            Directory.CreateDirectory(newpath);
            string targetPath = Path.Combine(newpath, Path.GetFileName(sourcePath));
            System.IO.File.Copy(sourcePath, targetPath, true);
            textBox16.Text = targetPath;
            toolStripButton1.Enabled = true;
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
           
           // axWindowsMediaPlayer1.URL = textBox16.Text;
            
            string filename = textBox1.Text;
            // string filename = textBox2.Text;
            filename += ".xml";
            string newfilename1 = Path.Combine("C:\\Users\\anilgontla\\Desktop\\PROJECT", textBox1.Text);
            string newfilename = Path.Combine(newfilename1, filename);
            FileStream aFile = new FileStream(newfilename, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);
            sw.WriteLine();
            sw.Write("<Item><Video>");
            sw.Write(Path.GetFileName(sourcePath));
            sw.Write("</Video></Item>");
            sw.Close();
            aFile.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Class1.count++;
            if (Class1.count == 1)
            {
                axWindowsMediaPlayer1.URL = @"C:\Users\Public\Videos\Sample Videos\Wildlife.wmv";
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
            button1.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button9.Visible = true;
            button5.Visible = true;
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
            string filename = textBox1.Text;
            filename += ".xml";
            string newfilename1 = Path.Combine("C:\\Users\\anilgontla\\Desktop\\PROJECT", textBox1.Text);
            Directory.CreateDirectory(newfilename1);
            string newfilename = Path.Combine(newfilename1, filename);
            FileStream aFile = new FileStream(newfilename, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);
            sw.WriteLine("<Item><Text>"+textBox3.Text+"</Item></Text>");
            
            sw.Close();
            this.Close();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            Class1.tempnum = 4;

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            button1.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button9.Visible = true;
            button5.Visible = true;
            button10.Visible = true;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            Class1.tempnum = 3;
            groupBox4.Visible = true;
            groupBox5.Visible = true;
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
            // browseFile.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
            //"All files (*.*)|*.*";
            browseFile.Title = "Browse Audio file";
            if (browseFile.ShowDialog() == DialogResult.Cancel)
                return;
            string imagepath;
            imagepath = browseFile.FileName;
            string sourcePath = imagepath;
            string avail_directory = "C:\\Users\\anilgontla\\Desktop\\PROJECT";
            string newpath = Path.Combine(avail_directory, textBox1.Text);
            Directory.CreateDirectory(newpath);
            string targetPath = Path.Combine(newpath, Path.GetFileName(sourcePath));
            System.IO.File.Copy(sourcePath, targetPath, true);
            Class1.audiopath = targetPath;
            string filename = textBox1.Text;
            // string filename = textBox2.Text;
            filename += ".xml";
            string newfilename1 = Path.Combine("C:\\Users\\anilgontla\\Desktop\\PROJECT", textBox1.Text);
            string newfilename = Path.Combine(newfilename1, filename);
            FileStream aFile = new FileStream(newfilename, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);
            sw.WriteLine();
            sw.Write("<Item><Audio>");
            sw.Write(Path.GetFileName(sourcePath));
            sw.Write("</Audio></Item>");
            sw.Close();
            aFile.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
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

       
    }
}