using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using AMovie;
using System.IO;
using ComponentAce.Compression.ZipForge;
using ComponentAce.Compression.Archiver;


namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            button1.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
             XmlTextReader reader = new XmlTextReader(Class1.xmlfilelocation);
             while (reader.Read())
             {
                 if (reader.Name == "CORRECTANSWER")
                     //textBox3.Text = reader.ReadString();

                     if (reader.ReadString() == "A")
                     {

                         MessageBox.Show("CORRECT ANSWER");
                     }
                     else
                     {
                         MessageBox.Show("WRONG ANSWER ");
                        
                     }
             

             }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(Class1.xmlfilelocation);
            while (reader.Read())
            {
                if (reader.Name == "CORRECTANSWER")
                    //textBox3.Text = reader.ReadString();

                    if (reader.ReadString() == "B")
                    {

                        MessageBox.Show("CORRECT ANSWER");
                    }
                    else
                    {
                        MessageBox.Show("WRONG ANSWER ");

                    }


            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(Class1.xmlfilelocation);
            while (reader.Read())
            {
                if (reader.Name == "CORRECTANSWER")
                    //textBox3.Text = reader.ReadString();

                    if (reader.ReadString() == "C")
                    {

                        MessageBox.Show("CORRECT ANSWER");
                    }
                    else
                    {
                        MessageBox.Show("WRONG ANSWER ");

                    }


            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(Class1.xmlfilelocation);
            while (reader.Read())
            {
                if (reader.Name == "CORRECTANSWER")
                    //textBox3.Text = reader.ReadString();

                    if (reader.ReadString() == "D")
                    {

                        MessageBox.Show("CORRECT ANSWER");
                    }
                    else
                    {
                        MessageBox.Show("WRONG ANSWER ");

                    }


            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(Class1.xmlfilelocation);
            while (reader.Read())
            {
               // if (reader.NodeType == XmlNodeType.Element)

                if (reader.Name == "QUESTION")
                    textBox3.Text = reader.ReadString();
                if (reader.Name == "ANSWER1")
                    radioButton1.Text = reader.ReadString();
                if (reader.Name == "ANSWER2")
                    radioButton2.Text = reader.ReadString();
                if (reader.Name == "ANSWER3")
                    radioButton3.Text = reader.ReadString();
                if (reader.Name == "ANSWER4")
                    radioButton4.Text = reader.ReadString();
                if (reader.Name == "Image")
                {
                    string imagepath1 = Path.Combine(Class1.location2, reader.ReadString());
                   // MessageBox.Show(imagepath1);
            Image image = Image.FromFile(imagepath1);
                   

                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Size = new Size(100, 100);

                    //pictureBox2.Height = image.Height;
                    // pictureBox2.Width = image.Width;
                    pictureBox1.Image = image;
                   // pictureBox1.Image = reader.ReadString;
                }
                if (reader.Name == "Text")
                {
                    textBox1.Text = reader.ReadString();

                }
                if (reader.Name == "Richtext")
                {
                    richTextBox1.LoadFile(Class1.rtffilelocation, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fILEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog browsefile = new OpenFileDialog();
           // string []arr;
            browsefile.Title = "browse file";
            if(browsefile.ShowDialog()==DialogResult.Cancel)
            return;
            Class1.location = browsefile.FileName;
           // string[] words = s.Split(' ');
           // string[] arr= Class1.location.Split('.');
           
           string pattt= Path.GetFileNameWithoutExtension(Class1.location);//extracts only anil if anil.zip was there.
             string xfilename=pattt+".xml";
             Class1.rtfname = pattt + ".rtf";



             Class1.location2 = Path.Combine("C:\\Users\\eashwar\\Desktop\\READERTOOL", pattt);
           Class1.xmlfilelocation = Path.Combine(Class1.location2,xfilename);
           Class1.rtffilelocation = Path.Combine(Class1.location2,Class1.rtfname);
            // MessageBox.Show(pattt);
           // Class1.location2=arr[0]; 
            
            
            //UNZIP STARTED

            ZipForge archiver = new ZipForge();
            try
            {
                // The name of the ZIP file to unzip
                archiver.FileName = Class1.location;
                // Open an existing archive
                archiver.OpenArchive(System.IO.FileMode.Open);
                // Default path for all operations                
                archiver.BaseDir ="C:\\Users\\eashwar\\Desktop\\READERTOOL";
                // Extract all files from the archive to C:\Temp folder
                archiver.ExtractFiles("*.*");
                // Close archive
                archiver.CloseArchive();
            }
            // Catch all exceptions of the ArchiverException type
            catch (ArchiverException ae)
            {
                Console.WriteLine("Message: {0}\t Error code: {1}", ae.Message, ae.ErrorCode);
                // Wait for keypress
                Console.ReadLine();
            }

            //UNZIP COMPLETE
           Class1.xsdlocation= Path.Combine(Class1.location2, "proj.xsd");
            FileStream aFile = new FileStream(Class1.xsdlocation, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);

            sw.WriteLine("<?xml version=\"1.0\"?>");
            sw.WriteLine("<xsd:schema xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"");
            
            sw.WriteLine("targetNamespace=\"http://www.manual.org\" xmlns=\"http://www.manual.org\" elementFormDefault=\"qualified\">");

            sw.WriteLine("<xsd:element name=\"Manual\">");
            sw.WriteLine("<xsd:complexType>");
            sw.WriteLine("<xsd:sequence>");
            sw.WriteLine("<xsd:element ref=\"doc\" minOccurs=\"1\" maxOccurs=\"unbounded\"/>");
            sw.WriteLine("</xsd:sequence>");
            sw.WriteLine("</xsd:complexType>");
            sw.WriteLine("</xsd:element>");
            sw.WriteLine("<xsd:element name=\"doc\">");
            sw.WriteLine("<xsd:complexType>");
            sw.WriteLine("<xsd:choice minOccurs=\"5\" maxOccurs=\"5\">");
            sw.WriteLine("<xsd:element ref=\"Text\" minOccurs=\"0\" maxOccurs=\"1\"/>");
            sw.WriteLine("<xsd:element ref=\"Image\" minOccurs=\"0\" maxOccurs=\"1\"/>");
            sw.WriteLine("<xsd:element ref=\"Video\" minOccurs=\"0\" maxOccurs=\"1\"/>");
            sw.WriteLine("<xsd:element ref=\"Flash\" minOccurs=\"0\" maxOccurs=\"1\"/>");
            sw.WriteLine("<xsd:element ref=\"QA\" minOccurs=\"0\" maxOccurs=\"1\"/>");
            sw.WriteLine("<xsd:element ref=\"Richtext\" minOccurs=\"0\" maxOccurs=\"1\"/>");
            sw.WriteLine("<xsd:element ref=\"Tempnum\" minOccurs=\"1\" maxOccurs=\"1\"/>");
            sw.WriteLine("</xsd:choice></xsd:complexType></xsd:element>");
            sw.WriteLine("<xsd:element name=\"Text\" type=\"xsd:string\"/>");
            sw.WriteLine("<xsd:element name=\"Image\" type=\"xsd:string\"/>");
            sw.WriteLine("<xsd:element name=\"Video\" type=\"xsd:string\"/>");
            sw.WriteLine("<xsd:element name=\"Flash\" type=\"xsd:string\"/>");
            sw.WriteLine("<xsd:element name=\"Richtext\" type=\"xsd:string\"/>");
            sw.WriteLine("<xsd:element name=\"Tempnum\" type=\"xsd:string\"/>");
            sw.WriteLine("<xsd:element name=\"QA\">");
            sw.WriteLine("<xsd:complexType>");
            sw.WriteLine("<xsd:sequence>");
            sw.WriteLine("<xsd:element name=\"QUESTION\" type=\"xsd:string\"/>");
            sw.WriteLine("<xsd:element name=\"ANSWER1\" type=\"xsd:string\" />");
            sw.WriteLine("<xsd:element name=\"ANSWER2\" type=\"xsd:string\" />");
            sw.WriteLine("<xsd:element name=\"ANSWER3\" type=\"xsd:string\" />");
            sw.WriteLine("<xsd:element name=\"ANSWER4\" type=\"xsd:string\" />");
            sw.WriteLine("<xsd:element name=\"CORRECTANSWER\" type=\"xsd:string\" />");
            sw.WriteLine("</xsd:sequence>");
            sw.WriteLine("</xsd:complexType>");
            sw.WriteLine("</xsd:element>");
            sw.WriteLine("</xsd:schema>");
            sw.Close();
            aFile.Close();
            //validation start
            bool isValid = true;
            // Console.Write("hai");

            Console.WriteLine("The xml file is" + isValid);

            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.Schemas.Add(null, Class1.xsdlocation);
                settings.ValidationType = ValidationType.Schema;
                XmlDocument document = new XmlDocument();
                document.Load(Class1.xmlfilelocation);
                XmlReader rdr = XmlReader.Create(new StringReader(document.InnerXml), settings);
                while (rdr.Read()) { }
            }
            catch
            {
                MessageBox.Show("Validation failed..Corrupted file");
                this.Close();
            }
            Console.WriteLine("The xml file is" + isValid);
            //validation end
            XmlTextReader reader1 = new XmlTextReader(Class1.xmlfilelocation);
            while (reader1.Read())
            {
                if (reader1.Name == "Tempnum")
                {
                    Class1.NUM = reader1.ReadString();
                   // MessageBox.Show(Class1.NUM);
                }
            }
            XmlTextReader reader = new XmlTextReader(Class1.xmlfilelocation);
            while (reader.Read())
            {
               // MessageBox.Show("hai");
                if (Class1.NUM =="1")
                {
                    groupBox1.Visible = true;
                   // MessageBox.Show(Class1.NUM);
                   
                    if (reader.Name == "QUESTION")
                        textBox3.Text = reader.ReadString();
                    if (reader.Name == "ANSWER1")
                        radioButton1.Text = reader.ReadString();
                    if (reader.Name == "ANSWER2")
                        radioButton2.Text = reader.ReadString();
                    if (reader.Name == "ANSWER3")
                        radioButton3.Text = reader.ReadString();
                    if (reader.Name == "ANSWER4")
                        radioButton4.Text = reader.ReadString();
                    /*if (reader.Name == "Image")
                    {
                        string imagepath1 = Path.Combine("C:\\Users\\eashwar\\Desktop\\target\\MADHURI", reader.ReadString());
                        Image image = Image.FromFile(imagepath1);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Size = new Size(100, 100);
                        pictureBox1.Image = image;
                     * 

                    }*/
                    if (reader.Name == "Richtext")
                    {
                        richTextBox1.LoadFile(Class1.rtffilelocation, RichTextBoxStreamType.RichText);
                    }
                    if (reader.Name == "Text")
                    {
                        textBox1.Text = reader.ReadString();

                    }
                    if (reader.Name == "Image")
                    {
                        string imagepath1 = Path.Combine(Class1.location2, reader.ReadString());
                        // MessageBox.Show(imagepath1);
                        Image image = Image.FromFile(imagepath1);


                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Size = new Size(100, 100);

                        //pictureBox2.Height = image.Height;
                        // pictureBox2.Width = image.Width;
                        pictureBox1.Image = image;
                        // pictureBox1.Image = reader.ReadString;
                    }
                }
                if (Class1.NUM =="2")
                {
                    groupBox2.Visible = true;
                    toolStripButton1.Enabled = true;
                    toolStripButton2.Enabled = false;
                    toolStripButton3.Enabled = false;

                    if (reader.Name == "QUESTION")
                        textBox6.Text = reader.ReadString();
                    if (reader.Name == "ANSWER1")
                        radioButton5.Text = reader.ReadString();
                    if (reader.Name == "ANSWER2")
                        radioButton6.Text = reader.ReadString();
                    if (reader.Name == "ANSWER3")
                        radioButton7.Text = reader.ReadString();
                    if (reader.Name == "ANSWER4")
                        radioButton8.Text = reader.ReadString();
                    /*if (reader.Name == "Image")
                    {
                        string imagepath1 = Path.Combine("C:\\Users\\eashwar\\Desktop\\target\\MADHURI", reader.ReadString());
                        Image image = Image.FromFile(imagepath1);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Size = new Size(100, 100);
                        pictureBox1.Image = image;
                     * 

                    }*/
                    if (reader.Name == "Video")
                    {
                        Class1.videolocation = Path.Combine(Class1.location2, reader.ReadString());
                        

                    }
                    if (reader.Name == "Text")
                    {
                        textBox4.Text = reader.ReadString();

                    }
                    if (reader.Name == "Richtext")
                    {
                        richTextBox2.LoadFile(Class1.rtffilelocation, RichTextBoxStreamType.RichText);
                    }
                }
                    if (Class1.NUM == "3")
                    {
                        groupBox3.Visible = true;
                        if (reader.Name == "QUESTION")
                            textBox8.Text = reader.ReadString();
                        if (reader.Name == "ANSWER1")
                            radioButton9.Text = reader.ReadString();
                        if (reader.Name == "ANSWER2")
                            radioButton10.Text = reader.ReadString();
                        if (reader.Name == "ANSWER3")
                            radioButton11.Text = reader.ReadString();
                        if (reader.Name == "ANSWER4")
                            radioButton12.Text = reader.ReadString();
                        if (reader.Name == "Richtext")
                        {
                            richTextBox3.LoadFile(Class1.rtffilelocation, RichTextBoxStreamType.RichText);
                        }
                        if (reader.Name == "Audio")
                        {
                            Class1.audiopath = Path.Combine(Class1.location2, reader.ReadString());
                       }
                        
                       
                        if (reader.Name == "Image")
                        {
                            string imagepath1 = Path.Combine(Class1.location2, reader.ReadString());
                            // MessageBox.Show(imagepath1);
                            Image image = Image.FromFile(imagepath1);


                            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox2.Size = new Size(100, 100);

                            //pictureBox2.Height = image.Height;
                            // pictureBox2.Width = image.Width;
                            pictureBox2.Image = image;
                            // pictureBox1.Image = reader.ReadString;
                        }
                    }
                    if (Class1.NUM == "4")
                    {
                        groupBox4.Visible = true;
                        if (reader.Name == "Richtext")
                        {
                            richTextBox4.LoadFile(Class1.rtffilelocation, RichTextBoxStreamType.RichText);
                        }
                        if (reader.Name == "Image")
                        {
                            string imagepath1 = Path.Combine(Class1.location2, reader.ReadString());
                            // MessageBox.Show(imagepath1);
                            Image image = Image.FromFile(imagepath1);


                            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                            //pictureBox3.Size = new Size(100, 100);

                            //pictureBox2.Height = image.Height;
                            // pictureBox2.Width = image.Width;
                            pictureBox3.Image = image;
                            // pictureBox1.Image = reader.ReadString;
                        }
                        if (reader.Name == "Video")
                        {
                            Class1.videolocation = Path.Combine(Class1.location2, reader.ReadString());


                        }
                        if (reader.Name == "Flash")
                        {
                            Class1.flashpath = Path.Combine(Class1.location2,reader.ReadString());
                            axShockwaveFlash1.Movie = Class1.flashpath;
                            //axShockwaveFlash1.Size = new System.Drawing.Size(100, 100);
                            axShockwaveFlash1.Play();

                        }

                    } 

                }

            


        }

        private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Class1.count++;
            if (Class1.count == 1)
            {
                axWindowsMediaPlayer1.URL = Class1.videolocation;
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

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Class1.audiocount++;
            if (Class1.audiocount == 1)
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

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void axShockwaveFlash1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
