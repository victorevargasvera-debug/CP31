using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000305 RID: 773
	public class CertificateRequest
	{
		// Token: 0x060020FE RID: 8446 RVA: 0x000926A0 File Offset: 0x000908A0
		public CertificateRequest(byte[] certificateTypes, global::System.Collections.IList supportedSignatureAlgorithms, global::System.Collections.IList certificateAuthorities)
		{
			this.mCertificateTypes = certificateTypes;
			this.mSupportedSignatureAlgorithms = supportedSignatureAlgorithms;
			this.mCertificateAuthorities = certificateAuthorities;
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060020FF RID: 8447 RVA: 0x000926BD File Offset: 0x000908BD
		public virtual byte[] CertificateTypes
		{
			get
			{
				return this.mCertificateTypes;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06002100 RID: 8448 RVA: 0x000926C5 File Offset: 0x000908C5
		public virtual global::System.Collections.IList SupportedSignatureAlgorithms
		{
			get
			{
				return this.mSupportedSignatureAlgorithms;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06002101 RID: 8449 RVA: 0x000926CD File Offset: 0x000908CD
		public virtual global::System.Collections.IList CertificateAuthorities
		{
			get
			{
				return this.mCertificateAuthorities;
			}
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x000926D8 File Offset: 0x000908D8
		public virtual void Encode(global::System.IO.Stream output)
		{
			if (this.mCertificateTypes == null || this.mCertificateTypes.Length == 0)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(0, output);
			}
			else
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8ArrayWithUint8Length(this.mCertificateTypes, output);
			}
			if (this.mSupportedSignatureAlgorithms != null)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EncodeSupportedSignatureAlgorithms(this.mSupportedSignatureAlgorithms, false, output);
			}
			if (this.mCertificateAuthorities == null || this.mCertificateAuthorities.Count < 1)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(0, output);
				return;
			}
			global::System.Collections.IList derEncodings = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(this.mCertificateAuthorities.Count);
			int totalLength = 0;
			foreach (object obj in this.mCertificateAuthorities)
			{
				byte[] derEncoding = ((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj).GetEncoded("DER");
				derEncodings.Add(derEncoding);
				totalLength += derEncoding.Length + 2;
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(totalLength);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(totalLength, output);
			foreach (object obj2 in derEncodings)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16((byte[])obj2, output);
			}
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x00092804 File Offset: 0x00090A04
		public static global::Org.BouncyCastle.Crypto.Tls.CertificateRequest Parse(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::System.IO.Stream input)
		{
			int numTypes = (int)global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input);
			byte[] certificateTypes = new byte[numTypes];
			for (int i = 0; i < numTypes; i++)
			{
				certificateTypes[i] = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input);
			}
			global::System.Collections.IList supportedSignatureAlgorithms = null;
			if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(context))
			{
				supportedSignatureAlgorithms = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ParseSupportedSignatureAlgorithms(false, input);
			}
			global::System.Collections.IList certificateAuthorities = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			global::System.IO.MemoryStream bis = new global::System.IO.MemoryStream(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input), false);
			while (bis.Position < bis.Length)
			{
				global::Org.BouncyCastle.Asn1.Asn1Object asn = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadDerObject(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(bis));
				certificateAuthorities.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(asn));
			}
			return new global::Org.BouncyCastle.Crypto.Tls.CertificateRequest(certificateTypes, supportedSignatureAlgorithms, certificateAuthorities);
		}

		// Token: 0x04000B99 RID: 2969
		protected readonly byte[] mCertificateTypes;

		// Token: 0x04000B9A RID: 2970
		protected readonly global::System.Collections.IList mSupportedSignatureAlgorithms;

		// Token: 0x04000B9B RID: 2971
		protected readonly global::System.Collections.IList mCertificateAuthorities;
	}
}
