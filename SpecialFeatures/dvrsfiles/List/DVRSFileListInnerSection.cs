using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.DVRSFiles.List
{
	// Token: 0x02000130 RID: 304
	[global::System.Serializable]
	public sealed class DVRSFileListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06000FF3 RID: 4083 RVA: 0x00002650 File Offset: 0x00000850
		public DVRSFileListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0000265F File Offset: 0x0000085F
		internal DVRSFileListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0016517C File Offset: 0x0016337C
		public override void Init()
		{
			int a_ = 6;
			short num = (short)2079737730;
			short num2 = num;
			num = (short)1207125890;
			switch (num2 == num)
			{
			}
			num = (short)184549377;
			if (num != 0)
			{
			}
			num = (short)1463746560;
			short num3 = num;
			num = (short)1278541824;
			if (num != 0)
			{
			}
			this.dvrsConfigDVRSFileData_A43734 = new global::AcpBusinessLayer.AcpStringField("", this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춈\udd8a\udf8c\udc8e힐朗璉", a_), global::CommonResources.AppResources.DVRS_File_Data_ID, 16);
			this.dvrsConfigDVRSFileData_A43734.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dvrsConfigDVRSFileData_A43734.DataTransferOrder = -1;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춈\udd8a\udf8c\udc8e놐햒ﲔﮖﲘ뮚톜튠힢", a_);
			base.Id = 10894;
			base.UIName = global::CommonResources.AcgResources.ID_DVRSFILELIST;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0016529C File Offset: 0x0016349C
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1642628389;
			short num2 = num;
			num = (short)1900250405;
			switch (num2 == num)
			{
			}
			num = (short)1620836352;
			if (num != 0)
			{
			}
			num = (short)459538432;
			short num3 = num;
			num = (short)720437249;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0016534C File Offset: 0x0016354C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 3;
			short num = (short)326828036;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_129;
				case 1:
				{
					num = (short)230160567;
					short num3 = num;
					num = (short)1503000759;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_129;
					default:
						num = (short)1200947200;
						if (num != 0)
						{
						}
						num = (short)367525888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					this.dvrsConfigDVRSFileData_A43734 = new global::AcpBusinessLayer.AcpStringField("", this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슅\ude87\ud889\udf8b좍憐ﺑ", a_), global::CommonResources.AppResources.DVRS_File_Data_ID, 16);
					this.dvrsConfigDVRSFileData_A43734.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dvrsConfigDVRSFileData_A43734.DataTransferOrder = -1;
					num = (short)1005846534;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields != null)
					{
						num = (short)1667629057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E2;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 5:
				{
					num = (short)2063728640;
					short num4 = num;
					num = (short)1674903555;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_C2;
				}
				IL_49:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)904462341;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_129:
				num = (short)1182597121;
				if (num != 0)
				{
				}
				if (!producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슅\ude87\ud889\udf8b좍憐ﺑ", a_)))
				{
					break;
				}
				num = (short)2091319298;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C2:
			IL_1E2:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슅\ude87\ud889\udf8b꺍횏ﮑ뢗횙풟", a_);
			base.Id = 10894;
			base.UIName = global::CommonResources.AcgResources.ID_DVRSFILELIST;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0016556C File Offset: 0x0016376C
		public override void PopulateReferences()
		{
			short num = (short)712572929;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)1851654144;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				}
				case 2:
				{
					global::AcpCommonLib.Document containerDoc = base.ParentRecset.ContainerDoc;
					goto IL_FA;
				}
				}
				IL_58:
				if (base.ParentRecset == null)
				{
					break;
				}
				num = (short)2058378070;
				short num4 = num;
				num = (short)652893014;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1146028033;
					if (num != 0)
					{
					}
					num = (short)2060976128;
					if (num != 0)
					{
					}
					num = (short)662568962;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_FA:
				num = (short)417005568;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0016568C File Offset: 0x0016388C
		public override void DropReferences()
		{
			short num = (short)933376576;
			short num2 = num;
			num = (short)769208896;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1451491328;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1396899841;
			if (num != 0)
			{
			}
			num = (short)1094254592;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00165738 File Offset: 0x00163938
		public override void SetConstraints()
		{
			short num = (short)1777955822;
			short num2 = num;
			num = (short)1852404718;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1569128448;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1036845057;
			if (num != 0)
			{
			}
			num = (short)1151074304;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x001657E4 File Offset: 0x001639E4
		public override void SetupDependencies()
		{
			short num = (short)1605990364;
			short num2 = num;
			num = (short)358905820;
			switch (num2 == num)
			{
			default:
			{
				num = (short)78577664;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)98304001;
			if (num != 0)
			{
			}
			num = (short)1087766528;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x0016588C File Offset: 0x00163A8C
		public bool HasDiffs
		{
			get
			{
				short num = (short)450838086;
				short num2 = num;
				num = (short)784612934;
				switch (num2 == num)
				{
				default:
				{
					num = (short)32768000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1756102656;
				if (num != 0)
				{
				}
				num = (short)2020933633;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000FFD RID: 4093 RVA: 0x0016593C File Offset: 0x00163B3C
		// (set) Token: 0x06000FFE RID: 4094 RVA: 0x001659F0 File Offset: 0x00163BF0
		public string DVRSConfigDVRSFileData_A43734Value
		{
			get
			{
				short num = (short)732420419;
				short num2 = num;
				num = (short)547871043;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1490485248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1987641344;
				if (num != 0)
				{
				}
				num = (short)87621633;
				if (num != 0)
				{
				}
				return this.dvrsConfigDVRSFileData_A43734.Value;
			}
			set
			{
				short num = (short)1621101364;
				short num2 = num;
				num = (short)914688820;
				switch (num2 == num)
				{
				default:
				{
					num = (short)82640896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1420099585;
				if (num != 0)
				{
				}
				num = (short)984154112;
				if (num != 0)
				{
				}
				this.dvrsConfigDVRSFileData_A43734.Value = value;
				this.dvrsConfigDVRSFileData_A43734.SetUITimer();
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000FFF RID: 4095 RVA: 0x00165AB0 File Offset: 0x00163CB0
		public global::AcpBusinessLayer.AcpStringField DVRSConfigDVRSFileData_A43734
		{
			get
			{
				short num = (short)785292352;
				short num2 = num;
				num = (short)980327488;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1587085312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1304559617;
				if (num != 0)
				{
				}
				num = (short)125108224;
				if (num != 0)
				{
				}
				return this.dvrsConfigDVRSFileData_A43734;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x00165B60 File Offset: 0x00163D60
		internal string DVRSConfigDVRSFileData_A43734_UILabel
		{
			get
			{
				short num = (short)1707148289;
				short num2 = num;
				num = (short)891028481;
				switch (num2 == num)
				{
				default:
				{
					num = (short)88932352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)445644800;
				if (num != 0)
				{
				}
				num = (short)1214709761;
				if (num != 0)
				{
				}
				return this.dvrsConfigDVRSFileData_A43734.UIName;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x00165C14 File Offset: 0x00163E14
		// (set) Token: 0x06001002 RID: 4098 RVA: 0x00165CCC File Offset: 0x00163ECC
		public bool DVRSConfigDVRSFileData_A43734_Applicable
		{
			get
			{
				short num = (short)1546917140;
				short num2 = num;
				num = (short)579867924;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1580335104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1832845313;
				if (num != 0)
				{
				}
				num = (short)697565184;
				if (num != 0)
				{
				}
				return this.dvrsConfigDVRSFileData_A43734.Applicable;
			}
			set
			{
				short num = (short)476381185;
				if (num != 0)
				{
				}
				num = (short)467992576;
				short num2 = num;
				num = (short)195891990;
				short num3 = num;
				num = (short)227349270;
				switch (num3 == num)
				{
				}
				num = (short)1931673600;
				if (num != 0)
				{
				}
				this.dvrsConfigDVRSFileData_A43734.Applicable = value;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x00165D84 File Offset: 0x00163F84
		// (set) Token: 0x06001004 RID: 4100 RVA: 0x00165E38 File Offset: 0x00164038
		public bool DVRSConfigDVRSFileData_A43734_Editable
		{
			get
			{
				short num = (short)903610776;
				short num2 = num;
				num = (short)1874723224;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1535574016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1879965697;
				if (num != 0)
				{
				}
				num = (short)1639383040;
				if (num != 0)
				{
				}
				return this.dvrsConfigDVRSFileData_A43734.Editable;
			}
			set
			{
				short num = (short)756537822;
				short num2 = num;
				num = (short)810015198;
				switch (num2 == num)
				{
				default:
				{
					num = (short)579993600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)238682113;
				if (num != 0)
				{
				}
				num = (short)2103050240;
				if (num != 0)
				{
				}
				this.dvrsConfigDVRSFileData_A43734.Editable = value;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x00165EEC File Offset: 0x001640EC
		// (set) Token: 0x06001006 RID: 4102 RVA: 0x00165FA0 File Offset: 0x001641A0
		public bool DVRSConfigDVRSFileData_A43734_Visible
		{
			get
			{
				short num = (short)1232273409;
				if (num != 0)
				{
				}
				num = (short)207159296;
				short num2 = num;
				num = (short)1160414874;
				short num3 = num;
				num = (short)252937882;
				switch (num3 == num)
				{
				}
				num = (short)539557888;
				if (num != 0)
				{
				}
				return this.dvrsConfigDVRSFileData_A43734.Visible;
			}
			set
			{
				short num = (short)1319928103;
				short num2 = num;
				num = (short)110526759;
				switch (num2 == num)
				{
				default:
				{
					num = (short)720699392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)93192193;
				if (num != 0)
				{
				}
				num = (short)338821120;
				if (num != 0)
				{
				}
				this.dvrsConfigDVRSFileData_A43734.Visible = value;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001007 RID: 4103 RVA: 0x00166054 File Offset: 0x00164254
		// (set) Token: 0x06001008 RID: 4104 RVA: 0x00166110 File Offset: 0x00164310
		internal bool DVRSConfigDVRSFileData_A43734_HiddenStatic
		{
			get
			{
				short num = (short)1274106389;
				short num2 = num;
				num = (short)1641959957;
				switch (num2 == num)
				{
				}
				num = (short)778371072;
				short num3 = num;
				num = (short)916455425;
				if (num != 0)
				{
				}
				num = (short)1078657024;
				if (num != 0)
				{
				}
				return this.dvrsConfigDVRSFileData_A43734.HiddenStatic;
			}
			set
			{
				short num = (short)1600766992;
				short num2 = num;
				num = (short)635290640;
				switch (num2 == num)
				{
				}
				num = (short)1837760512;
				short num3 = num;
				num = (short)196214785;
				if (num != 0)
				{
				}
				num = (short)839712768;
				if (num != 0)
				{
				}
				this.dvrsConfigDVRSFileData_A43734.HiddenStatic = value;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x001661C8 File Offset: 0x001643C8
		// (set) Token: 0x0600100A RID: 4106 RVA: 0x0016627C File Offset: 0x0016447C
		public bool DVRSConfigDVRSFileData_A43734_Valid
		{
			get
			{
				short num = (short)109120876;
				short num2 = num;
				num = (short)147590508;
				switch (num2 == num)
				{
				}
				num = (short)993722368;
				short num3 = num;
				num = (short)1019478017;
				if (num != 0)
				{
				}
				num = (short)1942749184;
				if (num != 0)
				{
				}
				return this.dvrsConfigDVRSFileData_A43734.Valid;
			}
			set
			{
				short num = (short)1898819677;
				short num2 = num;
				num = (short)1949675613;
				switch (num2 == num)
				{
				}
				num = (short)1973354496;
				short num3 = num;
				num = (short)1936392192;
				if (num != 0)
				{
				}
				num = (short)593559553;
				if (num != 0)
				{
				}
				this.dvrsConfigDVRSFileData_A43734.Valid = value;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x00166334 File Offset: 0x00164534
		public bool DVRSConfigDVRSFileData_A43734_HasDiffs
		{
			get
			{
				short num = (short)587333633;
				if (num != 0)
				{
				}
				num = (short)1466187334;
				short num2 = num;
				num = (short)2003320390;
				switch (num2 == num)
				{
				default:
				{
					num = (short)952369152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)725155840;
				if (num != 0)
				{
				}
				return this.dvrsConfigDVRSFileData_A43734._HasDiffs;
			}
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x001663EC File Offset: 0x001645EC
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
					goto IL_E9;
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1178664960;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)825229313;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						num2 = (short)823459844;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E9;
				case 3:
					IL_C3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)641662977;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E9;
				case 4:
					num2 = (short)782041091;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_E9:
				num2 = (short)804651008;
				short num3 = num2;
				num2 = (short)1627670424;
				short num4 = num2;
				num2 = (short)1085097880;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_C3;
				default:
					goto IL_147;
				}
			}
			IL_147:
			num2 = (short)20250624;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1184104450;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000840 RID: 2112
		private global::AcpBusinessLayer.AcpStringField dvrsConfigDVRSFileData_A43734;
	}
}
