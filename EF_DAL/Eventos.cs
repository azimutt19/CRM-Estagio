//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Eventos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Eventos()
        {
            this.Utilizadores = new HashSet<Utilizadores>();
        }
    
        public int Id_evento { get; set; }
        public int Id_empresa { get; set; }
        public int Id_cliente { get; set; }
        public string Assunto { get; set; }
        public string Notas { get; set; }
        public System.DateTime Data { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Empresas Empresas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Utilizadores> Utilizadores { get; set; }
    }
}