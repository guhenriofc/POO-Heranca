namespace POO_Heranca.Classes.cs
{
    public class PessoaFisica : Pessoa
    {
        public string cpf;
        public string rg;
        public bool ValidarCPF(string documento){
            if(documento!= ""){
                return true;
            }
            
            return false;
        }

    }
}