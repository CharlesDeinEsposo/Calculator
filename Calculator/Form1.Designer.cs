
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
            this.txt_output2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.History_Button = new System.Windows.Forms.Button();
            this.Memory_Button = new System.Windows.Forms.Button();
            this.History_Color = new System.Windows.Forms.TextBox();
            this.Memory_Color = new System.Windows.Forms.TextBox();
            this.Hisory_TextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ResultBox_Border = new System.Windows.Forms.TextBox();
            this.ResultBox_Border1 = new System.Windows.Forms.TextBox();
            this.ResultBox_Border4 = new System.Windows.Forms.TextBox();
            this.ResultBox_Border2 = new System.Windows.Forms.TextBox();
            this.Memory_TextBox = new System.Windows.Forms.TextBox();
            this.History_Label = new System.Windows.Forms.Label();
            this.Memory_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.equals.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.equals.FlatAppearance.BorderSize = 4;
            this.equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equals.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equals.Location = new System.Drawing.Point(292, 479);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(94, 58);
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
            this.number_0.Location = new System.Drawing.Point(107, 479);
            this.number_0.Name = "number_0";
            this.number_0.Size = new System.Drawing.Size(85, 58);
            this.number_0.TabIndex = 2;
            this.number_0.Text = "0";
            this.number_0.UseVisualStyleBackColor = false;
            this.number_0.Click += new System.EventHandler(this.numbers_Click);
            // 
            // plus_minus
            // 
            this.plus_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.plus_minus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.plus_minus.FlatAppearance.BorderSize = 4;
            this.plus_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus_minus.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus_minus.Location = new System.Drawing.Point(13, 479);
            this.plus_minus.Name = "plus_minus";
            this.plus_minus.Size = new System.Drawing.Size(85, 58);
            this.plus_minus.TabIndex = 3;
            this.plus_minus.Text = "±";
            this.plus_minus.UseVisualStyleBackColor = false;
            this.plus_minus.Click += new System.EventHandler(this.adv_oprtr_clck);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.addbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.addbtn.FlatAppearance.BorderSize = 4;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addbtn.Location = new System.Drawing.Point(292, 415);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(94, 58);
            this.addbtn.TabIndex = 4;
            this.addbtn.Text = "+";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.bsc_oprtr_clck);
            // 
            // subtractbtn
            // 
            this.subtractbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.subtractbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.subtractbtn.FlatAppearance.BorderSize = 4;
            this.subtractbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtractbtn.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtractbtn.Location = new System.Drawing.Point(292, 351);
            this.subtractbtn.Name = "subtractbtn";
            this.subtractbtn.Size = new System.Drawing.Size(94, 58);
            this.subtractbtn.TabIndex = 5;
            this.subtractbtn.Text = "-";
            this.subtractbtn.UseVisualStyleBackColor = false;
            this.subtractbtn.Click += new System.EventHandler(this.bsc_oprtr_clck);
            // 
            // multiplybtn
            // 
            this.multiplybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.multiplybtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.multiplybtn.FlatAppearance.BorderSize = 4;
            this.multiplybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplybtn.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplybtn.Location = new System.Drawing.Point(292, 287);
            this.multiplybtn.Name = "multiplybtn";
            this.multiplybtn.Size = new System.Drawing.Size(94, 58);
            this.multiplybtn.TabIndex = 6;
            this.multiplybtn.Text = "x";
            this.multiplybtn.UseVisualStyleBackColor = false;
            this.multiplybtn.Click += new System.EventHandler(this.bsc_oprtr_clck);
            // 
            // dividebtn
            // 
            this.dividebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.dividebtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.dividebtn.FlatAppearance.BorderSize = 4;
            this.dividebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dividebtn.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dividebtn.Location = new System.Drawing.Point(292, 223);
            this.dividebtn.Name = "dividebtn";
            this.dividebtn.Size = new System.Drawing.Size(94, 58);
            this.dividebtn.TabIndex = 7;
            this.dividebtn.Text = "÷";
            this.dividebtn.UseVisualStyleBackColor = false;
            this.dividebtn.Click += new System.EventHandler(this.bsc_oprtr_clck);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.delete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.delete.FlatAppearance.BorderSize = 4;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete.Location = new System.Drawing.Point(292, 159);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 58);
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
            this.number_1.Location = new System.Drawing.Point(13, 415);
            this.number_1.Name = "number_1";
            this.number_1.Size = new System.Drawing.Size(85, 58);
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
            this.number_2.Location = new System.Drawing.Point(107, 415);
            this.number_2.Name = "number_2";
            this.number_2.Size = new System.Drawing.Size(85, 58);
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
            this.number_3.Location = new System.Drawing.Point(201, 415);
            this.number_3.Name = "number_3";
            this.number_3.Size = new System.Drawing.Size(85, 58);
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
            this.number_4.Location = new System.Drawing.Point(13, 351);
            this.number_4.Name = "number_4";
            this.number_4.Size = new System.Drawing.Size(85, 58);
            this.number_4.TabIndex = 14;
            this.number_4.Text = "4";
            this.number_4.UseVisualStyleBackColor = false;
            this.number_4.Click += new System.EventHandler(this.numbers_Click);
            // 
            // number_5
            // 
            this.number_5.BackColor = System.Drawing.Color.Orange;
            this.number_5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.number_5.FlatAppearance.BorderSize = 4;
            this.number_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_5.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_5.Location = new System.Drawing.Point(107, 351);
            this.number_5.Name = "number_5";
            this.number_5.Size = new System.Drawing.Size(85, 58);
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
            this.number_6.Location = new System.Drawing.Point(201, 351);
            this.number_6.Name = "number_6";
            this.number_6.Size = new System.Drawing.Size(85, 58);
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
            this.number_7.Location = new System.Drawing.Point(13, 287);
            this.number_7.Name = "number_7";
            this.number_7.Size = new System.Drawing.Size(85, 58);
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
            this.number_8.Location = new System.Drawing.Point(107, 287);
            this.number_8.Name = "number_8";
            this.number_8.Size = new System.Drawing.Size(85, 58);
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
            this.number_9.Location = new System.Drawing.Point(201, 287);
            this.number_9.Name = "number_9";
            this.number_9.Size = new System.Drawing.Size(85, 58);
            this.number_9.TabIndex = 15;
            this.number_9.Text = "9";
            this.number_9.UseVisualStyleBackColor = false;
            this.number_9.Click += new System.EventHandler(this.numbers_Click);
            // 
            // fraction
            // 
            this.fraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.fraction.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.fraction.FlatAppearance.BorderSize = 4;
            this.fraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fraction.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fraction.Location = new System.Drawing.Point(13, 223);
            this.fraction.Name = "fraction";
            this.fraction.Size = new System.Drawing.Size(85, 58);
            this.fraction.TabIndex = 20;
            this.fraction.Text = "1 / x";
            this.fraction.UseVisualStyleBackColor = false;
            this.fraction.Click += new System.EventHandler(this.adv_oprtr_clck);
            // 
            // exponent
            // 
            this.exponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.exponent.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.exponent.FlatAppearance.BorderSize = 4;
            this.exponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exponent.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exponent.Location = new System.Drawing.Point(107, 223);
            this.exponent.Name = "exponent";
            this.exponent.Size = new System.Drawing.Size(85, 58);
            this.exponent.TabIndex = 19;
            this.exponent.Text = "x^2";
            this.exponent.UseVisualStyleBackColor = false;
            this.exponent.Click += new System.EventHandler(this.adv_oprtr_clck);
            // 
            // sqr_rt
            // 
            this.sqr_rt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.sqr_rt.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.sqr_rt.FlatAppearance.BorderSize = 4;
            this.sqr_rt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqr_rt.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sqr_rt.Location = new System.Drawing.Point(201, 223);
            this.sqr_rt.Name = "sqr_rt";
            this.sqr_rt.Size = new System.Drawing.Size(85, 58);
            this.sqr_rt.TabIndex = 18;
            this.sqr_rt.Text = "√x";
            this.sqr_rt.UseVisualStyleBackColor = false;
            this.sqr_rt.Click += new System.EventHandler(this.adv_oprtr_clck);
            // 
            // percent
            // 
            this.percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.percent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.percent.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.percent.FlatAppearance.BorderSize = 4;
            this.percent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percent.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.percent.Location = new System.Drawing.Point(13, 159);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(85, 58);
            this.percent.TabIndex = 23;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = false;
            this.percent.Click += new System.EventHandler(this.adv_oprtr_clck);
            // 
            // clear_entry
            // 
            this.clear_entry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.clear_entry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clear_entry.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.clear_entry.FlatAppearance.BorderSize = 4;
            this.clear_entry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_entry.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear_entry.Location = new System.Drawing.Point(107, 159);
            this.clear_entry.Name = "clear_entry";
            this.clear_entry.Size = new System.Drawing.Size(85, 58);
            this.clear_entry.TabIndex = 22;
            this.clear_entry.Text = "CE";
            this.clear_entry.UseVisualStyleBackColor = false;
            this.clear_entry.Click += new System.EventHandler(this.clear_entry_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.clear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.clear.FlatAppearance.BorderSize = 4;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(201, 159);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(85, 58);
            this.clear.TabIndex = 21;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // txt_output
            // 
            this.txt_output.BackColor = System.Drawing.Color.Orange;
            this.txt_output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_output.Font = new System.Drawing.Font("Futura BdCn BT", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_output.Location = new System.Drawing.Point(14, 41);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_output.Size = new System.Drawing.Size(372, 60);
            this.txt_output.TabIndex = 24;
            this.txt_output.Text = "0";
            this.txt_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // number_dec
            // 
            this.number_dec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.number_dec.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.number_dec.FlatAppearance.BorderSize = 4;
            this.number_dec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_dec.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_dec.Location = new System.Drawing.Point(201, 479);
            this.number_dec.Name = "number_dec";
            this.number_dec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.number_dec.Size = new System.Drawing.Size(85, 58);
            this.number_dec.TabIndex = 25;
            this.number_dec.Text = ".";
            this.number_dec.UseVisualStyleBackColor = false;
            this.number_dec.Click += new System.EventHandler(this.numbers_Click);
            // 
            // txt_output2
            // 
            this.txt_output2.BackColor = System.Drawing.Color.Orange;
            this.txt_output2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_output2.Font = new System.Drawing.Font("Futura BdCn BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_output2.Location = new System.Drawing.Point(14, 12);
            this.txt_output2.Multiline = true;
            this.txt_output2.Name = "txt_output2";
            this.txt_output2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_output2.Size = new System.Drawing.Size(372, 35);
            this.txt_output2.TabIndex = 26;
            this.txt_output2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 46);
            this.button1.TabIndex = 27;
            this.button1.Text = "MC";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.FlatAppearance.BorderSize = 4;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(88, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 46);
            this.button2.TabIndex = 28;
            this.button2.Text = "MR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.FlatAppearance.BorderSize = 4;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(240, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 46);
            this.button3.TabIndex = 30;
            this.button3.Text = "M-";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.FlatAppearance.BorderSize = 4;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(164, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 46);
            this.button4.TabIndex = 29;
            this.button4.Text = "M+";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.FlatAppearance.BorderSize = 4;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(316, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 46);
            this.button5.TabIndex = 32;
            this.button5.Text = "MS";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // History_Button
            // 
            this.History_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.History_Button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.History_Button.FlatAppearance.BorderSize = 4;
            this.History_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.History_Button.Font = new System.Drawing.Font("Futura BdCn BT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.History_Button.ForeColor = System.Drawing.Color.Orange;
            this.History_Button.Location = new System.Drawing.Point(402, 11);
            this.History_Button.Name = "History_Button";
            this.History_Button.Size = new System.Drawing.Size(123, 55);
            this.History_Button.TabIndex = 33;
            this.History_Button.Text = "History";
            this.History_Button.UseVisualStyleBackColor = false;
            this.History_Button.Click += new System.EventHandler(this.History_Button_Click);
            // 
            // Memory_Button
            // 
            this.Memory_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.Memory_Button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Memory_Button.FlatAppearance.BorderSize = 4;
            this.Memory_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Memory_Button.Font = new System.Drawing.Font("Futura BdCn BT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Memory_Button.ForeColor = System.Drawing.Color.Orange;
            this.Memory_Button.Location = new System.Drawing.Point(531, 11);
            this.Memory_Button.Name = "Memory_Button";
            this.Memory_Button.Size = new System.Drawing.Size(123, 55);
            this.Memory_Button.TabIndex = 34;
            this.Memory_Button.Text = "Memory";
            this.Memory_Button.UseVisualStyleBackColor = false;
            this.Memory_Button.Click += new System.EventHandler(this.Memory_Button_Click);
            // 
            // History_Color
            // 
            this.History_Color.BackColor = System.Drawing.Color.Orange;
            this.History_Color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.History_Color.Font = new System.Drawing.Font("Futura BdCn BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.History_Color.Location = new System.Drawing.Point(422, 55);
            this.History_Color.Multiline = true;
            this.History_Color.Name = "History_Color";
            this.History_Color.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.History_Color.Size = new System.Drawing.Size(80, 3);
            this.History_Color.TabIndex = 9;
            this.History_Color.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Memory_Color
            // 
            this.Memory_Color.BackColor = System.Drawing.Color.Orange;
            this.Memory_Color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Memory_Color.Font = new System.Drawing.Font("Futura BdCn BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Memory_Color.Location = new System.Drawing.Point(544, 55);
            this.Memory_Color.Multiline = true;
            this.Memory_Color.Name = "Memory_Color";
            this.Memory_Color.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Memory_Color.Size = new System.Drawing.Size(95, 3);
            this.Memory_Color.TabIndex = 36;
            this.Memory_Color.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Memory_Color.Visible = false;
            // 
            // Hisory_TextBox
            // 
            this.Hisory_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.Hisory_TextBox.Font = new System.Drawing.Font("Futura BdCn BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hisory_TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Hisory_TextBox.Location = new System.Drawing.Point(403, 117);
            this.Hisory_TextBox.Multiline = true;
            this.Hisory_TextBox.Name = "Hisory_TextBox";
            this.Hisory_TextBox.ReadOnly = true;
            this.Hisory_TextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Hisory_TextBox.Size = new System.Drawing.Size(252, 399);
            this.Hisory_TextBox.TabIndex = 37;
            this.Hisory_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Hisory_TextBox.TextChanged += new System.EventHandler(this.Hisory_TextBox_TextChanged);
            // 
            // ResultBox_Border
            // 
            this.ResultBox_Border.BackColor = System.Drawing.Color.DimGray;
            this.ResultBox_Border.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultBox_Border.Font = new System.Drawing.Font("Futura BdCn BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultBox_Border.Location = new System.Drawing.Point(13, 12);
            this.ResultBox_Border.Multiline = true;
            this.ResultBox_Border.Name = "ResultBox_Border";
            this.ResultBox_Border.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResultBox_Border.Size = new System.Drawing.Size(373, 5);
            this.ResultBox_Border.TabIndex = 38;
            this.ResultBox_Border.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ResultBox_Border1
            // 
            this.ResultBox_Border1.BackColor = System.Drawing.Color.DimGray;
            this.ResultBox_Border1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultBox_Border1.Font = new System.Drawing.Font("Futura BdCn BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultBox_Border1.Location = new System.Drawing.Point(13, 98);
            this.ResultBox_Border1.Multiline = true;
            this.ResultBox_Border1.Name = "ResultBox_Border1";
            this.ResultBox_Border1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResultBox_Border1.Size = new System.Drawing.Size(373, 5);
            this.ResultBox_Border1.TabIndex = 39;
            this.ResultBox_Border1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ResultBox_Border4
            // 
            this.ResultBox_Border4.BackColor = System.Drawing.Color.DimGray;
            this.ResultBox_Border4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultBox_Border4.Font = new System.Drawing.Font("Futura BdCn BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultBox_Border4.Location = new System.Drawing.Point(13, 12);
            this.ResultBox_Border4.Multiline = true;
            this.ResultBox_Border4.Name = "ResultBox_Border4";
            this.ResultBox_Border4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResultBox_Border4.Size = new System.Drawing.Size(5, 89);
            this.ResultBox_Border4.TabIndex = 40;
            this.ResultBox_Border4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ResultBox_Border2
            // 
            this.ResultBox_Border2.BackColor = System.Drawing.Color.DimGray;
            this.ResultBox_Border2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultBox_Border2.Font = new System.Drawing.Font("Futura BdCn BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultBox_Border2.Location = new System.Drawing.Point(382, 13);
            this.ResultBox_Border2.Multiline = true;
            this.ResultBox_Border2.Name = "ResultBox_Border2";
            this.ResultBox_Border2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResultBox_Border2.Size = new System.Drawing.Size(5, 89);
            this.ResultBox_Border2.TabIndex = 41;
            this.ResultBox_Border2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Memory_TextBox
            // 
            this.Memory_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.Memory_TextBox.Font = new System.Drawing.Font("Futura BdCn BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Memory_TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Memory_TextBox.Location = new System.Drawing.Point(403, 117);
            this.Memory_TextBox.Multiline = true;
            this.Memory_TextBox.Name = "Memory_TextBox";
            this.Memory_TextBox.ReadOnly = true;
            this.Memory_TextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Memory_TextBox.Size = new System.Drawing.Size(252, 399);
            this.Memory_TextBox.TabIndex = 42;
            this.Memory_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Memory_TextBox.Visible = false;
            this.Memory_TextBox.TextChanged += new System.EventHandler(this.Memory_TextBox_TextChanged);
            // 
            // History_Label
            // 
            this.History_Label.AutoSize = true;
            this.History_Label.BackColor = System.Drawing.Color.Transparent;
            this.History_Label.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.History_Label.ForeColor = System.Drawing.Color.White;
            this.History_Label.Location = new System.Drawing.Point(403, 80);
            this.History_Label.Name = "History_Label";
            this.History_Label.Size = new System.Drawing.Size(172, 25);
            this.History_Label.TabIndex = 43;
            this.History_Label.Text = "There\'s no history yet.";
            // 
            // Memory_Label
            // 
            this.Memory_Label.AutoSize = true;
            this.Memory_Label.BackColor = System.Drawing.Color.Transparent;
            this.Memory_Label.Font = new System.Drawing.Font("Futura BdCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Memory_Label.ForeColor = System.Drawing.Color.White;
            this.Memory_Label.Location = new System.Drawing.Point(403, 80);
            this.Memory_Label.Name = "Memory_Label";
            this.Memory_Label.Size = new System.Drawing.Size(262, 25);
            this.Memory_Label.TabIndex = 44;
            this.Memory_Label.Text = "There\'s nothing saved in memory.";
            this.Memory_Label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BackgroundImage = global::Calculator.Properties.Resources.h70v389765261;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 543);
            this.Controls.Add(this.History_Label);
            this.Controls.Add(this.Memory_TextBox);
            this.Controls.Add(this.ResultBox_Border2);
            this.Controls.Add(this.ResultBox_Border4);
            this.Controls.Add(this.ResultBox_Border1);
            this.Controls.Add(this.ResultBox_Border);
            this.Controls.Add(this.txt_output2);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.Hisory_TextBox);
            this.Controls.Add(this.Memory_Color);
            this.Controls.Add(this.History_Color);
            this.Controls.Add(this.Memory_Button);
            this.Controls.Add(this.History_Button);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.number_dec);
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
            this.Controls.Add(this.Memory_Label);
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
        private System.Windows.Forms.TextBox txt_output2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button History_Button;
        private System.Windows.Forms.Button Memory_Button;
        private System.Windows.Forms.TextBox History_Color;
        private System.Windows.Forms.TextBox Memory_Color;
        private System.Windows.Forms.TextBox Hisory_TextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox ResultBox_Border;
        private System.Windows.Forms.TextBox ResultBox_Border1;
        private System.Windows.Forms.TextBox ResultBox_Border4;
        private System.Windows.Forms.TextBox ResultBox_Border2;
        private System.Windows.Forms.TextBox Memory_TextBox;
        private System.Windows.Forms.Label History_Label;
        private System.Windows.Forms.Label Memory_Label;
    }
}

