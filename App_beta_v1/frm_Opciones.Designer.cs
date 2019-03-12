namespace App_beta_v1
{
    partial class frm_Opciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Opciones));
            this.btn_suma = new System.Windows.Forms.Button();
            this.btn_resta = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_suma
            // 
            this.btn_suma.Location = new System.Drawing.Point(60, 99);
            this.btn_suma.Name = "btn_suma";
            this.btn_suma.Size = new System.Drawing.Size(108, 35);
            this.btn_suma.TabIndex = 1;
            this.btn_suma.Text = "SUMA";
            this.btn_suma.UseVisualStyleBackColor = true;
            this.btn_suma.Click += new System.EventHandler(this.btn_suma_Click);
            // 
            // btn_resta
            // 
            this.btn_resta.Location = new System.Drawing.Point(60, 140);
            this.btn_resta.Name = "btn_resta";
            this.btn_resta.Size = new System.Drawing.Size(108, 35);
            this.btn_resta.TabIndex = 2;
            this.btn_resta.Text = "RESTA";
            this.btn_resta.UseVisualStyleBackColor = true;
            this.btn_resta.Click += new System.EventHandler(this.btn_resta_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.Location = new System.Drawing.Point(60, 181);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(108, 35);
            this.btn_multi.TabIndex = 3;
            this.btn_multi.Text = "MULTIPLICACION";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
            // 
            // btn_division
            // 
            this.btn_division.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_division.Location = new System.Drawing.Point(60, 222);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(108, 35);
            this.btn_division.TabIndex = 4;
            this.btn_division.Text = "DIVISION";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "ELIJE UNA OPCION PARA \r\nEMPEZAR A ENTRENAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(172, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "VOLVER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(231, 384);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_resta);
            this.Controls.Add(this.btn_suma);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Opciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU DE OPCIONES";
            this.Load += new System.EventHandler(this.frm_Opciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_suma;
        private System.Windows.Forms.Button btn_resta;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}