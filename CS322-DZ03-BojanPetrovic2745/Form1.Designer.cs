namespace CS322_DZ03_BojanPetrovic2745
{
    partial class Form1
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
            this.btnZuto = new System.Windows.Forms.Button();
            this.btnPlavo = new System.Windows.Forms.Button();
            this.btnCrveno = new System.Windows.Forms.Button();
            this.btnKlikni = new System.Windows.Forms.Button();
            this.lblTextSaTb = new System.Windows.Forms.Label();
            this.tbUnesi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnZuto
            // 
            this.btnZuto.Location = new System.Drawing.Point(521, 74);
            this.btnZuto.Name = "btnZuto";
            this.btnZuto.Size = new System.Drawing.Size(75, 23);
            this.btnZuto.TabIndex = 0;
            this.btnZuto.Text = "Žuto";
            this.btnZuto.UseVisualStyleBackColor = true;
            this.btnZuto.Click += new System.EventHandler(this.btnZuto_Click);
            // 
            // btnPlavo
            // 
            this.btnPlavo.Location = new System.Drawing.Point(424, 74);
            this.btnPlavo.Name = "btnPlavo";
            this.btnPlavo.Size = new System.Drawing.Size(75, 23);
            this.btnPlavo.TabIndex = 1;
            this.btnPlavo.Text = "Plavo";
            this.btnPlavo.UseVisualStyleBackColor = true;
            this.btnPlavo.Click += new System.EventHandler(this.btnPlavo_Click);
            // 
            // btnCrveno
            // 
            this.btnCrveno.Location = new System.Drawing.Point(311, 74);
            this.btnCrveno.Name = "btnCrveno";
            this.btnCrveno.Size = new System.Drawing.Size(75, 23);
            this.btnCrveno.TabIndex = 2;
            this.btnCrveno.Text = "Crveno";
            this.btnCrveno.UseVisualStyleBackColor = true;
            this.btnCrveno.Click += new System.EventHandler(this.btnCrveno_Click);
            // 
            // btnKlikni
            // 
            this.btnKlikni.Location = new System.Drawing.Point(424, 31);
            this.btnKlikni.Name = "btnKlikni";
            this.btnKlikni.Size = new System.Drawing.Size(75, 23);
            this.btnKlikni.TabIndex = 3;
            this.btnKlikni.Text = "Klikni";
            this.btnKlikni.UseVisualStyleBackColor = true;
            this.btnKlikni.Click += new System.EventHandler(this.btnKlikni_Click);
            // 
            // lblTextSaTb
            // 
            this.lblTextSaTb.AutoSize = true;
            this.lblTextSaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextSaTb.Location = new System.Drawing.Point(545, 34);
            this.lblTextSaTb.Name = "lblTextSaTb";
            this.lblTextSaTb.Size = new System.Drawing.Size(0, 20);
            this.lblTextSaTb.TabIndex = 4;
            // 
            // tbUnesi
            // 
            this.tbUnesi.Location = new System.Drawing.Point(311, 31);
            this.tbUnesi.Name = "tbUnesi";
            this.tbUnesi.Size = new System.Drawing.Size(100, 20);
            this.tbUnesi.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbUnesi);
            this.Controls.Add(this.lblTextSaTb);
            this.Controls.Add(this.btnKlikni);
            this.Controls.Add(this.btnCrveno);
            this.Controls.Add(this.btnPlavo);
            this.Controls.Add(this.btnZuto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZuto;
        private System.Windows.Forms.Button btnPlavo;
        private System.Windows.Forms.Button btnCrveno;
        private System.Windows.Forms.Button btnKlikni;
        private System.Windows.Forms.Label lblTextSaTb;
        private System.Windows.Forms.TextBox tbUnesi;
    }
}

