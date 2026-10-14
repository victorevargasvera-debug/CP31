using System;
using System.Globalization;

namespace Motorola.CommonCPS.RadioManagement
{
	// Token: 0x02000006 RID: 6
	public class VersionComparer
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000023C8 File Offset: 0x000005C8
		public static bool IsMajorVersionLowerOrEqual(string candidateVersion, string version)
		{
			short num;
			bool result;
			try
			{
				num = (short)820772871;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1780809734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_127;
					case 2:
						goto IL_10E;
					case 3:
						num = (short)397672456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (version != null)
						{
							num = (short)506068992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10E;
					case 5:
						num = (short)1403584516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (candidateVersion.Length >= 3)
						{
							num = (short)1820131331;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10E;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_4C;
						}
						continue;
					case 8:
					{
						if (version.Length < 3)
						{
							num = (short)1624571906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1326266793;
						short num3 = num;
						num = (short)38353321;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_52;
						default:
						{
							num = (short)306970624;
							if (num != 0)
							{
							}
							int num4 = int.Parse(version.Substring(1, 2), global::System.Globalization.CultureInfo.CurrentCulture);
							result = (int.Parse(candidateVersion.Substring(1, 2), global::System.Globalization.CultureInfo.CurrentCulture) <= num4);
							num = (short)350421001;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 9:
						goto IL_1BA;
					}
					goto IL_4C;
					IL_52:
					num = (short)1267859461;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C:
					if (candidateVersion != null)
					{
						goto IL_52;
					}
					IL_10E:
					result = false;
					num = (short)521011201;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_127:
				IL_1BA:;
			}
			catch
			{
				result = false;
			}
			num = (short)578027520;
			short num5 = num;
			num = (short)389611521;
			if (num != 0)
			{
			}
			return result;
		}
	}
}
