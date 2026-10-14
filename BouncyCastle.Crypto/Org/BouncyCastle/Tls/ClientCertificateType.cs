using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000A4 RID: 164
	public abstract class ClientCertificateType
	{
		// Token: 0x06000674 RID: 1652 RVA: 0x0001ADF4 File Offset: 0x00018FF4
		public static string GetName(short clientCertificateType)
		{
			switch (clientCertificateType)
			{
			case 1:
				return "rsa_sign";
			case 2:
				return "dss_sign";
			case 3:
				return "rsa_fixed_dh";
			case 4:
				return "dss_fixed_dh";
			case 5:
				return "rsa_ephemeral_dh_RESERVED";
			case 6:
				return "dss_ephemeral_dh_RESERVED";
			default:
				if (clientCertificateType == 20)
				{
					return "fortezza_dms_RESERVED";
				}
				switch (clientCertificateType)
				{
				case 64:
					return "ecdsa_sign";
				case 65:
					return "rsa_fixed_ecdh";
				case 66:
					return "ecdsa_fixed_ecdh";
				case 67:
					return "gost_sign256";
				case 68:
					return "gost_sign512";
				default:
					return "UNKNOWN";
				}
				break;
			}
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0001AE92 File Offset: 0x00019092
		public static string GetText(short clientCertificateType)
		{
			return global::Org.BouncyCastle.Tls.ClientCertificateType.GetName(clientCertificateType) + "(" + clientCertificateType.ToString() + ")";
		}

		// Token: 0x040004A5 RID: 1189
		public const short rsa_sign = 1;

		// Token: 0x040004A6 RID: 1190
		public const short dss_sign = 2;

		// Token: 0x040004A7 RID: 1191
		public const short rsa_fixed_dh = 3;

		// Token: 0x040004A8 RID: 1192
		public const short dss_fixed_dh = 4;

		// Token: 0x040004A9 RID: 1193
		public const short rsa_ephemeral_dh_RESERVED = 5;

		// Token: 0x040004AA RID: 1194
		public const short dss_ephemeral_dh_RESERVED = 6;

		// Token: 0x040004AB RID: 1195
		public const short fortezza_dms_RESERVED = 20;

		// Token: 0x040004AC RID: 1196
		public const short ecdsa_sign = 64;

		// Token: 0x040004AD RID: 1197
		public const short rsa_fixed_ecdh = 65;

		// Token: 0x040004AE RID: 1198
		public const short ecdsa_fixed_ecdh = 66;

		// Token: 0x040004AF RID: 1199
		public const short gost_sign256 = 67;

		// Token: 0x040004B0 RID: 1200
		public const short gost_sign512 = 68;
	}
}
