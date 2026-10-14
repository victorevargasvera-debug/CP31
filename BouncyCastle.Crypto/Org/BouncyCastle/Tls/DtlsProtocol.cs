using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000BA RID: 186
	public abstract class DtlsProtocol
	{
		// Token: 0x060006FC RID: 1788 RVA: 0x0001D034 File Offset: 0x0001B234
		internal DtlsProtocol()
		{
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0001D03C File Offset: 0x0001B23C
		internal virtual void ProcessFinished(byte[] body, byte[] expected_verify_data)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(body, false);
			byte[] verify_data = global::Org.BouncyCastle.Tls.TlsUtilities.ReadFully(expected_verify_data.Length, buf);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(expected_verify_data, verify_data))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
			}
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0001D074 File Offset: 0x0001B274
		internal static void ApplyMaxFragmentLengthExtension(global::Org.BouncyCastle.Tls.DtlsRecordLayer recordLayer, short maxFragmentLength)
		{
			if (maxFragmentLength >= 0)
			{
				if (!global::Org.BouncyCastle.Tls.MaxFragmentLength.IsValid(maxFragmentLength))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
				int plainTextLimit = 1 << (int)(8 + maxFragmentLength);
				recordLayer.SetPlaintextLimit(plainTextLimit);
			}
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0001D0A8 File Offset: 0x0001B2A8
		internal static short EvaluateMaxFragmentLengthExtension(bool resumedSession, global::System.Collections.IDictionary clientExtensions, global::System.Collections.IDictionary serverExtensions, short alertDescription)
		{
			short maxFragmentLength = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetMaxFragmentLengthExtension(serverExtensions);
			if (maxFragmentLength >= 0 && (!global::Org.BouncyCastle.Tls.MaxFragmentLength.IsValid(maxFragmentLength) || (!resumedSession && maxFragmentLength != global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetMaxFragmentLengthExtension(clientExtensions))))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(alertDescription);
			}
			return maxFragmentLength;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0001D0DC File Offset: 0x0001B2DC
		internal static byte[] GenerateCertificate(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.Certificate certificate, global::System.IO.Stream endPointHash)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			certificate.Encode(context, buf, endPointHash);
			return buf.ToArray();
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x0001D0FE File Offset: 0x0001B2FE
		internal static byte[] GenerateSupplementalData(global::System.Collections.IList supplementalData)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Tls.TlsProtocol.WriteSupplementalData(memoryStream, supplementalData);
			return memoryStream.ToArray();
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0001D114 File Offset: 0x0001B314
		internal static void SendCertificateMessage(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.DtlsReliableHandshake handshake, global::Org.BouncyCastle.Tls.Certificate certificate, global::System.IO.Stream endPointHash)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			if (securityParameters.LocalCertificate != null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			if (certificate == null)
			{
				certificate = global::Org.BouncyCastle.Tls.Certificate.EmptyChain;
			}
			byte[] certificateBody = global::Org.BouncyCastle.Tls.DtlsProtocol.GenerateCertificate(context, certificate, endPointHash);
			handshake.SendMessage(11, certificateBody);
			securityParameters.m_localCertificate = certificate;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0001D15C File Offset: 0x0001B35C
		internal static int ValidateSelectedCipherSuite(int selectedCipherSuite, short alertDescription)
		{
			int encryptionAlgorithm = global::Org.BouncyCastle.Tls.TlsUtilities.GetEncryptionAlgorithm(selectedCipherSuite);
			if (encryptionAlgorithm == -1 || encryptionAlgorithm - 1 <= 1)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(alertDescription);
			}
			return selectedCipherSuite;
		}
	}
}
