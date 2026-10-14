using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004E4 RID: 1252
	[global::System.Serializable]
	public class LTE : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600A75D RID: 42845 RVA: 0x009BB190 File Offset: 0x009B9390
		public LTE(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600A75E RID: 42846 RVA: 0x009BB1AC File Offset: 0x009B93AC
		protected LTE(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600A75F RID: 42847 RVA: 0x009BB1C4 File Offset: 0x009B93C4
		public override void Init()
		{
			int a_ = 8;
			short num = (short)1004797952;
			short num2 = num;
			num = (short)1590837332;
			short num3 = num;
			num = (short)1067663444;
			switch (num3 == num)
			{
			}
			num = (short)83755008;
			if (num != 0)
			{
			}
			num = (short)62717953;
			if (num != 0)
			{
			}
			this.dataWideLTELTECheckbackTime_A42205 = new global::AcpBusinessLayer.AcpSimpleRangeField(180, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖闘迚飜鏞뗠ꛢꛤ迦賨裪蛬跮郰郲黴ꏶ郸雺飼ꃾ䀀㜂㜄㔆㤈㸊", a_), global::CommonResources.AcgResources.ID_LTECHECKBACKTIMESEC, 0, 3600, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LegacyTitles.DataWideLTELTECheckbackTime_A42205LegacyTitles);
			this.dataWideLTELTECheckbackTime_A42205.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideLTELTECheckbackTime_A42205.DataTransferOrder = 57;
			this.dataWideLTELTECheckbackTime_A42205.ShowHexValue = false;
			this.dataWideLTEOutOfRangeThresholdTime_A42206 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖闘迚飜郞铠韢ꫤ臦믨諪菬裮铰ꟲ鷴藶鳸裺闼郾洀朂億渆搈渊刌与┐ℒ✔✖⼘", a_), global::CommonResources.AcgResources.ID_LTEOUTOFRANGETHRESHOLDTIMESEC, 60, 3600, null, null, 0, 1);
			this.dataWideLTEOutOfRangeThresholdTime_A42206.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.dataWideLTEOutOfRangeThresholdTime_A42206.DataTransferOrder = 58;
			this.dataWideLTEOutOfRangeThresholdTime_A42206.ShowHexValue = false;
			this.dataWideLTEOffMaxDetachTime_A42207 = new global::AcpBusinessLayer.AcpSimpleRangeField(6, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖闘迚飜郞蟠藢꣤蛦釨꿪裬鯮郰郲鷴ꏶ郸雺飼ꃾ䀀㜂㜄㔆㤈㰊", a_), global::CommonResources.AcgResources.ID_LTEOFFMAXDETACHTIMESEC, 1, 100, null, null, 0, 1);
			this.dataWideLTEOffMaxDetachTime_A42207.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dataWideLTEOffMaxDetachTime_A42207.DataTransferOrder = -1;
			this.dataWideLTEOffMaxDetachTime_A42207.ShowHexValue = false;
			this.dataWideLTEModeChangeMaxDetachTime_A42208 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖闘迚飜鋞軠蟢胤ꓦ臨諪菬裮铰뻲铴迶뷸黺觼黾戀欂億渆搈渊刌与┐ℒ✔✖℘", a_), global::CommonResources.AcgResources.ID_LTEMODECHANGEMAXDETACHTIMESEC, 1, 100, null, null, 0, 1);
			this.dataWideLTEModeChangeMaxDetachTime_A42208.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dataWideLTEModeChangeMaxDetachTime_A42208.DataTransferOrder = -1;
			this.dataWideLTEModeChangeMaxDetachTime_A42208.ShowHexValue = false;
			this.dataWideLTEOpenMaxGuardTime_A42391 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖闘迚飜郞釠蛢诤ꫦ裨鏪ꫬ髮郰臲釴ꏶ郸雺飼ꃾ䀀㜂㜄㐆〈㨊", a_), global::CommonResources.AcgResources.ID_LTEOPENMAXGUARDTIME, 1, 100, null, null, 0, 1);
			this.dataWideLTEOpenMaxGuardTime_A42391.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dataWideLTEOpenMaxGuardTime_A42391.DataTransferOrder = -1;
			this.dataWideLTEOpenMaxGuardTime_A42391.ShowHexValue = false;
			this.dataWideLTEClass3AccessPointName_A42392 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖闘迚飜鳞跠苢雤铦\udae8ꫪ軬賮铰胲蛴ꟶ雸鋺鏼课伀戂栄戆嘈䨊㤌㴎∐⨒✔", a_), global::CommonResources.AcgResources.ID_ACCESSPOINTNAME, 63);
			this.dataWideLTEClass3AccessPointName_A42392.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.dataWideLTEClass3AccessPointName_A42392.DataTransferOrder = 59;
			this.dataWideLTEOperation_A42215 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖闘迚飜郞釠蛢韤蛦鷨苪苬臮껰닲쇴엶쯸쫺주", a_), global::CommonResources.AcgResources.ID_LTEOPERATION)
			{
				DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full,
				DataTransferOrder = 60
			};
			this.dataWideDataOnRoaming_A42216 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖鷘뫚꧜뻞껠跢럤裦裨蛪蓬臮雰곲듴쏶쯸짺쳼짾", a_), global::CommonResources.AcgResources.ID_DATA_ON_ROAMING)
			{
				DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full,
				DataTransferOrder = 61
			};
			this.dataWideLTEHWEnable = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖闘迚飜韞뛠ꛢ诤蛦诨蟪裬", a_), global::CommonResources.AcgResources.ID_LTE_HW_Enable)
			{
				DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full,
				DataTransferOrder = 62
			};
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藈鿊裌", a_);
			base.Id = 10782;
			base.UIName = global::CommonResources.AcgResources.ID_LTE;
			base.DataTransferOrder = 10;
		}

		// Token: 0x0600A760 RID: 42848 RVA: 0x009BB504 File Offset: 0x009B9704
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)505806867;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.dataWideLTEOffMaxDetachTime_A42207 = new global::AcpBusinessLayer.AcpSimpleRangeField(6, this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟껡냣ꏥ꟧賩諫ꏭ釯諱냳鏵賷鯹鿻雽哿欁椃挅圇䬉㠋㰍∏∑⌓", a_), global::CommonResources.AcgResources.ID_LTEOFFMAXDETACHTIMESEC, null, null, 0, 1);
					this.dataWideLTEOffMaxDetachTime_A42207.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dataWideLTEOffMaxDetachTime_A42207.DataTransferOrder = -1;
					this.dataWideLTEOffMaxDetachTime_A42207.ShowHexValue = false;
					num = (short)1668284417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_62F;
				case 2:
				{
					num = (short)923108084;
					short num3 = num;
					num = (short)341672692;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_164;
					default:
						num = (short)115015680;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟껡냣ꏥꃧ뷩ꧫ胭釯郱飳鏵", a_)))
						{
							num = (short)2144337930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_79F;
					}
					break;
				}
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟껡냣ꏥ꟧鿩飫ꇭ雯ꃱ闳飵鿷鿹ꣻ雽狿朁眃清朇昉栋娍礏缑焓䤕夗⸙⸛Ⱍဟᐡ", a_)))
					{
						num = (short)382795789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_56B;
				case 4:
					this.dataWideDataOnRoaming_A42216 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟ꛡ藣鋥觧ꗩ苫볭鿯鏱駳鿵雷鷹ꏻ뿽㓿、㘃㜅㸇", a_), global::CommonResources.AcgResources.ID_DATA_ON_ROAMING)
					{
						DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full,
						DataTransferOrder = 61
					};
					num = (short)1542783005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.dataWideLTEOperation_A42215 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟껡냣ꏥ꟧髩觫鳭釯蛱鷳駵雷ꗹ뷻쫽㋿、㔃㌅", a_), global::CommonResources.AcgResources.ID_LTEOPERATION)
					{
						DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full,
						DataTransferOrder = 60
					};
					num = (short)1087111185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_4C8;
				case 7:
					num = (short)1799684097;
					if (num != 0)
					{
					}
					goto IL_37F;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟껡냣ꏥꗧ藩裫语돯髱闳飵鿷鿹뇻鿽磿䘁愃爅椇椉搋娍礏缑焓䤕夗⸙⸛Ⱍဟᨡ", a_)))
					{
						num = (short)63504410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37F;
				case 9:
					this.dataWideLTEClass3AccessPointName_A42392 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟껡냣ꏥꯧ蛩跫鷭華쇱뗳闵鯷鿹迻跽僿洁洃栅簇䐉洋挍甏䴑唓∕⨗⤙┛Ⱍ", a_), global::CommonResources.AcgResources.ID_ACCESSPOINTNAME, 63);
					this.dataWideLTEClass3AccessPointName_A42392.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.dataWideLTEClass3AccessPointName_A42392.DataTransferOrder = 59;
					num = (short)2001666071;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					this.dataWideLTEHWEnable = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟껡냣ꏥꃧ뷩ꧫ胭釯郱飳鏵", a_), global::CommonResources.AcgResources.ID_LTE_HW_Enable)
					{
						DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full,
						DataTransferOrder = 62
					};
					num = (short)1688666118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟껡냣ꏥꯧ蛩跫鷭華쇱뗳闵鯷鿹迻跽僿洁洃栅簇䐉洋挍甏䴑唓∕⨗⤙┛Ⱍ", a_)))
					{
						num = (short)1256718345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CF;
				case 12:
					this.dataWideLTEOpenMaxGuardTime_A42391 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟껡냣ꏥ꟧髩觫胭뷯鏱賳뇵跷鯹軻髽哿欁椃挅圇䬉㠋㰍⌏⬑┓", a_), global::CommonResources.AcgResources.ID_LTEOPENMAXGUARDTIME, null, null, 0, 1);
					this.dataWideLTEOpenMaxGuardTime_A42391.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dataWideLTEOpenMaxGuardTime_A42391.DataTransferOrder = -1;
					this.dataWideLTEOpenMaxGuardTime_A42391.ShowHexValue = false;
					goto IL_164;
				case 13:
					this.dataWideLTEOutOfRangeThresholdTime_A42206 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟껡냣ꏥ꟧鿩飫ꇭ雯ꃱ闳飵鿷鿹ꣻ雽狿朁眃清朇昉栋娍礏缑焓䤕夗⸙⸛Ⱍဟᐡ", a_), global::CommonResources.AcgResources.ID_LTEOUTOFRANGETHRESHOLDTIMESEC, null, null, 0, 1);
					this.dataWideLTEOutOfRangeThresholdTime_A42206.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.dataWideLTEOutOfRangeThresholdTime_A42206.DataTransferOrder = 58;
					this.dataWideLTEOutOfRangeThresholdTime_A42206.ShowHexValue = false;
					num = (short)1329790992;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)80674831;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (producerFields != null)
					{
						num = (short)2133327900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79F;
				case 16:
					goto IL_56B;
				case 17:
					goto IL_1CD;
				case 18:
					goto IL_6C7;
				case 19:
					switch (0)
					{
					case 0:
						goto IL_A9;
					}
					continue;
				case 20:
					goto IL_180;
				case 21:
				{
					num = (short)887095296;
					short num4 = num;
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟껡냣ꏥꓧ뻩ꧫ귭飯韱音鷵髷鯹鿻闽哿欁椃挅圇䬉㠋㰍∏∑ℓ", a_)))
					{
						num = (short)80347158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_180;
				}
				case 22:
					this.dataWideLTELTECheckbackTime_A42205 = new global::AcpBusinessLayer.AcpSimpleRangeField(180, this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟껡냣ꏥꓧ뻩ꧫ귭飯韱音鷵髷鯹鿻闽哿欁椃挅圇䬉㠋㰍∏∑ℓ", a_), global::CommonResources.AcgResources.ID_LTECHECKBACKTIMESEC, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LegacyTitles.DataWideLTELTECheckbackTime_A42205LegacyTitles);
					this.dataWideLTELTECheckbackTime_A42205.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideLTELTECheckbackTime_A42205.DataTransferOrder = 57;
					this.dataWideLTELTECheckbackTime_A42205.ShowHexValue = false;
					num = (short)841482260;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					goto IL_CF;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟껡냣ꏥ꟧髩觫胭뷯鏱賳뇵跷鯹軻髽哿欁椃挅圇䬉㠋㰍⌏⬑┓", a_)))
					{
						num = (short)1735393292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6C7;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟껡냣ꏥ꟧髩觫鳭釯蛱鷳駵雷ꗹ뷻쫽㋿、㔃㌅", a_)))
					{
						num = (short)1634533381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CD;
				case 26:
					this.dataWideLTEModeChangeMaxDetachTime_A42208 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟껡냣ꏥꗧ藩裫语돯髱闳飵鿷鿹뇻鿽磿䘁愃爅椇椉搋娍礏缑焓䤕夗⸙⸛Ⱍဟᨡ", a_), global::CommonResources.AcgResources.ID_LTEMODECHANGEMAXDETACHTIMESEC, null, null, 0, 1);
					this.dataWideLTEModeChangeMaxDetachTime_A42208.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dataWideLTEModeChangeMaxDetachTime_A42208.DataTransferOrder = -1;
					this.dataWideLTEModeChangeMaxDetachTime_A42208.ShowHexValue = false;
					num = (short)445906951;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟껡냣ꏥ꟧賩諫ꏭ釯諱냳鏵賷鯹鿻雽哿欁椃挅圇䬉㠋㰍∏∑⌓", a_)))
					{
						num = (short)364052480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_62F;
				case 28:
					num = (short)792264725;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					goto IL_2E6;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟ꛡ藣鋥觧ꗩ苫볭鿯鏱駳鿵雷鷹ꏻ뿽㓿、㘃㜅㸇", a_)))
					{
						num = (short)1684013060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E6;
				}
				IL_A9:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)2062155790;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_CF:
				num = (short)1203568665;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_164:
				num = (short)1104085010;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_180:
				num = (short)623509507;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1CD:
				num = (short)1664614430;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E6:
				num = (short)1642594306;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_37F:
				num = (short)208207896;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_56B:
				num = (short)1322123291;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_62F:
				num = (short)899547144;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6C7:
				num = (short)1268514827;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4C8:
			IL_79F:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("黑胓鏕", a_);
			base.Id = 10782;
			base.UIName = global::CommonResources.AcgResources.ID_LTE;
			base.DataTransferOrder = 10;
		}

		// Token: 0x0600A761 RID: 42849 RVA: 0x009BBCE4 File Offset: 0x009B9EE4
		public override void PopulateReferences()
		{
			short num = (short)2024705411;
			short num2 = num;
			num = (short)1155960195;
			switch (num2 == num)
			{
			}
			num = (short)748486657;
			if (num != 0)
			{
			}
			num = (short)1624440832;
			if (num != 0)
			{
			}
			num = (short)264634368;
			short num3 = num;
		}

		// Token: 0x0600A762 RID: 42850 RVA: 0x009BBD94 File Offset: 0x009B9F94
		public override void DropReferences()
		{
			short num = (short)1981082405;
			short num2 = num;
			num = (short)140634917;
			switch (num2 == num)
			{
			}
			num = (short)875626497;
			if (num != 0)
			{
			}
			num = (short)274333696;
			if (num != 0)
			{
			}
			num = (short)104792064;
			short num3 = num;
		}

		// Token: 0x0600A763 RID: 42851 RVA: 0x009BBE3C File Offset: 0x009BA03C
		public override void SetConstraints()
		{
			short num = (short)1469368585;
			short num2 = num;
			num = (short)1109707017;
			switch (num2 == num)
			{
			}
			num = (short)1597767681;
			if (num != 0)
			{
			}
			num = (short)1816002560;
			if (num != 0)
			{
			}
			num = (short)1590820864;
			short num3 = num;
			this.dataWideLTELTECheckbackTime_A42205.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.conReturnFalse);
			this.dataWideLTELTECheckbackTime_A42205.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConSetBroadbandCheckbackTime);
			this.dataWideLTEHWEnable.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x0600A764 RID: 42852 RVA: 0x009BBF28 File Offset: 0x009BA128
		public override void SetupDependencies()
		{
			short num = (short)1005842221;
			short num2 = num;
			num = (short)1184493357;
			switch (num2 == num)
			{
			}
			num = (short)2020605953;
			if (num != 0)
			{
			}
			num = (short)376242176;
			if (num != 0)
			{
			}
			num = (short)1096155136;
			short num3 = num;
		}

		// Token: 0x1700540A RID: 21514
		// (get) Token: 0x0600A765 RID: 42853 RVA: 0x009BBFD0 File Offset: 0x009BA1D0
		public bool HasDiffs
		{
			get
			{
				short num = (short)988611194;
				short num2 = num;
				num = (short)872874618;
				switch (num2 == num)
				{
				}
				num = (short)670564353;
				if (num != 0)
				{
				}
				num = (short)1720516608;
				if (num != 0)
				{
				}
				num = (short)1197277184;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x1700540B RID: 21515
		// (get) Token: 0x0600A766 RID: 42854 RVA: 0x009BC080 File Offset: 0x009BA280
		// (set) Token: 0x0600A767 RID: 42855 RVA: 0x009BC134 File Offset: 0x009BA334
		public int DataWideLTELTECheckbackTime_A42205Value
		{
			get
			{
				short num = (short)1762077766;
				short num2 = num;
				num = (short)960965702;
				switch (num2 == num)
				{
				}
				num = (short)629735425;
				if (num != 0)
				{
				}
				num = (short)797966336;
				if (num != 0)
				{
				}
				num = (short)1375666176;
				short num3 = num;
				return this.dataWideLTELTECheckbackTime_A42205.Value;
			}
			set
			{
				short num = (short)1587934621;
				short num2 = num;
				num = (short)848295325;
				switch (num2 == num)
				{
				}
				num = (short)726597633;
				if (num != 0)
				{
				}
				num = (short)2076180480;
				if (num != 0)
				{
				}
				num = (short)1346830336;
				short num3 = num;
				this.dataWideLTELTECheckbackTime_A42205.Value = value;
			}
		}

		// Token: 0x1700540C RID: 21516
		// (get) Token: 0x0600A768 RID: 42856 RVA: 0x009BC1EC File Offset: 0x009BA3EC
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideLTELTECheckbackTime_A42205
		{
			get
			{
				short num = (short)1369667514;
				short num2 = num;
				num = (short)1820882874;
				switch (num2 == num)
				{
				}
				num = (short)304742400;
				if (num != 0)
				{
				}
				num = (short)1743781889;
				if (num != 0)
				{
				}
				num = (short)1248067584;
				short num3 = num;
				return this.dataWideLTELTECheckbackTime_A42205;
			}
		}

		// Token: 0x1700540D RID: 21517
		// (get) Token: 0x0600A769 RID: 42857 RVA: 0x009BC29C File Offset: 0x009BA49C
		// (set) Token: 0x0600A76A RID: 42858 RVA: 0x009BC350 File Offset: 0x009BA550
		public string DataWideLTELTECheckbackTime_A42205_UIValue
		{
			get
			{
				short num = (short)661757092;
				short num2 = num;
				num = (short)285908132;
				switch (num2 == num)
				{
				}
				num = (short)1036124160;
				if (num != 0)
				{
				}
				num = (short)850395137;
				if (num != 0)
				{
				}
				num = (short)1657798656;
				short num3 = num;
				return this.dataWideLTELTECheckbackTime_A42205.UIValue;
			}
			set
			{
				short num = (short)99344458;
				short num2 = num;
				num = (short)1341186122;
				switch (num2 == num)
				{
				}
				num = (short)1554513920;
				if (num != 0)
				{
				}
				num = (short)1159921665;
				if (num != 0)
				{
				}
				num = (short)1575223296;
				short num3 = num;
				this.dataWideLTELTECheckbackTime_A42205.UIValue = value;
			}
		}

		// Token: 0x1700540E RID: 21518
		// (get) Token: 0x0600A76B RID: 42859 RVA: 0x009BC404 File Offset: 0x009BA604
		// (set) Token: 0x0600A76C RID: 42860 RVA: 0x009BC4B8 File Offset: 0x009BA6B8
		internal int DataWideLTELTECheckbackTime_A42205Min
		{
			get
			{
				short num = (short)394613012;
				short num2 = num;
				num = (short)72831252;
				switch (num2 == num)
				{
				}
				num = (short)1580990465;
				if (num != 0)
				{
				}
				num = (short)1767702528;
				if (num != 0)
				{
				}
				num = (short)1438318592;
				short num3 = num;
				return this.dataWideLTELTECheckbackTime_A42205.Min;
			}
			set
			{
				short num = (short)1440656618;
				short num2 = num;
				num = (short)844868842;
				switch (num2 == num)
				{
				}
				num = (short)814481409;
				if (num != 0)
				{
				}
				num = (short)1216413696;
				if (num != 0)
				{
				}
				num = (short)1339490304;
				short num3 = num;
				this.dataWideLTELTECheckbackTime_A42205.Min = value;
			}
		}

		// Token: 0x1700540F RID: 21519
		// (get) Token: 0x0600A76D RID: 42861 RVA: 0x009BC56C File Offset: 0x009BA76C
		// (set) Token: 0x0600A76E RID: 42862 RVA: 0x009BC61C File Offset: 0x009BA81C
		internal int DataWideLTELTECheckbackTime_A42205Max
		{
			get
			{
				short num = (short)478478337;
				if (num != 0)
				{
				}
				num = (short)2013683400;
				short num2 = num;
				num = (short)1922981576;
				switch (num2 == num)
				{
				}
				num = (short)1235943424;
				if (num != 0)
				{
				}
				num = (short)645595136;
				short num3 = num;
				return this.dataWideLTELTECheckbackTime_A42205.Max;
			}
			set
			{
				short num = (short)1052942700;
				short num2 = num;
				num = (short)1390649708;
				switch (num2 == num)
				{
				}
				num = (short)33751041;
				if (num != 0)
				{
				}
				num = (short)1512046592;
				if (num != 0)
				{
				}
				num = (short)355794944;
				short num3 = num;
				this.dataWideLTELTECheckbackTime_A42205.Max = value;
			}
		}

		// Token: 0x17005410 RID: 21520
		// (get) Token: 0x0600A76F RID: 42863 RVA: 0x009BC6D0 File Offset: 0x009BA8D0
		// (set) Token: 0x0600A770 RID: 42864 RVA: 0x009BC788 File Offset: 0x009BA988
		internal int DataWideLTELTECheckbackTime_A42205Step
		{
			get
			{
				short num = (short)1611333633;
				if (num != 0)
				{
				}
				num = (short)1111397126;
				short num2 = num;
				num = (short)7443206;
				switch (num2 == num)
				{
				}
				num = (short)1175715840;
				if (num != 0)
				{
				}
				num = (short)697434112;
				short num3 = num;
				return this.dataWideLTELTECheckbackTime_A42205.StepSize;
			}
			set
			{
				short num = (short)116294514;
				short num2 = num;
				num = (short)967476082;
				switch (num2 == num)
				{
				}
				num = (short)1162543104;
				if (num != 0)
				{
				}
				num = (short)235995137;
				if (num != 0)
				{
				}
				num = (short)1473380352;
				short num3 = num;
				this.dataWideLTELTECheckbackTime_A42205.StepSize = value;
			}
		}

		// Token: 0x17005411 RID: 21521
		// (get) Token: 0x0600A771 RID: 42865 RVA: 0x009BC840 File Offset: 0x009BAA40
		// (set) Token: 0x0600A772 RID: 42866 RVA: 0x009BC8F8 File Offset: 0x009BAAF8
		public bool DataWideLTELTECheckbackTime_A42205_Applicable
		{
			get
			{
				short num = (short)1607589741;
				short num2 = num;
				num = (short)1993072493;
				switch (num2 == num)
				{
				}
				num = (short)1662779392;
				if (num != 0)
				{
				}
				num = (short)1911488513;
				if (num != 0)
				{
				}
				num = (short)1541799936;
				short num3 = num;
				return this.dataWideLTELTECheckbackTime_A42205.Applicable;
			}
			set
			{
				short num = (short)349700097;
				if (num != 0)
				{
				}
				num = (short)1818246033;
				short num2 = num;
				num = (short)2008234897;
				switch (num2 == num)
				{
				}
				num = (short)826736640;
				if (num != 0)
				{
				}
				num = (short)385482752;
				short num3 = num;
				this.dataWideLTELTECheckbackTime_A42205.Applicable = value;
			}
		}

		// Token: 0x17005412 RID: 21522
		// (get) Token: 0x0600A773 RID: 42867 RVA: 0x009BC9AC File Offset: 0x009BABAC
		// (set) Token: 0x0600A774 RID: 42868 RVA: 0x009BCA60 File Offset: 0x009BAC60
		public bool DataWideLTELTECheckbackTime_A42205_Valid
		{
			get
			{
				short num = (short)1578438385;
				short num2 = num;
				num = (short)1704267505;
				switch (num2 == num)
				{
				}
				num = (short)187105281;
				if (num != 0)
				{
				}
				num = (short)1078591488;
				if (num != 0)
				{
				}
				num = (short)1164509184;
				short num3 = num;
				return this.dataWideLTELTECheckbackTime_A42205.Valid;
			}
			set
			{
				short num = (short)1941704363;
				short num2 = num;
				num = (short)203034283;
				switch (num2 == num)
				{
				}
				num = (short)109314048;
				if (num != 0)
				{
				}
				num = (short)246153217;
				if (num != 0)
				{
				}
				num = (short)287113216;
				short num3 = num;
				this.dataWideLTELTECheckbackTime_A42205.Valid = value;
			}
		}

		// Token: 0x17005413 RID: 21523
		// (get) Token: 0x0600A775 RID: 42869 RVA: 0x009BCB18 File Offset: 0x009BAD18
		// (set) Token: 0x0600A776 RID: 42870 RVA: 0x009BCBCC File Offset: 0x009BADCC
		public bool DataWideLTELTECheckbackTime_A42205_Visible
		{
			get
			{
				short num = (short)249233409;
				if (num != 0)
				{
				}
				num = (short)184593254;
				short num2 = num;
				num = (short)324643686;
				switch (num2 == num)
				{
				}
				num = (short)1438187520;
				if (num != 0)
				{
				}
				num = (short)1382744064;
				short num3 = num;
				return this.dataWideLTELTECheckbackTime_A42205.Visible;
			}
			set
			{
				short num = (short)2075918337;
				if (num != 0)
				{
				}
				num = (short)1840953311;
				short num2 = num;
				num = (short)619165663;
				switch (num2 == num)
				{
				}
				num = (short)1068695552;
				if (num != 0)
				{
				}
				num = (short)1306329088;
				short num3 = num;
				this.dataWideLTELTECheckbackTime_A42205.Visible = value;
			}
		}

		// Token: 0x17005414 RID: 21524
		// (get) Token: 0x0600A777 RID: 42871 RVA: 0x009BCC84 File Offset: 0x009BAE84
		// (set) Token: 0x0600A778 RID: 42872 RVA: 0x009BCD3C File Offset: 0x009BAF3C
		public bool DataWideLTELTECheckbackTime_A42205_Editable
		{
			get
			{
				short num = (short)734174849;
				short num2 = num;
				num = (short)993369729;
				switch (num2 == num)
				{
				}
				num = (short)1005387777;
				if (num != 0)
				{
				}
				num = (short)245104640;
				if (num != 0)
				{
				}
				num = (short)1897660416;
				short num3 = num;
				return this.dataWideLTELTECheckbackTime_A42205.Editable;
			}
			set
			{
				short num = (short)998364253;
				short num2 = num;
				num = (short)282776669;
				switch (num2 == num)
				{
				}
				num = (short)1159462913;
				if (num != 0)
				{
				}
				num = (short)292093952;
				if (num != 0)
				{
				}
				num = (short)153747456;
				short num3 = num;
				this.dataWideLTELTECheckbackTime_A42205.Editable = value;
			}
		}

		// Token: 0x17005415 RID: 21525
		// (get) Token: 0x0600A779 RID: 42873 RVA: 0x009BCDF4 File Offset: 0x009BAFF4
		internal string DataWideLTELTECheckbackTime_A42205_UILabel
		{
			get
			{
				short num = (short)1011627771;
				short num2 = num;
				num = (short)1068185339;
				switch (num2 == num)
				{
				}
				num = (short)1064697857;
				if (num != 0)
				{
				}
				num = (short)1318387712;
				if (num != 0)
				{
				}
				num = (short)693698560;
				short num3 = num;
				return this.dataWideLTELTECheckbackTime_A42205.UIName;
			}
		}

		// Token: 0x17005416 RID: 21526
		// (get) Token: 0x0600A77A RID: 42874 RVA: 0x009BCEAC File Offset: 0x009BB0AC
		// (set) Token: 0x0600A77B RID: 42875 RVA: 0x009BCF60 File Offset: 0x009BB160
		internal bool DataWideLTELTECheckbackTime_A42205_HiddenStatic
		{
			get
			{
				short num = (short)1621703159;
				short num2 = num;
				num = (short)1245264375;
				switch (num2 == num)
				{
				}
				num = (short)449511424;
				if (num != 0)
				{
				}
				num = (short)2056978433;
				if (num != 0)
				{
				}
				num = (short)1915486208;
				short num3 = num;
				return this.dataWideLTELTECheckbackTime_A42205.HiddenStatic;
			}
			set
			{
				short num = (short)1436242979;
				short num2 = num;
				num = (short)696931363;
				switch (num2 == num)
				{
				}
				num = (short)1050673153;
				if (num != 0)
				{
				}
				num = (short)236584960;
				if (num != 0)
				{
				}
				num = (short)1657798656;
				short num3 = num;
				this.dataWideLTELTECheckbackTime_A42205.HiddenStatic = value;
			}
		}

		// Token: 0x17005417 RID: 21527
		// (get) Token: 0x0600A77C RID: 42876 RVA: 0x009BD014 File Offset: 0x009BB214
		// (set) Token: 0x0600A77D RID: 42877 RVA: 0x009BD0C8 File Offset: 0x009BB2C8
		internal bool DataWideLTELTECheckbackTime_A42205_HiddenDynamic
		{
			get
			{
				short num = (short)1268571864;
				short num2 = num;
				num = (short)1313595096;
				switch (num2 == num)
				{
				}
				num = (short)949354496;
				if (num != 0)
				{
				}
				num = (short)802291713;
				if (num != 0)
				{
				}
				num = (short)256966656;
				short num3 = num;
				return this.dataWideLTELTECheckbackTime_A42205.HiddenDynamic;
			}
			set
			{
				short num = (short)823904309;
				short num2 = num;
				num = (short)396609589;
				switch (num2 == num)
				{
				}
				num = (short)1475215361;
				if (num != 0)
				{
				}
				num = (short)1789526016;
				if (num != 0)
				{
				}
				num = (short)1860829184;
				short num3 = num;
				this.dataWideLTELTECheckbackTime_A42205.HiddenDynamic = value;
			}
		}

		// Token: 0x17005418 RID: 21528
		// (get) Token: 0x0600A77E RID: 42878 RVA: 0x009BD17C File Offset: 0x009BB37C
		public bool DataWideLTELTECheckbackTime_A42205_HasDiffs
		{
			get
			{
				short num = (short)1551982398;
				short num2 = num;
				num = (short)206528318;
				switch (num2 == num)
				{
				}
				num = (short)929628161;
				if (num != 0)
				{
				}
				num = (short)53936128;
				if (num != 0)
				{
				}
				num = (short)533921792;
				short num3 = num;
				return this.dataWideLTELTECheckbackTime_A42205._HasDiffs;
			}
		}

		// Token: 0x17005419 RID: 21529
		// (get) Token: 0x0600A77F RID: 42879 RVA: 0x009BD234 File Offset: 0x009BB434
		// (set) Token: 0x0600A780 RID: 42880 RVA: 0x009BD2E8 File Offset: 0x009BB4E8
		public int DataWideLTEOutOfRangeThresholdTime_A42206Value
		{
			get
			{
				short num = (short)501481473;
				if (num != 0)
				{
				}
				num = (short)1380875407;
				short num2 = num;
				num = (short)423394447;
				switch (num2 == num)
				{
				}
				num = (short)923467776;
				if (num != 0)
				{
				}
				num = (short)319225856;
				short num3 = num;
				return this.dataWideLTEOutOfRangeThresholdTime_A42206.Value;
			}
			set
			{
				short num = (short)1076462847;
				short num2 = num;
				num = (short)2102363391;
				switch (num2 == num)
				{
				}
				num = (short)569376769;
				if (num != 0)
				{
				}
				num = (short)1042874368;
				if (num != 0)
				{
				}
				num = (short)1186398208;
				short num3 = num;
				this.dataWideLTEOutOfRangeThresholdTime_A42206.Value = value;
			}
		}

		// Token: 0x1700541A RID: 21530
		// (get) Token: 0x0600A781 RID: 42881 RVA: 0x009BD398 File Offset: 0x009BB598
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideLTEOutOfRangeThresholdTime_A42206
		{
			get
			{
				short num = (short)1344945521;
				short num2 = num;
				num = (short)1243757937;
				switch (num2 == num)
				{
				}
				num = (short)402587649;
				if (num != 0)
				{
				}
				num = (short)370540544;
				if (num != 0)
				{
				}
				num = (short)455671808;
				short num3 = num;
				return this.dataWideLTEOutOfRangeThresholdTime_A42206;
			}
		}

		// Token: 0x1700541B RID: 21531
		// (get) Token: 0x0600A782 RID: 42882 RVA: 0x009BD44C File Offset: 0x009BB64C
		// (set) Token: 0x0600A783 RID: 42883 RVA: 0x009BD504 File Offset: 0x009BB704
		public string DataWideLTEOutOfRangeThresholdTime_A42206_UIValue
		{
			get
			{
				short num = (short)1481610544;
				short num2 = num;
				num = (short)1206228272;
				switch (num2 == num)
				{
				}
				num = (short)1047134209;
				if (num != 0)
				{
				}
				num = (short)1781006336;
				if (num != 0)
				{
				}
				num = (short)471203840;
				short num3 = num;
				return this.dataWideLTEOutOfRangeThresholdTime_A42206.UIValue;
			}
			set
			{
				short num = (short)1900026713;
				short num2 = num;
				num = (short)44964697;
				switch (num2 == num)
				{
				}
				num = (short)1818689537;
				if (num != 0)
				{
				}
				num = (short)1667694592;
				if (num != 0)
				{
				}
				num = (short)1679425536;
				short num3 = num;
				this.dataWideLTEOutOfRangeThresholdTime_A42206.UIValue = value;
			}
		}

		// Token: 0x1700541C RID: 21532
		// (get) Token: 0x0600A784 RID: 42884 RVA: 0x009BD5B8 File Offset: 0x009BB7B8
		// (set) Token: 0x0600A785 RID: 42885 RVA: 0x009BD670 File Offset: 0x009BB870
		internal int DataWideLTEOutOfRangeThresholdTime_A42206Min
		{
			get
			{
				short num = (short)2038193597;
				short num2 = num;
				num = (short)766008765;
				switch (num2 == num)
				{
				}
				num = (short)1716322305;
				if (num != 0)
				{
				}
				num = (short)1666056192;
				if (num != 0)
				{
				}
				num = (short)894500864;
				short num3 = num;
				return this.dataWideLTEOutOfRangeThresholdTime_A42206.Min;
			}
			set
			{
				short num = (short)1961648623;
				short num2 = num;
				num = (short)616391151;
				switch (num2 == num)
				{
				}
				num = (short)852033537;
				if (num != 0)
				{
				}
				num = (short)2028339200;
				if (num != 0)
				{
				}
				num = (short)293535744;
				short num3 = num;
				this.dataWideLTEOutOfRangeThresholdTime_A42206.Min = value;
			}
		}

		// Token: 0x1700541D RID: 21533
		// (get) Token: 0x0600A786 RID: 42886 RVA: 0x009BD720 File Offset: 0x009BB920
		// (set) Token: 0x0600A787 RID: 42887 RVA: 0x009BD7D8 File Offset: 0x009BB9D8
		internal int DataWideLTEOutOfRangeThresholdTime_A42206Max
		{
			get
			{
				short num = (short)1045729712;
				short num2 = num;
				num = (short)1652593072;
				switch (num2 == num)
				{
				}
				num = (short)1058209792;
				if (num != 0)
				{
				}
				num = (short)768278529;
				if (num != 0)
				{
				}
				num = (short)1541799936;
				short num3 = num;
				return this.dataWideLTEOutOfRangeThresholdTime_A42206.Max;
			}
			set
			{
				short num = (short)1627526515;
				short num2 = num;
				num = (short)13505907;
				switch (num2 == num)
				{
				}
				num = (short)712900608;
				if (num != 0)
				{
				}
				num = (short)525991937;
				if (num != 0)
				{
				}
				num = (short)1118437376;
				short num3 = num;
				this.dataWideLTEOutOfRangeThresholdTime_A42206.Max = value;
			}
		}

		// Token: 0x1700541E RID: 21534
		// (get) Token: 0x0600A788 RID: 42888 RVA: 0x009BD890 File Offset: 0x009BBA90
		// (set) Token: 0x0600A789 RID: 42889 RVA: 0x009BD948 File Offset: 0x009BBB48
		internal int DataWideLTEOutOfRangeThresholdTime_A42206Step
		{
			get
			{
				short num = (short)1813592122;
				short num2 = num;
				num = (short)888485946;
				switch (num2 == num)
				{
				}
				num = (short)727580673;
				if (num != 0)
				{
				}
				num = (short)1305411584;
				if (num != 0)
				{
				}
				num = (short)1177026560;
				short num3 = num;
				return this.dataWideLTEOutOfRangeThresholdTime_A42206.StepSize;
			}
			set
			{
				short num = (short)1878080703;
				short num2 = num;
				num = (short)1417100479;
				switch (num2 == num)
				{
				}
				num = (short)853278720;
				if (num != 0)
				{
				}
				num = (short)410648577;
				if (num != 0)
				{
				}
				num = (short)2008481792;
				short num3 = num;
				this.dataWideLTEOutOfRangeThresholdTime_A42206.StepSize = value;
			}
		}

		// Token: 0x1700541F RID: 21535
		// (get) Token: 0x0600A78A RID: 42890 RVA: 0x009BD9FC File Offset: 0x009BBBFC
		// (set) Token: 0x0600A78B RID: 42891 RVA: 0x009BDAB4 File Offset: 0x009BBCB4
		public bool DataWideLTEOutOfRangeThresholdTime_A42206_Applicable
		{
			get
			{
				short num = (short)386465793;
				if (num != 0)
				{
				}
				num = (short)1355850752;
				short num2 = num;
				num = (short)1412342784;
				switch (num2 == num)
				{
				}
				num = (short)2113798144;
				if (num != 0)
				{
				}
				num = (short)1261764608;
				short num3 = num;
				return this.dataWideLTEOutOfRangeThresholdTime_A42206.Applicable;
			}
			set
			{
				short num = (short)2099773441;
				if (num != 0)
				{
				}
				num = (short)884503540;
				short num2 = num;
				num = (short)274756596;
				switch (num2 == num)
				{
				}
				num = (short)1088618496;
				if (num != 0)
				{
				}
				num = (short)975372288;
				short num3 = num;
				this.dataWideLTEOutOfRangeThresholdTime_A42206.Applicable = value;
			}
		}

		// Token: 0x17005420 RID: 21536
		// (get) Token: 0x0600A78C RID: 42892 RVA: 0x009BDB6C File Offset: 0x009BBD6C
		// (set) Token: 0x0600A78D RID: 42893 RVA: 0x009BDC20 File Offset: 0x009BBE20
		public bool DataWideLTEOutOfRangeThresholdTime_A42206_Valid
		{
			get
			{
				short num = (short)1848336467;
				short num2 = num;
				num = (short)958226515;
				switch (num2 == num)
				{
				}
				num = (short)858324992;
				if (num != 0)
				{
				}
				num = (short)1951924225;
				if (num != 0)
				{
				}
				num = (short)1235091456;
				short num3 = num;
				return this.dataWideLTEOutOfRangeThresholdTime_A42206.Valid;
			}
			set
			{
				short num = (short)2085896602;
				short num2 = num;
				num = (short)1071071642;
				switch (num2 == num)
				{
				}
				num = (short)1976762369;
				if (num != 0)
				{
				}
				num = (short)1241448448;
				if (num != 0)
				{
				}
				num = (short)2112684032;
				short num3 = num;
				this.dataWideLTEOutOfRangeThresholdTime_A42206.Valid = value;
			}
		}

		// Token: 0x17005421 RID: 21537
		// (get) Token: 0x0600A78E RID: 42894 RVA: 0x009BDCD8 File Offset: 0x009BBED8
		// (set) Token: 0x0600A78F RID: 42895 RVA: 0x009BDD90 File Offset: 0x009BBF90
		public bool DataWideLTEOutOfRangeThresholdTime_A42206_Visible
		{
			get
			{
				short num = (short)122332803;
				short num2 = num;
				num = (short)414688899;
				switch (num2 == num)
				{
				}
				num = (short)1784545281;
				if (num != 0)
				{
				}
				num = (short)934805504;
				if (num != 0)
				{
				}
				num = (short)1882062848;
				short num3 = num;
				return this.dataWideLTEOutOfRangeThresholdTime_A42206.Visible;
			}
			set
			{
				short num = (short)37089169;
				short num2 = num;
				num = (short)986247057;
				switch (num2 == num)
				{
				}
				num = (short)1988624385;
				if (num != 0)
				{
				}
				num = (short)1254948864;
				if (num != 0)
				{
				}
				num = (short)414646272;
				short num3 = num;
				this.dataWideLTEOutOfRangeThresholdTime_A42206.Visible = value;
			}
		}

		// Token: 0x17005422 RID: 21538
		// (get) Token: 0x0600A790 RID: 42896 RVA: 0x009BDE48 File Offset: 0x009BC048
		// (set) Token: 0x0600A791 RID: 42897 RVA: 0x009BDF00 File Offset: 0x009BC100
		public bool DataWideLTEOutOfRangeThresholdTime_A42206_Editable
		{
			get
			{
				short num = (short)404651107;
				short num2 = num;
				num = (short)1779268707;
				switch (num2 == num)
				{
				}
				num = (short)1754071040;
				if (num != 0)
				{
				}
				num = (short)794361857;
				if (num != 0)
				{
				}
				num = (short)1038942208;
				short num3 = num;
				return this.dataWideLTEOutOfRangeThresholdTime_A42206.Editable;
			}
			set
			{
				short num = (short)1454591973;
				short num2 = num;
				num = (short)407654373;
				switch (num2 == num)
				{
				}
				num = (short)1979645953;
				if (num != 0)
				{
				}
				num = (short)510459904;
				short num3 = num;
				num = (short)537526272;
				if (num != 0)
				{
				}
				this.dataWideLTEOutOfRangeThresholdTime_A42206.Editable = value;
			}
		}

		// Token: 0x17005423 RID: 21539
		// (get) Token: 0x0600A792 RID: 42898 RVA: 0x009BDFB4 File Offset: 0x009BC1B4
		internal string DataWideLTEOutOfRangeThresholdTime_A42206_UILabel
		{
			get
			{
				short num = (short)644627967;
				short num2 = num;
				num = (short)2091793919;
				switch (num2 == num)
				{
				}
				num = (short)61472769;
				if (num != 0)
				{
				}
				num = (short)739311616;
				short num3 = num;
				num = (short)1396965376;
				if (num != 0)
				{
				}
				return this.dataWideLTEOutOfRangeThresholdTime_A42206.UIName;
			}
		}

		// Token: 0x17005424 RID: 21540
		// (get) Token: 0x0600A793 RID: 42899 RVA: 0x009BE06C File Offset: 0x009BC26C
		// (set) Token: 0x0600A794 RID: 42900 RVA: 0x009BE120 File Offset: 0x009BC320
		internal bool DataWideLTEOutOfRangeThresholdTime_A42206_HiddenStatic
		{
			get
			{
				short num = (short)312041881;
				short num2 = num;
				num = (short)458121625;
				switch (num2 == num)
				{
				}
				num = (short)734265344;
				if (num != 0)
				{
				}
				num = (short)895352832;
				short num3 = num;
				num = (short)92405761;
				if (num != 0)
				{
				}
				return this.dataWideLTEOutOfRangeThresholdTime_A42206.HiddenStatic;
			}
			set
			{
				short num = (short)1603534849;
				if (num != 0)
				{
				}
				num = (short)951586919;
				short num2 = num;
				num = (short)352850023;
				switch (num2 == num)
				{
				}
				num = (short)2004680704;
				short num3 = num;
				num = (short)1334050816;
				if (num != 0)
				{
				}
				this.dataWideLTEOutOfRangeThresholdTime_A42206.HiddenStatic = value;
			}
		}

		// Token: 0x17005425 RID: 21541
		// (get) Token: 0x0600A795 RID: 42901 RVA: 0x009BE1D8 File Offset: 0x009BC3D8
		// (set) Token: 0x0600A796 RID: 42902 RVA: 0x009BE288 File Offset: 0x009BC488
		internal bool DataWideLTEOutOfRangeThresholdTime_A42206_HiddenDynamic
		{
			get
			{
				short num = (short)27332565;
				short num2 = num;
				num = (short)1009848277;
				switch (num2 == num)
				{
				}
				num = (short)1238761473;
				if (num != 0)
				{
				}
				num = (short)1559560192;
				short num3 = num;
				num = (short)1986330624;
				if (num != 0)
				{
				}
				return this.dataWideLTEOutOfRangeThresholdTime_A42206.HiddenDynamic;
			}
			set
			{
				short num = (short)94896129;
				if (num != 0)
				{
				}
				num = (short)300626345;
				short num2 = num;
				num = (short)1095446953;
				switch (num2 == num)
				{
				}
				num = (short)803471360;
				short num3 = num;
				num = (short)2112290816;
				if (num != 0)
				{
				}
				this.dataWideLTEOutOfRangeThresholdTime_A42206.HiddenDynamic = value;
			}
		}

		// Token: 0x17005426 RID: 21542
		// (get) Token: 0x0600A797 RID: 42903 RVA: 0x009BE33C File Offset: 0x009BC53C
		public bool DataWideLTEOutOfRangeThresholdTime_A42206_HasDiffs
		{
			get
			{
				short num = (short)442619790;
				short num2 = num;
				num = (short)712497038;
				switch (num2 == num)
				{
				}
				num = (short)1864105984;
				if (num != 0)
				{
				}
				num = (short)582615040;
				short num3 = num;
				num = (short)1259995137;
				if (num != 0)
				{
				}
				return this.dataWideLTEOutOfRangeThresholdTime_A42206._HasDiffs;
			}
		}

		// Token: 0x17005427 RID: 21543
		// (get) Token: 0x0600A798 RID: 42904 RVA: 0x009BE3F0 File Offset: 0x009BC5F0
		// (set) Token: 0x0600A799 RID: 42905 RVA: 0x009BE4A4 File Offset: 0x009BC6A4
		public int DataWideLTEOffMaxDetachTime_A42207Value
		{
			get
			{
				short num = (short)2038235137;
				if (num != 0)
				{
				}
				num = (short)294966692;
				short num2 = num;
				num = (short)1455871396;
				switch (num2 == num)
				{
				}
				num = (short)544079872;
				short num3 = num;
				num = (short)1988755456;
				if (num != 0)
				{
				}
				return this.dataWideLTEOffMaxDetachTime_A42207.Value;
			}
			set
			{
				short num = (short)1840139428;
				short num2 = num;
				num = (short)1655196836;
				switch (num2 == num)
				{
				}
				num = (short)571670528;
				if (num != 0)
				{
				}
				num = (short)566099968;
				short num3 = num;
				num = (short)1229127681;
				if (num != 0)
				{
				}
				this.dataWideLTEOffMaxDetachTime_A42207.Value = value;
			}
		}

		// Token: 0x17005428 RID: 21544
		// (get) Token: 0x0600A79A RID: 42906 RVA: 0x009BE558 File Offset: 0x009BC758
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideLTEOffMaxDetachTime_A42207
		{
			get
			{
				short num = (short)1465647105;
				if (num != 0)
				{
				}
				num = (short)885191852;
				short num2 = num;
				num = (short)1314714796;
				switch (num2 == num)
				{
				}
				num = (short)719126528;
				short num3 = num;
				num = (short)243269632;
				if (num != 0)
				{
				}
				return this.dataWideLTEOffMaxDetachTime_A42207;
			}
		}

		// Token: 0x17005429 RID: 21545
		// (get) Token: 0x0600A79B RID: 42907 RVA: 0x009BE608 File Offset: 0x009BC808
		// (set) Token: 0x0600A79C RID: 42908 RVA: 0x009BE6BC File Offset: 0x009BC8BC
		public string DataWideLTEOffMaxDetachTime_A42207_UIValue
		{
			get
			{
				short num = (short)1214578689;
				if (num != 0)
				{
				}
				num = (short)1780856881;
				short num2 = num;
				num = (short)1242216497;
				switch (num2 == num)
				{
				}
				num = (short)1188036608;
				short num3 = num;
				num = (short)998703104;
				if (num != 0)
				{
				}
				return this.dataWideLTEOffMaxDetachTime_A42207.UIValue;
			}
			set
			{
				short num = (short)1092339842;
				short num2 = num;
				num = (short)691325058;
				switch (num2 == num)
				{
				}
				num = (short)1861156865;
				if (num != 0)
				{
				}
				num = (short)783876096;
				short num3 = num;
				num = (short)773062656;
				if (num != 0)
				{
				}
				this.dataWideLTEOffMaxDetachTime_A42207.UIValue = value;
			}
		}

		// Token: 0x1700542A RID: 21546
		// (get) Token: 0x0600A79D RID: 42909 RVA: 0x009BE770 File Offset: 0x009BC970
		// (set) Token: 0x0600A79E RID: 42910 RVA: 0x009BE824 File Offset: 0x009BCA24
		internal int DataWideLTEOffMaxDetachTime_A42207Min
		{
			get
			{
				short num = (short)1035393058;
				short num2 = num;
				num = (short)1701304354;
				switch (num2 == num)
				{
				}
				num = (short)1257373696;
				if (num != 0)
				{
				}
				num = (short)1833435136;
				short num3 = num;
				num = (short)833748993;
				if (num != 0)
				{
				}
				return this.dataWideLTEOffMaxDetachTime_A42207.Min;
			}
			set
			{
				short num = (short)1236276932;
				short num2 = num;
				num = (short)952243908;
				switch (num2 == num)
				{
				}
				num = (short)1063321600;
				if (num != 0)
				{
				}
				num = (short)1590296576;
				short num3 = num;
				num = (short)248315905;
				if (num != 0)
				{
				}
				this.dataWideLTEOffMaxDetachTime_A42207.Min = value;
			}
		}

		// Token: 0x1700542B RID: 21547
		// (get) Token: 0x0600A79F RID: 42911 RVA: 0x009BE8D8 File Offset: 0x009BCAD8
		// (set) Token: 0x0600A7A0 RID: 42912 RVA: 0x009BE98C File Offset: 0x009BCB8C
		internal int DataWideLTEOffMaxDetachTime_A42207Max
		{
			get
			{
				short num = (short)173322117;
				short num2 = num;
				num = (short)672444293;
				switch (num2 == num)
				{
				}
				num = (short)955121665;
				if (num != 0)
				{
				}
				num = (short)856096768;
				short num3 = num;
				num = (short)398065664;
				if (num != 0)
				{
				}
				return this.dataWideLTEOffMaxDetachTime_A42207.Max;
			}
			set
			{
				short num = (short)1040465253;
				short num2 = num;
				num = (short)1771715941;
				switch (num2 == num)
				{
				}
				num = (short)1668939776;
				if (num != 0)
				{
				}
				num = (short)584515584;
				short num3 = num;
				num = (short)819789825;
				if (num != 0)
				{
				}
				this.dataWideLTEOffMaxDetachTime_A42207.Max = value;
			}
		}

		// Token: 0x1700542C RID: 21548
		// (get) Token: 0x0600A7A1 RID: 42913 RVA: 0x009BEA44 File Offset: 0x009BCC44
		// (set) Token: 0x0600A7A2 RID: 42914 RVA: 0x009BEAF8 File Offset: 0x009BCCF8
		internal int DataWideLTEOffMaxDetachTime_A42207Step
		{
			get
			{
				short num = (short)999449531;
				short num2 = num;
				num = (short)1806132155;
				switch (num2 == num)
				{
				}
				num = (short)1930493952;
				if (num != 0)
				{
				}
				num = (short)869662720;
				short num3 = num;
				num = (short)214827009;
				if (num != 0)
				{
				}
				return this.dataWideLTEOffMaxDetachTime_A42207.StepSize;
			}
			set
			{
				short num = (short)1424411668;
				short num2 = num;
				num = (short)1531235348;
				switch (num2 == num)
				{
				}
				num = (short)326762497;
				if (num != 0)
				{
				}
				num = (short)1405550592;
				short num3 = num;
				num = (short)1980891136;
				if (num != 0)
				{
				}
				this.dataWideLTEOffMaxDetachTime_A42207.StepSize = value;
			}
		}

		// Token: 0x1700542D RID: 21549
		// (get) Token: 0x0600A7A3 RID: 42915 RVA: 0x009BEBB0 File Offset: 0x009BCDB0
		// (set) Token: 0x0600A7A4 RID: 42916 RVA: 0x009BEC64 File Offset: 0x009BCE64
		public bool DataWideLTEOffMaxDetachTime_A42207_Applicable
		{
			get
			{
				short num = (short)1278439289;
				short num2 = num;
				num = (short)1392734073;
				switch (num2 == num)
				{
				}
				num = (short)558825473;
				if (num != 0)
				{
				}
				num = (short)1479213056;
				short num3 = num;
				num = (short)473759744;
				if (num != 0)
				{
				}
				return this.dataWideLTEOffMaxDetachTime_A42207.Applicable;
			}
			set
			{
				short num = (short)1184418200;
				short num2 = num;
				num = (short)1562364312;
				switch (num2 == num)
				{
				}
				num = (short)303366145;
				if (num != 0)
				{
				}
				num = (short)158597120;
				short num3 = num;
				num = (short)2102722560;
				if (num != 0)
				{
				}
				this.dataWideLTEOffMaxDetachTime_A42207.Applicable = value;
			}
		}

		// Token: 0x1700542E RID: 21550
		// (get) Token: 0x0600A7A5 RID: 42917 RVA: 0x009BED18 File Offset: 0x009BCF18
		// (set) Token: 0x0600A7A6 RID: 42918 RVA: 0x009BEDCC File Offset: 0x009BCFCC
		public bool DataWideLTEOffMaxDetachTime_A42207_Valid
		{
			get
			{
				short num = (short)1087635457;
				if (num != 0)
				{
				}
				num = (short)490243603;
				short num2 = num;
				num = (short)91588115;
				switch (num2 == num)
				{
				}
				num = (short)1433731072;
				short num3 = num;
				num = (short)33095680;
				if (num != 0)
				{
				}
				return this.dataWideLTEOffMaxDetachTime_A42207.Valid;
			}
			set
			{
				short num = (short)293483849;
				short num2 = num;
				num = (short)80819529;
				switch (num2 == num)
				{
				}
				num = (short)1866727425;
				if (num != 0)
				{
				}
				num = (short)2035941376;
				short num3 = num;
				num = (short)62193664;
				if (num != 0)
				{
				}
				this.dataWideLTEOffMaxDetachTime_A42207.Valid = value;
			}
		}

		// Token: 0x1700542F RID: 21551
		// (get) Token: 0x0600A7A7 RID: 42919 RVA: 0x009BEE84 File Offset: 0x009BD084
		// (set) Token: 0x0600A7A8 RID: 42920 RVA: 0x009BEF40 File Offset: 0x009BD140
		public bool DataWideLTEOffMaxDetachTime_A42207_Visible
		{
			get
			{
				short num = (short)788603266;
				short num2 = num;
				num = (short)38543746;
				switch (num2 == num)
				{
				}
				num = (short)2127364097;
				if (num != 0)
				{
				}
				num = (short)1196818432;
				short num3 = num;
				num = (short)1262616576;
				if (num != 0)
				{
				}
				return this.dataWideLTEOffMaxDetachTime_A42207.Visible;
			}
			set
			{
				short num = (short)1713851837;
				short num2 = num;
				num = (short)1544048061;
				switch (num2 == num)
				{
				}
				num = (short)1852375040;
				if (num != 0)
				{
				}
				num = (short)99155968;
				short num3 = num;
				num = (short)36503553;
				if (num != 0)
				{
				}
				this.dataWideLTEOffMaxDetachTime_A42207.Visible = value;
			}
		}

		// Token: 0x17005430 RID: 21552
		// (get) Token: 0x0600A7A9 RID: 42921 RVA: 0x009BEFF4 File Offset: 0x009BD1F4
		// (set) Token: 0x0600A7AA RID: 42922 RVA: 0x009BF0A8 File Offset: 0x009BD2A8
		public bool DataWideLTEOffMaxDetachTime_A42207_Editable
		{
			get
			{
				short num = (short)1205872158;
				short num2 = num;
				num = (short)603530782;
				switch (num2 == num)
				{
				}
				num = (short)808845313;
				if (num != 0)
				{
				}
				num = (short)1287323648;
				short num3 = num;
				num = (short)2028535808;
				if (num != 0)
				{
				}
				return this.dataWideLTEOffMaxDetachTime_A42207.Editable;
			}
			set
			{
				short num = (short)579589815;
				short num2 = num;
				num = (short)259315383;
				switch (num2 == num)
				{
				}
				num = (short)1808990209;
				if (num != 0)
				{
				}
				num = (short)869924864;
				short num3 = num;
				num = (short)1266286592;
				if (num != 0)
				{
				}
				this.dataWideLTEOffMaxDetachTime_A42207.Editable = value;
			}
		}

		// Token: 0x17005431 RID: 21553
		// (get) Token: 0x0600A7AB RID: 42923 RVA: 0x009BF15C File Offset: 0x009BD35C
		internal string DataWideLTEOffMaxDetachTime_A42207_UILabel
		{
			get
			{
				short num = (short)1475858923;
				short num2 = num;
				num = (short)934138347;
				switch (num2 == num)
				{
				}
				num = (short)714539008;
				if (num != 0)
				{
				}
				num = (short)1723662336;
				short num3 = num;
				num = (short)465960961;
				if (num != 0)
				{
				}
				return this.dataWideLTEOffMaxDetachTime_A42207.UIName;
			}
		}

		// Token: 0x17005432 RID: 21554
		// (get) Token: 0x0600A7AC RID: 42924 RVA: 0x009BF210 File Offset: 0x009BD410
		// (set) Token: 0x0600A7AD RID: 42925 RVA: 0x009BF2C8 File Offset: 0x009BD4C8
		internal bool DataWideLTEOffMaxDetachTime_A42207_HiddenStatic
		{
			get
			{
				short num = (short)931856385;
				if (num != 0)
				{
				}
				num = (short)700843877;
				short num2 = num;
				num = (short)832505701;
				switch (num2 == num)
				{
				}
				num = (short)1849098240;
				short num3 = num;
				num = (short)596508672;
				if (num != 0)
				{
				}
				return this.dataWideLTEOffMaxDetachTime_A42207.HiddenStatic;
			}
			set
			{
				short num = (short)1174881258;
				short num2 = num;
				num = (short)913261546;
				switch (num2 == num)
				{
				}
				num = (short)909770752;
				if (num != 0)
				{
				}
				num = (short)921174016;
				short num3 = num;
				num = (short)366149633;
				if (num != 0)
				{
				}
				this.dataWideLTEOffMaxDetachTime_A42207.HiddenStatic = value;
			}
		}

		// Token: 0x17005433 RID: 21555
		// (get) Token: 0x0600A7AE RID: 42926 RVA: 0x009BF37C File Offset: 0x009BD57C
		// (set) Token: 0x0600A7AF RID: 42927 RVA: 0x009BF430 File Offset: 0x009BD630
		internal bool DataWideLTEOffMaxDetachTime_A42207_HiddenDynamic
		{
			get
			{
				short num = (short)1024671277;
				short num2 = num;
				num = (short)610549293;
				switch (num2 == num)
				{
				}
				num = (short)582483969;
				if (num != 0)
				{
				}
				num = (short)73662464;
				short num3 = num;
				num = (short)2091057152;
				if (num != 0)
				{
				}
				return this.dataWideLTEOffMaxDetachTime_A42207.HiddenDynamic;
			}
			set
			{
				short num = (short)726504130;
				short num2 = num;
				num = (short)1568838338;
				switch (num2 == num)
				{
				}
				num = (short)980353025;
				if (num != 0)
				{
				}
				num = (short)1121189888;
				short num3 = num;
				num = (short)831782912;
				if (num != 0)
				{
				}
				this.dataWideLTEOffMaxDetachTime_A42207.HiddenDynamic = value;
			}
		}

		// Token: 0x17005434 RID: 21556
		// (get) Token: 0x0600A7B0 RID: 42928 RVA: 0x009BF4E8 File Offset: 0x009BD6E8
		public bool DataWideLTEOffMaxDetachTime_A42207_HasDiffs
		{
			get
			{
				short num = (short)45650040;
				short num2 = num;
				num = (short)786665592;
				switch (num2 == num)
				{
				}
				num = (short)1970929664;
				if (num != 0)
				{
				}
				num = (short)1901002752;
				short num3 = num;
				num = (short)1168506881;
				if (num != 0)
				{
				}
				return this.dataWideLTEOffMaxDetachTime_A42207._HasDiffs;
			}
		}

		// Token: 0x17005435 RID: 21557
		// (get) Token: 0x0600A7B1 RID: 42929 RVA: 0x009BF5A0 File Offset: 0x009BD7A0
		// (set) Token: 0x0600A7B2 RID: 42930 RVA: 0x009BF654 File Offset: 0x009BD854
		public int DataWideLTEModeChangeMaxDetachTime_A42208Value
		{
			get
			{
				short num = (short)691292774;
				short num2 = num;
				num = (short)1145064038;
				switch (num2 == num)
				{
				}
				num = (short)989003776;
				if (num != 0)
				{
				}
				num = (short)25755648;
				short num3 = num;
				num = (short)1826291713;
				if (num != 0)
				{
				}
				return this.dataWideLTEModeChangeMaxDetachTime_A42208.Value;
			}
			set
			{
				short num = (short)1878710208;
				short num2 = num;
				num = (short)354932672;
				switch (num2 == num)
				{
				}
				num = (short)32243712;
				if (num != 0)
				{
				}
				num = (short)272891904;
				short num3 = num;
				num = (short)849149953;
				if (num != 0)
				{
				}
				this.dataWideLTEModeChangeMaxDetachTime_A42208.Value = value;
			}
		}

		// Token: 0x17005436 RID: 21558
		// (get) Token: 0x0600A7B3 RID: 42931 RVA: 0x009BF70C File Offset: 0x009BD90C
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideLTEModeChangeMaxDetachTime_A42208
		{
			get
			{
				short num = (short)386174707;
				short num2 = num;
				num = (short)452824819;
				switch (num2 == num)
				{
				}
				num = (short)1893662721;
				if (num != 0)
				{
				}
				num = (short)741343232;
				short num3 = num;
				num = (short)1243283456;
				if (num != 0)
				{
				}
				return this.dataWideLTEModeChangeMaxDetachTime_A42208;
			}
		}

		// Token: 0x17005437 RID: 21559
		// (get) Token: 0x0600A7B4 RID: 42932 RVA: 0x009BF7BC File Offset: 0x009BD9BC
		// (set) Token: 0x0600A7B5 RID: 42933 RVA: 0x009BF870 File Offset: 0x009BDA70
		public string DataWideLTEModeChangeMaxDetachTime_A42208_UIValue
		{
			get
			{
				short num = (short)661389313;
				if (num != 0)
				{
				}
				num = (short)1339984437;
				short num2 = num;
				num = (short)443517493;
				switch (num2 == num)
				{
				}
				num = (short)2021195776;
				short num3 = num;
				num = (short)169738240;
				if (num != 0)
				{
				}
				return this.dataWideLTEModeChangeMaxDetachTime_A42208.UIValue;
			}
			set
			{
				short num = (short)2042232228;
				short num2 = num;
				num = (short)1316421028;
				switch (num2 == num)
				{
				}
				num = (short)1062338561;
				if (num != 0)
				{
				}
				num = (short)854327296;
				short num3 = num;
				num = (short)891289600;
				if (num != 0)
				{
				}
				this.dataWideLTEModeChangeMaxDetachTime_A42208.UIValue = value;
			}
		}

		// Token: 0x17005438 RID: 21560
		// (get) Token: 0x0600A7B6 RID: 42934 RVA: 0x009BF924 File Offset: 0x009BDB24
		// (set) Token: 0x0600A7B7 RID: 42935 RVA: 0x009BF9D8 File Offset: 0x009BDBD8
		internal int DataWideLTEModeChangeMaxDetachTime_A42208Min
		{
			get
			{
				short num = (short)960326695;
				short num2 = num;
				num = (short)101608487;
				switch (num2 == num)
				{
				}
				num = (short)2100887552;
				if (num != 0)
				{
				}
				num = (short)1590034432;
				short num3 = num;
				num = (short)1445724161;
				if (num != 0)
				{
				}
				return this.dataWideLTEModeChangeMaxDetachTime_A42208.Min;
			}
			set
			{
				short num = (short)322925866;
				short num2 = num;
				num = (short)248476970;
				switch (num2 == num)
				{
				}
				num = (short)606273536;
				if (num != 0)
				{
				}
				num = (short)958005248;
				short num3 = num;
				num = (short)1424752641;
				if (num != 0)
				{
				}
				this.dataWideLTEModeChangeMaxDetachTime_A42208.Min = value;
			}
		}

		// Token: 0x17005439 RID: 21561
		// (get) Token: 0x0600A7B8 RID: 42936 RVA: 0x009BFA90 File Offset: 0x009BDC90
		// (set) Token: 0x0600A7B9 RID: 42937 RVA: 0x009BFB44 File Offset: 0x009BDD44
		internal int DataWideLTEModeChangeMaxDetachTime_A42208Max
		{
			get
			{
				short num = (short)2067008456;
				short num2 = num;
				num = (short)91294664;
				switch (num2 == num)
				{
				}
				num = (short)713752577;
				if (num != 0)
				{
				}
				num = (short)860422144;
				short num3 = num;
				num = (short)1319436288;
				if (num != 0)
				{
				}
				return this.dataWideLTEModeChangeMaxDetachTime_A42208.Max;
			}
			set
			{
				short num = (short)1010351522;
				short num2 = num;
				num = (short)1781251490;
				switch (num2 == num)
				{
				}
				num = (short)472645633;
				if (num != 0)
				{
				}
				num = (short)1642659840;
				short num3 = num;
				num = (short)423231488;
				if (num != 0)
				{
				}
				this.dataWideLTEModeChangeMaxDetachTime_A42208.Max = value;
			}
		}

		// Token: 0x1700543A RID: 21562
		// (get) Token: 0x0600A7BA RID: 42938 RVA: 0x009BFBFC File Offset: 0x009BDDFC
		// (set) Token: 0x0600A7BB RID: 42939 RVA: 0x009BFCB0 File Offset: 0x009BDEB0
		internal int DataWideLTEModeChangeMaxDetachTime_A42208Step
		{
			get
			{
				short num = (short)153175476;
				short num2 = num;
				num = (short)694896052;
				switch (num2 == num)
				{
				}
				num = (short)209190913;
				if (num != 0)
				{
				}
				num = (short)1183645696;
				short num3 = num;
				num = (short)731709440;
				if (num != 0)
				{
				}
				return this.dataWideLTEModeChangeMaxDetachTime_A42208.StepSize;
			}
			set
			{
				short num = (short)1385369881;
				short num2 = num;
				num = (short)1839468825;
				switch (num2 == num)
				{
				}
				num = (short)1762459648;
				if (num != 0)
				{
				}
				num = (short)55312384;
				short num3 = num;
				num = (short)1897922561;
				if (num != 0)
				{
				}
				this.dataWideLTEModeChangeMaxDetachTime_A42208.StepSize = value;
			}
		}

		// Token: 0x1700543B RID: 21563
		// (get) Token: 0x0600A7BC RID: 42940 RVA: 0x009BFD64 File Offset: 0x009BDF64
		// (set) Token: 0x0600A7BD RID: 42941 RVA: 0x009BFE18 File Offset: 0x009BE018
		public bool DataWideLTEModeChangeMaxDetachTime_A42208_Applicable
		{
			get
			{
				short num = (short)1190358339;
				short num2 = num;
				num = (short)2004970819;
				switch (num2 == num)
				{
				}
				num = (short)1476984833;
				if (num != 0)
				{
				}
				num = (short)274268160;
				short num3 = num;
				num = (short)1528037376;
				if (num != 0)
				{
				}
				return this.dataWideLTEModeChangeMaxDetachTime_A42208.Applicable;
			}
			set
			{
				short num = (short)1648417150;
				short num2 = num;
				num = (short)1298258302;
				switch (num2 == num)
				{
				}
				num = (short)203161600;
				if (num != 0)
				{
				}
				num = (short)1406337024;
				short num3 = num;
				num = (short)2048065537;
				if (num != 0)
				{
				}
				this.dataWideLTEModeChangeMaxDetachTime_A42208.Applicable = value;
			}
		}

		// Token: 0x1700543C RID: 21564
		// (get) Token: 0x0600A7BE RID: 42942 RVA: 0x009BFED0 File Offset: 0x009BE0D0
		// (set) Token: 0x0600A7BF RID: 42943 RVA: 0x009BFF88 File Offset: 0x009BE188
		public bool DataWideLTEModeChangeMaxDetachTime_A42208_Valid
		{
			get
			{
				short num = (short)912346352;
				short num2 = num;
				num = (short)1712999664;
				switch (num2 == num)
				{
				}
				num = (short)1868300289;
				if (num != 0)
				{
				}
				num = (short)2099380224;
				short num3 = num;
				num = (short)400818176;
				if (num != 0)
				{
				}
				return this.dataWideLTEModeChangeMaxDetachTime_A42208.Valid;
			}
			set
			{
				short num = (short)931618839;
				short num2 = num;
				num = (short)1875402775;
				switch (num2 == num)
				{
				}
				num = (short)1131937792;
				if (num != 0)
				{
				}
				num = (short)1967783936;
				short num3 = num;
				num = (short)1768226817;
				if (num != 0)
				{
				}
				this.dataWideLTEModeChangeMaxDetachTime_A42208.Valid = value;
			}
		}

		// Token: 0x1700543D RID: 21565
		// (get) Token: 0x0600A7C0 RID: 42944 RVA: 0x009C003C File Offset: 0x009BE23C
		// (set) Token: 0x0600A7C1 RID: 42945 RVA: 0x009C00F4 File Offset: 0x009BE2F4
		public bool DataWideLTEModeChangeMaxDetachTime_A42208_Visible
		{
			get
			{
				short num = (short)1499529217;
				if (num != 0)
				{
				}
				num = (short)272442874;
				short num2 = num;
				num = (short)425993722;
				switch (num2 == num)
				{
				}
				num = (short)1845166080;
				short num3 = num;
				num = (short)712835072;
				if (num != 0)
				{
				}
				return this.dataWideLTEModeChangeMaxDetachTime_A42208.Visible;
			}
			set
			{
				short num = (short)2087318651;
				short num2 = num;
				num = (short)782038139;
				switch (num2 == num)
				{
				}
				num = (short)1896742913;
				if (num != 0)
				{
				}
				num = (short)1108869120;
				short num3 = num;
				num = (short)1616838656;
				if (num != 0)
				{
				}
				this.dataWideLTEModeChangeMaxDetachTime_A42208.Visible = value;
			}
		}

		// Token: 0x1700543E RID: 21566
		// (get) Token: 0x0600A7C2 RID: 42946 RVA: 0x009C01AC File Offset: 0x009BE3AC
		// (set) Token: 0x0600A7C3 RID: 42947 RVA: 0x009C0260 File Offset: 0x009BE460
		public bool DataWideLTEModeChangeMaxDetachTime_A42208_Editable
		{
			get
			{
				short num = (short)1546991246;
				short num2 = num;
				num = (short)896611982;
				switch (num2 == num)
				{
				}
				num = (short)629604353;
				if (num != 0)
				{
				}
				num = (short)1387921408;
				short num3 = num;
				num = (short)1198522368;
				if (num != 0)
				{
				}
				return this.dataWideLTEModeChangeMaxDetachTime_A42208.Editable;
			}
			set
			{
				short num = (short)1514863767;
				short num2 = num;
				num = (short)411827351;
				switch (num2 == num)
				{
				}
				num = (short)27000833;
				if (num != 0)
				{
				}
				num = (short)1492713472;
				short num3 = num;
				num = (short)1162870784;
				if (num != 0)
				{
				}
				this.dataWideLTEModeChangeMaxDetachTime_A42208.Editable = value;
			}
		}

		// Token: 0x1700543F RID: 21567
		// (get) Token: 0x0600A7C4 RID: 42948 RVA: 0x009C0318 File Offset: 0x009BE518
		internal string DataWideLTEModeChangeMaxDetachTime_A42208_UILabel
		{
			get
			{
				short num = (short)1421440390;
				short num2 = num;
				num = (short)55276934;
				switch (num2 == num)
				{
				}
				num = (short)867172352;
				if (num != 0)
				{
				}
				num = (short)1596063744;
				short num3 = num;
				num = (short)916783105;
				if (num != 0)
				{
				}
				return this.dataWideLTEModeChangeMaxDetachTime_A42208.UIName;
			}
		}

		// Token: 0x17005440 RID: 21568
		// (get) Token: 0x0600A7C5 RID: 42949 RVA: 0x009C03D0 File Offset: 0x009BE5D0
		// (set) Token: 0x0600A7C6 RID: 42950 RVA: 0x009C0484 File Offset: 0x009BE684
		internal bool DataWideLTEModeChangeMaxDetachTime_A42208_HiddenStatic
		{
			get
			{
				short num = (short)1230976778;
				short num2 = num;
				num = (short)1702049546;
				switch (num2 == num)
				{
				}
				num = (short)1620377600;
				if (num != 0)
				{
				}
				num = (short)2069233664;
				short num3 = num;
				num = (short)1122566145;
				if (num != 0)
				{
				}
				return this.dataWideLTEModeChangeMaxDetachTime_A42208.HiddenStatic;
			}
			set
			{
				short num = (short)634463737;
				short num2 = num;
				num = (short)2010588665;
				switch (num2 == num)
				{
				}
				num = (short)312868865;
				if (num != 0)
				{
				}
				num = (short)889061376;
				short num3 = num;
				num = (short)1976303616;
				if (num != 0)
				{
				}
				this.dataWideLTEModeChangeMaxDetachTime_A42208.HiddenStatic = value;
			}
		}

		// Token: 0x17005441 RID: 21569
		// (get) Token: 0x0600A7C7 RID: 42951 RVA: 0x009C0538 File Offset: 0x009BE738
		// (set) Token: 0x0600A7C8 RID: 42952 RVA: 0x009C05EC File Offset: 0x009BE7EC
		internal bool DataWideLTEModeChangeMaxDetachTime_A42208_HiddenDynamic
		{
			get
			{
				short num = (short)962262608;
				short num2 = num;
				num = (short)1488582224;
				switch (num2 == num)
				{
				}
				num = (short)744226816;
				if (num != 0)
				{
				}
				num = (short)841809920;
				short num3 = num;
				num = (short)545062913;
				if (num != 0)
				{
				}
				return this.dataWideLTEModeChangeMaxDetachTime_A42208.HiddenDynamic;
			}
			set
			{
				short num = (short)1761476608;
				short num2 = num;
				num = (short)708647580;
				short num3 = num;
				num = (short)1419713180;
				switch (num3 == num)
				{
				}
				num = (short)1816068096;
				if (num != 0)
				{
				}
				num = (short)1950941185;
				if (num != 0)
				{
				}
				this.dataWideLTEModeChangeMaxDetachTime_A42208.HiddenDynamic = value;
			}
		}

		// Token: 0x17005442 RID: 21570
		// (get) Token: 0x0600A7C9 RID: 42953 RVA: 0x009C06A4 File Offset: 0x009BE8A4
		public bool DataWideLTEModeChangeMaxDetachTime_A42208_HasDiffs
		{
			get
			{
				short num = (short)951451648;
				short num2 = num;
				num = (short)244784252;
				short num3 = num;
				num = (short)408886396;
				switch (num3 == num)
				{
				}
				num = (short)389677056;
				if (num != 0)
				{
				}
				num = (short)17104897;
				if (num != 0)
				{
				}
				return this.dataWideLTEModeChangeMaxDetachTime_A42208._HasDiffs;
			}
		}

		// Token: 0x17005443 RID: 21571
		// (get) Token: 0x0600A7CA RID: 42954 RVA: 0x009C0758 File Offset: 0x009BE958
		// (set) Token: 0x0600A7CB RID: 42955 RVA: 0x009C080C File Offset: 0x009BEA0C
		public int DataWideLTEOpenMaxGuardTime_A42391Value
		{
			get
			{
				short num = (short)1808138240;
				short num2 = num;
				num = (short)389092316;
				short num3 = num;
				num = (short)1586697180;
				switch (num3 == num)
				{
				}
				num = (short)222232577;
				if (num != 0)
				{
				}
				num = (short)824705024;
				if (num != 0)
				{
				}
				return this.dataWideLTEOpenMaxGuardTime_A42391.Value;
			}
			set
			{
				short num = (short)540344320;
				short num2 = num;
				num = (short)1958603337;
				short num3 = num;
				num = (short)543222345;
				switch (num3 == num)
				{
				}
				num = (short)1637023744;
				if (num != 0)
				{
				}
				num = (short)897843201;
				if (num != 0)
				{
				}
				this.dataWideLTEOpenMaxGuardTime_A42391.Value = value;
			}
		}

		// Token: 0x17005444 RID: 21572
		// (get) Token: 0x0600A7CC RID: 42956 RVA: 0x009C08C4 File Offset: 0x009BEAC4
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideLTEOpenMaxGuardTime_A42391
		{
			get
			{
				short num = (short)2133590016;
				short num2 = num;
				num = (short)9451806;
				short num3 = num;
				num = (short)2074556702;
				switch (num3 == num)
				{
				}
				num = (short)615055360;
				if (num != 0)
				{
				}
				num = (short)1589706753;
				if (num != 0)
				{
				}
				return this.dataWideLTEOpenMaxGuardTime_A42391;
			}
		}

		// Token: 0x17005445 RID: 21573
		// (get) Token: 0x0600A7CD RID: 42957 RVA: 0x009C0974 File Offset: 0x009BEB74
		// (set) Token: 0x0600A7CE RID: 42958 RVA: 0x009C0A28 File Offset: 0x009BEC28
		public string DataWideLTEOpenMaxGuardTime_A42391_UIValue
		{
			get
			{
				short num = (short)838139904;
				short num2 = num;
				num = (short)1869963197;
				short num3 = num;
				num = (short)1507418045;
				switch (num3 == num)
				{
				}
				num = (short)1374683137;
				if (num != 0)
				{
				}
				num = (short)1403912192;
				if (num != 0)
				{
				}
				return this.dataWideLTEOpenMaxGuardTime_A42391.UIValue;
			}
			set
			{
				short num = (short)740884480;
				short num2 = num;
				num = (short)2066075688;
				short num3 = num;
				num = (short)744149032;
				switch (num3 == num)
				{
				}
				num = (short)1888157696;
				if (num != 0)
				{
				}
				num = (short)852426753;
				if (num != 0)
				{
				}
				this.dataWideLTEOpenMaxGuardTime_A42391.UIValue = value;
			}
		}

		// Token: 0x17005446 RID: 21574
		// (get) Token: 0x0600A7CF RID: 42959 RVA: 0x009C0ADC File Offset: 0x009BECDC
		// (set) Token: 0x0600A7D0 RID: 42960 RVA: 0x009C0B90 File Offset: 0x009BED90
		internal int DataWideLTEOpenMaxGuardTime_A42391Min
		{
			get
			{
				short num = (short)1013448704;
				short num2 = num;
				num = (short)679215105;
				if (num != 0)
				{
				}
				num = (short)1040093625;
				short num3 = num;
				num = (short)771199417;
				switch (num3 == num)
				{
				}
				num = (short)390594560;
				if (num != 0)
				{
				}
				return this.dataWideLTEOpenMaxGuardTime_A42391.Min;
			}
			set
			{
				short num = (short)1666711552;
				short num2 = num;
				num = (short)1422986870;
				short num3 = num;
				num = (short)1560743542;
				switch (num3 == num)
				{
				}
				num = (short)1893466113;
				if (num != 0)
				{
				}
				num = (short)556269568;
				if (num != 0)
				{
				}
				this.dataWideLTEOpenMaxGuardTime_A42391.Min = value;
			}
		}

		// Token: 0x17005447 RID: 21575
		// (get) Token: 0x0600A7D1 RID: 42961 RVA: 0x009C0C44 File Offset: 0x009BEE44
		// (set) Token: 0x0600A7D2 RID: 42962 RVA: 0x009C0CF8 File Offset: 0x009BEEF8
		internal int DataWideLTEOpenMaxGuardTime_A42391Max
		{
			get
			{
				short num = (short)1503264768;
				short num2 = num;
				num = (short)1730961897;
				short num3 = num;
				num = (short)1402036713;
				switch (num3 == num)
				{
				}
				num = (short)200671232;
				if (num != 0)
				{
				}
				num = (short)1794965505;
				if (num != 0)
				{
				}
				return this.dataWideLTEOpenMaxGuardTime_A42391.Max;
			}
			set
			{
				short num = (short)278724608;
				short num2 = num;
				num = (short)112721921;
				if (num != 0)
				{
				}
				num = (short)338241465;
				short num3 = num;
				num = (short)1573136313;
				switch (num3 == num)
				{
				}
				num = (short)1287127040;
				if (num != 0)
				{
				}
				this.dataWideLTEOpenMaxGuardTime_A42391.Max = value;
			}
		}

		// Token: 0x17005448 RID: 21576
		// (get) Token: 0x0600A7D3 RID: 42963 RVA: 0x009C0DAC File Offset: 0x009BEFAC
		// (set) Token: 0x0600A7D4 RID: 42964 RVA: 0x009C0E60 File Offset: 0x009BF060
		internal int DataWideLTEOpenMaxGuardTime_A42391Step
		{
			get
			{
				short num = (short)1375993856;
				short num2 = num;
				num = (short)292847132;
				short num3 = num;
				num = (short)1501265436;
				switch (num3 == num)
				{
				}
				num = (short)106561537;
				if (num != 0)
				{
				}
				num = (short)402194432;
				if (num != 0)
				{
				}
				return this.dataWideLTEOpenMaxGuardTime_A42391.StepSize;
			}
			set
			{
				short num = (short)734593024;
				short num2 = num;
				num = (short)688717922;
				short num3 = num;
				num = (short)1253900386;
				switch (num3 == num)
				{
				}
				num = (short)1484193793;
				if (num != 0)
				{
				}
				num = (short)832045056;
				if (num != 0)
				{
				}
				this.dataWideLTEOpenMaxGuardTime_A42391.StepSize = value;
			}
		}

		// Token: 0x17005449 RID: 21577
		// (get) Token: 0x0600A7D5 RID: 42965 RVA: 0x009C0F14 File Offset: 0x009BF114
		// (set) Token: 0x0600A7D6 RID: 42966 RVA: 0x009C0FC8 File Offset: 0x009BF1C8
		public bool DataWideLTEOpenMaxGuardTime_A42391_Applicable
		{
			get
			{
				short num = (short)1988820992;
				short num2 = num;
				num = (short)1491306449;
				short num3 = num;
				num = (short)415074257;
				switch (num3 == num)
				{
				}
				num = (short)326959105;
				if (num != 0)
				{
				}
				num = (short)238026752;
				if (num != 0)
				{
				}
				return this.dataWideLTEOpenMaxGuardTime_A42391.Applicable;
			}
			set
			{
				short num = (short)1879638016;
				short num2 = num;
				num = (short)671950159;
				short num3 = num;
				num = (short)849814863;
				switch (num3 == num)
				{
				}
				num = (short)31522817;
				if (num != 0)
				{
				}
				num = (short)496173056;
				if (num != 0)
				{
				}
				this.dataWideLTEOpenMaxGuardTime_A42391.Applicable = value;
			}
		}

		// Token: 0x1700544A RID: 21578
		// (get) Token: 0x0600A7D7 RID: 42967 RVA: 0x009C1080 File Offset: 0x009BF280
		// (set) Token: 0x0600A7D8 RID: 42968 RVA: 0x009C1134 File Offset: 0x009BF334
		public bool DataWideLTEOpenMaxGuardTime_A42391_Valid
		{
			get
			{
				short num = (short)2002124800;
				short num2 = num;
				num = (short)1851473856;
				short num3 = num;
				num = (short)29441984;
				switch (num3 == num)
				{
				}
				num = (short)1578958849;
				if (num != 0)
				{
				}
				num = (short)38010880;
				if (num != 0)
				{
				}
				return this.dataWideLTEOpenMaxGuardTime_A42391.Valid;
			}
			set
			{
				short num = (short)1817313280;
				short num2 = num;
				num = (short)1885599635;
				short num3 = num;
				num = (short)728233875;
				switch (num3 == num)
				{
				}
				num = (short)1906769920;
				if (num != 0)
				{
				}
				num = (short)880803841;
				if (num != 0)
				{
				}
				this.dataWideLTEOpenMaxGuardTime_A42391.Valid = value;
			}
		}

		// Token: 0x1700544B RID: 21579
		// (get) Token: 0x0600A7D9 RID: 42969 RVA: 0x009C11E8 File Offset: 0x009BF3E8
		// (set) Token: 0x0600A7DA RID: 42970 RVA: 0x009C129C File Offset: 0x009BF49C
		public bool DataWideLTEOpenMaxGuardTime_A42391_Visible
		{
			get
			{
				short num = (short)1741750272;
				short num2 = num;
				num = (short)1101747946;
				short num3 = num;
				num = (short)1904957162;
				switch (num3 == num)
				{
				}
				num = (short)437059585;
				if (num != 0)
				{
				}
				num = (short)1201668096;
				if (num != 0)
				{
				}
				return this.dataWideLTEOpenMaxGuardTime_A42391.Visible;
			}
			set
			{
				short num = (short)38600704;
				short num2 = num;
				num = (short)1203135408;
				short num3 = num;
				num = (short)880042928;
				switch (num3 == num)
				{
				}
				num = (short)2000158721;
				if (num != 0)
				{
				}
				num = (short)2129461248;
				if (num != 0)
				{
				}
				this.dataWideLTEOpenMaxGuardTime_A42391.Visible = value;
			}
		}

		// Token: 0x1700544C RID: 21580
		// (get) Token: 0x0600A7DB RID: 42971 RVA: 0x009C1354 File Offset: 0x009BF554
		// (set) Token: 0x0600A7DC RID: 42972 RVA: 0x009C1408 File Offset: 0x009BF608
		public bool DataWideLTEOpenMaxGuardTime_A42391_Editable
		{
			get
			{
				short num = (short)2013134848;
				short num2 = num;
				num = (short)1320815605;
				short num3 = num;
				num = (short)8063989;
				switch (num3 == num)
				{
				}
				num = (short)310181888;
				if (num != 0)
				{
				}
				num = (short)2061893633;
				if (num != 0)
				{
				}
				return this.dataWideLTEOpenMaxGuardTime_A42391.Editable;
			}
			set
			{
				short num = (short)602800128;
				short num2 = num;
				num = (short)2040545374;
				short num3 = num;
				num = (short)1212235870;
				switch (num3 == num)
				{
				}
				num = (short)1123352576;
				if (num != 0)
				{
				}
				num = (short)800456705;
				if (num != 0)
				{
				}
				this.dataWideLTEOpenMaxGuardTime_A42391.Editable = value;
			}
		}

		// Token: 0x1700544D RID: 21581
		// (get) Token: 0x0600A7DD RID: 42973 RVA: 0x009C14BC File Offset: 0x009BF6BC
		internal string DataWideLTEOpenMaxGuardTime_A42391_UILabel
		{
			get
			{
				short num = (short)261423104;
				short num2 = num;
				num = (short)1931486255;
				short num3 = num;
				num = (short)409871407;
				switch (num3 == num)
				{
				}
				num = (short)1836056577;
				if (num != 0)
				{
				}
				num = (short)905183232;
				if (num != 0)
				{
				}
				return this.dataWideLTEOpenMaxGuardTime_A42391.UIName;
			}
		}

		// Token: 0x1700544E RID: 21582
		// (get) Token: 0x0600A7DE RID: 42974 RVA: 0x009C1570 File Offset: 0x009BF770
		// (set) Token: 0x0600A7DF RID: 42975 RVA: 0x009C1624 File Offset: 0x009BF824
		internal bool DataWideLTEOpenMaxGuardTime_A42391_HiddenStatic
		{
			get
			{
				short num = (short)1632829440;
				short num2 = num;
				num = (short)483262465;
				if (num != 0)
				{
				}
				num = (short)1985131583;
				short num3 = num;
				num = (short)772387903;
				switch (num3 == num)
				{
				}
				num = (short)295567360;
				if (num != 0)
				{
				}
				return this.dataWideLTEOpenMaxGuardTime_A42391.HiddenStatic;
			}
			set
			{
				short num = (short)26411008;
				short num2 = num;
				num = (short)1027306558;
				short num3 = num;
				num = (short)28472382;
				switch (num3 == num)
				{
				}
				num = (short)1558970368;
				if (num != 0)
				{
				}
				num = (short)299827201;
				if (num != 0)
				{
				}
				this.dataWideLTEOpenMaxGuardTime_A42391.HiddenStatic = value;
			}
		}

		// Token: 0x1700544F RID: 21583
		// (get) Token: 0x0600A7E0 RID: 42976 RVA: 0x009C16DC File Offset: 0x009BF8DC
		// (set) Token: 0x0600A7E1 RID: 42977 RVA: 0x009C1794 File Offset: 0x009BF994
		internal bool DataWideLTEOpenMaxGuardTime_A42391_HiddenDynamic
		{
			get
			{
				short num = (short)1142489088;
				short num2 = num;
				num = (short)1096603949;
				short num3 = num;
				num = (short)2051856685;
				switch (num3 == num)
				{
				}
				num = (short)1456799744;
				if (num != 0)
				{
				}
				num = (short)1886846977;
				if (num != 0)
				{
				}
				return this.dataWideLTEOpenMaxGuardTime_A42391.HiddenDynamic;
			}
			set
			{
				short num = (short)1038548992;
				short num2 = num;
				num = (short)49378975;
				short num3 = num;
				num = (short)2000385695;
				switch (num3 == num)
				{
				}
				num = (short)200736768;
				if (num != 0)
				{
				}
				num = (short)1600585729;
				if (num != 0)
				{
				}
				this.dataWideLTEOpenMaxGuardTime_A42391.HiddenDynamic = value;
			}
		}

		// Token: 0x17005450 RID: 21584
		// (get) Token: 0x0600A7E2 RID: 42978 RVA: 0x009C184C File Offset: 0x009BFA4C
		public bool DataWideLTEOpenMaxGuardTime_A42391_HasDiffs
		{
			get
			{
				short num = (short)221904896;
				short num2 = num;
				num = (short)1346481136;
				short num3 = num;
				num = (short)834120688;
				switch (num3 == num)
				{
				}
				num = (short)212533249;
				if (num != 0)
				{
				}
				num = (short)724762624;
				if (num != 0)
				{
				}
				return this.dataWideLTEOpenMaxGuardTime_A42391._HasDiffs;
			}
		}

		// Token: 0x17005451 RID: 21585
		// (get) Token: 0x0600A7E3 RID: 42979 RVA: 0x009C1900 File Offset: 0x009BFB00
		// (set) Token: 0x0600A7E4 RID: 42980 RVA: 0x009C19B4 File Offset: 0x009BFBB4
		public string DataWideLTEClass3AccessPointName_A42392Value
		{
			get
			{
				short num = (short)1225326592;
				short num2 = num;
				num = (short)1016140522;
				short num3 = num;
				num = (short)1016730346;
				switch (num3 == num)
				{
				}
				num = (short)1440219137;
				if (num != 0)
				{
				}
				num = (short)773914624;
				if (num != 0)
				{
				}
				return this.dataWideLTEClass3AccessPointName_A42392.Value;
			}
			set
			{
				short num = (short)1620180992;
				short num2 = num;
				num = (short)2138312027;
				short num3 = num;
				num = (short)800525659;
				switch (num3 == num)
				{
				}
				num = (short)1383137281;
				if (num != 0)
				{
				}
				num = (short)316407808;
				if (num != 0)
				{
				}
				this.dataWideLTEClass3AccessPointName_A42392.Value = value;
			}
		}

		// Token: 0x17005452 RID: 21586
		// (get) Token: 0x0600A7E5 RID: 42981 RVA: 0x009C1A6C File Offset: 0x009BFC6C
		public global::AcpBusinessLayer.AcpField<string> DataWideLTEClass3AccessPointName_A42392
		{
			get
			{
				short num = (short)1962606592;
				short num2 = num;
				num = (short)2096316822;
				short num3 = num;
				num = (short)467157398;
				switch (num3 == num)
				{
				}
				num = (short)1499463681;
				if (num != 0)
				{
				}
				num = (short)775094272;
				if (num != 0)
				{
				}
				return this.dataWideLTEClass3AccessPointName_A42392;
			}
		}

		// Token: 0x17005453 RID: 21587
		// (get) Token: 0x0600A7E6 RID: 42982 RVA: 0x009C1B1C File Offset: 0x009BFD1C
		// (set) Token: 0x0600A7E7 RID: 42983 RVA: 0x009C1BD4 File Offset: 0x009BFDD4
		public string DataWideLTEClass3AccessPointName_A42392_UIValue
		{
			get
			{
				short num = (short)346226688;
				short num2 = num;
				num = (short)580328764;
				short num3 = num;
				num = (short)1888165180;
				switch (num3 == num)
				{
				}
				num = (short)1287716865;
				if (num != 0)
				{
				}
				num = (short)1921646592;
				if (num != 0)
				{
				}
				return this.dataWideLTEClass3AccessPointName_A42392.Value;
			}
			set
			{
				short num = (short)858193920;
				short num2 = num;
				num = (short)2089091073;
				if (num != 0)
				{
				}
				num = (short)2016369005;
				short num3 = num;
				num = (short)1381587309;
				switch (num3 == num)
				{
				}
				num = (short)2138505216;
				if (num != 0)
				{
				}
				this.dataWideLTEClass3AccessPointName_A42392.Value = value;
			}
		}

		// Token: 0x17005454 RID: 21588
		// (get) Token: 0x0600A7E8 RID: 42984 RVA: 0x009C1C88 File Offset: 0x009BFE88
		// (set) Token: 0x0600A7E9 RID: 42985 RVA: 0x009C1D3C File Offset: 0x009BFF3C
		public bool DataWideLTEClass3AccessPointName_A42392_Applicable
		{
			get
			{
				short num = (short)799670272;
				short num2 = num;
				num = (short)1657274369;
				if (num != 0)
				{
				}
				num = (short)947135597;
				short num3 = num;
				num = (short)1678976109;
				switch (num3 == num)
				{
				}
				num = (short)304873472;
				if (num != 0)
				{
				}
				return this.dataWideLTEClass3AccessPointName_A42392.Applicable;
			}
			set
			{
				short num = (short)151191552;
				short num2 = num;
				num = (short)1948057601;
				if (num != 0)
				{
				}
				num = (short)24240495;
				short num3 = num;
				num = (short)347070831;
				switch (num3 == num)
				{
				}
				num = (short)2002583552;
				if (num != 0)
				{
				}
				this.dataWideLTEClass3AccessPointName_A42392.Applicable = value;
			}
		}

		// Token: 0x17005455 RID: 21589
		// (get) Token: 0x0600A7EA RID: 42986 RVA: 0x009C1DF4 File Offset: 0x009BFFF4
		// (set) Token: 0x0600A7EB RID: 42987 RVA: 0x009C1EAC File Offset: 0x009C00AC
		public bool DataWideLTEClass3AccessPointName_A42392_Valid
		{
			get
			{
				short num = (short)71106560;
				short num2 = num;
				num = (short)279737430;
				short num3 = num;
				num = (short)372012118;
				switch (num3 == num)
				{
				}
				num = (short)1389690881;
				if (num != 0)
				{
				}
				num = (short)708182016;
				if (num != 0)
				{
				}
				return this.dataWideLTEClass3AccessPointName_A42392.Valid;
			}
			set
			{
				short num = (short)1017774080;
				short num2 = num;
				num = (short)703032761;
				short num3 = num;
				num = (short)13200825;
				switch (num3 == num)
				{
				}
				num = (short)1203765249;
				if (num != 0)
				{
				}
				num = (short)641531904;
				if (num != 0)
				{
				}
				this.dataWideLTEClass3AccessPointName_A42392.Valid = value;
			}
		}

		// Token: 0x17005456 RID: 21590
		// (get) Token: 0x0600A7EC RID: 42988 RVA: 0x009C1F60 File Offset: 0x009C0160
		// (set) Token: 0x0600A7ED RID: 42989 RVA: 0x009C2014 File Offset: 0x009C0214
		public bool DataWideLTEClass3AccessPointName_A42392_Visible
		{
			get
			{
				short num = (short)1345126400;
				short num2 = num;
				num = (short)496429511;
				short num3 = num;
				num = (short)1809574343;
				switch (num3 == num)
				{
				}
				num = (short)512294912;
				if (num != 0)
				{
				}
				num = (short)886243329;
				if (num != 0)
				{
				}
				return this.dataWideLTEClass3AccessPointName_A42392.Visible;
			}
			set
			{
				short num = (short)294060032;
				short num2 = num;
				num = (short)1156874718;
				short num3 = num;
				num = (short)1957986782;
				switch (num3 == num)
				{
				}
				num = (short)168558593;
				if (num != 0)
				{
				}
				num = (short)1858142208;
				if (num != 0)
				{
				}
				this.dataWideLTEClass3AccessPointName_A42392.Visible = value;
			}
		}

		// Token: 0x17005457 RID: 21591
		// (get) Token: 0x0600A7EE RID: 42990 RVA: 0x009C20C8 File Offset: 0x009C02C8
		// (set) Token: 0x0600A7EF RID: 42991 RVA: 0x009C217C File Offset: 0x009C037C
		public bool DataWideLTEClass3AccessPointName_A42392_Editable
		{
			get
			{
				short num = (short)1589116928;
				short num2 = num;
				num = (short)1730100236;
				short num3 = num;
				num = (short)1128938508;
				switch (num3 == num)
				{
				}
				num = (short)2134245376;
				if (num != 0)
				{
				}
				num = (short)1130168321;
				if (num != 0)
				{
				}
				return this.dataWideLTEClass3AccessPointName_A42392.Editable;
			}
			set
			{
				short num = (short)765263872;
				short num2 = num;
				num = (short)1632414731;
				short num3 = num;
				num = (short)568110091;
				switch (num3 == num)
				{
				}
				num = (short)1901527040;
				if (num != 0)
				{
				}
				num = (short)850591745;
				if (num != 0)
				{
				}
				this.dataWideLTEClass3AccessPointName_A42392.Editable = value;
			}
		}

		// Token: 0x17005458 RID: 21592
		// (get) Token: 0x0600A7F0 RID: 42992 RVA: 0x009C2234 File Offset: 0x009C0434
		internal string DataWideLTEClass3AccessPointName_A42392_UILabel
		{
			get
			{
				short num = (short)1321861120;
				short num2 = num;
				num = (short)491449721;
				short num3 = num;
				num = (short)549252473;
				switch (num3 == num)
				{
				}
				num = (short)988807168;
				if (num != 0)
				{
				}
				num = (short)1765212161;
				if (num != 0)
				{
				}
				return this.dataWideLTEClass3AccessPointName_A42392.UIName;
			}
		}

		// Token: 0x17005459 RID: 21593
		// (get) Token: 0x0600A7F1 RID: 42993 RVA: 0x009C22E8 File Offset: 0x009C04E8
		// (set) Token: 0x0600A7F2 RID: 42994 RVA: 0x009C239C File Offset: 0x009C059C
		internal bool DataWideLTEClass3AccessPointName_A42392_HiddenStatic
		{
			get
			{
				short num = (short)310575104;
				short num2 = num;
				num = (short)618181627;
				short num3 = num;
				num = (short)683258875;
				switch (num3 == num)
				{
				}
				num = (short)1832976385;
				if (num != 0)
				{
				}
				num = (short)1296564224;
				if (num != 0)
				{
				}
				return this.dataWideLTEClass3AccessPointName_A42392.HiddenStatic;
			}
			set
			{
				short num = (short)1549467648;
				short num2 = num;
				num = (short)1868628643;
				short num3 = num;
				num = (short)1496449699;
				switch (num3 == num)
				{
				}
				num = (short)117178369;
				if (num != 0)
				{
				}
				num = (short)1361707008;
				if (num != 0)
				{
				}
				this.dataWideLTEClass3AccessPointName_A42392.HiddenStatic = value;
			}
		}

		// Token: 0x1700545A RID: 21594
		// (get) Token: 0x0600A7F3 RID: 42995 RVA: 0x009C2450 File Offset: 0x009C0650
		// (set) Token: 0x0600A7F4 RID: 42996 RVA: 0x009C2500 File Offset: 0x009C0700
		internal bool DataWideLTEClass3AccessPointName_A42392_HiddenDynamic
		{
			get
			{
				short num = (short)172163072;
				short num2 = num;
				num = (short)1210780505;
				short num3 = num;
				num = (short)1167788889;
				switch (num3 == num)
				{
				}
				num = (short)2054225921;
				if (num != 0)
				{
				}
				num = (short)348848128;
				if (num != 0)
				{
				}
				return this.dataWideLTEClass3AccessPointName_A42392.HiddenDynamic;
			}
			set
			{
				short num = (short)1383399424;
				short num2 = num;
				num = (short)1507766725;
				short num3 = num;
				num = (short)977973701;
				switch (num3 == num)
				{
				}
				num = (short)531759104;
				if (num != 0)
				{
				}
				num = (short)1990721537;
				if (num != 0)
				{
				}
				this.dataWideLTEClass3AccessPointName_A42392.HiddenDynamic = value;
			}
		}

		// Token: 0x1700545B RID: 21595
		// (get) Token: 0x0600A7F5 RID: 42997 RVA: 0x009C25B8 File Offset: 0x009C07B8
		public bool DataWideLTEClass3AccessPointName_A42392_HasDiffs
		{
			get
			{
				short num = (short)1090060288;
				short num2 = num;
				num = (short)774622932;
				short num3 = num;
				num = (short)1676988116;
				switch (num3 == num)
				{
				}
				num = (short)1452670976;
				if (num != 0)
				{
				}
				num = (short)564658177;
				if (num != 0)
				{
				}
				return this.dataWideLTEClass3AccessPointName_A42392._HasDiffs;
			}
		}

		// Token: 0x1700545C RID: 21596
		// (get) Token: 0x0600A7F6 RID: 42998 RVA: 0x009C2670 File Offset: 0x009C0870
		// (set) Token: 0x0600A7F7 RID: 42999 RVA: 0x009C2724 File Offset: 0x009C0924
		public bool DataWideLTEOperation_A42215Value
		{
			get
			{
				short num = (short)982974464;
				short num2 = num;
				num = (short)1862098868;
				short num3 = num;
				num = (short)1422221236;
				switch (num3 == num)
				{
				}
				num = (short)815071233;
				if (num != 0)
				{
				}
				num = (short)1203175424;
				if (num != 0)
				{
				}
				return this.dataWideLTEOperation_A42215.Value;
			}
			set
			{
				short num = (short)1304952832;
				short num2 = num;
				num = (short)729652777;
				short num3 = num;
				num = (short)837066281;
				switch (num3 == num)
				{
				}
				num = (short)1809055744;
				if (num != 0)
				{
				}
				num = (short)380108801;
				if (num != 0)
				{
				}
				this.dataWideLTEOperation_A42215.Value = value;
			}
		}

		// Token: 0x1700545D RID: 21597
		// (get) Token: 0x0600A7F8 RID: 43000 RVA: 0x009C27DC File Offset: 0x009C09DC
		public global::AcpBusinessLayer.AcpField<bool> DataWideLTEOperation_A42215
		{
			get
			{
				short num = (short)1068105728;
				short num2 = num;
				num = (short)1471401771;
				short num3 = num;
				num = (short)451465003;
				switch (num3 == num)
				{
				}
				num = (short)1801977857;
				if (num != 0)
				{
				}
				num = (short)1514602496;
				if (num != 0)
				{
				}
				return this.dataWideLTEOperation_A42215;
			}
		}

		// Token: 0x1700545E RID: 21598
		// (get) Token: 0x0600A7F9 RID: 43001 RVA: 0x009C288C File Offset: 0x009C0A8C
		// (set) Token: 0x0600A7FA RID: 43002 RVA: 0x009C2940 File Offset: 0x009C0B40
		public bool DataWideLTEOperation_A42215Value_UIValue
		{
			get
			{
				short num = (short)1342177280;
				short num2 = num;
				num = (short)2020472525;
				short num3 = num;
				num = (short)842331853;
				switch (num3 == num)
				{
				}
				num = (short)43384832;
				if (num != 0)
				{
				}
				num = (short)1193345025;
				if (num != 0)
				{
				}
				return this.dataWideLTEOperation_A42215.Value;
			}
			set
			{
				short num = (short)85458944;
				short num2 = num;
				num = (short)261358852;
				short num3 = num;
				num = (short)2081817860;
				switch (num3 == num)
				{
				}
				num = (short)1717501953;
				if (num != 0)
				{
				}
				num = (short)1896677376;
				if (num != 0)
				{
				}
				this.dataWideLTEOperation_A42215.Value = value;
			}
		}

		// Token: 0x1700545F RID: 21599
		// (get) Token: 0x0600A7FB RID: 43003 RVA: 0x009C29F8 File Offset: 0x009C0BF8
		// (set) Token: 0x0600A7FC RID: 43004 RVA: 0x009C2AAC File Offset: 0x009C0CAC
		public bool DataWideLTEOperation_A42215_Applicable
		{
			get
			{
				short num = (short)1901272731;
				short num2 = num;
				num = (short)2057248411;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1684144128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)4390913;
				if (num != 0)
				{
				}
				num = (short)1981218816;
				if (num != 0)
				{
				}
				return this.dataWideLTEOperation_A42215.Applicable;
			}
			set
			{
				short num = (short)1935725401;
				short num2 = num;
				num = (short)29152089;
				switch (num2 == num)
				{
				default:
				{
					num = (short)784990208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1412300801;
				if (num != 0)
				{
				}
				num = (short)946536448;
				if (num != 0)
				{
				}
				this.dataWideLTEOperation_A42215.Applicable = value;
			}
		}

		// Token: 0x17005460 RID: 21600
		// (get) Token: 0x0600A7FD RID: 43005 RVA: 0x009C2B68 File Offset: 0x009C0D68
		// (set) Token: 0x0600A7FE RID: 43006 RVA: 0x009C2C18 File Offset: 0x009C0E18
		public bool DataWideLTEOperation_A42215_Valid
		{
			get
			{
				short num = (short)2693635;
				short num2 = num;
				num = (short)88611331;
				switch (num2 == num)
				{
				default:
				{
					num = (short)604307456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1422262272;
				if (num != 0)
				{
				}
				num = (short)777519105;
				if (num != 0)
				{
				}
				return this.dataWideLTEOperation_A42215.Valid;
			}
			set
			{
				short num = (short)841397746;
				short num2 = num;
				num = (short)1087616498;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1284571136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1767899136;
				if (num != 0)
				{
				}
				num = (short)1262616577;
				if (num != 0)
				{
				}
				this.dataWideLTEOperation_A42215.Valid = value;
			}
		}

		// Token: 0x17005461 RID: 21601
		// (get) Token: 0x0600A7FF RID: 43007 RVA: 0x009C2CD0 File Offset: 0x009C0ED0
		// (set) Token: 0x0600A800 RID: 43008 RVA: 0x009C2D88 File Offset: 0x009C0F88
		public bool DataWideLTEOperation_A42215_Visible
		{
			get
			{
				short num = (short)1173288557;
				short num2 = num;
				num = (short)2034366061;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1936916480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)923795457;
				if (num != 0)
				{
				}
				num = (short)494796800;
				if (num != 0)
				{
				}
				return this.dataWideLTEOperation_A42215.Visible;
			}
			set
			{
				short num = (short)1191733309;
				short num2 = num;
				num = (short)1749510205;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1622081536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1219428352;
				if (num != 0)
				{
				}
				num = (short)1190985729;
				if (num != 0)
				{
				}
				this.dataWideLTEOperation_A42215.Visible = value;
			}
		}

		// Token: 0x17005462 RID: 21602
		// (get) Token: 0x0600A801 RID: 43009 RVA: 0x009C2E40 File Offset: 0x009C1040
		// (set) Token: 0x0600A802 RID: 43010 RVA: 0x009C2EF4 File Offset: 0x009C10F4
		public bool DataWideLTEOperation_A42215_Editable
		{
			get
			{
				short num = (short)1561567134;
				short num2 = num;
				num = (short)1578213278;
				switch (num2 == num)
				{
				default:
				{
					num = (short)65798144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)751239169;
				if (num != 0)
				{
				}
				num = (short)85983232;
				if (num != 0)
				{
				}
				return this.dataWideLTEOperation_A42215.Editable;
			}
			set
			{
				short num = (short)1882001691;
				short num2 = num;
				num = (short)1192956187;
				switch (num2 == num)
				{
				default:
				{
					num = (short)978649088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)164429824;
				if (num != 0)
				{
				}
				num = (short)344260609;
				if (num != 0)
				{
				}
				this.dataWideLTEOperation_A42215.Editable = value;
			}
		}

		// Token: 0x17005463 RID: 21603
		// (get) Token: 0x0600A803 RID: 43011 RVA: 0x009C2FA8 File Offset: 0x009C11A8
		internal string DataWideLTEOperation_A42215_UILabel
		{
			get
			{
				short num = (short)1018167297;
				if (num != 0)
				{
				}
				num = (short)1142816768;
				short num2 = num;
				num = (short)922993278;
				short num3 = num;
				num = (short)1730003582;
				switch (num3 == num)
				{
				}
				num = (short)1930231808;
				if (num != 0)
				{
				}
				return this.dataWideLTEOperation_A42215.UIName;
			}
		}

		// Token: 0x17005464 RID: 21604
		// (get) Token: 0x0600A804 RID: 43012 RVA: 0x009C3060 File Offset: 0x009C1260
		// (set) Token: 0x0600A805 RID: 43013 RVA: 0x009C3114 File Offset: 0x009C1314
		internal bool DataWideLTEOperation_A42215_HiddenStatic
		{
			get
			{
				short num = (short)1490203596;
				short num2 = num;
				num = (short)2063250380;
				switch (num2 == num)
				{
				default:
				{
					num = (short)188088320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2016280577;
				if (num != 0)
				{
				}
				num = (short)1072234496;
				if (num != 0)
				{
				}
				return this.dataWideLTEOperation_A42215.HiddenStatic;
			}
			set
			{
				short num = (short)468827454;
				short num2 = num;
				num = (short)1750580542;
				switch (num2 == num)
				{
				default:
				{
					num = (short)140836864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1647312897;
				if (num != 0)
				{
				}
				num = (short)988086272;
				if (num != 0)
				{
				}
				this.dataWideLTEOperation_A42215.HiddenStatic = value;
			}
		}

		// Token: 0x17005465 RID: 21605
		// (get) Token: 0x0600A806 RID: 43014 RVA: 0x009C31C8 File Offset: 0x009C13C8
		// (set) Token: 0x0600A807 RID: 43015 RVA: 0x009C327C File Offset: 0x009C147C
		internal bool DataWideLTEOperation_A42215_HiddenDynamic
		{
			get
			{
				short num = (short)2050065501;
				short num2 = num;
				num = (short)996901981;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1451294720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2062090241;
				if (num != 0)
				{
				}
				num = (short)778633216;
				if (num != 0)
				{
				}
				return this.dataWideLTEOperation_A42215.HiddenDynamic;
			}
			set
			{
				short num = (short)397593823;
				short num2 = num;
				num = (short)515165407;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1671036928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)478543872;
				if (num != 0)
				{
				}
				num = (short)1150353409;
				if (num != 0)
				{
				}
				this.dataWideLTEOperation_A42215.HiddenDynamic = value;
			}
		}

		// Token: 0x17005466 RID: 21606
		// (get) Token: 0x0600A808 RID: 43016 RVA: 0x009C3330 File Offset: 0x009C1530
		public bool DataWideLTEOperation_A42215_HasDiffs
		{
			get
			{
				short num = (short)582829229;
				short num2 = num;
				num = (short)389694637;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1662189568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)565968897;
				if (num != 0)
				{
				}
				num = (short)2123890688;
				if (num != 0)
				{
				}
				return this.dataWideLTEOperation_A42215._HasDiffs;
			}
		}

		// Token: 0x17005467 RID: 21607
		// (get) Token: 0x0600A809 RID: 43017 RVA: 0x009C33E4 File Offset: 0x009C15E4
		// (set) Token: 0x0600A80A RID: 43018 RVA: 0x009C3498 File Offset: 0x009C1698
		public bool DataWideDataOnRoaming_A42216Value
		{
			get
			{
				short num = (short)913309697;
				if (num != 0)
				{
				}
				num = (short)1172504576;
				short num2 = num;
				num = (short)1106234956;
				short num3 = num;
				num = (short)1750519372;
				switch (num3 == num)
				{
				}
				num = (short)1973944320;
				if (num != 0)
				{
				}
				return this.dataWideDataOnRoaming_A42216.Value;
			}
			set
			{
				short num = (short)1647597999;
				short num2 = num;
				num = (short)166156719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1156841472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2060320769;
				if (num != 0)
				{
				}
				num = (short)1478754304;
				if (num != 0)
				{
				}
				this.dataWideDataOnRoaming_A42216.Value = value;
			}
		}

		// Token: 0x17005468 RID: 21608
		// (get) Token: 0x0600A80B RID: 43019 RVA: 0x009C3550 File Offset: 0x009C1750
		public global::AcpBusinessLayer.AcpField<bool> DataWideDataOnRoaming_A42216
		{
			get
			{
				short num = (short)1604845569;
				if (num != 0)
				{
				}
				num = (short)555679744;
				short num2 = num;
				num = (short)1775116019;
				short num3 = num;
				num = (short)1708203763;
				switch (num3 == num)
				{
				}
				num = (short)440205312;
				if (num != 0)
				{
				}
				return this.dataWideDataOnRoaming_A42216;
			}
		}

		// Token: 0x17005469 RID: 21609
		// (get) Token: 0x0600A80C RID: 43020 RVA: 0x009C3600 File Offset: 0x009C1800
		// (set) Token: 0x0600A80D RID: 43021 RVA: 0x009C36B4 File Offset: 0x009C18B4
		public bool DataWideDataOnRoaming_A42216_UIValue
		{
			get
			{
				short num = (short)1739199355;
				short num2 = num;
				num = (short)1394283387;
				switch (num2 == num)
				{
				default:
				{
					num = (short)423690240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1150156800;
				if (num != 0)
				{
				}
				num = (short)1959133185;
				if (num != 0)
				{
				}
				return this.dataWideDataOnRoaming_A42216.Value;
			}
			set
			{
				short num = (short)1859518465;
				if (num != 0)
				{
				}
				num = (short)1670905856;
				short num2 = num;
				num = (short)1758115734;
				short num3 = num;
				num = (short)1675868054;
				switch (num3 == num)
				{
				}
				num = (short)1836253184;
				if (num != 0)
				{
				}
				this.dataWideDataOnRoaming_A42216.Value = value;
			}
		}

		// Token: 0x1700546A RID: 21610
		// (get) Token: 0x0600A80E RID: 43022 RVA: 0x009C3768 File Offset: 0x009C1968
		// (set) Token: 0x0600A80F RID: 43023 RVA: 0x009C3818 File Offset: 0x009C1A18
		public bool DataWideDataOnRoaming_A42216_Applicable
		{
			get
			{
				short num = (short)1440699897;
				short num2 = num;
				num = (short)629691897;
				switch (num2 == num)
				{
				default:
				{
					num = (short)33161216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2107768833;
				if (num != 0)
				{
				}
				num = (short)1700331520;
				if (num != 0)
				{
				}
				return this.dataWideDataOnRoaming_A42216.Applicable;
			}
			set
			{
				short num = (short)557872565;
				short num2 = num;
				num = (short)707294645;
				switch (num2 == num)
				{
				default:
				{
					num = (short)830078976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1981480961;
				if (num != 0)
				{
				}
				num = (short)1420296192;
				if (num != 0)
				{
				}
				this.dataWideDataOnRoaming_A42216.Applicable = value;
			}
		}

		// Token: 0x1700546B RID: 21611
		// (get) Token: 0x0600A810 RID: 43024 RVA: 0x009C38D0 File Offset: 0x009C1AD0
		// (set) Token: 0x0600A811 RID: 43025 RVA: 0x009C3984 File Offset: 0x009C1B84
		public bool DataWideDataOnRoaming_A42216_Valid
		{
			get
			{
				short num = (short)983833310;
				short num2 = num;
				num = (short)1911495390;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1819410432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1912209408;
				if (num != 0)
				{
				}
				num = (short)1796210689;
				if (num != 0)
				{
				}
				return this.dataWideDataOnRoaming_A42216.Valid;
			}
			set
			{
				short num = (short)563001253;
				short num2 = num;
				num = (short)808236965;
				switch (num2 == num)
				{
				default:
				{
					num = (short)141361152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)284884993;
				if (num != 0)
				{
				}
				num = (short)2032861184;
				if (num != 0)
				{
				}
				this.dataWideDataOnRoaming_A42216.Valid = value;
			}
		}

		// Token: 0x1700546C RID: 21612
		// (get) Token: 0x0600A812 RID: 43026 RVA: 0x009C3A38 File Offset: 0x009C1C38
		// (set) Token: 0x0600A813 RID: 43027 RVA: 0x009C3AEC File Offset: 0x009C1CEC
		public bool DataWideDataOnRoaming_A42216_Visible
		{
			get
			{
				short num = (short)1140588545;
				if (num != 0)
				{
				}
				num = (short)6946816;
				short num2 = num;
				num = (short)1917394556;
				short num3 = num;
				num = (short)573972092;
				switch (num3 == num)
				{
				}
				num = (short)1599668224;
				if (num != 0)
				{
				}
				return this.dataWideDataOnRoaming_A42216.Visible;
			}
			set
			{
				short num = (short)1613728866;
				short num2 = num;
				num = (short)977046626;
				switch (num2 == num)
				{
				default:
				{
					num = (short)752812032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)752615425;
				if (num != 0)
				{
				}
				num = (short)617152512;
				if (num != 0)
				{
				}
				this.dataWideDataOnRoaming_A42216.Visible = value;
			}
		}

		// Token: 0x1700546D RID: 21613
		// (get) Token: 0x0600A814 RID: 43028 RVA: 0x009C3BA0 File Offset: 0x009C1DA0
		// (set) Token: 0x0600A815 RID: 43029 RVA: 0x009C3C54 File Offset: 0x009C1E54
		public bool DataWideDataOnRoaming_A42216_Editable
		{
			get
			{
				short num = (short)1130307979;
				short num2 = num;
				num = (short)113648011;
				switch (num2 == num)
				{
				default:
				{
					num = (short)11993088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1726021632;
				if (num != 0)
				{
				}
				num = (short)189399041;
				if (num != 0)
				{
				}
				return this.dataWideDataOnRoaming_A42216.Editable;
			}
			set
			{
				short num = (short)2060298470;
				short num2 = num;
				num = (short)658876646;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1414987776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1876295681;
				if (num != 0)
				{
				}
				num = (short)1020788736;
				if (num != 0)
				{
				}
				this.dataWideDataOnRoaming_A42216.Editable = value;
			}
		}

		// Token: 0x1700546E RID: 21614
		// (get) Token: 0x0600A816 RID: 43030 RVA: 0x009C3D08 File Offset: 0x009C1F08
		internal string DataWideDataOnRoaming_A42216_UILabel
		{
			get
			{
				short num = (short)424411137;
				if (num != 0)
				{
				}
				num = (short)231211008;
				short num2 = num;
				num = (short)1844429432;
				short num3 = num;
				num = (short)1167639160;
				switch (num3 == num)
				{
				}
				num = (short)95223808;
				if (num != 0)
				{
				}
				return this.dataWideDataOnRoaming_A42216.UIName;
			}
		}

		// Token: 0x1700546F RID: 21615
		// (get) Token: 0x0600A817 RID: 43031 RVA: 0x009C3DBC File Offset: 0x009C1FBC
		// (set) Token: 0x0600A818 RID: 43032 RVA: 0x009C3E70 File Offset: 0x009C2070
		internal bool DataWideDataOnRoaming_A42216_HiddenStatic
		{
			get
			{
				short num = (short)1377045081;
				short num2 = num;
				num = (short)870648409;
				switch (num2 == num)
				{
				default:
				{
					num = (short)224329728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)716374016;
				if (num != 0)
				{
				}
				num = (short)695861249;
				if (num != 0)
				{
				}
				return this.dataWideDataOnRoaming_A42216.HiddenStatic;
			}
			set
			{
				short num = (short)510793450;
				short num2 = num;
				num = (short)347215594;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1366228992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1252786177;
				if (num != 0)
				{
				}
				num = (short)2112618496;
				if (num != 0)
				{
				}
				this.dataWideDataOnRoaming_A42216.HiddenStatic = value;
			}
		}

		// Token: 0x17005470 RID: 21616
		// (get) Token: 0x0600A819 RID: 43033 RVA: 0x009C3F28 File Offset: 0x009C2128
		// (set) Token: 0x0600A81A RID: 43034 RVA: 0x009C3FDC File Offset: 0x009C21DC
		internal bool DataWideDataOnRoaming_A42216_HiddenDynamic
		{
			get
			{
				short num = (short)184815047;
				short num2 = num;
				num = (short)168431047;
				switch (num2 == num)
				{
				default:
				{
					num = (short)989003776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)103284736;
				if (num != 0)
				{
				}
				num = (short)601882625;
				if (num != 0)
				{
				}
				return this.dataWideDataOnRoaming_A42216.HiddenDynamic;
			}
			set
			{
				short num = (short)2091843585;
				if (num != 0)
				{
				}
				num = (short)1997471744;
				short num2 = num;
				num = (short)966149055;
				short num3 = num;
				num = (short)1370571711;
				switch (num3 == num)
				{
				}
				num = (short)1372192768;
				if (num != 0)
				{
				}
				this.dataWideDataOnRoaming_A42216.HiddenDynamic = value;
			}
		}

		// Token: 0x17005471 RID: 21617
		// (get) Token: 0x0600A81B RID: 43035 RVA: 0x009C4090 File Offset: 0x009C2290
		public bool DataWideDataOnRoaming_A42216_HasDiffs
		{
			get
			{
				short num = (short)1341265549;
				short num2 = num;
				num = (short)1403000461;
				switch (num2 == num)
				{
				default:
				{
					num = (short)780664832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)537526272;
				if (num != 0)
				{
				}
				num = (short)167313409;
				if (num != 0)
				{
				}
				return this.dataWideDataOnRoaming_A42216._HasDiffs;
			}
		}

		// Token: 0x17005472 RID: 21618
		// (get) Token: 0x0600A81C RID: 43036 RVA: 0x009C4148 File Offset: 0x009C2348
		// (set) Token: 0x0600A81D RID: 43037 RVA: 0x009C41F8 File Offset: 0x009C23F8
		public bool DataWideLTEHWEnableValue
		{
			get
			{
				short num = (short)623000722;
				short num2 = num;
				num = (short)2125479058;
				switch (num2 == num)
				{
				default:
				{
					num = (short)551550976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)136249344;
				if (num != 0)
				{
				}
				num = (short)495386625;
				if (num != 0)
				{
				}
				return this.dataWideLTEHWEnable.Value;
			}
			set
			{
				short num = (short)2135162529;
				short num2 = num;
				num = (short)1934884513;
				switch (num2 == num)
				{
				default:
				{
					num = (short)508493824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1175322625;
				if (num != 0)
				{
				}
				num = (short)1081933824;
				if (num != 0)
				{
				}
				this.dataWideLTEHWEnable.Value = value;
			}
		}

		// Token: 0x17005473 RID: 21619
		// (get) Token: 0x0600A81E RID: 43038 RVA: 0x009C42AC File Offset: 0x009C24AC
		public global::AcpBusinessLayer.AcpField<bool> DataWideLTEHWEnable
		{
			get
			{
				short num = (short)771524115;
				short num2 = num;
				num = (short)1440253459;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1037959168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)930938881;
				if (num != 0)
				{
				}
				num = (short)710148096;
				if (num != 0)
				{
				}
				return this.dataWideLTEHWEnable;
			}
		}

		// Token: 0x17005474 RID: 21620
		// (get) Token: 0x0600A81F RID: 43039 RVA: 0x009C435C File Offset: 0x009C255C
		// (set) Token: 0x0600A820 RID: 43040 RVA: 0x009C4414 File Offset: 0x009C2614
		public bool DataWideLTEHWEnable_UIValue
		{
			get
			{
				short num = (short)1587874410;
				short num2 = num;
				num = (short)441780842;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2117271552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)117964801;
				if (num != 0)
				{
				}
				num = (short)667025408;
				if (num != 0)
				{
				}
				return this.dataWideLTEHWEnable.Value;
			}
			set
			{
				short num = (short)971647869;
				short num2 = num;
				num = (short)1901472637;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1343160320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)370016257;
				if (num != 0)
				{
				}
				num = (short)785055744;
				if (num != 0)
				{
				}
				this.dataWideLTEHWEnable.Value = value;
			}
		}

		// Token: 0x17005475 RID: 21621
		// (get) Token: 0x0600A821 RID: 43041 RVA: 0x009C44C8 File Offset: 0x009C26C8
		// (set) Token: 0x0600A822 RID: 43042 RVA: 0x009C4580 File Offset: 0x009C2780
		public bool DataWideLTEHWEnable_Applicable
		{
			get
			{
				short num = (short)1834942465;
				if (num != 0)
				{
				}
				num = (short)2026962944;
				short num2 = num;
				num = (short)660766185;
				short num3 = num;
				num = (short)169311721;
				switch (num3 == num)
				{
				}
				num = (short)122748928;
				if (num != 0)
				{
				}
				return this.dataWideLTEHWEnable.Applicable;
			}
			set
			{
				short num = (short)786630011;
				short num2 = num;
				num = (short)973735291;
				switch (num2 == num)
				{
				default:
				{
					num = (short)663552000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)409468929;
				if (num != 0)
				{
				}
				num = (short)1706295296;
				if (num != 0)
				{
				}
				this.dataWideLTEHWEnable.Applicable = value;
			}
		}

		// Token: 0x17005476 RID: 21622
		// (get) Token: 0x0600A823 RID: 43043 RVA: 0x009C4634 File Offset: 0x009C2834
		// (set) Token: 0x0600A824 RID: 43044 RVA: 0x009C46E8 File Offset: 0x009C28E8
		public bool DataWideLTEHWEnable_Valid
		{
			get
			{
				short num = (short)1979861545;
				short num2 = num;
				num = (short)1277053481;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1611268096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1450246145;
				if (num != 0)
				{
				}
				num = (short)456392704;
				if (num != 0)
				{
				}
				return this.dataWideLTEHWEnable.Valid;
			}
			set
			{
				short num = (short)1292464322;
				short num2 = num;
				num = (short)401502402;
				switch (num2 == num)
				{
				default:
				{
					num = (short)713228288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1222115329;
				if (num != 0)
				{
				}
				num = (short)516751360;
				if (num != 0)
				{
				}
				this.dataWideLTEHWEnable.Valid = value;
			}
		}

		// Token: 0x17005477 RID: 21623
		// (get) Token: 0x0600A825 RID: 43045 RVA: 0x009C479C File Offset: 0x009C299C
		// (set) Token: 0x0600A826 RID: 43046 RVA: 0x009C4850 File Offset: 0x009C2A50
		public bool DataWideLTEHWEnable_Visible
		{
			get
			{
				short num = (short)2029943181;
				short num2 = num;
				num = (short)1112635789;
				switch (num2 == num)
				{
				default:
				{
					num = (short)381419520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)968884224;
				if (num != 0)
				{
				}
				num = (short)581173249;
				if (num != 0)
				{
				}
				return this.dataWideLTEHWEnable.Visible;
			}
			set
			{
				short num = (short)1505359934;
				short num2 = num;
				num = (short)727447614;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1562116096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)936312833;
				if (num != 0)
				{
				}
				num = (short)1641414656;
				if (num != 0)
				{
				}
				this.dataWideLTEHWEnable.Visible = value;
			}
		}

		// Token: 0x17005478 RID: 21624
		// (get) Token: 0x0600A827 RID: 43047 RVA: 0x009C4904 File Offset: 0x009C2B04
		// (set) Token: 0x0600A828 RID: 43048 RVA: 0x009C49BC File Offset: 0x009C2BBC
		public bool DataWideLTEHWEnable_Editable
		{
			get
			{
				short num = (short)786182203;
				short num2 = num;
				num = (short)310456379;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1486553088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1296171009;
				if (num != 0)
				{
				}
				num = (short)1534722048;
				if (num != 0)
				{
				}
				return this.dataWideLTEHWEnable.Editable;
			}
			set
			{
				short num = (short)1273507741;
				short num2 = num;
				num = (short)2129997725;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2117009408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1016528896;
				if (num != 0)
				{
				}
				num = (short)1480720385;
				if (num != 0)
				{
				}
				this.dataWideLTEHWEnable.Editable = value;
			}
		}

		// Token: 0x17005479 RID: 21625
		// (get) Token: 0x0600A829 RID: 43049 RVA: 0x009C4A70 File Offset: 0x009C2C70
		internal string DataWideLTEHWEnable_UILabel
		{
			get
			{
				short num = (short)1428108739;
				short num2 = num;
				num = (short)956249539;
				switch (num2 == num)
				{
				default:
				{
					num = (short)945684480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2130903040;
				if (num != 0)
				{
				}
				num = (short)2041184257;
				if (num != 0)
				{
				}
				return this.dataWideLTEHWEnable.UIName;
			}
		}

		// Token: 0x1700547A RID: 21626
		// (get) Token: 0x0600A82A RID: 43050 RVA: 0x009C4B24 File Offset: 0x009C2D24
		// (set) Token: 0x0600A82B RID: 43051 RVA: 0x009C4BD8 File Offset: 0x009C2DD8
		internal bool DataWideLTEHWEnable_HiddenStatic
		{
			get
			{
				short num = (short)557172396;
				short num2 = num;
				num = (short)485934764;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1173684224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1178730497;
				if (num != 0)
				{
				}
				num = (short)498335744;
				if (num != 0)
				{
				}
				return this.dataWideLTEHWEnable.HiddenStatic;
			}
			set
			{
				short num = (short)674423673;
				short num2 = num;
				num = (short)15590265;
				switch (num2 == num)
				{
				default:
				{
					num = (short)138084352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1838022656;
				if (num != 0)
				{
				}
				num = (short)1483341825;
				if (num != 0)
				{
				}
				this.dataWideLTEHWEnable.HiddenStatic = value;
			}
		}

		// Token: 0x1700547B RID: 21627
		// (get) Token: 0x0600A82C RID: 43052 RVA: 0x009C4C90 File Offset: 0x009C2E90
		// (set) Token: 0x0600A82D RID: 43053 RVA: 0x009C4D44 File Offset: 0x009C2F44
		internal bool DataWideLTEHWEnable_HiddenDynamic
		{
			get
			{
				short num = (short)979006756;
				short num2 = num;
				num = (short)1257207076;
				switch (num2 == num)
				{
				default:
				{
					num = (short)261816320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)61472769;
				if (num != 0)
				{
				}
				num = (short)575471616;
				if (num != 0)
				{
				}
				return this.dataWideLTEHWEnable.HiddenDynamic;
			}
			set
			{
				short num = (short)477642945;
				short num2 = num;
				num = (short)1306673345;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1483866112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1330184193;
				if (num != 0)
				{
				}
				num = (short)1517355008;
				if (num != 0)
				{
				}
				this.dataWideLTEHWEnable.HiddenDynamic = value;
			}
		}

		// Token: 0x1700547C RID: 21628
		// (get) Token: 0x0600A82E RID: 43054 RVA: 0x009C4DFC File Offset: 0x009C2FFC
		public bool DataWideLTEHWEnable_HasDiffs
		{
			get
			{
				short num = (short)1079741101;
				short num2 = num;
				num = (short)61246125;
				switch (num2 == num)
				{
				default:
				{
					num = (short)248905728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1788608512;
				if (num != 0)
				{
				}
				num = (short)1434779649;
				if (num != 0)
				{
				}
				return this.dataWideLTEHWEnable._HasDiffs;
			}
		}

		// Token: 0x0600A82F RID: 43055 RVA: 0x009C4EB0 File Offset: 0x009C30B0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_00:
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
						num2 = (short)89718785;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
					{
						num2 = (short)1349195668;
						short num3 = num2;
						num2 = (short)1099831188;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1018888192;
							if (num2 != 0)
							{
							}
							if (base.ParentRecset.ContainerDoc != null)
							{
								num2 = (short)1310392323;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return result;
						}
						break;
					}
					case 2:
						return result;
					case 3:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)844496898;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
					{
						num2 = (short)201064449;
						if (num2 != 0)
						{
						}
						num2 = (short)37027840;
						short num4 = num2;
						if (base.ParentRecset != null)
						{
							num2 = (short)1423704064;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					}
					break;
				}
				IL_24:
				result = null;
				num2 = (short)1829306372;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x0400512A RID: 20778
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideLTELTECheckbackTime_A42205;

		// Token: 0x0400512B RID: 20779
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideLTEOutOfRangeThresholdTime_A42206;

		// Token: 0x0400512C RID: 20780
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideLTEOffMaxDetachTime_A42207;

		// Token: 0x0400512D RID: 20781
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideLTEModeChangeMaxDetachTime_A42208;

		// Token: 0x0400512E RID: 20782
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideLTEOpenMaxGuardTime_A42391;

		// Token: 0x0400512F RID: 20783
		private global::AcpBusinessLayer.AcpField<string> dataWideLTEClass3AccessPointName_A42392;

		// Token: 0x04005130 RID: 20784
		private global::AcpBusinessLayer.AcpField<bool> dataWideLTEOperation_A42215;

		// Token: 0x04005131 RID: 20785
		private global::AcpBusinessLayer.AcpField<bool> dataWideDataOnRoaming_A42216;

		// Token: 0x04005132 RID: 20786
		private global::AcpBusinessLayer.AcpField<bool> dataWideLTEHWEnable;
	}
}
