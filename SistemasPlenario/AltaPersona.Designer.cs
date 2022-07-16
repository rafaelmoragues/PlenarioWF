namespace SistemasPlenario
{
    partial class AltaPersona
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
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.txb_FNac = new System.Windows.Forms.TextBox();
            this.txb_Cred = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(579, 63);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 0;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Credito Maximo";
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.Location = new System.Drawing.Point(31, 47);
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.Size = new System.Drawing.Size(100, 23);
            this.txb_Nombre.TabIndex = 4;
            // 
            // txb_FNac
            // 
            this.txb_FNac.Location = new System.Drawing.Point(31, 133);
            this.txb_FNac.Name = "txb_FNac";
            this.txb_FNac.Size = new System.Drawing.Size(100, 23);
            this.txb_FNac.TabIndex = 5;
            // 
            // txb_Cred
            // 
            this.txb_Cred.Location = new System.Drawing.Point(31, 215);
            this.txb_Cred.Name = "txb_Cred";
            this.txb_Cred.Size = new System.Drawing.Size(100, 23);
            this.txb_Cred.TabIndex = 6;
            // 
            // AltaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_Cred);
            this.Controls.Add(this.txb_FNac);
            this.Controls.Add(this.txb_Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Guardar);
            this.Name = "AltaPersona";
            this.Text = "AltaPersona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Guardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txb_Nombre;
        private TextBox txb_FNac;
        private TextBox txb_Cred;
    }
}