using System;
using System.Text;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000656 RID: 1622
	public class GeneralNames : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003C05 RID: 15365 RVA: 0x00113560 File Offset: 0x00111760
		private static global::Org.BouncyCastle.Asn1.X509.GeneralName[] Copy(global::Org.BouncyCastle.Asn1.X509.GeneralName[] names)
		{
			return (global::Org.BouncyCastle.Asn1.X509.GeneralName[])names.Clone();
		}

		// Token: 0x06003C06 RID: 15366 RVA: 0x0011356D File Offset: 0x0011176D
		public static global::Org.BouncyCastle.Asn1.X509.GeneralNames GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.GeneralNames)
			{
				return (global::Org.BouncyCastle.Asn1.X509.GeneralNames)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.X509.GeneralNames(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003C07 RID: 15367 RVA: 0x0011358E File Offset: 0x0011178E
		public static global::Org.BouncyCastle.Asn1.X509.GeneralNames GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003C08 RID: 15368 RVA: 0x0011359C File Offset: 0x0011179C
		public static global::Org.BouncyCastle.Asn1.X509.GeneralNames FromExtensions(global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions, global::Org.BouncyCastle.Asn1.DerObjectIdentifier extOid)
		{
			return global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetExtensionParsedValue(extensions, extOid));
		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x001135AA File Offset: 0x001117AA
		public GeneralNames(global::Org.BouncyCastle.Asn1.X509.GeneralName name)
		{
			this.names = new global::Org.BouncyCastle.Asn1.X509.GeneralName[]
			{
				name
			};
		}

		// Token: 0x06003C0A RID: 15370 RVA: 0x001135C2 File Offset: 0x001117C2
		public GeneralNames(global::Org.BouncyCastle.Asn1.X509.GeneralName[] names)
		{
			this.names = global::Org.BouncyCastle.Asn1.X509.GeneralNames.Copy(names);
		}

		// Token: 0x06003C0B RID: 15371 RVA: 0x001135D8 File Offset: 0x001117D8
		private GeneralNames(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.names = new global::Org.BouncyCastle.Asn1.X509.GeneralName[seq.Count];
			for (int i = 0; i != seq.Count; i++)
			{
				this.names[i] = global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(seq[i]);
			}
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x00113621 File Offset: 0x00111821
		public global::Org.BouncyCastle.Asn1.X509.GeneralName[] GetNames()
		{
			return global::Org.BouncyCastle.Asn1.X509.GeneralNames.Copy(this.names);
		}

		// Token: 0x06003C0D RID: 15373 RVA: 0x00113630 File Offset: 0x00111830
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements = this.names;
			return new global::Org.BouncyCastle.Asn1.DerSequence(elements);
		}

		// Token: 0x06003C0E RID: 15374 RVA: 0x0011364C File Offset: 0x0011184C
		public override string ToString()
		{
			global::System.Text.StringBuilder buf = new global::System.Text.StringBuilder();
			string sep = global::Org.BouncyCastle.Utilities.Platform.NewLine;
			buf.Append("GeneralNames:");
			buf.Append(sep);
			foreach (global::Org.BouncyCastle.Asn1.X509.GeneralName name in this.names)
			{
				buf.Append("    ");
				buf.Append(name);
				buf.Append(sep);
			}
			return buf.ToString();
		}

		// Token: 0x04001A6F RID: 6767
		private readonly global::Org.BouncyCastle.Asn1.X509.GeneralName[] names;
	}
}
