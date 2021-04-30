
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
			this.cb_automobil = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cb_traseu = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_primary_add = new System.Windows.Forms.Button();
			this.controlBarButtons1 = new GaraAuto.forms.commonUserControls.ControlBarButtons();
			this.SuspendLayout();
			// 
			// cb_automobil
			// 
			this.cb_automobil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cb_automobil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cb_automobil.FormattingEnabled = true;
			this.cb_automobil.Location = new System.Drawing.Point(291, 157);
			this.cb_automobil.Name = "cb_automobil";
			this.cb_automobil.Size = new System.Drawing.Size(232, 30);
			this.cb_automobil.TabIndex = 27;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(74, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 22);
			this.label4.TabIndex = 26;
			this.label4.Text = "Automobil";
			// 
			// cb_traseu
			// 
			this.cb_traseu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cb_traseu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cb_traseu.FormattingEnabled = true;
			this.cb_traseu.Location = new System.Drawing.Point(291, 104);
			this.cb_traseu.Name = "cb_traseu";
			this.cb_traseu.Size = new System.Drawing.Size(232, 30);
			this.cb_traseu.TabIndex = 25;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(74, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 22);
			this.label2.TabIndex = 24;
			this.label2.Text = "Traseu";
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
			this.btn_primary_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_primary_add.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_primary_add.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn_primary_add.Image = global::GaraAuto.Properties.Resources.next_black;
			this.btn_primary_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_primary_add.Location = new System.Drawing.Point(217, 320);
			this.btn_primary_add.Name = "btn_primary_add";
			this.btn_primary_add.Size = new System.Drawing.Size(129, 40);
			this.btn_primary_add.TabIndex = 22;
			this.btn_primary_add.Text = "Adauga";
			this.btn_primary_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_primary_add.UseVisualStyleBackColor = true;
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
			this.ClientSize = new System.Drawing.Size(596, 373);
			this.Controls.Add(this.controlBarButtons1);
			this.Controls.Add(this.cb_automobil);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cb_traseu);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_primary_add);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddCursa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddCursa";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cb_automobil;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cb_traseu;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_primary_add;
		private commonUserControls.ControlBarButtons controlBarButtons1;
	}
}