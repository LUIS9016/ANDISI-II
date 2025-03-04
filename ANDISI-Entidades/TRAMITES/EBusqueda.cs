using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANDISI_Entidades.TRAMITES
{
    public class EBusqueda
    {
        public string Id_Socio { get; set; }
        public string Estatus_Socio { get; set; }
        public string Categoria_Socio { get; set; }
        public string Nombre { get; set; }
        public string App { get; set; }
        public string Apm { get; set; }
        public string Nombre_Artistico { get; set; }
        public string Actividad_Artistico { get; set; }
        public string Numero_Anda { get; set; }
        public DateTime ? Fecha_Alta { get; set; }
        public DateTime ? Fecha_Activo { get; set; }
        public bool Menor_Edad { get; set; }
    }
}
