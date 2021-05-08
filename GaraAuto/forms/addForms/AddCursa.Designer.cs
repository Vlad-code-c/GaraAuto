
namespace GaraAuto.forms.addForms
{
	partial class AddCursa
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
			this.cb_tip_auto = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_primary_add = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cb_ora = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.cb_automobil = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tooltip_help = new System.Windows.Forms.ToolTip(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.txt_id = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.pb_ora = new System.Windows.Forms.PictureBox();
			this.pb_tip_auto = new System.Windows.Forms.PictureBox();
			this.pb_automobil = new System.Windows.Forms.PictureBox();
			this.pb_traseu = new System.Windows.Forms.PictureBox();
			this.btn_delete = new System.Windows.Forms.Button();
			this.controlBarButtons1 = new GaraAuto.forms.commonUserControls.ControlBarButtons();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_ora)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_tip_auto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_automobil)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_traseu)).BeginInit();
			this.SuspendLayout();
			// 
			// cb_tip_auto
			// 
			this.cb_tip_auto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cb_tip_auto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cb_tip_auto.FormattingEnabled = true;
			this.cb_tip_auto.Location = new System.Drawing.Point(246, 229);
			this.cb_tip_auto.Name = "cb_tip_auto";
			this.cb_tip_auto.Size = new System.Drawing.Size(232, 30);
			this.cb_tip_auto.TabIndex = 27;
			this.cb_tip_auto.SelectedIndexChanged += new System.EventHandler(this.cb_automobil_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(72, 237);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 22);
			this.label4.TabIndex = 26;
			this.label4.Text = "Tip Automobil";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(169, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(193, 31);
			this.label3.TabIndex = 23;
			this.label3.Text = "Adauga Cursa";
			// 
			// btn_primary_add
			// 
			this.btn_primary_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
			this.btn_primary_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_primary_add.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_primary_add.ForeColor = System.Drawing.Color.White;
			this.btn_primary_add.Image = global::GaraAuto.Properties.Resources.next_white;
			this.btn_primary_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_primary_add.Location = new System.Drawing.Point(349, 374);
			this.btn_primary_add.Name = "btn_primary_add";
			this.btn_primary_add.Size = new System.Drawing.Size(129, 40);
			this.btn_primary_add.TabIndex = 22;
			this.btn_primary_add.Text = "Adauga";
			this.btn_primary_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_primary_add.UseVisualStyleBackColor = false;
			this.btn_primary_add.Click += new System.EventHandler(this.btn_primary_add_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(72, 178);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 22);
			this.label1.TabIndex = 37;
			this.label1.Text = "Traseu";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(72, 129);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(101, 22);
			this.label5.TabIndex = 40;
			this.label5.Text = "Ora cursa";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// cb_ora
			// 
			this.cb_ora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cb_ora.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cb_ora.FormattingEnabled = true;
			this.cb_ora.Location = new System.Drawing.Point(246, 121);
			this.cb_ora.Name = "cb_ora";
			this.cb_ora.Size = new System.Drawing.Size(232, 30);
			this.cb_ora.TabIndex = 41;
			this.cb_ora.SelectedIndexChanged += new System.EventHandler(this.cb_ora_SelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox1.ForeColor = System.Drawing.Color.Black;
			this.textBox1.Location = new System.Drawing.Point(246, 169);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(232, 24);
			this.textBox1.TabIndex = 42;
			this.textBox1.Text = "Selecteaza...";
			// 
			// cb_automobil
			// 
			this.cb_automobil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cb_automobil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cb_automobil.FormattingEnabled = true;
			this.cb_automobil.Location = new System.Drawing.Point(246, 286);
			this.cb_automobil.Name = "cb_automobil";
			this.cb_automobil.Size = new System.Drawing.Size(232, 30);
			this.cb_automobil.TabIndex = 44;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(72, 294);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 22);
			this.label2.TabIndex = 43;
			this.label2.Text = "Automobil";
			// 
			// tooltip_help
			// 
			this.tooltip_help.IsBalloon = true;
			this.tooltip_help.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.tooltip_help.ToolTipTitle = "Info";
			// 
			// toolTip1
			// 
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "Info";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::GaraAuto.Properties.Resources.question;
			this.pictureBox3.Location = new System.Drawing.Point(525, 78);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(59, 24);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 47;
			this.pictureBox3.TabStop = false;
			// 
			// txt_id
			// 
			this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_id.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_id.Location = new System.Drawing.Point(246, 78);
			this.txt_id.Name = "txt_id";
			this.txt_id.Size = new System.Drawing.Size(232, 24);
			this.txt_id.TabIndex = 46;
			this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(72, 78);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 22);
			this.label6.TabIndex = 45;
			this.label6.Text = "Id cursa";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// pb_ora
			// 
			this.pb_ora.Image = global::GaraAuto.Properties.Resources._false;
			this.pb_ora.Location = new System.Drawing.Point(525, 121);
			this.pb_ora.Name = "pb_ora";
			this.pb_ora.Size = new System.Drawing.Size(59, 30);
			this.pb_ora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_ora.TabIndex = 48;
			this.pb_ora.TabStop = false;
			// 
			// pb_tip_auto
			// 
			this.pb_tip_auto.Image = global::GaraAuto.Properties.Resources._false;
			this.pb_tip_auto.Location = new System.Drawing.Point(525, 229);
			this.pb_tip_auto.Name = "pb_tip_auto";
			this.pb_tip_auto.Size = new System.Drawing.Size(59, 30);
			this.pb_tip_auto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_tip_auto.TabIndex = 49;
			this.pb_tip_auto.TabStop = false;
			// 
			// pb_automobil
			// 
			this.pb_automobil.Image = global::GaraAuto.Properties.Resources._false;
			this.pb_automobil.Location = new System.Drawing.Point(525, 286);
			this.pb_automobil.Name = "pb_automobil";
			this.pb_automobil.Size = new System.Drawing.Size(59, 30);
			this.pb_automobil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_automobil.TabIndex = 50;
			this.pb_automobil.TabStop = false;
			// 
			// pb_traseu
			// 
			this.pb_traseu.Image = global::GaraAuto.Properties.Resources._false;
			this.pb_traseu.Location = new System.Drawing.Point(525, 169);
			this.pb_traseu.Name = "pb_traseu";
			this.pb_traseu.Size = new System.Drawing.Size(59, 24);
			this.pb_traseu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_traseu.TabIndex = 51;
			this.pb_traseu.TabStop = false;
			// 
			// btn_delete
			// 
			this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(86)))), ((int)(((byte)(80)))));
			this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_delete.ForeColor = System.Drawing.Color.White;
			this.btn_delete.Image = global::GaraAuto.Properties.Resources.delete_white;
			this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_delete.Location = new System.Drawing.Point(114, 374);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(129, 40);
			this.btn_delete.TabIndex = 52;
			this.btn_delete.Text = "Sterge";
			this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_delete.UseVisualStyleBackColor = false;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// controlBarButtons1
			// 
			this.controlBarButtons1.BackColor = System.Drawing.Color.Transparent;
			this.controlBarButtons1.Location = new System.Drawing.Point(518, 12);
			this.controlBarButtons1.Name = "controlBarButtons1";
			this.controlBarButtons1.Size = new System.Drawing.Size(66, 33);
			this.controlBarButtons1.TabIndex = 36;
			// 
			// AddCursa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(220)))));
			this.ClientSize = new System.Drawing.Size(628, 451);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.pb_traseu);
			this.Controls.Add(this.pb_automobil);
			this.Controls.Add(this.pb_tip_auto);
			this.Controls.Add(this.pb_ora);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.txt_id);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cb_automobil);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.cb_ora);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.controlBarButtons1);
			this.Controls.Add(this.cb_tip_auto);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_primary_add);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddCursa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddCursa";
			this.Load += new System.EventHandler(this.AddCursa_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_ora)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_tip_auto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_automobil)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_traseu)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cb_tip_auto;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_primary_add;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cb_ora;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox cb_automobil;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolTip tooltip_help;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.TextBox txt_id;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pb_ora;
		private System.Windows.Forms.PictureBox pb_tip_auto;
		private System.Windows.Forms.PictureBox pb_automobil;
		private System.Windows.Forms.PictureBox pb_traseu;
		private System.Windows.Forms.Button btn_delete;
		private commonUserControls.ControlBarButtons controlBarButtons1;
	}
}