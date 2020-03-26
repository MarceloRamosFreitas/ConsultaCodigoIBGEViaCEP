public class ConsultaCep
{
    public string ConsultaCodigoIBGE(int CEP) 
    {
      CEPLibrary.Model.ViaCEPModel objectResult = CEPLibrary.Search.ByZipCode(CEP);
      return objectResult.IBGE;
    } 
}