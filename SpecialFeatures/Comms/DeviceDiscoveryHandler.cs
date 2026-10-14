using System;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Service;

namespace SpecialFeatures.Comms
{
	// Token: 0x0200015D RID: 349
	[global::System.ServiceModel.CallbackBehavior(UseSynchronizationContext = false)]
	public class DeviceDiscoveryHandler : global::Motorola.Common.Communication.Service.IDiscoveryServiceEvent
	{
		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060011B2 RID: 4530 RVA: 0x001836D0 File Offset: 0x001818D0
		// (set) Token: 0x060011B3 RID: 4531 RVA: 0x00183780 File Offset: 0x00181980
		internal global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> DeviceConnectedEventHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)389939200;
				short num2 = num;
				num = (short)1256737623;
				short num3 = num;
				num = (short)858344279;
				switch (num3 == num)
				{
				}
				num = (short)1619197952;
				if (num != 0)
				{
				}
				num = (short)817954817;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)783876096;
				short num2 = num;
				num = (short)875579040;
				short num3 = num;
				num = (short)1295206048;
				switch (num3 == num)
				{
				}
				num = (short)1371930624;
				if (num != 0)
				{
				}
				num = (short)543686657;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x00183830 File Offset: 0x00181A30
		// (set) Token: 0x060011B5 RID: 4533 RVA: 0x001838E0 File Offset: 0x00181AE0
		internal global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> DeviceLostEventHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)160890880;
				short num2 = num;
				num = (short)1041246499;
				short num3 = num;
				num = (short)1429023011;
				switch (num3 == num)
				{
				}
				num = (short)954073089;
				if (num != 0)
				{
				}
				num = (short)729481216;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)323747840;
				short num2 = num;
				num = (short)1312186942;
				short num3 = num;
				num = (short)1078157886;
				switch (num3 == num)
				{
				}
				num = (short)340656129;
				if (num != 0)
				{
				}
				num = (short)268107776;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00183994 File Offset: 0x00181B94
		public void OnDeviceConnected(global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs args)
		{
			short num = (short)1535967232;
			short num2 = num;
			num = (short)804847616;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 1:
					return;
				case 2:
				{
					num = (short)49414145;
					if (num != 0)
					{
					}
					this.DeviceConnectedEventHandler(this, args);
					num = (short)845271202;
					short num4 = num;
					num = (short)1274466466;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)38731776;
						if (num != 0)
						{
						}
						num = (short)268959745;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_5A:
				if (this.DeviceConnectedEventHandler == null)
				{
					break;
				}
				num = (short)1347878914;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00183AB4 File Offset: 0x00181CB4
		public void OnDeviceLost(global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs args)
		{
			short num = (short)1784807424;
			short num2 = num;
			num = (short)1436024832;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 1:
					return;
				case 2:
				{
					this.DeviceLostEventHandler(this, args);
					num = (short)991407207;
					short num4 = num;
					num = (short)324512871;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1350959104;
						if (num != 0)
						{
						}
						num = (short)1355743233;
						if (num != 0)
						{
						}
						num = (short)196476929;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_5A:
				if (this.DeviceLostEventHandler == null)
				{
					break;
				}
				num = (short)857079810;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00183BD8 File Offset: 0x00181DD8
		public void OnDeviceSwitchOver(global::Motorola.Common.Communication.CommonUtil.SwitchOverEventArgs args)
		{
			short num = (short)525205504;
			short num2 = num;
			num = (short)2147154776;
			short num3 = num;
			num = (short)1875508056;
			switch (num3 == num)
			{
			}
			num = (short)1481113600;
			if (num != 0)
			{
			}
			num = (short)287703041;
			if (num != 0)
			{
			}
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00183C84 File Offset: 0x00181E84
		public void OnMasterSystemLost(global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs args)
		{
			short num = (short)1131806720;
			short num2 = num;
			num = (short)691451304;
			short num3 = num;
			num = (short)1676850600;
			switch (num3 == num)
			{
			}
			num = (short)295108609;
			if (num != 0)
			{
			}
			num = (short)2111373312;
			if (num != 0)
			{
			}
		}

		// Token: 0x040009B8 RID: 2488
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> a;

		// Token: 0x040009B9 RID: 2489
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> b;
	}
}
