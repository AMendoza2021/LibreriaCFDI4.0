// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv22.ComprobanteConcepto
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
  public class ComprobanteConcepto
  {
    private object[] itemsField;
    private Decimal cantidadField;
    private string unidadField;
    private string noIdentificacionField;
    private string descripcionField;
    private Decimal valorUnitarioField;
    private Decimal importeField;

    [XmlElement("ComplementoConcepto", typeof (ComprobanteConceptoComplementoConcepto))]
    [XmlElement("CuentaPredial", typeof (ComprobanteConceptoCuentaPredial))]
    [XmlElement("InformacionAduanera", typeof (t_InformacionAduanera))]
    [XmlElement("Parte", typeof (ComprobanteConceptoParte))]
    public object[] Items
    {
      get => this.itemsField;
      set => this.itemsField = value;
    }

    [XmlAttribute]
    public Decimal cantidad
    {
      get => this.cantidadField;
      set => this.cantidadField = value;
    }

    [XmlAttribute]
    public string unidad
    {
      get => this.unidadField;
      set => this.unidadField = value;
    }

    [XmlAttribute]
    public string noIdentificacion
    {
      get => this.noIdentificacionField;
      set => this.noIdentificacionField = value;
    }

    [XmlAttribute]
    public string descripcion
    {
      get => this.descripcionField;
      set => this.descripcionField = value;
    }

    [XmlAttribute]
    public Decimal valorUnitario
    {
      get => this.valorUnitarioField;
      set => this.valorUnitarioField = value;
    }

    [XmlAttribute]
    public Decimal importe
    {
      get => this.importeField;
      set => this.importeField = value;
    }
  }
}
