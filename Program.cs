// TDE Aula 02

int idade = 35;
string nome = "Maria";
float altura = 3.45f;
const int ano = 12;
Nullable<double> nota = 7.80d;

Console.WriteLine(idade);
Console.WriteLine(nome);
Console.WriteLine(ano);
Console.WriteLine(nota);


/*Quais as diferenças entre os tipos por valor e os tipos por referência ?
    Os tipos por valores tem seu valor direto, e os tipos por referencia tem atraves de dados.
        EX:
        string disciplina = "LP";
        disciplina = "Laboratório de Programação";
    */

/*O que é um nullable type e qual a sua utilidade ?
    Ele consegue mostrar um resultado de Null, invés de não aceitar o script e dar erro.
    */

/*O que é Camel Case ? Dê um exemplo de sua aplicação
    É uma forma de deixar mais legível o código, é usada para nomear variáveis que tenham duas ou mais palavras.
        EX:
        int notaMaxima = 10;
    */

/*O que é Pascal Case ? Dê um exemplo de sua aplicação
    Bem parecido com o Camel Case porém ele inicia com letras MAIUSCULAS, usada em classes.
        EX:
        public class NotasDosAlunos{}
    */


int x =77;
int y =66;
Console.WriteLine(x+y);

/*Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e
string.
    bool = valores de false e true;
    char = maneira de armazenar inteiros, ele representa um unico caractere;
    int = numeros inteiros;
    double = numero não inteiro usado para numeros decimais grandes;
    float = numero não inteiro usado para pequenos numeros decimais;
    decimal = numero não inteiro usado para numeros enormes, usado para resultados extremamente precisos;
    string = usado para paravras, frases e textos;
    */