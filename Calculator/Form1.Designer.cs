﻿
namespace Calculator
{
    partial class Form1
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
            this.equals = new System.Windows.Forms.Button();
            this.number_0 = new System.Windows.Forms.Button();
            this.plus_minus = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.subtractbtn = new System.Windows.Forms.Button();
            this.multiplybtn = new System.Windows.Forms.Button();
            this.dividebtn = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.number_1 = new System.Windows.Forms.Button();
            this.number_2 = new System.Windows.Forms.Button();
            this.number_3 = new System.Windows.Forms.Button();
            this.number_4 = new System.Windows.Forms.Button();
            this.number_5 = new System.Windows.Forms.Button();
            this.number_6 = new System.Windows.Forms.Button();
            this.number_7 = new System.Windows.Forms.Button();
            this.number_8 = new System.Windows.Forms.Button();
            this.number_9 = new System.Windows.Forms.Button();
            this.fraction = new System.Windows.Forms.Button();
            this.exponent = new System.Windows.Forms.Button();
            this.sqr_rt = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.clear_entry = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.number_dec = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.SystemColors.ControlDark;
            this.equals.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.equals.FlatAppearance.BorderSize = 4;
            this.equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equals.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equals.Location = new System.Drawing.Point(340, 428);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(114, 58);
            this.equals.TabIndex = 0;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // number_0
            // 
            this.number_0.BackColor = System.Drawing.Color.Orange;
            this.number_0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.number_0.FlatAppearance.BorderSize = 4;
            this.number_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_0.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_0.Location = new System.Drawing.Point(122, 428);
            this.number_0.Name = "number_0";
            this.number_0.Size = new System.Drawing.Size(103, 58);
            this.number_0.TabIndex = 2;
            this.number_0.Text = "0";
            this.number_0.UseVisualStyleBackColor = false;
            this.number_0.Click += new System.EventHandler(this.numbers_Click);
            // 
            // plus_minus
            // 
            this.plus_minus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.plus_minus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.plus_minus.FlatAppearance.BorderSize = 4;
            this.plus_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus_minus.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus_minus.Location = new System.Drawing.Point(13, 428);
            this.plus_minus.Name = "plus_minus";
            this.plus_minus.Size = new System.Drawing.Size(103, 58);
            this.plus_minus.TabIndex = 3;
            this.plus_minus.Text = "±";
            this.plus_minus.UseVisualStyleBackColor = false;
            this.plus_minus.Click += new System.EventHandler(this.adv_oprtr_clck);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addbtn.FlatAppearance.BorderSize = 4;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addbtn.Location = new System.Drawing.Point(340, 364);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(114, 58);
            this.addbtn.TabIndex = 4;
            this.addbtn.Text = "+";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.bsc_oprtr_clck);
            // 
            // subtractbtn
            // 
            this.subtractbtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.subtractbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.subtractbtn.FlatAppearance.BorderSize = 4;
            this.subtractbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtractbtn.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtractbtn.Location = new System.Drawing.Point(340, 300);
            this.subtractbtn.Name = "subtractbtn";
            this.subtractbtn.Size = new System.Drawing.Size(114, 58);
            this.subtractbtn.TabIndex = 5;
            this.subtractbtn.Text = "-";
            this.subtractbtn.UseVisualStyleBackColor = false;
            this.subtractbtn.Click += new System.EventHandler(this.bsc_oprtr_clck);
            // 
            // multiplybtn
            // 
            this.multiplybtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.multiplybtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.multiplybtn.FlatAppearance.BorderSize = 4;
            this.multiplybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplybtn.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplybtn.Location = new System.Drawing.Point(340, 236);
            this.multiplybtn.Name = "multiplybtn";
            this.multiplybtn.Size = new System.Drawing.Size(114, 58);
            this.multiplybtn.TabIndex = 6;
            this.multiplybtn.Text = "x";
            this.multiplybtn.UseVisualStyleBackColor = false;
            this.multiplybtn.Click += new System.EventHandler(this.bsc_oprtr_clck);
            // 
            // dividebtn
            // 
            this.dividebtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dividebtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.dividebtn.FlatAppearance.BorderSize = 4;
            this.dividebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dividebtn.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dividebtn.Location = new System.Drawing.Point(340, 172);
            this.dividebtn.Name = "dividebtn";
            this.dividebtn.Size = new System.Drawing.Size(114, 58);
            this.dividebtn.TabIndex = 7;
            this.dividebtn.Text = "÷";
            this.dividebtn.UseVisualStyleBackColor = false;
            this.dividebtn.Click += new System.EventHandler(this.bsc_oprtr_clck);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.delete.FlatAppearance.BorderSize = 4;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete.Location = new System.Drawing.Point(340, 108);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(114, 58);
            this.delete.TabIndex = 8;
            this.delete.Text = "⌫";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // number_1
            // 
            this.number_1.BackColor = System.Drawing.Color.Orange;
            this.number_1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.number_1.FlatAppearance.BorderSize = 4;
            this.number_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_1.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_1.Location = new System.Drawing.Point(13, 364);
            this.number_1.Name = "number_1";
            this.number_1.Size = new System.Drawing.Size(103, 58);
            this.number_1.TabIndex = 11;
            this.number_1.Text = "1";
            this.number_1.UseVisualStyleBackColor = false;
            this.number_1.Click += new System.EventHandler(this.numbers_Click);
            // 
            // number_2
            // 
            this.number_2.BackColor = System.Drawing.Color.Orange;
            this.number_2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.number_2.FlatAppearance.BorderSize = 4;
            this.number_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_2.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_2.Location = new System.Drawing.Point(122, 364);
            this.number_2.Name = "number_2";
            this.number_2.Size = new System.Drawing.Size(103, 58);
            this.number_2.TabIndex = 10;
            this.number_2.Text = "2";
            this.number_2.UseVisualStyleBackColor = false;
            this.number_2.Click += new System.EventHandler(this.numbers_Click);
            // 
            // number_3
            // 
            this.number_3.BackColor = System.Drawing.Color.Orange;
            this.number_3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.number_3.FlatAppearance.BorderSize = 4;
            this.number_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_3.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_3.Location = new System.Drawing.Point(231, 364);
            this.number_3.Name = "number_3";
            this.number_3.Size = new System.Drawing.Size(103, 58);
            this.number_3.TabIndex = 9;
            this.number_3.Text = "3";
            this.number_3.UseVisualStyleBackColor = false;
            this.number_3.Click += new System.EventHandler(this.numbers_Click);
            // 
            // number_4
            // 
            this.number_4.BackColor = System.Drawing.Color.Orange;
            this.number_4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.number_4.FlatAppearance.BorderSize = 4;
            this.number_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_4.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_4.Location = new System.Drawing.Point(13, 300);
            this.number_4.Name = "number_4";
            this.number_4.Size = new System.Drawing.Size(103, 58);
            this.number_4.TabIndex = 14;
            this.number_4.Text = "4";
            this.number_4.UseVisualStyleBackColor = false;
            this.number_4.Click += new System.EventHandler(this.numbers_Click);
            // 
            // number_5
            // 
            this.number_5.BackColor = System.Drawing.Color.Orange;
            this.number_5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.number_5.FlatAppearance.BorderSize = 4;
            this.number_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_5.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_5.Location = new System.Drawing.Point(122, 300);
            this.number_5.Name = "number_5";
            this.number_5.Size = new System.Drawing.Size(103, 58);
            this.number_5.TabIndex = 13;
            this.number_5.Text = "5";
            this.number_5.UseVisualStyleBackColor = false;
            this.number_5.Click += new System.EventHandler(this.numbers_Click);
            // 
            // number_6
            // 
            this.number_6.BackColor = System.Drawing.Color.Orange;
            this.number_6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.number_6.FlatAppearance.BorderSize = 4;
            this.number_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_6.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_6.Location = new System.Drawing.Point(231, 300);
            this.number_6.Name = "number_6";
            this.number_6.Size = new System.Drawing.Size(103, 58);
            this.number_6.TabIndex = 12;
            this.number_6.Text = "6";
            this.number_6.UseVisualStyleBackColor = false;
            this.number_6.Click += new System.EventHandler(this.numbers_Click);
            // 
            // number_7
            // 
            this.number_7.BackColor = System.Drawing.Color.Orange;
            this.number_7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.number_7.FlatAppearance.BorderSize = 4;
            this.number_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_7.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_7.Location = new System.Drawing.Point(13, 236);
            this.number_7.Name = "number_7";
            this.number_7.Size = new System.Drawing.Size(103, 58);
            this.number_7.TabIndex = 17;
            this.number_7.Text = "7";
            this.number_7.UseVisualStyleBackColor = false;
            this.number_7.Click += new System.EventHandler(this.numbers_Click);
            // 
            // number_8
            // 
            this.number_8.BackColor = System.Drawing.Color.Orange;
            this.number_8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.number_8.FlatAppearance.BorderSize = 4;
            this.number_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_8.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_8.Location = new System.Drawing.Point(122, 236);
            this.number_8.Name = "number_8";
            this.number_8.Size = new System.Drawing.Size(103, 58);
            this.number_8.TabIndex = 16;
            this.number_8.Text = "8";
            this.number_8.UseVisualStyleBackColor = false;
            this.number_8.Click += new System.EventHandler(this.numbers_Click);
            // 
            // number_9
            // 
            this.number_9.BackColor = System.Drawing.Color.Orange;
            this.number_9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.number_9.FlatAppearance.BorderSize = 4;
            this.number_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_9.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_9.Location = new System.Drawing.Point(231, 236);
            this.number_9.Name = "number_9";
            this.number_9.Size = new System.Drawing.Size(103, 58);
            this.number_9.TabIndex = 15;
            this.number_9.Text = "9";
            this.number_9.UseVisualStyleBackColor = false;
            this.number_9.Click += new System.EventHandler(this.numbers_Click);
            // 
            // fraction
            // 
            this.fraction.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fraction.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fraction.FlatAppearance.BorderSize = 4;
            this.fraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fraction.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fraction.Location = new System.Drawing.Point(13, 172);
            this.fraction.Name = "fraction";
            this.fraction.Size = new System.Drawing.Size(103, 58);
            this.fraction.TabIndex = 20;
            this.fraction.Text = "1 / x";
            this.fraction.UseVisualStyleBackColor = false;
            this.fraction.Click += new System.EventHandler(this.adv_oprtr_clck);
            // 
            // exponent
            // 
            this.exponent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.exponent.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exponent.FlatAppearance.BorderSize = 4;
            this.exponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exponent.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exponent.Location = new System.Drawing.Point(122, 172);
            this.exponent.Name = "exponent";
            this.exponent.Size = new System.Drawing.Size(103, 58);
            this.exponent.TabIndex = 19;
            this.exponent.Text = "x^2";
            this.exponent.UseVisualStyleBackColor = false;
            this.exponent.Click += new System.EventHandler(this.adv_oprtr_clck);
            // 
            // sqr_rt
            // 
            this.sqr_rt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sqr_rt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sqr_rt.FlatAppearance.BorderSize = 4;
            this.sqr_rt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqr_rt.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sqr_rt.Location = new System.Drawing.Point(231, 172);
            this.sqr_rt.Name = "sqr_rt";
            this.sqr_rt.Size = new System.Drawing.Size(103, 58);
            this.sqr_rt.TabIndex = 18;
            this.sqr_rt.Text = "√x";
            this.sqr_rt.UseVisualStyleBackColor = false;
            this.sqr_rt.Click += new System.EventHandler(this.adv_oprtr_clck);
            // 
            // percent
            // 
            this.percent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.percent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.percent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.percent.FlatAppearance.BorderSize = 4;
            this.percent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percent.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.percent.Location = new System.Drawing.Point(13, 108);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(103, 58);
            this.percent.TabIndex = 23;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = false;
            this.percent.Click += new System.EventHandler(this.adv_oprtr_clck);
            // 
            // clear_entry
            // 
            this.clear_entry.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clear_entry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clear_entry.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clear_entry.FlatAppearance.BorderSize = 4;
            this.clear_entry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_entry.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear_entry.Location = new System.Drawing.Point(122, 108);
            this.clear_entry.Name = "clear_entry";
            this.clear_entry.Size = new System.Drawing.Size(103, 58);
            this.clear_entry.TabIndex = 22;
            this.clear_entry.Text = "CE";
            this.clear_entry.UseVisualStyleBackColor = false;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clear.FlatAppearance.BorderSize = 4;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(231, 108);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(103, 58);
            this.clear.TabIndex = 21;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // txt_output
            // 
            this.txt_output.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_output.Font = new System.Drawing.Font("Futura BdCn BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_output.Location = new System.Drawing.Point(14, 53);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_output.Size = new System.Drawing.Size(441, 48);
            this.txt_output.TabIndex = 24;
            this.txt_output.Text = "0";
            this.txt_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // number_dec
            // 
            this.number_dec.BackColor = System.Drawing.SystemColors.ControlDark;
            this.number_dec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.number_dec.FlatAppearance.BorderSize = 4;
            this.number_dec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_dec.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_dec.Location = new System.Drawing.Point(231, 428);
            this.number_dec.Name = "number_dec";
            this.number_dec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.number_dec.Size = new System.Drawing.Size(103, 58);
            this.number_dec.TabIndex = 25;
            this.number_dec.Text = ".";
            this.number_dec.UseVisualStyleBackColor = false;
            this.number_dec.Click += new System.EventHandler(this.numbers_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Futura BdCn BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(14, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(441, 48);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(467, 503);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.number_dec);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.clear_entry);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.fraction);
            this.Controls.Add(this.exponent);
            this.Controls.Add(this.sqr_rt);
            this.Controls.Add(this.number_7);
            this.Controls.Add(this.number_8);
            this.Controls.Add(this.number_9);
            this.Controls.Add(this.number_4);
            this.Controls.Add(this.number_5);
            this.Controls.Add(this.number_6);
            this.Controls.Add(this.number_1);
            this.Controls.Add(this.number_2);
            this.Controls.Add(this.number_3);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.dividebtn);
            this.Controls.Add(this.multiplybtn);
            this.Controls.Add(this.subtractbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.plus_minus);
            this.Controls.Add(this.number_0);
            this.Controls.Add(this.equals);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator (Sample)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button number_0;
        private System.Windows.Forms.Button plus_minus;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button subtractbtn;
        private System.Windows.Forms.Button multiplybtn;
        private System.Windows.Forms.Button dividebtn;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button number_1;
        private System.Windows.Forms.Button number_2;
        private System.Windows.Forms.Button number_3;
        private System.Windows.Forms.Button number_4;
        private System.Windows.Forms.Button number_5;
        private System.Windows.Forms.Button number_6;
        private System.Windows.Forms.Button number_7;
        private System.Windows.Forms.Button number_8;
        private System.Windows.Forms.Button number_9;
        private System.Windows.Forms.Button fraction;
        private System.Windows.Forms.Button exponent;
        private System.Windows.Forms.Button sqr_rt;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button clear_entry;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Button number_dec;
        private System.Windows.Forms.TextBox textBox1;
    }
}
