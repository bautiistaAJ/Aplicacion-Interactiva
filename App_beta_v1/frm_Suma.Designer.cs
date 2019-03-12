namespace App_beta_v1
{
    partial class frm_Suma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Suma));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_num1 = new System.Windows.Forms.TextBox();
            this.tb_num2 = new System.Windows.Forms.TextBox();
            this.tb_res = new System.Windows.Forms.TextBox();
            this.btn_comprobar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_aciertos = new System.Windows.Forms.TextBox();
            this.tb_error = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(282, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "VOLVER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // tb_num1
            // 
            this.tb_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_num1.Location = new System.Drawing.Point(92, 181);
            this.tb_num1.Name = "tb_num1";
            this.tb_num1.ReadOnly = true;
            this.tb_num1.Size = new System.Drawing.Size(39, 31);
            this.tb_num1.TabIndex = 9;
            // 
            // tb_num2
            // 
            this.tb_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_num2.Location = new System.Drawing.Point(162, 181);
            this.tb_num2.Name = "tb_num2";
            this.tb_num2.ReadOnly = true;
            this.tb_num2.Size = new System.Drawing.Size(39, 31);
            this.tb_num2.TabIndex = 10;
            // 
            // tb_res
            // 
            this.tb_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_res.Location = new System.Drawing.Point(46, 250);
            this.tb_res.Name = "tb_res";
            this.tb_res.Size = new System.Drawing.Size(68, 31);
            this.tb_res.TabIndex = 11;
            this.tb_res.TextChanged += new System.EventHandler(this.tb_res_TextChanged);
            this.tb_res.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_res_KeyPress);
            // 
            // btn_comprobar
            // 
            this.btn_comprobar.Location = new System.Drawing.Point(46, 287);
            this.btn_comprobar.Name = "btn_comprobar";
            this.btn_comprobar.Size = new System.Drawing.Size(68, 35);
            this.btn_comprobar.TabIndex = 12;
            this.btn_comprobar.Text = "Comprobar";
            this.btn_comprobar.UseVisualStyleBackColor = true;
            this.btn_comprobar.Click += new System.EventHandler(this.btn_comprobar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Su puntaje es ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contesta correctamente 5 ejercicios \r\nde suma y obten el mayor puntaje!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "+";
            // 
            // tb_aciertos
            // 
            this.tb_aciertos.Location = new System.Drawing.Point(221, 247);
            this.tb_aciertos.Name = "tb_aciertos";
            this.tb_aciertos.ReadOnly = true;
            this.tb_aciertos.Size = new System.Drawing.Size(100, 20);
            this.tb_aciertos.TabIndex = 16;
            // 
            // tb_error
            // 
            this.tb_error.Location = new System.Drawing.Point(221, 273);
            this.tb_error.Name = "tb_error";
            this.tb_error.ReadOnly = true;
            this.tb_error.Size = new System.Drawing.Size(100, 20);
            this.tb_error.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Aciertos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Errores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Escriba su respuesta";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "Iniciar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_Suma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(343, 345);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_error);
            this.Controls.Add(this.tb_aciertos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_comprobar);
            this.Controls.Add(this.tb_res);
            this.Controls.Add(this.tb_num2);
            this.Controls.Add(this.tb_num1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Suma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrenador de sumas";
            this.Load += new System.EventHandler(this.frm_Suma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_num1;
        private System.Windows.Forms.TextBox tb_num2;
        private System.Windows.Forms.TextBox tb_res;
        private System.Windows.Forms.Button btn_comprobar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_aciertos;
        private System.Windows.Forms.TextBox tb_error;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}