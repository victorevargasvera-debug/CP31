using System;
using System.IO;

namespace PreEmptive.SoS.Runtime
{
	// Token: 0x0200009B RID: 155
	public sealed class FixedLengthStream : global::System.IO.Stream, global::System.IDisposable
	{
		// Token: 0x0600060A RID: 1546 RVA: 0x000FDA08 File Offset: 0x000FBC08
		private FixedLengthStream()
		{
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x000FDA1C File Offset: 0x000FBC1C
		public FixedLengthStream(global::System.IO.Stream stream, long totalSize)
		{
			this.stream = stream;
			this.totalSize = totalSize;
			this.currentPos = 0L;
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x000FDA48 File Offset: 0x000FBC48
		public override bool CanRead
		{
			get
			{
				short num = (short)2041852472;
				short num2 = num;
				num = (short)724906552;
				switch (num2 == num)
				{
				}
				num = (short)691601408;
				short num3 = num;
				num = (short)1880555521;
				if (num != 0)
				{
				}
				num = (short)758317056;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x000FDAF4 File Offset: 0x000FBCF4
		public override bool CanSeek
		{
			get
			{
				short num = (short)1278830706;
				short num2 = num;
				num = (short)1504077938;
				switch (num2 == num)
				{
				}
				num = (short)487981056;
				short num3 = num;
				num = (short)64749569;
				if (num != 0)
				{
				}
				num = (short)642646016;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x000FDBA0 File Offset: 0x000FBDA0
		public override bool CanWrite
		{
			get
			{
				short num = (short)139278773;
				short num2 = num;
				num = (short)725629365;
				switch (num2 == num)
				{
				}
				num = (short)406192128;
				short num3 = num;
				num = (short)948764673;
				if (num != 0)
				{
				}
				num = (short)1316618240;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x000FDC48 File Offset: 0x000FBE48
		public override long Length
		{
			get
			{
				short num = (short)1599752149;
				short num2 = num;
				num = (short)1939818453;
				switch (num2 == num)
				{
				}
				num = (short)1331888128;
				short num3 = num;
				num = (short)606601217;
				if (num != 0)
				{
				}
				num = (short)127008768;
				if (num != 0)
				{
				}
				return this.totalSize;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x000FDCFC File Offset: 0x000FBEFC
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x000FDDC4 File Offset: 0x000FBFC4
		public override long Position
		{
			get
			{
				short num;
				while (this.stream != null)
				{
					num = (short)896509655;
					short num2 = num;
					num = (short)1742317271;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)829947904;
						if (num != 0)
						{
						}
						num = (short)1239220224;
						short num3 = num;
						return this.currentPos;
					}
					}
				}
				num = (short)1002569729;
				if (num != 0)
				{
				}
				throw new global::System.ObjectDisposedException("stream", "Stream is closed");
			}
			set
			{
				short num = (short)2044636793;
				short num2 = num;
				num = (short)659926649;
				switch (num2 == num)
				{
				}
				num = (short)802029568;
				short num3 = num;
				num = (short)674627585;
				if (num != 0)
				{
				}
				num = (short)962265088;
				if (num != 0)
				{
				}
				throw new global::System.NotSupportedException("Seek not supported");
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000FDE78 File Offset: 0x000FC078
		public override void Flush()
		{
			short num = (short)867234846;
			short num2 = num;
			num = (short)1725953054;
			switch (num2 == num)
			{
			}
			num = (short)1877671936;
			short num3 = num;
			num = (short)111869953;
			if (num != 0)
			{
			}
			num = (short)1562247168;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x000FDF24 File Offset: 0x000FC124
		public override int Read(byte[] buffer, int offset, int count)
		{
			short num = (short)57540610;
			int num2 = (int)((global::System.IntPtr)num);
			int num3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_113;
				case 1:
				{
					num = (short)22609921;
					if (num != 0)
					{
					}
					long num4;
					num3 = (int)num4;
					num = (short)620041015;
					short num5 = num;
					num = (short)1910575927;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16D;
					default:
					{
						num = (short)1246887936;
						if (num != 0)
						{
						}
						num = (short)773586944;
						short num6 = num;
						num = (short)26214400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 3:
				{
					long num4;
					if (num4 < (long)num3)
					{
						num = (short)1821573121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16D;
				}
				case 4:
					goto IL_59;
				}
				IL_38:
				if (this.stream == null)
				{
					num = (short)1507131396;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num3 = count;
					long num4 = this.totalSize - this.currentPos;
					num = (short)1000669187;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_59:
			throw new global::System.ObjectDisposedException("stream", "Stream is closed");
			IL_113:
			IL_16D:
			int num7 = this.stream.Read(buffer, offset, num3);
			this.currentPos += (long)num7;
			return num7;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x000FE0C0 File Offset: 0x000FC2C0
		public override int ReadByte()
		{
			short num = (short)206831617;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_125;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					if (this.currentPos < this.totalSize)
					{
						num = (short)85065728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return -1;
				case 3:
					goto IL_53;
				}
				IL_34:
				if (this.stream == null)
				{
					num = (short)173080579;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)810549250;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_53:
			throw new global::System.ObjectDisposedException("stream", "Stream is closed");
			IL_125:
			num = (short)1907294209;
			if (num != 0)
			{
			}
			num = (short)142714062;
			short num3 = num;
			num = (short)601531598;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_53;
			default:
			{
				num = (short)2005270528;
				short num4 = num;
				num = (short)61210624;
				if (num != 0)
				{
				}
				this.currentPos += 1L;
				return this.stream.ReadByte();
			}
			}
			return -1;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x000FE230 File Offset: 0x000FC430
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			short num = (short)1455297372;
			short num2 = num;
			num = (short)1746998108;
			switch (num2 == num)
			{
			}
			num = (short)1707868160;
			short num3 = num;
			num = (short)994836481;
			if (num != 0)
			{
			}
			num = (short)327090176;
			if (num != 0)
			{
			}
			throw new global::System.NotSupportedException("Seek not supported");
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x000FE2E4 File Offset: 0x000FC4E4
		public override void SetLength(long len)
		{
			short num = (short)446817205;
			short num2 = num;
			num = (short)1909973941;
			switch (num2 == num)
			{
			}
			num = (short)187105280;
			short num3 = num;
			num = (short)1246167040;
			if (num != 0)
			{
			}
			num = (short)2018246657;
			if (num != 0)
			{
			}
			throw new global::System.NotSupportedException("Seek not supported");
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000FE398 File Offset: 0x000FC598
		public override void Write(byte[] array, int offset, int count)
		{
			short num = (short)398465872;
			short num2 = num;
			num = (short)1925585744;
			switch (num2 == num)
			{
			}
			num = (short)698220544;
			short num3 = num;
			num = (short)505544705;
			if (num != 0)
			{
			}
			num = (short)867237888;
			if (num != 0)
			{
			}
			throw new global::System.NotSupportedException("Writing not supported");
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x000FE450 File Offset: 0x000FC650
		public override void Close()
		{
			short num;
			try
			{
				num = (short)1795031041;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1389013721;
						short num3 = num;
						num = (short)1070246617;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
							goto IL_C2;
						}
						break;
					}
					case 1:
						goto IL_14;
					case 2:
						goto IL_75;
					case 3:
						this.stream.Close();
						num = (short)852492290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_34;
					IL_14:
					switch (0)
					{
					case 0:
						IL_34:
						if (this.stream == null)
						{
							goto IL_75;
						}
						num = (short)541720579;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					continue;
					IL_75:
					num = (short)1438384128;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C2:
				num = (short)66125824;
				if (num != 0)
				{
				}
			}
			finally
			{
				this.stream = null;
				base.Close();
			}
			num = (short)63111169;
			if (num != 0)
			{
			}
			num = (short)1809252352;
			short num4 = num;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x000FE5A4 File Offset: 0x000FC7A4
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(214330918 + A_1) + (global::System.IntPtr)64 + (global::System.IntPtr)50 + (global::System.IntPtr)71);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_5C;
			}
			IL_29:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_5C:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_29;
		}

		// Token: 0x040003B1 RID: 945
		private global::System.IO.Stream stream;

		// Token: 0x040003B2 RID: 946
		private long totalSize;

		// Token: 0x040003B3 RID: 947
		private long currentPos;

		// Token: 0x040003B4 RID: 948
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
