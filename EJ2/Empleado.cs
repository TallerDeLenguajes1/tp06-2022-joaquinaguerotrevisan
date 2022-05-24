// CLASES -----------------------------------------
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

        EstadoCivil = EstadoCivilUsuario;
        Genero = GeneroUsuario;

        SueldoBasico = SueldoBasicoUsuario;
        Cargo = CargoUsuario;
    }

}