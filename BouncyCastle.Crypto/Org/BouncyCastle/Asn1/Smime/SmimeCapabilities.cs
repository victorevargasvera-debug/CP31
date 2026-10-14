using System;
using System.Collections;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Smime
{
	// Token: 0x0200069F RID: 1695
	public class SmimeCapabilities : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003E4D RID: 15949 RVA: 0x0011C4BC File Offset: 0x0011A6BC
		public static global::Org.BouncyCastle.Asn1.Smime.SmimeCapabilities GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Smime.SmimeCapabilities)
			{
				return (global::Org.BouncyCastle.Asn1.Smime.SmimeCapabilities)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Smime.SmimeCapabilities((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			if (obj is global::Org.BouncyCastle.Asn1.X509.AttributeX509)
			{
				return new global::Org.BouncyCastle.Asn1.Smime.SmimeCapabilities((global::Org.BouncyCastle.Asn1.Asn1Sequence)((global::Org.BouncyCastle.Asn1.X509.AttributeX509)obj).AttrValues[0]);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003E4E RID: 15950 RVA: 0x0011C52D File Offset: 0x0011A72D
		public SmimeCapabilities(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.capabilities = seq;
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x0011C53C File Offset: 0x0011A73C
		[global::System.Obsolete("Use 'GetCapabilitiesForOid' instead")]
		public global::System.Collections.ArrayList GetCapabilities(global::Org.BouncyCastle.Asn1.DerObjectIdentifier capability)
		{
			global::System.Collections.ArrayList list = new global::System.Collections.ArrayList();
			this.DoGetCapabilitiesForOid(capability, list);
			return list;
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x0011C558 File Offset: 0x0011A758
		public global::System.Collections.IList GetCapabilitiesForOid(global::Org.BouncyCastle.Asn1.DerObjectIdentifier capability)
		{
			global::System.Collections.IList list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			this.DoGetCapabilitiesForOid(capability, list);
			return list;
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x0011C574 File Offset: 0x0011A774
		private void DoGetCapabilitiesForOid(global::Org.BouncyCastle.Asn1.DerObjectIdentifier capability, global::System.Collections.IList list)
		{
			if (capability == null)
			{
				using (global::System.Collections.IEnumerator enumerator = this.capabilities.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						global::Org.BouncyCastle.Asn1.Smime.SmimeCapability cap = global::Org.BouncyCastle.Asn1.Smime.SmimeCapability.GetInstance(obj);
						list.Add(cap);
					}
					return;
				}
			}
			foreach (object obj2 in this.capabilities)
			{
				global::Org.BouncyCastle.Asn1.Smime.SmimeCapability cap2 = global::Org.BouncyCastle.Asn1.Smime.SmimeCapability.GetInstance(obj2);
				if (capability.Equals(cap2.CapabilityID))
				{
					list.Add(cap2);
				}
			}
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x0011C628 File Offset: 0x0011A828
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.capabilities;
		}

		// Token: 0x04001C12 RID: 7186
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PreferSignedData = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PreferSignedData;

		// Token: 0x04001C13 RID: 7187
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CannotDecryptAny = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.CannotDecryptAny;

		// Token: 0x04001C14 RID: 7188
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SmimeCapabilitesVersions = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.SmimeCapabilitiesVersions;

		// Token: 0x04001C15 RID: 7189
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Aes256Cbc = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Cbc;

		// Token: 0x04001C16 RID: 7190
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Aes192Cbc = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Cbc;

		// Token: 0x04001C17 RID: 7191
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Aes128Cbc = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Cbc;

		// Token: 0x04001C18 RID: 7192
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdeaCbc = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.4.1.188.7.1.1.2");

		// Token: 0x04001C19 RID: 7193
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Cast5Cbc = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113533.7.66.10");

		// Token: 0x04001C1A RID: 7194
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DesCbc = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.14.3.2.7");

		// Token: 0x04001C1B RID: 7195
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DesEde3Cbc = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DesEde3Cbc;

		// Token: 0x04001C1C RID: 7196
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier RC2Cbc = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RC2Cbc;

		// Token: 0x04001C1D RID: 7197
		private global::Org.BouncyCastle.Asn1.Asn1Sequence capabilities;
	}
}
