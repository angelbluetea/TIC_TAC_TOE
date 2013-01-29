using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //グローバル変数、関数
        public static class GROBAL
        {
            public static int wk;
            public static void touch(ref int wk)
            {
                
                //ターンチェンジ
                if (wk == 0)
                {
                    wk = 1;
                    
                }
                else
                {
                    wk = 0;
                    
                }
            }
        }
        //ここまで

        private void Form1_Load(object sender, EventArgs e)
        {
            GROBAL.wk = 0;//ゲーム開始時に0にする。0ならばプレイヤー2のターン1ならばプレイヤー1のターン
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {

            }
            else
            {
               
                if (GROBAL.wk == 0)
                {
                    button1.Text = "○";
                    GROBAL.touch(ref GROBAL.wk);
                }
                else if (GROBAL.wk == 1)
                {
                    button1.Text = "×";
                    GROBAL.touch(ref GROBAL.wk);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text != "")
            {

            }
            else
            {
                
                if (GROBAL.wk == 0)
                {
                    button2.Text = "○";
                    GROBAL.touch(ref GROBAL.wk);
                }
                else if (GROBAL.wk == 1)
                {
                    button2.Text = "×";
                    GROBAL.touch(ref GROBAL.wk);
                }
                else
                {

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text != "")
            {

            }
            else
            {
               
                if (GROBAL.wk == 0)
                {
                    button3.Text = "○";
                    GROBAL.touch(ref GROBAL.wk);
                }
                else if (GROBAL.wk == 1)
                {
                    button3.Text = "×";
                    GROBAL.touch(ref GROBAL.wk);
                }
                else
                {

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text != "")
            {

            }
            else
            {
                
                if (GROBAL.wk == 0)
                {
                    button4.Text = "○";
                    GROBAL.touch(ref GROBAL.wk);
                }
                else if (GROBAL.wk == 1)
                {
                    button4.Text = "×";
                    GROBAL.touch(ref GROBAL.wk);
                }
                else
                {

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text != "")
            {

            }
            else
            {
                
                if (GROBAL.wk == 0)
                {
                    button5.Text = "○";
                    GROBAL.touch(ref GROBAL.wk);
                }
                else if (GROBAL.wk == 1)
                {
                    button5.Text = "×";
                    GROBAL.touch(ref GROBAL.wk);
                }
                else
                {

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text != "")
            {

            }
            else
            {
                
                if (GROBAL.wk == 0)
                {
                    button6.Text = "○";
                    GROBAL.touch(ref GROBAL.wk);
                }
                else if (GROBAL.wk == 1)
                {
                    button6.Text = "×";
                    GROBAL.touch(ref GROBAL.wk);
                }
                else
                {

                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text != "")
            {

            }
            else
            {
                
                if (GROBAL.wk == 0)
                {
                    button7.Text = "○";
                    GROBAL.touch(ref GROBAL.wk);
                }
                else if (GROBAL.wk == 1)
                {
                    button7.Text = "×";
                    GROBAL.touch(ref GROBAL.wk);
                }
                else
                {

                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text != "")
            {

            }
            else
            {
                
                if (GROBAL.wk == 0)
                {
                    button8.Text = "○";
                    GROBAL.touch(ref GROBAL.wk);
                }
                else if (GROBAL.wk == 1)
                {
                    button8.Text = "×";
                    GROBAL.touch(ref GROBAL.wk);
                }
                else
                {

                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text != "")
            {

            }
            else
            {
                
                if (GROBAL.wk == 0)
                {
                    button9.Text = "○";
                    GROBAL.touch(ref GROBAL.wk);
                }
                else if (GROBAL.wk == 1)
                {
                    button9.Text = "×";
                    GROBAL.touch(ref GROBAL.wk);
                }
                else
                {

                }
            }
        }
    }
}
