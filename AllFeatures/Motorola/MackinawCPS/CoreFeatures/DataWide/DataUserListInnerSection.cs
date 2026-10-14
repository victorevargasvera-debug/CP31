using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004D1 RID: 1233
	[global::System.Serializable]
	public class DataUserListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600A31F RID: 41759 RVA: 0x00981458 File Offset: 0x0097F658
		public DataUserListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600A320 RID: 41760 RVA: 0x00981474 File Offset: 0x0097F674
		protected DataUserListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600A321 RID: 41761 RVA: 0x0098148C File Offset: 0x0097F68C
		public override void Init()
		{
			int a_ = 13;
			short num = (short)6707507;
			short num2 = num;
			num = (short)2110740787;
			switch (num2 == num)
			{
			}
			num = (short)394330112;
			short num3 = num;
			num = (short)294780929;
			if (num != 0)
			{
			}
			num = (short)2020343808;
			if (num != 0)
			{
			}
			this.dataWideDataUserListDataUserInformation_A7800 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_USERNAME1, this, global::AllFeatures.CodeplugGuid.b("諍뇏ꛑ뗓臕뇗뻙맛髝臟雡藣돥鯧迩黫ꋭ駯臱胳답駷軹鷻꯽珿朁瘃伅昇氉挋簍紏猑怓缕眗琙䌛弝ᜟᨡᐣᘥ", a_), global::CommonResources.AcgResources.ID_DATAUSERNAME, 40);
			this.dataWideDataUserListDataUserInformation_A7800.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideDataUserListDataUserInformation_A7800.DataTransferOrder = 15;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諍뇏ꛑ뗓跗꧙맛곝샟껡跣闥鳧", a_);
			base.Id = 10070;
			base.UIName = global::CommonResources.AcgResources.ID_DATAUSERLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600A322 RID: 41762 RVA: 0x009815B4 File Offset: 0x0097F7B4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)304218118;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_136;
				case 1:
					goto IL_152;
				case 2:
					this.dataWideDataUserListDataUserInformation_A7800 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_USERNAME1, this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟ꛡ藣鋥觧뿩鿫语苯뻱鷳藵賷뻹鷻諽懿圁眃挅稇䌉戋栍缏怑礓眕気猙猛瀝缟挡ጣḥᠧᨩ", a_), global::CommonResources.AcgResources.ID_DATAUSERNAME, 40);
					this.dataWideDataUserListDataUserInformation_A7800.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideDataUserListDataUserInformation_A7800.DataTransferOrder = 15;
					num = (short)1802108928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields != null)
					{
						num = (short)640876549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B9;
				case 4:
				{
					num = (short)161939456;
					short num3 = num;
					num = (short)1226113027;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					num = (short)431030273;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				}
				IL_49:
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					break;
				}
				num = (short)89423038;
				short num4 = num;
				num = (short)222133438;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1085603840;
					if (num != 0)
					{
					}
					num = (short)810549252;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_152:
				if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟ꛡ藣鋥觧뿩鿫语苯뻱鷳藵賷뻹鷻諽懿圁眃挅稇䌉戋栍缏怑礓眕気猙猛瀝缟挡ጣḥᠧᨩ", a_)))
				{
					break;
				}
				num = (short)1624309762;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_136:
			IL_1B9:
			num = (short)1410465793;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗龎觛귝藟郡쓣ꫥ臧駩飫", a_);
			base.Id = 10070;
			base.UIName = global::CommonResources.AcgResources.ID_DATAUSERLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600A323 RID: 41763 RVA: 0x009817D4 File Offset: 0x0097F9D4
		public override void PopulateReferences()
		{
			short num = (short)1798393387;
			short num2 = num;
			num = (short)995642923;
			switch (num2 == num)
			{
			}
			num = (short)406978560;
			short num3 = num;
			num = (short)114819072;
			if (num != 0)
			{
			}
			num = (short)1847066625;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A324 RID: 41764 RVA: 0x0098187C File Offset: 0x0097FA7C
		public override void DropReferences()
		{
			short num = (short)1899924225;
			short num2 = num;
			num = (short)357796609;
			switch (num2 == num)
			{
			}
			num = (short)2032795648;
			short num3 = num;
			num = (short)836763649;
			if (num != 0)
			{
			}
			num = (short)1142423552;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A325 RID: 41765 RVA: 0x00981928 File Offset: 0x0097FB28
		public override void SetConstraints()
		{
			short num = (short)474638759;
			short num2 = num;
			num = (short)427452839;
			switch (num2 == num)
			{
			}
			num = (short)466681856;
			short num3 = num;
			num = (short)1767505921;
			if (num != 0)
			{
			}
			num = (short)1247215616;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A326 RID: 41766 RVA: 0x009819D0 File Offset: 0x0097FBD0
		public override void SetupDependencies()
		{
			short num = (short)1656160735;
			short num2 = num;
			num = (short)332726751;
			switch (num2 == num)
			{
			}
			num = (short)37421056;
			short num3 = num;
			num = (short)122814465;
			if (num != 0)
			{
			}
			num = (short)1173225472;
			if (num != 0)
			{
			}
		}

		// Token: 0x170051BC RID: 20924
		// (get) Token: 0x0600A327 RID: 41767 RVA: 0x00981A7C File Offset: 0x0097FC7C
		public bool HasDiffs
		{
			get
			{
				short num = (short)202728748;
				short num2 = num;
				num = (short)1684038956;
				switch (num2 == num)
				{
				}
				num = (short)1885339648;
				short num3 = num;
				num = (short)1291124737;
				if (num != 0)
				{
				}
				num = (short)141033472;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170051BD RID: 20925
		// (get) Token: 0x0600A328 RID: 41768 RVA: 0x00981B2C File Offset: 0x0097FD2C
		// (set) Token: 0x0600A329 RID: 41769 RVA: 0x00981BE0 File Offset: 0x0097FDE0
		public string DataWideDataUserListDataUserInformation_A7800Value
		{
			get
			{
				short num = (short)726846320;
				short num2 = num;
				num = (short)265669488;
				switch (num2 == num)
				{
				}
				num = (short)2123431936;
				short num3 = num;
				num = (short)274071553;
				if (num != 0)
				{
				}
				num = (short)1840644096;
				if (num != 0)
				{
				}
				return this.dataWideDataUserListDataUserInformation_A7800.Value;
			}
			set
			{
				short num = (short)1620112718;
				short num2 = num;
				num = (short)87684430;
				switch (num2 == num)
				{
				}
				num = (short)922157056;
				short num3 = num;
				num = (short)128188417;
				if (num != 0)
				{
				}
				num = (short)1180106752;
				if (num != 0)
				{
				}
				this.dataWideDataUserListDataUserInformation_A7800.Value = value;
			}
		}

		// Token: 0x170051BE RID: 20926
		// (get) Token: 0x0600A32A RID: 41770 RVA: 0x00981C98 File Offset: 0x0097FE98
		public global::AcpBusinessLayer.AcpField<string> DataWideDataUserListDataUserInformation_A7800
		{
			get
			{
				short num = (short)777012443;
				short num2 = num;
				num = (short)617366747;
				switch (num2 == num)
				{
				}
				num = (short)319619072;
				short num3 = num;
				num = (short)168034305;
				if (num != 0)
				{
				}
				num = (short)1703804928;
				if (num != 0)
				{
				}
				return this.dataWideDataUserListDataUserInformation_A7800;
			}
		}

		// Token: 0x170051BF RID: 20927
		// (get) Token: 0x0600A32B RID: 41771 RVA: 0x00981D48 File Offset: 0x0097FF48
		// (set) Token: 0x0600A32C RID: 41772 RVA: 0x00981DFC File Offset: 0x0097FFFC
		public string DataWideDataUserListDataUserInformation_A7800_UIValue
		{
			get
			{
				short num = (short)81102010;
				short num2 = num;
				num = (short)1684702394;
				switch (num2 == num)
				{
				}
				num = (short)426835968;
				short num3 = num;
				num = (short)345243648;
				if (num != 0)
				{
				}
				num = (short)935591937;
				if (num != 0)
				{
				}
				return this.dataWideDataUserListDataUserInformation_A7800.Value;
			}
			set
			{
				short num = (short)467009537;
				if (num != 0)
				{
				}
				num = (short)283595074;
				short num2 = num;
				num = (short)1531269442;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1171062784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1096089600;
				if (num != 0)
				{
				}
				this.dataWideDataUserListDataUserInformation_A7800.Value = value;
			}
		}

		// Token: 0x170051C0 RID: 20928
		// (get) Token: 0x0600A32D RID: 41773 RVA: 0x00981EB0 File Offset: 0x009800B0
		// (set) Token: 0x0600A32E RID: 41774 RVA: 0x00981F64 File Offset: 0x00980164
		public bool DataWideDataUserListDataUserInformation_A7800_Applicable
		{
			get
			{
				short num = (short)1834145309;
				short num2 = num;
				num = (short)65787421;
				switch (num2 == num)
				{
				}
				num = (short)351010816;
				short num3 = num;
				num = (short)1950154753;
				if (num != 0)
				{
				}
				num = (short)1069809664;
				if (num != 0)
				{
				}
				return this.dataWideDataUserListDataUserInformation_A7800.Applicable;
			}
			set
			{
				short num = (short)1178606421;
				short num2 = num;
				num = (short)1303780181;
				switch (num2 == num)
				{
				}
				num = (short)1972830208;
				short num3 = num;
				num = (short)497549312;
				if (num != 0)
				{
				}
				num = (short)849149953;
				if (num != 0)
				{
				}
				this.dataWideDataUserListDataUserInformation_A7800.Applicable = value;
			}
		}

		// Token: 0x170051C1 RID: 20929
		// (get) Token: 0x0600A32F RID: 41775 RVA: 0x0098201C File Offset: 0x0098021C
		// (set) Token: 0x0600A330 RID: 41776 RVA: 0x009820D4 File Offset: 0x009802D4
		public bool DataWideDataUserListDataUserInformation_A7800_Valid
		{
			get
			{
				short num = (short)23920641;
				if (num != 0)
				{
				}
				num = (short)1436425989;
				short num2 = num;
				num = (short)343416581;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1707081728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)995557376;
				if (num != 0)
				{
				}
				return this.dataWideDataUserListDataUserInformation_A7800.Valid;
			}
			set
			{
				short num = (short)182156313;
				short num2 = num;
				num = (short)540113945;
				switch (num2 == num)
				{
				}
				num = (short)336658432;
				short num3 = num;
				num = (short)1199767553;
				if (num != 0)
				{
				}
				num = (short)1891172352;
				if (num != 0)
				{
				}
				this.dataWideDataUserListDataUserInformation_A7800.Valid = value;
			}
		}

		// Token: 0x170051C2 RID: 20930
		// (get) Token: 0x0600A331 RID: 41777 RVA: 0x0098218C File Offset: 0x0098038C
		// (set) Token: 0x0600A332 RID: 41778 RVA: 0x00982244 File Offset: 0x00980444
		public bool DataWideDataUserListDataUserInformation_A7800_Visible
		{
			get
			{
				short num = (short)1370805813;
				short num2 = num;
				num = (short)968021557;
				switch (num2 == num)
				{
				}
				num = (short)1846411264;
				short num3 = num;
				num = (short)560005121;
				if (num != 0)
				{
				}
				num = (short)1776549888;
				if (num != 0)
				{
				}
				return this.dataWideDataUserListDataUserInformation_A7800.Visible;
			}
			set
			{
				short num = (short)338839424;
				short num2 = num;
				num = (short)358172544;
				switch (num2 == num)
				{
				}
				num = (short)415956992;
				short num3 = num;
				num = (short)1368653824;
				if (num != 0)
				{
				}
				num = (short)325582849;
				if (num != 0)
				{
				}
				this.dataWideDataUserListDataUserInformation_A7800.Visible = value;
			}
		}

		// Token: 0x170051C3 RID: 20931
		// (get) Token: 0x0600A333 RID: 41779 RVA: 0x009822FC File Offset: 0x009804FC
		// (set) Token: 0x0600A334 RID: 41780 RVA: 0x009823B4 File Offset: 0x009805B4
		public bool DataWideDataUserListDataUserInformation_A7800_Editable
		{
			get
			{
				short num = (short)2130313217;
				if (num != 0)
				{
				}
				num = (short)430993095;
				short num2 = num;
				num = (short)1460367047;
				switch (num2 == num)
				{
				default:
				{
					num = (short)224985088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1986789376;
				if (num != 0)
				{
				}
				return this.dataWideDataUserListDataUserInformation_A7800.Editable;
			}
			set
			{
				short num = (short)144697964;
				short num2 = num;
				num = (short)931654252;
				switch (num2 == num)
				{
				}
				num = (short)1065746432;
				short num3 = num;
				num = (short)1857290241;
				if (num != 0)
				{
				}
				num = (short)614793216;
				if (num != 0)
				{
				}
				this.dataWideDataUserListDataUserInformation_A7800.Editable = value;
			}
		}

		// Token: 0x170051C4 RID: 20932
		// (get) Token: 0x0600A335 RID: 41781 RVA: 0x00982468 File Offset: 0x00980668
		internal string DataWideDataUserListDataUserInformation_A7800_UILabel
		{
			get
			{
				short num = (short)452263937;
				if (num != 0)
				{
				}
				num = (short)633061652;
				short num2 = num;
				num = (short)875086100;
				switch (num2 == num)
				{
				default:
				{
					num = (short)3670016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1569259520;
				if (num != 0)
				{
				}
				return this.dataWideDataUserListDataUserInformation_A7800.UIName;
			}
		}

		// Token: 0x170051C5 RID: 20933
		// (get) Token: 0x0600A336 RID: 41782 RVA: 0x0098251C File Offset: 0x0098071C
		// (set) Token: 0x0600A337 RID: 41783 RVA: 0x009825D0 File Offset: 0x009807D0
		internal bool DataWideDataUserListDataUserInformation_A7800_HiddenStatic
		{
			get
			{
				short num = (short)609550337;
				if (num != 0)
				{
				}
				num = (short)1840439589;
				short num2 = num;
				num = (short)638574885;
				switch (num2 == num)
				{
				default:
				{
					num = (short)248053760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1161822208;
				if (num != 0)
				{
				}
				return this.dataWideDataUserListDataUserInformation_A7800.HiddenStatic;
			}
			set
			{
				short num = (short)383407042;
				short num2 = num;
				num = (short)1967281090;
				switch (num2 == num)
				{
				}
				num = (short)100597760;
				short num3 = num;
				num = (short)501678081;
				if (num != 0)
				{
				}
				num = (short)397213696;
				if (num != 0)
				{
				}
				this.dataWideDataUserListDataUserInformation_A7800.HiddenStatic = value;
			}
		}

		// Token: 0x170051C6 RID: 20934
		// (get) Token: 0x0600A338 RID: 41784 RVA: 0x00982684 File Offset: 0x00980884
		// (set) Token: 0x0600A339 RID: 41785 RVA: 0x00982738 File Offset: 0x00980938
		internal bool DataWideDataUserListDataUserInformation_A7800_HiddenDynamic
		{
			get
			{
				short num = (short)1732587506;
				short num2 = num;
				num = (short)339488754;
				switch (num2 == num)
				{
				}
				num = (short)527892480;
				short num3 = num;
				num = (short)1825177600;
				if (num != 0)
				{
				}
				num = (short)403701761;
				if (num != 0)
				{
				}
				return this.dataWideDataUserListDataUserInformation_A7800.HiddenDynamic;
			}
			set
			{
				short num = (short)266335126;
				short num2 = num;
				num = (short)1670443926;
				switch (num2 == num)
				{
				}
				num = (short)1907490816;
				short num3 = num;
				num = (short)2134441985;
				if (num != 0)
				{
				}
				num = (short)1914437632;
				if (num != 0)
				{
				}
				this.dataWideDataUserListDataUserInformation_A7800.HiddenDynamic = value;
			}
		}

		// Token: 0x170051C7 RID: 20935
		// (get) Token: 0x0600A33A RID: 41786 RVA: 0x009827F0 File Offset: 0x009809F0
		public bool DataWideDataUserListDataUserInformation_A7800_HasDiffs
		{
			get
			{
				short num = (short)751290516;
				short num2 = num;
				num = (short)152160404;
				switch (num2 == num)
				{
				}
				num = (short)1521942528;
				short num3 = num;
				num = (short)1144913921;
				if (num != 0)
				{
				}
				num = (short)869007360;
				if (num != 0)
				{
				}
				return this.dataWideDataUserListDataUserInformation_A7800._HasDiffs;
			}
		}

		// Token: 0x0600A33B RID: 41787 RVA: 0x009828A4 File Offset: 0x00980AA4
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			short num;
			int num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)762052609;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					return result;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)2114387971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					num = (short)1959526401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1545631912;
					short num3 = num;
					num = (short)1854961832;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)305856512;
						if (num != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						break;
					}
					num = (short)850198528;
					short num4 = num;
					num = (short)276561920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (base.ParentRecset != null)
					{
						num = (short)22085634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				goto IL_4D;
			}
			return result;
			IL_4D:
			result = null;
			num = (short)1911816196;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04004E22 RID: 20002
		private global::AcpBusinessLayer.AcpField<string> dataWideDataUserListDataUserInformation_A7800;
	}
}
