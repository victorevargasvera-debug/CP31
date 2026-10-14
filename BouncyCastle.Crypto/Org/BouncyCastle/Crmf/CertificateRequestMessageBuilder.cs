using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crmf
{
	// Token: 0x02000509 RID: 1289
	public class CertificateRequestMessageBuilder
	{
		// Token: 0x06003274 RID: 12916 RVA: 0x000F1E37 File Offset: 0x000F0037
		public CertificateRequestMessageBuilder(global::Org.BouncyCastle.Math.BigInteger certReqId)
		{
			this._certReqId = certReqId;
			this._extGenerator = new global::Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator();
			this._templateBuilder = new global::Org.BouncyCastle.Asn1.Crmf.CertTemplateBuilder();
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x000F1E6E File Offset: 0x000F006E
		public global::Org.BouncyCastle.Crmf.CertificateRequestMessageBuilder SetPublicKey(global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo publicKeyInfo)
		{
			if (publicKeyInfo != null)
			{
				this._templateBuilder.SetPublicKey(publicKeyInfo);
			}
			return this;
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x000F1E81 File Offset: 0x000F0081
		public global::Org.BouncyCastle.Crmf.CertificateRequestMessageBuilder SetIssuer(global::Org.BouncyCastle.Asn1.X509.X509Name issuer)
		{
			if (issuer != null)
			{
				this._templateBuilder.SetIssuer(issuer);
			}
			return this;
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x000F1E94 File Offset: 0x000F0094
		public global::Org.BouncyCastle.Crmf.CertificateRequestMessageBuilder SetSubject(global::Org.BouncyCastle.Asn1.X509.X509Name subject)
		{
			if (subject != null)
			{
				this._templateBuilder.SetSubject(subject);
			}
			return this;
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x000F1EA7 File Offset: 0x000F00A7
		public global::Org.BouncyCastle.Crmf.CertificateRequestMessageBuilder SetSerialNumber(global::Org.BouncyCastle.Math.BigInteger serialNumber)
		{
			if (serialNumber != null)
			{
				this._templateBuilder.SetSerialNumber(new global::Org.BouncyCastle.Asn1.DerInteger(serialNumber));
			}
			return this;
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x000F1EBF File Offset: 0x000F00BF
		public global::Org.BouncyCastle.Crmf.CertificateRequestMessageBuilder SetValidity(global::Org.BouncyCastle.Asn1.X509.Time notBefore, global::Org.BouncyCastle.Asn1.X509.Time notAfter)
		{
			this._templateBuilder.SetValidity(new global::Org.BouncyCastle.Asn1.Crmf.OptionalValidity(notBefore, notAfter));
			return this;
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x000F1ED5 File Offset: 0x000F00D5
		public global::Org.BouncyCastle.Crmf.CertificateRequestMessageBuilder AddExtension(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, bool critical, global::Org.BouncyCastle.Asn1.Asn1Encodable value)
		{
			this._extGenerator.AddExtension(oid, critical, value);
			return this;
		}

		// Token: 0x0600327B RID: 12923 RVA: 0x000F1EE6 File Offset: 0x000F00E6
		public global::Org.BouncyCastle.Crmf.CertificateRequestMessageBuilder AddExtension(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, bool critical, byte[] value)
		{
			this._extGenerator.AddExtension(oid, critical, value);
			return this;
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x000F1EF7 File Offset: 0x000F00F7
		public global::Org.BouncyCastle.Crmf.CertificateRequestMessageBuilder AddControl(global::Org.BouncyCastle.Crmf.IControl control)
		{
			this._controls.Add(control);
			return this;
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x000F1F07 File Offset: 0x000F0107
		public global::Org.BouncyCastle.Crmf.CertificateRequestMessageBuilder SetProofOfPossessionSignKeySigner(global::Org.BouncyCastle.Crypto.ISignatureFactory popoSignatureFactory)
		{
			if (this._popoPrivKey != null || this._popRaVerified != null || this._agreeMac != null)
			{
				throw new global::System.InvalidOperationException("only one proof of possession is allowed.");
			}
			this._popSigner = popoSignatureFactory;
			return this;
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x000F1F34 File Offset: 0x000F0134
		public global::Org.BouncyCastle.Crmf.CertificateRequestMessageBuilder SetProofOfPossessionSubsequentMessage(global::Org.BouncyCastle.Asn1.Crmf.SubsequentMessage msg)
		{
			if (this._popoPrivKey != null || this._popRaVerified != null || this._agreeMac != null)
			{
				throw new global::System.InvalidOperationException("only one proof of possession is allowed.");
			}
			this._popoType = 2;
			this._popoPrivKey = new global::Org.BouncyCastle.Asn1.Crmf.PopoPrivKey(msg);
			return this;
		}

		// Token: 0x0600327F RID: 12927 RVA: 0x000F1F70 File Offset: 0x000F0170
		public global::Org.BouncyCastle.Crmf.CertificateRequestMessageBuilder SetProofOfPossessionSubsequentMessage(int type, global::Org.BouncyCastle.Asn1.Crmf.SubsequentMessage msg)
		{
			if (this._popoPrivKey != null || this._popRaVerified != null || this._agreeMac != null)
			{
				throw new global::System.InvalidOperationException("only one proof of possession is allowed.");
			}
			if (type != 2 && type != 3)
			{
				throw new global::System.ArgumentException("type must be ProofOfPossession.TYPE_KEY_ENCIPHERMENT || ProofOfPossession.TYPE_KEY_AGREEMENT");
			}
			this._popoType = type;
			this._popoPrivKey = new global::Org.BouncyCastle.Asn1.Crmf.PopoPrivKey(msg);
			return this;
		}

		// Token: 0x06003280 RID: 12928 RVA: 0x000F1FC7 File Offset: 0x000F01C7
		public global::Org.BouncyCastle.Crmf.CertificateRequestMessageBuilder SetProofOfPossessionAgreeMac(global::Org.BouncyCastle.Asn1.Crmf.PKMacValue macValue)
		{
			if (this._popSigner != null || this._popRaVerified != null || this._popoPrivKey != null)
			{
				throw new global::System.InvalidOperationException("only one proof of possession allowed");
			}
			this._agreeMac = macValue;
			return this;
		}

		// Token: 0x06003281 RID: 12929 RVA: 0x000F1FF4 File Offset: 0x000F01F4
		public global::Org.BouncyCastle.Crmf.CertificateRequestMessageBuilder SetProofOfPossessionRaVerified()
		{
			if (this._popSigner != null || this._popoPrivKey != null)
			{
				throw new global::System.InvalidOperationException("only one proof of possession allowed");
			}
			this._popRaVerified = global::Org.BouncyCastle.Asn1.DerNull.Instance;
			return this;
		}

		// Token: 0x06003282 RID: 12930 RVA: 0x000F201D File Offset: 0x000F021D
		public global::Org.BouncyCastle.Crmf.CertificateRequestMessageBuilder SetAuthInfoPKMAC(global::Org.BouncyCastle.Crmf.PKMacBuilder pkmacFactory, char[] password)
		{
			this._pkMacBuilder = pkmacFactory;
			this._password = password;
			return this;
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x000F202E File Offset: 0x000F022E
		public global::Org.BouncyCastle.Crmf.CertificateRequestMessageBuilder SetAuthInfoSender(global::Org.BouncyCastle.Asn1.X509.X509Name sender)
		{
			return this.SetAuthInfoSender(new global::Org.BouncyCastle.Asn1.X509.GeneralName(sender));
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x000F203C File Offset: 0x000F023C
		public global::Org.BouncyCastle.Crmf.CertificateRequestMessageBuilder SetAuthInfoSender(global::Org.BouncyCastle.Asn1.X509.GeneralName sender)
		{
			this._sender = sender;
			return this;
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x000F2048 File Offset: 0x000F0248
		public global::Org.BouncyCastle.Crmf.CertificateRequestMessage Build()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				new global::Org.BouncyCastle.Asn1.DerInteger(this._certReqId)
			});
			if (!this._extGenerator.IsEmpty)
			{
				this._templateBuilder.SetExtensions(this._extGenerator.Generate());
			}
			v.Add(this._templateBuilder.Build());
			if (this._controls.Count > 0)
			{
				global::Org.BouncyCastle.Asn1.Asn1EncodableVector controlV = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
				foreach (object obj in this._controls)
				{
					global::Org.BouncyCastle.Crmf.IControl control = (global::Org.BouncyCastle.Crmf.IControl)obj;
					controlV.Add(new global::Org.BouncyCastle.Asn1.Crmf.AttributeTypeAndValue(control.Type, control.Value));
				}
				v.Add(new global::Org.BouncyCastle.Asn1.DerSequence(controlV));
			}
			global::Org.BouncyCastle.Asn1.Crmf.CertRequest request = global::Org.BouncyCastle.Asn1.Crmf.CertRequest.GetInstance(new global::Org.BouncyCastle.Asn1.DerSequence(v));
			v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				request
			});
			if (this._popSigner != null)
			{
				global::Org.BouncyCastle.Asn1.Crmf.CertTemplate template = request.CertTemplate;
				if (template.Subject == null || template.PublicKey == null)
				{
					global::Org.BouncyCastle.Crmf.ProofOfPossessionSigningKeyBuilder builder = new global::Org.BouncyCastle.Crmf.ProofOfPossessionSigningKeyBuilder(request.CertTemplate.PublicKey);
					if (this._sender != null)
					{
						builder.SetSender(this._sender);
					}
					else
					{
						builder.SetPublicKeyMac(this._pkMacBuilder, this._password);
					}
					v.Add(new global::Org.BouncyCastle.Asn1.Crmf.ProofOfPossession(builder.Build(this._popSigner)));
				}
				else
				{
					global::Org.BouncyCastle.Crmf.ProofOfPossessionSigningKeyBuilder builder2 = new global::Org.BouncyCastle.Crmf.ProofOfPossessionSigningKeyBuilder(request);
					v.Add(new global::Org.BouncyCastle.Asn1.Crmf.ProofOfPossession(builder2.Build(this._popSigner)));
				}
			}
			else if (this._popoPrivKey != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.Crmf.ProofOfPossession(this._popoType, this._popoPrivKey));
			}
			else if (this._agreeMac != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.Crmf.ProofOfPossession(3, global::Org.BouncyCastle.Asn1.Crmf.PopoPrivKey.GetInstance(new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 3, this._agreeMac), true)));
			}
			else if (this._popRaVerified != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.Crmf.ProofOfPossession());
			}
			return new global::Org.BouncyCastle.Crmf.CertificateRequestMessage(global::Org.BouncyCastle.Asn1.Crmf.CertReqMsg.GetInstance(new global::Org.BouncyCastle.Asn1.DerSequence(v)));
		}

		// Token: 0x04001669 RID: 5737
		private readonly global::Org.BouncyCastle.Math.BigInteger _certReqId;

		// Token: 0x0400166A RID: 5738
		private global::Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator _extGenerator;

		// Token: 0x0400166B RID: 5739
		private global::Org.BouncyCastle.Asn1.Crmf.CertTemplateBuilder _templateBuilder;

		// Token: 0x0400166C RID: 5740
		private global::System.Collections.IList _controls = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x0400166D RID: 5741
		private global::Org.BouncyCastle.Crypto.ISignatureFactory _popSigner;

		// Token: 0x0400166E RID: 5742
		private global::Org.BouncyCastle.Crmf.PKMacBuilder _pkMacBuilder;

		// Token: 0x0400166F RID: 5743
		private char[] _password;

		// Token: 0x04001670 RID: 5744
		private global::Org.BouncyCastle.Asn1.X509.GeneralName _sender;

		// Token: 0x04001671 RID: 5745
		private int _popoType = 2;

		// Token: 0x04001672 RID: 5746
		private global::Org.BouncyCastle.Asn1.Crmf.PopoPrivKey _popoPrivKey;

		// Token: 0x04001673 RID: 5747
		private global::Org.BouncyCastle.Asn1.Asn1Null _popRaVerified;

		// Token: 0x04001674 RID: 5748
		private global::Org.BouncyCastle.Asn1.Crmf.PKMacValue _agreeMac;
	}
}
