// Programação Orientada a Objetos

// 4 Pilares da POO

// Classe e Objeto
// Classe - Definicao (Molde)
// Objeto - Instancia da Classe

// Ferramentas - Formas de Trabalhar com POO

// Encapsulamento e Herança

// Abstração e Polimorfismo - Amanhã


// Encapsulamento - Esconder comportamentos e atributos
// Evitar que sejam acessados diretamente
// Conta Bancaria (saldo)
// Sacar() - Depositar() podem acessar o saldo

// conta.saldo = 300000;
// Vantagens -
// 1 - Esconder atributo/metodo/classe
// 2 - Defino regras para alteracao ou listagem

// public - Esse atributo/metodo/classe pode ser acessado por qualquer um

// private - Esse atributo/metodo/classe só pode ser acesso dentro dele mesmo

// protected/internal - Esse atributo/metodo/classe só pode ser acessado por ele mesmo e por sua classe pai

using POO;

Carro carro1 = new Carro();

// Get - Método para pegar um atributo privado
// Set - Método para alterar um atributo privado

carro1.SetModelo("HB20");

Console.WriteLine(carro1.GetModelo());











//### **1 - Criando uma Classe "Livro" e Instanciando um Objeto**

//Crie uma classe chamada `Livro` com os seguintes atributos:

//- `titulo` (tipo `string`)
//- `autor` (tipo `string`)
//- `paginas` (tipo `int`)

//Depois, instancie um objeto da classe `Livro`, atribua valores aos atributos e exiba as informações no console.

using POO;

Livro livro1 = new Livro();

livro1.autor = "Robert Martin";
livro1.titulo = "Clean Code";
livro1.paginas = 353;

Livro livro2 = new Livro()
{
    autor = "Robert Martin",
    titulo = "Clean Code",
    paginas = 353
};

Console.WriteLine(livro1.autor);
Console.WriteLine(livro1.titulo);
Console.WriteLine(livro1.paginas);

Aluno aluno1 = new Aluno();

aluno1.notaFinal = 9.5;
aluno1.idade = 16;
aluno1.nome = "Vini";

Console.WriteLine(aluno1.notaFinal);
Console.WriteLine(aluno1.idade);
Console.WriteLine(aluno1.nome);

Produto p1 = new Produto();

p1.nome = "Camiseta";
p1.preco = 25.99;
p1.quantidadeEmEstoque = 100;

Console.WriteLine(p1.nome);
Console.WriteLine(p1.preco);
Console.WriteLine(p1.quantidadeEmEstoque);

Console.WriteLine(p1.CalcularTotal());