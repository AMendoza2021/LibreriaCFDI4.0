﻿// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv22.ComprobanteReceptor
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
  [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/2")]
  [Serializable]
  public class ComprobanteReceptor
  {
    private t_Ubicacion domicilioField;
    private string rfcField;
    private string nombreField;

    public t_Ubicacion Domicilio
    {
      get => this.domicilioField;
      set => this.domicilioField = value;
    }

    [XmlAttribute]
    public string rfc
    {
      get => this.rfcField;
      set => this.rfcField = value;
    }

    [XmlAttribute]
    public string nombre
    {
      get => this.nombreField;
      set => this.nombreField = value;
    }
  }
}
