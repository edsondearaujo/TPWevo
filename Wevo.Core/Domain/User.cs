using System;

namespace Wevo.Core.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
