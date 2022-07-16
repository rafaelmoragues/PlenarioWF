namespace SistemasPlenario
{
    partial class Personas
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
            this.dataGridViewPersonas = new System.Windows.Forms.DataGridView();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Ver = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txb_buscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPersonas
            // 
            this.dataGridViewPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonas.Location = new System.Drawing.Point(21, 31);
            this.dataGridViewPersonas.Name = "dataGridViewPersonas";
            this.dataGridViewPersonas.RowTemplate.Height = 25;
            this.dataGridViewPersonas.Size = new System.Drawing.Size(653, 245);
            this.dataGridViewPersonas.TabIndex = 0;
            this.dataGridViewPersonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersonas_CellContentClick);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(21, 303);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 1;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(129, 303);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(234, 303);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 3;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Ver
            // 
            this.btn_Ver.Location = new System.Drawing.Point(334, 303);
            this.btn_Ver.Name = "btn_Ver";
            this.btn_Ver.Size = new System.Drawing.Size(100, 23);
            this.btn_Ver.TabIndex = 4;
            this.btn_Ver.Text = "Ver telefonos";
            this.btn_Ver.UseVisualStyleBackColor = true;
            this.btn_Ver.Click += new System.EventHandler(this.btn_Ver_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(599, 303);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 5;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txb_buscar
            // 
            this.txb_buscar.Location = new System.Drawing.Point(466, 303);
            this.txb_buscar.Name = "txb_buscar";
            this.txb_buscar.Size = new System.Drawing.Size(127, 23);
            this.txb_buscar.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(653, 121);
            this.dataGridView1.TabIndex = 7;
            // 
            // Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txb_buscar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Ver);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.dataGridViewPersonas);
            this.Name = "Personas";
            this.Text = "Agenda de contactos";
            this.Load += new System.EventHandler(this.Personas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewPersonas;
        private Button btn_Agregar;
        private Button btn_Eliminar;
        private Button btn_Modificar;
        private Button btn_Ver;
        private Button btn_Buscar;
        private TextBox txb_buscar;
        private DataGridView dataGridView1;
    }
}