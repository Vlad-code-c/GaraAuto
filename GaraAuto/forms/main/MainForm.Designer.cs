using System.ComponentModel;

namespace GaraAuto.forms.main
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
			this.mainFormLeftSide1 = new GaraAuto.forms.main.mainFormAnimations.MainFormLeftSide();
			this.mainFormRightSide1 = new GaraAuto.forms.main.mainFormAnimations.MainFormRightSide();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panelControlBar = new System.Windows.Forms.Panel();
			this.controlBarButtons1 = new GaraAuto.forms.commonUserControls.ControlBarButtons();
			this.panelControlBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainFormLeftSide1
			// 
			this.mainFormLeftSide1.BackColor = System.Drawing.Color.Transparent;
			this.mainFormLeftSide1.Location = new System.Drawing.Point(-450, 0);
			this.mainFormLeftSide1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mainFormLeftSide1.Name = "mainFormLeftSide1";
			this.mainFormLeftSide1.Size = new System.Drawing.Size(450, 519);
			this.mainFormLeftSide1.TabIndex = 0;
			// 
			// mainFormRightSide1
			// 
			this.mainFormRightSide1.BackColor = System.Drawing.Color.Transparent;
			this.mainFormRightSide1.Location = new System.Drawing.Point(900, 0);
			this.mainFormRightSide1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mainFormRightSide1.Name = "mainFormRightSide1";
			this.mainFormRightSide1.Size = new System.Drawing.Size(450, 519);
			this.mainFormRightSide1.TabIndex = 1;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// panelControlBar
			// 
			this.panelControlBar.BackColor = System.Drawing.Color.Transparent;
			this.panelControlBar.Controls.Add(this.controlBarButtons1);
			this.panelControlBar.Location = new System.Drawing.Point(12, 12);
			this.panelControlBar.Name = "panelControlBar";
			this.panelControlBar.Size = new System.Drawing.Size(876, 40);
			this.panelControlBar.TabIndex = 2;
			// 
			// controlBarButtons1
			// 
			this.controlBarButtons1.BackColor = System.Drawing.Color.Transparent;
			this.controlBarButtons1.Location = new System.Drawing.Point(800, 5);
			this.controlBarButtons1.Margin = new System.Windows.Forms.Padding(0);
			this.controlBarButtons1.Name = "controlBarButtons1";
			this.controlBarButtons1.Size = new System.Drawing.Size(69, 28);
			this.controlBarButtons1.TabIndex = 0;
			this.controlBarButtons1.Load += new System.EventHandler(this.controlBarButtons1_Load);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(900, 519);
			this.Controls.Add(this.panelControlBar);
			this.Controls.Add(this.mainFormRightSide1);
			this.Controls.Add(this.mainFormLeftSide1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panelControlBar.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private mainFormAnimations.MainFormLeftSide mainFormLeftSide1;
		private mainFormAnimations.MainFormRightSide mainFormRightSide1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel panelControlBar;
		private commonUserControls.ControlBarButtons controlBarButtons1;
	}
}