namespace StartovniListina
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_prochazet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_prochazet_novySoubor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_minutaSelect = new System.Windows.Forms.TextBox();
            this.textBox_hodinaSelect = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_interval = new System.Windows.Forms.TextBox();
            this.button_vytvorit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_prochazet
            // 
            this.button_prochazet.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_prochazet.Location = new System.Drawing.Point(1291, 134);
            this.button_prochazet.Name = "button_prochazet";
            this.button_prochazet.Size = new System.Drawing.Size(335, 78);
            this.button_prochazet.TabIndex = 0;
            this.button_prochazet.Text = "Procházet...";
            this.button_prochazet.UseVisualStyleBackColor = true;
            this.button_prochazet.Click += new System.EventHandler(this.button_prochazet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soubor přihlášek (vstupní):";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(38, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1221, 78);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(47, 382);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(1221, 78);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(865, 72);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soubor startovní listiny (vytvářený):";
            // 
            // button_prochazet_novySoubor
            // 
            this.button_prochazet_novySoubor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_prochazet_novySoubor.Location = new System.Drawing.Point(1300, 382);
            this.button_prochazet_novySoubor.Name = "button_prochazet_novySoubor";
            this.button_prochazet_novySoubor.Size = new System.Drawing.Size(335, 78);
            this.button_prochazet_novySoubor.TabIndex = 3;
            this.button_prochazet_novySoubor.Text = "Procházet...";
            this.button_prochazet_novySoubor.UseVisualStyleBackColor = true;
            this.button_prochazet_novySoubor.Click += new System.EventHandler(this.button_prochazet_novySoubor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_minutaSelect);
            this.groupBox1.Controls.Add(this.textBox_hodinaSelect);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(47, 502);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 268);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "První startuje:";
            // 
            // textBox_minutaSelect
            // 
            this.textBox_minutaSelect.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_minutaSelect.Location = new System.Drawing.Point(291, 157);
            this.textBox_minutaSelect.Name = "textBox_minutaSelect";
            this.textBox_minutaSelect.Size = new System.Drawing.Size(324, 78);
            this.textBox_minutaSelect.TabIndex = 9;
            this.textBox_minutaSelect.Enter += new System.EventHandler(this.textBox_hodinaSelect_Enter);
            this.textBox_minutaSelect.Leave += new System.EventHandler(this.textBox_hodinaSelect_Leave);
            // 
            // textBox_hodinaSelect
            // 
            this.textBox_hodinaSelect.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_hodinaSelect.Location = new System.Drawing.Point(291, 60);
            this.textBox_hodinaSelect.Name = "textBox_hodinaSelect";
            this.textBox_hodinaSelect.Size = new System.Drawing.Size(324, 78);
            this.textBox_hodinaSelect.TabIndex = 7;
            this.textBox_hodinaSelect.Enter += new System.EventHandler(this.textBox_hodinaSelect_Enter);
            this.textBox_hodinaSelect.Leave += new System.EventHandler(this.textBox_hodinaSelect_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 72);
            this.label4.TabIndex = 8;
            this.label4.Text = "Minuta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 72);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hodina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(47, 840);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(785, 72);
            this.label5.TabIndex = 7;
            this.label5.Text = "Interval mezi závodníky (minut):";
            // 
            // textBox_interval
            // 
            this.textBox_interval.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_interval.Location = new System.Drawing.Point(838, 834);
            this.textBox_interval.Name = "textBox_interval";
            this.textBox_interval.Size = new System.Drawing.Size(324, 78);
            this.textBox_interval.TabIndex = 10;
            this.textBox_interval.Enter += new System.EventHandler(this.textBox_interval_Enter);
            this.textBox_interval.Leave += new System.EventHandler(this.textBox_interval_Leave);
            // 
            // button_vytvorit
            // 
            this.button_vytvorit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_vytvorit.Location = new System.Drawing.Point(1300, 555);
            this.button_vytvorit.Name = "button_vytvorit";
            this.button_vytvorit.Size = new System.Drawing.Size(335, 176);
            this.button_vytvorit.TabIndex = 11;
            this.button_vytvorit.Text = "Vytvořit listinu";
            this.button_vytvorit.UseVisualStyleBackColor = true;
            this.button_vytvorit.Click += new System.EventHandler(this.button_vytvorit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1730, 964);
            this.Controls.Add(this.button_vytvorit);
            this.Controls.Add(this.textBox_interval);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_prochazet_novySoubor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_prochazet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Startovní listina";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_prochazet;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button_prochazet_novySoubor;
        private GroupBox groupBox1;
        private TextBox textBox_minutaSelect;
        private TextBox textBox_hodinaSelect;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox textBox_interval;
        private Button button_vytvorit;
    }
}