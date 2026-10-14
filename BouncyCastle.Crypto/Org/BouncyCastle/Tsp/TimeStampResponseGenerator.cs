using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Tsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Tsp
{
	// Token: 0x0200007D RID: 125
	public class TimeStampResponseGenerator
	{
		// Token: 0x06000504 RID: 1284 RVA: 0x00016BE4 File Offset: 0x00014DE4
		public TimeStampResponseGenerator(global::Org.BouncyCastle.Tsp.TimeStampTokenGenerator tokenGenerator, global::System.Collections.IList acceptedAlgorithms) : this(tokenGenerator, acceptedAlgorithms, null, null)
		{
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00016BF0 File Offset: 0x00014DF0
		public TimeStampResponseGenerator(global::Org.BouncyCastle.Tsp.TimeStampTokenGenerator tokenGenerator, global::System.Collections.IList acceptedAlgorithms, global::System.Collections.IList acceptedPolicy) : this(tokenGenerator, acceptedAlgorithms, acceptedPolicy, null)
		{
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00016BFC File Offset: 0x00014DFC
		public TimeStampResponseGenerator(global::Org.BouncyCastle.Tsp.TimeStampTokenGenerator tokenGenerator, global::System.Collections.IList acceptedAlgorithms, global::System.Collections.IList acceptedPolicies, global::System.Collections.IList acceptedExtensions)
		{
			this.tokenGenerator = tokenGenerator;
			this.acceptedAlgorithms = acceptedAlgorithms;
			this.acceptedPolicies = acceptedPolicies;
			this.acceptedExtensions = acceptedExtensions;
			this.statusStrings = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00016C2C File Offset: 0x00014E2C
		private void AddStatusString(string statusString)
		{
			this.statusStrings.Add(new global::Org.BouncyCastle.Asn1.DerUtf8String(statusString));
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00016C3F File Offset: 0x00014E3F
		private void SetFailInfoField(int field)
		{
			this.failInfo |= field;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00016C50 File Offset: 0x00014E50
		private global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo GetPkiStatusInfo()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				new global::Org.BouncyCastle.Asn1.DerInteger((int)this.status)
			});
			if (this.statusStrings.Count > 0)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText(new global::Org.BouncyCastle.Asn1.DerSequence(this.statusStrings)));
			}
			if (this.failInfo != 0)
			{
				v.Add(new global::Org.BouncyCastle.Tsp.TimeStampResponseGenerator.FailInfo(this.failInfo));
			}
			return new global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo(new global::Org.BouncyCastle.Asn1.DerSequence(v));
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00016CBF File Offset: 0x00014EBF
		public global::Org.BouncyCastle.Tsp.TimeStampResponse Generate(global::Org.BouncyCastle.Tsp.TimeStampRequest request, global::Org.BouncyCastle.Math.BigInteger serialNumber, global::System.DateTime genTime)
		{
			return this.Generate(request, serialNumber, new global::Org.BouncyCastle.Utilities.Date.DateTimeObject(genTime));
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00016CD0 File Offset: 0x00014ED0
		public global::Org.BouncyCastle.Tsp.TimeStampResponse Generate(global::Org.BouncyCastle.Tsp.TimeStampRequest request, global::Org.BouncyCastle.Math.BigInteger serialNumber, global::Org.BouncyCastle.Utilities.Date.DateTimeObject genTime)
		{
			global::Org.BouncyCastle.Asn1.Tsp.TimeStampResp resp;
			try
			{
				if (genTime == null)
				{
					throw new global::Org.BouncyCastle.Tsp.TspValidationException("The time source is not available.", 512);
				}
				request.Validate(this.acceptedAlgorithms, this.acceptedPolicies, this.acceptedExtensions);
				this.status = global::Org.BouncyCastle.Asn1.Cmp.PkiStatus.Granted;
				this.AddStatusString("Operation Okay");
				global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo pkiStatusInfo = this.GetPkiStatusInfo();
				global::Org.BouncyCastle.Asn1.Cms.ContentInfo tstTokenContentInfo;
				try
				{
					tstTokenContentInfo = global::Org.BouncyCastle.Asn1.Cms.ContentInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(this.tokenGenerator.Generate(request, serialNumber, genTime.Value).ToCmsSignedData().GetEncoded()));
				}
				catch (global::System.IO.IOException e)
				{
					throw new global::Org.BouncyCastle.Tsp.TspException("Timestamp token received cannot be converted to ContentInfo", e);
				}
				resp = new global::Org.BouncyCastle.Asn1.Tsp.TimeStampResp(pkiStatusInfo, tstTokenContentInfo);
			}
			catch (global::Org.BouncyCastle.Tsp.TspValidationException e2)
			{
				this.status = global::Org.BouncyCastle.Asn1.Cmp.PkiStatus.Rejection;
				this.SetFailInfoField(e2.FailureCode);
				this.AddStatusString(e2.Message);
				resp = new global::Org.BouncyCastle.Asn1.Tsp.TimeStampResp(this.GetPkiStatusInfo(), null);
			}
			global::Org.BouncyCastle.Tsp.TimeStampResponse result;
			try
			{
				result = new global::Org.BouncyCastle.Tsp.TimeStampResponse(resp);
			}
			catch (global::System.IO.IOException e3)
			{
				throw new global::Org.BouncyCastle.Tsp.TspException("created badly formatted response!", e3);
			}
			return result;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00016DD8 File Offset: 0x00014FD8
		public global::Org.BouncyCastle.Tsp.TimeStampResponse GenerateGrantedResponse(global::Org.BouncyCastle.Tsp.TimeStampRequest request, global::Org.BouncyCastle.Math.BigInteger serialNumber, global::Org.BouncyCastle.Utilities.Date.DateTimeObject genTime, string statusString, global::Org.BouncyCastle.Asn1.X509.X509Extensions additionalExtensions)
		{
			global::Org.BouncyCastle.Asn1.Tsp.TimeStampResp resp;
			try
			{
				if (genTime == null)
				{
					throw new global::Org.BouncyCastle.Tsp.TspValidationException("The time source is not available.", 512);
				}
				request.Validate(this.acceptedAlgorithms, this.acceptedPolicies, this.acceptedExtensions);
				this.status = global::Org.BouncyCastle.Asn1.Cmp.PkiStatus.Granted;
				this.AddStatusString(statusString);
				global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo pkiStatusInfo = this.GetPkiStatusInfo();
				global::Org.BouncyCastle.Asn1.Cms.ContentInfo tstTokenContentInfo;
				try
				{
					tstTokenContentInfo = global::Org.BouncyCastle.Asn1.Cms.ContentInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(this.tokenGenerator.Generate(request, serialNumber, genTime.Value, additionalExtensions).ToCmsSignedData().GetEncoded()));
				}
				catch (global::System.IO.IOException e)
				{
					throw new global::Org.BouncyCastle.Tsp.TspException("Timestamp token received cannot be converted to ContentInfo", e);
				}
				resp = new global::Org.BouncyCastle.Asn1.Tsp.TimeStampResp(pkiStatusInfo, tstTokenContentInfo);
			}
			catch (global::Org.BouncyCastle.Tsp.TspValidationException e2)
			{
				this.status = global::Org.BouncyCastle.Asn1.Cmp.PkiStatus.Rejection;
				this.SetFailInfoField(e2.FailureCode);
				this.AddStatusString(e2.Message);
				resp = new global::Org.BouncyCastle.Asn1.Tsp.TimeStampResp(this.GetPkiStatusInfo(), null);
			}
			global::Org.BouncyCastle.Tsp.TimeStampResponse result;
			try
			{
				result = new global::Org.BouncyCastle.Tsp.TimeStampResponse(resp);
			}
			catch (global::System.IO.IOException e3)
			{
				throw new global::Org.BouncyCastle.Tsp.TspException("created badly formatted response!", e3);
			}
			return result;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00016EE0 File Offset: 0x000150E0
		public global::Org.BouncyCastle.Tsp.TimeStampResponse GenerateFailResponse(global::Org.BouncyCastle.Asn1.Cmp.PkiStatus status, int failInfoField, string statusString)
		{
			this.status = status;
			this.SetFailInfoField(failInfoField);
			if (statusString != null)
			{
				this.AddStatusString(statusString);
			}
			global::Org.BouncyCastle.Asn1.Tsp.TimeStampResp resp = new global::Org.BouncyCastle.Asn1.Tsp.TimeStampResp(this.GetPkiStatusInfo(), null);
			global::Org.BouncyCastle.Tsp.TimeStampResponse result;
			try
			{
				result = new global::Org.BouncyCastle.Tsp.TimeStampResponse(resp);
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Tsp.TspException("created badly formatted response!", e);
			}
			return result;
		}

		// Token: 0x040002B1 RID: 689
		private global::Org.BouncyCastle.Asn1.Cmp.PkiStatus status;

		// Token: 0x040002B2 RID: 690
		private global::Org.BouncyCastle.Asn1.Asn1EncodableVector statusStrings;

		// Token: 0x040002B3 RID: 691
		private int failInfo;

		// Token: 0x040002B4 RID: 692
		private global::Org.BouncyCastle.Tsp.TimeStampTokenGenerator tokenGenerator;

		// Token: 0x040002B5 RID: 693
		private global::System.Collections.IList acceptedAlgorithms;

		// Token: 0x040002B6 RID: 694
		private global::System.Collections.IList acceptedPolicies;

		// Token: 0x040002B7 RID: 695
		private global::System.Collections.IList acceptedExtensions;

		// Token: 0x0200079C RID: 1948
		private class FailInfo : global::Org.BouncyCastle.Asn1.DerBitString
		{
			// Token: 0x060044F7 RID: 17655 RVA: 0x001324EF File Offset: 0x001306EF
			internal FailInfo(int failInfoValue) : base(failInfoValue)
			{
			}
		}
	}
}
