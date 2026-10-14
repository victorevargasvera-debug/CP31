using System;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000EB RID: 235
	public class UpgradeRadioValidator
	{
		// Token: 0x06000DDD RID: 3549 RVA: 0x00130EB0 File Offset: 0x0012F0B0
		public static bool IsCPSVersionLowerThanFirmwareUpgradeVersion(string cvnHostVersion, string cpsVersion)
		{
			short num = (short)1576009729;
			if (num != 0)
			{
			}
			num = (short)1113128960;
			short num2 = num;
			bool result = false;
			try
			{
				num = (short)1556808400;
				short num3 = num;
				num = (short)1583547088;
				int num5;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_129:
					int num4 = int.Parse(cvnHostVersion.Substring(1, 2));
					result = (int.Parse(cpsVersion.Substring(1, 2)) < num4);
					num = (short)1584332804;
					num5 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)1642921984;
					if (num != 0)
					{
					}
					num = (short)1636302851;
					num5 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num5)
					{
					case 0:
						goto IL_17D;
					case 1:
						num = (short)304414726;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_162;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_E2;
						}
						continue;
					case 4:
						goto IL_17D;
					case 5:
						goto IL_194;
					case 6:
						if (cpsVersion == null)
						{
							num = (short)1841299458;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_129;
					}
					IL_E2:
					if (cvnHostVersion != null)
					{
						num = (short)1212350465;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_162:
					result = true;
					num = (short)1324744704;
					num5 = (int)((global::System.IntPtr)num);
					continue;
					IL_17D:
					num = (short)1330053125;
					num5 = (int)((global::System.IntPtr)num);
				}
				IL_194:;
			}
			catch
			{
				result = true;
			}
			return result;
		}
	}
}
