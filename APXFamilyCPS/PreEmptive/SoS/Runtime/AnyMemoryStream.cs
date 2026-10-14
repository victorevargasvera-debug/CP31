using System;
using System.IO;
using System.Runtime.InteropServices;

namespace PreEmptive.SoS.Runtime
{
	// Token: 0x0200009A RID: 154
	public sealed class AnyMemoryStream : global::System.IO.Stream, global::System.IDisposable
	{
		// Token: 0x060005FB RID: 1531 RVA: 0x000FCF04 File Offset: 0x000FB104
		public AnyMemoryStream(global::System.IntPtr startAt)
		{
			this.arch64 = (global::System.IntPtr.Size == 8);
			this.currentPos = 0L;
			this.currentPtr = startAt;
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x000FCF34 File Offset: 0x000FB134
		public override bool CanRead
		{
			get
			{
				short num = (short)680853504;
				short num2 = num;
				num = (short)220781964;
				short num3 = num;
				num = (short)637001100;
				switch (num3 == num)
				{
				}
				num = (short)1506607104;
				if (num != 0)
				{
				}
				num = (short)2145779713;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x000FCFE0 File Offset: 0x000FB1E0
		public override bool CanSeek
		{
			get
			{
				short num = (short)853540864;
				short num2 = num;
				num = (short)1671938713;
				short num3 = num;
				num = (short)2035139225;
				switch (num3 == num)
				{
				}
				num = (short)228458497;
				if (num != 0)
				{
				}
				num = (short)2111307776;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x000FD08C File Offset: 0x000FB28C
		public override bool CanWrite
		{
			get
			{
				short num = (short)1174142976;
				short num2 = num;
				num = (short)564460056;
				short num3 = num;
				num = (short)1448475160;
				switch (num3 == num)
				{
				}
				num = (short)312147969;
				if (num != 0)
				{
				}
				num = (short)701235200;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x000FD13C File Offset: 0x000FB33C
		public override long Length
		{
			get
			{
				short num = (short)515571712;
				short num2 = num;
				num = (short)429785706;
				short num3 = num;
				num = (short)1923220074;
				switch (num3 == num)
				{
				}
				num = (short)1116209153;
				if (num != 0)
				{
				}
				num = (short)315621376;
				if (num != 0)
				{
				}
				throw new global::System.NotSupportedException("Seek not supported");
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x000FD1F0 File Offset: 0x000FB3F0
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x000FD2BC File Offset: 0x000FB4BC
		public override long Position
		{
			get
			{
				short num = (short)702939136;
				short num2 = num;
				num = (short)659750913;
				if (num != 0)
				{
				}
				num = (short)720684852;
				short num3 = num;
				num = (short)1051117364;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1215561728;
					if (num != 0)
					{
					}
					if (this.closed)
					{
						throw new global::System.ObjectDisposedException("stream", "Stream is closed");
					}
					break;
				}
				return this.currentPos;
			}
			set
			{
				short num = (short)1292566528;
				short num2 = num;
				num = (short)2040164475;
				short num3 = num;
				num = (short)152727675;
				switch (num3 == num)
				{
				}
				num = (short)1210449920;
				if (num != 0)
				{
				}
				num = (short)1222508545;
				if (num != 0)
				{
				}
				throw new global::System.NotSupportedException("Seek not supported");
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x000FD370 File Offset: 0x000FB570
		public override void Flush()
		{
			short num = (short)1224278016;
			short num2 = num;
			num = (short)11914239;
			short num3 = num;
			num = (short)1192872959;
			switch (num3 == num)
			{
			}
			num = (short)1056309248;
			if (num != 0)
			{
			}
			num = (short)245891073;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x000FD41C File Offset: 0x000FB61C
		public override int Read(byte[] buffer, int offset, int count)
		{
			short num = (short)2129264640;
			short num2 = num;
			num = (short)1044216804;
			short num3 = num;
			num = (short)1387625444;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)739180544;
				if (num != 0)
				{
				}
				if (this.closed)
				{
					throw new global::System.ObjectDisposedException("stream", "Stream is closed");
				}
				break;
			}
			num = (short)2118778881;
			if (num != 0)
			{
			}
			global::System.Runtime.InteropServices.Marshal.Copy(this.currentPtr, buffer, offset, count);
			this.Increment(count);
			return count;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x000FD4F4 File Offset: 0x000FB6F4
		public override int ReadByte()
		{
			short num = (short)376045568;
			short num2 = num;
			num = (short)1863243585;
			short num3 = num;
			num = (short)2136069953;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)216465408;
				if (num != 0)
				{
				}
				num = (short)2043281409;
				if (num != 0)
				{
				}
				if (this.closed)
				{
					throw new global::System.ObjectDisposedException("stream", "Stream is closed");
				}
				break;
			}
			byte result = global::System.Runtime.InteropServices.Marshal.ReadByte(this.currentPtr);
			this.Increment(1);
			return (int)result;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x000FD5CC File Offset: 0x000FB7CC
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			short num = (short)1976827904;
			short num2 = num;
			num = (short)498332927;
			short num3 = num;
			num = (short)434042111;
			switch (num3 == num)
			{
			}
			num = (short)2107441152;
			if (num != 0)
			{
			}
			num = (short)426442753;
			if (num != 0)
			{
			}
			throw new global::System.NotSupportedException("Seek not supported");
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x000FD67C File Offset: 0x000FB87C
		public override void SetLength(long len)
		{
			short num = (short)149650466;
			short num2 = num;
			num = (short)708475938;
			switch (num2 == num)
			{
			}
			num = (short)1323171840;
			short num3 = num;
			num = (short)589955072;
			if (num != 0)
			{
			}
			num = (short)47644673;
			if (num != 0)
			{
			}
			throw new global::System.NotSupportedException("Seek not supported");
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x000FD730 File Offset: 0x000FB930
		public override void Write(byte[] array, int offset, int count)
		{
			short num = (short)7707896;
			short num2 = num;
			num = (short)1330027768;
			switch (num2 == num)
			{
			}
			num = (short)2129395712;
			short num3 = num;
			num = (short)582549505;
			if (num != 0)
			{
			}
			num = (short)1145700352;
			if (num != 0)
			{
			}
			throw new global::System.NotSupportedException("Writing not supported");
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000FD7E4 File Offset: 0x000FB9E4
		public override void Close()
		{
			short num = (short)635215800;
			short num2 = num;
			num = (short)1493344184;
			switch (num2 == num)
			{
			}
			num = (short)842137600;
			short num3 = num;
			num = (short)1904607233;
			if (num != 0)
			{
			}
			num = (short)1239023616;
			if (num != 0)
			{
			}
			this.closed = true;
			base.Close();
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x000FD898 File Offset: 0x000FBA98
		private void Increment(int count)
		{
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)358023168;
				short num2 = num;
				switch (num3)
				{
				case 0:
				{
					num = (short)1202015518;
					short num4 = num;
					num = (short)754470174;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_128;
					}
					break;
				}
				case 1:
					if (!this.arch64)
					{
						num = (short)1430650881;
						if (num != 0)
						{
						}
						num = (short)848756739;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1870725122;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_CE;
				case 3:
					num = (short)684457984;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_49;
			}
			IL_CE:
			long num5 = this.currentPtr.ToInt64();
			goto IL_14B;
			IL_128:
			num = (short)736428032;
			if (num != 0)
			{
			}
			num5 = (long)this.currentPtr.ToInt32();
			IL_14B:
			long num6 = num5 + (long)count;
			this.currentPtr = global::System.Runtime.InteropServices.Marshal.ReadIntPtr(num6, 0);
			return;
			IL_49:
			this.currentPos += (long)count;
			num = (short)1438187521;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x040003AC RID: 940
		private long currentPos;

		// Token: 0x040003AD RID: 941
		private bool closed;

		// Token: 0x040003AE RID: 942
		private global::System.IntPtr currentPtr;

		// Token: 0x040003AF RID: 943
		private bool arch64;

		// Token: 0x040003B0 RID: 944
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
