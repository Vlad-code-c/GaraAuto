
namespace GaraAuto.forms.addForms
{
	partial class AddAutomobile
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
			this.components = new System.ComponentModel.Container();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_primary_add = new System.Windows.Forms.Button();
			this.txt_nrInmatriculare = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cb_tipAutomobil = new System.Windows.Forms.ComboBox();
			this.pb_nr_inmatric = new System.Windows.Forms.PictureBox();
			this.pb_tip_auto = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.tooltip_help = new System.Windows.Forms.ToolTip(this.components);
			this.btn_delete = new System.Windows.Forms.Button();
			this.controlBarButtons1 = new GaraAuto.forms.commonUserControls.ControlBarButtons();
			((System.ComponentModel.ISupportInitialize)(this.pb_nr_inmatric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_tip_auto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(182, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(264, 31);
			this.label3.TabIndex = 11;
			this.label3.Text = "Adauga automobile";
			// 
			// btn_primary_add
			// 
			this.btn_primary_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
			this.btn_primary_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_primary_add.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_primary_add.ForeColor = System.Drawing.Color.White;
			this.btn_primary_add.Image = global::GaraAuto.Properties.Resources.next_white;
			this.btn_primary_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_primary_add.Location = new System.Drawing.Point(368, 359);
			this.btn_primary_add.Name = "btn_primary_add";
			this.btn_primary_add.Size = new System.Drawing.Size(129, 40);
			this.btn_primary_add.TabIndex = 10;
			this.btn_primary_add.Text = "Adauga";
			this.btn_primary_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_primary_add.UseVisualStyleBackColor = false;
			this.btn_primary_add.Click += new System.EventHandler(this.btn_primary_add_Click);
			// 
			// txt_nrInmatriculare
			// 
			this.txt_nrInmatriculare.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_nrInmatriculare.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_nrInmatriculare.Location = new System.Drawing.Point(280, 170);
			this.txt_nrInmatriculare.Name = "txt_nrInmatriculare";
			this.txt_nrInmatriculare.Size = new System.Drawing.Size(232, 24);
			this.txt_nrInmatriculare.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(85, 170);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 22);
			this.label1.TabIndex = 8;
			this.label1.Text = "Nr inmatriculare";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(85, 248);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 22);
			this.label2.TabIndex = 12;
			this.label2.Text = "Tip automobil";
			// 
			// cb_tipAutomobil
			// 
			this.cb_tipAutomobil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cb_tipAutomobil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cb_tipAutomobil.FormattingEnabled = true;
			this.cb_tipAutomobil.Location = new System.Drawing.Point(280, 240);
			this.cb_tipAutomobil.Name = "cb_tipAutomobil";
			this.cb_tipAutomobil.Size = new System.Drawing.Size(232, 30);
			this.cb_tipAutomobil.TabIndex = 13;
			// 
			// pb_nr_inmatric
			// 
			this.pb_nr_inmatric.Image = global::GaraAuto.Properties.Resources._false;
			this.pb_nr_inmatric.Location = new System.Drawing.Point(550, 170);
			this.pb_nr_inmatric.Name = "pb_nr_inmatric";
			this.pb_nr_inmatric.Size = new System.Drawing.Size(59, 24);
			this.pb_nr_inmatric.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_nr_inmatric.TabIndex = 38;
			this.pb_nr_inmatric.TabStop = false;
			// 
			// pb_tip_auto
			// 
			this.pb_tip_auto.Image = global::GaraAuto.Properties.Resources._false;
			this.pb_tip_auto.Location = new System.Drawing.Point(550, 240);
			this.pb_tip_auto.Name = "pb_tip_auto";
			this.pb_tip_auto.Size = new System.Drawing.Size(59, 30);
			this.pb_tip_auto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_tip_auto.TabIndex = 39;
			this.pb_tip_auto.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::GaraAuto.Properties.Resources.question;
			this.pictureBox3.Location = new System.Drawing.Point(550, 102);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(59, 24);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 42;
			this.pictureBox3.TabStop = false;
			// 
			// txt_id
			// 

			// 
			// tooltip_help
			// 
			this.tooltip_help.IsBalloon = true;
			this.tooltip_help.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.tooltip_help.ToolTipTitle = "Info";
			// 
			// btn_delete
			// 
			this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(86)))), ((int)(((byte)(80)))));
			this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_delete.ForeColor = System.Drawing.Color.White;
			this.btn_delete.Image = global::GaraAuto.Properties.Resources.delete_white;
			this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_delete.Location = new System.Drawing.Point(121, 359);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(129, 40);
			this.btn_delete.TabIndex = 43;
			this.btn_delete.Text = "Sterge";
			this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_delete.UseVisualStyleBackColor = false;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// controlBarButtons1
			// 
			this.controlBarButtons1.BackColor = System.Drawing.Color.Transparent;
			this.controlBarButtons1.Location = new System.Drawing.Point(550, 12);
			this.controlBarButtons1.Name = "controlBarButtons1";
			this.controlBarButtons1.Size = new System.Drawing.Size(66, 33);
			this.controlBarButtons1.TabIndex = 36;
			// 
			// AddAutomobile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(220)))));
			this.ClientSize = new System.Drawing.Size(628, 451);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pb_tip_auto);
			this.Controls.Add(this.pb_nr_inmatric);
			this.Controls.Add(this.controlBarButtons1);
			this.Controls.Add(this.cb_tipAutomobil);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_primary_add);
			this.Controls.Add(this.txt_nrInmatriculare);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddAutomobile";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddAutomobile";
			((System.ComponentModel.ISupportInitialize)(this.pb_nr_inmatric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_tip_auto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_primary_add;
		private System.Windows.Forms.TextBox txt_nrInmatriculare;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cb_tipAutomobil;
		private System.Windows.Forms.PictureBox pb_nr_inmatric;
		private System.Windows.Forms.PictureBox pb_tip_auto;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.ToolTip tooltip_help;
		private System.Windows.Forms.Button btn_delete;
		private commonUserControls.ControlBarButtons controlBarButtons1;
	}
}