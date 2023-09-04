namespace Crud1
{
    partial class Form1
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
            txtId = new TextBox();
            txtName = new TextBox();
            txtNum = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnNovo = new Button();
            btnEditar = new Button();
            btnConsultar = new Button();
            btnExibir = new Button();
            btnExcluir = new Button();
            dgvDados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(122, 52);
            txtId.Name = "txtId";
            txtId.Size = new Size(232, 23);
            txtId.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(122, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(232, 23);
            txtName.TabIndex = 1;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(122, 155);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(232, 23);
            txtNum.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 60);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 3;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 109);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 163);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 5;
            label3.Text = "Numero:";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(54, 214);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 35);
            btnNovo.TabIndex = 6;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(147, 214);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 36);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(251, 215);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 35);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnExibir
            // 
            btnExibir.Location = new Point(358, 215);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(75, 35);
            btnExibir.TabIndex = 9;
            btnExibir.Text = "Exibir";
            btnExibir.UseVisualStyleBackColor = true;
            btnExibir.Click += btnExibir_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(457, 215);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 35);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(54, 273);
            dgvDados.Name = "dgvDados";
            dgvDados.RowTemplate.Height = 25;
            dgvDados.Size = new Size(478, 165);
            dgvDados.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 500);
            Controls.Add(dgvDados);
            Controls.Add(btnExcluir);
            Controls.Add(btnExibir);
            Controls.Add(btnConsultar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNum);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtNum;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnConsultar;
        private Button btnExibir;
        private Button btnExcluir;
        private DataGridView dgvDados;
    }
}