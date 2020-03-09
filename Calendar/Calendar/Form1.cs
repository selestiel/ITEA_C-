using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MyDT.SetDate(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            INIT();
            timer1.Start();

        }
        private void INIT()
        {
            RichTextBox[] RTB = new RichTextBox[35]
            {
                richTextBox1,richTextBox2,richTextBox3,richTextBox4,richTextBox5,richTextBox6,richTextBox7,
                richTextBox8,richTextBox9,richTextBox10,richTextBox11,richTextBox12,richTextBox13,richTextBox14,
                richTextBox15,richTextBox16,richTextBox17,richTextBox18,richTextBox19,richTextBox20,richTextBox21,
                richTextBox22,richTextBox23,richTextBox24,richTextBox25,richTextBox26,richTextBox27,richTextBox28,
                richTextBox29,richTextBox30,richTextBox31,richTextBox32,richTextBox33,richTextBox34,richTextBox35,
            };
            RTB[5].BackColor = Color.LightYellow;
            RTB[6].BackColor = Color.LightPink;
            Label[] LBL = new Label[35]
            {
                this.label1, this.label2,this.label3,this.label4,this.label5,this.label6,this.label7,
                this.label8,this.label9,this.label10,this.label11,this.label12,this.label13,this.label14,
                this.label15,this.label16,this.label17,this.label18,this.label19,this.label20,this.label21,
                this.label22,this.label23,this.label24,this.label25,this.label26,this.label27,this.label28,
                this.label29,this.label30,this.label31,this.label32,this.label33,this.label34,this.label35,
            };
            DateTime Begin = MyDT.Date;
            int counter = 0;
            int counter_b = 0;
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                for (int i = 0; i < LBL.Length; i++)
                {

                    LBL[i].Text = Begin.AddDays(counter).ToString("dd MM yyyy");
                    counter++;
                }
                RTB[0].BackColor = Color.Aquamarine;
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
            {
                for (int i = 1; i < LBL.Length; i++)
                {

                    LBL[i].Text = Begin.AddDays(counter).ToString("dd MM yyyy");
                    counter++;
                }

                for (int i = 1; i >= 0; i--)
                {

                    LBL[i].Text = Begin.AddDays(counter_b).ToString("dd MM yyyy");
                    counter_b--;
                    RTB[i].BackColor = Color.LightGray;
                }
                RTB[1].BackColor = Color.Aquamarine;
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                for (int i = 2; i < LBL.Length; i++)
                {

                    LBL[i].Text = Begin.AddDays(counter).ToString("dd MM yyyy");
                    counter++;
                }
                for (int i = 2; i >= 0; i--)
                {

                    LBL[i].Text = Begin.AddDays(counter_b).ToString("dd MM yyyy");
                    counter_b--;
                    RTB[i].BackColor = Color.LightGray;
                }
                RTB[2].BackColor = Color.Aquamarine;
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
            {
                for (int i = 3; i < LBL.Length; i++)
                {

                    LBL[i].Text = Begin.AddDays(counter).ToString("dd MM yyyy");
                    counter++;
                }
                for (int i = 3; i >= 0; i--)
                {

                    LBL[i].Text = Begin.AddDays(counter_b).ToString("dd MM yyyy");
                    counter_b--;
                    RTB[i].BackColor = Color.LightGray;
                }
                RTB[3].BackColor = Color.Aquamarine;
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {

                for (int i = 4; i < LBL.Length; i++)
                {

                    LBL[i].Text = Begin.AddDays(counter).ToString("dd MM yyyy");
                    counter++;
                }
                for (int i = 4; i >= 0; i--)
                {

                    LBL[i].Text = Begin.AddDays(counter_b).ToString("dd MM yyyy");
                    counter_b--;
                    RTB[i].BackColor = Color.LightGray;
                }
                RTB[4].BackColor = Color.Aquamarine;
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                for (int i = 5; i < LBL.Length; i++)
                {

                    LBL[i].Text = Begin.AddDays(counter).ToString("dd MM yyyy");
                    counter++;
                }
                for (int i = 5; i >= 0; i--)
                {

                    LBL[i].Text = Begin.AddDays(counter_b).ToString("dd MM yyyy");
                    counter_b--;
                    RTB[i].BackColor = Color.LightGray;
                }
                if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
                {
                    RTB[5].BackColor = Color.Aquamarine;
                }
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                for (int i = 6; i < LBL.Length; i++)
                {

                    LBL[i].Text = Begin.AddDays(counter).ToString("dd MM yyyy");
                    counter++;
                }
                for (int i = 6; i >= 0; i--)
                {

                    LBL[i].Text = Begin.AddDays(counter_b).ToString("dd MM yyyy");
                    counter_b--;
                    RTB[i].BackColor = Color.LightGray;
                }
                if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                {
                    RTB[6].BackColor = Color.Aquamarine;
                }
            }
            RTB[12].BackColor = Color.LightYellow;
            RTB[19].BackColor = Color.LightYellow;
            RTB[26].BackColor = Color.LightYellow;
            RTB[33].BackColor = Color.LightYellow;
            RTB[13].BackColor = Color.LightPink;
            RTB[20].BackColor = Color.LightPink;
            RTB[27].BackColor = Color.LightPink;
            RTB[34].BackColor = Color.LightPink;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            DateTime date = new DateTime(MyDT.Date.Year, MyDT.Date.Month, MyDT.Date.Day);
            int day = date.Day;
            int mon = DateTime.DaysInMonth(date.Year, date.Month);
            int total_load = mon * 8;
            RichTextBox[] RTBA = new RichTextBox[35]
            {
                richTextBox1,richTextBox2,richTextBox3,richTextBox4,richTextBox5,richTextBox6,richTextBox7,
                richTextBox8,richTextBox9,richTextBox10,richTextBox11,richTextBox12,richTextBox13,richTextBox14,
                richTextBox15,richTextBox16,richTextBox17,richTextBox18,richTextBox19,richTextBox20,richTextBox21,
                richTextBox22,richTextBox23,richTextBox24,richTextBox25,richTextBox26,richTextBox27,richTextBox28,
                richTextBox29,richTextBox30,richTextBox31,richTextBox32,richTextBox33,richTextBox34,richTextBox35,
            };
            for (int i = day; i < mon; i++)
            {
                if (RTBA[i].TextLength > 0)
                {
                    counter++;
                }
            }
            int load = 8 * counter;
            int free = total_load - load;
            int days_free = free / 8;
            LBL_FREE_DAYS.Text = Convert.ToString(days_free);
            LBL_LOAD_DAYS.Text = Convert.ToString(counter);
            LBL_TOTAL_DAYS.Text = Convert.ToString(mon);
            LBL_H_FREE.Text = Convert.ToString(free);
            LBL_H_LOAD.Text = Convert.ToString(load);
            LBL_H_TOT.Text = Convert.ToString(mon * 8);
        }
        private void BTN_SET_DATE_Click(object sender, EventArgs e)
        {
            try
            {
                MyDT.SetDate(Convert.ToDateTime(TB_SET_DATE.Text));
            }

            catch (Exception)
            {
            }
            finally 
            {
            INIT();
            }
        
        }

        static class MyDT
        {
            static public DateTime Date { get; set; }
            static public int Day { get; set; }
            static public int Month { get; set; }
            static public int Year { get; set; }
            static public void SetDate(DateTime dat)
            {
                Date = dat;
            }
            static public void SetDate(int day, int month, int year)
            {
                Date = new DateTime(year, month, day);
            }
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            Label[] LBLS = new Label[35]
            {
                this.label1, this.label2,this.label3,this.label4,this.label5,this.label6,this.label7,
                this.label8,this.label9,this.label10,this.label11,this.label12,this.label13,this.label14,
                this.label15,this.label16,this.label17,this.label18,this.label19,this.label20,this.label21,
                this.label22,this.label23,this.label24,this.label25,this.label26,this.label27,this.label28,
                this.label29,this.label30,this.label31,this.label32,this.label33,this.label34,this.label35,
            };
            RichTextBox[] RTBS = new RichTextBox[35]
            {
                richTextBox1,richTextBox2,richTextBox3,richTextBox4,richTextBox5,richTextBox6,richTextBox7,
                richTextBox8,richTextBox9,richTextBox10,richTextBox11,richTextBox12,richTextBox13,richTextBox14,
                richTextBox15,richTextBox16,richTextBox17,richTextBox18,richTextBox19,richTextBox20,richTextBox21,
                richTextBox22,richTextBox23,richTextBox24,richTextBox25,richTextBox26,richTextBox27,richTextBox28,
                richTextBox29,richTextBox30,richTextBox31,richTextBox32,richTextBox33,richTextBox34,richTextBox35,
            };
            for (int i = 0; i < RTBS.Length; i++)
            {
                if (RTBS[i].Text.Length > 0)
                {
                    if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        RTBS[i].SaveFile(saveFileDialog1.FileName);

                    }
                }

            }

        }

        private void BTN_FILELOAD_Click(object sender, EventArgs e)
        {
            Label[] LBLS = new Label[35]
            {
                this.label1, this.label2,this.label3,this.label4,this.label5,this.label6,this.label7,
                this.label8,this.label9,this.label10,this.label11,this.label12,this.label13,this.label14,
                this.label15,this.label16,this.label17,this.label18,this.label19,this.label20,this.label21,
                this.label22,this.label23,this.label24,this.label25,this.label26,this.label27,this.label28,
                this.label29,this.label30,this.label31,this.label32,this.label33,this.label34,this.label35,
            };
            RichTextBox[] RTBS = new RichTextBox[35]
            {
                richTextBox1,richTextBox2,richTextBox3,richTextBox4,richTextBox5,richTextBox6,richTextBox7,
                richTextBox8,richTextBox9,richTextBox10,richTextBox11,richTextBox12,richTextBox13,richTextBox14,
                richTextBox15,richTextBox16,richTextBox17,richTextBox18,richTextBox19,richTextBox20,richTextBox21,
                richTextBox22,richTextBox23,richTextBox24,richTextBox25,richTextBox26,richTextBox27,richTextBox28,
                richTextBox29,richTextBox30,richTextBox31,richTextBox32,richTextBox33,richTextBox34,richTextBox35,
            };
            for (int i = 0; i < RTBS.Length; i++)
            {
                if (RTBS[i].Text.Length > 0)
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        RTBS[i].LoadFile(openFileDialog1.FileName);
                    }
                }
            }
        }

        private void BTN_TODAY_Click(object sender, EventArgs e)
        {
            MyDT.SetDate(DateTime.Now.Date);
            INIT();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBL_TIME.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
