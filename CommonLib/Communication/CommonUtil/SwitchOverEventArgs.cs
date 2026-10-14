using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000030 RID: 48
	[global::System.Runtime.Serialization.DataContract]
	public class SwitchOverEventArgs : global::System.EventArgs
	{
		// Token: 0x060000FB RID: 251 RVA: 0x00017A84 File Offset: 0x00015C84
		public SwitchOverEventArgs(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, ushort sessionID, global::Motorola.Common.Communication.CommonUtil.SwitchOverStatus status)
		{
			this.DeviceInfo = deviceInfo;
			this.SessionID = sessionID;
			this.Status = status;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00017AAC File Offset: 0x00015CAC
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00017B5C File Offset: 0x00015D5C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo DeviceInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1993150405;
				short num2 = num;
				num = (short)1320554437;
				switch (num2 == num)
				{
				}
				num = (short)468058113;
				if (num != 0)
				{
				}
				num = (short)1246887936;
				if (num != 0)
				{
				}
				num = (short)84934656;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)101540884;
				short num2 = num;
				num = (short)1320510484;
				switch (num2 == num)
				{
				}
				num = (short)614465536;
				if (num != 0)
				{
				}
				num = (short)1605894145;
				if (num != 0)
				{
				}
				num = (short)342818816;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00017C0C File Offset: 0x00015E0C
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00017CBC File Offset: 0x00015EBC
		[global::System.Runtime.Serialization.DataMember]
		public ushort SessionID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)832106166;
				short num2 = num;
				num = (short)113831606;
				switch (num2 == num)
				{
				}
				num = (short)1430192129;
				if (num != 0)
				{
				}
				num = (short)1793523712;
				if (num != 0)
				{
				}
				num = (short)851509248;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)88346314;
				short num2 = num;
				num = (short)1236405962;
				switch (num2 == num)
				{
				}
				num = (short)599392257;
				if (num != 0)
				{
				}
				num = (short)23527424;
				if (num != 0)
				{
				}
				num = (short)250937344;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00017D6C File Offset: 0x00015F6C
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00017E18 File Offset: 0x00016018
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.SwitchOverStatus Status
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)872690676;
				short num2 = num;
				num = (short)1687172084;
				switch (num2 == num)
				{
				}
				num = (short)228458496;
				if (num != 0)
				{
				}
				num = (short)1891500033;
				if (num != 0)
				{
				}
				num = (short)1142620160;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1163573243;
				short num2 = num;
				num = (short)307214331;
				switch (num2 == num)
				{
				}
				num = (short)623575041;
				if (num != 0)
				{
				}
				num = (short)1746075648;
				if (num != 0)
				{
				}
				num = (short)1257701376;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x04000125 RID: 293
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.CommonUtil.DeviceInfo a;

		// Token: 0x04000126 RID: 294
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private ushort b;

		// Token: 0x04000127 RID: 295
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.CommonUtil.SwitchOverStatus c;
	}
}
