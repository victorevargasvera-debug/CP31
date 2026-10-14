using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;

namespace Org.BouncyCastle.Crmf
{
	// Token: 0x02000508 RID: 1288
	public class CertificateRequestMessage
	{
		// Token: 0x06003264 RID: 12900 RVA: 0x000F1B68 File Offset: 0x000EFD68
		private static global::Org.BouncyCastle.Asn1.Crmf.CertReqMsg ParseBytes(byte[] encoding)
		{
			return global::Org.BouncyCastle.Asn1.Crmf.CertReqMsg.GetInstance(encoding);
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x000F1B70 File Offset: 0x000EFD70
		public CertificateRequestMessage(byte[] encoded) : this(global::Org.BouncyCastle.Asn1.Crmf.CertReqMsg.GetInstance(encoded))
		{
		}

		// Token: 0x06003266 RID: 12902 RVA: 0x000F1B7E File Offset: 0x000EFD7E
		public CertificateRequestMessage(global::Org.BouncyCastle.Asn1.Crmf.CertReqMsg certReqMsg)
		{
			this.certReqMsg = certReqMsg;
			this.controls = certReqMsg.CertReq.Controls;
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x000F1B9E File Offset: 0x000EFD9E
		public global::Org.BouncyCastle.Asn1.Crmf.CertReqMsg ToAsn1Structure()
		{
			return this.certReqMsg;
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x000F1BA6 File Offset: 0x000EFDA6
		public global::Org.BouncyCastle.Asn1.Crmf.CertTemplate GetCertTemplate()
		{
			return this.certReqMsg.CertReq.CertTemplate;
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06003269 RID: 12905 RVA: 0x000F1BB8 File Offset: 0x000EFDB8
		public bool HasControls
		{
			get
			{
				return this.controls != null;
			}
		}

		// Token: 0x0600326A RID: 12906 RVA: 0x000F1BC3 File Offset: 0x000EFDC3
		public bool HasControl(global::Org.BouncyCastle.Asn1.DerObjectIdentifier objectIdentifier)
		{
			return this.FindControl(objectIdentifier) != null;
		}

		// Token: 0x0600326B RID: 12907 RVA: 0x000F1BD0 File Offset: 0x000EFDD0
		public global::Org.BouncyCastle.Crmf.IControl GetControl(global::Org.BouncyCastle.Asn1.DerObjectIdentifier type)
		{
			global::Org.BouncyCastle.Asn1.Crmf.AttributeTypeAndValue found = this.FindControl(type);
			if (found != null)
			{
				if (found.Type.Equals(global::Org.BouncyCastle.Asn1.Crmf.CrmfObjectIdentifiers.id_regCtrl_pkiArchiveOptions))
				{
					return new global::Org.BouncyCastle.Crmf.PkiArchiveControl(global::Org.BouncyCastle.Asn1.Crmf.PkiArchiveOptions.GetInstance(found.Value));
				}
				if (found.Type.Equals(global::Org.BouncyCastle.Asn1.Crmf.CrmfObjectIdentifiers.id_regCtrl_regToken))
				{
					return new global::Org.BouncyCastle.Crmf.RegTokenControl(global::Org.BouncyCastle.Asn1.DerUtf8String.GetInstance(found.Value));
				}
				if (found.Type.Equals(global::Org.BouncyCastle.Asn1.Crmf.CrmfObjectIdentifiers.id_regCtrl_authenticator))
				{
					return new global::Org.BouncyCastle.Crmf.AuthenticatorControl(global::Org.BouncyCastle.Asn1.DerUtf8String.GetInstance(found.Value));
				}
			}
			return null;
		}

		// Token: 0x0600326C RID: 12908 RVA: 0x000F1C54 File Offset: 0x000EFE54
		public global::Org.BouncyCastle.Asn1.Crmf.AttributeTypeAndValue FindControl(global::Org.BouncyCastle.Asn1.DerObjectIdentifier type)
		{
			if (this.controls == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.Crmf.AttributeTypeAndValue[] tAndV = this.controls.ToAttributeTypeAndValueArray();
			global::Org.BouncyCastle.Asn1.Crmf.AttributeTypeAndValue found = null;
			for (int i = 0; i < tAndV.Length; i++)
			{
				if (tAndV[i].Type.Equals(type))
				{
					found = tAndV[i];
					break;
				}
			}
			return found;
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x0600326D RID: 12909 RVA: 0x000F1C9E File Offset: 0x000EFE9E
		public bool HasProofOfPossession
		{
			get
			{
				return this.certReqMsg.Popo != null;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x0600326E RID: 12910 RVA: 0x000F1CAE File Offset: 0x000EFEAE
		public int ProofOfPossession
		{
			get
			{
				return this.certReqMsg.Popo.Type;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x0600326F RID: 12911 RVA: 0x000F1CC0 File Offset: 0x000EFEC0
		public bool HasSigningKeyProofOfPossessionWithPkMac
		{
			get
			{
				global::Org.BouncyCastle.Asn1.Crmf.ProofOfPossession pop = this.certReqMsg.Popo;
				return pop.Type == global::Org.BouncyCastle.Crmf.CertificateRequestMessage.popSigningKey && global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKey.GetInstance(pop.Object).PoposkInput.PublicKeyMac != null;
			}
		}

		// Token: 0x06003270 RID: 12912 RVA: 0x000F1D00 File Offset: 0x000EFF00
		public bool IsValidSigningKeyPop(global::Org.BouncyCastle.Crypto.IVerifierFactoryProvider verifierProvider)
		{
			global::Org.BouncyCastle.Asn1.Crmf.ProofOfPossession pop = this.certReqMsg.Popo;
			if (pop.Type != global::Org.BouncyCastle.Crmf.CertificateRequestMessage.popSigningKey)
			{
				throw new global::System.InvalidOperationException("not Signing Key type of proof of possession");
			}
			global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKey popoSign = global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKey.GetInstance(pop.Object);
			if (popoSign.PoposkInput != null && popoSign.PoposkInput.PublicKeyMac != null)
			{
				throw new global::System.InvalidOperationException("verification requires password check");
			}
			return this.verifySignature(verifierProvider, popoSign);
		}

		// Token: 0x06003271 RID: 12913 RVA: 0x000F1D68 File Offset: 0x000EFF68
		private bool verifySignature(global::Org.BouncyCastle.Crypto.IVerifierFactoryProvider verifierFactoryProvider, global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKey signKey)
		{
			global::Org.BouncyCastle.Crypto.IStreamCalculator calculator;
			try
			{
				calculator = verifierFactoryProvider.CreateVerifierFactory(signKey.AlgorithmIdentifier).CreateCalculator();
			}
			catch (global::System.Exception ex)
			{
				throw new global::Org.BouncyCastle.Crmf.CrmfException("unable to create verifier: " + ex.Message, ex);
			}
			if (signKey.PoposkInput != null)
			{
				byte[] b = signKey.GetDerEncoded();
				calculator.Stream.Write(b, 0, b.Length);
			}
			else
			{
				byte[] b2 = this.certReqMsg.CertReq.GetDerEncoded();
				calculator.Stream.Write(b2, 0, b2.Length);
			}
			return ((global::Org.BouncyCastle.Crypto.Operators.DefaultVerifierResult)calculator.GetResult()).IsVerified(signKey.Signature.GetBytes());
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x000F1E10 File Offset: 0x000F0010
		public byte[] GetEncoded()
		{
			return this.certReqMsg.GetEncoded();
		}

		// Token: 0x04001663 RID: 5731
		public static readonly int popRaVerified = 0;

		// Token: 0x04001664 RID: 5732
		public static readonly int popSigningKey = 1;

		// Token: 0x04001665 RID: 5733
		public static readonly int popKeyEncipherment = 2;

		// Token: 0x04001666 RID: 5734
		public static readonly int popKeyAgreement = 3;

		// Token: 0x04001667 RID: 5735
		private readonly global::Org.BouncyCastle.Asn1.Crmf.CertReqMsg certReqMsg;

		// Token: 0x04001668 RID: 5736
		private readonly global::Org.BouncyCastle.Asn1.Crmf.Controls controls;
	}
}
