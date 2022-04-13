// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv4.TimbreFiscalDigital
// Assembly: CFDIV40.CFDLibV4, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CAF3DEF6-5DD4-4CB5-ADA2-9896E9851594
// Assembly location: C:\Users\Loera\Downloads\Facturacion4Old - copia.dll

using CFDIV40.CFDLibV4;
using MictlanixV2.CFDv4.Resources;
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

namespace MictlanixV2.CFDv4
{
  [GeneratedCode("xsd", "4.6.1055.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/TimbreFiscalDigital")]
  [XmlRoot(IsNullable = false, Namespace = "http://www.sat.gob.mx/TimbreFiscalDigital")]
  [Serializable]
  public class TimbreFiscalDigital
  {
    private string versionField;
    private string uUIDField;
    private DateTime fechaTimbradoField;
    private string rfcProvCertifField;
    private string leyendaField;
    private string selloCFDField;
    private string noCertificadoSATField;
    private string selloSATField;
    private string schema_location = string.Empty;
    private List<XmlQualifiedName> xmlns;

    public TimbreFiscalDigital() => this.versionField = "1.1";

    [XmlAttribute]
    public string Version
    {
      get => this.versionField;
      set => this.versionField = value;
    }

    [XmlAttribute]
    public string UUID
    {
      get => this.uUIDField;
      set => this.uUIDField = value;
    }

    [XmlAttribute]
    public DateTime FechaTimbrado
    {
      get => this.fechaTimbradoField;
      set => this.fechaTimbradoField = value;
    }

    [XmlAttribute]
    public string RfcProvCertif
    {
      get => this.rfcProvCertifField;
      set => this.rfcProvCertifField = value;
    }

    [XmlAttribute]
    public string Leyenda
    {
      get => this.leyendaField;
      set => this.leyendaField = value;
    }

    [XmlAttribute]
    public string SelloCFD
    {
      get => this.selloCFDField;
      set => this.selloCFDField = value;
    }

    [XmlAttribute]
    public string NoCertificadoSAT
    {
      get => this.noCertificadoSATField;
      set => this.noCertificadoSATField = value;
    }

    [XmlAttribute]
    public string SelloSAT
    {
      get => this.selloSATField;
      set => this.selloSATField = value;
    }

    [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
    public string SchemaLocation
    {
      get
      {
        if (this.schema_location == string.Empty)
          this.schema_location = "http://www.sat.gob.mx/TimbreFiscalDigital http://www.sat.gob.mx/sitio_internet/cfd/timbrefiscaldigital/TimbreFiscalDigitalv11.xsd";
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
          this.xmlns.Add(new XmlQualifiedName("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital"));
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
          using (Stream resource = stylesheetResolver.GetResource("cadenaoriginal_TFD_1_1.xslt"))
          {
            XslCompiledTransform compiledTransform = new XslCompiledTransform();
            compiledTransform.Load(XmlReader.Create(resource), XsltSettings.TrustedXslt, (XmlResolver) stylesheetResolver);
            compiledTransform.Transform(XmlReader.Create((Stream) xmlStream), (XsltArgumentList) null, (TextWriter) results);
            return results.ToString();
          }
        }
      }
    }

    public string ToXmlString()
    {
      using (MemoryStream xmlStream = this.ToXmlStream())
        return Encoding.UTF8.GetString(xmlStream.ToArray());
    }

    public MemoryStream ToXmlStream() => Utils.SerializeToXmlStream<TimbreFiscalDigital>(this, this.Xmlns);

    public static TimbreFiscalDigital FromXml(string xml)
    {
      using (MemoryStream xml1 = new MemoryStream(Encoding.UTF8.GetBytes(xml)))
        return TimbreFiscalDigital.FromXml((Stream) xml1);
    }

    public static TimbreFiscalDigital FromXml(Stream xml) => new XmlSerializer(typeof (TimbreFiscalDigital)).Deserialize(xml) as TimbreFiscalDigital;
  }
}
