namespace DesafioProjetoHospedagem.Models
{
    public class Pessoa
    {
        // Construtor padrão
        public Pessoa() { }

        // Construtor que aceita apenas o nome
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        // Construtor que aceita nome e sobrenome
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // Propriedades para Nome e Sobrenome
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        // Propriedade que retorna o nome completo em maiúsculas
        public string NomeCompleto
        {
            get
            {
                // Se o sobrenome for nulo ou vazio, retorna apenas o nome
                if (string.IsNullOrWhiteSpace(Sobrenome))
                {
                    return Nome.ToUpper();
                }
                // Retorna o nome completo (nome + sobrenome) em maiúsculas
                return $"{Nome} {Sobrenome}".ToUpper();
            }
        }
    }
}
