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
            pricePanel = new Panel();
            textBox4 = new TextBox();
            label19 = new Label();
            usercntPanel = new Panel();
            numericUpDown1 = new NumericUpDown();
            label14 = new Label();
            typePanel = new Panel();
            label1 = new Label();
            textBox9 = new TextBox();
            comboBox4 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox10 = new TextBox();
            label5 = new Label();
            label13 = new Label();
            label15 = new Label();
            namePanel = new Panel();
            textBox2 = new TextBox();
            label9 = new Label();
            button2 = new Button();
            label8 = new Label();
            label7 = new Label();
            comboBox3 = new ComboBox();
            panel3 = new Panel();
            button1 = new Button();
            panel9 = new Panel();
            textBox5 = new TextBox();
            label23 = new Label();
            panel6 = new Panel();
            label2 = new Label();
            comboBox6 = new ComboBox();
            textBox7 = new TextBox();
            comboBox2 = new ComboBox();
            textBox8 = new TextBox();
            label12 = new Label();
            label6 = new Label();
            label4 = new Label();
            button3 = new Button();
            panel8 = new Panel();
            numericUpDown3 = new NumericUpDown();
            label22 = new Label();
            label10 = new Label();
            comboBox5 = new ComboBox();
            label11 = new Label();
            panel5 = new Panel();
            textBox3 = new TextBox();
            label17 = new Label();
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
            panel2.SuspendLayout();
            pricePanel.SuspendLayout();
            usercntPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            typePanel.SuspendLayout();
            namePanel.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            panel5.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 40);
            label3.Name = "label3";
            label3.Size = new Size(153, 25);
            label3.TabIndex = 4;
            label3.Text = "Кол-во объектов";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 83);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(pricePanel);
            panel2.Controls.Add(usercntPanel);
            panel2.Controls.Add(typePanel);
            panel2.Controls.Add(namePanel);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(comboBox3);
            panel2.Location = new Point(41, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 765);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // pricePanel
            // 
            pricePanel.BackColor = SystemColors.ButtonFace;
            pricePanel.Controls.Add(textBox4);
            pricePanel.Controls.Add(label19);
            pricePanel.Location = new Point(29, 253);
            pricePanel.Name = "pricePanel";
            pricePanel.Size = new Size(354, 57);
            pricePanel.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(20, 13);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(141, 31);
            textBox4.TabIndex = 5;
            textBox4.Visible = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(190, 13);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(130, 25);
            label19.TabIndex = 10;
            label19.Text = "Цена за месяц";
            label19.Visible = false;
            // 
            // usercntPanel
            // 
            usercntPanel.BackColor = SystemColors.ButtonFace;
            usercntPanel.Controls.Add(numericUpDown1);
            usercntPanel.Controls.Add(label14);
            usercntPanel.Location = new Point(30, 328);
            usercntPanel.Name = "usercntPanel";
            usercntPanel.Size = new Size(354, 73);
            usercntPanel.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(19, 25);
            numericUpDown1.Margin = new Padding(4, 5, 4, 5);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(171, 31);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Visible = false;
            // 
            // label14
            // 
            label14.Location = new Point(193, 12);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(141, 52);
            label14.TabIndex = 12;
            label14.Text = "Кол-во пользователей";
            label14.Visible = false;
            // 
            // typePanel
            // 
            typePanel.BackColor = SystemColors.ButtonFace;
            typePanel.Controls.Add(label1);
            typePanel.Controls.Add(textBox9);
            typePanel.Controls.Add(comboBox4);
            typePanel.Controls.Add(comboBox1);
            typePanel.Controls.Add(textBox10);
            typePanel.Controls.Add(label5);
            typePanel.Controls.Add(label13);
            typePanel.Controls.Add(label15);
            typePanel.Location = new Point(28, 424);
            typePanel.Name = "typePanel";
            typePanel.Size = new Size(355, 258);
            typePanel.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 10;
            label1.Text = "Vpn";
            label1.Click += label2_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(11, 106);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(150, 31);
            textBox9.TabIndex = 11;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(191, 47);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(153, 33);
            comboBox4.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(8, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 33);
            comboBox1.TabIndex = 1;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(14, 153);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(150, 31);
            textBox10.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 9);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 25);
            label5.TabIndex = 10;
            label5.Text = "Спецификация";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(182, 153);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(89, 25);
            label13.TabIndex = 10;
            label13.Text = "Скорость";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(182, 109);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(158, 25);
            label15.TabIndex = 10;
            label15.Text = "Тип подключения";
            // 
            // namePanel
            // 
            namePanel.BackColor = SystemColors.ButtonFace;
            namePanel.Controls.Add(textBox2);
            namePanel.Controls.Add(label9);
            namePanel.Location = new Point(30, 182);
            namePanel.Name = "namePanel";
            namePanel.Size = new Size(354, 57);
            namePanel.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(20, 8);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 31);
            textBox2.TabIndex = 5;
            textBox2.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(180, 13);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(140, 25);
            label9.TabIndex = 10;
            label9.Text = "Имя оператора";
            label9.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(139, 702);
            button2.Name = "button2";
            button2.Size = new Size(111, 33);
            button2.TabIndex = 2;
            button2.Text = "Создать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 83);
            label8.Name = "label8";
            label8.Size = new Size(296, 25);
            label8.TabIndex = 0;
            label8.Text = "Кол-во параметров конструктора:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(139, 10);
            label7.Name = "label7";
            label7.Size = new Size(161, 25);
            label7.TabIndex = 0;
            label7.Text = "Создание объекта";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(29, 125);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(183, 33);
            comboBox3.TabIndex = 1;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(comboBox5);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(546, 178);
            panel3.Name = "panel3";
            panel3.Size = new Size(389, 765);
            panel3.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(206, 702);
            button1.Name = "button1";
            button1.Size = new Size(111, 33);
            button1.TabIndex = 11;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ButtonFace;
            panel9.Controls.Add(textBox5);
            panel9.Controls.Add(label23);
            panel9.Location = new Point(11, 253);
            panel9.Name = "panel9";
            panel9.Size = new Size(354, 57);
            panel9.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(20, 13);
            textBox5.Margin = new Padding(4, 5, 4, 5);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(141, 31);
            textBox5.TabIndex = 5;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(190, 13);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(130, 25);
            label23.TabIndex = 10;
            label23.Text = "Цена за месяц";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonFace;
            panel6.Controls.Add(label2);
            panel6.Controls.Add(comboBox6);
            panel6.Controls.Add(textBox7);
            panel6.Controls.Add(comboBox2);
            panel6.Controls.Add(textBox8);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(13, 424);
            panel6.Name = "panel6";
            panel6.Size = new Size(355, 258);
            panel6.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 10;
            label2.Text = "Vpn";
            label2.Click += label2_Click;
            // 
            // comboBox6
            // 
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(188, 47);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(153, 33);
            comboBox6.TabIndex = 1;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(11, 106);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(150, 31);
            textBox7.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(11, 47);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(153, 33);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged_1;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(14, 153);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(150, 31);
            textBox8.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 9);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(133, 25);
            label12.TabIndex = 10;
            label12.Text = "Спецификация";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(182, 153);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 10;
            label6.Text = "Скорость";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 109);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 10;
            label4.Text = "Тип подключения";
            // 
            // button3
            // 
            button3.Location = new Point(33, 702);
            button3.Name = "button3";
            button3.Size = new Size(111, 33);
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
            panel8.Location = new Point(13, 328);
            panel8.Name = "panel8";
            panel8.Size = new Size(354, 73);
            panel8.TabIndex = 10;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(19, 25);
            numericUpDown3.Margin = new Padding(4, 5, 4, 5);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(171, 31);
            numericUpDown3.TabIndex = 3;
            // 
            // label22
            // 
            label22.Location = new Point(193, 12);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(141, 52);
            label22.TabIndex = 12;
            label22.Text = "Кол-во пользователей";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(96, 10);
            label10.Name = "label10";
            label10.Size = new Size(217, 25);
            label10.TabIndex = 0;
            label10.Text = "Редактирование объекта";
            // 
            // comboBox5
            // 
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(13, 125);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(183, 33);
            comboBox5.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 83);
            label11.Name = "label11";
            label11.Size = new Size(138, 25);
            label11.TabIndex = 2;
            label11.Text = "Выбор объекта";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonFace;
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(label17);
            panel5.Location = new Point(13, 182);
            panel5.Name = "panel5";
            panel5.Size = new Size(354, 57);
            panel5.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(20, 8);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(141, 31);
            textBox3.TabIndex = 5;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(180, 13);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(140, 25);
            label17.TabIndex = 10;
            label17.Text = "Имя оператора";
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
            listView1.Location = new Point(983, 185);
            listView1.Name = "listView1";
            listView1.Size = new Size(608, 396);
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
            button4.Location = new Point(1231, 667);
            button4.Name = "button4";
            button4.Size = new Size(134, 33);
            button4.TabIndex = 13;
            button4.Text = "Тестировать";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(6, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(204, 29);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Случайный порядок";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 65);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(182, 29);
            radioButton2.TabIndex = 15;
            radioButton2.Text = "Последовательно";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(983, 602);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 103);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Тип теста";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4 });
            listView2.Location = new Point(989, 713);
            listView2.Margin = new Padding(4, 5, 4, 5);
            listView2.Name = "listView2";
            listView2.Size = new Size(159, 219);
            listView2.TabIndex = 17;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Имя оператора";
            columnHeader4.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1645, 1136);
            Controls.Add(listView2);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(listView1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Лабораторная работа № 3. Порождающие паттерны. Ермаков, Петровский. Вар - 10";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pricePanel.ResumeLayout(false);
            pricePanel.PerformLayout();
            usercntPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            typePanel.ResumeLayout(false);
            typePanel.PerformLayout();
            namePanel.ResumeLayout(false);
            namePanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Label label14;
        private Label label9;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private Panel namePanel;
        private Panel pricePanel;
        private TextBox textBox4;
        private Label label19;
        private Panel usercntPanel;
        private Panel panel9;
        private TextBox textBox5;
        private Label label23;
        private Panel panel8;
        private NumericUpDown numericUpDown3;
        private Label label22;
        private Panel panel5;
        private TextBox textBox3;
        private Label label17;
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
        private ColumnHeader columnHeader5;
        private Panel panel6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label12;
        private Label label6;
        private Label label4;
        private Label label2;
        private ComboBox comboBox2;
        private Panel typePanel;
        private TextBox textBox9;
        private ComboBox comboBox1;
        private TextBox textBox10;
        private Label label5;
        private Label label13;
        private Label label15;
        private ComboBox comboBox4;
        private ComboBox comboBox6;
        private Label label1;
    }
}
