using Biblioteca;
using System.ComponentModel.Design;

namespace ExercicioPost.Forms;

public partial class FrmPost : Form
{

    public Post Post { get; set; }

    public FrmPost()
    {
        InitializeComponent();   
    }

    private void frmPost_Load(object sender, EventArgs e)
    {

    }

    private void novoPostToolStripMenuItem_Click(object sender, EventArgs e)
    {
        FrmNovoPost frmNovoPost = new FrmNovoPost(this);
        frmNovoPost.Show();
    }

    private void btnGosto_Click(object sender, EventArgs e)
    {
        Post.Gostos++;
        lblGostos.Text = Post.Gostos.ToString();
    }

    private void btnNaoGosto_Click(object sender, EventArgs e)
    {
        Post.NaoGostos++;
        lblNaoGostos.Text = Post.NaoGostos.ToString();
    }

    public void ApresentarPost()
    {        
        tbTitulo.Text = Post.Titulo;
        rtbDescricao.Text = Post.Descricao;
        lblData.Text = Post.Data.ToString("dd/MM/yyyy, HH:mm");

        grpboxVerPost.Enabled = true;
    }
}
