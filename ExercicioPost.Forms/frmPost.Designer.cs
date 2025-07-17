namespace ExercicioPost.Forms
{
    partial class FrmPost
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
            menuStrip1 = new MenuStrip();
            novoPostToolStripMenuItem = new ToolStripMenuItem();
            grpboxVerPost = new GroupBox();
            lblMensagem = new Label();
            btnGosto = new Button();
            btnNaoGosto = new Button();
            lblNaoGostos = new Label();
            lblData = new Label();
            lblGostos = new Label();
            lblTitulo = new Label();
            rtbDescricao = new RichTextBox();
            tbTitulo = new TextBox();
            lblDescricao = new Label();
            menuStrip1.SuspendLayout();
            grpboxVerPost.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { novoPostToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // novoPostToolStripMenuItem
            // 
            novoPostToolStripMenuItem.Name = "novoPostToolStripMenuItem";
            novoPostToolStripMenuItem.Size = new Size(74, 20);
            novoPostToolStripMenuItem.Text = "Novo Post";
            novoPostToolStripMenuItem.Click += novoPostToolStripMenuItem_Click;
            // 
            // grpboxVerPost
            // 
            grpboxVerPost.Controls.Add(lblMensagem);
            grpboxVerPost.Controls.Add(btnGosto);
            grpboxVerPost.Controls.Add(btnNaoGosto);
            grpboxVerPost.Controls.Add(lblNaoGostos);
            grpboxVerPost.Controls.Add(lblData);
            grpboxVerPost.Controls.Add(lblGostos);
            grpboxVerPost.Controls.Add(lblTitulo);
            grpboxVerPost.Controls.Add(rtbDescricao);
            grpboxVerPost.Controls.Add(tbTitulo);
            grpboxVerPost.Controls.Add(lblDescricao);
            grpboxVerPost.Enabled = false;
            grpboxVerPost.Location = new Point(12, 39);
            grpboxVerPost.Name = "grpboxVerPost";
            grpboxVerPost.Size = new Size(776, 345);
            grpboxVerPost.TabIndex = 8;
            grpboxVerPost.TabStop = false;
            grpboxVerPost.Text = "Ver Post";
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
            // btnGosto
            // 
            btnGosto.Location = new Point(628, 122);
            btnGosto.Name = "btnGosto";
            btnGosto.Size = new Size(89, 58);
            btnGosto.TabIndex = 6;
            btnGosto.Text = "Gosto";
            btnGosto.UseVisualStyleBackColor = true;
            btnGosto.Click += btnGosto_Click;
            // 
            // btnNaoGosto
            // 
            btnNaoGosto.Location = new Point(628, 217);
            btnNaoGosto.Name = "btnNaoGosto";
            btnNaoGosto.Size = new Size(89, 58);
            btnNaoGosto.TabIndex = 9;
            btnNaoGosto.Text = "Não Gosto";
            btnNaoGosto.UseVisualStyleBackColor = true;
            btnNaoGosto.Click += btnNaoGosto_Click;
            // 
            // lblNaoGostos
            // 
            lblNaoGostos.AutoSize = true;
            lblNaoGostos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNaoGostos.Location = new Point(576, 235);
            lblNaoGostos.Name = "lblNaoGostos";
            lblNaoGostos.Size = new Size(18, 20);
            lblNaoGostos.TabIndex = 11;
            lblNaoGostos.Text = "0";
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
            // lblGostos
            // 
            lblGostos.AutoSize = true;
            lblGostos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGostos.Location = new Point(576, 140);
            lblGostos.Name = "lblGostos";
            lblGostos.Size = new Size(18, 20);
            lblGostos.TabIndex = 10;
            lblGostos.Text = "0";
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
            rtbDescricao.Location = new Point(6, 111);
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
            // FrmPost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpboxVerPost);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPost";
            Text = "Post";
            Load += frmPost_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpboxVerPost.ResumeLayout(false);
            grpboxVerPost.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem novoPostToolStripMenuItem;
        private GroupBox grpboxVerPost;
        private Label lblMensagem;
        private Label lblData;
        private Label lblTitulo;
        private RichTextBox rtbDescricao;
        private TextBox tbTitulo;
        private Label lblDescricao;
        private Button btnGosto;
        private Button btnNaoGosto;
        private Label lblGostos;
        private Label lblNaoGostos;
    }
}
