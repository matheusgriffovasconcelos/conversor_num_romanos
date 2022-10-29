string op = "1";

while (op == "1")
{
    Console.Clear();
    ConverterNum();

    System.Console.WriteLine("\n[1] - Converter outro número");
    System.Console.WriteLine("[0] - ENCERRAR programa.");

    op = Console.ReadLine();
}



static void ConverterNum()
{


    //CRIANDO O DICIONÁRIO
    var rm = new Dictionary<char, int>();


    //ADICIONANDO OS VALORES AO DICIONÁRIO
    rm.Add('I', 1);
    rm.Add('V', 5);
    rm.Add('X', 10);
    rm.Add('L', 50);
    rm.Add('C', 100);
    rm.Add('D', 500);
    rm.Add('M', 1000);


    //LENDO O NUMERO ROMANO DIGITADO PELO USUÁRIO COM METODO CONVERTENDO PARA MAIUSCULO    
    Console.Write("Informe o numero ROMANO: ");
    string num_romano = Console.ReadLine().ToUpper();
    int tamanho = num_romano.Length;

    //ARRAY PARA RECEBER OS MEUS NUMEROS DIRETAMENTE CONVERTIDO PARA DECIMAL
    int[] novo = new int[tamanho];




    //PERCORRENDO O ARRAY E FAZENDO AS TROCAS NESCESSÁRIAS PARA CONVERSÃO. UTILIZANDO BUBBLESORT

    for (int i = 0; i < tamanho;)
    {
        foreach (char c in num_romano)
        {
            if (c == 'I')
            {
                novo[i] = rm['I'];
                i++;
            }
            else if (c == 'V')
            {
                novo[i] = rm['V'];
                i++;
            }
            else if (c == 'X')
            {
                novo[i] = rm['X'];
                i++;
            }
            else if (c == 'L')
            {
                novo[i] = rm['L'];
                i++;
            }
            else if (c == 'C')
            {
                novo[i] = rm['C'];
                i++;
            }
            else if (c == 'D')
            {
                novo[i] = rm['D'];
                i++;
            }
            else if (c == 'M')
            {
                novo[i] = rm['M'];
                i++;
            }
            else
            {
                System.Console.WriteLine("Voce inseriu um numero romano inválido!");

                Environment.Exit(0);
            }
        }
    }

    //INICIANDO MINHA VARIAVEL RESULTADO COM O ULTIMO NUMERO DIGITADO
    int resultado = novo[tamanho - 1];

    // AGORA PERCORRENDO O ARRAY DE TRAS PRA FRENTE REALIZANDO OS CALCULOS NESCESSARIOS PARA CONVERSAO.
    for (int i = tamanho - 1; i > 0; i--)
    {
        if (novo[i] > novo[i - 1])
        {
            resultado = resultado - novo[i - 1];
        }
        else if (novo[i] == novo[i - 1] || novo[i] < novo[i - 1])
        {
            resultado = resultado + novo[i - 1];
        }

    }

    System.Console.WriteLine($"\nO número convertido para decimal é: {resultado}");

}
