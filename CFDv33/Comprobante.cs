// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv33.Comprobante
// Assembly: CFDIV40.CFDLibV4, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CAF3DEF6-5DD4-4CB5-ADA2-9896E9851594
// Assembly location: C:\Users\Loera\Downloads\Facturacion4Old - copia.dll

using CFDIV40.CFDLibV4;
using MictlanixV2.CFDv33.Resources;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace MictlanixV2.CFDv33
{
    [GeneratedCode("xsd", "4.6.1055.0")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    [XmlRoot(IsNullable = false, Namespace = "http://www.sat.gob.mx/cfd/4")]
    [Serializable]
    public class Comprobante
    {
        private ComprobanteCFDIRelacionados cfdiRelacionadosField;
        private ComprobanteEmisor emisorField;
        private ComprobanteReceptor receptorField;
        private List<ComprobanteConcepto> conceptosField;
        private ComprobanteImpuestos impuestosField;
        private List<object> complementoField;
        private List<object> addendaField;
        private string versionField;
        private string serieField;
        private string folioField;
        private DateTime fechaField;
        private string selloField;
        private string formaPagoField;
        private string noCertificadoField;
        private string certificadoField;
        private string condicionesDePagoField;
        private Decimal subTotalField;
        private Decimal descuentoField;
        private string monedaField;
        private Decimal tipoCambioField;
        private Decimal totalField;
        private eTipoDeComprobante tipoDeComprobanteField;
        private string metodoPagoField;
        private string lugarExpedicionField;
        private string confirmacionField;
        private string schema_location;
        private List<XmlQualifiedName> xmlns;

        public Comprobante()
        {
            this.versionField = "4.0";
            this.descuentoField = 0M;
            this.formaPagoField = "";
            this.metodoPagoField = "";
            this.tipoCambioField = 0M;
        }

        public ComprobanteCFDIRelacionados CfdiRelacionados
        {
            get => this.cfdiRelacionadosField;
            set => this.cfdiRelacionadosField = value;
        }

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
        public List<ComprobanteConcepto> Conceptos
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
        [XmlArrayItem(typeof(TimbreFiscalDigital), Namespace = "http://www.sat.gob.mx/TimbreFiscalDigital")]
        [XmlArrayItem(typeof(LeyendasFiscales), Namespace = "http://www.sat.gob.mx/leyendasFiscales")]
        public List<object> Complemento
        {
            get => this.complementoField;
            set => this.complementoField = value;
        }

        [XmlArray("Addenda")]
        public List<object> Addenda
        {
            get => this.addendaField;
            set => this.addendaField = value;
        }

        public bool ShouldSerializeAddenda() => (uint)this.addendaField.Count > 0U;

        [XmlAttribute]
        public string Version
        {
            get => this.versionField;
            set => this.versionField = value;
        }

        [XmlAttribute]
        public string Serie
        {
            get => this.serieField;
            set => this.serieField = value;
        }

        [XmlAttribute]
        public string Folio
        {
            get => this.folioField;
            set => this.folioField = value;
        }

        [XmlAttribute]
        public DateTime Fecha
        {
            get => this.fechaField;
            set => this.fechaField = value;
        }

        [XmlAttribute]
        public string Sello
        {
            get => this.selloField;
            set => this.selloField = value;
        }

        [XmlAttribute]
        public string FormaPago
        {
            get => this.formaPagoField;
            set => this.formaPagoField = value;
        }

        [XmlIgnore]
        public bool EspecificaFormaPago => ((string)this.formaPagoField).Length > 0;

        [XmlAttribute]
        public string NoCertificado
        {
            get => this.noCertificadoField;
            set => this.noCertificadoField = value;
        }

        [XmlAttribute]
        public string Certificado
        {
            get => this.certificadoField;
            set => this.certificadoField = value;
        }

        [XmlAttribute]
        public string CondicionesDePago
        {
            get => this.condicionesDePagoField;
            set => this.condicionesDePagoField = value;
        }

        [XmlAttribute]
        public Decimal SubTotal
        {
            get => this.subTotalField;
            set => this.subTotalField = value;
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

        [XmlAttribute]
        public string Moneda
        {
            get => this.monedaField;
            set => this.monedaField = value;
        }

        [XmlAttribute]
        public Decimal TipoCambio
        {
            get => this.tipoCambioField;
            set => this.tipoCambioField = value;
        }

        public bool ShouldSerializeTipoCambio() => !((string)((string)this.monedaField).ToLower()).Contains("mxn") && !((string)((string)this.monedaField).ToLower()).Contains("xxx");

        [XmlIgnore]
        public bool EspecificaTipoCambio => this.tipoCambioField > 0;

        [XmlAttribute]
        public Decimal Total
        {
            get => this.totalField;
            set => this.totalField = value;
        }

        [XmlAttribute]
        public eTipoDeComprobante TipoDeComprobante
        {
            get => this.tipoDeComprobanteField;
            set => this.tipoDeComprobanteField = value;
        }

        [XmlAttribute]
        public string MetodoPago
        {
            get => this.metodoPagoField;
            set => this.metodoPagoField = value;
        }

        [XmlIgnore]
        public bool EspecificaMetodoPago => ((string)this.metodoPagoField).Length > 0;

        [XmlAttribute]
        public string LugarExpedicion
        {
            get => this.lugarExpedicionField;
            set => this.lugarExpedicionField = value;
        }

        [XmlAttribute]
        public string Confirmacion
        {
            get => this.confirmacionField;
            set => this.confirmacionField = value;
        }

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
                            TimbreFiscalDigital timbreFiscalDigital = (TimbreFiscalDigital)obj;
                            if (timbreFiscalDigital.SchemaLocation != null && !((string)this.schema_location).Contains(timbreFiscalDigital.SchemaLocation))
                                this.schema_location = this.schema_location + " " + timbreFiscalDigital.SchemaLocation;
                        }
                        else if (obj is LeyendasFiscales)
                        {
                            LeyendasFiscales leyendasFiscales = (LeyendasFiscales)obj;
                            if (!((string)this.schema_location).Contains(leyendasFiscales.SchemaLocation))
                                this.schema_location = this.schema_location + " " + leyendasFiscales.SchemaLocation;
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
                return new XmlSerializerNamespaces(this.xmlns.ToArray());
            }
            set
            {
                if (value == null)
                    this.xmlns = (List<XmlQualifiedName>)null;
                else
                    this.xmlns = new List<XmlQualifiedName>((IEnumerable<XmlQualifiedName>)value.ToArray());
            }
        }

        public virtual string ToString()
        {
            EmbeddedResourceResolver resourceResolver = new EmbeddedResourceResolver();
            using (MemoryStream xmlStream = this.ToXmlStream())
            {
                using (StringWriter stringWriter = new StringWriter())
                {
                    using (Stream resource = (Stream)resourceResolver.GetResource("cadenaoriginal_3_3.xslt"))
                    {
                        XslCompiledTransform compiledTransform = new XslCompiledTransform();
                        compiledTransform.Load(XmlReader.Create(resource), XsltSettings.TrustedXslt, (XmlResolver)resourceResolver);
                        compiledTransform.Transform(XmlReader.Create((Stream)xmlStream), (XsltArgumentList)null, (TextWriter)stringWriter);
                        return ((object)stringWriter).ToString();
                    }
                }
            }
        }

        public MemoryStream ToXmlStream() => (MemoryStream)Utils.SerializeToXmlStream<Comprobante>(this, (XmlSerializerNamespaces)this.Xmlns);

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

        public void Sign(byte[] privateKey, byte[] password) => this.Sello = Utils.SHA256withRSA(base.ToString(), privateKey, password);

        public static Comprobante FromXml(string xml)
        {
            using (MemoryStream xml1 = new MemoryStream(Encoding.UTF8.GetBytes(xml)))
                return Comprobante.FromXml((Stream)xml1);
        }

        public static Comprobante FromXml(Stream xml)
        {
            return new XmlSerializer(typeof(Comprobante)).Deserialize(xml) as Comprobante;
        }
    }
}
