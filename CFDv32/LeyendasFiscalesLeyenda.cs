// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv32.LeyendasFiscalesLeyenda
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
  [GeneratedCode("System.Xml", "4.0.30319.17020")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.sat.gob.mx/leyendasFiscales")]
  [Serializable]
  public class LeyendasFiscalesLeyenda
  {
    private string disposicionFiscalField;
    private string normaField;
    private string textoLeyendaField;

    [XmlAttribute(Namespace = "")]
    public string disposicionFiscal
    {
      get => this.disposicionFiscalField;
      set => this.disposicionFiscalField = value;
    }

    [XmlAttribute(Namespace = "")]
    public string norma
    {
      get => this.normaField;
      set => this.normaField = value;
    }

    [XmlAttribute(Namespace = "")]
    public string textoLeyenda
    {
      get => this.textoLeyendaField;
      set => this.textoLeyendaField = value;
    }
  }
}
