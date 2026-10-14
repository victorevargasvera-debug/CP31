using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x020000A5 RID: 165
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class UpgradeTemplateByFeaturesEventArgs : global::System.EventArgs
	{
		// Token: 0x060009F2 RID: 2546 RVA: 0x000753A4 File Offset: 0x000735A4
		public UpgradeTemplateByFeaturesEventArgs(global::Motorola.CommonCPS.Server.EntityModel.Template template, string sourceCFS, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> radioFeatures)
		{
			this.SourceTemplate = template;
			this.SourceCFS = sourceCFS;
			this.RadioFeatures = radioFeatures;
			this.Result = global::Motorola.Common.CustomException.CommonErrorCode.None;
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x000753D4 File Offset: 0x000735D4
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x00075480 File Offset: 0x00073680
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Template SourceTemplate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1908758092;
				short num2 = num;
				num = (short)64771660;
				switch (num2 == num)
				{
				}
				num = (short)1861484544;
				short num3 = num;
				num = (short)1583218689;
				if (num != 0)
				{
				}
				num = (short)1235484672;
				if (num != 0)
				{
				}
				return this.<SourceTemplate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1959629654;
				short num2 = num;
				num = (short)1930400598;
				switch (num2 == num)
				{
				}
				num = (short)2108096512;
				short num3 = num;
				num = (short)851705856;
				if (num != 0)
				{
				}
				num = (short)823394305;
				if (num != 0)
				{
				}
				this.<SourceTemplate>k__BackingField = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x00075530 File Offset: 0x00073730
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x000755E0 File Offset: 0x000737E0
		[global::System.Runtime.Serialization.DataMember]
		public string SourceCFS
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1989230606;
				short num2 = num;
				num = (short)164118542;
				switch (num2 == num)
				{
				}
				num = (short)1438384128;
				short num3 = num;
				num = (short)648609793;
				if (num != 0)
				{
				}
				num = (short)913833984;
				if (num != 0)
				{
				}
				return this.<SourceCFS>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1913582302;
				short num2 = num;
				num = (short)533983966;
				switch (num2 == num)
				{
				}
				num = (short)1505886208;
				short num3 = num;
				num = (short)255197185;
				if (num != 0)
				{
				}
				num = (short)1306656768;
				if (num != 0)
				{
				}
				this.<SourceCFS>k__BackingField = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x00075694 File Offset: 0x00073894
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x00075740 File Offset: 0x00073940
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> RadioFeatures
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)302350688;
				short num2 = num;
				num = (short)1297711456;
				switch (num2 == num)
				{
				}
				num = (short)238747648;
				short num3 = num;
				num = (short)1328218113;
				if (num != 0)
				{
				}
				num = (short)1588264960;
				if (num != 0)
				{
				}
				return this.<RadioFeatures>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1828161396;
				short num2 = num;
				num = (short)1537574772;
				switch (num2 == num)
				{
				}
				num = (short)167182336;
				short num3 = num;
				num = (short)878903297;
				if (num != 0)
				{
				}
				num = (short)893583360;
				if (num != 0)
				{
				}
				this.<RadioFeatures>k__BackingField = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x000757F0 File Offset: 0x000739F0
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x0007589C File Offset: 0x00073A9C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.CustomException.CommonErrorCode Result
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1438030175;
				short num2 = num;
				num = (short)655530335;
				switch (num2 == num)
				{
				}
				num = (short)1296367616;
				short num3 = num;
				num = (short)1937309697;
				if (num != 0)
				{
				}
				num = (short)36175872;
				if (num != 0)
				{
				}
				return this.<Result>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1221681943;
				short num2 = num;
				num = (short)573793047;
				switch (num2 == num)
				{
				}
				num = (short)1915355136;
				short num3 = num;
				num = (short)1019150336;
				if (num != 0)
				{
				}
				num = (short)809369601;
				if (num != 0)
				{
				}
				this.<Result>k__BackingField = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x00075948 File Offset: 0x00073B48
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x000759F8 File Offset: 0x00073BF8
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Template UpgradedTemplate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)167582700;
				short num2 = num;
				num = (short)1325931500;
				switch (num2 == num)
				{
				}
				num = (short)296484864;
				short num3 = num;
				num = (short)761462785;
				if (num != 0)
				{
				}
				num = (short)1673789440;
				if (num != 0)
				{
				}
				return this.<UpgradedTemplate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1908025621;
				short num2 = num;
				num = (short)1337272597;
				switch (num2 == num)
				{
				}
				num = (short)447283200;
				short num3 = num;
				num = (short)1191706624;
				if (num != 0)
				{
				}
				num = (short)199884801;
				if (num != 0)
				{
				}
				this.<UpgradedTemplate>k__BackingField = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x00075AA8 File Offset: 0x00073CA8
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x00075B5C File Offset: 0x00073D5C
		[global::System.Runtime.Serialization.DataMember]
		public bool NeedUpgradeFirmware
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1022561772;
				short num2 = num;
				num = (short)966921708;
				switch (num2 == num)
				{
				}
				num = (short)1074397184;
				short num3 = num;
				num = (short)540540929;
				if (num != 0)
				{
				}
				num = (short)1744830464;
				if (num != 0)
				{
				}
				return this.<NeedUpgradeFirmware>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)548374089;
				short num2 = num;
				num = (short)916620873;
				switch (num2 == num)
				{
				}
				num = (short)1503330304;
				short num3 = num;
				num = (short)583270400;
				if (num != 0)
				{
				}
				num = (short)796196865;
				if (num != 0)
				{
				}
				this.<NeedUpgradeFirmware>k__BackingField = value;
			}
		}
	}
}
