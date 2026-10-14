using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;
using Microsoft.Win32;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x0200002F RID: 47
	public class RNDISDetector : global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase
	{
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000126 RID: 294 RVA: 0x0001451C File Offset: 0x0001271C
		// (remove) Token: 0x06000127 RID: 295 RVA: 0x00014654 File Offset: 0x00012854
		public override event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceAttached
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler;
				for (;;)
				{
					IL_0A:
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)1713817266;
						short num3 = num2;
						num2 = (short)702400178;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_56;
						case 1:
							break;
						default:
						{
							num2 = (short)1173094400;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)127533056;
						if (num2 != 0)
						{
						}
						if (deviceEventHandler == deviceEventHandler2)
						{
							num2 = (short)369754113;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					}
					case 1:
						goto IL_FE;
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_56:
					num2 = (short)1155072000;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_39:
					deviceEventHandler2 = deviceEventHandler;
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler)global::System.Delegate.Combine(deviceEventHandler2, value);
					deviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler>(ref this.d, value2, deviceEventHandler2);
					goto IL_56;
				}
				IL_FE:
				num2 = (short)1513750529;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				deviceEventHandler = this.d;
				num2 = (short)1422262274;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler;
				for (;;)
				{
					IL_0A:
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)1513984055;
						short num3 = num2;
						num2 = (short)1351913527;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_56;
						case 1:
							break;
						default:
						{
							num2 = (short)1228406784;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)1148583937;
						if (num2 != 0)
						{
						}
						num2 = (short)689176576;
						if (num2 != 0)
						{
						}
						if (deviceEventHandler == deviceEventHandler2)
						{
							num2 = (short)2113208321;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					}
					case 1:
						return;
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_56:
					num2 = (short)211091456;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_39:
					deviceEventHandler2 = deviceEventHandler;
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler)global::System.Delegate.Remove(deviceEventHandler2, value);
					deviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler>(ref this.d, value2, deviceEventHandler2);
					goto IL_56;
				}
				return;
				IL_1C:
				deviceEventHandler = this.d;
				num2 = (short)1592590338;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000128 RID: 296 RVA: 0x00014788 File Offset: 0x00012988
		// (remove) Token: 0x06000129 RID: 297 RVA: 0x000148BC File Offset: 0x00012ABC
		public override event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceDetached
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler;
				for (;;)
				{
					IL_0A:
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)1163962114;
						short num3 = num2;
						num2 = (short)526100226;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_56;
						case 1:
							break;
						default:
						{
							num2 = (short)2112028672;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)407371776;
						if (num2 != 0)
						{
						}
						num2 = (short)2075656193;
						if (num2 != 0)
						{
						}
						if (deviceEventHandler == deviceEventHandler2)
						{
							num2 = (short)756744193;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					}
					case 1:
						return;
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_56:
					num2 = (short)348848128;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_39:
					deviceEventHandler2 = deviceEventHandler;
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler)global::System.Delegate.Combine(deviceEventHandler2, value);
					deviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler>(ref this.e, value2, deviceEventHandler2);
					goto IL_56;
				}
				return;
				IL_1C:
				deviceEventHandler = this.e;
				num2 = (short)463994882;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler;
				for (;;)
				{
					IL_0A:
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)1144939324;
						short num3 = num2;
						num2 = (short)301884220;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_56;
						case 1:
							break;
						default:
						{
							num2 = (short)975175680;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)1775894528;
						if (num2 != 0)
						{
						}
						num2 = (short)308674561;
						if (num2 != 0)
						{
						}
						if (deviceEventHandler == deviceEventHandler2)
						{
							num2 = (short)2128412673;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					}
					case 1:
						return;
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_56:
					num2 = (short)1464926208;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_39:
					deviceEventHandler2 = deviceEventHandler;
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler)global::System.Delegate.Remove(deviceEventHandler2, value);
					deviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler>(ref this.e, value2, deviceEventHandler2);
					goto IL_56;
				}
				return;
				IL_1C:
				deviceEventHandler = this.e;
				num2 = (short)1549991938;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000149F0 File Offset: 0x00012BF0
		public RNDISDetector()
		{
			int a_ = 9;
			this.c = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ه⽉㡋്㙏㕑ᵓ㡕⭗⹙㵛そ͟ݡⵣɥ", a_);
			base..ctor();
			base.DetectorType = global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType.RNDISDetector;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00014A28 File Offset: 0x00012C28
		protected override void InitDevClassGUIDList()
		{
			short num = (short)2084581287;
			short num2 = num;
			num = (short)927084455;
			switch (num2 == num)
			{
			}
			num = (short)2110259201;
			if (num != 0)
			{
			}
			num = (short)1143275520;
			if (num != 0)
			{
			}
			num = (short)1987575808;
			short num3 = num;
			base._radioClass = new global::System.Guid(global::Motorola.Common.Communication.DeviceDiscovery.RNDISDetector.b);
			base.lstValidGuid.Add(base._radioClass);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00014AF4 File Offset: 0x00012CF4
		protected override void HandleDeviceAttached(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg orgPnPMsg)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			global::Motorola.Common.Communication.IRadioProfile radioProfile;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
				{
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs deviceMsgEventArgs = new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs
					{
						PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached
					};
					deviceMsgEventArgs.RadioInfoSet.Add(radioProfile);
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler;
					deviceEventHandler(this, deviceMsgEventArgs);
					num2 = (short)377946113;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return;
				case 2:
				{
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler;
					if (deviceEventHandler != null)
					{
						num2 = (short)954662912;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 3:
					goto IL_E8;
				case 4:
					if (this.ExtractRadioInformation(orgPnPMsg, ref radioProfile))
					{
						num2 = (short)438435843;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_2D;
			}
			IL_E8:
			goto IL_129;
			IL_2D:
			num2 = (short)2005793188;
			short num3 = num2;
			num2 = (short)658176420;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_129:
				num2 = (short)1185677312;
				short num4 = num2;
				base._currentExistDevice.Add(radioProfile);
				global::System.Diagnostics.Trace.TraceInformation(string.Format(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᩀᙂᙄՆᑈ၊㙌罎ⱐ๒๔ⱖ桘♚\\罞፠ɢŤ๦٨䭪Ѭᱮ兰ቲŴͶᡸ᡺ᕼ᩾ꎂﶈ권\udf8e\ud890힒꾔랖ꦚ", a_), radioProfile.RadioType, radioProfile.RadioIdString, radioProfile.PID));
				num2 = (short)526385154;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)718929921;
				if (num2 != 0)
				{
				}
				num2 = (short)2139488256;
				if (num2 != 0)
				{
				}
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler = this.d;
				radioProfile = new global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile();
				num2 = (short)1285095428;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00014CC8 File Offset: 0x00012EC8
		protected override void HandleDeviceDetached(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg orgPnPMsg)
		{
			int a_ = 5;
			short num = (short)643432448;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile rndisradioProfile;
				string text;
				int num3;
				bool flag;
				int index;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						if (rndisradioProfile.DeviceInstanceID.IndexOf(text, global::System.StringComparison.OrdinalIgnoreCase) != -1)
						{
							num = (short)411697155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3++;
						num = (short)1754071042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)278449445;
						short num4 = num;
						num = (short)366464293;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_19E;
						default:
							goto IL_217;
						}
						break;
					}
					case 2:
						goto IL_E6;
					case 3:
						flag = true;
						index = num3;
						num = (short)1400307720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_AA;
					case 5:
						global::System.Diagnostics.Trace.TraceInformation(string.Format(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ὃፅᭇࡉᅋᕍ⭏扑⥓୕͗⅙浛⍝㵟䉡ᙣݥ౧ͩͫ乭᥯ű味ትᵷ๹ᵻᵽꚅﾇ낏슑\udd93튕ꊗ몙겝\udd9f", a_), rndisradioProfile.RadioType, rndisradioProfile.RadioIdString, rndisradioProfile.PID));
						base._currentExistDevice.RemoveAt(index);
						num = (short)1127415814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (deviceEventHandler != null)
						{
							num = (short)1877016585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
						goto IL_E6;
					case 8:
						goto IL_19E;
					case 9:
						deviceEventHandler(this, new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs
						{
							PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached,
							RadioInfoSet = 
							{
								rndisradioProfile
							}
						});
						num = (short)167837697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (num3 >= base._currentExistDevice.Count)
						{
							num = (short)39780353;
							if (num != 0)
							{
							}
							num = (short)1864695812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						rndisradioProfile = (global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile)base._currentExistDevice[num3];
						num = (short)72941568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (flag)
						{
							num = (short)1786445829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_68;
					IL_AA:
					num = (short)489357323;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E6:
					num = (short)1263730688;
					short num5 = num;
					num = (short)1155137546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19E:
					goto IL_AA;
				}
				IL_217:
				num = (short)65470464;
				if (num != 0)
				{
				}
				return;
				IL_68:
				rndisradioProfile = new global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile();
				flag = false;
				index = 0;
				deviceEventHandler = this.e;
				text = global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.GetDevCurrentLocationFromDevName(orgPnPMsg.sDeviceName);
				text = text.ToUpperInvariant();
				num3 = 0;
				num = (short)50921479;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00014FFC File Offset: 0x000131FC
		protected override bool ExtractRadioInformationHelper(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg orgPnPMsg, ref global::Motorola.Common.Communication.IRadioProfile radioInfo)
		{
			int a_ = 18;
			short num = (short)931397632;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BC;
				}
				global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile rndisradioProfile;
				global::System.IntPtr zero;
				bool result;
				for (;;)
				{
					IL_31:
					uint devID;
					global::System.Guid devClass;
					int num3;
					global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVINFO_DATA sp_DEVINFO_DATA;
					global::System.Guid devClass2;
					switch (num2)
					{
					case 0:
					{
						string value;
						if (base.NativeAPISet.Wrapper_CM_Get_Device_ID(devID, ref value))
						{
							num = (short)1583480850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_330;
					}
					case 1:
						if (!rndisradioProfile.VID.ToUpperInvariant().Equals(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("慐ၒᑔፖ", a_)))
						{
							num = (short)1186856986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᕐ㙒⅔㉖㩘⽚㡜㭞䅠ɢ䕤੦٨ὪɬᵮṰὲᑴ坶୸ᕺ᥼ᙾꎂ꾎벐뎒얔\ude96\udd98뮚Ꞝ뾞", a_) + rndisradioProfile.PID, global::System.Array.Empty<object>());
						num = (short)995426336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_330;
					case 3:
					{
						bool flag;
						if (flag)
						{
							num = (short)1828192262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_618;
					}
					case 4:
						devClass = base._devClass;
						num3 = 0;
						num = (short)418775056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						string text;
						string text2;
						if (text.IndexOf(text2, global::System.StringComparison.OrdinalIgnoreCase) != -1)
						{
							num = (short)679084039;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30C;
					}
					case 6:
					{
						num = (short)1507786753;
						if (num != 0)
						{
						}
						sp_DEVINFO_DATA.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVINFO_DATA));
						global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVICE_INTERFACE_DATA sp_DEVICE_INTERFACE_DATA;
						sp_DEVICE_INTERFACE_DATA.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVICE_INTERFACE_DATA));
						string text2 = global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.GetDevCurrentLocationFromDevName(orgPnPMsg.sDeviceName);
						text2 = text2.ToUpperInvariant();
						num = (short)505282587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						string text;
						rndisradioProfile.DeviceInstanceID = text;
						devID = 0U;
						num = (short)1174601741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_330;
					case 9:
						goto IL_236;
					case 10:
						goto IL_350;
					case 11:
					{
						global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVICE_INTERFACE_DATA sp_DEVICE_INTERFACE_DATA;
						uint num4;
						int num5;
						if (base.NativeAPISet.WrapperSetupDiGetDeviceInterfaceDetail(zero, ref sp_DEVICE_INTERFACE_DATA, global::System.IntPtr.Zero, 0U, out num4, ref sp_DEVINFO_DATA, out num5))
						{
							num = (short)1999962129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30C;
					}
					case 12:
					{
						base._devClass = devClass2;
						bool flag = false;
						num = (short)1635256333;
						short num6 = num;
						num = (short)2113865741;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5A2;
						default:
							num = (short)103284736;
							if (num != 0)
							{
							}
							num = (short)409403411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 13:
						goto IL_5A2;
					case 14:
						devClass2 = base._devClass;
						num = (short)835584030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						bool flag;
						if (flag)
						{
							num = (short)1083047940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7B7;
					}
					case 16:
						goto IL_236;
					case 17:
						num = (short)382795799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						string value;
						rndisradioProfile.ParentDeviceInstanceID = value;
						string text;
						rndisradioProfile.PhysicalLocation = global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.GetPhysicalLocationFromDeviceInstance(text);
						rndisradioProfile.UniqueLocation = rndisradioProfile.PhysicalLocation;
						this.a(ref rndisradioProfile);
						result = true;
						num = (short)1025048584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						if (zero != global::System.IntPtr.Zero)
						{
							num = (short)1914306580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D8;
					case 20:
						base.NativeAPISet.WrapperSetupDiDestroyDeviceInfoList(zero);
						num = (short)757727253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_5D8;
					case 22:
						num = (short)815005701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						string text;
						if (base.NativeAPISet.WrapperSetupDiGetDeviceInstanceId(zero, sp_DEVINFO_DATA, ref text, 1024))
						{
							num = (short)2002518038;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30C;
					}
					case 24:
						base._devClass = base._radioClass;
						num = (short)1259077646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						rndisradioProfile.InstanceId = sp_DEVINFO_DATA.DevInst;
						string value = "";
						num = (short)686424064;
						short num7 = num;
						num = (short)4259840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						return false;
					case 27:
						goto IL_618;
					case 28:
					{
						global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVICE_INTERFACE_DATA sp_DEVICE_INTERFACE_DATA;
						if (!base.NativeAPISet.WrapperSetupDiEnumDeviceInterfaces(zero, (uint)num3, ref sp_DEVICE_INTERFACE_DATA, ref devClass))
						{
							num = (short)866189314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						base._devClass = devClass;
						int num5 = 0;
						uint num4 = 0U;
						num = (short)2080112651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
					{
						if (rndisradioProfile == null)
						{
							num = (short)817102879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						bool flag = true;
						zero = global::System.IntPtr.Zero;
						sp_DEVINFO_DATA = default(global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVINFO_DATA);
						global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVICE_INTERFACE_DATA sp_DEVICE_INTERFACE_DATA = default(global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVICE_INTERFACE_DATA);
						string text2 = "";
						string text = "";
						orgPnPMsg.sDeviceName = orgPnPMsg.sDeviceName.ToUpperInvariant();
						rndisradioProfile.DeviceName = orgPnPMsg.sDeviceName;
						string text3 = orgPnPMsg.sDeviceName;
						int num8 = text3.IndexOf(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ݐᩒᅔࡖ", a_), global::System.StringComparison.OrdinalIgnoreCase);
						rndisradioProfile.VID = text3.Substring(num8 + 4, 4);
						num8 = text3.IndexOf(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("Őᩒᅔࡖ", a_), global::System.StringComparison.OrdinalIgnoreCase);
						rndisradioProfile.PID = text3.Substring(num8 + 4, 4);
						num = (short)365821953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						if (!base.NativeAPISet.WrapperSetupDiGetClassDevs(ref zero, ref devClass2, global::System.IntPtr.Zero))
						{
							num = (short)458293260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D8;
					case 31:
						return false;
					case 32:
						if (orgPnPMsg.sDeviceName.Contains(base._radioClass.ToString().ToUpperInvariant()))
						{
							num = (short)1421803544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_BC;
					IL_236:
					num = (short)1078263836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30C:
					num3++;
					num = (short)858783753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_330:
					base._devClass = devClass;
					num = (short)1801846794;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A2:
					if (base.NativeAPISet.Wrapper_CM_Get_Parent(sp_DEVINFO_DATA.DevInst, ref devID))
					{
						num = (short)1021181977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_330;
					IL_5D8:
					base._devClass = devClass2;
					num = (short)464125955;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_618:
					num = (short)1058734095;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_350:
				IL_7B7:
				base.NativeAPISet.WrapperSetupDiDestroyDeviceInfoList(zero);
				return result;
				IL_BC:
				rndisradioProfile = (radioInfo as global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile);
				num = (short)395247645;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000157D0 File Offset: 0x000139D0
		public override bool DeviceChanged(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg pnpMsg)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile rndisradioProfile;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)2091007503;
					short num3 = num2;
					num2 = (short)56245775;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_64;
					default:
					{
						num2 = (short)967835649;
						if (num2 != 0)
						{
						}
						num2 = (short)1409155072;
						if (num2 != 0)
						{
						}
						num2 = (short)1370095616;
						short num4 = num2;
						if (rndisradioProfile == null)
						{
							num2 = (short)197656577;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_138;
					}
					}
					break;
				}
				case 1:
					return false;
				case 2:
					if (pnpMsg.isSimulated)
					{
						num2 = (short)1280311299;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_138;
				case 3:
					goto IL_64;
				}
				goto IL_20;
				IL_64:
				num2 = (short)31653888;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_138:
			return base.DeviceChanged(pnpMsg);
			IL_20:
			rndisradioProfile = (pnpMsg.radioProfile as global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile);
			num2 = (short)198705154;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0001591C File Offset: 0x00013B1C
		private bool a(ref global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile A_0)
		{
			int a_ = 11;
			short num = (short)1090584576;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1354825729;
				if (num != 0)
				{
				}
				num = (short)2081488896;
				short num3 = num;
				bool flag = false;
				bool flag2 = true;
				global::System.IntPtr zero = global::System.IntPtr.Zero;
				global::System.IntPtr zero2 = global::System.IntPtr.Zero;
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVINFO_DATA sp_DEVINFO_DATA = default(global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVINFO_DATA);
				global::System.Guid guid = new global::System.Guid(global::Motorola.Common.Communication.DeviceDiscovery.RNDISDetector.a);
				try
				{
					switch (0)
					{
					case 0:
						goto IL_103;
					}
					global::System.IntPtr enumerator;
					for (;;)
					{
						IL_A4:
						int num4;
						switch (num2)
						{
						case 0:
							goto IL_1BC;
						case 1:
							goto IL_23D;
						case 2:
							if (!flag)
							{
								num = (short)868483083;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_43A;
						case 3:
							num = (short)1396703236;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							string text;
							if (!(A_0.DeviceInstanceID != text))
							{
								num = (short)181927954;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_306;
						}
						case 5:
							flag2 = false;
							num = (short)979763200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							string text;
							if (base.NativeAPISet.Wrapper_CM_Get_Device_ID(sp_DEVINFO_DATA.DevInst, ref text))
							{
								num = (short)956891139;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_43A;
						}
						case 7:
							goto IL_306;
						case 8:
							base.NativeAPISet.WrapperRegCloseKey(zero2);
							zero2 = global::System.IntPtr.Zero;
							num = (short)445186064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							string empty;
							if (!base.NativeAPISet.WrapperRegQueryValueEx(zero2, this.c, ref empty))
							{
								num = (short)780533768;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							A_0.NetCfgInstanceId = empty;
							base.NativeAPISet.WrapperRegCloseKey(zero2);
							zero2 = global::System.IntPtr.Zero;
							flag = true;
							num = (short)1073414151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							if (!base.NativeAPISet.WrapperSetupDiEnumDeviceInfo(zero, (uint)num4, ref sp_DEVINFO_DATA))
							{
								num = (short)2089025551;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)325713922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
						{
							string text = "";
							num = (short)1832648710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							if (flag2)
							{
								num = (short)1673986065;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_43A;
						case 13:
							if (base.NativeAPISet.WrapperSetupDiOpenDevRegKey(zero, ref sp_DEVINFO_DATA, ref zero2, 2, 1))
							{
								num = (short)1590034453;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_306;
						case 14:
							goto IL_23D;
						case 15:
							goto IL_43A;
						case 16:
							goto IL_306;
						case 17:
							num4 = 0;
							num = (short)1810104321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							num = (short)1339359245;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							goto IL_452;
						case 20:
							if (!base.NativeAPISet.WrapperSetupDiGetClassDevs(ref zero, ref guid, enumerator))
							{
								num = (short)972619781;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1BC;
						case 21:
						{
							string empty = string.Empty;
							num = (short)1946091529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_103;
						IL_1BC:
						sp_DEVINFO_DATA.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVINFO_DATA));
						num = (short)675807244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_23D:
						num = (short)1182793738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_306:
						num4++;
						num = (short)1679163406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_43A:
						num = (short)1843920915;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_452:
					return true;
					IL_103:
					enumerator = global::System.Runtime.InteropServices.Marshal.StringToHGlobalUni(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ὉὋ్", a_));
					num = (short)1826619412;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_A4;
				}
				catch (global::System.Exception ex)
				{
					string str = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ཉ㑋ⵍ㕏≑⁓㽕㝗㑙籛㝝๟䉡㙣⡥Ⱨ⍩㽫⩭ᕯٱᅳᕵ౷ᕹ๻䑽멿얁\uda87ﾏ\udb91쒓\udf95ﲙ춟쎡킣쾥잧쒩隫躭", a_);
					global::System.Exception ex2 = ex;
					global::System.Diagnostics.Trace.WriteLine(str + ((ex2 != null) ? ex2.ToString() : null));
				}
				finally
				{
					num = (short)1345519617;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_551;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_4BB;
							}
							continue;
						case 2:
							for (;;)
							{
								num = (short)56467682;
								short num5 = num;
								num = (short)901423330;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_517;
								}
							}
							IL_517:
							num = (short)1875509248;
							if (num != 0)
							{
							}
							base.NativeAPISet.WrapperSetupDiDestroyDeviceInfoList(zero);
							num = (short)1414135808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_4BB:
						if (!(zero != global::System.IntPtr.Zero))
						{
							break;
						}
						num = (short)2108489730;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_551:;
				}
				return true;
			}
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00015EB4 File Offset: 0x000140B4
		public static bool RetreiveDeviceIPAddress(ref global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			bool result;
			global::Motorola.Common.Communication.DeviceDiscovery.f f;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					return result;
				case 2:
					if (f != null)
					{
						num2 = (short)374276099;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("᥊͌୎ᡐR畔ፖ㱘ⵚ㑜㱞Ѡ䍢ቤ٦ᩨ䭪ͬnհ卲⁴❶啸孺੼Ṿꖊꎌꆎ", a_), global::System.Array.Empty<object>());
					global::System.Threading.Thread.Sleep(1000);
					num2 = (short)1071579136;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)1385813497;
					short num3 = num2;
					num2 = (short)446748153;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1073938433;
						if (num2 != 0)
						{
						}
						num2 = (short)278593536;
						if (num2 != 0)
						{
						}
						profile.PortName = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("獊経罎捐", a_);
						profile.DeviceDescription = f.a;
						profile.MacAddress = f.b;
						profile.IPAddress = f.c;
						result = true;
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("๊㕌㭎⍐㉒㙔⍖祘ग़፜᭞⡠ぢ䕤ͦ౨ᵪѬ౮ᑰ卲㱴❶奸㩺᥼᭾ꦈ놊권ꆐ떔펖\uda9e쾠슢잤쮦첨쾪邬풮肰캲", a_), new object[]
						{
							profile.IPAddress,
							f.d.ToString()
						});
						num2 = (short)113704961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_29;
			}
			return result;
			IL_29:
			result = false;
			f = global::Motorola.Common.Communication.DeviceDiscovery.RNDISDetector.b(profile.NetCfgInstanceId);
			num2 = (short)1001914368;
			short num4 = num2;
			num2 = (short)510984194;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00016098 File Offset: 0x00014298
		private static global::Motorola.Common.Communication.DeviceDiscovery.f b(string NetCfgInstanceId)
		{
			int a_ = 3;
			short num = (short)998572032;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_98;
				}
				global::System.Net.NetworkInformation.GatewayIPAddressInformationCollection gatewayAddresses;
				global::System.Net.NetworkInformation.IPAddressCollection dhcpServerAddresses;
				int num3;
				global::System.Net.NetworkInformation.NetworkInterface[] allNetworkInterfaces;
				global::System.Net.NetworkInformation.NetworkInterface networkInterface;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						global::System.Net.NetworkInformation.IPv4InterfaceProperties ipv4Properties;
						if (ipv4Properties.IsDhcpEnabled)
						{
							num = (short)1488191502;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Net.NetworkInformation.IPInterfaceProperties ipproperties;
						gatewayAddresses = ipproperties.GatewayAddresses;
						num = (short)1940979732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (gatewayAddresses[0].Address.ToString() != global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("牁橃癅晇穉手繍", a_))
						{
							num = (short)1902116871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_162;
					case 2:
						if (dhcpServerAddresses[0].ToString() != global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("牁橃癅晇穉手繍", a_))
						{
							num = (short)2101280776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11C;
					case 3:
						if (num3 >= allNetworkInterfaces.Length)
						{
							num = (short)217579537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						networkInterface = allNetworkInterfaces[num3];
						num = (short)1587216394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1210253325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (dhcpServerAddresses.Count > 0)
						{
							num = (short)2108620804;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11C;
					case 6:
						if (networkInterface.Supports(global::System.Net.NetworkInformation.NetworkInterfaceComponent.IPv4))
						{
							num = (short)1559560211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_306;
					case 7:
						goto IL_117;
					case 8:
						goto IL_4E4;
					case 9:
						goto IL_25D;
					case 10:
						if (networkInterface.Id == NetCfgInstanceId)
						{
							num = (short)196935695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_306;
					case 11:
						num = (short)300220434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1737883649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (dhcpServerAddresses[0].ToString() != global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("灁煃獅晇硉祋筍繏恑慓捕癗桙楛歝", a_))
						{
							num = (short)928186384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11C;
					case 14:
					{
						global::System.Net.NetworkInformation.IPInterfaceProperties ipproperties;
						dhcpServerAddresses = ipproperties.DhcpServerAddresses;
						num = (short)1067515909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						num = (short)577044481;
						if (num != 0)
						{
						}
						global::System.Net.NetworkInformation.IPInterfaceProperties ipproperties = networkInterface.GetIPProperties();
						num = (short)614006784;
						short num4 = num;
						num = (short)685244422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						num = (short)1796079618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_297;
					case 18:
						if (gatewayAddresses[0].Address.ToString() != global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("灁煃獅晇硉祋筍繏恑慓捕癗桙楛歝", a_))
						{
							num = (short)88932364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_162;
					case 19:
					{
						global::System.Net.NetworkInformation.IPInterfaceProperties ipproperties;
						global::System.Net.NetworkInformation.IPv4InterfaceProperties ipv4Properties = ipproperties.GetIPv4Properties();
						num = (short)764084247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (gatewayAddresses.Count > 0)
						{
							num = (short)1497235467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_162;
					case 21:
						num = (short)1824391168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_25D;
					case 23:
					{
						global::System.Net.NetworkInformation.IPv4InterfaceProperties ipv4Properties;
						if (ipv4Properties != null)
						{
							num = (short)2075459605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_306;
					}
					}
					goto IL_98;
					IL_25D:
					num = (short)449183747;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_306:
					num = (short)1084203844;
					short num5 = num;
					num = (short)97428292;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_25D;
					default:
						num = (short)189792256;
						if (num != 0)
						{
						}
						num3++;
						num = (short)1566179337;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_117:
				return new global::Motorola.Common.Communication.DeviceDiscovery.f(networkInterface.Name, networkInterface.GetPhysicalAddress().ToString(), gatewayAddresses[0].Address.ToString(), false);
				IL_11C:
				return null;
				IL_162:
				return null;
				IL_297:
				return null;
				IL_4E4:
				return new global::Motorola.Common.Communication.DeviceDiscovery.f(networkInterface.Name, networkInterface.GetPhysicalAddress().ToString(), dhcpServerAddresses[0].ToString(), true);
				IL_98:
				allNetworkInterfaces = global::System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();
				num3 = 0;
				num = (short)1547042838;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000165DC File Offset: 0x000147DC
		[global::System.Security.Permissions.RegistryPermission(global::System.Security.Permissions.SecurityAction.Assert, Read = "HKEY_LOCAL_MACHINESYSTEMCurrentControlSetservicesTcpipParametersInterface")]
		private static global::Motorola.Common.Communication.DeviceDiscovery.f a(string id)
		{
			int a_ = 18;
			short num = (short)358481920;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)554631169;
				if (num != 0)
				{
				}
				num = (short)1582563328;
				short num3 = num;
				global::Microsoft.Win32.RegistryKey registryKey = null;
				global::Motorola.Common.Communication.DeviceDiscovery.f result = null;
				string text = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ɐ੒͖ٔ᱘ᙚŜᱞᑠᅢᝤɦݨὪ⹬nὰݲݴᡶᕸ⡺᡼୾\udd80ﾈ쾒솔쎞슢힤욦쒨캪\ud9ac쪮쎰삲ﺶힸ쾺\ud8bc춾Ꟁꋂꛄꋆ뫈韊", a_) + id;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_EC;
					}
					for (;;)
					{
						IL_9D:
						switch (num2)
						{
						case 0:
						{
							string text2;
							if (text2 != global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("捐晒恔祖歘湚桜煞占噢偤䥦孨幪塬", a_))
							{
								num = (short)205455368;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_581;
						}
						case 1:
						{
							string a_2;
							try
							{
								try
								{
									switch (0)
									{
									case 0:
										goto IL_221;
									}
									global::Microsoft.Win32.RegistryKey registryKey2;
									for (;;)
									{
										IL_20A:
										switch (num2)
										{
										case 0:
											goto IL_2BA;
										case 1:
											if (registryKey2 != null)
											{
												num = (short)102105091;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_2BA;
										case 2:
											goto IL_2D2;
										case 3:
											a_2 = (string)registryKey2.GetValue(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ὐ㉒㡔㉖", a_));
											num = (short)1254948864;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_221;
										IL_2BA:
										num = (short)1577582594;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_2D2:
									goto IL_305;
									IL_221:
									string text3 = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ɐ੒͖ٔ᱘ᙚŜᱞᑠᅢᝤɦݨὪ⹬nὰݲݴᡶᕸ⡺᡼୾\udd80삂ﶈ力춐\udd92ﶠ\ud8a2醤骨鶪隮蚰膲颴誸覺袼銾蛄苆觊诌賎ﻒ鷞ꓠ틢헤퓦\ud8e8폪郬돮", a_) + id + global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("൐ၒ㩔㥖㝘㹚㹜⭞ࡠౢ୤", a_);
									registryKey2 = global::Microsoft.Win32.Registry.LocalMachine.OpenSubKey(text3);
									num = (short)363200513;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_20A;
								}
								catch (global::System.Exception ex)
								{
									string text3;
									global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("Ṑ⍒ご㥖祘ग़㡜㡞ࡠၢᅤᕦၨ䭪♬੮ࡰ卲㍴ᙶၸ᝺᡼᭾뮀ꎂﺄ랆꞊권ꂐ", a_), new object[]
									{
										text3,
										ex.Message
									});
								}
								IL_305:
								goto IL_183;
							}
							finally
							{
								num = (short)931987458;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::Microsoft.Win32.RegistryKey registryKey2;
									switch (num2)
									{
									case 0:
									{
										num = (short)550168995;
										short num4 = num;
										num = (short)830663075;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_344;
										default:
											num = (short)1018822656;
											if (num != 0)
											{
											}
											registryKey2.Close();
											num = (short)61014017;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
										goto IL_3C3;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_33D;
										}
										continue;
									}
									goto IL_33D;
									IL_344:
									num = (short)1672151040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_33D:
									if (registryKey2 != null)
									{
										goto IL_344;
									}
									break;
								}
								IL_3C3:;
							}
							goto IL_3C6;
							IL_183:
							string text4;
							result = new global::Motorola.Common.Communication.DeviceDiscovery.f(a_2, string.Empty, text4, true);
							num = (short)1673592842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							string a_2 = "";
							string text3 = "";
							global::Microsoft.Win32.RegistryKey registryKey2 = null;
							num = (short)707592193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							string text2;
							if (text2 != null)
							{
								num = (short)2105147399;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_581;
						}
						case 4:
						{
							string text2;
							if (text2 != global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("慐絒敔祖楘畚浜", a_))
							{
								num = (short)147324930;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_581;
						}
						case 5:
						{
							string text4;
							if (text4 != null)
							{
								num = (short)1691418635;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_581;
						}
						case 6:
						{
							string text4;
							if (text4 != global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("慐絒敔祖楘畚浜", a_))
							{
								num = (short)328466446;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_581;
						}
						case 7:
							num = (short)420020224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							num = (short)1558249476;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							goto IL_599;
						case 10:
							goto IL_581;
						case 11:
							num = (short)543490065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							num = (short)54001670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							string text2 = (string)registryKey.GetValue(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᕐ㭒㙔❖ၘ୚ᱜ㭞ՠᅢdᑦᩨ", a_));
							string text4 = (string)registryKey.GetValue(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᕐ㭒㙔❖੘㹚⽜⥞Ѡᅢ", a_));
							num = (short)832372741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							num = (short)1258029059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							if (registryKey != null)
							{
								num = (short)2095251469;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3C6;
						case 16:
							goto IL_581;
						case 17:
						{
							string text4;
							if (text4 != global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("捐晒恔祖歘湚桜煞占噢偤䥦孨幪塬", a_))
							{
								num = (short)48431116;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_581;
						}
						}
						goto IL_EC;
						IL_3C6:
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("Ṑ⍒ご㥖祘ग़㡜㡞ࡠၢᅤᕦၨ䭪♬੮ࡰ卲㍴ᙶၸ᝺᡼᭾뮀ꎂﺄ랆", a_), new object[]
						{
							text
						});
						num = (short)769785872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_581:
						num = (short)2110783497;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_599:
					return result;
					IL_EC:
					registryKey = global::Microsoft.Win32.Registry.LocalMachine.OpenSubKey(text);
					num = (short)276299791;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_9D;
				}
				catch (global::System.Exception ex2)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("Ṑ⍒ご㥖祘ग़㡜㡞ࡠၢᅤᕦၨ䭪♬੮ࡰ卲㍴ᙶၸ᝺᡼᭾뮀ꎂﺄ랆꞊권ꂐ", a_), new object[]
					{
						text,
						ex2.Message
					});
				}
				finally
				{
					num = (short)1315176450;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							registryKey.Close();
							num = (short)1778712577;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_638;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_600;
							}
							continue;
						}
						IL_600:
						if (registryKey == null)
						{
							break;
						}
						num = (short)1730740224;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_638:;
				}
				return result;
			}
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00016C8C File Offset: 0x00014E8C
		// Note: this type is marked as 'beforefieldinit'.
		static RNDISDetector()
		{
			int a_ = 12;
			short num = (short)109195438;
			short num2 = num;
			num = (short)554971310;
			switch (num2 == num)
			{
			}
			num = (short)555286529;
			if (num != 0)
			{
			}
			num = (short)304545792;
			short num3 = num;
			num = (short)400752640;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.DeviceDiscovery.RNDISDetector.a = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("罊ौ籎材ᙒ汔恖歘癚ᡜ汞占噢䡤噦塨⡪⡬䉮㍰㕲㙴䙶呸䭺䕼佾놀놂임슆뢈뮊뺌뺎ꦐ", a_);
			global::Motorola.Common.Communication.DeviceDiscovery.RNDISDetector.b = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("੊ौ筎桐歒汔捖浘癚橜楞占╢䡤噦塨⽪嵬䉮䥰㝲㙴㕶呸䭺䵼㱾놀랂쎄쒆몈뢊뢌랎튐", a_);
		}

		// Token: 0x040000AA RID: 170
		private static readonly string a;

		// Token: 0x040000AB RID: 171
		private new static readonly string b;

		// Token: 0x040000AC RID: 172
		private string c;

		// Token: 0x040000AD RID: 173
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler d;

		// Token: 0x040000AE RID: 174
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler e;
	}
}
