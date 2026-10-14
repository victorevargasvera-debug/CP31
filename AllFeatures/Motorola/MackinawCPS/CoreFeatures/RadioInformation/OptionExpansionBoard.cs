using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioInformation
{
	// Token: 0x020001AD RID: 429
	[global::System.Serializable]
	public class OptionExpansionBoard : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06005075 RID: 20597 RVA: 0x0048E868 File Offset: 0x0048CA68
		public OptionExpansionBoard(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06005076 RID: 20598 RVA: 0x0048E884 File Offset: 0x0048CA84
		protected OptionExpansionBoard(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x0048E89C File Offset: 0x0048CA9C
		public override void Init()
		{
			int a_ = 5;
			short num = (short)1757937665;
			if (num != 0)
			{
			}
			num = (short)1177616384;
			short num2 = num;
			num = (short)1053702315;
			short num3 = num;
			num = (short)216742059;
			switch (num3 == num)
			{
			}
			num = (short)1007353856;
			if (num != 0)
			{
			}
			this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鯓ꛕ곗동돛냝ꗟ髡铣蟥蛧駩藫臭黯냱鯳韵諷黹뻻釽懿瀁怃䀅愇砉愋礍焏怑焓䀕紗栙漛眝伟䰡笣朥ᬧᴩᰫᨭ࠯", a_), global::CommonResources.AcgResources.ID_BOARDFIRMWAREVERSION, 100);
			this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.DataTransferOrder = -1;
			this.radInfoOptionExpansionBoardBoardType_A37049 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鯓ꛕ곗동돛냝ꗟ髡铣蟥蛧駩藫臭黯냱鯳韵諷黹뻻釽懿瀁怃刅焇稉椋儍儏ℑ⌓☕Ⱇ⌙", a_), global::CommonResources.AcgResources.ID_BOARDTYPE, 100);
			this.radInfoOptionExpansionBoardBoardType_A37049.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoOptionExpansionBoardBoardType_A37049.DataTransferOrder = -1;
			this.radInfoOptionExpansionBoardBoardName_A37549 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鯓ꛕ곗동돛냝ꗟ髡铣蟥蛧駩藫臭黯냱鯳韵諷黹뻻釽懿瀁怃䠅椇有椋儍儏ℑ⌓⌕Ⱇ⌙", a_), global::CommonResources.AcgResources.ID_BOARDNAME, 14);
			this.radInfoOptionExpansionBoardBoardName_A37549.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoOptionExpansionBoardBoardName_A37549.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("觅룇뻉ꗋꇍ뻏﷑釓껕꣗믙닛귝觟跡諣웥ꫧ藩跫鳭铯", a_);
			base.Id = 10631;
			base.UIName = global::CommonResources.AcgResources.ID_OPTIONEXPANSIONBOARD;
			base.DataTransferOrder = 7;
		}

		// Token: 0x06005078 RID: 20600 RVA: 0x0048EA38 File Offset: 0x0048CC38
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 3;
			short num = (short)499318793;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.radInfoOptionExpansionBoardBoardName_A37549 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇菉ꋋ꣍뿏鷑ꓓꋕ뇗뗙닛鯝食鋡藣裥鯧菩菫胭닯鷱闳蓵鳷룹鏻鿽狿昁䨃朅攇漉匋伍⌏┑ℓ∕℗", a_), global::CommonResources.AcgResources.ID_BOARDNAME, 14);
					this.radInfoOptionExpansionBoardBoardName_A37549.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoOptionExpansionBoardBoardName_A37549.DataTransferOrder = -1;
					num = (short)1355022340;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields != null)
					{
						num = (short)99155976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_350;
				case 2:
					this.radInfoOptionExpansionBoardBoardType_A37049 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇菉ꋋ꣍뿏鷑ꓓꋕ뇗뗙닛鯝食鋡藣裥鯧菩菫胭닯鷱闳蓵鳷룹鏻鿽狿昁倃缅砇漉匋伍⌏┑␓∕℗", a_), global::CommonResources.AcgResources.ID_BOARDTYPE, 100);
					this.radInfoOptionExpansionBoardBoardType_A37049.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoOptionExpansionBoardBoardType_A37049.DataTransferOrder = -1;
					num = (short)1034420235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雃Ʂ곇菉ꋋ꣍뿏鷑ꓓꋕ뇗뗙닛鯝食鋡藣裥鯧菩菫胭닯鷱闳蓵鳷룹鏻鿽狿昁䨃朅攇漉匋伍⌏┑ℓ∕℗", a_)))
					{
						num = (short)2022113280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_350;
				case 4:
					goto IL_26C;
				case 5:
					goto IL_12C;
				case 6:
					num = (short)760217601;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇菉ꋋ꣍뿏鷑ꓓꋕ뇗뗙닛鯝食鋡藣裥鯧菩菫胭닯鷱闳蓵鳷룹鏻鿽狿昁䈃漅稇有笋漍戏眑䈓猕樗椙甛焝丟紡攣ᔥἧᨩᠫᘭ", a_), global::CommonResources.AcgResources.ID_BOARDFIRMWAREVERSION, 100);
					this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.DataTransferOrder = -1;
					num = (short)1433731077;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_2A6;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 10:
					num = (short)698286081;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雃Ʂ곇菉ꋋ꣍뿏鷑ꓓꋕ뇗뗙닛鯝食鋡藣裥鯧菩菫胭닯鷱闳蓵鳷룹鏻鿽狿昁倃缅砇漉匋伍⌏┑␓∕℗", a_)))
					{
						num = (short)996802562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AB;
				case 11:
					goto IL_2AB;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雃Ʂ곇菉ꋋ꣍뿏鷑ꓓꋕ뇗뗙닛鯝食鋡藣裥鯧菩菫胭닯鷱闳蓵鳷룹鏻鿽狿昁䈃漅稇有笋漍戏眑䈓猕樗椙甛焝丟紡攣ᔥἧᨩᠫᘭ", a_)))
					{
						num = (short)935329799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12C;
				}
				IL_61:
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					break;
				}
				num = (short)192124428;
				short num3 = num;
				num = (short)801216012;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_2A6;
				default:
					num = (short)370671616;
					if (num != 0)
					{
					}
					num = (short)964886534;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_12C:
				num = (short)2024538112;
				short num4 = num;
				num = (short)971243530;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2A6:
				num = (short)572391436;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2AB:
				num = (short)530186243;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_26C:
			IL_350:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("诃뛅볇ꏉꏋꃍￏ韑곓ꛕ맗듙꿛럝迟賡쓣ꓥ蟧诩黫諭", a_);
			base.Id = 10631;
			base.UIName = global::CommonResources.AcgResources.ID_OPTIONEXPANSIONBOARD;
			base.DataTransferOrder = 7;
		}

		// Token: 0x06005079 RID: 20601 RVA: 0x0048EDC8 File Offset: 0x0048CFC8
		public override void PopulateReferences()
		{
			short num = (short)92835633;
			short num2 = num;
			num = (short)1181126449;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1147469824;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)528941056;
			if (num != 0)
			{
			}
			num = (short)1888485377;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600507A RID: 20602 RVA: 0x0048EE74 File Offset: 0x0048D074
		public override void DropReferences()
		{
			short num = (short)2045961086;
			short num2 = num;
			num = (short)1518265214;
			switch (num2 == num)
			{
			default:
			{
				num = (short)134676480;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1373962241;
			if (num != 0)
			{
			}
			num = (short)1426259968;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600507B RID: 20603 RVA: 0x0048EF1C File Offset: 0x0048D11C
		public override void SetConstraints()
		{
			short num = (short)1271902364;
			short num2 = num;
			num = (short)1037086876;
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
			num = (short)451280896;
			if (num != 0)
			{
			}
			num = (short)1064697857;
			if (num != 0)
			{
			}
			this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoOptionExpansionBoardBoardType_A37049.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoOptionExpansionBoardBoardName_A37549.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x0600507C RID: 20604 RVA: 0x0048F00C File Offset: 0x0048D20C
		public override void SetupDependencies()
		{
			short num = (short)1942290433;
			if (num != 0)
			{
			}
			num = (short)686424064;
			short num2 = num;
			num = (short)1347110233;
			short num3 = num;
			num = (short)95896921;
			switch (num3 == num)
			{
			}
			num = (short)417005568;
			if (num != 0)
			{
			}
		}

		// Token: 0x170029E3 RID: 10723
		// (get) Token: 0x0600507D RID: 20605 RVA: 0x0048F0B4 File Offset: 0x0048D2B4
		public bool HasDiffs
		{
			get
			{
				short num = (short)1191906506;
				short num2 = num;
				num = (short)2052525258;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1035534336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)166461441;
				if (num != 0)
				{
				}
				num = (short)1668022272;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170029E4 RID: 10724
		// (get) Token: 0x0600507E RID: 20606 RVA: 0x0048F164 File Offset: 0x0048D364
		// (set) Token: 0x0600507F RID: 20607 RVA: 0x0048F21C File Offset: 0x0048D41C
		public string RadInfoOptionExpansionBoardBoardFirmwareVersion_A37048Value
		{
			get
			{
				short num = (short)1188341214;
				short num2 = num;
				num = (short)1613669854;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2125463552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1627062272;
				if (num != 0)
				{
				}
				num = (short)587726849;
				if (num != 0)
				{
				}
				return this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.Value;
			}
			set
			{
				short num = (short)1485766804;
				short num2 = num;
				num = (short)323354772;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1892286464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)330104833;
				if (num != 0)
				{
				}
				num = (short)867434496;
				if (num != 0)
				{
				}
				this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.Value = value;
			}
		}

		// Token: 0x170029E5 RID: 10725
		// (get) Token: 0x06005080 RID: 20608 RVA: 0x0048F2D0 File Offset: 0x0048D4D0
		public global::AcpBusinessLayer.AcpField<string> RadInfoOptionExpansionBoardBoardFirmwareVersion_A37048
		{
			get
			{
				short num = (short)1738639732;
				short num2 = num;
				num = (short)599165300;
				switch (num2 == num)
				{
				default:
				{
					num = (short)708050944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)75104257;
				if (num != 0)
				{
				}
				num = (short)1850933248;
				if (num != 0)
				{
				}
				return this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048;
			}
		}

		// Token: 0x170029E6 RID: 10726
		// (get) Token: 0x06005081 RID: 20609 RVA: 0x0048F380 File Offset: 0x0048D580
		// (set) Token: 0x06005082 RID: 20610 RVA: 0x0048F434 File Offset: 0x0048D634
		public string RadInfoOptionExpansionBoardBoardFirmwareVersion_A37048_UIValue
		{
			get
			{
				short num = (short)1087814398;
				short num2 = num;
				num = (short)1386724094;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1172176896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1665925120;
				if (num != 0)
				{
				}
				num = (short)1716191233;
				if (num != 0)
				{
				}
				return this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.Value;
			}
			set
			{
				short num = (short)1621577238;
				short num2 = num;
				num = (short)357977622;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1582825472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)384303105;
				if (num != 0)
				{
				}
				num = (short)1076690944;
				if (num != 0)
				{
				}
				this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.Value = value;
			}
		}

		// Token: 0x170029E7 RID: 10727
		// (get) Token: 0x06005083 RID: 20611 RVA: 0x0048F4EC File Offset: 0x0048D6EC
		// (set) Token: 0x06005084 RID: 20612 RVA: 0x0048F5A4 File Offset: 0x0048D7A4
		public bool RadInfoOptionExpansionBoardBoardFirmwareVersion_A37048_Applicable
		{
			get
			{
				short num = (short)1143374406;
				short num2 = num;
				num = (short)107315782;
				switch (num2 == num)
				{
				default:
				{
					num = (short)703987712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)161480705;
				if (num != 0)
				{
				}
				num = (short)1880293376;
				if (num != 0)
				{
				}
				return this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.Applicable;
			}
			set
			{
				short num = (short)815118261;
				short num2 = num;
				num = (short)1427224501;
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
				num = (short)515506176;
				if (num != 0)
				{
				}
				num = (short)651689985;
				if (num != 0)
				{
				}
				this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.Applicable = value;
			}
		}

		// Token: 0x170029E8 RID: 10728
		// (get) Token: 0x06005085 RID: 20613 RVA: 0x0048F658 File Offset: 0x0048D858
		// (set) Token: 0x06005086 RID: 20614 RVA: 0x0048F70C File Offset: 0x0048D90C
		public bool RadInfoOptionExpansionBoardBoardFirmwareVersion_A37048_Valid
		{
			get
			{
				short num = (short)746052840;
				short num2 = num;
				num = (short)1295572200;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1234305024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)724500481;
				if (num != 0)
				{
				}
				num = (short)860094464;
				if (num != 0)
				{
				}
				return this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.Valid;
			}
			set
			{
				short num = (short)1919917410;
				short num2 = num;
				num = (short)992976226;
				switch (num2 == num)
				{
				default:
				{
					num = (short)557711360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1174601728;
				if (num != 0)
				{
				}
				num = (short)1733754881;
				if (num != 0)
				{
				}
				this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.Valid = value;
			}
		}

		// Token: 0x170029E9 RID: 10729
		// (get) Token: 0x06005087 RID: 20615 RVA: 0x0048F7C0 File Offset: 0x0048D9C0
		// (set) Token: 0x06005088 RID: 20616 RVA: 0x0048F870 File Offset: 0x0048DA70
		public bool RadInfoOptionExpansionBoardBoardFirmwareVersion_A37048_Visible
		{
			get
			{
				short num = (short)681581404;
				short num2 = num;
				num = (short)1361517404;
				switch (num2 == num)
				{
				default:
				{
					num = (short)209453056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1573650433;
				if (num != 0)
				{
				}
				num = (short)1108934656;
				if (num != 0)
				{
				}
				return this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.Visible;
			}
			set
			{
				short num = (short)162110727;
				short num2 = num;
				num = (short)1597938951;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1563033600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1952579584;
				if (num != 0)
				{
				}
				num = (short)1282080769;
				if (num != 0)
				{
				}
				this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.Visible = value;
			}
		}

		// Token: 0x170029EA RID: 10730
		// (get) Token: 0x06005089 RID: 20617 RVA: 0x0048F928 File Offset: 0x0048DB28
		// (set) Token: 0x0600508A RID: 20618 RVA: 0x0048F9DC File Offset: 0x0048DBDC
		public bool RadInfoOptionExpansionBoardBoardFirmwareVersion_A37048_Editable
		{
			get
			{
				short num = (short)849942412;
				short num2 = num;
				num = (short)186652556;
				switch (num2 == num)
				{
				default:
				{
					num = (short)793247744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1370750977;
				if (num != 0)
				{
				}
				num = (short)765526016;
				if (num != 0)
				{
				}
				return this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.Editable;
			}
			set
			{
				short num = (short)1503689802;
				short num2 = num;
				num = (short)1759935562;
				switch (num2 == num)
				{
				default:
				{
					num = (short)122290176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1608908801;
				if (num != 0)
				{
				}
				num = (short)1338638336;
				if (num != 0)
				{
				}
				this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.Editable = value;
			}
		}

		// Token: 0x170029EB RID: 10731
		// (get) Token: 0x0600508B RID: 20619 RVA: 0x0048FA90 File Offset: 0x0048DC90
		internal string RadInfoOptionExpansionBoardBoardFirmwareVersion_A37048_UILabel
		{
			get
			{
				short num = (short)1805636538;
				short num2 = num;
				num = (short)1105318842;
				switch (num2 == num)
				{
				default:
				{
					num = (short)428802048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1705639937;
				if (num != 0)
				{
				}
				num = (short)1876426752;
				if (num != 0)
				{
				}
				return this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.UIName;
			}
		}

		// Token: 0x170029EC RID: 10732
		// (get) Token: 0x0600508C RID: 20620 RVA: 0x0048FB44 File Offset: 0x0048DD44
		// (set) Token: 0x0600508D RID: 20621 RVA: 0x0048FBFC File Offset: 0x0048DDFC
		internal bool RadInfoOptionExpansionBoardBoardFirmwareVersion_A37048_HiddenStatic
		{
			get
			{
				short num = (short)2125598560;
				short num2 = num;
				num = (short)719523680;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1188757504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1660747776;
				if (num != 0)
				{
				}
				num = (short)679542785;
				if (num != 0)
				{
				}
				return this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.HiddenStatic;
			}
			set
			{
				short num = (short)1687337926;
				short num2 = num;
				num = (short)2086517702;
				switch (num2 == num)
				{
				}
				num = (short)1429667841;
				if (num != 0)
				{
				}
				num = (short)1884749824;
				if (num != 0)
				{
				}
				num = (short)1206452224;
				short num3 = num;
				this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.HiddenStatic = value;
			}
		}

		// Token: 0x170029ED RID: 10733
		// (get) Token: 0x0600508E RID: 20622 RVA: 0x0048FCB0 File Offset: 0x0048DEB0
		// (set) Token: 0x0600508F RID: 20623 RVA: 0x0048FD64 File Offset: 0x0048DF64
		internal bool RadInfoOptionExpansionBoardBoardFirmwareVersion_A37048_HiddenDynamic
		{
			get
			{
				short num = (short)1696791451;
				short num2 = num;
				num = (short)569834395;
				switch (num2 == num)
				{
				}
				num = (short)896860161;
				if (num != 0)
				{
				}
				num = (short)473890816;
				if (num != 0)
				{
				}
				num = (short)1047789568;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.HiddenDynamic;
			}
			set
			{
				short num = (short)850100235;
				short num2 = num;
				num = (short)824016907;
				switch (num2 == num)
				{
				}
				num = (short)1495662593;
				if (num != 0)
				{
				}
				num = (short)1744764928;
				if (num != 0)
				{
				}
				num = (short)2686976;
				short num3 = num;
				this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048.HiddenDynamic = value;
			}
		}

		// Token: 0x170029EE RID: 10734
		// (get) Token: 0x06005090 RID: 20624 RVA: 0x0048FE1C File Offset: 0x0048E01C
		public bool RadInfoOptionExpansionBoardBoardFirmwareVersion_A37048_HasDiffs
		{
			get
			{
				short num = (short)879083894;
				short num2 = num;
				num = (short)1398522230;
				switch (num2 == num)
				{
				}
				num = (short)1499463681;
				if (num != 0)
				{
				}
				num = (short)1862664192;
				if (num != 0)
				{
				}
				num = (short)1986199552;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardFirmwareVersion_A37048._HasDiffs;
			}
		}

		// Token: 0x170029EF RID: 10735
		// (get) Token: 0x06005091 RID: 20625 RVA: 0x0048FED0 File Offset: 0x0048E0D0
		// (set) Token: 0x06005092 RID: 20626 RVA: 0x0048FF84 File Offset: 0x0048E184
		public string RadInfoOptionExpansionBoardBoardType_A37049Value
		{
			get
			{
				short num = (short)805403218;
				short num2 = num;
				num = (short)1085045330;
				switch (num2 == num)
				{
				}
				num = (short)1433862145;
				if (num != 0)
				{
				}
				num = (short)2055995392;
				if (num != 0)
				{
				}
				num = (short)1554776064;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardType_A37049.Value;
			}
			set
			{
				short num = (short)1830203794;
				short num2 = num;
				num = (short)1991225746;
				switch (num2 == num)
				{
				}
				num = (short)1637285889;
				if (num != 0)
				{
				}
				num = (short)428146688;
				if (num != 0)
				{
				}
				num = (short)1049296896;
				short num3 = num;
				this.radInfoOptionExpansionBoardBoardType_A37049.Value = value;
			}
		}

		// Token: 0x170029F0 RID: 10736
		// (get) Token: 0x06005093 RID: 20627 RVA: 0x0049003C File Offset: 0x0048E23C
		public global::AcpBusinessLayer.AcpField<string> RadInfoOptionExpansionBoardBoardType_A37049
		{
			get
			{
				short num = (short)685768705;
				if (num != 0)
				{
				}
				num = (short)1746855422;
				short num2 = num;
				num = (short)272623102;
				switch (num2 == num)
				{
				}
				num = (short)354418688;
				if (num != 0)
				{
				}
				num = (short)356974592;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardType_A37049;
			}
		}

		// Token: 0x170029F1 RID: 10737
		// (get) Token: 0x06005094 RID: 20628 RVA: 0x004900EC File Offset: 0x0048E2EC
		// (set) Token: 0x06005095 RID: 20629 RVA: 0x004901A0 File Offset: 0x0048E3A0
		public string RadInfoOptionExpansionBoardBoardType_A37049_UIValue
		{
			get
			{
				short num = (short)1272139033;
				short num2 = num;
				num = (short)48319769;
				switch (num2 == num)
				{
				}
				num = (short)1144389632;
				if (num != 0)
				{
				}
				num = (short)804847617;
				if (num != 0)
				{
				}
				num = (short)540803072;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardType_A37049.Value;
			}
			set
			{
				short num = (short)978190337;
				if (num != 0)
				{
				}
				num = (short)853263599;
				short num2 = num;
				num = (short)432194799;
				switch (num2 == num)
				{
				}
				num = (short)729284608;
				if (num != 0)
				{
				}
				num = (short)1685258240;
				short num3 = num;
				this.radInfoOptionExpansionBoardBoardType_A37049.Value = value;
			}
		}

		// Token: 0x170029F2 RID: 10738
		// (get) Token: 0x06005096 RID: 20630 RVA: 0x00490258 File Offset: 0x0048E458
		// (set) Token: 0x06005097 RID: 20631 RVA: 0x0049030C File Offset: 0x0048E50C
		public bool RadInfoOptionExpansionBoardBoardType_A37049_Applicable
		{
			get
			{
				short num = (short)1109781717;
				short num2 = num;
				num = (short)704834773;
				switch (num2 == num)
				{
				}
				num = (short)131530752;
				if (num != 0)
				{
				}
				num = (short)579076097;
				if (num != 0)
				{
				}
				num = (short)6029312;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardType_A37049.Applicable;
			}
			set
			{
				short num = (short)1426470392;
				short num2 = num;
				num = (short)496121336;
				switch (num2 == num)
				{
				}
				num = (short)1214382081;
				if (num != 0)
				{
				}
				num = (short)1564606464;
				if (num != 0)
				{
				}
				num = (short)1825046528;
				short num3 = num;
				this.radInfoOptionExpansionBoardBoardType_A37049.Applicable = value;
			}
		}

		// Token: 0x170029F3 RID: 10739
		// (get) Token: 0x06005098 RID: 20632 RVA: 0x004903C0 File Offset: 0x0048E5C0
		// (set) Token: 0x06005099 RID: 20633 RVA: 0x00490474 File Offset: 0x0048E674
		public bool RadInfoOptionExpansionBoardBoardType_A37049_Valid
		{
			get
			{
				short num = (short)1795654959;
				short num2 = num;
				num = (short)293373231;
				switch (num2 == num)
				{
				}
				num = (short)109314049;
				if (num != 0)
				{
				}
				num = (short)946208768;
				if (num != 0)
				{
				}
				num = (short)411566080;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardType_A37049.Valid;
			}
			set
			{
				short num = (short)2021261313;
				if (num != 0)
				{
				}
				num = (short)1722862230;
				short num2 = num;
				num = (short)736676502;
				switch (num2 == num)
				{
				}
				num = (short)447873024;
				if (num != 0)
				{
				}
				num = (short)1141637120;
				short num3 = num;
				this.radInfoOptionExpansionBoardBoardType_A37049.Valid = value;
			}
		}

		// Token: 0x170029F4 RID: 10740
		// (get) Token: 0x0600509A RID: 20634 RVA: 0x00490528 File Offset: 0x0048E728
		// (set) Token: 0x0600509B RID: 20635 RVA: 0x004905DC File Offset: 0x0048E7DC
		public bool RadInfoOptionExpansionBoardBoardType_A37049_Visible
		{
			get
			{
				short num = (short)1975972050;
				short num2 = num;
				num = (short)699134162;
				switch (num2 == num)
				{
				}
				num = (short)432799744;
				if (num != 0)
				{
				}
				num = (short)476053505;
				if (num != 0)
				{
				}
				num = (short)47382528;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardType_A37049.Visible;
			}
			set
			{
				short num = (short)205193217;
				if (num != 0)
				{
				}
				num = (short)1045485498;
				short num2 = num;
				num = (short)2089277370;
				switch (num2 == num)
				{
				}
				num = (short)257884160;
				if (num != 0)
				{
				}
				num = (short)502988800;
				short num3 = num;
				this.radInfoOptionExpansionBoardBoardType_A37049.Visible = value;
			}
		}

		// Token: 0x170029F5 RID: 10741
		// (get) Token: 0x0600509C RID: 20636 RVA: 0x00490690 File Offset: 0x0048E890
		// (set) Token: 0x0600509D RID: 20637 RVA: 0x00490744 File Offset: 0x0048E944
		public bool RadInfoOptionExpansionBoardBoardType_A37049_Editable
		{
			get
			{
				short num = (short)695105489;
				short num2 = num;
				num = (short)1267169233;
				switch (num2 == num)
				{
				}
				num = (short)1883308033;
				if (num != 0)
				{
				}
				num = (short)2036793344;
				if (num != 0)
				{
				}
				num = (short)1919614976;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardType_A37049.Editable;
			}
			set
			{
				short num = (short)1519915246;
				short num2 = num;
				num = (short)1413943534;
				switch (num2 == num)
				{
				}
				num = (short)1998782465;
				if (num != 0)
				{
				}
				num = (short)1937375232;
				if (num != 0)
				{
				}
				num = (short)70385664;
				short num3 = num;
				this.radInfoOptionExpansionBoardBoardType_A37049.Editable = value;
			}
		}

		// Token: 0x170029F6 RID: 10742
		// (get) Token: 0x0600509E RID: 20638 RVA: 0x004907F8 File Offset: 0x0048E9F8
		internal string RadInfoOptionExpansionBoardBoardType_A37049_UILabel
		{
			get
			{
				short num = (short)1525470214;
				short num2 = num;
				num = (short)1860817926;
				switch (num2 == num)
				{
				}
				num = (short)911867904;
				if (num != 0)
				{
				}
				num = (short)1145765889;
				if (num != 0)
				{
				}
				num = (short)1314848768;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardType_A37049.UIName;
			}
		}

		// Token: 0x170029F7 RID: 10743
		// (get) Token: 0x0600509F RID: 20639 RVA: 0x004908A8 File Offset: 0x0048EAA8
		// (set) Token: 0x060050A0 RID: 20640 RVA: 0x00490960 File Offset: 0x0048EB60
		internal bool RadInfoOptionExpansionBoardBoardType_A37049_HiddenStatic
		{
			get
			{
				short num = (short)405471233;
				if (num != 0)
				{
				}
				num = (short)1135292871;
				short num2 = num;
				num = (short)1395601863;
				switch (num2 == num)
				{
				}
				num = (short)1781006336;
				if (num != 0)
				{
				}
				num = (short)4849664;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardType_A37049.HiddenStatic;
			}
			set
			{
				short num = (short)668906837;
				short num2 = num;
				num = (short)1568650581;
				switch (num2 == num)
				{
				}
				num = (short)231931905;
				if (num != 0)
				{
				}
				num = (short)277217280;
				if (num != 0)
				{
				}
				num = (short)213712896;
				short num3 = num;
				this.radInfoOptionExpansionBoardBoardType_A37049.HiddenStatic = value;
			}
		}

		// Token: 0x170029F8 RID: 10744
		// (get) Token: 0x060050A1 RID: 20641 RVA: 0x00490A18 File Offset: 0x0048EC18
		// (set) Token: 0x060050A2 RID: 20642 RVA: 0x00490ACC File Offset: 0x0048ECCC
		internal bool RadInfoOptionExpansionBoardBoardType_A37049_HiddenDynamic
		{
			get
			{
				short num = (short)1055650812;
				short num2 = num;
				num = (short)1132393468;
				switch (num2 == num)
				{
				}
				num = (short)344129537;
				if (num != 0)
				{
				}
				num = (short)1993801728;
				if (num != 0)
				{
				}
				num = (short)2110521344;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardType_A37049.HiddenDynamic;
			}
			set
			{
				short num = (short)1937990901;
				short num2 = num;
				num = (short)1206215925;
				switch (num2 == num)
				{
				}
				num = (short)896598017;
				if (num != 0)
				{
				}
				num = (short)1420886016;
				if (num != 0)
				{
				}
				num = (short)596115456;
				short num3 = num;
				this.radInfoOptionExpansionBoardBoardType_A37049.HiddenDynamic = value;
			}
		}

		// Token: 0x170029F9 RID: 10745
		// (get) Token: 0x060050A3 RID: 20643 RVA: 0x00490B84 File Offset: 0x0048ED84
		public bool RadInfoOptionExpansionBoardBoardType_A37049_HasDiffs
		{
			get
			{
				short num = (short)837760614;
				short num2 = num;
				num = (short)1073493606;
				switch (num2 == num)
				{
				}
				num = (short)1487601665;
				if (num != 0)
				{
				}
				num = (short)633208832;
				if (num != 0)
				{
				}
				num = (short)2129068032;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardType_A37049._HasDiffs;
			}
		}

		// Token: 0x170029FA RID: 10746
		// (get) Token: 0x060050A4 RID: 20644 RVA: 0x00490C38 File Offset: 0x0048EE38
		// (set) Token: 0x060050A5 RID: 20645 RVA: 0x00490CEC File Offset: 0x0048EEEC
		public string RadInfoOptionExpansionBoardBoardName_A37549Value
		{
			get
			{
				short num = (short)1532367932;
				short num2 = num;
				num = (short)1284052028;
				switch (num2 == num)
				{
				}
				num = (short)2054553601;
				if (num != 0)
				{
				}
				num = (short)116391936;
				if (num != 0)
				{
				}
				num = (short)94961664;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardName_A37549.Value;
			}
			set
			{
				short num = (short)1448280065;
				if (num != 0)
				{
				}
				num = (short)303499223;
				short num2 = num;
				num = (short)165939159;
				switch (num2 == num)
				{
				}
				num = (short)979238912;
				if (num != 0)
				{
				}
				num = (short)670498816;
				short num3 = num;
				this.radInfoOptionExpansionBoardBoardName_A37549.Value = value;
			}
		}

		// Token: 0x170029FB RID: 10747
		// (get) Token: 0x060050A6 RID: 20646 RVA: 0x00490DA0 File Offset: 0x0048EFA0
		public global::AcpBusinessLayer.AcpField<string> RadInfoOptionExpansionBoardBoardName_A37549
		{
			get
			{
				short num = (short)951168329;
				short num2 = num;
				num = (short)1685630281;
				switch (num2 == num)
				{
				}
				num = (short)2017984513;
				if (num != 0)
				{
				}
				num = (short)530055168;
				if (num != 0)
				{
				}
				num = (short)757137408;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardName_A37549;
			}
		}

		// Token: 0x170029FC RID: 10748
		// (get) Token: 0x060050A7 RID: 20647 RVA: 0x00490E50 File Offset: 0x0048F050
		// (set) Token: 0x060050A8 RID: 20648 RVA: 0x00490F04 File Offset: 0x0048F104
		public string RadInfoOptionExpansionBoardBoardName_A37549_UIValue
		{
			get
			{
				short num = (short)1294764466;
				short num2 = num;
				num = (short)1596492210;
				switch (num2 == num)
				{
				}
				num = (short)923860993;
				if (num != 0)
				{
				}
				num = (short)1316290560;
				if (num != 0)
				{
				}
				num = (short)364314624;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardName_A37549.Value;
			}
			set
			{
				short num = (short)349831169;
				if (num != 0)
				{
				}
				num = (short)2076642558;
				short num2 = num;
				num = (short)1417678078;
				switch (num2 == num)
				{
				}
				num = (short)86179840;
				if (num != 0)
				{
				}
				num = (short)315490304;
				short num3 = num;
				this.radInfoOptionExpansionBoardBoardName_A37549.Value = value;
			}
		}

		// Token: 0x170029FD RID: 10749
		// (get) Token: 0x060050A9 RID: 20649 RVA: 0x00490FB8 File Offset: 0x0048F1B8
		// (set) Token: 0x060050AA RID: 20650 RVA: 0x00491070 File Offset: 0x0048F270
		public bool RadInfoOptionExpansionBoardBoardName_A37549_Applicable
		{
			get
			{
				short num = (short)89498468;
				short num2 = num;
				num = (short)1299030884;
				switch (num2 == num)
				{
				}
				num = (short)1884028929;
				if (num != 0)
				{
				}
				num = (short)1109917696;
				if (num != 0)
				{
				}
				num = (short)537329664;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardName_A37549.Applicable;
			}
			set
			{
				short num = (short)1760012621;
				short num2 = num;
				num = (short)50506061;
				switch (num2 == num)
				{
				}
				num = (short)1660616704;
				if (num != 0)
				{
				}
				num = (short)1713111041;
				if (num != 0)
				{
				}
				num = (short)1073676288;
				short num3 = num;
				this.radInfoOptionExpansionBoardBoardName_A37549.Applicable = value;
			}
		}

		// Token: 0x170029FE RID: 10750
		// (get) Token: 0x060050AB RID: 20651 RVA: 0x00491128 File Offset: 0x0048F328
		// (set) Token: 0x060050AC RID: 20652 RVA: 0x004911E0 File Offset: 0x0048F3E0
		public bool RadInfoOptionExpansionBoardBoardName_A37549_Valid
		{
			get
			{
				short num = (short)976123525;
				short num2 = num;
				num = (short)1013937797;
				switch (num2 == num)
				{
				}
				num = (short)661192705;
				if (num != 0)
				{
				}
				num = (short)1947664384;
				if (num != 0)
				{
				}
				num = (short)1492844544;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardName_A37549.Valid;
			}
			set
			{
				short num = (short)368812365;
				short num2 = num;
				num = (short)1232380237;
				switch (num2 == num)
				{
				}
				num = (short)331546625;
				if (num != 0)
				{
				}
				num = (short)113967104;
				if (num != 0)
				{
				}
				num = (short)7012352;
				short num3 = num;
				this.radInfoOptionExpansionBoardBoardName_A37549.Valid = value;
			}
		}

		// Token: 0x170029FF RID: 10751
		// (get) Token: 0x060050AD RID: 20653 RVA: 0x00491298 File Offset: 0x0048F498
		// (set) Token: 0x060050AE RID: 20654 RVA: 0x0049134C File Offset: 0x0048F54C
		public bool RadInfoOptionExpansionBoardBoardName_A37549_Visible
		{
			get
			{
				short num = (short)316382042;
				short num2 = num;
				num = (short)539335514;
				switch (num2 == num)
				{
				}
				num = (short)1869807616;
				if (num != 0)
				{
				}
				num = (short)381550593;
				if (num != 0)
				{
				}
				num = (short)1342308352;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardName_A37549.Visible;
			}
			set
			{
				short num = (short)353184075;
				short num2 = num;
				num = (short)1279535435;
				switch (num2 == num)
				{
				}
				num = (short)969146369;
				if (num != 0)
				{
				}
				num = (short)70647808;
				if (num != 0)
				{
				}
				num = (short)6422528;
				short num3 = num;
				this.radInfoOptionExpansionBoardBoardName_A37549.Visible = value;
			}
		}

		// Token: 0x17002A00 RID: 10752
		// (get) Token: 0x060050AF RID: 20655 RVA: 0x00491400 File Offset: 0x0048F600
		// (set) Token: 0x060050B0 RID: 20656 RVA: 0x004914B8 File Offset: 0x0048F6B8
		public bool RadInfoOptionExpansionBoardBoardName_A37549_Editable
		{
			get
			{
				short num = (short)373021253;
				short num2 = num;
				num = (short)762501701;
				switch (num2 == num)
				{
				}
				num = (short)1617100801;
				if (num != 0)
				{
				}
				num = (short)1169948672;
				if (num != 0)
				{
				}
				num = (short)989790208;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardName_A37549.Editable;
			}
			set
			{
				short num = (short)2069664661;
				short num2 = num;
				num = (short)684626837;
				switch (num2 == num)
				{
				}
				num = (short)1952382977;
				if (num != 0)
				{
				}
				num = (short)464912384;
				if (num != 0)
				{
				}
				num = (short)1518665728;
				short num3 = num;
				this.radInfoOptionExpansionBoardBoardName_A37549.Editable = value;
			}
		}

		// Token: 0x17002A01 RID: 10753
		// (get) Token: 0x060050B1 RID: 20657 RVA: 0x0049156C File Offset: 0x0048F76C
		internal string RadInfoOptionExpansionBoardBoardName_A37549_UILabel
		{
			get
			{
				short num = (short)1218863987;
				short num2 = num;
				num = (short)607609715;
				switch (num2 == num)
				{
				}
				num = (short)583204865;
				if (num != 0)
				{
				}
				num = (short)930480128;
				if (num != 0)
				{
				}
				num = (short)1267924992;
				short num3 = num;
				return this.radInfoOptionExpansionBoardBoardName_A37549.UIName;
			}
		}

		// Token: 0x17002A02 RID: 10754
		// (get) Token: 0x060050B2 RID: 20658 RVA: 0x00491624 File Offset: 0x0048F824
		// (set) Token: 0x060050B3 RID: 20659 RVA: 0x004916DC File Offset: 0x0048F8DC
		internal bool RadInfoOptionExpansionBoardBoardName_A37549_HiddenStatic
		{
			get
			{
				short num = (short)216006656;
				short num2 = num;
				num = (short)131985190;
				short num3 = num;
				num = (short)1072492326;
				switch (num3 == num)
				{
				}
				num = (short)1634729985;
				if (num != 0)
				{
				}
				num = (short)1153695744;
				if (num != 0)
				{
				}
				return this.radInfoOptionExpansionBoardBoardName_A37549.HiddenStatic;
			}
			set
			{
				short num = (short)1135214592;
				short num2 = num;
				num = (short)986761991;
				short num3 = num;
				num = (short)2066991879;
				switch (num3 == num)
				{
				}
				num = (short)1905917952;
				if (num != 0)
				{
				}
				num = (short)1355022337;
				if (num != 0)
				{
				}
				this.radInfoOptionExpansionBoardBoardName_A37549.HiddenStatic = value;
			}
		}

		// Token: 0x17002A03 RID: 10755
		// (get) Token: 0x060050B4 RID: 20660 RVA: 0x00491790 File Offset: 0x0048F990
		// (set) Token: 0x060050B5 RID: 20661 RVA: 0x00491848 File Offset: 0x0048FA48
		internal bool RadInfoOptionExpansionBoardBoardName_A37549_HiddenDynamic
		{
			get
			{
				short num = (short)715718656;
				short num2 = num;
				num = (short)306273079;
				short num3 = num;
				num = (short)1433819959;
				switch (num3 == num)
				{
				}
				num = (short)347471872;
				if (num != 0)
				{
				}
				num = (short)1116340225;
				if (num != 0)
				{
				}
				return this.radInfoOptionExpansionBoardBoardName_A37549.HiddenDynamic;
			}
			set
			{
				short num = (short)786300928;
				short num2 = num;
				num = (short)1378271199;
				short num3 = num;
				num = (short)669040607;
				switch (num3 == num)
				{
				}
				num = (short)857079809;
				if (num != 0)
				{
				}
				num = (short)417333248;
				if (num != 0)
				{
				}
				this.radInfoOptionExpansionBoardBoardName_A37549.HiddenDynamic = value;
			}
		}

		// Token: 0x17002A04 RID: 10756
		// (get) Token: 0x060050B6 RID: 20662 RVA: 0x00491900 File Offset: 0x0048FB00
		public bool RadInfoOptionExpansionBoardBoardName_A37549_HasDiffs
		{
			get
			{
				short num = (short)952107008;
				short num2 = num;
				num = (short)1141617531;
				short num3 = num;
				num = (short)381137787;
				switch (num3 == num)
				{
				}
				num = (short)521076737;
				if (num != 0)
				{
				}
				num = (short)225837056;
				if (num != 0)
				{
				}
				return this.radInfoOptionExpansionBoardBoardName_A37549._HasDiffs;
			}
		}

		// Token: 0x060050B7 RID: 20663 RVA: 0x004919B8 File Offset: 0x0048FBB8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_4E;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)601227264;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (base.ParentRecset != null)
					{
						num = (short)19595267;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1418526722;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)891027460;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1379714180;
					short num4 = num;
					num = (short)595248260;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1692205056;
						if (num != 0)
						{
						}
						num = (short)1688862721;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					return result;
				}
				goto IL_4E;
			}
			return result;
			IL_4E:
			result = null;
			num = (short)1164967937;
			if (num != 0)
			{
			}
			num = (short)160759808;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04001B0C RID: 6924
		private global::AcpBusinessLayer.AcpField<string> radInfoOptionExpansionBoardBoardFirmwareVersion_A37048;

		// Token: 0x04001B0D RID: 6925
		private global::AcpBusinessLayer.AcpField<string> radInfoOptionExpansionBoardBoardType_A37049;

		// Token: 0x04001B0E RID: 6926
		private global::AcpBusinessLayer.AcpField<string> radInfoOptionExpansionBoardBoardName_A37549;
	}
}
