using Biblioteca;

namespace ExercicioPost.Forms;

public partial class FrmNovoPost : Form
{
    public FrmPost FormPrincipal { get; set; }

    public FrmNovoPost(FrmPost form)
    {
        InitializeComponent();
        FormPrincipal = form;
    }

    private void frmNovoPost_Load(object sender, EventArgs e)
    {

    }

    private void CriarPost()
    {
        FormPrincipal.Post = new Post(tbTitulo.Text, rtbDescricao.Text);

        FormPrincipal.Post.Titulo = tbTitulo.Text;
        FormPrincipal.Post.Descricao = rtbDescricao.Text;

        if (tbTitulo.Text != "" && rtbDescricao.Text != "")
        {
            FormPrincipal.Post.DataPost();
            lblData.Text = FormPrincipal.Post.Data.ToString("dd/MM/yyyy, HH:mm");
            lblMensagem.Visible = false;               
        }
        else
        {
            lblMensagem.Text = "Por favor preencha todos os campos!";
            lblMensagem.Visible = true;
        }
    }

    private void btnCriar_Click(object sender, EventArgs e)
    {
        CriarPost();
        FormPrincipal.ApresentarPost();

        this.Close();
    }
}
