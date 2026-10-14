using System;
using System.Collections;
using System.IO;
using System.Text;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Misc;
using Org.BouncyCastle.Asn1.Utilities;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.X509.Extension;

namespace Org.BouncyCastle.X509
{
	// Token: 0x02000013 RID: 19
	public class X509Certificate : global::Org.BouncyCastle.X509.X509ExtensionBase
	{
		// Token: 0x060000BB RID: 187 RVA: 0x0000668E File Offset: 0x0000488E
		protected X509Certificate()
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000066A1 File Offset: 0x000048A1
		public X509Certificate(byte[] certData) : this(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(certData))
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000066B0 File Offset: 0x000048B0
		public X509Certificate(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure c)
		{
			this.c = c;
			try
			{
				this.sigAlgName = global::Org.BouncyCastle.X509.X509SignatureUtilities.GetSignatureName(c.SignatureAlgorithm);
				global::Org.BouncyCastle.Asn1.Asn1Encodable parameters = c.SignatureAlgorithm.Parameters;
				this.sigAlgParams = ((parameters == null) ? null : parameters.GetEncoded("DER"));
			}
			catch (global::System.Exception e)
			{
				string str3 = "Certificate contents invalid: ";
				global::System.Exception ex = e;
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateParsingException(str3 + ((ex != null) ? ex.ToString() : null));
			}
			try
			{
				global::Org.BouncyCastle.Asn1.Asn1OctetString str = this.GetExtensionValue(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.19"));
				if (str != null)
				{
					this.basicConstraints = global::Org.BouncyCastle.Asn1.X509.BasicConstraints.GetInstance(global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.FromExtensionValue(str));
				}
			}
			catch (global::System.Exception e2)
			{
				string str4 = "cannot construct BasicConstraints: ";
				global::System.Exception ex2 = e2;
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateParsingException(str4 + ((ex2 != null) ? ex2.ToString() : null));
			}
			try
			{
				global::Org.BouncyCastle.Asn1.Asn1OctetString str2 = this.GetExtensionValue(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.15"));
				if (str2 != null)
				{
					global::Org.BouncyCastle.Asn1.DerBitString bits = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.FromExtensionValue(str2));
					byte[] bytes = bits.GetBytes();
					int length = bytes.Length * 8 - bits.PadBits;
					this.keyUsage = new bool[(length < 9) ? 9 : length];
					for (int i = 0; i != length; i++)
					{
						this.keyUsage[i] = (((int)bytes[i / 8] & 128 >> i % 8) != 0);
					}
				}
				else
				{
					this.keyUsage = null;
				}
			}
			catch (global::System.Exception e3)
			{
				string str5 = "cannot construct KeyUsage: ";
				global::System.Exception ex3 = e3;
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateParsingException(str5 + ((ex3 != null) ? ex3.ToString() : null));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000684C File Offset: 0x00004A4C
		public virtual global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure CertificateStructure
		{
			get
			{
				return this.c;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00006854 File Offset: 0x00004A54
		public virtual bool IsValidNow
		{
			get
			{
				return this.IsValid(global::System.DateTime.UtcNow);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00006861 File Offset: 0x00004A61
		public virtual bool IsValid(global::System.DateTime time)
		{
			return time.CompareTo(this.NotBefore) >= 0 && time.CompareTo(this.NotAfter) <= 0;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00006888 File Offset: 0x00004A88
		public virtual void CheckValidity()
		{
			this.CheckValidity(global::System.DateTime.UtcNow);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00006898 File Offset: 0x00004A98
		public virtual void CheckValidity(global::System.DateTime time)
		{
			if (time.CompareTo(this.NotAfter) > 0)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateExpiredException("certificate expired on " + this.c.EndDate.GetTime());
			}
			if (time.CompareTo(this.NotBefore) < 0)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateNotYetValidException("certificate not valid until " + this.c.StartDate.GetTime());
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00006905 File Offset: 0x00004B05
		public virtual int Version
		{
			get
			{
				return this.c.Version;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00006912 File Offset: 0x00004B12
		public virtual global::Org.BouncyCastle.Math.BigInteger SerialNumber
		{
			get
			{
				return this.c.SerialNumber.Value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00006924 File Offset: 0x00004B24
		public virtual global::Org.BouncyCastle.Asn1.X509.X509Name IssuerDN
		{
			get
			{
				return this.c.Issuer;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00006931 File Offset: 0x00004B31
		public virtual global::Org.BouncyCastle.Asn1.X509.X509Name SubjectDN
		{
			get
			{
				return this.c.Subject;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000693E File Offset: 0x00004B3E
		public virtual global::System.DateTime NotBefore
		{
			get
			{
				return this.c.StartDate.ToDateTime();
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00006950 File Offset: 0x00004B50
		public virtual global::System.DateTime NotAfter
		{
			get
			{
				return this.c.EndDate.ToDateTime();
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00006962 File Offset: 0x00004B62
		public virtual byte[] GetTbsCertificate()
		{
			return this.c.TbsCertificate.GetDerEncoded();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00006974 File Offset: 0x00004B74
		public virtual byte[] GetSignature()
		{
			return this.c.GetSignatureOctets();
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00006981 File Offset: 0x00004B81
		public virtual string SigAlgName
		{
			get
			{
				return this.sigAlgName;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00006989 File Offset: 0x00004B89
		public virtual string SigAlgOid
		{
			get
			{
				return this.c.SignatureAlgorithm.Algorithm.Id;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000069A0 File Offset: 0x00004BA0
		public virtual byte[] GetSigAlgParams()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.sigAlgParams);
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000069AD File Offset: 0x00004BAD
		public virtual global::Org.BouncyCastle.Asn1.DerBitString IssuerUniqueID
		{
			get
			{
				return this.c.TbsCertificate.IssuerUniqueID;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000CF RID: 207 RVA: 0x000069BF File Offset: 0x00004BBF
		public virtual global::Org.BouncyCastle.Asn1.DerBitString SubjectUniqueID
		{
			get
			{
				return this.c.TbsCertificate.SubjectUniqueID;
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000069D1 File Offset: 0x00004BD1
		public virtual bool[] GetKeyUsage()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.keyUsage);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000069E0 File Offset: 0x00004BE0
		public virtual global::System.Collections.IList GetExtendedKeyUsage()
		{
			global::Org.BouncyCastle.Asn1.Asn1OctetString str = this.GetExtensionValue(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.37"));
			if (str == null)
			{
				return null;
			}
			global::System.Collections.IList result;
			try
			{
				global::Org.BouncyCastle.Asn1.Asn1Sequence instance = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.FromExtensionValue(str));
				global::System.Collections.IList list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				foreach (object obj in instance)
				{
					global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)obj;
					list.Add(oid.Id);
				}
				result = list;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateParsingException("error processing extended key usage extension", e);
			}
			return result;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00006A88 File Offset: 0x00004C88
		public virtual int GetBasicConstraints()
		{
			if (this.basicConstraints == null || !this.basicConstraints.IsCA())
			{
				return -1;
			}
			if (this.basicConstraints.PathLenConstraint == null)
			{
				return int.MaxValue;
			}
			return this.basicConstraints.PathLenConstraint.IntValue;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00006AC4 File Offset: 0x00004CC4
		public virtual global::System.Collections.ICollection GetSubjectAlternativeNames()
		{
			return this.GetAlternativeNames("2.5.29.17");
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00006AD1 File Offset: 0x00004CD1
		public virtual global::System.Collections.ICollection GetIssuerAlternativeNames()
		{
			return this.GetAlternativeNames("2.5.29.18");
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00006AE0 File Offset: 0x00004CE0
		protected virtual global::System.Collections.ICollection GetAlternativeNames(string oid)
		{
			global::Org.BouncyCastle.Asn1.Asn1OctetString altNames = this.GetExtensionValue(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(oid));
			if (altNames == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.X509.GeneralNames instance = global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.FromExtensionValue(altNames));
			global::System.Collections.IList result = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			foreach (global::Org.BouncyCastle.Asn1.X509.GeneralName gn in instance.GetNames())
			{
				global::System.Collections.IList entry = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				entry.Add(gn.TagNo);
				entry.Add(gn.Name.ToString());
				result.Add(entry);
			}
			return result;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00006B62 File Offset: 0x00004D62
		protected override global::Org.BouncyCastle.Asn1.X509.X509Extensions GetX509Extensions()
		{
			if (this.c.Version < 3)
			{
				return null;
			}
			return this.c.TbsCertificate.Extensions;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00006B84 File Offset: 0x00004D84
		public virtual global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter GetPublicKey()
		{
			object obj = this.cacheLock;
			lock (obj)
			{
				if (this.publicKeyValue != null)
				{
					return this.publicKeyValue;
				}
			}
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter temp = global::Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(this.c.SubjectPublicKeyInfo);
			obj = this.cacheLock;
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter result;
			lock (obj)
			{
				if (this.publicKeyValue == null)
				{
					this.publicKeyValue = temp;
				}
				result = this.publicKeyValue;
			}
			return result;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00006C20 File Offset: 0x00004E20
		public virtual byte[] GetEncoded()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.GetCachedEncoding().GetEncoded());
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00006C34 File Offset: 0x00004E34
		public override bool Equals(object other)
		{
			if (this == other)
			{
				return true;
			}
			global::Org.BouncyCastle.X509.X509Certificate that = other as global::Org.BouncyCastle.X509.X509Certificate;
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

		// Token: 0x060000DA RID: 218 RVA: 0x00006CD8 File Offset: 0x00004ED8
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

		// Token: 0x060000DB RID: 219 RVA: 0x00006D1C File Offset: 0x00004F1C
		public override string ToString()
		{
			global::System.Text.StringBuilder buf = new global::System.Text.StringBuilder();
			string nl = global::Org.BouncyCastle.Utilities.Platform.NewLine;
			buf.Append("  [0]         Version: ").Append(this.Version).Append(nl);
			buf.Append("         SerialNumber: ").Append(this.SerialNumber).Append(nl);
			buf.Append("             IssuerDN: ").Append(this.IssuerDN).Append(nl);
			buf.Append("           Start Date: ").Append(this.NotBefore).Append(nl);
			buf.Append("           Final Date: ").Append(this.NotAfter).Append(nl);
			buf.Append("            SubjectDN: ").Append(this.SubjectDN).Append(nl);
			buf.Append("           Public Key: ").Append(this.GetPublicKey()).Append(nl);
			buf.Append("  Signature Algorithm: ").Append(this.SigAlgName).Append(nl);
			byte[] sig = this.GetSignature();
			buf.Append("            Signature: ").Append(global::Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(sig, 0, 20)).Append(nl);
			for (int i = 20; i < sig.Length; i += 20)
			{
				int len = global::System.Math.Min(20, sig.Length - i);
				buf.Append("                       ").Append(global::Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(sig, i, len)).Append(nl);
			}
			global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions = this.c.TbsCertificate.Extensions;
			if (extensions != null)
			{
				global::System.Collections.IEnumerator e = extensions.ExtensionOids.GetEnumerator();
				if (e.MoveNext())
				{
					buf.Append("       Extensions: \n");
				}
				do
				{
					global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)e.Current;
					global::Org.BouncyCastle.Asn1.X509.X509Extension ext = extensions.GetExtension(oid);
					if (ext.Value != null)
					{
						global::Org.BouncyCastle.Asn1.Asn1Object obj = global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.FromExtensionValue(ext.Value);
						buf.Append("                       critical(").Append(ext.IsCritical).Append(") ");
						try
						{
							if (oid.Equals(global::Org.BouncyCastle.Asn1.X509.X509Extensions.BasicConstraints))
							{
								buf.Append(global::Org.BouncyCastle.Asn1.X509.BasicConstraints.GetInstance(obj));
							}
							else if (oid.Equals(global::Org.BouncyCastle.Asn1.X509.X509Extensions.KeyUsage))
							{
								buf.Append(global::Org.BouncyCastle.Asn1.X509.KeyUsage.GetInstance(obj));
							}
							else if (oid.Equals(global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.NetscapeCertType))
							{
								buf.Append(new global::Org.BouncyCastle.Asn1.Misc.NetscapeCertType((global::Org.BouncyCastle.Asn1.DerBitString)obj));
							}
							else if (oid.Equals(global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.NetscapeRevocationUrl))
							{
								buf.Append(new global::Org.BouncyCastle.Asn1.Misc.NetscapeRevocationUrl((global::Org.BouncyCastle.Asn1.DerIA5String)obj));
							}
							else if (oid.Equals(global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.VerisignCzagExtension))
							{
								buf.Append(new global::Org.BouncyCastle.Asn1.Misc.VerisignCzagExtension((global::Org.BouncyCastle.Asn1.DerIA5String)obj));
							}
							else
							{
								buf.Append(oid.Id);
								buf.Append(" value = ").Append(global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.DumpAsString(obj));
							}
						}
						catch (global::System.Exception)
						{
							buf.Append(oid.Id);
							buf.Append(" value = ").Append("*****");
						}
					}
					buf.Append(nl);
				}
				while (e.MoveNext());
			}
			return buf.ToString();
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00007044 File Offset: 0x00005244
		public virtual void Verify(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key)
		{
			this.CheckSignature(new global::Org.BouncyCastle.Crypto.Operators.Asn1VerifierFactory(this.c.SignatureAlgorithm, key));
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000705D File Offset: 0x0000525D
		public virtual void Verify(global::Org.BouncyCastle.Crypto.IVerifierFactoryProvider verifierProvider)
		{
			this.CheckSignature(verifierProvider.CreateVerifierFactory(this.c.SignatureAlgorithm));
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00007078 File Offset: 0x00005278
		protected virtual void CheckSignature(global::Org.BouncyCastle.Crypto.IVerifierFactory verifier)
		{
			if (!global::Org.BouncyCastle.X509.X509Certificate.IsAlgIDEqual(this.c.SignatureAlgorithm, this.c.TbsCertificate.Signature))
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateException("signature algorithm in TBS cert not same as outer cert");
			}
			global::Org.BouncyCastle.Asn1.Asn1Encodable parameters = this.c.SignatureAlgorithm.Parameters;
			global::Org.BouncyCastle.Crypto.IStreamCalculator streamCalculator = verifier.CreateCalculator();
			byte[] b = this.GetTbsCertificate();
			streamCalculator.Stream.Write(b, 0, b.Length);
			global::Org.BouncyCastle.Utilities.Platform.Dispose(streamCalculator.Stream);
			if (!((global::Org.BouncyCastle.Crypto.IVerifier)streamCalculator.GetResult()).IsVerified(this.GetSignature()))
			{
				throw new global::Org.BouncyCastle.Security.InvalidKeyException("Public key presented not for certificate signature");
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00007110 File Offset: 0x00005310
		private global::Org.BouncyCastle.X509.X509Certificate.CachedEncoding GetCachedEncoding()
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
			global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException exception = null;
			try
			{
				encoding = this.c.GetEncoded("DER");
			}
			catch (global::System.IO.IOException e)
			{
				exception = new global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException("Failed to DER-encode certificate", e);
			}
			global::Org.BouncyCastle.X509.X509Certificate.CachedEncoding temp = new global::Org.BouncyCastle.X509.X509Certificate.CachedEncoding(encoding, exception);
			obj = this.cacheLock;
			global::Org.BouncyCastle.X509.X509Certificate.CachedEncoding result;
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

		// Token: 0x060000E0 RID: 224 RVA: 0x000071E0 File Offset: 0x000053E0
		private static bool IsAlgIDEqual(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier id1, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier id2)
		{
			if (!id1.Algorithm.Equals(id2.Algorithm))
			{
				return false;
			}
			global::Org.BouncyCastle.Asn1.Asn1Encodable p = id1.Parameters;
			global::Org.BouncyCastle.Asn1.Asn1Encodable p2 = id2.Parameters;
			if (p == null == (p2 == null))
			{
				return object.Equals(p, p2);
			}
			if (p != null)
			{
				return p.ToAsn1Object() is global::Org.BouncyCastle.Asn1.Asn1Null;
			}
			return p2.ToAsn1Object() is global::Org.BouncyCastle.Asn1.Asn1Null;
		}

		// Token: 0x0400007D RID: 125
		private readonly global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure c;

		// Token: 0x0400007E RID: 126
		private readonly string sigAlgName;

		// Token: 0x0400007F RID: 127
		private readonly byte[] sigAlgParams;

		// Token: 0x04000080 RID: 128
		private readonly global::Org.BouncyCastle.Asn1.X509.BasicConstraints basicConstraints;

		// Token: 0x04000081 RID: 129
		private readonly bool[] keyUsage;

		// Token: 0x04000082 RID: 130
		private readonly object cacheLock = new object();

		// Token: 0x04000083 RID: 131
		private global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKeyValue;

		// Token: 0x04000084 RID: 132
		private global::Org.BouncyCastle.X509.X509Certificate.CachedEncoding cachedEncoding;

		// Token: 0x04000085 RID: 133
		private volatile bool hashValueSet;

		// Token: 0x04000086 RID: 134
		private volatile int hashValue;

		// Token: 0x02000799 RID: 1945
		private class CachedEncoding
		{
			// Token: 0x060044F0 RID: 17648 RVA: 0x0013243C File Offset: 0x0013063C
			internal CachedEncoding(byte[] encoding, global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException exception)
			{
				this.encoding = encoding;
				this.exception = exception;
			}

			// Token: 0x17000A68 RID: 2664
			// (get) Token: 0x060044F1 RID: 17649 RVA: 0x00132452 File Offset: 0x00130652
			internal byte[] Encoding
			{
				get
				{
					return this.encoding;
				}
			}

			// Token: 0x060044F2 RID: 17650 RVA: 0x0013245A File Offset: 0x0013065A
			internal byte[] GetEncoded()
			{
				if (this.exception != null)
				{
					throw this.exception;
				}
				if (this.encoding == null)
				{
					throw new global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException();
				}
				return this.encoding;
			}

			// Token: 0x040022DC RID: 8924
			private readonly byte[] encoding;

			// Token: 0x040022DD RID: 8925
			private readonly global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException exception;
		}
	}
}
