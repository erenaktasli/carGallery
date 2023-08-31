
namespace ComboboxCarModel
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMarka = new System.Windows.Forms.ComboBox();
            this.comboBoxModelYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewCar = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MARKA";
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarka.FormattingEnabled = true;
            this.comboBoxMarka.Location = new System.Drawing.Point(291, 31);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(233, 28);
            this.comboBoxMarka.TabIndex = 1;
            this.comboBoxMarka.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarka_SelectedIndexChanged);
            // 
            // comboBoxModelYear
            // 
            this.comboBoxModelYear.FormattingEnabled = true;
            this.comboBoxModelYear.Location = new System.Drawing.Point(291, 188);
            this.comboBoxModelYear.Name = "comboBoxModelYear";
            this.comboBoxModelYear.Size = new System.Drawing.Size(233, 28);
            this.comboBoxModelYear.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "MODEL YILI";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(291, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(291, 140);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(233, 28);
            this.comboBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "MODEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "VERSİYON";
            // 
            // listViewCar
            // 
            this.listViewCar.HideSelection = false;
            this.listViewCar.Location = new System.Drawing.Point(164, 319);
            this.listViewCar.Name = "listViewCar";
            this.listViewCar.Size = new System.Drawing.Size(557, 119);
            this.listViewCar.TabIndex = 8;
            this.listViewCar.UseCompatibleStateImageBehavior = false;
            this.listViewCar.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(291, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 26);
            this.textBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "TUTAR";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxModelYear);
            this.Controls.Add(this.comboBoxMarka);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMarka;
        private System.Windows.Forms.ComboBox comboBoxModelYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewCar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}

