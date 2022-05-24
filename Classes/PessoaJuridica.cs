using er3.Interfaces;

namespace er3.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        // Atributos
        public string ?cnpj {get; set;}

        public string ?razaoSocial {get; set;}

        // Metodos
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool validarCnpj(string cnpj)
        {
            throw new NotFiniteNumberException();
        }
    }
}