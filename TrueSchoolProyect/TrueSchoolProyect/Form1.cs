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


namespace TrueSchoolProyect
{

    public partial class Form1 : Form
    {
        Player player = new Player();
        RecordsDB records = new RecordsDB();
        int HPCheckpoint = 100;
        int ScoreCheckpoint = 0;
        public Form1()
        {
            InitializeComponent();
            BuildMenu();
        }

        private void Play_Button_Click(object sender, EventArgs e)
        {
            ClearMenu();
            BuildTextZone();
            BuildIntro();
            WriteToGame("Hello... I see you are starting up...");
            WriteToGame("What is your filename?");
            player.SetScore(1000);
            //BuildDesktop();
        }

        private void Checkpoint()
        {
            HPCheckpoint = player.GetHP();
        }
        //public void takeDamage(int damage)
        //{
        //    if (player.GetHP() - damage >= 0)
        //    {
        //        try
        //        {
        //            player.ReduceHP(damage);
        //            HealthBar.Value = player.GetHP();
        //            HealthCounter.Text = player.GetHP() + "/" + player.GetMaxHP();
        //            WriteToGame("You got punched in the face and lost " + damage + " hp");
        //        }
        //        catch (Exception e) { }
        //    }
        //    else
        //    {
        //        WriteToGame("You are dead");
        //    }
        //}

        public void WriteToGame(String NewEntry)
        {
            List<TextBox> tblist = new List<TextBox>() { textBox2, textBox3, textBox4, textBox5 };
            String SwapVarStore = null;
            String SwapVar = textBox1.Text;
            textBox1.Text = NewEntry;
            foreach (TextBox Name in tblist)
            {
                SwapVarStore = Name.Text;
                Name.Text = SwapVar;
                SwapVar = SwapVarStore;
            }
        }

        //private void SaveGame()
        //{
        //    //File.Create("SaveData.doc");
        //    var fs = File.Open("SaveData.doc", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        //    var sw = new StreamWriter(fs);
        //    int hp = player.GetHP();
        //    string saveData = "HP = " + hp;
        //    sw.WriteLine(saveData);
        //    sw.Flush();

        //    fs.Close();
        //}

        //private void LoadGame()
        //{
        //    var fs = File.Open("SaveData.doc", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        //    var sr = new StreamReader(fs);
        //    string loadData = sr.ReadLine();
        //    WriteToGame(loadData);

        //    fs.Close();
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WriteTopScores()
        {
            List<string>[] HighScores = records.SelectHighScores();
            for (int i=0; i<5; i++){
                int n = i + 1;
            
                WriteToGame("#"+n+" High Score: "+HighScores[1][i]+"("+HighScores[2][i]+")");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Records_Click(object sender, EventArgs e)
        {
            ClearMenu();
            BuildTextZone();
            WriteTopScores();
            BuildRecords();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        //private void AttackButton_Click(object sender, EventArgs e)
        //{
        //    takeDamage(10);
        //}

        //private void HealthPotButton_Click(object sender, EventArgs e)
        //{
        //    if (player.GetHP() + 10 <= player.GetMaxHP() & player.GetHP() > 0)
        //    {
        //        try
        //        {
        //            player.RestoreHP(10);
        //            HealthBar.Value = player.GetHP();
        //            HealthCounter.Text = player.GetHP() + "/" + player.GetMaxHP();
        //            WriteToGame("You take a swig of your health potion and it restores 10 hp");
        //        }
        //        catch (Exception exe) { }
        //    }
        //    else
        //    {
        //        if (player.GetHP() <= 0)
        //        {
        //            WriteToGame("You are dead and therefore are unable to drink of your potion");
        //        }
        //        else
        //        {
        //            WriteToGame("You take a swig of your drink but it doesn't appear to have had any affect");
        //        }
        //    }

        //}


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TurnRightBox_Click(object sender, EventArgs e)
        {
            ClearTestGame();
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    SaveGame();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    LoadGame();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            ClearTextZone();
            ClearRecords();
            BuildMenu();
            
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void NameConfirm_Click(object sender, EventArgs e)
        {
            player.SetUsername(NameRegister.Text);
            NameConfirm.Visible = false;
            NameRegister.Visible = false;
            NameConfirm.Enabled = false;
            NameRegister.Enabled = false;
            GameLoadButton.Enabled = true;
            GameLoadButton.Visible = true;
            WriteToGame(player.GetUsername()+"? What a strange name for an Antivirus...");
            WriteToGame("Oh no... it can't be... User? Is that you?");
            WriteToGame("We have to get you out of here! There are virus' everywhere!");
        }

        private void GameLoadButton_Click(object sender, EventArgs e)
        {
            ClearTextZone();
            ClearIntro();
            BuildDesktop();
        }




        #region CAT5 Zone
        //Global variables
        Position Terminal = new Position();
        Position Colors = new Position();
        List<string> ColorList = new List<string>();
        List<string> myColorNames = new List<string>();
        List<string> LocationList = new List<string>();
        List<string> myLocationNames = new List<string>();
        int clicks = 0;

        //public Form1()
        //{
            //InitializeComponent();
        //}
        //Mouse Down Event  
        private void dragDrop_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox myPic = (PictureBox)sender;
            myPic.Select();
            myPic.DoDragDrop(myPic.Image, DragDropEffects.Copy);
            //X coordinate of the COLOR
            if (e.Button == MouseButtons.Left)
            {
                tb_Colors.Text = myPic.Location.X.ToString();
                if (Colors != null)
                {
                    Colors.position = tb_Colors.Text;
                    ColorList.Add(Colors.position);
                    while (LocationList.Count != ColorList.Count)
                        ColorList.RemoveAt(ColorList.Count - 1);
                    /*Click Count */
                    clicks++;
                    tb_Clicks.Text = clicks.ToString();
                }
            }
        }

        //Drag PickUp Event
        private void dragDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }

        //Drop Event
        private void dragDrop_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox myPic = (PictureBox)sender;
            myPic.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            //X coordinate location of TERMINAL
            if (Terminal != null)
            {
                tb_Terminal.Text = myPic.Location.X.ToString();
                Terminal.position = tb_Terminal.Text;
                LocationList.Add(Terminal.position);
                myPic.Enabled = false;
            }
        }
        public class Position
        {
            public string position { get; set; }
            //Method assigns names to "Color" picture boxes 
            public string assignName(string position)
            {
                string name;
                if (position == "221") name = "Blue";
                else if (position == "257") name = "Brown";
                else if (position == "292") name = "Green";
                else if (position == "328") name = "Orange";
                else if (position == "364") name = "White and Blue";
                else if (position == "401") name = "White and Brown";
                else if (position == "436") name = "White and Green";
                else if (position == "473") name = "White and Orange";
                else name = null;
                return name;

            }
            //Method assigns names to "Terminal" pictureboxes
            public string checkTerminalPosition(string position)
            {
                string location;
                //Correct sequence :

                //Terminal 1: 
                //1.White and Orange    2.Orange    3.White and Green   4.Blue   
                //5.White and Blue      6.Green     7.White and Brown   8.Brown 
                if (position == "41") location = "White and Orange";
                else if (position == "77") location = "Orange";
                else if (position == "112") location = "White and Green";
                else if (position == "148") location = "Blue";
                else if (position == "184") location = "White and Blue";
                else if (position == "221") location = "Green";
                else if (position == "256") location = "White and Brown";
                else if (position == "293") location = "Brown";

                //Terminal 2: 
                //1.White and Green    2.Green    3.White and Orange    4.Blue   
                //5.White and Blue     6.Orange   7.White and Brown     8.Brown 
                else if (position == "380") location = "White and Green";
                else if (position == "415") location = "Green";
                else if (position == "453") location = "White and Orange";
                else if (position == "489") location = "Blue";
                else if (position == "524") location = "White and Blue";
                else if (position == "560") location = "Orange";
                else if (position == "595") location = "White and Brown";
                else if (position == "632") location = "Brown";
                else location = null;
                return location;

            }

        }

        //Compares for positional match
        public int checkMatch()
        {
            int count = 0;
            if (LocationList.Count == ColorList.Count)
            {
                //Uses Position Class Methods of Assigning names to coordinates
                foreach (string color in ColorList) myColorNames.Add(Colors.assignName(color));
                foreach (string coordinate in LocationList) myLocationNames.Add(Terminal.checkTerminalPosition(coordinate));
                //Loops to compare if matches were found in lists
                for (int i = 0; i < LocationList.Count; i++)
                    if (myColorNames[i] == myLocationNames[i]) count++;
            }
            //Disables Submit button to reduce risk of false results.
            bt_Submit.Visible = false;
            return count;
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
            //Allows Drag & Drop Effect on Receiving PictureBox
            //Terminal 1           //Terminal 2
            //t1p1.AllowDrop = true; t2p1.AllowDrop = true;
            //t1p2.AllowDrop = true; t2p2.AllowDrop = true;
            //t1p3.AllowDrop = true; t2p3.AllowDrop = true;
            //t1p4.AllowDrop = true; t2p4.AllowDrop = true;
            //t1p5.AllowDrop = true; t2p5.AllowDrop = true;
            //t1p6.AllowDrop = true; t2p6.AllowDrop = true;
            //t1p7.AllowDrop = true; t2p7.AllowDrop = true;
            //t1p8.AllowDrop = true; t2p8.AllowDrop = true;
        //}
        private void EnableDrop()
        {
            //Allows Drag & Drop Effect on Receiving PictureBox
            //Terminal 1           //Terminal 2
            t1p1.AllowDrop = true; t2p1.AllowDrop = true;
            t1p2.AllowDrop = true; t2p2.AllowDrop = true;
            t1p3.AllowDrop = true; t2p3.AllowDrop = true;
            t1p4.AllowDrop = true; t2p4.AllowDrop = true;
            t1p5.AllowDrop = true; t2p5.AllowDrop = true;
            t1p6.AllowDrop = true; t2p6.AllowDrop = true;
            t1p7.AllowDrop = true; t2p7.AllowDrop = true;
            t1p8.AllowDrop = true; t2p8.AllowDrop = true;
        }

        //Submit Button uses checkMatch() to estimate results
        private void bt_Submit_Click(object sender, EventArgs e)
        {
            List<PictureBox> myPictureBoxList = new List<PictureBox>() { t1p1, t1p2, t1p3, t1p4, t1p5, t1p6, t1p7, t1p8, t2p1, t2p2, t2p3, t2p4, t2p5, t2p6, t2p7, t2p8 };

            tb_instructions.Visible = false;
            lb_instructions.Visible = false;
            tb_Clicks.Visible = true;
            lb_clicks.Visible = true; 
            //High Score Calculation
            int highScore = 116 - clicks;
            int total = 0;
            total += checkMatch();

            //Found matches either:
            //Lose if less than 16
            if ((total < 16) && (0 <= total))
            {
                tb_Results.Visible = true;
                tb_Results.Text = (total.ToString() + " are correct \nTry again!".ToUpper());
            }
            //Win if 16 matches are found
            else
            {
                tb_Results.Text = "Congratulations, You Won!\n High Score of "+highScore.ToString()+"...";
                total = 0;
                player.ScoreUP(highScore);
                MessageBox.Show("TOTAL POINTS: " + player.GetScore().ToString());
                records.WriteNewScore(player.GetUsername(), player.GetScore());
                ClearCAT5();
                BuildMenu();
                DeclareScore();

            }

        }

        public void DeclareScore()
        {
            MessageBox.Show("Congratulations! Your score of " + player.GetScore().ToString()+" has been added to the Records, Check to see if you made top 5!");
        }

        //Resets all elements
        private void bt_Reset_Click(object sender, EventArgs e)
        {

            List<PictureBox> myPictureBoxList = new List<PictureBox>() { t1p1, t1p2, t1p3, t1p4, t1p5, t1p6, t1p7, t1p8, t2p1, t2p2, t2p3, t2p4, t2p5, t2p6, t2p7, t2p8 };


            List<string> ResetTerminals = new List<string>();
            bt_Submit.Visible = true;
            tb_Colors.Text = "COLORS!";
            tb_Terminal.Text = "TERMINAL LOC";
            tb_Clicks.Text = "CLICKS!";
            clicks = 0;
            Terminal = new Position();
            Colors = new Position();
            ColorList = new List<string>();
            myColorNames = new List<string>();
            LocationList = new List<string>();
            myLocationNames = new List<string>();

            foreach (PictureBox Name in myPictureBoxList)
            {
                Name.Image = null;
                Name.Enabled = true;
                Name.MouseLeave -= new System.EventHandler(this.PictureBox_MouseLeave);
                Name.MouseHover -= new System.EventHandler(this.PictureBox_MouseHover);
            }
        }
        private string HintText(string position)
        {
            string HintName = "";
            if ((position == "41") || (position == "453")) HintName = "  Almost Nemo Stripes";
            else if ((position == "77") || (position == "560")) HintName = "   Full of Vitamin C";
            else if ((position == "112") || (position == "380")) HintName = "Put a Lime in a Coconut";
            else if ((position == "148") || (position == "489")) HintName = "Once in a That Moon";
            else if ((position == "184") || (position == "524")) HintName = "An Almost American Flag";
            else if ((position == "221") || (position == "415")) HintName = "   Four Leaf Clover";
            else if ((position == "256") || (position == "595")) HintName = "Baby Zebra's Stripes";
            else if ((position == "293") || (position == "632")) HintName = "Java, NOT the Software";
            return HintName;
        }
        private void PictureBox_MouseHover(object sender, EventArgs e)
        {
            PictureBox Hint = (PictureBox)sender;
            lb_t1p1.Text = HintText(Hint.Location.X.ToString());
            lb_t1p1.Visible = true;
            lb_Hint.Visible = false;
        }
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            lb_t1p1.Visible = false;
        }
        private void bt_Hint_Click(object sender, EventArgs e)
        {
            List<PictureBox> myPictureBoxList = new List<PictureBox>() { t1p1, t1p2, t1p3, t1p4, t1p5, t1p6, t1p7, t1p8, t2p1, t2p2, t2p3, t2p4, t2p5, t2p6, t2p7, t2p8 };

            bt_Hint.Visible = false;
            tb_instructions.Visible = false;
            lb_instructions.Visible = false;
            tb_Clicks.Visible = true;
            lb_clicks.Visible = true;
            try
            {
                //reduces total score for the game
                player.ScoreUP(-10);
                lb_Hint.Visible = true;
                foreach (PictureBox Name in myPictureBoxList)
                {
                    Name.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
                    Name.MouseHover += new System.EventHandler(this.PictureBox_MouseHover);
                }
            }

            catch (Exception) { }

        }
        #endregion

        #region Stephen Zone
        //This variable is used to count the number of objects you have found
        int found = 0;
        //I added This to test your points.  It is never shown, Only recorded
        //int points = 1000;
        //I added this variable to test the virus method
        //int HealthCheckpoint = 100;
        //This method is only called when you die.  It means you must find everything again
        public int lost()
        {
            return found = 0;
        }
        //This method is called when you find an item
        public int item()
        {
            if (found == 10)
            {
                MessageBox.Show("You've found all the items!");
                Checkpoint();
                ClearSearch();
                BuildCAT5();
            }
            return found++;

        }
        //This is keeps track of your score.  using the point variabl
        //public int score(int num)
        //{
        //    points = points + num;
        //    return points;
        //}
        //This is called when you run out of health
        public void death()
        {
            MessageBox.Show("Zap!  The viruses got you!  You will reboot in a second, but you'll have to find all your stuff again");
            lost();
            player.SetHP(HPCheckpoint);
            player.ScoreUP(-100);
            TheCloudTB.Text = "The Cloud";
            CloudBT.Visible = true;
            TheWeb_BT.Visible = true;
            TheWebTB.Text = "The Web";
            WordDocBT.Visible = true;
            WordDocTB.Text = "Word Doc";
            Fire_WallBT.Visible = true;
            FireWallTb.Text = "Firewall";
            MalwearTB.Text = "Malwear";
            MalWearBT1.Visible = true;
            HeadphoneJackBT.Visible = true;
            HeadphoneJackTB.Text = "Headphone Jack";
            ComputerChipBT.Visible = true;
            ComputerChipsTB.Text = "Computer Chip";
            BatteryBT.Visible = true;
            BatteryTB.Text = "Battery";
            LibraryFileTB.Text = "Library File";
            LibraryFileBt.Visible = true;
            SecurityKeyBT.Visible = true;
            SecurityKeyTB.Text = "Security Key";
            BrokenLinkTB.Text = "Broken Link";
            BrokenLinkBT.Visible = true;
            //return Health;
        }
        //This is called whenever you click on a worm.  It reduces your health 20 and your score 10
        public void worm()
        {
            player.ReduceHP(20);
            if (player.GetHP() >= 0)
            {
                MessageBox.Show("Uh Oh!  You found a worm!  These invisible pest can really hurt you!");
                player.ScoreUP(-10);
                //return Health;
            }
            else
            {
                death();
                //return Health;
            }
        }

        //This is called whenever you click on a virus.  It reduces your health 30 and your score 15
        public void virus()
        {
            player.ReduceHP(30);
            if (player.GetHP() >= 0)
            {
                MessageBox.Show("Uh Oh!  You found a virus!  That's going to cost you!");
                player.ScoreUP(-10);
                //return Health;
            }
            else
            {
                death();
                //return Health;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            virus();
        }

        private void Fire_WallBT_Click(object sender, EventArgs e)
        {
            FireWallTb.Text = "Firewall (found)";
            MessageBox.Show("You found the Fire Wall");
            Fire_WallBT.Visible = false;
            item();
        }

        private void WordDocBT_Click(object sender, EventArgs e)
        {
            WordDocTB.Text = "Word Doc (found)";
            MessageBox.Show("You found the Word Doc!");
            item();

            WordDocBT.Visible = false;

        }

        private void BrokenLinkBT_Click(object sender, EventArgs e)
        {
            BrokenLinkTB.Text = "Broken Link (found)";
            MessageBox.Show("You found a Broken Link");
            BrokenLinkBT.Visible = false;
            item();
        }

        private void TheWeb_BT_Click(object sender, EventArgs e)
        {
            TheWebTB.Text = "The Web (found)";
            MessageBox.Show("You found the Web!");
            TheWeb_BT.Visible = false;
            item();
        }

        private void SecurityKeyBT_Click(object sender, EventArgs e)
        {
            SecurityKeyTB.Text = "Security Key (found)";
            MessageBox.Show("You found the Security Key");
            SecurityKeyBT.Visible = false;
            item();
        }

        private void CloudBT_Click(object sender, EventArgs e)
        {
            TheCloudTB.Text = "The Cloud (found)";
            MessageBox.Show("Welcome to the Cloud!");
            item();
            CloudBT.Visible = false;
        }

        private void VirusPb4_Click(object sender, EventArgs e)
        {
            virus();
        }

        private void VirusPb5_Click(object sender, EventArgs e)
        {
            virus();
        }

        private void LibraryFileBt_Click(object sender, EventArgs e)
        {
            LibraryFileTB.Text = "Library File (found)";
            MessageBox.Show("You found the Library File!");
            LibraryFileBt.Visible = false;
            item();
        }

        private void HeadphoneJackBT_Click(object sender, EventArgs e)
        {
            HeadphoneJackTB.Text = "Headphone Jack (found)";
            MessageBox.Show("You found the Headphone Jack");
            item();
            HeadphoneJackBT.Visible = false;
        }

        private void VirusPb6_Click(object sender, EventArgs e)
        {
            virus();
        }

        private void ComputerChipBT_Click(object sender, EventArgs e)
        {
            ComputerChipsTB.Text = "Computer Chip (found)";
            MessageBox.Show("You found the Computer Chips!");
            item();
            ComputerChipBT.Visible = false;
        }

        private void VirusPb_Click(object sender, EventArgs e)
        {
            virus();
        }

        private void MalWearBT1_Click(object sender, EventArgs e)
        {
            MalwearTB.Text = "Malwear (found)";
            MessageBox.Show("You found the Mal Wear!");
            item();
            MalWearBT1.Visible = false;
        }

        private void VirusPb2_Click(object sender, EventArgs e)
        {
            virus();
        }

        private void BatteryBT_Click(object sender, EventArgs e)
        {
            BatteryTB.Text = "Battery (found)";
            MessageBox.Show("You found a Battery!  Yep it's just a battery");
            item();
            BatteryBT.Visible = false;
        }

        private void VirusPb8_Click(object sender, EventArgs e)
        {
            virus();
        }

        private void VirusPb1_Click(object sender, EventArgs e)
        {
            virus();
        }

        private void VirusPb3_Click(object sender, EventArgs e)
        {
            virus();
        }

        private void Virus9_Click(object sender, EventArgs e)
        {
            virus();
        }

        private void worm2_Click(object sender, EventArgs e)
        {
            worm();
        }

        private void Worm1_Click(object sender, EventArgs e)
        {
            worm();
        }

        private void worm3_Click(object sender, EventArgs e)
        {
            worm();
        }

        private void worm4b_Click(object sender, EventArgs e)
        {
            worm();
        }

        private void Worm4_Click(object sender, EventArgs e)
        {
            worm();
        }

        private void worm5_Click(object sender, EventArgs e)
        {
            worm();
        }

        private void Worm5c_Click(object sender, EventArgs e)
        {
            worm();
        }

        private void Worm5b_Click(object sender, EventArgs e)
        {
            worm();
        }

        private void Worm5d_Click(object sender, EventArgs e)
        {
            worm();
        }

        private void Worm6_Click(object sender, EventArgs e)
        {
            worm();
        }

        private void Worm8_Click(object sender, EventArgs e)
        {
            worm();
        }
        #endregion

        #region Miguel Zone

        //int health = 100; // Variable Int for the player's health
        int vhealth = 100; //Variable Int for the enemies health
        public void attack()
        { //Method for enemies' attack
            player.ReduceHP(Random(0, 20));
            //return health;
        }

        public void OnBuild()
        {
            vhealth = 100;
            player.SetHP(100);
        }
        public int damage()
        {   //Same as previous but the damage you cause
            vhealth -= Random(1, 40);
            return vhealth;

        }

        public int Random(int min, int max) //Random rumber method
        {
            Random random = new Random();
            return random.Next(min, max+1);
        }


        private void instructions1_Click(object sender, EventArgs e)
        {

        }

        private void Desktop_Load(object sender, EventArgs e)
        { //In order for the user not be able to write on the heath textboxes...
            You.ReadOnly = true;
            Enemy.ReadOnly = true;
            MessageBox.Show("--Welcome to your Desktop--"); //Greeting

        }


        private void Enemybt_Click(object sender, EventArgs e)
        {
            
            if (vhealth > 0)
            {
                vhealth -= Random(0, 40);
            }
                
            if (vhealth <= 0) {
                    MessageBox.Show("Enemy defeated!");
                    Checkpoint();
                    ClearDesktopZone();
                    BuildSearch();
                    return;
                }

            
            if (player.GetHP() >= 40) attack();
            else if ((player.GetHP() < 40) && (player.GetHP() >= 0))
            {
                Random rand = new Random();
                player.ReduceHP(rand.Next(1, 5));
                if (player.GetHP() <= 0) MessageBox.Show("You have been defeated!");
                You.Text = 0.ToString();
                if (player.GetHP() <= 0) //Closes program after
                ClearDesktopZone();
                BuildMenu();
                return;
            

            }

            Enemy.Text = vhealth.ToString();
            You.Text = player.GetHP().ToString();
            MessageBox.Show("POW!! attacked the virus with your plasma cannon, his health is " + vhealth + "Hp");


        }

        private void button1_2_Click(object sender, EventArgs e)
        {

        }

        private void Vhealth_TextChanged(object sender, EventArgs e)
        {

        }

        private void instructions2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        //Bryce: "I think we can optimize this better while I lower the difficulty"
        private void FolderFunction()
        {
            int effect = Random(1, 5);
            MessageBox.Show("Mystery folder unlocked!");
            switch (effect)              
            {
                case 1:
                    player.RestoreHP(5);
                    break;

                case 2:
                    player.RestoreHP(10);
                    break;

                case 3:
                    player.RestoreHP(20);
                    break;

                case 4:
                    player.ReduceHP(player.GetHP()/4);
                    break;

                case 5:
                    player.RestoreHP(player.GetHP()/2);
                    break;

                default:
                    break;
            }
            if (player.GetHP() <= 0)
            {
                MessageBox.Show("You have been eliminated!");
                ClearDesktopZone();
                BuildMenu();
            }
            You.Text = player.GetHP().ToString();
            player.ScoreUP(-10);
        }

        private void folder1_Click(object sender, EventArgs e)//folder1
        {
            FolderFunction();
            folder1.Enabled = false;
            
        }
        //private int folders(int sign)
        //{

        //    Random change = new Random();
        //    int points = change.Next(5);



        //    if (sign == 1)
        //        player.ReduceHP(points);
        //    else
        //        player.RestoreHP(points);

        //    return player.GetHP();
        //}
        //private int randomFunction()
        //{
        //    Random turn = new Random();
        //    int sign = turn.Next(0, 2);
        //    return sign;
        //}
        //private void textInTextBox(int health)
        //{
        //    Random turn = new Random();
        //    int sign = turn.Next(1, 2);
        //    You.Text = player.GetHP().ToString();
        //}

        private void folder2_Click(object sender, EventArgs e) //folder2
        {
            FolderFunction();
            folder2.Enabled = false;
        }

        private void folder3_Click(object sender, EventArgs e) //folder3
        {
            FolderFunction();
            folder3.Enabled = false;
        }

        private void folder4_Click(object sender, EventArgs e) //folder4
        {
            FolderFunction();
            folder4.Enabled = false;
        }

        private void folder5_Click(object sender, EventArgs e) //folder5
        {
            FolderFunction();
            folder5.Enabled = false;
        }

        private void folder6_Click(object sender, EventArgs e) //folder6
        {
            FolderFunction();
            folder6.Enabled = false;
        }

        private void folder7_Click(object sender, EventArgs e) //folder7
        {
            FolderFunction();
            folder7.Enabled = false;
        }

        private void folder8_Click(object sender, EventArgs e) //folder8
        {
            FolderFunction();
            folder8.Enabled = false;
        }
    



        #endregion


    }
}
