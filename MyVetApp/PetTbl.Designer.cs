namespace MyVetApp
{
    partial class PetTbl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetTbl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.AnimalGender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AnimalAge = new System.Windows.Forms.TextBox();
            this.AnimalName = new System.Windows.Forms.TextBox();
            this.AnimalId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.AnimalNeutered = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AnimalColor = new System.Windows.Forms.TextBox();
            this.PetDGV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetDGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 106);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(800, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(392, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "PETS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(206, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "VETERINARY MANAGMENT SYSTEM";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(150, 520);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 36);
            this.button5.TabIndex = 33;
            this.button5.Text = "HOME";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(250, 464);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(77, 36);
            this.button6.TabIndex = 30;
            this.button6.Text = "DELETE";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(150, 464);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 36);
            this.button7.TabIndex = 29;
            this.button7.Text = "EDIT";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DodgerBlue;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.Control;
            this.button8.Location = new System.Drawing.Point(47, 464);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(78, 36);
            this.button8.TabIndex = 28;
            this.button8.Text = "ADD";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(43, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "Gender";
            // 
            // AnimalGender
            // 
            this.AnimalGender.FormattingEnabled = true;
            this.AnimalGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.AnimalGender.Location = new System.Drawing.Point(206, 305);
            this.AnimalGender.Name = "AnimalGender";
            this.AnimalGender.Size = new System.Drawing.Size(121, 21);
            this.AnimalGender.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(43, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "Age";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(43, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(43, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 21);
            this.label12.TabIndex = 21;
            this.label12.Text = "Id";
            // 
            // AnimalAge
            // 
            this.AnimalAge.Location = new System.Drawing.Point(206, 254);
            this.AnimalAge.MaxLength = 9;
            this.AnimalAge.Name = "AnimalAge";
            this.AnimalAge.Size = new System.Drawing.Size(121, 20);
            this.AnimalAge.TabIndex = 22;
            // 
            // AnimalName
            // 
            this.AnimalName.Location = new System.Drawing.Point(206, 204);
            this.AnimalName.Name = "AnimalName";
            this.AnimalName.Size = new System.Drawing.Size(121, 20);
            this.AnimalName.TabIndex = 20;
            // 
            // AnimalId
            // 
            this.AnimalId.Location = new System.Drawing.Point(206, 159);
            this.AnimalId.Name = "AnimalId";
            this.AnimalId.Size = new System.Drawing.Size(121, 20);
            this.AnimalId.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(42, 399);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 21);
            this.label13.TabIndex = 34;
            this.label13.Text = "Neutered";
            // 
            // AnimalNeutered
            // 
            this.AnimalNeutered.FormattingEnabled = true;
            this.AnimalNeutered.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.AnimalNeutered.Location = new System.Drawing.Point(206, 402);
            this.AnimalNeutered.Name = "AnimalNeutered";
            this.AnimalNeutered.Size = new System.Drawing.Size(121, 21);
            this.AnimalNeutered.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(43, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Color";
            // 
            // AnimalColor
            // 
            this.AnimalColor.Location = new System.Drawing.Point(206, 356);
            this.AnimalColor.MaxLength = 9;
            this.AnimalColor.Name = "AnimalColor";
            this.AnimalColor.Size = new System.Drawing.Size(121, 20);
            this.AnimalColor.TabIndex = 37;
            // 
            // PetDGV
            // 
            this.PetDGV.BackgroundColor = System.Drawing.Color.White;
            this.PetDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PetDGV.Location = new System.Drawing.Point(388, 156);
            this.PetDGV.Name = "PetDGV";
            this.PetDGV.Size = new System.Drawing.Size(449, 400);
            this.PetDGV.TabIndex = 38;
            this.PetDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PetDGV_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 669);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 31);
            this.panel2.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(348, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Tomasz Topór Copyright ©";
            // 
            // PetTbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(905, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PetDGV);
            this.Controls.Add(this.AnimalColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AnimalNeutered);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AnimalGender);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.AnimalAge);
            this.Controls.Add(this.AnimalName);
            this.Controls.Add(this.AnimalId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PetTbl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetTbl";
            this.Load += new System.EventHandler(this.PetTbl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox AnimalGender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox AnimalAge;
        private System.Windows.Forms.TextBox AnimalName;
        private System.Windows.Forms.TextBox AnimalId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox AnimalNeutered;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AnimalColor;
        private System.Windows.Forms.DataGridView PetDGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}