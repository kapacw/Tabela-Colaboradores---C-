using TreinoPiramide.Menu;

namespace TreinoPiramide.Calculo;

internal class CalculoTriangulo
{
    // Inicialização de uma variável inteira _base para armazenar o dado que será inserido;
    private int _base;

    // Propriedade que verifica a integridade do dado e se pode ser passado adiante para execução do Cálculo;
    public int Base
    {
        get
        {
            // Retorna o resultado inserido se for do jeito correto;
            return _base;
        }
        set
        {
            // Verifica com um if se o valor inserido é positivo, se não, aparece uma mensagem e volta ao Menu Principal;
            if (value < 0)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n Digite um valor positvo!!");
                Thread.Sleep(3000);
                MenuTitulo menu = new();
                menu.MenuExibir();
                menu.InformeBase();
            }
            _base = value;
        }
    }

    // Cálculo que faz a exibição do triângulo com asteriscos.
    public void Calculo()
    {
        Console.Clear();

        Console.WriteLine("Seu TRIÂNGULO a seguir:\n");
        
        // Primeiro for faz com que a variavel inicializada seja contada até o número inserido;
        for (int i = 1; i <= _base; i++)
        {
            // Segundo for faz com crie os asteriscos de acordo com o Loop atual, o último Console.WriteLine faz com 
            // que pule linha;
            for(int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // Cw básico exigindo uma escolha e logo em seguida um Switch que executa essa escolha para o usuário;
        Console.WriteLine("\n\nDigite '0' para voltar ao Menu;");
        Console.WriteLine("Digite '1' para sair do Programa;\n");

        switch (int.Parse(Console.ReadLine()))
        {
            case 0:
                MenuTitulo menu = new();
                menu.MenuExibir();
                menu.InformeBase();
                break;

            case 1:
                Console.WriteLine("\nValeu!");
            break;

            default:
                Console.WriteLine("\nOpção Inválida! Digite novamente!");
                Thread.Sleep(3000);
                Calculo();
            break;
        }
    }
}
