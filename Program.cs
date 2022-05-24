using er3.Classes;

PessoaFisica metodoPf = new PessoaFisica();
PessoaFisica novoPf = new PessoaFisica();
Endereco novoEnd = new Endereco();

novoPf.nome = "Milton Augusto";
novoPf.dataNascumento = "1981/11/17";
novoPf.cpf="62349139387";
novoPf.rendimento= 200.0f;

novoEnd.logradouro  = "Rua dois";
novoEnd.numero = 924;
novoEnd.complemento = "Prox a Houston Bike";
novoEnd.endComercial = false;

novoPf.endereco = novoEnd;

Console.WriteLine($"Nome: {novoPf.nome}");
Console.WriteLine($"Cpf: {novoPf.cpf}");
Console.WriteLine($"Data de Nascimento: {novoPf.dataNascumento}");
Console.WriteLine($"Rendimento: {novoPf.rendimento}");
Console.WriteLine($"Endereco: {novoPf.endereco.logradouro}, {novoPf.endereco.numero}");

string retorno1 = metodoPf.validarDataNascimento(new String(novoPf.dataNascumento));
Console.WriteLine(retorno1);

Console.WriteLine(" ");

string retorno2 = novoPf.validarDataNascimento(new string("2021,01,01"));

Console.WriteLine(retorno2);

string retorno3 = novoPf.validarDataNascimento(new string("2021//01/01"));

Console.WriteLine(retorno3);