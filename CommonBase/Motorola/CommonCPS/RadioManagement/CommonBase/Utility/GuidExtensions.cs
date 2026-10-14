using System;
using System.Collections.Generic;
using System.Linq;

namespace Motorola.CommonCPS.RadioManagement.CommonBase.Utility
{
	// Token: 0x02000011 RID: 17
	public static class GuidExtensions
	{
		// Token: 0x0600005E RID: 94 RVA: 0x00008B78 File Offset: 0x00006D78
		public static bool TryConvertToByteArray(this global::System.Collections.Generic.List<global::System.Guid> guids, out byte[] outputBytes)
		{
			short num;
			bool result;
			try
			{
				num = (short)1487521831;
				short num2 = num;
				num = (short)296405031;
				switch (num2 == num)
				{
				}
				num = (short)493551617;
				if (num != 0)
				{
				}
				num = (short)56950784;
				if (num != 0)
				{
				}
				outputBytes = guids.ToByteArray();
				result = true;
			}
			catch (global::System.Exception)
			{
				outputBytes = global::System.Array.Empty<byte>();
				result = false;
			}
			num = (short)1498087424;
			short num3 = num;
			return result;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00008C48 File Offset: 0x00006E48
		public static byte[] ToByteArray(this global::System.Collections.Generic.List<global::System.Guid> guids)
		{
			short num = (short)436872793;
			short num2 = num;
			num = (short)1629038169;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)786956288;
				short num3 = num;
				num = (short)281149440;
				if (num != 0)
				{
				}
				num = (short)51445760;
				switch (num)
				{
				}
				break;
			}
			}
			byte[] array = new byte[guids.Count * 16];
			int num4 = 0;
			global::System.Collections.Generic.List<global::System.Guid>.Enumerator enumerator = guids.GetEnumerator();
			try
			{
				num = (short)151781380;
				int num5 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num5)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)368902147;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Guid guid = enumerator.Current;
						byte[] array2 = guid.ToByteArray();
						int num6 = 0;
						num = (short)553123845;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						byte[] array2;
						int num6;
						if (num6 >= array2.Length)
						{
							num = (short)33816582;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = array2[num6];
						array[num4] = b;
						num4++;
						num6++;
						num = (short)454295554;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_189;
					case 3:
						num = (short)2079981575;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_F3;
						}
						continue;
					case 5:
						goto IL_189;
					case 7:
						goto IL_1E2;
					}
					IL_120:
					num = (short)210370560;
					num5 = (int)((global::System.IntPtr)num);
					continue;
					IL_F3:
					goto IL_120;
					IL_189:
					num = (short)765919233;
					num5 = (int)((global::System.IntPtr)num);
				}
				IL_1E2:;
			}
			finally
			{
				num = (short)953745409;
				if (num != 0)
				{
				}
				((global::System.IDisposable)enumerator).Dispose();
			}
			return array;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00008E8C File Offset: 0x0000708C
		public static bool TryParseIntoGuidsList(this byte[] input, out global::System.Collections.Generic.List<global::System.Guid> outputGuids)
		{
			short num;
			bool result;
			try
			{
				num = (short)311604751;
				short num2 = num;
				num = (short)1705752079;
				switch (num2 == num)
				{
				}
				num = (short)531562497;
				if (num != 0)
				{
				}
				num = (short)1125056512;
				if (num != 0)
				{
				}
				outputGuids = input.FromByteArray();
				result = true;
			}
			catch (global::System.Exception)
			{
				outputGuids = new global::System.Collections.Generic.List<global::System.Guid>();
				result = false;
			}
			num = (short)1782382592;
			short num3 = num;
			return result;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00008F5C File Offset: 0x0000715C
		public static global::System.Collections.Generic.List<global::System.Guid> FromByteArray(this byte[] input)
		{
			short num = (short)1577582592;
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
				int num5;
				global::System.Collections.Generic.List<byte[]> list;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_BB;
					case 1:
					{
						num = (short)104850903;
						short num3 = num;
						num = (short)390063575;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_181;
						default:
						{
							num = (short)1088684033;
							if (num != 0)
							{
							}
							num = (short)1177092096;
							if (num != 0)
							{
							}
							int num4;
							if (num4 >= 16)
							{
								num = (short)1150222340;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte[] array;
							array[num4] = input[num5];
							num5++;
							num4++;
							num = (short)1598750720;
							short num6 = num;
							num = (short)1749090312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
					{
						if (num5 >= input.Length)
						{
							num = (short)600506375;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array = new byte[16];
						int num4 = 0;
						num = (short)203489280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_181;
					case 4:
					{
						byte[] array;
						list.Add(array);
						num = (short)786956294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_18F;
					case 6:
						goto IL_18F;
					case 7:
						num = (short)532873219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_BB;
					}
					goto IL_52;
					IL_BB:
					num = (short)12648449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18F:
					num = (short)1913061378;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_181:
				return list.Select(new global::System.Func<byte[], global::System.Guid>(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.GuidExtensions.<>c.<>9.a)).ToList<global::System.Guid>();
				IL_52:
				list = new global::System.Collections.Generic.List<byte[]>();
				num5 = 0;
				num = (short)1109590021;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0400002E RID: 46
		private const int a = 16;
	}
}
