using System;

class Heroi
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Tipo { get; set; }

    public Heroi(string nome, int idade, string tipo)
    {
        Nome = nome;
        Idade = idade;
        Tipo = tipo;
    }

    public void Atacar()
    {
        string ataque;

        switch (Tipo.ToLower())
        {
            case "mago":
                ataque = "magia";
                break;
            case "guerreiro":
                ataque = "espada";
                break;
            case "monge":
                ataque = "artes marciais";
                break;
            case "ninja":
                ataque = "shuriken";
                break;
            default:
                ataque = "um ataque desconhecido";
                break;
        }

        Console.WriteLine($"O {Tipo} atacou usando {ataque}.");
    }
}

class Program
{
    static void Main()
    {
        Heroi heroi1 = new Heroi("Arthur", 30, "guerreiro");
        Heroi heroi2 = new Heroi("Merlin", 150, "mago");
        Heroi heroi3 = new Heroi("Shinobi", 25, "ninja");

        heroi1.Atacar();
        heroi2.Atacar();
        heroi3.Atacar();
    }
}




