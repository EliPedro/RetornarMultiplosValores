using System;

namespace EliPedro.RetornarMultiplosValores.TUPLE
{
    public class TupleMensagem
    {

       public Tuple<string, int, double> RetornarMensagemTupl()
        {
            return new Tuple<string, int, double>("SucessoTuple", 10, 1.2f);        }
    }
}
