namespace 記帳SQLServer
{
    partial class SearchByMonth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MonthTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BorrowercomboBox1 = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.PersonalPrelendBN = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 534);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(859, 254);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(11, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "月份:";
            // 
            // MonthTextBox
            // 
            this.MonthTextBox.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MonthTextBox.Location = new System.Drawing.Point(135, 64);
            this.MonthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MonthTextBox.Name = "MonthTextBox";
            this.MonthTextBox.Size = new System.Drawing.Size(132, 39);
            this.MonthTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PersonalPrelendBN);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(460, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(415, 275);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "月份";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(279, 100);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 66);
            this.button4.TabIndex = 6;
            this.button4.Text = "預借總計";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 66);
            this.button1.TabIndex = 5;
            this.button1.Text = "總計(收+支)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(144, 98);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 66);
            this.button3.TabIndex = 4;
            this.button3.Text = "淨賺";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(8, 24);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(128, 66);
            this.button7.TabIndex = 3;
            this.button7.Text = "收入";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 98);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 66);
            this.button5.TabIndex = 2;
            this.button5.Text = "支出";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 26);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "查詢";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(11, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 27);
            this.label4.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(11, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 27);
            this.label2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(11, 394);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 27);
            this.label5.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(11, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 27);
            this.label3.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(11, 351);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 27);
            this.label6.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(11, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 27);
            this.label7.TabIndex = 18;
            this.label7.Text = "借款人:";
            // 
            // BorrowercomboBox1
            // 
            this.BorrowercomboBox1.FormattingEnabled = true;
            this.BorrowercomboBox1.Items.AddRange(new object[] {
            "遠"});
            this.BorrowercomboBox1.Location = new System.Drawing.Point(135, 130);
            this.BorrowercomboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.BorrowercomboBox1.Name = "BorrowercomboBox1";
            this.BorrowercomboBox1.Size = new System.Drawing.Size(136, 23);
            this.BorrowercomboBox1.TabIndex = 19;
            this.BorrowercomboBox1.Text = "遠";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Year.Location = new System.Drawing.Point(11, 8);
            this.Year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(73, 27);
            this.Year.TabIndex = 20;
            this.Year.Text = "年份:";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.YearTextBox.Location = new System.Drawing.Point(135, 4);
            this.YearTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(132, 39);
            this.YearTextBox.TabIndex = 21;
            // 
            // PersonalPrelendBN
            // 
            this.PersonalPrelendBN.Location = new System.Drawing.Point(144, 187);
            this.PersonalPrelendBN.Margin = new System.Windows.Forms.Padding(4);
            this.PersonalPrelendBN.Name = "PersonalPrelendBN";
            this.PersonalPrelendBN.Size = new System.Drawing.Size(128, 66);
            this.PersonalPrelendBN.TabIndex = 7;
            this.PersonalPrelendBN.Text = "個人預借總計";
            this.PersonalPrelendBN.UseVisualStyleBackColor = true;
            this.PersonalPrelendBN.Click += new System.EventHandler(this.PersonalPrelendBN_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(5, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 28);
            this.label8.TabIndex = 22;
            // 
            // SearchByMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 801);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.BorrowercomboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MonthTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchByMonth";
            this.Text = "月份查詢";
            this.Load += new System.EventHandler(this.resource_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MonthTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox BorrowercomboBox1;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Button PersonalPrelendBN;
        private System.Windows.Forms.Label label8;
    }
}