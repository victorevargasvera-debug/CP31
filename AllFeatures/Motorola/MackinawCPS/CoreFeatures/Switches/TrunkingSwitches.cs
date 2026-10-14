using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.MenuItems;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x020002BF RID: 703
	[global::System.Serializable]
	public class TrunkingSwitches : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060075E6 RID: 30182 RVA: 0x006A6B5C File Offset: 0x006A4D5C
		public TrunkingSwitches(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060075E7 RID: 30183 RVA: 0x006A6B78 File Offset: 0x006A4D78
		protected TrunkingSwitches(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060075E8 RID: 30184 RVA: 0x006A6B90 File Offset: 0x006A4D90
		public override void Init()
		{
			int a_ = 5;
			short num = (short)1123870334;
			short num2 = num;
			num = (short)1653991038;
			switch (num2 == num)
			{
			}
			num = (short)676528128;
			short num3 = num;
			num = (short)1276248065;
			if (num != 0)
			{
			}
			num = (short)2103967744;
			if (num != 0)
			{
			}
			this.switchTrunkingSwitchesPosition1_A9466 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchTrunkingSwitchesPosition1_A9466LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchTrunkingSwitchesPosition1_A9466LovStrs), this, global::AllFeatures.CodeplugGuid.b("闅뿇ꏉ룋귍룏蛑ꛓꏕ뛗뇙뗛냝蟟뇡鏣迥鳧觩蓫语華ꋱ鯳藵釷軹闻釽滿㌁嬃䜅ㄇ㸉㨋㠍", a_), global::CommonResources.AcgResources.ID_CONCENTRICSWITCHPOSITIONA, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchesPosition1_A9466LovStrs);
			this.switchTrunkingSwitchesPosition1_A9466.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.switchTrunkingSwitchesPosition1_A9466.DataTransferOrder = 12;
			this.switchTrunkingSwitchesPosition2_A9467 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchTrunkingSwitchesPosition2_A9467LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchTrunkingSwitchesPosition2_A9467LovStrs), this, global::AllFeatures.CodeplugGuid.b("闅뿇ꏉ룋귍룏蛑ꛓꏕ뛗뇙뗛냝蟟뇡鏣迥鳧觩蓫语華ꋱ鯳藵釷軹闻釽滿、嬃䜅ㄇ㸉㨋㤍", a_), global::CommonResources.AcgResources.ID_CONCENTRICSWITCHPOSITIONB, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchesPosition2_A9467LovStrs);
			this.switchTrunkingSwitchesPosition2_A9467.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.switchTrunkingSwitchesPosition2_A9467.DataTransferOrder = 13;
			this.switchTrunkingSwitchesPosition3_A9468 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchTrunkingSwitchesPosition3_A9468LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchTrunkingSwitchesPosition3_A9468LovStrs), this, global::AllFeatures.CodeplugGuid.b("闅뿇ꏉ룋귍룏蛑ꛓꏕ뛗뇙뗛냝蟟뇡鏣迥鳧觩蓫语華ꋱ鯳藵釷軹闻釽滿㄁嬃䜅ㄇ㸉㨋㘍", a_), global::CommonResources.AcgResources.ID_TOGGLESWITCHPOSITIONA, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchesPosition3_A9468LovStrs);
			this.switchTrunkingSwitchesPosition3_A9468.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.switchTrunkingSwitchesPosition3_A9468.DataTransferOrder = 14;
			this.switchTrunkingSwitchesPosition4_A21534 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchTrunkingSwitchesPosition4_A21534LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchTrunkingSwitchesPosition4_A21534LovStrs), this, global::AllFeatures.CodeplugGuid.b("闅뿇ꏉ룋귍룏蛑ꛓꏕ뛗뇙뗛냝蟟뇡鏣迥鳧觩蓫语華ꋱ鯳藵釷軹闻釽滿㘁嬃䜅㨇㬉㤋㴍␏", a_), global::CommonResources.AcgResources.ID_TOGGLESWITCHPOSITIONB, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchesPosition4_A21534LovStrs);
			this.switchTrunkingSwitchesPosition4_A21534.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.switchTrunkingSwitchesPosition4_A21534.DataTransferOrder = 15;
			this.switchTrunkingSwitchesPosition5_A21535 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchTrunkingSwitchesPosition5_A21535LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchTrunkingSwitchesPosition5_A21535LovStrs), this, global::AllFeatures.CodeplugGuid.b("闅뿇ꏉ룋귍룏蛑ꛓꏕ뛗뇙뗛냝蟟뇡鏣迥鳧觩蓫语華ꋱ鯳藵釷軹闻釽滿㜁嬃䜅㨇㬉㤋㴍┏", a_), global::CommonResources.AcgResources.ID_TOGGLESWITCHPOSITIONC, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchesPosition5_A21535LovStrs);
			this.switchTrunkingSwitchesPosition5_A21535.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.switchTrunkingSwitchesPosition5_A21535.DataTransferOrder = 16;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鋅뫇뿉ꋋꗍ맏병돓诗귙뗛ꫝ菟諡臣闥", a_);
			base.Id = 10088;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGSWITCHES;
			base.DataTransferOrder = 5;
		}

		// Token: 0x060075E9 RID: 30185 RVA: 0x006A6DFC File Offset: 0x006A4FFC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 11;
			short num = (short)1327890449;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_EA;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿋맍맏ꛑ럓뻕賗꣙꧛냝诟诡諣臥믧鷩藫髭鏯髱釳藵ꣷ闹迻韽瓿欁欃栅㬇唉䴋㜍␏␑Ⱃ", a_)))
					{
						num = (short)379191306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9C;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿋맍맏ꛑ럓뻕賗꣙꧛냝诟诡諣臥믧鷩藫髭鏯髱釳藵ꣷ闹迻韽瓿欁欃栅㤇唉䴋㜍␏␑∓", a_)))
					{
						num = (short)985792530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4BA;
				case 3:
				{
					num = (short)2058485760;
					short num3 = num;
					this.switchTrunkingSwitchesPosition5_A21535 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchTrunkingSwitchesPosition5_A21535LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchTrunkingSwitchesPosition5_A21535LovStrs), this, global::AllFeatures.CodeplugGuid.b("鿋맍맏ꛑ럓뻕賗꣙꧛냝诟诡諣臥믧鷩藫髭鏯髱釳藵ꣷ闹迻韽瓿欁欃栅㴇唉䴋㰍ℏ✑✓⌕", a_), global::CommonResources.AcgResources.ID_TOGGLESWITCHPOSITIONC, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchesPosition5_A21535LovStrs);
					this.switchTrunkingSwitchesPosition5_A21535.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.switchTrunkingSwitchesPosition5_A21535.DataTransferOrder = 16;
					num = (short)361103365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					num = (short)496893966;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_377;
				case 6:
					goto IL_4BA;
				case 7:
					goto IL_9C;
				case 8:
					this.switchTrunkingSwitchesPosition2_A9467 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchTrunkingSwitchesPosition2_A9467LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchTrunkingSwitchesPosition2_A9467LovStrs), this, global::AllFeatures.CodeplugGuid.b("鿋맍맏ꛑ럓뻕賗꣙꧛냝诟诡諣臥믧鷩藫髭鏯髱釳藵ꣷ闹迻韽瓿欁欃栅㨇唉䴋㜍␏␑⌓", a_), global::CommonResources.AcgResources.ID_CONCENTRICSWITCHPOSITIONB, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchesPosition2_A9467LovStrs);
					this.switchTrunkingSwitchesPosition2_A9467.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.switchTrunkingSwitchesPosition2_A9467.DataTransferOrder = 13;
					num = (short)1872035840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿋맍맏ꛑ럓뻕賗꣙꧛냝诟诡諣臥믧鷩藫髭鏯髱釳藵ꣷ闹迻韽瓿欁欃栅㰇唉䴋㰍ℏ✑✓∕", a_)))
					{
						num = (short)1926692880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F2;
				case 10:
					this.switchTrunkingSwitchesPosition3_A9468 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchTrunkingSwitchesPosition3_A9468LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchTrunkingSwitchesPosition3_A9468LovStrs), this, global::AllFeatures.CodeplugGuid.b("鿋맍맏ꛑ럓뻕賗꣙꧛냝诟诡諣臥믧鷩藫髭鏯髱釳藵ꣷ闹迻韽瓿欁欃栅㬇唉䴋㜍␏␑Ⱃ", a_), global::CommonResources.AcgResources.ID_TOGGLESWITCHPOSITIONA, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchesPosition3_A9468LovStrs);
					this.switchTrunkingSwitchesPosition3_A9468.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.switchTrunkingSwitchesPosition3_A9468.DataTransferOrder = 14;
					num = (short)868810759;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿋맍맏ꛑ럓뻕賗꣙꧛냝诟诡諣臥믧鷩藫髭鏯髱釳藵ꣷ闹迻韽瓿欁欃栅㨇唉䴋㜍␏␑⌓", a_)))
					{
						num = (short)1622081544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EA;
				case 12:
				{
					num = (short)863551785;
					short num4 = num;
					num = (short)2140586281;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_377;
					default:
						num = (short)657588225;
						if (num != 0)
						{
						}
						num = (short)729677824;
						if (num != 0)
						{
						}
						num = (short)799866882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 13:
					goto IL_1F2;
				case 14:
					if (producerFields != null)
					{
						num = (short)1416626188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_508;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿋맍맏ꛑ럓뻕賗꣙꧛냝诟诡諣臥믧鷩藫髭鏯髱釳藵ꣷ闹迻韽瓿欁欃栅㴇唉䴋㰍ℏ✑✓⌕", a_)))
					{
						num = (short)251396099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_508;
				case 16:
					this.switchTrunkingSwitchesPosition4_A21534 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchTrunkingSwitchesPosition4_A21534LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchTrunkingSwitchesPosition4_A21534LovStrs), this, global::AllFeatures.CodeplugGuid.b("鿋맍맏ꛑ럓뻕賗꣙꧛냝诟诡諣臥믧鷩藫髭鏯髱釳藵ꣷ闹迻韽瓿欁欃栅㰇唉䴋㰍ℏ✑✓∕", a_), global::CommonResources.AcgResources.ID_TOGGLESWITCHPOSITIONB, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchesPosition4_A21534LovStrs);
					this.switchTrunkingSwitchesPosition4_A21534.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.switchTrunkingSwitchesPosition4_A21534.DataTransferOrder = 15;
					num = (short)339476493;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					switch (0)
					{
					case 0:
						goto IL_79;
					}
					continue;
				case 18:
					this.switchTrunkingSwitchesPosition1_A9466 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchTrunkingSwitchesPosition1_A9466LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchTrunkingSwitchesPosition1_A9466LovStrs), this, global::AllFeatures.CodeplugGuid.b("鿋맍맏ꛑ럓뻕賗꣙꧛냝诟诡諣臥믧鷩藫髭鏯髱釳藵ꣷ闹迻韽瓿欁欃栅㤇唉䴋㜍␏␑∓", a_), global::CommonResources.AcgResources.ID_CONCENTRICSWITCHPOSITIONA, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchesPosition1_A9466LovStrs);
					this.switchTrunkingSwitchesPosition1_A9466.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.switchTrunkingSwitchesPosition1_A9466.DataTransferOrder = 12;
					num = (short)51707910;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_79:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)423231492;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9C:
				num = (short)1609957385;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EA:
				num = (short)303628289;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F2:
				num = (short)915931151;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4BA:
				num = (short)739049483;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_377:
			IL_508:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("飋볍ꗏ병뿓뿕뛗뷙ﳛ距韟诡郣藥胧迩鿫", a_);
			base.Id = 10088;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGSWITCHES;
			base.DataTransferOrder = 5;
		}

		// Token: 0x060075EA RID: 30186 RVA: 0x006A7344 File Offset: 0x006A5544
		public override void PopulateReferences()
		{
			short num = (short)1839202304;
			short num2 = num;
			num = (short)1056922198;
			short num3 = num;
			num = (short)1460230742;
			switch (num3 == num)
			{
			}
			num = (short)1338769409;
			if (num != 0)
			{
			}
			num = (short)1397882880;
			if (num != 0)
			{
			}
		}

		// Token: 0x060075EB RID: 30187 RVA: 0x006A73F0 File Offset: 0x006A55F0
		public override void DropReferences()
		{
			short num = (short)1518665728;
			short num2 = num;
			num = (short)1538523137;
			if (num != 0)
			{
			}
			num = (short)1159305337;
			short num3 = num;
			num = (short)664836217;
			switch (num3 == num)
			{
			}
			num = (short)526974976;
			if (num != 0)
			{
			}
		}

		// Token: 0x060075EC RID: 30188 RVA: 0x006A7498 File Offset: 0x006A5698
		public override void SetConstraints()
		{
			short num = (short)477888512;
			short num2 = num;
			num = (short)729112519;
			short num3 = num;
			num = (short)1162305479;
			switch (num3 == num)
			{
			}
			num = (short)1170407425;
			if (num != 0)
			{
			}
			num = (short)1293877248;
			if (num != 0)
			{
			}
			this.switchTrunkingSwitchesPosition1_A9466.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSwitchesTrkPos1);
			this.switchTrunkingSwitchesPosition1_A9466.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.conSetEditabilityConcentricSwitches);
			this.switchTrunkingSwitchesPosition1_A9466.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSyncPositionAInFirstRecTrkSwitches);
			this.switchTrunkingSwitchesPosition2_A9467.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSwitchesTrkPos2);
			this.switchTrunkingSwitchesPosition2_A9467.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.conSetEditabilityConcentricSwitches);
			this.switchTrunkingSwitchesPosition2_A9467.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSyncPositionBInFirstRecTrkSwitches);
			this.switchTrunkingSwitchesPosition3_A9468.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSwitchesTrkPos3);
			this.switchTrunkingSwitchesPosition3_A9468.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.conSetEditabilityToggleSwitches);
			this.switchTrunkingSwitchesPosition3_A9468.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSyncPositionAInFourthRecTrkSwitches);
			this.switchTrunkingSwitchesPosition4_A21534.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSwitchesTrkPos4);
			this.switchTrunkingSwitchesPosition4_A21534.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.conSetEditabilityToggleSwitches);
			this.switchTrunkingSwitchesPosition4_A21534.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSyncPositionBInFourthRecTrkSwitches);
			this.switchTrunkingSwitchesPosition5_A21535.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSwitchesTrkPos5);
			this.switchTrunkingSwitchesPosition5_A21535.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.conSetEditabilityToggleSwitches);
			this.switchTrunkingSwitchesPosition5_A21535.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSyncPositionCInFourthRecTrkSwitches);
		}

		// Token: 0x060075ED RID: 30189 RVA: 0x006A769C File Offset: 0x006A589C
		public override void SetupDependencies()
		{
			short num = (short)1404698624;
			short num2 = num;
			num = (short)508428289;
			if (num != 0)
			{
			}
			num = (short)1904490889;
			short num3 = num;
			num = (short)1548892553;
			switch (num3 == num)
			{
			}
			num = (short)911015936;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
			switches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.AddDependentObject(this.switchTrunkingSwitchesPosition1_A9466);
			switches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.AddDependentObject(this.switchTrunkingSwitchesPosition1_A9466);
			this.switchTrunkingSwitchesPosition2_A9467.AddDependentObject(this.switchTrunkingSwitchesPosition1_A9466);
			this.switchTrunkingSwitchesPosition3_A9468.AddDependentObject(this.switchTrunkingSwitchesPosition1_A9466);
			this.switchTrunkingSwitchesPosition4_A21534.AddDependentObject(this.switchTrunkingSwitchesPosition1_A9466);
			this.switchTrunkingSwitchesPosition5_A21535.AddDependentObject(this.switchTrunkingSwitchesPosition1_A9466);
			this.RefMenuItems.General.DispMenuConventionalSelectedMenuItems_A21736.AddDependentObject(this.switchTrunkingSwitchesPosition1_A9466);
			this.RefMenuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.AddDependentObject(this.switchTrunkingSwitchesPosition1_A9466);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.AddDependentObject(this.switchTrunkingSwitchesPosition1_A9466);
			switches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.AddDependentObject(this.switchTrunkingSwitchesPosition2_A9467);
			switches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.AddDependentObject(this.switchTrunkingSwitchesPosition2_A9467);
			this.switchTrunkingSwitchesPosition1_A9466.AddDependentObject(this.switchTrunkingSwitchesPosition2_A9467);
			this.switchTrunkingSwitchesPosition3_A9468.AddDependentObject(this.switchTrunkingSwitchesPosition2_A9467);
			this.switchTrunkingSwitchesPosition4_A21534.AddDependentObject(this.switchTrunkingSwitchesPosition2_A9467);
			this.switchTrunkingSwitchesPosition5_A21535.AddDependentObject(this.switchTrunkingSwitchesPosition2_A9467);
			this.RefMenuItems.General.DispMenuConventionalSelectedMenuItems_A21736.AddDependentObject(this.switchTrunkingSwitchesPosition2_A9467);
			this.RefMenuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.AddDependentObject(this.switchTrunkingSwitchesPosition2_A9467);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.AddDependentObject(this.switchTrunkingSwitchesPosition2_A9467);
			switches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.AddDependentObject(this.switchTrunkingSwitchesPosition3_A9468);
			switches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.AddDependentObject(this.switchTrunkingSwitchesPosition3_A9468);
			switches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.AddDependentObject(this.switchTrunkingSwitchesPosition3_A9468);
			this.switchTrunkingSwitchesPosition1_A9466.AddDependentObject(this.switchTrunkingSwitchesPosition3_A9468);
			this.switchTrunkingSwitchesPosition2_A9467.AddDependentObject(this.switchTrunkingSwitchesPosition3_A9468);
			this.switchTrunkingSwitchesPosition4_A21534.AddDependentObject(this.switchTrunkingSwitchesPosition3_A9468);
			this.switchTrunkingSwitchesPosition5_A21535.AddDependentObject(this.switchTrunkingSwitchesPosition3_A9468);
			this.RefMenuItems.General.DispMenuConventionalSelectedMenuItems_A21736.AddDependentObject(this.switchTrunkingSwitchesPosition3_A9468);
			this.RefMenuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.AddDependentObject(this.switchTrunkingSwitchesPosition3_A9468);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.AddDependentObject(this.switchTrunkingSwitchesPosition3_A9468);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedToggleSwitchLockEnable_43773.AddDependentObject(this.switchTrunkingSwitchesPosition3_A9468);
			switches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.AddDependentObject(this.switchTrunkingSwitchesPosition4_A21534);
			switches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.AddDependentObject(this.switchTrunkingSwitchesPosition4_A21534);
			switches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.AddDependentObject(this.switchTrunkingSwitchesPosition4_A21534);
			this.switchTrunkingSwitchesPosition1_A9466.AddDependentObject(this.switchTrunkingSwitchesPosition4_A21534);
			this.switchTrunkingSwitchesPosition2_A9467.AddDependentObject(this.switchTrunkingSwitchesPosition4_A21534);
			this.switchTrunkingSwitchesPosition3_A9468.AddDependentObject(this.switchTrunkingSwitchesPosition4_A21534);
			this.switchTrunkingSwitchesPosition5_A21535.AddDependentObject(this.switchTrunkingSwitchesPosition4_A21534);
			this.RefMenuItems.General.DispMenuConventionalSelectedMenuItems_A21736.AddDependentObject(this.switchTrunkingSwitchesPosition4_A21534);
			this.RefMenuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.AddDependentObject(this.switchTrunkingSwitchesPosition4_A21534);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.AddDependentObject(this.switchTrunkingSwitchesPosition4_A21534);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedToggleSwitchLockEnable_43773.AddDependentObject(this.switchTrunkingSwitchesPosition4_A21534);
			switches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.AddDependentObject(this.switchTrunkingSwitchesPosition5_A21535);
			switches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.AddDependentObject(this.switchTrunkingSwitchesPosition5_A21535);
			switches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.AddDependentObject(this.switchTrunkingSwitchesPosition5_A21535);
			this.switchTrunkingSwitchesPosition1_A9466.AddDependentObject(this.switchTrunkingSwitchesPosition5_A21535);
			this.switchTrunkingSwitchesPosition2_A9467.AddDependentObject(this.switchTrunkingSwitchesPosition5_A21535);
			this.switchTrunkingSwitchesPosition3_A9468.AddDependentObject(this.switchTrunkingSwitchesPosition5_A21535);
			this.switchTrunkingSwitchesPosition4_A21534.AddDependentObject(this.switchTrunkingSwitchesPosition5_A21535);
			this.RefMenuItems.General.DispMenuConventionalSelectedMenuItems_A21736.AddDependentObject(this.switchTrunkingSwitchesPosition5_A21535);
			this.RefMenuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.AddDependentObject(this.switchTrunkingSwitchesPosition5_A21535);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.AddDependentObject(this.switchTrunkingSwitchesPosition5_A21535);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedToggleSwitchLockEnable_43773.AddDependentObject(this.switchTrunkingSwitchesPosition5_A21535);
			this.RefRadioWide.Features.RadWideFeaturesNFPACompliant.AddDependentObject(this.switchTrunkingSwitchesPosition1_A9466);
			this.RefRadioWide.Features.RadWideFeaturesNFPACompliant.AddDependentObject(this.switchTrunkingSwitchesPosition2_A9467);
		}

		// Token: 0x17003CB4 RID: 15540
		// (get) Token: 0x060075EE RID: 30190 RVA: 0x006A7C10 File Offset: 0x006A5E10
		public bool HasDiffs
		{
			get
			{
				short num = (short)502726656;
				short num2 = num;
				num = (short)194293337;
				short num3 = num;
				num = (short)440905305;
				switch (num3 == num)
				{
				}
				num = (short)562954240;
				if (num != 0)
				{
				}
				num = (short)2119761921;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003CB5 RID: 15541
		// (get) Token: 0x060075EF RID: 30191 RVA: 0x006A7CC0 File Offset: 0x006A5EC0
		// (set) Token: 0x060075F0 RID: 30192 RVA: 0x006A7D74 File Offset: 0x006A5F74
		public int SwitchTrunkingSwitchesPosition1_A9466Value
		{
			get
			{
				short num = (short)981729280;
				short num2 = num;
				num = (short)1625123476;
				short num3 = num;
				num = (short)1289317012;
				switch (num3 == num)
				{
				}
				num = (short)246218753;
				if (num != 0)
				{
				}
				num = (short)1840447488;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition1_A9466.Value;
			}
			set
			{
				short num = (short)1015349248;
				short num2 = num;
				num = (short)430702971;
				short num3 = num;
				num = (short)2116157819;
				switch (num3 == num)
				{
				}
				num = (short)1674641408;
				if (num != 0)
				{
				}
				num = (short)627572737;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition1_A9466.Value = value;
			}
		}

		// Token: 0x17003CB6 RID: 15542
		// (get) Token: 0x060075F1 RID: 30193 RVA: 0x006A7E28 File Offset: 0x006A6028
		// (set) Token: 0x060075F2 RID: 30194 RVA: 0x006A7EE0 File Offset: 0x006A60E0
		public string SwitchTrunkingSwitchesPosition1_A9466_UIValue
		{
			get
			{
				short num = (short)437125120;
				short num2 = num;
				num = (short)1739535223;
				short num3 = num;
				num = (short)1342714743;
				switch (num3 == num)
				{
				}
				num = (short)1470955521;
				if (num != 0)
				{
				}
				num = (short)138412032;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition1_A9466.UIValue;
			}
			set
			{
				short num = (short)1536950272;
				short num2 = num;
				num = (short)539379982;
				short num3 = num;
				num = (short)1958627598;
				switch (num3 == num)
				{
				}
				num = (short)1331494913;
				if (num != 0)
				{
				}
				num = (short)892993536;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition1_A9466.UIValue = value;
			}
		}

		// Token: 0x17003CB7 RID: 15543
		// (get) Token: 0x060075F3 RID: 30195 RVA: 0x006A7F94 File Offset: 0x006A6194
		public global::AcpBusinessLayer.AcpListField SwitchTrunkingSwitchesPosition1_A9466
		{
			get
			{
				short num = (short)988872704;
				short num2 = num;
				num = (short)1142181247;
				short num3 = num;
				num = (short)1586908543;
				switch (num3 == num)
				{
				}
				num = (short)1833172992;
				if (num != 0)
				{
				}
				num = (short)610140161;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition1_A9466;
			}
		}

		// Token: 0x17003CB8 RID: 15544
		// (get) Token: 0x060075F4 RID: 30196 RVA: 0x006A8044 File Offset: 0x006A6244
		// (set) Token: 0x060075F5 RID: 30197 RVA: 0x006A80F8 File Offset: 0x006A62F8
		public bool SwitchTrunkingSwitchesPosition1_A9466_Applicable
		{
			get
			{
				short num = (short)989265920;
				short num2 = num;
				num = (short)2138806486;
				short num3 = num;
				num = (short)1353816278;
				switch (num3 == num)
				{
				}
				num = (short)936050688;
				if (num != 0)
				{
				}
				num = (short)1301872641;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition1_A9466.Applicable;
			}
			set
			{
				short num = (short)1316618240;
				short num2 = num;
				num = (short)1854793976;
				short num3 = num;
				num = (short)545646840;
				switch (num3 == num)
				{
				}
				num = (short)668401665;
				if (num != 0)
				{
				}
				num = (short)932249600;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition1_A9466.Applicable = value;
			}
		}

		// Token: 0x17003CB9 RID: 15545
		// (get) Token: 0x060075F6 RID: 30198 RVA: 0x006A81B0 File Offset: 0x006A63B0
		// (set) Token: 0x060075F7 RID: 30199 RVA: 0x006A8264 File Offset: 0x006A6464
		public bool SwitchTrunkingSwitchesPosition1_A9466_Valid
		{
			get
			{
				short num = (short)1919418368;
				short num2 = num;
				num = (short)705981890;
				short num3 = num;
				num = (short)919432642;
				switch (num3 == num)
				{
				}
				num = (short)708575233;
				if (num != 0)
				{
				}
				num = (short)1550450688;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition1_A9466.Valid;
			}
			set
			{
				short num = (short)1003225088;
				short num2 = num;
				num = (short)403173391;
				short num3 = num;
				num = (short)1932914703;
				switch (num3 == num)
				{
				}
				num = (short)1648361472;
				if (num != 0)
				{
				}
				num = (short)380370945;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition1_A9466.Valid = value;
			}
		}

		// Token: 0x17003CBA RID: 15546
		// (get) Token: 0x060075F8 RID: 30200 RVA: 0x006A831C File Offset: 0x006A651C
		// (set) Token: 0x060075F9 RID: 30201 RVA: 0x006A83D0 File Offset: 0x006A65D0
		public bool SwitchTrunkingSwitchesPosition1_A9466_Visible
		{
			get
			{
				short num = (short)1143537664;
				short num2 = num;
				num = (short)91772122;
				short num3 = num;
				num = (short)856904922;
				switch (num3 == num)
				{
				}
				num = (short)597884928;
				if (num != 0)
				{
				}
				num = (short)955383809;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition1_A9466.Visible;
			}
			set
			{
				short num = (short)1749090304;
				short num2 = num;
				num = (short)1135176385;
				short num3 = num;
				num = (short)1035954881;
				switch (num3 == num)
				{
				}
				num = (short)1010958337;
				if (num != 0)
				{
				}
				num = (short)739966976;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition1_A9466.Visible = value;
			}
		}

		// Token: 0x17003CBB RID: 15547
		// (get) Token: 0x060075FA RID: 30202 RVA: 0x006A8488 File Offset: 0x006A6688
		// (set) Token: 0x060075FB RID: 30203 RVA: 0x006A8540 File Offset: 0x006A6740
		public bool SwitchTrunkingSwitchesPosition1_A9466_Editable
		{
			get
			{
				short num = (short)1915551744;
				short num2 = num;
				num = (short)1068433409;
				if (num != 0)
				{
				}
				num = (short)1485981141;
				short num3 = num;
				num = (short)1975076309;
				switch (num3 == num)
				{
				}
				num = (short)486801408;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition1_A9466.Editable;
			}
			set
			{
				short num = (short)158728192;
				short num2 = num;
				num = (short)2028684151;
				short num3 = num;
				num = (short)363217783;
				switch (num3 == num)
				{
				}
				num = (short)646774785;
				if (num != 0)
				{
				}
				num = (short)658374656;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition1_A9466.Editable = value;
			}
		}

		// Token: 0x17003CBC RID: 15548
		// (get) Token: 0x060075FC RID: 30204 RVA: 0x006A85F4 File Offset: 0x006A67F4
		internal string SwitchTrunkingSwitchesPosition1_A9466_UILabel
		{
			get
			{
				short num = (short)64290816;
				short num2 = num;
				num = (short)759814261;
				short num3 = num;
				num = (short)468965493;
				switch (num3 == num)
				{
				}
				num = (short)982908928;
				if (num != 0)
				{
				}
				num = (short)68550657;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition1_A9466.UIName;
			}
		}

		// Token: 0x17003CBD RID: 15549
		// (get) Token: 0x060075FD RID: 30205 RVA: 0x006A86A8 File Offset: 0x006A68A8
		// (set) Token: 0x060075FE RID: 30206 RVA: 0x006A875C File Offset: 0x006A695C
		internal bool SwitchTrunkingSwitchesPosition1_A9466_HiddenStatic
		{
			get
			{
				short num = (short)1497628672;
				short num2 = num;
				num = (short)1206976513;
				if (num != 0)
				{
				}
				num = (short)1941029818;
				short num3 = num;
				num = (short)1432470458;
				switch (num3 == num)
				{
				}
				num = (short)116523008;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition1_A9466.HiddenStatic;
			}
			set
			{
				short num = (short)2055929856;
				short num2 = num;
				num = (short)1585458158;
				short num3 = num;
				num = (short)582626286;
				switch (num3 == num)
				{
				}
				num = (short)897187841;
				if (num != 0)
				{
				}
				num = (short)166068224;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition1_A9466.HiddenStatic = value;
			}
		}

		// Token: 0x17003CBE RID: 15550
		// (get) Token: 0x060075FF RID: 30207 RVA: 0x006A8814 File Offset: 0x006A6A14
		// (set) Token: 0x06007600 RID: 30208 RVA: 0x006A88C8 File Offset: 0x006A6AC8
		internal bool SwitchTrunkingSwitchesPosition1_A9466_HiddenDynamic
		{
			get
			{
				short num = (short)1841496064;
				short num2 = num;
				num = (short)117302484;
				short num3 = num;
				num = (short)342484180;
				switch (num3 == num)
				{
				}
				num = (short)129695744;
				if (num != 0)
				{
				}
				num = (short)1891106817;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition1_A9466.HiddenDynamic;
			}
			set
			{
				short num = (short)2133852160;
				short num2 = num;
				num = (short)57739160;
				short num3 = num;
				num = (short)504432536;
				switch (num3 == num)
				{
				}
				num = (short)1786707969;
				if (num != 0)
				{
				}
				num = (short)1850802176;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition1_A9466.HiddenDynamic = value;
			}
		}

		// Token: 0x17003CBF RID: 15551
		// (get) Token: 0x06007601 RID: 30209 RVA: 0x006A8980 File Offset: 0x006A6B80
		public bool SwitchTrunkingSwitchesPosition1_A9466_HasDiffs
		{
			get
			{
				short num = (short)1667170304;
				short num2 = num;
				num = (short)1315009365;
				short num3 = num;
				num = (short)1429238613;
				switch (num3 == num)
				{
				}
				num = (short)1030815744;
				if (num != 0)
				{
				}
				num = (short)1527971841;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition1_A9466._HasDiffs;
			}
		}

		// Token: 0x17003CC0 RID: 15552
		// (get) Token: 0x06007602 RID: 30210 RVA: 0x006A8A34 File Offset: 0x006A6C34
		// (set) Token: 0x06007603 RID: 30211 RVA: 0x006A8AE8 File Offset: 0x006A6CE8
		public int SwitchTrunkingSwitchesPosition2_A9467Value
		{
			get
			{
				short num = (short)1688862720;
				short num2 = num;
				num = (short)1141219288;
				short num3 = num;
				num = (short)544907224;
				switch (num3 == num)
				{
				}
				num = (short)1316159489;
				if (num != 0)
				{
				}
				num = (short)2109276160;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition2_A9467.Value;
			}
			set
			{
				short num = (short)717619200;
				short num2 = num;
				num = (short)275082221;
				short num3 = num;
				num = (short)1743285229;
				switch (num3 == num)
				{
				}
				num = (short)117374977;
				if (num != 0)
				{
				}
				num = (short)1686700032;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition2_A9467.Value = value;
			}
		}

		// Token: 0x17003CC1 RID: 15553
		// (get) Token: 0x06007604 RID: 30212 RVA: 0x006A8B9C File Offset: 0x006A6D9C
		// (set) Token: 0x06007605 RID: 30213 RVA: 0x006A8C50 File Offset: 0x006A6E50
		public string SwitchTrunkingSwitchesPosition2_A9467_UIValue
		{
			get
			{
				short num = (short)1522335744;
				short num2 = num;
				num = (short)1130149458;
				short num3 = num;
				num = (short)1417066066;
				switch (num3 == num)
				{
				}
				num = (short)1692598273;
				if (num != 0)
				{
				}
				num = (short)141819904;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition2_A9467.UIValue;
			}
			set
			{
				short num = (short)351600640;
				short num2 = num;
				num = (short)183011885;
				short num3 = num;
				num = (short)989760045;
				switch (num3 == num)
				{
				}
				num = (short)2107047937;
				if (num != 0)
				{
				}
				num = (short)780140544;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition2_A9467.UIValue = value;
			}
		}

		// Token: 0x17003CC2 RID: 15554
		// (get) Token: 0x06007606 RID: 30214 RVA: 0x006A8D04 File Offset: 0x006A6F04
		public global::AcpBusinessLayer.AcpListField SwitchTrunkingSwitchesPosition2_A9467
		{
			get
			{
				short num = (short)294977536;
				short num2 = num;
				num = (short)1643049720;
				short num3 = num;
				num = (short)1556214520;
				switch (num3 == num)
				{
				}
				num = (short)1730740225;
				if (num != 0)
				{
				}
				num = (short)1529806848;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition2_A9467;
			}
		}

		// Token: 0x17003CC3 RID: 15555
		// (get) Token: 0x06007607 RID: 30215 RVA: 0x006A8DB4 File Offset: 0x006A6FB4
		// (set) Token: 0x06007608 RID: 30216 RVA: 0x006A8E64 File Offset: 0x006A7064
		public bool SwitchTrunkingSwitchesPosition2_A9467_Applicable
		{
			get
			{
				short num = (short)234029056;
				short num2 = num;
				num = (short)986933711;
				short num3 = num;
				num = (short)1356622287;
				switch (num3 == num)
				{
				}
				num = (short)1930625025;
				if (num != 0)
				{
				}
				num = (short)1439825920;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition2_A9467.Applicable;
			}
			set
			{
				short num = (short)1168834560;
				short num2 = num;
				num = (short)804011493;
				short num3 = num;
				num = (short)72498661;
				switch (num3 == num)
				{
				}
				num = (short)1785004033;
				if (num != 0)
				{
				}
				num = (short)1841692672;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition2_A9467.Applicable = value;
			}
		}

		// Token: 0x17003CC4 RID: 15556
		// (get) Token: 0x06007609 RID: 30217 RVA: 0x006A8F18 File Offset: 0x006A7118
		// (set) Token: 0x0600760A RID: 30218 RVA: 0x006A8FCC File Offset: 0x006A71CC
		public bool SwitchTrunkingSwitchesPosition2_A9467_Valid
		{
			get
			{
				short num = (short)1901264896;
				short num2 = num;
				num = (short)2091188225;
				if (num != 0)
				{
				}
				num = (short)706278478;
				short num3 = num;
				num = (short)1603925070;
				switch (num3 == num)
				{
				}
				num = (short)1199177728;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition2_A9467.Valid;
			}
			set
			{
				short num = (short)184680448;
				short num2 = num;
				num = (short)468960168;
				short num3 = num;
				num = (short)1159840680;
				switch (num3 == num)
				{
				}
				num = (short)619773953;
				if (num != 0)
				{
				}
				num = (short)12648448;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition2_A9467.Valid = value;
			}
		}

		// Token: 0x17003CC5 RID: 15557
		// (get) Token: 0x0600760B RID: 30219 RVA: 0x006A9084 File Offset: 0x006A7284
		// (set) Token: 0x0600760C RID: 30220 RVA: 0x006A9138 File Offset: 0x006A7338
		public bool SwitchTrunkingSwitchesPosition2_A9467_Visible
		{
			get
			{
				short num = (short)296419328;
				short num2 = num;
				num = (short)1830345273;
				short num3 = num;
				num = (short)1383979577;
				switch (num3 == num)
				{
				}
				num = (short)941490176;
				if (num != 0)
				{
				}
				num = (short)1170931713;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition2_A9467.Visible;
			}
			set
			{
				short num = (short)1640169472;
				short num2 = num;
				num = (short)1076611521;
				short num3 = num;
				num = (short)1581959617;
				switch (num3 == num)
				{
				}
				num = (short)974585857;
				if (num != 0)
				{
				}
				num = (short)285671424;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition2_A9467.Visible = value;
			}
		}

		// Token: 0x17003CC6 RID: 15558
		// (get) Token: 0x0600760D RID: 30221 RVA: 0x006A91F0 File Offset: 0x006A73F0
		// (set) Token: 0x0600760E RID: 30222 RVA: 0x006A92A4 File Offset: 0x006A74A4
		public bool SwitchTrunkingSwitchesPosition2_A9467_Editable
		{
			get
			{
				short num = (short)564527104;
				short num2 = num;
				num = (short)392644639;
				short num3 = num;
				num = (short)634013727;
				switch (num3 == num)
				{
				}
				num = (short)401473536;
				if (num != 0)
				{
				}
				num = (short)241893377;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition2_A9467.Editable;
			}
			set
			{
				short num = (short)1696268288;
				short num2 = num;
				num = (short)1028654777;
				short num3 = num;
				num = (short)1772357305;
				switch (num3 == num)
				{
				}
				num = (short)258998272;
				if (num != 0)
				{
				}
				num = (short)1261830145;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition2_A9467.Editable = value;
			}
		}

		// Token: 0x17003CC7 RID: 15559
		// (get) Token: 0x0600760F RID: 30223 RVA: 0x006A9358 File Offset: 0x006A7558
		internal string SwitchTrunkingSwitchesPosition2_A9467_UILabel
		{
			get
			{
				short num = (short)371261440;
				short num2 = num;
				num = (short)2008545931;
				short num3 = num;
				num = (short)2081815179;
				switch (num3 == num)
				{
				}
				num = (short)809172993;
				if (num != 0)
				{
				}
				num = (short)2099183616;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition2_A9467.UIName;
			}
		}

		// Token: 0x17003CC8 RID: 15560
		// (get) Token: 0x06007610 RID: 30224 RVA: 0x006A940C File Offset: 0x006A760C
		// (set) Token: 0x06007611 RID: 30225 RVA: 0x006A94C4 File Offset: 0x006A76C4
		internal bool SwitchTrunkingSwitchesPosition2_A9467_HiddenStatic
		{
			get
			{
				short num = (short)1741567156;
				short num2 = num;
				num = (short)689648820;
				switch (num2 == num)
				{
				default:
				{
					num = (short)61341696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)161349633;
				if (num != 0)
				{
				}
				num = (short)501874688;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition2_A9467.HiddenStatic;
			}
			set
			{
				short num = (short)1874355750;
				short num2 = num;
				num = (short)783902246;
				switch (num2 == num)
				{
				default:
				{
					num = (short)928251904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)337707009;
				if (num != 0)
				{
				}
				num = (short)328663040;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition2_A9467.HiddenStatic = value;
			}
		}

		// Token: 0x17003CC9 RID: 15561
		// (get) Token: 0x06007612 RID: 30226 RVA: 0x006A957C File Offset: 0x006A777C
		// (set) Token: 0x06007613 RID: 30227 RVA: 0x006A9634 File Offset: 0x006A7834
		internal bool SwitchTrunkingSwitchesPosition2_A9467_HiddenDynamic
		{
			get
			{
				short num = (short)78150450;
				short num2 = num;
				num = (short)246184754;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1934098432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)731774976;
				if (num != 0)
				{
				}
				num = (short)1260650497;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition2_A9467.HiddenDynamic;
			}
			set
			{
				short num = (short)754822465;
				short num2 = num;
				num = (short)2110762305;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2126512128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1532035072;
				if (num != 0)
				{
				}
				num = (short)848035841;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition2_A9467.HiddenDynamic = value;
			}
		}

		// Token: 0x17003CCA RID: 15562
		// (get) Token: 0x06007614 RID: 30228 RVA: 0x006A96E8 File Offset: 0x006A78E8
		public bool SwitchTrunkingSwitchesPosition2_A9467_HasDiffs
		{
			get
			{
				short num = (short)927399937;
				if (num != 0)
				{
				}
				num = (short)1056047104;
				short num2 = num;
				num = (short)1837332771;
				short num3 = num;
				num = (short)56260899;
				switch (num3 == num)
				{
				}
				num = (short)136904704;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition2_A9467._HasDiffs;
			}
		}

		// Token: 0x17003CCB RID: 15563
		// (get) Token: 0x06007615 RID: 30229 RVA: 0x006A97A0 File Offset: 0x006A79A0
		// (set) Token: 0x06007616 RID: 30230 RVA: 0x006A9850 File Offset: 0x006A7A50
		public int SwitchTrunkingSwitchesPosition3_A9468Value
		{
			get
			{
				short num = (short)1377827858;
				short num2 = num;
				num = (short)486997010;
				switch (num2 == num)
				{
				default:
				{
					num = (short)501678080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1844903937;
				if (num != 0)
				{
				}
				num = (short)1190133760;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition3_A9468.Value;
			}
			set
			{
				short num = (short)391446529;
				if (num != 0)
				{
				}
				num = (short)1156317184;
				short num2 = num;
				num = (short)316242791;
				short num3 = num;
				num = (short)268991335;
				switch (num3 == num)
				{
				}
				num = (short)2041511936;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition3_A9468.Value = value;
			}
		}

		// Token: 0x17003CCC RID: 15564
		// (get) Token: 0x06007617 RID: 30231 RVA: 0x006A9904 File Offset: 0x006A7B04
		// (set) Token: 0x06007618 RID: 30232 RVA: 0x006A99B8 File Offset: 0x006A7BB8
		public string SwitchTrunkingSwitchesPosition3_A9468_UIValue
		{
			get
			{
				short num = (short)1547918284;
				short num2 = num;
				num = (short)1394170828;
				switch (num2 == num)
				{
				default:
				{
					num = (short)306118656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)676003840;
				if (num != 0)
				{
				}
				num = (short)351928321;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition3_A9468.UIValue;
			}
			set
			{
				short num = (short)1709964370;
				short num2 = num;
				num = (short)216661074;
				switch (num2 == num)
				{
				default:
				{
					num = (short)179699712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1786642433;
				if (num != 0)
				{
				}
				num = (short)463142912;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition3_A9468.UIValue = value;
			}
		}

		// Token: 0x17003CCD RID: 15565
		// (get) Token: 0x06007619 RID: 30233 RVA: 0x006A9A70 File Offset: 0x006A7C70
		public global::AcpBusinessLayer.AcpListField SwitchTrunkingSwitchesPosition3_A9468
		{
			get
			{
				short num = (short)1196787617;
				short num2 = num;
				num = (short)1384810401;
				switch (num2 == num)
				{
				default:
				{
					num = (short)872808448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1498087424;
				if (num != 0)
				{
				}
				num = (short)1101725697;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition3_A9468;
			}
		}

		// Token: 0x17003CCE RID: 15566
		// (get) Token: 0x0600761A RID: 30234 RVA: 0x006A9B20 File Offset: 0x006A7D20
		// (set) Token: 0x0600761B RID: 30235 RVA: 0x006A9BD4 File Offset: 0x006A7DD4
		public bool SwitchTrunkingSwitchesPosition3_A9468_Applicable
		{
			get
			{
				short num = (short)1376090571;
				short num2 = num;
				num = (short)1169979851;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1921449984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)227344384;
				if (num != 0)
				{
				}
				num = (short)53346305;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition3_A9468.Applicable;
			}
			set
			{
				short num = (short)1337262081;
				if (num != 0)
				{
				}
				num = (short)439746560;
				short num2 = num;
				num = (short)422667360;
				short num3 = num;
				num = (short)1820681312;
				switch (num3 == num)
				{
				}
				num = (short)1887567872;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition3_A9468.Applicable = value;
			}
		}

		// Token: 0x17003CCF RID: 15567
		// (get) Token: 0x0600761C RID: 30236 RVA: 0x006A9C8C File Offset: 0x006A7E8C
		// (set) Token: 0x0600761D RID: 30237 RVA: 0x006A9D40 File Offset: 0x006A7F40
		public bool SwitchTrunkingSwitchesPosition3_A9468_Valid
		{
			get
			{
				short num = (short)1758662948;
				short num2 = num;
				num = (short)1342247204;
				switch (num2 == num)
				{
				default:
				{
					num = (short)527040512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)987693057;
				if (num != 0)
				{
				}
				num = (short)1039204352;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition3_A9468.Valid;
			}
			set
			{
				short num = (short)911671297;
				if (num != 0)
				{
				}
				num = (short)1046085632;
				short num2 = num;
				num = (short)1324734437;
				short num3 = num;
				num = (short)229169125;
				switch (num3 == num)
				{
				}
				num = (short)886964224;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition3_A9468.Valid = value;
			}
		}

		// Token: 0x17003CD0 RID: 15568
		// (get) Token: 0x0600761E RID: 30238 RVA: 0x006A9DF0 File Offset: 0x006A7FF0
		// (set) Token: 0x0600761F RID: 30239 RVA: 0x006A9EA8 File Offset: 0x006A80A8
		public bool SwitchTrunkingSwitchesPosition3_A9468_Visible
		{
			get
			{
				short num = (short)2013578598;
				short num2 = num;
				num = (short)2145764710;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1032912896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1071972352;
				if (num != 0)
				{
				}
				num = (short)299040769;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition3_A9468.Visible;
			}
			set
			{
				short num = (short)386409155;
				short num2 = num;
				num = (short)1905337027;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1163198464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)299958273;
				if (num != 0)
				{
				}
				num = (short)967507968;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition3_A9468.Visible = value;
			}
		}

		// Token: 0x17003CD1 RID: 15569
		// (get) Token: 0x06007620 RID: 30240 RVA: 0x006A9F5C File Offset: 0x006A815C
		// (set) Token: 0x06007621 RID: 30241 RVA: 0x006AA010 File Offset: 0x006A8210
		public bool SwitchTrunkingSwitchesPosition3_A9468_Editable
		{
			get
			{
				short num = (short)1550095674;
				short num2 = num;
				num = (short)580949306;
				switch (num2 == num)
				{
				default:
				{
					num = (short)141230080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1701117952;
				if (num != 0)
				{
				}
				num = (short)214958081;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition3_A9468.Editable;
			}
			set
			{
				short num = (short)1750300034;
				short num2 = num;
				num = (short)1618441602;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1761148928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)797442049;
				if (num != 0)
				{
				}
				num = (short)1105657856;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition3_A9468.Editable = value;
			}
		}

		// Token: 0x17003CD2 RID: 15570
		// (get) Token: 0x06007622 RID: 30242 RVA: 0x006AA0C4 File Offset: 0x006A82C4
		internal string SwitchTrunkingSwitchesPosition3_A9468_UILabel
		{
			get
			{
				short num = (short)119574752;
				short num2 = num;
				num = (short)274108640;
				switch (num2 == num)
				{
				default:
				{
					num = (short)36438016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)551288832;
				if (num != 0)
				{
				}
				num = (short)640483329;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition3_A9468.UIName;
			}
		}

		// Token: 0x17003CD3 RID: 15571
		// (get) Token: 0x06007623 RID: 30243 RVA: 0x006AA178 File Offset: 0x006A8378
		// (set) Token: 0x06007624 RID: 30244 RVA: 0x006AA22C File Offset: 0x006A842C
		internal bool SwitchTrunkingSwitchesPosition3_A9468_HiddenStatic
		{
			get
			{
				short num = (short)1317727345;
				short num2 = num;
				num = (short)461565041;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1610350592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)477167617;
				if (num != 0)
				{
				}
				num = (short)1327038464;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition3_A9468.HiddenStatic;
			}
			set
			{
				short num = (short)431856048;
				short num2 = num;
				num = (short)1358141872;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1474428928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)883359744;
				if (num != 0)
				{
				}
				num = (short)1847066625;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition3_A9468.HiddenStatic = value;
			}
		}

		// Token: 0x17003CD4 RID: 15572
		// (get) Token: 0x06007625 RID: 30245 RVA: 0x006AA2E4 File Offset: 0x006A84E4
		// (set) Token: 0x06007626 RID: 30246 RVA: 0x006AA398 File Offset: 0x006A8598
		internal bool SwitchTrunkingSwitchesPosition3_A9468_HiddenDynamic
		{
			get
			{
				short num = (short)1261585004;
				short num2 = num;
				num = (short)1128612460;
				switch (num2 == num)
				{
				default:
				{
					num = (short)848560128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)484573185;
				if (num != 0)
				{
				}
				num = (short)592838656;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition3_A9468.HiddenDynamic;
			}
			set
			{
				short num = (short)91141185;
				short num2 = num;
				num = (short)1660990529;
				switch (num2 == num)
				{
				default:
				{
					num = (short)444071936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)543358976;
				if (num != 0)
				{
				}
				num = (short)2053242881;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition3_A9468.HiddenDynamic = value;
			}
		}

		// Token: 0x17003CD5 RID: 15573
		// (get) Token: 0x06007627 RID: 30247 RVA: 0x006AA450 File Offset: 0x006A8650
		public bool SwitchTrunkingSwitchesPosition3_A9468_HasDiffs
		{
			get
			{
				short num = (short)453539662;
				short num2 = num;
				num = (short)16807758;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2093809664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1049362433;
				if (num != 0)
				{
				}
				num = (short)1511784448;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition3_A9468._HasDiffs;
			}
		}

		// Token: 0x17003CD6 RID: 15574
		// (get) Token: 0x06007628 RID: 30248 RVA: 0x006AA504 File Offset: 0x006A8704
		// (set) Token: 0x06007629 RID: 30249 RVA: 0x006AA5B4 File Offset: 0x006A87B4
		public int SwitchTrunkingSwitchesPosition4_A21534Value
		{
			get
			{
				short num = (short)390414463;
				short num2 = num;
				num = (short)385826943;
				switch (num2 == num)
				{
				default:
				{
					num = (short)917504000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1735917568;
				if (num != 0)
				{
				}
				num = (short)944373761;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition4_A21534.Value;
			}
			set
			{
				short num = (short)381542206;
				short num2 = num;
				num = (short)1538383678;
				switch (num2 == num)
				{
				default:
				{
					num = (short)798359552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)224526337;
				if (num != 0)
				{
				}
				num = (short)847839232;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition4_A21534.Value = value;
			}
		}

		// Token: 0x17003CD7 RID: 15575
		// (get) Token: 0x0600762A RID: 30250 RVA: 0x006AA66C File Offset: 0x006A886C
		// (set) Token: 0x0600762B RID: 30251 RVA: 0x006AA720 File Offset: 0x006A8920
		public string SwitchTrunkingSwitchesPosition4_A21534_UIValue
		{
			get
			{
				short num = (short)1464209306;
				short num2 = num;
				num = (short)240324506;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1139474432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1334181889;
				if (num != 0)
				{
				}
				num = (short)1976369152;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition4_A21534.UIValue;
			}
			set
			{
				short num = (short)1532142727;
				short num2 = num;
				num = (short)1285858439;
				switch (num2 == num)
				{
				default:
				{
					num = (short)782106624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1814757377;
				if (num != 0)
				{
				}
				num = (short)57016320;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition4_A21534.UIValue = value;
			}
		}

		// Token: 0x17003CD8 RID: 15576
		// (get) Token: 0x0600762C RID: 30252 RVA: 0x006AA7D8 File Offset: 0x006A89D8
		public global::AcpBusinessLayer.AcpListField SwitchTrunkingSwitchesPosition4_A21534
		{
			get
			{
				short num = (short)492643663;
				short num2 = num;
				num = (short)36316495;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1472659456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1074921473;
				if (num != 0)
				{
				}
				num = (short)179896320;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition4_A21534;
			}
		}

		// Token: 0x17003CD9 RID: 15577
		// (get) Token: 0x0600762D RID: 30253 RVA: 0x006AA888 File Offset: 0x006A8A88
		// (set) Token: 0x0600762E RID: 30254 RVA: 0x006AA93C File Offset: 0x006A8B3C
		public bool SwitchTrunkingSwitchesPosition4_A21534_Applicable
		{
			get
			{
				short num = (short)1484428169;
				short num2 = num;
				num = (short)947491721;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1604845568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1855651841;
				if (num != 0)
				{
				}
				num = (short)275906560;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition4_A21534.Applicable;
			}
			set
			{
				short num = (short)1485045761;
				if (num != 0)
				{
				}
				num = (short)476119040;
				short num2 = num;
				num = (short)421537358;
				short num3 = num;
				num = (short)1263871566;
				switch (num3 == num)
				{
				}
				num = (short)1534197760;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition4_A21534.Applicable = value;
			}
		}

		// Token: 0x17003CDA RID: 15578
		// (get) Token: 0x0600762F RID: 30255 RVA: 0x006AA9F0 File Offset: 0x006A8BF0
		// (set) Token: 0x06007630 RID: 30256 RVA: 0x006AAAA4 File Offset: 0x006A8CA4
		public bool SwitchTrunkingSwitchesPosition4_A21534_Valid
		{
			get
			{
				short num = (short)1079512250;
				short num2 = num;
				num = (short)1837305018;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1707147264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1699086336;
				if (num != 0)
				{
				}
				num = (short)1055326209;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition4_A21534.Valid;
			}
			set
			{
				short num = (short)840655879;
				short num2 = num;
				num = (short)1200251911;
				switch (num2 == num)
				{
				default:
				{
					num = (short)964755456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)619511809;
				if (num != 0)
				{
				}
				num = (short)1490550784;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition4_A21534.Valid = value;
			}
		}

		// Token: 0x17003CDB RID: 15579
		// (get) Token: 0x06007631 RID: 30257 RVA: 0x006AAB58 File Offset: 0x006A8D58
		// (set) Token: 0x06007632 RID: 30258 RVA: 0x006AAC0C File Offset: 0x006A8E0C
		public bool SwitchTrunkingSwitchesPosition4_A21534_Visible
		{
			get
			{
				short num = (short)1581927242;
				short num2 = num;
				num = (short)1440238410;
				switch (num2 == num)
				{
				default:
				{
					num = (short)804519936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2103836672;
				if (num != 0)
				{
				}
				num = (short)1802174465;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition4_A21534.Visible;
			}
			set
			{
				short num = (short)913047553;
				if (num != 0)
				{
				}
				num = (short)1786380288;
				short num2 = num;
				num = (short)1078857411;
				short num3 = num;
				num = (short)960433859;
				switch (num3 == num)
				{
				}
				num = (short)1250099200;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition4_A21534.Visible = value;
			}
		}

		// Token: 0x17003CDC RID: 15580
		// (get) Token: 0x06007633 RID: 30259 RVA: 0x006AACC4 File Offset: 0x006A8EC4
		// (set) Token: 0x06007634 RID: 30260 RVA: 0x006AAD78 File Offset: 0x006A8F78
		public bool SwitchTrunkingSwitchesPosition4_A21534_Editable
		{
			get
			{
				short num = (short)1239249487;
				short num2 = num;
				num = (short)252473935;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1826357248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1702035457;
				if (num != 0)
				{
				}
				num = (short)1498480640;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition4_A21534.Editable;
			}
			set
			{
				short num = (short)213516289;
				if (num != 0)
				{
				}
				num = (short)663879680;
				short num2 = num;
				num = (short)101075079;
				short num3 = num;
				num = (short)950159495;
				switch (num3 == num)
				{
				}
				num = (short)721616896;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition4_A21534.Editable = value;
			}
		}

		// Token: 0x17003CDD RID: 15581
		// (get) Token: 0x06007635 RID: 30261 RVA: 0x006AAE30 File Offset: 0x006A9030
		internal string SwitchTrunkingSwitchesPosition4_A21534_UILabel
		{
			get
			{
				short num = (short)203062956;
				short num2 = num;
				num = (short)1027833516;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1854406656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)142082049;
				if (num != 0)
				{
				}
				num = (short)7798784;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition4_A21534.UIName;
			}
		}

		// Token: 0x17003CDE RID: 15582
		// (get) Token: 0x06007636 RID: 30262 RVA: 0x006AAEE4 File Offset: 0x006A90E4
		// (set) Token: 0x06007637 RID: 30263 RVA: 0x006AAF98 File Offset: 0x006A9198
		internal bool SwitchTrunkingSwitchesPosition4_A21534_HiddenStatic
		{
			get
			{
				short num = (short)933587888;
				short num2 = num;
				num = (short)33123248;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1884553216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1869479936;
				if (num != 0)
				{
				}
				num = (short)1150877697;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition4_A21534.HiddenStatic;
			}
			set
			{
				short num = (short)313133957;
				short num2 = num;
				num = (short)21367685;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1559691264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1923088384;
				if (num != 0)
				{
				}
				num = (short)970326017;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition4_A21534.HiddenStatic = value;
			}
		}

		// Token: 0x17003CDF RID: 15583
		// (get) Token: 0x06007638 RID: 30264 RVA: 0x006AB050 File Offset: 0x006A9250
		// (set) Token: 0x06007639 RID: 30265 RVA: 0x006AB108 File Offset: 0x006A9308
		internal bool SwitchTrunkingSwitchesPosition4_A21534_HiddenDynamic
		{
			get
			{
				short num = (short)679868397;
				short num2 = num;
				num = (short)1825961965;
				switch (num2 == num)
				{
				default:
				{
					num = (short)658571264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1616379904;
				if (num != 0)
				{
				}
				num = (short)1501822977;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition4_A21534.HiddenDynamic;
			}
			set
			{
				short num = (short)2144683020;
				short num2 = num;
				num = (short)865354764;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1482948608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)463273985;
				if (num != 0)
				{
				}
				num = (short)1557069824;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition4_A21534.HiddenDynamic = value;
			}
		}

		// Token: 0x17003CE0 RID: 15584
		// (get) Token: 0x0600763A RID: 30266 RVA: 0x006AB1BC File Offset: 0x006A93BC
		public bool SwitchTrunkingSwitchesPosition4_A21534_HasDiffs
		{
			get
			{
				short num = (short)118517658;
				short num2 = num;
				num = (short)1228631962;
				switch (num2 == num)
				{
				default:
				{
					num = (short)464453632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)458031105;
				if (num != 0)
				{
				}
				num = (short)1926561792;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition4_A21534._HasDiffs;
			}
		}

		// Token: 0x17003CE1 RID: 15585
		// (get) Token: 0x0600763B RID: 30267 RVA: 0x006AB270 File Offset: 0x006A9470
		// (set) Token: 0x0600763C RID: 30268 RVA: 0x006AB324 File Offset: 0x006A9524
		public int SwitchTrunkingSwitchesPosition5_A21535Value
		{
			get
			{
				short num = (short)1571630769;
				short num2 = num;
				num = (short)1099837105;
				switch (num2 == num)
				{
				default:
				{
					num = (short)939589632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1258029057;
				if (num != 0)
				{
				}
				num = (short)1735720960;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition5_A21535.Value;
			}
			set
			{
				short num = (short)1109528673;
				short num2 = num;
				num = (short)1343361121;
				switch (num2 == num)
				{
				default:
				{
					num = (short)989331456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2114453505;
				if (num != 0)
				{
				}
				num = (short)2123563008;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition5_A21535.Value = value;
			}
		}

		// Token: 0x17003CE2 RID: 15586
		// (get) Token: 0x0600763D RID: 30269 RVA: 0x006AB3DC File Offset: 0x006A95DC
		// (set) Token: 0x0600763E RID: 30270 RVA: 0x006AB490 File Offset: 0x006A9690
		public string SwitchTrunkingSwitchesPosition5_A21535_UIValue
		{
			get
			{
				short num = (short)91393687;
				short num2 = num;
				num = (short)259886743;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1631715328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1100021761;
				if (num != 0)
				{
				}
				num = (short)855048192;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition5_A21535.UIValue;
			}
			set
			{
				short num = (short)2125355178;
				short num2 = num;
				num = (short)658659498;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1123287040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1252851712;
				if (num != 0)
				{
				}
				num = (short)1979711489;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition5_A21535.UIValue = value;
			}
		}

		// Token: 0x17003CE3 RID: 15587
		// (get) Token: 0x0600763F RID: 30271 RVA: 0x006AB548 File Offset: 0x006A9748
		public global::AcpBusinessLayer.AcpListField SwitchTrunkingSwitchesPosition5_A21535
		{
			get
			{
				short num = (short)1691379199;
				short num2 = num;
				num = (short)513500671;
				switch (num2 == num)
				{
				default:
				{
					num = (short)721879040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1070006273;
				if (num != 0)
				{
				}
				num = (short)1871249408;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition5_A21535;
			}
		}

		// Token: 0x17003CE4 RID: 15588
		// (get) Token: 0x06007640 RID: 30272 RVA: 0x006AB5F8 File Offset: 0x006A97F8
		// (set) Token: 0x06007641 RID: 30273 RVA: 0x006AB6AC File Offset: 0x006A98AC
		public bool SwitchTrunkingSwitchesPosition5_A21535_Applicable
		{
			get
			{
				short num = (short)1428303592;
				short num2 = num;
				num = (short)60042984;
				switch (num2 == num)
				{
				default:
				{
					num = (short)29032448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1043922945;
				if (num != 0)
				{
				}
				num = (short)1255211008;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition5_A21535.Applicable;
			}
			set
			{
				short num = (short)2109841636;
				short num2 = num;
				num = (short)1332977892;
				switch (num2 == num)
				{
				default:
				{
					num = (short)184942592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1664090112;
				if (num != 0)
				{
				}
				num = (short)774832129;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition5_A21535.Applicable = value;
			}
		}

		// Token: 0x17003CE5 RID: 15589
		// (get) Token: 0x06007642 RID: 30274 RVA: 0x006AB760 File Offset: 0x006A9960
		// (set) Token: 0x06007643 RID: 30275 RVA: 0x006AB814 File Offset: 0x006A9A14
		public bool SwitchTrunkingSwitchesPosition5_A21535_Valid
		{
			get
			{
				short num = (short)1334265086;
				short num2 = num;
				num = (short)1423721726;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1486684160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1909391360;
				if (num != 0)
				{
				}
				num = (short)1720385537;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition5_A21535.Valid;
			}
			set
			{
				short num = (short)2091471934;
				short num2 = num;
				num = (short)1979601982;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1176961024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)978255873;
				if (num != 0)
				{
				}
				num = (short)996540416;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition5_A21535.Valid = value;
			}
		}

		// Token: 0x17003CE6 RID: 15590
		// (get) Token: 0x06007644 RID: 30276 RVA: 0x006AB8CC File Offset: 0x006A9ACC
		// (set) Token: 0x06007645 RID: 30277 RVA: 0x006AB984 File Offset: 0x006A9B84
		public bool SwitchTrunkingSwitchesPosition5_A21535_Visible
		{
			get
			{
				short num = (short)1460451135;
				short num2 = num;
				num = (short)995866431;
				switch (num2 == num)
				{
				default:
				{
					num = (short)667811840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1507655680;
				if (num != 0)
				{
				}
				num = (short)658178049;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition5_A21535.Visible;
			}
			set
			{
				short num = (short)1906055751;
				short num2 = num;
				num = (short)1364204103;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1302593536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1722023937;
				if (num != 0)
				{
				}
				num = (short)641662976;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition5_A21535.Visible = value;
			}
		}

		// Token: 0x17003CE7 RID: 15591
		// (get) Token: 0x06007646 RID: 30278 RVA: 0x006ABA38 File Offset: 0x006A9C38
		// (set) Token: 0x06007647 RID: 30279 RVA: 0x006ABAEC File Offset: 0x006A9CEC
		public bool SwitchTrunkingSwitchesPosition5_A21535_Editable
		{
			get
			{
				short num = (short)2028036314;
				short num2 = num;
				num = (short)2116247770;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1687289856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)96862209;
				if (num != 0)
				{
				}
				num = (short)374079488;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition5_A21535.Editable;
			}
			set
			{
				short num = (short)52621895;
				short num2 = num;
				num = (short)537260615;
				switch (num2 == num)
				{
				default:
				{
					num = (short)710344704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1432485888;
				if (num != 0)
				{
				}
				num = (short)1407451137;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition5_A21535.Editable = value;
			}
		}

		// Token: 0x17003CE8 RID: 15592
		// (get) Token: 0x06007648 RID: 30280 RVA: 0x006ABBA4 File Offset: 0x006A9DA4
		internal string SwitchTrunkingSwitchesPosition5_A21535_UILabel
		{
			get
			{
				short num = (short)1052684772;
				short num2 = num;
				num = (short)734048740;
				switch (num2 == num)
				{
				default:
				{
					num = (short)383254528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)601620481;
				if (num != 0)
				{
				}
				num = (short)1194590208;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition5_A21535.UIName;
			}
		}

		// Token: 0x17003CE9 RID: 15593
		// (get) Token: 0x06007649 RID: 30281 RVA: 0x006ABC5C File Offset: 0x006A9E5C
		// (set) Token: 0x0600764A RID: 30282 RVA: 0x006ABD0C File Offset: 0x006A9F0C
		internal bool SwitchTrunkingSwitchesPosition5_A21535_HiddenStatic
		{
			get
			{
				short num = (short)831849444;
				short num2 = num;
				num = (short)1052836836;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1155137536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)79888385;
				if (num != 0)
				{
				}
				num = (short)1654980608;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition5_A21535.HiddenStatic;
			}
			set
			{
				short num = (short)1648651457;
				short num2 = num;
				num = (short)2074111169;
				switch (num2 == num)
				{
				default:
				{
					num = (short)763494400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)257032192;
				if (num != 0)
				{
				}
				num = (short)1670774785;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition5_A21535.HiddenStatic = value;
			}
		}

		// Token: 0x17003CEA RID: 15594
		// (get) Token: 0x0600764B RID: 30283 RVA: 0x006ABDC0 File Offset: 0x006A9FC0
		// (set) Token: 0x0600764C RID: 30284 RVA: 0x006ABE74 File Offset: 0x006AA074
		internal bool SwitchTrunkingSwitchesPosition5_A21535_HiddenDynamic
		{
			get
			{
				short num = (short)764975589;
				short num2 = num;
				num = (short)1909955045;
				switch (num2 == num)
				{
				}
				num = (short)975110144;
				short num3 = num;
				num = (short)1772421120;
				if (num != 0)
				{
				}
				num = (short)48955393;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition5_A21535.HiddenDynamic;
			}
			set
			{
				short num = (short)779021432;
				short num2 = num;
				num = (short)2112875640;
				switch (num2 == num)
				{
				}
				num = (short)217972736;
				short num3 = num;
				num = (short)1656750081;
				if (num != 0)
				{
				}
				num = (short)1559298048;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchesPosition5_A21535.HiddenDynamic = value;
			}
		}

		// Token: 0x17003CEB RID: 15595
		// (get) Token: 0x0600764D RID: 30285 RVA: 0x006ABF28 File Offset: 0x006AA128
		public bool SwitchTrunkingSwitchesPosition5_A21535_HasDiffs
		{
			get
			{
				short num = (short)616486624;
				short num2 = num;
				num = (short)1212536544;
				switch (num2 == num)
				{
				}
				num = (short)1821442048;
				short num3 = num;
				num = (short)302448641;
				if (num != 0)
				{
				}
				num = (short)1858404352;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchesPosition5_A21535._HasDiffs;
			}
		}

		// Token: 0x17003CEC RID: 15596
		// (get) Token: 0x0600764E RID: 30286 RVA: 0x006ABFDC File Offset: 0x006AA1DC
		public global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems RefMenuItems
		{
			get
			{
				short num = (short)753022588;
				short num2 = num;
				num = (short)1653749372;
				switch (num2 == num)
				{
				}
				num = (short)1515716608;
				short num3 = num;
				num = (short)446758913;
				if (num != 0)
				{
				}
				num = (short)2050555904;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2088)[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
			}
		}

		// Token: 0x17003CED RID: 15597
		// (get) Token: 0x0600764F RID: 30287 RVA: 0x006AC09C File Offset: 0x006AA29C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)1245472969;
				short num2 = num;
				num = (short)2103142601;
				switch (num2 == num)
				{
				}
				num = (short)1824325632;
				short num3 = num;
				num = (short)1994784769;
				if (num != 0)
				{
				}
				num = (short)465764352;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x17003CEE RID: 15598
		// (get) Token: 0x06007650 RID: 30288 RVA: 0x006AC15C File Offset: 0x006AA35C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)185491794;
				short num2 = num;
				num = (short)168714578;
				switch (num2 == num)
				{
				}
				num = (short)1306329088;
				short num3 = num;
				num = (short)1155661825;
				if (num != 0)
				{
				}
				num = (short)850460672;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06007651 RID: 30289 RVA: 0x006AC218 File Offset: 0x006AA418
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_9A;
			}
			short num;
			int num4;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)212205568;
				short num2 = num;
				num = (short)2094689552;
				short num3 = num;
				num = (short)714173712;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)369885184;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						goto IL_100;
					case 1:
						num = (short)381878275;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (base.ParentRecset != null)
						{
							goto IL_BE;
						}
						goto IL_141;
					case 3:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)310640644;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_141;
					case 4:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)899809280;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9A;
				}
				IL_BE:
				num = (short)1771438081;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_100:
			IL_141:
			num = (short)537919489;
			if (num != 0)
			{
			}
			return result;
			IL_9A:
			result = null;
			num = (short)1592590338;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04003080 RID: 12416
		private global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition1_A9466;

		// Token: 0x04003081 RID: 12417
		private global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition2_A9467;

		// Token: 0x04003082 RID: 12418
		private global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition3_A9468;

		// Token: 0x04003083 RID: 12419
		private global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition4_A21534;

		// Token: 0x04003084 RID: 12420
		private global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition5_A21535;
	}
}
