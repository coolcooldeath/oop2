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
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace Windows_Forms.Элементы_управления
{

    public partial class Form1 : Form
    {
        static Processor Processor = new Processor();
        string type, RAMType, DiskType;
        DateTime Date;
        int RAM, Disk;
        Videocard videocard1 = new GtxVideocard();
        
        



        static Builder builder = new Builder();
        ComputerDirector ComputerDirector = new ComputerDirector(builder);


        DezignDirector dezignDirector = new DezignDirector();
        


        Computer[] comp = new Computer[10];
        Processor[] proc = new Processor[10];
        int priceComp = 0;
        int countComp = 0;
        int it = 0;
        
        public Form1()
        {

            
            InitializeComponent();

            dezignDirector.Start(Color.AliceBlue, Color.BlanchedAlmond);
            comboBox1.Click += delegate
            {
                comboBox1.BackColor = dezignDirector.userDezign.ClearColor;

            };
            comboBox2.Click += delegate
            {
                comboBox2.BackColor = dezignDirector.userDezign.ClearColor;

            };
            textBox1.Click += delegate
            {
                textBox1.BackColor = dezignDirector.userDezign.ClearColor;
                textBox1.Clear();
            };
            textBox2.Click += delegate
            {
                textBox2.BackColor = dezignDirector.userDezign.ClearColor;
                textBox2.Clear();

            };
            textBox3.Click += delegate
            {
                textBox3.BackColor = dezignDirector.userDezign.ClearColor;
                textBox3.Clear();
            };
            
            textBox5.Click += delegate
            {
                textBox5.BackColor = dezignDirector.userDezign.ClearColor;
                textBox5.Clear();
            };
            numericUpDown1.Click += delegate
            {
                numericUpDown1.BackColor = dezignDirector.userDezign.ClearColor;

            };
            numericUpDown2.Click += delegate
            {
                numericUpDown2.BackColor = dezignDirector.userDezign.ClearColor;

            };

            comboBox1.Items.AddRange(new string[] { "3", "4", "5", "6" });
            comboBox2.Items.AddRange(new string[] { "IBM", "Microsoft", "BogdevichInd", "Corp", "Codr" });
            comboBox3.Items.AddRange(new string[] { "HDD", "SSD"});
            listBox1.Items.AddRange(new[] { "1000", "20000", "3000" });
            
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            Processor.model = textBox1.Text;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            videocard1 = new GTX(videocard1);
            label25.Text = videocard1.Name;
            videocard1.Cost = 1000;
            Memento memento = videocard1.SaveState();
            videocard1.Cost -= 100;
            MessageBox.Show("Сохраненная цена - "+memento.Cost);
            MessageBox.Show("Новая цена - "+ videocard1.Cost);

            StringBuilder StrBldr = new StringBuilder();

            if (numericUpDown1.Value == 0)
            {
                numericUpDown1.BackColor = dezignDirector.userDezign.ErrorColor;

            }
            if (numericUpDown2.Value == 0)
            {
                numericUpDown2.BackColor = dezignDirector.userDezign.ErrorColor;

            }
            if (comboBox1.Text == "")
            {
                comboBox1.BackColor = dezignDirector.userDezign.ErrorColor;

            }
            if (comboBox2.Text == "")
            {
                comboBox2.BackColor = dezignDirector.userDezign.ErrorColor;

            }
            if (textBox1.TextLength == 0) {
                textBox1.BackColor = dezignDirector.userDezign.ErrorColor;
                textBox1.Text = "Нет значений";
            }
            if (textBox2.TextLength == 0)
            {
                textBox2.BackColor = dezignDirector.userDezign.ErrorColor;
                textBox2.Text = "Нет значений";

            }
            if (textBox3.TextLength == 0)
            {
                textBox3.BackColor = dezignDirector.userDezign.ErrorColor;
                textBox3.Text = "Нет значений";
            }
           
            if (textBox5.TextLength == 0)
            {
                textBox5.BackColor = dezignDirector.userDezign.ErrorColor;
                textBox5.Text = "Нет значений";
            }

            StrBldr.AppendLine("Модель процессора - " + Processor.model);
            StrBldr.AppendLine("Тип компьютера  - " + type);
            StrBldr.AppendLine("ОЗУ  - " + RAM);
            StrBldr.AppendLine("Тип ОЗУ - " + RAMType);
            StrBldr.AppendLine("Тип диска  - " + DiskType);
            StrBldr.AppendLine("Размер диска  - " + Disk);
            StrBldr.AppendLine("Дата приобретения - " + Date);
            StrBldr.AppendLine("Количество ядер процессора - " + Processor.numEd);
            StrBldr.AppendLine("Создатель процессора - " + Processor.creator);
            StrBldr.AppendLine("Серия процессора - " + Processor.serialNum);
            StrBldr.AppendLine("Частота процессора - " + Processor.freq);
            StrBldr.AppendLine("Максимальная частота процессора - " + Processor.maxFreq);
           
            if (radioButton2.Checked)
            {
               
                Processor.Architech= new Architech(StateArchitecture.X32);
                StrBldr.AppendLine("Разрядность архитектуры- " + Processor.Architech.GetResult());
            }
            else if (radioButton3.Checked)
            {
                Processor.Architech = new Architech(StateArchitecture.X64);
                StrBldr.AppendLine("Разрядность архитектуры- " + Processor.Architech.GetResult());
            }
            ComputerDirector.BuildComputer(Date,Processor,RAMType,type,RAM,DiskType,Disk);
             Computer Computer =  builder.GetResult();

            Validata validata = new Validata();
            
            if(validata.Validater(Processor)) {
                if (Regex.Match(type, @"^[A-Za-z]+$").Success)
                {
                    if (Regex.Match(RAMType, @"^[A-Za-z]+$").Success)
                    {
                        MessageBox.Show("Валидация пройдена");
                        label1.Text = Convert.ToString(StrBldr);
                        Serializer serializer = new Serializer();
                        serializer.MyXMLSerializer<Computer>(Computer, "Computer" + it + ".xml");
                      /*  serializer.MyXMLSerializer<Computer>(Computer.Clone(), "ComputerClone " + it + ".xml");*/
                        serializer.MyXMLSerializer<Processor>(Computer.processor, "Processor" + it + ".xml");

                        for (int i = 0; i <= it; i++)
                        {
                            comp[i] = serializer.MyXMLDeserializer<Computer>(Computer, "Computer" + i + ".xml");
                            proc[i] = serializer.MyXMLProcDeserializer<Processor>(Computer.processor, "Processor" + i + ".xml");

                        }
                        

                        it++;
                    }
                    else MessageBox.Show("Тип ОЗУ должен состоять только из латинских символов");
                }
                else MessageBox.Show("Тип компьютера должен состоять только из латинских символов");
            }
            else {  }



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            type = textBox3.Text;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            RAM = (int)numericUpDown1.Value;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            RAMType = textBox2.Text;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Disk = (int)numericUpDown2.Value;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Date = dateTimePicker1.Value;
        }



        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           Processor.numEd = Convert.ToInt32(comboBox1.SelectedItem.ToString());

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Processor.creator = comboBox2.SelectedItem.ToString();
            countComp = (int)numericUpDown3.Value;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try { Processor.serialNum = Convert.ToInt32(textBox5.Text); }
            catch {

                textBox5.Clear();
            }

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          Processor.freq = Convert.ToInt32(listBox1.SelectedItem.ToString());
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
            if (Processor.creator == "IBM")
                priceComp = 1000;
            if (Processor.creator == "Microsoft")
                priceComp = 2000;
            if (Processor.creator == "BogdevichInd")
                priceComp = 4;
            if (Processor.creator == "SergioComp")
                priceComp = 3;
            label15.Text = ("Цена компьютера - " + priceComp + "\n" + "Общая цена - " + priceComp * countComp);
        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {



        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {



        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            Button button = new Button();
            App app = new App();
            button.SetCommand(new AppOnComand(app));
            button.PressButton(it);
            button.PressUndo();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < it; i++)
            {
                try
                {
                    if (proc[i].creator.StartsWith(textBox6.Text))
                    {

                        label17.Text += (proc[i].creator) + " Модель - " + (proc[i].model) + " Частота - " + (proc[i].freq) + "\n";
                    }
                }
                catch (Exception) { }
            }
        }



        private void button7_Click(object sender, EventArgs e)
        {
            string pattern = @"\b[M]\w+";
            
                for (int i = 0; i < it; i++)
                {

                if (proc[i].creator == null) { }
                   

                else if (Regex.IsMatch(proc[i].creator, pattern))
                    {
                        label17.Text += (proc[i].creator) + " Модель - " + (proc[i].model) + " Частота - " + (proc[i].freq) + "\n";

                    }
                
                
               

                }
            
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string pattern = @"\b\w+(n)?d(\s|$)";
            
                for (int i = 0; i < it; i++)
                {
                if (proc[i].creator == null) { }


                else
                    if (Regex.IsMatch(proc[i].creator, pattern))
                    {
                        label17.Text +=  (proc[i].creator) + " Модель - " + (proc[i].model) + " Частота - " + (proc[i].freq) + "\n";

                    }

                }
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string pattern = @"\bCo[^d]\w+\b";
           
                for (int i = 0; i < it; i++)
            {
                if (proc[i].creator == null) { }


                else 
                if (Regex.IsMatch(proc[i].creator, pattern))
                {
                    label17.Text += (proc[i].creator) + " Модель - " + (proc[i].model) + " Частота - " + (proc[i].freq)+ "\n";

                }

            }
            
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {
            label17.Text = "";
        }

        private void label22_Click(object sender, EventArgs e)
        {
            label22.Text = "";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < it; i++)
            {

                if (proc[i].model.StartsWith(textBox7.Text))
                {
                    label22.Text += "\n" + (proc[i].model) + " Производитель - " + (proc[i].creator);
                }

            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
            label23.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < it; i++)
            {

                if (comp[i].RAM==numericUpDown4.Value)
                {
                    label23.Text += (comp[i].RAM) + " Тип ОЗУ- " + (comp[i].RAMType) + " Тип - " + (comp[i].type)+ "\n";
                }


            }
        }

       


        


        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           DiskType = comboBox3.SelectedItem.ToString();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Стельмаков Константин");
        }

        private void очисткаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label15.Text = "";
            label17.Text = "";
            label22.Text = "";
            label23.Text = "";
            
        }

        private void тестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(it + " Объектов\n" + DateTime.Now + " Время\n");
        }
    }
    //builder
    public interface IComputerBuilder
    {
       
        void BuildProc(Processor processor);
        void BuildDate(DateTime time);
        void BuildRam(string RAMType);
        void BuildRam(int RAM);
   
        void BuildDisk(string DiskType);
        void BuildDisk(int Disk);
        void BuildType(string Type);
       
    }
    public class Builder : IComputerBuilder
    {
        private readonly Computer _computer = new Computer();

        public void BuildDate(DateTime time)
        {
            this._computer.Date = time;
        }

        public void BuildDisk(string DiskType)
        {
            this._computer.DiskType = DiskType;
        }
    

        public void BuildDisk(int Disk)
        {
            this._computer.Disk= Disk;
        }

        public void BuildProc(Processor processor)
        {
            this._computer.processor = processor;
        }

        public void BuildProc(string Proc)
        {
            this._computer.proc = Proc;
        }

        public void BuildRam(string RAMType)
        {
            this._computer.RAMType = RAMType;
        }
        public void BuildRam(int RAM)
        {
            this._computer.RAM = RAM;
        }

        public void BuildType(string Type)
        {
            this._computer.type = Type;
        }

        public void BuildVideoCard(string videocard)
        {
            this._computer.videocard = videocard;
        }
        

        public Computer GetResult() { return this._computer; }

    }
    public class ComputerDirector {

        private readonly IComputerBuilder _computerBuilder;
        public ComputerDirector(IComputerBuilder computerBuilder)
        {
            this._computerBuilder = computerBuilder;
        }
      /*  private Processor GetProcessor(int Id) { return null; }
        private DateTime GetDate(int Id) { return DateTime.Now; }
        private string GetVideoCard(int Id) { return null; }
        private string GetRam(int Id) { return null; }*/
        public void BuildComputer(DateTime dateTime,Processor processor,string RamType,string type,int Ram,string DiskType,int Disk)
        {
            this._computerBuilder.BuildDate(dateTime);// изменить методы добавления
            this._computerBuilder.BuildProc(processor);
            this._computerBuilder.BuildRam(Ram);
            this._computerBuilder.BuildRam(RamType);
            this._computerBuilder.BuildDisk(Disk);
            this._computerBuilder.BuildDisk(DiskType);
   
        
      
        }
    }
    //builder

    [UserValidationAttribute]
    public class Processor 
    {
        public int serialNum, freq=1000, maxFreq=20000, Size,numEd;
        private Architech architech = new Architech(StateArchitecture.X32);
        public string creator;
       
       
        public string model { get; set; }
        internal Architech Architech { get => architech; set => architech = value; }
    }
    //clone
    interface IСlone<T>
    {
        T Clone();
        
    }
    public class Computer:IСlone<Computer>
    {
        public Computer()
        {

        }
        public Computer(string type, string proc, string videocard, string RAMType, string DiskType, DateTime Date, int RAM, int Disk,Processor processor)
        {
            this.processor = processor;
            this.type = type;
            this.proc = proc;
            this.RAMType = RAMType;
            this.DiskType = DiskType;
            this.Date = Date;
            this.RAM = RAM;
            this.Disk = Disk;

        }
        public string type, proc, videocard, RAMType, DiskType;
        public DateTime Date;
        public int RAM, Disk;
        public Processor processor;

        public Computer Clone()
        {
            return new Computer(this.type, this.proc,this.videocard,this.RAMType,this.DiskType,this.Date,this.RAM,this.Disk,this.processor) ;
        }

        
    }
    //clone
    public class Serializer
    {
        public void MyXMLSerializer<T>(T obj,string name)
        {
            Type type = obj.GetType();
            XmlSerializer xmlSerializer = new XmlSerializer(type);
            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, obj);
                fs.Close();
            }

        }
        public Computer MyXMLDeserializer<T>(T obj,string name)
        {
            Type type = obj.GetType();
            XmlSerializer xmlSerializer = new XmlSerializer(type);
            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate))
            {
                var restObj = xmlSerializer.Deserialize(fs) as Computer;
                fs.Close();
                return (restObj);
            }
        }
        public Processor MyXMLProcDeserializer<T>(T obj, string name)
        {
            Type type = obj.GetType();
            XmlSerializer xmlSerializer = new XmlSerializer(type);
            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate))
            {
                var restObj = xmlSerializer.Deserialize(fs) as Processor;
                fs.Close();
                return (restObj);
            }
        }
    }
    public class Validata
    {
        

        public bool Validater(Processor proc)
        {
            bool valid = false;
            var results = new List<ValidationResult>();
            var context = new ValidationContext(proc);
            if (!Validator.TryValidateObject(proc, context, results, true))
            {
                foreach (var error in results)
                {
                   MessageBox.Show(error.ErrorMessage);
                    
                }
                
            }
            else { valid = true;}

            return valid;
        }
    }
    public class UserValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var value1 = value as Processor;
            if (Regex.Match(value1.model, @"^[A-Za-z]+$").Success)
            {
                
                return true;
            }
            this.ErrorMessage = "Модель состоит только из латинских символов";
            return false;


        }
    }
    // singltone
    class DezignDirector
    {
        public UserDezign userDezign { get; set; }
        public void Start(Color ErrorColor, Color ClearColor)
        {
            userDezign = UserDezign.GetInstance(ErrorColor, ClearColor);
        }
    }
    class UserDezign
    {
        private static UserDezign instance;
        public Color ErrorColor { get; set; }
        public Color ClearColor { get; set; }

        protected UserDezign(Color ErrorColor,Color ClearColor)
        {
            this.ClearColor = ClearColor;
            this.ErrorColor = ErrorColor;
        }
        public static UserDezign GetInstance(Color ErrorColor, Color ClearColor)
        {
            if (instance == null)
            {
                instance = new UserDezign (ErrorColor, ClearColor);
            }
            return instance;
        }

    }

    // singltone

    //factory
    abstract class ComputerA
    { }

    abstract class ComputerB
    { }

    class ComputerA1 : ComputerA
    { }

    class ProcessorB1 : ComputerB
    { }
    abstract class AbstractFactory
    {
        public abstract ComputerA CreateProductA();
        public abstract ComputerB CreateProductB();
    }
    class ComputerFactory : AbstractFactory
    {
        public override ComputerA CreateProductA()
        {
            return new ComputerA1();
        }

        public override ComputerB CreateProductB()
        {
            return new ProcessorB1();
        }
    }
    class ProcessorFactory : AbstractFactory
    {
        public override ComputerA CreateProductA()
        {
            return new ComputerA1();
        }

        public override ComputerB CreateProductB()
        {
            return new ProcessorB1();
        }
    }

    //factory


    //command
    interface ICommand
    {
        void Delete(int it);
        void Exit();
    }

    class App
    {
        public void Delete(int it)
        {
            for (int i = 0; i <= it; i++)
            {
                File.Delete("Computer" + i + ".xml");
                File.Delete("Processor" + i + ".xml");

            }
        }

        public void Exit()
        {
            Application.Exit();
        }
    }
    class AppOnComand:ICommand
    {
        App app;
        public AppOnComand(App app)
        {
            this.app = app;
        }

        
        public void Delete(int it)
        {
            app.Delete(it);
        }

        public void Exit()
        {
            app.Exit();
        }
    }
    class Button
    {
        ICommand command;

        public Button() { }

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void PressButton(int it)
        {
            command.Delete(it);
        }
        public void PressUndo()
        {
            command.Exit();
        }
    }
    //command


    //state
    enum  StateArchitecture
    {
        X32=32,X64=64
    }

    class Architech
    {
        public StateArchitecture state;
        public Architech(StateArchitecture state)
        {
            this.state = state;
        }
       
        public int GetResult()
        {
            if (state == StateArchitecture.X32)
                return 32;
            else
            if (state == StateArchitecture.X64)
                return 64;
            else
                return 0;
        }
    }



    class Client
    {
        public void Request(Target target)
        {
            target.Request();
        }
    }
    // класс, к которому надо адаптировать другой класс   
    class Target
    {
        public virtual void Request()
        { }
    }

    // Адаптер
    class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }

    // Адаптируемый класс
    class Adaptee
    {
        public void SpecificRequest()
        { }
    }




    // Decorator

    abstract class Videocard
    {
        public Memento SaveState()
        {
            MessageBox.Show("Состояние сохранено - " + this.Cost + " цена ");
            return new Memento(this.Cost);
           
        }
        public Videocard(string n)
        {
            this.Name = n;
        }
        public string Name { get; protected set; }
        public abstract int GetCost();
        public int Cost;
    }

    class GtxVideocard : Videocard
    {
        new  int Cost = 1000;
        public GtxVideocard() : base("GTX")
        { }
        public override int GetCost()
        {
            return Cost;
        }
    }
    class Gtx302Videocard : Videocard
    {
        new int Cost = 2000;
        public Gtx302Videocard()
            : base("Gtx302")
        { }
        public override int GetCost()
        {
            return Cost;
        }
    }

    abstract class VideocardDecorator : Videocard
    {
        protected Videocard Videocard;
        public VideocardDecorator(string n, Videocard Videocard) : base(n)
        {
            this.Videocard = Videocard;
        }
    }

    class GTX : VideocardDecorator
    {
        public GTX(Videocard p)
            : base(p.Name + ", версия 324235", p)
        { }

        public override int GetCost()
        {
            return Videocard.GetCost() + 3;
        }
    }
    //Memento

    class Memento
    {
        public int Cost { get; private set; }
        public Memento(int Cost)
        {
            this.Cost = Cost;
           
        }
    }

    //Strategy
    interface IDriver
    {
        void Driver();
    }

    class DriverRf : IDriver
    {
        public void Driver()
        {
            Console.WriteLine("Драйверa rf");
        }
    }

    class DriverSd : IDriver
    {
        public void Driver()
        {
            Console.WriteLine("Драйвера sd");
        }
    }
    //


}
