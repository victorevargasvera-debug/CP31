using System;
using System.IO;
using Motorola.CommonCPS.RadioManagement.Global.Properties;

namespace Motorola.CommonCPS.RadioManagement.Global
{
	// Token: 0x02000016 RID: 22
	public static class UserConfig
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000075F4 File Offset: 0x000057F4
		public static global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings Settings
		{
			get
			{
				short num = (short)156940327;
				short num2 = num;
				num = (short)18659367;
				switch (num2 == num)
				{
				}
				num = (short)598147072;
				short num3 = num;
				num = (short)2044461057;
				if (num != 0)
				{
				}
				num = (short)222494720;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings.Default;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000076A8 File Offset: 0x000058A8
		public static string GetValidFolder(string folder)
		{
			int a_ = 3;
			short num = (short)1206517761;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_94;
			}
			int num2;
			string text;
			for (;;)
			{
				IL_3A:
				switch (num2)
				{
				case 0:
					if (!folder.StartsWith(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.b("駄", a_), global::System.StringComparison.Ordinal))
					{
						num = (short)613810176;
						short num3 = num;
						num = (short)443285517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22A;
				case 1:
					goto IL_22A;
				case 2:
					if (!folder.Contains(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.b("駄鯆", a_)))
					{
						num = (short)1445462030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22A;
				case 3:
					if (!folder.Contains(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.b("ￄ鯆", a_)))
					{
						num = (short)218693648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_325;
				case 4:
					goto IL_242;
				case 5:
					try
					{
						num = (short)1420230658;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_474;
							case 1:
								text = global::System.IO.Path.GetFullPath(folder);
								num = (short)1411514368;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_439;
								}
								continue;
							case 3:
								goto IL_489;
							}
							IL_439:
							if (global::System.IO.Directory.Exists(folder))
							{
								num = (short)1590755329;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_474:
							num = (short)395968515;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_489:
						goto IL_22A;
					}
					catch
					{
						goto IL_22A;
					}
					return text;
				case 6:
					if (!folder.Contains(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.b("", a_)))
					{
						num = (short)728367124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22A;
				case 7:
					if (!folder.Contains(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.b("ￄ", a_)))
					{
						num = (short)2102198291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22A;
				case 8:
					if (folder.StartsWith(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.b("駄鯆", a_), global::System.StringComparison.Ordinal))
					{
						num = (short)723910668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)771227655;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					text = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.Desktop);
					num = (short)853344273;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (!string.IsNullOrWhiteSpace(folder))
					{
						num = (short)1889140751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22A;
				case 11:
					if (!folder.Contains(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.b("ￄ", a_)))
					{
						num = (short)32768018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_325;
				case 12:
					goto IL_325;
				case 13:
					text = folder;
					num = (short)1458896897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)1947860992;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
				{
					num = (short)1303387187;
					short num4 = num;
					num = (short)1995381811;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_242;
					default:
						num = (short)976879616;
						if (num != 0)
						{
						}
						folder = folder.Trim();
						num = (short)1076494339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 16:
					num = (short)842137611;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					return text;
				case 18:
					num = (short)2011168776;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					num = (short)1425539078;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					num = (short)1678639106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_94;
				IL_22A:
				num = (short)1303248900;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_242:
				if (string.IsNullOrEmpty(text))
				{
					num = (short)744620041;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_325:
				num = (short)2007105541;
				num2 = (int)((global::System.IntPtr)num);
			}
			return text;
			IL_94:
			text = string.Empty;
			num = (short)1543372810;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_3A;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00007B5C File Offset: 0x00005D5C
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(979899444 + A_1) + (global::System.IntPtr)35 + (global::System.IntPtr)23 + (global::System.IntPtr)83);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_5C;
			}
			IL_29:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_5C:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_29;
		}
	}
}
