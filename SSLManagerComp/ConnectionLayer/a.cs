using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Tls;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x02000034 RID: 52
	internal sealed class a : global::Org.BouncyCastle.Crypto.Tls.DefaultTlsServer
	{
		// Token: 0x06000127 RID: 295 RVA: 0x000116CC File Offset: 0x0000F8CC
		protected override global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion get_MaximumVersion()
		{
			short num = (short)664784880;
			short num2 = num;
			num = (short)484626416;
			switch (num2 == num)
			{
			}
			num = (short)1218772993;
			if (num != 0)
			{
			}
			num = (short)1776156672;
			if (num != 0)
			{
			}
			num = (short)1554186240;
			short num3 = num;
			return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv12;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0001177C File Offset: 0x0000F97C
		protected override global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion get_MinimumVersion()
		{
			short num = (short)11800344;
			short num2 = num;
			num = (short)107024152;
			switch (num2 == num)
			{
			}
			num = (short)938344449;
			if (num != 0)
			{
			}
			num = (short)1456996352;
			if (num != 0)
			{
			}
			num = (short)923467776;
			short num3 = num;
			return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv10;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00011828 File Offset: 0x0000FA28
		public a(global::Org.BouncyCastle.Crypto.Tls.Certificate A_0, global::Org.BouncyCastle.Crypto.Tls.Certificate A_1, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter A_2, global::Org.BouncyCastle.Crypto.Parameters.DHParameters A_3)
		{
			this.a = A_0;
			this.b = A_1;
			this.c = A_2;
			this.d = A_3;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00011858 File Offset: 0x0000FA58
		protected override global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials GetRsaSignerCredentials()
		{
			while (!global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(this.mContext))
			{
				short num = (short)1868364521;
				short num2 = num;
				num = (short)20839145;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)438042625;
					if (num != 0)
					{
					}
					num = (short)646119424;
					if (num != 0)
					{
					}
					num = (short)228982784;
					short num3 = num;
					return new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsSignerCredentials(this.mContext, this.a, this.c);
				}
				}
			}
			return new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsSignerCredentials(this.mContext, this.a, this.c, new global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm(2, 1));
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00011944 File Offset: 0x0000FB44
		protected override global::Org.BouncyCastle.Crypto.Tls.TlsEncryptionCredentials GetRsaEncryptionCredentials()
		{
			short num = (short)1118012405;
			short num2 = num;
			num = (short)546079733;
			switch (num2 == num)
			{
			}
			num = (short)1139867648;
			if (num != 0)
			{
			}
			num = (short)1893466113;
			if (num != 0)
			{
			}
			num = (short)1308622848;
			short num3 = num;
			return new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsEncryptionCredentials(this.mContext, this.a, this.c);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00011A04 File Offset: 0x0000FC04
		public override global::Org.BouncyCastle.Crypto.Tls.CertificateRequest GetCertificateRequest()
		{
			short num = (short)830603265;
			if (num != 0)
			{
			}
			num = (short)967444906;
			short num2 = num;
			num = (short)2098661802;
			switch (num2 == num)
			{
			}
			num = (short)1314979840;
			if (num != 0)
			{
			}
			num = (short)1024589824;
			short num3 = num;
			byte[] certificateTypes = new byte[]
			{
				1,
				2,
				64
			};
			global::System.Collections.IList supportedSignatureAlgorithms = null;
			if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSignatureAlgorithmsExtensionAllowed(this.mServerVersion))
			{
				supportedSignatureAlgorithms = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetDefaultSupportedSignatureAlgorithms();
			}
			global::System.Collections.IList certificateAuthorities = new global::System.Collections.ArrayList
			{
				this.b.GetCertificateAt(0).Subject
			};
			return new global::Org.BouncyCastle.Crypto.Tls.CertificateRequest(certificateTypes, supportedSignatureAlgorithms, certificateAuthorities);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00011AFC File Offset: 0x0000FCFC
		public override void NotifyClientCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate)
		{
			short num = (short)216006660;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_23A;
				case 1:
				{
					num = (short)548493500;
					short num3 = num;
					num = (short)473520316;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_221;
					default:
						num = (short)1679097856;
						if (num != 0)
						{
						}
						goto IL_AD;
					}
					break;
				}
				case 2:
					goto IL_FC;
				case 3:
					if (clientCertificate.IsEmpty)
					{
						num = (short)1332346881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1423048710;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 5:
					num = (short)173539331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure certificateAt = clientCertificate.GetCertificateAt(0);
					if (certificateAt.StartDate.ToDateTime() > global::System.DateTime.Now)
					{
						goto Block_2;
					}
					if (certificateAt.EndDate.ToDateTime() < global::System.DateTime.Now)
					{
						num = (short)407044098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1567621120;
					short num4 = num;
					num = (short)819003399;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					num = (short)988741633;
					if (num != 0)
					{
					}
					if (!clientCertificate.GetCertificateList()[0].Issuer.Equivalent(this.a.GetCertificateList()[0].Issuer))
					{
						goto IL_221;
					}
					return;
				case 8:
					goto IL_C4;
				}
				IL_49:
				if (clientCertificate != null)
				{
					num = (short)1629421573;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AD:
				num = (short)1584594952;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_221:
				num = (short)1892810752;
				num2 = (int)((global::System.IntPtr)num);
			}
			Block_2:
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(45);
			IL_C4:
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(41);
			IL_FC:
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(45);
			IL_23A:
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(42);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00011D48 File Offset: 0x0000FF48
		protected override global::Org.BouncyCastle.Crypto.Parameters.DHParameters GetDHParameters()
		{
			short num = (short)1570177024;
			short num2 = num;
			num = (short)690028545;
			if (num != 0)
			{
			}
			num = (short)386522149;
			short num3 = num;
			num = (short)714660901;
			switch (num3 == num)
			{
			}
			num = (short)843120640;
			if (num != 0)
			{
			}
			return this.d;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00011DF8 File Offset: 0x0000FFF8
		public override void NotifySecureRenegotiation(bool secureRenegotiation)
		{
			short num = (short)396951552;
			short num2 = num;
			num = (short)2134223004;
			short num3 = num;
			num = (short)1015130268;
			switch (num3 == num)
			{
			}
			num = (short)2048196609;
			if (num != 0)
			{
			}
			num = (short)61407232;
			if (num != 0)
			{
			}
		}

		// Token: 0x040000B0 RID: 176
		private readonly global::Org.BouncyCastle.Crypto.Tls.Certificate a;

		// Token: 0x040000B1 RID: 177
		private readonly global::Org.BouncyCastle.Crypto.Tls.Certificate b;

		// Token: 0x040000B2 RID: 178
		private readonly global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter c;

		// Token: 0x040000B3 RID: 179
		private readonly global::Org.BouncyCastle.Crypto.Parameters.DHParameters d;
	}
}
