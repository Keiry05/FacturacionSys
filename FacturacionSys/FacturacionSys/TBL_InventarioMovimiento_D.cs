//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FacturacionSys
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_InventarioMovimiento_D
    {
        public int CodMovimientoD { get; set; }
        public int CodMovimiento { get; set; }
        public int CodProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }
        public decimal Importe { get; set; }
    
        public virtual TBL_InventarioMovimiento TBL_InventarioMovimiento { get; set; }
        public virtual TBL_Producto TBL_Producto { get; set; }
    }
}
