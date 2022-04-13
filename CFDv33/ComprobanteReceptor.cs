// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv33.ComprobanteReceptor
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
  public class ComprobanteReceptor
  {
    private string rfcField;
    private string nombreField;
    private string residenciaFiscalField;
    private bool residenciaFiscalFieldSpecified;
    private string numRegIdTribField;
    private string usoCFDIField;

    [XmlAttribute]
    public string Rfc
    {
      get => this.rfcField;
      set => this.rfcField = value;
    }

    [XmlAttribute]
    public string Nombre
    {
      get => this.nombreField;
      set => this.nombreField = value;
    }

    [XmlAttribute]
    public string ResidenciaFiscal
    {
      get => this.residenciaFiscalField;
      set => this.residenciaFiscalField = value;
    }

    [XmlIgnore]
    public bool ResidenciaFiscalSpecified
    {
      get => this.residenciaFiscalFieldSpecified;
      set => this.residenciaFiscalFieldSpecified = value;
    }

    [XmlAttribute]
    public string NumRegIdTrib
    {
      get => this.numRegIdTribField;
      set => this.numRegIdTribField = value;
    }

    [XmlAttribute]
    public string UsoCFDI
    {
      get => this.usoCFDIField;
      set => this.usoCFDIField = value;
    }
  }
}
