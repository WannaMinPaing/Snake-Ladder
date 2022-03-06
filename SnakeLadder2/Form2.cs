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
    public partial class fromgame : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player1 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player2 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player3 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player4 = new WMPLib.WindowsMediaPlayer();
        float  x = 10, y = 530, xx = -10, yy = 530, bx = -30, by = 530, gx = -50, gy = 530;
        int redpostion = 0, blueposition = 0, blackposition = 0, greenposition = 0, ix = 1, ib = 1, ig = 1, ibl = 1;
        int flag = 0, c, threehave = 0, fourhave = 0, myanmar;
       
        int num = 0;
      
        
        public fromgame()
        {
            InitializeComponent();
          //  player2.URL = "click.mp3";
          
        }

       

        private void roll_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
               
                player1.URL = "test.mp3";
                player1.controls.play();
                if (ix == 1)
                {
                    onered.Location = new Point(116, 530); ix++;
                   // player1.controls.stop();
                }
                Random r = new Random();
                num = r.Next(1 , 7);
                dice.Image = Image.FromFile(@"C:\SnakeLadder2\SnakeLadder2\Resources\" + num + ".png");
                dice.SizeMode = PictureBoxSizeMode.StretchImage;
               if(myanmar ==1)
               { turn.Text = lb2playertwo.Text + "အလွည့္"; }
               else  turn.Text = lb2playertwo.Text + "Turn";
                turn.BackColor = System.Drawing.Color.Blue ;


                for (int i = 0; i < num; i++)
                {
                    redpostion += 1;


                    x += 106;
                    timer2.Start();
                }
              
                flag = 1;
            }
        
        }

        private void fromgame_Load(object sender, EventArgs e)
        {
            dice.Image = Image.FromFile(@"C:\SnakeLadder2\SnakeLadder2\Resources\roll.png");
            dice.SizeMode = PictureBoxSizeMode.StretchImage;
            if (myanmar == 1)
            { turn.Text = lb2playerone.Text + "အလွည့္"; }
            else turn.Text = lb2playerone.Text + "Turn";
         
            turn.BackColor = System.Drawing.Color.Red;
            timer1.Stop();
            textBox1.Visible = false;
            if (lbplayerthree.Text == "Player Three")
            {
                three2.Visible = false;
                three1.Visible = false;
                r3.Visible = false;
            }
            else
            {
             threehave = 2;
            }

            if (lbplayerfour.Text == "Player Four")
            {
               four2.Visible = false;
               four1.Visible = false;
                r4.Visible = false;
            }
            else
            {
                fourhave = 3;
            }

            myanmar = Convert.ToInt16(textBox1.Text);
            if(myanmar ==1)
            {
                restart.Text = "ျပန္လည္စ";
                Exit.Text = "ထြက္ခြာ";
                back.Text = "ေနာက္သို႔";
                roll1.Text = "ႏွိပ္ပါ";
                roll2.Text = "ႏွိပ္ပါ";
                r3.Text = "ႏွိပ္ပါ";
                r4.Text = "ႏွိပ္ပါ";
               
                 turn.Text = lb2playerone.Text + "အလွည့္"; 
                

                turn.BackColor = System.Drawing.Color.Red;
            }
        else { turn.Text = lb2playerone.Text + "Turn";

                turn.BackColor = System.Drawing.Color.Red;}

            
        }

       
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roll2_Click(object sender, EventArgs e)
        {
           
            if (flag == 1)
            {
                player2.URL = "test.mp3";
                player2.controls.play();
                
                Random r = new Random();
                num = r.Next(1,7);
                dice.Image = Image.FromFile(@"C:\SnakeLadder2\SnakeLadder2\Resources\" + num + ".png");
                dice.SizeMode = PictureBoxSizeMode.StretchImage;
                if (ib == 1)
                {
                    bluetwo.Location = new Point(96, 530); ib++;
                   // player2.controls.stop();
                }
                if (threehave == 2)
                {
                    if (myanmar == 1)

                    { turn.Text = lbplayerthree.Text + "အလွည့္"; }
                    else turn.Text = lbplayerthree.Text + "Turn";
                    turn.BackColor = System.Drawing.Color.Yellow ;
                }
                else
                {
                    if (myanmar == 1)
                    { turn.Text = lb2playerone.Text + "အလွည့္"; }
                    else turn.Text = lb2playerone.Text + "Turn";
                    turn.BackColor = System.Drawing.Color.Red;
                }


                for (int i = 0; i < num; i++)
                {
                    blueposition  += 1;
                    xx += 106;
                }
                timer6.Start();//2timer
                if (threehave == 2)
                    flag = 2;
                else flag = 0;
            }
        }

        private void lb2playerone_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            player.URL = "realclick.mp3";
            player.controls.play();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            player2.URL = "realclick.mp3";
            player2.controls.play();
            Form1 f = new Form1();
            f.Show();
            if (myanmar == 1)
            {
               f. lbPlayerone.Text = "ကစားသမားတစ္ဧ။္ နာမည္";
                f.lbPlayertwo.Text = "ကစားသမားႏွစ္ဧ။္ နာမည္";
              f.  lbPlayerthree.Text = "ကစားသမားသံုးဧ။္ နာမည္";
              f.  lbPlayerfour.Text = "ကစားသမားေလးဧ။္ နာမည္";
               f. button1.Text = "အံစာ လွိမ့္မည္။";
              f.  Help.Text = "အကူအညီ";
               f. about.Text = "အေၾကာင္း";
              f.  exit.Text = "ထြက္ခြာ";
              f.  moreplay.Text = "ႏွစ္ေယာက္ထက္ပုိကစားမည္။";
             f.   start.Text = "ေဆာ့မည္။";
              f.  three.Text = "သံုးေယာက္";
              f.  four.Text = "ေလးေယာက္";
              f.  comfirm.Text = "အတည္ျပဳ";
              f.  cancal.Text = "ျပန္ဖ်က္";
              f.  button2.Text = "";
              f.  label3.Text = "ကစားသမားတစ္ေနရာမွာ နာမည္ေရးၿပီး ပ၊ဒု၊တ အတြက္ အံစာလွိမ့္ပါ။";

                // tt.back.Text = "ေနာက္သို႔";
                //tt.Exit.Text = "ထြက္ခြာ";
                //tt.restart.Text = "ျပန္လည္စ";
                //  game.textBox1.Text = "1";
               f. button2.Text = "ဘာသာ";
            }
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }//click  end

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (onered.Left <= x)
            { onered.Left += 10; }
            else timer1.Stop();
        }

        private void r4_Click(object sender, EventArgs e)
        {

            if (flag == 3)
            {
                player4.URL = "test.mp3";
                player4.controls.play();
                if (ig == 1)
                {
                    four2.Location = new Point(56, 530); ig++;
                   // player4.controls.stop();
                }
                Random r = new Random();
                num = r.Next(1, 7);
                dice.Image = Image.FromFile(@"C:\SnakeLadder2\SnakeLadder2\Resources\" + num + ".png");
                dice.SizeMode = PictureBoxSizeMode.StretchImage;
              
                if(myanmar ==1)
                { turn.Text = lb2playerone.Text + "အလွည့္"; }
               else  turn.Text = lb2playerone.Text + "Turn";
                turn.BackColor = System.Drawing.Color.Red;
                
                for (int i = 0; i < num; i++)
                {
                    greenposition  += 1;
                    gx += 106;
                    timer14.Start();
                }
                flag = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void r3_Click(object sender, EventArgs e)
        {
            if (flag == 2)
            {
                player3.URL = "test.mp3";
                player3.controls.play();
               if (ibl == 1)
               {
                   three2.Location = new Point(76, 530); ibl++;
                  // player3.controls.stop();
               }

                Random r = new Random();
                num = r.Next(1, 7);
                dice.Image = Image.FromFile(@"C:\SnakeLadder2\SnakeLadder2\Resources\" + num + ".png");
                dice.SizeMode = PictureBoxSizeMode.StretchImage;
                if (fourhave == 3)
                {       if(myanmar ==1)
                        { turn.Text = lbplayerfour.Text + "အလွည့္"; }
                       else  turn.Text = lbplayerfour.Text + "Turn";
                        turn.BackColor = System.Drawing.Color.Green ;
                }
                else
                {
                   if(myanmar ==1)
                   { turn.Text = lb2playerone.Text + "အလွည့္"; }
                   else  turn.Text = lb2playerone.Text + "Turn";
                    turn.BackColor = System.Drawing.Color.Red;
               }


                for (int i = 0; i < num; i++)
                {
                    blackposition += 1;
                    bx = 106;
                    timer10.Start();
                }

                if (fourhave == 3)
                    flag = 3;
                else flag = 0;
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            player2.URL = "realclick.mp3";
            player2.controls.play();
            Reset(); ix = 1; ib = 1; ibl = 1; ig = 1;

        }
    public void Reset()
        {

            redpostion = 0;
            blueposition = 0;
            blackposition = 0;
            greenposition = 0;
            x = 10; y = 530;
            xx = -10; yy = 530;
            bx = -30; by = 530;
            gx = -50; gy = 530;
            onered.Location = new Point(116, 588);
            bluetwo.Location = new Point(96, 588);
            three2.Location = new Point(76, 588);
            four2.Location = new Point(56, 588);
            flag = 0;
            turn.Text = lb2playerone.Text + "Turn";
            turn.BackColor = System.Drawing.Color.Red;
            roll1.Enabled = true; roll2.Enabled = true; r3.Enabled = true; r4.Enabled = true;



        }

    public  void timer2_Tick(object sender, EventArgs e)
    {
       
       
        //player2.URL = "test.mp3";
        //player2.controls.play();
         switch(redpostion )
        {
            case 1: player1.controls.stop(); break;
            case 2: if (onered.Left <= 222) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(222, 530); player1.controls.stop(); } break;

            case 3: if (onered.Left <= 328) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(328, 530); redpostion = 51;   timer4.Start(); } break;

            case 4: if (onered.Left <= 434) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(434, 530); player1.controls.stop(); } break;
            case 5: if (onered.Left <= 540) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(540, 530); player1.controls.stop(); } break;

            case 6: if (onered.Left <= 646) { onered.Left += 20;  } else { timer2.Stop(); onered.Location = new Point(646, 530); redpostion = 27; timer4.Start(); } break;

            case 7: if (onered.Left <= 752) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(752, 530); player1.controls.stop(); } break;
            case 8: if (onered.Left <= 858) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(858, 530); player1.controls.stop(); } break;
            case 9: if (onered.Left <= 964) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(964, 530); player1.controls.stop(); } break;
            case 10: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(1070, 530); player1.controls.stop(); } break;
            case 11: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(116, 472); player1.controls.stop(); } break;


            case 12: if (onered.Top == 530 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 530) {onered.Location = new Point(116, 472);}timer3.Start(); } break;
            case 13: if (onered.Top == 530 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 530) {onered.Location = new Point(116, 472);}timer3.Start(); } break;
            case 14: if (onered.Top == 530 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 530) {onered.Location = new Point(116, 472);}timer3.Start(); } break;
            case 15: if (onered.Top == 530 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 530) {onered.Location = new Point(116, 472);}timer3.Start(); } break;
            case 16: if (onered.Top == 530 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 530) {onered.Location = new Point(116, 472);}timer3.Start(); } break;


            case 17: if (onered.Left <= 752) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(752, 472); player1.controls.stop(); } break;
            case 18: if (onered.Left <= 858) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(858, 472); player1.controls.stop(); } break;
            case 19: if (onered.Left <= 964) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(964, 472); player1.controls.stop(); } break;
            case 20: if (onered.Left <= 1070) { onered.Left += 20; } else if (onered.Top >= 182) { onered.Top -= 10; } else { timer2.Stop(); onered.Location = new Point(1070, 182); redpostion = 70; player2.controls.stop(); } break;
            case 21: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(116, 414); player1.controls.stop(); } break;

            case 22: if (onered.Top == 472 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 472) { onered.Location = new Point(116, 414); } timer3.Start(); } break;
            case 23: if (onered.Top == 472 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 472) { onered.Location = new Point(116, 414); } timer3.Start(); } break;
            case 24: if (onered.Top == 472 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 472) { onered.Location = new Point(116, 414); } timer3.Start(); } break;
            case 25: if (onered.Top == 472 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 472) { onered.Location = new Point(116, 414); } timer3.Start(); } break;
            case 26: if (onered.Top == 472 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 472) { onered.Location = new Point(116, 414); } timer3.Start(); } break;
            //case 22: if (onered.Top >= 414)
             //   {
                  //  if (onered.Left >= 222) { onered.Left -= 20; } else if (onered.Top >= 414) { onered.Top -= 5; }
              //  }
              //  else if (onered.Left <= 222) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(222, 414); } break;

          /*  case 223: if (onered.Top >= 414)
                {
                    if (onered.Left >= 328) { onered.Left -= 20; } else if (onered.Top >= 414) { onered.Top -= 5; }
                }
                else if (onered.Left <= 328) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(328, 414); } break;

            case 224: if (onered.Top >= 414)
                {
                    if (onered.Left >= 434) { onered.Left -= 20; } else if (onered.Top >= 414) { onered.Top -= 5; }
                }
                else if (onered.Left <= 434) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(434, 414); } break;

          //  case 25: if (onered.Left <= 540) { onered.Left += 20; } else if (onered.Top <= 530) { onered.Top += 5; } else { timer2.Stop(); redpostion = 5; onered.Location = new Point(540, 530); redpostion = 5; timer4.Start(); } break;
            case 225: if (onered.Top >= 414)
                {
                    if (onered.Left >= 540) { onered.Left -= 20; } else if (onered.Top >= 414) { onered.Top -= 5; }
                }
                else if (onered.Left <= 540) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(540, 414); redpostion = 5; timer4.Start(); } break;
          
            case 226: if (onered.Top >= 414)
               {
                   if (onered.Left >= 646) { onered.Left -= 20; } else if (onered.Top >= 414) { onered.Top -= 5; }
               }
               else if (onered.Left <= 646) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(646, 414); } break;*/

            case 27: if (onered.Left <= 752) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(752, 414); player1.controls.stop(); } break;
            case 28: if (onered.Left <= 858) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(858, 414); player1.controls.stop(); } break;
            case 29: if (onered.Left <= 964) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(964, 414); player1.controls.stop(); } break;
            case 30: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(1070, 414); player1.controls.stop(); } break;

      /*     case 32: if (onered.Top >=356)
               {
                   if (onered.Left >= 222) { onered.Left -= 20; } else if (onered.Top >= 356) { onered.Top -= 5; }
               }
               else if (onered.Left <= 222) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(222, 356); } break;

           case 33: if (onered.Top >= 356)
               {
                   if (onered.Left >= 328) { onered.Left -= 20; } else if (onered.Top >= 356) { onered.Top -= 5; }
               }
               else if (onered.Left <= 328) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(328, 356); } break;

           case 34: if (onered.Top >= 356)
               {
                   if (onered.Left >= 434) { onered.Left -= 20; } else if (onered.Top >= 356) { onered.Top -= 5; }
               }
               else if (onered.Left <= 434) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(434, 356);redpostion =1;   timer4.Start();} break;

           case 35: if (onered.Top >= 356)
               {
                   if (onered.Left >= 540) { onered.Left -= 20; } else if (onered.Top >= 356) { onered.Top -= 5; }
               }
               else if (onered.Left <= 540) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(540, 356); } break;

           case 36: if (onered.Top >= 356)
               {
                   if (onered.Left >= 646) { onered.Left -= 20; } else if (onered.Top >= 356) { onered.Top -= 5; }
               }
               else if (onered.Left<= 646) { onered.Left += 20; } else  { timer2.Stop();onered.Location = new Point(646, 356); redpostion =55;timer4.Start (); } break;*/


            case 31: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(116, 356); player1.controls.stop(); } break;
           case 32: if (onered.Top == 414 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 414) { onered.Location = new Point(116, 356); } timer3.Start(); } break;
           case 33: if (onered.Top == 414 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 414) { onered.Location = new Point(116, 356); } timer3.Start(); } break;
           case 34: if (onered.Top == 414 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 414) { onered.Location = new Point(116, 356); } timer3.Start(); } break;
           case 35: if (onered.Top == 414 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 414) { onered.Location = new Point(116, 356); } timer3.Start(); } break;
           case 36: if (onered.Top == 414 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 414) { onered.Location = new Point(116, 356); } timer3.Start(); } break;

           case 37: if (onered.Left <= 752) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(752, 356); player1.controls.stop(); } break;
           case 38: if (onered.Left <= 858) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(858, 356); player1.controls.stop(); } break;
           case 39: if (onered.Left <= 964) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(964, 356); player1.controls.stop(); } break;
           case 40: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(1070, 356); player1.controls.stop(); } break;

        /*   case 42: if (onered.Top >= 298)
               {
                   if (onered.Left >= 222) { onered.Left -= 20; } else if (onered.Top >= 298) { onered.Top -= 5; }
               }
               else if (onered.Left <= 222) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(222, 298); } break;


           case 43: if (onered.Top >= 298)
               {
                   if (onered.Left >= 328) { onered.Left -= 20; } else if (onered.Top >= 298) { onered.Top -= 5; }
               }
               else if (onered.Left <= 328) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(328, 298); } break;

           case 44: if (onered.Top >= 298)
               {
                   if (onered.Left >= 434) { onered.Left -= 20; } else if (onered.Top >= 298) { onered.Top -= 5; }
               }
               else if (onered.Left <= 434) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(434, 298); } break;

           case 45: if (onered.Top >= 298)
               {
                   if (onered.Left >= 540) { onered.Left -= 20; } else if (onered.Top >= 298) { onered.Top -= 5; }
               }
               else if (onered.Left <= 540) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(540, 298); } break;

          case 46: if (onered.Top >= 298)
               {
                   if (onered.Left >= 646) { onered.Left -= 20; } else if (onered.Top >= 298) { onered.Top -= 5; }
               }
               else if (onered.Left <= 646) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(646, 298); } break;*/

           case 41: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(116, 298); player1.controls.stop(); } break;

           case 42: if (onered.Top == 356 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 356) { onered.Location = new Point(116, 298); } timer3.Start(); } break;
           case 43: if (onered.Top == 356 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 356) { onered.Location = new Point(116, 298); } timer3.Start(); } break;
           case 44: if (onered.Top == 356 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 356) { onered.Location = new Point(116, 298); } timer3.Start(); } break;
           case 45: if (onered.Top == 356 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 356) { onered.Location = new Point(116, 298); } timer3.Start(); } break;
           case 46: if (onered.Top == 356 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 356) { onered.Location = new Point(116, 298); } timer3.Start(); } break;

          case 47: if (onered.Left <= 752) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(752, 298); redpostion = 19; timer4.Start(); } break;


          case 48: if (onered.Left <= 858) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(858, 298); player1.controls.stop(); } break;
          case 49: if (onered.Left <= 964) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(964, 298); player1.controls.stop(); } break;
          case 50: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(1070, 298); player1.controls.stop(); } break;

          /*case 52: if (onered.Top >= 240)
              {
                  if (onered.Left >= 222) { onered.Left -= 20; } else if (onered.Top >= 240) { onered.Top -= 5; }
              }
              else if (onered.Left <= 222) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(222, 240); } break;

          case 53: if (onered.Top >= 240)
              {
                  if (onered.Left >= 328) { onered.Left -= 20; } else if (onered.Top >= 240) { onered.Top -= 5; }
              }
              else if (onered.Left <= 328) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(328, 240); } break;


          case 54: if (onered.Top >= 240)
              {
                  if (onered.Left >= 434) { onered.Left -= 20; } else if (onered.Top >= 240) { onered.Top -= 5; }
              }
              else if (onered.Left <= 434) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(434, 240); } break;


          case 55: if (onered.Top >= 240)
              {
                  if (onered.Left >= 540) { onered.Left -= 20; } else if (onered.Top >= 240) { onered.Top -= 5; }
              }
              else if (onered.Left <= 540) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(540, 240); } break;

          case 56: if (onered.Top >= 240)
              {
                  if (onered.Left >= 646) { onered.Left -= 20; } else if (onered.Top >= 240) { onered.Top -= 5; }
              }
              else if (onered.Left <= 646) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(646, 240); } break;*/

          case 51: if (onered.Left < 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(116, 240); player1.controls.stop(); } break;

          case 52: if (onered.Top == 298 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 298) { onered.Location = new Point(116, 240); } timer3.Start(); } break;
          case 53: if (onered.Top == 298 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 298) { onered.Location = new Point(116, 240); } timer3.Start(); } break;
          case 54: if (onered.Top == 298 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 298) { onered.Location = new Point(116, 240); } timer3.Start(); } break;
          case 55: if (onered.Top == 298 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 298) { onered.Location = new Point(116, 240); } timer3.Start(); } break;
          case 56: if (onered.Top == 298 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 298) { onered.Location = new Point(116, 240); } timer3.Start(); } break;

          case 57: if (onered.Left <= 752) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(752, 240); player1.controls.stop(); } break;
          case 58: if (onered.Left <= 858) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(858, 240); player1.controls.stop(); } break;
          case 59: if (onered.Left <= 964) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(964, 240); player1.controls.stop(); } break;
          case 60: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(1070, 240); player1.controls.stop(); } break;

       /*   case 62: if (onered.Top >= 182)
              {
                  if (onered.Left >= 222) { onered.Left -= 20; } else if (onered.Top >= 182) { onered.Top -= 5; }
              }
              else if (onered.Left <= 222) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(222, 182); } break;


          case 63: if (onered.Top >= 182)
              {
                  if (onered.Left >= 328) { onered.Left -= 20; } else if (onered.Top >= 182) { onered.Top -= 5; }
              }
              else if (onered.Left <= 328) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(328, 182); redpostion = 95; timer4.Start(); } break;

          case 64: if (onered.Top >=182 )
              {
                  if (onered.Left >= 434) { onered.Left -= 20; } else if (onered.Top >= 182) { onered.Top -= 5; }
              }
              else if (onered.Left <= 434) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(434,182); } break;

          case 65: if (onered.Top >= 182)
              {
                  if (onered.Left >= 540) { onered.Left -= 20; } else if (onered.Top >= 182) { onered.Top -= 5; }
              }
              else if (onered.Left <= 540) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(540, 182); redpostion = 52; timer4.Start(); } break;

          case 66: if (onered.Top >= 182)
              {
                  if (onered.Left >= 646) { onered.Left -= 20; } else if (onered.Top >= 182) { onered.Top -= 5; }
              }
              else if (onered.Left <= 646) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(646, 182); } break;

          case 67: if (onered.Left <= 752) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(752, 182); } break;


          case 68: if (onered.Left <= 858) { onered.Left += 20; } else if (onered.Top >=8) { onered.Top -= 10; } else { timer2.Stop(); onered.Location = new Point(858, 8
        * redpostion = 98;timer4.start();. } break;

          case 69: if (onered.Left <= 964) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(964, 182); } break;                                    
          case 70: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(1070, 182); } break;*/
          case 61: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(116, 182); player1.controls.stop(); } break;

          case 62: if (onered.Top == 240 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 240) { onered.Location = new Point(116, 182); } timer3.Start(); } break;
          case 63: if (onered.Top == 240 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 240) { onered.Location = new Point(116, 182); } timer3.Start(); } break;
          case 64: if (onered.Top == 240 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 240) { onered.Location = new Point(116, 182); } timer3.Start(); } break;
          case 65: if (onered.Top == 240 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 240) { onered.Location = new Point(116, 182); } timer3.Start(); } break;
          case 66: if (onered.Top == 240 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 240) { onered.Location = new Point(116, 182); } timer3.Start(); } break;

          case 67: if (onered.Left <= 752) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(752, 182); player1.controls.stop(); } break;
          case 68: if (onered.Left <= 858) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(858, 182); redpostion = 98; timer4.Start(); } break;
          case 69: if (onered.Left <= 964) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(964, 182); player1.controls.stop(); } break;
          case 70: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(1070, 182); player1.controls.stop(); } break;
          case 71: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(116, 124); player1.controls.stop(); } break;

          case 72: if (onered.Top == 182 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 182) { onered.Location = new Point(116, 124); } timer3.Start(); } break;
          case 73: if (onered.Top == 182 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 182) { onered.Location = new Point(116, 124); } timer3.Start(); } break;
          case 74: if (onered.Top == 182 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 182) { onered.Location = new Point(116, 124); } timer3.Start(); } break;
          case 75: if (onered.Top == 182 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 182) { onered.Location = new Point(116, 124); } timer3.Start(); } break;
          case 76: if (onered.Top == 182 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 182) { onered.Location = new Point(116, 124); } timer3.Start(); } break;

          case 77: if (onered.Left <= 752) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(752, 124); player1.controls.stop(); } break;
          case 78: if (onered.Left <= 858) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(858, 124); player1.controls.stop(); } break;
          case 79: if (onered.Left <= 964) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(964, 124); player1.controls.stop(); } break;
          case 80: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(1070, 124); player1.controls.stop(); } break;
          case 81: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(116, 66); player1.controls.stop(); } break;

          case 82: if (onered.Top == 124 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 124) { onered.Location = new Point(116, 66); } timer3.Start(); } break;
          case 83: if (onered.Top == 124 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 124) { onered.Location = new Point(116, 66); } timer3.Start(); } break;
          case 84: if (onered.Top == 124 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 124) { onered.Location = new Point(116, 66); } timer3.Start(); } break;
          case 85: if (onered.Top == 124 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 124) { onered.Location = new Point(116, 66); } timer3.Start(); } break;
          case 86: if (onered.Top == 124 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 124) { onered.Location = new Point(116, 66); } timer3.Start(); } break;

          case 87: if (onered.Left <= 752 ) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(752, 66); redpostion = 57; timer4.Start(); } break;
          case 88: if (onered.Left <= 858) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(858, 66); player1.controls.stop(); } break;
          case 89: if (onered.Left <= 964) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(964, 66); player1.controls.stop(); } break;
          case 90: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(1070, 66); player1.controls.stop(); } break;
          case 91: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(116, 8); redpostion = 61; timer4.Start(); } break;

          case 92: if (onered.Top == 66 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 66) { onered.Location = new Point(116, 8); } timer3.Start(); } break;
          case 93: if (onered.Top == 66 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 66) { onered.Location = new Point(116, 8); } timer3.Start(); } break;
          case 94: if (onered.Top == 66 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 66) { onered.Location = new Point(116, 8); } timer3.Start(); } break;
          case 95: if (onered.Top == 66 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 66) { onered.Location = new Point(116, 8); } timer3.Start(); } break;
          case 96: if (onered.Top == 66 && onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); if (onered.Top == 66) { onered.Location = new Point(116, 8); } timer3.Start(); } break;

          case 97: if (onered.Left <= 752) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(752, 8); player1.controls.stop(); } break;
          case 98: if (onered.Left <= 858) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(858, 8); player1.controls.stop(); } break;
          case  99: if (onered.Left <= 964 ) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(964 , 8); redpostion = 69; timer4.Start(); } break;
          case 100: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(1070, 8); player1.controls.stop(); Form4 f4 = new Form4();f4.Show(); roll1.Enabled = false; roll2.Enabled = false; r3.Enabled = false; r4.Enabled = false; } break;
          

          //case 11: if (onered.Left >= 116) { onered.Left -= 20; } else if (onered.Top >= 472) { onered.Top -= 31; } else { timer2.Stop(); onered.Location = new Point(116,472); } break;
          //case 21: if (onered.Left >= 116) { onered.Left -= 20; } else if (onered.Top >= 414) { onered.Top -= 31; } else { timer2.Stop(); onered.Location = new Point(116,414); } break;

          





         // case 81: if (onered.Left >= 1070) { onered.Left -= 20; } else if (onered.Top >= 66) { onered.Top -= 31; } else { timer2.Stop(); onered.Location = new Point(116, 66); } break;



      /*    case 72: if (onered.Top >= 124)
              {
                  if (onered.Left >= 222) { onered.Left -= 20; } else if (onered.Top >= 124) { onered.Top -= 5; }
              }
              else if (onered.Left <= 222) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(222, 124); } break;

          case 73: if (onered.Top >= 124)
              {
                  if (onered.Left >= 328) { onered.Left -= 20; } else if (onered.Top >= 124) { onered.Top -= 5; }
              }
              else if (onered.Left <= 328) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(328, 124); } break;


          case 74: if (onered.Top >= 124)
              {
                  if (onered.Left >= 434) { onered.Left -= 20; } else if (onered.Top >= 124) { onered.Top -= 5; }
              }
              else if (onered.Left <= 434) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(434, 124); } break;


          case 75: if (onered.Top >= 124)
              {
                  if (onered.Left >= 540) { onered.Left -= 20; } else if (onered.Top >= 124) { onered.Top -= 5; }
              }
              else if (onered.Left <= 540) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(540, 124); } break;

          case 76: if (onered.Top >= 124)
              {
                  if (onered.Left >= 646) { onered.Left -= 20; } else if (onered.Top >= 124) { onered.Top -= 5; }
              }
              else if (onered.Left <= 646) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(646, 124); } break;

          case 77: if (onered.Left <= 752) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(752, 124); } break;
          case 78: if (onered.Left <= 858) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(858, 124); } break;
          case 79: if (onered.Left <= 964) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(964, 124); } break;
          case 80: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(1070, 124); } break;


          case 82: if (onered.Top >= 66)
              {
                  if (onered.Left >= 222) { onered.Left -= 20; } else if (onered.Top >= 66) { onered.Top -= 5; }
              }
              else if (onered.Left <= 222) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(222, 66); } break;

          case 83: if (onered.Top >= 66)
              {
                  if (onered.Left >= 328) { onered.Left -= 20; } else if (onered.Top >= 66) { onered.Top -= 5; }
              }
              else if (onered.Left <= 328) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(328, 66); } break;


          case 84: if (onered.Top >= 66)
              {
                  if (onered.Left >= 434) { onered.Left -= 20; } else if (onered.Top >= 66) { onered.Top -= 5; }
              }
              else if (onered.Left <= 434) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(434, 66); } break;


          case 85: if (onered.Top >= 66)
              {
                  if (onered.Left >= 540) { onered.Left -= 20; } else if (onered.Top >= 66) { onered.Top -= 5; }
              }
              else if (onered.Left <= 540) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(540,66); } break;

          case 86: if (onered.Top >= 66)
              {
                  if (onered.Left >= 646) { onered.Left -= 20; } else if (onered.Top >= 66) { onered.Top -= 5; }
              }
              else if (onered.Left <= 646) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(646, 66); } break;

          case 87: if (onered.Left <= 752) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(752, 66); redpostion = 57; timer4.Start(); } break;
          case 88: if (onered.Left <= 858) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(858, 66); } break;
          case 89: if (onered.Left <= 964) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(964, 66); } break;
          case 90: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(1070, 66); } break;*/

        /*  case 92: if (onered.Top >= 8)
              {
                  if (onered.Left >= 222) { onered.Left -= 20; } else if (onered.Top >= 8) { onered.Top -= 5; }
              }
              else if (onered.Left <= 222) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(222, 8); } break;

          case 93: if (onered.Top >= 8)
              {
                  if (onered.Left >= 328) { onered.Left -= 20; } else if (onered.Top >= 8) { onered.Top -= 5; }
              }
              else if (onered.Left <= 328) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(328, 8); } break;


          case 94: if (onered.Top >= 8)
              {
                  if (onered.Left >= 434) { onered.Left -= 20; } else if (onered.Top >= 8) { onered.Top -= 5; }
              }
              else if (onered.Left <= 434) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(434, 8); } break;


          case 95: if (onered.Top >= 8)
              {
                  if (onered.Left >= 540) { onered.Left -= 20; } else if (onered.Top >= 8) { onered.Top -= 5; }
              }
              else if (onered.Left <= 540) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(540, 8); } break;

          case 96: if (onered.Top >= 8)
              {
                  if (onered.Left >= 646) { onered.Left -= 20; } else if (onered.Top >= 8) { onered.Top -= 5; }
              }
              else if (onered.Left <= 646) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(646, 8); } break;

          case 97: if (onered.Left <= 752) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(752, 8); } break;
          case 98: if (onered.Left <= 858) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(858, 8); } break;
          case 99: if (onered.Left <= 964) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(964, 8); redpostion = 69; timer4.Start(); } break;
        
         case 100: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(1070, 8); MessageBox.Show("Win Game"); roll1.Enabled = false; roll2.Enabled = false; r3.Enabled = false; r4.Enabled = false; } break;
         
         */
          case 101: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(1070, 8); redpostion = 99; timer5.Start(); } break;
         // case 102: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(1070, 8); redpostion = 98; timer4.Start(); } break;
          case 102: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(1070, 8); redpostion = 98; timer3.Start(); } break;

          case 103: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(1070, 8); redpostion = 97; timer4.Start(); } break;
          case 104: if (onered.Left <= 1070) { onered.Left += 20; } else { timer2.Stop(); onered.Location = new Point(1070, 8); redpostion = 96; timer4.Start(); } break;
          
            
            
          
            
            
          //case 101: if (onered.Left <= 964) { onered.Left -= 20; } else { timer2.Stop(); onered.Location = new Point(964, 8); redpostion = 99; timer5.Start(); } break;
          //case 102: if (onered.Left <= 858) { onered.Left -= 20; } else { timer2.Stop(); onered.Location = new Point(858, 8); redpostion = 98; } break;
          //case 103: if (onered.Left <= 752) { onered.Left -= 20; } else { timer2.Stop(); onered.Location = new Point(752, 8); redpostion = 97; } break;
          //case 104: if (onered.Left <= 646) { onered.Left -= 20; } else { timer2.Stop(); onered.Location = new Point(646, 8); redpostion = 96; } break;
          

         
        }
    }

    private void bluetwo_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        timer2.Start();
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {

    }

    private void timer3_Tick(object sender, EventArgs e)
    {
        switch (redpostion)
        {
            case 12: if (onered.Left <= 222) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(222, 472); player1.controls.stop(); } break;
            case 13: if (onered.Left <= 328) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(328, 472); player1.controls.stop(); } break;
            case 14: if (onered.Left <= 434) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(434, 472); player1.controls.stop(); } break;
            case 15: if (onered.Left <= 540) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(540, 472); player1.controls.stop(); } break;
            case 16: if (onered.Left <= 646) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(646, 472); player1.controls.stop(); } break;

            case 22: if (onered.Left <= 222) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(222, 414); player1.controls.stop(); } break;
            case 23: if (onered.Left <= 328) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(328, 414); player1.controls.stop(); } break;
            case 24: if (onered.Left <= 434) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(434, 414); player1.controls.stop(); } break;
            case 25: if (onered.Left <= 540 ) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(540 , 414); redpostion = 5; timer4.Start(); } break;
            case 26: if (onered.Left <= 646) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(646, 414); player1.controls.stop(); } break;

            case 32: if (onered.Left <= 222) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(222, 356); player1.controls.stop(); } break;
            case 33: if (onered.Left <= 328) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(328, 356); player1.controls.stop(); } break;
            case 34: if (onered.Left <= 434) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(434, 356); redpostion = 1; timer4.Start(); } break;
            case 35: if (onered.Left <= 540) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(540, 356); player1.controls.stop(); } break;
            case 36: if (onered.Left <= 646) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(646, 356); redpostion = 55; timer4.Start(); } break;

            case 42: if (onered.Left <= 222) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(222, 298); player1.controls.stop(); } break;
            case 43: if (onered.Left <= 328) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(328, 298); player1.controls.stop(); } break;
            case 44: if (onered.Left <= 434) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(434, 298); player1.controls.stop(); } break;
            case 45: if (onered.Left <= 540) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(540, 298); player1.controls.stop(); } break;
            case 46: if (onered.Left <= 646) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(646, 298); player1.controls.stop(); } break;

            case 52: if (onered.Left <= 222) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(222, 240); player1.controls.stop(); } break;
            case 53: if (onered.Left <= 328) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(328, 240); player1.controls.stop(); } break;
            case 54: if (onered.Left <= 434) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(434, 240); player1.controls.stop(); } break;
            case 55: if (onered.Left <= 540) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(540, 240); player1.controls.stop(); } break;
            case 56: if (onered.Left <= 646) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(646, 240); player1.controls.stop(); } break;

            case 62: if (onered.Left <= 222) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(222, 182); player1.controls.stop(); } break;
            case 63: if (onered.Left <= 328) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(328, 182); redpostion = 95; timer4.Start(); } break;
            case 64: if (onered.Left <= 434) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(434, 182); player1.controls.stop(); } break;
            case 65: if (onered.Left <= 540) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(540, 182); redpostion = 52; timer4.Start(); } break;
            case 66: if (onered.Left <= 646) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(646, 182); player1.controls.stop(); } break;

            case 72: if (onered.Left <= 222) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(222, 124); player1.controls.stop(); } break;
            case 73: if (onered.Left <= 328) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(328, 124); player1.controls.stop(); } break;
            case 74: if (onered.Left <= 434) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(434, 124); player1.controls.stop(); } break;
            case 75: if (onered.Left <= 540) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(540, 124); player1.controls.stop(); } break;
            case 76: if (onered.Left <= 646) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(646, 124); player1.controls.stop(); } break;

            case 82: if (onered.Left <= 222) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(222, 66); player1.controls.stop(); } break;
            case 83: if (onered.Left <= 328) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(328, 66); player1.controls.stop(); } break;
            case 84: if (onered.Left <= 434) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(434, 66); player1.controls.stop(); } break;
            case 85: if (onered.Left <= 540) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(540, 66); player1.controls.stop(); } break;
            case 86: if (onered.Left <= 646) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(646, 66); player1.controls.stop(); } break;

            case 92: if (onered.Left <= 222) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(222, 8); player1.controls.stop(); } break;
            case 93: if (onered.Left <= 328) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(328, 8); player1.controls.stop(); } break;
            case 94: if (onered.Left <= 434) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(434, 8); player1.controls.stop(); } break;
            case 95: if (onered.Left <= 540) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(540, 8); player1.controls.stop(); } break;
            case 96: if (onered.Left <= 646) { onered.Left += 20; } else { timer3.Stop(); onered.Location = new Point(646, 8); player1.controls.stop(); } break;



            case 11: if (onered.Left >= 116) { onered.Left -= 20; } else if (onered.Top >= 472) { onered.Top -= 31; } else { timer3.Stop(); player1.controls.stop(); } break;
            case 21: if (onered.Left >= 116) { onered.Left -= 20; } else if (onered.Top >= 414) { onered.Top -= 31; } else { timer3.Stop(); player1.controls.stop(); } break;
            case 31: if (onered.Left >= 116) { onered.Left -= 20; } else if (onered.Top >= 356) { onered.Top -= 31; } else { timer3.Stop(); player1.controls.stop(); } break;
            case 41: if (onered.Left >= 116) { onered.Left -= 20; } else if (onered.Top >= 298) { onered.Top -= 31; } else { timer3.Stop(); player1.controls.stop(); } break;

            case 51: if (onered.Left >= 116) { onered.Left -= 20; } else if (onered.Top >= 240) { onered.Top -= 31; } else { timer3.Stop(); player1.controls.stop(); } break;

            case 61: if (onered.Left >= 116) { onered.Left -= 20; } else if (onered.Top >= 182) { onered.Top -= 31; } else { timer3.Stop(); player1.controls.stop(); } break;

            case 71: if (onered.Left >= 116) { onered.Left -= 20; } else if (onered.Top >= 356) { onered.Top -= 31; } else { timer3.Stop(); player1.controls.stop(); } break;

            case 81: if (onered.Left >= 116) { onered.Left -= 20; } else if (onered.Top >= 356) { onered.Top -= 31; } else { timer3.Stop(); player1.controls.stop(); } break;

            case 91: if (onered.Left >= 116) { onered.Left -= 20; } else if (onered.Top >= 356) { onered.Top -= 31; } else { timer3.Stop(); player1.controls.stop(); } break;

            case 98: if (onered.Left >= 858) { onered.Left -= 20; } else { timer3.Stop(); player1.controls.stop(); } break;


        }
    }

    private void timer4_Tick(object sender, EventArgs e)
    {
       
         switch (redpostion)
        {

            case 1: if (onered.Left >= 116 && onered.Top <= 530) { onered.Left -= 20; onered.Top += 12; } else { timer4.Stop(); onered.Location = new Point(116, 530); player1.controls.stop(); } break;
            case 5: if (onered.Top <= 530) { onered.Top += 5; } else { timer4.Stop(); onered.Location = new Point(540, 530); player1.controls.stop(); } break;//true
            case 27: if (onered.Top >= 414 && onered.Left <= 752) { onered.Top -= 20; onered.Left += 17; } else { timer4.Stop(); onered.Location = new Point(752, 414); player1.controls.stop(); } break;
            case 51: if (onered.Top >= 240 && onered.Left >= 116) { onered.Top -= 20; onered.Left -= 15;  } else { timer4.Stop(); onered.Location = new Point(116, 240); player1.controls.stop(); } break;

            case 55: if (onered.Left >= 540 && onered.Top >= 240) { onered.Left -= 20; onered.Top -= 22; } else { timer4.Stop(); onered.Location = new Point(540, 240); player1.controls.stop(); } break;//true


            case 19: if (onered.Left <= 964 && onered.Top <= 472) { onered.Left += 20; onered.Top += 16; } else { timer4.Stop(); onered.Location = new Point(964, 472); player1.controls.stop(); } break;


            case 95: if (onered.Left <= 540 && onered.Top >= 10) { onered.Left += 20; onered.Top -= 16; } else { timer4.Stop(); onered.Location = new Point(540, 8); player1.controls.stop(); } break;//true

            case 52: if (onered.Top <= 240 && onered.Left >= 222) { onered.Top += 4; onered.Left -= 20; } else { timer4.Stop(); onered.Location = new Point(222, 240); player1.controls.stop(); } break;
            case 57: if (onered.Top <= 240) { onered.Top += 5; } else { timer4.Stop(); onered.Location = new Point(752, 240); player1.controls.stop(); } break;//true
            case 61: if (onered.Top <= 182) { onered.Top += 5; } else { timer4.Stop(); onered.Location = new Point(116, 182); player1.controls.stop(); } break;//true
            case 69: if (onered.Top <= 182) { onered.Top += 5; } else { timer4.Stop(); onered.Location = new Point(964, 182); player1.controls.stop(); } break;//true
         
           // case 98: if (onered.Left >= 858) { onered.Left -= 20; } else { timer4.Stop(); onered.Location = new Point(858, 8); } break;
            case 98: if (onered.Top >= 8) { onered.Top -= 5; } else { timer4.Stop(); onered.Location = new Point(858, 8); player1.controls.stop(); } break;

            case 97: if (onered.Left >= 752) { onered.Left -= 20; } else { timer4.Stop(); onered.Location = new Point(752, 8); player1.controls.stop(); } break;
            case 96: if (onered.Left >= 646) { onered.Left -= 20; } else { timer4.Stop(); onered.Location = new Point(646, 8); player1.controls.stop(); } break;


        
        }
    }

    private void timer5_Tick(object sender, EventArgs e)
    {
        switch (redpostion)
        {

            case 99: if (onered.Left >= 964) { onered.Left -= 20; } else { timer5.Stop(); onered.Location = new Point(964, 8); redpostion = 69; timer4.Start(); } break;
       //i change y530 to 8
        }
    }

    private void timer6_Tick(object sender, EventArgs e)
    {
        switch (blueposition )
        {
            case 1: player2.controls.stop(); break;
            case 2: if (bluetwo.Left <= 202) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(202, 530); player2.controls.stop(); } break;
            case 3:  if (bluetwo.Left <= 308)  { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(308, 530); blueposition = 51; timer8.Start(); } break;
            case 4: if (bluetwo.Left <= 414) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(414, 530); player2.controls.stop(); } break;
            case 5: if (bluetwo.Left <= 520) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(520, 530); player2.controls.stop(); } break;
            case 6:  if (bluetwo.Left <= 626)  { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(626, 530); blueposition = 27; timer8.Start(); } break;
            case 7: if (bluetwo.Left <= 732) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(732, 530); player2.controls.stop(); } break;
            case 8: if (bluetwo.Left <= 838) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(838, 530); player2.controls.stop(); } break;
            case 9: if (bluetwo.Left <= 944) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(944, 530); player2.controls.stop(); } break;
            case 10: if (bluetwo.Left <= 1050) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(1050, 530); player2.controls.stop(); } break;
            case 11: if (bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(96, 472); player2.controls.stop(); } break;


            case 12: if (bluetwo.Top == 530 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 530) { bluetwo.Location = new Point(96, 472); } timer7.Start(); } break;
            case 13: if (bluetwo.Top == 530 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 530) { bluetwo.Location = new Point(96, 472); } timer7.Start(); } break;
            case 14: if (bluetwo.Top == 530 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 530) { bluetwo.Location = new Point(96, 472); } timer7.Start(); } break;
            case 15: if (bluetwo.Top == 530 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 530) { bluetwo.Location = new Point(96, 472); } timer7.Start(); } break;
            case 16: if (bluetwo.Top == 530 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 530) { bluetwo.Location = new Point(96, 472); } timer7.Start(); } break;


            case 17: if (bluetwo.Left <= 732) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(732, 472); player2.controls.stop(); } break;
            case 18: if (bluetwo.Left <= 838) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(838, 472); player2.controls.stop(); } break;
            case 19: if (bluetwo.Left <= 944) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(944, 472); player2.controls.stop(); } break;
            case 20: if (bluetwo.Left <= 1050) { bluetwo.Left += 20; } else if (bluetwo.Top >= 182) { bluetwo.Top -= 10; } else { timer6.Stop(); bluetwo.Location = new Point(1050, 182); blueposition = 70; player2.controls.stop(); } break;
            case 21: if (bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(96, 414); player2.controls.stop(); } break;

            case 22: if (bluetwo.Top == 472 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 472) { bluetwo.Location = new Point(96, 414); } timer7.Start(); } break;
            case 23: if (bluetwo.Top == 472 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 472) { bluetwo.Location = new Point(96, 414); } timer7.Start(); } break;
            case 24: if (bluetwo.Top == 472 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 472) { bluetwo.Location = new Point(96, 414); } timer7.Start(); } break;
            case 25: if (bluetwo.Top == 472 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 472) { bluetwo.Location = new Point(96, 414); } timer7.Start(); } break;
            case 26: if (bluetwo.Top == 472 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 472) { bluetwo.Location = new Point(96, 414); } timer7.Start(); } break;

            case 27: if (bluetwo.Left <= 732) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(732, 414); player2.controls.stop(); } break;
            case 28: if (bluetwo.Left <= 838) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(838, 414); player2.controls.stop(); } break;
            case 29: if (bluetwo.Left <= 944) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(944, 414); player2.controls.stop(); } break;
            case 30: if (bluetwo.Left <= 1050) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(1050, 414); player2.controls.stop(); } break;

            case 31: if (bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(96, 356); player2.controls.stop(); } break;
           
            case 32: if (bluetwo.Top == 414 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 414) { bluetwo.Location = new Point(96, 356); } timer7.Start(); } break;
            case 33: if (bluetwo.Top == 414 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 414) { bluetwo.Location = new Point(96, 356); } timer7.Start(); } break;
            case 34: if (bluetwo.Top == 414 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 414) { bluetwo.Location = new Point(96, 356); } timer7.Start(); } break;
            case 35: if (bluetwo.Top == 414 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 414) { bluetwo.Location = new Point(96, 356); } timer7.Start(); } break;
            case 36: if (bluetwo.Top == 414 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 414) { bluetwo.Location = new Point(96, 356); } timer7.Start(); } break;

            case 37: if (bluetwo.Left <= 732) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(732, 356); player2.controls.stop(); } break;
            case 38: if (bluetwo.Left <= 838) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(838, 356); player2.controls.stop(); } break;
            case 39: if (bluetwo.Left <= 944) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(944, 356); player2.controls.stop(); } break;
            case 40: if (bluetwo.Left <= 1050) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(1050, 356); player2.controls.stop(); } break;
            case 41: if (bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(96, 298); player2.controls.stop(); } break;

            case 42: if (bluetwo.Top == 356 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 356) { bluetwo.Location = new Point(96, 298); } timer7.Start(); } break;
            case 43: if (bluetwo.Top == 356 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 356) { bluetwo.Location = new Point(96, 298); } timer7.Start(); } break;
            case 44: if (bluetwo.Top == 356 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 356) { bluetwo.Location = new Point(96, 298); } timer7.Start(); } break;
            case 45: if (bluetwo.Top == 356 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 356) { bluetwo.Location = new Point(96, 298); } timer7.Start(); } break;
            case 46: if (bluetwo.Top == 356 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 356) { bluetwo.Location = new Point(96, 298); } timer7.Start(); } break;

            case 47: if (bluetwo.Left <= 732) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(732, 298); blueposition = 19; timer8.Start(); } break;


            case 48: if (bluetwo.Left <= 838) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(838, 298); player2.controls.stop(); } break;
            case 49: if (bluetwo.Left <= 944) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(944, 298); player2.controls.stop(); } break;
            case 50: if (bluetwo.Left <= 1050) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(1050, 298); player2.controls.stop(); } break;
            case 51: if (bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(96, 240); player2.controls.stop(); } break;

            case 52: if (bluetwo.Top == 298 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 298) { bluetwo.Location = new Point(96, 240); } timer7.Start(); } break;
            case 53: if (bluetwo.Top == 298 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 298) { bluetwo.Location = new Point(96, 240); } timer7.Start(); } break;
            case 54: if (bluetwo.Top == 298 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 298) { bluetwo.Location = new Point(96, 240); } timer7.Start(); } break;
            case 55: if (bluetwo.Top == 298 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 298) { bluetwo.Location = new Point(96, 240); } timer7.Start(); } break;
            case 56: if (bluetwo.Top == 298 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 298) { bluetwo.Location = new Point(96, 240); } timer7.Start(); } break;

            case 57: if (bluetwo.Left <= 732) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(732, 240); player2.controls.stop(); } break;
            case 58: if (bluetwo.Left <= 838) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(838, 240); player2.controls.stop(); } break;
            case 59: if (bluetwo.Left <= 944) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(944, 240); player2.controls.stop(); } break;
            case 60: if (bluetwo.Left <= 1050) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(1050, 240); player2.controls.stop(); } break;
            case 61: if (bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(96, 182); player2.controls.stop(); } break;

            case 62: if (bluetwo.Top == 240 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 240) { bluetwo.Location = new Point(96, 182); } timer7.Start(); } break;
            case 63: if (bluetwo.Top == 240 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 240) { bluetwo.Location = new Point(96, 182); } timer7.Start(); } break;
            case 64: if (bluetwo.Top == 240 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 240) { bluetwo.Location = new Point(96, 182); } timer7.Start(); } break;
            case 65: if (bluetwo.Top == 240 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 240) { bluetwo.Location = new Point(96, 182); } timer7.Start(); } break;
            case 66: if (bluetwo.Top == 240 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 240) { bluetwo.Location = new Point(96, 182); } timer7.Start(); } break;

            case 67: if (bluetwo.Left <= 732) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(732, 182); player2.controls.stop(); } break;
            case 68: if (bluetwo.Left <= 838 ) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(838, 182); blueposition = 98; timer8.Start(); } break;
            case 69: if (bluetwo.Left <= 944) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(944, 182); player2.controls.stop(); } break;
            case 70: if (bluetwo.Left <= 1050) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(1050, 182); player2.controls.stop(); } break;
            case 71: if (bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(96, 124); player2.controls.stop(); } break;

            case 72: if (bluetwo.Top == 182 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 182) { bluetwo.Location = new Point(96, 124); } timer7.Start(); } break;
            case 73: if (bluetwo.Top == 182 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 182) { bluetwo.Location = new Point(96, 124); } timer7.Start(); } break;
            case 74: if (bluetwo.Top == 182 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 182) { bluetwo.Location = new Point(96, 124); } timer7.Start(); } break;
            case 75: if (bluetwo.Top == 182 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 182) { bluetwo.Location = new Point(96, 124); } timer7.Start(); } break;
            case 76: if (bluetwo.Top == 182 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 182) { bluetwo.Location = new Point(96, 124); } timer7.Start(); } break;

            case 77: if (bluetwo.Left <= 732) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(732, 124); player2.controls.stop(); } break;
            case 78: if (bluetwo.Left <= 838) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(838, 124); player2.controls.stop(); } break;
            case 79: if (bluetwo.Left <= 944) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(944, 124); player2.controls.stop(); } break;
            case 80: if (bluetwo.Left <= 1050) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(1050, 124); player2.controls.stop(); } break;
            case 81: if (bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(96, 66); player2.controls.stop(); } break;

            case 82: if (bluetwo.Top == 124 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 124) { bluetwo.Location = new Point(96, 66); } timer7.Start(); } break;
            case 83: if (bluetwo.Top == 124 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 124) { bluetwo.Location = new Point(96, 66); } timer7.Start(); } break;
            case 84: if (bluetwo.Top == 124 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 124) { bluetwo.Location = new Point(96, 66); } timer7.Start(); } break;
            case 85: if (bluetwo.Top == 124 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 124) { bluetwo.Location = new Point(96, 66); } timer7.Start(); } break;
            case 86: if (bluetwo.Top == 124 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 124) { bluetwo.Location = new Point(96, 66); } timer7.Start(); } break;

            case 87: if (bluetwo.Left <= 732 ) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(732, 66); blueposition = 57; timer8.Start(); } break;
            case 88: if (bluetwo.Left <= 838) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(838, 66); player2.controls.stop(); } break;
            case 89: if (bluetwo.Left <= 944) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(944, 66); player2.controls.stop(); } break;
            case 90: if (bluetwo.Left <= 1050) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(1050, 66); player2.controls.stop(); } break;
            case 91: if (bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(96   , 8); blueposition = 61; timer8.Start(); } break;

            case 92: if (bluetwo.Top == 66 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 66) { bluetwo.Location = new Point(96, 8); } timer7.Start(); } break;
            case 93: if (bluetwo.Top == 66 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 66) { bluetwo.Location = new Point(96, 8); } timer7.Start(); } break;
            case 94: if (bluetwo.Top == 66 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 66) { bluetwo.Location = new Point(96, 8); } timer7.Start(); } break;
            case 95: if (bluetwo.Top == 66 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 66) { bluetwo.Location = new Point(96, 8); } timer7.Start(); } break;
            case 96: if (bluetwo.Top == 66 && bluetwo.Left <= 1070) { bluetwo.Left += 20; } else { timer6.Stop(); if (bluetwo.Top == 66) { bluetwo.Location = new Point(96, 8); } timer7.Start(); } break;

            case 97: if (bluetwo.Left <= 732) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(732, 8); player2.controls.stop(); } break;
            case 98: if (bluetwo.Left <= 838) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(838, 8); player2.controls.stop(); } break;
            case 99: if (bluetwo.Left <= 944) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(944, 8); blueposition = 69; timer8.Start(); } break;
            case 100: if (bluetwo.Left <= 1050) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(1050, 8); Form4 f4 = new Form4(); f4.Show(); ; roll1.Enabled = false; roll2.Enabled = false; r3.Enabled = false; r4.Enabled = false; player2.controls.stop(); } break;
            case 101: if (bluetwo.Left <= 1050) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(1050, 8); blueposition = 99; timer9.Start(); } break;//point
            
            case 102: if (bluetwo.Left <= 1050) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(1050, 8); blueposition = 98; timer7.Start(); } break;
            case 103: if (bluetwo.Left <= 1050) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(1050, 8); blueposition = 97; timer8.Start(); } break;
            case 104: if (bluetwo.Left <= 1050) { bluetwo.Left += 20; } else { timer6.Stop(); bluetwo.Location = new Point(1050, 8); blueposition = 96; timer8.Start(); } break;
          

            

          
        }
    }

    private void timer7_Tick(object sender, EventArgs e)
    {
        switch (blueposition )
        {
            case 12: if (bluetwo.Left <= 202) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(202, 472); player2.controls.stop(); } break;
            case 13: if (bluetwo.Left <= 308) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(308, 472); player2.controls.stop(); } break;
            case 14: if (bluetwo.Left <= 414) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(414, 472); player2.controls.stop(); } break;
            case 15: if (bluetwo.Left <= 520) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(520, 472); player2.controls.stop(); } break;
            case 16: if (bluetwo.Left <= 626) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(626, 472); player2.controls.stop(); } break;

            case 22: if (bluetwo.Left <= 202) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(202, 414); player2.controls.stop(); } break;
            case 23: if (bluetwo.Left <= 308) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(308, 414); player2.controls.stop(); } break;
            case 24: if (bluetwo.Left <= 414) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(414, 414); player2.controls.stop(); } break;
            case 25: if (bluetwo.Left <= 520) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(520, 414); blueposition = 5; timer8.Start(); } break;
            case 26: if (bluetwo.Left <= 626) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(626, 414); player2.controls.stop(); } break;

            case 32: if (bluetwo.Left <= 202) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(202, 356); player2.controls.stop(); } break;
            case 33: if (bluetwo.Left <= 308) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(308, 356); player2.controls.stop(); } break;
            case 34: if (bluetwo.Left <= 414) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(414, 356); blueposition = 1; timer8.Start(); } break;
            case 35: if (bluetwo.Left <= 520) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(520, 356); player2.controls.stop(); } break;
            case 36: if (bluetwo.Left <= 626) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(626, 356); blueposition = 55; timer8.Start(); } break;

            case 42: if (bluetwo.Left <= 202) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(202, 298); player2.controls.stop(); } break;
            case 43: if (bluetwo.Left <= 308) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(308, 298); player2.controls.stop(); } break;
            case 44: if (bluetwo.Left <= 414) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(414, 298); player2.controls.stop(); } break;
            case 45: if (bluetwo.Left <= 520) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(520, 298); player2.controls.stop(); } break;
            case 46: if (bluetwo.Left <= 626) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(626, 298); player2.controls.stop(); } break;

            case 52: if (bluetwo.Left <= 202) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(202, 240); player2.controls.stop(); } break;
            case 53: if (bluetwo.Left <= 308) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(308, 240); player2.controls.stop(); } break;
            case 54: if (bluetwo.Left <= 414) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(414, 240); player2.controls.stop(); } break;
            case 55: if (bluetwo.Left <= 520) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(520, 240); player2.controls.stop(); } break;
            case 56: if (bluetwo.Left <= 626) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(626, 240); player2.controls.stop(); } break;

            case 62: if (bluetwo.Left <= 202) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(202, 182); player2.controls.stop(); } break;
            case 63: if (bluetwo.Left <= 308) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(308, 182); blueposition = 95; timer8.Start(); } break;
            case 64: if (bluetwo.Left <= 414) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(414, 182); player2.controls.stop(); } break;
            case 65: if (bluetwo.Left <= 520) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(520, 182); blueposition = 52; timer8.Start(); } break;
            case 66: if (bluetwo.Left <= 626) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(626, 182); player2.controls.stop(); } break;

            case 72: if (bluetwo.Left <= 202) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(202, 124); player2.controls.stop(); } break;
            case 73: if (bluetwo.Left <= 308) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(308, 124); player2.controls.stop(); } break;
            case 74: if (bluetwo.Left <= 414) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(414, 124); player2.controls.stop(); } break;
            case 75: if (bluetwo.Left <= 520) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(520, 124); player2.controls.stop(); } break;
            case 76: if (bluetwo.Left <= 626) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(626, 124); player2.controls.stop(); } break;

            case 82: if (bluetwo.Left <= 202) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(202, 66); player2.controls.stop(); } break;
            case 83: if (bluetwo.Left <= 308) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(308, 66); player2.controls.stop(); } break;
            case 84: if (bluetwo.Left <= 414) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(414, 66); player2.controls.stop(); } break;
            case 85: if (bluetwo.Left <= 520) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(520, 66); player2.controls.stop(); } break;
            case 86: if (bluetwo.Left <= 626) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(626, 66); player2.controls.stop(); } break;

            case 92: if (bluetwo.Left <= 202) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(202, 8); player2.controls.stop(); } break;
            case 93: if (bluetwo.Left <= 308) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(308, 8); player2.controls.stop(); } break;
            case 94: if (bluetwo.Left <= 414) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(414, 8); player2.controls.stop(); } break;
            case 95: if (bluetwo.Left <= 520) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(520, 8); player2.controls.stop(); } break;
            case 96: if (bluetwo.Left <= 626) { bluetwo.Left += 20; } else { timer7.Stop(); bluetwo.Location = new Point(626, 8); player2.controls.stop(); } break;



         /*   case 11: if (bluetwo.Left >= 116) { bluetwo.Left -= 20; } else if (bluetwo.Top >= 472) { bluetwo.Top -= 31; } else { timer7.Stop(); } break;
            case 21: if (bluetwo.Left >= 116) { bluetwo.Left -= 20; } else if (bluetwo.Top >= 414) { bluetwo.Top -= 31; } else { timer7.Stop(); } break;
            case 31: if (bluetwo.Left >= 116) { bluetwo.Left -= 20; } else if (bluetwo.Top >= 356) { bluetwo.Top -= 31; } else { timer7.Stop(); } break;
            case 41: if (bluetwo.Left >= 116) { bluetwo.Left -= 20; } else if (bluetwo.Top >= 298) { bluetwo.Top -= 31; } else { timer7.Stop(); } break;

            case 51: if (bluetwo.Left >= 116) { bluetwo.Left -= 20; } else if (bluetwo.Top >= 240) { bluetwo.Top -= 31; } else { timer7.Stop(); } break;

            case 61: if (bluetwo.Left >= 116) { bluetwo.Left -= 20; } else if (bluetwo.Top >= 182) { bluetwo.Top -= 31; } else { timer7.Stop(); } break;

            case 71: if (bluetwo.Left >= 116) { bluetwo.Left -= 20; } else if (bluetwo.Top >= 356) { bluetwo.Top -= 31; } else { timer7.Stop(); } break;

            case 81: if (bluetwo.Left >= 116) { bluetwo.Left -= 20; } else if (bluetwo.Top >= 356) { bluetwo.Top -= 31; } else { timer7.Stop(); } break;

            case 91: if (bluetwo.Left >= 116) { bluetwo.Left -= 20; } else if (bluetwo.Top >= 356) { bluetwo.Top -= 31; } else { timer7.Stop(); } break;

            case 98: if (bluetwo.Left >= 838) { bluetwo.Left -= 20; } else { timer7.Stop(); } break;*/


        }
    }

    private void timer8_Tick(object sender, EventArgs e)
    {

        switch (blueposition )
        {

            case 1: if (bluetwo.Left >= 96 && bluetwo.Top <= 530) { bluetwo.Left -= 20; bluetwo.Top += 11; } else { timer8.Stop(); bluetwo.Location = new Point(96, 530); player2.controls.stop(); } break;
            case 5: if (bluetwo.Top <= 530) { bluetwo.Top += 10; } else { timer8.Stop(); bluetwo.Location = new Point(520, 530); player2.controls.stop(); } break;//true-20
            case 27: if (bluetwo.Top >= 414 && bluetwo.Left <= 732) { bluetwo.Top -= 20; bluetwo.Left += 22; } else { timer8.Stop(); bluetwo.Location = new Point(732, 414); player2.controls.stop(); } break;

            case 51: if (bluetwo.Top >= 240 && bluetwo.Left >= 96) { bluetwo.Top -= 20; bluetwo.Left -= 13; } else { timer8.Stop(); bluetwo.Location = new Point(96, 240); player2.controls.stop(); } break;

            case 55: if (bluetwo.Left >= 520 && bluetwo.Top >= 240) { bluetwo.Left -= 20; bluetwo.Top -= 22; } else { timer8.Stop(); bluetwo.Location = new Point(520, 240); player2.controls.stop(); } break;//true

            case 19: if (bluetwo.Left <= 944 && bluetwo.Top <= 472) { bluetwo.Left += 20; bluetwo.Top += 16; } else { timer8.Stop(); bluetwo.Location = new Point(944, 472); player2.controls.stop(); } break;

            case 95: if (bluetwo.Left <= 520 && bluetwo.Top >= 10) { bluetwo.Left += 20; bluetwo.Top -= 16; } else { timer8.Stop(); bluetwo.Location = new Point(520, 8); player2.controls.stop(); } break;//true
            case 52: if (bluetwo.Top <= 240 && bluetwo.Left >= 202) { bluetwo.Top += 4; bluetwo.Left -= 20; } else { timer8.Stop(); bluetwo.Location = new Point(202, 240); player2.controls.stop(); } break;
            case 57: if (bluetwo.Top <= 240) { bluetwo.Top += 10; } else { timer8.Stop(); bluetwo.Location = new Point(732, 240); player2.controls.stop(); } break;//true
            case 61: if (bluetwo.Top <= 182) { bluetwo.Top += 10; } else { timer8.Stop(); bluetwo.Location = new Point(96, 182); player2.controls.stop(); } break;//true
            case 69: if (bluetwo.Top <= 182) { bluetwo.Top += 10; } else { timer8.Stop(); bluetwo.Location = new Point(944, 182); player2.controls.stop(); } break;//true
            case 98: if (bluetwo.Top >= 8) { bluetwo.Top -= 10; } else { timer8.Stop(); bluetwo.Location = new Point(838, 8); player2.controls.stop(); } break;
            case 97: if (bluetwo.Left >= 732) { bluetwo.Left -= 20; } else { timer8.Stop(); bluetwo.Location = new Point(732, 8); player2.controls.stop(); } break;
            case 96: if (bluetwo.Left >= 626) { bluetwo.Left -= 20; } else { timer8.Stop(); bluetwo.Location = new Point(626, 8); player2.controls.stop(); } break;


        }
    }

    private void timer9_Tick(object sender, EventArgs e)
    {
        switch (blueposition )
        {

            case 99: if (bluetwo.Left >= 944) { bluetwo.Left -= 20; } else { timer9.Stop(); bluetwo.Location = new Point(944, 8); blueposition  = 69; timer8.Start(); } break;
        }
    }

    private void timer10_Tick(object sender, EventArgs e)
    {
        switch (blackposition )
        {
            case 1:player3.controls.stop();  break;
            case 2: if (three2.Left <= 182) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(182, 530); player3.controls.stop(); } break;
            case 3: if (three2.Left <= 288) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(288, 530); blackposition = 51; timer12.Start(); } break;
            case 4: if (three2.Left <= 394) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(394, 530); player3.controls.stop(); } break;
            case 5: if (three2.Left <= 500) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(500, 530); player3.controls.stop(); } break;
            case 6: if (three2.Left <= 606) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(606, 530); blackposition = 27; timer12.Start(); } break;
            case 7: if (three2.Left <= 712) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(712, 530); player3.controls.stop(); } break;
            case 8: if (three2.Left <= 818) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(818, 530); player3.controls.stop(); } break;
            case 9: if (three2.Left <= 924) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(924, 530); player3.controls.stop(); } break;
            case 10: if (three2.Left <= 1030) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(1030, 530); player3.controls.stop(); } break;
            case 11: if (three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(76, 472); player3.controls.stop(); } break;


            case 12: if (three2.Top == 530 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 530) { three2.Location = new Point(76, 472); } timer11.Start(); } break;
            case 13: if (three2.Top == 530 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 530) { three2.Location = new Point(76, 472); } timer11.Start(); } break;
            case 14: if (three2.Top == 530 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 530) { three2.Location = new Point(76, 472); } timer11.Start(); } break;
            case 15: if (three2.Top == 530 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 530) { three2.Location = new Point(76, 472); } timer11.Start(); } break;
            case 16: if (three2.Top == 530 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 530) { three2.Location = new Point(76, 472); } timer11.Start(); } break;


            case 17: if (three2.Left <= 712) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(712, 472); player3.controls.stop(); } break;
            case 18: if (three2.Left <= 818) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(818, 472); player3.controls.stop(); } break;
            case 19: if (three2.Left <= 924) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(924, 472); player3.controls.stop(); } break;
            case 20: if (three2.Left <= 1030) { three2.Left += 20; } else if (three2.Top >= 182) { three2.Top -= 10; } else { timer10.Stop(); three2.Location = new Point(1030, 182); blackposition = 70; player3.controls.stop(); } break;
            case 21: if (three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(76, 414); player3.controls.stop(); } break;

            case 22: if (three2.Top == 472 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 472) { three2.Location = new Point(76, 414); } timer11.Start(); } break;
            case 23: if (three2.Top == 472 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 472) { three2.Location = new Point(76, 414); } timer11.Start(); } break;
            case 24: if (three2.Top == 472 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 472) { three2.Location = new Point(76, 414); } timer11.Start(); } break;
            case 25: if (three2.Top == 472 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 472) { three2.Location = new Point(76, 414); } timer11.Start(); } break;
            case 26: if (three2.Top == 472 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 472) { three2.Location = new Point(76, 414); } timer11.Start(); } break;

            case 27: if (three2.Left <= 712) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(712, 414); player3.controls.stop(); } break;
            case 28: if (three2.Left <= 818) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(818, 414); player3.controls.stop(); } break;
            case 29: if (three2.Left <= 924) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(924, 414); player3.controls.stop(); } break;
            case 30: if (three2.Left <= 1030) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(1030, 414); player3.controls.stop(); } break;

            case 31: if (three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(76, 356); player3.controls.stop(); } break;

            case 32: if (three2.Top == 414 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 414) { three2.Location = new Point(76, 356); } timer11.Start(); } break;
            case 33: if (three2.Top == 414 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 414) { three2.Location = new Point(76, 356); } timer11.Start(); } break;
            case 34: if (three2.Top == 414 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 414) { three2.Location = new Point(76, 356); } timer11.Start(); } break;
            case 35: if (three2.Top == 414 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 414) { three2.Location = new Point(76, 356); } timer11.Start(); } break;
            case 36: if (three2.Top == 414 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 414) { three2.Location = new Point(76, 356); } timer11.Start(); } break;

            case 37: if (three2.Left <= 712) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(712, 356); player3.controls.stop(); } break;
            case 38: if (three2.Left <= 818) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(818, 356); player3.controls.stop(); } break;
            case 39: if (three2.Left <= 924) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(924, 356); player3.controls.stop(); } break;
            case 40: if (three2.Left <= 1030) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(1030, 356); player3.controls.stop(); } break;
            case 41: if (three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(76, 298); player3.controls.stop(); } break;

            case 42: if (three2.Top == 356 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 356) { three2.Location = new Point(76, 298); } timer11.Start(); } break;
            case 43: if (three2.Top == 356 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 356) { three2.Location = new Point(76, 298); } timer11.Start(); } break;
            case 44: if (three2.Top == 356 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 356) { three2.Location = new Point(76, 298); } timer11.Start(); } break;
            case 45: if (three2.Top == 356 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 356) { three2.Location = new Point(76, 298); } timer11.Start(); } break;
            case 46: if (three2.Top == 356 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 356) { three2.Location = new Point(76, 298); } timer11.Start(); } break;

            case 47: if (three2.Left <= 712) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(712, 298); blackposition = 19; timer12.Start(); } break;


            case 48: if (three2.Left <= 818) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(818, 298); player3.controls.stop(); } break;
            case 49: if (three2.Left <= 924) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(924, 298); player3.controls.stop(); } break;
            case 50: if (three2.Left <= 1030) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(1030, 298); player3.controls.stop(); } break;
            case 51: if (three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(76, 240); player3.controls.stop(); } break;

            case 52: if (three2.Top == 298 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 298) { three2.Location = new Point(76, 240); } timer11.Start(); } break;
            case 53: if (three2.Top == 298 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 298) { three2.Location = new Point(76, 240); } timer11.Start(); } break;
            case 54: if (three2.Top == 298 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 298) { three2.Location = new Point(76, 240); } timer11.Start(); } break;
            case 55: if (three2.Top == 298 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 298) { three2.Location = new Point(76, 240); } timer11.Start(); } break;
            case 56: if (three2.Top == 298 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 298) { three2.Location = new Point(76, 240); } timer11.Start(); } break;

            case 57: if (three2.Left <= 712) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(712, 240); player3.controls.stop(); } break;
            case 58: if (three2.Left <= 818) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(818, 240); player3.controls.stop(); } break;
            case 59: if (three2.Left <= 924) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(924, 240); player3.controls.stop(); } break;
            case 60: if (three2.Left <= 1030) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(1030, 240); player3.controls.stop(); } break;
            case 61: if (three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(76, 182); player3.controls.stop(); } break;

            case 62: if (three2.Top == 240 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 240) { three2.Location = new Point(76, 182); } timer11.Start(); } break;
            case 63: if (three2.Top == 240 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 240) { three2.Location = new Point(76, 182); } timer11.Start(); } break;
            case 64: if (three2.Top == 240 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 240) { three2.Location = new Point(76, 182); } timer11.Start(); } break;
            case 65: if (three2.Top == 240 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 240) { three2.Location = new Point(76, 182); } timer11.Start(); } break;
            case 66: if (three2.Top == 240 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 240) { three2.Location = new Point(76, 182); } timer11.Start(); } break;

            case 67: if (three2.Left <= 712) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(712, 182); player3.controls.stop(); } break;
            case 68: if (three2.Left <= 818) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(818, 182); blackposition = 98; timer12.Start(); } break;
            case 69: if (three2.Left <= 924) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(924, 182); player3.controls.stop(); } break;
            case 70: if (three2.Left <= 1030) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(1030, 182); player3.controls.stop(); } break;
            case 71: if (three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(76, 124); player3.controls.stop(); } break;

            case 72: if (three2.Top == 182 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 182) { three2.Location = new Point(76, 124); } timer11.Start(); } break;
            case 73: if (three2.Top == 182 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 182) { three2.Location = new Point(76, 124); } timer11.Start(); } break;
            case 74: if (three2.Top == 182 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 182) { three2.Location = new Point(76, 124); } timer11.Start(); } break;
            case 75: if (three2.Top == 182 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 182) { three2.Location = new Point(76, 124); } timer11.Start(); } break;
            case 76: if (three2.Top == 182 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 182) { three2.Location = new Point(76, 124); } timer11.Start(); } break;

            case 77: if (three2.Left <= 712) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(712, 124); player3.controls.stop(); } break;
            case 78: if (three2.Left <= 818) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(818, 124); player3.controls.stop(); } break;
            case 79: if (three2.Left <= 924) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(924, 124); player3.controls.stop(); } break;
            case 80: if (three2.Left <= 1030) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(1030, 124); player3.controls.stop(); } break;
            case 81: if (three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(76, 66); player3.controls.stop(); } break;

            case 82: if (three2.Top == 124 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 124) { three2.Location = new Point(76, 66); } timer11.Start(); } break;
            case 83: if (three2.Top == 124 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 124) { three2.Location = new Point(76, 66); } timer11.Start(); } break;
            case 84: if (three2.Top == 124 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 124) { three2.Location = new Point(76, 66); } timer11.Start(); } break;
            case 85: if (three2.Top == 124 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 124) { three2.Location = new Point(76, 66); } timer11.Start(); } break;
            case 86: if (three2.Top == 124 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 124) { three2.Location = new Point(76, 66); } timer11.Start(); } break;

            case 87: if (three2.Left <= 712) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(712, 66); blackposition = 57; timer12.Start(); } break;
            case 88: if (three2.Left <= 818) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(818, 66); player3.controls.stop(); } break;
            case 89: if (three2.Left <= 924) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(924, 66); player3.controls.stop(); } break;
            case 90: if (three2.Left <= 1030) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(1030, 66); player3.controls.stop(); } break;
            case 91: if (three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(76, 8); blackposition = 61; timer12.Start(); } break;

            case 92: if (three2.Top == 66 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 66) { three2.Location = new Point(76, 8); } timer11.Start(); } break;
            case 93: if (three2.Top == 66 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 66) { three2.Location = new Point(76, 8); } timer11.Start(); } break;
            case 94: if (three2.Top == 66 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 66) { three2.Location = new Point(76, 8); } timer11.Start(); } break;
            case 95: if (three2.Top == 66 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 66) { three2.Location = new Point(76, 8); } timer11.Start(); } break;
            case 96: if (three2.Top == 66 && three2.Left <= 1070) { three2.Left += 20; } else { timer10.Stop(); if (three2.Top == 66) { three2.Location = new Point(76, 8); } timer11.Start(); } break;

            case 97: if (three2.Left <= 712) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(712, 8); player3.controls.stop(); } break;
            case 98: if (three2.Left <= 818) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(818, 8); player3.controls.stop(); } break;
            case 99: if (three2.Left <= 924) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(924, 8); blackposition = 69; timer12.Start(); } break;
            case 100: if (three2.Left <= 1030) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(1030, 8); player3.controls.stop(); Form4 f4 = new Form4(); f4.Show(); roll1.Enabled = false; roll2.Enabled = false; r3.Enabled = false; r4.Enabled = false; } break;
            case 101: if (three2.Left <= 1030) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(1030, 8); blackposition = 99; timer13.Start(); } break;//point

            case 102: if (three2.Left <= 1050) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(1030, 8); blackposition = 98; timer11.Start(); } break;
            case 103: if (three2.Left <= 1050) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(1030, 8); blackposition = 97; timer12.Start(); } break;
            case 104: if (three2.Left <= 1050) { three2.Left += 20; } else { timer10.Stop(); three2.Location = new Point(1030, 8); blackposition = 96; timer12.Start(); } break;





        }
    }

    private void timer11_Tick(object sender, EventArgs e)
    {
        switch (blackposition )
        {
            case 12: if (three2.Left <= 182) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(182, 472); player3.controls.stop(); } break;
            case 13: if (three2.Left <= 288) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(288, 472); player3.controls.stop(); } break;
            case 14: if (three2.Left <= 394) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(394, 472); player3.controls.stop(); } break;
            case 15: if (three2.Left <= 500) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(500, 472); player3.controls.stop(); } break;
            case 16: if (three2.Left <= 606) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(606, 472); player3.controls.stop(); } break;

            case 22: if (three2.Left <= 182) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(182, 414); player3.controls.stop(); } break;
            case 23: if (three2.Left <= 288) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(288, 414); player3.controls.stop(); } break;
            case 24: if (three2.Left <= 394) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(394, 414); player3.controls.stop(); } break;
            case 25: if (three2.Left <= 500) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(500, 414); blackposition = 5; timer12.Start(); } break;
            case 26: if (three2.Left <= 606) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(606, 414); player3.controls.stop(); } break;

            case 32: if (three2.Left <= 182) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(182, 356); player3.controls.stop(); } break;
            case 33: if (three2.Left <= 288) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(288, 356); player3.controls.stop(); } break;
            case 34: if (three2.Left <= 394) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(394, 356); blackposition = 1; timer12.Start(); } break;
            case 35: if (three2.Left <= 500) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(500, 356); player3.controls.stop(); } break;
            case 36: if (three2.Left <= 606) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(606, 356); blackposition = 55; timer12.Start(); } break;

            case 42: if (three2.Left <= 182) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(182, 298); player3.controls.stop(); } break;
            case 43: if (three2.Left <= 288) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(288, 298); player3.controls.stop(); } break;
            case 44: if (three2.Left <= 394) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(394, 298); player3.controls.stop(); } break;
            case 45: if (three2.Left <= 500) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(500, 298); player3.controls.stop(); } break;
            case 46: if (three2.Left <= 606) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(606, 298); player3.controls.stop(); } break;

            case 52: if (three2.Left <= 182) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(182, 240); player3.controls.stop(); } break;
            case 53: if (three2.Left <= 288) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(288, 240); player3.controls.stop(); } break;
            case 54: if (three2.Left <= 394) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(394, 240); player3.controls.stop(); } break;
            case 55: if (three2.Left <= 500) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(500, 240); player3.controls.stop(); } break;
            case 56: if (three2.Left <= 606) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(606, 240); player3.controls.stop(); } break;

            case 62: if (three2.Left <= 182) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(182, 182); player3.controls.stop(); } break;
            case 63: if (three2.Left <= 288) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(288, 182); blackposition = 95; timer12.Start(); } break;
            case 64: if (three2.Left <= 394) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(394, 182); player3.controls.stop(); } break;
            case 65: if (three2.Left <= 500) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(500, 182); blackposition = 52; timer12.Start(); } break;
            case 66: if (three2.Left <= 606) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(606, 182); player3.controls.stop(); } break;

            case 72: if (three2.Left <= 182) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(182, 124); player3.controls.stop(); } break;
            case 73: if (three2.Left <= 288) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(288, 124); player3.controls.stop(); } break;
            case 74: if (three2.Left <= 394) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(394, 124); player3.controls.stop(); } break;
            case 75: if (three2.Left <= 500) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(500, 124); player3.controls.stop(); } break;
            case 76: if (three2.Left <= 606) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(606, 124); player3.controls.stop(); } break;

            case 82: if (three2.Left <= 182) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(182, 66); player3.controls.stop(); } break;
            case 83: if (three2.Left <= 288) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(288, 66); player3.controls.stop(); } break;
            case 84: if (three2.Left <= 394) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(394, 66); player3.controls.stop(); } break;
            case 85: if (three2.Left <= 500) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(500, 66); player3.controls.stop(); } break;
            case 86: if (three2.Left <= 606) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(606, 66); player3.controls.stop(); } break;

            case 92: if (three2.Left <= 182) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(182, 8); player3.controls.stop(); } break;
            case 93: if (three2.Left <= 288) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(288, 8); player3.controls.stop(); } break;
            case 94: if (three2.Left <= 394) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(394, 8); player3.controls.stop(); } break;
            case 95: if (three2.Left <= 500) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(500, 8); player3.controls.stop(); } break;
            case 96: if (three2.Left <= 606) { three2.Left += 20; } else { timer11.Stop(); three2.Location = new Point(606, 8); player3.controls.stop(); } break;



         /*   case 11: if (three2.Left >= 116) { bluetwo.Left -= 20; } else if (bluetwo.Top >= 472) { bluetwo.Top -= 31; } else { timer7.Stop(); } break;
            case 21: if (three2.Left >= 116) { bluetwo.Left -= 20; } else if (bluetwo.Top >= 414) { bluetwo.Top -= 31; } else { timer7.Stop(); } break;
            case 31: if (three2.Left >= 116) { bluetwo.Left -= 20; } else if (bluetwo.Top >= 356) { bluetwo.Top -= 31; } else { timer7.Stop(); } break;
            case 41: if (three2.Left >= 116) { bluetwo.Left -= 20; } else if (bluetwo.Top >= 298) { bluetwo.Top -= 31; } else { timer7.Stop(); } break;

            case 51: if (three2.Left >= 116) { bluetwo.Left -= 20; } else if (bluetwo.Top >= 240) { bluetwo.Top -= 31; } else { timer7.Stop(); } break;

            case 61: if (three2.Left >= 116) { bluetwo.Left -= 20; } else if (bluetwo.Top >= 182) { bluetwo.Top -= 31; } else { timer7.Stop(); } break;

            case 71: if (three2.Left >= 116) { bluetwo.Left -= 20; } else if (bluetwo.Top >= 356) { bluetwo.Top -= 31; } else { timer7.Stop(); } break;

            case 81: if (three2.Left >= 116) { bluetwo.Left -= 20; } else if (bluetwo.Top >= 356) { bluetwo.Top -= 31; } else { timer7.Stop(); } break;

            case 91: if (three2.Left >= 116) { bluetwo.Left -= 20; } else if (bluetwo.Top >= 356) { bluetwo.Top -= 31; } else { timer7.Stop(); } break;

            case 98: if (three2.Left >= 838) { bluetwo.Left -= 20; } else { timer7.Stop(); } break;*/


        }
    }

    private void timer12_Tick(object sender, EventArgs e)
    {
        switch (blackposition )
        {

            case 1: if (three2.Left >= 76 && three2.Top <= 530) { three2.Left -= 20; three2.Top += 11; } else { timer12.Stop(); three2.Location = new Point(76, 530); player3.controls.stop(); } break;
            case 5: if (three2.Top <= 530) { three2.Top += 10; } else { timer12.Stop(); three2.Location = new Point(500, 530); player3.controls.stop(); } break;//true-20
            case 27: if (three2.Top >= 414 && three2.Left <= 712) { three2.Top -= 20; three2.Left += 22; } else { timer12.Stop(); three2.Location = new Point(712, 414); player3.controls.stop(); } break;

            case 51: if (three2.Top >= 240 && three2.Left >= 76) { three2.Top -= 20; three2.Left -= 13; } else { timer12.Stop(); three2.Location = new Point(76, 240); player3.controls.stop(); } break;

            case 55: if (three2.Left >= 500 && three2.Top >= 240) { three2.Left -= 20; three2.Top -= 22; } else { timer12.Stop(); three2.Location = new Point(500, 240); player3.controls.stop(); } break;//true

            case 19: if (three2.Left <= 924 && three2.Top <= 472) { three2.Left += 20; three2.Top += 16; } else { timer12.Stop(); three2.Location = new Point(924, 472); player3.controls.stop(); } break;

            case 95: if (three2.Left <= 500 && three2.Top >= 10) { three2.Left += 20; three2.Top -= 16; } else { timer12.Stop(); three2.Location = new Point(500, 8); player3.controls.stop(); } break;//true
            case 52: if (three2.Top <= 240 && three2.Left >= 182) { three2.Top += 4; three2.Left -= 20; } else { timer12.Stop(); three2.Location = new Point(182, 240); player3.controls.stop(); } break;
            case 57: if (three2.Top <= 220) { three2.Top += 10; } else { timer12.Stop(); three2.Location = new Point(712, 240); player3.controls.stop(); } break;//true
            case 61: if (three2.Top <= 182) { three2.Top += 10; } else { timer12.Stop(); three2.Location = new Point(76, 182); player3.controls.stop(); } break;//true
            case 69: if (three2.Top <= 182) { three2.Top += 10; } else { timer12.Stop(); three2.Location = new Point(924, 182); player3.controls.stop(); } break;//true
            case 98: if (three2.Top >= 8) { three2.Top -= 10; } else { timer12.Stop(); three2.Location = new Point(818, 8); player3.controls.stop(); } break;
            case 97: if (three2.Left >= 712) { three2.Left -= 20; } else { timer12.Stop(); three2.Location = new Point(712, 8); player3.controls.stop(); } break;
            case 96: if (three2.Left >= 606) { three2.Left -= 20; } else { timer12.Stop(); three2.Location = new Point(606, 8);  player3.controls.stop();} break;
        }
    }

    private void timer13_Tick(object sender, EventArgs e)
    {
        switch (blackposition )
        {

            case 99: if (three2.Left >= 924) { three2.Left -= 20; } else { timer13.Stop(); bluetwo.Location = new Point(924,8); blackposition  = 69; timer12.Start(); } break;
        }
    }

    private void timer14_Tick(object sender, EventArgs e)
    {
        switch (greenposition )
        {
            case 1:player4.controls.stop();  break;
            case 2: if (four2.Left <= 162) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(162, 530); player4.controls.stop(); } break;
            case 3: if (four2.Left <= 268) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(268, 530); greenposition = 51; timer16.Start(); } break;
            case 4: if (four2.Left <= 374) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(374, 530); player4.controls.stop(); } break;
            case 5: if (four2.Left <= 480) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(480, 530); player4.controls.stop(); } break;
            case 6: if (four2.Left <= 586) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(586, 530); greenposition = 27; timer16.Start(); } break;
            case 7: if (four2.Left <= 692) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(692, 530); player4.controls.stop(); } break;
            case 8: if (four2.Left <= 798) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(798, 530); player4.controls.stop(); } break;
            case 9: if (four2.Left <= 904) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(904, 530); player4.controls.stop(); } break;
            case 10: if (four2.Left <= 1010) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(1010, 530); player4.controls.stop(); } break;
            case 11: if (four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(56, 472); player4.controls.stop(); } break;


            case 12: if (four2.Top == 530 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 530) { four2.Location = new Point(56, 472); } timer15.Start(); } break;
            case 13: if (four2.Top == 530 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 530) { four2.Location = new Point(56, 472); } timer15.Start(); } break;
            case 14: if (four2.Top == 530 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 530) { four2.Location = new Point(56, 472); } timer15.Start(); } break;
            case 15: if (four2.Top == 530 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 530) { four2.Location = new Point(56, 472); } timer15.Start(); } break;
            case 16: if (four2.Top == 530 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 530) { four2.Location = new Point(56, 472); } timer15.Start(); } break;


            case 17: if (four2.Left <= 692) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(692, 472); player4.controls.stop(); } break;
            case 18: if (four2.Left <= 798) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(798, 472); player4.controls.stop(); } break;
            case 19: if (four2.Left <= 904) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(904, 472); player4.controls.stop(); } break;
            case 20: if (four2.Left <= 1010) { four2.Left += 20; } else if (four2.Top >= 182) { four2.Top -= 10; } else { timer14.Stop(); four2.Location = new Point(1010, 182); greenposition = 70; player4.controls.stop(); } break;
            case 21: if (four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(56, 414); player4.controls.stop(); } break;

            case 22: if (four2.Top == 472 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 472) { four2.Location = new Point(56, 414); } timer15.Start(); } break;
            case 23: if (four2.Top == 472 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 472) { four2.Location = new Point(56, 414); } timer15.Start(); } break;
            case 24: if (four2.Top == 472 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 472) { four2.Location = new Point(56, 414); } timer15.Start(); } break;
            case 25: if (four2.Top == 472 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 472) { four2.Location = new Point(56, 414); } timer15.Start(); } break;
            case 26: if (four2.Top == 472 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 472) { four2.Location = new Point(56, 414); } timer15.Start(); } break;

            case 27: if (four2.Left <= 692) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(692, 414); player4.controls.stop(); } break;
            case 28: if (four2.Left <= 798) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(798, 414); player4.controls.stop(); } break;
            case 29: if (four2.Left <= 904) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(904, 414); player4.controls.stop(); } break;
            case 30: if (four2.Left <= 1010) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(1010, 414); player4.controls.stop(); } break;

            case 31: if (four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(56, 356); player4.controls.stop(); } break;

            case 32: if (four2.Top == 414 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 414) { four2.Location = new Point(56, 356); } timer15.Start(); } break;
            case 33: if (four2.Top == 414 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 414) { four2.Location = new Point(56, 356); } timer15.Start(); } break;
            case 34: if (four2.Top == 414 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 414) { four2.Location = new Point(56, 356); } timer15.Start(); } break;
            case 35: if (four2.Top == 414 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 414) { four2.Location = new Point(56, 356); } timer15.Start(); } break;
            case 36: if (four2.Top == 414 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 414) { four2.Location = new Point(56, 356); } timer15.Start(); } break;

            case 37: if (four2.Left <= 692) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(692, 356); player4.controls.stop(); } break;
            case 38: if (four2.Left <= 798) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(798, 356); player4.controls.stop(); } break;
            case 39: if (four2.Left <= 904) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(904, 356); player4.controls.stop(); } break;
            case 40: if (four2.Left <= 1010) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(1010, 356); player4.controls.stop(); } break;
            case 41: if (four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(56, 298); player4.controls.stop(); } break;

            case 42: if (four2.Top == 356 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 356) { four2.Location = new Point(56, 298); } timer15.Start(); } break;
            case 43: if (four2.Top == 356 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 356) { four2.Location = new Point(56, 298); } timer15.Start(); } break;
            case 44: if (four2.Top == 356 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 356) { four2.Location = new Point(56, 298); } timer15.Start(); } break;
            case 45: if (four2.Top == 356 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 356) { four2.Location = new Point(56, 298); } timer15.Start(); } break;
            case 46: if (four2.Top == 356 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 356) { four2.Location = new Point(56, 298); } timer15.Start(); } break;

            case 47: if (four2.Left <= 692) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(692, 298); greenposition = 19; timer16.Start(); } break;


            case 48: if (four2.Left <= 798) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(798, 298); player4.controls.stop(); } break;
            case 49: if (four2.Left <= 904) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(904, 298); player4.controls.stop(); } break;
            case 50: if (four2.Left <= 1010) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(1010, 298); player4.controls.stop(); } break;
            case 51: if (four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(56, 240); player4.controls.stop(); } break;

            case 52: if (four2.Top == 298 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 298) { four2.Location = new Point(56, 240); } timer15.Start(); } break;
            case 53: if (four2.Top == 298 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 298) { four2.Location = new Point(56, 240); } timer15.Start(); } break;
            case 54: if (four2.Top == 298 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 298) { four2.Location = new Point(56, 240); } timer15.Start(); } break;
            case 55: if (four2.Top == 298 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 298) { four2.Location = new Point(56, 240); } timer15.Start(); } break;
            case 56: if (four2.Top == 298 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 298) { four2.Location = new Point(56, 240); } timer15.Start(); } break;

            case 57: if (four2.Left <= 692) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(692, 240); player4.controls.stop(); } break;
            case 58: if (four2.Left <= 798) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(798, 240); player4.controls.stop(); } break;
            case 59: if (four2.Left <= 904) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(904, 240); player4.controls.stop(); } break;
            case 60: if (four2.Left <= 1010) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(1010, 240); player4.controls.stop(); } break;
            case 61: if (four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(56, 182); player4.controls.stop(); } break;

            case 62: if (four2.Top == 240 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 240) { four2.Location = new Point(56, 182); } timer15.Start(); } break;
            case 63: if (four2.Top == 240 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 240) { four2.Location = new Point(56, 182); } timer15.Start(); } break;
            case 64: if (four2.Top == 240 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 240) { four2.Location = new Point(56, 182); } timer15.Start(); } break;
            case 65: if (four2.Top == 240 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 240) { four2.Location = new Point(56, 182); } timer15.Start(); } break;
            case 66: if (four2.Top == 240 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 240) { four2.Location = new Point(56, 182); } timer15.Start(); } break;

            case 67: if (four2.Left <= 692) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(692, 182); player4.controls.stop(); } break;
            case 68: if (four2.Left <= 798) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(798, 182); greenposition = 98; timer16.Start(); } break;
            case 69: if (four2.Left <= 904) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(904, 182); player4.controls.stop(); } break;
            case 70: if (four2.Left <= 1010) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(1010, 182); player4.controls.stop(); } break;
            case 71: if (four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(56, 124); player4.controls.stop(); } break;

            case 72: if (four2.Top == 182 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 182) { four2.Location = new Point(56, 124); } timer15.Start(); } break;
            case 73: if (four2.Top == 182 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 182) { four2.Location = new Point(56, 124); } timer15.Start(); } break;
            case 74: if (four2.Top == 182 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 182) { four2.Location = new Point(56, 124); } timer15.Start(); } break;
            case 75: if (four2.Top == 182 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 182) { four2.Location = new Point(56, 124); } timer15.Start(); } break;
            case 76: if (four2.Top == 182 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 182) { four2.Location = new Point(56, 124); } timer15.Start(); } break;

            case 77: if (four2.Left <= 692) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(692, 124); player4.controls.stop(); } break;
            case 78: if (four2.Left <= 798) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(798, 124); player4.controls.stop(); } break;
            case 79: if (four2.Left <= 904) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(904, 124); player4.controls.stop(); } break;
            case 80: if (four2.Left <= 1010) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(1010, 124); player4.controls.stop(); } break;
            case 81: if (four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(56, 66); player4.controls.stop(); } break;

            case 82: if (four2.Top == 124 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 124) { four2.Location = new Point(56, 66); } timer15.Start(); } break;
            case 83: if (four2.Top == 124 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 124) { four2.Location = new Point(56, 66); } timer15.Start(); } break;
            case 84: if (four2.Top == 124 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 124) { four2.Location = new Point(56, 66); } timer15.Start(); } break;
            case 85: if (four2.Top == 124 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 124) { four2.Location = new Point(56, 66); } timer15.Start(); } break;
            case 86: if (four2.Top == 124 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 124) { four2.Location = new Point(56, 66); } timer15.Start(); } break;

            case 87: if (four2.Left <= 692) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(692, 66); greenposition = 57; timer16.Start(); } break;
            case 88: if (four2.Left <= 798) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(798, 66); player4.controls.stop(); } break;
            case 89: if (four2.Left <= 904) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(904, 66); player4.controls.stop(); } break;
            case 90: if (four2.Left <= 1010) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(1010, 66); player4.controls.stop(); } break;
            case 91: if (four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(56, 8); greenposition = 61; timer16.Start(); } break;

            case 92: if (four2.Top == 66 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 66) { four2.Location = new Point(56, 8); } timer15.Start(); } break;
            case 93: if (four2.Top == 66 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 66) { four2.Location = new Point(56, 8); } timer15.Start(); } break;
            case 94: if (four2.Top == 66 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 66) { four2.Location = new Point(56, 8); } timer15.Start(); } break;
            case 95: if (four2.Top == 66 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 66) { four2.Location = new Point(56, 8); } timer15.Start(); } break;
            case 96: if (four2.Top == 66 && four2.Left <= 1070) { four2.Left += 20; } else { timer14.Stop(); if (four2.Top == 66) { four2.Location = new Point(56, 8); } timer15.Start(); } break;

            case 97: if (four2.Left <= 692) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(692, 8); player4.controls.stop(); } break;
            case 98: if (four2.Left <= 798) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(798, 8); player4.controls.stop(); } break;
            case 99: if (four2.Left <= 904) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(904, 8); greenposition = 69; timer16.Start(); } break;
            case 100: if (four2.Left <= 1010) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(1010, 8); Form4 f4 = new Form4(); f4.Show(); roll1.Enabled = false; roll2.Enabled = false; r3.Enabled = false; r4.Enabled = false; player4.controls.stop(); } break;
            case 101: if (four2.Left <= 1010) { four2.Left += 20; } else { timer14.Stop(); four2.Location = new Point(1010, 8); greenposition = 99; timer17.Start(); } break;//point

            case 102: if (four2.Left <= 1050) { four2.Left += 20; } else { timer10.Stop(); four2.Location = new Point(1010, 8); greenposition = 98; timer15.Start(); } break;
            case 103: if (four2.Left <= 1050) { four2.Left += 20; } else { timer10.Stop(); four2.Location = new Point(1010, 8); greenposition = 97; timer16.Start(); } break;
            case 104: if (four2.Left <= 1050) { four2.Left += 20; } else { timer10.Stop(); four2.Location = new Point(1010, 8); greenposition = 96; timer16.Start(); } break;





        }
    }

    private void timer15_Tick(object sender, EventArgs e)
    {
        switch (greenposition )
        {
            case 12: if (four2.Left <= 162) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(162, 472); player4.controls.stop(); } break;
            case 13: if (four2.Left <= 268) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(268, 472); player4.controls.stop(); } break;
            case 14: if (four2.Left <= 374) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(374, 472); player4.controls.stop(); } break;
            case 15: if (four2.Left <= 480) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(480, 472); player4.controls.stop(); } break;
            case 16: if (four2.Left <= 586) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(586, 472); player4.controls.stop(); } break;

            case 22: if (four2.Left <= 162) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(162, 414); player4.controls.stop(); } break;
            case 23: if (four2.Left <= 268) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(268, 414); player4.controls.stop(); } break;
            case 24: if (four2.Left <= 374) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(374, 414); player4.controls.stop(); } break;
            case 25: if (four2.Left <= 480) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(480, 414); greenposition = 5; timer16.Start(); } break;
            case 26: if (four2.Left <= 586) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(586, 414); player4.controls.stop(); } break;

            case 32: if (four2.Left <= 162) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(162, 356); player4.controls.stop(); } break;
            case 33: if (four2.Left <= 268) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(268, 356); player4.controls.stop(); } break;
            case 34: if (four2.Left <= 374) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(374, 356); greenposition = 1; timer16.Start(); } break;
            case 35: if (four2.Left <= 480) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(480, 356); player4.controls.stop(); } break;
            case 36: if (four2.Left <= 586) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(586, 356); greenposition = 55; timer16.Start(); } break;

            case 42: if (four2.Left <= 162) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(162, 298); player4.controls.stop(); } break;
            case 43: if (four2.Left <= 268) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(268, 298); player4.controls.stop(); } break;
            case 44: if (four2.Left <= 374) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(374, 298); player4.controls.stop(); } break;
            case 45: if (four2.Left <= 480) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(480, 298); player4.controls.stop(); } break;
            case 46: if (four2.Left <= 586) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(586, 298); player4.controls.stop(); } break;

            case 52: if (four2.Left <= 162) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(162, 240); player4.controls.stop(); } break;
            case 53: if (four2.Left <= 268) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(268, 240); player4.controls.stop(); } break;
            case 54: if (four2.Left <= 374) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(374, 240); player4.controls.stop(); } break;
            case 55: if (four2.Left <= 480) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(480, 240); player4.controls.stop(); } break;
            case 56: if (four2.Left <= 586) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(586, 240); player4.controls.stop(); } break;

            case 62: if (four2.Left <= 162) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(162, 182); player4.controls.stop(); } break;
            case 63: if (four2.Left <= 268) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(268, 182); greenposition = 95; timer16.Start(); } break;
            case 64: if (four2.Left <= 374) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(374, 182); player4.controls.stop(); } break;
            case 65: if (four2.Left <= 480) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(480, 182); greenposition = 52; timer16.Start(); } break;
            case 66: if (four2.Left <= 586) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(586, 182); player4.controls.stop(); } break;

            case 72: if (four2.Left <= 162) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(162, 124); player4.controls.stop(); } break;
            case 73: if (four2.Left <= 268) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(268, 124); player4.controls.stop(); } break;
            case 74: if (four2.Left <= 374) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(374, 124); player4.controls.stop(); } break;
            case 75: if (four2.Left <= 480) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(480, 124); player4.controls.stop(); } break;
            case 76: if (four2.Left <= 586) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(586, 124); player4.controls.stop(); } break;

            case 82: if (four2.Left <= 162) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(162, 66); player4.controls.stop(); } break;
            case 83: if (four2.Left <= 268) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(268, 66); player4.controls.stop(); } break;
            case 84: if (four2.Left <= 374) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(374, 66); player4.controls.stop(); } break;
            case 85: if (four2.Left <= 480) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(480, 66); player4.controls.stop(); } break;
            case 86: if (four2.Left <= 586) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(586, 66); player4.controls.stop(); } break;

            case 92: if (four2.Left <= 162) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(162, 8); player4.controls.stop(); } break;
            case 93: if (four2.Left <= 268) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(268, 8); player4.controls.stop(); } break;
            case 94: if (four2.Left <= 374) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(374, 8); player4.controls.stop(); } break;
            case 95: if (four2.Left <= 480) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(480, 8); player4.controls.stop(); } break;
            case 96: if (four2.Left <= 586) { four2.Left += 20; } else { timer15.Stop(); four2.Location = new Point(586, 8); player4.controls.stop(); } break;

        }
    }

    private void timer16_Tick(object sender, EventArgs e)
    {

        switch (greenposition )
        {

            case 1: if (four2.Left >= 56 && four2.Top <= 530) { four2.Left -= 20; four2.Top += 11; } else { timer16.Stop(); four2.Location = new Point(56, 530); player4.controls.stop(); } break;

            case 5: if (four2.Top <= 530) { four2.Top += 10; } else { timer16.Stop(); four2.Location = new Point(500, 530); player4.controls.stop(); } break;//true-20

            case 27: if (four2.Top >= 414 && four2.Left <= 692) { four2.Top -= 20; four2.Left += 22; } else { timer16.Stop(); four2.Location = new Point(692, 414); player4.controls.stop(); } break;

            case 51: if (four2.Top >= 240 && four2.Left >= 56) { four2.Top -= 20; four2.Left -= 13; } else { timer16.Stop(); four2.Location = new Point(56, 240); player4.controls.stop(); } break;

            case 55: if (four2.Left >= 480 && four2.Top >= 240) { four2.Left -= 20; four2.Top -= 22; } else { timer16.Stop(); four2.Location = new Point(480, 240); player4.controls.stop(); } break;//true

            case 19: if (four2.Left <= 904 && four2.Top <= 472) { four2.Left += 20; four2.Top += 16; } else { timer16.Stop(); four2.Location = new Point(904, 472); player4.controls.stop(); } break;

            case 95: if (four2.Left <= 480 && four2.Top >= 10) { four2.Left += 20; four2.Top -= 16; } else { timer16.Stop(); four2.Location = new Point(480, 8); player4.controls.stop(); } break;//true
            case 52: if (four2.Top <= 240 && four2.Left >= 162) { four2.Top += 4; four2.Left -= 20; } else { timer16.Stop(); four2.Location = new Point(162, 240); player4.controls.stop(); } break;
            case 57: if (four2.Top <= 220) { four2.Top += 10; } else { timer16.Stop(); four2.Location = new Point(692, 240); player4.controls.stop(); } break;//true
            case 61: if (four2.Top <= 182) { four2.Top += 10; } else { timer16.Stop(); four2.Location = new Point(56, 182); player4.controls.stop(); } break;//true
            case 69: if (four2.Top <= 182) { four2.Top += 10; } else { timer16.Stop(); four2.Location = new Point(904, 182); player4.controls.stop(); } break;//true
            case 98: if (four2.Top >= 8) { four2.Top -= 10; } else { timer16.Stop(); four2.Location = new Point(798, 8); player4.controls.stop(); } break;
            case 97: if (four2.Left >= 692) { four2.Left -= 20; } else { timer16.Stop(); four2.Location = new Point(692, 8); player4.controls.stop(); } break;
            case 96: if (four2.Left >= 586) { four2.Left -= 20; } else { timer16.Stop(); four2.Location = new Point(586, 8); player4.controls.stop(); } break;
        }
    }

    private void timer17_Tick(object sender, EventArgs e)
    {
        switch (greenposition )
        {

            case 99: if (four2.Left >= 904) { four2.Left -= 20; } else { timer17.Stop(); four2.Location = new Point(904, 8); greenposition  = 69; timer16.Start(); } break;
        }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void pictureBox3_Click_1(object sender, EventArgs e)
    {

    }

    private void dice_Click(object sender, EventArgs e)
    {

    }

 
    
    
    
    
    }

    }

