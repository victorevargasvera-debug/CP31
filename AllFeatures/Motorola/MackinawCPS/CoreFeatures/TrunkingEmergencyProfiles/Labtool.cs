using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles
{
	// Token: 0x0200047B RID: 1147
	[global::System.Serializable]
	public class Labtool : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600979F RID: 38815 RVA: 0x008E46B4 File Offset: 0x008E28B4
		public Labtool(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060097A0 RID: 38816 RVA: 0x008E46D0 File Offset: 0x008E28D0
		protected Labtool(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060097A1 RID: 38817 RVA: 0x008E46E8 File Offset: 0x008E28E8
		public override void Init()
		{
			int a_ = 19;
			short num = (short)569179106;
			short num2 = num;
			num = (short)1820130274;
			switch (num2 == num)
			{
			}
			num = (short)323354624;
			short num3 = num;
			num = (short)2017263616;
			if (num != 0)
			{
			}
			num = (short)226557953;
			if (num != 0)
			{
			}
			this.trkEmergencyToneSelection_42055 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗鿙뇛믝鋟藡臣裥诧鏩룫臭黯韱ꟳ鏵铷鿹鿻諽槿洁樃夅㰇㠉㰋㬍┏", a_), global::CommonResources.AcgResources.ID_TRUNKINGEMERGENCYPROFILETONECONFIGURATIONLISTITEMNAMEID, new string[]
			{
				global::CommonResources.AcgResources.ID_DEFAULTTONECONFIGURATION
			}, new int[1], true, false);
			this.trkEmergencyToneSelection_42055.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trkEmergencyToneSelection_42055.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("飓럕뫗껙돛뇝賟", a_);
			base.Id = 10187;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 4;
		}

		// Token: 0x060097A2 RID: 38818 RVA: 0x008E481C File Offset: 0x008E2A1C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 19;
			short num = (short)813170688;
			short num2 = num;
			num = (short)847052804;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					num = (short)1069481985;
					if (num != 0)
					{
					}
					num = (short)434110469;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)792330242;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胓ꓕ돗鿙뇛믝鋟藡臣裥诧鏩룫臭黯韱ꟳ鏵铷鿹鿻諽槿洁樃夅㰇㠉㰋㬍┏", a_)))
					{
						num = (short)1538654214;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F1;
				case 3:
				{
					num = (short)1682858902;
					short num4 = num;
					num = (short)192766870;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18E;
					default:
						goto IL_12D;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_71;
					}
					continue;
				case 5:
					if (producerFields != null)
					{
						num = (short)1723596801;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F1;
				case 6:
					goto IL_18E;
				}
				IL_71:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)815988736;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1F1;
				IL_18E:
				this.trkEmergencyToneSelection_42055 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗鿙뇛믝鋟藡臣裥诧鏩룫臭黯韱ꟳ鏵铷鿹鿻諽槿洁樃夅㰇㠉㰋㬍┏", a_), global::CommonResources.AcgResources.ID_TRUNKINGEMERGENCYPROFILETONECONFIGURATIONLISTITEMNAMEID, new string[]
				{
					global::CommonResources.AcgResources.ID_DEFAULTTONECONFIGURATION
				}, new int[1], true, false);
				this.trkEmergencyToneSelection_42055.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
				this.trkEmergencyToneSelection_42055.DataTransferOrder = -1;
				num = (short)787087363;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_12D:
			num = (short)136183808;
			if (num != 0)
			{
			}
			IL_1F1:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("飓럕뫗껙돛뇝賟", a_);
			base.Id = 10187;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 4;
		}

		// Token: 0x060097A3 RID: 38819 RVA: 0x008E4A4C File Offset: 0x008E2C4C
		public override void PopulateReferences()
		{
			short num = (short)625516516;
			short num2 = num;
			num = (short)1808637924;
			switch (num2 == num)
			{
			default:
			{
				num = (short)703004672;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1351680001;
			if (num != 0)
			{
			}
			num = (short)202440704;
			if (num != 0)
			{
			}
		}

		// Token: 0x060097A4 RID: 38820 RVA: 0x008E4AF4 File Offset: 0x008E2CF4
		public override void DropReferences()
		{
			short num = (short)611368354;
			short num2 = num;
			num = (short)872136098;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2026110976;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)894828544;
			if (num != 0)
			{
			}
			num = (short)1467023361;
			if (num != 0)
			{
			}
		}

		// Token: 0x060097A5 RID: 38821 RVA: 0x008E4B9C File Offset: 0x008E2D9C
		public override void SetConstraints()
		{
			short num = (short)1932132353;
			if (num != 0)
			{
			}
			num = (short)552206336;
			short num2 = num;
			num = (short)260585679;
			short num3 = num;
			num = (short)591083727;
			switch (num3 == num)
			{
			}
			num = (short)2027552768;
			if (num != 0)
			{
			}
		}

		// Token: 0x060097A6 RID: 38822 RVA: 0x008E4C48 File Offset: 0x008E2E48
		public override void SetupDependencies()
		{
			short num = (short)1412774723;
			short num2 = num;
			num = (short)1526807363;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1696464896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1595736065;
			if (num != 0)
			{
			}
			num = (short)1300234240;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004C38 RID: 19512
		// (get) Token: 0x060097A7 RID: 38823 RVA: 0x008E4CF0 File Offset: 0x008E2EF0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1247615327;
				short num2 = num;
				num = (short)1379080543;
				switch (num2 == num)
				{
				default:
				{
					num = (short)300941312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)577044481;
				if (num != 0)
				{
				}
				num = (short)699138048;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004C39 RID: 19513
		// (get) Token: 0x060097A8 RID: 38824 RVA: 0x008E4DA0 File Offset: 0x008E2FA0
		// (set) Token: 0x060097A9 RID: 38825 RVA: 0x008E4E54 File Offset: 0x008E3054
		public int TrkEmergencyToneSelection_42055Value
		{
			get
			{
				short num = (short)1457142712;
				short num2 = num;
				num = (short)175455160;
				switch (num2 == num)
				{
				default:
				{
					num = (short)558104576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1730084865;
				if (num != 0)
				{
				}
				num = (short)1334050816;
				if (num != 0)
				{
				}
				return this.trkEmergencyToneSelection_42055.Value;
			}
			set
			{
				short num = (short)436493751;
				short num2 = num;
				num = (short)1496473015;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2002583552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)907149313;
				if (num != 0)
				{
				}
				num = (short)1371537408;
				if (num != 0)
				{
				}
				this.trkEmergencyToneSelection_42055.Value = value;
			}
		}

		// Token: 0x17004C3A RID: 19514
		// (get) Token: 0x060097AA RID: 38826 RVA: 0x008E4F08 File Offset: 0x008E3108
		// (set) Token: 0x060097AB RID: 38827 RVA: 0x008E4FBC File Offset: 0x008E31BC
		public string TrkEmergencyToneSelection_42055_UIValue
		{
			get
			{
				short num = (short)1435964456;
				short num2 = num;
				num = (short)552866856;
				switch (num2 == num)
				{
				default:
				{
					num = (short)946995200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2080243713;
				if (num != 0)
				{
				}
				num = (short)1669660672;
				if (num != 0)
				{
				}
				return this.trkEmergencyToneSelection_42055.UIValue;
			}
			set
			{
				short num = (short)1866127743;
				short num2 = num;
				num = (short)2062014847;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1678442496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)906362881;
				if (num != 0)
				{
				}
				num = (short)1207173120;
				if (num != 0)
				{
				}
				this.trkEmergencyToneSelection_42055.UIValue = value;
			}
		}

		// Token: 0x17004C3B RID: 19515
		// (get) Token: 0x060097AC RID: 38828 RVA: 0x008E5070 File Offset: 0x008E3270
		public global::AcpBusinessLayer.AcpRecRefField TrkEmergencyToneSelection_42055
		{
			get
			{
				short num = (short)2100266957;
				short num2 = num;
				num = (short)1887340493;
				switch (num2 == num)
				{
				default:
				{
					num = (short)285474816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)403636225;
				if (num != 0)
				{
				}
				num = (short)1526136832;
				if (num != 0)
				{
				}
				return this.trkEmergencyToneSelection_42055;
			}
		}

		// Token: 0x17004C3C RID: 19516
		// (get) Token: 0x060097AD RID: 38829 RVA: 0x008E511C File Offset: 0x008E331C
		// (set) Token: 0x060097AE RID: 38830 RVA: 0x008E51D0 File Offset: 0x008E33D0
		public bool TrkEmergencyToneSelection_42055_Applicable
		{
			get
			{
				short num = (short)1452084643;
				short num2 = num;
				num = (short)1255869859;
				switch (num2 == num)
				{
				default:
				{
					num = (short)199032832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2069692417;
				if (num != 0)
				{
				}
				num = (short)1394081792;
				if (num != 0)
				{
				}
				return this.trkEmergencyToneSelection_42055.Applicable;
			}
			set
			{
				short num = (short)1276694041;
				short num2 = num;
				num = (short)683331097;
				switch (num2 == num)
				{
				default:
				{
					num = (short)139067392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1658716161;
				if (num != 0)
				{
				}
				num = (short)206897152;
				if (num != 0)
				{
				}
				this.trkEmergencyToneSelection_42055.Applicable = value;
			}
		}

		// Token: 0x17004C3D RID: 19517
		// (get) Token: 0x060097AF RID: 38831 RVA: 0x008E5288 File Offset: 0x008E3488
		// (set) Token: 0x060097B0 RID: 38832 RVA: 0x008E5340 File Offset: 0x008E3540
		public bool TrkEmergencyToneSelection_42055_Valid
		{
			get
			{
				short num = (short)95643131;
				short num2 = num;
				num = (short)164652539;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1685061632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)74645505;
				if (num != 0)
				{
				}
				num = (short)1150877696;
				if (num != 0)
				{
				}
				return this.trkEmergencyToneSelection_42055.Valid;
			}
			set
			{
				short num = (short)111391429;
				short num2 = num;
				num = (short)1633465029;
				switch (num2 == num)
				{
				default:
				{
					num = (short)947257344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1563099136;
				if (num != 0)
				{
				}
				num = (short)29163521;
				if (num != 0)
				{
				}
				this.trkEmergencyToneSelection_42055.Valid = value;
			}
		}

		// Token: 0x17004C3E RID: 19518
		// (get) Token: 0x060097B1 RID: 38833 RVA: 0x008E53F4 File Offset: 0x008E35F4
		// (set) Token: 0x060097B2 RID: 38834 RVA: 0x008E54AC File Offset: 0x008E36AC
		public bool TrkEmergencyToneSelection_42055_Visible
		{
			get
			{
				short num = (short)511705089;
				if (num != 0)
				{
				}
				num = (short)1406664704;
				short num2 = num;
				num = (short)1287201475;
				short num3 = num;
				num = (short)164700867;
				switch (num3 == num)
				{
				}
				num = (short)1821638656;
				if (num != 0)
				{
				}
				return this.trkEmergencyToneSelection_42055.Visible;
			}
			set
			{
				short num = (short)811317386;
				short num2 = num;
				num = (short)526497930;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2031943680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1463222273;
				if (num != 0)
				{
				}
				num = (short)504430592;
				if (num != 0)
				{
				}
				this.trkEmergencyToneSelection_42055.Visible = value;
			}
		}

		// Token: 0x17004C3F RID: 19519
		// (get) Token: 0x060097B3 RID: 38835 RVA: 0x008E5564 File Offset: 0x008E3764
		// (set) Token: 0x060097B4 RID: 38836 RVA: 0x008E561C File Offset: 0x008E381C
		public bool TrkEmergencyToneSelection_42055_Editable
		{
			get
			{
				short num = (short)227925516;
				short num2 = num;
				num = (short)2039275020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)618463232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1437401089;
				if (num != 0)
				{
				}
				num = (short)556072960;
				if (num != 0)
				{
				}
				return this.trkEmergencyToneSelection_42055.Editable;
			}
			set
			{
				short num = (short)545702483;
				short num2 = num;
				num = (short)384746067;
				switch (num2 == num)
				{
				default:
				{
					num = (short)737935360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)404619265;
				if (num != 0)
				{
				}
				num = (short)336396288;
				if (num != 0)
				{
				}
				this.trkEmergencyToneSelection_42055.Editable = value;
			}
		}

		// Token: 0x17004C40 RID: 19520
		// (get) Token: 0x060097B5 RID: 38837 RVA: 0x008E56D0 File Offset: 0x008E38D0
		internal string TrkEmergencyToneSelection_42055_UILabel
		{
			get
			{
				short num = (short)1752245208;
				short num2 = num;
				num = (short)1168843736;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1309605888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1717829632;
				if (num != 0)
				{
				}
				num = (short)494731265;
				if (num != 0)
				{
				}
				return this.trkEmergencyToneSelection_42055.UIName;
			}
		}

		// Token: 0x17004C41 RID: 19521
		// (get) Token: 0x060097B6 RID: 38838 RVA: 0x008E5784 File Offset: 0x008E3984
		// (set) Token: 0x060097B7 RID: 38839 RVA: 0x008E5838 File Offset: 0x008E3A38
		internal bool TrkEmergencyToneSelection_42055_HiddenStatic
		{
			get
			{
				short num = (short)1519994335;
				short num2 = num;
				num = (short)97797599;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1456603136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)458424321;
				if (num != 0)
				{
				}
				num = (short)1724907520;
				if (num != 0)
				{
				}
				return this.trkEmergencyToneSelection_42055.HiddenStatic;
			}
			set
			{
				short num = (short)634571662;
				short num2 = num;
				num = (short)1026214798;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1600585728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1600847873;
				if (num != 0)
				{
				}
				num = (short)128647168;
				if (num != 0)
				{
				}
				this.trkEmergencyToneSelection_42055.HiddenStatic = value;
			}
		}

		// Token: 0x17004C42 RID: 19522
		// (get) Token: 0x060097B8 RID: 38840 RVA: 0x008E58EC File Offset: 0x008E3AEC
		// (set) Token: 0x060097B9 RID: 38841 RVA: 0x008E59A4 File Offset: 0x008E3BA4
		internal bool TrkEmergencyToneSelection_42055_HiddenDynamic
		{
			get
			{
				short num = (short)67680143;
				short num2 = num;
				num = (short)94091151;
				switch (num2 == num)
				{
				default:
				{
					num = (short)820183040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1464008705;
				if (num != 0)
				{
				}
				num = (short)1643511808;
				if (num != 0)
				{
				}
				return this.trkEmergencyToneSelection_42055.HiddenDynamic;
			}
			set
			{
				short num = (short)932392322;
				short num2 = num;
				num = (short)595078530;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1452474368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)596508673;
				if (num != 0)
				{
				}
				num = (short)1481113600;
				if (num != 0)
				{
				}
				this.trkEmergencyToneSelection_42055.HiddenDynamic = value;
			}
		}

		// Token: 0x17004C43 RID: 19523
		// (get) Token: 0x060097BA RID: 38842 RVA: 0x008E5A5C File Offset: 0x008E3C5C
		public bool TrkEmergencyToneSelection_42055_HasDiffs
		{
			get
			{
				short num = (short)93292090;
				short num2 = num;
				num = (short)1127450170;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1638137856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1641480192;
				if (num != 0)
				{
				}
				num = (short)1988100097;
				if (num != 0)
				{
				}
				return this.trkEmergencyToneSelection_42055._HasDiffs;
			}
		}

		// Token: 0x060097BB RID: 38843 RVA: 0x008E5B14 File Offset: 0x008E3D14
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
					goto IL_12B;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)2140536836;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
				{
					if (base.ParentRecset == null)
					{
						return result;
					}
					num2 = (short)1313687971;
					short num3 = num2;
					num2 = (short)665864611;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12B;
					default:
						num2 = (short)1904017408;
						if (num2 != 0)
						{
						}
						num2 = (short)944504833;
						if (num2 != 0)
						{
						}
						num2 = (short)2058354688;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					return result;
				case 4:
				{
					num2 = (short)504954880;
					short num4 = num2;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1989214211;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_24;
				IL_12B:
				num2 = (short)473563137;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)80805890;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04004A50 RID: 19024
		private global::AcpBusinessLayer.AcpRecRefField trkEmergencyToneSelection_42055;
	}
}
