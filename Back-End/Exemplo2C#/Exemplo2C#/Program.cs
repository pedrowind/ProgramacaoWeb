double area, baseMenor, baseMaior, h;

Console.WriteLine("Insira o valor da base maior: ");
baseMaior = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira o valor da base menor: ");
baseMenor = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira o valor da altura: ");
h = Convert.ToDouble(Console.ReadLine());

area = (baseMaior + baseMenor) * h / 2;

Console.WriteLine($"A área do trapézio é: {area}");