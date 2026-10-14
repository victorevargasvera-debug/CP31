using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu
{
	// Token: 0x02000290 RID: 656
	[global::System.Serializable]
	public class IDDisplayTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007325 RID: 29477 RVA: 0x0066493C File Offset: 0x00662B3C
		public IDDisplayTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06007326 RID: 29478 RVA: 0x00664958 File Offset: 0x00662B58
		protected IDDisplayTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			this.a(info, context);
		}

		// Token: 0x06007327 RID: 29479 RVA: 0x00664978 File Offset: 0x00662B78
		public override void Init()
		{
			int a_ = 1;
			short num = (short)800653312;
			short num2 = num;
			num = (short)828824099;
			short num3 = num;
			num = (short)1166400035;
			switch (num3 == num)
			{
			}
			num = (short)1815150593;
			if (num != 0)
			{
			}
			num = (short)1766457344;
			if (num != 0)
			{
			}
			this.prefix_A23035 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_PTT, this, global::AllFeatures.CodeplugGuid.b("鋁뛃ꏅ껇ꏉ듋重量", a_), global::CommonResources.AcgResources.ID_FEATURENAME, 100);
			this.prefix_A23035.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.prefix_A23035.DataTransferOrder = -1;
			this.dispMenuIDDisplayID_A8738 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("证胃ﳅ", a_), new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.UnpackNonListStringStripBlanksAndpackStringtoUpper(), this, global::AllFeatures.CodeplugGuid.b("蛁귃뗅룇蟉꧋ꃍꗏ鯑郓鋕뇗꧙곛닝臟鯡귣ꋥ럧ꯩ퓫\ud9ed쏯쫱", a_), global::CommonResources.AcgResources.ID_DISPLAY);
			this.dispMenuIDDisplayID_A8738.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dispMenuIDDisplayID_A8738.DataTransferOrder = 9;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("证胃資ꏉ뿋뻍볏돑귓賗믙뻛닝藟", a_);
			base.Id = 10022;
			base.UIName = global::CommonResources.AcgResources.ID_IDDISPLAYTABLE;
			base.DataTransferOrder = 1;
			this.b();
		}

		// Token: 0x06007328 RID: 29480 RVA: 0x00664AEC File Offset: 0x00662CEC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)61145090;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.dispMenuIDDisplayID_A8738 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("賄菆", a_), new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.UnpackNonListStringStripBlanksAndpackStringtoUpper(), this, global::AllFeatures.CodeplugGuid.b("臄껆뫈믊背꫎뿐ꛒ鳔鏖鷘닚껜꿞跠苢鳤껦귨듪곬ퟮ웰샲췴", a_), global::CommonResources.AcgResources.ID_DISPLAY);
					this.dispMenuIDDisplayID_A8738.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dispMenuIDDisplayID_A8738.DataTransferOrder = 9;
					num = (short)1180303366;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_EF;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 3:
					this.prefix_A23035 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_PTT, this, global::AllFeatures.CodeplugGuid.b("闄뗆곈귊꓌럎軐鋒", a_), global::CommonResources.AcgResources.ID_FEATURENAME, 100);
					this.prefix_A23035.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.prefix_A23035.DataTransferOrder = -1;
					num = (short)813957121;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1001979911;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄껆뫈믊背꫎뿐ꛒ鳔鏖鷘닚껜꿞跠苢鳤껦귨듪곬ퟮ웰샲췴", a_)))
					{
						num = (short)1641938944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A6;
				case 6:
					goto IL_22F;
				case 7:
					if (producerFields != null)
					{
						num = (short)2020868104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A6;
				case 8:
					num = (short)1752170505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闄뗆곈귊꓌럎軐鋒", a_)))
					{
						num = (short)746061825;
						if (num != 0)
						{
						}
						num = (short)1179844611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EF;
				}
				IL_55:
				num = (short)1410412615;
				short num3 = num;
				num = (short)1960587335;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)676724736;
					if (num != 0)
					{
					}
					if (!global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						goto IL_2A6;
					}
					break;
				}
				num = (short)260767744;
				short num4 = num;
				num = (short)1493958660;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EF:
				num = (short)1013579781;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_22F:
			IL_2A6:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("賄菆迊꓌볎ꇐ뿒듔껖律迚볜뷞跠蛢", a_);
			base.Id = 10022;
			base.UIName = global::CommonResources.AcgResources.ID_IDDISPLAYTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007329 RID: 29481 RVA: 0x00664DD0 File Offset: 0x00662FD0
		public override void PopulateReferences()
		{
			short num = (short)1506082816;
			short num2 = num;
			num = (short)1561082455;
			short num3 = num;
			num = (short)298007127;
			switch (num3 == num)
			{
			}
			num = (short)2044788736;
			if (num != 0)
			{
			}
			num = (short)1677000705;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600732A RID: 29482 RVA: 0x00664E78 File Offset: 0x00663078
		public override void DropReferences()
		{
			short num = (short)1038286848;
			short num2 = num;
			num = (short)837025793;
			if (num != 0)
			{
			}
			num = (short)399824623;
			short num3 = num;
			num = (short)629921519;
			switch (num3 == num)
			{
			}
			num = (short)754057216;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600732B RID: 29483 RVA: 0x00664F24 File Offset: 0x00663124
		public override void SetConstraints()
		{
			short num = (short)1924595712;
			short num2 = num;
			num = (short)442761217;
			if (num != 0)
			{
			}
			num = (short)1632168987;
			short num3 = num;
			num = (short)1159654427;
			switch (num3 == num)
			{
			}
			num = (short)1836646400;
			if (num != 0)
			{
			}
			this.prefix_A23035.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.dispMenuIDDisplayID_A8738.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.ConIdDispIsEnabled);
			this.dispMenuIDDisplayID_A8738.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.ConPrefixIDTxtLengthValid);
		}

		// Token: 0x0600732C RID: 29484 RVA: 0x00665014 File Offset: 0x00663214
		public override void SetupDependencies()
		{
			short num = (short)2133262336;
			short num2 = num;
			num = (short)1033221694;
			short num3 = num;
			num = (short)1858319934;
			switch (num3 == num)
			{
			}
			num = (short)1951924225;
			if (num != 0)
			{
			}
			num = (short)1833172992;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu displayAndMenu = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu;
			displayAndMenu.IDDisplay.DispMenuIDDisplayPTTIDDisplay_A8221.AddDependentObject(this.dispMenuIDDisplayID_A8738);
			displayAndMenu.IDDisplay.PrefixIDTextSize_A22465.AddDependentObject(this.dispMenuIDDisplayID_A8738);
		}

		// Token: 0x17003B74 RID: 15220
		// (get) Token: 0x0600732D RID: 29485 RVA: 0x00665100 File Offset: 0x00663300
		public bool HasDiffs
		{
			get
			{
				short num = (short)1044840448;
				short num2 = num;
				num = (short)698241506;
				short num3 = num;
				num = (short)563696098;
				switch (num3 == num)
				{
				}
				num = (short)1455095809;
				if (num != 0)
				{
				}
				num = (short)995819520;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003B75 RID: 15221
		// (get) Token: 0x0600732E RID: 29486 RVA: 0x006651B0 File Offset: 0x006633B0
		// (set) Token: 0x0600732F RID: 29487 RVA: 0x00665268 File Offset: 0x00663468
		public string Prefix_A23035Value
		{
			get
			{
				short num = (short)1978400768;
				short num2 = num;
				num = (short)718985542;
				short num3 = num;
				num = (short)1981077830;
				switch (num3 == num)
				{
				}
				num = (short)1730019329;
				if (num != 0)
				{
				}
				num = (short)1780809728;
				if (num != 0)
				{
				}
				return this.prefix_A23035.Value;
			}
			set
			{
				short num = (short)301301677;
				short num2 = num;
				num = (short)1334017965;
				switch (num2 == num)
				{
				}
				num = (short)2089877504;
				if (num != 0)
				{
				}
				num = (short)1810235392;
				short num3 = num;
				num = (short)2002386945;
				if (num != 0)
				{
				}
				this.prefix_A23035.Value = value;
			}
		}

		// Token: 0x17003B76 RID: 15222
		// (get) Token: 0x06007330 RID: 29488 RVA: 0x00665320 File Offset: 0x00663520
		public global::AcpBusinessLayer.AcpField<string> Prefix_A23035
		{
			get
			{
				short num = (short)823909504;
				short num2 = num;
				num = (short)1072684160;
				switch (num2 == num)
				{
				}
				num = (short)889257985;
				if (num != 0)
				{
				}
				num = (short)274399232;
				short num3 = num;
				num = (short)2049114112;
				if (num != 0)
				{
				}
				return this.prefix_A23035;
			}
		}

		// Token: 0x17003B77 RID: 15223
		// (get) Token: 0x06007331 RID: 29489 RVA: 0x006653CC File Offset: 0x006635CC
		// (set) Token: 0x06007332 RID: 29490 RVA: 0x00665484 File Offset: 0x00663684
		public string Prefix_A23035_UIValue
		{
			get
			{
				short num = (short)1139236615;
				short num2 = num;
				num = (short)737435399;
				switch (num2 == num)
				{
				}
				num = (short)443809793;
				if (num != 0)
				{
				}
				num = (short)505872384;
				short num3 = num;
				num = (short)543358976;
				if (num != 0)
				{
				}
				return this.prefix_A23035.Value;
			}
			set
			{
				short num = (short)1431097188;
				short num2 = num;
				num = (short)1863700324;
				switch (num2 == num)
				{
				}
				num = (short)747700224;
				if (num != 0)
				{
				}
				num = (short)200540160;
				short num3 = num;
				num = (short)1545732097;
				if (num != 0)
				{
				}
				this.prefix_A23035.Value = value;
			}
		}

		// Token: 0x17003B78 RID: 15224
		// (get) Token: 0x06007333 RID: 29491 RVA: 0x0066553C File Offset: 0x0066373C
		// (set) Token: 0x06007334 RID: 29492 RVA: 0x006655F0 File Offset: 0x006637F0
		public bool Prefix_A23035_Applicable
		{
			get
			{
				short num = (short)792803850;
				short num2 = num;
				num = (short)77281802;
				switch (num2 == num)
				{
				}
				num = (short)2074148864;
				if (num != 0)
				{
				}
				num = (short)891617280;
				short num3 = num;
				num = (short)268566529;
				if (num != 0)
				{
				}
				return this.prefix_A23035.Applicable;
			}
			set
			{
				short num = (short)1410177566;
				short num2 = num;
				num = (short)975804958;
				switch (num2 == num)
				{
				}
				num = (short)1947926529;
				if (num != 0)
				{
				}
				num = (short)1758396416;
				short num3 = num;
				num = (short)2067464192;
				if (num != 0)
				{
				}
				this.prefix_A23035.Applicable = value;
			}
		}

		// Token: 0x17003B79 RID: 15225
		// (get) Token: 0x06007335 RID: 29493 RVA: 0x006656AC File Offset: 0x006638AC
		// (set) Token: 0x06007336 RID: 29494 RVA: 0x00665764 File Offset: 0x00663964
		public bool Prefix_A23035_Valid
		{
			get
			{
				short num = (short)96337921;
				if (num != 0)
				{
				}
				num = (short)198821890;
				short num2 = num;
				num = (short)13289474;
				switch (num2 == num)
				{
				}
				num = (short)764215296;
				short num3 = num;
				num = (short)970915840;
				if (num != 0)
				{
				}
				return this.prefix_A23035.Valid;
			}
			set
			{
				short num = (short)1485268432;
				short num2 = num;
				num = (short)102393296;
				switch (num2 == num)
				{
				}
				num = (short)1446248449;
				if (num != 0)
				{
				}
				num = (short)37814272;
				short num3 = num;
				num = (short)119603200;
				if (num != 0)
				{
				}
				this.prefix_A23035.Valid = value;
			}
		}

		// Token: 0x17003B7A RID: 15226
		// (get) Token: 0x06007337 RID: 29495 RVA: 0x0066581C File Offset: 0x00663A1C
		// (set) Token: 0x06007338 RID: 29496 RVA: 0x006658D0 File Offset: 0x00663AD0
		public bool Prefix_A23035_Visible
		{
			get
			{
				short num = (short)1689637668;
				short num2 = num;
				num = (short)463852324;
				switch (num2 == num)
				{
				}
				num = (short)1602355201;
				if (num != 0)
				{
				}
				num = (short)88539136;
				short num3 = num;
				num = (short)813236224;
				if (num != 0)
				{
				}
				return this.prefix_A23035.Visible;
			}
			set
			{
				short num = (short)1399579459;
				short num2 = num;
				num = (short)645260099;
				switch (num2 == num)
				{
				}
				num = (short)122224641;
				if (num != 0)
				{
				}
				num = (short)72679424;
				short num3 = num;
				num = (short)1839988736;
				if (num != 0)
				{
				}
				this.prefix_A23035.Visible = value;
			}
		}

		// Token: 0x17003B7B RID: 15227
		// (get) Token: 0x06007339 RID: 29497 RVA: 0x00665984 File Offset: 0x00663B84
		// (set) Token: 0x0600733A RID: 29498 RVA: 0x00665A38 File Offset: 0x00663C38
		public bool Prefix_A23035_Editable
		{
			get
			{
				short num = (short)915815165;
				short num2 = num;
				num = (short)1062484733;
				switch (num2 == num)
				{
				}
				num = (short)1110507520;
				if (num != 0)
				{
				}
				num = (short)1186922496;
				short num3 = num;
				num = (short)1682309121;
				if (num != 0)
				{
				}
				return this.prefix_A23035.Editable;
			}
			set
			{
				short num = (short)219253751;
				short num2 = num;
				num = (short)57248759;
				switch (num2 == num)
				{
				}
				num = (short)1212874753;
				if (num != 0)
				{
				}
				num = (short)458489856;
				short num3 = num;
				num = (short)1573322752;
				if (num != 0)
				{
				}
				this.prefix_A23035.Editable = value;
			}
		}

		// Token: 0x17003B7C RID: 15228
		// (get) Token: 0x0600733B RID: 29499 RVA: 0x00665AEC File Offset: 0x00663CEC
		internal string Prefix_A23035_UILabel
		{
			get
			{
				short num = (short)1809711105;
				if (num != 0)
				{
				}
				num = (short)1096712129;
				short num2 = num;
				num = (short)637501377;
				switch (num2 == num)
				{
				}
				num = (short)1661796352;
				short num3 = num;
				num = (short)705560576;
				if (num != 0)
				{
				}
				return this.prefix_A23035.UIName;
			}
		}

		// Token: 0x17003B7D RID: 15229
		// (get) Token: 0x0600733C RID: 29500 RVA: 0x00665BA0 File Offset: 0x00663DA0
		// (set) Token: 0x0600733D RID: 29501 RVA: 0x00665C54 File Offset: 0x00663E54
		internal bool Prefix_A23035_HiddenStatic
		{
			get
			{
				short num = (short)1403568405;
				short num2 = num;
				num = (short)1892991253;
				switch (num2 == num)
				{
				}
				num = (short)863764480;
				if (num != 0)
				{
				}
				num = (short)1220280320;
				short num3 = num;
				num = (short)900661249;
				if (num != 0)
				{
				}
				return this.prefix_A23035.HiddenStatic;
			}
			set
			{
				short num = (short)1344953712;
				short num2 = num;
				num = (short)1381064048;
				switch (num2 == num)
				{
				}
				num = (short)863109121;
				if (num != 0)
				{
				}
				num = (short)1383202816;
				short num3 = num;
				num = (short)457441280;
				if (num != 0)
				{
				}
				this.prefix_A23035.HiddenStatic = value;
			}
		}

		// Token: 0x17003B7E RID: 15230
		// (get) Token: 0x0600733E RID: 29502 RVA: 0x00665D08 File Offset: 0x00663F08
		// (set) Token: 0x0600733F RID: 29503 RVA: 0x00665DBC File Offset: 0x00663FBC
		internal bool Prefix_A23035_HiddenDynamic
		{
			get
			{
				short num = (short)1655104516;
				short num2 = num;
				num = (short)1938940932;
				switch (num2 == num)
				{
				}
				num = (short)984875008;
				if (num != 0)
				{
				}
				num = (short)1361379328;
				short num3 = num;
				num = (short)1277689857;
				if (num != 0)
				{
				}
				return this.prefix_A23035.HiddenDynamic;
			}
			set
			{
				short num = (short)1870669711;
				short num2 = num;
				num = (short)1417422735;
				switch (num2 == num)
				{
				}
				num = (short)79626241;
				if (num != 0)
				{
				}
				num = (short)1363738624;
				short num3 = num;
				num = (short)453640192;
				if (num != 0)
				{
				}
				this.prefix_A23035.HiddenDynamic = value;
			}
		}

		// Token: 0x17003B7F RID: 15231
		// (get) Token: 0x06007340 RID: 29504 RVA: 0x00665E74 File Offset: 0x00664074
		public bool Prefix_A23035_HasDiffs
		{
			get
			{
				short num = (short)1110629418;
				short num2 = num;
				num = (short)1416944682;
				switch (num2 == num)
				{
				}
				num = (short)50724865;
				if (num != 0)
				{
				}
				num = (short)1765867520;
				short num3 = num;
				num = (short)676462592;
				if (num != 0)
				{
				}
				return this.prefix_A23035._HasDiffs;
			}
		}

		// Token: 0x17003B80 RID: 15232
		// (get) Token: 0x06007341 RID: 29505 RVA: 0x00665F2C File Offset: 0x0066412C
		// (set) Token: 0x06007342 RID: 29506 RVA: 0x00665FE0 File Offset: 0x006641E0
		public string DispMenuIDDisplayID_A8738Value
		{
			get
			{
				short num = (short)350353564;
				short num2 = num;
				num = (short)206370972;
				switch (num2 == num)
				{
				}
				num = (short)227082240;
				if (num != 0)
				{
				}
				num = (short)1513947136;
				short num3 = num;
				num = (short)922943489;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayID_A8738.Value;
			}
			set
			{
				short num = (short)22784301;
				short num2 = num;
				num = (short)385460525;
				switch (num2 == num)
				{
				}
				num = (short)1847787520;
				if (num != 0)
				{
				}
				num = (short)941424640;
				short num3 = num;
				num = (short)88604673;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayID_A8738.Value = value;
			}
		}

		// Token: 0x17003B81 RID: 15233
		// (get) Token: 0x06007343 RID: 29507 RVA: 0x0066609C File Offset: 0x0066429C
		public global::AcpBusinessLayer.AcpFieldX<string, string> DispMenuIDDisplayID_A8738
		{
			get
			{
				short num = (short)742260737;
				if (num != 0)
				{
				}
				num = (short)1653771049;
				short num2 = num;
				num = (short)1563921193;
				switch (num2 == num)
				{
				}
				num = (short)967376896;
				short num3 = num;
				num = (short)602669056;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayID_A8738;
			}
		}

		// Token: 0x17003B82 RID: 15234
		// (get) Token: 0x06007344 RID: 29508 RVA: 0x0066614C File Offset: 0x0066434C
		// (set) Token: 0x06007345 RID: 29509 RVA: 0x00666200 File Offset: 0x00664400
		public string DispMenuIDDisplayID_A8738_UIValue
		{
			get
			{
				short num = (short)2131656517;
				short num2 = num;
				num = (short)2039054149;
				switch (num2 == num)
				{
				}
				num = (short)326696960;
				if (num != 0)
				{
				}
				num = (short)1849622528;
				short num3 = num;
				num = (short)1444085761;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayID_A8738.UIValue;
			}
			set
			{
				short num = (short)746129456;
				short num2 = num;
				num = (short)1626277936;
				switch (num2 == num)
				{
				}
				num = (short)1322188800;
				if (num != 0)
				{
				}
				num = (short)893386752;
				short num3 = num;
				num = (short)2120810497;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayID_A8738.UIValue = value;
			}
		}

		// Token: 0x17003B83 RID: 15235
		// (get) Token: 0x06007346 RID: 29510 RVA: 0x006662B4 File Offset: 0x006644B4
		// (set) Token: 0x06007347 RID: 29511 RVA: 0x00666368 File Offset: 0x00664568
		public bool DispMenuIDDisplayID_A8738_Applicable
		{
			get
			{
				short num = (short)1323417765;
				short num2 = num;
				num = (short)1764016293;
				switch (num2 == num)
				{
				}
				num = (short)1570635777;
				if (num != 0)
				{
				}
				num = (short)1544683520;
				short num3 = num;
				num = (short)1463877632;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayID_A8738.Applicable;
			}
			set
			{
				short num = (short)728126389;
				short num2 = num;
				num = (short)33838005;
				switch (num2 == num)
				{
				}
				num = (short)538509313;
				if (num != 0)
				{
				}
				num = (short)1859452928;
				short num3 = num;
				num = (short)917504;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayID_A8738.Applicable = value;
			}
		}

		// Token: 0x17003B84 RID: 15236
		// (get) Token: 0x06007348 RID: 29512 RVA: 0x0066641C File Offset: 0x0066461C
		// (set) Token: 0x06007349 RID: 29513 RVA: 0x006664D0 File Offset: 0x006646D0
		public bool DispMenuIDDisplayID_A8738_Valid
		{
			get
			{
				short num = (short)289939377;
				short num2 = num;
				num = (short)1951801265;
				switch (num2 == num)
				{
				}
				num = (short)1152909313;
				if (num != 0)
				{
				}
				num = (short)839450624;
				short num3 = num;
				num = (short)1281753088;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayID_A8738.Valid;
			}
			set
			{
				short num = (short)122541950;
				short num2 = num;
				num = (short)474929022;
				switch (num2 == num)
				{
				}
				num = (short)824180737;
				if (num != 0)
				{
				}
				num = (short)1609957376;
				short num3 = num;
				num = (short)854130688;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayID_A8738.Valid = value;
			}
		}

		// Token: 0x17003B85 RID: 15237
		// (get) Token: 0x0600734A RID: 29514 RVA: 0x00666584 File Offset: 0x00664784
		// (set) Token: 0x0600734B RID: 29515 RVA: 0x0066663C File Offset: 0x0066483C
		public bool DispMenuIDDisplayID_A8738_Visible
		{
			get
			{
				short num = (short)1960567248;
				short num2 = num;
				num = (short)199680464;
				switch (num2 == num)
				{
				}
				num = (short)1676804097;
				if (num != 0)
				{
				}
				num = (short)681377792;
				short num3 = num;
				num = (short)1623719936;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayID_A8738.Visible;
			}
			set
			{
				short num = (short)1252951605;
				short num2 = num;
				num = (short)448366133;
				switch (num2 == num)
				{
				}
				num = (short)236519424;
				if (num != 0)
				{
				}
				num = (short)2029125632;
				short num3 = num;
				num = (short)172883969;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayID_A8738.Visible = value;
			}
		}

		// Token: 0x17003B86 RID: 15238
		// (get) Token: 0x0600734C RID: 29516 RVA: 0x006666F0 File Offset: 0x006648F0
		// (set) Token: 0x0600734D RID: 29517 RVA: 0x006667A8 File Offset: 0x006649A8
		public bool DispMenuIDDisplayID_A8738_Editable
		{
			get
			{
				short num = (short)590650401;
				short num2 = num;
				num = (short)1653972001;
				switch (num2 == num)
				{
				}
				num = (short)1842806784;
				if (num != 0)
				{
				}
				num = (short)639959040;
				short num3 = num;
				num = (short)419495937;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayID_A8738.Editable;
			}
			set
			{
				short num = (short)198309510;
				short num2 = num;
				num = (short)177010310;
				switch (num2 == num)
				{
				}
				num = (short)965804032;
				if (num != 0)
				{
				}
				num = (short)1224278016;
				short num3 = num;
				num = (short)188088321;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayID_A8738.Editable = value;
			}
		}

		// Token: 0x17003B87 RID: 15239
		// (get) Token: 0x0600734E RID: 29518 RVA: 0x0066685C File Offset: 0x00664A5C
		internal string DispMenuIDDisplayID_A8738_UILabel
		{
			get
			{
				short num = (short)2046662806;
				short num2 = num;
				num = (short)555718806;
				switch (num2 == num)
				{
				}
				num = (short)757202944;
				if (num != 0)
				{
				}
				num = (short)1862205440;
				short num3 = num;
				num = (short)1516175361;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayID_A8738.UIName;
			}
		}

		// Token: 0x17003B88 RID: 15240
		// (get) Token: 0x0600734F RID: 29519 RVA: 0x00666910 File Offset: 0x00664B10
		// (set) Token: 0x06007350 RID: 29520 RVA: 0x006669C4 File Offset: 0x00664BC4
		internal bool DispMenuIDDisplayID_A8738_HiddenStatic
		{
			get
			{
				short num = (short)1629626191;
				short num2 = num;
				num = (short)1852841807;
				switch (num2 == num)
				{
				}
				num = (short)589365249;
				if (num != 0)
				{
				}
				num = (short)1115226112;
				short num3 = num;
				num = (short)1490092032;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayID_A8738.HiddenStatic;
			}
			set
			{
				short num = (short)1827482376;
				short num2 = num;
				num = (short)601107208;
				switch (num2 == num)
				{
				}
				num = (short)381943809;
				if (num != 0)
				{
				}
				num = (short)1691353088;
				short num3 = num;
				num = (short)1634926592;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayID_A8738.HiddenStatic = value;
			}
		}

		// Token: 0x17003B89 RID: 15241
		// (get) Token: 0x06007351 RID: 29521 RVA: 0x00666A78 File Offset: 0x00664C78
		// (set) Token: 0x06007352 RID: 29522 RVA: 0x00666B30 File Offset: 0x00664D30
		internal bool DispMenuIDDisplayID_A8738_HiddenDynamic
		{
			get
			{
				short num = (short)1668153345;
				if (num != 0)
				{
				}
				num = (short)2029258366;
				short num2 = num;
				num = (short)2011760254;
				switch (num2 == num)
				{
				}
				num = (short)1779171328;
				short num3 = num;
				num = (short)1807810560;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayID_A8738.HiddenDynamic;
			}
			set
			{
				short num = (short)1150123772;
				short num2 = num;
				num = (short)5734140;
				switch (num2 == num)
				{
				}
				num = (short)1173946369;
				if (num != 0)
				{
				}
				num = (short)1571225600;
				short num3 = num;
				num = (short)863633408;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayID_A8738.HiddenDynamic = value;
			}
		}

		// Token: 0x17003B8A RID: 15242
		// (get) Token: 0x06007353 RID: 29523 RVA: 0x00666BE4 File Offset: 0x00664DE4
		public bool DispMenuIDDisplayID_A8738_HasDiffs
		{
			get
			{
				short num = (short)2002169787;
				short num2 = num;
				num = (short)1248767931;
				switch (num2 == num)
				{
				}
				num = (short)645988353;
				if (num != 0)
				{
				}
				num = (short)160628736;
				short num3 = num;
				num = (short)1963655168;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayID_A8738._HasDiffs;
			}
		}

		// Token: 0x06007354 RID: 29524 RVA: 0x00666C98 File Offset: 0x00664E98
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)761135107;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_140;
					case 1:
						if (base.ParentRecset != null)
						{
							num2 = (short)1094778884;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_140;
					case 2:
						goto IL_FC;
					case 3:
					{
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)319564468;
						short num3 = num2;
						num2 = (short)436546228;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1332477952;
							if (num2 != 0)
							{
							}
							num2 = (short)271908866;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 4:
						num2 = (short)67108864;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				IL_24:
				num2 = (short)1496711168;
				short num4 = num2;
				result = null;
				num2 = (short)1003683841;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_FC:
			IL_140:
			num2 = (short)307757057;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x06007355 RID: 29525 RVA: 0x00666E10 File Offset: 0x00665010
		private void a(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			short num = (short)183763584;
			short num2 = num;
			num = (short)723255936;
			switch (num2 == num)
			{
			}
			num = (short)1947336704;
			short num3 = num;
			num = (short)341508097;
			if (num != 0)
			{
			}
			num = (short)2095906816;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06007356 RID: 29526 RVA: 0x00666EC0 File Offset: 0x006650C0
		private void b()
		{
			short num = (short)229094712;
			short num2 = num;
			num = (short)547075384;
			switch (num2 == num)
			{
			}
			num = (short)1510211584;
			short num3 = num;
			num = (short)959905793;
			if (num != 0)
			{
			}
			num = (short)1214709760;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06007357 RID: 29527 RVA: 0x00666F70 File Offset: 0x00665170
		private void a()
		{
			short num = (short)1082026688;
			short num2 = num;
			num = (short)2140302016;
			switch (num2 == num)
			{
			}
			num = (short)469893120;
			short num3 = num;
			num = (short)619642881;
			if (num != 0)
			{
			}
			num = (short)355467264;
			if (num != 0)
			{
			}
			this.dispMenuIDDisplayID_A8738.Value = this.dispMenuIDDisplayID_A8738.Value.TrimEnd(global::System.Array.Empty<char>());
			this.dispMenuIDDisplayID_A8738.DefaultValue = this.dispMenuIDDisplayID_A8738.DefaultValue.TrimEnd(global::System.Array.Empty<char>());
		}

		// Token: 0x04002D06 RID: 11526
		private global::AcpBusinessLayer.AcpField<string> prefix_A23035;

		// Token: 0x04002D07 RID: 11527
		private global::AcpBusinessLayer.AcpFieldX<string, string> dispMenuIDDisplayID_A8738;
	}
}
