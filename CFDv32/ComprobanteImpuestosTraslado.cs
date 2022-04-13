// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv32.ComprobanteImpuestosTraslado
// Assembly: CFDIV40.CFDLibV4, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CAF3DEF6-5DD4-4CB5-ADA2-9896E9851594
// Assembly location: C:\Users\Loera\Downloads\Facturacion4Old - copia.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace MictlanixV2.CFDv32
{
  [GeneratedCode("xsd", "4.0.30319.1")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
  [Serializable]
  public class ComprobanteImpuestosTraslado
  {
    private ComprobanteImpuestosTrasladoImpuesto impuestoField;
    private Decimal tasaField;
    private Decimal importeField;

    [XmlAttribute]
    public ComprobanteImpuestosTrasladoImpuesto impuesto
    {
      get => this.impuestoField;
      set => this.impuestoField = value;
    }

    [XmlAttribute]
    public Decimal tasa
    {
      get => this.tasaField;
      set => this.tasaField = value;
    }

    [XmlAttribute]
    public Decimal importe
    {
      get => this.importeField;
      set => this.importeField = value;
    }
  }
}
