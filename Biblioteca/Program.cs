
Biblioteca.Biblioteca biblioteca = new Biblioteca.Biblioteca();
int selectedOption = 0;

while (true)
{
    Console.Clear();

    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("---------- Bem vindo à biblioteca ----------");
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Gray;

    Console.WriteLine("     Cadastrar Novo Livro");
    Console.WriteLine("     Marcar Livro como perdido");
    Console.WriteLine("     Marcar Livro como destruido");
    Console.WriteLine("     Atualizar dados do livro");
    Console.WriteLine("     Novo Usuário");
    Console.WriteLine("     Altualizar Cadastro do Usuário");
    Console.WriteLine("     Banir Usuário");
    Console.WriteLine("     Emprestar Livro");
    Console.WriteLine("     Devolver Livro");
    Console.WriteLine("     Sair");

    Console.SetCursorPosition(0, 1 + selectedOption);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(">");
    Console.SetCursorPosition(43, 1 + selectedOption);
    Console.Write("<");
    Console.ForegroundColor = ConsoleColor.White;

    var input = Console.ReadKey();
    if (input.Key == ConsoleKey.DownArrow || input.Key == ConsoleKey.RightArrow)
    {
        selectedOption++;
        if (selectedOption > 9) selectedOption = 0;
    }
    else if (input.Key == ConsoleKey.UpArrow || input.Key == ConsoleKey.LeftArrow)
    {
        selectedOption--;
        if (selectedOption < 0) selectedOption = 9;
    }
    else if (input.Key == ConsoleKey.Enter)
    {
        if (selectedOption == 9) { return; }
        //Todo chamar a respectiva função
        selectedOption = 0;
    }
}