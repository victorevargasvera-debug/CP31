using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using IACustomException;

namespace SSLMangrComp
{
	// Token: 0x02000007 RID: 7
	public static class CertificateValidator
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002E0C File Offset: 0x0000100C
		public static bool ValidateRemoteCertificate(global::System.Security.Cryptography.X509Certificates.X509Certificate2 clientCertificate, global::System.Security.Cryptography.X509Certificates.X509Chain chain, global::System.Net.Security.SslPolicyErrors sslPolicyErrors)
		{
			short num = (short)55443456;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 1:
					if (global::System.DateTime.Today > clientCertificate.NotAfter)
					{
						num = (short)1630994436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1143537667;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_A7;
				case 3:
					if (sslPolicyErrors != global::System.Net.Security.SslPolicyErrors.RemoteCertificateNotAvailable)
					{
						num = (short)1333264389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14D;
				case 4:
					goto IL_124;
				case 5:
					num = (short)395902983;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_6E;
				case 7:
					if (sslPolicyErrors == global::System.Net.Security.SslPolicyErrors.RemoteCertificateChainErrors)
					{
						num = (short)1603665922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_44:
				if (global::System.DateTime.Today < clientCertificate.NotBefore)
				{
					num = (short)1710751750;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)521863169;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_6E:
			throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_CE_CertificateNotYetActive);
			IL_A7:
			return global::SSLMangrComp.CertificateValidator.a(clientCertificate, chain);
			IL_124:
			num = (short)1483931649;
			if (num != 0)
			{
			}
			num = (short)1187497740;
			short num3 = num;
			num = (short)117229324;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_14D:
				num = (short)648806400;
				short num4 = num;
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_CE_ClientCertificateRequestDenied);
			}
			default:
				num = (short)1637089280;
				if (num != 0)
				{
				}
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_CE_CertificateExpired);
			}
			return true;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003004 File Offset: 0x00001204
		private static bool a(global::System.Security.Cryptography.X509Certificates.X509Certificate2 A_0, global::System.Security.Cryptography.X509Certificates.X509Chain A_1)
		{
			short num = (short)1972764673;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_155;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 2:
					num = (short)1353252870;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					global::System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator enumerator;
					if (!enumerator.MoveNext())
					{
						num = (short)50069504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)203161604;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					global::System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator enumerator;
					if (enumerator.Current.Certificate.Equals(A_0))
					{
						num = (short)697565193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11A;
				}
				case 5:
				{
					num = (short)1723154332;
					short num3 = num;
					num = (short)318783388;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num = (short)448135168;
						if (num != 0)
						{
						}
						if (A_1.ChainElements.Count > 0)
						{
							num = (short)1610547208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					break;
				}
				case 6:
					num = (short)900595713;
					if (num != 0)
					{
					}
					if (A_1 != null)
					{
						num = (short)1620312071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 7:
					num = (short)345178117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					global::System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator enumerator = A_1.ChainElements.GetEnumerator();
					num = (short)676921354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					return true;
				case 10:
				{
					num = (short)1641021440;
					short num4 = num;
					goto IL_11A;
				}
				}
				IL_51:
				if (A_0 != null)
				{
					num = (short)1866530818;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_11A:
				num = (short)1535508483;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_155:
			return false;
		}
	}
}
