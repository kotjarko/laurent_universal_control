namespace Laurent_control_app
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
            this.btn_connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_controller1_connected = new System.Windows.Forms.Label();
            this.lbl_controller2_connected = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.relay_1_4 = new System.Windows.Forms.Button();
            this.relay_1_2 = new System.Windows.Forms.Button();
            this.relay_1_3 = new System.Windows.Forms.Button();
            this.relay_1_1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.relay_2_4 = new System.Windows.Forms.Button();
            this.relay_2_2 = new System.Windows.Forms.Button();
            this.relay_2_3 = new System.Windows.Forms.Button();
            this.relay_2_1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.out_2_12 = new System.Windows.Forms.Button();
            this.out_2_10 = new System.Windows.Forms.Button();
            this.out_2_11 = new System.Windows.Forms.Button();
            this.out_2_9 = new System.Windows.Forms.Button();
            this.out_2_8 = new System.Windows.Forms.Button();
            this.out_2_6 = new System.Windows.Forms.Button();
            this.out_2_7 = new System.Windows.Forms.Button();
            this.out_2_5 = new System.Windows.Forms.Button();
            this.out_2_4 = new System.Windows.Forms.Button();
            this.out_2_2 = new System.Windows.Forms.Button();
            this.out_2_3 = new System.Windows.Forms.Button();
            this.out_2_1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.out_1_12 = new System.Windows.Forms.Button();
            this.out_1_10 = new System.Windows.Forms.Button();
            this.out_1_11 = new System.Windows.Forms.Button();
            this.out_1_9 = new System.Windows.Forms.Button();
            this.out_1_8 = new System.Windows.Forms.Button();
            this.out_1_6 = new System.Windows.Forms.Button();
            this.out_1_7 = new System.Windows.Forms.Button();
            this.out_1_5 = new System.Windows.Forms.Button();
            this.out_1_4 = new System.Windows.Forms.Button();
            this.out_1_2 = new System.Windows.Forms.Button();
            this.out_1_3 = new System.Windows.Forms.Button();
            this.out_1_1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.in_1_6 = new System.Windows.Forms.Button();
            this.in_1_5 = new System.Windows.Forms.Button();
            this.in_1_4 = new System.Windows.Forms.Button();
            this.in_1_2 = new System.Windows.Forms.Button();
            this.in_1_3 = new System.Windows.Forms.Button();
            this.in_1_1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.in_2_6 = new System.Windows.Forms.Button();
            this.in_2_5 = new System.Windows.Forms.Button();
            this.in_2_4 = new System.Windows.Forms.Button();
            this.in_2_2 = new System.Windows.Forms.Button();
            this.in_2_3 = new System.Windows.Forms.Button();
            this.in_2_1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(450, 25);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(154, 23);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Установить соединение";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Статус соединения с контроллерами";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_controller1_connected
            // 
            this.lbl_controller1_connected.AutoSize = true;
            this.lbl_controller1_connected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_controller1_connected.Location = new System.Drawing.Point(223, 30);
            this.lbl_controller1_connected.Name = "lbl_controller1_connected";
            this.lbl_controller1_connected.Size = new System.Drawing.Size(83, 16);
            this.lbl_controller1_connected.TabIndex = 3;
            this.lbl_controller1_connected.Text = "Нет связи";
            // 
            // lbl_controller2_connected
            // 
            this.lbl_controller2_connected.AutoSize = true;
            this.lbl_controller2_connected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_controller2_connected.Location = new System.Drawing.Point(341, 30);
            this.lbl_controller2_connected.Name = "lbl_controller2_connected";
            this.lbl_controller2_connected.Size = new System.Drawing.Size(83, 16);
            this.lbl_controller2_connected.TabIndex = 4;
            this.lbl_controller2_connected.Text = "Нет связи";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_connect);
            this.panel1.Controls.Add(this.lbl_controller2_connected);
            this.panel1.Controls.Add(this.lbl_controller1_connected);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 83);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Общее управление контроллерами";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 124);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.relay_1_4);
            this.panel4.Controls.Add(this.relay_1_2);
            this.panel4.Controls.Add(this.relay_1_3);
            this.panel4.Controls.Add(this.relay_1_1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(8, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(366, 88);
            this.panel4.TabIndex = 16;
            // 
            // relay_1_4
            // 
            this.relay_1_4.Location = new System.Drawing.Point(186, 56);
            this.relay_1_4.Name = "relay_1_4";
            this.relay_1_4.Size = new System.Drawing.Size(48, 23);
            this.relay_1_4.TabIndex = 14;
            this.relay_1_4.Text = "---";
            this.relay_1_4.UseVisualStyleBackColor = true;
            this.relay_1_4.Click += new System.EventHandler(this.on_btn_relay_click);
            // 
            // relay_1_2
            // 
            this.relay_1_2.Location = new System.Drawing.Point(186, 27);
            this.relay_1_2.Name = "relay_1_2";
            this.relay_1_2.Size = new System.Drawing.Size(48, 23);
            this.relay_1_2.TabIndex = 13;
            this.relay_1_2.Text = "---";
            this.relay_1_2.UseVisualStyleBackColor = true;
            this.relay_1_2.Click += new System.EventHandler(this.on_btn_relay_click);
            // 
            // relay_1_3
            // 
            this.relay_1_3.Location = new System.Drawing.Point(12, 56);
            this.relay_1_3.Name = "relay_1_3";
            this.relay_1_3.Size = new System.Drawing.Size(48, 23);
            this.relay_1_3.TabIndex = 12;
            this.relay_1_3.Text = "---";
            this.relay_1_3.UseVisualStyleBackColor = true;
            this.relay_1_3.Click += new System.EventHandler(this.on_btn_relay_click);
            // 
            // relay_1_1
            // 
            this.relay_1_1.Location = new System.Drawing.Point(12, 27);
            this.relay_1_1.Name = "relay_1_1";
            this.relay_1_1.Size = new System.Drawing.Size(48, 23);
            this.relay_1_1.TabIndex = 11;
            this.relay_1_1.Text = "---";
            this.relay_1_1.UseVisualStyleBackColor = true;
            this.relay_1_1.Click += new System.EventHandler(this.on_btn_relay_click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Контроллер 1:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.relay_2_4);
            this.panel3.Controls.Add(this.relay_2_2);
            this.panel3.Controls.Add(this.relay_2_3);
            this.panel3.Controls.Add(this.relay_2_1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(394, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 88);
            this.panel3.TabIndex = 15;
            // 
            // relay_2_4
            // 
            this.relay_2_4.Location = new System.Drawing.Point(186, 56);
            this.relay_2_4.Name = "relay_2_4";
            this.relay_2_4.Size = new System.Drawing.Size(48, 23);
            this.relay_2_4.TabIndex = 14;
            this.relay_2_4.Text = "---";
            this.relay_2_4.UseVisualStyleBackColor = true;
            this.relay_2_4.Click += new System.EventHandler(this.on_btn_relay_click);
            // 
            // relay_2_2
            // 
            this.relay_2_2.Location = new System.Drawing.Point(186, 27);
            this.relay_2_2.Name = "relay_2_2";
            this.relay_2_2.Size = new System.Drawing.Size(48, 23);
            this.relay_2_2.TabIndex = 13;
            this.relay_2_2.Text = "---";
            this.relay_2_2.UseVisualStyleBackColor = true;
            this.relay_2_2.Click += new System.EventHandler(this.on_btn_relay_click);
            // 
            // relay_2_3
            // 
            this.relay_2_3.Location = new System.Drawing.Point(12, 56);
            this.relay_2_3.Name = "relay_2_3";
            this.relay_2_3.Size = new System.Drawing.Size(48, 23);
            this.relay_2_3.TabIndex = 12;
            this.relay_2_3.Text = "---";
            this.relay_2_3.UseVisualStyleBackColor = true;
            this.relay_2_3.Click += new System.EventHandler(this.on_btn_relay_click);
            // 
            // relay_2_1
            // 
            this.relay_2_1.Location = new System.Drawing.Point(12, 27);
            this.relay_2_1.Name = "relay_2_1";
            this.relay_2_1.Size = new System.Drawing.Size(48, 23);
            this.relay_2_1.TabIndex = 11;
            this.relay_2_1.Text = "---";
            this.relay_2_1.UseVisualStyleBackColor = true;
            this.relay_2_1.Click += new System.EventHandler(this.on_btn_relay_click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Контроллер 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Управление реле";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(12, 231);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(760, 260);
            this.panel5.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.out_2_12);
            this.panel7.Controls.Add(this.out_2_10);
            this.panel7.Controls.Add(this.out_2_11);
            this.panel7.Controls.Add(this.out_2_9);
            this.panel7.Controls.Add(this.out_2_8);
            this.panel7.Controls.Add(this.out_2_6);
            this.panel7.Controls.Add(this.out_2_7);
            this.panel7.Controls.Add(this.out_2_5);
            this.panel7.Controls.Add(this.out_2_4);
            this.panel7.Controls.Add(this.out_2_2);
            this.panel7.Controls.Add(this.out_2_3);
            this.panel7.Controls.Add(this.out_2_1);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(389, 27);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(366, 202);
            this.panel7.TabIndex = 17;
            // 
            // out_2_12
            // 
            this.out_2_12.Location = new System.Drawing.Point(186, 172);
            this.out_2_12.Name = "out_2_12";
            this.out_2_12.Size = new System.Drawing.Size(48, 23);
            this.out_2_12.TabIndex = 22;
            this.out_2_12.Text = "---";
            this.out_2_12.UseVisualStyleBackColor = true;
            this.out_2_12.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_2_10
            // 
            this.out_2_10.Location = new System.Drawing.Point(186, 143);
            this.out_2_10.Name = "out_2_10";
            this.out_2_10.Size = new System.Drawing.Size(48, 23);
            this.out_2_10.TabIndex = 21;
            this.out_2_10.Text = "---";
            this.out_2_10.UseVisualStyleBackColor = true;
            this.out_2_10.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_2_11
            // 
            this.out_2_11.Location = new System.Drawing.Point(12, 172);
            this.out_2_11.Name = "out_2_11";
            this.out_2_11.Size = new System.Drawing.Size(48, 23);
            this.out_2_11.TabIndex = 20;
            this.out_2_11.Text = "---";
            this.out_2_11.UseVisualStyleBackColor = true;
            this.out_2_11.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_2_9
            // 
            this.out_2_9.Location = new System.Drawing.Point(12, 143);
            this.out_2_9.Name = "out_2_9";
            this.out_2_9.Size = new System.Drawing.Size(48, 23);
            this.out_2_9.TabIndex = 19;
            this.out_2_9.Text = "---";
            this.out_2_9.UseVisualStyleBackColor = true;
            this.out_2_9.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_2_8
            // 
            this.out_2_8.Location = new System.Drawing.Point(186, 114);
            this.out_2_8.Name = "out_2_8";
            this.out_2_8.Size = new System.Drawing.Size(48, 23);
            this.out_2_8.TabIndex = 18;
            this.out_2_8.Text = "---";
            this.out_2_8.UseVisualStyleBackColor = true;
            this.out_2_8.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_2_6
            // 
            this.out_2_6.Location = new System.Drawing.Point(186, 85);
            this.out_2_6.Name = "out_2_6";
            this.out_2_6.Size = new System.Drawing.Size(48, 23);
            this.out_2_6.TabIndex = 17;
            this.out_2_6.Text = "---";
            this.out_2_6.UseVisualStyleBackColor = true;
            this.out_2_6.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_2_7
            // 
            this.out_2_7.Location = new System.Drawing.Point(12, 114);
            this.out_2_7.Name = "out_2_7";
            this.out_2_7.Size = new System.Drawing.Size(48, 23);
            this.out_2_7.TabIndex = 16;
            this.out_2_7.Text = "---";
            this.out_2_7.UseVisualStyleBackColor = true;
            this.out_2_7.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_2_5
            // 
            this.out_2_5.Location = new System.Drawing.Point(12, 85);
            this.out_2_5.Name = "out_2_5";
            this.out_2_5.Size = new System.Drawing.Size(48, 23);
            this.out_2_5.TabIndex = 15;
            this.out_2_5.Text = "---";
            this.out_2_5.UseVisualStyleBackColor = true;
            this.out_2_5.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_2_4
            // 
            this.out_2_4.Location = new System.Drawing.Point(186, 56);
            this.out_2_4.Name = "out_2_4";
            this.out_2_4.Size = new System.Drawing.Size(48, 23);
            this.out_2_4.TabIndex = 14;
            this.out_2_4.Text = "---";
            this.out_2_4.UseVisualStyleBackColor = true;
            this.out_2_4.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_2_2
            // 
            this.out_2_2.Location = new System.Drawing.Point(186, 27);
            this.out_2_2.Name = "out_2_2";
            this.out_2_2.Size = new System.Drawing.Size(48, 23);
            this.out_2_2.TabIndex = 13;
            this.out_2_2.Text = "---";
            this.out_2_2.UseVisualStyleBackColor = true;
            this.out_2_2.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_2_3
            // 
            this.out_2_3.Location = new System.Drawing.Point(12, 56);
            this.out_2_3.Name = "out_2_3";
            this.out_2_3.Size = new System.Drawing.Size(48, 23);
            this.out_2_3.TabIndex = 12;
            this.out_2_3.Text = "---";
            this.out_2_3.UseVisualStyleBackColor = true;
            this.out_2_3.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_2_1
            // 
            this.out_2_1.Location = new System.Drawing.Point(12, 27);
            this.out_2_1.Name = "out_2_1";
            this.out_2_1.Size = new System.Drawing.Size(48, 23);
            this.out_2_1.TabIndex = 11;
            this.out_2_1.Text = "---";
            this.out_2_1.UseVisualStyleBackColor = true;
            this.out_2_1.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(9, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Контроллер 2:";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.out_1_12);
            this.panel6.Controls.Add(this.out_1_10);
            this.panel6.Controls.Add(this.out_1_11);
            this.panel6.Controls.Add(this.out_1_9);
            this.panel6.Controls.Add(this.out_1_8);
            this.panel6.Controls.Add(this.out_1_6);
            this.panel6.Controls.Add(this.out_1_7);
            this.panel6.Controls.Add(this.out_1_5);
            this.panel6.Controls.Add(this.out_1_4);
            this.panel6.Controls.Add(this.out_1_2);
            this.panel6.Controls.Add(this.out_1_3);
            this.panel6.Controls.Add(this.out_1_1);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(8, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(366, 202);
            this.panel6.TabIndex = 16;
            // 
            // out_1_12
            // 
            this.out_1_12.Location = new System.Drawing.Point(186, 172);
            this.out_1_12.Name = "out_1_12";
            this.out_1_12.Size = new System.Drawing.Size(48, 23);
            this.out_1_12.TabIndex = 22;
            this.out_1_12.Text = "---";
            this.out_1_12.UseVisualStyleBackColor = true;
            this.out_1_12.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_1_10
            // 
            this.out_1_10.Location = new System.Drawing.Point(186, 143);
            this.out_1_10.Name = "out_1_10";
            this.out_1_10.Size = new System.Drawing.Size(48, 23);
            this.out_1_10.TabIndex = 21;
            this.out_1_10.Text = "---";
            this.out_1_10.UseVisualStyleBackColor = true;
            this.out_1_10.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_1_11
            // 
            this.out_1_11.Location = new System.Drawing.Point(12, 172);
            this.out_1_11.Name = "out_1_11";
            this.out_1_11.Size = new System.Drawing.Size(48, 23);
            this.out_1_11.TabIndex = 20;
            this.out_1_11.Text = "---";
            this.out_1_11.UseVisualStyleBackColor = true;
            this.out_1_11.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_1_9
            // 
            this.out_1_9.Location = new System.Drawing.Point(12, 143);
            this.out_1_9.Name = "out_1_9";
            this.out_1_9.Size = new System.Drawing.Size(48, 23);
            this.out_1_9.TabIndex = 19;
            this.out_1_9.Text = "---";
            this.out_1_9.UseVisualStyleBackColor = true;
            this.out_1_9.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_1_8
            // 
            this.out_1_8.Location = new System.Drawing.Point(186, 114);
            this.out_1_8.Name = "out_1_8";
            this.out_1_8.Size = new System.Drawing.Size(48, 23);
            this.out_1_8.TabIndex = 18;
            this.out_1_8.Text = "---";
            this.out_1_8.UseVisualStyleBackColor = true;
            this.out_1_8.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_1_6
            // 
            this.out_1_6.Location = new System.Drawing.Point(186, 85);
            this.out_1_6.Name = "out_1_6";
            this.out_1_6.Size = new System.Drawing.Size(48, 23);
            this.out_1_6.TabIndex = 17;
            this.out_1_6.Text = "---";
            this.out_1_6.UseVisualStyleBackColor = true;
            this.out_1_6.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_1_7
            // 
            this.out_1_7.Location = new System.Drawing.Point(12, 114);
            this.out_1_7.Name = "out_1_7";
            this.out_1_7.Size = new System.Drawing.Size(48, 23);
            this.out_1_7.TabIndex = 16;
            this.out_1_7.Text = "---";
            this.out_1_7.UseVisualStyleBackColor = true;
            this.out_1_7.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_1_5
            // 
            this.out_1_5.Location = new System.Drawing.Point(12, 85);
            this.out_1_5.Name = "out_1_5";
            this.out_1_5.Size = new System.Drawing.Size(48, 23);
            this.out_1_5.TabIndex = 15;
            this.out_1_5.Text = "---";
            this.out_1_5.UseVisualStyleBackColor = true;
            this.out_1_5.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_1_4
            // 
            this.out_1_4.Location = new System.Drawing.Point(186, 56);
            this.out_1_4.Name = "out_1_4";
            this.out_1_4.Size = new System.Drawing.Size(48, 23);
            this.out_1_4.TabIndex = 14;
            this.out_1_4.Text = "---";
            this.out_1_4.UseVisualStyleBackColor = true;
            this.out_1_4.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_1_2
            // 
            this.out_1_2.Location = new System.Drawing.Point(186, 27);
            this.out_1_2.Name = "out_1_2";
            this.out_1_2.Size = new System.Drawing.Size(48, 23);
            this.out_1_2.TabIndex = 13;
            this.out_1_2.Text = "---";
            this.out_1_2.UseVisualStyleBackColor = true;
            this.out_1_2.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_1_3
            // 
            this.out_1_3.Location = new System.Drawing.Point(12, 56);
            this.out_1_3.Name = "out_1_3";
            this.out_1_3.Size = new System.Drawing.Size(48, 23);
            this.out_1_3.TabIndex = 12;
            this.out_1_3.Text = "---";
            this.out_1_3.UseVisualStyleBackColor = true;
            this.out_1_3.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // out_1_1
            // 
            this.out_1_1.Location = new System.Drawing.Point(12, 27);
            this.out_1_1.Name = "out_1_1";
            this.out_1_1.Size = new System.Drawing.Size(48, 23);
            this.out_1_1.TabIndex = 11;
            this.out_1_1.Text = "---";
            this.out_1_1.UseVisualStyleBackColor = true;
            this.out_1_1.Click += new System.EventHandler(this.on_btn_out_click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Контроллер 1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Управление выходами";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Location = new System.Drawing.Point(12, 497);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(760, 153);
            this.panel8.TabIndex = 9;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.in_1_6);
            this.panel9.Controls.Add(this.in_1_5);
            this.panel9.Controls.Add(this.in_1_4);
            this.panel9.Controls.Add(this.in_1_2);
            this.panel9.Controls.Add(this.in_1_3);
            this.panel9.Controls.Add(this.in_1_1);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(8, 27);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(366, 117);
            this.panel9.TabIndex = 16;
            // 
            // in_1_6
            // 
            this.in_1_6.Enabled = false;
            this.in_1_6.Location = new System.Drawing.Point(186, 85);
            this.in_1_6.Name = "in_1_6";
            this.in_1_6.Size = new System.Drawing.Size(48, 23);
            this.in_1_6.TabIndex = 16;
            this.in_1_6.Text = "---";
            this.in_1_6.UseVisualStyleBackColor = true;
            // 
            // in_1_5
            // 
            this.in_1_5.Enabled = false;
            this.in_1_5.Location = new System.Drawing.Point(12, 85);
            this.in_1_5.Name = "in_1_5";
            this.in_1_5.Size = new System.Drawing.Size(48, 23);
            this.in_1_5.TabIndex = 15;
            this.in_1_5.Text = "---";
            this.in_1_5.UseVisualStyleBackColor = true;
            // 
            // in_1_4
            // 
            this.in_1_4.Enabled = false;
            this.in_1_4.Location = new System.Drawing.Point(186, 56);
            this.in_1_4.Name = "in_1_4";
            this.in_1_4.Size = new System.Drawing.Size(48, 23);
            this.in_1_4.TabIndex = 14;
            this.in_1_4.Text = "---";
            this.in_1_4.UseVisualStyleBackColor = true;
            // 
            // in_1_2
            // 
            this.in_1_2.Enabled = false;
            this.in_1_2.Location = new System.Drawing.Point(186, 27);
            this.in_1_2.Name = "in_1_2";
            this.in_1_2.Size = new System.Drawing.Size(48, 23);
            this.in_1_2.TabIndex = 13;
            this.in_1_2.Text = "---";
            this.in_1_2.UseVisualStyleBackColor = true;
            // 
            // in_1_3
            // 
            this.in_1_3.Enabled = false;
            this.in_1_3.Location = new System.Drawing.Point(12, 56);
            this.in_1_3.Name = "in_1_3";
            this.in_1_3.Size = new System.Drawing.Size(48, 23);
            this.in_1_3.TabIndex = 12;
            this.in_1_3.Text = "---";
            this.in_1_3.UseVisualStyleBackColor = true;
            // 
            // in_1_1
            // 
            this.in_1_1.Enabled = false;
            this.in_1_1.Location = new System.Drawing.Point(12, 27);
            this.in_1_1.Name = "in_1_1";
            this.in_1_1.Size = new System.Drawing.Size(48, 23);
            this.in_1_1.TabIndex = 11;
            this.in_1_1.Text = "---";
            this.in_1_1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(9, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Контроллер 1:";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.in_2_6);
            this.panel10.Controls.Add(this.in_2_5);
            this.panel10.Controls.Add(this.in_2_4);
            this.panel10.Controls.Add(this.in_2_2);
            this.panel10.Controls.Add(this.in_2_3);
            this.panel10.Controls.Add(this.in_2_1);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Location = new System.Drawing.Point(394, 27);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(361, 117);
            this.panel10.TabIndex = 15;
            // 
            // in_2_6
            // 
            this.in_2_6.Enabled = false;
            this.in_2_6.Location = new System.Drawing.Point(186, 85);
            this.in_2_6.Name = "in_2_6";
            this.in_2_6.Size = new System.Drawing.Size(48, 23);
            this.in_2_6.TabIndex = 16;
            this.in_2_6.Text = "---";
            this.in_2_6.UseVisualStyleBackColor = true;
            // 
            // in_2_5
            // 
            this.in_2_5.Enabled = false;
            this.in_2_5.Location = new System.Drawing.Point(12, 85);
            this.in_2_5.Name = "in_2_5";
            this.in_2_5.Size = new System.Drawing.Size(48, 23);
            this.in_2_5.TabIndex = 15;
            this.in_2_5.Text = "---";
            this.in_2_5.UseVisualStyleBackColor = true;
            // 
            // in_2_4
            // 
            this.in_2_4.Enabled = false;
            this.in_2_4.Location = new System.Drawing.Point(186, 56);
            this.in_2_4.Name = "in_2_4";
            this.in_2_4.Size = new System.Drawing.Size(48, 23);
            this.in_2_4.TabIndex = 14;
            this.in_2_4.Text = "---";
            this.in_2_4.UseVisualStyleBackColor = true;
            // 
            // in_2_2
            // 
            this.in_2_2.Enabled = false;
            this.in_2_2.Location = new System.Drawing.Point(186, 27);
            this.in_2_2.Name = "in_2_2";
            this.in_2_2.Size = new System.Drawing.Size(48, 23);
            this.in_2_2.TabIndex = 13;
            this.in_2_2.Text = "---";
            this.in_2_2.UseVisualStyleBackColor = true;
            // 
            // in_2_3
            // 
            this.in_2_3.Enabled = false;
            this.in_2_3.Location = new System.Drawing.Point(12, 56);
            this.in_2_3.Name = "in_2_3";
            this.in_2_3.Size = new System.Drawing.Size(48, 23);
            this.in_2_3.TabIndex = 12;
            this.in_2_3.Text = "---";
            this.in_2_3.UseVisualStyleBackColor = true;
            // 
            // in_2_1
            // 
            this.in_2_1.Enabled = false;
            this.in_2_1.Location = new System.Drawing.Point(12, 27);
            this.in_2_1.Name = "in_2_1";
            this.in_2_1.Size = new System.Drawing.Size(48, 23);
            this.in_2_1.TabIndex = 11;
            this.in_2_1.Text = "---";
            this.in_2_1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(9, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Контроллер 2:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "Состояние входов";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Управление квестом \"Боги Египта\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_controller1_connected;
        private System.Windows.Forms.Label lbl_controller2_connected;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button relay_1_4;
        private System.Windows.Forms.Button relay_1_2;
        private System.Windows.Forms.Button relay_1_3;
        private System.Windows.Forms.Button relay_1_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button relay_2_4;
        private System.Windows.Forms.Button relay_2_2;
        private System.Windows.Forms.Button relay_2_3;
        private System.Windows.Forms.Button relay_2_1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button out_2_12;
        private System.Windows.Forms.Button out_2_10;
        private System.Windows.Forms.Button out_2_11;
        private System.Windows.Forms.Button out_2_9;
        private System.Windows.Forms.Button out_2_8;
        private System.Windows.Forms.Button out_2_6;
        private System.Windows.Forms.Button out_2_7;
        private System.Windows.Forms.Button out_2_5;
        private System.Windows.Forms.Button out_2_4;
        private System.Windows.Forms.Button out_2_2;
        private System.Windows.Forms.Button out_2_3;
        private System.Windows.Forms.Button out_2_1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button out_1_12;
        private System.Windows.Forms.Button out_1_10;
        private System.Windows.Forms.Button out_1_11;
        private System.Windows.Forms.Button out_1_9;
        private System.Windows.Forms.Button out_1_8;
        private System.Windows.Forms.Button out_1_6;
        private System.Windows.Forms.Button out_1_7;
        private System.Windows.Forms.Button out_1_5;
        private System.Windows.Forms.Button out_1_4;
        private System.Windows.Forms.Button out_1_2;
        private System.Windows.Forms.Button out_1_3;
        private System.Windows.Forms.Button out_1_1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button in_1_6;
        private System.Windows.Forms.Button in_1_5;
        private System.Windows.Forms.Button in_1_4;
        private System.Windows.Forms.Button in_1_2;
        private System.Windows.Forms.Button in_1_3;
        private System.Windows.Forms.Button in_1_1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button in_2_6;
        private System.Windows.Forms.Button in_2_5;
        private System.Windows.Forms.Button in_2_4;
        private System.Windows.Forms.Button in_2_2;
        private System.Windows.Forms.Button in_2_3;
        private System.Windows.Forms.Button in_2_1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}

