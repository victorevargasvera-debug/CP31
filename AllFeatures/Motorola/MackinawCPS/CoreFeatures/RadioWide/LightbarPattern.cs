using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000179 RID: 377
	[global::System.Serializable]
	public class LightbarPattern : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06003C61 RID: 15457 RVA: 0x00387730 File Offset: 0x00385930
		public LightbarPattern(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06003C62 RID: 15458 RVA: 0x00387770 File Offset: 0x00385970
		protected LightbarPattern(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06003C63 RID: 15459 RVA: 0x00387788 File Offset: 0x00385988
		public override void Init()
		{
			int a_ = 8;
			short num = (short)83034112;
			short num2 = num;
			num = (short)1167776131;
			short num3 = num;
			num = (short)572643715;
			switch (num3 == num)
			{
			}
			num = (short)1715339264;
			if (num != 0)
			{
			}
			num = (short)1150418945;
			if (num != 0)
			{
			}
			this.radWideUniversalRelayControllerEquipped_A37191 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔苖럘닚ꯜ뫞鏠郢蓤详믨軪臬軮裰냲髴駶跸觺鋼鏾洀昂眄䈆砈縊搌缎愐瘒焔䠖堘⠚⨜⸞ᠠሢ", a_), global::CommonResources.AcgResources.ID_UNIVERSALRELAYCONTROLLEREQUIPPED);
			this.radWideUniversalRelayControllerEquipped_A37191.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideUniversalRelayControllerEquipped_A37191.DataTransferOrder = 130;
			this.radWideUniversalRelayControllerFatalError_A37194 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔苖럘닚ꯜ뫞鏠郢蓤详믨軪臬軮裰냲髴駶跸觺鋼鏾洀昂眄䄆栈缊氌挎吐愒朔砖欘䐚尜Ⱎᘠሢᰤጦ", a_), global::CommonResources.AcgResources.ID_UNIVERSALRELAYCONTROLLERFATALERROR);
			this.radWideUniversalRelayControllerFatalError_A37194.IgnoreOnCompare = true;
			this.radWideUniversalRelayControllerFatalError_A37194.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideUniversalRelayControllerFatalError_A37194.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鳈ꗊ꓌많듐ꇒꛔ뛖뗘ﯚ远뫞跠苢鳤쟦ꫨ蓪菬鯮菰鳲駴鯶鳸觺", a_);
			base.Id = 10604;
			base.UIName = global::CommonResources.AcgResources.ID_UNIVERSALRELAYCONTROLLER;
			base.DataTransferOrder = 13;
		}

		// Token: 0x06003C64 RID: 15460 RVA: 0x003878EC File Offset: 0x00385AEC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 16;
			short num = (short)1033306113;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菐닒뇔胖냘뿚룜諞迠諢鏤苦鯨飪賬菮ꏰ雲駴零胸룺鋼釾甀焂樄欆攈渊缌䤎瀐朒琔笖尘椚漜瀞匠簢搤ᐦḨᨪᐬᬮ", a_)))
					{
						goto IL_D1;
					}
					goto IL_29F;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 2:
				{
					num = (short)1404262355;
					short num3 = num;
					num = (short)1333614547;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D1;
					default:
						goto IL_213;
					}
					break;
				}
				case 3:
					num = (short)624689156;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (producerFields != null)
					{
						num = (short)617414664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_29F;
				case 5:
				{
					num = (short)357236736;
					short num4 = num;
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菐닒뇔胖냘뿚룜諞迠諢鏤苦鯨飪賬菮ꏰ雲駴零胸룺鋼釾甀焂樄欆攈渊缌䨎怐昒簔朖椘縚礜䀞怠ဢሤᘦဨᨪ", a_)))
					{
						num = (short)1681915913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79;
				}
				case 6:
					this.radWideUniversalRelayControllerFatalError_A37194 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("菐닒뇔胖냘뿚룜諞迠諢鏤苦鯨飪賬菮ꏰ雲駴零胸룺鋼釾甀焂樄欆攈渊缌䤎瀐朒琔笖尘椚漜瀞匠簢搤ᐦḨᨪᐬᬮ", a_), global::CommonResources.AcgResources.ID_UNIVERSALRELAYCONTROLLERFATALERROR);
					this.radWideUniversalRelayControllerFatalError_A37194.IgnoreOnCompare = true;
					this.radWideUniversalRelayControllerFatalError_A37194.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideUniversalRelayControllerFatalError_A37194.DataTransferOrder = -1;
					num = (short)398065666;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_79;
				case 8:
					num = (short)1251409925;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					this.radWideUniversalRelayControllerEquipped_A37191 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("菐닒뇔胖냘뿚룜諞迠諢鏤苦鯨飪賬菮ꏰ雲駴零胸룺鋼釾甀焂樄欆攈渊缌䨎怐昒簔朖椘縚礜䀞怠ဢሤᘦဨᨪ", a_), global::CommonResources.AcgResources.ID_UNIVERSALRELAYCONTROLLEREQUIPPED);
					this.radWideUniversalRelayControllerEquipped_A37191.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideUniversalRelayControllerEquipped_A37191.DataTransferOrder = 130;
					num = (short)1273757703;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1376387075;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_29F;
				IL_79:
				num = (short)11534337;
				if (num != 0)
				{
				}
				num = (short)600244224;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D1:
				num = (short)8388614;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_213:
			num = (short)23134208;
			if (num != 0)
			{
			}
			IL_29F:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓐뷒볔ꇖ볘꧚껜뻞跠쏢럤苦藨諪铬쿮닰鳲鯴菶诸铺釼鏾搀焂", a_);
			base.Id = 10604;
			base.UIName = global::CommonResources.AcgResources.ID_UNIVERSALRELAYCONTROLLER;
			base.DataTransferOrder = 13;
		}

		// Token: 0x06003C65 RID: 15461 RVA: 0x00387BCC File Offset: 0x00385DCC
		public override void PopulateReferences()
		{
			short num = (short)2024079360;
			short num2 = num;
			num = (short)1564019522;
			short num3 = num;
			num = (short)1828719426;
			switch (num3 == num)
			{
			}
			num = (short)532414465;
			if (num != 0)
			{
			}
			num = (short)522321920;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x00387C74 File Offset: 0x00385E74
		public override void DropReferences()
		{
			short num = (short)1117257728;
			short num2 = num;
			num = (short)865109378;
			short num3 = num;
			num = (short)230262146;
			switch (num3 == num)
			{
			}
			num = (short)1455226880;
			if (num != 0)
			{
			}
			num = (short)494993409;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003C67 RID: 15463 RVA: 0x00387D20 File Offset: 0x00385F20
		public override void SetConstraints()
		{
			short num = (short)1048379392;
			short num2 = num;
			num = (short)187308352;
			short num3 = num;
			num = (short)539302208;
			switch (num3 == num)
			{
			}
			num = (short)467730432;
			if (num != 0)
			{
			}
			num = (short)819527681;
			if (num != 0)
			{
			}
			this.radWideUniversalRelayControllerEquipped_A37191.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConRadWideURCIsApp);
			this.radWideUniversalRelayControllerEquipped_A37191.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConRadWideURCIsValid);
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x00387DF8 File Offset: 0x00385FF8
		public override void SetupDependencies()
		{
			short num = (short)477298688;
			short num2 = num;
			num = (short)65517219;
			short num3 = num;
			num = (short)593802915;
			switch (num3 == num)
			{
			}
			num = (short)989265921;
			if (num != 0)
			{
			}
			num = (short)972161024;
			if (num != 0)
			{
			}
			(base.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radWideUniversalRelayControllerEquipped_A37191);
		}

		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x06003C69 RID: 15465 RVA: 0x00387EC4 File Offset: 0x003860C4
		public bool HasDiffs
		{
			get
			{
				short num = (short)1072496640;
				short num2 = num;
				num = (short)1601239478;
				short num3 = num;
				num = (short)302250422;
				switch (num3 == num)
				{
				}
				num = (short)1874329601;
				if (num != 0)
				{
				}
				num = (short)383975424;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x06003C6A RID: 15466 RVA: 0x00387F74 File Offset: 0x00386174
		// (set) Token: 0x06003C6B RID: 15467 RVA: 0x00388028 File Offset: 0x00386228
		public bool RadWideUniversalRelayControllerEquipped_A37191Value
		{
			get
			{
				short num = (short)1786576896;
				short num2 = num;
				num = (short)717804560;
				short num3 = num;
				num = (short)693752848;
				switch (num3 == num)
				{
				}
				num = (short)387710977;
				if (num != 0)
				{
				}
				num = (short)774504448;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerEquipped_A37191.Value;
			}
			set
			{
				short num = (short)558104576;
				short num2 = num;
				num = (short)1127002814;
				short num3 = num;
				num = (short)1252831934;
				switch (num3 == num)
				{
				}
				num = (short)1482883073;
				if (num != 0)
				{
				}
				num = (short)1693974528;
				if (num != 0)
				{
				}
				this.radWideUniversalRelayControllerEquipped_A37191.Value = value;
			}
		}

		// Token: 0x17001EFB RID: 7931
		// (get) Token: 0x06003C6C RID: 15468 RVA: 0x003880DC File Offset: 0x003862DC
		public global::AcpBusinessLayer.AcpField<bool> RadWideUniversalRelayControllerEquipped_A37191
		{
			get
			{
				short num = (short)1453981696;
				short num2 = num;
				num = (short)1606230751;
				short num3 = num;
				num = (short)347153119;
				switch (num3 == num)
				{
				}
				num = (short)817430529;
				if (num != 0)
				{
				}
				num = (short)1327235072;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerEquipped_A37191;
			}
		}

		// Token: 0x17001EFC RID: 7932
		// (get) Token: 0x06003C6D RID: 15469 RVA: 0x0038818C File Offset: 0x0038638C
		// (set) Token: 0x06003C6E RID: 15470 RVA: 0x00388240 File Offset: 0x00386440
		public bool RadWideUniversalRelayControllerEquipped_A37191_UIValue
		{
			get
			{
				short num = (short)984350720;
				short num2 = num;
				num = (short)93318927;
				short num3 = num;
				num = (short)1006563087;
				switch (num3 == num)
				{
				}
				num = (short)1868300289;
				if (num != 0)
				{
				}
				num = (short)740884480;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerEquipped_A37191.Value;
			}
			set
			{
				short num = (short)169410560;
				short num2 = num;
				num = (short)1814758006;
				short num3 = num;
				num = (short)626328182;
				switch (num3 == num)
				{
				}
				num = (short)503119873;
				if (num != 0)
				{
				}
				num = (short)675086336;
				if (num != 0)
				{
				}
				this.radWideUniversalRelayControllerEquipped_A37191.Value = value;
			}
		}

		// Token: 0x17001EFD RID: 7933
		// (get) Token: 0x06003C6F RID: 15471 RVA: 0x003882F4 File Offset: 0x003864F4
		// (set) Token: 0x06003C70 RID: 15472 RVA: 0x003883AC File Offset: 0x003865AC
		public bool RadWideUniversalRelayControllerEquipped_A37191_Applicable
		{
			get
			{
				short num = (short)1385234432;
				short num2 = num;
				num = (short)1103998506;
				short num3 = num;
				num = (short)1220193834;
				switch (num3 == num)
				{
				}
				num = (short)564723712;
				if (num != 0)
				{
				}
				num = (short)327221249;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerEquipped_A37191.Applicable;
			}
			set
			{
				short num = (short)1965359104;
				short num2 = num;
				num = (short)831673495;
				short num3 = num;
				num = (short)1533826199;
				switch (num3 == num)
				{
				}
				num = (short)758317056;
				if (num != 0)
				{
				}
				num = (short)443809793;
				if (num != 0)
				{
				}
				this.radWideUniversalRelayControllerEquipped_A37191.Applicable = value;
			}
		}

		// Token: 0x17001EFE RID: 7934
		// (get) Token: 0x06003C71 RID: 15473 RVA: 0x00388460 File Offset: 0x00386660
		// (set) Token: 0x06003C72 RID: 15474 RVA: 0x00388510 File Offset: 0x00386710
		public bool RadWideUniversalRelayControllerEquipped_A37191_Valid
		{
			get
			{
				short num = (short)1071775744;
				short num2 = num;
				num = (short)884598296;
				short num3 = num;
				num = (short)527951384;
				switch (num3 == num)
				{
				}
				num = (short)2133786625;
				if (num != 0)
				{
				}
				num = (short)7143424;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerEquipped_A37191.Valid;
			}
			set
			{
				short num = (short)1002509451;
				short num2 = num;
				num = (short)1824003211;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1703804928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1275658241;
				if (num != 0)
				{
				}
				num = (short)1558446080;
				if (num != 0)
				{
				}
				this.radWideUniversalRelayControllerEquipped_A37191.Valid = value;
			}
		}

		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x06003C73 RID: 15475 RVA: 0x003885C4 File Offset: 0x003867C4
		// (set) Token: 0x06003C74 RID: 15476 RVA: 0x0038867C File Offset: 0x0038687C
		public bool RadWideUniversalRelayControllerEquipped_A37191_Visible
		{
			get
			{
				short num = (short)1320264180;
				short num2 = num;
				num = (short)440967668;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1861943296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)257622016;
				if (num != 0)
				{
				}
				num = (short)1533280257;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerEquipped_A37191.Visible;
			}
			set
			{
				short num = (short)375422691;
				short num2 = num;
				num = (short)1416855267;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1780350976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2047606784;
				if (num != 0)
				{
				}
				num = (short)28246017;
				if (num != 0)
				{
				}
				this.radWideUniversalRelayControllerEquipped_A37191.Visible = value;
			}
		}

		// Token: 0x17001F00 RID: 7936
		// (get) Token: 0x06003C75 RID: 15477 RVA: 0x00388730 File Offset: 0x00386930
		// (set) Token: 0x06003C76 RID: 15478 RVA: 0x003887E4 File Offset: 0x003869E4
		public bool RadWideUniversalRelayControllerEquipped_A37191_Editable
		{
			get
			{
				short num = (short)1548884143;
				short num2 = num;
				num = (short)1103304879;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1371144192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)536543233;
				if (num != 0)
				{
				}
				num = (short)844365824;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerEquipped_A37191.Editable;
			}
			set
			{
				short num = (short)1272019162;
				short num2 = num;
				num = (short)319715546;
				switch (num2 == num)
				{
				default:
				{
					num = (short)753991680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)266141697;
				if (num != 0)
				{
				}
				num = (short)2128805888;
				if (num != 0)
				{
				}
				this.radWideUniversalRelayControllerEquipped_A37191.Editable = value;
			}
		}

		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x06003C77 RID: 15479 RVA: 0x00388898 File Offset: 0x00386A98
		internal string RadWideUniversalRelayControllerEquipped_A37191_UILabel
		{
			get
			{
				short num = (short)2021771095;
				short num2 = num;
				num = (short)758040407;
				switch (num2 == num)
				{
				default:
				{
					num = (short)278921216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1758527488;
				if (num != 0)
				{
				}
				num = (short)1989345281;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerEquipped_A37191.UIName;
			}
		}

		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x06003C78 RID: 15480 RVA: 0x0038894C File Offset: 0x00386B4C
		// (set) Token: 0x06003C79 RID: 15481 RVA: 0x00388A00 File Offset: 0x00386C00
		internal bool RadWideUniversalRelayControllerEquipped_A37191_HiddenStatic
		{
			get
			{
				short num = (short)1163043923;
				short num2 = num;
				num = (short)1531356243;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1103233024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1458831361;
				if (num != 0)
				{
				}
				num = (short)2036137984;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerEquipped_A37191.HiddenStatic;
			}
			set
			{
				short num = (short)264778510;
				short num2 = num;
				num = (short)1580479246;
				switch (num2 == num)
				{
				default:
				{
					num = (short)498008064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)93454336;
				if (num != 0)
				{
				}
				num = (short)1949499393;
				if (num != 0)
				{
				}
				this.radWideUniversalRelayControllerEquipped_A37191.HiddenStatic = value;
			}
		}

		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x06003C7A RID: 15482 RVA: 0x00388AB8 File Offset: 0x00386CB8
		// (set) Token: 0x06003C7B RID: 15483 RVA: 0x00388B70 File Offset: 0x00386D70
		internal bool RadWideUniversalRelayControllerEquipped_A37191_HiddenDynamic
		{
			get
			{
				short num = (short)554958568;
				short num2 = num;
				num = (short)1148845800;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1078722560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1178468352;
				if (num != 0)
				{
				}
				num = (short)387907585;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerEquipped_A37191.HiddenDynamic;
			}
			set
			{
				short num = (short)24421804;
				short num2 = num;
				num = (short)2128192940;
				switch (num2 == num)
				{
				default:
				{
					num = (short)597098496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)47448064;
				if (num != 0)
				{
				}
				num = (short)1894383617;
				if (num != 0)
				{
				}
				this.radWideUniversalRelayControllerEquipped_A37191.HiddenDynamic = value;
			}
		}

		// Token: 0x17001F04 RID: 7940
		// (get) Token: 0x06003C7C RID: 15484 RVA: 0x00388C24 File Offset: 0x00386E24
		public bool RadWideUniversalRelayControllerEquipped_A37191_HasDiffs
		{
			get
			{
				short num = (short)496435201;
				if (num != 0)
				{
				}
				num = (short)785645568;
				short num2 = num;
				num = (short)1904691531;
				short num3 = num;
				num = (short)231164235;
				switch (num3 == num)
				{
				}
				num = (short)297402368;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerEquipped_A37191._HasDiffs;
			}
		}

		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x06003C7D RID: 15485 RVA: 0x00388CD8 File Offset: 0x00386ED8
		// (set) Token: 0x06003C7E RID: 15486 RVA: 0x00388D8C File Offset: 0x00386F8C
		public bool RadWideUniversalRelayControllerFatalError_A37194Value
		{
			get
			{
				short num = (short)571939587;
				short num2 = num;
				num = (short)1191975683;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1653014528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1242890241;
				if (num != 0)
				{
				}
				num = (short)1551761408;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerFatalError_A37194.Value;
			}
			set
			{
				short num = (short)881317203;
				short num2 = num;
				num = (short)1370674515;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1432748032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)236716033;
				if (num != 0)
				{
				}
				num = (short)1778450432;
				if (num != 0)
				{
				}
				this.radWideUniversalRelayControllerFatalError_A37194.Value = value;
			}
		}

		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x06003C7F RID: 15487 RVA: 0x00388E40 File Offset: 0x00387040
		public global::AcpBusinessLayer.AcpField<bool> RadWideUniversalRelayControllerFatalError_A37194
		{
			get
			{
				short num = (short)997392385;
				if (num != 0)
				{
				}
				num = (short)289406976;
				short num2 = num;
				num = (short)460859671;
				short num3 = num;
				num = (short)1874733335;
				switch (num3 == num)
				{
				}
				num = (short)724697088;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerFatalError_A37194;
			}
		}

		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x06003C80 RID: 15488 RVA: 0x00388EF0 File Offset: 0x003870F0
		// (set) Token: 0x06003C81 RID: 15489 RVA: 0x00388FA4 File Offset: 0x003871A4
		public bool RadWideUniversalRelayControllerFatalError_A37194_UIValue
		{
			get
			{
				short num = (short)2039486250;
				short num2 = num;
				num = (short)391911210;
				switch (num2 == num)
				{
				default:
				{
					num = (short)191627264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)989265921;
				if (num != 0)
				{
				}
				num = (short)799735808;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerFatalError_A37194.Value;
			}
			set
			{
				short num = (short)709144489;
				short num2 = num;
				num = (short)452374441;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1390804992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1246429184;
				if (num != 0)
				{
				}
				num = (short)441122817;
				if (num != 0)
				{
				}
				this.radWideUniversalRelayControllerFatalError_A37194.Value = value;
			}
		}

		// Token: 0x17001F08 RID: 7944
		// (get) Token: 0x06003C82 RID: 15490 RVA: 0x0038905C File Offset: 0x0038725C
		// (set) Token: 0x06003C83 RID: 15491 RVA: 0x00389110 File Offset: 0x00387310
		public bool RadWideUniversalRelayControllerFatalError_A37194_Applicable
		{
			get
			{
				short num = (short)220029134;
				short num2 = num;
				num = (short)2071879886;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1971912704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1398145024;
				if (num != 0)
				{
				}
				num = (short)1896349697;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerFatalError_A37194.Applicable;
			}
			set
			{
				short num = (short)1755134710;
				short num2 = num;
				num = (short)270547702;
				switch (num2 == num)
				{
				default:
				{
					num = (short)807534592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1002635265;
				if (num != 0)
				{
				}
				num = (short)852951040;
				if (num != 0)
				{
				}
				this.radWideUniversalRelayControllerFatalError_A37194.Applicable = value;
			}
		}

		// Token: 0x17001F09 RID: 7945
		// (get) Token: 0x06003C84 RID: 15492 RVA: 0x003891C8 File Offset: 0x003873C8
		// (set) Token: 0x06003C85 RID: 15493 RVA: 0x0038927C File Offset: 0x0038747C
		public bool RadWideUniversalRelayControllerFatalError_A37194_Valid
		{
			get
			{
				short num = (short)481361921;
				if (num != 0)
				{
				}
				num = (short)1448673280;
				short num2 = num;
				num = (short)667596854;
				short num3 = num;
				num = (short)1561573430;
				switch (num3 == num)
				{
				}
				num = (short)1223884800;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerFatalError_A37194.Valid;
			}
			set
			{
				short num = (short)1055653889;
				if (num != 0)
				{
				}
				num = (short)1860370432;
				short num2 = num;
				num = (short)1948912236;
				short num3 = num;
				num = (short)1197607532;
				switch (num3 == num)
				{
				}
				num = (short)482410496;
				if (num != 0)
				{
				}
				this.radWideUniversalRelayControllerFatalError_A37194.Valid = value;
			}
		}

		// Token: 0x17001F0A RID: 7946
		// (get) Token: 0x06003C86 RID: 15494 RVA: 0x00389330 File Offset: 0x00387530
		// (set) Token: 0x06003C87 RID: 15495 RVA: 0x003893E4 File Offset: 0x003875E4
		public bool RadWideUniversalRelayControllerFatalError_A37194_Visible
		{
			get
			{
				short num = (short)776351312;
				short num2 = num;
				num = (short)459026000;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2128150528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)718274561;
				if (num != 0)
				{
				}
				num = (short)1748500480;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerFatalError_A37194.Visible;
			}
			set
			{
				short num = (short)2075787265;
				if (num != 0)
				{
				}
				num = (short)220463104;
				short num2 = num;
				num = (short)1918922202;
				short num3 = num;
				num = (short)2145480154;
				switch (num3 == num)
				{
				}
				num = (short)153092096;
				if (num != 0)
				{
				}
				this.radWideUniversalRelayControllerFatalError_A37194.Visible = value;
			}
		}

		// Token: 0x17001F0B RID: 7947
		// (get) Token: 0x06003C88 RID: 15496 RVA: 0x0038949C File Offset: 0x0038769C
		// (set) Token: 0x06003C89 RID: 15497 RVA: 0x00389550 File Offset: 0x00387750
		public bool RadWideUniversalRelayControllerFatalError_A37194_Editable
		{
			get
			{
				short num = (short)1633288193;
				if (num != 0)
				{
				}
				num = (short)245497856;
				short num2 = num;
				num = (short)1997155272;
				short num3 = num;
				num = (short)1032727496;
				switch (num3 == num)
				{
				}
				num = (short)477757440;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerFatalError_A37194.Editable;
			}
			set
			{
				short num = (short)1466695680;
				short num2 = num;
				num = (short)672972611;
				short num3 = num;
				num = (short)226475843;
				switch (num3 == num)
				{
				}
				num = (short)1270874113;
				if (num != 0)
				{
				}
				num = (short)117112832;
				if (num != 0)
				{
				}
				this.radWideUniversalRelayControllerFatalError_A37194.Editable = value;
			}
		}

		// Token: 0x17001F0C RID: 7948
		// (get) Token: 0x06003C8A RID: 15498 RVA: 0x00389604 File Offset: 0x00387804
		internal string RadWideUniversalRelayControllerFatalError_A37194_UILabel
		{
			get
			{
				short num = (short)916848640;
				short num2 = num;
				num = (short)154877668;
				short num3 = num;
				num = (short)1785085668;
				switch (num3 == num)
				{
				}
				num = (short)1557266433;
				if (num != 0)
				{
				}
				num = (short)786038784;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerFatalError_A37194.UIName;
			}
		}

		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x06003C8B RID: 15499 RVA: 0x003896BC File Offset: 0x003878BC
		// (set) Token: 0x06003C8C RID: 15500 RVA: 0x00389774 File Offset: 0x00387974
		internal bool RadWideUniversalRelayControllerFatalError_A37194_HiddenStatic
		{
			get
			{
				short num = (short)1983840256;
				short num2 = num;
				num = (short)1832651427;
				short num3 = num;
				num = (short)1409944227;
				switch (num3 == num)
				{
				}
				num = (short)1086652416;
				if (num != 0)
				{
				}
				num = (short)747765761;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerFatalError_A37194.HiddenStatic;
			}
			set
			{
				short num = (short)768212992;
				short num2 = num;
				num = (short)62471001;
				short num3 = num;
				num = (short)1827814233;
				switch (num3 == num)
				{
				}
				num = (short)999292929;
				if (num != 0)
				{
				}
				num = (short)1346830336;
				if (num != 0)
				{
				}
				this.radWideUniversalRelayControllerFatalError_A37194.HiddenStatic = value;
			}
		}

		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x06003C8D RID: 15501 RVA: 0x0038982C File Offset: 0x00387A2C
		// (set) Token: 0x06003C8E RID: 15502 RVA: 0x003898E0 File Offset: 0x00387AE0
		internal bool RadWideUniversalRelayControllerFatalError_A37194_HiddenDynamic
		{
			get
			{
				short num = (short)1514274816;
				short num2 = num;
				num = (short)1907789151;
				short num3 = num;
				num = (short)191270239;
				switch (num3 == num)
				{
				}
				num = (short)830865409;
				if (num != 0)
				{
				}
				num = (short)1419902976;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerFatalError_A37194.HiddenDynamic;
			}
			set
			{
				short num = (short)1929248768;
				short num2 = num;
				num = (short)741486254;
				short num3 = num;
				num = (short)338308782;
				switch (num3 == num)
				{
				}
				num = (short)804061185;
				if (num != 0)
				{
				}
				num = (short)361627648;
				if (num != 0)
				{
				}
				this.radWideUniversalRelayControllerFatalError_A37194.HiddenDynamic = value;
			}
		}

		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x06003C8F RID: 15503 RVA: 0x00389998 File Offset: 0x00387B98
		public bool RadWideUniversalRelayControllerFatalError_A37194_HasDiffs
		{
			get
			{
				short num = (short)507117568;
				short num2 = num;
				num = (short)1535660112;
				short num3 = num;
				num = (short)1225674832;
				switch (num3 == num)
				{
				}
				num = (short)822870017;
				if (num != 0)
				{
				}
				num = (short)1356660736;
				if (num != 0)
				{
				}
				return this.radWideUniversalRelayControllerFatalError_A37194._HasDiffs;
			}
		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x00389A4C File Offset: 0x00387C4C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
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
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (base.ParentRecset != null)
						{
							num2 = (short)439025665;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 1:
					{
						num2 = (short)1431175168;
						short num3 = num2;
						num2 = (short)1838612484;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
					{
						num2 = (short)297505948;
						short num4 = num2;
						num2 = (short)1567855772;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)805240833;
							if (num2 != 0)
							{
							}
							num2 = (short)1375731712;
							if (num2 != 0)
							{
							}
							result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
							num2 = (short)1122107395;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						return result;
					case 4:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)421593090;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				IL_24:
				result = null;
				num2 = (short)1961295872;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x0400120B RID: 4619
		private global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset innerRecset;

		// Token: 0x0400120C RID: 4620
		private global::AcpBusinessLayer.AcpField<bool> radWideUniversalRelayControllerEquipped_A37191;

		// Token: 0x0400120D RID: 4621
		private global::AcpBusinessLayer.AcpField<bool> radWideUniversalRelayControllerFatalError_A37194;
	}
}
