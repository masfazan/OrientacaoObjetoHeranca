public class Pessoa
{
    public string nome;
    public string endereco;
    public string sexo;
    public string telefone;
    float salario;
    public DateOnly nascimento;

    public Pessoa()
    {

    }

    public void DefinirNome(string nome)
    {
        this.nome = nome;
    }
    public void DefinirEndereco(string e)
    {
        this.endereco = e;
    }
    public void DefinirSexo(string s)
    {
        this.sexo = s;
    }
    public void DefinirTelefone(string t)
    {
        this.telefone = t;
    }
    public void DefinirSalario(float s)
    {
        this.salario = s;
    }
    public void DefinirNasc(DateOnly d)
    {
        this.nascimento = d;
    }
        public void ImprimirPessoa() //função para imprimir os atributos de pessoa
    {
        Console.WriteLine(this.nome);
        Console.WriteLine(this.endereco);
        Console.WriteLine(this.sexo);
        Console.WriteLine(this.telefone);
        Console.WriteLine(this.salario);
        Console.WriteLine(this.nascimento);
    }
}