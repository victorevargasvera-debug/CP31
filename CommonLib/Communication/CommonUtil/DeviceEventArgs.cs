using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200002F RID: 47
	[global::System.Runtime.Serialization.DataContract]
	public class DeviceEventArgs : global::System.EventArgs
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x00017904 File Offset: 0x00015B04
		public DeviceEventArgs(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			this.DeviceInfo = deviceInfo;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00017920 File Offset: 0x00015B20
		// (set) Token: 0x060000FA RID: 250 RVA: 0x000179D0 File Offset: 0x00015BD0
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo DeviceInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)909952078;
				short num2 = num;
				num = (short)1210762318;
				switch (num2 == num)
				{
				}
				num = (short)1133576192;
				if (num != 0)
				{
				}
				num = (short)1676279809;
				if (num != 0)
				{
				}
				num = (short)1997078528;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)777405472;
				short num2 = num;
				num = (short)1831552032;
				switch (num2 == num)
				{
				}
				num = (short)1872494593;
				if (num != 0)
				{
				}
				num = (short)1104543744;
				if (num != 0)
				{
				}
				num = (short)1319239680;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x04000124 RID: 292
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.CommonUtil.DeviceInfo a;
	}
}
