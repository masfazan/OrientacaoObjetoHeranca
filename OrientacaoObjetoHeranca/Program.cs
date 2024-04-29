Cliente c1=new Cliente();
Funcionario f1= new Funcionario();
#region c1
Console.WriteLine("Informe o nome do cliente: ");
c1.DefinirNome(Console.ReadLine());

Console.WriteLine("Informe o endereço do cliente: ");
c1.DefinirEndereco(Console.ReadLine());

Console.WriteLine("Informe o sexo do cliente:");
c1.DefinirSexo((Console.ReadLine()));

Console.WriteLine("Informe o telefone do cliente: ");
c1.DefinirTelefone(Console.ReadLine());

Console.WriteLine("Informe o salario do cliente: ");
c1.DefinirSalario(float.Parse(Console.ReadLine()));

Console.WriteLine("Informe a data de nascimento do cliente: ");
c1.DefinirNasc(DateOnly.Parse(Console.ReadLine()));

Console.WriteLine("Informe o número da conta: ");
c1.DefinirConta(int.Parse(Console.ReadLine()));

c1.ImprimirCliente(); //não precisa imprimir pessoa porque o cliente herda pessoa
#endregion
#region f1
Console.WriteLine("Informe o nome do funcionário: ");
f1.DefinirNome(Console.ReadLine());

Console.WriteLine("Informe o endereço do funcionário: ");
f1.DefinirEndereco(Console.ReadLine());

Console.WriteLine("Informe o sexo do funcionário:");
f1.DefinirSexo((Console.ReadLine()));

Console.WriteLine("Informe o telefone do funcionário: ");
f1.DefinirTelefone(Console.ReadLine());

Console.WriteLine("Informe o salario do funcionário: ");
f1.DefinirSalario(float.Parse(Console.ReadLine()));

Console.WriteLine("Informe a data de nascimento do funcionário: ");
f1.DefinirNasc(DateOnly.Parse(Console.ReadLine()));

Console.WriteLine("Informe o código: ");
f1.DefinirCodigo(int.Parse(Console.ReadLine()));

Console.WriteLine("Informe o cargo do funcionário: ");
f1.DefinirCargo(Console.ReadLine());

f1.ImprimirFuncionario();

#endregion
