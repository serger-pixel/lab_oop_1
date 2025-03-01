namespace lab_1
{
    partial class Form1: Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, ""), new ListViewItem.ListViewSubItem(null, "", SystemColors.WindowText, SystemColors.HotTrack, new Font("Segoe UI", 9F)), new ListViewItem.ListViewSubItem(null, "", SystemColors.WindowText, SystemColors.HotTrack, new Font("Segoe UI", 9F)) }, -1);
            ListViewItem listViewItem2 = new ListViewItem("");
            label3 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            speedPanel = new Panel();
            numericUpDown2 = new NumericUpDown();
            label15 = new Label();
            pricePanel = new Panel();
            textBox4 = new TextBox();
            label19 = new Label();
            usercntPanel = new Panel();
            numericUpDown1 = new NumericUpDown();
            label14 = new Label();
            sup5gPanel = new Panel();
            comboBox10 = new ComboBox();
            label20 = new Label();
            routerPanel = new Panel();
            comboBox9 = new ComboBox();
            label13 = new Label();
            namePanel = new Panel();
            textBox2 = new TextBox();
            label9 = new Label();
            familyPanel = new Panel();
            comboBox4 = new ComboBox();
            label16 = new Label();
            button2 = new Button();
            label8 = new Label();
            label7 = new Label();
            comboBox3 = new ComboBox();
            panel3 = new Panel();
            button1 = new Button();
            panel10 = new Panel();
            numericUpDown4 = new NumericUpDown();
            label24 = new Label();
            panel9 = new Panel();
            textBox5 = new TextBox();
            label23 = new Label();
            button3 = new Button();
            panel8 = new Panel();
            numericUpDown3 = new NumericUpDown();
            label22 = new Label();
            label10 = new Label();
            panel7 = new Panel();
            comboBox8 = new ComboBox();
            label21 = new Label();
            comboBox5 = new ComboBox();
            panel6 = new Panel();
            comboBox7 = new ComboBox();
            label18 = new Label();
            label11 = new Label();
            panel5 = new Panel();
            textBox3 = new TextBox();
            label17 = new Label();
            panel4 = new Panel();
            comboBox6 = new ComboBox();
            label12 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            button4 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            button5 = new Button();
            panel2.SuspendLayout();
            speedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            pricePanel.SuspendLayout();
            usercntPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            sup5gPanel.SuspendLayout();
            routerPanel.SuspendLayout();
            namePanel.SuspendLayout();
            familyPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 24);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 4;
            label3.Text = "Кол-во объектов";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 50);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(speedPanel);
            panel2.Controls.Add(pricePanel);
            panel2.Controls.Add(usercntPanel);
            panel2.Controls.Add(sup5gPanel);
            panel2.Controls.Add(routerPanel);
            panel2.Controls.Add(namePanel);
            panel2.Controls.Add(familyPanel);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(comboBox3);
            panel2.Location = new Point(29, 107);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 459);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // speedPanel
            // 
            speedPanel.BackColor = SystemColors.ButtonFace;
            speedPanel.Controls.Add(numericUpDown2);
            speedPanel.Controls.Add(label15);
            speedPanel.Location = new Point(21, 251);
            speedPanel.Margin = new Padding(2, 2, 2, 2);
            speedPanel.Name = "speedPanel";
            speedPanel.Size = new Size(248, 34);
            speedPanel.TabIndex = 10;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(14, 8);
            numericUpDown2.Maximum = new decimal(new int[] { 6144, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 4;
            numericUpDown2.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(143, 10);
            label15.Name = "label15";
            label15.Size = new Size(100, 15);
            label15.TabIndex = 13;
            label15.Text = "Скорость в МБ/с";
            label15.Visible = false;
            // 
            // pricePanel
            // 
            pricePanel.BackColor = SystemColors.ButtonFace;
            pricePanel.Controls.Add(textBox4);
            pricePanel.Controls.Add(label19);
            pricePanel.Location = new Point(20, 152);
            pricePanel.Margin = new Padding(2, 2, 2, 2);
            pricePanel.Name = "pricePanel";
            pricePanel.Size = new Size(248, 34);
            pricePanel.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(14, 8);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            textBox4.Visible = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(133, 8);
            label19.Name = "label19";
            label19.Size = new Size(86, 15);
            label19.TabIndex = 10;
            label19.Text = "Цена за месяц";
            label19.Visible = false;
            // 
            // usercntPanel
            // 
            usercntPanel.BackColor = SystemColors.ButtonFace;
            usercntPanel.Controls.Add(numericUpDown1);
            usercntPanel.Controls.Add(label14);
            usercntPanel.Location = new Point(21, 197);
            usercntPanel.Margin = new Padding(2, 2, 2, 2);
            usercntPanel.Name = "usercntPanel";
            usercntPanel.Size = new Size(248, 44);
            usercntPanel.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(13, 15);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Visible = false;
            // 
            // label14
            // 
            label14.Location = new Point(135, 7);
            label14.Name = "label14";
            label14.Size = new Size(99, 31);
            label14.TabIndex = 12;
            label14.Text = "Кол-во пользователей";
            label14.Visible = false;
            // 
            // sup5gPanel
            // 
            sup5gPanel.BackColor = SystemColors.ButtonFace;
            sup5gPanel.Controls.Add(comboBox10);
            sup5gPanel.Controls.Add(label20);
            sup5gPanel.Location = new Point(21, 296);
            sup5gPanel.Margin = new Padding(2, 2, 2, 2);
            sup5gPanel.Name = "sup5gPanel";
            sup5gPanel.Size = new Size(248, 34);
            sup5gPanel.TabIndex = 10;
            // 
            // comboBox10
            // 
            comboBox10.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox10.FormattingEnabled = true;
            comboBox10.Location = new Point(14, 3);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(121, 23);
            comboBox10.TabIndex = 7;
            comboBox10.Visible = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(143, 6);
            label20.Name = "label20";
            label20.Size = new Size(86, 15);
            label20.TabIndex = 14;
            label20.Text = "Поддержка 5G";
            label20.Visible = false;
            // 
            // routerPanel
            // 
            routerPanel.BackColor = SystemColors.ButtonFace;
            routerPanel.Controls.Add(comboBox9);
            routerPanel.Controls.Add(label13);
            routerPanel.Location = new Point(20, 380);
            routerPanel.Margin = new Padding(2, 2, 2, 2);
            routerPanel.Name = "routerPanel";
            routerPanel.Size = new Size(248, 34);
            routerPanel.TabIndex = 10;
            // 
            // comboBox9
            // 
            comboBox9.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox9.FormattingEnabled = true;
            comboBox9.Location = new Point(17, 8);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(121, 23);
            comboBox9.TabIndex = 7;
            comboBox9.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(150, 8);
            label13.Name = "label13";
            label13.Size = new Size(94, 15);
            label13.TabIndex = 14;
            label13.Text = "Аренда роутера";
            label13.Visible = false;
            // 
            // namePanel
            // 
            namePanel.BackColor = SystemColors.ButtonFace;
            namePanel.Controls.Add(textBox2);
            namePanel.Controls.Add(label9);
            namePanel.Location = new Point(21, 109);
            namePanel.Margin = new Padding(2, 2, 2, 2);
            namePanel.Name = "namePanel";
            namePanel.Size = new Size(248, 34);
            namePanel.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            textBox2.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(126, 8);
            label9.Name = "label9";
            label9.Size = new Size(92, 15);
            label9.TabIndex = 10;
            label9.Text = "Имя оператора";
            label9.Visible = false;
            // 
            // familyPanel
            // 
            familyPanel.BackColor = SystemColors.ButtonFace;
            familyPanel.Controls.Add(comboBox4);
            familyPanel.Controls.Add(label16);
            familyPanel.Location = new Point(21, 336);
            familyPanel.Margin = new Padding(2, 2, 2, 2);
            familyPanel.Name = "familyPanel";
            familyPanel.Size = new Size(248, 34);
            familyPanel.TabIndex = 10;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(14, 8);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 7;
            comboBox4.Visible = false;
            // 
            // label16
            // 
            label16.Location = new Point(143, 2);
            label16.Name = "label16";
            label16.Size = new Size(94, 32);
            label16.TabIndex = 14;
            label16.Text = "Семейный доступ";
            label16.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(97, 421);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(78, 20);
            button2.TabIndex = 2;
            button2.Text = "Создать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 50);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(196, 15);
            label8.TabIndex = 0;
            label8.Text = "Кол-во параметров конструктора:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(97, 6);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(106, 15);
            label7.TabIndex = 0;
            label7.Text = "Создание объекта";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(20, 75);
            comboBox3.Margin = new Padding(2, 2, 2, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(129, 23);
            comboBox3.TabIndex = 1;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(panel10);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(comboBox5);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(382, 107);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(272, 459);
            panel3.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(144, 421);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 11;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ButtonFace;
            panel10.Controls.Add(numericUpDown4);
            panel10.Controls.Add(label24);
            panel10.Location = new Point(9, 251);
            panel10.Margin = new Padding(2, 2, 2, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(248, 34);
            panel10.TabIndex = 10;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(14, 8);
            numericUpDown4.Maximum = new decimal(new int[] { 6144, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(120, 23);
            numericUpDown4.TabIndex = 4;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(143, 10);
            label24.Name = "label24";
            label24.Size = new Size(100, 15);
            label24.TabIndex = 13;
            label24.Text = "Скорость в МБ/с";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ButtonFace;
            panel9.Controls.Add(textBox5);
            panel9.Controls.Add(label23);
            panel9.Location = new Point(8, 152);
            panel9.Margin = new Padding(2, 2, 2, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(248, 34);
            panel9.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(14, 8);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 5;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(133, 8);
            label23.Name = "label23";
            label23.Size = new Size(86, 15);
            label23.TabIndex = 10;
            label23.Text = "Цена за месяц";
            // 
            // button3
            // 
            button3.Location = new Point(23, 421);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(78, 20);
            button3.TabIndex = 2;
            button3.Text = "Изменить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ButtonFace;
            panel8.Controls.Add(numericUpDown3);
            panel8.Controls.Add(label22);
            panel8.Location = new Point(9, 197);
            panel8.Margin = new Padding(2, 2, 2, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(248, 44);
            panel8.TabIndex = 10;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(13, 15);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 3;
            // 
            // label22
            // 
            label22.Location = new Point(135, 7);
            label22.Name = "label22";
            label22.Size = new Size(99, 31);
            label22.TabIndex = 12;
            label22.Text = "Кол-во пользователей";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(67, 6);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(143, 15);
            label10.TabIndex = 0;
            label10.Text = "Редактирование объекта";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonFace;
            panel7.Controls.Add(comboBox8);
            panel7.Controls.Add(label21);
            panel7.Location = new Point(9, 296);
            panel7.Margin = new Padding(2, 2, 2, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(248, 34);
            panel7.TabIndex = 10;
            // 
            // comboBox8
            // 
            comboBox8.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox8.FormattingEnabled = true;
            comboBox8.Items.AddRange(new object[] { "true", "false" });
            comboBox8.Location = new Point(14, 3);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(121, 23);
            comboBox8.TabIndex = 7;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(143, 6);
            label21.Name = "label21";
            label21.Size = new Size(86, 15);
            label21.TabIndex = 14;
            label21.Text = "Поддержка 5G";
            // 
            // comboBox5
            // 
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(9, 75);
            comboBox5.Margin = new Padding(2, 2, 2, 2);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(129, 23);
            comboBox5.TabIndex = 1;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonFace;
            panel6.Controls.Add(comboBox7);
            panel6.Controls.Add(label18);
            panel6.Location = new Point(8, 380);
            panel6.Margin = new Padding(2, 2, 2, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(248, 34);
            panel6.TabIndex = 10;
            // 
            // comboBox7
            // 
            comboBox7.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "true", "false" });
            comboBox7.Location = new Point(17, 8);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(121, 23);
            comboBox7.TabIndex = 7;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(150, 8);
            label18.Name = "label18";
            label18.Size = new Size(94, 15);
            label18.TabIndex = 14;
            label18.Text = "Аренда роутера";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 50);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(91, 15);
            label11.TabIndex = 2;
            label11.Text = "Выбор объекта";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonFace;
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(label17);
            panel5.Location = new Point(9, 109);
            panel5.Margin = new Padding(2, 2, 2, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(248, 34);
            panel5.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(14, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(126, 8);
            label17.Name = "label17";
            label17.Size = new Size(92, 15);
            label17.TabIndex = 10;
            label17.Text = "Имя оператора";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonFace;
            panel4.Controls.Add(comboBox6);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(9, 336);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(248, 34);
            panel4.TabIndex = 10;
            // 
            // comboBox6
            // 
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "true", "false" });
            comboBox6.Location = new Point(14, 8);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(121, 23);
            comboBox6.TabIndex = 7;
            // 
            // label12
            // 
            label12.Location = new Point(143, 2);
            label12.Name = "label12";
            label12.Size = new Size(94, 32);
            label12.TabIndex = 14;
            label12.Text = "Семейный доступ";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader5 });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(701, 111);
            listView1.Margin = new Padding(2, 2, 2, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(414, 239);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Номер теста";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "List, мс";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Array, мс";
            columnHeader3.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Тип теста";
            columnHeader5.Width = 200;
            // 
            // button4
            // 
            button4.Location = new Point(862, 400);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(94, 20);
            button4.TabIndex = 13;
            button4.Text = "Тестировать";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(4, 18);
            radioButton1.Margin = new Padding(2, 2, 2, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(138, 19);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Случайный порядок";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(4, 39);
            radioButton2.Margin = new Padding(2, 2, 2, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(123, 19);
            radioButton2.TabIndex = 15;
            radioButton2.Text = "Последовательно";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(688, 361);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(169, 62);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Тип теста";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4 });
            listView2.Location = new Point(692, 428);
            listView2.Name = "listView2";
            listView2.Size = new Size(269, 189);
            listView2.TabIndex = 17;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Имя оператора";
            columnHeader4.Width = 100;
            // 
            // button5
            // 
            button5.Location = new Point(540, 598);
            button5.Margin = new Padding(2, 2, 2, 2);
            button5.Name = "button5";
            button5.Size = new Size(120, 20);
            button5.TabIndex = 18;
            button5.Text = "Вывод объектов";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 565);
            Controls.Add(button5);
            Controls.Add(listView2);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(listView1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Лабораторная работа № 2.  Использование коллекций.  Делегаты и события. Ермаков, Петровский. Вар - 10";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            speedPanel.ResumeLayout(false);
            speedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            pricePanel.ResumeLayout(false);
            pricePanel.PerformLayout();
            usercntPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            sup5gPanel.ResumeLayout(false);
            sup5gPanel.PerformLayout();
            routerPanel.ResumeLayout(false);
            routerPanel.PerformLayout();
            namePanel.ResumeLayout(false);
            namePanel.PerformLayout();
            familyPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox textBox1;
        private Panel panel2;
        private Label label7;
        private Button button2;
        private Label label8;
        private ComboBox comboBox3;
        private Panel panel3;
        private Button button3;
        private Label label10;
        private ComboBox comboBox5;
        private Label label11;
        private Label lb;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label9;
        private ComboBox comboBox4;
        private TextBox textBox2;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Panel namePanel;
        private Panel pricePanel;
        private TextBox textBox4;
        private Label label19;
        private Panel usercntPanel;
        private Panel speedPanel;
        private Panel sup5gPanel;
        private ComboBox comboBox10;
        private Label label20;
        private Panel routerPanel;
        private ComboBox comboBox9;
        private Label label13;
        private Panel familyPanel;
        private Panel panel10;
        private NumericUpDown numericUpDown4;
        private Label label24;
        private Panel panel9;
        private TextBox textBox5;
        private Label label23;
        private Panel panel8;
        private NumericUpDown numericUpDown3;
        private Label label22;
        private Panel panel7;
        private ComboBox comboBox8;
        private Label label21;
        private Panel panel6;
        private ComboBox comboBox7;
        private Label label18;
        private Panel panel5;
        private TextBox textBox3;
        private Label label17;
        private Panel panel4;
        private ComboBox comboBox6;
        private Label label12;
        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
        private ListView listView1;
        private Button button4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private Button button5;
        private ColumnHeader columnHeader5;
    }
}
