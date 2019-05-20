using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*  Nathan Turner and Tommy Carron     f= a full class period
 *Weds 10/25   Nathan Turner f
 *Thurs 10/26  tommy c money f
 *Mon 10/30    Nathan Turner f
 *Tues 10/31   nathan Turner f
 *Weds 11/1     Tom Carron f
 *Thurs 11/2    tom carron f
 *Fri 11/3      Nathan Turner f
 */

namespace Adventure_Game
{


    public partial class frm : Form
    {
        bool thornyRing = false;
        bool thornArmor = false;
        bool bestoc = false;
     
        public frm()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            picbox.Image = Properties.Resources.firelink_Shrine;
            String choice1 = (btn1.Text);

            if (choice1 == "High Wall")
            {
                btn1.Text = "Fight Dancer";
                btn2.Text = "Fight Vordt";
                btn3.Visible = true;
                btn3.Text = "jump off cliff for item";
                btn4.Visible = true;
                btn4.Text = "go back to start";
                txtBox.Text = "you are in High Wall you can";
                picbox.Image = Properties.Resources.high_wall;
               

            }
            else if (choice1 == "go back to start")
            {
                btn1.Visible = true;
                btn2.Visible = true;
                btn4.Visible = false;
                btn3.Visible = false;
                btn1.Text = "High Wall";
                btn2.Text = "Irithyll";
                picbox.Image = Properties.Resources.firelink_Shrine;
                txtBox.Text = "You awaken at firelink shrine you see a bonfire which connects to other bonfires one in High Wall and one in Irithyll";
                if (bestoc == true && thornyRing == true && thornArmor == true)
                {
                    btn3.Visible = true;
                    btn3.Text = "fight the soul of cinder";
                }
            }

            else if (choice1 == "Fight Dancer")
            {
                btn1.Text = "Summon people";
                btn4.Text = "run for your life";
                btn2.Text = "Hit it 'til it dies";
                btn4.Visible = true;
                btn3.Text = "Give up";
                btn1.Visible = true;
                picbox.Image = Properties.Resources.Dancer_of_the_Borreal_Valley_0;
                txtBox.Text = "You are against the dancer of the boreal valley! Whatchu gonna do?";
                btn2.Visible = true;
            }
          else  if (choice1 == "go back")
            {
                btn2.Visible = false;
                btn3.Visible = true;
                btn4.Visible = true;
                btn1.Text = "Fight Dancer";
                btn2.Text = "Fight Vordt";
                btn3.Text = "jump off cliff for item";
                btn4.Text = "go back to start";
                txtBox.Text = "you are in High Wall you can";
                picbox.Image = Properties.Resources.high_wall;
            }
          else  if (choice1 == "git gud u filthy casul")
            {
                picbox.Image = Properties.Resources.ringothorn;
                txtBox.Text = "You got a thorny ring";
                thornyRing = true;
                btn1.Visible = true;
                btn2.Visible = false;
                btn3.Visible = false;
                btn4.Visible = false;
                btn1.Text = "go back";
            }
         else   if (choice1 == "Summon people")
            {
                btn2.Visible = false;
                btn1.Text = "go back bud";
                btn3.Visible = false;
                btn4.Visible = false;
                thornArmor = true;
                picbox.Image = Properties.Resources.thornArmor;
                txtBox.Text = "you won and got a armer of thurns";
            }
            else if (choice1 == "go back bud")
            {
                btn1.Visible = false;
                btn2.Visible = true;
                btn3.Visible = true;
                btn4.Visible = true;
                btn1.Text = "Fight Dancer";
                btn2.Text = "Fight Vordt";
                btn3.Text = "jump off cliff for item";
                btn4.Text = "go back to start";
                txtBox.Text = "you are in High Wall you can";
                picbox.Image = Properties.Resources.high_wall;
            }
            else if (choice1 == "Parry dem attacks")
            {
                btn1.Visible = false;
                btn2.Visible = false;
                btn3.Visible = false;
                btn4.Visible = true;
                btn4.Text = "start over you pleb";
                txtBox.Text = "you can't parry magic moron";
                picbox.Image = Properties.Resources.youdied;
            }
            else if (choice1 == "restart")
            {
                Application.Restart();
            }
            else if (choice1 == "look up youtube tutorial")
            {
                btn1.Visible = false;
                btn2.Visible = false;
                btn3.Visible = false;
                txtBox.Text = "youtube cant give you skill";
                btn4.Text = "start over you pleb";
                picbox.Image = Properties.Resources.youdied;
            }
         
            
            
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            String choice2 = (btn2.Text);

            if (choice2 == "Hit it 'til it dies")
            {
                btn1.Visible = false;
                btn2.Visible = false;
                btn3.Visible = false;
                txtBox.Text = "You died. What did you expect?";
                btn4.Text = "start over you pleb";
                picbox.Image = Properties.Resources.youdied;
            }
          else  if (choice2 == "Fight Vordt")

            {
                picbox.Image = Properties.Resources.Vordty_boi;
                btn2.Text = "run for your life";
                btn3.Text = "fight dat boi";
                btn1.Text = "git gud u filthy casul";
                btn1.Visible = true;
                btn4.Visible = false;
                txtBox.Text = "a wild vordty boi appears";
            }
          else  if (choice2 == "run for your life")
            {
                btn1.Text = "Fight Dancer";
                btn2.Text = "Fight Vordt";
                btn3.Visible = true;

                btn4.Visible = true;
                btn4.Text = "go back to start";
                btn3.Text = "jump off cliff for item";
                txtBox.Text = "you are in High Wall you can";

                picbox.Image = Properties.Resources.high_wall;
            }
          else  if (choice2 == "Irithyll")
            {
                picbox.Image = Properties.Resources.boi;
                btn1.Text = "Parry dem attacks";
                btn2.Text = "Run around the arena";
                btn3.Text = "just give up scrub";
                txtBox.Text = "yo fella up vs aldrich wat u do?";
                btn4.Visible = false;
                btn3.Visible = true;
            }
            else if (choice2 == "Run around the arena")
            {
                btn1.Visible = true;
                btn2.Visible = false;
                btn3.Visible = false;
                btn4.Visible = false;
                btn1.Text = "go back to start";
                picbox.Image = Properties.Resources.bestoc;
                txtBox.Text = "you claimed a legendary bestoc";
                bestoc = true;
            }
            else if (choice2 == "fight him with cheese")
            {
                picbox.Image = Properties.Resources.you_win;
                btn1.Visible = true;
                btn2.Visible = true;
                btn3.Visible = false;
                btn4.Visible = false;
                btn1.Text = "restart";
                btn2.Text = "quit";
                txtBox.Text = "you won congragulations";
            }
            else if (choice2 == "quit")
            {
                Application.Exit();
            }

          
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            String choice3 = (btn3.Text);
           
            if (choice3 == "fight the soul of cinder")
            {
                btn1.Visible = true;
                btn2.Visible = true;
                btn3.Visible = true;
                btn4.Visible = true;
                btn1.Text = "look up youtube tutorial";
                btn2.Text = "fight him with cheese";
                btn3.Text = "try to parry";
                btn4.Text = "chug estus flasks";
                picbox.Image = Properties.Resources.Soul_of_Cinder___02;
                txtBox.Text = "the legendary final boss appears what you gonna do";
            }
            else if (choice3 == "try to parry")
            {
                btn1.Visible = false;
                btn2.Visible = false;
                btn3.Visible = false;
                btn4.Visible = true;
                btn4.Text = "start over you pleb";
                txtBox.Text = "why would you parry with an estoc?";
                picbox.Image = Properties.Resources.youdied;
            }

           else if (choice3 == "jump off cliff for item")
         {
                btn1.Visible = false;
                btn2.Visible = false;
                btn3.Visible = false;
                btn4.Visible = true;
                btn4.Text = "start over you pleb";
                txtBox.Text = "you died. what a scruby boi";
                picbox.Image = Properties.Resources.youdied;
         }
          else  if (choice3 == "Give up")
            {
                btn1.Visible = false;
                btn2.Visible = false;
                btn3.Visible = false;
                btn4.Visible = true;
                txtBox.Text = "You died. What did you expect?";
                btn4.Text = "start over you pleb";
                picbox.Image = Properties.Resources.youdied;

            }
         else   if (choice3 == "fight dat boi")
            {
                btn1.Visible = false;
                btn2.Visible = false;
                btn3.Visible = false;
                btn4.Visible = true;
                btn4.Text = "start over you pleb";
                txtBox.Text = "Congrats man you won, oh nevermind man you dead";
                picbox.Image = Properties.Resources.youdied;
            }
            else if (choice3 == "just give up scrub")
            {
                btn1.Visible = false;
                btn2.Visible = false;
                btn3.Visible = false;
                btn4.Visible = true;
                txtBox.Text = "Suicidal much";
                btn4.Text = "start over you pleb";
                picbox.Image = Properties.Resources.youdied;
            }
           
        }




        private void btn4_Click(object sender, EventArgs e)

        {
            String choice4 = (btn4.Text);
            if (choice4 == "start over you pleb")
            {
                btn1.Visible = true;
                btn2.Visible = true;
                btn4.Visible = false;

                btn1.Text = "High Wall";
                btn2.Text = "Irithyll";
                picbox.Image = Properties.Resources.firelink_Shrine;
                txtBox.Text = "You awaken at firelink shrine you see a bonfire which connects to other bonfires one in High Wall and one in Irithyll";
            }
           else if (choice4 == "go back to start")
            {
                btn1.Visible = true;
                btn2.Visible = true;
                btn4.Visible = false;
                btn3.Visible = false;
                btn1.Text = "High Wall";
                btn2.Text = "Irithyll";
                picbox.Image = Properties.Resources.firelink_Shrine;
                txtBox.Text = "You awaken at firelink shrine you see a bonfire which connects to other bonfires one in High Wall and one in Irithyll";
            }
            else if (choice4 == "chug estus flasks")
            {
                btn1.Visible = false;
                btn2.Visible = false;
                btn3.Visible = false;
                btn4.Visible = true;
                txtBox.Text = "he hit you as you tried to finish the last sip";
                btn4.Text = "start over you pleb";
                picbox.Image = Properties.Resources.youdied;
            }
           else if (choice4 == "run for your life")
            {
                btn1.Text = "Fight Dancer";
                btn2.Text = "Fight Vordt";
                btn3.Visible = true;

                btn4.Visible = true;
                btn4.Text = "go back to start";
                btn3.Text = "jump off cliff for item";
                txtBox.Text = "you are in High Wall you can";

                picbox.Image = Properties.Resources.high_wall;


            }
          
        }
    }
}
