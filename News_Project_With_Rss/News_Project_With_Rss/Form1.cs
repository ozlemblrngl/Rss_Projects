using System;
using System.Windows.Forms;
using System.Xml;


namespace News_Project_With_Rss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlRead = new XmlTextReader("http://www.hurriyet.com.tr/rss/anasayfa");
            while (xmlRead.Read())
            {
                if (xmlRead.Name == "title")
                {
                    listBox1.Items.Add(xmlRead.ReadString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlRead = new XmlTextReader("http://www.mynet.com/haber/rss/sondakika");
            while (xmlRead.Read())
            {
                if (xmlRead.Name == "title")
                {
                    listBox1.Items.Add(xmlRead.ReadString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlRead = new XmlTextReader("http://www.milliyet.com.tr/rss/rssNew/SonDakikaRss.xml");
            while (xmlRead.Read())
            {
                if (xmlRead.Name == "title")
                {
                    listBox1.Items.Add(xmlRead.ReadString());
                }
            }

        }
    }
}
