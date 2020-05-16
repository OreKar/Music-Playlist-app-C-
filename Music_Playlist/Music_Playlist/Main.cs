using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Playlist
{
    public partial class Main : Form
    {
        public static int[] favSiNDEX = new int[6];

        public Main()
        {
            InitializeComponent();

           for (int i = 0; i < 6; i++)
            {
                favSiNDEX[i] = i;


            }

        }


        public static String[] paths ;
        public static String[] files ;
       



        private void addS_Click(object sender, EventArgs e)
        {
        
            OpenFileDialog od = new OpenFileDialog();

            od.Multiselect = true;
            if (od.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = od.SafeFileNames;
                paths = od.FileNames;

                for(int i =0; i<files.Length; i++)
                {
                    ListOfSongs.Items.Add(files[i]);
                }
    

            }

           TextWriter tw = new StreamWriter("Songs.txt");
            for (int k = 0; k < ListOfSongs.Items.Count; k++)
            {
                tw.WriteLine((string)ListOfSongs.Items[k]);
            }


            tw.Close();



            
    }
        public static int[] favS = new int[6];
      


        private void ListOfSongs_SelectedIndexChanged(object sender, EventArgs e)
        {

          

            try
            {
              
                favS[ListOfSongs.SelectedIndex] = favS[ListOfSongs.SelectedIndex] + 1;

                WindowsMediaPlayer.URL = paths[ListOfSongs.SelectedIndex];
            }

            catch (IndexOutOfRangeException r)
            { }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Info i = new Info();
            i.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rmvS_Click(object sender, EventArgs e)
        {
            if (ListOfSongs.SelectedIndex == -1)
                MessageBox.Show("You must select a song first.");
            if (ListOfSongs.SelectedIndex > -1)
            {
                ListOfSongs.Items.RemoveAt(ListOfSongs.SelectedIndex);
                
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int c = ListOfSongs.Items.Count;
            int c2 = rnd.Next(0, c);
            ListOfSongs.SelectedIndex = c2;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();

            int n = favS.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (favS[j] > favS[j + 1])
                    {
                        int temp = favS[j];
                        favS[j] = favS[j + 1];
                        favS[j + 1] = temp;

                        int temp2 = favSiNDEX[j];
                        favSiNDEX[j] = favSiNDEX[j + 1];
                        favSiNDEX[j + 1] = temp2;



                    }



            Fav f = new Fav();
            f.ShowDialog();
            Show();




        }
    }
 
}
