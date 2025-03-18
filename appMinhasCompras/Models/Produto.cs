using SQLite;

namespace appMinhasCompras.Models
{
    public class Produto
    {
        string _descricao;
        double _quantidade;
        double _preco;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao {
            get => _descricao; set
            {
                if (value == null)
                {
                    throw new Exception("Por favor, preencha a descrição!");
                }

                _descricao = value;
            }
        }
        public double Quantidade { get => _quantidade; set
            {
                if (value == 0)
                {
                    throw new Exception("Por favor, preencha uma quantidade!");
                }

                _quantidade = value;
            } 
        }
        public double Preco { get => _preco; set
            {
                if (value == 0)
                {
                    throw new Exception("Por favor, preencha um preço!");
                }

                _preco = value;
            }
        }

        public double Total { get => Quantidade * Preco; }
    }
}

