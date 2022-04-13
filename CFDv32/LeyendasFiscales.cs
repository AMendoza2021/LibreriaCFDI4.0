// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv32.LeyendasFiscales
// Assembly: CFDIV40.CFDLibV4, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CAF3DEF6-5DD4-4CB5-ADA2-9896E9851594
// Assembly location: C:\Users\Loera\Downloads\Facturacion4Old - copia.dll

using CFDIV40.CFDLibV4;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace MictlanixV2.CFDv32
{
  [GeneratedCode("System.Xml", "4.0.30319.17020")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.sat.gob.mx/leyendasFiscales")]
  [XmlRoot(IsNullable = false, Namespace = "http://www.sat.gob.mx/leyendasFiscales")]
  [Serializable]
  public class LeyendasFiscales
  {
    private string versionField;
    private LeyendasFiscalesLeyenda[] leyendaField;
    private string schema_location = string.Empty;
    private XmlSerializerNamespaces xmlns;

    public LeyendasFiscales() => this.versionField = "1.0";

    [XmlAttribute(Namespace = "")]
    public string version
    {
      get => this.versionField;
      set => this.versionField = value;
    }

    [XmlElement("Leyenda")]
    public LeyendasFiscalesLeyenda[] Leyenda
    {
      get => this.leyendaField;
      set => this.leyendaField = value;
    }

    [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
    public string SchemaLocation
    {
      get
      {
        if (this.schema_location == string.Empty)
          this.schema_location = "http://www.sat.gob.mx/leyendasFiscales http://www.sat.gob.mx/sitio_internet/cfd/leyendasFiscales/leyendasFisc.xsd";
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
            new XmlQualifiedName("leyendasFisc", "http://www.sat.gob.mx/leyendasFiscales"),
            new XmlQualifiedName("xsi", "http://www.w3.org/2001/XMLSchema-instance")
          });
        return this.xmlns;
      }
      set => this.xmlns = value;
    }

    public override string ToString() => this.ToXmlString();

    public string ToXmlString()
    {
      using (MemoryStream xmlStream = this.ToXmlStream())
        return Encoding.UTF8.GetString(xmlStream.ToArray());
    }

    public MemoryStream ToXmlStream() => Utils.SerializeToXmlStream<LeyendasFiscales>(this, this.Xmlns);
  }
}
