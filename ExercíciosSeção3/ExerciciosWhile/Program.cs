using System;
using System.Globalization;

Console.WriteLine("Informe sua senha:");
string senha = Console.ReadLine();
int tentativas = 0;

    while (senha != "2002" && tentativas <= 5)
    {
        tentativas++;
        System.Console.WriteLine("Senha inválida! Tente novamente");
        senha = Console.ReadLine();
    }
    
    if (senha == "2002") {
        System.Console.WriteLine("Acesso permitido");
    } else {
        System.Console.WriteLine("Tentativas Excedidas. Senha bloqueada.");
    }





