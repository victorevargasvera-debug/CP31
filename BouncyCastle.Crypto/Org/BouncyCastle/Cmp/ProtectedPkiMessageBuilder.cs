using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cmp
{
	// Token: 0x02000564 RID: 1380
	public class ProtectedPkiMessageBuilder
	{
		// Token: 0x060034C0 RID: 13504 RVA: 0x000FBC5D File Offset: 0x000F9E5D
		public ProtectedPkiMessageBuilder(global::Org.BouncyCastle.Asn1.X509.GeneralName sender, global::Org.BouncyCastle.Asn1.X509.GeneralName recipient) : this(global::Org.BouncyCastle.Asn1.Cmp.PkiHeader.CMP_2000, sender, recipient)
		{
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x000FBC6C File Offset: 0x000F9E6C
		public ProtectedPkiMessageBuilder(int pvno, global::Org.BouncyCastle.Asn1.X509.GeneralName sender, global::Org.BouncyCastle.Asn1.X509.GeneralName recipient)
		{
			this.hdrBuilBuilder = new global::Org.BouncyCastle.Asn1.Cmp.PkiHeaderBuilder(pvno, sender, recipient);
		}

		// Token: 0x060034C2 RID: 13506 RVA: 0x000FBC98 File Offset: 0x000F9E98
		public global::Org.BouncyCastle.Cmp.ProtectedPkiMessageBuilder SetTransactionId(byte[] tid)
		{
			this.hdrBuilBuilder.SetTransactionID(tid);
			return this;
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x000FBCA8 File Offset: 0x000F9EA8
		public global::Org.BouncyCastle.Cmp.ProtectedPkiMessageBuilder SetFreeText(global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText freeText)
		{
			this.hdrBuilBuilder.SetFreeText(freeText);
			return this;
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x000FBCB8 File Offset: 0x000F9EB8
		public global::Org.BouncyCastle.Cmp.ProtectedPkiMessageBuilder AddGeneralInfo(global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue genInfo)
		{
			this.generalInfos.Add(genInfo);
			return this;
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x000FBCC8 File Offset: 0x000F9EC8
		public global::Org.BouncyCastle.Cmp.ProtectedPkiMessageBuilder SetMessageTime(global::Org.BouncyCastle.Asn1.DerGeneralizedTime generalizedTime)
		{
			this.hdrBuilBuilder.SetMessageTime(generalizedTime);
			return this;
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x000FBCD8 File Offset: 0x000F9ED8
		public global::Org.BouncyCastle.Cmp.ProtectedPkiMessageBuilder SetRecipKID(byte[] id)
		{
			this.hdrBuilBuilder.SetRecipKID(id);
			return this;
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x000FBCE8 File Offset: 0x000F9EE8
		public global::Org.BouncyCastle.Cmp.ProtectedPkiMessageBuilder SetRecipNonce(byte[] nonce)
		{
			this.hdrBuilBuilder.SetRecipNonce(nonce);
			return this;
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x000FBCF8 File Offset: 0x000F9EF8
		public global::Org.BouncyCastle.Cmp.ProtectedPkiMessageBuilder SetSenderKID(byte[] id)
		{
			this.hdrBuilBuilder.SetSenderKID(id);
			return this;
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x000FBD08 File Offset: 0x000F9F08
		public global::Org.BouncyCastle.Cmp.ProtectedPkiMessageBuilder SetSenderNonce(byte[] nonce)
		{
			this.hdrBuilBuilder.SetSenderNonce(nonce);
			return this;
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x000FBD18 File Offset: 0x000F9F18
		public global::Org.BouncyCastle.Cmp.ProtectedPkiMessageBuilder SetBody(global::Org.BouncyCastle.Asn1.Cmp.PkiBody body)
		{
			this.body = body;
			return this;
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x000FBD22 File Offset: 0x000F9F22
		public global::Org.BouncyCastle.Cmp.ProtectedPkiMessageBuilder AddCmpCertificate(global::Org.BouncyCastle.X509.X509Certificate certificate)
		{
			this.extraCerts.Add(certificate);
			return this;
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x000FBD34 File Offset: 0x000F9F34
		public global::Org.BouncyCastle.Cmp.ProtectedPkiMessage Build(global::Org.BouncyCastle.Crypto.ISignatureFactory signatureFactory)
		{
			if (this.body == null)
			{
				throw new global::System.InvalidOperationException("body must be set before building");
			}
			global::Org.BouncyCastle.Crypto.IStreamCalculator calculator = signatureFactory.CreateCalculator();
			if (!(signatureFactory.AlgorithmDetails is global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier))
			{
				throw new global::System.ArgumentException("AlgorithmDetails is not AlgorithmIdentifier");
			}
			this.FinalizeHeader((global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)signatureFactory.AlgorithmDetails);
			global::Org.BouncyCastle.Asn1.Cmp.PkiHeader header = this.hdrBuilBuilder.Build();
			global::Org.BouncyCastle.Asn1.DerBitString protection = new global::Org.BouncyCastle.Asn1.DerBitString(this.CalculateSignature(calculator, header, this.body));
			return this.FinalizeMessage(header, protection);
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x000FBDAC File Offset: 0x000F9FAC
		public global::Org.BouncyCastle.Cmp.ProtectedPkiMessage Build(global::Org.BouncyCastle.Crypto.IMacFactory factory)
		{
			if (this.body == null)
			{
				throw new global::System.InvalidOperationException("body must be set before building");
			}
			global::Org.BouncyCastle.Crypto.IStreamCalculator calculator = factory.CreateCalculator();
			this.FinalizeHeader((global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)factory.AlgorithmDetails);
			global::Org.BouncyCastle.Asn1.Cmp.PkiHeader header = this.hdrBuilBuilder.Build();
			global::Org.BouncyCastle.Asn1.DerBitString protection = new global::Org.BouncyCastle.Asn1.DerBitString(this.CalculateSignature(calculator, header, this.body));
			return this.FinalizeMessage(header, protection);
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x000FBE0C File Offset: 0x000FA00C
		private void FinalizeHeader(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithmIdentifier)
		{
			this.hdrBuilBuilder.SetProtectionAlg(algorithmIdentifier);
			if (this.generalInfos.Count > 0)
			{
				global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue[] genInfos = new global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue[this.generalInfos.Count];
				for (int t = 0; t < genInfos.Length; t++)
				{
					genInfos[t] = (global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue)this.generalInfos[t];
				}
				this.hdrBuilBuilder.SetGeneralInfo(genInfos);
			}
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x000FBE74 File Offset: 0x000FA074
		private global::Org.BouncyCastle.Cmp.ProtectedPkiMessage FinalizeMessage(global::Org.BouncyCastle.Asn1.Cmp.PkiHeader header, global::Org.BouncyCastle.Asn1.DerBitString protection)
		{
			if (this.extraCerts.Count > 0)
			{
				global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate[] cmpCertificates = new global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate[this.extraCerts.Count];
				for (int i = 0; i < cmpCertificates.Length; i++)
				{
					byte[] cert = ((global::Org.BouncyCastle.X509.X509Certificate)this.extraCerts[i]).GetEncoded();
					cmpCertificates[i] = global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(cert));
				}
				return new global::Org.BouncyCastle.Cmp.ProtectedPkiMessage(new global::Org.BouncyCastle.Asn1.Cmp.PkiMessage(header, this.body, protection, cmpCertificates));
			}
			return new global::Org.BouncyCastle.Cmp.ProtectedPkiMessage(new global::Org.BouncyCastle.Asn1.Cmp.PkiMessage(header, this.body, protection));
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x000FBEFC File Offset: 0x000FA0FC
		private byte[] CalculateSignature(global::Org.BouncyCastle.Crypto.IStreamCalculator signer, global::Org.BouncyCastle.Asn1.Cmp.PkiHeader header, global::Org.BouncyCastle.Asn1.Cmp.PkiBody body)
		{
			byte[] encoded = new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1EncodableVector
			{
				header,
				body
			}).GetEncoded();
			signer.Stream.Write(encoded, 0, encoded.Length);
			object result = signer.GetResult();
			if (result is global::Org.BouncyCastle.Crypto.Operators.DefaultSignatureResult)
			{
				return ((global::Org.BouncyCastle.Crypto.Operators.DefaultSignatureResult)result).Collect();
			}
			if (result is global::Org.BouncyCastle.Crypto.IBlockResult)
			{
				return ((global::Org.BouncyCastle.Crypto.IBlockResult)result).Collect();
			}
			if (result is byte[])
			{
				return (byte[])result;
			}
			throw new global::System.InvalidOperationException("result is not byte[] or DefaultSignatureResult");
		}

		// Token: 0x04001793 RID: 6035
		private global::Org.BouncyCastle.Asn1.Cmp.PkiHeaderBuilder hdrBuilBuilder;

		// Token: 0x04001794 RID: 6036
		private global::Org.BouncyCastle.Asn1.Cmp.PkiBody body;

		// Token: 0x04001795 RID: 6037
		private global::System.Collections.IList generalInfos = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x04001796 RID: 6038
		private global::System.Collections.IList extraCerts = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
	}
}
