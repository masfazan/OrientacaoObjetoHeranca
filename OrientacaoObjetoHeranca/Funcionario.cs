

internal class Funcionario : Pessoa
{
    public int codigo;
    public string cargo;
    public Funcionario()
    {

    }
    public void DefinirCargo(string cargo)
    {
        this.cargo = cargo;
    }
    public void DefinirCodigo(int codigo)
    {
        this.codigo = codigo;
    }

    public void ImprimirFuncionario()
    {
        ImprimirPessoa();
        Console.WriteLine(this.codigo);
        Console.WriteLine(this.cargo);
    }

}





