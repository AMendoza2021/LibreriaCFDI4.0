// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv32.TimbreFiscalDigital
// Assembly: CFDIV40.CFDLibV4, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CAF3DEF6-5DD4-4CB5-ADA2-9896E9851594
// Assembly location: C:\Users\Loera\Downloads\Facturacion4Old - copia.dll

using CFDIV40.CFDLibV4;
using MictlanixV2.CFDv32.Resources;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace MictlanixV2.CFDv32
{
  [GeneratedCode("xsd", "4.0.30319.1")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/TimbreFiscalDigital")]
  [XmlRoot(IsNullable = false, Namespace = "http://www.sat.gob.mx/TimbreFiscalDigital")]
  [Serializable]
  public class TimbreFiscalDigital
  {
    private string schema_location = string.Empty;
    private XmlSerializerNamespaces xmlns;
    private string versionField;
    private string uUIDField;
    private DateTime fechaTimbradoField;
    private string selloCFDField;
    private string noCertificadoSATField;
    private string selloSATField;

    [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
    public string SchemaLocation
    {
      get
      {
        if (this.schema_location == string.Empty)
          this.schema_location = "http://www.sat.gob.mx/TimbreFiscalDigital http://www.sat.gob.mx/sitio_internet/TimbreFiscalDigital/TimbreFiscalDigital.xsd";
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
          this.xmlns = new XmlSerializerNamespaces(new XmlQualifiedName[2]
          {
            new XmlQualifiedName("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital"),
            new XmlQualifiedName("xsi", "http://www.w3.org/2001/XMLSchema-instance")
          });
        return this.xmlns;
      }
      set => this.xmlns = value;
    }

    public override string ToString()
    {
      EmbeddedResourceResolver stylesheetResolver = new EmbeddedResourceResolver();
      using (MemoryStream xmlStream = this.ToXmlStream())
      {
        using (StringWriter results = new StringWriter())
        {
          using (Stream resource = stylesheetResolver.GetResource("cadenaoriginal_TFD_1_0.xslt"))
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

    public TimbreFiscalDigital() => this.versionField = "1.0";

    [XmlAttribute]
    public string version
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
    public string selloCFD
    {
      get => this.selloCFDField;
      set => this.selloCFDField = value;
    }

    [XmlAttribute]
    public string noCertificadoSAT
    {
      get => this.noCertificadoSATField;
      set => this.noCertificadoSATField = value;
    }

    [XmlAttribute]
    public string selloSAT
    {
      get => this.selloSATField;
      set => this.selloSATField = value;
    }
  }
}
