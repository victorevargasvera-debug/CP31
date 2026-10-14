using System;
using System.IO;
using System.Text;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x0200000C RID: 12
	public class ByteBufferStreamReader : global::System.IDisposable
	{
		// Token: 0x06000052 RID: 82 RVA: 0x000085C4 File Offset: 0x000067C4
		internal ByteBufferStreamReader(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream A_0) : this(A_0, false)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000085DC File Offset: 0x000067DC
		public ByteBufferStreamReader(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream input, bool bigEndian) : this(input, new global::System.Text.UTF8Encoding())
		{
			this.j = bigEndian;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000085FC File Offset: 0x000067FC
		internal ByteBufferStreamReader(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream A_0, global::System.Text.Encoding A_1)
		{
			int a_ = 4;
			base..ctor();
			if (A_0 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("풠힢", a_));
			}
			if (A_1 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﺚﲞ캠잢첤즦캨", a_));
			}
			if (!A_0.CanRead)
			{
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("좚쒠슢좤螦잨쒪\ud9ac辮쎰횲풴펶\ud8b8\ud9ba톼\udabe", a_));
			}
			this.h = A_0;
			this.e = A_1.GetDecoder();
			this.f = A_1.GetMaxCharCount(128);
			int num = A_1.GetMaxByteCount(1);
			if (num < 16)
			{
				num = 16;
			}
			this.b = new byte[num];
			this.c = null;
			this.d = null;
			this.a = (A_1 is global::System.Text.UnicodeEncoding);
			this.j = !global::System.BitConverter.IsLittleEndian;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000086D8 File Offset: 0x000068D8
		internal ByteBufferStreamReader(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream A_0, global::System.Text.Encoding A_1, bool A_2) : this(A_0, A_1)
		{
			this.j = A_2;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000086F4 File Offset: 0x000068F4
		internal virtual void Close()
		{
			short num = (short)2113895352;
			short num2 = num;
			num = (short)287865784;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1466499072;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)709951489;
			if (num != 0)
			{
			}
			num = (short)444661760;
			if (num != 0)
			{
			}
			this.Dispose(true);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000087A8 File Offset: 0x000069A8
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)1960247298;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1988165633;
					if (num != 0)
					{
					}
					global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream byteBufferStream = this.h;
					this.h = null;
					goto IL_11F;
				}
				case 1:
				{
					global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream byteBufferStream;
					byteBufferStream.Close();
					num = (short)1293549571;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 3:
				{
					num = (short)1164101297;
					short num3 = num;
					num = (short)192267953;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11F;
					default:
						goto IL_D1;
					}
					break;
				}
				case 4:
				{
					global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream byteBufferStream;
					if (byteBufferStream != null)
					{
						num = (short)388628481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_157;
				}
				}
				IL_3A:
				if (disposing)
				{
					num = (short)1296105472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_157;
				IL_11F:
				num = (short)256573444;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D1:
			num = (short)788135936;
			if (num != 0)
			{
			}
			num = (short)69271552;
			short num4 = num;
			IL_157:
			this.h = null;
			this.b = null;
			this.e = null;
			this.d = null;
			this.g = null;
			this.c = null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00008938 File Offset: 0x00006B38
		protected virtual void FillBuffer(int numBytes)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			int num;
			short num2;
			int num5;
			int num6;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)785121281;
					if (num2 != 0)
					{
					}
					num2 = (short)1973028278;
					short num3 = num2;
					num2 = (short)1683293622;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_230;
					default:
					{
						num2 = (short)1173159936;
						short num4 = num2;
						num2 = (short)1093402624;
						if (num2 != 0)
						{
						}
						if (this.h == null)
						{
							num2 = (short)638255105;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)422903816;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					goto IL_114;
				case 2:
					if (num5 == -1)
					{
						num2 = (short)225640453;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_166;
				case 3:
					num5 = this.h.ReadByte();
					goto IL_230;
				case 4:
					if (num6 >= numBytes)
					{
						num2 = (short)784203785;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_119;
				case 5:
					goto IL_268;
				case 6:
					goto IL_161;
				case 7:
					if (num5 == 0)
					{
						num2 = (short)217448454;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num6 += num5;
					num2 = (short)516751364;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (numBytes == 1)
					{
						num2 = (short)239206403;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_119;
				case 9:
					return;
				}
				goto IL_41;
				IL_119:
				num5 = this.h.Read(this.b, num6, numBytes - num6);
				num2 = (short)172163079;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_230:
				num2 = (short)158728194;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_114:
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪘爵삠캢薤즦욨\udfaa趬삮솰횲\udbb4", a_));
			IL_161:
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udc98列뾞캠얢薤풦\udda8\ud9aa좬캮\udcb0", a_));
			IL_166:
			this.b[0] = (byte)num5;
			return;
			IL_268:
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udc98列뾞캠얢薤풦\udda8\ud9aa좬캮\udcb0", a_));
			IL_41:
			num6 = 0;
			num5 = 0;
			num2 = (short)1213923328;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00008BB0 File Offset: 0x00006DB0
		private int a(char[] A_0, int A_1, int A_2)
		{
			short num = (short)1476067328;
			short num2 = num;
			num = (short)198901760;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_90;
				}
				int num4;
				int num6;
				for (;;)
				{
					IL_51:
					int byteIndex;
					switch (num3)
					{
					case 0:
						goto IL_2AD;
					case 1:
						num4 = 128;
						num = (short)647495692;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)935577989;
						short num5 = num;
						num = (short)1776273797;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1F3;
						default:
							num = (short)1985675264;
							if (num != 0)
							{
							}
							if (this.a)
							{
								num = (short)2128805894;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2AD;
						}
						break;
					}
					case 3:
						if (this.d == null)
						{
							num = (short)1980694541;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_272;
					case 4:
						if (num4 > 128)
						{
							num = (short)1664745473;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21D;
					case 5:
						goto IL_26D;
					case 6:
						num4 <<= 1;
						num = (short)1840054272;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						if (num4 == 0)
						{
							num = (short)753598469;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						int chars = this.e.GetChars(this.h.a(), byteIndex, num4, A_0, A_1);
						num6 -= chars;
						A_1 += chars;
						num = (short)293339147;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						return A_2;
					case 9:
						goto IL_272;
					case 10:
						if (num6 <= 0)
						{
							num = (short)1127153672;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = num6;
						num = (short)1565589506;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_272;
					case 12:
						goto IL_21D;
					case 13:
						goto IL_1F3;
					}
					goto IL_90;
					IL_1F3:
					this.d = new byte[128];
					num = (short)751304713;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_21D:
					byteIndex = this.h.b();
					num4 = this.h.b(num4);
					num = (short)2120679431;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_272:
					num = (short)871563274;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AD:
					num = (short)17825796;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_26D:
				return A_2 - num6;
				IL_90:
				num = (short)1835466753;
				if (num != 0)
				{
				}
				num4 = 0;
				num6 = A_2;
				num = (short)685965315;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00008ECC File Offset: 0x000070CC
		private int a()
		{
			short num = (short)191299584;
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
				int num4;
				int num5;
				long num6;
				for (;;)
				{
					IL_28:
					int num3;
					int num7;
					switch (num2)
					{
					case 0:
						num3 = this.h.ReadByte();
						this.d[1] = (byte)num3;
						num = (short)1651376129;
						if (num != 0)
						{
						}
						num = (short)1358888962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (num4 == 2)
						{
							num = (short)1034551296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_470;
					case 2:
						if (num3 == -1)
						{
							num = (short)658505755;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_470;
					case 3:
						return -1;
					case 4:
						if (num5 == 0)
						{
							num = (short)280428547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_556;
					case 5:
						goto IL_326;
					case 6:
						num6 = this.h.Position;
						num = (short)916520983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_470;
					case 8:
						if (!this.a)
						{
							num = (short)1766195225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)473890828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (this.h.CanSeek)
						{
							num = (short)2021588998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4CC;
					case 10:
						if (this.d == null)
						{
							num = (short)1196359695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_326;
					case 11:
						if (num4 == 0)
						{
							num = (short)360644630;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2057633818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num7 = 2;
						goto IL_383;
					case 13:
						num7 = 1;
						goto IL_383;
					case 14:
						if (num5 != 0)
						{
							num = (short)24707092;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)994312200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						this.d = new byte[128];
						num = (short)614268933;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (this.g == null)
						{
							num = (short)1236664338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29F;
					case 17:
						goto IL_29F;
					case 18:
						this.g = new char[1];
						num = (short)1357119505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_222;
					case 20:
						num = (short)1325989892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (num3 == -1)
						{
							num = (short)674299928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_222;
					case 22:
						return -1;
					case 23:
						goto IL_4CC;
					case 24:
						num4 = 0;
						num = (short)2116485139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)1973944333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						try
						{
							num5 = this.e.GetChars(this.d, 0, num4, this.g, 0);
							goto IL_29F;
						}
						catch
						{
							if (this.h.CanSeek)
							{
								num = (short)299501513;
								short num8 = num;
								num = (short)421922761;
								switch ((num8 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1465057280;
									if (num != 0)
									{
									}
									this.h.Seek(num6 - this.h.Position, global::System.IO.SeekOrigin.Current);
									break;
								}
							}
							throw;
						}
						goto IL_470;
					case 27:
					{
						num4 = 1;
						num = (short)790298624;
						short num9 = num;
						num = (short)45154311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_9F;
					IL_222:
					num = (short)1639120897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29F:
					num = (short)1410793486;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_326:
					num = (short)33226768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_383:
					num4 = num7;
					num3 = this.h.ReadByte();
					this.d[0] = (byte)num3;
					num = (short)85590037;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_470:
					num = (short)834928651;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4CC:
					num = (short)695730186;
					num2 = (int)((global::System.IntPtr)num);
				}
				return -1;
				IL_556:
				return (int)this.g[0];
				IL_9F:
				num5 = 0;
				num4 = 0;
				num6 = (num6 = 0L);
				num = (short)363069449;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00009448 File Offset: 0x00007648
		internal virtual int PeekChar()
		{
			int a_ = 2;
			short num = (short)1114046467;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_84;
				case 1:
					if (!this.h.CanSeek)
					{
						num = (short)605552642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D9;
				case 2:
					return -1;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				}
				IL_3E:
				if (this.h == null)
				{
					num = (short)1470300160;
					short num3 = num;
					num = (short)1569128448;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1819934721;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_84:
			IL_C5:
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪘爵삠캢薤즦욨\udfaa趬삮솰횲\udbb4", a_));
			IL_D9:
			num = (short)922979639;
			short num4 = num;
			num = (short)2120846647;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_C5;
			default:
			{
				num = (short)1645215744;
				if (num != 0)
				{
				}
				num = (short)148242433;
				if (num != 0)
				{
				}
				long position = this.h.Position;
				int result = this.Read();
				this.h.Position = position;
				return result;
			}
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000095C0 File Offset: 0x000077C0
		internal virtual int Read()
		{
			int a_ = 14;
			short num = (short)902823936;
			short num2 = num;
			if (this.h == null)
			{
				num = (short)1768751105;
				if (num != 0)
				{
				}
				num = (short)23798788;
				short num3 = num;
				num = (short)559293444;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)281673728;
					if (num != 0)
					{
					}
					break;
				}
				throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("펦\udba8캪첬슮醰\uddb2\udab4쎶馸풺춼\udabe꿀", a_));
			}
			return this.a();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00009698 File Offset: 0x00007898
		internal virtual int Read(byte[] buffer, int index, int count)
		{
			int a_ = 6;
			short num = (short)144375808;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_28:
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 1:
					goto IL_248;
				case 2:
					if (count < 0)
					{
						num = (short)136314881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)450560006;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1AC;
				case 4:
					goto IL_1FB;
				case 5:
					if (this.h == null)
					{
						num = (short)1945763843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_261;
				case 6:
					if (buffer.Length - index < count)
					{
						num = (short)257753092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1331363845;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_16D;
				case 8:
					while (index < 0)
					{
						num = (short)2147352576;
						short num3 = num;
						num = (short)1370888761;
						short num4 = num;
						num = (short)1298471481;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)206635008;
							if (num != 0)
							{
							}
							num = (short)1057292295;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_28;
						}
					}
					num = (short)1260257282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_6D;
				}
				IL_56:
				if (buffer == null)
				{
					num = (short)1001390089;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)789839873;
					if (num != 0)
					{
					}
					num = (short)1993277448;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_6D:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﾜ잠얢삤햦", a_));
			IL_16D:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("얠욢\udda4", a_));
			IL_1AC:
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("캜펠욢쒤쪦覨얪슬\udbae醰\udcb2어튶ힸ", a_));
			IL_1FB:
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("풜힠슢즤캦춨讪슬즮ힰ삲킴쎶馸ힺ\ud8bc톾ꛀ럂귄", a_));
			IL_248:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﺜ풠춢톤", a_));
			IL_261:
			return this.h.Read(buffer, index, count);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00009914 File Offset: 0x00007B14
		internal virtual int Read(char[] buffer, int index, int count)
		{
			int a_ = 3;
			short num = (short)1782972416;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_29:
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					continue;
				case 1:
					goto IL_24C;
				case 2:
					if (count < 0)
					{
						num = (short)1190002689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1219690502;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_187;
				case 4:
					goto IL_201;
				case 5:
					if (this.h == null)
					{
						num = (short)515112963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_265;
				case 6:
					if (buffer.Length - index < count)
					{
						num = (short)405405700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1705902085;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_147;
				case 8:
					while (index < 0)
					{
						num = (short)1214674281;
						short num3 = num;
						num = (short)1109620073;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							break;
						default:
						{
							num = (short)79757312;
							short num4 = num;
							break;
						}
						}
						num = (short)227606528;
						if (num != 0)
						{
						}
						num = (short)1660289031;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_29;
					}
					num = (short)1805778946;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_6E;
				}
				IL_57:
				if (buffer == null)
				{
					num = (short)1664942089;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1030094856;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_6E:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("욟잡횣", a_));
			IL_147:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("瞧얟\udaa1", a_));
			IL_187:
			num = (short)20774913;
			if (num != 0)
			{
			}
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즙얟쎡즣蚥욧얩\ud8ab躭\udfaf슱톳\ud8b5", a_));
			IL_201:
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("펙솟캡춣슥袧얩쪫좭쎯ힱ삳隵풷\udfb9튻\ud9bd뒿꫁", a_));
			IL_24C:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("蓮캟횡", a_));
			IL_265:
			return this.a(buffer, index, count);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00009B90 File Offset: 0x00007D90
		protected internal int Read7BitEncodedInt()
		{
			int a_ = 3;
			short num = (short)1345247011;
			short num2 = num;
			num = (short)2071582499;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)7995392;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_79;
				}
				int num3;
				int num4;
				int num5;
				for (;;)
				{
					IL_5F:
					switch (num3)
					{
					case 0:
					{
						if (num4 == 35)
						{
							num = (short)108199939;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = this.ReadByte();
						num5 |= (int)(b & 127) << num4;
						num4 += 7;
						num = (short)416612354;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return num5;
					case 2:
					{
						byte b;
						if ((b & 128) == 0)
						{
							num = (short)64159745;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_125;
					}
					case 3:
						goto IL_15C;
					case 4:
						goto IL_125;
					}
					goto IL_79;
					IL_125:
					num = (short)1164836864;
					num3 = (int)((global::System.IntPtr)num);
				}
				return num5;
				IL_79:
				num5 = 0;
				num4 = 0;
				num = (short)1626603524;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_5F;
			}
			}
			IL_15C:
			num = (short)294584320;
			short num6 = num;
			num = (short)385286145;
			if (num != 0)
			{
			}
			throw new global::System.FormatException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\ud899ﶛ瞧肟閡覣솧\udea9貫\udeaf욱螳蒵", a_));
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00009D28 File Offset: 0x00007F28
		internal virtual bool ReadBoolean()
		{
			short num = (short)2097487811;
			short num2 = num;
			num = (short)1970216899;
			switch (num2 == num)
			{
			}
			num = (short)2144468993;
			if (num != 0)
			{
			}
			num = (short)1789919232;
			short num3 = num;
			num = (short)1739390976;
			if (num != 0)
			{
			}
			this.FillBuffer(1);
			return this.b[0] > 0;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00009DE4 File Offset: 0x00007FE4
		internal virtual byte ReadByte()
		{
			int a_ = 9;
			short num = (short)1207768450;
			short num2 = num;
			num = (short)414586242;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_DF:
				num = (short)138936321;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)2067333120;
				if (num != 0)
				{
				}
				num = (short)63832066;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_A3;
				case 1:
					goto IL_F7;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					continue;
				}
				IL_85:
				if (this.h != null)
				{
					goto IL_DF;
				}
				num = (short)926482432;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_A3:
			num = (short)1561722881;
			if (num != 0)
			{
			}
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("횡횣쎥즧잩貫삭\udfaf욱钳\ud9b5좷\udfb9튻", a_));
			IL_F7:
			num = (short)319291392;
			short num4 = num;
			int num5 = this.h.ReadByte();
			if (num5 == -1)
			{
				throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첡삣蚥잧첩貫\uddad쒯삱톳ힵ햷", a_));
			}
			return (byte)num5;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00009F38 File Offset: 0x00008138
		public virtual byte[] ReadBytes(int count)
		{
			int a_ = 13;
			short num = (short)1407975424;
			switch (num)
			{
			default:
			{
				num = (short)482541569;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_10A;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					case 2:
					{
						int num3;
						byte[] array;
						if (num3 != array.Length)
						{
							num = (short)324075523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return array;
					}
					case 3:
					{
						IL_28C:
						int num3;
						byte[] array2 = new byte[num3];
						byte[] array;
						global::System.Buffer.BlockCopy(array, 0, array2, 0, num3);
						array = array2;
						num = (short)688521222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_256;
					case 5:
					{
						if (this.h == null)
						{
							num = (short)2060320776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array = new byte[count];
						int num3 = 0;
						num = (short)1101856768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						byte[] array;
						return array;
					}
					case 7:
					{
						int num3;
						int num4;
						num3 += num4;
						count -= num4;
						num = (short)1827405834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_20C;
					case 9:
					{
						int num4;
						if (num4 != 0)
						{
							num = (short)1076690944;
							short num5 = num;
							num = (short)245235719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_256;
					}
					case 10:
						if (count <= 0)
						{
							num = (short)1679228932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10A;
					case 11:
						goto IL_9A;
					}
					IL_7E:
					if (count < 0)
					{
						num = (short)498991115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)883884037;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10A:
					num = (short)1299241768;
					short num6 = num;
					num = (short)1989073704;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_28C;
					default:
					{
						num = (short)1821442048;
						if (num != 0)
						{
						}
						int num3;
						byte[] array;
						int num4 = this.h.Read(array, num3, count);
						num = (short)765001737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_256:
					num = (short)1774518274;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_9A:
				num = (short)879493121;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("잣즥\udda7쒩\ud8ab", a_));
				IL_20C:
				throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("튥\udaa7쾩춫쎭邯\udcb1\udbb3습颷햹첻\udbbd꺿", a_));
			}
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000A210 File Offset: 0x00008410
		internal virtual char ReadChar()
		{
			int a_ = 7;
			short num = (short)321894990;
			short num2 = num;
			num = (short)1186773582;
			switch (num2 == num)
			{
			}
			num = (short)473694208;
			if (num != 0)
			{
			}
			num = (short)1072234496;
			short num3 = num;
			num = (short)657653761;
			if (num != 0)
			{
			}
			int num4 = this.Read();
			if (num4 == -1)
			{
				throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udb9d캟욡蒣즥캧誩\udfab\udaad슯ힱ햳\udbb5", a_));
			}
			return (char)num4;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000A2E4 File Offset: 0x000084E4
		internal virtual char[] ReadChars(int count)
		{
			int a_ = 10;
			short num = (short)1328349190;
			int num2 = (int)((global::System.IntPtr)num);
			char[] array;
			for (;;)
			{
				int num4;
				switch (num2)
				{
				case 0:
				{
					num = (short)512219546;
					short num3 = num;
					num = (short)1241962906;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_96;
					default:
						goto IL_1A3;
					}
					break;
				}
				case 1:
					if (count < 0)
					{
						num = (short)1955397632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					array = new char[count];
					num4 = this.a(array, 0, count);
					num = (short)245301252;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_134;
				case 3:
				{
					char[] array2 = new char[num4];
					global::System.Buffer.BlockCopy(array, 0, array2, 0, 2 * num4);
					array = array2;
					num = (short)320471042;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_96;
				case 5:
					goto IL_6A;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4B;
					}
					continue;
				}
				IL_4B:
				if (this.h == null)
				{
					num = (short)705626117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)744488961;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_96:
				num = (short)2091319296;
				short num5 = num;
				if (num4 == count)
				{
					return array;
				}
				num = (short)1004994563;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_6A:
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("힢힤슦좨욪趬솮\udeb0잲閴\ud8b6즸\udeba펼", a_));
			IL_134:
			return array;
			IL_1A3:
			num = (short)831455233;
			if (num != 0)
			{
			}
			num = (short)2089353216;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("슠첢키즦\udda8", a_));
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000A4D8 File Offset: 0x000086D8
		internal virtual decimal ReadDecimal()
		{
			short num = (short)2074083328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3B;
				}
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_A3;
					case 1:
					{
						num = (short)1456865280;
						short num3 = num;
						num = (short)1003956079;
						short num4 = num;
						num = (short)651831151;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A3;
						default:
							goto IL_128;
						}
						break;
					}
					case 2:
						if (this.j)
						{
							num = (short)1534656512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_140;
					}
					goto IL_3B;
					IL_A3:
					global::System.Array.Reverse(this.b, 0, 16);
					num = (short)1610285057;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_128:
				num = (short)926023680;
				if (num != 0)
				{
				}
				IL_140:
				int lo = (int)this.b[0] | (int)this.b[1] << 8 | (int)this.b[2] << 16 | (int)this.b[3] << 24;
				int mid = (int)this.b[4] | (int)this.b[5] << 8 | (int)this.b[6] << 16 | (int)this.b[7] << 24;
				int hi = (int)this.b[8] | (int)this.b[9] << 8 | (int)this.b[10] << 16 | (int)this.b[11] << 24;
				int num5 = (int)this.b[12] | (int)this.b[13] << 8 | (int)this.b[14] << 16 | (int)this.b[15] << 24;
				bool isNegative = ((long)num5 & (long)((ulong)int.MinValue)) == (long)((ulong)int.MinValue);
				byte scale = (byte)((num5 & int.MaxValue) >> 16);
				return new decimal(lo, mid, hi, isNegative, scale);
				IL_3B:
				num = (short)519569409;
				if (num != 0)
				{
				}
				this.FillBuffer(16);
				num = (short)1724907522;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000A700 File Offset: 0x00008900
		internal unsafe virtual double ReadDouble()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)2027177486;
					short num3 = num2;
					num2 = (short)195773966;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)552271872;
						if (num2 != 0)
						{
						}
						if (this.j)
						{
							num2 = (short)2060386305;
							if (num2 != 0)
							{
							}
							num2 = (short)720764929;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_11E;
					}
					break;
				}
				case 1:
				{
					num2 = (short)242024448;
					short num4 = num2;
					global::System.Array.Reverse(this.b, 0, 8);
					num2 = (short)1587347458;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_11C;
				}
				goto IL_1C;
			}
			IL_11C:
			IL_11E:
			uint num5 = (uint)((int)this.b[0] | (int)this.b[1] << 8 | (int)this.b[2] << 16 | (int)this.b[3] << 24);
			ulong num6 = (ulong)((int)this.b[4] | (int)this.b[5] << 8 | (int)this.b[6] << 16 | (int)this.b[7] << 24 | (int)num5);
			return *(double*)(&num6);
			IL_1C:
			this.FillBuffer(8);
			num2 = (short)588120064;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000A88C File Offset: 0x00008A8C
		internal virtual short ReadInt16()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1339235291;
					short num3 = num2;
					num2 = (short)419961819;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1611857920;
						if (num2 != 0)
						{
						}
						if (this.j)
						{
							num2 = (short)1664024577;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_119;
					}
					break;
				}
				case 1:
				{
					num2 = (short)401997824;
					short num4 = num2;
					global::System.Array.Reverse(this.b, 0, 2);
					num2 = (short)781320194;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_117;
				}
				goto IL_1C;
			}
			IL_117:
			IL_119:
			return (short)((int)this.b[0] | (int)this.b[1] << 8);
			IL_1C:
			num2 = (short)878116865;
			if (num2 != 0)
			{
			}
			this.FillBuffer(2);
			num2 = (short)1514405888;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		internal virtual int ReadInt32()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)2105909739;
					short num3 = num2;
					num2 = (short)1945412075;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1216086017;
						if (num2 != 0)
						{
						}
						num2 = (short)1480851456;
						if (num2 != 0)
						{
						}
						if (this.j)
						{
							num2 = (short)104398849;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_119;
					}
					break;
				}
				case 1:
				{
					num2 = (short)1987706880;
					short num4 = num2;
					global::System.Array.Reverse(this.b, 0, 4);
					num2 = (short)136183810;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_117;
				}
				goto IL_1C;
			}
			IL_117:
			IL_119:
			return (int)this.b[0] | (int)this.b[1] << 8 | (int)this.b[2] << 16 | (int)this.b[3] << 24;
			IL_1C:
			this.FillBuffer(4);
			num2 = (short)288948224;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000AB1C File Offset: 0x00008D1C
		internal virtual long ReadInt64()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)600384703;
					short num3 = num2;
					num2 = (short)734536895;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)995885056;
						if (num2 != 0)
						{
						}
						if (this.j)
						{
							num2 = (short)925302785;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_F4;
					}
					break;
				}
				case 1:
				{
					global::System.Array.Reverse(this.b, 0, 8);
					num2 = (short)143065088;
					short num4 = num2;
					num2 = (short)1282932738;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_F2;
				}
				goto IL_1C;
			}
			IL_F2:
			IL_F4:
			num2 = (short)339804161;
			if (num2 != 0)
			{
			}
			uint num5 = (uint)((int)this.b[0] | (int)this.b[1] << 8 | (int)this.b[2] << 16 | (int)this.b[3] << 24);
			return (long)((ulong)((int)this.b[4] | (int)this.b[5] << 8 | (int)this.b[6] << 16 | (int)this.b[7] << 24) << 32 | (ulong)num5);
			IL_1C:
			this.FillBuffer(8);
			num2 = (short)1506869248;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000ACA4 File Offset: 0x00008EA4
		internal virtual sbyte ReadSByte()
		{
			short num = (short)52355437;
			short num2 = num;
			num = (short)597811565;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1008795648;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)685375488;
			if (num != 0)
			{
			}
			num = (short)2139422721;
			if (num != 0)
			{
			}
			this.FillBuffer(1);
			return (sbyte)this.b[0];
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000AD60 File Offset: 0x00008F60
		internal unsafe virtual float ReadSingle()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1716283542;
					short num3 = num2;
					num2 = (short)1078552726;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)604372992;
						if (num2 != 0)
						{
						}
						if (this.j)
						{
							num2 = (short)1456603137;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_121;
					}
					break;
				}
				case 1:
				{
					num2 = (short)1136525313;
					if (num2 != 0)
					{
					}
					num2 = (short)1862139904;
					short num4 = num2;
					global::System.Array.Reverse(this.b, 0, 4);
					num2 = (short)543621122;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_11F;
				}
				goto IL_1C;
			}
			IL_11F:
			IL_121:
			uint num5 = (uint)((int)this.b[0] | (int)this.b[1] << 8 | (int)this.b[2] << 16 | (int)this.b[3] << 24);
			return *(float*)(&num5);
			IL_1C:
			this.FillBuffer(4);
			num2 = (short)1387200512;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000AEC0 File Offset: 0x000090C0
		internal virtual string ReadString()
		{
			int a_ = 17;
			short num = (short)2103508992;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A8;
				}
				int num3;
				int chars;
				global::System.Text.StringBuilder stringBuilder;
				for (;;)
				{
					IL_31:
					int num5;
					int num7;
					int num8;
					switch (num2)
					{
					case 0:
						if (num3 == 0)
						{
							num = (short)156303380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E6;
					case 1:
						goto IL_3FA;
					case 2:
						goto IL_263;
					case 3:
						if (this.h == null)
						{
							num = (short)2050490368;
							short num4 = num;
							num = (short)407306264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_50F;
					case 4:
						if (num3 >= num5)
						{
							num = (short)1517158406;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_263;
					case 5:
						num = (short)1993539592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_36D;
					case 7:
						goto IL_497;
					case 8:
					{
						num = (short)654925269;
						short num6 = num;
						num = (short)1340956117;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_50F;
						default:
							num = (short)1437794304;
							if (num != 0)
							{
							}
							num7 = num5 - num3;
							goto IL_49C;
						}
						break;
					}
					case 9:
						if (num8 == num5)
						{
							num = (short)2024800263;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E6;
					case 10:
						goto IL_372;
					case 11:
						if (this.d == null)
						{
							num = (short)583598098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_372;
					case 12:
						goto IL_4EB;
					case 13:
						if (num5 - num3 <= 128)
						{
							num = (short)219611141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)711786523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						this.c = new char[this.f];
						num = (short)1548812310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (num8 == 0)
						{
							num = (short)378470412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						chars = this.e.GetChars(this.d, 0, num8, this.c, 0);
						num = (short)1315897344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_54E;
					case 17:
						goto IL_31F;
					case 18:
						this.d = new byte[128];
						num = (short)2059665418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						stringBuilder = new global::System.Text.StringBuilder(num5);
						num = (short)1884880913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)1592393729;
						if (num != 0)
						{
						}
						num = (short)1882914825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (this.c == null)
						{
							num = (short)1215889422;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F0;
					case 22:
						goto IL_4F0;
					case 23:
						if (stringBuilder == null)
						{
							num = (short)1859846163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31F;
					case 24:
						goto IL_111;
					case 25:
						if (num5 < 0)
						{
							num = (short)806813712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1839333402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (num5 == 0)
						{
							num = (short)732430337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1924792331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num7 = 128;
						goto IL_49C;
					}
					goto IL_A8;
					IL_263:
					num = (short)606928909;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E6:
					num = (short)1924923415;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_31F:
					stringBuilder.Append(this.c, 0, chars);
					num3 += num8;
					num = (short)216989700;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_372:
					num = (short)476643349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_49C:
					int count = num7;
					num8 = this.h.Read(this.d, 0, count);
					num = (short)1340276751;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F0:
					stringBuilder = null;
					num = (short)251461634;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_50F:
					num5 = this.Read7BitEncodedInt();
					num = (short)1648033817;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_111:
				throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮧ\udea9\udeab쮭톯\udfb1钳\ud8b5ힷ캹鲻톽낿ꟁ꫃", a_));
				IL_36D:
				return stringBuilder.ToString();
				IL_3FA:
				return string.Empty;
				IL_497:
				return new string(this.c, 0, chars);
				IL_4EB:
				throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒩좫躭\udfaf풱钳억첷좹\ud9bb\udfbd궿", a_));
				IL_54E:
				throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒩\udaab쾭\udcaf\udbb1킳隵쮷좹햻킽ꞿꣃꏅꛇ귉룋ꛍ", a_));
				IL_A8:
				num3 = 0;
				num = (short)127991811;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000B448 File Offset: 0x00009648
		internal virtual ushort ReadUInt16()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)997720065;
					if (num2 != 0)
					{
					}
					num2 = (short)816238930;
					short num3 = num2;
					num2 = (short)2740562;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)50593792;
						if (num2 != 0)
						{
						}
						if (this.j)
						{
							num2 = (short)1692860417;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_119;
					}
					break;
				}
				case 1:
				{
					num2 = (short)432472064;
					short num4 = num2;
					global::System.Array.Reverse(this.b, 0, 2);
					num2 = (short)1930100738;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_117;
				}
				goto IL_1C;
			}
			IL_117:
			IL_119:
			return (ushort)((int)this.b[0] | (int)this.b[1] << 8);
			IL_1C:
			this.FillBuffer(2);
			num2 = (short)1699807232;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000B584 File Offset: 0x00009784
		internal virtual uint ReadUInt32()
		{
			short num = (short)1614413825;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_43;
			}
			int num2;
			for (;;)
			{
				IL_31:
				switch (num2)
				{
				case 0:
				{
					num = (short)495285457;
					short num3 = num;
					num = (short)865301713;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1938554880;
						if (num != 0)
						{
						}
						if (this.j)
						{
							num = (short)1361575937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11A;
					}
					break;
				}
				case 1:
				{
					num = (short)1554710528;
					short num4 = num;
					global::System.Array.Reverse(this.b, 0, 4);
					num = (short)1862008834;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_118;
				}
				goto IL_43;
			}
			IL_118:
			IL_11A:
			return (uint)((int)this.b[0] | (int)this.b[1] << 8 | (int)this.b[2] << 16 | (int)this.b[3] << 24);
			IL_43:
			this.FillBuffer(4);
			num = (short)591331328;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000B6D8 File Offset: 0x000098D8
		internal virtual ulong ReadUInt64()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1454263076;
					short num3 = num2;
					num2 = (short)911100708;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)484311040;
						if (num2 != 0)
						{
						}
						if (this.j)
						{
							num2 = (short)720175105;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_120;
					}
					break;
				}
				case 1:
				{
					global::System.Array.Reverse(this.b, 0, 8);
					num2 = (short)1726152704;
					short num4 = num2;
					num2 = (short)68747266;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_F6;
				}
				goto IL_1C;
			}
			IL_F6:
			num2 = (short)2018574337;
			if (num2 != 0)
			{
			}
			IL_120:
			uint num5 = (uint)((int)this.b[0] | (int)this.b[1] << 8 | (int)this.b[2] << 16 | (int)this.b[3] << 24);
			return (ulong)((int)this.b[4] | (int)this.b[5] << 8 | (int)this.b[6] << 16 | (int)this.b[7] << 24) << 32 | (ulong)num5;
			IL_1C:
			this.FillBuffer(8);
			num2 = (short)190709760;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000B864 File Offset: 0x00009A64
		void global::System.IDisposable.Dispose()
		{
			short num = (short)253817927;
			short num2 = num;
			num = (short)907932743;
			switch (num2 == num)
			{
			default:
			{
				num = (short)559677440;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1268187137;
			if (num != 0)
			{
			}
			num = (short)1606352896;
			if (num != 0)
			{
			}
			this.Dispose(true);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0000B918 File Offset: 0x00009B18
		public virtual global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream BaseStream
		{
			get
			{
				short num = (short)1966741178;
				short num2 = num;
				num = (short)2019432122;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2134048768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1272971264;
				if (num != 0)
				{
				}
				num = (short)228982785;
				if (num != 0)
				{
				}
				return this.h;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000B9C8 File Offset: 0x00009BC8
		public virtual bool BigEndian
		{
			get
			{
				short num = (short)746660948;
				short num2 = num;
				num = (short)1334387796;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1045954560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2084241408;
				if (num != 0)
				{
				}
				num = (short)964427777;
				if (num != 0)
				{
				}
				return this.j;
			}
		}

		// Token: 0x0400001A RID: 26
		private bool a;

		// Token: 0x0400001B RID: 27
		private byte[] b;

		// Token: 0x0400001C RID: 28
		private char[] c;

		// Token: 0x0400001D RID: 29
		private byte[] d;

		// Token: 0x0400001E RID: 30
		private global::System.Text.Decoder e;

		// Token: 0x0400001F RID: 31
		private int f;

		// Token: 0x04000020 RID: 32
		private char[] g;

		// Token: 0x04000021 RID: 33
		private global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream h;

		// Token: 0x04000022 RID: 34
		private const int i = 128;

		// Token: 0x04000023 RID: 35
		private bool j;
	}
}
