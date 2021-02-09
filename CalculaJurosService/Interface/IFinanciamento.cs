namespace CalculaJurosService.Interface
{
    public interface IFinanciamento
    {
        double ValorInicial { get; set; }
        double Juros { get; set; }
        int Periodo { get; set; }


    }
}
