namespace WindowsFormsApp1
{
    partial class Team_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Team_Detail));
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button54 = new System.Windows.Forms.Button();
            this.button53 = new System.Windows.Forms.Button();
            this.button51 = new System.Windows.Forms.Button();
            this.button52 = new System.Windows.Forms.Button();
            this.button55 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(187, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 20);
            this.label1.TabIndex = 115;
            this.label1.Text = "Team Name  I   Division Name of Conferense Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(703, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 35);
            this.button4.TabIndex = 302;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label36.Location = new System.Drawing.Point(313, 18);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(144, 29);
            this.label36.TabIndex = 303;
            this.label36.Text = "Team Detail";
            this.label36.UseMnemonic = false;
            this.label36.Click += new System.EventHandler(this.label36_Click);
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label32.Location = new System.Drawing.Point(47, 25);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(221, 35);
            this.label32.TabIndex = 305;
            this.label32.Text = "NBA Management System";
            this.label32.Click += new System.EventHandler(this.label32_Click);
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(0, 2);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(41, 58);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 304;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.rheu;
            this.pictureBox1.Location = new System.Drawing.Point(61, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 307;
            this.pictureBox1.TabStop = false;
            // 
            // button54
            // 
            this.button54.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button54.Location = new System.Drawing.Point(88, 134);
            this.button54.Name = "button54";
            this.button54.Size = new System.Drawing.Size(83, 31);
            this.button54.TabIndex = 410;
            this.button54.Text = "Matchups";
            this.button54.UseVisualStyleBackColor = false;
            this.button54.Click += new System.EventHandler(this.button54_Click);
            // 
            // button53
            // 
            this.button53.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button53.Location = new System.Drawing.Point(167, 134);
            this.button53.Name = "button53";
            this.button53.Size = new System.Drawing.Size(83, 31);
            this.button53.TabIndex = 409;
            this.button53.Text = "Lineup";
            this.button53.UseVisualStyleBackColor = false;
            this.button53.Click += new System.EventHandler(this.button53_Click);
            // 
            // button51
            // 
            this.button51.Location = new System.Drawing.Point(517, 133);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(75, 23);
            this.button51.TabIndex = 408;
            this.button51.Text = "Search";
            this.button51.UseVisualStyleBackColor = true;
            // 
            // button52
            // 
            this.button52.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button52.Location = new System.Drawing.Point(416, 133);
            this.button52.Name = "button52";
            this.button52.Size = new System.Drawing.Size(95, 23);
            this.button52.TabIndex = 407;
            this.button52.Text = "2016-2017 ";
            this.button52.UseVisualStyleBackColor = false;
            // 
            // button55
            // 
            this.button55.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button55.Location = new System.Drawing.Point(12, 134);
            this.button55.Name = "button55";
            this.button55.Size = new System.Drawing.Size(83, 31);
            this.button55.TabIndex = 411;
            this.button55.Text = "Roster";
            this.button55.UseVisualStyleBackColor = false;
            this.button55.Click += new System.EventHandler(this.button55_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(30, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(631, 183);
            this.dataGridView1.TabIndex = 412;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "PlayerId";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "LastName";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Firstname";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Height";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Weight";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "CountryCode";
            this.Column6.Name = "Column6";
            // 
            // Team_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button51);
            this.Controls.Add(this.button52);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button54);
            this.Controls.Add(this.button53);
            this.Controls.Add(this.button55);
            this.Name = "Team_Detail";
            this.Text = "Team_Detail";
            this.Load += new System.EventHandler(this.Team_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button54;
        private System.Windows.Forms.Button button53;
        private System.Windows.Forms.Button button51;
        private System.Windows.Forms.Button button52;
        private System.Windows.Forms.Button button55;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}