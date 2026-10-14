using System;
using Motorola.Common.Communication.AmpConfigPackage;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Utils
{
	// Token: 0x02000030 RID: 48
	public static class InfoMapper
	{
		// Token: 0x06000187 RID: 391 RVA: 0x00027150 File Offset: 0x00025350
		public static void MapBasicDeviceInfo(global::Motorola.Common.Communication.RadioParams source, global::Motorola.Common.Communication.CommonUtil.DeviceInfo destination)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_6D;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)1388249094;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (destination.ConnectionInfo == null)
					{
						num2 = (short)951779347;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2C2;
				case 2:
					goto IL_3AD;
				case 3:
					if (source.PsdtVersion.Length > 0)
					{
						num2 = (short)221315080;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_475;
				case 4:
					num2 = (short)2083192837;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_3ED;
				case 6:
				{
					global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue networkAttachmentValue;
					if (networkAttachmentValue != global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.LMR)
					{
						num2 = (short)96993284;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					destination.ConnectionInfo.OtapConnectionType = global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.LMR;
					num2 = (short)1917714432;
					short num3 = num2;
					num2 = (short)621019138;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
				{
					global::System.Version version;
					destination.RadioStorage = ((version.CompareTo(new global::System.Version(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("쏲쏴\ud9f6컸쯺폼쿾㄀", a_))) >= 0) ? global::Motorola.Common.Communication.CommonUtil.RadioStorage.FileSystem : global::Motorola.Common.Communication.CommonUtil.RadioStorage.Raw);
					num2 = (short)121634827;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
				{
					global::System.Version version = new global::System.Version(source.PsdtVersion.Remove(0, 1));
					num2 = (short)491716615;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
					if (!string.IsNullOrEmpty(source.DefaultGatewayNetworkAttachmentValue))
					{
						num2 = (short)1274216466;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					destination.ConnectionInfo.OtapConnectionType = global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.NONE;
					num2 = (short)1037041684;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					destination.ConnectionInfo.Location = source.TlsPskPortNumber;
					destination.ConnectionInfo.IsTlsPskCompatible = true;
					num2 = (short)2052653069;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_473;
				case 12:
					if (source.IsTlsPskCompatible)
					{
						num2 = (short)1222508554;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1E0;
				case 13:
					goto IL_1E0;
				case 14:
				{
					global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue networkAttachmentValue;
					switch (networkAttachmentValue)
					{
					case global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.NoDefaultGateway:
					case global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.OneG:
					case global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.TwoG:
					case global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.ThreeG:
					case global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.WiFi:
						goto IL_3ED;
					case global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.FourG:
						destination.ConnectionInfo.OtapConnectionType = global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.LTE;
						num2 = (short)36634639;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)1907097600;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 15:
					goto IL_3AD;
				case 16:
					goto IL_3AD;
				case 17:
					goto IL_2C2;
				case 18:
				{
					global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue networkAttachmentValue = (global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue)global::System.Convert.ToByte(source.DefaultGatewayNetworkAttachmentValue);
					num2 = (short)157690607;
					short num4 = num2;
					num2 = (short)1982147311;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E6;
					default:
						num2 = (short)51970048;
						if (num2 != 0)
						{
						}
						num2 = (short)1566965774;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 19:
					destination.ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo();
					goto IL_E6;
				case 20:
					goto IL_3AD;
				}
				goto IL_6D;
				IL_E6:
				num2 = (short)2060582929;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1E0:
				destination.RadioBBFSuiteVersion = source.BBFBundleVersion;
				num2 = (short)68288515;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2C2:
				num2 = (short)750256137;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3AD:
				num2 = (short)557907980;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3ED:
				num2 = (short)1111097345;
				if (num2 != 0)
				{
				}
				destination.ConnectionInfo.OtapConnectionType = global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.NONE;
				num2 = (short)1860567056;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_473:
			destination.PendingBBFSuiteVersion = source.PendingBbfBundleVersion;
			destination.CodeplugSessionID = source.CodeplugSessionID;
			destination.DownloadPercent = source.DownloadPercent;
			return;
			IL_475:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_InvalidPSDT);
			IL_6D:
			destination.CodeplugVersion = source.CodeplugVersion;
			destination.ModelNumber = source.ModelNumber;
			destination.SerialNumber = source.SerialNumber;
			destination.SoftwareVersion = source.HostVersion;
			num2 = (short)26411009;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00027604 File Offset: 0x00025804
		public static void MapExtendedDeviceInfo(global::Motorola.Common.Communication.RadioParams radioData, global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo deviceInfo)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)692191233;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (radioData.ESerialNumber.Length != 0)
					{
						num2 = (short)1504182274;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					num2 = (short)1853299420;
					short num3 = num2;
					num2 = (short)256645852;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_149;
					default:
						num2 = (short)708509696;
						if (num2 != 0)
						{
						}
						num2 = (short)465371137;
						if (num2 != 0)
						{
						}
						deviceInfo.ESN = new byte[radioData.ESerialNumber.Length];
						radioData.ESerialNumber.CopyTo(deviceInfo.ESN, 0);
						num2 = (short)1816657924;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					goto IL_149;
				case 4:
					return;
				}
				goto IL_24;
				IL_149:
				if (radioData.ESerialNumber == null)
				{
					break;
				}
				num2 = (short)1045495808;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_24:
			global::Motorola.Common.Communication.Utils.InfoMapper.MapBasicDeviceInfo(radioData, deviceInfo);
			deviceInfo.UUID = radioData.Uuid.ToString();
			deviceInfo.RadioBBFSuiteVersion = radioData.BBFBundleVersion;
			deviceInfo.TuneVersion = radioData.TuneVersion;
			deviceInfo.PsdtVersion = radioData.PsdtVersion;
			deviceInfo.MaceFlashVersion = radioData.MaceFlashVersion;
			deviceInfo.DspVersion = radioData.DspVersion;
			deviceInfo.BootloaderVersion = radioData.BootAppVersion;
			deviceInfo.OptionBoardFlashImageType = radioData.OptBrdFlashImageType;
			deviceInfo.OptionBoardFlashImageVersion = radioData.OptBrdFlashImageVersion;
			deviceInfo.OptionBoardHardwareHostVersion = radioData.OptBrdHwHostVersion;
			deviceInfo.OptionBoardHardwareNotPresentFlag = radioData.OptBrdHwNotPresentFlag;
			deviceInfo.OptionBoardHardwareType = radioData.OptBrdHardwareType;
			deviceInfo.OptionBoardName = radioData.OptBoardName;
			deviceInfo.ConsoletteBoardHardwareType = radioData.ConBrdHardwareType;
			deviceInfo.ConsoletteBoardHardwareHostVersion = radioData.ConBrdHwHostVersion;
			deviceInfo.MaceSecureHardwareType = radioData.MaceHardwareType;
			deviceInfo.MaceSecureHardwareVersion = radioData.MaceHardwareVersion;
			num2 = (short)815792128;
			short num4 = num2;
			num2 = (short)804585475;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
