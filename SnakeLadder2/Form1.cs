using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeLadder2
{    
    public partial class Form1 : Form
    {
        //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        //System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player2 = new WMPLib.WindowsMediaPlayer();
        int dice = 0;
        int num = 0,num2,num3, one, two,tthree,ffour;
        int p=0, pp;
        int F, S, T, F4, FS2, FS3, FS4;
        string s;
        int c=0;
        int[] array;
        int second=0;
        int myanmar = 0;
        string numstring;
        fromgame game;
        public Form1()
        {
            InitializeComponent();
            game = new fromgame();
            //player1.SoundLocation = "night.wav";
           // player.SoundLocation = "night.wav";
           // player.URL = "night.mp3";
            //player.controls.stop();

            //player2.URL = "ggg.mp3";
            //player2.controls.stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start.Enabled = false;
           
            pictureBox2.Image = Image.FromFile(@"C:\SnakeLadder2\SnakeLadder2\Resources\roll.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            three.Visible = false;
            four.Visible = false;
            comfirm.Visible = false;
            Playerthree.Visible = false;
            lbPlayerthree.Visible = false;
            Playerfour.Visible = false;
            lbPlayerfour.Visible = false;
            cancal.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            textBox1.Visible = false;

              pictureBox2.Image = Image.FromFile(@"C:\SnakeLadder2\SnakeLadder2\Resources\roll.png");

            timer1.Stop();
            //player1.Play();
          //  player.Play();
            Random musicRan = new Random();
            int mm = musicRan.Next(1, 3);
            if (mm == 1)
               {
                   player.URL = "1.mp3";
                player.controls.play();
               }
            else {
                player.URL = "2.mp3";
                player.controls.play();
                }
            myanmar = Convert.ToInt16(textBox1.Text);
            if(myanmar ==1)
            {
              
                lbPlayerone.Text = "ကစားသမားတစ္ဧ။္ နာမည္";
                lbPlayertwo.Text = "ကစားသမားႏွစ္ဧ။္ နာမည္";
                lbPlayerthree.Text = "ကစားသမားသံုးဧ။္ နာမည္";
                lbPlayerfour.Text = "ကစားသမားေလးဧ။္ နာမည္";
                button1.Text = "အံစာ လွိမ့္မည္။";
                Help.Text = "အကူအညီ";
                about.Text = "အေၾကာင္း";
                exit.Text = "ထြက္ခြာ";
                moreplay.Text = "ႏွစ္ေယာက္ထက္ပုိကစားမည္။";
                start.Text = "ေဆာ့မည္။";
                three.Text = "သံုးေယာက္";
                four.Text = "ေလးေယာက္";
                comfirm.Text = "အတည္ျပဳ";
                cancal.Text = "ျပန္ဖ်က္";
                button2.Text = "";
                label3.Text = "ကစားသမားတစ္ေနရာမွာ နာမည္ေရးၿပီး ပ၊ဒု၊တ အတြက္ အံစာလွိမ့္ပါ။";

                // tt.back.Text = "ေနာက္သို႔";
                //tt.Exit.Text = "ထြက္ခြာ";
                //tt.restart.Text = "ျပန္လည္စ";
              //  game.textBox1.Text = "1";
                button2.Text = "ဘာသာ";
                button3.Visible = false;
                button4.Visible = false;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            player2.URL = "realclick.mp3";
            player2.controls.play(); game.Show();
            this.Hide();
           //player2.controls.stop();
            player.controls.stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player2.URL = "realclick.mp3";
            player2.controls.play();
            
          //  pictureBox2.Image = Image.FromFile(@"E:\C#\SnakeLadder2\SnakeLadder2\Resources\roll.png");


            Random r = new Random();
          
            p++;


            if (p == 1)
            {
                num = r.Next(1, 7);
                pictureBox2.Image = Image.FromFile(@"C:\SnakeLadder2\SnakeLadder2\Resources\" + num + ".png");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

                one = num;
                if (myanmar== 0)
                {
                    label1.Text = "Player One's Number is" + num; 
                    label3.Text = "Player Two's add your name and roll dice for First or Second.";
                }
                else
                {
                   
                    switch (num)
                {
                    case 1: numstring = "တစ္"; break;
                    case 2: numstring = "ႏွစ္"; break;
                    case 3: numstring = "သံုး"; break;
                    case 4: numstring = "ေလး"; break;
                    case 5: numstring = "ငါး"; break;
                    case 6: numstring = "ေျခာက္"; break;
                }
                    label1.Text = "ကစားသမားတစ္ဧ။္ အံစာနံပါတ္မွာ" + numstring  + " ျဖစ္ပါသည္။";
                    label3.Text = "ကစားသမားႏွစ္ေနရာမွာ နာမည္ေရးၿပီး ပ၊ဒု၊တ အတြက္ အံစာလွိမ့္ပါ။";
                }

            }


            else if (p == 2)
            {
                do { num = r.Next(1, 7); } while (one == num);
                pictureBox2.Image = Image.FromFile(@"C:\SnakeLadder2\SnakeLadder2\Resources\" + num + ".png");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                two = num;

                if (myanmar == 0) { label2.Text = "Player Two's Number is" + num; }
                else {
                    switch (num)
                    {
                        case 1: numstring = "တစ္"; break;
                        case 2: numstring = "ႏွစ္"; break;
                        case 3: numstring = "သံုး"; break;
                        case 4: numstring = "ေလး"; break;
                        case 5: numstring = "ငါး"; break;
                        case 6: numstring = "ေျခာက္"; break;
                    }
                    label2.Text = "ကစားသမားႏွစ္ဧ။္ အံစာနံပါတ္မွာ " +numstring + " ျဖစ္ပါသည္။"; }
             
                if (pp != 2)
                {
                    if (pp != 3)
                    {
                        button1.Visible = false; FS2 = 1;
                    }
                }
                if (pp == 2)
                {
                    if (myanmar == 0)
                    { label3.Text = "Player Three's add your name and roll dice for First or Second."; }
                    else { label3.Text = "ကစားသမားသံုးေနရာမွာ နာမည္ေရးၿပီး ပ၊ဒု၊တ အတြက္ အံစာလွိမ့္ပါ။"; }
                }

            }

            else if (pp == 2)
            {
                do { num = r.Next(1, 7); } while (num == one || num == two);
                pictureBox2.Image = Image.FromFile(@"C:\SnakeLadder2\SnakeLadder2\Resources\" + num + ".png");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

                tthree = num;
                if (myanmar == 0)
                { label4.Text = "Player Three's Number is" + num; }
                else {

                    switch (num)
                    {
                        case 1: numstring = "တစ္"; break;
                        case 2: numstring = "ႏွစ္"; break;
                        case 3: numstring = "သံုး"; break;
                        case 4: numstring = "ေလး"; break;
                        case 5: numstring = "ငါး"; break;
                        case 6: numstring = "ေျခာက္"; break;
                    }
                    label4.Text = "ကစားသမားသံုးဧ။္ အံစာနံပါတ္မွာ" + numstring  + " ျဖစ္ပါသည္။"; }
                
                
                button1.Visible = false; FS3 = 1;
            }

            else if (pp == 3)
            {
                do { num = r.Next(1, 7); } while (num == one || num == two);
                pictureBox2.Image = Image.FromFile(@"C:\SnakeLadder2\SnakeLadder2\Resources\" + num + ".png");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

                tthree = num; pp = 4;

                if (myanmar == 0)
                {
                    label4.Text = "Player Three's Number is" + num;
                    label3.Text = "Player four's add your name and roll dice for First or Second.";
                }
                else
                {
                    switch (num)
                    {
                        case 1: numstring = "တစ္"; break;
                        case 2: numstring = "ႏွစ္"; break;
                        case 3: numstring = "သံုး"; break;
                        case 4: numstring = "ေလး"; break;
                        case 5: numstring = "ငါး"; break;
                        case 6: numstring = "ေျခာက္"; break;
                    }
                    label4.Text = "ကစားသမားသံုးဧ။္ အံစာနံပါတ္မွာ" + numstring  + " ျဖစ္ပါသည္။";
                    label3.Text = "ကစားသမားေလးေနရာမွာ နာမည္ေရးၿပီး ပ၊ဒု၊တ အတြက္ အံစာလွိမ့္ပါ။";
                }
            }

            else if (pp == 4)
            {
                do { num = r.Next(1, 7); } while (num == one || num == two || num == tthree);
                pictureBox2.Image = Image.FromFile(@"C:\SnakeLadder2\SnakeLadder2\Resources\" + num + ".png");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

                ffour = num;button1.Visible = false; FS4 = 1;
                if (myanmar == 0)
                { label5.Text = "Player four's Number is" + num; }
                else {
                    switch (num)
                    {
                        case 1: numstring = "တစ္"; break;
                        case 2: numstring = "ႏွစ္"; break;
                        case 3: numstring = "သံုး"; break;
                        case 4: numstring = "ေလး"; break;
                        case 5: numstring = "ငါး"; break;
                        case 6: numstring = "ေျခာက္"; break;
                    }
                    
                    label5.Text = "ကစားသမားေလးဧ။္ အံစာနံပါတ္မွာ" + numstring  + " ျဖစ္ပါသည္။"; }
            }

            if (FS2 == 1)
            {
                if (one > two)
                {
                    if (myanmar == 1) {
                        Form3 f3 = new Form3();
                        f3.label1.Text = "ကစားသမားတစ္သည္ ပထမ\nကစားသမားႏွစ္သည္  ဒုတိယ";
                        f3.Show();
                        // MessageBox.Show("ကစားသမားတစ္သည္ ပထမ\nကစားသမားႏွစ္သည္  ဒုတိယ");
                                     }
                    else {
                        Form3 f3 = new Form3();
                        f3.label1.Text = "Player One is first\nPlayer Two is second";
                        f3.Show();
                        //MessageBox.Show("First player is first\nSecond player is second");
                    }
                    F = one; S = two;
                    game.lb2playerone.Text = this.Playerone.Text;
                    game.lb2playertwo.Text = this.Playertwo.Text;
                    game.lbplayerthree.Visible = false;
                    game.lbplayerfour.Visible = false;

                }
                else
                {
                    if (myanmar == 1) {
                        Form3 f3 = new Form3();
                        f3.label1.Text = "ကစားသမားႏွစ္သည္   ပထမ\nကစားသမားတစ္သည္   ဒုတိယ";
                        f3.Show();
                        //MessageBox.Show("ကစားသမားႏွစ္သည္   ပထမ\nကစားသမားတစ္သည္   ဒုတိယ"); 
                    }
                    else {
                        Form3 f3 = new Form3();
                        f3.label1.Text = "Player Two is first\nPlayer One is second";
                        f3.Show();
                        //MessageBox.Show("Second player is first\nFirst player is second"); 
                    }
                     F = two; S = one;
                    game.lb2playertwo.Text = this.Playerone.Text;
                    game.lb2playerone.Text = this.Playertwo.Text;
                    game.lbplayerthree.Visible = false;
                    game.lbplayerfour.Visible = false;

                }
                start.Enabled = true;
             
            }
 
          if(FS3==1)
          {
           int []    array = { one, two, tthree };
              
              Array.Sort(array);
              Array.Reverse(array);
              foreach (int i in array )
              {
                  c++;
                  
                  if(one==i)
                  {
                      switch (c)
                      {
                          case 1: if (myanmar == 1) { s += "ကစားသမားတစ္သည္ ပထမ\n"; } else { s += "Player One is First\n"; } game.lb2playerone.Text = this.Playerone.Text; break;
                          case 2: if (myanmar == 1) { s += "ကစားသမားတစ္သည္   ဒုတိယ\n"; } else { s += "Player One is second \n"; } game.lb2playertwo.Text = this.Playerone.Text; break;
                          case 3: if (myanmar == 1) { s += "ကစားသမားတစ္သည္  တတိယ\n"; } else { s += "Player One is third\n"; } game.lbplayerthree.Text = this.Playerone.Text; break;

                      }
                  }
                  if (two == i)
                  {
                      switch (c)
                      {
                          case 1: if (myanmar == 1) { s += "ကစားသမားႏွစ္သည္   ပထမ\n"; } else { s += "Player Two is First\n"; } game.lb2playerone.Text = this.Playertwo.Text; break;
                          case 2: if (myanmar == 1) { s += "ကစားသမားႏွစ္သည္  ဒုတိယ\n "; } else { s += "Player Two is second\n "; } game.lb2playertwo.Text = this.Playertwo.Text; break;
                          case 3: if (myanmar == 1) { s += "ကစားသမားႏွစ္သည္   တတိယ\n"; } else { s += "Player Two is third\n"; } game.lbplayerthree.Text = this.Playertwo.Text; break;

                      }
                  }
                  if (tthree  == i)
                  {
                      switch (c)
                      {
                          case 1: if (myanmar == 1) { s += "ကစားသမားသံုးသည္  ပထမ\n"; } else { s += "Player Three is First\n"; } game.lb2playerone.Text = this.Playerthree.Text; break;
                          case 2: if (myanmar == 1) { s += "ကစားသမားသံုးသည္  ဒုတိယ \n"; } else { s += "Player Three is second \n"; } game.lb2playertwo.Text = this.Playerthree.Text; break;
                          case 3: if (myanmar == 1) { s += "ကစားသမားသံုးသည္   တတိယ\n"; } else { s += "Player Three is third\n"; } game.lbplayerthree.Text = this.Playerthree.Text; break;

                      }
                  }

              }
              Form3 f3 = new Form3();
              f3.label1.Text = s;
              f3.Show();
             // MessageBox.Show(s);
              start.Enabled = true;
              game.lbplayerfour.Visible = false;
           
             
             
          }


          if (FS4 == 1)
          {
              int[] array = { one, two, tthree,ffour  };

              Array.Sort(array);
              Array.Reverse(array);
              foreach (int i in array)
              {
                  c++;

                  if (one == i)
                  {
                      switch (c)
                      {
                          case 1: if (myanmar == 1) { s += "ကစားသမားတစ္သည္ ပထမ\n"; } else { s += "Player One is First\n"; } game.lb2playerone.Text = this.Playerone.Text; break;
                          case 2: if (myanmar == 1) { s += "ကစားသမားတစ္သည္   ဒုတိယ \n"; } else { s += "Player One is second \n"; } game.lb2playertwo.Text = this.Playerone.Text; break;
                          case 3: if (myanmar == 1) { s += "ကစားသမားတစ္သည္  တတိယ\n"; } else { s += "Player One is third\n"; } game.lbplayerthree.Text = this.Playerone.Text; break;
                          case 4: if (myanmar == 1) { s += "ကစားသမားတစ္သည္ စတုတၳ\n"; } else { s += "Player One is fourth\n"; } game.lbplayerfour.Text = this.Playerone.Text; break;

                      }
                  }
                  if (two == i)
                  {
                      switch (c)
                      {
                          case 1: if (myanmar == 1) { s += "ကစားသမားႏွစ္သည္   ပထမ\n"; } else { s += "Player Two is First\n"; } game.lb2playerone.Text = this.Playertwo.Text; break;
                          case 2: if (myanmar == 1) { s += "ကစားသမားႏွစ္သည္  ဒုတိယ\n "; } else { s += "Player Two is second\n "; } game.lb2playertwo.Text = this.Playertwo.Text; break;
                          case 3: if (myanmar == 1) { s += "ကစားသမားႏွစ္သည္   တတိယ\n"; } else { s += "Player Two is third\n"; } game.lbplayerthree.Text = this.Playertwo.Text; break;
                          case 4: if (myanmar == 1) { s += "ကစားသမားႏွစ္သည္ စတုတၳ\n"; } else { s += "Player Two is fourth\n"; } game.lbplayerfour.Text = this.Playertwo.Text; break;
                      }
                  }
                  if (tthree == i)
                  {
                      switch (c)
                      {
                          case 1: if (myanmar == 1) { s += "ကစားသမားသံုးသည္  ပထမ\n"; } else { s += "Player Three is First\n"; } game.lb2playerone.Text = this.Playerthree.Text; break;
                          case 2: if (myanmar == 1) { s += "ကစားသမားသံုးသည္  ဒုတိယ \n"; } else { s += "Player Three is second \n"; } game.lb2playertwo.Text = this.Playerthree.Text; break;
                          case 3: if (myanmar == 1) { s += "ကစားသမားသံုးသည္   တတိယ\n"; } else { s += "Player Three is third\n"; } game.lbplayerthree.Text = this.Playerthree.Text; break;
                          case 4: if (myanmar == 1) { s += "ကစားသမားသံုးသည္   စတုတၳ\n"; } else { s += "Player Three is fourth\n"; } game.lbplayerfour.Text = this.Playerthree.Text; break;
                      }
                  }
                  if (ffour  == i)
                  {
                      switch (c)
                      {
                          case 1: if (myanmar == 1) { s += "ကစားသမားေလးသည္  ပထမ\n"; } else { s += "Player Four is First\n"; } game.lb2playerone.Text = this.Playerfour.Text; break;
                          case 2: if (myanmar == 1) { s += "ကစားသမားေလးသည္ ဒုတိယ \n"; } else { s += "Player Four is second \n"; } game.lb2playertwo.Text = this.Playerfour.Text; break;
                          case 3: if (myanmar == 1) { s += "ကစားသမားေလးသည္ တတိယ\n"; } else { s += "Player Four is third\n"; } game.lbplayerthree.Text = this.Playerfour.Text; break;
                          case 4: if (myanmar == 1) { s += "ကစားသမားေလးသည္  စတုတၳ\n"; } else { s += "Player Four is fourth\n"; } game.lbplayerfour.Text = this.Playerfour.Text; break;
                      }
                  }

              }
              Form3 f3 = new Form3();
              f3.label1.Text = s;
              f3.Show();
              
             // MessageBox.Show(s);
              start.Enabled = true;
            

          }
            

        }

        private void exit_Click(object sender, EventArgs e)
        {
            player2.URL = "realclick.mp3";
            player2.controls.play();
            this.Close();
        }

        private void moreplay_Click(object sender, EventArgs e)
        {
            player2.URL = "realclick.mp3";
            player2.controls.play();
            three.Visible = true;
            four.Visible = true;
            comfirm.Visible = true;
            cancal.Visible = true;

        }

        private void comfirm_Click(object sender, EventArgs e)
        {
            player2.URL = "realclick.mp3";
            player2.controls.play();
            if (three.Checked)
            {
              
                Playerthree.Visible = true ;
                lbPlayerthree.Visible = true ;
                Playerfour.Visible = false ;
                lbPlayerfour.Visible = false ;
                pp = 2;
                
            }

            if (four.Checked )
            {
             
                Playerthree.Visible = true;
                lbPlayerthree.Visible = true;
                Playerfour.Visible = true;
                lbPlayerfour.Visible = true;
                pp = 3;

            }
           
        }

        private void lbPlayerthree_Click(object sender, EventArgs e)
        {

        }

        private void cancal_Click(object sender, EventArgs e)
        {
            player2.URL = "realclick.mp3";
            player2.controls.play();
            Playerthree.Visible = false;
            lbPlayerthree.Visible = false;
            Playerfour.Visible = false;
            lbPlayerfour.Visible = false;
            three.Visible = false;
            four.Visible = false;
            comfirm.Visible = false;
          
            cancal.Visible = false;
            pp = 0;
            
        }

        private void three_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            player2.URL = "realclick.mp3";
            player2.controls.play();
            myanmar = 1;
            lbPlayerone.Text = "ကစားသမားတစ္ဧ။္ နာမည္";
            lbPlayertwo.Text = "ကစားသမားႏွစ္ဧ။္ နာမည္";
            lbPlayerthree.Text = "ကစားသမားသံုးဧ။္ နာမည္";
            lbPlayerfour.Text = "ကစားသမားေလးဧ။္ နာမည္";
            button1.Text = "အံစာ လွိမ့္မည္။";
            Help.Text = "အကူအညီ";
            about.Text = "အေၾကာင္း";
            exit.Text = "ထြက္ခြာ";
            moreplay.Text = "ႏွစ္ေယာက္ထက္ပုိကစားမည္။";
            start.Text = "ေဆာ့မည္။";
            three.Text = "သံုးေယာက္";
            four.Text = "ေလးေယာက္";
            comfirm.Text = "အတည္ျပဳ";
            cancal.Text = "ျပန္ဖ်က္";
            button2.Text = "";
            label3.Text = "ကစားသမားတစ္ေနရာမွာ နာမည္ေရးၿပီး ပ၊ဒု၊တ အတြက္ အံစာလွိမ့္ပါ။";
            
           // tt.back.Text = "ေနာက္သို႔";
            //tt.Exit.Text = "ထြက္ခြာ";
            //tt.restart.Text = "ျပန္လည္စ";
            game.textBox1.Text = "1";
            button2.Text = "ဘာသာ";
            button3.Visible = false;
            button4.Visible = false;
           
        }

        private void lbPlayerone_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            player2.URL = "realclick.mp3";
            player2.controls.play();
            button3.Visible = true ;
            button4.Visible = true ;
        }

        private void about_Click(object sender, EventArgs e)
        {
            player2.URL = "realclick.mp3";
            player2.controls.play();
            About bb = new About();
            bb.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player2.URL = "realclick.mp3";
            player2.controls.play();
            myanmar = 0;
            lbPlayerone.Text = "Player One";
            lbPlayertwo.Text = "Player Two";
            lbPlayerthree.Text = "Player Three";
            lbPlayerfour.Text = "Player Four";
            button1.Text = "Roll Dice";
            Help.Text = "Help";
            about.Text = "About";
            exit.Text = "Exist";
            moreplay.Text ="Two more play";
            start.Text = "Play";
            three.Text = "Three";
            four.Text ="Four";
            comfirm.Text = "Comfirm";
            cancal.Text = "Cancel";
            button2.Text = "Language";
            label3.Text = "Player One's add your name and roll dice for First or Second.";

            // tt.back.Text = "ေနာက္သို႔";
            //tt.Exit.Text = "ထြက္ခြာ";
            //tt.restart.Text = "ျပန္လည္စ";
            game.textBox1.Text = "0";
            button2.Text = "Language";
            button3.Visible = false;
            button4.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Help_Click(object sender, EventArgs e)
        {
            player2.URL = "realclick.mp3";
            player2.controls.play();
            Help hh = new Help();
            hh.Show();
        }

       

       
       
        }
       
      /*  public void  rollnum()
        {   
        timer1.Start();
        testnum = num3;
        return testnum;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            num3 = 0;
             second+=1;
             Random r = new Random();
             if (second <= 10)
             {
                 num2 = r.Next(1, 7);
                 pictureBox2.Image = Image.FromFile(@"E:\C#\SnakeLadder2\SnakeLadder2\Resources\" + num2 + ".png");
                 pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
             }
             else
             {
                 timer1.Stop();
                 num3 = num2;
                 second = 0;
             }
        }*/
    }
