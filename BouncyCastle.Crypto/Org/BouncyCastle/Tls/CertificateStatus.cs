using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000099 RID: 153
	public sealed class CertificateStatus
	{
		// Token: 0x0600064F RID: 1615 RVA: 0x0001A692 File Offset: 0x00018892
		public CertificateStatus(short statusType, object response)
		{
			if (!global::Org.BouncyCastle.Tls.CertificateStatus.IsCorrectType(statusType, response))
			{
				throw new global::System.ArgumentException("not an instance of the correct type", "response");
			}
			this.m_statusType = statusType;
			this.m_response = response;
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x0001A6C1 File Offset: 0x000188C1
		public short StatusType
		{
			get
			{
				return this.m_statusType;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x0001A6C9 File Offset: 0x000188C9
		public object Response
		{
			get
			{
				return this.m_response;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x0001A6D1 File Offset: 0x000188D1
		public global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse OcspResponse
		{
			get
			{
				if (!global::Org.BouncyCastle.Tls.CertificateStatus.IsCorrectType(1, this.m_response))
				{
					throw new global::System.InvalidOperationException("'response' is not an OCSPResponse");
				}
				return (global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse)this.m_response;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x0001A6F7 File Offset: 0x000188F7
		public global::System.Collections.IList OcspResponseList
		{
			get
			{
				if (!global::Org.BouncyCastle.Tls.CertificateStatus.IsCorrectType(2, this.m_response))
				{
					throw new global::System.InvalidOperationException("'response' is not an OCSPResponseList");
				}
				return (global::System.Collections.IList)this.m_response;
			}
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0001A720 File Offset: 0x00018920
		public void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(this.m_statusType, output);
			short statusType = this.m_statusType;
			if (statusType != 1)
			{
				if (statusType == 2)
				{
					global::System.Collections.IList list = (global::System.Collections.IList)this.m_response;
					global::System.Collections.IList derEncodings = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(list.Count);
					long totalLength = 0L;
					foreach (object obj in list)
					{
						global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse ocspResponse = (global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse)obj;
						if (ocspResponse == null)
						{
							derEncodings.Add(global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes);
						}
						else
						{
							byte[] derEncoding = ocspResponse.GetEncoded("DER");
							derEncodings.Add(derEncoding);
							totalLength += (long)derEncoding.Length;
						}
						totalLength += 3L;
					}
					global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint24(totalLength);
					global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint24((int)totalLength, output);
					using (global::System.Collections.IEnumerator enumerator = derEncodings.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj2 = enumerator.Current;
							global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque24((byte[])obj2, output);
						}
						return;
					}
				}
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque24(((global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse)this.m_response).GetEncoded("DER"), output);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0001A858 File Offset: 0x00018A58
		public static global::Org.BouncyCastle.Tls.CertificateStatus Parse(global::Org.BouncyCastle.Tls.TlsContext context, global::System.IO.Stream input)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			global::Org.BouncyCastle.Tls.Certificate peerCertificate = securityParameters.PeerCertificate;
			if (peerCertificate == null || peerCertificate.IsEmpty || peerCertificate.CertificateType != 0)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			int certificateCount = peerCertificate.Length;
			int statusRequestVersion = securityParameters.StatusRequestVersion;
			short status_type = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(input);
			object response;
			if (status_type != 1)
			{
				if (status_type != 2)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
				}
				global::Org.BouncyCastle.Tls.CertificateStatus.RequireStatusRequestVersion(2, statusRequestVersion);
				global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque24(input, 1), false);
				global::System.Collections.IList ocspResponseList = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				while (buf.Position < buf.Length)
				{
					if (ocspResponseList.Count >= certificateCount)
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
					}
					int length = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint24(buf);
					if (length < 1)
					{
						ocspResponseList.Add(null);
					}
					else
					{
						global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse ocspResponse = global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse.GetInstance(global::Org.BouncyCastle.Tls.TlsUtilities.ReadDerObject(global::Org.BouncyCastle.Tls.TlsUtilities.ReadFully(length, buf)));
						ocspResponseList.Add(ocspResponse);
					}
				}
				response = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(ocspResponseList);
			}
			else
			{
				global::Org.BouncyCastle.Tls.CertificateStatus.RequireStatusRequestVersion(1, statusRequestVersion);
				response = global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse.GetInstance(global::Org.BouncyCastle.Tls.TlsUtilities.ReadDerObject(global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque24(input, 1)));
			}
			return new global::Org.BouncyCastle.Tls.CertificateStatus(status_type, response);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0001A961 File Offset: 0x00018B61
		private static bool IsCorrectType(short statusType, object response)
		{
			if (statusType == 1)
			{
				return response is global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse;
			}
			if (statusType != 2)
			{
				throw new global::System.ArgumentException("unsupported CertificateStatusType", "statusType");
			}
			return global::Org.BouncyCastle.Tls.CertificateStatus.IsOcspResponseList(response);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0001A990 File Offset: 0x00018B90
		private static bool IsOcspResponseList(object response)
		{
			if (!(response is global::System.Collections.IList))
			{
				return false;
			}
			global::System.Collections.IList v = (global::System.Collections.IList)response;
			if (v.Count < 1)
			{
				return false;
			}
			foreach (object e in v)
			{
				if (e != null && !(e is global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0001AA0C File Offset: 0x00018C0C
		private static void RequireStatusRequestVersion(int minVersion, int statusRequestVersion)
		{
			if (statusRequestVersion < minVersion)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
		}

		// Token: 0x04000348 RID: 840
		private readonly short m_statusType;

		// Token: 0x04000349 RID: 841
		private readonly object m_response;
	}
}
