Int32 idade;
String resultado;

Console.WriteLine("Informe a idade: ");
idade = Convert.ToInt32(Console.ReadLine());
resultado = (idade > 17) ? "Pode dirigir." : "Não pode dirigir.";
Console.WriteLine(resultado);

//if (idade > 17)
//{
//    Console.WriteLine("Pode dirigir.");
//}
//else
//{
//    Console.WriteLine("Não pode dirigir.");
//}