
namespace Windows_Forms.Элементы_управления
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "вывод всей информации";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(40, 34);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(382, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 33);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 22);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(187, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(382, 114);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 33);
            this.textBox3.TabIndex = 12;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Location = new System.Drawing.Point(382, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "модель процессора";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Location = new System.Drawing.Point(382, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "тип компьютера";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(37, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 244);
            this.label1.TabIndex = 15;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Location = new System.Drawing.Point(37, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "размер озу";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(382, 190);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 33);
            this.textBox2.TabIndex = 17;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Location = new System.Drawing.Point(382, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "тип ОЗУ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(40, 83);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 19;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label6
            // 
            this.label6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label6.Location = new System.Drawing.Point(37, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "размер диска (мб)";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(564, 36);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 33);
            this.textBox4.TabIndex = 21;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label7.Location = new System.Drawing.Point(561, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "тип диска";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label8.Location = new System.Drawing.Point(379, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 29);
            this.label8.TabIndex = 24;
            this.label8.Text = "разрядность архитектуры";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(382, 271);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 21);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "32x";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(452, 271);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 21);
            this.radioButton3.TabIndex = 26;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "64x";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label9
            // 
            this.label9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label9.Location = new System.Drawing.Point(37, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "дата покупки";
            // 
            // label10
            // 
            this.label10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label10.Location = new System.Drawing.Point(184, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "количество ядер";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(187, 83);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label11.Location = new System.Drawing.Point(184, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "производитель";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(564, 114);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(145, 33);
            this.textBox5.TabIndex = 32;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label12
            // 
            this.label12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label12.Location = new System.Drawing.Point(564, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "серия процессора";
            // 
            // label13
            // 
            this.label13.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label13.Location = new System.Drawing.Point(564, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "максимальная частота";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(564, 190);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 35;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(40, 191);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown3.TabIndex = 36;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label14
            // 
            this.label14.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label14.Location = new System.Drawing.Point(37, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(211, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "количество компьютеров";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(382, 323);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 17);
            this.label16.TabIndex = 41;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 34);
            this.button2.TabIndex = 44;
            this.button2.Text = "расчет цены";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label15.Location = new System.Drawing.Point(379, 414);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(222, 91);
            this.label15.TabIndex = 45;
            this.label15.Click += new System.EventHandler(this.label15_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
    }
}

