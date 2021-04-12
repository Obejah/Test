using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testt
{
    public partial class FlappyBird : Form
    {
        bool gameover = false;

        int gamespeed = 5;
        int pipespeed = 10;
        int groundspeed = 10;
        int gravity = 15;
        int scorer1 = 0;
        int scorer2 = 0;
        int scorer3 = 0;
        int score = 0;
        int lives = 3;
        int totalscore = 0;
        int idlespeed = 5;
        int lastleaderboardscore;
        int i;


        public FlappyBird()
        {
            InitializeComponent();
            /*   string server = "localhost";
            string database = "flappyLeader";
            string dbUsername = "root";
            string dbPassword = "";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +

                database + ";" + "UID=" + dbUsername + ";" + "PASSWORD=" + dbPassword + ";";

            MySqlConnection mysqlcon = new MySqlConnection(connectionString);

            i = 0;
            mysqlcon.Open();
            MySqlCommand cmd = mysqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select score from leaderboard order by Score  desc limit 1 offset 9";
            
            DataTable dtbl = new DataTable("dtbl");
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            i = Convert.ToInt32(dtbl.Rows.Count.ToString());

            lastleaderboardscore = (int)ds.Tables[0].Rows[0]["score"];

            
            
            mysqlcon.Close();
            
            
            
            KeyPreview = true; */
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
         {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void Idle_Tick(object sender, EventArgs e)
        {
            Player.Top -= idlespeed;
            if(Player.Top <300)
            {
                idlespeed = -idlespeed;
            }
            Player.Top -= idlespeed;
            if (Player.Top < 600)
            {
                idlespeed = -idlespeed;
            }

            Ground.Left -= pipespeed;

            if (Ground.Left < -185)
            {
                Ground.Left = 0;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Idle.Enabled = false; 
            Game.Enabled = true;
            Start.Hide();
            Leaderboard.Hide();
            Exit.Hide();
            Exit.Enabled = false;
        }

        private void Game_Tick(object sender, EventArgs e)
        {
            LivesCounter.Text = "Lives: " + lives;


            Player.Top += gravity;
            Pipe1.Left -= pipespeed;
            Pipe2.Left -= pipespeed;
            Pipe3.Left -= pipespeed;
            Pipe4.Left -= pipespeed;
            Pipe5.Left -= pipespeed;
            Pipe6.Left -= pipespeed;
            Pipe7.Left -= pipespeed;
            Pipe8.Left -= pipespeed;


            /* foreach (Control x in this.Controls)
             {
                 if (x is PictureBox && x.Tag == "Pipe" || x is PictureBox && x.Tag == "Ground")

                     if (Player.Bounds.IntersectsWith(x.Bounds))
                     {
                         lives = lives - 1;
                         Game.Stop();
                         LivesCounter.Text = "press space to reset";
                     }

             }*/
            if (score == gamespeed)
            {
                pipespeed++;
                gamespeed = gamespeed + 2;
            }

            if (lives == 0)
            {
                gameover = true;
            }
            Ground.Left -= pipespeed;

            if (Ground.Left < -185)
            {
                Ground.Left = 0;
            }

            if (Player.Top < -80)
            {
                Player.Top = -70;
            }



        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FlappyBird_Load(object sender, EventArgs e)
        {
            Randomize();
        }

        private void Randomize()
        {
        //    throw new NotImplementedException();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pipe1_Click(object sender, EventArgs e)
        {

        }
    }
}
