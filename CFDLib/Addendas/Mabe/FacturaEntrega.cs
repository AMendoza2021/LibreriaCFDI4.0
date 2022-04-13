// Decompiled with JetBrains decompiler
// Type: CFDIV40.CFDLibV4.Addendas.Mabe.FacturaEntrega
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
  public class FacturaEntrega
  {
    private string plantaEntregaField;
    private string calleField;
    private string noExteriorField;
    private string noInteriorField;
    private string codigoPostalField;

    [XmlAttribute]
    public string plantaEntrega
    {
      get => this.plantaEntregaField;
      set => this.plantaEntregaField = value;
    }

    [XmlAttribute]
    public string calle
    {
      get => this.calleField;
      set => this.calleField = value;
    }

    [XmlAttribute]
    public string noExterior
    {
      get => this.noExteriorField;
      set => this.noExteriorField = value;
    }

    [XmlAttribute]
    public string noInterior
    {
      get => this.noInteriorField;
      set => this.noInteriorField = value;
    }

    [XmlAttribute]
    public string codigoPostal
    {
      get => this.codigoPostalField;
      set => this.codigoPostalField = value;
    }
  }
}
