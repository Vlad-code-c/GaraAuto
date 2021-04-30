
namespace GaraAuto.forms.addForms
{
	partial class OcupaLoc
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
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_primary_add = new System.Windows.Forms.Button();
			this.txt_cursa = new System.Windows.Forms.TextBox();
			this.txt_pasager = new System.Windows.Forms.TextBox();
			this.controlBarButtons1 = new GaraAuto.forms.commonUserControls.ControlBarButtons();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(66, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 22);
			this.label4.TabIndex = 32;
			this.label4.Text = "Pasager";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(66, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 22);
			this.label1.TabIndex = 30;
			this.label1.Text = "Cursa";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(167, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(193, 31);
			this.label3.TabIndex = 29;
			this.label3.Text = "Adauga Cursa";
			// 
			// btn_primary_add
			// 
			this.btn_primary_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_primary_add.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_primary_add.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn_primary_add.Image = global::GaraAuto.Properties.Resources.next_black;
			this.btn_primary_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_primary_add.Location = new System.Drawing.Point(209, 301);
			this.btn_primary_add.Name = "btn_primary_add";
			this.btn_primary_add.Size = new System.Drawing.Size(129, 40);
			this.btn_primary_add.TabIndex = 28;
			this.btn_primary_add.Text = "Adauga";
			this.btn_primary_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_primary_add.UseVisualStyleBackColor = true;
			// 
			// txt_cursa
			// 
			this.txt_cursa.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_cursa.Enabled = false;
			this.txt_cursa.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_cursa.Location = new System.Drawing.Point(267, 91);
			this.txt_cursa.Name = "txt_cursa";
			this.txt_cursa.Size = new System.Drawing.Size(232, 24);
			this.txt_cursa.TabIndex = 33;
			// 
			// txt_pasager
			// 
			this.txt_pasager.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_pasager.Enabled = false;
			this.txt_pasager.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_pasager.Location = new System.Drawing.Point(267, 144);
			this.txt_pasager.Name = "txt_pasager";
			this.txt_pasager.Size = new System.Drawing.Size(232, 24);
			this.txt_pasager.TabIndex = 34;
			// 
			// controlBarButtons1
			// 
			this.controlBarButtons1.BackColor = System.Drawing.Color.Transparent;
			this.controlBarButtons1.Location = new System.Drawing.Point(518, 12);
			this.controlBarButtons1.Name = "controlBarButtons1";
			this.controlBarButtons1.Size = new System.Drawing.Size(66, 33);
			this.controlBarButtons1.TabIndex = 35;
			// 
			// OcupaLoc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(220)))));
			this.ClientSize = new System.Drawing.Size(596, 373);
			this.Controls.Add(this.controlBarButtons1);
			this.Controls.Add(this.txt_pasager);
			this.Controls.Add(this.txt_cursa);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_primary_add);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "OcupaLoc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OcupaLoc";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_primary_add;
		private System.Windows.Forms.ComboBox cb_pasager;
		private System.Windows.Forms.TextBox txt_cursa;
		private System.Windows.Forms.TextBox txt_pasager;
		private commonUserControls.ControlBarButtons controlBarButtons1;
	}
}