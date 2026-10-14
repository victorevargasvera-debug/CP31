using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO7
{
	// Token: 0x0200039B RID: 923
	[global::System.Serializable]
	public class O7DataButtonInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060086D6 RID: 34518 RVA: 0x007DB978 File Offset: 0x007D9B78
		public O7DataButtonInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060086D7 RID: 34519 RVA: 0x007DB994 File Offset: 0x007D9B94
		protected O7DataButtonInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060086D8 RID: 34520 RVA: 0x007DB9AC File Offset: 0x007D9BAC
		public override void Init()
		{
			int a_ = 0;
			short num = (short)1739128832;
			short num2 = num;
			num = (short)190361352;
			short num3 = num;
			num = (short)640397064;
			switch (num3 == num)
			{
			}
			num = (short)722665472;
			if (num != 0)
			{
			}
			num = (short)1282539521;
			if (num != 0)
			{
			}
			this.radErgCtrlHeadO7DataButtonName_A41296 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_DATABUTTON_1, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊軌믎ꏐ뿒鷔닖룘뿚鋜ꗠ苢釤蛦ꯨ黪駬鯮黰鷲믴零铸黺ꋼ뻾㔀㈂㜄㸆㼈", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.radErgCtrlHeadO7DataButtonName_A41296.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgCtrlHeadO7DataButtonName_A41296.DataTransferOrder = -1;
			this.radErgCtrlHeadO7DataButtonTrkFeature_A41297 = new global::AcpBusinessLayer.AcpSparseLOVField(161, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.indexRadErgCtrlHeadO7DataButtonTrkFeature_A41297LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.idRadErgCtrlHeadO7DataButtonTrkFeature_A41297LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊軌믎ꏐ뿒鷔닖룘뿚鋜ꗠ苢釤蛦ꯨ黪駬鯮黰鷲ꇴ藶鋸뷺飼黾甀瘂眄戆嘈䨊㤌㸎⌐⨒∔", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.RadErgCtrlHeadO7DataButtonTrkFeature_A41297LovStrs);
			this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.DataTransferOrder = 19;
			this.radErgCtrlHeadO7DataButtonTrkBCO_A41298 = new global::AcpBusinessLayer.AcpSparseLOVField(134, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.indexRadErgCtrlHeadO7DataButtonTrkBCO_A41298LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.idRadErgCtrlHeadO7DataButtonTrkBCO_A41298LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊軌믎ꏐ뿒鷔닖룘뿚鋜ꗠ苢釤蛦ꯨ黪駬鯮黰鷲ꇴ藶鋸맺뻼냾帀䈂㄄㘆㬈㈊㔌", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.RadErgCtrlHeadO7DataButtonTrkBCO_A41298LovStrs);
			this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.IgnoreOnCompare = true;
			this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.DataTransferOrder = -1;
			this.radErgCtrlHeadO7DataButtonCnvFeature_A41299 = new global::AcpBusinessLayer.AcpSparseLOVField(161, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.indexRadErgCtrlHeadO7DataButtonCnvFeature_A41299LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.idRadErgCtrlHeadO7DataButtonCnvFeature_A41299LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊軌믎ꏐ뿒鷔닖룘뿚鋜ꗠ苢釤蛦ꯨ黪駬鯮黰鷲뛴駶迸뷺飼黾甀瘂眄戆嘈䨊㤌㸎⌐⨒Ⱄ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.RadErgCtrlHeadO7DataButtonCnvFeature_A41299LovStrs);
			this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.DataTransferOrder = 3;
			this.radErgCtrlHeadO7DataButtonCnvBCO_A41300 = new global::AcpBusinessLayer.AcpSparseLOVField(134, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.indexRadErgCtrlHeadO7DataButtonCnvBCO_A41300LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.idRadErgCtrlHeadO7DataButtonCnvBCO_A41300LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊軌믎ꏐ뿒鷔닖룘뿚鋜ꗠ苢釤蛦ꯨ黪駬鯮黰鷲뛴駶迸맺뻼냾帀䈂㄄㘆㨈㬊㴌", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.RadErgCtrlHeadO7DataButtonCnvBCO_A41300LovStrs);
			this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.IgnoreOnCompare = true;
			this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.DataTransferOrder = -1;
			this.cHO7DataButtonConvIndex_A41417 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("苀诂諄跈꫊만껎鏐ꛒꇔꏖ뛘뗚黜냞迠闢곤触跨軪闬냮냰쟲쓴쏶죸쳺", a_), global::CommonResources.AcgResources.ID_CONVENTIONALINDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.cHO7DataButtonConvIndex_A41417.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO7DataButtonConvIndex_A41417.DataTransferOrder = 5;
			this.cHO7DataButtonTrkIndex_A41418 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("苀诂諄跈꫊만껎鏐ꛒꇔꏖ뛘뗚觜귞諠ꫢ诤菦賨鏪달껮연싲쇴웶쇸", a_), global::CommonResources.AcgResources.ID_TRUNKINGINDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.cHO7DataButtonTrkIndex_A41418.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO7DataButtonTrkIndex_A41418.DataTransferOrder = 7;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ觊료믎ꗐ볒믔", a_);
			base.Id = 10713;
			base.UIName = global::CommonResources.AcgResources.ID_DATABUTTON_1;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060086D9 RID: 34521 RVA: 0x007DBCC0 File Offset: 0x007D9EC0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 13;
			short num = (short)542179340;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.radErgCtrlHeadO7DataButtonCnvFeature_A41299 = new global::AcpBusinessLayer.AcpSparseLOVField(161, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.indexRadErgCtrlHeadO7DataButtonCnvFeature_A41299LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.idRadErgCtrlHeadO7DataButtonCnvFeature_A41299LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗駙꣛곝賟ꫡ臣蟥賧ꗩ\udbebꫭ釯蛱闳듵跷軹裻釽滿䄁樃瀅万漉洋稍攏怑焓䤕夗⸙ⴛⰝ᤟ᬡ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.RadErgCtrlHeadO7DataButtonCnvFeature_A41299LovStrs);
					this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.DataTransferOrder = 3;
					num = (short)1123549187;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.radErgCtrlHeadO7DataButtonName_A41296 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_DATABUTTON_1, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗駙꣛곝賟ꫡ臣蟥賧ꗩ\udbebꫭ釯蛱闳듵跷軹裻釽滿䰁攃欅洇唉䴋㨍ℏ‑ⴓ―", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.radErgCtrlHeadO7DataButtonName_A41296.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgCtrlHeadO7DataButtonName_A41296.DataTransferOrder = -1;
					num = (short)59047938;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_406;
				case 3:
					goto IL_2AF;
				case 4:
				{
					num = (short)1478426624;
					short num3 = num;
					this.cHO7DataButtonTrkIndex_A41418 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("跍飏鷑鋕맗껙뷛鳝闟雡郣觥蛧뻩黫藭맯鳱郳鏵胷ꗹ뷻쫽ㇿ㘁㔃㸅", a_), global::CommonResources.AcgResources.ID_TRUNKINGINDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.cHO7DataButtonTrkIndex_A41418.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHO7DataButtonTrkIndex_A41418.DataTransferOrder = 7;
					num = (short)1987313669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_389;
				case 6:
					num = (short)125960209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					this.radErgCtrlHeadO7DataButtonTrkBCO_A41298 = new global::AcpBusinessLayer.AcpSparseLOVField(134, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.indexRadErgCtrlHeadO7DataButtonTrkBCO_A41298LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.idRadErgCtrlHeadO7DataButtonTrkBCO_A41298LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗駙꣛곝賟ꫡ臣蟥賧ꗩ\udbebꫭ釯蛱闳듵跷軹裻釽滿嘁瘃洅䨇䤉䌋儍儏☑┓␕℗∙", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.RadErgCtrlHeadO7DataButtonTrkBCO_A41298LovStrs);
					this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.IgnoreOnCompare = true;
					this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.DataTransferOrder = -1;
					num = (short)927793162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_454;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗駙꣛곝賟ꫡ臣蟥賧ꗩ\udbebꫭ釯蛱闳듵跷軹裻釽滿嘁瘃洅万漉洋稍攏怑焓䤕夗⸙ⴛⰝ᤟ᔡ", a_)))
					{
						num = (short)598474770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_606;
				case 10:
					goto IL_651;
				case 11:
					goto IL_4A2;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_92;
					}
					continue;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗駙꣛곝賟ꫡ臣蟥賧ꗩ\udbebꫭ釯蛱闳듵跷軹裻釽滿嘁瘃洅䨇䤉䌋儍儏☑┓␕℗∙", a_)))
					{
						num = (short)1735327751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_651;
				case 14:
					this.cHO7DataButtonConvIndex_A41417 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("跍飏鷑鋕맗껙뷛鳝闟雡郣觥蛧ꧩ菫胭蛯믱髳鋵鷷苹ꏻ뿽㓿㌁〃㜅㼇", a_), global::CommonResources.AcgResources.ID_CONVENTIONALINDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.cHO7DataButtonConvIndex_A41417.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHO7DataButtonConvIndex_A41417.DataTransferOrder = 5;
					num = (short)14155784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (producerFields != null)
					{
						num = (short)954990598;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_69D;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍飏鷑鋕맗껙뷛鳝闟雡郣觥蛧ꧩ菫胭蛯믱髳鋵鷷苹ꏻ뿽㓿㌁〃㜅㼇", a_)))
					{
						num = (short)1035534350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_454;
				case 17:
					goto IL_279;
				case 18:
				{
					this.radErgCtrlHeadO7DataButtonTrkFeature_A41297 = new global::AcpBusinessLayer.AcpSparseLOVField(161, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.indexRadErgCtrlHeadO7DataButtonTrkFeature_A41297LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.idRadErgCtrlHeadO7DataButtonTrkFeature_A41297LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗駙꣛곝賟ꫡ臣蟥賧ꗩ\udbebꫭ釯蛱闳듵跷軹裻釽滿嘁瘃洅万漉洋稍攏怑焓䤕夗⸙ⴛⰝ᤟ᔡ", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.RadErgCtrlHeadO7DataButtonTrkFeature_A41297LovStrs);
					this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.DataTransferOrder = 19;
					num = (short)254232284;
					short num4 = num;
					num = (short)1393051356;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_279;
					default:
						num = (short)1632043009;
						if (num != 0)
						{
						}
						num = (short)559546368;
						if (num != 0)
						{
						}
						num = (short)448921624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗駙꣛곝賟ꫡ臣蟥賧ꗩ\udbebꫭ釯蛱闳듵跷軹裻釽滿䄁樃瀅万漉洋稍攏怑焓䤕夗⸙ⴛⰝ᤟ᬡ", a_)))
					{
						num = (short)133890048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AF;
				case 20:
					num = (short)2111438863;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍飏鷑鋕맗껙뷛鳝闟雡郣觥蛧뻩黫藭맯鳱郳鏵胷ꗹ뷻쫽ㇿ㘁㔃㸅", a_)))
					{
						num = (short)61276164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_69D;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗駙꣛곝賟ꫡ臣蟥賧ꗩ\udbebꫭ釯蛱闳듵跷軹裻釽滿䄁樃瀅䨇䤉䌋儍儏☑┓┕⠗⨙", a_)))
					{
						num = (short)1855062039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4A2;
				case 23:
					this.radErgCtrlHeadO7DataButtonCnvBCO_A41300 = new global::AcpBusinessLayer.AcpSparseLOVField(134, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.indexRadErgCtrlHeadO7DataButtonCnvBCO_A41300LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.idRadErgCtrlHeadO7DataButtonCnvBCO_A41300LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗駙꣛곝賟ꫡ臣蟥賧ꗩ\udbebꫭ釯蛱闳듵跷軹裻釽滿䄁樃瀅䨇䤉䌋儍儏☑┓┕⠗⨙", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.RadErgCtrlHeadO7DataButtonCnvBCO_A41300LovStrs);
					this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.IgnoreOnCompare = true;
					this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.DataTransferOrder = -1;
					num = (short)723845131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					goto IL_606;
				}
				IL_92:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1836515348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_279:
				if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗駙꣛곝賟ꫡ臣蟥賧ꗩ\udbebꫭ釯蛱闳듵跷軹裻釽滿䰁攃欅洇唉䴋㨍ℏ‑ⴓ―", a_)))
				{
					num = (short)325320705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_406;
				IL_2AF:
				num = (short)1310130198;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_406:
				num = (short)1244463113;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_454:
				num = (short)1720844309;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4A2:
				num = (short)413663248;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_606:
				num = (short)1702559757;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_651:
				num = (short)589365267;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_389:
			IL_69D:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諍뇏ꛑ뗓髗꿙꣛ꫝ迟賡", a_);
			base.Id = 10713;
			base.UIName = global::CommonResources.AcgResources.ID_DATABUTTON_1;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060086DA RID: 34522 RVA: 0x007DC39C File Offset: 0x007DA59C
		public override void PopulateReferences()
		{
			short num = (short)347799552;
			short num2 = num;
			num = (short)794953221;
			short num3 = num;
			num = (short)1940784645;
			switch (num3 == num)
			{
			}
			num = (short)1210056705;
			if (num != 0)
			{
			}
			num = (short)1768488960;
			if (num != 0)
			{
			}
			this.cHO7DataButtonConvIndex_A41417.SetRecset(this.a(4008));
			this.cHO7DataButtonTrkIndex_A41418.SetRecset(this.a(4008));
		}

		// Token: 0x060086DB RID: 34523 RVA: 0x007DC474 File Offset: 0x007DA674
		public override void DropReferences()
		{
			short num = (short)885653504;
			short num2 = num;
			num = (short)1332915165;
			short num3 = num;
			num = (short)1389865949;
			switch (num3 == num)
			{
			}
			num = (short)1622081537;
			if (num != 0)
			{
			}
			num = (short)1390477312;
			if (num != 0)
			{
			}
		}

		// Token: 0x060086DC RID: 34524 RVA: 0x007DC520 File Offset: 0x007DA720
		public override void SetConstraints()
		{
			short num = (short)783089664;
			short num2 = num;
			num = (short)239624299;
			short num3 = num;
			num = (short)2073452651;
			switch (num3 == num)
			{
			}
			num = (short)1898315777;
			if (num != 0)
			{
			}
			num = (short)2090205184;
			if (num != 0)
			{
			}
			this.radErgCtrlHeadO7DataButtonName_A41296.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.conDataBtnTrkFeatureValid);
			this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.ConSyncTrkDataBtnFeature);
			this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.conDataBtnConvFeatureValid);
			this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.ConSyncCnvDataBtnFeature);
			this.cHO7DataButtonConvIndex_A41417.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.ConO7DataButtonConvIndexApplicable);
			this.cHO7DataButtonConvIndex_A41417.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.ConDataButtonIndexValid);
			this.cHO7DataButtonConvIndex_A41417.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.ConValueSetIfDataCnvIndexChanged);
			this.cHO7DataButtonTrkIndex_A41418.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.ConO7DataButtonTrkIndexApplicable);
			this.cHO7DataButtonTrkIndex_A41418.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.ConDataButtonIndexValid);
			this.cHO7DataButtonTrkIndex_A41418.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.ConValueSetIfDataTrkIndexChanged);
		}

		// Token: 0x060086DD RID: 34525 RVA: 0x007DC6C4 File Offset: 0x007DA8C4
		public override void SetupDependencies()
		{
			short num = (short)2073165824;
			short num2 = num;
			num = (short)1126233089;
			short num3 = num;
			num = (short)1849750529;
			switch (num3 == num)
			{
			}
			num = (short)1045757952;
			if (num != 0)
			{
			}
			num = (short)777191425;
			if (num != 0)
			{
			}
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgCtrlHeadO7DataButtonTrkFeature_A41297);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgCtrlHeadO7DataButtonCnvFeature_A41299);
			this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.AddDependentObject(this.cHO7DataButtonConvIndex_A41417);
			this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.AddDependentObject(this.cHO7DataButtonTrkIndex_A41418);
		}

		// Token: 0x17004492 RID: 17554
		// (get) Token: 0x060086DE RID: 34526 RVA: 0x007DC7C8 File Offset: 0x007DA9C8
		public global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation ActionConsolidationForCHO7DataButtonConvIndex_A41417
		{
			get
			{
				short num = (short)1180631040;
				short num2 = num;
				num = (short)243817285;
				short num3 = num;
				num = (short)1899518789;
				switch (num3 == num)
				{
				}
				num = (short)830799873;
				if (num != 0)
				{
				}
				num = (short)597295104;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonConvIndex_A41417.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation;
			}
		}

		// Token: 0x17004493 RID: 17555
		// (get) Token: 0x060086DF RID: 34527 RVA: 0x007DC884 File Offset: 0x007DAA84
		public global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation ActionConsolidationForCHO7DataButtonTrkIndex_A41418
		{
			get
			{
				short num = (short)727318528;
				short num2 = num;
				num = (short)1374084069;
				short num3 = num;
				num = (short)2133842917;
				switch (num3 == num)
				{
				}
				num = (short)832438273;
				if (num != 0)
				{
				}
				num = (short)70713344;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonTrkIndex_A41418.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation;
			}
		}

		// Token: 0x17004494 RID: 17556
		// (get) Token: 0x060086E0 RID: 34528 RVA: 0x007DC93C File Offset: 0x007DAB3C
		public bool HasDiffs
		{
			get
			{
				short num = (short)928972800;
				short num2 = num;
				num = (short)1040496133;
				short num3 = num;
				num = (short)134067717;
				switch (num3 == num)
				{
				}
				num = (short)832962560;
				if (num != 0)
				{
				}
				num = (short)1955332097;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004495 RID: 17557
		// (get) Token: 0x060086E1 RID: 34529 RVA: 0x007DC9E8 File Offset: 0x007DABE8
		// (set) Token: 0x060086E2 RID: 34530 RVA: 0x007DCA9C File Offset: 0x007DAC9C
		public string RadErgCtrlHeadO7DataButtonName_A41296Value
		{
			get
			{
				short num = (short)1310982144;
				short num2 = num;
				num = (short)820518274;
				short num3 = num;
				num = (short)1753685378;
				switch (num3 == num)
				{
				}
				num = (short)352976897;
				if (num != 0)
				{
				}
				num = (short)243466240;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonName_A41296.Value;
			}
			set
			{
				short num = (short)1402339328;
				short num2 = num;
				num = (short)1900008145;
				short num3 = num;
				num = (short)381539025;
				switch (num3 == num)
				{
				}
				num = (short)255131649;
				if (num != 0)
				{
				}
				num = (short)930611200;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonName_A41296.Value = value;
			}
		}

		// Token: 0x17004496 RID: 17558
		// (get) Token: 0x060086E3 RID: 34531 RVA: 0x007DCB54 File Offset: 0x007DAD54
		public global::AcpBusinessLayer.AcpField<string> RadErgCtrlHeadO7DataButtonName_A41296
		{
			get
			{
				short num = (short)1822752768;
				short num2 = num;
				num = (short)673841153;
				if (num != 0)
				{
				}
				num = (short)2039600816;
				short num3 = num;
				num = (short)1994446512;
				switch (num3 == num)
				{
				}
				num = (short)1493237760;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonName_A41296;
			}
		}

		// Token: 0x17004497 RID: 17559
		// (get) Token: 0x060086E4 RID: 34532 RVA: 0x007DCC04 File Offset: 0x007DAE04
		// (set) Token: 0x060086E5 RID: 34533 RVA: 0x007DCCBC File Offset: 0x007DAEBC
		public string RadErgCtrlHeadO7DataButtonName_A41296_UIValue
		{
			get
			{
				short num = (short)857997312;
				short num2 = num;
				num = (short)1637476984;
				short num3 = num;
				num = (short)2104224376;
				switch (num3 == num)
				{
				}
				num = (short)21102593;
				if (num != 0)
				{
				}
				num = (short)1594556416;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonName_A41296.Value;
			}
			set
			{
				short num = (short)712441856;
				short num2 = num;
				num = (short)1035833707;
				short num3 = num;
				num = (short)181899627;
				switch (num3 == num)
				{
				}
				num = (short)1237188609;
				if (num != 0)
				{
				}
				num = (short)1090125824;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonName_A41296.Value = value;
			}
		}

		// Token: 0x17004498 RID: 17560
		// (get) Token: 0x060086E6 RID: 34534 RVA: 0x007DCD74 File Offset: 0x007DAF74
		// (set) Token: 0x060086E7 RID: 34535 RVA: 0x007DCE28 File Offset: 0x007DB028
		public bool RadErgCtrlHeadO7DataButtonName_A41296_Applicable
		{
			get
			{
				short num = (short)1238433792;
				short num2 = num;
				num = (short)1612578817;
				if (num != 0)
				{
				}
				num = (short)1518304972;
				short num3 = num;
				num = (short)902463180;
				switch (num3 == num)
				{
				}
				num = (short)1403322368;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonName_A41296.Applicable;
			}
			set
			{
				short num = (short)1802371072;
				short num2 = num;
				num = (short)1180465115;
				short num3 = num;
				num = (short)1376548827;
				switch (num3 == num)
				{
				}
				num = (short)767033344;
				if (num != 0)
				{
				}
				num = (short)778829825;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonName_A41296.Applicable = value;
			}
		}

		// Token: 0x17004499 RID: 17561
		// (get) Token: 0x060086E8 RID: 34536 RVA: 0x007DCEDC File Offset: 0x007DB0DC
		// (set) Token: 0x060086E9 RID: 34537 RVA: 0x007DCF94 File Offset: 0x007DB194
		public bool RadErgCtrlHeadO7DataButtonName_A41296_Valid
		{
			get
			{
				short num = (short)1188823040;
				short num2 = num;
				num = (short)1013972993;
				if (num != 0)
				{
				}
				num = (short)592468539;
				short num3 = num;
				num = (short)1170102843;
				switch (num3 == num)
				{
				}
				num = (short)1170866176;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonName_A41296.Valid;
			}
			set
			{
				short num = (short)2075066368;
				short num2 = num;
				num = (short)907708507;
				short num3 = num;
				num = (short)450332763;
				switch (num3 == num)
				{
				}
				num = (short)1151533057;
				if (num != 0)
				{
				}
				num = (short)833814528;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonName_A41296.Valid = value;
			}
		}

		// Token: 0x1700449A RID: 17562
		// (get) Token: 0x060086EA RID: 34538 RVA: 0x007DD04C File Offset: 0x007DB24C
		// (set) Token: 0x060086EB RID: 34539 RVA: 0x007DD100 File Offset: 0x007DB300
		public bool RadErgCtrlHeadO7DataButtonName_A41296_Visible
		{
			get
			{
				short num = (short)1898250240;
				short num2 = num;
				num = (short)1928607570;
				short num3 = num;
				num = (short)525940562;
				switch (num3 == num)
				{
				}
				num = (short)1895038976;
				if (num != 0)
				{
				}
				num = (short)1423966209;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonName_A41296.Visible;
			}
			set
			{
				short num = (short)1088946176;
				short num2 = num;
				num = (short)1249026404;
				short num3 = num;
				num = (short)1110221156;
				switch (num3 == num)
				{
				}
				num = (short)2123956224;
				if (num != 0)
				{
				}
				num = (short)1987575809;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonName_A41296.Visible = value;
			}
		}

		// Token: 0x1700449B RID: 17563
		// (get) Token: 0x060086EC RID: 34540 RVA: 0x007DD1B4 File Offset: 0x007DB3B4
		// (set) Token: 0x060086ED RID: 34541 RVA: 0x007DD26C File Offset: 0x007DB46C
		public bool RadErgCtrlHeadO7DataButtonName_A41296_Editable
		{
			get
			{
				short num = (short)75366400;
				short num2 = num;
				num = (short)1150129390;
				short num3 = num;
				num = (short)717198574;
				switch (num3 == num)
				{
				}
				num = (short)1618280449;
				if (num != 0)
				{
				}
				num = (short)33751040;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonName_A41296.Editable;
			}
			set
			{
				short num = (short)1135542272;
				short num2 = num;
				num = (short)53909317;
				short num3 = num;
				num = (short)1426822981;
				switch (num3 == num)
				{
				}
				num = (short)1486618624;
				if (num != 0)
				{
				}
				num = (short)342360065;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonName_A41296.Editable = value;
			}
		}

		// Token: 0x1700449C RID: 17564
		// (get) Token: 0x060086EE RID: 34542 RVA: 0x007DD320 File Offset: 0x007DB520
		internal string RadErgCtrlHeadO7DataButtonName_A41296_UILabel
		{
			get
			{
				short num = (short)1854865408;
				short num2 = num;
				num = (short)1550727052;
				short num3 = num;
				num = (short)1603090316;
				switch (num3 == num)
				{
				}
				num = (short)1625292801;
				if (num != 0)
				{
				}
				num = (short)837353472;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonName_A41296.UIName;
			}
		}

		// Token: 0x1700449D RID: 17565
		// (get) Token: 0x060086EF RID: 34543 RVA: 0x007DD3D4 File Offset: 0x007DB5D4
		// (set) Token: 0x060086F0 RID: 34544 RVA: 0x007DD488 File Offset: 0x007DB688
		internal bool RadErgCtrlHeadO7DataButtonName_A41296_HiddenStatic
		{
			get
			{
				short num = (short)862519296;
				short num2 = num;
				num = (short)1719468033;
				if (num != 0)
				{
				}
				num = (short)2020077690;
				short num3 = num;
				num = (short)1973219450;
				switch (num3 == num)
				{
				}
				num = (short)1696727040;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonName_A41296.HiddenStatic;
			}
			set
			{
				short num = (short)121044992;
				short num2 = num;
				num = (short)280344759;
				short num3 = num;
				num = (short)302823607;
				switch (num3 == num)
				{
				}
				num = (short)697892865;
				if (num != 0)
				{
				}
				num = (short)1151336448;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonName_A41296.HiddenStatic = value;
			}
		}

		// Token: 0x1700449E RID: 17566
		// (get) Token: 0x060086F1 RID: 34545 RVA: 0x007DD53C File Offset: 0x007DB73C
		// (set) Token: 0x060086F2 RID: 34546 RVA: 0x007DD5F4 File Offset: 0x007DB7F4
		internal bool RadErgCtrlHeadO7DataButtonName_A41296_HiddenDynamic
		{
			get
			{
				short num = (short)861536256;
				short num2 = num;
				num = (short)1363086227;
				short num3 = num;
				num = (short)1072827283;
				switch (num3 == num)
				{
				}
				num = (short)374013952;
				if (num != 0)
				{
				}
				num = (short)784531457;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonName_A41296.HiddenDynamic;
			}
			set
			{
				short num = (short)1473904640;
				short num2 = num;
				num = (short)1275461633;
				if (num != 0)
				{
				}
				num = (short)506705802;
				short num3 = num;
				num = (short)856209290;
				switch (num3 == num)
				{
				}
				num = (short)1393950720;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonName_A41296.HiddenDynamic = value;
			}
		}

		// Token: 0x1700449F RID: 17567
		// (get) Token: 0x060086F3 RID: 34547 RVA: 0x007DD6AC File Offset: 0x007DB8AC
		public bool RadErgCtrlHeadO7DataButtonName_A41296_HasDiffs
		{
			get
			{
				short num = (short)1689255936;
				short num2 = num;
				num = (short)789781992;
				short num3 = num;
				num = (short)985275880;
				switch (num3 == num)
				{
				}
				num = (short)634322944;
				if (num != 0)
				{
				}
				num = (short)1458241537;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonName_A41296._HasDiffs;
			}
		}

		// Token: 0x170044A0 RID: 17568
		// (get) Token: 0x060086F4 RID: 34548 RVA: 0x007DD760 File Offset: 0x007DB960
		// (set) Token: 0x060086F5 RID: 34549 RVA: 0x007DD814 File Offset: 0x007DBA14
		public int RadErgCtrlHeadO7DataButtonTrkFeature_A41297Value
		{
			get
			{
				short num = (short)996802560;
				short num2 = num;
				num = (short)1541172146;
				short num3 = num;
				num = (short)1816685490;
				switch (num3 == num)
				{
				}
				num = (short)1327955969;
				if (num != 0)
				{
				}
				num = (short)171114496;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.Value;
			}
			set
			{
				short num = (short)2037776384;
				short num2 = num;
				num = (short)213894545;
				short num3 = num;
				num = (short)2005976465;
				switch (num3 == num)
				{
				}
				num = (short)1380777984;
				if (num != 0)
				{
				}
				num = (short)1189609473;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.Value = value;
			}
		}

		// Token: 0x170044A1 RID: 17569
		// (get) Token: 0x060086F6 RID: 34550 RVA: 0x007DD8C8 File Offset: 0x007DBAC8
		// (set) Token: 0x060086F7 RID: 34551 RVA: 0x007DD980 File Offset: 0x007DBB80
		public string RadErgCtrlHeadO7DataButtonTrkFeature_A41297_UIValue
		{
			get
			{
				short num = (short)375848960;
				short num2 = num;
				num = (short)1863181941;
				short num3 = num;
				num = (short)1095296629;
				switch (num3 == num)
				{
				}
				num = (short)544538625;
				if (num != 0)
				{
				}
				num = (short)2075197440;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.UIValue;
			}
			set
			{
				short num = (short)579796992;
				short num2 = num;
				num = (short)1786722558;
				short num3 = num;
				num = (short)1882536190;
				switch (num3 == num)
				{
				}
				num = (short)878641153;
				if (num != 0)
				{
				}
				num = (short)1160118272;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.UIValue = value;
			}
		}

		// Token: 0x170044A2 RID: 17570
		// (get) Token: 0x060086F8 RID: 34552 RVA: 0x007DDA38 File Offset: 0x007DBC38
		public global::AcpBusinessLayer.AcpListField RadErgCtrlHeadO7DataButtonTrkFeature_A41297
		{
			get
			{
				short num = (short)1626603520;
				short num2 = num;
				num = (short)719731909;
				short num3 = num;
				num = (short)98843845;
				switch (num3 == num)
				{
				}
				num = (short)1521418240;
				if (num != 0)
				{
				}
				num = (short)2118975489;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkFeature_A41297;
			}
		}

		// Token: 0x170044A3 RID: 17571
		// (get) Token: 0x060086F9 RID: 34553 RVA: 0x007DDAE8 File Offset: 0x007DBCE8
		// (set) Token: 0x060086FA RID: 34554 RVA: 0x007DDBA0 File Offset: 0x007DBDA0
		public bool RadErgCtrlHeadO7DataButtonTrkFeature_A41297_Applicable
		{
			get
			{
				short num = (short)1278738432;
				short num2 = num;
				num = (short)1834829797;
				short num3 = num;
				num = (short)938297317;
				switch (num3 == num)
				{
				}
				num = (short)1531248640;
				if (num != 0)
				{
				}
				num = (short)1644494849;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.Applicable;
			}
			set
			{
				short num = (short)1977286656;
				short num2 = num;
				num = (short)1291736637;
				short num3 = num;
				num = (short)1887458877;
				switch (num3 == num)
				{
				}
				num = (short)1811021824;
				if (num != 0)
				{
				}
				num = (short)1053229057;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.Applicable = value;
			}
		}

		// Token: 0x170044A4 RID: 17572
		// (get) Token: 0x060086FB RID: 34555 RVA: 0x007DDC58 File Offset: 0x007DBE58
		// (set) Token: 0x060086FC RID: 34556 RVA: 0x007DDD10 File Offset: 0x007DBF10
		public bool RadErgCtrlHeadO7DataButtonTrkFeature_A41297_Valid
		{
			get
			{
				short num = (short)2127757312;
				short num2 = num;
				num = (short)1450697138;
				short num3 = num;
				num = (short)1885987250;
				switch (num3 == num)
				{
				}
				num = (short)199294977;
				if (num != 0)
				{
				}
				num = (short)1932984320;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.Valid;
			}
			set
			{
				short num = (short)435617792;
				short num2 = num;
				num = (short)1142896310;
				short num3 = num;
				num = (short)1244673718;
				switch (num3 == num)
				{
				}
				num = (short)1081081857;
				if (num != 0)
				{
				}
				num = (short)1918828544;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.Valid = value;
			}
		}

		// Token: 0x170044A5 RID: 17573
		// (get) Token: 0x060086FD RID: 34557 RVA: 0x007DDDC4 File Offset: 0x007DBFC4
		// (set) Token: 0x060086FE RID: 34558 RVA: 0x007DDE74 File Offset: 0x007DC074
		public bool RadErgCtrlHeadO7DataButtonTrkFeature_A41297_Visible
		{
			get
			{
				short num = (short)341835776;
				short num2 = num;
				num = (short)1254695369;
				short num3 = num;
				num = (short)662512073;
				switch (num3 == num)
				{
				}
				num = (short)482344960;
				if (num != 0)
				{
				}
				num = (short)977207297;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.Visible;
			}
			set
			{
				short num = (short)1075314688;
				short num2 = num;
				num = (short)821077348;
				short num3 = num;
				num = (short)1119659364;
				switch (num3 == num)
				{
				}
				num = (short)1549795328;
				if (num != 0)
				{
				}
				num = (short)1619787777;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.Visible = value;
			}
		}

		// Token: 0x170044A6 RID: 17574
		// (get) Token: 0x060086FF RID: 34559 RVA: 0x007DDF28 File Offset: 0x007DC128
		// (set) Token: 0x06008700 RID: 34560 RVA: 0x007DDFE0 File Offset: 0x007DC1E0
		public bool RadErgCtrlHeadO7DataButtonTrkFeature_A41297_Editable
		{
			get
			{
				short num = (short)301334528;
				short num2 = num;
				num = (short)572278119;
				short num3 = num;
				num = (short)166085991;
				switch (num3 == num)
				{
				}
				num = (short)867434497;
				if (num != 0)
				{
				}
				num = (short)1736572928;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.Editable;
			}
			set
			{
				short num = (short)985726976;
				short num2 = num;
				num = (short)773569122;
				short num3 = num;
				num = (short)2145303138;
				switch (num3 == num)
				{
				}
				num = (short)549453825;
				if (num != 0)
				{
				}
				num = (short)1501364224;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.Editable = value;
			}
		}

		// Token: 0x170044A7 RID: 17575
		// (get) Token: 0x06008701 RID: 34561 RVA: 0x007DE098 File Offset: 0x007DC298
		internal string RadErgCtrlHeadO7DataButtonTrkFeature_A41297_UILabel
		{
			get
			{
				short num = (short)541196288;
				short num2 = num;
				num = (short)1998965833;
				short num3 = num;
				num = (short)798542921;
				switch (num3 == num)
				{
				}
				num = (short)1642463233;
				if (num != 0)
				{
				}
				num = (short)2029912064;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.UIName;
			}
		}

		// Token: 0x170044A8 RID: 17576
		// (get) Token: 0x06008702 RID: 34562 RVA: 0x007DE14C File Offset: 0x007DC34C
		// (set) Token: 0x06008703 RID: 34563 RVA: 0x007DE200 File Offset: 0x007DC400
		internal bool RadErgCtrlHeadO7DataButtonTrkFeature_A41297_HiddenStatic
		{
			get
			{
				short num = (short)40828928;
				short num2 = num;
				num = (short)1343665475;
				short num3 = num;
				num = (short)1661056323;
				switch (num3 == num)
				{
				}
				num = (short)176029696;
				if (num != 0)
				{
				}
				num = (short)584581121;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.HiddenStatic;
			}
			set
			{
				short num = (short)929693696;
				short num2 = num;
				num = (short)852729624;
				short num3 = num;
				num = (short)1529126680;
				switch (num3 == num)
				{
				}
				num = (short)270598145;
				if (num != 0)
				{
				}
				num = (short)366870528;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.HiddenStatic = value;
			}
		}

		// Token: 0x170044A9 RID: 17577
		// (get) Token: 0x06008704 RID: 34564 RVA: 0x007DE2B4 File Offset: 0x007DC4B4
		// (set) Token: 0x06008705 RID: 34565 RVA: 0x007DE368 File Offset: 0x007DC568
		internal bool RadErgCtrlHeadO7DataButtonTrkFeature_A41297_HiddenDynamic
		{
			get
			{
				short num = (short)1684602880;
				short num2 = num;
				num = (short)1951137793;
				if (num != 0)
				{
				}
				num = (short)779189716;
				short num3 = num;
				num = (short)936476116;
				switch (num3 == num)
				{
				}
				num = (short)631701504;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.HiddenDynamic;
			}
			set
			{
				short num = (short)1239220224;
				short num2 = num;
				num = (short)1987483863;
				short num3 = num;
				num = (short)1936038103;
				switch (num3 == num)
				{
				}
				num = (short)208011265;
				if (num != 0)
				{
				}
				num = (short)517537792;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonTrkFeature_A41297.HiddenDynamic = value;
			}
		}

		// Token: 0x170044AA RID: 17578
		// (get) Token: 0x06008706 RID: 34566 RVA: 0x007DE420 File Offset: 0x007DC620
		public bool RadErgCtrlHeadO7DataButtonTrkFeature_A41297_HasDiffs
		{
			get
			{
				short num = (short)1338834944;
				short num2 = num;
				num = (short)1655447281;
				short num3 = num;
				num = (short)1430789873;
				switch (num3 == num)
				{
				}
				num = (short)789905408;
				if (num != 0)
				{
				}
				num = (short)1140719617;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkFeature_A41297._HasDiffs;
			}
		}

		// Token: 0x170044AB RID: 17579
		// (get) Token: 0x06008707 RID: 34567 RVA: 0x007DE4D4 File Offset: 0x007DC6D4
		// (set) Token: 0x06008708 RID: 34568 RVA: 0x007DE588 File Offset: 0x007DC788
		public int RadErgCtrlHeadO7DataButtonTrkBCO_A41298Value
		{
			get
			{
				short num = (short)1122172928;
				short num2 = num;
				num = (short)972157248;
				short num3 = num;
				num = (short)449704256;
				switch (num3 == num)
				{
				}
				num = (short)1863712769;
				if (num != 0)
				{
				}
				num = (short)1302396928;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.Value;
			}
			set
			{
				short num = (short)866648064;
				short num2 = num;
				num = (short)1808011917;
				short num3 = num;
				num = (short)677188237;
				switch (num3 == num)
				{
				}
				num = (short)1005322241;
				if (num != 0)
				{
				}
				num = (short)935526400;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.Value = value;
			}
		}

		// Token: 0x170044AC RID: 17580
		// (get) Token: 0x06008709 RID: 34569 RVA: 0x007DE640 File Offset: 0x007DC840
		// (set) Token: 0x0600870A RID: 34570 RVA: 0x007DE6F4 File Offset: 0x007DC8F4
		public string RadErgCtrlHeadO7DataButtonTrkBCO_A41298_UIValue
		{
			get
			{
				short num = (short)997588992;
				short num2 = num;
				num = (short)200380859;
				short num3 = num;
				num = (short)901288379;
				switch (num3 == num)
				{
				}
				num = (short)1249640449;
				if (num != 0)
				{
				}
				num = (short)770572288;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.UIValue;
			}
			set
			{
				short num = (short)1742667776;
				short num2 = num;
				num = (short)1797770380;
				short num3 = num;
				num = (short)1365298316;
				switch (num3 == num)
				{
				}
				num = (short)1058537473;
				if (num != 0)
				{
				}
				num = (short)1318912000;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.UIValue = value;
			}
		}

		// Token: 0x170044AD RID: 17581
		// (get) Token: 0x0600870B RID: 34571 RVA: 0x007DE7AC File Offset: 0x007DC9AC
		public global::AcpBusinessLayer.AcpListField RadErgCtrlHeadO7DataButtonTrkBCO_A41298
		{
			get
			{
				short num = (short)1361641472;
				short num2 = num;
				num = (short)1812568922;
				short num3 = num;
				num = (short)886676314;
				switch (num3 == num)
				{
				}
				num = (short)1582366720;
				if (num != 0)
				{
				}
				num = (short)2145976321;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkBCO_A41298;
			}
		}

		// Token: 0x170044AE RID: 17582
		// (get) Token: 0x0600870C RID: 34572 RVA: 0x007DE85C File Offset: 0x007DCA5C
		// (set) Token: 0x0600870D RID: 34573 RVA: 0x007DE910 File Offset: 0x007DCB10
		public bool RadErgCtrlHeadO7DataButtonTrkBCO_A41298_Applicable
		{
			get
			{
				short num = (short)161742848;
				short num2 = num;
				num = (short)1574481283;
				short num3 = num;
				num = (short)1308732803;
				switch (num3 == num)
				{
				}
				num = (short)591134721;
				if (num != 0)
				{
				}
				num = (short)283705344;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.Applicable;
			}
			set
			{
				short num = (short)620756992;
				short num2 = num;
				num = (short)1519779841;
				if (num != 0)
				{
				}
				num = (short)910393838;
				short num3 = num;
				num = (short)1159102958;
				switch (num3 == num)
				{
				}
				num = (short)2126643200;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.Applicable = value;
			}
		}

		// Token: 0x170044AF RID: 17583
		// (get) Token: 0x0600870E RID: 34574 RVA: 0x007DE9C8 File Offset: 0x007DCBC8
		// (set) Token: 0x0600870F RID: 34575 RVA: 0x007DEA7C File Offset: 0x007DCC7C
		public bool RadErgCtrlHeadO7DataButtonTrkBCO_A41298_Valid
		{
			get
			{
				short num = (short)976919242;
				short num2 = num;
				num = (short)284203722;
				switch (num2 == num)
				{
				}
				num = (short)2094858241;
				if (num != 0)
				{
				}
				num = (short)1504641024;
				short num3 = num;
				num = (short)1156513792;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.Valid;
			}
			set
			{
				short num = (short)2101870593;
				if (num != 0)
				{
				}
				num = (short)1726289859;
				short num2 = num;
				num = (short)453384131;
				switch (num2 == num)
				{
				}
				num = (short)448331776;
				short num3 = num;
				num = (short)2109472768;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.Valid = value;
			}
		}

		// Token: 0x170044B0 RID: 17584
		// (get) Token: 0x06008710 RID: 34576 RVA: 0x007DEB30 File Offset: 0x007DCD30
		// (set) Token: 0x06008711 RID: 34577 RVA: 0x007DEBE4 File Offset: 0x007DCDE4
		public bool RadErgCtrlHeadO7DataButtonTrkBCO_A41298_Visible
		{
			get
			{
				short num = (short)525209423;
				short num2 = num;
				num = (short)408620879;
				switch (num2 == num)
				{
				}
				num = (short)224133121;
				if (num != 0)
				{
				}
				num = (short)682098688;
				short num3 = num;
				num = (short)848625664;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.Visible;
			}
			set
			{
				short num = (short)75431937;
				if (num != 0)
				{
				}
				num = (short)1166742923;
				short num2 = num;
				num = (short)297211275;
				switch (num2 == num)
				{
				}
				num = (short)505675776;
				short num3 = num;
				num = (short)580124672;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.Visible = value;
			}
		}

		// Token: 0x170044B1 RID: 17585
		// (get) Token: 0x06008712 RID: 34578 RVA: 0x007DEC9C File Offset: 0x007DCE9C
		// (set) Token: 0x06008713 RID: 34579 RVA: 0x007DED50 File Offset: 0x007DCF50
		public bool RadErgCtrlHeadO7DataButtonTrkBCO_A41298_Editable
		{
			get
			{
				short num = (short)869856038;
				short num2 = num;
				num = (short)1286468390;
				switch (num2 == num)
				{
				}
				num = (short)93650944;
				if (num != 0)
				{
				}
				num = (short)1851326464;
				short num3 = num;
				num = (short)1498218497;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.Editable;
			}
			set
			{
				short num = (short)1837913304;
				short num2 = num;
				num = (short)1676760280;
				switch (num2 == num)
				{
				}
				num = (short)448790529;
				if (num != 0)
				{
				}
				num = (short)666697728;
				short num3 = num;
				num = (short)278200320;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.Editable = value;
			}
		}

		// Token: 0x170044B2 RID: 17586
		// (get) Token: 0x06008714 RID: 34580 RVA: 0x007DEE04 File Offset: 0x007DD004
		internal string RadErgCtrlHeadO7DataButtonTrkBCO_A41298_UILabel
		{
			get
			{
				short num = (short)864959606;
				short num2 = num;
				num = (short)617888886;
				switch (num2 == num)
				{
				}
				num = (short)1981939712;
				if (num != 0)
				{
				}
				num = (short)499122176;
				short num3 = num;
				num = (short)1331167233;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.UIName;
			}
		}

		// Token: 0x170044B3 RID: 17587
		// (get) Token: 0x06008715 RID: 34581 RVA: 0x007DEEB8 File Offset: 0x007DD0B8
		// (set) Token: 0x06008716 RID: 34582 RVA: 0x007DEF70 File Offset: 0x007DD170
		internal bool RadErgCtrlHeadO7DataButtonTrkBCO_A41298_HiddenStatic
		{
			get
			{
				short num = (short)1821064540;
				short num2 = num;
				num = (short)1909734748;
				switch (num2 == num)
				{
				}
				num = (short)1201012737;
				if (num != 0)
				{
				}
				num = (short)1127284736;
				short num3 = num;
				num = (short)1216348160;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.HiddenStatic;
			}
			set
			{
				short num = (short)2053111809;
				if (num != 0)
				{
				}
				num = (short)268202034;
				short num2 = num;
				num = (short)2071425074;
				switch (num2 == num)
				{
				}
				num = (short)2000551936;
				short num3 = num;
				num = (short)16580608;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.HiddenStatic = value;
			}
		}

		// Token: 0x170044B4 RID: 17588
		// (get) Token: 0x06008717 RID: 34583 RVA: 0x007DF024 File Offset: 0x007DD224
		// (set) Token: 0x06008718 RID: 34584 RVA: 0x007DF0D8 File Offset: 0x007DD2D8
		internal bool RadErgCtrlHeadO7DataButtonTrkBCO_A41298_HiddenDynamic
		{
			get
			{
				short num = (short)284684403;
				short num2 = num;
				num = (short)1684205683;
				switch (num2 == num)
				{
				}
				num = (short)750780416;
				if (num != 0)
				{
				}
				num = (short)2066350080;
				short num3 = num;
				num = (short)1417216001;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.HiddenDynamic;
			}
			set
			{
				short num = (short)1534998285;
				short num2 = num;
				num = (short)808859405;
				switch (num2 == num)
				{
				}
				num = (short)1764950016;
				if (num != 0)
				{
				}
				num = (short)673447936;
				short num3 = num;
				num = (short)851640321;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonTrkBCO_A41298.HiddenDynamic = value;
			}
		}

		// Token: 0x170044B5 RID: 17589
		// (get) Token: 0x06008719 RID: 34585 RVA: 0x007DF18C File Offset: 0x007DD38C
		public bool RadErgCtrlHeadO7DataButtonTrkBCO_A41298_HasDiffs
		{
			get
			{
				short num = (short)2082118099;
				short num2 = num;
				num = (short)277584339;
				switch (num2 == num)
				{
				}
				num = (short)273743872;
				if (num != 0)
				{
				}
				num = (short)2029387776;
				short num3 = num;
				num = (short)527630337;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonTrkBCO_A41298._HasDiffs;
			}
		}

		// Token: 0x170044B6 RID: 17590
		// (get) Token: 0x0600871A RID: 34586 RVA: 0x007DF244 File Offset: 0x007DD444
		// (set) Token: 0x0600871B RID: 34587 RVA: 0x007DF2F8 File Offset: 0x007DD4F8
		public int RadErgCtrlHeadO7DataButtonCnvFeature_A41299Value
		{
			get
			{
				short num = (short)2048065537;
				if (num != 0)
				{
				}
				num = (short)331389419;
				short num2 = num;
				num = (short)1522833899;
				switch (num2 == num)
				{
				}
				num = (short)977076224;
				short num3 = num;
				num = (short)1085734912;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.Value;
			}
			set
			{
				short num = (short)935109266;
				short num2 = num;
				num = (short)131900050;
				switch (num2 == num)
				{
				}
				num = (short)1993998337;
				if (num != 0)
				{
				}
				num = (short)2094071808;
				short num3 = num;
				num = (short)46727168;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.Value = value;
			}
		}

		// Token: 0x170044B7 RID: 17591
		// (get) Token: 0x0600871C RID: 34588 RVA: 0x007DF3AC File Offset: 0x007DD5AC
		// (set) Token: 0x0600871D RID: 34589 RVA: 0x007DF464 File Offset: 0x007DD664
		public string RadErgCtrlHeadO7DataButtonCnvFeature_A41299_UIValue
		{
			get
			{
				short num = (short)1808939821;
				short num2 = num;
				num = (short)1283144493;
				switch (num2 == num)
				{
				}
				num = (short)2048983041;
				if (num != 0)
				{
				}
				num = (short)1701511168;
				short num3 = num;
				num = (short)1530724352;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.UIValue;
			}
			set
			{
				short num = (short)931831065;
				short num2 = num;
				num = (short)1785961753;
				switch (num2 == num)
				{
				}
				num = (short)1289879553;
				if (num != 0)
				{
				}
				num = (short)287637504;
				short num3 = num;
				num = (short)1215299584;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.UIValue = value;
			}
		}

		// Token: 0x170044B8 RID: 17592
		// (get) Token: 0x0600871E RID: 34590 RVA: 0x007DF51C File Offset: 0x007DD71C
		public global::AcpBusinessLayer.AcpListField RadErgCtrlHeadO7DataButtonCnvFeature_A41299
		{
			get
			{
				short num = (short)1987395877;
				short num2 = num;
				num = (short)1773551909;
				switch (num2 == num)
				{
				}
				num = (short)692715521;
				if (num != 0)
				{
				}
				num = (short)1669529600;
				short num3 = num;
				num = (short)308150272;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvFeature_A41299;
			}
		}

		// Token: 0x170044B9 RID: 17593
		// (get) Token: 0x0600871F RID: 34591 RVA: 0x007DF5CC File Offset: 0x007DD7CC
		// (set) Token: 0x06008720 RID: 34592 RVA: 0x007DF680 File Offset: 0x007DD880
		public bool RadErgCtrlHeadO7DataButtonCnvFeature_A41299_Applicable
		{
			get
			{
				short num = (short)1489582193;
				short num2 = num;
				num = (short)626604145;
				switch (num2 == num)
				{
				}
				num = (short)1390477313;
				if (num != 0)
				{
				}
				num = (short)1262419968;
				short num3 = num;
				num = (short)975372288;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.Applicable;
			}
			set
			{
				short num = (short)1425072887;
				short num2 = num;
				num = (short)1484776183;
				switch (num2 == num)
				{
				}
				num = (short)1052442624;
				if (num != 0)
				{
				}
				num = (short)266600448;
				short num3 = num;
				num = (short)968622081;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.Applicable = value;
			}
		}

		// Token: 0x170044BA RID: 17594
		// (get) Token: 0x06008721 RID: 34593 RVA: 0x007DF734 File Offset: 0x007DD934
		// (set) Token: 0x06008722 RID: 34594 RVA: 0x007DF7E8 File Offset: 0x007DD9E8
		public bool RadErgCtrlHeadO7DataButtonCnvFeature_A41299_Valid
		{
			get
			{
				short num = (short)1920004587;
				short num2 = num;
				num = (short)1305211371;
				switch (num2 == num)
				{
				}
				num = (short)793116673;
				if (num != 0)
				{
				}
				num = (short)1900740608;
				short num3 = num;
				num = (short)979959808;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.Valid;
			}
			set
			{
				short num = (short)177399553;
				short num2 = num;
				num = (short)860546817;
				switch (num2 == num)
				{
				}
				num = (short)1856241665;
				if (num != 0)
				{
				}
				num = (short)312606720;
				short num3 = num;
				num = (short)433848320;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.Valid = value;
			}
		}

		// Token: 0x170044BB RID: 17595
		// (get) Token: 0x06008723 RID: 34595 RVA: 0x007DF8A0 File Offset: 0x007DDAA0
		// (set) Token: 0x06008724 RID: 34596 RVA: 0x007DF954 File Offset: 0x007DDB54
		public bool RadErgCtrlHeadO7DataButtonCnvFeature_A41299_Visible
		{
			get
			{
				short num = (short)407750820;
				short num2 = num;
				num = (short)103991460;
				switch (num2 == num)
				{
				}
				num = (short)1182466048;
				if (num != 0)
				{
				}
				num = (short)1636040704;
				short num3 = num;
				num = (short)1621229569;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.Visible;
			}
			set
			{
				short num = (short)470475266;
				short num2 = num;
				num = (short)24240642;
				switch (num2 == num)
				{
				}
				num = (short)1953497088;
				if (num != 0)
				{
				}
				num = (short)226033664;
				short num3 = num;
				num = (short)1847656449;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.Visible = value;
			}
		}

		// Token: 0x170044BC RID: 17596
		// (get) Token: 0x06008725 RID: 34597 RVA: 0x007DFA0C File Offset: 0x007DDC0C
		// (set) Token: 0x06008726 RID: 34598 RVA: 0x007DFAC0 File Offset: 0x007DDCC0
		public bool RadErgCtrlHeadO7DataButtonCnvFeature_A41299_Editable
		{
			get
			{
				short num = (short)133208180;
				short num2 = num;
				num = (short)751474804;
				switch (num2 == num)
				{
				}
				num = (short)1449459712;
				if (num != 0)
				{
				}
				num = (short)1711603712;
				short num3 = num;
				num = (short)554958849;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.Editable;
			}
			set
			{
				short num = (short)1573257217;
				if (num != 0)
				{
				}
				num = (short)1789358757;
				short num2 = num;
				num = (short)600470181;
				switch (num2 == num)
				{
				}
				num = (short)595132416;
				short num3 = num;
				num = (short)98107392;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.Editable = value;
			}
		}

		// Token: 0x170044BD RID: 17597
		// (get) Token: 0x06008727 RID: 34599 RVA: 0x007DFB78 File Offset: 0x007DDD78
		internal string RadErgCtrlHeadO7DataButtonCnvFeature_A41299_UILabel
		{
			get
			{
				short num = (short)1377247199;
				short num2 = num;
				num = (short)1375412191;
				switch (num2 == num)
				{
				}
				num = (short)1860632577;
				if (num != 0)
				{
				}
				num = (short)285999104;
				short num3 = num;
				num = (short)838795264;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.UIName;
			}
		}

		// Token: 0x170044BE RID: 17598
		// (get) Token: 0x06008728 RID: 34600 RVA: 0x007DFC30 File Offset: 0x007DDE30
		// (set) Token: 0x06008729 RID: 34601 RVA: 0x007DFCE4 File Offset: 0x007DDEE4
		internal bool RadErgCtrlHeadO7DataButtonCnvFeature_A41299_HiddenStatic
		{
			get
			{
				short num = (short)328531969;
				if (num != 0)
				{
				}
				num = (short)873917601;
				short num2 = num;
				num = (short)947645601;
				switch (num2 == num)
				{
				}
				num = (short)1723138048;
				short num3 = num;
				num = (short)207093760;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.HiddenStatic;
			}
			set
			{
				short num = (short)1448855114;
				short num2 = num;
				num = (short)1099338;
				switch (num2 == num)
				{
				}
				num = (short)21561345;
				if (num != 0)
				{
				}
				num = (short)678100992;
				short num3 = num;
				num = (short)38731776;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.HiddenStatic = value;
			}
		}

		// Token: 0x170044BF RID: 17599
		// (get) Token: 0x0600872A RID: 34602 RVA: 0x007DFD98 File Offset: 0x007DDF98
		// (set) Token: 0x0600872B RID: 34603 RVA: 0x007DFE4C File Offset: 0x007DE04C
		internal bool RadErgCtrlHeadO7DataButtonCnvFeature_A41299_HiddenDynamic
		{
			get
			{
				short num = (short)821365595;
				short num2 = num;
				num = (short)1653345115;
				switch (num2 == num)
				{
				}
				num = (short)1240006657;
				if (num != 0)
				{
				}
				num = (short)300089344;
				short num3 = num;
				num = (short)1014497280;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.HiddenDynamic;
			}
			set
			{
				short num = (short)777968119;
				short num2 = num;
				num = (short)1356519927;
				switch (num2 == num)
				{
				}
				num = (short)342884353;
				if (num != 0)
				{
				}
				num = (short)2012413952;
				short num3 = num;
				num = (short)1092550656;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonCnvFeature_A41299.HiddenDynamic = value;
			}
		}

		// Token: 0x170044C0 RID: 17600
		// (get) Token: 0x0600872C RID: 34604 RVA: 0x007DFF04 File Offset: 0x007DE104
		public bool RadErgCtrlHeadO7DataButtonCnvFeature_A41299_HasDiffs
		{
			get
			{
				short num = (short)1609234692;
				short num2 = num;
				num = (short)1958476036;
				switch (num2 == num)
				{
				}
				num = (short)1012858881;
				if (num != 0)
				{
				}
				num = (short)1777598464;
				short num3 = num;
				num = (short)136249344;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvFeature_A41299._HasDiffs;
			}
		}

		// Token: 0x170044C1 RID: 17601
		// (get) Token: 0x0600872D RID: 34605 RVA: 0x007DFFBC File Offset: 0x007DE1BC
		// (set) Token: 0x0600872E RID: 34606 RVA: 0x007E0070 File Offset: 0x007DE270
		public int RadErgCtrlHeadO7DataButtonCnvBCO_A41300Value
		{
			get
			{
				short num = (short)1591167771;
				short num2 = num;
				num = (short)1391741723;
				switch (num2 == num)
				{
				}
				num = (short)1330642944;
				if (num != 0)
				{
				}
				num = (short)1198850048;
				short num3 = num;
				num = (short)1333657601;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.Value;
			}
			set
			{
				short num = (short)104893306;
				short num2 = num;
				num = (short)1863027578;
				switch (num2 == num)
				{
				}
				num = (short)1277165568;
				if (num != 0)
				{
				}
				num = (short)612761600;
				short num3 = num;
				num = (short)1601437697;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.Value = value;
			}
		}

		// Token: 0x170044C2 RID: 17602
		// (get) Token: 0x0600872F RID: 34607 RVA: 0x007E0124 File Offset: 0x007DE324
		// (set) Token: 0x06008730 RID: 34608 RVA: 0x007E01D8 File Offset: 0x007DE3D8
		public string RadErgCtrlHeadO7DataButtonCnvBCO_A41300_UIValue
		{
			get
			{
				short num = (short)2111224534;
				short num2 = num;
				num = (short)452901590;
				switch (num2 == num)
				{
				}
				num = (short)1857224704;
				if (num != 0)
				{
				}
				num = (short)1915289600;
				short num3 = num;
				num = (short)614137857;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.UIValue;
			}
			set
			{
				short num = (short)762293530;
				short num2 = num;
				num = (short)76786970;
				switch (num2 == num)
				{
				}
				num = (short)1251868672;
				if (num != 0)
				{
				}
				num = (short)728563712;
				short num3 = num;
				num = (short)2069561345;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.UIValue = value;
			}
		}

		// Token: 0x170044C3 RID: 17603
		// (get) Token: 0x06008731 RID: 34609 RVA: 0x007E0290 File Offset: 0x007DE490
		public global::AcpBusinessLayer.AcpListField RadErgCtrlHeadO7DataButtonCnvBCO_A41300
		{
			get
			{
				short num = (short)599932537;
				short num2 = num;
				num = (short)396639865;
				switch (num2 == num)
				{
				}
				num = (short)990117888;
				if (num != 0)
				{
				}
				num = (short)1219428352;
				short num3 = num;
				num = (short)575995905;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvBCO_A41300;
			}
		}

		// Token: 0x170044C4 RID: 17604
		// (get) Token: 0x06008732 RID: 34610 RVA: 0x007E0340 File Offset: 0x007DE540
		// (set) Token: 0x06008733 RID: 34611 RVA: 0x007E03F0 File Offset: 0x007DE5F0
		public bool RadErgCtrlHeadO7DataButtonCnvBCO_A41300_Applicable
		{
			get
			{
				short num = (short)1239339618;
				short num2 = num;
				num = (short)1919930978;
				switch (num2 == num)
				{
				}
				num = (short)776470529;
				if (num != 0)
				{
				}
				num = (short)958529536;
				short num3 = num;
				num = (short)317325312;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.Applicable;
			}
			set
			{
				short num = (short)1384915243;
				short num2 = num;
				num = (short)1953440043;
				switch (num2 == num)
				{
				}
				num = (short)1502674945;
				if (num != 0)
				{
				}
				num = (short)1819738112;
				short num3 = num;
				num = (short)1335885824;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.Applicable = value;
			}
		}

		// Token: 0x170044C5 RID: 17605
		// (get) Token: 0x06008734 RID: 34612 RVA: 0x007E04A8 File Offset: 0x007DE6A8
		// (set) Token: 0x06008735 RID: 34613 RVA: 0x007E055C File Offset: 0x007DE75C
		public bool RadErgCtrlHeadO7DataButtonCnvBCO_A41300_Valid
		{
			get
			{
				short num = (short)2146172929;
				if (num != 0)
				{
				}
				num = (short)1643916963;
				short num2 = num;
				num = (short)426323619;
				switch (num2 == num)
				{
				}
				num = (short)212008960;
				short num3 = num;
				num = (short)1025638400;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.Valid;
			}
			set
			{
				short num = (short)41898124;
				short num2 = num;
				num = (short)1489522828;
				switch (num2 == num)
				{
				}
				num = (short)973209601;
				if (num != 0)
				{
				}
				num = (short)1689255936;
				short num3 = num;
				num = (short)873791488;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.Valid = value;
			}
		}

		// Token: 0x170044C6 RID: 17606
		// (get) Token: 0x06008736 RID: 34614 RVA: 0x007E0610 File Offset: 0x007DE810
		// (set) Token: 0x06008737 RID: 34615 RVA: 0x007E06C8 File Offset: 0x007DE8C8
		public bool RadErgCtrlHeadO7DataButtonCnvBCO_A41300_Visible
		{
			get
			{
				short num = (short)879429872;
				short num2 = num;
				num = (short)872089840;
				switch (num2 == num)
				{
				}
				num = (short)114884609;
				if (num != 0)
				{
				}
				num = (short)1158938624;
				short num3 = num;
				num = (short)931004416;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.Visible;
			}
			set
			{
				short num = (short)324959493;
				short num2 = num;
				num = (short)1729723653;
				switch (num2 == num)
				{
				}
				num = (short)1171521536;
				if (num != 0)
				{
				}
				num = (short)993460224;
				short num3 = num;
				num = (short)1811873793;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.Visible = value;
			}
		}

		// Token: 0x170044C7 RID: 17607
		// (get) Token: 0x06008738 RID: 34616 RVA: 0x007E077C File Offset: 0x007DE97C
		// (set) Token: 0x06008739 RID: 34617 RVA: 0x007E0830 File Offset: 0x007DEA30
		public bool RadErgCtrlHeadO7DataButtonCnvBCO_A41300_Editable
		{
			get
			{
				short num = (short)2094291991;
				short num2 = num;
				num = (short)1829002263;
				switch (num2 == num)
				{
				}
				num = (short)1816068097;
				if (num != 0)
				{
				}
				num = (short)1805844480;
				short num3 = num;
				num = (short)426377216;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.Editable;
			}
			set
			{
				short num = (short)1158989007;
				short num2 = num;
				num = (short)951174351;
				switch (num2 == num)
				{
				}
				num = (short)1189675008;
				if (num != 0)
				{
				}
				num = (short)968753152;
				short num3 = num;
				num = (short)2023227393;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.Editable = value;
			}
		}

		// Token: 0x170044C8 RID: 17608
		// (get) Token: 0x0600873A RID: 34618 RVA: 0x007E08E8 File Offset: 0x007DEAE8
		internal string RadErgCtrlHeadO7DataButtonCnvBCO_A41300_UILabel
		{
			get
			{
				short num = (short)1321822218;
				short num2 = num;
				num = (short)605906954;
				switch (num2 == num)
				{
				}
				num = (short)126943232;
				if (num != 0)
				{
				}
				num = (short)2116485120;
				short num3 = num;
				num = (short)2132082689;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.UIName;
			}
		}

		// Token: 0x170044C9 RID: 17609
		// (get) Token: 0x0600873B RID: 34619 RVA: 0x007E0998 File Offset: 0x007DEB98
		// (set) Token: 0x0600873C RID: 34620 RVA: 0x007E0A50 File Offset: 0x007DEC50
		internal bool RadErgCtrlHeadO7DataButtonCnvBCO_A41300_HiddenStatic
		{
			get
			{
				short num = (short)1965883393;
				if (num != 0)
				{
				}
				num = (short)396026881;
				short num2 = num;
				num = (short)2003756033;
				switch (num2 == num)
				{
				}
				num = (short)977534976;
				short num3 = num;
				num = (short)1510932480;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.HiddenStatic;
			}
			set
			{
				short num = (short)1496186881;
				if (num != 0)
				{
				}
				num = (short)2139225836;
				short num2 = num;
				num = (short)50921196;
				switch (num2 == num)
				{
				}
				num = (short)1699020800;
				short num3 = num;
				num = (short)1795358720;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.HiddenStatic = value;
			}
		}

		// Token: 0x170044CA RID: 17610
		// (get) Token: 0x0600873D RID: 34621 RVA: 0x007E0B08 File Offset: 0x007DED08
		// (set) Token: 0x0600873E RID: 34622 RVA: 0x007E0BC0 File Offset: 0x007DEDC0
		internal bool RadErgCtrlHeadO7DataButtonCnvBCO_A41300_HiddenDynamic
		{
			get
			{
				short num = (short)813530207;
				short num2 = num;
				num = (short)1894808671;
				switch (num2 == num)
				{
				}
				num = (short)1026883585;
				if (num != 0)
				{
				}
				num = (short)2008481792;
				short num3 = num;
				num = (short)368836608;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.HiddenDynamic;
			}
			set
			{
				short num = (short)1742386706;
				short num2 = num;
				num = (short)1672525330;
				switch (num2 == num)
				{
				}
				num = (short)787939329;
				if (num != 0)
				{
				}
				num = (short)1149698048;
				short num3 = num;
				num = (short)536739840;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO7DataButtonCnvBCO_A41300.HiddenDynamic = value;
			}
		}

		// Token: 0x170044CB RID: 17611
		// (get) Token: 0x0600873F RID: 34623 RVA: 0x007E0C74 File Offset: 0x007DEE74
		public bool RadErgCtrlHeadO7DataButtonCnvBCO_A41300_HasDiffs
		{
			get
			{
				short num = (short)498991105;
				if (num != 0)
				{
				}
				num = (short)1878816115;
				short num2 = num;
				num = (short)629175667;
				switch (num2 == num)
				{
				}
				num = (short)1282342912;
				short num3 = num;
				num = (short)654245888;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO7DataButtonCnvBCO_A41300._HasDiffs;
			}
		}

		// Token: 0x170044CC RID: 17612
		// (get) Token: 0x06008740 RID: 34624 RVA: 0x007E0D28 File Offset: 0x007DEF28
		// (set) Token: 0x06008741 RID: 34625 RVA: 0x007E0DDC File Offset: 0x007DEFDC
		public int CHO7DataButtonConvIndex_A41417Value
		{
			get
			{
				short num = (short)66277526;
				short num2 = num;
				num = (short)328683670;
				switch (num2 == num)
				{
				}
				num = (short)146735104;
				if (num != 0)
				{
				}
				num = (short)345112576;
				short num3 = num;
				num = (short)249233409;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonConvIndex_A41417.Value;
			}
			set
			{
				short num = (short)2105512987;
				short num2 = num;
				num = (short)443520027;
				switch (num2 == num)
				{
				}
				num = (short)447676417;
				if (num != 0)
				{
				}
				num = (short)352124928;
				short num3 = num;
				num = (short)475332608;
				if (num != 0)
				{
				}
				this.cHO7DataButtonConvIndex_A41417.Value = value;
			}
		}

		// Token: 0x170044CD RID: 17613
		// (get) Token: 0x06008742 RID: 34626 RVA: 0x007E0E94 File Offset: 0x007DF094
		// (set) Token: 0x06008743 RID: 34627 RVA: 0x007E0F48 File Offset: 0x007DF148
		public string CHO7DataButtonConvIndex_A41417_UIValue
		{
			get
			{
				short num = (short)1859106914;
				short num2 = num;
				num = (short)994621538;
				switch (num2 == num)
				{
				}
				num = (short)385417216;
				if (num != 0)
				{
				}
				num = (short)1746599936;
				short num3 = num;
				num = (short)88080385;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonConvIndex_A41417.UIValue;
			}
			set
			{
				short num = (short)1135983512;
				short num2 = num;
				num = (short)281983896;
				switch (num2 == num)
				{
				}
				num = (short)1620115456;
				if (num != 0)
				{
				}
				num = (short)1269956608;
				short num3 = num;
				num = (short)1881407489;
				if (num != 0)
				{
				}
				this.cHO7DataButtonConvIndex_A41417.UIValue = value;
			}
		}

		// Token: 0x170044CE RID: 17614
		// (get) Token: 0x06008744 RID: 34628 RVA: 0x007E1000 File Offset: 0x007DF200
		public global::AcpBusinessLayer.AcpRecRefField CHO7DataButtonConvIndex_A41417
		{
			get
			{
				short num = (short)1321114349;
				short num2 = num;
				num = (short)2030213869;
				switch (num2 == num)
				{
				}
				num = (short)531693568;
				short num3 = num;
				num = (short)1665269761;
				if (num != 0)
				{
				}
				num = (short)1332084736;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonConvIndex_A41417;
			}
		}

		// Token: 0x170044CF RID: 17615
		// (get) Token: 0x06008745 RID: 34629 RVA: 0x007E10B4 File Offset: 0x007DF2B4
		// (set) Token: 0x06008746 RID: 34630 RVA: 0x007E1168 File Offset: 0x007DF368
		public bool CHO7DataButtonConvIndex_A41417_Applicable
		{
			get
			{
				short num = (short)657642022;
				short num2 = num;
				num = (short)290247206;
				switch (num2 == num)
				{
				}
				num = (short)1581907968;
				short num3 = num;
				num = (short)1619132417;
				if (num != 0)
				{
				}
				num = (short)808845312;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonConvIndex_A41417.Applicable;
			}
			set
			{
				short num = (short)1123090433;
				if (num != 0)
				{
				}
				num = (short)870004161;
				short num2 = num;
				num = (short)650589633;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1573126144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1105788928;
				if (num != 0)
				{
				}
				this.cHO7DataButtonConvIndex_A41417.Applicable = value;
			}
		}

		// Token: 0x170044D0 RID: 17616
		// (get) Token: 0x06008747 RID: 34631 RVA: 0x007E121C File Offset: 0x007DF41C
		// (set) Token: 0x06008748 RID: 34632 RVA: 0x007E12D4 File Offset: 0x007DF4D4
		public bool CHO7DataButtonConvIndex_A41417_Valid
		{
			get
			{
				short num = (short)741242587;
				short num2 = num;
				num = (short)525694683;
				switch (num2 == num)
				{
				}
				num = (short)1501954048;
				short num3 = num;
				num = (short)1561395201;
				if (num != 0)
				{
				}
				num = (short)1790377984;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonConvIndex_A41417.Valid;
			}
			set
			{
				short num = (short)241762305;
				if (num != 0)
				{
				}
				num = (short)1799004901;
				short num2 = num;
				num = (short)645636837;
				switch (num2 == num)
				{
				default:
				{
					num = (short)39387136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)403439616;
				if (num != 0)
				{
				}
				this.cHO7DataButtonConvIndex_A41417.Valid = value;
			}
		}

		// Token: 0x170044D1 RID: 17617
		// (get) Token: 0x06008749 RID: 34633 RVA: 0x007E138C File Offset: 0x007DF58C
		// (set) Token: 0x0600874A RID: 34634 RVA: 0x007E1440 File Offset: 0x007DF640
		public bool CHO7DataButtonConvIndex_A41417_Visible
		{
			get
			{
				short num = (short)1222169415;
				short num2 = num;
				num = (short)557437767;
				switch (num2 == num)
				{
				}
				num = (short)1821704192;
				short num3 = num;
				num = (short)293011457;
				if (num != 0)
				{
				}
				num = (short)249757696;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonConvIndex_A41417.Visible;
			}
			set
			{
				short num = (short)1043753014;
				short num2 = num;
				num = (short)1695639606;
				switch (num2 == num)
				{
				}
				num = (short)307888128;
				short num3 = num;
				num = (short)1324744705;
				if (num != 0)
				{
				}
				num = (short)311754752;
				if (num != 0)
				{
				}
				this.cHO7DataButtonConvIndex_A41417.Visible = value;
			}
		}

		// Token: 0x170044D2 RID: 17618
		// (get) Token: 0x0600874B RID: 34635 RVA: 0x007E14F8 File Offset: 0x007DF6F8
		// (set) Token: 0x0600874C RID: 34636 RVA: 0x007E15AC File Offset: 0x007DF7AC
		public bool CHO7DataButtonConvIndex_A41417_Editable
		{
			get
			{
				short num = (short)1742108204;
				short num2 = num;
				num = (short)1963423276;
				switch (num2 == num)
				{
				}
				num = (short)652607488;
				short num3 = num;
				num = (short)2103312385;
				if (num != 0)
				{
				}
				num = (short)382009344;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonConvIndex_A41417.Editable;
			}
			set
			{
				short num = (short)1882665473;
				short num2 = num;
				num = (short)1907896833;
				switch (num2 == num)
				{
				}
				num = (short)598343680;
				short num3 = num;
				num = (short)1392574465;
				if (num != 0)
				{
				}
				num = (short)1644691456;
				if (num != 0)
				{
				}
				this.cHO7DataButtonConvIndex_A41417.Editable = value;
			}
		}

		// Token: 0x170044D3 RID: 17619
		// (get) Token: 0x0600874D RID: 34637 RVA: 0x007E1664 File Offset: 0x007DF864
		internal string CHO7DataButtonConvIndex_A41417_UILabel
		{
			get
			{
				short num = (short)558077498;
				short num2 = num;
				num = (short)997496378;
				switch (num2 == num)
				{
				}
				num = (short)438173696;
				short num3 = num;
				num = (short)2020605953;
				if (num != 0)
				{
				}
				num = (short)1557856256;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonConvIndex_A41417.UIName;
			}
		}

		// Token: 0x170044D4 RID: 17620
		// (get) Token: 0x0600874E RID: 34638 RVA: 0x007E171C File Offset: 0x007DF91C
		// (set) Token: 0x0600874F RID: 34639 RVA: 0x007E17D4 File Offset: 0x007DF9D4
		internal bool CHO7DataButtonConvIndex_A41417_HiddenStatic
		{
			get
			{
				short num = (short)1935472495;
				short num2 = num;
				num = (short)1310586735;
				switch (num2 == num)
				{
				}
				num = (short)410124288;
				short num3 = num;
				num = (short)1227948033;
				if (num != 0)
				{
				}
				num = (short)2052849664;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonConvIndex_A41417.HiddenStatic;
			}
			set
			{
				short num = (short)1662381042;
				short num2 = num;
				num = (short)1777265650;
				switch (num2 == num)
				{
				}
				num = (short)1405878272;
				short num3 = num;
				num = (short)1093140480;
				if (num != 0)
				{
				}
				num = (short)862650369;
				if (num != 0)
				{
				}
				this.cHO7DataButtonConvIndex_A41417.HiddenStatic = value;
			}
		}

		// Token: 0x170044D5 RID: 17621
		// (get) Token: 0x06008750 RID: 34640 RVA: 0x007E1888 File Offset: 0x007DFA88
		// (set) Token: 0x06008751 RID: 34641 RVA: 0x007E193C File Offset: 0x007DFB3C
		internal bool CHO7DataButtonConvIndex_A41417_HiddenDynamic
		{
			get
			{
				short num = (short)1267138561;
				if (num != 0)
				{
				}
				num = (short)808914520;
				short num2 = num;
				num = (short)418713176;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1845821440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1898119168;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonConvIndex_A41417.HiddenDynamic;
			}
			set
			{
				short num = (short)546889492;
				short num2 = num;
				num = (short)537059092;
				switch (num2 == num)
				{
				}
				num = (short)1853095936;
				short num3 = num;
				num = (short)390070273;
				if (num != 0)
				{
				}
				num = (short)678821888;
				if (num != 0)
				{
				}
				this.cHO7DataButtonConvIndex_A41417.HiddenDynamic = value;
			}
		}

		// Token: 0x170044D6 RID: 17622
		// (get) Token: 0x06008752 RID: 34642 RVA: 0x007E19F4 File Offset: 0x007DFBF4
		public bool CHO7DataButtonConvIndex_A41417_HasDiffs
		{
			get
			{
				short num = (short)1542124919;
				short num2 = num;
				num = (short)1076950391;
				switch (num2 == num)
				{
				}
				num = (short)494010368;
				short num3 = num;
				num = (short)1462697985;
				if (num != 0)
				{
				}
				num = (short)273219584;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonConvIndex_A41417._HasDiffs;
			}
		}

		// Token: 0x170044D7 RID: 17623
		// (get) Token: 0x06008753 RID: 34643 RVA: 0x007E1AA8 File Offset: 0x007DFCA8
		// (set) Token: 0x06008754 RID: 34644 RVA: 0x007E1B5C File Offset: 0x007DFD5C
		public int CHO7DataButtonTrkIndex_A41418Value
		{
			get
			{
				short num = (short)1933180083;
				short num2 = num;
				num = (short)309329075;
				switch (num2 == num)
				{
				}
				num = (short)1401618432;
				short num3 = num;
				num = (short)1291780097;
				if (num != 0)
				{
				}
				num = (short)1472004096;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonTrkIndex_A41418.Value;
			}
			set
			{
				short num = (short)4980737;
				if (num != 0)
				{
				}
				num = (short)1757727415;
				short num2 = num;
				num = (short)1044695735;
				switch (num2 == num)
				{
				default:
				{
					num = (short)5505024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1421803520;
				if (num != 0)
				{
				}
				this.cHO7DataButtonTrkIndex_A41418.Value = value;
			}
		}

		// Token: 0x170044D8 RID: 17624
		// (get) Token: 0x06008755 RID: 34645 RVA: 0x007E1C14 File Offset: 0x007DFE14
		// (set) Token: 0x06008756 RID: 34646 RVA: 0x007E1CC8 File Offset: 0x007DFEC8
		public string CHO7DataButtonTrkIndex_A41418_UIValue
		{
			get
			{
				short num = (short)214573050;
				short num2 = num;
				num = (short)1059659770;
				switch (num2 == num)
				{
				}
				num = (short)1707147264;
				short num3 = num;
				num = (short)1804861441;
				if (num != 0)
				{
				}
				num = (short)66453504;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonTrkIndex_A41418.UIValue;
			}
			set
			{
				short num = (short)346357761;
				if (num != 0)
				{
				}
				num = (short)921831885;
				short num2 = num;
				num = (short)1534593485;
				switch (num2 == num)
				{
				default:
				{
					num = (short)876609536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1492779008;
				if (num != 0)
				{
				}
				this.cHO7DataButtonTrkIndex_A41418.UIValue = value;
			}
		}

		// Token: 0x170044D9 RID: 17625
		// (get) Token: 0x06008757 RID: 34647 RVA: 0x007E1D80 File Offset: 0x007DFF80
		public global::AcpBusinessLayer.AcpRecRefField CHO7DataButtonTrkIndex_A41418
		{
			get
			{
				short num = (short)1349358187;
				short num2 = num;
				num = (short)505188971;
				switch (num2 == num)
				{
				}
				num = (short)1803616256;
				short num3 = num;
				num = (short)1546387457;
				if (num != 0)
				{
				}
				num = (short)1545142272;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonTrkIndex_A41418;
			}
		}

		// Token: 0x170044DA RID: 17626
		// (get) Token: 0x06008758 RID: 34648 RVA: 0x007E1E2C File Offset: 0x007E002C
		// (set) Token: 0x06008759 RID: 34649 RVA: 0x007E1EE0 File Offset: 0x007E00E0
		public bool CHO7DataButtonTrkIndex_A41418_Applicable
		{
			get
			{
				short num = (short)1908730106;
				short num2 = num;
				num = (short)812312826;
				switch (num2 == num)
				{
				}
				num = (short)1227554816;
				short num3 = num;
				num = (short)1222180865;
				if (num != 0)
				{
				}
				num = (short)4718592;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonTrkIndex_A41418.Applicable;
			}
			set
			{
				short num = (short)1558800891;
				short num2 = num;
				num = (short)1282173435;
				switch (num2 == num)
				{
				}
				num = (short)1302200320;
				short num3 = num;
				num = (short)2130575361;
				if (num != 0)
				{
				}
				num = (short)106627072;
				if (num != 0)
				{
				}
				this.cHO7DataButtonTrkIndex_A41418.Applicable = value;
			}
		}

		// Token: 0x170044DB RID: 17627
		// (get) Token: 0x0600875A RID: 34650 RVA: 0x007E1F94 File Offset: 0x007E0194
		// (set) Token: 0x0600875B RID: 34651 RVA: 0x007E2048 File Offset: 0x007E0248
		public bool CHO7DataButtonTrkIndex_A41418_Valid
		{
			get
			{
				short num = (short)1041656972;
				short num2 = num;
				num = (short)1874619532;
				switch (num2 == num)
				{
				}
				num = (short)101974016;
				short num3 = num;
				num = (short)2146107393;
				if (num != 0)
				{
				}
				num = (short)1173880832;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonTrkIndex_A41418.Valid;
			}
			set
			{
				short num = (short)296812545;
				if (num != 0)
				{
				}
				num = (short)1565990194;
				short num2 = num;
				num = (short)941038898;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1588789248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1557004288;
				if (num != 0)
				{
				}
				this.cHO7DataButtonTrkIndex_A41418.Valid = value;
			}
		}

		// Token: 0x170044DC RID: 17628
		// (get) Token: 0x0600875C RID: 34652 RVA: 0x007E2100 File Offset: 0x007E0300
		// (set) Token: 0x0600875D RID: 34653 RVA: 0x007E21B4 File Offset: 0x007E03B4
		public bool CHO7DataButtonTrkIndex_A41418_Visible
		{
			get
			{
				short num = (short)483852289;
				if (num != 0)
				{
				}
				num = (short)302395497;
				short num2 = num;
				num = (short)24326249;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1840578560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1189543936;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonTrkIndex_A41418.Visible;
			}
			set
			{
				short num = (short)1981124260;
				short num2 = num;
				num = (short)686657188;
				switch (num2 == num)
				{
				}
				num = (short)1395523584;
				short num3 = num;
				num = (short)1832124416;
				if (num != 0)
				{
				}
				num = (short)1264517121;
				if (num != 0)
				{
				}
				this.cHO7DataButtonTrkIndex_A41418.Visible = value;
			}
		}

		// Token: 0x170044DD RID: 17629
		// (get) Token: 0x0600875E RID: 34654 RVA: 0x007E226C File Offset: 0x007E046C
		// (set) Token: 0x0600875F RID: 34655 RVA: 0x007E2320 File Offset: 0x007E0520
		public bool CHO7DataButtonTrkIndex_A41418_Editable
		{
			get
			{
				short num = (short)1728585970;
				short num2 = num;
				num = (short)294265074;
				switch (num2 == num)
				{
				}
				num = (short)921698304;
				short num3 = num;
				num = (short)1306198017;
				if (num != 0)
				{
				}
				num = (short)559415296;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonTrkIndex_A41418.Editable;
			}
			set
			{
				short num = (short)466251842;
				short num2 = num;
				num = (short)1708093506;
				switch (num2 == num)
				{
				}
				num = (short)1383661568;
				short num3 = num;
				num = (short)1757937665;
				if (num != 0)
				{
				}
				num = (short)2025193472;
				if (num != 0)
				{
				}
				this.cHO7DataButtonTrkIndex_A41418.Editable = value;
			}
		}

		// Token: 0x170044DE RID: 17630
		// (get) Token: 0x06008760 RID: 34656 RVA: 0x007E23D4 File Offset: 0x007E05D4
		internal string CHO7DataButtonTrkIndex_A41418_UILabel
		{
			get
			{
				short num = (short)1214844983;
				short num2 = num;
				num = (short)1692012599;
				switch (num2 == num)
				{
				}
				num = (short)24444928;
				short num3 = num;
				num = (short)993067009;
				if (num != 0)
				{
				}
				num = (short)2099707904;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonTrkIndex_A41418.UIName;
			}
		}

		// Token: 0x170044DF RID: 17631
		// (get) Token: 0x06008761 RID: 34657 RVA: 0x007E2488 File Offset: 0x007E0688
		// (set) Token: 0x06008762 RID: 34658 RVA: 0x007E2540 File Offset: 0x007E0740
		internal bool CHO7DataButtonTrkIndex_A41418_HiddenStatic
		{
			get
			{
				short num = (short)792565224;
				short num2 = num;
				num = (short)1421579752;
				switch (num2 == num)
				{
				}
				num = (short)159383552;
				short num3 = num;
				num = (short)1802371073;
				if (num != 0)
				{
				}
				num = (short)1245380608;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonTrkIndex_A41418.HiddenStatic;
			}
			set
			{
				short num = (short)1585613152;
				short num2 = num;
				num = (short)713722208;
				switch (num2 == num)
				{
				}
				num = (short)2133393408;
				short num3 = num;
				num = (short)1920729089;
				if (num != 0)
				{
				}
				num = (short)902103040;
				if (num != 0)
				{
				}
				this.cHO7DataButtonTrkIndex_A41418.HiddenStatic = value;
			}
		}

		// Token: 0x170044E0 RID: 17632
		// (get) Token: 0x06008763 RID: 34659 RVA: 0x007E25F8 File Offset: 0x007E07F8
		// (set) Token: 0x06008764 RID: 34660 RVA: 0x007E26AC File Offset: 0x007E08AC
		internal bool CHO7DataButtonTrkIndex_A41418_HiddenDynamic
		{
			get
			{
				short num = (short)1962435816;
				short num2 = num;
				num = (short)115631336;
				switch (num2 == num)
				{
				}
				num = (short)307429376;
				short num3 = num;
				num = (short)669581313;
				if (num != 0)
				{
				}
				num = (short)9764864;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonTrkIndex_A41418.HiddenDynamic;
			}
			set
			{
				short num = (short)1927779000;
				short num2 = num;
				num = (short)1914213048;
				switch (num2 == num)
				{
				}
				num = (short)1046347776;
				short num3 = num;
				num = (short)802095104;
				if (num != 0)
				{
				}
				num = (short)1154875393;
				if (num != 0)
				{
				}
				this.cHO7DataButtonTrkIndex_A41418.HiddenDynamic = value;
			}
		}

		// Token: 0x170044E1 RID: 17633
		// (get) Token: 0x06008765 RID: 34661 RVA: 0x007E2760 File Offset: 0x007E0960
		public bool CHO7DataButtonTrkIndex_A41418_HasDiffs
		{
			get
			{
				short num = (short)1542193153;
				if (num != 0)
				{
				}
				num = (short)1747570658;
				short num2 = num;
				num = (short)120901602;
				switch (num2 == num)
				{
				default:
				{
					num = (short)947191808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2064908288;
				if (num != 0)
				{
				}
				return this.cHO7DataButtonTrkIndex_A41418._HasDiffs;
			}
		}

		// Token: 0x170044E2 RID: 17634
		// (get) Token: 0x06008766 RID: 34662 RVA: 0x007E2814 File Offset: 0x007E0A14
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1882922985;
				short num2 = num;
				num = (short)373235689;
				switch (num2 == num)
				{
				}
				num = (short)550371328;
				short num3 = num;
				num = (short)317325313;
				if (num != 0)
				{
				}
				num = (short)874446848;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06008767 RID: 34663 RVA: 0x007E28D4 File Offset: 0x007E0AD4
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					return result;
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)386465792;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)472580097;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)1640890369;
						if (num2 != 0)
						{
						}
						num2 = (short)2098987012;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					goto IL_FE;
				}
				goto IL_24;
			}
			IL_FE:
			goto IL_12B;
			IL_24:
			result = null;
			num2 = (short)1836374772;
			short num3 = num2;
			num2 = (short)430365428;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_12B:
				num2 = (short)1222246402;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1920729088;
				if (num2 != 0)
				{
				}
				num2 = (short)1116995584;
				short num4 = num2;
				num2 = (short)1770323971;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x04003FE7 RID: 16359
		private global::AcpBusinessLayer.AcpField<string> radErgCtrlHeadO7DataButtonName_A41296;

		// Token: 0x04003FE8 RID: 16360
		private global::AcpBusinessLayer.AcpListField radErgCtrlHeadO7DataButtonTrkFeature_A41297;

		// Token: 0x04003FE9 RID: 16361
		private global::AcpBusinessLayer.AcpListField radErgCtrlHeadO7DataButtonTrkBCO_A41298;

		// Token: 0x04003FEA RID: 16362
		private global::AcpBusinessLayer.AcpListField radErgCtrlHeadO7DataButtonCnvFeature_A41299;

		// Token: 0x04003FEB RID: 16363
		private global::AcpBusinessLayer.AcpListField radErgCtrlHeadO7DataButtonCnvBCO_A41300;

		// Token: 0x04003FEC RID: 16364
		private global::AcpBusinessLayer.AcpRecRefField cHO7DataButtonConvIndex_A41417;

		// Token: 0x04003FED RID: 16365
		private global::AcpBusinessLayer.AcpRecRefField cHO7DataButtonTrkIndex_A41418;
	}
}
