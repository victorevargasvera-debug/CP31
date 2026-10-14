using System;
using System.Collections;
using System.IO;
using System.Text;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Utilities;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.X509.Extension;

namespace Org.BouncyCastle.X509
{
	// Token: 0x02000017 RID: 23
	public class X509Crl : global::Org.BouncyCastle.X509.X509ExtensionBase
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x00007735 File Offset: 0x00005935
		public X509Crl(byte[] encoding) : this(global::Org.BouncyCastle.Asn1.X509.CertificateList.GetInstance(encoding))
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00007744 File Offset: 0x00005944
		public X509Crl(global::Org.BouncyCastle.Asn1.X509.CertificateList c)
		{
			this.c = c;
			try
			{
				this.sigAlgName = global::Org.BouncyCastle.X509.X509SignatureUtilities.GetSignatureName(c.SignatureAlgorithm);
				global::Org.BouncyCastle.Asn1.Asn1Encodable parameters = c.SignatureAlgorithm.Parameters;
				this.sigAlgParams = ((parameters == null) ? null : parameters.GetEncoded("DER"));
				this.isIndirect = this.IsIndirectCrl;
			}
			catch (global::System.Exception e)
			{
				string str = "CRL contents invalid: ";
				global::System.Exception ex = e;
				throw new global::Org.BouncyCastle.Security.Certificates.CrlException(str + ((ex != null) ? ex.ToString() : null));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000077DC File Offset: 0x000059DC
		public virtual global::Org.BouncyCastle.Asn1.X509.CertificateList CertificateList
		{
			get
			{
				return this.c;
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000077E4 File Offset: 0x000059E4
		protected override global::Org.BouncyCastle.Asn1.X509.X509Extensions GetX509Extensions()
		{
			if (this.c.Version < 2)
			{
				return null;
			}
			return this.c.TbsCertList.Extensions;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00007806 File Offset: 0x00005A06
		public virtual void Verify(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
		{
			this.Verify(new global::Org.BouncyCastle.Crypto.Operators.Asn1VerifierFactoryProvider(publicKey));
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00007814 File Offset: 0x00005A14
		public virtual void Verify(global::Org.BouncyCastle.Crypto.IVerifierFactoryProvider verifierProvider)
		{
			this.CheckSignature(verifierProvider.CreateVerifierFactory(this.c.SignatureAlgorithm));
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00007830 File Offset: 0x00005A30
		protected virtual void CheckSignature(global::Org.BouncyCastle.Crypto.IVerifierFactory verifier)
		{
			if (!this.c.SignatureAlgorithm.Equals(this.c.TbsCertList.Signature))
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CrlException("Signature algorithm on CertificateList does not match TbsCertList.");
			}
			global::Org.BouncyCastle.Asn1.Asn1Encodable parameters = this.c.SignatureAlgorithm.Parameters;
			global::Org.BouncyCastle.Crypto.IStreamCalculator streamCalculator = verifier.CreateCalculator();
			byte[] b = this.GetTbsCertList();
			streamCalculator.Stream.Write(b, 0, b.Length);
			global::Org.BouncyCastle.Utilities.Platform.Dispose(streamCalculator.Stream);
			if (!((global::Org.BouncyCastle.Crypto.IVerifier)streamCalculator.GetResult()).IsVerified(this.GetSignature()))
			{
				throw new global::Org.BouncyCastle.Security.InvalidKeyException("CRL does not verify with supplied public key.");
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000FF RID: 255 RVA: 0x000078C5 File Offset: 0x00005AC5
		public virtual int Version
		{
			get
			{
				return this.c.Version;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000100 RID: 256 RVA: 0x000078D2 File Offset: 0x00005AD2
		public virtual global::Org.BouncyCastle.Asn1.X509.X509Name IssuerDN
		{
			get
			{
				return this.c.Issuer;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000101 RID: 257 RVA: 0x000078DF File Offset: 0x00005ADF
		public virtual global::System.DateTime ThisUpdate
		{
			get
			{
				return this.c.ThisUpdate.ToDateTime();
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000102 RID: 258 RVA: 0x000078F1 File Offset: 0x00005AF1
		public virtual global::Org.BouncyCastle.Utilities.Date.DateTimeObject NextUpdate
		{
			get
			{
				if (this.c.NextUpdate != null)
				{
					return new global::Org.BouncyCastle.Utilities.Date.DateTimeObject(this.c.NextUpdate.ToDateTime());
				}
				return null;
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00007918 File Offset: 0x00005B18
		private global::Org.BouncyCastle.Utilities.Collections.ISet LoadCrlEntries()
		{
			global::Org.BouncyCastle.Utilities.Collections.ISet entrySet = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			global::System.Collections.IEnumerable revokedCertificateEnumeration = this.c.GetRevokedCertificateEnumeration();
			global::Org.BouncyCastle.Asn1.X509.X509Name previousCertificateIssuer = this.IssuerDN;
			foreach (object obj in revokedCertificateEnumeration)
			{
				global::Org.BouncyCastle.X509.X509CrlEntry crlEntry = new global::Org.BouncyCastle.X509.X509CrlEntry((global::Org.BouncyCastle.Asn1.X509.CrlEntry)obj, this.isIndirect, previousCertificateIssuer);
				entrySet.Add(crlEntry);
				previousCertificateIssuer = crlEntry.GetCertificateIssuer();
			}
			return entrySet;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000799C File Offset: 0x00005B9C
		public virtual global::Org.BouncyCastle.X509.X509CrlEntry GetRevokedCertificate(global::Org.BouncyCastle.Math.BigInteger serialNumber)
		{
			global::System.Collections.IEnumerable revokedCertificateEnumeration = this.c.GetRevokedCertificateEnumeration();
			global::Org.BouncyCastle.Asn1.X509.X509Name previousCertificateIssuer = this.IssuerDN;
			foreach (object obj in revokedCertificateEnumeration)
			{
				global::Org.BouncyCastle.Asn1.X509.CrlEntry entry = (global::Org.BouncyCastle.Asn1.X509.CrlEntry)obj;
				global::Org.BouncyCastle.X509.X509CrlEntry crlEntry = new global::Org.BouncyCastle.X509.X509CrlEntry(entry, this.isIndirect, previousCertificateIssuer);
				if (serialNumber.Equals(entry.UserCertificate.Value))
				{
					return crlEntry;
				}
				previousCertificateIssuer = crlEntry.GetCertificateIssuer();
			}
			return null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00007A30 File Offset: 0x00005C30
		public virtual global::Org.BouncyCastle.Utilities.Collections.ISet GetRevokedCertificates()
		{
			global::Org.BouncyCastle.Utilities.Collections.ISet entrySet = this.LoadCrlEntries();
			if (entrySet.Count > 0)
			{
				return entrySet;
			}
			return null;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00007A50 File Offset: 0x00005C50
		public virtual byte[] GetTbsCertList()
		{
			byte[] derEncoded;
			try
			{
				derEncoded = this.c.TbsCertList.GetDerEncoded();
			}
			catch (global::System.Exception ex)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CrlException(ex.ToString());
			}
			return derEncoded;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00007A8C File Offset: 0x00005C8C
		public virtual byte[] GetSignature()
		{
			return this.c.GetSignatureOctets();
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00007A99 File Offset: 0x00005C99
		public virtual string SigAlgName
		{
			get
			{
				return this.sigAlgName;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00007AA1 File Offset: 0x00005CA1
		public virtual string SigAlgOid
		{
			get
			{
				return this.c.SignatureAlgorithm.Algorithm.Id;
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00007AB8 File Offset: 0x00005CB8
		public virtual byte[] GetSigAlgParams()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.sigAlgParams);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00007AC5 File Offset: 0x00005CC5
		public virtual byte[] GetEncoded()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.GetCachedEncoding().GetEncoded());
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00007AD8 File Offset: 0x00005CD8
		public override bool Equals(object other)
		{
			if (this == other)
			{
				return true;
			}
			global::Org.BouncyCastle.X509.X509Crl that = other as global::Org.BouncyCastle.X509.X509Crl;
			if (that == null)
			{
				return false;
			}
			if (this.hashValueSet && that.hashValueSet)
			{
				if (this.hashValue != that.hashValue)
				{
					return false;
				}
			}
			else if (this.cachedEncoding == null || that.cachedEncoding == null)
			{
				global::Org.BouncyCastle.Asn1.DerBitString signature = this.c.Signature;
				if (signature != null && !signature.Equals(that.c.Signature))
				{
					return false;
				}
			}
			byte[] thisEncoding = this.GetCachedEncoding().Encoding;
			byte[] thatEncoding = that.GetCachedEncoding().Encoding;
			return thisEncoding != null && thatEncoding != null && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(thisEncoding, thatEncoding);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00007B7C File Offset: 0x00005D7C
		public override int GetHashCode()
		{
			if (!this.hashValueSet)
			{
				byte[] thisEncoding = this.GetCachedEncoding().Encoding;
				this.hashValue = global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(thisEncoding);
				this.hashValueSet = true;
			}
			return this.hashValue;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00007BC0 File Offset: 0x00005DC0
		public override string ToString()
		{
			global::System.Text.StringBuilder buf = new global::System.Text.StringBuilder();
			string nl = global::Org.BouncyCastle.Utilities.Platform.NewLine;
			buf.Append("              Version: ").Append(this.Version).Append(nl);
			buf.Append("             IssuerDN: ").Append(this.IssuerDN).Append(nl);
			buf.Append("          This update: ").Append(this.ThisUpdate).Append(nl);
			buf.Append("          Next update: ").Append(this.NextUpdate).Append(nl);
			buf.Append("  Signature Algorithm: ").Append(this.SigAlgName).Append(nl);
			byte[] sig = this.GetSignature();
			buf.Append("            Signature: ");
			buf.Append(global::Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(sig, 0, 20)).Append(nl);
			for (int i = 20; i < sig.Length; i += 20)
			{
				int count = global::System.Math.Min(20, sig.Length - i);
				buf.Append("                       ");
				buf.Append(global::Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(sig, i, count)).Append(nl);
			}
			global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions = this.c.TbsCertList.Extensions;
			if (extensions != null)
			{
				global::System.Collections.IEnumerator e = extensions.ExtensionOids.GetEnumerator();
				if (e.MoveNext())
				{
					buf.Append("           Extensions: ").Append(nl);
				}
				for (;;)
				{
					global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)e.Current;
					global::Org.BouncyCastle.Asn1.X509.X509Extension ext = extensions.GetExtension(oid);
					if (ext.Value != null)
					{
						global::Org.BouncyCastle.Asn1.Asn1Object asn1Value = global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.FromExtensionValue(ext.Value);
						buf.Append("                       critical(").Append(ext.IsCritical).Append(") ");
						try
						{
							if (oid.Equals(global::Org.BouncyCastle.Asn1.X509.X509Extensions.CrlNumber))
							{
								buf.Append(new global::Org.BouncyCastle.Asn1.X509.CrlNumber(global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(asn1Value).PositiveValue)).Append(nl);
							}
							else if (oid.Equals(global::Org.BouncyCastle.Asn1.X509.X509Extensions.DeltaCrlIndicator))
							{
								global::System.Text.StringBuilder stringBuilder = buf;
								string str = "Base CRL: ";
								global::Org.BouncyCastle.Asn1.X509.CrlNumber crlNumber = new global::Org.BouncyCastle.Asn1.X509.CrlNumber(global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(asn1Value).PositiveValue);
								stringBuilder.Append(str + ((crlNumber != null) ? crlNumber.ToString() : null)).Append(nl);
							}
							else if (oid.Equals(global::Org.BouncyCastle.Asn1.X509.X509Extensions.IssuingDistributionPoint))
							{
								buf.Append(global::Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint.GetInstance((global::Org.BouncyCastle.Asn1.Asn1Sequence)asn1Value)).Append(nl);
							}
							else if (oid.Equals(global::Org.BouncyCastle.Asn1.X509.X509Extensions.CrlDistributionPoints))
							{
								buf.Append(global::Org.BouncyCastle.Asn1.X509.CrlDistPoint.GetInstance((global::Org.BouncyCastle.Asn1.Asn1Sequence)asn1Value)).Append(nl);
							}
							else if (oid.Equals(global::Org.BouncyCastle.Asn1.X509.X509Extensions.FreshestCrl))
							{
								buf.Append(global::Org.BouncyCastle.Asn1.X509.CrlDistPoint.GetInstance((global::Org.BouncyCastle.Asn1.Asn1Sequence)asn1Value)).Append(nl);
							}
							else
							{
								buf.Append(oid.Id);
								buf.Append(" value = ").Append(global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.DumpAsString(asn1Value)).Append(nl);
							}
							goto IL_2FA;
						}
						catch (global::System.Exception)
						{
							buf.Append(oid.Id);
							buf.Append(" value = ").Append("*****").Append(nl);
							goto IL_2FA;
						}
						goto IL_2F2;
					}
					goto IL_2F2;
					IL_2FA:
					if (!e.MoveNext())
					{
						break;
					}
					continue;
					IL_2F2:
					buf.Append(nl);
					goto IL_2FA;
				}
			}
			global::Org.BouncyCastle.Utilities.Collections.ISet certSet = this.GetRevokedCertificates();
			if (certSet != null)
			{
				foreach (object obj in certSet)
				{
					global::Org.BouncyCastle.X509.X509CrlEntry entry = (global::Org.BouncyCastle.X509.X509CrlEntry)obj;
					buf.Append(entry);
					buf.Append(nl);
				}
			}
			return buf.ToString();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00007F64 File Offset: 0x00006164
		public virtual bool IsRevoked(global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			global::Org.BouncyCastle.Asn1.X509.CrlEntry[] certs = this.c.GetRevokedCertificates();
			if (certs != null)
			{
				global::Org.BouncyCastle.Math.BigInteger serial = cert.SerialNumber;
				for (int i = 0; i < certs.Length; i++)
				{
					if (certs[i].UserCertificate.HasValue(serial))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00007FA8 File Offset: 0x000061A8
		protected virtual bool IsIndirectCrl
		{
			get
			{
				global::Org.BouncyCastle.Asn1.Asn1OctetString idp = this.GetExtensionValue(global::Org.BouncyCastle.Asn1.X509.X509Extensions.IssuingDistributionPoint);
				bool isIndirect = false;
				try
				{
					if (idp != null)
					{
						isIndirect = global::Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint.GetInstance(global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.FromExtensionValue(idp)).IsIndirectCrl;
					}
				}
				catch (global::System.Exception e)
				{
					string str = "Exception reading IssuingDistributionPoint";
					global::System.Exception ex = e;
					throw new global::Org.BouncyCastle.Security.Certificates.CrlException(str + ((ex != null) ? ex.ToString() : null));
				}
				return isIndirect;
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00008008 File Offset: 0x00006208
		private global::Org.BouncyCastle.X509.X509Crl.CachedEncoding GetCachedEncoding()
		{
			object obj = this.cacheLock;
			lock (obj)
			{
				if (this.cachedEncoding != null)
				{
					return this.cachedEncoding;
				}
			}
			byte[] encoding = null;
			global::Org.BouncyCastle.Security.Certificates.CrlException exception = null;
			try
			{
				encoding = this.c.GetEncoded("DER");
			}
			catch (global::System.IO.IOException e)
			{
				exception = new global::Org.BouncyCastle.Security.Certificates.CrlException("Failed to DER-encode CRL", e);
			}
			global::Org.BouncyCastle.X509.X509Crl.CachedEncoding temp = new global::Org.BouncyCastle.X509.X509Crl.CachedEncoding(encoding, exception);
			obj = this.cacheLock;
			global::Org.BouncyCastle.X509.X509Crl.CachedEncoding result;
			lock (obj)
			{
				if (this.cachedEncoding == null)
				{
					this.cachedEncoding = temp;
				}
				result = this.cachedEncoding;
			}
			return result;
		}

		// Token: 0x0400008E RID: 142
		private readonly global::Org.BouncyCastle.Asn1.X509.CertificateList c;

		// Token: 0x0400008F RID: 143
		private readonly string sigAlgName;

		// Token: 0x04000090 RID: 144
		private readonly byte[] sigAlgParams;

		// Token: 0x04000091 RID: 145
		private readonly bool isIndirect;

		// Token: 0x04000092 RID: 146
		private readonly object cacheLock = new object();

		// Token: 0x04000093 RID: 147
		private global::Org.BouncyCastle.X509.X509Crl.CachedEncoding cachedEncoding;

		// Token: 0x04000094 RID: 148
		private volatile bool hashValueSet;

		// Token: 0x04000095 RID: 149
		private volatile int hashValue;

		// Token: 0x0200079A RID: 1946
		private class CachedEncoding
		{
			// Token: 0x060044F3 RID: 17651 RVA: 0x0013247F File Offset: 0x0013067F
			internal CachedEncoding(byte[] encoding, global::Org.BouncyCastle.Security.Certificates.CrlException exception)
			{
				this.encoding = encoding;
				this.exception = exception;
			}

			// Token: 0x17000A69 RID: 2665
			// (get) Token: 0x060044F4 RID: 17652 RVA: 0x00132495 File Offset: 0x00130695
			internal byte[] Encoding
			{
				get
				{
					return this.encoding;
				}
			}

			// Token: 0x060044F5 RID: 17653 RVA: 0x0013249D File Offset: 0x0013069D
			internal byte[] GetEncoded()
			{
				if (this.exception != null)
				{
					throw this.exception;
				}
				if (this.encoding == null)
				{
					throw new global::Org.BouncyCastle.Security.Certificates.CrlException();
				}
				return this.encoding;
			}

			// Token: 0x040022DE RID: 8926
			private readonly byte[] encoding;

			// Token: 0x040022DF RID: 8927
			private readonly global::Org.BouncyCastle.Security.Certificates.CrlException exception;
		}
	}
}
