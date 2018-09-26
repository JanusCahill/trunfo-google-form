namespace WindowsFormsApplication1
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
            this.lbl_MyAtr = new System.Windows.Forms.Label();
            this.lbl_MyTitle = new System.Windows.Forms.Label();
            this.lbl_otherTitle = new System.Windows.Forms.Label();
            this.lbl_otherAtr = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_reiniciar = new System.Windows.Forms.Button();
            this.lbl_qntCartasOponente = new System.Windows.Forms.Label();
            this.lbl_qntCartas = new System.Windows.Forms.Label();
            this.lbl_Interrogacao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_MyAtr
            // 
            this.lbl_MyAtr.AutoSize = true;
            this.lbl_MyAtr.Location = new System.Drawing.Point(41, 147);
            this.lbl_MyAtr.Name = "lbl_MyAtr";
            this.lbl_MyAtr.Size = new System.Drawing.Size(35, 13);
            this.lbl_MyAtr.TabIndex = 0;
            this.lbl_MyAtr.Text = "label1";
            this.lbl_MyAtr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_MyTitle
            // 
            this.lbl_MyTitle.AutoSize = true;
            this.lbl_MyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MyTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_MyTitle.Location = new System.Drawing.Point(6, 35);
            this.lbl_MyTitle.Name = "lbl_MyTitle";
            this.lbl_MyTitle.Size = new System.Drawing.Size(54, 16);
            this.lbl_MyTitle.TabIndex = 1;
            this.lbl_MyTitle.Text = "hghfhg";
            // 
            // lbl_otherTitle
            // 
            this.lbl_otherTitle.AutoSize = true;
            this.lbl_otherTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_otherTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_otherTitle.Location = new System.Drawing.Point(6, 35);
            this.lbl_otherTitle.Name = "lbl_otherTitle";
            this.lbl_otherTitle.Size = new System.Drawing.Size(54, 16);
            this.lbl_otherTitle.TabIndex = 2;
            this.lbl_otherTitle.Text = "hghfhg";
            // 
            // lbl_otherAtr
            // 
            this.lbl_otherAtr.AutoSize = true;
            this.lbl_otherAtr.Location = new System.Drawing.Point(36, 147);
            this.lbl_otherAtr.Name = "lbl_otherAtr";
            this.lbl_otherAtr.Size = new System.Drawing.Size(35, 13);
            this.lbl_otherAtr.TabIndex = 3;
            this.lbl_otherAtr.Text = "label1";
            this.lbl_otherAtr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.lbl_MyTitle);
            this.groupBox1.Controls.Add(this.lbl_MyAtr);
            this.groupBox1.Location = new System.Drawing.Point(33, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 274);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sua carta";
            // 
            // radioButton4
            // 
            this.radioButton4.Location = new System.Drawing.Point(21, 221);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(16, 17);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(20, 198);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(16, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(20, 175);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(16, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(20, 152);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(16, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox2.Controls.Add(this.lbl_Interrogacao);
            this.groupBox2.Controls.Add(this.lbl_otherTitle);
            this.groupBox2.Controls.Add(this.lbl_otherAtr);
            this.groupBox2.Location = new System.Drawing.Point(396, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 274);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carta oponente";
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.Location = new System.Drawing.Point(536, 5);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_reiniciar.TabIndex = 8;
            this.btn_reiniciar.Text = "Reiniciar";
            this.btn_reiniciar.UseVisualStyleBackColor = true;
            this.btn_reiniciar.Click += new System.EventHandler(this.btn_reiniciar_Click);
            // 
            // lbl_qntCartasOponente
            // 
            this.lbl_qntCartasOponente.AutoSize = true;
            this.lbl_qntCartasOponente.Location = new System.Drawing.Point(432, 18);
            this.lbl_qntCartasOponente.Name = "lbl_qntCartasOponente";
            this.lbl_qntCartasOponente.Size = new System.Drawing.Size(35, 13);
            this.lbl_qntCartasOponente.TabIndex = 10;
            this.lbl_qntCartasOponente.Text = "label1";
            // 
            // lbl_qntCartas
            // 
            this.lbl_qntCartas.AutoSize = true;
            this.lbl_qntCartas.Location = new System.Drawing.Point(74, 18);
            this.lbl_qntCartas.Name = "lbl_qntCartas";
            this.lbl_qntCartas.Size = new System.Drawing.Size(35, 13);
            this.lbl_qntCartas.TabIndex = 5;
            this.lbl_qntCartas.Text = "label1";
            this.lbl_qntCartas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Interrogacao
            // 
            this.lbl_Interrogacao.AutoSize = true;
            this.lbl_Interrogacao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Interrogacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Interrogacao.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Interrogacao.Location = new System.Drawing.Point(26, 63);
            this.lbl_Interrogacao.Name = "lbl_Interrogacao";
            this.lbl_Interrogacao.Size = new System.Drawing.Size(0, 152);
            this.lbl_Interrogacao.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 378);
            this.Controls.Add(this.lbl_qntCartas);
            this.Controls.Add(this.lbl_qntCartasOponente);
            this.Controls.Add(this.btn_reiniciar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Trunfo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MyAtr;
        private System.Windows.Forms.Label lbl_MyTitle;
        private System.Windows.Forms.Label lbl_otherTitle;
        private System.Windows.Forms.Label lbl_otherAtr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn_reiniciar;
        private System.Windows.Forms.Label lbl_qntCartasOponente;
        private System.Windows.Forms.Label lbl_qntCartas;
        private System.Windows.Forms.Label lbl_Interrogacao;
    }
}

