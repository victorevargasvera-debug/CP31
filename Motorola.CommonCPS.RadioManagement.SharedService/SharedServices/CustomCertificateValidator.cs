using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200001B RID: 27
	public static class CustomCertificateValidator
	{
		// Token: 0x06000137 RID: 311 RVA: 0x0000AE88 File Offset: 0x00009088
		public static void ValidatorCertificate()
		{
			short num = (short)1822507989;
			short num2 = num;
			num = (short)2033664981;
			switch (num2 == num)
			{
			}
			num = (short)907214849;
			if (num != 0)
			{
			}
			num = (short)1174011904;
			short num3 = num;
			num = (short)1863450624;
			if (num != 0)
			{
			}
			global::System.Net.ServicePointManager.Expect100Continue = true;
			global::System.Net.ServicePointManager.SecurityProtocol = global::System.Net.SecurityProtocolType.Tls12;
			global::System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate(object s, global::System.Security.Cryptography.X509Certificates.X509Certificate certificate, global::System.Security.Cryptography.X509Certificates.X509Chain chain, global::System.Net.Security.SslPolicyErrors sslPolicyErrors)
			{
				short num4 = (short)326205249;
				short num5 = num4;
				num4 = (short)364805953;
				switch (num5 == num4)
				{
				}
				num4 = (short)359792640;
				if (num4 != 0)
				{
				}
				num4 = (short)989659136;
				short num6 = num4;
				num4 = (short)678952961;
				if (num4 != 0)
				{
				}
				return true;
			};
		}
	}
}
