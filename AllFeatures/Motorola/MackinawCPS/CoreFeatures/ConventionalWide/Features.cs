using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x0200054F RID: 1359
	[global::System.Serializable]
	public class Features : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B545 RID: 46405 RVA: 0x00A80244 File Offset: 0x00A7E444
		public Features(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600B546 RID: 46406 RVA: 0x00A80260 File Offset: 0x00A7E460
		protected Features(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B547 RID: 46407 RVA: 0x00A80278 File Offset: 0x00A7E478
		public override void Init()
		{
			int a_ = 15;
			short num = (short)1855174723;
			short num2 = num;
			num = (short)1194440771;
			switch (num2 == num)
			{
			}
			num = (short)1511063553;
			if (num != 0)
			{
			}
			num = (short)364183552;
			if (num != 0)
			{
			}
			num = (short)1275527168;
			short num3 = num;
			this.cnvWideFeaturesSmartPTTRetryTimerms_A9163 = new global::AcpBusinessLayer.AcpSimpleRangeField(11, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ臕뇗뻙맛飝藟菡郣鏥髧迩鿫뷭鷯鏱蛳苵ꣷ껹ꣻ곽旿瘁瘃缅將按愋欍戏缑朓䤕夗⌙ⴛ⠝ጟ", a_), global::CommonResources.AcgResources.ID_SMARTPTTSMARTPTTRETRYTIMERMS, 0, 200, null, null, 0, 25);
			this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.DataTransferOrder = 15;
			this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.ShowHexValue = false;
			this.cnvWideFeaturesSoftIDFeature_A9168 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ臕뇗뻙맛飝藟菡郣鏥髧迩鿫뷭鿯铱胳뿵볷볹駻鿽瓿省瘃挅圇䬉㔋㼍☏⨑", a_), global::CommonResources.AcgResources.ID_SOFTIDFEATUREENABLE);
			this.cnvWideFeaturesSoftIDFeature_A9168.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvWideFeaturesSoftIDFeature_A9168.DataTransferOrder = 3;
			this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162 = new global::AcpBusinessLayer.AcpRangeField<int, string>(20, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.UnpackFactorAndpackStep100FactorWith25(), this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ臕뇗뻙맛飝藟菡郣鏥髧迩鿫뷭鷯鏱蛳苵ꣷ껹ꣻ꿽痿欁會洅䌇漉甋娍礏缑焓搕甗椙䌛弝᤟ጡሣᐥ", a_), global::CommonResources.AcgResources.ID_SMARTPTTSMARTPTTQUICKKEYTIMERMS, 4, 200, 4);
			this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.DataTransferOrder = 14;
			this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.ShowHexValue = false;
			this.conventionlWideFeaturesStatusNumOfAttempts_42156 = new global::AcpBusinessLayer.AcpCustomRangeField(5, this, global::AllFeatures.CodeplugGuid.b("鏏뷑뫓ꃕ뷗듙꣛럝迟賡裣뇥臧軩觫꣭闯鏱胳菵諷鿹迻귽瓿持瀃猅笇䐉礋挍式琑唓戕気缙焛渝吟儡笣ሥᨧᬩᤫᠭ", a_), global::CommonResources.AcgResources.ID_STATUSNUMBEROFATTEMPTS, 1, 14, 1, null, null);
			this.conventionlWideFeaturesStatusNumOfAttempts_42156.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.conventionlWideFeaturesStatusNumOfAttempts_42156.DataTransferOrder = 25;
			this.conventionlWideFeaturesStatusNumOfAttempts_42156.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("雏럑뗓ꋕ귗꣙맛귝", a_);
			base.Id = 10057;
			base.UIName = global::CommonResources.AcgResources.ID_FEATURES;
			base.DataTransferOrder = 3;
		}

		// Token: 0x0600B548 RID: 46408 RVA: 0x00A80484 File Offset: 0x00A7E684
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)1457520650;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1016332288;
					short num3 = num;
					num = (short)1874794383;
					short num4 = num;
					num = (short)1539643279;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_416;
					default:
						num = (short)1265565696;
						if (num != 0)
						{
						}
						this.conventionlWideFeaturesStatusNumOfAttempts_42156 = new global::AcpBusinessLayer.AcpCustomRangeField(5, this, global::AllFeatures.CodeplugGuid.b("觉ꏋꃍꛏ럑뫓ꋕ뇗뗙닛닝럟诡胣菥껧迩跫髭藯胱釳藵꯷軹鷻諽痿焁䨃猅攇䔉樋伍搏昑焓笕栗渙漛䄝ᐟအᔣጥḧ", a_), global::CommonResources.AcgResources.ID_STATUSNUMBEROFATTEMPTS, null, null);
						this.conventionlWideFeaturesStatusNumOfAttempts_42156.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
						this.conventionlWideFeaturesStatusNumOfAttempts_42156.DataTransferOrder = 25;
						this.conventionlWideFeaturesStatusNumOfAttempts_42156.ShowHexValue = false;
						num = (short)545783820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					this.cnvWideFeaturesSmartPTTRetryTimerms_A9163 = new global::AcpBusinessLayer.AcpSimpleRangeField(11, this, global::AllFeatures.CodeplugGuid.b("觉ꋋ룍蟏믑냓돕黗뿙뷛ꫝ闟郡臣闥믧蟩跫鳭蓯ꋱꃳꋵ꫷鿹裻賽秿嘁洃欅洇砉愋納伏匑ⴓ✕⸗⤙", a_), global::CommonResources.AcgResources.ID_SMARTPTTSMARTPTTRETRYTIMERMS, null, null, 0, 25);
					this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.DataTransferOrder = 15;
					this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.ShowHexValue = false;
					num = (short)1434189837;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觉ꋋ룍蟏믑냓돕黗뿙뷛ꫝ闟郡臣闥믧蟩跫鳭蓯ꋱꃳꋵ꧷迹闻鷽毿䤁愃缅將按愋欍戏缑朓䤕夗⌙ⴛ⠝ሟ", a_)))
					{
						num = (short)520486927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_95;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觉ꋋ룍蟏믑냓돕黗뿙뷛ꫝ闟郡臣闥믧藩諫髭맯뛱닳鏵駷軹觻賽旿崁䔃㼅㤇㰉㐋", a_)))
					{
						num = (short)390856713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10D;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觉ꏋꃍꛏ럑뫓ꋕ뇗뗙닛닝럟诡胣菥껧迩跫髭藯胱釳藵꯷軹鷻諽痿焁䨃猅攇䔉樋伍搏昑焓笕栗渙漛䄝ᐟအᔣጥḧ", a_)))
					{
						num = (short)666828800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2F5;
				case 5:
					num = (short)388759563;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_95;
				case 7:
					if (producerFields != null)
					{
						num = (short)530710533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					num = (short)774111239;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)753532929;
					if (num != 0)
					{
					}
					this.cnvWideFeaturesSoftIDFeature_A9168 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("觉ꋋ룍蟏믑냓돕黗뿙뷛ꫝ闟郡臣闥믧藩諫髭맯뛱닳鏵駷軹觻賽旿崁䔃㼅㤇㰉㐋", a_), global::CommonResources.AcgResources.ID_SOFTIDFEATUREENABLE);
					this.cnvWideFeaturesSoftIDFeature_A9168.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvWideFeaturesSoftIDFeature_A9168.DataTransferOrder = 3;
					num = (short)1368719374;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_72;
					}
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觉ꋋ룍蟏믑냓돕黗뿙뷛ꫝ闟郡臣闥믧蟩跫鳭蓯ꋱꃳꋵ꫷鿹裻賽秿嘁洃欅洇砉愋納伏匑ⴓ✕⸗⤙", a_)))
					{
						num = (short)1045954561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_342;
				case 12:
					goto IL_2F5;
				case 13:
					goto IL_416;
				case 14:
					goto IL_10D;
				case 15:
					this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162 = new global::AcpBusinessLayer.AcpRangeField<int, string>(20, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.UnpackFactorAndpackStep100FactorWith25(), this, global::AllFeatures.CodeplugGuid.b("觉ꋋ룍蟏믑냓돕黗뿙뷛ꫝ闟郡臣闥믧蟩跫鳭蓯ꋱꃳꋵ꧷迹闻鷽毿䤁愃缅將按愋欍戏缑朓䤕夗⌙ⴛ⠝ሟ", a_), global::CommonResources.AcgResources.ID_SMARTPTTSMARTPTTQUICKKEYTIMERMS);
					this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.DataTransferOrder = 14;
					this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.ShowHexValue = false;
					num = (short)182452230;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					return;
				}
				IL_72:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)514392072;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_95:
				num = (short)768868356;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10D:
				num = (short)520224770;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2F5:
				base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("賉꧋꿍꓏ꟑꛓ돕ꯗ", a_);
				base.Id = 10057;
				base.UIName = global::CommonResources.AcgResources.ID_FEATURES;
				base.DataTransferOrder = 3;
				num = (short)243531792;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_342:
				num = (short)922877955;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_416:
				goto IL_342;
			}
		}

		// Token: 0x0600B549 RID: 46409 RVA: 0x00A80900 File Offset: 0x00A7EB00
		public override void PopulateReferences()
		{
			short num = (short)649795510;
			short num2 = num;
			num = (short)1803360182;
			switch (num2 == num)
			{
			}
			num = (short)18612225;
			if (num != 0)
			{
			}
			num = (short)1530331136;
			if (num != 0)
			{
			}
			num = (short)2124873728;
			short num3 = num;
		}

		// Token: 0x0600B54A RID: 46410 RVA: 0x00A809A8 File Offset: 0x00A7EBA8
		public override void DropReferences()
		{
			short num = (short)710875864;
			short num2 = num;
			num = (short)186325720;
			switch (num2 == num)
			{
			}
			num = (short)756744192;
			if (num != 0)
			{
			}
			num = (short)1073938433;
			if (num != 0)
			{
			}
			num = (short)2130509824;
			short num3 = num;
		}

		// Token: 0x0600B54B RID: 46411 RVA: 0x00A80A54 File Offset: 0x00A7EC54
		public override void SetConstraints()
		{
			short num = (short)533697370;
			short num2 = num;
			num = (short)979800922;
			switch (num2 == num)
			{
			}
			num = (short)1590099969;
			if (num != 0)
			{
			}
			num = (short)613416960;
			if (num != 0)
			{
			}
			num = (short)1779040256;
			short num3 = num;
			this.cnvWideFeaturesSoftIDFeature_A9168.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideConstraints.conChangeLengthOfSoftIDUsername);
		}

		// Token: 0x0600B54C RID: 46412 RVA: 0x00A80B14 File Offset: 0x00A7ED14
		public override void SetupDependencies()
		{
			short num = (short)1885258231;
			short num2 = num;
			num = (short)741196279;
			switch (num2 == num)
			{
			}
			num = (short)1872429057;
			if (num != 0)
			{
			}
			num = (short)1786249216;
			if (num != 0)
			{
			}
			num = (short)1849556992;
			short num3 = num;
		}

		// Token: 0x17005AD7 RID: 23255
		// (get) Token: 0x0600B54D RID: 46413 RVA: 0x00A80BBC File Offset: 0x00A7EDBC
		public bool HasDiffs
		{
			get
			{
				short num = (short)690232603;
				short num2 = num;
				num = (short)960306459;
				switch (num2 == num)
				{
				}
				num = (short)415367169;
				if (num != 0)
				{
				}
				num = (short)771817472;
				if (num != 0)
				{
				}
				num = (short)36896768;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17005AD8 RID: 23256
		// (get) Token: 0x0600B54E RID: 46414 RVA: 0x00A80C70 File Offset: 0x00A7EE70
		// (set) Token: 0x0600B54F RID: 46415 RVA: 0x00A80D24 File Offset: 0x00A7EF24
		public int CnvWideFeaturesSmartPTTRetryTimerms_A9163Value
		{
			get
			{
				short num = (short)1003880449;
				if (num != 0)
				{
				}
				num = (short)431961322;
				short num2 = num;
				num = (short)752956650;
				switch (num2 == num)
				{
				}
				num = (short)803274752;
				if (num != 0)
				{
				}
				num = (short)740294656;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.Value;
			}
			set
			{
				short num = (short)1003159553;
				if (num != 0)
				{
				}
				num = (short)1649181368;
				short num2 = num;
				num = (short)688824;
				switch (num2 == num)
				{
				}
				num = (short)1166606336;
				if (num != 0)
				{
				}
				num = (short)1602420736;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.Value = value;
			}
		}

		// Token: 0x17005AD9 RID: 23257
		// (get) Token: 0x0600B550 RID: 46416 RVA: 0x00A80DDC File Offset: 0x00A7EFDC
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvWideFeaturesSmartPTTRetryTimerms_A9163
		{
			get
			{
				short num = (short)1049520382;
				short num2 = num;
				num = (short)2009753854;
				switch (num2 == num)
				{
				}
				num = (short)1760034816;
				if (num != 0)
				{
				}
				num = (short)1564213249;
				if (num != 0)
				{
				}
				num = (short)658046976;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTRetryTimerms_A9163;
			}
		}

		// Token: 0x17005ADA RID: 23258
		// (get) Token: 0x0600B551 RID: 46417 RVA: 0x00A80E88 File Offset: 0x00A7F088
		// (set) Token: 0x0600B552 RID: 46418 RVA: 0x00A80F3C File Offset: 0x00A7F13C
		public string CnvWideFeaturesSmartPTTRetryTimerms_A9163_UIValue
		{
			get
			{
				short num = (short)209821964;
				short num2 = num;
				num = (short)1493410060;
				switch (num2 == num)
				{
				}
				num = (short)956694528;
				if (num != 0)
				{
				}
				num = (short)410124289;
				if (num != 0)
				{
				}
				num = (short)211222528;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.UIValue;
			}
			set
			{
				short num = (short)1791680071;
				short num2 = num;
				num = (short)344776263;
				switch (num2 == num)
				{
				}
				num = (short)1814102017;
				if (num != 0)
				{
				}
				num = (short)22085632;
				if (num != 0)
				{
				}
				num = (short)539623424;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.UIValue = value;
			}
		}

		// Token: 0x17005ADB RID: 23259
		// (get) Token: 0x0600B553 RID: 46419 RVA: 0x00A80FF4 File Offset: 0x00A7F1F4
		// (set) Token: 0x0600B554 RID: 46420 RVA: 0x00A810A8 File Offset: 0x00A7F2A8
		internal int CnvWideFeaturesSmartPTTRetryTimerms_A9163Min
		{
			get
			{
				short num = (short)610990937;
				short num2 = num;
				num = (short)1264515929;
				switch (num2 == num)
				{
				}
				num = (short)1037893632;
				if (num != 0)
				{
				}
				num = (short)61538305;
				if (num != 0)
				{
				}
				num = (short)1801912320;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.Min;
			}
			set
			{
				short num = (short)1055326209;
				if (num != 0)
				{
				}
				num = (short)949608032;
				short num2 = num;
				num = (short)254729824;
				switch (num2 == num)
				{
				}
				num = (short)1288634368;
				if (num != 0)
				{
				}
				num = (short)1322123264;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.Min = value;
			}
		}

		// Token: 0x17005ADC RID: 23260
		// (get) Token: 0x0600B555 RID: 46421 RVA: 0x00A8115C File Offset: 0x00A7F35C
		// (set) Token: 0x0600B556 RID: 46422 RVA: 0x00A81210 File Offset: 0x00A7F410
		internal int CnvWideFeaturesSmartPTTRetryTimerms_A9163Max
		{
			get
			{
				short num = (short)1564338711;
				short num2 = num;
				num = (short)57600535;
				switch (num2 == num)
				{
				}
				num = (short)569114625;
				if (num != 0)
				{
				}
				num = (short)481165312;
				if (num != 0)
				{
				}
				num = (short)422903808;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.Max;
			}
			set
			{
				short num = (short)368212111;
				short num2 = num;
				num = (short)1329494159;
				switch (num2 == num)
				{
				}
				num = (short)1766457345;
				if (num != 0)
				{
				}
				num = (short)371195904;
				if (num != 0)
				{
				}
				num = (short)241041408;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.Max = value;
			}
		}

		// Token: 0x17005ADD RID: 23261
		// (get) Token: 0x0600B557 RID: 46423 RVA: 0x00A812C4 File Offset: 0x00A7F4C4
		// (set) Token: 0x0600B558 RID: 46424 RVA: 0x00A81378 File Offset: 0x00A7F578
		internal int CnvWideFeaturesSmartPTTRetryTimerms_A9163Step
		{
			get
			{
				short num = (short)688710592;
				short num2 = num;
				num = (short)1946739648;
				switch (num2 == num)
				{
				}
				num = (short)454033408;
				if (num != 0)
				{
				}
				num = (short)289472513;
				if (num != 0)
				{
				}
				num = (short)1826029568;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.StepSize;
			}
			set
			{
				short num = (short)31190571;
				short num2 = num;
				num = (short)1207430699;
				switch (num2 == num)
				{
				}
				num = (short)348782593;
				if (num != 0)
				{
				}
				num = (short)1584988160;
				if (num != 0)
				{
				}
				num = (short)295632896;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.StepSize = value;
			}
		}

		// Token: 0x17005ADE RID: 23262
		// (get) Token: 0x0600B559 RID: 46425 RVA: 0x00A8142C File Offset: 0x00A7F62C
		// (set) Token: 0x0600B55A RID: 46426 RVA: 0x00A814E0 File Offset: 0x00A7F6E0
		public bool CnvWideFeaturesSmartPTTRetryTimerms_A9163_Applicable
		{
			get
			{
				short num = (short)1269499874;
				short num2 = num;
				num = (short)137168866;
				switch (num2 == num)
				{
				}
				num = (short)1164115969;
				if (num != 0)
				{
				}
				num = (short)965214208;
				if (num != 0)
				{
				}
				num = (short)2047541248;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.Applicable;
			}
			set
			{
				short num = (short)66859384;
				short num2 = num;
				num = (short)2040279416;
				switch (num2 == num)
				{
				}
				num = (short)371720192;
				if (num != 0)
				{
				}
				num = (short)1927020545;
				if (num != 0)
				{
				}
				num = (short)1523843072;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.Applicable = value;
			}
		}

		// Token: 0x17005ADF RID: 23263
		// (get) Token: 0x0600B55B RID: 46427 RVA: 0x00A81598 File Offset: 0x00A7F798
		// (set) Token: 0x0600B55C RID: 46428 RVA: 0x00A81650 File Offset: 0x00A7F850
		public bool CnvWideFeaturesSmartPTTRetryTimerms_A9163_Valid
		{
			get
			{
				short num = (short)1781278346;
				short num2 = num;
				num = (short)606348938;
				switch (num2 == num)
				{
				}
				num = (short)10551296;
				if (num != 0)
				{
				}
				num = (short)1452605441;
				if (num != 0)
				{
				}
				num = (short)496041984;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.Valid;
			}
			set
			{
				short num = (short)1393011675;
				short num2 = num;
				num = (short)899722203;
				switch (num2 == num)
				{
				}
				num = (short)2090729473;
				if (num != 0)
				{
				}
				num = (short)1368588288;
				if (num != 0)
				{
				}
				num = (short)758120448;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.Valid = value;
			}
		}

		// Token: 0x17005AE0 RID: 23264
		// (get) Token: 0x0600B55D RID: 46429 RVA: 0x00A81704 File Offset: 0x00A7F904
		// (set) Token: 0x0600B55E RID: 46430 RVA: 0x00A817BC File Offset: 0x00A7F9BC
		public bool CnvWideFeaturesSmartPTTRetryTimerms_A9163_Visible
		{
			get
			{
				short num = (short)579333467;
				short num2 = num;
				num = (short)1713499483;
				switch (num2 == num)
				{
				}
				num = (short)585564160;
				if (num != 0)
				{
				}
				num = (short)470745089;
				if (num != 0)
				{
				}
				num = (short)1326120960;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.Visible;
			}
			set
			{
				short num = (short)1660408813;
				short num2 = num;
				num = (short)272618477;
				switch (num2 == num)
				{
				}
				num = (short)1045561344;
				if (num != 0)
				{
				}
				num = (short)1593507841;
				if (num != 0)
				{
				}
				num = (short)1310457856;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.Visible = value;
			}
		}

		// Token: 0x17005AE1 RID: 23265
		// (get) Token: 0x0600B55F RID: 46431 RVA: 0x00A81870 File Offset: 0x00A7FA70
		// (set) Token: 0x0600B560 RID: 46432 RVA: 0x00A81924 File Offset: 0x00A7FB24
		public bool CnvWideFeaturesSmartPTTRetryTimerms_A9163_Editable
		{
			get
			{
				short num = (short)1068431372;
				short num2 = num;
				num = (short)1495070732;
				switch (num2 == num)
				{
				}
				num = (short)910163969;
				if (num != 0)
				{
				}
				num = (short)307298304;
				if (num != 0)
				{
				}
				num = (short)1896611840;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.Editable;
			}
			set
			{
				short num = (short)2099974504;
				short num2 = num;
				num = (short)2068386152;
				switch (num2 == num)
				{
				}
				num = (short)1000800257;
				if (num != 0)
				{
				}
				num = (short)1270349824;
				if (num != 0)
				{
				}
				num = (short)1911160832;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.Editable = value;
			}
		}

		// Token: 0x17005AE2 RID: 23266
		// (get) Token: 0x0600B561 RID: 46433 RVA: 0x00A819D8 File Offset: 0x00A7FBD8
		internal string CnvWideFeaturesSmartPTTRetryTimerms_A9163_UILabel
		{
			get
			{
				short num = (short)1575968612;
				short num2 = num;
				num = (short)1162043236;
				switch (num2 == num)
				{
				}
				num = (short)1526857729;
				if (num != 0)
				{
				}
				num = (short)242614272;
				if (num != 0)
				{
				}
				num = (short)94896128;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.UIName;
			}
		}

		// Token: 0x17005AE3 RID: 23267
		// (get) Token: 0x0600B562 RID: 46434 RVA: 0x00A81A8C File Offset: 0x00A7FC8C
		// (set) Token: 0x0600B563 RID: 46435 RVA: 0x00A81B40 File Offset: 0x00A7FD40
		internal bool CnvWideFeaturesSmartPTTRetryTimerms_A9163_HiddenStatic
		{
			get
			{
				short num = (short)988565671;
				short num2 = num;
				num = (short)788287655;
				switch (num2 == num)
				{
				}
				num = (short)429588481;
				if (num != 0)
				{
				}
				num = (short)542900224;
				if (num != 0)
				{
				}
				num = (short)1915813888;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.HiddenStatic;
			}
			set
			{
				short num = (short)854589441;
				if (num != 0)
				{
				}
				num = (short)1440965550;
				short num2 = num;
				num = (short)238117806;
				switch (num2 == num)
				{
				}
				num = (short)443482112;
				if (num != 0)
				{
				}
				num = (short)1987182592;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.HiddenStatic = value;
			}
		}

		// Token: 0x17005AE4 RID: 23268
		// (get) Token: 0x0600B564 RID: 46436 RVA: 0x00A81BF4 File Offset: 0x00A7FDF4
		// (set) Token: 0x0600B565 RID: 46437 RVA: 0x00A81CA8 File Offset: 0x00A7FEA8
		internal bool CnvWideFeaturesSmartPTTRetryTimerms_A9163_HiddenDynamic
		{
			get
			{
				short num = (short)1736111753;
				short num2 = num;
				num = (short)1840510601;
				switch (num2 == num)
				{
				}
				num = (short)1429209089;
				if (num != 0)
				{
				}
				num = (short)1832255488;
				if (num != 0)
				{
				}
				num = (short)1289224192;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.HiddenDynamic;
			}
			set
			{
				short num = (short)478638894;
				short num2 = num;
				num = (short)373781294;
				switch (num2 == num)
				{
				}
				num = (short)1612709889;
				if (num != 0)
				{
				}
				num = (short)1470038016;
				if (num != 0)
				{
				}
				num = (short)995753984;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTRetryTimerms_A9163.HiddenDynamic = value;
			}
		}

		// Token: 0x17005AE5 RID: 23269
		// (get) Token: 0x0600B566 RID: 46438 RVA: 0x00A81D5C File Offset: 0x00A7FF5C
		public bool CnvWideFeaturesSmartPTTRetryTimerms_A9163_HasDiffs
		{
			get
			{
				short num = (short)1499301302;
				short num2 = num;
				num = (short)170952118;
				switch (num2 == num)
				{
				}
				num = (short)1950089217;
				if (num != 0)
				{
				}
				num = (short)1540227072;
				if (num != 0)
				{
				}
				num = (short)1422065664;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTRetryTimerms_A9163._HasDiffs;
			}
		}

		// Token: 0x17005AE6 RID: 23270
		// (get) Token: 0x0600B567 RID: 46439 RVA: 0x00A81E10 File Offset: 0x00A80010
		// (set) Token: 0x0600B568 RID: 46440 RVA: 0x00A81EC8 File Offset: 0x00A800C8
		public bool CnvWideFeaturesSoftIDFeature_A9168Value
		{
			get
			{
				short num = (short)1001543600;
				short num2 = num;
				num = (short)253843376;
				switch (num2 == num)
				{
				}
				num = (short)2053242880;
				if (num != 0)
				{
				}
				num = (short)717619201;
				if (num != 0)
				{
				}
				num = (short)2146828288;
				short num3 = num;
				return this.cnvWideFeaturesSoftIDFeature_A9168.Value;
			}
			set
			{
				short num = (short)1849037720;
				short num2 = num;
				num = (short)83432344;
				switch (num2 == num)
				{
				}
				num = (short)487325697;
				if (num != 0)
				{
				}
				num = (short)1185218560;
				if (num != 0)
				{
				}
				num = (short)985792512;
				short num3 = num;
				this.cnvWideFeaturesSoftIDFeature_A9168.Value = value;
			}
		}

		// Token: 0x17005AE7 RID: 23271
		// (get) Token: 0x0600B569 RID: 46441 RVA: 0x00A81F84 File Offset: 0x00A80184
		public global::AcpBusinessLayer.AcpField<bool> CnvWideFeaturesSoftIDFeature_A9168
		{
			get
			{
				short num = (short)1488761300;
				short num2 = num;
				num = (short)996585940;
				switch (num2 == num)
				{
				}
				num = (short)1344405505;
				if (num != 0)
				{
				}
				num = (short)2021982208;
				if (num != 0)
				{
				}
				num = (short)1647509504;
				short num3 = num;
				return this.cnvWideFeaturesSoftIDFeature_A9168;
			}
		}

		// Token: 0x17005AE8 RID: 23272
		// (get) Token: 0x0600B56A RID: 46442 RVA: 0x00A82038 File Offset: 0x00A80238
		// (set) Token: 0x0600B56B RID: 46443 RVA: 0x00A820E8 File Offset: 0x00A802E8
		public bool CnvWideFeaturesSoftIDFeature_A9168_UIValue
		{
			get
			{
				short num = (short)61093647;
				short num2 = num;
				num = (short)1530869519;
				switch (num2 == num)
				{
				}
				num = (short)1407909889;
				if (num != 0)
				{
				}
				num = (short)1615527936;
				if (num != 0)
				{
				}
				num = (short)1612382208;
				short num3 = num;
				return this.cnvWideFeaturesSoftIDFeature_A9168.Value;
			}
			set
			{
				short num = (short)763592653;
				short num2 = num;
				num = (short)1728217037;
				switch (num2 == num)
				{
				}
				num = (short)1070268417;
				if (num != 0)
				{
				}
				num = (short)192020480;
				if (num != 0)
				{
				}
				num = (short)1541013504;
				short num3 = num;
				this.cnvWideFeaturesSoftIDFeature_A9168.Value = value;
			}
		}

		// Token: 0x17005AE9 RID: 23273
		// (get) Token: 0x0600B56C RID: 46444 RVA: 0x00A821A0 File Offset: 0x00A803A0
		// (set) Token: 0x0600B56D RID: 46445 RVA: 0x00A82258 File Offset: 0x00A80458
		public bool CnvWideFeaturesSoftIDFeature_A9168_Applicable
		{
			get
			{
				short num = (short)1655373825;
				if (num != 0)
				{
				}
				num = (short)1120737464;
				short num2 = num;
				num = (short)1046747320;
				switch (num2 == num)
				{
				}
				num = (short)843907072;
				if (num != 0)
				{
				}
				num = (short)1289748480;
				short num3 = num;
				return this.cnvWideFeaturesSoftIDFeature_A9168.Applicable;
			}
			set
			{
				short num = (short)752033325;
				short num2 = num;
				num = (short)952639021;
				switch (num2 == num)
				{
				}
				num = (short)1868890112;
				if (num != 0)
				{
				}
				num = (short)434896897;
				if (num != 0)
				{
				}
				num = (short)1685651456;
				short num3 = num;
				this.cnvWideFeaturesSoftIDFeature_A9168.Applicable = value;
			}
		}

		// Token: 0x17005AEA RID: 23274
		// (get) Token: 0x0600B56E RID: 46446 RVA: 0x00A8230C File Offset: 0x00A8050C
		// (set) Token: 0x0600B56F RID: 46447 RVA: 0x00A823C0 File Offset: 0x00A805C0
		public bool CnvWideFeaturesSoftIDFeature_A9168_Valid
		{
			get
			{
				short num = (short)895221761;
				if (num != 0)
				{
				}
				num = (short)1232087540;
				short num2 = num;
				num = (short)969746932;
				switch (num2 == num)
				{
				}
				num = (short)1848442880;
				if (num != 0)
				{
				}
				num = (short)145620992;
				short num3 = num;
				return this.cnvWideFeaturesSoftIDFeature_A9168.Valid;
			}
			set
			{
				short num = (short)1175824586;
				short num2 = num;
				num = (short)757573834;
				switch (num2 == num)
				{
				}
				num = (short)434962433;
				if (num != 0)
				{
				}
				num = (short)60489728;
				if (num != 0)
				{
				}
				num = (short)859242496;
				short num3 = num;
				this.cnvWideFeaturesSoftIDFeature_A9168.Valid = value;
			}
		}

		// Token: 0x17005AEB RID: 23275
		// (get) Token: 0x0600B570 RID: 46448 RVA: 0x00A82474 File Offset: 0x00A80674
		// (set) Token: 0x0600B571 RID: 46449 RVA: 0x00A82528 File Offset: 0x00A80728
		public bool CnvWideFeaturesSoftIDFeature_A9168_Visible
		{
			get
			{
				short num = (short)1854687434;
				short num2 = num;
				num = (short)1482705098;
				switch (num2 == num)
				{
				}
				num = (short)2109014017;
				if (num != 0)
				{
				}
				num = (short)170328064;
				if (num != 0)
				{
				}
				num = (short)229376000;
				short num3 = num;
				return this.cnvWideFeaturesSoftIDFeature_A9168.Visible;
			}
			set
			{
				short num = (short)64187481;
				short num2 = num;
				num = (short)204500057;
				switch (num2 == num)
				{
				}
				num = (short)1360330753;
				if (num != 0)
				{
				}
				num = (short)87949312;
				if (num != 0)
				{
				}
				num = (short)1197473792;
				short num3 = num;
				this.cnvWideFeaturesSoftIDFeature_A9168.Visible = value;
			}
		}

		// Token: 0x17005AEC RID: 23276
		// (get) Token: 0x0600B572 RID: 46450 RVA: 0x00A825DC File Offset: 0x00A807DC
		// (set) Token: 0x0600B573 RID: 46451 RVA: 0x00A82690 File Offset: 0x00A80890
		public bool CnvWideFeaturesSoftIDFeature_A9168_Editable
		{
			get
			{
				short num = (short)1454344801;
				short num2 = num;
				num = (short)1296927329;
				switch (num2 == num)
				{
				}
				num = (short)1028390912;
				if (num != 0)
				{
				}
				num = (short)1152385025;
				if (num != 0)
				{
				}
				num = (short)956497920;
				short num3 = num;
				return this.cnvWideFeaturesSoftIDFeature_A9168.Editable;
			}
			set
			{
				short num = (short)1484903983;
				short num2 = num;
				num = (short)1463408175;
				switch (num2 == num)
				{
				}
				num = (short)1185480705;
				if (num != 0)
				{
				}
				num = (short)1049624576;
				if (num != 0)
				{
				}
				num = (short)2088894464;
				short num3 = num;
				this.cnvWideFeaturesSoftIDFeature_A9168.Editable = value;
			}
		}

		// Token: 0x17005AED RID: 23277
		// (get) Token: 0x0600B574 RID: 46452 RVA: 0x00A82744 File Offset: 0x00A80944
		internal string CnvWideFeaturesSoftIDFeature_A9168_UILabel
		{
			get
			{
				short num = (short)645678974;
				short num2 = num;
				num = (short)1666140030;
				switch (num2 == num)
				{
				}
				num = (short)2023292929;
				if (num != 0)
				{
				}
				num = (short)584843264;
				if (num != 0)
				{
				}
				num = (short)674693120;
				short num3 = num;
				return this.cnvWideFeaturesSoftIDFeature_A9168.UIName;
			}
		}

		// Token: 0x17005AEE RID: 23278
		// (get) Token: 0x0600B575 RID: 46453 RVA: 0x00A827F8 File Offset: 0x00A809F8
		// (set) Token: 0x0600B576 RID: 46454 RVA: 0x00A828AC File Offset: 0x00A80AAC
		internal bool CnvWideFeaturesSoftIDFeature_A9168_HiddenStatic
		{
			get
			{
				short num = (short)856637745;
				short num2 = num;
				num = (short)114114865;
				switch (num2 == num)
				{
				}
				num = (short)750256128;
				if (num != 0)
				{
				}
				num = (short)1381105665;
				if (num != 0)
				{
				}
				num = (short)326696960;
				short num3 = num;
				return this.cnvWideFeaturesSoftIDFeature_A9168.HiddenStatic;
			}
			set
			{
				short num = (short)1695787241;
				short num2 = num;
				num = (short)1007134953;
				switch (num2 == num)
				{
				}
				num = (short)1461649409;
				if (num != 0)
				{
				}
				num = (short)747438080;
				if (num != 0)
				{
				}
				num = (short)1185480704;
				short num3 = num;
				this.cnvWideFeaturesSoftIDFeature_A9168.HiddenStatic = value;
			}
		}

		// Token: 0x17005AEF RID: 23279
		// (get) Token: 0x0600B577 RID: 46455 RVA: 0x00A82960 File Offset: 0x00A80B60
		// (set) Token: 0x0600B578 RID: 46456 RVA: 0x00A82A18 File Offset: 0x00A80C18
		internal bool CnvWideFeaturesSoftIDFeature_A9168_HiddenDynamic
		{
			get
			{
				short num = (short)974417771;
				short num2 = num;
				num = (short)1964863339;
				switch (num2 == num)
				{
				}
				num = (short)352649217;
				if (num != 0)
				{
				}
				num = (short)1886191616;
				if (num != 0)
				{
				}
				num = (short)53018624;
				short num3 = num;
				return this.cnvWideFeaturesSoftIDFeature_A9168.HiddenDynamic;
			}
			set
			{
				short num = (short)929955841;
				if (num != 0)
				{
				}
				num = (short)2144056293;
				short num2 = num;
				num = (short)479048677;
				switch (num2 == num)
				{
				}
				num = (short)18087936;
				if (num != 0)
				{
				}
				num = (short)1187446784;
				short num3 = num;
				this.cnvWideFeaturesSoftIDFeature_A9168.HiddenDynamic = value;
			}
		}

		// Token: 0x17005AF0 RID: 23280
		// (get) Token: 0x0600B579 RID: 46457 RVA: 0x00A82ACC File Offset: 0x00A80CCC
		public bool CnvWideFeaturesSoftIDFeature_A9168_HasDiffs
		{
			get
			{
				short num = (short)1067054345;
				short num2 = num;
				num = (short)1989145865;
				switch (num2 == num)
				{
				}
				num = (short)148045825;
				if (num != 0)
				{
				}
				num = (short)1485438976;
				if (num != 0)
				{
				}
				num = (short)981663744;
				short num3 = num;
				return this.cnvWideFeaturesSoftIDFeature_A9168._HasDiffs;
			}
		}

		// Token: 0x17005AF1 RID: 23281
		// (get) Token: 0x0600B57A RID: 46458 RVA: 0x00A82B80 File Offset: 0x00A80D80
		// (set) Token: 0x0600B57B RID: 46459 RVA: 0x00A82C34 File Offset: 0x00A80E34
		public int CnvWideFeaturesSmartPTTQuickKeyTimerms_A9162Value
		{
			get
			{
				short num = (short)1330169377;
				short num2 = num;
				num = (short)1836434977;
				switch (num2 == num)
				{
				}
				num = (short)723451905;
				if (num != 0)
				{
				}
				num = (short)1568145408;
				if (num != 0)
				{
				}
				num = (short)2084438016;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.Value;
			}
			set
			{
				short num = (short)91597084;
				short num2 = num;
				num = (short)428714268;
				switch (num2 == num)
				{
				}
				num = (short)2141978625;
				if (num != 0)
				{
				}
				num = (short)217317376;
				if (num != 0)
				{
				}
				num = (short)566624256;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.Value = value;
			}
		}

		// Token: 0x17005AF2 RID: 23282
		// (get) Token: 0x0600B57C RID: 46460 RVA: 0x00A82CE8 File Offset: 0x00A80EE8
		public global::AcpBusinessLayer.AcpRangeField<int, string> CnvWideFeaturesSmartPTTQuickKeyTimerms_A9162
		{
			get
			{
				short num = (short)647468843;
				short num2 = num;
				num = (short)1797494571;
				switch (num2 == num)
				{
				}
				num = (short)1139212289;
				if (num != 0)
				{
				}
				num = (short)69271552;
				if (num != 0)
				{
				}
				num = (short)926482432;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162;
			}
		}

		// Token: 0x17005AF3 RID: 23283
		// (get) Token: 0x0600B57D RID: 46461 RVA: 0x00A82D98 File Offset: 0x00A80F98
		// (set) Token: 0x0600B57E RID: 46462 RVA: 0x00A82E50 File Offset: 0x00A81050
		public string CnvWideFeaturesSmartPTTQuickKeyTimerms_A9162_UIValue
		{
			get
			{
				short num = (short)1710588447;
				short num2 = num;
				num = (short)1895334431;
				switch (num2 == num)
				{
				}
				num = (short)1541472257;
				if (num != 0)
				{
				}
				num = (short)556204032;
				if (num != 0)
				{
				}
				num = (short)1829634048;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.UIValue;
			}
			set
			{
				short num = (short)2145258600;
				short num2 = num;
				num = (short)4787304;
				switch (num2 == num)
				{
				}
				num = (short)932315136;
				if (num != 0)
				{
				}
				num = (short)1172373505;
				if (num != 0)
				{
				}
				num = (short)814153728;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.UIValue = value;
			}
		}

		// Token: 0x17005AF4 RID: 23284
		// (get) Token: 0x0600B57F RID: 46463 RVA: 0x00A82F04 File Offset: 0x00A81104
		// (set) Token: 0x0600B580 RID: 46464 RVA: 0x00A82FB8 File Offset: 0x00A811B8
		internal int CnvWideFeaturesSmartPTTQuickKeyTimerms_A9162Min
		{
			get
			{
				short num = (short)196553267;
				short num2 = num;
				num = (short)1865099827;
				switch (num2 == num)
				{
				}
				num = (short)578551808;
				if (num != 0)
				{
				}
				num = (short)648740865;
				if (num != 0)
				{
				}
				num = (short)688193536;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.Min;
			}
			set
			{
				short num = (short)1407927240;
				short num2 = num;
				num = (short)1255228360;
				switch (num2 == num)
				{
				}
				num = (short)732233728;
				if (num != 0)
				{
				}
				num = (short)1027342337;
				if (num != 0)
				{
				}
				num = (short)1331494912;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.Min = value;
			}
		}

		// Token: 0x17005AF5 RID: 23285
		// (get) Token: 0x0600B581 RID: 46465 RVA: 0x00A83070 File Offset: 0x00A81270
		// (set) Token: 0x0600B582 RID: 46466 RVA: 0x00A83120 File Offset: 0x00A81320
		internal int CnvWideFeaturesSmartPTTQuickKeyTimerms_A9162Max
		{
			get
			{
				short num = (short)2003182284;
				short num2 = num;
				num = (short)379921100;
				switch (num2 == num)
				{
				}
				num = (short)2036400129;
				if (num != 0)
				{
				}
				num = (short)2036662272;
				if (num != 0)
				{
				}
				num = (short)65536000;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.Max;
			}
			set
			{
				short num = (short)108462081;
				if (num != 0)
				{
				}
				num = (short)1863549425;
				short num2 = num;
				num = (short)359170545;
				switch (num2 == num)
				{
				}
				num = (short)1566703616;
				if (num != 0)
				{
				}
				num = (short)653590528;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.Max = value;
			}
		}

		// Token: 0x17005AF6 RID: 23286
		// (get) Token: 0x0600B583 RID: 46467 RVA: 0x00A831D4 File Offset: 0x00A813D4
		// (set) Token: 0x0600B584 RID: 46468 RVA: 0x00A8328C File Offset: 0x00A8148C
		internal int CnvWideFeaturesSmartPTTQuickKeyTimerms_A9162Step
		{
			get
			{
				short num = (short)1508860563;
				short num2 = num;
				num = (short)672162451;
				switch (num2 == num)
				{
				}
				num = (short)1465974784;
				if (num != 0)
				{
				}
				num = (short)1102774273;
				if (num != 0)
				{
				}
				num = (short)1416232960;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.StepSize;
			}
			set
			{
				short num = (short)1592577139;
				short num2 = num;
				num = (short)181193843;
				switch (num2 == num)
				{
				}
				num = (short)1750597632;
				if (num != 0)
				{
				}
				num = (short)595918849;
				if (num != 0)
				{
				}
				num = (short)1024524288;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.StepSize = value;
			}
		}

		// Token: 0x17005AF7 RID: 23287
		// (get) Token: 0x0600B585 RID: 46469 RVA: 0x00A83340 File Offset: 0x00A81540
		// (set) Token: 0x0600B586 RID: 46470 RVA: 0x00A833F4 File Offset: 0x00A815F4
		public bool CnvWideFeaturesSmartPTTQuickKeyTimerms_A9162_Applicable
		{
			get
			{
				short num = (short)641978684;
				short num2 = num;
				num = (short)1797509436;
				switch (num2 == num)
				{
				}
				num = (short)1095106560;
				if (num != 0)
				{
				}
				num = (short)1808138241;
				if (num != 0)
				{
				}
				num = (short)1737687040;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.Applicable;
			}
			set
			{
				short num = (short)634031150;
				short num2 = num;
				num = (short)1548782638;
				switch (num2 == num)
				{
				}
				num = (short)1061158913;
				if (num != 0)
				{
				}
				num = (short)448659456;
				if (num != 0)
				{
				}
				num = (short)865730560;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.Applicable = value;
			}
		}

		// Token: 0x17005AF8 RID: 23288
		// (get) Token: 0x0600B587 RID: 46471 RVA: 0x00A834A8 File Offset: 0x00A816A8
		// (set) Token: 0x0600B588 RID: 46472 RVA: 0x00A8355C File Offset: 0x00A8175C
		public bool CnvWideFeaturesSmartPTTQuickKeyTimerms_A9162_Valid
		{
			get
			{
				short num = (short)315946448;
				short num2 = num;
				num = (short)1555363280;
				switch (num2 == num)
				{
				}
				num = (short)748814337;
				if (num != 0)
				{
				}
				num = (short)1152385024;
				if (num != 0)
				{
				}
				num = (short)1188954112;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.Valid;
			}
			set
			{
				short num = (short)1470634837;
				short num2 = num;
				num = (short)835263317;
				switch (num2 == num)
				{
				}
				num = (short)733085697;
				if (num != 0)
				{
				}
				num = (short)711262208;
				if (num != 0)
				{
				}
				num = (short)527630336;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.Valid = value;
			}
		}

		// Token: 0x17005AF9 RID: 23289
		// (get) Token: 0x0600B589 RID: 46473 RVA: 0x00A83610 File Offset: 0x00A81810
		// (set) Token: 0x0600B58A RID: 46474 RVA: 0x00A836C8 File Offset: 0x00A818C8
		public bool CnvWideFeaturesSmartPTTQuickKeyTimerms_A9162_Visible
		{
			get
			{
				short num = (short)518293143;
				short num2 = num;
				num = (short)2073921175;
				switch (num2 == num)
				{
				}
				num = (short)299499520;
				if (num != 0)
				{
				}
				num = (short)1920270337;
				if (num != 0)
				{
				}
				num = (short)2050162688;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.Visible;
			}
			set
			{
				short num = (short)1517479872;
				short num2 = num;
				num = (short)2070865856;
				switch (num2 == num)
				{
				}
				num = (short)1408237569;
				if (num != 0)
				{
				}
				num = (short)2077622272;
				if (num != 0)
				{
				}
				num = (short)16515072;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.Visible = value;
			}
		}

		// Token: 0x17005AFA RID: 23290
		// (get) Token: 0x0600B58B RID: 46475 RVA: 0x00A83780 File Offset: 0x00A81980
		// (set) Token: 0x0600B58C RID: 46476 RVA: 0x00A83838 File Offset: 0x00A81A38
		public bool CnvWideFeaturesSmartPTTQuickKeyTimerms_A9162_Editable
		{
			get
			{
				short num = (short)1732127884;
				short num2 = num;
				num = (short)534457484;
				switch (num2 == num)
				{
				}
				num = (short)490864641;
				if (num != 0)
				{
				}
				num = (short)1343684608;
				if (num != 0)
				{
				}
				num = (short)1684865024;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.Editable;
			}
			set
			{
				short num = (short)980529928;
				short num2 = num;
				num = (short)1441968904;
				switch (num2 == num)
				{
				}
				num = (short)1950547969;
				if (num != 0)
				{
				}
				num = (short)2020671488;
				if (num != 0)
				{
				}
				num = (short)95551488;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.Editable = value;
			}
		}

		// Token: 0x17005AFB RID: 23291
		// (get) Token: 0x0600B58D RID: 46477 RVA: 0x00A838EC File Offset: 0x00A81AEC
		internal string CnvWideFeaturesSmartPTTQuickKeyTimerms_A9162_UILabel
		{
			get
			{
				short num = (short)114948290;
				short num2 = num;
				num = (short)497154242;
				switch (num2 == num)
				{
				}
				num = (short)1884946433;
				if (num != 0)
				{
				}
				num = (short)2061762560;
				if (num != 0)
				{
				}
				num = (short)1285488640;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.UIName;
			}
		}

		// Token: 0x17005AFC RID: 23292
		// (get) Token: 0x0600B58E RID: 46478 RVA: 0x00A839A0 File Offset: 0x00A81BA0
		// (set) Token: 0x0600B58F RID: 46479 RVA: 0x00A83A58 File Offset: 0x00A81C58
		internal bool CnvWideFeaturesSmartPTTQuickKeyTimerms_A9162_HiddenStatic
		{
			get
			{
				short num = (short)1825819399;
				short num2 = num;
				num = (short)57985799;
				switch (num2 == num)
				{
				}
				num = (short)656736256;
				if (num != 0)
				{
				}
				num = (short)1920139265;
				if (num != 0)
				{
				}
				num = (short)631635968;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.HiddenStatic;
			}
			set
			{
				short num = (short)1554632701;
				short num2 = num;
				num = (short)686870525;
				switch (num2 == num)
				{
				}
				num = (short)2081554433;
				if (num != 0)
				{
				}
				num = (short)1985216512;
				if (num != 0)
				{
				}
				num = (short)106299392;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.HiddenStatic = value;
			}
		}

		// Token: 0x17005AFD RID: 23293
		// (get) Token: 0x0600B590 RID: 46480 RVA: 0x00A83B0C File Offset: 0x00A81D0C
		// (set) Token: 0x0600B591 RID: 46481 RVA: 0x00A83BC0 File Offset: 0x00A81DC0
		internal bool CnvWideFeaturesSmartPTTQuickKeyTimerms_A9162_HiddenDynamic
		{
			get
			{
				short num = (short)2058608110;
				short num2 = num;
				num = (short)648666606;
				switch (num2 == num)
				{
				}
				num = (short)1899495425;
				if (num != 0)
				{
				}
				num = (short)675414016;
				if (num != 0)
				{
				}
				num = (short)1561067520;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.HiddenDynamic;
			}
			set
			{
				short num = (short)1085769901;
				short num2 = num;
				num = (short)421234861;
				switch (num2 == num)
				{
				}
				num = (short)315817985;
				if (num != 0)
				{
				}
				num = (short)1907163136;
				if (num != 0)
				{
				}
				num = (short)938016768;
				short num3 = num;
				this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162.HiddenDynamic = value;
			}
		}

		// Token: 0x17005AFE RID: 23294
		// (get) Token: 0x0600B592 RID: 46482 RVA: 0x00A83C74 File Offset: 0x00A81E74
		public bool CnvWideFeaturesSmartPTTQuickKeyTimerms_A9162_HasDiffs
		{
			get
			{
				short num = (short)822009279;
				short num2 = num;
				num = (short)956292543;
				switch (num2 == num)
				{
				}
				num = (short)133562369;
				if (num != 0)
				{
				}
				num = (short)2042101760;
				if (num != 0)
				{
				}
				num = (short)170393600;
				short num3 = num;
				return this.cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162._HasDiffs;
			}
		}

		// Token: 0x17005AFF RID: 23295
		// (get) Token: 0x0600B593 RID: 46483 RVA: 0x00A83D28 File Offset: 0x00A81F28
		// (set) Token: 0x0600B594 RID: 46484 RVA: 0x00A83DE0 File Offset: 0x00A81FE0
		public int ConventionlWideFeaturesStatusNumOfAttempts_42156Value
		{
			get
			{
				short num = (short)299908994;
				short num2 = num;
				num = (short)1618952066;
				switch (num2 == num)
				{
				}
				num = (short)1460797440;
				if (num != 0)
				{
				}
				num = (short)1399717889;
				if (num != 0)
				{
				}
				num = (short)812646400;
				short num3 = num;
				return this.conventionlWideFeaturesStatusNumOfAttempts_42156.Value;
			}
			set
			{
				short num = (short)96796673;
				if (num != 0)
				{
				}
				num = (short)1270833914;
				short num2 = num;
				num = (short)1089102586;
				switch (num2 == num)
				{
				}
				num = (short)1144913920;
				if (num != 0)
				{
				}
				num = (short)1965293568;
				short num3 = num;
				this.conventionlWideFeaturesStatusNumOfAttempts_42156.Value = value;
			}
		}

		// Token: 0x17005B00 RID: 23296
		// (get) Token: 0x0600B595 RID: 46485 RVA: 0x00A83E98 File Offset: 0x00A82098
		public global::AcpBusinessLayer.AcpCustomRangeField ConventionlWideFeaturesStatusNumOfAttempts_42156
		{
			get
			{
				short num = (short)1903885758;
				short num2 = num;
				num = (short)1051590078;
				switch (num2 == num)
				{
				}
				num = (short)1695744001;
				if (num != 0)
				{
				}
				num = (short)2026242048;
				if (num != 0)
				{
				}
				num = (short)2100559872;
				short num3 = num;
				return this.conventionlWideFeaturesStatusNumOfAttempts_42156;
			}
		}

		// Token: 0x17005B01 RID: 23297
		// (get) Token: 0x0600B596 RID: 46486 RVA: 0x00A83F48 File Offset: 0x00A82148
		// (set) Token: 0x0600B597 RID: 46487 RVA: 0x00A83FFC File Offset: 0x00A821FC
		public string ConventionlWideFeaturesStatusNumOfAttempts_42156_UIValue
		{
			get
			{
				short num = (short)209584129;
				if (num != 0)
				{
				}
				num = (short)1402646669;
				short num2 = num;
				num = (short)1137094797;
				switch (num2 == num)
				{
				}
				num = (short)1544486912;
				if (num != 0)
				{
				}
				num = (short)1413283840;
				short num3 = num;
				return this.conventionlWideFeaturesStatusNumOfAttempts_42156.UIValue;
			}
			set
			{
				short num = (short)170250294;
				short num2 = num;
				num = (short)1983893558;
				switch (num2 == num)
				{
				}
				num = (short)656539649;
				if (num != 0)
				{
				}
				num = (short)2053308416;
				if (num != 0)
				{
				}
				num = (short)87228416;
				short num3 = num;
				this.conventionlWideFeaturesStatusNumOfAttempts_42156.UIValue = value;
			}
		}

		// Token: 0x17005B02 RID: 23298
		// (get) Token: 0x0600B598 RID: 46488 RVA: 0x00A840B4 File Offset: 0x00A822B4
		// (set) Token: 0x0600B599 RID: 46489 RVA: 0x00A84168 File Offset: 0x00A82368
		internal int ConventionlWideFeaturesStatusNumOfAttempts_42156Min
		{
			get
			{
				short num = (short)338998906;
				short num2 = num;
				num = (short)623752826;
				switch (num2 == num)
				{
				}
				num = (short)808189953;
				if (num != 0)
				{
				}
				num = (short)372310016;
				if (num != 0)
				{
				}
				num = (short)1804402688;
				short num3 = num;
				return this.conventionlWideFeaturesStatusNumOfAttempts_42156.Min;
			}
			set
			{
				short num = (short)997843259;
				short num2 = num;
				num = (short)361161019;
				switch (num2 == num)
				{
				}
				num = (short)310181888;
				short num3 = num;
				num = (short)1628372993;
				if (num != 0)
				{
				}
				num = (short)836698112;
				if (num != 0)
				{
				}
				this.conventionlWideFeaturesStatusNumOfAttempts_42156.Min = value;
			}
		}

		// Token: 0x17005B03 RID: 23299
		// (get) Token: 0x0600B59A RID: 46490 RVA: 0x00A84220 File Offset: 0x00A82420
		// (set) Token: 0x0600B59B RID: 46491 RVA: 0x00A842D8 File Offset: 0x00A824D8
		internal int ConventionlWideFeaturesStatusNumOfAttempts_42156Max
		{
			get
			{
				short num = (short)1565831112;
				short num2 = num;
				num = (short)1191358408;
				switch (num2 == num)
				{
				}
				num = (short)1737752576;
				short num3 = num;
				num = (short)848101376;
				if (num != 0)
				{
				}
				num = (short)1407320065;
				if (num != 0)
				{
				}
				return this.conventionlWideFeaturesStatusNumOfAttempts_42156.Max;
			}
			set
			{
				short num = (short)1659568129;
				if (num != 0)
				{
				}
				num = (short)1966408064;
				short num2 = num;
				num = (short)3080576;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1434976256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)250478592;
				if (num != 0)
				{
				}
				this.conventionlWideFeaturesStatusNumOfAttempts_42156.Max = value;
			}
		}

		// Token: 0x17005B04 RID: 23300
		// (get) Token: 0x0600B59C RID: 46492 RVA: 0x00A84390 File Offset: 0x00A82590
		// (set) Token: 0x0600B59D RID: 46493 RVA: 0x00A84448 File Offset: 0x00A82648
		internal int ConventionlWideFeaturesStatusNumOfAttempts_42156Step
		{
			get
			{
				short num = (short)408857868;
				short num2 = num;
				num = (short)685944076;
				switch (num2 == num)
				{
				}
				num = (short)1829044224;
				short num3 = num;
				num = (short)714604544;
				if (num != 0)
				{
				}
				num = (short)1916534785;
				if (num != 0)
				{
				}
				return this.conventionlWideFeaturesStatusNumOfAttempts_42156.StepSize;
			}
			set
			{
				short num = (short)741203097;
				short num2 = num;
				num = (short)699653273;
				switch (num2 == num)
				{
				}
				num = (short)918487040;
				short num3 = num;
				num = (short)642908161;
				if (num != 0)
				{
				}
				num = (short)1867841536;
				if (num != 0)
				{
				}
				this.conventionlWideFeaturesStatusNumOfAttempts_42156.StepSize = value;
			}
		}

		// Token: 0x17005B05 RID: 23301
		// (get) Token: 0x0600B59E RID: 46494 RVA: 0x00A84500 File Offset: 0x00A82700
		// (set) Token: 0x0600B59F RID: 46495 RVA: 0x00A845B4 File Offset: 0x00A827B4
		public bool ConventionlWideFeaturesStatusNumOfAttempts_42156_Applicable
		{
			get
			{
				short num = (short)1816838276;
				short num2 = num;
				num = (short)670417028;
				switch (num2 == num)
				{
				}
				num = (short)33619968;
				short num3 = num;
				num = (short)745340929;
				if (num != 0)
				{
				}
				num = (short)6422528;
				if (num != 0)
				{
				}
				return this.conventionlWideFeaturesStatusNumOfAttempts_42156.Applicable;
			}
			set
			{
				short num = (short)2044760441;
				short num2 = num;
				num = (short)506827129;
				switch (num2 == num)
				{
				}
				num = (short)1001914368;
				short num3 = num;
				num = (short)372572161;
				if (num != 0)
				{
				}
				num = (short)288948224;
				if (num != 0)
				{
				}
				this.conventionlWideFeaturesStatusNumOfAttempts_42156.Applicable = value;
			}
		}

		// Token: 0x17005B06 RID: 23302
		// (get) Token: 0x0600B5A0 RID: 46496 RVA: 0x00A84668 File Offset: 0x00A82868
		// (set) Token: 0x0600B5A1 RID: 46497 RVA: 0x00A8471C File Offset: 0x00A8291C
		public bool ConventionlWideFeaturesStatusNumOfAttempts_42156_Valid
		{
			get
			{
				short num = (short)1307092332;
				short num2 = num;
				num = (short)1546036588;
				switch (num2 == num)
				{
				}
				num = (short)613351424;
				short num3 = num;
				num = (short)1298202625;
				if (num != 0)
				{
				}
				num = (short)973078528;
				if (num != 0)
				{
				}
				return this.conventionlWideFeaturesStatusNumOfAttempts_42156.Valid;
			}
			set
			{
				short num = (short)1090653403;
				short num2 = num;
				num = (short)1492323547;
				switch (num2 == num)
				{
				}
				num = (short)1176633344;
				short num3 = num;
				num = (short)1315700737;
				if (num != 0)
				{
				}
				num = (short)1329987584;
				if (num != 0)
				{
				}
				this.conventionlWideFeaturesStatusNumOfAttempts_42156.Valid = value;
			}
		}

		// Token: 0x17005B07 RID: 23303
		// (get) Token: 0x0600B5A2 RID: 46498 RVA: 0x00A847D0 File Offset: 0x00A829D0
		// (set) Token: 0x0600B5A3 RID: 46499 RVA: 0x00A84884 File Offset: 0x00A82A84
		public bool ConventionlWideFeaturesStatusNumOfAttempts_42156_Visible
		{
			get
			{
				short num = (short)1694317573;
				short num2 = num;
				num = (short)1830304773;
				switch (num2 == num)
				{
				}
				num = (short)1345191936;
				short num3 = num;
				num = (short)2116747264;
				if (num != 0)
				{
				}
				num = (short)244842497;
				if (num != 0)
				{
				}
				return this.conventionlWideFeaturesStatusNumOfAttempts_42156.Visible;
			}
			set
			{
				short num = (short)1839068652;
				short num2 = num;
				num = (short)1507325420;
				switch (num2 == num)
				{
				}
				num = (short)1426128896;
				short num3 = num;
				num = (short)559742977;
				if (num != 0)
				{
				}
				num = (short)1606418432;
				if (num != 0)
				{
				}
				this.conventionlWideFeaturesStatusNumOfAttempts_42156.Visible = value;
			}
		}

		// Token: 0x17005B08 RID: 23304
		// (get) Token: 0x0600B5A4 RID: 46500 RVA: 0x00A84938 File Offset: 0x00A82B38
		// (set) Token: 0x0600B5A5 RID: 46501 RVA: 0x00A849EC File Offset: 0x00A82BEC
		public bool ConventionlWideFeaturesStatusNumOfAttempts_42156_Editable
		{
			get
			{
				short num = (short)629447739;
				short num2 = num;
				num = (short)1865718843;
				switch (num2 == num)
				{
				}
				num = (short)1178075136;
				short num3 = num;
				num = (short)1367212033;
				if (num != 0)
				{
				}
				num = (short)1869611008;
				if (num != 0)
				{
				}
				return this.conventionlWideFeaturesStatusNumOfAttempts_42156.Editable;
			}
			set
			{
				short num = (short)183224160;
				short num2 = num;
				num = (short)710330208;
				switch (num2 == num)
				{
				}
				num = (short)1963589632;
				short num3 = num;
				num = (short)1588068353;
				if (num != 0)
				{
				}
				num = (short)145620992;
				if (num != 0)
				{
				}
				this.conventionlWideFeaturesStatusNumOfAttempts_42156.Editable = value;
			}
		}

		// Token: 0x17005B09 RID: 23305
		// (get) Token: 0x0600B5A6 RID: 46502 RVA: 0x00A84AA4 File Offset: 0x00A82CA4
		internal string ConventionlWideFeaturesStatusNumOfAttempts_42156_UILabel
		{
			get
			{
				short num = (short)1974393942;
				short num2 = num;
				num = (short)1731058774;
				switch (num2 == num)
				{
				}
				num = (short)1025179648;
				short num3 = num;
				num = (short)1371406337;
				if (num != 0)
				{
				}
				num = (short)607256576;
				if (num != 0)
				{
				}
				return this.conventionlWideFeaturesStatusNumOfAttempts_42156.UIName;
			}
		}

		// Token: 0x17005B0A RID: 23306
		// (get) Token: 0x0600B5A7 RID: 46503 RVA: 0x00A84B5C File Offset: 0x00A82D5C
		// (set) Token: 0x0600B5A8 RID: 46504 RVA: 0x00A84C10 File Offset: 0x00A82E10
		internal bool ConventionlWideFeaturesStatusNumOfAttempts_42156_HiddenStatic
		{
			get
			{
				short num = (short)207910798;
				short num2 = num;
				num = (short)1799452558;
				switch (num2 == num)
				{
				}
				num = (short)1145438208;
				short num3 = num;
				num = (short)1156055041;
				if (num != 0)
				{
				}
				num = (short)1604911104;
				if (num != 0)
				{
				}
				return this.conventionlWideFeaturesStatusNumOfAttempts_42156.HiddenStatic;
			}
			set
			{
				short num = (short)1797840938;
				short num2 = num;
				num = (short)93249578;
				switch (num2 == num)
				{
				}
				num = (short)1253769216;
				short num3 = num;
				num = (short)783482880;
				if (num != 0)
				{
				}
				num = (short)1209663489;
				if (num != 0)
				{
				}
				this.conventionlWideFeaturesStatusNumOfAttempts_42156.HiddenStatic = value;
			}
		}

		// Token: 0x17005B0B RID: 23307
		// (get) Token: 0x0600B5A9 RID: 46505 RVA: 0x00A84CC4 File Offset: 0x00A82EC4
		// (set) Token: 0x0600B5AA RID: 46506 RVA: 0x00A84D78 File Offset: 0x00A82F78
		internal bool ConventionlWideFeaturesStatusNumOfAttempts_42156_HiddenDynamic
		{
			get
			{
				short num = (short)1424790673;
				short num2 = num;
				num = (short)1941542033;
				switch (num2 == num)
				{
				}
				num = (short)193265664;
				short num3 = num;
				num = (short)1921712129;
				if (num != 0)
				{
				}
				num = (short)977862656;
				if (num != 0)
				{
				}
				return this.conventionlWideFeaturesStatusNumOfAttempts_42156.HiddenDynamic;
			}
			set
			{
				short num = (short)208124633;
				short num2 = num;
				num = (short)311212761;
				switch (num2 == num)
				{
				}
				num = (short)1149698048;
				short num3 = num;
				num = (short)253558784;
				if (num != 0)
				{
				}
				num = (short)888078337;
				if (num != 0)
				{
				}
				this.conventionlWideFeaturesStatusNumOfAttempts_42156.HiddenDynamic = value;
			}
		}

		// Token: 0x17005B0C RID: 23308
		// (get) Token: 0x0600B5AB RID: 46507 RVA: 0x00A84E30 File Offset: 0x00A83030
		public bool ConventionlWideFeaturesStatusNumOfAttempts_42156_HasDiffs
		{
			get
			{
				short num = (short)1923662055;
				short num2 = num;
				num = (short)822001895;
				switch (num2 == num)
				{
				}
				num = (short)708706304;
				short num3 = num;
				num = (short)1441202177;
				if (num != 0)
				{
				}
				num = (short)1213857792;
				if (num != 0)
				{
				}
				return this.conventionlWideFeaturesStatusNumOfAttempts_42156._HasDiffs;
			}
		}

		// Token: 0x0600B5AC RID: 46508 RVA: 0x00A84EE4 File Offset: 0x00A830E4
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
					return result;
				case 1:
				{
					num2 = (short)207618048;
					short num3 = num2;
					num2 = (short)1527994737;
					short num4 = num2;
					num2 = (short)2015058289;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13C;
					default:
						num2 = (short)2138832896;
						if (num2 != 0)
						{
						}
						num2 = (short)2013593601;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset != null)
						{
							num2 = (short)583729155;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 2:
					goto IL_13C;
				case 3:
					num2 = (short)1989607426;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)29687808;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_13C:
				if (base.ParentRecset.ContainerDoc == null)
				{
					break;
				}
				num2 = (short)590086148;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)224985089;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040058B0 RID: 22704
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvWideFeaturesSmartPTTRetryTimerms_A9163;

		// Token: 0x040058B1 RID: 22705
		private global::AcpBusinessLayer.AcpField<bool> cnvWideFeaturesSoftIDFeature_A9168;

		// Token: 0x040058B2 RID: 22706
		private global::AcpBusinessLayer.AcpRangeField<int, string> cnvWideFeaturesSmartPTTQuickKeyTimerms_A9162;

		// Token: 0x040058B3 RID: 22707
		private global::AcpBusinessLayer.AcpCustomRangeField conventionlWideFeaturesStatusNumOfAttempts_42156;
	}
}
