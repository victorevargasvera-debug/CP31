using System;

namespace Ionic.Zlib
{
	// Token: 0x02000016 RID: 22
	internal sealed class InflateManager
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00008CCF File Offset: 0x00006ECF
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00008CD7 File Offset: 0x00006ED7
		internal bool HandleRfc1950HeaderBytes
		{
			get
			{
				return this._handleRfc1950HeaderBytes;
			}
			set
			{
				this._handleRfc1950HeaderBytes = value;
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00008CE0 File Offset: 0x00006EE0
		public InflateManager()
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00008CEF File Offset: 0x00006EEF
		public InflateManager(bool expectRfc1950HeaderBytes)
		{
			this._handleRfc1950HeaderBytes = expectRfc1950HeaderBytes;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00008D08 File Offset: 0x00006F08
		internal int Reset()
		{
			this._codec.TotalBytesIn = (this._codec.TotalBytesOut = 0L);
			this._codec.Message = null;
			this.mode = (this.HandleRfc1950HeaderBytes ? global::Ionic.Zlib.InflateManager.InflateManagerMode.METHOD : global::Ionic.Zlib.InflateManager.InflateManagerMode.BLOCKS);
			this.blocks.Reset();
			return 0;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00008D5B File Offset: 0x00006F5B
		internal int End()
		{
			if (this.blocks != null)
			{
				this.blocks.Free();
			}
			this.blocks = null;
			return 0;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00008D78 File Offset: 0x00006F78
		internal int Initialize(global::Ionic.Zlib.ZlibCodec codec, int w)
		{
			this._codec = codec;
			this._codec.Message = null;
			this.blocks = null;
			if (w < 8 || w > 15)
			{
				this.End();
				throw new global::Ionic.Zlib.ZlibException("Bad window size.");
			}
			this.wbits = w;
			this.blocks = new global::Ionic.Zlib.InflateBlocks(codec, this.HandleRfc1950HeaderBytes ? this : null, 1 << w);
			this.Reset();
			return 0;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00008DE8 File Offset: 0x00006FE8
		internal int Inflate(global::Ionic.Zlib.FlushType flush)
		{
			if (this._codec.InputBuffer == null)
			{
				throw new global::Ionic.Zlib.ZlibException("InputBuffer is null. ");
			}
			int num = 0;
			int num2 = -5;
			int nextIn;
			for (;;)
			{
				switch (this.mode)
				{
				case global::Ionic.Zlib.InflateManager.InflateManagerMode.METHOD:
				{
					if (this._codec.AvailableBytesIn == 0)
					{
						return num2;
					}
					num2 = num;
					this._codec.AvailableBytesIn--;
					this._codec.TotalBytesIn += 1L;
					byte[] inputBuffer = this._codec.InputBuffer;
					global::Ionic.Zlib.ZlibCodec codec = this._codec;
					nextIn = codec.NextIn;
					codec.NextIn = nextIn + 1;
					if (((this.method = inputBuffer[nextIn]) & 15) != 8)
					{
						this.mode = global::Ionic.Zlib.InflateManager.InflateManagerMode.BAD;
						this._codec.Message = string.Format("unknown compression method (0x{0:X2})", this.method);
						this.marker = 5;
						continue;
					}
					if ((this.method >> 4) + 8 > this.wbits)
					{
						this.mode = global::Ionic.Zlib.InflateManager.InflateManagerMode.BAD;
						this._codec.Message = string.Format("invalid window size ({0})", (this.method >> 4) + 8);
						this.marker = 5;
						continue;
					}
					this.mode = global::Ionic.Zlib.InflateManager.InflateManagerMode.FLAG;
					continue;
				}
				case global::Ionic.Zlib.InflateManager.InflateManagerMode.FLAG:
				{
					if (this._codec.AvailableBytesIn == 0)
					{
						return num2;
					}
					num2 = num;
					this._codec.AvailableBytesIn--;
					this._codec.TotalBytesIn += 1L;
					byte[] inputBuffer2 = this._codec.InputBuffer;
					global::Ionic.Zlib.ZlibCodec codec2 = this._codec;
					nextIn = codec2.NextIn;
					codec2.NextIn = nextIn + 1;
					int num3 = inputBuffer2[nextIn] & 255;
					if (((this.method << 8) + num3) % 31 != 0)
					{
						this.mode = global::Ionic.Zlib.InflateManager.InflateManagerMode.BAD;
						this._codec.Message = "incorrect header check";
						this.marker = 5;
						continue;
					}
					this.mode = (((num3 & 32) == 0) ? global::Ionic.Zlib.InflateManager.InflateManagerMode.BLOCKS : global::Ionic.Zlib.InflateManager.InflateManagerMode.DICT4);
					continue;
				}
				case global::Ionic.Zlib.InflateManager.InflateManagerMode.DICT4:
				{
					if (this._codec.AvailableBytesIn == 0)
					{
						return num2;
					}
					num2 = num;
					this._codec.AvailableBytesIn--;
					this._codec.TotalBytesIn += 1L;
					byte[] inputBuffer3 = this._codec.InputBuffer;
					global::Ionic.Zlib.ZlibCodec codec3 = this._codec;
					nextIn = codec3.NextIn;
					codec3.NextIn = nextIn + 1;
					this.expectedCheck = (uint)(inputBuffer3[nextIn] << 24 & (long)((ulong)-16777216));
					this.mode = global::Ionic.Zlib.InflateManager.InflateManagerMode.DICT3;
					continue;
				}
				case global::Ionic.Zlib.InflateManager.InflateManagerMode.DICT3:
				{
					if (this._codec.AvailableBytesIn == 0)
					{
						return num2;
					}
					num2 = num;
					this._codec.AvailableBytesIn--;
					this._codec.TotalBytesIn += 1L;
					uint num4 = this.expectedCheck;
					byte[] inputBuffer4 = this._codec.InputBuffer;
					global::Ionic.Zlib.ZlibCodec codec4 = this._codec;
					nextIn = codec4.NextIn;
					codec4.NextIn = nextIn + 1;
					this.expectedCheck = num4 + (inputBuffer4[nextIn] << 16 & 16711680U);
					this.mode = global::Ionic.Zlib.InflateManager.InflateManagerMode.DICT2;
					continue;
				}
				case global::Ionic.Zlib.InflateManager.InflateManagerMode.DICT2:
				{
					if (this._codec.AvailableBytesIn == 0)
					{
						return num2;
					}
					num2 = num;
					this._codec.AvailableBytesIn--;
					this._codec.TotalBytesIn += 1L;
					uint num5 = this.expectedCheck;
					byte[] inputBuffer5 = this._codec.InputBuffer;
					global::Ionic.Zlib.ZlibCodec codec5 = this._codec;
					nextIn = codec5.NextIn;
					codec5.NextIn = nextIn + 1;
					this.expectedCheck = num5 + (inputBuffer5[nextIn] << 8 & 65280U);
					this.mode = global::Ionic.Zlib.InflateManager.InflateManagerMode.DICT1;
					continue;
				}
				case global::Ionic.Zlib.InflateManager.InflateManagerMode.DICT1:
					goto IL_383;
				case global::Ionic.Zlib.InflateManager.InflateManagerMode.DICT0:
					goto IL_40D;
				case global::Ionic.Zlib.InflateManager.InflateManagerMode.BLOCKS:
					num2 = this.blocks.Process(num2);
					if (num2 == -3)
					{
						this.mode = global::Ionic.Zlib.InflateManager.InflateManagerMode.BAD;
						this.marker = 0;
						continue;
					}
					if (num2 == 0)
					{
						num2 = num;
					}
					if (num2 != 1)
					{
						return num2;
					}
					num2 = num;
					this.computedCheck = this.blocks.Reset();
					if (!this.HandleRfc1950HeaderBytes)
					{
						goto Block_16;
					}
					this.mode = global::Ionic.Zlib.InflateManager.InflateManagerMode.CHECK4;
					continue;
				case global::Ionic.Zlib.InflateManager.InflateManagerMode.CHECK4:
				{
					if (this._codec.AvailableBytesIn == 0)
					{
						return num2;
					}
					num2 = num;
					this._codec.AvailableBytesIn--;
					this._codec.TotalBytesIn += 1L;
					byte[] inputBuffer6 = this._codec.InputBuffer;
					global::Ionic.Zlib.ZlibCodec codec6 = this._codec;
					nextIn = codec6.NextIn;
					codec6.NextIn = nextIn + 1;
					this.expectedCheck = (uint)(inputBuffer6[nextIn] << 24 & (long)((ulong)-16777216));
					this.mode = global::Ionic.Zlib.InflateManager.InflateManagerMode.CHECK3;
					continue;
				}
				case global::Ionic.Zlib.InflateManager.InflateManagerMode.CHECK3:
				{
					if (this._codec.AvailableBytesIn == 0)
					{
						return num2;
					}
					num2 = num;
					this._codec.AvailableBytesIn--;
					this._codec.TotalBytesIn += 1L;
					uint num6 = this.expectedCheck;
					byte[] inputBuffer7 = this._codec.InputBuffer;
					global::Ionic.Zlib.ZlibCodec codec7 = this._codec;
					nextIn = codec7.NextIn;
					codec7.NextIn = nextIn + 1;
					this.expectedCheck = num6 + (inputBuffer7[nextIn] << 16 & 16711680U);
					this.mode = global::Ionic.Zlib.InflateManager.InflateManagerMode.CHECK2;
					continue;
				}
				case global::Ionic.Zlib.InflateManager.InflateManagerMode.CHECK2:
				{
					if (this._codec.AvailableBytesIn == 0)
					{
						return num2;
					}
					num2 = num;
					this._codec.AvailableBytesIn--;
					this._codec.TotalBytesIn += 1L;
					uint num7 = this.expectedCheck;
					byte[] inputBuffer8 = this._codec.InputBuffer;
					global::Ionic.Zlib.ZlibCodec codec8 = this._codec;
					nextIn = codec8.NextIn;
					codec8.NextIn = nextIn + 1;
					this.expectedCheck = num7 + (inputBuffer8[nextIn] << 8 & 65280U);
					this.mode = global::Ionic.Zlib.InflateManager.InflateManagerMode.CHECK1;
					continue;
				}
				case global::Ionic.Zlib.InflateManager.InflateManagerMode.CHECK1:
				{
					if (this._codec.AvailableBytesIn == 0)
					{
						return num2;
					}
					num2 = num;
					this._codec.AvailableBytesIn--;
					this._codec.TotalBytesIn += 1L;
					uint num8 = this.expectedCheck;
					byte[] inputBuffer9 = this._codec.InputBuffer;
					global::Ionic.Zlib.ZlibCodec codec9 = this._codec;
					nextIn = codec9.NextIn;
					codec9.NextIn = nextIn + 1;
					this.expectedCheck = num8 + (inputBuffer9[nextIn] & 255U);
					if (this.computedCheck != this.expectedCheck)
					{
						this.mode = global::Ionic.Zlib.InflateManager.InflateManagerMode.BAD;
						this._codec.Message = "incorrect data check";
						this.marker = 5;
						continue;
					}
					goto IL_6AE;
				}
				case global::Ionic.Zlib.InflateManager.InflateManagerMode.DONE:
					return 1;
				case global::Ionic.Zlib.InflateManager.InflateManagerMode.BAD:
					goto IL_6BA;
				}
				break;
			}
			throw new global::Ionic.Zlib.ZlibException("Stream error.");
			IL_383:
			if (this._codec.AvailableBytesIn == 0)
			{
				return num2;
			}
			this._codec.AvailableBytesIn--;
			this._codec.TotalBytesIn += 1L;
			uint num9 = this.expectedCheck;
			byte[] inputBuffer10 = this._codec.InputBuffer;
			global::Ionic.Zlib.ZlibCodec codec10 = this._codec;
			nextIn = codec10.NextIn;
			codec10.NextIn = nextIn + 1;
			this.expectedCheck = num9 + (inputBuffer10[nextIn] & 255U);
			this._codec._Adler32 = this.expectedCheck;
			this.mode = global::Ionic.Zlib.InflateManager.InflateManagerMode.DICT0;
			return 2;
			IL_40D:
			this.mode = global::Ionic.Zlib.InflateManager.InflateManagerMode.BAD;
			this._codec.Message = "need dictionary";
			this.marker = 0;
			return -2;
			Block_16:
			this.mode = global::Ionic.Zlib.InflateManager.InflateManagerMode.DONE;
			return 1;
			IL_6AE:
			this.mode = global::Ionic.Zlib.InflateManager.InflateManagerMode.DONE;
			return 1;
			IL_6BA:
			throw new global::Ionic.Zlib.ZlibException(string.Format("Bad state ({0})", this._codec.Message));
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000094D4 File Offset: 0x000076D4
		internal int SetDictionary(byte[] dictionary, bool unconditional = false)
		{
			int start = 0;
			int num = dictionary.Length;
			if (!unconditional)
			{
				if (this.mode != global::Ionic.Zlib.InflateManager.InflateManagerMode.DICT0)
				{
					throw new global::Ionic.Zlib.ZlibException("Stream error.");
				}
				if (global::Ionic.Zlib.Adler.Adler32(1U, dictionary, 0, dictionary.Length) != this._codec._Adler32)
				{
					return -3;
				}
			}
			this._codec._Adler32 = global::Ionic.Zlib.Adler.Adler32(0U, null, 0, 0);
			if (num >= 1 << this.wbits)
			{
				num = (1 << this.wbits) - 1;
				start = dictionary.Length - num;
			}
			this.blocks.SetDictionary(dictionary, start, num);
			this.mode = global::Ionic.Zlib.InflateManager.InflateManagerMode.BLOCKS;
			return 0;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00009568 File Offset: 0x00007768
		internal int Sync()
		{
			if (this.mode != global::Ionic.Zlib.InflateManager.InflateManagerMode.BAD)
			{
				this.mode = global::Ionic.Zlib.InflateManager.InflateManagerMode.BAD;
				this.marker = 0;
			}
			int num;
			if ((num = this._codec.AvailableBytesIn) == 0)
			{
				return -5;
			}
			int num2 = this._codec.NextIn;
			int num3 = this.marker;
			while (num != 0 && num3 < 4)
			{
				if (this._codec.InputBuffer[num2] == global::Ionic.Zlib.InflateManager.mark[num3])
				{
					num3++;
				}
				else if (this._codec.InputBuffer[num2] != 0)
				{
					num3 = 0;
				}
				else
				{
					num3 = 4 - num3;
				}
				num2++;
				num--;
			}
			this._codec.TotalBytesIn += (long)(num2 - this._codec.NextIn);
			this._codec.NextIn = num2;
			this._codec.AvailableBytesIn = num;
			this.marker = num3;
			if (num3 != 4)
			{
				return -3;
			}
			long totalBytesIn = this._codec.TotalBytesIn;
			long totalBytesOut = this._codec.TotalBytesOut;
			this.Reset();
			this._codec.TotalBytesIn = totalBytesIn;
			this._codec.TotalBytesOut = totalBytesOut;
			this.mode = global::Ionic.Zlib.InflateManager.InflateManagerMode.BLOCKS;
			return 0;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000967E File Offset: 0x0000787E
		internal int SyncPoint(global::Ionic.Zlib.ZlibCodec z)
		{
			return this.blocks.SyncPoint();
		}

		// Token: 0x040000B3 RID: 179
		private const int PRESET_DICT = 32;

		// Token: 0x040000B4 RID: 180
		private const int Z_DEFLATED = 8;

		// Token: 0x040000B5 RID: 181
		private global::Ionic.Zlib.InflateManager.InflateManagerMode mode;

		// Token: 0x040000B6 RID: 182
		internal global::Ionic.Zlib.ZlibCodec _codec;

		// Token: 0x040000B7 RID: 183
		internal int method;

		// Token: 0x040000B8 RID: 184
		internal uint computedCheck;

		// Token: 0x040000B9 RID: 185
		internal uint expectedCheck;

		// Token: 0x040000BA RID: 186
		internal int marker;

		// Token: 0x040000BB RID: 187
		private bool _handleRfc1950HeaderBytes = true;

		// Token: 0x040000BC RID: 188
		internal int wbits;

		// Token: 0x040000BD RID: 189
		internal global::Ionic.Zlib.InflateBlocks blocks;

		// Token: 0x040000BE RID: 190
		private static readonly byte[] mark = new byte[]
		{
			0,
			0,
			byte.MaxValue,
			byte.MaxValue
		};

		// Token: 0x02000070 RID: 112
		private enum InflateManagerMode
		{
			// Token: 0x040003E9 RID: 1001
			METHOD,
			// Token: 0x040003EA RID: 1002
			FLAG,
			// Token: 0x040003EB RID: 1003
			DICT4,
			// Token: 0x040003EC RID: 1004
			DICT3,
			// Token: 0x040003ED RID: 1005
			DICT2,
			// Token: 0x040003EE RID: 1006
			DICT1,
			// Token: 0x040003EF RID: 1007
			DICT0,
			// Token: 0x040003F0 RID: 1008
			BLOCKS,
			// Token: 0x040003F1 RID: 1009
			CHECK4,
			// Token: 0x040003F2 RID: 1010
			CHECK3,
			// Token: 0x040003F3 RID: 1011
			CHECK2,
			// Token: 0x040003F4 RID: 1012
			CHECK1,
			// Token: 0x040003F5 RID: 1013
			DONE,
			// Token: 0x040003F6 RID: 1014
			BAD
		}
	}
}
