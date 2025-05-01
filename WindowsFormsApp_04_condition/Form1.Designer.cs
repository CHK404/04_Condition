namespace WindowsFormsApp_04_condition
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
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_input = new System.Windows.Forms.Button();
            this.tButton = new System.Windows.Forms.RadioButton();
            this.fButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_input2 = new System.Windows.Forms.TextBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.textBox_print = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_result.Location = new System.Drawing.Point(31, 184);
            this.textBox_result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(649, 314);
            this.textBox_result.TabIndex = 0;
            this.textBox_result.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(31, 56);
            this.textBox_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(417, 72);
            this.textBox_input.TabIndex = 1;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            // 
            // button_input
            // 
            this.button_input.Font = new System.Drawing.Font("Gulim", 15F);
            this.button_input.Location = new System.Drawing.Point(464, 56);
            this.button_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(215, 71);
            this.button_input.TabIndex = 2;
            this.button_input.Text = "Input";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            // 
            // tButton
            // 
            this.tButton.AutoSize = true;
            this.tButton.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tButton.Location = new System.Drawing.Point(31, 148);
            this.tButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tButton.Name = "tButton";
            this.tButton.Size = new System.Drawing.Size(72, 24);
            this.tButton.TabIndex = 3;
            this.tButton.TabStop = true;
            this.tButton.Text = "True";
            this.tButton.UseVisualStyleBackColor = true;
            this.tButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // fButton
            // 
            this.fButton.AutoSize = true;
            this.fButton.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fButton.Location = new System.Drawing.Point(141, 148);
            this.fButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fButton.Name = "fButton";
            this.fButton.Size = new System.Drawing.Size(79, 24);
            this.fButton.TabIndex = 4;
            this.fButton.TabStop = true;
            this.fButton.Text = "False";
            this.fButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox_input2
            // 
            this.textBox_input2.Location = new System.Drawing.Point(31, 24);
            this.textBox_input2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_input2.Name = "textBox_input2";
            this.textBox_input2.Size = new System.Drawing.Size(372, 25);
            this.textBox_input2.TabIndex = 6;
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(496, 24);
            this.textBox_output.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.Size = new System.Drawing.Size(181, 25);
            this.textBox_output.TabIndex = 7;
            // 
            // textBox_print
            // 
            this.textBox_print.Location = new System.Drawing.Point(724, 25);
            this.textBox_print.Multiline = true;
            this.textBox_print.Name = "textBox_print";
            this.textBox_print.Size = new System.Drawing.Size(618, 102);
            this.textBox_print.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 599);
            this.Controls.Add(this.textBox_print);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.textBox_input2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fButton);
            this.Controls.Add(this.tButton);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.textBox_result);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.RadioButton tButton;
        private System.Windows.Forms.RadioButton fButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_input2;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.TextBox textBox_print;
    }
}

