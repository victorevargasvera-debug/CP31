using System;
using System.Runtime.CompilerServices;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000F RID: 15
	public class MultiPipeMessageWrapper : global::Motorola.Common.Communication.BaseMessage
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00004524 File Offset: 0x00002724
		// (set) Token: 0x0600002C RID: 44 RVA: 0x000045D4 File Offset: 0x000027D4
		public int ExecutorID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)526831100;
				short num2 = num;
				num = (short)664129020;
				switch (num2 == num)
				{
				}
				num = (short)775421953;
				if (num != 0)
				{
				}
				num = (short)1452802048;
				short num3 = num;
				num = (short)669646848;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1741259865;
				short num2 = num;
				num = (short)1646756953;
				switch (num2 == num)
				{
				}
				num = (short)861077504;
				if (num != 0)
				{
				}
				num = (short)1825243136;
				short num3 = num;
				num = (short)1576337409;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00004688 File Offset: 0x00002888
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00004738 File Offset: 0x00002938
		public global::Motorola.Common.Communication.IMessage Message
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)368943154;
				short num2 = num;
				num = (short)423075890;
				switch (num2 == num)
				{
				}
				num = (short)1495531520;
				if (num != 0)
				{
				}
				num = (short)508231680;
				short num3 = num;
				num = (short)2137915393;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)948801105;
				short num2 = num;
				num = (short)400002641;
				switch (num2 == num)
				{
				}
				num = (short)317849601;
				if (num != 0)
				{
				}
				num = (short)551813120;
				short num3 = num;
				num = (short)1313210368;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000047E8 File Offset: 0x000029E8
		public MultiPipeMessageWrapper(int executorID, global::Motorola.Common.Communication.IMessage wrappedMessage)
		{
			this.ExecutorID = executorID;
			this.Message = wrappedMessage;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000480C File Offset: 0x00002A0C
		public override int BuildCommandMessage(byte[] sendBuffer)
		{
			short num = (short)549707706;
			short num2 = num;
			num = (short)14344122;
			switch (num2 == num)
			{
			}
			num = (short)1854603265;
			if (num != 0)
			{
			}
			num = (short)284950528;
			short num3 = num;
			num = (short)1450115072;
			if (num != 0)
			{
			}
			return this.Message.BuildCommandMessage(sendBuffer);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000048C4 File Offset: 0x00002AC4
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)1864957953;
			if (num != 0)
			{
			}
			num = (short)2005993;
			short num2 = num;
			num = (short)733584361;
			switch (num2 == num)
			{
			}
			num = (short)1122369536;
			short num3 = num;
			num = (short)1479671808;
			if (num != 0)
			{
			}
			this.Message.DecodeReplyMessage(replyBuffer, offset, length);
		}

		// Token: 0x04000034 RID: 52
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int a;

		// Token: 0x04000035 RID: 53
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.IMessage b;
	}
}
