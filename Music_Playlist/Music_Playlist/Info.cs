using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Playlist
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            ////Gia ta tragoudia
            TextReader tr = new StreamReader("Songs.txt");

            label7.Text = tr.ReadLine();
            label8.Text = tr.ReadLine();
            label9.Text = tr.ReadLine();
            label10.Text = tr.ReadLine();
            label11.Text = tr.ReadLine();
            label12.Text = tr.ReadLine();

            tr.Close();

            /////Gia ton kallitexnh

            TextReader trr = new StreamReader("Art.txt");

            label13.Text = trr.ReadLine();
            label14.Text = trr.ReadLine();
            label15.Text = trr.ReadLine();
            label16.Text = trr.ReadLine();
            label17.Text = trr.ReadLine();
            label18.Text = trr.ReadLine();

            trr.Close();

            /////Gia to etos
            TextReader trrr = new StreamReader("Year.txt");

            label19.Text = trrr.ReadLine();
            label20.Text = trrr.ReadLine();
            label21.Text = trrr.ReadLine();
            label22.Text = trrr.ReadLine();
            label23.Text = trrr.ReadLine();
            label24.Text = trrr.ReadLine();

            trrr.Close();

            /////Gia to eidos
            TextReader tr2 = new StreamReader("Genre.txt");

            label25.Text = tr2.ReadLine();
            label26.Text = tr2.ReadLine();
            label27.Text = tr2.ReadLine();
            label28.Text = tr2.ReadLine();
            label29.Text = tr2.ReadLine();
            label30.Text = tr2.ReadLine();

            tr2.Close();

            TextReader tr3 = new StreamReader("Lang.txt");

            label31.Text = tr3.ReadLine();
            label32.Text = tr3.ReadLine();
            label33.Text = tr3.ReadLine();
            label34.Text = tr3.ReadLine();
            label35.Text = tr3.ReadLine();
            label36.Text = tr3.ReadLine();

            tr3.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("Songs.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("Art.txt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("Year.txt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("Genre.txt");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("Lang.txt");
        }

        
      private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Info i = new Info();
            i.ShowDialog();
            this.Close();

        }
    }
}
