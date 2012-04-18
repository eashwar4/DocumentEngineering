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
                 
                 {

                     Class1.qans = reader.ReadString();

                 }


             }
             if ((Class1.qans == "A")||(Class1.qans=="a"))
             {
                 label3.Text = "Correct Answer!";
             }
             else
             {
                 label3.Text = "Wrong Answer!";
             }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(Class1.xmlfilelocation);
            while (reader.Read())
            {
                if (reader.Name == "CORRECTANSWER")
                {

                    Class1.qans = reader.ReadString();

                }


            }
            if ((Class1.qans == "B")||(Class1.qans == "b"))
            {
                label3.Text = "Correct Answer!";
            }
            else
            {
                label3.Text = "Wrong Answer!";
            }
          
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(Class1.xmlfilelocation);
            while (reader.Read())
            {
                if (reader.Name == "CORRECTANSWER")
                {

                    Class1.qans = reader.ReadString();

                }


            }
            if ((Class1.qans == "C") || (Class1.qans == "c"))
            {
                label3.Text = "Correct Answer!";
            }
            else
            {
                label3.Text = "Wrong Answer!";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            XmlTextReader reader = new XmlTextReader(Class1.xmlfilelocation);
            while (reader.Read())
            {
                if (reader.Name == "CORRECTANSWER")
                {

                    Class1.qans = reader.ReadString();

                }


            }
            if ((Class1.qans == "D") || (Class1.qans == "d"))
            {
                label3.Text = "Correct Answer!";
            }
            else
            {
                label3.Text = "Wrong Answer!";
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
            browsefile.Filter="Zip Files|*.zip";

            if(browsefile.ShowDialog()==DialogResult.Cancel)
            return;
            Class1.location = browsefile.FileName;
           // string[] words = s.Split(' ');
           // string[] arr= Class1.location.Split('.');
           
           string pattt= Path.GetFileNameWithoutExtension(Class1.location);//extracts only anil if anil.zip was there.
             string xfilename=pattt+".xml";
             Class1.rtfname = pattt + ".rtf";



             Class1.location2 = Path.Combine("C:\\Users\\Vyshak\\Desktop\\READERTOOL", pattt);
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
                archiver.Password = "iiitb";
                archiver.OpenArchive(System.IO.FileMode.Open);
                // Default path for all operations                
                archiver.BaseDir ="C:\\Users\\Vyshak\\Desktop\\READERTOOL";
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
            FileStream aFile = new FileStream(Class1.xsdlocation, FileMode.Create, FileAccess.Write);
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
            sw.WriteLine("<xsd:element ref=\"Audio\" minOccurs=\"0\" maxOccurs=\"1\"/>");
            sw.WriteLine("<xsd:element ref=\"QA\" minOccurs=\"0\" maxOccurs=\"1\"/>");
            sw.WriteLine("<xsd:element ref=\"Richtext\" minOccurs=\"0\" maxOccurs=\"1\"/>");
            sw.WriteLine("<xsd:element ref=\"Tempnum\" minOccurs=\"1\" maxOccurs=\"1\"/>");
            sw.WriteLine("</xsd:choice></xsd:complexType></xsd:element>");
            sw.WriteLine("<xsd:element name=\"Text\" type=\"xsd:string\"/>");
            sw.WriteLine("<xsd:element name=\"Image\" type=\"xsd:string\"/>");
            sw.WriteLine("<xsd:element name=\"Video\" type=\"xsd:string\"/>");
            sw.WriteLine("<xsd:element name=\"Flash\" type=\"xsd:string\"/>");
            sw.WriteLine("<xsd:element name=\"Audio\" type=\"xsd:string\"/>");
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
            bool isValid = true; //xml validation
            // Console.Write("hai");

            //Console.WriteLine("The xml file is" + isValid);

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
                        string imagepath1 = Path.Combine("C:\\Users\\Vyshak\\Desktop\\target\\Vyshak", reader.ReadString());
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
                        string imagepath1 = Path.Combine("C:\\Users\\Vyshak\\Desktop\\target\\Vyshak", reader.ReadString());
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

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Class1.count++;
            if (Class1.count == 1)
            {
                axWindowsMediaPlayer3.URL = Class1.videolocation;
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

        private void iNCREASEToolStripMenuItem_Click(object sender, EventArgs e)
        {
          // groupBox4.Size = new Size(groupBox4.Size.Width + 100, groupBox4.Size.Height + 100);
           //richTextBox4.Size = new Size(groupBox4.Size.Width, (groupBox4.Size.Height) / 4);
           //axShockwaveFlash1.Size = new Size((groupBox4.Width) / 2, (groupBox4.Height) / 2);
           //pictureBox3.Size = new Size((groupBox4.Width) / 2, (groupBox4.Height) / 2);
           // this.Size = new System.Drawing.Size(800, 800);
            //background image
          // string imagepath9 = @"C:\Users\vyshak\Desktop\background\bk1.jpg";
          //  Image image1 = Image.FromFile(imagepath9);
            //pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            // pictureBox4.Size = new Size(groupBox1.Width/, groupBox1.Height);
            //pictureBox4.Image = image1;

            //Template 1 resizing
            groupBox1.Width = 800;
            groupBox1.Height = 650;
            richTextBox1.SetBounds(10,10,800,130);
            textBox2.SetBounds(410,140,400,325);
            radioButton1.SetBounds(420,200,400,40);
            radioButton2.SetBounds(420, 250, 400, 40);
            radioButton3.SetBounds(420,300,400,40);
            radioButton4.SetBounds(420, 350, 400, 40);
            textBox1.SetBounds(10,455,800,195);
            textBox3.SetBounds(420, 150, 400, 40);
            pictureBox1.SetBounds(10,140,400,325);
            label3.SetBounds(500,400,400,50);

            //Template3 resizing
            groupBox3.Width = 800;
            groupBox3.Height = 650;
            richTextBox3.SetBounds(10, 10, 800, 130);
            axWindowsMediaPlayer2.SetBounds(10, 140, 400, 300);
            groupBox6.SetBounds(10,380,400,60);
           
            pictureBox2.SetBounds(410, 140, 400, 325);
            textBox7.SetBounds(10, 455, 800, 195);
            textBox8.SetBounds(10, 470, 800, 25);
            radioButton9.SetBounds(10, 490, 800, 40);
            radioButton10.SetBounds(10, 530, 800, 40);
            radioButton11.SetBounds(10, 570, 800, 40);
            radioButton12.SetBounds(10, 610, 800, 40);
            label5.SetBounds(500,625,800,40);

            //Template2 resizing
            groupBox2.SetBounds(10, 20, groupBox2.Width, groupBox2.Height);
            groupBox2.Width = 800;
            groupBox2.Height = 650;
            richTextBox2.SetBounds(10, 10, 800, 130);
            axWindowsMediaPlayer1.SetBounds(10, 140, 400, 300);
            groupBox5.SetBounds(10, 380, 400, 60);
            textBox6.SetBounds(10, 470, 800, 25);
            textBox4.SetBounds(410,140,400,325);
            radioButton5.SetBounds(10, 490, 800, 40);
            radioButton6.SetBounds(10, 530, 800, 40);
            radioButton7.SetBounds(10, 570, 800, 40);
            radioButton8.SetBounds(10, 610, 800, 40);
            label4.SetBounds(500, 625, 800, 40);

            //Template 4 resizing
            groupBox4.SetBounds(10, 20, groupBox2.Width, groupBox2.Height);
            groupBox4.Width = 800;
            groupBox4.Height = 670;
            richTextBox4.SetBounds(10,10,800,130);
            axShockwaveFlash1.SetBounds(10,140,400,325);
            pictureBox3.SetBounds(410,140,400,325);
            axWindowsMediaPlayer3.SetBounds(10,470,800,195);
            groupBox7.SetBounds(10,620,800,30);
            //groupBox1.SetBounds(10, 10, groupBox4.Size.Width, groupBox4.Size.Height);
           
            //this.Scale(2);
           // vScrollBar1.SetBounds(this.Width, 0, vScrollBar1.Width, vScrollBar1.Height);
           //groupBox4.Scale(2);
           // this.Height = 1500;
            //this.Width = 1500;*/
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(Class1.xmlfilelocation);
            while (reader.Read())
            {
                if (reader.Name == "CORRECTANSWER")
                {

                    Class1.qans = reader.ReadString();

                }


            }
            if ((Class1.qans == "A")||(Class1.qans=="a"))
            {
                label4.Text = "Correct Answer!";
            }
            else
            {
                label4.Text = "Wrong Answer!";
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(Class1.xmlfilelocation);
            while (reader.Read())
            {
                if (reader.Name == "CORRECTANSWER")
                {

                    Class1.qans = reader.ReadString();

                }


            }
            if ((Class1.qans == "B")||(Class1.qans=="b"))
            {
                label4.Text = "Correct Answer!";
            }
            else
            {
                label4.Text = "Wrong Answer!";
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(Class1.xmlfilelocation);
            while (reader.Read())
            {
                if (reader.Name == "CORRECTANSWER")
                {

                    Class1.qans = reader.ReadString();

                }


            }
            if ((Class1.qans == "C")||(Class1.qans=="c"))
            {
                label4.Text = "Correct Answer!";
            }

            else
            {
                label4.Text = "Wrong Answer!";
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(Class1.xmlfilelocation);
            while (reader.Read())
            {
                if (reader.Name == "CORRECTANSWER")
                {

                    Class1.qans = reader.ReadString();

                }


            }
            if ((Class1.qans == "D")||(Class1.qans=="d"))
            {
                label4.Text = "Correct Answer!";
            }
            else
            {
                label4.Text = "Wrong Answer!";
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(Class1.xmlfilelocation);
            while (reader.Read())
            {
                if (reader.Name == "CORRECTANSWER")
                {

                    Class1.qans = reader.ReadString();

                }


            }
            if ((Class1.qans == "a") || (Class1.qans == "A"))
            {
                label5.Text = "Correct Answer!";
            }

            else
            {
                label5.Text = "Wrong Answer!";
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(Class1.xmlfilelocation);
            while (reader.Read())
            {
                if (reader.Name == "CORRECTANSWER")
                {

                    Class1.qans = reader.ReadString();

                }


            }
            if ((Class1.qans == "b") || (Class1.qans == "B"))
            {
                label5.Text = "Correct Answer!";
            }

            else
            {
                label5.Text = "Wrong Answer!";
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(Class1.xmlfilelocation);
            while (reader.Read())
            {
                if (reader.Name == "CORRECTANSWER")
                {

                    Class1.qans = reader.ReadString();

                }


            }
            if ((Class1.qans == "C") || (Class1.qans == "c"))
            {
                label5.Text = "Correct Answer!";
            }

            else
            {
                label5.Text = "Wrong Answer!";
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(Class1.xmlfilelocation);
            while (reader.Read())
            {
                if (reader.Name == "CORRECTANSWER")
                {

                    Class1.qans = reader.ReadString();

                }


            }
            if ((Class1.qans == "d") || (Class1.qans == "D"))
            {
                label5.Text = "Correct Answer!";
            }

            else
            {
                label5.Text = "Wrong Answer!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer3_Enter(object sender, EventArgs e)
        {

        }
    }
}
