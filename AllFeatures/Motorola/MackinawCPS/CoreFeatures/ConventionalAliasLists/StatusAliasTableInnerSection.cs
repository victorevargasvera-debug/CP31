using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists
{
	// Token: 0x020005DB RID: 1499
	[global::System.Serializable]
	public class StatusAliasTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600CEE6 RID: 52966 RVA: 0x00C07A44 File Offset: 0x00C05C44
		public StatusAliasTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600CEE7 RID: 52967 RVA: 0x00C07A60 File Offset: 0x00C05C60
		protected StatusAliasTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600CEE8 RID: 52968 RVA: 0x00C07A78 File Offset: 0x00C05C78
		public override void Init()
		{
			int a_ = 18;
			short num = (short)1057816576;
			short num2 = num;
			num = (short)791437305;
			short num3 = num;
			num = (short)321150969;
			switch (num3 == num)
			{
			}
			num = (short)547422208;
			if (num != 0)
			{
			}
			num = (short)1196425217;
			if (num != 0)
			{
			}
			this.cnvAlsLstStatusAliasListStatusAliasText_A9192 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ飘럚껜鏞鋠韢뛤鏦裨鿪飬鳮냰鿲鳴零諸럺铼賾甀倂焄昆紈縊縌与紐稒琔搖䴘縚攜欞縠戢ᰤᘦဨᤪ", a_), global::CommonResources.AcgResources.ID_STATUSALIASTEXT, 14);
			this.cnvAlsLstStatusAliasListStatusAliasText_A9192.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvAlsLstStatusAliasListStatusAliasText_A9192.DataTransferOrder = 6;
			this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ飘럚껜鏞鋠韢뛤鏦裨鿪飬鳮냰鿲鳴零諸럺铼賾甀倂焄昆紈縊縌与紐稒琔搖團渚瀜紞䐠儢稤昦ဨᨪᐬḮ", a_), global::CommonResources.AcgResources.ID_STATUSALIASNUMBER, 1, 16, null, null, 0, 1);
			this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.DataTransferOrder = 4;
			this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胒ꇔ뛖귘껚껜￞ꃠ迢賤蛦髨쯪맬軮鏰鿲郴", a_);
			base.Id = 10015;
			base.UIName = global::CommonResources.AcgResources.ID_STATUSALIASTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600CEE9 RID: 52969 RVA: 0x00C07BE0 File Offset: 0x00C05DE0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)716898307;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌軎뷐ꃒ駔ꓖ귘裚꧜뻞闠離雤ꛦ藨苪賬鳮뷰髲蛴菶꫸迺鳼课琀瀂䐄欆怈樊縌䄎搐縒眔爖欘䐚尜☞ဠᨢᐤ", a_), global::CommonResources.AcgResources.ID_STATUSALIASNUMBER, null, null, 0, 1);
					this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.DataTransferOrder = 4;
					this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.ShowHexValue = false;
					num = (short)2003959809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_223;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌軎뷐ꃒ駔ꓖ귘裚꧜뻞闠離雤ꛦ藨苪賬鳮뷰髲蛴菶꫸迺鳼课琀瀂䐄欆怈樊縌䄎搐縒眔爖欘䐚尜☞ဠᨢᐤ", a_)))
					{
						num = (short)1652817920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_272;
				case 3:
					num = (short)20054017;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_7D;
					}
					continue;
				case 4:
					num = (short)1444610057;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)52297864;
					short num3 = num;
					num = (short)600375432;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_187;
					default:
						num = (short)1257373696;
						if (num != 0)
						{
						}
						num = (short)611909638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					if (producerFields != null)
					{
						num = (short)1848836100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_272;
				case 7:
					goto IL_187;
				case 8:
					this.cnvAlsLstStatusAliasListStatusAliasText_A9192 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌軎뷐ꃒ駔ꓖ귘裚꧜뻞闠離雤ꛦ藨苪賬鳮뷰髲蛴菶꫸迺鳼课琀瀂䐄欆怈樊縌嬎琐欒愔䠖堘√Ⱌ☞ጠ", a_), global::CommonResources.AcgResources.ID_STATUSALIASTEXT, 14);
					this.cnvAlsLstStatusAliasListStatusAliasText_A9192.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvAlsLstStatusAliasListStatusAliasText_A9192.DataTransferOrder = 6;
					num = (short)1832189959;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌軎뷐ꃒ駔ꓖ귘裚꧜뻞闠離雤ꛦ藨苪賬鳮뷰髲蛴菶꫸迺鳼课琀瀂䐄欆怈樊縌嬎琐欒愔䠖堘√Ⱌ☞ጠ", a_)))
					{
						num = (short)250150920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E9;
				}
				IL_7D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)533069829;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_E9:
				num = (short)289013762;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_187:
				goto IL_E9;
			}
			IL_223:
			IL_272:
			num = (short)1020657664;
			short num4 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("髈뿊곌믎ꓐꃒ雖뗘닚볜곞쇠럢蓤藦藨軪", a_);
			base.Id = 10015;
			base.UIName = global::CommonResources.AcgResources.ID_STATUSALIASTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600CEEA RID: 52970 RVA: 0x00C07EB8 File Offset: 0x00C060B8
		public override void PopulateReferences()
		{
			short num = (short)1826226176;
			short num2 = num;
			num = (short)879261786;
			short num3 = num;
			num = (short)1188984922;
			switch (num3 == num)
			{
			}
			num = (short)96337920;
			if (num != 0)
			{
			}
			num = (short)1750073345;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CEEB RID: 52971 RVA: 0x00C07F60 File Offset: 0x00C06160
		public override void DropReferences()
		{
			short num = (short)181272576;
			short num2 = num;
			num = (short)1476330236;
			short num3 = num;
			num = (short)2056061692;
			switch (num3 == num)
			{
			}
			num = (short)1296367617;
			if (num != 0)
			{
			}
			num = (short)2129068032;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CEEC RID: 52972 RVA: 0x00C0800C File Offset: 0x00C0620C
		public override void SetConstraints()
		{
			short num = (short)103481344;
			short num2 = num;
			num = (short)1475746306;
			short num3 = num;
			num = (short)49551874;
			switch (num3 == num)
			{
			}
			num = (short)2020474881;
			if (num != 0)
			{
			}
			num = (short)302645248;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CEED RID: 52973 RVA: 0x00C080B4 File Offset: 0x00C062B4
		public override void SetupDependencies()
		{
			short num = (short)1939931136;
			short num2 = num;
			num = (short)1855004816;
			short num3 = num;
			num = (short)703930512;
			switch (num3 == num)
			{
			}
			num = (short)829358081;
			if (num != 0)
			{
			}
			num = (short)1443758080;
			if (num != 0)
			{
			}
		}

		// Token: 0x17006803 RID: 26627
		// (get) Token: 0x0600CEEE RID: 52974 RVA: 0x00C0815C File Offset: 0x00C0635C
		public bool HasDiffs
		{
			get
			{
				short num = (short)174718976;
				short num2 = num;
				num = (short)2104629015;
				short num3 = num;
				num = (short)599463703;
				switch (num3 == num)
				{
				}
				num = (short)725745665;
				if (num != 0)
				{
				}
				num = (short)324927488;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17006804 RID: 26628
		// (get) Token: 0x0600CEEF RID: 52975 RVA: 0x00C08208 File Offset: 0x00C06408
		// (set) Token: 0x0600CEF0 RID: 52976 RVA: 0x00C082BC File Offset: 0x00C064BC
		public string CnvAlsLstStatusAliasListStatusAliasText_A9192Value
		{
			get
			{
				short num = (short)42795008;
				short num2 = num;
				num = (short)26904057;
				short num3 = num;
				num = (short)791840249;
				switch (num3 == num)
				{
				}
				num = (short)1201078272;
				if (num != 0)
				{
				}
				num = (short)1606352897;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasText_A9192.Value;
			}
			set
			{
				short num = (short)340918272;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 1:
					{
						num = (short)1784283137;
						if (num != 0)
						{
						}
						num = (short)297992192;
						short num3 = num;
						this.cnvAlsLstStatusAliasListStatusAliasText_A9192.Value = value;
						goto IL_FD;
					}
					case 2:
						return;
					}
					IL_31:
					num = (short)938347354;
					short num4 = num;
					num = (short)997329754;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_FD:
						num = (short)1413283842;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)534511616;
						if (num != 0)
						{
						}
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)105119745;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x17006805 RID: 26629
		// (get) Token: 0x0600CEF1 RID: 52977 RVA: 0x00C083E4 File Offset: 0x00C065E4
		// (set) Token: 0x0600CEF2 RID: 52978 RVA: 0x00C0849C File Offset: 0x00C0669C
		public string CnvAlsLstStatusAliasListStatusAliasText_A9192_UIValue
		{
			get
			{
				short num = (short)337969152;
				short num2 = num;
				num = (short)1939963484;
				short num3 = num;
				num = (short)328433244;
				switch (num3 == num)
				{
				}
				num = (short)133562368;
				if (num != 0)
				{
				}
				num = (short)1738473473;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasText_A9192.Value;
			}
			set
			{
				short num = (short)1741225984;
				short num2 = num;
				num = (short)1867128094;
				short num3 = num;
				num = (short)1356537118;
				switch (num3 == num)
				{
				}
				num = (short)2038431744;
				if (num != 0)
				{
				}
				num = (short)1067384833;
				if (num != 0)
				{
				}
				this.cnvAlsLstStatusAliasListStatusAliasText_A9192.Value = value;
			}
		}

		// Token: 0x17006806 RID: 26630
		// (get) Token: 0x0600CEF3 RID: 52979 RVA: 0x00C08550 File Offset: 0x00C06750
		public global::AcpBusinessLayer.AcpKeyField CnvAlsLstStatusAliasListStatusAliasText_A9192
		{
			get
			{
				short num = (short)723648512;
				short num2 = num;
				num = (short)1410380488;
				short num3 = num;
				num = (short)567456456;
				switch (num3 == num)
				{
				}
				num = (short)520421377;
				if (num != 0)
				{
				}
				num = (short)1278214144;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasText_A9192;
			}
		}

		// Token: 0x17006807 RID: 26631
		// (get) Token: 0x0600CEF4 RID: 52980 RVA: 0x00C08604 File Offset: 0x00C06804
		// (set) Token: 0x0600CEF5 RID: 52981 RVA: 0x00C086B8 File Offset: 0x00C068B8
		public bool CnvAlsLstStatusAliasListStatusAliasText_A9192_Applicable
		{
			get
			{
				short num = (short)1605304320;
				short num2 = num;
				num = (short)1905936025;
				short num3 = num;
				num = (short)428689049;
				switch (num3 == num)
				{
				}
				num = (short)914685952;
				if (num != 0)
				{
				}
				num = (short)96206849;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasText_A9192.Applicable;
			}
			set
			{
				short num = (short)1414201344;
				short num2 = num;
				num = (short)469685800;
				short num3 = num;
				num = (short)1308677672;
				switch (num3 == num)
				{
				}
				num = (short)1796276224;
				if (num != 0)
				{
				}
				num = (short)78577665;
				if (num != 0)
				{
				}
				this.cnvAlsLstStatusAliasListStatusAliasText_A9192.Applicable = value;
			}
		}

		// Token: 0x17006808 RID: 26632
		// (get) Token: 0x0600CEF6 RID: 52982 RVA: 0x00C08770 File Offset: 0x00C06970
		// (set) Token: 0x0600CEF7 RID: 52983 RVA: 0x00C08824 File Offset: 0x00C06A24
		public bool CnvAlsLstStatusAliasListStatusAliasText_A9192_Valid
		{
			get
			{
				short num = (short)1075642368;
				short num2 = num;
				num = (short)499707786;
				short num3 = num;
				num = (short)956624778;
				switch (num3 == num)
				{
				}
				num = (short)1175191553;
				if (num != 0)
				{
				}
				num = (short)717225984;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasText_A9192.Valid;
			}
			set
			{
				short num = (short)392888320;
				short num2 = num;
				num = (short)306949058;
				short num3 = num;
				num = (short)1025813442;
				switch (num3 == num)
				{
				}
				num = (short)1730019329;
				if (num != 0)
				{
				}
				num = (short)1054670848;
				if (num != 0)
				{
				}
				this.cnvAlsLstStatusAliasListStatusAliasText_A9192.Valid = value;
			}
		}

		// Token: 0x17006809 RID: 26633
		// (get) Token: 0x0600CEF8 RID: 52984 RVA: 0x00C088DC File Offset: 0x00C06ADC
		// (set) Token: 0x0600CEF9 RID: 52985 RVA: 0x00C08990 File Offset: 0x00C06B90
		public bool CnvAlsLstStatusAliasListStatusAliasText_A9192_Visible
		{
			get
			{
				short num = (short)1046544384;
				short num2 = num;
				num = (short)632396657;
				short num3 = num;
				num = (short)731749233;
				switch (num3 == num)
				{
				}
				num = (short)1527119873;
				if (num != 0)
				{
				}
				num = (short)1822162944;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasText_A9192.Visible;
			}
			set
			{
				short num = (short)325779456;
				short num2 = num;
				num = (short)925492545;
				short num3 = num;
				num = (short)1419044161;
				switch (num3 == num)
				{
				}
				num = (short)238878721;
				if (num != 0)
				{
				}
				num = (short)2078867456;
				if (num != 0)
				{
				}
				this.cnvAlsLstStatusAliasListStatusAliasText_A9192.Visible = value;
			}
		}

		// Token: 0x1700680A RID: 26634
		// (get) Token: 0x0600CEFA RID: 52986 RVA: 0x00C08A48 File Offset: 0x00C06C48
		// (set) Token: 0x0600CEFB RID: 52987 RVA: 0x00C08AFC File Offset: 0x00C06CFC
		public bool CnvAlsLstStatusAliasListStatusAliasText_A9192_Editable
		{
			get
			{
				short num = (short)467402752;
				short num2 = num;
				num = (short)1623190115;
				short num3 = num;
				num = (short)707324515;
				switch (num3 == num)
				{
				}
				num = (short)834469888;
				if (num != 0)
				{
				}
				num = (short)145424385;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasText_A9192.Editable;
			}
			set
			{
				short num = (short)1755250688;
				short num2 = num;
				num = (short)743692404;
				short num3 = num;
				num = (short)412670068;
				switch (num3 == num)
				{
				}
				num = (short)1906638848;
				if (num != 0)
				{
				}
				num = (short)532348929;
				if (num != 0)
				{
				}
				this.cnvAlsLstStatusAliasListStatusAliasText_A9192.Editable = value;
			}
		}

		// Token: 0x1700680B RID: 26635
		// (get) Token: 0x0600CEFC RID: 52988 RVA: 0x00C08BB0 File Offset: 0x00C06DB0
		internal string CnvAlsLstStatusAliasListStatusAliasText_A9192_UILabel
		{
			get
			{
				short num = (short)317325313;
				if (num != 0)
				{
				}
				num = (short)1882062848;
				short num2 = num;
				num = (short)2038113629;
				short num3 = num;
				num = (short)960570717;
				switch (num3 == num)
				{
				}
				num = (short)1356529664;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasText_A9192.UIName;
			}
		}

		// Token: 0x1700680C RID: 26636
		// (get) Token: 0x0600CEFD RID: 52989 RVA: 0x00C08C68 File Offset: 0x00C06E68
		// (set) Token: 0x0600CEFE RID: 52990 RVA: 0x00C08D1C File Offset: 0x00C06F1C
		internal bool CnvAlsLstStatusAliasListStatusAliasText_A9192_HiddenStatic
		{
			get
			{
				short num = (short)274518569;
				short num2 = num;
				num = (short)337760809;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1232535552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)853934080;
				if (num != 0)
				{
				}
				num = (short)1903689729;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasText_A9192.HiddenStatic;
			}
			set
			{
				short num = (short)1797379956;
				short num2 = num;
				num = (short)1897781108;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1103495168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)917897216;
				if (num != 0)
				{
				}
				num = (short)1767899137;
				if (num != 0)
				{
				}
				this.cnvAlsLstStatusAliasListStatusAliasText_A9192.HiddenStatic = value;
			}
		}

		// Token: 0x1700680D RID: 26637
		// (get) Token: 0x0600CEFF RID: 52991 RVA: 0x00C08DD4 File Offset: 0x00C06FD4
		// (set) Token: 0x0600CF00 RID: 52992 RVA: 0x00C08E88 File Offset: 0x00C07088
		internal bool CnvAlsLstStatusAliasListStatusAliasText_A9192_HiddenDynamic
		{
			get
			{
				short num = (short)1884304324;
				short num2 = num;
				num = (short)1862480836;
				switch (num2 == num)
				{
				default:
				{
					num = (short)56492032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1648427009;
				if (num != 0)
				{
				}
				num = (short)371851264;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasText_A9192.HiddenDynamic;
			}
			set
			{
				short num = (short)1739249891;
				short num2 = num;
				num = (short)1764940003;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1384448000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)434765825;
				if (num != 0)
				{
				}
				num = (short)1809186816;
				if (num != 0)
				{
				}
				this.cnvAlsLstStatusAliasListStatusAliasText_A9192.HiddenDynamic = value;
			}
		}

		// Token: 0x1700680E RID: 26638
		// (get) Token: 0x0600CF01 RID: 52993 RVA: 0x00C08F40 File Offset: 0x00C07140
		public bool CnvAlsLstStatusAliasListStatusAliasText_A9192_HasDiffs
		{
			get
			{
				short num = (short)716764473;
				short num2 = num;
				num = (short)1807611193;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1259732992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)376832001;
				if (num != 0)
				{
				}
				num = (short)433586176;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasText_A9192._HasDiffs;
			}
		}

		// Token: 0x1700680F RID: 26639
		// (get) Token: 0x0600CF02 RID: 52994 RVA: 0x00C08FF0 File Offset: 0x00C071F0
		// (set) Token: 0x0600CF03 RID: 52995 RVA: 0x00C090A8 File Offset: 0x00C072A8
		public int CnvAlsLstStatusAliasListStatusAliasNumber_A9191Value
		{
			get
			{
				short num = (short)1068977090;
				short num2 = num;
				num = (short)1366903746;
				switch (num2 == num)
				{
				default:
				{
					num = (short)904069120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1298333696;
				if (num != 0)
				{
				}
				num = (short)126156801;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.Value;
			}
			set
			{
				short num = (short)395457241;
				short num2 = num;
				num = (short)332477145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1758396416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)384237568;
				if (num != 0)
				{
				}
				num = (short)566493185;
				if (num != 0)
				{
				}
				this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.Value = value;
			}
		}

		// Token: 0x17006810 RID: 26640
		// (get) Token: 0x0600CF04 RID: 52996 RVA: 0x00C09160 File Offset: 0x00C07360
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvAlsLstStatusAliasListStatusAliasNumber_A9191
		{
			get
			{
				short num = (short)118226945;
				if (num != 0)
				{
				}
				num = (short)260702208;
				short num2 = num;
				num = (short)230840893;
				short num3 = num;
				num = (short)1820678717;
				switch (num3 == num)
				{
				}
				num = (short)180682752;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191;
			}
		}

		// Token: 0x17006811 RID: 26641
		// (get) Token: 0x0600CF05 RID: 52997 RVA: 0x00C09210 File Offset: 0x00C07410
		// (set) Token: 0x0600CF06 RID: 52998 RVA: 0x00C092C4 File Offset: 0x00C074C4
		public string CnvAlsLstStatusAliasListStatusAliasNumber_A9191_UIValue
		{
			get
			{
				short num = (short)1130491308;
				short num2 = num;
				num = (short)1813769644;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2031419392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)511901696;
				if (num != 0)
				{
				}
				num = (short)383188993;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.UIValue;
			}
			set
			{
				short num = (short)395191466;
				short num2 = num;
				num = (short)1601184938;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1484521472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1740832769;
				if (num != 0)
				{
				}
				num = (short)1972109312;
				if (num != 0)
				{
				}
				this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.UIValue = value;
			}
		}

		// Token: 0x17006812 RID: 26642
		// (get) Token: 0x0600CF07 RID: 52999 RVA: 0x00C09378 File Offset: 0x00C07578
		// (set) Token: 0x0600CF08 RID: 53000 RVA: 0x00C09430 File Offset: 0x00C07630
		internal int CnvAlsLstStatusAliasListStatusAliasNumber_A9191Min
		{
			get
			{
				short num = (short)1976992855;
				short num2 = num;
				num = (short)794592343;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1984561152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)870776832;
				if (num != 0)
				{
				}
				num = (short)863371265;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.Min;
			}
			set
			{
				short num = (short)400767652;
				short num2 = num;
				num = (short)1748777636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)294125568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)453771264;
				if (num != 0)
				{
				}
				num = (short)1884815361;
				if (num != 0)
				{
				}
				this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.Min = value;
			}
		}

		// Token: 0x17006813 RID: 26643
		// (get) Token: 0x0600CF09 RID: 53001 RVA: 0x00C094E4 File Offset: 0x00C076E4
		// (set) Token: 0x0600CF0A RID: 53002 RVA: 0x00C09598 File Offset: 0x00C07798
		internal int CnvAlsLstStatusAliasListStatusAliasNumber_A9191Max
		{
			get
			{
				short num = (short)232959114;
				short num2 = num;
				num = (short)1173990538;
				switch (num2 == num)
				{
				default:
				{
					num = (short)408420352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1670578177;
				if (num != 0)
				{
				}
				num = (short)239861760;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.Max;
			}
			set
			{
				short num = (short)1809010076;
				short num2 = num;
				num = (short)513691036;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2105868288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1000734721;
				if (num != 0)
				{
				}
				num = (short)751894528;
				if (num != 0)
				{
				}
				this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.Max = value;
			}
		}

		// Token: 0x17006814 RID: 26644
		// (get) Token: 0x0600CF0B RID: 53003 RVA: 0x00C0964C File Offset: 0x00C0784C
		// (set) Token: 0x0600CF0C RID: 53004 RVA: 0x00C09700 File Offset: 0x00C07900
		internal int CnvAlsLstStatusAliasListStatusAliasNumber_A9191Step
		{
			get
			{
				short num = (short)1469230358;
				short num2 = num;
				num = (short)2074586390;
				switch (num2 == num)
				{
				default:
				{
					num = (short)53411840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1522335745;
				if (num != 0)
				{
				}
				num = (short)1598881792;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.StepSize;
			}
			set
			{
				short num = (short)1844141136;
				short num2 = num;
				num = (short)864377936;
				switch (num2 == num)
				{
				default:
				{
					num = (short)674758656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1187971072;
				if (num != 0)
				{
				}
				num = (short)1745616897;
				if (num != 0)
				{
				}
				this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.StepSize = value;
			}
		}

		// Token: 0x17006815 RID: 26645
		// (get) Token: 0x0600CF0D RID: 53005 RVA: 0x00C097B8 File Offset: 0x00C079B8
		// (set) Token: 0x0600CF0E RID: 53006 RVA: 0x00C0986C File Offset: 0x00C07A6C
		public bool CnvAlsLstStatusAliasListStatusAliasNumber_A9191_Applicable
		{
			get
			{
				short num = (short)1729067283;
				short num2 = num;
				num = (short)561608979;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1309802496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)204931073;
				if (num != 0)
				{
				}
				num = (short)9699328;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.Applicable;
			}
			set
			{
				short num = (short)748752926;
				short num2 = num;
				num = (short)1104351262;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1913126912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1923284992;
				if (num != 0)
				{
				}
				num = (short)842924033;
				if (num != 0)
				{
				}
				this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.Applicable = value;
			}
		}

		// Token: 0x17006816 RID: 26646
		// (get) Token: 0x0600CF0F RID: 53007 RVA: 0x00C09924 File Offset: 0x00C07B24
		// (set) Token: 0x0600CF10 RID: 53008 RVA: 0x00C099D8 File Offset: 0x00C07BD8
		public bool CnvAlsLstStatusAliasListStatusAliasNumber_A9191_Valid
		{
			get
			{
				short num = (short)1984359239;
				short num2 = num;
				num = (short)721480519;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1570504704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1304821760;
				if (num != 0)
				{
				}
				num = (short)1593442305;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.Valid;
			}
			set
			{
				short num = (short)1931935745;
				if (num != 0)
				{
				}
				num = (short)1613496320;
				short num2 = num;
				num = (short)459526345;
				short num3 = num;
				num = (short)194105545;
				switch (num3 == num)
				{
				}
				num = (short)1125974016;
				if (num != 0)
				{
				}
				this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.Valid = value;
			}
		}

		// Token: 0x17006817 RID: 26647
		// (get) Token: 0x0600CF11 RID: 53009 RVA: 0x00C09A8C File Offset: 0x00C07C8C
		// (set) Token: 0x0600CF12 RID: 53010 RVA: 0x00C09B40 File Offset: 0x00C07D40
		public bool CnvAlsLstStatusAliasListStatusAliasNumber_A9191_Visible
		{
			get
			{
				short num = (short)1896901801;
				short num2 = num;
				num = (short)1617521833;
				switch (num2 == num)
				{
				default:
				{
					num = (short)474087424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1999896577;
				if (num != 0)
				{
				}
				num = (short)293732352;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.Visible;
			}
			set
			{
				short num = (short)78369550;
				short num2 = num;
				num = (short)307680014;
				switch (num2 == num)
				{
				default:
				{
					num = (short)888602624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1077084161;
				if (num != 0)
				{
				}
				num = (short)1690238976;
				if (num != 0)
				{
				}
				this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.Visible = value;
			}
		}

		// Token: 0x17006818 RID: 26648
		// (get) Token: 0x0600CF13 RID: 53011 RVA: 0x00C09BF4 File Offset: 0x00C07DF4
		// (set) Token: 0x0600CF14 RID: 53012 RVA: 0x00C09CAC File Offset: 0x00C07EAC
		public bool CnvAlsLstStatusAliasListStatusAliasNumber_A9191_Editable
		{
			get
			{
				short num = (short)1498243257;
				short num2 = num;
				num = (short)1009475769;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1154416640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1636368384;
				if (num != 0)
				{
				}
				num = (short)1317732353;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.Editable;
			}
			set
			{
				short num = (short)214574467;
				short num2 = num;
				num = (short)462300547;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1197080576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1635450881;
				if (num != 0)
				{
				}
				num = (short)361693184;
				if (num != 0)
				{
				}
				this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.Editable = value;
			}
		}

		// Token: 0x17006819 RID: 26649
		// (get) Token: 0x0600CF15 RID: 53013 RVA: 0x00C09D60 File Offset: 0x00C07F60
		internal string CnvAlsLstStatusAliasListStatusAliasNumber_A9191_UILabel
		{
			get
			{
				short num = (short)997061878;
				short num2 = num;
				num = (short)664532214;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1418985472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1286995969;
				if (num != 0)
				{
				}
				num = (short)1420951552;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.UIName;
			}
		}

		// Token: 0x1700681A RID: 26650
		// (get) Token: 0x0600CF16 RID: 53014 RVA: 0x00C09E14 File Offset: 0x00C08014
		// (set) Token: 0x0600CF17 RID: 53015 RVA: 0x00C09ECC File Offset: 0x00C080CC
		internal bool CnvAlsLstStatusAliasListStatusAliasNumber_A9191_HiddenStatic
		{
			get
			{
				short num = (short)300795813;
				short num2 = num;
				num = (short)1472448421;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1027932160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)587268097;
				if (num != 0)
				{
				}
				num = (short)1123876864;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.HiddenStatic;
			}
			set
			{
				short num = (short)1241748083;
				short num2 = num;
				num = (short)1558155891;
				switch (num2 == num)
				{
				default:
				{
					num = (short)739442688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)705822721;
				if (num != 0)
				{
				}
				num = (short)1679687680;
				if (num != 0)
				{
				}
				this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.HiddenStatic = value;
			}
		}

		// Token: 0x1700681B RID: 26651
		// (get) Token: 0x0600CF18 RID: 53016 RVA: 0x00C09F80 File Offset: 0x00C08180
		// (set) Token: 0x0600CF19 RID: 53017 RVA: 0x00C0A034 File Offset: 0x00C08234
		internal bool CnvAlsLstStatusAliasListStatusAliasNumber_A9191_HiddenDynamic
		{
			get
			{
				short num = (short)2131879901;
				short num2 = num;
				num = (short)2134042589;
				switch (num2 == num)
				{
				default:
				{
					num = (short)880082944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1895301121;
				if (num != 0)
				{
				}
				num = (short)1561591808;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.HiddenDynamic;
			}
			set
			{
				short num = (short)315686913;
				if (num != 0)
				{
				}
				num = (short)273416192;
				short num2 = num;
				num = (short)992029039;
				short num3 = num;
				num = (short)417409391;
				switch (num3 == num)
				{
				}
				num = (short)571080704;
				if (num != 0)
				{
				}
				this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191.HiddenDynamic = value;
			}
		}

		// Token: 0x1700681C RID: 26652
		// (get) Token: 0x0600CF1A RID: 53018 RVA: 0x00C0A0E8 File Offset: 0x00C082E8
		public bool CnvAlsLstStatusAliasListStatusAliasNumber_A9191_HasDiffs
		{
			get
			{
				short num = (short)348702706;
				short num2 = num;
				num = (short)1451083762;
				switch (num2 == num)
				{
				default:
				{
					num = (short)597491712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)758054912;
				if (num != 0)
				{
				}
				num = (short)932184065;
				if (num != 0)
				{
				}
				return this.cnvAlsLstStatusAliasListStatusAliasNumber_A9191._HasDiffs;
			}
		}

		// Token: 0x0600CF1B RID: 53019 RVA: 0x00C0A1A0 File Offset: 0x00C083A0
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
					num2 = (short)895418370;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)974585857;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)949094296;
					short num3 = num2;
					num2 = (short)1211500440;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)642973696;
						if (num2 != 0)
						{
						}
						num2 = (short)2116222979;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1419182081;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					goto IL_D3;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)1139015680;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			IL_D3:
			num2 = (short)769589248;
			short num4 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)455278596;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04006548 RID: 25928
		private global::AcpBusinessLayer.AcpKeyField cnvAlsLstStatusAliasListStatusAliasText_A9192;

		// Token: 0x04006549 RID: 25929
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvAlsLstStatusAliasListStatusAliasNumber_A9191;
	}
}
