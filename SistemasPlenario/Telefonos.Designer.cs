namespace SistemasPlenario
{
    partial class Telefonos
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
            this.dataGridViewTelefonos = new System.Windows.Forms.DataGridView();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefonos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTelefonos
            // 
            this.dataGridViewTelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTelefonos.Location = new System.Drawing.Point(23, 52);
            this.dataGridViewTelefonos.Name = "dataGridViewTelefonos";
            this.dataGridViewTelefonos.RowTemplate.Height = 25;
            this.dataGridViewTelefonos.Size = new System.Drawing.Size(418, 150);
            this.dataGridViewTelefonos.TabIndex = 0;
            this.dataGridViewTelefonos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTelefonos_CellContentClick);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Location = new System.Drawing.Point(469, 52);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Agregar.TabIndex = 1;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(469, 103);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(469, 155);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // Telefonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.dataGridViewTelefonos);
            this.Name = "Telefonos";
            this.Text = "Telefonos";
            this.Load += new System.EventHandler(this.Telefonos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefonos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewTelefonos;
        private Button Btn_Agregar;
        private Button btn_Modificar;
        private Button btn_Eliminar;
    }
}