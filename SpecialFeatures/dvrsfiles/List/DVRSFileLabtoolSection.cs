using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.DVRSFiles.List
{
	// Token: 0x0200012B RID: 299
	[global::System.Serializable]
	public sealed class DVRSFileLabtoolSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06000FB5 RID: 4021 RVA: 0x000034C0 File Offset: 0x000016C0
		public DVRSFileLabtoolSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x0000265F File Offset: 0x0000085F
		internal DVRSFileLabtoolSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x00161D9C File Offset: 0x0015FF9C
		public global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset DVRSFileListInnerRecset
		{
			get
			{
				short num = (short)897519750;
				short num2 = num;
				num = (short)734859398;
				switch (num2 == num)
				{
				}
				num = (short)408813569;
				if (num != 0)
				{
				}
				num = (short)1034747904;
				short num3 = num;
				num = (short)903741440;
				if (num != 0)
				{
				}
				return this.innerRecset;
			}
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00161E48 File Offset: 0x00160048
		public override void Init()
		{
			int a_ = 10;
			short num = (short)1247478130;
			short num2 = num;
			num = (short)836108658;
			switch (num2 == num)
			{
			}
			num = (short)9371649;
			if (num != 0)
			{
			}
			num = (short)1868955648;
			short num3 = num;
			num = (short)2125725696;
			if (num != 0)
			{
			}
			this.dvrsConfigDVRSFileName_A43736 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즌\ud98e쎐삒횔ﶚ슪솬쪮ﾰ튲\ud8b4튶諸覼貾", a_), global::CommonResources.AppResources.DVRS_Filename_ID, 255);
			this.dvrsConfigDVRSFileName_A43736.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dvrsConfigDVRSFileName_A43736.DataTransferOrder = -1;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("소杖", a_);
			base.Id = 10893;
			base.UIName = global::CommonResources.AppResources.Labtool_Id;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00161F68 File Offset: 0x00160168
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)561184770;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_19B;
				case 1:
				{
					num = (short)413007872;
					short num3 = num;
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잂펄햆\uda88좊朗펖쾘즚캜\ud99e좠쾢삤좨욪좬螲蚴肶誸趺", a_)))
					{
						num = (short)1918697475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E3;
				}
				case 2:
				{
					num = (short)527182943;
					short num4 = num;
					num = (short)216476767;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19B;
					default:
						num = (short)457244672;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_94;
						}
						continue;
					}
					break;
				}
				case 3:
					this.dvrsConfigDVRSFileName_A43736 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잂펄햆\uda88좊朗펖쾘즚캜\ud99e좠쾢삤좨욪좬螲蚴肶誸趺", a_), global::CommonResources.AppResources.DVRS_Filename_ID, 255);
					this.dvrsConfigDVRSFileName_A43736.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dvrsConfigDVRSFileName_A43736.DataTransferOrder = -1;
					num = (short)563675140;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_10B;
				case 5:
					num = (short)630718465;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1099759616;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_94:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1193869318;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_19B:
				num = (short)1183973377;
				if (num != 0)
				{
				}
				if (producerFields == null)
				{
					break;
				}
				num = (short)608894981;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10B:
			IL_1E3:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾂ﶈ", a_);
			base.Id = 10893;
			base.UIName = global::CommonResources.AppResources.Labtool_Id;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x0016218C File Offset: 0x0016038C
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)902068049;
			short num2 = num;
			num = (short)1200256849;
			switch (num2 == num)
			{
			}
			num = (short)66846721;
			if (num != 0)
			{
			}
			num = (short)1475149824;
			if (num != 0)
			{
			}
			num = (short)1190920192;
			short num3 = num;
			base.GetObjectData(info, context);
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00162240 File Offset: 0x00160440
		public override void PopulateReferences()
		{
			short num = (short)1421672448;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2116091904;
				short num3 = num;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 1:
					goto IL_E9;
				case 2:
				{
					global::AcpCommonLib.Document containerDoc = base.ParentRecset.ContainerDoc;
					goto IL_D2;
				}
				}
				IL_5A:
				num = (short)1342139668;
				short num4 = num;
				num = (short)182938900;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_D2:
					num = (short)1276706817;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1570963456;
					if (num != 0)
					{
					}
					if (base.ParentRecset == null)
					{
						return;
					}
					num = (short)1743978498;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_E9:
			num = (short)722468865;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00162360 File Offset: 0x00160560
		public override void DropReferences()
		{
			short num = (short)1198325761;
			if (num != 0)
			{
			}
			num = (short)159318289;
			short num2 = num;
			num = (short)1624375569;
			switch (num2 == num)
			{
			}
			num = (short)1780940800;
			if (num != 0)
			{
			}
			num = (short)357695488;
			short num3 = num;
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x0016240C File Offset: 0x0016060C
		public override void SetConstraints()
		{
			short num = (short)21892367;
			short num2 = num;
			num = (short)1185025295;
			switch (num2 == num)
			{
			}
			num = (short)2111438848;
			if (num != 0)
			{
			}
			num = (short)619053057;
			if (num != 0)
			{
			}
			num = (short)1951268864;
			short num3 = num;
			this.DVRSConfigDVRSFileName_A43736Object.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x001624CC File Offset: 0x001606CC
		public override void SetupDependencies()
		{
			short num = (short)1798630330;
			short num2 = num;
			num = (short)1419439034;
			switch (num2 == num)
			{
			}
			num = (short)95289344;
			if (num != 0)
			{
			}
			num = (short)796852225;
			if (num != 0)
			{
			}
			num = (short)1832976384;
			short num3 = num;
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00162578 File Offset: 0x00160778
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)923664385;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_33:
				switch (num2)
				{
				case 0:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1873870848;
					short num3 = num;
					num = (short)1255276548;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (base.ParentRecset != null)
					{
						num = (short)1838809090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
				{
					num = (short)1648111595;
					short num4 = num;
					num = (short)1002647531;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num = (short)653918208;
						if (num != 0)
						{
						}
						num = (short)1893203971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)890830848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 4:
					return result;
				}
				goto IL_4D;
			}
			return result;
			IL_4D:
			result = null;
			num = (short)1251475457;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x001626F0 File Offset: 0x001608F0
		public bool HasDiffs
		{
			get
			{
				short num = (short)904527873;
				if (num != 0)
				{
				}
				num = (short)2077979009;
				short num2 = num;
				num = (short)862548353;
				switch (num2 == num)
				{
				}
				num = (short)545128448;
				if (num != 0)
				{
				}
				num = (short)2137456640;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000FC1 RID: 4033 RVA: 0x001627A0 File Offset: 0x001609A0
		// (set) Token: 0x06000FC2 RID: 4034 RVA: 0x00162854 File Offset: 0x00160A54
		public string DVRSConfigDVRSFileName_A43736Value
		{
			get
			{
				short num = (short)352377891;
				short num2 = num;
				num = (short)1710087203;
				switch (num2 == num)
				{
				}
				num = (short)17301505;
				if (num != 0)
				{
				}
				num = (short)856883200;
				if (num != 0)
				{
				}
				num = (short)1315307520;
				short num3 = num;
				return this.dvrsConfigDVRSFileName_A43736.Value;
			}
			set
			{
				short num = (short)1168487705;
				short num2 = num;
				num = (short)741586201;
				switch (num2 == num)
				{
				}
				num = (short)584450049;
				if (num != 0)
				{
				}
				num = (short)1148256256;
				if (num != 0)
				{
				}
				num = (short)603652096;
				short num3 = num;
				this.dvrsConfigDVRSFileName_A43736.Value = value;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x00162908 File Offset: 0x00160B08
		public global::AcpBusinessLayer.AcpKeyField DVRSConfigDVRSFileName_A43736Object
		{
			get
			{
				short num = (short)1002848746;
				short num2 = num;
				num = (short)1855603178;
				switch (num2 == num)
				{
				}
				num = (short)1378156545;
				if (num != 0)
				{
				}
				num = (short)1610612736;
				if (num != 0)
				{
				}
				num = (short)470482944;
				short num3 = num;
				return this.dvrsConfigDVRSFileName_A43736;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x001629B4 File Offset: 0x00160BB4
		internal string DVRSConfigDVRSFileName_A43736_UILabel
		{
			get
			{
				short num = (short)744763501;
				short num2 = num;
				num = (short)2010001517;
				switch (num2 == num)
				{
				}
				num = (short)337707009;
				if (num != 0)
				{
				}
				num = (short)1028915200;
				if (num != 0)
				{
				}
				num = (short)1368064000;
				short num3 = num;
				return this.dvrsConfigDVRSFileName_A43736.UIName;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x00162A68 File Offset: 0x00160C68
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x00162B1C File Offset: 0x00160D1C
		public bool DVRSConfigDVRSFileName_A43736_Applicable
		{
			get
			{
				short num = (short)570472439;
				short num2 = num;
				num = (short)1931786231;
				switch (num2 == num)
				{
				}
				num = (short)1389953025;
				if (num != 0)
				{
				}
				num = (short)419430400;
				if (num != 0)
				{
				}
				num = (short)1589248000;
				short num3 = num;
				return this.dvrsConfigDVRSFileName_A43736.Applicable;
			}
			set
			{
				short num = (short)2043532305;
				short num2 = num;
				num = (short)1010029585;
				switch (num2 == num)
				{
				}
				num = (short)2063925249;
				if (num != 0)
				{
				}
				num = (short)1776812032;
				if (num != 0)
				{
				}
				num = (short)2012479488;
				short num3 = num;
				this.dvrsConfigDVRSFileName_A43736.Applicable = value;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x00162BD0 File Offset: 0x00160DD0
		// (set) Token: 0x06000FC8 RID: 4040 RVA: 0x00162C84 File Offset: 0x00160E84
		public bool DVRSConfigDVRSFileName_A43736_Editable
		{
			get
			{
				short num = (short)1876906259;
				short num2 = num;
				num = (short)1704087827;
				switch (num2 == num)
				{
				}
				num = (short)2070085633;
				if (num != 0)
				{
				}
				num = (short)108855296;
				if (num != 0)
				{
				}
				num = (short)906428416;
				short num3 = num;
				return this.dvrsConfigDVRSFileName_A43736.Editable;
			}
			set
			{
				short num = (short)602865665;
				if (num != 0)
				{
				}
				num = (short)1957115046;
				short num2 = num;
				num = (short)576205990;
				switch (num2 == num)
				{
				}
				num = (short)1724710912;
				if (num != 0)
				{
				}
				num = (short)1111359488;
				short num3 = num;
				this.dvrsConfigDVRSFileName_A43736.Editable = value;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x00162D38 File Offset: 0x00160F38
		// (set) Token: 0x06000FCA RID: 4042 RVA: 0x00162DEC File Offset: 0x00160FEC
		public bool DVRSConfigDVRSFileName_A43736_Visible
		{
			get
			{
				short num = (short)271081037;
				short num2 = num;
				num = (short)969825869;
				switch (num2 == num)
				{
				}
				num = (short)2106785792;
				if (num != 0)
				{
				}
				num = (short)1552285697;
				if (num != 0)
				{
				}
				num = (short)1730412544;
				short num3 = num;
				return this.dvrsConfigDVRSFileName_A43736.Visible;
			}
			set
			{
				short num = (short)895156225;
				if (num != 0)
				{
				}
				num = (short)958139036;
				short num2 = num;
				num = (short)524815004;
				switch (num2 == num)
				{
				}
				num = (short)1869545472;
				if (num != 0)
				{
				}
				num = (short)1743192064;
				short num3 = num;
				this.dvrsConfigDVRSFileName_A43736.Visible = value;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x00162EA4 File Offset: 0x001610A4
		// (set) Token: 0x06000FCC RID: 4044 RVA: 0x00162F5C File Offset: 0x0016115C
		public bool DVRSConfigDVRSFileName_A43736_Valid
		{
			get
			{
				short num = (short)858770336;
				short num2 = num;
				num = (short)1019399072;
				switch (num2 == num)
				{
				}
				num = (short)664731649;
				if (num != 0)
				{
				}
				num = (short)1791557632;
				if (num != 0)
				{
				}
				num = (short)172556288;
				short num3 = num;
				return this.dvrsConfigDVRSFileName_A43736.Valid;
			}
			set
			{
				short num = (short)880023502;
				short num2 = num;
				num = (short)591796174;
				switch (num2 == num)
				{
				}
				num = (short)1354432512;
				if (num != 0)
				{
				}
				num = (short)1108934657;
				if (num != 0)
				{
				}
				num = (short)542441472;
				short num3 = num;
				this.dvrsConfigDVRSFileName_A43736.Valid = value;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x00163010 File Offset: 0x00161210
		// (set) Token: 0x06000FCE RID: 4046 RVA: 0x001630C4 File Offset: 0x001612C4
		internal bool DVRSConfigDVRSFileName_A43736_HiddenStatic
		{
			get
			{
				short num = (short)841524763;
				short num2 = num;
				num = (short)103786011;
				switch (num2 == num)
				{
				}
				num = (short)1968635904;
				if (num != 0)
				{
				}
				num = (short)758120449;
				if (num != 0)
				{
				}
				num = (short)1561657344;
				short num3 = num;
				return this.dvrsConfigDVRSFileName_A43736.HiddenStatic;
			}
			set
			{
				short num = (short)553581087;
				short num2 = num;
				num = (short)558955039;
				switch (num2 == num)
				{
				}
				num = (short)2057895937;
				if (num != 0)
				{
				}
				num = (short)1272315904;
				if (num != 0)
				{
				}
				num = (short)1662058496;
				short num3 = num;
				this.dvrsConfigDVRSFileName_A43736.HiddenStatic = value;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x00163178 File Offset: 0x00161378
		// (set) Token: 0x06000FD0 RID: 4048 RVA: 0x0016322C File Offset: 0x0016142C
		internal bool DVRSConfigDVRSFileName_A43736_HiddenDynamic
		{
			get
			{
				short num = (short)1827930113;
				if (num != 0)
				{
				}
				num = (short)1769538403;
				short num2 = num;
				num = (short)241566563;
				switch (num2 == num)
				{
				}
				num = (short)160432128;
				if (num != 0)
				{
				}
				num = (short)1318912000;
				short num3 = num;
				return this.dvrsConfigDVRSFileName_A43736.HiddenDynamic;
			}
			set
			{
				short num = (short)1016329528;
				short num2 = num;
				num = (short)613020984;
				switch (num2 == num)
				{
				}
				num = (short)14942209;
				if (num != 0)
				{
				}
				num = (short)1131151360;
				if (num != 0)
				{
				}
				num = (short)1707409408;
				short num3 = num;
				this.dvrsConfigDVRSFileName_A43736.HiddenDynamic = value;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x001632E4 File Offset: 0x001614E4
		public bool DVRSConfigDVRSFileName_A43736_HasDiffs
		{
			get
			{
				short num = (short)1609810634;
				short num2 = num;
				num = (short)928563914;
				switch (num2 == num)
				{
				}
				num = (short)1898315777;
				if (num != 0)
				{
				}
				num = (short)1400242176;
				if (num != 0)
				{
				}
				num = (short)692387840;
				short num3 = num;
				return this.dvrsConfigDVRSFileName_A43736._HasDiffs;
			}
		}

		// Token: 0x04000824 RID: 2084
		private global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset innerRecset;

		// Token: 0x04000825 RID: 2085
		private global::AcpBusinessLayer.AcpKeyField dvrsConfigDVRSFileName_A43736;
	}
}
