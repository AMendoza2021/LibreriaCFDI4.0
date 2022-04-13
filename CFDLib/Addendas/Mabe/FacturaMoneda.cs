// Decompiled with JetBrains decompiler
// Type: CFDIV40.CFDLibV4.Addendas.Mabe.FacturaMoneda
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
  public class FacturaMoneda
  {
    private FacturaMonedaTipoMoneda tipoMonedaField;
    private Decimal tipoCambioField;
    private bool tipoCambioFieldSpecified;
    private string importeConLetraField;

    [XmlAttribute]
    public FacturaMonedaTipoMoneda tipoMoneda
    {
      get => this.tipoMonedaField;
      set => this.tipoMonedaField = value;
    }

    [XmlAttribute]
    public Decimal tipoCambio
    {
      get => this.tipoCambioField;
      set => this.tipoCambioField = value;
    }

    [XmlIgnore]
    public bool tipoCambioSpecified
    {
      get => this.tipoCambioFieldSpecified;
      set => this.tipoCambioFieldSpecified = value;
    }

    [XmlAttribute]
    public string importeConLetra
    {
      get => this.importeConLetraField;
      set => this.importeConLetraField = value;
    }
  }
}
