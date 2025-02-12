# LogicaCsharp3

RESOLUÇÃO DOS EXERCICIOS DO CURSO: https://github.com/acenelio/curso-logica-de-programacao-csharp

3. Estruturas Repetitivas - Algumas anotações sobre o curso em lógica de programação em Csharp

- Estrutura repetitiva "enquanto"

É uma estrutura de controle que repete um bloco de comandos enquanto uma condição for verdadeira.
Quando usar: quando não se sabe previamente a quantidade de repetições que será realizada.

EXEMPLO: FAZER UMA AÇÃO ATÉ QUE ALGO OCORRA.

Sintaxe / regra:

While ( condição ) { // VAI EXECUTAR A CONDIÇÃO, SE ELA FOR VERDADEIRA VAI PASSAR PELOS COMANDOS 1 E 2 E VAI VOLTAR PARA O INICIO E REPETIR.
		comando 1
		comando 2
	}
	
- Estrutura repetitiva "faça enquanto"

Menos utilizada, mas em alguns casos se encaixa melhor ao problema. O Bloco de comandos executa pelo menos uma vez, pois a condição é verificada no final.

Sintaxe / regra

do {
	comando 1
	comando 2
} while ( condição );

Regra: se a condição for verdadeira volta, se for falsa pula fora
