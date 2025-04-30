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
            this.SuspendLayout();
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_result.Location = new System.Drawing.Point(31, 184);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(648, 314);
            this.textBox_result.TabIndex = 0;
            this.textBox_result.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(31, 56);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(417, 71);
            this.textBox_input.TabIndex = 1;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            // 
            // button_input
            // 
            this.button_input.Font = new System.Drawing.Font("Gulim", 15F);
            this.button_input.Location = new System.Drawing.Point(464, 56);
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
            this.tButton.Location = new System.Drawing.Point(31, 147);
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
            this.fButton.Location = new System.Drawing.Point(141, 147);
            this.fButton.Name = "fButton";
            this.fButton.Size = new System.Drawing.Size(79, 24);
            this.fButton.TabIndex = 4;
            this.fButton.TabStop = true;
            this.fButton.Text = "False";
            this.fButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 599);
            this.Controls.Add(this.fButton);
            this.Controls.Add(this.tButton);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.textBox_result);
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
    }
}

