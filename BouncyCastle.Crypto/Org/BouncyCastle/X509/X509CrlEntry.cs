using System;
using System.Collections;
using System.Text;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Utilities;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509.Extension;

namespace Org.BouncyCastle.X509
{
	// Token: 0x02000018 RID: 24
	public class X509CrlEntry : global::Org.BouncyCastle.X509.X509ExtensionBase
	{
		// Token: 0x06000112 RID: 274 RVA: 0x000080D8 File Offset: 0x000062D8
		public X509CrlEntry(global::Org.BouncyCastle.Asn1.X509.CrlEntry c)
		{
			this.c = c;
			this.certificateIssuer = this.loadCertificateIssuer();
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000080F3 File Offset: 0x000062F3
		public X509CrlEntry(global::Org.BouncyCastle.Asn1.X509.CrlEntry c, bool isIndirect, global::Org.BouncyCastle.Asn1.X509.X509Name previousCertificateIssuer)
		{
			this.c = c;
			this.isIndirect = isIndirect;
			this.previousCertificateIssuer = previousCertificateIssuer;
			this.certificateIssuer = this.loadCertificateIssuer();
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000811C File Offset: 0x0000631C
		private global::Org.BouncyCastle.Asn1.X509.X509Name loadCertificateIssuer()
		{
			if (!this.isIndirect)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.Asn1OctetString ext = this.GetExtensionValue(global::Org.BouncyCastle.Asn1.X509.X509Extensions.CertificateIssuer);
			if (ext == null)
			{
				return this.previousCertificateIssuer;
			}
			try
			{
				global::Org.BouncyCastle.Asn1.X509.GeneralName[] names = global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.FromExtensionValue(ext)).GetNames();
				for (int i = 0; i < names.Length; i++)
				{
					if (names[i].TagNo == 4)
					{
						return global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(names[i].Name);
					}
				}
			}
			catch (global::System.Exception)
			{
			}
			return null;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000819C File Offset: 0x0000639C
		public global::Org.BouncyCastle.Asn1.X509.X509Name GetCertificateIssuer()
		{
			return this.certificateIssuer;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000081A4 File Offset: 0x000063A4
		protected override global::Org.BouncyCastle.Asn1.X509.X509Extensions GetX509Extensions()
		{
			return this.c.Extensions;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000081B4 File Offset: 0x000063B4
		public byte[] GetEncoded()
		{
			byte[] derEncoded;
			try
			{
				derEncoded = this.c.GetDerEncoded();
			}
			catch (global::System.Exception ex)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CrlException(ex.ToString());
			}
			return derEncoded;
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000118 RID: 280 RVA: 0x000081EC File Offset: 0x000063EC
		public global::Org.BouncyCastle.Math.BigInteger SerialNumber
		{
			get
			{
				return this.c.UserCertificate.Value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000119 RID: 281 RVA: 0x000081FE File Offset: 0x000063FE
		public global::System.DateTime RevocationDate
		{
			get
			{
				return this.c.RevocationDate.ToDateTime();
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00008210 File Offset: 0x00006410
		public bool HasExtensions
		{
			get
			{
				return this.c.Extensions != null;
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00008220 File Offset: 0x00006420
		public override bool Equals(object other)
		{
			if (this == other)
			{
				return true;
			}
			global::Org.BouncyCastle.X509.X509CrlEntry that = other as global::Org.BouncyCastle.X509.X509CrlEntry;
			return that != null && (!this.hashValueSet || !that.hashValueSet || this.hashValue == that.hashValue) && this.c.Equals(that.c);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00008278 File Offset: 0x00006478
		public override int GetHashCode()
		{
			if (!this.hashValueSet)
			{
				this.hashValue = this.c.GetHashCode();
				this.hashValueSet = true;
			}
			return this.hashValue;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000082A8 File Offset: 0x000064A8
		public override string ToString()
		{
			global::System.Text.StringBuilder buf = new global::System.Text.StringBuilder();
			string nl = global::Org.BouncyCastle.Utilities.Platform.NewLine;
			buf.Append("        userCertificate: ").Append(this.SerialNumber).Append(nl);
			buf.Append("         revocationDate: ").Append(this.RevocationDate).Append(nl);
			buf.Append("      certificateIssuer: ").Append(this.GetCertificateIssuer()).Append(nl);
			global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions = this.c.Extensions;
			if (extensions != null)
			{
				global::System.Collections.IEnumerator e = extensions.ExtensionOids.GetEnumerator();
				if (e.MoveNext())
				{
					buf.Append("   crlEntryExtensions:").Append(nl);
					for (;;)
					{
						global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)e.Current;
						global::Org.BouncyCastle.Asn1.X509.X509Extension ext = extensions.GetExtension(oid);
						if (ext.Value != null)
						{
							global::Org.BouncyCastle.Asn1.Asn1Object obj = global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.FromExtensionValue(ext.Value);
							buf.Append("                       critical(").Append(ext.IsCritical).Append(") ");
							try
							{
								if (oid.Equals(global::Org.BouncyCastle.Asn1.X509.X509Extensions.ReasonCode))
								{
									buf.Append(new global::Org.BouncyCastle.Asn1.X509.CrlReason(global::Org.BouncyCastle.Asn1.DerEnumerated.GetInstance(obj)));
								}
								else if (oid.Equals(global::Org.BouncyCastle.Asn1.X509.X509Extensions.CertificateIssuer))
								{
									buf.Append("Certificate issuer: ").Append(global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj));
								}
								else
								{
									buf.Append(oid.Id);
									buf.Append(" value = ").Append(global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.DumpAsString(obj));
								}
								buf.Append(nl);
								goto IL_1AB;
							}
							catch (global::System.Exception)
							{
								buf.Append(oid.Id);
								buf.Append(" value = ").Append("*****").Append(nl);
								goto IL_1AB;
							}
							goto IL_1A3;
						}
						goto IL_1A3;
						IL_1AB:
						if (!e.MoveNext())
						{
							break;
						}
						continue;
						IL_1A3:
						buf.Append(nl);
						goto IL_1AB;
					}
				}
			}
			return buf.ToString();
		}

		// Token: 0x04000096 RID: 150
		private global::Org.BouncyCastle.Asn1.X509.CrlEntry c;

		// Token: 0x04000097 RID: 151
		private bool isIndirect;

		// Token: 0x04000098 RID: 152
		private global::Org.BouncyCastle.Asn1.X509.X509Name previousCertificateIssuer;

		// Token: 0x04000099 RID: 153
		private global::Org.BouncyCastle.Asn1.X509.X509Name certificateIssuer;

		// Token: 0x0400009A RID: 154
		private volatile bool hashValueSet;

		// Token: 0x0400009B RID: 155
		private volatile int hashValue;
	}
}
