using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000003 RID: 3
	public abstract class BaseMessage : global::Motorola.Common.Communication.IMessage
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000021CC File Offset: 0x000003CC
		protected byte[] _myCommandBuffer
		{
			get
			{
				short num = (short)1555955712;
				short num2 = num;
				num = (short)1398952483;
				short num3 = num;
				num = (short)106779171;
				switch (num3 == num)
				{
				}
				num = (short)25821184;
				if (num != 0)
				{
				}
				num = (short)78249985;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1222377472;
				short num2 = num;
				num = (short)1547273066;
				short num3 = num;
				num = (short)368608106;
				switch (num3 == num)
				{
				}
				num = (short)1449984000;
				if (num != 0)
				{
				}
				num = (short)1129185281;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000227C File Offset: 0x0000047C
		// (set) Token: 0x06000007 RID: 7 RVA: 0x0000232C File Offset: 0x0000052C
		protected byte[] _myReplyBuffer
		{
			get
			{
				short num = (short)406650880;
				short num2 = num;
				num = (short)1985150977;
				if (num != 0)
				{
				}
				num = (short)646011736;
				short num3 = num;
				num = (short)1073109848;
				switch (num3 == num)
				{
				}
				num = (short)1892483072;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)421724160;
				short num2 = num;
				num = (short)1529123676;
				short num3 = num;
				num = (short)1946391388;
				switch (num3 == num)
				{
				}
				num = (short)1557266433;
				if (num != 0)
				{
				}
				num = (short)1282015232;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000023DC File Offset: 0x000005DC
		// (set) Token: 0x06000009 RID: 9 RVA: 0x0000248C File Offset: 0x0000068C
		protected byte[] _myWriteDataBuffer
		{
			get
			{
				short num = (short)114950144;
				short num2 = num;
				num = (short)1473653595;
				short num3 = num;
				num = (short)1213803355;
				switch (num3 == num)
				{
				}
				num = (short)1005912065;
				if (num != 0)
				{
				}
				num = (short)2135293952;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)270729216;
				short num2 = num;
				num = (short)17025055;
				short num3 = num;
				num = (short)1549977631;
				switch (num3 == num)
				{
				}
				num = (short)1008795648;
				if (num != 0)
				{
				}
				num = (short)1789722625;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000253C File Offset: 0x0000073C
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000025EC File Offset: 0x000007EC
		public bool hasReply
		{
			get
			{
				short num = (short)1261830144;
				short num2 = num;
				num = (short)853038401;
				short num3 = num;
				num = (short)1323455809;
				switch (num3 == num)
				{
				}
				num = (short)1685782529;
				if (num != 0)
				{
				}
				num = (short)268042240;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1766326272;
				short num2 = num;
				num = (short)1024890737;
				short num3 = num;
				num = (short)513841009;
				switch (num3 == num)
				{
				}
				num = (short)1358364673;
				if (num != 0)
				{
				}
				num = (short)1864630272;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000026A0 File Offset: 0x000008A0
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002750 File Offset: 0x00000950
		public int ReadTimeout
		{
			get
			{
				short num = (short)809238528;
				short num2 = num;
				num = (short)1311571969;
				if (num != 0)
				{
				}
				num = (short)141443312;
				short num3 = num;
				num = (short)1176453360;
				switch (num3 == num)
				{
				}
				num = (short)2013724672;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1320353792;
				short num2 = num;
				num = (short)1363256919;
				short num3 = num;
				num = (short)579249751;
				switch (num3 == num)
				{
				}
				num = (short)2086469632;
				if (num != 0)
				{
				}
				num = (short)355074049;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0600000E RID: 14
		public abstract int BuildCommandMessage(byte[] sendBuffer);

		// Token: 0x0600000F RID: 15
		public abstract void DecodeReplyMessage(byte[] replyBuffer, int offset, int length);

		// Token: 0x04000003 RID: 3
		private int a;

		// Token: 0x04000004 RID: 4
		private byte[] b;

		// Token: 0x04000005 RID: 5
		private byte[] c;

		// Token: 0x04000006 RID: 6
		private byte[] d;

		// Token: 0x04000007 RID: 7
		private bool e = true;
	}
}
