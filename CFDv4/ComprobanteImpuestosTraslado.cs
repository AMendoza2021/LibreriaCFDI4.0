// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv4.ComprobanteImpuestosTraslado
// Assembly: CFDIV40.CFDLibV4, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CAF3DEF6-5DD4-4CB5-ADA2-9896E9851594
// Assembly location: C:\Users\Loera\Downloads\Facturacion4Old - copia.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace MictlanixV2.CFDv4
{
  [GeneratedCode("xsd", "4.6.1055.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
  [Serializable]
  public class ComprobanteImpuestosTraslado
  {
    private string impuestoField;
    private string tipoFactorField;
    private Decimal tasaOCuotaField;
    private Decimal importeField;

    [XmlAttribute]
    public string Impuesto
    {
      get => this.impuestoField;
      set => this.impuestoField = value;
    }

    [XmlAttribute]
    public string TipoFactor
    {
      get => this.tipoFactorField;
      set => this.tipoFactorField = value;
    }

    [XmlAttribute]
    public Decimal TasaOCuota
    {
      get => this.tasaOCuotaField;
      set => this.tasaOCuotaField = value;
    }

    [XmlAttribute]
    public Decimal Importe
    {
      get => this.importeField;
      set => this.importeField = value;
    }
  }
}
