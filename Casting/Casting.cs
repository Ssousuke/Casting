class Casting
{
    static void Main(string[] args)
    {
        double a;
        float b;
        int c;

        a = 5.1;

        // Conversão explicíta pra float
        b = (float)a;

        // Conversão explicíta para int
        c = (int)b;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

        int num1 = 5;
        int num2 = 2;


        // Mesmo que a váriavel resultadoSemCasting seja um double ela está recebendo
        // a divisão de duas váriaveis que são inteiras, ou seja o valor retornado vai ser 2 e não 2,5

        double resultadoSemCasting = num1 / num2;
        Console.WriteLine(resultadoSemCasting);


        // Deve ser feito a conversão do tipo recebido
        double resultadoComCasting = (double)num1 / num2;

        Console.WriteLine(resultadoComCasting);
    }
}