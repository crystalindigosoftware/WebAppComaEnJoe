//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mesas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mesas()
        {
            this.MesasPorSalon = new HashSet<MesasPorSalon>();
        }
    
        public int ID { get; set; }
        public string Mesa { get; set; }
        public int TipoMesa { get; set; }
        public byte CantidadPersonas { get; set; }
    
        public virtual MesasTipos MesasTipos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MesasPorSalon> MesasPorSalon { get; set; }
    }
}
