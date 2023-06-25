string NomeUsuario;

Console.WriteLine("Digite o seu nome!");

NomeUsuario = Console.ReadLine()!.ToLower()
//Eu não entendi o porquê de quando colocamos toUpper e colocamos apenas letras maiúsculas no "replace" dá errado...
    .Replace("a", "KA")
    .Replace("b", "ZU")
    .Replace("c", "MI")
    .Replace("d", "TE")
    .Replace("e", "KU")
    .Replace("f", "LU")
    .Replace("g", "JI")
    .Replace("h", "RI")
    .Replace("i", "KI")
    .Replace("j", "ZUS")
    .Replace("k", "ME")
    .Replace("l", "TA")
    .Replace("m", "RIN")
    .Replace("n", "TO")
    .Replace("o", "MO")
    .Replace("p", "NO")
    .Replace("q", "KE")
    .Replace("r", "SHI")
    .Replace("s", "ARI")
    .Replace("t", "CHI")
    .Replace("u", "DO")
    .Replace("v", "RU")
    .Replace("w", "MEI")
    .Replace("x", "NA")
    .Replace("y", "FU")
    .Replace("z", "ZI");
NomeUsuario = $"{NomeUsuario.Substring(0, 1).ToUpper()}{NomeUsuario.Substring(1).ToLower()}";
Console.WriteLine($"Esse é o seu nome de ninja:{NomeUsuario}");