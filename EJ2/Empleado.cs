// CLASES -----------------------------------------
using System;
public class Empleado
{
    public string Nombre;
    public string Apellido;

    public DateTime FechaDeNacimiento;
    public DateTime FechaDeIngreso;

    public char EstadoCivil;
    public char Genero;

    public double SueldoBasico;

    public cargos Cargo;

    public enum cargos
    {

        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador

    }

    public Empleado(string NombreUsuario, string ApellidoUsuario, DateTime FechaNacUsuario, DateTime FechaIngUsuario, char EstadoCivilUsuario, char GeneroUsuario, double SueldoBasicoUsuario, cargos CargoUsuario)
    {
        Nombre = NombreUsuario;
        Apellido = ApellidoUsuario;

        FechaDeNacimiento = FechaNacUsuario;
        FechaDeIngreso = FechaIngUsuario;

        EstadoCivil = Char.ToLower(EstadoCivilUsuario);
        Genero = Char.ToLower(GeneroUsuario);

        SueldoBasico = SueldoBasicoUsuario;
        Cargo = CargoUsuario;
    }

    public int Antiguedad (DateTime FechaIngUsuario)
    {
        DateTime FechaActual = DateTime.Today;
        
        int Antiguedad = FechaActual.Year - FechaIngUsuario.Year;

        if (FechaIngUsuario.Month > FechaActual.Month)
        {
            --Antiguedad;
        }

        return Antiguedad;

    }

    public int Edad (DateTime FechaDeNacimiento)
    {
        DateTime FechaActual = DateTime.Today;

        int Edad = FechaActual.Year - FechaDeNacimiento.Year;

        if (FechaDeNacimiento.Month > FechaActual.Month)
        {
            --Edad;
        }

        return Edad;
        
    }

    public int AniosParaJubilarse (int Antiguedad, char GeneroUsuario)
    {
        if (GeneroUsuario == 'm')
        {
            int AniosParaJubilarse = Antiguedad -  65;
            return AniosParaJubilarse;

        } else if (GeneroUsuario == 'f')
        {
            int AniosParaJubilarse = Antiguedad - 60;
            return AniosParaJubilarse;
        }

        return 0;
    }

    public void Salario (int Antiguedad, cargos CargoUsuario, char EstadoCivilUsuario, double SueldoBasicoUsuario)
    {
        double Adicional = 0;

        if(Antiguedad<=20){

            Adicional = SueldoBasicoUsuario*(0.01*Antiguedad);

        } else
        {
            Adicional = SueldoBasicoUsuario*0.25;
        }

        if (CargoUsuario == cargos.Ingeniero || CargoUsuario == cargos.Especialista)
        {
            Adicional = Adicional + (Adicional*0.50);
        }

        if (EstadoCivilUsuario == 'c')
        {
            Adicional = Adicional + 15000;
        }

        Console.WriteLine("Sueldo del Empleado: {0}",SueldoBasicoUsuario + Adicional);

    }
}