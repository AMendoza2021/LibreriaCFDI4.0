﻿// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv33.ComprobanteCfdiRelacionadosCfdiRelacionado
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
  public class ComprobanteCfdiRelacionadosCfdiRelacionado
  {
    private string uUIDField;

    [XmlAttribute]
    public string UUID
    {
      get => this.uUIDField;
      set => this.uUIDField = value;
    }
  }
}
