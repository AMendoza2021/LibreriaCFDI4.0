// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv22.t_Ubicacion
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
  public class t_Ubicacion
  {
    private string calleField;
    private string noExteriorField;
    private string noInteriorField;
    private string coloniaField;
    private string localidadField;
    private string referenciaField;
    private string municipioField;
    private string estadoField;
    private string paisField;
    private string codigoPostalField;

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
    public string colonia
    {
      get => this.coloniaField;
      set => this.coloniaField = value;
    }

    [XmlAttribute]
    public string localidad
    {
      get => this.localidadField;
      set => this.localidadField = value;
    }

    [XmlAttribute]
    public string referencia
    {
      get => this.referenciaField;
      set => this.referenciaField = value;
    }

    [XmlAttribute]
    public string municipio
    {
      get => this.municipioField;
      set => this.municipioField = value;
    }

    [XmlAttribute]
    public string estado
    {
      get => this.estadoField;
      set => this.estadoField = value;
    }

    [XmlAttribute]
    public string pais
    {
      get => this.paisField;
      set => this.paisField = value;
    }

    [XmlAttribute]
    public string codigoPostal
    {
      get => this.codigoPostalField;
      set => this.codigoPostalField = value;
    }
  }
}
