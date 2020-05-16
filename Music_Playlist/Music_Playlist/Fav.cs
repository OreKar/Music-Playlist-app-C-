using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Playlist
{
    public partial class Fav : Form
    {
        public Fav()
        {
            InitializeComponent();
        }

        private void Fav_Load(object sender, EventArgs e)
        {
           

        

            label2.Text = Main.files[Main.favSiNDEX[5]];
            label3.Text = Main.files[Main.favSiNDEX[4]];
            label4.Text = Main.files[Main.favSiNDEX[3]];
            label5.Text = Main.files[Main.favSiNDEX[2]];
            label6.Text = Main.files[Main.favSiNDEX[1]];
            label7.Text = Main.files[Main.favSiNDEX[0]];



        }


            private void button2_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }

