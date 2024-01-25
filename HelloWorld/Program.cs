using System; //usa a biblioteca System
namespace HelloWorld;

public class Project {

    public static void Main() {

        Console.WriteLine("Hello, World!");

        // variáveis

        int a = 2;
        System.Int32 b = 4; // usado em versões anteriores
        Console.WriteLine(a);
        Console.WriteLine(b);

        short c = 7; // inteiro de 16bits
        long l = 10L; // inteiro de 64bits
        Console.WriteLine(c);
        Console.WriteLine(l);

        string name = "teste";
        Console.WriteLine(name);

        float f = 10.5f;
        double d = 50.75d;
        int i = 10;
        Console.WriteLine(f);
        Console.WriteLine(d);
        Console.WriteLine(i);

        double um = 1;
        Console.WriteLine(um/2); 

        // casting
        long inteiroLongo = 3L;
        int longo = (int)inteiroLongo; // assumo os riscos de transformar longo em inteiro
        Console.WriteLine(inteiroLongo);
        Console.WriteLine(longo);

        Console.WriteLine(double.MaxValue);
        Console.WriteLine(double.MinValue);

        Console.Write("Digite uma entrada: ");
        var leitura = Console.ReadLine();

        Console.WriteLine(leitura);

        Console.Write("Digite o primeiro número: ");
        var primeiroNumero = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        var segundoNumero = int.Parse(Console.ReadLine());

        Console.WriteLine(primeiroNumero + segundoNumero);

    }

}