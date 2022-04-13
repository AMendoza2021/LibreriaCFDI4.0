// Decompiled with JetBrains decompiler
// Type: CFDIV40.CFDLibV4.Addendas.Mabe.FacturaDetalle
// Assembly: CFDIV40.CFDLibV4, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CAF3DEF6-5DD4-4CB5-ADA2-9896E9851594
// Assembly location: C:\Users\Loera\Downloads\Facturacion4Old - copia.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace CFDIV40.CFDLibV4.Addendas.Mabe
{
  [GeneratedCode("xsd", "4.0.30319.33440")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true, Namespace = "http://recepcionfe.mabempresa.com/cfd/addenda/v1")]
  [Serializable]
  public class FacturaDetalle
  {
    private string noLineaArticuloField;
    private string codigoArticuloField;
    private string descripcionField;
    private string unidadField;
    private Decimal cantidadField;
    private Decimal precioSinIvaField;
    private Decimal precioConIvaField;
    private bool precioConIvaFieldSpecified;
    private Decimal importeSinIvaField;
    private Decimal importeConIvaField;
    private bool importeConIvaFieldSpecified;

    [XmlAttribute(DataType = "integer")]
    public string noLineaArticulo
    {
      get => this.noLineaArticuloField;
      set => this.noLineaArticuloField = value;
    }

    [XmlAttribute]
    public string codigoArticulo
    {
      get => this.codigoArticuloField;
      set => this.codigoArticuloField = value;
    }

    [XmlAttribute]
    public string descripcion
    {
      get => this.descripcionField;
      set => this.descripcionField = value;
    }

    [XmlAttribute]
    public string unidad
    {
      get => this.unidadField;
      set => this.unidadField = value;
    }

    [XmlAttribute]
    public Decimal cantidad
    {
      get => this.cantidadField;
      set => this.cantidadField = value;
    }

    [XmlAttribute]
    public Decimal precioSinIva
    {
      get => this.precioSinIvaField;
      set => this.precioSinIvaField = value;
    }

    [XmlAttribute]
    public Decimal precioConIva
    {
      get => this.precioConIvaField;
      set => this.precioConIvaField = value;
    }

    [XmlIgnore]
    public bool precioConIvaSpecified
    {
      get => this.precioConIvaFieldSpecified;
      set => this.precioConIvaFieldSpecified = value;
    }

    [XmlAttribute]
    public Decimal importeSinIva
    {
      get => this.importeSinIvaField;
      set => this.importeSinIvaField = value;
    }

    [XmlAttribute]
    public Decimal importeConIva
    {
      get => this.importeConIvaField;
      set => this.importeConIvaField = value;
    }

    [XmlIgnore]
    public bool importeConIvaSpecified
    {
      get => this.importeConIvaFieldSpecified;
      set => this.importeConIvaFieldSpecified = value;
    }
  }
}
