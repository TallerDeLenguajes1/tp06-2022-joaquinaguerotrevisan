Console.WriteLine(" === CALCULADORA === \n");
Console.WriteLine("  [1] Suma\n  [2] Resta\n  [3] Multiplicacion\n  [4]Dividir\n  [5] Limpiar\n  [6] Parar Calculadora");

int Solicitacion = 0, NumeroElegido = 0;
Calculadora Calculadora0 = new Calculadora(0);

do
{
    do
    {
        Console.WriteLine("\nEscriba que operacion desea realizar: ");
        Solicitacion = Convert.ToInt32(Console.ReadLine());

    } while (Solicitacion<=0 || Solicitacion>6);

    if (Solicitacion != 6)
    {
        do
        {
            Console.WriteLine("\nEscriba el numero que desea operar: ");
            NumeroElegido = Convert.ToInt32(Console.ReadLine());

        } while (NumeroElegido<-100 || NumeroElegido>100); 
    }
    
    switch (Solicitacion)
    {
        case 1:
            Calculadora0.Suma(NumeroElegido);
            Console.WriteLine("\nResultado de la Suma: "+Calculadora0.Resultado);
            break;

        case 2:
            Calculadora0.Resta(NumeroElegido);
            Console.WriteLine("\nResultado de la Resta: "+Calculadora0.Resultado);
            break;
        
        case 3:
            Calculadora0.Multiplicacion(NumeroElegido);
            Console.WriteLine("\nResultado de la Multiplicacion: "+Calculadora0.Resultado);
            break;
        
        case 4:
            Calculadora0.Dividir(NumeroElegido);
            Console.WriteLine("\nResultado de la Division: "+Calculadora0.Resultado);
            break;

        case 5:
            Calculadora0.Limpiar();
            break;
    }

} while (Solicitacion!=6);