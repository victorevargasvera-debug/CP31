using System;
using System.Diagnostics;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.IshHandler;

namespace Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP
{
	// Token: 0x0200003F RID: 63
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Raw, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program | global::Motorola.Common.Communication.CommonUtil.RadioOperation.CBIProgram)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Raw, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program | global::Motorola.Common.Communication.CommonUtil.RadioOperation.CBIProgram)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create)]
	public class AmpCpsSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000151 RID: 337 RVA: 0x0001AA60 File Offset: 0x00018C60
		public global::Motorola.Common.Communication.ISequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			int a_ = 5;
			short num = (short)965214208;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo ampDeviceInfo;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						global::ProcessorType processorType;
						if (processorType != global::ProcessorType.BP)
						{
							num = (short)1172570113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2075721731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_123;
					case 2:
					{
						num = (short)1518665728;
						short num3 = num;
						num = (short)1987182600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_193;
					case 4:
						num = (short)876478466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						if (ampDeviceInfo == null)
						{
							num = (short)327221255;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::ProcessorType processorType = ampDeviceInfo.ProcessorType;
						num = (short)1299841024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_2CC;
					case 7:
						goto IL_98;
					case 8:
					{
						string format = global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ř❛湝ᵟ㽡㽣ᵥ奧ᝩㅫ㕭୯䁱ॳ⭵⍷Ź佻ͽ\udd7f\ud981잃춏즑ꊕ잙잛閟\udfa1念蚥얩\ud9ab슭풯銱\udab3\ud9b5첷骹\udfbb첽ꖿꏁ냃ꏅ막꧋뿍ꗏ럑뫓뗕뷗龎뇛뿝軟菡菣菥髧쫩諫臭苯틱髳駵賷\udaf9迻诽烿爁欃琅簇漉栋⸍怏怑笓甕紗椙漛焝刟ȡ倣弥堧伩ᘫอ䬯б䤳ᠵ", a_);
						object[] array = new object[7];
						int num4 = 0;
						global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType;
						if (ampDeviceInfo == null)
						{
							connectionType = null;
						}
						else
						{
							global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo = ampDeviceInfo.ConnectionInfo;
							connectionType = ((connectionInfo != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo.ConnectionType) : null);
						}
						array[num4] = connectionType;
						array[1] = ((ampDeviceInfo != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(ampDeviceInfo.Family) : null);
						array[2] = ((ampDeviceInfo != null) ? ampDeviceInfo.SerialNumber : null);
						array[3] = ((ampDeviceInfo != null) ? ampDeviceInfo.ModelNumber : null);
						array[4] = ((ampDeviceInfo != null) ? ampDeviceInfo.SoftwareVersion : null);
						array[5] = ((ampDeviceInfo != null) ? ampDeviceInfo.CodeplugVersion : null);
						array[6] = ((ampDeviceInfo != null) ? new global::ProcessorType?(ampDeviceInfo.ProcessorType) : null);
						global::System.Diagnostics.Trace.TraceError(string.Format(format, array));
						num = (short)147062785;
						if (num != 0)
						{
						}
						num = (short)793051146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::ProcessorType processorType;
						if (processorType != global::ProcessorType.AP)
						{
							num = (short)279445508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)799985814;
						short num5 = num;
						num = (short)1452396694;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_123;
						default:
							num = (short)899219456;
							if (num != 0)
							{
							}
							num = (short)1368260614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						goto IL_52E;
					}
					goto IL_63;
					IL_123:
					num = (short)334757897;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_98:
				global::System.Diagnostics.Trace.TraceError(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ᥙ㍛⭝౟١䑣ࡥݧṩ䱫൭ᅯűs噵౷ቹ᥻幽낏蓮鍊힝캟쒡쮣蚥\udca7얩貫\uddaf슱펵캷펹\udfbb\udbbd覿곁ꋃ꧅ꗉ뻋듏럑ꋓ뿕믗뿙闛냝蛟跡쓣釥觧駩쳫胭藯黱飳\ud8f5", a_), new object[]
				{
					global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("㹙㥛⡝य़šţ⽥٧౩ͫ", a_)
				});
				throw new global::System.ArgumentException(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ᥙ㍛⭝౟١䑣ࡥݧṩ䱫൭ᅯűs噵౷ቹ᥻幽낏蓮鍊힝캟쒡쮣蚥\udca7얩貫\uddaf슱펵캷펹\udfbb\udbbd覿곁ꋃ꧅ꗉ뻋듏럑ꋓ뿕믗뿙闛냝蛟跡쓣釥觧駩쳫胭藯黱飳\ud8f5", a_), global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("㹙㥛⡝य़šţ⽥٧౩ͫ", a_));
				IL_193:
				string format2 = global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ř❛湝ᵟ㽡㽣ᵥ奧ᝩㅫ㕭୯䁱ॳ⭵⍷Ź佻ͽ\udd7f\ud981잃춏즑ꊕ잙잛閟\udfa1念蚥\ud8a9즫쾭쒯\udbb1\udab3통颷즹\ud9bb쾽떿ꟁ꫃ꗅ귇ꇋ꿍뻏돑돓돕꫗龎뫛뇝鋟싡胣菥黧菩迫语탯藱鷳苵郷\udaf9뻻껽⃿企欃戅洇", a_);
				object[] array2 = new object[6];
				int num6 = 0;
				global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType2;
				if (ampDeviceInfo == null)
				{
					connectionType2 = null;
				}
				else
				{
					global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo2 = ampDeviceInfo.ConnectionInfo;
					connectionType2 = ((connectionInfo2 != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo2.ConnectionType) : null);
				}
				array2[num6] = connectionType2;
				array2[1] = ((ampDeviceInfo != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(ampDeviceInfo.Family) : null);
				array2[2] = ((ampDeviceInfo != null) ? ampDeviceInfo.SerialNumber : null);
				array2[3] = ((ampDeviceInfo != null) ? ampDeviceInfo.ModelNumber : null);
				array2[4] = ((ampDeviceInfo != null) ? ampDeviceInfo.SoftwareVersion : null);
				array2[5] = ((ampDeviceInfo != null) ? ampDeviceInfo.CodeplugVersion : null);
				global::System.Diagnostics.Trace.TraceInformation(string.Format(format2, array2));
				return new global::Motorola.Common.Communication.AmpBpSequenceManager(new global::Motorola.Common.Communication.IshHandler.RcmpMessageExecutor(communicationPipe));
				IL_2CC:
				string format3 = global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ř❛湝ᵟ㽡㽣ᵥ奧ᝩㅫ㕭୯䁱ॳ⭵⍷Ź佻ͽ\udd7f\ud981잃춏즑ꊕ잙잛閟\udfa1念蚥\ud8a9즫쾭쒯\udbb1\udab3통颷즹\ud9bb쾽떿ꟁ꫃ꗅ귇ꇋ꿍뻏돑돓돕꫗龎뫛뇝鋟싡胣菥黧菩迫语탯藱鷳苵郷\udaf9뷻껽⃿企欃戅洇", a_);
				object[] array3 = new object[6];
				int num7 = 0;
				global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType3;
				if (ampDeviceInfo == null)
				{
					connectionType3 = null;
				}
				else
				{
					global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo3 = ampDeviceInfo.ConnectionInfo;
					connectionType3 = ((connectionInfo3 != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo3.ConnectionType) : null);
				}
				array3[num7] = connectionType3;
				array3[1] = ((ampDeviceInfo != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(ampDeviceInfo.Family) : null);
				array3[2] = ((ampDeviceInfo != null) ? ampDeviceInfo.SerialNumber : null);
				array3[3] = ((ampDeviceInfo != null) ? ampDeviceInfo.ModelNumber : null);
				array3[4] = ((ampDeviceInfo != null) ? ampDeviceInfo.SoftwareVersion : null);
				array3[5] = ((ampDeviceInfo != null) ? ampDeviceInfo.CodeplugVersion : null);
				global::System.Diagnostics.Trace.TraceInformation(string.Format(format3, array3));
				return new global::Motorola.Common.Communication.AmpApSequenceManager(new global::Motorola.Common.Communication.AmpHttpMessageExecutor(communicationPipe, deviceInfo.ConnectionInfo.Location, deviceInfo.ConnectionInfo.UniqueAddress), new global::Motorola.Common.Communication.AmpCpsPackageFilePathProvider());
				IL_52E:
				string format4 = global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ř❛湝ᵟ㽡㽣ᵥ奧ᝩㅫ㕭୯䁱ॳ⭵塷㑹፻੽ꁿﺋ揄뒓ﾛﮝ펟톡쮣풥袧\udea9햫\udead햯袱钳춵讷잹銻", a_);
				object[] array4 = new object[4];
				int num8 = 0;
				global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType4;
				if (ampDeviceInfo == null)
				{
					connectionType4 = null;
				}
				else
				{
					global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo4 = ampDeviceInfo.ConnectionInfo;
					connectionType4 = ((connectionInfo4 != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo4.ConnectionType) : null);
				}
				array4[num8] = connectionType4;
				array4[1] = ((ampDeviceInfo != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(ampDeviceInfo.Family) : null);
				array4[2] = ((ampDeviceInfo != null) ? ampDeviceInfo.SerialNumber : null);
				array4[3] = ((ampDeviceInfo != null) ? new global::ProcessorType?(ampDeviceInfo.ProcessorType) : null);
				throw new global::System.NotSupportedException(string.Format(format4, array4));
				IL_63:
				ampDeviceInfo = (deviceInfo as global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo);
				num = (short)1545076741;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}
	}
}
