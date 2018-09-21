namespace 記帳SQLServer
{
    partial class SearchByYear
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Average = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Income = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Research = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(16, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 27);
            this.label5.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(16, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 27);
            this.label2.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(16, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 27);
            this.label4.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.Average);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.Income);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.Research);
            this.groupBox1.Location = new System.Drawing.Point(445, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(427, 171);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "年份";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(280, 98);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 66);
            this.button4.TabIndex = 6;
            this.button4.Text = "總計(收+支)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Average
            // 
            this.Average.Location = new System.Drawing.Point(280, 26);
            this.Average.Margin = new System.Windows.Forms.Padding(4);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(128, 66);
            this.Average.TabIndex = 5;
            this.Average.Text = "平均";
            this.Average.UseVisualStyleBackColor = true;
            this.Average.Click += new System.EventHandler(this.button1_Click);
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
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Income
            // 
            this.Income.Location = new System.Drawing.Point(8, 24);
            this.Income.Margin = new System.Windows.Forms.Padding(4);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(128, 66);
            this.Income.TabIndex = 3;
            this.Income.Text = "收入";
            this.Income.UseVisualStyleBackColor = true;
            this.Income.Click += new System.EventHandler(this.button7_Click);
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
            // Research
            // 
            this.Research.Location = new System.Drawing.Point(144, 26);
            this.Research.Margin = new System.Windows.Forms.Padding(4);
            this.Research.Name = "Research";
            this.Research.Size = new System.Drawing.Size(128, 66);
            this.Research.TabIndex = 1;
            this.Research.Text = "查詢";
            this.Research.UseVisualStyleBackColor = true;
            this.Research.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "年份:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 335);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(859, 254);
            this.dataGridView1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(16, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 27);
            this.label3.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(16, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 27);
            this.label7.TabIndex = 25;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.YearTextBox.Location = new System.Drawing.Point(92, 32);
            this.YearTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(132, 36);
            this.YearTextBox.TabIndex = 26;
            // 
            // SearchByYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 604);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchByYear";
            this.Text = "年份查詢";
            this.Load += new System.EventHandler(this.Year_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Income;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Research;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Average;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox YearTextBox;
    }
}