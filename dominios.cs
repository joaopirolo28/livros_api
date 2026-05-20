using System.Diagnostics.Contracts;

namespace Classes
{
    public class Usuario
    {
        public string Nome;
        public string Email;
        public string Senha;

        public void SetNome(string valor)
        {
            this.Nome = valor;
        }

        public string GetNome(string valor)
        {
            return Nome;
        }

        public void SetEmail(string valor)
        {
            this.Email = valor;
        }

        public string GetEmail(string valor)
        {
            return Email;
        }
        public void SetSenha(string valor)
        {
            this.Senha = valor;
        }

        public string GetSenha(string valor)
        {
            return Senha;
        }
    }
}
























// namespace Classes;

// public class Nome
// {
//     public string nome { get; set; }

//     public bool validar(string valor){
//         return true;
//     }
//     public bool setNome(string valor){
//         this.nome = valor;
//         return true;
//     }
//     public string getNome(){
//         return nome;
//     }
// }