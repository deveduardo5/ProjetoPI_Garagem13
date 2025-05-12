namespace garagem13
{
    partial class TelaCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroCliente));
            buttonCriarClienteCC = new Button();
            buttonCustomizacaoCC = new Button();
            dataGridViewCadastroCliente = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCadastroCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonCriarClienteCC
            // 
            buttonCriarClienteCC.BackColor = SystemColors.ScrollBar;
            buttonCriarClienteCC.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCriarClienteCC.Location = new Point(14, 366);
            buttonCriarClienteCC.Margin = new Padding(3, 2, 3, 2);
            buttonCriarClienteCC.Name = "buttonCriarClienteCC";
            buttonCriarClienteCC.Size = new Size(178, 30);
            buttonCriarClienteCC.TabIndex = 1;
            buttonCriarClienteCC.Text = "Criar Cliente";
            buttonCriarClienteCC.UseVisualStyleBackColor = false;
            buttonCriarClienteCC.Click += buttonIncluirCC_Click;
            // 
            // buttonCustomizacaoCC
            // 
            buttonCustomizacaoCC.BackColor = SystemColors.ScrollBar;
            buttonCustomizacaoCC.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCustomizacaoCC.Location = new Point(756, 366);
            buttonCustomizacaoCC.Margin = new Padding(3, 2, 3, 2);
            buttonCustomizacaoCC.Name = "buttonCustomizacaoCC";
            buttonCustomizacaoCC.Size = new Size(178, 30);
            buttonCustomizacaoCC.TabIndex = 3;
            buttonCustomizacaoCC.Text = "Customização";
            buttonCustomizacaoCC.UseVisualStyleBackColor = false;
            buttonCustomizacaoCC.Click += buttonCustomizacaoCC_Click_1;
            // 
            // dataGridViewCadastroCliente
            // 
            dataGridViewCadastroCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCadastroCliente.Location = new Point(14, 52);
            dataGridViewCadastroCliente.Margin = new Padding(3, 2, 3, 2);
            dataGridViewCadastroCliente.Name = "dataGridViewCadastroCliente";
            dataGridViewCadastroCliente.RowHeadersWidth = 51;
            dataGridViewCadastroCliente.Size = new Size(920, 294);
            dataGridViewCadastroCliente.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ScrollBar;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(365, 35);
            label1.TabIndex = 6;
            label1.Text = "Clientes Cadastrados";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(5000, 3334);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // TelaCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 408);
            Controls.Add(label1);
            Controls.Add(dataGridViewCadastroCliente);
            Controls.Add(buttonCustomizacaoCC);
            Controls.Add(buttonCriarClienteCC);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaCadastroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroCliente";
            Load += TelaCadastroCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCadastroCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonCriarClienteCC;
        private Button buttonCustomizacaoCC;
        private DataGridView dataGridViewCadastroCliente;
        private Label label1;
        private PictureBox pictureBox1;
    }
}