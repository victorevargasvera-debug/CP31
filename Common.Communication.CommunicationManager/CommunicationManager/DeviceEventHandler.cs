using System;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200000D RID: 13
	public class DeviceEventHandler : global::Motorola.Common.Communication.CommunicationManager.IDeviceEventHandler
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00008434 File Offset: 0x00006634
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000084E0 File Offset: 0x000066E0
		public global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> DeviceConnectedEventHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1842085888;
				short num2 = num;
				num = (short)108141209;
				short num3 = num;
				num = (short)67377817;
				switch (num3 == num)
				{
				}
				num = (short)1838153729;
				if (num != 0)
				{
				}
				num = (short)282001408;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)494534656;
				short num2 = num;
				num = (short)1310137609;
				short num3 = num;
				num = (short)2128092425;
				switch (num3 == num)
				{
				}
				num = (short)613744641;
				if (num != 0)
				{
				}
				num = (short)1713700864;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00008594 File Offset: 0x00006794
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00008644 File Offset: 0x00006844
		public global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> DeviceLostEventHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1002635264;
				short num2 = num;
				num = (short)1313603585;
				if (num != 0)
				{
				}
				num = (short)633424967;
				short num3 = num;
				num = (short)1671580743;
				switch (num3 == num)
				{
				}
				num = (short)115081216;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)873660416;
				short num2 = num;
				num = (short)1025122915;
				short num3 = num;
				num = (short)755245667;
				switch (num3 == num)
				{
				}
				num = (short)436404225;
				if (num != 0)
				{
				}
				num = (short)896073728;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000086F4 File Offset: 0x000068F4
		protected virtual void OnDeviceConnected(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)2102394880;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)488384950;
				short num3 = num;
				num = (short)1338845622;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)42270720;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_15;
					case 1:
						return;
					case 2:
						this.DeviceConnectedEventHandler(this, new global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs(deviceInfo));
						num = (short)832897025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7C;
				}
				IL_15:
				switch (0)
				{
				case 0:
				{
					IL_7C:
					num = (short)1096810496;
					short num4 = num;
					if (this.DeviceConnectedEventHandler == null)
					{
						return;
					}
					num = (short)1475477505;
					if (num != 0)
					{
					}
					num = (short)55771138;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000881C File Offset: 0x00006A1C
		protected virtual void OnDeviceLost(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)478478336;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2102517795;
				short num3 = num;
				num = (short)176414755;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)147259392;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_14;
					case 1:
						goto IL_EE;
					case 2:
						this.DeviceLostEventHandler(this, new global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs(deviceInfo));
						num = (short)735248385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7B;
				}
				IL_14:
				switch (0)
				{
				case 0:
				{
					IL_7B:
					num = (short)1920073728;
					short num4 = num;
					if (this.DeviceLostEventHandler == null)
					{
						goto IL_F0;
					}
					num = (short)971636738;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_EE:
			IL_F0:
			num = (short)1576075265;
			if (num != 0)
			{
			}
		}

		// Token: 0x04000011 RID: 17
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> a;

		// Token: 0x04000012 RID: 18
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> b;
	}
}
