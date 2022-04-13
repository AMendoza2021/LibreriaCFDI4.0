// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv33.ComprobanteConceptoImpuestos
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
  public class ComprobanteConceptoImpuestos
  {
    private ComprobanteConceptoImpuestosTraslado[] trasladosField;
    private ComprobanteConceptoImpuestosRetencion[] retencionesField;

    [XmlArrayItem("Traslado", IsNullable = false)]
    public ComprobanteConceptoImpuestosTraslado[] Traslados
    {
      get => this.trasladosField;
      set => this.trasladosField = value;
    }

    [XmlArrayItem("Retencion", IsNullable = false)]
    public ComprobanteConceptoImpuestosRetencion[] Retenciones
    {
      get => this.retencionesField;
      set => this.retencionesField = value;
    }
  }
}
