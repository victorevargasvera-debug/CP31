using System;
using System.IO;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000130 RID: 304
	public sealed class TrustedAuthority
	{
		// Token: 0x06000CB9 RID: 3257 RVA: 0x000318FA File Offset: 0x0002FAFA
		public TrustedAuthority(short identifierType, object identifier)
		{
			if (!global::Org.BouncyCastle.Tls.TrustedAuthority.IsCorrectType(identifierType, identifier))
			{
				throw new global::System.ArgumentException("not an instance of the correct type", "identifier");
			}
			this.m_identifierType = identifierType;
			this.m_identifier = identifier;
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x00031929 File Offset: 0x0002FB29
		public short IdentifierType
		{
			get
			{
				return this.m_identifierType;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x00031931 File Offset: 0x0002FB31
		public object Identifier
		{
			get
			{
				return this.m_identifier;
			}
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00031939 File Offset: 0x0002FB39
		public byte[] GetCertSha1Hash()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone((byte[])this.m_identifier);
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x0003194B File Offset: 0x0002FB4B
		public byte[] GetKeySha1Hash()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone((byte[])this.m_identifier);
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x0003195D File Offset: 0x0002FB5D
		public global::Org.BouncyCastle.Asn1.X509.X509Name X509Name
		{
			get
			{
				this.CheckCorrectType(2);
				return (global::Org.BouncyCastle.Asn1.X509.X509Name)this.m_identifier;
			}
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00031974 File Offset: 0x0002FB74
		public void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(this.m_identifierType, output);
			switch (this.m_identifierType)
			{
			case 0:
				return;
			case 1:
			case 3:
			{
				byte[] sha1Hash = (byte[])this.m_identifier;
				output.Write(sha1Hash, 0, sha1Hash.Length);
				return;
			}
			case 2:
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(((global::Org.BouncyCastle.Asn1.X509.X509Name)this.m_identifier).GetEncoded("DER"), output);
				return;
			default:
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x000319E8 File Offset: 0x0002FBE8
		public static global::Org.BouncyCastle.Tls.TrustedAuthority Parse(global::System.IO.Stream input)
		{
			short identifier_type = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(input);
			object identifier;
			switch (identifier_type)
			{
			case 0:
				identifier = null;
				break;
			case 1:
			case 3:
				identifier = global::Org.BouncyCastle.Tls.TlsUtilities.ReadFully(20, input);
				break;
			case 2:
				identifier = global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(global::Org.BouncyCastle.Tls.TlsUtilities.ReadDerObject(global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input, 1)));
				break;
			default:
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			return new global::Org.BouncyCastle.Tls.TrustedAuthority(identifier_type, identifier);
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00031A46 File Offset: 0x0002FC46
		private void CheckCorrectType(short expectedIdentifierType)
		{
			if (this.m_identifierType != expectedIdentifierType || !global::Org.BouncyCastle.Tls.TrustedAuthority.IsCorrectType(expectedIdentifierType, this.m_identifier))
			{
				throw new global::System.InvalidOperationException("TrustedAuthority is not of type " + global::Org.BouncyCastle.Tls.IdentifierType.GetName(expectedIdentifierType));
			}
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00031A75 File Offset: 0x0002FC75
		private static bool IsCorrectType(short identifierType, object identifier)
		{
			switch (identifierType)
			{
			case 0:
				return identifier == null;
			case 1:
			case 3:
				return global::Org.BouncyCastle.Tls.TrustedAuthority.IsSha1Hash(identifier);
			case 2:
				return identifier is global::Org.BouncyCastle.Asn1.X509.X509Name;
			default:
				throw new global::System.ArgumentException("unsupported IdentifierType", "identifierType");
			}
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00031AB4 File Offset: 0x0002FCB4
		private static bool IsSha1Hash(object identifier)
		{
			return identifier is byte[] && ((byte[])identifier).Length == 20;
		}

		// Token: 0x0400075F RID: 1887
		private readonly short m_identifierType;

		// Token: 0x04000760 RID: 1888
		private readonly object m_identifier;
	}
}
