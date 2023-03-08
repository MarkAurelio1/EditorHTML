using System;

namespace EditorHtml
{
  public static class Menu
  {


    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Blue;
      Console.ForegroundColor = ConsoleColor.Black;

      DesenhoDeTela();
      EscrevaAsOpcoes();

      var opcoes = short.Parse(Console.ReadLine());
      HandleMenuOption(opcoes);
    }

    public static void DesenhoDeTela()
    {
      Console.Write("+");
      for (int i = 0; i <= 30; i++)
        Console.Write("-");

      Console.Write("+");
      Console.Write("\n");

      for (int linhas = 0; linhas <= 10; linhas++)
      {
        Console.Write("|");
        for (int i = 0; i <= 30; i++)
          Console.Write(" ");

        Console.Write("|");
        Console.Write("\n");
      }
      Console.Write("+");
      for (int i = 0; i <= 30; i++)
        Console.Write("-");

      Console.Write("+");
      Console.Write("\n");

    }


    public static void EscrevaAsOpcoes()
    {
      Console.SetCursorPosition(3, 2);
      Console.WriteLine("Editor HTML");
      Console.WriteLine("==============");
      Console.SetCursorPosition(3, 4);
      Console.WriteLine("Selecione uma opção abaixo");
      Console.SetCursorPosition(3, 6);
      Console.WriteLine("1 - Novo arquivo");
      Console.SetCursorPosition(3, 7);
      Console.WriteLine("2 - Abrir");
      Console.SetCursorPosition(3, 9);
      Console.WriteLine("0 - Sair");
      Console.SetCursorPosition(3, 10);
      Console.WriteLine("Opção: ");
      Console.SetCursorPosition(10, 10);

    }

    public static void HandleMenuOption(short opcoes)
    {
      switch (opcoes)
      {
        case 1: Editor.Show(); break;
        case 2: Console.WriteLine("Visualizador"); break;
        case 0:
          {
            Console.Clear();
            Environment.Exit(0);
            break;
          }
        default: Show(); break;
      }

    }
  }


}