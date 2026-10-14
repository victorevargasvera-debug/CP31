using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000098 RID: 152
	public sealed class CertificateRequest
	{
		// Token: 0x06000643 RID: 1603 RVA: 0x0001A31D File Offset: 0x0001851D
		private static global::System.Collections.IList CheckSupportedSignatureAlgorithms(global::System.Collections.IList supportedSignatureAlgorithms, short alertDescription)
		{
			if (supportedSignatureAlgorithms == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(alertDescription, "'signature_algorithms' is required");
			}
			return supportedSignatureAlgorithms;
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0001A32F File Offset: 0x0001852F
		public CertificateRequest(short[] certificateTypes, global::System.Collections.IList supportedSignatureAlgorithms, global::System.Collections.IList certificateAuthorities) : this(null, certificateTypes, supportedSignatureAlgorithms, null, certificateAuthorities)
		{
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0001A33C File Offset: 0x0001853C
		public CertificateRequest(byte[] certificateRequestContext, global::System.Collections.IList supportedSignatureAlgorithms, global::System.Collections.IList supportedSignatureAlgorithmsCert, global::System.Collections.IList certificateAuthorities) : this(certificateRequestContext, null, global::Org.BouncyCastle.Tls.CertificateRequest.CheckSupportedSignatureAlgorithms(supportedSignatureAlgorithms, 80), supportedSignatureAlgorithmsCert, certificateAuthorities)
		{
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0001A354 File Offset: 0x00018554
		private CertificateRequest(byte[] certificateRequestContext, short[] certificateTypes, global::System.Collections.IList supportedSignatureAlgorithms, global::System.Collections.IList supportedSignatureAlgorithmsCert, global::System.Collections.IList certificateAuthorities)
		{
			if (certificateRequestContext != null && !global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint8(certificateRequestContext.Length))
			{
				throw new global::System.ArgumentException("cannot be longer than 255", "certificateRequestContext");
			}
			if (certificateTypes != null && (certificateTypes.Length < 1 || !global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint8(certificateTypes.Length)))
			{
				throw new global::System.ArgumentException("should have length from 1 to 255", "certificateTypes");
			}
			this.m_certificateRequestContext = global::Org.BouncyCastle.Tls.TlsUtilities.Clone(certificateRequestContext);
			this.m_certificateTypes = certificateTypes;
			this.m_supportedSignatureAlgorithms = supportedSignatureAlgorithms;
			this.m_supportedSignatureAlgorithmsCert = supportedSignatureAlgorithmsCert;
			this.m_certificateAuthorities = certificateAuthorities;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0001A3D1 File Offset: 0x000185D1
		public byte[] GetCertificateRequestContext()
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.Clone(this.m_certificateRequestContext);
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x0001A3DE File Offset: 0x000185DE
		public short[] CertificateTypes
		{
			get
			{
				return this.m_certificateTypes;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x0001A3E6 File Offset: 0x000185E6
		public global::System.Collections.IList SupportedSignatureAlgorithms
		{
			get
			{
				return this.m_supportedSignatureAlgorithms;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x0001A3EE File Offset: 0x000185EE
		public global::System.Collections.IList SupportedSignatureAlgorithmsCert
		{
			get
			{
				return this.m_supportedSignatureAlgorithmsCert;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x0001A3F6 File Offset: 0x000185F6
		public global::System.Collections.IList CertificateAuthorities
		{
			get
			{
				return this.m_certificateAuthorities;
			}
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0001A3FE File Offset: 0x000185FE
		public bool HasCertificateRequestContext(byte[] certificateRequestContext)
		{
			return global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.m_certificateRequestContext, certificateRequestContext);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0001A40C File Offset: 0x0001860C
		public void Encode(global::Org.BouncyCastle.Tls.TlsContext context, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.ProtocolVersion serverVersion = context.ServerVersion;
			bool isTlsV12 = global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV12(serverVersion);
			bool isTlsV13 = global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(serverVersion);
			if (isTlsV13 != (this.m_certificateRequestContext != null) || isTlsV13 != (this.m_certificateTypes == null) || isTlsV12 != (this.m_supportedSignatureAlgorithms != null) || (!isTlsV13 && this.m_supportedSignatureAlgorithmsCert != null))
			{
				throw new global::System.InvalidOperationException();
			}
			if (isTlsV13)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque8(this.m_certificateRequestContext, output);
				global::System.Collections.IDictionary extensions = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddSignatureAlgorithmsExtension(extensions, this.m_supportedSignatureAlgorithms);
				if (this.m_supportedSignatureAlgorithmsCert != null)
				{
					global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddSignatureAlgorithmsCertExtension(extensions, this.m_supportedSignatureAlgorithmsCert);
				}
				if (this.m_certificateAuthorities != null)
				{
					global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddCertificateAuthoritiesExtension(extensions, this.m_certificateAuthorities);
				}
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(global::Org.BouncyCastle.Tls.TlsProtocol.WriteExtensionsData(extensions), output);
				return;
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8ArrayWithUint8Length(this.m_certificateTypes, output);
			if (isTlsV12)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.EncodeSupportedSignatureAlgorithms(this.m_supportedSignatureAlgorithms, output);
			}
			if (this.m_certificateAuthorities == null || this.m_certificateAuthorities.Count < 1)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(0, output);
				return;
			}
			global::System.Collections.IList derEncodings = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(this.m_certificateAuthorities.Count);
			int totalLength = 0;
			foreach (object obj in this.m_certificateAuthorities)
			{
				byte[] derEncoding = ((global::Org.BouncyCastle.Asn1.X509.X509Name)obj).GetEncoded("DER");
				derEncodings.Add(derEncoding);
				totalLength += derEncoding.Length + 2;
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(totalLength);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(totalLength, output);
			foreach (object obj2 in derEncodings)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16((byte[])obj2, output);
			}
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0001A5C8 File Offset: 0x000187C8
		public static global::Org.BouncyCastle.Tls.CertificateRequest Parse(global::Org.BouncyCastle.Tls.TlsContext context, global::System.IO.Stream input)
		{
			global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion = context.ServerVersion;
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(negotiatedVersion))
			{
				byte[] certificateRequestContext = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque8(input);
				byte[] extEncoding = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input);
				global::System.Collections.IDictionary extensions = global::Org.BouncyCastle.Tls.TlsProtocol.ReadExtensionsData13(13, extEncoding);
				global::System.Collections.IList supportedSignatureAlgorithms13 = global::Org.BouncyCastle.Tls.CertificateRequest.CheckSupportedSignatureAlgorithms(global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetSignatureAlgorithmsExtension(extensions), 109);
				global::System.Collections.IList supportedSignatureAlgorithmsCert13 = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetSignatureAlgorithmsCertExtension(extensions);
				global::System.Collections.IList certificateAuthorities13 = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetCertificateAuthoritiesExtension(extensions);
				return new global::Org.BouncyCastle.Tls.CertificateRequest(certificateRequestContext, supportedSignatureAlgorithms13, supportedSignatureAlgorithmsCert13, certificateAuthorities13);
			}
			bool flag = global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV12(negotiatedVersion);
			short[] certificateTypes = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8ArrayWithUint8Length(input, 1);
			global::System.Collections.IList supportedSignatureAlgorithms14 = null;
			if (flag)
			{
				supportedSignatureAlgorithms14 = global::Org.BouncyCastle.Tls.TlsUtilities.ParseSupportedSignatureAlgorithms(input);
			}
			global::System.Collections.IList certificateAuthorities14 = null;
			byte[] certAuthData = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input);
			if (certAuthData.Length != 0)
			{
				certificateAuthorities14 = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				global::System.IO.MemoryStream bis = new global::System.IO.MemoryStream(certAuthData, false);
				do
				{
					global::Org.BouncyCastle.Asn1.Asn1Object asn = global::Org.BouncyCastle.Tls.TlsUtilities.ReadDerObject(global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(bis, 1));
					certificateAuthorities14.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(asn));
				}
				while (bis.Position < bis.Length);
			}
			return new global::Org.BouncyCastle.Tls.CertificateRequest(certificateTypes, supportedSignatureAlgorithms14, certificateAuthorities14);
		}

		// Token: 0x04000343 RID: 835
		private readonly byte[] m_certificateRequestContext;

		// Token: 0x04000344 RID: 836
		private readonly short[] m_certificateTypes;

		// Token: 0x04000345 RID: 837
		private readonly global::System.Collections.IList m_supportedSignatureAlgorithms;

		// Token: 0x04000346 RID: 838
		private readonly global::System.Collections.IList m_supportedSignatureAlgorithmsCert;

		// Token: 0x04000347 RID: 839
		private readonly global::System.Collections.IList m_certificateAuthorities;
	}
}
