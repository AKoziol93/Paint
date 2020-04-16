namespace Paint
{
    partial class MicroPaint
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
            this.imgObrazek = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.czyscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.lblkolor = new System.Windows.Forms.Label();
            this.buttKolory = new System.Windows.Forms.Button();
            this.trkSize = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgObrazek)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkSize)).BeginInit();
            this.SuspendLayout();
            // 
            // imgObrazek
            // 
            this.imgObrazek.BackColor = System.Drawing.Color.White;
            this.imgObrazek.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgObrazek.Location = new System.Drawing.Point(105, 122);
            this.imgObrazek.Name = "imgObrazek";
            this.imgObrazek.Size = new System.Drawing.Size(524, 437);
            this.imgObrazek.TabIndex = 0;
            this.imgObrazek.TabStop = false;
            this.imgObrazek.Click += new System.EventHandler(this.imgObrazek_Click);
            this.imgObrazek.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgObrazek_MouseDown);
            this.imgObrazek.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgObrazek_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.zapiszToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.toolStripSeparator1,
            this.zamknijToolStripMenuItem,
            this.toolStripSeparator5});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(154, 6);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.zamknijToolStripMenuItem.Text = "zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(154, 6);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator7,
            this.czyscToolStripMenuItem,
            this.toolStripSeparator4});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            this.edycjaToolStripMenuItem.Click += new System.EventHandler(this.edycjaToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(157, 6);
            // 
            // czyscToolStripMenuItem
            // 
            this.czyscToolStripMenuItem.Name = "czyscToolStripMenuItem";
            this.czyscToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.czyscToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.czyscToolStripMenuItem.Text = "Czysc";
            this.czyscToolStripMenuItem.Click += new System.EventHandler(this.czyscToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(157, 6);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolorToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.formatToolStripMenuItem.Text = "format";
            // 
            // kolorToolStripMenuItem
            // 
            this.kolorToolStripMenuItem.Name = "kolorToolStripMenuItem";
            this.kolorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.kolorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kolorToolStripMenuItem.Text = "Kolor";
            this.kolorToolStripMenuItem.Click += new System.EventHandler(this.kolorToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(105, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 26);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(148, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 26);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(191, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 26);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.Location = new System.Drawing.Point(234, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 26);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Olive;
            this.button5.Location = new System.Drawing.Point(406, 52);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 26);
            this.button5.TabIndex = 10;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Fuchsia;
            this.button6.Location = new System.Drawing.Point(363, 52);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 26);
            this.button6.TabIndex = 9;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Maroon;
            this.button7.Location = new System.Drawing.Point(320, 52);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(37, 26);
            this.button7.TabIndex = 8;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Yellow;
            this.button8.Location = new System.Drawing.Point(277, 52);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(37, 26);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Maroon;
            this.button9.Location = new System.Drawing.Point(406, 84);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(37, 26);
            this.button9.TabIndex = 18;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Green;
            this.button10.Location = new System.Drawing.Point(363, 84);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(37, 26);
            this.button10.TabIndex = 17;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.GreenYellow;
            this.button11.Location = new System.Drawing.Point(320, 84);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(37, 26);
            this.button11.TabIndex = 16;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Lime;
            this.button12.Location = new System.Drawing.Point(277, 84);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(37, 26);
            this.button12.TabIndex = 15;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button13.Location = new System.Drawing.Point(234, 84);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(37, 26);
            this.button13.TabIndex = 14;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Red;
            this.button14.Location = new System.Drawing.Point(191, 84);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(37, 26);
            this.button14.TabIndex = 13;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Black;
            this.button15.Location = new System.Drawing.Point(148, 84);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(37, 26);
            this.button15.TabIndex = 12;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(105, 84);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(37, 26);
            this.button16.TabIndex = 11;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // lblkolor
            // 
            this.lblkolor.AutoSize = true;
            this.lblkolor.BackColor = System.Drawing.Color.White;
            this.lblkolor.Location = new System.Drawing.Point(12, 53);
            this.lblkolor.MaximumSize = new System.Drawing.Size(75, 25);
            this.lblkolor.MinimumSize = new System.Drawing.Size(75, 25);
            this.lblkolor.Name = "lblkolor";
            this.lblkolor.Size = new System.Drawing.Size(75, 25);
            this.lblkolor.TabIndex = 19;
            // 
            // buttKolory
            // 
            this.buttKolory.Location = new System.Drawing.Point(9, 81);
            this.buttKolory.Name = "buttKolory";
            this.buttKolory.Size = new System.Drawing.Size(90, 26);
            this.buttKolory.TabIndex = 20;
            this.buttKolory.Text = "Kolory";
            this.buttKolory.UseVisualStyleBackColor = true;
            this.buttKolory.Click += new System.EventHandler(this.buttKolory_Click_1);
            // 
            // trkSize
            // 
            this.trkSize.LargeChange = 1;
            this.trkSize.Location = new System.Drawing.Point(519, 53);
            this.trkSize.Minimum = 1;
            this.trkSize.Name = "trkSize";
            this.trkSize.Size = new System.Drawing.Size(110, 45);
            this.trkSize.TabIndex = 21;
            this.trkSize.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trkSize.Value = 1;
            this.trkSize.Scroll += new System.EventHandler(this.tracksize_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Rozmiar";
            // 
            // lblSize
            // 
            this.lblSize.AutoEllipsis = true;
            this.lblSize.AutoSize = true;
            this.lblSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSize.Location = new System.Drawing.Point(458, 53);
            this.lblSize.MaximumSize = new System.Drawing.Size(40, 40);
            this.lblSize.MinimumSize = new System.Drawing.Size(40, 40);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(40, 40);
            this.lblSize.TabIndex = 23;
            this.lblSize.Text = "1";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MicroPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 559);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trkSize);
            this.Controls.Add(this.buttKolory);
            this.Controls.Add(this.lblkolor);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgObrazek);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(649, 597);
            this.MinimumSize = new System.Drawing.Size(649, 597);
            this.Name = "MicroPaint";
            this.Text = "MicroPaint";
            this.Load += new System.EventHandler(this.MicroPaint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgObrazek)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgObrazek;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem czyscToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label lblkolor;
        private System.Windows.Forms.Button buttKolory;
        private System.Windows.Forms.TrackBar trkSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSize;
    }
}

