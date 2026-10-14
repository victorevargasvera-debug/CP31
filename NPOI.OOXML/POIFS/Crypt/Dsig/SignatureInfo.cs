using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.Util;

namespace NPOI.POIFS.Crypt.Dsig
{
	// Token: 0x02000101 RID: 257
	public class SignatureInfo : global::NPOI.POIFS.Crypt.Dsig.ISignatureConfigurable
	{
		// Token: 0x06000F51 RID: 3921 RVA: 0x000362A9 File Offset: 0x000344A9
		public SignatureInfo()
		{
			global::NPOI.POIFS.Crypt.Dsig.SignatureInfo.InitXmlProvider();
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.POIFS.Crypt.Dsig.SignatureConfig GetSignatureConfig()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x000065E4 File Offset: 0x000047E4
		public void SetSignatureConfig(global::NPOI.POIFS.Crypt.Dsig.SignatureConfig signatureConfig)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x000065E4 File Offset: 0x000047E4
		public bool VerifySignature()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x000362B6 File Offset: 0x000344B6
		public void ConfirmSignature()
		{
			global::NPOI.Util.DocumentHelper.CreateDocument();
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x000362C3 File Offset: 0x000344C3
		public byte[] signDigest(byte[] digest)
		{
			global::NPOI.POIFS.Crypt.CryptoFunctions.GetCipher(this.signatureConfig.GetKey(), global::NPOI.POIFS.Crypt.CipherAlgorithm.rsa, global::NPOI.POIFS.Crypt.ChainingMode.ecb, null, global::NPOI.POIFS.Crypt.Cipher.ENCRYPT_MODE, "PKCS1PAdding");
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x000362F0 File Offset: 0x000344F0
		public global::System.Collections.Generic.IEnumerable<global::NPOI.POIFS.Crypt.Dsig.SignatureInfo.SignaturePart> GetSignatureParts()
		{
			this.signatureConfig.Init(true);
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x000065E4 File Offset: 0x000047E4
		protected static void InitXmlProvider()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00036303 File Offset: 0x00034503
		public global::NPOI.POIFS.Crypt.Dsig.DigestInfo preSign(global::System.Xml.XmlDocument document, global::System.Collections.Generic.List<global::NPOI.POIFS.Crypt.Dsig.DigestInfo> digestInfos)
		{
			this.signatureConfig.Init(false);
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x000065E4 File Offset: 0x000047E4
		public void postSign(global::System.Xml.XmlDocument document, byte[] signatureValue)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x000029BF File Offset: 0x00000BBF
		protected void WriteDocument(global::System.Xml.XmlDocument document)
		{
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x000065E4 File Offset: 0x000047E4
		private static global::System.Collections.Generic.List<T> safe<T>(global::System.Collections.Generic.List<T> other)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x040004BA RID: 1210
		private static bool IsInitialized;

		// Token: 0x040004BB RID: 1211
		protected internal global::NPOI.POIFS.Crypt.Dsig.SignatureConfig signatureConfig;

		// Token: 0x0200014E RID: 334
		public class SignaturePart
		{
			// Token: 0x06001078 RID: 4216 RVA: 0x000394B0 File Offset: 0x000376B0
			private SignaturePart(global::NPOI.OpenXml4Net.OPC.PackagePart signaturePart)
			{
				this.signaturePart = signaturePart;
			}

			// Token: 0x06001079 RID: 4217 RVA: 0x000394BF File Offset: 0x000376BF
			public global::NPOI.OpenXml4Net.OPC.PackagePart GetPackagePart()
			{
				return this.signaturePart;
			}

			// Token: 0x0600107A RID: 4218 RVA: 0x000394C7 File Offset: 0x000376C7
			public global::System.Security.Cryptography.X509Certificates.X509Certificate GetSigner()
			{
				return this.signer;
			}

			// Token: 0x0600107B RID: 4219 RVA: 0x000394CF File Offset: 0x000376CF
			public global::System.Collections.Generic.List<global::System.Security.Cryptography.X509Certificates.X509Certificate> GetCertChain()
			{
				return this.certChain;
			}

			// Token: 0x0600107C RID: 4220 RVA: 0x000065E4 File Offset: 0x000047E4
			public bool Validate()
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x04000538 RID: 1336
			private global::NPOI.OpenXml4Net.OPC.PackagePart signaturePart;

			// Token: 0x04000539 RID: 1337
			private global::System.Security.Cryptography.X509Certificates.X509Certificate signer;

			// Token: 0x0400053A RID: 1338
			private global::System.Collections.Generic.List<global::System.Security.Cryptography.X509Certificates.X509Certificate> certChain;
		}
	}
}
