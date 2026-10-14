using System;
using System.IO;
using System.Text;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Tsp;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tsp
{
	// Token: 0x0200007C RID: 124
	public class TimeStampResponse
	{
		// Token: 0x060004FA RID: 1274 RVA: 0x00016948 File Offset: 0x00014B48
		public TimeStampResponse(global::Org.BouncyCastle.Asn1.Tsp.TimeStampResp resp)
		{
			this.resp = resp;
			if (resp.TimeStampToken != null)
			{
				this.timeStampToken = new global::Org.BouncyCastle.Tsp.TimeStampToken(resp.TimeStampToken);
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00016970 File Offset: 0x00014B70
		public TimeStampResponse(byte[] resp) : this(global::Org.BouncyCastle.Tsp.TimeStampResponse.readTimeStampResp(new global::Org.BouncyCastle.Asn1.Asn1InputStream(resp)))
		{
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00016983 File Offset: 0x00014B83
		public TimeStampResponse(global::System.IO.Stream input) : this(global::Org.BouncyCastle.Tsp.TimeStampResponse.readTimeStampResp(new global::Org.BouncyCastle.Asn1.Asn1InputStream(input)))
		{
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00016998 File Offset: 0x00014B98
		private static global::Org.BouncyCastle.Asn1.Tsp.TimeStampResp readTimeStampResp(global::Org.BouncyCastle.Asn1.Asn1InputStream input)
		{
			global::Org.BouncyCastle.Asn1.Tsp.TimeStampResp instance;
			try
			{
				instance = global::Org.BouncyCastle.Asn1.Tsp.TimeStampResp.GetInstance(input.ReadObject());
			}
			catch (global::System.ArgumentException e)
			{
				string str = "malformed timestamp response: ";
				global::System.ArgumentException ex = e;
				throw new global::Org.BouncyCastle.Tsp.TspException(str + ((ex != null) ? ex.ToString() : null), e);
			}
			catch (global::System.InvalidCastException e2)
			{
				string str2 = "malformed timestamp response: ";
				global::System.InvalidCastException ex2 = e2;
				throw new global::Org.BouncyCastle.Tsp.TspException(str2 + ((ex2 != null) ? ex2.ToString() : null), e2);
			}
			return instance;
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x00016A10 File Offset: 0x00014C10
		public int Status
		{
			get
			{
				return this.resp.Status.Status.IntValue;
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00016A28 File Offset: 0x00014C28
		public string GetStatusString()
		{
			if (this.resp.Status.StatusString == null)
			{
				return null;
			}
			global::System.Text.StringBuilder statusStringBuf = new global::System.Text.StringBuilder();
			global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText text = this.resp.Status.StatusString;
			for (int i = 0; i != text.Count; i++)
			{
				statusStringBuf.Append(text[i].GetString());
			}
			return statusStringBuf.ToString();
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00016A8A File Offset: 0x00014C8A
		public global::Org.BouncyCastle.Asn1.Cmp.PkiFailureInfo GetFailInfo()
		{
			if (this.resp.Status.FailInfo == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.Cmp.PkiFailureInfo(this.resp.Status.FailInfo);
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x00016AB5 File Offset: 0x00014CB5
		public global::Org.BouncyCastle.Tsp.TimeStampToken TimeStampToken
		{
			get
			{
				return this.timeStampToken;
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00016AC0 File Offset: 0x00014CC0
		public void Validate(global::Org.BouncyCastle.Tsp.TimeStampRequest request)
		{
			global::Org.BouncyCastle.Tsp.TimeStampToken tok = this.TimeStampToken;
			if (tok != null)
			{
				global::Org.BouncyCastle.Tsp.TimeStampTokenInfo tstInfo = tok.TimeStampInfo;
				if (request.Nonce != null && !request.Nonce.Equals(tstInfo.Nonce))
				{
					throw new global::Org.BouncyCastle.Tsp.TspValidationException("response contains wrong nonce value.");
				}
				if (this.Status != 0 && this.Status != 1)
				{
					throw new global::Org.BouncyCastle.Tsp.TspValidationException("time stamp token found in failed request.");
				}
				if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(request.GetMessageImprintDigest(), tstInfo.GetMessageImprintDigest()))
				{
					throw new global::Org.BouncyCastle.Tsp.TspValidationException("response for different message imprint digest.");
				}
				if (!tstInfo.MessageImprintAlgOid.Equals(request.MessageImprintAlgOid))
				{
					throw new global::Org.BouncyCastle.Tsp.TspValidationException("response for different message imprint algorithm.");
				}
				global::Org.BouncyCastle.Asn1.Cms.Attribute attribute = tok.SignedAttributes[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAASigningCertificate];
				global::Org.BouncyCastle.Asn1.Cms.Attribute scV2 = tok.SignedAttributes[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAASigningCertificateV2];
				if (attribute == null && scV2 == null)
				{
					throw new global::Org.BouncyCastle.Tsp.TspValidationException("no signing certificate attribute present.");
				}
				if (attribute != null)
				{
				}
				if (request.ReqPolicy != null && !request.ReqPolicy.Equals(tstInfo.Policy))
				{
					throw new global::Org.BouncyCastle.Tsp.TspValidationException("TSA policy wrong for request.");
				}
			}
			else if (this.Status == 0 || this.Status == 1)
			{
				throw new global::Org.BouncyCastle.Tsp.TspValidationException("no time stamp token found and one expected.");
			}
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00016BD7 File Offset: 0x00014DD7
		public byte[] GetEncoded()
		{
			return this.resp.GetEncoded();
		}

		// Token: 0x040002AF RID: 687
		private global::Org.BouncyCastle.Asn1.Tsp.TimeStampResp resp;

		// Token: 0x040002B0 RID: 688
		private global::Org.BouncyCastle.Tsp.TimeStampToken timeStampToken;
	}
}
