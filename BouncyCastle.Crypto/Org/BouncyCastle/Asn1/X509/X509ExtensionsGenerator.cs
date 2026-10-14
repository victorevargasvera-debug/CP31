using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200067F RID: 1663
	public class X509ExtensionsGenerator
	{
		// Token: 0x06003D61 RID: 15713 RVA: 0x001176F4 File Offset: 0x001158F4
		static X509ExtensionsGenerator()
		{
			global::Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator.dupsAllowed.Add(global::Org.BouncyCastle.Asn1.X509.X509Extensions.SubjectAlternativeName, true);
			global::Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator.dupsAllowed.Add(global::Org.BouncyCastle.Asn1.X509.X509Extensions.IssuerAlternativeName, true);
			global::Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator.dupsAllowed.Add(global::Org.BouncyCastle.Asn1.X509.X509Extensions.SubjectDirectoryAttributes, true);
			global::Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator.dupsAllowed.Add(global::Org.BouncyCastle.Asn1.X509.X509Extensions.CertificateIssuer, true);
		}

		// Token: 0x06003D62 RID: 15714 RVA: 0x0011775F File Offset: 0x0011595F
		public void Reset()
		{
			this.extensions = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			this.extOrdering = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
		}

		// Token: 0x06003D63 RID: 15715 RVA: 0x00117778 File Offset: 0x00115978
		public void AddExtension(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, bool critical, global::Org.BouncyCastle.Asn1.Asn1Encodable extValue)
		{
			byte[] encoded;
			try
			{
				encoded = extValue.GetDerEncoded();
			}
			catch (global::System.Exception e)
			{
				string str = "error encoding value: ";
				global::System.Exception ex = e;
				throw new global::System.ArgumentException(str + ((ex != null) ? ex.ToString() : null));
			}
			this.AddExtension(oid, critical, encoded);
		}

		// Token: 0x06003D64 RID: 15716 RVA: 0x001177C8 File Offset: 0x001159C8
		public void AddExtension(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, bool critical, byte[] extValue)
		{
			if (!this.extensions.Contains(oid))
			{
				this.extOrdering.Add(oid);
				this.extensions.Add(oid, new global::Org.BouncyCastle.Asn1.X509.X509Extension(critical, new global::Org.BouncyCastle.Asn1.DerOctetString(extValue)));
				return;
			}
			if (global::Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator.dupsAllowed.Contains(oid))
			{
				global::Org.BouncyCastle.Asn1.X509.X509Extension existingExtension = (global::Org.BouncyCastle.Asn1.X509.X509Extension)this.extensions[oid];
				global::Org.BouncyCastle.Asn1.Asn1EncodableVector items = global::Org.BouncyCastle.Asn1.Asn1EncodableVector.FromEnumerable(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(existingExtension.Value).GetOctets()));
				foreach (object obj in global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(extValue))
				{
					global::Org.BouncyCastle.Asn1.Asn1Encodable enc = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj;
					items.Add(enc);
				}
				this.extensions[oid] = new global::Org.BouncyCastle.Asn1.X509.X509Extension(existingExtension.IsCritical, new global::Org.BouncyCastle.Asn1.DerOctetString(new global::Org.BouncyCastle.Asn1.DerSequence(items).GetEncoded()));
				return;
			}
			throw new global::System.ArgumentException("extension " + ((oid != null) ? oid.ToString() : null) + " already added");
		}

		// Token: 0x06003D65 RID: 15717 RVA: 0x001178E4 File Offset: 0x00115AE4
		public void AddExtensions(global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
		{
			foreach (object obj in extensions.ExtensionOids)
			{
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier ident = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)obj;
				global::Org.BouncyCastle.Asn1.X509.X509Extension ext = extensions.GetExtension(ident);
				this.AddExtension(ident, ext.critical, ext.Value.GetOctets());
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06003D66 RID: 15718 RVA: 0x00117958 File Offset: 0x00115B58
		public bool IsEmpty
		{
			get
			{
				return this.extOrdering.Count < 1;
			}
		}

		// Token: 0x06003D67 RID: 15719 RVA: 0x00117968 File Offset: 0x00115B68
		public global::Org.BouncyCastle.Asn1.X509.X509Extensions Generate()
		{
			return new global::Org.BouncyCastle.Asn1.X509.X509Extensions(this.extOrdering, this.extensions);
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x0011797C File Offset: 0x00115B7C
		internal void AddExtension(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, global::Org.BouncyCastle.Asn1.X509.X509Extension x509Extension)
		{
			if (this.extensions.Contains(oid))
			{
				throw new global::System.ArgumentException("extension " + ((oid != null) ? oid.ToString() : null) + " already added");
			}
			this.extOrdering.Add(oid);
			this.extensions.Add(oid, x509Extension);
		}

		// Token: 0x04001B34 RID: 6964
		private global::System.Collections.IDictionary extensions = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04001B35 RID: 6965
		private global::System.Collections.IList extOrdering = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x04001B36 RID: 6966
		private static readonly global::System.Collections.IDictionary dupsAllowed = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
