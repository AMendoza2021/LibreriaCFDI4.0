// Decompiled with JetBrains decompiler
// Type: CFDIV40.CFDLibV4.Addendas.Mabe.Factura
// Assembly: CFDIV40.CFDLibV4, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CAF3DEF6-5DD4-4CB5-ADA2-9896E9851594
// Assembly location: C:\Users\Loera\Downloads\Facturacion4Old - copia.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace CFDIV40.CFDLibV4.Addendas.Mabe
{
  [GeneratedCode("xsd", "4.0.30319.33440")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true, Namespace = "http://recepcionfe.mabempresa.com/cfd/addenda/v1")]
  [XmlRoot(IsNullable = false, Namespace = "http://recepcionfe.mabempresa.com/cfd/addenda/v1")]
  [Serializable]
  public class Factura
  {
    private FacturaMoneda monedaField;
    private FacturaProveedor proveedorField;
    private FacturaEntrega entregaField;
    private FacturaDetalle[] detallesField;
    private FacturaDescuentos descuentosField;
    private FacturaSubtotal subtotalField;
    private FacturaTraslado[] trasladosField;
    private FacturaRetencion[] retencionesField;
    private FacturaTotal totalField;
    private Decimal versionField;
    private FacturaTipoDocumento tipoDocumentoField;
    private string folioField;
    private DateTime fechaField;
    private string ordenCompraField;
    private string referencia1Field;
    private string referencia2Field;
    private string schema_location = string.Empty;
    private XmlSerializerNamespaces xmlns;

    public Factura() => this.versionField = 1.0M;

    public FacturaMoneda Moneda
    {
      get => this.monedaField;
      set => this.monedaField = value;
    }

    public FacturaProveedor Proveedor
    {
      get => this.proveedorField;
      set => this.proveedorField = value;
    }

    public FacturaEntrega Entrega
    {
      get => this.entregaField;
      set => this.entregaField = value;
    }

    [XmlArrayItem("Detalle", IsNullable = false)]
    public FacturaDetalle[] Detalles
    {
      get => this.detallesField;
      set => this.detallesField = value;
    }

    public FacturaDescuentos Descuentos
    {
      get => this.descuentosField;
      set => this.descuentosField = value;
    }

    public FacturaSubtotal Subtotal
    {
      get => this.subtotalField;
      set => this.subtotalField = value;
    }

    [XmlArrayItem("Traslado", IsNullable = false)]
    public FacturaTraslado[] Traslados
    {
      get => this.trasladosField;
      set => this.trasladosField = value;
    }

    [XmlArrayItem("Retencion", IsNullable = false)]
    public FacturaRetencion[] Retenciones
    {
      get => this.retencionesField;
      set => this.retencionesField = value;
    }

    public FacturaTotal Total
    {
      get => this.totalField;
      set => this.totalField = value;
    }

    [XmlAttribute]
    public Decimal version
    {
      get => this.versionField;
      set => this.versionField = value;
    }

    [XmlAttribute]
    public FacturaTipoDocumento tipoDocumento
    {
      get => this.tipoDocumentoField;
      set => this.tipoDocumentoField = value;
    }

    [XmlAttribute]
    public string folio
    {
      get => this.folioField;
      set => this.folioField = value;
    }

    [XmlAttribute(DataType = "date")]
    public DateTime fecha
    {
      get => this.fechaField;
      set => this.fechaField = value;
    }

    [XmlAttribute]
    public string ordenCompra
    {
      get => this.ordenCompraField;
      set => this.ordenCompraField = value;
    }

    [XmlAttribute]
    public string referencia1
    {
      get => this.referencia1Field;
      set => this.referencia1Field = value;
    }

    [XmlAttribute]
    public string referencia2
    {
      get => this.referencia2Field;
      set => this.referencia2Field = value;
    }

    [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
    public string SchemaLocation
    {
      get
      {
        if (string.IsNullOrWhiteSpace(this.schema_location))
          this.schema_location = "http://recepcionfe.mabempresa.com/cfd/addenda/v1 http://recepcionfe.mabempresa.com/cfd/addenda/v1/mabev1.xsd";
        return this.schema_location;
      }
      set => this.schema_location = value;
    }

    [XmlNamespaceDeclarations]
    public XmlSerializerNamespaces Xmlns
    {
      get
      {
        if (this.xmlns == null)
          this.xmlns = new XmlSerializerNamespaces(new XmlQualifiedName[2]
          {
            new XmlQualifiedName("mabe", "http://recepcionfe.mabempresa.com/cfd/addenda/v1"),
            new XmlQualifiedName("xsi", "http://www.w3.org/2001/XMLSchema-instance")
          });
        return this.xmlns;
      }
      set => this.xmlns = value;
    }

    public override string ToString() => this.ToXmlString();

    public string ToXmlString()
    {
      using (MemoryStream xmlStream = this.ToXmlStream())
        return Encoding.UTF8.GetString(xmlStream.ToArray());
    }

    public MemoryStream ToXmlStream() => Utils.SerializeToXmlStream<Factura>(this, this.Xmlns);
  }
}
