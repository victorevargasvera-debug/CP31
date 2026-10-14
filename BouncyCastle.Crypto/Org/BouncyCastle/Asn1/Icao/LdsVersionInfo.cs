using System;

namespace Org.BouncyCastle.Asn1.Icao
{
	// Token: 0x020006F5 RID: 1781
	public class LdsVersionInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004084 RID: 16516 RVA: 0x00124968 File Offset: 0x00122B68
		public LdsVersionInfo(string ldsVersion, string unicodeVersion)
		{
			this.ldsVersion = new global::Org.BouncyCastle.Asn1.DerPrintableString(ldsVersion);
			this.unicodeVersion = new global::Org.BouncyCastle.Asn1.DerPrintableString(unicodeVersion);
		}

		// Token: 0x06004085 RID: 16517 RVA: 0x00124988 File Offset: 0x00122B88
		private LdsVersionInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("sequence wrong size for LDSVersionInfo", "seq");
			}
			this.ldsVersion = global::Org.BouncyCastle.Asn1.DerPrintableString.GetInstance(seq[0]);
			this.unicodeVersion = global::Org.BouncyCastle.Asn1.DerPrintableString.GetInstance(seq[1]);
		}

		// Token: 0x06004086 RID: 16518 RVA: 0x001249D8 File Offset: 0x00122BD8
		public static global::Org.BouncyCastle.Asn1.Icao.LdsVersionInfo GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Icao.LdsVersionInfo)
			{
				return (global::Org.BouncyCastle.Asn1.Icao.LdsVersionInfo)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.Icao.LdsVersionInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x06004087 RID: 16519 RVA: 0x001249F9 File Offset: 0x00122BF9
		public virtual string GetLdsVersion()
		{
			return this.ldsVersion.GetString();
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x00124A06 File Offset: 0x00122C06
		public virtual string GetUnicodeVersion()
		{
			return this.unicodeVersion.GetString();
		}

		// Token: 0x06004089 RID: 16521 RVA: 0x00124A13 File Offset: 0x00122C13
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.ldsVersion,
				this.unicodeVersion
			});
		}

		// Token: 0x04001E9C RID: 7836
		private global::Org.BouncyCastle.Asn1.DerPrintableString ldsVersion;

		// Token: 0x04001E9D RID: 7837
		private global::Org.BouncyCastle.Asn1.DerPrintableString unicodeVersion;
	}
}
