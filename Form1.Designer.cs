namespace Apartman_Otamasyon
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
            this.btn_gider = new System.Windows.Forms.Button();
            this.btn_gelir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_gider
            // 
            this.btn_gider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gider.Location = new System.Drawing.Point(97, 114);
            this.btn_gider.Name = "btn_gider";
            this.btn_gider.Size = new System.Drawing.Size(151, 183);
            this.btn_gider.TabIndex = 0;
            this.btn_gider.Text = "Gelirler";
            this.btn_gider.UseVisualStyleBackColor = true;
            this.btn_gider.Click += new System.EventHandler(this.btn_gider_Click);
            // 
            // btn_gelir
            // 
            this.btn_gelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gelir.Location = new System.Drawing.Point(310, 114);
            this.btn_gelir.Name = "btn_gelir";
            this.btn_gelir.Size = new System.Drawing.Size(151, 183);
            this.btn_gelir.TabIndex = 1;
            this.btn_gelir.Text = "Giderler";
            this.btn_gelir.UseVisualStyleBackColor = true;
            this.btn_gelir.Click += new System.EventHandler(this.btn_gelir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.btn_gelir);
            this.Controls.Add(this.btn_gider);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_gider;
        private System.Windows.Forms.Button btn_gelir;
    }
}

