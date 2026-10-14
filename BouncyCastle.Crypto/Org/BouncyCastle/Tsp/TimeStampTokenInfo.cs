using System;
using Org.BouncyCastle.Asn1.Tsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Tsp
{
	// Token: 0x02000081 RID: 129
	public class TimeStampTokenInfo
	{
		// Token: 0x0600052C RID: 1324 RVA: 0x00017A50 File Offset: 0x00015C50
		public TimeStampTokenInfo(global::Org.BouncyCastle.Asn1.Tsp.TstInfo tstInfo)
		{
			this.tstInfo = tstInfo;
			try
			{
				this.genTime = tstInfo.GenTime.ToDateTime();
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Tsp.TspException("unable to parse genTime field: " + e.Message);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x00017AA4 File Offset: 0x00015CA4
		public bool IsOrdered
		{
			get
			{
				return this.tstInfo.Ordering.IsTrue;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00017AB6 File Offset: 0x00015CB6
		public global::Org.BouncyCastle.Asn1.Tsp.Accuracy Accuracy
		{
			get
			{
				return this.tstInfo.Accuracy;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00017AC3 File Offset: 0x00015CC3
		public global::System.DateTime GenTime
		{
			get
			{
				return this.genTime;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00017ACB File Offset: 0x00015CCB
		public global::Org.BouncyCastle.Tsp.GenTimeAccuracy GenTimeAccuracy
		{
			get
			{
				if (this.Accuracy != null)
				{
					return new global::Org.BouncyCastle.Tsp.GenTimeAccuracy(this.Accuracy);
				}
				return null;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x00017AE2 File Offset: 0x00015CE2
		public string Policy
		{
			get
			{
				return this.tstInfo.Policy.Id;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x00017AF4 File Offset: 0x00015CF4
		public global::Org.BouncyCastle.Math.BigInteger SerialNumber
		{
			get
			{
				return this.tstInfo.SerialNumber.Value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00017B06 File Offset: 0x00015D06
		public global::Org.BouncyCastle.Asn1.X509.GeneralName Tsa
		{
			get
			{
				return this.tstInfo.Tsa;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00017B13 File Offset: 0x00015D13
		public global::Org.BouncyCastle.Math.BigInteger Nonce
		{
			get
			{
				if (this.tstInfo.Nonce != null)
				{
					return this.tstInfo.Nonce.Value;
				}
				return null;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00017B34 File Offset: 0x00015D34
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlgorithm
		{
			get
			{
				return this.tstInfo.MessageImprint.HashAlgorithm;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00017B46 File Offset: 0x00015D46
		public string MessageImprintAlgOid
		{
			get
			{
				return this.tstInfo.MessageImprint.HashAlgorithm.Algorithm.Id;
			}
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00017B62 File Offset: 0x00015D62
		public byte[] GetMessageImprintDigest()
		{
			return this.tstInfo.MessageImprint.GetHashedMessage();
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00017B74 File Offset: 0x00015D74
		public byte[] GetEncoded()
		{
			return this.tstInfo.GetEncoded();
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00017B81 File Offset: 0x00015D81
		public global::Org.BouncyCastle.Asn1.Tsp.TstInfo TstInfo
		{
			get
			{
				return this.tstInfo;
			}
		}

		// Token: 0x040002CC RID: 716
		private global::Org.BouncyCastle.Asn1.Tsp.TstInfo tstInfo;

		// Token: 0x040002CD RID: 717
		private global::System.DateTime genTime;
	}
}
