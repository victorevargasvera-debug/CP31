using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000324 RID: 804
	public abstract class DtlsProtocol
	{
		// Token: 0x060021C3 RID: 8643 RVA: 0x00095384 File Offset: 0x00093584
		protected DtlsProtocol(global::Org.BouncyCastle.Security.SecureRandom secureRandom)
		{
			if (secureRandom == null)
			{
				throw new global::System.ArgumentNullException("secureRandom");
			}
			this.mSecureRandom = secureRandom;
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x000953A4 File Offset: 0x000935A4
		protected virtual void ProcessFinished(byte[] body, byte[] expected_verify_data)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(body, false);
			byte[] verify_data = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(expected_verify_data.Length, buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf);
			if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(expected_verify_data, verify_data))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
			}
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x000953DC File Offset: 0x000935DC
		internal static void ApplyMaxFragmentLengthExtension(global::Org.BouncyCastle.Crypto.Tls.DtlsRecordLayer recordLayer, short maxFragmentLength)
		{
			if (maxFragmentLength >= 0)
			{
				if (!global::Org.BouncyCastle.Crypto.Tls.MaxFragmentLength.IsValid((byte)maxFragmentLength))
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
				}
				int plainTextLimit = 1 << (int)(8 + maxFragmentLength);
				recordLayer.SetPlaintextLimit(plainTextLimit);
			}
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x00095410 File Offset: 0x00093610
		protected static short EvaluateMaxFragmentLengthExtension(bool resumedSession, global::System.Collections.IDictionary clientExtensions, global::System.Collections.IDictionary serverExtensions, byte alertDescription)
		{
			short maxFragmentLength = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.GetMaxFragmentLengthExtension(serverExtensions);
			if (maxFragmentLength >= 0 && (!global::Org.BouncyCastle.Crypto.Tls.MaxFragmentLength.IsValid((byte)maxFragmentLength) || (!resumedSession && maxFragmentLength != global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.GetMaxFragmentLengthExtension(clientExtensions))))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription);
			}
			return maxFragmentLength;
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x00095448 File Offset: 0x00093648
		protected static byte[] GenerateCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate certificate)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			certificate.Encode(buf);
			return buf.ToArray();
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x00095468 File Offset: 0x00093668
		protected static byte[] GenerateSupplementalData(global::System.Collections.IList supplementalData)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.WriteSupplementalData(memoryStream, supplementalData);
			return memoryStream.ToArray();
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x0009547C File Offset: 0x0009367C
		protected static void ValidateSelectedCipherSuite(int selectedCipherSuite, byte alertDescription)
		{
			int encryptionAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetEncryptionAlgorithm(selectedCipherSuite);
			if (encryptionAlgorithm - 1 <= 1)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription);
			}
		}

		// Token: 0x04000CE9 RID: 3305
		protected readonly global::Org.BouncyCastle.Security.SecureRandom mSecureRandom;
	}
}
