using EliPedro.RetornarMultiplosValores.OUT;
using EliPedro.RetornarMultiplosValores.POCO;
using EliPedro.RetornarMultiplosValores.TUPLE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetornarMultiplosValores.ConsoleApp
{
    class Teste
    {
        static void Main(string[] args)
        {
            
            OutMensagem outmsg = new OutMensagem();

            bool outFlag;
            string mensagem = outmsg.RetornarMensagemOut(out outFlag);

            Console.WriteLine(new string('-', 30));

            Console.WriteLine(mensagem);
            Console.WriteLine(outFlag);


            POCOMensagem poco = new POCOMensagem();

            Console.WriteLine(new string('-', 30));

            Console.WriteLine(poco.RetornarMensagemPOCO().Mensagem);
            Console.WriteLine(poco.RetornarMensagemPOCO().Flag);

            Console.WriteLine(new string('-', 30));

            TupleMensagem tuple = new TupleMensagem();

            Console.WriteLine(tuple.RetornarMensagemTupl().Item1);
            Console.WriteLine(tuple.RetornarMensagemTupl().Item2);
            Console.WriteLine(tuple.RetornarMensagemTupl().Item3);

            Console.ReadKey();
        }
    }
}
