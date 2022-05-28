using System;

Empleado EmpleadoCargar1 = new Empleado("-","-",new DateTime(1900,01,01),new DateTime(1900,01,01),'-','-',0,0);
Empleado EmpleadoCargar2 = new Empleado("-","-",new DateTime(1900,01,01),new DateTime(1900,01,01),'-','-',0,0);
Empleado EmpleadoCargar3 = new Empleado("-","-",new DateTime(1900,01,01),new DateTime(1900,01,01),'-','-',0,0);

Console.WriteLine(" === COMPANIA GENERIK === ");

EmpleadoCargar1 = CargarEmpleado(EmpleadoCargar1);
EmpleadoCargar2 = CargarEmpleado(EmpleadoCargar2);
EmpleadoCargar3 = CargarEmpleado(EmpleadoCargar3);

EmpleadoCargar1.Salario(EmpleadoCargar1.Antiguedad(EmpleadoCargar1.FechaDeIngreso), EmpleadoCargar1.Cargo, EmpleadoCargar1.EstadoCivil, EmpleadoCargar1.SueldoBasico);
EmpleadoCargar2.Salario(EmpleadoCargar2.Antiguedad(EmpleadoCargar2.FechaDeIngreso), EmpleadoCargar2.Cargo, EmpleadoCargar2.EstadoCivil, EmpleadoCargar2.SueldoBasico);
EmpleadoCargar3.Salario(EmpleadoCargar3.Antiguedad(EmpleadoCargar3.FechaDeIngreso), EmpleadoCargar3.Cargo, EmpleadoCargar3.EstadoCivil, EmpleadoCargar3.SueldoBasico);

if (EmpleadoCargar1.AniosParaJubilarse(EmpleadoCargar1.Antiguedad(EmpleadoCargar1.FechaDeIngreso), EmpleadoCargar1.Genero) > EmpleadoCargar2.AniosParaJubilarse(EmpleadoCargar2.Antiguedad(EmpleadoCargar2.FechaDeIngreso), EmpleadoCargar2.Genero))
{
    if (EmpleadoCargar1.AniosParaJubilarse(EmpleadoCargar1.Antiguedad(EmpleadoCargar1.FechaDeIngreso), EmpleadoCargar1.Genero) > EmpleadoCargar3.AniosParaJubilarse(EmpleadoCargar3.Antiguedad(EmpleadoCargar3.FechaDeIngreso), EmpleadoCargar3.Genero))
    {
        Console.WriteLine(" - Empleado mas proximo a jubilarse: "+EmpleadoCargar1.Nombre);
        Console.WriteLine("\n   Edad: "+EmpleadoCargar1.Edad);
        Console.WriteLine("\n   Antiguedad: "+EmpleadoCargar1.Antiguedad(EmpleadoCargar1.FechaDeIngreso));
        Console.WriteLine("\n   Cantidad de anios: "+EmpleadoCargar1.AniosParaJubilarse(EmpleadoCargar1.Antiguedad(EmpleadoCargar1.FechaDeIngreso), EmpleadoCargar1.Genero));
        EmpleadoCargar1.Salario(EmpleadoCargar1.Antiguedad(EmpleadoCargar1.FechaDeIngreso), EmpleadoCargar1.Cargo, EmpleadoCargar1.EstadoCivil, EmpleadoCargar1.SueldoBasico);

    } else
    {
        Console.WriteLine(" - Empleado mas proximo a jubilarse: "+EmpleadoCargar3.Nombre);
        Console.WriteLine("\n   Edad: "+EmpleadoCargar3.Edad);
        Console.WriteLine("\n   Antiguedad: "+EmpleadoCargar3.Antiguedad(EmpleadoCargar3.FechaDeIngreso));
        Console.WriteLine("\n   Cantidad de anios: "+EmpleadoCargar3.AniosParaJubilarse(EmpleadoCargar3.Antiguedad(EmpleadoCargar3.FechaDeIngreso), EmpleadoCargar3.Genero));
        EmpleadoCargar3.Salario(EmpleadoCargar3.Antiguedad(EmpleadoCargar3.FechaDeIngreso), EmpleadoCargar3.Cargo, EmpleadoCargar3.EstadoCivil, EmpleadoCargar3.SueldoBasico);
    }

    Console.WriteLine(" - Empleado mas proximo a jubilarse: "+EmpleadoCargar2.Nombre);
    Console.WriteLine("\n   Edad: "+EmpleadoCargar2.Edad);
    Console.WriteLine("\n   Antiguedad: "+EmpleadoCargar2.Antiguedad(EmpleadoCargar2.FechaDeIngreso));
    Console.WriteLine("\n   Cantidad de anios: "+EmpleadoCargar2.AniosParaJubilarse(EmpleadoCargar2.Antiguedad(EmpleadoCargar2.FechaDeIngreso), EmpleadoCargar2.Genero));
    EmpleadoCargar2.Salario(EmpleadoCargar2.Antiguedad(EmpleadoCargar2.FechaDeIngreso), EmpleadoCargar2.Cargo, EmpleadoCargar2.EstadoCivil, EmpleadoCargar2.SueldoBasico);

}

// FUNCTION ===================================================================
static Empleado CargarEmpleado(Empleado EmpleadoGenerico)
{
    string Fecha = "---", CargoEmpleado = "---";

    Console.WriteLine("\n [1] Escriba su nombre: ");
    EmpleadoGenerico.Nombre= Convert.ToString(Console.ReadLine());
    Console.WriteLine("\n [2] Escriba su Apellido: ");
    EmpleadoGenerico.Apellido = Convert.ToString(Console.ReadLine());

    Console.WriteLine("\n [3] Escriba su Fecha de Naciemiento: ");
    Fecha = Convert.ToString(Console.ReadLine());;
    EmpleadoGenerico.FechaDeNacimiento = DateTime.Parse(Fecha);
    Console.WriteLine("\n [4] Escriba su Fecha de Ingreso a la Compania: ");
    Fecha = Convert.ToString(Console.ReadLine());;
    EmpleadoGenerico.FechaDeIngreso = DateTime.Parse(Fecha);

    Console.WriteLine("\n [5] Escriba su Estado Civil (Use la primera letra de su estado civil): ");
    EmpleadoGenerico.EstadoCivil = Convert.ToChar(Console.ReadLine());
    Console.WriteLine("\n [6] Escriba su Genero (Use la primera letra de su genero): ");
    EmpleadoGenerico.Genero = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("\n [7] Escriba su Sueldo Basico (Si ingresa un valor incorrecto, nosotros lo llamaremos): ");
    EmpleadoGenerico.SueldoBasico = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("\n [8] Escriba su Cargo en la compania ( Auxiliar, Administrativo, Ingeniero, Especialista, Investigador): ");
    CargoEmpleado = Convert.ToString(Console.ReadLine());;
    EmpleadoGenerico.Cargo = (Empleado.cargos)Enum.Parse(typeof(Empleado.cargos), CargoEmpleado);

    Console.WriteLine("\n ------------------------ ");

    return EmpleadoGenerico;
}