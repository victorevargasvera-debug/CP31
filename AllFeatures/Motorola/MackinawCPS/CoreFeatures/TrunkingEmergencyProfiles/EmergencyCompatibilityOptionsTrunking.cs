using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles
{
	// Token: 0x02000478 RID: 1144
	[global::System.Serializable]
	public class EmergencyCompatibilityOptionsTrunking : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009600 RID: 38400 RVA: 0x008D09C0 File Offset: 0x008CEBC0
		public EmergencyCompatibilityOptionsTrunking(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06009601 RID: 38401 RVA: 0x008D09DC File Offset: 0x008CEBDC
		protected EmergencyCompatibilityOptionsTrunking(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009602 RID: 38402 RVA: 0x008D09F4 File Offset: 0x008CEBF4
		public override void Init()
		{
			int a_ = 6;
			short num = (short)999424000;
			short num2 = num;
			num = (short)41705007;
			short num3 = num;
			num = (short)1690918447;
			switch (num3 == num)
			{
			}
			num = (short)1028063232;
			if (num != 0)
			{
			}
			num = (short)272826369;
			if (num != 0)
			{
			}
			this.emergencyExitControl_43341 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苆꓈껊뿌꣎듐뷒뛔껖鳘ꏚ드ꯞꋠ賢诤鏦鯨蓪臬냮연샲웴쏶죸", a_), global::CommonResources.AcgResources.ID_EMERGENCYEXITCONTROL, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.EmergencyExitControl_43341LovStrs);
			this.emergencyExitControl_43341.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emergencyExitControl_43341.DataTransferOrder = 1;
			this.emergencyHotMicRestart_43342 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苆꓈껊뿌꣎듐뷒뛔껖釘듚꧜鋞裠胢럤苦髨鿪賬鷮藰곲쇴쓶쫸쿺쿼", a_), global::CommonResources.AcgResources.ID_EMERGENCYHOTMICRESTART);
			this.emergencyHotMicRestart_43342.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emergencyHotMicRestart_43342.DataTransferOrder = 2;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苆꓈껊뿌꣎듐뷒뛔껖律飚닜닞釠苢釤軦诨苪臬蛮藰諲헴룶觸迺铼郾漀瀂", a_);
			base.Id = 10845;
			base.UIName = global::CommonResources.AcgResources.ID_EMERGENCYCOMPATIBILITYOPTIONS;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06009603 RID: 38403 RVA: 0x008D0B4C File Offset: 0x008CED4C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 13;
			short num = (short)1836056577;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1207107584;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_EE;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_7E;
					}
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("词뷏럑ꛓ뇕뷗듙뿛꟝꣟跡郣ꯥ臧觩뻫语華蛱闳蓵賷ꗹ죻췽㏿㘁㘃", a_)))
					{
						num = (short)489095172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_291;
				case 3:
				{
					num = (short)2088211756;
					short num4 = num;
					num = (short)1108579628;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13D;
					default:
						num = (short)2121465856;
						if (num != 0)
						{
						}
						num = (short)1818165254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					this.emergencyHotMicRestart_43342 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("词뷏럑ꛓ뇕뷗듙뿛꟝꣟跡郣ꯥ臧觩뻫语華蛱闳蓵賷ꗹ죻췽㏿㘁㘃", a_), global::CommonResources.AcgResources.ID_EMERGENCYHOTMICRESTART);
					this.emergencyHotMicRestart_43342.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emergencyHotMicRestart_43342.DataTransferOrder = 2;
					num = (short)1839923207;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("词뷏럑ꛓ뇕뷗듙뿛꟝ꗟ髡跣鋥ꯧ藩苫髭苯鷱飳꧵쳷짹쿻쫽ㇿ", a_)))
					{
						num = (short)1442185224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EE;
				case 6:
					if (producerFields != null)
					{
						num = (short)1659371529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_291;
				case 7:
					goto IL_21C;
				case 8:
					num = (short)1039728641;
					if (num != 0)
					{
					}
					goto IL_13D;
				case 9:
					num = (short)362872837;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_7E:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)591331331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_EE:
				num = (short)167575554;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_13D:
				this.emergencyExitControl_43341 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("词뷏럑ꛓ뇕뷗듙뿛꟝ꗟ髡跣鋥ꯧ藩苫髭苯鷱飳꧵쳷짹쿻쫽ㇿ", a_), global::CommonResources.AcgResources.ID_EMERGENCYEXITCONTROL, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.EmergencyExitControl_43341LovStrs);
				this.emergencyExitControl_43341.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
				this.emergencyExitControl_43341.DataTransferOrder = 1;
				num = (short)1572208640;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_21C:
			IL_291:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("词뷏럑ꛓ뇕뷗듙뿛꟝샟ꇡ诣该飧诩飫蟭鋯鯱飳鿵賷菹\udcfb뇽烿瘁洃椅昇礉", a_);
			base.Id = 10845;
			base.UIName = global::CommonResources.AcgResources.ID_EMERGENCYCOMPATIBILITYOPTIONS;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06009604 RID: 38404 RVA: 0x008D0E1C File Offset: 0x008CF01C
		public override void PopulateReferences()
		{
			short num = (short)1685848064;
			short num2 = num;
			num = (short)1623749513;
			short num3 = num;
			num = (short)636646281;
			switch (num3 == num)
			{
			}
			num = (short)210239489;
			if (num != 0)
			{
			}
			num = (short)2034302976;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009605 RID: 38405 RVA: 0x008D0EC8 File Offset: 0x008CF0C8
		public override void DropReferences()
		{
			short num = (short)1104543744;
			short num2 = num;
			num = (short)894778077;
			short num3 = num;
			num = (short)1643002589;
			switch (num3 == num)
			{
			}
			num = (short)554303489;
			if (num != 0)
			{
			}
			num = (short)955121664;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009606 RID: 38406 RVA: 0x008D0F70 File Offset: 0x008CF170
		public override void SetConstraints()
		{
			short num = (short)2131296256;
			short num2 = num;
			num = (short)664124183;
			short num3 = num;
			num = (short)2004400919;
			switch (num3 == num)
			{
			}
			num = (short)1595277313;
			if (num != 0)
			{
			}
			num = (short)1611792384;
			if (num != 0)
			{
			}
			this.emergencyExitControl_43341.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.ConValidateTrunSysConsoleEmergExitContr);
			this.emergencyHotMicRestart_43342.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.ConTrunkEmerHotMicRestartIsApplicable);
		}

		// Token: 0x06009607 RID: 38407 RVA: 0x008D1048 File Offset: 0x008CF248
		public override void SetupDependencies()
		{
			short num = (short)216465408;
			short num2 = num;
			num = (short)1235393555;
			short num3 = num;
			num = (short)2079497235;
			switch (num3 == num)
			{
			}
			num = (short)2096496640;
			if (num != 0)
			{
			}
			num = (short)729088001;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles trunkingEmergencyProfiles = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles;
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.emergencyExitControl_43341);
			trunkingEmergencyProfiles.General.TrkEmerProfGeneralEmergencyOperation_A7926.AddDependentObject(this.emergencyHotMicRestart_43342);
			trunkingEmergencyProfiles.General.TrkEmerProEmergencyAutoTransmitMode_A22567.AddDependentObject(this.emergencyHotMicRestart_43342);
		}

		// Token: 0x17004B52 RID: 19282
		// (get) Token: 0x06009608 RID: 38408 RVA: 0x008D1144 File Offset: 0x008CF344
		public bool HasDiffs
		{
			get
			{
				short num = (short)1046740992;
				short num2 = num;
				num = (short)1577523575;
				short num3 = num;
				num = (short)1276975479;
				switch (num3 == num)
				{
				}
				num = (short)795738112;
				if (num != 0)
				{
				}
				num = (short)618266625;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004B53 RID: 19283
		// (get) Token: 0x06009609 RID: 38409 RVA: 0x008D11F4 File Offset: 0x008CF3F4
		// (set) Token: 0x0600960A RID: 38410 RVA: 0x008D12A8 File Offset: 0x008CF4A8
		public int EmergencyExitControl_43341Value
		{
			get
			{
				short num = (short)1227554816;
				short num2 = num;
				num = (short)1189178868;
				short num3 = num;
				num = (short)1677159924;
				switch (num3 == num)
				{
				}
				num = (short)277217281;
				if (num != 0)
				{
				}
				num = (short)357761024;
				if (num != 0)
				{
				}
				return this.emergencyExitControl_43341.Value;
			}
			set
			{
				short num = (short)1310064640;
				short num2 = num;
				num = (short)1419576471;
				short num3 = num;
				num = (short)786826391;
				switch (num3 == num)
				{
				}
				num = (short)1090519041;
				if (num != 0)
				{
				}
				num = (short)1566965760;
				if (num != 0)
				{
				}
				this.emergencyExitControl_43341.Value = value;
			}
		}

		// Token: 0x17004B54 RID: 19284
		// (get) Token: 0x0600960B RID: 38411 RVA: 0x008D135C File Offset: 0x008CF55C
		// (set) Token: 0x0600960C RID: 38412 RVA: 0x008D1410 File Offset: 0x008CF610
		public string EmergencyExitControl_43341_UIValue
		{
			get
			{
				short num = (short)1441529856;
				short num2 = num;
				num = (short)1666131379;
				short num3 = num;
				num = (short)1394484659;
				switch (num3 == num)
				{
				}
				num = (short)1624440833;
				if (num != 0)
				{
				}
				num = (short)2109734912;
				if (num != 0)
				{
				}
				return this.emergencyExitControl_43341.UIValue;
			}
			set
			{
				short num = (short)171311104;
				short num2 = num;
				num = (short)376020770;
				short num3 = num;
				num = (short)958963490;
				switch (num3 == num)
				{
				}
				num = (short)1528692737;
				if (num != 0)
				{
				}
				num = (short)60358656;
				if (num != 0)
				{
				}
				this.emergencyExitControl_43341.UIValue = value;
			}
		}

		// Token: 0x17004B55 RID: 19285
		// (get) Token: 0x0600960D RID: 38413 RVA: 0x008D14C4 File Offset: 0x008CF6C4
		public global::AcpBusinessLayer.AcpListField EmergencyExitControl_43341
		{
			get
			{
				short num = (short)2083192832;
				short num2 = num;
				num = (short)1308812067;
				short num3 = num;
				num = (short)1764680483;
				switch (num3 == num)
				{
				}
				num = (short)2111569921;
				if (num != 0)
				{
				}
				num = (short)1743060992;
				if (num != 0)
				{
				}
				return this.emergencyExitControl_43341;
			}
		}

		// Token: 0x17004B56 RID: 19286
		// (get) Token: 0x0600960E RID: 38414 RVA: 0x008D1574 File Offset: 0x008CF774
		// (set) Token: 0x0600960F RID: 38415 RVA: 0x008D1624 File Offset: 0x008CF824
		public bool EmergencyExitControl_43341_Applicable
		{
			get
			{
				short num = (short)1684275200;
				short num2 = num;
				num = (short)1469521225;
				short num3 = num;
				num = (short)425991497;
				switch (num3 == num)
				{
				}
				num = (short)1787232256;
				if (num != 0)
				{
				}
				num = (short)47841281;
				if (num != 0)
				{
				}
				return this.emergencyExitControl_43341.Applicable;
			}
			set
			{
				short num = (short)1187905536;
				short num2 = num;
				num = (short)1586396281;
				short num3 = num;
				num = (short)1148025977;
				switch (num3 == num)
				{
				}
				num = (short)1177550849;
				if (num != 0)
				{
				}
				num = (short)1128660992;
				if (num != 0)
				{
				}
				this.emergencyExitControl_43341.Applicable = value;
			}
		}

		// Token: 0x17004B57 RID: 19287
		// (get) Token: 0x06009610 RID: 38416 RVA: 0x008D16DC File Offset: 0x008CF8DC
		// (set) Token: 0x06009611 RID: 38417 RVA: 0x008D1794 File Offset: 0x008CF994
		public bool EmergencyExitControl_43341_Valid
		{
			get
			{
				short num = (short)1641021440;
				short num2 = num;
				num = (short)2070880833;
				short num3 = num;
				num = (short)571548225;
				switch (num3 == num)
				{
				}
				num = (short)1767571457;
				if (num != 0)
				{
				}
				num = (short)1877082112;
				if (num != 0)
				{
				}
				return this.emergencyExitControl_43341.Valid;
			}
			set
			{
				short num = (short)608894976;
				short num2 = num;
				num = (short)1094341350;
				short num3 = num;
				num = (short)265573094;
				switch (num3 == num)
				{
				}
				num = (short)428539904;
				if (num != 0)
				{
				}
				num = (short)1206452225;
				if (num != 0)
				{
				}
				this.emergencyExitControl_43341.Valid = value;
			}
		}

		// Token: 0x17004B58 RID: 19288
		// (get) Token: 0x06009612 RID: 38418 RVA: 0x008D1848 File Offset: 0x008CFA48
		// (set) Token: 0x06009613 RID: 38419 RVA: 0x008D18FC File Offset: 0x008CFAFC
		public bool EmergencyExitControl_43341_Visible
		{
			get
			{
				short num = (short)156208527;
				short num2 = num;
				num = (short)728075663;
				switch (num2 == num)
				{
				}
				num = (short)801832961;
				if (num != 0)
				{
				}
				num = (short)1663369216;
				short num3 = num;
				num = (short)738066432;
				if (num != 0)
				{
				}
				return this.emergencyExitControl_43341.Visible;
			}
			set
			{
				short num = (short)283459214;
				short num2 = num;
				num = (short)960577166;
				switch (num2 == num)
				{
				}
				num = (short)1007091712;
				if (num != 0)
				{
				}
				num = (short)405012480;
				short num3 = num;
				num = (short)1703937;
				if (num != 0)
				{
				}
				this.emergencyExitControl_43341.Visible = value;
			}
		}

		// Token: 0x17004B59 RID: 19289
		// (get) Token: 0x06009614 RID: 38420 RVA: 0x008D19B4 File Offset: 0x008CFBB4
		// (set) Token: 0x06009615 RID: 38421 RVA: 0x008D1A68 File Offset: 0x008CFC68
		public bool EmergencyExitControl_43341_Editable
		{
			get
			{
				short num = (short)133769134;
				short num2 = num;
				num = (short)2019043246;
				switch (num2 == num)
				{
				}
				num = (short)711065601;
				if (num != 0)
				{
				}
				num = (short)1446772736;
				short num3 = num;
				num = (short)1271791616;
				if (num != 0)
				{
				}
				return this.emergencyExitControl_43341.Editable;
			}
			set
			{
				short num = (short)527048156;
				short num2 = num;
				num = (short)40705500;
				switch (num2 == num)
				{
				}
				num = (short)1384513536;
				if (num != 0)
				{
				}
				num = (short)230621184;
				short num3 = num;
				num = (short)464846849;
				if (num != 0)
				{
				}
				this.emergencyExitControl_43341.Editable = value;
			}
		}

		// Token: 0x17004B5A RID: 19290
		// (get) Token: 0x06009616 RID: 38422 RVA: 0x008D1B1C File Offset: 0x008CFD1C
		internal string EmergencyExitControl_43341_UILabel
		{
			get
			{
				short num = (short)1026521351;
				short num2 = num;
				num = (short)1556904199;
				switch (num2 == num)
				{
				}
				num = (short)1165950976;
				short num3 = num;
				num = (short)1315700737;
				if (num != 0)
				{
				}
				num = (short)736493568;
				if (num != 0)
				{
				}
				return this.emergencyExitControl_43341.UIName;
			}
		}

		// Token: 0x17004B5B RID: 19291
		// (get) Token: 0x06009617 RID: 38423 RVA: 0x008D1BD4 File Offset: 0x008CFDD4
		// (set) Token: 0x06009618 RID: 38424 RVA: 0x008D1C88 File Offset: 0x008CFE88
		internal bool EmergencyExitControl_43341_HiddenStatic
		{
			get
			{
				short num = (short)223031241;
				short num2 = num;
				num = (short)1996304329;
				switch (num2 == num)
				{
				}
				num = (short)832176128;
				short num3 = num;
				num = (short)189726721;
				if (num != 0)
				{
				}
				num = (short)356581376;
				if (num != 0)
				{
				}
				return this.emergencyExitControl_43341.HiddenStatic;
			}
			set
			{
				short num = (short)1872028699;
				short num2 = num;
				num = (short)1974199323;
				switch (num2 == num)
				{
				}
				num = (short)882835456;
				short num3 = num;
				num = (short)280690689;
				if (num != 0)
				{
				}
				num = (short)532217856;
				if (num != 0)
				{
				}
				this.emergencyExitControl_43341.HiddenStatic = value;
			}
		}

		// Token: 0x17004B5C RID: 19292
		// (get) Token: 0x06009619 RID: 38425 RVA: 0x008D1D40 File Offset: 0x008CFF40
		// (set) Token: 0x0600961A RID: 38426 RVA: 0x008D1DF4 File Offset: 0x008CFFF4
		internal bool EmergencyExitControl_43341_HiddenDynamic
		{
			get
			{
				short num = (short)2122130804;
				short num2 = num;
				num = (short)1240933748;
				switch (num2 == num)
				{
				}
				num = (short)1989279744;
				short num3 = num;
				num = (short)990511105;
				if (num != 0)
				{
				}
				num = (short)1193476096;
				if (num != 0)
				{
				}
				return this.emergencyExitControl_43341.HiddenDynamic;
			}
			set
			{
				short num = (short)1159790593;
				if (num != 0)
				{
				}
				num = (short)1361226829;
				short num2 = num;
				num = (short)521972813;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1784479744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1838612480;
				if (num != 0)
				{
				}
				this.emergencyExitControl_43341.HiddenDynamic = value;
			}
		}

		// Token: 0x17004B5D RID: 19293
		// (get) Token: 0x0600961B RID: 38427 RVA: 0x008D1EAC File Offset: 0x008D00AC
		public bool EmergencyExitControl_43341_HasDiffs
		{
			get
			{
				short num = (short)117899265;
				if (num != 0)
				{
				}
				num = (short)193442779;
				short num2 = num;
				num = (short)1925559259;
				switch (num2 == num)
				{
				default:
				{
					num = (short)947781632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)666304512;
				if (num != 0)
				{
				}
				return this.emergencyExitControl_43341._HasDiffs;
			}
		}

		// Token: 0x17004B5E RID: 19294
		// (get) Token: 0x0600961C RID: 38428 RVA: 0x008D1F60 File Offset: 0x008D0160
		// (set) Token: 0x0600961D RID: 38429 RVA: 0x008D2014 File Offset: 0x008D0214
		public bool EmergencyHotMicRestart_43342Value
		{
			get
			{
				short num = (short)562133001;
				short num2 = num;
				num = (short)1554937865;
				switch (num2 == num)
				{
				}
				num = (short)863371264;
				short num3 = num;
				num = (short)809566208;
				if (num != 0)
				{
				}
				num = (short)1332346881;
				if (num != 0)
				{
				}
				return this.emergencyHotMicRestart_43342.Value;
			}
			set
			{
				short num = (short)841042405;
				short num2 = num;
				num = (short)1353009637;
				switch (num2 == num)
				{
				}
				num = (short)502530048;
				short num3 = num;
				num = (short)150994944;
				if (num != 0)
				{
				}
				num = (short)785383425;
				if (num != 0)
				{
				}
				this.emergencyHotMicRestart_43342.Value = value;
			}
		}

		// Token: 0x17004B5F RID: 19295
		// (get) Token: 0x0600961E RID: 38430 RVA: 0x008D20C8 File Offset: 0x008D02C8
		public global::AcpBusinessLayer.AcpField<bool> EmergencyHotMicRestart_43342
		{
			get
			{
				short num = (short)791347201;
				if (num != 0)
				{
				}
				num = (short)1768395017;
				short num2 = num;
				num = (short)239898889;
				switch (num2 == num)
				{
				default:
				{
					num = (short)609943552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1551892480;
				if (num != 0)
				{
				}
				return this.emergencyHotMicRestart_43342;
			}
		}

		// Token: 0x17004B60 RID: 19296
		// (get) Token: 0x0600961F RID: 38431 RVA: 0x008D2178 File Offset: 0x008D0378
		// (set) Token: 0x06009620 RID: 38432 RVA: 0x008D2230 File Offset: 0x008D0430
		public bool EmergencyHotMicRestart_43342_UIValue
		{
			get
			{
				short num = (short)1630651810;
				short num2 = num;
				num = (short)1581696418;
				switch (num2 == num)
				{
				}
				num = (short)155910144;
				short num3 = num;
				num = (short)948502529;
				if (num != 0)
				{
				}
				num = (short)815923200;
				if (num != 0)
				{
				}
				return this.emergencyHotMicRestart_43342.Value;
			}
			set
			{
				short num = (short)1286282159;
				short num2 = num;
				num = (short)45423535;
				switch (num2 == num)
				{
				}
				num = (short)1951268864;
				short num3 = num;
				num = (short)1383202817;
				if (num != 0)
				{
				}
				num = (short)2055077888;
				if (num != 0)
				{
				}
				this.emergencyHotMicRestart_43342.Value = value;
			}
		}

		// Token: 0x17004B61 RID: 19297
		// (get) Token: 0x06009621 RID: 38433 RVA: 0x008D22E4 File Offset: 0x008D04E4
		// (set) Token: 0x06009622 RID: 38434 RVA: 0x008D2398 File Offset: 0x008D0598
		public bool EmergencyHotMicRestart_43342_Applicable
		{
			get
			{
				short num = (short)1719390594;
				short num2 = num;
				num = (short)387764610;
				switch (num2 == num)
				{
				}
				num = (short)431554560;
				short num3 = num;
				num = (short)715259905;
				if (num != 0)
				{
				}
				num = (short)1100611584;
				if (num != 0)
				{
				}
				return this.emergencyHotMicRestart_43342.Applicable;
			}
			set
			{
				short num = (short)21024866;
				short num2 = num;
				num = (short)525193314;
				switch (num2 == num)
				{
				}
				num = (short)1431961600;
				short num3 = num;
				num = (short)832372737;
				if (num != 0)
				{
				}
				num = (short)1716387840;
				if (num != 0)
				{
				}
				this.emergencyHotMicRestart_43342.Applicable = value;
			}
		}

		// Token: 0x17004B62 RID: 19298
		// (get) Token: 0x06009623 RID: 38435 RVA: 0x008D244C File Offset: 0x008D064C
		// (set) Token: 0x06009624 RID: 38436 RVA: 0x008D2500 File Offset: 0x008D0700
		public bool EmergencyHotMicRestart_43342_Valid
		{
			get
			{
				short num = (short)562061866;
				short num2 = num;
				num = (short)1803837994;
				switch (num2 == num)
				{
				}
				num = (short)151715840;
				short num3 = num;
				num = (short)31981569;
				if (num != 0)
				{
				}
				num = (short)121962496;
				if (num != 0)
				{
				}
				return this.emergencyHotMicRestart_43342.Valid;
			}
			set
			{
				short num = (short)1256278129;
				short num2 = num;
				num = (short)890325105;
				switch (num2 == num)
				{
				}
				num = (short)1110769664;
				short num3 = num;
				num = (short)1362231296;
				if (num != 0)
				{
				}
				num = (short)829554689;
				if (num != 0)
				{
				}
				this.emergencyHotMicRestart_43342.Valid = value;
			}
		}

		// Token: 0x17004B63 RID: 19299
		// (get) Token: 0x06009625 RID: 38437 RVA: 0x008D25B8 File Offset: 0x008D07B8
		// (set) Token: 0x06009626 RID: 38438 RVA: 0x008D266C File Offset: 0x008D086C
		public bool EmergencyHotMicRestart_43342_Visible
		{
			get
			{
				short num = (short)1617759273;
				short num2 = num;
				num = (short)295504937;
				switch (num2 == num)
				{
				}
				num = (short)2060779520;
				short num3 = num;
				num = (short)2016870401;
				if (num != 0)
				{
				}
				num = (short)2084372480;
				if (num != 0)
				{
				}
				return this.emergencyHotMicRestart_43342.Visible;
			}
			set
			{
				short num = (short)642215497;
				short num2 = num;
				num = (short)1121676873;
				switch (num2 == num)
				{
				}
				num = (short)1314062336;
				short num3 = num;
				num = (short)234618881;
				if (num != 0)
				{
				}
				num = (short)975634432;
				if (num != 0)
				{
				}
				this.emergencyHotMicRestart_43342.Visible = value;
			}
		}

		// Token: 0x17004B64 RID: 19300
		// (get) Token: 0x06009627 RID: 38439 RVA: 0x008D2720 File Offset: 0x008D0920
		// (set) Token: 0x06009628 RID: 38440 RVA: 0x008D27D8 File Offset: 0x008D09D8
		public bool EmergencyHotMicRestart_43342_Editable
		{
			get
			{
				short num = (short)150131662;
				short num2 = num;
				num = (short)810406862;
				switch (num2 == num)
				{
				}
				num = (short)805371904;
				short num3 = num;
				num = (short)203227137;
				if (num != 0)
				{
				}
				num = (short)236716032;
				if (num != 0)
				{
				}
				return this.emergencyHotMicRestart_43342.Editable;
			}
			set
			{
				short num = (short)1327775897;
				short num2 = num;
				num = (short)170737817;
				switch (num2 == num)
				{
				}
				num = (short)868024320;
				short num3 = num;
				num = (short)404750336;
				if (num != 0)
				{
				}
				num = (short)163250177;
				if (num != 0)
				{
				}
				this.emergencyHotMicRestart_43342.Editable = value;
			}
		}

		// Token: 0x17004B65 RID: 19301
		// (get) Token: 0x06009629 RID: 38441 RVA: 0x008D288C File Offset: 0x008D0A8C
		internal string EmergencyHotMicRestart_43342_UILabel
		{
			get
			{
				short num = (short)152266378;
				short num2 = num;
				num = (short)659121802;
				switch (num2 == num)
				{
				}
				num = (short)1661861888;
				short num3 = num;
				num = (short)1671299073;
				if (num != 0)
				{
				}
				num = (short)1099759616;
				if (num != 0)
				{
				}
				return this.emergencyHotMicRestart_43342.UIName;
			}
		}

		// Token: 0x17004B66 RID: 19302
		// (get) Token: 0x0600962A RID: 38442 RVA: 0x008D2940 File Offset: 0x008D0B40
		// (set) Token: 0x0600962B RID: 38443 RVA: 0x008D29F4 File Offset: 0x008D0BF4
		internal bool EmergencyHotMicRestart_43342_HiddenStatic
		{
			get
			{
				short num = (short)41222145;
				if (num != 0)
				{
				}
				num = (short)198390312;
				short num2 = num;
				num = (short)1653027368;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1421803520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1391460352;
				if (num != 0)
				{
				}
				return this.emergencyHotMicRestart_43342.HiddenStatic;
			}
			set
			{
				short num = (short)68550657;
				if (num != 0)
				{
				}
				num = (short)1032042867;
				short num2 = num;
				num = (short)1909504371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1146552320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1341718528;
				if (num != 0)
				{
				}
				this.emergencyHotMicRestart_43342.HiddenStatic = value;
			}
		}

		// Token: 0x17004B67 RID: 19303
		// (get) Token: 0x0600962C RID: 38444 RVA: 0x008D2AAC File Offset: 0x008D0CAC
		// (set) Token: 0x0600962D RID: 38445 RVA: 0x008D2B60 File Offset: 0x008D0D60
		internal bool EmergencyHotMicRestart_43342_HiddenDynamic
		{
			get
			{
				short num = (short)1347818851;
				short num2 = num;
				num = (short)1127945571;
				switch (num2 == num)
				{
				}
				num = (short)567410688;
				short num3 = num;
				num = (short)874971137;
				if (num != 0)
				{
				}
				num = (short)708247552;
				if (num != 0)
				{
				}
				return this.emergencyHotMicRestart_43342.HiddenDynamic;
			}
			set
			{
				short num = (short)1194163521;
				short num2 = num;
				num = (short)127302977;
				switch (num2 == num)
				{
				}
				num = (short)699924480;
				short num3 = num;
				num = (short)555483137;
				if (num != 0)
				{
				}
				num = (short)1866792960;
				if (num != 0)
				{
				}
				this.emergencyHotMicRestart_43342.HiddenDynamic = value;
			}
		}

		// Token: 0x17004B68 RID: 19304
		// (get) Token: 0x0600962E RID: 38446 RVA: 0x008D2C18 File Offset: 0x008D0E18
		public bool EmergencyHotMicRestart_43342_HasDiffs
		{
			get
			{
				short num = (short)1499313032;
				short num2 = num;
				num = (short)588886920;
				switch (num2 == num)
				{
				}
				num = (short)495321088;
				short num3 = num;
				num = (short)1033699329;
				if (num != 0)
				{
				}
				num = (short)367198208;
				if (num != 0)
				{
				}
				return this.emergencyHotMicRestart_43342._HasDiffs;
			}
		}

		// Token: 0x17004B69 RID: 19305
		// (get) Token: 0x0600962F RID: 38447 RVA: 0x008D2CCC File Offset: 0x008D0ECC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1535937640;
				short num2 = num;
				num = (short)1612352616;
				switch (num2 == num)
				{
				}
				num = (short)331350016;
				short num3 = num;
				num = (short)103940097;
				if (num != 0)
				{
				}
				num = (short)1126825984;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06009630 RID: 38448 RVA: 0x008D2D8C File Offset: 0x008D0F8C
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
					num2 = (short)298582018;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1103953921;
						if (num2 != 0)
						{
						}
						num2 = (short)1820983299;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)501874688;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)1467088896;
					short num3 = num2;
					num2 = (short)27287742;
					short num4 = num2;
					num2 = (short)374956222;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)18546688;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset == null)
						{
							return result;
						}
						break;
					}
					num2 = (short)525991937;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1834876932;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04004A3D RID: 19005
		private global::AcpBusinessLayer.AcpListField emergencyExitControl_43341;

		// Token: 0x04004A3E RID: 19006
		private global::AcpBusinessLayer.AcpField<bool> emergencyHotMicRestart_43342;
	}
}
