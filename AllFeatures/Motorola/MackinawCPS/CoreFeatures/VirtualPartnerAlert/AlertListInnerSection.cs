using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;

namespace Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert
{
	// Token: 0x020001B3 RID: 435
	[global::System.Serializable]
	public class AlertListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600513F RID: 20799 RVA: 0x0049E440 File Offset: 0x0049C640
		public AlertListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06005140 RID: 20800 RVA: 0x0049E45C File Offset: 0x0049C65C
		protected AlertListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06005141 RID: 20801 RVA: 0x0049E474 File Offset: 0x0049C674
		public override void Init()
		{
			int a_ = 7;
			short num = (short)1687853195;
			short num2 = num;
			num = (short)1674287243;
			switch (num2 == num)
			{
			}
			num = (short)1720451073;
			if (num != 0)
			{
			}
			num = (short)1623261184;
			short num3 = num;
			num = (short)1264386048;
			if (num != 0)
			{
			}
			this.virtualPartnerAlertListResultCode_43682 = new global::AcpBusinessLayer.AcpField<int>(this, global::AllFeatures.CodeplugGuid.b("黇ꏉ뻋뫍ꗏ돑룓蛕맗꣙꣛냝藟郡ꗣ諥跧飩飫ꋭ駯臱胳ꓵ鷷觹觻鋽瓿䄁欃戅洇唉㠋㴍☏⨑☓", a_), global::CommonResources.AcgResources.ID_RESULTCODE);
			this.virtualPartnerAlertListResultCode_43682.IgnoreOnCompare = true;
			this.virtualPartnerAlertListResultCode_43682.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.virtualPartnerAlertListResultCode_43682.DataTransferOrder = -1;
			this.virtualPartnerAlertAlias_A43683 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("黇ꏉ뻋뫍ꗏ돑룓蛕맗꣙꣛냝藟郡ꗣ諥跧飩飫꿭鳯鯱闳藵ꟷ믹죻췽㛿㨁㜃", a_), global::CommonResources.AcgResources.ID_ALERTALIAS, 14);
			this.virtualPartnerAlertAlias_A43683.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.virtualPartnerAlertAlias_A43683.DataTransferOrder = 1304;
			this.vPAlertListAlertAction_A43684 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("黇髉跋ꋍ뗏ꃑꃓ髕뇗꧙꣛鿝賟蟡難鋥ꧧ觩飫蟭鿯鳱꯳럵쳷짹쫻웽㓿", a_), global::CommonResources.AcgResources.ID_ALERTACTION, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.vPAlertListAlertAction_A43684.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.vPAlertListAlertAction_A43684.DataTransferOrder = 1305;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("觇ꛉ꧋볍꓏飓뿕ꯗ껙", a_);
			base.Id = 10892;
			base.UIName = global::CommonResources.AcgResources.ID_ALERTLIST;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06005142 RID: 20802 RVA: 0x0049E630 File Offset: 0x0049C830
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)1360134155;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_221;
				case 1:
					this.virtualPartnerAlertListResultCode_43682 = new global::AcpBusinessLayer.AcpField<int>(this, global::AllFeatures.CodeplugGuid.b("韀ꫂ럄돆볈꫊ꇌ鿎냐ꇒꇔ맖볘꧚鳜돞蓠釢釤ꯦ胨飪駬뷮铰胲胴鯶跸룺鋼鯾搀専㄄㐆㼈㌊㼌", a_), global::CommonResources.AcgResources.ID_RESULTCODE);
					this.virtualPartnerAlertListResultCode_43682.IgnoreOnCompare = true;
					this.virtualPartnerAlertListResultCode_43682.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.virtualPartnerAlertListResultCode_43682.DataTransferOrder = -1;
					num = (short)1809514505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韀鏂蓄ꯆ곈맊만菎룐ꃒꇔ雖뗘뻚꿜ꯞꃠ胢釤軦蛨藪달껮연샲쏴쿶췸", a_)))
					{
						num = (short)659292166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_366;
				case 3:
					this.virtualPartnerAlertAlias_A43683 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("韀ꫂ럄돆볈꫊ꇌ鿎냐ꇒꇔ맖볘꧚鳜돞蓠釢釤ꛦ藨苪賬鳮껰닲쇴쓶쿸쏺컼", a_), global::CommonResources.AcgResources.ID_ALERTALIAS, 14);
					this.virtualPartnerAlertAlias_A43683.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.virtualPartnerAlertAlias_A43683.DataTransferOrder = 1304;
					num = (short)1225785344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (producerFields != null)
					{
						num = (short)1776680970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_366;
				case 5:
					num = (short)1029177348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)593084977;
					short num3 = num;
					num = (short)2128921137;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E2;
					case 1:
						break;
					default:
					{
						num = (short)475070464;
						short num4 = num;
						break;
					}
					}
					num = (short)1596063744;
					if (num != 0)
					{
					}
					num = (short)1339490305;
					if (num != 0)
					{
					}
					this.vPAlertListAlertAction_A43684 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("韀鏂蓄ꯆ곈맊만菎룐ꃒꇔ雖뗘뻚꿜ꯞꃠ胢釤軦蛨藪달껮연샲쏴쿶췸", a_), global::CommonResources.AcgResources.ID_ALERTACTION, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.vPAlertListAlertAction_A43684.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.vPAlertListAlertAction_A43684.DataTransferOrder = 1305;
					num = (short)1892155404;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韀ꫂ럄돆볈꫊ꇌ鿎냐ꇒꇔ맖볘꧚鳜돞蓠釢釤ꛦ藨苪賬鳮껰닲쇴쓶쿸쏺컼", a_)))
					{
						num = (short)406585347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_221;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韀ꫂ럄돆볈꫊ꇌ鿎냐ꇒꇔ맖볘꧚鳜돞蓠釢釤ꯦ胨飪駬뷮铰胲胴鯶跸룺鋼鯾搀専㄄㐆㼈㌊㼌", a_)))
					{
						num = (short)302579713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E2;
				case 9:
					goto IL_E2;
				case 10:
					num = (short)640221192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 12:
					goto IL_1E2;
				}
				IL_61:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1373569029;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_E2:
				num = (short)232521735;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_221:
				num = (short)547880962;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1E2:
			IL_366:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胀꿂ꃄ뗆뷈臌ꛎꋐ꟒", a_);
			base.Id = 10892;
			base.UIName = global::CommonResources.AcgResources.ID_ALERTLIST;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06005143 RID: 20803 RVA: 0x0049E9D4 File Offset: 0x0049CBD4
		public override void PopulateReferences()
		{
			short num = (short)281529304;
			short num2 = num;
			num = (short)756992984;
			switch (num2 == num)
			{
			}
			num = (short)2038169601;
			if (num != 0)
			{
			}
			num = (short)1147338752;
			short num3 = num;
			num = (short)165478400;
			if (num != 0)
			{
			}
			this.vPAlertListAlertAction_A43684.SetRecset(this.a(4008));
		}

		// Token: 0x06005144 RID: 20804 RVA: 0x0049EA94 File Offset: 0x0049CC94
		public override void DropReferences()
		{
			short num = (short)1113012525;
			short num2 = num;
			num = (short)832256301;
			switch (num2 == num)
			{
			}
			num = (short)2053963777;
			if (num != 0)
			{
			}
			num = (short)234684416;
			short num3 = num;
			num = (short)1379270656;
			if (num != 0)
			{
			}
		}

		// Token: 0x06005145 RID: 20805 RVA: 0x0049EB3C File Offset: 0x0049CD3C
		public override void SetConstraints()
		{
			short num = (short)1289964427;
			short num2 = num;
			num = (short)913197963;
			switch (num2 == num)
			{
			}
			num = (short)498597889;
			if (num != 0)
			{
			}
			num = (short)270336000;
			short num3 = num;
			num = (short)160301056;
			if (num != 0)
			{
			}
			this.virtualPartnerAlertListResultCode_43682.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.vPAlertListAlertAction_A43684.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.VirtualPartnerConstraints.conVPAlertActionValidityACActionType);
		}

		// Token: 0x06005146 RID: 20806 RVA: 0x0049EC14 File Offset: 0x0049CE14
		public override void SetupDependencies()
		{
			short num = (short)1267682009;
			short num2 = num;
			num = (short)247679705;
			switch (num2 == num)
			{
			}
			num = (short)1738276864;
			if (num != 0)
			{
			}
			num = (short)413728768;
			short num3 = num;
			num = (short)1445593089;
			if (num != 0)
			{
			}
		}

		// Token: 0x17002A43 RID: 10819
		// (get) Token: 0x06005147 RID: 20807 RVA: 0x0049ECC0 File Offset: 0x0049CEC0
		public global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation ActionConsolidationForVPAlertListAlertAction_A43684
		{
			get
			{
				short num = (short)1413896971;
				short num2 = num;
				num = (short)1009736459;
				switch (num2 == num)
				{
				}
				num = (short)23265281;
				if (num != 0)
				{
				}
				num = (short)1682767872;
				short num3 = num;
				num = (short)468254720;
				if (num != 0)
				{
				}
				return this.vPAlertListAlertAction_A43684.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation;
			}
		}

		// Token: 0x17002A44 RID: 10820
		// (get) Token: 0x06005148 RID: 20808 RVA: 0x0049ED7C File Offset: 0x0049CF7C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1547835608;
				short num2 = num;
				num = (short)585898200;
				switch (num2 == num)
				{
				}
				num = (short)464060417;
				if (num != 0)
				{
				}
				num = (short)1356398592;
				short num3 = num;
				num = (short)317194240;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17002A45 RID: 10821
		// (get) Token: 0x06005149 RID: 20809 RVA: 0x0049EE2C File Offset: 0x0049D02C
		// (set) Token: 0x0600514A RID: 20810 RVA: 0x0049EEE0 File Offset: 0x0049D0E0
		public int VirtualPartnerAlertListResultCode_43682Value
		{
			get
			{
				short num = (short)1024942175;
				short num2 = num;
				num = (short)482828383;
				switch (num2 == num)
				{
				}
				num = (short)1891500033;
				if (num != 0)
				{
				}
				num = (short)1331757056;
				short num3 = num;
				num = (short)1548681216;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListResultCode_43682.Value;
			}
			set
			{
				short num = (short)79742465;
				short num2 = num;
				num = (short)754894337;
				switch (num2 == num)
				{
				}
				num = (short)1004994561;
				if (num != 0)
				{
				}
				num = (short)1086914560;
				short num3 = num;
				num = (short)553648128;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertListResultCode_43682.Value = value;
			}
		}

		// Token: 0x17002A46 RID: 10822
		// (get) Token: 0x0600514B RID: 20811 RVA: 0x0049EF94 File Offset: 0x0049D194
		public global::AcpBusinessLayer.AcpField<int> VirtualPartnerAlertListResultCode_43682
		{
			get
			{
				short num = (short)662832218;
				short num2 = num;
				num = (short)1266353242;
				switch (num2 == num)
				{
				}
				num = (short)167182336;
				if (num != 0)
				{
				}
				num = (short)723779584;
				short num3 = num;
				num = (short)1321467905;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListResultCode_43682;
			}
		}

		// Token: 0x17002A47 RID: 10823
		// (get) Token: 0x0600514C RID: 20812 RVA: 0x0049F044 File Offset: 0x0049D244
		// (set) Token: 0x0600514D RID: 20813 RVA: 0x0049F0FC File Offset: 0x0049D2FC
		public int VirtualPartnerAlertListResultCode_43682_UIValue
		{
			get
			{
				short num = (short)222794948;
				short num2 = num;
				num = (short)1402049732;
				switch (num2 == num)
				{
				}
				num = (short)949354497;
				if (num != 0)
				{
				}
				num = (short)1383596032;
				short num3 = num;
				num = (short)655228928;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListResultCode_43682.Value;
			}
			set
			{
				short num = (short)1440900503;
				short num2 = num;
				num = (short)591619479;
				switch (num2 == num)
				{
				}
				num = (short)2002780161;
				if (num != 0)
				{
				}
				num = (short)2097610752;
				short num3 = num;
				num = (short)2012086272;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertListResultCode_43682.Value = value;
			}
		}

		// Token: 0x17002A48 RID: 10824
		// (get) Token: 0x0600514E RID: 20814 RVA: 0x0049F1B4 File Offset: 0x0049D3B4
		// (set) Token: 0x0600514F RID: 20815 RVA: 0x0049F268 File Offset: 0x0049D468
		public bool VirtualPartnerAlertListResultCode_43682_Applicable
		{
			get
			{
				short num = (short)624951297;
				if (num != 0)
				{
				}
				num = (short)1045961185;
				short num2 = num;
				num = (short)369105377;
				switch (num2 == num)
				{
				}
				num = (short)1676345344;
				short num3 = num;
				num = (short)1217789952;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListResultCode_43682.Applicable;
			}
			set
			{
				short num = (short)880540197;
				short num2 = num;
				num = (short)1849227813;
				switch (num2 == num)
				{
				}
				num = (short)941031425;
				if (num != 0)
				{
				}
				num = (short)1747845120;
				short num3 = num;
				num = (short)913113088;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertListResultCode_43682.Applicable = value;
			}
		}

		// Token: 0x17002A49 RID: 10825
		// (get) Token: 0x06005150 RID: 20816 RVA: 0x0049F31C File Offset: 0x0049D51C
		// (set) Token: 0x06005151 RID: 20817 RVA: 0x0049F3D4 File Offset: 0x0049D5D4
		public bool VirtualPartnerAlertListResultCode_43682_Valid
		{
			get
			{
				short num = (short)834732033;
				if (num != 0)
				{
				}
				num = (short)726382945;
				short num2 = num;
				num = (short)1792063841;
				switch (num2 == num)
				{
				}
				num = (short)2083061760;
				short num3 = num;
				num = (short)419758080;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListResultCode_43682.Valid;
			}
			set
			{
				short num = (short)1220990671;
				short num2 = num;
				num = (short)1155389135;
				switch (num2 == num)
				{
				}
				num = (short)833880064;
				if (num != 0)
				{
				}
				num = (short)308150272;
				short num3 = num;
				num = (short)412286977;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertListResultCode_43682.Valid = value;
			}
		}

		// Token: 0x17002A4A RID: 10826
		// (get) Token: 0x06005152 RID: 20818 RVA: 0x0049F488 File Offset: 0x0049D688
		// (set) Token: 0x06005153 RID: 20819 RVA: 0x0049F53C File Offset: 0x0049D73C
		public bool VirtualPartnerAlertListResultCode_43682_Visible
		{
			get
			{
				short num = (short)1525959963;
				short num2 = num;
				num = (short)702434587;
				switch (num2 == num)
				{
				}
				num = (short)891813889;
				if (num != 0)
				{
				}
				num = (short)1288765440;
				short num3 = num;
				num = (short)131465216;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListResultCode_43682.Visible;
			}
			set
			{
				short num = (short)1627455489;
				if (num != 0)
				{
				}
				num = (short)2073623517;
				short num2 = num;
				num = (short)1990851549;
				switch (num2 == num)
				{
				}
				num = (short)7602176;
				short num3 = num;
				num = (short)1238761472;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertListResultCode_43682.Visible = value;
			}
		}

		// Token: 0x17002A4B RID: 10827
		// (get) Token: 0x06005154 RID: 20820 RVA: 0x0049F5F4 File Offset: 0x0049D7F4
		// (set) Token: 0x06005155 RID: 20821 RVA: 0x0049F6A8 File Offset: 0x0049D8A8
		public bool VirtualPartnerAlertListResultCode_43682_Editable
		{
			get
			{
				short num = (short)837169946;
				short num2 = num;
				num = (short)1726165786;
				switch (num2 == num)
				{
				}
				num = (short)983041;
				if (num != 0)
				{
				}
				num = (short)1680867328;
				short num3 = num;
				num = (short)1817247744;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListResultCode_43682.Editable;
			}
			set
			{
				short num = (short)632443162;
				short num2 = num;
				num = (short)1094668570;
				switch (num2 == num)
				{
				}
				num = (short)1635713025;
				if (num != 0)
				{
				}
				num = (short)1513291776;
				short num3 = num;
				num = (short)871956480;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertListResultCode_43682.Editable = value;
			}
		}

		// Token: 0x17002A4C RID: 10828
		// (get) Token: 0x06005156 RID: 20822 RVA: 0x0049F75C File Offset: 0x0049D95C
		internal string VirtualPartnerAlertListResultCode_43682_UILabel
		{
			get
			{
				short num = (short)71220194;
				short num2 = num;
				num = (short)410106850;
				switch (num2 == num)
				{
				}
				num = (short)82509825;
				if (num != 0)
				{
				}
				num = (short)1228668928;
				short num3 = num;
				num = (short)2048393216;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListResultCode_43682.UIName;
			}
		}

		// Token: 0x17002A4D RID: 10829
		// (get) Token: 0x06005157 RID: 20823 RVA: 0x0049F810 File Offset: 0x0049DA10
		// (set) Token: 0x06005158 RID: 20824 RVA: 0x0049F8C4 File Offset: 0x0049DAC4
		internal bool VirtualPartnerAlertListResultCode_43682_HiddenStatic
		{
			get
			{
				short num = (short)261522849;
				short num2 = num;
				num = (short)1244890529;
				switch (num2 == num)
				{
				}
				num = (short)849018881;
				if (num != 0)
				{
				}
				num = (short)1402732544;
				short num3 = num;
				num = (short)601161728;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListResultCode_43682.HiddenStatic;
			}
			set
			{
				short num = (short)1589164561;
				short num2 = num;
				num = (short)551729681;
				switch (num2 == num)
				{
				}
				num = (short)744226817;
				if (num != 0)
				{
				}
				num = (short)1465253888;
				short num3 = num;
				num = (short)712638464;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertListResultCode_43682.HiddenStatic = value;
			}
		}

		// Token: 0x17002A4E RID: 10830
		// (get) Token: 0x06005159 RID: 20825 RVA: 0x0049F978 File Offset: 0x0049DB78
		// (set) Token: 0x0600515A RID: 20826 RVA: 0x0049FA2C File Offset: 0x0049DC2C
		internal bool VirtualPartnerAlertListResultCode_43682_HiddenDynamic
		{
			get
			{
				short num = (short)799604281;
				short num2 = num;
				num = (short)1629945401;
				switch (num2 == num)
				{
				}
				num = (short)258867200;
				if (num != 0)
				{
				}
				num = (short)194183168;
				short num3 = num;
				num = (short)296419329;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListResultCode_43682.HiddenDynamic;
			}
			set
			{
				short num = (short)2086614225;
				short num2 = num;
				num = (short)197080273;
				switch (num2 == num)
				{
				}
				num = (short)631046145;
				if (num != 0)
				{
				}
				num = (short)1339555840;
				short num3 = num;
				num = (short)1977614336;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertListResultCode_43682.HiddenDynamic = value;
			}
		}

		// Token: 0x17002A4F RID: 10831
		// (get) Token: 0x0600515B RID: 20827 RVA: 0x0049FAE4 File Offset: 0x0049DCE4
		public bool VirtualPartnerAlertListResultCode_43682_HasDiffs
		{
			get
			{
				short num = (short)1495451888;
				short num2 = num;
				num = (short)259377392;
				switch (num2 == num)
				{
				}
				num = (short)1594818561;
				if (num != 0)
				{
				}
				num = (short)2128805888;
				short num3 = num;
				num = (short)687341568;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListResultCode_43682._HasDiffs;
			}
		}

		// Token: 0x17002A50 RID: 10832
		// (get) Token: 0x0600515C RID: 20828 RVA: 0x0049FB98 File Offset: 0x0049DD98
		// (set) Token: 0x0600515D RID: 20829 RVA: 0x0049FC4C File Offset: 0x0049DE4C
		public string VirtualPartnerAlertAlias_A43683Value
		{
			get
			{
				short num = (short)1624248857;
				short num2 = num;
				num = (short)586355225;
				switch (num2 == num)
				{
				}
				num = (short)1002897408;
				if (num != 0)
				{
				}
				num = (short)1960312832;
				short num3 = num;
				num = (short)561971201;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertAlias_A43683.Value;
			}
			set
			{
				short num = (short)417413549;
				short num2 = num;
				num = (short)642791853;
				switch (num2 == num)
				{
				}
				num = (short)1363410944;
				if (num != 0)
				{
				}
				num = (short)1900478464;
				short num3 = num;
				num = (short)1701576705;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertAlias_A43683.Value = value;
			}
		}

		// Token: 0x17002A51 RID: 10833
		// (get) Token: 0x0600515E RID: 20830 RVA: 0x0049FD00 File Offset: 0x0049DF00
		public global::AcpBusinessLayer.AcpField<string> VirtualPartnerAlertAlias_A43683
		{
			get
			{
				short num = (short)2021953243;
				short num2 = num;
				num = (short)171019995;
				switch (num2 == num)
				{
				}
				num = (short)2031812609;
				if (num != 0)
				{
				}
				num = (short)612958208;
				short num3 = num;
				num = (short)1818558464;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertAlias_A43683;
			}
		}

		// Token: 0x17002A52 RID: 10834
		// (get) Token: 0x0600515F RID: 20831 RVA: 0x0049FDB0 File Offset: 0x0049DFB0
		// (set) Token: 0x06005160 RID: 20832 RVA: 0x0049FE64 File Offset: 0x0049E064
		public string VirtualPartnerAlertAlias_A43683_UIValue
		{
			get
			{
				short num = (short)1661865542;
				short num2 = num;
				num = (short)587140678;
				switch (num2 == num)
				{
				}
				num = (short)1225129985;
				if (num != 0)
				{
				}
				num = (short)553320448;
				short num3 = num;
				num = (short)1202716672;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertAlias_A43683.Value;
			}
			set
			{
				short num = (short)476128471;
				short num2 = num;
				num = (short)933045463;
				switch (num2 == num)
				{
				}
				num = (short)800784385;
				if (num != 0)
				{
				}
				num = (short)78905344;
				short num3 = num;
				num = (short)1912668160;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertAlias_A43683.Value = value;
			}
		}

		// Token: 0x17002A53 RID: 10835
		// (get) Token: 0x06005161 RID: 20833 RVA: 0x0049FF18 File Offset: 0x0049E118
		// (set) Token: 0x06005162 RID: 20834 RVA: 0x0049FFCC File Offset: 0x0049E1CC
		public bool VirtualPartnerAlertAlias_A43683_Applicable
		{
			get
			{
				short num = (short)195006703;
				short num2 = num;
				num = (short)376672495;
				switch (num2 == num)
				{
				}
				num = (short)571801601;
				if (num != 0)
				{
				}
				num = (short)678559744;
				short num3 = num;
				num = (short)762183680;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertAlias_A43683.Applicable;
			}
			set
			{
				short num = (short)894422856;
				short num2 = num;
				num = (short)1909116744;
				switch (num2 == num)
				{
				}
				num = (short)1912406017;
				if (num != 0)
				{
				}
				num = (short)179961856;
				short num3 = num;
				num = (short)1759707136;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertAlias_A43683.Applicable = value;
			}
		}

		// Token: 0x17002A54 RID: 10836
		// (get) Token: 0x06005163 RID: 20835 RVA: 0x004A0084 File Offset: 0x0049E284
		// (set) Token: 0x06005164 RID: 20836 RVA: 0x004A013C File Offset: 0x0049E33C
		public bool VirtualPartnerAlertAlias_A43683_Valid
		{
			get
			{
				short num = (short)1660115091;
				short num2 = num;
				num = (short)1116952723;
				switch (num2 == num)
				{
				}
				num = (short)1183842304;
				if (num != 0)
				{
				}
				num = (short)902037504;
				short num3 = num;
				num = (short)1349779457;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertAlias_A43683.Valid;
			}
			set
			{
				short num = (short)1672347649;
				if (num != 0)
				{
				}
				num = (short)538109664;
				short num2 = num;
				num = (short)1752032992;
				switch (num2 == num)
				{
				}
				num = (short)2131361792;
				short num3 = num;
				num = (short)492830720;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertAlias_A43683.Valid = value;
			}
		}

		// Token: 0x17002A55 RID: 10837
		// (get) Token: 0x06005165 RID: 20837 RVA: 0x004A01F4 File Offset: 0x0049E3F4
		// (set) Token: 0x06005166 RID: 20838 RVA: 0x004A02A8 File Offset: 0x0049E4A8
		public bool VirtualPartnerAlertAlias_A43683_Visible
		{
			get
			{
				short num = (short)450726236;
				short num2 = num;
				num = (short)1233553756;
				switch (num2 == num)
				{
				}
				num = (short)1369571329;
				if (num != 0)
				{
				}
				num = (short)1033437184;
				short num3 = num;
				num = (short)1823473664;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertAlias_A43683.Visible;
			}
			set
			{
				short num = (short)166995646;
				short num2 = num;
				num = (short)1458316990;
				switch (num2 == num)
				{
				}
				num = (short)1438973953;
				if (num != 0)
				{
				}
				num = (short)1945174016;
				short num3 = num;
				num = (short)1757085696;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertAlias_A43683.Visible = value;
			}
		}

		// Token: 0x17002A56 RID: 10838
		// (get) Token: 0x06005167 RID: 20839 RVA: 0x004A0360 File Offset: 0x0049E560
		// (set) Token: 0x06005168 RID: 20840 RVA: 0x004A0414 File Offset: 0x0049E614
		public bool VirtualPartnerAlertAlias_A43683_Editable
		{
			get
			{
				short num = (short)1144086248;
				short num2 = num;
				num = (short)1203265256;
				switch (num2 == num)
				{
				}
				num = (short)1270808577;
				if (num != 0)
				{
				}
				num = (short)622592000;
				short num3 = num;
				num = (short)233701376;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertAlias_A43683.Editable;
			}
			set
			{
				short num = (short)153274798;
				short num2 = num;
				num = (short)130206126;
				switch (num2 == num)
				{
				}
				num = (short)1988558849;
				if (num != 0)
				{
				}
				num = (short)170459136;
				short num3 = num;
				num = (short)1344929792;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertAlias_A43683.Editable = value;
			}
		}

		// Token: 0x17002A57 RID: 10839
		// (get) Token: 0x06005169 RID: 20841 RVA: 0x004A04CC File Offset: 0x0049E6CC
		internal string VirtualPartnerAlertAlias_A43683_UILabel
		{
			get
			{
				short num = (short)763161221;
				short num2 = num;
				num = (short)877521541;
				switch (num2 == num)
				{
				}
				num = (short)76349440;
				if (num != 0)
				{
				}
				num = (short)898695168;
				short num3 = num;
				num = (short)295632897;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertAlias_A43683.UIName;
			}
		}

		// Token: 0x17002A58 RID: 10840
		// (get) Token: 0x0600516A RID: 20842 RVA: 0x004A0584 File Offset: 0x0049E784
		// (set) Token: 0x0600516B RID: 20843 RVA: 0x004A063C File Offset: 0x0049E83C
		internal bool VirtualPartnerAlertAlias_A43683_HiddenStatic
		{
			get
			{
				short num = (short)389189003;
				short num2 = num;
				num = (short)798264715;
				switch (num2 == num)
				{
				}
				num = (short)1477181441;
				if (num != 0)
				{
				}
				num = (short)1975779328;
				short num3 = num;
				num = (short)1148583936;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertAlias_A43683.HiddenStatic;
			}
			set
			{
				short num = (short)1861244945;
				short num2 = num;
				num = (short)1387157521;
				switch (num2 == num)
				{
				}
				num = (short)558432257;
				if (num != 0)
				{
				}
				num = (short)905773056;
				short num3 = num;
				num = (short)860487680;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertAlias_A43683.HiddenStatic = value;
			}
		}

		// Token: 0x17002A59 RID: 10841
		// (get) Token: 0x0600516C RID: 20844 RVA: 0x004A06F4 File Offset: 0x0049E8F4
		// (set) Token: 0x0600516D RID: 20845 RVA: 0x004A07AC File Offset: 0x0049E9AC
		internal bool VirtualPartnerAlertAlias_A43683_HiddenDynamic
		{
			get
			{
				short num = (short)348093552;
				short num2 = num;
				num = (short)906460272;
				switch (num2 == num)
				{
				}
				num = (short)461570049;
				if (num != 0)
				{
				}
				num = (short)69009408;
				short num3 = num;
				num = (short)1680670720;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertAlias_A43683.HiddenDynamic;
			}
			set
			{
				short num = (short)854394725;
				short num2 = num;
				num = (short)1456408421;
				switch (num2 == num)
				{
				}
				num = (short)1071382529;
				if (num != 0)
				{
				}
				num = (short)1706033152;
				short num3 = num;
				num = (short)664076288;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertAlias_A43683.HiddenDynamic = value;
			}
		}

		// Token: 0x17002A5A RID: 10842
		// (get) Token: 0x0600516E RID: 20846 RVA: 0x004A0864 File Offset: 0x0049EA64
		public bool VirtualPartnerAlertAlias_A43683_HasDiffs
		{
			get
			{
				short num = (short)1055448494;
				short num2 = num;
				num = (short)1776278958;
				switch (num2 == num)
				{
				}
				num = (short)547815425;
				if (num != 0)
				{
				}
				num = (short)1967587328;
				short num3 = num;
				num = (short)1592131584;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertAlias_A43683._HasDiffs;
			}
		}

		// Token: 0x17002A5B RID: 10843
		// (get) Token: 0x0600516F RID: 20847 RVA: 0x004A0918 File Offset: 0x0049EB18
		// (set) Token: 0x06005170 RID: 20848 RVA: 0x004A09D0 File Offset: 0x0049EBD0
		public int VPAlertListAlertAction_A43684Value
		{
			get
			{
				short num = (short)1099044985;
				short num2 = num;
				num = (short)99752057;
				switch (num2 == num)
				{
				}
				num = (short)1186922497;
				if (num != 0)
				{
				}
				num = (short)1547304960;
				short num3 = num;
				num = (short)1033109504;
				if (num != 0)
				{
				}
				return this.vPAlertListAlertAction_A43684.Value;
			}
			set
			{
				short num = (short)1072895397;
				short num2 = num;
				num = (short)777852325;
				switch (num2 == num)
				{
				}
				num = (short)185139201;
				if (num != 0)
				{
				}
				num = (short)1655963648;
				short num3 = num;
				num = (short)1441071104;
				if (num != 0)
				{
				}
				this.vPAlertListAlertAction_A43684.Value = value;
			}
		}

		// Token: 0x17002A5C RID: 10844
		// (get) Token: 0x06005171 RID: 20849 RVA: 0x004A0A88 File Offset: 0x0049EC88
		// (set) Token: 0x06005172 RID: 20850 RVA: 0x004A0B3C File Offset: 0x0049ED3C
		public string VPAlertListAlertAction_A43684_UIValue
		{
			get
			{
				short num = (short)1587992214;
				short num2 = num;
				num = (short)1267586710;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1060372480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)143392768;
				if (num != 0)
				{
				}
				num = (short)341901313;
				if (num != 0)
				{
				}
				return this.vPAlertListAlertAction_A43684.UIValue;
			}
			set
			{
				short num = (short)1935867905;
				if (num != 0)
				{
				}
				num = (short)731381760;
				short num2 = num;
				num = (short)589783287;
				short num3 = num;
				num = (short)934699255;
				switch (num3 == num)
				{
				}
				num = (short)1969422336;
				if (num != 0)
				{
				}
				this.vPAlertListAlertAction_A43684.UIValue = value;
			}
		}

		// Token: 0x17002A5D RID: 10845
		// (get) Token: 0x06005173 RID: 20851 RVA: 0x004A0BF0 File Offset: 0x0049EDF0
		public global::AcpBusinessLayer.AcpRecRefField VPAlertListAlertAction_A43684
		{
			get
			{
				short num = (short)1346030936;
				short num2 = num;
				num = (short)1760546136;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2141061120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)133955585;
				if (num != 0)
				{
				}
				num = (short)512098304;
				if (num != 0)
				{
				}
				return this.vPAlertListAlertAction_A43684;
			}
		}

		// Token: 0x17002A5E RID: 10846
		// (get) Token: 0x06005174 RID: 20852 RVA: 0x004A0CA4 File Offset: 0x0049EEA4
		// (set) Token: 0x06005175 RID: 20853 RVA: 0x004A0D58 File Offset: 0x0049EF58
		public bool VPAlertListAlertAction_A43684_Applicable
		{
			get
			{
				short num = (short)884371891;
				short num2 = num;
				num = (short)2065985971;
				switch (num2 == num)
				{
				default:
				{
					num = (short)212402176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)996212736;
				if (num != 0)
				{
				}
				num = (short)1650786305;
				if (num != 0)
				{
				}
				return this.vPAlertListAlertAction_A43684.Applicable;
			}
			set
			{
				short num = (short)61624500;
				short num2 = num;
				num = (short)1104105652;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1339162624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2059272193;
				if (num != 0)
				{
				}
				num = (short)1384775680;
				if (num != 0)
				{
				}
				this.vPAlertListAlertAction_A43684.Applicable = value;
			}
		}

		// Token: 0x17002A5F RID: 10847
		// (get) Token: 0x06005176 RID: 20854 RVA: 0x004A0E08 File Offset: 0x0049F008
		// (set) Token: 0x06005177 RID: 20855 RVA: 0x004A0EC0 File Offset: 0x0049F0C0
		public bool VPAlertListAlertAction_A43684_Valid
		{
			get
			{
				short num = (short)2046542826;
				short num2 = num;
				num = (short)502318058;
				switch (num2 == num)
				{
				default:
				{
					num = (short)771293184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1564803072;
				if (num != 0)
				{
				}
				num = (short)1988493313;
				if (num != 0)
				{
				}
				return this.vPAlertListAlertAction_A43684.Valid;
			}
			set
			{
				short num = (short)755066438;
				short num2 = num;
				num = (short)1972004422;
				switch (num2 == num)
				{
				default:
				{
					num = (short)89653248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2031878145;
				if (num != 0)
				{
				}
				num = (short)231735296;
				if (num != 0)
				{
				}
				this.vPAlertListAlertAction_A43684.Valid = value;
			}
		}

		// Token: 0x17002A60 RID: 10848
		// (get) Token: 0x06005178 RID: 20856 RVA: 0x004A0F78 File Offset: 0x0049F178
		// (set) Token: 0x06005179 RID: 20857 RVA: 0x004A102C File Offset: 0x0049F22C
		public bool VPAlertListAlertAction_A43684_Visible
		{
			get
			{
				short num = (short)1170014209;
				if (num != 0)
				{
				}
				num = (short)311558144;
				short num2 = num;
				num = (short)529390760;
				short num3 = num;
				num = (short)2108349608;
				switch (num3 == num)
				{
				}
				num = (short)2129526784;
				if (num != 0)
				{
				}
				return this.vPAlertListAlertAction_A43684.Visible;
			}
			set
			{
				short num = (short)1058028688;
				short num2 = num;
				num = (short)1827159184;
				switch (num2 == num)
				{
				default:
				{
					num = (short)499187712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1804468225;
				if (num != 0)
				{
				}
				num = (short)559415296;
				if (num != 0)
				{
				}
				this.vPAlertListAlertAction_A43684.Visible = value;
			}
		}

		// Token: 0x17002A61 RID: 10849
		// (get) Token: 0x0600517A RID: 20858 RVA: 0x004A10E0 File Offset: 0x0049F2E0
		// (set) Token: 0x0600517B RID: 20859 RVA: 0x004A1198 File Offset: 0x0049F398
		public bool VPAlertListAlertAction_A43684_Editable
		{
			get
			{
				short num = (short)1455357953;
				if (num != 0)
				{
				}
				num = (short)1396637696;
				short num2 = num;
				num = (short)637145542;
				short num3 = num;
				num = (short)251990470;
				switch (num3 == num)
				{
				}
				num = (short)2081751040;
				if (num != 0)
				{
				}
				return this.vPAlertListAlertAction_A43684.Editable;
			}
			set
			{
				short num = (short)294664947;
				short num2 = num;
				num = (short)2056141555;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2040070144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1053884416;
				if (num != 0)
				{
				}
				num = (short)1169555457;
				if (num != 0)
				{
				}
				this.vPAlertListAlertAction_A43684.Editable = value;
			}
		}

		// Token: 0x17002A62 RID: 10850
		// (get) Token: 0x0600517C RID: 20860 RVA: 0x004A1248 File Offset: 0x0049F448
		internal string VPAlertListAlertAction_A43684_UILabel
		{
			get
			{
				short num = (short)826939066;
				short num2 = num;
				num = (short)662312634;
				switch (num2 == num)
				{
				default:
				{
					num = (short)467927040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1318912000;
				if (num != 0)
				{
				}
				num = (short)1361313793;
				if (num != 0)
				{
				}
				return this.vPAlertListAlertAction_A43684.UIName;
			}
		}

		// Token: 0x17002A63 RID: 10851
		// (get) Token: 0x0600517D RID: 20861 RVA: 0x004A1300 File Offset: 0x0049F500
		// (set) Token: 0x0600517E RID: 20862 RVA: 0x004A13B8 File Offset: 0x0049F5B8
		internal bool VPAlertListAlertAction_A43684_HiddenStatic
		{
			get
			{
				short num = (short)942113256;
				short num2 = num;
				num = (short)1721008616;
				switch (num2 == num)
				{
				default:
				{
					num = (short)63766528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)682950657;
				if (num != 0)
				{
				}
				num = (short)1691222016;
				if (num != 0)
				{
				}
				return this.vPAlertListAlertAction_A43684.HiddenStatic;
			}
			set
			{
				short num = (short)901859569;
				short num2 = num;
				num = (short)868501745;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1299185664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)569901057;
				if (num != 0)
				{
				}
				num = (short)1250230272;
				if (num != 0)
				{
				}
				this.vPAlertListAlertAction_A43684.HiddenStatic = value;
			}
		}

		// Token: 0x17002A64 RID: 10852
		// (get) Token: 0x0600517F RID: 20863 RVA: 0x004A146C File Offset: 0x0049F66C
		// (set) Token: 0x06005180 RID: 20864 RVA: 0x004A151C File Offset: 0x0049F71C
		internal bool VPAlertListAlertAction_A43684_HiddenDynamic
		{
			get
			{
				short num = (short)566484778;
				short num2 = num;
				num = (short)1843846954;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1023148032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)504430592;
				if (num != 0)
				{
				}
				num = (short)1822359553;
				if (num != 0)
				{
				}
				return this.vPAlertListAlertAction_A43684.HiddenDynamic;
			}
			set
			{
				short num = (short)1269301249;
				if (num != 0)
				{
				}
				num = (short)1769930752;
				short num2 = num;
				num = (short)1482740100;
				short num3 = num;
				num = (short)1478873476;
				switch (num3 == num)
				{
				}
				num = (short)493158400;
				if (num != 0)
				{
				}
				this.vPAlertListAlertAction_A43684.HiddenDynamic = value;
			}
		}

		// Token: 0x17002A65 RID: 10853
		// (get) Token: 0x06005181 RID: 20865 RVA: 0x004A15D0 File Offset: 0x0049F7D0
		public bool VPAlertListAlertAction_A43684_HasDiffs
		{
			get
			{
				short num = (short)1696774074;
				short num2 = num;
				num = (short)1511503802;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1591738368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1639514113;
				if (num != 0)
				{
				}
				num = (short)392167424;
				if (num != 0)
				{
				}
				return this.vPAlertListAlertAction_A43684._HasDiffs;
			}
		}

		// Token: 0x06005182 RID: 20866 RVA: 0x004A1684 File Offset: 0x0049F884
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
					num2 = (short)286720003;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_FF;
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)114556928;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13F;
				case 3:
					goto IL_118;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)141492225;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_FF:
			goto IL_13F;
			IL_118:
			if (base.ParentRecset.ContainerDoc != null)
			{
				goto IL_125;
			}
			IL_13F:
			num2 = (short)1572864;
			short num3 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)1169416066;
			short num4 = num2;
			num2 = (short)914808706;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_125:
				num2 = (short)652935172;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)102301696;
				if (num2 != 0)
				{
				}
				num2 = (short)1027211265;
				if (num2 != 0)
				{
				}
				num2 = (short)229244930;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x04001EE8 RID: 7912
		private global::AcpBusinessLayer.AcpField<int> virtualPartnerAlertListResultCode_43682;

		// Token: 0x04001EE9 RID: 7913
		private global::AcpBusinessLayer.AcpField<string> virtualPartnerAlertAlias_A43683;

		// Token: 0x04001EEA RID: 7914
		private global::AcpBusinessLayer.AcpRecRefField vPAlertListAlertAction_A43684;
	}
}
