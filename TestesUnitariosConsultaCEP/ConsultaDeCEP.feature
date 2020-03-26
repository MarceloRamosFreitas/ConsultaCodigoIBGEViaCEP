#language: pt-br

Funcionalidade: Consulta CEP
	
Cenário: Consulta de CEP Existente
	Dado que estou consumindo o método ConsultaCep
	E preencho o campo 'CEP' com o valor 11060450
	Quando executo a aplicação
	Entao vejo 3548500

Cenário: Consulta de CEP Inexistente
	Dado que estou consumindo o método ConsultaCep
	E preencho o campo 'CEP' com o valor 999999999
	Quando executo a aplicação
	Entao vejo -1
	
