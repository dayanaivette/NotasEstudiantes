//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NotasEstudiantes.MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class notas
    {
        public int IdNotas { get; set; }
        public Nullable<double> nota { get; set; }
        public int IdEstudiante { get; set; }
        public int IdMateria { get; set; }
    
        public virtual estudiante estudiante { get; set; }
        public virtual materia materia { get; set; }
    }
}
