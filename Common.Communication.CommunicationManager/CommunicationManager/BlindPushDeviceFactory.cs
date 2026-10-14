using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000028 RID: 40
	internal static class BlindPushDeviceFactory
	{
		// Token: 0x0600008D RID: 141 RVA: 0x0000C21C File Offset: 0x0000A41C
		public static global::Motorola.Common.Communication.IMotoDevice CreateRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass communicationManager, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory sequenceManagerFactory, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory communicationPipeFactory)
		{
			switch (0)
			{
			case 0:
				goto IL_64;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.IMotoDevice motoDevice;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1590886409;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					motoDevice = new global::Motorola.Common.Communication.CommunicationManager.AstroOtapDevice(deviceInfo, sequenceManagerFactory, communicationManager, communicationPipeFactory);
					num2 = (short)1823014929;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					motoDevice = new global::Motorola.Common.Communication.CommunicationManager.AstroWiFiDevice(deviceInfo, null, sequenceManagerFactory, communicationManager, communicationPipeFactory);
					num2 = (short)1679491091;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (deviceInfo.Family == (deviceInfo.Family & global::Motorola.Common.Communication.CommonUtil.ProductFamily.PCRRadio))
					{
						num2 = (short)1676935168;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2A8;
				case 4:
					if (deviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio)
					{
						num2 = (short)1636171784;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)915406851;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_254;
				case 6:
					num2 = (short)1705312257;
					if (num2 != 0)
					{
					}
					goto IL_15B;
				case 7:
					motoDevice = new global::Motorola.Common.Communication.CommunicationManager.MotoDevice(deviceInfo, null, sequenceManagerFactory, communicationManager, communicationPipeFactory);
					num2 = (short)799539216;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)1995243533;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (deviceInfo.ConnectionInfo.ConnectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork)
					{
						num2 = (short)229244942;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15B;
				case 10:
					goto IL_197;
				case 11:
					if (deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap)
					{
						num2 = (short)1138163713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)584187919;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (deviceInfo.ConnectionInfo.ConnectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.DMR3Network)
					{
						num2 = (short)828440583;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15B;
				case 13:
					if (deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.Bluetooth)
					{
						num2 = (short)1558118410;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)203685899;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					num2 = (short)992346124;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
				{
					num2 = (short)1340887675;
					short num3 = num2;
					num2 = (short)590238331;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_197;
					default:
					{
						num2 = (short)1987444736;
						if (num2 != 0)
						{
						}
						num2 = (short)1239220224;
						short num4 = num2;
						if (deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI)
						{
							num2 = (short)62390274;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_15B;
					}
					}
					break;
				}
				case 16:
					goto IL_15B;
				case 17:
					goto IL_15B;
				case 18:
					if (motoDevice != null)
					{
						num2 = (short)1057292308;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return motoDevice;
				case 19:
					goto IL_15B;
				case 20:
					motoDevice.radioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
					communicationManager.AddBlindPushDevice(motoDevice);
					num2 = (short)967573509;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_64;
				IL_15B:
				num2 = (short)9306130;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_197:
				motoDevice = new global::Motorola.Common.Communication.CommunicationManager.MotoDevice(deviceInfo, null, sequenceManagerFactory, communicationManager, communicationPipeFactory);
				num2 = (short)1245904902;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_254:
			return motoDevice;
			IL_2A8:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerUnknownDeviceFamily);
			IL_64:
			motoDevice = null;
			num2 = (short)417923076;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
