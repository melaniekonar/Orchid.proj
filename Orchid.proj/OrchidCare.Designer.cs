namespace Orchid.proj
{
    partial class OrchidCare
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
            this.btnCareInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWater = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFertilizer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkWater = new System.Windows.Forms.CheckBox();
            this.chkFertilizer = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCareInfo
            // 
            this.btnCareInfo.Location = new System.Drawing.Point(87, 195);
            this.btnCareInfo.Name = "btnCareInfo";
            this.btnCareInfo.Size = new System.Drawing.Size(75, 23);
            this.btnCareInfo.TabIndex = 0;
            this.btnCareInfo.Text = "Care Info";
            this.btnCareInfo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Next Watering:";
            // 
            // txtWater
            // 
            this.txtWater.Location = new System.Drawing.Point(122, 56);
            this.txtWater.Name = "txtWater";
            this.txtWater.ReadOnly = true;
            this.txtWater.Size = new System.Drawing.Size(100, 20);
            this.txtWater.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Next Fertilizing:";
            // 
            // txtFertilizer
            // 
            this.txtFertilizer.Location = new System.Drawing.Point(106, 87);
            this.txtFertilizer.Name = "txtFertilizer";
            this.txtFertilizer.ReadOnly = true;
            this.txtFertilizer.Size = new System.Drawing.Size(100, 20);
            this.txtFertilizer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Days Late Watering:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Days Late Fertilizing:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(279, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 20);
            this.textBox2.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(249, 195);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNotes
            // 
            this.btnNotes.Location = new System.Drawing.Point(168, 195);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(75, 23);
            this.btnNotes.TabIndex = 10;
            this.btnNotes.Text = "Notes";
            this.btnNotes.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(230, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 110);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // chkWater
            // 
            this.chkWater.AutoSize = true;
            this.chkWater.Location = new System.Drawing.Point(15, 21);
            this.chkWater.Name = "chkWater";
            this.chkWater.Size = new System.Drawing.Size(100, 17);
            this.chkWater.TabIndex = 12;
            this.chkWater.Text = "Watered Today";
            this.chkWater.UseVisualStyleBackColor = true;
            this.chkWater.CheckedChanged += new System.EventHandler(this.chkWater_CheckedChanged);
            // 
            // chkFertilizer
            // 
            this.chkFertilizer.AutoSize = true;
            this.chkFertilizer.Location = new System.Drawing.Point(126, 21);
            this.chkFertilizer.Name = "chkFertilizer";
            this.chkFertilizer.Size = new System.Drawing.Size(100, 17);
            this.chkFertilizer.TabIndex = 13;
            this.chkFertilizer.Text = "Fertilized Today";
            this.chkFertilizer.UseVisualStyleBackColor = true;
            this.chkFertilizer.CheckedChanged += new System.EventHandler(this.chkFertilizer_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 195);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // OrchidCare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 261);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkFertilizer);
            this.Controls.Add(this.chkWater);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFertilizer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWater);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCareInfo);
            this.Name = "OrchidCare";
            this.Text = "Orchid Care";
            this.Load += new System.EventHandler(this.OrchidCare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCareInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWater;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFertilizer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkWater;
        private System.Windows.Forms.CheckBox chkFertilizer;
        private System.Windows.Forms.Button btnSave;
    }
}

