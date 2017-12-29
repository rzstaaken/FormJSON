namespace FormJSON
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTest = new System.Windows.Forms.Button();
            this.lblPunkte = new System.Windows.Forms.Label();
            this.lblFrage = new System.Windows.Forms.Label();
            this.btnAntwort3 = new System.Windows.Forms.Button();
            this.btnAntwort2 = new System.Windows.Forms.Button();
            this.btnAntwort1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(31, 232);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(546, 23);
            this.btnTest.TabIndex = 12;
            this.btnTest.Text = "Test: ";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblPunkte
            // 
            this.lblPunkte.Location = new System.Drawing.Point(645, 232);
            this.lblPunkte.Name = "lblPunkte";
            this.lblPunkte.Size = new System.Drawing.Size(192, 24);
            this.lblPunkte.TabIndex = 11;
            this.lblPunkte.Text = "Punktzahl: ";
            // 
            // lblFrage
            // 
            this.lblFrage.Location = new System.Drawing.Point(31, 53);
            this.lblFrage.Name = "lblFrage";
            this.lblFrage.Size = new System.Drawing.Size(447, 24);
            this.lblFrage.TabIndex = 10;
            this.lblFrage.Text = "Frage: ";
            // 
            // btnAntwort3
            // 
            this.btnAntwort3.Location = new System.Drawing.Point(31, 185);
            this.btnAntwort3.Name = "btnAntwort3";
            this.btnAntwort3.Size = new System.Drawing.Size(806, 23);
            this.btnAntwort3.TabIndex = 9;
            this.btnAntwort3.Tag = "2";
            this.btnAntwort3.Text = "button3";
            this.btnAntwort3.UseVisualStyleBackColor = true;
            this.btnAntwort3.Click += new System.EventHandler(this.btnAntwort1_Click);
            // 
            // btnAntwort2
            // 
            this.btnAntwort2.Location = new System.Drawing.Point(31, 142);
            this.btnAntwort2.Name = "btnAntwort2";
            this.btnAntwort2.Size = new System.Drawing.Size(806, 23);
            this.btnAntwort2.TabIndex = 8;
            this.btnAntwort2.Tag = "1";
            this.btnAntwort2.Text = "button2";
            this.btnAntwort2.UseVisualStyleBackColor = true;
            this.btnAntwort2.Click += new System.EventHandler(this.btnAntwort1_Click);
            // 
            // btnAntwort1
            // 
            this.btnAntwort1.Location = new System.Drawing.Point(31, 99);
            this.btnAntwort1.Name = "btnAntwort1";
            this.btnAntwort1.Size = new System.Drawing.Size(806, 23);
            this.btnAntwort1.TabIndex = 7;
            this.btnAntwort1.Tag = "0";
            this.btnAntwort1.Text = "button1";
            this.btnAntwort1.UseVisualStyleBackColor = true;
            this.btnAntwort1.Click += new System.EventHandler(this.btnAntwort1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 308);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblPunkte);
            this.Controls.Add(this.lblFrage);
            this.Controls.Add(this.btnAntwort3);
            this.Controls.Add(this.btnAntwort2);
            this.Controls.Add(this.btnAntwort1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblPunkte;
        private System.Windows.Forms.Label lblFrage;
        private System.Windows.Forms.Button btnAntwort3;
        private System.Windows.Forms.Button btnAntwort2;
        private System.Windows.Forms.Button btnAntwort1;
    }
}

