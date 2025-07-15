using Biblioteca;
using System.ComponentModel.Design;

namespace ExercicioPost.Forms;

public partial class frmPost : Form
{
    private Post _post;

    public frmPost()
    {
        InitializeComponent();
        _post = new Post();

        if (_post != null)
        {
            grpboxCriarPost.Enabled = true;
        }
    }

    private void frmPost_Load(object sender, EventArgs e)
    {

    }

    private void btnCriar_Click(object sender, EventArgs e)
    {
        _post.Titulo = tbTitulo.Text;
        _post.Descricao = rtbDescricao.Text;

        _post.CriarPost();

        if (_post.Estado == true)
        {
            _post.DataPost();
            lblData.Text = _post.Data.ToString("dd/MM/yyyy, HH:mm");
            grpboxVerPost.Visible = true;
            lblMensagem.Visible = false;

            ApresentarPost();
        }
        else
        {
            lblMensagem.Text = "Por favor preencha todos os campos!";
            lblMensagem.Visible = true;
        }

    }

    private void btnGosto_Click(object sender, EventArgs e)
    {
        _post.Gostos++;
        lblGostos.Text = _post.Gostos.ToString();
    }

    private void btnNaoGosto_Click(object sender, EventArgs e)
    {
        _post.Gostos--;
        lblGostos.Text = _post.Gostos.ToString();
    }

    private void ApresentarPost()
    {
        textBox1.Text = _post.Titulo;
        richTextBox1.Text = _post.Descricao;
        label3.Text = _post.Data.ToString("dd/MM/yyyy, HH:mm");
    }
}
