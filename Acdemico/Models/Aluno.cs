using System.ComponentModel;

namespace Acdemico.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}
