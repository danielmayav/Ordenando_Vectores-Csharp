namespace Ordenando_Vectores_Daniel_Maya_Vera
{
    partial class frmArreglandoVec
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
            this.bntLlenar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.txtLlenar = new System.Windows.Forms.TextBox();
            this.txtOrdenar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam Libre", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordenando Vectores";
            // 
            // bntLlenar
            // 
            this.bntLlenar.Font = new System.Drawing.Font("Noto Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLlenar.Location = new System.Drawing.Point(33, 123);
            this.bntLlenar.Name = "bntLlenar";
            this.bntLlenar.Size = new System.Drawing.Size(145, 48);
            this.bntLlenar.TabIndex = 1;
            this.bntLlenar.Text = "Llenar";
            this.bntLlenar.UseVisualStyleBackColor = true;
            this.bntLlenar.Click += new System.EventHandler(this.bntLlenar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Noto Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(33, 253);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(145, 48);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            // 
            // txtLlenar
            // 
            this.txtLlenar.Location = new System.Drawing.Point(219, 123);
            this.txtLlenar.Multiline = true;
            this.txtLlenar.Name = "txtLlenar";
            this.txtLlenar.Size = new System.Drawing.Size(404, 48);
            this.txtLlenar.TabIndex = 3;
            // 
            // txtOrdenar
            // 
            this.txtOrdenar.Location = new System.Drawing.Point(219, 253);
            this.txtOrdenar.Multiline = true;
            this.txtOrdenar.Name = "txtOrdenar";
            this.txtOrdenar.Size = new System.Drawing.Size(404, 48);
            this.txtOrdenar.TabIndex = 4;
            // 
            // frmArreglandoVec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.txtOrdenar);
            this.Controls.Add(this.txtLlenar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.bntLlenar);
            this.Controls.Add(this.label1);
            this.Name = "frmArreglandoVec";
            this.Text = "Ordenando Vectores: Daniel Maya";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntLlenar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TextBox txtLlenar;
        private System.Windows.Forms.TextBox txtOrdenar;
    }
}

