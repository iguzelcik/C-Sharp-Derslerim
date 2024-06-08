namespace Uygulama13_16122021_FormUygulaması2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.olusturBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.biletIptalBtn = new System.Windows.Forms.Button();
            this.biletSatBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bosKoltukBtn = new System.Windows.Forms.Button();
            this.bakiyeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salon No:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(225, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Koltuk Sayısı:";
            // 
            // olusturBtn
            // 
            this.olusturBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.olusturBtn.Location = new System.Drawing.Point(412, 78);
            this.olusturBtn.Name = "olusturBtn";
            this.olusturBtn.Size = new System.Drawing.Size(256, 56);
            this.olusturBtn.TabIndex = 4;
            this.olusturBtn.Text = "Oluştur";
            this.olusturBtn.UseVisualStyleBackColor = true;
            this.olusturBtn.Click += new System.EventHandler(this.olusturBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.biletIptalBtn);
            this.groupBox1.Controls.Add(this.biletSatBtn);
            this.groupBox1.Location = new System.Drawing.Point(38, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 147);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış-İptal";
            // 
            // biletIptalBtn
            // 
            this.biletIptalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.biletIptalBtn.Location = new System.Drawing.Point(157, 96);
            this.biletIptalBtn.Name = "biletIptalBtn";
            this.biletIptalBtn.Size = new System.Drawing.Size(110, 39);
            this.biletIptalBtn.TabIndex = 1;
            this.biletIptalBtn.Text = "Bilet İptal";
            this.biletIptalBtn.UseVisualStyleBackColor = true;
            // 
            // biletSatBtn
            // 
            this.biletSatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.biletSatBtn.Location = new System.Drawing.Point(20, 96);
            this.biletSatBtn.Name = "biletSatBtn";
            this.biletSatBtn.Size = new System.Drawing.Size(122, 39);
            this.biletSatBtn.TabIndex = 0;
            this.biletSatBtn.Text = "Bilet Sat";
            this.biletSatBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bosKoltukBtn);
            this.groupBox2.Controls.Add(this.bakiyeBtn);
            this.groupBox2.Location = new System.Drawing.Point(398, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 147);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rapor";
            // 
            // bosKoltukBtn
            // 
            this.bosKoltukBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bosKoltukBtn.Location = new System.Drawing.Point(150, 96);
            this.bosKoltukBtn.Name = "bosKoltukBtn";
            this.bosKoltukBtn.Size = new System.Drawing.Size(120, 34);
            this.bosKoltukBtn.TabIndex = 1;
            this.bosKoltukBtn.Text = "Boş Koltuk";
            this.bosKoltukBtn.UseVisualStyleBackColor = true;
            // 
            // bakiyeBtn
            // 
            this.bakiyeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bakiyeBtn.Location = new System.Drawing.Point(14, 96);
            this.bakiyeBtn.Name = "bakiyeBtn";
            this.bakiyeBtn.Size = new System.Drawing.Size(124, 34);
            this.bakiyeBtn.TabIndex = 0;
            this.bakiyeBtn.Text = "Bakiye";
            this.bakiyeBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(41, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(658, 74);
            this.label3.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "indirimli";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.olusturBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bilet Satış";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button olusturBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button biletIptalBtn;
        private System.Windows.Forms.Button biletSatBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bosKoltukBtn;
        private System.Windows.Forms.Button bakiyeBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

