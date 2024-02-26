using System;
namespace FichasUniversitarias.Clases
{
	public class Ficha
	{
		public Aspirante Aspirante { get; set; }
		public Carrera Carrera { get; set; }
		public Bachillerato Bachillerato { get; set; }
		public float PromedioDeBachillerato { get; set; }
		public DateTime Fecha { get; set; }
		public int Número { get; set; }
		public bool EntregaActaDeNacimiento { get; set; }
		public bool EntregaCertificado { get; set; }
		public bool EntregaCopiaIne { get; set; }

		public bool AlcanzaBeca()
		{
			// codigo para validar si alcanza beca
			if (PromedioDeBachillerato >= 9)
				return true;
			else
				return false;
		}
	}
}

