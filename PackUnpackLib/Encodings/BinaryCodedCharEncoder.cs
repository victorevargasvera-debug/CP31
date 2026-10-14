using System;
using System.Text;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Encodings
{
	// Token: 0x02000009 RID: 9
	public class BinaryCodedCharEncoder : global::System.Text.Encoder
	{
		// Token: 0x06000014 RID: 20 RVA: 0x000032BC File Offset: 0x000014BC
		internal BinaryCodedCharEncoder(bool A_0)
		{
			this.b = A_0;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000032D8 File Offset: 0x000014D8
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00003388 File Offset: 0x00001588
		internal global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble StartNibble
		{
			get
			{
				short num = (short)1837826048;
				short num2 = num;
				num = (short)1720657892;
				short num3 = num;
				num = (short)542189540;
				switch (num3 == num)
				{
				}
				num = (short)1723858945;
				if (num != 0)
				{
				}
				num = (short)1526923264;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1117782016;
				short num2 = num;
				num = (short)655297204;
				short num3 = num;
				num = (short)1148914356;
				switch (num3 == num)
				{
				}
				num = (short)1765146625;
				if (num != 0)
				{
				}
				num = (short)337248256;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00003438 File Offset: 0x00001638
		internal bool BchEncode
		{
			get
			{
				short num = (short)1882062848;
				short num2 = num;
				num = (short)1721205028;
				short num3 = num;
				num = (short)787513636;
				switch (num3 == num)
				{
				}
				num = (short)2125070337;
				if (num != 0)
				{
				}
				num = (short)365887488;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000034E8 File Offset: 0x000016E8
		public override int GetByteCount(char[] chars, int index, int count, bool flush)
		{
			int a_ = 15;
			short num = (short)1684078594;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				int num5;
				switch (num2)
				{
				case 0:
				{
					if (index <= chars.Length - 1)
					{
						num = (short)1873936395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1345847297;
					if (num != 0)
					{
					}
					num = (short)822883429;
					short num3 = num;
					num = (short)1052193893;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2BA;
					default:
						num = (short)1256259584;
						if (num != 0)
						{
						}
						num = (short)1696595977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_20B;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_69;
					}
					continue;
				case 3:
					if (flag)
					{
						num = (short)1848770565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_115;
				case 4:
					num = (short)1079508992;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					int num4;
					num4++;
					num = (short)547094536;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
				{
					int num4;
					return num4;
				}
				case 7:
					goto IL_82;
				case 8:
					goto IL_115;
				case 9:
					goto IL_2BA;
				case 10:
					if (index >= 0)
					{
						num = (short)592117764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2DE;
				case 11:
				{
					if (count > chars.Length - index)
					{
						num = (short)1839529985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					int num4 = 0;
					flag = true;
					num5 = index;
					num = (short)272760844;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					goto IL_194;
				case 13:
					goto IL_194;
				case 14:
					if (num5 >= count)
					{
						num = (short)621543430;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.a(chars[num5]);
					num = (short)1857945603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_69:
				if (chars == null)
				{
					num = (short)1564278791;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)919601162;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_115:
				num = (short)1075511296;
				short num6 = num;
				flag = !flag;
				num5++;
				num = (short)1228931085;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_194:
				num = (short)1475018766;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_82:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("얥삧쮩\udeab\uddad", a_));
			IL_20B:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("얥잧\udfa9슫\udaad", a_));
			IL_2BA:
			IL_2DE:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쾥욧캩즫횭", a_));
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000037E8 File Offset: 0x000019E8
		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush)
		{
			int a_ = 10;
			short num;
			for (;;)
			{
				IL_09:
				num = (short)1067450368;
				switch (num)
				{
				default:
				{
					num = (short)1678639116;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						int num3;
						bool flag;
						int num7;
						switch (num2)
						{
						case 0:
							goto IL_D4;
						case 1:
							if (charIndex > chars.Length - 1)
							{
								num = (short)204996619;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1330118679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_2CA;
						case 3:
							if (charIndex >= 0)
							{
								num = (short)474415125;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_110;
						case 4:
							if (this.a == global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble.Lower)
							{
								num = (short)1194786821;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D4;
						case 5:
						{
							byte b = this.b(chars[num3]);
							int num4;
							bytes[num4] = b;
							int num5;
							num5++;
							num3++;
							num4++;
							num = (short)1771569152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							if (flag)
							{
								num = (short)854851598;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte b;
							byte b2;
							b2 |= b;
							int num4;
							bytes[num4] = b2;
							num4++;
							num = (short)866844682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_1C6;
						case 8:
							goto IL_29A;
						case 9:
							goto IL_CF;
						case 10:
							goto IL_1C6;
						case 11:
							goto IL_189;
						case 12:
							switch (0)
							{
							case 0:
								goto IL_B1;
							}
							continue;
						case 13:
						{
							if (byteIndex > bytes.Length - 1)
							{
								num = (short)1013252116;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num5 = 0;
							byte b2 = 0;
							int num4 = byteIndex;
							num3 = charIndex;
							num = (short)824377348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
						{
							byte b;
							byte b2 = (byte)(b << 4);
							int num4;
							bytes[num4] = b2;
							int num5;
							num5++;
							num = (short)1663107079;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
							if (byteIndex >= 0)
							{
								num = (short)1046609942;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_FC;
						case 16:
						{
							if (bytes != null)
							{
								num = (short)1952776207;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)585496320;
							short num6 = num;
							num = (short)1077409536;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
								num = (short)265945088;
								if (num != 0)
								{
								}
								num = (short)2016870418;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 17:
							goto IL_2CA;
						case 18:
							goto IL_3B3;
						case 19:
						{
							if (num3 > num7)
							{
								num = (short)1979973656;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte b = this.b(chars[num3]);
							num = (short)872808454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 20:
							goto IL_230;
						case 21:
							num = (short)1584594945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							num = (short)308215821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 23:
							if (charCount > chars.Length - charIndex)
							{
								num = (short)1116078088;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)276168720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
						{
							int num5;
							return num5;
						}
						}
						IL_B1:
						if (chars == null)
						{
							num = (short)1788870665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)375193603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_D4:
						num7 = charIndex + charCount - 1;
						flag = true;
						num = (short)2018639889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1C6:
						num3++;
						flag = !flag;
						num = (short)2040463362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2CA:
						num = (short)934543361;
						if (num != 0)
						{
						}
						num = (short)71761939;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			IL_CF:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("슠쮢쒤햦\udaa8", a_));
			IL_FC:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("슠쮢쒤햦얪즬쪮즰", a_));
			IL_110:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("슠쮢쒤햦얪즬쪮즰", a_));
			IL_189:
			goto IL_110;
			IL_230:
			num = (short)2123825152;
			short num8 = num;
			goto IL_FC;
			IL_29A:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("슠첢키즦\udda8", a_));
			IL_3B3:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("슠쮢쒤햦\udaa8", a_));
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003CF8 File Offset: 0x00001EF8
		private byte b(char A_0)
		{
			short num = (short)19070982;
			int num2 = (int)((global::System.IntPtr)num);
			byte result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1C0;
				case 1:
					goto IL_CD;
				case 2:
					num = (short)1464139779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					if (!this.b)
					{
						num = (short)1517027329;
						if (num != 0)
						{
						}
						num = (short)2033582092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1353279013;
					short num3 = num;
					num = (short)1651926565;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E3;
					default:
						num = (short)983957504;
						if (num != 0)
						{
						}
						result = (byte)(A_0 - 'a' + '\n');
						num = (short)54067207;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					result = (byte)(A_0 - '0');
					num = (short)633012224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!this.b)
					{
						num = (short)246939649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = (byte)(A_0 - 'A' + '\n');
					num = (short)973996049;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_70;
					}
					continue;
				case 7:
					goto IL_13C;
				case 8:
					if (A_0 >= 'a')
					{
						num = (short)1371471886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24B;
				case 9:
					num = (short)99287053;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (A_0 <= '9')
					{
						num = (short)199819268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_141;
				case 11:
				{
					num = (short)1074921472;
					short num4 = num;
					num = (short)91291658;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					goto IL_34D;
				case 13:
					if (A_0 <= 'F')
					{
						goto IL_1E3;
					}
					goto IL_200;
				case 14:
					num = (short)599654418;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (A_0 >= 'A')
					{
						num = (short)1371668489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_200;
				case 16:
					num = (short)253427717;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_19D;
				case 18:
					if (A_0 <= 'f')
					{
						num = (short)1978597378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24B;
				}
				IL_70:
				if (A_0 >= '0')
				{
					num = (short)844824587;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_141:
				num = (short)211943432;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E3:
				num = (short)2114125840;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_24B:
				num = (short)1356529679;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CD:
			throw new global::System.Text.EncoderFallbackException();
			IL_13C:
			IL_19D:
			IL_1C0:
			return result;
			IL_200:
			throw new global::System.Text.EncoderFallbackException();
			IL_34D:
			throw new global::System.Text.EncoderFallbackException();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00004058 File Offset: 0x00002258
		private byte a(byte A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble A_1)
		{
			short num = (short)84738048;
			short num2 = num;
			num = (short)1474618304;
			short num3 = num;
			num = (short)1461642176;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)974913537;
				if (num != 0)
				{
				}
				num = (short)1509818368;
				if (num != 0)
				{
				}
				if (A_1 == global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble.Upper)
				{
					return (byte)(A_0 >> 4 & 15);
				}
				break;
			}
			return A_0 & 15;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00004114 File Offset: 0x00002314
		private void a(char A_0)
		{
			short num = (short)1197932547;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_0 <= 'f')
					{
						num = (short)1354891266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_129;
				case 1:
					goto IL_1DA;
				case 2:
					num = (short)608305153;
					if (num != 0)
					{
					}
					num = (short)1531052045;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 4:
					if (A_0 <= 'F')
					{
						num = (short)571867141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D7;
				case 5:
					num = (short)686555143;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (A_0 >= 'a')
					{
						num = (short)883228683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_129;
				case 7:
					if (!this.b)
					{
						num = (short)727384073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					num = (short)165543948;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_219;
				case 10:
					num = (short)657195012;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)259588096;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (A_0 <= '9')
					{
						num = (short)1819017217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BE;
				case 13:
					if (!this.b)
					{
						num = (short)1285816335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 14:
					if (A_0 >= 'A')
					{
						num = (short)1835728906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D7;
				case 15:
					goto IL_19F;
				}
				IL_65:
				if (A_0 >= '0')
				{
					num = (short)1140064264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_BE:
				num = (short)1089929222;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_129:
				num = (short)466812942;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_19F:
			goto IL_26B;
			IL_1DA:
			num = (short)1822097408;
			short num3 = num;
			return;
			IL_219:
			num = (short)1640556087;
			short num4 = num;
			num = (short)1774577207;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_26B:
				throw new global::System.Text.EncoderFallbackException();
			default:
				num = (short)319750144;
				if (num != 0)
				{
				}
				throw new global::System.Text.EncoderFallbackException();
			}
			IL_2D7:
			throw new global::System.Text.EncoderFallbackException();
		}

		// Token: 0x0400000A RID: 10
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble a;

		// Token: 0x0400000B RID: 11
		private bool b;
	}
}
