
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
			this.label1 = new System.Windows.Forms.Label();
			this.txt_localitate = new System.Windows.Forms.TextBox();
			this.txt_raion = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_primary_add = new System.Windows.Forms.Button();
			this.controlBarButtons1 = new GaraAuto.forms.commonUserControls.ControlBarButtons();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(138, 119);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Localitate";
			// 
			// txt_localitate
			// 
			this.txt_localitate.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_localitate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_localitate.Location = new System.Drawing.Point(259, 119);
			this.txt_localitate.Name = "txt_localitate";
			this.txt_localitate.Size = new System.Drawing.Size(232, 24);
			this.txt_localitate.TabIndex = 1;
			this.txt_localitate.TextChanged += new System.EventHandler(this.txt_localitate_TextChanged);
			// 
			// txt_raion
			// 
			this.txt_raion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_raion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_raion.Location = new System.Drawing.Point(259, 191);
			this.txt_raion.Name = "txt_raion";
			this.txt_raion.Size = new System.Drawing.Size(232, 24);
			this.txt_raion.TabIndex = 3;
			this.txt_raion.TextChanged += new System.EventHandler(this.txt_raion_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(138, 191);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "Raion";
			// 
			// btn_primary_add
			// 
			this.btn_primary_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_primary_add.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_primary_add.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn_primary_add.Image = global::GaraAuto.Properties.Resources.next_black;
			this.btn_primary_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_primary_add.Location = new System.Drawing.Point(218, 319);
			this.btn_primary_add.Name = "btn_primary_add";
			this.btn_primary_add.Size = new System.Drawing.Size(129, 40);
			this.btn_primary_add.TabIndex = 4;
			this.btn_primary_add.Text = "Adauga";
			this.btn_primary_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_primary_add.UseVisualStyleBackColor = true;
			// 
			// controlBarButtons1
			// 
			this.controlBarButtons1.BackColor = System.Drawing.Color.Transparent;
			this.controlBarButtons1.Location = new System.Drawing.Point(550, 12);
			this.controlBarButtons1.Name = "controlBarButtons1";
			this.controlBarButtons1.Size = new System.Drawing.Size(66, 33);
			this.controlBarButtons1.TabIndex = 36;
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
			// addLocalitate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(220)))));
			this.ClientSize = new System.Drawing.Size(628, 451);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.controlBarButtons1);
			this.Controls.Add(this.btn_primary_add);
			this.Controls.Add(this.txt_raion);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_localitate);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "addLocalitate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "addLocalitate";

			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_localitate;
		private System.Windows.Forms.TextBox txt_raion;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_primary_add;
		private commonUserControls.ControlBarButtons controlBarButtons1;
		private System.Windows.Forms.Label label3;
	}
}