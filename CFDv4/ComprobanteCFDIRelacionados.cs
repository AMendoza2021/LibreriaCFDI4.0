// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv4.ComprobanteCFDIRelacionados
// Assembly: CFDIV40.CFDLibV4, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CAF3DEF6-5DD4-4CB5-ADA2-9896E9851594
// Assembly location: C:\Users\Loera\Downloads\Facturacion4Old - copia.dll

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
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
  public class ComprobanteCFDIRelacionados
  {
    private List<ComprobanteCfdiRelacionadosCfdiRelacionado> cfdiRelacionadoField;
    private string tipoRelacionField;

    [XmlElement("CfdiRelacionado")]
    public List<ComprobanteCfdiRelacionadosCfdiRelacionado> CfdiRelacionado
    {
      get => this.cfdiRelacionadoField;
      set => this.cfdiRelacionadoField = value;
    }

    [XmlAttribute]
    public string TipoRelacion
    {
      get => this.tipoRelacionField;
      set => this.tipoRelacionField = value;
    }
  }
}
