using System;
namespace FichasUniversitarias.Clases
{
	public class Aspirante
	{
		public string Nombres { get; set; }
		public string Apellidos { get; set; }
		public string Curp { get; set; }
		public Género Género { get; set; }
		public int Edad { get; set; }
		public string Teléfono { get; set; }
		public string CorreoElectrónico { get; set; }
	}
}

public enum Género
{
	Masculino, Femenino
}