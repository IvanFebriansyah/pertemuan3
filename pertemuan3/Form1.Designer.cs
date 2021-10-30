
namespace pertemuan3
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
            this.textnim = new System.Windows.Forms.TextBox();
            this.textnama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textnilaiinggris = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textnilaimanajemen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textnilaibahasa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            // 
            // textnim
            // 
            this.textnim.Location = new System.Drawing.Point(112, 33);
            this.textnim.Name = "textnim";
            this.textnim.Size = new System.Drawing.Size(132, 20);
            this.textnim.TabIndex = 1;
            // 
            // textnama
            // 
            this.textnama.Location = new System.Drawing.Point(112, 66);
            this.textnama.Name = "textnama";
            this.textnama.Size = new System.Drawing.Size(132, 20);
            this.textnama.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // textnilaiinggris
            // 
            this.textnilaiinggris.Location = new System.Drawing.Point(112, 104);
            this.textnilaiinggris.Name = "textnilaiinggris";
            this.textnilaiinggris.Size = new System.Drawing.Size(132, 20);
            this.textnilaiinggris.TabIndex = 5;
            this.textnilaiinggris.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nilai Inggris";
            // 
            // textnilaimanajemen
            // 
            this.textnilaimanajemen.Location = new System.Drawing.Point(112, 139);
            this.textnilaimanajemen.Name = "textnilaimanajemen";
            this.textnilaimanajemen.Size = new System.Drawing.Size(132, 20);
            this.textnilaimanajemen.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nilai Manajemen";
            // 
            // textnilaibahasa
            // 
            this.textnilaibahasa.Location = new System.Drawing.Point(112, 181);
            this.textnilaibahasa.Name = "textnilaibahasa";
            this.textnilaibahasa.Size = new System.Drawing.Size(132, 20);
            this.textnilaibahasa.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nilai Bahasa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "HITUNG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 287);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textnilaibahasa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textnilaimanajemen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textnilaiinggris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textnama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textnim);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encapsulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textnim;
        private System.Windows.Forms.TextBox textnama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textnilaiinggris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textnilaimanajemen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textnilaibahasa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

