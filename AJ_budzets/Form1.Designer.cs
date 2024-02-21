namespace AJ_budzets
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nr_alga = new System.Windows.Forms.NumericUpDown();
            this.nr_papildus = new System.Windows.Forms.NumericUpDown();
            this.nr_ire = new System.Windows.Forms.NumericUpDown();
            this.nr_partika = new System.Windows.Forms.NumericUpDown();
            this.nr_komunalie = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_budzets = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nr_alga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nr_papildus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nr_ire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nr_partika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nr_komunalie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(74, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ienākumi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(74, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Papildus ienākumi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(74, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Izdevumi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(74, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alga:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(75, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Īre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.Location = new System.Drawing.Point(74, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pārtika:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.Location = new System.Drawing.Point(74, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Komunālie maksājumi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label8.Location = new System.Drawing.Point(425, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kopējais pieejamais budžets:";
            // 
            // nr_alga
            // 
            this.nr_alga.Location = new System.Drawing.Point(235, 78);
            this.nr_alga.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nr_alga.Name = "nr_alga";
            this.nr_alga.Size = new System.Drawing.Size(120, 20);
            this.nr_alga.TabIndex = 8;
            // 
            // nr_papildus
            // 
            this.nr_papildus.Location = new System.Drawing.Point(235, 110);
            this.nr_papildus.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nr_papildus.Name = "nr_papildus";
            this.nr_papildus.Size = new System.Drawing.Size(120, 20);
            this.nr_papildus.TabIndex = 9;
            // 
            // nr_ire
            // 
            this.nr_ire.Location = new System.Drawing.Point(235, 198);
            this.nr_ire.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nr_ire.Name = "nr_ire";
            this.nr_ire.Size = new System.Drawing.Size(120, 20);
            this.nr_ire.TabIndex = 10;
            // 
            // nr_partika
            // 
            this.nr_partika.Location = new System.Drawing.Point(235, 247);
            this.nr_partika.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nr_partika.Name = "nr_partika";
            this.nr_partika.Size = new System.Drawing.Size(120, 20);
            this.nr_partika.TabIndex = 11;
            // 
            // nr_komunalie
            // 
            this.nr_komunalie.Location = new System.Drawing.Point(235, 286);
            this.nr_komunalie.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nr_komunalie.Name = "nr_komunalie";
            this.nr_komunalie.Size = new System.Drawing.Size(120, 20);
            this.nr_komunalie.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button1.Location = new System.Drawing.Point(429, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Aprēķināt budžetu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_budzets
            // 
            this.txt_budzets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txt_budzets.Location = new System.Drawing.Point(429, 271);
            this.txt_budzets.Name = "txt_budzets";
            this.txt_budzets.Size = new System.Drawing.Size(115, 26);
            this.txt_budzets.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_budzets);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nr_komunalie);
            this.Controls.Add(this.nr_partika);
            this.Controls.Add(this.nr_ire);
            this.Controls.Add(this.nr_papildus);
            this.Controls.Add(this.nr_alga);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nr_alga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nr_papildus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nr_ire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nr_partika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nr_komunalie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nr_alga;
        private System.Windows.Forms.NumericUpDown nr_papildus;
        private System.Windows.Forms.NumericUpDown nr_ire;
        private System.Windows.Forms.NumericUpDown nr_partika;
        private System.Windows.Forms.NumericUpDown nr_komunalie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_budzets;
    }
}

