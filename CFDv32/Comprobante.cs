// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv32.Comprobante
// Assembly: CFDIV40.CFDLibV4, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CAF3DEF6-5DD4-4CB5-ADA2-9896E9851594
// Assembly location: C:\Users\Loera\Downloads\Facturacion4Old - copia.dll

using CFDIV40.CFDLibV4;
using CFDIV40.CFDLibV4.Addendas.Mabe;
using MictlanixV2.CFDv32.Resources;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace MictlanixV2.CFDv32
{
  [GeneratedCode("xsd", "4.0.30319.1")]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
  [XmlRoot(IsNullable = false, Namespace = "http://www.sat.gob.mx/cfd/3")]
  [Serializable]
  public class Comprobante
  {
    private string schema_location;
    private List<XmlQualifiedName> xmlns;
    private ComprobanteEmisor emisorField;
    private ComprobanteReceptor receptorField;
    private ComprobanteConcepto[] conceptosField;
    private ComprobanteImpuestos impuestosField;
    private List<object> complementoField;
    private List<object> addendaField;
    private string versionField;
    private string serieField;
    private string folioField;
    private DateTime fechaField;
    private string selloField;
    private string formaDePagoField;
    private string noCertificadoField;
    private string certificadoField;
    private string condicionesDePagoField;
    private Decimal subTotalField;
    private Decimal descuentoField;
    private bool descuentoFieldSpecified;
    private string motivoDescuentoField;
    private string tipoCambioField;
    private string monedaField;
    private Decimal totalField;
    private ComprobanteTipoDeComprobante tipoDeComprobanteField;
    private string metodoDePagoField;
    private string lugarExpedicionField;
    private string numCtaPagoField;
    private string folioFiscalOrigField;
    private string serieFolioFiscalOrigField;
    private DateTime fechaFolioFiscalOrigField;
    private bool fechaFolioFiscalOrigFieldSpecified;
    private Decimal montoFolioFiscalOrigField;
    private bool montoFolioFiscalOrigFieldSpecified;

    [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
    public string SchemaLocation
    {
      get
      {
        if (this.schema_location == null)
          this.schema_location = "http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd";
        if (this.Complemento != null)
        {
          foreach (object obj in this.Complemento)
          {
            if (obj is TimbreFiscalDigital)
            {
              TimbreFiscalDigital timbreFiscalDigital = (TimbreFiscalDigital) obj;
              if (timbreFiscalDigital.SchemaLocation != null && !this.schema_location.Contains(timbreFiscalDigital.SchemaLocation))
                this.schema_location = this.schema_location + " " + timbreFiscalDigital.SchemaLocation;
            }
            else if (obj is LeyendasFiscales)
            {
              LeyendasFiscales leyendasFiscales = (LeyendasFiscales) obj;
              if (!this.schema_location.Contains(leyendasFiscales.SchemaLocation))
                this.schema_location = this.schema_location + " " + leyendasFiscales.SchemaLocation;
            }
          }
        }
        if (this.Addenda != null)
        {
          foreach (object addendum in this.Addenda)
          {
            if (addendum is Factura)
            {
              Factura factura = (Factura) addendum;
              if (factura.SchemaLocation != null && !this.schema_location.Contains(factura.SchemaLocation))
                this.schema_location = this.schema_location + " " + factura.SchemaLocation;
            }
          }
        }
        return this.schema_location;
      }
      set => this.schema_location = value;
    }

    [XmlNamespaceDeclarations]
    public XmlSerializerNamespaces Xmlns
    {
      get
      {
        if (this.xmlns == null)
        {
          this.xmlns = new List<XmlQualifiedName>();
          this.xmlns.Add(new XmlQualifiedName("cfdi", "http://www.sat.gob.mx/cfd/3"));
          this.xmlns.Add(new XmlQualifiedName("xsi", "http://www.w3.org/2001/XMLSchema-instance"));
        }
        if (this.Complemento != null)
        {
          foreach (object obj in this.Complemento)
          {
            if (obj is TimbreFiscalDigital && !this.xmlns.Exists((Predicate<XmlQualifiedName>) (x => x.Name == "tfd")))
              this.xmlns.Add(new XmlQualifiedName("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital"));
            else if (obj is LeyendasFiscales && !this.xmlns.Exists((Predicate<XmlQualifiedName>) (x => x.Name == "leyendasFisc")))
              this.xmlns.Add(new XmlQualifiedName("leyendasFisc", "http://www.sat.gob.mx/leyendasFiscales"));
          }
        }
        if (this.Addenda != null)
        {
          foreach (object addendum in this.Addenda)
          {
            if (addendum is Factura && !this.xmlns.Exists((Predicate<XmlQualifiedName>) (x => x.Name == "mabe")))
              this.xmlns.Add(new XmlQualifiedName("mabe", "http://recepcionfe.mabempresa.com/cfd/addenda/v1"));
          }
        }
        return new XmlSerializerNamespaces(this.xmlns.ToArray());
      }
      set
      {
        if (value == null)
          this.xmlns = (List<XmlQualifiedName>) null;
        else
          this.xmlns = new List<XmlQualifiedName>((IEnumerable<XmlQualifiedName>) value.ToArray());
      }
    }

    public override string ToString()
    {
      EmbeddedResourceResolver stylesheetResolver = new EmbeddedResourceResolver();
      using (MemoryStream xmlStream = this.ToXmlStream())
      {
        using (StringWriter results = new StringWriter())
        {
          using (Stream resource = stylesheetResolver.GetResource("cadenaoriginal_3_2.xslt"))
          {
            XslCompiledTransform compiledTransform = new XslCompiledTransform();
            compiledTransform.Load(XmlReader.Create(resource), XsltSettings.TrustedXslt, (XmlResolver) stylesheetResolver);
            compiledTransform.Transform(XmlReader.Create((Stream) xmlStream), (XsltArgumentList) null, (TextWriter) results);
            return results.ToString();
          }
        }
      }
    }

    public MemoryStream ToXmlStream() => Utils.SerializeToXmlStream<Comprobante>(this, this.Xmlns);

    public byte[] ToXmlBytes()
    {
      using (MemoryStream xmlStream = this.ToXmlStream())
        return xmlStream.ToArray();
    }

    public string ToXmlString()
    {
      using (MemoryStream xmlStream = this.ToXmlStream())
        return Encoding.UTF8.GetString(xmlStream.ToArray());
    }

    public void Sign(byte[] privateKey, byte[] password) => this.sello = Utils.SHA1WithRSA(this.ToString(), privateKey, password);

    public static Comprobante FromXml(string xml)
    {
      using (MemoryStream xml1 = new MemoryStream(Encoding.UTF8.GetBytes(xml)))
        return Comprobante.FromXml((Stream) xml1);
    }

    public static Comprobante FromXml(Stream xml) => new XmlSerializer(typeof (Comprobante)).Deserialize(xml) as Comprobante;

    public Comprobante() => this.versionField = "3.2";

    public ComprobanteEmisor Emisor
    {
      get => this.emisorField;
      set => this.emisorField = value;
    }

    public ComprobanteReceptor Receptor
    {
      get => this.receptorField;
      set => this.receptorField = value;
    }

    [XmlArrayItem("Concepto", IsNullable = false)]
    public ComprobanteConcepto[] Conceptos
    {
      get => this.conceptosField;
      set => this.conceptosField = value;
    }

    public ComprobanteImpuestos Impuestos
    {
      get => this.impuestosField;
      set => this.impuestosField = value;
    }

    [XmlArray("Complemento")]
    [XmlArrayItem(typeof (TimbreFiscalDigital), Namespace = "http://www.sat.gob.mx/TimbreFiscalDigital")]
    [XmlArrayItem(typeof (LeyendasFiscales), Namespace = "http://www.sat.gob.mx/leyendasFiscales")]
    public List<object> Complemento
    {
      get => this.complementoField;
      set => this.complementoField = value;
    }

    [XmlArray("Addenda")]
    [XmlArrayItem(typeof (Factura), Namespace = "http://recepcionfe.mabempresa.com/cfd/addenda/v1")]
    public List<object> Addenda
    {
      get => this.addendaField;
      set => this.addendaField = value;
    }

    [XmlAttribute]
    public string version
    {
      get => this.versionField;
      set => this.versionField = value;
    }

    [XmlAttribute]
    public string serie
    {
      get => this.serieField;
      set => this.serieField = value;
    }

    [XmlAttribute]
    public string folio
    {
      get => this.folioField;
      set => this.folioField = value;
    }

    [XmlAttribute]
    public DateTime fecha
    {
      get => this.fechaField;
      set => this.fechaField = value;
    }

    [XmlAttribute]
    public string sello
    {
      get => this.selloField;
      set => this.selloField = value;
    }

    [XmlAttribute]
    public string formaDePago
    {
      get => this.formaDePagoField;
      set => this.formaDePagoField = value;
    }

    [XmlAttribute]
    public string noCertificado
    {
      get => this.noCertificadoField;
      set => this.noCertificadoField = value;
    }

    [XmlAttribute]
    public string certificado
    {
      get => this.certificadoField;
      set => this.certificadoField = value;
    }

    [XmlAttribute]
    public string condicionesDePago
    {
      get => this.condicionesDePagoField;
      set => this.condicionesDePagoField = value;
    }

    [XmlAttribute]
    public Decimal subTotal
    {
      get => this.subTotalField;
      set => this.subTotalField = value;
    }

    [XmlAttribute]
    public Decimal descuento
    {
      get => this.descuentoField;
      set => this.descuentoField = value;
    }

    [XmlIgnore]
    public bool descuentoSpecified
    {
      get => this.descuentoFieldSpecified;
      set => this.descuentoFieldSpecified = value;
    }

    [XmlAttribute]
    public string motivoDescuento
    {
      get => this.motivoDescuentoField;
      set => this.motivoDescuentoField = value;
    }

    [XmlAttribute]
    public string TipoCambio
    {
      get => this.tipoCambioField;
      set => this.tipoCambioField = value;
    }

    [XmlAttribute]
    public string Moneda
    {
      get => this.monedaField;
      set => this.monedaField = value;
    }

    [XmlAttribute]
    public Decimal total
    {
      get => this.totalField;
      set => this.totalField = value;
    }

    [XmlAttribute]
    public ComprobanteTipoDeComprobante tipoDeComprobante
    {
      get => this.tipoDeComprobanteField;
      set => this.tipoDeComprobanteField = value;
    }

    [XmlAttribute]
    public string metodoDePago
    {
      get => this.metodoDePagoField;
      set => this.metodoDePagoField = value;
    }

    [XmlAttribute]
    public string LugarExpedicion
    {
      get => this.lugarExpedicionField;
      set => this.lugarExpedicionField = value;
    }

    [XmlAttribute]
    public string NumCtaPago
    {
      get => this.numCtaPagoField;
      set => this.numCtaPagoField = value;
    }

    [XmlAttribute]
    public string FolioFiscalOrig
    {
      get => this.folioFiscalOrigField;
      set => this.folioFiscalOrigField = value;
    }

    [XmlAttribute]
    public string SerieFolioFiscalOrig
    {
      get => this.serieFolioFiscalOrigField;
      set => this.serieFolioFiscalOrigField = value;
    }

    [XmlAttribute]
    public DateTime FechaFolioFiscalOrig
    {
      get => this.fechaFolioFiscalOrigField;
      set => this.fechaFolioFiscalOrigField = value;
    }

    [XmlIgnore]
    public bool FechaFolioFiscalOrigSpecified
    {
      get => this.fechaFolioFiscalOrigFieldSpecified;
      set => this.fechaFolioFiscalOrigFieldSpecified = value;
    }

    [XmlAttribute]
    public Decimal MontoFolioFiscalOrig
    {
      get => this.montoFolioFiscalOrigField;
      set => this.montoFolioFiscalOrigField = value;
    }

    [XmlIgnore]
    public bool MontoFolioFiscalOrigSpecified
    {
      get => this.montoFolioFiscalOrigFieldSpecified;
      set => this.montoFolioFiscalOrigFieldSpecified = value;
    }
  }
}
