using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000654 RID: 1620
	public class ExtendedKeyUsage : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003BE9 RID: 15337 RVA: 0x00112D3C File Offset: 0x00110F3C
		public static global::Org.BouncyCastle.Asn1.X509.ExtendedKeyUsage GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.ExtendedKeyUsage.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003BEA RID: 15338 RVA: 0x00112D4A File Offset: 0x00110F4A
		public static global::Org.BouncyCastle.Asn1.X509.ExtendedKeyUsage GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.ExtendedKeyUsage)
			{
				return (global::Org.BouncyCastle.Asn1.X509.ExtendedKeyUsage)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.X509.X509Extension)
			{
				return global::Org.BouncyCastle.Asn1.X509.ExtendedKeyUsage.GetInstance(global::Org.BouncyCastle.Asn1.X509.X509Extension.ConvertValueToObject((global::Org.BouncyCastle.Asn1.X509.X509Extension)obj));
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.X509.ExtendedKeyUsage(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003BEB RID: 15339 RVA: 0x00112D84 File Offset: 0x00110F84
		public static global::Org.BouncyCastle.Asn1.X509.ExtendedKeyUsage FromExtensions(global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
		{
			return global::Org.BouncyCastle.Asn1.X509.ExtendedKeyUsage.GetInstance(global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetExtensionParsedValue(extensions, global::Org.BouncyCastle.Asn1.X509.X509Extensions.ExtendedKeyUsage));
		}

		// Token: 0x06003BEC RID: 15340 RVA: 0x00112D98 File Offset: 0x00110F98
		private ExtendedKeyUsage(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.seq = seq;
			foreach (object obj in seq)
			{
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj);
				this.usageTable[oid] = oid;
			}
		}

		// Token: 0x06003BED RID: 15341 RVA: 0x00112E10 File Offset: 0x00111010
		public ExtendedKeyUsage(params global::Org.BouncyCastle.Asn1.X509.KeyPurposeID[] usages)
		{
			this.seq = new global::Org.BouncyCastle.Asn1.DerSequence(usages);
			foreach (global::Org.BouncyCastle.Asn1.X509.KeyPurposeID usage in usages)
			{
				this.usageTable[usage] = usage;
			}
		}

		// Token: 0x06003BEE RID: 15342 RVA: 0x00112E5D File Offset: 0x0011105D
		[global::System.Obsolete]
		public ExtendedKeyUsage(global::System.Collections.ArrayList usages) : this(usages)
		{
		}

		// Token: 0x06003BEF RID: 15343 RVA: 0x00112E68 File Offset: 0x00111068
		public ExtendedKeyUsage(global::System.Collections.IEnumerable usages)
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			foreach (object obj in usages)
			{
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(obj);
				v.Add(oid);
				this.usageTable[oid] = oid;
			}
			this.seq = new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x06003BF0 RID: 15344 RVA: 0x00112EEC File Offset: 0x001110EC
		public bool HasKeyPurposeId(global::Org.BouncyCastle.Asn1.X509.KeyPurposeID keyPurposeId)
		{
			return this.usageTable.Contains(keyPurposeId);
		}

		// Token: 0x06003BF1 RID: 15345 RVA: 0x00112EFA File Offset: 0x001110FA
		[global::System.Obsolete("Use 'GetAllUsages'")]
		public global::System.Collections.ArrayList GetUsages()
		{
			return new global::System.Collections.ArrayList(this.usageTable.Values);
		}

		// Token: 0x06003BF2 RID: 15346 RVA: 0x00112F0C File Offset: 0x0011110C
		public global::System.Collections.IList GetAllUsages()
		{
			return global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(this.usageTable.Values);
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06003BF3 RID: 15347 RVA: 0x00112F1E File Offset: 0x0011111E
		public int Count
		{
			get
			{
				return this.usageTable.Count;
			}
		}

		// Token: 0x06003BF4 RID: 15348 RVA: 0x00112F2B File Offset: 0x0011112B
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.seq;
		}

		// Token: 0x04001A62 RID: 6754
		internal readonly global::System.Collections.IDictionary usageTable = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04001A63 RID: 6755
		internal readonly global::Org.BouncyCastle.Asn1.Asn1Sequence seq;
	}
}
