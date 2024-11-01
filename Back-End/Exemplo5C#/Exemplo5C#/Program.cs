int numero;
int[] pares = new int[10];
int[] impares = new int[10];

try {
    for (int i = 1; i < 10; i++)
    {
        Console.WriteLine("Insira o numero:" + i);
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            pares[i] = numero;
        }
        else
        {
            impares[i] = numero;
        }
    }

    for (int i = 0; i < pares.Length; i++)
    {
        if (pares[i] != 0) {
            Console.WriteLine(pares[i]);
        }

    }

    Console.WriteLine("=======================================");

    for (int i = 0; i < impares.Length; i++)
    {
        if (impares[i] != 0)
        {
            Console.WriteLine(impares[i]);
        }
    }
}

catch (Exception ex) { 
    Console.WriteLine("Digita certo ai pô");
}
