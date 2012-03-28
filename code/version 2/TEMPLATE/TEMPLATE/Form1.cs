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
            Image image = Image.FromFile("C:\\Users\\eashwar\\Desktop\\TEMPLATE1.jpg");
            pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;
            pictureBox2.Size = new Size(100, 100);
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
            string avail_directory = "C:\\Users\\eashwar\\Desktop\\PROJECT";
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
            string newfilename1 = Path.Combine("C:\\Users\\eashwar\\Desktop\\PROJECT", textBox1.Text);
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
            textBox2.Text = textBox3.Text;
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
            //richTextBox2.Clear();
            richTextBox1.Clear();
            richTextBox2.SelectAll();
            richTextBox2.Copy();
            richTextBox1.Clear();
            richTextBox1.Paste();


            groupBox1.Visible = true;

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
            textBox11.Text = textBox5.Text;
            radioButton1.Text = textBox6.Text;
            radioButton2.Text = textBox7.Text;
            radioButton3.Text = textBox8.Text;
            radioButton4.Text = textBox9.Text;
            try
            {
                string filename = textBox1.Text;
                filename += ".xml";
                string newfilename1 = Path.Combine("C:\\Users\\eashwar\\Desktop\\PROJECT", textBox1.Text);
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
                sw.WriteLine("<Item><ANSWER>" + answer1 + "</ANSWER></Item>");
                sw.WriteLine("<Item><ANSWER>" + answer2 + "</ANSWER></Item>");
                sw.WriteLine("<Item><ANSWER>" + answer3 + "</ANSWER></Item>");
                sw.WriteLine("<Item><ANSWER>" + answer4 + "</ANSWER></Item>");
                sw.WriteLine("<Item><CORRECTANSWER>" + correctanswer + "</CORRECTANSWER></Item>");
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ENTER FOUR OPTIONS FOR ANSWER");
            }

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
                    /*if (dlgSave.ShowDialog() == DialogResult.OK && dlgSave.FileName.Length > 0)
                    {
                        // Save file as utf8 without byte order mark (BOM)
                        // ref: http://msdn.microsoft.com/en-us/library/s064f8w2.aspx
                        UTF8Encoding utf8 = new UTF8Encoding();
                        StreamWriter sw = new StreamWriter(dlgSave.FileName, false, utf8);
                        sw.Write(str);
                        sw.Close();
                    }*/

                    //my section(temporary)
                    if (dlgSave.ShowDialog() == DialogResult.OK)
                    {
                        // Save as .txt file
                        if (Path.GetExtension(dlgSave.FileName) == ".txt")
                        {
                            richTextBox1.SaveFile(dlgSave.FileName, RichTextBoxStreamType.PlainText);
                        }
                        // Save as .rtf file
                        if (Path.GetExtension(dlgSave.FileName) == ".rtf")
                        {
                            richTextBox1.SaveFile(dlgSave.FileName, RichTextBoxStreamType.PlainText);
                        }
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
    }
}