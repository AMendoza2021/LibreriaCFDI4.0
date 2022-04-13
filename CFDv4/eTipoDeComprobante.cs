// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv4.eTipoDeComprobante
// Assembly: CFDIV40.CFDLibV4, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CAF3DEF6-5DD4-4CB5-ADA2-9896E9851594
// Assembly location: C:\Users\Loera\Downloads\Facturacion4Old - copia.dll

using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace MictlanixV2.CFDv4
{
  [GeneratedCode("xsd", "4.6.1055.0")]
  [XmlType(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
  [Serializable]
  public enum eTipoDeComprobante
  {
    [XmlEnum("I")] Ingreso,
    [XmlEnum("E")] Egreso,
    [XmlEnum("T")] Traslado,
    [XmlEnum("N")] Nomina,
    [XmlEnum("P")] Pago,
  }
}
