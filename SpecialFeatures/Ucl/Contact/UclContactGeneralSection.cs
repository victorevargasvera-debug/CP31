using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x02000217 RID: 535
	[global::System.Serializable]
	public sealed class UclContactGeneralSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001B53 RID: 6995 RVA: 0x00002650 File Offset: 0x00000850
		internal UclContactGeneralSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x00234390 File Offset: 0x00232590
		public override void Init()
		{
			int a_ = 5;
			short num = (short)760283136;
			short num2 = num;
			num = (short)509425155;
			short num3 = num;
			num = (short)1069561347;
			switch (num3 == num)
			{
			}
			num = (short)367919105;
			if (num != 0)
			{
			}
			num = (short)2122055680;
			if (num != 0)
			{
			}
			this.uclGen_ContactAlias_A00009 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87즍ﲑ쮓햕ﾝ쎟횡쪥솧쮩\udfab花蒳蚵袷莹", a_), global::CommonResources.AppResources.Contact_Name, 14);
			this.uclGen_ContactAlias_A00009.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclGen_ContactAlias_A00009.DataTransferOrder = 1;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾇", a_);
			base.UIName = global::CommonResources.AppResources.General_Id;
			base.Id = 10400;
			base.DataTransferOrder = 10;
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x002344AC File Offset: 0x002326AC
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)116785152;
			short num2 = num;
			num = (short)1911688128;
			short num3 = num;
			num = (short)3541952;
			switch (num3 == num)
			{
			}
			num = (short)951975937;
			if (num != 0)
			{
			}
			num = (short)1177157632;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x0023455C File Offset: 0x0023275C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)2121728000;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 1:
					num = (short)1877803009;
					if (num != 0)
					{
					}
					num = (short)816316418;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튆쪌ﾐ첒횔ﲜﲞ햠즤캦좨\ud8aa膰莲薴螶肸", a_)))
					{
						num = (short)217645062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E2;
				case 3:
					if (producerFields != null)
					{
						num = (short)576176878;
						short num3 = num;
						num = (short)204260078;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E2;
						case 1:
							break;
						default:
						{
							num = (short)1667694592;
							short num4 = num;
							break;
						}
						}
						num = (short)247726080;
						if (num != 0)
						{
						}
						num = (short)127139841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E2;
				case 4:
					num = (short)1960771587;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_BE;
				case 6:
					this.uclGen_ContactAlias_A00009 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튆쪌ﾐ첒횔ﲜﲞ햠즤캦좨\ud8aa膰莲薴螶肸", a_), global::CommonResources.AppResources.Contact_Name, 14);
					this.uclGen_ContactAlias_A00009.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclGen_ContactAlias_A00009.DataTransferOrder = 1;
					num = (short)123731973;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_49:
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					break;
				}
				num = (short)497745924;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BE:
			IL_1E2:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삆ﶎﾒ", a_);
			base.UIName = global::CommonResources.AppResources.General_Id;
			base.Id = 10400;
			base.DataTransferOrder = 10;
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x00234780 File Offset: 0x00232980
		public override void PopulateReferences()
		{
			short num = (short)255918080;
			short num2 = num;
			num = (short)840401931;
			short num3 = num;
			num = (short)384336907;
			switch (num3 == num)
			{
			}
			num = (short)353566721;
			if (num != 0)
			{
			}
			num = (short)1652424704;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x00234828 File Offset: 0x00232A28
		public override void DropReferences()
		{
			short num = (short)889257984;
			short num2 = num;
			num = (short)1212940289;
			if (num != 0)
			{
			}
			num = (short)1540802950;
			short num3 = num;
			num = (short)1244318086;
			switch (num3 == num)
			{
			}
			num = (short)685572096;
			if (num != 0)
			{
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x002348D4 File Offset: 0x00232AD4
		public global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu RefDisplayAndMenu
		{
			get
			{
				short num = (short)1575157760;
				short num2 = num;
				num = (short)2081339430;
				short num3 = num;
				num = (short)818788390;
				switch (num3 == num)
				{
				}
				num = (short)319553537;
				if (num != 0)
				{
				}
				num = (short)1766326272;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu;
			}
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x00234994 File Offset: 0x00232B94
		public override void SetupDependencies()
		{
			short num = (short)1864105984;
			short num2 = num;
			num = (short)1928587313;
			short num3 = num;
			num = (short)266528817;
			switch (num3 == num)
			{
			}
			num = (short)1564147713;
			if (num != 0)
			{
			}
			num = (short)589758464;
			if (num != 0)
			{
			}
			this.RefDisplayAndMenu.Advanced.DispMenuAdvancedLanguageSelection_A8386.AddDependentObject(this.uclGen_ContactAlias_A00009);
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x00234A58 File Offset: 0x00232C58
		public override void SetConstraints()
		{
			short num = (short)649527296;
			short num2 = num;
			num = (short)1162281171;
			short num3 = num;
			num = (short)51052755;
			switch (num3 == num)
			{
			}
			num = (short)355794945;
			if (num != 0)
			{
			}
			num = (short)1598881792;
			if (num != 0)
			{
			}
			this.uclGen_ContactAlias_A00009.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conUCLContactsValidity);
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x00234B18 File Offset: 0x00232D18
		public bool HasDiffs
		{
			get
			{
				short num = (short)494338048;
				short num2 = num;
				num = (short)1829003173;
				short num3 = num;
				num = (short)721969061;
				switch (num3 == num)
				{
				}
				num = (short)63635456;
				if (num != 0)
				{
				}
				num = (short)709820417;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x00234BC8 File Offset: 0x00232DC8
		// (set) Token: 0x06001B5E RID: 7006 RVA: 0x00234C7C File Offset: 0x00232E7C
		public string UclGen_ContactAlias_A00009Value
		{
			get
			{
				short num = (short)390856704;
				short num2 = num;
				num = (short)1643642881;
				if (num != 0)
				{
				}
				num = (short)2025292342;
				short num3 = num;
				num = (short)75530806;
				switch (num3 == num)
				{
				}
				num = (short)1646002176;
				if (num != 0)
				{
				}
				return this.uclGen_ContactAlias_A00009.Value;
			}
			set
			{
				short num = (short)1950482432;
				short num2 = num;
				num = (short)1598456057;
				short num3 = num;
				num = (short)18383097;
				switch (num3 == num)
				{
				}
				num = (short)1729298432;
				if (num != 0)
				{
				}
				num = (short)1239154689;
				if (num != 0)
				{
				}
				this.uclGen_ContactAlias_A00009.Value = value.Trim();
				this.uclGen_ContactAlias_A00009.SetUITimer();
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x00234D40 File Offset: 0x00232F40
		public global::AcpBusinessLayer.AcpKeyField UclGen_ContactAlias_A00009Object
		{
			get
			{
				short num = (short)39256064;
				short num2 = num;
				num = (short)675424990;
				short num3 = num;
				num = (short)1424632542;
				switch (num3 == num)
				{
				}
				num = (short)200933377;
				if (num != 0)
				{
				}
				num = (short)859176960;
				if (num != 0)
				{
				}
				return this.uclGen_ContactAlias_A00009;
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06001B60 RID: 7008 RVA: 0x00234DF0 File Offset: 0x00232FF0
		public bool UclGen_ContactAlias_A00009_HasDiffs
		{
			get
			{
				short num = (short)184745984;
				short num2 = num;
				num = (short)1182435102;
				short num3 = num;
				num = (short)1261340446;
				switch (num3 == num)
				{
				}
				num = (short)2016083969;
				if (num != 0)
				{
				}
				num = (short)1434714112;
				if (num != 0)
				{
				}
				return this.uclGen_ContactAlias_A00009._HasDiffs;
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x00234EA4 File Offset: 0x002330A4
		public string UclGen_ContactAlias_A00009_UILabel
		{
			get
			{
				short num = (short)1331691520;
				short num2 = num;
				num = (short)1317097351;
				short num3 = num;
				num = (short)104419207;
				switch (num3 == num)
				{
				}
				num = (short)2107441153;
				if (num != 0)
				{
				}
				num = (short)622919680;
				if (num != 0)
				{
				}
				return this.uclGen_ContactAlias_A00009.UIName;
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06001B62 RID: 7010 RVA: 0x00234F58 File Offset: 0x00233158
		// (set) Token: 0x06001B63 RID: 7011 RVA: 0x00235010 File Offset: 0x00233210
		public bool UclGen_ContactAlias_A00009_Applicable
		{
			get
			{
				short num = (short)685113344;
				short num2 = num;
				num = (short)1902212022;
				short num3 = num;
				num = (short)1166308278;
				switch (num3 == num)
				{
				}
				num = (short)583467009;
				if (num != 0)
				{
				}
				num = (short)1844051968;
				if (num != 0)
				{
				}
				return this.uclGen_ContactAlias_A00009.Applicable;
			}
			set
			{
				short num = (short)375128064;
				short num2 = num;
				num = (short)1346613959;
				short num3 = num;
				num = (short)1413264071;
				switch (num3 == num)
				{
				}
				num = (short)987627521;
				if (num != 0)
				{
				}
				num = (short)1559887872;
				if (num != 0)
				{
				}
				this.uclGen_ContactAlias_A00009.Applicable = value;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06001B64 RID: 7012 RVA: 0x002350C4 File Offset: 0x002332C4
		// (set) Token: 0x06001B65 RID: 7013 RVA: 0x00235178 File Offset: 0x00233378
		public bool UclGen_ContactAlias_A00009_Editable
		{
			get
			{
				short num = (short)688914432;
				short num2 = num;
				num = (short)881880002;
				short num3 = num;
				num = (short)436956098;
				switch (num3 == num)
				{
				}
				num = (short)878575617;
				if (num != 0)
				{
				}
				num = (short)1768554496;
				if (num != 0)
				{
				}
				return this.uclGen_ContactAlias_A00009.Editable;
			}
			set
			{
				short num = (short)1413087232;
				short num2 = num;
				num = (short)574739864;
				short num3 = num;
				num = (short)152884632;
				switch (num3 == num)
				{
				}
				num = (short)312082433;
				if (num != 0)
				{
				}
				num = (short)246874112;
				if (num != 0)
				{
				}
				this.uclGen_ContactAlias_A00009.Editable = value;
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001B66 RID: 7014 RVA: 0x0023522C File Offset: 0x0023342C
		// (set) Token: 0x06001B67 RID: 7015 RVA: 0x002352E0 File Offset: 0x002334E0
		public bool UclGen_ContactAlias_A00009_Visible
		{
			get
			{
				short num = (short)1251409920;
				short num2 = num;
				num = (short)266121490;
				short num3 = num;
				num = (short)1927983378;
				switch (num3 == num)
				{
				}
				num = (short)1611661312;
				if (num != 0)
				{
				}
				num = (short)782565377;
				if (num != 0)
				{
				}
				return this.uclGen_ContactAlias_A00009.Visible;
			}
			set
			{
				short num = (short)1853947904;
				short num2 = num;
				num = (short)36252785;
				short num3 = num;
				num = (short)2117741681;
				switch (num3 == num)
				{
				}
				num = (short)27131905;
				if (num != 0)
				{
				}
				num = (short)625016832;
				if (num != 0)
				{
				}
				this.uclGen_ContactAlias_A00009.Visible = value;
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001B68 RID: 7016 RVA: 0x00235394 File Offset: 0x00233594
		// (set) Token: 0x06001B69 RID: 7017 RVA: 0x00235448 File Offset: 0x00233648
		internal bool UclGen_ContactAlias_A00009_HiddenStatic
		{
			get
			{
				short num = (short)557056000;
				short num2 = num;
				num = (short)550117161;
				short num3 = num;
				num = (short)366550825;
				switch (num3 == num)
				{
				}
				num = (short)1628176385;
				if (num != 0)
				{
				}
				num = (short)348782592;
				if (num != 0)
				{
				}
				return this.uclGen_ContactAlias_A00009.HiddenStatic;
			}
			set
			{
				short num = (short)1433075712;
				short num2 = num;
				num = (short)507838465;
				if (num != 0)
				{
				}
				num = (short)2017762057;
				short num3 = num;
				num = (short)450140937;
				switch (num3 == num)
				{
				}
				num = (short)1983774720;
				if (num != 0)
				{
				}
				this.uclGen_ContactAlias_A00009.HiddenStatic = value;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x002354FC File Offset: 0x002336FC
		// (set) Token: 0x06001B6B RID: 7019 RVA: 0x002355B0 File Offset: 0x002337B0
		public bool UclGen_ContactAlias_A00009_Valid
		{
			get
			{
				short num = (short)1170014208;
				short num2 = num;
				num = (short)1497628673;
				if (num != 0)
				{
				}
				num = (short)2000906493;
				short num3 = num;
				num = (short)2060216573;
				switch (num3 == num)
				{
				}
				num = (short)1220345856;
				if (num != 0)
				{
				}
				return this.uclGen_ContactAlias_A00009.Valid;
			}
			set
			{
				short num = (short)204210176;
				short num2 = num;
				num = (short)1933699996;
				short num3 = num;
				num = (short)584379292;
				switch (num3 == num)
				{
				}
				num = (short)1577582593;
				if (num != 0)
				{
				}
				num = (short)49348608;
				if (num != 0)
				{
				}
				this.uclGen_ContactAlias_A00009.Valid = value;
			}
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x0000265F File Offset: 0x0000085F
		internal UclContactGeneralSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04000CCE RID: 3278
		private global::AcpBusinessLayer.AcpKeyField uclGen_ContactAlias_A00009;
	}
}
