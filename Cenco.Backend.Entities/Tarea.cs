using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenco.Backend.Entities
{
	public class Tarea
	{
		public long id { get; set; } = 0;
		public long id_usuario { get; set; } = 0;
		public DateTime fecha_creacion { get; set; } = DateTime.Now;
		public DateTime? fecha_eliminacion { get; set; } = null;
		public string titulo { get; set; } = string.Empty;
		public string descripcion { get; set; } = string.Empty;
		public int estado { get; set; } = 1;
	}
}
