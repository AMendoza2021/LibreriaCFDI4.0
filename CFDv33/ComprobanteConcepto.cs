// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv33.ComprobanteConcepto
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
  public class ComprobanteConcepto
  {
    private ComprobanteConceptoImpuestos impuestosField;
    private ComprobanteConceptoInformacionAduanera[] informacionAduaneraField;
    private ComprobanteConceptoCuentaPredial cuentaPredialField;
    private ComprobanteConceptoComplementoConcepto complementoConceptoField;
    private ComprobanteConceptoParte[] parteField;
    private string claveProdServField;
    private string noIdentificacionField;
    private Decimal cantidadField;
    private string claveUnidadField;
    private string unidadField;
    private string descripcionField;
    private Decimal valorUnitarioField;
    private Decimal importeField;
    private Decimal descuentoField;

    public ComprobanteConceptoImpuestos Impuestos
    {
      get => this.impuestosField;
      set => this.impuestosField = value;
    }

    [XmlElement("InformacionAduanera")]
    public ComprobanteConceptoInformacionAduanera[] InformacionAduanera
    {
      get => this.informacionAduaneraField;
      set => this.informacionAduaneraField = value;
    }

    public ComprobanteConceptoCuentaPredial CuentaPredial
    {
      get => this.cuentaPredialField;
      set => this.cuentaPredialField = value;
    }

    public ComprobanteConceptoComplementoConcepto ComplementoConcepto
    {
      get => this.complementoConceptoField;
      set => this.complementoConceptoField = value;
    }

    [XmlElement("Parte")]
    public ComprobanteConceptoParte[] Parte
    {
      get => this.parteField;
      set => this.parteField = value;
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
    public string ClaveUnidad
    {
      get => this.claveUnidadField;
      set => this.claveUnidadField = value;
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

    [XmlAttribute]
    public Decimal Importe
    {
      get => this.importeField;
      set => this.importeField = value;
    }

    [XmlAttribute]
    public Decimal Descuento
    {
      get => this.descuentoField;
      set => this.descuentoField = value;
    }

    [XmlIgnore]
    public bool EspecificaDescuento => this.descuentoField > 0M;

    public bool ShouldSerializeDescuento() => this.descuentoField > 0M;
  }
}
