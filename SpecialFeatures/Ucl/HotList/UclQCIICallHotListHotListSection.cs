using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001E6 RID: 486
	[global::System.Serializable]
	public sealed class UclQCIICallHotListHotListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x0600175F RID: 5983 RVA: 0x001FDED0 File Offset: 0x001FC0D0
		// (set) Token: 0x06001760 RID: 5984 RVA: 0x001FDF84 File Offset: 0x001FC184
		internal string HotListAlias
		{
			get
			{
				short num = (short)654311424;
				short num2 = num;
				num = (short)739480481;
				short num3 = num;
				num = (short)565875617;
				switch (num3 == num)
				{
				}
				num = (short)878051329;
				if (num != 0)
				{
				}
				num = (short)742064128;
				if (num != 0)
				{
				}
				return this.hotListAlias.Value;
			}
			set
			{
				short num = (short)1495138304;
				short num2 = num;
				num = (short)2026643662;
				short num3 = num;
				num = (short)1389895886;
				switch (num3 == num)
				{
				}
				num = (short)812384257;
				if (num != 0)
				{
				}
				num = (short)921370624;
				if (num != 0)
				{
				}
				this.hotListAlias.Value = value;
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x001FE03C File Offset: 0x001FC23C
		public global::AcpBusinessLayer.AcpKeyField HotListAliasObject
		{
			get
			{
				short num = (short)584908800;
				short num2 = num;
				num = (short)967976002;
				short num3 = num;
				num = (short)938681410;
				switch (num3 == num)
				{
				}
				num = (short)1860173825;
				if (num != 0)
				{
				}
				num = (short)81330176;
				if (num != 0)
				{
				}
				return this.hotListAlias;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x001FE0F0 File Offset: 0x001FC2F0
		internal string HotListAlias_UILabel
		{
			get
			{
				short num = (short)11206656;
				short num2 = num;
				num = (short)2115502081;
				if (num != 0)
				{
				}
				num = (short)1761925813;
				short num3 = num;
				num = (short)1986583221;
				switch (num3 == num)
				{
				}
				num = (short)1461125120;
				if (num != 0)
				{
				}
				return this.hotListAlias.UIName;
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x001FE1A4 File Offset: 0x001FC3A4
		// (set) Token: 0x06001764 RID: 5988 RVA: 0x001FE258 File Offset: 0x001FC458
		public bool HotListAlias_Applicable
		{
			get
			{
				short num = (short)1671561216;
				short num2 = num;
				num = (short)310000011;
				short num3 = num;
				num = (short)910834059;
				switch (num3 == num)
				{
				}
				num = (short)1856634881;
				if (num != 0)
				{
				}
				num = (short)786432;
				if (num != 0)
				{
				}
				return this.hotListAlias.Applicable;
			}
			set
			{
				short num = (short)17104896;
				short num2 = num;
				num = (short)1145896961;
				if (num != 0)
				{
				}
				num = (short)1433977658;
				short num3 = num;
				num = (short)569754426;
				switch (num3 == num)
				{
				}
				num = (short)416808960;
				if (num != 0)
				{
				}
				this.hotListAlias.Applicable = value;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001765 RID: 5989 RVA: 0x001FE30C File Offset: 0x001FC50C
		// (set) Token: 0x06001766 RID: 5990 RVA: 0x001FE3C4 File Offset: 0x001FC5C4
		public bool HotListAlias_Editable
		{
			get
			{
				short num = (short)61276160;
				short num2 = num;
				num = (short)273154049;
				if (num != 0)
				{
				}
				num = (short)1502407151;
				short num3 = num;
				num = (short)1627384303;
				switch (num3 == num)
				{
				}
				num = (short)1530593280;
				if (num != 0)
				{
				}
				return this.hotListAlias.Editable;
			}
			set
			{
				short num = (short)1883570176;
				short num2 = num;
				num = (short)951523365;
				short num3 = num;
				num = (short)955062309;
				switch (num3 == num)
				{
				}
				num = (short)1178140673;
				if (num != 0)
				{
				}
				num = (short)1070333952;
				if (num != 0)
				{
				}
				this.hotListAlias.Editable = value;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x001FE47C File Offset: 0x001FC67C
		// (set) Token: 0x06001768 RID: 5992 RVA: 0x001FE534 File Offset: 0x001FC734
		public bool HotListAlias_Visible
		{
			get
			{
				short num = (short)1019478016;
				short num2 = num;
				num = (short)1849588495;
				short num3 = num;
				num = (short)1103788815;
				switch (num3 == num)
				{
				}
				num = (short)1142161409;
				if (num != 0)
				{
				}
				num = (short)1587544064;
				if (num != 0)
				{
				}
				return this.hotListAlias.Visible;
			}
			set
			{
				short num = (short)1683226624;
				short num2 = num;
				num = (short)207760680;
				short num3 = num;
				num = (short)406007080;
				switch (num3 == num)
				{
				}
				num = (short)1163460609;
				if (num != 0)
				{
				}
				num = (short)1877213184;
				if (num != 0)
				{
				}
				this.hotListAlias.Visible = value;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x001FE5E8 File Offset: 0x001FC7E8
		// (set) Token: 0x0600176A RID: 5994 RVA: 0x001FE69C File Offset: 0x001FC89C
		internal bool HotListAlias_HiddenStatic
		{
			get
			{
				short num = (short)1982005248;
				short num2 = num;
				num = (short)1405596205;
				short num3 = num;
				num = (short)243577389;
				switch (num3 == num)
				{
				}
				num = (short)1987379201;
				if (num != 0)
				{
				}
				num = (short)54853632;
				if (num != 0)
				{
				}
				return this.hotListAlias.HiddenStatic;
			}
			set
			{
				short num = (short)234553344;
				short num2 = num;
				num = (short)1426213814;
				short num3 = num;
				num = (short)568478646;
				switch (num3 == num)
				{
				}
				num = (short)1666514944;
				if (num != 0)
				{
				}
				num = (short)943521793;
				if (num != 0)
				{
				}
				this.hotListAlias.HiddenStatic = value;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x001FE754 File Offset: 0x001FC954
		// (set) Token: 0x0600176C RID: 5996 RVA: 0x001FE808 File Offset: 0x001FCA08
		public bool HotListAlias_Valid
		{
			get
			{
				short num = (short)1665925120;
				short num2 = num;
				num = (short)1382018962;
				short num3 = num;
				num = (short)193261458;
				switch (num3 == num)
				{
				}
				num = (short)968032257;
				if (num != 0)
				{
				}
				num = (short)224460800;
				if (num != 0)
				{
				}
				return this.hotListAlias.Valid;
			}
			set
			{
				short num = (short)623247360;
				short num2 = num;
				num = (short)1623556823;
				short num3 = num;
				num = (short)97485527;
				switch (num3 == num)
				{
				}
				num = (short)1699938304;
				if (num != 0)
				{
				}
				num = (short)886833153;
				if (num != 0)
				{
				}
				this.hotListAlias.Valid = value;
			}
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x00003B3C File Offset: 0x00001D3C
		public UclQCIICallHotListHotListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
			base.EmbeddedRecset = this.qCIICallHotListRecset;
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x001FE8C0 File Offset: 0x001FCAC0
		public global::SpecialFeatures.Ucl.HotList.QCIICallHotListRecset QCIICallHotListRecset
		{
			get
			{
				short num = (short)2081095680;
				short num2 = num;
				num = (short)772971983;
				short num3 = num;
				num = (short)693804495;
				switch (num3 == num)
				{
				}
				num = (short)748552193;
				if (num != 0)
				{
				}
				num = (short)102105088;
				if (num != 0)
				{
				}
				return this.qCIICallHotListRecset;
			}
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x001FE970 File Offset: 0x001FCB70
		public override void PopulateReferences()
		{
			short num = (short)2042953728;
			short num2 = num;
			num = (short)790309470;
			short num3 = num;
			num = (short)801581662;
			switch (num3 == num)
			{
			}
			num = (short)2043346945;
			if (num != 0)
			{
			}
			num = (short)1547960320;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x001FEA18 File Offset: 0x001FCC18
		public override void DropReferences()
		{
			short num = (short)874512384;
			short num2 = num;
			num = (short)1148715009;
			if (num != 0)
			{
			}
			num = (short)851045915;
			short num3 = num;
			num = (short)776859163;
			switch (num3 == num)
			{
			}
			num = (short)1318649856;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x001FEAC0 File Offset: 0x001FCCC0
		public override void SetupDependencies()
		{
			short num = (short)1640890368;
			short num2 = num;
			num = (short)1427819998;
			short num3 = num;
			num = (short)2124598750;
			switch (num3 == num)
			{
			}
			num = (short)1437073408;
			if (num != 0)
			{
			}
			num = (short)1333592065;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x001FEB68 File Offset: 0x001FCD68
		public override void SetConstraints()
		{
			short num = (short)565903360;
			short num2 = num;
			num = (short)1390493424;
			short num3 = num;
			num = (short)496516848;
			switch (num3 == num)
			{
			}
			num = (short)994902017;
			if (num != 0)
			{
			}
			num = (short)501481472;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x001FEC10 File Offset: 0x001FCE10
		public override void Init()
		{
			int a_ = 7;
			short num = (short)1995898880;
			short num2 = num;
			num = (short)1679563939;
			short num3 = num;
			num = (short)963648675;
			switch (num3 == num)
			{
			}
			num = (short)1037828097;
			if (num != 0)
			{
			}
			num = (short)1315962880;
			if (num != 0)
			{
			}
			this.qCIICallHotListRecset = new global::SpecialFeatures.Ucl.HotList.QCIICallHotListRecset();
			this.hotListAlias = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슉揄ﲏﮑ\udb97솟송킣쒧쎩춫\uddad", a_), global::CommonResources.AppResources.Hot_List_Alias);
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb89쾋잍\ud98f늑힓벛횝쾟횡蒣솧\ud9a9\ud8ab", a_);
			base.UIName = global::CommonResources.AppResources.QCII_Call_Hot_List;
			base.Id = 10425;
			base.DataTransferOrder = 13;
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x001FED1C File Offset: 0x001FCF1C
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)522125312;
			short num2 = num;
			num = (short)1221388393;
			short num3 = num;
			num = (short)263514217;
			switch (num3 == num)
			{
			}
			num = (short)335544321;
			if (num != 0)
			{
			}
			num = (short)1147404288;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x001FEDD0 File Offset: 0x001FCFD0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)1311244288;
			short num2 = num;
			num = (short)2042115078;
			short num3 = num;
			num = (short)1427059718;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_17E:
				num = (short)1283850241;
				if (num != 0)
				{
				}
				num = (short)4325376;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1350369280;
				if (num != 0)
				{
				}
				num = (short)2057371649;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					num = (short)57147395;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_C2;
					}
					continue;
				case 2:
					this.hotListAlias = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒋ﺑﶓ\ud999풟쎡잣튥용얫쾭쎯", a_), global::CommonResources.AppResources.Hot_List_Alias);
					num = (short)226623493;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒋ﺑﶓ\ud999풟쎡잣튥용얫쾭쎯", a_)))
					{
						num = (short)2057240578;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C4;
				case 4:
					goto IL_17B;
				case 5:
					goto IL_118;
				case 6:
					num = (short)1514668036;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C2:
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					break;
				}
				num = (short)732954630;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_118:
			goto IL_1C4;
			IL_17B:
			if (producerFields != null)
			{
				goto IL_17E;
			}
			IL_1C4:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b춍\ud98f\udb91뒓햕聯뺝춡킣蚥쎩\udfab\udaad", a_);
			base.UIName = global::CommonResources.AppResources.QCII_Call_Hot_List;
			base.Id = 10425;
			base.DataTransferOrder = 13;
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x0000265F File Offset: 0x0000085F
		internal UclQCIICallHotListHotListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04000C1A RID: 3098
		private global::SpecialFeatures.Ucl.HotList.QCIICallHotListRecset qCIICallHotListRecset;

		// Token: 0x04000C1B RID: 3099
		private global::AcpBusinessLayer.AcpKeyField hotListAlias;
	}
}
