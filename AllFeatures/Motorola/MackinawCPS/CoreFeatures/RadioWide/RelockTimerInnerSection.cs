using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000180 RID: 384
	[global::System.Serializable]
	public class RelockTimerInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06003E1B RID: 15899 RVA: 0x003AAA80 File Offset: 0x003A8C80
		public RelockTimerInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x003AAA9C File Offset: 0x003A8C9C
		protected RelockTimerInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06003E1D RID: 15901 RVA: 0x003AAAB4 File Offset: 0x003A8CB4
		public override void Init()
		{
			int a_ = 12;
			short num = (short)1730254822;
			short num2 = num;
			num = (short)857315302;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1646723072;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1227292672;
			if (num != 0)
			{
			}
			num = (short)560922625;
			if (num != 0)
			{
			}
			this.radWideGunlockRelocktimerName_A36521 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐蓒볔돖볘鳚꣜뇞跠賢蛤賦믨軪臬胮鋰飲致黶铸黺迼뇾怀渂怄堆䠈㠊㬌㨎⌐−", a_), global::CommonResources.AcgResources.ID_NAME, 14);
			this.radWideGunlockRelocktimerName_A36521.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideGunlockRelocktimerName_A36521.DataTransferOrder = 142;
			this.radWideGunlockRelocktimerTimer_A36522 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐蓒볔돖볘鳚꣜뇞跠賢蛤賦믨軪臬胮鋰飲致黶铸黺迼꯾栀渂怄甆嘈䨊㸌㤎␐ℒ✔", a_), global::CommonResources.AcgResources.ID_RELOCKTIMERSEC, 0, 255, 1, global::CommonResources.AcgResources.ID_MOMENTARY, null);
			this.radWideGunlockRelocktimerTimer_A36522.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideGunlockRelocktimerTimer_A36522.DataTransferOrder = 143;
			this.radWideGunlockRelocktimerTimer_A36522.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鿌꫎뷐볒뛔볖律迚드닞蓠釢", a_);
			base.Id = 10607;
			base.UIName = global::CommonResources.AcgResources.ID_RELOCKTIMER;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06003E1E RID: 15902 RVA: 0x003AAC28 File Offset: 0x003A8E28
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 10;
			short num = (short)1492058113;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖默껚돜돞軠胢軤뗦賨蟪苬賮髰蟲鳴髶鳸觺ꧼ雾氀昂眄堆䠈㠊㬌㨎⌐ℒ", a_)))
					{
						num = (short)526188544;
						short num3 = num;
						num = (short)1279459334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A7;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 2:
					this.radWideGunlockRelocktimerName_A36521 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖默껚돜돞軠胢軤뗦賨蟪苬賮髰蟲鳴髶鳸觺돼黾氀昂娄䘆㨈㴊㠌㴎‐", a_), global::CommonResources.AcgResources.ID_NAME, 14);
					this.radWideGunlockRelocktimerName_A36521.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideGunlockRelocktimerName_A36521.DataTransferOrder = 142;
					num = (short)820707331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_78;
				case 4:
					goto IL_209;
				case 5:
				{
					num = (short)1901395969;
					if (num != 0)
					{
					}
					num = (short)1435619755;
					short num4 = num;
					num = (short)361550251;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2A7;
					default:
						num = (short)124256256;
						if (num != 0)
						{
						}
						num = (short)12189704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					this.radWideGunlockRelocktimerTimer_A36522 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖默껚돜돞軠胢軤뗦賨蟪苬賮髰蟲鳴髶鳸觺ꧼ雾氀昂眄堆䠈㠊㬌㨎⌐ℒ", a_), global::CommonResources.AcgResources.ID_RELOCKTIMERSEC, global::CommonResources.AcgResources.ID_MOMENTARY, null);
					this.radWideGunlockRelocktimerTimer_A36522.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideGunlockRelocktimerTimer_A36522.DataTransferOrder = 143;
					this.radWideGunlockRelocktimerTimer_A36522.ShowHexValue = false;
					num = (short)1167196164;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields != null)
					{
						num = (short)167837701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A7;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖默껚돜돞軠胢軤뗦賨蟪苬賮髰蟲鳴髶鳸觺돼黾氀昂娄䘆㨈㴊㠌㴎‐", a_)))
					{
						num = (short)458031106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_78;
				case 9:
					num = (short)985595911;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_55:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)590348297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_78:
				num = (short)1144717312;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_209:
			IL_2A7:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("駊꣌ꏎ뻐냒뻔跘닚냜뫞鏠", a_);
			base.Id = 10607;
			base.UIName = global::CommonResources.AcgResources.ID_RELOCKTIMER;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06003E1F RID: 15903 RVA: 0x003AAF10 File Offset: 0x003A9110
		public override void PopulateReferences()
		{
			short num = (short)1003137178;
			short num2 = num;
			num = (short)2042800282;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1184628736;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1958608897;
			if (num != 0)
			{
			}
			num = (short)1616117760;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003E20 RID: 15904 RVA: 0x003AAFB8 File Offset: 0x003A91B8
		public override void DropReferences()
		{
			short num = (short)1552343122;
			short num2 = num;
			num = (short)2128011346;
			switch (num2 == num)
			{
			default:
			{
				num = (short)154533888;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1283653633;
			if (num != 0)
			{
			}
			num = (short)97714176;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003E21 RID: 15905 RVA: 0x003AB064 File Offset: 0x003A9264
		public override void SetConstraints()
		{
			short num = (short)626145050;
			short num2 = num;
			num = (short)1040660250;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1939210240;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)385875968;
			if (num != 0)
			{
			}
			num = (short)808648705;
			if (num != 0)
			{
			}
			this.radWideGunlockRelocktimerName_A36521.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideGunlockRelocktimerTimer_A36522.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConDualRadioSystemIsNOTSecondaryApp);
		}

		// Token: 0x06003E22 RID: 15906 RVA: 0x003AB13C File Offset: 0x003A933C
		public override void SetupDependencies()
		{
			short num = (short)1118458303;
			short num2 = num;
			num = (short)1445941695;
			switch (num2 == num)
			{
			default:
			{
				num = (short)329646080;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1787232257;
			if (num != 0)
			{
			}
			num = (short)1760165888;
			if (num != 0)
			{
			}
			(base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radWideGunlockRelocktimerTimer_A36522);
		}

		// Token: 0x17001FDA RID: 8154
		// (get) Token: 0x06003E23 RID: 15907 RVA: 0x003AB20C File Offset: 0x003A940C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1066860545;
				if (num != 0)
				{
				}
				num = (short)754647040;
				short num2 = num;
				num = (short)1016068971;
				short num3 = num;
				num = (short)793246571;
				switch (num3 == num)
				{
				}
				num = (short)1444478976;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17001FDB RID: 8155
		// (get) Token: 0x06003E24 RID: 15908 RVA: 0x003AB2BC File Offset: 0x003A94BC
		// (set) Token: 0x06003E25 RID: 15909 RVA: 0x003AB370 File Offset: 0x003A9570
		public string RadWideGunlockRelocktimerName_A36521Value
		{
			get
			{
				short num = (short)1998239424;
				short num2 = num;
				num = (short)453752512;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1197146112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1837432832;
				if (num != 0)
				{
				}
				num = (short)916979713;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerName_A36521.Value;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)732758018;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1367632687;
						short num3 = num;
						num = (short)24275759;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)435879936;
							if (num != 0)
							{
							}
							switch (num2)
							{
							case 0:
								return;
							case 1:
							{
								this.radWideGunlockRelocktimerName_A36521.Value = value;
								num = (short)586678272;
								short num4 = num;
								num = (short)75956224;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_7D;
								}
								continue;
							}
							IL_7D:
							num = (short)4718593;
							if (num != 0)
							{
							}
							if (string.IsNullOrEmpty(value.Trim()))
							{
								return;
							}
							num = (short)1034551297;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
				}
			}
		}

		// Token: 0x17001FDC RID: 8156
		// (get) Token: 0x06003E26 RID: 15910 RVA: 0x003AB498 File Offset: 0x003A9698
		// (set) Token: 0x06003E27 RID: 15911 RVA: 0x003AB54C File Offset: 0x003A974C
		public string RadWideGunlockRelocktimerName_A36521_UIValue
		{
			get
			{
				short num = (short)1861745254;
				short num2 = num;
				num = (short)584252006;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1076756480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)664993792;
				if (num != 0)
				{
				}
				num = (short)58654721;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerName_A36521.Value;
			}
			set
			{
				short num = (short)1807941633;
				if (num != 0)
				{
				}
				num = (short)1347944448;
				short num2 = num;
				num = (short)181813688;
				short num3 = num;
				num = (short)334053816;
				switch (num3 == num)
				{
				}
				num = (short)1506476032;
				if (num != 0)
				{
				}
				this.radWideGunlockRelocktimerName_A36521.Value = value;
			}
		}

		// Token: 0x17001FDD RID: 8157
		// (get) Token: 0x06003E28 RID: 15912 RVA: 0x003AB600 File Offset: 0x003A9800
		public global::AcpBusinessLayer.AcpKeyField RadWideGunlockRelocktimerName_A36521
		{
			get
			{
				short num = (short)581359101;
				short num2 = num;
				num = (short)1950930429;
				switch (num2 == num)
				{
				default:
				{
					num = (short)341114880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1978990593;
				if (num != 0)
				{
				}
				num = (short)334168064;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerName_A36521;
			}
		}

		// Token: 0x17001FDE RID: 8158
		// (get) Token: 0x06003E29 RID: 15913 RVA: 0x003AB6B0 File Offset: 0x003A98B0
		// (set) Token: 0x06003E2A RID: 15914 RVA: 0x003AB768 File Offset: 0x003A9968
		public bool RadWideGunlockRelocktimerName_A36521_Applicable
		{
			get
			{
				short num = (short)2038466069;
				short num2 = num;
				num = (short)405767701;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2044788736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1164771328;
				if (num != 0)
				{
				}
				num = (short)1392377857;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerName_A36521.Applicable;
			}
			set
			{
				short num = (short)1613234177;
				if (num != 0)
				{
				}
				num = (short)598867968;
				short num2 = num;
				num = (short)1135039081;
				short num3 = num;
				num = (short)412635753;
				switch (num3 == num)
				{
				}
				num = (short)776339456;
				if (num != 0)
				{
				}
				this.radWideGunlockRelocktimerName_A36521.Applicable = value;
			}
		}

		// Token: 0x17001FDF RID: 8159
		// (get) Token: 0x06003E2B RID: 15915 RVA: 0x003AB81C File Offset: 0x003A9A1C
		// (set) Token: 0x06003E2C RID: 15916 RVA: 0x003AB8D0 File Offset: 0x003A9AD0
		public bool RadWideGunlockRelocktimerName_A36521_Valid
		{
			get
			{
				short num = (short)1120141313;
				if (num != 0)
				{
				}
				num = (short)2117984549;
				short num2 = num;
				num = (short)1520820517;
				switch (num2 == num)
				{
				default:
				{
					num = (short)490274816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1188626432;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerName_A36521.Valid;
			}
			set
			{
				short num = (short)183921214;
				short num2 = num;
				num = (short)410610238;
				switch (num2 == num)
				{
				}
				num = (short)696057856;
				short num3 = num;
				num = (short)2142437376;
				if (num != 0)
				{
				}
				num = (short)550502401;
				if (num != 0)
				{
				}
				this.radWideGunlockRelocktimerName_A36521.Valid = value;
			}
		}

		// Token: 0x17001FE0 RID: 8160
		// (get) Token: 0x06003E2D RID: 15917 RVA: 0x003AB980 File Offset: 0x003A9B80
		// (set) Token: 0x06003E2E RID: 15918 RVA: 0x003ABA34 File Offset: 0x003A9C34
		public bool RadWideGunlockRelocktimerName_A36521_Visible
		{
			get
			{
				short num = (short)751736767;
				short num2 = num;
				num = (short)1662359487;
				switch (num2 == num)
				{
				}
				num = (short)163250176;
				short num3 = num;
				num = (short)837091329;
				if (num != 0)
				{
				}
				num = (short)9175040;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerName_A36521.Visible;
			}
			set
			{
				short num = (short)1507726175;
				short num2 = num;
				num = (short)640095071;
				switch (num2 == num)
				{
				}
				num = (short)234291200;
				short num3 = num;
				num = (short)170852352;
				if (num != 0)
				{
				}
				num = (short)1712914433;
				if (num != 0)
				{
				}
				this.radWideGunlockRelocktimerName_A36521.Visible = value;
			}
		}

		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x06003E2F RID: 15919 RVA: 0x003ABAE8 File Offset: 0x003A9CE8
		// (set) Token: 0x06003E30 RID: 15920 RVA: 0x003ABBA0 File Offset: 0x003A9DA0
		public bool RadWideGunlockRelocktimerName_A36521_Editable
		{
			get
			{
				short num = (short)813764564;
				short num2 = num;
				num = (short)1844121556;
				switch (num2 == num)
				{
				}
				num = (short)954662912;
				short num3 = num;
				num = (short)2083848192;
				if (num != 0)
				{
				}
				num = (short)1943142401;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerName_A36521.Editable;
			}
			set
			{
				short num = (short)1502613795;
				short num2 = num;
				num = (short)1730613539;
				switch (num2 == num)
				{
				}
				num = (short)1724579840;
				short num3 = num;
				num = (short)1019150337;
				if (num != 0)
				{
				}
				num = (short)1544093696;
				if (num != 0)
				{
				}
				this.radWideGunlockRelocktimerName_A36521.Editable = value;
			}
		}

		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x06003E31 RID: 15921 RVA: 0x003ABC54 File Offset: 0x003A9E54
		internal string RadWideGunlockRelocktimerName_A36521_UILabel
		{
			get
			{
				short num = (short)918355969;
				if (num != 0)
				{
				}
				num = (short)1906176258;
				short num2 = num;
				num = (short)234877186;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1550712832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1815543808;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerName_A36521.UIName;
			}
		}

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x06003E32 RID: 15922 RVA: 0x003ABD0C File Offset: 0x003A9F0C
		// (set) Token: 0x06003E33 RID: 15923 RVA: 0x003ABDC0 File Offset: 0x003A9FC0
		internal bool RadWideGunlockRelocktimerName_A36521_HiddenStatic
		{
			get
			{
				short num = (short)365941558;
				short num2 = num;
				num = (short)1371657014;
				switch (num2 == num)
				{
				}
				num = (short)2008350720;
				short num3 = num;
				num = (short)974913537;
				if (num != 0)
				{
				}
				num = (short)330760192;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerName_A36521.HiddenStatic;
			}
			set
			{
				short num = (short)514953827;
				short num2 = num;
				num = (short)1775211107;
				switch (num2 == num)
				{
				}
				num = (short)1605173248;
				short num3 = num;
				num = (short)392429569;
				if (num != 0)
				{
				}
				num = (short)295895040;
				if (num != 0)
				{
				}
				this.radWideGunlockRelocktimerName_A36521.HiddenStatic = value;
			}
		}

		// Token: 0x17001FE4 RID: 8164
		// (get) Token: 0x06003E34 RID: 15924 RVA: 0x003ABE74 File Offset: 0x003AA074
		// (set) Token: 0x06003E35 RID: 15925 RVA: 0x003ABF28 File Offset: 0x003AA128
		internal bool RadWideGunlockRelocktimerName_A36521_HiddenDynamic
		{
			get
			{
				short num = (short)272606410;
				short num2 = num;
				num = (short)1613800650;
				switch (num2 == num)
				{
				}
				num = (short)417923072;
				short num3 = num;
				num = (short)774504448;
				if (num != 0)
				{
				}
				num = (short)1174405121;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerName_A36521.HiddenDynamic;
			}
			set
			{
				short num = (short)2052067080;
				short num2 = num;
				num = (short)661851912;
				switch (num2 == num)
				{
				}
				num = (short)1841364992;
				short num3 = num;
				num = (short)738787329;
				if (num != 0)
				{
				}
				num = (short)1206976512;
				if (num != 0)
				{
				}
				this.radWideGunlockRelocktimerName_A36521.HiddenDynamic = value;
			}
		}

		// Token: 0x17001FE5 RID: 8165
		// (get) Token: 0x06003E36 RID: 15926 RVA: 0x003ABFDC File Offset: 0x003AA1DC
		public bool RadWideGunlockRelocktimerName_A36521_HasDiffs
		{
			get
			{
				short num = (short)339542017;
				if (num != 0)
				{
				}
				num = (short)972839331;
				short num2 = num;
				num = (short)195385763;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1765539840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)917831680;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerName_A36521._HasDiffs;
			}
		}

		// Token: 0x17001FE6 RID: 8166
		// (get) Token: 0x06003E37 RID: 15927 RVA: 0x003AC094 File Offset: 0x003AA294
		// (set) Token: 0x06003E38 RID: 15928 RVA: 0x003AC14C File Offset: 0x003AA34C
		public int RadWideGunlockRelocktimerTimer_A36522Value
		{
			get
			{
				short num = (short)1285336777;
				short num2 = num;
				num = (short)673754825;
				switch (num2 == num)
				{
				}
				num = (short)1082392576;
				short num3 = num;
				num = (short)937820161;
				if (num != 0)
				{
				}
				num = (short)612106240;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerTimer_A36522.Value;
			}
			set
			{
				short num = (short)1580377759;
				short num2 = num;
				num = (short)394438303;
				switch (num2 == num)
				{
				}
				num = (short)561971200;
				short num3 = num;
				num = (short)393674753;
				if (num != 0)
				{
				}
				num = (short)1503330304;
				if (num != 0)
				{
				}
				this.radWideGunlockRelocktimerTimer_A36522.Value = value;
			}
		}

		// Token: 0x17001FE7 RID: 8167
		// (get) Token: 0x06003E39 RID: 15929 RVA: 0x003AC204 File Offset: 0x003AA404
		public global::AcpBusinessLayer.AcpCustomRangeField RadWideGunlockRelocktimerTimer_A36522
		{
			get
			{
				short num = (short)1331007435;
				short num2 = num;
				num = (short)578129867;
				switch (num2 == num)
				{
				}
				num = (short)1567883264;
				short num3 = num;
				num = (short)1581318145;
				if (num != 0)
				{
				}
				num = (short)1114505216;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerTimer_A36522;
			}
		}

		// Token: 0x17001FE8 RID: 8168
		// (get) Token: 0x06003E3A RID: 15930 RVA: 0x003AC2B8 File Offset: 0x003AA4B8
		// (set) Token: 0x06003E3B RID: 15931 RVA: 0x003AC36C File Offset: 0x003AA56C
		public string RadWideGunlockRelocktimerTimer_A36522_UIValue
		{
			get
			{
				short num = (short)27321197;
				short num2 = num;
				num = (short)2090328941;
				switch (num2 == num)
				{
				}
				num = (short)64028672;
				short num3 = num;
				num = (short)1900740608;
				if (num != 0)
				{
				}
				num = (short)1841758209;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerTimer_A36522.UIValue;
			}
			set
			{
				short num = (short)2064001732;
				short num2 = num;
				num = (short)1744317124;
				switch (num2 == num)
				{
				}
				num = (short)894238720;
				short num3 = num;
				num = (short)395182080;
				if (num != 0)
				{
				}
				num = (short)305725441;
				if (num != 0)
				{
				}
				this.radWideGunlockRelocktimerTimer_A36522.UIValue = value;
			}
		}

		// Token: 0x17001FE9 RID: 8169
		// (get) Token: 0x06003E3C RID: 15932 RVA: 0x003AC424 File Offset: 0x003AA624
		// (set) Token: 0x06003E3D RID: 15933 RVA: 0x003AC4D8 File Offset: 0x003AA6D8
		internal int RadWideGunlockRelocktimerTimer_A36522Min
		{
			get
			{
				short num = (short)192924917;
				short num2 = num;
				num = (short)1734921461;
				switch (num2 == num)
				{
				}
				num = (short)1132068864;
				short num3 = num;
				num = (short)677249024;
				if (num != 0)
				{
				}
				num = (short)1693122561;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerTimer_A36522.Min;
			}
			set
			{
				short num = (short)92602369;
				if (num != 0)
				{
				}
				num = (short)753399078;
				short num2 = num;
				num = (short)1895757094;
				switch (num2 == num)
				{
				default:
				{
					num = (short)622788608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1042808832;
				if (num != 0)
				{
				}
				this.radWideGunlockRelocktimerTimer_A36522.Min = value;
			}
		}

		// Token: 0x17001FEA RID: 8170
		// (get) Token: 0x06003E3E RID: 15934 RVA: 0x003AC58C File Offset: 0x003AA78C
		// (set) Token: 0x06003E3F RID: 15935 RVA: 0x003AC640 File Offset: 0x003AA840
		internal int RadWideGunlockRelocktimerTimer_A36522Max
		{
			get
			{
				short num = (short)1507760494;
				short num2 = num;
				num = (short)746887534;
				switch (num2 == num)
				{
				}
				num = (short)1953169408;
				short num3 = num;
				num = (short)381419520;
				if (num != 0)
				{
				}
				num = (short)1630339073;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerTimer_A36522.Max;
			}
			set
			{
				short num = (short)1706869371;
				short num2 = num;
				num = (short)918340219;
				switch (num2 == num)
				{
				}
				num = (short)2000551936;
				short num3 = num;
				num = (short)1588330496;
				if (num != 0)
				{
				}
				num = (short)580321281;
				if (num != 0)
				{
				}
				this.radWideGunlockRelocktimerTimer_A36522.Max = value;
			}
		}

		// Token: 0x17001FEB RID: 8171
		// (get) Token: 0x06003E40 RID: 15936 RVA: 0x003AC6F8 File Offset: 0x003AA8F8
		// (set) Token: 0x06003E41 RID: 15937 RVA: 0x003AC7AC File Offset: 0x003AA9AC
		internal int RadWideGunlockRelocktimerTimer_A36522Step
		{
			get
			{
				short num = (short)1465458599;
				short num2 = num;
				num = (short)2098143143;
				switch (num2 == num)
				{
				}
				num = (short)452722688;
				short num3 = num;
				num = (short)69337089;
				if (num != 0)
				{
				}
				num = (short)798425088;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerTimer_A36522.StepSize;
			}
			set
			{
				short num = (short)648065537;
				short num2 = num;
				num = (short)1130410497;
				switch (num2 == num)
				{
				}
				num = (short)96403456;
				short num3 = num;
				num = (short)1312096257;
				if (num != 0)
				{
				}
				num = (short)1149501440;
				if (num != 0)
				{
				}
				this.radWideGunlockRelocktimerTimer_A36522.StepSize = value;
			}
		}

		// Token: 0x17001FEC RID: 8172
		// (get) Token: 0x06003E42 RID: 15938 RVA: 0x003AC860 File Offset: 0x003AAA60
		// (set) Token: 0x06003E43 RID: 15939 RVA: 0x003AC914 File Offset: 0x003AAB14
		public bool RadWideGunlockRelocktimerTimer_A36522_Applicable
		{
			get
			{
				short num = (short)1912772712;
				short num2 = num;
				num = (short)1968937064;
				switch (num2 == num)
				{
				}
				num = (short)1529282560;
				short num3 = num;
				num = (short)705298433;
				if (num != 0)
				{
				}
				num = (short)314638336;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerTimer_A36522.Applicable;
			}
			set
			{
				short num = (short)1184791370;
				short num2 = num;
				num = (short)1910995786;
				switch (num2 == num)
				{
				}
				num = (short)327548928;
				short num3 = num;
				num = (short)887816192;
				if (num != 0)
				{
				}
				num = (short)1296105473;
				if (num != 0)
				{
				}
				this.radWideGunlockRelocktimerTimer_A36522.Applicable = value;
			}
		}

		// Token: 0x17001FED RID: 8173
		// (get) Token: 0x06003E44 RID: 15940 RVA: 0x003AC9CC File Offset: 0x003AABCC
		// (set) Token: 0x06003E45 RID: 15941 RVA: 0x003ACA80 File Offset: 0x003AAC80
		public bool RadWideGunlockRelocktimerTimer_A36522_Valid
		{
			get
			{
				short num = (short)413789473;
				short num2 = num;
				num = (short)558951713;
				switch (num2 == num)
				{
				}
				num = (short)1038680064;
				short num3 = num;
				num = (short)1926889472;
				if (num != 0)
				{
				}
				num = (short)120193025;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerTimer_A36522.Valid;
			}
			set
			{
				short num = (short)861966841;
				short num2 = num;
				num = (short)1351717369;
				switch (num2 == num)
				{
				}
				num = (short)479395840;
				short num3 = num;
				num = (short)445841409;
				if (num != 0)
				{
				}
				num = (short)1131347968;
				if (num != 0)
				{
				}
				this.radWideGunlockRelocktimerTimer_A36522.Valid = value;
			}
		}

		// Token: 0x17001FEE RID: 8174
		// (get) Token: 0x06003E46 RID: 15942 RVA: 0x003ACB34 File Offset: 0x003AAD34
		// (set) Token: 0x06003E47 RID: 15943 RVA: 0x003ACBE8 File Offset: 0x003AADE8
		public bool RadWideGunlockRelocktimerTimer_A36522_Visible
		{
			get
			{
				short num = (short)529345402;
				short num2 = num;
				num = (short)1212689274;
				switch (num2 == num)
				{
				}
				num = (short)618266624;
				short num3 = num;
				num = (short)583925761;
				if (num != 0)
				{
				}
				num = (short)746455040;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerTimer_A36522.Visible;
			}
			set
			{
				short num = (short)1202651137;
				if (num != 0)
				{
				}
				num = (short)2135683226;
				short num2 = num;
				num = (short)368504986;
				switch (num2 == num)
				{
				default:
				{
					num = (short)118292480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)518782976;
				if (num != 0)
				{
				}
				this.radWideGunlockRelocktimerTimer_A36522.Visible = value;
			}
		}

		// Token: 0x17001FEF RID: 8175
		// (get) Token: 0x06003E48 RID: 15944 RVA: 0x003ACC9C File Offset: 0x003AAE9C
		// (set) Token: 0x06003E49 RID: 15945 RVA: 0x003ACD50 File Offset: 0x003AAF50
		public bool RadWideGunlockRelocktimerTimer_A36522_Editable
		{
			get
			{
				short num = (short)1779433473;
				if (num != 0)
				{
				}
				num = (short)329149854;
				short num2 = num;
				num = (short)1233153438;
				switch (num2 == num)
				{
				default:
				{
					num = (short)845152256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)677904384;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerTimer_A36522.Editable;
			}
			set
			{
				short num = (short)1346434963;
				short num2 = num;
				num = (short)821950355;
				switch (num2 == num)
				{
				}
				num = (short)700579840;
				short num3 = num;
				num = (short)1703936001;
				if (num != 0)
				{
				}
				num = (short)192544768;
				if (num != 0)
				{
				}
				this.radWideGunlockRelocktimerTimer_A36522.Editable = value;
			}
		}

		// Token: 0x17001FF0 RID: 8176
		// (get) Token: 0x06003E4A RID: 15946 RVA: 0x003ACE08 File Offset: 0x003AB008
		internal string RadWideGunlockRelocktimerTimer_A36522_UILabel
		{
			get
			{
				short num = (short)1971837394;
				short num2 = num;
				num = (short)1441978834;
				switch (num2 == num)
				{
				}
				num = (short)680656896;
				short num3 = num;
				num = (short)1831403521;
				if (num != 0)
				{
				}
				num = (short)1531248640;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerTimer_A36522.UIName;
			}
		}

		// Token: 0x17001FF1 RID: 8177
		// (get) Token: 0x06003E4B RID: 15947 RVA: 0x003ACEBC File Offset: 0x003AB0BC
		// (set) Token: 0x06003E4C RID: 15948 RVA: 0x003ACF70 File Offset: 0x003AB170
		internal bool RadWideGunlockRelocktimerTimer_A36522_HiddenStatic
		{
			get
			{
				short num = (short)912007597;
				short num2 = num;
				num = (short)1102193069;
				switch (num2 == num)
				{
				}
				num = (short)1618870272;
				short num3 = num;
				num = (short)1099825153;
				if (num != 0)
				{
				}
				num = (short)1846542336;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerTimer_A36522.HiddenStatic;
			}
			set
			{
				short num = (short)1928149936;
				short num2 = num;
				num = (short)241712048;
				switch (num2 == num)
				{
				}
				num = (short)1371602944;
				short num3 = num;
				num = (short)1973485569;
				if (num != 0)
				{
				}
				num = (short)992018432;
				if (num != 0)
				{
				}
				this.radWideGunlockRelocktimerTimer_A36522.HiddenStatic = value;
			}
		}

		// Token: 0x17001FF2 RID: 8178
		// (get) Token: 0x06003E4D RID: 15949 RVA: 0x003AD024 File Offset: 0x003AB224
		// (set) Token: 0x06003E4E RID: 15950 RVA: 0x003AD0D8 File Offset: 0x003AB2D8
		internal bool RadWideGunlockRelocktimerTimer_A36522_HiddenDynamic
		{
			get
			{
				short num = (short)1918754033;
				short num2 = num;
				num = (short)385604849;
				switch (num2 == num)
				{
				}
				num = (short)1668349952;
				short num3 = num;
				num = (short)1537409024;
				if (num != 0)
				{
				}
				num = (short)102498305;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerTimer_A36522.HiddenDynamic;
			}
			set
			{
				short num = (short)1239549839;
				short num2 = num;
				num = (short)2047084431;
				switch (num2 == num)
				{
				}
				num = (short)94765056;
				short num3 = num;
				num = (short)977272832;
				if (num != 0)
				{
				}
				num = (short)949420033;
				if (num != 0)
				{
				}
				this.radWideGunlockRelocktimerTimer_A36522.HiddenDynamic = value;
			}
		}

		// Token: 0x17001FF3 RID: 8179
		// (get) Token: 0x06003E4F RID: 15951 RVA: 0x003AD190 File Offset: 0x003AB390
		public bool RadWideGunlockRelocktimerTimer_A36522_HasDiffs
		{
			get
			{
				short num = (short)1899494862;
				short num2 = num;
				num = (short)649199054;
				switch (num2 == num)
				{
				}
				num = (short)1419378688;
				short num3 = num;
				num = (short)1478098945;
				if (num != 0)
				{
				}
				num = (short)641138688;
				if (num != 0)
				{
				}
				return this.radWideGunlockRelocktimerTimer_A36522._HasDiffs;
			}
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x003AD244 File Offset: 0x003AB444
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
				{
					num2 = (short)1311494212;
					short num3 = num2;
					num2 = (short)443273284;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)939524096;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1754923010;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 2:
					num2 = (short)2068512769;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1301872640;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)1981480960;
					short num4 = num2;
					if (base.ParentRecset != null)
					{
						num2 = (short)2089091076;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 4:
					num2 = (short)1901461505;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1559822339;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040019E1 RID: 6625
		private global::AcpBusinessLayer.AcpKeyField radWideGunlockRelocktimerName_A36521;

		// Token: 0x040019E2 RID: 6626
		private global::AcpBusinessLayer.AcpCustomRangeField radWideGunlockRelocktimerTimer_A36522;
	}
}
