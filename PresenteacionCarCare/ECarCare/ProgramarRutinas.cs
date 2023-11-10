namespace ECarCare
{
    public class ProgramarRutinas
    {
        public ProgramarRutinas(int idRutProgramadas, string fkIdVehiculos, string fkIdRutinas, string fecha)
        {
            IdRutProgramadas = idRutProgramadas;
            FkIdVehiculos = fkIdVehiculos;
            FkIdRutinas = fkIdRutinas;
            Fecha = fecha;
        }

        public int IdRutProgramadas { get; set; }
        public string FkIdVehiculos { get; set; }
        public string FkIdRutinas { get; set; }
        public string Fecha { get; set; }
    }
}
