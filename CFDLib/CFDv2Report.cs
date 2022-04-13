// Decompiled with JetBrains decompiler
// Type: CFDIV40.CFDLibV4.CFDv2Report
// Assembly: CFDIV40.CFDLibV4, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CAF3DEF6-5DD4-4CB5-ADA2-9896E9851594
// Assembly location: C:\Users\Loera\Downloads\Facturacion4Old - copia.dll

using System;
using System.Collections.Generic;

namespace CFDIV40.CFDLibV4
{
  public class CFDv2Report
  {
    public CFDv2Report() => this.Items = (IList<CFDv2ReportItem>) new List<CFDv2ReportItem>();

    public string Taxpayer { get; set; }

    public DateTime Date { get; set; }

    public IList<CFDv2ReportItem> Items { get; private set; }

    public override string ToString() => string.Format("1{0}{1:MMyyyy}", (object) this.Taxpayer, (object) this.Date);
  }
}
