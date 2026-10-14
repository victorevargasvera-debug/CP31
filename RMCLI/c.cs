using System;
using System.Collections.Generic;
using CommonLicenseInterfaceWrapper;
using Motorola.CommonCPS.Server.EntityModel;

namespace commonLicensing
{
	// Token: 0x02000009 RID: 9
	internal static class c
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00005AC0 File Offset: 0x00003CC0
		public static global::CommonLicenseInterfaceWrapper.DeviceRequest a(global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest A_0)
		{
			short num = (short)1334509568;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)243204096;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_64;
				}
				global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.ActivationInfo> list;
				for (;;)
				{
					IL_51:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						if (A_0.ActivationInfo.Count > 0)
						{
							num = (short)217317378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23F;
					case 1:
						try
						{
							num = (short)539361281;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1731002372;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation activationInformation = enumerator.Current;
									global::CommonLicenseInterfaceWrapper.ActivationInfo item = new global::CommonLicenseInterfaceWrapper.ActivationInfo
									{
										activationCount = activationInformation.Count,
										activationId = activationInformation.ID
									};
									list.Add(item);
									num = (short)596312066;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									num = (short)986426422;
									short num4 = num;
									num = (short)2079304758;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)504365056;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_162;
										}
										continue;
									}
									break;
								}
								case 3:
									goto IL_203;
								case 4:
									num = (short)953942019;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_164:
								num = (short)160628736;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_162:
								goto IL_164;
							}
							IL_203:
							goto IL_23F;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_213;
					case 2:
						goto IL_213;
					}
					goto IL_64;
					IL_213:
					enumerator = A_0.ActivationInfo.GetEnumerator();
					num = (short)689766401;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_23F:
				global::CommonLicenseInterfaceWrapper.DeviceRequest deviceRequest;
				deviceRequest.activationInfoList = list;
				global::CommonLicenseInterfaceWrapper.DeviceInfo deviceInfo = new global::CommonLicenseInterfaceWrapper.DeviceInfo
				{
					deviceAlias = string.Empty,
					deviceId = A_0.DeviceID,
					deviceType = string.Empty
				};
				deviceRequest.deviceInfo = deviceInfo;
				global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.FeatureInfoCount> featureInfoCountList = new global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.FeatureInfoCount>();
				deviceRequest.featureInfoCountList = featureInfoCountList;
				return deviceRequest;
				IL_64:
				deviceRequest = new global::CommonLicenseInterfaceWrapper.DeviceRequest();
				list = new global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.ActivationInfo>();
				num = (short)1735327745;
				if (num != 0)
				{
				}
				num = (short)953417728;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00005D6C File Offset: 0x00003F6C
		public static global::CommonLicenseInterfaceWrapper.DeviceCapabilityResponse a(byte[] A_0, string A_1)
		{
			short num = (short)758775141;
			short num2 = num;
			num = (short)1148976485;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1417019392;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1234370561;
			if (num != 0)
			{
			}
			num = (short)222429184;
			if (num != 0)
			{
			}
			global::CommonLicenseInterfaceWrapper.DeviceCapabilityResponse deviceCapabilityResponse = new global::CommonLicenseInterfaceWrapper.DeviceCapabilityResponse();
			deviceCapabilityResponse.binaryResponse = A_0;
			deviceCapabilityResponse.binaryResponseSize = A_0.Length;
			global::CommonLicenseInterfaceWrapper.DeviceInfo deviceInfo = new global::CommonLicenseInterfaceWrapper.DeviceInfo
			{
				deviceId = A_1,
				deviceAlias = string.Empty,
				deviceType = string.Empty
			};
			deviceCapabilityResponse.deviceInfo = deviceInfo;
			return deviceCapabilityResponse;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00005E54 File Offset: 0x00004054
		public static global::CommonLicenseInterfaceWrapper.FeatureInfo a(string A_0, string A_1)
		{
			short num = (short)1487827834;
			short num2 = num;
			num = (short)1546285946;
			switch (num2 == num)
			{
			default:
			{
				num = (short)534577152;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1644167169;
			if (num != 0)
			{
			}
			num = (short)1943666688;
			if (num != 0)
			{
			}
			return new global::CommonLicenseInterfaceWrapper.FeatureInfo
			{
				featureName = A_0,
				featureVersion = A_1
			};
		}
	}
}
