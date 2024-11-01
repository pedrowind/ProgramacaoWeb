int idade;

Console.WriteLine("Insira a sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

if (idade == 16)
{
    Console.WriteLine("Pode votar");
}
else if (idade > 17 && idade < 60)
{
    Console.WriteLine("Deve votar");
}
else
{
    Console.WriteLine("Não pode votar");
}