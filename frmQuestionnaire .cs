using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class Form1 : Form
    {
        string[] messages = { "!כל הכבוד", "!נסה שוב בשאלה הבאה"};
        string[] question ={"?איזה מן המשולשים הבאים שווה צלעות" , "?איזה מבין הצורות למטה הכי דומה לצורה למעלה",
                "כל המשולשים חופפים. היקף ריבוע – 24 סמ, היקף כל משולש – 30 סמ. " + "חשב היקף הצורה",
            "?כמה עיגולים בתמונה","השלם את הזווית החסרה","?איזה מהצורות הבאות הוא מעויין",
        "?איזה מבין המשולשים *אינו שווה שוקיים","ריבוע שהקפו 16 סמ חולק ל12 מלבנים חופפים. חשב היקף כל מלבן",
        "?מה נכון לגביי תכונות הצורה שלפניכם","?כמה טפרזים שווי שוקיים בשרטוט שלפנייך", "?מהו המשך הצורה",
       "?כמה משולשים(מכל הסוגים)בשרטוט שלפניכם","?מי הצורה בעלת השטח הגדול ביותר","?כמה משולשים ישר זווית בתמונה",
        "?באיזה מן המשולשים הזווית הגדולה ביותר חייבת להיות מעל 90 מעלות", "?מי מבין משפחת המרובעים הוא המרובע המשוכלל ביותר",
        "?כמה קוביות בתמונה","השלם את המילה בעזרת הצורה שלפנייך","סיימת את המבחן. לפנייך 2 אפשרויות: ציון או משוב עבורינו. לסיום לחץ יציאה",};
        string[] arrbtn = { "90", "60", "110", "1","2","3", "100", "96" , "80", "85","40", "130","צהוב","ורוד","אדום"," 14/3",
        "זווית נגדיות שוות","צלעות מקבילות שוות","תשובות א וב נכונות","4","א","ב","ד","5","אליפסה", "מלבן", " משולש",
        "ג","ריבוע","דלתון","8","9","10","חלב","חדש","חגב"};
        int[] goodans = { 1, 1, 3, 2, 3, 3, 2, 2, 1, 3, 2, 3, 1, 2, 3, 3, 3, 1, 2, 1 };
        int counter = 0, sum = 0;
        const int TIME_FINISH = 11;
        int ticks;
        DialogResult dr;
        RichTextBox dynamicRichTextBox = new RichTextBox();
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("שלום!לפנייך 20 שאלות בנושא צורות. עלייך לענות על כמה שיותר תשובות נכונות, כל תשובה נכונה תזכה אותך ב5 נקודות. בסופו של המבחן תוכל לראות את הציון שאותו קיבלת!בהצלחה");
            Timer.Interval = 1000;
            checkgrade_off();
            checkmasov_off();
            masov_off();
            exit.Visible = false;
            richTextBox.Visible = false;
            btn_color.Visible = false;
            Timer.Start();
            ticks = 0;
            question1();

        }

        public void questions(int answer)
        {
            ticks = 0;
            if (goodans[counter] == answer)
            {
                TextBox.Text = messages[0];
                sum += 5;
            }
            else
                TextBox.Text = messages[1];


            switch (++counter)
            {
                case 1:
                    question2();
                    break;
                case 2:
                    question3();
                    break;
                case 3:
                    question4();
                    break;
                case 4:
                    question5();
                    break;
                case 5:
                    question6();
                    break;
                case 6:
                    question7();
                    break;
                case 7:
                    question8();
                    break;
                case 8:
                    question9();
                    break;
                case 9:
                    question10();
                    break;
                case 10:
                    question11();
                    break;
                case 11:
                    question12();
                    break;
                case 12:
                    question13();
                    break;
                case 13:
                    question14();
                    break;
                case 14:
                    question15();
                    break;
                case 15:
                    question16();
                    break;
                case 16:
                    question17();
                    break;
                case 17:
                    question18();
                    break;
                case 18:
                    question19();
                    break;
                case 19:
                    question20();
                    break;
                case 20: Final();
                    break;
            }
        }

        public void question1()
        {
            Qustion.Text = "?מה הזווית הגדולה ביותר במשולש ישר זווית";
            Ans1.Text = arrbtn[0];
            Ans2.Text = arrbtn[1];
            Ans3.Text = arrbtn[2];


        }
        public void question2()
        {
            Ans1.Text = arrbtn[3];
            Ans2.Text = arrbtn[4];
            Ans3.Text = arrbtn[5];
            Qustion.Text = question[0];
            PictureBox1.ImageLocation = @"..\..\images\משולש-שווה-צלעות-צהוב.gif";
            PictureBox2.ImageLocation = @"..\..\images\משולש-ישר-זווית.jpg";
            PictureBox3.ImageLocation = @"..\..\images\משולש-קהה-זווית.jpg";


        }
        public void question3()
        {
            Ans1.Text = arrbtn[3];
            Ans2.Text = arrbtn[4];
            Ans3.Text = arrbtn[5];
            Qustion.Text = question[1];
            PictureBox1.Visible = false;
            PictureBox3.Visible = false;
            PictureBox2.ImageLocation = @"..\..\images\איזה-מבין-הצורות-הכי-דומה-לצורה-למעלה.png";

        }

        public void question4()
        {
            Ans1.Text = arrbtn[6];
            Ans2.Text = arrbtn[7];
            Ans3.Text = arrbtn[8];
            Qustion.Text = question[2];
            PictureBox1.Visible = false;
            PictureBox3.Visible = false;
            PictureBox2.ImageLocation = @"..\..\images\היקף-צורה-רק-תמונה.jpg";
        }

        public void question5()
        {
            Ans1.Text = arrbtn[3];
            Ans2.Text = arrbtn[4];
            Ans3.Text = arrbtn[19];
            Qustion.Text = question[3];
            PictureBox1.Visible = false;
            PictureBox3.Visible = false;
            PictureBox2.ImageLocation = @"..\..\images\סודוקו-צורות.jpg";
        }

        public void question6()
        {
            Ans1.Text = arrbtn[9];
            Ans2.Text = arrbtn[10];
            Ans3.Text = arrbtn[11];
            Qustion.Text = question[4];
            PictureBox1.Visible = false;
            PictureBox3.Visible = false;
            PictureBox2.ImageLocation = @"..\..\images\שאלה-זווית.jpg";
        }

        public void question7()
        {
            Ans1.Text = arrbtn[3];
            Ans2.Text = arrbtn[4];
            Ans3.Text = arrbtn[5];
            Qustion.Text = question[5];
            PictureBox1.Visible = false;
            PictureBox3.Visible = false;
            PictureBox2.ImageLocation = @"..\..\images\איזה-מהצורות-מעויין.jpg";
        }

        public void question8()
        {
            Ans1.Text = arrbtn[12];
            Ans2.Text = arrbtn[13];
            Ans3.Text = arrbtn[14];
            Qustion.Text = question[6];
            PictureBox1.Visible = false;
            PictureBox3.Visible = false;
            PictureBox2.ImageLocation = @"..\..\images\איזה-מהמשולשים-שווי-שוקיים.png";
        }

        public void question9()
        {
            Ans1.Text = arrbtn[15];
            Ans2.Text = arrbtn[3];
            Ans3.Text = arrbtn[4];
            Qustion.Text = question[7];
            PictureBox1.Visible = false;
            PictureBox3.Visible = false;
            PictureBox2.ImageLocation = @"..\..\images\היקף-מלבן-רק-תמונה.jpg";
        }

        public void question10()
        {
            Ans1.Text = arrbtn[16];
            Ans2.Text = arrbtn[17];
            Ans3.Text = arrbtn[18];
            Qustion.Text = question[8];
            PictureBox1.Visible = false;
            PictureBox3.Visible = false;
            PictureBox2.ImageLocation = @"..\..\images\מקבילית-כחולה.png";
        }

        public void question11()
        {
            Ans1.Text = arrbtn[4];
            Ans2.Text = arrbtn[19];
            Ans3.Text = arrbtn[5];
            Qustion.Text = question[9];
            PictureBox1.Visible = false;
            PictureBox3.Visible = false;
            PictureBox2.ImageLocation = @"..\..\images\כמה-טרפזים-שווי-שוקיים-בציור.png";
        }

        public void question12()
        {
            Ans1.Text = arrbtn[20];
            Ans2.Text = arrbtn[21];
            Ans3.Text = arrbtn[22];
            Qustion.Text = question[10];
            PictureBox1.Visible = false;
            PictureBox3.Visible = false;
            PictureBox2.ImageLocation = @"..\..\images\מה-המשך-הצורה.png";
        }

        public void question13()
        {
            Ans1.Text = arrbtn[23];
            Ans2.Text = arrbtn[5];
            Ans3.Text = arrbtn[19];
            Qustion.Text = question[11];
            PictureBox1.Visible = false;
            PictureBox3.Visible = false;
            PictureBox2.ImageLocation = @"..\..\images\כמה-משולשים-בתמונה.png";
        }

        public void question14()
        {
            Ans1.Text = arrbtn[24];
            Ans2.Text = arrbtn[25];
            Ans3.Text = arrbtn[26];
            Qustion.Text = question[12];
            PictureBox1.Visible = false;
            PictureBox3.Visible = false;
            PictureBox2.ImageLocation = @"..\..\images\מי-הצורה-בעלת-שטח-הכי-גדול.jpg";
        }

        public void question15()
        {
            Ans1.Text = arrbtn[3];
            Ans2.Text = arrbtn[4];
            Ans3.Text = arrbtn[5];
            Qustion.Text = question[13];
            PictureBox1.Visible = false;
            PictureBox3.Visible = false;
            PictureBox2.ImageLocation = @"..\..\images\כמה-משולשים-ישרי-זווית-בתמונה.png";
        }

        public void question16()
        {
            Ans1.Text = arrbtn[20];
            Ans2.Text = arrbtn[21];
            Ans3.Text = arrbtn[27];
            Qustion.Text = question[10];
            PictureBox1.Visible = false;
            PictureBox3.Visible = false;
            PictureBox2.ImageLocation = @"..\..\images\מהו-ההמשך.png";
        }

        public void question17()
        {
            Ans1.Text = arrbtn[3];
            Ans2.Text = arrbtn[4];
            Ans3.Text = arrbtn[5];
            Qustion.Text = question[14];
            PictureBox1.Visible = false;
            PictureBox3.Visible = false;
            PictureBox2.ImageLocation = @"..\..\images\משולשים-כללי.png";
        }


        public void question18()
        {
            Ans1.Text = arrbtn[28];
            Ans2.Text = arrbtn[29];
            Ans3.Text = arrbtn[25];
            Qustion.Text = question[15];
            PictureBox1.Visible = false;
            PictureBox3.Visible = false;
            PictureBox2.ImageLocation = @"..\..\images\משפחת-מרובעים.jpg";
        }


        public void question19()
        {
            Ans1.Text = arrbtn[30];
            Ans2.Text = arrbtn[31];
            Ans3.Text = arrbtn[32];
            Qustion.Text = question[16];
            PictureBox1.Visible = false;
            PictureBox3.Visible = false;
            PictureBox2.ImageLocation = @"..\..\images\כמה-קוביות-בתמונה.jpg";
        }

        public void question20()
        {
            Ans1.Text = arrbtn[33];
            Ans2.Text = arrbtn[34];
            Ans3.Text = arrbtn[35];
            Qustion.Text = question[17];
            PictureBox1.Visible = false;
            PictureBox3.Visible = false;
            PictureBox2.ImageLocation = @"..\..\images\מה-הרכב-התמונה.png";

        }

        public void Final()
        {
            Timer.Stop();
            checkgrade_on();
            checkmasov_on();
            HowmuchT.Visible = false;
            TextBox.Visible = false;
            Ans1.Visible = false;
            Ans2.Visible = false;
            Ans3.Visible = false;
            Qustion.Text = question[18];
            PictureBox1.Visible = true;
            PictureBox3.Visible = true;
            PictureBox2.Visible = false;
            exit.Visible = true;
            PictureBox1.ImageLocation = @"..\..\images\ציון.jpg";
            PictureBox3.ImageLocation = @"..\..\images\משוב.jpg";


        }

        private void RichTextBox()
        {
                richTextBox.Visible = true;
                richTextBox.Location = new Point(80, 20);
                richTextBox.Width = 400;
                richTextBox.Height = 350;
                richTextBox.BackColor = Color.LightPink;
                richTextBox.ForeColor = Color.Firebrick;
                richTextBox.Text = "השאלון הסתיים!" + "\n" + "עבודה טובה," + " \n" + "המשך כך!";
                richTextBox.Font = new Font("Century Gothic", 50,FontStyle.Bold);
              

        }

        private void Ans1_Click(object sender, EventArgs e)
        {
            questions(1);
        }

        private void Ans2_Click(object sender, EventArgs e)
        {
            questions(2);
        }

        private void Ans3_Click(object sender, EventArgs e)
        {
            questions(3);
        }

        private void checkgrade_CheckedChanged(object sender, EventArgs e)
        {
            if (checkgrade.Checked)
            {
                MessageBox.Show("הניקוד שלך הוא" + " : " + sum);
                checkgrade.Enabled = false;
            }
            Final();
        }

        private void checkmasov_CheckedChanged(object sender, EventArgs e)
        {
            if (checkmasov.Checked)
            {
                masov_on();
                Ans1.Visible = false;
                Ans2.Visible = false;
                Ans3.Visible = false;
                PictureBox1.Visible = false;
                PictureBox2.Visible = false;
                PictureBox3.Visible = false;
                HowmuchT.Visible = false;
                TextBox.Visible = false;
                Qustion.Visible = false;
                checkgrade_off();
                checkmasov_off();
                Final();
            }
           
        }

        private void checkgrade_on()
        {
            checkgrade.Visible = true;
        }
        private void checkgrade_off()
        {
            checkgrade.Visible = false;
        }

        private void checkmasov_on()
        {
            checkmasov.Visible = true;
        }
        private void checkmasov_off()
        {
            checkmasov.Visible = false;
        }

        private void masov_on()
        {
            txt_mashov.Visible = true;
            btn_mashov.Visible = true;
        }
        private void masov_off()
        {
            txt_mashov.Visible = false;
            btn_mashov.Visible = false;
        }

        private void btn_mashov_Click(object sender, EventArgs e)
        {
            dr = MessageBox.Show("?האם אתה בטוח", "!שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                masov_off();
                checkmasov.Enabled = false;
            }
            Final();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Ans1.Visible = false;
            Ans2.Visible = false;
            Ans3.Visible = false;
            PictureBox1.Visible = false;
            PictureBox2.Visible = false;
            PictureBox3.ImageLocation = @"..\..\images\כל-הכבוד.jpg";
            HowmuchT.Visible = false;
            TextBox.Visible = false;
            Qustion.Visible = false;
            exit.Visible = false;
            checkgrade_off();
            checkmasov_off();
            RichTextBox();
            btn_color.Visible = true;
            

        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            if (this.BackColor == System.Drawing.Color.MistyRose)
                this.BackColor = System.Drawing.Color.Coral;
            else if (this.BackColor == System.Drawing.Color.Coral)
                this.BackColor = System.Drawing.Color.Green;
            else if (this.BackColor == System.Drawing.Color.Green)
                this.BackColor = System.Drawing.Color.SteelBlue;
            else if (this.BackColor == System.Drawing.Color.SteelBlue)
                this.BackColor = System.Drawing.Color.DarkRed;
            else if (this.BackColor == System.Drawing.Color.DarkRed)
                this.BackColor = System.Drawing.Color.Plum;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (TIME_FINISH - ticks == 0)
            {
                HowmuchT.Text = " Time has passed\n";
                ticks = 0;
                questions(counter);
                 
            }
            else if (TIME_FINISH - ticks <= 10)
            {
                HowmuchT.Text = "נותרו לך עוד " + (TIME_FINISH - ticks) + " שניות לסיום השאלה\n";
            }
        }
    }
}

