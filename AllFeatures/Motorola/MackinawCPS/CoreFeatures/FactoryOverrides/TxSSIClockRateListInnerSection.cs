using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000469 RID: 1129
	[global::System.Serializable]
	public class TxSSIClockRateListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009566 RID: 38246 RVA: 0x008C73F4 File Offset: 0x008C55F4
		public TxSSIClockRateListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06009567 RID: 38247 RVA: 0x008C7410 File Offset: 0x008C5610
		protected TxSSIClockRateListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009568 RID: 38248 RVA: 0x008C7428 File Offset: 0x008C5628
		public override void Init()
		{
			int a_ = 9;
			short num = (short)1657143296;
			short num2 = num;
			num = (short)1426720538;
			short num3 = num;
			num = (short)1984628506;
			switch (num3 == num)
			{
			}
			num = (short)2024996865;
			if (num != 0)
			{
			}
			num = (short)840957952;
			if (num != 0)
			{
			}
			this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("賉꿋뫍鿏ꃑ냓ꗕ賗ꋙ进距꧟ꇡ裣觥诧臩뻫迭蓯韱룳鿵请軹ꣻ蛽䛿瀁愃眅紇漉戋洍椏弑尓氕䜗嬙⼛⠝ᔟᔡጣ", a_), global::CommonResources.AcgResources.ID_TXFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.DataTransferOrder = 200;
			this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.LOVs.indexFctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578LovStrs, global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.LOVs.idFctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578LovStrs), this, global::AllFeatures.CodeplugGuid.b("賉꿋뫍鿏ꃑ냓ꗕ賗ꋙ进距꧟ꇡ裣觥诧臩뻫迭蓯韱룳鿵请軹ꣻ蛽叿儁䴃䔅搇攉漋攍䈏猑怓猕唗则昛䄝感ᄡሣጥἧሩ", a_), global::CommonResources.AcgResources.ID_TXSSICLOCKRATEMHZ, global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.LOVs.FctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578LovStrs);
			this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.DataTransferOrder = 201;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("黉듋菏臑鷓鯗뛙돛뷝诟싡뛣蟥鳧迩쳫ꋭ駯臱胳", a_);
			base.Id = 10613;
			base.UIName = global::CommonResources.AcgResources.ID_TXSSICLOCKRATELIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06009569 RID: 38249 RVA: 0x008C75A0 File Offset: 0x008C57A0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 6;
			short num = (short)1856176130;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1090584576;
				short num3 = num;
				switch (num2)
				{
				case 0:
					num = (short)617742339;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臆꫈뿊苌뷎뗐ꃒ臔꿖諘裚铜鳞跠賢蛤賦믨諪駬諮뷰髲蛴菶그菺껼곾䠀䀂椄栆樈怊弌渎攐瘒堔弖挘䐚尜Ⱎᜠᘢሤἦ", a_)))
					{
						num = (short)190316553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B2;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_80;
					}
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臆꫈뿊苌뷎뗐ꃒ臔꿖諘裚铜鳞跠賢蛤賦믨諪駬諮뷰髲蛴菶그菺민跾搀爂瀄戆月栊琌䈎夐椒䨔嘖⨘ⴚ⠜⠞ᘠ", a_)))
					{
						num = (short)1457913860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A3;
				case 4:
					this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("臆꫈뿊苌뷎뗐ꃒ臔꿖諘裚铜鳞跠賢蛤賦믨諪駬諮뷰髲蛴菶그菺민跾搀爂瀄戆月栊琌䈎夐椒䨔嘖⨘ⴚ⠜⠞ᘠ", a_), global::CommonResources.AcgResources.ID_TXFREQUENCYMHZ);
					this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.DataTransferOrder = 200;
					goto IL_131;
				case 5:
					num = (short)2096300039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)1597994802;
					short num4 = num;
					num = (short)1059682098;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_131;
					default:
						goto IL_24D;
					}
					break;
				}
				case 7:
					if (producerFields != null)
					{
						num = (short)2056192000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B2;
				case 8:
					goto IL_A3;
				case 9:
					this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.LOVs.indexFctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578LovStrs, global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.LOVs.idFctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578LovStrs), this, global::AllFeatures.CodeplugGuid.b("臆꫈뿊苌뷎뗐ꃒ臔꿖諘裚铜鳞跠賢蛤賦믨諪駬諮뷰髲蛴菶그菺껼곾䠀䀂椄栆樈怊弌渎攐瘒堔弖挘䐚尜Ⱎᜠᘢሤἦ", a_), global::CommonResources.AcgResources.ID_TXSSICLOCKRATEMHZ, global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.LOVs.FctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578LovStrs);
					this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.DataTransferOrder = 201;
					num = (short)1207173121;
					if (num != 0)
					{
					}
					num = (short)1215758342;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_80:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)534839301;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2B2;
				IL_A3:
				num = (short)1324679169;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_131:
				num = (short)624951304;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_24D:
			num = (short)313655296;
			if (num != 0)
			{
			}
			IL_2B2:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏆뇈黌鳎飐雔믖뛘룚뛜￞돠苢釤苦짨꟪蓬鳮藰", a_);
			base.Id = 10613;
			base.UIName = global::CommonResources.AcgResources.ID_TXSSICLOCKRATELIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600956A RID: 38250 RVA: 0x008C7890 File Offset: 0x008C5A90
		public override void PopulateReferences()
		{
			short num = (short)1727397888;
			short num2 = num;
			num = (short)1254006634;
			short num3 = num;
			num = (short)1447599978;
			switch (num3 == num)
			{
			}
			num = (short)155320321;
			if (num != 0)
			{
			}
			num = (short)121831424;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600956B RID: 38251 RVA: 0x008C793C File Offset: 0x008C5B3C
		public override void DropReferences()
		{
			short num = (short)395771904;
			short num2 = num;
			num = (short)454569205;
			short num3 = num;
			num = (short)662514933;
			switch (num3 == num)
			{
			}
			num = (short)549322753;
			if (num != 0)
			{
			}
			num = (short)923402240;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600956C RID: 38252 RVA: 0x008C79E4 File Offset: 0x008C5BE4
		public override void SetConstraints()
		{
			short num = (short)467992576;
			short num2 = num;
			num = (short)569831945;
			short num3 = num;
			num = (short)2120348169;
			switch (num3 == num)
			{
			}
			num = (short)1556480001;
			if (num != 0)
			{
			}
			num = (short)994639872;
			if (num != 0)
			{
			}
			this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesConstraints.ConFactoryOverridesEnableIsChecked);
			this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesConstraints.ConFacOvrrdTxSSITxFreqMHzIsValid);
			this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesConstraints.ConFactoryOverridesEnableIsChecked);
		}

		// Token: 0x0600956D RID: 38253 RVA: 0x008C7AD0 File Offset: 0x008C5CD0
		public override void SetupDependencies()
		{
			short num = (short)1083899904;
			short num2 = num;
			num = (short)550626350;
			short num3 = num;
			num = (short)792323118;
			switch (num3 == num)
			{
			}
			num = (short)1334575105;
			if (num != 0)
			{
			}
			num = (short)444727296;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverrides factoryOverrides = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverrides;
			factoryOverrides.General.RadWideAdvancedFactoryOverrides_A8004.AddDependentObject(this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577);
			factoryOverrides.General.RadWideAdvancedFactoryOverrides_A8004.AddDependentObject(this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578);
		}

		// Token: 0x17004B15 RID: 19221
		// (get) Token: 0x0600956E RID: 38254 RVA: 0x008C7BD8 File Offset: 0x008C5DD8
		public bool HasDiffs
		{
			get
			{
				short num = (short)919928832;
				short num2 = num;
				num = (short)1567870408;
				short num3 = num;
				num = (short)774491592;
				switch (num3 == num)
				{
				}
				num = (short)1682046976;
				if (num != 0)
				{
				}
				num = (short)485359617;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004B16 RID: 19222
		// (get) Token: 0x0600956F RID: 38255 RVA: 0x008C7C88 File Offset: 0x008C5E88
		// (set) Token: 0x06009570 RID: 38256 RVA: 0x008C7D3C File Offset: 0x008C5F3C
		public int FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577Value
		{
			get
			{
				short num = (short)36634624;
				short num2 = num;
				num = (short)1714946116;
				short num3 = num;
				num = (short)691929156;
				switch (num3 == num)
				{
				}
				num = (short)306249729;
				if (num != 0)
				{
				}
				num = (short)942145536;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.Value;
			}
			set
			{
				short num = (short)828440576;
				short num2 = num;
				num = (short)293959737;
				short num3 = num;
				num = (short)664238137;
				switch (num3 == num)
				{
				}
				num = (short)184090624;
				if (num != 0)
				{
				}
				num = (short)190185473;
				if (num != 0)
				{
				}
				this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.Value = value;
			}
		}

		// Token: 0x17004B17 RID: 19223
		// (get) Token: 0x06009571 RID: 38257 RVA: 0x008C7DF0 File Offset: 0x008C5FF0
		// (set) Token: 0x06009572 RID: 38258 RVA: 0x008C7EA4 File Offset: 0x008C60A4
		public string FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577_UIValue
		{
			get
			{
				short num = (short)1857814528;
				short num2 = num;
				num = (short)1888002860;
				short num3 = num;
				num = (short)351445804;
				switch (num3 == num)
				{
				}
				num = (short)201392129;
				if (num != 0)
				{
				}
				num = (short)1598881792;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.UIValue;
			}
			set
			{
				short num = (short)2114519040;
				short num2 = num;
				num = (short)887656283;
				short num3 = num;
				num = (short)2074054491;
				switch (num3 == num)
				{
				}
				num = (short)1189740545;
				if (num != 0)
				{
				}
				num = (short)19398656;
				if (num != 0)
				{
				}
				this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.UIValue = value;
			}
		}

		// Token: 0x17004B18 RID: 19224
		// (get) Token: 0x06009573 RID: 38259 RVA: 0x008C7F58 File Offset: 0x008C6158
		public global::AcpBusinessLayer.AcpFrequencyField FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577
		{
			get
			{
				short num = (short)1223229440;
				short num2 = num;
				num = (short)288962239;
				short num3 = num;
				num = (short)1385445055;
				switch (num3 == num)
				{
				}
				num = (short)424804353;
				if (num != 0)
				{
				}
				num = (short)770048000;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577;
			}
		}

		// Token: 0x17004B19 RID: 19225
		// (get) Token: 0x06009574 RID: 38260 RVA: 0x008C8008 File Offset: 0x008C6208
		// (set) Token: 0x06009575 RID: 38261 RVA: 0x008C80BC File Offset: 0x008C62BC
		internal int FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577Min
		{
			get
			{
				short num = (short)2026373120;
				short num2 = num;
				num = (short)1627956327;
				short num3 = num;
				num = (short)1892787303;
				switch (num3 == num)
				{
				}
				num = (short)50593792;
				if (num != 0)
				{
				}
				num = (short)251592705;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.Min;
			}
			set
			{
				short num = (short)877330432;
				short num2 = num;
				num = (short)151473322;
				short num3 = num;
				num = (short)1244810410;
				switch (num3 == num)
				{
				}
				num = (short)676986881;
				if (num != 0)
				{
				}
				num = (short)568983552;
				if (num != 0)
				{
				}
				this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.Min = value;
			}
		}

		// Token: 0x17004B1A RID: 19226
		// (get) Token: 0x06009576 RID: 38262 RVA: 0x008C8174 File Offset: 0x008C6374
		// (set) Token: 0x06009577 RID: 38263 RVA: 0x008C8228 File Offset: 0x008C6428
		internal int FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577Max
		{
			get
			{
				short num = (short)1109393408;
				short num2 = num;
				num = (short)1568249154;
				short num3 = num;
				num = (short)1223923010;
				switch (num3 == num)
				{
				}
				num = (short)407764993;
				if (num != 0)
				{
				}
				num = (short)1324417024;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.Max;
			}
			set
			{
				short num = (short)751671455;
				short num2 = num;
				num = (short)631412895;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1333985280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1192361985;
				if (num != 0)
				{
				}
				num = (short)1315110912;
				if (num != 0)
				{
				}
				this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.Max = value;
			}
		}

		// Token: 0x17004B1B RID: 19227
		// (get) Token: 0x06009578 RID: 38264 RVA: 0x008C82E0 File Offset: 0x008C64E0
		// (set) Token: 0x06009579 RID: 38265 RVA: 0x008C8398 File Offset: 0x008C6598
		internal int FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577Step
		{
			get
			{
				short num = (short)33145072;
				short num2 = num;
				num = (short)81248496;
				switch (num2 == num)
				{
				default:
				{
					num = (short)868810752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)195100673;
				if (num != 0)
				{
				}
				num = (short)272957440;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.StepSize;
			}
			set
			{
				short num = (short)579854144;
				short num2 = num;
				num = (short)1466163008;
				switch (num2 == num)
				{
				default:
				{
					num = (short)896729088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1039532032;
				if (num != 0)
				{
				}
				num = (short)1679097857;
				if (num != 0)
				{
				}
				this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.StepSize = value;
			}
		}

		// Token: 0x17004B1C RID: 19228
		// (get) Token: 0x0600957A RID: 38266 RVA: 0x008C8450 File Offset: 0x008C6650
		// (set) Token: 0x0600957B RID: 38267 RVA: 0x008C8508 File Offset: 0x008C6708
		public bool FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577_Applicable
		{
			get
			{
				short num = (short)1361622611;
				short num2 = num;
				num = (short)579450451;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1906769920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)348848128;
				if (num != 0)
				{
				}
				num = (short)1858600961;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.Applicable;
			}
			set
			{
				short num = (short)19121292;
				short num2 = num;
				num = (short)1317454988;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2111504384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2100559873;
				if (num != 0)
				{
				}
				num = (short)1153695744;
				if (num != 0)
				{
				}
				this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.Applicable = value;
			}
		}

		// Token: 0x17004B1D RID: 19229
		// (get) Token: 0x0600957C RID: 38268 RVA: 0x008C85BC File Offset: 0x008C67BC
		// (set) Token: 0x0600957D RID: 38269 RVA: 0x008C8670 File Offset: 0x008C6870
		public bool FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577_Valid
		{
			get
			{
				short num = (short)629840532;
				short num2 = num;
				num = (short)1044290196;
				switch (num2 == num)
				{
				default:
				{
					num = (short)365559808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)474284032;
				if (num != 0)
				{
				}
				num = (short)1147469825;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.Valid;
			}
			set
			{
				short num = (short)1810018552;
				short num2 = num;
				num = (short)1238413560;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1783758848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1869217793;
				if (num != 0)
				{
				}
				num = (short)1822949376;
				if (num != 0)
				{
				}
				this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.Valid = value;
			}
		}

		// Token: 0x17004B1E RID: 19230
		// (get) Token: 0x0600957E RID: 38270 RVA: 0x008C8724 File Offset: 0x008C6924
		// (set) Token: 0x0600957F RID: 38271 RVA: 0x008C87D8 File Offset: 0x008C69D8
		public bool FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577_Visible
		{
			get
			{
				short num = (short)1147452354;
				short num2 = num;
				num = (short)63093698;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1790640128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1381826560;
				if (num != 0)
				{
				}
				num = (short)852951041;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.Visible;
			}
			set
			{
				short num = (short)1505411056;
				short num2 = num;
				num = (short)253738992;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1602289664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1405026305;
				if (num != 0)
				{
				}
				num = (short)2041577472;
				if (num != 0)
				{
				}
				this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.Visible = value;
			}
		}

		// Token: 0x17004B1F RID: 19231
		// (get) Token: 0x06009580 RID: 38272 RVA: 0x008C888C File Offset: 0x008C6A8C
		// (set) Token: 0x06009581 RID: 38273 RVA: 0x008C8944 File Offset: 0x008C6B44
		public bool FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577_Editable
		{
			get
			{
				short num = (short)1407920159;
				short num2 = num;
				num = (short)943335455;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1754923008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)686948352;
				if (num != 0)
				{
				}
				num = (short)1225719809;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.Editable;
			}
			set
			{
				short num = (short)496369665;
				if (num != 0)
				{
				}
				num = (short)1483014144;
				short num2 = num;
				num = (short)1013442672;
				short num3 = num;
				num = (short)175106160;
				switch (num3 == num)
				{
				}
				num = (short)2082996224;
				if (num != 0)
				{
				}
				this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.Editable = value;
			}
		}

		// Token: 0x17004B20 RID: 19232
		// (get) Token: 0x06009582 RID: 38274 RVA: 0x008C89FC File Offset: 0x008C6BFC
		internal string FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577_UILabel
		{
			get
			{
				short num = (short)1507774687;
				short num2 = num;
				num = (short)1418121439;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1816133632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)895418369;
				if (num != 0)
				{
				}
				num = (short)387645440;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.UIName;
			}
		}

		// Token: 0x17004B21 RID: 19233
		// (get) Token: 0x06009583 RID: 38275 RVA: 0x008C8AB4 File Offset: 0x008C6CB4
		// (set) Token: 0x06009584 RID: 38276 RVA: 0x008C8B68 File Offset: 0x008C6D68
		internal bool FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577_HiddenStatic
		{
			get
			{
				short num = (short)793538032;
				short num2 = num;
				num = (short)236940784;
				switch (num2 == num)
				{
				default:
				{
					num = (short)153026560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)210108416;
				if (num != 0)
				{
				}
				num = (short)855572481;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.HiddenStatic;
			}
			set
			{
				short num = (short)1076421322;
				short num2 = num;
				num = (short)804250314;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1254621184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1997209601;
				if (num != 0)
				{
				}
				num = (short)1693384704;
				if (num != 0)
				{
				}
				this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.HiddenStatic = value;
			}
		}

		// Token: 0x17004B22 RID: 19234
		// (get) Token: 0x06009585 RID: 38277 RVA: 0x008C8C1C File Offset: 0x008C6E1C
		// (set) Token: 0x06009586 RID: 38278 RVA: 0x008C8CD0 File Offset: 0x008C6ED0
		internal bool FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577_HiddenDynamic
		{
			get
			{
				short num = (short)1206240773;
				short num2 = num;
				num = (short)361219589;
				switch (num2 == num)
				{
				default:
				{
					num = (short)324665344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)502333440;
				if (num != 0)
				{
				}
				num = (short)637534209;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.HiddenDynamic;
			}
			set
			{
				short num = (short)1744940337;
				short num2 = num;
				num = (short)278310193;
				switch (num2 == num)
				{
				default:
				{
					num = (short)89915392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2109472768;
				if (num != 0)
				{
				}
				num = (short)2131492865;
				if (num != 0)
				{
				}
				this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.HiddenDynamic = value;
			}
		}

		// Token: 0x17004B23 RID: 19235
		// (get) Token: 0x06009587 RID: 38279 RVA: 0x008C8D84 File Offset: 0x008C6F84
		public bool FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577_HasDiffs
		{
			get
			{
				short num = (short)1263684470;
				short num2 = num;
				num = (short)1657883510;
				switch (num2 == num)
				{
				default:
				{
					num = (short)765132800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1163657217;
				if (num != 0)
				{
				}
				num = (short)1641021440;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577._HasDiffs;
			}
		}

		// Token: 0x17004B24 RID: 19236
		// (get) Token: 0x06009588 RID: 38280 RVA: 0x008C8E38 File Offset: 0x008C7038
		// (set) Token: 0x06009589 RID: 38281 RVA: 0x008C8EEC File Offset: 0x008C70EC
		public int FctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578Value
		{
			get
			{
				short num = (short)755790092;
				short num2 = num;
				num = (short)1566929164;
				switch (num2 == num)
				{
				default:
				{
					num = (short)575143936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1548222465;
				if (num != 0)
				{
				}
				num = (short)71761920;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.Value;
			}
			set
			{
				short num = (short)666370049;
				if (num != 0)
				{
				}
				num = (short)1295581184;
				short num2 = num;
				num = (short)330362201;
				short num3 = num;
				num = (short)1594420569;
				switch (num3 == num)
				{
				}
				num = (short)1904017408;
				if (num != 0)
				{
				}
				this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.Value = value;
			}
		}

		// Token: 0x17004B25 RID: 19237
		// (get) Token: 0x0600958A RID: 38282 RVA: 0x008C8FA4 File Offset: 0x008C71A4
		// (set) Token: 0x0600958B RID: 38283 RVA: 0x008C9058 File Offset: 0x008C7258
		public string FctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578_UIValue
		{
			get
			{
				short num = (short)2037710357;
				short num2 = num;
				num = (short)1718681109;
				switch (num2 == num)
				{
				default:
				{
					num = (short)58523648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)343080960;
				if (num != 0)
				{
				}
				num = (short)1652686849;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.UIValue;
			}
			set
			{
				short num = (short)1539495854;
				short num2 = num;
				num = (short)1613420462;
				switch (num2 == num)
				{
				default:
				{
					num = (short)861143040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)170262529;
				if (num != 0)
				{
				}
				num = (short)908460032;
				if (num != 0)
				{
				}
				this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.UIValue = value;
			}
		}

		// Token: 0x17004B26 RID: 19238
		// (get) Token: 0x0600958C RID: 38284 RVA: 0x008C910C File Offset: 0x008C730C
		public global::AcpBusinessLayer.AcpListField FctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578
		{
			get
			{
				short num = (short)388221731;
				short num2 = num;
				num = (short)788646691;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1175715840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1087963136;
				if (num != 0)
				{
				}
				num = (short)1912733697;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578;
			}
		}

		// Token: 0x17004B27 RID: 19239
		// (get) Token: 0x0600958D RID: 38285 RVA: 0x008C91C0 File Offset: 0x008C73C0
		// (set) Token: 0x0600958E RID: 38286 RVA: 0x008C9274 File Offset: 0x008C7474
		public bool FctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578_Applicable
		{
			get
			{
				short num = (short)1788304269;
				short num2 = num;
				num = (short)1485069197;
				switch (num2 == num)
				{
				default:
				{
					num = (short)96141312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1788018689;
				if (num != 0)
				{
				}
				num = (short)1528233984;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.Applicable;
			}
			set
			{
				short num = (short)263517843;
				short num2 = num;
				num = (short)339211923;
				switch (num2 == num)
				{
				default:
				{
					num = (short)58916864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)661323777;
				if (num != 0)
				{
				}
				num = (short)1104543744;
				if (num != 0)
				{
				}
				this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.Applicable = value;
			}
		}

		// Token: 0x17004B28 RID: 19240
		// (get) Token: 0x0600958F RID: 38287 RVA: 0x008C9328 File Offset: 0x008C7528
		// (set) Token: 0x06009590 RID: 38288 RVA: 0x008C93DC File Offset: 0x008C75DC
		public bool FctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578_Valid
		{
			get
			{
				short num = (short)288514946;
				short num2 = num;
				num = (short)1564566402;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1079181312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1429733376;
				if (num != 0)
				{
				}
				num = (short)29163521;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.Valid;
			}
			set
			{
				short num = (short)443411554;
				short num2 = num;
				num = (short)1798564962;
				switch (num2 == num)
				{
				default:
				{
					num = (short)501284864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)687603713;
				if (num != 0)
				{
				}
				num = (short)1558642688;
				if (num != 0)
				{
				}
				this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.Valid = value;
			}
		}

		// Token: 0x17004B29 RID: 19241
		// (get) Token: 0x06009591 RID: 38289 RVA: 0x008C9494 File Offset: 0x008C7694
		// (set) Token: 0x06009592 RID: 38290 RVA: 0x008C9548 File Offset: 0x008C7748
		public bool FctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578_Visible
		{
			get
			{
				short num = (short)1346357331;
				short num2 = num;
				num = (short)1239861331;
				switch (num2 == num)
				{
				default:
				{
					num = (short)652083200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1775960065;
				if (num != 0)
				{
				}
				num = (short)11599872;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.Visible;
			}
			set
			{
				short num = (short)1567138969;
				short num2 = num;
				num = (short)737977497;
				switch (num2 == num)
				{
				default:
				{
					num = (short)96206848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1734082561;
				if (num != 0)
				{
				}
				num = (short)377552896;
				if (num != 0)
				{
				}
				this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.Visible = value;
			}
		}

		// Token: 0x17004B2A RID: 19242
		// (get) Token: 0x06009593 RID: 38291 RVA: 0x008C95FC File Offset: 0x008C77FC
		// (set) Token: 0x06009594 RID: 38292 RVA: 0x008C96B0 File Offset: 0x008C78B0
		public bool FctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578_Editable
		{
			get
			{
				short num = (short)369360897;
				if (num != 0)
				{
				}
				num = (short)1845493760;
				short num2 = num;
				num = (short)1331922787;
				short num3 = num;
				num = (short)2106361699;
				switch (num3 == num)
				{
				}
				num = (short)1301807104;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.Editable;
			}
			set
			{
				short num = (short)202659989;
				short num2 = num;
				num = (short)1662670997;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1692205056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)383844353;
				if (num != 0)
				{
				}
				num = (short)1224146944;
				if (num != 0)
				{
				}
				this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.Editable = value;
			}
		}

		// Token: 0x17004B2B RID: 19243
		// (get) Token: 0x06009595 RID: 38293 RVA: 0x008C9764 File Offset: 0x008C7964
		internal string FctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578_UILabel
		{
			get
			{
				short num = (short)864878593;
				if (num != 0)
				{
				}
				num = (short)1532166144;
				short num2 = num;
				num = (short)723205922;
				short num3 = num;
				num = (short)1458650914;
				switch (num3 == num)
				{
				}
				num = (short)540803072;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.UIName;
			}
		}

		// Token: 0x17004B2C RID: 19244
		// (get) Token: 0x06009596 RID: 38294 RVA: 0x008C981C File Offset: 0x008C7A1C
		// (set) Token: 0x06009597 RID: 38295 RVA: 0x008C98D0 File Offset: 0x008C7AD0
		internal bool FctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578_HiddenStatic
		{
			get
			{
				short num = (short)536547514;
				short num2 = num;
				num = (short)743379130;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1761411072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1911685120;
				if (num != 0)
				{
				}
				num = (short)1744371713;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.HiddenStatic;
			}
			set
			{
				short num = (short)277901742;
				short num2 = num;
				num = (short)257192366;
				switch (num2 == num)
				{
				default:
				{
					num = (short)757530624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1351286785;
				if (num != 0)
				{
				}
				num = (short)874774528;
				if (num != 0)
				{
				}
				this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.HiddenStatic = value;
			}
		}

		// Token: 0x17004B2D RID: 19245
		// (get) Token: 0x06009598 RID: 38296 RVA: 0x008C9988 File Offset: 0x008C7B88
		// (set) Token: 0x06009599 RID: 38297 RVA: 0x008C9A3C File Offset: 0x008C7C3C
		internal bool FctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578_HiddenDynamic
		{
			get
			{
				short num = (short)1226080555;
				short num2 = num;
				num = (short)1850835243;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1002635264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1399062528;
				if (num != 0)
				{
				}
				num = (short)1881735169;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.HiddenDynamic;
			}
			set
			{
				short num = (short)635109941;
				short num2 = num;
				num = (short)1124270645;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1188888576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)411828224;
				if (num != 0)
				{
				}
				num = (short)605093889;
				if (num != 0)
				{
				}
				this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.HiddenDynamic = value;
			}
		}

		// Token: 0x17004B2E RID: 19246
		// (get) Token: 0x0600959A RID: 38298 RVA: 0x008C9AF0 File Offset: 0x008C7CF0
		public bool FctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578_HasDiffs
		{
			get
			{
				short num = (short)1022624158;
				short num2 = num;
				num = (short)1132986782;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1452015616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2006188033;
				if (num != 0)
				{
				}
				num = (short)844365824;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578._HasDiffs;
			}
		}

		// Token: 0x17004B2F RID: 19247
		// (get) Token: 0x0600959B RID: 38299 RVA: 0x008C9BA8 File Offset: 0x008C7DA8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)15475436;
				short num2 = num;
				num = (short)1317282540;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1282080768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)787873793;
				if (num != 0)
				{
				}
				num = (short)1951727616;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x0600959C RID: 38300 RVA: 0x008C9C64 File Offset: 0x008C7E64
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
					num2 = (short)723976196;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)381550594;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)739573760;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)630881566;
					short num3 = num2;
					num2 = (short)1573420318;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)22806529;
						if (num2 != 0)
						{
						}
						num2 = (short)1992622080;
						if (num2 != 0)
						{
						}
						num2 = (short)826671104;
						short num4 = num2;
						num2 = (short)1007353857;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)688259075;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04004A09 RID: 18953
		private global::AcpBusinessLayer.AcpFrequencyField fctOrdsTxSSIClockRateListTxFrequencyMHz_A36577;

		// Token: 0x04004A0A RID: 18954
		private global::AcpBusinessLayer.AcpListField fctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578;
	}
}
