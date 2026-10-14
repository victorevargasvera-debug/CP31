using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x02000544 RID: 1348
	[global::System.Serializable]
	public class ASTROOTAC : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B4E7 RID: 46311 RVA: 0x00A78B28 File Offset: 0x00A76D28
		public ASTROOTAC(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600B4E8 RID: 46312 RVA: 0x00A78B68 File Offset: 0x00A76D68
		protected ASTROOTAC(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B4E9 RID: 46313 RVA: 0x00A78B80 File Offset: 0x00A76D80
		public override void Init()
		{
			int a_ = 3;
			short num = (short)1062581874;
			short num2 = num;
			num = (short)360887922;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1874853888;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)501612545;
			if (num != 0)
			{
			}
			num = (short)476905472;
			if (num != 0)
			{
			}
			this.cnvWideASTROOTACOTACRFeature_A8662 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟃ꣅ뻇鷉ꗋ꫍뗏鏑蟓苕諗闙鏛諝ꇟꇡꯣ닥ꧧꧩ뻫꣭闯鏱胳菵諷鿹ꏻ뿽㣿㐁㈃㐅", a_), global::CommonResources.AcgResources.ID_OTACRFEATURE);
			this.cnvWideASTROOTACOTACRFeature_A8662.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvWideASTROOTACOTACRFeature_A8662.DataTransferOrder = 7;
			this.cnvWideASTROOTACOTACSFeature_A8667 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟃ꣅ뻇鷉ꗋ꫍뗏鏑蟓苕諗闙鏛諝ꇟꇡꯣ닥ꧧꧩ뿫꣭闯鏱胳菵諷鿹ꏻ뿽㣿㐁㈃ㄅ", a_), global::CommonResources.AcgResources.ID_OTACSFEATURE);
			this.cnvWideASTROOTACOTACSFeature_A8667.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvWideASTROOTACOTACSFeature_A8667.DataTransferOrder = 8;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藃闅鳇飉菋鿏蛑闓闕", a_);
			base.Id = 10055;
			base.UIName = global::CommonResources.AcgResources.ID_ASTROOTAC;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600B4EA RID: 46314 RVA: 0x00A78CD4 File Offset: 0x00A76ED4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)61931527;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1F4;
				case 1:
					goto IL_132;
				case 2:
					goto IL_7A;
				case 3:
				{
					num = (short)945881088;
					short num3 = num;
					this.cnvWideASTROOTACOTACSFeature_A8667 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆黈ꋊ꧌꫎郐胒臔藖雘铚觜點ꋠ곢뇤ꛦꫨ룪꯬諮郰蟲胴藶鳸ꓺ볼쟾㜀㔂㈄", a_), global::CommonResources.AcgResources.ID_OTACSFEATURE);
					this.cnvWideASTROOTACOTACSFeature_A8667.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvWideASTROOTACOTACSFeature_A8667.DataTransferOrder = 8;
					num = (short)1169489921;
					if (num != 0)
					{
					}
					num = (short)1466564608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					num = (short)36781157;
					short num4 = num;
					num = (short)1819688037;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_132;
					default:
						num = (short)1898053632;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆黈ꋊ꧌꫎郐胒臔藖雘铚觜點ꋠ곢뇤ꛦꫨ맪꯬諮郰蟲胴藶鳸ꓺ볼쟾㜀㔂㜄", a_)))
						{
							num = (short)327688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A;
					}
					break;
				}
				case 5:
					num = (short)574291969;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆黈ꋊ꧌꫎郐胒臔藖雘铚觜點ꋠ곢뇤ꛦꫨ룪꯬諮郰蟲胴藶鳸ꓺ볼쟾㜀㔂㈄", a_)))
					{
						num = (short)55836675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28F;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 8:
					this.cnvWideASTROOTACOTACRFeature_A8662 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆黈ꋊ꧌꫎郐胒臔藖雘铚觜點ꋠ곢뇤ꛦꫨ맪꯬諮郰蟲胴藶鳸ꓺ볼쟾㜀㔂㜄", a_), global::CommonResources.AcgResources.ID_OTACRFEATURE);
					this.cnvWideASTROOTACOTACRFeature_A8662.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvWideASTROOTACOTACRFeature_A8662.DataTransferOrder = 7;
					num = (short)390922242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1950547972;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)2084438021;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_7A:
				num = (short)1422196742;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_132:
				if (producerFields == null)
				{
					break;
				}
				num = (short)1775042569;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1F4:
			IL_28F:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苂雄鏆鯈蓊胎藐鋒雔", a_);
			base.Id = 10055;
			base.UIName = global::CommonResources.AcgResources.ID_ASTROOTAC;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600B4EB RID: 46315 RVA: 0x00A78FA4 File Offset: 0x00A771A4
		public override void PopulateReferences()
		{
			short num = (short)181587116;
			short num2 = num;
			num = (short)586337452;
			switch (num2 == num)
			{
			}
			num = (short)1455423488;
			short num3 = num;
			num = (short)1640431617;
			if (num != 0)
			{
			}
			num = (short)1377173504;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B4EC RID: 46316 RVA: 0x00A79050 File Offset: 0x00A77250
		public override void DropReferences()
		{
			short num = (short)1061142381;
			short num2 = num;
			num = (short)117358445;
			switch (num2 == num)
			{
			}
			num = (short)767754240;
			short num3 = num;
			num = (short)750845953;
			if (num != 0)
			{
			}
			num = (short)974585856;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B4ED RID: 46317 RVA: 0x00A790F8 File Offset: 0x00A772F8
		public override void SetConstraints()
		{
			short num = (short)1179516929;
			if (num != 0)
			{
			}
			num = (short)959609724;
			short num2 = num;
			num = (short)2054912892;
			switch (num2 == num)
			{
			default:
			{
				num = (short)260374528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1458176000;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B4EE RID: 46318 RVA: 0x00A791A4 File Offset: 0x00A773A4
		public override void SetupDependencies()
		{
			short num = (short)1533074309;
			short num2 = num;
			num = (short)2068110213;
			switch (num2 == num)
			{
			}
			num = (short)491782144;
			short num3 = num;
			num = (short)2033451009;
			if (num != 0)
			{
			}
			num = (short)1215365120;
			if (num != 0)
			{
			}
		}

		// Token: 0x17005AB8 RID: 23224
		// (get) Token: 0x0600B4EF RID: 46319 RVA: 0x00A79250 File Offset: 0x00A77450
		public bool HasDiffs
		{
			get
			{
				short num = (short)883810388;
				short num2 = num;
				num = (short)2019483732;
				switch (num2 == num)
				{
				}
				num = (short)331022336;
				short num3 = num;
				num = (short)3014657;
				if (num != 0)
				{
				}
				num = (short)171376640;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17005AB9 RID: 23225
		// (get) Token: 0x0600B4F0 RID: 46320 RVA: 0x00A79304 File Offset: 0x00A77504
		// (set) Token: 0x0600B4F1 RID: 46321 RVA: 0x00A793B8 File Offset: 0x00A775B8
		public bool CnvWideASTROOTACOTACRFeature_A8662Value
		{
			get
			{
				short num = (short)1003227435;
				short num2 = num;
				num = (short)292686123;
				switch (num2 == num)
				{
				}
				num = (short)686751744;
				short num3 = num;
				num = (short)556990464;
				if (num != 0)
				{
				}
				num = (short)1464860673;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACRFeature_A8662.Value;
			}
			set
			{
				short num = (short)1548877825;
				if (num != 0)
				{
				}
				num = (short)94158152;
				short num2 = num;
				num = (short)138591560;
				switch (num2 == num)
				{
				default:
				{
					num = (short)607059968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1185218560;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACOTACRFeature_A8662.Value = value;
			}
		}

		// Token: 0x17005ABA RID: 23226
		// (get) Token: 0x0600B4F2 RID: 46322 RVA: 0x00A7946C File Offset: 0x00A7766C
		public global::AcpBusinessLayer.AcpField<bool> CnvWideASTROOTACOTACRFeature_A8662
		{
			get
			{
				short num = (short)473319145;
				short num2 = num;
				num = (short)1899054825;
				switch (num2 == num)
				{
				}
				num = (short)1256521728;
				short num3 = num;
				num = (short)1022033920;
				if (num != 0)
				{
				}
				num = (short)197918721;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACRFeature_A8662;
			}
		}

		// Token: 0x17005ABB RID: 23227
		// (get) Token: 0x0600B4F3 RID: 46323 RVA: 0x00A7951C File Offset: 0x00A7771C
		// (set) Token: 0x0600B4F4 RID: 46324 RVA: 0x00A795D0 File Offset: 0x00A777D0
		public bool CnvWideASTROOTACOTACRFeature_A8662_UIValue
		{
			get
			{
				short num = (short)1176566371;
				short num2 = num;
				num = (short)1258093155;
				switch (num2 == num)
				{
				}
				num = (short)1022689280;
				short num3 = num;
				num = (short)1297547264;
				if (num != 0)
				{
				}
				num = (short)507772929;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACRFeature_A8662.Value;
			}
			set
			{
				short num = (short)1111649340;
				short num2 = num;
				num = (short)993160252;
				switch (num2 == num)
				{
				}
				num = (short)494075904;
				short num3 = num;
				num = (short)121896961;
				if (num != 0)
				{
				}
				num = (short)326107136;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACOTACRFeature_A8662.Value = value;
			}
		}

		// Token: 0x17005ABC RID: 23228
		// (get) Token: 0x0600B4F5 RID: 46325 RVA: 0x00A79688 File Offset: 0x00A77888
		// (set) Token: 0x0600B4F6 RID: 46326 RVA: 0x00A79740 File Offset: 0x00A77940
		public bool CnvWideASTROOTACOTACRFeature_A8662_Applicable
		{
			get
			{
				short num = (short)701469398;
				short num2 = num;
				num = (short)873763542;
				switch (num2 == num)
				{
				}
				num = (short)881655808;
				short num3 = num;
				num = (short)1056833536;
				if (num != 0)
				{
				}
				num = (short)1448083457;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACRFeature_A8662.Applicable;
			}
			set
			{
				short num = (short)254083073;
				if (num != 0)
				{
				}
				num = (short)709727378;
				short num2 = num;
				num = (short)727291026;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1793327104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1975320576;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACOTACRFeature_A8662.Applicable = value;
			}
		}

		// Token: 0x17005ABD RID: 23229
		// (get) Token: 0x0600B4F7 RID: 46327 RVA: 0x00A797F4 File Offset: 0x00A779F4
		// (set) Token: 0x0600B4F8 RID: 46328 RVA: 0x00A798AC File Offset: 0x00A77AAC
		public bool CnvWideASTROOTACOTACRFeature_A8662_Valid
		{
			get
			{
				short num = (short)1351781676;
				short num2 = num;
				num = (short)2130742572;
				switch (num2 == num)
				{
				}
				num = (short)1193869312;
				short num3 = num;
				num = (short)146604033;
				if (num != 0)
				{
				}
				num = (short)1786576896;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACRFeature_A8662.Valid;
			}
			set
			{
				short num = (short)536543233;
				if (num != 0)
				{
				}
				num = (short)1728332483;
				short num2 = num;
				num = (short)1270170307;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1637482496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1982595072;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACOTACRFeature_A8662.Valid = value;
			}
		}

		// Token: 0x17005ABE RID: 23230
		// (get) Token: 0x0600B4F9 RID: 46329 RVA: 0x00A79964 File Offset: 0x00A77B64
		// (set) Token: 0x0600B4FA RID: 46330 RVA: 0x00A79A18 File Offset: 0x00A77C18
		public bool CnvWideASTROOTACOTACRFeature_A8662_Visible
		{
			get
			{
				short num = (short)1216102684;
				short num2 = num;
				num = (short)1183858972;
				switch (num2 == num)
				{
				}
				num = (short)1052639232;
				short num3 = num;
				num = (short)986054657;
				if (num != 0)
				{
				}
				num = (short)1040973824;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACRFeature_A8662.Visible;
			}
			set
			{
				short num = (short)125076442;
				short num2 = num;
				num = (short)628786138;
				switch (num2 == num)
				{
				}
				num = (short)989790208;
				short num3 = num;
				num = (short)1937113088;
				if (num != 0)
				{
				}
				num = (short)1943273473;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACOTACRFeature_A8662.Visible = value;
			}
		}

		// Token: 0x17005ABF RID: 23231
		// (get) Token: 0x0600B4FB RID: 46331 RVA: 0x00A79AD0 File Offset: 0x00A77CD0
		// (set) Token: 0x0600B4FC RID: 46332 RVA: 0x00A79B84 File Offset: 0x00A77D84
		public bool CnvWideASTROOTACOTACRFeature_A8662_Editable
		{
			get
			{
				short num = (short)2005421823;
				short num2 = num;
				num = (short)1897484031;
				switch (num2 == num)
				{
				}
				num = (short)779091968;
				short num3 = num;
				num = (short)803274753;
				if (num != 0)
				{
				}
				num = (short)619315200;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACRFeature_A8662.Editable;
			}
			set
			{
				short num = (short)1911619585;
				if (num != 0)
				{
				}
				num = (short)234955873;
				short num2 = num;
				num = (short)897000545;
				switch (num2 == num)
				{
				default:
				{
					num = (short)214958080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2146893824;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACOTACRFeature_A8662.Editable = value;
			}
		}

		// Token: 0x17005AC0 RID: 23232
		// (get) Token: 0x0600B4FD RID: 46333 RVA: 0x00A79C3C File Offset: 0x00A77E3C
		internal string CnvWideASTROOTACOTACRFeature_A8662_UILabel
		{
			get
			{
				short num = (short)623899687;
				short num2 = num;
				num = (short)25490471;
				switch (num2 == num)
				{
				}
				num = (short)1008336896;
				short num3 = num;
				num = (short)1734279169;
				if (num != 0)
				{
				}
				num = (short)2105278464;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACRFeature_A8662.UIName;
			}
		}

		// Token: 0x17005AC1 RID: 23233
		// (get) Token: 0x0600B4FE RID: 46334 RVA: 0x00A79CF0 File Offset: 0x00A77EF0
		// (set) Token: 0x0600B4FF RID: 46335 RVA: 0x00A79DA4 File Offset: 0x00A77FA4
		internal bool CnvWideASTROOTACOTACRFeature_A8662_HiddenStatic
		{
			get
			{
				short num = (short)588238787;
				short num2 = num;
				num = (short)1962921923;
				switch (num2 == num)
				{
				}
				num = (short)257228800;
				short num3 = num;
				num = (short)385417216;
				if (num != 0)
				{
				}
				num = (short)482279425;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACRFeature_A8662.HiddenStatic;
			}
			set
			{
				short num = (short)38638138;
				short num2 = num;
				num = (short)1392808506;
				switch (num2 == num)
				{
				}
				num = (short)346750976;
				short num3 = num;
				num = (short)802684929;
				if (num != 0)
				{
				}
				num = (short)412680192;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACOTACRFeature_A8662.HiddenStatic = value;
			}
		}

		// Token: 0x17005AC2 RID: 23234
		// (get) Token: 0x0600B500 RID: 46336 RVA: 0x00A79E58 File Offset: 0x00A78058
		// (set) Token: 0x0600B501 RID: 46337 RVA: 0x00A79F10 File Offset: 0x00A78110
		internal bool CnvWideASTROOTACOTACRFeature_A8662_HiddenDynamic
		{
			get
			{
				short num = (short)1697120257;
				if (num != 0)
				{
				}
				num = (short)13581448;
				short num2 = num;
				num = (short)70990984;
				switch (num2 == num)
				{
				default:
				{
					num = (short)896860160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)602275840;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACRFeature_A8662.HiddenDynamic;
			}
			set
			{
				short num = (short)1904934913;
				if (num != 0)
				{
				}
				num = (short)613347354;
				short num2 = num;
				num = (short)1755377690;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1313341440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)295567360;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACOTACRFeature_A8662.HiddenDynamic = value;
			}
		}

		// Token: 0x17005AC3 RID: 23235
		// (get) Token: 0x0600B502 RID: 46338 RVA: 0x00A79FC8 File Offset: 0x00A781C8
		public bool CnvWideASTROOTACOTACRFeature_A8662_HasDiffs
		{
			get
			{
				short num = (short)1867120641;
				if (num != 0)
				{
				}
				num = (short)1378440192;
				short num2 = num;
				num = (short)161240064;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2089615360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)800456704;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACRFeature_A8662._HasDiffs;
			}
		}

		// Token: 0x17005AC4 RID: 23236
		// (get) Token: 0x0600B503 RID: 46339 RVA: 0x00A7A078 File Offset: 0x00A78278
		// (set) Token: 0x0600B504 RID: 46340 RVA: 0x00A7A12C File Offset: 0x00A7832C
		public bool CnvWideASTROOTACOTACSFeature_A8667Value
		{
			get
			{
				short num = (short)1142662350;
				short num2 = num;
				num = (short)823305422;
				switch (num2 == num)
				{
				}
				num = (short)698351616;
				short num3 = num;
				num = (short)687144961;
				if (num != 0)
				{
				}
				num = (short)705232896;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACSFeature_A8667.Value;
			}
			set
			{
				short num = (short)916439041;
				short num2 = num;
				num = (short)358793217;
				switch (num2 == num)
				{
				}
				num = (short)842006528;
				short num3 = num;
				num = (short)588578817;
				if (num != 0)
				{
				}
				num = (short)311558144;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACOTACSFeature_A8667.Value = value;
			}
		}

		// Token: 0x17005AC5 RID: 23237
		// (get) Token: 0x0600B505 RID: 46341 RVA: 0x00A7A1E4 File Offset: 0x00A783E4
		public global::AcpBusinessLayer.AcpField<bool> CnvWideASTROOTACOTACSFeature_A8667
		{
			get
			{
				short num = (short)629145601;
				if (num != 0)
				{
				}
				num = (short)1143753961;
				short num2 = num;
				num = (short)451693801;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1906245632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1785069568;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACSFeature_A8667;
			}
		}

		// Token: 0x17005AC6 RID: 23238
		// (get) Token: 0x0600B506 RID: 46342 RVA: 0x00A7A294 File Offset: 0x00A78494
		// (set) Token: 0x0600B507 RID: 46343 RVA: 0x00A7A348 File Offset: 0x00A78548
		public bool CnvWideASTROOTACOTACSFeature_A8667_UIValue
		{
			get
			{
				short num = (short)1874678576;
				short num2 = num;
				num = (short)1122390832;
				switch (num2 == num)
				{
				}
				num = (short)131465216;
				short num3 = num;
				num = (short)77725697;
				if (num != 0)
				{
				}
				num = (short)1542193152;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACSFeature_A8667.Value;
			}
			set
			{
				short num = (short)157677642;
				short num2 = num;
				num = (short)1233909834;
				switch (num2 == num)
				{
				}
				num = (short)2123169792;
				short num3 = num;
				num = (short)762183681;
				if (num != 0)
				{
				}
				num = (short)2121990144;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACOTACSFeature_A8667.Value = value;
			}
		}

		// Token: 0x17005AC7 RID: 23239
		// (get) Token: 0x0600B508 RID: 46344 RVA: 0x00A7A400 File Offset: 0x00A78600
		// (set) Token: 0x0600B509 RID: 46345 RVA: 0x00A7A4B8 File Offset: 0x00A786B8
		public bool CnvWideASTROOTACOTACSFeature_A8667_Applicable
		{
			get
			{
				short num = (short)1571513055;
				short num2 = num;
				num = (short)1024942815;
				switch (num2 == num)
				{
				}
				num = (short)1469906944;
				short num3 = num;
				num = (short)1995571201;
				if (num != 0)
				{
				}
				num = (short)1529151488;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACSFeature_A8667.Applicable;
			}
			set
			{
				short num = (short)557856939;
				short num2 = num;
				num = (short)718223531;
				switch (num2 == num)
				{
				}
				num = (short)372506624;
				short num3 = num;
				num = (short)143851520;
				if (num != 0)
				{
				}
				num = (short)1421148161;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACOTACSFeature_A8667.Applicable = value;
			}
		}

		// Token: 0x17005AC8 RID: 23240
		// (get) Token: 0x0600B50A RID: 46346 RVA: 0x00A7A56C File Offset: 0x00A7876C
		// (set) Token: 0x0600B50B RID: 46347 RVA: 0x00A7A620 File Offset: 0x00A78820
		public bool CnvWideASTROOTACOTACSFeature_A8667_Valid
		{
			get
			{
				short num = (short)2064572750;
				short num2 = num;
				num = (short)673702222;
				switch (num2 == num)
				{
				}
				num = (short)451346432;
				short num3 = num;
				num = (short)1612972033;
				if (num != 0)
				{
				}
				num = (short)1530265600;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACSFeature_A8667.Valid;
			}
			set
			{
				short num = (short)1261545638;
				short num2 = num;
				num = (short)832546982;
				switch (num2 == num)
				{
				}
				num = (short)1242759168;
				short num3 = num;
				num = (short)1206976512;
				if (num != 0)
				{
				}
				num = (short)1965424641;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACOTACSFeature_A8667.Valid = value;
			}
		}

		// Token: 0x17005AC9 RID: 23241
		// (get) Token: 0x0600B50C RID: 46348 RVA: 0x00A7A6D4 File Offset: 0x00A788D4
		// (set) Token: 0x0600B50D RID: 46349 RVA: 0x00A7A788 File Offset: 0x00A78988
		public bool CnvWideASTROOTACOTACSFeature_A8667_Visible
		{
			get
			{
				short num = (short)1206306630;
				short num2 = num;
				num = (short)1008191302;
				switch (num2 == num)
				{
				}
				num = (short)1068498944;
				short num3 = num;
				num = (short)237961217;
				if (num != 0)
				{
				}
				num = (short)2078015488;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACSFeature_A8667.Visible;
			}
			set
			{
				short num = (short)483640590;
				short num2 = num;
				num = (short)671859982;
				switch (num2 == num)
				{
				}
				num = (short)1943011328;
				short num3 = num;
				num = (short)1449525249;
				if (num != 0)
				{
				}
				num = (short)1878786048;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACOTACSFeature_A8667.Visible = value;
			}
		}

		// Token: 0x17005ACA RID: 23242
		// (get) Token: 0x0600B50E RID: 46350 RVA: 0x00A7A83C File Offset: 0x00A78A3C
		// (set) Token: 0x0600B50F RID: 46351 RVA: 0x00A7A8F4 File Offset: 0x00A78AF4
		public bool CnvWideASTROOTACOTACSFeature_A8667_Editable
		{
			get
			{
				short num = (short)155800074;
				short num2 = num;
				num = (short)1645826570;
				switch (num2 == num)
				{
				}
				num = (short)259784704;
				short num3 = num;
				num = (short)416546816;
				if (num != 0)
				{
				}
				num = (short)1510998017;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACSFeature_A8667.Editable;
			}
			set
			{
				short num = (short)864063610;
				short num2 = num;
				num = (short)915443834;
				switch (num2 == num)
				{
				}
				num = (short)542048256;
				short num3 = num;
				num = (short)738656256;
				if (num != 0)
				{
				}
				num = (short)1522597889;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACOTACSFeature_A8667.Editable = value;
			}
		}

		// Token: 0x17005ACB RID: 23243
		// (get) Token: 0x0600B510 RID: 46352 RVA: 0x00A7A9A8 File Offset: 0x00A78BA8
		internal string CnvWideASTROOTACOTACSFeature_A8667_UILabel
		{
			get
			{
				short num = (short)1609553859;
				short num2 = num;
				num = (short)739235779;
				switch (num2 == num)
				{
				}
				num = (short)1710227456;
				short num3 = num;
				num = (short)585826304;
				if (num != 0)
				{
				}
				num = (short)1555431425;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACSFeature_A8667.UIName;
			}
		}

		// Token: 0x17005ACC RID: 23244
		// (get) Token: 0x0600B511 RID: 46353 RVA: 0x00A7AA5C File Offset: 0x00A78C5C
		// (set) Token: 0x0600B512 RID: 46354 RVA: 0x00A7AB10 File Offset: 0x00A78D10
		internal bool CnvWideASTROOTACOTACSFeature_A8667_HiddenStatic
		{
			get
			{
				short num = (short)1237909146;
				short num2 = num;
				num = (short)1378090650;
				switch (num2 == num)
				{
				}
				num = (short)346161152;
				short num3 = num;
				num = (short)265093121;
				if (num != 0)
				{
				}
				num = (short)1964572672;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACSFeature_A8667.HiddenStatic;
			}
			set
			{
				short num = (short)74692508;
				short num2 = num;
				num = (short)439990172;
				switch (num2 == num)
				{
				}
				num = (short)1879441408;
				short num3 = num;
				num = (short)2088566785;
				if (num != 0)
				{
				}
				num = (short)707461120;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACOTACSFeature_A8667.HiddenStatic = value;
			}
		}

		// Token: 0x17005ACD RID: 23245
		// (get) Token: 0x0600B513 RID: 46355 RVA: 0x00A7ABC4 File Offset: 0x00A78DC4
		// (set) Token: 0x0600B514 RID: 46356 RVA: 0x00A7AC78 File Offset: 0x00A78E78
		internal bool CnvWideASTROOTACOTACSFeature_A8667_HiddenDynamic
		{
			get
			{
				short num = (short)1847675001;
				short num2 = num;
				num = (short)1236093049;
				switch (num2 == num)
				{
				}
				num = (short)1776418816;
				short num3 = num;
				num = (short)1586561024;
				if (num != 0)
				{
				}
				num = (short)375652353;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACSFeature_A8667.HiddenDynamic;
			}
			set
			{
				short num = (short)2121021622;
				short num2 = num;
				num = (short)859191478;
				switch (num2 == num)
				{
				}
				num = (short)1899233280;
				short num3 = num;
				num = (short)40566784;
				if (num != 0)
				{
				}
				num = (short)212992001;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACOTACSFeature_A8667.HiddenDynamic = value;
			}
		}

		// Token: 0x17005ACE RID: 23246
		// (get) Token: 0x0600B515 RID: 46357 RVA: 0x00A7AD30 File Offset: 0x00A78F30
		public bool CnvWideASTROOTACOTACSFeature_A8667_HasDiffs
		{
			get
			{
				short num = (short)1100288019;
				short num2 = num;
				num = (short)650186771;
				switch (num2 == num)
				{
				}
				num = (short)1826357248;
				short num3 = num;
				num = (short)2041511937;
				if (num != 0)
				{
				}
				num = (short)696057856;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACOTACSFeature_A8667._HasDiffs;
			}
		}

		// Token: 0x0600B516 RID: 46358 RVA: 0x00A7ADE4 File Offset: 0x00A78FE4
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
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)17432580;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
				{
					num2 = (short)1073283072;
					short num3 = num2;
					if (base.ParentRecset != null)
					{
						num2 = (short)1320681475;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 3:
					num2 = (short)1259339777;
					if (num2 != 0)
					{
					}
					num2 = (short)949223425;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)301930321;
					short num4 = num2;
					num2 = (short)1704925009;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)970850304;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)519176192;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1433600002;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040057BB RID: 22459
		private global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerRecset innerRecset;

		// Token: 0x040057BC RID: 22460
		private global::AcpBusinessLayer.AcpField<bool> cnvWideASTROOTACOTACRFeature_A8662;

		// Token: 0x040057BD RID: 22461
		private global::AcpBusinessLayer.AcpField<bool> cnvWideASTROOTACOTACSFeature_A8667;
	}
}
