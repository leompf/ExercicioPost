namespace ExercicioPost.Forms
{
    partial class FrmNovoPost
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
            grpboxCriarPost = new GroupBox();
            btnCriar = new Button();
            lblMensagem = new Label();
            lblData = new Label();
            lblTitulo = new Label();
            rtbDescricao = new RichTextBox();
            tbTitulo = new TextBox();
            lblDescricao = new Label();
            grpboxCriarPost.SuspendLayout();
            SuspendLayout();
            // 
            // grpboxCriarPost
            // 
            grpboxCriarPost.Controls.Add(btnCriar);
            grpboxCriarPost.Controls.Add(lblMensagem);
            grpboxCriarPost.Controls.Add(lblData);
            grpboxCriarPost.Controls.Add(lblTitulo);
            grpboxCriarPost.Controls.Add(rtbDescricao);
            grpboxCriarPost.Controls.Add(tbTitulo);
            grpboxCriarPost.Controls.Add(lblDescricao);
            grpboxCriarPost.Location = new Point(12, 25);
            grpboxCriarPost.Name = "grpboxCriarPost";
            grpboxCriarPost.Size = new Size(676, 345);
            grpboxCriarPost.TabIndex = 5;
            grpboxCriarPost.TabStop = false;
            grpboxCriarPost.Text = "Criar Post";
            // 
            // btnCriar
            // 
            btnCriar.Location = new Point(563, 192);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(92, 38);
            btnCriar.TabIndex = 6;
            btnCriar.Text = "Criar Post";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click;
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
            // rtbDescricao
            // 
            rtbDescricao.Location = new Point(6, 107);
            rtbDescricao.Name = "rtbDescricao";
            rtbDescricao.Size = new Size(541, 202);
            rtbDescricao.TabIndex = 3;
            rtbDescricao.Text = "";
            // 
            // tbTitulo
            // 
            tbTitulo.Location = new Point(71, 22);
            tbTitulo.Name = "tbTitulo";
            tbTitulo.Size = new Size(178, 23);
            tbTitulo.TabIndex = 0;
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
            // FrmNovoPost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpboxCriarPost);
            Name = "FrmNovoPost";
            Text = "frmNovoPost";
            Load += frmNovoPost_Load;
            grpboxCriarPost.ResumeLayout(false);
            grpboxCriarPost.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpboxCriarPost;
        private Label lblMensagem;
        private Label lblData;
        private Label lblTitulo;
        private RichTextBox rtbDescricao;
        private TextBox tbTitulo;
        private Label lblDescricao;
        private Button btnCriar;
    }
}