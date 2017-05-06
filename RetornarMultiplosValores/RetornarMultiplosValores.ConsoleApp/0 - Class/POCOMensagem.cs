namespace EliPedro.RetornarMultiplosValores.POCO
{
    public class POCOMensagem
    {
        public string Mensagem { get; set; }
        public bool Flag { get; set; }

        public POCOMensagem RetornarMensagemPOCO()
        {
            return new POCOMensagem() { Mensagem = "SucessoPoco", Flag = true };
        }
    }
}

//POCO(Plain Old Class Object). Esse tipo de classe tem como objetivo 
//simplesmente guardar dados, ou seja, não possuem nenhum comportamento definido
