
namespace GaraAuto.forms.addForms
{
	partial class AddTipAutomobil
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
			this.txt_denumire = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.btn_primary_add = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.controlBarButtons1 = new GaraAuto.forms.commonUserControls.ControlBarButtons();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_denumire
			// 
			this.txt_denumire.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_denumire.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_denumire.Location = new System.Drawing.Point(299, 143);
			this.txt_denumire.Name = "txt_denumire";
			this.txt_denumire.Size = new System.Drawing.Size(232, 24);
			this.txt_denumire.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(133, 143);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 22);
			this.label1.TabIndex = 2;
			this.label1.Text = "Denumire";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(133, 240);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 22);
			this.label2.TabIndex = 4;
			this.label2.Text = "Nr locuri";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.numericUpDown1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.numericUpDown1.Location = new System.Drawing.Point(299, 239);
			this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(136, 27);
			this.numericUpDown1.TabIndex = 5;
			this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// btn_primary_add
			// 
			this.btn_primary_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_primary_add.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_primary_add.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn_primary_add.Image = global::GaraAuto.Properties.Resources.next_black;
			this.btn_primary_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_primary_add.Location = new System.Drawing.Point(193, 337);
			this.btn_primary_add.Name = "btn_primary_add";
			this.btn_primary_add.Size = new System.Drawing.Size(129, 40);
			this.btn_primary_add.TabIndex = 6;
			this.btn_primary_add.Text = "Adauga";
			this.btn_primary_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_primary_add.UseVisualStyleBackColor = true;
			this.btn_primary_add.Click += new System.EventHandler(this.btn_primary_add_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(140, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(371, 31);
			this.label3.TabIndex = 7;
			this.label3.Text = "Adauga tipuri de automobile";
			// 
			// controlBarButtons1
			// 
			this.controlBarButtons1.BackColor = System.Drawing.Color.Transparent;
			this.controlBarButtons1.Location = new System.Drawing.Point(550, 12);
			this.controlBarButtons1.Name = "controlBarButtons1";
			this.controlBarButtons1.Size = new System.Drawing.Size(66, 33);
			this.controlBarButtons1.TabIndex = 36;
			// 
			// AddTipAutomobil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(220)))));
			this.ClientSize = new System.Drawing.Size(628, 451);
			this.Controls.Add(this.controlBarButtons1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_primary_add);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_denumire);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddTipAutomobil";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddTipAutomobil";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_denumire;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button btn_primary_add;
		private System.Windows.Forms.Label label3;
		private commonUserControls.ControlBarButtons controlBarButtons1;
	}
}