using System;
using System.IO;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000069 RID: 105
	public class ProxyStream : global::System.IO.Stream
	{
		// Token: 0x060002D6 RID: 726 RVA: 0x00034070 File Offset: 0x00032270
		public ProxyStream(global::System.IO.Stream stream, bool isForwardSeekable = false)
		{
			this.a = stream;
			this.b = isForwardSeekable;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00034094 File Offset: 0x00032294
		public override void Flush()
		{
			short num = (short)2139924555;
			short num2 = num;
			num = (short)1034135627;
			switch (num2 == num)
			{
			}
			num = (short)1845952513;
			if (num != 0)
			{
			}
			num = (short)449183744;
			if (num != 0)
			{
			}
			num = (short)1548812288;
			short num3 = num;
			this.a.Flush();
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00034148 File Offset: 0x00032348
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			short num = (short)1015152643;
			int num2 = (int)((global::System.IntPtr)num);
			long num5;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)232325126;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_1F6;
				case 2:
					goto IL_130;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 4:
					if (offset >= 0L)
					{
						num = (short)1720647688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26C;
				case 5:
					if (this.b)
					{
						num = (short)2095972359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26C;
				case 6:
					if (origin == global::System.IO.SeekOrigin.Current)
					{
						num = (short)383216332;
						short num3 = num;
						num = (short)773024460;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							break;
						default:
						{
							num = (short)1777074176;
							short num4 = num;
							break;
						}
						}
						num = (short)1985413120;
						if (num != 0)
						{
						}
						num = (short)665255938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26C;
				case 7:
					num = (short)705495044;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)1744896011;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_79;
				case 10:
					if (num5 > 0L)
					{
						num = (short)1481441281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26C;
				case 11:
					if (origin != global::System.IO.SeekOrigin.Begin)
					{
						num = (short)73465856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num5 = offset - this.Position;
					num = (short)777715713;
					if (num != 0)
					{
					}
					num = (short)1145962506;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_55:
				if (this.a.CanSeek)
				{
					num = (short)10092553;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)490602501;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_79:
			return this.a.Seek(offset, origin);
			IL_130:
			return this.a(offset, 4096);
			IL_1F6:
			return this.a(num5, 4096);
			IL_26C:
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000343C8 File Offset: 0x000325C8
		public override void SetLength(long value)
		{
			short num = (short)635264563;
			short num2 = num;
			num = (short)2014993971;
			switch (num2 == num)
			{
			}
			num = (short)17301505;
			if (num != 0)
			{
			}
			num = (short)56098816;
			if (num != 0)
			{
			}
			num = (short)1209925632;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00034478 File Offset: 0x00032678
		public override int Read(byte[] buffer, int offset, int count)
		{
			short num = (short)389193353;
			short num2 = num;
			num = (short)1813618313;
			switch (num2 == num)
			{
			}
			num = (short)1001390081;
			if (num != 0)
			{
			}
			num = (short)1968308224;
			if (num != 0)
			{
			}
			num = (short)1955659776;
			short num3 = num;
			int result = this.a.Read(buffer, offset, count);
			if (!this.a.CanSeek)
			{
				this.c += count;
			}
			return result;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00034550 File Offset: 0x00032750
		public override void Write(byte[] buffer, int offset, int count)
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
					num2 = (short)1948319745;
					if (num2 != 0)
					{
					}
					num2 = (short)687341568;
					short num3 = num2;
					num2 = (short)796155937;
					short num4 = num2;
					num2 = (short)826695713;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_102;
					default:
						num2 = (short)2010382336;
						if (num2 != 0)
						{
						}
						if (!this.a.CanSeek)
						{
							num2 = (short)669188097;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 1:
					goto IL_102;
				case 2:
					return;
				}
				goto IL_1C;
				IL_102:
				this.c += count;
				num2 = (short)668663810;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			this.a.Write(buffer, offset, count);
			num2 = (short)1822883840;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00034688 File Offset: 0x00032888
		public override bool CanRead
		{
			get
			{
				short num = (short)255185025;
				short num2 = num;
				num = (short)1703137409;
				switch (num2 == num)
				{
				}
				num = (short)286326784;
				if (num != 0)
				{
				}
				num = (short)1685127169;
				if (num != 0)
				{
				}
				num = (short)1075707904;
				short num3 = num;
				return this.a.CanRead;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0003473C File Offset: 0x0003293C
		public override bool CanSeek
		{
			get
			{
				if (this.a.CanSeek)
				{
					short num = (short)1291979248;
					short num2 = num;
					num = (short)3934704;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)491323393;
						if (num != 0)
						{
						}
						num = (short)2095579136;
						if (num != 0)
						{
						}
						num = (short)1595604992;
						short num3 = num;
						return true;
					}
					}
				}
				return this.b;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002DE RID: 734 RVA: 0x000347FC File Offset: 0x000329FC
		public override bool CanWrite
		{
			get
			{
				short num = (short)1285273852;
				short num2 = num;
				num = (short)1466939644;
				switch (num2 == num)
				{
				}
				num = (short)741736449;
				if (num != 0)
				{
				}
				num = (short)1816526848;
				if (num != 0)
				{
				}
				num = (short)1129709568;
				short num3 = num;
				return this.a.CanWrite;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002DF RID: 735 RVA: 0x000348B0 File Offset: 0x00032AB0
		public override long Length
		{
			get
			{
				short num = (short)1574240257;
				if (num != 0)
				{
				}
				num = (short)863845326;
				short num2 = num;
				num = (short)2114141134;
				switch (num2 == num)
				{
				}
				num = (short)1158545408;
				if (num != 0)
				{
				}
				num = (short)434831360;
				short num3 = num;
				return this.a.Length;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00034964 File Offset: 0x00032B64
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x00034A2C File Offset: 0x00032C2C
		public override long Position
		{
			get
			{
				if (this.a.CanSeek)
				{
					short num = (short)991314062;
					short num2 = num;
					num = (short)16203918;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1860763648;
						if (num != 0)
						{
						}
						num = (short)1570963457;
						if (num != 0)
						{
						}
						num = (short)1341784064;
						short num3 = num;
						return this.a.Position;
					}
					}
				}
				return (long)this.c;
			}
			set
			{
				short num = (short)1629157363;
				short num2 = num;
				num = (short)1778448371;
				switch (num2 == num)
				{
				}
				num = (short)1878654977;
				if (num != 0)
				{
				}
				num = (short)1413677056;
				if (num != 0)
				{
				}
				num = (short)641466368;
				short num3 = num;
				this.Seek(value, global::System.IO.SeekOrigin.Begin);
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00034ADC File Offset: 0x00032CDC
		private long a(long A_0, int A_1 = 4096)
		{
			short num = (short)710541312;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				long num5;
				byte[] array;
				for (;;)
				{
					IL_27:
					int num4;
					switch (num2)
					{
					case 0:
						goto IL_66;
					case 1:
					{
						num = (short)959058552;
						short num3 = num;
						num = (short)1294668408;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_66;
						default:
							num = (short)771883008;
							if (num != 0)
							{
							}
							if (num4 != 0)
							{
								num = (short)1940717568;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_192;
						}
						break;
					}
					case 2:
						if (num5 >= A_0)
						{
							num = (short)1559035904;
							short num6 = num;
							num = (short)1533870084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F5;
					case 3:
						goto IL_F5;
					case 4:
						goto IL_F0;
					}
					goto IL_42;
					IL_66:
					num5 += (long)num4;
					num = (short)169541633;
					if (num != 0)
					{
					}
					num = (short)170852354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F5:
					long num7 = global::System.Math.Min(A_0 - num5, (long)array.Length);
					num4 = this.Read(array, 0, (int)num7);
					num = (short)335544321;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F0:
				IL_192:
				return (long)this.c;
				IL_42:
				num5 = 0L;
				array = new byte[A_1];
				num = (short)1344405507;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00034C84 File Offset: 0x00032E84
		protected override void Dispose(bool disposing)
		{
			short num = (short)1526923265;
			if (num != 0)
			{
			}
			num = (short)133205382;
			short num2 = num;
			num = (short)1154125190;
			switch (num2 == num)
			{
			}
			num = (short)760414208;
			if (num != 0)
			{
			}
			num = (short)1762918400;
			short num3 = num;
			this.a.Dispose();
			base.Dispose(disposing);
		}

		// Token: 0x040002DA RID: 730
		private readonly global::System.IO.Stream a;

		// Token: 0x040002DB RID: 731
		private readonly bool b;

		// Token: 0x040002DC RID: 732
		private int c;
	}
}
