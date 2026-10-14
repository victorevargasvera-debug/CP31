using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x0200003B RID: 59
	internal sealed class e : global::System.IO.Stream
	{
		// Token: 0x0600014B RID: 331 RVA: 0x000130F4 File Offset: 0x000112F4
		public e(global::System.Net.Sockets.NetworkStream A_0, bool A_1 = false)
		{
			this.a = A_0;
			this.b = this.g();
			this.e = A_1;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0001312C File Offset: 0x0001132C
		private global::System.IO.MemoryStream g()
		{
			short num = (short)618987520;
			short num2 = num;
			num = (short)1019163981;
			short num3 = num;
			num = (short)2069116237;
			switch (num3 == num)
			{
			}
			num = (short)187039745;
			if (num != 0)
			{
			}
			num = (short)556924928;
			if (num != 0)
			{
			}
			return new global::System.IO.MemoryStream(4096);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000131E0 File Offset: 0x000113E0
		public override void Flush()
		{
			short num = (short)674627584;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)294322177;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 1:
					this.f();
					num = (short)1826488322;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1499520319;
					short num3 = num;
					num = (short)2088754495;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_CA;
					}
					break;
				}
				}
				IL_58:
				if (!this.c)
				{
					return;
				}
				num = (short)949223425;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CA:
			num = (short)1647640576;
			if (num != 0)
			{
			}
			num = (short)439091200;
			short num4 = num;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000132F8 File Offset: 0x000114F8
		private void f()
		{
			short num = (short)1062993920;
			short num2 = num;
			num = (short)2005764364;
			short num3 = num;
			num = (short)2078640396;
			switch (num3 == num)
			{
			}
			num = (short)21692417;
			if (num != 0)
			{
			}
			num = (short)398327808;
			if (num != 0)
			{
			}
			this.b.WriteTo(this.a);
			this.b.Close();
			this.b = this.g();
			this.a.Flush();
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000133D0 File Offset: 0x000115D0
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			short num = (short)582528308;
			short num2 = num;
			num = (short)948350260;
			switch (num2 == num)
			{
			}
			num = (short)532545537;
			if (num != 0)
			{
			}
			num = (short)1268252672;
			short num3 = num;
			num = (short)1130758144;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0001347C File Offset: 0x0001167C
		public override void SetLength(long value)
		{
			short num = (short)1834289795;
			short num2 = num;
			num = (short)280824451;
			switch (num2 == num)
			{
			}
			num = (short)982188032;
			if (num != 0)
			{
			}
			num = (short)1455095808;
			short num3 = num;
			num = (short)704380929;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00013528 File Offset: 0x00011728
		public override int Read(byte[] buffer, int offset, int count)
		{
			short num = (short)1905113326;
			short num2 = num;
			num = (short)953923822;
			switch (num2 == num)
			{
			}
			num = (short)1564213248;
			if (num != 0)
			{
			}
			num = (short)2085683200;
			short num3 = num;
			num = (short)121962497;
			if (num != 0)
			{
			}
			return this.a.Read(buffer, offset, count);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000135E0 File Offset: 0x000117E0
		public override void Write(byte[] buffer, int offset, int count)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_247;
				case 1:
					if (buffer[0] == 22)
					{
						num2 = (short)1738932234;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A3;
				case 2:
					if (buffer[0] != 20)
					{
						num2 = (short)1438515208;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					if (buffer[5] == 14)
					{
						num2 = (short)116981765;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					goto IL_CD;
				case 5:
					goto IL_142;
				case 6:
					if (this.d)
					{
						num2 = (short)2089811969;
						if (num2 != 0)
						{
						}
						num2 = (short)1525022720;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1628438531;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_19D;
				case 8:
					this.c = true;
					num2 = (short)2046754823;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (this.c)
					{
						num2 = (short)1501560836;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1511391233;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)1839333382;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_3C;
			}
			IL_CD:
			num2 = (short)1011744768;
			short num3 = num2;
			return;
			IL_142:
			this.d = true;
			this.f();
			return;
			IL_19D:
			return;
			IL_247:
			this.c = true;
			return;
			IL_3C:
			num2 = (short)1648811239;
			short num4 = num2;
			num2 = (short)928373991;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1A3:
				num2 = (short)2103377922;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1620246528;
				if (num2 != 0)
				{
				}
				this.b.Write(buffer, offset, count);
				num2 = (short)338886665;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00013838 File Offset: 0x00011A38
		public override bool get_CanRead()
		{
			short num = (short)5368946;
			short num2 = num;
			num = (short)1268051058;
			switch (num2 == num)
			{
			}
			num = (short)2019164160;
			if (num != 0)
			{
			}
			num = (short)187957248;
			short num3 = num;
			num = (short)1885208577;
			if (num != 0)
			{
			}
			return this.a.CanRead;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000138EC File Offset: 0x00011AEC
		public override bool get_CanSeek()
		{
			short num = (short)876057070;
			short num2 = num;
			num = (short)1470140910;
			switch (num2 == num)
			{
			}
			num = (short)749207553;
			if (num != 0)
			{
			}
			num = (short)1954742272;
			short num3 = num;
			num = (short)1815937024;
			if (num != 0)
			{
			}
			return this.a.CanSeek;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000139A0 File Offset: 0x00011BA0
		public override bool get_CanWrite()
		{
			short num = (short)1313700844;
			short num2 = num;
			num = (short)1455389676;
			switch (num2 == num)
			{
			}
			num = (short)1842085889;
			if (num != 0)
			{
			}
			num = (short)634912768;
			short num3 = num;
			num = (short)1910636544;
			if (num != 0)
			{
			}
			return this.a.CanWrite;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00013A54 File Offset: 0x00011C54
		public override long get_Length()
		{
			short num = (short)1656444546;
			short num2 = num;
			num = (short)2007979650;
			switch (num2 == num)
			{
			}
			num = (short)1826684929;
			if (num != 0)
			{
			}
			num = (short)726007808;
			short num3 = num;
			num = (short)1842937856;
			if (num != 0)
			{
			}
			return this.a.Length;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00013B08 File Offset: 0x00011D08
		public override long get_Position()
		{
			short num = (short)170939404;
			short num2 = num;
			num = (short)478041100;
			switch (num2 == num)
			{
			}
			num = (short)644808705;
			if (num != 0)
			{
			}
			num = (short)1434451968;
			short num3 = num;
			num = (short)11337728;
			if (num != 0)
			{
			}
			return this.a.Position;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00013BBC File Offset: 0x00011DBC
		public override void set_Position(long value)
		{
			short num = (short)436293203;
			short num2 = num;
			num = (short)280776275;
			switch (num2 == num)
			{
			}
			num = (short)131989504;
			if (num != 0)
			{
			}
			num = (short)2140078080;
			short num3 = num;
			num = (short)1038024705;
			if (num != 0)
			{
			}
			this.a.Position = value;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00013C70 File Offset: 0x00011E70
		public override void Close()
		{
			object obj = this.g;
			bool flag = false;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				int num;
				for (;;)
				{
					IL_48:
					switch (num)
					{
					case 0:
						try
						{
							this.f();
							goto IL_0B;
						}
						catch (global::System.Exception)
						{
							goto IL_0B;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_CE;
							}
							for (;;)
							{
								IL_BC:
								switch (num)
								{
								case 0:
									goto IL_13B;
								case 1:
									if (!this.e)
									{
										num2 = (short)32112642;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									goto IL_13D;
								case 2:
									this.a.Close();
									num2 = (short)1121058816;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_CE;
							}
							IL_13B:
							IL_13D:
							goto EndFinally_10;
							IL_CE:
							this.f = true;
							this.b.Close();
							this.b = null;
							num2 = (short)1757216769;
							num = (int)((global::System.IntPtr)num2);
							goto IL_BC;
							EndFinally_10:;
						}
						goto IL_13E;
					case 1:
						goto IL_13E;
					case 2:
						if (this.f)
						{
							num2 = (short)942211073;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1572405248;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_155;
					}
					goto IL_5E;
					IL_13E:
					num2 = (short)1446379523;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_155:
				goto IL_22F;
				IL_5E:
				global::System.Threading.Monitor.Enter(obj, ref flag);
				num2 = (short)1163591682;
				num = (int)((global::System.IntPtr)num2);
				goto IL_48;
			}
			finally
			{
				num2 = (short)758448129;
				int num = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					IL_195:
					switch (num)
					{
					case 0:
						goto IL_22C;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_1A7;
						}
						continue;
					case 2:
						global::System.Threading.Monitor.Exit(obj);
						num2 = (short)135725056;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					IL_1A7:
					while (flag)
					{
						num2 = (short)664134685;
						short num3 = num2;
						num2 = (short)1055319069;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1607663616;
							if (num2 != 0)
							{
							}
							num2 = (short)1589968898;
							num = (int)((global::System.IntPtr)num2);
							goto IL_195;
						}
					}
					break;
				}
				IL_22C:;
			}
			goto IL_22F;
			IL_0B:
			num2 = (short)2100428801;
			if (num2 != 0)
			{
			}
			base.Close();
			IL_22F:
			num2 = (short)601686016;
			short num4 = num2;
		}

		// Token: 0x040000B9 RID: 185
		private readonly global::System.IO.Stream a;

		// Token: 0x040000BA RID: 186
		private global::System.IO.MemoryStream b;

		// Token: 0x040000BB RID: 187
		private bool c;

		// Token: 0x040000BC RID: 188
		private bool d;

		// Token: 0x040000BD RID: 189
		private readonly bool e;

		// Token: 0x040000BE RID: 190
		private bool f;

		// Token: 0x040000BF RID: 191
		private readonly object g = new object();
	}
}
