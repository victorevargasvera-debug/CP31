using System;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication
{
	// Token: 0x02000005 RID: 5
	public class CommunicationSession
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002820 File Offset: 0x00000A20
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000028D0 File Offset: 0x00000AD0
		public ushort ID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1232338944;
				short num2 = num;
				num = (short)586350593;
				if (num != 0)
				{
				}
				num = (short)1426397817;
				short num3 = num;
				num = (short)421141113;
				switch (num3 == num)
				{
				}
				num = (short)1822883840;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1872297984;
				short num2 = num;
				num = (short)1220265682;
				short num3 = num;
				num = (short)1162069714;
				switch (num3 == num)
				{
				}
				num = (short)1289682945;
				if (num != 0)
				{
				}
				num = (short)491061248;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000019 RID: 25 RVA: 0x0000297C File Offset: 0x00000B7C
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002A28 File Offset: 0x00000C28
		public global::Motorola.Common.Communication.CommonUtil.RadioOperation OperationType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1836908544;
				short num2 = num;
				num = (short)1086717953;
				if (num != 0)
				{
				}
				num = (short)666113832;
				short num3 = num;
				num = (short)240129832;
				switch (num3 == num)
				{
				}
				num = (short)232652800;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1390804992;
				short num2 = num;
				num = (short)1757114650;
				short num3 = num;
				num = (short)914321690;
				switch (num3 == num)
				{
				}
				num = (short)717881345;
				if (num != 0)
				{
				}
				num = (short)384434176;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002AD8 File Offset: 0x00000CD8
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002B8C File Offset: 0x00000D8C
		public global::Motorola.Common.Communication.ISequenceManager SequenceManager
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)75890688;
				short num2 = num;
				num = (short)1970642618;
				short num3 = num;
				num = (short)991534778;
				switch (num3 == num)
				{
				}
				num = (short)1016856577;
				if (num != 0)
				{
				}
				num = (short)610664448;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1829109760;
				short num2 = num;
				num = (short)2067368080;
				short num3 = num;
				num = (short)1756530832;
				switch (num3 == num)
				{
				}
				num = (short)1769340929;
				if (num != 0)
				{
				}
				num = (short)613810176;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002C40 File Offset: 0x00000E40
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002CF0 File Offset: 0x00000EF0
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe CommunicationPipe
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1236074496;
				short num2 = num;
				num = (short)1659174913;
				if (num != 0)
				{
				}
				num = (short)671910160;
				short num3 = num;
				num = (short)1544128784;
				switch (num3 == num)
				{
				}
				num = (short)302514176;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1251803136;
				short num2 = num;
				num = (short)1008992257;
				if (num != 0)
				{
				}
				num = (short)501838709;
				short num3 = num;
				num = (short)1422619509;
				switch (num3 == num)
				{
				}
				num = (short)607059968;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002DA4 File Offset: 0x00000FA4
		public CommunicationSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe, global::Motorola.Common.Communication.ISequenceManager sequenceManager)
		{
			this.ID = sessionID;
			this.CommunicationPipe = communicationPipe;
			this.SequenceManager = sequenceManager;
			this.OperationType = operationType;
		}

		// Token: 0x04000008 RID: 8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private ushort a;

		// Token: 0x04000009 RID: 9
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.CommonUtil.RadioOperation b;

		// Token: 0x0400000A RID: 10
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.ISequenceManager c;

		// Token: 0x0400000B RID: 11
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe d;
	}
}
