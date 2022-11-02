using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnReSet_Click(object sender, EventArgs e)
        {

            txtResult.Text = string.Empty;
            int[] Ans = GetAns();

            
        }

        private int[] GetAns()
        {
            
            int[] RandomNumber = new int[4];
            Random rdm = new Random();

            for (int i = 0; i < 4; i++)
            {
                RandomNumber[i] = rdm.Next(0, 10);

                for (int j = 0; j < i; j++)
                {

                    while (RandomNumber[j] == RandomNumber[i])
                    {
                        RandomNumber[i] = rdm.Next(0, 10);
                    }
                }
            }
            return RandomNumber;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int Number;

            try
            {
                Number = GetCondition();
                string result = CheckAns(Number);
                txtResult.Text = result; 

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string CheckAns(Number)
        {
            //todo 陣列對答案,if數字對給B字串,else if位置對給A字串
        }

        private int GetCondition()
        {
            string input = txtEnter.Text;
            int WordLimit = 4;
            
            bool isInt = int.TryParse(input, out int Number);
            int num01 = Number.ToString().Length; 
            int[] num02 = new int[Number];

            if (isInt == false)
            {
                throw new Exception("格式不符,請輸入正整數");
            }
            if (num01 != WordLimit)
            {
                throw new Exception("格式不符,請輸入四位數字");
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (num02[j] == num02[i])
                    {
                        throw new Exception("格式不符,請輸入不同數字");
                    }
                    
                }
            }

            return Number;
        }

    }
}
