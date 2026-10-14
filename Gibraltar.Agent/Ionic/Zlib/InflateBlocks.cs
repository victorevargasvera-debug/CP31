using System;

namespace Ionic.Zlib
{
	// Token: 0x0200042B RID: 1067
	internal sealed class InflateBlocks
	{
		// Token: 0x06002E73 RID: 11891 RVA: 0x0009ECA0 File Offset: 0x0009CEA0
		internal InflateBlocks(global::Ionic.Zlib.ZlibCodec codec, object checkfn, int w)
		{
			this._codec = codec;
			this.hufts = new int[4320];
			this.window = new byte[w];
			this.end = w;
			this.checkfn = checkfn;
			this.mode = global::Ionic.Zlib.InflateBlocks.InflateBlockMode.TYPE;
			this.Reset();
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x0009ED24 File Offset: 0x0009CF24
		internal uint Reset()
		{
			uint result = this.check;
			this.mode = global::Ionic.Zlib.InflateBlocks.InflateBlockMode.TYPE;
			this.bitk = 0;
			this.bitb = 0;
			this.readAt = (this.writeAt = 0);
			if (this.checkfn != null)
			{
				this._codec._Adler32 = (this.check = global::Ionic.Zlib.Adler.Adler32(0U, null, 0, 0));
			}
			return result;
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x0009ED88 File Offset: 0x0009CF88
		internal int Process(int r)
		{
			int num = this._codec.NextIn;
			int num2 = this._codec.AvailableBytesIn;
			int num3 = this.bitb;
			int i = this.bitk;
			int num4 = this.writeAt;
			int num5 = (num4 < this.readAt) ? (this.readAt - num4 - 1) : (this.end - num4);
			int num6;
			for (;;)
			{
				switch (this.mode)
				{
				case global::Ionic.Zlib.InflateBlocks.InflateBlockMode.TYPE:
					while (i < 3)
					{
						if (num2 == 0)
						{
							goto IL_A0;
						}
						r = 0;
						num2--;
						num3 |= (int)(this._codec.InputBuffer[num++] & byte.MaxValue) << i;
						i += 8;
					}
					num6 = (num3 & 7);
					this.last = (num6 & 1);
					switch ((uint)num6 >> 1)
					{
					case 0U:
						num3 >>= 3;
						i -= 3;
						num6 = (i & 7);
						num3 >>= num6;
						i -= num6;
						this.mode = global::Ionic.Zlib.InflateBlocks.InflateBlockMode.LENS;
						continue;
					case 1U:
					{
						int[] array = new int[1];
						int[] array2 = new int[1];
						int[][] array3 = new int[1][];
						int[][] array4 = new int[1][];
						global::Ionic.Zlib.InfTree.inflate_trees_fixed(array, array2, array3, array4, this._codec);
						this.codes.Init(array[0], array2[0], array3[0], 0, array4[0], 0);
						num3 >>= 3;
						i -= 3;
						this.mode = global::Ionic.Zlib.InflateBlocks.InflateBlockMode.CODES;
						continue;
					}
					case 2U:
						num3 >>= 3;
						i -= 3;
						this.mode = global::Ionic.Zlib.InflateBlocks.InflateBlockMode.TABLE;
						continue;
					case 3U:
						goto IL_1FC;
					default:
						continue;
					}
					break;
				case global::Ionic.Zlib.InflateBlocks.InflateBlockMode.LENS:
					while (i < 32)
					{
						if (num2 == 0)
						{
							goto IL_284;
						}
						r = 0;
						num2--;
						num3 |= (int)(this._codec.InputBuffer[num++] & byte.MaxValue) << i;
						i += 8;
					}
					if ((~num3 >> 16 & 65535) != (num3 & 65535))
					{
						goto Block_8;
					}
					this.left = (num3 & 65535);
					i = (num3 = 0);
					this.mode = ((this.left != 0) ? global::Ionic.Zlib.InflateBlocks.InflateBlockMode.STORED : ((this.last != 0) ? global::Ionic.Zlib.InflateBlocks.InflateBlockMode.DRY : global::Ionic.Zlib.InflateBlocks.InflateBlockMode.TYPE));
					continue;
				case global::Ionic.Zlib.InflateBlocks.InflateBlockMode.STORED:
					if (num2 == 0)
					{
						goto Block_11;
					}
					if (num5 == 0)
					{
						if (num4 == this.end && this.readAt != 0)
						{
							num4 = 0;
							num5 = ((num4 < this.readAt) ? (this.readAt - num4 - 1) : (this.end - num4));
						}
						if (num5 == 0)
						{
							this.writeAt = num4;
							r = this.Flush(r);
							num4 = this.writeAt;
							num5 = ((num4 < this.readAt) ? (this.readAt - num4 - 1) : (this.end - num4));
							if (num4 == this.end && this.readAt != 0)
							{
								num4 = 0;
								num5 = ((num4 < this.readAt) ? (this.readAt - num4 - 1) : (this.end - num4));
							}
							if (num5 == 0)
							{
								goto Block_21;
							}
						}
					}
					r = 0;
					num6 = this.left;
					if (num6 > num2)
					{
						num6 = num2;
					}
					if (num6 > num5)
					{
						num6 = num5;
					}
					global::System.Array.Copy(this._codec.InputBuffer, num, this.window, num4, num6);
					num += num6;
					num2 -= num6;
					num4 += num6;
					num5 -= num6;
					if ((this.left -= num6) == 0)
					{
						this.mode = ((this.last != 0) ? global::Ionic.Zlib.InflateBlocks.InflateBlockMode.DRY : global::Ionic.Zlib.InflateBlocks.InflateBlockMode.TYPE);
						continue;
					}
					continue;
				case global::Ionic.Zlib.InflateBlocks.InflateBlockMode.TABLE:
					while (i < 14)
					{
						if (num2 == 0)
						{
							goto IL_5F9;
						}
						r = 0;
						num2--;
						num3 |= (int)(this._codec.InputBuffer[num++] & byte.MaxValue) << i;
						i += 8;
					}
					num6 = (this.table = (num3 & 16383));
					if ((num6 & 31) > 29 || (num6 >> 5 & 31) > 29)
					{
						goto IL_6A8;
					}
					num6 = 258 + (num6 & 31) + (num6 >> 5 & 31);
					if (this.blens == null || this.blens.Length < num6)
					{
						this.blens = new int[num6];
					}
					else
					{
						global::System.Array.Clear(this.blens, 0, num6);
					}
					num3 >>= 14;
					i -= 14;
					this.index = 0;
					this.mode = global::Ionic.Zlib.InflateBlocks.InflateBlockMode.BTREE;
					goto IL_844;
				case global::Ionic.Zlib.InflateBlocks.InflateBlockMode.BTREE:
					goto IL_844;
				case global::Ionic.Zlib.InflateBlocks.InflateBlockMode.DTREE:
					goto IL_942;
				case global::Ionic.Zlib.InflateBlocks.InflateBlockMode.CODES:
					goto IL_D84;
				case global::Ionic.Zlib.InflateBlocks.InflateBlockMode.DRY:
					goto IL_E67;
				case global::Ionic.Zlib.InflateBlocks.InflateBlockMode.DONE:
					goto IL_F16;
				case global::Ionic.Zlib.InflateBlocks.InflateBlockMode.BAD:
					goto IL_F6F;
				}
				break;
				IL_844:
				while (this.index < 4 + (this.table >> 10))
				{
					while (i < 3)
					{
						if (num2 == 0)
						{
							goto IL_794;
						}
						r = 0;
						num2--;
						num3 |= (int)(this._codec.InputBuffer[num++] & byte.MaxValue) << i;
						i += 8;
					}
					int[] array5 = this.blens;
					int[] array6 = global::Ionic.Zlib.InflateBlocks.border;
					int num7 = this.index;
					this.index = num7 + 1;
					array5[array6[num7]] = (num3 & 7);
					num3 >>= 3;
					i -= 3;
				}
				while (this.index < 19)
				{
					int[] array7 = this.blens;
					int[] array8 = global::Ionic.Zlib.InflateBlocks.border;
					int num7 = this.index;
					this.index = num7 + 1;
					array7[array8[num7]] = 0;
				}
				this.bb[0] = 7;
				num6 = this.inftree.inflate_trees_bits(this.blens, this.bb, this.tb, this.hufts, this._codec);
				if (num6 != 0)
				{
					goto Block_34;
				}
				this.index = 0;
				this.mode = global::Ionic.Zlib.InflateBlocks.InflateBlockMode.DTREE;
				for (;;)
				{
					IL_942:
					num6 = this.table;
					if (this.index >= 258 + (num6 & 31) + (num6 >> 5 & 31))
					{
						break;
					}
					num6 = this.bb[0];
					while (i < num6)
					{
						if (num2 == 0)
						{
							goto IL_985;
						}
						r = 0;
						num2--;
						num3 |= (int)(this._codec.InputBuffer[num++] & byte.MaxValue) << i;
						i += 8;
					}
					num6 = this.hufts[(this.tb[0] + (num3 & global::Ionic.Zlib.InternalInflateConstants.InflateMask[num6])) * 3 + 1];
					int num8 = this.hufts[(this.tb[0] + (num3 & global::Ionic.Zlib.InternalInflateConstants.InflateMask[num6])) * 3 + 2];
					if (num8 < 16)
					{
						num3 >>= num6;
						i -= num6;
						int[] array9 = this.blens;
						int num7 = this.index;
						this.index = num7 + 1;
						array9[num7] = num8;
					}
					else
					{
						int num9 = (num8 == 18) ? 7 : (num8 - 14);
						int num10 = (num8 == 18) ? 11 : 3;
						while (i < num6 + num9)
						{
							if (num2 == 0)
							{
								goto IL_ABE;
							}
							r = 0;
							num2--;
							num3 |= (int)(this._codec.InputBuffer[num++] & byte.MaxValue) << i;
							i += 8;
						}
						num3 >>= num6;
						i -= num6;
						num10 += (num3 & global::Ionic.Zlib.InternalInflateConstants.InflateMask[num9]);
						num3 >>= num9;
						i -= num9;
						num9 = this.index;
						num6 = this.table;
						if (num9 + num10 > 258 + (num6 & 31) + (num6 >> 5 & 31) || (num8 == 16 && num9 < 1))
						{
							goto IL_BAD;
						}
						num8 = ((num8 == 16) ? this.blens[num9 - 1] : 0);
						do
						{
							this.blens[num9++] = num8;
						}
						while (--num10 != 0);
						this.index = num9;
					}
				}
				this.tb[0] = -1;
				int[] array10 = new int[]
				{
					9
				};
				int[] array11 = new int[]
				{
					6
				};
				int[] array12 = new int[1];
				int[] array13 = new int[1];
				num6 = this.table;
				num6 = this.inftree.inflate_trees_dynamic(257 + (num6 & 31), 1 + (num6 >> 5 & 31), this.blens, array10, array11, array12, array13, this.hufts, this._codec);
				if (num6 != 0)
				{
					goto Block_48;
				}
				this.codes.Init(array10[0], array11[0], this.hufts, array12[0], this.hufts, array13[0]);
				this.mode = global::Ionic.Zlib.InflateBlocks.InflateBlockMode.CODES;
				IL_D84:
				this.bitb = num3;
				this.bitk = i;
				this._codec.AvailableBytesIn = num2;
				this._codec.TotalBytesIn += (long)(num - this._codec.NextIn);
				this._codec.NextIn = num;
				this.writeAt = num4;
				r = this.codes.Process(this, r);
				if (r != 1)
				{
					goto Block_50;
				}
				r = 0;
				num = this._codec.NextIn;
				num2 = this._codec.AvailableBytesIn;
				num3 = this.bitb;
				i = this.bitk;
				num4 = this.writeAt;
				num5 = ((num4 < this.readAt) ? (this.readAt - num4 - 1) : (this.end - num4));
				if (this.last != 0)
				{
					goto IL_E60;
				}
				this.mode = global::Ionic.Zlib.InflateBlocks.InflateBlockMode.TYPE;
			}
			r = -2;
			this.bitb = num3;
			this.bitk = i;
			this._codec.AvailableBytesIn = num2;
			this._codec.TotalBytesIn += (long)(num - this._codec.NextIn);
			this._codec.NextIn = num;
			this.writeAt = num4;
			return this.Flush(r);
			IL_A0:
			this.bitb = num3;
			this.bitk = i;
			this._codec.AvailableBytesIn = num2;
			this._codec.TotalBytesIn += (long)(num - this._codec.NextIn);
			this._codec.NextIn = num;
			this.writeAt = num4;
			return this.Flush(r);
			IL_1FC:
			num3 >>= 3;
			i -= 3;
			this.mode = global::Ionic.Zlib.InflateBlocks.InflateBlockMode.BAD;
			this._codec.Message = "invalid block type";
			r = -3;
			this.bitb = num3;
			this.bitk = i;
			this._codec.AvailableBytesIn = num2;
			this._codec.TotalBytesIn += (long)(num - this._codec.NextIn);
			this._codec.NextIn = num;
			this.writeAt = num4;
			return this.Flush(r);
			IL_284:
			this.bitb = num3;
			this.bitk = i;
			this._codec.AvailableBytesIn = num2;
			this._codec.TotalBytesIn += (long)(num - this._codec.NextIn);
			this._codec.NextIn = num;
			this.writeAt = num4;
			return this.Flush(r);
			Block_8:
			this.mode = global::Ionic.Zlib.InflateBlocks.InflateBlockMode.BAD;
			this._codec.Message = "invalid stored block lengths";
			r = -3;
			this.bitb = num3;
			this.bitk = i;
			this._codec.AvailableBytesIn = num2;
			this._codec.TotalBytesIn += (long)(num - this._codec.NextIn);
			this._codec.NextIn = num;
			this.writeAt = num4;
			return this.Flush(r);
			Block_11:
			this.bitb = num3;
			this.bitk = i;
			this._codec.AvailableBytesIn = num2;
			this._codec.TotalBytesIn += (long)(num - this._codec.NextIn);
			this._codec.NextIn = num;
			this.writeAt = num4;
			return this.Flush(r);
			Block_21:
			this.bitb = num3;
			this.bitk = i;
			this._codec.AvailableBytesIn = num2;
			this._codec.TotalBytesIn += (long)(num - this._codec.NextIn);
			this._codec.NextIn = num;
			this.writeAt = num4;
			return this.Flush(r);
			IL_5F9:
			this.bitb = num3;
			this.bitk = i;
			this._codec.AvailableBytesIn = num2;
			this._codec.TotalBytesIn += (long)(num - this._codec.NextIn);
			this._codec.NextIn = num;
			this.writeAt = num4;
			return this.Flush(r);
			IL_6A8:
			this.mode = global::Ionic.Zlib.InflateBlocks.InflateBlockMode.BAD;
			this._codec.Message = "too many length or distance symbols";
			r = -3;
			this.bitb = num3;
			this.bitk = i;
			this._codec.AvailableBytesIn = num2;
			this._codec.TotalBytesIn += (long)(num - this._codec.NextIn);
			this._codec.NextIn = num;
			this.writeAt = num4;
			return this.Flush(r);
			IL_794:
			this.bitb = num3;
			this.bitk = i;
			this._codec.AvailableBytesIn = num2;
			this._codec.TotalBytesIn += (long)(num - this._codec.NextIn);
			this._codec.NextIn = num;
			this.writeAt = num4;
			return this.Flush(r);
			Block_34:
			r = num6;
			if (r == -3)
			{
				this.blens = null;
				this.mode = global::Ionic.Zlib.InflateBlocks.InflateBlockMode.BAD;
			}
			this.bitb = num3;
			this.bitk = i;
			this._codec.AvailableBytesIn = num2;
			this._codec.TotalBytesIn += (long)(num - this._codec.NextIn);
			this._codec.NextIn = num;
			this.writeAt = num4;
			return this.Flush(r);
			IL_985:
			this.bitb = num3;
			this.bitk = i;
			this._codec.AvailableBytesIn = num2;
			this._codec.TotalBytesIn += (long)(num - this._codec.NextIn);
			this._codec.NextIn = num;
			this.writeAt = num4;
			return this.Flush(r);
			IL_ABE:
			this.bitb = num3;
			this.bitk = i;
			this._codec.AvailableBytesIn = num2;
			this._codec.TotalBytesIn += (long)(num - this._codec.NextIn);
			this._codec.NextIn = num;
			this.writeAt = num4;
			return this.Flush(r);
			IL_BAD:
			this.blens = null;
			this.mode = global::Ionic.Zlib.InflateBlocks.InflateBlockMode.BAD;
			this._codec.Message = "invalid bit length repeat";
			r = -3;
			this.bitb = num3;
			this.bitk = i;
			this._codec.AvailableBytesIn = num2;
			this._codec.TotalBytesIn += (long)(num - this._codec.NextIn);
			this._codec.NextIn = num;
			this.writeAt = num4;
			return this.Flush(r);
			Block_48:
			if (num6 == -3)
			{
				this.blens = null;
				this.mode = global::Ionic.Zlib.InflateBlocks.InflateBlockMode.BAD;
			}
			r = num6;
			this.bitb = num3;
			this.bitk = i;
			this._codec.AvailableBytesIn = num2;
			this._codec.TotalBytesIn += (long)(num - this._codec.NextIn);
			this._codec.NextIn = num;
			this.writeAt = num4;
			return this.Flush(r);
			Block_50:
			return this.Flush(r);
			IL_E60:
			this.mode = global::Ionic.Zlib.InflateBlocks.InflateBlockMode.DRY;
			IL_E67:
			this.writeAt = num4;
			r = this.Flush(r);
			num4 = this.writeAt;
			int num11 = (num4 < this.readAt) ? (this.readAt - num4 - 1) : (this.end - num4);
			if (this.readAt != this.writeAt)
			{
				this.bitb = num3;
				this.bitk = i;
				this._codec.AvailableBytesIn = num2;
				this._codec.TotalBytesIn += (long)(num - this._codec.NextIn);
				this._codec.NextIn = num;
				this.writeAt = num4;
				return this.Flush(r);
			}
			this.mode = global::Ionic.Zlib.InflateBlocks.InflateBlockMode.DONE;
			IL_F16:
			r = 1;
			this.bitb = num3;
			this.bitk = i;
			this._codec.AvailableBytesIn = num2;
			this._codec.TotalBytesIn += (long)(num - this._codec.NextIn);
			this._codec.NextIn = num;
			this.writeAt = num4;
			return this.Flush(r);
			IL_F6F:
			r = -3;
			this.bitb = num3;
			this.bitk = i;
			this._codec.AvailableBytesIn = num2;
			this._codec.TotalBytesIn += (long)(num - this._codec.NextIn);
			this._codec.NextIn = num;
			this.writeAt = num4;
			return this.Flush(r);
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x0009FDBC File Offset: 0x0009DFBC
		internal void Free()
		{
			this.Reset();
			this.window = null;
			this.hufts = null;
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x0009FDD4 File Offset: 0x0009DFD4
		internal void SetDictionary(byte[] d, int start, int n)
		{
			global::System.Array.Copy(d, start, this.window, 0, n);
			this.writeAt = n;
			this.readAt = n;
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x0009FE04 File Offset: 0x0009E004
		internal int SyncPoint()
		{
			if (this.mode != global::Ionic.Zlib.InflateBlocks.InflateBlockMode.LENS)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x0009FE18 File Offset: 0x0009E018
		internal int Flush(int r)
		{
			for (int i = 0; i < 2; i++)
			{
				int num;
				if (i == 0)
				{
					num = ((this.readAt <= this.writeAt) ? this.writeAt : this.end) - this.readAt;
				}
				else
				{
					num = this.writeAt - this.readAt;
				}
				if (num == 0)
				{
					if (r == -5)
					{
						r = 0;
					}
					return r;
				}
				if (num > this._codec.AvailableBytesOut)
				{
					num = this._codec.AvailableBytesOut;
				}
				if (num != 0 && r == -5)
				{
					r = 0;
				}
				this._codec.AvailableBytesOut -= num;
				this._codec.TotalBytesOut += (long)num;
				if (this.checkfn != null)
				{
					this._codec._Adler32 = (this.check = global::Ionic.Zlib.Adler.Adler32(this.check, this.window, this.readAt, num));
				}
				global::System.Array.Copy(this.window, this.readAt, this._codec.OutputBuffer, this._codec.NextOut, num);
				this._codec.NextOut += num;
				this.readAt += num;
				if (this.readAt == this.end && i == 0)
				{
					this.readAt = 0;
					if (this.writeAt == this.end)
					{
						this.writeAt = 0;
					}
				}
				else
				{
					i++;
				}
			}
			return r;
		}

		// Token: 0x04000FFA RID: 4090
		private const int MANY = 1440;

		// Token: 0x04000FFB RID: 4091
		internal static readonly int[] border = new int[]
		{
			16,
			17,
			18,
			0,
			8,
			7,
			9,
			6,
			10,
			5,
			11,
			4,
			12,
			3,
			13,
			2,
			14,
			1,
			15
		};

		// Token: 0x04000FFC RID: 4092
		private global::Ionic.Zlib.InflateBlocks.InflateBlockMode mode;

		// Token: 0x04000FFD RID: 4093
		internal int left;

		// Token: 0x04000FFE RID: 4094
		internal int table;

		// Token: 0x04000FFF RID: 4095
		internal int index;

		// Token: 0x04001000 RID: 4096
		internal int[] blens;

		// Token: 0x04001001 RID: 4097
		internal int[] bb = new int[1];

		// Token: 0x04001002 RID: 4098
		internal int[] tb = new int[1];

		// Token: 0x04001003 RID: 4099
		internal global::Ionic.Zlib.InflateCodes codes = new global::Ionic.Zlib.InflateCodes();

		// Token: 0x04001004 RID: 4100
		internal int last;

		// Token: 0x04001005 RID: 4101
		internal global::Ionic.Zlib.ZlibCodec _codec;

		// Token: 0x04001006 RID: 4102
		internal int bitk;

		// Token: 0x04001007 RID: 4103
		internal int bitb;

		// Token: 0x04001008 RID: 4104
		internal int[] hufts;

		// Token: 0x04001009 RID: 4105
		internal byte[] window;

		// Token: 0x0400100A RID: 4106
		internal int end;

		// Token: 0x0400100B RID: 4107
		internal int readAt;

		// Token: 0x0400100C RID: 4108
		internal int writeAt;

		// Token: 0x0400100D RID: 4109
		internal object checkfn;

		// Token: 0x0400100E RID: 4110
		internal uint check;

		// Token: 0x0400100F RID: 4111
		internal global::Ionic.Zlib.InfTree inftree = new global::Ionic.Zlib.InfTree();

		// Token: 0x020004DD RID: 1245
		private enum InflateBlockMode
		{
			// Token: 0x040013F3 RID: 5107
			TYPE,
			// Token: 0x040013F4 RID: 5108
			LENS,
			// Token: 0x040013F5 RID: 5109
			STORED,
			// Token: 0x040013F6 RID: 5110
			TABLE,
			// Token: 0x040013F7 RID: 5111
			BTREE,
			// Token: 0x040013F8 RID: 5112
			DTREE,
			// Token: 0x040013F9 RID: 5113
			CODES,
			// Token: 0x040013FA RID: 5114
			DRY,
			// Token: 0x040013FB RID: 5115
			DONE,
			// Token: 0x040013FC RID: 5116
			BAD
		}
	}
}
