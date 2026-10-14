using System;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;

namespace Motorola.Security.SamlCommonUtility
{
	// Token: 0x02000015 RID: 21
	public abstract class NameResolver
	{
		// Token: 0x0600004B RID: 75 RVA: 0x000062A8 File Offset: 0x000044A8
		public static bool IsNameResolveable(string systemName, string accountName)
		{
			short num = (short)1169883136;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				byte[] a_;
				uint num3;
				global::System.Text.StringBuilder stringBuilder;
				uint capacity;
				int num5;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						global::Motorola.Security.SamlCommonUtility.NameResolver.SID_NAME_USE sid_NAME_USE;
						if (!global::Motorola.Security.SamlCommonUtility.NameResolver.a.LookupAccountName(null, accountName, a_, ref num3, stringBuilder, ref capacity, out sid_NAME_USE))
						{
							num = (short)275054592;
							short num4 = num;
							num = (short)1332543489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_253;
					}
					case 1:
					{
						num5 = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
						num = (short)1319898644;
						short num6 = num;
						num = (short)953290260;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C3;
						default:
							num = (short)769261568;
							if (num != 0)
							{
							}
							num = (short)2117926914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_251;
					case 3:
						if (num5 == 1004)
						{
							num = (short)566099974;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_253;
					case 4:
						if (num5 != 122)
						{
							num = (short)1397555201;
							if (num != 0)
							{
							}
							num = (short)260243463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B1;
					case 5:
						num5 = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
						num = (short)1326317572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_B1;
					case 7:
						num = (short)1076690947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::Motorola.Security.SamlCommonUtility.NameResolver.SID_NAME_USE sid_NAME_USE;
						if (!global::Motorola.Security.SamlCommonUtility.NameResolver.a.LookupAccountName(systemName, accountName, a_, ref num3, stringBuilder, ref capacity, out sid_NAME_USE))
						{
							num = (short)893452293;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_253;
					}
					}
					goto IL_53;
					IL_C3:
					num = (short)1357512704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B1:
					a_ = new byte[num3];
					stringBuilder.EnsureCapacity((int)capacity);
					num5 = 0;
					goto IL_C3;
				}
				IL_251:
				IL_253:
				return num5 == 0;
				IL_53:
				a_ = null;
				num3 = 0U;
				stringBuilder = new global::System.Text.StringBuilder(64);
				capacity = (uint)stringBuilder.Capacity;
				num5 = 0;
				num = (short)1448149000;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00006510 File Offset: 0x00004710
		public static bool IsNameResolveable(string accountName)
		{
			short num = (short)355361975;
			short num2 = num;
			num = (short)885089463;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1866268672;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)880082945;
			if (num != 0)
			{
			}
			num = (short)301924352;
			if (num != 0)
			{
			}
			return global::Motorola.Security.SamlCommonUtility.NameResolver.IsNameResolveable(null, accountName);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000065C0 File Offset: 0x000047C0
		public static global::System.Security.Principal.SecurityIdentifier ResolveName(string systemName, string accountName, out string outDomainName)
		{
			short num = (short)1697382400;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				byte[] array;
				uint num3;
				global::System.Text.StringBuilder stringBuilder;
				uint capacity;
				global::System.Security.Principal.SecurityIdentifier result;
				int num6;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						global::Motorola.Security.SamlCommonUtility.NameResolver.SID_NAME_USE sid_NAME_USE;
						if (global::Motorola.Security.SamlCommonUtility.NameResolver.a.LookupAccountName(null, accountName, array, ref num3, stringBuilder, ref capacity, out sid_NAME_USE))
						{
							num = (short)1237712896;
							short num4 = num;
							num = (short)247070721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 1:
					{
						outDomainName = stringBuilder.ToString();
						result = new global::System.Security.Principal.SecurityIdentifier(array, 0);
						num = (short)1725295905;
						short num5 = num;
						num = (short)1540746529;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C8;
						default:
							num = (short)1181089792;
							if (num != 0)
							{
							}
							num = (short)554237954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_237;
					case 3:
						if (num6 == 1004)
						{
							num = (short)2066743302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						if (num6 != 122)
						{
							num = (short)45940743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B5;
					case 5:
						num6 = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
						num = (short)514129924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_B5;
					case 7:
						num = (short)1355153411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::Motorola.Security.SamlCommonUtility.NameResolver.SID_NAME_USE sid_NAME_USE;
						if (!global::Motorola.Security.SamlCommonUtility.NameResolver.a.LookupAccountName(systemName, accountName, array, ref num3, stringBuilder, ref capacity, out sid_NAME_USE))
						{
							num = (short)562626565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					}
					goto IL_52;
					IL_C8:
					num = (short)2084831232;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B5:
					array = new byte[num3];
					stringBuilder.EnsureCapacity((int)capacity);
					num6 = 0;
					goto IL_C8;
				}
				IL_237:
				num = (short)1363345409;
				if (num != 0)
				{
				}
				return result;
				IL_52:
				result = null;
				outDomainName = null;
				array = null;
				num3 = 0U;
				stringBuilder = new global::System.Text.StringBuilder(64);
				capacity = (uint)stringBuilder.Capacity;
				num6 = 0;
				num = (short)1702559752;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0400008D RID: 141
		private const int a = 0;

		// Token: 0x0400008E RID: 142
		private const int b = 122;

		// Token: 0x0400008F RID: 143
		private const int c = 1004;

		// Token: 0x02000016 RID: 22
		public enum SID_NAME_USE
		{
			// Token: 0x04000091 RID: 145
			SidTypeUser = 1,
			// Token: 0x04000092 RID: 146
			SidTypeGroup,
			// Token: 0x04000093 RID: 147
			SidTypeDomain,
			// Token: 0x04000094 RID: 148
			SidTypeAlias,
			// Token: 0x04000095 RID: 149
			SidTypeWellKnownGroup,
			// Token: 0x04000096 RID: 150
			SidTypeDeletedAccount,
			// Token: 0x04000097 RID: 151
			SidTypeInvalid,
			// Token: 0x04000098 RID: 152
			SidTypeUnknown,
			// Token: 0x04000099 RID: 153
			SidTypeComputer
		}

		// Token: 0x02000017 RID: 23
		private static class a
		{
			// Token: 0x0600004F RID: 79
			[global::System.Runtime.InteropServices.DllImport("advapi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
			public static extern bool LookupAccountName([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] string A_0, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] string A_1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPArray)] byte[] A_2, ref uint A_3, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] global::System.Text.StringBuilder A_4, ref uint A_5, out global::Motorola.Security.SamlCommonUtility.NameResolver.SID_NAME_USE A_6);

			// Token: 0x06000050 RID: 80
			[global::System.Runtime.InteropServices.DllImport("kernel32.dll")]
			public static extern global::System.IntPtr LocalFree(global::System.IntPtr A_0);
		}
	}
}
