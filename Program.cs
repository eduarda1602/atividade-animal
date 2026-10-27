// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    // classe pai para inicializar as propriedades  
    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }


    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico de animal");
    }


}


class Cachorro : Animal
{
        public Cachorro(string nome, int idade) : base(nome, idade)
        {}


    public override void EmitirSom()
    {
        Console.WriteLine($"Animal: Thor {Nome}");
        Console.WriteLine($"Idade: 2 {Idade} anos");
        Console.WriteLine("O cachorro está latindo: au au!");
    }
}
class Gato : Animal
{
    public Gato(string nome, int idade) : base(nome, idade)
    { }


    public override void EmitirSom()
    {
        Console.WriteLine($"Animal: Bolinha {Nome}");
        Console.WriteLine($"Idade: 3 meses {Idade}");
        Console.WriteLine("O gato está miando: meow!");
    }
}
class Program
{
    static void Main(string[] args)


    {
        Console.WriteLine("SISTEMAS DE ANIMAIS");
        //CRIANDO CARACTERISTICAS-- tocolocando comentario pra nao esquecer


        List<Animal> animais = new List<Animal>();
        animais.Add(new Cachorro("Thor", 2));
        animais.Add(new Gato("Bolinha", 3));


        foreach (var animal in animais)
        {
            animal.EmitirSom();
        }

// Professor gostoso


    }
}







