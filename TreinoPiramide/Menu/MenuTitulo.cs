using TreinoPiramide.Calculo;

namespace TreinoPiramide.Menu;

internal class MenuTitulo
{
    // Função (método) responsável para a exibição do Menu Principal;
    public void MenuExibir()
    {
        Console.Clear();
        Console.WriteLine("\n*********************** Triangle Status ***********************");
        Console.WriteLine("**         Informe a base de um triângulo retângulo          **");
        Console.WriteLine("***                                                         ***");
        Console.WriteLine("****               Vamos exibir seu triângulo              ****");
        Console.WriteLine("***************************************************************");
    }

    // Função (método) responsável para a exibição da mensagem pedindo o valor inserido e logo em seguida é captado
    // o valor chamando a função da classe CalculoTriangulo;
    public void InformeBase()
    {
        CalculoTriangulo calculo = new();

        Console.Write("\n\nDigite o valor da sua base: ");
        var valorBase = int.Parse(Console.ReadLine());

        calculo.Base = valorBase;
        calculo.Calculo();
    }
}
