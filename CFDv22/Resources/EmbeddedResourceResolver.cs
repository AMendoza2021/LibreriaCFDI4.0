// Decompiled with JetBrains decompiler
// Type: MictlanixV2.CFDv22.Resources.EmbeddedResourceResolver
// Assembly: CFDIV40.CFDLibV4, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CAF3DEF6-5DD4-4CB5-ADA2-9896E9851594
// Assembly location: C:\Users\Loera\Downloads\Facturacion4Old - copia.dll

using System;
using System.IO;
using System.Xml;

namespace MictlanixV2.CFDv22.Resources
{
  internal class EmbeddedResourceResolver : XmlUrlResolver
  {
    public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
    {
      Type type = typeof (EmbeddedResourceResolver);
      return (object) type.Assembly.GetManifestResourceStream(type, Path.GetFileName(absoluteUri.AbsolutePath));
    }

    public Stream GetResource(string name)
    {
      Type type = typeof (EmbeddedResourceResolver);
      return type.Assembly.GetManifestResourceStream(type, name);
    }
  }
}
