using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Windows.Forms;
using System.IO;
//using System.Text;
namespace Forms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
            textBox6.Visible = false;
            button6.Visible = false;
            label1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label1.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible =false;
            button11.Visible = false;
            button12.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = textBox6.Text;
            // string filename = textBox6.Text;
            string avail_directory = "C:\\Users\\ANILGADU\\Desktop\\target";
            string newpath = Path.Combine(avail_directory, textBox6.Text);
            Directory.CreateDirectory(newpath);
            //string targetPath = Path.Combine(newpath, Path.GetFileName(sourcePath));
            filename += ".xml";
            string newfilename1 = Path.Combine("C:\\Users\\ANILGADU\\Desktop\\target", textBox6.Text);
            string newfilename = Path.Combine(newfilename1, filename);
            FileStream aFile = new FileStream(newfilename, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);        
            //FileStream aFile = new FileStream("C:\\Users\\ANILGADU\\Desktop\\target\\a.xml", FileMode.Append, FileAccess.Write);
            //StreamWriter sw = new StreamWriter(aFile);
            sw.WriteLine();
            sw.Write("<Item><Text>");
            sw.Write(textBox1.Text);
            sw.Write("</Text></Item>");
            sw.Close();
            aFile.Close();
            textBox1.Text = null;
            textBox1.Visible = false;
            button1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //String filename;
            try
            {
                OpenFileDialog browseFile = new OpenFileDialog();
                browseFile.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
            "All files (*.*)|*.*";
                browseFile.Title = "Browse Image file";
                if (browseFile.ShowDialog() == DialogResult.Cancel)
                    return;
                //string newfilename = Path.Combine(Application.StartupPath,Path.GetFileName(oldfilename ));
                textBox2.Text = browseFile.FileName;
                string sourcePath = textBox2.Text;
                string avail_directory = "C:\\Users\\ANILGADU\\Desktop\\target";
                string newpath = Path.Combine(avail_directory, textBox6.Text);
                Directory.CreateDirectory(newpath);
                string targetPath = Path.Combine(newpath, Path.GetFileName(sourcePath));
                System.IO.File.Copy(sourcePath, targetPath, true);
                //string sourcePath = textBox2.Text;
                //string targetPath = Path.Combine("C:\\Users\\ANILGADU\\Desktop\\target", Path.GetFileName(sourcePath));
               // System.IO.File.Copy(sourcePath, targetPath, true);
                MessageBox.Show("Added Sucessfully");
                string filename = textBox6.Text;
                // string filename = textBox6.Text;
                filename += ".xml";
                string newfilename1 = Path.Combine("C:\\Users\\ANILGADU\\Desktop\\target", textBox6.Text);
                string newfilename = Path.Combine(newfilename1, filename);
                FileStream aFile = new FileStream(newfilename, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(aFile);
                //FileStream aFile = new FileStream("C:\\Users\\ANILGADU\\Desktop\\target\\a.xml", FileMode.Append, FileAccess.Write);
                //StreamWriter sw = new StreamWriter(aFile);
                sw.WriteLine();
                sw.Write("<Item><Image>");
                sw.Write(Path.GetFileName(sourcePath));
                sw.Write("</Image></Item>");
                sw.Close();
                aFile.Close();
                button2.Visible = false;
                textBox2.Visible = false;
            }
            catch (Exception ex)
            {
                System.Console.Write("please choose approiate Item");
            }
                    
         }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Filter = "All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | WMAs | *.wma";
            browseFile.Title = "Browse Audio file";
            if (browseFile.ShowDialog() == DialogResult.Cancel)
                return;
            textBox4.Text = browseFile.FileName;
            //***************************
            string sourcePath = textBox4.Text;
            string avail_directory = "C:\\Users\\ANILGADU\\Desktop\\target";
            string newpath = Path.Combine(avail_directory, textBox6.Text);
            Directory.CreateDirectory(newpath);
            string targetPath = Path.Combine(newpath, Path.GetFileName(sourcePath));
            System.IO.File.Copy(sourcePath, targetPath, true);
            //***************************
            //string sourcePath = textBox4.Text;
            //string targetPath = Path.Combine("C:\\Users\\ANILGADU\\Desktop\\target", Path.GetFileName(sourcePath));
            //System.IO.File.Copy(sourcePath, targetPath, true);
            MessageBox.Show("Added Sucessfully");
            string filename = textBox6.Text;
            // string filename = textBox6.Text;
            filename += ".xml";
            string newfilename1 = Path.Combine("C:\\Users\\ANILGADU\\Desktop\\target", textBox6.Text);
            string newfilename = Path.Combine(newfilename1, filename);
            FileStream aFile = new FileStream(newfilename, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);
            //FileStream aFile = new FileStream("C:\\Users\\ANILGADU\\Desktop\\target\\a.xml", FileMode.Append, FileAccess.Write);
           // StreamWriter sw = new StreamWriter(aFile);
            sw.WriteLine();
            sw.Write("<Item><Audio>");
            sw.Write(Path.GetFileName(sourcePath));
            sw.Write("</Audio></Item>");
            sw.Close();
            aFile.Close();
            button4.Visible = false;
            textBox4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Filter = "Video Files (.ASF, .AVI, .MPG, .MPEG, .VOB, .QT, .WMV)|*.ASF;*.AVI;*.MPG;*.MPEG;*" +
        ".VOB;*.QT;*.WMV|All Files (*.*)|*.*";
            browseFile.Title = "Browse video file";
            if (browseFile.ShowDialog() == DialogResult.Cancel)
                return;
            textBox3.Text = browseFile.FileName;
            //string sourcePath = textBox3.Text;
            //*******************************
            string sourcePath = textBox3.Text;
            string avail_directory = "C:\\Users\\ANILGADU\\Desktop\\target";
            string newpath = Path.Combine(avail_directory, textBox6.Text);
            Directory.CreateDirectory(newpath);
            string targetPath = Path.Combine(newpath, Path.GetFileName(sourcePath));
            System.IO.File.Copy(sourcePath, targetPath, true);
            //*******************************
            //string targetPath = Path.Combine("C:\\Users\\ANILGADU\\Desktop\\target", Path.GetFileName(sourcePath));
           // System.IO.File.Copy(sourcePath, targetPath, true);
            MessageBox.Show("Added Sucessfully");
            string filename = textBox6.Text;
           // string filename = textBox6.Text;
            filename += ".xml";
            string newfilename1 = Path.Combine("C:\\Users\\ANILGADU\\Desktop\\target", textBox6.Text);
            string newfilename = Path.Combine(newfilename1, filename);
            FileStream aFile = new FileStream(newfilename, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);
            sw.WriteLine();
            sw.Write("<Item><video>");
            sw.Write(Path.GetFileName(sourcePath));
            sw.Write("</video></Item>");
            sw.Close();
            aFile.Close();
            button3.Visible = false;
            textBox3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Filter = "Flash (.flash)|*.flash";
            browseFile.Title = "Browse flash file";
            if (browseFile.ShowDialog() == DialogResult.Cancel)
                       return;
            textBox5.Text = browseFile.FileName;
            //*************************************************
            string sourcePath = textBox5.Text;
            string avail_directory = "C:\\Users\\ANILGADU\\Desktop\\target";
            string newpath = Path.Combine(avail_directory, textBox6.Text);
            Directory.CreateDirectory(newpath);
            string targetPath = Path.Combine(newpath, Path.GetFileName(sourcePath));
            System.IO.File.Copy(sourcePath, targetPath, true);
            //*************************************************
            //string sourcePath = textBox3.Text;
            //string targetPath = Path.Combine("C:\\Users\\ANILGADU\\Desktop\\target", Path.GetFileName(sourcePath));
           // System.IO.File.Copy(sourcePath, targetPath, true);
            MessageBox.Show("Added Sucessfully");
           // string filename=textBox6.Text;
           // string newfilename = Path.Combine("C:\\Users\\ANILGADU\\Desktop\\target", filename);
            string filename = textBox6.Text;
            filename += ".xml";
            string newfilename1 = Path.Combine("C:\\Users\\ANILGADU\\Desktop\\target", textBox6.Text);
            string newfilename = Path.Combine(newfilename1, filename);
            FileStream aFile = new FileStream(newfilename, FileMode.Append, FileAccess.Write);
            // FileStream aFile = new FileStream("C:\\Users\\ANILGADU\\Desktop\\target\\a.xml", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);
            sw.WriteLine();
            sw.Write("<Item><Flash>");
            sw.Write(Path.GetFileName(sourcePath));
            sw.Write("</Flash></Item>");
            sw.Close();
            aFile.Close();
            button5.Visible = false;
            textBox5.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox6.Visible = true;
            button6.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sourcePath = textBox6.Text;
            string avail_directory = "C:\\Users\\ANILGADU\\Desktop\\target";
            string newpath = Path.Combine(avail_directory, textBox6.Text);
            Directory.CreateDirectory(newpath);
            //string targetPath = Path.Combine(newpath, Path.GetFileName(sourcePath));
            //System.IO.File.Copy(sourcePath, targetPath, true);
            //*************************************************
            //string sourcePath = textBox3.Text;
            //string targetPath = Path.Combine("C:\\Users\\ANILGADU\\Desktop\\target", Path.GetFileName(sourcePath));
            // System.IO.File.Copy(sourcePath, targetPath, true);
            //MessageBox.Show("Added Sucessfully");
            // string filename=textBox6.Text;
            // string newfilename = Path.Combine("C:\\Users\\ANILGADU\\Desktop\\target", filename);
            string filename = textBox6.Text;
            filename += ".xml";
           
            string newfilename1 = Path.Combine("C:\\Users\\ANILGADU\\Desktop\\target", textBox6.Text);
            string newfilename = Path.Combine(newfilename1, filename);
            FileStream aFile = new FileStream(newfilename, FileMode.Append, FileAccess.Write);
            // FileStream aFile = new FileStream("C:\\Users\\ANILGADU\\Desktop\\target\\a.xml", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);
            //sw.WriteLine();
            sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sw.WriteLine("<?xml-stylesheet type=\"text/xsl\" href=\"XML2HTML.xsl\"?>");
            sw.Write("<document>");
            sw.Close();
            aFile.Close();
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible =true;
            button6.Visible = false;
            label2.Visible = false;
            textBox6.Visible = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox4.Visible = true;
            button4.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button1.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            button3.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox5.Visible = true;
            button5.Visible = true;
        }

        private void nEWToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox6.Visible = true;
            button6.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            button2.Visible = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string filename = textBox6.Text;
            filename += ".xml";
            string newfilename1 = Path.Combine("C:\\Users\\ANILGADU\\Desktop\\target", textBox6.Text);
            string newfilename = Path.Combine(newfilename1, filename);
            FileStream aFile = new FileStream(newfilename, FileMode.Append, FileAccess.Write);
            // FileStream aFile = new FileStream("C:\\Users\\ANILGADU\\Desktop\\target\\a.xml", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);
            sw.WriteLine("</document>");
            sw.Close();
            //string filename1 = textBox6.Text;
           string filename1= "XML2HTML.xsl";
            string newfilename2 = Path.Combine(newfilename1, filename1);
            FileStream aFile1 = new FileStream(newfilename2, FileMode.Append, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(aFile1);
            sw1.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\" ?>");
            sw1.WriteLine("<xsl:stylesheet version=\"1.0\" xmlns:xsl=\"http://www.w3.org/1999/XSL/Transform\">");
            sw1.WriteLine("<xsl:output omit-xml-declaration=\"yes\"/>");
            sw1.WriteLine("<xsl:template match=\"/\">");
            sw1.WriteLine("<html>");
            sw1.WriteLine("<body>");	 
            sw1.WriteLine("<xsl:for-each select=\"document/Item\">");
            sw1.WriteLine("<td bgcolor=\"cyan\"><xsl:value-of select=\"Text\"/></td>");
            sw1.WriteLine("<xsl:variable name=\"link\" select=\"Image\" />");
            sw1.WriteLine("<img src=\"{$link}\"  height=\"200\" width=\"200\" />");
            sw1.WriteLine("<xsl:variable name=\"link2\" select=\"Audio\" />");
            sw1.WriteLine("<object height=\"50px\" width=\"500px\" data=\"{$link2}\" autoplay=\"false\"/>");
            sw1.WriteLine("<xsl:variable name=\"link3\" select=\"video\" />");
            sw1.WriteLine("<object height=\"500px\" width=\"500px\" data=\"{$link3}\" autoplay=\"false\"/>");
            sw1.WriteLine("</xsl:for-each>");
            sw1.WriteLine("</body>");
            sw1.WriteLine("</html>");
            sw1.WriteLine("</xsl:template>");
            sw1.WriteLine("</xsl:stylesheet>");
            sw1.Close();

        }

       
    }
}
