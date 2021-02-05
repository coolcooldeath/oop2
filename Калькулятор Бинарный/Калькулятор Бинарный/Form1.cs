using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор_Бинарный
{
    interface ICalkOperation
    {
        string And(string value1, string value2);  
        string Or(string value1, string value2);  
        string Xor(string value1, string value2);  
        string Not(string value);
        

    }
    
    public partial class Form1 : Form
    {
        public int NumOfLbl;
        public string i2;
        public Form1()
        {
            InitializeComponent();
        }


        int label111, label211;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void label1_Click(object sender, EventArgs e)
        {
            NumOfLbl = 1;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label2.BorderStyle = BorderStyle.Fixed3D;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            NumOfLbl = 2;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(NumOfLbl == 1)
            label1.Text = label1.Text + 0; 
            if (NumOfLbl == 2 )
            label2.Text = label2.Text + 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NumOfLbl == 1 )
                label1.Text = label1.Text + 1;
            if (NumOfLbl == 2 )
                label2.Text = label2.Text + 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //or
            Calculator calculator = new Calculator();
            label3.Text = calculator.Or(label1.Text, label2.Text);
            i2 = label3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //and
            Calculator calculator = new Calculator();
            label3.Text = calculator.And(label1.Text, label2.Text);
            i2 = label3.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //xor
            Calculator calculator = new Calculator();
            label3.Text = calculator.Xor(label1.Text, label2.Text);
            i2 = label3.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //not
            
            Calculator calculator = new Calculator();
            if (NumOfLbl == 1) {
                
                label1.Text = calculator.Not(label1.Text);
                
            }
            
            if (NumOfLbl == 2)
            {
               
                label2.Text = calculator.Not(label2.Text);

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try 
            { 
                label3.Text = Convert.ToString(Convert.ToInt32(i2, 2)); 
            }
            catch
            {
                label5.Text = "Пустое поле";
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try { label3.Text = Convert.ToString(Convert.ToInt32(i2, 2), 8); }
            catch { label5.Text = "Пустое поле"; }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try { label3.Text = Convert.ToString(Convert.ToInt32(i2, 2), 16); }
            catch { label5.Text = "Пустое поле"; }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label3.Text = i2;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    class Calculator : ICalkOperation
    {

        public string And(string value1, string value2)
        {
            int rz = 0;
            StringBuilder str = new StringBuilder();
            if (value1.Length > value2.Length)
            {
                StringBuilder strValue2 = new StringBuilder(value2);
                rz = value1.Length - value2.Length;
                for (int i = 0; i < rz; i++)
                    strValue2.Insert(i, '0');
                for (int i = 0; i < value1.Length; i++)
                {
                    if (value1[i] == '1' && strValue2[i] == '1')
                        str.Append('1');
                    else
                        str.Append('0');
                }

            }

            if (value2.Length > value1.Length)
            {

                StringBuilder strValue1 = new StringBuilder(value1);
                rz = value2.Length - value1.Length;
                for (int i = 0; i < rz; i++)
                    strValue1.Insert(i, '0');

                for (int i = 0; i < value2.Length; i++)
                {
                    if (value2[i] == '1' && strValue1[i] == '1')
                        str.Append('1');
                    else
                        str.Append('0');
                }
            }
            if (value2.Length == value1.Length)
                for (int i = 0; i < value2.Length; i++)
                {
                    if (value2[i] == '1' && value1[i] == '1')
                        str.Append('1');
                    else
                        str.Append('0');
                }



            return Convert.ToString(str);
        }

        public string Not(string value)
        {
            StringBuilder stringBuilder = new StringBuilder();
            
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] == '1')
                        stringBuilder.Append(0);
                    else
                        stringBuilder.Append(1);

                }
           
           
            
            
            return Convert.ToString(stringBuilder);

            
            
        }

        public string Or(string value1,string value2)
        {

            int rz = 0 ;
            StringBuilder str = new StringBuilder();
            if (value1.Length > value2.Length) {
                StringBuilder strValue2 = new StringBuilder(value2);
                rz = value1.Length - value2.Length;
                for (int i = 0; i < rz; i++)
                    strValue2.Insert(i,'0');
                for (int i = 0; i < value1.Length; i++)
                {
                    if (value1[i] == '1' || strValue2[i] == '1')
                        str.Append('1');
                    else
                        str.Append('0');
                }

            }

            if (value2.Length > value1.Length)
            {
                
                StringBuilder strValue1 = new StringBuilder(value1);
                rz = value2.Length - value1.Length;
                for (int i = 0; i < rz; i++)
                    strValue1.Insert(i, '0');
                
                for(int i = 0; i < value2.Length; i++)
                {
                    if (value2[i] == '1' || strValue1[i] == '1')
                        str.Append('1');
                    else
                        str.Append('0');
                }
            }
            if(value2.Length == value1.Length)
                for (int i = 0; i < value2.Length; i++)
                {
                    if (value2[i] == '1' || value1[i] == '1')
                        str.Append('1');
                    else
                        str.Append('0');
                }



            return Convert.ToString(str);
        }

       

        public string Xor(string value1, string value2)
        {
            int rz = 0;
            StringBuilder str = new StringBuilder();
           
            if (value1.Length > value2.Length)
            {
                StringBuilder strValue2 = new StringBuilder(value2);
                rz = value1.Length - value2.Length;
                for (int i = 0; i < rz; i++)
                    strValue2.Insert(i, '0');
                for (int i = 0; i < value1.Length; i++)
                {
                    if (strValue2[i] == '0' && value1[i] == '1' || strValue2[i] == '1' && value1[i] == '0')
                        str.Append('1');
                    else
                        str.Append('0');
                }

            }

            if (value2.Length > value1.Length)
            {

                StringBuilder strValue1 = new StringBuilder(value1);
                rz = value2.Length - value1.Length;
                for (int i = 0; i < rz; i++)
                    strValue1.Insert(i, '0');

                for (int i = 0; i < value2.Length; i++)
                {
                    if (value2[i] == '0' && strValue1[i] == '1' || value2[i] == '1' && strValue1[i] == '0')
                        str.Append('1');
                    else
                        str.Append('0');
                }
            }
            if (value2.Length == value1.Length)
                for (int i = 0; i < value2.Length; i++)
                {
                    if (value2[i] == '0' && value1[i] == '1' || value2[i] == '1' && value1[i] == '0')
                        str.Append('1');
                    else
                        str.Append('0');
                }



            return Convert.ToString(str);
        }
    }
}
