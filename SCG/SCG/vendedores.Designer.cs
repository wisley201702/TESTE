﻿namespace SCG
{
    partial class vendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vendedores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.excluir = new System.Windows.Forms.Button();
            this.gravar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.alterar = new System.Windows.Forms.Button();
            this.novo = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvendedor = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.buscar);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.excluir);
            this.panel1.Controls.Add(this.gravar);
            this.panel1.Controls.Add(this.cancelar);
            this.panel1.Controls.Add(this.alterar);
            this.panel1.Controls.Add(this.novo);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 28);
            this.panel1.TabIndex = 1;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(579, 3);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(49, 23);
            this.buscar.TabIndex = 15;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click_1);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(376, 5);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(197, 20);
            this.id.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buscar por Id:";
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(242, 3);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(49, 23);
            this.excluir.TabIndex = 13;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // gravar
            // 
            this.gravar.Location = new System.Drawing.Point(187, 3);
            this.gravar.Name = "gravar";
            this.gravar.Size = new System.Drawing.Size(49, 23);
            this.gravar.TabIndex = 12;
            this.gravar.Text = "Gravar";
            this.gravar.UseVisualStyleBackColor = true;
            this.gravar.Click += new System.EventHandler(this.gravar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(121, 3);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(60, 23);
            this.cancelar.TabIndex = 11;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // alterar
            // 
            this.alterar.Location = new System.Drawing.Point(62, 3);
            this.alterar.Name = "alterar";
            this.alterar.Size = new System.Drawing.Size(53, 23);
            this.alterar.TabIndex = 10;
            this.alterar.Text = "Alterar";
            this.alterar.UseVisualStyleBackColor = true;
            this.alterar.Click += new System.EventHandler(this.alterar_Click);
            // 
            // novo
            // 
            this.novo.Location = new System.Drawing.Point(3, 3);
            this.novo.Name = "novo";
            this.novo.Size = new System.Drawing.Size(53, 23);
            this.novo.TabIndex = 8;
            this.novo.Text = "Novo";
            this.novo.UseVisualStyleBackColor = true;
            this.novo.Click += new System.EventHandler(this.novo_Click);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(100, 75);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(219, 20);
            this.nome.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(97, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome Vendedor:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // dgvendedor
            // 
            this.dgvendedor.AllowUserToAddRows = false;
            this.dgvendedor.AllowUserToDeleteRows = false;
            this.dgvendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvendedor.Location = new System.Drawing.Point(342, 36);
            this.dgvendedor.Name = "dgvendedor";
            this.dgvendedor.ReadOnly = true;
            this.dgvendedor.Size = new System.Drawing.Size(292, 111);
            this.dgvendedor.TabIndex = 18;
            this.dgvendedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvendedor_CellDoubleClick);
            // 
            // vendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(637, 166);
            this.Controls.Add(this.dgvendedor);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vendedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vendedores";
            this.Load += new System.EventHandler(this.vendedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button gravar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button alterar;
        private System.Windows.Forms.Button novo;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvendedor;
    }
}