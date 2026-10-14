using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Windows.Data;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.UclWide
{
	// Token: 0x020001B8 RID: 440
	[global::System.Serializable]
	public sealed class UclWideSectionGeneral : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600148F RID: 5263 RVA: 0x00002650 File Offset: 0x00000850
		internal UclWideSectionGeneral(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x001D881C File Offset: 0x001D6A1C
		public override void Init()
		{
			int a_ = 16;
			short num = (short)807283753;
			short num2 = num;
			num = (short)1697459241;
			switch (num2 == num)
			{
			}
			num = (short)1054343169;
			if (num != 0)
			{
			}
			num = (short)1806827520;
			short num3 = num;
			num = (short)789643264;
			if (num != 0)
			{
			}
			this.uclWideGen_UCLEdit_A00001 = new global::AcpBusinessLayer.AcpField<bool>(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욒ﮖ캘列爵욢쮤ﲨ햰\udab2솴论趼达", a_), global::CommonResources.AppResources.UCL_Editable);
			this.uclWideGen_UCLEdit_A00001.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclWideGen_UCLEdit_A00001.DataTransferOrder = 1;
			this.uclWideGen_HotListEdit_A00002 = new global::AcpBusinessLayer.AcpField<bool>(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욒ﮖ캘列爵욢쮤쒪\ud9ac\ud8b0삲솴\uddb8튺즼胀杻流", a_), global::CommonResources.AppResources.Hot_List_Editable);
			this.uclWideGen_HotListEdit_A00002.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclWideGen_HotListEdit_A00002.DataTransferOrder = 2;
			this.uclWideGen_PhoneNumEdit_A00004 = new global::AcpBusinessLayer.AcpField<bool>(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욒ﮖ캘列爵욢쮤令쎪슬솮풰ﶲ살\udab6ﲸ\udfba풼쮾黀苂杻﯊琉", a_), global::CommonResources.AppResources.Phone_Number_Editable);
			this.uclWideGen_PhoneNumEdit_A00004.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclWideGen_PhoneNumEdit_A00004.DataTransferOrder = 3;
			this.uclWideGen_RadioIdEdit_A00003 = new global::AcpBusinessLayer.AcpField<bool>(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욒ﮖ캘列爵욢쮤ﮨ쪪즬욮\udeb0者톴\uddb8튺즼胀杻", a_), global::CommonResources.AppResources.Radio_ID_Editable);
			this.uclWideGen_RadioIdEdit_A00003.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclWideGen_RadioIdEdit_A00003.DataTransferOrder = 4;
			this.uclWideGen_ContactDataOrder_A00005 = new global::AcpBusinessLayer.AcpSparseLOVField(new global::SpecialFeatures.Ucl.UclWide.UclWideSectionGeneral.CallTypeLOVConverter(), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욒ﮖ캘列爵욢쮤쒪쎬\udbae킰킲솴\ud8b8쾺\udcbc돀Ꟃꃄ뗆雈諊﷌ￎ", a_), global::CommonResources.AppResources.Contact_Data_Order_Indicator, global::SpecialFeatures.Ucl.UclWide.LOVs.CallTypeList, true);
			this.uclWideGen_ContactDataOrder_A00005.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclWideGen_ContactDataOrder_A00005.DataTransferOrder = -1;
			this.uclWideGen_ContactDataOrder_A00005.UndoIgnoresSelection = true;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풒練ﲘﲜ", a_);
			base.UIName = global::CommonResources.AppResources.General_Id;
			base.DataTransferOrder = 1;
			base.Id = 10429;
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x001D8A28 File Offset: 0x001D6C28
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)222804167;
			short num2 = num;
			num = (short)1665120455;
			switch (num2 == num)
			{
			}
			num = (short)1609760769;
			if (num != 0)
			{
			}
			num = (short)2081882112;
			short num3 = num;
			num = (short)237830144;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x001D8ADC File Offset: 0x001D6CDC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)758972428;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_EA;
				case 1:
					goto IL_2ED;
				case 2:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\ud98d憐톕ﶗ쎛횝쾟횡쾥\udba7\udea9쪭\ud9af욱袷誹費躽", a_)))
					{
						num = (short)1979711498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EA;
				case 3:
					this.uclWideGen_UCLEdit_A00001 = new global::AcpBusinessLayer.AcpField<bool>(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\ud98d憐톕ﶗ쎛쮝슥솧\udea9肯花蒳蚵覷", a_), global::CommonResources.AppResources.UCL_Editable);
					this.uclWideGen_UCLEdit_A00001.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclWideGen_UCLEdit_A00001.DataTransferOrder = 1;
					goto IL_37C;
				case 4:
					this.uclWideGen_RadioIdEdit_A00003 = new global::AcpBusinessLayer.AcpField<bool>(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\ud98d憐톕ﶗ쎛첝솟욡춣즥캩쪭\ud9af욱袷誹費躽", a_), global::CommonResources.AppResources.Radio_ID_Editable);
					this.uclWideGen_RadioIdEdit_A00003.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclWideGen_RadioIdEdit_A00003.DataTransferOrder = 4;
					num = (short)662765573;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_182;
				case 6:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\ud98d憐톕ﶗ쎛첝솟욡춣즥캩쪭\ud9af욱袷誹費躽", a_)))
					{
						num = (short)834797572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_182;
				case 7:
					this.uclWideGen_ContactDataOrder_A00005 = new global::AcpBusinessLayer.AcpSparseLOVField(new global::SpecialFeatures.Ucl.UclWide.UclWideSectionGeneral.CallTypeLOVConverter(), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\ud98d憐톕ﶗ쎛\udd9d쾟첡킣장쮧\udea9쾭쒯펱﮳쒵\udcb7\udfb9캻膿￉", a_), global::CommonResources.AppResources.Contact_Data_Order_Indicator, global::SpecialFeatures.Ucl.UclWide.LOVs.CallTypeList, true);
					this.uclWideGen_ContactDataOrder_A00005.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclWideGen_ContactDataOrder_A00005.DataTransferOrder = -1;
					this.uclWideGen_ContactDataOrder_A00005.UndoIgnoresSelection = true;
					num = (short)1364525057;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_9D;
				case 9:
					num = (short)1054343185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)60683780;
					short num3 = num;
					num = (short)2045244932;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_37C;
					default:
						num = (short)438960128;
						if (num != 0)
						{
						}
						this.uclWideGen_HotListEdit_A00002 = new global::AcpBusinessLayer.AcpField<bool>(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\ud98d憐톕ﶗ쎛횝쾟횡쾥\udba7\udea9쪭\ud9af욱袷誹費躽", a_), global::CommonResources.AppResources.Hot_List_Editable);
						this.uclWideGen_HotListEdit_A00002.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.uclWideGen_HotListEdit_A00002.DataTransferOrder = 2;
						num = (short)753664000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 11:
					if (producerFields != null)
					{
						num = (short)1550778377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4AA;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_79;
					}
					continue;
				case 13:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\ud98d憐톕ﶗ쎛캝좟춡쪣쎥\udfa9솫풯\udbb1삳醴誹費躽", a_)))
					{
						num = (short)1084555280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9D;
				case 14:
					goto IL_412;
				case 15:
					num = (short)1248591883;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					this.uclWideGen_PhoneNumEdit_A00004 = new global::AcpBusinessLayer.AcpField<bool>(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\ud98d憐톕ﶗ쎛캝좟춡쪣쎥\udfa9솫풯\udbb1삳醴誹費躽", a_), global::CommonResources.AppResources.Phone_Number_Editable);
					this.uclWideGen_PhoneNumEdit_A00004.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclWideGen_PhoneNumEdit_A00004.DataTransferOrder = 3;
					num = (short)808255496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\ud98d憐톕ﶗ쎛쮝슥솧\udea9肯花蒳蚵覷", a_)))
					{
						num = (short)2051866627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_412;
				case 18:
				{
					num = (short)1661075456;
					short num4 = num;
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\ud98d憐톕ﶗ쎛\udd9d쾟첡킣장쮧\udea9쾭쒯펱﮳쒵\udcb7\udfb9캻膿￉", a_)))
					{
						num = (short)2057502727;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4AA;
				}
				}
				IL_79:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1898643471;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9D:
				num = (short)488505350;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EA:
				num = (short)1966538765;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_182:
				num = (short)1237516306;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_37C:
				num = (short)758841345;
				if (num != 0)
				{
				}
				num = (short)17170446;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_412:
				num = (short)1921974274;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2ED:
			IL_4AA:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾇", a_);
			base.UIName = global::CommonResources.AppResources.General_Id;
			base.DataTransferOrder = 1;
			base.Id = 10429;
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x001D8FC4 File Offset: 0x001D71C4
		public override void PopulateReferences()
		{
			short num = (short)1064795322;
			short num2 = num;
			num = (short)865041594;
			switch (num2 == num)
			{
			}
			num = (short)1102446593;
			if (num != 0)
			{
			}
			num = (short)1857486848;
			short num3 = num;
			num = (short)689438720;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x001D9070 File Offset: 0x001D7270
		public override void DropReferences()
		{
			short num = (short)477961453;
			short num2 = num;
			num = (short)833101037;
			switch (num2 == num)
			{
			}
			num = (short)1469382656;
			if (num != 0)
			{
			}
			num = (short)784596992;
			short num3 = num;
			num = (short)693698561;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x001D9118 File Offset: 0x001D7318
		public override void SetupDependencies()
		{
			short num = (short)508132266;
			short num2 = num;
			num = (short)1282571178;
			switch (num2 == num)
			{
			}
			num = (short)109772800;
			if (num != 0)
			{
			}
			num = (short)1580269568;
			short num3 = num;
			num = (short)1727922177;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x001D91C0 File Offset: 0x001D73C0
		public override void SetConstraints()
		{
			short num = (short)1303236861;
			short num2 = num;
			num = (short)1037553917;
			switch (num2 == num)
			{
			}
			num = (short)40435713;
			if (num != 0)
			{
			}
			num = (short)1992884224;
			short num3 = num;
			num = (short)2057502720;
			if (num != 0)
			{
			}
			this.uclWideGen_UCLEdit_A00001.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::SpecialFeatures.Ucl.UclWide.UclWideConstraints.conSetValueHotListEditable);
			this.uclWideGen_HotListEdit_A00002.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::SpecialFeatures.Ucl.UclWide.UclWideConstraints.conSetValueUclEditable);
			this.uclWideGen_PhoneNumEdit_A00004.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.UclWide.UclWideConstraints.ConUclIsEditable);
			this.uclWideGen_RadioIdEdit_A00003.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.UclWide.UclWideConstraints.ConUclIsEditable);
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x001D92C4 File Offset: 0x001D74C4
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x001D9378 File Offset: 0x001D7578
		public bool UclWideGen_UCLEdit_A00001Value
		{
			get
			{
				short num = (short)1992077662;
				short num2 = num;
				num = (short)1124249950;
				switch (num2 == num)
				{
				}
				num = (short)148701185;
				if (num != 0)
				{
				}
				num = (short)1275658240;
				short num3 = num;
				num = (short)435945472;
				if (num != 0)
				{
				}
				return this.uclWideGen_UCLEdit_A00001.Value;
			}
			set
			{
				short num = (short)1006604186;
				short num2 = num;
				num = (short)2034339738;
				switch (num2 == num)
				{
				}
				num = (short)1215627264;
				short num3 = num;
				num = (short)318111745;
				if (num != 0)
				{
				}
				num = (short)1553596416;
				if (num != 0)
				{
				}
				this.uclWideGen_UCLEdit_A00001.Value = value;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x001D9430 File Offset: 0x001D7630
		public global::AcpBusinessLayer.AcpField<bool> UclWideGen_UCLEdit_A00001Object
		{
			get
			{
				short num = (short)1106837505;
				if (num != 0)
				{
				}
				num = (short)136616210;
				short num2 = num;
				num = (short)992516370;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2039939072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1858207744;
				if (num != 0)
				{
				}
				return this.uclWideGen_UCLEdit_A00001;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x001D94E0 File Offset: 0x001D76E0
		public string UclWideGen_UCLEdit_A00001_UILabel
		{
			get
			{
				short num = (short)741474305;
				if (num != 0)
				{
				}
				num = (short)2045605953;
				short num2 = num;
				num = (short)1698592833;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1283653632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)746913792;
				if (num != 0)
				{
				}
				return this.uclWideGen_UCLEdit_A00001.UIName;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x001D9594 File Offset: 0x001D7794
		// (set) Token: 0x0600149C RID: 5276 RVA: 0x001D9648 File Offset: 0x001D7848
		public bool UclWideGen_UCLEdit_A00001_Applicable
		{
			get
			{
				short num = (short)1812775504;
				short num2 = num;
				num = (short)370131536;
				switch (num2 == num)
				{
				}
				num = (short)575799296;
				short num3 = num;
				num = (short)1490419712;
				if (num != 0)
				{
				}
				num = (short)644939777;
				if (num != 0)
				{
				}
				return this.uclWideGen_UCLEdit_A00001.Applicable;
			}
			set
			{
				short num = (short)330438342;
				short num2 = num;
				num = (short)302978758;
				switch (num2 == num)
				{
				}
				num = (short)622657536;
				short num3 = num;
				num = (short)127664128;
				if (num != 0)
				{
				}
				num = (short)368312321;
				if (num != 0)
				{
				}
				this.uclWideGen_UCLEdit_A00001.Applicable = value;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x001D9700 File Offset: 0x001D7900
		// (set) Token: 0x0600149E RID: 5278 RVA: 0x001D97B4 File Offset: 0x001D79B4
		public bool UclWideGen_UCLEdit_A00001_Editable
		{
			get
			{
				short num = (short)1601972160;
				short num2 = num;
				num = (short)1006512064;
				switch (num2 == num)
				{
				}
				num = (short)1438056448;
				short num3 = num;
				num = (short)492634113;
				if (num != 0)
				{
				}
				num = (short)134348800;
				if (num != 0)
				{
				}
				return this.uclWideGen_UCLEdit_A00001.Editable;
			}
			set
			{
				short num = (short)487569090;
				short num2 = num;
				num = (short)408598210;
				switch (num2 == num)
				{
				}
				num = (short)1239154688;
				short num3 = num;
				num = (short)737476609;
				if (num != 0)
				{
				}
				num = (short)409862144;
				if (num != 0)
				{
				}
				this.uclWideGen_UCLEdit_A00001.Editable = value;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x001D9868 File Offset: 0x001D7A68
		// (set) Token: 0x060014A0 RID: 5280 RVA: 0x001D991C File Offset: 0x001D7B1C
		public bool UclWideGen_UCLEdit_A00001_Visible
		{
			get
			{
				short num = (short)963120813;
				short num2 = num;
				num = (short)1595608749;
				switch (num2 == num)
				{
				}
				num = (short)109445120;
				short num3 = num;
				num = (short)300417024;
				if (num != 0)
				{
				}
				num = (short)846004225;
				if (num != 0)
				{
				}
				return this.uclWideGen_UCLEdit_A00001.Visible;
			}
			set
			{
				short num = (short)2028745950;
				short num2 = num;
				num = (short)634795230;
				switch (num2 == num)
				{
				}
				num = (short)1916534784;
				short num3 = num;
				num = (short)1882718209;
				if (num != 0)
				{
				}
				num = (short)1068564480;
				if (num != 0)
				{
				}
				this.uclWideGen_UCLEdit_A00001.Visible = value;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x001D99D0 File Offset: 0x001D7BD0
		// (set) Token: 0x060014A2 RID: 5282 RVA: 0x001D9A84 File Offset: 0x001D7C84
		internal bool UclWideGen_UCLEdit_A00001_HiddenStatic
		{
			get
			{
				short num = (short)746749101;
				short num2 = num;
				num = (short)810515629;
				switch (num2 == num)
				{
				}
				num = (short)1284571136;
				short num3 = num;
				num = (short)1937309697;
				if (num != 0)
				{
				}
				num = (short)2004811776;
				if (num != 0)
				{
				}
				return this.uclWideGen_UCLEdit_A00001.HiddenStatic;
			}
			set
			{
				short num = (short)1809728055;
				short num2 = num;
				num = (short)1405829687;
				switch (num2 == num)
				{
				}
				num = (short)181731328;
				short num3 = num;
				num = (short)1277427713;
				if (num != 0)
				{
				}
				num = (short)736493568;
				if (num != 0)
				{
				}
				this.uclWideGen_UCLEdit_A00001.HiddenStatic = value;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x001D9B38 File Offset: 0x001D7D38
		// (set) Token: 0x060014A4 RID: 5284 RVA: 0x001D9BF0 File Offset: 0x001D7DF0
		public bool UclWideGen_UCLEdit_A00001_Valid
		{
			get
			{
				short num = (short)1174474782;
				short num2 = num;
				num = (short)154865694;
				switch (num2 == num)
				{
				}
				num = (short)290652160;
				short num3 = num;
				num = (short)252510209;
				if (num != 0)
				{
				}
				num = (short)2105868288;
				if (num != 0)
				{
				}
				return this.uclWideGen_UCLEdit_A00001.Valid;
			}
			set
			{
				short num = (short)777752782;
				short num2 = num;
				num = (short)2022346958;
				switch (num2 == num)
				{
				}
				num = (short)610140160;
				short num3 = num;
				num = (short)3866624;
				if (num != 0)
				{
				}
				num = (short)1167261697;
				if (num != 0)
				{
				}
				this.uclWideGen_UCLEdit_A00001.Valid = value;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x001D9CA4 File Offset: 0x001D7EA4
		public bool UclWideGen_UCLEdit_A00001_HasDiffs
		{
			get
			{
				short num = (short)1480590731;
				short num2 = num;
				num = (short)835650955;
				switch (num2 == num)
				{
				}
				num = (short)343736320;
				short num3 = num;
				num = (short)1636237313;
				if (num != 0)
				{
				}
				num = (short)728825856;
				if (num != 0)
				{
				}
				return this.uclWideGen_UCLEdit_A00001._HasDiffs;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x001D9D5C File Offset: 0x001D7F5C
		// (set) Token: 0x060014A7 RID: 5287 RVA: 0x001D9E10 File Offset: 0x001D8010
		public bool UclWideGen_HotListEdit_A00002Value
		{
			get
			{
				short num = (short)365131250;
				short num2 = num;
				num = (short)1258518002;
				switch (num2 == num)
				{
				}
				num = (short)129433600;
				short num3 = num;
				num = (short)866189313;
				if (num != 0)
				{
				}
				num = (short)434241536;
				if (num != 0)
				{
				}
				return this.uclWideGen_HotListEdit_A00002.Value;
			}
			set
			{
				short num = (short)1046020097;
				if (num != 0)
				{
				}
				num = (short)1088528443;
				short num2 = num;
				num = (short)1190371387;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1536229376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1607860224;
				if (num != 0)
				{
				}
				this.uclWideGen_HotListEdit_A00002.Value = value;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x060014A8 RID: 5288 RVA: 0x001D9EC8 File Offset: 0x001D80C8
		public global::AcpBusinessLayer.AcpField<bool> UclWideGen_HotListEdit_A00002Object
		{
			get
			{
				short num = (short)1236074497;
				if (num != 0)
				{
				}
				num = (short)698247395;
				short num2 = num;
				num = (short)1786210531;
				switch (num2 == num)
				{
				default:
				{
					num = (short)757530624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1698103296;
				if (num != 0)
				{
				}
				return this.uclWideGen_HotListEdit_A00002;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x001D9F7C File Offset: 0x001D817C
		public string UclWideGen_HotListEdit_A00002_UILabel
		{
			get
			{
				short num = (short)1749775161;
				short num2 = num;
				num = (short)770011961;
				switch (num2 == num)
				{
				}
				num = (short)1869611008;
				short num3 = num;
				num = (short)1582628865;
				if (num != 0)
				{
				}
				num = (short)1529020416;
				if (num != 0)
				{
				}
				return this.uclWideGen_HotListEdit_A00002.UIName;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x001DA034 File Offset: 0x001D8234
		// (set) Token: 0x060014AB RID: 5291 RVA: 0x001DA0E4 File Offset: 0x001D82E4
		public bool UclWideGen_HotListEdit_A00002_Applicable
		{
			get
			{
				short num = (short)1453453362;
				short num2 = num;
				num = (short)1406136370;
				switch (num2 == num)
				{
				}
				num = (short)1123090432;
				short num3 = num;
				num = (short)929103873;
				if (num != 0)
				{
				}
				num = (short)1518338048;
				if (num != 0)
				{
				}
				return this.uclWideGen_HotListEdit_A00002.Applicable;
			}
			set
			{
				short num = (short)14182254;
				short num2 = num;
				num = (short)1530488686;
				switch (num2 == num)
				{
				}
				num = (short)1241382912;
				short num3 = num;
				num = (short)695795713;
				if (num != 0)
				{
				}
				num = (short)162201600;
				if (num != 0)
				{
				}
				this.uclWideGen_HotListEdit_A00002.Applicable = value;
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x001DA19C File Offset: 0x001D839C
		// (set) Token: 0x060014AD RID: 5293 RVA: 0x001DA250 File Offset: 0x001D8450
		public bool UclWideGen_HotListEdit_A00002_Editable
		{
			get
			{
				short num = (short)1053360129;
				if (num != 0)
				{
				}
				num = (short)1509716316;
				short num2 = num;
				num = (short)1294168412;
				switch (num2 == num)
				{
				default:
				{
					num = (short)883032064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1246232576;
				if (num != 0)
				{
				}
				return this.uclWideGen_HotListEdit_A00002.Editable;
			}
			set
			{
				short num = (short)60040057;
				short num2 = num;
				num = (short)1072636793;
				switch (num2 == num)
				{
				}
				num = (short)1663041536;
				short num3 = num;
				num = (short)1943666688;
				if (num != 0)
				{
				}
				num = (short)1051656193;
				if (num != 0)
				{
				}
				this.uclWideGen_HotListEdit_A00002.Editable = value;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060014AE RID: 5294 RVA: 0x001DA304 File Offset: 0x001D8504
		// (set) Token: 0x060014AF RID: 5295 RVA: 0x001DA3B8 File Offset: 0x001D85B8
		public bool UclWideGen_HotListEdit_A00002_Visible
		{
			get
			{
				short num = (short)1863480311;
				short num2 = num;
				num = (short)1173976055;
				switch (num2 == num)
				{
				}
				num = (short)121176064;
				short num3 = num;
				num = (short)1588723713;
				if (num != 0)
				{
				}
				num = (short)833552384;
				if (num != 0)
				{
				}
				return this.uclWideGen_HotListEdit_A00002.Visible;
			}
			set
			{
				short num = (short)1794310145;
				if (num != 0)
				{
				}
				num = (short)1843585702;
				short num2 = num;
				num = (short)232448678;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1707212800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)553254912;
				if (num != 0)
				{
				}
				this.uclWideGen_HotListEdit_A00002.Visible = value;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x001DA46C File Offset: 0x001D866C
		// (set) Token: 0x060014B1 RID: 5297 RVA: 0x001DA520 File Offset: 0x001D8720
		internal bool UclWideGen_HotListEdit_A00002_HiddenStatic
		{
			get
			{
				short num = (short)345760461;
				short num2 = num;
				num = (short)2066080461;
				switch (num2 == num)
				{
				}
				num = (short)2061041664;
				short num3 = num;
				num = (short)2039349248;
				if (num != 0)
				{
				}
				num = (short)1048182785;
				if (num != 0)
				{
				}
				return this.uclWideGen_HotListEdit_A00002.HiddenStatic;
			}
			set
			{
				short num = (short)979890522;
				short num2 = num;
				num = (short)1703211354;
				switch (num2 == num)
				{
				}
				num = (short)1657733120;
				short num3 = num;
				num = (short)2047016961;
				if (num != 0)
				{
				}
				num = (short)2037186560;
				if (num != 0)
				{
				}
				this.uclWideGen_HotListEdit_A00002.HiddenStatic = value;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x001DA5DC File Offset: 0x001D87DC
		// (set) Token: 0x060014B3 RID: 5299 RVA: 0x001DA694 File Offset: 0x001D8894
		public bool UclWideGen_HotListEdit_A00002_Valid
		{
			get
			{
				short num = (short)439732325;
				short num2 = num;
				num = (short)787138661;
				switch (num2 == num)
				{
				}
				num = (short)1220542464;
				short num3 = num;
				num = (short)1148715008;
				if (num != 0)
				{
				}
				num = (short)1719205889;
				if (num != 0)
				{
				}
				return this.uclWideGen_HotListEdit_A00002.Valid;
			}
			set
			{
				short num = (short)2064430688;
				short num2 = num;
				num = (short)241612384;
				switch (num2 == num)
				{
				}
				num = (short)1725890560;
				short num3 = num;
				num = (short)680787968;
				if (num != 0)
				{
				}
				num = (short)1888026625;
				if (num != 0)
				{
				}
				this.uclWideGen_HotListEdit_A00002.Valid = value;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x001DA74C File Offset: 0x001D894C
		public bool UclWideGen_HotListEdit_A00002_HasDiffs
		{
			get
			{
				short num = (short)817664129;
				short num2 = num;
				num = (short)153849985;
				switch (num2 == num)
				{
				}
				num = (short)247201792;
				short num3 = num;
				num = (short)542179329;
				if (num != 0)
				{
				}
				num = (short)1644560384;
				if (num != 0)
				{
				}
				return this.uclWideGen_HotListEdit_A00002._HasDiffs;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x060014B5 RID: 5301 RVA: 0x001DA800 File Offset: 0x001D8A00
		// (set) Token: 0x060014B6 RID: 5302 RVA: 0x001DA8B4 File Offset: 0x001D8AB4
		public bool UclWideGen_PhoneNumEdit_A00004Value
		{
			get
			{
				short num = (short)571005839;
				short num2 = num;
				num = (short)153017231;
				switch (num2 == num)
				{
				}
				num = (short)810090496;
				short num3 = num;
				num = (short)1598423041;
				if (num != 0)
				{
				}
				num = (short)622460928;
				if (num != 0)
				{
				}
				return this.uclWideGen_PhoneNumEdit_A00004.Value;
			}
			set
			{
				short num = (short)22395915;
				short num2 = num;
				num = (short)861715467;
				switch (num2 == num)
				{
				}
				num = (short)1701838848;
				short num3 = num;
				num = (short)1969422337;
				if (num != 0)
				{
				}
				num = (short)475267072;
				if (num != 0)
				{
				}
				this.uclWideGen_PhoneNumEdit_A00004.Value = value;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x001DA968 File Offset: 0x001D8B68
		public global::AcpBusinessLayer.AcpField<bool> UclWideGen_PhoneNumEdit_A00004Object
		{
			get
			{
				short num = (short)1144459647;
				short num2 = num;
				num = (short)1069486463;
				switch (num2 == num)
				{
				}
				num = (short)361758720;
				short num3 = num;
				num = (short)611844097;
				if (num != 0)
				{
				}
				num = (short)1715666944;
				if (num != 0)
				{
				}
				return this.uclWideGen_PhoneNumEdit_A00004;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x001DAA18 File Offset: 0x001D8C18
		public string UclWideGen_PhoneNumEdit_A00004_UILabel
		{
			get
			{
				short num = (short)1069441161;
				short num2 = num;
				num = (short)240214153;
				switch (num2 == num)
				{
				}
				num = (short)720633856;
				short num3 = num;
				num = (short)324796417;
				if (num != 0)
				{
				}
				num = (short)1961099264;
				if (num != 0)
				{
				}
				return this.uclWideGen_PhoneNumEdit_A00004.UIName;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x060014B9 RID: 5305 RVA: 0x001DAACC File Offset: 0x001D8CCC
		// (set) Token: 0x060014BA RID: 5306 RVA: 0x001DAB80 File Offset: 0x001D8D80
		public bool UclWideGen_PhoneNumEdit_A00004_Applicable
		{
			get
			{
				short num = (short)1329135617;
				if (num != 0)
				{
				}
				num = (short)983111803;
				short num2 = num;
				num = (short)1811421307;
				switch (num2 == num)
				{
				default:
				{
					num = (short)686751744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2145583104;
				if (num != 0)
				{
				}
				return this.uclWideGen_PhoneNumEdit_A00004.Applicable;
			}
			set
			{
				short num = (short)1356203838;
				short num2 = num;
				num = (short)342165310;
				switch (num2 == num)
				{
				}
				num = (short)1297285120;
				short num3 = num;
				num = (short)708378625;
				if (num != 0)
				{
				}
				num = (short)232128512;
				if (num != 0)
				{
				}
				this.uclWideGen_PhoneNumEdit_A00004.Applicable = value;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x001DAC34 File Offset: 0x001D8E34
		// (set) Token: 0x060014BC RID: 5308 RVA: 0x001DACEC File Offset: 0x001D8EEC
		public bool UclWideGen_PhoneNumEdit_A00004_Editable
		{
			get
			{
				short num = (short)1895753475;
				short num2 = num;
				num = (short)1861609219;
				switch (num2 == num)
				{
				}
				num = (short)1541734400;
				short num3 = num;
				num = (short)1294467073;
				if (num != 0)
				{
				}
				num = (short)60227584;
				if (num != 0)
				{
				}
				return this.uclWideGen_PhoneNumEdit_A00004.Editable;
			}
			set
			{
				short num = (short)2070775206;
				short num2 = num;
				num = (short)1777829286;
				switch (num2 == num)
				{
				}
				num = (short)1012989952;
				short num3 = num;
				num = (short)232849409;
				if (num != 0)
				{
				}
				num = (short)1320681472;
				if (num != 0)
				{
				}
				this.uclWideGen_PhoneNumEdit_A00004.Editable = value;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060014BD RID: 5309 RVA: 0x001DADA4 File Offset: 0x001D8FA4
		// (set) Token: 0x060014BE RID: 5310 RVA: 0x001DAE58 File Offset: 0x001D9058
		public bool UclWideGen_PhoneNumEdit_A00004_Visible
		{
			get
			{
				short num = (short)458227049;
				short num2 = num;
				num = (short)1571224937;
				switch (num2 == num)
				{
				}
				num = (short)284098560;
				short num3 = num;
				num = (short)759955456;
				if (num != 0)
				{
				}
				num = (short)501219329;
				if (num != 0)
				{
				}
				return this.uclWideGen_PhoneNumEdit_A00004.Visible;
			}
			set
			{
				short num = (short)1837789931;
				short num2 = num;
				num = (short)1299935979;
				switch (num2 == num)
				{
				}
				num = (short)284426240;
				short num3 = num;
				num = (short)1346895873;
				if (num != 0)
				{
				}
				num = (short)772866048;
				if (num != 0)
				{
				}
				this.uclWideGen_PhoneNumEdit_A00004.Visible = value;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x001DAF0C File Offset: 0x001D910C
		// (set) Token: 0x060014C0 RID: 5312 RVA: 0x001DAFC0 File Offset: 0x001D91C0
		internal bool UclWideGen_PhoneNumEdit_A00004_HiddenStatic
		{
			get
			{
				short num = (short)72665937;
				short num2 = num;
				num = (short)651086673;
				switch (num2 == num)
				{
				}
				num = (short)832503808;
				short num3 = num;
				num = (short)1994588161;
				if (num != 0)
				{
				}
				num = (short)560726016;
				if (num != 0)
				{
				}
				return this.uclWideGen_PhoneNumEdit_A00004.HiddenStatic;
			}
			set
			{
				short num = (short)1283171317;
				short num2 = num;
				num = (short)1776198645;
				switch (num2 == num)
				{
				}
				num = (short)685047808;
				short num3 = num;
				num = (short)256507905;
				if (num != 0)
				{
				}
				num = (short)741736448;
				if (num != 0)
				{
				}
				this.uclWideGen_PhoneNumEdit_A00004.HiddenStatic = value;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060014C1 RID: 5313 RVA: 0x001DB074 File Offset: 0x001D9274
		// (set) Token: 0x060014C2 RID: 5314 RVA: 0x001DB128 File Offset: 0x001D9328
		public bool UclWideGen_PhoneNumEdit_A00004_Valid
		{
			get
			{
				short num = (short)1934295041;
				if (num != 0)
				{
				}
				num = (short)1491636259;
				short num2 = num;
				num = (short)1479774243;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2144600064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)995819520;
				if (num != 0)
				{
				}
				return this.uclWideGen_PhoneNumEdit_A00004.Valid;
			}
			set
			{
				short num = (short)985729762;
				short num2 = num;
				num = (short)1574963938;
				switch (num2 == num)
				{
				}
				num = (short)685703168;
				short num3 = num;
				num = (short)770506753;
				if (num != 0)
				{
				}
				num = (short)2029649920;
				if (num != 0)
				{
				}
				this.uclWideGen_PhoneNumEdit_A00004.Valid = value;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x060014C3 RID: 5315 RVA: 0x001DB1DC File Offset: 0x001D93DC
		public bool UclWideGen_PhoneNumEdit_A00004_HasDiffs
		{
			get
			{
				short num = (short)1996436066;
				short num2 = num;
				num = (short)769012322;
				switch (num2 == num)
				{
				}
				num = (short)874577920;
				short num3 = num;
				num = (short)1061552129;
				if (num != 0)
				{
				}
				num = (short)412680192;
				if (num != 0)
				{
				}
				return this.uclWideGen_PhoneNumEdit_A00004._HasDiffs;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x001DB294 File Offset: 0x001D9494
		// (set) Token: 0x060014C5 RID: 5317 RVA: 0x001DB34C File Offset: 0x001D954C
		public bool UclWideGen_RadioIdEdit_A00003Value
		{
			get
			{
				short num = (short)417702720;
				short num2 = num;
				num = (short)131965760;
				switch (num2 == num)
				{
				}
				num = (short)1433927680;
				short num3 = num;
				num = (short)862388225;
				if (num != 0)
				{
				}
				num = (short)2070413312;
				if (num != 0)
				{
				}
				return this.uclWideGen_RadioIdEdit_A00003.Value;
			}
			set
			{
				short num = (short)1436511958;
				short num2 = num;
				num = (short)1861840598;
				switch (num2 == num)
				{
				}
				num = (short)1982922752;
				short num3 = num;
				num = (short)1639645185;
				if (num != 0)
				{
				}
				num = (short)953286656;
				if (num != 0)
				{
				}
				this.uclWideGen_RadioIdEdit_A00003.Value = value;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x001DB400 File Offset: 0x001D9600
		public global::AcpBusinessLayer.AcpField<bool> UclWideGen_RadioIdEdit_A00003Object
		{
			get
			{
				short num = (short)925206758;
				short num2 = num;
				num = (short)2018347238;
				switch (num2 == num)
				{
				}
				num = (short)1486094336;
				short num3 = num;
				num = (short)1684799488;
				if (num != 0)
				{
				}
				num = (short)1524105217;
				if (num != 0)
				{
				}
				return this.uclWideGen_RadioIdEdit_A00003;
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x060014C7 RID: 5319 RVA: 0x001DB4B4 File Offset: 0x001D96B4
		public string UclWideGen_RadioIdEdit_A00003_UILabel
		{
			get
			{
				short num = (short)1497694208;
				short num2 = num;
				num = (short)823797406;
				short num3 = num;
				num = (short)1621370526;
				switch (num3 == num)
				{
				}
				num = (short)770375681;
				if (num != 0)
				{
				}
				num = (short)2086928384;
				if (num != 0)
				{
				}
				return this.uclWideGen_RadioIdEdit_A00003.UIName;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x001DB56C File Offset: 0x001D976C
		// (set) Token: 0x060014C9 RID: 5321 RVA: 0x001DB620 File Offset: 0x001D9820
		public bool UclWideGen_RadioIdEdit_A00003_Applicable
		{
			get
			{
				short num = (short)590479360;
				short num2 = num;
				num = (short)61227732;
				short num3 = num;
				num = (short)86721236;
				switch (num3 == num)
				{
				}
				num = (short)1709965313;
				if (num != 0)
				{
				}
				num = (short)84738048;
				if (num != 0)
				{
				}
				return this.uclWideGen_RadioIdEdit_A00003.Applicable;
			}
			set
			{
				short num = (short)2055208960;
				short num2 = num;
				num = (short)767907272;
				short num3 = num;
				num = (short)100423112;
				switch (num3 == num)
				{
				}
				num = (short)228065281;
				if (num != 0)
				{
				}
				num = (short)1368522752;
				if (num != 0)
				{
				}
				this.uclWideGen_RadioIdEdit_A00003.Applicable = value;
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x001DB6D4 File Offset: 0x001D98D4
		// (set) Token: 0x060014CB RID: 5323 RVA: 0x001DB788 File Offset: 0x001D9988
		public bool UclWideGen_RadioIdEdit_A00003_Editable
		{
			get
			{
				short num = (short)1888878592;
				short num2 = num;
				num = (short)809440215;
				short num3 = num;
				num = (short)1024398295;
				switch (num3 == num)
				{
				}
				num = (short)1117782017;
				if (num != 0)
				{
				}
				num = (short)1121124352;
				if (num != 0)
				{
				}
				return this.uclWideGen_RadioIdEdit_A00003.Editable;
			}
			set
			{
				short num = (short)799997952;
				short num2 = num;
				num = (short)1761257907;
				short num3 = num;
				num = (short)1037478323;
				switch (num3 == num)
				{
				}
				num = (short)628490241;
				if (num != 0)
				{
				}
				num = (short)1234436096;
				if (num != 0)
				{
				}
				this.uclWideGen_RadioIdEdit_A00003.Editable = value;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x001DB840 File Offset: 0x001D9A40
		// (set) Token: 0x060014CD RID: 5325 RVA: 0x001DB8F4 File Offset: 0x001D9AF4
		public bool UclWideGen_RadioIdEdit_A00003_Visible
		{
			get
			{
				short num = (short)812580864;
				short num2 = num;
				num = (short)1961069432;
				short num3 = num;
				num = (short)1658751864;
				switch (num3 == num)
				{
				}
				num = (short)1460404225;
				if (num != 0)
				{
				}
				num = (short)2011627520;
				if (num != 0)
				{
				}
				return this.uclWideGen_RadioIdEdit_A00003.Visible;
			}
			set
			{
				short num = (short)130023424;
				short num2 = num;
				num = (short)1573284239;
				short num3 = num;
				num = (short)1917675919;
				switch (num3 == num)
				{
				}
				num = (short)1831731201;
				if (num != 0)
				{
				}
				num = (short)1213136896;
				if (num != 0)
				{
				}
				this.uclWideGen_RadioIdEdit_A00003.Visible = value;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x001DB9B0 File Offset: 0x001D9BB0
		// (set) Token: 0x060014CF RID: 5327 RVA: 0x001DBA64 File Offset: 0x001D9C64
		internal bool UclWideGen_RadioIdEdit_A00003_HiddenStatic
		{
			get
			{
				short num = (short)1583546368;
				short num2 = num;
				num = (short)1652097025;
				if (num != 0)
				{
				}
				num = (short)1716338690;
				short num3 = num;
				num = (short)558317570;
				switch (num3 == num)
				{
				}
				num = (short)346816512;
				if (num != 0)
				{
				}
				return this.uclWideGen_RadioIdEdit_A00003.HiddenStatic;
			}
			set
			{
				short num = (short)1522335744;
				short num2 = num;
				num = (short)239496225;
				short num3 = num;
				num = (short)525298721;
				switch (num3 == num)
				{
				}
				num = (short)1330774017;
				if (num != 0)
				{
				}
				num = (short)1475018752;
				if (num != 0)
				{
				}
				this.uclWideGen_RadioIdEdit_A00003.HiddenStatic = value;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x060014D0 RID: 5328 RVA: 0x001DBB18 File Offset: 0x001D9D18
		// (set) Token: 0x060014D1 RID: 5329 RVA: 0x001DBBCC File Offset: 0x001D9DCC
		public bool UclWideGen_RadioIdEdit_A00003_Valid
		{
			get
			{
				short num = (short)1925709824;
				short num2 = num;
				num = (short)875308314;
				short num3 = num;
				num = (short)853419290;
				switch (num3 == num)
				{
				}
				num = (short)1812135937;
				if (num != 0)
				{
				}
				num = (short)1486356480;
				if (num != 0)
				{
				}
				return this.uclWideGen_RadioIdEdit_A00003.Valid;
			}
			set
			{
				short num = (short)597688320;
				short num2 = num;
				num = (short)714014721;
				if (num != 0)
				{
				}
				num = (short)75208090;
				short num3 = num;
				num = (short)1641977242;
				switch (num3 == num)
				{
				}
				num = (short)1741750272;
				if (num != 0)
				{
				}
				this.uclWideGen_RadioIdEdit_A00003.Valid = value;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x001DBC80 File Offset: 0x001D9E80
		public bool UclWideGen_RadioIdEdit_A00003_HasDiffs
		{
			get
			{
				short num = (short)604241920;
				short num2 = num;
				num = (short)1131405186;
				short num3 = num;
				num = (short)297328514;
				switch (num3 == num)
				{
				}
				num = (short)1102249984;
				if (num != 0)
				{
				}
				num = (short)1543700481;
				if (num != 0)
				{
				}
				return this.uclWideGen_RadioIdEdit_A00003._HasDiffs;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x001DBD30 File Offset: 0x001D9F30
		// (set) Token: 0x060014D4 RID: 5332 RVA: 0x001DBDE4 File Offset: 0x001D9FE4
		public int UclWideGen_ContactDataOrder_A00005Value
		{
			get
			{
				short num = (short)69730304;
				short num2 = num;
				num = (short)2008622444;
				short num3 = num;
				num = (short)1381049708;
				switch (num3 == num)
				{
				}
				num = (short)647692289;
				if (num != 0)
				{
				}
				num = (short)594542592;
				if (num != 0)
				{
				}
				return this.uclWideGen_ContactDataOrder_A00005.Value;
			}
			set
			{
				short num = (short)1157300224;
				short num2 = num;
				num = (short)274816858;
				short num3 = num;
				num = (short)132079450;
				switch (num3 == num)
				{
				}
				num = (short)1371209728;
				if (num != 0)
				{
				}
				num = (short)877985793;
				if (num != 0)
				{
				}
				this.uclWideGen_ContactDataOrder_A00005.Value = value;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x001DBE9C File Offset: 0x001DA09C
		public global::AcpBusinessLayer.AcpSparseLOVField UclWideGen_ContactDataOrder_A00005Object
		{
			get
			{
				short num = (short)1103429632;
				short num2 = num;
				num = (short)1749549154;
				short num3 = num;
				num = (short)372703330;
				switch (num3 == num)
				{
				}
				num = (short)1737883649;
				if (num != 0)
				{
				}
				num = (short)2109210624;
				if (num != 0)
				{
				}
				return this.uclWideGen_ContactDataOrder_A00005;
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x001DBF48 File Offset: 0x001DA148
		// (set) Token: 0x060014D7 RID: 5335 RVA: 0x001DBFFC File Offset: 0x001DA1FC
		public string UclWideGen_ContactDataOrder_A00005_UIValue
		{
			get
			{
				short num = (short)1904607232;
				short num2 = num;
				num = (short)1370193451;
				short num3 = num;
				num = (short)1548385835;
				switch (num3 == num)
				{
				}
				num = (short)777584641;
				if (num != 0)
				{
				}
				num = (short)951582720;
				if (num != 0)
				{
				}
				return this.uclWideGen_ContactDataOrder_A00005.UIValue;
			}
			set
			{
				short num = (short)490405888;
				short num2 = num;
				num = (short)1674467662;
				short num3 = num;
				num = (short)1357338958;
				switch (num3 == num)
				{
				}
				num = (short)487718913;
				if (num != 0)
				{
				}
				num = (short)911998976;
				if (num != 0)
				{
				}
				this.uclWideGen_ContactDataOrder_A00005.UIValue = value;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x001DC0B4 File Offset: 0x001DA2B4
		public string UclWideGen_ContactDataOrder_A00005_UILabel
		{
			get
			{
				short num = (short)1308950528;
				short num2 = num;
				num = (short)508870817;
				short num3 = num;
				num = (short)625262753;
				switch (num3 == num)
				{
				}
				num = (short)2141913088;
				if (num != 0)
				{
				}
				num = (short)603062273;
				if (num != 0)
				{
				}
				return this.uclWideGen_ContactDataOrder_A00005.UIName;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x001DC168 File Offset: 0x001DA368
		// (set) Token: 0x060014DA RID: 5338 RVA: 0x001DC21C File Offset: 0x001DA41C
		public bool UclWideGen_ContactDataOrder_A00005_Applicable
		{
			get
			{
				short num = (short)73531392;
				short num2 = num;
				num = (short)1328230584;
				short num3 = num;
				num = (short)2004562104;
				switch (num3 == num)
				{
				}
				num = (short)1904214017;
				if (num != 0)
				{
				}
				num = (short)969539584;
				if (num != 0)
				{
				}
				return this.uclWideGen_ContactDataOrder_A00005.Applicable;
			}
			set
			{
				short num = (short)1340473344;
				short num2 = num;
				num = (short)2003808149;
				short num3 = num;
				num = (short)937865109;
				switch (num3 == num)
				{
				}
				num = (short)1757413377;
				if (num != 0)
				{
				}
				num = (short)1443037184;
				if (num != 0)
				{
				}
				this.uclWideGen_ContactDataOrder_A00005.Applicable = value;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x001DC2D4 File Offset: 0x001DA4D4
		// (set) Token: 0x060014DC RID: 5340 RVA: 0x001DC38C File Offset: 0x001DA58C
		public bool UclWideGen_ContactDataOrder_A00005_Editable
		{
			get
			{
				short num = (short)1236795392;
				short num2 = num;
				num = (short)544766035;
				short num3 = num;
				num = (short)1854109779;
				switch (num3 == num)
				{
				}
				num = (short)589430784;
				if (num != 0)
				{
				}
				num = (short)658702337;
				if (num != 0)
				{
				}
				return this.uclWideGen_ContactDataOrder_A00005.Editable;
			}
			set
			{
				short num = (short)1901133824;
				short num2 = num;
				num = (short)1071448065;
				if (num != 0)
				{
				}
				num = (short)1783692876;
				short num3 = num;
				num = (short)267124300;
				switch (num3 == num)
				{
				}
				num = (short)1550319616;
				if (num != 0)
				{
				}
				this.uclWideGen_ContactDataOrder_A00005.Editable = value;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x001DC440 File Offset: 0x001DA640
		// (set) Token: 0x060014DE RID: 5342 RVA: 0x001DC4F4 File Offset: 0x001DA6F4
		public bool UclWideGen_ContactDataOrder_A00005_Visible
		{
			get
			{
				short num = (short)1007681536;
				short num2 = num;
				num = (short)2089324271;
				short num3 = num;
				num = (short)276139759;
				switch (num3 == num)
				{
				}
				num = (short)1314521088;
				if (num != 0)
				{
				}
				num = (short)275382273;
				if (num != 0)
				{
				}
				return this.uclWideGen_ContactDataOrder_A00005.Visible;
			}
			set
			{
				short num = (short)1686044672;
				short num2 = num;
				num = (short)910760597;
				short num3 = num;
				num = (short)931011221;
				switch (num3 == num)
				{
				}
				num = (short)866254849;
				if (num != 0)
				{
				}
				num = (short)1918369792;
				if (num != 0)
				{
				}
				this.uclWideGen_ContactDataOrder_A00005.Visible = value;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x001DC5A8 File Offset: 0x001DA7A8
		// (set) Token: 0x060014E0 RID: 5344 RVA: 0x001DC658 File Offset: 0x001DA858
		internal bool UclWideGen_ContactDataOrder_A00005_HiddenStatic
		{
			get
			{
				short num = (short)120782848;
				short num2 = num;
				num = (short)836922234;
				short num3 = num;
				num = (short)1789553530;
				switch (num3 == num)
				{
				}
				num = (short)1756299265;
				if (num != 0)
				{
				}
				num = (short)928514048;
				if (num != 0)
				{
				}
				return this.uclWideGen_ContactDataOrder_A00005.HiddenStatic;
			}
			set
			{
				short num = (short)1637744640;
				short num2 = num;
				num = (short)371916877;
				short num3 = num;
				num = (short)143458381;
				switch (num3 == num)
				{
				}
				num = (short)1946157057;
				if (num != 0)
				{
				}
				num = (short)985530368;
				if (num != 0)
				{
				}
				this.uclWideGen_ContactDataOrder_A00005.HiddenStatic = value;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x001DC70C File Offset: 0x001DA90C
		// (set) Token: 0x060014E2 RID: 5346 RVA: 0x001DC7C4 File Offset: 0x001DA9C4
		public bool UclWideGen_ContactDataOrder_A00005_Valid
		{
			get
			{
				short num = (short)2081751040;
				short num2 = num;
				num = (short)326313184;
				short num3 = num;
				num = (short)439100640;
				switch (num3 == num)
				{
				}
				num = (short)988807168;
				if (num != 0)
				{
				}
				num = (short)1503985665;
				if (num != 0)
				{
				}
				return this.uclWideGen_ContactDataOrder_A00005.Valid;
			}
			set
			{
				short num = (short)1985871872;
				short num2 = num;
				num = (short)1671954433;
				if (num != 0)
				{
				}
				num = (short)1732952953;
				short num3 = num;
				num = (short)1735836537;
				switch (num3 == num)
				{
				}
				num = (short)618856448;
				if (num != 0)
				{
				}
				this.uclWideGen_ContactDataOrder_A00005.Valid = value;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x001DC87C File Offset: 0x001DAA7C
		public bool UclWideGen_ContactDataOrder_A00005_HasDiffs
		{
			get
			{
				short num = (short)529793024;
				short num2 = num;
				num = (short)1071178041;
				short num3 = num;
				num = (short)55632185;
				switch (num3 == num)
				{
				}
				num = (short)1491075072;
				if (num != 0)
				{
				}
				num = (short)2028273665;
				if (num != 0)
				{
				}
				return this.uclWideGen_ContactDataOrder_A00005._HasDiffs;
			}
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0000265F File Offset: 0x0000085F
		internal UclWideSectionGeneral(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x001DC930 File Offset: 0x001DAB30
		public bool HasDiffs
		{
			get
			{
				short num = (short)163381248;
				short num2 = num;
				num = (short)1521817751;
				short num3 = num;
				num = (short)927996055;
				switch (num3 == num)
				{
				}
				num = (short)64684033;
				if (num != 0)
				{
				}
				num = (short)615186432;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x04000B76 RID: 2934
		private global::AcpBusinessLayer.AcpField<bool> uclWideGen_UCLEdit_A00001;

		// Token: 0x04000B77 RID: 2935
		private global::AcpBusinessLayer.AcpField<bool> uclWideGen_HotListEdit_A00002;

		// Token: 0x04000B78 RID: 2936
		private global::AcpBusinessLayer.AcpField<bool> uclWideGen_PhoneNumEdit_A00004;

		// Token: 0x04000B79 RID: 2937
		private global::AcpBusinessLayer.AcpField<bool> uclWideGen_RadioIdEdit_A00003;

		// Token: 0x04000B7A RID: 2938
		private global::AcpBusinessLayer.AcpSparseLOVField uclWideGen_ContactDataOrder_A00005;

		// Token: 0x020001B9 RID: 441
		internal class CallTypeLOVConverter : global::System.Windows.Data.IValueConverter
		{
			// Token: 0x060014E6 RID: 5350 RVA: 0x001DC9DC File Offset: 0x001DABDC
			public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				switch (0)
				{
				case 0:
					goto IL_38;
				}
				int num;
				string result;
				short num2;
				int num3;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_18E;
					case 1:
						return result;
					case 2:
						num2 = (short)812974089;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_FE;
					case 4:
						goto IL_DC;
					case 5:
						switch (num3)
						{
						case 1:
							result = global::CommonResources.AppResources.Trunk_A25;
							num2 = (short)1421082632;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							result = global::CommonResources.AppResources.Trunk_T2;
							num2 = (short)1366949889;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 3:
							result = global::CommonResources.AppResources.Conv_MDC;
							num2 = (short)1027801094;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 4:
							result = global::CommonResources.AppResources.Conv_ASTRO;
							num2 = (short)665649155;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 5:
						case 6:
							goto IL_171;
						case 7:
							result = global::CommonResources.AppResources.Mobile_Phone;
							num2 = (short)934936580;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 8:
							result = global::CommonResources.AppResources.Work_Phone;
							num2 = (short)1906245639;
							num = (int)((global::System.IntPtr)num2);
							continue;
						default:
							num2 = (short)1727135746;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					case 6:
						goto IL_1EA;
					case 7:
						goto IL_1CA;
					case 8:
					{
						num2 = (short)1330528660;
						short num4 = num2;
						num2 = (short)237846932;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_156;
						}
						break;
					}
					case 9:
						goto IL_171;
					}
					goto IL_38;
					IL_171:
					result = global::CommonResources.AppResources.DEFAULT_Id;
					num2 = (short)1741553664;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_DC:
				IL_FE:
				return result;
				IL_156:
				num2 = (short)584384512;
				if (num2 != 0)
				{
				}
				IL_18E:
				IL_1CA:
				return result;
				IL_1EA:
				num2 = (short)2057306112;
				short num5 = num2;
				return result;
				IL_38:
				num2 = (short)514981889;
				if (num2 != 0)
				{
				}
				num3 = (int)value;
				num2 = (short)436207621;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x060014E7 RID: 5351 RVA: 0x001DCC20 File Offset: 0x001DAE20
			public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				switch (0)
				{
				case 0:
					goto IL_5C;
				}
				int num;
				string a;
				short num2;
				int num4;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (a == global::CommonResources.AppResources.Conv_ASTRO)
						{
							num2 = (short)178782224;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1503199249;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						if (a == global::CommonResources.AppResources.Trunk_A25)
						{
							goto IL_88;
						}
						num2 = (short)904658957;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
					{
						num2 = (short)1767063397;
						short num3 = num2;
						num2 = (short)1731149669;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_88;
						default:
							num2 = (short)557449216;
							if (num2 != 0)
							{
							}
							num4 = 7;
							num2 = (short)2022703107;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						goto IL_109;
					case 4:
						goto IL_166;
					case 5:
						num4 = 8;
						num2 = (short)456327172;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						if (a == global::CommonResources.AppResources.Conv_MDC)
						{
							num2 = (short)96927744;
							short num5 = num2;
							num2 = (short)1713111048;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1078263808;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						num4 = 2;
						num2 = (short)14745611;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						num4 = 3;
						num2 = (short)1897332748;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 9:
						goto IL_127;
					case 10:
						if (a == global::CommonResources.AppResources.Work_Phone)
						{
							num2 = (short)376832005;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num4 = 0;
						num2 = (short)80674831;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 11:
						goto IL_146;
					case 12:
						goto IL_22A;
					case 13:
						if (a == global::CommonResources.AppResources.Trunk_T2)
						{
							num2 = (short)1323499527;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1750925318;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 14:
						num4 = 1;
						num2 = (short)1393819666;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 15:
						goto IL_20C;
					case 16:
						num4 = 4;
						num2 = (short)1835204617;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 17:
						if (a == global::CommonResources.AppResources.Mobile_Phone)
						{
							num2 = (short)1699610626;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1065091073;
						if (num2 != 0)
						{
						}
						num2 = (short)19333130;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 18:
						goto IL_24A;
					}
					goto IL_5C;
					IL_88:
					num2 = (short)477560846;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_109:
				IL_127:
				IL_146:
				IL_166:
				IL_20C:
				IL_22A:
				IL_24A:
				return num4;
				IL_5C:
				a = (string)value;
				num2 = (short)839254017;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}
	}
}
