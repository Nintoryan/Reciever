namespace Reciever
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.serverStatus = new System.Windows.Forms.Label();
            this.bitShow = new System.Windows.Forms.RichTextBox();
            this.time = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.serverSoket = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.messageType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.recievedMessage = new System.Windows.Forms.RichTextBox();
            this.hiddenMessageData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hiddenMessageWhole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.byteShow = new System.Windows.Forms.RichTextBox();
            this.hiddenText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Полученный пакет";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // serverStatus
            // 
            this.serverStatus.AutoSize = true;
            this.serverStatus.Location = new System.Drawing.Point(16, 9);
            this.serverStatus.Name = "serverStatus";
            this.serverStatus.Size = new System.Drawing.Size(55, 20);
            this.serverStatus.TabIndex = 5;
            this.serverStatus.Text = "Статус:";
            // 
            // bitShow
            // 
            this.bitShow.Location = new System.Drawing.Point(10, 128);
            this.bitShow.Name = "bitShow";
            this.bitShow.ReadOnly = true;
            this.bitShow.Size = new System.Drawing.Size(776, 187);
            this.bitShow.TabIndex = 9;
            this.bitShow.Text = "";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(6, 43);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(128, 20);
            this.time.TabIndex = 10;
            this.time.Text = "Время передачи:";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(6, 23);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(82, 20);
            this.size.TabIndex = 11;
            this.size.Text = "Передано:";
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(6, 63);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(76, 20);
            this.speed.TabIndex = 12;
            this.speed.Text = "Скорость:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.size);
            this.groupBox1.Controls.Add(this.speed);
            this.groupBox1.Controls.Add(this.time);
            this.groupBox1.Location = new System.Drawing.Point(366, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 92);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статистика";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(16, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(134, 20);
            this.label21.TabIndex = 14;
            this.label21.Text = "Сокет получателя:";
            // 
            // serverSoket
            // 
            this.serverSoket.Location = new System.Drawing.Point(156, 29);
            this.serverSoket.Name = "serverSoket";
            this.serverSoket.ReadOnly = true;
            this.serverSoket.Size = new System.Drawing.Size(204, 27);
            this.serverSoket.TabIndex = 15;
            this.serverSoket.TextChanged += new System.EventHandler(this.serverSoket_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Тип пакета:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // messageType
            // 
            this.messageType.Location = new System.Drawing.Point(156, 62);
            this.messageType.Name = "messageType";
            this.messageType.ReadOnly = true;
            this.messageType.Size = new System.Drawing.Size(204, 27);
            this.messageType.TabIndex = 17;
            this.messageType.TextChanged += new System.EventHandler(this.messageType_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Полученные биты";
            // 
            // recievedMessage
            // 
            this.recievedMessage.Location = new System.Drawing.Point(6, 341);
            this.recievedMessage.Name = "recievedMessage";
            this.recievedMessage.Size = new System.Drawing.Size(782, 229);
            this.recievedMessage.TabIndex = 19;
            this.recievedMessage.Text = "";
            // 
            // hiddenMessageData
            // 
            this.hiddenMessageData.Location = new System.Drawing.Point(6, 597);
            this.hiddenMessageData.Name = "hiddenMessageData";
            this.hiddenMessageData.Size = new System.Drawing.Size(177, 27);
            this.hiddenMessageData.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 573);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Скрытые данные пакета";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 574);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Скрытые данные передачи бинарные";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // hiddenMessageWhole
            // 
            this.hiddenMessageWhole.Location = new System.Drawing.Point(189, 597);
            this.hiddenMessageWhole.Name = "hiddenMessageWhole";
            this.hiddenMessageWhole.Size = new System.Drawing.Size(442, 27);
            this.hiddenMessageWhole.TabIndex = 23;
            this.hiddenMessageWhole.TextChanged += new System.EventHandler(this.hiddenMessageWhole_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Полученные байты";
            // 
            // byteShow
            // 
            this.byteShow.Location = new System.Drawing.Point(798, 128);
            this.byteShow.Name = "byteShow";
            this.byteShow.ReadOnly = true;
            this.byteShow.Size = new System.Drawing.Size(208, 262);
            this.byteShow.TabIndex = 8;
            this.byteShow.Text = "";
            this.byteShow.TextChanged += new System.EventHandler(this.byteShow_TextChanged);
            // 
            // hiddenText
            // 
            this.hiddenText.Location = new System.Drawing.Point(637, 597);
            this.hiddenText.Name = "hiddenText";
            this.hiddenText.Size = new System.Drawing.Size(149, 27);
            this.hiddenText.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(637, 574);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Скрытый текст";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 631);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hiddenText);
            this.Controls.Add(this.hiddenMessageWhole);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hiddenMessageData);
            this.Controls.Add(this.recievedMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.messageType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serverSoket);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bitShow);
            this.Controls.Add(this.byteShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverStatus);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Получатель";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label serverStatus;
        private RichTextBox bitShow;
        private Label time;
        private Label size;
        private Label speed;
        private GroupBox groupBox1;
        private Label label21;
        private TextBox serverSoket;
        private Label label3;
        private TextBox messageType;
        private Label label4;
        private RichTextBox recievedMessage;
        private TextBox hiddenMessageData;
        private Label label5;
        private Label label6;
        private TextBox hiddenMessageWhole;
        private Label label2;
        private RichTextBox byteShow;
        private TextBox hiddenText;
        private Label label7;
    }
}