
namespace Simple_Calculator
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multipleButton = new System.Windows.Forms.Button();
            this.devideButton = new System.Windows.Forms.Button();
            this.factorialButton = new System.Windows.Forms.Button();
            this.powerButton = new System.Windows.Forms.Button();
            this.moduleButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "type numbers first";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.Location = new System.Drawing.Point(255, 54);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(76, 21);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(70, 21);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "NUMBER 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(90, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "NUMBER 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Result:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(80, 37);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(54, 16);
            this.result.TabIndex = 1;
            this.result.Text = "0-0-0-0";
            this.result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.result);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(43, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 69);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(0, 19);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(50, 35);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subtractButton.Location = new System.Drawing.Point(334, 19);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(50, 35);
            this.subtractButton.TabIndex = 1;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // multipleButton
            // 
            this.multipleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multipleButton.Location = new System.Drawing.Point(281, 19);
            this.multipleButton.Name = "multipleButton";
            this.multipleButton.Size = new System.Drawing.Size(50, 35);
            this.multipleButton.TabIndex = 2;
            this.multipleButton.Text = "*";
            this.multipleButton.UseVisualStyleBackColor = true;
            this.multipleButton.Click += new System.EventHandler(this.multipleButton_Click);
            // 
            // devideButton
            // 
            this.devideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.devideButton.Location = new System.Drawing.Point(112, 19);
            this.devideButton.Name = "devideButton";
            this.devideButton.Size = new System.Drawing.Size(50, 35);
            this.devideButton.TabIndex = 3;
            this.devideButton.Text = "/";
            this.devideButton.UseVisualStyleBackColor = true;
            this.devideButton.Click += new System.EventHandler(this.devideButton_Click);
            // 
            // factorialButton
            // 
            this.factorialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factorialButton.Location = new System.Drawing.Point(169, 19);
            this.factorialButton.Name = "factorialButton";
            this.factorialButton.Size = new System.Drawing.Size(50, 35);
            this.factorialButton.TabIndex = 4;
            this.factorialButton.Text = "!";
            this.factorialButton.UseVisualStyleBackColor = true;
            this.factorialButton.Click += new System.EventHandler(this.factorialButton_Click);
            // 
            // powerButton
            // 
            this.powerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.powerButton.Location = new System.Drawing.Point(225, 19);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(50, 35);
            this.powerButton.TabIndex = 5;
            this.powerButton.Text = "^";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            // 
            // moduleButton
            // 
            this.moduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moduleButton.Location = new System.Drawing.Point(56, 19);
            this.moduleButton.Name = "moduleButton";
            this.moduleButton.Size = new System.Drawing.Size(50, 35);
            this.moduleButton.TabIndex = 6;
            this.moduleButton.Text = "%";
            this.moduleButton.UseVisualStyleBackColor = true;
            this.moduleButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Silver;
            this.clearButton.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(43, 141);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(396, 52);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(43, 369);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(132, 35);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.moduleButton);
            this.groupBox4.Controls.Add(this.powerButton);
            this.groupBox4.Controls.Add(this.factorialButton);
            this.groupBox4.Controls.Add(this.devideButton);
            this.groupBox4.Controls.Add(this.multipleButton);
            this.groupBox4.Controls.Add(this.subtractButton);
            this.groupBox4.Controls.Add(this.addButton);
            this.groupBox4.Location = new System.Drawing.Point(43, 193);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(396, 74);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(151, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Simple calculator";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(15, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Shakar Hama karim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(469, 487);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShakarDDC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multipleButton;
        private System.Windows.Forms.Button devideButton;
        private System.Windows.Forms.Button factorialButton;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Button moduleButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

