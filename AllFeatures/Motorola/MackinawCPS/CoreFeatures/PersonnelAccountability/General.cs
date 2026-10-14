using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability
{
	// Token: 0x02000247 RID: 583
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06006852 RID: 26706 RVA: 0x005D632C File Offset: 0x005D452C
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06006853 RID: 26707 RVA: 0x005D636C File Offset: 0x005D456C
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06006854 RID: 26708 RVA: 0x005D6384 File Offset: 0x005D4584
		public override void Init()
		{
			int a_ = 18;
			short num = (short)118173564;
			short num2 = num;
			num = (short)268971900;
			switch (num2 == num)
			{
			}
			num = (short)2045444097;
			if (num != 0)
			{
			}
			num = (short)79495168;
			if (num != 0)
			{
			}
			num = (short)845283328;
			short num3 = num;
			this.radioErgoConfigACPAListAlertName_A42874 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("臒듔돖냘듚飜귞蛠賢ꛤ裦蟨跪蓬裮냰냲ꗴ뛶뗸鋺軼课䀀漂怄甆紈䔊氌戎琐䰒吔⌖⬘⌚⨜⬞", a_), global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITYLISTNAME, 14);
			this.radioErgoConfigACPAListAlertName_A42874.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radioErgoConfigACPAListAlertName_A42874.DataTransferOrder = 16;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("铒냔맖볘꧚볜돞", a_);
			base.Id = 10813;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06006855 RID: 26709 RVA: 0x005D64A4 File Offset: 0x005D46A4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)836567044;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕뇗뗙駛곝蟟跡꟣觥蛧賩藫觭뇯뇱ꓳ럵듷鏹迻諽䇿渁愃琅簇䐉洋挍甏䴑唓∕⨗∙⬛⨝", a_)))
					{
						num = (short)1840709633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E6;
				case 1:
					this.radioErgoConfigACPAListAlertName_A42874 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("胑뗓닕뇗뗙駛곝蟟跡꟣觥蛧賩藫觭뇯뇱ꓳ럵듷鏹迻諽䇿渁愃琅簇䐉洋挍甏䴑唓∕⨗∙⬛⨝", a_), global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITYLISTNAME, 14);
					this.radioErgoConfigACPAListAlertName_A42874.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radioErgoConfigACPAListAlertName_A42874.DataTransferOrder = 16;
					num = (short)1931608070;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1863122944;
					short num3 = num;
					num = (short)1926924136;
					short num4 = num;
					num = (short)2011531112;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1302069248;
						if (num != 0)
						{
						}
						num = (short)1968504835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					if (producerFields != null)
					{
						num = (short)1636171781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E6;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_4B;
					}
					continue;
				case 5:
					num = (short)1683816449;
					if (num != 0)
					{
					}
					num = (short)769327104;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_BF;
				}
				IL_4B:
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					break;
				}
				num = (short)514129922;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BF:
			IL_1E6:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闑뇓룕뷗꣙뷛닝", a_);
			base.Id = 10813;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06006856 RID: 26710 RVA: 0x005D66C8 File Offset: 0x005D48C8
		public override void PopulateReferences()
		{
			short num = (short)2137153383;
			short num2 = num;
			num = (short)313417575;
			switch (num2 == num)
			{
			}
			num = (short)1735983105;
			if (num != 0)
			{
			}
			num = (short)1236336640;
			if (num != 0)
			{
			}
			num = (short)1663696896;
			short num3 = num;
		}

		// Token: 0x06006857 RID: 26711 RVA: 0x005D6770 File Offset: 0x005D4970
		public override void DropReferences()
		{
			short num = (short)986272947;
			short num2 = num;
			num = (short)1025463475;
			switch (num2 == num)
			{
			}
			num = (short)2142568449;
			if (num != 0)
			{
			}
			num = (short)1799618560;
			if (num != 0)
			{
			}
			num = (short)77987840;
			short num3 = num;
		}

		// Token: 0x06006858 RID: 26712 RVA: 0x005D681C File Offset: 0x005D4A1C
		public override void SetConstraints()
		{
			short num = (short)669450241;
			if (num != 0)
			{
			}
			num = (short)820285640;
			short num2 = num;
			num = (short)763203784;
			switch (num2 == num)
			{
			}
			num = (short)2081619968;
			if (num != 0)
			{
			}
			num = (short)456654848;
			short num3 = num;
		}

		// Token: 0x06006859 RID: 26713 RVA: 0x005D68C8 File Offset: 0x005D4AC8
		public override void SetupDependencies()
		{
			short num = (short)309419816;
			short num2 = num;
			num = (short)613572392;
			switch (num2 == num)
			{
			}
			num = (short)801374209;
			if (num != 0)
			{
			}
			num = (short)765526016;
			if (num != 0)
			{
			}
			num = (short)696844288;
			short num3 = num;
		}

		// Token: 0x17003617 RID: 13847
		// (get) Token: 0x0600685A RID: 26714 RVA: 0x005D6970 File Offset: 0x005D4B70
		public bool HasDiffs
		{
			get
			{
				short num = (short)414238332;
				short num2 = num;
				num = (short)913229436;
				switch (num2 == num)
				{
				}
				num = (short)463994881;
				if (num != 0)
				{
				}
				num = (short)1877475328;
				if (num != 0)
				{
				}
				num = (short)1676935168;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17003618 RID: 13848
		// (get) Token: 0x0600685B RID: 26715 RVA: 0x005D6A20 File Offset: 0x005D4C20
		// (set) Token: 0x0600685C RID: 26716 RVA: 0x005D6AD8 File Offset: 0x005D4CD8
		public string RadioErgoConfigACPAListAlertName_A42874Value
		{
			get
			{
				short num = (short)870066797;
				short num2 = num;
				num = (short)1942760045;
				switch (num2 == num)
				{
				}
				num = (short)1867448321;
				if (num != 0)
				{
				}
				num = (short)2116550656;
				if (num != 0)
				{
				}
				num = (short)1028849664;
				short num3 = num;
				return this.radioErgoConfigACPAListAlertName_A42874.Value;
			}
			set
			{
				short num = (short)999882753;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_15;
					case 2:
					{
						num = (short)864223233;
						if (num != 0)
						{
						}
						num = (short)2057441434;
						short num3 = num;
						num = (short)2115768474;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15;
						default:
						{
							num = (short)1613758464;
							if (num != 0)
							{
							}
							num = (short)1315241984;
							short num4 = num;
							this.radioErgoConfigACPAListAlertName_A42874.Value = value;
							num = (short)1104150528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					goto IL_31;
					IL_15:
					switch (0)
					{
					case 0:
						IL_31:
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)1412562946;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x17003619 RID: 13849
		// (get) Token: 0x0600685D RID: 26717 RVA: 0x005D6C00 File Offset: 0x005D4E00
		// (set) Token: 0x0600685E RID: 26718 RVA: 0x005D6CB8 File Offset: 0x005D4EB8
		public string RadioErgoConfigACPAListAlertName_A42874_UIValue
		{
			get
			{
				short num = (short)160468661;
				short num2 = num;
				num = (short)1773375157;
				switch (num2 == num)
				{
				}
				num = (short)1789853696;
				if (num != 0)
				{
				}
				num = (short)1592983553;
				if (num != 0)
				{
				}
				num = (short)538050560;
				short num3 = num;
				return this.radioErgoConfigACPAListAlertName_A42874.Value;
			}
			set
			{
				short num = (short)1203234479;
				short num2 = num;
				num = (short)599910063;
				switch (num2 == num)
				{
				}
				num = (short)641531904;
				if (num != 0)
				{
				}
				num = (short)815464449;
				if (num != 0)
				{
				}
				num = (short)1901395968;
				short num3 = num;
				this.radioErgoConfigACPAListAlertName_A42874.Value = value;
			}
		}

		// Token: 0x1700361A RID: 13850
		// (get) Token: 0x0600685F RID: 26719 RVA: 0x005D6D6C File Offset: 0x005D4F6C
		public global::AcpBusinessLayer.AcpKeyField RadioErgoConfigACPAListAlertName_A42874
		{
			get
			{
				short num = (short)1728335798;
				short num2 = num;
				num = (short)1280135094;
				switch (num2 == num)
				{
				}
				num = (short)682688513;
				if (num != 0)
				{
				}
				num = (short)416219136;
				if (num != 0)
				{
				}
				num = (short)659095552;
				short num3 = num;
				return this.radioErgoConfigACPAListAlertName_A42874;
			}
		}

		// Token: 0x1700361B RID: 13851
		// (get) Token: 0x06006860 RID: 26720 RVA: 0x005D6E1C File Offset: 0x005D501C
		// (set) Token: 0x06006861 RID: 26721 RVA: 0x005D6ED0 File Offset: 0x005D50D0
		public bool RadioErgoConfigACPAListAlertName_A42874_Applicable
		{
			get
			{
				short num = (short)864840602;
				short num2 = num;
				num = (short)1327721370;
				switch (num2 == num)
				{
				}
				num = (short)1328283649;
				if (num != 0)
				{
				}
				num = (short)1569390592;
				if (num != 0)
				{
				}
				num = (short)670040064;
				short num3 = num;
				return this.radioErgoConfigACPAListAlertName_A42874.Applicable;
			}
			set
			{
				short num = (short)1540161537;
				if (num != 0)
				{
				}
				num = (short)965610716;
				short num2 = num;
				num = (short)551554268;
				switch (num2 == num)
				{
				}
				num = (short)1614544896;
				if (num != 0)
				{
				}
				num = (short)1555759104;
				short num3 = num;
				this.radioErgoConfigACPAListAlertName_A42874.Applicable = value;
			}
		}

		// Token: 0x1700361C RID: 13852
		// (get) Token: 0x06006862 RID: 26722 RVA: 0x005D6F88 File Offset: 0x005D5188
		// (set) Token: 0x06006863 RID: 26723 RVA: 0x005D703C File Offset: 0x005D523C
		public bool RadioErgoConfigACPAListAlertName_A42874_Valid
		{
			get
			{
				short num = (short)6671653;
				short num2 = num;
				num = (short)278383909;
				switch (num2 == num)
				{
				}
				num = (short)1320943617;
				if (num != 0)
				{
				}
				num = (short)750714880;
				if (num != 0)
				{
				}
				num = (short)1527054336;
				short num3 = num;
				return this.radioErgoConfigACPAListAlertName_A42874.Valid;
			}
			set
			{
				short num = (short)577734086;
				short num2 = num;
				num = (short)2086503878;
				switch (num2 == num)
				{
				}
				num = (short)1060503553;
				if (num != 0)
				{
				}
				num = (short)1300955136;
				if (num != 0)
				{
				}
				num = (short)1733885952;
				short num3 = num;
				this.radioErgoConfigACPAListAlertName_A42874.Valid = value;
			}
		}

		// Token: 0x1700361D RID: 13853
		// (get) Token: 0x06006864 RID: 26724 RVA: 0x005D70F4 File Offset: 0x005D52F4
		// (set) Token: 0x06006865 RID: 26725 RVA: 0x005D71AC File Offset: 0x005D53AC
		public bool RadioErgoConfigACPAListAlertName_A42874_Visible
		{
			get
			{
				short num = (short)1795962231;
				short num2 = num;
				num = (short)5715319;
				switch (num2 == num)
				{
				}
				num = (short)319946752;
				if (num != 0)
				{
				}
				num = (short)712048641;
				if (num != 0)
				{
				}
				num = (short)1679491072;
				short num3 = num;
				return this.radioErgoConfigACPAListAlertName_A42874.Visible;
			}
			set
			{
				short num = (short)1954351987;
				short num2 = num;
				num = (short)1702955891;
				switch (num2 == num)
				{
				default:
				{
					num = (short)302579712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)155385856;
				if (num != 0)
				{
				}
				num = (short)888668161;
				if (num != 0)
				{
				}
				this.radioErgoConfigACPAListAlertName_A42874.Visible = value;
			}
		}

		// Token: 0x1700361E RID: 13854
		// (get) Token: 0x06006866 RID: 26726 RVA: 0x005D7264 File Offset: 0x005D5464
		// (set) Token: 0x06006867 RID: 26727 RVA: 0x005D7318 File Offset: 0x005D5518
		public bool RadioErgoConfigACPAListAlertName_A42874_Editable
		{
			get
			{
				short num = (short)654569406;
				short num2 = num;
				num = (short)1079373758;
				switch (num2 == num)
				{
				default:
				{
					num = (short)292290560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1922695169;
				if (num != 0)
				{
				}
				num = (short)536739840;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACPAListAlertName_A42874.Editable;
			}
			set
			{
				short num = (short)1095370661;
				short num2 = num;
				num = (short)25560997;
				switch (num2 == num)
				{
				default:
				{
					num = (short)770113536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1606942720;
				if (num != 0)
				{
				}
				num = (short)2008481793;
				if (num != 0)
				{
				}
				this.radioErgoConfigACPAListAlertName_A42874.Editable = value;
			}
		}

		// Token: 0x1700361F RID: 13855
		// (get) Token: 0x06006868 RID: 26728 RVA: 0x005D73D0 File Offset: 0x005D55D0
		internal string RadioErgoConfigACPAListAlertName_A42874_UILabel
		{
			get
			{
				short num = (short)1897201665;
				if (num != 0)
				{
				}
				num = (short)1922039808;
				short num2 = num;
				num = (short)1458572465;
				short num3 = num;
				num = (short)1395657905;
				switch (num3 == num)
				{
				}
				num = (short)1116471296;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACPAListAlertName_A42874.UIName;
			}
		}

		// Token: 0x17003620 RID: 13856
		// (get) Token: 0x06006869 RID: 26729 RVA: 0x005D7484 File Offset: 0x005D5684
		// (set) Token: 0x0600686A RID: 26730 RVA: 0x005D7538 File Offset: 0x005D5738
		internal bool RadioErgoConfigACPAListAlertName_A42874_HiddenStatic
		{
			get
			{
				short num = (short)49193818;
				short num2 = num;
				num = (short)471442266;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1295253504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1389887488;
				if (num != 0)
				{
				}
				num = (short)961740801;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACPAListAlertName_A42874.HiddenStatic;
			}
			set
			{
				short num = (short)467928188;
				short num2 = num;
				num = (short)852034684;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1135411200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1278935041;
				if (num != 0)
				{
				}
				num = (short)1602748416;
				if (num != 0)
				{
				}
				this.radioErgoConfigACPAListAlertName_A42874.HiddenStatic = value;
			}
		}

		// Token: 0x17003621 RID: 13857
		// (get) Token: 0x0600686B RID: 26731 RVA: 0x005D75EC File Offset: 0x005D57EC
		// (set) Token: 0x0600686C RID: 26732 RVA: 0x005D76A4 File Offset: 0x005D58A4
		internal bool RadioErgoConfigACPAListAlertName_A42874_HiddenDynamic
		{
			get
			{
				short num = (short)670040065;
				if (num != 0)
				{
				}
				num = (short)639696896;
				short num2 = num;
				num = (short)1480250274;
				short num3 = num;
				num = (short)50779042;
				switch (num3 == num)
				{
				}
				num = (short)811663360;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACPAListAlertName_A42874.HiddenDynamic;
			}
			set
			{
				short num = (short)698567841;
				short num2 = num;
				num = (short)1013533857;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1937047552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1191706624;
				if (num != 0)
				{
				}
				num = (short)1950679041;
				if (num != 0)
				{
				}
				this.radioErgoConfigACPAListAlertName_A42874.HiddenDynamic = value;
			}
		}

		// Token: 0x17003622 RID: 13858
		// (get) Token: 0x0600686D RID: 26733 RVA: 0x005D7758 File Offset: 0x005D5958
		public bool RadioErgoConfigACPAListAlertName_A42874_HasDiffs
		{
			get
			{
				short num = (short)1498401046;
				short num2 = num;
				num = (short)1175374102;
				switch (num2 == num)
				{
				default:
				{
					num = (short)282722304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)741867521;
				if (num != 0)
				{
				}
				num = (short)2121793536;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACPAListAlertName_A42874._HasDiffs;
			}
		}

		// Token: 0x0600686E RID: 26734 RVA: 0x005D7808 File Offset: 0x005D5A08
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
					num2 = (short)166526980;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
				{
					num2 = (short)1899814102;
					short num3 = num2;
					num2 = (short)1901386966;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1561395200;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						break;
					}
					num2 = (short)963182593;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)1581449216;
						short num4 = num2;
						num2 = (short)452132864;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					num2 = (short)1983315969;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)354287618;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1334378499;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04002910 RID: 10512
		private global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInnerRecset innerRecset;

		// Token: 0x04002911 RID: 10513
		private global::AcpBusinessLayer.AcpKeyField radioErgoConfigACPAListAlertName_A42874;
	}
}
