using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.ActionConsolidation
{
	// Token: 0x0200041F RID: 1055
	[global::System.Serializable]
	public class ConsolidatedActionsInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600901B RID: 36891 RVA: 0x0087EB24 File Offset: 0x0087CD24
		public ConsolidatedActionsInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600901C RID: 36892 RVA: 0x0087EB40 File Offset: 0x0087CD40
		protected ConsolidatedActionsInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600901D RID: 36893 RVA: 0x0087EB58 File Offset: 0x0087CD58
		public override void Init()
		{
			int a_ = 8;
			short num = (short)139311915;
			short num2 = num;
			num = (short)29735723;
			switch (num2 == num)
			{
			}
			num = (short)1698168833;
			if (num != 0)
			{
			}
			num = (short)988741632;
			short num3 = num;
			num = (short)1023475712;
			if (num != 0)
			{
			}
			this.radioErgoConfigACActionID_A36590 = new global::AcpBusinessLayer.AcpSparseLOVField(75, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.indexRadioErgoConfigACActionID_A36590LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.idRadioErgoConfigACActionID_A36590LovStrs), this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌ꛎ뻐雒꟔냖뛘飚닜뇞蟠諢苤ꛦꫨꫪ軬鯮飰鳲鯴뻶뷸ꓺ볼쳾㜀㘂㰄㜆", a_), global::CommonResources.AcgResources.ID_ACTIONID, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigACActionID_A36590LovStrs);
			this.radioErgoConfigACActionID_A36590.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioErgoConfigACActionID_A36590.DataTransferOrder = 10;
			this.radioErgoConfigACGeneralZone_A36592 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌ꛎ뻐雒꟔냖뛘飚닜뇞蟠諢苤ꛦꫨ곪裬臮铰臲铴鯶ꏸ铺鏼髾帀䈂㘄ㄆ㰈㈊㼌", a_), global::CommonResources.AcgResources.ID_ZONE, new string[]
			{
				global::CommonResources.AcgResources.ID_LASTZONE
			}, new int[1], true, false);
			this.radioErgoConfigACGeneralZone_A36592.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioErgoConfigACGeneralZone_A36592.DataTransferOrder = 12;
			this.radioErgoConfigACGeneralChannel_A36593 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌ꛎ뻐雒꟔냖뛘飚닜뇞蟠諢苤ꛦꫨ곪裬臮铰臲铴鯶뫸鏺鳼釾漀昂椄堆䠈㠊㬌㨎⠐‒", a_), global::CommonResources.AcgResources.ID_CHANNEL, new string[]
			{
				global::CommonResources.AcgResources.ID_LASTCHANNEL
			}, new int[1], true, false);
			this.radioErgoConfigACGeneralChannel_A36593.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioErgoConfigACGeneralChannel_A36593.DataTransferOrder = 13;
			this.radioErgoConfigACGeneralErrStrategy_A36594 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌ꛎ뻐雒꟔냖뛘飚닜뇞蟠諢苤ꛦꫨ곪裬臮铰臲铴鯶본觺迼곾甀焂搄猆氈氊琌倎倐‒⌔∖‘⼚", a_), global::CommonResources.AcgResources.ID_ERRORSTRATEGY, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigACGeneralErrStrategy_A36594LovStrs);
			this.radioErgoConfigACGeneralErrStrategy_A36594.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioErgoConfigACGeneralErrStrategy_A36594.DataTransferOrder = 14;
			this.radioErgoConfigACGeneralIndex_A36591 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌ꛎ뻐雒꟔냖뛘飚닜뇞蟠諢苤ꛦꫨ곪裬臮铰臲铴鯶냸闺駼髾礀専䐄㐆㼈㸊㐌㸎", a_), global::CommonResources.AcgResources.ID_INDEX, 1, 16, null, null, 0, 1);
			this.radioErgoConfigACGeneralIndex_A36591.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioErgoConfigACGeneralIndex_A36591.DataTransferOrder = 11;
			this.radioErgoConfigACGeneralIndex_A36591.ShowHexValue = false;
			this.radioErgoConfigACAlertAudioFile_A42875 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌ꛎ뻐雒꟔냖뛘飚닜뇞蟠諢苤ꛦꫨꫪ臬諮菰蟲듴苶鷸鋺鋼맾栀漂怄堆䠈㼊㼌㜎☐☒", a_), global::CommonResources.AcgResources.ID_ALERTAUDIOFILE, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, false);
			this.radioErgoConfigACAlertAudioFile_A42875.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radioErgoConfigACAlertAudioFile_A42875.DataTransferOrder = 18;
			this.radioErgoConfigACAlertInterval_A42877 = new global::AcpBusinessLayer.AcpCustomRangeField(5, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌ꛎ뻐雒꟔냖뛘飚닜뇞蟠諢苤ꛦꫨꫪ臬諮菰蟲보駶跸黺迼觾怀漂娄䘆㴈㤊㔌㠎☐", a_), global::CommonResources.AcgResources.ID_ALERTINTERVALSEC, 0, 255, 1, global::CommonResources.AcgResources.ID_CONTINUOUS, global::CommonResources.AcgResources.ID_MOMENTARY);
			this.radioErgoConfigACAlertInterval_A42877.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radioErgoConfigACAlertInterval_A42877.DataTransferOrder = 15;
			this.radioErgoConfigACAlertInterval_A42877.ShowHexValue = false;
			this.radioErgoConfigACGeneralTEXTMESSAGE_42913 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_TEXTMESSAGE1, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌ꛎ뻐雒꟔냖뛘飚닜뇞蟠諢苤ꛦꫨ곪裬臮铰臲铴鯶그뻺ꗼ꯾䰀䘂嘄吆䠈䰊䠌倎┐ℒⰔ☖⨘", a_), global::CommonResources.AcgResources.ID_TEXTMESSAGE, 40);
			this.radioErgoConfigACGeneralTEXTMESSAGE_42913.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioErgoConfigACGeneralTEXTMESSAGE_42913.DataTransferOrder = 32;
			this.radioErgoConfigACGeneralTxPowerChange__42916 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌ꛎ뻐雒꟔냖뛘飚닜뇞蟠諢苤ꛦꫨ곪裬臮铰臲铴鯶그菺근郾瘀昂眄䐆愈樊挌栎琐䰒䨔⌖⬘√Ⱌ⤞", a_), global::CommonResources.AcgResources.ID_TRANSMITPOWERLEVEL, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigACGeneralTxPowerChange__42916LovStrs);
			this.radioErgoConfigACGeneralTxPowerChange__42916.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioErgoConfigACGeneralTxPowerChange__42916.DataTransferOrder = 35;
			this.radioErgoConfigACGeneralMuteSSA__42917 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌ꛎ뻐雒꟔냖뛘飚닜뇞蟠諢苤ꛦꫨ곪裬臮铰臲铴鯶듸軺觼髾刀倂䐄堆嘈㼊㼌㘎‐␒", a_), global::CommonResources.AcgResources.ID_MUTESITESELECTABLEALERT);
			this.radioErgoConfigACGeneralMuteSSA__42917.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioErgoConfigACGeneralMuteSSA__42917.DataTransferOrder = 36;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諈꓊ꏌ볎뻐뿒볔돖룘꿚룜믞쇠ꋢ蛤鏦胨蓪菬鳮", a_);
			base.Id = 10614;
			base.UIName = global::CommonResources.AcgResources.ID_CONSOLIDATEDACTIONS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600901E RID: 36894 RVA: 0x0087EF08 File Offset: 0x0087D108
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)7012364;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)836894720;
				short num3 = num;
				switch (num2)
				{
				case 0:
					this.radioErgoConfigACGeneralTxPowerChange__42916 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ諎ꏐ듒뫔铖뛘뗚믜뛞蛠ꋢꛤꃦ賨藪裬鷮郰鿲ꇴ迶꧸铺諼髾猀䀂洄昆月氊栌倎丐✒✔⸖⠘ⴚ", a_), global::CommonResources.AcgResources.ID_TRANSMITPOWERLEVEL, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigACGeneralTxPowerChange__42916LovStrs);
					this.radioErgoConfigACGeneralTxPowerChange__42916.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radioErgoConfigACGeneralTxPowerChange__42916.DataTransferOrder = 35;
					num = (short)1148715041;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_2E3;
				case 2:
					goto IL_745;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ諎ꏐ듒뫔铖뛘뗚믜뛞蛠ꋢꛤꃦ賨藪裬鷮郰鿲룴苶跸黺껼곾䀀専娄㌆㬈㈊㰌㠎", a_)))
					{
						num = (short)2011365400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_898;
				case 4:
					this.radioErgoConfigACActionID_A36590 = new global::AcpBusinessLayer.AcpSparseLOVField(75, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.indexRadioErgoConfigACActionID_A36590LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.idRadioErgoConfigACActionID_A36590LovStrs), this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ諎ꏐ듒뫔铖뛘뗚믜뛞蛠ꋢꛤꛦ諨鿪蓬胮鿰뫲뇴ꣶ룸죺쯼쫾㠀㌂", a_), global::CommonResources.AcgResources.ID_ACTIONID, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigACActionID_A36590LovStrs);
					this.radioErgoConfigACActionID_A36590.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radioErgoConfigACActionID_A36590.DataTransferOrder = 10;
					num = (short)1698824211;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.radioErgoConfigACGeneralIndex_A36591 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ諎ꏐ듒뫔铖뛘뗚믜뛞蛠ꋢꛤꃦ賨藪裬鷮郰鿲보駶鷸黺藼ꃾ䀀。㌄㈆〈㨊", a_), global::CommonResources.AcgResources.ID_INDEX, null, null, 0, 1);
					this.radioErgoConfigACGeneralIndex_A36591.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radioErgoConfigACGeneralIndex_A36591.DataTransferOrder = 11;
					this.radioErgoConfigACGeneralIndex_A36591.ShowHexValue = false;
					num = (short)1594884124;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ諎ꏐ듒뫔铖뛘뗚믜뛞蛠ꋢꛤꃦ賨藪裬鷮郰鿲ꇴ닶ꇸ꿺냼뫾刀倂䐄䀆䰈吊㤌㴎⠐−☔", a_)))
					{
						num = (short)1296629775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22B;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ諎ꏐ듒뫔铖뛘뗚믜뛞蛠ꋢꛤꛦ諨鿪蓬胮鿰뫲뇴ꣶ룸죺쯼쫾㠀㌂", a_)))
					{
						goto IL_811;
					}
					goto IL_5D8;
				case 8:
					this.radioErgoConfigACAlertInterval_A42877 = new global::AcpBusinessLayer.AcpCustomRangeField(5, this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ諎ꏐ듒뫔铖뛘뗚믜뛞蛠ꋢꛤꛦ藨軪鿬鯮룰鷲致鋶诸跺鳼鏾帀䈂㄄㔆ㄈ㰊㨌", a_), global::CommonResources.AcgResources.ID_ALERTINTERVALSEC, global::CommonResources.AcgResources.ID_CONTINUOUS, global::CommonResources.AcgResources.ID_MOMENTARY);
					this.radioErgoConfigACAlertInterval_A42877.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radioErgoConfigACAlertInterval_A42877.DataTransferOrder = 15;
					this.radioErgoConfigACAlertInterval_A42877.ShowHexValue = false;
					num = (short)1191772161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_792;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ諎ꏐ듒뫔铖뛘뗚믜뛞蛠ꋢꛤꃦ賨藪裬鷮郰鿲꿴飶韸黺ꋼ뻾㈀㔂〄㸆㬈", a_)))
					{
						num = (short)1854275610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_42C;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ諎ꏐ듒뫔铖뛘뗚믜뛞蛠ꋢꛤꃦ賨藪裬鷮郰鿲ꇴ迶꧸铺諼髾猀䀂洄昆月氊栌倎丐✒✔⸖⠘ⴚ", a_)))
					{
						num = (short)470286336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_379;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_DF;
					}
					continue;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ諎ꏐ듒뫔铖뛘뗚믜뛞蛠ꋢꛤꃦ賨藪裬鷮郰鿲뛴鿶飸闺鏼髾洀専䐄㐆㼈㸊㐌㰎", a_)))
					{
						num = (short)536346646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_529;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ諎ꏐ듒뫔铖뛘뗚믜뛞蛠ꋢꛤꃦ賨藪裬鷮郰鿲보駶鷸黺藼ꃾ䀀。㌄㈆〈㨊", a_)))
					{
						num = (short)1765408773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_172;
				case 15:
				{
					num = (short)590572837;
					short num4 = num;
					num = (short)934505765;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_811;
					default:
						num = (short)2116878336;
						if (num != 0)
						{
						}
						this.radioErgoConfigACGeneralTEXTMESSAGE_42913 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_TEXTMESSAGE1, this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ諎ꏐ듒뫔铖뛘뗚믜뛞蛠ꋢꛤꃦ賨藪裬鷮郰鿲ꇴ닶ꇸ꿺냼뫾刀倂䐄䀆䰈吊㤌㴎⠐−☔", a_), global::CommonResources.AcgResources.ID_TEXTMESSAGE, 40);
						this.radioErgoConfigACGeneralTEXTMESSAGE_42913.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.radioErgoConfigACGeneralTEXTMESSAGE_42913.DataTransferOrder = 32;
						num = (short)1261764625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 16:
					if (producerFields != null)
					{
						num = (short)1369964565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_898;
				case 17:
					goto IL_22B;
				case 18:
					this.radioErgoConfigACAlertAudioFile_A42875 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ諎ꏐ듒뫔铖뛘뗚믜뛞蛠ꋢꛤꛦ藨軪鿬鯮냰蛲釴黶雸뷺铼鏾搀専䐄㌆㬈㌊㨌㨎", a_), global::CommonResources.AcgResources.ID_ALERTAUDIOFILE, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE
					}, new int[1], true, false);
					this.radioErgoConfigACAlertAudioFile_A42875.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radioErgoConfigACAlertAudioFile_A42875.DataTransferOrder = 18;
					num = (short)1687355394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					goto IL_5D8;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ諎ꏐ듒뫔铖뛘뗚믜뛞蛠ꋢꛤꛦ藨軪鿬鯮냰蛲釴黶雸뷺铼鏾搀専䐄㌆㬈㌊㨌㨎", a_)))
					{
						num = (short)694616082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_745;
				case 21:
					num = (short)1058668551;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					this.radioErgoConfigACGeneralChannel_A36593 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ諎ꏐ듒뫔铖뛘뗚믜뛞蛠ꋢꛤꃦ賨藪裬鷮郰鿲뛴鿶飸闺鏼髾洀専䐄㐆㼈㸊㐌㰎", a_), global::CommonResources.AcgResources.ID_CHANNEL, new string[]
					{
						global::CommonResources.AcgResources.ID_LASTCHANNEL
					}, new int[1], true, false);
					this.radioErgoConfigACGeneralChannel_A36593.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radioErgoConfigACGeneralChannel_A36593.DataTransferOrder = 13;
					num = (short)1263534107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					num = (short)930611216;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					this.radioErgoConfigACGeneralMuteSSA__42917 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ諎ꏐ듒뫔铖뛘뗚믜뛞蛠ꋢꛤꃦ賨藪裬鷮郰鿲룴苶跸黺껼곾䀀専娄㌆㬈㈊㰌㠎", a_), global::CommonResources.AcgResources.ID_MUTESITESELECTABLEALERT);
					this.radioErgoConfigACGeneralMuteSSA__42917.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radioErgoConfigACGeneralMuteSSA__42917.DataTransferOrder = 36;
					num = (short)39452701;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ諎ꏐ듒뫔铖뛘뗚믜뛞蛠ꋢꛤꃦ賨藪裬鷮郰鿲냴藶诸꣺觼跾怀眂怄怆瀈吊䰌㰎✐☒Ⱄ⌖", a_)))
					{
						num = (short)1680932894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_792;
				case 26:
					this.radioErgoConfigACGeneralZone_A36592 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ諎ꏐ듒뫔铖뛘뗚믜뛞蛠ꋢꛤꃦ賨藪裬鷮郰鿲꿴飶韸黺ꋼ뻾㈀㔂〄㸆㬈", a_), global::CommonResources.AcgResources.ID_ZONE, new string[]
					{
						global::CommonResources.AcgResources.ID_LASTZONE
					}, new int[1], true, false);
					this.radioErgoConfigACGeneralZone_A36592.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radioErgoConfigACGeneralZone_A36592.DataTransferOrder = 12;
					num = (short)289407008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					goto IL_529;
				case 28:
					goto IL_172;
				case 29:
					goto IL_524;
				case 30:
					num = (short)225837057;
					if (num != 0)
					{
					}
					this.radioErgoConfigACGeneralErrStrategy_A36594 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ諎ꏐ듒뫔铖뛘뗚믜뛞蛠ꋢꛤꃦ賨藪裬鷮郰鿲냴藶诸꣺觼跾怀眂怄怆瀈吊䰌㰎✐☒Ⱄ⌖", a_), global::CommonResources.AcgResources.ID_ERRORSTRATEGY, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigACGeneralErrStrategy_A36594LovStrs);
					this.radioErgoConfigACGeneralErrStrategy_A36594.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radioErgoConfigACGeneralErrStrategy_A36594.DataTransferOrder = 14;
					num = (short)1435828233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ諎ꏐ듒뫔铖뛘뗚믜뛞蛠ꋢꛤꛦ藨軪鿬鯮룰鷲致鋶诸跺鳼鏾帀䈂㄄㔆ㄈ㰊㨌", a_)))
					{
						num = (short)577634312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E3;
				case 32:
					goto IL_42C;
				case 33:
					goto IL_379;
				}
				IL_DF:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)20447255;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_172:
				num = (short)1840840724;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_22B:
				num = (short)1141964811;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E3:
				num = (short)636682246;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_379:
				num = (short)1649803267;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_42C:
				num = (short)1006305293;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_529:
				num = (short)2068054041;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5D8:
				num = (short)1242759178;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_745:
				num = (short)530317343;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_792:
				num = (short)532742158;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_811:
				num = (short)51511300;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_524:
			IL_898:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛄꣆ꟈ룊ꋌꏎ룐럒듔ꏖ볘뿚﷜點苠韢賤裦蟨飪", a_);
			base.Id = 10614;
			base.UIName = global::CommonResources.AcgResources.ID_CONSOLIDATEDACTIONS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600901F RID: 36895 RVA: 0x0087F7E0 File Offset: 0x0087D9E0
		public override void PopulateReferences()
		{
			short num = (short)1076350402;
			short num2 = num;
			num = (short)1955057090;
			switch (num2 == num)
			{
			}
			num = (short)510394369;
			if (num != 0)
			{
			}
			num = (short)463011840;
			short num3 = num;
			num = (short)240451584;
			if (num != 0)
			{
			}
			this.radioErgoConfigACGeneralZone_A36592.SetRecset(this.a(2051));
			this.radioErgoConfigACAlertAudioFile_A42875.SetRecset(this.a(2300));
			this.radioErgoConfigACGeneralZone_A36592.AddSlaveField(this.radioErgoConfigACGeneralChannel_A36593, 10114);
		}

		// Token: 0x06009020 RID: 36896 RVA: 0x0087F8CC File Offset: 0x0087DACC
		public override void DropReferences()
		{
			short num = (short)639219144;
			short num2 = num;
			num = (short)1728820680;
			switch (num2 == num)
			{
			}
			num = (short)259391488;
			if (num != 0)
			{
			}
			num = (short)1115750400;
			short num3 = num;
			num = (short)725811201;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009021 RID: 36897 RVA: 0x0087F974 File Offset: 0x0087DB74
		public override void SetConstraints()
		{
			short num = (short)908154002;
			short num2 = num;
			num = (short)72504466;
			switch (num2 == num)
			{
			default:
			{
				num = (short)711458816;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1793064961;
			if (num != 0)
			{
			}
			num = (short)8126464;
			if (num != 0)
			{
			}
			this.radioErgoConfigACActionID_A36590.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConModeAndGPSCannotBothBeConfigured);
			this.radioErgoConfigACActionID_A36590.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConValueSetActionAllowedOnResponseSelector);
			this.radioErgoConfigACGeneralZone_A36592.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConZoneApplicable);
			this.radioErgoConfigACGeneralZone_A36592.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConZoneReferencedIsNormalOrDynamicOneBased);
			this.radioErgoConfigACGeneralZone_A36592.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsGeneralOrControlOrInvalidSim);
			this.radioErgoConfigACGeneralChannel_A36593.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConChannelApplicable);
			this.radioErgoConfigACGeneralChannel_A36593.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConChannelValidity);
			this.radioErgoConfigACGeneralChannel_A36593.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsGeneralOrControlOrInvalidSim);
			this.radioErgoConfigACGeneralIndex_A36591.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConStsXIndexApplicable);
			this.radioErgoConfigACGeneralIndex_A36591.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsGeneralOrExitOrControlOrInvalidSim);
			this.radioErgoConfigACAlertAudioFile_A42875.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConAlertAliasAudioFileIntervalApplicable);
			this.radioErgoConfigACAlertInterval_A42877.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConAlertAliasAudioFileIntervalApplicable);
			this.radioErgoConfigACAlertInterval_A42877.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConCAAlertIntervalIsValid);
			this.radioErgoConfigACAlertInterval_A42877.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsNotExit);
			this.radioErgoConfigACGeneralTEXTMESSAGE_42913.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConTextMsgApplicable);
			this.radioErgoConfigACGeneralTEXTMESSAGE_42913.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsGeneralOrExit);
			this.radioErgoConfigACGeneralTxPowerChange__42916.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConTxPowerChangeApplicable);
			this.radioErgoConfigACGeneralTxPowerChange__42916.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsGeneral);
			this.radioErgoConfigACGeneralMuteSSA__42917.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConMuteSSAApplicable);
			this.radioErgoConfigACGeneralMuteSSA__42917.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsGeneral);
			this.RadioErgoConfigACGeneralErrStrategy_A36594.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConErrStrategyValid);
		}

		// Token: 0x06009022 RID: 36898 RVA: 0x0087FC00 File Offset: 0x0087DE00
		public override void SetupDependencies()
		{
			short num = (short)1028890877;
			short num2 = num;
			num = (short)1554424061;
			switch (num2 == num)
			{
			default:
			{
				num = (short)709689344;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)743571456;
			if (num != 0)
			{
			}
			num = (short)1832976385;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation;
			actionConsolidation.General.RadioErgoConfigACGeneralActionAllowed_A36579.AddDependentObject(this.radioErgoConfigACActionID_A36590);
			actionConsolidation.General.RadioErgoConfigACGpsReport_A36587.AddDependentObject(this.radioErgoConfigACActionID_A36590);
			actionConsolidation.General.RadioErgoConfigACActionType_A42871.AddDependentObject(this.radioErgoConfigACActionID_A36590);
			this.radioErgoConfigACActionID_A36590.AddDependentObject(this.radioErgoConfigACGeneralZone_A36592);
			this.radioErgoConfigACActionID_A36590.AddDependentObject(this.radioErgoConfigACGeneralChannel_A36593);
			this.radioErgoConfigACGeneralZone_A36592.AddDependentObject(this.radioErgoConfigACGeneralChannel_A36593);
			this.radioErgoConfigACActionID_A36590.AddDependentObject(this.radioErgoConfigACGeneralIndex_A36591);
			this.radioErgoConfigACActionID_A36590.AddDependentObject(this.radioErgoConfigACAlertAudioFile_A42875);
			this.radioErgoConfigACActionID_A36590.AddDependentObject(this.radioErgoConfigACAlertInterval_A42877);
			this.radioErgoConfigACActionID_A36590.AddDependentObject(this.radioErgoConfigACGeneralTEXTMESSAGE_42913);
			this.radioErgoConfigACActionID_A36590.AddDependentObject(this.radioErgoConfigACGeneralTxPowerChange__42916);
			this.radioErgoConfigACActionID_A36590.AddDependentObject(this.radioErgoConfigACGeneralMuteSSA__42917);
			this.radioErgoConfigACActionID_A36590.AddDependentObject((base.ParentRecset.ParentSection.Parent[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACGpsReport_A36587);
		}

		// Token: 0x170048B3 RID: 18611
		// (get) Token: 0x06009023 RID: 36899 RVA: 0x0087FDD8 File Offset: 0x0087DFD8
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment ZoneChannelAssignmentForRadioErgoConfigACGeneralZone_A36592
		{
			get
			{
				short num = (short)1045757953;
				if (num != 0)
				{
				}
				num = (short)1526661120;
				short num2 = num;
				num = (short)1853338518;
				short num3 = num;
				num = (short)1684059030;
				switch (num3 == num)
				{
				}
				num = (short)1345650688;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralZone_A36592.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
			}
		}

		// Token: 0x170048B4 RID: 18612
		// (get) Token: 0x06009024 RID: 36900 RVA: 0x0087FE94 File Offset: 0x0087E094
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner ChannelAssignmentListInnerSectionForRadioErgoConfigACGeneralChannel_A36593
		{
			get
			{
				short num = (short)1837814893;
				short num2 = num;
				num = (short)9819245;
				switch (num2 == num)
				{
				default:
				{
					num = (short)738918400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)763494401;
				if (num != 0)
				{
				}
				num = (short)1702363136;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralChannel_A36593.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
			}
		}

		// Token: 0x170048B5 RID: 18613
		// (get) Token: 0x06009025 RID: 36901 RVA: 0x0087FF4C File Offset: 0x0087E14C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1776588362;
				short num2 = num;
				num = (short)323720778;
				switch (num2 == num)
				{
				default:
				{
					num = (short)629997568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1901199360;
				if (num != 0)
				{
				}
				num = (short)848166913;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170048B6 RID: 18614
		// (get) Token: 0x06009026 RID: 36902 RVA: 0x0087FFF8 File Offset: 0x0087E1F8
		// (set) Token: 0x06009027 RID: 36903 RVA: 0x008800AC File Offset: 0x0087E2AC
		public int RadioErgoConfigACActionID_A36590Value
		{
			get
			{
				short num = (short)1838153729;
				if (num != 0)
				{
				}
				num = (short)2125004800;
				short num2 = num;
				num = (short)227765166;
				short num3 = num;
				num = (short)178351022;
				switch (num3 == num)
				{
				}
				num = (short)1196032000;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACActionID_A36590.Value;
			}
			set
			{
				short num = (short)2049355184;
				short num2 = num;
				num = (short)1714204080;
				switch (num2 == num)
				{
				default:
				{
					num = (short)722862080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1041367041;
				if (num != 0)
				{
				}
				num = (short)379650048;
				if (num != 0)
				{
				}
				this.radioErgoConfigACActionID_A36590.Value = value;
			}
		}

		// Token: 0x170048B7 RID: 18615
		// (get) Token: 0x06009028 RID: 36904 RVA: 0x00880160 File Offset: 0x0087E360
		// (set) Token: 0x06009029 RID: 36905 RVA: 0x00880218 File Offset: 0x0087E418
		public string RadioErgoConfigACActionID_A36590_UIValue
		{
			get
			{
				short num = (short)289932384;
				short num2 = num;
				num = (short)1759118432;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1489829888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1952055297;
				if (num != 0)
				{
				}
				num = (short)645726208;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACActionID_A36590.UIValue;
			}
			set
			{
				short num = (short)1738150660;
				short num2 = num;
				num = (short)701567748;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1553137664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1148321793;
				if (num != 0)
				{
				}
				num = (short)945356800;
				if (num != 0)
				{
				}
				this.radioErgoConfigACActionID_A36590.UIValue = value;
			}
		}

		// Token: 0x170048B8 RID: 18616
		// (get) Token: 0x0600902A RID: 36906 RVA: 0x008802CC File Offset: 0x0087E4CC
		public global::AcpBusinessLayer.AcpListField RadioErgoConfigACActionID_A36590
		{
			get
			{
				short num = (short)760251625;
				short num2 = num;
				num = (short)975537385;
				switch (num2 == num)
				{
				default:
				{
					num = (short)43581440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)830210049;
				if (num != 0)
				{
				}
				num = (short)1135345664;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACActionID_A36590;
			}
		}

		// Token: 0x170048B9 RID: 18617
		// (get) Token: 0x0600902B RID: 36907 RVA: 0x0088037C File Offset: 0x0087E57C
		// (set) Token: 0x0600902C RID: 36908 RVA: 0x00880430 File Offset: 0x0087E630
		public bool RadioErgoConfigACActionID_A36590_Applicable
		{
			get
			{
				short num = (short)939714047;
				short num2 = num;
				num = (short)769713663;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1917517824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2083913729;
				if (num != 0)
				{
				}
				num = (short)1473839104;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACActionID_A36590.Applicable;
			}
			set
			{
				short num = (short)1115125199;
				short num2 = num;
				num = (short)231634383;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1846738944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1006501889;
				if (num != 0)
				{
				}
				num = (short)266272768;
				if (num != 0)
				{
				}
				this.radioErgoConfigACActionID_A36590.Applicable = value;
			}
		}

		// Token: 0x170048BA RID: 18618
		// (get) Token: 0x0600902D RID: 36909 RVA: 0x008804E8 File Offset: 0x0087E6E8
		// (set) Token: 0x0600902E RID: 36910 RVA: 0x0088059C File Offset: 0x0087E79C
		public bool RadioErgoConfigACActionID_A36590_Valid
		{
			get
			{
				short num = (short)1650341199;
				short num2 = num;
				num = (short)1238512975;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1742405632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2008875009;
				if (num != 0)
				{
				}
				num = (short)536346624;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACActionID_A36590.Valid;
			}
			set
			{
				short num = (short)1489516190;
				short num2 = num;
				num = (short)1260009118;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1973420032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2048458753;
				if (num != 0)
				{
				}
				num = (short)1718419456;
				if (num != 0)
				{
				}
				this.radioErgoConfigACActionID_A36590.Valid = value;
			}
		}

		// Token: 0x170048BB RID: 18619
		// (get) Token: 0x0600902F RID: 36911 RVA: 0x00880654 File Offset: 0x0087E854
		// (set) Token: 0x06009030 RID: 36912 RVA: 0x00880704 File Offset: 0x0087E904
		public bool RadioErgoConfigACActionID_A36590_Visible
		{
			get
			{
				short num = (short)75259903;
				short num2 = num;
				num = (short)1572102143;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1082064896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)234487809;
				if (num != 0)
				{
				}
				num = (short)2097152;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACActionID_A36590.Visible;
			}
			set
			{
				short num = (short)1299677583;
				short num2 = num;
				num = (short)362119567;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1680474112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)516751361;
				if (num != 0)
				{
				}
				num = (short)274071552;
				if (num != 0)
				{
				}
				this.radioErgoConfigACActionID_A36590.Visible = value;
			}
		}

		// Token: 0x170048BC RID: 18620
		// (get) Token: 0x06009031 RID: 36913 RVA: 0x008807BC File Offset: 0x0087E9BC
		// (set) Token: 0x06009032 RID: 36914 RVA: 0x00880870 File Offset: 0x0087EA70
		public bool RadioErgoConfigACActionID_A36590_Editable
		{
			get
			{
				short num = (short)64340997;
				short num2 = num;
				num = (short)392020997;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1725366272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)896663553;
				if (num != 0)
				{
				}
				num = (short)1014628352;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACActionID_A36590.Editable;
			}
			set
			{
				short num = (short)906196760;
				short num2 = num;
				num = (short)1509062424;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1322319872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1052835841;
				if (num != 0)
				{
				}
				num = (short)326303744;
				if (num != 0)
				{
				}
				this.radioErgoConfigACActionID_A36590.Editable = value;
			}
		}

		// Token: 0x170048BD RID: 18621
		// (get) Token: 0x06009033 RID: 36915 RVA: 0x00880924 File Offset: 0x0087EB24
		internal string RadioErgoConfigACActionID_A36590_UILabel
		{
			get
			{
				short num = (short)246774135;
				short num2 = num;
				num = (short)138115447;
				switch (num2 == num)
				{
				default:
				{
					num = (short)928514048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)50921473;
				if (num != 0)
				{
				}
				num = (short)503644160;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACActionID_A36590.UIName;
			}
		}

		// Token: 0x170048BE RID: 18622
		// (get) Token: 0x06009034 RID: 36916 RVA: 0x008809DC File Offset: 0x0087EBDC
		// (set) Token: 0x06009035 RID: 36917 RVA: 0x00880A90 File Offset: 0x0087EC90
		internal bool RadioErgoConfigACActionID_A36590_HiddenStatic
		{
			get
			{
				short num = (short)1476443288;
				short num2 = num;
				num = (short)808303768;
				switch (num2 == num)
				{
				default:
				{
					num = (short)317980672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)81920000;
				if (num != 0)
				{
				}
				num = (short)1374224385;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACActionID_A36590.HiddenStatic;
			}
			set
			{
				short num = (short)1740694796;
				short num2 = num;
				num = (short)1559880972;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1729626112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)81002497;
				if (num != 0)
				{
				}
				num = (short)540672000;
				if (num != 0)
				{
				}
				this.radioErgoConfigACActionID_A36590.HiddenStatic = value;
			}
		}

		// Token: 0x170048BF RID: 18623
		// (get) Token: 0x06009036 RID: 36918 RVA: 0x00880B44 File Offset: 0x0087ED44
		// (set) Token: 0x06009037 RID: 36919 RVA: 0x00880BF8 File Offset: 0x0087EDF8
		internal bool RadioErgoConfigACActionID_A36590_HiddenDynamic
		{
			get
			{
				short num = (short)294375441;
				short num2 = num;
				num = (short)1103351825;
				switch (num2 == num)
				{
				default:
				{
					num = (short)226951168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1440612352;
				if (num != 0)
				{
				}
				num = (short)1466171393;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACActionID_A36590.HiddenDynamic;
			}
			set
			{
				short num = (short)1621419557;
				short num2 = num;
				num = (short)1166796325;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1106247680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)223674368;
				if (num != 0)
				{
				}
				num = (short)1710489601;
				if (num != 0)
				{
				}
				this.radioErgoConfigACActionID_A36590.HiddenDynamic = value;
			}
		}

		// Token: 0x170048C0 RID: 18624
		// (get) Token: 0x06009038 RID: 36920 RVA: 0x00880CAC File Offset: 0x0087EEAC
		public bool RadioErgoConfigACActionID_A36590_HasDiffs
		{
			get
			{
				short num = (short)698175692;
				short num2 = num;
				num = (short)158355660;
				switch (num2 == num)
				{
				default:
				{
					num = (short)205783040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1225261056;
				if (num != 0)
				{
				}
				num = (short)1500839937;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACActionID_A36590._HasDiffs;
			}
		}

		// Token: 0x170048C1 RID: 18625
		// (get) Token: 0x06009039 RID: 36921 RVA: 0x00880D60 File Offset: 0x0087EF60
		// (set) Token: 0x0600903A RID: 36922 RVA: 0x00880E18 File Offset: 0x0087F018
		public int RadioErgoConfigACGeneralZone_A36592Value
		{
			get
			{
				short num = (short)1700103478;
				short num2 = num;
				num = (short)250971446;
				switch (num2 == num)
				{
				default:
				{
					num = (short)944242688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1892941825;
				if (num != 0)
				{
				}
				num = (short)1037697024;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralZone_A36592.Value;
			}
			set
			{
				short num = (short)1803550188;
				short num2 = num;
				num = (short)1650327020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)203948032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1095499777;
				if (num != 0)
				{
				}
				num = (short)1239547904;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralZone_A36592.Value = value;
			}
		}

		// Token: 0x170048C2 RID: 18626
		// (get) Token: 0x0600903B RID: 36923 RVA: 0x00880ECC File Offset: 0x0087F0CC
		// (set) Token: 0x0600903C RID: 36924 RVA: 0x00880F80 File Offset: 0x0087F180
		public string RadioErgoConfigACGeneralZone_A36592_UIValue
		{
			get
			{
				short num = (short)1805806714;
				short num2 = num;
				num = (short)2032430202;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1781792768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1017774081;
				if (num != 0)
				{
				}
				num = (short)1025048576;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralZone_A36592.UIValue;
			}
			set
			{
				short num = (short)1020664892;
				short num2 = num;
				num = (short)1895439420;
				switch (num2 == num)
				{
				default:
				{
					num = (short)610009088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)10485761;
				if (num != 0)
				{
				}
				num = (short)1179648000;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralZone_A36592.UIValue = value;
			}
		}

		// Token: 0x170048C3 RID: 18627
		// (get) Token: 0x0600903D RID: 36925 RVA: 0x00881034 File Offset: 0x0087F234
		public global::AcpBusinessLayer.AcpRecRefField RadioErgoConfigACGeneralZone_A36592
		{
			get
			{
				short num = (short)2083352272;
				short num2 = num;
				num = (short)1176596176;
				switch (num2 == num)
				{
				default:
				{
					num = (short)925040640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2115829761;
				if (num != 0)
				{
				}
				num = (short)501874688;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralZone_A36592;
			}
		}

		// Token: 0x170048C4 RID: 18628
		// (get) Token: 0x0600903E RID: 36926 RVA: 0x008810E4 File Offset: 0x0087F2E4
		// (set) Token: 0x0600903F RID: 36927 RVA: 0x00881198 File Offset: 0x0087F398
		public bool RadioErgoConfigACGeneralZone_A36592_Applicable
		{
			get
			{
				short num = (short)1915740180;
				short num2 = num;
				num = (short)1602740244;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2119499776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2132672512;
				if (num != 0)
				{
				}
				num = (short)1809645569;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralZone_A36592.Applicable;
			}
			set
			{
				short num = (short)2123944373;
				short num2 = num;
				num = (short)1972490677;
				switch (num2 == num)
				{
				default:
				{
					num = (short)258408448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1439236097;
				if (num != 0)
				{
				}
				num = (short)1675886592;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralZone_A36592.Applicable = value;
			}
		}

		// Token: 0x170048C5 RID: 18629
		// (get) Token: 0x06009040 RID: 36928 RVA: 0x0088124C File Offset: 0x0087F44C
		// (set) Token: 0x06009041 RID: 36929 RVA: 0x00881300 File Offset: 0x0087F500
		public bool RadioErgoConfigACGeneralZone_A36592_Valid
		{
			get
			{
				short num = (short)411500545;
				if (num != 0)
				{
				}
				num = (short)1182072832;
				short num2 = num;
				num = (short)1397865431;
				short num3 = num;
				num = (short)19381207;
				switch (num3 == num)
				{
				}
				num = (short)645726208;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralZone_A36592.Valid;
			}
			set
			{
				short num = (short)1842070162;
				short num2 = num;
				num = (short)647676562;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1519976448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1775304705;
				if (num != 0)
				{
				}
				num = (short)687079424;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralZone_A36592.Valid = value;
			}
		}

		// Token: 0x170048C6 RID: 18630
		// (get) Token: 0x06009042 RID: 36930 RVA: 0x008813B8 File Offset: 0x0087F5B8
		// (set) Token: 0x06009043 RID: 36931 RVA: 0x0088146C File Offset: 0x0087F66C
		public bool RadioErgoConfigACGeneralZone_A36592_Visible
		{
			get
			{
				short num = (short)1297678337;
				if (num != 0)
				{
				}
				num = (short)1659961344;
				short num2 = num;
				num = (short)296738619;
				short num3 = num;
				num = (short)1557389115;
				switch (num3 == num)
				{
				}
				num = (short)1232470016;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralZone_A36592.Visible;
			}
			set
			{
				short num = (short)1881892264;
				short num2 = num;
				num = (short)1945527720;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1291911168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1526988801;
				if (num != 0)
				{
				}
				num = (short)1603600384;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralZone_A36592.Visible = value;
			}
		}

		// Token: 0x170048C7 RID: 18631
		// (get) Token: 0x06009044 RID: 36932 RVA: 0x00881524 File Offset: 0x0087F724
		// (set) Token: 0x06009045 RID: 36933 RVA: 0x008815D8 File Offset: 0x0087F7D8
		public bool RadioErgoConfigACGeneralZone_A36592_Editable
		{
			get
			{
				short num = (short)1866040301;
				short num2 = num;
				num = (short)758154221;
				switch (num2 == num)
				{
				default:
				{
					num = (short)6160384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1318977537;
				if (num != 0)
				{
				}
				num = (short)163512320;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralZone_A36592.Editable;
			}
			set
			{
				short num = (short)212141954;
				short num2 = num;
				num = (short)528680834;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1021771776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)648151041;
				if (num != 0)
				{
				}
				num = (short)651821056;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralZone_A36592.Editable = value;
			}
		}

		// Token: 0x170048C8 RID: 18632
		// (get) Token: 0x06009046 RID: 36934 RVA: 0x0088168C File Offset: 0x0087F88C
		internal string RadioErgoConfigACGeneralZone_A36592_UILabel
		{
			get
			{
				short num = (short)6356993;
				if (num != 0)
				{
				}
				num = (short)2143748096;
				short num2 = num;
				num = (short)352786042;
				short num3 = num;
				num = (short)938219130;
				switch (num3 == num)
				{
				}
				num = (short)27131904;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralZone_A36592.UIName;
			}
		}

		// Token: 0x170048C9 RID: 18633
		// (get) Token: 0x06009047 RID: 36935 RVA: 0x00881744 File Offset: 0x0087F944
		// (set) Token: 0x06009048 RID: 36936 RVA: 0x008817F8 File Offset: 0x0087F9F8
		internal bool RadioErgoConfigACGeneralZone_A36592_HiddenStatic
		{
			get
			{
				short num = (short)837079403;
				short num2 = num;
				num = (short)131453291;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1168637952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)366411776;
				if (num != 0)
				{
				}
				num = (short)1950023681;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralZone_A36592.HiddenStatic;
			}
			set
			{
				short num = (short)839397473;
				short num2 = num;
				num = (short)426520673;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1298268160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1246429185;
				if (num != 0)
				{
				}
				num = (short)1735589888;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralZone_A36592.HiddenStatic = value;
			}
		}

		// Token: 0x170048CA RID: 18634
		// (get) Token: 0x06009049 RID: 36937 RVA: 0x008818B0 File Offset: 0x0087FAB0
		// (set) Token: 0x0600904A RID: 36938 RVA: 0x00881964 File Offset: 0x0087FB64
		internal bool RadioErgoConfigACGeneralZone_A36592_HiddenDynamic
		{
			get
			{
				short num = (short)148235494;
				short num2 = num;
				num = (short)470607078;
				switch (num2 == num)
				{
				default:
				{
					num = (short)86835200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1710882816;
				if (num != 0)
				{
				}
				num = (short)1905852417;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralZone_A36592.HiddenDynamic;
			}
			set
			{
				short num = (short)2068557732;
				short num2 = num;
				num = (short)1328328612;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1230307328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)855244801;
				if (num != 0)
				{
				}
				num = (short)871956480;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralZone_A36592.HiddenDynamic = value;
			}
		}

		// Token: 0x170048CB RID: 18635
		// (get) Token: 0x0600904B RID: 36939 RVA: 0x00881A1C File Offset: 0x0087FC1C
		public bool RadioErgoConfigACGeneralZone_A36592_HasDiffs
		{
			get
			{
				short num = (short)901722264;
				short num2 = num;
				num = (short)728576152;
				switch (num2 == num)
				{
				default:
				{
					num = (short)754778112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)611385345;
				if (num != 0)
				{
				}
				num = (short)364249088;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralZone_A36592._HasDiffs;
			}
		}

		// Token: 0x170048CC RID: 18636
		// (get) Token: 0x0600904C RID: 36940 RVA: 0x00881AD0 File Offset: 0x0087FCD0
		// (set) Token: 0x0600904D RID: 36941 RVA: 0x00881B84 File Offset: 0x0087FD84
		public int RadioErgoConfigACGeneralChannel_A36593Value
		{
			get
			{
				short num = (short)1637611166;
				short num2 = num;
				num = (short)702281374;
				switch (num2 == num)
				{
				default:
				{
					num = (short)38010880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)21626881;
				if (num != 0)
				{
				}
				num = (short)1164115968;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralChannel_A36593.Value;
			}
			set
			{
				short num = (short)37646598;
				short num2 = num;
				num = (short)514093318;
				switch (num2 == num)
				{
				default:
				{
					num = (short)300810240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)156237824;
				if (num != 0)
				{
				}
				num = (short)1867710465;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralChannel_A36593.Value = value;
			}
		}

		// Token: 0x170048CD RID: 18637
		// (get) Token: 0x0600904E RID: 36942 RVA: 0x00881C38 File Offset: 0x0087FE38
		// (set) Token: 0x0600904F RID: 36943 RVA: 0x00881CEC File Offset: 0x0087FEEC
		public string RadioErgoConfigACGeneralChannel_A36593_UIValue
		{
			get
			{
				short num = (short)850297667;
				short num2 = num;
				num = (short)484082499;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1041563648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)794165249;
				if (num != 0)
				{
				}
				num = (short)2022178816;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralChannel_A36593.UIValue;
			}
			set
			{
				short num = (short)332207896;
				short num2 = num;
				num = (short)1009129240;
				switch (num2 == num)
				{
				}
				num = (short)151977984;
				if (num != 0)
				{
				}
				num = (short)183042049;
				if (num != 0)
				{
				}
				num = (short)204406784;
				short num3 = num;
				this.radioErgoConfigACGeneralChannel_A36593.UIValue = value;
			}
		}

		// Token: 0x170048CE RID: 18638
		// (get) Token: 0x06009050 RID: 36944 RVA: 0x00881DA4 File Offset: 0x0087FFA4
		public global::AcpBusinessLayer.AcpRecRefField RadioErgoConfigACGeneralChannel_A36593
		{
			get
			{
				short num = (short)362534506;
				short num2 = num;
				num = (short)2068764266;
				switch (num2 == num)
				{
				}
				num = (short)1593769985;
				if (num != 0)
				{
				}
				num = (short)469696512;
				if (num != 0)
				{
				}
				num = (short)1019281408;
				short num3 = num;
				return this.radioErgoConfigACGeneralChannel_A36593;
			}
		}

		// Token: 0x170048CF RID: 18639
		// (get) Token: 0x06009051 RID: 36945 RVA: 0x00881E50 File Offset: 0x00880050
		// (set) Token: 0x06009052 RID: 36946 RVA: 0x00881F04 File Offset: 0x00880104
		public bool RadioErgoConfigACGeneralChannel_A36593_Applicable
		{
			get
			{
				short num = (short)353440614;
				short num2 = num;
				num = (short)928781158;
				switch (num2 == num)
				{
				}
				num = (short)1158283264;
				if (num != 0)
				{
				}
				num = (short)936181761;
				if (num != 0)
				{
				}
				num = (short)2145714176;
				short num3 = num;
				return this.radioErgoConfigACGeneralChannel_A36593.Applicable;
			}
			set
			{
				short num = (short)685899777;
				if (num != 0)
				{
				}
				num = (short)1106692566;
				short num2 = num;
				num = (short)1953286614;
				switch (num2 == num)
				{
				}
				num = (short)1634729984;
				if (num != 0)
				{
				}
				num = (short)1072496640;
				short num3 = num;
				this.radioErgoConfigACGeneralChannel_A36593.Applicable = value;
			}
		}

		// Token: 0x170048D0 RID: 18640
		// (get) Token: 0x06009053 RID: 36947 RVA: 0x00881FBC File Offset: 0x008801BC
		// (set) Token: 0x06009054 RID: 36948 RVA: 0x00882070 File Offset: 0x00880270
		public bool RadioErgoConfigACGeneralChannel_A36593_Valid
		{
			get
			{
				short num = (short)330860013;
				short num2 = num;
				num = (short)1139115501;
				switch (num2 == num)
				{
				}
				num = (short)46202881;
				if (num != 0)
				{
				}
				num = (short)2066612224;
				if (num != 0)
				{
				}
				num = (short)49414144;
				short num3 = num;
				return this.radioErgoConfigACGeneralChannel_A36593.Valid;
			}
			set
			{
				short num = (short)296895506;
				short num2 = num;
				num = (short)1472021522;
				switch (num2 == num)
				{
				}
				num = (short)173867009;
				if (num != 0)
				{
				}
				num = (short)93323264;
				if (num != 0)
				{
				}
				num = (short)417988608;
				short num3 = num;
				this.radioErgoConfigACGeneralChannel_A36593.Valid = value;
			}
		}

		// Token: 0x170048D1 RID: 18641
		// (get) Token: 0x06009055 RID: 36949 RVA: 0x00882128 File Offset: 0x00880328
		// (set) Token: 0x06009056 RID: 36950 RVA: 0x008821DC File Offset: 0x008803DC
		public bool RadioErgoConfigACGeneralChannel_A36593_Visible
		{
			get
			{
				short num = (short)2004484097;
				if (num != 0)
				{
				}
				num = (short)201388974;
				short num2 = num;
				num = (short)1104540590;
				switch (num2 == num)
				{
				}
				num = (short)585826304;
				if (num != 0)
				{
				}
				num = (short)1076756480;
				short num3 = num;
				return this.radioErgoConfigACGeneralChannel_A36593.Visible;
			}
			set
			{
				short num = (short)1552486698;
				short num2 = num;
				num = (short)1976963370;
				switch (num2 == num)
				{
				}
				num = (short)536477696;
				if (num != 0)
				{
				}
				num = (short)746127361;
				if (num != 0)
				{
				}
				num = (short)290193408;
				short num3 = num;
				this.radioErgoConfigACGeneralChannel_A36593.Visible = value;
			}
		}

		// Token: 0x170048D2 RID: 18642
		// (get) Token: 0x06009057 RID: 36951 RVA: 0x00882294 File Offset: 0x00880494
		// (set) Token: 0x06009058 RID: 36952 RVA: 0x00882348 File Offset: 0x00880548
		public bool RadioErgoConfigACGeneralChannel_A36593_Editable
		{
			get
			{
				short num = (short)927781051;
				short num2 = num;
				num = (short)665637051;
				switch (num2 == num)
				{
				}
				num = (short)1388773377;
				if (num != 0)
				{
				}
				num = (short)1109393408;
				if (num != 0)
				{
				}
				num = (short)451280896;
				short num3 = num;
				return this.radioErgoConfigACGeneralChannel_A36593.Editable;
			}
			set
			{
				short num = (short)1583514752;
				short num2 = num;
				num = (short)897025152;
				switch (num2 == num)
				{
				}
				num = (short)1035862017;
				if (num != 0)
				{
				}
				num = (short)1291845632;
				if (num != 0)
				{
				}
				num = (short)789708800;
				short num3 = num;
				this.radioErgoConfigACGeneralChannel_A36593.Editable = value;
			}
		}

		// Token: 0x170048D3 RID: 18643
		// (get) Token: 0x06009059 RID: 36953 RVA: 0x008823FC File Offset: 0x008805FC
		internal string RadioErgoConfigACGeneralChannel_A36593_UILabel
		{
			get
			{
				short num = (short)787349505;
				if (num != 0)
				{
				}
				num = (short)653900503;
				short num2 = num;
				num = (short)435796695;
				switch (num2 == num)
				{
				}
				num = (short)1896873984;
				if (num != 0)
				{
				}
				num = (short)1269235712;
				short num3 = num;
				return this.radioErgoConfigACGeneralChannel_A36593.UIName;
			}
		}

		// Token: 0x170048D4 RID: 18644
		// (get) Token: 0x0600905A RID: 36954 RVA: 0x008824B0 File Offset: 0x008806B0
		// (set) Token: 0x0600905B RID: 36955 RVA: 0x00882564 File Offset: 0x00880764
		internal bool RadioErgoConfigACGeneralChannel_A36593_HiddenStatic
		{
			get
			{
				short num = (short)922182346;
				short num2 = num;
				num = (short)1292001994;
				switch (num2 == num)
				{
				}
				num = (short)1786052609;
				if (num != 0)
				{
				}
				num = (short)1607860224;
				if (num != 0)
				{
				}
				num = (short)1804730368;
				short num3 = num;
				return this.radioErgoConfigACGeneralChannel_A36593.HiddenStatic;
			}
			set
			{
				short num = (short)1769754422;
				short num2 = num;
				num = (short)877088566;
				switch (num2 == num)
				{
				}
				num = (short)1561329664;
				if (num != 0)
				{
				}
				num = (short)1501626369;
				if (num != 0)
				{
				}
				num = (short)1974403072;
				short num3 = num;
				this.radioErgoConfigACGeneralChannel_A36593.HiddenStatic = value;
			}
		}

		// Token: 0x170048D5 RID: 18645
		// (get) Token: 0x0600905C RID: 36956 RVA: 0x00882618 File Offset: 0x00880818
		// (set) Token: 0x0600905D RID: 36957 RVA: 0x008826CC File Offset: 0x008808CC
		internal bool RadioErgoConfigACGeneralChannel_A36593_HiddenDynamic
		{
			get
			{
				short num = (short)425302109;
				short num2 = num;
				num = (short)2146998365;
				switch (num2 == num)
				{
				}
				num = (short)1761280001;
				if (num != 0)
				{
				}
				num = (short)808255488;
				if (num != 0)
				{
				}
				num = (short)92340224;
				short num3 = num;
				return this.radioErgoConfigACGeneralChannel_A36593.HiddenDynamic;
			}
			set
			{
				short num = (short)37224244;
				short num2 = num;
				num = (short)1964441396;
				switch (num2 == num)
				{
				}
				num = (short)989659136;
				if (num != 0)
				{
				}
				num = (short)1681522689;
				if (num != 0)
				{
				}
				num = (short)1377370112;
				short num3 = num;
				this.radioErgoConfigACGeneralChannel_A36593.HiddenDynamic = value;
			}
		}

		// Token: 0x170048D6 RID: 18646
		// (get) Token: 0x0600905E RID: 36958 RVA: 0x00882780 File Offset: 0x00880980
		public bool RadioErgoConfigACGeneralChannel_A36593_HasDiffs
		{
			get
			{
				short num = (short)1086455809;
				if (num != 0)
				{
				}
				num = (short)419729780;
				short num2 = num;
				num = (short)1844875636;
				switch (num2 == num)
				{
				}
				num = (short)16646144;
				if (num != 0)
				{
				}
				num = (short)516358144;
				short num3 = num;
				return this.radioErgoConfigACGeneralChannel_A36593._HasDiffs;
			}
		}

		// Token: 0x170048D7 RID: 18647
		// (get) Token: 0x0600905F RID: 36959 RVA: 0x00882834 File Offset: 0x00880A34
		// (set) Token: 0x06009060 RID: 36960 RVA: 0x008828E8 File Offset: 0x00880AE8
		public int RadioErgoConfigACGeneralErrStrategy_A36594Value
		{
			get
			{
				short num = (short)1214119937;
				if (num != 0)
				{
				}
				num = (short)323196304;
				short num2 = num;
				num = (short)1637979536;
				switch (num2 == num)
				{
				}
				num = (short)1061617664;
				if (num != 0)
				{
				}
				num = (short)199229440;
				short num3 = num;
				return this.radioErgoConfigACGeneralErrStrategy_A36594.Value;
			}
			set
			{
				short num = (short)1314468591;
				short num2 = num;
				num = (short)1875653359;
				switch (num2 == num)
				{
				}
				num = (short)253820929;
				if (num != 0)
				{
				}
				num = (short)927924224;
				if (num != 0)
				{
				}
				num = (short)1496317952;
				short num3 = num;
				this.radioErgoConfigACGeneralErrStrategy_A36594.Value = value;
			}
		}

		// Token: 0x170048D8 RID: 18648
		// (get) Token: 0x06009061 RID: 36961 RVA: 0x008829A4 File Offset: 0x00880BA4
		// (set) Token: 0x06009062 RID: 36962 RVA: 0x00882A5C File Offset: 0x00880C5C
		public string RadioErgoConfigACGeneralErrStrategy_A36594_UIValue
		{
			get
			{
				short num = (short)1396028211;
				short num2 = num;
				num = (short)1836823347;
				switch (num2 == num)
				{
				}
				num = (short)1232338945;
				if (num != 0)
				{
				}
				num = (short)60293120;
				if (num != 0)
				{
				}
				num = (short)252510208;
				short num3 = num;
				return this.radioErgoConfigACGeneralErrStrategy_A36594.UIValue;
			}
			set
			{
				short num = (short)1750411815;
				short num2 = num;
				num = (short)1622944295;
				switch (num2 == num)
				{
				}
				num = (short)1673199617;
				if (num != 0)
				{
				}
				num = (short)1234894848;
				if (num != 0)
				{
				}
				num = (short)588251136;
				short num3 = num;
				this.radioErgoConfigACGeneralErrStrategy_A36594.UIValue = value;
			}
		}

		// Token: 0x170048D9 RID: 18649
		// (get) Token: 0x06009063 RID: 36963 RVA: 0x00882B14 File Offset: 0x00880D14
		public global::AcpBusinessLayer.AcpListField RadioErgoConfigACGeneralErrStrategy_A36594
		{
			get
			{
				short num = (short)1509471036;
				short num2 = num;
				num = (short)148878140;
				switch (num2 == num)
				{
				}
				num = (short)389283841;
				if (num != 0)
				{
				}
				num = (short)322830336;
				if (num != 0)
				{
				}
				num = (short)1962082304;
				short num3 = num;
				return this.radioErgoConfigACGeneralErrStrategy_A36594;
			}
		}

		// Token: 0x170048DA RID: 18650
		// (get) Token: 0x06009064 RID: 36964 RVA: 0x00882BC8 File Offset: 0x00880DC8
		// (set) Token: 0x06009065 RID: 36965 RVA: 0x00882C7C File Offset: 0x00880E7C
		public bool RadioErgoConfigACGeneralErrStrategy_A36594_Applicable
		{
			get
			{
				short num = (short)544298515;
				short num2 = num;
				num = (short)274159123;
				switch (num2 == num)
				{
				}
				num = (short)1944977409;
				if (num != 0)
				{
				}
				num = (short)942342144;
				if (num != 0)
				{
				}
				num = (short)1908801536;
				short num3 = num;
				return this.radioErgoConfigACGeneralErrStrategy_A36594.Applicable;
			}
			set
			{
				short num = (short)1712247030;
				short num2 = num;
				num = (short)1822150902;
				switch (num2 == num)
				{
				}
				num = (short)1717960705;
				if (num != 0)
				{
				}
				num = (short)1543766016;
				if (num != 0)
				{
				}
				num = (short)1382809600;
				short num3 = num;
				this.radioErgoConfigACGeneralErrStrategy_A36594.Applicable = value;
			}
		}

		// Token: 0x170048DB RID: 18651
		// (get) Token: 0x06009066 RID: 36966 RVA: 0x00882D30 File Offset: 0x00880F30
		// (set) Token: 0x06009067 RID: 36967 RVA: 0x00882DE8 File Offset: 0x00880FE8
		public bool RadioErgoConfigACGeneralErrStrategy_A36594_Valid
		{
			get
			{
				short num = (short)1004535809;
				if (num != 0)
				{
				}
				num = (short)344382482;
				short num2 = num;
				num = (short)752868370;
				switch (num2 == num)
				{
				}
				num = (short)725614592;
				if (num != 0)
				{
				}
				num = (short)969146368;
				short num3 = num;
				return this.radioErgoConfigACGeneralErrStrategy_A36594.Valid;
			}
			set
			{
				short num = (short)454523404;
				short num2 = num;
				num = (short)1413380620;
				switch (num2 == num)
				{
				}
				num = (short)1891827713;
				if (num != 0)
				{
				}
				num = (short)1161363456;
				if (num != 0)
				{
				}
				num = (short)2088304640;
				short num3 = num;
				this.radioErgoConfigACGeneralErrStrategy_A36594.Valid = value;
			}
		}

		// Token: 0x170048DC RID: 18652
		// (get) Token: 0x06009068 RID: 36968 RVA: 0x00882E9C File Offset: 0x0088109C
		// (set) Token: 0x06009069 RID: 36969 RVA: 0x00882F50 File Offset: 0x00881150
		public bool RadioErgoConfigACGeneralErrStrategy_A36594_Visible
		{
			get
			{
				short num = (short)437235083;
				short num2 = num;
				num = (short)178892171;
				switch (num2 == num)
				{
				}
				num = (short)229965825;
				if (num != 0)
				{
				}
				num = (short)2034499584;
				if (num != 0)
				{
				}
				num = (short)836304896;
				short num3 = num;
				return this.radioErgoConfigACGeneralErrStrategy_A36594.Visible;
			}
			set
			{
				short num = (short)612869548;
				short num2 = num;
				num = (short)1424139692;
				switch (num2 == num)
				{
				}
				num = (short)1759969281;
				if (num != 0)
				{
				}
				num = (short)129105920;
				if (num != 0)
				{
				}
				num = (short)1677066240;
				short num3 = num;
				this.radioErgoConfigACGeneralErrStrategy_A36594.Visible = value;
			}
		}

		// Token: 0x170048DD RID: 18653
		// (get) Token: 0x0600906A RID: 36970 RVA: 0x00883008 File Offset: 0x00881208
		// (set) Token: 0x0600906B RID: 36971 RVA: 0x008830C0 File Offset: 0x008812C0
		public bool RadioErgoConfigACGeneralErrStrategy_A36594_Editable
		{
			get
			{
				short num = (short)1677936917;
				short num2 = num;
				num = (short)1441679637;
				switch (num2 == num)
				{
				}
				num = (short)746192897;
				if (num != 0)
				{
				}
				num = (short)1138098176;
				if (num != 0)
				{
				}
				num = (short)1138032640;
				short num3 = num;
				return this.radioErgoConfigACGeneralErrStrategy_A36594.Editable;
			}
			set
			{
				short num = (short)548788146;
				short num2 = num;
				num = (short)672585650;
				switch (num2 == num)
				{
				}
				num = (short)193134592;
				if (num != 0)
				{
				}
				num = (short)182255617;
				if (num != 0)
				{
				}
				num = (short)1085276160;
				short num3 = num;
				this.radioErgoConfigACGeneralErrStrategy_A36594.Editable = value;
			}
		}

		// Token: 0x170048DE RID: 18654
		// (get) Token: 0x0600906C RID: 36972 RVA: 0x00883178 File Offset: 0x00881378
		internal string RadioErgoConfigACGeneralErrStrategy_A36594_UILabel
		{
			get
			{
				short num = (short)1931097447;
				short num2 = num;
				num = (short)2086614375;
				switch (num2 == num)
				{
				}
				num = (short)2048589824;
				if (num != 0)
				{
				}
				num = (short)1121058817;
				if (num != 0)
				{
				}
				num = (short)599851008;
				short num3 = num;
				return this.radioErgoConfigACGeneralErrStrategy_A36594.UIName;
			}
		}

		// Token: 0x170048DF RID: 18655
		// (get) Token: 0x0600906D RID: 36973 RVA: 0x00883230 File Offset: 0x00881430
		// (set) Token: 0x0600906E RID: 36974 RVA: 0x008832E8 File Offset: 0x008814E8
		internal bool RadioErgoConfigACGeneralErrStrategy_A36594_HiddenStatic
		{
			get
			{
				short num = (short)995073912;
				short num2 = num;
				num = (short)54632312;
				switch (num2 == num)
				{
				}
				num = (short)1959985153;
				if (num != 0)
				{
				}
				num = (short)900857856;
				if (num != 0)
				{
				}
				num = (short)1632108544;
				short num3 = num;
				return this.radioErgoConfigACGeneralErrStrategy_A36594.HiddenStatic;
			}
			set
			{
				short num = (short)1983377286;
				short num2 = num;
				num = (short)968814470;
				switch (num2 == num)
				{
				}
				num = (short)100335617;
				if (num != 0)
				{
				}
				num = (short)13107200;
				if (num != 0)
				{
				}
				num = (short)1360723968;
				short num3 = num;
				this.radioErgoConfigACGeneralErrStrategy_A36594.HiddenStatic = value;
			}
		}

		// Token: 0x170048E0 RID: 18656
		// (get) Token: 0x0600906F RID: 36975 RVA: 0x0088339C File Offset: 0x0088159C
		// (set) Token: 0x06009070 RID: 36976 RVA: 0x00883450 File Offset: 0x00881650
		internal bool RadioErgoConfigACGeneralErrStrategy_A36594_HiddenDynamic
		{
			get
			{
				short num = (short)1562443777;
				if (num != 0)
				{
				}
				num = (short)1062985669;
				short num2 = num;
				num = (short)256434117;
				switch (num2 == num)
				{
				}
				num = (short)873529344;
				if (num != 0)
				{
				}
				num = (short)1366949888;
				short num3 = num;
				return this.radioErgoConfigACGeneralErrStrategy_A36594.HiddenDynamic;
			}
			set
			{
				short num = (short)1388904449;
				if (num != 0)
				{
				}
				num = (short)1110966771;
				short num2 = num;
				num = (short)543752691;
				switch (num2 == num)
				{
				}
				num = (short)621346816;
				if (num != 0)
				{
				}
				num = (short)1823866880;
				short num3 = num;
				this.radioErgoConfigACGeneralErrStrategy_A36594.HiddenDynamic = value;
			}
		}

		// Token: 0x170048E1 RID: 18657
		// (get) Token: 0x06009071 RID: 36977 RVA: 0x00883504 File Offset: 0x00881704
		public bool RadioErgoConfigACGeneralErrStrategy_A36594_HasDiffs
		{
			get
			{
				short num = (short)359392980;
				short num2 = num;
				num = (short)1557653204;
				switch (num2 == num)
				{
				}
				num = (short)2094792705;
				if (num != 0)
				{
				}
				num = (short)1456013312;
				if (num != 0)
				{
				}
				num = (short)655097856;
				short num3 = num;
				return this.radioErgoConfigACGeneralErrStrategy_A36594._HasDiffs;
			}
		}

		// Token: 0x170048E2 RID: 18658
		// (get) Token: 0x06009072 RID: 36978 RVA: 0x008835B8 File Offset: 0x008817B8
		// (set) Token: 0x06009073 RID: 36979 RVA: 0x0088366C File Offset: 0x0088186C
		public int RadioErgoConfigACGeneralIndex_A36591Value
		{
			get
			{
				short num = (short)466223105;
				if (num != 0)
				{
				}
				num = (short)1689359888;
				short num2 = num;
				num = (short)1003197968;
				switch (num2 == num)
				{
				}
				num = (short)1301282816;
				if (num != 0)
				{
				}
				num = (short)1695219712;
				short num3 = num;
				return this.radioErgoConfigACGeneralIndex_A36591.Value;
			}
			set
			{
				short num = (short)1663633622;
				short num2 = num;
				num = (short)11995350;
				switch (num2 == num)
				{
				}
				num = (short)984809473;
				if (num != 0)
				{
				}
				num = (short)2001666048;
				if (num != 0)
				{
				}
				num = (short)1981087744;
				short num3 = num;
				this.radioErgoConfigACGeneralIndex_A36591.Value = value;
			}
		}

		// Token: 0x170048E3 RID: 18659
		// (get) Token: 0x06009074 RID: 36980 RVA: 0x00883720 File Offset: 0x00881920
		public global::AcpBusinessLayer.AcpSimpleRangeField RadioErgoConfigACGeneralIndex_A36591
		{
			get
			{
				short num = (short)655271161;
				short num2 = num;
				num = (short)1437050105;
				switch (num2 == num)
				{
				}
				num = (short)285933569;
				if (num != 0)
				{
				}
				num = (short)1990524928;
				if (num != 0)
				{
				}
				num = (short)2060582912;
				short num3 = num;
				return this.radioErgoConfigACGeneralIndex_A36591;
			}
		}

		// Token: 0x170048E4 RID: 18660
		// (get) Token: 0x06009075 RID: 36981 RVA: 0x008837CC File Offset: 0x008819CC
		// (set) Token: 0x06009076 RID: 36982 RVA: 0x0088387C File Offset: 0x00881A7C
		public string RadioErgoConfigACGeneralIndex_A36591_UIValue
		{
			get
			{
				short num = (short)1261394471;
				short num2 = num;
				num = (short)621238823;
				switch (num2 == num)
				{
				}
				num = (short)1823604737;
				if (num != 0)
				{
				}
				num = (short)1786380288;
				if (num != 0)
				{
				}
				num = (short)946667520;
				short num3 = num;
				return this.radioErgoConfigACGeneralIndex_A36591.UIValue;
			}
			set
			{
				short num = (short)2050592163;
				short num2 = num;
				num = (short)267488675;
				switch (num2 == num)
				{
				}
				num = (short)1402470401;
				if (num != 0)
				{
				}
				num = (short)31850496;
				if (num != 0)
				{
				}
				num = (short)1654456320;
				short num3 = num;
				this.radioErgoConfigACGeneralIndex_A36591.UIValue = value;
			}
		}

		// Token: 0x170048E5 RID: 18661
		// (get) Token: 0x06009077 RID: 36983 RVA: 0x00883930 File Offset: 0x00881B30
		// (set) Token: 0x06009078 RID: 36984 RVA: 0x008839E4 File Offset: 0x00881BE4
		internal int RadioErgoConfigACGeneralIndex_A36591Min
		{
			get
			{
				short num = (short)1501626369;
				if (num != 0)
				{
				}
				num = (short)1081329705;
				short num2 = num;
				num = (short)709478441;
				switch (num2 == num)
				{
				}
				num = (short)1204289536;
				if (num != 0)
				{
				}
				num = (short)2112880640;
				short num3 = num;
				return this.radioErgoConfigACGeneralIndex_A36591.Min;
			}
			set
			{
				short num = (short)1588310376;
				short num2 = num;
				num = (short)2141106536;
				switch (num2 == num)
				{
				}
				num = (short)101842944;
				if (num != 0)
				{
				}
				num = (short)1813381121;
				if (num != 0)
				{
				}
				num = (short)507772928;
				short num3 = num;
				this.radioErgoConfigACGeneralIndex_A36591.Min = value;
			}
		}

		// Token: 0x170048E6 RID: 18662
		// (get) Token: 0x06009079 RID: 36985 RVA: 0x00883A9C File Offset: 0x00881C9C
		// (set) Token: 0x0600907A RID: 36986 RVA: 0x00883B50 File Offset: 0x00881D50
		internal int RadioErgoConfigACGeneralIndex_A36591Max
		{
			get
			{
				short num = (short)758320767;
				short num2 = num;
				num = (short)2029915775;
				switch (num2 == num)
				{
				}
				num = (short)552271873;
				if (num != 0)
				{
				}
				num = (short)1516830720;
				if (num != 0)
				{
				}
				num = (short)525598720;
				short num3 = num;
				return this.radioErgoConfigACGeneralIndex_A36591.Max;
			}
			set
			{
				short num = (short)1592189223;
				short num2 = num;
				num = (short)909607;
				switch (num2 == num)
				{
				}
				num = (short)16121857;
				if (num != 0)
				{
				}
				num = (short)383582208;
				if (num != 0)
				{
				}
				num = (short)66846720;
				short num3 = num;
				this.radioErgoConfigACGeneralIndex_A36591.Max = value;
			}
		}

		// Token: 0x170048E7 RID: 18663
		// (get) Token: 0x0600907B RID: 36987 RVA: 0x00883C08 File Offset: 0x00881E08
		// (set) Token: 0x0600907C RID: 36988 RVA: 0x00883CBC File Offset: 0x00881EBC
		internal int RadioErgoConfigACGeneralIndex_A36591Step
		{
			get
			{
				short num = (short)209373461;
				short num2 = num;
				num = (short)1083689237;
				switch (num2 == num)
				{
				}
				num = (short)1001914369;
				if (num != 0)
				{
				}
				num = (short)1675165696;
				if (num != 0)
				{
				}
				num = (short)1043988480;
				short num3 = num;
				return this.radioErgoConfigACGeneralIndex_A36591.StepSize;
			}
			set
			{
				short num = (short)2015929528;
				short num2 = num;
				num = (short)2146018488;
				switch (num2 == num)
				{
				}
				num = (short)160104449;
				if (num != 0)
				{
				}
				num = (short)1292238848;
				if (num != 0)
				{
				}
				num = (short)1526267904;
				short num3 = num;
				this.radioErgoConfigACGeneralIndex_A36591.StepSize = value;
			}
		}

		// Token: 0x170048E8 RID: 18664
		// (get) Token: 0x0600907D RID: 36989 RVA: 0x00883D74 File Offset: 0x00881F74
		// (set) Token: 0x0600907E RID: 36990 RVA: 0x00883E28 File Offset: 0x00882028
		public bool RadioErgoConfigACGeneralIndex_A36591_Applicable
		{
			get
			{
				short num = (short)1804402689;
				if (num != 0)
				{
				}
				num = (short)87607108;
				short num2 = num;
				num = (short)243910468;
				switch (num2 == num)
				{
				}
				num = (short)169017344;
				if (num != 0)
				{
				}
				num = (short)1547763712;
				short num3 = num;
				return this.radioErgoConfigACGeneralIndex_A36591.Applicable;
			}
			set
			{
				short num = (short)1513553921;
				if (num != 0)
				{
				}
				num = (short)1805400333;
				short num2 = num;
				num = (short)164772109;
				switch (num2 == num)
				{
				}
				num = (short)1260519424;
				if (num != 0)
				{
				}
				num = (short)1323433984;
				short num3 = num;
				this.radioErgoConfigACGeneralIndex_A36591.Applicable = value;
			}
		}

		// Token: 0x170048E9 RID: 18665
		// (get) Token: 0x0600907F RID: 36991 RVA: 0x00883EE0 File Offset: 0x008820E0
		// (set) Token: 0x06009080 RID: 36992 RVA: 0x00883F98 File Offset: 0x00882198
		public bool RadioErgoConfigACGeneralIndex_A36591_Valid
		{
			get
			{
				short num = (short)1844523308;
				short num2 = num;
				num = (short)1019425068;
				switch (num2 == num)
				{
				}
				num = (short)484966401;
				if (num != 0)
				{
				}
				num = (short)239403008;
				if (num != 0)
				{
				}
				num = (short)1604583424;
				short num3 = num;
				return this.radioErgoConfigACGeneralIndex_A36591.Valid;
			}
			set
			{
				short num = (short)2066961266;
				short num2 = num;
				num = (short)1045975922;
				switch (num2 == num)
				{
				}
				num = (short)1719599104;
				if (num != 0)
				{
				}
				num = (short)1604648961;
				if (num != 0)
				{
				}
				num = (short)992673792;
				short num3 = num;
				this.radioErgoConfigACGeneralIndex_A36591.Valid = value;
			}
		}

		// Token: 0x170048EA RID: 18666
		// (get) Token: 0x06009081 RID: 36993 RVA: 0x0088404C File Offset: 0x0088224C
		// (set) Token: 0x06009082 RID: 36994 RVA: 0x00884104 File Offset: 0x00882304
		public bool RadioErgoConfigACGeneralIndex_A36591_Visible
		{
			get
			{
				short num = (short)1521818132;
				short num2 = num;
				num = (short)172825108;
				switch (num2 == num)
				{
				}
				num = (short)853868545;
				if (num != 0)
				{
				}
				num = (short)896860160;
				if (num != 0)
				{
				}
				num = (short)76349440;
				short num3 = num;
				return this.radioErgoConfigACGeneralIndex_A36591.Visible;
			}
			set
			{
				short num = (short)1559559592;
				short num2 = num;
				num = (short)900988328;
				switch (num2 == num)
				{
				}
				num = (short)445120512;
				if (num != 0)
				{
				}
				num = (short)332922881;
				if (num != 0)
				{
				}
				num = (short)1141702656;
				short num3 = num;
				this.radioErgoConfigACGeneralIndex_A36591.Visible = value;
			}
		}

		// Token: 0x170048EB RID: 18667
		// (get) Token: 0x06009083 RID: 36995 RVA: 0x008841B8 File Offset: 0x008823B8
		// (set) Token: 0x06009084 RID: 36996 RVA: 0x0088426C File Offset: 0x0088246C
		public bool RadioErgoConfigACGeneralIndex_A36591_Editable
		{
			get
			{
				short num = (short)1115095041;
				if (num != 0)
				{
				}
				num = (short)741688171;
				short num2 = num;
				num = (short)535380843;
				switch (num2 == num)
				{
				}
				num = (short)814415872;
				if (num != 0)
				{
				}
				num = (short)886439936;
				short num3 = num;
				return this.radioErgoConfigACGeneralIndex_A36591.Editable;
			}
			set
			{
				short num = (short)1974075393;
				if (num != 0)
				{
				}
				num = (short)2041792222;
				short num2 = num;
				num = (short)1151026910;
				switch (num2 == num)
				{
				}
				num = (short)45023232;
				if (num != 0)
				{
				}
				num = (short)907149312;
				short num3 = num;
				this.radioErgoConfigACGeneralIndex_A36591.Editable = value;
			}
		}

		// Token: 0x170048EC RID: 18668
		// (get) Token: 0x06009085 RID: 36997 RVA: 0x00884320 File Offset: 0x00882520
		internal string RadioErgoConfigACGeneralIndex_A36591_UILabel
		{
			get
			{
				short num = (short)1163120646;
				short num2 = num;
				num = (short)1873793030;
				switch (num2 == num)
				{
				}
				num = (short)446693376;
				if (num != 0)
				{
				}
				num = (short)1899888641;
				if (num != 0)
				{
				}
				num = (short)713424896;
				short num3 = num;
				return this.radioErgoConfigACGeneralIndex_A36591.UIName;
			}
		}

		// Token: 0x170048ED RID: 18669
		// (get) Token: 0x06009086 RID: 36998 RVA: 0x008843D4 File Offset: 0x008825D4
		// (set) Token: 0x06009087 RID: 36999 RVA: 0x0088448C File Offset: 0x0088268C
		internal bool RadioErgoConfigACGeneralIndex_A36591_HiddenStatic
		{
			get
			{
				short num = (short)601604356;
				short num2 = num;
				num = (short)1965670660;
				switch (num2 == num)
				{
				}
				num = (short)1372127233;
				if (num != 0)
				{
				}
				num = (short)1741160448;
				if (num != 0)
				{
				}
				num = (short)17432576;
				short num3 = num;
				return this.radioErgoConfigACGeneralIndex_A36591.HiddenStatic;
			}
			set
			{
				short num = (short)772539763;
				short num2 = num;
				num = (short)54789491;
				switch (num2 == num)
				{
				}
				num = (short)509607936;
				if (num != 0)
				{
				}
				num = (short)307757057;
				if (num != 0)
				{
				}
				num = (short)1066926080;
				short num3 = num;
				this.radioErgoConfigACGeneralIndex_A36591.HiddenStatic = value;
			}
		}

		// Token: 0x170048EE RID: 18670
		// (get) Token: 0x06009088 RID: 37000 RVA: 0x00884540 File Offset: 0x00882740
		// (set) Token: 0x06009089 RID: 37001 RVA: 0x008845F4 File Offset: 0x008827F4
		internal bool RadioErgoConfigACGeneralIndex_A36591_HiddenDynamic
		{
			get
			{
				short num = (short)689059667;
				short num2 = num;
				num = (short)1871787859;
				switch (num2 == num)
				{
				}
				num = (short)1922236416;
				if (num != 0)
				{
				}
				num = (short)1883242497;
				if (num != 0)
				{
				}
				num = (short)1877409792;
				short num3 = num;
				return this.radioErgoConfigACGeneralIndex_A36591.HiddenDynamic;
			}
			set
			{
				short num = (short)227233737;
				short num2 = num;
				num = (short)587026377;
				switch (num2 == num)
				{
				}
				num = (short)768344065;
				if (num != 0)
				{
				}
				num = (short)752812032;
				if (num != 0)
				{
				}
				num = (short)898891776;
				short num3 = num;
				this.radioErgoConfigACGeneralIndex_A36591.HiddenDynamic = value;
			}
		}

		// Token: 0x170048EF RID: 18671
		// (get) Token: 0x0600908A RID: 37002 RVA: 0x008846A8 File Offset: 0x008828A8
		public bool RadioErgoConfigACGeneralIndex_A36591_HasDiffs
		{
			get
			{
				short num = (short)336592897;
				if (num != 0)
				{
				}
				num = (short)312072290;
				short num2 = num;
				num = (short)1030019170;
				switch (num2 == num)
				{
				}
				num = (short)1661075456;
				if (num != 0)
				{
				}
				num = (short)334561280;
				short num3 = num;
				return this.radioErgoConfigACGeneralIndex_A36591._HasDiffs;
			}
		}

		// Token: 0x170048F0 RID: 18672
		// (get) Token: 0x0600908B RID: 37003 RVA: 0x0088475C File Offset: 0x0088295C
		// (set) Token: 0x0600908C RID: 37004 RVA: 0x00884810 File Offset: 0x00882A10
		public int RadioErgoConfigACAlertAudioFile_A42875Value
		{
			get
			{
				short num = (short)752983654;
				short num2 = num;
				num = (short)554212966;
				switch (num2 == num)
				{
				}
				num = (short)920190977;
				if (num != 0)
				{
				}
				num = (short)2077294592;
				if (num != 0)
				{
				}
				num = (short)2033188864;
				short num3 = num;
				return this.radioErgoConfigACAlertAudioFile_A42875.Value;
			}
			set
			{
				short num = (short)1462217368;
				short num2 = num;
				num = (short)1572776600;
				switch (num2 == num)
				{
				}
				num = (short)1977090049;
				if (num != 0)
				{
				}
				num = (short)1097465856;
				if (num != 0)
				{
				}
				num = (short)515833856;
				short num3 = num;
				this.radioErgoConfigACAlertAudioFile_A42875.Value = value;
			}
		}

		// Token: 0x170048F1 RID: 18673
		// (get) Token: 0x0600908D RID: 37005 RVA: 0x008848C8 File Offset: 0x00882AC8
		// (set) Token: 0x0600908E RID: 37006 RVA: 0x00884980 File Offset: 0x00882B80
		public string RadioErgoConfigACAlertAudioFile_A42875_UIValue
		{
			get
			{
				short num = (short)75970936;
				short num2 = num;
				num = (short)363805048;
				switch (num2 == num)
				{
				}
				num = (short)1788280832;
				if (num != 0)
				{
				}
				num = (short)1186988033;
				if (num != 0)
				{
				}
				num = (short)881983488;
				short num3 = num;
				return this.radioErgoConfigACAlertAudioFile_A42875.UIValue;
			}
			set
			{
				short num = (short)58628948;
				short num2 = num;
				num = (short)855481172;
				switch (num2 == num)
				{
				}
				num = (short)174587904;
				if (num != 0)
				{
				}
				num = (short)2070740993;
				if (num != 0)
				{
				}
				num = (short)601686016;
				short num3 = num;
				this.radioErgoConfigACAlertAudioFile_A42875.UIValue = value;
			}
		}

		// Token: 0x170048F2 RID: 18674
		// (get) Token: 0x0600908F RID: 37007 RVA: 0x00884A34 File Offset: 0x00882C34
		public global::AcpBusinessLayer.AcpRecRefField RadioErgoConfigACAlertAudioFile_A42875
		{
			get
			{
				short num = (short)48882951;
				short num2 = num;
				num = (short)1450042631;
				switch (num2 == num)
				{
				}
				num = (short)1309409281;
				if (num != 0)
				{
				}
				num = (short)1177419776;
				if (num != 0)
				{
				}
				num = (short)1708130304;
				short num3 = num;
				return this.radioErgoConfigACAlertAudioFile_A42875;
			}
		}

		// Token: 0x170048F3 RID: 18675
		// (get) Token: 0x06009090 RID: 37008 RVA: 0x00884AE4 File Offset: 0x00882CE4
		// (set) Token: 0x06009091 RID: 37009 RVA: 0x00884B98 File Offset: 0x00882D98
		public bool RadioErgoConfigACAlertAudioFile_A42875_Applicable
		{
			get
			{
				short num = (short)60279633;
				short num2 = num;
				num = (short)1991953233;
				switch (num2 == num)
				{
				}
				num = (short)1968898049;
				if (num != 0)
				{
				}
				num = (short)510001152;
				if (num != 0)
				{
				}
				num = (short)1354039296;
				short num3 = num;
				return this.radioErgoConfigACAlertAudioFile_A42875.Applicable;
			}
			set
			{
				short num = (short)242385668;
				short num2 = num;
				num = (short)1131512580;
				switch (num2 == num)
				{
				}
				num = (short)1131937793;
				if (num != 0)
				{
				}
				num = (short)145686528;
				if (num != 0)
				{
				}
				num = (short)1597440000;
				short num3 = num;
				this.radioErgoConfigACAlertAudioFile_A42875.Applicable = value;
			}
		}

		// Token: 0x170048F4 RID: 18676
		// (get) Token: 0x06009092 RID: 37010 RVA: 0x00884C50 File Offset: 0x00882E50
		// (set) Token: 0x06009093 RID: 37011 RVA: 0x00884D04 File Offset: 0x00882F04
		public bool RadioErgoConfigACAlertAudioFile_A42875_Valid
		{
			get
			{
				short num = (short)600657219;
				short num2 = num;
				num = (short)1557024067;
				switch (num2 == num)
				{
				}
				num = (short)1110507520;
				if (num != 0)
				{
				}
				num = (short)466288641;
				if (num != 0)
				{
				}
				num = (short)755892224;
				short num3 = num;
				return this.radioErgoConfigACAlertAudioFile_A42875.Valid;
			}
			set
			{
				short num = (short)1784328585;
				short num2 = num;
				num = (short)917287305;
				switch (num2 == num)
				{
				}
				num = (short)1421803521;
				if (num != 0)
				{
				}
				num = (short)282656768;
				if (num != 0)
				{
				}
				num = (short)1911029760;
				short num3 = num;
				this.radioErgoConfigACAlertAudioFile_A42875.Valid = value;
			}
		}

		// Token: 0x170048F5 RID: 18677
		// (get) Token: 0x06009094 RID: 37012 RVA: 0x00884DB8 File Offset: 0x00882FB8
		// (set) Token: 0x06009095 RID: 37013 RVA: 0x00884E68 File Offset: 0x00883068
		public bool RadioErgoConfigACAlertAudioFile_A42875_Visible
		{
			get
			{
				short num = (short)1861183780;
				short num2 = num;
				num = (short)1752721700;
				switch (num2 == num)
				{
				}
				num = (short)209846272;
				if (num != 0)
				{
				}
				num = (short)2097152001;
				if (num != 0)
				{
				}
				num = (short)1266548736;
				short num3 = num;
				return this.radioErgoConfigACAlertAudioFile_A42875.Visible;
			}
			set
			{
				short num = (short)184453277;
				short num2 = num;
				num = (short)1657505949;
				switch (num2 == num)
				{
				}
				num = (short)1983447041;
				if (num != 0)
				{
				}
				num = (short)1351483392;
				if (num != 0)
				{
				}
				num = (short)2013790208;
				short num3 = num;
				this.radioErgoConfigACAlertAudioFile_A42875.Visible = value;
			}
		}

		// Token: 0x170048F6 RID: 18678
		// (get) Token: 0x06009096 RID: 37014 RVA: 0x00884F20 File Offset: 0x00883120
		// (set) Token: 0x06009097 RID: 37015 RVA: 0x00884FD8 File Offset: 0x008831D8
		public bool RadioErgoConfigACAlertAudioFile_A42875_Editable
		{
			get
			{
				short num = (short)1487728790;
				short num2 = num;
				num = (short)1566830742;
				switch (num2 == num)
				{
				}
				num = (short)234553344;
				if (num != 0)
				{
				}
				num = (short)378929153;
				if (num != 0)
				{
				}
				num = (short)1733296128;
				short num3 = num;
				return this.radioErgoConfigACAlertAudioFile_A42875.Editable;
			}
			set
			{
				short num = (short)1854396616;
				short num2 = num;
				num = (short)319543496;
				switch (num2 == num)
				{
				}
				num = (short)1192755201;
				if (num != 0)
				{
				}
				num = (short)1442840576;
				if (num != 0)
				{
				}
				num = (short)1001521152;
				short num3 = num;
				this.radioErgoConfigACAlertAudioFile_A42875.Editable = value;
			}
		}

		// Token: 0x170048F7 RID: 18679
		// (get) Token: 0x06009098 RID: 37016 RVA: 0x0088508C File Offset: 0x0088328C
		internal string RadioErgoConfigACAlertAudioFile_A42875_UILabel
		{
			get
			{
				short num = (short)468723088;
				short num2 = num;
				num = (short)884811152;
				switch (num2 == num)
				{
				}
				num = (short)905379840;
				if (num != 0)
				{
				}
				num = (short)2135359489;
				if (num != 0)
				{
				}
				num = (short)566099968;
				short num3 = num;
				return this.radioErgoConfigACAlertAudioFile_A42875.UIName;
			}
		}

		// Token: 0x170048F8 RID: 18680
		// (get) Token: 0x06009099 RID: 37017 RVA: 0x00885144 File Offset: 0x00883344
		// (set) Token: 0x0600909A RID: 37018 RVA: 0x008851FC File Offset: 0x008833FC
		internal bool RadioErgoConfigACAlertAudioFile_A42875_HiddenStatic
		{
			get
			{
				short num = (short)1429103102;
				short num2 = num;
				num = (short)526737918;
				switch (num2 == num)
				{
				}
				num = (short)766312449;
				if (num != 0)
				{
				}
				num = (short)1932853248;
				if (num != 0)
				{
				}
				num = (short)1785921536;
				short num3 = num;
				return this.radioErgoConfigACAlertAudioFile_A42875.HiddenStatic;
			}
			set
			{
				short num = (short)1248002516;
				short num2 = num;
				num = (short)1813774804;
				switch (num2 == num)
				{
				}
				num = (short)1866465281;
				if (num != 0)
				{
				}
				num = (short)297992192;
				if (num != 0)
				{
				}
				num = (short)1861615616;
				short num3 = num;
				this.radioErgoConfigACAlertAudioFile_A42875.HiddenStatic = value;
			}
		}

		// Token: 0x170048F9 RID: 18681
		// (get) Token: 0x0600909B RID: 37019 RVA: 0x008852B4 File Offset: 0x008834B4
		// (set) Token: 0x0600909C RID: 37020 RVA: 0x00885368 File Offset: 0x00883568
		internal bool RadioErgoConfigACAlertAudioFile_A42875_HiddenDynamic
		{
			get
			{
				short num = (short)108939156;
				short num2 = num;
				num = (short)1707689876;
				switch (num2 == num)
				{
				}
				num = (short)202571776;
				if (num != 0)
				{
				}
				num = (short)1736310785;
				if (num != 0)
				{
				}
				num = (short)499908608;
				short num3 = num;
				return this.radioErgoConfigACAlertAudioFile_A42875.HiddenDynamic;
			}
			set
			{
				short num = (short)1995042766;
				short num2 = num;
				num = (short)883224526;
				switch (num2 == num)
				{
				}
				num = (short)1050411008;
				if (num != 0)
				{
				}
				num = (short)1987706881;
				if (num != 0)
				{
				}
				num = (short)10223616;
				short num3 = num;
				this.radioErgoConfigACAlertAudioFile_A42875.HiddenDynamic = value;
			}
		}

		// Token: 0x170048FA RID: 18682
		// (get) Token: 0x0600909D RID: 37021 RVA: 0x00885420 File Offset: 0x00883620
		public bool RadioErgoConfigACAlertAudioFile_A42875_HasDiffs
		{
			get
			{
				short num = (short)885396221;
				short num2 = num;
				num = (short)743379709;
				switch (num2 == num)
				{
				}
				num = (short)1987772417;
				if (num != 0)
				{
				}
				num = (short)31916032;
				if (num != 0)
				{
				}
				num = (short)1194524672;
				short num3 = num;
				return this.radioErgoConfigACAlertAudioFile_A42875._HasDiffs;
			}
		}

		// Token: 0x170048FB RID: 18683
		// (get) Token: 0x0600909E RID: 37022 RVA: 0x008854D8 File Offset: 0x008836D8
		// (set) Token: 0x0600909F RID: 37023 RVA: 0x00885590 File Offset: 0x00883790
		public int RadioErgoConfigACAlertInterval_A42877Value
		{
			get
			{
				short num = (short)579272705;
				if (num != 0)
				{
				}
				num = (short)912708948;
				short num2 = num;
				num = (short)547607892;
				switch (num2 == num)
				{
				}
				num = (short)652869632;
				if (num != 0)
				{
				}
				num = (short)545718272;
				short num3 = num;
				return this.radioErgoConfigACAlertInterval_A42877.Value;
			}
			set
			{
				short num = (short)1821697606;
				short num2 = num;
				num = (short)131982918;
				switch (num2 == num)
				{
				}
				num = (short)653066241;
				if (num != 0)
				{
				}
				num = (short)681115648;
				if (num != 0)
				{
				}
				num = (short)2138046464;
				short num3 = num;
				this.radioErgoConfigACAlertInterval_A42877.Value = value;
			}
		}

		// Token: 0x170048FC RID: 18684
		// (get) Token: 0x060090A0 RID: 37024 RVA: 0x00885644 File Offset: 0x00883844
		public global::AcpBusinessLayer.AcpCustomRangeField RadioErgoConfigACAlertInterval_A42877
		{
			get
			{
				short num = (short)989752478;
				short num2 = num;
				num = (short)928935070;
				switch (num2 == num)
				{
				}
				num = (short)1132396545;
				if (num != 0)
				{
				}
				num = (short)252051456;
				if (num != 0)
				{
				}
				num = (short)1847001088;
				short num3 = num;
				return this.radioErgoConfigACAlertInterval_A42877;
			}
		}

		// Token: 0x170048FD RID: 18685
		// (get) Token: 0x060090A1 RID: 37025 RVA: 0x008856F4 File Offset: 0x008838F4
		// (set) Token: 0x060090A2 RID: 37026 RVA: 0x008857A8 File Offset: 0x008839A8
		public string RadioErgoConfigACAlertInterval_A42877_UIValue
		{
			get
			{
				short num = (short)2137528297;
				short num2 = num;
				num = (short)1375606761;
				switch (num2 == num)
				{
				}
				num = (short)631963648;
				if (num != 0)
				{
				}
				num = (short)106954753;
				if (num != 0)
				{
				}
				num = (short)152371200;
				short num3 = num;
				return this.radioErgoConfigACAlertInterval_A42877.UIValue;
			}
			set
			{
				short num = (short)355074049;
				if (num != 0)
				{
				}
				num = (short)428835903;
				short num2 = num;
				num = (short)130778175;
				switch (num2 == num)
				{
				}
				num = (short)1181286400;
				if (num != 0)
				{
				}
				num = (short)137232384;
				short num3 = num;
				this.radioErgoConfigACAlertInterval_A42877.UIValue = value;
			}
		}

		// Token: 0x170048FE RID: 18686
		// (get) Token: 0x060090A3 RID: 37027 RVA: 0x0088585C File Offset: 0x00883A5C
		// (set) Token: 0x060090A4 RID: 37028 RVA: 0x00885910 File Offset: 0x00883B10
		internal int RadioErgoConfigACAlertInterval_A42877Min
		{
			get
			{
				short num = (short)1509170002;
				short num2 = num;
				num = (short)830937938;
				switch (num2 == num)
				{
				}
				num = (short)485294081;
				if (num != 0)
				{
				}
				num = (short)513015808;
				if (num != 0)
				{
				}
				num = (short)619511808;
				short num3 = num;
				return this.radioErgoConfigACAlertInterval_A42877.Min;
			}
			set
			{
				short num = (short)1633657295;
				short num2 = num;
				num = (short)467706319;
				switch (num2 == num)
				{
				}
				num = (short)1515913217;
				if (num != 0)
				{
				}
				num = (short)1111097344;
				if (num != 0)
				{
				}
				num = (short)235143168;
				short num3 = num;
				this.radioErgoConfigACAlertInterval_A42877.Min = value;
			}
		}

		// Token: 0x170048FF RID: 18687
		// (get) Token: 0x060090A5 RID: 37029 RVA: 0x008859C4 File Offset: 0x00883BC4
		// (set) Token: 0x060090A6 RID: 37030 RVA: 0x00885A7C File Offset: 0x00883C7C
		internal int RadioErgoConfigACAlertInterval_A42877Max
		{
			get
			{
				short num = (short)2060233754;
				short num2 = num;
				num = (short)1927654426;
				switch (num2 == num)
				{
				}
				num = (short)854654977;
				if (num != 0)
				{
				}
				num = (short)1708785664;
				if (num != 0)
				{
				}
				num = (short)618070016;
				short num3 = num;
				return this.radioErgoConfigACAlertInterval_A42877.Max;
			}
			set
			{
				short num = (short)730568935;
				short num2 = num;
				num = (short)1700567271;
				switch (num2 == num)
				{
				}
				num = (short)503775232;
				if (num != 0)
				{
				}
				num = (short)379912193;
				if (num != 0)
				{
				}
				num = (short)390856704;
				short num3 = num;
				this.radioErgoConfigACAlertInterval_A42877.Max = value;
			}
		}

		// Token: 0x17004900 RID: 18688
		// (get) Token: 0x060090A7 RID: 37031 RVA: 0x00885B30 File Offset: 0x00883D30
		// (set) Token: 0x060090A8 RID: 37032 RVA: 0x00885BE8 File Offset: 0x00883DE8
		internal int RadioErgoConfigACAlertInterval_A42877Step
		{
			get
			{
				short num = (short)1705390572;
				short num2 = num;
				num = (short)655962604;
				switch (num2 == num)
				{
				}
				num = (short)138084353;
				if (num != 0)
				{
				}
				num = (short)244973568;
				if (num != 0)
				{
				}
				num = (short)1860829184;
				short num3 = num;
				return this.radioErgoConfigACAlertInterval_A42877.StepSize;
			}
			set
			{
				short num = (short)720633857;
				if (num != 0)
				{
				}
				num = (short)280045007;
				short num2 = num;
				num = (short)1856120271;
				switch (num2 == num)
				{
				}
				num = (short)706871296;
				if (num != 0)
				{
				}
				num = (short)130285568;
				short num3 = num;
				this.radioErgoConfigACAlertInterval_A42877.StepSize = value;
			}
		}

		// Token: 0x17004901 RID: 18689
		// (get) Token: 0x060090A9 RID: 37033 RVA: 0x00885C9C File Offset: 0x00883E9C
		// (set) Token: 0x060090AA RID: 37034 RVA: 0x00885D50 File Offset: 0x00883F50
		public bool RadioErgoConfigACAlertInterval_A42877_Applicable
		{
			get
			{
				short num = (short)1489502209;
				if (num != 0)
				{
				}
				num = (short)532975772;
				short num2 = num;
				num = (short)986615964;
				switch (num2 == num)
				{
				}
				num = (short)1796472832;
				if (num != 0)
				{
				}
				num = (short)1490747392;
				short num3 = num;
				return this.radioErgoConfigACAlertInterval_A42877.Applicable;
			}
			set
			{
				short num = (short)1579340162;
				short num2 = num;
				num = (short)1823658370;
				switch (num2 == num)
				{
				}
				num = (short)1979514881;
				if (num != 0)
				{
				}
				num = (short)1953628160;
				if (num != 0)
				{
				}
				num = (short)944111616;
				short num3 = num;
				this.radioErgoConfigACAlertInterval_A42877.Applicable = value;
			}
		}

		// Token: 0x17004902 RID: 18690
		// (get) Token: 0x060090AB RID: 37035 RVA: 0x00885E08 File Offset: 0x00884008
		// (set) Token: 0x060090AC RID: 37036 RVA: 0x00885EBC File Offset: 0x008840BC
		public bool RadioErgoConfigACAlertInterval_A42877_Valid
		{
			get
			{
				short num = (short)722556208;
				short num2 = num;
				num = (short)129193264;
				switch (num2 == num)
				{
				}
				num = (short)5636096;
				if (num != 0)
				{
				}
				num = (short)325124097;
				if (num != 0)
				{
				}
				num = (short)1937768448;
				short num3 = num;
				return this.radioErgoConfigACAlertInterval_A42877.Valid;
			}
			set
			{
				short num = (short)1847689668;
				short num2 = num;
				num = (short)636191172;
				switch (num2 == num)
				{
				}
				num = (short)1177092097;
				if (num != 0)
				{
				}
				num = (short)1735327744;
				if (num != 0)
				{
				}
				num = (short)1733689344;
				short num3 = num;
				this.radioErgoConfigACAlertInterval_A42877.Valid = value;
			}
		}

		// Token: 0x17004903 RID: 18691
		// (get) Token: 0x060090AD RID: 37037 RVA: 0x00885F70 File Offset: 0x00884170
		// (set) Token: 0x060090AE RID: 37038 RVA: 0x00886024 File Offset: 0x00884224
		public bool RadioErgoConfigACAlertInterval_A42877_Visible
		{
			get
			{
				short num = (short)1905192765;
				short num2 = num;
				num = (short)970583869;
				switch (num2 == num)
				{
				}
				num = (short)1039990784;
				if (num != 0)
				{
				}
				num = (short)171835393;
				if (num != 0)
				{
				}
				num = (short)1205403648;
				short num3 = num;
				return this.radioErgoConfigACAlertInterval_A42877.Visible;
			}
			set
			{
				short num = (short)1181621649;
				short num2 = num;
				num = (short)99687825;
				switch (num2 == num)
				{
				}
				num = (short)56164353;
				if (num != 0)
				{
				}
				num = (short)966721536;
				if (num != 0)
				{
				}
				num = (short)34078720;
				short num3 = num;
				this.radioErgoConfigACAlertInterval_A42877.Visible = value;
			}
		}

		// Token: 0x17004904 RID: 18692
		// (get) Token: 0x060090AF RID: 37039 RVA: 0x008860DC File Offset: 0x008842DC
		// (set) Token: 0x060090B0 RID: 37040 RVA: 0x00886194 File Offset: 0x00884394
		public bool RadioErgoConfigACAlertInterval_A42877_Editable
		{
			get
			{
				short num = (short)2075359216;
				short num2 = num;
				num = (short)743340016;
				switch (num2 == num)
				{
				}
				num = (short)773390336;
				if (num != 0)
				{
				}
				num = (short)1031536641;
				if (num != 0)
				{
				}
				num = (short)2018050048;
				short num3 = num;
				return this.radioErgoConfigACAlertInterval_A42877.Editable;
			}
			set
			{
				short num = (short)2108125995;
				short num2 = num;
				num = (short)1877046059;
				switch (num2 == num)
				{
				}
				num = (short)1731002369;
				if (num != 0)
				{
				}
				num = (short)142082048;
				if (num != 0)
				{
				}
				num = (short)338034688;
				short num3 = num;
				this.radioErgoConfigACAlertInterval_A42877.Editable = value;
			}
		}

		// Token: 0x17004905 RID: 18693
		// (get) Token: 0x060090B1 RID: 37041 RVA: 0x00886248 File Offset: 0x00884448
		internal string RadioErgoConfigACAlertInterval_A42877_UILabel
		{
			get
			{
				short num = (short)1816460319;
				short num2 = num;
				num = (short)193002527;
				switch (num2 == num)
				{
				}
				num = (short)1921908737;
				if (num != 0)
				{
				}
				num = (short)2130575360;
				if (num != 0)
				{
				}
				num = (short)1377566720;
				short num3 = num;
				return this.radioErgoConfigACAlertInterval_A42877.UIName;
			}
		}

		// Token: 0x17004906 RID: 18694
		// (get) Token: 0x060090B2 RID: 37042 RVA: 0x008862FC File Offset: 0x008844FC
		// (set) Token: 0x060090B3 RID: 37043 RVA: 0x008863B0 File Offset: 0x008845B0
		internal bool RadioErgoConfigACAlertInterval_A42877_HiddenStatic
		{
			get
			{
				short num = (short)57540035;
				short num2 = num;
				num = (short)831126979;
				switch (num2 == num)
				{
				}
				num = (short)1961230336;
				if (num != 0)
				{
				}
				num = (short)468254721;
				if (num != 0)
				{
				}
				num = (short)1312948224;
				short num3 = num;
				return this.radioErgoConfigACAlertInterval_A42877.HiddenStatic;
			}
			set
			{
				short num = (short)1112416691;
				short num2 = num;
				num = (short)1345462707;
				switch (num2 == num)
				{
				}
				num = (short)2094006273;
				if (num != 0)
				{
				}
				num = (short)546111488;
				if (num != 0)
				{
				}
				num = (short)1454899200;
				short num3 = num;
				this.radioErgoConfigACAlertInterval_A42877.HiddenStatic = value;
			}
		}

		// Token: 0x17004907 RID: 18695
		// (get) Token: 0x060090B4 RID: 37044 RVA: 0x00886468 File Offset: 0x00884668
		// (set) Token: 0x060090B5 RID: 37045 RVA: 0x00886520 File Offset: 0x00884720
		internal bool RadioErgoConfigACAlertInterval_A42877_HiddenDynamic
		{
			get
			{
				short num = (short)702283777;
				if (num != 0)
				{
				}
				num = (short)1872001536;
				short num2 = num;
				num = (short)1391557120;
				switch (num2 == num)
				{
				}
				num = (short)2074869760;
				if (num != 0)
				{
				}
				num = (short)688848896;
				short num3 = num;
				return this.radioErgoConfigACAlertInterval_A42877.HiddenDynamic;
			}
			set
			{
				short num = (short)619874180;
				short num2 = num;
				num = (short)1648789380;
				switch (num2 == num)
				{
				default:
				{
					num = (short)223805440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)917504;
				if (num != 0)
				{
				}
				num = (short)1856569345;
				if (num != 0)
				{
				}
				this.radioErgoConfigACAlertInterval_A42877.HiddenDynamic = value;
			}
		}

		// Token: 0x17004908 RID: 18696
		// (get) Token: 0x060090B6 RID: 37046 RVA: 0x008865D8 File Offset: 0x008847D8
		public bool RadioErgoConfigACAlertInterval_A42877_HasDiffs
		{
			get
			{
				short num = (short)1320798216;
				short num2 = num;
				num = (short)1390069768;
				switch (num2 == num)
				{
				default:
				{
					num = (short)992083968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)919732225;
				if (num != 0)
				{
				}
				num = (short)272105472;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACAlertInterval_A42877._HasDiffs;
			}
		}

		// Token: 0x17004909 RID: 18697
		// (get) Token: 0x060090B7 RID: 37047 RVA: 0x0088668C File Offset: 0x0088488C
		// (set) Token: 0x060090B8 RID: 37048 RVA: 0x00886740 File Offset: 0x00884940
		public string RadioErgoConfigACGeneralTEXTMESSAGE_42913Value
		{
			get
			{
				short num = (short)254935041;
				if (num != 0)
				{
				}
				num = (short)1373962240;
				short num2 = num;
				num = (short)1441647316;
				short num3 = num;
				num = (short)627493588;
				switch (num3 == num)
				{
				}
				num = (short)763887616;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTEXTMESSAGE_42913.Value;
			}
			set
			{
				short num = (short)1025386877;
				short num2 = num;
				num = (short)1215703421;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1471152128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)952631297;
				if (num != 0)
				{
				}
				num = (short)1144979456;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralTEXTMESSAGE_42913.Value = value;
			}
		}

		// Token: 0x1700490A RID: 18698
		// (get) Token: 0x060090B9 RID: 37049 RVA: 0x008867F4 File Offset: 0x008849F4
		public global::AcpBusinessLayer.AcpField<string> RadioErgoConfigACGeneralTEXTMESSAGE_42913
		{
			get
			{
				short num = (short)1290806496;
				short num2 = num;
				num = (short)455353568;
				switch (num2 == num)
				{
				default:
				{
					num = (short)151126016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1784807425;
				if (num != 0)
				{
				}
				num = (short)1932591104;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTEXTMESSAGE_42913;
			}
		}

		// Token: 0x1700490B RID: 18699
		// (get) Token: 0x060090BA RID: 37050 RVA: 0x008868A8 File Offset: 0x00884AA8
		// (set) Token: 0x060090BB RID: 37051 RVA: 0x00886958 File Offset: 0x00884B58
		public string RadioErgoConfigACGeneralTEXTMESSAGE_42913_UIValue
		{
			get
			{
				short num = (short)752222209;
				if (num != 0)
				{
				}
				num = (short)295239680;
				short num2 = num;
				num = (short)1925455322;
				short num3 = num;
				num = (short)1153637850;
				switch (num3 == num)
				{
				}
				num = (short)1206583296;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTEXTMESSAGE_42913.Value;
			}
			set
			{
				short num = (short)113435872;
				short num2 = num;
				num = (short)2106647776;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1109262336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)869203969;
				if (num != 0)
				{
				}
				num = (short)703660032;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralTEXTMESSAGE_42913.Value = value;
			}
		}

		// Token: 0x1700490C RID: 18700
		// (get) Token: 0x060090BC RID: 37052 RVA: 0x00886A0C File Offset: 0x00884C0C
		// (set) Token: 0x060090BD RID: 37053 RVA: 0x00886AC4 File Offset: 0x00884CC4
		public bool RadioErgoConfigACGeneralTEXTMESSAGE_42913_Applicable
		{
			get
			{
				short num = (short)492175361;
				if (num != 0)
				{
				}
				num = (short)2047410176;
				short num2 = num;
				num = (short)372428338;
				short num3 = num;
				num = (short)1881198130;
				switch (num3 == num)
				{
				}
				num = (short)386793472;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTEXTMESSAGE_42913.Applicable;
			}
			set
			{
				short num = (short)946043248;
				short num2 = num;
				num = (short)3111280;
				switch (num2 == num)
				{
				default:
				{
					num = (short)420741120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)140574721;
				if (num != 0)
				{
				}
				num = (short)926351360;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralTEXTMESSAGE_42913.Applicable = value;
			}
		}

		// Token: 0x1700490D RID: 18701
		// (get) Token: 0x060090BE RID: 37054 RVA: 0x00886B78 File Offset: 0x00884D78
		// (set) Token: 0x060090BF RID: 37055 RVA: 0x00886C2C File Offset: 0x00884E2C
		public bool RadioErgoConfigACGeneralTEXTMESSAGE_42913_Valid
		{
			get
			{
				short num = (short)35460517;
				short num2 = num;
				num = (short)806557093;
				switch (num2 == num)
				{
				default:
				{
					num = (short)711131136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1822752769;
				if (num != 0)
				{
				}
				num = (short)1679294464;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTEXTMESSAGE_42913.Valid;
			}
			set
			{
				short num = (short)1816536150;
				short num2 = num;
				num = (short)1233658966;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1432485888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1105330177;
				if (num != 0)
				{
				}
				num = (short)1130299392;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralTEXTMESSAGE_42913.Valid = value;
			}
		}

		// Token: 0x1700490E RID: 18702
		// (get) Token: 0x060090C0 RID: 37056 RVA: 0x00886CE0 File Offset: 0x00884EE0
		// (set) Token: 0x060090C1 RID: 37057 RVA: 0x00886D94 File Offset: 0x00884F94
		public bool RadioErgoConfigACGeneralTEXTMESSAGE_42913_Visible
		{
			get
			{
				short num = (short)1981512308;
				short num2 = num;
				num = (short)388659828;
				switch (num2 == num)
				{
				default:
				{
					num = (short)39976960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)658833409;
				if (num != 0)
				{
				}
				num = (short)1087897600;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTEXTMESSAGE_42913.Visible;
			}
			set
			{
				short num = (short)1818030619;
				short num2 = num;
				num = (short)1861677595;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1613168640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)253165569;
				if (num != 0)
				{
				}
				num = (short)1632370688;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralTEXTMESSAGE_42913.Visible = value;
			}
		}

		// Token: 0x1700490F RID: 18703
		// (get) Token: 0x060090C2 RID: 37058 RVA: 0x00886E4C File Offset: 0x0088504C
		// (set) Token: 0x060090C3 RID: 37059 RVA: 0x00886F00 File Offset: 0x00885100
		public bool RadioErgoConfigACGeneralTEXTMESSAGE_42913_Editable
		{
			get
			{
				short num = (short)558969287;
				short num2 = num;
				num = (short)1945645511;
				switch (num2 == num)
				{
				default:
				{
					num = (short)593362944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1316814848;
				if (num != 0)
				{
				}
				num = (short)161415169;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTEXTMESSAGE_42913.Editable;
			}
			set
			{
				short num = (short)1817350830;
				short num2 = num;
				num = (short)1413321390;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1893007360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2013265921;
				if (num != 0)
				{
				}
				num = (short)194904064;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralTEXTMESSAGE_42913.Editable = value;
			}
		}

		// Token: 0x17004910 RID: 18704
		// (get) Token: 0x060090C4 RID: 37060 RVA: 0x00886FB4 File Offset: 0x008851B4
		internal string RadioErgoConfigACGeneralTEXTMESSAGE_42913_UILabel
		{
			get
			{
				short num = (short)53392696;
				short num2 = num;
				num = (short)256554296;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1272905728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1973420032;
				if (num != 0)
				{
				}
				num = (short)1787166721;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTEXTMESSAGE_42913.UIName;
			}
		}

		// Token: 0x17004911 RID: 18705
		// (get) Token: 0x060090C5 RID: 37061 RVA: 0x0088706C File Offset: 0x0088526C
		// (set) Token: 0x060090C6 RID: 37062 RVA: 0x0088711C File Offset: 0x0088531C
		internal bool RadioErgoConfigACGeneralTEXTMESSAGE_42913_HiddenStatic
		{
			get
			{
				short num = (short)1309376513;
				short num2 = num;
				num = (short)1273200641;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1476722688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)209453057;
				if (num != 0)
				{
				}
				num = (short)1261305856;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTEXTMESSAGE_42913.HiddenStatic;
			}
			set
			{
				short num = (short)587268097;
				if (num != 0)
				{
				}
				num = (short)1183711232;
				short num2 = num;
				num = (short)1769095992;
				short num3 = num;
				num = (short)1587692344;
				switch (num3 == num)
				{
				}
				num = (short)56295424;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralTEXTMESSAGE_42913.HiddenStatic = value;
			}
		}

		// Token: 0x17004912 RID: 18706
		// (get) Token: 0x060090C7 RID: 37063 RVA: 0x008871D4 File Offset: 0x008853D4
		// (set) Token: 0x060090C8 RID: 37064 RVA: 0x0088728C File Offset: 0x0088548C
		internal bool RadioErgoConfigACGeneralTEXTMESSAGE_42913_HiddenDynamic
		{
			get
			{
				short num = (short)659030017;
				if (num != 0)
				{
				}
				num = (short)1187905536;
				short num2 = num;
				num = (short)2145591094;
				short num3 = num;
				num = (short)1598627638;
				switch (num3 == num)
				{
				}
				num = (short)2031616;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTEXTMESSAGE_42913.HiddenDynamic;
			}
			set
			{
				short num = (short)1296689693;
				short num2 = num;
				num = (short)1394928157;
				switch (num2 == num)
				{
				default:
				{
					num = (short)345112576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)219086849;
				if (num != 0)
				{
				}
				num = (short)240189440;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralTEXTMESSAGE_42913.HiddenDynamic = value;
			}
		}

		// Token: 0x17004913 RID: 18707
		// (get) Token: 0x060090C9 RID: 37065 RVA: 0x00887344 File Offset: 0x00885544
		public bool RadioErgoConfigACGeneralTEXTMESSAGE_42913_HasDiffs
		{
			get
			{
				short num = (short)1605114711;
				short num2 = num;
				num = (short)827202391;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1115029504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1457061889;
				if (num != 0)
				{
				}
				num = (short)1954414592;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTEXTMESSAGE_42913._HasDiffs;
			}
		}

		// Token: 0x17004914 RID: 18708
		// (get) Token: 0x060090CA RID: 37066 RVA: 0x008873F8 File Offset: 0x008855F8
		// (set) Token: 0x060090CB RID: 37067 RVA: 0x008874AC File Offset: 0x008856AC
		public int RadioErgoConfigACGeneralTxPowerChange__42916Value
		{
			get
			{
				short num = (short)1912703929;
				short num2 = num;
				num = (short)1905232825;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2122842112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2134310913;
				if (num != 0)
				{
				}
				num = (short)1529544704;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTxPowerChange__42916.Value;
			}
			set
			{
				short num = (short)1503058056;
				short num2 = num;
				num = (short)1266079880;
				switch (num2 == num)
				{
				default:
				{
					num = (short)205127680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)60162048;
				if (num != 0)
				{
				}
				num = (short)1764622337;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralTxPowerChange__42916.Value = value;
			}
		}

		// Token: 0x17004915 RID: 18709
		// (get) Token: 0x060090CC RID: 37068 RVA: 0x00887560 File Offset: 0x00885760
		// (set) Token: 0x060090CD RID: 37069 RVA: 0x00887614 File Offset: 0x00885814
		public string RadioErgoConfigACGeneralTxPowerChange__42916_UIValue
		{
			get
			{
				short num = (short)2085355521;
				if (num != 0)
				{
				}
				num = (short)843579392;
				short num2 = num;
				num = (short)1002288923;
				short num3 = num;
				num = (short)1931392795;
				switch (num3 == num)
				{
				}
				num = (short)1258553344;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTxPowerChange__42916.UIValue;
			}
			set
			{
				short num = (short)619813734;
				short num2 = num;
				num = (short)2017172326;
				switch (num2 == num)
				{
				default:
				{
					num = (short)170000384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1674117121;
				if (num != 0)
				{
				}
				num = (short)803733504;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralTxPowerChange__42916.UIValue = value;
			}
		}

		// Token: 0x17004916 RID: 18710
		// (get) Token: 0x060090CE RID: 37070 RVA: 0x008876CC File Offset: 0x008858CC
		public global::AcpBusinessLayer.AcpListField RadioErgoConfigACGeneralTxPowerChange__42916
		{
			get
			{
				short num = (short)1126323971;
				short num2 = num;
				num = (short)692213507;
				switch (num2 == num)
				{
				default:
				{
					num = (short)203161600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)526385152;
				if (num != 0)
				{
				}
				num = (short)1949171713;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTxPowerChange__42916;
			}
		}

		// Token: 0x17004917 RID: 18711
		// (get) Token: 0x060090CF RID: 37071 RVA: 0x0088777C File Offset: 0x0088597C
		// (set) Token: 0x060090D0 RID: 37072 RVA: 0x00887830 File Offset: 0x00885A30
		public bool RadioErgoConfigACGeneralTxPowerChange__42916_Applicable
		{
			get
			{
				short num = (short)957888083;
				short num2 = num;
				num = (short)1844786771;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1512701952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)909312001;
				if (num != 0)
				{
				}
				num = (short)1180434432;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTxPowerChange__42916.Applicable;
			}
			set
			{
				short num = (short)635895809;
				if (num != 0)
				{
				}
				num = (short)1511129088;
				short num2 = num;
				num = (short)958874732;
				short num3 = num;
				num = (short)692995180;
				switch (num3 == num)
				{
				}
				num = (short)172228608;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralTxPowerChange__42916.Applicable = value;
			}
		}

		// Token: 0x17004918 RID: 18712
		// (get) Token: 0x060090D1 RID: 37073 RVA: 0x008878E8 File Offset: 0x00885AE8
		// (set) Token: 0x060090D2 RID: 37074 RVA: 0x0088799C File Offset: 0x00885B9C
		public bool RadioErgoConfigACGeneralTxPowerChange__42916_Valid
		{
			get
			{
				short num = (short)2015726052;
				short num2 = num;
				num = (short)1456966116;
				switch (num2 == num)
				{
				default:
				{
					num = (short)391446528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)779747329;
				if (num != 0)
				{
				}
				num = (short)641859584;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTxPowerChange__42916.Valid;
			}
			set
			{
				short num = (short)1296421992;
				short num2 = num;
				num = (short)1239995496;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1482555392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1083310081;
				if (num != 0)
				{
				}
				num = (short)1858928640;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralTxPowerChange__42916.Valid = value;
			}
		}

		// Token: 0x17004919 RID: 18713
		// (get) Token: 0x060090D3 RID: 37075 RVA: 0x00887A50 File Offset: 0x00885C50
		// (set) Token: 0x060090D4 RID: 37076 RVA: 0x00887B04 File Offset: 0x00885D04
		public bool RadioErgoConfigACGeneralTxPowerChange__42916_Visible
		{
			get
			{
				short num = (short)622982063;
				short num2 = num;
				num = (short)1165030319;
				switch (num2 == num)
				{
				default:
				{
					num = (short)652541952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1902379009;
				if (num != 0)
				{
				}
				num = (short)68747264;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTxPowerChange__42916.Visible;
			}
			set
			{
				short num = (short)373888313;
				short num2 = num;
				num = (short)85923129;
				switch (num2 == num)
				{
				default:
				{
					num = (short)135135232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)489422849;
				if (num != 0)
				{
				}
				num = (short)1021968384;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralTxPowerChange__42916.Visible = value;
			}
		}

		// Token: 0x1700491A RID: 18714
		// (get) Token: 0x060090D5 RID: 37077 RVA: 0x00887BB8 File Offset: 0x00885DB8
		// (set) Token: 0x060090D6 RID: 37078 RVA: 0x00887C6C File Offset: 0x00885E6C
		public bool RadioErgoConfigACGeneralTxPowerChange__42916_Editable
		{
			get
			{
				short num = (short)1489154976;
				short num2 = num;
				num = (short)610579360;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1379270656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1231224832;
				if (num != 0)
				{
				}
				num = (short)558301185;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTxPowerChange__42916.Editable;
			}
			set
			{
				short num = (short)549809222;
				short num2 = num;
				num = (short)104295494;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1551368192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)674365441;
				if (num != 0)
				{
				}
				num = (short)941424640;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralTxPowerChange__42916.Editable = value;
			}
		}

		// Token: 0x1700491B RID: 18715
		// (get) Token: 0x060090D7 RID: 37079 RVA: 0x00887D24 File Offset: 0x00885F24
		internal string RadioErgoConfigACGeneralTxPowerChange__42916_UILabel
		{
			get
			{
				short num = (short)459400474;
				short num2 = num;
				num = (short)428270874;
				switch (num2 == num)
				{
				default:
				{
					num = (short)265420800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1268383745;
				if (num != 0)
				{
				}
				num = (short)1578303488;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTxPowerChange__42916.UIName;
			}
		}

		// Token: 0x1700491C RID: 18716
		// (get) Token: 0x060090D8 RID: 37080 RVA: 0x00887DD8 File Offset: 0x00885FD8
		// (set) Token: 0x060090D9 RID: 37081 RVA: 0x00887E8C File Offset: 0x0088608C
		internal bool RadioErgoConfigACGeneralTxPowerChange__42916_HiddenStatic
		{
			get
			{
				short num = (short)1396705;
				short num2 = num;
				num = (short)877154273;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1456930816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1804402689;
				if (num != 0)
				{
				}
				num = (short)1126629376;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTxPowerChange__42916.HiddenStatic;
			}
			set
			{
				short num = (short)965148673;
				if (num != 0)
				{
				}
				num = (short)495910912;
				short num2 = num;
				num = (short)239778154;
				short num3 = num;
				num = (short)1730656618;
				switch (num3 == num)
				{
				}
				num = (short)901775360;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralTxPowerChange__42916.HiddenStatic = value;
			}
		}

		// Token: 0x1700491D RID: 18717
		// (get) Token: 0x060090DA RID: 37082 RVA: 0x00887F44 File Offset: 0x00886144
		// (set) Token: 0x060090DB RID: 37083 RVA: 0x00887FF8 File Offset: 0x008861F8
		internal bool RadioErgoConfigACGeneralTxPowerChange__42916_HiddenDynamic
		{
			get
			{
				short num = (short)1426128897;
				if (num != 0)
				{
				}
				num = (short)1445462016;
				short num2 = num;
				num = (short)1633087957;
				short num3 = num;
				num = (short)561115605;
				switch (num3 == num)
				{
				}
				num = (short)760741888;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTxPowerChange__42916.HiddenDynamic;
			}
			set
			{
				short num = (short)69172463;
				short num2 = num;
				num = (short)890338543;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1074135040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1577451520;
				if (num != 0)
				{
				}
				num = (short)727646209;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralTxPowerChange__42916.HiddenDynamic = value;
			}
		}

		// Token: 0x1700491E RID: 18718
		// (get) Token: 0x060090DC RID: 37084 RVA: 0x008880B0 File Offset: 0x008862B0
		public bool RadioErgoConfigACGeneralTxPowerChange__42916_HasDiffs
		{
			get
			{
				short num = (short)1680772672;
				short num2 = num;
				num = (short)896634432;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1148911616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)112132097;
				if (num != 0)
				{
				}
				num = (short)646905856;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralTxPowerChange__42916._HasDiffs;
			}
		}

		// Token: 0x1700491F RID: 18719
		// (get) Token: 0x060090DD RID: 37085 RVA: 0x00888164 File Offset: 0x00886364
		// (set) Token: 0x060090DE RID: 37086 RVA: 0x00888218 File Offset: 0x00886418
		public bool RadioErgoConfigACGeneralMuteSSA__42917Value
		{
			get
			{
				short num = (short)409711622;
				short num2 = num;
				num = (short)671134726;
				switch (num2 == num)
				{
				default:
				{
					num = (short)282918912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1939341313;
				if (num != 0)
				{
				}
				num = (short)283705344;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralMuteSSA__42917.Value;
			}
			set
			{
				short num = (short)897016761;
				short num2 = num;
				num = (short)1415603129;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1058930688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1748303873;
				if (num != 0)
				{
				}
				num = (short)1376780288;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralMuteSSA__42917.Value = value;
			}
		}

		// Token: 0x17004920 RID: 18720
		// (get) Token: 0x060090DF RID: 37087 RVA: 0x008882D0 File Offset: 0x008864D0
		public global::AcpBusinessLayer.AcpField<bool> RadioErgoConfigACGeneralMuteSSA__42917
		{
			get
			{
				short num = (short)1119923295;
				short num2 = num;
				num = (short)1626516575;
				switch (num2 == num)
				{
				default:
				{
					num = (short)519110656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1974468609;
				if (num != 0)
				{
				}
				num = (short)2042953728;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralMuteSSA__42917;
			}
		}

		// Token: 0x17004921 RID: 18721
		// (get) Token: 0x060090E0 RID: 37088 RVA: 0x00888384 File Offset: 0x00886584
		// (set) Token: 0x060090E1 RID: 37089 RVA: 0x00888438 File Offset: 0x00886638
		public bool RadioErgoConfigACGeneralMuteSSA__42917_UIValue
		{
			get
			{
				short num = (short)1960934135;
				short num2 = num;
				num = (short)209287927;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1680080896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)228786176;
				if (num != 0)
				{
				}
				num = (short)13303809;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralMuteSSA__42917.Value;
			}
			set
			{
				short num = (short)1308011820;
				short num2 = num;
				num = (short)1821355308;
				switch (num2 == num)
				{
				}
				num = (short)1226244096;
				short num3 = num;
				num = (short)1074462721;
				if (num != 0)
				{
				}
				num = (short)1531707392;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralMuteSSA__42917.Value = value;
			}
		}

		// Token: 0x17004922 RID: 18722
		// (get) Token: 0x060090E2 RID: 37090 RVA: 0x008884F4 File Offset: 0x008866F4
		// (set) Token: 0x060090E3 RID: 37091 RVA: 0x008885A8 File Offset: 0x008867A8
		public bool RadioErgoConfigACGeneralMuteSSA__42917_Applicable
		{
			get
			{
				short num = (short)477682363;
				short num2 = num;
				num = (short)1397021371;
				switch (num2 == num)
				{
				}
				num = (short)1620049920;
				short num3 = num;
				num = (short)1925513217;
				if (num != 0)
				{
				}
				num = (short)2135097344;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralMuteSSA__42917.Applicable;
			}
			set
			{
				short num = (short)1958580137;
				short num2 = num;
				num = (short)1690996649;
				switch (num2 == num)
				{
				}
				num = (short)1161822208;
				short num3 = num;
				num = (short)1046740993;
				if (num != 0)
				{
				}
				num = (short)971964416;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralMuteSSA__42917.Applicable = value;
			}
		}

		// Token: 0x17004923 RID: 18723
		// (get) Token: 0x060090E4 RID: 37092 RVA: 0x00888660 File Offset: 0x00886860
		// (set) Token: 0x060090E5 RID: 37093 RVA: 0x00888714 File Offset: 0x00886914
		public bool RadioErgoConfigACGeneralMuteSSA__42917_Valid
		{
			get
			{
				short num = (short)886816117;
				short num2 = num;
				num = (short)928824693;
				switch (num2 == num)
				{
				}
				num = (short)1476329472;
				short num3 = num;
				num = (short)526254080;
				if (num != 0)
				{
				}
				num = (short)399704065;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralMuteSSA__42917.Valid;
			}
			set
			{
				short num = (short)522291938;
				short num2 = num;
				num = (short)933137122;
				switch (num2 == num)
				{
				}
				num = (short)115277824;
				short num3 = num;
				num = (short)1851129857;
				if (num != 0)
				{
				}
				num = (short)34144256;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralMuteSSA__42917.Valid = value;
			}
		}

		// Token: 0x17004924 RID: 18724
		// (get) Token: 0x060090E6 RID: 37094 RVA: 0x008887C8 File Offset: 0x008869C8
		// (set) Token: 0x060090E7 RID: 37095 RVA: 0x0088887C File Offset: 0x00886A7C
		public bool RadioErgoConfigACGeneralMuteSSA__42917_Visible
		{
			get
			{
				short num = (short)1692123831;
				short num2 = num;
				num = (short)1014416055;
				switch (num2 == num)
				{
				}
				num = (short)716636160;
				short num3 = num;
				num = (short)474152961;
				if (num != 0)
				{
				}
				num = (short)6619136;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralMuteSSA__42917.Visible;
			}
			set
			{
				short num = (short)635826986;
				short num2 = num;
				num = (short)2094854954;
				switch (num2 == num)
				{
				}
				num = (short)1292304384;
				short num3 = num;
				num = (short)469762049;
				if (num != 0)
				{
				}
				num = (short)1708130304;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralMuteSSA__42917.Visible = value;
			}
		}

		// Token: 0x17004925 RID: 18725
		// (get) Token: 0x060090E8 RID: 37096 RVA: 0x00888930 File Offset: 0x00886B30
		// (set) Token: 0x060090E9 RID: 37097 RVA: 0x008889E4 File Offset: 0x00886BE4
		public bool RadioErgoConfigACGeneralMuteSSA__42917_Editable
		{
			get
			{
				short num = (short)116195329;
				if (num != 0)
				{
				}
				num = (short)996260071;
				short num2 = num;
				num = (short)1674623207;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1450704896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1022623744;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralMuteSSA__42917.Editable;
			}
			set
			{
				short num = (short)1439424140;
				short num2 = num;
				num = (short)1586749068;
				switch (num2 == num)
				{
				}
				num = (short)1288634368;
				short num3 = num;
				num = (short)540016640;
				if (num != 0)
				{
				}
				num = (short)510787585;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralMuteSSA__42917.Editable = value;
			}
		}

		// Token: 0x17004926 RID: 18726
		// (get) Token: 0x060090EA RID: 37098 RVA: 0x00888A98 File Offset: 0x00886C98
		internal string RadioErgoConfigACGeneralMuteSSA__42917_UILabel
		{
			get
			{
				short num = (short)592510977;
				if (num != 0)
				{
				}
				num = (short)345257878;
				short num2 = num;
				num = (short)135608214;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1468203008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1073741824;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralMuteSSA__42917.UIName;
			}
		}

		// Token: 0x17004927 RID: 18727
		// (get) Token: 0x060090EB RID: 37099 RVA: 0x00888B50 File Offset: 0x00886D50
		// (set) Token: 0x060090EC RID: 37100 RVA: 0x00888C00 File Offset: 0x00886E00
		internal bool RadioErgoConfigACGeneralMuteSSA__42917_HiddenStatic
		{
			get
			{
				short num = (short)1018191529;
				short num2 = num;
				num = (short)786718377;
				switch (num2 == num)
				{
				}
				num = (short)1604845568;
				short num3 = num;
				num = (short)1443299329;
				if (num != 0)
				{
				}
				num = (short)1563557888;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralMuteSSA__42917.HiddenStatic;
			}
			set
			{
				short num = (short)1708260298;
				short num2 = num;
				num = (short)687471562;
				switch (num2 == num)
				{
				}
				num = (short)462815232;
				short num3 = num;
				num = (short)569966592;
				if (num != 0)
				{
				}
				num = (short)62652417;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralMuteSSA__42917.HiddenStatic = value;
			}
		}

		// Token: 0x17004928 RID: 18728
		// (get) Token: 0x060090ED RID: 37101 RVA: 0x00888CB4 File Offset: 0x00886EB4
		// (set) Token: 0x060090EE RID: 37102 RVA: 0x00888D6C File Offset: 0x00886F6C
		internal bool RadioErgoConfigACGeneralMuteSSA__42917_HiddenDynamic
		{
			get
			{
				short num = (short)1627713408;
				short num2 = num;
				num = (short)651751296;
				switch (num2 == num)
				{
				}
				num = (short)696057856;
				short num3 = num;
				num = (short)120061952;
				if (num != 0)
				{
				}
				num = (short)949747713;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralMuteSSA__42917.HiddenDynamic;
			}
			set
			{
				short num = (short)2056716289;
				if (num != 0)
				{
				}
				num = (short)598545337;
				short num2 = num;
				num = (short)1750668217;
				switch (num2 == num)
				{
				default:
				{
					num = (short)180027392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1120665600;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralMuteSSA__42917.HiddenDynamic = value;
			}
		}

		// Token: 0x17004929 RID: 18729
		// (get) Token: 0x060090EF RID: 37103 RVA: 0x00888E20 File Offset: 0x00887020
		public bool RadioErgoConfigACGeneralMuteSSA__42917_HasDiffs
		{
			get
			{
				short num = (short)1857261079;
				short num2 = num;
				num = (short)95718935;
				switch (num2 == num)
				{
				}
				num = (short)1363804160;
				short num3 = num;
				num = (short)1305608193;
				if (num != 0)
				{
				}
				num = (short)260440064;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralMuteSSA__42917._HasDiffs;
			}
		}

		// Token: 0x060090F0 RID: 37104 RVA: 0x00888ED4 File Offset: 0x008870D4
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					goto IL_CA;
				case 2:
				{
					num2 = (short)1023856092;
					short num3 = num2;
					num2 = (short)644926940;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CA;
					default:
						num2 = (short)1449000960;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)894566400;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)1725956096;
						short num4 = num2;
						num2 = (short)223215620;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					num2 = (short)53084161;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_CA:
				num2 = (short)1372454913;
				if (num2 != 0)
				{
				}
				if (base.ParentRecset.ContainerDoc == null)
				{
					break;
				}
				num2 = (short)1212874754;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1520762883;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400483A RID: 18490
		private global::AcpBusinessLayer.AcpListField radioErgoConfigACActionID_A36590;

		// Token: 0x0400483B RID: 18491
		private global::AcpBusinessLayer.AcpRecRefField radioErgoConfigACGeneralZone_A36592;

		// Token: 0x0400483C RID: 18492
		private global::AcpBusinessLayer.AcpRecRefField radioErgoConfigACGeneralChannel_A36593;

		// Token: 0x0400483D RID: 18493
		private global::AcpBusinessLayer.AcpListField radioErgoConfigACGeneralErrStrategy_A36594;

		// Token: 0x0400483E RID: 18494
		private global::AcpBusinessLayer.AcpSimpleRangeField radioErgoConfigACGeneralIndex_A36591;

		// Token: 0x0400483F RID: 18495
		private global::AcpBusinessLayer.AcpRecRefField radioErgoConfigACAlertAudioFile_A42875;

		// Token: 0x04004840 RID: 18496
		private global::AcpBusinessLayer.AcpCustomRangeField radioErgoConfigACAlertInterval_A42877;

		// Token: 0x04004841 RID: 18497
		private global::AcpBusinessLayer.AcpField<string> radioErgoConfigACGeneralTEXTMESSAGE_42913;

		// Token: 0x04004842 RID: 18498
		private global::AcpBusinessLayer.AcpListField radioErgoConfigACGeneralTxPowerChange__42916;

		// Token: 0x04004843 RID: 18499
		private global::AcpBusinessLayer.AcpField<bool> radioErgoConfigACGeneralMuteSSA__42917;
	}
}
