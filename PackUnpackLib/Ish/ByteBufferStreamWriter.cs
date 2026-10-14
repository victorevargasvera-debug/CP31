using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x0200000D RID: 13
	public class ByteBufferStreamWriter : global::System.IDisposable
	{
		// Token: 0x06000073 RID: 115 RVA: 0x0000BA78 File Offset: 0x00009C78
		protected ByteBufferStreamWriter()
		{
			this.f = new char[1];
			this.OutStream = (global::System.IO.Stream.Null as global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream);
			this.a = new byte[16];
			this.c = new global::System.Text.UTF8Encoding(false, true);
			this.b = this.c.GetEncoder();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000BAD4 File Offset: 0x00009CD4
		internal ByteBufferStreamWriter(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream A_0, bool A_1) : this(A_0, new global::System.Text.UTF8Encoding(false, true))
		{
			this.h = A_1;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000BAF8 File Offset: 0x00009CF8
		internal ByteBufferStreamWriter(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream A_0, global::System.Text.Encoding A_1)
		{
			int a_ = 3;
			base..ctor();
			this.f = new char[1];
			if (A_0 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("킟힡킣", a_));
			}
			if (A_1 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﾙﶝ쾟욡춣좥쾧", a_));
			}
			if (!A_0.CanWrite)
			{
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즙얟쎡즣蚥욧얩\ud8ab躭잯삱\uddb3습\ud9b7\ud8b9킻\udbbd", a_));
			}
			this.OutStream = A_0;
			this.a = new byte[16];
			this.c = A_1;
			this.b = this.c.GetEncoder();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000BB9C File Offset: 0x00009D9C
		internal virtual void Close()
		{
			short num = (short)1327034490;
			short num2 = num;
			num = (short)561246330;
			switch (num2 == num)
			{
			default:
			{
				num = (short)200278016;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1206976513;
			if (num != 0)
			{
			}
			num = (short)901644288;
			if (num != 0)
			{
			}
			this.Dispose(true);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000BC48 File Offset: 0x00009E48
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)1807155200;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_16;
				case 1:
				{
					num = (short)1201274880;
					short num3 = num;
					this.OutStream.Close();
					num = (short)803143682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					return;
				}
				goto IL_32;
				IL_16:
				switch (0)
				{
				case 0:
				{
					IL_32:
					num = (short)879913880;
					short num4 = num;
					num = (short)749628312;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16;
					default:
						num = (short)1229258753;
						if (num != 0)
						{
						}
						num = (short)440008704;
						if (num != 0)
						{
						}
						if (!disposing)
						{
							return;
						}
						num = (short)267059201;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000BD64 File Offset: 0x00009F64
		internal virtual void Flush()
		{
			short num = (short)562183335;
			short num2 = num;
			num = (short)488783015;
			switch (num2 == num)
			{
			default:
			{
				num = (short)90767360;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1325334529;
			if (num != 0)
			{
			}
			num = (short)1355743232;
			if (num != 0)
			{
			}
			this.OutStream.Flush();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000BE18 File Offset: 0x0000A018
		internal virtual long Seek(int offset, global::System.IO.SeekOrigin origin)
		{
			short num = (short)72876033;
			if (num != 0)
			{
			}
			num = (short)322437120;
			short num2 = num;
			num = (short)845761513;
			short num3 = num;
			num = (short)276646889;
			switch (num3 == num)
			{
			}
			num = (short)1629028352;
			if (num != 0)
			{
			}
			return this.OutStream.Seek((long)offset, origin);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000BED4 File Offset: 0x0000A0D4
		void global::System.IDisposable.Dispose()
		{
			short num = (short)166978864;
			short num2 = num;
			num = (short)1111745840;
			switch (num2 == num)
			{
			default:
			{
				num = (short)466812928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)683933696;
			if (num != 0)
			{
			}
			num = (short)1809907713;
			if (num != 0)
			{
			}
			this.Dispose(true);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000BF84 File Offset: 0x0000A184
		internal virtual void Write(bool value)
		{
			short num = (short)1644338738;
			short num2 = num;
			num = (short)1937940018;
			switch (num2 == num)
			{
			default:
			{
				num = (short)573767680;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1107034113;
			if (num != 0)
			{
			}
			num = (short)1047855104;
			if (num != 0)
			{
			}
			this.a[0] = (value ? 1 : 0);
			this.OutStream.Write(this.a, 0, 1);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000C054 File Offset: 0x0000A254
		internal virtual void Write(byte value)
		{
			short num = (short)458345724;
			short num2 = num;
			num = (short)1573309692;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1843396608;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1047724033;
			if (num != 0)
			{
			}
			num = (short)698548224;
			if (num != 0)
			{
			}
			this.OutStream.WriteByte(value);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000C10C File Offset: 0x0000A30C
		internal unsafe virtual void Write(char ch)
		{
			int a_ = 10;
			short num = (short)2130200022;
			short num2 = num;
			num = (short)168379862;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_FE:
				num = (short)1834680321;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1520762880;
				if (num != 0)
				{
				}
				num = (short)851771396;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			byte[] array;
			byte* bytes;
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)2056454144;
					short num4 = num;
					if ((array = this.a) != null)
					{
						num = (short)1168506887;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BB;
				}
				case 1:
					if (array.Length == 0)
					{
						num = (short)850001926;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					bytes = &array[0];
					num = (short)13500421;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_D3;
				case 3:
					goto IL_B9;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_9A;
					}
					continue;
				case 5:
					goto IL_167;
				case 6:
					goto IL_BB;
				case 7:
					goto IL_1D0;
				}
				IL_9A:
				if (char.IsSurrogate(ch))
				{
					num = (short)1690632195;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)323354624;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_BB:
				bytes = null;
				num = (short)846397442;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_B9:
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("횢힤햦욨첪첬\udbae풰삲閴\ud9b6횸쾺鶼\udebe귀꿂꫄냆곈꿊껎ꋐꛔ뻖럘볚뇜뫞쇠胢跤蛦鯨", a_));
			IL_D3:
			num = (short)386465793;
			if (num != 0)
			{
			}
			IL_167:
			goto IL_1D5;
			IL_1D0:
			goto IL_FE;
			IL_1D5:
			int bytes2 = this.b.GetBytes(&ch, 1, bytes, 16, true);
			array = null;
			this.OutStream.Write(this.a, 0, bytes2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000C318 File Offset: 0x0000A518
		internal virtual void Write(byte[] buffer)
		{
			int a_ = 9;
			short num;
			if (buffer != null)
			{
				num = (short)228613513;
				short num2 = num;
				num = (short)806575497;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_0E;
				case 1:
					break;
				default:
				{
					num = (short)534446080;
					short num3 = num;
					break;
				}
				}
				num = (short)1190658048;
				if (num != 0)
				{
				}
				this.OutStream.Write(buffer, 0, buffer.Length);
				return;
			}
			IL_0E:
			num = (short)477102081;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("슟힡슣삥춧\ud8a9", a_));
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000C3F4 File Offset: 0x0000A5F4
		internal virtual void Write(decimal value)
		{
			short num = (short)253296640;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_43;
					}
					for (;;)
					{
						IL_28:
						switch (num2)
						{
						case 0:
							if (value != 0m)
							{
								num = (short)1616904195;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_267;
						case 1:
							goto IL_1CE;
						case 2:
							if (this.h)
							{
								num = (short)278396932;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_267;
						case 3:
							global::System.Array.Reverse(this.a, 0, 16);
							num = (short)608567297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)199688192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					IL_43:
					num = (short)1475960725;
					short num3 = num;
					num = (short)260530069;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)84672512;
						if (num != 0)
						{
						}
						int[] bits = decimal.GetBits(value);
						int num4 = bits[0];
						int num5 = bits[1];
						int num6 = bits[2];
						int num7 = bits[3];
						this.a[0] = (byte)num4;
						this.a[1] = (byte)(num4 >> 8);
						this.a[2] = (byte)(num4 >> 16);
						this.a[3] = (byte)(num4 >> 24);
						this.a[4] = (byte)num5;
						this.a[5] = (byte)(num5 >> 8);
						this.a[6] = (byte)(num5 >> 16);
						this.a[7] = (byte)(num5 >> 24);
						this.a[8] = (byte)num6;
						this.a[9] = (byte)(num6 >> 8);
						this.a[10] = (byte)(num6 >> 16);
						this.a[11] = (byte)(num6 >> 24);
						this.a[12] = (byte)num7;
						this.a[13] = (byte)(num7 >> 8);
						this.a[14] = (byte)(num7 >> 16);
						this.a[15] = (byte)(num7 >> 24);
						num = (short)585433090;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_28;
					}
					}
				}
				IL_1CE:
				num = (short)2091122688;
				short num8 = num;
				num = (short)1667497985;
				if (num != 0)
				{
				}
				IL_267:
				this.OutStream.Write(this.a, 0, 16);
				return;
			}
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000C67C File Offset: 0x0000A87C
		internal unsafe virtual void Write(double value)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (value != 0.0)
					{
						num2 = (short)413925379;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C9;
				case 1:
					goto IL_187;
				case 2:
					if (this.h)
					{
						num2 = (short)320798724;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C9;
				case 3:
					goto IL_1C4;
				case 4:
				{
					num2 = (short)1721609257;
					short num3 = num2;
					num2 = (short)1592568873;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C4;
					default:
						num2 = (short)1789001728;
						if (num2 != 0)
						{
						}
						num2 = (short)1447100416;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
				IL_1C4:
				global::System.Array.Reverse(this.a, 0, 8);
				num2 = (short)1057030145;
				if (num2 != 0)
				{
				}
				num2 = (short)18350080;
				short num4 = num2;
				num2 = (short)507248641;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_187:
			IL_1C9:
			this.OutStream.Write(this.a, 0, 8);
			return;
			IL_24:
			ulong num5 = (ulong)(*(long*)(&value));
			this.a[0] = (byte)num5;
			this.a[1] = (byte)(num5 >> 8);
			this.a[2] = (byte)(num5 >> 16);
			this.a[3] = (byte)(num5 >> 24);
			this.a[4] = (byte)(num5 >> 32);
			this.a[5] = (byte)(num5 >> 40);
			this.a[6] = (byte)(num5 >> 48);
			this.a[7] = (byte)(num5 >> 56);
			num2 = (short)1779040258;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000C868 File Offset: 0x0000AA68
		internal virtual void Write(char[] chars)
		{
			int a_ = 16;
			if (chars != null)
			{
				short num = (short)889096315;
				short num2 = num;
				num = (short)1556842619;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)135135232;
					short num3 = num;
					num = (short)637992961;
					if (num != 0)
					{
					}
					num = (short)681181184;
					if (num != 0)
					{
					}
					byte[] bytes = this.c.GetBytes(chars, 0, chars.Length);
					this.OutStream.Write(bytes, 0, bytes.Length);
					return;
				}
				}
			}
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒦솨쪪\udfac\udcae", a_));
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000C954 File Offset: 0x0000AB54
		internal virtual void Write(short value)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (value != 0)
					{
						num2 = (short)1543176195;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16A;
				case 1:
					goto IL_131;
				case 2:
					if (this.h)
					{
						num2 = (short)1344077828;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16A;
				case 3:
					goto IL_165;
				case 4:
				{
					num2 = (short)378558176;
					short num3 = num2;
					num2 = (short)1654740704;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_165;
					default:
						num2 = (short)894631936;
						if (num2 != 0)
						{
						}
						num2 = (short)67567616;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
				IL_165:
				global::System.Array.Reverse(this.a, 0, 2);
				num2 = (short)1924988928;
				short num4 = num2;
				num2 = (short)984940545;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_131:
			IL_16A:
			this.OutStream.Write(this.a, 0, 2);
			return;
			IL_24:
			num2 = (short)1076166657;
			if (num2 != 0)
			{
			}
			this.a[0] = (byte)value;
			this.a[1] = (byte)(value >> 8);
			num2 = (short)1458765826;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		internal virtual void Write(int value)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (value != 0)
					{
						num2 = (short)1934688259;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_188;
				case 1:
					goto IL_150;
				case 2:
					if (this.h)
					{
						num2 = (short)216727556;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_188;
				case 3:
					goto IL_183;
				case 4:
				{
					num2 = (short)1963794352;
					short num3 = num2;
					num2 = (short)717627312;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_183;
					default:
						num2 = (short)252379136;
						if (num2 != 0)
						{
						}
						num2 = (short)831193088;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
				IL_183:
				global::System.Array.Reverse(this.a, 0, 4);
				num2 = (short)376504320;
				short num4 = num2;
				num2 = (short)1438842881;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_150:
			IL_188:
			this.OutStream.Write(this.a, 0, 4);
			return;
			IL_24:
			this.a[0] = (byte)value;
			this.a[1] = (byte)(value >> 8);
			this.a[2] = (byte)(value >> 16);
			this.a[3] = (byte)(value >> 24);
			num2 = (short)690487297;
			if (num2 != 0)
			{
			}
			num2 = (short)150732802;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000CC88 File Offset: 0x0000AE88
		internal virtual void Write(long value)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (value != 0L)
					{
						num2 = (short)1342636035;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BB;
				case 1:
					goto IL_183;
				case 2:
					if (this.h)
					{
						num2 = (short)325517316;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BB;
				case 3:
					goto IL_1B6;
				case 4:
				{
					num2 = (short)1047892650;
					short num3 = num2;
					num2 = (short)567513770;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B6;
					default:
						num2 = (short)866058241;
						if (num2 != 0)
						{
						}
						num2 = (short)978780160;
						if (num2 != 0)
						{
						}
						num2 = (short)1522335744;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
				IL_1B6:
				global::System.Array.Reverse(this.a, 0, 8);
				num2 = (short)2000879616;
				short num4 = num2;
				num2 = (short)1555693569;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_183:
			IL_1BB:
			this.OutStream.Write(this.a, 0, 8);
			return;
			IL_24:
			this.a[0] = (byte)value;
			this.a[1] = (byte)(value >> 8);
			this.a[2] = (byte)(value >> 16);
			this.a[3] = (byte)(value >> 24);
			this.a[4] = (byte)(value >> 32);
			this.a[5] = (byte)(value >> 40);
			this.a[6] = (byte)(value >> 48);
			this.a[7] = (byte)(value >> 56);
			num2 = (short)590741506;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000CE64 File Offset: 0x0000B064
		internal virtual void Write(sbyte value)
		{
			short num = (short)222539945;
			short num2 = num;
			num = (short)699969705;
			switch (num2 == num)
			{
			}
			num = (short)568983553;
			if (num != 0)
			{
			}
			num = (short)1303642112;
			short num3 = num;
			num = (short)1075380224;
			if (num != 0)
			{
			}
			this.OutStream.WriteByte((byte)value);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000CF1C File Offset: 0x0000B11C
		internal unsafe virtual void Write(float value)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (value != 0f)
					{
						num2 = (short)1501298691;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_194;
				case 1:
					goto IL_105;
				case 2:
					if (this.h)
					{
						num2 = (short)604176388;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_194;
				case 3:
					goto IL_168;
				case 4:
				{
					num2 = (short)1518392331;
					short num3 = num2;
					num2 = (short)2041041931;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_168;
					default:
						num2 = (short)238485504;
						if (num2 != 0)
						{
						}
						num2 = (short)646119424;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
				IL_168:
				num2 = (short)1414201345;
				if (num2 != 0)
				{
				}
				global::System.Array.Reverse(this.a, 0, 4);
				num2 = (short)1331953665;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_105:
			num2 = (short)121372672;
			short num4 = num2;
			IL_194:
			this.OutStream.Write(this.a, 0, 4);
			return;
			IL_24:
			uint num5 = *(uint*)(&value);
			this.a[0] = (byte)num5;
			this.a[1] = (byte)(num5 >> 8);
			this.a[2] = (byte)(num5 >> 16);
			this.a[3] = (byte)(num5 >> 24);
			num2 = (short)1757151234;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000D0D0 File Offset: 0x0000B2D0
		internal unsafe virtual void Write(string value)
		{
			int a_ = 16;
			short num = (short)621346816;
			switch (num)
			{
			default:
			{
				num = (short)704118784;
				short num2 = num;
				num = (short)266534922;
				int num3 = (int)((global::System.IntPtr)num);
				int byteCount;
				for (;;)
				{
					int num4;
					byte[] array;
					byte* bytes;
					char* ptr;
					int num6;
					int num7;
					switch (num3)
					{
					case 0:
						goto IL_306;
					case 1:
						if (num4 <= 0)
						{
							num = (short)1720320007;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1773469717;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (array.Length == 0)
						{
							num = (short)425656332;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						bytes = &array[0];
						num = (short)437977110;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)783932573;
						short num5 = num;
						num = (short)2011290781;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_225;
						default:
							num = (short)794230784;
							if (num != 0)
							{
							}
							ptr += global::System.Runtime.CompilerServices.RuntimeHelpers.OffsetToStringData / 2;
							num = (short)100990994;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_268;
					case 5:
						goto IL_48C;
					case 6:
						goto IL_48C;
					case 7:
						return;
					case 8:
						num6 = this.e;
						goto IL_447;
					case 9:
						num6 = num4;
						goto IL_447;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_D7;
						}
						continue;
					case 11:
						if (ptr != null)
						{
							num = (short)2060124163;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AE;
					case 12:
						goto IL_121;
					case 13:
						goto IL_F5;
					case 14:
						if ((array = this.d) != null)
						{
							num = (short)220528663;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_121;
					case 15:
						goto IL_2C8;
					case 16:
						num = (short)231866377;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_225;
					case 18:
						goto IL_1AE;
					case 19:
						if (this.d == null)
						{
							num = (short)234749969;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C8;
					case 20:
						if (byteCount <= 256)
						{
							num = (short)118358016;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num7 = 0;
						num4 = value.Length;
						num = (short)1047855110;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (num4 <= this.e)
						{
							num = (short)345440272;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1955004424;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_268;
					case 23:
						num = (short)1985085442;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D7:
					if (value == null)
					{
						num = (short)2005663757;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					byteCount = this.c.GetByteCount(value);
					this.Write7BitEncodedInt(byteCount);
					num = (short)1583611923;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_121:
					bytes = null;
					num = (short)889454596;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AE:
					char* ptr2 = ptr;
					num = (short)2036989966;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_225:
					this.d = new byte[256];
					this.e = 256 / this.c.GetMaxByteCount(1);
					num = (short)1878261775;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_268:
					int num8;
					int bytes2 = this.b.GetBytes(ptr2 + num7, num8, bytes, 256, num8 == num4);
					array = null;
					this.OutStream.Write(this.d, 0, bytes2);
					num7 += num8;
					string text = null;
					num4 -= num8;
					num = (short)1432879109;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C8:
					num = (short)177340436;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_447:
					num8 = num6;
					fixed (string text = value)
					{
						ptr = text;
						num = (short)723189771;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_48C:
						num = (short)302514177;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				IL_F5:
				num = (short)1608843265;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("톦좨잪\ud8ac쪮", a_));
				IL_306:
				this.c.GetBytes(value, 0, value.Length, this.d, 0);
				this.OutStream.Write(this.d, 0, byteCount);
				return;
			}
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000D5F4 File Offset: 0x0000B7F4
		internal virtual void Write(ushort value)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (value != 0)
					{
						num2 = (short)615055361;
						if (num2 != 0)
						{
						}
						num2 = (short)1414856707;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16D;
				case 1:
					goto IL_E4;
				case 2:
					if (this.h)
					{
						num2 = (short)931201028;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16D;
				case 3:
					goto IL_168;
				case 4:
				{
					num2 = (short)2079409494;
					short num3 = num2;
					num2 = (short)87115094;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_168;
					default:
						num2 = (short)361234432;
						if (num2 != 0)
						{
						}
						num2 = (short)214630400;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
				IL_168:
				global::System.Array.Reverse(this.a, 0, 2);
				num2 = (short)1138098177;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_E4:
			num2 = (short)1850212352;
			short num4 = num2;
			IL_16D:
			this.OutStream.Write(this.a, 0, 2);
			return;
			IL_24:
			this.a[0] = (byte)value;
			this.a[1] = (byte)(value >> 8);
			num2 = (short)1996226562;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000D784 File Offset: 0x0000B984
		internal virtual void Write(uint value)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (value != 0U)
					{
						num2 = (short)738459651;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_182;
				case 1:
					goto IL_F8;
				case 2:
					if (this.h)
					{
						num2 = (short)1334378500;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_182;
				case 3:
					goto IL_17D;
				case 4:
				{
					num2 = (short)1159077899;
					short num3 = num2;
					num2 = (short)463478795;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17D;
					default:
						num2 = (short)1953693696;
						if (num2 != 0)
						{
						}
						num2 = (short)1276051456;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
				IL_17D:
				global::System.Array.Reverse(this.a, 0, 4);
				num2 = (short)1176698881;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F8:
			num2 = (short)774242304;
			short num4 = num2;
			num2 = (short)446562305;
			if (num2 != 0)
			{
			}
			IL_182:
			this.OutStream.Write(this.a, 0, 4);
			return;
			IL_24:
			this.a[0] = (byte)value;
			this.a[1] = (byte)(value >> 8);
			this.a[2] = (byte)(value >> 16);
			this.a[3] = (byte)(value >> 24);
			num2 = (short)1920532482;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000D928 File Offset: 0x0000BB28
		internal virtual void Write(ulong value)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (value != 0UL)
					{
						num2 = (short)1262813187;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BB;
				case 1:
					goto IL_133;
				case 2:
					if (this.h)
					{
						num2 = (short)636616708;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BB;
				case 3:
					goto IL_1B6;
				case 4:
				{
					num2 = (short)1817284867;
					short num3 = num2;
					num2 = (short)861835523;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B6;
					default:
						num2 = (short)589758464;
						if (num2 != 0)
						{
						}
						num2 = (short)2024865792;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
				IL_1B6:
				global::System.Array.Reverse(this.a, 0, 8);
				num2 = (short)195624961;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_133:
			num2 = (short)1692729344;
			short num4 = num2;
			num2 = (short)272760833;
			if (num2 != 0)
			{
			}
			IL_1BB:
			this.OutStream.Write(this.a, 0, 8);
			return;
			IL_24:
			this.a[0] = (byte)value;
			this.a[1] = (byte)(value >> 8);
			this.a[2] = (byte)(value >> 16);
			this.a[3] = (byte)(value >> 24);
			this.a[4] = (byte)(value >> 32);
			this.a[5] = (byte)(value >> 40);
			this.a[6] = (byte)(value >> 48);
			this.a[7] = (byte)(value >> 56);
			num2 = (short)572325890;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000DB04 File Offset: 0x0000BD04
		internal virtual void Write(byte[] buffer, int index, int count)
		{
			short num = (short)910670386;
			short num2 = num;
			num = (short)1257421362;
			switch (num2 == num)
			{
			}
			num = (short)4063233;
			if (num != 0)
			{
			}
			num = (short)1011220480;
			short num3 = num;
			num = (short)2028339200;
			if (num != 0)
			{
			}
			this.OutStream.Write(buffer, index, count);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000DBBC File Offset: 0x0000BDBC
		internal virtual void Write(char[] chars, int index, int count)
		{
			short num = (short)1581483305;
			short num2 = num;
			num = (short)818971945;
			switch (num2 == num)
			{
			}
			num = (short)647430145;
			if (num != 0)
			{
			}
			num = (short)237043712;
			if (num != 0)
			{
			}
			num = (short)1406271488;
			short num3 = num;
			byte[] bytes = this.c.GetBytes(chars, index, count);
			this.OutStream.Write(bytes, 0, bytes.Length);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000DC84 File Offset: 0x0000BE84
		protected void Write7BitEncodedInt(int value)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			uint num2;
			short num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_38;
				case 1:
					if (num2 < 128U)
					{
						num3 = (short)865402880;
						short num4 = num3;
						num3 = (short)1760952322;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)505610241;
					if (num3 != 0)
					{
					}
					this.Write((byte)(num2 | 128U));
					num2 >>= 7;
					num3 = (short)1479868416;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					goto IL_E6;
				case 3:
					goto IL_38;
				}
				goto IL_20;
				IL_38:
				num3 = (short)918611937;
				short num5 = num3;
				num3 = (short)512813025;
				switch ((num5 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_13E;
				default:
					num3 = (short)2103574528;
					if (num3 != 0)
					{
					}
					num3 = (short)197001217;
					num = (int)((global::System.IntPtr)num3);
					break;
				}
			}
			IL_E6:
			IL_13E:
			this.Write((byte)num2);
			return;
			IL_20:
			num2 = (uint)value;
			num3 = (short)968884227;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000DDD8 File Offset: 0x0000BFD8
		internal virtual global::System.IO.Stream BaseStream
		{
			get
			{
				short num = (short)1827201817;
				short num2 = num;
				num = (short)56681241;
				switch (num2 == num)
				{
				}
				num = (short)1748172801;
				if (num != 0)
				{
				}
				num = (short)1483538432;
				if (num != 0)
				{
				}
				num = (short)1320288256;
				short num3 = num;
				this.Flush();
				return this.OutStream;
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000DE8C File Offset: 0x0000C08C
		// Note: this type is marked as 'beforefieldinit'.
		static ByteBufferStreamWriter()
		{
			short num = (short)1276525665;
			short num2 = num;
			num = (short)1524382817;
			switch (num2 == num)
			{
			}
			num = (short)657915904;
			if (num != 0)
			{
			}
			num = (short)1585446913;
			if (num != 0)
			{
			}
			num = (short)1175191552;
			short num3 = num;
			global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamWriter.Null = new global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamWriter();
		}

		// Token: 0x04000024 RID: 36
		private byte[] a;

		// Token: 0x04000025 RID: 37
		private global::System.Text.Encoder b;

		// Token: 0x04000026 RID: 38
		private global::System.Text.Encoding c;

		// Token: 0x04000027 RID: 39
		private byte[] d;

		// Token: 0x04000028 RID: 40
		private int e;

		// Token: 0x04000029 RID: 41
		private char[] f;

		// Token: 0x0400002A RID: 42
		private const int g = 256;

		// Token: 0x0400002B RID: 43
		private bool h;

		// Token: 0x0400002C RID: 44
		protected global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream OutStream;

		// Token: 0x0400002D RID: 45
		public static readonly global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamWriter Null;
	}
}
