namespace JavaScriptGenerator
{
    partial class MainForm
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
            this.NameSpace = new System.Windows.Forms.Label();
            this.comboClassName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.srcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameSpace
            // 
            this.NameSpace.AutoSize = true;
            this.NameSpace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameSpace.Location = new System.Drawing.Point(51, 27);
            this.NameSpace.Name = "NameSpace";
            this.NameSpace.Size = new System.Drawing.Size(82, 15);
            this.NameSpace.TabIndex = 1;
            this.NameSpace.Text = "Name Space :";
            this.NameSpace.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboClassName
            // 
            this.comboClassName.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.comboClassName.FormattingEnabled = true;
            this.comboClassName.Location = new System.Drawing.Point(139, 66);
            this.comboClassName.Name = "comboClassName";
            this.comboClassName.Size = new System.Drawing.Size(376, 23);
            this.comboClassName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGenerate.Location = new System.Drawing.Point(205, 118);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(190, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(140, 27);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(329, 23);
            this.txtLocation.TabIndex = 3;
            // 
            // srcBtn
            // 
            this.srcBtn.Location = new System.Drawing.Point(475, 27);
            this.srcBtn.Name = "srcBtn";
            this.srcBtn.Size = new System.Drawing.Size(40, 23);
            this.srcBtn.TabIndex = 4;
            this.srcBtn.Text = "...";
            this.srcBtn.UseVisualStyleBackColor = true;
            this.srcBtn.Click += new System.EventHandler(this.srcBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 327);
            this.Controls.Add(this.srcBtn);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboClassName);
            this.Controls.Add(this.NameSpace);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NameSpace;
        private System.Windows.Forms.ComboBox comboClassName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button srcBtn;
    }
}

