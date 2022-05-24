public class Calculadora{
    public double Resultado;
    public Calculadora(double Valor1)
    {
        Resultado = Valor1;
    }

    public void Suma(double Valor2)
    {
        Resultado+=Valor2;
    }

    public void Resta(double Valor3)
    {
        Resultado-=Valor3;
    }

    public void Multiplicacion(double Valor3)
    {
        Resultado*=Valor3;
    }

    public void Dividir(double Valor4)
    {
        if (Valor4!=0)
        {
            Resultado/=Valor4;
        } else
        {
            Console.WriteLine("Error: el divisor es 0...");        
        }
    }

    public void Limpiar()
    {
        Resultado = 0;
    }
}