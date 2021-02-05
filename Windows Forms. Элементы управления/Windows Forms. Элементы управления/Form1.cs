using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Windows_Forms.Элементы_управления
{
   
    public partial class Form1 : Form
    {
        static Processor Processor = new Processor();

        Computer Computer = new Computer(Processor);
        
        int priceComp = 0;
        int countComp = 0;

        public Form1()
        {
           

            InitializeComponent();
           
            comboBox1.Click += delegate
            {
                comboBox1.BackColor = Color.White;
                
            };
            comboBox2.Click += delegate
            {
                comboBox2.BackColor = Color.White;

            };
            textBox1.Click += delegate
            {
                textBox1.BackColor = Color.White;
                textBox1.Clear();
            };
            textBox2.Click += delegate
            {
                textBox2.BackColor = Color.White;
                textBox2.Clear();

            };
            textBox3.Click += delegate
            {
                textBox3.BackColor = Color.White;
                textBox3.Clear();
            };
            textBox4.Click += delegate
            {
                textBox4.BackColor = Color.White;
                textBox4.Clear();
            };
            textBox5.Click += delegate
            {
                textBox5.BackColor = Color.White;
                textBox5.Clear();
            };
            numericUpDown1.Click += delegate
            {
                numericUpDown1.BackColor = Color.White;
                
            };
            numericUpDown2.Click += delegate
            {
                numericUpDown2.BackColor = Color.White;

            };

            comboBox1.Items.AddRange(new string[] { "3", "4", "5", "6" });
            comboBox2.Items.AddRange(new string[] { "IBM", "Microsoft", "BogdevichInd", "SergioCorp" });
            
            listBox1.Items.AddRange(new[] { "1000", "20000", "3000" });

        }

        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
               
            Processor.model = textBox1.Text;
            Console.WriteLine(Processor.model);
           
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            
        
            StringBuilder StrBldr = new StringBuilder();

            if (numericUpDown1.Value==0)
            {
                numericUpDown1.BackColor = Color.Red;

            }
            if (numericUpDown2.Value == 0)
            {
                numericUpDown2.BackColor = Color.Red;

            }
            if (comboBox1.Text == "")
            {
                comboBox1.BackColor = Color.Red;
                
            }
            if (comboBox2.Text == "")
            {
                comboBox2.BackColor = Color.Red;
                
            }
            if (textBox1.TextLength == 0) {
                textBox1.BackColor = Color.Red;
                textBox1.Text = "Нет значений";
            }
            if (textBox2.TextLength == 0)
            {
                textBox2.BackColor = Color.Red;
                textBox2.Text = "Нет значений";

            }
            if (textBox3.TextLength == 0)
            {
                textBox3.BackColor = Color.Red;
                textBox3.Text = "Нет значений";
            }
            if (textBox4.TextLength == 0)
            {
                textBox4.BackColor = Color.Red;
                textBox4.Text = "Нет значений";
            }
            if (textBox5.TextLength == 0)
            {
                textBox5.BackColor = Color.Red;
                textBox5.Text = "Нет значений";
            }

            StrBldr.AppendLine("Модель процессора - "+ Computer.processor.model);
            StrBldr.AppendLine("Тип компьютера  - "+Computer.type);
            StrBldr.AppendLine("ОЗУ  - "+ Computer.RAM);
            StrBldr.AppendLine("Тип ОЗУ - " + Computer.RAMType);
            StrBldr.AppendLine("Тип диска  - "+ Computer.DiskType);
            StrBldr.AppendLine("Размер диска  - "+ Computer.Disk);
            StrBldr.AppendLine("Дата приобретения - "+ Computer.Date);
            StrBldr.AppendLine("Количество ядер процессора - " + Computer.processor.numEd);
            StrBldr.AppendLine("Создатель процессора - " + Computer.processor.creator);
            StrBldr.AppendLine("Серия процессора - " + Computer.processor.serialNum);
            StrBldr.AppendLine("Частота процессора - " + Computer.processor.freq);
            StrBldr.AppendLine("Максимальная частота процессора - " + Computer.processor.maxFreq);
            if (radioButton2.Checked) 
            {
                Computer.processor.Architech = 32;
                StrBldr.AppendLine("Разрядность архитектуры- " + Computer.processor.Architech);
            }
            else if (radioButton3.Checked)
            {
                Computer.processor.Architech = 64;
                StrBldr.AppendLine("Разрядность архитектуры- " + Computer.processor.Architech);
            }



            label1.Text = Convert.ToString(StrBldr);
            Serializer serializer = new Serializer();
            serializer.MyXMLSerializer<Computer>(Computer);
            

           

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Computer.type = textBox3.Text;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Computer.RAM = (int)numericUpDown1.Value;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Computer.RAMType = textBox2.Text;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Computer.Disk = (int)numericUpDown2.Value;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Computer.DiskType = textBox4.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Computer.Date = dateTimePicker1.Value;
        }

        

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Computer.processor.numEd = Convert.ToInt32(comboBox1.SelectedItem.ToString());

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Computer.processor.creator = comboBox2.SelectedItem.ToString();
            countComp = (int)numericUpDown3.Value;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try { Computer.processor.serialNum = Convert.ToInt32(textBox5.Text); }
            catch {
                
                textBox5.Clear();
                 }
           
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Computer.processor.freq = Convert.ToInt32(listBox1.SelectedItem.ToString());
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            countComp = (int)numericUpDown3.Value;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

           
        }

        private void label16_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Computer.processor.creator == "IBM")
                priceComp = 1000;
            if (Computer.processor.creator == "Microsoft")
                priceComp = 2000;
            if (Computer.processor.creator == "BogdevichInd")
                priceComp = 4;
            if (Computer.processor.creator == "SergioComp")
                priceComp = 3;
            label15.Text = ("Цена компьютера - " + priceComp + "\n" + "Общая цена - " + priceComp * countComp);
        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }
    }
    public class Processor 
    {
        public int serialNum, freq=1000, maxFreq=20000, Architech, Size,numEd;
        public string creator,  model;
    
    }

    public class Computer
    {
        public Computer()
        {

        }
        public string type, proc, videocard, RAMType, DiskType;
        public DateTime Date;
        public int RAM, Disk;
        public Processor processor;
        public Computer(Processor processor)
        {
            this.processor = processor;
        }



    }
    public class Serializer
    {
        public void MyXMLSerializer<T>(T obj)
        {
            Type type = obj.GetType();
            XmlSerializer xmlSerializer = new XmlSerializer(type);
            using (FileStream fs = new FileStream("xmlObj.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, obj);
                fs.Close();
            }

        }
        public Computer MyXMLDeserializer<T>(T obj)
        {
            Type type = obj.GetType();
            XmlSerializer xmlSerializer = new XmlSerializer(type);
            using (FileStream fs = new FileStream("xmlObj.xml", FileMode.OpenOrCreate))
            {
                var restObj = xmlSerializer.Deserialize(fs) as Computer;
                fs.Close();
                return (restObj);
            }
        }
    }
}
