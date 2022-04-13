// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv33.ComprobanteImpuestos
// Assembly: CFDIV40.CFDLibV4, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CAF3DEF6-5DD4-4CB5-ADA2-9896E9851594
// Assembly location: C:\Users\Loera\Downloads\Facturacion4Old - copia.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace MictlanixV2.CFDv33
{
  [GeneratedCode("xsd", "4.6.1055.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
  [Serializable]
  public class ComprobanteImpuestos
  {
    private ComprobanteImpuestosRetencion[] retencionesField;
    private ComprobanteImpuestosTraslado[] trasladosField;
    private Decimal totalImpuestosRetenidosField;
    private bool totalImpuestosRetenidosFieldSpecified;
    private Decimal totalImpuestosTrasladadosField;
    private bool totalImpuestosTrasladadosFieldSpecified;

    [XmlArrayItem("Retencion", IsNullable = false)]
    public ComprobanteImpuestosRetencion[] Retenciones
    {
      get => this.retencionesField;
      set => this.retencionesField = value;
    }

    [XmlArrayItem("Traslado", IsNullable = false)]
    public ComprobanteImpuestosTraslado[] Traslados
    {
      get => this.trasladosField;
      set => this.trasladosField = value;
    }

    [XmlAttribute]
    public Decimal TotalImpuestosRetenidos
    {
      get => this.totalImpuestosRetenidosField;
      set => this.totalImpuestosRetenidosField = value;
    }

    [XmlIgnore]
    public bool TotalImpuestosRetenidosSpecified
    {
      get => this.totalImpuestosRetenidosFieldSpecified;
      set => this.totalImpuestosRetenidosFieldSpecified = value;
    }

    [XmlAttribute]
    public Decimal TotalImpuestosTrasladados
    {
      get => this.totalImpuestosTrasladadosField;
      set => this.totalImpuestosTrasladadosField = value;
    }

    [XmlIgnore]
    public bool TotalImpuestosTrasladadosSpecified
    {
      get => this.totalImpuestosTrasladadosFieldSpecified;
      set => this.totalImpuestosTrasladadosFieldSpecified = value;
    }
  }
}
