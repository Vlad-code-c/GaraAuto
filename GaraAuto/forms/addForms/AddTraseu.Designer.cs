
namespace GaraAuto.forms.addForms
{
	partial class AddTraseu
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
			this.cb_start = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_denumire = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cb_finish = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.customNumericUpDown1 = new GaraAuto.forms.commonUserControls.CustomNumericUpDown();
			this.pb_inceput = new System.Windows.Forms.PictureBox();
			this.pb_sfarsit = new System.Windows.Forms.PictureBox();
			this.pb_denumire = new System.Windows.Forms.PictureBox();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_primary_add = new System.Windows.Forms.Button();
			this.controlBarButtons1 = new GaraAuto.forms.commonUserControls.ControlBarButtons();
			((System.ComponentModel.ISupportInitialize)(this.customNumericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_inceput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_sfarsit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_denumire)).BeginInit();
			this.SuspendLayout();
			// 
			// cb_start
			// 
			this.cb_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cb_start.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cb_start.FormattingEnabled = true;
			this.cb_start.Location = new System.Drawing.Point(259, 124);
			this.cb_start.Name = "cb_start";
			this.cb_start.Size = new System.Drawing.Size(232, 30);
			this.cb_start.TabIndex = 19;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(82, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 22);
			this.label2.TabIndex = 18;
			this.label2.Text = "Inceput";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(213, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(197, 31);
			this.label3.TabIndex = 17;
			this.label3.Text = "Adauga traseu";
			// 
			// txt_denumire
			// 
			this.txt_denumire.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_denumire.Enabled = false;
			this.txt_denumire.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_denumire.Location = new System.Drawing.Point(259, 275);
			this.txt_denumire.Name = "txt_denumire";
			this.txt_denumire.Size = new System.Drawing.Size(232, 24);
			this.txt_denumire.TabIndex = 15;
			this.txt_denumire.TextChanged += new System.EventHandler(this.txt_denumire_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(82, 277);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 22);
			this.label1.TabIndex = 14;
			this.label1.Text = "Denumire";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// cb_finish
			// 
			this.cb_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cb_finish.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cb_finish.FormattingEnabled = true;
			this.cb_finish.Location = new System.Drawing.Point(259, 177);
			this.cb_finish.Name = "cb_finish";
			this.cb_finish.Size = new System.Drawing.Size(232, 30);
			this.cb_finish.TabIndex = 21;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(82, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 22);
			this.label4.TabIndex = 20;
			this.label4.Text = "Sfarsit";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(82, 230);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 22);
			this.label5.TabIndex = 37;
			this.label5.Text = "Distanta";
			// 
			// customNumericUpDown1
			// 
			this.customNumericUpDown1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.customNumericUpDown1.Location = new System.Drawing.Point(259, 228);
			this.customNumericUpDown1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.customNumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.customNumericUpDown1.Name = "customNumericUpDown1";
			this.customNumericUpDown1.Size = new System.Drawing.Size(95, 31);
			this.customNumericUpDown1.TabIndex = 39;
			this.customNumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// pb_inceput
			// 
			this.pb_inceput.Image = global::GaraAuto.Properties.Resources._false;
			this.pb_inceput.Location = new System.Drawing.Point(534, 124);
			this.pb_inceput.Name = "pb_inceput";
			this.pb_inceput.Size = new System.Drawing.Size(59, 30);
			this.pb_inceput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_inceput.TabIndex = 44;
			this.pb_inceput.TabStop = false;
			this.pb_inceput.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pb_sfarsit
			// 
			this.pb_sfarsit.Image = global::GaraAuto.Properties.Resources._false;
			this.pb_sfarsit.Location = new System.Drawing.Point(534, 177);
			this.pb_sfarsit.Name = "pb_sfarsit";
			this.pb_sfarsit.Size = new System.Drawing.Size(59, 30);
			this.pb_sfarsit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_sfarsit.TabIndex = 45;
			this.pb_sfarsit.TabStop = false;
			// 
			// pb_denumire
			// 
			this.pb_denumire.Image = global::GaraAuto.Properties.Resources._false;
			this.pb_denumire.Location = new System.Drawing.Point(534, 275);
			this.pb_denumire.Name = "pb_denumire";
			this.pb_denumire.Size = new System.Drawing.Size(59, 24);
			this.pb_denumire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_denumire.TabIndex = 46;
			this.pb_denumire.TabStop = false;
			// 
			// btn_delete
			// 
			this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(86)))), ((int)(((byte)(80)))));
			this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_delete.ForeColor = System.Drawing.Color.White;
			this.btn_delete.Image = global::GaraAuto.Properties.Resources.delete_white;
			this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_delete.Location = new System.Drawing.Point(115, 362);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(129, 40);
			this.btn_delete.TabIndex = 54;
			this.btn_delete.Text = "Sterge";
			this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_delete.UseVisualStyleBackColor = false;
			// 
			// btn_primary_add
			// 
			this.btn_primary_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
			this.btn_primary_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_primary_add.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_primary_add.ForeColor = System.Drawing.Color.White;
			this.btn_primary_add.Image = global::GaraAuto.Properties.Resources.next_white;
			this.btn_primary_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_primary_add.Location = new System.Drawing.Point(362, 362);
			this.btn_primary_add.Name = "btn_primary_add";
			this.btn_primary_add.Size = new System.Drawing.Size(129, 40);
			this.btn_primary_add.TabIndex = 53;
			this.btn_primary_add.Text = "Adauga";
			this.btn_primary_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_primary_add.UseVisualStyleBackColor = false;
			this.btn_primary_add.Click += new System.EventHandler(this.btn_primary_add_Click);
			// 
			// controlBarButtons1
			// 
			this.controlBarButtons1.BackColor = System.Drawing.Color.Transparent;
			this.controlBarButtons1.Location = new System.Drawing.Point(534, 12);
			this.controlBarButtons1.Name = "controlBarButtons1";
			this.controlBarButtons1.Size = new System.Drawing.Size(66, 33);
			this.controlBarButtons1.TabIndex = 36;
			// 
			// AddTraseu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(220)))));
			this.ClientSize = new System.Drawing.Size(628, 451);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_primary_add);
			this.Controls.Add(this.pb_denumire);
			this.Controls.Add(this.pb_sfarsit);
			this.Controls.Add(this.pb_inceput);
			this.Controls.Add(this.customNumericUpDown1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.controlBarButtons1);
			this.Controls.Add(this.cb_finish);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cb_start);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_denumire);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddTraseu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddTraseu";
			((System.ComponentModel.ISupportInitialize)(this.customNumericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_inceput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_sfarsit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_denumire)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cb_start;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_denumire;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cb_finish;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private commonUserControls.CustomNumericUpDown customNumericUpDown1;
		private System.Windows.Forms.PictureBox pb_inceput;
		private System.Windows.Forms.PictureBox pb_sfarsit;
		private System.Windows.Forms.PictureBox pb_denumire;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_primary_add;
		private commonUserControls.ControlBarButtons controlBarButtons1;
	}
}