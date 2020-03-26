# ConsultaCodigoIBGEViaCEP

- Framework do Projeto: Visual Studio .Net

- Funcionalidade: Consulta de Código do IBGE via API dos Correios => https://viacep.com.br/ws/01001000/json/

- Área de Conhecimento: Automatização de Teste via BDD + MS TESTS + SPECFLOW.

- Contém 1 Funcionalidade e 2 Cenários, onde:

Funcionalidade: Consulta CEP
	
Cenário: Consulta de CEP Existente

  Dado que estou consumindo o método ConsultaCep
  E preencho o campo 'CEP' com o valor 11060450
	Quando executo a aplicação
	Entao vejo 3548500
  
Obs: No cenário acima o CEP 11060450 que foi informado ao método irá retornar o Código do IBGE 3548500 (SANTOS) pelo webservice dos
     Correios e será este valor que o método irá retornar a fim de poder gerar uma comparação assertiva no método 'ASSERT' (PASSED).

Cenário: Consulta de CEP Inexistente
	
  Dado que estou consumindo o método ConsultaCep
	E preencho o campo 'CEP' com o valor 99999999
	Quando executo a aplicação
	Entao vejo -1
  
  Obs: No cenário acima o CEP 99999999 (INEXISTENTE) que foi informado ao método irá retornar NULL pelo webservice dos Correios e
       quando isto ocorrer foi feito um tratamento no retorno do método para ele retornar o valor "-1" a fim de poder gerar uma 
       comparação assertiva no método 'ASSERT' (PASSED).
       
  Atenção: Caso desejar que o resultado do teste seja 'FAILED' alterar para o CEP 18010003 (SOROCABA). Deste modo o webservices dos
           Correios irá retornar ao método o Código do IBGE 3552205 que quando comparado com o valor esperado "-1" irá gerar
           uma comparação não assertiva no médoto 'ASSERT' (FAILED).
