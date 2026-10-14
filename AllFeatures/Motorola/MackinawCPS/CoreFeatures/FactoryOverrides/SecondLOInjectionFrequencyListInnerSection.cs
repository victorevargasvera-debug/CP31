using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000465 RID: 1125
	[global::System.Serializable]
	public class SecondLOInjectionFrequencyListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009529 RID: 38185 RVA: 0x008C4944 File Offset: 0x008C2B44
		public SecondLOInjectionFrequencyListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600952A RID: 38186 RVA: 0x008C4960 File Offset: 0x008C2B60
		protected SecondLOInjectionFrequencyListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600952B RID: 38187 RVA: 0x008C4978 File Offset: 0x008C2B78
		public override void Init()
		{
			int a_ = 6;
			short num = (short)1093945163;
			short num2 = num;
			num = (short)796018507;
			switch (num2 == num)
			{
			}
			num = (short)2034106368;
			if (num != 0)
			{
			}
			num = (short)592642049;
			if (num != 0)
			{
			}
			num = (short)2023686144;
			short num3 = num;
			this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062 = new global::AcpBusinessLayer.AcpFrequencyField(170205000, this, global::AllFeatures.CodeplugGuid.b("臆꫈뿊苌뷎뗐ꃒ蛔닖뫘듚돜믞균곢곤触菨軪軬鯮飰鳲鯴뇶诸黺購諾搀洂昄縆娈渊渌怎缐眒夔堖倘甚眜稞䈠圢䰤䠦䜨洪弬䨮䀰䘲倴夶娸䈺戼績础獂獄畆", a_), global::CommonResources.AcgResources.ID_SECONDLOINJECTIONFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.DataTransferOrder = 10;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("铆곈꣊ꋌꇎ뗐駔飖律鋚돜뗞蓠胢釤軦蛨藪췬ꧮ菰雲蓴苶鳸闺黼蛾℀伂氄理紈", a_);
			base.Id = 10011;
			base.UIName = global::CommonResources.AcgResources.ID_SECONDLOINJECTIONFREQUENCYLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600952C RID: 38188 RVA: 0x008C4A9C File Offset: 0x008C2C9C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 16;
			short num = (short)585433093;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields != null)
					{
						num = (short)887685121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B9;
				case 1:
					num = (short)116064262;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062 = new global::AcpBusinessLayer.AcpFrequencyField(170205000, this, global::AllFeatures.CodeplugGuid.b("韐냒ꇔ飖ꯘ뿚껜賞蓠胢諤触跨꟪ꋬꛮ鿰駲郴银跸鋺鋼釾䜀焂怄瘆簈渊挌氎栐䀒瀔琖瘘甚礜匞渠樢䬤䴦䰨䠪夬䘮帰崲猴䔶尸䨺䠼娾⽀⁂㱄ᡆࡈ牊経祎捐", a_), global::CommonResources.AcgResources.ID_SECONDLOINJECTIONFREQUENCYMHZ);
					this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.DataTransferOrder = 10;
					num = (short)1859387395;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_C2;
				case 4:
					num = (short)1695809536;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_1E;
				case 6:
				{
					num = (short)817089272;
					short num3 = num;
					num = (short)179817208;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E;
					case 1:
						break;
					default:
					{
						num = (short)1600978944;
						short num4 = num;
						break;
					}
					}
					num = (short)261685248;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韐냒ꇔ飖ꯘ뿚껜賞蓠胢諤触跨꟪ꋬꛮ鿰駲郴银跸鋺鋼釾䜀焂怄瘆簈渊挌氎栐䀒瀔琖瘘甚礜匞渠樢䬤䴦䰨䠪夬䘮帰崲猴䔶尸䨺䠼娾⽀⁂㱄ᡆࡈ牊経祎捐", a_)))
					{
						num = (short)1065353218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B9;
				}
				}
				goto IL_4A;
				IL_1E:
				switch (0)
				{
				case 0:
					IL_4A:
					if (!global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						goto IL_1B9;
					}
					num = (short)1910505476;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_C2:
			IL_1B9:
			num = (short)228982785;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苐뛒뛔룖럘뿚﷜鏞껠쏢곤触菨軪軬鯮飰鳲鯴ퟶ뿸觺飼軾琀昂欄搆瀈⬊䄌明成朒", a_);
			base.Id = 10011;
			base.UIName = global::CommonResources.AcgResources.ID_SECONDLOINJECTIONFREQUENCYLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600952D RID: 38189 RVA: 0x008C4CBC File Offset: 0x008C2EBC
		public override void PopulateReferences()
		{
			short num = (short)852070299;
			short num2 = num;
			num = (short)1721274267;
			switch (num2 == num)
			{
			}
			num = (short)2103574529;
			if (num != 0)
			{
			}
			num = (short)2122186752;
			if (num != 0)
			{
			}
			num = (short)515571712;
			short num3 = num;
		}

		// Token: 0x0600952E RID: 38190 RVA: 0x008C4D68 File Offset: 0x008C2F68
		public override void DropReferences()
		{
			short num = (short)518288230;
			short num2 = num;
			num = (short)242840422;
			switch (num2 == num)
			{
			}
			num = (short)1013514240;
			if (num != 0)
			{
			}
			num = (short)628817921;
			if (num != 0)
			{
			}
			num = (short)2126249984;
			short num3 = num;
		}

		// Token: 0x0600952F RID: 38191 RVA: 0x008C4E10 File Offset: 0x008C3010
		public override void SetConstraints()
		{
			short num = (short)580473382;
			short num2 = num;
			num = (short)917197350;
			switch (num2 == num)
			{
			}
			num = (short)1928593409;
			if (num != 0)
			{
			}
			num = (short)928645120;
			if (num != 0)
			{
			}
			num = (short)946667520;
			short num3 = num;
			this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesConstraints.ConFactoryOverridesEnableIsChecked);
			this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesConstraints.conFacOvrrdSecLOInjFreqIsValid);
		}

		// Token: 0x06009530 RID: 38192 RVA: 0x008C4EE8 File Offset: 0x008C30E8
		public override void SetupDependencies()
		{
			short num = (short)1911848420;
			short num2 = num;
			num = (short)895516132;
			switch (num2 == num)
			{
			}
			num = (short)1153695744;
			if (num != 0)
			{
			}
			num = (short)566689793;
			if (num != 0)
			{
			}
			num = (short)1014497280;
			short num3 = num;
			(base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverrides).General.RadWideAdvancedFactoryOverrides_A8004.AddDependentObject(this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062);
		}

		// Token: 0x17004AFE RID: 19198
		// (get) Token: 0x06009531 RID: 38193 RVA: 0x008C4FDC File Offset: 0x008C31DC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1928855553;
				if (num != 0)
				{
				}
				num = (short)438829261;
				short num2 = num;
				num = (short)1513947341;
				switch (num2 == num)
				{
				}
				num = (short)1935933440;
				if (num != 0)
				{
				}
				num = (short)1920401408;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17004AFF RID: 19199
		// (get) Token: 0x06009532 RID: 38194 RVA: 0x008C508C File Offset: 0x008C328C
		// (set) Token: 0x06009533 RID: 38195 RVA: 0x008C5140 File Offset: 0x008C3340
		public int FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062Value
		{
			get
			{
				short num = (short)2060341898;
				short num2 = num;
				num = (short)1318539914;
				switch (num2 == num)
				{
				}
				num = (short)1080360961;
				if (num != 0)
				{
				}
				num = (short)2086797312;
				if (num != 0)
				{
				}
				num = (short)219283456;
				short num3 = num;
				return this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.Value;
			}
			set
			{
				short num = (short)414715459;
				short num2 = num;
				num = (short)238620227;
				switch (num2 == num)
				{
				}
				num = (short)2042691585;
				if (num != 0)
				{
				}
				num = (short)140902400;
				if (num != 0)
				{
				}
				num = (short)1228079104;
				short num3 = num;
				this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.Value = value;
			}
		}

		// Token: 0x17004B00 RID: 19200
		// (get) Token: 0x06009534 RID: 38196 RVA: 0x008C51FC File Offset: 0x008C33FC
		// (set) Token: 0x06009535 RID: 38197 RVA: 0x008C52B0 File Offset: 0x008C34B0
		public string FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062_UIValue
		{
			get
			{
				short num = (short)683191808;
				short num2 = num;
				num = (short)589803008;
				switch (num2 == num)
				{
				}
				num = (short)619773952;
				if (num != 0)
				{
				}
				num = (short)453640193;
				if (num != 0)
				{
				}
				num = (short)60424192;
				short num3 = num;
				return this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.UIValue;
			}
			set
			{
				short num = (short)336830214;
				short num2 = num;
				num = (short)1504222982;
				switch (num2 == num)
				{
				}
				num = (short)540803072;
				if (num != 0)
				{
				}
				num = (short)598147073;
				if (num != 0)
				{
				}
				num = (short)1792278528;
				short num3 = num;
				this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.UIValue = value;
			}
		}

		// Token: 0x17004B01 RID: 19201
		// (get) Token: 0x06009536 RID: 38198 RVA: 0x008C5364 File Offset: 0x008C3564
		public global::AcpBusinessLayer.AcpFrequencyField FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062
		{
			get
			{
				short num = (short)1876120026;
				short num2 = num;
				num = (short)1744261594;
				switch (num2 == num)
				{
				}
				num = (short)383057921;
				if (num != 0)
				{
				}
				num = (short)1542651904;
				if (num != 0)
				{
				}
				num = (short)859832320;
				short num3 = num;
				return this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062;
			}
		}

		// Token: 0x17004B02 RID: 19202
		// (get) Token: 0x06009537 RID: 38199 RVA: 0x008C5414 File Offset: 0x008C3614
		// (set) Token: 0x06009538 RID: 38200 RVA: 0x008C54C8 File Offset: 0x008C36C8
		internal int FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062Min
		{
			get
			{
				short num = (short)1657857058;
				short num2 = num;
				num = (short)1350820898;
				switch (num2 == num)
				{
				}
				num = (short)1814495233;
				if (num != 0)
				{
				}
				num = (short)2137194496;
				if (num != 0)
				{
				}
				num = (short)1358888960;
				short num3 = num;
				return this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.Min;
			}
			set
			{
				short num = (short)1428489004;
				short num2 = num;
				num = (short)180421420;
				switch (num2 == num)
				{
				}
				num = (short)1153892352;
				if (num != 0)
				{
				}
				num = (short)1575616513;
				if (num != 0)
				{
				}
				num = (short)266862592;
				short num3 = num;
				this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.Min = value;
			}
		}

		// Token: 0x17004B03 RID: 19203
		// (get) Token: 0x06009539 RID: 38201 RVA: 0x008C5580 File Offset: 0x008C3780
		// (set) Token: 0x0600953A RID: 38202 RVA: 0x008C5634 File Offset: 0x008C3834
		internal int FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062Max
		{
			get
			{
				short num = (short)121325940;
				short num2 = num;
				num = (short)424429940;
				switch (num2 == num)
				{
				}
				num = (short)835649536;
				if (num != 0)
				{
				}
				num = (short)929038337;
				if (num != 0)
				{
				}
				num = (short)1030881280;
				short num3 = num;
				return this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.Max;
			}
			set
			{
				short num = (short)20367324;
				short num2 = num;
				num = (short)1361889244;
				switch (num2 == num)
				{
				}
				num = (short)1518272513;
				if (num != 0)
				{
				}
				num = (short)1477705728;
				if (num != 0)
				{
				}
				num = (short)36372480;
				short num3 = num;
				this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.Max = value;
			}
		}

		// Token: 0x17004B04 RID: 19204
		// (get) Token: 0x0600953B RID: 38203 RVA: 0x008C56EC File Offset: 0x008C38EC
		// (set) Token: 0x0600953C RID: 38204 RVA: 0x008C57A0 File Offset: 0x008C39A0
		internal int FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062Step
		{
			get
			{
				short num = (short)1272577539;
				short num2 = num;
				num = (short)227212803;
				switch (num2 == num)
				{
				}
				num = (short)988348417;
				if (num != 0)
				{
				}
				num = (short)1658454016;
				if (num != 0)
				{
				}
				num = (short)1496055808;
				short num3 = num;
				return this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.StepSize;
			}
			set
			{
				short num = (short)1138785975;
				short num2 = num;
				num = (short)1662222007;
				switch (num2 == num)
				{
				}
				num = (short)1739718656;
				if (num != 0)
				{
				}
				num = (short)433258497;
				if (num != 0)
				{
				}
				num = (short)1765539840;
				short num3 = num;
				this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.StepSize = value;
			}
		}

		// Token: 0x17004B05 RID: 19205
		// (get) Token: 0x0600953D RID: 38205 RVA: 0x008C5854 File Offset: 0x008C3A54
		// (set) Token: 0x0600953E RID: 38206 RVA: 0x008C5908 File Offset: 0x008C3B08
		public bool FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062_Applicable
		{
			get
			{
				short num = (short)1328702252;
				short num2 = num;
				num = (short)1431331628;
				switch (num2 == num)
				{
				}
				num = (short)222494721;
				if (num != 0)
				{
				}
				num = (short)520749056;
				if (num != 0)
				{
				}
				num = (short)496500736;
				short num3 = num;
				return this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.Applicable;
			}
			set
			{
				short num = (short)1466486219;
				short num2 = num;
				num = (short)746311115;
				switch (num2 == num)
				{
				}
				num = (short)467533825;
				if (num != 0)
				{
				}
				num = (short)748421120;
				if (num != 0)
				{
				}
				num = (short)60948480;
				short num3 = num;
				this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.Applicable = value;
			}
		}

		// Token: 0x17004B06 RID: 19206
		// (get) Token: 0x0600953F RID: 38207 RVA: 0x008C59BC File Offset: 0x008C3BBC
		// (set) Token: 0x06009540 RID: 38208 RVA: 0x008C5A70 File Offset: 0x008C3C70
		public bool FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062_Valid
		{
			get
			{
				short num = (short)678749778;
				short num2 = num;
				num = (short)2099635794;
				switch (num2 == num)
				{
				}
				num = (short)1766195201;
				if (num != 0)
				{
				}
				num = (short)527106048;
				if (num != 0)
				{
				}
				num = (short)115671040;
				short num3 = num;
				return this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.Valid;
			}
			set
			{
				short num = (short)1279174625;
				short num2 = num;
				num = (short)806004705;
				switch (num2 == num)
				{
				}
				num = (short)665780225;
				if (num != 0)
				{
				}
				num = (short)671154176;
				if (num != 0)
				{
				}
				num = (short)1015611392;
				short num3 = num;
				this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.Valid = value;
			}
		}

		// Token: 0x17004B07 RID: 19207
		// (get) Token: 0x06009541 RID: 38209 RVA: 0x008C5B24 File Offset: 0x008C3D24
		// (set) Token: 0x06009542 RID: 38210 RVA: 0x008C5BD8 File Offset: 0x008C3DD8
		public bool FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062_Visible
		{
			get
			{
				short num = (short)1203412482;
				short num2 = num;
				num = (short)1274453506;
				switch (num2 == num)
				{
				}
				num = (short)30081025;
				if (num != 0)
				{
				}
				num = (short)410976256;
				if (num != 0)
				{
				}
				num = (short)1327562752;
				short num3 = num;
				return this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.Visible;
			}
			set
			{
				short num = (short)1326161298;
				short num2 = num;
				num = (short)82419090;
				switch (num2 == num)
				{
				}
				num = (short)312213505;
				if (num != 0)
				{
				}
				num = (short)96665600;
				if (num != 0)
				{
				}
				num = (short)1219952640;
				short num3 = num;
				this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.Visible = value;
			}
		}

		// Token: 0x17004B08 RID: 19208
		// (get) Token: 0x06009543 RID: 38211 RVA: 0x008C5C90 File Offset: 0x008C3E90
		// (set) Token: 0x06009544 RID: 38212 RVA: 0x008C5D44 File Offset: 0x008C3F44
		public bool FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062_Editable
		{
			get
			{
				short num = (short)1182109495;
				short num2 = num;
				num = (short)1459392311;
				switch (num2 == num)
				{
				}
				num = (short)1176043521;
				if (num != 0)
				{
				}
				num = (short)1714094080;
				if (num != 0)
				{
				}
				num = (short)2084634624;
				short num3 = num;
				return this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.Editable;
			}
			set
			{
				short num = (short)1802929246;
				short num2 = num;
				num = (short)1356825694;
				switch (num2 == num)
				{
				}
				num = (short)1513226240;
				if (num != 0)
				{
				}
				num = (short)869007361;
				if (num != 0)
				{
				}
				num = (short)382795776;
				short num3 = num;
				this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.Editable = value;
			}
		}

		// Token: 0x17004B09 RID: 19209
		// (get) Token: 0x06009545 RID: 38213 RVA: 0x008C5DF8 File Offset: 0x008C3FF8
		internal string FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062_UILabel
		{
			get
			{
				short num = (short)816741791;
				short num2 = num;
				num = (short)1348369823;
				switch (num2 == num)
				{
				}
				num = (short)718995457;
				if (num != 0)
				{
				}
				num = (short)919732224;
				if (num != 0)
				{
				}
				num = (short)521076736;
				short num3 = num;
				return this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.UIName;
			}
		}

		// Token: 0x17004B0A RID: 19210
		// (get) Token: 0x06009546 RID: 38214 RVA: 0x008C5EB0 File Offset: 0x008C40B0
		// (set) Token: 0x06009547 RID: 38215 RVA: 0x008C5F64 File Offset: 0x008C4164
		internal bool FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062_HiddenStatic
		{
			get
			{
				short num = (short)1294829715;
				short num2 = num;
				num = (short)694126739;
				switch (num2 == num)
				{
				}
				num = (short)1711407105;
				if (num != 0)
				{
				}
				num = (short)1656160256;
				if (num != 0)
				{
				}
				num = (short)1813774336;
				short num3 = num;
				return this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.HiddenStatic;
			}
			set
			{
				short num = (short)1188495360;
				short num2 = num;
				num = (short)1462873950;
				short num3 = num;
				num = (short)1486401374;
				switch (num3 == num)
				{
				}
				num = (short)1927479297;
				if (num != 0)
				{
				}
				num = (short)1889599488;
				if (num != 0)
				{
				}
				this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.HiddenStatic = value;
			}
		}

		// Token: 0x17004B0B RID: 19211
		// (get) Token: 0x06009548 RID: 38216 RVA: 0x008C6018 File Offset: 0x008C4218
		// (set) Token: 0x06009549 RID: 38217 RVA: 0x008C60CC File Offset: 0x008C42CC
		internal bool FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062_HiddenDynamic
		{
			get
			{
				short num = (short)1071513600;
				short num2 = num;
				num = (short)1076232193;
				if (num != 0)
				{
				}
				num = (short)1405976295;
				short num3 = num;
				num = (short)329416423;
				switch (num3 == num)
				{
				}
				num = (short)1136328704;
				if (num != 0)
				{
				}
				return this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.HiddenDynamic;
			}
			set
			{
				short num = (short)232456192;
				short num2 = num;
				num = (short)639792960;
				short num3 = num;
				num = (short)300054336;
				switch (num3 == num)
				{
				}
				num = (short)31850497;
				if (num != 0)
				{
				}
				num = (short)1656029184;
				if (num != 0)
				{
				}
				this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.HiddenDynamic = value;
			}
		}

		// Token: 0x17004B0C RID: 19212
		// (get) Token: 0x0600954A RID: 38218 RVA: 0x008C6180 File Offset: 0x008C4380
		public bool FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062_HasDiffs
		{
			get
			{
				short num = (short)574947328;
				short num2 = num;
				num = (short)1359020033;
				if (num != 0)
				{
				}
				num = (short)70253215;
				short num3 = num;
				num = (short)1205598879;
				switch (num3 == num)
				{
				}
				num = (short)871628800;
				if (num != 0)
				{
				}
				return this.fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062._HasDiffs;
			}
		}

		// Token: 0x17004B0D RID: 19213
		// (get) Token: 0x0600954B RID: 38219 RVA: 0x008C6234 File Offset: 0x008C4434
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)354549760;
				short num2 = num;
				num = (short)583270401;
				if (num != 0)
				{
				}
				num = (short)1883309360;
				short num3 = num;
				num = (short)1591018800;
				switch (num3 == num)
				{
				}
				num = (short)978518016;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x0600954C RID: 38220 RVA: 0x008C62F0 File Offset: 0x008C44F0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_D6;
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)2115829763;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1375141889;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					goto IL_124;
				case 4:
					num2 = (short)2050228226;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_124:
			return result;
			IL_24:
			result = null;
			num2 = (short)1644777184;
			short num3 = num2;
			num2 = (short)127225568;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D6:
				if (base.ParentRecset != null)
				{
					num2 = (short)1676214276;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			default:
			{
				num2 = (short)1792147456;
				short num4 = num2;
				num2 = (short)262340609;
				if (num2 != 0)
				{
				}
				num2 = (short)934543360;
				if (num2 != 0)
				{
				}
				num2 = (short)992083968;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return result;
		}

		// Token: 0x04004A02 RID: 18946
		private global::AcpBusinessLayer.AcpFrequencyField fctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062;
	}
}
