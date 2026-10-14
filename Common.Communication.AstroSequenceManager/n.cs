using System;
using System.Collections;
using Motorola.Common.Communication.AmpConfigPackage;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200002D RID: 45
	internal class n : global::System.Collections.IComparer
	{
		// Token: 0x06000180 RID: 384 RVA: 0x00026448 File Offset: 0x00024648
		internal static int a(string A_0, string A_1)
		{
			int a_ = 14;
			short num = (short)1052704768;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9F;
				}
				int num3;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						if (A_0 == string.Empty)
						{
							num = (short)439353352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)374145047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (A_1 == string.Empty)
						{
							num = (short)2135228432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2106261509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_206;
					case 3:
						goto IL_333;
					case 4:
						num = (short)1427963905;
						if (num != 0)
						{
						}
						num3 = 1;
						num = (short)1512570883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (A_0.Length >= 6)
						{
							num = (short)672268306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B6;
					case 6:
						if (A_0 == null)
						{
							num = (short)1148583960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F7;
					case 7:
					{
						char c;
						char c2;
						if (c > c2)
						{
							num = (short)1947402244;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return num3;
					}
					case 8:
						goto IL_1E6;
					case 9:
						if (num3 == 0)
						{
							num = (short)1559822348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return num3;
					case 10:
					{
						string text;
						string text2;
						if (text != text2)
						{
							num = (short)1212022806;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return num3;
					}
					case 11:
						goto IL_1A0;
					case 12:
						num = (short)1703280665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1042743296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (A_0 != null)
						{
							goto IL_416;
						}
						return -1;
					case 15:
					{
						if (A_1.Length < 6)
						{
							num = (short)653131787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = A_0;
						string text2 = A_1;
						text = text.ToLowerInvariant();
						text2 = text2.ToLowerInvariant();
						text = text.Replace(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("탽", a_), "");
						text2 = text2.Replace(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("탽", a_), "");
						num = (short)2094989322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_472;
					case 17:
					{
						num = (short)1409337001;
						short num4 = num;
						num = (short)1741932201;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_416;
						default:
							num = (short)860225536;
							if (num != 0)
							{
							}
							if (A_1 == null)
							{
								num = (short)353304595;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3F7;
						}
						break;
					}
					case 18:
						num = (short)6488079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						return 0;
					case 20:
						num3 = -1;
						num = (short)291438594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)1625358337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						string text;
						char c = text[0];
						string text2;
						char c2 = text2[0];
						text = text.Remove(0, 1);
						text2 = text2.Remove(0, 1);
						num3 = string.Compare(text, text2, global::System.StringComparison.Ordinal);
						num = (short)1416364041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						if (A_1 != null)
						{
							num = (short)1246298133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return 1;
					case 24:
						num = (short)1735983121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						char c;
						char c2;
						if (c < c2)
						{
							num = (short)1982136340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1502806023;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_9F;
					IL_3F7:
					num = (short)1730215950;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_416:
					num = (short)1052966925;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A0:
				goto IL_4B6;
				IL_1E6:
				return -1;
				IL_206:
				return num3;
				IL_333:
				return num3;
				IL_472:
				return 1;
				IL_4B6:
				num = (short)1163264000;
				short num5 = num;
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ValidateInfosFailure);
				IL_9F:
				num3 = 0;
				num = (short)121569286;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00026940 File Offset: 0x00024B40
		public int Compare(object x, object y)
		{
			short num = (short)950528980;
			short num2 = num;
			num = (short)1728310228;
			switch (num2 == num)
			{
			default:
			{
				num = (short)693305344;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1163788289;
			if (num != 0)
			{
			}
			num = (short)1510866944;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.n.a((string)x, (string)y);
		}
	}
}
