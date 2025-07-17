using System.Runtime.CompilerServices;

namespace Biblioteca;

public class Post
{
    private string _titulo;

    private string _descricao;

    private DateTime _data;

    private int _gostos;

    private int _ngostos;


    public string Titulo
    {
        get { return _titulo; }
        set 
        {
            if (value != "")
            _titulo = value; 
        }
    }

    public string Descricao
    {
        get { return _descricao; }
        set
        {
            if (value != "")
                _descricao = value;
        }
    }

    public int Gostos
    {
        get { return _gostos; }
        set { _gostos = value; }
    }

    public int NaoGostos
    {
        get { return _ngostos; }
        set { _ngostos = value; }
    }

    public DateTime Data
    {
        get { return _data; }
    }

    public Post(string titulo, string descricao)
    {
        _titulo = titulo;
        _descricao = descricao;
    }

    public void DataPost()
    {
        _data = DateTime.Now;
    }
}
