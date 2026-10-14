using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadE5
{
	// Token: 0x020003F4 RID: 1012
	[global::System.Serializable]
	public class E5BottomFunctionButtonInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008CC1 RID: 36033 RVA: 0x00841828 File Offset: 0x0083FA28
		public E5BottomFunctionButtonInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06008CC2 RID: 36034 RVA: 0x00841844 File Offset: 0x0083FA44
		protected E5BottomFunctionButtonInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008CC3 RID: 36035 RVA: 0x0084185C File Offset: 0x0083FA5C
		public override void Init()
		{
			int a_ = 18;
			short num = (short)584316921;
			short num2 = num;
			num = (short)2078341113;
			switch (num2 == num)
			{
			}
			num = (short)30408704;
			short num3 = num;
			num = (short)419233792;
			if (num != 0)
			{
			}
			num = (short)825163777;
			if (num != 0)
			{
			}
			this.e5BottomFunctionButtonName_43756 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_P, this, global::AllFeatures.CodeplugGuid.b("雒闖뛘꿚꧜냞賠ꗢ郤触諨鿪蓬胮鿰뇲胴菶跸铺鏼뇾怀渂怄堆㴈㠊㨌㨎✐", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.e5BottomFunctionButtonName_43756.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.e5BottomFunctionButtonName_43756.DataTransferOrder = -1;
			this.e5BottomFunctionButtonBCO_43757 = new global::AcpBusinessLayer.AcpSparseLOVField(165, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.indexE5BottomFunctionButtonBCO_43757LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.idE5BottomFunctionButtonBCO_43757LovStrs), this, global::AllFeatures.CodeplugGuid.b("雒闖뛘꿚꧜냞賠ꗢ郤触諨鿪蓬胮鿰뇲胴菶跸铺鏼뷾䈀䰂娄㌆㨈㰊㠌㠎", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.E5BottomFunctionButtonBCO_43757LovStrs);
			this.e5BottomFunctionButtonBCO_43757.IgnoreOnCompare = true;
			this.e5BottomFunctionButtonBCO_43757.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.e5BottomFunctionButtonBCO_43757.DataTransferOrder = -1;
			this.e5BottomFunctionButtonFeature_43758 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.indexE5BottomFunctionButtonFeature_43758LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.idE5BottomFunctionButtonFeature_43758LovStrs), this, global::AllFeatures.CodeplugGuid.b("雒闖뛘꿚꧜냞賠ꗢ郤触諨鿪蓬胮鿰뇲胴菶跸铺鏼맾搀戂焄爆笈渊刌㬎∐␒—⼖", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.E5BottomFunctionButtonFeature_43758LovStrs);
			this.e5BottomFunctionButtonFeature_43758.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.e5BottomFunctionButtonFeature_43758.DataTransferOrder = 15;
			this.e5BottomFunctionButtonIndex_43759 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("雒闖뛘꿚꧜냞賠ꗢ郤触諨鿪蓬胮鿰뇲胴菶跸铺鏼뛾漀朂怄缆嘈㼊㸌㠎␐⨒", a_), global::CommonResources.AcgResources.ID_INDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.e5BottomFunctionButtonIndex_43759.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.e5BottomFunctionButtonIndex_43759.DataTransferOrder = 16;
			this.e5BottomFunctionButtonIndex_43759.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("釒뫔ꏖ귘듚냜￞꟠離诤蓦鷨苪苬臮퇰ꏲ蟴飶黸觺鳼鋾氀戂朄欆氈⬊伌税攐朒稔礖", a_);
			base.Id = 10904;
			base.UIName = global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONPROGRAMMABLEBUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008CC4 RID: 36036 RVA: 0x00841A84 File Offset: 0x0083FC84
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)1133838351;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields != null)
					{
						num = (short)1594097671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_455;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跇￉軋ꇍ꓏ꛑ믓믕黗꿙닛뷝铟诡诣裥ꫧ鿩飫髭鿯鳱뛳뗵럷ꗹ죻췽㟿㜁㌃", a_)))
					{
						num = (short)1170800652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_276;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跇￉軋ꇍ꓏ꛑ믓믕黗꿙닛뷝铟诡诣裥ꫧ鿩飫髭鿯鳱닳鏵駷軹觻賽旿崁〃㔅㼇㼉㐋", a_)))
					{
						num = (short)726007822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C4;
				case 3:
					num = (short)248578049;
					if (num != 0)
					{
					}
					num = (short)2047016960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_276;
				case 5:
					goto IL_334;
				case 6:
				{
					this.e5BottomFunctionButtonName_43756 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_P, this, global::AllFeatures.CodeplugGuid.b("跇￉軋ꇍ꓏ꛑ믓믕黗꿙닛뷝铟诡诣裥ꫧ鿩飫髭鿯鳱뫳韵闷鿹ꏻ쫽㏿㔁㄃々", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.e5BottomFunctionButtonName_43756.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.e5BottomFunctionButtonName_43756.DataTransferOrder = -1;
					num = (short)133974024;
					short num3 = num;
					num = (short)1449674760;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_20D;
					default:
					{
						num = (short)50790400;
						short num4 = num;
						num = (short)583860224;
						if (num != 0)
						{
						}
						num = (short)949551115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 7:
					num = (short)1641283597;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_20D;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跇￉軋ꇍ꓏ꛑ믓믕黗꿙닛뷝铟诡诣裥ꫧ鿩飫髭鿯鳱뷳飵鳷鿹蓻ꇽ㓿㄁㌃㌅ㄇ", a_)))
					{
						num = (short)2028929032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_455;
				case 10:
					goto IL_1C4;
				case 11:
					goto IL_339;
				case 12:
					this.e5BottomFunctionButtonBCO_43757 = new global::AcpBusinessLayer.AcpSparseLOVField(165, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.indexE5BottomFunctionButtonBCO_43757LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.idE5BottomFunctionButtonBCO_43757LovStrs), this, global::AllFeatures.CodeplugGuid.b("跇￉軋ꇍ꓏ꛑ믓믕黗꿙닛뷝铟诡诣裥ꫧ鿩飫髭鿯鳱뛳뗵럷ꗹ죻췽㟿㜁㌃", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.E5BottomFunctionButtonBCO_43757LovStrs);
					this.e5BottomFunctionButtonBCO_43757.IgnoreOnCompare = true;
					this.e5BottomFunctionButtonBCO_43757.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.e5BottomFunctionButtonBCO_43757.DataTransferOrder = -1;
					num = (short)1678114820;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跇￉軋ꇍ꓏ꛑ믓믕黗꿙닛뷝铟诡诣裥ꫧ鿩飫髭鿯鳱뫳韵闷鿹ꏻ쫽㏿㔁㄃々", a_)))
					{
						num = (short)200409094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_339;
				case 14:
					this.e5BottomFunctionButtonFeature_43758 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.indexE5BottomFunctionButtonFeature_43758LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.idE5BottomFunctionButtonFeature_43758LovStrs), this, global::AllFeatures.CodeplugGuid.b("跇￉軋ꇍ꓏ꛑ믓믕黗꿙닛뷝铟诡诣裥ꫧ鿩飫髭鿯鳱닳鏵駷軹觻賽旿崁〃㔅㼇㼉㐋", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.E5BottomFunctionButtonFeature_43758LovStrs);
					this.e5BottomFunctionButtonFeature_43758.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.e5BottomFunctionButtonFeature_43758.DataTransferOrder = 15;
					num = (short)1331363850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					switch (0)
					{
					case 0:
						goto IL_6E;
					}
					continue;
				}
				IL_6E:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1633812483;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1C4:
				num = (short)2004877321;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_20D:
				this.e5BottomFunctionButtonIndex_43759 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("跇￉軋ꇍ꓏ꛑ믓믕黗꿙닛뷝铟诡诣裥ꫧ鿩飫髭鿯鳱뷳飵鳷鿹蓻ꇽ㓿㄁㌃㌅ㄇ", a_), global::CommonResources.AcgResources.ID_INDEX, new string[]
				{
					global::CommonResources.AcgResources.ID_UNASSIGNED
				}, new int[1], true, false);
				this.e5BottomFunctionButtonIndex_43759.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
				this.e5BottomFunctionButtonIndex_43759.DataTransferOrder = 16;
				this.e5BottomFunctionButtonIndex_43759.ValidateAcrossRecset = true;
				num = (short)669253637;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_276:
				num = (short)456851458;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_339:
				num = (short)301793281;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_334:
			IL_455:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("談ꗉ룋뫍뿏뿑郕귗듙뿛ꫝ觟跡諣웥룧飩菫觭苯鏱駳鯵駷飹郻鯽⃿䀁焃爅簇攉戋", a_);
			base.Id = 10904;
			base.UIName = global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONPROGRAMMABLEBUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008CC5 RID: 36037 RVA: 0x00841F18 File Offset: 0x00840118
		public override void PopulateReferences()
		{
			short num = (short)1589826752;
			short num2 = num;
			num = (short)2073810112;
			switch (num2 == num)
			{
			}
			num = (short)1117782016;
			short num3 = num;
			num = (short)1444741121;
			if (num != 0)
			{
			}
			num = (short)614793216;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			global::System.Collections.Generic.List<global::AcpBusinessLayer.Recordset> list2 = new global::System.Collections.Generic.List<global::AcpBusinessLayer.Recordset>();
			list2.Add((global::AcpBusinessLayer.Recordset)this.a(4008));
			list.Add(global::CommonResources.AcgResources.ID_ACTIONCONSOLIDATION);
			list2.Add((global::AcpBusinessLayer.Recordset)this.a(2045)[0][10604].EmbeddedRecset);
			list.Add(global::CommonResources.AcgResources.ID_RELAYPATTERN);
			((global::AcpBusinessLayer.AcpSparseLOVField)this.e5BottomFunctionButtonFeature_43758).SetBuddyRecRefField(this.e5BottomFunctionButtonIndex_43759, list2, list);
		}

		// Token: 0x06008CC6 RID: 36038 RVA: 0x0084203C File Offset: 0x0084023C
		public override void DropReferences()
		{
			short num = (short)2031210390;
			short num2 = num;
			num = (short)1954271126;
			switch (num2 == num)
			{
			}
			num = (short)1607794688;
			short num3 = num;
			num = (short)1713569793;
			if (num != 0)
			{
			}
			num = (short)928710656;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008CC7 RID: 36039 RVA: 0x008420EC File Offset: 0x008402EC
		public override void SetConstraints()
		{
			short num = (short)1605843039;
			short num2 = num;
			num = (short)1953118303;
			switch (num2 == num)
			{
			}
			num = (short)1927806976;
			short num3 = num;
			num = (short)673316865;
			if (num != 0)
			{
			}
			num = (short)306708480;
			if (num != 0)
			{
			}
			this.e5BottomFunctionButtonName_43756.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.e5BottomFunctionButtonFeature_43758.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.ConSyncBottomFunctionButton);
			this.e5BottomFunctionButtonFeature_43758.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.ConBottomButtonFeatureIsValid);
			this.e5BottomFunctionButtonIndex_43759.ValidateAcrossRecset = true;
			this.e5BottomFunctionButtonIndex_43759.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.ConBottomFunctionButtonIndexIsApplicable);
			this.e5BottomFunctionButtonIndex_43759.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.ConSyncBottomFunctionButtonIndex);
			this.e5BottomFunctionButtonIndex_43759.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.ConBottomFunctionButtonIndexIsValid);
		}

		// Token: 0x06008CC8 RID: 36040 RVA: 0x00842228 File Offset: 0x00840428
		public override void SetupDependencies()
		{
			short num = (short)1516397880;
			short num2 = num;
			num = (short)1893557560;
			switch (num2 == num)
			{
			}
			num = (short)808321024;
			short num3 = num;
			num = (short)1759707137;
			if (num != 0)
			{
			}
			num = (short)730071040;
			if (num != 0)
			{
			}
			this.e5BottomFunctionButtonFeature_43758.AddDependentObject(this.e5BottomFunctionButtonIndex_43759);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.e5BottomFunctionButtonIndex_43759);
			this.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.AddDependentObject(this.e5BottomFunctionButtonIndex_43759);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.e5BottomFunctionButtonFeature_43758);
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561.AddDependentObject(this.e5BottomFunctionButtonFeature_43758);
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550.AddDependentObject(this.e5BottomFunctionButtonFeature_43758);
			this.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.AddDependentObject(this.e5BottomFunctionButtonFeature_43758);
			this.RefRadioWide.Features.RadWideFeaturesChannelFallbackEnable.AddDependentObject(this.e5BottomFunctionButtonFeature_43758);
		}

		// Token: 0x1700472B RID: 18219
		// (get) Token: 0x06008CC9 RID: 36041 RVA: 0x008423A8 File Offset: 0x008405A8
		public bool HasDiffs
		{
			get
			{
				short num = (short)595233235;
				short num2 = num;
				num = (short)821922259;
				switch (num2 == num)
				{
				}
				num = (short)215416832;
				short num3 = num;
				num = (short)221446145;
				if (num != 0)
				{
				}
				num = (short)1125122048;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700472C RID: 18220
		// (get) Token: 0x06008CCA RID: 36042 RVA: 0x00842458 File Offset: 0x00840658
		// (set) Token: 0x06008CCB RID: 36043 RVA: 0x00842510 File Offset: 0x00840710
		public string E5BottomFunctionButtonName_43756Value
		{
			get
			{
				short num = (short)547964042;
				short num2 = num;
				num = (short)166085770;
				switch (num2 == num)
				{
				}
				num = (short)660668416;
				short num3 = num;
				num = (short)1226899456;
				if (num != 0)
				{
				}
				num = (short)1947205633;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonName_43756.Value;
			}
			set
			{
				short num = (short)1662709939;
				short num2 = num;
				num = (short)1548808371;
				switch (num2 == num)
				{
				}
				num = (short)361234432;
				short num3 = num;
				num = (short)1846411264;
				if (num != 0)
				{
				}
				num = (short)1607729153;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonName_43756.Value = value;
			}
		}

		// Token: 0x1700472D RID: 18221
		// (get) Token: 0x06008CCC RID: 36044 RVA: 0x008425C8 File Offset: 0x008407C8
		public global::AcpBusinessLayer.AcpField<string> E5BottomFunctionButtonName_43756
		{
			get
			{
				short num = (short)1910440038;
				short num2 = num;
				num = (short)839647334;
				switch (num2 == num)
				{
				}
				num = (short)1633091584;
				short num3 = num;
				num = (short)1031995393;
				if (num != 0)
				{
				}
				num = (short)783220736;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonName_43756;
			}
		}

		// Token: 0x1700472E RID: 18222
		// (get) Token: 0x06008CCD RID: 36045 RVA: 0x00842678 File Offset: 0x00840878
		// (set) Token: 0x06008CCE RID: 36046 RVA: 0x0084272C File Offset: 0x0084092C
		public string E5BottomFunctionButtonName_43756_UIValue
		{
			get
			{
				short num = (short)2067715667;
				short num2 = num;
				num = (short)1507186259;
				switch (num2 == num)
				{
				}
				num = (short)377225216;
				short num3 = num;
				num = (short)147914753;
				if (num != 0)
				{
				}
				num = (short)2021785600;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonName_43756.Value;
			}
			set
			{
				short num = (short)362008495;
				short num2 = num;
				num = (short)1575604143;
				switch (num2 == num)
				{
				}
				num = (short)2034565120;
				short num3 = num;
				num = (short)2070216705;
				if (num != 0)
				{
				}
				num = (short)1074266112;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonName_43756.Value = value;
			}
		}

		// Token: 0x1700472F RID: 18223
		// (get) Token: 0x06008CCF RID: 36047 RVA: 0x008427E0 File Offset: 0x008409E0
		// (set) Token: 0x06008CD0 RID: 36048 RVA: 0x00842894 File Offset: 0x00840A94
		public bool E5BottomFunctionButtonName_43756_Applicable
		{
			get
			{
				short num = (short)402960372;
				short num2 = num;
				num = (short)1865723892;
				switch (num2 == num)
				{
				}
				num = (short)1952776192;
				short num3 = num;
				num = (short)392495105;
				if (num != 0)
				{
				}
				num = (short)1328021504;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonName_43756.Applicable;
			}
			set
			{
				short num = (short)1983217364;
				short num2 = num;
				num = (short)1125940948;
				switch (num2 == num)
				{
				}
				num = (short)961216512;
				short num3 = num;
				num = (short)1153236992;
				if (num != 0)
				{
				}
				num = (short)853671937;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonName_43756.Applicable = value;
			}
		}

		// Token: 0x17004730 RID: 18224
		// (get) Token: 0x06008CD1 RID: 36049 RVA: 0x00842948 File Offset: 0x00840B48
		// (set) Token: 0x06008CD2 RID: 36050 RVA: 0x008429FC File Offset: 0x00840BFC
		public bool E5BottomFunctionButtonName_43756_Valid
		{
			get
			{
				short num = (short)1032792483;
				short num2 = num;
				num = (short)1890396579;
				switch (num2 == num)
				{
				}
				num = (short)46333952;
				short num3 = num;
				num = (short)209321985;
				if (num != 0)
				{
				}
				num = (short)2047344640;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonName_43756.Valid;
			}
			set
			{
				short num = (short)1825404254;
				short num2 = num;
				num = (short)1813476702;
				switch (num2 == num)
				{
				}
				num = (short)253558784;
				short num3 = num;
				num = (short)1759117313;
				if (num != 0)
				{
				}
				num = (short)1823539200;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonName_43756.Valid = value;
			}
		}

		// Token: 0x17004731 RID: 18225
		// (get) Token: 0x06008CD3 RID: 36051 RVA: 0x00842AB0 File Offset: 0x00840CB0
		// (set) Token: 0x06008CD4 RID: 36052 RVA: 0x00842B68 File Offset: 0x00840D68
		public bool E5BottomFunctionButtonName_43756_Visible
		{
			get
			{
				short num = (short)2047148033;
				if (num != 0)
				{
				}
				num = (short)1699490114;
				short num2 = num;
				num = (short)1104750914;
				switch (num2 == num)
				{
				default:
				{
					num = (short)724566016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1599733760;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonName_43756.Visible;
			}
			set
			{
				short num = (short)1817640961;
				if (num != 0)
				{
				}
				num = (short)640029683;
				short num2 = num;
				num = (short)261231603;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1170735104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1858732032;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonName_43756.Visible = value;
			}
		}

		// Token: 0x17004732 RID: 18226
		// (get) Token: 0x06008CD5 RID: 36053 RVA: 0x00842C1C File Offset: 0x00840E1C
		// (set) Token: 0x06008CD6 RID: 36054 RVA: 0x00842CD0 File Offset: 0x00840ED0
		public bool E5BottomFunctionButtonName_43756_Editable
		{
			get
			{
				short num = (short)1127587880;
				short num2 = num;
				num = (short)317235240;
				switch (num2 == num)
				{
				}
				num = (short)2009464832;
				short num3 = num;
				num = (short)1456340993;
				if (num != 0)
				{
				}
				num = (short)1739718656;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonName_43756.Editable;
			}
			set
			{
				short num = (short)1129375339;
				short num2 = num;
				num = (short)492889707;
				switch (num2 == num)
				{
				}
				num = (short)1671364608;
				short num3 = num;
				num = (short)173277185;
				if (num != 0)
				{
				}
				num = (short)43188224;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonName_43756.Editable = value;
			}
		}

		// Token: 0x17004733 RID: 18227
		// (get) Token: 0x06008CD7 RID: 36055 RVA: 0x00842D84 File Offset: 0x00840F84
		internal string E5BottomFunctionButtonName_43756_UILabel
		{
			get
			{
				short num = (short)226677666;
				short num2 = num;
				num = (short)862442402;
				switch (num2 == num)
				{
				}
				num = (short)1317732352;
				short num3 = num;
				num = (short)1974075393;
				if (num != 0)
				{
				}
				num = (short)163053568;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonName_43756.UIName;
			}
		}

		// Token: 0x17004734 RID: 18228
		// (get) Token: 0x06008CD8 RID: 36056 RVA: 0x00842E38 File Offset: 0x00841038
		// (set) Token: 0x06008CD9 RID: 36057 RVA: 0x00842EF0 File Offset: 0x008410F0
		internal bool E5BottomFunctionButtonName_43756_HiddenStatic
		{
			get
			{
				short num = (short)201392129;
				if (num != 0)
				{
				}
				num = (short)1561195893;
				short num2 = num;
				num = (short)77329781;
				switch (num2 == num)
				{
				default:
				{
					num = (short)281673728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)553713664;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonName_43756.HiddenStatic;
			}
			set
			{
				short num = (short)578596214;
				short num2 = num;
				num = (short)2033429878;
				switch (num2 == num)
				{
				}
				num = (short)211288064;
				short num3 = num;
				num = (short)689504256;
				if (num != 0)
				{
				}
				num = (short)2035351553;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonName_43756.HiddenStatic = value;
			}
		}

		// Token: 0x17004735 RID: 18229
		// (get) Token: 0x06008CDA RID: 36058 RVA: 0x00842FA4 File Offset: 0x008411A4
		// (set) Token: 0x06008CDB RID: 36059 RVA: 0x00843058 File Offset: 0x00841258
		internal bool E5BottomFunctionButtonName_43756_HiddenDynamic
		{
			get
			{
				short num = (short)391518123;
				short num2 = num;
				num = (short)1764431787;
				switch (num2 == num)
				{
				}
				num = (short)1361117184;
				short num3 = num;
				num = (short)1312292865;
				if (num != 0)
				{
				}
				num = (short)1669136384;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonName_43756.HiddenDynamic;
			}
			set
			{
				short num = (short)120440094;
				short num2 = num;
				num = (short)149996830;
				switch (num2 == num)
				{
				}
				num = (short)2116222976;
				short num3 = num;
				num = (short)1631453185;
				if (num != 0)
				{
				}
				num = (short)465633280;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonName_43756.HiddenDynamic = value;
			}
		}

		// Token: 0x17004736 RID: 18230
		// (get) Token: 0x06008CDC RID: 36060 RVA: 0x0084310C File Offset: 0x0084130C
		public bool E5BottomFunctionButtonName_43756_HasDiffs
		{
			get
			{
				short num = (short)1149660558;
				short num2 = num;
				num = (short)2047700366;
				switch (num2 == num)
				{
				}
				num = (short)545718272;
				short num3 = num;
				num = (short)668794881;
				if (num != 0)
				{
				}
				num = (short)1111097344;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonName_43756._HasDiffs;
			}
		}

		// Token: 0x17004737 RID: 18231
		// (get) Token: 0x06008CDD RID: 36061 RVA: 0x008431C0 File Offset: 0x008413C0
		// (set) Token: 0x06008CDE RID: 36062 RVA: 0x00843278 File Offset: 0x00841478
		public int E5BottomFunctionButtonBCO_43757Value
		{
			get
			{
				short num = (short)866597167;
				short num2 = num;
				num = (short)605894959;
				switch (num2 == num)
				{
				}
				num = (short)1886453760;
				short num3 = num;
				num = (short)898367489;
				if (num != 0)
				{
				}
				num = (short)1520435200;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonBCO_43757.Value;
			}
			set
			{
				short num = (short)977651887;
				short num2 = num;
				num = (short)1249691823;
				switch (num2 == num)
				{
				}
				num = (short)678690816;
				if (num != 0)
				{
				}
				num = (short)802291712;
				short num3 = num;
				num = (short)1615396865;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonBCO_43757.Value = value;
			}
		}

		// Token: 0x17004738 RID: 18232
		// (get) Token: 0x06008CDF RID: 36063 RVA: 0x0084332C File Offset: 0x0084152C
		// (set) Token: 0x06008CE0 RID: 36064 RVA: 0x008433E0 File Offset: 0x008415E0
		public string E5BottomFunctionButtonBCO_43757_UIValue
		{
			get
			{
				short num = (short)575829531;
				short num2 = num;
				num = (short)1881306651;
				switch (num2 == num)
				{
				}
				num = (short)1412890625;
				if (num != 0)
				{
				}
				num = (short)497549312;
				short num3 = num;
				num = (short)1137573888;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonBCO_43757.UIValue;
			}
			set
			{
				short num = (short)2043281409;
				if (num != 0)
				{
				}
				num = (short)1977188385;
				short num2 = num;
				num = (short)507543585;
				switch (num2 == num)
				{
				}
				num = (short)680919040;
				short num3 = num;
				num = (short)1742602240;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonBCO_43757.UIValue = value;
			}
		}

		// Token: 0x17004739 RID: 18233
		// (get) Token: 0x06008CE1 RID: 36065 RVA: 0x00843494 File Offset: 0x00841694
		public global::AcpBusinessLayer.AcpListField E5BottomFunctionButtonBCO_43757
		{
			get
			{
				short num = (short)1606333130;
				short num2 = num;
				num = (short)810070730;
				switch (num2 == num)
				{
				}
				num = (short)837419009;
				if (num != 0)
				{
				}
				num = (short)1033371648;
				short num3 = num;
				num = (short)1222508544;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonBCO_43757;
			}
		}

		// Token: 0x1700473A RID: 18234
		// (get) Token: 0x06008CE2 RID: 36066 RVA: 0x00843540 File Offset: 0x00841740
		// (set) Token: 0x06008CE3 RID: 36067 RVA: 0x008435F4 File Offset: 0x008417F4
		public bool E5BottomFunctionButtonBCO_43757_Applicable
		{
			get
			{
				short num = (short)16374183;
				short num2 = num;
				num = (short)560322983;
				switch (num2 == num)
				{
				}
				num = (short)1132855296;
				if (num != 0)
				{
				}
				num = (short)1426522112;
				short num3 = num;
				num = (short)1368981505;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonBCO_43757.Applicable;
			}
			set
			{
				short num = (short)1528545243;
				short num2 = num;
				num = (short)1816051675;
				switch (num2 == num)
				{
				}
				num = (short)1572405249;
				if (num != 0)
				{
				}
				num = (short)1325203456;
				short num3 = num;
				num = (short)673841152;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonBCO_43757.Applicable = value;
			}
		}

		// Token: 0x1700473B RID: 18235
		// (get) Token: 0x06008CE4 RID: 36068 RVA: 0x008436A8 File Offset: 0x008418A8
		// (set) Token: 0x06008CE5 RID: 36069 RVA: 0x0084375C File Offset: 0x0084195C
		public bool E5BottomFunctionButtonBCO_43757_Valid
		{
			get
			{
				short num = (short)1879312007;
				short num2 = num;
				num = (short)849217159;
				switch (num2 == num)
				{
				}
				num = (short)1491927041;
				if (num != 0)
				{
				}
				num = (short)313196544;
				short num3 = num;
				num = (short)239730688;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonBCO_43757.Valid;
			}
			set
			{
				short num = (short)2009231055;
				short num2 = num;
				num = (short)21655247;
				switch (num2 == num)
				{
				}
				num = (short)1825112064;
				if (num != 0)
				{
				}
				num = (short)1373503488;
				short num3 = num;
				num = (short)115343361;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonBCO_43757.Valid = value;
			}
		}

		// Token: 0x1700473C RID: 18236
		// (get) Token: 0x06008CE6 RID: 36070 RVA: 0x00843814 File Offset: 0x00841A14
		// (set) Token: 0x06008CE7 RID: 36071 RVA: 0x008438C4 File Offset: 0x00841AC4
		public bool E5BottomFunctionButtonBCO_43757_Visible
		{
			get
			{
				short num = (short)1444682547;
				short num2 = num;
				num = (short)1006967603;
				switch (num2 == num)
				{
				}
				num = (short)188088320;
				if (num != 0)
				{
				}
				num = (short)1480196096;
				short num3 = num;
				num = (short)376569857;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonBCO_43757.Visible;
			}
			set
			{
				short num = (short)2085075508;
				short num2 = num;
				num = (short)403487284;
				switch (num2 == num)
				{
				}
				num = (short)576258048;
				if (num != 0)
				{
				}
				num = (short)1553203200;
				short num3 = num;
				num = (short)204079105;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonBCO_43757.Visible = value;
			}
		}

		// Token: 0x1700473D RID: 18237
		// (get) Token: 0x06008CE8 RID: 36072 RVA: 0x00843978 File Offset: 0x00841B78
		// (set) Token: 0x06008CE9 RID: 36073 RVA: 0x00843A30 File Offset: 0x00841C30
		public bool E5BottomFunctionButtonBCO_43757_Editable
		{
			get
			{
				short num = (short)339082005;
				short num2 = num;
				num = (short)165018389;
				switch (num2 == num)
				{
				}
				num = (short)1268973569;
				if (num != 0)
				{
				}
				num = (short)1706754048;
				short num3 = num;
				num = (short)248446976;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonBCO_43757.Editable;
			}
			set
			{
				short num = (short)2097153;
				if (num != 0)
				{
				}
				num = (short)450733190;
				short num2 = num;
				num = (short)42837126;
				switch (num2 == num)
				{
				}
				num = (short)1781268480;
				short num3 = num;
				num = (short)1056374784;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonBCO_43757.Editable = value;
			}
		}

		// Token: 0x1700473E RID: 18238
		// (get) Token: 0x06008CEA RID: 36074 RVA: 0x00843AE4 File Offset: 0x00841CE4
		internal string E5BottomFunctionButtonBCO_43757_UILabel
		{
			get
			{
				short num = (short)1325325948;
				short num2 = num;
				num = (short)435019388;
				switch (num2 == num)
				{
				}
				num = (short)241238017;
				if (num != 0)
				{
				}
				num = (short)789970944;
				short num3 = num;
				num = (short)2126053376;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonBCO_43757.UIName;
			}
		}

		// Token: 0x1700473F RID: 18239
		// (get) Token: 0x06008CEB RID: 36075 RVA: 0x00843B98 File Offset: 0x00841D98
		// (set) Token: 0x06008CEC RID: 36076 RVA: 0x00843C4C File Offset: 0x00841E4C
		internal bool E5BottomFunctionButtonBCO_43757_HiddenStatic
		{
			get
			{
				short num = (short)1906291923;
				short num2 = num;
				num = (short)729134291;
				switch (num2 == num)
				{
				}
				num = (short)191692801;
				if (num != 0)
				{
				}
				num = (short)1675296768;
				short num3 = num;
				num = (short)581238784;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonBCO_43757.HiddenStatic;
			}
			set
			{
				short num = (short)1949737368;
				short num2 = num;
				num = (short)1246405016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1003552768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)701038593;
				if (num != 0)
				{
				}
				num = (short)1088684032;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonBCO_43757.HiddenStatic = value;
			}
		}

		// Token: 0x17004740 RID: 18240
		// (get) Token: 0x06008CED RID: 36077 RVA: 0x00843D00 File Offset: 0x00841F00
		// (set) Token: 0x06008CEE RID: 36078 RVA: 0x00843DB4 File Offset: 0x00841FB4
		internal bool E5BottomFunctionButtonBCO_43757_HiddenDynamic
		{
			get
			{
				short num = (short)617403263;
				short num2 = num;
				num = (short)1968886655;
				switch (num2 == num)
				{
				default:
				{
					num = (short)69992448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2126184449;
				if (num != 0)
				{
				}
				num = (short)1913389056;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonBCO_43757.HiddenDynamic;
			}
			set
			{
				short num = (short)1284303260;
				short num2 = num;
				num = (short)1701964188;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1642004480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2077949953;
				if (num != 0)
				{
				}
				num = (short)1406140416;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonBCO_43757.HiddenDynamic = value;
			}
		}

		// Token: 0x17004741 RID: 18241
		// (get) Token: 0x06008CEF RID: 36079 RVA: 0x00843E68 File Offset: 0x00842068
		public bool E5BottomFunctionButtonBCO_43757_HasDiffs
		{
			get
			{
				short num = (short)1430532189;
				short num2 = num;
				num = (short)1752182877;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1334968320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2074148865;
				if (num != 0)
				{
				}
				num = (short)229834752;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonBCO_43757._HasDiffs;
			}
		}

		// Token: 0x17004742 RID: 18242
		// (get) Token: 0x06008CF0 RID: 36080 RVA: 0x00843F1C File Offset: 0x0084211C
		// (set) Token: 0x06008CF1 RID: 36081 RVA: 0x00843FD0 File Offset: 0x008421D0
		public int E5BottomFunctionButtonIndex_43759Value
		{
			get
			{
				short num = (short)1113932663;
				short num2 = num;
				num = (short)1693795191;
				switch (num2 == num)
				{
				default:
				{
					num = (short)352190464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2112880641;
				if (num != 0)
				{
				}
				num = (short)447938560;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonIndex_43759.Value;
			}
			set
			{
				short num = (short)160566112;
				short num2 = num;
				num = (short)579734368;
				switch (num2 == num)
				{
				default:
				{
					num = (short)533921792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)72482817;
				if (num != 0)
				{
				}
				num = (short)1894121472;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonIndex_43759.Value = value;
			}
		}

		// Token: 0x17004743 RID: 18243
		// (get) Token: 0x06008CF2 RID: 36082 RVA: 0x00844084 File Offset: 0x00842284
		// (set) Token: 0x06008CF3 RID: 36083 RVA: 0x0084413C File Offset: 0x0084233C
		public string E5BottomFunctionButtonIndex_43759_UIValue
		{
			get
			{
				short num = (short)1370505050;
				short num2 = num;
				num = (short)501432154;
				switch (num2 == num)
				{
				default:
				{
					num = (short)575864832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1010565121;
				if (num != 0)
				{
				}
				num = (short)1498939392;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonIndex_43759.UIValue;
			}
			set
			{
				short num = (short)1375018016;
				short num2 = num;
				num = (short)1200299040;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1021050880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)679608321;
				if (num != 0)
				{
				}
				num = (short)599916544;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonIndex_43759.UIValue = value;
			}
		}

		// Token: 0x17004744 RID: 18244
		// (get) Token: 0x06008CF4 RID: 36084 RVA: 0x008441F0 File Offset: 0x008423F0
		public global::AcpBusinessLayer.AcpRecRefField E5BottomFunctionButtonIndex_43759
		{
			get
			{
				short num = (short)2088222770;
				short num2 = num;
				num = (short)1916780594;
				switch (num2 == num)
				{
				default:
				{
					num = (short)302055424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1581842433;
				if (num != 0)
				{
				}
				num = (short)1275658240;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonIndex_43759;
			}
		}

		// Token: 0x17004745 RID: 18245
		// (get) Token: 0x06008CF5 RID: 36085 RVA: 0x008442A0 File Offset: 0x008424A0
		// (set) Token: 0x06008CF6 RID: 36086 RVA: 0x00844358 File Offset: 0x00842558
		public bool E5BottomFunctionButtonIndex_43759_Applicable
		{
			get
			{
				short num = (short)419075584;
				short num2 = num;
				num = (short)216569344;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1042481152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2063204353;
				if (num != 0)
				{
				}
				num = (short)832045056;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonIndex_43759.Applicable;
			}
			set
			{
				short num = (short)697711187;
				short num2 = num;
				num = (short)19806803;
				switch (num2 == num)
				{
				default:
				{
					num = (short)400621568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1420165121;
				if (num != 0)
				{
				}
				num = (short)1728446464;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonIndex_43759.Applicable = value;
			}
		}

		// Token: 0x17004746 RID: 18246
		// (get) Token: 0x06008CF7 RID: 36087 RVA: 0x00844410 File Offset: 0x00842610
		// (set) Token: 0x06008CF8 RID: 36088 RVA: 0x008444C8 File Offset: 0x008426C8
		public bool E5BottomFunctionButtonIndex_43759_Valid
		{
			get
			{
				short num = (short)928120833;
				if (num != 0)
				{
				}
				num = (short)1746534400;
				short num2 = num;
				num = (short)1109062715;
				short num3 = num;
				num = (short)970716219;
				switch (num3 == num)
				{
				}
				num = (short)1809383424;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonIndex_43759.Valid;
			}
			set
			{
				short num = (short)1461858327;
				short num2 = num;
				num = (short)703279127;
				switch (num2 == num)
				{
				default:
				{
					num = (short)759758848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)891092993;
				if (num != 0)
				{
				}
				num = (short)864223232;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonIndex_43759.Valid = value;
			}
		}

		// Token: 0x17004747 RID: 18247
		// (get) Token: 0x06008CF9 RID: 36089 RVA: 0x00844580 File Offset: 0x00842780
		// (set) Token: 0x06008CFA RID: 36090 RVA: 0x00844638 File Offset: 0x00842838
		public bool E5BottomFunctionButtonIndex_43759_Visible
		{
			get
			{
				short num = (short)699531265;
				if (num != 0)
				{
				}
				num = (short)248315904;
				short num2 = num;
				num = (short)1149407246;
				short num3 = num;
				num = (short)1588957198;
				switch (num3 == num)
				{
				}
				num = (short)214302720;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonIndex_43759.Visible;
			}
			set
			{
				short num = (short)2147091075;
				short num2 = num;
				num = (short)1227358851;
				switch (num2 == num)
				{
				default:
				{
					num = (short)485752832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1573978112;
				if (num != 0)
				{
				}
				num = (short)1775173633;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonIndex_43759.Visible = value;
			}
		}

		// Token: 0x17004748 RID: 18248
		// (get) Token: 0x06008CFB RID: 36091 RVA: 0x008446EC File Offset: 0x008428EC
		// (set) Token: 0x06008CFC RID: 36092 RVA: 0x0084479C File Offset: 0x0084299C
		public bool E5BottomFunctionButtonIndex_43759_Editable
		{
			get
			{
				short num = (short)1959959186;
				short num2 = num;
				num = (short)2013567634;
				switch (num2 == num)
				{
				default:
				{
					num = (short)910491648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)107741185;
				if (num != 0)
				{
				}
				num = (short)699727872;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonIndex_43759.Editable;
			}
			set
			{
				short num = (short)812908545;
				if (num != 0)
				{
				}
				num = (short)181141504;
				short num2 = num;
				num = (short)366656788;
				short num3 = num;
				num = (short)1197325588;
				switch (num3 == num)
				{
				}
				num = (short)1562050560;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonIndex_43759.Editable = value;
			}
		}

		// Token: 0x17004749 RID: 18249
		// (get) Token: 0x06008CFD RID: 36093 RVA: 0x00844850 File Offset: 0x00842A50
		internal string E5BottomFunctionButtonIndex_43759_UILabel
		{
			get
			{
				short num = (short)1454574199;
				short num2 = num;
				num = (short)735251063;
				switch (num2 == num)
				{
				default:
				{
					num = (short)782172160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1477902336;
				if (num != 0)
				{
				}
				num = (short)1771765761;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonIndex_43759.UIName;
			}
		}

		// Token: 0x1700474A RID: 18250
		// (get) Token: 0x06008CFE RID: 36094 RVA: 0x00844904 File Offset: 0x00842B04
		// (set) Token: 0x06008CFF RID: 36095 RVA: 0x008449B8 File Offset: 0x00842BB8
		internal bool E5BottomFunctionButtonIndex_43759_HiddenStatic
		{
			get
			{
				short num = (short)502398977;
				if (num != 0)
				{
				}
				num = (short)1137377280;
				short num2 = num;
				num = (short)1539754704;
				short num3 = num;
				num = (short)646957776;
				switch (num3 == num)
				{
				}
				num = (short)480444416;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonIndex_43759.HiddenStatic;
			}
			set
			{
				short num = (short)1719413768;
				short num2 = num;
				num = (short)2097884168;
				switch (num2 == num)
				{
				default:
				{
					num = (short)552534016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1047986176;
				if (num != 0)
				{
				}
				num = (short)126943233;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonIndex_43759.HiddenStatic = value;
			}
		}

		// Token: 0x1700474B RID: 18251
		// (get) Token: 0x06008D00 RID: 36096 RVA: 0x00844A6C File Offset: 0x00842C6C
		// (set) Token: 0x06008D01 RID: 36097 RVA: 0x00844B20 File Offset: 0x00842D20
		internal bool E5BottomFunctionButtonIndex_43759_HiddenDynamic
		{
			get
			{
				short num = (short)241811748;
				short num2 = num;
				num = (short)1660272932;
				switch (num2 == num)
				{
				default:
				{
					num = (short)768278528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)754778113;
				if (num != 0)
				{
				}
				num = (short)735576064;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonIndex_43759.HiddenDynamic;
			}
			set
			{
				short num = (short)1246023278;
				short num2 = num;
				num = (short)1792462446;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1518993408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)512229377;
				if (num != 0)
				{
				}
				num = (short)1666711552;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonIndex_43759.HiddenDynamic = value;
			}
		}

		// Token: 0x1700474C RID: 18252
		// (get) Token: 0x06008D02 RID: 36098 RVA: 0x00844BD4 File Offset: 0x00842DD4
		public bool E5BottomFunctionButtonIndex_43759_HasDiffs
		{
			get
			{
				short num = (short)1308061841;
				short num2 = num;
				num = (short)1359507601;
				switch (num2 == num)
				{
				default:
				{
					num = (short)437256192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)314703872;
				if (num != 0)
				{
				}
				num = (short)1583087617;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonIndex_43759._HasDiffs;
			}
		}

		// Token: 0x1700474D RID: 18253
		// (get) Token: 0x06008D03 RID: 36099 RVA: 0x00844C88 File Offset: 0x00842E88
		// (set) Token: 0x06008D04 RID: 36100 RVA: 0x00844D3C File Offset: 0x00842F3C
		public int E5BottomFunctionButtonFeature_43758Value
		{
			get
			{
				short num = (short)322174977;
				if (num != 0)
				{
				}
				num = (short)1194590208;
				short num2 = num;
				num = (short)18238876;
				short num3 = num;
				num = (short)1152339356;
				switch (num3 == num)
				{
				}
				num = (short)701431808;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonFeature_43758.Value;
			}
			set
			{
				short num = (short)744357036;
				short num2 = num;
				num = (short)1117519020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)952500224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1285619713;
				if (num != 0)
				{
				}
				num = (short)1774583808;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonFeature_43758.Value = value;
			}
		}

		// Token: 0x1700474E RID: 18254
		// (get) Token: 0x06008D05 RID: 36101 RVA: 0x00844DF0 File Offset: 0x00842FF0
		// (set) Token: 0x06008D06 RID: 36102 RVA: 0x00844EA4 File Offset: 0x008430A4
		public string E5BottomFunctionButtonFeature_43758_UIValue
		{
			get
			{
				short num = (short)1642729427;
				short num2 = num;
				num = (short)1027936211;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1785724928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1692467200;
				if (num != 0)
				{
				}
				num = (short)98893825;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonFeature_43758.UIValue;
			}
			set
			{
				short num = (short)202615149;
				short num2 = num;
				num = (short)1383115117;
				switch (num2 == num)
				{
				default:
				{
					num = (short)904921088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1651638272;
				if (num != 0)
				{
				}
				num = (short)415170561;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonFeature_43758.UIValue = value;
			}
		}

		// Token: 0x1700474F RID: 18255
		// (get) Token: 0x06008D07 RID: 36103 RVA: 0x00844F58 File Offset: 0x00843158
		public global::AcpBusinessLayer.AcpListField E5BottomFunctionButtonFeature_43758
		{
			get
			{
				short num = (short)407961601;
				if (num != 0)
				{
				}
				num = (short)62652416;
				short num2 = num;
				num = (short)306057221;
				short num3 = num;
				num = (short)591138821;
				switch (num3 == num)
				{
				}
				num = (short)1453129728;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonFeature_43758;
			}
		}

		// Token: 0x17004750 RID: 18256
		// (get) Token: 0x06008D08 RID: 36104 RVA: 0x0084500C File Offset: 0x0084320C
		// (set) Token: 0x06008D09 RID: 36105 RVA: 0x008450C0 File Offset: 0x008432C0
		public bool E5BottomFunctionButtonFeature_43758_Applicable
		{
			get
			{
				short num = (short)1720651376;
				short num2 = num;
				num = (short)2114784880;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1256652800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1542193152;
				if (num != 0)
				{
				}
				num = (short)1647509505;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonFeature_43758.Applicable;
			}
			set
			{
				short num = (short)1984215849;
				short num2 = num;
				num = (short)2093398825;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1038024704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)231211009;
				if (num != 0)
				{
				}
				num = (short)861208576;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonFeature_43758.Applicable = value;
			}
		}

		// Token: 0x17004751 RID: 18257
		// (get) Token: 0x06008D0A RID: 36106 RVA: 0x00845174 File Offset: 0x00843374
		// (set) Token: 0x06008D0B RID: 36107 RVA: 0x00845228 File Offset: 0x00843428
		public bool E5BottomFunctionButtonFeature_43758_Valid
		{
			get
			{
				short num = (short)239545900;
				short num2 = num;
				num = (short)1413951020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)950599680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1792344064;
				if (num != 0)
				{
				}
				num = (short)1874132993;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonFeature_43758.Valid;
			}
			set
			{
				short num = (short)1897332737;
				if (num != 0)
				{
				}
				num = (short)1279787008;
				short num2 = num;
				num = (short)1561685868;
				short num3 = num;
				num = (short)1339060076;
				switch (num3 == num)
				{
				}
				num = (short)1182334976;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonFeature_43758.Valid = value;
			}
		}

		// Token: 0x17004752 RID: 18258
		// (get) Token: 0x06008D0C RID: 36108 RVA: 0x008452DC File Offset: 0x008434DC
		// (set) Token: 0x06008D0D RID: 36109 RVA: 0x0084538C File Offset: 0x0084358C
		public bool E5BottomFunctionButtonFeature_43758_Visible
		{
			get
			{
				short num = (short)2113651116;
				short num2 = num;
				num = (short)647152044;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2124152832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)997851137;
				if (num != 0)
				{
				}
				num = (short)589103104;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonFeature_43758.Visible;
			}
			set
			{
				short num = (short)1134571927;
				short num2 = num;
				num = (short)2071277975;
				switch (num2 == num)
				{
				default:
				{
					num = (short)108199936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1483472897;
				if (num != 0)
				{
				}
				num = (short)483065856;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonFeature_43758.Visible = value;
			}
		}

		// Token: 0x17004753 RID: 18259
		// (get) Token: 0x06008D0E RID: 36110 RVA: 0x00845440 File Offset: 0x00843640
		// (set) Token: 0x06008D0F RID: 36111 RVA: 0x008454F0 File Offset: 0x008436F0
		public bool E5BottomFunctionButtonFeature_43758_Editable
		{
			get
			{
				short num = (short)1689793034;
				short num2 = num;
				num = (short)442839562;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1109458944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)148897793;
				if (num != 0)
				{
				}
				num = (short)811991040;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonFeature_43758.Editable;
			}
			set
			{
				short num = (short)1734025718;
				short num2 = num;
				num = (short)1368728054;
				switch (num2 == num)
				{
				default:
				{
					num = (short)550567936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)17432577;
				if (num != 0)
				{
				}
				num = (short)1421148160;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonFeature_43758.Editable = value;
			}
		}

		// Token: 0x17004754 RID: 18260
		// (get) Token: 0x06008D10 RID: 36112 RVA: 0x008455A4 File Offset: 0x008437A4
		internal string E5BottomFunctionButtonFeature_43758_UILabel
		{
			get
			{
				short num = (short)1087226841;
				short num2 = num;
				num = (short)664060889;
				switch (num2 == num)
				{
				default:
				{
					num = (short)21168128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1552023553;
				if (num != 0)
				{
				}
				num = (short)1052704768;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonFeature_43758.UIName;
			}
		}

		// Token: 0x17004755 RID: 18261
		// (get) Token: 0x06008D11 RID: 36113 RVA: 0x00845658 File Offset: 0x00843858
		// (set) Token: 0x06008D12 RID: 36114 RVA: 0x0084570C File Offset: 0x0084390C
		internal bool E5BottomFunctionButtonFeature_43758_HiddenStatic
		{
			get
			{
				short num = (short)694675277;
				short num2 = num;
				num = (short)995157837;
				switch (num2 == num)
				{
				default:
				{
					num = (short)249626624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)360579073;
				if (num != 0)
				{
				}
				num = (short)1010892800;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonFeature_43758.HiddenStatic;
			}
			set
			{
				short num = (short)1876066727;
				short num2 = num;
				num = (short)2070839719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)611057664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1796341760;
				if (num != 0)
				{
				}
				num = (short)494796801;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonFeature_43758.HiddenStatic = value;
			}
		}

		// Token: 0x17004756 RID: 18262
		// (get) Token: 0x06008D13 RID: 36115 RVA: 0x008457C4 File Offset: 0x008439C4
		// (set) Token: 0x06008D14 RID: 36116 RVA: 0x00845878 File Offset: 0x00843A78
		internal bool E5BottomFunctionButtonFeature_43758_HiddenDynamic
		{
			get
			{
				short num = (short)744620033;
				if (num != 0)
				{
				}
				num = (short)2071658496;
				short num2 = num;
				num = (short)1892966958;
				short num3 = num;
				num = (short)1464689198;
				switch (num3 == num)
				{
				}
				num = (short)19267584;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonFeature_43758.HiddenDynamic;
			}
			set
			{
				short num = (short)1953233365;
				short num2 = num;
				num = (short)1119287765;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1174142976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1275396097;
				if (num != 0)
				{
				}
				num = (short)299630592;
				if (num != 0)
				{
				}
				this.e5BottomFunctionButtonFeature_43758.HiddenDynamic = value;
			}
		}

		// Token: 0x17004757 RID: 18263
		// (get) Token: 0x06008D15 RID: 36117 RVA: 0x00845930 File Offset: 0x00843B30
		public bool E5BottomFunctionButtonFeature_43758_HasDiffs
		{
			get
			{
				short num = (short)835431566;
				short num2 = num;
				num = (short)1700179086;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1809252352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1990787073;
				if (num != 0)
				{
				}
				num = (short)644677632;
				if (num != 0)
				{
				}
				return this.e5BottomFunctionButtonFeature_43758._HasDiffs;
			}
		}

		// Token: 0x17004758 RID: 18264
		// (get) Token: 0x06008D16 RID: 36118 RVA: 0x008459E8 File Offset: 0x00843BE8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)563918312;
				short num2 = num;
				num = (short)1114813928;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1812856832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)637730817;
				if (num != 0)
				{
				}
				num = (short)2098200576;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x17004759 RID: 18265
		// (get) Token: 0x06008D17 RID: 36119 RVA: 0x00845AA4 File Offset: 0x00843CA4
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)1662052896;
				short num2 = num;
				num = (short)1280043552;
				switch (num2 == num)
				{
				default:
				{
					num = (short)675086336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)29556736;
				if (num != 0)
				{
				}
				num = (short)259063809;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x06008D18 RID: 36120 RVA: 0x00845B64 File Offset: 0x00843D64
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1131675652;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_100;
				case 2:
					num2 = (short)1723924481;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)878379009;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_B1;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)714670082;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			IL_100:
			return result;
			IL_24:
			num2 = (short)1891334262;
			short num3 = num2;
			num2 = (short)421296246;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B1:
				if (base.ParentRecset != null)
				{
					num2 = (short)1779630080;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				return result;
			case 1:
				break;
			default:
			{
				num2 = (short)543358976;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)2061762560;
			if (num2 != 0)
			{
			}
			result = null;
			num2 = (short)91226115;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400457A RID: 17786
		private global::AcpBusinessLayer.AcpField<string> e5BottomFunctionButtonName_43756;

		// Token: 0x0400457B RID: 17787
		private global::AcpBusinessLayer.AcpListField e5BottomFunctionButtonBCO_43757;

		// Token: 0x0400457C RID: 17788
		private global::AcpBusinessLayer.AcpRecRefField e5BottomFunctionButtonIndex_43759;

		// Token: 0x0400457D RID: 17789
		private global::AcpBusinessLayer.AcpListField e5BottomFunctionButtonFeature_43758;
	}
}
