using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.CommunicationManager.DeviceFactory.AmpRadioFactory;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000027 RID: 39
	public abstract class WiFiDeviceFactory : global::Motorola.Common.Communication.DeviceFactoryBase
	{
		// Token: 0x06000089 RID: 137
		protected abstract global::Motorola.Common.Communication.IMotoDevice CreateRadio(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile profile, global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo);

		// Token: 0x0600008A RID: 138 RVA: 0x0000BC04 File Offset: 0x00009E04
		protected WiFiDeviceFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer, global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManagerClass, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory communicationPipeFactory, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory sequenceManagerFactory) : base(communicationManagerClass, communicationPipeFactory, sequenceManagerFactory)
		{
			this._observer = observer;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000BC24 File Offset: 0x00009E24
		protected override bool CreateRadio(out global::Motorola.Common.Communication.IMotoDevice radio, global::Motorola.Common.Communication.IRadioProfile hwProfile)
		{
			int a_ = 12;
			short num = (short)1208221696;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_97;
				}
				bool result;
				global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile ldtradioProfile;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_3CD;
					case 1:
						goto IL_D7;
					case 2:
					{
						global::Motorola.Common.Communication.IMotoDevice device;
						if (device != null)
						{
							num = (short)508755983;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DC;
					}
					case 3:
						num = (short)202899463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (radio != null)
						{
							num = (short)2089943049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 5:
					{
						if (ldtradioProfile == null)
						{
							num = (short)911343617;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = ((global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass)this.CommunicationManager).FindDeviceWithSameIpAddressInCache(ldtradioProfile);
						num = (short)1281032211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_DC;
					case 7:
					{
						num = (short)1615399890;
						short num3 = num;
						num = (short)789973970;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)2092695552;
							if (num != 0)
							{
							}
							if (this.CommunicationManager.ContainWiFiDevice(ldtradioProfile.RadioIdString))
							{
								num = (short)434765832;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3F8;
						}
						break;
					}
					case 8:
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("⡠ൢ٤ࡦѨɪͬ࡮兰Ųᑴ፶ၸᑺ嵼Ṿ권ﺐﮔ릘뾞햠쮢삤螦춨캪\udbac욮튰횲閴풶\ud8b8\ud8ba햼\udabeꃂ꫄ꯆꗈ껊껌믎룐볒믔淪律鋚돜볞軠転賤触軨쯪뿬軮闰髲髴ퟶ냸꯺볼鯾攀焂怄理稈ㄊ", a_) + ldtradioProfile.IPAddress + global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("婠䍢Ɽ०੨Ѫlٮὰᑲ啴╶ᡸὺᑼၾꆀ톂쒌쮎ꮐ뎒", a_) + ldtradioProfile.RadioIdString, global::System.Array.Empty<object>());
						global::Motorola.Common.Communication.IMotoDevice device = this.CommunicationManager.GetDevice(ldtradioProfile.RadioIdString);
						num = (short)203948034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)1502412820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_DC;
					case 11:
						goto IL_122;
					case 12:
						goto IL_2F4;
					case 13:
						radio.Prefetch();
						num = (short)1797062674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						global::Motorola.Common.Communication.IMotoDevice device;
						this.CommunicationManager.Notify(device);
						num = (short)493223946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						num = (short)569049104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						global::Motorola.Common.Communication.IMotoDevice device;
						if (device.DeviceInfo.ConnectionInfo.UniqueAddress == ldtradioProfile.IPAddress)
						{
							num = (short)213581838;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						device.DeviceInfo.ConnectionInfo.UniqueAddress = ldtradioProfile.IPAddress;
						this.CommunicationManager.ReDetectDevice(ldtradioProfile.RadioIdString);
						num = (short)1583874054;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_47E;
					case 18:
						goto IL_28A;
					case 19:
					{
						string text;
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1901854742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47E;
					}
					case 20:
					{
						num = (short)1134690304;
						short num4 = num;
						if (this.CommunicationManager.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Active)
						{
							num = (short)647430157;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28A;
					}
					case 21:
					{
						string item;
						if (global::Motorola.Common.Communication.CommunicationManager.DeviceFactory.AmpRadioFactory.AmpApRadioFactory.ApPIDs.Contains(item))
						{
							num = (short)886374400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("㍠ɢŤ๦٨䭪ᩬٮհ᭲啴Ѷᡸᙺ᡼彾좀펂쒄力ﲎ뎒뮚列잠얢삤햦첨얪\ud9ac辮튲톴\udeb6횸鮺﮾ꗂ꫄닆ꟈ꿊ꛎ뿐뛔룖뗘럚룜볞闠諢諤触쟨쯪뿬諮鳰鳲菴黶韸鳺\uddfc雾甀ⴂ┄丆夈䨊椌欎挐瘒昔搖⌘", a_) + ldtradioProfile.IPAddress + global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("婠䍢㝤٦൨ɪɬ♮㕰䥲啴", a_) + ldtradioProfile.RadioIdString, global::System.Array.Empty<object>());
						string text;
						this.CommunicationManager.RemoveDevice(text);
						num = (short)769392657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						string text;
						string item = text.Substring(0, 4);
						num = (short)448004117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						if (ldtradioProfile.DeviceInstanceID != null)
						{
							num = (short)767164419;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F8;
					}
					goto IL_97;
					IL_DC:
					radio = null;
					result = false;
					num = (short)1935147009;
					if (num != 0)
					{
					}
					num = (short)325976075;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28A:
					radio.DeviceInfo.RadioID = hwProfile.RadioIdString;
					result = true;
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("⁠ݢŤɦ൨䭪Ὤ๮ᕰᩲᩴ坶൸ᑺ嵼᱾ﾊﾐ붒떔\ude96즘\uda9a列ﮞ펠욢횤풦鎨", a_) + ldtradioProfile.IPAddress + global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("婠䍢㝤٦൨ɪɬ♮㕰䥲啴", a_) + ldtradioProfile.RadioIdString, global::System.Array.Empty<object>());
					num = (short)1689649164;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F8:
					global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo
					{
						ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter,
						UniqueAddress = ldtradioProfile.IPAddress,
						DeviceInstance = ldtradioProfile.DeviceInstanceID,
						Location = ldtradioProfile.PortName,
						IsTlsPskCompatible = ldtradioProfile.TlsPsk
					};
					radio = this.CreateRadio(ldtradioProfile, connectionInfo);
					num = (short)511442948;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47E:
					num = (short)760610839;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D7:
				radio = null;
				return false;
				IL_122:
				IL_2F4:
				return result;
				IL_3CD:
				radio = null;
				return true;
				IL_97:
				result = true;
				ldtradioProfile = (hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile);
				num = (short)2042691589;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600008C RID: 140
		public abstract string PAC_Name { get; }

		// Token: 0x04000026 RID: 38
		protected global::Motorola.Common.Communication.CommonUtil.IObserver _observer;
	}
}
