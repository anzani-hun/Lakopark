
namespace Lakopark
{
    partial class Form_Lakopark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Lakopark));
            this.button_jobbra = new System.Windows.Forms.Button();
            this.button_balra = new System.Windows.Forms.Button();
            this.pictureBox_Nevado = new System.Windows.Forms.PictureBox();
            this.panelEpuletek = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Nevado)).BeginInit();
            this.SuspendLayout();
            // 
            // button_jobbra
            // 
            this.button_jobbra.BackgroundImage = global::Lakopark.Properties.Resources.jobbnyil;
            this.button_jobbra.Location = new System.Drawing.Point(330, 359);
            this.button_jobbra.Name = "button_jobbra";
            this.button_jobbra.Size = new System.Drawing.Size(90, 65);
            this.button_jobbra.TabIndex = 2;
            this.button_jobbra.UseVisualStyleBackColor = true;
            // 
            // button_balra
            // 
            this.button_balra.BackgroundImage = global::Lakopark.Properties.Resources.balnyil;
            this.button_balra.Location = new System.Drawing.Point(154, 359);
            this.button_balra.Name = "button_balra";
            this.button_balra.Size = new System.Drawing.Size(90, 65);
            this.button_balra.TabIndex = 1;
            this.button_balra.UseVisualStyleBackColor = true;
            // 
            // pictureBox_Nevado
            // 
            this.pictureBox_Nevado.Location = new System.Drawing.Point(44, 24);
            this.pictureBox_Nevado.Name = "pictureBox_Nevado";
            this.pictureBox_Nevado.Size = new System.Drawing.Size(113, 76);
            this.pictureBox_Nevado.TabIndex = 0;
            this.pictureBox_Nevado.TabStop = false;
            this.pictureBox_Nevado.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelEpuletek
            // 
            this.panelEpuletek.Location = new System.Drawing.Point(266, 65);
            this.panelEpuletek.Name = "panelEpuletek";
            this.panelEpuletek.Size = new System.Drawing.Size(200, 100);
            this.panelEpuletek.TabIndex = 3;
            // 
            // Form_Lakopark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelEpuletek);
            this.Controls.Add(this.button_jobbra);
            this.Controls.Add(this.button_balra);
            this.Controls.Add(this.pictureBox_Nevado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Lakopark";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Nevado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Nevado;
        private System.Windows.Forms.Button button_balra;
        private System.Windows.Forms.Button button_jobbra;
        private System.Windows.Forms.Panel panelEpuletek;
    }
}

