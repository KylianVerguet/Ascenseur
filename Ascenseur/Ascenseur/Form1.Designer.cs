namespace Ascenseur
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.monter = new System.Windows.Forms.Button();
            this.descendre = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.etage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monter
            // 
            this.monter.Location = new System.Drawing.Point(86, 51);
            this.monter.Name = "monter";
            this.monter.Size = new System.Drawing.Size(110, 23);
            this.monter.TabIndex = 0;
            this.monter.Text = "Monter";
            this.monter.UseVisualStyleBackColor = true;
            this.monter.Click += new System.EventHandler(this.monter_Click);
            // 
            // descendre
            // 
            this.descendre.Location = new System.Drawing.Point(86, 129);
            this.descendre.Name = "descendre";
            this.descendre.Size = new System.Drawing.Size(110, 23);
            this.descendre.TabIndex = 1;
            this.descendre.Text = "Descendre";
            this.descendre.UseVisualStyleBackColor = true;
            this.descendre.Click += new System.EventHandler(this.descendre_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(77, 322);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "Quitter";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Position";
            // 
            // etage
            // 
            this.etage.AutoSize = true;
            this.etage.Location = new System.Drawing.Point(400, 153);
            this.etage.Name = "etage";
            this.etage.Size = new System.Drawing.Size(14, 16);
            this.etage.TabIndex = 4;
            this.etage.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.etage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.descendre);
            this.Controls.Add(this.monter);
            this.Name = "Form1";
            this.Text = "a";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button monter;
        private System.Windows.Forms.Button descendre;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label etage;
    }
}

