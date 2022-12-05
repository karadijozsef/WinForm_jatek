namespace WinForm_jatek
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
            this.listBox_jatekok = new System.Windows.Forms.ListBox();
            this.groupBox_jatek = new System.Windows.Forms.GroupBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.inert_button = new System.Windows.Forms.Button();
            this.textBox_mufaj = new System.Windows.Forms.TextBox();
            this.dateTimePicker_datum = new System.Windows.Forms.DateTimePicker();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_jatek.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_jatekok
            // 
            this.listBox_jatekok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_jatekok.FormattingEnabled = true;
            this.listBox_jatekok.Location = new System.Drawing.Point(0, 0);
            this.listBox_jatekok.Name = "listBox_jatekok";
            this.listBox_jatekok.Size = new System.Drawing.Size(150, 468);
            this.listBox_jatekok.TabIndex = 1;
            this.listBox_jatekok.SelectedIndexChanged += new System.EventHandler(this.listBox_jatekok_SelectedIndexChanged);
            // 
            // groupBox_jatek
            // 
            this.groupBox_jatek.Controls.Add(this.delete_button);
            this.groupBox_jatek.Controls.Add(this.update_button);
            this.groupBox_jatek.Controls.Add(this.inert_button);
            this.groupBox_jatek.Controls.Add(this.textBox_mufaj);
            this.groupBox_jatek.Controls.Add(this.dateTimePicker_datum);
            this.groupBox_jatek.Controls.Add(this.textBox_nev);
            this.groupBox_jatek.Controls.Add(this.textBox_id);
            this.groupBox_jatek.Controls.Add(this.label4);
            this.groupBox_jatek.Controls.Add(this.label3);
            this.groupBox_jatek.Controls.Add(this.label2);
            this.groupBox_jatek.Controls.Add(this.label1);
            this.groupBox_jatek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_jatek.Location = new System.Drawing.Point(150, 0);
            this.groupBox_jatek.Name = "groupBox_jatek";
            this.groupBox_jatek.Size = new System.Drawing.Size(418, 468);
            this.groupBox_jatek.TabIndex = 2;
            this.groupBox_jatek.TabStop = false;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(160, 355);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(122, 43);
            this.delete_button.TabIndex = 10;
            this.delete_button.Text = "Játék törlése";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(232, 276);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(122, 43);
            this.update_button.TabIndex = 9;
            this.update_button.Text = "Játék módosítása";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // inert_button
            // 
            this.inert_button.Location = new System.Drawing.Point(64, 276);
            this.inert_button.Name = "inert_button";
            this.inert_button.Size = new System.Drawing.Size(122, 43);
            this.inert_button.TabIndex = 8;
            this.inert_button.Text = "Játék hozzáadása";
            this.inert_button.UseVisualStyleBackColor = true;
            this.inert_button.Click += new System.EventHandler(this.inert_button_Click);
            // 
            // textBox_mufaj
            // 
            this.textBox_mufaj.Location = new System.Drawing.Point(151, 204);
            this.textBox_mufaj.Name = "textBox_mufaj";
            this.textBox_mufaj.Size = new System.Drawing.Size(100, 20);
            this.textBox_mufaj.TabIndex = 7;
            // 
            // dateTimePicker_datum
            // 
            this.dateTimePicker_datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_datum.Location = new System.Drawing.Point(151, 148);
            this.dateTimePicker_datum.MaxDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_datum.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_datum.Name = "dateTimePicker_datum";
            this.dateTimePicker_datum.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker_datum.TabIndex = 6;
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(151, 95);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(140, 20);
            this.textBox_nev.TabIndex = 5;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(151, 46);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(55, 20);
            this.textBox_id.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Műfaj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Megjelenési dátum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 468);
            this.Controls.Add(this.groupBox_jatek);
            this.Controls.Add(this.listBox_jatekok);
            this.Name = "Form1";
            this.Text = "Játékok";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_jatek.ResumeLayout(false);
            this.groupBox_jatek.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_jatekok;
        private System.Windows.Forms.GroupBox groupBox_jatek;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button inert_button;
        private System.Windows.Forms.TextBox textBox_mufaj;
        private System.Windows.Forms.DateTimePicker dateTimePicker_datum;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

