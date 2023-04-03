using System.Drawing;

namespace WindowsFormsApp1
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.setRealDate = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.setMinManual = new System.Windows.Forms.NumericUpDown();
            this.setHourManual = new System.Windows.Forms.NumericUpDown();
            this.lblColon1 = new System.Windows.Forms.Label();
            this.lblColon2 = new System.Windows.Forms.Label();
            this.setSecManual = new System.Windows.Forms.NumericUpDown();
            this.setRTC = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.setMinManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setHourManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setSecManual)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(300, 325);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(208, 41);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // setRealDate
            // 
            this.setRealDate.AccessibleName = "setRealDate";
            this.setRealDate.AutoSize = true;
            this.setRealDate.Location = new System.Drawing.Point(333, 219);
            this.setRealDate.Name = "setRealDate";
            this.setRealDate.Size = new System.Drawing.Size(136, 24);
            this.setRealDate.TabIndex = 3;
            this.setRealDate.Text = "Set Real Date";
            this.setRealDate.UseVisualStyleBackColor = true;
            this.setRealDate.CheckedChanged += new System.EventHandler(this.setRealDate_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.AccessibleName = "dateMenu";
            this.dateTimePicker.Location = new System.Drawing.Point(25, 215);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // setMinManual
            // 
            this.setMinManual.Location = new System.Drawing.Point(99, 282);
            this.setMinManual.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.setMinManual.Name = "setMinManual";
            this.setMinManual.Size = new System.Drawing.Size(49, 26);
            this.setMinManual.TabIndex = 6;
            // 
            // setHourManual
            // 
            this.setHourManual.Location = new System.Drawing.Point(25, 282);
            this.setHourManual.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.setHourManual.Name = "setHourManual";
            this.setHourManual.Size = new System.Drawing.Size(49, 26);
            this.setHourManual.TabIndex = 7;
            this.setHourManual.ValueChanged += new System.EventHandler(this.SetHourManual_ValueChanged);
            // 
            // lblColon1
            // 
            this.lblColon1.AutoSize = true;
            this.lblColon1.Location = new System.Drawing.Point(80, 284);
            this.lblColon1.Name = "lblColon1";
            this.lblColon1.Size = new System.Drawing.Size(13, 20);
            this.lblColon1.TabIndex = 8;
            this.lblColon1.Text = ":";
            this.lblColon1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblColon2
            // 
            this.lblColon2.AutoSize = true;
            this.lblColon2.Location = new System.Drawing.Point(154, 284);
            this.lblColon2.Name = "lblColon2";
            this.lblColon2.Size = new System.Drawing.Size(13, 20);
            this.lblColon2.TabIndex = 9;
            this.lblColon2.Text = ":";
            // 
            // setSecManual
            // 
            this.setSecManual.Location = new System.Drawing.Point(173, 282);
            this.setSecManual.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.setSecManual.Name = "setSecManual";
            this.setSecManual.Size = new System.Drawing.Size(49, 26);
            this.setSecManual.TabIndex = 10;
            this.setSecManual.Click += new System.EventHandler(this.secSecManual_Click);
            // 
            // setRTC
            // 
            this.setRTC.AutoSize = true;
            this.setRTC.Location = new System.Drawing.Point(333, 284);
            this.setRTC.Name = "setRTC";
            this.setRTC.Size = new System.Drawing.Size(135, 24);
            this.setRTC.TabIndex = 11;
            this.setRTC.Text = "Set Real Time";
            this.setRTC.UseVisualStyleBackColor = true;
            this.setRTC.CheckedChanged += new System.EventHandler(this.setRTC_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 143);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(8, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(416, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Now, compile the program as usual in Quartus!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select your preferences, click the save button";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = " for the FPGA clock project.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "This window generate verilog code file to set time ";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.setRTC);
            this.Controls.Add(this.setSecManual);
            this.Controls.Add(this.lblColon2);
            this.Controls.Add(this.lblColon1);
            this.Controls.Add(this.setHourManual);
            this.Controls.Add(this.setMinManual);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.setRealDate);
            this.Controls.Add(this.saveBtn);
            this.Name = "Form1";
            this.Text = "Set Date And Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.setMinManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setHourManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setSecManual)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.CheckBox setRealDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.NumericUpDown setMinManual;
        private System.Windows.Forms.NumericUpDown setHourManual;
        private System.Windows.Forms.Label lblColon1;
        private System.Windows.Forms.Label lblColon2;
        private System.Windows.Forms.NumericUpDown setSecManual;
        private System.Windows.Forms.CheckBox setRTC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

