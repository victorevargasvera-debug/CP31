using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000349 RID: 841
	[global::System.Serializable]
	public class BottomFunctionProgrammableButtonInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060080AE RID: 32942 RVA: 0x00762EC0 File Offset: 0x007610C0
		public BottomFunctionProgrammableButtonInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060080AF RID: 32943 RVA: 0x00762EDC File Offset: 0x007610DC
		protected BottomFunctionProgrammableButtonInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060080B0 RID: 32944 RVA: 0x00762EF4 File Offset: 0x007610F4
		public override void Init()
		{
			int a_ = 11;
			short num = (short)938082304;
			short num2 = num;
			num = (short)2140636209;
			short num3 = num;
			num = (short)2042594353;
			switch (num3 == num)
			{
			}
			num = (short)990707713;
			if (num != 0)
			{
			}
			num = (short)1913323520;
			if (num != 0)
			{
			}
			this.cHO9BottomFunctionButtonName_A36657 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_P1, this, global::AllFeatures.CodeplugGuid.b("迋蛍鿏雓맕곗껙돛돝ꛟ韡諣藥鳧菩菫胭닯蟱胳苵韷铹닻鿽淿朁嬃䜅㬇㰉㨋㬍✏", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.cHO9BottomFunctionButtonName_A36657.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO9BottomFunctionButtonName_A36657.DataTransferOrder = -1;
			this.cHO9BottomFunctionButtonBCO_A36660 = new global::AcpBusinessLayer.AcpSparseLOVField(165, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexCHO9BottomFunctionButtonBCO_A36660LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idCHO9BottomFunctionButtonBCO_A36660LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋蛍鿏雓맕곗껙돛돝ꛟ韡諣藥鳧菩菫胭닯蟱胳苵韷铹뻻뷽俿崁䔃㔅㸇㰉㨋㸍", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.CHO9BottomFunctionButtonBCO_A36660LovStrs);
			this.cHO9BottomFunctionButtonBCO_A36660.IgnoreOnCompare = true;
			this.cHO9BottomFunctionButtonBCO_A36660.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cHO9BottomFunctionButtonBCO_A36660.DataTransferOrder = -1;
			this.cHO9BottomFunctionButtonIndex_A36665 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("迋蛍鿏雓맕곗껙돛돝ꛟ韡諣藥鳧菩菫胭닯蟱胳苵韷铹뗻都擿朁簃夅䤇㤉㨋㠍☏✑", a_), global::CommonResources.AcgResources.ID_INDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.cHO9BottomFunctionButtonIndex_A36665.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO9BottomFunctionButtonIndex_A36665.DataTransferOrder = 16;
			this.cHO9BottomFunctionButtonIndex_A36665.ValidateAcrossRecset = true;
			this.cHO9BottomFunctionButtonFeature_A36664 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexCHO9BottomFunctionButtonFeature_A36664LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idCHO9BottomFunctionButtonFeature_A36664LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋蛍鿏雓맕곗껙돛돝ꛟ韡諣藥鳧菩菫胭닯蟱胳苵韷铹뫻鯽懿瘁焃琅洇唉䴋㴍☏␑∓∕", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.CHO9BottomFunctionButtonFeature_A36664LovStrs);
			this.cHO9BottomFunctionButtonFeature_A36664.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO9BottomFunctionButtonFeature_A36664.DataTransferOrder = 15;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軋ꇍ꓏ꛑ믓믕鳙꧛냝菟雡跣觥蛧쫩볫鳭鿯闱蛳韵闷韹鷻鳽泿朁␃䐅紇縉砋愍縏", a_);
			base.Id = 10619;
			base.UIName = global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONPROGRAMMABLEBUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060080B1 RID: 32945 RVA: 0x00763118 File Offset: 0x00761318
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)802029578;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					this.cHO9BottomFunctionButtonBCO_A36660 = new global::AcpBusinessLayer.AcpSparseLOVField(165, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexCHO9BottomFunctionButtonBCO_A36660LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idCHO9BottomFunctionButtonBCO_A36660LovStrs), this, global::AllFeatures.CodeplugGuid.b("金鳓駕飙돛ꫝ铟跡解ꃥ鷧蓩迫髭駯鷱髳듵跷軹裻釽滿䀁䜃䤅圇䬉㼋㠍☏␑␓", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.CHO9BottomFunctionButtonBCO_A36660LovStrs);
					this.cHO9BottomFunctionButtonBCO_A36660.IgnoreOnCompare = true;
					this.cHO9BottomFunctionButtonBCO_A36660.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cHO9BottomFunctionButtonBCO_A36660.DataTransferOrder = -1;
					num = (short)325877487;
					short num3 = num;
					num = (short)1891466991;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2B7;
					case 1:
						break;
					default:
					{
						num = (short)336068608;
						short num4 = num;
						break;
					}
					}
					num = (short)311492608;
					if (num != 0)
					{
					}
					num = (short)1497169926;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_3AE;
				case 2:
					goto IL_2B7;
				case 3:
					this.cHO9BottomFunctionButtonIndex_A36665 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("金鳓駕飙돛ꫝ铟跡解ꃥ鷧蓩迫髭駯鷱髳듵跷軹裻釽滿䬁樃戅洇爉匋伍⌏␑∓―ⴗ", a_), global::CommonResources.AcgResources.ID_INDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.cHO9BottomFunctionButtonIndex_A36665.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHO9BottomFunctionButtonIndex_A36665.DataTransferOrder = 16;
					this.cHO9BottomFunctionButtonIndex_A36665.ValidateAcrossRecset = true;
					num = (short)1154678789;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.cHO9BottomFunctionButtonName_A36657 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_P1, this, global::AllFeatures.CodeplugGuid.b("金鳓駕飙돛ꫝ铟跡解ꃥ鷧蓩迫髭駯鷱髳듵跷軹裻釽滿䰁攃欅洇唉䴋㴍☏␑ℓℕ", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.cHO9BottomFunctionButtonName_A36657.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHO9BottomFunctionButtonName_A36657.DataTransferOrder = -1;
					num = (short)1331822593;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_26E;
				case 6:
					goto IL_2F5;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("金鳓駕飙돛ꫝ铟跡解ꃥ鷧蓩迫髭駯鷱髳듵跷軹裻釽滿䀁䜃䤅圇䬉㼋㠍☏␑␓", a_)))
					{
						num = (short)1370619904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2F5;
				case 8:
					num = (short)1163067406;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("金鳓駕飙돛ꫝ铟跡解ꃥ鷧蓩迫髭駯鷱髳듵跷軹裻釽滿䰁攃欅洇唉䴋㴍☏␑ℓℕ", a_)))
					{
						num = (short)409403396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3AE;
				case 10:
					num = (short)884736001;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_97;
					}
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("金鳓駕飙돛ꫝ铟跡解ꃥ鷧蓩迫髭駯鷱髳듵跷軹裻釽滿䬁樃戅洇爉匋伍⌏␑∓―ⴗ", a_)))
					{
						num = (short)1272971267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26E;
				case 12:
					num = (short)1354039305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_3A9;
				case 14:
					if (producerFields != null)
					{
						num = (short)1072562188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_458;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("金鳓駕飙돛ꫝ铟跡解ꃥ鷧蓩迫髭駯鷱髳듵跷軹裻釽滿䐁愃朅簇缉縋欍伏匑✓―⸗Ⱉ⠛", a_)))
					{
						num = (short)1025048578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_458;
				}
				IL_97:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1406205960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_26E:
				num = (short)1545994255;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B7:
				this.cHO9BottomFunctionButtonFeature_A36664 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexCHO9BottomFunctionButtonFeature_A36664LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idCHO9BottomFunctionButtonFeature_A36664LovStrs), this, global::AllFeatures.CodeplugGuid.b("金鳓駕飙돛ꫝ铟跡解ꃥ鷧蓩迫髭駯鷱髳듵跷軹裻釽滿䐁愃朅簇缉縋欍伏匑✓―⸗Ⱉ⠛", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.CHO9BottomFunctionButtonFeature_A36664LovStrs);
				this.cHO9BottomFunctionButtonFeature_A36664.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
				this.cHO9BottomFunctionButtonFeature_A36664.DataTransferOrder = 15;
				num = (short)1800339469;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2F5:
				num = (short)1015611403;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3AE:
				num = (short)819396615;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3A9:
			IL_458:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("郑믓ꋕ곗뗙뇛ﻝꛟ韡諣藥鳧菩菫胭탯ꋱ蛳駵鿷裹鷻鏽淿持昃樅洇⨉下笍搏昑笓砕", a_);
			base.Id = 10619;
			base.UIName = global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONPROGRAMMABLEBUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060080B2 RID: 32946 RVA: 0x007635B0 File Offset: 0x007617B0
		public override void PopulateReferences()
		{
			short num = (short)1730936832;
			short num2 = num;
			num = (short)1051875072;
			short num3 = num;
			num = (short)1701467904;
			switch (num3 == num)
			{
			}
			num = (short)802029568;
			if (num != 0)
			{
			}
			num = (short)743505921;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			global::System.Collections.Generic.List<global::AcpBusinessLayer.Recordset> list2 = new global::System.Collections.Generic.List<global::AcpBusinessLayer.Recordset>();
			list2.Add((global::AcpBusinessLayer.Recordset)this.a(4008));
			list.Add(global::CommonResources.AcgResources.ID_ACTIONCONSOLIDATION);
			list2.Add((global::AcpBusinessLayer.Recordset)this.a(2045)[0][10604].EmbeddedRecset);
			list.Add(global::CommonResources.AcgResources.ID_RELAYPATTERN);
			((global::AcpBusinessLayer.AcpSparseLOVField)this.cHO9BottomFunctionButtonFeature_A36664).SetBuddyRecRefField(this.cHO9BottomFunctionButtonIndex_A36665, list2, list);
		}

		// Token: 0x060080B3 RID: 32947 RVA: 0x007636D4 File Offset: 0x007618D4
		public override void DropReferences()
		{
			short num = (short)390135808;
			short num2 = num;
			num = (short)1489856708;
			short num3 = num;
			num = (short)1021339844;
			switch (num3 == num)
			{
			}
			num = (short)1630601216;
			if (num != 0)
			{
			}
			num = (short)606666753;
			if (num != 0)
			{
			}
		}

		// Token: 0x060080B4 RID: 32948 RVA: 0x0076377C File Offset: 0x0076197C
		public override void SetConstraints()
		{
			short num = (short)1918238720;
			short num2 = num;
			num = (short)820404630;
			short num3 = num;
			num = (short)1807507862;
			switch (num3 == num)
			{
			}
			num = (short)2013790209;
			if (num != 0)
			{
			}
			num = (short)815202304;
			if (num != 0)
			{
			}
			this.cHO9BottomFunctionButtonName_A36657.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.cHO9BottomFunctionButtonIndex_A36665.ValidateAcrossRecset = true;
			this.cHO9BottomFunctionButtonIndex_A36665.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConO9BottomProBtnIndexApplicability);
			this.cHO9BottomFunctionButtonIndex_A36665.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConACorRelayPatternUniqueinTopandBottomandDirLightTBL);
			this.cHO9BottomFunctionButtonIndex_A36665.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableEditable);
			this.cHO9BottomFunctionButtonIndex_A36665.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConValueSetIfBottomBtnIndexIsChanged);
			this.cHO9BottomFunctionButtonFeature_A36664.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableApp);
			this.cHO9BottomFunctionButtonFeature_A36664.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConO9BottomProBtnFeatureValidity);
			this.cHO9BottomFunctionButtonFeature_A36664.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableEditable);
			this.cHO9BottomFunctionButtonFeature_A36664.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConValueSetIfBottomBtnFeatIsACOrLB);
		}

		// Token: 0x060080B5 RID: 32949 RVA: 0x00763900 File Offset: 0x00761B00
		public override void SetupDependencies()
		{
			short num = (short)295895040;
			short num2 = num;
			num = (short)1865700928;
			short num3 = num;
			num = (short)572413504;
			switch (num3 == num)
			{
			}
			num = (short)728236033;
			if (num != 0)
			{
			}
			num = (short)1845690368;
			if (num != 0)
			{
			}
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cHO9BottomFunctionButtonIndex_A36665);
			this.cHO9BottomFunctionButtonFeature_A36664.AddDependentObject(this.cHO9BottomFunctionButtonIndex_A36665);
			this.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.AddDependentObject(this.cHO9BottomFunctionButtonIndex_A36665);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cHO9BottomFunctionButtonFeature_A36664);
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561.AddDependentObject(this.cHO9BottomFunctionButtonFeature_A36664);
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550.AddDependentObject(this.cHO9BottomFunctionButtonFeature_A36664);
			this.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.AddDependentObject(this.cHO9BottomFunctionButtonFeature_A36664);
			this.RefRadioWide.Features.RadWideFeaturesChannelFallbackEnable.AddDependentObject(this.cHO9BottomFunctionButtonFeature_A36664);
		}

		// Token: 0x170041C4 RID: 16836
		// (get) Token: 0x060080B6 RID: 32950 RVA: 0x00763A80 File Offset: 0x00761C80
		public global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation ActionConsolidationForCHO9BottomFunctionButtonIndex_A36665
		{
			get
			{
				short num = (short)874643456;
				short num2 = num;
				num = (short)1733004444;
				short num3 = num;
				num = (short)422546588;
				switch (num3 == num)
				{
				}
				num = (short)11272193;
				if (num != 0)
				{
				}
				num = (short)1638400;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonIndex_A36665.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation;
			}
		}

		// Token: 0x170041C5 RID: 16837
		// (get) Token: 0x060080B7 RID: 32951 RVA: 0x00763B38 File Offset: 0x00761D38
		public bool HasDiffs
		{
			get
			{
				short num = (short)1619984384;
				short num2 = num;
				num = (short)1014890497;
				if (num != 0)
				{
				}
				num = (short)458703025;
				short num3 = num;
				num = (short)332808369;
				switch (num3 == num)
				{
				}
				num = (short)1736704000;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170041C6 RID: 16838
		// (get) Token: 0x060080B8 RID: 32952 RVA: 0x00763BEC File Offset: 0x00761DEC
		// (set) Token: 0x060080B9 RID: 32953 RVA: 0x00763CA4 File Offset: 0x00761EA4
		public string CHO9BottomFunctionButtonName_A36657Value
		{
			get
			{
				short num = (short)319684608;
				short num2 = num;
				num = (short)1850867713;
				if (num != 0)
				{
				}
				num = (short)1053828859;
				short num3 = num;
				num = (short)1570318075;
				switch (num3 == num)
				{
				}
				num = (short)1267138560;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonName_A36657.Value;
			}
			set
			{
				short num = (short)2086993920;
				short num2 = num;
				num = (short)2000727772;
				short num3 = num;
				num = (short)1633332956;
				switch (num3 == num)
				{
				}
				num = (short)9306113;
				if (num != 0)
				{
				}
				num = (short)1979842560;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonName_A36657.Value = value;
			}
		}

		// Token: 0x170041C7 RID: 16839
		// (get) Token: 0x060080BA RID: 32954 RVA: 0x00763D5C File Offset: 0x00761F5C
		public global::AcpBusinessLayer.AcpField<string> CHO9BottomFunctionButtonName_A36657
		{
			get
			{
				short num = (short)53280768;
				short num2 = num;
				num = (short)1249277188;
				short num3 = num;
				num = (short)920352004;
				switch (num3 == num)
				{
				}
				num = (short)965541888;
				if (num != 0)
				{
				}
				num = (short)1295122433;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonName_A36657;
			}
		}

		// Token: 0x170041C8 RID: 16840
		// (get) Token: 0x060080BB RID: 32955 RVA: 0x00763E0C File Offset: 0x0076200C
		// (set) Token: 0x060080BC RID: 32956 RVA: 0x00763EC0 File Offset: 0x007620C0
		public string CHO9BottomFunctionButtonName_A36657_UIValue
		{
			get
			{
				short num = (short)280166400;
				short num2 = num;
				num = (short)47327052;
				short num3 = num;
				num = (short)396633932;
				switch (num3 == num)
				{
				}
				num = (short)1691746304;
				if (num != 0)
				{
				}
				num = (short)1296695297;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonName_A36657.Value;
			}
			set
			{
				short num = (short)1727594496;
				short num2 = num;
				num = (short)1300764726;
				short num3 = num;
				num = (short)688855094;
				switch (num3 == num)
				{
				}
				num = (short)1360527361;
				if (num != 0)
				{
				}
				num = (short)1694236672;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonName_A36657.Value = value;
			}
		}

		// Token: 0x170041C9 RID: 16841
		// (get) Token: 0x060080BD RID: 32957 RVA: 0x00763F74 File Offset: 0x00762174
		// (set) Token: 0x060080BE RID: 32958 RVA: 0x00764028 File Offset: 0x00762228
		public bool CHO9BottomFunctionButtonName_A36657_Applicable
		{
			get
			{
				short num = (short)788145192;
				short num2 = num;
				num = (short)1577460776;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1662779392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2029387777;
				if (num != 0)
				{
				}
				num = (short)1292173312;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonName_A36657.Applicable;
			}
			set
			{
				short num = (short)1360002960;
				short num2 = num;
				num = (short)238682000;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1482227712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)471072768;
				if (num != 0)
				{
				}
				num = (short)1200422913;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonName_A36657.Applicable = value;
			}
		}

		// Token: 0x170041CA RID: 16842
		// (get) Token: 0x060080BF RID: 32959 RVA: 0x007640E0 File Offset: 0x007622E0
		// (set) Token: 0x060080C0 RID: 32960 RVA: 0x00764198 File Offset: 0x00762398
		public bool CHO9BottomFunctionButtonName_A36657_Valid
		{
			get
			{
				short num = (short)698810369;
				if (num != 0)
				{
				}
				num = (short)1078722560;
				short num2 = num;
				num = (short)1458976179;
				short num3 = num;
				num = (short)1270429107;
				switch (num3 == num)
				{
				}
				num = (short)1641021440;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonName_A36657.Valid;
			}
			set
			{
				short num = (short)922006256;
				short num2 = num;
				num = (short)1428599536;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1987444736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)145686528;
				if (num != 0)
				{
				}
				num = (short)1860370433;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonName_A36657.Valid = value;
			}
		}

		// Token: 0x170041CB RID: 16843
		// (get) Token: 0x060080C1 RID: 32961 RVA: 0x0076424C File Offset: 0x0076244C
		// (set) Token: 0x060080C2 RID: 32962 RVA: 0x00764304 File Offset: 0x00762504
		public bool CHO9BottomFunctionButtonName_A36657_Visible
		{
			get
			{
				short num = (short)183057066;
				short num2 = num;
				num = (short)1167342250;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1602879488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1005191168;
				if (num != 0)
				{
				}
				num = (short)121765889;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonName_A36657.Visible;
			}
			set
			{
				short num = (short)1901330433;
				if (num != 0)
				{
				}
				num = (short)470220800;
				short num2 = num;
				num = (short)1182862539;
				short num3 = num;
				num = (short)1822166219;
				switch (num3 == num)
				{
				}
				num = (short)1555628032;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonName_A36657.Visible = value;
			}
		}

		// Token: 0x170041CC RID: 16844
		// (get) Token: 0x060080C3 RID: 32963 RVA: 0x007643B8 File Offset: 0x007625B8
		// (set) Token: 0x060080C4 RID: 32964 RVA: 0x0076446C File Offset: 0x0076266C
		public bool CHO9BottomFunctionButtonName_A36657_Editable
		{
			get
			{
				short num = (short)1041921471;
				short num2 = num;
				num = (short)1672312255;
				switch (num2 == num)
				{
				default:
				{
					num = (short)800194560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)968949760;
				if (num != 0)
				{
				}
				num = (short)226754561;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonName_A36657.Editable;
			}
			set
			{
				short num = (short)667404866;
				short num2 = num;
				num = (short)722061890;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1655373824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)933101568;
				if (num != 0)
				{
				}
				num = (short)918487041;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonName_A36657.Editable = value;
			}
		}

		// Token: 0x170041CD RID: 16845
		// (get) Token: 0x060080C5 RID: 32965 RVA: 0x00764520 File Offset: 0x00762720
		internal string CHO9BottomFunctionButtonName_A36657_UILabel
		{
			get
			{
				short num = (short)1369211179;
				short num2 = num;
				num = (short)1418232107;
				switch (num2 == num)
				{
				default:
				{
					num = (short)583925760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2008809473;
				if (num != 0)
				{
				}
				num = (short)1837105152;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonName_A36657.UIName;
			}
		}

		// Token: 0x170041CE RID: 16846
		// (get) Token: 0x060080C6 RID: 32966 RVA: 0x007645D8 File Offset: 0x007627D8
		// (set) Token: 0x060080C7 RID: 32967 RVA: 0x00764690 File Offset: 0x00762890
		internal bool CHO9BottomFunctionButtonName_A36657_HiddenStatic
		{
			get
			{
				short num = (short)1059371474;
				short num2 = num;
				num = (short)1060092370;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1987837952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1420689409;
				if (num != 0)
				{
				}
				num = (short)157155328;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonName_A36657.HiddenStatic;
			}
			set
			{
				short num = (short)1371815601;
				short num2 = num;
				num = (short)82984625;
				switch (num2 == num)
				{
				default:
				{
					num = (short)272433152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1261764608;
				if (num != 0)
				{
				}
				num = (short)270860289;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonName_A36657.HiddenStatic = value;
			}
		}

		// Token: 0x170041CF RID: 16847
		// (get) Token: 0x060080C8 RID: 32968 RVA: 0x00764748 File Offset: 0x00762948
		// (set) Token: 0x060080C9 RID: 32969 RVA: 0x007647FC File Offset: 0x007629FC
		internal bool CHO9BottomFunctionButtonName_A36657_HiddenDynamic
		{
			get
			{
				short num = (short)864134262;
				short num2 = num;
				num = (short)306160758;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1998848000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1336213505;
				if (num != 0)
				{
				}
				num = (short)407109632;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonName_A36657.HiddenDynamic;
			}
			set
			{
				short num = (short)885430800;
				short num2 = num;
				num = (short)96967184;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1633943552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)579993601;
				if (num != 0)
				{
				}
				num = (short)290586624;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonName_A36657.HiddenDynamic = value;
			}
		}

		// Token: 0x170041D0 RID: 16848
		// (get) Token: 0x060080CA RID: 32970 RVA: 0x007648B4 File Offset: 0x00762AB4
		public bool CHO9BottomFunctionButtonName_A36657_HasDiffs
		{
			get
			{
				short num = (short)618163322;
				short num2 = num;
				num = (short)2139253882;
				switch (num2 == num)
				{
				default:
				{
					num = (short)650510336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2095316993;
				if (num != 0)
				{
				}
				num = (short)1206321152;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonName_A36657._HasDiffs;
			}
		}

		// Token: 0x170041D1 RID: 16849
		// (get) Token: 0x060080CB RID: 32971 RVA: 0x00764968 File Offset: 0x00762B68
		// (set) Token: 0x060080CC RID: 32972 RVA: 0x00764A1C File Offset: 0x00762C1C
		public int CHO9BottomFunctionButtonBCO_A36660Value
		{
			get
			{
				short num = (short)2120460364;
				short num2 = num;
				num = (short)626370636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1508245504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1069481985;
				if (num != 0)
				{
				}
				num = (short)710672384;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36660.Value;
			}
			set
			{
				short num = (short)331667840;
				short num2 = num;
				num = (short)144038272;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1784545280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1233453057;
				if (num != 0)
				{
				}
				num = (short)1436155904;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonBCO_A36660.Value = value;
			}
		}

		// Token: 0x170041D2 RID: 16850
		// (get) Token: 0x060080CD RID: 32973 RVA: 0x00764AD0 File Offset: 0x00762CD0
		// (set) Token: 0x060080CE RID: 32974 RVA: 0x00764B88 File Offset: 0x00762D88
		public string CHO9BottomFunctionButtonBCO_A36660_UIValue
		{
			get
			{
				short num = (short)37289985;
				if (num != 0)
				{
				}
				num = (short)650510336;
				short num2 = num;
				num = (short)1018661717;
				short num3 = num;
				num = (short)303926101;
				switch (num3 == num)
				{
				}
				num = (short)748879872;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36660.UIValue;
			}
			set
			{
				short num = (short)947961113;
				short num2 = num;
				num = (short)2020785433;
				switch (num2 == num)
				{
				}
				num = (short)720764929;
				if (num != 0)
				{
				}
				num = (short)2037645312;
				short num3 = num;
				num = (short)1321861120;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonBCO_A36660.UIValue = value;
			}
		}

		// Token: 0x170041D3 RID: 16851
		// (get) Token: 0x060080CF RID: 32975 RVA: 0x00764C3C File Offset: 0x00762E3C
		public global::AcpBusinessLayer.AcpListField CHO9BottomFunctionButtonBCO_A36660
		{
			get
			{
				short num = (short)1071101807;
				short num2 = num;
				num = (short)1452128111;
				switch (num2 == num)
				{
				}
				num = (short)131792897;
				if (num != 0)
				{
				}
				num = (short)599130112;
				short num3 = num;
				num = (short)1777467392;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36660;
			}
		}

		// Token: 0x170041D4 RID: 16852
		// (get) Token: 0x060080D0 RID: 32976 RVA: 0x00764CEC File Offset: 0x00762EEC
		// (set) Token: 0x060080D1 RID: 32977 RVA: 0x00764DA0 File Offset: 0x00762FA0
		public bool CHO9BottomFunctionButtonBCO_A36660_Applicable
		{
			get
			{
				short num = (short)874876810;
				short num2 = num;
				num = (short)1619693450;
				switch (num2 == num)
				{
				}
				num = (short)1209597952;
				if (num != 0)
				{
				}
				num = (short)1339817984;
				short num3 = num;
				num = (short)1279787009;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36660.Applicable;
			}
			set
			{
				short num = (short)1622689960;
				short num2 = num;
				num = (short)1320372392;
				switch (num2 == num)
				{
				}
				num = (short)1830027265;
				if (num != 0)
				{
				}
				num = (short)714145792;
				short num3 = num;
				num = (short)698023936;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonBCO_A36660.Applicable = value;
			}
		}

		// Token: 0x170041D5 RID: 16853
		// (get) Token: 0x060080D2 RID: 32978 RVA: 0x00764E54 File Offset: 0x00763054
		// (set) Token: 0x060080D3 RID: 32979 RVA: 0x00764F08 File Offset: 0x00763108
		public bool CHO9BottomFunctionButtonBCO_A36660_Valid
		{
			get
			{
				short num = (short)574750721;
				if (num != 0)
				{
				}
				num = (short)1896440421;
				short num2 = num;
				num = (short)1078813285;
				switch (num2 == num)
				{
				}
				num = (short)100794368;
				short num3 = num;
				num = (short)2040332288;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36660.Valid;
			}
			set
			{
				short num = (short)328900691;
				short num2 = num;
				num = (short)7512147;
				switch (num2 == num)
				{
				}
				num = (short)1317797889;
				if (num != 0)
				{
				}
				num = (short)1777336320;
				short num3 = num;
				num = (short)1387397120;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonBCO_A36660.Valid = value;
			}
		}

		// Token: 0x170041D6 RID: 16854
		// (get) Token: 0x060080D4 RID: 32980 RVA: 0x00764FC0 File Offset: 0x007631C0
		// (set) Token: 0x060080D5 RID: 32981 RVA: 0x00765074 File Offset: 0x00763274
		public bool CHO9BottomFunctionButtonBCO_A36660_Visible
		{
			get
			{
				short num = (short)1456876766;
				short num2 = num;
				num = (short)35663070;
				switch (num2 == num)
				{
				}
				num = (short)62259201;
				if (num != 0)
				{
				}
				num = (short)490405888;
				short num3 = num;
				num = (short)1016201216;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36660.Visible;
			}
			set
			{
				short num = (short)835709353;
				short num2 = num;
				num = (short)720300457;
				switch (num2 == num)
				{
				}
				num = (short)923729921;
				if (num != 0)
				{
				}
				num = (short)1729167360;
				short num3 = num;
				num = (short)1069875200;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonBCO_A36660.Visible = value;
			}
		}

		// Token: 0x170041D7 RID: 16855
		// (get) Token: 0x060080D6 RID: 32982 RVA: 0x0076512C File Offset: 0x0076332C
		// (set) Token: 0x060080D7 RID: 32983 RVA: 0x007651E4 File Offset: 0x007633E4
		public bool CHO9BottomFunctionButtonBCO_A36660_Editable
		{
			get
			{
				short num = (short)1054712170;
				short num2 = num;
				num = (short)1560519018;
				switch (num2 == num)
				{
				}
				num = (short)1458634752;
				if (num != 0)
				{
				}
				num = (short)713424896;
				short num3 = num;
				num = (short)1736245249;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36660.Editable;
			}
			set
			{
				short num = (short)2097780856;
				short num2 = num;
				num = (short)1801558136;
				switch (num2 == num)
				{
				}
				num = (short)204341249;
				if (num != 0)
				{
				}
				num = (short)1621360640;
				short num3 = num;
				num = (short)517406720;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonBCO_A36660.Editable = value;
			}
		}

		// Token: 0x170041D8 RID: 16856
		// (get) Token: 0x060080D8 RID: 32984 RVA: 0x00765298 File Offset: 0x00763498
		internal string CHO9BottomFunctionButtonBCO_A36660_UILabel
		{
			get
			{
				short num = (short)1289991792;
				short num2 = num;
				num = (short)407025264;
				switch (num2 == num)
				{
				}
				num = (short)1234173953;
				if (num != 0)
				{
				}
				num = (short)1667563520;
				short num3 = num;
				num = (short)1242759168;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36660.UIName;
			}
		}

		// Token: 0x170041D9 RID: 16857
		// (get) Token: 0x060080D9 RID: 32985 RVA: 0x00765350 File Offset: 0x00763550
		// (set) Token: 0x060080DA RID: 32986 RVA: 0x00765404 File Offset: 0x00763604
		internal bool CHO9BottomFunctionButtonBCO_A36660_HiddenStatic
		{
			get
			{
				short num = (short)282723335;
				short num2 = num;
				num = (short)1998914567;
				switch (num2 == num)
				{
				}
				num = (short)1150681089;
				if (num != 0)
				{
				}
				num = (short)1495465984;
				short num3 = num;
				num = (short)904658944;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36660.HiddenStatic;
			}
			set
			{
				short num = (short)989775089;
				short num2 = num;
				num = (short)1890698481;
				switch (num2 == num)
				{
				}
				num = (short)1607598081;
				if (num != 0)
				{
				}
				num = (short)88735744;
				short num3 = num;
				num = (short)12451840;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonBCO_A36660.HiddenStatic = value;
			}
		}

		// Token: 0x170041DA RID: 16858
		// (get) Token: 0x060080DB RID: 32987 RVA: 0x007654BC File Offset: 0x007636BC
		// (set) Token: 0x060080DC RID: 32988 RVA: 0x00765570 File Offset: 0x00763770
		internal bool CHO9BottomFunctionButtonBCO_A36660_HiddenDynamic
		{
			get
			{
				short num = (short)1392409816;
				short num2 = num;
				num = (short)1435532504;
				switch (num2 == num)
				{
				}
				num = (short)2049966081;
				if (num != 0)
				{
				}
				num = (short)403046400;
				short num3 = num;
				num = (short)969080832;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36660.HiddenDynamic;
			}
			set
			{
				short num = (short)1393957991;
				short num2 = num;
				num = (short)2069044327;
				switch (num2 == num)
				{
				}
				num = (short)2084569088;
				if (num != 0)
				{
				}
				num = (short)676593664;
				short num3 = num;
				num = (short)1977614337;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonBCO_A36660.HiddenDynamic = value;
			}
		}

		// Token: 0x170041DB RID: 16859
		// (get) Token: 0x060080DD RID: 32989 RVA: 0x00765628 File Offset: 0x00763828
		public bool CHO9BottomFunctionButtonBCO_A36660_HasDiffs
		{
			get
			{
				short num = (short)1583426171;
				short num2 = num;
				num = (short)351611515;
				switch (num2 == num)
				{
				}
				num = (short)386269184;
				if (num != 0)
				{
				}
				num = (short)2010120192;
				short num3 = num;
				num = (short)439025665;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36660._HasDiffs;
			}
		}

		// Token: 0x170041DC RID: 16860
		// (get) Token: 0x060080DE RID: 32990 RVA: 0x007656D8 File Offset: 0x007638D8
		// (set) Token: 0x060080DF RID: 32991 RVA: 0x00765790 File Offset: 0x00763990
		public int CHO9BottomFunctionButtonIndex_A36665Value
		{
			get
			{
				short num = (short)1311858694;
				short num2 = num;
				num = (short)66281478;
				switch (num2 == num)
				{
				}
				num = (short)1363476481;
				if (num != 0)
				{
				}
				num = (short)172032000;
				short num3 = num;
				num = (short)1985478656;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonIndex_A36665.Value;
			}
			set
			{
				short num = (short)948888521;
				short num2 = num;
				num = (short)1140581321;
				switch (num2 == num)
				{
				}
				num = (short)976617472;
				if (num != 0)
				{
				}
				num = (short)143327232;
				short num3 = num;
				num = (short)1609564161;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonIndex_A36665.Value = value;
			}
		}

		// Token: 0x170041DD RID: 16861
		// (get) Token: 0x060080E0 RID: 32992 RVA: 0x00765844 File Offset: 0x00763A44
		// (set) Token: 0x060080E1 RID: 32993 RVA: 0x007658F8 File Offset: 0x00763AF8
		public string CHO9BottomFunctionButtonIndex_A36665_UIValue
		{
			get
			{
				short num = (short)1396642681;
				short num2 = num;
				num = (short)55579513;
				switch (num2 == num)
				{
				}
				num = (short)1615462401;
				if (num != 0)
				{
				}
				num = (short)329252864;
				short num3 = num;
				num = (short)1757085696;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonIndex_A36665.UIValue;
			}
			set
			{
				short num = (short)2013534629;
				short num2 = num;
				num = (short)1731664293;
				switch (num2 == num)
				{
				}
				num = (short)1977942016;
				if (num != 0)
				{
				}
				num = (short)2025455616;
				short num3 = num;
				num = (short)572391425;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonIndex_A36665.UIValue = value;
			}
		}

		// Token: 0x170041DE RID: 16862
		// (get) Token: 0x060080E2 RID: 32994 RVA: 0x007659AC File Offset: 0x00763BAC
		public global::AcpBusinessLayer.AcpRecRefField CHO9BottomFunctionButtonIndex_A36665
		{
			get
			{
				short num = (short)988623640;
				short num2 = num;
				num = (short)1238577944;
				switch (num2 == num)
				{
				}
				num = (short)48693248;
				if (num != 0)
				{
				}
				num = (short)1197932544;
				short num3 = num;
				num = (short)1588330497;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonIndex_A36665;
			}
		}

		// Token: 0x170041DF RID: 16863
		// (get) Token: 0x060080E3 RID: 32995 RVA: 0x00765A5C File Offset: 0x00763C5C
		// (set) Token: 0x060080E4 RID: 32996 RVA: 0x00765B10 File Offset: 0x00763D10
		public bool CHO9BottomFunctionButtonIndex_A36665_Applicable
		{
			get
			{
				short num = (short)1603027968;
				short num2 = num;
				num = (short)588792832;
				switch (num2 == num)
				{
				}
				num = (short)1668415489;
				if (num != 0)
				{
				}
				num = (short)1793982464;
				short num3 = num;
				num = (short)1079902208;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonIndex_A36665.Applicable;
			}
			set
			{
				short num = (short)790492149;
				short num2 = num;
				num = (short)545387509;
				switch (num2 == num)
				{
				}
				num = (short)2003959808;
				if (num != 0)
				{
				}
				num = (short)355270656;
				short num3 = num;
				num = (short)502595585;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonIndex_A36665.Applicable = value;
			}
		}

		// Token: 0x170041E0 RID: 16864
		// (get) Token: 0x060080E5 RID: 32997 RVA: 0x00765BC4 File Offset: 0x00763DC4
		// (set) Token: 0x060080E6 RID: 32998 RVA: 0x00765C78 File Offset: 0x00763E78
		public bool CHO9BottomFunctionButtonIndex_A36665_Valid
		{
			get
			{
				short num = (short)1060654056;
				short num2 = num;
				num = (short)138890216;
				switch (num2 == num)
				{
				}
				num = (short)2020212737;
				if (num != 0)
				{
				}
				num = (short)1814167552;
				short num3 = num;
				num = (short)996999168;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonIndex_A36665.Valid;
			}
			set
			{
				short num = (short)223715547;
				short num2 = num;
				num = (short)575381723;
				switch (num2 == num)
				{
				}
				num = (short)1747189760;
				if (num != 0)
				{
				}
				num = (short)941228032;
				short num3 = num;
				num = (short)610533377;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonIndex_A36665.Valid = value;
			}
		}

		// Token: 0x170041E1 RID: 16865
		// (get) Token: 0x060080E7 RID: 32999 RVA: 0x00765D30 File Offset: 0x00763F30
		// (set) Token: 0x060080E8 RID: 33000 RVA: 0x00765DE4 File Offset: 0x00763FE4
		public bool CHO9BottomFunctionButtonIndex_A36665_Visible
		{
			get
			{
				short num = (short)2000552710;
				short num2 = num;
				num = (short)347669254;
				switch (num2 == num)
				{
				}
				num = (short)187957249;
				if (num != 0)
				{
				}
				num = (short)378273792;
				short num3 = num;
				num = (short)72286208;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonIndex_A36665.Visible;
			}
			set
			{
				short num = (short)1931724060;
				short num2 = num;
				num = (short)1060488476;
				switch (num2 == num)
				{
				}
				num = (short)1882980353;
				if (num != 0)
				{
				}
				num = (short)231669760;
				short num3 = num;
				num = (short)1220214784;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonIndex_A36665.Visible = value;
			}
		}

		// Token: 0x170041E2 RID: 16866
		// (get) Token: 0x060080E9 RID: 33001 RVA: 0x00765E9C File Offset: 0x0076409C
		// (set) Token: 0x060080EA RID: 33002 RVA: 0x00765F50 File Offset: 0x00764150
		public bool CHO9BottomFunctionButtonIndex_A36665_Editable
		{
			get
			{
				short num = (short)823394305;
				if (num != 0)
				{
				}
				num = (short)1161893967;
				short num2 = num;
				num = (short)1067325519;
				switch (num2 == num)
				{
				}
				num = (short)2144927744;
				short num3 = num;
				num = (short)1917911040;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonIndex_A36665.Editable;
			}
			set
			{
				short num = (short)1261487182;
				short num2 = num;
				num = (short)2072822862;
				switch (num2 == num)
				{
				}
				num = (short)1916469248;
				if (num != 0)
				{
				}
				num = (short)143982592;
				short num3 = num;
				num = (short)137232385;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonIndex_A36665.Editable = value;
			}
		}

		// Token: 0x170041E3 RID: 16867
		// (get) Token: 0x060080EB RID: 33003 RVA: 0x00766008 File Offset: 0x00764208
		internal string CHO9BottomFunctionButtonIndex_A36665_UILabel
		{
			get
			{
				short num = (short)1415300998;
				short num2 = num;
				num = (short)409323398;
				switch (num2 == num)
				{
				}
				num = (short)1951924225;
				if (num != 0)
				{
				}
				num = (short)515440640;
				short num3 = num;
				num = (short)1366949888;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonIndex_A36665.UIName;
			}
		}

		// Token: 0x170041E4 RID: 16868
		// (get) Token: 0x060080EC RID: 33004 RVA: 0x007660BC File Offset: 0x007642BC
		// (set) Token: 0x060080ED RID: 33005 RVA: 0x00766170 File Offset: 0x00764370
		internal bool CHO9BottomFunctionButtonIndex_A36665_HiddenStatic
		{
			get
			{
				short num = (short)103410117;
				short num2 = num;
				num = (short)1853024709;
				switch (num2 == num)
				{
				}
				num = (short)1173880833;
				if (num != 0)
				{
				}
				num = (short)2055143424;
				short num3 = num;
				num = (short)1066205184;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonIndex_A36665.HiddenStatic;
			}
			set
			{
				short num = (short)978379855;
				short num2 = num;
				num = (short)1029497935;
				switch (num2 == num)
				{
				}
				num = (short)469696513;
				if (num != 0)
				{
				}
				num = (short)1169752064;
				short num3 = num;
				num = (short)477822976;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonIndex_A36665.HiddenStatic = value;
			}
		}

		// Token: 0x170041E5 RID: 16869
		// (get) Token: 0x060080EE RID: 33006 RVA: 0x00766224 File Offset: 0x00764424
		// (set) Token: 0x060080EF RID: 33007 RVA: 0x007662D8 File Offset: 0x007644D8
		internal bool CHO9BottomFunctionButtonIndex_A36665_HiddenDynamic
		{
			get
			{
				short num = (short)185427761;
				short num2 = num;
				num = (short)1720739633;
				switch (num2 == num)
				{
				}
				num = (short)717946881;
				if (num != 0)
				{
				}
				num = (short)123863040;
				short num3 = num;
				num = (short)843448320;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonIndex_A36665.HiddenDynamic;
			}
			set
			{
				short num = (short)1182899109;
				short num2 = num;
				num = (short)839228325;
				switch (num2 == num)
				{
				}
				num = (short)164298752;
				if (num != 0)
				{
				}
				num = (short)675217408;
				short num3 = num;
				num = (short)1965424641;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonIndex_A36665.HiddenDynamic = value;
			}
		}

		// Token: 0x170041E6 RID: 16870
		// (get) Token: 0x060080F0 RID: 33008 RVA: 0x0076638C File Offset: 0x0076458C
		public bool CHO9BottomFunctionButtonIndex_A36665_HasDiffs
		{
			get
			{
				short num = (short)61993411;
				short num2 = num;
				num = (short)400486851;
				switch (num2 == num)
				{
				}
				num = (short)633012224;
				if (num != 0)
				{
				}
				num = (short)153026560;
				short num3 = num;
				num = (short)577568769;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonIndex_A36665._HasDiffs;
			}
		}

		// Token: 0x170041E7 RID: 16871
		// (get) Token: 0x060080F1 RID: 33009 RVA: 0x00766440 File Offset: 0x00764640
		// (set) Token: 0x060080F2 RID: 33010 RVA: 0x007664F4 File Offset: 0x007646F4
		public int CHO9BottomFunctionButtonFeature_A36664Value
		{
			get
			{
				short num = (short)751025556;
				short num2 = num;
				num = (short)496549268;
				switch (num2 == num)
				{
				}
				num = (short)634650625;
				if (num != 0)
				{
				}
				num = (short)1639186432;
				short num3 = num;
				num = (short)1074724864;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36664.Value;
			}
			set
			{
				short num = (short)999358465;
				if (num != 0)
				{
				}
				num = (short)568498113;
				short num2 = num;
				num = (short)1283561409;
				switch (num2 == num)
				{
				}
				num = (short)704774144;
				short num3 = num;
				num = (short)1194655744;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonFeature_A36664.Value = value;
			}
		}

		// Token: 0x170041E8 RID: 16872
		// (get) Token: 0x060080F3 RID: 33011 RVA: 0x007665AC File Offset: 0x007647AC
		// (set) Token: 0x060080F4 RID: 33012 RVA: 0x00766660 File Offset: 0x00764860
		public string CHO9BottomFunctionButtonFeature_A36664_UIValue
		{
			get
			{
				short num = (short)35901326;
				short num2 = num;
				num = (short)465948558;
				switch (num2 == num)
				{
				}
				num = (short)1425670145;
				if (num != 0)
				{
				}
				num = (short)72155136;
				short num3 = num;
				num = (short)1099366400;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36664.UIValue;
			}
			set
			{
				short num = (short)1120125378;
				short num2 = num;
				num = (short)446022082;
				switch (num2 == num)
				{
				}
				num = (short)203358209;
				if (num != 0)
				{
				}
				num = (short)1839988736;
				short num3 = num;
				num = (short)1277100032;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonFeature_A36664.UIValue = value;
			}
		}

		// Token: 0x170041E9 RID: 16873
		// (get) Token: 0x060080F5 RID: 33013 RVA: 0x00766718 File Offset: 0x00764918
		public global::AcpBusinessLayer.AcpListField CHO9BottomFunctionButtonFeature_A36664
		{
			get
			{
				short num = (short)691035964;
				short num2 = num;
				num = (short)129589052;
				switch (num2 == num)
				{
				}
				num = (short)962330625;
				if (num != 0)
				{
				}
				num = (short)917045248;
				short num3 = num;
				num = (short)1846935552;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36664;
			}
		}

		// Token: 0x170041EA RID: 16874
		// (get) Token: 0x060080F6 RID: 33014 RVA: 0x007667C8 File Offset: 0x007649C8
		// (set) Token: 0x060080F7 RID: 33015 RVA: 0x0076687C File Offset: 0x00764A7C
		public bool CHO9BottomFunctionButtonFeature_A36664_Applicable
		{
			get
			{
				short num = (short)1187383509;
				short num2 = num;
				num = (short)336201941;
				switch (num2 == num)
				{
				}
				num = (short)1586954241;
				if (num != 0)
				{
				}
				num = (short)1058930688;
				short num3 = num;
				num = (short)388628480;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36664.Applicable;
			}
			set
			{
				short num = (short)1412548934;
				short num2 = num;
				num = (short)1166330182;
				switch (num2 == num)
				{
				}
				num = (short)1242038273;
				if (num != 0)
				{
				}
				num = (short)885260288;
				short num3 = num;
				num = (short)1658912768;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonFeature_A36664.Applicable = value;
			}
		}

		// Token: 0x170041EB RID: 16875
		// (get) Token: 0x060080F8 RID: 33016 RVA: 0x00766930 File Offset: 0x00764B30
		// (set) Token: 0x060080F9 RID: 33017 RVA: 0x007669E4 File Offset: 0x00764BE4
		public bool CHO9BottomFunctionButtonFeature_A36664_Valid
		{
			get
			{
				short num = (short)2029951295;
				short num2 = num;
				num = (short)1041865023;
				switch (num2 == num)
				{
				}
				num = (short)1269301248;
				if (num != 0)
				{
				}
				num = (short)2103574528;
				short num3 = num;
				num = (short)1776353281;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36664.Valid;
			}
			set
			{
				short num = (short)841118803;
				short num2 = num;
				num = (short)1428976723;
				switch (num2 == num)
				{
				}
				num = (short)253034497;
				if (num != 0)
				{
				}
				num = (short)2009268224;
				short num3 = num;
				num = (short)764870656;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonFeature_A36664.Valid = value;
			}
		}

		// Token: 0x170041EC RID: 16876
		// (get) Token: 0x060080FA RID: 33018 RVA: 0x00766A98 File Offset: 0x00764C98
		// (set) Token: 0x060080FB RID: 33019 RVA: 0x00766B4C File Offset: 0x00764D4C
		public bool CHO9BottomFunctionButtonFeature_A36664_Visible
		{
			get
			{
				short num = (short)280280911;
				short num2 = num;
				num = (short)1449705295;
				switch (num2 == num)
				{
				}
				num = (short)2038431745;
				if (num != 0)
				{
				}
				num = (short)1244332032;
				short num3 = num;
				num = (short)1289224192;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36664.Visible;
			}
			set
			{
				short num = (short)692897338;
				short num2 = num;
				num = (short)1817495098;
				switch (num2 == num)
				{
				}
				num = (short)2022899713;
				if (num != 0)
				{
				}
				num = (short)874184704;
				short num3 = num;
				num = (short)553385984;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonFeature_A36664.Visible = value;
			}
		}

		// Token: 0x170041ED RID: 16877
		// (get) Token: 0x060080FC RID: 33020 RVA: 0x00766C04 File Offset: 0x00764E04
		// (set) Token: 0x060080FD RID: 33021 RVA: 0x00766CBC File Offset: 0x00764EBC
		public bool CHO9BottomFunctionButtonFeature_A36664_Editable
		{
			get
			{
				short num = (short)257163265;
				if (num != 0)
				{
				}
				num = (short)34454585;
				short num2 = num;
				num = (short)905886777;
				switch (num2 == num)
				{
				}
				num = (short)1595408384;
				short num3 = num;
				num = (short)461766656;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36664.Editable;
			}
			set
			{
				short num = (short)1632779513;
				short num2 = num;
				num = (short)1072905465;
				switch (num2 == num)
				{
				}
				num = (short)945029121;
				if (num != 0)
				{
				}
				num = (short)1268776960;
				short num3 = num;
				num = (short)1801715712;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonFeature_A36664.Editable = value;
			}
		}

		// Token: 0x170041EE RID: 16878
		// (get) Token: 0x060080FE RID: 33022 RVA: 0x00766D6C File Offset: 0x00764F6C
		internal string CHO9BottomFunctionButtonFeature_A36664_UILabel
		{
			get
			{
				short num = (short)299311689;
				short num2 = num;
				num = (short)1617633865;
				switch (num2 == num)
				{
				}
				num = (short)1661337600;
				if (num != 0)
				{
				}
				num = (short)655097856;
				short num3 = num;
				num = (short)1496121345;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36664.UIName;
			}
		}

		// Token: 0x170041EF RID: 16879
		// (get) Token: 0x060080FF RID: 33023 RVA: 0x00766E20 File Offset: 0x00765020
		// (set) Token: 0x06008100 RID: 33024 RVA: 0x00766ED4 File Offset: 0x007650D4
		internal bool CHO9BottomFunctionButtonFeature_A36664_HiddenStatic
		{
			get
			{
				short num = (short)31160826;
				short num2 = num;
				num = (short)1843755514;
				switch (num2 == num)
				{
				}
				num = (short)455933953;
				if (num != 0)
				{
				}
				num = (short)1028456448;
				short num3 = num;
				num = (short)890306560;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36664.HiddenStatic;
			}
			set
			{
				short num = (short)280705545;
				short num2 = num;
				num = (short)185743881;
				switch (num2 == num)
				{
				}
				num = (short)1463222272;
				if (num != 0)
				{
				}
				num = (short)1672085504;
				short num3 = num;
				num = (short)2039676929;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonFeature_A36664.HiddenStatic = value;
			}
		}

		// Token: 0x170041F0 RID: 16880
		// (get) Token: 0x06008101 RID: 33025 RVA: 0x00766F88 File Offset: 0x00765188
		// (set) Token: 0x06008102 RID: 33026 RVA: 0x00767040 File Offset: 0x00765240
		internal bool CHO9BottomFunctionButtonFeature_A36664_HiddenDynamic
		{
			get
			{
				short num = (short)2094368945;
				short num2 = num;
				num = (short)1623623857;
				switch (num2 == num)
				{
				}
				num = (short)829358081;
				if (num != 0)
				{
				}
				num = (short)811008000;
				short num3 = num;
				num = (short)1977090048;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36664.HiddenDynamic;
			}
			set
			{
				short num = (short)1851167955;
				short num2 = num;
				num = (short)868652243;
				switch (num2 == num)
				{
				}
				num = (short)1970470913;
				if (num != 0)
				{
				}
				num = (short)2137063424;
				short num3 = num;
				num = (short)1006108672;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonFeature_A36664.HiddenDynamic = value;
			}
		}

		// Token: 0x170041F1 RID: 16881
		// (get) Token: 0x06008103 RID: 33027 RVA: 0x007670F4 File Offset: 0x007652F4
		public bool CHO9BottomFunctionButtonFeature_A36664_HasDiffs
		{
			get
			{
				short num = (short)941801435;
				short num2 = num;
				num = (short)1931919323;
				switch (num2 == num)
				{
				}
				num = (short)1695285248;
				if (num != 0)
				{
				}
				num = (short)892207104;
				short num3 = num;
				num = (short)986054657;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36664._HasDiffs;
			}
		}

		// Token: 0x170041F2 RID: 16882
		// (get) Token: 0x06008104 RID: 33028 RVA: 0x007671A8 File Offset: 0x007653A8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1806719037;
				short num2 = num;
				num = (short)492722237;
				switch (num2 == num)
				{
				}
				num = (short)1462632449;
				if (num != 0)
				{
				}
				num = (short)205389824;
				short num3 = num;
				num = (short)490405888;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x170041F3 RID: 16883
		// (get) Token: 0x06008105 RID: 33029 RVA: 0x00767268 File Offset: 0x00765468
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)624261400;
				short num2 = num;
				num = (short)211253528;
				switch (num2 == num)
				{
				}
				num = (short)433717249;
				if (num != 0)
				{
				}
				num = (short)292159488;
				short num3 = num;
				num = (short)289079296;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x06008106 RID: 33030 RVA: 0x00767328 File Offset: 0x00765528
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
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)1367277568;
					short num3 = num2;
					num2 = (short)831832954;
					short num4 = num2;
					num2 = (short)1160627066;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5A;
					default:
						num2 = (short)830603264;
						if (num2 != 0)
						{
						}
						num2 = (short)925171715;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_82;
				case 2:
					goto IL_5A;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)853671937;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)251461634;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_5A:
				num2 = (short)320012288;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_82:
			num2 = (short)571408385;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)21626884;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040039CA RID: 14794
		private global::AcpBusinessLayer.AcpField<string> cHO9BottomFunctionButtonName_A36657;

		// Token: 0x040039CB RID: 14795
		private global::AcpBusinessLayer.AcpListField cHO9BottomFunctionButtonBCO_A36660;

		// Token: 0x040039CC RID: 14796
		private global::AcpBusinessLayer.AcpRecRefField cHO9BottomFunctionButtonIndex_A36665;

		// Token: 0x040039CD RID: 14797
		private global::AcpBusinessLayer.AcpListField cHO9BottomFunctionButtonFeature_A36664;
	}
}
