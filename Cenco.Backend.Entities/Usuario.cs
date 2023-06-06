namespace Cenco.Backend.Entities
{
	public class Usuario
	{
		public long id { get; set; } = 0;
		public DateTime fecha_creacion { get; set; } = DateTime.Now;	
		public DateTime? fecha_eliminacion { get; set; } = null;
		public long id_perfil { get; set; } = 0;
		public string nombres { get; set; }	= string.Empty;
		public string apellidos { get; set; } = String.Empty;
		public string email { get; set; } = string.Empty;
		public int activo { get; set; } = 1;
		
	}
}