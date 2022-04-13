// Decompiled with JetBrains decompiler
// Type: CFDIV40..Utils
// Assembly: CFDIV40.CFDLibV4, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CAF3DEF6-5DD4-4CB5-ADA2-9896E9851594
// Assembly location: C:\Users\Loera\Downloads\Facturacion4Old - copia.dll

using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace CFDIV40.CFDLibV4
{
  public static class Utils
  {
    public static MemoryStream SerializeToXmlStream<T>(
      T obj,
      XmlSerializerNamespaces xmlns)
    {
      MemoryStream w = new MemoryStream(4096);
      new XmlSerializer(typeof (T)).Serialize((XmlWriter) new XmlTextWriter((Stream) w, (Encoding) new UTF8Encoding(false)), (object) obj, xmlns);
      w.Seek(0L, SeekOrigin.Begin);
      return w;
    }

    public static string SHA1WithRSA(string message, byte[] data, byte[] password)
    {
      AsymmetricKeyParameter asymmetricKeyParameter = PrivateKeyFactory.DecryptKey(Encoding.UTF8.GetString(password).ToCharArray(), data);
      ISigner signer = SignerUtilities.GetSigner(nameof (SHA1WithRSA));
      signer.Init(true, (ICipherParameters) asymmetricKeyParameter);
      data = Encoding.UTF8.GetBytes(message);
      signer.BlockUpdate(data, 0, data.Length);
      return Convert.ToBase64String(signer.GenerateSignature());
    }

    public static string SHA256withRSA(string message, byte[] data, byte[] password)
    {
      AsymmetricKeyParameter asymmetricKeyParameter = PrivateKeyFactory.DecryptKey(Encoding.UTF8.GetString(password).ToCharArray(), data);
      ISigner signer = SignerUtilities.GetSigner(nameof (SHA256withRSA));
      signer.Init(true, (ICipherParameters) asymmetricKeyParameter);
      data = Encoding.UTF8.GetBytes(message);
      signer.BlockUpdate(data, 0, data.Length);
      return Convert.ToBase64String(signer.GenerateSignature());
    }

    public static bool PrivateKeyTest(byte[] data, byte[] password)
    {
      try
      {
        return PrivateKeyFactory.DecryptKey(Encoding.UTF8.GetString(password).ToCharArray(), data).IsPrivate;
      }
      catch
      {
      }
      return false;
    }
  }
}
