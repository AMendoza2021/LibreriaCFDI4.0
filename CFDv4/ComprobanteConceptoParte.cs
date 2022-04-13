// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv4.ComprobanteConceptoParte
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
  public class ComprobanteConceptoParte
  {
    private ComprobanteConceptoParteInformacionAduanera[] informacionAduaneraField;
    private string claveProdServField;
    private string noIdentificacionField;
    private Decimal cantidadField;
    private string unidadField;
    private string descripcionField;
    private Decimal valorUnitarioField;
    private bool valorUnitarioFieldSpecified;
    private Decimal importeField;

    [XmlElement("InformacionAduanera")]
    public ComprobanteConceptoParteInformacionAduanera[] InformacionAduanera
    {
      get => this.informacionAduaneraField;
      set => this.informacionAduaneraField = value;
    }

    [XmlAttribute]
    public string ClaveProdServ
    {
      get => this.claveProdServField;
      set => this.claveProdServField = value;
    }

    [XmlAttribute]
    public string NoIdentificacion
    {
      get => this.noIdentificacionField;
      set => this.noIdentificacionField = value;
    }

    [XmlAttribute]
    public Decimal Cantidad
    {
      get => this.cantidadField;
      set => this.cantidadField = value;
    }

    [XmlAttribute]
    public string Unidad
    {
      get => this.unidadField;
      set => this.unidadField = value;
    }

    [XmlAttribute]
    public string Descripcion
    {
      get => this.descripcionField;
      set => this.descripcionField = value;
    }

    [XmlAttribute]
    public Decimal ValorUnitario
    {
      get => this.valorUnitarioField;
      set => this.valorUnitarioField = value;
    }

    [XmlIgnore]
    public bool ValorUnitarioSpecified
    {
      get => this.valorUnitarioFieldSpecified;
      set => this.valorUnitarioFieldSpecified = value;
    }

    [XmlAttribute]
    public Decimal Importe
    {
      get => this.importeField;
      set => this.importeField = value;
    }

    [XmlIgnore]
    public bool EspecificaImporte => this.importeField > 0M;
  }
}
