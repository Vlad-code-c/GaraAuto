using System.ComponentModel;

namespace GaraAuto.forms.showForms
{
    partial class ShowTipTransportCursaX
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListaPasageri = new System.Windows.Forms.DataGridView();
            this.cmbCursa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdnpPasager = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dgvListaPasageri)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(459, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cursa";
            // 
            // dgvListaPasageri
            // 
            this.dgvListaPasageri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPasageri.Location = new System.Drawing.Point(23, 130);
            this.dgvListaPasageri.Name = "dgvListaPasageri";
            this.dgvListaPasageri.RowTemplate.Height = 25;
            this.dgvListaPasageri.Size = new System.Drawing.Size(756, 308);
            this.dgvListaPasageri.TabIndex = 10;
            // 
            // cmbCursa
            // 
            this.cmbCursa.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cmbCursa.FormattingEnabled = true;
            this.cmbCursa.Location = new System.Drawing.Point(554, 74);
            this.cmbCursa.Name = "cmbCursa";
            this.cmbCursa.Size = new System.Drawing.Size(154, 30);
            this.cmbCursa.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(192, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Locuri rezervate de pasagerul X la cura Y";
            // 
            // cmbIdnpPasager
            // 
            this.cmbIdnpPasager.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cmbIdnpPasager.FormattingEnabled = true;
            this.cmbIdnpPasager.Location = new System.Drawing.Point(232, 74);
            this.cmbIdnpPasager.Name = "cmbIdnpPasager";
            this.cmbIdnpPasager.Size = new System.Drawing.Size(157, 30);
            this.cmbIdnpPasager.TabIndex = 14;
            this.cmbIdnpPasager.SelectedIndexChanged += new System.EventHandler(this.cmbIdnpPasager_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(74, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Idnp Pasager";
            // 
            // ShowPasagerXCursaY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbIdnpPasager);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCursa);
            this.Controls.Add(this.dgvListaPasageri);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowPasagerXCursaY";
            this.Text = "pasagerCursaX";
            ((System.ComponentModel.ISupportInitialize) (this.dgvListaPasageri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cmbIdnpPasager;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ComboBox cmbCursa;

        private System.Windows.Forms.DataGridView dgvListaPasageri;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}