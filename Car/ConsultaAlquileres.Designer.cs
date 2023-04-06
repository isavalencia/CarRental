
namespace Car
{
    partial class ConsultaAlquileres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaAlquileres));
            this.panelTituloConsultaAlquiler = new System.Windows.Forms.Panel();
            this.btnMinim = new System.Windows.Forms.Button();
            this.btnMaxi = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvCAlquileres = new System.Windows.Forms.DataGridView();
            this.btnEditarAlqui = new System.Windows.Forms.Button();
            this.bntEliminarAlqui = new System.Windows.Forms.Button();
            this.btnNuevoAlqui = new System.Windows.Forms.Button();
            this.txtBuscarAlqui = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTituloConsultaAlquiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCAlquileres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTituloConsultaAlquiler
            // 
            this.panelTituloConsultaAlquiler.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelTituloConsultaAlquiler.Controls.Add(this.btnMinim);
            this.panelTituloConsultaAlquiler.Controls.Add(this.btnMaxi);
            this.panelTituloConsultaAlquiler.Controls.Add(this.btnCerrar);
            this.panelTituloConsultaAlquiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloConsultaAlquiler.Location = new System.Drawing.Point(0, 0);
            this.panelTituloConsultaAlquiler.Name = "panelTituloConsultaAlquiler";
            this.panelTituloConsultaAlquiler.Size = new System.Drawing.Size(1119, 28);
            this.panelTituloConsultaAlquiler.TabIndex = 66;
            this.panelTituloConsultaAlquiler.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTituloConsultaAlquiler_MouseMove);
            // 
            // btnMinim
            // 
            this.btnMinim.BackColor = System.Drawing.Color.Transparent;
            this.btnMinim.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinim.FlatAppearance.BorderSize = 0;
            this.btnMinim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinim.Image = ((System.Drawing.Image)(resources.GetObject("btnMinim.Image")));
            this.btnMinim.Location = new System.Drawing.Point(989, 0);
            this.btnMinim.Name = "btnMinim";
            this.btnMinim.Size = new System.Drawing.Size(47, 28);
            this.btnMinim.TabIndex = 7;
            this.btnMinim.UseVisualStyleBackColor = false;
            this.btnMinim.Click += new System.EventHandler(this.btnMinim_Click);
            // 
            // btnMaxi
            // 
            this.btnMaxi.BackColor = System.Drawing.Color.Transparent;
            this.btnMaxi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaxi.FlatAppearance.BorderSize = 0;
            this.btnMaxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxi.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxi.Image")));
            this.btnMaxi.Location = new System.Drawing.Point(1036, 0);
            this.btnMaxi.Name = "btnMaxi";
            this.btnMaxi.Size = new System.Drawing.Size(44, 28);
            this.btnMaxi.TabIndex = 9;
            this.btnMaxi.UseVisualStyleBackColor = false;
            this.btnMaxi.Click += new System.EventHandler(this.btnMaxi_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1080, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 28);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvCAlquileres
            // 
            this.dgvCAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCAlquileres.Location = new System.Drawing.Point(12, 121);
            this.dgvCAlquileres.Name = "dgvCAlquileres";
            this.dgvCAlquileres.Size = new System.Drawing.Size(936, 356);
            this.dgvCAlquileres.TabIndex = 67;
            // 
            // btnEditarAlqui
            // 
            this.btnEditarAlqui.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEditarAlqui.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditarAlqui.FlatAppearance.BorderSize = 0;
            this.btnEditarAlqui.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAlqui.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarAlqui.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarAlqui.Image")));
            this.btnEditarAlqui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAlqui.Location = new System.Drawing.Point(963, 121);
            this.btnEditarAlqui.Name = "btnEditarAlqui";
            this.btnEditarAlqui.Size = new System.Drawing.Size(144, 40);
            this.btnEditarAlqui.TabIndex = 68;
            this.btnEditarAlqui.Text = "Editar";
            this.btnEditarAlqui.UseVisualStyleBackColor = false;
            // 
            // bntEliminarAlqui
            // 
            this.bntEliminarAlqui.BackColor = System.Drawing.SystemColors.Highlight;
            this.bntEliminarAlqui.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.bntEliminarAlqui.FlatAppearance.BorderSize = 0;
            this.bntEliminarAlqui.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntEliminarAlqui.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntEliminarAlqui.Image = ((System.Drawing.Image)(resources.GetObject("bntEliminarAlqui.Image")));
            this.bntEliminarAlqui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntEliminarAlqui.Location = new System.Drawing.Point(963, 183);
            this.bntEliminarAlqui.Name = "bntEliminarAlqui";
            this.bntEliminarAlqui.Size = new System.Drawing.Size(144, 40);
            this.bntEliminarAlqui.TabIndex = 69;
            this.bntEliminarAlqui.Text = "Eliminar";
            this.bntEliminarAlqui.UseVisualStyleBackColor = false;
            // 
            // btnNuevoAlqui
            // 
            this.btnNuevoAlqui.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNuevoAlqui.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevoAlqui.FlatAppearance.BorderSize = 0;
            this.btnNuevoAlqui.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAlqui.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevoAlqui.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoAlqui.Image")));
            this.btnNuevoAlqui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoAlqui.Location = new System.Drawing.Point(12, 75);
            this.btnNuevoAlqui.Name = "btnNuevoAlqui";
            this.btnNuevoAlqui.Size = new System.Drawing.Size(210, 40);
            this.btnNuevoAlqui.TabIndex = 70;
            this.btnNuevoAlqui.Text = "Nuevo Alquiler";
            this.btnNuevoAlqui.UseVisualStyleBackColor = false;
            // 
            // txtBuscarAlqui
            // 
            this.txtBuscarAlqui.Location = new System.Drawing.Point(710, 95);
            this.txtBuscarAlqui.Name = "txtBuscarAlqui";
            this.txtBuscarAlqui.Size = new System.Drawing.Size(238, 20);
            this.txtBuscarAlqui.TabIndex = 71;
            this.txtBuscarAlqui.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 72;
            this.label1.Text = "CONSULTA ALQUILERES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(928, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultaAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarAlqui);
            this.Controls.Add(this.btnNuevoAlqui);
            this.Controls.Add(this.bntEliminarAlqui);
            this.Controls.Add(this.btnEditarAlqui);
            this.Controls.Add(this.dgvCAlquileres);
            this.Controls.Add(this.panelTituloConsultaAlquiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaAlquileres";
            this.Text = "ConsultaAlquileres";
            this.Load += new System.EventHandler(this.ConsultaAlquileres_Load);
            this.panelTituloConsultaAlquiler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCAlquileres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTituloConsultaAlquiler;
        private System.Windows.Forms.Button btnMinim;
        private System.Windows.Forms.Button btnMaxi;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvCAlquileres;
        private System.Windows.Forms.Button btnEditarAlqui;
        private System.Windows.Forms.Button bntEliminarAlqui;
        private System.Windows.Forms.Button btnNuevoAlqui;
        private System.Windows.Forms.TextBox txtBuscarAlqui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}