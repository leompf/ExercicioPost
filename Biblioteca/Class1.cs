using System.Runtime.CompilerServices;

namespace Biblioteca;

public class Post
{
    private string _titulo;

    private string _descricao;

    private DateTime _data;

    private int _gostos;

    private bool _estado;

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
        set
        {
            _gostos = value;
        }
    }
    public DateTime Data
    {
        get { return _data; }
    }

    public bool Estado
    {
        get { return _estado; }
    }

    public void DataPost()
    {
        _data = DateTime.Now;
    }

    public bool CriarPost()
    {
        _estado = false;

        if (Titulo != null && Descricao != null)
        {
            _estado =  true;
        }

        return _estado;
    }
}
