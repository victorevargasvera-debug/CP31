using System;
using System.IO;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x0200000A RID: 10
	internal class CommunicationPipeAdapter : global::System.IO.Stream
	{
		// Token: 0x06000026 RID: 38 RVA: 0x000039E0 File Offset: 0x00001BE0
		public CommunicationPipeAdapter(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe pipe)
		{
			this.a = pipe;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000039FC File Offset: 0x00001BFC
		public override int Read(byte[] buffer, int offset, int count)
		{
			short num = (short)754188294;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1776549892;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1044709379;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_12E;
				case 3:
					if (this.b.Length != 0)
					{
						num = (short)432340992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8E;
				case 4:
					IL_14C:
					if (this.c >= this.b.Length)
					{
						num = (short)1830813703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E7;
				case 5:
					if (this.b == null)
					{
						num = (short)1646460930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E7;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 7:
					goto IL_8E;
				}
				IL_46:
				num = (short)1355218945;
				if (num != 0)
				{
				}
				if (this.b != null)
				{
					num = (short)1686044673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_8E:
				this.b = this.a.ReceiveData();
				this.c = 0;
				num = (short)1937843337;
				short num3 = num;
				num = (short)1507140745;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_14C;
				default:
					num = (short)1738539008;
					if (num != 0)
					{
					}
					num = (short)545259525;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_12E:
			num = (short)1599733760;
			short num4 = num;
			return 0;
			IL_1E7:
			int num5 = global::System.Math.Min(this.b.Length, count);
			global::System.Buffer.BlockCopy(this.b, this.c, buffer, offset, num5);
			this.c += num5;
			return num5;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003C24 File Offset: 0x00001E24
		public override void Write(byte[] buffer, int offset, int count)
		{
			short num = (short)433896084;
			short num2 = num;
			num = (short)1524087444;
			switch (num2 == num)
			{
			}
			num = (short)216727553;
			if (num != 0)
			{
			}
			num = (short)1348337664;
			if (num != 0)
			{
			}
			num = (short)844824576;
			short num3 = num;
			this.a.SendData(buffer, offset, count);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003CD8 File Offset: 0x00001ED8
		public override void Flush()
		{
			short num = (short)1775383234;
			short num2 = num;
			num = (short)796865218;
			switch (num2 == num)
			{
			}
			num = (short)540082176;
			if (num != 0)
			{
			}
			num = (short)1335689217;
			if (num != 0)
			{
			}
			num = (short)1132331008;
			short num3 = num;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003D80 File Offset: 0x00001F80
		public override bool CanRead
		{
			get
			{
				short num;
				if (this.a != null)
				{
					num = (short)92615673;
					short num2 = num;
					num = (short)410334201;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1515192320;
						if (num != 0)
						{
						}
						num = (short)1021968385;
						if (num != 0)
						{
						}
						return this.a.IsOpen;
					}
				}
				num = (short)835518464;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003E44 File Offset: 0x00002044
		public override bool CanSeek
		{
			get
			{
				short num = (short)506589027;
				short num2 = num;
				num = (short)6877027;
				switch (num2 == num)
				{
				}
				num = (short)1437990912;
				if (num != 0)
				{
				}
				num = (short)2071134209;
				if (num != 0)
				{
				}
				num = (short)2023161856;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00003EF0 File Offset: 0x000020F0
		public override bool CanWrite
		{
			get
			{
				short num = (short)1819410433;
				if (num != 0)
				{
				}
				if (this.a != null)
				{
					num = (short)629509600;
					short num2 = num;
					num = (short)1186172384;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1393623040;
						if (num != 0)
						{
						}
						return this.a.IsOpen;
					}
				}
				num = (short)1670119424;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003FB4 File Offset: 0x000021B4
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			short num = (short)1689456234;
			short num2 = num;
			num = (short)1426591338;
			switch (num2 == num)
			{
			}
			num = (short)11272192;
			if (num != 0)
			{
			}
			num = (short)352518145;
			if (num != 0)
			{
			}
			num = (short)164560896;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004064 File Offset: 0x00002264
		public override void SetLength(long value)
		{
			short num = (short)1794048001;
			if (num != 0)
			{
			}
			num = (short)733235815;
			short num2 = num;
			num = (short)591284839;
			switch (num2 == num)
			{
			}
			num = (short)1299644416;
			if (num != 0)
			{
			}
			num = (short)1143275520;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00004114 File Offset: 0x00002314
		public override long Length
		{
			get
			{
				short num = (short)1263107314;
				short num2 = num;
				num = (short)245267698;
				switch (num2 == num)
				{
				}
				num = (short)77332481;
				if (num != 0)
				{
				}
				num = (short)2032074752;
				if (num != 0)
				{
				}
				num = (short)959512576;
				short num3 = num;
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000041C0 File Offset: 0x000023C0
		// (set) Token: 0x06000031 RID: 49 RVA: 0x0000426C File Offset: 0x0000246C
		public override long Position
		{
			get
			{
				short num = (short)65470465;
				if (num != 0)
				{
				}
				num = (short)171058216;
				short num2 = num;
				num = (short)46015528;
				switch (num2 == num)
				{
				}
				num = (short)594477056;
				if (num != 0)
				{
				}
				num = (short)1094516736;
				short num3 = num;
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)2094413993;
				short num2 = num;
				num = (short)1472936105;
				switch (num2 == num)
				{
				}
				num = (short)1043202049;
				if (num != 0)
				{
				}
				num = (short)1352794112;
				if (num != 0)
				{
				}
				num = (short)2067988480;
				short num3 = num;
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x04000017 RID: 23
		private readonly global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe a;

		// Token: 0x04000018 RID: 24
		private byte[] b;

		// Token: 0x04000019 RID: 25
		private int c;
	}
}
