
using System.Windows.Forms;

namespace GaraAuto.forms.addForms
{
	partial class addLocalitate
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
			this.label1 = new System.Windows.Forms.Label();
			this.txt_localitate = new System.Windows.Forms.TextBox();
			this.cb_raion = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pb_localitate = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.txt_id = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_primary_add = new System.Windows.Forms.Button();
			this.controlBarButtons1 = new GaraAuto.forms.commonUserControls.ControlBarButtons();
			this.tooltip_help = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pb_localitate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(97, 153);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Localitate";
			// 
			// txt_localitate
			// 
			this.txt_localitate.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_localitate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_localitate.Location = new System.Drawing.Point(218, 153);
			this.txt_localitate.Name = "txt_localitate";
			this.txt_localitate.Size = new System.Drawing.Size(232, 24);
			this.txt_localitate.TabIndex = 1;
			this.txt_localitate.TextChanged += new System.EventHandler(this.txt_localitate_TextChanged);
			// 
			// cb_raion
			// 
			this.cb_raion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cb_raion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cb_raion.Location = new System.Drawing.Point(218, 225);
			this.cb_raion.Name = "cb_raion";
			this.cb_raion.Size = new System.Drawing.Size(232, 30);
			this.cb_raion.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(97, 225);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "Raion";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(201, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(239, 31);
			this.label3.TabIndex = 37;
			this.label3.Text = "Adauga localitate";
			// 
			// pb_localitate
			// 
			this.pb_localitate.Image = global::GaraAuto.Properties.Resources._false;
			this.pb_localitate.Location = new System.Drawing.Point(495, 151);
			this.pb_localitate.Name = "pb_localitate";
			this.pb_localitate.Size = new System.Drawing.Size(59, 24);
			this.pb_localitate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_localitate.TabIndex = 41;
			this.pb_localitate.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::GaraAuto.Properties.Resources.question;
			this.pictureBox3.Location = new System.Drawing.Point(495, 94);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(59, 24);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 50;
			this.pictureBox3.TabStop = false;
			// 
			// txt_id
			// 
			this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_id.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_id.Location = new System.Drawing.Point(218, 94);
			this.txt_id.Name = "txt_id";
			this.txt_id.Size = new System.Drawing.Size(232, 24);
			this.txt_id.TabIndex = 49;
			this.txt_id.TextChanged += txt_idOnTextChanged;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(97, 94);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(118, 22);
			this.label6.TabIndex = 48;
			this.label6.Text = "Id localitate";
			// 
			// btn_delete
			// 
			this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(86)))), ((int)(((byte)(80)))));
			this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_delete.ForeColor = System.Drawing.Color.White;
			this.btn_delete.Image = global::GaraAuto.Properties.Resources.delete_white;
			this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_delete.Location = new System.Drawing.Point(125, 349);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(129, 40);
			this.btn_delete.TabIndex = 52;
			this.btn_delete.Text = "Sterge";
			this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_delete.UseVisualStyleBackColor = false;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_primary_add
			// 
			this.btn_primary_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
			this.btn_primary_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_primary_add.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_primary_add.ForeColor = System.Drawing.Color.White;
			this.btn_primary_add.Image = global::GaraAuto.Properties.Resources.next_white;
			this.btn_primary_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_primary_add.Location = new System.Drawing.Point(372, 349);
			this.btn_primary_add.Name = "btn_primary_add";
			this.btn_primary_add.Size = new System.Drawing.Size(129, 40);
			this.btn_primary_add.TabIndex = 51;
			this.btn_primary_add.Text = "Adauga";
			this.btn_primary_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_primary_add.UseVisualStyleBackColor = false;
			this.btn_primary_add.Click += new System.EventHandler(this.btn_primary_add_Click);
			// 
			// controlBarButtons1
			// 
			this.controlBarButtons1.BackColor = System.Drawing.Color.Transparent;
			this.controlBarButtons1.Location = new System.Drawing.Point(550, 12);
			this.controlBarButtons1.Name = "controlBarButtons1";
			this.controlBarButtons1.Size = new System.Drawing.Size(66, 33);
			this.controlBarButtons1.TabIndex = 36;
			// 
			// tooltip_help
			// 
			this.tooltip_help.IsBalloon = true;
			this.tooltip_help.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.tooltip_help.ToolTipTitle = "Info";
			// 
			// addLocalitate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(220)))));
			this.ClientSize = new System.Drawing.Size(628, 451);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_primary_add);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.txt_id);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pb_localitate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.controlBarButtons1);
			this.Controls.Add(this.cb_raion);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_localitate);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "addLocalitate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "addLocalitate";
			((System.ComponentModel.ISupportInitialize)(this.pb_localitate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_localitate;
		private System.Windows.Forms.ComboBox cb_raion;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pb_localitate;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.TextBox txt_id;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_primary_add;
		private commonUserControls.ControlBarButtons controlBarButtons1;
		private ToolTip tooltip_help;
	}
}