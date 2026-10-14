using System;
using System.Collections;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000011 RID: 17
	public class DeviceMsgEventArgs : global::System.EventArgs, global::System.ICloneable
	{
		// Token: 0x06000061 RID: 97 RVA: 0x000065A4 File Offset: 0x000047A4
		public DeviceMsgEventArgs()
		{
			this.a = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceStatusUnknow;
			this.b = new global::System.Collections.ArrayList();
			this.b.Clear();
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000065D4 File Offset: 0x000047D4
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00006684 File Offset: 0x00004884
		public global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction PnPAction
		{
			get
			{
				short num = (short)718442677;
				short num2 = num;
				num = (short)1787859125;
				switch (num2 == num)
				{
				}
				num = (short)1359478784;
				if (num != 0)
				{
				}
				num = (short)1699217409;
				if (num != 0)
				{
				}
				num = (short)1392377856;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)1104374763;
				short num2 = num;
				num = (short)1324641259;
				switch (num2 == num)
				{
				}
				num = (short)738656257;
				if (num != 0)
				{
				}
				num = (short)705232896;
				if (num != 0)
				{
				}
				num = (short)2036072448;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00006738 File Offset: 0x00004938
		public global::System.Collections.ArrayList RadioInfoSet
		{
			get
			{
				short num = (short)1005232067;
				short num2 = num;
				num = (short)1466277827;
				switch (num2 == num)
				{
				}
				num = (short)217841665;
				if (num != 0)
				{
				}
				num = (short)264765440;
				if (num != 0)
				{
				}
				num = (short)1481768960;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000067E8 File Offset: 0x000049E8
		public object Clone()
		{
			short num = (short)1544423905;
			short num2 = num;
			num = (short)1843988961;
			switch (num2 == num)
			{
			}
			num = (short)1810759681;
			if (num != 0)
			{
			}
			num = (short)649592832;
			if (num != 0)
			{
			}
			num = (short)1763966976;
			short num3 = num;
			return base.MemberwiseClone() as global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs;
		}

		// Token: 0x0400002D RID: 45
		private global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction a;

		// Token: 0x0400002E RID: 46
		private readonly global::System.Collections.ArrayList b;
	}
}
