using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager.Device
{
	// Token: 0x0200003B RID: 59
	internal class BTDevice : global::Motorola.Common.Communication.CommunicationManager.WiFiDevice
	{
		// Token: 0x06000144 RID: 324 RVA: 0x0001A0D4 File Offset: 0x000182D4
		public BTDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory sequenceManagerFactory, global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory communicationPipeFactory) : base(deviceInfo, profile, sequenceManagerFactory, communicationManager, communicationPipeFactory)
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0001A0F0 File Offset: 0x000182F0
		protected override bool RetrieveIPAddress(ref global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile _radioProfile)
		{
			short num = (short)1290369251;
			short num2 = num;
			num = (short)656242915;
			switch (num2 == num)
			{
			}
			num = (short)42795008;
			short num3 = num;
			num = (short)1901789184;
			if (num != 0)
			{
			}
			num = (short)1505624065;
			if (num != 0)
			{
			}
			bool flag = base.RetrieveIPAddress(ref _radioProfile);
			if (flag)
			{
				this.DeviceInfo.ConnectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.Bluetooth;
			}
			return flag;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0001A1B8 File Offset: 0x000183B8
		public override void CloseSession(bool pendingDeploy)
		{
			short num = (short)1141964691;
			short num2 = num;
			num = (short)397213587;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1556086785;
				if (num != 0)
				{
				}
				num = (short)1835466752;
				if (num != 0)
				{
				}
				num = (short)1269628928;
				short num3 = num;
				base.ValidateSession();
				try
				{
					switch (0)
					{
					case 0:
						goto IL_C3;
					}
					int num4;
					for (;;)
					{
						IL_AD:
						switch (num4)
						{
						case 0:
							goto IL_162;
						case 1:
							if ((base.ActiveSession.OperationType & global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program) == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
							{
								num = (short)740818946;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_162;
						case 2:
							this.CommunicationManager.RemoveDevice(this.DeviceInfo.RadioID);
							global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector>.Instance().ClearDevice(this._radioProfile);
							num = (short)1446117376;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_179;
						}
						goto IL_C3;
						IL_162:
						num = (short)1654915075;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_179:
					break;
					IL_C3:
					base.SequenceManager.CloseSession(base.ActiveSession.ID, base.ActiveSession.OperationType, pendingDeploy);
					num = (short)1989083137;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_AD;
				}
				finally
				{
					base.DisposeSession();
				}
				break;
			}
			}
		}
	}
}
