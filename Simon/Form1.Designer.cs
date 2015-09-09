namespace Simon
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
            this.components = new System.ComponentModel.Container();
            this.button_Cervena = new System.Windows.Forms.Button();
            this.button_Modra = new System.Windows.Forms.Button();
            this.button_Zelena = new System.Windows.Forms.Button();
            this.button_Zluta = new System.Windows.Forms.Button();
            this.button_Zacit = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pocitadloDelkyVzoru = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Vyhodnotit = new System.Windows.Forms.Button();
            this.pomocnyTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pocitadloDelkyVzoru)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Cervena
            // 
            this.button_Cervena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.button_Cervena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Cervena.Location = new System.Drawing.Point(12, 12);
            this.button_Cervena.Name = "button_Cervena";
            this.button_Cervena.Size = new System.Drawing.Size(100, 100);
            this.button_Cervena.TabIndex = 0;
            this.button_Cervena.UseVisualStyleBackColor = false;
            this.button_Cervena.Click += new System.EventHandler(this.button_Cervena_Click);
            // 
            // button_Modra
            // 
            this.button_Modra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(241)))));
            this.button_Modra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Modra.Location = new System.Drawing.Point(12, 118);
            this.button_Modra.Name = "button_Modra";
            this.button_Modra.Size = new System.Drawing.Size(100, 100);
            this.button_Modra.TabIndex = 1;
            this.button_Modra.UseVisualStyleBackColor = false;
            this.button_Modra.Click += new System.EventHandler(this.button_Modra_Click);
            // 
            // button_Zelena
            // 
            this.button_Zelena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.button_Zelena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Zelena.Location = new System.Drawing.Point(118, 12);
            this.button_Zelena.Name = "button_Zelena";
            this.button_Zelena.Size = new System.Drawing.Size(100, 100);
            this.button_Zelena.TabIndex = 2;
            this.button_Zelena.UseVisualStyleBackColor = false;
            this.button_Zelena.Click += new System.EventHandler(this.button_Zelena_Click);
            // 
            // button_Zluta
            // 
            this.button_Zluta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.button_Zluta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Zluta.Location = new System.Drawing.Point(118, 118);
            this.button_Zluta.Name = "button_Zluta";
            this.button_Zluta.Size = new System.Drawing.Size(100, 100);
            this.button_Zluta.TabIndex = 3;
            this.button_Zluta.UseVisualStyleBackColor = false;
            this.button_Zluta.Click += new System.EventHandler(this.button_Zluta_Click);
            // 
            // button_Zacit
            // 
            this.button_Zacit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Zacit.Location = new System.Drawing.Point(12, 259);
            this.button_Zacit.Name = "button_Zacit";
            this.button_Zacit.Size = new System.Drawing.Size(100, 23);
            this.button_Zacit.TabIndex = 4;
            this.button_Zacit.Text = "Zacit hru";
            this.button_Zacit.UseVisualStyleBackColor = true;
            this.button_Zacit.Click += new System.EventHandler(this.button_Zacit_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pocitadloDelkyVzoru
            // 
            this.pocitadloDelkyVzoru.Location = new System.Drawing.Point(85, 233);
            this.pocitadloDelkyVzoru.Name = "pocitadloDelkyVzoru";
            this.pocitadloDelkyVzoru.Size = new System.Drawing.Size(47, 20);
            this.pocitadloDelkyVzoru.TabIndex = 5;
            this.pocitadloDelkyVzoru.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Delka vzoru:";
            // 
            // button_Vyhodnotit
            // 
            this.button_Vyhodnotit.Enabled = false;
            this.button_Vyhodnotit.Location = new System.Drawing.Point(118, 259);
            this.button_Vyhodnotit.Name = "button_Vyhodnotit";
            this.button_Vyhodnotit.Size = new System.Drawing.Size(103, 23);
            this.button_Vyhodnotit.TabIndex = 7;
            this.button_Vyhodnotit.Text = "Vyhodnotit";
            this.button_Vyhodnotit.UseVisualStyleBackColor = true;
            this.button_Vyhodnotit.Click += new System.EventHandler(this.button_Vyhodnotit_Click);
            // 
            // pomocnyTimer
            // 
            this.pomocnyTimer.Interval = 800;
            this.pomocnyTimer.Tick += new System.EventHandler(this.pomocnyTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 295);
            this.Controls.Add(this.button_Vyhodnotit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pocitadloDelkyVzoru);
            this.Controls.Add(this.button_Zacit);
            this.Controls.Add(this.button_Zluta);
            this.Controls.Add(this.button_Zelena);
            this.Controls.Add(this.button_Modra);
            this.Controls.Add(this.button_Cervena);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hra Simon";
            ((System.ComponentModel.ISupportInitialize)(this.pocitadloDelkyVzoru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cervena;
        private System.Windows.Forms.Button button_Modra;
        private System.Windows.Forms.Button button_Zelena;
        private System.Windows.Forms.Button button_Zluta;
        private System.Windows.Forms.Button button_Zacit;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown pocitadloDelkyVzoru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Vyhodnotit;
        private System.Windows.Forms.Timer pomocnyTimer;
    }
}

