// tipos de dados

string nome = "Juliana ";
Console.WriteLine("o nome do usuario é: " + nome);

int idade = 38;
//console.writeline( "a idade do usuario é:" + idade+
Console.WriteLine($"a idade do usuario é: {idade} anos");

float carteira = 2.63f;

char classificacao = 'A';
Console.WriteLine($"o cliente é do tipo {classificacao}");

bool dinheironaconta = true;
Console.WriteLine(dinheironaconta);

double limitecredito = 2000.0;
Console.WriteLine("seu limite de credito é: " + limitecredito);


string sobrenome = "silva";

string nomecompleto = nome + sobrenome;
Console.WriteLine(nomecompleto);

double valorconta = 53.73;
Console.WriteLine($"o valor na conta é: {valorconta}");

double limitetotal = valorconta + limitecredito;
Console.WriteLine($"o saldo + limite é {limitetotal}");




