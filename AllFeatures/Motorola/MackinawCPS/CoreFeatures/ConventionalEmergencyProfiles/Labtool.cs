using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles
{
	// Token: 0x020004A7 RID: 1191
	[global::System.Serializable]
	public class Labtool : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009D24 RID: 40228 RVA: 0x0092DCD8 File Offset: 0x0092BED8
		public Labtool(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06009D25 RID: 40229 RVA: 0x0092DCF4 File Offset: 0x0092BEF4
		protected Labtool(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009D26 RID: 40230 RVA: 0x0092DD0C File Offset: 0x0092BF0C
		public override void Init()
		{
			int a_ = 2;
			short num = (short)1250988295;
			short num2 = num;
			num = (short)1215467783;
			switch (num2 == num)
			{
			}
			num = (short)356319233;
			if (num != 0)
			{
			}
			num = (short)185204736;
			if (num != 0)
			{
			}
			num = (short)1258553344;
			short num3 = num;
			this.cnvEmergencyToneSelection_42053 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆賈ꛊ꣌뷎뛐뛒믔듖ꃘ迚닜뇞蓠냢胤详賨裪駬蛮黰鷲ꫴ쏶쯸쯺주쳾", a_), global::CommonResources.AcgResources.ID_CONVENTIONALEMERGENCYPROFILETONECONFIGURATIONLISTITEMNAMEID, new string[]
			{
				global::CommonResources.AcgResources.ID_DEFAULTTONECONFIGURATION
			}, new int[1], true, false);
			this.cnvEmergencyToneSelection_42053.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvEmergencyToneSelection_42053.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迂꓄ꗆ뷈꓊ꋌꏎ", a_);
			base.Id = 10777;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06009D27 RID: 40231 RVA: 0x0092DE40 File Offset: 0x0092C040
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)60424198;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1072103425;
					if (num != 0)
					{
					}
					num = (short)1451622402;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_147;
				case 2:
				{
					num = (short)944373760;
					short num3 = num;
					if (producerFields != null)
					{
						num = (short)1056768001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F6;
				}
				case 3:
					goto IL_142;
				case 4:
				{
					this.cnvEmergencyToneSelection_42053 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("賎뿐ꗒ郔뫖볘꧚뫜뫞迠胢鳤돦蛨藪裬볮铰鿲郴银跸鋺鋼釾帀㜂㜄㜆㰈㠊", a_), global::CommonResources.AcgResources.ID_CONVENTIONALEMERGENCYPROFILETONECONFIGURATIONLISTITEMNAMEID, new string[]
					{
						global::CommonResources.AcgResources.ID_DEFAULTTONECONFIGURATION
					}, new int[1], true, false);
					this.cnvEmergencyToneSelection_42053.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvEmergencyToneSelection_42053.DataTransferOrder = -1;
					num = (short)1699531390;
					short num4 = num;
					num = (short)486853246;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_147;
					default:
						num = (short)45285376;
						if (num != 0)
						{
						}
						num = (short)19267587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賎뿐ꗒ郔뫖볘꧚뫜뫞迠胢鳤돦蛨藪裬볮铰鿲郴银跸鋺鋼釾帀㜂㜄㜆㰈㠊", a_)))
					{
						num = (short)1394999300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F6;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				}
				IL_49:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)562888704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_147:
				num = (short)1504313349;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_142:
			IL_1F6:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菎냐뇒ꇔ룖뛘럚", a_);
			base.Id = 10777;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06009D28 RID: 40232 RVA: 0x0092E074 File Offset: 0x0092C274
		public override void PopulateReferences()
		{
			short num = (short)586611788;
			short num2 = num;
			num = (short)1938619468;
			switch (num2 == num)
			{
			}
			num = (short)1940062209;
			if (num != 0)
			{
			}
			num = (short)1240596480;
			if (num != 0)
			{
			}
			num = (short)358023168;
			short num3 = num;
		}

		// Token: 0x06009D29 RID: 40233 RVA: 0x0092E11C File Offset: 0x0092C31C
		public override void DropReferences()
		{
			short num = (short)98843369;
			short num2 = num;
			num = (short)847330025;
			switch (num2 == num)
			{
			}
			num = (short)1992359937;
			if (num != 0)
			{
			}
			num = (short)1428488192;
			if (num != 0)
			{
			}
			num = (short)1042808832;
			short num3 = num;
		}

		// Token: 0x06009D2A RID: 40234 RVA: 0x0092E1C4 File Offset: 0x0092C3C4
		public override void SetConstraints()
		{
			short num = (short)1108948875;
			short num2 = num;
			num = (short)175060875;
			switch (num2 == num)
			{
			}
			num = (short)1265303553;
			if (num != 0)
			{
			}
			num = (short)1252392960;
			if (num != 0)
			{
			}
			num = (short)303497216;
			short num3 = num;
		}

		// Token: 0x06009D2B RID: 40235 RVA: 0x0092E26C File Offset: 0x0092C46C
		public override void SetupDependencies()
		{
			short num = (short)1092282466;
			short num2 = num;
			num = (short)2075584610;
			switch (num2 == num)
			{
			}
			num = (short)1397882880;
			if (num != 0)
			{
			}
			num = (short)1301282817;
			if (num != 0)
			{
			}
			num = (short)164691968;
			short num3 = num;
		}

		// Token: 0x17004EF1 RID: 20209
		// (get) Token: 0x06009D2C RID: 40236 RVA: 0x0092E318 File Offset: 0x0092C518
		public bool HasDiffs
		{
			get
			{
				short num = (short)1713580439;
				short num2 = num;
				num = (short)2124163479;
				switch (num2 == num)
				{
				}
				num = (short)150339584;
				if (num != 0)
				{
				}
				num = (short)1637220353;
				if (num != 0)
				{
				}
				num = (short)1149763584;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17004EF2 RID: 20210
		// (get) Token: 0x06009D2D RID: 40237 RVA: 0x0092E3C8 File Offset: 0x0092C5C8
		// (set) Token: 0x06009D2E RID: 40238 RVA: 0x0092E480 File Offset: 0x0092C680
		public int CnvEmergencyToneSelection_42053Value
		{
			get
			{
				short num = (short)1815706522;
				short num2 = num;
				num = (short)116489114;
				switch (num2 == num)
				{
				}
				num = (short)2106589185;
				if (num != 0)
				{
				}
				num = (short)2005794816;
				if (num != 0)
				{
				}
				num = (short)74514432;
				short num3 = num;
				return this.cnvEmergencyToneSelection_42053.Value;
			}
			set
			{
				short num = (short)1390440839;
				short num2 = num;
				num = (short)1286238599;
				switch (num2 == num)
				{
				}
				num = (short)1409220608;
				if (num != 0)
				{
				}
				num = (short)1413414913;
				if (num != 0)
				{
				}
				num = (short)759431168;
				short num3 = num;
				this.cnvEmergencyToneSelection_42053.Value = value;
			}
		}

		// Token: 0x17004EF3 RID: 20211
		// (get) Token: 0x06009D2F RID: 40239 RVA: 0x0092E534 File Offset: 0x0092C734
		// (set) Token: 0x06009D30 RID: 40240 RVA: 0x0092E5E8 File Offset: 0x0092C7E8
		public string CnvEmergencyToneSelection_42053_UIValue
		{
			get
			{
				short num = (short)591007294;
				short num2 = num;
				num = (short)120196670;
				switch (num2 == num)
				{
				}
				num = (short)1361444865;
				if (num != 0)
				{
				}
				num = (short)1406009344;
				if (num != 0)
				{
				}
				num = (short)965148672;
				short num3 = num;
				return this.cnvEmergencyToneSelection_42053.UIValue;
			}
			set
			{
				short num = (short)69751297;
				short num2 = num;
				num = (short)127357441;
				switch (num2 == num)
				{
				}
				num = (short)1325006849;
				if (num != 0)
				{
				}
				num = (short)1074921472;
				if (num != 0)
				{
				}
				num = (short)42401792;
				short num3 = num;
				this.cnvEmergencyToneSelection_42053.UIValue = value;
			}
		}

		// Token: 0x17004EF4 RID: 20212
		// (get) Token: 0x06009D31 RID: 40241 RVA: 0x0092E69C File Offset: 0x0092C89C
		public global::AcpBusinessLayer.AcpRecRefField CnvEmergencyToneSelection_42053
		{
			get
			{
				short num = (short)1418592257;
				if (num != 0)
				{
				}
				num = (short)1741292186;
				short num2 = num;
				num = (short)765592218;
				switch (num2 == num)
				{
				}
				num = (short)1966735360;
				if (num != 0)
				{
				}
				num = (short)1226833920;
				short num3 = num;
				return this.cnvEmergencyToneSelection_42053;
			}
		}

		// Token: 0x17004EF5 RID: 20213
		// (get) Token: 0x06009D32 RID: 40242 RVA: 0x0092E74C File Offset: 0x0092C94C
		// (set) Token: 0x06009D33 RID: 40243 RVA: 0x0092E804 File Offset: 0x0092CA04
		public bool CnvEmergencyToneSelection_42053_Applicable
		{
			get
			{
				short num = (short)1559877539;
				short num2 = num;
				num = (short)1792202659;
				switch (num2 == num)
				{
				}
				num = (short)1006108673;
				if (num != 0)
				{
				}
				num = (short)623050752;
				if (num != 0)
				{
				}
				num = (short)1633550336;
				short num3 = num;
				return this.cnvEmergencyToneSelection_42053.Applicable;
			}
			set
			{
				short num = (short)1505351549;
				short num2 = num;
				num = (short)734386045;
				switch (num2 == num)
				{
				}
				num = (short)534839297;
				if (num != 0)
				{
				}
				num = (short)1270087680;
				if (num != 0)
				{
				}
				num = (short)2013003776;
				short num3 = num;
				this.cnvEmergencyToneSelection_42053.Applicable = value;
			}
		}

		// Token: 0x17004EF6 RID: 20214
		// (get) Token: 0x06009D34 RID: 40244 RVA: 0x0092E8B8 File Offset: 0x0092CAB8
		// (set) Token: 0x06009D35 RID: 40245 RVA: 0x0092E96C File Offset: 0x0092CB6C
		public bool CnvEmergencyToneSelection_42053_Valid
		{
			get
			{
				short num = (short)391511477;
				short num2 = num;
				num = (short)1167523253;
				switch (num2 == num)
				{
				}
				num = (short)965541889;
				if (num != 0)
				{
				}
				num = (short)101122048;
				if (num != 0)
				{
				}
				num = (short)1320550400;
				short num3 = num;
				return this.cnvEmergencyToneSelection_42053.Valid;
			}
			set
			{
				short num = (short)1061814273;
				if (num != 0)
				{
				}
				num = (short)123737691;
				short num2 = num;
				num = (short)1873155675;
				switch (num2 == num)
				{
				}
				num = (short)1391656960;
				if (num != 0)
				{
				}
				num = (short)988151808;
				short num3 = num;
				this.cnvEmergencyToneSelection_42053.Valid = value;
			}
		}

		// Token: 0x17004EF7 RID: 20215
		// (get) Token: 0x06009D36 RID: 40246 RVA: 0x0092EA24 File Offset: 0x0092CC24
		// (set) Token: 0x06009D37 RID: 40247 RVA: 0x0092EADC File Offset: 0x0092CCDC
		public bool CnvEmergencyToneSelection_42053_Visible
		{
			get
			{
				short num = (short)484179969;
				if (num != 0)
				{
				}
				num = (short)306851291;
				short num2 = num;
				num = (short)1625370075;
				switch (num2 == num)
				{
				}
				num = (short)958267392;
				if (num != 0)
				{
				}
				num = (short)2124611584;
				short num3 = num;
				return this.cnvEmergencyToneSelection_42053.Visible;
			}
			set
			{
				short num = (short)684500208;
				short num2 = num;
				num = (short)918725872;
				switch (num2 == num)
				{
				}
				num = (short)955187201;
				if (num != 0)
				{
				}
				num = (short)122224640;
				if (num != 0)
				{
				}
				num = (short)392757248;
				short num3 = num;
				this.cnvEmergencyToneSelection_42053.Visible = value;
			}
		}

		// Token: 0x17004EF8 RID: 20216
		// (get) Token: 0x06009D38 RID: 40248 RVA: 0x0092EB90 File Offset: 0x0092CD90
		// (set) Token: 0x06009D39 RID: 40249 RVA: 0x0092EC44 File Offset: 0x0092CE44
		public bool CnvEmergencyToneSelection_42053_Editable
		{
			get
			{
				short num = (short)721803249;
				short num2 = num;
				num = (short)1313658865;
				switch (num2 == num)
				{
				}
				num = (short)1430716417;
				if (num != 0)
				{
				}
				num = (short)1976172544;
				if (num != 0)
				{
				}
				num = (short)1200947200;
				short num3 = num;
				return this.cnvEmergencyToneSelection_42053.Editable;
			}
			set
			{
				short num = (short)1453547122;
				short num2 = num;
				num = (short)510353010;
				switch (num2 == num)
				{
				}
				num = (short)192479233;
				if (num != 0)
				{
				}
				num = (short)32178176;
				if (num != 0)
				{
				}
				num = (short)1332543488;
				short num3 = num;
				this.cnvEmergencyToneSelection_42053.Editable = value;
			}
		}

		// Token: 0x17004EF9 RID: 20217
		// (get) Token: 0x06009D3A RID: 40250 RVA: 0x0092ECF8 File Offset: 0x0092CEF8
		internal string CnvEmergencyToneSelection_42053_UILabel
		{
			get
			{
				short num = (short)520323650;
				short num2 = num;
				num = (short)2016576066;
				switch (num2 == num)
				{
				}
				num = (short)1826750464;
				if (num != 0)
				{
				}
				num = (short)1459093505;
				if (num != 0)
				{
				}
				num = (short)1883635712;
				short num3 = num;
				return this.cnvEmergencyToneSelection_42053.UIName;
			}
		}

		// Token: 0x17004EFA RID: 20218
		// (get) Token: 0x06009D3B RID: 40251 RVA: 0x0092EDB0 File Offset: 0x0092CFB0
		// (set) Token: 0x06009D3C RID: 40252 RVA: 0x0092EE64 File Offset: 0x0092D064
		internal bool CnvEmergencyToneSelection_42053_HiddenStatic
		{
			get
			{
				short num = (short)540409857;
				if (num != 0)
				{
				}
				num = (short)980432229;
				short num2 = num;
				num = (short)1299461477;
				switch (num2 == num)
				{
				}
				num = (short)246022144;
				if (num != 0)
				{
				}
				num = (short)1817575424;
				short num3 = num;
				return this.cnvEmergencyToneSelection_42053.HiddenStatic;
			}
			set
			{
				short num = (short)1242103809;
				if (num != 0)
				{
				}
				num = (short)1144209547;
				short num2 = num;
				num = (short)697647243;
				switch (num2 == num)
				{
				}
				num = (short)1147863040;
				if (num != 0)
				{
				}
				num = (short)54722560;
				short num3 = num;
				this.cnvEmergencyToneSelection_42053.HiddenStatic = value;
			}
		}

		// Token: 0x17004EFB RID: 20219
		// (get) Token: 0x06009D3D RID: 40253 RVA: 0x0092EF18 File Offset: 0x0092D118
		// (set) Token: 0x06009D3E RID: 40254 RVA: 0x0092EFCC File Offset: 0x0092D1CC
		internal bool CnvEmergencyToneSelection_42053_HiddenDynamic
		{
			get
			{
				short num = (short)176360316;
				short num2 = num;
				num = (short)39914364;
				switch (num2 == num)
				{
				}
				num = (short)1517617153;
				if (num != 0)
				{
				}
				num = (short)291045376;
				if (num != 0)
				{
				}
				num = (short)1946157056;
				short num3 = num;
				return this.cnvEmergencyToneSelection_42053.HiddenDynamic;
			}
			set
			{
				short num = (short)1268769627;
				short num2 = num;
				num = (short)483124059;
				switch (num2 == num)
				{
				}
				num = (short)1885274112;
				if (num != 0)
				{
				}
				num = (short)268828673;
				if (num != 0)
				{
				}
				num = (short)29360128;
				short num3 = num;
				this.cnvEmergencyToneSelection_42053.HiddenDynamic = value;
			}
		}

		// Token: 0x17004EFC RID: 20220
		// (get) Token: 0x06009D3F RID: 40255 RVA: 0x0092F080 File Offset: 0x0092D280
		public bool CnvEmergencyToneSelection_42053_HasDiffs
		{
			get
			{
				short num = (short)1386971404;
				short num2 = num;
				num = (short)1169129740;
				switch (num2 == num)
				{
				}
				num = (short)761987073;
				if (num != 0)
				{
				}
				num = (short)128712704;
				if (num != 0)
				{
				}
				num = (short)47775744;
				short num3 = num;
				return this.cnvEmergencyToneSelection_42053._HasDiffs;
			}
		}

		// Token: 0x06009D40 RID: 40256 RVA: 0x0092F134 File Offset: 0x0092D334
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
				{
					num2 = (short)915537920;
					short num3 = num2;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1986658307;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					num2 = (short)1560805377;
					if (num2 != 0)
					{
					}
					goto IL_DE;
				case 2:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)1827986870;
					short num4 = num2;
					num2 = (short)841407926;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DE;
					default:
						num2 = (short)1283915776;
						if (num2 != 0)
						{
						}
						num2 = (short)136445952;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					return result;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)839254017;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_DE:
				num2 = (short)1731919874;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1521156100;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04004D10 RID: 19728
		private global::AcpBusinessLayer.AcpRecRefField cnvEmergencyToneSelection_42053;
	}
}
