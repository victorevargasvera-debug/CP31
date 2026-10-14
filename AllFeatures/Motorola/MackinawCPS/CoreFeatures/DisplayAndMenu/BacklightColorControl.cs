using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu
{
	// Token: 0x02000271 RID: 625
	[global::System.Serializable]
	public class BacklightColorControl : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600700D RID: 28685 RVA: 0x0063BC5C File Offset: 0x00639E5C
		public BacklightColorControl(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600700E RID: 28686 RVA: 0x0063BC9C File Offset: 0x00639E9C
		protected BacklightColorControl(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600700F RID: 28687 RVA: 0x0063BCB4 File Offset: 0x00639EB4
		public override void Init()
		{
			int a_ = 5;
			short num = (short)830247231;
			short num2 = num;
			num = (short)116232511;
			switch (num2 == num)
			{
			}
			num = (short)1470562304;
			short num3 = num;
			num = (short)1609564161;
			if (num != 0)
			{
			}
			num = (short)535035904;
			if (num != 0)
			{
			}
			this.radProfBacklightColorControlDefaultBacklightColor_A7811 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("铅꧇껉鳋볍뿏듑雓럕믗뇙냛럝蟟諡郣ꗥ蟧蛩菫鳭돯鷱髳苵諷闹郻뫽旿搁攃猅搇縉下漍猏礑砓缕缗爙栛崝伟両䬣吥眧欩ᬫᘭį̱", a_), global::CommonResources.AcgResources.ID_DEFAULTBACKLIGHTCOLOR, null, null, false, false);
			this.radProfBacklightColorControlDefaultBacklightColor_A7811.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radProfBacklightColorControlDefaultBacklightColor_A7811.DataTransferOrder = 46;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓅꧇꧉Ɤꋍ맏뗑볓ꋕ駙돛닝迟郡쓣ꗥ蟧蓩飫鳭鿯黱", a_);
			base.Id = 10215;
			base.UIName = global::CommonResources.AcgResources.ID_BACKLIGHTCOLORCONTROL;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06007010 RID: 28688 RVA: 0x0063BDD4 File Offset: 0x00639FD4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			for (;;)
			{
				IL_09:
				short num = (short)977797125;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (producerFields != null)
						{
							num = (short)1271988230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DF;
					case 1:
						goto IL_15C;
					case 2:
						this.radProfBacklightColorControlDefaultBacklightColor_A7811 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ韆믈꓊ꯌ跎냐냒뻔믖냘볚뗜ꯞꋠ賢觤裦鯨꣪苬臮藰臲髴鯶뷸黺鯼黾琀漂焄䔆栈栊昌挎砐琒純挖娘琚焜瀞匠簢搤ဦᄨᨪᰬ", a_), global::CommonResources.AcgResources.ID_DEFAULTBACKLIGHTCOLOR, null, null, false, false);
						this.radProfBacklightColorControlDefaultBacklightColor_A7811.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
						this.radProfBacklightColorControlDefaultBacklightColor_A7811.DataTransferOrder = 46;
						num = (short)744685569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)579855040;
						short num3 = num;
						num = (short)1352000192;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
						{
							num = (short)243007488;
							if (num != 0)
							{
							}
							num = (short)684261377;
							if (num != 0)
							{
							}
							num = (short)1513947136;
							short num4 = num;
							num = (short)1962999808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 4:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ韆믈꓊ꯌ跎냐냒뻔믖냘볚뗜ꯞꋠ賢觤裦鯨꣪苬臮藰臲髴鯶뷸黺鯼黾琀漂焄䔆栈栊昌挎砐琒純挖娘琚焜瀞匠簢搤ဦᄨᨪᰬ", a_)))
						{
							num = (short)724172802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DF;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_49;
						}
						continue;
					case 6:
						num = (short)1105199108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_49:
					if (!global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						goto IL_1DF;
					}
					num = (short)554303491;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_15C:
			IL_1DF:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菀ꋂꛄ곆ꗈꋊ꫌꟎ꗐ雔룖뗘듚꿜￞ꋠ賢诤鏦鯨蓪臬", a_);
			base.Id = 10215;
			base.UIName = global::CommonResources.AcgResources.ID_BACKLIGHTCOLORCONTROL;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06007011 RID: 28689 RVA: 0x0063BFF4 File Offset: 0x0063A1F4
		public override void PopulateReferences()
		{
			short num = (short)2000520089;
			short num2 = num;
			num = (short)1187218329;
			switch (num2 == num)
			{
			}
			num = (short)1433600000;
			short num3 = num;
			num = (short)124125185;
			if (num != 0)
			{
			}
			num = (short)414449664;
			if (num != 0)
			{
			}
			this.radProfBacklightColorControlDefaultBacklightColor_A7811.SetRecset(this.a(2010)[0][10215].EmbeddedRecset);
		}

		// Token: 0x06007012 RID: 28690 RVA: 0x0063C0C8 File Offset: 0x0063A2C8
		public override void DropReferences()
		{
			short num = (short)2043099217;
			short num2 = num;
			num = (short)195901521;
			switch (num2 == num)
			{
			}
			num = (short)741146624;
			short num3 = num;
			num = (short)1894187008;
			if (num != 0)
			{
			}
			num = (short)67567617;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007013 RID: 28691 RVA: 0x0063C174 File Offset: 0x0063A374
		public override void SetConstraints()
		{
			short num = (short)1280483320;
			short num2 = num;
			num = (short)340762616;
			switch (num2 == num)
			{
			}
			num = (short)987693056;
			short num3 = num;
			num = (short)1277558785;
			if (num != 0)
			{
			}
			num = (short)467795968;
			if (num != 0)
			{
			}
			this.radProfBacklightColorControlDefaultBacklightColor_A7811.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.ConCheckDefaultColorisValidity);
		}

		// Token: 0x06007014 RID: 28692 RVA: 0x0063C238 File Offset: 0x0063A438
		public override void SetupDependencies()
		{
			short num = (short)1334152704;
			short num2 = num;
			num = (short)1812762112;
			switch (num2 == num)
			{
			}
			num = (short)1656094720;
			short num3 = num;
			num = (short)1357643776;
			if (num != 0)
			{
			}
			num = (short)1097334785;
			if (num != 0)
			{
			}
		}

		// Token: 0x170039EA RID: 14826
		// (get) Token: 0x06007015 RID: 28693 RVA: 0x0063C2E4 File Offset: 0x0063A4E4
		public global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInner BacklightColorsInnerSectionForRadProfBacklightColorControlDefaultBacklightColor_A7811
		{
			get
			{
				short num = (short)186817809;
				short num2 = num;
				num = (short)1379769617;
				switch (num2 == num)
				{
				}
				num = (short)1454047232;
				short num3 = num;
				num = (short)324009985;
				if (num != 0)
				{
				}
				num = (short)571015168;
				if (num != 0)
				{
				}
				return this.radProfBacklightColorControlDefaultBacklightColor_A7811.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInner;
			}
		}

		// Token: 0x170039EB RID: 14827
		// (get) Token: 0x06007016 RID: 28694 RVA: 0x0063C39C File Offset: 0x0063A59C
		public bool HasDiffs
		{
			get
			{
				short num = (short)345100157;
				short num2 = num;
				num = (short)1246351229;
				switch (num2 == num)
				{
				}
				num = (short)1915944960;
				short num3 = num;
				num = (short)858980352;
				if (num != 0)
				{
				}
				num = (short)80347137;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170039EC RID: 14828
		// (get) Token: 0x06007017 RID: 28695 RVA: 0x0063C450 File Offset: 0x0063A650
		// (set) Token: 0x06007018 RID: 28696 RVA: 0x0063C504 File Offset: 0x0063A704
		public int RadProfBacklightColorControlDefaultBacklightColor_A7811Value
		{
			get
			{
				short num = (short)598350676;
				short num2 = num;
				num = (short)1265572692;
				switch (num2 == num)
				{
				}
				num = (short)1311113216;
				short num3 = num;
				num = (short)186580993;
				if (num != 0)
				{
				}
				num = (short)867827712;
				if (num != 0)
				{
				}
				return this.radProfBacklightColorControlDefaultBacklightColor_A7811.Value;
			}
			set
			{
				short num = (short)1362167744;
				short num2 = num;
				num = (short)1960576960;
				switch (num2 == num)
				{
				}
				num = (short)1897332736;
				short num3 = num;
				num = (short)1515913217;
				if (num != 0)
				{
				}
				num = (short)951582720;
				if (num != 0)
				{
				}
				this.radProfBacklightColorControlDefaultBacklightColor_A7811.Value = value;
			}
		}

		// Token: 0x170039ED RID: 14829
		// (get) Token: 0x06007019 RID: 28697 RVA: 0x0063C5BC File Offset: 0x0063A7BC
		// (set) Token: 0x0600701A RID: 28698 RVA: 0x0063C674 File Offset: 0x0063A874
		public string RadProfBacklightColorControlDefaultBacklightColor_A7811_UIValue
		{
			get
			{
				short num = (short)157098707;
				short num2 = num;
				num = (short)1519723219;
				switch (num2 == num)
				{
				}
				num = (short)340000768;
				short num3 = num;
				num = (short)2049835008;
				if (num != 0)
				{
				}
				num = (short)103088129;
				if (num != 0)
				{
				}
				return this.radProfBacklightColorControlDefaultBacklightColor_A7811.UIValue;
			}
			set
			{
				short num = (short)881234048;
				short num2 = num;
				num = (short)511086720;
				switch (num2 == num)
				{
				}
				num = (short)89391104;
				short num3 = num;
				num = (short)13828097;
				if (num != 0)
				{
				}
				num = (short)1141243904;
				if (num != 0)
				{
				}
				this.radProfBacklightColorControlDefaultBacklightColor_A7811.UIValue = value;
			}
		}

		// Token: 0x170039EE RID: 14830
		// (get) Token: 0x0600701B RID: 28699 RVA: 0x0063C728 File Offset: 0x0063A928
		public global::AcpBusinessLayer.AcpRecRefField RadProfBacklightColorControlDefaultBacklightColor_A7811
		{
			get
			{
				short num = (short)354222615;
				short num2 = num;
				num = (short)745341463;
				switch (num2 == num)
				{
				}
				num = (short)374341632;
				short num3 = num;
				num = (short)394854401;
				if (num != 0)
				{
				}
				num = (short)6225920;
				if (num != 0)
				{
				}
				return this.radProfBacklightColorControlDefaultBacklightColor_A7811;
			}
		}

		// Token: 0x170039EF RID: 14831
		// (get) Token: 0x0600701C RID: 28700 RVA: 0x0063C7D4 File Offset: 0x0063A9D4
		// (set) Token: 0x0600701D RID: 28701 RVA: 0x0063C888 File Offset: 0x0063AA88
		public bool RadProfBacklightColorControlDefaultBacklightColor_A7811_Applicable
		{
			get
			{
				short num = (short)1205933249;
				short num2 = num;
				num = (short)1608455361;
				switch (num2 == num)
				{
				}
				num = (short)1128726528;
				short num3 = num;
				num = (short)1133051905;
				if (num != 0)
				{
				}
				num = (short)823132160;
				if (num != 0)
				{
				}
				return this.radProfBacklightColorControlDefaultBacklightColor_A7811.Applicable;
			}
			set
			{
				short num = (short)1098938321;
				short num2 = num;
				num = (short)468088785;
				switch (num2 == num)
				{
				}
				num = (short)238223360;
				short num3 = num;
				num = (short)390332417;
				if (num != 0)
				{
				}
				num = (short)1881538560;
				if (num != 0)
				{
				}
				this.radProfBacklightColorControlDefaultBacklightColor_A7811.Applicable = value;
			}
		}

		// Token: 0x170039F0 RID: 14832
		// (get) Token: 0x0600701E RID: 28702 RVA: 0x0063C940 File Offset: 0x0063AB40
		// (set) Token: 0x0600701F RID: 28703 RVA: 0x0063C9F4 File Offset: 0x0063ABF4
		public bool RadProfBacklightColorControlDefaultBacklightColor_A7811_Valid
		{
			get
			{
				short num = (short)1049127554;
				short num2 = num;
				num = (short)621767298;
				switch (num2 == num)
				{
				}
				num = (short)1401225216;
				short num3 = num;
				num = (short)1007222785;
				if (num != 0)
				{
				}
				num = (short)1089273856;
				if (num != 0)
				{
				}
				return this.radProfBacklightColorControlDefaultBacklightColor_A7811.Valid;
			}
			set
			{
				short num = (short)2029167384;
				short num2 = num;
				num = (short)1056613144;
				switch (num2 == num)
				{
				}
				num = (short)2078408704;
				short num3 = num;
				num = (short)662831105;
				if (num != 0)
				{
				}
				num = (short)385548288;
				if (num != 0)
				{
				}
				this.radProfBacklightColorControlDefaultBacklightColor_A7811.Valid = value;
			}
		}

		// Token: 0x170039F1 RID: 14833
		// (get) Token: 0x06007020 RID: 28704 RVA: 0x0063CAAC File Offset: 0x0063ACAC
		// (set) Token: 0x06007021 RID: 28705 RVA: 0x0063CB60 File Offset: 0x0063AD60
		public bool RadProfBacklightColorControlDefaultBacklightColor_A7811_Visible
		{
			get
			{
				short num = (short)796975092;
				short num2 = num;
				num = (short)426106868;
				switch (num2 == num)
				{
				}
				num = (short)378142720;
				short num3 = num;
				num = (short)763363328;
				if (num != 0)
				{
				}
				num = (short)81723393;
				if (num != 0)
				{
				}
				return this.radProfBacklightColorControlDefaultBacklightColor_A7811.Visible;
			}
			set
			{
				short num = (short)1462501377;
				if (num != 0)
				{
				}
				num = (short)1867879326;
				short num2 = num;
				num = (short)1767674782;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2134638592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1781006336;
				if (num != 0)
				{
				}
				this.radProfBacklightColorControlDefaultBacklightColor_A7811.Visible = value;
			}
		}

		// Token: 0x170039F2 RID: 14834
		// (get) Token: 0x06007022 RID: 28706 RVA: 0x0063CC14 File Offset: 0x0063AE14
		// (set) Token: 0x06007023 RID: 28707 RVA: 0x0063CCC8 File Offset: 0x0063AEC8
		public bool RadProfBacklightColorControlDefaultBacklightColor_A7811_Editable
		{
			get
			{
				short num = (short)781189121;
				if (num != 0)
				{
				}
				num = (short)1664630448;
				short num2 = num;
				num = (short)758660784;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1967652864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1907884032;
				if (num != 0)
				{
				}
				return this.radProfBacklightColorControlDefaultBacklightColor_A7811.Editable;
			}
			set
			{
				short num = (short)722227628;
				short num2 = num;
				num = (short)834687404;
				switch (num2 == num)
				{
				}
				num = (short)2109407232;
				short num3 = num;
				num = (short)1033764865;
				if (num != 0)
				{
				}
				num = (short)1951596544;
				if (num != 0)
				{
				}
				this.radProfBacklightColorControlDefaultBacklightColor_A7811.Editable = value;
			}
		}

		// Token: 0x170039F3 RID: 14835
		// (get) Token: 0x06007024 RID: 28708 RVA: 0x0063CD7C File Offset: 0x0063AF7C
		internal string RadProfBacklightColorControlDefaultBacklightColor_A7811_UILabel
		{
			get
			{
				short num = (short)1650047099;
				short num2 = num;
				num = (short)1072871547;
				switch (num2 == num)
				{
				}
				num = (short)811991040;
				short num3 = num;
				num = (short)35913729;
				if (num != 0)
				{
				}
				num = (short)512884736;
				if (num != 0)
				{
				}
				return this.radProfBacklightColorControlDefaultBacklightColor_A7811.UIName;
			}
		}

		// Token: 0x170039F4 RID: 14836
		// (get) Token: 0x06007025 RID: 28709 RVA: 0x0063CE34 File Offset: 0x0063B034
		// (set) Token: 0x06007026 RID: 28710 RVA: 0x0063CEE8 File Offset: 0x0063B0E8
		internal bool RadProfBacklightColorControlDefaultBacklightColor_A7811_HiddenStatic
		{
			get
			{
				short num = (short)3983913;
				short num2 = num;
				num = (short)928369193;
				switch (num2 == num)
				{
				}
				num = (short)1904607232;
				short num3 = num;
				num = (short)805961729;
				if (num != 0)
				{
				}
				num = (short)391970816;
				if (num != 0)
				{
				}
				return this.radProfBacklightColorControlDefaultBacklightColor_A7811.HiddenStatic;
			}
			set
			{
				short num = (short)2067202049;
				if (num != 0)
				{
				}
				num = (short)2020550034;
				short num2 = num;
				num = (short)269821330;
				switch (num2 == num)
				{
				default:
				{
					num = (short)111017984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)987430912;
				if (num != 0)
				{
				}
				this.radProfBacklightColorControlDefaultBacklightColor_A7811.HiddenStatic = value;
			}
		}

		// Token: 0x170039F5 RID: 14837
		// (get) Token: 0x06007027 RID: 28711 RVA: 0x0063CF9C File Offset: 0x0063B19C
		// (set) Token: 0x06007028 RID: 28712 RVA: 0x0063D050 File Offset: 0x0063B250
		internal bool RadProfBacklightColorControlDefaultBacklightColor_A7811_HiddenDynamic
		{
			get
			{
				short num = (short)1336329862;
				short num2 = num;
				num = (short)921093766;
				switch (num2 == num)
				{
				}
				num = (short)2132606976;
				short num3 = num;
				num = (short)618528768;
				if (num != 0)
				{
				}
				num = (short)2043871233;
				if (num != 0)
				{
				}
				return this.radProfBacklightColorControlDefaultBacklightColor_A7811.HiddenDynamic;
			}
			set
			{
				short num = (short)2073538473;
				short num2 = num;
				num = (short)1537978281;
				switch (num2 == num)
				{
				}
				num = (short)370212864;
				short num3 = num;
				num = (short)1665728512;
				if (num != 0)
				{
				}
				num = (short)39387137;
				if (num != 0)
				{
				}
				this.radProfBacklightColorControlDefaultBacklightColor_A7811.HiddenDynamic = value;
			}
		}

		// Token: 0x170039F6 RID: 14838
		// (get) Token: 0x06007029 RID: 28713 RVA: 0x0063D104 File Offset: 0x0063B304
		public bool RadProfBacklightColorControlDefaultBacklightColor_A7811_HasDiffs
		{
			get
			{
				short num = (short)787662052;
				short num2 = num;
				num = (short)650560740;
				switch (num2 == num)
				{
				}
				num = (short)428736512;
				short num3 = num;
				num = (short)1651965952;
				if (num != 0)
				{
				}
				num = (short)1331691521;
				if (num != 0)
				{
				}
				return this.radProfBacklightColorControlDefaultBacklightColor_A7811._HasDiffs;
			}
		}

		// Token: 0x0600702A RID: 28714 RVA: 0x0063D1B8 File Offset: 0x0063B3B8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1773469696;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4F;
			}
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_35:
				switch (num3)
				{
				case 0:
					return result;
				case 1:
				{
					num = (short)2015420583;
					short num4 = num;
					num = (short)434561191;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_70;
					default:
						num = (short)615579648;
						if (num != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)690946052;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					break;
				}
				case 2:
					num = (short)249495553;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (base.ParentRecset != null)
					{
						goto IL_70;
					}
					return result;
				case 4:
					num = (short)421920769;
					if (num != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1237254144;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4F;
				IL_70:
				num = (short)526843906;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_4F:
			result = null;
			num = (short)1540554755;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_35;
		}

		// Token: 0x04002B43 RID: 11075
		private global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInnerRecset innerRecset;

		// Token: 0x04002B44 RID: 11076
		private global::AcpBusinessLayer.AcpRecRefField radProfBacklightColorControlDefaultBacklightColor_A7811;
	}
}
