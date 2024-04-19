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
            this.components = new System.ComponentModel.Container();
            this.etage2 = new System.Windows.Forms.Button();
            this.etage1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.etage = new System.Windows.Forms.Label();
            this.etage0 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // etage2
            // 
            this.etage2.Location = new System.Drawing.Point(148, 75);
            this.etage2.Name = "etage2";
            this.etage2.Size = new System.Drawing.Size(110, 40);
            this.etage2.TabIndex = 0;
            this.etage2.Text = "Appel";
            this.etage2.UseVisualStyleBackColor = true;
            this.etage2.Click += new System.EventHandler(this.etage2_Click);
            // 
            // etage1
            // 
            this.etage1.Location = new System.Drawing.Point(148, 175);
            this.etage1.Name = "etage1";
            this.etage1.Size = new System.Drawing.Size(110, 45);
            this.etage1.TabIndex = 1;
            this.etage1.Text = "Appel";
            this.etage1.UseVisualStyleBackColor = true;
            this.etage1.Click += new System.EventHandler(this.etage1_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 21);
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
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            // 
            // etage
            // 
            this.etage.AutoSize = true;
            this.etage.Location = new System.Drawing.Point(258, 24);
            this.etage.Name = "etage";
            this.etage.Size = new System.Drawing.Size(0, 16);
            this.etage.TabIndex = 4;
            // 
            // etage0
            // 
            this.etage0.Location = new System.Drawing.Point(148, 288);
            this.etage0.Name = "etage0";
            this.etage0.Size = new System.Drawing.Size(110, 45);
            this.etage0.TabIndex = 5;
            this.etage0.Text = "Appel";
            this.etage0.UseVisualStyleBackColor = true;
            this.etage0.Click += new System.EventHandler(this.etage0_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(64, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 32);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(64, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 32);
            this.panel2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(400, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 150);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ascenseur";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "etage2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "etage1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rdc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.etage0);
            this.Controls.Add(this.etage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.etage1);
            this.Controls.Add(this.etage2);
            this.Name = "Form1";
            this.Text = "a";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button etage2;
        private System.Windows.Forms.Button etage1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label etage;
        private System.Windows.Forms.Button etage0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}

