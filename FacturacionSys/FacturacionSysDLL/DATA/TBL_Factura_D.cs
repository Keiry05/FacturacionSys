//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FacturacionSysDLL.DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_Factura_D
    {
        public int CodFacturaD { get; set; }
        public int CodFactura { get; set; }
        public int CodProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public decimal Importe { get; set; }
        public Nullable<decimal> CantidadDev { get; set; }
    
        public virtual TBL_Factura TBL_Factura { get; set; }
        public virtual TBL_Producto TBL_Producto { get; set; }
    }
}
