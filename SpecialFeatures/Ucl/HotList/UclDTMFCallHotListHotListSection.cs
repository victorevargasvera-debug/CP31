using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001D8 RID: 472
	[global::System.Serializable]
	public sealed class UclDTMFCallHotListHotListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x060016D7 RID: 5847 RVA: 0x001F6444 File Offset: 0x001F4644
		// (set) Token: 0x060016D8 RID: 5848 RVA: 0x001F64F8 File Offset: 0x001F46F8
		public string HotListAlias
		{
			get
			{
				short num = (short)787766553;
				short num2 = num;
				num = (short)528768281;
				switch (num2 == num)
				{
				default:
				{
					num = (short)365035520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1339490305;
				if (num != 0)
				{
				}
				num = (short)902758400;
				if (num != 0)
				{
				}
				return this.hotListAlias.Value;
			}
			set
			{
				short num = (short)280484664;
				short num2 = num;
				num = (short)1646648120;
				switch (num2 == num)
				{
				default:
				{
					num = (short)63176704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1749549056;
				if (num != 0)
				{
				}
				num = (short)1760755713;
				if (num != 0)
				{
				}
				this.hotListAlias.Value = value;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x001F65AC File Offset: 0x001F47AC
		public global::AcpBusinessLayer.AcpKeyField HotListAliasObject
		{
			get
			{
				short num = (short)149101881;
				short num2 = num;
				num = (short)1905401145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1325793280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2067857409;
				if (num != 0)
				{
				}
				num = (short)1706164224;
				if (num != 0)
				{
				}
				return this.hotListAlias;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x001F665C File Offset: 0x001F485C
		internal string HotListAlias_UILabel
		{
			get
			{
				short num = (short)264188079;
				short num2 = num;
				num = (short)377958575;
				switch (num2 == num)
				{
				default:
				{
					num = (short)410320896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)838270976;
				if (num != 0)
				{
				}
				num = (short)1563557889;
				if (num != 0)
				{
				}
				return this.hotListAlias.UIName;
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x001F6710 File Offset: 0x001F4910
		// (set) Token: 0x060016DC RID: 5852 RVA: 0x001F67C4 File Offset: 0x001F49C4
		public bool HotListAlias_Applicable
		{
			get
			{
				short num = (short)1182240190;
				short num2 = num;
				num = (short)409177534;
				switch (num2 == num)
				{
				default:
				{
					num = (short)33554432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1937178625;
				if (num != 0)
				{
				}
				num = (short)835387392;
				if (num != 0)
				{
				}
				return this.hotListAlias.Applicable;
			}
			set
			{
				short num = (short)993273595;
				short num2 = num;
				num = (short)190260987;
				switch (num2 == num)
				{
				default:
				{
					num = (short)567083008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)253952000;
				if (num != 0)
				{
				}
				num = (short)514392065;
				if (num != 0)
				{
				}
				this.hotListAlias.Applicable = value;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x001F687C File Offset: 0x001F4A7C
		// (set) Token: 0x060016DE RID: 5854 RVA: 0x001F6930 File Offset: 0x001F4B30
		public bool HotListAlias_Editable
		{
			get
			{
				short num = (short)66766624;
				short num2 = num;
				num = (short)415876896;
				switch (num2 == num)
				{
				default:
				{
					num = (short)680591360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1519190016;
				if (num != 0)
				{
				}
				num = (short)990838785;
				if (num != 0)
				{
				}
				return this.hotListAlias.Editable;
			}
			set
			{
				short num = (short)1400383995;
				short num2 = num;
				num = (short)106375675;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1856765952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2078932992;
				if (num != 0)
				{
				}
				num = (short)1418723329;
				if (num != 0)
				{
				}
				this.hotListAlias.Editable = value;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x060016DF RID: 5855 RVA: 0x001F69E8 File Offset: 0x001F4BE8
		// (set) Token: 0x060016E0 RID: 5856 RVA: 0x001F6AA0 File Offset: 0x001F4CA0
		public bool HotListAlias_Visible
		{
			get
			{
				short num = (short)1041486628;
				short num2 = num;
				num = (short)2040714020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2106195968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)300482561;
				if (num != 0)
				{
				}
				num = (short)1545666560;
				if (num != 0)
				{
				}
				return this.hotListAlias.Visible;
			}
			set
			{
				short num = (short)1030615701;
				short num2 = num;
				num = (short)1034482325;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1305870336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)49020929;
				if (num != 0)
				{
				}
				num = (short)1695219712;
				if (num != 0)
				{
				}
				this.hotListAlias.Visible = value;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x001F6B58 File Offset: 0x001F4D58
		// (set) Token: 0x060016E2 RID: 5858 RVA: 0x001F6C0C File Offset: 0x001F4E0C
		internal bool HotListAlias_HiddenStatic
		{
			get
			{
				short num = (short)1401028609;
				if (num != 0)
				{
				}
				num = (short)1174142976;
				short num2 = num;
				num = (short)651216049;
				short num3 = num;
				num = (short)185517233;
				switch (num3 == num)
				{
				}
				num = (short)210960384;
				if (num != 0)
				{
				}
				return this.hotListAlias.HiddenStatic;
			}
			set
			{
				short num = (short)1444563931;
				short num2 = num;
				num = (short)1260473307;
				switch (num2 == num)
				{
				default:
				{
					num = (short)918028288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)839385089;
				if (num != 0)
				{
				}
				num = (short)973930496;
				if (num != 0)
				{
				}
				this.hotListAlias.HiddenStatic = value;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x001F6CC4 File Offset: 0x001F4EC4
		// (set) Token: 0x060016E4 RID: 5860 RVA: 0x001F6D78 File Offset: 0x001F4F78
		public bool HotListAlias_Valid
		{
			get
			{
				short num = (short)1617428481;
				if (num != 0)
				{
				}
				num = (short)1635713024;
				short num2 = num;
				num = (short)8526644;
				short num3 = num;
				num = (short)624761652;
				switch (num3 == num)
				{
				}
				num = (short)557187072;
				if (num != 0)
				{
				}
				return this.hotListAlias.Valid;
			}
			set
			{
				short num = (short)1247639679;
				short num2 = num;
				num = (short)1088256127;
				switch (num2 == num)
				{
				default:
				{
					num = (short)592445440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)841482240;
				if (num != 0)
				{
				}
				num = (short)1148977153;
				if (num != 0)
				{
				}
				this.hotListAlias.Valid = value;
			}
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x00003A5B File Offset: 0x00001C5B
		internal UclDTMFCallHotListHotListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
			base.EmbeddedRecset = this.dTMFCallHotListRecset;
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x001F6E30 File Offset: 0x001F5030
		public global::SpecialFeatures.Ucl.HotList.DTMFCallHotListRecset DTMFCallHotListRecset
		{
			get
			{
				short num = (short)57847435;
				short num2 = num;
				num = (short)497725067;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1928658944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1329070081;
				if (num != 0)
				{
				}
				num = (short)787218432;
				if (num != 0)
				{
				}
				return this.dTMFCallHotListRecset;
			}
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x001F6EE0 File Offset: 0x001F50E0
		public override void PopulateReferences()
		{
			short num = (short)218759169;
			if (num != 0)
			{
			}
			num = (short)1687093248;
			short num2 = num;
			num = (short)1053650858;
			short num3 = num;
			num = (short)178220970;
			switch (num3 == num)
			{
			}
			num = (short)399441920;
			if (num != 0)
			{
			}
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x001F6F8C File Offset: 0x001F518C
		public override void DropReferences()
		{
			short num = (short)1693372477;
			short num2 = num;
			num = (short)2081411133;
			switch (num2 == num)
			{
			default:
			{
				num = (short)529465344;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2046164992;
			if (num != 0)
			{
			}
			num = (short)1060634625;
			if (num != 0)
			{
			}
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x001F7038 File Offset: 0x001F5238
		public override void SetupDependencies()
		{
			short num = (short)518701849;
			short num2 = num;
			num = (short)958841625;
			switch (num2 == num)
			{
			default:
			{
				num = (short)157810688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)61669377;
			if (num != 0)
			{
			}
			num = (short)1937244160;
			if (num != 0)
			{
			}
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x001F70E4 File Offset: 0x001F52E4
		public override void SetConstraints()
		{
			short num = (short)1185823725;
			short num2 = num;
			num = (short)2104638445;
			switch (num2 == num)
			{
			}
			num = (short)1420754944;
			if (num != 0)
			{
			}
			num = (short)330956801;
			if (num != 0)
			{
			}
			num = (short)1816199168;
			short num3 = num;
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x001F718C File Offset: 0x001F538C
		public override void Init()
		{
			int a_ = 18;
			short num = (short)1817864591;
			short num2 = num;
			num = (short)1286105487;
			switch (num2 == num)
			{
			}
			num = (short)1622409217;
			if (num != 0)
			{
			}
			num = (short)725483520;
			if (num != 0)
			{
			}
			num = (short)1515454464;
			short num3 = num;
			this.dTMFCallHotListRecset = new global::SpecialFeatures.Ucl.HotList.DTMFCallHotListRecset();
			this.hotListAlias = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd94햠쪤즦\udda8쪪캬\udbae\udfb2\udcb4횶쪸", a_), global::CommonResources.AppResources.Hot_List_Alias);
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톔쎖풘\udd9a붜\udc9e삠쾢즤螦쒪\ud9ac辮ﶰ\udab2운쎶", a_);
			base.UIName = global::CommonResources.AppResources.DTMF_Call_Hot_List;
			base.Id = 10423;
			base.DataTransferOrder = 12;
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x001F7298 File Offset: 0x001F5498
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)2091565294;
			short num2 = num;
			num = (short)1519632622;
			switch (num2 == num)
			{
			}
			num = (short)1783693313;
			if (num != 0)
			{
			}
			num = (short)1001521152;
			if (num != 0)
			{
			}
			num = (short)1943994368;
			short num3 = num;
			base.GetObjectData(info, context);
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x001F734C File Offset: 0x001F554C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 3;
			short num = (short)1837170690;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)2007421887;
					short num3 = num;
					num = (short)262329279;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F;
					default:
					{
						num = (short)462880768;
						if (num != 0)
						{
						}
						num = (short)871956480;
						short num4 = num;
						if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캅ﺉ힓秊ﶛﶝ풟좣쾥즧\ud9a9", a_)))
						{
							num = (short)1911947267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C5;
					}
					}
					break;
				}
				case 1:
					num = (short)1387069440;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1F;
				case 3:
					num = (short)1160904705;
					if (num != 0)
					{
					}
					this.hotListAlias = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캅ﺉ힓秊ﶛﶝ풟좣쾥즧\ud9a9", a_), global::CommonResources.AppResources.Hot_List_Alias);
					num = (short)122028038;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1106247685;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields != null)
					{
						num = (short)404226049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C5;
				case 6:
					goto IL_A4;
				}
				goto IL_4B;
				IL_1F:
				switch (0)
				{
				case 0:
					IL_4B:
					if (!global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						goto IL_1C5;
					}
					num = (short)234422276;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_A4:
			IL_1C5:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슅\udc87잉쪋꺍펏歹뢗튙肟춣향\udca7", a_);
			base.UIName = global::CommonResources.AppResources.DTMF_Call_Hot_List;
			base.Id = 10423;
			base.DataTransferOrder = 12;
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x0000265F File Offset: 0x0000085F
		internal UclDTMFCallHotListHotListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04000BC5 RID: 3013
		private global::SpecialFeatures.Ucl.HotList.DTMFCallHotListRecset dTMFCallHotListRecset;

		// Token: 0x04000BC6 RID: 3014
		private global::AcpBusinessLayer.AcpKeyField hotListAlias;
	}
}
