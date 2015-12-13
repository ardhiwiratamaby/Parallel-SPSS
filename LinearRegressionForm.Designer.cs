namespace ParallelSPSS
{
    partial class LinearRegressionForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dependentLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dependentButton = new System.Windows.Forms.Button();
            this.independentButton = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(139, 277);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dependentLabel
            // 
            this.dependentLabel.Location = new System.Drawing.Point(226, 55);
            this.dependentLabel.Name = "dependentLabel";
            this.dependentLabel.Size = new System.Drawing.Size(188, 20);
            this.dependentLabel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dependent :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Independent :";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(165, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(246, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dependentButton
            // 
            this.dependentButton.BackgroundImage = global::ParallelSPSS.Properties.Resources.rightArrow;
            this.dependentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dependentButton.Location = new System.Drawing.Point(165, 44);
            this.dependentButton.Name = "dependentButton";
            this.dependentButton.Size = new System.Drawing.Size(39, 38);
            this.dependentButton.TabIndex = 7;
            this.dependentButton.UseVisualStyleBackColor = true;
            this.dependentButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // independentButton
            // 
            this.independentButton.BackgroundImage = global::ParallelSPSS.Properties.Resources.rightArrow1;
            this.independentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.independentButton.Location = new System.Drawing.Point(165, 137);
            this.independentButton.Name = "independentButton";
            this.independentButton.Size = new System.Drawing.Size(39, 37);
            this.independentButton.TabIndex = 8;
            this.independentButton.UseVisualStyleBackColor = true;
            this.independentButton.Click += new System.EventHandler(this.independentButton_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(229, 136);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(185, 43);
            this.listBox2.TabIndex = 9;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // LinearRegressionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 365);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.independentButton);
            this.Controls.Add(this.dependentButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dependentLabel);
            this.Controls.Add(this.listBox1);
            this.Name = "LinearRegressionForm";
            this.Text = "LinearRegressionForm";
            this.Load += new System.EventHandler(this.LinearRegressionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }





        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox dependentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button dependentButton;
        private System.Windows.Forms.Button independentButton;
        private System.Windows.Forms.ListBox listBox2;
    }
}