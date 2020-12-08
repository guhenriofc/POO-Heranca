using System;
using POO_Heranca.Classes.cs;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.cpf = "000.000.000-00";
            pf.nome = "Gustavo";
            Console.WriteLine(pf.DarBoasVindas(pf.nome));
            
        }
    }
}
