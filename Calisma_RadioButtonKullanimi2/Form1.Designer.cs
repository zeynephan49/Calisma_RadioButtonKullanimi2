
namespace Calisma_RadioButtonKullanimi2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnİlk = new System.Windows.Forms.RadioButton();
            this.radioBtnOrta = new System.Windows.Forms.RadioButton();
            this.radioBtnLisans = new System.Windows.Forms.RadioButton();
            this.radioBtnYukLis = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnYukLis);
            this.groupBox1.Controls.Add(this.radioBtnLisans);
            this.groupBox1.Controls.Add(this.radioBtnOrta);
            this.groupBox1.Controls.Add(this.radioBtnİlk);
            this.groupBox1.Location = new System.Drawing.Point(39, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MEZUNİYETİ";
            // 
            // radioBtnİlk
            // 
            this.radioBtnİlk.AutoSize = true;
            this.radioBtnİlk.Location = new System.Drawing.Point(23, 20);
            this.radioBtnİlk.Name = "radioBtnİlk";
            this.radioBtnİlk.Size = new System.Drawing.Size(91, 17);
            this.radioBtnİlk.TabIndex = 0;
            this.radioBtnİlk.TabStop = true;
            this.radioBtnİlk.Text = "İLKÖĞRETİM";
            this.radioBtnİlk.UseVisualStyleBackColor = true;
            // 
            // radioBtnOrta
            // 
            this.radioBtnOrta.AutoSize = true;
            this.radioBtnOrta.Location = new System.Drawing.Point(23, 44);
            this.radioBtnOrta.Name = "radioBtnOrta";
            this.radioBtnOrta.Size = new System.Drawing.Size(105, 17);
            this.radioBtnOrta.TabIndex = 1;
            this.radioBtnOrta.TabStop = true;
            this.radioBtnOrta.Text = "ORTAÖĞRETİM";
            this.radioBtnOrta.UseVisualStyleBackColor = true;
            // 
            // radioBtnLisans
            // 
            this.radioBtnLisans.AutoSize = true;
            this.radioBtnLisans.Location = new System.Drawing.Point(23, 68);
            this.radioBtnLisans.Name = "radioBtnLisans";
            this.radioBtnLisans.Size = new System.Drawing.Size(63, 17);
            this.radioBtnLisans.TabIndex = 2;
            this.radioBtnLisans.TabStop = true;
            this.radioBtnLisans.Text = "LİSANS";
            this.radioBtnLisans.UseVisualStyleBackColor = true;
            // 
            // radioBtnYukLis
            // 
            this.radioBtnYukLis.AutoSize = true;
            this.radioBtnYukLis.Location = new System.Drawing.Point(23, 91);
            this.radioBtnYukLis.Name = "radioBtnYukLis";
            this.radioBtnYukLis.Size = new System.Drawing.Size(106, 17);
            this.radioBtnYukLis.TabIndex = 3;
            this.radioBtnYukLis.TabStop = true;
            this.radioBtnYukLis.Text = "YÜKSEKLİSANS";
            this.radioBtnYukLis.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mezuniyeti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "______";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(231, 33);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 216);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnYukLis;
        private System.Windows.Forms.RadioButton radioBtnLisans;
        private System.Windows.Forms.RadioButton radioBtnOrta;
        private System.Windows.Forms.RadioButton radioBtnİlk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKaydet;
    }
}

