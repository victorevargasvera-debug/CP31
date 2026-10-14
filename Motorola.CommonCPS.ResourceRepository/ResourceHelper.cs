using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.ResourceRepository.RadioCentral;

namespace Motorola.CommonCPS.ResourceRepository
{
	// Token: 0x02000003 RID: 3
	public class ResourceHelper
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public static string GetCommonErrorMessageByID(string errorID, string[] args = null)
		{
			short num;
			string result;
			try
			{
				num = (short)1107755009;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_BC;
							}
							string text;
							for (;;)
							{
								IL_A6:
								switch (num2)
								{
								case 0:
									result = text;
									num = (short)1841758209;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_118;
								case 2:
									if (!string.IsNullOrEmpty(text))
									{
										num = (short)1803485184;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1571946499;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_132;
								}
								goto IL_BC;
							}
							IL_118:
							goto IL_169;
							IL_132:
							goto IL_137;
							IL_BC:
							text = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.a(typeof(global::Motorola.CommonCPS.ResourceRepository.RadioCentral.RadioCentralResources), errorID, args);
							num = (short)1385889794;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_A6;
						}
						catch
						{
						}
						goto IL_137;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						goto IL_162;
					}
					IL_30:
					num = (short)722200583;
					short num3 = num;
					num = (short)2130634759;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1635778560;
						if (num != 0)
						{
						}
						if (!global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.IsRadioCentral)
						{
							goto IL_137;
						}
						break;
					}
					num = (short)1624571904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_137:
					result = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.a(typeof(global::Motorola.CommonCPS.ResourceRepository.Resources), errorID, args);
					num = (short)505020418;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_162:;
			}
			catch
			{
				result = errorID;
			}
			IL_169:
			num = (short)1308098560;
			short num4 = num;
			num = (short)1179058177;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002318 File Offset: 0x00000518
		private static string a(global::System.Type A_0, string A_1, string[] A_2)
		{
			short num2;
			global::System.Reflection.PropertyInfo property;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)600375296;
						short num3 = num2;
						num2 = (short)1499987969;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						if (A_2.Length == 0)
						{
							num2 = (short)1317208067;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_113;
					case 2:
					{
						if (A_2 == null)
						{
							goto IL_D0;
						}
						num2 = (short)660968592;
						short num4 = num2;
						num2 = (short)1151046800;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1923088384;
							if (num2 != 0)
							{
							}
							num2 = (short)1374355456;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						goto IL_111;
					}
					break;
				}
				IL_20:
				property = A_0.GetProperty(A_1, global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
				num2 = (short)1889533954;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_D0:
			return property.GetValue(null, null).ToString();
			IL_111:
			goto IL_D0;
			IL_113:
			num2 = (short)1159725057;
			if (num2 != 0)
			{
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, property.GetValue(null, null).ToString(), A_2);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000247C File Offset: 0x0000067C
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002530 File Offset: 0x00000730
		public static bool IsRadioCentral
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1020847971;
				short num2 = num;
				num = (short)87484259;
				switch (num2 == num)
				{
				}
				num = (short)106496001;
				if (num != 0)
				{
				}
				num = (short)1277100032;
				short num3 = num;
				num = (short)253755392;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)53823767;
				short num2 = num;
				num = (short)304302359;
				switch (num2 == num)
				{
				}
				num = (short)1072168961;
				if (num != 0)
				{
				}
				num = (short)485556224;
				short num3 = num;
				num = (short)753991680;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.a = value;
			}
		}

		// Token: 0x04000003 RID: 3
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool a;
	}
}
