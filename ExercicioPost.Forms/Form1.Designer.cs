namespace ExercicioPost.Forms
{
    partial class frmPost
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
            tbTitulo = new TextBox();
            lblTitulo = new Label();
            lblDescricao = new Label();
            rtbDescricao = new RichTextBox();
            grpboxCriarPost = new GroupBox();
            lblMensagem = new Label();
            lblData = new Label();
            btnCriar = new Button();
            grpboxVerPost = new GroupBox();
            btnNaoGosto = new Button();
            lblGostos = new Label();
            btnGosto = new Button();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            grpboxCriarPost.SuspendLayout();
            grpboxVerPost.SuspendLayout();
            SuspendLayout();
            // 
            // tbTitulo
            // 
            tbTitulo.Location = new Point(71, 22);
            tbTitulo.Name = "tbTitulo";
            tbTitulo.Size = new Size(178, 23);
            tbTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(6, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(59, 21);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Titulo:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(6, 83);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(88, 21);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição:";
            // 
            // rtbDescricao
            // 
            rtbDescricao.Location = new Point(100, 83);
            rtbDescricao.Name = "rtbDescricao";
            rtbDescricao.Size = new Size(484, 88);
            rtbDescricao.TabIndex = 3;
            rtbDescricao.Text = "";
            // 
            // grpboxCriarPost
            // 
            grpboxCriarPost.Controls.Add(lblMensagem);
            grpboxCriarPost.Controls.Add(lblData);
            grpboxCriarPost.Controls.Add(lblTitulo);
            grpboxCriarPost.Controls.Add(rtbDescricao);
            grpboxCriarPost.Controls.Add(tbTitulo);
            grpboxCriarPost.Controls.Add(lblDescricao);
            grpboxCriarPost.Enabled = false;
            grpboxCriarPost.Location = new Point(21, 24);
            grpboxCriarPost.Name = "grpboxCriarPost";
            grpboxCriarPost.Size = new Size(665, 212);
            grpboxCriarPost.TabIndex = 4;
            grpboxCriarPost.TabStop = false;
            grpboxCriarPost.Text = "Criar Post";
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMensagem.ForeColor = SystemColors.WindowFrame;
            lblMensagem.Location = new Point(47, 179);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 20);
            lblMensagem.TabIndex = 5;
            lblMensagem.Visible = false;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.Location = new Point(280, 24);
            lblData.Name = "lblData";
            lblData.Size = new Size(50, 21);
            lblData.TabIndex = 4;
            lblData.Text = "Data:";
            // 
            // btnCriar
            // 
            btnCriar.Location = new Point(692, 107);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(101, 47);
            btnCriar.TabIndex = 5;
            btnCriar.Text = "Criar Post";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click;
            // 
            // grpboxVerPost
            // 
            grpboxVerPost.Controls.Add(label3);
            grpboxVerPost.Controls.Add(btnNaoGosto);
            grpboxVerPost.Controls.Add(lblGostos);
            grpboxVerPost.Controls.Add(btnGosto);
            grpboxVerPost.Controls.Add(label1);
            grpboxVerPost.Controls.Add(richTextBox1);
            grpboxVerPost.Controls.Add(textBox1);
            grpboxVerPost.Controls.Add(label2);
            grpboxVerPost.Location = new Point(21, 242);
            grpboxVerPost.Name = "grpboxVerPost";
            grpboxVerPost.Size = new Size(693, 205);
            grpboxVerPost.TabIndex = 6;
            grpboxVerPost.TabStop = false;
            grpboxVerPost.Text = "Ver Post";
            grpboxVerPost.Visible = false;
            // 
            // btnNaoGosto
            // 
            btnNaoGosto.Location = new Point(162, 173);
            btnNaoGosto.Name = "btnNaoGosto";
            btnNaoGosto.Size = new Size(75, 23);
            btnNaoGosto.TabIndex = 10;
            btnNaoGosto.Text = "Não Gosto";
            btnNaoGosto.UseVisualStyleBackColor = true;
            btnNaoGosto.Click += btnNaoGosto_Click;
            // 
            // lblGostos
            // 
            lblGostos.AutoSize = true;
            lblGostos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGostos.Location = new Point(267, 179);
            lblGostos.Name = "lblGostos";
            lblGostos.Size = new Size(15, 17);
            lblGostos.TabIndex = 9;
            lblGostos.Text = "0";
            // 
            // btnGosto
            // 
            btnGosto.Location = new Point(71, 173);
            btnGosto.Name = "btnGosto";
            btnGosto.Size = new Size(75, 23);
            btnGosto.TabIndex = 8;
            btnGosto.Text = "Gosto";
            btnGosto.UseVisualStyleBackColor = true;
            btnGosto.Click += btnGosto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 5;
            label1.Text = "Titulo:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(100, 62);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(484, 88);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 62);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 6;
            label2.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(280, 24);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 11;
            label3.Text = "Data:";
            // 
            // frmPost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpboxVerPost);
            Controls.Add(btnCriar);
            Controls.Add(grpboxCriarPost);
            Name = "frmPost";
            Text = "Post";
            Load += frmPost_Load;
            grpboxCriarPost.ResumeLayout(false);
            grpboxCriarPost.PerformLayout();
            grpboxVerPost.ResumeLayout(false);
            grpboxVerPost.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbTitulo;
        private Label lblTitulo;
        private Label lblDescricao;
        private RichTextBox rtbDescricao;
        private GroupBox grpboxCriarPost;
        private Button btnCriar;
        private GroupBox grpboxVerPost;
        private Label label1;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Label label2;
        private Label lblGostos;
        private Button btnGosto;
        private Label lblData;
        private Label lblMensagem;
        private Button btnNaoGosto;
        private Label label3;
    }
}
