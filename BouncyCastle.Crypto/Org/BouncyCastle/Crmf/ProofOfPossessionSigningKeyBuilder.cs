using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crmf
{
	// Token: 0x02000516 RID: 1302
	public class ProofOfPossessionSigningKeyBuilder
	{
		// Token: 0x060032B8 RID: 12984 RVA: 0x000F29DD File Offset: 0x000F0BDD
		public ProofOfPossessionSigningKeyBuilder(global::Org.BouncyCastle.Asn1.Crmf.CertRequest certRequest)
		{
			this._certRequest = certRequest;
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x000F29EC File Offset: 0x000F0BEC
		public ProofOfPossessionSigningKeyBuilder(global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo pubKeyInfo)
		{
			this._pubKeyInfo = pubKeyInfo;
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x000F29FB File Offset: 0x000F0BFB
		public global::Org.BouncyCastle.Crmf.ProofOfPossessionSigningKeyBuilder SetSender(global::Org.BouncyCastle.Asn1.X509.GeneralName name)
		{
			this._name = name;
			return this;
		}

		// Token: 0x060032BB RID: 12987 RVA: 0x000F2A08 File Offset: 0x000F0C08
		public global::Org.BouncyCastle.Crmf.ProofOfPossessionSigningKeyBuilder SetPublicKeyMac(global::Org.BouncyCastle.Crmf.PKMacBuilder generator, char[] password)
		{
			global::Org.BouncyCastle.Crypto.IMacFactory fact = generator.Build(password);
			global::Org.BouncyCastle.Crypto.IStreamCalculator calc = fact.CreateCalculator();
			byte[] d = this._pubKeyInfo.GetDerEncoded();
			calc.Stream.Write(d, 0, d.Length);
			calc.Stream.Flush();
			global::Org.BouncyCastle.Utilities.Platform.Dispose(calc.Stream);
			this._publicKeyMAC = new global::Org.BouncyCastle.Asn1.Crmf.PKMacValue((global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)fact.AlgorithmDetails, new global::Org.BouncyCastle.Asn1.DerBitString(((global::Org.BouncyCastle.Crypto.IBlockResult)calc.GetResult()).Collect()));
			return this;
		}

		// Token: 0x060032BC RID: 12988 RVA: 0x000F2A84 File Offset: 0x000F0C84
		public global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKey Build(global::Org.BouncyCastle.Crypto.ISignatureFactory signer)
		{
			if (this._name != null && this._publicKeyMAC != null)
			{
				throw new global::System.InvalidOperationException("name and publicKeyMAC cannot both be set.");
			}
			global::Org.BouncyCastle.Crypto.IStreamCalculator calc = signer.CreateCalculator();
			global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKeyInput popo;
			if (this._certRequest != null)
			{
				popo = null;
				byte[] b = this._certRequest.GetDerEncoded();
				calc.Stream.Write(b, 0, b.Length);
			}
			else if (this._name != null)
			{
				popo = new global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKeyInput(this._name, this._pubKeyInfo);
				byte[] b = popo.GetDerEncoded();
				calc.Stream.Write(b, 0, b.Length);
			}
			else
			{
				popo = new global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKeyInput(this._publicKeyMAC, this._pubKeyInfo);
				byte[] b = popo.GetDerEncoded();
				calc.Stream.Write(b, 0, b.Length);
			}
			calc.Stream.Flush();
			global::Org.BouncyCastle.Utilities.Platform.Dispose(calc.Stream);
			global::Org.BouncyCastle.Crypto.Operators.DefaultSignatureResult res = (global::Org.BouncyCastle.Crypto.Operators.DefaultSignatureResult)calc.GetResult();
			return new global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKey(popo, (global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)signer.AlgorithmDetails, new global::Org.BouncyCastle.Asn1.DerBitString(res.Collect()));
		}

		// Token: 0x0400168B RID: 5771
		private global::Org.BouncyCastle.Asn1.Crmf.CertRequest _certRequest;

		// Token: 0x0400168C RID: 5772
		private global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo _pubKeyInfo;

		// Token: 0x0400168D RID: 5773
		private global::Org.BouncyCastle.Asn1.X509.GeneralName _name;

		// Token: 0x0400168E RID: 5774
		private global::Org.BouncyCastle.Asn1.Crmf.PKMacValue _publicKeyMAC;
	}
}
