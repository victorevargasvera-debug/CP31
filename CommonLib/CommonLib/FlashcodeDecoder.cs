using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.CommonUtil.Extensions;

namespace Motorola.Common.CommonLib
{
	// Token: 0x02000010 RID: 16
	public class FlashcodeDecoder
	{
		// Token: 0x06000063 RID: 99 RVA: 0x0000E8F4 File Offset: 0x0000CAF4
		public FlashcodeDecoder()
		{
			this.a = new global::Motorola.Common.CommonLib.FlashcodeMapping();
			this.b = new global::Motorola.Common.CommonLib.FlashcodeFormatter();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000E920 File Offset: 0x0000CB20
		public void CodeFlashcode(byte[] code, ref string flashcode)
		{
			short num = (short)157286400;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num3;
			global::System.Collections.Generic.List<string> list;
			string item;
			for (;;)
			{
				IL_33:
				switch (num3)
				{
				case 0:
					goto IL_107;
				case 1:
					if (list != null)
					{
						num = (short)1973157892;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BC;
				case 2:
					if (list.Count >= 2)
					{
						num = (short)72286208;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BC;
				case 3:
					goto IL_127;
				case 4:
					num = (short)1800929282;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4D;
				IL_107:
				list.Insert(2, item);
				num = (short)701366275;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_BC:
				num = (short)1045508376;
				short num4 = num;
				num = (short)693055768;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_107;
				default:
					goto IL_F0;
				}
			}
			IL_F0:
			num = (short)1347551232;
			if (num != 0)
			{
			}
			return;
			IL_127:
			flashcode = this.a(list);
			return;
			IL_4D:
			num = (short)2101149697;
			if (num != 0)
			{
			}
			string text = this.FlashcodeInByteToString(code);
			item = this.a(text);
			list = this.SplitFcIntoGroups(text);
			num = (short)9961473;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000EA9C File Offset: 0x0000CC9C
		public string FlashcodeInByteToString(byte[] flashcodeBytes)
		{
			short num = (short)1633878016;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1701904385;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 1:
					if (flashcodeBytes.Length == 0)
					{
						num = (short)1963851778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12A;
				case 2:
					goto IL_128;
				case 3:
					goto IL_ED;
				}
				IL_5C:
				if (flashcodeBytes == null)
				{
					break;
				}
				num = (short)939527640;
				short num3 = num;
				num = (short)1624706520;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2113011712;
					short num4 = num;
					num = (short)542769152;
					if (num != 0)
					{
					}
					num = (short)1197670403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_ED:
				num = (short)2067464193;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EF:
			return string.Empty;
			IL_128:
			goto IL_EF;
			IL_12A:
			return flashcodeBytes.Aggregate(string.Empty, new global::System.Func<string, byte, string>(this.a));
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000EBEC File Offset: 0x0000CDEC
		private string a(string A_0)
		{
			short num = (short)1555300352;
			short num2 = num;
			num = (short)584051705;
			short num3 = num;
			num = (short)716762105;
			switch (num3 == num)
			{
			}
			num = (short)35717121;
			if (num != 0)
			{
			}
			num = (short)1010499584;
			if (num != 0)
			{
			}
			byte b = new global::Motorola.Common.CommonLib.FlashcodeFormatter().CalculateFlashCodeCheckDigit(A_0);
			return this.a.flashcodeMap[(int)b].ToString();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		public global::System.Collections.Generic.List<string> SplitFcIntoGroups(string flashcodeStr)
		{
			short num = (short)746717184;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1731526656;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_78;
				}
				global::System.Collections.Generic.List<string> list;
				for (;;)
				{
					IL_51:
					switch (num2)
					{
					case 0:
					{
						int i;
						int num4;
						while (i <= num4)
						{
							string item = flashcodeStr.Substring((i - 1) * 6, 6);
							list.Add(item);
							i++;
							num = (short)68003014;
							short num5 = num;
							num = (short)1899930822;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1365180417;
								if (num != 0)
								{
								}
								num = (short)1821179904;
								if (num != 0)
								{
								}
								num = (short)1456930822;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_51;
							}
						}
						num = (short)1392967683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return list;
					case 2:
					{
						if (string.IsNullOrEmpty(flashcodeStr))
						{
							num = (short)584253441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4 = flashcodeStr.Length / 6;
						num = (short)951451655;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						return list;
					case 4:
						return list;
					case 5:
						goto IL_164;
					case 6:
						goto IL_164;
					case 7:
					{
						int num4;
						if (num4 < 2)
						{
							num = (short)1749024772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int i = 1;
						num = (short)703332357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_78;
					IL_164:
					num = (short)108658688;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_78:
				list = new global::System.Collections.Generic.List<string>();
				num = (short)109510658;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000EEC8 File Offset: 0x0000D0C8
		private string a(global::System.Collections.Generic.List<string> A_0)
		{
			int a_ = 8;
			short num = (short)390529024;
			short num2 = num;
			num = (short)1947321718;
			short num3 = num;
			num = (short)1133692278;
			switch (num3 == num)
			{
			}
			num = (short)1602486272;
			if (num != 0)
			{
			}
			num = (short)1565065217;
			if (num != 0)
			{
			}
			return string.Join(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("ℋ", a_), A_0);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000EF90 File Offset: 0x0000D190
		public void Decode(string flashcode, ref byte[] decoded)
		{
			short num = (short)533397504;
			short num2 = num;
			num = (short)764477440;
			switch (num)
			{
			default:
			{
				num = (short)1497825284;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num5;
					int num6;
					switch (num3)
					{
					case 0:
						goto IL_15F;
					case 1:
					{
						char c;
						if (this.a.IsCharInFlashcodeMap(c))
						{
							num = (short)1442250759;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19F;
					}
					case 2:
					{
						num = (short)759720790;
						short num4 = num;
						num = (short)1344498518;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_19F;
						default:
							num = (short)1059651584;
							if (num != 0)
							{
							}
							num = (short)410910735;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_AD;
						}
						continue;
					case 5:
					{
						if (num5 >= flashcode.Length)
						{
							num = (short)503840771;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						char c = flashcode[num5];
						num = (short)595722253;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)1971257345;
						if (num != 0)
						{
						}
						num = (short)2084962305;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						char c;
						decoded[num6++] = (byte)this.a.GetFlashcodeIntValue(c);
						num = (short)893124622;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						global::System.Array.Resize<byte>(ref decoded, 12);
						num = (short)967770123;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_1A3;
					case 10:
						if (num6 != 25)
						{
							num = (short)1860108288;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
						goto IL_13E;
					case 12:
						goto IL_1A3;
					case 13:
					{
						char c;
						if (c != '-')
						{
							num = (short)857341954;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15F;
					}
					case 14:
						num = (short)1478295562;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (num6 != 12)
						{
							num = (short)1356791814;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15F;
					}
					IL_AD:
					if (decoded.Length != 12)
					{
						num = (short)1689190408;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_13E:
					num6 = 0;
					num5 = 0;
					num = (short)365166601;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_15F:
					num5++;
					num = (short)753205260;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A3:
					num = (short)1617100805;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_19F:
				decoded = null;
				return;
			}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000F2BC File Offset: 0x0000D4BC
		public void DecodeExpandedFlashcode(string flashcode, ref byte[] decoded)
		{
			short num = (short)1541144582;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num4;
				switch (num2)
				{
				case 0:
				{
					int num3;
					decoded[num3++] = (byte)this.a.GetFlashcodeIntValue(flashcode[num4]);
					num = (short)1199046659;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (this.a.IsCharInFlashcodeMap(flashcode[num4]))
					{
						num = (short)357695488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A4;
				case 2:
					goto IL_ED;
				case 3:
					goto IL_157;
				case 4:
					return;
				case 5:
					num = (short)434831371;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1462304769;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_83;
					}
					continue;
				case 7:
					if (flashcode[num4] != '-')
					{
						goto IL_26D;
					}
					goto IL_157;
				case 8:
					global::System.Array.Resize<byte>(ref decoded, 24);
					num = (short)1705705474;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)2054356993;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_1CD;
				case 11:
					if (num4 != 14)
					{
						num = (short)39059465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_157;
				case 12:
					goto IL_1CD;
				case 13:
					if (num4 >= flashcode.Length)
					{
						num = (short)353763332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1879113735;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_83:
				if (decoded.Length != 24)
				{
					num = (short)846987272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_ED:
				num = (short)445553472;
				short num5 = num;
				num = (short)1586076480;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_26D:
					num = (short)1970405376;
					short num6 = num;
					num = (short)1444741125;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				default:
				{
					num = (short)907476992;
					if (num != 0)
					{
					}
					int num3 = 0;
					num4 = 0;
					num = (short)2012807180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_157:
				num4++;
				num = (short)854982666;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1CD:
				num = (short)96993293;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A4:
			decoded = null;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000F57C File Offset: 0x0000D77C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a(string A_0, byte A_1)
		{
			short num = (short)871628800;
			short num2 = num;
			num = (short)2076357209;
			short num3 = num;
			num = (short)1259778649;
			switch (num3 == num)
			{
			}
			num = (short)346685440;
			if (num != 0)
			{
			}
			num = (short)1799487489;
			if (num != 0)
			{
			}
			return A_0 + this.a.flashcodeMap[(int)A_1].ToString();
		}

		// Token: 0x04000054 RID: 84
		private global::Motorola.Common.CommonLib.FlashcodeMapping a;

		// Token: 0x04000055 RID: 85
		private global::Motorola.Common.CommonLib.FlashcodeFormatter b;
	}
}
