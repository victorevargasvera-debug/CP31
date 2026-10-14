using System;
using System.Net;
using System.Security;

namespace MotorolaSolutions.RadioCentral.CodeplugExchangeLibrary.Extensions
{
	// Token: 0x02000003 RID: 3
	public static class SecureStringExtensions
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public static global::System.Security.SecureString ToSecureString(this string @string)
		{
			short num = (short)2135818240;
			short num2 = num;
			num = (short)1700986881;
			if (num != 0)
			{
			}
			num = (short)724670467;
			short num3 = num;
			num = (short)768841731;
			switch (num3 == num)
			{
			}
			num = (short)1810169856;
			if (num != 0)
			{
			}
			return new global::System.Net.NetworkCredential(string.Empty, @string).SecurePassword;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021D4 File Offset: 0x000003D4
		public static string ToPlainString(this global::System.Security.SecureString secureString)
		{
			short num = (short)1100611584;
			short num2 = num;
			num = (short)672227287;
			short num3 = num;
			num = (short)982278103;
			switch (num3 == num)
			{
			}
			num = (short)1416364033;
			if (num != 0)
			{
			}
			num = (short)1076953088;
			if (num != 0)
			{
			}
			return new global::System.Net.NetworkCredential(string.Empty, secureString).Password;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000228C File Offset: 0x0000048C
		public static bool Compare(this global::System.Security.SecureString secureString, global::System.Security.SecureString secureStringToCompare)
		{
			short num = (short)417136640;
			short num2 = num;
			num = (short)1050455086;
			short num3 = num;
			num = (short)1088334894;
			switch (num3 == num)
			{
			}
			num = (short)617938945;
			if (num != 0)
			{
			}
			num = (short)1607073792;
			if (num != 0)
			{
			}
			return secureString.ToPlainString() == secureStringToCompare.ToPlainString();
		}
	}
}
