<h1 align="center">:memo: Academia .NET - Exercícios POO Abstração e Herança</h1>

<p align="center">
  <a href="https://learn.microsoft.com/pt-br/dotnet/"><img alt="DotNet 6" src="https://img.shields.io/badge/.NET-5C2D91?logo=.net&logoColor=white&style=for-the-badge" /></a>
  <a href="https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/"><img alt="C#" src="https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white&style=for-the-badge" /></a>
</p>

## :computer: Projeto

Repositório com exercícios sobre programação orientada a objetos em C# utilizando Abstração e Herança, os exercícios foram propostos durante a Academia DotNet ministrada pela `Universidade Franciscana - UFN`.

## :page_facing_up: Lista dos Exercícios

1 - Criar uma classe Pessoa que contém as propriedades Nome e Idade. Criar duas classes derivadas, Aluno e Professor, que herdam de Pessoa.  
A classe Aluno deve ter uma propriedade adicional Matricula, enquanto a classe Professor deve ter uma propriedade adicional Disciplina.  
Criar um método abstrato Apresentar na classe Pessoa. 
Em seguida, criar um método Apresentar na classe Aluno que imprime o nome, a idade e a matrícula do aluno, e um método Apresentar na classe Professor que imprime o nome, a idade e a disciplina do professor.


2 - Criar uma classe Veiculo que contém as propriedades Marca e Modelo. Criar um método abstrato chamado Dirigir. Criar duas classes derivadas, Carro e Moto, que herdam de Veiculo. 
A classe Carro deve ter uma propriedade adicional QuantidadeDePortas, enquanto a classe Moto deve ter uma propriedade adicional Cilindrada. 
Criar um método abstrato Dirigir na classe Veiculo. 
Em seguida, criar um método Dirigir na classe Carro que imprime "Dirigindo o <marca> <modelo> com <quantidadeDePortas> portas" e um método Dirigir na classe Moto que imprime "Dirigindo a <marca> <modelo> com <cilindrada> cilindradas"

3 - Crie uma interface chamada "IFormaGeometrica" com dois métodos abstratos: "CalcularArea()" e "CalcularPerimetro()". 
Em seguida, crie duas classes que implementam essa interface: "Retangulo" e "Circulo". 
Implemente os métodos "CalcularArea()" e "CalcularPerimetro()" para cada uma dessas classes, de forma que o "Retangulo" calcule a área e o perímetro de um retângulo e o "Circulo" calcule a área e o perímetro de um círculo. 

4 - Crie uma classe abstrata "ContaBancaria" com propriedades para "Saldo" e métodos abstratos "Depositar" e "Sacar". Crie classes derivadas, como "ContaCorrente" e "ContaPoupanca", que implementam os métodos de depósito e saque de acordo com as regras de cada tipo de conta.

5 - Crie uma classe abstrata "Produto" com propriedades para "Nome", "Preço" e um método abstrato "CalcularDesconto". Crie classes derivadas para diferentes tipos de produtos, como "Livro" e "Eletrônico", que implementam o método "CalcularDesconto" de acordo com as regras específicas de desconto para cada tipo de produto.
- Livro – 5% de desconto
- Eletrônico  - 12.5% de desconto

6 - Crie uma classe "ContaBancaria" com propriedades para "Saldo" e métodos "Depositar" e "Sacar". 
    
Crie classes derivadas, como "ContaCorrente" e "ContaPoupanca", que implementam os métodos de depósito e saque de acordo com as regras de cada tipo de conta.
Regras: 
- i) Para sacar na conta poupança, cada saque tem um custo de 0,10 
- ii) para depositar na conta poupança, não existe custo
- iii) Para sacar na conta corrente somente o primeiro saque é gratuito e o restante tem tem um custo de 0,05 centavos 
- iv) Para depositar na conta corrente não existe custo porém deve apresentar a mensgem na tela do valor do saldo.

7 -
 - a) Crie uma classe base chamada "Veiculo" com propriedades como "Marca" e "Ano."
 - b) Crie classes derivadas como "Carro" e "Moto" que herdem de "Veiculo" e adicionem propriedades específicas, como "Número de Portas" para carros e "Cilindrada" para motos.
 - c) Crie uma lista de Veículos que inclui instâncias de "Veiculo", "Carro" e "Moto." Use um loop para percorrer a lista e chamar um método "Apresentar" que exibe informações sobre cada veículo, demonstrando o polimorfismo.
 - d) Modifique a classe "Veiculo" para ter um método virtual "Apresentar" que exiba informações gerais do veículo.
 - e) Sobrescreva o método "Apresentar" nas classes derivadas para incluir informações específicas, como o número de portas para carros ou a cilindrada para motos.

8 - Crie uma classe chamada "Calculadora" com métodos para somar, subtrair, multiplicar e dividir números. Implemente sobrecargas desses métodos para aceitar diferentes números de argumentos e tipos, como inteiros e decimais.

9 -
- a) Crie uma classe base "Pessoa" com propriedades como "Nome" e "Idade." 
- b) Crie uma classe derivada "Estudante" que herde de "Pessoa" e adicione propriedades específicas, como "Matricula" e "Curso."
- c) Certifique-se de que a classe derivada chame o construtor da classe base

10 - 
- a) Crie uma classe base "Funcionario" com propriedades como "Nome" e "Salario."
- b) Crie classes derivadas, como "Gerente" e "Desenvolvedor," que herdem de "Funcionario" e forneçam implementações específicas para calcular bônus ou mostrar funções.

11 - 
- a) Crie uma classe "Produto" com propriedades como "Nome," "Preço" e "Estoque."
- b) Implemente construtores sobrecarregados que permitam criar instâncias de produtos de diferentes maneiras, como especificando apenas o nome ou especificando todas as propriedades.

## :memo: Respostas dos Exercícios

- [Exercicio 1](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-abstracao-heranca/tree/master/Exercicios/Academia.Dotnet.POO.AH.Exercicio01)
- [Exercicio 2](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-abstracao-heranca/tree/master/Exercicios/Academia.Dotnet.POO.AH.Exercicio02)
- [Exercicio 3](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-abstracao-heranca/tree/master/Exercicios/Academia.Dotnet.POO.AH.Exercicio03)
- [Exercicio 4](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-abstracao-heranca/tree/master/Exercicios/Academia.Dotnet.POO.AH.Exercicio04)
- [Exercicio 5](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-abstracao-heranca/tree/master/Exercicios/Academia.Dotnet.POO.AH.Exercicio05)
- [Exercicio 6](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-abstracao-heranca/tree/master/Exercicios/Academia.Dotnet.POO.AH.Exercicio06)
- [Exercicio 7](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-abstracao-heranca/tree/master/Exercicios/Academia.Dotnet.POO.AH.Exercicio07)
- [Exercicio 8](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-abstracao-heranca/tree/master/Exercicios/Academia.Dotnet.POO.AH.Exercicio08)
- [Exercicio 9](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-abstracao-heranca/tree/master/Exercicios/Academia.Dotnet.POO.AH.Exercicio09)
- [Exercicio 10](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-abstracao-heranca/tree/master/Exercicios/Academia.Dotnet.POO.AH.Exercicio10)
- [Exercicio 11](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-abstracao-heranca/tree/master/Exercicios/Academia.Dotnet.POO.AH.Exercicio11)

## :white_check_mark: Decisões Técnicas

Procurei responder os exercícios mantendo as declarações de variáveis, construtores e sobrescrita de métodos de acordo com o que foram apresentados durantes as aula.   
  
## ✔️ Recursos Utilizados

- ``.NET 6.0``
- ``Console Application``
- ``C#``

## :floppy_disk: Clonar Repositório

```bash
git clone https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-abstracao-heranca.git
```

## :boy: Author

<a href="https://github.com/PauloAlves8039"><img src="https://avatars.githubusercontent.com/u/57012714?v=4" width=70></a>
[Paulo Alves](https://github.com/PauloAlves8039)
