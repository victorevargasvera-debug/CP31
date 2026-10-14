using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x02000578 RID: 1400
	[global::System.Serializable]
	public class Advanced : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600BF6D RID: 49005 RVA: 0x00B0B8B8 File Offset: 0x00B09AB8
		public Advanced(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600BF6E RID: 49006 RVA: 0x00B0B8D4 File Offset: 0x00B09AD4
		protected Advanced(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600BF6F RID: 49007 RVA: 0x00B0B8EC File Offset: 0x00B09AEC
		public override void Init()
		{
			int a_ = 8;
			short num = (short)1015349248;
			short num2 = num;
			num = (short)1507459073;
			if (num != 0)
			{
			}
			num = (short)197586091;
			short num3 = num;
			num = (short)1310452907;
			switch (num3 == num)
			{
			}
			num = (short)1157627904;
			if (num != 0)
			{
			}
			this.cnvPerAdvancedAdvancedRFAGC_A7408 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ铔돖꿘뫚돜볞蓠蟢ꓤ菦鿨諪菬賮铰韲ꟴ뇶룸볺뻼ꃾ䀀㐂㄄㜆ㄈ", a_), global::CommonResources.AcgResources.ID_ADVANCEDRFAGC, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerAdvancedAdvancedRFAGC_A7408LovStrs);
			this.cnvPerAdvancedAdvancedRFAGC_A7408.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerAdvancedAdvancedRFAGC_A7408.DataTransferOrder = 60;
			this.cnvPerAdvancedAnalogFlatAudio_A7443 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ铔돖꿘뫚돜볞蓠蟢ꓤ触裨蟪苬裮런鿲铴菶룸軺駼雾渀専䐄〆㴈㼊㸌", a_), global::CommonResources.AcgResources.ID_ANALOGFLATAUDIO);
			this.cnvPerAdvancedAnalogFlatAudio_A7443.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerAdvancedAnalogFlatAudio_A7443.DataTransferOrder = 2;
			this.cnvPerAdvancedAnalogWidebandData_A1994 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ铔돖꿘뫚돜볞蓠蟢ꓤ触裨蟪苬裮꛰髲釴鋶鯸髺鏼鯾䔀戂焄昆嘈䨊㰌㘎⠐✒", a_), global::CommonResources.AcgResources.ID_ANALOGWIDEBANDDATA);
			this.cnvPerAdvancedAnalogWidebandData_A1994.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerAdvancedAnalogWidebandData_A1994.DataTransferOrder = 6;
			this.cnvPerAdvancedDisableHighPassFilter_A7864 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ铔돖꿘뫚돜볞蓠蟢ꇤ軦髨諪迬菮铰믲鳴郶釸꯺鳼賾爀䔂氄欆紈渊缌倎倐␒ⴔ№ⴘ", a_), global::CommonResources.AcgResources.ID_DISABLEHIGHPASSFILTER);
			this.cnvPerAdvancedDisableHighPassFilter_A7864.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerAdvancedDisableHighPassFilter_A7864.DataTransferOrder = 72;
			this.cnvPerAdvancedSecondLOSideInjection_A9063 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ铔돖꿘뫚돜볞蓠蟢뛤苦諨蓪菬诮뷰볲꛴黶鷸黺듼釾欀昂昄猆怈搊挌倎倐⨒└№⨘", a_), global::CommonResources.AcgResources.ID_SECONDLOSIDEINJECTION);
			this.cnvPerAdvancedSecondLOSideInjection_A9063.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvPerAdvancedSecondLOSideInjection_A9063.DataTransferOrder = 63;
			this.cnvPerAdvanceBroadbandProtection = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ铔돖꿘뫚돜볞蓠ꇢ韤裦裨迪迬軮鿰韲ꗴ藶雸迺飼鳾甀樂樄椆", a_), global::CommonResources.AcgResources.ID_CONVENTIONALPERSONALITYBROADBANDPROTECTION);
			this.cnvPerAdvanceBroadbandProtection.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerAdvanceBroadbandProtection.DataTransferOrder = 74;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裈꿊믌껎뿐냒냔돖", a_);
			base.Id = 10140;
			base.UIName = global::CommonResources.AcgResources.ID_ADVANCED;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600BF70 RID: 49008 RVA: 0x00B0BB28 File Offset: 0x00B09D28
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 19;
			short num = (short)1163067402;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꇟ蛡鋣蟥蛧觩觫諭듯鯱蟳韵髷雹駻뛽槿攁氃嘅椇礉缋䠍礏縑怓猕樗䔙崛⤝᠟ᐡဣ", a_)))
					{
						num = (short)2125266963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A9;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꇟ蛡鋣蟥蛧觩觫諭뇯鳱闳髵韷鷹꯻韽擿朁昃朅昇渉䠋漍搏猑䬓圕⤗⌙┛⨝", a_)))
					{
						num = (short)2136473620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_44C;
				case 2:
					goto IL_35E;
				case 3:
					goto IL_3AB;
				case 4:
					goto IL_359;
				case 5:
					if (producerFields != null)
					{
						num = (short)1834876949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_551;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꇟ蛡鋣蟥蛧觩觫諭ꏯ韱音駵雷黹냻뇽叿欁怃挅䄇搉昋欍猏昑紓礕瘗䔙崛✝ဟᐡᜣ", a_)))
					{
						num = (short)1094189071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A4;
				case 7:
					this.cnvPerAdvancedAnalogFlatAudio_A7443 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꇟ蛡鋣蟥蛧觩觫諭뇯鳱闳髵韷鷹뫻鋽懿瘁䔃猅氇按挋儍儏┑–∕⬗", a_), global::CommonResources.AcgResources.ID_ANALOGFLATAUDIO);
					this.cnvPerAdvancedAnalogFlatAudio_A7443.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerAdvancedAnalogFlatAudio_A7443.DataTransferOrder = 2;
					num = (short)131858434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_A9;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꇟ蛡鋣蟥蛧觩觫곭苯鷱闳鋵髷鯹鋻髽僿瀁欃爅洇椉砋服缏簑", a_)))
					{
						num = (short)1831731217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_551;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_86;
					}
					continue;
				case 11:
					goto IL_44C;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꇟ蛡鋣蟥蛧觩觫諭뇯雱苳韵雷駹駻髽勿䐁䔃䄅䬇唉䴋㤍␏∑Ⱃ", a_)))
					{
						num = (short)1467482125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3AB;
				case 13:
					this.cnvPerAdvancedAdvancedRFAGC_A7408 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꇟ蛡鋣蟥蛧觩觫諭뇯雱苳韵雷駹駻髽勿䐁䔃䄅䬇唉䴋㤍␏∑Ⱃ", a_), global::CommonResources.AcgResources.ID_ADVANCEDRFAGC, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerAdvancedAdvancedRFAGC_A7408LovStrs);
					this.cnvPerAdvancedAdvancedRFAGC_A7408.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerAdvancedAdvancedRFAGC_A7408.DataTransferOrder = 60;
					num = (short)1156775939;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)374472709;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					this.cnvPerAdvancedSecondLOSideInjection_A9063 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꇟ蛡鋣蟥蛧觩觫諭ꏯ韱音駵雷黹냻뇽叿欁怃挅䄇搉昋欍猏昑紓礕瘗䔙崛✝ဟᐡᜣ", a_), global::CommonResources.AcgResources.ID_SECONDLOSIDEINJECTION);
					this.cnvPerAdvancedSecondLOSideInjection_A9063.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvPerAdvancedSecondLOSideInjection_A9063.DataTransferOrder = 63;
					num = (short)1877016592;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_1A4;
				case 17:
					goto IL_1ED;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꇟ蛡鋣蟥蛧觩觫諭뇯鳱闳髵韷鷹뫻鋽懿瘁䔃猅氇按挋儍儏┑–∕⬗", a_)))
					{
						num = (short)1075773447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_35E;
				case 19:
				{
					num = (short)1673986048;
					short num3 = num;
					this.cnvPerAdvancedDisableHighPassFilter_A7864 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꇟ蛡鋣蟥蛧觩觫諭듯鯱蟳韵髷雹駻뛽槿攁氃嘅椇礉缋䠍礏縑怓猕樗䔙崛⤝᠟ᐡဣ", a_), global::CommonResources.AcgResources.ID_DISABLEHIGHPASSFILTER);
					this.cnvPerAdvancedDisableHighPassFilter_A7864.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerAdvancedDisableHighPassFilter_A7864.DataTransferOrder = 72;
					num = (short)137579885;
					short num4 = num;
					num = (short)1703693677;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1ED;
					default:
						num = (short)1202847745;
						if (num != 0)
						{
						}
						num = (short)737804288;
						if (num != 0)
						{
						}
						num = (short)1629880328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 20:
					this.cnvPerAdvancedAnalogWidebandData_A1994 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꇟ蛡鋣蟥蛧觩觫諭뇯鳱闳髵韷鷹꯻韽擿朁昃朅昇渉䠋漍搏猑䬓圕⤗⌙┛⨝", a_), global::CommonResources.AcgResources.ID_ANALOGWIDEBANDDATA);
					this.cnvPerAdvancedAnalogWidebandData_A1994.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerAdvancedAnalogWidebandData_A1994.DataTransferOrder = 6;
					num = (short)1637613579;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					num = (short)301072396;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_86:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)108527630;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A9:
				num = (short)546635782;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A4:
				num = (short)1150353417;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1ED:
				this.cnvPerAdvanceBroadbandProtection = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꇟ蛡鋣蟥蛧觩觫곭苯鷱闳鋵髷鯹鋻髽僿瀁欃爅洇椉砋服缏簑", a_), global::CommonResources.AcgResources.ID_CONVENTIONALPERSONALITYBROADBANDPROTECTION);
				this.cnvPerAdvanceBroadbandProtection.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
				this.cnvPerAdvanceBroadbandProtection.DataTransferOrder = 74;
				num = (short)1137311748;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_35E:
				num = (short)1274871809;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3AB:
				num = (short)1710358546;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_44C:
				num = (short)1123483648;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_359:
			IL_551:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闓닕껗믙닛뷝藟蛡", a_);
			base.Id = 10140;
			base.UIName = global::CommonResources.AcgResources.ID_ADVANCED;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600BF71 RID: 49009 RVA: 0x00B0C0B8 File Offset: 0x00B0A2B8
		public override void PopulateReferences()
		{
			short num = (short)1354667372;
			short num2 = num;
			num = (short)1916769644;
			switch (num2 == num)
			{
			}
			num = (short)1867251713;
			if (num != 0)
			{
			}
			num = (short)2116812800;
			if (num != 0)
			{
			}
			num = (short)255459328;
			short num3 = num;
		}

		// Token: 0x0600BF72 RID: 49010 RVA: 0x00B0C164 File Offset: 0x00B0A364
		public override void DropReferences()
		{
			short num = (short)600179788;
			short num2 = num;
			num = (short)1491731532;
			switch (num2 == num)
			{
			}
			num = (short)1225654273;
			if (num != 0)
			{
			}
			num = (short)510984192;
			if (num != 0)
			{
			}
			num = (short)294977536;
			short num3 = num;
		}

		// Token: 0x0600BF73 RID: 49011 RVA: 0x00B0C20C File Offset: 0x00B0A40C
		public override void SetConstraints()
		{
			short num = (short)1611357662;
			short num2 = num;
			num = (short)2038717918;
			switch (num2 == num)
			{
			}
			num = (short)1806827521;
			if (num != 0)
			{
			}
			num = (short)482607104;
			if (num != 0)
			{
			}
			num = (short)228130816;
			short num3 = num;
			this.cnvPerAdvancedAnalogFlatAudio_A7443.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConDVRSIsEnAndAnalogFlatAudioApp);
			this.cnvPerAdvancedAnalogFlatAudio_A7443.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConDVRSIsEnAndAnalogFlatAudioValid);
			this.cnvPerAdvancedAnalogFlatAudio_A7443.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConAnalogFlatIsDisabledOrAnalogwideIsDisabled);
			this.cnvPerAdvancedDisableHighPassFilter_A7864.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConAnalogFlatAudioIsEnabled);
			this.cnvPerAdvancedAnalogWidebandData_A1994.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConAnalogWidebandDataIsEnable);
			this.cnvPerAdvancedAnalogWidebandData_A1994.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConAdvancedAnalogWidebandDataApplicable);
			this.cnvPerAdvancedAdvancedRFAGC_A7408.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConAdvancedRFAGCSmartOptionValid);
			this.cnvPerAdvanceBroadbandProtection.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConAdvancedSmartRFAGCOptionApplicable);
			this.cnvPerAdvanceBroadbandProtection.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConAdvancedBroadbandProtectionValid);
		}

		// Token: 0x0600BF74 RID: 49012 RVA: 0x00B0C384 File Offset: 0x00B0A584
		public override void SetupDependencies()
		{
			short num = (short)440547084;
			short num2 = num;
			num = (short)779564812;
			switch (num2 == num)
			{
			}
			num = (short)97255425;
			if (num != 0)
			{
			}
			num = (short)1821966336;
			if (num != 0)
			{
			}
			num = (short)1484652544;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
			conventionalPersonality.Secure.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerAdvancedAnalogWidebandData_A1994);
			conventionalPersonality.Secure.RefRadioWide.Bluetooth.RadWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.cnvPerAdvancedAnalogWidebandData_A1994);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.cnvPerAdvancedAnalogFlatAudio_A7443);
			this.cnvPerAdvancedAnalogFlatAudio_A7443.AddDependentObject(this.cnvPerAdvancedDisableHighPassFilter_A7864);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.cnvPerAdvancedAnalogWidebandData_A1994);
			this.cnvPerAdvancedAnalogWidebandData_A1994.AddDependentObject(this.cnvPerAdvancedDisableHighPassFilter_A7864);
			this.cnvPerAdvancedAnalogWidebandData_A1994.AddDependentObject(conventionalPersonality.Secure.RefSecureWide.General.SecWideGeneralSecureOperation_A9067);
		}

		// Token: 0x17006022 RID: 24610
		// (get) Token: 0x0600BF75 RID: 49013 RVA: 0x00B0C4F8 File Offset: 0x00B0A6F8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1187618794;
				short num2 = num;
				num = (short)1728028650;
				switch (num2 == num)
				{
				}
				num = (short)1248460801;
				if (num != 0)
				{
				}
				num = (short)151846912;
				if (num != 0)
				{
				}
				num = (short)1953300480;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17006023 RID: 24611
		// (get) Token: 0x0600BF76 RID: 49014 RVA: 0x00B0C5A8 File Offset: 0x00B0A7A8
		// (set) Token: 0x0600BF77 RID: 49015 RVA: 0x00B0C65C File Offset: 0x00B0A85C
		public int CnvPerAdvancedAdvancedRFAGC_A7408Value
		{
			get
			{
				short num = (short)1226781247;
				short num2 = num;
				num = (short)2011181631;
				switch (num2 == num)
				{
				}
				num = (short)507379713;
				if (num != 0)
				{
				}
				num = (short)1149042688;
				if (num != 0)
				{
				}
				num = (short)464257024;
				short num3 = num;
				return this.cnvPerAdvancedAdvancedRFAGC_A7408.Value;
			}
			set
			{
				short num = (short)141975389;
				short num2 = num;
				num = (short)1865310045;
				switch (num2 == num)
				{
				}
				num = (short)628031489;
				if (num != 0)
				{
				}
				num = (short)1781792768;
				if (num != 0)
				{
				}
				num = (short)1598816256;
				short num3 = num;
				this.cnvPerAdvancedAdvancedRFAGC_A7408.Value = value;
			}
		}

		// Token: 0x17006024 RID: 24612
		// (get) Token: 0x0600BF78 RID: 49016 RVA: 0x00B0C714 File Offset: 0x00B0A914
		// (set) Token: 0x0600BF79 RID: 49017 RVA: 0x00B0C7C8 File Offset: 0x00B0A9C8
		public string CnvPerAdvancedAdvancedRFAGC_A7408_UIValue
		{
			get
			{
				short num = (short)363798138;
				short num2 = num;
				num = (short)1512644218;
				switch (num2 == num)
				{
				}
				num = (short)2017918977;
				if (num != 0)
				{
				}
				num = (short)1589903360;
				if (num != 0)
				{
				}
				num = (short)193003520;
				short num3 = num;
				return this.cnvPerAdvancedAdvancedRFAGC_A7408.UIValue;
			}
			set
			{
				short num = (short)890697924;
				short num2 = num;
				num = (short)1296955588;
				switch (num2 == num)
				{
				}
				num = (short)919863297;
				if (num != 0)
				{
				}
				num = (short)1727725568;
				if (num != 0)
				{
				}
				num = (short)1219887104;
				short num3 = num;
				this.cnvPerAdvancedAdvancedRFAGC_A7408.UIValue = value;
			}
		}

		// Token: 0x17006025 RID: 24613
		// (get) Token: 0x0600BF7A RID: 49018 RVA: 0x00B0C880 File Offset: 0x00B0AA80
		public global::AcpBusinessLayer.AcpListField CnvPerAdvancedAdvancedRFAGC_A7408
		{
			get
			{
				short num = (short)1935191147;
				short num2 = num;
				num = (short)1847110763;
				switch (num2 == num)
				{
				}
				num = (short)557318144;
				if (num != 0)
				{
				}
				num = (short)1009254401;
				if (num != 0)
				{
				}
				num = (short)1898971136;
				short num3 = num;
				return this.cnvPerAdvancedAdvancedRFAGC_A7408;
			}
		}

		// Token: 0x17006026 RID: 24614
		// (get) Token: 0x0600BF7B RID: 49019 RVA: 0x00B0C930 File Offset: 0x00B0AB30
		// (set) Token: 0x0600BF7C RID: 49020 RVA: 0x00B0C9E8 File Offset: 0x00B0ABE8
		public bool CnvPerAdvancedAdvancedRFAGC_A7408_Applicable
		{
			get
			{
				short num = (short)935925623;
				short num2 = num;
				num = (short)1515460471;
				switch (num2 == num)
				{
				}
				num = (short)123142145;
				if (num != 0)
				{
				}
				num = (short)82903040;
				if (num != 0)
				{
				}
				num = (short)904134656;
				short num3 = num;
				return this.cnvPerAdvancedAdvancedRFAGC_A7408.Applicable;
			}
			set
			{
				short num = (short)593231873;
				if (num != 0)
				{
				}
				num = (short)1980423906;
				short num2 = num;
				num = (short)1026481890;
				switch (num2 == num)
				{
				}
				num = (short)890044416;
				if (num != 0)
				{
				}
				num = (short)1102118912;
				short num3 = num;
				this.cnvPerAdvancedAdvancedRFAGC_A7408.Applicable = value;
			}
		}

		// Token: 0x17006027 RID: 24615
		// (get) Token: 0x0600BF7D RID: 49021 RVA: 0x00B0CA9C File Offset: 0x00B0AC9C
		// (set) Token: 0x0600BF7E RID: 49022 RVA: 0x00B0CB50 File Offset: 0x00B0AD50
		public bool CnvPerAdvancedAdvancedRFAGC_A7408_Valid
		{
			get
			{
				short num = (short)1218666148;
				short num2 = num;
				num = (short)1224171172;
				switch (num2 == num)
				{
				}
				num = (short)1754005505;
				if (num != 0)
				{
				}
				num = (short)1272578048;
				if (num != 0)
				{
				}
				num = (short)1436090368;
				short num3 = num;
				return this.cnvPerAdvancedAdvancedRFAGC_A7408.Valid;
			}
			set
			{
				short num = (short)1363607553;
				if (num != 0)
				{
				}
				num = (short)247790313;
				short num2 = num;
				num = (short)1780021993;
				switch (num2 == num)
				{
				}
				num = (short)502792192;
				if (num != 0)
				{
				}
				num = (short)579207168;
				short num3 = num;
				this.cnvPerAdvancedAdvancedRFAGC_A7408.Valid = value;
			}
		}

		// Token: 0x17006028 RID: 24616
		// (get) Token: 0x0600BF7F RID: 49023 RVA: 0x00B0CC08 File Offset: 0x00B0AE08
		// (set) Token: 0x0600BF80 RID: 49024 RVA: 0x00B0CCC0 File Offset: 0x00B0AEC0
		public bool CnvPerAdvancedAdvancedRFAGC_A7408_Visible
		{
			get
			{
				short num = (short)651823093;
				short num2 = num;
				num = (short)1696729077;
				switch (num2 == num)
				{
				}
				num = (short)1637482497;
				if (num != 0)
				{
				}
				num = (short)876609536;
				if (num != 0)
				{
				}
				num = (short)1143013376;
				short num3 = num;
				return this.cnvPerAdvancedAdvancedRFAGC_A7408.Visible;
			}
			set
			{
				short num = (short)112682240;
				short num2 = num;
				num = (short)1087399168;
				switch (num2 == num)
				{
				}
				num = (short)77070337;
				if (num != 0)
				{
				}
				num = (short)852426752;
				if (num != 0)
				{
				}
				num = (short)531300352;
				short num3 = num;
				this.cnvPerAdvancedAdvancedRFAGC_A7408.Visible = value;
			}
		}

		// Token: 0x17006029 RID: 24617
		// (get) Token: 0x0600BF81 RID: 49025 RVA: 0x00B0CD78 File Offset: 0x00B0AF78
		// (set) Token: 0x0600BF82 RID: 49026 RVA: 0x00B0CE2C File Offset: 0x00B0B02C
		public bool CnvPerAdvancedAdvancedRFAGC_A7408_Editable
		{
			get
			{
				short num = (short)1053273651;
				short num2 = num;
				num = (short)1040559667;
				switch (num2 == num)
				{
				}
				num = (short)669450241;
				if (num != 0)
				{
				}
				num = (short)1673658368;
				if (num != 0)
				{
				}
				num = (short)449708032;
				short num3 = num;
				return this.cnvPerAdvancedAdvancedRFAGC_A7408.Editable;
			}
			set
			{
				short num = (short)1600028195;
				short num2 = num;
				num = (short)1516600867;
				switch (num2 == num)
				{
				}
				num = (short)1420689409;
				if (num != 0)
				{
				}
				num = (short)939458560;
				if (num != 0)
				{
				}
				num = (short)636157952;
				short num3 = num;
				this.cnvPerAdvancedAdvancedRFAGC_A7408.Editable = value;
			}
		}

		// Token: 0x1700602A RID: 24618
		// (get) Token: 0x0600BF83 RID: 49027 RVA: 0x00B0CEE0 File Offset: 0x00B0B0E0
		internal string CnvPerAdvancedAdvancedRFAGC_A7408_UILabel
		{
			get
			{
				short num = (short)1269563393;
				if (num != 0)
				{
				}
				num = (short)1293157071;
				short num2 = num;
				num = (short)101974735;
				switch (num2 == num)
				{
				}
				num = (short)1291649024;
				if (num != 0)
				{
				}
				num = (short)1449852928;
				short num3 = num;
				return this.cnvPerAdvancedAdvancedRFAGC_A7408.UIName;
			}
		}

		// Token: 0x1700602B RID: 24619
		// (get) Token: 0x0600BF84 RID: 49028 RVA: 0x00B0CF98 File Offset: 0x00B0B198
		// (set) Token: 0x0600BF85 RID: 49029 RVA: 0x00B0D04C File Offset: 0x00B0B24C
		internal bool CnvPerAdvancedAdvancedRFAGC_A7408_HiddenStatic
		{
			get
			{
				short num = (short)984969750;
				short num2 = num;
				num = (short)569602582;
				switch (num2 == num)
				{
				}
				num = (short)830930945;
				if (num != 0)
				{
				}
				num = (short)1657864192;
				if (num != 0)
				{
				}
				num = (short)471400448;
				short num3 = num;
				return this.cnvPerAdvancedAdvancedRFAGC_A7408.HiddenStatic;
			}
			set
			{
				short num = (short)1707255543;
				short num2 = num;
				num = (short)1375381239;
				switch (num2 == num)
				{
				}
				num = (short)747175936;
				if (num != 0)
				{
				}
				num = (short)1528496129;
				if (num != 0)
				{
				}
				num = (short)854589440;
				short num3 = num;
				this.cnvPerAdvancedAdvancedRFAGC_A7408.HiddenStatic = value;
			}
		}

		// Token: 0x1700602C RID: 24620
		// (get) Token: 0x0600BF86 RID: 49030 RVA: 0x00B0D100 File Offset: 0x00B0B300
		// (set) Token: 0x0600BF87 RID: 49031 RVA: 0x00B0D1B8 File Offset: 0x00B0B3B8
		internal bool CnvPerAdvancedAdvancedRFAGC_A7408_HiddenDynamic
		{
			get
			{
				short num = (short)401694523;
				short num2 = num;
				num = (short)1541562171;
				switch (num2 == num)
				{
				}
				num = (short)1578762240;
				if (num != 0)
				{
				}
				num = (short)1931280385;
				if (num != 0)
				{
				}
				num = (short)828964864;
				short num3 = num;
				return this.cnvPerAdvancedAdvancedRFAGC_A7408.HiddenDynamic;
			}
			set
			{
				short num = (short)1044066109;
				short num2 = num;
				num = (short)1439706941;
				switch (num2 == num)
				{
				}
				num = (short)1425539073;
				if (num != 0)
				{
				}
				num = (short)1535377408;
				if (num != 0)
				{
				}
				num = (short)1211957248;
				short num3 = num;
				this.cnvPerAdvancedAdvancedRFAGC_A7408.HiddenDynamic = value;
			}
		}

		// Token: 0x1700602D RID: 24621
		// (get) Token: 0x0600BF88 RID: 49032 RVA: 0x00B0D26C File Offset: 0x00B0B46C
		public bool CnvPerAdvancedAdvancedRFAGC_A7408_HasDiffs
		{
			get
			{
				short num = (short)42644987;
				short num2 = num;
				num = (short)71742971;
				switch (num2 == num)
				{
				}
				num = (short)1615200257;
				if (num != 0)
				{
				}
				num = (short)108527616;
				if (num != 0)
				{
				}
				num = (short)816840704;
				short num3 = num;
				return this.cnvPerAdvancedAdvancedRFAGC_A7408._HasDiffs;
			}
		}

		// Token: 0x1700602E RID: 24622
		// (get) Token: 0x0600BF89 RID: 49033 RVA: 0x00B0D320 File Offset: 0x00B0B520
		// (set) Token: 0x0600BF8A RID: 49034 RVA: 0x00B0D3D8 File Offset: 0x00B0B5D8
		public bool CnvPerAdvancedAnalogFlatAudio_A7443Value
		{
			get
			{
				short num = (short)1479671809;
				if (num != 0)
				{
				}
				num = (short)850053638;
				short num2 = num;
				num = (short)2110179846;
				switch (num2 == num)
				{
				}
				num = (short)1365442560;
				if (num != 0)
				{
				}
				num = (short)1970274304;
				short num3 = num;
				return this.cnvPerAdvancedAnalogFlatAudio_A7443.Value;
			}
			set
			{
				short num = (short)1514143745;
				if (num != 0)
				{
				}
				num = (short)239603132;
				short num2 = num;
				num = (short)711200188;
				switch (num2 == num)
				{
				}
				num = (short)1109065728;
				if (num != 0)
				{
				}
				num = (short)1344012288;
				short num3 = num;
				this.cnvPerAdvancedAnalogFlatAudio_A7443.Value = value;
			}
		}

		// Token: 0x1700602F RID: 24623
		// (get) Token: 0x0600BF8B RID: 49035 RVA: 0x00B0D48C File Offset: 0x00B0B68C
		public global::AcpBusinessLayer.AcpField<bool> CnvPerAdvancedAnalogFlatAudio_A7443
		{
			get
			{
				short num = (short)771022186;
				short num2 = num;
				num = (short)1876155754;
				switch (num2 == num)
				{
				}
				num = (short)1779040257;
				if (num != 0)
				{
				}
				num = (short)1248067584;
				if (num != 0)
				{
				}
				num = (short)1568538624;
				short num3 = num;
				return this.cnvPerAdvancedAnalogFlatAudio_A7443;
			}
		}

		// Token: 0x17006030 RID: 24624
		// (get) Token: 0x0600BF8C RID: 49036 RVA: 0x00B0D53C File Offset: 0x00B0B73C
		// (set) Token: 0x0600BF8D RID: 49037 RVA: 0x00B0D5F0 File Offset: 0x00B0B7F0
		public bool CnvPerAdvancedAnalogFlatAudio_A7443_UIValue
		{
			get
			{
				short num = (short)923123636;
				short num2 = num;
				num = (short)2129510324;
				switch (num2 == num)
				{
				}
				num = (short)1119223809;
				if (num != 0)
				{
				}
				num = (short)1881866240;
				if (num != 0)
				{
				}
				num = (short)733478912;
				short num3 = num;
				return this.cnvPerAdvancedAnalogFlatAudio_A7443.Value;
			}
			set
			{
				short num = (short)1710843890;
				short num2 = num;
				num = (short)498821106;
				switch (num2 == num)
				{
				}
				num = (short)166658048;
				if (num != 0)
				{
				}
				num = (short)168099841;
				if (num != 0)
				{
				}
				num = (short)2011496448;
				short num3 = num;
				this.cnvPerAdvancedAnalogFlatAudio_A7443.Value = value;
			}
		}

		// Token: 0x17006031 RID: 24625
		// (get) Token: 0x0600BF8E RID: 49038 RVA: 0x00B0D6A8 File Offset: 0x00B0B8A8
		// (set) Token: 0x0600BF8F RID: 49039 RVA: 0x00B0D75C File Offset: 0x00B0B95C
		public bool CnvPerAdvancedAnalogFlatAudio_A7443_Applicable
		{
			get
			{
				short num = (short)782324292;
				short num2 = num;
				num = (short)275993156;
				switch (num2 == num)
				{
				}
				num = (short)1590231040;
				if (num != 0)
				{
				}
				num = (short)140312577;
				if (num != 0)
				{
				}
				num = (short)1413087232;
				short num3 = num;
				return this.cnvPerAdvancedAnalogFlatAudio_A7443.Applicable;
			}
			set
			{
				short num = (short)2021071538;
				short num2 = num;
				num = (short)928389810;
				switch (num2 == num)
				{
				}
				num = (short)680984576;
				if (num != 0)
				{
				}
				num = (short)570753025;
				if (num != 0)
				{
				}
				num = (short)1693253632;
				short num3 = num;
				this.cnvPerAdvancedAnalogFlatAudio_A7443.Applicable = value;
			}
		}

		// Token: 0x17006032 RID: 24626
		// (get) Token: 0x0600BF90 RID: 49040 RVA: 0x00B0D810 File Offset: 0x00B0BA10
		// (set) Token: 0x0600BF91 RID: 49041 RVA: 0x00B0D8C4 File Offset: 0x00B0BAC4
		public bool CnvPerAdvancedAnalogFlatAudio_A7443_Valid
		{
			get
			{
				short num = (short)53150017;
				short num2 = num;
				num = (short)1949761857;
				switch (num2 == num)
				{
				}
				num = (short)1372454913;
				if (num != 0)
				{
				}
				num = (short)649199616;
				if (num != 0)
				{
				}
				num = (short)1870987264;
				short num3 = num;
				return this.cnvPerAdvancedAnalogFlatAudio_A7443.Valid;
			}
			set
			{
				short num = (short)974804274;
				short num2 = num;
				num = (short)2072925490;
				switch (num2 == num)
				{
				}
				num = (short)924516353;
				if (num != 0)
				{
				}
				num = (short)1110769664;
				if (num != 0)
				{
				}
				num = (short)1043791872;
				short num3 = num;
				this.cnvPerAdvancedAnalogFlatAudio_A7443.Valid = value;
			}
		}

		// Token: 0x17006033 RID: 24627
		// (get) Token: 0x0600BF92 RID: 49042 RVA: 0x00B0D97C File Offset: 0x00B0BB7C
		// (set) Token: 0x0600BF93 RID: 49043 RVA: 0x00B0DA30 File Offset: 0x00B0BC30
		public bool CnvPerAdvancedAnalogFlatAudio_A7443_Visible
		{
			get
			{
				short num = (short)919839921;
				short num2 = num;
				num = (short)1397400753;
				switch (num2 == num)
				{
				}
				num = (short)1671430145;
				if (num != 0)
				{
				}
				num = (short)589889536;
				if (num != 0)
				{
				}
				num = (short)1123680256;
				short num3 = num;
				return this.cnvPerAdvancedAnalogFlatAudio_A7443.Visible;
			}
			set
			{
				short num = (short)59198580;
				short num2 = num;
				num = (short)91573364;
				switch (num2 == num)
				{
				}
				num = (short)1779630081;
				if (num != 0)
				{
				}
				num = (short)2129395712;
				if (num != 0)
				{
				}
				num = (short)1071316992;
				short num3 = num;
				this.cnvPerAdvancedAnalogFlatAudio_A7443.Visible = value;
			}
		}

		// Token: 0x17006034 RID: 24628
		// (get) Token: 0x0600BF94 RID: 49044 RVA: 0x00B0DAE4 File Offset: 0x00B0BCE4
		// (set) Token: 0x0600BF95 RID: 49045 RVA: 0x00B0DB98 File Offset: 0x00B0BD98
		public bool CnvPerAdvancedAnalogFlatAudio_A7443_Editable
		{
			get
			{
				short num = (short)1473041310;
				short num2 = num;
				num = (short)271831966;
				switch (num2 == num)
				{
				}
				num = (short)1069875200;
				if (num != 0)
				{
				}
				num = (short)1881800705;
				if (num != 0)
				{
				}
				num = (short)1140981760;
				short num3 = num;
				return this.cnvPerAdvancedAnalogFlatAudio_A7443.Editable;
			}
			set
			{
				short num = (short)677234322;
				short num2 = num;
				num = (short)1695663762;
				switch (num2 == num)
				{
				}
				num = (short)1833500672;
				if (num != 0)
				{
				}
				num = (short)1106771969;
				if (num != 0)
				{
				}
				num = (short)535494656;
				short num3 = num;
				this.cnvPerAdvancedAnalogFlatAudio_A7443.Editable = value;
			}
		}

		// Token: 0x17006035 RID: 24629
		// (get) Token: 0x0600BF96 RID: 49046 RVA: 0x00B0DC4C File Offset: 0x00B0BE4C
		internal string CnvPerAdvancedAnalogFlatAudio_A7443_UILabel
		{
			get
			{
				short num = (short)1511026598;
				short num2 = num;
				num = (short)176648102;
				switch (num2 == num)
				{
				}
				num = (short)1322254337;
				if (num != 0)
				{
				}
				num = (short)1656291328;
				if (num != 0)
				{
				}
				num = (short)1291059200;
				short num3 = num;
				return this.cnvPerAdvancedAnalogFlatAudio_A7443.UIName;
			}
		}

		// Token: 0x17006036 RID: 24630
		// (get) Token: 0x0600BF97 RID: 49047 RVA: 0x00B0DD04 File Offset: 0x00B0BF04
		// (set) Token: 0x0600BF98 RID: 49048 RVA: 0x00B0DDB8 File Offset: 0x00B0BFB8
		internal bool CnvPerAdvancedAnalogFlatAudio_A7443_HiddenStatic
		{
			get
			{
				short num = (short)1733296129;
				if (num != 0)
				{
				}
				num = (short)1278493963;
				short num2 = num;
				num = (short)1612334347;
				switch (num2 == num)
				{
				}
				num = (short)2033778688;
				if (num != 0)
				{
				}
				num = (short)1720451072;
				short num3 = num;
				return this.cnvPerAdvancedAnalogFlatAudio_A7443.HiddenStatic;
			}
			set
			{
				short num = (short)97628558;
				short num2 = num;
				num = (short)387363214;
				switch (num2 == num)
				{
				}
				num = (short)297402368;
				if (num != 0)
				{
				}
				num = (short)2024341505;
				if (num != 0)
				{
				}
				num = (short)1395326976;
				short num3 = num;
				this.cnvPerAdvancedAnalogFlatAudio_A7443.HiddenStatic = value;
			}
		}

		// Token: 0x17006037 RID: 24631
		// (get) Token: 0x0600BF99 RID: 49049 RVA: 0x00B0DE6C File Offset: 0x00B0C06C
		// (set) Token: 0x0600BF9A RID: 49050 RVA: 0x00B0DF20 File Offset: 0x00B0C120
		internal bool CnvPerAdvancedAnalogFlatAudio_A7443_HiddenDynamic
		{
			get
			{
				short num = (short)1070475367;
				short num2 = num;
				num = (short)1237330023;
				switch (num2 == num)
				{
				}
				num = (short)425721857;
				if (num != 0)
				{
				}
				num = (short)537395200;
				if (num != 0)
				{
				}
				num = (short)1897398272;
				short num3 = num;
				return this.cnvPerAdvancedAnalogFlatAudio_A7443.HiddenDynamic;
			}
			set
			{
				short num = (short)2045934033;
				short num2 = num;
				num = (short)1126398417;
				switch (num2 == num)
				{
				}
				num = (short)239534081;
				if (num != 0)
				{
				}
				num = (short)1517682688;
				if (num != 0)
				{
				}
				num = (short)535166976;
				short num3 = num;
				this.cnvPerAdvancedAnalogFlatAudio_A7443.HiddenDynamic = value;
			}
		}

		// Token: 0x17006038 RID: 24632
		// (get) Token: 0x0600BF9B RID: 49051 RVA: 0x00B0DFD8 File Offset: 0x00B0C1D8
		public bool CnvPerAdvancedAnalogFlatAudio_A7443_HasDiffs
		{
			get
			{
				short num = (short)1387890461;
				short num2 = num;
				num = (short)285706013;
				switch (num2 == num)
				{
				}
				num = (short)1281884161;
				if (num != 0)
				{
				}
				num = (short)393871360;
				if (num != 0)
				{
				}
				num = (short)1900216320;
				short num3 = num;
				return this.cnvPerAdvancedAnalogFlatAudio_A7443._HasDiffs;
			}
		}

		// Token: 0x17006039 RID: 24633
		// (get) Token: 0x0600BF9C RID: 49052 RVA: 0x00B0E08C File Offset: 0x00B0C28C
		// (set) Token: 0x0600BF9D RID: 49053 RVA: 0x00B0E144 File Offset: 0x00B0C344
		public bool CnvPerAdvancedAnalogWidebandData_A1994Value
		{
			get
			{
				short num = (short)1876216644;
				short num2 = num;
				num = (short)1792723780;
				switch (num2 == num)
				{
				}
				num = (short)1788870656;
				if (num != 0)
				{
				}
				num = (short)1906311169;
				if (num != 0)
				{
				}
				num = (short)1637613568;
				short num3 = num;
				return this.cnvPerAdvancedAnalogWidebandData_A1994.Value;
			}
			set
			{
				short num = (short)292432026;
				short num2 = num;
				num = (short)1164126362;
				switch (num2 == num)
				{
				}
				num = (short)750583808;
				if (num != 0)
				{
				}
				num = (short)72089601;
				if (num != 0)
				{
				}
				num = (short)2027683840;
				short num3 = num;
				this.cnvPerAdvancedAnalogWidebandData_A1994.Value = value;
			}
		}

		// Token: 0x1700603A RID: 24634
		// (get) Token: 0x0600BF9E RID: 49054 RVA: 0x00B0E1FC File Offset: 0x00B0C3FC
		public global::AcpBusinessLayer.AcpField<bool> CnvPerAdvancedAnalogWidebandData_A1994
		{
			get
			{
				short num = (short)1415906988;
				short num2 = num;
				num = (short)1507526316;
				switch (num2 == num)
				{
				}
				num = (short)263192577;
				if (num != 0)
				{
				}
				num = (short)1895104512;
				if (num != 0)
				{
				}
				num = (short)188284928;
				short num3 = num;
				return this.cnvPerAdvancedAnalogWidebandData_A1994;
			}
		}

		// Token: 0x1700603B RID: 24635
		// (get) Token: 0x0600BF9F RID: 49055 RVA: 0x00B0E2AC File Offset: 0x00B0C4AC
		// (set) Token: 0x0600BFA0 RID: 49056 RVA: 0x00B0E360 File Offset: 0x00B0C560
		public bool CnvPerAdvancedAnalogWidebandData_A1994_UIValue
		{
			get
			{
				short num = (short)1477443585;
				if (num != 0)
				{
				}
				num = (short)836096753;
				short num2 = num;
				num = (short)1822544625;
				switch (num2 == num)
				{
				}
				num = (short)263389184;
				if (num != 0)
				{
				}
				num = (short)963903488;
				short num3 = num;
				return this.cnvPerAdvancedAnalogWidebandData_A1994.Value;
			}
			set
			{
				short num = (short)630985823;
				short num2 = num;
				num = (short)1221334111;
				switch (num2 == num)
				{
				}
				num = (short)1507262464;
				if (num != 0)
				{
				}
				num = (short)1182269441;
				if (num != 0)
				{
				}
				num = (short)1116340224;
				short num3 = num;
				this.cnvPerAdvancedAnalogWidebandData_A1994.Value = value;
			}
		}

		// Token: 0x1700603C RID: 24636
		// (get) Token: 0x0600BFA1 RID: 49057 RVA: 0x00B0E418 File Offset: 0x00B0C618
		// (set) Token: 0x0600BFA2 RID: 49058 RVA: 0x00B0E4D0 File Offset: 0x00B0C6D0
		public bool CnvPerAdvancedAnalogWidebandData_A1994_Applicable
		{
			get
			{
				short num = (short)1269025804;
				short num2 = num;
				num = (short)168348684;
				switch (num2 == num)
				{
				}
				num = (short)314769408;
				if (num != 0)
				{
				}
				num = (short)1179582465;
				if (num != 0)
				{
				}
				num = (short)759758848;
				short num3 = num;
				return this.cnvPerAdvancedAnalogWidebandData_A1994.Applicable;
			}
			set
			{
				short num = (short)1212291380;
				short num2 = num;
				num = (short)832575796;
				switch (num2 == num)
				{
				}
				num = (short)931201025;
				if (num != 0)
				{
				}
				num = (short)1733558272;
				if (num != 0)
				{
				}
				num = (short)1481637888;
				short num3 = num;
				this.cnvPerAdvancedAnalogWidebandData_A1994.Applicable = value;
			}
		}

		// Token: 0x1700603D RID: 24637
		// (get) Token: 0x0600BFA3 RID: 49059 RVA: 0x00B0E584 File Offset: 0x00B0C784
		// (set) Token: 0x0600BFA4 RID: 49060 RVA: 0x00B0E638 File Offset: 0x00B0C838
		public bool CnvPerAdvancedAnalogWidebandData_A1994_Valid
		{
			get
			{
				short num = (short)513007216;
				short num2 = num;
				num = (short)1532354160;
				switch (num2 == num)
				{
				}
				num = (short)1516044288;
				if (num != 0)
				{
				}
				num = (short)1789722625;
				if (num != 0)
				{
				}
				num = (short)581632000;
				short num3 = num;
				return this.cnvPerAdvancedAnalogWidebandData_A1994.Valid;
			}
			set
			{
				short num = (short)367001601;
				if (num != 0)
				{
				}
				num = (short)373836258;
				short num2 = num;
				num = (short)205670882;
				switch (num2 == num)
				{
				}
				num = (short)1100152832;
				if (num != 0)
				{
				}
				num = (short)1200422912;
				short num3 = num;
				this.cnvPerAdvancedAnalogWidebandData_A1994.Valid = value;
			}
		}

		// Token: 0x1700603E RID: 24638
		// (get) Token: 0x0600BFA5 RID: 49061 RVA: 0x00B0E6EC File Offset: 0x00B0C8EC
		// (set) Token: 0x0600BFA6 RID: 49062 RVA: 0x00B0E79C File Offset: 0x00B0C99C
		public bool CnvPerAdvancedAnalogWidebandData_A1994_Visible
		{
			get
			{
				short num = (short)2134039545;
				short num2 = num;
				num = (short)1966791673;
				switch (num2 == num)
				{
				}
				num = (short)1072693249;
				if (num != 0)
				{
				}
				num = (short)1262551040;
				if (num != 0)
				{
				}
				num = (short)1363410944;
				short num3 = num;
				return this.cnvPerAdvancedAnalogWidebandData_A1994.Visible;
			}
			set
			{
				short num = (short)1924233877;
				short num2 = num;
				num = (short)2138536597;
				switch (num2 == num)
				{
				}
				num = (short)401735681;
				if (num != 0)
				{
				}
				num = (short)603062272;
				short num3 = num;
				num = (short)1720778752;
				if (num != 0)
				{
				}
				this.cnvPerAdvancedAnalogWidebandData_A1994.Visible = value;
			}
		}

		// Token: 0x1700603F RID: 24639
		// (get) Token: 0x0600BFA7 RID: 49063 RVA: 0x00B0E850 File Offset: 0x00B0CA50
		// (set) Token: 0x0600BFA8 RID: 49064 RVA: 0x00B0E900 File Offset: 0x00B0CB00
		public bool CnvPerAdvancedAnalogWidebandData_A1994_Editable
		{
			get
			{
				short num = (short)2010883702;
				short num2 = num;
				num = (short)823895670;
				switch (num2 == num)
				{
				}
				num = (short)1431699457;
				if (num != 0)
				{
				}
				num = (short)357695488;
				short num3 = num;
				num = (short)1764294656;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedAnalogWidebandData_A1994.Editable;
			}
			set
			{
				short num = (short)1490171440;
				short num2 = num;
				num = (short)801781296;
				switch (num2 == num)
				{
				}
				num = (short)1255473153;
				if (num != 0)
				{
				}
				num = (short)1166868480;
				short num3 = num;
				num = (short)284622848;
				if (num != 0)
				{
				}
				this.cnvPerAdvancedAnalogWidebandData_A1994.Editable = value;
			}
		}

		// Token: 0x17006040 RID: 24640
		// (get) Token: 0x0600BFA9 RID: 49065 RVA: 0x00B0E9B4 File Offset: 0x00B0CBB4
		internal string CnvPerAdvancedAnalogWidebandData_A1994_UILabel
		{
			get
			{
				short num = (short)216519950;
				short num2 = num;
				num = (short)643290382;
				switch (num2 == num)
				{
				}
				num = (short)1196032000;
				if (num != 0)
				{
				}
				num = (short)539295744;
				short num3 = num;
				num = (short)1390673921;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedAnalogWidebandData_A1994.UIName;
			}
		}

		// Token: 0x17006041 RID: 24641
		// (get) Token: 0x0600BFAA RID: 49066 RVA: 0x00B0EA6C File Offset: 0x00B0CC6C
		// (set) Token: 0x0600BFAB RID: 49067 RVA: 0x00B0EB20 File Offset: 0x00B0CD20
		internal bool CnvPerAdvancedAnalogWidebandData_A1994_HiddenStatic
		{
			get
			{
				short num = (short)1206364130;
				short num2 = num;
				num = (short)1824958434;
				switch (num2 == num)
				{
				}
				num = (short)1296171008;
				if (num != 0)
				{
				}
				num = (short)1816199168;
				short num3 = num;
				num = (short)1384382465;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedAnalogWidebandData_A1994.HiddenStatic;
			}
			set
			{
				short num = (short)1976331525;
				short num2 = num;
				num = (short)1322478853;
				switch (num2 == num)
				{
				}
				num = (short)1227096065;
				if (num != 0)
				{
				}
				num = (short)1737883648;
				short num3 = num;
				num = (short)1610022912;
				if (num != 0)
				{
				}
				this.cnvPerAdvancedAnalogWidebandData_A1994.HiddenStatic = value;
			}
		}

		// Token: 0x17006042 RID: 24642
		// (get) Token: 0x0600BFAC RID: 49068 RVA: 0x00B0EBD4 File Offset: 0x00B0CDD4
		// (set) Token: 0x0600BFAD RID: 49069 RVA: 0x00B0EC88 File Offset: 0x00B0CE88
		internal bool CnvPerAdvancedAnalogWidebandData_A1994_HiddenDynamic
		{
			get
			{
				short num = (short)799642158;
				short num2 = num;
				num = (short)554603054;
				switch (num2 == num)
				{
				}
				num = (short)256638977;
				if (num != 0)
				{
				}
				num = (short)811270144;
				short num3 = num;
				num = (short)1013055488;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedAnalogWidebandData_A1994.HiddenDynamic;
			}
			set
			{
				short num = (short)1039094996;
				short num2 = num;
				num = (short)1986811092;
				switch (num2 == num)
				{
				}
				num = (short)1586102273;
				if (num != 0)
				{
				}
				num = (short)745472000;
				short num3 = num;
				num = (short)242417664;
				if (num != 0)
				{
				}
				this.cnvPerAdvancedAnalogWidebandData_A1994.HiddenDynamic = value;
			}
		}

		// Token: 0x17006043 RID: 24643
		// (get) Token: 0x0600BFAE RID: 49070 RVA: 0x00B0ED40 File Offset: 0x00B0CF40
		public bool CnvPerAdvancedAnalogWidebandData_A1994_HasDiffs
		{
			get
			{
				short num = (short)1044422569;
				short num2 = num;
				num = (short)519675817;
				switch (num2 == num)
				{
				}
				num = (short)2060845056;
				if (num != 0)
				{
				}
				num = (short)2119565312;
				short num3 = num;
				num = (short)1558708225;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedAnalogWidebandData_A1994._HasDiffs;
			}
		}

		// Token: 0x17006044 RID: 24644
		// (get) Token: 0x0600BFAF RID: 49071 RVA: 0x00B0EDF8 File Offset: 0x00B0CFF8
		// (set) Token: 0x0600BFB0 RID: 49072 RVA: 0x00B0EEB0 File Offset: 0x00B0D0B0
		public bool CnvPerAdvancedDisableHighPassFilter_A7864Value
		{
			get
			{
				short num = (short)678016648;
				short num2 = num;
				num = (short)1858647688;
				switch (num2 == num)
				{
				}
				num = (short)1959591937;
				if (num != 0)
				{
				}
				num = (short)1631322112;
				short num3 = num;
				num = (short)812122112;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedDisableHighPassFilter_A7864.Value;
			}
			set
			{
				short num = (short)425764480;
				short num2 = num;
				num = (short)1964091008;
				switch (num2 == num)
				{
				}
				num = (short)1853095937;
				if (num != 0)
				{
				}
				num = (short)811728896;
				short num3 = num;
				num = (short)524156928;
				if (num != 0)
				{
				}
				this.cnvPerAdvancedDisableHighPassFilter_A7864.Value = value;
			}
		}

		// Token: 0x17006045 RID: 24645
		// (get) Token: 0x0600BFB1 RID: 49073 RVA: 0x00B0EF68 File Offset: 0x00B0D168
		public global::AcpBusinessLayer.AcpField<bool> CnvPerAdvancedDisableHighPassFilter_A7864
		{
			get
			{
				short num = (short)1513394616;
				short num2 = num;
				num = (short)874090936;
				switch (num2 == num)
				{
				}
				num = (short)1007091712;
				if (num != 0)
				{
				}
				num = (short)243466240;
				short num3 = num;
				num = (short)1595539457;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedDisableHighPassFilter_A7864;
			}
		}

		// Token: 0x17006046 RID: 24646
		// (get) Token: 0x0600BFB2 RID: 49074 RVA: 0x00B0F018 File Offset: 0x00B0D218
		// (set) Token: 0x0600BFB3 RID: 49075 RVA: 0x00B0F0CC File Offset: 0x00B0D2CC
		public bool CnvPerAdvancedDisableHighPassFilter_A7864_UIValue
		{
			get
			{
				short num = (short)1797062657;
				if (num != 0)
				{
				}
				num = (short)680400437;
				short num2 = num;
				num = (short)466949685;
				switch (num2 == num)
				{
				}
				num = (short)1575354368;
				short num3 = num;
				num = (short)1556021248;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedDisableHighPassFilter_A7864.Value;
			}
			set
			{
				short num = (short)592808367;
				short num2 = num;
				num = (short)636717487;
				switch (num2 == num)
				{
				}
				num = (short)1360396288;
				if (num != 0)
				{
				}
				num = (short)1974927360;
				short num3 = num;
				num = (short)219480065;
				if (num != 0)
				{
				}
				this.cnvPerAdvancedDisableHighPassFilter_A7864.Value = value;
			}
		}

		// Token: 0x17006047 RID: 24647
		// (get) Token: 0x0600BFB4 RID: 49076 RVA: 0x00B0F184 File Offset: 0x00B0D384
		// (set) Token: 0x0600BFB5 RID: 49077 RVA: 0x00B0F238 File Offset: 0x00B0D438
		public bool CnvPerAdvancedDisableHighPassFilter_A7864_Applicable
		{
			get
			{
				short num = (short)792246771;
				short num2 = num;
				num = (short)2027141619;
				switch (num2 == num)
				{
				}
				num = (short)2086273024;
				if (num != 0)
				{
				}
				num = (short)1363017728;
				short num3 = num;
				num = (short)134152193;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedDisableHighPassFilter_A7864.Applicable;
			}
			set
			{
				short num = (short)1619111540;
				short num2 = num;
				num = (short)1618783860;
				switch (num2 == num)
				{
				}
				num = (short)1469382656;
				if (num != 0)
				{
				}
				num = (short)176226304;
				short num3 = num;
				num = (short)734855169;
				if (num != 0)
				{
				}
				this.cnvPerAdvancedDisableHighPassFilter_A7864.Applicable = value;
			}
		}

		// Token: 0x17006048 RID: 24648
		// (get) Token: 0x0600BFB6 RID: 49078 RVA: 0x00B0F2F0 File Offset: 0x00B0D4F0
		// (set) Token: 0x0600BFB7 RID: 49079 RVA: 0x00B0F3A4 File Offset: 0x00B0D5A4
		public bool CnvPerAdvancedDisableHighPassFilter_A7864_Valid
		{
			get
			{
				short num = (short)1575433303;
				short num2 = num;
				num = (short)1265251415;
				switch (num2 == num)
				{
				}
				num = (short)1825374209;
				if (num != 0)
				{
				}
				num = (short)1926037504;
				short num3 = num;
				num = (short)416481280;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedDisableHighPassFilter_A7864.Valid;
			}
			set
			{
				short num = (short)2139725421;
				short num2 = num;
				num = (short)1947967085;
				switch (num2 == num)
				{
				}
				num = (short)1020788736;
				if (num != 0)
				{
				}
				num = (short)537329664;
				short num3 = num;
				num = (short)365428737;
				if (num != 0)
				{
				}
				this.cnvPerAdvancedDisableHighPassFilter_A7864.Valid = value;
			}
		}

		// Token: 0x17006049 RID: 24649
		// (get) Token: 0x0600BFB8 RID: 49080 RVA: 0x00B0F458 File Offset: 0x00B0D658
		// (set) Token: 0x0600BFB9 RID: 49081 RVA: 0x00B0F50C File Offset: 0x00B0D70C
		public bool CnvPerAdvancedDisableHighPassFilter_A7864_Visible
		{
			get
			{
				short num = (short)801570817;
				if (num != 0)
				{
				}
				num = (short)1561411213;
				short num2 = num;
				num = (short)1750285965;
				switch (num2 == num)
				{
				}
				num = (short)431030272;
				short num3 = num;
				num = (short)1586495488;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedDisableHighPassFilter_A7864.Visible;
			}
			set
			{
				short num = (short)1434583041;
				if (num != 0)
				{
				}
				num = (short)675035415;
				short num2 = num;
				num = (short)2055878935;
				switch (num2 == num)
				{
				}
				num = (short)1849294848;
				short num3 = num;
				num = (short)1499529216;
				if (num != 0)
				{
				}
				this.cnvPerAdvancedDisableHighPassFilter_A7864.Visible = value;
			}
		}

		// Token: 0x1700604A RID: 24650
		// (get) Token: 0x0600BFBA RID: 49082 RVA: 0x00B0F5C0 File Offset: 0x00B0D7C0
		// (set) Token: 0x0600BFBB RID: 49083 RVA: 0x00B0F678 File Offset: 0x00B0D878
		public bool CnvPerAdvancedDisableHighPassFilter_A7864_Editable
		{
			get
			{
				short num = (short)492327233;
				short num2 = num;
				num = (short)1470583105;
				switch (num2 == num)
				{
				}
				num = (short)185597953;
				if (num != 0)
				{
				}
				num = (short)1441726464;
				short num3 = num;
				num = (short)2103640064;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedDisableHighPassFilter_A7864.Editable;
			}
			set
			{
				short num = (short)971721134;
				short num2 = num;
				num = (short)1190545838;
				switch (num2 == num)
				{
				}
				num = (short)1703280641;
				if (num != 0)
				{
				}
				num = (short)1797783552;
				short num3 = num;
				num = (short)637206528;
				if (num != 0)
				{
				}
				this.cnvPerAdvancedDisableHighPassFilter_A7864.Editable = value;
			}
		}

		// Token: 0x1700604B RID: 24651
		// (get) Token: 0x0600BFBC RID: 49084 RVA: 0x00B0F730 File Offset: 0x00B0D930
		internal string CnvPerAdvancedDisableHighPassFilter_A7864_UILabel
		{
			get
			{
				short num = (short)365833510;
				short num2 = num;
				num = (short)347155750;
				switch (num2 == num)
				{
				}
				num = (short)1730215937;
				if (num != 0)
				{
				}
				num = (short)1887043584;
				short num3 = num;
				num = (short)2117468160;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedDisableHighPassFilter_A7864.UIName;
			}
		}

		// Token: 0x1700604C RID: 24652
		// (get) Token: 0x0600BFBD RID: 49085 RVA: 0x00B0F7E4 File Offset: 0x00B0D9E4
		// (set) Token: 0x0600BFBE RID: 49086 RVA: 0x00B0F89C File Offset: 0x00B0DA9C
		internal bool CnvPerAdvancedDisableHighPassFilter_A7864_HiddenStatic
		{
			get
			{
				short num = (short)1781782557;
				short num2 = num;
				num = (short)260626461;
				switch (num2 == num)
				{
				}
				num = (short)2007367681;
				if (num != 0)
				{
				}
				num = (short)1947140096;
				short num3 = num;
				num = (short)110493696;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedDisableHighPassFilter_A7864.HiddenStatic;
			}
			set
			{
				short num = (short)1803707384;
				short num2 = num;
				num = (short)2054710264;
				switch (num2 == num)
				{
				}
				num = (short)970326017;
				if (num != 0)
				{
				}
				num = (short)163250176;
				short num3 = num;
				num = (short)57802752;
				if (num != 0)
				{
				}
				this.cnvPerAdvancedDisableHighPassFilter_A7864.HiddenStatic = value;
			}
		}

		// Token: 0x1700604D RID: 24653
		// (get) Token: 0x0600BFBF RID: 49087 RVA: 0x00B0F950 File Offset: 0x00B0DB50
		// (set) Token: 0x0600BFC0 RID: 49088 RVA: 0x00B0FA08 File Offset: 0x00B0DC08
		internal bool CnvPerAdvancedDisableHighPassFilter_A7864_HiddenDynamic
		{
			get
			{
				short num = (short)34245984;
				short num2 = num;
				num = (short)102206816;
				switch (num2 == num)
				{
				}
				num = (short)2034302977;
				if (num != 0)
				{
				}
				num = (short)2094596096;
				short num3 = num;
				num = (short)219086848;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedDisableHighPassFilter_A7864.HiddenDynamic;
			}
			set
			{
				short num = (short)141411162;
				short num2 = num;
				num = (short)617464666;
				switch (num2 == num)
				{
				}
				num = (short)377683968;
				if (num != 0)
				{
				}
				num = (short)1311113216;
				short num3 = num;
				num = (short)1125515265;
				if (num != 0)
				{
				}
				this.cnvPerAdvancedDisableHighPassFilter_A7864.HiddenDynamic = value;
			}
		}

		// Token: 0x1700604E RID: 24654
		// (get) Token: 0x0600BFC1 RID: 49089 RVA: 0x00B0FABC File Offset: 0x00B0DCBC
		public bool CnvPerAdvancedDisableHighPassFilter_A7864_HasDiffs
		{
			get
			{
				short num = (short)706805761;
				if (num != 0)
				{
				}
				num = (short)72039115;
				short num2 = num;
				num = (short)347159243;
				switch (num2 == num)
				{
				}
				num = (short)764739584;
				short num3 = num;
				num = (short)789708800;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedDisableHighPassFilter_A7864._HasDiffs;
			}
		}

		// Token: 0x1700604F RID: 24655
		// (get) Token: 0x0600BFC2 RID: 49090 RVA: 0x00B0FB70 File Offset: 0x00B0DD70
		// (set) Token: 0x0600BFC3 RID: 49091 RVA: 0x00B0FC28 File Offset: 0x00B0DE28
		public bool CnvPerAdvancedSecondLOSideInjection_A9063Value
		{
			get
			{
				short num = (short)898615562;
				short num2 = num;
				num = (short)870500618;
				switch (num2 == num)
				{
				}
				num = (short)1345060865;
				if (num != 0)
				{
				}
				num = (short)750845952;
				short num3 = num;
				num = (short)1324744704;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedSecondLOSideInjection_A9063.Value;
			}
			set
			{
				short num = (short)1682109352;
				short num2 = num;
				num = (short)1504965544;
				switch (num2 == num)
				{
				}
				num = (short)1578500096;
				if (num != 0)
				{
				}
				num = (short)1183121408;
				short num3 = num;
				num = (short)1442119681;
				if (num != 0)
				{
				}
				this.cnvPerAdvancedSecondLOSideInjection_A9063.Value = value;
			}
		}

		// Token: 0x17006050 RID: 24656
		// (get) Token: 0x0600BFC4 RID: 49092 RVA: 0x00B0FCE0 File Offset: 0x00B0DEE0
		public global::AcpBusinessLayer.AcpField<bool> CnvPerAdvancedSecondLOSideInjection_A9063
		{
			get
			{
				short num = (short)1582124734;
				short num2 = num;
				num = (short)514346686;
				switch (num2 == num)
				{
				}
				num = (short)1853095937;
				if (num != 0)
				{
				}
				num = (short)911081472;
				short num3 = num;
				num = (short)816447488;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedSecondLOSideInjection_A9063;
			}
		}

		// Token: 0x17006051 RID: 24657
		// (get) Token: 0x0600BFC5 RID: 49093 RVA: 0x00B0FD90 File Offset: 0x00B0DF90
		// (set) Token: 0x0600BFC6 RID: 49094 RVA: 0x00B0FE44 File Offset: 0x00B0E044
		public bool CnvPerAdvancedSecondLOSideInjection_A9063_UIValue
		{
			get
			{
				short num = (short)70480852;
				short num2 = num;
				num = (short)1893692372;
				switch (num2 == num)
				{
				}
				num = (short)2060779520;
				if (num != 0)
				{
				}
				num = (short)1219559424;
				short num3 = num;
				num = (short)1507786753;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedSecondLOSideInjection_A9063.Value;
			}
			set
			{
				short num = (short)2087964880;
				short num2 = num;
				num = (short)368758992;
				switch (num2 == num)
				{
				}
				num = (short)1241186304;
				if (num != 0)
				{
				}
				num = (short)1040515072;
				short num3 = num;
				num = (short)1787232257;
				if (num != 0)
				{
				}
				this.cnvPerAdvancedSecondLOSideInjection_A9063.Value = value;
			}
		}

		// Token: 0x17006052 RID: 24658
		// (get) Token: 0x0600BFC7 RID: 49095 RVA: 0x00B0FF00 File Offset: 0x00B0E100
		// (set) Token: 0x0600BFC8 RID: 49096 RVA: 0x00B0FFB4 File Offset: 0x00B0E1B4
		public bool CnvPerAdvancedSecondLOSideInjection_A9063_Applicable
		{
			get
			{
				short num = (short)2004428104;
				short num2 = num;
				num = (short)1298474312;
				switch (num2 == num)
				{
				}
				num = (short)1176698880;
				if (num != 0)
				{
				}
				num = (short)316342272;
				short num3 = num;
				num = (short)1573453825;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedSecondLOSideInjection_A9063.Applicable;
			}
			set
			{
				short num = (short)1423825564;
				short num2 = num;
				num = (short)1265425052;
				switch (num2 == num)
				{
				}
				num = (short)397410304;
				if (num != 0)
				{
				}
				num = (short)1433993216;
				short num3 = num;
				num = (short)216924161;
				if (num != 0)
				{
				}
				this.cnvPerAdvancedSecondLOSideInjection_A9063.Applicable = value;
			}
		}

		// Token: 0x17006053 RID: 24659
		// (get) Token: 0x0600BFC9 RID: 49097 RVA: 0x00B10068 File Offset: 0x00B0E268
		// (set) Token: 0x0600BFCA RID: 49098 RVA: 0x00B10118 File Offset: 0x00B0E318
		public bool CnvPerAdvancedSecondLOSideInjection_A9063_Valid
		{
			get
			{
				short num = (short)1620377147;
				short num2 = num;
				num = (short)630193723;
				switch (num2 == num)
				{
				}
				num = (short)1024786432;
				if (num != 0)
				{
				}
				num = (short)566951936;
				short num3 = num;
				num = (short)969605121;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedSecondLOSideInjection_A9063.Valid;
			}
			set
			{
				short num = (short)1866405444;
				short num2 = num;
				num = (short)457840196;
				switch (num2 == num)
				{
				}
				num = (short)1718681601;
				if (num != 0)
				{
				}
				num = (short)964886528;
				short num3 = num;
				num = (short)1484914688;
				if (num != 0)
				{
				}
				this.cnvPerAdvancedSecondLOSideInjection_A9063.Valid = value;
			}
		}

		// Token: 0x17006054 RID: 24660
		// (get) Token: 0x0600BFCB RID: 49099 RVA: 0x00B101D0 File Offset: 0x00B0E3D0
		// (set) Token: 0x0600BFCC RID: 49100 RVA: 0x00B10288 File Offset: 0x00B0E488
		public bool CnvPerAdvancedSecondLOSideInjection_A9063_Visible
		{
			get
			{
				short num = (short)1537146511;
				short num2 = num;
				num = (short)475463311;
				switch (num2 == num)
				{
				}
				num = (short)1047527424;
				if (num != 0)
				{
				}
				num = (short)430374912;
				short num3 = num;
				num = (short)1049427969;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedSecondLOSideInjection_A9063.Visible;
			}
			set
			{
				short num = (short)1798446767;
				short num2 = num;
				num = (short)625024687;
				switch (num2 == num)
				{
				}
				num = (short)514392064;
				if (num != 0)
				{
				}
				num = (short)1279590400;
				short num3 = num;
				num = (short)822214657;
				if (num != 0)
				{
				}
				this.cnvPerAdvancedSecondLOSideInjection_A9063.Visible = value;
			}
		}

		// Token: 0x17006055 RID: 24661
		// (get) Token: 0x0600BFCD RID: 49101 RVA: 0x00B10340 File Offset: 0x00B0E540
		// (set) Token: 0x0600BFCE RID: 49102 RVA: 0x00B103F4 File Offset: 0x00B0E5F4
		public bool CnvPerAdvancedSecondLOSideInjection_A9063_Editable
		{
			get
			{
				short num = (short)925762208;
				short num2 = num;
				num = (short)1129906848;
				switch (num2 == num)
				{
				}
				num = (short)428539905;
				if (num != 0)
				{
				}
				num = (short)618004480;
				short num3 = num;
				num = (short)306118656;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedSecondLOSideInjection_A9063.Editable;
			}
			set
			{
				short num = (short)250000093;
				short num2 = num;
				num = (short)2102637277;
				switch (num2 == num)
				{
				}
				num = (short)1532690433;
				if (num != 0)
				{
				}
				num = (short)955711488;
				short num3 = num;
				num = (short)1304887296;
				if (num != 0)
				{
				}
				this.cnvPerAdvancedSecondLOSideInjection_A9063.Editable = value;
			}
		}

		// Token: 0x17006056 RID: 24662
		// (get) Token: 0x0600BFCF RID: 49103 RVA: 0x00B104AC File Offset: 0x00B0E6AC
		internal string CnvPerAdvancedSecondLOSideInjection_A9063_UILabel
		{
			get
			{
				short num = (short)928996537;
				short num2 = num;
				num = (short)1135566009;
				switch (num2 == num)
				{
				}
				num = (short)1618345985;
				if (num != 0)
				{
				}
				num = (short)1156644864;
				short num3 = num;
				num = (short)582549504;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedSecondLOSideInjection_A9063.UIName;
			}
		}

		// Token: 0x17006057 RID: 24663
		// (get) Token: 0x0600BFD0 RID: 49104 RVA: 0x00B10560 File Offset: 0x00B0E760
		// (set) Token: 0x0600BFD1 RID: 49105 RVA: 0x00B10614 File Offset: 0x00B0E814
		internal bool CnvPerAdvancedSecondLOSideInjection_A9063_HiddenStatic
		{
			get
			{
				short num = (short)2096466110;
				short num2 = num;
				num = (short)1613859006;
				switch (num2 == num)
				{
				}
				num = (short)120586241;
				if (num != 0)
				{
				}
				num = (short)1183514624;
				short num3 = num;
				num = (short)648937472;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedSecondLOSideInjection_A9063.HiddenStatic;
			}
			set
			{
				short num = (short)920715265;
				if (num != 0)
				{
				}
				num = (short)1746125641;
				short num2 = num;
				num = (short)1553449801;
				switch (num2 == num)
				{
				}
				num = (short)1390280704;
				short num3 = num;
				num = (short)1705902080;
				if (num != 0)
				{
				}
				this.cnvPerAdvancedSecondLOSideInjection_A9063.HiddenStatic = value;
			}
		}

		// Token: 0x17006058 RID: 24664
		// (get) Token: 0x0600BFD2 RID: 49106 RVA: 0x00B106C8 File Offset: 0x00B0E8C8
		// (set) Token: 0x0600BFD3 RID: 49107 RVA: 0x00B1077C File Offset: 0x00B0E97C
		internal bool CnvPerAdvancedSecondLOSideInjection_A9063_HiddenDynamic
		{
			get
			{
				short num = (short)1166802945;
				if (num != 0)
				{
				}
				num = (short)619896989;
				short num2 = num;
				num = (short)1887690909;
				switch (num2 == num)
				{
				}
				num = (short)1881931776;
				short num3 = num;
				num = (short)1231159296;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedSecondLOSideInjection_A9063.HiddenDynamic;
			}
			set
			{
				short num = (short)332937612;
				short num2 = num;
				num = (short)305478028;
				switch (num2 == num)
				{
				}
				num = (short)2062614528;
				if (num != 0)
				{
				}
				num = (short)1268908032;
				short num3 = num;
				num = (short)738852865;
				if (num != 0)
				{
				}
				this.cnvPerAdvancedSecondLOSideInjection_A9063.HiddenDynamic = value;
			}
		}

		// Token: 0x17006059 RID: 24665
		// (get) Token: 0x0600BFD4 RID: 49108 RVA: 0x00B10834 File Offset: 0x00B0EA34
		public bool CnvPerAdvancedSecondLOSideInjection_A9063_HasDiffs
		{
			get
			{
				short num = (short)166662757;
				short num2 = num;
				num = (short)580260453;
				switch (num2 == num)
				{
				}
				num = (short)1737097216;
				if (num != 0)
				{
				}
				num = (short)928317440;
				short num3 = num;
				num = (short)103546881;
				if (num != 0)
				{
				}
				return this.cnvPerAdvancedSecondLOSideInjection_A9063._HasDiffs;
			}
		}

		// Token: 0x1700605A RID: 24666
		// (get) Token: 0x0600BFD5 RID: 49109 RVA: 0x00B108E8 File Offset: 0x00B0EAE8
		// (set) Token: 0x0600BFD6 RID: 49110 RVA: 0x00B1099C File Offset: 0x00B0EB9C
		public bool CnvPerAdvanceBroadbandProtectionValue
		{
			get
			{
				short num = (short)1107787004;
				short num2 = num;
				num = (short)1812364540;
				switch (num2 == num)
				{
				}
				num = (short)584515585;
				if (num != 0)
				{
				}
				num = (short)1150287872;
				short num3 = num;
				num = (short)1911029760;
				if (num != 0)
				{
				}
				return this.cnvPerAdvanceBroadbandProtection.Value;
			}
			set
			{
				short num = (short)635312382;
				short num2 = num;
				num = (short)1716394238;
				switch (num2 == num)
				{
				}
				num = (short)506789889;
				if (num != 0)
				{
				}
				num = (short)377159680;
				short num3 = num;
				num = (short)1230635008;
				if (num != 0)
				{
				}
				this.cnvPerAdvanceBroadbandProtection.Value = value;
			}
		}

		// Token: 0x1700605B RID: 24667
		// (get) Token: 0x0600BFD7 RID: 49111 RVA: 0x00B10A54 File Offset: 0x00B0EC54
		public global::AcpBusinessLayer.AcpField<bool> CnvPerAdvanceBroadbandProtection
		{
			get
			{
				short num = (short)1377723883;
				short num2 = num;
				num = (short)21718507;
				switch (num2 == num)
				{
				}
				num = (short)1681588225;
				if (num != 0)
				{
				}
				num = (short)1176895488;
				short num3 = num;
				num = (short)1199439872;
				if (num != 0)
				{
				}
				return this.cnvPerAdvanceBroadbandProtection;
			}
		}

		// Token: 0x1700605C RID: 24668
		// (get) Token: 0x0600BFD8 RID: 49112 RVA: 0x00B10B04 File Offset: 0x00B0ED04
		// (set) Token: 0x0600BFD9 RID: 49113 RVA: 0x00B10BBC File Offset: 0x00B0EDBC
		public bool CnvPerAdvanceBroadbandProtection_UIValue
		{
			get
			{
				short num = (short)887396276;
				short num2 = num;
				num = (short)1676449716;
				switch (num2 == num)
				{
				}
				num = (short)1415905281;
				if (num != 0)
				{
				}
				num = (short)1568407552;
				short num3 = num;
				num = (short)460390400;
				if (num != 0)
				{
				}
				return this.cnvPerAdvanceBroadbandProtection.Value;
			}
			set
			{
				short num = (short)1167293126;
				short num2 = num;
				num = (short)265845446;
				switch (num2 == num)
				{
				}
				num = (short)1727332353;
				if (num != 0)
				{
				}
				num = (short)870121472;
				short num3 = num;
				num = (short)1397882880;
				if (num != 0)
				{
				}
				this.cnvPerAdvanceBroadbandProtection.Value = value;
			}
		}

		// Token: 0x1700605D RID: 24669
		// (get) Token: 0x0600BFDA RID: 49114 RVA: 0x00B10C70 File Offset: 0x00B0EE70
		// (set) Token: 0x0600BFDB RID: 49115 RVA: 0x00B10D24 File Offset: 0x00B0EF24
		public bool CnvPerAdvanceBroadbandProtection_Applicable
		{
			get
			{
				short num = (short)1032232930;
				short num2 = num;
				num = (short)1977262050;
				switch (num2 == num)
				{
				}
				num = (short)2128936960;
				if (num != 0)
				{
				}
				num = (short)127533056;
				short num3 = num;
				num = (short)128843777;
				if (num != 0)
				{
				}
				return this.cnvPerAdvanceBroadbandProtection.Applicable;
			}
			set
			{
				short num = (short)287838410;
				short num2 = num;
				num = (short)940970186;
				switch (num2 == num)
				{
				}
				num = (short)798162944;
				if (num != 0)
				{
				}
				num = (short)316145664;
				short num3 = num;
				num = (short)1481768961;
				if (num != 0)
				{
				}
				this.cnvPerAdvanceBroadbandProtection.Applicable = value;
			}
		}

		// Token: 0x1700605E RID: 24670
		// (get) Token: 0x0600BFDC RID: 49116 RVA: 0x00B10DD8 File Offset: 0x00B0EFD8
		// (set) Token: 0x0600BFDD RID: 49117 RVA: 0x00B10E8C File Offset: 0x00B0F08C
		public bool CnvPerAdvanceBroadbandProtection_Valid
		{
			get
			{
				short num = (short)924581889;
				if (num != 0)
				{
				}
				num = (short)1669761719;
				short num2 = num;
				num = (short)47483575;
				switch (num2 == num)
				{
				}
				num = (short)1333264384;
				short num3 = num;
				num = (short)75235328;
				if (num != 0)
				{
				}
				return this.cnvPerAdvanceBroadbandProtection.Valid;
			}
			set
			{
				short num = (short)1425604608;
				short num2 = num;
				num = (short)1429549287;
				short num3 = num;
				num = (short)694694119;
				switch (num3 == num)
				{
				}
				num = (short)1307377664;
				if (num != 0)
				{
				}
				num = (short)1284898817;
				if (num != 0)
				{
				}
				this.cnvPerAdvanceBroadbandProtection.Valid = value;
			}
		}

		// Token: 0x1700605F RID: 24671
		// (get) Token: 0x0600BFDE RID: 49118 RVA: 0x00B10F40 File Offset: 0x00B0F140
		// (set) Token: 0x0600BFDF RID: 49119 RVA: 0x00B10FF4 File Offset: 0x00B0F1F4
		public bool CnvPerAdvanceBroadbandProtection_Visible
		{
			get
			{
				short num = (short)742653952;
				short num2 = num;
				num = (short)323975503;
				short num3 = num;
				num = (short)786135375;
				switch (num3 == num)
				{
				}
				num = (short)1220149249;
				if (num != 0)
				{
				}
				num = (short)495845376;
				if (num != 0)
				{
				}
				return this.cnvPerAdvanceBroadbandProtection.Visible;
			}
			set
			{
				short num = (short)1876426752;
				short num2 = num;
				num = (short)113466898;
				short num3 = num;
				num = (short)1457872402;
				switch (num3 == num)
				{
				}
				num = (short)1193672705;
				if (num != 0)
				{
				}
				num = (short)604897280;
				if (num != 0)
				{
				}
				this.cnvPerAdvanceBroadbandProtection.Visible = value;
			}
		}

		// Token: 0x17006060 RID: 24672
		// (get) Token: 0x0600BFE0 RID: 49120 RVA: 0x00B110A8 File Offset: 0x00B0F2A8
		// (set) Token: 0x0600BFE1 RID: 49121 RVA: 0x00B1115C File Offset: 0x00B0F35C
		public bool CnvPerAdvanceBroadbandProtection_Editable
		{
			get
			{
				short num = (short)1429929984;
				short num2 = num;
				num = (short)875655445;
				short num3 = num;
				num = (short)1436184853;
				switch (num3 == num)
				{
				}
				num = (short)1252720641;
				if (num != 0)
				{
				}
				num = (short)1168834560;
				if (num != 0)
				{
				}
				return this.cnvPerAdvanceBroadbandProtection.Editable;
			}
			set
			{
				short num = (short)1841561600;
				short num2 = num;
				num = (short)594680449;
				short num3 = num;
				num = (short)657529473;
				switch (num3 == num)
				{
				}
				num = (short)608501761;
				if (num != 0)
				{
				}
				num = (short)2097872896;
				if (num != 0)
				{
				}
				this.cnvPerAdvanceBroadbandProtection.Editable = value;
			}
		}

		// Token: 0x17006061 RID: 24673
		// (get) Token: 0x0600BFE2 RID: 49122 RVA: 0x00B11210 File Offset: 0x00B0F410
		internal string CnvPerAdvanceBroadbandProtection_UILabel
		{
			get
			{
				short num = (short)913375232;
				short num2 = num;
				num = (short)1991879083;
				short num3 = num;
				num = (short)2046863787;
				switch (num3 == num)
				{
				}
				num = (short)270991361;
				if (num != 0)
				{
				}
				num = (short)1965424640;
				if (num != 0)
				{
				}
				return this.cnvPerAdvanceBroadbandProtection.UIName;
			}
		}

		// Token: 0x17006062 RID: 24674
		// (get) Token: 0x0600BFE3 RID: 49123 RVA: 0x00B112C4 File Offset: 0x00B0F4C4
		// (set) Token: 0x0600BFE4 RID: 49124 RVA: 0x00B11378 File Offset: 0x00B0F578
		internal bool CnvPerAdvanceBroadbandProtection_HiddenStatic
		{
			get
			{
				short num = (short)1482162176;
				short num2 = num;
				num = (short)2097043298;
				short num3 = num;
				num = (short)85284706;
				switch (num3 == num)
				{
				}
				num = (short)2032467969;
				if (num != 0)
				{
				}
				num = (short)2124218368;
				if (num != 0)
				{
				}
				return this.cnvPerAdvanceBroadbandProtection.HiddenStatic;
			}
			set
			{
				short num = (short)93192192;
				short num2 = num;
				num = (short)1147309002;
				short num3 = num;
				num = (short)1932954570;
				switch (num3 == num)
				{
				}
				num = (short)243924993;
				if (num != 0)
				{
				}
				num = (short)1877409792;
				if (num != 0)
				{
				}
				this.cnvPerAdvanceBroadbandProtection.HiddenStatic = value;
			}
		}

		// Token: 0x17006063 RID: 24675
		// (get) Token: 0x0600BFE5 RID: 49125 RVA: 0x00B11430 File Offset: 0x00B0F630
		// (set) Token: 0x0600BFE6 RID: 49126 RVA: 0x00B114E0 File Offset: 0x00B0F6E0
		internal bool CnvPerAdvanceBroadbandProtection_HiddenDynamic
		{
			get
			{
				short num = (short)1636564992;
				short num2 = num;
				num = (short)316080129;
				if (num != 0)
				{
				}
				num = (short)2117970945;
				short num3 = num;
				num = (short)408136705;
				switch (num3 == num)
				{
				}
				num = (short)409141248;
				if (num != 0)
				{
				}
				return this.cnvPerAdvanceBroadbandProtection.HiddenDynamic;
			}
			set
			{
				short num = (short)1365966848;
				short num2 = num;
				num = (short)1917675465;
				short num3 = num;
				num = (short)1288071113;
				switch (num3 == num)
				{
				}
				num = (short)1622736897;
				if (num != 0)
				{
				}
				num = (short)945750016;
				if (num != 0)
				{
				}
				this.cnvPerAdvanceBroadbandProtection.HiddenDynamic = value;
			}
		}

		// Token: 0x17006064 RID: 24676
		// (get) Token: 0x0600BFE7 RID: 49127 RVA: 0x00B11598 File Offset: 0x00B0F798
		public bool CnvPerAdvanceBroadbandProtection_HasDiffs
		{
			get
			{
				short num = (short)455802880;
				short num2 = num;
				num = (short)992293548;
				short num3 = num;
				num = (short)1193489068;
				switch (num3 == num)
				{
				}
				num = (short)1728774145;
				if (num != 0)
				{
				}
				num = (short)1511194624;
				if (num != 0)
				{
				}
				return this.cnvPerAdvanceBroadbandProtection._HasDiffs;
			}
		}

		// Token: 0x17006065 RID: 24677
		// (get) Token: 0x0600BFE8 RID: 49128 RVA: 0x00B11650 File Offset: 0x00B0F850
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)744816640;
				short num2 = num;
				num = (short)1848508417;
				if (num != 0)
				{
				}
				num = (short)599834856;
				short num3 = num;
				num = (short)776847592;
				switch (num3 == num)
				{
				}
				num = (short)4718592;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x0600BFE9 RID: 49129 RVA: 0x00B11710 File Offset: 0x00B0F910
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_BE;
			}
			short num;
			global::AcpCommonLib.IAcpRecordset result;
			int num4;
			for (;;)
			{
				IL_0A:
				num = (short)1907355885;
				short num2 = num;
				num = (short)1614606573;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return result;
				default:
				{
					num = (short)281018369;
					if (num != 0)
					{
					}
					num = (short)336461824;
					short num3 = num;
					num = (short)1753939968;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						if (base.ParentRecset != null)
						{
							num = (short)1354825731;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)1806761986;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)1903296516;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)303431681;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return result;
					}
					goto IL_BE;
				}
				}
			}
			return result;
			IL_BE:
			result = null;
			num = (short)904462336;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04005C3F RID: 23615
		private global::AcpBusinessLayer.AcpListField cnvPerAdvancedAdvancedRFAGC_A7408;

		// Token: 0x04005C40 RID: 23616
		private global::AcpBusinessLayer.AcpField<bool> cnvPerAdvancedAnalogFlatAudio_A7443;

		// Token: 0x04005C41 RID: 23617
		private global::AcpBusinessLayer.AcpField<bool> cnvPerAdvancedAnalogWidebandData_A1994;

		// Token: 0x04005C42 RID: 23618
		private global::AcpBusinessLayer.AcpField<bool> cnvPerAdvancedDisableHighPassFilter_A7864;

		// Token: 0x04005C43 RID: 23619
		private global::AcpBusinessLayer.AcpField<bool> cnvPerAdvancedSecondLOSideInjection_A9063;

		// Token: 0x04005C44 RID: 23620
		private global::AcpBusinessLayer.AcpField<bool> cnvPerAdvanceBroadbandProtection;
	}
}
