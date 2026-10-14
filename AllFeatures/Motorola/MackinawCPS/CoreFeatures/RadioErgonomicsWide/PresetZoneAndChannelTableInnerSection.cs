using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Features.Converters;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x0200023F RID: 575
	[global::System.Serializable]
	public class PresetZoneAndChannelTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060067AC RID: 26540 RVA: 0x005C9C40 File Offset: 0x005C7E40
		public PresetZoneAndChannelTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060067AD RID: 26541 RVA: 0x005C9C5C File Offset: 0x005C7E5C
		protected PresetZoneAndChannelTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060067AE RID: 26542 RVA: 0x005C9C74 File Offset: 0x005C7E74
		public override void Init()
		{
			int a_ = 14;
			short num = (short)2099613805;
			short num2 = num;
			num = (short)43552877;
			switch (num2 == num)
			{
			}
			num = (short)112197632;
			short num3 = num;
			num = (short)228458496;
			if (num != 0)
			{
			}
			num = (short)295305217;
			if (num != 0)
			{
			}
			this.presetModeSelect = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_MS01, this, global::AllFeatures.CodeplugGuid.b("鿎ꏐ뛒ꛔ닖귘雚닜믞蓠냢胤详賨裪駬", a_), global::CommonResources.AcgResources.ID_PRESET_MODE_SELECT, 4);
			this.presetModeSelect.IgnoreOnCompare = true;
			this.presetModeSelect.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.presetModeSelect.DataTransferOrder = -1;
			this.labtoolPresetZone_A41079 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("菎냐뇒ꇔ룖뛘럚跜귞蓠郢胤鏦돨蓪菬諮껰닲쇴웶째쳺쓼", a_), global::CommonResources.AcgResources.ID_PRESETZONE, new string[]
			{
				global::CommonResources.AcgResources.ID_SELECTED_ZONE
			}, new int[1], true, false);
			this.labtoolPresetZone_A41079.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.labtoolPresetZone_A41079.DataTransferOrder = 1;
			this.labtoolPresetChannel_A41080 = new global::AcpBusinessLayer.AcpRangeField<int, string>(0, new global::Features.Converters.UnpackAndPackPresetChannelFields(), this, global::AllFeatures.CodeplugGuid.b("菎냐뇒ꇔ룖뛘럚跜귞蓠郢胤鏦ꫨ菪賬臮鿰雲駴ꣶ룸쿺쳼쿾㤀㌂", a_), global::CommonResources.AcgResources.ID_PRESETCHANNEL, 0, 625, 1);
			this.labtoolPresetChannel_A41080.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.labtoolPresetChannel_A41080.DataTransferOrder = 2;
			this.labtoolPresetChannel_A41080.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鿎ꏐ뛒ꛔ닖귘ﯚ蟜냞迠蛢엤蛦蟨迪췬곮駰鋲鯴駶鳸韺\uddfc꯾怀愂椄戆", a_);
			base.Id = 10641;
			base.UIName = global::CommonResources.AcgResources.ID_PRESETZONEANDCHANNELTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060067AF RID: 26543 RVA: 0x005C9E40 File Offset: 0x005C8040
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)2140471304;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_218;
				case 1:
					num = (short)1657339908;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					this.presetModeSelect = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_MS01, this, global::AllFeatures.CodeplugGuid.b("釀뇂ꃄ듆곈뿊背ꃎ뗐뛒蛔닖뗘뻚뻜ꯞ", a_), global::CommonResources.AcgResources.ID_PRESET_MODE_SELECT, 4);
					this.presetModeSelect.IgnoreOnCompare = true;
					this.presetModeSelect.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.presetModeSelect.DataTransferOrder = -1;
					num = (short)1107034112;
					short num3 = num;
					num = (short)46858251;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					num = (short)369754117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)473423426;
					short num4 = num;
					num = (short)635887170;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_378;
					default:
						num = (short)502726656;
						if (num != 0)
						{
						}
						if (producerFields != null)
						{
							num = (short)1943666691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37D;
					}
					break;
				}
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釀뇂ꃄ듆곈뿊背ꃎ뗐뛒蛔닖뗘뻚뻜ꯞ", a_)))
					{
						num = (short)119341057;
						if (num != 0)
						{
						}
						num = (short)1270349826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EE;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跀ꋂꟄ돆ꛈ꓊ꇌ鿎ꏐ뛒ꛔ닖귘飚뗜뻞迠跢胤详뛨ꫪ\ud9ec\udeee쇰쯲열", a_)))
					{
						num = (short)1410990089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37D;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跀ꋂꟄ돆ꛈ꓊ꇌ鿎ꏐ뛒ꛔ닖귘臚닜뇞蓠볢ꓤ폦\ud8e8\udbea\udaec훮", a_)))
					{
						num = (short)960888842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A3;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 9:
					this.labtoolPresetChannel_A41080 = new global::AcpBusinessLayer.AcpRangeField<int, string>(0, new global::Features.Converters.UnpackAndPackPresetChannelFields(), this, global::AllFeatures.CodeplugGuid.b("跀ꋂꟄ돆ꛈ꓊ꇌ鿎ꏐ뛒ꛔ닖귘飚뗜뻞迠跢胤详뛨ꫪ\ud9ec\udeee쇰쯲열", a_), global::CommonResources.AcgResources.ID_PRESETCHANNEL, 0, 625, 1);
					this.labtoolPresetChannel_A41080.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.labtoolPresetChannel_A41080.DataTransferOrder = 2;
					this.labtoolPresetChannel_A41080.ShowHexValue = false;
					num = (short)941228032;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					this.labtoolPresetZone_A41079 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("跀ꋂꟄ돆ꛈ꓊ꇌ鿎ꏐ뛒ꛔ닖귘臚닜뇞蓠볢ꓤ폦\ud8e8\udbea\udaec훮", a_), global::CommonResources.AcgResources.ID_PRESETZONE, new string[]
					{
						global::CommonResources.AcgResources.ID_SELECTED_ZONE
					}, new int[1], true, false);
					this.labtoolPresetZone_A41079.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.labtoolPresetZone_A41079.DataTransferOrder = 1;
					num = (short)546111500;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_378;
				case 12:
					goto IL_2A3;
				}
				IL_61:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1618608129;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_EE:
				num = (short)643563527;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_378:
				goto IL_EE;
				IL_2A3:
				num = (short)1466761222;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_218:
			IL_37D:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("釀뇂ꃄ듆곈뿊闎뻐뷒냔룘뗚맜￞ꋠ询蓤触蟨軪臬쿮ꗰ鋲韴鯶鳸", a_);
			base.Id = 10641;
			base.UIName = global::CommonResources.AcgResources.ID_PRESETZONEANDCHANNELTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060067B0 RID: 26544 RVA: 0x005CA1FC File Offset: 0x005C83FC
		public override void PopulateReferences()
		{
			short num = (short)548209444;
			short num2 = num;
			num = (short)896795428;
			switch (num2 == num)
			{
			default:
			{
				num = (short)34537472;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)751370241;
			if (num != 0)
			{
			}
			num = (short)308609024;
			if (num != 0)
			{
			}
			this.labtoolPresetZone_A41079.SetRecset(this.a(2051));
		}

		// Token: 0x060067B1 RID: 26545 RVA: 0x005CA2BC File Offset: 0x005C84BC
		public override void DropReferences()
		{
			short num = (short)2132147910;
			short num2 = num;
			num = (short)1218641606;
			switch (num2 == num)
			{
			default:
			{
				num = (short)243269632;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)856752129;
			if (num != 0)
			{
			}
			num = (short)1139015680;
			if (num != 0)
			{
			}
		}

		// Token: 0x060067B2 RID: 26546 RVA: 0x005CA364 File Offset: 0x005C8564
		public override void SetConstraints()
		{
			short num = (short)718209025;
			if (num != 0)
			{
			}
			num = (short)1012924416;
			short num2 = num;
			num = (short)582526183;
			short num3 = num;
			num = (short)1488692455;
			switch (num3 == num)
			{
			}
			num = (short)1887502336;
			if (num != 0)
			{
			}
			this.presetModeSelect.IsApplicable = delegate(global::AcpCommonLib.IAcpFeatureSection _)
			{
				short num4 = (short)543943178;
				short num5 = num4;
				num4 = (short)1508633098;
				switch (num5 == num4)
				{
				}
				num4 = (short)988545024;
				short num6 = num4;
				num4 = (short)816971777;
				if (num4 != 0)
				{
				}
				num4 = (short)1017118720;
				if (num4 != 0)
				{
				}
				return true;
			};
			this.presetModeSelect.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.labtoolPresetChannel_A41080.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadWidePresetChannelSelIsValid);
		}

		// Token: 0x060067B3 RID: 26547 RVA: 0x005CA46C File Offset: 0x005C866C
		public override void SetupDependencies()
		{
			short num = (short)1198147632;
			short num2 = num;
			num = (short)140396592;
			switch (num2 == num)
			{
			default:
			{
				num = (short)353566720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)981663745;
			if (num != 0)
			{
			}
			num = (short)1019478016;
			if (num != 0)
			{
			}
			this.labtoolPresetChannel_A41080.AddDependentObject(this.labtoolPresetZone_A41079);
		}

		// Token: 0x170035CE RID: 13774
		// (get) Token: 0x060067B4 RID: 26548 RVA: 0x005CA528 File Offset: 0x005C8728
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment ZoneChannelAssignmentForLabtoolPresetZone_A41079
		{
			get
			{
				short num = (short)1390881614;
				short num2 = num;
				num = (short)716057422;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1348141056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)199426048;
				if (num != 0)
				{
				}
				num = (short)313065473;
				if (num != 0)
				{
				}
				return this.labtoolPresetZone_A41079.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
			}
		}

		// Token: 0x170035CF RID: 13775
		// (get) Token: 0x060067B5 RID: 26549 RVA: 0x005CA5E0 File Offset: 0x005C87E0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1544754864;
				short num2 = num;
				num = (short)928913072;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1892745216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)199622657;
				if (num != 0)
				{
				}
				num = (short)1105002496;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170035D0 RID: 13776
		// (get) Token: 0x060067B6 RID: 26550 RVA: 0x005CA690 File Offset: 0x005C8890
		// (set) Token: 0x060067B7 RID: 26551 RVA: 0x005CA744 File Offset: 0x005C8944
		public int LabtoolPresetZone_A41079Value
		{
			get
			{
				short num = (short)1608493491;
				short num2 = num;
				num = (short)2127276467;
				switch (num2 == num)
				{
				default:
				{
					num = (short)820903936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1351745537;
				if (num != 0)
				{
				}
				num = (short)681771008;
				if (num != 0)
				{
				}
				return this.labtoolPresetZone_A41079.Value;
			}
			set
			{
				short num = (short)1130690264;
				short num2 = num;
				num = (short)124319448;
				switch (num2 == num)
				{
				default:
				{
					num = (short)420413440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1374552065;
				if (num != 0)
				{
				}
				num = (short)437256192;
				if (num != 0)
				{
				}
				this.labtoolPresetZone_A41079.Value = value;
			}
		}

		// Token: 0x170035D1 RID: 13777
		// (get) Token: 0x060067B8 RID: 26552 RVA: 0x005CA7F8 File Offset: 0x005C89F8
		// (set) Token: 0x060067B9 RID: 26553 RVA: 0x005CA8A8 File Offset: 0x005C8AA8
		public string LabtoolPresetZone_A41079_UIValue
		{
			get
			{
				short num = (short)235601728;
				short num2 = num;
				num = (short)1768292160;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1314979840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1957429249;
				if (num != 0)
				{
				}
				num = (short)846266368;
				if (num != 0)
				{
				}
				return this.labtoolPresetZone_A41079.UIValue;
			}
			set
			{
				short num = (short)712406704;
				short num2 = num;
				num = (short)1217427120;
				switch (num2 == num)
				{
				default:
				{
					num = (short)550436864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1041039361;
				if (num != 0)
				{
				}
				num = (short)1468596224;
				if (num != 0)
				{
				}
				this.labtoolPresetZone_A41079.UIValue = value;
			}
		}

		// Token: 0x170035D2 RID: 13778
		// (get) Token: 0x060067BA RID: 26554 RVA: 0x005CA960 File Offset: 0x005C8B60
		public global::AcpBusinessLayer.AcpRecRefField LabtoolPresetZone_A41079
		{
			get
			{
				short num = (short)1888449604;
				short num2 = num;
				num = (short)1266381892;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1845493760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)470941697;
				if (num != 0)
				{
				}
				num = (short)1938423808;
				if (num != 0)
				{
				}
				return this.labtoolPresetZone_A41079;
			}
		}

		// Token: 0x170035D3 RID: 13779
		// (get) Token: 0x060067BB RID: 26555 RVA: 0x005CAA10 File Offset: 0x005C8C10
		// (set) Token: 0x060067BC RID: 26556 RVA: 0x005CAAC4 File Offset: 0x005C8CC4
		public bool LabtoolPresetZone_A41079_Applicable
		{
			get
			{
				short num = (short)1546001839;
				short num2 = num;
				num = (short)1736908207;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1396375552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1193869313;
				if (num != 0)
				{
				}
				num = (short)192872448;
				if (num != 0)
				{
				}
				return this.labtoolPresetZone_A41079.Applicable;
			}
			set
			{
				short num = (short)972565192;
				short num2 = num;
				num = (short)130886344;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1809776640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1689583616;
				if (num != 0)
				{
				}
				num = (short)145424385;
				if (num != 0)
				{
				}
				this.labtoolPresetZone_A41079.Applicable = value;
			}
		}

		// Token: 0x170035D4 RID: 13780
		// (get) Token: 0x060067BD RID: 26557 RVA: 0x005CAB7C File Offset: 0x005C8D7C
		// (set) Token: 0x060067BE RID: 26558 RVA: 0x005CAC30 File Offset: 0x005C8E30
		public bool LabtoolPresetZone_A41079_Valid
		{
			get
			{
				short num = (short)1789647455;
				short num2 = num;
				num = (short)1849678431;
				switch (num2 == num)
				{
				default:
				{
					num = (short)501874688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1302265856;
				if (num != 0)
				{
				}
				num = (short)214958081;
				if (num != 0)
				{
				}
				return this.labtoolPresetZone_A41079.Valid;
			}
			set
			{
				short num = (short)2107945189;
				short num2 = num;
				num = (short)1247916261;
				switch (num2 == num)
				{
				default:
				{
					num = (short)486932480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1492713473;
				if (num != 0)
				{
				}
				num = (short)381288448;
				if (num != 0)
				{
				}
				this.labtoolPresetZone_A41079.Valid = value;
			}
		}

		// Token: 0x170035D5 RID: 13781
		// (get) Token: 0x060067BF RID: 26559 RVA: 0x005CACE8 File Offset: 0x005C8EE8
		// (set) Token: 0x060067C0 RID: 26560 RVA: 0x005CAD98 File Offset: 0x005C8F98
		public bool LabtoolPresetZone_A41079_Visible
		{
			get
			{
				short num = (short)785942043;
				short num2 = num;
				num = (short)1585481243;
				switch (num2 == num)
				{
				default:
				{
					num = (short)494796800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1605042176;
				if (num != 0)
				{
				}
				num = (short)251920385;
				if (num != 0)
				{
				}
				return this.labtoolPresetZone_A41079.Visible;
			}
			set
			{
				short num = (short)1472593921;
				if (num != 0)
				{
				}
				num = (short)1545797632;
				short num2 = num;
				num = (short)555153283;
				short num3 = num;
				num = (short)1370224515;
				switch (num3 == num)
				{
				}
				num = (short)1261961216;
				if (num != 0)
				{
				}
				this.labtoolPresetZone_A41079.Visible = value;
			}
		}

		// Token: 0x170035D6 RID: 13782
		// (get) Token: 0x060067C1 RID: 26561 RVA: 0x005CAE4C File Offset: 0x005C904C
		// (set) Token: 0x060067C2 RID: 26562 RVA: 0x005CAF00 File Offset: 0x005C9100
		public bool LabtoolPresetZone_A41079_Editable
		{
			get
			{
				short num = (short)1530457986;
				short num2 = num;
				num = (short)1413934978;
				switch (num2 == num)
				{
				default:
				{
					num = (short)795934720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1023016961;
				if (num != 0)
				{
				}
				num = (short)1345650688;
				if (num != 0)
				{
				}
				return this.labtoolPresetZone_A41079.Editable;
			}
			set
			{
				short num = (short)2085041694;
				short num2 = num;
				num = (short)67712542;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1465909248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1619656705;
				if (num != 0)
				{
				}
				num = (short)288948224;
				if (num != 0)
				{
				}
				this.labtoolPresetZone_A41079.Editable = value;
			}
		}

		// Token: 0x170035D7 RID: 13783
		// (get) Token: 0x060067C3 RID: 26563 RVA: 0x005CAFB8 File Offset: 0x005C91B8
		internal string LabtoolPresetZone_A41079_UILabel
		{
			get
			{
				short num = (short)1749876737;
				if (num != 0)
				{
				}
				num = (short)1919221760;
				short num2 = num;
				num = (short)1165500909;
				short num3 = num;
				num = (short)1267999213;
				switch (num3 == num)
				{
				}
				num = (short)2095644672;
				if (num != 0)
				{
				}
				return this.labtoolPresetZone_A41079.UIName;
			}
		}

		// Token: 0x170035D8 RID: 13784
		// (get) Token: 0x060067C4 RID: 26564 RVA: 0x005CB06C File Offset: 0x005C926C
		// (set) Token: 0x060067C5 RID: 26565 RVA: 0x005CB124 File Offset: 0x005C9324
		internal bool LabtoolPresetZone_A41079_HiddenStatic
		{
			get
			{
				short num = (short)322241565;
				short num2 = num;
				num = (short)1501496349;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2030370816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)229376001;
				if (num != 0)
				{
				}
				num = (short)1585446912;
				if (num != 0)
				{
				}
				return this.labtoolPresetZone_A41079.HiddenStatic;
			}
			set
			{
				short num = (short)41218406;
				short num2 = num;
				num = (short)1847587174;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1479737344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)487915520;
				if (num != 0)
				{
				}
				num = (short)967639041;
				if (num != 0)
				{
				}
				this.labtoolPresetZone_A41079.HiddenStatic = value;
			}
		}

		// Token: 0x170035D9 RID: 13785
		// (get) Token: 0x060067C6 RID: 26566 RVA: 0x005CB1D8 File Offset: 0x005C93D8
		// (set) Token: 0x060067C7 RID: 26567 RVA: 0x005CB290 File Offset: 0x005C9490
		internal bool LabtoolPresetZone_A41079_HiddenDynamic
		{
			get
			{
				short num = (short)1782841345;
				if (num != 0)
				{
				}
				num = (short)774766592;
				short num2 = num;
				num = (short)1755582948;
				short num3 = num;
				num = (short)1765544420;
				switch (num3 == num)
				{
				}
				num = (short)799735808;
				if (num != 0)
				{
				}
				return this.labtoolPresetZone_A41079.HiddenDynamic;
			}
			set
			{
				short num = (short)639431264;
				short num2 = num;
				num = (short)79491680;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1858338816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)274595840;
				if (num != 0)
				{
				}
				num = (short)2036203521;
				if (num != 0)
				{
				}
				this.labtoolPresetZone_A41079.HiddenDynamic = value;
			}
		}

		// Token: 0x170035DA RID: 13786
		// (get) Token: 0x060067C8 RID: 26568 RVA: 0x005CB344 File Offset: 0x005C9544
		public bool LabtoolPresetZone_A41079_HasDiffs
		{
			get
			{
				short num = (short)1721453697;
				short num2 = num;
				num = (short)799296641;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2102001664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1007943681;
				if (num != 0)
				{
				}
				num = (short)1905065984;
				if (num != 0)
				{
				}
				return this.labtoolPresetZone_A41079._HasDiffs;
			}
		}

		// Token: 0x170035DB RID: 13787
		// (get) Token: 0x060067C9 RID: 26569 RVA: 0x005CB3F8 File Offset: 0x005C95F8
		// (set) Token: 0x060067CA RID: 26570 RVA: 0x005CB4B0 File Offset: 0x005C96B0
		public int LabtoolPresetChannel_A41080Value
		{
			get
			{
				short num = (short)1758323904;
				short num2 = num;
				num = (short)33481920;
				switch (num2 == num)
				{
				default:
				{
					num = (short)498794496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2088828929;
				if (num != 0)
				{
				}
				num = (short)631832576;
				if (num != 0)
				{
				}
				return this.labtoolPresetChannel_A41080.Value;
			}
			set
			{
				short num = (short)667549697;
				if (num != 0)
				{
				}
				num = (short)1720254464;
				short num2 = num;
				num = (short)2125820059;
				short num3 = num;
				num = (short)2070769819;
				switch (num3 == num)
				{
				}
				num = (short)1272905728;
				if (num != 0)
				{
				}
				this.labtoolPresetChannel_A41080.Value = value;
			}
		}

		// Token: 0x170035DC RID: 13788
		// (get) Token: 0x060067CB RID: 26571 RVA: 0x005CB564 File Offset: 0x005C9764
		// (set) Token: 0x060067CC RID: 26572 RVA: 0x005CB618 File Offset: 0x005C9818
		public string LabtoolPresetChannel_A41080_UIValue
		{
			get
			{
				short num = (short)682229761;
				if (num != 0)
				{
				}
				num = (short)735772672;
				short num2 = num;
				num = (short)567699690;
				short num3 = num;
				num = (short)812148970;
				switch (num3 == num)
				{
				}
				num = (short)1403584512;
				if (num != 0)
				{
				}
				return this.labtoolPresetChannel_A41080.UIValue;
			}
			set
			{
				short num = (short)1513291777;
				if (num != 0)
				{
				}
				num = (short)1227423744;
				short num2 = num;
				num = (short)705619699;
				short num3 = num;
				num = (short)1045096179;
				switch (num3 == num)
				{
				}
				num = (short)1020002304;
				if (num != 0)
				{
				}
				this.labtoolPresetChannel_A41080.UIValue = value;
			}
		}

		// Token: 0x170035DD RID: 13789
		// (get) Token: 0x060067CD RID: 26573 RVA: 0x005CB6CC File Offset: 0x005C98CC
		public global::AcpBusinessLayer.AcpRangeField<int, string> LabtoolPresetChannel_A41080
		{
			get
			{
				short num = (short)1835502925;
				short num2 = num;
				num = (short)1569295693;
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
				num = (short)203096064;
				if (num != 0)
				{
				}
				num = (short)1280245761;
				if (num != 0)
				{
				}
				return this.labtoolPresetChannel_A41080;
			}
		}

		// Token: 0x170035DE RID: 13790
		// (get) Token: 0x060067CE RID: 26574 RVA: 0x005CB780 File Offset: 0x005C9980
		// (set) Token: 0x060067CF RID: 26575 RVA: 0x005CB834 File Offset: 0x005C9A34
		internal int LabtoolPresetChannel_A41080Min
		{
			get
			{
				short num = (short)1516573644;
				short num2 = num;
				num = (short)660018124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1250820096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1031602176;
				if (num != 0)
				{
				}
				num = (short)306315265;
				if (num != 0)
				{
				}
				return this.labtoolPresetChannel_A41080.Min;
			}
			set
			{
				short num = (short)1556480001;
				if (num != 0)
				{
				}
				num = (short)1149042688;
				short num2 = num;
				num = (short)1264940086;
				short num3 = num;
				num = (short)1510700086;
				switch (num3 == num)
				{
				}
				num = (short)1982922752;
				if (num != 0)
				{
				}
				this.labtoolPresetChannel_A41080.Min = value;
			}
		}

		// Token: 0x170035DF RID: 13791
		// (get) Token: 0x060067D0 RID: 26576 RVA: 0x005CB8E8 File Offset: 0x005C9AE8
		// (set) Token: 0x060067D1 RID: 26577 RVA: 0x005CB99C File Offset: 0x005C9B9C
		internal int LabtoolPresetChannel_A41080Max
		{
			get
			{
				short num = (short)931357045;
				short num2 = num;
				num = (short)432562549;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1646067712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1561853952;
				if (num != 0)
				{
				}
				num = (short)1109327873;
				if (num != 0)
				{
				}
				return this.labtoolPresetChannel_A41080.Max;
			}
			set
			{
				short num = (short)2111524667;
				short num2 = num;
				num = (short)479940411;
				switch (num2 == num)
				{
				default:
				{
					num = (short)705495040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1044185088;
				if (num != 0)
				{
				}
				num = (short)236453889;
				if (num != 0)
				{
				}
				this.labtoolPresetChannel_A41080.Max = value;
			}
		}

		// Token: 0x170035E0 RID: 13792
		// (get) Token: 0x060067D2 RID: 26578 RVA: 0x005CBA54 File Offset: 0x005C9C54
		// (set) Token: 0x060067D3 RID: 26579 RVA: 0x005CBB08 File Offset: 0x005C9D08
		internal int LabtoolPresetChannel_A41080Step
		{
			get
			{
				short num = (short)173998081;
				if (num != 0)
				{
				}
				num = (short)1160904704;
				short num2 = num;
				num = (short)1975451858;
				short num3 = num;
				num = (short)586940626;
				switch (num3 == num)
				{
				}
				num = (short)1850212352;
				if (num != 0)
				{
				}
				return this.labtoolPresetChannel_A41080.StepSize;
			}
			set
			{
				short num = (short)262048286;
				short num2 = num;
				num = (short)604736030;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1121976320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1159790593;
				if (num != 0)
				{
				}
				num = (short)1027866624;
				if (num != 0)
				{
				}
				this.labtoolPresetChannel_A41080.StepSize = value;
			}
		}

		// Token: 0x170035E1 RID: 13793
		// (get) Token: 0x060067D4 RID: 26580 RVA: 0x005CBBC0 File Offset: 0x005C9DC0
		// (set) Token: 0x060067D5 RID: 26581 RVA: 0x005CBC74 File Offset: 0x005C9E74
		public bool LabtoolPresetChannel_A41080_Applicable
		{
			get
			{
				short num = (short)1221166267;
				short num2 = num;
				num = (short)920552635;
				switch (num2 == num)
				{
				default:
				{
					num = (short)417660928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1767178240;
				if (num != 0)
				{
				}
				num = (short)821428225;
				if (num != 0)
				{
				}
				return this.labtoolPresetChannel_A41080.Applicable;
			}
			set
			{
				short num = (short)2140867961;
				short num2 = num;
				num = (short)1029049721;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2010578944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)762576896;
				if (num != 0)
				{
				}
				num = (short)91684865;
				if (num != 0)
				{
				}
				this.labtoolPresetChannel_A41080.Applicable = value;
			}
		}

		// Token: 0x170035E2 RID: 13794
		// (get) Token: 0x060067D6 RID: 26582 RVA: 0x005CBD28 File Offset: 0x005C9F28
		// (set) Token: 0x060067D7 RID: 26583 RVA: 0x005CBDE0 File Offset: 0x005C9FE0
		public bool LabtoolPresetChannel_A41080_Valid
		{
			get
			{
				short num = (short)1194477027;
				short num2 = num;
				num = (short)486032867;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2077949952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1174732801;
				if (num != 0)
				{
				}
				num = (short)393936896;
				if (num != 0)
				{
				}
				return this.labtoolPresetChannel_A41080.Valid;
			}
			set
			{
				short num = (short)740013277;
				short num2 = num;
				num = (short)21411037;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1510735872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2017263616;
				if (num != 0)
				{
				}
				num = (short)493617153;
				if (num != 0)
				{
				}
				this.labtoolPresetChannel_A41080.Valid = value;
			}
		}

		// Token: 0x170035E3 RID: 13795
		// (get) Token: 0x060067D8 RID: 26584 RVA: 0x005CBE94 File Offset: 0x005CA094
		// (set) Token: 0x060067D9 RID: 26585 RVA: 0x005CBF4C File Offset: 0x005CA14C
		public bool LabtoolPresetChannel_A41080_Visible
		{
			get
			{
				short num = (short)1810227614;
				short num2 = num;
				num = (short)682353054;
				switch (num2 == num)
				{
				default:
				{
					num = (short)381878272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)91553793;
				if (num != 0)
				{
				}
				num = (short)1551499264;
				if (num != 0)
				{
				}
				return this.labtoolPresetChannel_A41080.Visible;
			}
			set
			{
				short num = (short)51645496;
				short num2 = num;
				num = (short)1559432248;
				switch (num2 == num)
				{
				default:
				{
					num = (short)272367616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)731971585;
				if (num != 0)
				{
				}
				num = (short)2035941376;
				if (num != 0)
				{
				}
				this.labtoolPresetChannel_A41080.Visible = value;
			}
		}

		// Token: 0x170035E4 RID: 13796
		// (get) Token: 0x060067DA RID: 26586 RVA: 0x005CC000 File Offset: 0x005CA200
		// (set) Token: 0x060067DB RID: 26587 RVA: 0x005CC0B4 File Offset: 0x005CA2B4
		public bool LabtoolPresetChannel_A41080_Editable
		{
			get
			{
				short num = (short)1357525224;
				short num2 = num;
				num = (short)1065431272;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1151795200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1134886912;
				if (num != 0)
				{
				}
				num = (short)1130758145;
				if (num != 0)
				{
				}
				return this.labtoolPresetChannel_A41080.Editable;
			}
			set
			{
				short num = (short)1984167937;
				if (num != 0)
				{
				}
				num = (short)494731264;
				short num2 = num;
				num = (short)1423049164;
				short num3 = num;
				num = (short)296354252;
				switch (num3 == num)
				{
				}
				num = (short)952172544;
				if (num != 0)
				{
				}
				this.labtoolPresetChannel_A41080.Editable = value;
			}
		}

		// Token: 0x170035E5 RID: 13797
		// (get) Token: 0x060067DC RID: 26588 RVA: 0x005CC168 File Offset: 0x005CA368
		internal string LabtoolPresetChannel_A41080_UILabel
		{
			get
			{
				short num = (short)285327286;
				short num2 = num;
				num = (short)1323351990;
				switch (num2 == num)
				{
				default:
				{
					num = (short)541130752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1745879041;
				if (num != 0)
				{
				}
				num = (short)786759680;
				if (num != 0)
				{
				}
				return this.labtoolPresetChannel_A41080.UIName;
			}
		}

		// Token: 0x170035E6 RID: 13798
		// (get) Token: 0x060067DD RID: 26589 RVA: 0x005CC220 File Offset: 0x005CA420
		// (set) Token: 0x060067DE RID: 26590 RVA: 0x005CC2D8 File Offset: 0x005CA4D8
		internal bool LabtoolPresetChannel_A41080_HiddenStatic
		{
			get
			{
				short num = (short)1215565030;
				short num2 = num;
				num = (short)35654886;
				switch (num2 == num)
				{
				default:
				{
					num = (short)525402112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)648347649;
				if (num != 0)
				{
				}
				num = (short)1721499648;
				if (num != 0)
				{
				}
				return this.labtoolPresetChannel_A41080.HiddenStatic;
			}
			set
			{
				short num = (short)310878573;
				short num2 = num;
				num = (short)1641521517;
				switch (num2 == num)
				{
				default:
				{
					num = (short)249167872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1636696064;
				if (num != 0)
				{
				}
				num = (short)1804926977;
				if (num != 0)
				{
				}
				this.labtoolPresetChannel_A41080.HiddenStatic = value;
			}
		}

		// Token: 0x170035E7 RID: 13799
		// (get) Token: 0x060067DF RID: 26591 RVA: 0x005CC38C File Offset: 0x005CA58C
		// (set) Token: 0x060067E0 RID: 26592 RVA: 0x005CC43C File Offset: 0x005CA63C
		internal bool LabtoolPresetChannel_A41080_HiddenDynamic
		{
			get
			{
				short num = (short)1722882231;
				short num2 = num;
				num = (short)1103567031;
				switch (num2 == num)
				{
				default:
				{
					num = (short)584712192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)465436673;
				if (num != 0)
				{
				}
				num = (short)478150656;
				if (num != 0)
				{
				}
				return this.labtoolPresetChannel_A41080.HiddenDynamic;
			}
			set
			{
				short num = (short)1578058007;
				short num2 = num;
				num = (short)1091977495;
				switch (num2 == num)
				{
				default:
				{
					num = (short)690487296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)119930880;
				if (num != 0)
				{
				}
				num = (short)30408705;
				if (num != 0)
				{
				}
				this.labtoolPresetChannel_A41080.HiddenDynamic = value;
			}
		}

		// Token: 0x170035E8 RID: 13800
		// (get) Token: 0x060067E1 RID: 26593 RVA: 0x005CC4F0 File Offset: 0x005CA6F0
		public bool LabtoolPresetChannel_A41080_HasDiffs
		{
			get
			{
				short num = (short)328241077;
				short num2 = num;
				num = (short)1841926069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)506920960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)71958529;
				if (num != 0)
				{
				}
				num = (short)633208832;
				if (num != 0)
				{
				}
				return this.labtoolPresetChannel_A41080._HasDiffs;
			}
		}

		// Token: 0x170035E9 RID: 13801
		// (get) Token: 0x060067E2 RID: 26594 RVA: 0x005CC5A8 File Offset: 0x005CA7A8
		// (set) Token: 0x060067E3 RID: 26595 RVA: 0x005CC65C File Offset: 0x005CA85C
		public string PresetModeSelectValue
		{
			get
			{
				short num = (short)1174505671;
				short num2 = num;
				num = (short)276203719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1687420928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)47382529;
				if (num != 0)
				{
				}
				num = (short)1509228544;
				if (num != 0)
				{
				}
				return this.presetModeSelect.Value;
			}
			set
			{
				short num = (short)1080458839;
				short num2 = num;
				num = (short)1334541911;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1679884288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1436286976;
				if (num != 0)
				{
				}
				num = (short)2045902849;
				if (num != 0)
				{
				}
				this.presetModeSelect.Value = value;
			}
		}

		// Token: 0x170035EA RID: 13802
		// (get) Token: 0x060067E4 RID: 26596 RVA: 0x005CC710 File Offset: 0x005CA910
		public global::AcpBusinessLayer.AcpField<string> PresetModeSelect
		{
			get
			{
				short num = (short)1436615763;
				short num2 = num;
				num = (short)839844947;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1166475264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)136249345;
				if (num != 0)
				{
				}
				num = (short)27394048;
				if (num != 0)
				{
				}
				return this.presetModeSelect;
			}
		}

		// Token: 0x170035EB RID: 13803
		// (get) Token: 0x060067E5 RID: 26597 RVA: 0x005CC7C0 File Offset: 0x005CA9C0
		// (set) Token: 0x060067E6 RID: 26598 RVA: 0x005CC874 File Offset: 0x005CAA74
		public string PresetModeSelect_UIValue
		{
			get
			{
				short num = (short)1960603263;
				short num2 = num;
				num = (short)1741188735;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1843724288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1772224512;
				if (num != 0)
				{
				}
				num = (short)169541633;
				if (num != 0)
				{
				}
				return this.presetModeSelect.Value;
			}
			set
			{
				short num = (short)269025281;
				if (num != 0)
				{
				}
				num = (short)311286309;
				short num2 = num;
				num = (short)871750181;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1006829568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2019622912;
				if (num != 0)
				{
				}
				this.presetModeSelect.Value = value;
			}
		}

		// Token: 0x170035EC RID: 13804
		// (get) Token: 0x060067E7 RID: 26599 RVA: 0x005CC92C File Offset: 0x005CAB2C
		// (set) Token: 0x060067E8 RID: 26600 RVA: 0x005CC9E0 File Offset: 0x005CABE0
		public bool PresetModeSelect_Applicable
		{
			get
			{
				short num = (short)402002365;
				short num2 = num;
				num = (short)1719800253;
				switch (num2 == num)
				{
				}
				num = (short)817299456;
				short num3 = num;
				num = (short)1729363969;
				if (num != 0)
				{
				}
				num = (short)1646002176;
				if (num != 0)
				{
				}
				return this.presetModeSelect.Applicable;
			}
			set
			{
				short num = (short)1024322785;
				short num2 = num;
				num = (short)994503905;
				switch (num2 == num)
				{
				}
				num = (short)1361838080;
				short num3 = num;
				num = (short)872480769;
				if (num != 0)
				{
				}
				num = (short)628686848;
				if (num != 0)
				{
				}
				this.presetModeSelect.Applicable = value;
			}
		}

		// Token: 0x170035ED RID: 13805
		// (get) Token: 0x060067E9 RID: 26601 RVA: 0x005CCA94 File Offset: 0x005CAC94
		// (set) Token: 0x060067EA RID: 26602 RVA: 0x005CCB48 File Offset: 0x005CAD48
		public bool PresetModeSelect_Valid
		{
			get
			{
				short num = (short)2114302599;
				short num2 = num;
				num = (short)630043271;
				switch (num2 == num)
				{
				}
				num = (short)658833408;
				short num3 = num;
				num = (short)737345536;
				if (num != 0)
				{
				}
				num = (short)2073624577;
				if (num != 0)
				{
				}
				return this.presetModeSelect.Valid;
			}
			set
			{
				short num = (short)71434241;
				if (num != 0)
				{
				}
				num = (short)1874983855;
				short num2 = num;
				num = (short)1123548079;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2133196800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)989855744;
				if (num != 0)
				{
				}
				this.presetModeSelect.Valid = value;
			}
		}

		// Token: 0x170035EE RID: 13806
		// (get) Token: 0x060067EB RID: 26603 RVA: 0x005CCC00 File Offset: 0x005CAE00
		// (set) Token: 0x060067EC RID: 26604 RVA: 0x005CCCB4 File Offset: 0x005CAEB4
		public bool PresetModeSelect_Visible
		{
			get
			{
				short num = (short)1615611533;
				short num2 = num;
				num = (short)1912817293;
				switch (num2 == num)
				{
				}
				num = (short)82182144;
				short num3 = num;
				num = (short)1387069441;
				if (num != 0)
				{
				}
				num = (short)1013448704;
				if (num != 0)
				{
				}
				return this.presetModeSelect.Visible;
			}
			set
			{
				short num = (short)855549460;
				short num2 = num;
				num = (short)2069800468;
				switch (num2 == num)
				{
				}
				num = (short)1947992064;
				short num3 = num;
				num = (short)406454273;
				if (num != 0)
				{
				}
				num = (short)1434845184;
				if (num != 0)
				{
				}
				this.presetModeSelect.Visible = value;
			}
		}

		// Token: 0x170035EF RID: 13807
		// (get) Token: 0x060067ED RID: 26605 RVA: 0x005CCD6C File Offset: 0x005CAF6C
		// (set) Token: 0x060067EE RID: 26606 RVA: 0x005CCE1C File Offset: 0x005CB01C
		public bool PresetModeSelect_Editable
		{
			get
			{
				short num = (short)2065711304;
				short num2 = num;
				num = (short)1540833480;
				switch (num2 == num)
				{
				}
				num = (short)2077884416;
				short num3 = num;
				num = (short)1534328833;
				if (num != 0)
				{
				}
				num = (short)1732771840;
				if (num != 0)
				{
				}
				return this.presetModeSelect.Editable;
			}
			set
			{
				short num = (short)1309478885;
				short num2 = num;
				num = (short)151130085;
				switch (num2 == num)
				{
				}
				num = (short)1631191040;
				short num3 = num;
				num = (short)1943666689;
				if (num != 0)
				{
				}
				num = (short)134217728;
				if (num != 0)
				{
				}
				this.presetModeSelect.Editable = value;
			}
		}

		// Token: 0x170035F0 RID: 13808
		// (get) Token: 0x060067EF RID: 26607 RVA: 0x005CCED4 File Offset: 0x005CB0D4
		internal string PresetModeSelect_UILabel
		{
			get
			{
				short num = (short)1872130547;
				short num2 = num;
				num = (short)148664819;
				switch (num2 == num)
				{
				}
				num = (short)2077622272;
				short num3 = num;
				num = (short)807141377;
				if (num != 0)
				{
				}
				num = (short)1059717120;
				if (num != 0)
				{
				}
				return this.presetModeSelect.UIName;
			}
		}

		// Token: 0x170035F1 RID: 13809
		// (get) Token: 0x060067F0 RID: 26608 RVA: 0x005CCF88 File Offset: 0x005CB188
		// (set) Token: 0x060067F1 RID: 26609 RVA: 0x005CD03C File Offset: 0x005CB23C
		internal bool PresetModeSelect_HiddenStatic
		{
			get
			{
				short num = (short)553411300;
				short num2 = num;
				num = (short)565207780;
				switch (num2 == num)
				{
				}
				num = (short)1230438400;
				short num3 = num;
				num = (short)645201921;
				if (num != 0)
				{
				}
				num = (short)284753920;
				if (num != 0)
				{
				}
				return this.presetModeSelect.HiddenStatic;
			}
			set
			{
				short num = (short)1132855310;
				short num2 = num;
				num = (short)737345550;
				switch (num2 == num)
				{
				}
				num = (short)322961408;
				short num3 = num;
				num = (short)4456449;
				if (num != 0)
				{
				}
				num = (short)944832512;
				if (num != 0)
				{
				}
				this.presetModeSelect.HiddenStatic = value;
			}
		}

		// Token: 0x170035F2 RID: 13810
		// (get) Token: 0x060067F2 RID: 26610 RVA: 0x005CD0F0 File Offset: 0x005CB2F0
		// (set) Token: 0x060067F3 RID: 26611 RVA: 0x005CD1A4 File Offset: 0x005CB3A4
		internal bool PresetModeSelect_HiddenDynamic
		{
			get
			{
				short num = (short)2116467769;
				short num2 = num;
				num = (short)561691705;
				switch (num2 == num)
				{
				}
				num = (short)1803616256;
				short num3 = num;
				num = (short)57081857;
				if (num != 0)
				{
				}
				num = (short)823787520;
				if (num != 0)
				{
				}
				return this.presetModeSelect.HiddenDynamic;
			}
			set
			{
				short num = (short)847174541;
				short num2 = num;
				num = (short)592632717;
				switch (num2 == num)
				{
				}
				num = (short)14811136;
				short num3 = num;
				num = (short)1299578880;
				if (num != 0)
				{
				}
				num = (short)1388249089;
				if (num != 0)
				{
				}
				this.presetModeSelect.HiddenDynamic = value;
			}
		}

		// Token: 0x170035F3 RID: 13811
		// (get) Token: 0x060067F4 RID: 26612 RVA: 0x005CD25C File Offset: 0x005CB45C
		public bool PresetModeSelect_HasDiffs
		{
			get
			{
				short num = (short)1780406668;
				short num2 = num;
				num = (short)375970188;
				switch (num2 == num)
				{
				}
				num = (short)1817968640;
				short num3 = num;
				num = (short)1798045696;
				if (num != 0)
				{
				}
				num = (short)1081475073;
				if (num != 0)
				{
				}
				return this.presetModeSelect._HasDiffs;
			}
		}

		// Token: 0x060067F5 RID: 26613 RVA: 0x005CD310 File Offset: 0x005CB510
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_127;
				case 1:
					goto IL_141;
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)1982201860;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1207631872;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)1265893377;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_127:
			return result;
			IL_141:
			if (base.ParentRecset.ContainerDoc != null)
			{
				goto IL_14E;
			}
			return result;
			IL_24:
			num2 = (short)1565327360;
			short num3 = num2;
			num2 = (short)1536566982;
			short num4 = num2;
			num2 = (short)1639589574;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_14E:
				num2 = (short)1859059715;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)912261121;
				if (num2 != 0)
				{
				}
				num2 = (short)1539964928;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)88014850;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x040026BF RID: 9919
		private global::AcpBusinessLayer.AcpRecRefField labtoolPresetZone_A41079;

		// Token: 0x040026C0 RID: 9920
		private global::AcpBusinessLayer.AcpRangeField<int, string> labtoolPresetChannel_A41080;

		// Token: 0x040026C1 RID: 9921
		private global::AcpBusinessLayer.AcpField<string> presetModeSelect;
	}
}
