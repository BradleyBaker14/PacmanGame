using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Pacman_Zagorschi_Franco
{
    public partial class Form1 : Form
    {
        // Declare public integer variables to track the x-position of each ghost and player character
        public int leftGhost1, leftGhost2, leftGhost3, leftGhost4, left;
        // Declare public integer variables to track the y-position of each ghost and player character
        public int topGhost1, topGhost2, topGhost3, topGhost4, top;
        // Declare public integer variables to track the next move, current direction, and a temporary value
        public int next, direction, temp = 1;
        // Declare public boolean variables to track which player or ghost character has the current turn to make a move
        public bool pacTurn, ghost1Turn, ghost2Turn, ghost3Turn, ghost4Turn, start;
        // Declare public boolean variables to track whether each ghost character is currently able to eat the player character
        public bool ghost1CanEat, ghost2CanEat, ghost3CanEat, ghost4CanEat;
        // Declare public boolean variables to track whether each ghost character has eaten the player character
        public bool g1Eaten, g2Eaten, g3Eaten, g4Eaten;
        // Declare public boolean variables to track various game states and conditions
        public bool dir1, dir2, dir3, dir4, c, superMode, superMode1, superMode2, superMode3, superMode4, v1, v2, v3, v4, threeSec = true;
        // Declare public integer variables to store random numbers generated for various purposes in the game
        public int random1, random2, random3, random4;
        // Declare public integer variables to track the number of lives the player has remaining and the player's score
        public int lives = 3, point;
        // Declare public integer variables to track the duration of certain game events or animations
        public int tic4, tic5, tic6;


        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label255_Click(object sender, EventArgs e)
        {

        }

        private void label254_Click(object sender, EventArgs e)
        {

        }

        private void pacman_Click(object sender, EventArgs e)
        {

        }

        private void button10_click(object sender, EventArgs e)
        {
            Controls controls = new Controls();

            controls.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Controls control = new Controls();
            control.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void transparent_Bg(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label142_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        // Declare public integer variables to track the previous direction of each ghost character, and set the player's starting direction
        public int prev1, prev2, prev3, prev4, startingDirection = 1;
        // Declare public integer variables to set the velocity of each ghost character
        public int ghost1Velocity = 2, ghost2Velocity = 2, ghost3Velocity = 2, ghost4Velocity = 2;
        // Create a new Random object for generating random numbers
        public Random rand = new Random();
        // Declare a List of objects to store various game objects
        public List<object> objects = new List<object>();



        //inizializzazione della Form1
        public Form1()
        {
            InitializeComponent();
            //calling all labels to be added just incase the label does not show on run time
            objects.Add(label4);
            objects.Add(label5);
            objects.Add(label6);
            objects.Add(label7);
            objects.Add(label8);
            objects.Add(label9);
            objects.Add(label10);
            objects.Add(label11);
            objects.Add(label12);
            objects.Add(label13);
            objects.Add(label14);
            objects.Add(label15);
            objects.Add(label16);
            objects.Add(label17);
            objects.Add(label18);
            objects.Add(label19);
            objects.Add(label20);
            objects.Add(label21);
            objects.Add(label22);
            objects.Add(label23);
            objects.Add(label24);
            objects.Add(label25);
            objects.Add(label26);
            objects.Add(label27);
            objects.Add(label28);
            objects.Add(label29);
            objects.Add(label30);
            objects.Add(label31);
            objects.Add(label32);
            objects.Add(label33);
            objects.Add(label34);
            objects.Add(label35);
            objects.Add(label36);
            objects.Add(label37);
            objects.Add(label38);
            objects.Add(label39);
            objects.Add(label40);
            objects.Add(label41);
            objects.Add(label42);
            objects.Add(label43);
            objects.Add(label44);
            objects.Add(label45);
            objects.Add(label46);
            objects.Add(label47);
            objects.Add(label48);
            objects.Add(label49);
            objects.Add(label50);
            objects.Add(label51);
            objects.Add(label52);
            objects.Add(label53);
            objects.Add(label54);
            objects.Add(label55);
            objects.Add(label56);
            objects.Add(label57);
            objects.Add(label58);
            objects.Add(label59);
            objects.Add(label60);
            objects.Add(label61);
            objects.Add(label62);
            objects.Add(label63);
            objects.Add(label64);
            objects.Add(label65);
            objects.Add(label66);
            objects.Add(label67);
            objects.Add(label68);
            objects.Add(label69);
            objects.Add(label70);
            objects.Add(label71);
            objects.Add(label72);
            objects.Add(label73);
            objects.Add(label74);
            objects.Add(label75);
            objects.Add(label76);
            objects.Add(label77);
            objects.Add(label78);
            objects.Add(label79);
            objects.Add(label80);
            objects.Add(label81);
            objects.Add(label82);
            objects.Add(label83);
            objects.Add(label84);
            objects.Add(label85);
            objects.Add(label86);
            objects.Add(label87);
            objects.Add(label88);
            objects.Add(label89);
            objects.Add(label90);
            objects.Add(label91);
            objects.Add(label92);
            objects.Add(label93);
            objects.Add(label94);
            objects.Add(label95);
            objects.Add(label96);
            objects.Add(label97);
            objects.Add(label98);
            objects.Add(label99);
            objects.Add(label100);
            objects.Add(label101);
            objects.Add(label102);
            objects.Add(label103);
            objects.Add(label104);
            objects.Add(label105);
            objects.Add(label106);
            objects.Add(label107);
            objects.Add(label108);
            objects.Add(label109);
            objects.Add(label110);
            objects.Add(label111);
            objects.Add(label112);
            objects.Add(label113);
            objects.Add(label114);
            objects.Add(label115);
            objects.Add(label116);
            objects.Add(label117);
            objects.Add(label118);
            objects.Add(label119);
            objects.Add(label120);
            objects.Add(label121);
            objects.Add(label122);
            objects.Add(label123);
            objects.Add(label125);
            objects.Add(label126);
            objects.Add(label127);
            objects.Add(label128);
            objects.Add(label129);
            objects.Add(label130);
            objects.Add(label131);
            objects.Add(label132);
            objects.Add(label133);
            objects.Add(label134);
            objects.Add(label135);
            objects.Add(label136);
            objects.Add(label137);
            objects.Add(label138);
            objects.Add(label139);
            objects.Add(label140);
            objects.Add(label143);
            objects.Add(label144);
            objects.Add(label145);
            objects.Add(label146);
            objects.Add(label147);
            objects.Add(label148);
            objects.Add(label149);
            objects.Add(label150);
            objects.Add(label151);
            objects.Add(label152);
            objects.Add(label153);
            objects.Add(label154);
            objects.Add(label155);
            objects.Add(label156);
            objects.Add(label157);
            objects.Add(label158);
            objects.Add(label159);
            objects.Add(label160);
            objects.Add(label161);
            objects.Add(label162);
            objects.Add(label163);
            objects.Add(label164);
            objects.Add(label165);
            objects.Add(label166);
            objects.Add(label167);
            objects.Add(label168);
            objects.Add(label169);
            objects.Add(label170);
            objects.Add(label171);
            objects.Add(label172);
            objects.Add(label173);
            objects.Add(label174);
            objects.Add(label175);
            objects.Add(label176);
            objects.Add(label177);
            objects.Add(label178);
            objects.Add(label179);
            objects.Add(label180);
            objects.Add(label181);
            objects.Add(label182);
            objects.Add(label183);
            objects.Add(label184);
            objects.Add(label185);
            objects.Add(label186);
            objects.Add(label187);
            objects.Add(label188);
            objects.Add(label189);
            objects.Add(label190);
            objects.Add(label191);
            objects.Add(label192);
            objects.Add(label193);
            objects.Add(label194);
            objects.Add(label195);
            objects.Add(label196);
            objects.Add(label197);
            objects.Add(label198);
            objects.Add(label199);
            objects.Add(label200);
            objects.Add(label201);
            objects.Add(label202);
            objects.Add(label203);
            objects.Add(label204);
            objects.Add(label205);
            objects.Add(label206);
            objects.Add(label207);
            objects.Add(label208);
            objects.Add(label209);
            objects.Add(label210);
            objects.Add(label211);
            objects.Add(label212);
            objects.Add(label213);
            objects.Add(label214);
            objects.Add(label215);
            objects.Add(label216);
            objects.Add(label217);
            objects.Add(label218);
            objects.Add(label219);
            objects.Add(label220);
            objects.Add(label221);
            objects.Add(label222);
            objects.Add(label223);
            objects.Add(label224);
            objects.Add(label225);
            objects.Add(label226);
            objects.Add(label227);
            objects.Add(label228);
            objects.Add(label229);
            objects.Add(label230);
            objects.Add(label231);
            objects.Add(label232);
            objects.Add(label233);
            objects.Add(label234);
            objects.Add(label235);
            objects.Add(label236);
            objects.Add(label237);
            objects.Add(label238);
            objects.Add(label239);
            objects.Add(label240);
            objects.Add(label241);
            objects.Add(label242);
            objects.Add(label243);
            objects.Add(label244);
            objects.Add(label245);
            objects.Add(label246);
            objects.Add(label247);
            objects.Add(label248);
            objects.Add(label249);
            objects.Add(label250);
            objects.Add(label251);
            objects.Add(label252);
            objects.Add(label256);
            objects.Add(label257);
            objects.Add(label258);
            objects.Add(label259);
            objects.Add(label260);
            objects.Add(label261);
            objects.Add(label262);
            objects.Add(label263);
            objects.Add(label264);
            objects.Add(label265);
            objects.Add(label266);
            objects.Add(label267);
            objects.Add(label268);
            objects.Add(label269);
            objects.Add(label270);
            objects.Add(label271);
            objects.Add(label272);
            objects.Add(label273);
            objects.Add(label274);
            objects.Add(label275);
            objects.Add(label276);
            objects.Add(label277);
            objects.Add(label278);
            objects.Add(label279);
            objects.Add(label280);
            objects.Add(label281);
            objects.Add(label282);
            objects.Add(label283);
            objects.Add(label284);
            objects.Add(label285);
            objects.Add(label286);
            objects.Add(label287);
            objects.Add(label288);
            objects.Add(label289);
            objects.Add(label290);
            objects.Add(label291);
            objects.Add(label292);
            objects.Add(label293);
            objects.Add(label294);
            objects.Add(label295);
            objects.Add(label296);
            objects.Add(label297);
            objects.Add(label298);
            objects.Add(label299);
            objects.Add(label300);
            objects.Add(label301);
            objects.Add(label302);
            objects.Add(label303);
            objects.Add(label304);
            objects.Add(label305);
            objects.Add(label306);
            objects.Add(label307);
            objects.Add(label308);
            objects.Add(label309);
            objects.Add(label310);
            objects.Add(label311);
            objects.Add(label312);
            objects.Add(label313);
            objects.Add(label314);
            objects.Add(label315);
            objects.Add(label316);
            objects.Add(label317);
            objects.Add(label318);
            objects.Add(label319);
            objects.Add(label320);
            objects.Add(label321);
            objects.Add(label322);
            objects.Add(label323);
            objects.Add(label324);
            objects.Add(label325);
            objects.Add(label326);
            objects.Add(label327);
            objects.Add(label328);
            objects.Add(label329);
            objects.Add(label330);
            objects.Add(label331);
            objects.Add(label332);
            objects.Add(label333);
            objects.Add(label334);
            objects.Add(label335);
            objects.Add(label336);
            objects.Add(label337);
            objects.Add(label338);
            objects.Add(label339);
            objects.Add(label340);
            objects.Add(label341);
        }

        //Starting the game
        private void button1_Click(object sender, EventArgs e)
        {
            start = true;
            life();
            points();
            panel1.Visible = false;
            resetall();
        }


        //input - User input event handler
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) next = 1; //If the left arrow key is pressed, set next to 1
            if (e.KeyCode == Keys.Right) next = 2; //If the right arrow key is pressed, set next to 2
            if (e.KeyCode == Keys.Up) next = 3; //If the up arrow key is pressed, set next to 3
            if (e.KeyCode == Keys.Down) next = 4; //If the down arrow key is pressed, set next to 4
            if (e.KeyCode == Keys.Escape) Close(); //If the escape key is pressed, close the form
            temp = next; //Set temp equal to next to keep track of the current input
        }


        // Button1 style event handler for when the mouse leaves the button
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Pacman.Properties.Resources.PlayGame1; //Set the button1 image to the default PlayGame image when the mouse leaves the control
            button1.BackColor = Color.Transparent; //Set the button1 background color to transparent when the mouse leaves the control
        }



        //Button1 style event handler for when the mouse enters the button
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Image = Pacman.Properties.Resources.PlayGame1; //Set the button1 image to the default PlayGame image when the mouse enters the control
            button1.BackColor = Color.Transparent; //Set the button1 background color to transparent when the mouse enters the control
        }


        //Timer1 tick event handler
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pacman.Enabled) //If pacman is enabled, run direction and freeDirection methods
            {
                Direction();
                freeDirection();
            }
            if (ghost1.Enabled || ghost2.Enabled || ghost3.Enabled || ghost4.Enabled) //If any of the ghosts are enabled, run the ghost method
            {
                ghost();
            }
            if (c) control(); //If the control flag is true, run the control method
            supermod(); //Run the supermod method
            points(); //Update the points display
            collision(); //Check for collisions between pacman and other game objects
        }


        //Timer2 tick event handler
        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Visible = false; //Hide the "Get Ready!" label
            timer1.Enabled = true; //Enable timer1
            timer2.Enabled = false; //Disable timer2
            c = true; //Set the control flag to true
        }


        //timer3 - Timer3 tick event handler
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (ghost2.Top == 180) startingDirection = 2; //If ghost2's top position is 180, set the starting direction to down (2)
            if (ghost2.Top == 192) startingDirection = 1; //If ghost2's top position is 192, set the starting direction to up (1)
            if (startingDirection == 1) //If the starting direction is up (1), move ghost2 and ghost4 up
            {
                ghost2.Top--;
                ghost4.Top--;
            }
            if (startingDirection == 2) //If the starting direction is down (2), move ghost2 and ghost4 down
            {
                ghost2.Top++;
                ghost4.Top++;
            }
        }


        // This method is called every time timer4 ticks
        private void timer4_Tick(object sender, EventArgs e)
        {
            // Increment the value of tic4 by 1
            tic4++;
            // If ghost3 is more than 150 pixels from the top of the screen
            // and tic4 is greater than 100
            if (ghost3.Top > 150 && tic4 > 100)
            {
                // Set prev1 to 3
                prev1 = 3;

                // Decrement the value of ghost3's Top property by 1
                ghost3.Top--;
            }

            // If ghost3's Top property is now equal to 150 pixels
            if (ghost3.Top == 150)
            {
                // Disable timer4 so it stops ticking
                timer4.Enabled = false;
            }
        }


        // This method is called every time timer5 ticks
        private void timer5_Tick(object sender, EventArgs e)
        {
            // Increment the value of tic5 by 1
            tic5++;
            // If ghost2 is between 153 and 176 pixels from the left of the screen
            // and tic5 is greater than 300
            if (ghost2.Left > 153 && ghost2.Left < 176 && tic5 > 300)
            {
                // Increment the value of ghost2's Left property by 1
                ghost2.Left++;
            }

            // If ghost2 is more than 150 pixels from the top of the screen
            // and its Left property is now equal to 176 pixels
            if (ghost2.Top > 150 && ghost2.Left == 176)
            {
                // Decrement the value of ghost2's Top property by 1
                ghost2.Top--;
            }

            // If ghost2's Top property is now equal to 150 pixels
            if (ghost2.Top == 150)
            {
                // Enable timer6 and disable timer5
                timer6.Enabled = true;
                timer5.Enabled = false;
            }
        }

        // This method is called every time timer6 ticks
        private void timer6_Tick(object sender, EventArgs e)
        {
            // Increment the value of tic6 by 1
            tic6++;
            // If ghost4 is between 176 and 200 pixels from the left of the screen
            // and tic6 is greater than 100
            if (ghost4.Left > 176 && ghost4.Left < 200 && tic6 > 100)
            {
                // Decrement the value of ghost4's Left property by 1
                ghost4.Left--;
            }

            // If ghost4 is more than 150 pixels from the top of the screen
            // and its Left property is now equal to 176 pixels
            if (ghost4.Top > 150 && ghost4.Left == 176)
            {
                // Decrement the value of ghost4's Top property by 1
                ghost4.Top--;
            }

            // If ghost4's Top property is now equal to 150 pixels
            if (ghost4.Top == 150)
            {
                // Disable timer6 so it stops ticking
                timer6.Enabled = false;
            }

        }

        // This method is called by the power-up timer every time it ticks
        // It resets the power-up effects on ghosts, disables the power-up timer,
        // and reverts each ghost to its previous appearance and movement pattern
        private void powermod_Tick(object sender, EventArgs e)
        {
            // Reset power-up effects
            threeSec = false;
            // If ghost 1 has not been eaten, reset its properties to their default values
            if (!g1Eaten)
            {
                v1 = false;
                ghost1CanEat = true;
                superMode1 = false;
                ghost1Velocity = 2;
            }

            // If ghost 2 has not been eaten, reset its properties to their default values
            if (!g2Eaten)
            {
                v2 = false;
                ghost2CanEat = true;
                superMode2 = false;
                ghost2Velocity = 2;
            }

            // If ghost 3 has not been eaten, reset its properties to their default values
            if (!g3Eaten)
            {
                v3 = false;
                ghost3CanEat = true;
                superMode3 = false;
                ghost3Velocity = 2;
            }

            // If ghost 4 has not been eaten, reset its properties to their default values
            if (!g4Eaten)
            {
                v4 = false;
                ghost4CanEat = true;
                superMode4 = false;
                ghost4Velocity = 2;
            }

            // Set the flag that determines whether the power-up has been consumed to false
            superMode = false;

            // Disable the power mode timer and the power mode 1 timer
            powermod.Enabled = false;
            powermod1.Enabled = false;

            // Change the appearance of ghost 1 based on its previous direction of movement
            if (prev1 == 1 && !g1Eaten) { if (ghost1.Left % 2 == 0) leftGhost1 = ghost1Velocity; ghost1.Image = Pacman.Properties.Resources.gray_chicken; }
            if (prev1 == 2 && !g1Eaten) { if (ghost1.Left % 2 == 0) leftGhost1 = -ghost1Velocity; ghost1.Image = Pacman.Properties.Resources.gray_chicken; }
            if (prev1 == 3 && !g1Eaten) { if (ghost1.Top % 2 == 0) topGhost1 = -ghost1Velocity; ghost1.Image = Pacman.Properties.Resources.gray_chicken; }
            if (prev1 == 4 && !g1Eaten) { if (ghost1.Top % 2 == 0) topGhost1 = ghost1Velocity; ghost1.Image = Pacman.Properties.Resources.gray_chicken; }

            // Change the appearance of ghost 2 based on its previous direction of movement
            if (prev2 == 1 && !g2Eaten) { if (ghost2.Left % 2 == 0) leftGhost2 = ghost2Velocity; ghost2.Image = Pacman.Properties.Resources.white_chicken; }
            if (prev2 == 2 && !g2Eaten) { if (ghost2.Left % 2 == 0) leftGhost2 = -ghost2Velocity; ghost2.Image = Pacman.Properties.Resources.white_chicken; }
            if (prev2 == 3 && !g2Eaten) { if (ghost2.Top % 2 == 0) topGhost2 = -ghost2Velocity; ghost2.Image = Pacman.Properties.Resources.white_chicken; }
            if (prev2 == 4 && !g2Eaten) { if (ghost2.Top % 2 == 0) topGhost2 = ghost2Velocity; ghost2.Image = Pacman.Properties.Resources.white_chicken; }

            // Change the appearance of ghost 3 based on its previous direction of movement
            if (prev3 == 1 && !g3Eaten) { if (ghost3.Left % 2 == 0) leftGhost3 = ghost3Velocity; ghost3.Image = Pacman.Properties.Resources.brown_chicken; }
            if (prev3 == 2 && !g3Eaten) { if (ghost3.Left % 2 == 0) leftGhost3 = -ghost3Velocity; ghost3.Image = Pacman.Properties.Resources.brown_chicken; }
            if (prev3 == 3 && !g3Eaten) { if (ghost3.Top % 2 == 0) topGhost3 = -ghost3Velocity; ghost3.Image = Pacman.Properties.Resources.brown_chicken; }
            if (prev3 == 4 && !g3Eaten) { if (ghost3.Top % 2 == 0) topGhost3 = ghost3Velocity; ghost3.Image = Pacman.Properties.Resources.brown_chicken; }

            //Change the appearance of ghost 4 based on its previous direction of movement
            if (prev4 == 1 && !g4Eaten) { if (ghost4.Left % 2 == 0) leftGhost4 = ghost4Velocity; ghost4.Image = Pacman.Properties.Resources.yellow_chicken; }
            if (prev4 == 2 && !g4Eaten) { if (ghost4.Left % 2 == 0) leftGhost4 = -ghost4Velocity; ghost4.Image = Pacman.Properties.Resources.yellow_chicken; }
            if (prev4 == 3 && !g4Eaten) { if (ghost4.Top % 2 == 0) topGhost4 = -ghost4Velocity; ghost4.Image = Pacman.Properties.Resources.yellow_chicken; }
            if (prev4 == 4 && !g4Eaten) { if (ghost4.Top % 2 == 0) topGhost4 = ghost4Velocity; ghost1.Image = Pacman.Properties.Resources.yellow_chicken; }
        }

        // This method is called every time timer8 ticks
        private void timer8_Tick(object sender, EventArgs e)
        {
            // Resetting the pacman and ghost positions and flags
            pacman.SetBounds(pacman.Left, pacman.Top, 0, 0);
            g1Eaten = false;
            g2Eaten = false;
            g3Eaten = false;
            g4Eaten = false;
            v1 = false;
            v2 = false;
            v3 = false;
            v4 = false;
            ghost1CanEat = true;
            ghost2CanEat = true;
            ghost3CanEat = true;
            ghost4CanEat = true;
            ghost1.Visible = false;
            ghost2.Visible = false;
            ghost3.Visible = false;
            ghost4.Visible = false;
            pacman.Visible = false;
            tic4 = 0;
            tic5 = 0;
            tic6 = 0;
            superMode = false;
            superMode1 = false;
            superMode2 = false;
            superMode3 = false;
            superMode4 = false;
            ghost1Velocity = 2;
            ghost2Velocity = 2;
            ghost3Velocity = 2;
            ghost4Velocity = 2;
            // Decrease the number of lives
            lives--;
            // Update the life display
            life();
            prev1 = 0;
            prev2 = 0;
            prev3 = 0;
            prev4 = 0;
            startingDirection = 1;
            dir1 = false;
            dir2 = false;
            dir3 = false;
            dir4 = false;
            c = false;
            next = 0;
            temp = 1;
            direction = 0;
            // Resetting the positions of pacman and the ghosts
            pacman.Left = 24;
            pacman.Top = 364;
            ghost1.Left = 176;
            ghost1.Top = 150;
            ghost2.Left = 154;
            ghost2.Top = 185;
            ghost3.Left = 176;
            ghost3.Top = 185;
            ghost4.Left = 199;
            ghost4.Top = 185;
            leftGhost1 = 0;
            leftGhost2 = 0;
            leftGhost3 = 0;
            leftGhost4 = 0;
            topGhost1 = 0;
            topGhost2 = 0;
            topGhost3 = 0;
            topGhost4 = 0;
            left = 0;
            top = 0;
            // Disable timer8 and enable timer2 and timer3
            timer8.Enabled = false;
            pacman.Image = Pacman.Properties.Resources.normal_doggo;
            ghost1.Image = Pacman.Properties.Resources.gray_chicken;
            ghost2.Image = Pacman.Properties.Resources.white_chicken;
            ghost3.Image = Pacman.Properties.Resources.brown_chicken;
            ghost4.Image = Pacman.Properties.Resources.yellow_chicken;
            ghost1.Visible = true;
            ghost2.Visible = true;
            ghost3.Visible = true;
            ghost4.Visible = true;
            // Set the bounds of pacman and make it visible
            pacman.SetBounds(pacman.Left, pacman.Top, 22, 22);
            pacman.Visible = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            // Set the interval of timer8
            timer8.Interval = 1900;
        }

        // This method is called each time the Timer9's interval elapses
        private void timer9_Tick(object sender, EventArgs e)
        {
            // Show the pictureBox3 and button1 controls
            pictureBox3.Visible = true;
            button1.Visible = true;
            // Disable the Timer9 to prevent it from triggering again
            timer9.Enabled = false;

        }

        private void resetall()
        {
            // Reset eaten status of ghosts
            g1Eaten = false;
            g2Eaten = false;
            g3Eaten = false;
            g4Eaten = false;

            // Reset power-up status of ghosts
            v1 = false;
            v2 = false;
            v3 = false;
            v4 = false;

            // Reset ability of ghosts to be eaten by player
            ghost1CanEat = true;
            ghost2CanEat = true;
            ghost3CanEat = true;
            ghost4CanEat = true;

            // Hide certain labels from the game interface
            label124.Visible = false;
            label141.Visible = false;

            // Reset size and position of player's character
            pacman.SetBounds(pacman.Left, pacman.Top, 22, 22);

            // Reset timer variables for certain game events
            tic4 = 0;
            tic5 = 0;
            tic6 = 0;

            // Reset power-up status for the player's character
            superMode = false;
            superMode1 = false;
            superMode2 = false;
            superMode3 = false;
            superMode4 = false;

            // Reset movement speed of ghosts
            ghost1Velocity = 2;
            ghost2Velocity = 2;
            ghost3Velocity = 2;
            ghost4Velocity = 2;

            // Reset number of lives remaining for player
            life();

            // Reset variables used to track previous directions of ghosts
            prev1 = 0;
            prev2 = 0;
            prev3 = 0;
            prev4 = 0;

            // Reset starting direction for player's character
            startingDirection = 1;

            // Reset variables used to track movement of ghosts
            dir1 = false;
            dir2 = false;
            dir3 = false;
            dir4 = false;
            c = false;
            next = 0;
            temp = 1;
            direction = 0;

            // Reset position of player's character and ghosts on game board
            pacman.Left = 24;
            pacman.Top = 364;
            ghost1.Left = 176;
            ghost1.Top = 150;
            ghost2.Left = 154;
            ghost2.Top = 185;
            ghost3.Left = 176;
            ghost3.Top = 185;
            ghost4.Left = 199;
            ghost4.Top = 185;

            // Reset variables used to track movement of ghosts
            leftGhost1 = 0;
            leftGhost2 = 0;
            leftGhost3 = 0;
            leftGhost4 = 0;
            topGhost1 = 0;
            topGhost2 = 0;
            topGhost3 = 0;
            topGhost4 = 0;
            left = 0;
            top = 0;

            // Reset images for player's character and ghosts
            pacman.Image = Pacman.Properties.Resources.normal_doggo;
            ghost1.Image = Pacman.Properties.Resources.gray_chicken;
            ghost2.Image = Pacman.Properties.Resources.white_chicken;
            ghost3.Image = Pacman.Properties.Resources.brown_chicken;
            ghost4.Image = Pacman.Properties.Resources.yellow_chicken;

            // Stop certain timers from running
            timer1.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            timer7.Enabled = false;
            timer8.Enabled = false;
            powermod.Enabled = false;
            powermod1.Enabled = false;

            // Start certain timers if game has not yet begun
            if (start)
            {
                //If the variable start is true, do the following instructions
                timer2.Enabled = true;
                timer3.Enabled = true;
            }
            //Enable timer2 and timer3
            start = false;
            //Set start to false, indicating that the game has started and this block of code has been executed.
            for (int i = 0; i < 332; i++) ((Label)objects[i]).Visible = true;
        }
        //timer7
        private void timer7_Tick(object sender, EventArgs e)
        {
            // Disable the timer7
            timer7.Enabled = false;
            // Make the panel1 visible
            panel1.Visible = true;
            // Enable another timer named "attendo"
            waiting.Enabled = true;
        }

        //timer "waiting"
        private void waiting_Tick(object sender, EventArgs e)
        {
            resetall();
            waiting.Enabled = false;
        }

        //Initial movement of ghosts
        private void control()
        {
            //If ghost2 reaches a certain position, enable certain timers and set a flag to false
            if (ghost2.Top == 185)
            {
                timer3.Enabled = false;
                timer4.Enabled = true;
                dir2 = false; //set direction flag to false
                timer5.Enabled = true;
            }
        }

        // This function checks the number of lives remaining and updates the visibility of the life icons accordingly.
        private void life()
        {
            if (lives == 3)
            {
                // If there are 3 lives left, show all life icons.
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
            }
            if (lives == 2)
            {
                // If there are 2 lives left, show the first life icon and hide the second one.
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            if (lives == 1)
            {
                // If there is only 1 life left, hide both life icons.
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }
        }
        // Super mode
        // Checks if Pacman intersects with a power-up label and if that label is visible
        // If true, calls the function supermod2() which activates Pacman's super mode
        private void supermod()
        {
            if (pacman.Bounds.IntersectsWith(label173.Bounds) && label173.Visible == true) supermod2();
            if (pacman.Bounds.IntersectsWith(label307.Bounds) && label307.Visible == true) supermod2();
            if (pacman.Bounds.IntersectsWith(label220.Bounds) && label220.Visible == true) supermod2();
            if (pacman.Bounds.IntersectsWith(label71.Bounds) && label71.Visible == true) supermod2();
        }
        //This method is called when Pacman eats a super power-up and all ghosts become edible
        private void supermod2()
        {
            //if ghost 1 has not been eaten yet
            if (!g1Eaten)
            {
                v1 = false; //set ghost 1 velocity to normal
                ghost1Velocity = 2; //set ghost 1 velocity to 2
                superMode1 = true; //set ghost 1 to edible
                ghost1.Image = Pacman.Properties.Resources.GrayChicken; //set ghost 1 image to a gray chicken
                ghost1CanEat = true; //set ghost 1 to able to eat
            }
            //if ghost 2 has not been eaten yet
            if (!g2Eaten)
            {
                v2 = false; //set ghost 2 velocity to normal
                ghost2Velocity = 2; //set ghost 2 velocity to 2
                superMode2 = true; //set ghost 2 to edible
                ghost2.Image = Pacman.Properties.Resources.WhiteChicken; //set ghost 2 image to a white chicken
                ghost2CanEat = true; //set ghost 2 to able to eat
            }
            //if ghost 3 has not been eaten yet
            if (!g3Eaten)
            {
                v3 = false; //set ghost 3 velocity to normal
                ghost3Velocity = 2; //set ghost 3 velocity to 2
                superMode3 = true; //set ghost 3 to edible
                ghost3.Image = Pacman.Properties.Resources.BrownChicken; //set ghost 3 image to a brown chicken
                ghost3CanEat = true; //set ghost 3 to able to eat
            }
            //if ghost 4 has not been eaten yet
            if (!g4Eaten)
            {
                v4 = false; //set ghost 4 velocity to normal
                ghost4Velocity = 2; //set ghost 4 velocity to 2
                superMode4 = true; //set ghost 4 to edible
                ghost4.Image = Pacman.Properties.Resources.YellowChicken; //set ghost 4 image to a yellow chicken
                ghost4CanEat = true; //set ghost 4 to able to eat
            }
            powermod.Enabled = false; //disable power mode timer
            powermod1.Enabled = false; //disable power mode1 timer
            powermod1.Enabled = true; //enable power mode1 timer
            threeSec = false; //set three seconds to false
            powermod.Enabled = true; //enable power mode timer
            superMode = true; //set the game to super mode
        }

        // This method is called every time the powermod1 timer ticks.
        private void powermod1_Tick(object sender, EventArgs e)
        {
            // Set the threeSec variable to true when the timer ticks.
            threeSec = true;
            // Disable the powermod1 timer.
            powermod1.Enabled = false;
        }

        // This function checks for collisions between characters
        private void collision()
        {
            // Check for collision with each ghost
            if (pacman.Bounds.IntersectsWith(ghost1.Bounds) || pacman.Bounds.IntersectsWith(ghost2.Bounds) || pacman.Bounds.IntersectsWith(ghost3.Bounds) || pacman.Bounds.IntersectsWith(ghost4.Bounds))
            {
                // If pacman collides with a ghost while not in super mode, call the "eaten" function
                if (pacman.Bounds.IntersectsWith(ghost1.Bounds) && !superMode1) eaten();
                if (pacman.Bounds.IntersectsWith(ghost2.Bounds) && !superMode2) eaten();
                if (pacman.Bounds.IntersectsWith(ghost3.Bounds) && !superMode3) eaten();
                if (pacman.Bounds.IntersectsWith(ghost4.Bounds) && !superMode4) eaten();
                // If pacman is in super mode and collides with a ghost, call the "eaten" function
                if (superMode)
                {
                    if (pacman.Bounds.IntersectsWith(ghost1.Bounds) && !superMode1) eaten();
                    if (pacman.Bounds.IntersectsWith(ghost2.Bounds) && !superMode2) eaten();
                    if (pacman.Bounds.IntersectsWith(ghost3.Bounds) && !superMode3) eaten();
                    if (pacman.Bounds.IntersectsWith(ghost4.Bounds) && !superMode4) eaten();
                }

                // If pacman collides with a ghost while the ghost is edible and pacman is in super mode, set the ghost to be eaten and change its properties
                // If Pacman is in super mode, handle the case of Pacman eating a ghost.
                if (superMode)
                {
                    if (pacman.Bounds.IntersectsWith(ghost1.Bounds) && !superMode1)
                        eaten();
                    if (pacman.Bounds.IntersectsWith(ghost2.Bounds) && !superMode2)
                        eaten();
                    if (pacman.Bounds.IntersectsWith(ghost3.Bounds) && !superMode3)
                        eaten();
                    if (pacman.Bounds.IntersectsWith(ghost4.Bounds) && !superMode4)
                        eaten();
                }

                // Handle the special case of Pacman eating ghost1 while it is vulnerable.
                if (pacman.Bounds.IntersectsWith(ghost1.Bounds) && ghost1CanEat && superMode1)
                {
                    g1Eaten = true;
                    v1 = true;
                    ghost1CanEat = false;
                    timer1.Enabled = false;
                    ghostEaten.Enabled = true;
                    ghost1Velocity = 4;
                }

                // Handle the special case of Pacman eating ghost2 while it is vulnerable.
                if (pacman.Bounds.IntersectsWith(ghost2.Bounds) && ghost2CanEat && superMode2)
                {
                    g2Eaten = true;
                    v2 = true;
                    ghost2CanEat = false;
                    timer1.Enabled = false;
                    ghostEaten.Enabled = true;
                    ghost2Velocity = 4;
                }

                // Handle the special case of Pacman eating ghost3 while it is vulnerable.
                if (pacman.Bounds.IntersectsWith(ghost3.Bounds) && ghost3CanEat && superMode3)
                {
                    g3Eaten = true;
                    v3 = true;
                    ghost3CanEat = false;
                    timer1.Enabled = false;
                    ghostEaten.Enabled = true;
                    ghost3Velocity = 4;
                }

                // Handle the special case of Pacman eating ghost4 while it is vulnerable.
                if (pacman.Bounds.IntersectsWith(ghost4.Bounds) && ghost4CanEat && superMode4)
                {
                    g4Eaten = true;
                    v4 = true;
                    ghost4CanEat = false;
                    timer1.Enabled = false;
                    ghostEaten.Enabled = true;
                    ghost4Velocity = 4;
                }
            }

        }

        // This method is called when the ghostEaten timer ticks
        private void ghostEaten_Tick(object sender, EventArgs e)
        {
            // Re-enable the timer1 that controls the ghost's movement
            timer1.Enabled = true;
            // Disable the ghostEaten timer since it has completed its task
            ghostEaten.Enabled = false;
        }

        // This method is called when pacman is eaten.
        private void eaten()
        {
            // Change pacman's image to a normal doggo image.
            pacman.Image = Pacman.Properties.Resources.normal_doggo;
            // Check if there are no remaining lives.
            if (lives - 1 <= 0)
            {
                // Show the game over label and end the game.
                label124.Visible = true;
                gameOver();
            }
            else
            {
                // Reset the positions of pacman and the ghosts.
                top = 0;
                left = 0;
                topGhost1 = 0;
                topGhost2 = 0;
                topGhost3 = 0;
                topGhost4 = 0;
                leftGhost1 = 0;
                leftGhost2 = 0;
                leftGhost3 = 0;
                leftGhost4 = 0;

                // Disable timers and reset the turns for pacman and ghosts.
                timer1.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                timer6.Enabled = false;
                pacTurn = false;
                ghost1Turn = false;
                ghost2Turn = false;
                ghost3Turn = false;
                ghost4Turn = false;

                // Enable a timer to delay before restarting the game.
                timer8.Enabled = true;
            }
        }

        // Method to update the points collected by Pacman
        private void points()
        {
            // Iterate through all the labels representing points in the game
            for (int i = 0; i < 332; i++)
            {
                // Check if the current point label is visible and intersects with Pacman's bounds
                if (((Label)objects[i]).Visible == true && pacman.Bounds.IntersectsWith(((Label)objects[i]).Bounds))
                {
                    // Increment the point counter and make the label invisible
                    point += 1;
                    ((Label)objects[i]).Visible = false;
                }
            }
            // Update the score display with the current point total
            score.Text = point.ToString();
            // If Pacman has collected all the points in the game, display the victory message and end the game
            if (point >= 332)
            {
                gameOver();
                label141.Visible = true;
            }
        }

        //game over
        private void gameOver()
        {
            // Reset the points to zero
            point = 0;
            // Reset the lives to 3
            lives = 3;
            // Disable timer1, which controls the movement of pacman and the ghosts
            timer1.Enabled = false;
            // Disable timer2, which controls the movement of ghost1
            timer2.Enabled = false;
            // Disable timer3, which controls the movement of ghost2
            timer3.Enabled = false;
            // Disable timer4, which controls the movement of ghost3
            timer4.Enabled = false;
            // Disable timer5, which controls the movement of ghost4
            timer5.Enabled = false;
            // Disable timer6, which controls the movement of ghosts during the "super mode"
            timer6.Enabled = false;
            // Disable powermod1, which controls the duration of the "super mode"
            powermod1.Enabled = false;
            // Disable powermod, which controls the duration of the "super mode" for ghost1
            powermod.Enabled = false;
            // Enable timer7, which displays the "game over" message and resets the game
            timer7.Enabled = true;
        }

        //cambio direction di pacman
        private void freeDirection()
        {
            // switch statement that checks the current value of the variable "direction"
            switch (direction)
            {
                // if direction is 1:
                case 1:
                    // and the next direction is 2:
                    if (next == 2)
                    {
                        // set the left movement to 2
                        left = 2;
                        // change the image of the pacman to normal_doggo
                        pacman.Image = Pacman.Properties.Resources.normal_doggo;
                        // set the direction to the next direction
                        direction = next;
                        // set the temp to the next direction
                        temp = next;
                    }
                    // break out of the switch statement
                    break;

                // if direction is 2:
                case 2:
                    // and the next direction is 1:
                    if (next == 1)
                    {
                        // set the left movement to -2
                        left = -2;
                        // change the image of the pacman to normal_doggo
                        pacman.Image = Pacman.Properties.Resources.normal_doggo;
                        // set the direction to the next direction
                        direction = next;
                        // set the temp to the next direction
                        temp = next;
                    }
                    // break out of the switch statement
                    break;

                // if direction is 3:
                case 3:
                    // and the next direction is 4:
                    if (next == 4)
                    {
                        // set the top movement to 2
                        top = 2;
                        // change the image of the pacman to normal_doggo
                        pacman.Image = Pacman.Properties.Resources.normal_doggo;
                        // set the direction to the next direction
                        direction = next;
                        // set the temp to the next direction
                        temp = next;
                    }
                    // break out of the switch statement
                    break;

                // if direction is 4:
                case 4:
                    // and the next direction is 3:
                    if (next == 3)
                    {
                        // set the top movement to -2
                        top = -2;
                        // change the image of the pacman to normal_doggo
                        pacman.Image = Pacman.Properties.Resources.normal_doggo;
                        // set the direction to the next direction
                        direction = next;
                        // set the temp to the next direction
                        temp = next;
                    }
                    // break out of the switch statement
                    break;
            }

        }

        private void leftright(int i, int y, int n, int m)
        {
            //turn the ghost1
            if (ghost1Turn)
            {
                // If the superMode1 flag is true and the ghost1CanEat flag is false
                if (superMode1 && !ghost1CanEat)
                {
                    // Check if the ghost1 is within a certain range of coordinates
                    if (ghost1.Left < 180 && ghost1.Top == 150 || ghost1.Left > 170 && ghost1.Top == 150)
                    {
                        // If so, update some flags and velocity values
                        ghost1Velocity = 2;
                        superMode1 = false;
                        v1 = false;
                        ghost1CanEat = true;
                        g1Eaten = false;
                    }
                    else
                    {
                        // Otherwise, update some flags based on the current position of ghost1
                        if (ghost1.Top < 150) { if (n == 1 && m == 1) n = 0; }
                        if (ghost1.Top > 150) { if (n == 1 && m == 1) m = 0; }
                        if (ghost1.Left < 176) { if (i == 1 && y == 1) i = 0; }
                        if (ghost1.Left > 176) { if (i == 1 && y == 1) y = 0; }
                    }
                }

                // Reset the topGhost1 and leftGhost1 variables
                topGhost1 = 0;
                leftGhost1 = 0;

                // Loop until dir1 flag is set to true
                while (!dir1)
                {
                    // Generate a random number between 1 and 4
                    random1 = rand.Next(1, 5);

                    // Check the value of the random number and update variables accordingly
                    // Also update the ghost1 Image based on various conditions
                    if (random1 == 1 && !dir1 && random1 != prev1) // If random1 is 1 and dir1 is false and random1 is not equal to prev1
                        if (i == 1) // If i is 1
                        {
                            leftGhost1 = -ghost1Velocity; // Move ghost1 to the left
                            dir1 = true; // Set dir1 flag to true
                            if (!superMode1 && ghost1CanEat) ghost1.Image = Pacman.Properties.Resources.gray_chicken;
                            else if (!threeSec || g1Eaten)
                            {
                                if (!threeSec) ghost1.Image = Pacman.Properties.Resources.GrayChicken;
                                if (g1Eaten) ghost1.Image = Pacman.Properties.Resources.Egg__2_;
                            }
                            else ghost1.Image = Pacman.Properties.Resources.gray_chicken;
                        }

                    // Repeat the above for the other possible values of random1
                    if (random1 == 2 && !dir1 && random1 != prev1)
                        if (y == 1)
                        {
                            leftGhost1 = ghost1Velocity;
                            dir1 = true;
                            if (!superMode1 && ghost1CanEat) ghost1.Image = Pacman.Properties.Resources.gray_chicken;
                            else if (!threeSec || g1Eaten)
                            {
                                if (!threeSec) ghost1.Image = Pacman.Properties.Resources.GrayChicken;
                                if (g1Eaten) ghost1.Image = Pacman.Properties.Resources.Egg__2_;
                            }
                            else ghost1.Image = Pacman.Properties.Resources.gray_chicken;
                        }

                    if (random1 == 3 && !dir1 && random1 != prev1)
                        if (m == 1)
                        {
                            topGhost1 = ghost1Velocity;
                            dir1 = true;
                            if (!superMode1 && ghost1CanEat) ghost1.Image = Pacman.Properties.Resources.gray_chicken;
                            else if (!threeSec || g1Eaten)
                            {
                                if (!threeSec) ghost1.Image = Pacman.Properties.Resources.GrayChicken;
                                if (g1Eaten) ghost1.Image = Pacman.Properties.Resources.Egg__2_;
                            }
                            else ghost1.Image = Pacman.Properties.Resources.gray_chicken;
                        }

                    if (random1 == 4 && !dir1 && random1 != prev1)
                        if (n == 1)
                        {
                            topGhost1 = -ghost1Velocity;
                            dir1 = true;
                            if (!superMode1 && ghost1CanEat) ghost1.Image = Pacman.Properties.Resources.gray_chicken;
                            else if (!threeSec || g1Eaten)
                            {
                                if (!threeSec) ghost1.Image = Pacman.Properties.Resources.GrayChicken;
                                if (g1Eaten) ghost1.Image = Pacman.Properties.Resources.Egg__2_;
                            }
                            else ghost1.Image = Pacman.Properties.Resources.gray_chicken;
                        }
                }

                // Set the previous direction for ghost1 based on the random value generated in the previous loop.
                if (random1 == 1) prev1 = 2; // If random1 is 1, set prev1 to 2 (which represents moving right)
                if (random1 == 2) prev1 = 1; // If random1 is 2, set prev1 to 1 (which represents moving left)
                if (random1 == 3) prev1 = 4; // If random1 is 3, set prev1 to 4 (which represents moving down)
                if (random1 == 4) prev1 = 3; // If random1 is 4, set prev1 to 3 (which represents moving up)

                // Reset the direction flag so that the loop can continue and a new direction can be generated.
                dir1 = false;
            }

            //turn the ghost2
            if (ghost2Turn)
            {
                if (superMode2 && !ghost2CanEat)
                {
                    if (ghost2.Left < 180 && ghost2.Top == 150 || ghost2.Left > 170 && ghost2.Top == 150) { ghost2Velocity = 2; superMode2 = false; v2 = false; ghost2CanEat = true; g2Eaten = false; }
                    else
                    {
                        if (ghost2.Top < 150) { if (n == 1 && m == 1) n = 0; }
                        if (ghost2.Top > 150) { if (n == 1 && m == 1) m = 0; }
                        if (ghost2.Left < 176) { if (i == 1 && y == 1) i = 0; }
                        if (ghost2.Left > 176) { if (i == 1 && y == 1) y = 0; }
                    }
                }
                topGhost2 = 0;
                leftGhost2 = 0;
                while (!dir2)
                {
                    random2 = rand.Next(1, 5);
                    if (random2 == 1 && !dir2 && random2 != prev2) if (i == 1) { leftGhost2 = -ghost2Velocity; dir2 = true; if (!superMode2 && ghost2CanEat) ghost2.Image = Pacman.Properties.Resources.white_chicken; else if (!threeSec || g2Eaten) { if (!threeSec) ghost2.Image = Pacman.Properties.Resources.WhiteChicken; if (g2Eaten) ghost2.Image = Pacman.Properties.Resources.Egg__2_; } else ghost2.Image = Pacman.Properties.Resources.white_chicken; }
                    if (random2 == 2 && !dir2 && random2 != prev2) if (y == 1) { leftGhost2 = ghost2Velocity; dir2 = true; if (!superMode2 && ghost2CanEat) ghost2.Image = Pacman.Properties.Resources.white_chicken; else if (!threeSec || g2Eaten) { if (!threeSec) ghost2.Image = Pacman.Properties.Resources.WhiteChicken; if (g2Eaten) ghost2.Image = Pacman.Properties.Resources.Egg__2_; } else ghost2.Image = Pacman.Properties.Resources.white_chicken; }
                    if (random2 == 3 && !dir2 && random2 != prev2) if (m == 1) { topGhost2 = ghost2Velocity; dir2 = true; if (!superMode2 && ghost2CanEat) ghost2.Image = Pacman.Properties.Resources.white_chicken; else if (!threeSec || g2Eaten) { if (!threeSec) ghost2.Image = Pacman.Properties.Resources.WhiteChicken; if (g2Eaten) ghost2.Image = Pacman.Properties.Resources.Egg__2_; } else ghost2.Image = Pacman.Properties.Resources.white_chicken; }
                    if (random2 == 4 && !dir2 && random2 != prev2) if (n == 1) { topGhost2 = -ghost2Velocity; dir2 = true; if (!superMode2 && ghost2CanEat) ghost2.Image = Pacman.Properties.Resources.white_chicken; else if (!threeSec || g2Eaten) { if (!threeSec) ghost2.Image = Pacman.Properties.Resources.WhiteChicken; if (g2Eaten) ghost2.Image = Pacman.Properties.Resources.Egg__2_; } else ghost2.Image = Pacman.Properties.Resources.white_chicken; }
                }
                if (random2 == 1) prev2 = 2;
                if (random2 == 2) prev2 = 1;
                if (random2 == 3) prev2 = 4;
                if (random2 == 4) prev2 = 3;
                dir2 = false;
            }
            //turn the ghost3
            if (ghost3Turn)
            {
                if (superMode3 && !ghost3CanEat)
                {
                    if (ghost3.Left < 180 && ghost3.Top == 150 || ghost3.Left > 170 && ghost3.Top == 150) { ghost3Velocity = 2; superMode3 = false; v3 = false; ghost3CanEat = true; g3Eaten = false; }
                    else
                    {
                        if (ghost3.Top > 150) { if (n == 1 && m == 1) m = 0; }
                        if (ghost3.Top < 150) { if (n == 1 && m == 1) n = 0; }
                        if (ghost3.Left < 176) { if (i == 1 && y == 1) i = 0; }
                        if (ghost3.Left > 176) { if (i == 1 && y == 1) y = 0; }
                    }
                }
                topGhost3 = 0;
                leftGhost3 = 0;
                while (!dir3)
                {
                    random3 = rand.Next(1, 5);
                    if (random3 == 1 && !dir3 && random3 != prev3) if (i == 1) { leftGhost3 = -ghost3Velocity; dir3 = true; if (!superMode3 && ghost3CanEat) ghost3.Image = Pacman.Properties.Resources.brown_chicken; else if (!threeSec || g3Eaten) { if (!threeSec) ghost3.Image = Pacman.Properties.Resources.BrownChicken; if (g3Eaten) ghost3.Image = Pacman.Properties.Resources.Egg__2_; } else ghost3.Image = Pacman.Properties.Resources.brown_chicken; }
                    if (random3 == 2 && !dir3 && random3 != prev3) if (y == 1) { leftGhost3 = ghost3Velocity; dir3 = true; if (!superMode3 && ghost3CanEat) ghost3.Image = Pacman.Properties.Resources.brown_chicken; else if (!threeSec || g3Eaten) { if (!threeSec) ghost3.Image = Pacman.Properties.Resources.BrownChicken; if (g3Eaten) ghost3.Image = Pacman.Properties.Resources.Egg__2_; } else ghost3.Image = Pacman.Properties.Resources.brown_chicken; }
                    if (random3 == 3 && !dir3 && random3 != prev3) if (m == 1) { topGhost3 = ghost3Velocity; dir3 = true; if (!superMode3 && ghost3CanEat) ghost3.Image = Pacman.Properties.Resources.brown_chicken; else if (!threeSec || g3Eaten) { if (!threeSec) ghost3.Image = Pacman.Properties.Resources.BrownChicken; if (g3Eaten) ghost3.Image = Pacman.Properties.Resources.Egg__2_; } else ghost3.Image = Pacman.Properties.Resources.brown_chicken; }
                    if (random3 == 4 && !dir3 && random3 != prev3) if (n == 1) { topGhost3 = -ghost3Velocity; dir3 = true; if (!superMode3 && ghost3CanEat) ghost3.Image = Pacman.Properties.Resources.brown_chicken; else if (!threeSec || g3Eaten) { if (!threeSec) ghost3.Image = Pacman.Properties.Resources.BrownChicken; if (g3Eaten) ghost3.Image = Pacman.Properties.Resources.Egg__2_; } else ghost3.Image = Pacman.Properties.Resources.brown_chicken; }
                }
                if (random3 == 1) prev3 = 2;
                if (random3 == 2) prev3 = 1;
                if (random3 == 3) prev3 = 4;
                if (random3 == 4) prev3 = 3;
                dir3 = false;
            }
            //turn the ghost4
            if (ghost4Turn)
            {
                if (superMode4 && !ghost4CanEat)
                {
                    if (ghost4.Left < 180 && ghost4.Top == 150 || ghost4.Left > 170 && ghost4.Top == 150) { ghost4Velocity = 2; superMode4 = false; v4 = false; ghost4CanEat = true; g4Eaten = false; }
                    else
                    {
                        if (ghost4.Top > 150) { if (n == 1 && m == 1) m = 0; }
                        if (ghost4.Top < 150) { if (n == 1 && m == 1) n = 0; }
                        if (ghost4.Left < 176) { if (i == 1 && y == 1) i = 0; }
                        if (ghost4.Left > 176) { if (i == 1 && y == 1) y = 0; }
                    }
                }
                topGhost4 = 0;
                leftGhost4 = 0;
                while (!dir4)
                {
                    random4 = rand.Next(1, 5);
                    if (random4 == 1 && !dir4 && random4 != prev4) if (i == 1) { leftGhost4 = -ghost4Velocity; dir4 = true; if (!superMode4 && ghost4CanEat) ghost4.Image = Pacman.Properties.Resources.yellow_chicken; else if (!threeSec || g4Eaten) { if (!threeSec) ghost4.Image = Pacman.Properties.Resources.YellowChicken; if (g4Eaten) ghost4.Image = Pacman.Properties.Resources.Egg__2_; } else ghost4.Image = Pacman.Properties.Resources.yellow_chicken; }
                    if (random4 == 2 && !dir4 && random4 != prev4) if (y == 1) { leftGhost4 = ghost4Velocity; dir4 = true; if (!superMode4 && ghost4CanEat) ghost4.Image = Pacman.Properties.Resources.yellow_chicken; else if (!threeSec || g4Eaten) { if (!threeSec) ghost4.Image = Pacman.Properties.Resources.YellowChicken; if (g4Eaten) ghost4.Image = Pacman.Properties.Resources.Egg__2_; } else ghost4.Image = Pacman.Properties.Resources.yellow_chicken; }
                    if (random4 == 3 && !dir4 && random4 != prev4) if (m == 1) { topGhost4 = ghost4Velocity; dir4 = true; if (!superMode4 && ghost4CanEat) ghost4.Image = Pacman.Properties.Resources.yellow_chicken; else if (!threeSec || g4Eaten) { if (!threeSec) ghost4.Image = Pacman.Properties.Resources.YellowChicken; if (g4Eaten) ghost4.Image = Pacman.Properties.Resources.Egg__2_; } else ghost4.Image = Pacman.Properties.Resources.yellow_chicken; }
                    if (random4 == 4 && !dir4 && random4 != prev4) if (n == 1) { topGhost4 = -ghost4Velocity; dir4 = true; if (!superMode4 && ghost4CanEat) ghost4.Image = Pacman.Properties.Resources.yellow_chicken; else if (!threeSec || g4Eaten) { if (!threeSec) ghost4.Image = Pacman.Properties.Resources.YellowChicken; if (g4Eaten) ghost4.Image = Pacman.Properties.Resources.Egg__2_; } else ghost4.Image = Pacman.Properties.Resources.yellow_chicken; }
                }
                if (random4 == 1) prev4 = 2;
                if (random4 == 2) prev4 = 1;
                if (random4 == 3) prev4 = 4;
                if (random4 == 4) prev4 = 3;
                dir4 = false;
            }
            //turn the pacman
            // This code is executed when it is Pac-Man's turn to move
            if (pacTurn)
            {
                // Reset the top and left movement to 0
                top = 0;
                left = 0;

                // If Pac-Man's next direction is possible, set it
                if (temp == 1 && i == 1 || temp == 2 && y == 1 || temp == 3 && n == 1 || temp == 4 && m == 1)
                {
                    next = temp;
                }

                // If Pac-Man's next direction is to move left and it's possible, set the movement and the image
                if (next == 1 && i == 1)
                {
                    left = -2;
                    pacman.Image = Pacman.Properties.Resources.normal_doggo;
                    direction = next;
                }

                // If Pac-Man's next direction is to move right and it's possible, set the movement and the image
                if (next == 2 && y == 1)
                {
                    left = 2;
                    pacman.Image = Pacman.Properties.Resources.normal_doggo;
                    direction = next;
                }

                // If Pac-Man's next direction is to move up and it's possible, set the movement and the image
                if (next == 3 && n == 1)
                {
                    top = -2;
                    pacman.Image = Pacman.Properties.Resources.normal_doggo;
                    direction = next;
                }

                // If Pac-Man's next direction is to move down and it's possible, set the movement and the image
                if (next == 4 && m == 1)
                {
                    top = 2;
                    pacman.Image = Pacman.Properties.Resources.normal_doggo;
                    direction = next;
                }

                // If Pac-Man is not moving in any direction, update his next and current directions and his image
                if (top == 0 && left == 0)
                {
                    temp = next;
                    next = direction;
                    if (next == 1) pacman.Image = Pacman.Properties.Resources.normal_doggo;
                    if (next == 2) pacman.Image = Pacman.Properties.Resources.normal_doggo;
                    if (next == 3) pacman.Image = Pacman.Properties.Resources.normal_doggo;
                    if (next == 4) pacman.Image = Pacman.Properties.Resources.normal_doggo;
                }
            }
        }

        // This function handles the actual change in direction of Pacman
        private void Direction()
        {
            pacTurn = true; // set the pacTurn flag to true, indicating that Pacman is turning
            a(pacman.Left, pacman.Top); // call the function a with the current position of Pacman
            pacman.Left += left; // adjust Pacman's left position based on the current direction
            pacman.Top += top; // adjust Pacman's top position based on the current direction
        }

        // This method takes in the left and top coordinates of Pac-Man's position on the game map
        private void a(int left, int top)
        {
            // If it is Pac-Man's turn to move
            if (pacTurn)
            {
                // Check the left coordinate of Pac-Man's position
                switch (left)
                {
                    case 174:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                        if (top == 148) { leftright(1, 1, 0, 0); break; }
                        break;
                    case 24:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                        if (top == 364) { leftright(0, 1, 1, 0); break; }
                        if (top == 328) { leftright(0, 1, 0, 1); break; }
                        if (top == 292) { leftright(0, 1, 1, 0); break; }
                        if (top == 256) { leftright(0, 1, 0, 1); break; }
                        if (top == 112) { leftright(0, 1, 1, 0); break; }
                        if (top == 76) { leftright(0, 1, 1, 1); break; }
                        if (top == 28) { leftright(0, 1, 0, 1); break; }
                        break;
                    case 48:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                        if (top == 328) { leftright(1, 1, 1, 0); break; }
                        if (top == 292) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 84:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                        if (top == 256) { leftright(1, 1, 1, 1); break; }
                        if (top == 328) { leftright(1, 0, 1, 0); break; }
                        if (top == 292) { leftright(0, 1, 1, 1); break; }
                        if (top == 184) { leftright(1, 1, 1, 1); break; }
                        if (top == 112) { leftright(1, 0, 1, 1); break; }
                        if (top == 28) { leftright(1, 1, 0, 1); break; }
                        if (top == 76) { leftright(1, 1, 1, 1); break; }
                        break;
                    case 120:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() 
                        if (top == 292) { leftright(1, 1, 0, 1); break; }
                        if (top == 328) { leftright(0, 1, 1, 0); break; }
                        if (top == 256) { leftright(1, 1, 1, 0); break; }
                        if (top == 220) { leftright(0, 1, 1, 1); break; }
                        if (top == 76) { leftright(1, 1, 0, 1); break; }
                        if (top == 112) { leftright(0, 1, 1, 0); break; }
                        if (top == 148) { leftright(0, 1, 0, 1); break; }
                        if (top == 184) { leftright(1, 0, 1, 1); break; }
                        break;
                    case 156:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                        if (top == 328) { leftright(1, 0, 0, 1); break; }
                        if (top == 364) { leftright(1, 1, 1, 0); break; }
                        if (top == 256) { leftright(1, 0, 0, 1); break; }
                        if (top == 292) { leftright(1, 1, 1, 0); break; }
                        if (top == 76) { leftright(1, 1, 1, 0); break; }
                        if (top == 112) { leftright(1, 0, 0, 1); break; }
                        if (top == 148) { leftright(1, 1, 1, 0); break; }
                        if (top == 28) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 192:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                        if (top == 292) { leftright(1, 1, 1, 0); break; }
                        if (top == 256) { leftright(0, 1, 0, 1); break; }
                        if (top == 364) { leftright(1, 1, 1, 0); break; }
                        if (top == 328) { leftright(0, 1, 0, 1); break; }
                        if (top == 28) { leftright(0, 1, 0, 1); break; }
                        if (top == 76) { leftright(1, 1, 1, 0); break; }
                        if (top == 112) { leftright(0, 1, 0, 1); break; }
                        if (top == 148) { leftright(1, 1, 1, 0); break; }
                        break;
                    case 228:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                        if (top == 256) { leftright(1, 1, 1, 0); break; }
                        if (top == 328) { leftright(1, 0, 1, 0); break; }
                        if (top == 292) { leftright(1, 1, 0, 1); break; }
                        if (top == 220) { leftright(1, 0, 1, 1); break; }
                        if (top == 184) { leftright(0, 1, 1, 1); break; }
                        if (top == 76) { leftright(1, 1, 0, 1); break; }
                        if (top == 112) { leftright(1, 0, 1, 0); break; }
                        if (top == 148) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 264:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                        if (top == 256) { leftright(1, 1, 1, 1); break; }
                        if (top == 292) { leftright(1, 0, 1, 1); break; }
                        if (top == 328) { leftright(0, 1, 1, 0); break; }
                        if (top == 184) { leftright(1, 1, 1, 1); break; }
                        if (top == 112) { leftright(0, 1, 1, 1); break; }
                        if (top == 28) { leftright(1, 1, 0, 1); break; }
                        if (top == 76) { leftright(1, 1, 1, 1); break; }
                        break;
                    case 324:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                        if (top == 256) { leftright(1, 0, 0, 1); break; }
                        if (top == 292) { leftright(1, 0, 1, 0); break; }
                        if (top == 328) { leftright(1, 0, 0, 1); break; }
                        if (top == 364) { leftright(1, 0, 1, 0); break; }
                        if (top == 112) { leftright(1, 0, 1, 0); break; }
                        if (top == 76) { leftright(1, 0, 1, 1); break; }
                        if (top == 28) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 300:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                        if (top == 292) { leftright(0, 1, 0, 1); break; }
                        if (top == 328) { leftright(1, 1, 1, 0); break; }
                        break;
                    case 374:
                        // If Pac-Man is at a certain intersection, set his movement direction using the transport() method
                        if (top == 184) { transport(0, 1); break; }
                        break;
                    case -26:
                        // If Pac-Man is at a certain intersection, set his movement direction using the transport() method
                        if (top == 184) { transport(1, 0); break; }
                        break;
                }
            }
            else
            {
                switch (left)
                {
                    // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                    case 176:
                        if (top == 150) { leftright(1, 1, 0, 0); break; }
                        break;
                    case 26:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                        if (top == 366) { leftright(0, 1, 1, 0); break; }
                        if (top == 330) { leftright(0, 1, 0, 1); break; }
                        if (top == 294) { leftright(0, 1, 1, 0); break; }
                        if (top == 258) { leftright(0, 1, 0, 1); break; }
                        if (top == 114) { leftright(0, 1, 1, 0); break; }
                        if (top == 78) { leftright(0, 1, 1, 1); break; }
                        if (top == 30) { leftright(0, 1, 0, 1); break; }
                        break;
                    case 50:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                        if (top == 330) { leftright(1, 1, 1, 0); break; }
                        if (top == 294) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 86:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                        if (top == 258) { leftright(1, 1, 1, 1); break; }
                        if (top == 330) { leftright(1, 0, 1, 0); break; }
                        if (top == 294) { leftright(0, 1, 1, 1); break; }
                        if (top == 186) { leftright(1, 1, 1, 1); break; }
                        if (top == 114) { leftright(1, 0, 1, 1); break; }
                        if (top == 30) { leftright(1, 1, 0, 1); break; }
                        if (top == 78) { leftright(1, 1, 1, 1); break; }
                        break;
                    case 122:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                        if (top == 294) { leftright(1, 1, 0, 1); break; }
                        if (top == 330) { leftright(0, 1, 1, 0); break; }
                        if (top == 258) { leftright(1, 1, 1, 0); break; }
                        if (top == 222) { leftright(0, 1, 1, 1); break; }
                        if (top == 78) { leftright(1, 1, 0, 1); break; }
                        if (top == 114) { leftright(0, 1, 1, 0); break; }
                        if (top == 150) { leftright(0, 1, 0, 1); break; }
                        if (top == 186) { leftright(1, 0, 1, 1); break; }
                        break;
                    case 158:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                        if (top == 330) { leftright(1, 0, 0, 1); break; }
                        if (top == 366) { leftright(1, 1, 1, 0); break; }
                        if (top == 258) { leftright(1, 0, 0, 1); break; }
                        if (top == 294) { leftright(1, 1, 1, 0); break; }
                        if (top == 78) { leftright(1, 1, 1, 0); break; }
                        if (top == 114) { leftright(1, 0, 0, 1); break; }
                        if (top == 150) { leftright(1, 1, 1, 0); break; }
                        if (top == 30) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 194:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                        if (top == 294) { leftright(1, 1, 1, 0); break; }
                        if (top == 258) { leftright(0, 1, 0, 1); break; }
                        if (top == 366) { leftright(1, 1, 1, 0); break; }
                        if (top == 330) { leftright(0, 1, 0, 1); break; }
                        if (top == 30) { leftright(0, 1, 0, 1); break; }
                        if (top == 78) { leftright(1, 1, 1, 0); break; }
                        if (top == 114) { leftright(0, 1, 0, 1); break; }
                        if (top == 150) { leftright(1, 1, 1, 0); break; }
                        break;
                    case 230:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                        if (top == 258) { leftright(1, 1, 1, 0); break; }
                        if (top == 330) { leftright(1, 0, 1, 0); break; }
                        if (top == 294) { leftright(1, 1, 0, 1); break; }
                        if (top == 222) { leftright(1, 0, 1, 1); break; }
                        if (top == 186) { leftright(0, 1, 1, 1); break; }
                        if (top == 78) { leftright(1, 1, 0, 1); break; }
                        if (top == 114) { leftright(1, 0, 1, 0); break; }
                        if (top == 150) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 266:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                        if (top == 258) { leftright(1, 1, 1, 1); break; }
                        if (top == 294) { leftright(1, 0, 1, 1); break; }
                        if (top == 330) { leftright(0, 1, 1, 0); break; }
                        if (top == 186) { leftright(1, 1, 1, 1); break; }
                        if (top == 114) { leftright(0, 1, 1, 1); break; }
                        if (top == 30) { leftright(1, 1, 0, 1); break; }
                        if (top == 78) { leftright(1, 1, 1, 1); break; }
                        break;
                    case 326:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                        if (top == 258) { leftright(1, 0, 0, 1); break; }
                        if (top == 294) { leftright(1, 0, 1, 0); break; }
                        if (top == 330) { leftright(1, 0, 0, 1); break; }
                        if (top == 366) { leftright(1, 0, 1, 0); break; }
                        if (top == 114) { leftright(1, 0, 1, 0); break; }
                        if (top == 78) { leftright(1, 0, 1, 1); break; }
                        if (top == 30) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 302:
                        // If Pac-Man is at a certain intersection, set his movement direction using the leftright() method
                        if (top == 294) { leftright(0, 1, 0, 1); break; }
                        if (top == 330) { leftright(1, 1, 1, 0); break; }
                        break;
                    case 376:
                        // If Pac-Man is at a certain intersection, set his movement direction using the transport() method
                        if (top == 186) { transport(0, 1); break; }
                        break;
                    case -28:
                        // If Pac-Man is at a certain intersection, set his movement direction using the transport() method
                        if (top == 186) { transport(1, 0); break; }
                        break;
                }
            }
            pacTurn = false;
            ghost1Turn = false;
            ghost2Turn = false;
            ghost3Turn = false;
            ghost4Turn = false;
        }

        // This method is used to transport the characters.
        private void transport(int i, int n)
        {
            // Check if it's Pacman's turn.
            if (pacTurn)
            {
                // If Pacman reaches the left end of the screen, transport him to the right end.
                if (i == 0)
                    pacman.Left = -26;
                // If Pacman reaches the right end of the screen, transport him to the left end.
                if (n == 0)
                    pacman.Left = 374;
            }
            // Check if it's Ghost 1's turn.
            if (ghost1Turn)
            {
                // If Ghost 1 reaches the left end of the screen, transport him to the right end.
                if (i == 0)
                    ghost1.Left = -26;
                // If Ghost 1 reaches the right end of the screen, transport him to the left end.
                if (n == 0)
                    ghost1.Left = 374;
            }
            // Check if it's Ghost 2's turn.
            if (ghost2Turn)
            {
                // If Ghost 2 reaches the left end of the screen, transport him to the right end.
                if (i == 0)
                    ghost2.Left = -26;
                // If Ghost 2 reaches the right end of the screen, transport him to the left end.
                if (n == 0)
                    ghost2.Left = 374;
            }
            // Check if it's Ghost 3's turn.
            if (ghost3Turn)
            {
                // If Ghost 3 reaches the left end of the screen, transport him to the right end.
                if (i == 0)
                    ghost3.Left = -26;
                // If Ghost 3 reaches the right end of the screen, transport him to the left end.
                if (n == 0)
                    ghost3.Left = 374;
            }
            // Check if it's Ghost 4's turn.
            if (ghost4Turn)
            {
                // If Ghost 4 reaches the left end of the screen, transport him to the right end.
                if (i == 0)
                    ghost4.Left = -26;
                // If Ghost 4 reaches the right end of the screen, transport him to the left end.
                if (n == 0)
                    ghost4.Left = 374;
            }
        }

        // This method updates the position of each ghost based on their current position and direction
        private void ghost()
        {
            // Update the position of ghost1 if it is enabled
            if (ghost1.Enabled == true)
            {
                ghost1.Left += leftGhost1; // Move ghost1 left or right based on the value of leftGhost1
                ghost1.Top += topGhost1; // Move ghost1 up or down based on the value of topGhost1
                ghost1Turn = true; // Set ghost1Turn to true to indicate that ghost1 has moved in this turn
                a(ghost1.Left, ghost1.Top); // Call the a() method to check if ghost1 has collided with any walls or pellets
            }
            // Update the position of ghost2 if it is enabled
            if (ghost2.Enabled == true)
            {
                ghost2.Left += leftGhost2; // Move ghost2 left or right based on the value of leftGhost2
                ghost2.Top += topGhost2; // Move ghost2 up or down based on the value of topGhost2
                ghost2Turn = true; // Set ghost2Turn to true to indicate that ghost2 has moved in this turn
                a(ghost2.Left, ghost2.Top); // Call the a() method to check if ghost2 has collided with any walls or pellets
            }

            // Update the position of ghost3 if it is enabled
            if (ghost3.Enabled == true)
            {
                ghost3.Left += leftGhost3; // Move ghost3 left or right based on the value of leftGhost3
                ghost3.Top += topGhost3; // Move ghost3 up or down based on the value of topGhost3
                ghost3Turn = true; // Set ghost3Turn to true to indicate that ghost3 has moved in this turn
                a(ghost3.Left, ghost3.Top); // Call the a() method to check if ghost3 has collided with any walls or pellets
            }

            // Update the position of ghost4 if it is enabled
            if (ghost4.Enabled == true)
            {
                ghost4.Left += leftGhost4; // Move ghost4 left or right based on the value of leftGhost4
                ghost4.Top += topGhost4; // Move ghost4 up or down based on the value of topGhost4
                ghost4Turn = true; // Set ghost4Turn to true to indicate that ghost4 has moved in this turn
                a(ghost4.Left, ghost4.Top); // Call the a() method to check if ghost4 has collided with any walls or pellets
            }

        }
    }
}
