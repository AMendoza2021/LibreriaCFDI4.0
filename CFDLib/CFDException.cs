// Decompiled with JetBrains decompiler
// Type: CFDIV40.CFDLibV4.CFDException
// Assembly: CFDIV40.CFDLibV4, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CAF3DEF6-5DD4-4CB5-ADA2-9896E9851594
// Assembly location: C:\Users\Loera\Downloads\Facturacion4Old - copia.dll

using System;

namespace CFDIV40.CFDLibV4
{
  public class CFDException : Exception
  {
    public CFDException()
    {
    }

    public CFDException(string message)
      : base(message)
    {
    }

    public CFDException(string message, Exception innerException)
      : base(message, innerException)
    {
    }
  }
}
