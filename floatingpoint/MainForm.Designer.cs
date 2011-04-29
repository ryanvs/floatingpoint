namespace floatingpoint
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInt = new System.Windows.Forms.TextBox();
            this.textBoxHex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFloat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Int32 Value";
            // 
            // textBoxInt
            // 
            this.textBoxInt.Location = new System.Drawing.Point(99, 8);
            this.textBoxInt.Name = "textBoxInt";
            this.textBoxInt.Size = new System.Drawing.Size(171, 22);
            this.textBoxInt.TabIndex = 1;
            this.textBoxInt.TextChanged += new System.EventHandler(this.textBoxInt_TextChanged);
            // 
            // textBoxHex
            // 
            this.textBoxHex.Location = new System.Drawing.Point(99, 36);
            this.textBoxHex.Name = "textBoxHex";
            this.textBoxHex.Size = new System.Drawing.Size(171, 22);
            this.textBoxHex.TabIndex = 3;
            this.textBoxHex.TextChanged += new System.EventHandler(this.textBoxHex_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hex Value";
            // 
            // textBoxFloat
            // 
            this.textBoxFloat.Location = new System.Drawing.Point(99, 64);
            this.textBoxFloat.Name = "textBoxFloat";
            this.textBoxFloat.Size = new System.Drawing.Size(171, 22);
            this.textBoxFloat.TabIndex = 5;
            this.textBoxFloat.TextChanged += new System.EventHandler(this.textBoxFloat_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Float Value";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.textBoxFloat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxHex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxInt);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Floating Point Details";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInt;
        private System.Windows.Forms.TextBox textBoxHex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFloat;
        private System.Windows.Forms.Label label3;
    }
}

