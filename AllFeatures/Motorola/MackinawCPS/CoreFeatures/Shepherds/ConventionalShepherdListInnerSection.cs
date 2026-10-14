using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001CF RID: 463
	[global::System.Serializable]
	public class ConventionalShepherdListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06005358 RID: 21336 RVA: 0x004B9EDC File Offset: 0x004B80DC
		public ConventionalShepherdListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06005359 RID: 21337 RVA: 0x004B9EF8 File Offset: 0x004B80F8
		protected ConventionalShepherdListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600535A RID: 21338 RVA: 0x004B9F10 File Offset: 0x004B8110
		public override void Init()
		{
			int a_ = 5;
			short num = (short)231776809;
			short num2 = num;
			num = (short)1561895465;
			switch (num2 == num)
			{
			}
			num = (short)1000079361;
			if (num != 0)
			{
			}
			num = (short)1061093376;
			if (num != 0)
			{
			}
			num = (short)1893072896;
			short num3 = num;
			this.radErgoCfgCnvBtnListKey_A21175 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗駙닛꣝ꋟ雡諣ꫥ臧駩飫ꗭ闯诱꯳럵쫷쯹췻짽㗿", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBUTTONLISTKEY, 14);
			this.radErgoCfgCnvBtnListKey_A21175.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgCnvBtnListKey_A21175.DataTransferOrder = -1;
			this.radErgoCfgCnvBtnListID_A21376 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗駙닛꣝ꋟ雡諣ꫥ臧駩飫꟭듯귱뗳쓵짷짹쯻죽", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBUTTONLISTID, 0, 65535, null, null, 0, 1);
			this.radErgoCfgCnvBtnListID_A21376.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgCnvBtnListID_A21376.DataTransferOrder = -1;
			this.radErgoCfgCnvBtnListID_A21376.ShowHexValue = false;
			this.radErgoCfgCnvBtnListType_A21164 = new global::AcpBusinessLayer.AcpSparseLOVField(1008, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.indexRadErgoCfgCnvBtnListType_A21164LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.idRadErgoCfgCnvBtnListType_A21164LovStrs), this, global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗駙닛꣝ꋟ雡諣ꫥ臧駩飫뫭觯英釳꧵맷죹췻쿽㛿㘁", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBUTTONLISTTYPE, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.RadErgoCfgCnvBtnListType_A21164LovStrs);
			this.radErgoCfgCnvBtnListType_A21164.IgnoreOnCompare = true;
			this.radErgoCfgCnvBtnListType_A21164.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgCnvBtnListType_A21164.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藅Ꟈ꓉뫋ꯍ뻏ꛑ뷓맕뛗믙냛ﻝ돟諡臣雥胧迩黫諭탯뻱鷳藵賷", a_);
			base.Id = 10036;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALSHEPHERDLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600535B RID: 21339 RVA: 0x004BA0D8 File Offset: 0x004B82D8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)943980549;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1481113608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1911146882;
					short num3 = num;
					num = (short)1130678658;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_241;
					default:
						num = (short)547094528;
						if (num != 0)
						{
						}
						this.radErgoCfgCnvBtnListKey_A21175 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋词ꋏ뗑믓闕뻗뷙鿛냝雟ꃡ郣裥ꓧ菩鿫髭믯韱跳꧵맷죹췻쿽㟿㜁", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBUTTONLISTKEY, 14);
						this.radErgoCfgCnvBtnListKey_A21175.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.radErgoCfgCnvBtnListKey_A21175.DataTransferOrder = -1;
						num = (short)1061814281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋词ꋏ뗑믓闕뻗뷙鿛냝雟ꃡ郣裥ꓧ菩鿫髭ꓯ诱蓳鏵ꟷ믹컻쿽ㇿ㐁〃", a_)))
					{
						num = (short)2099183623;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_373;
				case 3:
					if (producerFields != null)
					{
						goto IL_241;
					}
					goto IL_373;
				case 4:
				{
					num = (short)979566592;
					short num4 = num;
					this.radErgoCfgCnvBtnListID_A21376 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋词ꋏ뗑믓闕뻗뷙鿛냝雟ꃡ郣裥ꓧ菩鿫髭맯뛱꯳럵쫷쯹쿻짽㛿", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBUTTONLISTID, null, null, 0, 1);
					this.radErgoCfgCnvBtnListID_A21376.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgCnvBtnListID_A21376.DataTransferOrder = -1;
					this.radErgoCfgCnvBtnListID_A21376.ShowHexValue = false;
					num = (short)1026293766;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 6:
					goto IL_25D;
				case 7:
					num = (short)364249089;
					if (num != 0)
					{
					}
					this.radErgoCfgCnvBtnListType_A21164 = new global::AcpBusinessLayer.AcpSparseLOVField(1008, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.indexRadErgoCfgCnvBtnListType_A21164LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.idRadErgoCfgCnvBtnListType_A21164LovStrs), this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋词ꋏ뗑믓闕뻗뷙鿛냝雟ꃡ郣裥ꓧ菩鿫髭ꓯ诱蓳鏵ꟷ믹컻쿽ㇿ㐁〃", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBUTTONLISTTYPE, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.RadErgoCfgCnvBtnListType_A21164LovStrs);
					this.radErgoCfgCnvBtnListType_A21164.IgnoreOnCompare = true;
					this.radErgoCfgCnvBtnListType_A21164.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgCnvBtnListType_A21164.DataTransferOrder = -1;
					num = (short)6225931;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋词ꋏ뗑믓闕뻗뷙鿛냝雟ꃡ郣裥ꓧ菩鿫髭믯韱跳꧵맷죹췻쿽㟿㜁", a_)))
					{
						num = (short)646184961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_115;
				case 9:
					goto IL_115;
				case 10:
					num = (short)1304428547;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_21F;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋词ꋏ뗑믓闕뻗뷙鿛냝雟ꃡ郣裥ꓧ菩鿫髭맯뛱꯳럵쫷쯹쿻짽㛿", a_)))
					{
						num = (short)1676738564;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25D;
				}
				IL_62:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)871497738;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_115:
				num = (short)1059848204;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_241:
				num = (short)867106816;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_25D:
				num = (short)584712194;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_21F:
			IL_373:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("诇ꗉꋋ룍뗏병ꃓ뿕럗듙뷛닝샟뇡賣菥飧苩觫鳭铯틱룳鿵请軹", a_);
			base.Id = 10036;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALSHEPHERDLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600535C RID: 21340 RVA: 0x004BA48C File Offset: 0x004B868C
		public override void PopulateReferences()
		{
			short num = (short)411735194;
			short num2 = num;
			num = (short)1215534234;
			switch (num2 == num)
			{
			}
			num = (short)1540751360;
			if (num != 0)
			{
			}
			num = (short)385875969;
			if (num != 0)
			{
			}
			num = (short)1792802816;
			short num3 = num;
		}

		// Token: 0x0600535D RID: 21341 RVA: 0x004BA534 File Offset: 0x004B8734
		public override void DropReferences()
		{
			short num = (short)1880689037;
			short num2 = num;
			num = (short)1342769549;
			switch (num2 == num)
			{
			}
			num = (short)1521221633;
			if (num != 0)
			{
			}
			num = (short)1459814400;
			if (num != 0)
			{
			}
			num = (short)1097334784;
			short num3 = num;
		}

		// Token: 0x0600535E RID: 21342 RVA: 0x004BA5DC File Offset: 0x004B87DC
		public override void SetConstraints()
		{
			short num = (short)1936022061;
			short num2 = num;
			num = (short)122116653;
			switch (num2 == num)
			{
			}
			num = (short)1362690049;
			if (num != 0)
			{
			}
			num = (short)437190656;
			if (num != 0)
			{
			}
			num = (short)905641984;
			short num3 = num;
			this.radErgoCfgCnvBtnListID_A21376.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x0600535F RID: 21343 RVA: 0x004BA6A0 File Offset: 0x004B88A0
		public override void SetupDependencies()
		{
			short num = (short)627929769;
			short num2 = num;
			num = (short)1607496361;
			switch (num2 == num)
			{
			}
			num = (short)1965031425;
			if (num != 0)
			{
			}
			num = (short)1484914688;
			if (num != 0)
			{
			}
			num = (short)435093504;
			short num3 = num;
		}

		// Token: 0x17002B26 RID: 11046
		// (get) Token: 0x06005360 RID: 21344 RVA: 0x004BA748 File Offset: 0x004B8948
		public bool HasDiffs
		{
			get
			{
				short num = (short)1808218259;
				short num2 = num;
				num = (short)864630931;
				switch (num2 == num)
				{
				}
				num = (short)515964928;
				if (num != 0)
				{
				}
				num = (short)1661599745;
				if (num != 0)
				{
				}
				num = (short)398000128;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17002B27 RID: 11047
		// (get) Token: 0x06005361 RID: 21345 RVA: 0x004BA7F8 File Offset: 0x004B89F8
		// (set) Token: 0x06005362 RID: 21346 RVA: 0x004BA8AC File Offset: 0x004B8AAC
		public string RadErgoCfgCnvBtnListKey_A21175Value
		{
			get
			{
				short num = (short)2120145190;
				short num2 = num;
				num = (short)475257126;
				switch (num2 == num)
				{
				}
				num = (short)1442643968;
				if (num != 0)
				{
				}
				num = (short)1109983233;
				if (num != 0)
				{
				}
				num = (short)218824704;
				short num3 = num;
				return this.radErgoCfgCnvBtnListKey_A21175.Value;
			}
			set
			{
				short num = (short)1481834498;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_EF;
					case 1:
					{
						num = (short)1617718976;
						short num3 = num;
						num = (short)492990144;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_EF;
						default:
							num = (short)2133065728;
							if (num != 0)
							{
							}
							num = (short)1193672705;
							if (num != 0)
							{
							}
							this.radErgoCfgCnvBtnListKey_A21175.Value = value;
							num = (short)548667392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					}
					IL_32:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)1154154497;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_EF:
				num = (short)1456537600;
				short num4 = num;
			}
		}

		// Token: 0x17002B28 RID: 11048
		// (get) Token: 0x06005363 RID: 21347 RVA: 0x004BA9D4 File Offset: 0x004B8BD4
		// (set) Token: 0x06005364 RID: 21348 RVA: 0x004BAA88 File Offset: 0x004B8C88
		public string RadErgoCfgCnvBtnListKey_A21175_UIValue
		{
			get
			{
				short num = (short)264765441;
				if (num != 0)
				{
				}
				num = (short)319784753;
				short num2 = num;
				num = (short)1922598705;
				switch (num2 == num)
				{
				}
				num = (short)922157056;
				if (num != 0)
				{
				}
				num = (short)1018298368;
				short num3 = num;
				return this.radErgoCfgCnvBtnListKey_A21175.Value;
			}
			set
			{
				short num = (short)921047319;
				short num2 = num;
				num = (short)497881367;
				switch (num2 == num)
				{
				}
				num = (short)1028521985;
				if (num != 0)
				{
				}
				num = (short)1131085824;
				if (num != 0)
				{
				}
				num = (short)935723008;
				short num3 = num;
				this.radErgoCfgCnvBtnListKey_A21175.Value = value;
			}
		}

		// Token: 0x17002B29 RID: 11049
		// (get) Token: 0x06005365 RID: 21349 RVA: 0x004BAB40 File Offset: 0x004B8D40
		public global::AcpBusinessLayer.AcpKeyField RadErgoCfgCnvBtnListKey_A21175
		{
			get
			{
				short num = (short)803209775;
				short num2 = num;
				num = (short)443286063;
				switch (num2 == num)
				{
				}
				num = (short)415694848;
				if (num != 0)
				{
				}
				num = (short)694353921;
				if (num != 0)
				{
				}
				num = (short)1028325376;
				short num3 = num;
				return this.radErgoCfgCnvBtnListKey_A21175;
			}
		}

		// Token: 0x17002B2A RID: 11050
		// (get) Token: 0x06005366 RID: 21350 RVA: 0x004BABF0 File Offset: 0x004B8DF0
		// (set) Token: 0x06005367 RID: 21351 RVA: 0x004BACA4 File Offset: 0x004B8EA4
		public bool RadErgoCfgCnvBtnListKey_A21175_Applicable
		{
			get
			{
				short num = (short)516026517;
				short num2 = num;
				num = (short)314896533;
				switch (num2 == num)
				{
				}
				num = (short)1780744193;
				if (num != 0)
				{
				}
				num = (short)777912320;
				if (num != 0)
				{
				}
				num = (short)2082406400;
				short num3 = num;
				return this.radErgoCfgCnvBtnListKey_A21175.Applicable;
			}
			set
			{
				short num = (short)1877497819;
				short num2 = num;
				num = (short)267540443;
				switch (num2 == num)
				{
				}
				num = (short)2033385473;
				if (num != 0)
				{
				}
				num = (short)1288175616;
				if (num != 0)
				{
				}
				num = (short)1533411328;
				short num3 = num;
				this.radErgoCfgCnvBtnListKey_A21175.Applicable = value;
			}
		}

		// Token: 0x17002B2B RID: 11051
		// (get) Token: 0x06005368 RID: 21352 RVA: 0x004BAD58 File Offset: 0x004B8F58
		// (set) Token: 0x06005369 RID: 21353 RVA: 0x004BAE10 File Offset: 0x004B9010
		public bool RadErgoCfgCnvBtnListKey_A21175_Valid
		{
			get
			{
				short num = (short)1682007067;
				short num2 = num;
				num = (short)171336731;
				switch (num2 == num)
				{
				}
				num = (short)358023169;
				if (num != 0)
				{
				}
				num = (short)941555712;
				if (num != 0)
				{
				}
				num = (short)408289280;
				short num3 = num;
				return this.radErgoCfgCnvBtnListKey_A21175.Valid;
			}
			set
			{
				short num = (short)283402730;
				short num2 = num;
				num = (short)1266573802;
				switch (num2 == num)
				{
				}
				num = (short)1363542016;
				if (num != 0)
				{
				}
				num = (short)88735744;
				short num3 = num;
				num = (short)55312385;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListKey_A21175.Valid = value;
			}
		}

		// Token: 0x17002B2C RID: 11052
		// (get) Token: 0x0600536A RID: 21354 RVA: 0x004BAEC4 File Offset: 0x004B90C4
		// (set) Token: 0x0600536B RID: 21355 RVA: 0x004BAF78 File Offset: 0x004B9178
		public bool RadErgoCfgCnvBtnListKey_A21175_Visible
		{
			get
			{
				short num = (short)1471952108;
				short num2 = num;
				num = (short)1809069292;
				switch (num2 == num)
				{
				}
				num = (short)1792868352;
				if (num != 0)
				{
				}
				num = (short)1023016960;
				short num3 = num;
				num = (short)1239547905;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListKey_A21175.Visible;
			}
			set
			{
				short num = (short)210131843;
				short num2 = num;
				num = (short)606821251;
				switch (num2 == num)
				{
				}
				num = (short)281739265;
				if (num != 0)
				{
				}
				num = (short)1018888192;
				short num3 = num;
				num = (short)188350464;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListKey_A21175.Visible = value;
			}
		}

		// Token: 0x17002B2D RID: 11053
		// (get) Token: 0x0600536C RID: 21356 RVA: 0x004BB030 File Offset: 0x004B9230
		// (set) Token: 0x0600536D RID: 21357 RVA: 0x004BB0E8 File Offset: 0x004B92E8
		public bool RadErgoCfgCnvBtnListKey_A21175_Editable
		{
			get
			{
				short num = (short)1833836553;
				short num2 = num;
				num = (short)787750921;
				switch (num2 == num)
				{
				}
				num = (short)249888768;
				if (num != 0)
				{
				}
				num = (short)1433272320;
				short num3 = num;
				num = (short)300613633;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListKey_A21175.Editable;
			}
			set
			{
				short num = (short)1929118229;
				short num2 = num;
				num = (short)1495728661;
				switch (num2 == num)
				{
				}
				num = (short)1490878465;
				if (num != 0)
				{
				}
				num = (short)37421056;
				short num3 = num;
				num = (short)1697185792;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListKey_A21175.Editable = value;
			}
		}

		// Token: 0x17002B2E RID: 11054
		// (get) Token: 0x0600536E RID: 21358 RVA: 0x004BB19C File Offset: 0x004B939C
		internal string RadErgoCfgCnvBtnListKey_A21175_UILabel
		{
			get
			{
				short num = (short)501825026;
				short num2 = num;
				num = (short)1312767490;
				switch (num2 == num)
				{
				}
				num = (short)1336279041;
				if (num != 0)
				{
				}
				num = (short)1276313600;
				short num3 = num;
				num = (short)844431360;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListKey_A21175.UIName;
			}
		}

		// Token: 0x17002B2F RID: 11055
		// (get) Token: 0x0600536F RID: 21359 RVA: 0x004BB254 File Offset: 0x004B9454
		// (set) Token: 0x06005370 RID: 21360 RVA: 0x004BB30C File Offset: 0x004B950C
		internal bool RadErgoCfgCnvBtnListKey_A21175_HiddenStatic
		{
			get
			{
				short num = (short)1048464106;
				short num2 = num;
				num = (short)396577514;
				switch (num2 == num)
				{
				}
				num = (short)1816002561;
				if (num != 0)
				{
				}
				num = (short)1986527232;
				short num3 = num;
				num = (short)718995456;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListKey_A21175.HiddenStatic;
			}
			set
			{
				short num = (short)846469727;
				short num2 = num;
				num = (short)1780554335;
				switch (num2 == num)
				{
				}
				num = (short)2018705408;
				if (num != 0)
				{
				}
				num = (short)1500053504;
				short num3 = num;
				num = (short)1138229249;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListKey_A21175.HiddenStatic = value;
			}
		}

		// Token: 0x17002B30 RID: 11056
		// (get) Token: 0x06005371 RID: 21361 RVA: 0x004BB3C4 File Offset: 0x004B95C4
		// (set) Token: 0x06005372 RID: 21362 RVA: 0x004BB478 File Offset: 0x004B9678
		internal bool RadErgoCfgCnvBtnListKey_A21175_HiddenDynamic
		{
			get
			{
				short num = (short)1534712052;
				short num2 = num;
				num = (short)1980618996;
				switch (num2 == num)
				{
				}
				num = (short)1303576576;
				if (num != 0)
				{
				}
				num = (short)333512704;
				short num3 = num;
				num = (short)1370292225;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListKey_A21175.HiddenDynamic;
			}
			set
			{
				short num = (short)233106097;
				short num2 = num;
				num = (short)1235610289;
				switch (num2 == num)
				{
				}
				num = (short)407371777;
				if (num != 0)
				{
				}
				num = (short)396427264;
				short num3 = num;
				num = (short)2033713152;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListKey_A21175.HiddenDynamic = value;
			}
		}

		// Token: 0x17002B31 RID: 11057
		// (get) Token: 0x06005373 RID: 21363 RVA: 0x004BB52C File Offset: 0x004B972C
		public bool RadErgoCfgCnvBtnListKey_A21175_HasDiffs
		{
			get
			{
				short num = (short)1635900076;
				short num2 = num;
				num = (short)31120044;
				switch (num2 == num)
				{
				}
				num = (short)816381953;
				if (num != 0)
				{
				}
				num = (short)5767168;
				short num3 = num;
				num = (short)989200384;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListKey_A21175._HasDiffs;
			}
		}

		// Token: 0x17002B32 RID: 11058
		// (get) Token: 0x06005374 RID: 21364 RVA: 0x004BB5E0 File Offset: 0x004B97E0
		// (set) Token: 0x06005375 RID: 21365 RVA: 0x004BB698 File Offset: 0x004B9898
		public int RadErgoCfgCnvBtnListID_A21376Value
		{
			get
			{
				short num = (short)427389783;
				short num2 = num;
				num = (short)922776407;
				switch (num2 == num)
				{
				}
				num = (short)1604845569;
				if (num != 0)
				{
				}
				num = (short)1363673088;
				short num3 = num;
				num = (short)1860239360;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListID_A21376.Value;
			}
			set
			{
				short num = (short)287361051;
				short num2 = num;
				num = (short)2021050395;
				switch (num2 == num)
				{
				}
				num = (short)465633280;
				if (num != 0)
				{
				}
				num = (short)1653145600;
				short num3 = num;
				num = (short)2006843393;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListID_A21376.Value = value;
			}
		}

		// Token: 0x17002B33 RID: 11059
		// (get) Token: 0x06005376 RID: 21366 RVA: 0x004BB750 File Offset: 0x004B9950
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgCnvBtnListID_A21376
		{
			get
			{
				short num = (short)425812739;
				short num2 = num;
				num = (short)1196647171;
				switch (num2 == num)
				{
				}
				num = (short)1003880449;
				if (num != 0)
				{
				}
				num = (short)1443037184;
				short num3 = num;
				num = (short)644546560;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListID_A21376;
			}
		}

		// Token: 0x17002B34 RID: 11060
		// (get) Token: 0x06005377 RID: 21367 RVA: 0x004BB800 File Offset: 0x004B9A00
		// (set) Token: 0x06005378 RID: 21368 RVA: 0x004BB8B4 File Offset: 0x004B9AB4
		public string RadErgoCfgCnvBtnListID_A21376_UIValue
		{
			get
			{
				short num = (short)1205675647;
				short num2 = num;
				num = (short)1495213695;
				switch (num2 == num)
				{
				}
				num = (short)1340669952;
				if (num != 0)
				{
				}
				num = (short)356909056;
				short num3 = num;
				num = (short)1744240641;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListID_A21376.UIValue;
			}
			set
			{
				short num = (short)1092373899;
				short num2 = num;
				num = (short)582831499;
				switch (num2 == num)
				{
				}
				num = (short)2109341697;
				if (num != 0)
				{
				}
				num = (short)410124288;
				short num3 = num;
				num = (short)1356201984;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListID_A21376.UIValue = value;
			}
		}

		// Token: 0x17002B35 RID: 11061
		// (get) Token: 0x06005379 RID: 21369 RVA: 0x004BB968 File Offset: 0x004B9B68
		// (set) Token: 0x0600537A RID: 21370 RVA: 0x004BBA1C File Offset: 0x004B9C1C
		internal int RadErgoCfgCnvBtnListID_A21376Min
		{
			get
			{
				short num = (short)674631632;
				short num2 = num;
				num = (short)1526206416;
				switch (num2 == num)
				{
				}
				num = (short)146341889;
				if (num != 0)
				{
				}
				num = (short)243728384;
				short num3 = num;
				num = (short)1107951616;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListID_A21376.Min;
			}
			set
			{
				short num = (short)1712950151;
				short num2 = num;
				num = (short)1450740615;
				switch (num2 == num)
				{
				}
				num = (short)1767112704;
				if (num != 0)
				{
				}
				num = (short)1824391168;
				short num3 = num;
				num = (short)895746049;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListID_A21376.Min = value;
			}
		}

		// Token: 0x17002B36 RID: 11062
		// (get) Token: 0x0600537B RID: 21371 RVA: 0x004BBAD0 File Offset: 0x004B9CD0
		// (set) Token: 0x0600537C RID: 21372 RVA: 0x004BBB84 File Offset: 0x004B9D84
		internal int RadErgoCfgCnvBtnListID_A21376Max
		{
			get
			{
				short num = (short)408582084;
				short num2 = num;
				num = (short)1601271748;
				switch (num2 == num)
				{
				}
				num = (short)141033472;
				if (num != 0)
				{
				}
				num = (short)519110656;
				short num3 = num;
				num = (short)1424228353;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListID_A21376.Max;
			}
			set
			{
				short num = (short)1524630687;
				short num2 = num;
				num = (short)515310751;
				switch (num2 == num)
				{
				}
				num = (short)1144586241;
				if (num != 0)
				{
				}
				num = (short)1069088768;
				short num3 = num;
				num = (short)809369600;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListID_A21376.Max = value;
			}
		}

		// Token: 0x17002B37 RID: 11063
		// (get) Token: 0x0600537D RID: 21373 RVA: 0x004BBC3C File Offset: 0x004B9E3C
		// (set) Token: 0x0600537E RID: 21374 RVA: 0x004BBCF0 File Offset: 0x004B9EF0
		internal int RadErgoCfgCnvBtnListID_A21376Step
		{
			get
			{
				short num = (short)950222846;
				short num2 = num;
				num = (short)377831422;
				switch (num2 == num)
				{
				}
				num = (short)352976897;
				if (num != 0)
				{
				}
				num = (short)974651392;
				short num3 = num;
				num = (short)1214906368;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListID_A21376.StepSize;
			}
			set
			{
				short num = (short)105805458;
				short num2 = num;
				num = (short)1983018642;
				switch (num2 == num)
				{
				}
				num = (short)2018574337;
				if (num != 0)
				{
				}
				num = (short)734396416;
				short num3 = num;
				num = (short)85524480;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListID_A21376.StepSize = value;
			}
		}

		// Token: 0x17002B38 RID: 11064
		// (get) Token: 0x0600537F RID: 21375 RVA: 0x004BBDA4 File Offset: 0x004B9FA4
		// (set) Token: 0x06005380 RID: 21376 RVA: 0x004BBE58 File Offset: 0x004BA058
		public bool RadErgoCfgCnvBtnListID_A21376_Applicable
		{
			get
			{
				short num = (short)71117408;
				short num2 = num;
				num = (short)54405728;
				switch (num2 == num)
				{
				}
				num = (short)1559756801;
				if (num != 0)
				{
				}
				num = (short)850853888;
				short num3 = num;
				num = (short)1478295552;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListID_A21376.Applicable;
			}
			set
			{
				short num = (short)1530452624;
				short num2 = num;
				num = (short)2094717584;
				switch (num2 == num)
				{
				}
				num = (short)555286529;
				if (num != 0)
				{
				}
				num = (short)1486749696;
				short num3 = num;
				num = (short)524288000;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListID_A21376.Applicable = value;
			}
		}

		// Token: 0x17002B39 RID: 11065
		// (get) Token: 0x06005381 RID: 21377 RVA: 0x004BBF10 File Offset: 0x004BA110
		// (set) Token: 0x06005382 RID: 21378 RVA: 0x004BBFC4 File Offset: 0x004BA1C4
		public bool RadErgoCfgCnvBtnListID_A21376_Valid
		{
			get
			{
				short num = (short)946229694;
				short num2 = num;
				num = (short)569463230;
				switch (num2 == num)
				{
				}
				num = (short)556466176;
				if (num != 0)
				{
				}
				num = (short)2100887552;
				short num3 = num;
				num = (short)1412300801;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListID_A21376.Valid;
			}
			set
			{
				short num = (short)1263730689;
				if (num != 0)
				{
				}
				num = (short)1567650775;
				short num2 = num;
				num = (short)1359508439;
				switch (num2 == num)
				{
				}
				num = (short)680263680;
				short num3 = num;
				num = (short)733151232;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListID_A21376.Valid = value;
			}
		}

		// Token: 0x17002B3A RID: 11066
		// (get) Token: 0x06005383 RID: 21379 RVA: 0x004BC078 File Offset: 0x004BA278
		// (set) Token: 0x06005384 RID: 21380 RVA: 0x004BC12C File Offset: 0x004BA32C
		public bool RadErgoCfgCnvBtnListID_A21376_Visible
		{
			get
			{
				short num = (short)508624897;
				if (num != 0)
				{
				}
				num = (short)809461125;
				short num2 = num;
				num = (short)42100101;
				switch (num2 == num)
				{
				}
				num = (short)128712704;
				short num3 = num;
				num = (short)889323520;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListID_A21376.Visible;
			}
			set
			{
				short num = (short)1101767593;
				short num2 = num;
				num = (short)1449829289;
				switch (num2 == num)
				{
				}
				num = (short)1779302401;
				if (num != 0)
				{
				}
				num = (short)1320615936;
				short num3 = num;
				num = (short)1421410304;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListID_A21376.Visible = value;
			}
		}

		// Token: 0x17002B3B RID: 11067
		// (get) Token: 0x06005385 RID: 21381 RVA: 0x004BC1E4 File Offset: 0x004BA3E4
		// (set) Token: 0x06005386 RID: 21382 RVA: 0x004BC294 File Offset: 0x004BA494
		public bool RadErgoCfgCnvBtnListID_A21376_Editable
		{
			get
			{
				short num = (short)1410992977;
				short num2 = num;
				num = (short)1927875409;
				switch (num2 == num)
				{
				}
				num = (short)1368981504;
				if (num != 0)
				{
				}
				num = (short)1504837632;
				short num3 = num;
				num = (short)826015745;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListID_A21376.Editable;
			}
			set
			{
				short num = (short)1845040374;
				short num2 = num;
				num = (short)229512438;
				switch (num2 == num)
				{
				}
				num = (short)267845633;
				if (num != 0)
				{
				}
				num = (short)1550123008;
				short num3 = num;
				num = (short)733085696;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListID_A21376.Editable = value;
			}
		}

		// Token: 0x17002B3C RID: 11068
		// (get) Token: 0x06005387 RID: 21383 RVA: 0x004BC348 File Offset: 0x004BA548
		internal string RadErgoCfgCnvBtnListID_A21376_UILabel
		{
			get
			{
				short num = (short)1007809485;
				short num2 = num;
				num = (short)232780749;
				switch (num2 == num)
				{
				}
				num = (short)82903041;
				if (num != 0)
				{
				}
				num = (short)539099136;
				short num3 = num;
				num = (short)1794113536;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListID_A21376.UIName;
			}
		}

		// Token: 0x17002B3D RID: 11069
		// (get) Token: 0x06005388 RID: 21384 RVA: 0x004BC3FC File Offset: 0x004BA5FC
		// (set) Token: 0x06005389 RID: 21385 RVA: 0x004BC4AC File Offset: 0x004BA6AC
		internal bool RadErgoCfgCnvBtnListID_A21376_HiddenStatic
		{
			get
			{
				short num = (short)1456533770;
				short num2 = num;
				num = (short)44232970;
				switch (num2 == num)
				{
				}
				num = (short)740556800;
				if (num != 0)
				{
				}
				num = (short)2146369536;
				short num3 = num;
				num = (short)1635778561;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListID_A21376.HiddenStatic;
			}
			set
			{
				short num = (short)1366490785;
				short num2 = num;
				num = (short)545980065;
				switch (num2 == num)
				{
				}
				num = (short)1350631425;
				if (num != 0)
				{
				}
				num = (short)1690501120;
				short num3 = num;
				num = (short)1228537856;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListID_A21376.HiddenStatic = value;
			}
		}

		// Token: 0x17002B3E RID: 11070
		// (get) Token: 0x0600538A RID: 21386 RVA: 0x004BC560 File Offset: 0x004BA760
		// (set) Token: 0x0600538B RID: 21387 RVA: 0x004BC610 File Offset: 0x004BA810
		internal bool RadErgoCfgCnvBtnListID_A21376_HiddenDynamic
		{
			get
			{
				short num = (short)1883762101;
				short num2 = num;
				num = (short)1327820213;
				switch (num2 == num)
				{
				}
				num = (short)1787625473;
				if (num != 0)
				{
				}
				num = (short)1383792640;
				short num3 = num;
				num = (short)246743040;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListID_A21376.HiddenDynamic;
			}
			set
			{
				short num = (short)1597996915;
				short num2 = num;
				num = (short)825917299;
				switch (num2 == num)
				{
				}
				num = (short)1468006400;
				if (num != 0)
				{
				}
				num = (short)1896218624;
				short num3 = num;
				num = (short)1608908801;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListID_A21376.HiddenDynamic = value;
			}
		}

		// Token: 0x17002B3F RID: 11071
		// (get) Token: 0x0600538C RID: 21388 RVA: 0x004BC6C4 File Offset: 0x004BA8C4
		public bool RadErgoCfgCnvBtnListID_A21376_HasDiffs
		{
			get
			{
				short num = (short)1979778060;
				short num2 = num;
				num = (short)120521740;
				switch (num2 == num)
				{
				}
				num = (short)1303052289;
				if (num != 0)
				{
				}
				num = (short)1198522368;
				short num3 = num;
				num = (short)1998848000;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListID_A21376._HasDiffs;
			}
		}

		// Token: 0x17002B40 RID: 11072
		// (get) Token: 0x0600538D RID: 21389 RVA: 0x004BC778 File Offset: 0x004BA978
		// (set) Token: 0x0600538E RID: 21390 RVA: 0x004BC82C File Offset: 0x004BAA2C
		public int RadErgoCfgCnvBtnListType_A21164Value
		{
			get
			{
				short num = (short)1302715614;
				short num2 = num;
				num = (short)499309790;
				switch (num2 == num)
				{
				}
				num = (short)614727681;
				if (num != 0)
				{
				}
				num = (short)480772096;
				short num3 = num;
				num = (short)1780678656;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListType_A21164.Value;
			}
			set
			{
				short num = (short)543433337;
				short num2 = num;
				num = (short)94249593;
				switch (num2 == num)
				{
				}
				num = (short)525533184;
				if (num != 0)
				{
				}
				num = (short)1270546432;
				short num3 = num;
				num = (short)1239416833;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListType_A21164.Value = value;
			}
		}

		// Token: 0x17002B41 RID: 11073
		// (get) Token: 0x0600538F RID: 21391 RVA: 0x004BC8E0 File Offset: 0x004BAAE0
		// (set) Token: 0x06005390 RID: 21392 RVA: 0x004BC994 File Offset: 0x004BAB94
		public string RadErgoCfgCnvBtnListType_A21164_UIValue
		{
			get
			{
				short num = (short)1383453519;
				short num2 = num;
				num = (short)2129711951;
				switch (num2 == num)
				{
				}
				num = (short)1476722689;
				if (num != 0)
				{
				}
				num = (short)430505984;
				short num3 = num;
				num = (short)1823277056;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListType_A21164.UIValue;
			}
			set
			{
				short num = (short)971653520;
				short num2 = num;
				num = (short)608256400;
				switch (num2 == num)
				{
				}
				num = (short)836829185;
				if (num != 0)
				{
				}
				num = (short)491126784;
				short num3 = num;
				num = (short)1979645952;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListType_A21164.UIValue = value;
			}
		}

		// Token: 0x17002B42 RID: 11074
		// (get) Token: 0x06005391 RID: 21393 RVA: 0x004BCA48 File Offset: 0x004BAC48
		public global::AcpBusinessLayer.AcpListField RadErgoCfgCnvBtnListType_A21164
		{
			get
			{
				short num = (short)990009150;
				short num2 = num;
				num = (short)1235834686;
				switch (num2 == num)
				{
				}
				num = (short)75104257;
				if (num != 0)
				{
				}
				num = (short)183894016;
				short num3 = num;
				num = (short)2106654720;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListType_A21164;
			}
		}

		// Token: 0x17002B43 RID: 11075
		// (get) Token: 0x06005392 RID: 21394 RVA: 0x004BCAF8 File Offset: 0x004BACF8
		// (set) Token: 0x06005393 RID: 21395 RVA: 0x004BCBAC File Offset: 0x004BADAC
		public bool RadErgoCfgCnvBtnListType_A21164_Applicable
		{
			get
			{
				short num = (short)672771874;
				short num2 = num;
				num = (short)975286050;
				switch (num2 == num)
				{
				}
				num = (short)36569088;
				if (num != 0)
				{
				}
				num = (short)157286400;
				short num3 = num;
				num = (short)1627193345;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListType_A21164.Applicable;
			}
			set
			{
				short num = (short)1192737702;
				short num2 = num;
				num = (short)95075238;
				switch (num2 == num)
				{
				}
				num = (short)974782464;
				if (num != 0)
				{
				}
				num = (short)222822400;
				short num3 = num;
				num = (short)525860865;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListType_A21164.Applicable = value;
			}
		}

		// Token: 0x17002B44 RID: 11076
		// (get) Token: 0x06005394 RID: 21396 RVA: 0x004BCC64 File Offset: 0x004BAE64
		// (set) Token: 0x06005395 RID: 21397 RVA: 0x004BCD18 File Offset: 0x004BAF18
		public bool RadErgoCfgCnvBtnListType_A21164_Valid
		{
			get
			{
				short num = (short)294526684;
				short num2 = num;
				num = (short)314908380;
				switch (num2 == num)
				{
				}
				num = (short)264699904;
				if (num != 0)
				{
				}
				num = (short)1029439488;
				short num3 = num;
				num = (short)648151041;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListType_A21164.Valid;
			}
			set
			{
				short num = (short)95846272;
				short num2 = num;
				num = (short)106397568;
				switch (num2 == num)
				{
				}
				num = (short)1954283520;
				if (num != 0)
				{
				}
				num = (short)99614720;
				short num3 = num;
				num = (short)140181505;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListType_A21164.Valid = value;
			}
		}

		// Token: 0x17002B45 RID: 11077
		// (get) Token: 0x06005396 RID: 21398 RVA: 0x004BCDCC File Offset: 0x004BAFCC
		// (set) Token: 0x06005397 RID: 21399 RVA: 0x004BCE80 File Offset: 0x004BB080
		public bool RadErgoCfgCnvBtnListType_A21164_Visible
		{
			get
			{
				short num = (short)936640338;
				short num2 = num;
				num = (short)1602944850;
				switch (num2 == num)
				{
				}
				num = (short)59703297;
				if (num != 0)
				{
				}
				num = (short)1397555200;
				short num3 = num;
				num = (short)961478656;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListType_A21164.Visible;
			}
			set
			{
				short num = (short)1493069943;
				short num2 = num;
				num = (short)1550020727;
				switch (num2 == num)
				{
				}
				num = (short)154402816;
				if (num != 0)
				{
				}
				num = (short)265158656;
				short num3 = num;
				num = (short)327483393;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListType_A21164.Visible = value;
			}
		}

		// Token: 0x17002B46 RID: 11078
		// (get) Token: 0x06005398 RID: 21400 RVA: 0x004BCF38 File Offset: 0x004BB138
		// (set) Token: 0x06005399 RID: 21401 RVA: 0x004BCFEC File Offset: 0x004BB1EC
		public bool RadErgoCfgCnvBtnListType_A21164_Editable
		{
			get
			{
				short num = (short)365953025;
				if (num != 0)
				{
				}
				num = (short)2117957155;
				short num2 = num;
				num = (short)1311929891;
				switch (num2 == num)
				{
				}
				num = (short)1558446080;
				short num3 = num;
				num = (short)129761280;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListType_A21164.Editable;
			}
			set
			{
				short num = (short)645220416;
				short num2 = num;
				num = (short)120277056;
				switch (num2 == num)
				{
				}
				num = (short)962330624;
				if (num != 0)
				{
				}
				num = (short)617676800;
				short num3 = num;
				num = (short)788201473;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListType_A21164.Editable = value;
			}
		}

		// Token: 0x17002B47 RID: 11079
		// (get) Token: 0x0600539A RID: 21402 RVA: 0x004BD0A0 File Offset: 0x004BB2A0
		internal string RadErgoCfgCnvBtnListType_A21164_UILabel
		{
			get
			{
				short num = (short)571619750;
				short num2 = num;
				num = (short)502020518;
				switch (num2 == num)
				{
				}
				num = (short)1591672832;
				if (num != 0)
				{
				}
				num = (short)1568866304;
				short num3 = num;
				num = (short)1633681409;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListType_A21164.UIName;
			}
		}

		// Token: 0x17002B48 RID: 11080
		// (get) Token: 0x0600539B RID: 21403 RVA: 0x004BD158 File Offset: 0x004BB358
		// (set) Token: 0x0600539C RID: 21404 RVA: 0x004BD210 File Offset: 0x004BB410
		internal bool RadErgoCfgCnvBtnListType_A21164_HiddenStatic
		{
			get
			{
				short num = (short)922812742;
				short num2 = num;
				num = (short)1657405766;
				switch (num2 == num)
				{
				}
				num = (short)1466040320;
				if (num != 0)
				{
				}
				num = (short)1464926208;
				short num3 = num;
				num = (short)231538689;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListType_A21164.HiddenStatic;
			}
			set
			{
				short num = (short)1702655655;
				short num2 = num;
				num = (short)1651799719;
				switch (num2 == num)
				{
				}
				num = (short)1798242304;
				if (num != 0)
				{
				}
				num = (short)2081030144;
				short num3 = num;
				num = (short)1299709953;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListType_A21164.HiddenStatic = value;
			}
		}

		// Token: 0x17002B49 RID: 11081
		// (get) Token: 0x0600539D RID: 21405 RVA: 0x004BD2C4 File Offset: 0x004BB4C4
		// (set) Token: 0x0600539E RID: 21406 RVA: 0x004BD378 File Offset: 0x004BB578
		internal bool RadErgoCfgCnvBtnListType_A21164_HiddenDynamic
		{
			get
			{
				short num = (short)973437136;
				short num2 = num;
				num = (short)82606288;
				switch (num2 == num)
				{
				}
				num = (short)1959133184;
				if (num != 0)
				{
				}
				num = (short)710148096;
				short num3 = num;
				num = (short)1028784129;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListType_A21164.HiddenDynamic;
			}
			set
			{
				short num = (short)1377763328;
				short num2 = num;
				num = (short)792089403;
				short num3 = num;
				num = (short)750342971;
				switch (num3 == num)
				{
				}
				num = (short)1720385536;
				if (num != 0)
				{
				}
				num = (short)968163329;
				if (num != 0)
				{
				}
				this.radErgoCfgCnvBtnListType_A21164.HiddenDynamic = value;
			}
		}

		// Token: 0x17002B4A RID: 11082
		// (get) Token: 0x0600539F RID: 21407 RVA: 0x004BD42C File Offset: 0x004BB62C
		public bool RadErgoCfgCnvBtnListType_A21164_HasDiffs
		{
			get
			{
				short num = (short)529661952;
				short num2 = num;
				num = (short)1911366684;
				short num3 = num;
				num = (short)1773478940;
				switch (num3 == num)
				{
				}
				num = (short)847773696;
				if (num != 0)
				{
				}
				num = (short)1239154689;
				if (num != 0)
				{
				}
				return this.radErgoCfgCnvBtnListType_A21164._HasDiffs;
			}
		}

		// Token: 0x060053A0 RID: 21408 RVA: 0x004BD4E0 File Offset: 0x004BB6E0
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
					num2 = (short)1037429592;
					short num3 = num2;
					num2 = (short)656993112;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F7;
					default:
					{
						num2 = (short)1503789056;
						short num4 = num2;
						num2 = (short)1352990721;
						if (num2 != 0)
						{
						}
						num2 = (short)2032074752;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset != null)
						{
							num2 = (short)1634205697;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					}
					break;
				}
				case 1:
					goto IL_F7;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1878720515;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1603600388;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return result;
				}
				goto IL_24;
				IL_F7:
				num2 = (short)1367408642;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1062862848;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04001FB4 RID: 8116
		private global::AcpBusinessLayer.AcpKeyField radErgoCfgCnvBtnListKey_A21175;

		// Token: 0x04001FB5 RID: 8117
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgCnvBtnListID_A21376;

		// Token: 0x04001FB6 RID: 8118
		private global::AcpBusinessLayer.AcpListField radErgoCfgCnvBtnListType_A21164;
	}
}
