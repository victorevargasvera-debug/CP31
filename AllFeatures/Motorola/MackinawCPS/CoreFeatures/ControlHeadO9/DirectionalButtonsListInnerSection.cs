using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x0200036C RID: 876
	[global::System.Serializable]
	public class DirectionalButtonsListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060081CB RID: 33227 RVA: 0x007904C0 File Offset: 0x0078E6C0
		public DirectionalButtonsListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060081CC RID: 33228 RVA: 0x007904DC File Offset: 0x0078E6DC
		protected DirectionalButtonsListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060081CD RID: 33229 RVA: 0x007904F4 File Offset: 0x0078E6F4
		public override void Init()
		{
			int a_ = 6;
			short num = (short)1721630720;
			short num2 = num;
			num = (short)1785758217;
			short num3 = num;
			num = (short)582189577;
			switch (num3 == num)
			{
			}
			num = (short)1700134913;
			if (num != 0)
			{
			}
			num = (short)848166912;
			if (num != 0)
			{
			}
			this.radErgCtrlHeadO9DirLightBarName_A36558 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_LEFT, this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐郒ꇔꗖ뗘鏚룜뻞藠곢\udce4ꏦ胨駪ꇬ蛮雰鯲致뗶飸觺돼黾氀昂娄䘆㨈㴊㠌㨎⤐", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.radErgCtrlHeadO9DirLightBarName_A36558.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgCtrlHeadO9DirLightBarName_A36558.DataTransferOrder = -1;
			this.radErgCtrlHeadO9DirLightBarBCO_A36559 = new global::AcpBusinessLayer.AcpSparseLOVField(120, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexRadErgCtrlHeadO9DirLightBarBCO_A36559LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idRadErgCtrlHeadO9DirLightBarBCO_A36559LovStrs), this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐郒ꇔꗖ뗘鏚룜뻞藠곢\udce4ꏦ胨駪ꇬ蛮雰鯲致뗶飸觺뿼볾一専䐄㐆㼈㸊㠌㘎", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.RadErgCtrlHeadO9DirLightBarBCO_A36559LovStrs);
			this.radErgCtrlHeadO9DirLightBarBCO_A36559.IgnoreOnCompare = true;
			this.radErgCtrlHeadO9DirLightBarBCO_A36559.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgCtrlHeadO9DirLightBarBCO_A36559.DataTransferOrder = -1;
			this.radErgCtrlHeadO9DirLightBarFeature_A36597 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexRadErgCtrlHeadO9DirLightBarFeature_A36597LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idRadErgCtrlHeadO9DirLightBarFeature_A36597LovStrs), this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐郒ꇔꗖ뗘鏚룜뻞藠곢\udce4ꏦ胨駪ꇬ蛮雰鯲致뗶飸觺민髾怀眂瀄甆氈吊䰌㰎✐☒Ⱄ‖", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.RadErgCtrlHeadO9DirLightBarFeature_A36597LovStrs);
			this.radErgCtrlHeadO9DirLightBarFeature_A36597.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgCtrlHeadO9DirLightBarFeature_A36597.DataTransferOrder = 18;
			this.radErgCtrlHeadO9DirLightBarIndex_A36601 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐郒ꇔꗖ뗘鏚룜뻞藠곢\udce4ꏦ胨駪ꇬ蛮雰鯲致뗶飸觺듼釾攀昂約堆䠈㠊㬌㤎ℐ−", a_), global::CommonResources.AcgResources.ID_INDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.radErgCtrlHeadO9DirLightBarIndex_A36601.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgCtrlHeadO9DirLightBarIndex_A36601.DataTransferOrder = 19;
			this.radErgCtrlHeadO9DirLightBarIndex_A36601.ValidateAcrossRecset = true;
			this.pgrmbleO9DiretionShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("韆軈駊背跎鷐雒體鷘닚꿜뫞闠諢諤触뫨菪苬鷮藰ꏲ蟴鋶諸裺ꧼ雾氀昂", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
			this.pgrmbleO9DiretionShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.pgrmbleO9DiretionShortPressTime.DataTransferOrder = -1;
			this.pgrmbleO9DiretionShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.pgrmbleO9DiretionShortPressTime.ShowHexValue = false;
			this.pgrmbleO9DiretionShortPressTime.ValidateAcrossRecset = true;
			this.pgrmbleO9DiretionLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("韆軈駊背跎鷐雒體鷘닚꿜뫞闠諢諤触ꗨ蓪菬裮ꇰ臲郴蓶諸꿺铼鋾搀", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
			this.pgrmbleO9DiretionLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.pgrmbleO9DiretionLongPressTime.DataTransferOrder = -1;
			this.pgrmbleO9DiretionLongPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.pgrmbleO9DiretionLongPressTime.ShowHexValue = false;
			this.pgrmbleO9DiretionLongPressTime.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菆ꃈ맊꣌곎ꗐ뫒뫔맖룘럚﷜鷞铠韢釤裦蟨飪", a_);
			base.Id = 10610;
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTIONALBUTTONS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060081CE RID: 33230 RVA: 0x007907FC File Offset: 0x0078E9FC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 18;
			short num = (short)1994915841;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_3D6;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_86;
					}
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臒듔돖鳘꧚뫜鳞闠釢觤꿦賨諪觬ꃮ죰럲鳴藶뗸鋺髼韾甀䄂搄甆伈渊氌笎搐愒瀔䠖堘⠚⬜⨞ᠠᐢ", a_)))
					{
						num = (short)868876301;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4B1;
				case 3:
					goto IL_35B;
				case 4:
					goto IL_2D0;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臒듔돖鳘꧚뫜鳞闠釢觤꿦賨諪觬ꃮ죰럲鳴藶뗸鋺髼韾甀䄂搄甆䜈樊怌樎丐划☔№Ⱈ⸚├", a_)))
					{
						num = (short)1643053073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3D6;
				case 6:
					goto IL_1BF;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菒鋔藖铘駚釜髞껠\udae2ꇤ軦鯨軪駬蛮黰鷲꛴鿶雸觺觼꿾猀昂瘄理崈戊怌樎", a_)))
					{
						num = (short)1189740552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BF;
				case 8:
					this.pgrmbleO9DiretionShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("菒鋔藖铘駚釜髞껠\udae2ꇤ軦鯨軪駬蛮黰鷲꛴鿶雸觺觼꿾猀昂瘄理崈戊怌樎", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
					this.pgrmbleO9DiretionShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.pgrmbleO9DiretionShortPressTime.DataTransferOrder = -1;
					this.pgrmbleO9DiretionShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.pgrmbleO9DiretionShortPressTime.ShowHexValue = false;
					this.pgrmbleO9DiretionShortPressTime.ValidateAcrossRecset = true;
					num = (short)2039742470;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)2143354885;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_AB;
				case 11:
					this.radErgCtrlHeadO9DirLightBarIndex_A36601 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("臒듔돖鳘꧚뫜鳞闠釢觤꿦賨諪觬ꃮ죰럲鳴藶뗸鋺髼韾甀䄂搄甆䀈攊椌樎椐䰒吔␖⼘ⴚⴜ⸞", a_), global::CommonResources.AcgResources.ID_INDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.radErgCtrlHeadO9DirLightBarIndex_A36601.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgCtrlHeadO9DirLightBarIndex_A36601.DataTransferOrder = 19;
					this.radErgCtrlHeadO9DirLightBarIndex_A36601.ValidateAcrossRecset = true;
					num = (short)653983754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					num = (short)1663769617;
					short num3 = num;
					num = (short)1376132113;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2D0;
					default:
						num = (short)803733504;
						if (num != 0)
						{
						}
						this.radErgCtrlHeadO9DirLightBarBCO_A36559 = new global::AcpBusinessLayer.AcpSparseLOVField(120, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexRadErgCtrlHeadO9DirLightBarBCO_A36559LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idRadErgCtrlHeadO9DirLightBarBCO_A36559LovStrs), this, global::AllFeatures.CodeplugGuid.b("臒듔돖鳘꧚뫜鳞闠釢觤꿦賨諪觬ꃮ죰럲鳴藶뗸鋺髼韾甀䄂搄甆䬈䠊䈌倎倐‒⌔∖Ⱈ√", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.RadErgCtrlHeadO9DirLightBarBCO_A36559LovStrs);
						this.radErgCtrlHeadO9DirLightBarBCO_A36559.IgnoreOnCompare = true;
						this.radErgCtrlHeadO9DirLightBarBCO_A36559.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.radErgCtrlHeadO9DirLightBarBCO_A36559.DataTransferOrder = -1;
						num = (short)689963026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 13:
					this.radErgCtrlHeadO9DirLightBarFeature_A36597 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexRadErgCtrlHeadO9DirLightBarFeature_A36597LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idRadErgCtrlHeadO9DirLightBarFeature_A36597LovStrs), this, global::AllFeatures.CodeplugGuid.b("臒듔돖鳘꧚뫜鳞闠釢觤꿦賨諪觬ꃮ죰럲鳴藶뗸鋺髼韾甀䄂搄甆伈渊氌笎搐愒瀔䠖堘⠚⬜⨞ᠠᐢ", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.RadErgCtrlHeadO9DirLightBarFeature_A36597LovStrs);
					this.radErgCtrlHeadO9DirLightBarFeature_A36597.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgCtrlHeadO9DirLightBarFeature_A36597.DataTransferOrder = 18;
					num = (short)485163023;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菒鋔藖铘駚釜髞껠\udae2ꇤ軦鯨軪駬蛮黰鷲맴飶韸鳺근跾搀瀂瘄匆怈昊栌", a_)))
					{
						num = (short)388890628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_623;
				case 15:
					goto IL_4B1;
				case 16:
					num = (short)276299796;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					this.radErgCtrlHeadO9DirLightBarName_A36558 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_LEFT, this, global::AllFeatures.CodeplugGuid.b("臒듔돖鳘꧚뫜鳞闠釢觤꿦賨諪觬ꃮ죰럲鳴藶뗸鋺髼韾甀䄂搄甆䜈樊怌樎丐划☔№Ⱈ⸚├", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.radErgCtrlHeadO9DirLightBarName_A36558.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgCtrlHeadO9DirLightBarName_A36558.DataTransferOrder = -1;
					num = (short)104202240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_38A;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臒듔돖鳘꧚뫜鳞闠釢觤꿦賨諪觬ꃮ죰럲鳴藶뗸鋺髼韾甀䄂搄甆䬈䠊䈌倎倐‒⌔∖Ⱈ√", a_)))
					{
						num = (short)1281556492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_38A;
				case 20:
					num = (short)857669633;
					if (num != 0)
					{
					}
					if (producerFields != null)
					{
						num = (short)1884160009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_623;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臒듔돖鳘꧚뫜鳞闠釢觤꿦賨諪觬ꃮ죰럲鳴藶뗸鋺髼韾甀䄂搄甆䀈攊椌樎椐䰒吔␖⼘ⴚⴜ⸞", a_)))
					{
						num = (short)813891595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AB;
				}
				IL_86:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)480313360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_623;
				IL_AB:
				num = (short)1961754631;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1BF:
				num = (short)1324089358;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D0:
				this.pgrmbleO9DiretionLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("菒鋔藖铘駚釜髞껠\udae2ꇤ軦鯨軪駬蛮黰鷲맴飶韸鳺근跾搀瀂瘄匆怈昊栌", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
				this.pgrmbleO9DiretionLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
				this.pgrmbleO9DiretionLongPressTime.DataTransferOrder = -1;
				this.pgrmbleO9DiretionLongPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
				this.pgrmbleO9DiretionLongPressTime.ShowHexValue = false;
				this.pgrmbleO9DiretionLongPressTime.ValidateAcrossRecset = true;
				num = (short)1685258243;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_38A:
				num = (short)275447810;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3D6:
				num = (short)584253459;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4B1:
				num = (short)2080309269;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_35B:
			num = (short)619118592;
			short num4 = num;
			IL_623:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("韒볔ꗖ볘룚꧜뛞軠跢蓤详짨ꧪ飬鯮藰鳲鯴蓶", a_);
			base.Id = 10610;
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTIONALBUTTONS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060081CF RID: 33231 RVA: 0x00790E60 File Offset: 0x0078F060
		public override void PopulateReferences()
		{
			short num = (short)1620180992;
			short num2 = num;
			num = (short)340512637;
			short num3 = num;
			num = (short)234803069;
			switch (num3 == num)
			{
			}
			num = (short)455409665;
			if (num != 0)
			{
			}
			num = (short)2133524480;
			if (num != 0)
			{
			}
			this.radErgCtrlHeadO9DirLightBarIndex_A36601.SetRecset(this.a(2045)[0][10604].EmbeddedRecset);
		}

		// Token: 0x060081D0 RID: 33232 RVA: 0x00790F34 File Offset: 0x0078F134
		public override void DropReferences()
		{
			short num = (short)2024472576;
			short num2 = num;
			num = (short)995659957;
			short num3 = num;
			num = (short)1790021813;
			switch (num3 == num)
			{
			}
			num = (short)1015939072;
			if (num != 0)
			{
			}
			num = (short)1815347201;
			if (num != 0)
			{
			}
		}

		// Token: 0x060081D1 RID: 33233 RVA: 0x00790FE0 File Offset: 0x0078F1E0
		public override void SetConstraints()
		{
			short num = (short)1827274752;
			short num2 = num;
			num = (short)1109019435;
			short num3 = num;
			num = (short)1961315115;
			switch (num3 == num)
			{
			}
			num = (short)601161729;
			if (num != 0)
			{
			}
			num = (short)1358626816;
			if (num != 0)
			{
			}
			this.radErgCtrlHeadO9DirLightBarName_A36558.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radErgCtrlHeadO9DirLightBarFeature_A36597.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConDirectionalLightBarFeatureisApplicableWhenUniversalRelayControllerEquipped);
			this.radErgCtrlHeadO9DirLightBarFeature_A36597.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConDirectionalLightBarFeatureisValid);
			this.radErgCtrlHeadO9DirLightBarFeature_A36597.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableEditable);
			this.radErgCtrlHeadO9DirLightBarFeature_A36597.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConSetDirectionalButtonIndex);
			this.radErgCtrlHeadO9DirLightBarIndex_A36601.ValidateAcrossRecset = true;
			this.radErgCtrlHeadO9DirLightBarIndex_A36601.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConDirectionalLightBarIndexisApplicableWhenUniversalRelayControllerEquipped);
			this.radErgCtrlHeadO9DirLightBarIndex_A36601.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConACorRelayPatternUniqueinTopandBottomandDirLightTBL);
			this.radErgCtrlHeadO9DirLightBarIndex_A36601.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableEditable);
			this.radErgCtrlHeadO9DirLightBarIndex_A36601.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConValueSetDirLightingButtonsIndex);
		}

		// Token: 0x060081D2 RID: 33234 RVA: 0x00791164 File Offset: 0x0078F364
		public override void SetupDependencies()
		{
			short num = (short)709296128;
			short num2 = num;
			num = (short)2032009217;
			if (num != 0)
			{
			}
			num = (short)1032346888;
			short num3 = num;
			num = (short)832265480;
			switch (num3 == num)
			{
			}
			num = (short)2067136512;
			if (num != 0)
			{
			}
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgCtrlHeadO9DirLightBarFeature_A36597);
			this.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.AddDependentObject(this.radErgCtrlHeadO9DirLightBarFeature_A36597);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgCtrlHeadO9DirLightBarIndex_A36601);
			this.radErgCtrlHeadO9DirLightBarBCO_A36559.AddDependentObject(this.radErgCtrlHeadO9DirLightBarIndex_A36601);
			this.radErgCtrlHeadO9DirLightBarFeature_A36597.AddDependentObject(this.radErgCtrlHeadO9DirLightBarIndex_A36601);
			this.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.AddDependentObject(this.radErgCtrlHeadO9DirLightBarIndex_A36601);
		}

		// Token: 0x1700421B RID: 16923
		// (get) Token: 0x060081D3 RID: 33235 RVA: 0x007912A0 File Offset: 0x0078F4A0
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner GeneralLightbarPatternInnerSectionForRadErgCtrlHeadO9DirLightBarIndex_A36601
		{
			get
			{
				short num = (short)813826048;
				short num2 = num;
				num = (short)122137614;
				short num3 = num;
				num = (short)657173518;
				switch (num3 == num)
				{
				}
				num = (short)1276182529;
				if (num != 0)
				{
				}
				num = (short)222887936;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarIndex_A36601.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner;
			}
		}

		// Token: 0x1700421C RID: 16924
		// (get) Token: 0x060081D4 RID: 33236 RVA: 0x0079135C File Offset: 0x0078F55C
		public bool HasDiffs
		{
			get
			{
				short num = (short)268894208;
				short num2 = num;
				num = (short)799108596;
				short num3 = num;
				num = (short)658271732;
				switch (num3 == num)
				{
				}
				num = (short)1494745089;
				if (num != 0)
				{
				}
				num = (short)926220288;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700421D RID: 16925
		// (get) Token: 0x060081D5 RID: 33237 RVA: 0x0079140C File Offset: 0x0078F60C
		// (set) Token: 0x060081D6 RID: 33238 RVA: 0x007914C0 File Offset: 0x0078F6C0
		public string RadErgCtrlHeadO9DirLightBarName_A36558Value
		{
			get
			{
				short num = (short)982777856;
				short num2 = num;
				num = (short)582221825;
				if (num != 0)
				{
				}
				num = (short)1035279667;
				short num3 = num;
				num = (short)671358259;
				switch (num3 == num)
				{
				}
				num = (short)1722679296;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarName_A36558.Value;
			}
			set
			{
				short num = (short)1739849728;
				short num2 = num;
				num = (short)588972033;
				if (num != 0)
				{
				}
				num = (short)1129504271;
				short num3 = num;
				num = (short)2021121551;
				switch (num3 == num)
				{
				}
				num = (short)481230848;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarName_A36558.Value = value;
			}
		}

		// Token: 0x1700421E RID: 16926
		// (get) Token: 0x060081D7 RID: 33239 RVA: 0x00791574 File Offset: 0x0078F774
		public global::AcpBusinessLayer.AcpField<string> RadErgCtrlHeadO9DirLightBarName_A36558
		{
			get
			{
				short num = (short)425787392;
				short num2 = num;
				num = (short)2033057793;
				if (num != 0)
				{
				}
				num = (short)1537492647;
				short num3 = num;
				num = (short)1243432615;
				switch (num3 == num)
				{
				}
				num = (short)2074476544;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarName_A36558;
			}
		}

		// Token: 0x1700421F RID: 16927
		// (get) Token: 0x060081D8 RID: 33240 RVA: 0x00791620 File Offset: 0x0078F820
		// (set) Token: 0x060081D9 RID: 33241 RVA: 0x007916D4 File Offset: 0x0078F8D4
		public string RadErgCtrlHeadO9DirLightBarName_A36558_UIValue
		{
			get
			{
				short num = (short)348127232;
				short num2 = num;
				num = (short)159580161;
				if (num != 0)
				{
				}
				num = (short)1997138609;
				short num3 = num;
				num = (short)1784212145;
				switch (num3 == num)
				{
				}
				num = (short)2023424000;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarName_A36558.Value;
			}
			set
			{
				short num = (short)2040004608;
				short num2 = num;
				num = (short)506003299;
				short num3 = num;
				num = (short)608436067;
				switch (num3 == num)
				{
				}
				num = (short)829685761;
				if (num != 0)
				{
				}
				num = (short)2100494336;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarName_A36558.Value = value;
			}
		}

		// Token: 0x17004220 RID: 16928
		// (get) Token: 0x060081DA RID: 33242 RVA: 0x00791788 File Offset: 0x0078F988
		// (set) Token: 0x060081DB RID: 33243 RVA: 0x00791840 File Offset: 0x0078FA40
		public bool RadErgCtrlHeadO9DirLightBarName_A36558_Applicable
		{
			get
			{
				short num = (short)647036928;
				short num2 = num;
				num = (short)1382491013;
				short num3 = num;
				num = (short)1823744901;
				switch (num3 == num)
				{
				}
				num = (short)739311617;
				if (num != 0)
				{
				}
				num = (short)1763246080;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarName_A36558.Applicable;
			}
			set
			{
				short num = (short)618266624;
				short num2 = num;
				num = (short)587641677;
				short num3 = num;
				num = (short)1119990605;
				switch (num3 == num)
				{
				}
				num = (short)616759297;
				if (num != 0)
				{
				}
				num = (short)1888485376;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarName_A36558.Applicable = value;
			}
		}

		// Token: 0x17004221 RID: 16929
		// (get) Token: 0x060081DC RID: 33244 RVA: 0x007918F4 File Offset: 0x0078FAF4
		// (set) Token: 0x060081DD RID: 33245 RVA: 0x007919A8 File Offset: 0x0078FBA8
		public bool RadErgCtrlHeadO9DirLightBarName_A36558_Valid
		{
			get
			{
				short num = (short)12648448;
				short num2 = num;
				num = (short)1261502465;
				if (num != 0)
				{
				}
				num = (short)843739228;
				short num3 = num;
				num = (short)698052700;
				switch (num3 == num)
				{
				}
				num = (short)715259904;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarName_A36558.Valid;
			}
			set
			{
				short num = (short)800784384;
				short num2 = num;
				num = (short)62595626;
				short num3 = num;
				num = (short)1630282282;
				switch (num3 == num)
				{
				}
				num = (short)1022099456;
				if (num != 0)
				{
				}
				num = (short)1654259713;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarName_A36558.Valid = value;
			}
		}

		// Token: 0x17004222 RID: 16930
		// (get) Token: 0x060081DE RID: 33246 RVA: 0x00791A5C File Offset: 0x0078FC5C
		// (set) Token: 0x060081DF RID: 33247 RVA: 0x00791B10 File Offset: 0x0078FD10
		public bool RadErgCtrlHeadO9DirLightBarName_A36558_Visible
		{
			get
			{
				short num = (short)1717239808;
				short num2 = num;
				num = (short)1381567855;
				short num3 = num;
				num = (short)1662455151;
				switch (num3 == num)
				{
				}
				num = (short)2131034113;
				if (num != 0)
				{
				}
				num = (short)709492736;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarName_A36558.Visible;
			}
			set
			{
				short num = (short)2058092544;
				short num2 = num;
				num = (short)1302534675;
				short num3 = num;
				num = (short)920459795;
				switch (num3 == num)
				{
				}
				num = (short)1371078657;
				if (num != 0)
				{
				}
				num = (short)466223104;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarName_A36558.Visible = value;
			}
		}

		// Token: 0x17004223 RID: 16931
		// (get) Token: 0x060081E0 RID: 33248 RVA: 0x00791BC4 File Offset: 0x0078FDC4
		// (set) Token: 0x060081E1 RID: 33249 RVA: 0x00791C78 File Offset: 0x0078FE78
		public bool RadErgCtrlHeadO9DirLightBarName_A36558_Editable
		{
			get
			{
				short num = (short)1902116864;
				short num2 = num;
				num = (short)1157103857;
				short num3 = num;
				num = (short)254607601;
				switch (num3 == num)
				{
				}
				num = (short)959184896;
				if (num != 0)
				{
				}
				num = (short)691011585;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarName_A36558.Editable;
			}
			set
			{
				short num = (short)1852071136;
				short num2 = num;
				num = (short)1075862752;
				switch (num2 == num)
				{
				default:
				{
					num = (short)373293056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)210567168;
				if (num != 0)
				{
				}
				num = (short)1064304641;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarName_A36558.Editable = value;
			}
		}

		// Token: 0x17004224 RID: 16932
		// (get) Token: 0x060081E2 RID: 33250 RVA: 0x00791D2C File Offset: 0x0078FF2C
		internal string RadErgCtrlHeadO9DirLightBarName_A36558_UILabel
		{
			get
			{
				short num = (short)272039937;
				if (num != 0)
				{
				}
				num = (short)2089222144;
				short num2 = num;
				num = (short)744809620;
				short num3 = num;
				num = (short)1211229332;
				switch (num3 == num)
				{
				}
				num = (short)974848000;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarName_A36558.UIName;
			}
		}

		// Token: 0x17004225 RID: 16933
		// (get) Token: 0x060081E3 RID: 33251 RVA: 0x00791DE4 File Offset: 0x0078FFE4
		// (set) Token: 0x060081E4 RID: 33252 RVA: 0x00791E9C File Offset: 0x0079009C
		internal bool RadErgCtrlHeadO9DirLightBarName_A36558_HiddenStatic
		{
			get
			{
				short num = (short)707830450;
				short num2 = num;
				num = (short)1094034098;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1981022208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2082275328;
				if (num != 0)
				{
				}
				num = (short)413007873;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarName_A36558.HiddenStatic;
			}
			set
			{
				short num = (short)1123811329;
				if (num != 0)
				{
				}
				num = (short)155910144;
				short num2 = num;
				num = (short)1239457804;
				short num3 = num;
				num = (short)1587519500;
				switch (num3 == num)
				{
				}
				num = (short)1249902592;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarName_A36558.HiddenStatic = value;
			}
		}

		// Token: 0x17004226 RID: 16934
		// (get) Token: 0x060081E5 RID: 33253 RVA: 0x00791F54 File Offset: 0x00790154
		// (set) Token: 0x060081E6 RID: 33254 RVA: 0x00792008 File Offset: 0x00790208
		internal bool RadErgCtrlHeadO9DirLightBarName_A36558_HiddenDynamic
		{
			get
			{
				short num = (short)1260816188;
				short num2 = num;
				num = (short)1671071548;
				switch (num2 == num)
				{
				default:
				{
					num = (short)209649664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)113704961;
				if (num != 0)
				{
				}
				num = (short)1975582720;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarName_A36558.HiddenDynamic;
			}
			set
			{
				short num = (short)1800433163;
				short num2 = num;
				num = (short)1991601675;
				switch (num2 == num)
				{
				default:
				{
					num = (short)444792832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1826029569;
				if (num != 0)
				{
				}
				num = (short)725352448;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarName_A36558.HiddenDynamic = value;
			}
		}

		// Token: 0x17004227 RID: 16935
		// (get) Token: 0x060081E7 RID: 33255 RVA: 0x007920C0 File Offset: 0x007902C0
		public bool RadErgCtrlHeadO9DirLightBarName_A36558_HasDiffs
		{
			get
			{
				short num = (short)1805504919;
				short num2 = num;
				num = (short)354210199;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1087569920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)233177089;
				if (num != 0)
				{
				}
				num = (short)860684288;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarName_A36558._HasDiffs;
			}
		}

		// Token: 0x17004228 RID: 16936
		// (get) Token: 0x060081E8 RID: 33256 RVA: 0x00792174 File Offset: 0x00790374
		// (set) Token: 0x060081E9 RID: 33257 RVA: 0x00792228 File Offset: 0x00790428
		public int RadErgCtrlHeadO9DirLightBarBCO_A36559Value
		{
			get
			{
				short num = (short)1712362349;
				short num2 = num;
				num = (short)1536529261;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1494548480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)603127809;
				if (num != 0)
				{
				}
				num = (short)615907328;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarBCO_A36559.Value;
			}
			set
			{
				short num = (short)948389141;
				short num2 = num;
				num = (short)576800021;
				switch (num2 == num)
				{
				default:
				{
					num = (short)855703552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)981925889;
				if (num != 0)
				{
				}
				num = (short)921960448;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarBCO_A36559.Value = value;
			}
		}

		// Token: 0x17004229 RID: 16937
		// (get) Token: 0x060081EA RID: 33258 RVA: 0x007922E0 File Offset: 0x007904E0
		// (set) Token: 0x060081EB RID: 33259 RVA: 0x00792390 File Offset: 0x00790590
		public string RadErgCtrlHeadO9DirLightBarBCO_A36559_UIValue
		{
			get
			{
				short num = (short)55715062;
				short num2 = num;
				num = (short)1536566518;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2015690752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2091122688;
				if (num != 0)
				{
				}
				num = (short)1642856449;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarBCO_A36559.UIValue;
			}
			set
			{
				short num = (short)1613562265;
				short num2 = num;
				num = (short)263192985;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1133772800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1935147009;
				if (num != 0)
				{
				}
				num = (short)51904512;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarBCO_A36559.UIValue = value;
			}
		}

		// Token: 0x1700422A RID: 16938
		// (get) Token: 0x060081EC RID: 33260 RVA: 0x00792444 File Offset: 0x00790644
		public global::AcpBusinessLayer.AcpListField RadErgCtrlHeadO9DirLightBarBCO_A36559
		{
			get
			{
				short num = (short)1029152580;
				short num2 = num;
				num = (short)2013044548;
				switch (num2 == num)
				{
				default:
				{
					num = (short)556924928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)41156609;
				if (num != 0)
				{
				}
				num = (short)1185218560;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarBCO_A36559;
			}
		}

		// Token: 0x1700422B RID: 16939
		// (get) Token: 0x060081ED RID: 33261 RVA: 0x007924F4 File Offset: 0x007906F4
		// (set) Token: 0x060081EE RID: 33262 RVA: 0x007925A8 File Offset: 0x007907A8
		public bool RadErgCtrlHeadO9DirLightBarBCO_A36559_Applicable
		{
			get
			{
				short num = (short)1766373298;
				short num2 = num;
				num = (short)46315442;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1095958528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1321861121;
				if (num != 0)
				{
				}
				num = (short)1690304512;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarBCO_A36559.Applicable;
			}
			set
			{
				short num = (short)493721260;
				short num2 = num;
				num = (short)1739036332;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1319632896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1201274881;
				if (num != 0)
				{
				}
				num = (short)804388864;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarBCO_A36559.Applicable = value;
			}
		}

		// Token: 0x1700422C RID: 16940
		// (get) Token: 0x060081EF RID: 33263 RVA: 0x0079265C File Offset: 0x0079085C
		// (set) Token: 0x060081F0 RID: 33264 RVA: 0x00792710 File Offset: 0x00790910
		public bool RadErgCtrlHeadO9DirLightBarBCO_A36559_Valid
		{
			get
			{
				short num = (short)231484992;
				short num2 = num;
				num = (short)490679872;
				switch (num2 == num)
				{
				default:
				{
					num = (short)259522560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)262864897;
				if (num != 0)
				{
				}
				num = (short)262144;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarBCO_A36559.Valid;
			}
			set
			{
				short num = (short)999882753;
				if (num != 0)
				{
				}
				num = (short)1600454656;
				short num2 = num;
				num = (short)1705962254;
				short num3 = num;
				num = (short)1969679118;
				switch (num3 == num)
				{
				}
				num = (short)1954349056;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarBCO_A36559.Valid = value;
			}
		}

		// Token: 0x1700422D RID: 16941
		// (get) Token: 0x060081F1 RID: 33265 RVA: 0x007927C4 File Offset: 0x007909C4
		// (set) Token: 0x060081F2 RID: 33266 RVA: 0x00792874 File Offset: 0x00790A74
		public bool RadErgCtrlHeadO9DirLightBarBCO_A36559_Visible
		{
			get
			{
				short num = (short)543253305;
				short num2 = num;
				num = (short)1828348729;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1369309184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1969750016;
				if (num != 0)
				{
				}
				num = (short)1607008257;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarBCO_A36559.Visible;
			}
			set
			{
				short num = (short)1233821824;
				short num2 = num;
				num = (short)80322688;
				switch (num2 == num)
				{
				default:
				{
					num = (short)283705344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)762511361;
				if (num != 0)
				{
				}
				num = (short)654573568;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarBCO_A36559.Visible = value;
			}
		}

		// Token: 0x1700422E RID: 16942
		// (get) Token: 0x060081F3 RID: 33267 RVA: 0x00792928 File Offset: 0x00790B28
		// (set) Token: 0x060081F4 RID: 33268 RVA: 0x007929DC File Offset: 0x00790BDC
		public bool RadErgCtrlHeadO9DirLightBarBCO_A36559_Editable
		{
			get
			{
				short num = (short)1025926637;
				short num2 = num;
				num = (short)309749229;
				switch (num2 == num)
				{
				default:
				{
					num = (short)184614912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1273364480;
				if (num != 0)
				{
				}
				num = (short)361103361;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarBCO_A36559.Editable;
			}
			set
			{
				short num = (short)484306605;
				short num2 = num;
				num = (short)837021357;
				switch (num2 == num)
				{
				default:
				{
					num = (short)979304448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)554041344;
				if (num != 0)
				{
				}
				num = (short)678100993;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarBCO_A36559.Editable = value;
			}
		}

		// Token: 0x1700422F RID: 16943
		// (get) Token: 0x060081F5 RID: 33269 RVA: 0x00792A90 File Offset: 0x00790C90
		internal string RadErgCtrlHeadO9DirLightBarBCO_A36559_UILabel
		{
			get
			{
				short num = (short)1481310209;
				if (num != 0)
				{
				}
				num = (short)1040252928;
				short num2 = num;
				num = (short)608206711;
				short num3 = num;
				num = (short)798588791;
				switch (num3 == num)
				{
				}
				num = (short)1600126976;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarBCO_A36559.UIName;
			}
		}

		// Token: 0x17004230 RID: 16944
		// (get) Token: 0x060081F6 RID: 33270 RVA: 0x00792B44 File Offset: 0x00790D44
		// (set) Token: 0x060081F7 RID: 33271 RVA: 0x00792BF8 File Offset: 0x00790DF8
		internal bool RadErgCtrlHeadO9DirLightBarBCO_A36559_HiddenStatic
		{
			get
			{
				short num = (short)1742405633;
				if (num != 0)
				{
				}
				num = (short)1345323008;
				short num2 = num;
				num = (short)1469447308;
				short num3 = num;
				num = (short)1731918988;
				switch (num3 == num)
				{
				}
				num = (short)1239875584;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarBCO_A36559.HiddenStatic;
			}
			set
			{
				short num = (short)1234184868;
				short num2 = num;
				num = (short)474294948;
				switch (num2 == num)
				{
				default:
				{
					num = (short)754188288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2093678593;
				if (num != 0)
				{
				}
				num = (short)1137573888;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarBCO_A36559.HiddenStatic = value;
			}
		}

		// Token: 0x17004231 RID: 16945
		// (get) Token: 0x060081F8 RID: 33272 RVA: 0x00792CB0 File Offset: 0x00790EB0
		// (set) Token: 0x060081F9 RID: 33273 RVA: 0x00792D68 File Offset: 0x00790F68
		internal bool RadErgCtrlHeadO9DirLightBarBCO_A36559_HiddenDynamic
		{
			get
			{
				short num = (short)1602551809;
				if (num != 0)
				{
				}
				num = (short)1992818688;
				short num2 = num;
				num = (short)734921906;
				short num3 = num;
				num = (short)1035470002;
				switch (num3 == num)
				{
				}
				num = (short)1480458240;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarBCO_A36559.HiddenDynamic;
			}
			set
			{
				short num = (short)669931504;
				short num2 = num;
				num = (short)1812617200;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1274609664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)271319040;
				if (num != 0)
				{
				}
				num = (short)295239681;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarBCO_A36559.HiddenDynamic = value;
			}
		}

		// Token: 0x17004232 RID: 16946
		// (get) Token: 0x060081FA RID: 33274 RVA: 0x00792E1C File Offset: 0x0079101C
		public bool RadErgCtrlHeadO9DirLightBarBCO_A36559_HasDiffs
		{
			get
			{
				short num = (short)2054124334;
				short num2 = num;
				num = (short)1579578158;
				switch (num2 == num)
				{
				default:
				{
					num = (short)287571968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1043857409;
				if (num != 0)
				{
				}
				num = (short)1890058240;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarBCO_A36559._HasDiffs;
			}
		}

		// Token: 0x17004233 RID: 16947
		// (get) Token: 0x060081FB RID: 33275 RVA: 0x00792ED0 File Offset: 0x007910D0
		// (set) Token: 0x060081FC RID: 33276 RVA: 0x00792F84 File Offset: 0x00791184
		public int RadErgCtrlHeadO9DirLightBarFeature_A36597Value
		{
			get
			{
				short num = (short)1225654273;
				if (num != 0)
				{
				}
				num = (short)1614413824;
				short num2 = num;
				num = (short)717440684;
				short num3 = num;
				num = (short)167986860;
				switch (num3 == num)
				{
				}
				num = (short)2118778880;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarFeature_A36597.Value;
			}
			set
			{
				short num = (short)999290021;
				short num2 = num;
				num = (short)373879973;
				switch (num2 == num)
				{
				default:
				{
					num = (short)634781696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1383858176;
				if (num != 0)
				{
				}
				num = (short)1510998017;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarFeature_A36597.Value = value;
			}
		}

		// Token: 0x17004234 RID: 16948
		// (get) Token: 0x060081FD RID: 33277 RVA: 0x0079303C File Offset: 0x0079123C
		// (set) Token: 0x060081FE RID: 33278 RVA: 0x007930F0 File Offset: 0x007912F0
		public string RadErgCtrlHeadO9DirLightBarFeature_A36597_UIValue
		{
			get
			{
				short num = (short)1055328823;
				short num2 = num;
				num = (short)748816951;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1963327488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2130903041;
				if (num != 0)
				{
				}
				num = (short)606732288;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarFeature_A36597.UIValue;
			}
			set
			{
				short num = (short)879187209;
				short num2 = num;
				num = (short)1826051337;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1150681088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)260243457;
				if (num != 0)
				{
				}
				num = (short)1720254464;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarFeature_A36597.UIValue = value;
			}
		}

		// Token: 0x17004235 RID: 16949
		// (get) Token: 0x060081FF RID: 33279 RVA: 0x007931A4 File Offset: 0x007913A4
		public global::AcpBusinessLayer.AcpListField RadErgCtrlHeadO9DirLightBarFeature_A36597
		{
			get
			{
				short num = (short)1650187690;
				short num2 = num;
				num = (short)198958506;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1436418048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)35454977;
				if (num != 0)
				{
				}
				num = (short)295960576;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarFeature_A36597;
			}
		}

		// Token: 0x17004236 RID: 16950
		// (get) Token: 0x06008200 RID: 33280 RVA: 0x00793250 File Offset: 0x00791450
		// (set) Token: 0x06008201 RID: 33281 RVA: 0x00793304 File Offset: 0x00791504
		public bool RadErgCtrlHeadO9DirLightBarFeature_A36597_Applicable
		{
			get
			{
				short num = (short)1045841862;
				short num2 = num;
				num = (short)1480083398;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1706164224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1484259328;
				if (num != 0)
				{
				}
				num = (short)1631322113;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarFeature_A36597.Applicable;
			}
			set
			{
				short num = (short)1291615576;
				short num2 = num;
				num = (short)116620632;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2060451840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1141506049;
				if (num != 0)
				{
				}
				num = (short)1737359360;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarFeature_A36597.Applicable = value;
			}
		}

		// Token: 0x17004237 RID: 16951
		// (get) Token: 0x06008202 RID: 33282 RVA: 0x007933BC File Offset: 0x007915BC
		// (set) Token: 0x06008203 RID: 33283 RVA: 0x00793470 File Offset: 0x00791670
		public bool RadErgCtrlHeadO9DirLightBarFeature_A36597_Valid
		{
			get
			{
				short num = (short)767189887;
				short num2 = num;
				num = (short)364864383;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1714094080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1154678785;
				if (num != 0)
				{
				}
				num = (short)937885696;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarFeature_A36597.Valid;
			}
			set
			{
				short num = (short)1198998484;
				short num2 = num;
				num = (short)1005142996;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1916076032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1368522752;
				if (num != 0)
				{
				}
				num = (short)1307377665;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarFeature_A36597.Valid = value;
			}
		}

		// Token: 0x17004238 RID: 16952
		// (get) Token: 0x06008204 RID: 33284 RVA: 0x00793528 File Offset: 0x00791728
		// (set) Token: 0x06008205 RID: 33285 RVA: 0x007935DC File Offset: 0x007917DC
		public bool RadErgCtrlHeadO9DirLightBarFeature_A36597_Visible
		{
			get
			{
				short num = (short)332897652;
				short num2 = num;
				num = (short)2040110452;
				switch (num2 == num)
				{
				default:
				{
					num = (short)7602176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)892207105;
				if (num != 0)
				{
				}
				num = (short)505610240;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarFeature_A36597.Visible;
			}
			set
			{
				short num = (short)359596033;
				if (num != 0)
				{
				}
				num = (short)397541376;
				short num2 = num;
				num = (short)303200607;
				short num3 = num;
				num = (short)799308127;
				switch (num3 == num)
				{
				}
				num = (short)154796032;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarFeature_A36597.Visible = value;
			}
		}

		// Token: 0x17004239 RID: 16953
		// (get) Token: 0x06008206 RID: 33286 RVA: 0x00793694 File Offset: 0x00791894
		// (set) Token: 0x06008207 RID: 33287 RVA: 0x00793748 File Offset: 0x00791948
		public bool RadErgCtrlHeadO9DirLightBarFeature_A36597_Editable
		{
			get
			{
				short num = (short)168963952;
				short num2 = num;
				num = (short)1072312176;
				switch (num2 == num)
				{
				default:
				{
					num = (short)445841408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2007040001;
				if (num != 0)
				{
				}
				num = (short)337117184;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarFeature_A36597.Editable;
			}
			set
			{
				short num = (short)779815288;
				short num2 = num;
				num = (short)1419446648;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1730150400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)71041025;
				if (num != 0)
				{
				}
				num = (short)1731461120;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarFeature_A36597.Editable = value;
			}
		}

		// Token: 0x1700423A RID: 16954
		// (get) Token: 0x06008208 RID: 33288 RVA: 0x007937FC File Offset: 0x007919FC
		internal string RadErgCtrlHeadO9DirLightBarFeature_A36597_UILabel
		{
			get
			{
				short num = (short)1871642625;
				if (num != 0)
				{
				}
				num = (short)1050476544;
				short num2 = num;
				num = (short)484826399;
				short num3 = num;
				num = (short)1414257951;
				switch (num3 == num)
				{
				}
				num = (short)1393360896;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarFeature_A36597.UIName;
			}
		}

		// Token: 0x1700423B RID: 16955
		// (get) Token: 0x06008209 RID: 33289 RVA: 0x007938B0 File Offset: 0x00791AB0
		// (set) Token: 0x0600820A RID: 33290 RVA: 0x00793964 File Offset: 0x00791B64
		internal bool RadErgCtrlHeadO9DirLightBarFeature_A36597_HiddenStatic
		{
			get
			{
				short num = (short)2145487729;
				short num2 = num;
				num = (short)385715057;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1082916864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1618477057;
				if (num != 0)
				{
				}
				num = (short)1570045952;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarFeature_A36597.HiddenStatic;
			}
			set
			{
				short num = (short)1674647712;
				short num2 = num;
				num = (short)429332640;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1173946368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1058144256;
				if (num != 0)
				{
				}
				num = (short)1380843521;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarFeature_A36597.HiddenStatic = value;
			}
		}

		// Token: 0x1700423C RID: 16956
		// (get) Token: 0x0600820B RID: 33291 RVA: 0x00793A18 File Offset: 0x00791C18
		// (set) Token: 0x0600820C RID: 33292 RVA: 0x00793AD0 File Offset: 0x00791CD0
		internal bool RadErgCtrlHeadO9DirLightBarFeature_A36597_HiddenDynamic
		{
			get
			{
				short num = (short)791543809;
				if (num != 0)
				{
				}
				num = (short)1818427392;
				short num2 = num;
				num = (short)777201887;
				short num3 = num;
				num = (short)1620650207;
				switch (num3 == num)
				{
				}
				num = (short)1406664704;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarFeature_A36597.HiddenDynamic;
			}
			set
			{
				short num = (short)1947334717;
				short num2 = num;
				num = (short)2147088445;
				switch (num2 == num)
				{
				default:
				{
					num = (short)861798400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1021116417;
				if (num != 0)
				{
				}
				num = (short)1603928064;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarFeature_A36597.HiddenDynamic = value;
			}
		}

		// Token: 0x1700423D RID: 16957
		// (get) Token: 0x0600820D RID: 33293 RVA: 0x00793B88 File Offset: 0x00791D88
		public bool RadErgCtrlHeadO9DirLightBarFeature_A36597_HasDiffs
		{
			get
			{
				short num = (short)1452268662;
				short num2 = num;
				num = (short)1184619638;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1370947584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)344064001;
				if (num != 0)
				{
				}
				num = (short)1620967424;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarFeature_A36597._HasDiffs;
			}
		}

		// Token: 0x1700423E RID: 16958
		// (get) Token: 0x0600820E RID: 33294 RVA: 0x00793C3C File Offset: 0x00791E3C
		// (set) Token: 0x0600820F RID: 33295 RVA: 0x00793CF0 File Offset: 0x00791EF0
		public int RadErgCtrlHeadO9DirLightBarIndex_A36601Value
		{
			get
			{
				short num = (short)625387363;
				short num2 = num;
				num = (short)1861592931;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1047461888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)852361217;
				if (num != 0)
				{
				}
				num = (short)335085568;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarIndex_A36601.Value;
			}
			set
			{
				short num = (short)2078028543;
				short num2 = num;
				num = (short)1235432191;
				switch (num2 == num)
				{
				default:
				{
					num = (short)260374528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1689845761;
				if (num != 0)
				{
				}
				num = (short)843776000;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarIndex_A36601.Value = value;
			}
		}

		// Token: 0x1700423F RID: 16959
		// (get) Token: 0x06008210 RID: 33296 RVA: 0x00793DA4 File Offset: 0x00791FA4
		// (set) Token: 0x06008211 RID: 33297 RVA: 0x00793E58 File Offset: 0x00792058
		public string RadErgCtrlHeadO9DirLightBarIndex_A36601_UIValue
		{
			get
			{
				short num = (short)25585846;
				short num2 = num;
				num = (short)49440950;
				switch (num2 == num)
				{
				default:
				{
					num = (short)23461888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1634271232;
				if (num != 0)
				{
				}
				num = (short)139591681;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarIndex_A36601.UIValue;
			}
			set
			{
				short num = (short)1953890305;
				if (num != 0)
				{
				}
				num = (short)1964703744;
				short num2 = num;
				num = (short)2072704325;
				short num3 = num;
				num = (short)2056582469;
				switch (num3 == num)
				{
				}
				num = (short)546111488;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarIndex_A36601.UIValue = value;
			}
		}

		// Token: 0x17004240 RID: 16960
		// (get) Token: 0x06008212 RID: 33298 RVA: 0x00793F10 File Offset: 0x00792110
		public global::AcpBusinessLayer.AcpRecRefField RadErgCtrlHeadO9DirLightBarIndex_A36601
		{
			get
			{
				short num = (short)965804033;
				if (num != 0)
				{
				}
				num = (short)529858560;
				short num2 = num;
				num = (short)1017235518;
				short num3 = num;
				num = (short)1777780798;
				switch (num3 == num)
				{
				}
				num = (short)1113849856;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarIndex_A36601;
			}
		}

		// Token: 0x17004241 RID: 16961
		// (get) Token: 0x06008213 RID: 33299 RVA: 0x00793FC0 File Offset: 0x007921C0
		// (set) Token: 0x06008214 RID: 33300 RVA: 0x00794074 File Offset: 0x00792274
		public bool RadErgCtrlHeadO9DirLightBarIndex_A36601_Applicable
		{
			get
			{
				short num = (short)9375011;
				short num2 = num;
				num = (short)1137708323;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1196294144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1468858369;
				if (num != 0)
				{
				}
				num = (short)1129381888;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarIndex_A36601.Applicable;
			}
			set
			{
				short num = (short)1315209642;
				short num2 = num;
				num = (short)355303850;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2090467328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)906690561;
				if (num != 0)
				{
				}
				num = (short)466354176;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarIndex_A36601.Applicable = value;
			}
		}

		// Token: 0x17004242 RID: 16962
		// (get) Token: 0x06008215 RID: 33301 RVA: 0x0079412C File Offset: 0x0079232C
		// (set) Token: 0x06008216 RID: 33302 RVA: 0x007941E4 File Offset: 0x007923E4
		public bool RadErgCtrlHeadO9DirLightBarIndex_A36601_Valid
		{
			get
			{
				short num = (short)877176705;
				short num2 = num;
				num = (short)1347725185;
				switch (num2 == num)
				{
				default:
				{
					num = (short)649330688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1066401792;
				if (num != 0)
				{
				}
				num = (short)1668153345;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarIndex_A36601.Valid;
			}
			set
			{
				short num = (short)767372134;
				short num2 = num;
				num = (short)182987622;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2091319296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1555955713;
				if (num != 0)
				{
				}
				num = (short)1654390784;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DirLightBarIndex_A36601.Valid = value;
			}
		}

		// Token: 0x17004243 RID: 16963
		// (get) Token: 0x06008217 RID: 33303 RVA: 0x00794298 File Offset: 0x00792498
		// (set) Token: 0x06008218 RID: 33304 RVA: 0x00794350 File Offset: 0x00792550
		public bool RadErgCtrlHeadO9DirLightBarIndex_A36601_Visible
		{
			get
			{
				short num = (short)1481408890;
				short num2 = num;
				num = (short)1913815418;
				switch (num2 == num)
				{
				default:
				{
					num = (short)425721856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2088435712;
				if (num != 0)
				{
				}
				num = (short)590741505;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DirLightBarIndex_A36601.Visible;
			}
			set
			{
				short num = (short)829907027;
				short num2 = num;
				num = (short)1921998931;
				switch (num2 == num)
				{
				}
				num = (short)1860698112;
				if (num != 0)
				{
				}
				num = (short)1503526913;
				if (num != 0)
				{
				}
				num = (short)1531183104;
				short num3 = num;
				this.radErgCtrlHeadO9DirLightBarIndex_A36601.Visible = value;
			}
		}

		// Token: 0x17004244 RID: 16964
		// (get) Token: 0x06008219 RID: 33305 RVA: 0x00794408 File Offset: 0x00792608
		// (set) Token: 0x0600821A RID: 33306 RVA: 0x007944BC File Offset: 0x007926BC
		public bool RadErgCtrlHeadO9DirLightBarIndex_A36601_Editable
		{
			get
			{
				short num = (short)1858255344;
				short num2 = num;
				num = (short)97237488;
				switch (num2 == num)
				{
				}
				num = (short)600047617;
				if (num != 0)
				{
				}
				num = (short)1660878848;
				if (num != 0)
				{
				}
				num = (short)1699807232;
				short num3 = num;
				return this.radErgCtrlHeadO9DirLightBarIndex_A36601.Editable;
			}
			set
			{
				short num = (short)713727487;
				short num2 = num;
				num = (short)1425513983;
				switch (num2 == num)
				{
				}
				num = (short)1200226304;
				if (num != 0)
				{
				}
				num = (short)1135607809;
				if (num != 0)
				{
				}
				num = (short)1486880768;
				short num3 = num;
				this.radErgCtrlHeadO9DirLightBarIndex_A36601.Editable = value;
			}
		}

		// Token: 0x17004245 RID: 16965
		// (get) Token: 0x0600821B RID: 33307 RVA: 0x00794574 File Offset: 0x00792774
		internal string RadErgCtrlHeadO9DirLightBarIndex_A36601_UILabel
		{
			get
			{
				short num = (short)547833883;
				short num2 = num;
				num = (short)746145819;
				switch (num2 == num)
				{
				}
				num = (short)1598160897;
				if (num != 0)
				{
				}
				num = (short)95879168;
				if (num != 0)
				{
				}
				num = (short)1213530112;
				short num3 = num;
				return this.radErgCtrlHeadO9DirLightBarIndex_A36601.UIName;
			}
		}

		// Token: 0x17004246 RID: 16966
		// (get) Token: 0x0600821C RID: 33308 RVA: 0x00794628 File Offset: 0x00792828
		// (set) Token: 0x0600821D RID: 33309 RVA: 0x007946DC File Offset: 0x007928DC
		internal bool RadErgCtrlHeadO9DirLightBarIndex_A36601_HiddenStatic
		{
			get
			{
				short num = (short)721556494;
				short num2 = num;
				num = (short)1823937550;
				switch (num2 == num)
				{
				}
				num = (short)354942976;
				if (num != 0)
				{
				}
				num = (short)134676481;
				if (num != 0)
				{
				}
				num = (short)1134166016;
				short num3 = num;
				return this.radErgCtrlHeadO9DirLightBarIndex_A36601.HiddenStatic;
			}
			set
			{
				short num = (short)663299934;
				short num2 = num;
				num = (short)1970808670;
				switch (num2 == num)
				{
				}
				num = (short)1018560513;
				if (num != 0)
				{
				}
				num = (short)1892679680;
				if (num != 0)
				{
				}
				num = (short)2013462528;
				short num3 = num;
				this.radErgCtrlHeadO9DirLightBarIndex_A36601.HiddenStatic = value;
			}
		}

		// Token: 0x17004247 RID: 16967
		// (get) Token: 0x0600821E RID: 33310 RVA: 0x00794794 File Offset: 0x00792994
		// (set) Token: 0x0600821F RID: 33311 RVA: 0x0079484C File Offset: 0x00792A4C
		internal bool RadErgCtrlHeadO9DirLightBarIndex_A36601_HiddenDynamic
		{
			get
			{
				short num = (short)340319474;
				short num2 = num;
				num = (short)1265556722;
				switch (num2 == num)
				{
				}
				num = (short)537657345;
				if (num != 0)
				{
				}
				num = (short)846397440;
				if (num != 0)
				{
				}
				num = (short)1619853312;
				short num3 = num;
				return this.radErgCtrlHeadO9DirLightBarIndex_A36601.HiddenDynamic;
			}
			set
			{
				short num = (short)326207797;
				short num2 = num;
				num = (short)1644726581;
				switch (num2 == num)
				{
				}
				num = (short)451739649;
				if (num != 0)
				{
				}
				num = (short)315883520;
				if (num != 0)
				{
				}
				num = (short)886636544;
				short num3 = num;
				this.radErgCtrlHeadO9DirLightBarIndex_A36601.HiddenDynamic = value;
			}
		}

		// Token: 0x17004248 RID: 16968
		// (get) Token: 0x06008220 RID: 33312 RVA: 0x00794904 File Offset: 0x00792B04
		public bool RadErgCtrlHeadO9DirLightBarIndex_A36601_HasDiffs
		{
			get
			{
				short num = (short)477753355;
				short num2 = num;
				num = (short)167833611;
				switch (num2 == num)
				{
				}
				num = (short)947650560;
				if (num != 0)
				{
				}
				num = (short)350027777;
				if (num != 0)
				{
				}
				num = (short)1980694528;
				short num3 = num;
				return this.radErgCtrlHeadO9DirLightBarIndex_A36601._HasDiffs;
			}
		}

		// Token: 0x17004249 RID: 16969
		// (get) Token: 0x06008221 RID: 33313 RVA: 0x007949B8 File Offset: 0x00792BB8
		// (set) Token: 0x06008222 RID: 33314 RVA: 0x00794A70 File Offset: 0x00792C70
		public int PGRMBLEO9DiretionShortPressTimeValue
		{
			get
			{
				short num = (short)410535755;
				short num2 = num;
				num = (short)988432203;
				switch (num2 == num)
				{
				}
				num = (short)1236860929;
				if (num != 0)
				{
				}
				num = (short)704184320;
				if (num != 0)
				{
				}
				num = (short)172621824;
				short num3 = num;
				return this.pgrmbleO9DiretionShortPressTime.Value;
			}
			set
			{
				short num = (short)1108195794;
				short num2 = num;
				num = (short)1077918162;
				switch (num2 == num)
				{
				}
				num = (short)449183744;
				if (num != 0)
				{
				}
				num = (short)1893466113;
				if (num != 0)
				{
				}
				num = (short)1866006528;
				short num3 = num;
				this.pgrmbleO9DiretionShortPressTime.Value = value;
			}
		}

		// Token: 0x1700424A RID: 16970
		// (get) Token: 0x06008223 RID: 33315 RVA: 0x00794B24 File Offset: 0x00792D24
		// (set) Token: 0x06008224 RID: 33316 RVA: 0x00794BD8 File Offset: 0x00792DD8
		public string PGRMBLEO9DiretionShortPressTime_UIValue
		{
			get
			{
				short num = (short)350552065;
				if (num != 0)
				{
				}
				num = (short)812982764;
				short num2 = num;
				num = (short)12394988;
				switch (num2 == num)
				{
				}
				num = (short)2107047936;
				if (num != 0)
				{
				}
				num = (short)2026045440;
				short num3 = num;
				return this.pgrmbleO9DiretionShortPressTime.UIValue;
			}
			set
			{
				short num = (short)666588211;
				short num2 = num;
				num = (short)348673075;
				switch (num2 == num)
				{
				}
				num = (short)102498305;
				if (num != 0)
				{
				}
				num = (short)2038497280;
				if (num != 0)
				{
				}
				num = (short)1567358976;
				short num3 = num;
				this.pgrmbleO9DiretionShortPressTime.UIValue = value;
			}
		}

		// Token: 0x1700424B RID: 16971
		// (get) Token: 0x06008225 RID: 33317 RVA: 0x00794C8C File Offset: 0x00792E8C
		public global::AcpBusinessLayer.AcpSimpleRangeField PGRMBLEO9DiretionShortPressTime
		{
			get
			{
				short num = (short)564351704;
				short num2 = num;
				num = (short)99767000;
				switch (num2 == num)
				{
				}
				num = (short)1135542273;
				if (num != 0)
				{
				}
				num = (short)1581514752;
				if (num != 0)
				{
				}
				num = (short)676986880;
				short num3 = num;
				return this.pgrmbleO9DiretionShortPressTime;
			}
		}

		// Token: 0x1700424C RID: 16972
		// (get) Token: 0x06008226 RID: 33318 RVA: 0x00794D38 File Offset: 0x00792F38
		// (set) Token: 0x06008227 RID: 33319 RVA: 0x00794DEC File Offset: 0x00792FEC
		internal int PGRMBLEO9DiretionShortPressTimeMin
		{
			get
			{
				short num = (short)1749549057;
				if (num != 0)
				{
				}
				num = (short)290361547;
				short num2 = num;
				num = (short)454660299;
				switch (num2 == num)
				{
				}
				num = (short)1546584064;
				if (num != 0)
				{
				}
				num = (short)488177664;
				short num3 = num;
				return this.pgrmbleO9DiretionShortPressTime.Min;
			}
			set
			{
				short num = (short)199229441;
				if (num != 0)
				{
				}
				num = (short)1909354927;
				short num2 = num;
				num = (short)881357231;
				switch (num2 == num)
				{
				}
				num = (short)1676017664;
				if (num != 0)
				{
				}
				num = (short)1951399936;
				short num3 = num;
				this.pgrmbleO9DiretionShortPressTime.Min = value;
			}
		}

		// Token: 0x1700424D RID: 16973
		// (get) Token: 0x06008228 RID: 33320 RVA: 0x00794EA0 File Offset: 0x007930A0
		// (set) Token: 0x06008229 RID: 33321 RVA: 0x00794F54 File Offset: 0x00793154
		internal int PGRMBLEO9DiretionShortPressTimeMax
		{
			get
			{
				short num = (short)1295266760;
				short num2 = num;
				num = (short)895431624;
				switch (num2 == num)
				{
				}
				num = (short)393609217;
				if (num != 0)
				{
				}
				num = (short)1303773184;
				if (num != 0)
				{
				}
				num = (short)1480916992;
				short num3 = num;
				return this.pgrmbleO9DiretionShortPressTime.Max;
			}
			set
			{
				short num = (short)20748039;
				short num2 = num;
				num = (short)653956871;
				switch (num2 == num)
				{
				}
				num = (short)1352531969;
				if (num != 0)
				{
				}
				num = (short)716111872;
				if (num != 0)
				{
				}
				num = (short)784138240;
				short num3 = num;
				this.pgrmbleO9DiretionShortPressTime.Max = value;
			}
		}

		// Token: 0x1700424E RID: 16974
		// (get) Token: 0x0600822A RID: 33322 RVA: 0x00795008 File Offset: 0x00793208
		// (set) Token: 0x0600822B RID: 33323 RVA: 0x007950B8 File Offset: 0x007932B8
		internal int PGRMBLEO9DiretionShortPressTimeStep
		{
			get
			{
				short num = (short)496470221;
				short num2 = num;
				num = (short)335120589;
				switch (num2 == num)
				{
				}
				num = (short)2114191360;
				if (num != 0)
				{
				}
				num = (short)1706033153;
				if (num != 0)
				{
				}
				num = (short)1432879104;
				short num3 = num;
				return this.pgrmbleO9DiretionShortPressTime.StepSize;
			}
			set
			{
				short num = (short)328164155;
				short num2 = num;
				num = (short)1665819451;
				switch (num2 == num)
				{
				}
				num = (short)1596653569;
				if (num != 0)
				{
				}
				num = (short)1891500032;
				if (num != 0)
				{
				}
				num = (short)742588416;
				short num3 = num;
				this.pgrmbleO9DiretionShortPressTime.StepSize = value;
			}
		}

		// Token: 0x1700424F RID: 16975
		// (get) Token: 0x0600822C RID: 33324 RVA: 0x0079516C File Offset: 0x0079336C
		// (set) Token: 0x0600822D RID: 33325 RVA: 0x0079521C File Offset: 0x0079341C
		public bool PGRMBLEO9DiretionShortPressTime_Applicable
		{
			get
			{
				short num = (short)681731798;
				short num2 = num;
				num = (short)1392207574;
				switch (num2 == num)
				{
				}
				num = (short)1000931329;
				if (num != 0)
				{
				}
				num = (short)93454336;
				if (num != 0)
				{
				}
				num = (short)1673265152;
				short num3 = num;
				return this.pgrmbleO9DiretionShortPressTime.Applicable;
			}
			set
			{
				short num = (short)151126017;
				if (num != 0)
				{
				}
				num = (short)981717933;
				short num2 = num;
				num = (short)485610413;
				switch (num2 == num)
				{
				}
				num = (short)25952256;
				if (num != 0)
				{
				}
				num = (short)1076101120;
				short num3 = num;
				this.pgrmbleO9DiretionShortPressTime.Applicable = value;
			}
		}

		// Token: 0x17004250 RID: 16976
		// (get) Token: 0x0600822E RID: 33326 RVA: 0x007952D4 File Offset: 0x007934D4
		// (set) Token: 0x0600822F RID: 33327 RVA: 0x00795388 File Offset: 0x00793588
		public bool PGRMBLEO9DiretionShortPressTime_Valid
		{
			get
			{
				short num = (short)1270952551;
				short num2 = num;
				num = (short)367407719;
				switch (num2 == num)
				{
				}
				num = (short)657850369;
				if (num != 0)
				{
				}
				num = (short)1413414912;
				if (num != 0)
				{
				}
				num = (short)1112473600;
				short num3 = num;
				return this.pgrmbleO9DiretionShortPressTime.Valid;
			}
			set
			{
				short num = (short)1026369596;
				short num2 = num;
				num = (short)1439443004;
				switch (num2 == num)
				{
				}
				num = (short)198770689;
				if (num != 0)
				{
				}
				num = (short)498925568;
				if (num != 0)
				{
				}
				num = (short)1228472320;
				short num3 = num;
				this.pgrmbleO9DiretionShortPressTime.Valid = value;
			}
		}

		// Token: 0x17004251 RID: 16977
		// (get) Token: 0x06008230 RID: 33328 RVA: 0x00795440 File Offset: 0x00793640
		// (set) Token: 0x06008231 RID: 33329 RVA: 0x007954F4 File Offset: 0x007936F4
		public bool PGRMBLEO9DiretionShortPressTime_Visible
		{
			get
			{
				short num = (short)52146317;
				short num2 = num;
				num = (short)880914573;
				switch (num2 == num)
				{
				}
				num = (short)533987329;
				if (num != 0)
				{
				}
				num = (short)728236032;
				if (num != 0)
				{
				}
				num = (short)1414266880;
				short num3 = num;
				return this.pgrmbleO9DiretionShortPressTime.Visible;
			}
			set
			{
				short num = (short)380305409;
				if (num != 0)
				{
				}
				num = (short)2059288623;
				short num2 = num;
				num = (short)40189999;
				switch (num2 == num)
				{
				}
				num = (short)1302593536;
				if (num != 0)
				{
				}
				num = (short)774701056;
				short num3 = num;
				this.pgrmbleO9DiretionShortPressTime.Visible = value;
			}
		}

		// Token: 0x17004252 RID: 16978
		// (get) Token: 0x06008232 RID: 33330 RVA: 0x007955AC File Offset: 0x007937AC
		// (set) Token: 0x06008233 RID: 33331 RVA: 0x00795660 File Offset: 0x00793860
		public bool PGRMBLEO9DiretionShortPressTime_Editable
		{
			get
			{
				short num = (short)1260576246;
				short num2 = num;
				num = (short)1770708470;
				switch (num2 == num)
				{
				}
				num = (short)441319425;
				if (num != 0)
				{
				}
				num = (short)2069233664;
				if (num != 0)
				{
				}
				num = (short)1004863488;
				short num3 = num;
				return this.pgrmbleO9DiretionShortPressTime.Editable;
			}
			set
			{
				short num = (short)1221459807;
				short num2 = num;
				num = (short)864943967;
				switch (num2 == num)
				{
				}
				num = (short)150208512;
				if (num != 0)
				{
				}
				num = (short)1425145857;
				if (num != 0)
				{
				}
				num = (short)421920768;
				short num3 = num;
				this.pgrmbleO9DiretionShortPressTime.Editable = value;
			}
		}

		// Token: 0x17004253 RID: 16979
		// (get) Token: 0x06008234 RID: 33332 RVA: 0x00795718 File Offset: 0x00793918
		internal string PGRMBLEO9DiretionShortPressTime_UILabel
		{
			get
			{
				short num = (short)1502740481;
				if (num != 0)
				{
				}
				num = (short)203964920;
				short num2 = num;
				num = (short)565789176;
				switch (num2 == num)
				{
				}
				num = (short)888406016;
				if (num != 0)
				{
				}
				num = (short)1035272192;
				short num3 = num;
				return this.pgrmbleO9DiretionShortPressTime.UIName;
			}
		}

		// Token: 0x17004254 RID: 16980
		// (get) Token: 0x06008235 RID: 33333 RVA: 0x007957D0 File Offset: 0x007939D0
		// (set) Token: 0x06008236 RID: 33334 RVA: 0x00795888 File Offset: 0x00793A88
		internal bool PGRMBLEO9DiretionShortPressTime_HiddenStatic
		{
			get
			{
				short num = (short)1766785025;
				if (num != 0)
				{
				}
				num = (short)1760446438;
				short num2 = num;
				num = (short)120145894;
				switch (num2 == num)
				{
				}
				num = (short)250478592;
				if (num != 0)
				{
				}
				num = (short)1857552384;
				short num3 = num;
				return this.pgrmbleO9DiretionShortPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)1099169793;
				if (num != 0)
				{
				}
				num = (short)2075876351;
				short num2 = num;
				num = (short)1188912127;
				switch (num2 == num)
				{
				}
				num = (short)960495616;
				if (num != 0)
				{
				}
				num = (short)1207238656;
				short num3 = num;
				this.pgrmbleO9DiretionShortPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17004255 RID: 16981
		// (get) Token: 0x06008237 RID: 33335 RVA: 0x00795940 File Offset: 0x00793B40
		// (set) Token: 0x06008238 RID: 33336 RVA: 0x007959F0 File Offset: 0x00793BF0
		internal bool PGRMBLEO9DiretionShortPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)168927300;
				short num2 = num;
				num = (short)200384580;
				switch (num2 == num)
				{
				}
				num = (short)1187381248;
				if (num != 0)
				{
				}
				num = (short)56033281;
				if (num != 0)
				{
				}
				num = (short)301531136;
				short num3 = num;
				return this.pgrmbleO9DiretionShortPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)1084576242;
				short num2 = num;
				num = (short)180376050;
				switch (num2 == num)
				{
				}
				num = (short)1511456768;
				if (num != 0)
				{
				}
				num = (short)887881729;
				if (num != 0)
				{
				}
				num = (short)454950912;
				short num3 = num;
				this.pgrmbleO9DiretionShortPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17004256 RID: 16982
		// (get) Token: 0x06008239 RID: 33337 RVA: 0x00795AA4 File Offset: 0x00793CA4
		public bool PGRMBLEO9DiretionShortPressTime_HasDiffs
		{
			get
			{
				short num = (short)517071364;
				short num2 = num;
				num = (short)54125060;
				switch (num2 == num)
				{
				}
				num = (short)556466177;
				if (num != 0)
				{
				}
				num = (short)1176371200;
				if (num != 0)
				{
				}
				num = (short)1017708544;
				short num3 = num;
				return this.pgrmbleO9DiretionShortPressTime._HasDiffs;
			}
		}

		// Token: 0x17004257 RID: 16983
		// (get) Token: 0x0600823A RID: 33338 RVA: 0x00795B58 File Offset: 0x00793D58
		// (set) Token: 0x0600823B RID: 33339 RVA: 0x00795C0C File Offset: 0x00793E0C
		public int PGRMBLEO9DiretionLongPressTimeValue
		{
			get
			{
				short num = (short)1332339584;
				short num2 = num;
				num = (short)158524288;
				switch (num2 == num)
				{
				}
				num = (short)1084030977;
				if (num != 0)
				{
				}
				num = (short)944373760;
				if (num != 0)
				{
				}
				num = (short)534577152;
				short num3 = num;
				return this.pgrmbleO9DiretionLongPressTime.Value;
			}
			set
			{
				short num = (short)1082123140;
				short num2 = num;
				num = (short)1448862596;
				switch (num2 == num)
				{
				}
				num = (short)775028736;
				if (num != 0)
				{
				}
				num = (short)1677131777;
				if (num != 0)
				{
				}
				num = (short)236257280;
				short num3 = num;
				this.pgrmbleO9DiretionLongPressTime.Value = value;
			}
		}

		// Token: 0x17004258 RID: 16984
		// (get) Token: 0x0600823C RID: 33340 RVA: 0x00795CC4 File Offset: 0x00793EC4
		// (set) Token: 0x0600823D RID: 33341 RVA: 0x00795D78 File Offset: 0x00793F78
		public string PGRMBLEO9DiretionLongPressTime_UIValue
		{
			get
			{
				short num = (short)1906039647;
				short num2 = num;
				num = (short)1741413215;
				switch (num2 == num)
				{
				}
				num = (short)1024262145;
				if (num != 0)
				{
				}
				num = (short)533004288;
				if (num != 0)
				{
				}
				num = (short)670105600;
				short num3 = num;
				return this.pgrmbleO9DiretionLongPressTime.UIValue;
			}
			set
			{
				short num = (short)1190389589;
				short num2 = num;
				num = (short)2010310485;
				switch (num2 == num)
				{
				}
				num = (short)1760034817;
				if (num != 0)
				{
				}
				num = (short)1226637312;
				if (num != 0)
				{
				}
				num = (short)967180288;
				short num3 = num;
				this.pgrmbleO9DiretionLongPressTime.UIValue = value;
			}
		}

		// Token: 0x17004259 RID: 16985
		// (get) Token: 0x0600823E RID: 33342 RVA: 0x00795E2C File Offset: 0x0079402C
		public global::AcpBusinessLayer.AcpSimpleRangeField PGRMBLEO9DiretionLongPressTime
		{
			get
			{
				short num = (short)1744696682;
				short num2 = num;
				num = (short)665777514;
				switch (num2 == num)
				{
				}
				num = (short)508035073;
				if (num != 0)
				{
				}
				num = (short)798556160;
				if (num != 0)
				{
				}
				num = (short)1894711296;
				short num3 = num;
				return this.pgrmbleO9DiretionLongPressTime;
			}
		}

		// Token: 0x1700425A RID: 16986
		// (get) Token: 0x0600823F RID: 33343 RVA: 0x00795ED8 File Offset: 0x007940D8
		// (set) Token: 0x06008240 RID: 33344 RVA: 0x00795F8C File Offset: 0x0079418C
		internal int PGRMBLEO9DiretionLongPressTimeMin
		{
			get
			{
				short num = (short)1882895809;
				short num2 = num;
				num = (short)2045031873;
				switch (num2 == num)
				{
				}
				num = (short)1825439744;
				if (num != 0)
				{
				}
				num = (short)1433862145;
				if (num != 0)
				{
				}
				num = (short)1187905536;
				short num3 = num;
				return this.pgrmbleO9DiretionLongPressTime.Min;
			}
			set
			{
				short num = (short)1445003265;
				if (num != 0)
				{
				}
				num = (short)2095427198;
				short num2 = num;
				num = (short)1325969022;
				switch (num2 == num)
				{
				}
				num = (short)1791885312;
				if (num != 0)
				{
				}
				num = (short)169082880;
				short num3 = num;
				this.pgrmbleO9DiretionLongPressTime.Min = value;
			}
		}

		// Token: 0x1700425B RID: 16987
		// (get) Token: 0x06008241 RID: 33345 RVA: 0x00796040 File Offset: 0x00794240
		// (set) Token: 0x06008242 RID: 33346 RVA: 0x007960F4 File Offset: 0x007942F4
		internal int PGRMBLEO9DiretionLongPressTimeMax
		{
			get
			{
				short num = (short)1915522922;
				short num2 = num;
				num = (short)114593642;
				switch (num2 == num)
				{
				}
				num = (short)788791297;
				if (num != 0)
				{
				}
				num = (short)650772480;
				if (num != 0)
				{
				}
				num = (short)1630863360;
				short num3 = num;
				return this.pgrmbleO9DiretionLongPressTime.Max;
			}
			set
			{
				short num = (short)1198471379;
				short num2 = num;
				num = (short)305739987;
				switch (num2 == num)
				{
				}
				num = (short)2056323073;
				if (num != 0)
				{
				}
				num = (short)100663296;
				if (num != 0)
				{
				}
				num = (short)980746240;
				short num3 = num;
				this.pgrmbleO9DiretionLongPressTime.Max = value;
			}
		}

		// Token: 0x1700425C RID: 16988
		// (get) Token: 0x06008243 RID: 33347 RVA: 0x007961AC File Offset: 0x007943AC
		// (set) Token: 0x06008244 RID: 33348 RVA: 0x00796264 File Offset: 0x00794464
		internal int PGRMBLEO9DiretionLongPressTimeStep
		{
			get
			{
				short num = (short)214806769;
				short num2 = num;
				num = (short)1940762865;
				switch (num2 == num)
				{
				}
				num = (short)991363072;
				if (num != 0)
				{
				}
				num = (short)1725300737;
				if (num != 0)
				{
				}
				num = (short)294060032;
				short num3 = num;
				return this.pgrmbleO9DiretionLongPressTime.StepSize;
			}
			set
			{
				short num = (short)572203683;
				short num2 = num;
				num = (short)1293623971;
				switch (num2 == num)
				{
				}
				num = (short)554303489;
				if (num != 0)
				{
				}
				num = (short)1114177536;
				if (num != 0)
				{
				}
				num = (short)1097596928;
				short num3 = num;
				this.pgrmbleO9DiretionLongPressTime.StepSize = value;
			}
		}

		// Token: 0x1700425D RID: 16989
		// (get) Token: 0x06008245 RID: 33349 RVA: 0x0079631C File Offset: 0x0079451C
		// (set) Token: 0x06008246 RID: 33350 RVA: 0x007963D0 File Offset: 0x007945D0
		public bool PGRMBLEO9DiretionLongPressTime_Applicable
		{
			get
			{
				short num = (short)584680823;
				short num2 = num;
				num = (short)1114146167;
				switch (num2 == num)
				{
				}
				num = (short)805240833;
				if (num != 0)
				{
				}
				num = (short)1267400704;
				if (num != 0)
				{
				}
				num = (short)425000960;
				short num3 = num;
				return this.pgrmbleO9DiretionLongPressTime.Applicable;
			}
			set
			{
				short num = (short)713350859;
				short num2 = num;
				num = (short)1495523019;
				switch (num2 == num)
				{
				}
				num = (short)1956446209;
				if (num != 0)
				{
				}
				num = (short)1996095488;
				if (num != 0)
				{
				}
				num = (short)884211712;
				short num3 = num;
				this.pgrmbleO9DiretionLongPressTime.Applicable = value;
			}
		}

		// Token: 0x1700425E RID: 16990
		// (get) Token: 0x06008247 RID: 33351 RVA: 0x00796484 File Offset: 0x00794684
		// (set) Token: 0x06008248 RID: 33352 RVA: 0x00796538 File Offset: 0x00794738
		public bool PGRMBLEO9DiretionLongPressTime_Valid
		{
			get
			{
				short num = (short)1781339614;
				short num2 = num;
				num = (short)1290671582;
				switch (num2 == num)
				{
				}
				num = (short)1306132481;
				if (num != 0)
				{
				}
				num = (short)349765632;
				if (num != 0)
				{
				}
				num = (short)547618816;
				short num3 = num;
				return this.pgrmbleO9DiretionLongPressTime.Valid;
			}
			set
			{
				short num = (short)1913257985;
				if (num != 0)
				{
				}
				num = (short)524379257;
				short num2 = num;
				num = (short)889873529;
				switch (num2 == num)
				{
				}
				num = (short)1396178944;
				if (num != 0)
				{
				}
				num = (short)120389632;
				short num3 = num;
				this.pgrmbleO9DiretionLongPressTime.Valid = value;
			}
		}

		// Token: 0x1700425F RID: 16991
		// (get) Token: 0x06008249 RID: 33353 RVA: 0x007965F0 File Offset: 0x007947F0
		// (set) Token: 0x0600824A RID: 33354 RVA: 0x007966A4 File Offset: 0x007948A4
		public bool PGRMBLEO9DiretionLongPressTime_Visible
		{
			get
			{
				short num = (short)2075874959;
				short num2 = num;
				num = (short)623728271;
				switch (num2 == num)
				{
				}
				num = (short)1123221504;
				if (num != 0)
				{
				}
				num = (short)50593793;
				if (num != 0)
				{
				}
				num = (short)948305920;
				short num3 = num;
				return this.pgrmbleO9DiretionLongPressTime.Visible;
			}
			set
			{
				short num = (short)1717033307;
				short num2 = num;
				num = (short)549116251;
				switch (num2 == num)
				{
				}
				num = (short)1142423553;
				if (num != 0)
				{
				}
				num = (short)36962304;
				if (num != 0)
				{
				}
				num = (short)1430388736;
				short num3 = num;
				this.pgrmbleO9DiretionLongPressTime.Visible = value;
			}
		}

		// Token: 0x17004260 RID: 16992
		// (get) Token: 0x0600824B RID: 33355 RVA: 0x0079675C File Offset: 0x0079495C
		// (set) Token: 0x0600824C RID: 33356 RVA: 0x00796814 File Offset: 0x00794A14
		public bool PGRMBLEO9DiretionLongPressTime_Editable
		{
			get
			{
				short num = (short)1595337379;
				short num2 = num;
				num = (short)521792163;
				switch (num2 == num)
				{
				}
				num = (short)1886978049;
				if (num != 0)
				{
				}
				num = (short)469565440;
				if (num != 0)
				{
				}
				num = (short)729612288;
				short num3 = num;
				return this.pgrmbleO9DiretionLongPressTime.Editable;
			}
			set
			{
				short num = (short)1859649537;
				if (num != 0)
				{
				}
				num = (short)804658868;
				short num2 = num;
				num = (short)2053709492;
				switch (num2 == num)
				{
				}
				num = (short)276889600;
				if (num != 0)
				{
				}
				num = (short)677576704;
				short num3 = num;
				this.pgrmbleO9DiretionLongPressTime.Editable = value;
			}
		}

		// Token: 0x17004261 RID: 16993
		// (get) Token: 0x0600824D RID: 33357 RVA: 0x007968C8 File Offset: 0x00794AC8
		internal string PGRMBLEO9DiretionLongPressTime_UILabel
		{
			get
			{
				short num = (short)859242497;
				if (num != 0)
				{
				}
				num = (short)2116339754;
				short num2 = num;
				num = (short)1399834666;
				switch (num2 == num)
				{
				}
				num = (short)340590592;
				if (num != 0)
				{
				}
				num = (short)93650944;
				short num3 = num;
				return this.pgrmbleO9DiretionLongPressTime.UIName;
			}
		}

		// Token: 0x17004262 RID: 16994
		// (get) Token: 0x0600824E RID: 33358 RVA: 0x00796980 File Offset: 0x00794B80
		// (set) Token: 0x0600824F RID: 33359 RVA: 0x00796A34 File Offset: 0x00794C34
		internal bool PGRMBLEO9DiretionLongPressTime_HiddenStatic
		{
			get
			{
				short num = (short)1457134244;
				short num2 = num;
				num = (short)1778457252;
				switch (num2 == num)
				{
				}
				num = (short)1457520641;
				if (num != 0)
				{
				}
				num = (short)870055936;
				if (num != 0)
				{
				}
				num = (short)1986199552;
				short num3 = num;
				return this.pgrmbleO9DiretionLongPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)1885179046;
				short num2 = num;
				num = (short)1386712230;
				switch (num2 == num)
				{
				}
				num = (short)132907009;
				if (num != 0)
				{
				}
				num = (short)1469513728;
				if (num != 0)
				{
				}
				num = (short)1984757760;
				short num3 = num;
				this.pgrmbleO9DiretionLongPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17004263 RID: 16995
		// (get) Token: 0x06008250 RID: 33360 RVA: 0x00796AE8 File Offset: 0x00794CE8
		// (set) Token: 0x06008251 RID: 33361 RVA: 0x00796B9C File Offset: 0x00794D9C
		internal bool PGRMBLEO9DiretionLongPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)853803009;
				if (num != 0)
				{
				}
				num = (short)1617856393;
				short num2 = num;
				num = (short)663848841;
				switch (num2 == num)
				{
				}
				num = (short)273809408;
				if (num != 0)
				{
				}
				num = (short)799801344;
				short num3 = num;
				return this.pgrmbleO9DiretionLongPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)1161166848;
				short num2 = num;
				num = (short)1289945089;
				if (num != 0)
				{
				}
				num = (short)570258883;
				short num3 = num;
				num = (short)578975171;
				switch (num3 == num)
				{
				}
				num = (short)390725632;
				if (num != 0)
				{
				}
				this.pgrmbleO9DiretionLongPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17004264 RID: 16996
		// (get) Token: 0x06008252 RID: 33362 RVA: 0x00796C50 File Offset: 0x00794E50
		public bool PGRMBLEO9DiretionLongPressTime_HasDiffs
		{
			get
			{
				short num = (short)345571328;
				short num2 = num;
				num = (short)428802049;
				if (num != 0)
				{
				}
				num = (short)1917097869;
				short num3 = num;
				num = (short)265983885;
				switch (num3 == num)
				{
				}
				num = (short)800653312;
				if (num != 0)
				{
				}
				return this.pgrmbleO9DiretionLongPressTime._HasDiffs;
			}
		}

		// Token: 0x17004265 RID: 16997
		// (get) Token: 0x06008253 RID: 33363 RVA: 0x00796D04 File Offset: 0x00794F04
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)2038890496;
				short num2 = num;
				num = (short)589353950;
				short num3 = num;
				num = (short)354145246;
				switch (num3 == num)
				{
				}
				num = (short)1357447168;
				if (num != 0)
				{
				}
				num = (short)1102774273;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06008254 RID: 33364 RVA: 0x00796DC0 File Offset: 0x00794FC0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)74991976;
			short num2 = num;
			num = (short)464865640;
			global::AcpCommonLib.IAcpRecordset result;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_85:
				if (base.ParentRecset == null)
				{
					return result;
				}
				num = (short)1601306628;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1117585408;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6F;
				}
				break;
			}
			for (;;)
			{
				IL_55:
				switch (num3)
				{
				case 0:
					goto IL_85;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)649461762;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
				{
					num = (short)281870336;
					short num4 = num;
					num = (short)1689649153;
					if (num != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)906756099;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_CE;
				case 4:
					num = (short)1559101441;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_6F;
			}
			IL_CE:
			return result;
			IL_6F:
			result = null;
			num = (short)1043070976;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_55;
		}

		// Token: 0x04003E3D RID: 15933
		private global::AcpBusinessLayer.AcpField<string> radErgCtrlHeadO9DirLightBarName_A36558;

		// Token: 0x04003E3E RID: 15934
		private global::AcpBusinessLayer.AcpListField radErgCtrlHeadO9DirLightBarBCO_A36559;

		// Token: 0x04003E3F RID: 15935
		private global::AcpBusinessLayer.AcpListField radErgCtrlHeadO9DirLightBarFeature_A36597;

		// Token: 0x04003E40 RID: 15936
		private global::AcpBusinessLayer.AcpRecRefField radErgCtrlHeadO9DirLightBarIndex_A36601;

		// Token: 0x04003E41 RID: 15937
		private global::AcpBusinessLayer.AcpSimpleRangeField pgrmbleO9DiretionShortPressTime;

		// Token: 0x04003E42 RID: 15938
		private global::AcpBusinessLayer.AcpSimpleRangeField pgrmbleO9DiretionLongPressTime;
	}
}
