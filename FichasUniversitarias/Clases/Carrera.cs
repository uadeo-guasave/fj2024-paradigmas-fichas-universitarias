using System;
namespace FichasUniversitarias.Clases
{
    public class Carrera
    {
        public string Nombre { get; set; }
        public int PlanDeEstudios { get; set; }
        public int TotalDeSemestres { get; set; }
        public int TotalDeCréditos { get; set; }
        public CoordinadorDeCarrera CoordinadorDeCarrera { get; set; }
    }
}

