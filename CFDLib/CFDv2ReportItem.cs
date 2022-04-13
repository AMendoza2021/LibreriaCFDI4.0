// Decompiled with JetBrains decompiler
// Type: CFDIV40.CFDLibV4.CFDv2ReportItem
// Assembly: CFDIV40.CFDLibV4, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CAF3DEF6-5DD4-4CB5-ADA2-9896E9851594
// Assembly location: C:\Users\Loera\Downloads\Facturacion4Old - copia.dll

using System;

namespace CFDIV40.CFDLibV4
{
  public class CFDv2ReportItem : ICloneable
  {
    public string Taxpayer { get; set; }

    public string Batch { get; set; }

    public int Serial { get; set; }

    public int ApprovalYear { get; set; }

    public int ApprovalNumber { get; set; }

    public DateTime Date { get; set; }

    public Decimal Amount { get; set; }

    public Decimal Taxes { get; set; }

    public bool IsActive { get; set; }

    public CFDv2ReportItemType Type { get; set; }

    public string CustomsMotion { get; set; }

    public DateTime? CustomsMotionDate { get; set; }

    public string CustomsAgency { get; set; }

    public bool IsCancelled => !this.IsActive;

    public override string ToString()
    {
      string str = this.Type == CFDv2ReportItemType.Income ? "I" : (this.Type == CFDv2ReportItemType.Outcome ? "E" : "T");
      return string.Format("|{0}|{1}|{2}|{12:0000}{3}|{4:dd/MM/yyyy HH:mm:ss}|{5:0.00}|{6:0.00}|{7}|{8}|{9}|{10:dd/MM/yyyy}|{11}|", (object) this.Taxpayer, (object) this.Batch, (object) this.Serial, (object) this.ApprovalNumber, (object) this.Date, (object) this.Amount, (object) this.Taxes, (object) (this.IsActive ? 1 : 0), (object) str, (object) this.CustomsMotion, (object) this.CustomsMotionDate, (object) this.CustomsAgency, (object) this.ApprovalYear);
    }

    public object Clone() => this.MemberwiseClone();
  }
}
