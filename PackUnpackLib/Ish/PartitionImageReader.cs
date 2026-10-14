using System;
using System.IO;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.Exceptions;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x0200003C RID: 60
	public class PartitionImageReader
	{
		// Token: 0x0600025F RID: 607 RVA: 0x000370A4 File Offset: 0x000352A4
		internal PartitionImageReader(global::Motorola.Acp.PackUnpack.Ish.Partition A_0, global::Motorola.Acp.PackUnpack.Ish.Crc16Generator A_1, global::Motorola.Acp.PackUnpack.Ish.IshItemFactory A_2)
		{
			int a_ = 12;
			base..ctor();
			if (A_0 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("펢쒤햦\udda8슪\ud9ac욮\udeb0\uddb2", a_));
			}
			if (A_1 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("삢힤쒦캪쎬쪮쎰튲솴\ud8b6쮸", a_));
			}
			if (A_2 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪢톤슦쒨첬첮얰\udcb2잴캶", a_));
			}
			A_0.Image.Position = 0L;
			this.c = new global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader(A_0.Image, true);
			this.d = A_0;
			this.a = A_1;
			this.e = A_2;
			this.j = null;
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00037148 File Offset: 0x00035348
		internal global::Motorola.Acp.PackUnpack.Ish.Partition Partition
		{
			get
			{
				short num = (short)1133707264;
				short num2 = num;
				num = (short)623050753;
				if (num != 0)
				{
				}
				num = (short)213501883;
				short num3 = num;
				num = (short)511363003;
				switch (num3 == num)
				{
				}
				num = (short)665190400;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000261 RID: 609 RVA: 0x000371F4 File Offset: 0x000353F4
		internal int ItemType
		{
			get
			{
				short num = (short)791019520;
				short num2 = num;
				num = (short)558561600;
				short num3 = num;
				num = (short)1747319104;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)802816000;
					if (num != 0)
					{
					}
					if (this.b == global::Motorola.Acp.PackUnpack.Ish.ReadState.Interactive)
					{
						num = (short)1632043009;
						if (num != 0)
						{
						}
						return this.f.Type;
					}
					break;
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000262 RID: 610 RVA: 0x000372B8 File Offset: 0x000354B8
		internal int ItemId
		{
			get
			{
				short num = (short)753008640;
				short num2 = num;
				num = (short)1059007977;
				short num3 = num;
				num = (short)1819749865;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1628831744;
					if (num != 0)
					{
					}
					num = (short)22609921;
					if (num != 0)
					{
					}
					if (this.b == global::Motorola.Acp.PackUnpack.Ish.ReadState.Interactive)
					{
						return this.f.Id;
					}
					break;
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0003737C File Offset: 0x0003557C
		internal global::Motorola.Acp.PackUnpack.Ish.IshItemName ItemName
		{
			get
			{
				short num = (short)1525612544;
				short num2 = num;
				num = (short)1411964113;
				short num3 = num;
				num = (short)1155062993;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1841102849;
					if (num != 0)
					{
					}
					num = (short)2079981568;
					if (num != 0)
					{
					}
					if (this.b == global::Motorola.Acp.PackUnpack.Ish.ReadState.Interactive)
					{
						return this.f;
					}
					break;
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0003743C File Offset: 0x0003563C
		internal int ItemDataLength
		{
			get
			{
				short num = (short)874512384;
				short num2 = num;
				num = (short)281737021;
				short num3 = num;
				num = (short)2079455037;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1791229952;
					if (num != 0)
					{
					}
					if (this.b == global::Motorola.Acp.PackUnpack.Ish.ReadState.Interactive)
					{
						return this.g;
					}
					num = (short)648675329;
					if (num != 0)
					{
					}
					break;
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00037500 File Offset: 0x00035700
		internal global::Motorola.Acp.PackUnpack.Ish.ItemStructureType ItemStructureType
		{
			get
			{
				short num = (short)1287520256;
				short num2 = num;
				num = (short)51224003;
				short num3 = num;
				num = (short)995270083;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1133117441;
					if (num != 0)
					{
					}
					num = (short)1394212864;
					if (num != 0)
					{
					}
					if (this.b == global::Motorola.Acp.PackUnpack.Ish.ReadState.Interactive)
					{
						return this.h;
					}
					break;
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000266 RID: 614 RVA: 0x000375C0 File Offset: 0x000357C0
		internal short ItemCrc
		{
			get
			{
				short num = (short)713883648;
				short num2 = num;
				num = (short)1756974932;
				short num3 = num;
				num = (short)1119768404;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1565851648;
					if (num != 0)
					{
					}
					if (this.b == global::Motorola.Acp.PackUnpack.Ish.ReadState.Interactive)
					{
						num = (short)570556417;
						if (num != 0)
						{
						}
						return this.i;
					}
					break;
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00037684 File Offset: 0x00035884
		internal global::Motorola.Acp.PackUnpack.Ish.IshItem Item
		{
			get
			{
				short num = (short)1259077632;
				short num2 = num;
				num = (short)486033608;
				short num3 = num;
				num = (short)1045711048;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)699531265;
					if (num != 0)
					{
					}
					num = (short)1722941440;
					if (num != 0)
					{
					}
					if (this.b == global::Motorola.Acp.PackUnpack.Ish.ReadState.Interactive)
					{
						return this.j;
					}
					break;
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00037744 File Offset: 0x00035944
		internal bool EOS
		{
			get
			{
				short num = (short)528023552;
				short num2 = num;
				num = (short)335643017;
				short num3 = num;
				num = (short)1523286409;
				switch (num3 == num)
				{
				}
				num = (short)1031536640;
				if (num != 0)
				{
				}
				num = (short)1306132481;
				if (num != 0)
				{
				}
				return this.d.Image.Position >= this.d.Image.Length;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00037814 File Offset: 0x00035A14
		// (set) Token: 0x0600026A RID: 618 RVA: 0x000378C0 File Offset: 0x00035AC0
		public global::Motorola.Acp.PackUnpack.Ish.ReadState ReadState
		{
			get
			{
				short num = (short)2068054016;
				short num2 = num;
				num = (short)2096321011;
				short num3 = num;
				num = (short)840454643;
				switch (num3 == num)
				{
				}
				num = (short)1186070529;
				if (num != 0)
				{
				}
				num = (short)535494656;
				if (num != 0)
				{
				}
				return this.b;
			}
			protected set
			{
				short num = (short)127205376;
				short num2 = num;
				num = (short)1251162123;
				short num3 = num;
				num = (short)1004943371;
				switch (num3 == num)
				{
				}
				num = (short)1721171968;
				if (num != 0)
				{
				}
				num = (short)1737293825;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00037970 File Offset: 0x00035B70
		internal bool j()
		{
			int a_ = 18;
			short num = (short)940179456;
			switch (num)
			{
			default:
			{
				num = (short)445054976;
				short num2 = num;
				num = (short)1642266624;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_8C;
						}
						continue;
					case 1:
						return false;
					case 2:
						if (this.b != global::Motorola.Acp.PackUnpack.Ish.ReadState.Interactive)
						{
							num = (short)1232011265;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A1;
					case 3:
						try
						{
							num = (short)550699009;
							num3 = (int)((global::System.IntPtr)num);
							int num6;
							int num7;
							for (;;)
							{
								global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream baseStream;
								switch (num3)
								{
								case 0:
									if (baseStream.b(2) == 0)
									{
										num = (short)2049900548;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.b = global::Motorola.Acp.PackUnpack.Ish.ReadState.Interactive;
									flag = true;
									num = (short)1142620170;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_11F;
									}
									continue;
								case 2:
								{
									num = (short)1418727789;
									short num4 = num;
									num = (short)1249710445;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_476;
									default:
										num = (short)836435968;
										if (num != 0)
										{
										}
										num = (short)1492910086;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_47B;
								case 4:
									goto IL_1B1;
								case 5:
									goto IL_494;
								case 6:
									if (!this.EOS)
									{
										num = (short)895418384;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_47B;
								case 7:
									if (flag)
									{
										num = (short)497352707;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1035010057;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_434;
								case 9:
									if (this.d.Image.Length != 0L)
									{
										num = (short)24903682;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_47B;
								case 11:
									goto IL_476;
								case 12:
									goto IL_394;
								case 13:
								{
									short num5;
									if (num5 != this.i)
									{
										num = (short)1239482376;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)119537678;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
									if (this.a(num6))
									{
										num = (short)430440459;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 15:
								{
									if (this.g <= 2)
									{
										num = (short)2070413324;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.g -= 2;
									baseStream = this.c.BaseStream;
									byte[] buffer = baseStream.a();
									int index = baseStream.b();
									short num5 = this.a.Compute(buffer, index, this.g);
									baseStream.Seek((long)this.g, global::System.IO.SeekOrigin.Current);
									this.i = this.c.ReadInt16();
									num = (short)880541709;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
									num6 = (int)this.c.ReadUInt16();
									num7 = (int)this.c.ReadUInt16();
									this.f = new global::Motorola.Acp.PackUnpack.Ish.IshItemName(num6, num7);
									this.g = (int)this.c.ReadUInt16();
									num = (short)993329167;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1B6:
								num = (short)1650327559;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_11F:
								goto IL_1B6;
								IL_476:
								baseStream.Seek((long)(-(long)(this.g + 2)), global::System.IO.SeekOrigin.Current);
								this.h = (global::Motorola.Acp.PackUnpack.Ish.ItemStructureType)this.c.ReadByte();
								this.g--;
								this.j = this.a(this.h, num6, num7, this.g, this.c);
								num = (short)2000158720;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_47B:
								num = (short)97386501;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_1B1:
							throw new global::System.IO.InvalidDataException();
							IL_394:
							throw new global::System.IO.InvalidDataException();
							IL_434:
							throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.InvalidCrcException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udda8튪\uddac쪮记鎲캴螶쒸鞺鶼횾ꗀ蓼볆뛊", a_), num6, num7));
							IL_494:
							return flag;
						}
						catch (global::System.Exception ex)
						{
							this.b = global::Motorola.Acp.PackUnpack.Ish.ReadState.Error;
							throw ex;
						}
						goto IL_4A1;
					case 4:
						num = (short)1199439873;
						if (num != 0)
						{
						}
						num = (short)2142306306;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_8C:
					if (this.b != global::Motorola.Acp.PackUnpack.Ish.ReadState.Initial)
					{
						num = (short)290390020;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_4A1:
					flag = false;
					num = (short)1970012163;
					num3 = (int)((global::System.IntPtr)num);
				}
				return false;
			}
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00037EC0 File Offset: 0x000360C0
		private bool a(int A_0)
		{
			short num = (short)1148846080;
			short num2 = num;
			num = (short)1716345740;
			short num3 = num;
			num = (short)1363762060;
			switch (num3 == num)
			{
			}
			num = (short)1678245889;
			if (num != 0)
			{
			}
			num = (short)1204355072;
			if (num != 0)
			{
			}
			return this.d.Layouts.Find(A_0) != null;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00037F80 File Offset: 0x00036180
		private global::Motorola.Acp.PackUnpack.Ish.IshItem a(global::Motorola.Acp.PackUnpack.Ish.ItemStructureType A_0, int A_1, int A_2, int A_3, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader A_4)
		{
			short num = (short)36831232;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_54;
				}
				global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout structureLayout;
				global::Motorola.Acp.PackUnpack.Ish.IshItem result;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						if (A_0 == global::Motorola.Acp.PackUnpack.Ish.ItemStructureType.Composite)
						{
							num = (short)1678180353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1349320711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout compositeLayout = structureLayout as global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout;
						result = this.e.CreateItem(compositeLayout.CompositeType, A_2, compositeLayout, A_3, A_4);
						num = (short)864878596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_153;
					case 3:
					{
						num = (short)436910570;
						short num3 = num;
						num = (short)637057514;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1607794688;
							if (num != 0)
							{
							}
							global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout = structureLayout as global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout;
							result = this.e.CreateItem(listLayout.ListletType, A_2, listLayout, A_3, A_4);
							num = (short)167772162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 4:
						goto IL_1CC;
					case 5:
						num = (short)507183105;
						if (num != 0)
						{
						}
						if (A_0 == global::Motorola.Acp.PackUnpack.Ish.ItemStructureType.ListListlet)
						{
							num = (short)1653014531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D1;
					case 6:
					{
						global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout2 = structureLayout as global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout;
						result = this.e.CreateItem(listLayout2.HeaderType, A_2, listLayout2, A_3, A_4);
						num = (short)1139933192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (A_0 == global::Motorola.Acp.PackUnpack.Ish.ItemStructureType.ListHeader)
						{
							num = (short)784859142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1960640517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_18F;
					}
					goto IL_54;
				}
				IL_153:
				IL_18F:
				IL_1CC:
				return result;
				IL_1D1:
				throw new global::System.IO.InvalidDataException();
				IL_54:
				structureLayout = this.d.Layouts.Find(A_1);
				result = null;
				num = (short)326500352;
				short num4 = num;
				num = (short)689307648;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00038208 File Offset: 0x00036408
		internal void k()
		{
			short num = (short)715980800;
			short num2 = num;
			num = (short)836786040;
			short num3 = num;
			num = (short)1995134840;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)925696001;
				if (num != 0)
				{
				}
				num = (short)1666383872;
				if (num != 0)
				{
				}
				num = (short)1285226496;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_CF;
					}
					continue;
				case 1:
					if (this.b != global::Motorola.Acp.PackUnpack.Ish.ReadState.Interactive)
					{
						num = (short)948895746;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_123;
				case 2:
					return;
				case 3:
					num = (short)1477574657;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_CF:
				if (this.b == global::Motorola.Acp.PackUnpack.Ish.ReadState.Initial)
				{
					goto IL_123;
				}
				num = (short)447873027;
				num4 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_123:
			((global::System.IDisposable)this).Dispose();
			this.b = global::Motorola.Acp.PackUnpack.Ish.ReadState.Closed;
		}

		// Token: 0x040000D7 RID: 215
		private global::Motorola.Acp.PackUnpack.Ish.Crc16Generator a;

		// Token: 0x040000D8 RID: 216
		private global::Motorola.Acp.PackUnpack.Ish.ReadState b;

		// Token: 0x040000D9 RID: 217
		private global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader c;

		// Token: 0x040000DA RID: 218
		private global::Motorola.Acp.PackUnpack.Ish.Partition d;

		// Token: 0x040000DB RID: 219
		private global::Motorola.Acp.PackUnpack.Ish.IshItemFactory e;

		// Token: 0x040000DC RID: 220
		private global::Motorola.Acp.PackUnpack.Ish.IshItemName f;

		// Token: 0x040000DD RID: 221
		private int g;

		// Token: 0x040000DE RID: 222
		private global::Motorola.Acp.PackUnpack.Ish.ItemStructureType h;

		// Token: 0x040000DF RID: 223
		private short i;

		// Token: 0x040000E0 RID: 224
		private global::Motorola.Acp.PackUnpack.Ish.IshItem j;

		// Token: 0x040000E1 RID: 225
		private const int k = 2;

		// Token: 0x040000E2 RID: 226
		private const int l = 6;
	}
}
