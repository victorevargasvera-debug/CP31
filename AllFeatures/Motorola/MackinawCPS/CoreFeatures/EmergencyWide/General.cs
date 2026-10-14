using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.EmergencyWide
{
	// Token: 0x02000491 RID: 1169
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009955 RID: 39253 RVA: 0x008FC644 File Offset: 0x008FA844
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06009956 RID: 39254 RVA: 0x008FC660 File Offset: 0x008FA860
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009957 RID: 39255 RVA: 0x008FC678 File Offset: 0x008FA878
		public override void Init()
		{
			int a_ = 10;
			short num = (short)556438421;
			short num2 = num;
			num = (short)2130547605;
			switch (num2 == num)
			{
			}
			num = (short)582811649;
			if (num != 0)
			{
			}
			num = (short)1215954944;
			short num3 = num;
			num = (short)1324613632;
			if (num != 0)
			{
			}
			this.emerWideGeneralChannelDelaysec_A7657 = new global::AcpBusinessLayer.AcpSimpleRangeField(2, this, global::AllFeatures.CodeplugGuid.b("車ꃌ꫎ꏐ蓒볔돖볘鳚룜뇞蓠釢蓤详ꫨ菪賬臮鿰雲駴돶鳸韺鳼蛾爀昂昄堆䠈㰊㬌㨎☐", a_), global::CommonResources.AcgResources.ID_CHANNELDELAYSEC, 0, 7, null, null, 0, 1);
			this.emerWideGeneralChannelDelaysec_A7657.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emerWideGeneralChannelDelaysec_A7657.DataTransferOrder = 3;
			this.emerWideGeneralChannelDelaysec_A7657.ShowHexValue = false;
			this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("車ꃌ꫎ꏐ蓒볔돖볘鳚룜뇞蓠釢蓤详골蛪裬鷮雰雲鯴银胸뫺釼黾猀渂圄缆䀈攊椌明爐爒愔砖欘会搜漞䐠簢搤ဦဨᠪḬ", a_), global::CommonResources.AcgResources.ID_EMERGENCYALARMRXINDICATORTYPE, global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.LOVs.EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933LovStrs);
			this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.DataTransferOrder = 4;
			this.emerWideGeneralEmergencyCallReceive_A7937 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("車ꃌ꫎ꏐ蓒볔돖볘鳚룜뇞蓠釢蓤详골蛪裬鷮雰雲鯴银胸룺鳼鏾洀儂怄搆氈戊笌樎丐划∔⸖⨘Ⱊ", a_), global::CommonResources.AcgResources.ID_EMERGENCYCALLRECEIVE);
			this.emerWideGeneralEmergencyCallReceive_A7937.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emerWideGeneralEmergencyCallReceive_A7937.DataTransferOrder = 1;
			this.emerWideGeneralEmergencyPowerUp_A7942 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("車ꃌ꫎ꏐ蓒볔돖볘鳚룜뇞蓠釢蓤详골蛪裬鷮雰雲鯴银胸꯺鋼裾搀焂倄眆嘈䨊㨌㘎┐ℒ", a_), global::CommonResources.AcgResources.ID_EMERGENCYPOWERUP);
			this.emerWideGeneralEmergencyPowerUp_A7942.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emerWideGeneralEmergencyPowerUp_A7942.DataTransferOrder = 5;
			this.emerWideGeneralKeepAlive_A8360 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("車ꃌ꫎ꏐ蓒볔돖볘鳚룜뇞蓠釢蓤详ꋨ軪裬鿮냰鿲鳴臶鳸ꓺ볼쟾㈀㔂㔄", a_), global::CommonResources.AcgResources.ID_KEEPALIVE);
			this.emerWideGeneralKeepAlive_A8360.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emerWideGeneralKeepAlive_A8360.DataTransferOrder = 6;
			this.emerWideGeneralSilentAlarm_A9130 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("車ꃌ꫎ꏐ蓒볔돖볘鳚룜뇞蓠釢蓤详뫨苪臬諮鿰蟲듴鯶飸觺郼ꃾ䀀㨂㐄㐆㤈", a_), global::CommonResources.AcgResources.ID_SILENTALARM);
			this.emerWideGeneralSilentAlarm_A9130.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emerWideGeneralSilentAlarm_A9130.DataTransferOrder = 2;
			this.emerWideGeneralUnmuteOption_A9598 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("車ꃌ꫎ꏐ蓒볔돖볘鳚룜뇞蓠釢蓤详볨藪胬髮藰雲뫴蟶跸鋺鋼釾帀䈂㰄㈆〈㌊", a_), global::CommonResources.AcgResources.ID_UNMUTEOPTION);
			this.emerWideGeneralUnmuteOption_A9598.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emerWideGeneralUnmuteOption_A9598.DataTransferOrder = 15;
			this.emerWideGeneralSuppressEmergencyCall_A42142 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("車ꃌ꫎ꏐ蓒볔돖볘鳚룜뇞蓠釢蓤详뫨黪鷬鿮菰雲蛴蓶본雺飼跾昀昂欄搆瀈䠊氌挎紐䰒吔⌖⬘⨚⤜ⴞ", a_), global::CommonResources.AcgResources.ID_DISABLEEMERGENCYCALLINDICATIONS);
			this.emerWideGeneralSuppressEmergencyCall_A42142.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emerWideGeneralSuppressEmergencyCall_A42142.DataTransferOrder = 7;
			this.emerWideGeneralDistinguishEmergencyType_43546 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("車ꃌ꫎ꏐ蓒볔돖볘鳚룜뇞蓠釢蓤详귨苪黬鯮飰鷲鋴苶郸裺闼뫾氀昂眄怆氈攊渌瘎䔐樒攔爖䘘⼚⸜⨞ᔠᔢ", a_), global::CommonResources.AcgResources.ID_DISTINGUISHEMERGENCYTYPE);
			this.emerWideGeneralDistinguishEmergencyType_43546.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emerWideGeneralDistinguishEmergencyType_43546.DataTransferOrder = 50;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("賊꣌ꇎ듐ꇒ듔믖", a_);
			base.Id = 10074;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06009958 RID: 39256 RVA: 0x008FC96C File Offset: 0x008FAB6C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 15;
			short num = (short)699203594;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ迗동룛믝꟟蟡諣菥髧诩胫귭飯鏱髳飵鷷雹룻鯽泿持紃甅洇椉匋伍✏␑ℓℕ", a_)))
					{
						num = (short)586154006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19A;
				case 1:
					goto IL_D1;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ迗동룛믝꟟蟡諣菥髧诩胫꯭鷯韱蛳釵鷷铹鿻蟽僿洁猃挅稇弉簋儍儏┑ⴓ∕⨗", a_)))
					{
						num = (short)1709572120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_33B;
				case 3:
				{
					num = (short)1229640458;
					short num3 = num;
					num = (short)1994969866;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D1;
					default:
						num = (short)2084241408;
						if (num != 0)
						{
						}
						this.emerWideGeneralEmergencyCallReceive_A7937 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ迗동룛믝꟟蟡諣菥髧诩胫꯭鷯韱蛳釵鷷铹鿻蟽䏿持栃樅娇漉漋欍礏搑焓䤕夗ⴙ┛ⴝᜟ", a_), global::CommonResources.AcgResources.ID_EMERGENCYCALLRECEIVE);
						this.emerWideGeneralEmergencyCallReceive_A7937.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
						this.emerWideGeneralEmergencyCallReceive_A7937.DataTransferOrder = 1;
						num = (short)1912668180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ迗동룛믝꟟蟡諣菥髧诩胫뷭駯黱釳飵賷믹郻鿽狿漁嬃䜅ㄇ㬉㼋㸍", a_)))
					{
						num = (short)1616576527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D1;
				case 5:
					goto IL_4AF;
				case 6:
					num = (short)643039251;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ迗동룛믝꟟蟡諣菥髧诩胫꯭鷯韱蛳釵鷷铹鿻蟽䇿渁攃琅攇堉琋䜍縏瘑紓甕礗渙猛氝琟嬡吣䌥眧欩ᬫᜭ̯ı", a_)))
					{
						num = (short)614531083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_58B;
				case 8:
					goto IL_58B;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ迗동룛믝꟟蟡諣菥髧诩胫ꫭ駯臱胳鿵雷鷹觻韽珿樁䄃欅洇砉欋欍縏焑洓䈕愗標礛䄝ᐟᄡᄣሥḧ", a_)))
					{
						num = (short)738656284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_768;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_AA;
					}
					continue;
				case 11:
					this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ迗동룛믝꟟蟡諣菥髧诩胫꯭鷯韱蛳釵鷷铹鿻蟽䇿渁攃琅攇堉琋䜍縏瘑紓甕礗渙猛氝琟嬡吣䌥眧欩ᬫᜭ̯ı", a_), global::CommonResources.AcgResources.ID_EMERGENCYALARMRXINDICATORTYPE, global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.LOVs.EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933LovStrs);
					this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.DataTransferOrder = 4;
					num = (short)123666440;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ迗동룛믝꟟蟡諣菥髧诩胫뷭藯英蓳蓵鷷觹迻믽淿朁瘃愅洇搉漋眍匏猑砓稕䜗嬙⠛Ⱍᄟᘡᘣ", a_)))
					{
						num = (short)295960597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2EE;
				case 13:
					goto IL_19A;
				case 14:
					this.emerWideGeneralKeepAlive_A8360 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ迗동룛믝꟟蟡諣菥髧诩胫ꗭ闯韱蓳럵铷鏹諻鯽忿䌁㰃㔅㸇㨉", a_), global::CommonResources.AcgResources.ID_KEEPALIVE);
					this.emerWideGeneralKeepAlive_A8360.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emerWideGeneralKeepAlive_A8360.DataTransferOrder = 6;
					num = (short)1764425757;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					this.emerWideGeneralSilentAlarm_A9130 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ迗동룛믝꟟蟡諣菥髧诩胫뷭駯黱釳飵賷믹郻鿽狿漁嬃䜅ㄇ㬉㼋㸍", a_), global::CommonResources.AcgResources.ID_SILENTALARM);
					this.emerWideGeneralSilentAlarm_A9130.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emerWideGeneralSilentAlarm_A9130.DataTransferOrder = 2;
					num = (short)1684537345;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ迗동룛믝꟟蟡諣菥髧诩胫ꗭ闯韱蓳럵铷鏹諻鯽忿䌁㰃㔅㸇㨉", a_)))
					{
						num = (short)429654030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6C7;
				case 17:
					num = (short)675807233;
					if (num != 0)
					{
					}
					this.emerWideGeneralUnmuteOption_A9598 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ迗동룛믝꟟蟡諣菥髧诩胫믭黯鿱至苵鷷뗹賻諽槿洁樃夅䤇㌉㤋㜍⠏", a_), global::CommonResources.AcgResources.ID_UNMUTEOPTION);
					this.emerWideGeneralUnmuteOption_A9598.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emerWideGeneralUnmuteOption_A9598.DataTransferOrder = 15;
					num = (short)30212126;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_2EE;
				case 19:
					if (producerFields != null)
					{
						num = (short)1611726875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_768;
				case 20:
					goto IL_623;
				case 21:
				{
					num = (short)567148544;
					short num4 = num;
					this.emerWideGeneralSuppressEmergencyCall_A42142 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ迗동룛믝꟟蟡諣菥髧诩胫뷭藯英蓳蓵鷷觹迻믽淿朁瘃愅洇搉漋眍匏猑砓稕䜗嬙⠛Ⱍᄟᘡᘣ", a_), global::CommonResources.AcgResources.ID_DISABLEEMERGENCYCALLINDICATIONS);
					this.emerWideGeneralSuppressEmergencyCall_A42142.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emerWideGeneralSuppressEmergencyCall_A42142.DataTransferOrder = 7;
					num = (short)1583022098;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 22:
					this.emerWideGeneralChannelDelaysec_A7657 = new global::AcpBusinessLayer.AcpSimpleRangeField(2, this, global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ迗동룛믝꟟蟡諣菥髧诩胫귭飯鏱髳飵鷷雹룻鯽泿持紃甅洇椉匋伍✏␑ℓℕ", a_), global::CommonResources.AcgResources.ID_CHANNELDELAYSEC, null, null, 0, 1);
					this.emerWideGeneralChannelDelaysec_A7657.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emerWideGeneralChannelDelaysec_A7657.DataTransferOrder = 3;
					this.emerWideGeneralChannelDelaysec_A7657.ShowHexValue = false;
					num = (short)1004208141;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ迗동룛믝꟟蟡諣菥髧诩胫꯭鷯韱蛳釵鷷铹鿻蟽䏿持栃樅娇漉漋欍礏搑焓䤕夗ⴙ┛ⴝᜟ", a_)))
					{
						num = (short)210108419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_623;
				case 24:
					this.emerWideGeneralEmergencyPowerUp_A7942 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ迗동룛믝꟟蟡諣菥髧诩胫꯭鷯韱蛳釵鷷铹鿻蟽僿洁猃挅稇弉簋儍儏┑ⴓ∕⨗", a_), global::CommonResources.AcgResources.ID_EMERGENCYPOWERUP);
					this.emerWideGeneralEmergencyPowerUp_A7942.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emerWideGeneralEmergencyPowerUp_A7942.DataTransferOrder = 5;
					num = (short)1314979865;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					goto IL_33B;
				case 26:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ迗동룛믝꟟蟡諣菥髧诩胫믭黯鿱至苵鷷뗹賻諽槿洁樃夅䤇㌉㤋㜍⠏", a_)))
					{
						num = (short)1286144017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E6;
				case 27:
					num = (short)1742209024;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					this.emerWideGeneralDistinguishEmergencyType_43546 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ迗동룛믝꟟蟡諣菥髧诩胫ꫭ駯臱胳鿵雷鷹觻韽珿樁䄃欅洇砉欋欍縏焑洓䈕愗標礛䄝ᐟᄡᄣሥḧ", a_), global::CommonResources.AcgResources.ID_DISTINGUISHEMERGENCYTYPE);
					this.emerWideGeneralDistinguishEmergencyType_43546.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emerWideGeneralDistinguishEmergencyType_43546.DataTransferOrder = 50;
					num = (short)540082181;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					goto IL_6C7;
				case 30:
					goto IL_1E6;
				}
				IL_AA:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1951203334;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_D1:
				num = (short)707919898;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_19A:
				num = (short)514129927;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E6:
				num = (short)1666187276;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2EE:
				num = (short)531693577;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_33B:
				num = (short)77660176;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_58B:
				num = (short)53674007;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_623:
				num = (short)969080834;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6C7:
				num = (short)942800900;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4AF:
			IL_768:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("韏럑뫓돕꫗믙냛", a_);
			base.Id = 10074;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06009959 RID: 39257 RVA: 0x008FD114 File Offset: 0x008FB314
		public override void PopulateReferences()
		{
			short num = (short)1884815361;
			if (num != 0)
			{
			}
			num = (short)1110800053;
			short num2 = num;
			num = (short)1034581685;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1882587136;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1863647232;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600995A RID: 39258 RVA: 0x008FD1BC File Offset: 0x008FB3BC
		public override void DropReferences()
		{
			short num = (short)1499072918;
			short num2 = num;
			num = (short)751962518;
			switch (num2 == num)
			{
			}
			num = (short)624230400;
			short num3 = num;
			num = (short)1131741184;
			if (num != 0)
			{
			}
			num = (short)216006657;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600995B RID: 39259 RVA: 0x008FD264 File Offset: 0x008FB464
		public override void SetConstraints()
		{
			short num = (short)350437524;
			short num2 = num;
			num = (short)2136621204;
			switch (num2 == num)
			{
			}
			num = (short)2072903680;
			short num3 = num;
			num = (short)1095368705;
			if (num != 0)
			{
			}
			num = (short)547684352;
			if (num != 0)
			{
			}
			this.emerWideGeneralEmergencyCallReceive_A7937.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.conEmerSilentAlarmIsDisabled);
			this.emerWideGeneralEmergencyPowerUp_A7942.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.ConDualRadioSystemIsNOTSecondaryApp);
			this.emerWideGeneralEmergencyPowerUp_A7942.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.ConMCHAndIgnitionNotInhibit);
			this.emerWideGeneralKeepAlive_A8360.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.ConEmerWideKeepAliveValid);
			this.emerWideGeneralSilentAlarm_A9130.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.conRXIndIsDisabled);
			this.emerWideGeneralUnmuteOption_A9598.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.ConSilientAlarmEnabled);
			this.emerWideGeneralUnmuteOption_A9598.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.ConUnmuteOptionValid);
			this.emerWideGeneralSuppressEmergencyCall_A42142.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.DisableEmergencyCallIndicationsApplicable);
			this.emerWideGeneralSuppressEmergencyCall_A42142.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.ConDisableEmergencyCallIndicationsValid);
			this.emerWideGeneralDistinguishEmergencyType_43546.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.ConEmerConfEmerWideDistingEmerTypeAllow);
		}

		// Token: 0x0600995C RID: 39260 RVA: 0x008FD3F4 File Offset: 0x008FB5F4
		public override void SetupDependencies()
		{
			short num = (short)1958202089;
			short num2 = num;
			num = (short)2040449769;
			switch (num2 == num)
			{
			}
			num = (short)1433337856;
			short num3 = num;
			num = (short)2089222145;
			if (num != 0)
			{
			}
			num = (short)992215040;
			if (num != 0)
			{
			}
			this.emerWideGeneralSilentAlarm_A9130.AddDependentObject(this.emerWideGeneralEmergencyCallReceive_A7937);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.emerWideGeneralEmergencyPowerUp_A7942);
			this.RefRadioWide.Features.SwitchConventionalSwitchesPosition1_A12643.AddDependentObject(this.emerWideGeneralEmergencyPowerUp_A7942);
			this.emerWideGeneralEmergencyCallReceive_A7937.AddDependentObject(this.emerWideGeneralSilentAlarm_A9130);
			this.emerWideGeneralSuppressEmergencyCall_A42142.AddDependentObject(this.emerWideGeneralUnmuteOption_A9598);
			this.emerWideGeneralSilentAlarm_A9130.AddDependentObject(this.emerWideGeneralUnmuteOption_A9598);
			this.emerWideGeneralSilentAlarm_A9130.AddDependentObject(this.emerWideGeneralSuppressEmergencyCall_A42142);
			this.RefRadioWide.TPS.RadWideTPSAudibleEmergencyBeaconsec_A7502.AddDependentObject(this.emerWideGeneralSuppressEmergencyCall_A42142);
			this.RefRadioWide.TPS.RadWideTPSFiregroundEmergencyCallDekeySidetone_A7936.AddDependentObject(this.emerWideGeneralSuppressEmergencyCall_A42142);
		}

		// Token: 0x17004CF8 RID: 19704
		// (get) Token: 0x0600995D RID: 39261 RVA: 0x008FD56C File Offset: 0x008FB76C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1619980220;
				short num2 = num;
				num = (short)2056777660;
				switch (num2 == num)
				{
				}
				num = (short)883425280;
				short num3 = num;
				num = (short)997392385;
				if (num != 0)
				{
				}
				num = (short)39190528;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004CF9 RID: 19705
		// (get) Token: 0x0600995E RID: 39262 RVA: 0x008FD61C File Offset: 0x008FB81C
		// (set) Token: 0x0600995F RID: 39263 RVA: 0x008FD6D0 File Offset: 0x008FB8D0
		public int EmerWideGeneralChannelDelaysec_A7657Value
		{
			get
			{
				short num = (short)50212216;
				short num2 = num;
				num = (short)1253715320;
				switch (num2 == num)
				{
				}
				num = (short)1327235072;
				short num3 = num;
				num = (short)35323904;
				if (num != 0)
				{
				}
				num = (short)853671937;
				if (num != 0)
				{
				}
				return this.emerWideGeneralChannelDelaysec_A7657.Value;
			}
			set
			{
				short num = (short)1111883777;
				if (num != 0)
				{
				}
				num = (short)1338790017;
				short num2 = num;
				num = (short)1790267521;
				switch (num2 == num)
				{
				default:
				{
					num = (short)971571200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1254555648;
				if (num != 0)
				{
				}
				this.emerWideGeneralChannelDelaysec_A7657.Value = value;
			}
		}

		// Token: 0x17004CFA RID: 19706
		// (get) Token: 0x06009960 RID: 39264 RVA: 0x008FD784 File Offset: 0x008FB984
		public global::AcpBusinessLayer.AcpSimpleRangeField EmerWideGeneralChannelDelaysec_A7657
		{
			get
			{
				short num = (short)1919324959;
				short num2 = num;
				num = (short)408851231;
				switch (num2 == num)
				{
				}
				num = (short)2056912896;
				short num3 = num;
				num = (short)1390411776;
				if (num != 0)
				{
				}
				num = (short)631177217;
				if (num != 0)
				{
				}
				return this.emerWideGeneralChannelDelaysec_A7657;
			}
		}

		// Token: 0x17004CFB RID: 19707
		// (get) Token: 0x06009961 RID: 39265 RVA: 0x008FD834 File Offset: 0x008FBA34
		// (set) Token: 0x06009962 RID: 39266 RVA: 0x008FD8EC File Offset: 0x008FBAEC
		public string EmerWideGeneralChannelDelaysec_A7657_UIValue
		{
			get
			{
				short num = (short)1679818178;
				short num2 = num;
				num = (short)348454338;
				switch (num2 == num)
				{
				}
				num = (short)713883648;
				short num3 = num;
				num = (short)730267648;
				if (num != 0)
				{
				}
				num = (short)1196556289;
				if (num != 0)
				{
				}
				return this.emerWideGeneralChannelDelaysec_A7657.UIValue;
			}
			set
			{
				short num = (short)2038432099;
				short num2 = num;
				num = (short)422510947;
				switch (num2 == num)
				{
				}
				num = (short)1014431744;
				short num3 = num;
				num = (short)1524236288;
				if (num != 0)
				{
				}
				num = (short)816119809;
				if (num != 0)
				{
				}
				this.emerWideGeneralChannelDelaysec_A7657.UIValue = value;
			}
		}

		// Token: 0x17004CFC RID: 19708
		// (get) Token: 0x06009963 RID: 39267 RVA: 0x008FD9A0 File Offset: 0x008FBBA0
		// (set) Token: 0x06009964 RID: 39268 RVA: 0x008FDA54 File Offset: 0x008FBC54
		internal int EmerWideGeneralChannelDelaysec_A7657Min
		{
			get
			{
				short num = (short)1382768032;
				short num2 = num;
				num = (short)1095851424;
				switch (num2 == num)
				{
				}
				num = (short)1277165568;
				short num3 = num;
				num = (short)762183681;
				if (num != 0)
				{
				}
				num = (short)1488060416;
				if (num != 0)
				{
				}
				return this.emerWideGeneralChannelDelaysec_A7657.Min;
			}
			set
			{
				short num = (short)1256320517;
				short num2 = num;
				num = (short)1432219141;
				switch (num2 == num)
				{
				}
				num = (short)450101248;
				short num3 = num;
				num = (short)1894580225;
				if (num != 0)
				{
				}
				num = (short)1686175744;
				if (num != 0)
				{
				}
				this.emerWideGeneralChannelDelaysec_A7657.Min = value;
			}
		}

		// Token: 0x17004CFD RID: 19709
		// (get) Token: 0x06009965 RID: 39269 RVA: 0x008FDB08 File Offset: 0x008FBD08
		// (set) Token: 0x06009966 RID: 39270 RVA: 0x008FDBBC File Offset: 0x008FBDBC
		internal int EmerWideGeneralChannelDelaysec_A7657Max
		{
			get
			{
				short num = (short)684543601;
				short num2 = num;
				num = (short)1404259953;
				switch (num2 == num)
				{
				}
				num = (short)473169920;
				short num3 = num;
				num = (short)759431168;
				if (num != 0)
				{
				}
				num = (short)1760755713;
				if (num != 0)
				{
				}
				return this.emerWideGeneralChannelDelaysec_A7657.Max;
			}
			set
			{
				short num = (short)1880860723;
				short num2 = num;
				num = (short)331196467;
				switch (num2 == num)
				{
				}
				num = (short)1874460672;
				short num3 = num;
				num = (short)848953345;
				if (num != 0)
				{
				}
				num = (short)817692672;
				if (num != 0)
				{
				}
				this.emerWideGeneralChannelDelaysec_A7657.Max = value;
			}
		}

		// Token: 0x17004CFE RID: 19710
		// (get) Token: 0x06009967 RID: 39271 RVA: 0x008FDC74 File Offset: 0x008FBE74
		// (set) Token: 0x06009968 RID: 39272 RVA: 0x008FDD28 File Offset: 0x008FBF28
		internal int EmerWideGeneralChannelDelaysec_A7657Step
		{
			get
			{
				short num = (short)149473162;
				short num2 = num;
				num = (short)943310730;
				switch (num2 == num)
				{
				}
				num = (short)371654656;
				short num3 = num;
				num = (short)1653211136;
				if (num != 0)
				{
				}
				num = (short)1570045953;
				if (num != 0)
				{
				}
				return this.emerWideGeneralChannelDelaysec_A7657.StepSize;
			}
			set
			{
				short num = (short)1666842625;
				if (num != 0)
				{
				}
				num = (short)521000215;
				short num2 = num;
				num = (short)1168430359;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1662124032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)726663168;
				if (num != 0)
				{
				}
				this.emerWideGeneralChannelDelaysec_A7657.StepSize = value;
			}
		}

		// Token: 0x17004CFF RID: 19711
		// (get) Token: 0x06009969 RID: 39273 RVA: 0x008FDDE0 File Offset: 0x008FBFE0
		// (set) Token: 0x0600996A RID: 39274 RVA: 0x008FDE94 File Offset: 0x008FC094
		public bool EmerWideGeneralChannelDelaysec_A7657_Applicable
		{
			get
			{
				short num = (short)961155217;
				short num2 = num;
				num = (short)350883985;
				switch (num2 == num)
				{
				}
				num = (short)792133632;
				short num3 = num;
				num = (short)1616576512;
				if (num != 0)
				{
				}
				num = (short)187826177;
				if (num != 0)
				{
				}
				return this.emerWideGeneralChannelDelaysec_A7657.Applicable;
			}
			set
			{
				short num = (short)53936129;
				if (num != 0)
				{
				}
				num = (short)272109786;
				short num2 = num;
				num = (short)23662810;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2125463552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)623968256;
				if (num != 0)
				{
				}
				this.emerWideGeneralChannelDelaysec_A7657.Applicable = value;
			}
		}

		// Token: 0x17004D00 RID: 19712
		// (get) Token: 0x0600996B RID: 39275 RVA: 0x008FDF4C File Offset: 0x008FC14C
		// (set) Token: 0x0600996C RID: 39276 RVA: 0x008FE000 File Offset: 0x008FC200
		public bool EmerWideGeneralChannelDelaysec_A7657_Valid
		{
			get
			{
				short num = (short)22244759;
				short num2 = num;
				num = (short)1963879831;
				switch (num2 == num)
				{
				}
				num = (short)1702232064;
				short num3 = num;
				num = (short)1823604737;
				if (num != 0)
				{
				}
				num = (short)1912537088;
				if (num != 0)
				{
				}
				return this.emerWideGeneralChannelDelaysec_A7657.Valid;
			}
			set
			{
				short num = (short)764366859;
				short num2 = num;
				num = (short)25776139;
				switch (num2 == num)
				{
				}
				num = (short)572194816;
				short num3 = num;
				num = (short)282853376;
				if (num != 0)
				{
				}
				num = (short)1812398081;
				if (num != 0)
				{
				}
				this.emerWideGeneralChannelDelaysec_A7657.Valid = value;
			}
		}

		// Token: 0x17004D01 RID: 19713
		// (get) Token: 0x0600996D RID: 39277 RVA: 0x008FE0B8 File Offset: 0x008FC2B8
		// (set) Token: 0x0600996E RID: 39278 RVA: 0x008FE16C File Offset: 0x008FC36C
		public bool EmerWideGeneralChannelDelaysec_A7657_Visible
		{
			get
			{
				short num = (short)1562112264;
				short num2 = num;
				num = (short)201257224;
				switch (num2 == num)
				{
				}
				num = (short)1964310528;
				short num3 = num;
				num = (short)1818427392;
				if (num != 0)
				{
				}
				num = (short)1342701569;
				if (num != 0)
				{
				}
				return this.emerWideGeneralChannelDelaysec_A7657.Visible;
			}
			set
			{
				short num = (short)93716849;
				short num2 = num;
				num = (short)2076705137;
				switch (num2 == num)
				{
				}
				num = (short)172949504;
				short num3 = num;
				num = (short)121176065;
				if (num != 0)
				{
				}
				num = (short)514457600;
				if (num != 0)
				{
				}
				this.emerWideGeneralChannelDelaysec_A7657.Visible = value;
			}
		}

		// Token: 0x17004D02 RID: 19714
		// (get) Token: 0x0600996F RID: 39279 RVA: 0x008FE224 File Offset: 0x008FC424
		// (set) Token: 0x06009970 RID: 39280 RVA: 0x008FE2D8 File Offset: 0x008FC4D8
		public bool EmerWideGeneralChannelDelaysec_A7657_Editable
		{
			get
			{
				short num = (short)748945409;
				if (num != 0)
				{
				}
				num = (short)1244403838;
				short num2 = num;
				num = (short)1113593982;
				switch (num2 == num)
				{
				default:
				{
					num = (short)826015744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)418381824;
				if (num != 0)
				{
				}
				return this.emerWideGeneralChannelDelaysec_A7657.Editable;
			}
			set
			{
				short num = (short)382622223;
				short num2 = num;
				num = (short)1542543887;
				switch (num2 == num)
				{
				}
				num = (short)2030567424;
				short num3 = num;
				num = (short)1542127617;
				if (num != 0)
				{
				}
				num = (short)211156992;
				if (num != 0)
				{
				}
				this.emerWideGeneralChannelDelaysec_A7657.Editable = value;
			}
		}

		// Token: 0x17004D03 RID: 19715
		// (get) Token: 0x06009971 RID: 39281 RVA: 0x008FE390 File Offset: 0x008FC590
		internal string EmerWideGeneralChannelDelaysec_A7657_UILabel
		{
			get
			{
				short num = (short)4943987;
				short num2 = num;
				num = (short)542601331;
				switch (num2 == num)
				{
				}
				num = (short)9764864;
				short num3 = num;
				num = (short)276037633;
				if (num != 0)
				{
				}
				num = (short)765657088;
				if (num != 0)
				{
				}
				return this.emerWideGeneralChannelDelaysec_A7657.UIName;
			}
		}

		// Token: 0x17004D04 RID: 19716
		// (get) Token: 0x06009972 RID: 39282 RVA: 0x008FE444 File Offset: 0x008FC644
		// (set) Token: 0x06009973 RID: 39283 RVA: 0x008FE4FC File Offset: 0x008FC6FC
		internal bool EmerWideGeneralChannelDelaysec_A7657_HiddenStatic
		{
			get
			{
				short num = (short)1945889826;
				short num2 = num;
				num = (short)102951970;
				switch (num2 == num)
				{
				}
				num = (short)1672544256;
				short num3 = num;
				num = (short)794886145;
				if (num != 0)
				{
				}
				num = (short)1705574400;
				if (num != 0)
				{
				}
				return this.emerWideGeneralChannelDelaysec_A7657.HiddenStatic;
			}
			set
			{
				short num = (short)729124524;
				short num2 = num;
				num = (short)1720946348;
				switch (num2 == num)
				{
				}
				num = (short)1981480960;
				short num3 = num;
				num = (short)1751646208;
				if (num != 0)
				{
				}
				num = (short)235995137;
				if (num != 0)
				{
				}
				this.emerWideGeneralChannelDelaysec_A7657.HiddenStatic = value;
			}
		}

		// Token: 0x17004D05 RID: 19717
		// (get) Token: 0x06009974 RID: 39284 RVA: 0x008FE5B0 File Offset: 0x008FC7B0
		// (set) Token: 0x06009975 RID: 39285 RVA: 0x008FE664 File Offset: 0x008FC864
		internal bool EmerWideGeneralChannelDelaysec_A7657_HiddenDynamic
		{
			get
			{
				short num = (short)477608725;
				short num2 = num;
				num = (short)205568789;
				switch (num2 == num)
				{
				}
				num = (short)561774592;
				short num3 = num;
				num = (short)685113345;
				if (num != 0)
				{
				}
				num = (short)923467776;
				if (num != 0)
				{
				}
				return this.emerWideGeneralChannelDelaysec_A7657.HiddenDynamic;
			}
			set
			{
				short num = (short)955295136;
				short num2 = num;
				num = (short)1176872352;
				switch (num2 == num)
				{
				}
				num = (short)1312161792;
				short num3 = num;
				num = (short)30146561;
				if (num != 0)
				{
				}
				num = (short)1270284288;
				if (num != 0)
				{
				}
				this.emerWideGeneralChannelDelaysec_A7657.HiddenDynamic = value;
			}
		}

		// Token: 0x17004D06 RID: 19718
		// (get) Token: 0x06009976 RID: 39286 RVA: 0x008FE718 File Offset: 0x008FC918
		public bool EmerWideGeneralChannelDelaysec_A7657_HasDiffs
		{
			get
			{
				short num = (short)1213679004;
				short num2 = num;
				num = (short)1368475036;
				switch (num2 == num)
				{
				}
				num = (short)768147456;
				short num3 = num;
				num = (short)1081999361;
				if (num != 0)
				{
				}
				num = (short)1637810176;
				if (num != 0)
				{
				}
				return this.emerWideGeneralChannelDelaysec_A7657._HasDiffs;
			}
		}

		// Token: 0x17004D07 RID: 19719
		// (get) Token: 0x06009977 RID: 39287 RVA: 0x008FE7CC File Offset: 0x008FC9CC
		// (set) Token: 0x06009978 RID: 39288 RVA: 0x008FE880 File Offset: 0x008FCA80
		public int EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933Value
		{
			get
			{
				short num = (short)1902692690;
				short num2 = num;
				num = (short)1068091730;
				switch (num2 == num)
				{
				}
				num = (short)1808138240;
				short num3 = num;
				num = (short)2010120193;
				if (num != 0)
				{
				}
				num = (short)665518080;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.Value;
			}
			set
			{
				short num = (short)534617061;
				short num2 = num;
				num = (short)1978178533;
				switch (num2 == num)
				{
				}
				num = (short)559677440;
				short num3 = num;
				num = (short)164102145;
				if (num != 0)
				{
				}
				num = (short)1341259776;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.Value = value;
			}
		}

		// Token: 0x17004D08 RID: 19720
		// (get) Token: 0x06009979 RID: 39289 RVA: 0x008FE934 File Offset: 0x008FCB34
		// (set) Token: 0x0600997A RID: 39290 RVA: 0x008FE9E8 File Offset: 0x008FCBE8
		public string EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933_UIValue
		{
			get
			{
				short num = (short)856624787;
				short num2 = num;
				num = (short)1511984787;
				switch (num2 == num)
				{
				}
				num = (short)1911881728;
				short num3 = num;
				num = (short)304611328;
				if (num != 0)
				{
				}
				num = (short)1848115201;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.UIValue;
			}
			set
			{
				short num = (short)455213057;
				if (num != 0)
				{
				}
				num = (short)1472939992;
				short num2 = num;
				num = (short)1220298712;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2004877312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1820721152;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.UIValue = value;
			}
		}

		// Token: 0x17004D09 RID: 19721
		// (get) Token: 0x0600997B RID: 39291 RVA: 0x008FEAA0 File Offset: 0x008FCCA0
		public global::AcpBusinessLayer.AcpListField EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933
		{
			get
			{
				short num = (short)2042914055;
				short num2 = num;
				num = (short)764044551;
				switch (num2 == num)
				{
				}
				num = (short)1552678912;
				short num3 = num;
				num = (short)208470017;
				if (num != 0)
				{
				}
				num = (short)1241710592;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933;
			}
		}

		// Token: 0x17004D0A RID: 19722
		// (get) Token: 0x0600997C RID: 39292 RVA: 0x008FEB4C File Offset: 0x008FCD4C
		// (set) Token: 0x0600997D RID: 39293 RVA: 0x008FEC00 File Offset: 0x008FCE00
		public bool EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933_Applicable
		{
			get
			{
				short num = (short)773024652;
				short num2 = num;
				num = (short)1217096588;
				switch (num2 == num)
				{
				}
				num = (short)707919872;
				short num3 = num;
				num = (short)373489664;
				if (num != 0)
				{
				}
				num = (short)1573388289;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.Applicable;
			}
			set
			{
				short num = (short)744586441;
				short num2 = num;
				num = (short)31423689;
				switch (num2 == num)
				{
				}
				num = (short)500760576;
				short num3 = num;
				num = (short)257753088;
				if (num != 0)
				{
				}
				num = (short)1100021761;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.Applicable = value;
			}
		}

		// Token: 0x17004D0B RID: 19723
		// (get) Token: 0x0600997E RID: 39294 RVA: 0x008FECB8 File Offset: 0x008FCEB8
		// (set) Token: 0x0600997F RID: 39295 RVA: 0x008FED6C File Offset: 0x008FCF6C
		public bool EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933_Valid
		{
			get
			{
				short num = (short)1658114066;
				short num2 = num;
				num = (short)2127024146;
				switch (num2 == num)
				{
				}
				num = (short)1468399616;
				short num3 = num;
				num = (short)1122500609;
				if (num != 0)
				{
				}
				num = (short)586022912;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.Valid;
			}
			set
			{
				short num = (short)1565013909;
				short num2 = num;
				num = (short)41236373;
				switch (num2 == num)
				{
				}
				num = (short)504627200;
				short num3 = num;
				num = (short)803536897;
				if (num != 0)
				{
				}
				num = (short)236978176;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.Valid = value;
			}
		}

		// Token: 0x17004D0C RID: 19724
		// (get) Token: 0x06009980 RID: 39296 RVA: 0x008FEE20 File Offset: 0x008FD020
		// (set) Token: 0x06009981 RID: 39297 RVA: 0x008FEED4 File Offset: 0x008FD0D4
		public bool EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933_Visible
		{
			get
			{
				short num = (short)162454189;
				short num2 = num;
				num = (short)706927277;
				switch (num2 == num)
				{
				}
				num = (short)329777152;
				short num3 = num;
				num = (short)48365568;
				if (num != 0)
				{
				}
				num = (short)1946157057;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.Visible;
			}
			set
			{
				short num = (short)651625710;
				short num2 = num;
				num = (short)834602222;
				switch (num2 == num)
				{
				}
				num = (short)1043464192;
				short num3 = num;
				num = (short)381288449;
				if (num != 0)
				{
				}
				num = (short)490733568;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.Visible = value;
			}
		}

		// Token: 0x17004D0D RID: 19725
		// (get) Token: 0x06009982 RID: 39298 RVA: 0x008FEF88 File Offset: 0x008FD188
		// (set) Token: 0x06009983 RID: 39299 RVA: 0x008FF03C File Offset: 0x008FD23C
		public bool EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933_Editable
		{
			get
			{
				short num = (short)1500957327;
				short num2 = num;
				num = (short)613927567;
				switch (num2 == num)
				{
				}
				num = (short)1751187456;
				short num3 = num;
				num = (short)238747648;
				if (num != 0)
				{
				}
				num = (short)1272709121;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.Editable;
			}
			set
			{
				short num = (short)916652033;
				if (num != 0)
				{
				}
				num = (short)463779466;
				short num2 = num;
				num = (short)1840690826;
				switch (num2 == num)
				{
				default:
				{
					num = (short)568983552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1974403072;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.Editable = value;
			}
		}

		// Token: 0x17004D0E RID: 19726
		// (get) Token: 0x06009984 RID: 39300 RVA: 0x008FF0F0 File Offset: 0x008FD2F0
		internal string EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933_UILabel
		{
			get
			{
				short num = (short)1540697131;
				short num2 = num;
				num = (short)574434347;
				switch (num2 == num)
				{
				}
				num = (short)1216151552;
				short num3 = num;
				num = (short)1943142401;
				if (num != 0)
				{
				}
				num = (short)544473088;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.UIName;
			}
		}

		// Token: 0x17004D0F RID: 19727
		// (get) Token: 0x06009985 RID: 39301 RVA: 0x008FF1A8 File Offset: 0x008FD3A8
		// (set) Token: 0x06009986 RID: 39302 RVA: 0x008FF260 File Offset: 0x008FD460
		internal bool EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933_HiddenStatic
		{
			get
			{
				short num = (short)1974440266;
				short num2 = num;
				num = (short)657953098;
				switch (num2 == num)
				{
				}
				num = (short)88866816;
				short num3 = num;
				num = (short)1975975936;
				if (num != 0)
				{
				}
				num = (short)155582465;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.HiddenStatic;
			}
			set
			{
				short num = (short)1291255808;
				short num2 = num;
				num = (short)998652354;
				short num3 = num;
				num = (short)1266825666;
				switch (num3 == num)
				{
				}
				num = (short)1282670593;
				if (num != 0)
				{
				}
				num = (short)687996928;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.HiddenStatic = value;
			}
		}

		// Token: 0x17004D10 RID: 19728
		// (get) Token: 0x06009987 RID: 39303 RVA: 0x008FF318 File Offset: 0x008FD518
		// (set) Token: 0x06009988 RID: 39304 RVA: 0x008FF3D0 File Offset: 0x008FD5D0
		internal bool EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933_HiddenDynamic
		{
			get
			{
				short num = (short)2107506688;
				short num2 = num;
				num = (short)634242956;
				short num3 = num;
				num = (short)2107099020;
				switch (num3 == num)
				{
				}
				num = (short)1157693441;
				if (num != 0)
				{
				}
				num = (short)1654718464;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.HiddenDynamic;
			}
			set
			{
				short num = (short)562298880;
				short num2 = num;
				num = (short)1795050122;
				short num3 = num;
				num = (short)2022787722;
				switch (num3 == num)
				{
				}
				num = (short)1943928833;
				if (num != 0)
				{
				}
				num = (short)286392320;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933.HiddenDynamic = value;
			}
		}

		// Token: 0x17004D11 RID: 19729
		// (get) Token: 0x06009989 RID: 39305 RVA: 0x008FF488 File Offset: 0x008FD688
		public bool EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933_HasDiffs
		{
			get
			{
				short num = (short)647954432;
				short num2 = num;
				num = (short)970915317;
				short num3 = num;
				num = (short)1920138741;
				switch (num3 == num)
				{
				}
				num = (short)870187008;
				if (num != 0)
				{
				}
				num = (short)1666908161;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyAlarmRxIndicatorType_A7933._HasDiffs;
			}
		}

		// Token: 0x17004D12 RID: 19730
		// (get) Token: 0x0600998A RID: 39306 RVA: 0x008FF53C File Offset: 0x008FD73C
		// (set) Token: 0x0600998B RID: 39307 RVA: 0x008FF5F4 File Offset: 0x008FD7F4
		public bool EmerWideGeneralEmergencyCallReceive_A7937Value
		{
			get
			{
				short num = (short)334692352;
				short num2 = num;
				num = (short)1356697845;
				short num3 = num;
				num = (short)722964725;
				switch (num3 == num)
				{
				}
				num = (short)552730624;
				if (num != 0)
				{
				}
				num = (short)569311233;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyCallReceive_A7937.Value;
			}
			set
			{
				short num = (short)851181568;
				short num2 = num;
				num = (short)1430192129;
				if (num != 0)
				{
				}
				num = (short)1991906704;
				short num3 = num;
				num = (short)1905595792;
				switch (num3 == num)
				{
				}
				num = (short)2133458944;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyCallReceive_A7937.Value = value;
			}
		}

		// Token: 0x17004D13 RID: 19731
		// (get) Token: 0x0600998C RID: 39308 RVA: 0x008FF6AC File Offset: 0x008FD8AC
		public global::AcpBusinessLayer.AcpField<bool> EmerWideGeneralEmergencyCallReceive_A7937
		{
			get
			{
				short num = (short)2075852800;
				short num2 = num;
				num = (short)1949676195;
				short num3 = num;
				num = (short)428520099;
				switch (num3 == num)
				{
				}
				num = (short)95027200;
				if (num != 0)
				{
				}
				num = (short)2094530561;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyCallReceive_A7937;
			}
		}

		// Token: 0x17004D14 RID: 19732
		// (get) Token: 0x0600998D RID: 39309 RVA: 0x008FF75C File Offset: 0x008FD95C
		// (set) Token: 0x0600998E RID: 39310 RVA: 0x008FF810 File Offset: 0x008FDA10
		public bool EmerWideGeneralEmergencyCallReceive_A7937_UIValue
		{
			get
			{
				short num = (short)102694912;
				short num2 = num;
				num = (short)935671620;
				short num3 = num;
				num = (short)45102916;
				switch (num3 == num)
				{
				}
				num = (short)1549729793;
				if (num != 0)
				{
				}
				num = (short)1526988800;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyCallReceive_A7937.Value;
			}
			set
			{
				short num = (short)1756692480;
				short num2 = num;
				num = (short)894845834;
				short num3 = num;
				num = (short)1054229386;
				switch (num3 == num)
				{
				}
				num = (short)79757312;
				if (num != 0)
				{
				}
				num = (short)809435137;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyCallReceive_A7937.Value = value;
			}
		}

		// Token: 0x17004D15 RID: 19733
		// (get) Token: 0x0600998F RID: 39311 RVA: 0x008FF8C4 File Offset: 0x008FDAC4
		// (set) Token: 0x06009990 RID: 39312 RVA: 0x008FF978 File Offset: 0x008FDB78
		public bool EmerWideGeneralEmergencyCallReceive_A7937_Applicable
		{
			get
			{
				short num = (short)420544512;
				short num2 = num;
				num = (short)914219522;
				short num3 = num;
				num = (short)1104732674;
				switch (num3 == num)
				{
				}
				num = (short)649003009;
				if (num != 0)
				{
				}
				num = (short)1847853056;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyCallReceive_A7937.Applicable;
			}
			set
			{
				short num = (short)1136721920;
				short num2 = num;
				num = (short)628847940;
				short num3 = num;
				num = (short)1414952260;
				switch (num3 == num)
				{
				}
				num = (short)833486849;
				if (num != 0)
				{
				}
				num = (short)1686372352;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyCallReceive_A7937.Applicable = value;
			}
		}

		// Token: 0x17004D16 RID: 19734
		// (get) Token: 0x06009991 RID: 39313 RVA: 0x008FFA2C File Offset: 0x008FDC2C
		// (set) Token: 0x06009992 RID: 39314 RVA: 0x008FFAE0 File Offset: 0x008FDCE0
		public bool EmerWideGeneralEmergencyCallReceive_A7937_Valid
		{
			get
			{
				short num = (short)1596588032;
				short num2 = num;
				num = (short)1263202583;
				short num3 = num;
				num = (short)853864727;
				switch (num3 == num)
				{
				}
				num = (short)1371340800;
				if (num != 0)
				{
				}
				num = (short)1489829889;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyCallReceive_A7937.Valid;
			}
			set
			{
				short num = (short)1778581504;
				short num2 = num;
				num = (short)663158785;
				if (num != 0)
				{
				}
				num = (short)1411901061;
				short num3 = num;
				num = (short)667870853;
				switch (num3 == num)
				{
				}
				num = (short)1827733504;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyCallReceive_A7937.Valid = value;
			}
		}

		// Token: 0x17004D17 RID: 19735
		// (get) Token: 0x06009993 RID: 39315 RVA: 0x008FFB94 File Offset: 0x008FDD94
		// (set) Token: 0x06009994 RID: 39316 RVA: 0x008FFC48 File Offset: 0x008FDE48
		public bool EmerWideGeneralEmergencyCallReceive_A7937_Visible
		{
			get
			{
				short num = (short)1144389632;
				short num2 = num;
				num = (short)1299012213;
				short num3 = num;
				num = (short)205085301;
				switch (num3 == num)
				{
				}
				num = (short)824705024;
				if (num != 0)
				{
				}
				num = (short)370278401;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyCallReceive_A7937.Visible;
			}
			set
			{
				short num = (short)1600323584;
				short num2 = num;
				num = (short)79889305;
				short num3 = num;
				num = (short)1374421913;
				switch (num3 == num)
				{
				}
				num = (short)219742208;
				if (num != 0)
				{
				}
				num = (short)1638006785;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyCallReceive_A7937.Visible = value;
			}
		}

		// Token: 0x17004D18 RID: 19736
		// (get) Token: 0x06009995 RID: 39317 RVA: 0x008FFCFC File Offset: 0x008FDEFC
		// (set) Token: 0x06009996 RID: 39318 RVA: 0x008FFDB0 File Offset: 0x008FDFB0
		public bool EmerWideGeneralEmergencyCallReceive_A7937_Editable
		{
			get
			{
				short num = (short)1205272576;
				short num2 = num;
				num = (short)1716977665;
				if (num != 0)
				{
				}
				num = (short)1695063755;
				short num3 = num;
				num = (short)1427480267;
				switch (num3 == num)
				{
				}
				num = (short)760938496;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyCallReceive_A7937.Editable;
			}
			set
			{
				short num = (short)2094137344;
				short num2 = num;
				num = (short)572626284;
				short num3 = num;
				num = (short)1802933612;
				switch (num3 == num)
				{
				}
				num = (short)340197376;
				if (num != 0)
				{
				}
				num = (short)2034630657;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyCallReceive_A7937.Editable = value;
			}
		}

		// Token: 0x17004D19 RID: 19737
		// (get) Token: 0x06009997 RID: 39319 RVA: 0x008FFE68 File Offset: 0x008FE068
		internal string EmerWideGeneralEmergencyCallReceive_A7937_UILabel
		{
			get
			{
				short num = (short)1001783296;
				short num2 = num;
				num = (short)163900799;
				short num3 = num;
				num = (short)1054928255;
				switch (num3 == num)
				{
				}
				num = (short)371785729;
				if (num != 0)
				{
				}
				num = (short)515047424;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyCallReceive_A7937.UIName;
			}
		}

		// Token: 0x17004D1A RID: 19738
		// (get) Token: 0x06009998 RID: 39320 RVA: 0x008FFF1C File Offset: 0x008FE11C
		// (set) Token: 0x06009999 RID: 39321 RVA: 0x008FFFD0 File Offset: 0x008FE1D0
		internal bool EmerWideGeneralEmergencyCallReceive_A7937_HiddenStatic
		{
			get
			{
				short num = (short)1841954816;
				short num2 = num;
				num = (short)1184563201;
				if (num != 0)
				{
				}
				num = (short)2041231398;
				short num3 = num;
				num = (short)2052044838;
				switch (num3 == num)
				{
				}
				num = (short)2053439488;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyCallReceive_A7937.HiddenStatic;
			}
			set
			{
				short num = (short)2126970880;
				short num2 = num;
				num = (short)310917136;
				short num3 = num;
				num = (short)963393552;
				switch (num3 == num)
				{
				}
				num = (short)1356922881;
				if (num != 0)
				{
				}
				num = (short)689897472;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyCallReceive_A7937.HiddenStatic = value;
			}
		}

		// Token: 0x17004D1B RID: 19739
		// (get) Token: 0x0600999A RID: 39322 RVA: 0x00900084 File Offset: 0x008FE284
		// (set) Token: 0x0600999B RID: 39323 RVA: 0x00900138 File Offset: 0x008FE338
		internal bool EmerWideGeneralEmergencyCallReceive_A7937_HiddenDynamic
		{
			get
			{
				short num = (short)1059520512;
				short num2 = num;
				num = (short)512884737;
				if (num != 0)
				{
				}
				num = (short)968802746;
				short num3 = num;
				num = (short)1394000314;
				switch (num3 == num)
				{
				}
				num = (short)1681719296;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyCallReceive_A7937.HiddenDynamic;
			}
			set
			{
				short num = (short)219152384;
				short num2 = num;
				num = (short)3465073;
				short num3 = num;
				num = (short)1335615345;
				switch (num3 == num)
				{
				}
				num = (short)1249771520;
				if (num != 0)
				{
				}
				num = (short)1163395073;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyCallReceive_A7937.HiddenDynamic = value;
			}
		}

		// Token: 0x17004D1C RID: 19740
		// (get) Token: 0x0600999C RID: 39324 RVA: 0x009001EC File Offset: 0x008FE3EC
		public bool EmerWideGeneralEmergencyCallReceive_A7937_HasDiffs
		{
			get
			{
				short num = (short)1495924736;
				short num2 = num;
				num = (short)339478169;
				short num3 = num;
				num = (short)269026969;
				switch (num3 == num)
				{
				}
				num = (short)1300168704;
				if (num != 0)
				{
				}
				num = (short)2090467329;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyCallReceive_A7937._HasDiffs;
			}
		}

		// Token: 0x17004D1D RID: 19741
		// (get) Token: 0x0600999D RID: 39325 RVA: 0x009002A0 File Offset: 0x008FE4A0
		// (set) Token: 0x0600999E RID: 39326 RVA: 0x00900354 File Offset: 0x008FE554
		public bool EmerWideGeneralEmergencyPowerUp_A7942Value
		{
			get
			{
				short num = (short)599457792;
				short num2 = num;
				num = (short)440550188;
				short num3 = num;
				num = (short)330646316;
				switch (num3 == num)
				{
				}
				num = (short)70647809;
				if (num != 0)
				{
				}
				num = (short)885325824;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyPowerUp_A7942.Value;
			}
			set
			{
				short num = (short)936050688;
				short num2 = num;
				num = (short)1794179073;
				if (num != 0)
				{
				}
				num = (short)1948343294;
				short num3 = num;
				num = (short)1251433470;
				switch (num3 == num)
				{
				}
				num = (short)1557135360;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyPowerUp_A7942.Value = value;
			}
		}

		// Token: 0x17004D1E RID: 19742
		// (get) Token: 0x0600999F RID: 39327 RVA: 0x0090040C File Offset: 0x008FE60C
		public global::AcpBusinessLayer.AcpField<bool> EmerWideGeneralEmergencyPowerUp_A7942
		{
			get
			{
				short num = (short)1929379840;
				short num2 = num;
				num = (short)1051262977;
				if (num != 0)
				{
				}
				num = (short)1919047758;
				short num3 = num;
				num = (short)425941070;
				switch (num3 == num)
				{
				}
				num = (short)1569325056;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyPowerUp_A7942;
			}
		}

		// Token: 0x17004D1F RID: 19743
		// (get) Token: 0x060099A0 RID: 39328 RVA: 0x009004BC File Offset: 0x008FE6BC
		// (set) Token: 0x060099A1 RID: 39329 RVA: 0x00900570 File Offset: 0x008FE770
		public bool EmerWideGeneralEmergencyPowerUp_A7942_UIValue
		{
			get
			{
				short num = (short)17432576;
				short num2 = num;
				num = (short)2030911615;
				short num3 = num;
				num = (short)298729599;
				switch (num3 == num)
				{
				}
				num = (short)17760257;
				if (num != 0)
				{
				}
				num = (short)172359680;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyPowerUp_A7942.Value;
			}
			set
			{
				short num = (short)284229632;
				short num2 = num;
				num = (short)1834342724;
				short num3 = num;
				num = (short)1790695748;
				switch (num3 == num)
				{
				}
				num = (short)673579009;
				if (num != 0)
				{
				}
				num = (short)62390272;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyPowerUp_A7942.Value = value;
			}
		}

		// Token: 0x17004D20 RID: 19744
		// (get) Token: 0x060099A2 RID: 39330 RVA: 0x0090062C File Offset: 0x008FE82C
		// (set) Token: 0x060099A3 RID: 39331 RVA: 0x009006E0 File Offset: 0x008FE8E0
		public bool EmerWideGeneralEmergencyPowerUp_A7942_Applicable
		{
			get
			{
				short num = (short)1219690496;
				short num2 = num;
				num = (short)355373802;
				short num3 = num;
				num = (short)1497338602;
				switch (num3 == num)
				{
				}
				num = (short)1353973761;
				if (num != 0)
				{
				}
				num = (short)831062016;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyPowerUp_A7942.Applicable;
			}
			set
			{
				short num = (short)838926336;
				short num2 = num;
				num = (short)124144412;
				short num3 = num;
				num = (short)1824803612;
				switch (num3 == num)
				{
				}
				num = (short)1743847425;
				if (num != 0)
				{
				}
				num = (short)840499200;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyPowerUp_A7942.Applicable = value;
			}
		}

		// Token: 0x17004D21 RID: 19745
		// (get) Token: 0x060099A4 RID: 39332 RVA: 0x00900794 File Offset: 0x008FE994
		// (set) Token: 0x060099A5 RID: 39333 RVA: 0x00900848 File Offset: 0x008FEA48
		public bool EmerWideGeneralEmergencyPowerUp_A7942_Valid
		{
			get
			{
				short num = (short)486014976;
				short num2 = num;
				num = (short)452339320;
				short num3 = num;
				num = (short)1625302648;
				switch (num3 == num)
				{
				}
				num = (short)2051080192;
				if (num != 0)
				{
				}
				num = (short)399835137;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyPowerUp_A7942.Valid;
			}
			set
			{
				short num = (short)929693696;
				short num2 = num;
				num = (short)1075596006;
				short num3 = num;
				num = (short)2052082406;
				switch (num3 == num)
				{
				}
				num = (short)42467329;
				if (num != 0)
				{
				}
				num = (short)1297154048;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyPowerUp_A7942.Valid = value;
			}
		}

		// Token: 0x17004D22 RID: 19746
		// (get) Token: 0x060099A6 RID: 39334 RVA: 0x009008FC File Offset: 0x008FEAFC
		// (set) Token: 0x060099A7 RID: 39335 RVA: 0x009009B0 File Offset: 0x008FEBB0
		public bool EmerWideGeneralEmergencyPowerUp_A7942_Visible
		{
			get
			{
				short num = (short)401408000;
				short num2 = num;
				num = (short)2023156819;
				short num3 = num;
				num = (short)2085678163;
				switch (num3 == num)
				{
				}
				num = (short)2077556736;
				if (num != 0)
				{
				}
				num = (short)560267265;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyPowerUp_A7942.Visible;
			}
			set
			{
				short num = (short)245366784;
				short num2 = num;
				num = (short)523028676;
				short num3 = num;
				num = (short)2144913604;
				switch (num3 == num)
				{
				}
				num = (short)1378942977;
				if (num != 0)
				{
				}
				num = (short)1122172928;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyPowerUp_A7942.Visible = value;
			}
		}

		// Token: 0x17004D23 RID: 19747
		// (get) Token: 0x060099A8 RID: 39336 RVA: 0x00900A68 File Offset: 0x008FEC68
		// (set) Token: 0x060099A9 RID: 39337 RVA: 0x00900B1C File Offset: 0x008FED1C
		public bool EmerWideGeneralEmergencyPowerUp_A7942_Editable
		{
			get
			{
				short num = (short)1677656064;
				short num2 = num;
				num = (short)1072641713;
				short num3 = num;
				num = (short)52311729;
				switch (num3 == num)
				{
				}
				num = (short)1423769600;
				if (num != 0)
				{
				}
				num = (short)1660682241;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyPowerUp_A7942.Editable;
			}
			set
			{
				short num = (short)675610624;
				short num2 = num;
				num = (short)700458134;
				short num3 = num;
				num = (short)1180443798;
				switch (num3 == num)
				{
				}
				num = (short)1017511936;
				if (num != 0)
				{
				}
				num = (short)94896129;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyPowerUp_A7942.Editable = value;
			}
		}

		// Token: 0x17004D24 RID: 19748
		// (get) Token: 0x060099AA RID: 39338 RVA: 0x00900BD0 File Offset: 0x008FEDD0
		internal string EmerWideGeneralEmergencyPowerUp_A7942_UILabel
		{
			get
			{
				short num = (short)1135411200;
				short num2 = num;
				num = (short)762201122;
				short num3 = num;
				num = (short)1153123362;
				switch (num3 == num)
				{
				}
				num = (short)819462145;
				if (num != 0)
				{
				}
				num = (short)36241408;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyPowerUp_A7942.UIName;
			}
		}

		// Token: 0x17004D25 RID: 19749
		// (get) Token: 0x060099AB RID: 39339 RVA: 0x00900C84 File Offset: 0x008FEE84
		// (set) Token: 0x060099AC RID: 39340 RVA: 0x00900D38 File Offset: 0x008FEF38
		internal bool EmerWideGeneralEmergencyPowerUp_A7942_HiddenStatic
		{
			get
			{
				short num = (short)899022848;
				short num2 = num;
				num = (short)999013663;
				short num3 = num;
				num = (short)1840430367;
				switch (num3 == num)
				{
				}
				num = (short)2124611585;
				if (num != 0)
				{
				}
				num = (short)490733568;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyPowerUp_A7942.HiddenStatic;
			}
			set
			{
				short num = (short)535625728;
				short num2 = num;
				num = (short)1408046250;
				short num3 = num;
				num = (short)585700522;
				switch (num3 == num)
				{
				}
				num = (short)2139291649;
				if (num != 0)
				{
				}
				num = (short)381943808;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyPowerUp_A7942.HiddenStatic = value;
			}
		}

		// Token: 0x17004D26 RID: 19750
		// (get) Token: 0x060099AD RID: 39341 RVA: 0x00900DEC File Offset: 0x008FEFEC
		// (set) Token: 0x060099AE RID: 39342 RVA: 0x00900EA0 File Offset: 0x008FF0A0
		internal bool EmerWideGeneralEmergencyPowerUp_A7942_HiddenDynamic
		{
			get
			{
				short num = (short)410648576;
				short num2 = num;
				num = (short)543567884;
				short num3 = num;
				num = (short)2011836428;
				switch (num3 == num)
				{
				}
				num = (short)773324801;
				if (num != 0)
				{
				}
				num = (short)443351040;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyPowerUp_A7942.HiddenDynamic;
			}
			set
			{
				short num = (short)541261824;
				short num2 = num;
				num = (short)1678579374;
				short num3 = num;
				num = (short)524752558;
				switch (num3 == num)
				{
				}
				num = (short)2145583105;
				if (num != 0)
				{
				}
				num = (short)1836318720;
				if (num != 0)
				{
				}
				this.emerWideGeneralEmergencyPowerUp_A7942.HiddenDynamic = value;
			}
		}

		// Token: 0x17004D27 RID: 19751
		// (get) Token: 0x060099AF RID: 39343 RVA: 0x00900F58 File Offset: 0x008FF158
		public bool EmerWideGeneralEmergencyPowerUp_A7942_HasDiffs
		{
			get
			{
				short num = (short)1646723072;
				short num2 = num;
				num = (short)662503425;
				if (num != 0)
				{
				}
				num = (short)1661297825;
				short num3 = num;
				num = (short)650536097;
				switch (num3 == num)
				{
				}
				num = (short)1312948224;
				if (num != 0)
				{
				}
				return this.emerWideGeneralEmergencyPowerUp_A7942._HasDiffs;
			}
		}

		// Token: 0x17004D28 RID: 19752
		// (get) Token: 0x060099B0 RID: 39344 RVA: 0x00901010 File Offset: 0x008FF210
		// (set) Token: 0x060099B1 RID: 39345 RVA: 0x009010C0 File Offset: 0x008FF2C0
		public bool EmerWideGeneralKeepAlive_A8360Value
		{
			get
			{
				short num = (short)1197735936;
				short num2 = num;
				num = (short)141426689;
				if (num != 0)
				{
				}
				num = (short)1414646537;
				short num3 = num;
				num = (short)1109773065;
				switch (num3 == num)
				{
				}
				num = (short)1585119232;
				if (num != 0)
				{
				}
				return this.emerWideGeneralKeepAlive_A8360.Value;
			}
			set
			{
				short num = (short)611385344;
				short num2 = num;
				num = (short)1811703253;
				short num3 = num;
				num = (short)1175479765;
				switch (num3 == num)
				{
				}
				num = (short)989986816;
				if (num != 0)
				{
				}
				num = (short)801570817;
				if (num != 0)
				{
				}
				this.emerWideGeneralKeepAlive_A8360.Value = value;
			}
		}

		// Token: 0x17004D29 RID: 19753
		// (get) Token: 0x060099B2 RID: 39346 RVA: 0x00901178 File Offset: 0x008FF378
		public global::AcpBusinessLayer.AcpField<bool> EmerWideGeneralKeepAlive_A8360
		{
			get
			{
				short num = (short)1994129408;
				short num2 = num;
				num = (short)129953731;
				short num3 = num;
				num = (short)1457582019;
				switch (num3 == num)
				{
				}
				num = (short)1241120769;
				if (num != 0)
				{
				}
				num = (short)1734410240;
				if (num != 0)
				{
				}
				return this.emerWideGeneralKeepAlive_A8360;
			}
		}

		// Token: 0x17004D2A RID: 19754
		// (get) Token: 0x060099B3 RID: 39347 RVA: 0x00901224 File Offset: 0x008FF424
		// (set) Token: 0x060099B4 RID: 39348 RVA: 0x009012D4 File Offset: 0x008FF4D4
		public bool EmerWideGeneralKeepAlive_A8360_UIValue
		{
			get
			{
				short num = (short)1890123776;
				short num2 = num;
				num = (short)1908277249;
				if (num != 0)
				{
				}
				num = (short)120879732;
				short num3 = num;
				num = (short)970422900;
				switch (num3 == num)
				{
				}
				num = (short)275513344;
				if (num != 0)
				{
				}
				return this.emerWideGeneralKeepAlive_A8360.Value;
			}
			set
			{
				short num = (short)2122579968;
				short num2 = num;
				num = (short)1720030787;
				short num3 = num;
				num = (short)1646433859;
				switch (num3 == num)
				{
				}
				num = (short)97320960;
				if (num != 0)
				{
				}
				num = (short)497090561;
				if (num != 0)
				{
				}
				this.emerWideGeneralKeepAlive_A8360.Value = value;
			}
		}

		// Token: 0x17004D2B RID: 19755
		// (get) Token: 0x060099B5 RID: 39349 RVA: 0x00901388 File Offset: 0x008FF588
		// (set) Token: 0x060099B6 RID: 39350 RVA: 0x0090143C File Offset: 0x008FF63C
		public bool EmerWideGeneralKeepAlive_A8360_Applicable
		{
			get
			{
				short num = (short)654704640;
				short num2 = num;
				num = (short)1265464733;
				short num3 = num;
				num = (short)74610077;
				switch (num3 == num)
				{
				}
				num = (short)770703361;
				if (num != 0)
				{
				}
				num = (short)181010432;
				if (num != 0)
				{
				}
				return this.emerWideGeneralKeepAlive_A8360.Applicable;
			}
			set
			{
				short num = (short)1259732992;
				short num2 = num;
				num = (short)1811559420;
				short num3 = num;
				num = (short)496972796;
				switch (num3 == num)
				{
				}
				num = (short)2058944513;
				if (num != 0)
				{
				}
				num = (short)422379520;
				if (num != 0)
				{
				}
				this.emerWideGeneralKeepAlive_A8360.Applicable = value;
			}
		}

		// Token: 0x17004D2C RID: 19756
		// (get) Token: 0x060099B7 RID: 39351 RVA: 0x009014F4 File Offset: 0x008FF6F4
		// (set) Token: 0x060099B8 RID: 39352 RVA: 0x009015A8 File Offset: 0x008FF7A8
		public bool EmerWideGeneralKeepAlive_A8360_Valid
		{
			get
			{
				short num = (short)1969356800;
				short num2 = num;
				num = (short)147012577;
				short num3 = num;
				num = (short)1985690593;
				switch (num3 == num)
				{
				}
				num = (short)1199702017;
				if (num != 0)
				{
				}
				num = (short)2130837504;
				if (num != 0)
				{
				}
				return this.emerWideGeneralKeepAlive_A8360.Valid;
			}
			set
			{
				short num = (short)1151729664;
				short num2 = num;
				num = (short)792424322;
				short num3 = num;
				num = (short)710176642;
				switch (num3 == num)
				{
				}
				num = (short)2103181312;
				if (num != 0)
				{
				}
				num = (short)1265631233;
				if (num != 0)
				{
				}
				this.emerWideGeneralKeepAlive_A8360.Valid = value;
			}
		}

		// Token: 0x17004D2D RID: 19757
		// (get) Token: 0x060099B9 RID: 39353 RVA: 0x00901660 File Offset: 0x008FF860
		// (set) Token: 0x060099BA RID: 39354 RVA: 0x00901718 File Offset: 0x008FF918
		public bool EmerWideGeneralKeepAlive_A8360_Visible
		{
			get
			{
				short num = (short)1851785216;
				short num2 = num;
				num = (short)1975835920;
				short num3 = num;
				num = (short)2082987280;
				switch (num3 == num)
				{
				}
				num = (short)179830785;
				if (num != 0)
				{
				}
				num = (short)532742144;
				if (num != 0)
				{
				}
				return this.emerWideGeneralKeepAlive_A8360.Visible;
			}
			set
			{
				short num = (short)1072431104;
				short num2 = num;
				num = (short)20971521;
				if (num != 0)
				{
				}
				num = (short)1900019300;
				short num3 = num;
				num = (short)930414180;
				switch (num3 == num)
				{
				}
				num = (short)1963393024;
				if (num != 0)
				{
				}
				this.emerWideGeneralKeepAlive_A8360.Visible = value;
			}
		}

		// Token: 0x17004D2E RID: 19758
		// (get) Token: 0x060099BB RID: 39355 RVA: 0x009017D0 File Offset: 0x008FF9D0
		// (set) Token: 0x060099BC RID: 39356 RVA: 0x00901884 File Offset: 0x008FFA84
		public bool EmerWideGeneralKeepAlive_A8360_Editable
		{
			get
			{
				short num = (short)823328768;
				short num2 = num;
				num = (short)1740567579;
				short num3 = num;
				num = (short)404550683;
				switch (num3 == num)
				{
				}
				num = (short)165019648;
				if (num != 0)
				{
				}
				num = (short)1958805505;
				if (num != 0)
				{
				}
				return this.emerWideGeneralKeepAlive_A8360.Editable;
			}
			set
			{
				short num = (short)226623488;
				short num2 = num;
				num = (short)588107663;
				short num3 = num;
				num = (short)17223567;
				switch (num3 == num)
				{
				}
				num = (short)1500381184;
				if (num != 0)
				{
				}
				num = (short)2136145921;
				if (num != 0)
				{
				}
				this.emerWideGeneralKeepAlive_A8360.Editable = value;
			}
		}

		// Token: 0x17004D2F RID: 19759
		// (get) Token: 0x060099BD RID: 39357 RVA: 0x00901938 File Offset: 0x008FFB38
		internal string EmerWideGeneralKeepAlive_A8360_UILabel
		{
			get
			{
				short num = (short)1042481152;
				short num2 = num;
				num = (short)1594776145;
				short num3 = num;
				num = (short)1544837713;
				switch (num3 == num)
				{
				}
				num = (short)956825600;
				if (num != 0)
				{
				}
				num = (short)661323777;
				if (num != 0)
				{
				}
				return this.emerWideGeneralKeepAlive_A8360.UIName;
			}
		}

		// Token: 0x17004D30 RID: 19760
		// (get) Token: 0x060099BE RID: 39358 RVA: 0x009019F0 File Offset: 0x008FFBF0
		// (set) Token: 0x060099BF RID: 39359 RVA: 0x00901AA4 File Offset: 0x008FFCA4
		internal bool EmerWideGeneralKeepAlive_A8360_HiddenStatic
		{
			get
			{
				short num = (short)1673314546;
				short num2 = num;
				num = (short)443793650;
				switch (num2 == num)
				{
				}
				num = (short)1635909632;
				if (num != 0)
				{
				}
				num = (short)1065811969;
				if (num != 0)
				{
				}
				num = (short)1536229376;
				short num3 = num;
				return this.emerWideGeneralKeepAlive_A8360.HiddenStatic;
			}
			set
			{
				short num = (short)1291978590;
				short num2 = num;
				num = (short)1203832670;
				switch (num2 == num)
				{
				}
				num = (short)57606144;
				if (num != 0)
				{
				}
				num = (short)154206209;
				if (num != 0)
				{
				}
				num = (short)2133131264;
				short num3 = num;
				this.emerWideGeneralKeepAlive_A8360.HiddenStatic = value;
			}
		}

		// Token: 0x17004D31 RID: 19761
		// (get) Token: 0x060099C0 RID: 39360 RVA: 0x00901B58 File Offset: 0x008FFD58
		// (set) Token: 0x060099C1 RID: 39361 RVA: 0x00901C0C File Offset: 0x008FFE0C
		internal bool EmerWideGeneralKeepAlive_A8360_HiddenDynamic
		{
			get
			{
				short num = (short)1068999159;
				short num2 = num;
				num = (short)571253239;
				switch (num2 == num)
				{
				}
				num = (short)1920991232;
				if (num != 0)
				{
				}
				num = (short)696385537;
				if (num != 0)
				{
				}
				num = (short)1635909632;
				short num3 = num;
				return this.emerWideGeneralKeepAlive_A8360.HiddenDynamic;
			}
			set
			{
				short num = (short)686962855;
				short num2 = num;
				num = (short)1253587111;
				switch (num2 == num)
				{
				}
				num = (short)1047003136;
				if (num != 0)
				{
				}
				num = (short)38469633;
				if (num != 0)
				{
				}
				num = (short)520028160;
				short num3 = num;
				this.emerWideGeneralKeepAlive_A8360.HiddenDynamic = value;
			}
		}

		// Token: 0x17004D32 RID: 19762
		// (get) Token: 0x060099C2 RID: 39362 RVA: 0x00901CC4 File Offset: 0x008FFEC4
		public bool EmerWideGeneralKeepAlive_A8360_HasDiffs
		{
			get
			{
				short num = (short)145478928;
				short num2 = num;
				num = (short)617600272;
				switch (num2 == num)
				{
				}
				num = (short)838074369;
				if (num != 0)
				{
				}
				num = (short)1741422592;
				if (num != 0)
				{
				}
				num = (short)1005912064;
				short num3 = num;
				return this.emerWideGeneralKeepAlive_A8360._HasDiffs;
			}
		}

		// Token: 0x17004D33 RID: 19763
		// (get) Token: 0x060099C3 RID: 39363 RVA: 0x00901D80 File Offset: 0x008FFF80
		// (set) Token: 0x060099C4 RID: 39364 RVA: 0x00901E34 File Offset: 0x00900034
		public bool EmerWideGeneralSilentAlarm_A9130Value
		{
			get
			{
				short num = (short)562092383;
				short num2 = num;
				num = (short)1928452447;
				switch (num2 == num)
				{
				}
				num = (short)2101149697;
				if (num != 0)
				{
				}
				num = (short)242221056;
				if (num != 0)
				{
				}
				num = (short)962527232;
				short num3 = num;
				return this.emerWideGeneralSilentAlarm_A9130.Value;
			}
			set
			{
				short num = (short)165848154;
				short num2 = num;
				num = (short)1390978138;
				switch (num2 == num)
				{
				}
				num = (short)354091008;
				if (num != 0)
				{
				}
				num = (short)1975451649;
				if (num != 0)
				{
				}
				num = (short)958464000;
				short num3 = num;
				this.emerWideGeneralSilentAlarm_A9130.Value = value;
			}
		}

		// Token: 0x17004D34 RID: 19764
		// (get) Token: 0x060099C5 RID: 39365 RVA: 0x00901EEC File Offset: 0x009000EC
		public global::AcpBusinessLayer.AcpField<bool> EmerWideGeneralSilentAlarm_A9130
		{
			get
			{
				short num = (short)1213266030;
				short num2 = num;
				num = (short)1616443502;
				switch (num2 == num)
				{
				}
				num = (short)1097269249;
				if (num != 0)
				{
				}
				num = (short)1839005696;
				if (num != 0)
				{
				}
				num = (short)34930688;
				short num3 = num;
				return this.emerWideGeneralSilentAlarm_A9130;
			}
		}

		// Token: 0x17004D35 RID: 19765
		// (get) Token: 0x060099C6 RID: 39366 RVA: 0x00901F9C File Offset: 0x0090019C
		// (set) Token: 0x060099C7 RID: 39367 RVA: 0x00902050 File Offset: 0x00900250
		public bool EmerWideGeneralSilentAlarm_A9130_UIValue
		{
			get
			{
				short num = (short)1607318410;
				short num2 = num;
				num = (short)1534114698;
				switch (num2 == num)
				{
				}
				num = (short)868286465;
				if (num != 0)
				{
				}
				num = (short)85458944;
				if (num != 0)
				{
				}
				num = (short)1306984448;
				short num3 = num;
				return this.emerWideGeneralSilentAlarm_A9130.Value;
			}
			set
			{
				short num = (short)241707613;
				short num2 = num;
				num = (short)663300701;
				switch (num2 == num)
				{
				}
				num = (short)1571225601;
				if (num != 0)
				{
				}
				num = (short)909770752;
				if (num != 0)
				{
				}
				num = (short)1872035840;
				short num3 = num;
				this.emerWideGeneralSilentAlarm_A9130.Value = value;
			}
		}

		// Token: 0x17004D36 RID: 19766
		// (get) Token: 0x060099C8 RID: 39368 RVA: 0x00902104 File Offset: 0x00900304
		// (set) Token: 0x060099C9 RID: 39369 RVA: 0x009021B8 File Offset: 0x009003B8
		public bool EmerWideGeneralSilentAlarm_A9130_Applicable
		{
			get
			{
				short num = (short)854328516;
				short num2 = num;
				num = (short)1600849092;
				switch (num2 == num)
				{
				}
				num = (short)1688207360;
				if (num != 0)
				{
				}
				num = (short)1224736769;
				if (num != 0)
				{
				}
				num = (short)1313275904;
				short num3 = num;
				return this.emerWideGeneralSilentAlarm_A9130.Applicable;
			}
			set
			{
				short num = (short)726146496;
				short num2 = num;
				num = (short)1405033920;
				switch (num2 == num)
				{
				}
				num = (short)1555103744;
				if (num != 0)
				{
				}
				num = (short)874053633;
				if (num != 0)
				{
				}
				num = (short)511049728;
				short num3 = num;
				this.emerWideGeneralSilentAlarm_A9130.Applicable = value;
			}
		}

		// Token: 0x17004D37 RID: 19767
		// (get) Token: 0x060099CA RID: 39370 RVA: 0x00902270 File Offset: 0x00900470
		// (set) Token: 0x060099CB RID: 39371 RVA: 0x00902324 File Offset: 0x00900524
		public bool EmerWideGeneralSilentAlarm_A9130_Valid
		{
			get
			{
				short num = (short)989528065;
				if (num != 0)
				{
				}
				num = (short)504046532;
				short num2 = num;
				num = (short)1781474244;
				switch (num2 == num)
				{
				}
				num = (short)1313734656;
				if (num != 0)
				{
				}
				num = (short)1357709312;
				short num3 = num;
				return this.emerWideGeneralSilentAlarm_A9130.Valid;
			}
			set
			{
				short num = (short)276094723;
				short num2 = num;
				num = (short)372891395;
				switch (num2 == num)
				{
				}
				num = (short)2017591296;
				if (num != 0)
				{
				}
				num = (short)1086586881;
				if (num != 0)
				{
				}
				num = (short)1068367872;
				short num3 = num;
				this.emerWideGeneralSilentAlarm_A9130.Valid = value;
			}
		}

		// Token: 0x17004D38 RID: 19768
		// (get) Token: 0x060099CC RID: 39372 RVA: 0x009023D4 File Offset: 0x009005D4
		// (set) Token: 0x060099CD RID: 39373 RVA: 0x00902488 File Offset: 0x00900688
		public bool EmerWideGeneralSilentAlarm_A9130_Visible
		{
			get
			{
				short num = (short)1715624617;
				short num2 = num;
				num = (short)739007145;
				switch (num2 == num)
				{
				}
				num = (short)920518656;
				if (num != 0)
				{
				}
				num = (short)2010513409;
				if (num != 0)
				{
				}
				num = (short)1757741056;
				short num3 = num;
				return this.emerWideGeneralSilentAlarm_A9130.Visible;
			}
			set
			{
				short num = (short)1281087564;
				short num2 = num;
				num = (short)1961351244;
				switch (num2 == num)
				{
				}
				num = (short)1200947201;
				if (num != 0)
				{
				}
				num = (short)479395840;
				if (num != 0)
				{
				}
				num = (short)499908608;
				short num3 = num;
				this.emerWideGeneralSilentAlarm_A9130.Visible = value;
			}
		}

		// Token: 0x17004D39 RID: 19769
		// (get) Token: 0x060099CE RID: 39374 RVA: 0x00902540 File Offset: 0x00900740
		// (set) Token: 0x060099CF RID: 39375 RVA: 0x009025F4 File Offset: 0x009007F4
		public bool EmerWideGeneralSilentAlarm_A9130_Editable
		{
			get
			{
				short num = (short)161929428;
				short num2 = num;
				num = (short)1628821716;
				switch (num2 == num)
				{
				}
				num = (short)754515969;
				if (num != 0)
				{
				}
				num = (short)805502976;
				if (num != 0)
				{
				}
				num = (short)1382809600;
				short num3 = num;
				return this.emerWideGeneralSilentAlarm_A9130.Editable;
			}
			set
			{
				short num = (short)474712089;
				short num2 = num;
				num = (short)1134790681;
				switch (num2 == num)
				{
				}
				num = (short)967245825;
				if (num != 0)
				{
				}
				num = (short)1266024448;
				if (num != 0)
				{
				}
				num = (short)1113784320;
				short num3 = num;
				this.emerWideGeneralSilentAlarm_A9130.Editable = value;
			}
		}

		// Token: 0x17004D3A RID: 19770
		// (get) Token: 0x060099D0 RID: 39376 RVA: 0x009026A8 File Offset: 0x009008A8
		internal string EmerWideGeneralSilentAlarm_A9130_UILabel
		{
			get
			{
				short num = (short)195043681;
				short num2 = num;
				num = (short)1845502305;
				switch (num2 == num)
				{
				}
				num = (short)1793654784;
				if (num != 0)
				{
				}
				num = (short)1432092673;
				if (num != 0)
				{
				}
				num = (short)1397555200;
				short num3 = num;
				return this.emerWideGeneralSilentAlarm_A9130.UIName;
			}
		}

		// Token: 0x17004D3B RID: 19771
		// (get) Token: 0x060099D1 RID: 39377 RVA: 0x0090275C File Offset: 0x0090095C
		// (set) Token: 0x060099D2 RID: 39378 RVA: 0x00902810 File Offset: 0x00900A10
		internal bool EmerWideGeneralSilentAlarm_A9130_HiddenStatic
		{
			get
			{
				short num = (short)59333913;
				short num2 = num;
				num = (short)2098814233;
				switch (num2 == num)
				{
				}
				num = (short)820707328;
				if (num != 0)
				{
				}
				num = (short)703987713;
				if (num != 0)
				{
				}
				num = (short)489684992;
				short num3 = num;
				return this.emerWideGeneralSilentAlarm_A9130.HiddenStatic;
			}
			set
			{
				short num = (short)664540264;
				short num2 = num;
				num = (short)147592296;
				switch (num2 == num)
				{
				}
				num = (short)1723924481;
				if (num != 0)
				{
				}
				num = (short)612761600;
				if (num != 0)
				{
				}
				num = (short)714276864;
				short num3 = num;
				this.emerWideGeneralSilentAlarm_A9130.HiddenStatic = value;
			}
		}

		// Token: 0x17004D3C RID: 19772
		// (get) Token: 0x060099D3 RID: 39379 RVA: 0x009028C8 File Offset: 0x00900AC8
		// (set) Token: 0x060099D4 RID: 39380 RVA: 0x00902978 File Offset: 0x00900B78
		internal bool EmerWideGeneralSilentAlarm_A9130_HiddenDynamic
		{
			get
			{
				short num = (short)1651548356;
				short num2 = num;
				num = (short)310354116;
				switch (num2 == num)
				{
				}
				num = (short)906625024;
				if (num != 0)
				{
				}
				num = (short)927465473;
				if (num != 0)
				{
				}
				num = (short)1027145728;
				short num3 = num;
				return this.emerWideGeneralSilentAlarm_A9130.HiddenDynamic;
			}
			set
			{
				short num = (short)561402729;
				short num2 = num;
				num = (short)808670057;
				switch (num2 == num)
				{
				}
				num = (short)587923457;
				if (num != 0)
				{
				}
				num = (short)1777991680;
				if (num != 0)
				{
				}
				num = (short)2100756480;
				short num3 = num;
				this.emerWideGeneralSilentAlarm_A9130.HiddenDynamic = value;
			}
		}

		// Token: 0x17004D3D RID: 19773
		// (get) Token: 0x060099D5 RID: 39381 RVA: 0x00902A30 File Offset: 0x00900C30
		public bool EmerWideGeneralSilentAlarm_A9130_HasDiffs
		{
			get
			{
				short num = (short)168558593;
				if (num != 0)
				{
				}
				num = (short)1825628553;
				short num2 = num;
				num = (short)2087903625;
				switch (num2 == num)
				{
				}
				num = (short)257622016;
				if (num != 0)
				{
				}
				num = (short)317521920;
				short num3 = num;
				return this.emerWideGeneralSilentAlarm_A9130._HasDiffs;
			}
		}

		// Token: 0x17004D3E RID: 19774
		// (get) Token: 0x060099D6 RID: 39382 RVA: 0x00902AE4 File Offset: 0x00900CE4
		// (set) Token: 0x060099D7 RID: 39383 RVA: 0x00902B98 File Offset: 0x00900D98
		public bool EmerWideGeneralUnmuteOption_A9598Value
		{
			get
			{
				short num = (short)416924170;
				short num2 = num;
				num = (short)618906122;
				switch (num2 == num)
				{
				}
				num = (short)723779585;
				if (num != 0)
				{
				}
				num = (short)151781376;
				if (num != 0)
				{
				}
				num = (short)1321598976;
				short num3 = num;
				return this.emerWideGeneralUnmuteOption_A9598.Value;
			}
			set
			{
				short num = (short)1734855393;
				short num2 = num;
				num = (short)295095009;
				switch (num2 == num)
				{
				}
				num = (short)2055405569;
				if (num != 0)
				{
				}
				num = (short)707002368;
				if (num != 0)
				{
				}
				num = (short)1252655104;
				short num3 = num;
				this.emerWideGeneralUnmuteOption_A9598.Value = value;
			}
		}

		// Token: 0x17004D3F RID: 19775
		// (get) Token: 0x060099D8 RID: 39384 RVA: 0x00902C54 File Offset: 0x00900E54
		public global::AcpBusinessLayer.AcpField<bool> EmerWideGeneralUnmuteOption_A9598
		{
			get
			{
				short num = (short)585278792;
				short num2 = num;
				num = (short)104047944;
				switch (num2 == num)
				{
				}
				num = (short)2045444096;
				if (num != 0)
				{
				}
				num = (short)717160449;
				if (num != 0)
				{
				}
				num = (short)1349910528;
				short num3 = num;
				return this.emerWideGeneralUnmuteOption_A9598;
			}
		}

		// Token: 0x17004D40 RID: 19776
		// (get) Token: 0x060099D9 RID: 39385 RVA: 0x00902D04 File Offset: 0x00900F04
		// (set) Token: 0x060099DA RID: 39386 RVA: 0x00902DB8 File Offset: 0x00900FB8
		public bool EmerWideGeneralUnmuteOption_A9598_UIValue
		{
			get
			{
				short num = (short)57431816;
				short num2 = num;
				num = (short)1214797576;
				switch (num2 == num)
				{
				}
				num = (short)1672019968;
				if (num != 0)
				{
				}
				num = (short)396165121;
				if (num != 0)
				{
				}
				num = (short)496697344;
				short num3 = num;
				return this.emerWideGeneralUnmuteOption_A9598.Value;
			}
			set
			{
				short num = (short)1650973593;
				short num2 = num;
				num = (short)285989785;
				switch (num2 == num)
				{
				}
				num = (short)1194917889;
				if (num != 0)
				{
				}
				num = (short)3932160;
				if (num != 0)
				{
				}
				num = (short)1759248384;
				short num3 = num;
				this.emerWideGeneralUnmuteOption_A9598.Value = value;
			}
		}

		// Token: 0x17004D41 RID: 19777
		// (get) Token: 0x060099DB RID: 39387 RVA: 0x00902E6C File Offset: 0x0090106C
		// (set) Token: 0x060099DC RID: 39388 RVA: 0x00902F20 File Offset: 0x00901120
		public bool EmerWideGeneralUnmuteOption_A9598_Applicable
		{
			get
			{
				short num = (short)941377895;
				short num2 = num;
				num = (short)294603111;
				switch (num2 == num)
				{
				}
				num = (short)234487809;
				if (num != 0)
				{
				}
				num = (short)427687936;
				if (num != 0)
				{
				}
				num = (short)1520238592;
				short num3 = num;
				return this.emerWideGeneralUnmuteOption_A9598.Applicable;
			}
			set
			{
				short num = (short)1046760578;
				short num2 = num;
				num = (short)90328194;
				switch (num2 == num)
				{
				}
				num = (short)1198522369;
				if (num != 0)
				{
				}
				num = (short)492634112;
				if (num != 0)
				{
				}
				num = (short)2047606784;
				short num3 = num;
				this.emerWideGeneralUnmuteOption_A9598.Applicable = value;
			}
		}

		// Token: 0x17004D42 RID: 19778
		// (get) Token: 0x060099DD RID: 39389 RVA: 0x00902FD4 File Offset: 0x009011D4
		// (set) Token: 0x060099DE RID: 39390 RVA: 0x00903088 File Offset: 0x00901288
		public bool EmerWideGeneralUnmuteOption_A9598_Valid
		{
			get
			{
				short num = (short)910557185;
				if (num != 0)
				{
				}
				num = (short)842135607;
				short num2 = num;
				num = (short)1510996023;
				switch (num2 == num)
				{
				}
				num = (short)406257664;
				if (num != 0)
				{
				}
				num = (short)560660480;
				short num3 = num;
				return this.emerWideGeneralUnmuteOption_A9598.Valid;
			}
			set
			{
				short num = (short)263584053;
				short num2 = num;
				num = (short)1435367733;
				switch (num2 == num)
				{
				}
				num = (short)1449459713;
				if (num != 0)
				{
				}
				num = (short)656277504;
				if (num != 0)
				{
				}
				num = (short)1300103168;
				short num3 = num;
				this.emerWideGeneralUnmuteOption_A9598.Valid = value;
			}
		}

		// Token: 0x17004D43 RID: 19779
		// (get) Token: 0x060099DF RID: 39391 RVA: 0x0090313C File Offset: 0x0090133C
		// (set) Token: 0x060099E0 RID: 39392 RVA: 0x009031F0 File Offset: 0x009013F0
		public bool EmerWideGeneralUnmuteOption_A9598_Visible
		{
			get
			{
				short num = (short)1411112032;
				short num2 = num;
				num = (short)1518263392;
				switch (num2 == num)
				{
				}
				num = (short)362676225;
				if (num != 0)
				{
				}
				num = (short)1664155648;
				if (num != 0)
				{
				}
				num = (short)921960448;
				short num3 = num;
				return this.emerWideGeneralUnmuteOption_A9598.Visible;
			}
			set
			{
				short num = (short)167903233;
				if (num != 0)
				{
				}
				num = (short)1418748835;
				short num2 = num;
				num = (short)301818787;
				switch (num2 == num)
				{
				}
				num = (short)425459712;
				if (num != 0)
				{
				}
				num = (short)1981218816;
				short num3 = num;
				this.emerWideGeneralUnmuteOption_A9598.Visible = value;
			}
		}

		// Token: 0x17004D44 RID: 19780
		// (get) Token: 0x060099E1 RID: 39393 RVA: 0x009032A4 File Offset: 0x009014A4
		// (set) Token: 0x060099E2 RID: 39394 RVA: 0x00903358 File Offset: 0x00901558
		public bool EmerWideGeneralUnmuteOption_A9598_Editable
		{
			get
			{
				short num = (short)1431256259;
				short num2 = num;
				num = (short)955137219;
				switch (num2 == num)
				{
				}
				num = (short)2067202049;
				if (num != 0)
				{
				}
				num = (short)1436483584;
				if (num != 0)
				{
				}
				num = (short)1727594496;
				short num3 = num;
				return this.emerWideGeneralUnmuteOption_A9598.Editable;
			}
			set
			{
				short num = (short)1546918696;
				short num2 = num;
				num = (short)691084072;
				switch (num2 == num)
				{
				}
				num = (short)2044788737;
				if (num != 0)
				{
				}
				num = (short)378929152;
				if (num != 0)
				{
				}
				num = (short)409075712;
				short num3 = num;
				this.emerWideGeneralUnmuteOption_A9598.Editable = value;
			}
		}

		// Token: 0x17004D45 RID: 19781
		// (get) Token: 0x060099E3 RID: 39395 RVA: 0x0090340C File Offset: 0x0090160C
		internal string EmerWideGeneralUnmuteOption_A9598_UILabel
		{
			get
			{
				short num = (short)651418627;
				short num2 = num;
				num = (short)1733417987;
				switch (num2 == num)
				{
				}
				num = (short)173080577;
				if (num != 0)
				{
				}
				num = (short)1300889600;
				if (num != 0)
				{
				}
				num = (short)139001856;
				short num3 = num;
				return this.emerWideGeneralUnmuteOption_A9598.UIName;
			}
		}

		// Token: 0x17004D46 RID: 19782
		// (get) Token: 0x060099E4 RID: 39396 RVA: 0x009034C0 File Offset: 0x009016C0
		// (set) Token: 0x060099E5 RID: 39397 RVA: 0x00903578 File Offset: 0x00901778
		internal bool EmerWideGeneralUnmuteOption_A9598_HiddenStatic
		{
			get
			{
				short num = (short)1280531195;
				short num2 = num;
				num = (short)362961659;
				switch (num2 == num)
				{
				}
				num = (short)166199297;
				if (num != 0)
				{
				}
				num = (short)365101056;
				if (num != 0)
				{
				}
				num = (short)1031077888;
				short num3 = num;
				return this.emerWideGeneralUnmuteOption_A9598.HiddenStatic;
			}
			set
			{
				short num = (short)1076378959;
				short num2 = num;
				num = (short)325336399;
				switch (num2 == num)
				{
				}
				num = (short)1906704385;
				if (num != 0)
				{
				}
				num = (short)353632256;
				if (num != 0)
				{
				}
				num = (short)1735262208;
				short num3 = num;
				this.emerWideGeneralUnmuteOption_A9598.HiddenStatic = value;
			}
		}

		// Token: 0x17004D47 RID: 19783
		// (get) Token: 0x060099E6 RID: 39398 RVA: 0x00903630 File Offset: 0x00901830
		// (set) Token: 0x060099E7 RID: 39399 RVA: 0x009036E4 File Offset: 0x009018E4
		internal bool EmerWideGeneralUnmuteOption_A9598_HiddenDynamic
		{
			get
			{
				short num = (short)1181597766;
				short num2 = num;
				num = (short)2045952070;
				switch (num2 == num)
				{
				}
				num = (short)349372417;
				if (num != 0)
				{
				}
				num = (short)134545408;
				if (num != 0)
				{
				}
				num = (short)870318080;
				short num3 = num;
				return this.emerWideGeneralUnmuteOption_A9598.HiddenDynamic;
			}
			set
			{
				short num = (short)1031459482;
				short num2 = num;
				num = (short)110482074;
				switch (num2 == num)
				{
				}
				num = (short)1119485953;
				if (num != 0)
				{
				}
				num = (short)1910374400;
				if (num != 0)
				{
				}
				num = (short)1131479040;
				short num3 = num;
				this.emerWideGeneralUnmuteOption_A9598.HiddenDynamic = value;
			}
		}

		// Token: 0x17004D48 RID: 19784
		// (get) Token: 0x060099E8 RID: 39400 RVA: 0x00903798 File Offset: 0x00901998
		public bool EmerWideGeneralUnmuteOption_A9598_HasDiffs
		{
			get
			{
				short num = (short)1955310154;
				short num2 = num;
				num = (short)2067901002;
				switch (num2 == num)
				{
				}
				num = (short)1306001409;
				if (num != 0)
				{
				}
				num = (short)826540032;
				if (num != 0)
				{
				}
				num = (short)926285824;
				short num3 = num;
				return this.emerWideGeneralUnmuteOption_A9598._HasDiffs;
			}
		}

		// Token: 0x17004D49 RID: 19785
		// (get) Token: 0x060099E9 RID: 39401 RVA: 0x0090384C File Offset: 0x00901A4C
		// (set) Token: 0x060099EA RID: 39402 RVA: 0x00903900 File Offset: 0x00901B00
		public bool EmerWideGeneralSuppressEmergencyCall_A42142Value
		{
			get
			{
				short num = (short)1060816229;
				short num2 = num;
				num = (short)1424803173;
				switch (num2 == num)
				{
				}
				num = (short)42270720;
				if (num != 0)
				{
				}
				num = (short)2073165825;
				if (num != 0)
				{
				}
				num = (short)1273036800;
				short num3 = num;
				return this.emerWideGeneralSuppressEmergencyCall_A42142.Value;
			}
			set
			{
				short num = (short)688193537;
				if (num != 0)
				{
				}
				num = (short)1101100464;
				short num2 = num;
				num = (short)1118729648;
				switch (num2 == num)
				{
				}
				num = (short)1099694080;
				if (num != 0)
				{
				}
				num = (short)1720254464;
				short num3 = num;
				this.emerWideGeneralSuppressEmergencyCall_A42142.Value = value;
			}
		}

		// Token: 0x17004D4A RID: 19786
		// (get) Token: 0x060099EB RID: 39403 RVA: 0x009039B4 File Offset: 0x00901BB4
		public global::AcpBusinessLayer.AcpField<bool> EmerWideGeneralSuppressEmergencyCall_A42142
		{
			get
			{
				short num = (short)15663105;
				if (num != 0)
				{
				}
				num = (short)452688003;
				short num2 = num;
				num = (short)514947203;
				switch (num2 == num)
				{
				}
				num = (short)2082013184;
				if (num != 0)
				{
				}
				num = (short)2033647616;
				short num3 = num;
				return this.emerWideGeneralSuppressEmergencyCall_A42142;
			}
		}

		// Token: 0x17004D4B RID: 19787
		// (get) Token: 0x060099EC RID: 39404 RVA: 0x00903A64 File Offset: 0x00901C64
		// (set) Token: 0x060099ED RID: 39405 RVA: 0x00903B18 File Offset: 0x00901D18
		public bool EmerWideGeneralSuppressEmergencyCall_A42142_UIValue
		{
			get
			{
				short num = (short)196760025;
				short num2 = num;
				num = (short)673534425;
				switch (num2 == num)
				{
				}
				num = (short)2130378753;
				if (num != 0)
				{
				}
				num = (short)1150812160;
				if (num != 0)
				{
				}
				num = (short)436469760;
				short num3 = num;
				return this.emerWideGeneralSuppressEmergencyCall_A42142.Value;
			}
			set
			{
				short num = (short)103568632;
				short num2 = num;
				num = (short)182015224;
				switch (num2 == num)
				{
				}
				num = (short)64225280;
				if (num != 0)
				{
				}
				num = (short)552271873;
				if (num != 0)
				{
				}
				num = (short)591396864;
				short num3 = num;
				this.emerWideGeneralSuppressEmergencyCall_A42142.Value = value;
			}
		}

		// Token: 0x17004D4C RID: 19788
		// (get) Token: 0x060099EE RID: 39406 RVA: 0x00903BD0 File Offset: 0x00901DD0
		// (set) Token: 0x060099EF RID: 39407 RVA: 0x00903C88 File Offset: 0x00901E88
		public bool EmerWideGeneralSuppressEmergencyCall_A42142_Applicable
		{
			get
			{
				short num = (short)748020024;
				short num2 = num;
				num = (short)1192681784;
				switch (num2 == num)
				{
				}
				num = (short)938934272;
				if (num != 0)
				{
				}
				num = (short)1171390465;
				if (num != 0)
				{
				}
				num = (short)91226112;
				short num3 = num;
				return this.emerWideGeneralSuppressEmergencyCall_A42142.Applicable;
			}
			set
			{
				short num = (short)1916704566;
				short num2 = num;
				num = (short)492148534;
				switch (num2 == num)
				{
				}
				num = (short)1494024193;
				if (num != 0)
				{
				}
				num = (short)1124270080;
				if (num != 0)
				{
				}
				num = (short)686292992;
				short num3 = num;
				this.emerWideGeneralSuppressEmergencyCall_A42142.Applicable = value;
			}
		}

		// Token: 0x17004D4D RID: 19789
		// (get) Token: 0x060099F0 RID: 39408 RVA: 0x00903D3C File Offset: 0x00901F3C
		// (set) Token: 0x060099F1 RID: 39409 RVA: 0x00903DF4 File Offset: 0x00901FF4
		public bool EmerWideGeneralSuppressEmergencyCall_A42142_Valid
		{
			get
			{
				short num = (short)642057275;
				short num2 = num;
				num = (short)1822491707;
				switch (num2 == num)
				{
				}
				num = (short)473825281;
				if (num != 0)
				{
				}
				num = (short)413466624;
				if (num != 0)
				{
				}
				num = (short)1108869120;
				short num3 = num;
				return this.emerWideGeneralSuppressEmergencyCall_A42142.Valid;
			}
			set
			{
				short num = (short)1477473866;
				short num2 = num;
				num = (short)1083733578;
				switch (num2 == num)
				{
				}
				num = (short)1726021632;
				if (num != 0)
				{
				}
				num = (short)155385857;
				if (num != 0)
				{
				}
				num = (short)108331008;
				short num3 = num;
				this.emerWideGeneralSuppressEmergencyCall_A42142.Valid = value;
			}
		}

		// Token: 0x17004D4E RID: 19790
		// (get) Token: 0x060099F2 RID: 39410 RVA: 0x00903EAC File Offset: 0x009020AC
		// (set) Token: 0x060099F3 RID: 39411 RVA: 0x00903F64 File Offset: 0x00902164
		public bool EmerWideGeneralSuppressEmergencyCall_A42142_Visible
		{
			get
			{
				short num = (short)2072302265;
				short num2 = num;
				num = (short)2127811257;
				switch (num2 == num)
				{
				}
				num = (short)780468224;
				if (num != 0)
				{
				}
				num = (short)154664961;
				if (num != 0)
				{
				}
				num = (short)1611661312;
				short num3 = num;
				return this.emerWideGeneralSuppressEmergencyCall_A42142.Visible;
			}
			set
			{
				short num = (short)2053111809;
				if (num != 0)
				{
				}
				num = (short)333083253;
				short num2 = num;
				num = (short)1542550133;
				switch (num2 == num)
				{
				}
				num = (short)586088448;
				if (num != 0)
				{
				}
				num = (short)1221656576;
				short num3 = num;
				this.emerWideGeneralSuppressEmergencyCall_A42142.Visible = value;
			}
		}

		// Token: 0x17004D4F RID: 19791
		// (get) Token: 0x060099F4 RID: 39412 RVA: 0x00904018 File Offset: 0x00902218
		// (set) Token: 0x060099F5 RID: 39413 RVA: 0x009040CC File Offset: 0x009022CC
		public bool EmerWideGeneralSuppressEmergencyCall_A42142_Editable
		{
			get
			{
				short num = (short)1141506049;
				if (num != 0)
				{
				}
				num = (short)2032682472;
				short num2 = num;
				num = (short)819152360;
				switch (num2 == num)
				{
				}
				num = (short)1031405568;
				if (num != 0)
				{
				}
				num = (short)1052442624;
				short num3 = num;
				return this.emerWideGeneralSuppressEmergencyCall_A42142.Editable;
			}
			set
			{
				short num = (short)2073174062;
				short num2 = num;
				num = (short)734928942;
				switch (num2 == num)
				{
				}
				num = (short)306511872;
				if (num != 0)
				{
				}
				num = (short)308805633;
				if (num != 0)
				{
				}
				num = (short)887947264;
				short num3 = num;
				this.emerWideGeneralSuppressEmergencyCall_A42142.Editable = value;
			}
		}

		// Token: 0x17004D50 RID: 19792
		// (get) Token: 0x060099F6 RID: 39414 RVA: 0x00904180 File Offset: 0x00902380
		internal string EmerWideGeneralSuppressEmergencyCall_A42142_UILabel
		{
			get
			{
				short num = (short)1590932469;
				short num2 = num;
				num = (short)860337141;
				switch (num2 == num)
				{
				}
				num = (short)483262465;
				if (num != 0)
				{
				}
				num = (short)1271726080;
				if (num != 0)
				{
				}
				num = (short)240123904;
				short num3 = num;
				return this.emerWideGeneralSuppressEmergencyCall_A42142.UIName;
			}
		}

		// Token: 0x17004D51 RID: 19793
		// (get) Token: 0x060099F7 RID: 39415 RVA: 0x00904234 File Offset: 0x00902434
		// (set) Token: 0x060099F8 RID: 39416 RVA: 0x009042E8 File Offset: 0x009024E8
		internal bool EmerWideGeneralSuppressEmergencyCall_A42142_HiddenStatic
		{
			get
			{
				short num = (short)1364115565;
				short num2 = num;
				num = (short)329302125;
				switch (num2 == num)
				{
				}
				num = (short)1375076352;
				if (num != 0)
				{
				}
				num = (short)309329921;
				if (num != 0)
				{
				}
				num = (short)63635456;
				short num3 = num;
				return this.emerWideGeneralSuppressEmergencyCall_A42142.HiddenStatic;
			}
			set
			{
				short num = (short)2004383388;
				short num2 = num;
				num = (short)1329821340;
				switch (num2 == num)
				{
				}
				num = (short)1714421761;
				if (num != 0)
				{
				}
				num = (short)468647936;
				if (num != 0)
				{
				}
				num = (short)328728576;
				short num3 = num;
				this.emerWideGeneralSuppressEmergencyCall_A42142.HiddenStatic = value;
			}
		}

		// Token: 0x17004D52 RID: 19794
		// (get) Token: 0x060099F9 RID: 39417 RVA: 0x009043A0 File Offset: 0x009025A0
		// (set) Token: 0x060099FA RID: 39418 RVA: 0x00904454 File Offset: 0x00902654
		internal bool EmerWideGeneralSuppressEmergencyCall_A42142_HiddenDynamic
		{
			get
			{
				short num = (short)520423983;
				short num2 = num;
				num = (short)674236975;
				switch (num2 == num)
				{
				}
				num = (short)512360448;
				if (num != 0)
				{
				}
				num = (short)141557761;
				if (num != 0)
				{
				}
				num = (short)1247477760;
				short num3 = num;
				return this.emerWideGeneralSuppressEmergencyCall_A42142.HiddenDynamic;
			}
			set
			{
				short num = (short)1034040343;
				short num2 = num;
				num = (short)78787607;
				switch (num2 == num)
				{
				}
				num = (short)852688897;
				if (num != 0)
				{
				}
				num = (short)1328218112;
				if (num != 0)
				{
				}
				num = (short)796393472;
				short num3 = num;
				this.emerWideGeneralSuppressEmergencyCall_A42142.HiddenDynamic = value;
			}
		}

		// Token: 0x17004D53 RID: 19795
		// (get) Token: 0x060099FB RID: 39419 RVA: 0x00904508 File Offset: 0x00902708
		public bool EmerWideGeneralSuppressEmergencyCall_A42142_HasDiffs
		{
			get
			{
				short num = (short)1709834241;
				if (num != 0)
				{
				}
				num = (short)1455312210;
				short num2 = num;
				num = (short)2057456978;
				switch (num2 == num)
				{
				}
				num = (short)933363712;
				if (num != 0)
				{
				}
				num = (short)1910046720;
				short num3 = num;
				return this.emerWideGeneralSuppressEmergencyCall_A42142._HasDiffs;
			}
		}

		// Token: 0x17004D54 RID: 19796
		// (get) Token: 0x060099FC RID: 39420 RVA: 0x009045BC File Offset: 0x009027BC
		// (set) Token: 0x060099FD RID: 39421 RVA: 0x00904674 File Offset: 0x00902874
		public bool EmerWideGeneralDistinguishEmergencyType_43546Value
		{
			get
			{
				short num = (short)488709333;
				short num2 = num;
				num = (short)1258626261;
				switch (num2 == num)
				{
				}
				num = (short)653590529;
				if (num != 0)
				{
				}
				num = (short)2009858048;
				if (num != 0)
				{
				}
				num = (short)1010696192;
				short num3 = num;
				return this.emerWideGeneralDistinguishEmergencyType_43546.Value;
			}
			set
			{
				short num = (short)669348387;
				short num2 = num;
				num = (short)1110733347;
				switch (num2 == num)
				{
				}
				num = (short)1310064640;
				if (num != 0)
				{
				}
				num = (short)1885208577;
				if (num != 0)
				{
				}
				num = (short)1307967488;
				short num3 = num;
				this.emerWideGeneralDistinguishEmergencyType_43546.Value = value;
			}
		}

		// Token: 0x17004D55 RID: 19797
		// (get) Token: 0x060099FE RID: 39422 RVA: 0x00904728 File Offset: 0x00902928
		public global::AcpBusinessLayer.AcpField<bool> EmerWideGeneralDistinguishEmergencyType_43546
		{
			get
			{
				short num = (short)1443159515;
				short num2 = num;
				num = (short)1446174171;
				switch (num2 == num)
				{
				}
				num = (short)1464729600;
				if (num != 0)
				{
				}
				num = (short)1019543553;
				if (num != 0)
				{
				}
				num = (short)403832832;
				short num3 = num;
				return this.emerWideGeneralDistinguishEmergencyType_43546;
			}
		}

		// Token: 0x17004D56 RID: 19798
		// (get) Token: 0x060099FF RID: 39423 RVA: 0x009047D8 File Offset: 0x009029D8
		// (set) Token: 0x06009A00 RID: 39424 RVA: 0x0090488C File Offset: 0x00902A8C
		public bool EmerWideGeneralDistinguishEmergencyType_43546_UIValue
		{
			get
			{
				short num = (short)2067336332;
				short num2 = num;
				num = (short)681970828;
				switch (num2 == num)
				{
				}
				num = (short)1162870784;
				if (num != 0)
				{
				}
				num = (short)412745729;
				if (num != 0)
				{
				}
				num = (short)770244608;
				short num3 = num;
				return this.emerWideGeneralDistinguishEmergencyType_43546.Value;
			}
			set
			{
				short num = (short)1507861643;
				short num2 = num;
				num = (short)592061579;
				switch (num2 == num)
				{
				}
				num = (short)29425665;
				if (num != 0)
				{
				}
				num = (short)832897024;
				if (num != 0)
				{
				}
				num = (short)828571648;
				short num3 = num;
				this.emerWideGeneralDistinguishEmergencyType_43546.Value = value;
			}
		}

		// Token: 0x17004D57 RID: 19799
		// (get) Token: 0x06009A01 RID: 39425 RVA: 0x00904940 File Offset: 0x00902B40
		// (set) Token: 0x06009A02 RID: 39426 RVA: 0x009049F4 File Offset: 0x00902BF4
		public bool EmerWideGeneralDistinguishEmergencyType_43546_Applicable
		{
			get
			{
				short num = (short)1023297380;
				short num2 = num;
				num = (short)881543012;
				switch (num2 == num)
				{
				}
				num = (short)1703346176;
				if (num != 0)
				{
				}
				num = (short)1760952321;
				if (num != 0)
				{
				}
				num = (short)237240320;
				short num3 = num;
				return this.emerWideGeneralDistinguishEmergencyType_43546.Applicable;
			}
			set
			{
				short num = (short)1890745184;
				short num2 = num;
				num = (short)1482390368;
				switch (num2 == num)
				{
				}
				num = (short)359858176;
				if (num != 0)
				{
				}
				num = (short)1192689665;
				if (num != 0)
				{
				}
				num = (short)1346633728;
				short num3 = num;
				this.emerWideGeneralDistinguishEmergencyType_43546.Applicable = value;
			}
		}

		// Token: 0x17004D58 RID: 19800
		// (get) Token: 0x06009A03 RID: 39427 RVA: 0x00904AA8 File Offset: 0x00902CA8
		// (set) Token: 0x06009A04 RID: 39428 RVA: 0x00904B5C File Offset: 0x00902D5C
		public bool EmerWideGeneralDistinguishEmergencyType_43546_Valid
		{
			get
			{
				short num = (short)266083813;
				short num2 = num;
				num = (short)1134829029;
				switch (num2 == num)
				{
				}
				num = (short)365756417;
				if (num != 0)
				{
				}
				num = (short)857276416;
				if (num != 0)
				{
				}
				num = (short)1864761344;
				short num3 = num;
				return this.emerWideGeneralDistinguishEmergencyType_43546.Valid;
			}
			set
			{
				short num = (short)895139108;
				short num2 = num;
				num = (short)538623268;
				switch (num2 == num)
				{
				}
				num = (short)134742016;
				if (num != 0)
				{
				}
				num = (short)124387329;
				if (num != 0)
				{
				}
				num = (short)1853292544;
				short num3 = num;
				this.emerWideGeneralDistinguishEmergencyType_43546.Valid = value;
			}
		}

		// Token: 0x17004D59 RID: 19801
		// (get) Token: 0x06009A05 RID: 39429 RVA: 0x00904C14 File Offset: 0x00902E14
		// (set) Token: 0x06009A06 RID: 39430 RVA: 0x00904CC8 File Offset: 0x00902EC8
		public bool EmerWideGeneralDistinguishEmergencyType_43546_Visible
		{
			get
			{
				short num = (short)21167313;
				short num2 = num;
				num = (short)838532305;
				switch (num2 == num)
				{
				}
				num = (short)688717825;
				if (num != 0)
				{
				}
				num = (short)33292288;
				if (num != 0)
				{
				}
				num = (short)1305083904;
				short num3 = num;
				return this.emerWideGeneralDistinguishEmergencyType_43546.Visible;
			}
			set
			{
				short num = (short)1791307038;
				short num2 = num;
				num = (short)713305374;
				switch (num2 == num)
				{
				}
				num = (short)1609236480;
				if (num != 0)
				{
				}
				num = (short)1854865409;
				if (num != 0)
				{
				}
				num = (short)1682571264;
				short num3 = num;
				this.emerWideGeneralDistinguishEmergencyType_43546.Visible = value;
			}
		}

		// Token: 0x17004D5A RID: 19802
		// (get) Token: 0x06009A07 RID: 39431 RVA: 0x00904D80 File Offset: 0x00902F80
		// (set) Token: 0x06009A08 RID: 39432 RVA: 0x00904E34 File Offset: 0x00903034
		public bool EmerWideGeneralDistinguishEmergencyType_43546_Editable
		{
			get
			{
				short num = (short)1507517458;
				short num2 = num;
				num = (short)1656939538;
				switch (num2 == num)
				{
				}
				num = (short)793772033;
				if (num != 0)
				{
				}
				num = (short)1291845632;
				if (num != 0)
				{
				}
				num = (short)570621952;
				short num3 = num;
				return this.emerWideGeneralDistinguishEmergencyType_43546.Editable;
			}
			set
			{
				short num = (short)2108267731;
				short num2 = num;
				num = (short)930913491;
				switch (num2 == num)
				{
				}
				num = (short)326238209;
				if (num != 0)
				{
				}
				num = (short)2029256704;
				if (num != 0)
				{
				}
				num = (short)189595648;
				short num3 = num;
				this.emerWideGeneralDistinguishEmergencyType_43546.Editable = value;
			}
		}

		// Token: 0x17004D5B RID: 19803
		// (get) Token: 0x06009A09 RID: 39433 RVA: 0x00904EE8 File Offset: 0x009030E8
		internal string EmerWideGeneralDistinguishEmergencyType_43546_UILabel
		{
			get
			{
				short num = (short)944914893;
				short num2 = num;
				num = (short)1860846029;
				switch (num2 == num)
				{
				}
				num = (short)1814691841;
				if (num != 0)
				{
				}
				num = (short)699727872;
				if (num != 0)
				{
				}
				num = (short)1655177216;
				short num3 = num;
				return this.emerWideGeneralDistinguishEmergencyType_43546.UIName;
			}
		}

		// Token: 0x17004D5C RID: 19804
		// (get) Token: 0x06009A0A RID: 39434 RVA: 0x00904FA0 File Offset: 0x009031A0
		// (set) Token: 0x06009A0B RID: 39435 RVA: 0x00905054 File Offset: 0x00903254
		internal bool EmerWideGeneralDistinguishEmergencyType_43546_HiddenStatic
		{
			get
			{
				short num = (short)1971320441;
				short num2 = num;
				num = (short)1771632249;
				switch (num2 == num)
				{
				}
				num = (short)282656769;
				if (num != 0)
				{
				}
				num = (short)438370304;
				if (num != 0)
				{
				}
				num = (short)1529872384;
				short num3 = num;
				return this.emerWideGeneralDistinguishEmergencyType_43546.HiddenStatic;
			}
			set
			{
				short num = (short)1816825347;
				short num2 = num;
				num = (short)1904446979;
				switch (num2 == num)
				{
				}
				num = (short)1208549377;
				if (num != 0)
				{
				}
				num = (short)331612160;
				if (num != 0)
				{
				}
				num = (short)1713242112;
				short num3 = num;
				this.emerWideGeneralDistinguishEmergencyType_43546.HiddenStatic = value;
			}
		}

		// Token: 0x17004D5D RID: 19805
		// (get) Token: 0x06009A0C RID: 39436 RVA: 0x00905108 File Offset: 0x00903308
		// (set) Token: 0x06009A0D RID: 39437 RVA: 0x009051BC File Offset: 0x009033BC
		internal bool EmerWideGeneralDistinguishEmergencyType_43546_HiddenDynamic
		{
			get
			{
				short num = (short)328138753;
				if (num != 0)
				{
				}
				num = (short)1622830040;
				short num2 = num;
				num = (short)1046703064;
				switch (num2 == num)
				{
				}
				num = (short)307822592;
				if (num != 0)
				{
				}
				num = (short)1860632576;
				short num3 = num;
				return this.emerWideGeneralDistinguishEmergencyType_43546.HiddenDynamic;
			}
			set
			{
				short num = (short)211634567;
				short num2 = num;
				num = (short)2126006663;
				switch (num2 == num)
				{
				}
				num = (short)522387457;
				if (num != 0)
				{
				}
				num = (short)1845886976;
				if (num != 0)
				{
				}
				num = (short)799014912;
				short num3 = num;
				this.emerWideGeneralDistinguishEmergencyType_43546.HiddenDynamic = value;
			}
		}

		// Token: 0x17004D5E RID: 19806
		// (get) Token: 0x06009A0E RID: 39438 RVA: 0x00905270 File Offset: 0x00903470
		public bool EmerWideGeneralDistinguishEmergencyType_43546_HasDiffs
		{
			get
			{
				short num = (short)460224776;
				short num2 = num;
				num = (short)259291400;
				switch (num2 == num)
				{
				}
				num = (short)1888944129;
				if (num != 0)
				{
				}
				num = (short)318177280;
				if (num != 0)
				{
				}
				num = (short)903675904;
				short num3 = num;
				return this.emerWideGeneralDistinguishEmergencyType_43546._HasDiffs;
			}
		}

		// Token: 0x17004D5F RID: 19807
		// (get) Token: 0x06009A0F RID: 39439 RVA: 0x00905324 File Offset: 0x00903524
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)672858113;
				if (num != 0)
				{
				}
				num = (short)887705679;
				short num2 = num;
				num = (short)977948751;
				switch (num2 == num)
				{
				}
				num = (short)1440612352;
				if (num != 0)
				{
				}
				num = (short)1994850304;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06009A10 RID: 39440 RVA: 0x009053E4 File Offset: 0x009035E4
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1828913152;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4E;
			}
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_34:
				switch (num3)
				{
				case 0:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1718747139;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					IL_64:
					if (base.ParentRecset != null)
					{
						num = (short)1687355394;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E8;
				case 2:
					num = (short)1178009604;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_E8;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)849543168;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E8;
				}
				goto IL_4E;
				IL_E8:
				num = (short)248578049;
				if (num != 0)
				{
				}
				num = (short)822506959;
				short num4 = num;
				num = (short)1135900111;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_64;
				default:
					goto IL_143;
				}
			}
			IL_143:
			num = (short)743112704;
			if (num != 0)
			{
			}
			return result;
			IL_4E:
			result = null;
			num = (short)1587806209;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_34;
		}

		// Token: 0x04004BD5 RID: 19413
		private global::AcpBusinessLayer.AcpSimpleRangeField emerWideGeneralChannelDelaysec_A7657;

		// Token: 0x04004BD6 RID: 19414
		private global::AcpBusinessLayer.AcpListField emerWideGeneralEmergencyAlarmRxIndicatorType_A7933;

		// Token: 0x04004BD7 RID: 19415
		private global::AcpBusinessLayer.AcpField<bool> emerWideGeneralEmergencyCallReceive_A7937;

		// Token: 0x04004BD8 RID: 19416
		private global::AcpBusinessLayer.AcpField<bool> emerWideGeneralEmergencyPowerUp_A7942;

		// Token: 0x04004BD9 RID: 19417
		private global::AcpBusinessLayer.AcpField<bool> emerWideGeneralKeepAlive_A8360;

		// Token: 0x04004BDA RID: 19418
		private global::AcpBusinessLayer.AcpField<bool> emerWideGeneralSilentAlarm_A9130;

		// Token: 0x04004BDB RID: 19419
		private global::AcpBusinessLayer.AcpField<bool> emerWideGeneralUnmuteOption_A9598;

		// Token: 0x04004BDC RID: 19420
		private global::AcpBusinessLayer.AcpField<bool> emerWideGeneralSuppressEmergencyCall_A42142;

		// Token: 0x04004BDD RID: 19421
		private global::AcpBusinessLayer.AcpField<bool> emerWideGeneralDistinguishEmergencyType_43546;
	}
}
