using System;
using TechTalk.SpecFlow;

namespace TestesUnitariosConsultaCEP
{
    [Binding]
    public class ConsultaDeCEPSteps 
    {
        
        private ConsultaCep consultaCEP;
        private int CEP;
        private string CODIBGE;

        [Given(@"que estou consumindo o método ConsultaCep")]
        public void DadoQueEstouConsumindoOMetodoConsultaCep()
        {
            consultaCEP = new ConsultaCep();
        }

        [Given(@"preencho o campo '(.*)' com o valor (.*)")]
        public void DadoPreenchoOCampoComOValor(string p0, int p1)
        {
            CEP = p1;
        }
           
        [When(@"executo a aplicação")]
        public void QuandoExecutoAAplicacaoConsole()
        {
            try
            {
                int zipCodeIntOk = CEP;
                CODIBGE = consultaCEP.ConsultaCodigoIBGE(zipCodeIntOk);
            }
            catch (Exception ex)
            {
                CODIBGE = "-1";
            }
            finally
            {

            }

        }
            
        [Then(@"vejo (.*)")]
        public void EntaoVejo(int p0)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(p0.ToString(), CODIBGE);
        }
      
    }
}