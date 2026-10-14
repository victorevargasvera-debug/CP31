using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using Motorola.Common.Communication.CommonUtil.Extensions;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000033 RID: 51
	public static class DFlagInfo
	{
		// Token: 0x0600012C RID: 300 RVA: 0x00019C2C File Offset: 0x00017E2C
		private static bool a(global::Motorola.Common.Communication.CommonUtil.DFlagType A_0, global::Motorola.Common.Communication.CommonUtil.DFlagType A_1)
		{
			short num = (short)31069245;
			short num2 = num;
			num = (short)690099261;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2064711680;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2107834368;
			if (num != 0)
			{
			}
			num = (short)423952385;
			if (num != 0)
			{
			}
			return (A_0 & A_1) == A_0;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00019CE0 File Offset: 0x00017EE0
		public static bool IsDFlagExisted(global::Motorola.Common.Communication.CommonUtil.DFlagType dft)
		{
			int a_ = 13;
			short num = (short)141754369;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)199688193;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::System.Attribute> enumerator;
				global::Motorola.Common.Communication.CommonUtil.DFlagType dflagType;
				switch (num2)
				{
				case 0:
					goto IL_25B;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 2:
				{
					IL_2D0:
					try
					{
						num = (short)923009030;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								num = (short)1297285128;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num = (short)863764487;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)2094465025;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Reflection.AssemblyMetadataAttribute assemblyMetadataAttribute = enumerator.Current as global::System.Reflection.AssemblyMetadataAttribute;
								num = (short)982843396;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
							{
								global::System.Reflection.AssemblyMetadataAttribute assemblyMetadataAttribute;
								if (assemblyMetadataAttribute != null)
								{
									num = (short)903872514;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
							{
								global::System.Reflection.AssemblyMetadataAttribute assemblyMetadataAttribute;
								dflagType |= (global::Motorola.Common.Communication.CommonUtil.DFlagType)global::System.Enum.ToObject(typeof(global::Motorola.Common.Communication.CommonUtil.DFlagType), global::System.Convert.ToInt32(assemblyMetadataAttribute.Value, global::System.Globalization.CultureInfo.InvariantCulture));
								num = (short)236322816;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								switch (0)
								{
								case 0:
									goto IL_D1;
								}
								continue;
							case 7:
							{
								global::System.Reflection.AssemblyMetadataAttribute assemblyMetadataAttribute;
								if (assemblyMetadataAttribute.Key == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("唐唒礔瘖縘", a_))
								{
									num = (short)540344325;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 8:
								goto IL_1ED;
							}
							IL_10C:
							num = (short)1276116995;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_D1:
							goto IL_10C;
						}
						IL_1ED:
						goto IL_2D5;
					}
					finally
					{
						num = (short)1249509376;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_223;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)318439426;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_258;
							}
							IL_223:
							if (enumerator == null)
							{
								break;
							}
							num = (short)551026689;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_258:;
					}
					goto IL_25B;
					IL_2D5:
					num = (short)164823040;
					short num3 = num;
					global::Motorola.Common.Communication.CommonUtil.DFlagInfo.a = dflagType;
					global::Motorola.Common.Communication.CommonUtil.DFlagInfo.b = true;
					num = (short)386662403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_320;
				}
				IL_65:
				if (!global::Motorola.Common.Communication.CommonUtil.DFlagInfo.b)
				{
					num = (short)579338240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_25B:
				dflagType = global::Motorola.Common.Communication.CommonUtil.DFlagType.Normal;
				enumerator = global::System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes().GetEnumerator();
				num = (short)1334076005;
				short num4 = num;
				num = (short)971465317;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_2D0;
				default:
					num = (short)1407320064;
					if (num != 0)
					{
					}
					num = (short)1117454338;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_320:
			return global::Motorola.Common.Communication.CommonUtil.DFlagInfo.a(dft, global::Motorola.Common.Communication.CommonUtil.DFlagInfo.a);
		}

		// Token: 0x04000141 RID: 321
		private static global::Motorola.Common.Communication.CommonUtil.DFlagType a;

		// Token: 0x04000142 RID: 322
		private static bool b;
	}
}
