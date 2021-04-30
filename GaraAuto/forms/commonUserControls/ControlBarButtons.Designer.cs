
namespace GaraAuto.forms.commonUserControls
{
	partial class ControlBarButtons
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.close = new System.Windows.Forms.PictureBox();
			this.minimalize = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minimalize)).BeginInit();
			this.SuspendLayout();
			// 
			// close
			// 
			this.close.Image = global::GaraAuto.Properties.Resources.close_red_light;
			this.close.Location = new System.Drawing.Point(38, 2);
			this.close.Margin = new System.Windows.Forms.Padding(5);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(25, 25);
			this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.close.TabIndex = 0;
			this.close.TabStop = false;
			// 
			// minimalize
			// 
			this.minimalize.Image = global::GaraAuto.Properties.Resources.minus_blue;
			this.minimalize.Location = new System.Drawing.Point(2, 2);
			this.minimalize.Margin = new System.Windows.Forms.Padding(5);
			this.minimalize.Name = "minimalize";
			this.minimalize.Size = new System.Drawing.Size(25, 25);
			this.minimalize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.minimalize.TabIndex = 2;
			this.minimalize.TabStop = false;
			// 
			// ControlBarButtons
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.minimalize);
			this.Controls.Add(this.close);
			this.Name = "ControlBarButtons";
			this.Size = new System.Drawing.Size(69, 30);
			((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minimalize)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox close;
		private System.Windows.Forms.PictureBox minimalize;
	}
}
