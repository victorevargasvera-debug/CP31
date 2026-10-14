using System;
using System.Text;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200002E RID: 46
	internal class AstroWireDevice : global::Motorola.Common.Communication.CommunicationManager.MotoDevice
	{
		// Token: 0x06000103 RID: 259 RVA: 0x000155F4 File Offset: 0x000137F4
		public AstroWireDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory sequenceManagerFactory, global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory communicationPipeFactory) : base(deviceInfo, profile, sequenceManagerFactory, communicationManager, communicationPipeFactory)
		{
			this.a = profile.InstanceId;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0001561C File Offset: 0x0001381C
		public override ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			short num = (short)643891201;
			if (num != 0)
			{
			}
			num = (short)1816173052;
			short num2 = num;
			num = (short)432642556;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1476460544;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)718798848;
			if (num != 0)
			{
			}
			base.RefreshIPAddress();
			return base.OpenSession(operationType, sessionParameter);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000156D4 File Offset: 0x000138D4
		public override void CloseSession(bool pendingDeploy)
		{
			int a_ = 1;
			short num = (short)1017247556;
			short num2 = num;
			num = (short)1034942276;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)855375872;
				short num3 = num;
				num = (short)456654848;
				if (num != 0)
				{
				}
				base.ValidateSession();
				try
				{
					switch (0)
					{
					case 0:
						goto IL_B5;
					}
					int num4;
					for (;;)
					{
						IL_8F:
						switch (num4)
						{
						case 0:
							if (this.CommunicationManager.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Lazy)
							{
								num = (short)2054684679;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1EF;
						case 1:
							if (!pendingDeploy)
							{
								num = (short)2056060932;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1EF;
						case 2:
							goto IL_22D;
						case 3:
							goto IL_1EF;
						case 4:
							num = (short)1107623942;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							base.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Removing);
							num = (short)1217331200;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (!this.DeviceInfo.ConnectionInfo.DeviceInstance.Contains(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ŕㅗ᱙㕛", a_)))
							{
								num = (short)2076573701;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1EF;
						case 7:
							global::System.Threading.Thread.Sleep(1000);
							global::Motorola.Common.Communication.CommonUtil.NativeMethodsForOtherNamSpace.CM_Request_Device_Eject(this.a, global::System.UIntPtr.Zero, global::System.UIntPtr.Zero, 0U, 0U);
							num = (short)628621315;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B5;
						IL_1EF:
						num = (short)1242365953;
						if (num != 0)
						{
						}
						num = (short)2090139650;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_22D:
					break;
					IL_B5:
					base.SequenceManager.CloseSession(base.ActiveSession.ID, base.ActiveSession.OperationType, pendingDeploy);
					global::System.Threading.Thread.Sleep(500);
					num = (short)1759182849;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_8F;
				}
				finally
				{
					base.DisposeSession();
				}
				break;
			}
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00015934 File Offset: 0x00013B34
		public override global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_20B;
				case 1:
					num2 = (short)977928193;
					if (num2 != 0)
					{
					}
					if (string.IsNullOrEmpty(extendedDeviceInfo.RadioID))
					{
						num2 = (short)1805910020;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20B;
				case 2:
					num2 = (short)702742533;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_A4;
				case 4:
				{
					num2 = (short)647438931;
					short num3 = num2;
					num2 = (short)61481555;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1446838272;
						if (num2 != 0)
						{
						}
						extendedDeviceInfo.RadioID = this.DeviceInfo.RadioID;
						num2 = (short)2083651584;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
				{
					num2 = (short)204931072;
					short num4 = num2;
					if (this.DeviceInfo.SerialNumber == global::System.Text.Encoding.ASCII.GetString(global::System.Convert.FromBase64String(extendedDeviceInfo.SerialNumber)))
					{
						num2 = (short)702676995;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_200;
				}
				case 6:
					return extendedDeviceInfo;
				case 7:
					if (!(this.DeviceInfo.SerialNumber == extendedDeviceInfo.SerialNumber))
					{
						num2 = (short)18677762;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A4;
				}
				goto IL_30;
				IL_A4:
				this.DeviceInfo.CodeplugVersion = extendedDeviceInfo.CodeplugVersion;
				this.DeviceInfo.ModelNumber = extendedDeviceInfo.ModelNumber;
				this.DeviceInfo.SerialNumber = extendedDeviceInfo.SerialNumber;
				this.DeviceInfo.SoftwareVersion = extendedDeviceInfo.SoftwareVersion;
				num2 = (short)1269301254;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_20B:
				extendedDeviceInfo.ConnectionInfo = this.DeviceInfo.ConnectionInfo;
				extendedDeviceInfo.RadioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
				num2 = (short)507969543;
				num = (int)((global::System.IntPtr)num2);
			}
			return extendedDeviceInfo;
			IL_200:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerWireDeviceIdentityMismatched);
			IL_30:
			extendedDeviceInfo = base.SequenceManager.ReadExtendedDeviceInfo();
			num2 = (short)1580924929;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400003A RID: 58
		private uint a;
	}
}
