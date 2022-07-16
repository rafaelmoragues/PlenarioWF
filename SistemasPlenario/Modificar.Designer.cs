namespace SistemasPlenario
{
    partial class Modificar
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
            this.txb_Num = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_Num
            // 
            this.txb_Num.Location = new System.Drawing.Point(72, 53);
            this.txb_Num.Name = "txb_Num";
            this.txb_Num.Size = new System.Drawing.Size(100, 23);
            this.txb_Num.TabIndex = 0;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(267, 52);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 1;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txb_Num);
            this.Name = "Modificar";
            this.Text = "Modificar número existente";
            this.Load += new System.EventHandler(this.Modificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txb_Num;
        private Button btn_Guardar;
    }
}