// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv22.t_InformacionAduanera
// Assembly: CFDIV40.CFDLibV4, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CAF3DEF6-5DD4-4CB5-ADA2-9896E9851594
// Assembly location: C:\Users\Loera\Downloads\Facturacion4Old - copia.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace MictlanixV2.CFDv22
{
  [GeneratedCode("xsd", "4.0.30319.1")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.sat.gob.mx/cfd/2")]
  [Serializable]
  public class t_InformacionAduanera
  {
    private string numeroField;
    private DateTime fechaField;
    private string aduanaField;

    [XmlAttribute]
    public string numero
    {
      get => this.numeroField;
      set => this.numeroField = value;
    }

    [XmlAttribute(DataType = "date")]
    public DateTime fecha
    {
      get => this.fechaField;
      set => this.fechaField = value;
    }

    [XmlAttribute]
    public string aduana
    {
      get => this.aduanaField;
      set => this.aduanaField = value;
    }
  }
}
