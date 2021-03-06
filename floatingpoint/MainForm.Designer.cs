﻿namespace floatingpoint
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMantissa = new System.Windows.Forms.TextBox();
            this.textBoxExponent = new System.Windows.Forms.TextBox();
            this.textBoxInt = new System.Windows.Forms.TextBox();
            this.textBoxFloat = new System.Windows.Forms.TextBox();
            this.textBoxHex = new System.Windows.Forms.TextBox();
            this.textBoxSign = new System.Windows.Forms.TextBox();
            this.floatControl1 = new floatingpoint.FloatControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Int32 Value";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hex Value";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Float Value";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxSign, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHex, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFloat, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxInt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxExponent, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMantissa, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 178);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Exponent";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sign";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mantissa";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxMantissa
            // 
            this.textBoxMantissa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMantissa.Location = new System.Drawing.Point(88, 143);
            this.textBoxMantissa.Name = "textBoxMantissa";
            this.textBoxMantissa.ReadOnly = true;
            this.textBoxMantissa.Size = new System.Drawing.Size(209, 22);
            this.textBoxMantissa.TabIndex = 11;
            // 
            // textBoxExponent
            // 
            this.textBoxExponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxExponent.Location = new System.Drawing.Point(88, 115);
            this.textBoxExponent.Name = "textBoxExponent";
            this.textBoxExponent.ReadOnly = true;
            this.textBoxExponent.Size = new System.Drawing.Size(209, 22);
            this.textBoxExponent.TabIndex = 9;
            // 
            // textBoxInt
            // 
            this.textBoxInt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInt.Location = new System.Drawing.Point(88, 31);
            this.textBoxInt.Name = "textBoxInt";
            this.textBoxInt.Size = new System.Drawing.Size(209, 22);
            this.textBoxInt.TabIndex = 3;
            this.textBoxInt.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // textBoxFloat
            // 
            this.textBoxFloat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFloat.Location = new System.Drawing.Point(88, 3);
            this.textBoxFloat.Name = "textBoxFloat";
            this.textBoxFloat.Size = new System.Drawing.Size(209, 22);
            this.textBoxFloat.TabIndex = 1;
            this.textBoxFloat.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // textBoxHex
            // 
            this.textBoxHex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHex.Location = new System.Drawing.Point(88, 59);
            this.textBoxHex.Name = "textBoxHex";
            this.textBoxHex.Size = new System.Drawing.Size(209, 22);
            this.textBoxHex.TabIndex = 5;
            this.textBoxHex.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // textBoxSign
            // 
            this.textBoxSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSign.Location = new System.Drawing.Point(88, 87);
            this.textBoxSign.Name = "textBoxSign";
            this.textBoxSign.ReadOnly = true;
            this.textBoxSign.Size = new System.Drawing.Size(209, 22);
            this.textBoxSign.TabIndex = 7;
            // 
            // floatControl1
            // 
            this.floatControl1.AutoScroll = true;
            this.floatControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floatControl1.FloatValue = null;
            this.floatControl1.Location = new System.Drawing.Point(0, 178);
            this.floatControl1.Name = "mantissaControl1";
            this.floatControl1.Size = new System.Drawing.Size(300, 334);
            this.floatControl1.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(300, 512);
            this.Controls.Add(this.floatControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Floating Point Details";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSign;
        private System.Windows.Forms.TextBox textBoxHex;
        private System.Windows.Forms.TextBox textBoxFloat;
        private System.Windows.Forms.TextBox textBoxInt;
        private System.Windows.Forms.TextBox textBoxExponent;
        private System.Windows.Forms.TextBox textBoxMantissa;
        private FloatControl floatControl1;
    }
}

