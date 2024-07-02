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
            LoadRss("http://www.hurriyet.com.tr/rss/anasayfa");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadRss("http://www.mynet.com/haber/rss/sondakika");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            LoadRss("http://www.milliyet.com.tr/rss/rssNew/SonDakikaRss.xml");

        }

        private void LoadRss(string url)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlTextRead = new XmlTextReader(url);
            while (xmlTextRead.Read())
            {
                if (xmlTextRead.Name == "title")
                {
                    listBox1.Items.Add(xmlTextRead.ReadString());
                }
            }
        }
    }
}
