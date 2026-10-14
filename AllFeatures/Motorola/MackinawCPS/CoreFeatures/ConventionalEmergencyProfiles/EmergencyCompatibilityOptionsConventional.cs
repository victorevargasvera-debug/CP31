using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles
{
	// Token: 0x020004A0 RID: 1184
	[global::System.Serializable]
	public class EmergencyCompatibilityOptionsConventional : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009ACB RID: 39627 RVA: 0x009115B0 File Offset: 0x0090F7B0
		public EmergencyCompatibilityOptionsConventional(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06009ACC RID: 39628 RVA: 0x009115CC File Offset: 0x0090F7CC
		protected EmergencyCompatibilityOptionsConventional(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009ACD RID: 39629 RVA: 0x009115E4 File Offset: 0x0090F7E4
		public override void Init()
		{
			int a_ = 5;
			short num = (short)697633507;
			short num2 = num;
			num = (short)205589219;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1103429632;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1255997440;
			if (num != 0)
			{
			}
			num = (short)971440129;
			if (num != 0)
			{
			}
			this.emergencyHotMicReStart_43343 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("菅ꗇ꿉뻋꧍뗏병럓꿕郗뗙꣛鏝觟臡뛣菥믧黩跫鳭蓯귱샳엵쯷컹쿻", a_), global::CommonResources.AcgResources.ID_EMERGENCYHOTMICRESTART);
			this.emergencyHotMicReStart_43343.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emergencyHotMicReStart_43343.DataTransferOrder = 2;
			this.emergencyExitControl_43344 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("菅ꗇ꿉뻋꧍뗏병럓꿕鷗ꋙ뗛ꫝꏟ跡諣鋥髧藩胫뇭쓯쇱쟳싵쳷", a_), global::CommonResources.AcgResources.ID_EMERGENCYEXITCONTROL, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.EmergencyExitControl_43344LovStrs);
			this.emergencyExitControl_43344.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emergencyExitControl_43344.DataTransferOrder = 1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菅ꗇ꿉뻋꧍뗏병럓꿕駙돛돝郟菡郣迥諧菩胫蟭蓯诱퓳맵裷軹闻釽滿焁", a_);
			base.Id = 10846;
			base.UIName = global::CommonResources.AcgResources.ID_EMERGENCYCOMPATIBILITYOPTIONS;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06009ACE RID: 39630 RVA: 0x00911740 File Offset: 0x0090F940
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)471007238;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_23D;
				case 1:
					num = (short)222625793;
					if (num != 0)
					{
					}
					this.emergencyExitControl_43344 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("賈ꛊ꣌뷎뛐뛒믔듖ꃘ黚ꗜ뛞闠ꃢ諤触鷨駪苬菮껰쟲웴쓶췸쿺", a_), global::CommonResources.AcgResources.ID_EMERGENCYEXITCONTROL, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.EmergencyExitControl_43344LovStrs);
					this.emergencyExitControl_43344.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emergencyExitControl_43344.DataTransferOrder = 1;
					goto IL_226;
				case 2:
					if (producerFields != null)
					{
						num = (short)1837301763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28E;
				case 3:
				{
					num = (short)1292453041;
					short num3 = num;
					num = (short)634012849;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_226;
					default:
					{
						num = (short)464781312;
						if (num != 0)
						{
						}
						num = (short)1406599168;
						short num4 = num;
						num = (short)1223950340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賈ꛊ꣌뷎뛐뛒믔듖ꃘ鏚닜ꯞ고諢蛤뗦賨룪駬軮菰蟲ꫴ쏶쫸죺짼쳾", a_)))
					{
						num = (short)796590088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_78;
				case 5:
					num = (short)968425474;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賈ꛊ꣌뷎뛐뛒믔듖ꃘ黚ꗜ뛞闠ꃢ諤触鷨駪苬菮껰쟲웴쓶췸쿺", a_)))
					{
						num = (short)227606529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28E;
				case 8:
					this.emergencyHotMicReStart_43343 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("賈ꛊ꣌뷎뛐뛒믔듖ꃘ鏚닜ꯞ고諢蛤뗦賨룪駬軮菰蟲ꫴ쏶쫸죺짼쳾", a_), global::CommonResources.AcgResources.ID_EMERGENCYHOTMICRESTART);
					this.emergencyHotMicReStart_43343.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emergencyHotMicReStart_43343.DataTransferOrder = 2;
					num = (short)934084617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_78;
				}
				IL_55:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)179372037;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_78:
				num = (short)1752498183;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_226:
				num = (short)1113653248;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_23D:
			IL_28E:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("賈ꛊ꣌뷎뛐뛒믔듖ꃘﯚ黜냞賠鏢蓤鏦胨觪蓬菮飰蟲賴ퟶ뛸诺觼雾渀洂瘄", a_);
			base.Id = 10846;
			base.UIName = global::CommonResources.AcgResources.ID_EMERGENCYCOMPATIBILITYOPTIONS;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06009ACF RID: 39631 RVA: 0x00911A0C File Offset: 0x0090FC0C
		public override void PopulateReferences()
		{
			short num = (short)1032905253;
			short num2 = num;
			num = (short)808968741;
			switch (num2 == num)
			{
			default:
			{
				num = (short)740556800;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1569980417;
			if (num != 0)
			{
			}
			num = (short)1408172032;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009AD0 RID: 39632 RVA: 0x00911AB8 File Offset: 0x0090FCB8
		public override void DropReferences()
		{
			short num = (short)1423062708;
			short num2 = num;
			num = (short)1093744308;
			switch (num2 == num)
			{
			default:
			{
				num = (short)426377216;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)794361857;
			if (num != 0)
			{
			}
			num = (short)2126446592;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009AD1 RID: 39633 RVA: 0x00911B60 File Offset: 0x0090FD60
		public override void SetConstraints()
		{
			short num = (short)1582371759;
			short num2 = num;
			num = (short)515380143;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2018639872;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1623785473;
			if (num != 0)
			{
			}
			num = (short)1102512128;
			if (num != 0)
			{
			}
			this.emergencyHotMicReStart_43343.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.ConConvEmerHotMicRestartIsApplicable);
			this.emergencyExitControl_43344.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.ConValidateConvSysConsoleEmergExitContr);
		}

		// Token: 0x06009AD2 RID: 39634 RVA: 0x00911C38 File Offset: 0x0090FE38
		public override void SetupDependencies()
		{
			short num = (short)105098544;
			short num2 = num;
			num = (short)859483440;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1016987648;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)119603200;
			if (num != 0)
			{
			}
			num = (short)1788018689;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles conventionalEmergencyProfiles = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles;
			conventionalEmergencyProfiles.General.CnvEmerProfGeneralEmergencyType_A7960.AddDependentObject(this.emergencyHotMicReStart_43343);
			conventionalEmergencyProfiles.General.ConEmerProEmergencyAutoTransmitMode_A22532.AddDependentObject(this.emergencyHotMicReStart_43343);
			conventionalEmergencyProfiles.General.CnvEmerProfGeneralEmergencyType_A7960.AddDependentObject(this.emergencyExitControl_43344);
		}

		// Token: 0x17004DAD RID: 19885
		// (get) Token: 0x06009AD3 RID: 39635 RVA: 0x00911D30 File Offset: 0x0090FF30
		public bool HasDiffs
		{
			get
			{
				short num = (short)1597666143;
				short num2 = num;
				num = (short)1556771679;
				switch (num2 == num)
				{
				default:
				{
					num = (short)919339008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1442119681;
				if (num != 0)
				{
				}
				num = (short)1650262016;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004DAE RID: 19886
		// (get) Token: 0x06009AD4 RID: 39636 RVA: 0x00911DE0 File Offset: 0x0090FFE0
		// (set) Token: 0x06009AD5 RID: 39637 RVA: 0x00911E98 File Offset: 0x00910098
		public bool EmergencyHotMicReStart_43343Value
		{
			get
			{
				short num = (short)1558033047;
				short num2 = num;
				num = (short)358789783;
				switch (num2 == num)
				{
				default:
				{
					num = (short)770703360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1746993153;
				if (num != 0)
				{
				}
				num = (short)334692352;
				if (num != 0)
				{
				}
				return this.emergencyHotMicReStart_43343.Value;
			}
			set
			{
				short num = (short)731762831;
				short num2 = num;
				num = (short)1963970703;
				switch (num2 == num)
				{
				default:
				{
					num = (short)882049024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1824784385;
				if (num != 0)
				{
				}
				num = (short)1630339072;
				if (num != 0)
				{
				}
				this.emergencyHotMicReStart_43343.Value = value;
			}
		}

		// Token: 0x17004DAF RID: 19887
		// (get) Token: 0x06009AD6 RID: 39638 RVA: 0x00911F4C File Offset: 0x0091014C
		public global::AcpBusinessLayer.AcpField<bool> EmergencyHotMicReStart_43343
		{
			get
			{
				short num = (short)1192190292;
				short num2 = num;
				num = (short)1243439444;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2142699520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)606142465;
				if (num != 0)
				{
				}
				num = (short)523239424;
				if (num != 0)
				{
				}
				return this.emergencyHotMicReStart_43343;
			}
		}

		// Token: 0x17004DB0 RID: 19888
		// (get) Token: 0x06009AD7 RID: 39639 RVA: 0x00911FFC File Offset: 0x009101FC
		// (set) Token: 0x06009AD8 RID: 39640 RVA: 0x009120B0 File Offset: 0x009102B0
		public bool EmergencyHotMicReStart_43343_UIValue
		{
			get
			{
				short num = (short)1998783828;
				short num2 = num;
				num = (short)858129748;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1447428096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)32702464;
				if (num != 0)
				{
				}
				num = (short)1736966145;
				if (num != 0)
				{
				}
				return this.emergencyHotMicReStart_43343.Value;
			}
			set
			{
				short num = (short)1446480347;
				short num2 = num;
				num = (short)1817086427;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1994653696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1895104513;
				if (num != 0)
				{
				}
				num = (short)1331429376;
				if (num != 0)
				{
				}
				this.emergencyHotMicReStart_43343.Value = value;
			}
		}

		// Token: 0x17004DB1 RID: 19889
		// (get) Token: 0x06009AD9 RID: 39641 RVA: 0x00912164 File Offset: 0x00910364
		// (set) Token: 0x06009ADA RID: 39642 RVA: 0x00912218 File Offset: 0x00910418
		public bool EmergencyHotMicReStart_43343_Applicable
		{
			get
			{
				short num = (short)1023418649;
				short num2 = num;
				num = (short)1067524377;
				switch (num2 == num)
				{
				default:
				{
					num = (short)719650816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1626275841;
				if (num != 0)
				{
				}
				num = (short)579469312;
				if (num != 0)
				{
				}
				return this.emergencyHotMicReStart_43343.Applicable;
			}
			set
			{
				short num = (short)1770936217;
				short num2 = num;
				num = (short)159537049;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1616773120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)533200897;
				if (num != 0)
				{
				}
				num = (short)1444216832;
				if (num != 0)
				{
				}
				this.emergencyHotMicReStart_43343.Applicable = value;
			}
		}

		// Token: 0x17004DB2 RID: 19890
		// (get) Token: 0x06009ADB RID: 39643 RVA: 0x009122D0 File Offset: 0x009104D0
		// (set) Token: 0x06009ADC RID: 39644 RVA: 0x00912384 File Offset: 0x00910584
		public bool EmergencyHotMicReStart_43343_Valid
		{
			get
			{
				short num = (short)1120412293;
				short num2 = num;
				num = (short)1380655749;
				switch (num2 == num)
				{
				default:
				{
					num = (short)484638720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)144900097;
				if (num != 0)
				{
				}
				num = (short)1999044608;
				if (num != 0)
				{
				}
				return this.emergencyHotMicReStart_43343.Valid;
			}
			set
			{
				short num = (short)862487098;
				short num2 = num;
				num = (short)1680704058;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1893924864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)125173761;
				if (num != 0)
				{
				}
				num = (short)164167680;
				if (num != 0)
				{
				}
				this.emergencyHotMicReStart_43343.Valid = value;
			}
		}

		// Token: 0x17004DB3 RID: 19891
		// (get) Token: 0x06009ADD RID: 39645 RVA: 0x0091243C File Offset: 0x0091063C
		// (set) Token: 0x06009ADE RID: 39646 RVA: 0x009124F4 File Offset: 0x009106F4
		public bool EmergencyHotMicReStart_43343_Visible
		{
			get
			{
				short num = (short)1782985594;
				short num2 = num;
				num = (short)1967076218;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1150615552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)189530112;
				if (num != 0)
				{
				}
				num = (short)957284353;
				if (num != 0)
				{
				}
				return this.emergencyHotMicReStart_43343.Visible;
			}
			set
			{
				short num = (short)2081423361;
				if (num != 0)
				{
				}
				num = (short)1056964608;
				short num2 = num;
				num = (short)1886275197;
				short num3 = num;
				num = (short)1165903485;
				switch (num3 == num)
				{
				}
				num = (short)2121138176;
				if (num != 0)
				{
				}
				this.emergencyHotMicReStart_43343.Visible = value;
			}
		}

		// Token: 0x17004DB4 RID: 19892
		// (get) Token: 0x06009ADF RID: 39647 RVA: 0x009125AC File Offset: 0x009107AC
		// (set) Token: 0x06009AE0 RID: 39648 RVA: 0x00912664 File Offset: 0x00910864
		public bool EmergencyHotMicReStart_43343_Editable
		{
			get
			{
				short num = (short)1429149835;
				short num2 = num;
				num = (short)10885259;
				switch (num2 == num)
				{
				default:
				{
					num = (short)216596480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1349976065;
				if (num != 0)
				{
				}
				num = (short)58458112;
				if (num != 0)
				{
				}
				return this.emergencyHotMicReStart_43343.Editable;
			}
			set
			{
				short num = (short)2071831598;
				short num2 = num;
				num = (short)460170286;
				switch (num2 == num)
				{
				default:
				{
					num = (short)134152192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1688862721;
				if (num != 0)
				{
				}
				num = (short)676331520;
				if (num != 0)
				{
				}
				this.emergencyHotMicReStart_43343.Editable = value;
			}
		}

		// Token: 0x17004DB5 RID: 19893
		// (get) Token: 0x06009AE1 RID: 39649 RVA: 0x0091271C File Offset: 0x0091091C
		internal string EmergencyHotMicReStart_43343_UILabel
		{
			get
			{
				short num = (short)1203594392;
				short num2 = num;
				num = (short)1537696920;
				switch (num2 == num)
				{
				default:
				{
					num = (short)707133440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2142306305;
				if (num != 0)
				{
				}
				num = (short)1186791424;
				if (num != 0)
				{
				}
				return this.emergencyHotMicReStart_43343.UIName;
			}
		}

		// Token: 0x17004DB6 RID: 19894
		// (get) Token: 0x06009AE2 RID: 39650 RVA: 0x009127D0 File Offset: 0x009109D0
		// (set) Token: 0x06009AE3 RID: 39651 RVA: 0x00912884 File Offset: 0x00910A84
		internal bool EmergencyHotMicReStart_43343_HiddenStatic
		{
			get
			{
				short num = (short)899809281;
				if (num != 0)
				{
				}
				num = (short)2129985536;
				short num2 = num;
				num = (short)2099350116;
				short num3 = num;
				num = (short)1344244324;
				switch (num3 == num)
				{
				}
				num = (short)730398720;
				if (num != 0)
				{
				}
				return this.emergencyHotMicReStart_43343.HiddenStatic;
			}
			set
			{
				short num = (short)970573958;
				short num2 = num;
				num = (short)1586677894;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1014890496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)110231552;
				if (num != 0)
				{
				}
				num = (short)1184104449;
				if (num != 0)
				{
				}
				this.emergencyHotMicReStart_43343.HiddenStatic = value;
			}
		}

		// Token: 0x17004DB7 RID: 19895
		// (get) Token: 0x06009AE4 RID: 39652 RVA: 0x0091293C File Offset: 0x00910B3C
		// (set) Token: 0x06009AE5 RID: 39653 RVA: 0x009129F0 File Offset: 0x00910BF0
		internal bool EmergencyHotMicReStart_43343_HiddenDynamic
		{
			get
			{
				short num = (short)1646264147;
				short num2 = num;
				num = (short)1458765651;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2099314688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)28049409;
				if (num != 0)
				{
				}
				num = (short)145883136;
				if (num != 0)
				{
				}
				return this.emergencyHotMicReStart_43343.HiddenDynamic;
			}
			set
			{
				short num = (short)1681391617;
				if (num != 0)
				{
				}
				num = (short)1722351616;
				short num2 = num;
				num = (short)962245462;
				short num3 = num;
				num = (short)1106686806;
				switch (num3 == num)
				{
				}
				num = (short)1687486464;
				if (num != 0)
				{
				}
				this.emergencyHotMicReStart_43343.HiddenDynamic = value;
			}
		}

		// Token: 0x17004DB8 RID: 19896
		// (get) Token: 0x06009AE6 RID: 39654 RVA: 0x00912AA8 File Offset: 0x00910CA8
		public bool EmergencyHotMicReStart_43343_HasDiffs
		{
			get
			{
				short num = (short)71203253;
				short num2 = num;
				num = (short)1880455605;
				switch (num2 == num)
				{
				}
				num = (short)1541734401;
				if (num != 0)
				{
				}
				num = (short)112984064;
				if (num != 0)
				{
				}
				num = (short)278003712;
				short num3 = num;
				return this.emergencyHotMicReStart_43343._HasDiffs;
			}
		}

		// Token: 0x17004DB9 RID: 19897
		// (get) Token: 0x06009AE7 RID: 39655 RVA: 0x00912B5C File Offset: 0x00910D5C
		// (set) Token: 0x06009AE8 RID: 39656 RVA: 0x00912C10 File Offset: 0x00910E10
		public int EmergencyExitControl_43344Value
		{
			get
			{
				short num = (short)289547344;
				short num2 = num;
				num = (short)666182736;
				switch (num2 == num)
				{
				}
				num = (short)1418919936;
				if (num != 0)
				{
				}
				num = (short)1362100225;
				if (num != 0)
				{
				}
				num = (short)1881276416;
				short num3 = num;
				return this.emergencyExitControl_43344.Value;
			}
			set
			{
				short num = (short)1018873090;
				short num2 = num;
				num = (short)1345373442;
				switch (num2 == num)
				{
				}
				num = (short)1890648065;
				if (num != 0)
				{
				}
				num = (short)1897594880;
				if (num != 0)
				{
				}
				num = (short)1857028096;
				short num3 = num;
				this.emergencyExitControl_43344.Value = value;
			}
		}

		// Token: 0x17004DBA RID: 19898
		// (get) Token: 0x06009AE9 RID: 39657 RVA: 0x00912CC4 File Offset: 0x00910EC4
		// (set) Token: 0x06009AEA RID: 39658 RVA: 0x00912D78 File Offset: 0x00910F78
		public string EmergencyExitControl_43344_UIValue
		{
			get
			{
				short num = (short)1545360805;
				short num2 = num;
				num = (short)395466149;
				switch (num2 == num)
				{
				}
				num = (short)945684481;
				if (num != 0)
				{
				}
				num = (short)1129971712;
				if (num != 0)
				{
				}
				num = (short)1568997376;
				short num3 = num;
				return this.emergencyExitControl_43344.UIValue;
			}
			set
			{
				short num = (short)1440935959;
				short num2 = num;
				num = (short)1123938327;
				switch (num2 == num)
				{
				}
				num = (short)1926758401;
				if (num != 0)
				{
				}
				num = (short)701562880;
				if (num != 0)
				{
				}
				num = (short)1799553024;
				short num3 = num;
				this.emergencyExitControl_43344.UIValue = value;
			}
		}

		// Token: 0x17004DBB RID: 19899
		// (get) Token: 0x06009AEB RID: 39659 RVA: 0x00912E30 File Offset: 0x00911030
		public global::AcpBusinessLayer.AcpListField EmergencyExitControl_43344
		{
			get
			{
				short num = (short)800840888;
				short num2 = num;
				num = (short)926801080;
				switch (num2 == num)
				{
				}
				num = (short)365428737;
				if (num != 0)
				{
				}
				num = (short)129564672;
				if (num != 0)
				{
				}
				num = (short)2105933824;
				short num3 = num;
				return this.emergencyExitControl_43344;
			}
		}

		// Token: 0x17004DBC RID: 19900
		// (get) Token: 0x06009AEC RID: 39660 RVA: 0x00912EE0 File Offset: 0x009110E0
		// (set) Token: 0x06009AED RID: 39661 RVA: 0x00912F94 File Offset: 0x00911194
		public bool EmergencyExitControl_43344_Applicable
		{
			get
			{
				short num = (short)1602175581;
				short num2 = num;
				num = (short)1980383837;
				switch (num2 == num)
				{
				}
				num = (short)1073676289;
				if (num != 0)
				{
				}
				num = (short)1286602752;
				if (num != 0)
				{
				}
				num = (short)526188544;
				short num3 = num;
				return this.emergencyExitControl_43344.Applicable;
			}
			set
			{
				short num = (short)720371713;
				if (num != 0)
				{
				}
				num = (short)122506181;
				short num2 = num;
				num = (short)112151493;
				switch (num2 == num)
				{
				}
				num = (short)155779072;
				if (num != 0)
				{
				}
				num = (short)1122893824;
				short num3 = num;
				this.emergencyExitControl_43344.Applicable = value;
			}
		}

		// Token: 0x17004DBD RID: 19901
		// (get) Token: 0x06009AEE RID: 39662 RVA: 0x00913048 File Offset: 0x00911248
		// (set) Token: 0x06009AEF RID: 39663 RVA: 0x009130FC File Offset: 0x009112FC
		public bool EmergencyExitControl_43344_Valid
		{
			get
			{
				short num = (short)304716960;
				short num2 = num;
				num = (short)312646816;
				switch (num2 == num)
				{
				}
				num = (short)486539265;
				if (num != 0)
				{
				}
				num = (short)1078525952;
				if (num != 0)
				{
				}
				num = (short)762052608;
				short num3 = num;
				return this.emergencyExitControl_43344.Valid;
			}
			set
			{
				short num = (short)1407735396;
				short num2 = num;
				num = (short)594237028;
				switch (num2 == num)
				{
				}
				num = (short)286588928;
				if (num != 0)
				{
				}
				num = (short)443023361;
				if (num != 0)
				{
				}
				num = (short)1452867584;
				short num3 = num;
				this.emergencyExitControl_43344.Valid = value;
			}
		}

		// Token: 0x17004DBE RID: 19902
		// (get) Token: 0x06009AF0 RID: 39664 RVA: 0x009131B0 File Offset: 0x009113B0
		// (set) Token: 0x06009AF1 RID: 39665 RVA: 0x00913264 File Offset: 0x00911464
		public bool EmergencyExitControl_43344_Visible
		{
			get
			{
				short num = (short)281176588;
				short num2 = num;
				num = (short)1234856460;
				switch (num2 == num)
				{
				}
				num = (short)63700992;
				if (num != 0)
				{
				}
				num = (short)959381505;
				if (num != 0)
				{
				}
				num = (short)926089216;
				short num3 = num;
				return this.emergencyExitControl_43344.Visible;
			}
			set
			{
				short num = (short)464491458;
				short num2 = num;
				num = (short)1197052866;
				switch (num2 == num)
				{
				}
				num = (short)2074804225;
				if (num != 0)
				{
				}
				num = (short)2064187392;
				if (num != 0)
				{
				}
				num = (short)1660289024;
				short num3 = num;
				this.emergencyExitControl_43344.Visible = value;
			}
		}

		// Token: 0x17004DBF RID: 19903
		// (get) Token: 0x06009AF2 RID: 39666 RVA: 0x00913318 File Offset: 0x00911518
		// (set) Token: 0x06009AF3 RID: 39667 RVA: 0x009133CC File Offset: 0x009115CC
		public bool EmergencyExitControl_43344_Editable
		{
			get
			{
				short num = (short)505455451;
				short num2 = num;
				num = (short)1507894107;
				switch (num2 == num)
				{
				}
				num = (short)1515913216;
				if (num != 0)
				{
				}
				num = (short)1425473537;
				if (num != 0)
				{
				}
				num = (short)1368850432;
				short num3 = num;
				return this.emergencyExitControl_43344.Editable;
			}
			set
			{
				short num = (short)1037188571;
				short num2 = num;
				num = (short)277626331;
				switch (num2 == num)
				{
				}
				num = (short)2018246657;
				if (num != 0)
				{
				}
				num = (short)480247808;
				if (num != 0)
				{
				}
				num = (short)1703673856;
				short num3 = num;
				this.emergencyExitControl_43344.Editable = value;
			}
		}

		// Token: 0x17004DC0 RID: 19904
		// (get) Token: 0x06009AF4 RID: 39668 RVA: 0x00913484 File Offset: 0x00911684
		internal string EmergencyExitControl_43344_UILabel
		{
			get
			{
				short num = (short)1633147658;
				short num2 = num;
				num = (short)392616714;
				switch (num2 == num)
				{
				}
				num = (short)2062483457;
				if (num != 0)
				{
				}
				num = (short)1574305792;
				if (num != 0)
				{
				}
				num = (short)1935540224;
				short num3 = num;
				return this.emergencyExitControl_43344.UIName;
			}
		}

		// Token: 0x17004DC1 RID: 19905
		// (get) Token: 0x06009AF5 RID: 39669 RVA: 0x00913538 File Offset: 0x00911738
		// (set) Token: 0x06009AF6 RID: 39670 RVA: 0x009135EC File Offset: 0x009117EC
		internal bool EmergencyExitControl_43344_HiddenStatic
		{
			get
			{
				short num = (short)411460584;
				short num2 = num;
				num = (short)248210408;
				switch (num2 == num)
				{
				}
				num = (short)1854013440;
				if (num != 0)
				{
				}
				num = (short)1818755073;
				if (num != 0)
				{
				}
				num = (short)1132658688;
				short num3 = num;
				return this.emergencyExitControl_43344.HiddenStatic;
			}
			set
			{
				short num = (short)350620228;
				short num2 = num;
				num = (short)566102596;
				switch (num2 == num)
				{
				}
				num = (short)745734145;
				if (num != 0)
				{
				}
				num = (short)1325531136;
				if (num != 0)
				{
				}
				num = (short)1422131200;
				short num3 = num;
				this.emergencyExitControl_43344.HiddenStatic = value;
			}
		}

		// Token: 0x17004DC2 RID: 19906
		// (get) Token: 0x06009AF7 RID: 39671 RVA: 0x009136A4 File Offset: 0x009118A4
		// (set) Token: 0x06009AF8 RID: 39672 RVA: 0x00913758 File Offset: 0x00911958
		internal bool EmergencyExitControl_43344_HiddenDynamic
		{
			get
			{
				short num = (short)1268252532;
				short num2 = num;
				num = (short)1007091572;
				switch (num2 == num)
				{
				}
				num = (short)1151860736;
				if (num != 0)
				{
				}
				num = (short)475136001;
				if (num != 0)
				{
				}
				num = (short)319946752;
				short num3 = num;
				return this.emergencyExitControl_43344.HiddenDynamic;
			}
			set
			{
				short num = (short)2026267474;
				short num2 = num;
				num = (short)1711432530;
				switch (num2 == num)
				{
				}
				num = (short)95813632;
				if (num != 0)
				{
				}
				num = (short)1989148673;
				if (num != 0)
				{
				}
				num = (short)2092498944;
				short num3 = num;
				this.emergencyExitControl_43344.HiddenDynamic = value;
			}
		}

		// Token: 0x17004DC3 RID: 19907
		// (get) Token: 0x06009AF9 RID: 39673 RVA: 0x0091380C File Offset: 0x00911A0C
		public bool EmergencyExitControl_43344_HasDiffs
		{
			get
			{
				short num = (short)1027269294;
				short num2 = num;
				num = (short)308535982;
				switch (num2 == num)
				{
				}
				num = (short)2065039361;
				if (num != 0)
				{
				}
				num = (short)1285816320;
				if (num != 0)
				{
				}
				num = (short)1116930048;
				short num3 = num;
				return this.emergencyExitControl_43344._HasDiffs;
			}
		}

		// Token: 0x06009AFA RID: 39674 RVA: 0x009138C0 File Offset: 0x00911AC0
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
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1986723841;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
				{
					num2 = (short)1068105729;
					if (num2 != 0)
					{
					}
					num2 = (short)1531904000;
					short num3 = num2;
					num2 = (short)223332114;
					short num4 = num2;
					num2 = (short)700761874;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1808859136;
						if (num2 != 0)
						{
						}
						num2 = (short)91881476;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)1401356290;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)456720384;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1331822595;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04004CF0 RID: 19696
		private global::AcpBusinessLayer.AcpField<bool> emergencyHotMicReStart_43343;

		// Token: 0x04004CF1 RID: 19697
		private global::AcpBusinessLayer.AcpListField emergencyExitControl_43344;
	}
}
