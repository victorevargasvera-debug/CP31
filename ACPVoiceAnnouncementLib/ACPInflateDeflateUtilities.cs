using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace ACPVoiceAnnouncementLib
{
	// Token: 0x02000014 RID: 20
	public class ACPInflateDeflateUtilities
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00005EA0 File Offset: 0x000040A0
		internal global::System.Collections.Generic.List<string> a(string A_0, string A_1)
		{
			int a_ = 12;
			short num = (short)1550974976;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex(global::ACPVoiceAnnouncementLib.WaveFileReader.f("ጼᔾᵀὂ浄潆杈慊摌ፎ罐", a_) + A_1 + global::ACPVoiceAnnouncementLib.WaveFileReader.f("ᐼ", a_));
				try
				{
					switch (0)
					{
					case 0:
						goto IL_8F;
					}
					for (;;)
					{
						IL_60:
						int num3;
						switch (num2)
						{
						case 0:
							num = (short)1064042505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_15A;
						case 2:
							list.Sort();
							num = (short)1491795975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_15A;
						case 4:
						{
							string[] files;
							if (num3 >= files.Length)
							{
								num = (short)1503199234;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string input = files[num3];
							global::System.Text.RegularExpressions.Match match = regex.Match(input);
							num = (short)1870594053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::System.Text.RegularExpressions.Match match;
							if (match.Success)
							{
								num = (short)1930297344;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E2;
						}
						case 6:
						{
							global::System.Text.RegularExpressions.Match match;
							list.Add(match.Groups[1].Value);
							num = (short)1832583176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_27E;
						case 8:
							num = (short)1111949313;
							if (num != 0)
							{
							}
							goto IL_1E2;
						case 9:
						{
							global::System.Text.RegularExpressions.Match match;
							if (match.Groups.Count == 3)
							{
								num = (short)1899036678;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E2;
						}
						}
						break;
						IL_15A:
						num = (short)876347396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E2:
						num3++;
						num = (short)352124931;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_8F:
					num = (short)933171836;
					short num4 = num;
					num = (short)1336021628;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_27E:
						break;
					default:
					{
						num = (short)54329344;
						if (num != 0)
						{
						}
						string[] files = global::System.IO.Directory.GetFiles(A_0, global::ACPVoiceAnnouncementLib.WaveFileReader.f("᜼ᄾ", a_) + A_1);
						int num3 = 0;
						num = (short)1154416641;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_60;
					}
					}
				}
				catch
				{
					list = null;
				}
				num = (short)369557504;
				short num5 = num;
				return list;
			}
			}
		}
	}
}
