using System;
using System.Collections.Generic;
using CodeplugExchangeLibrary.Exceptions;
using Ionic.Zip;

namespace CodeplugExchangeLibrary.Extensions
{
	// Token: 0x02000009 RID: 9
	internal static class ZipFileExtensions
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00003EC0 File Offset: 0x000020C0
		internal static bool IsValidCodeplugExchangeArchive(this global::Ionic.Zip.ZipFile zipFile, bool checkPassword = true)
		{
			short num = (short)799059065;
			short num2 = num;
			num = (short)461089913;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)475070464;
				if (num != 0)
				{
				}
				num = (short)91226116;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)90701825;
						if (num != 0)
						{
						}
						num = (short)727121922;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1425014784;
						short num4 = num;
						num = (short)1442054149;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (global::CodeplugExchangeLibrary.Extensions.ZipFileExtensions.b(zipFile))
						{
							num = (short)934936577;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						goto IL_10F;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_89;
						}
						continue;
					case 5:
						if (checkPassword)
						{
							num = (short)1900412931;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					IL_89:
					if (!global::CodeplugExchangeLibrary.Extensions.ZipFileExtensions.a(zipFile, 2))
					{
						return false;
					}
					num = (short)819527680;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_10F:
				break;
			}
			}
			return global::CodeplugExchangeLibrary.Extensions.ZipFileExtensions.a(zipFile);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000404C File Offset: 0x0000224C
		private static bool a(global::Ionic.Zip.ZipFile A_0, int A_1)
		{
			short num = (short)1661507335;
			short num2 = num;
			num = (short)96245511;
			switch (num2 == num)
			{
			default:
			{
				num = (short)273547264;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)942931969;
			if (num != 0)
			{
			}
			num = (short)2061238272;
			if (num != 0)
			{
			}
			return A_0.Count == A_1;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00004100 File Offset: 0x00002300
		private static bool b(global::Ionic.Zip.ZipFile A_0)
		{
			int a_ = 9;
			short num;
			if (A_0.ContainsEntry(global::CodeplugExchangeLibrary.Exceptions.InvalidCxfFilePasswordException.b("ꗅꟇ껉꧋뻍볏ꟑ돓믗럙곛", a_)))
			{
				num = (short)1406964475;
				short num2 = num;
				num = (short)2077266683;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)117112833;
					if (num != 0)
					{
					}
					num = (short)451608576;
					if (num != 0)
					{
					}
					return A_0.ContainsEntry(global::CodeplugExchangeLibrary.Exceptions.InvalidCxfFilePasswordException.b("ꯅ귇뻉귋꫍뇏ꛑ뗓", a_));
				}
			}
			num = (short)2103902208;
			short num3 = num;
			return false;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000041E4 File Offset: 0x000023E4
		private static bool a(global::Ionic.Zip.ZipFile A_0)
		{
			global::System.Collections.Generic.IEnumerator<global::Ionic.Zip.ZipEntry> enumerator = A_0.GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)1396965381;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)925499394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!enumerator.MoveNext())
						{
							num = (short)297598976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)443875334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_14B;
					case 3:
						goto IL_12F;
					case 4:
						result = false;
						num = (short)1673723907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_A6;
						}
						continue;
					case 6:
						if (!enumerator.Current.UsesEncryption)
						{
							num = (short)34209796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					IL_A8:
					num = (short)1719992321;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A6:
					goto IL_A8;
				}
				IL_12F:
				return result;
				IL_14B:
				goto IL_09;
			}
			finally
			{
				num = (short)1637810177;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_204;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_180;
						}
						continue;
					case 2:
					{
						num = (short)412265637;
						short num3 = num;
						num = (short)414690469;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_204;
						default:
							num = (short)729022464;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							num = (short)350552064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_180:
					if (enumerator == null)
					{
						break;
					}
					num = (short)2359298;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_204:;
			}
			return result;
			IL_09:
			num = (short)2076114945;
			if (num != 0)
			{
			}
			num = (short)246349824;
			short num4 = num;
			return A_0.Count != 0;
		}
	}
}
