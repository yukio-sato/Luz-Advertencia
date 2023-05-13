string resposta;

bool 
temperatura = false,
pressao = false,
rpm = false;

void frase (string txt)
{
    for (int i = 0; i < txt.Length; i++)
    {
        Console.Write(txt[i]);   
        Thread.Sleep(37);
    }
}
Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
frase("Responda as perguntas a seguir com as palavras: Ativado ou Desativado\n\n");
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("Pressione qualquer tecla para continuar. . .");
Console.ReadKey();

Console.Clear();

Console.ForegroundColor = ConsoleColor.Red;
frase("Sensor de temperatura está: ");
Console.ForegroundColor = ConsoleColor.White;
resposta = Console.ReadLine()!;

if (resposta.Trim().ToUpper().Substring(0,1) == "A")
{
    temperatura = true;
}


Console.ForegroundColor = ConsoleColor.Gray;
frase("Sensor de Pressão está: ");
Console.ForegroundColor = ConsoleColor.White;
resposta = Console.ReadLine()!;

if (resposta.Trim().ToUpper().Substring(0,1) == "A")
{
    pressao = true;
}

Console.ForegroundColor = ConsoleColor.Cyan;
frase("Sensor de RPM está: ");
Console.ForegroundColor = ConsoleColor.White;
resposta = Console.ReadLine()!;

if (resposta.Trim().ToUpper().Substring(0,1) == "A")
{
    rpm = true;
}

if (temperatura == true && (pressao == true || rpm == false))
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    frase($"\nLuz de Advertencia Ligada!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Black;
    frase($"\nLuz de Advertencia Desligada. . .");
}
Console.ResetColor();