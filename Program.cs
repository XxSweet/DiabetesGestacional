﻿int glicemia;
string diagnostico;
ConsoleColor corExibicao;

Console.WriteLine("--- Diabetes Gestacional ---\n");

Console.Write("Glucemia (em mg/dL)...: ");
Console.ForegroundColor = ConsoleColor.Green;
glicemia = Convert.ToInt32(Console.ReadLine());

if (glicemia > 126)
{
    diagnostico = "Diabetes Mellitus en el embarazo";
    corExibicao = ConsoleColor.Red;
}
else
{
    if (glicemia >= 92)
    {
        diagnostico = "Compatível con Diabetes en el embarazo";
        corExibicao = ConsoleColor.Yellow;
    }
    else
    {
        diagnostico = "reevaluar entre 24 e 28 semanas con TTOG 75g de glucosa";
        corExibicao = ConsoleColor.Red;
    }
}

Console.ForegroundColor = corExibicao;

Console.WriteLine();
Console.WriteLine(diagnostico);

Console.ResetColor();