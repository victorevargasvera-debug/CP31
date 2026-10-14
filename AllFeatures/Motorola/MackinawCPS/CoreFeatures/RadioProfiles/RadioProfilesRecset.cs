using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.RadioProfiles
{
	// Token: 0x02000216 RID: 534
	[global::System.Serializable]
	public class RadioProfilesRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600602E RID: 24622 RVA: 0x00567B20 File Offset: 0x00565D20
		public RadioProfilesRecset() : base(global::CommonResources.AcgResources.ID_RADIOPROFILES, global::CommonResources.AcgResources.ID_PROFILE)
		{
			this.SetValues();
		}

		// Token: 0x0600602F RID: 24623 RVA: 0x00567B44 File Offset: 0x00565D44
		public RadioProfilesRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170031DF RID: 12767
		// (get) Token: 0x06006030 RID: 24624 RVA: 0x00567B70 File Offset: 0x00565D70
		public override int MaxPool
		{
			get
			{
				short num = (short)1151689115;
				short num2 = num;
				num = (short)1802264987;
				switch (num2 == num)
				{
				}
				num = (short)234553345;
				if (num != 0)
				{
				}
				num = (short)1515454464;
				short num3 = num;
				num = (short)950599680;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset._MaxPool;
			}
		}

		// Token: 0x170031E0 RID: 12768
		// (get) Token: 0x06006031 RID: 24625 RVA: 0x00567C1C File Offset: 0x00565E1C
		// (set) Token: 0x06006032 RID: 24626 RVA: 0x00567CE0 File Offset: 0x00565EE0
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num;
					for (;;)
					{
						num = (short)1439315879;
						short num2 = num;
						num = (short)1538865063;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_43;
						}
					}
					IL_43:
					num = (short)2146172928;
					short num3 = num;
					num = (short)1097203712;
					if (num != 0)
					{
					}
					num = (short)1027342337;
					if (num != 0)
					{
					}
					return global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset._Max;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)211357090;
				short num2 = num;
				num = (short)1380584866;
				switch (num2 == num)
				{
				}
				num = (short)391118849;
				if (num != 0)
				{
				}
				num = (short)363724800;
				short num3 = num;
				num = (short)998637568;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170031E1 RID: 12769
		// (get) Token: 0x06006033 RID: 24627 RVA: 0x00567D90 File Offset: 0x00565F90
		public bool HasDiffs
		{
			get
			{
				short num = (short)1859159113;
				short num2 = num;
				num = (short)827950153;
				switch (num2 == num)
				{
				}
				num = (short)1683816449;
				if (num != 0)
				{
				}
				num = (short)1320026112;
				short num3 = num;
				num = (short)767229952;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170031E2 RID: 12770
		// (get) Token: 0x06006034 RID: 24628 RVA: 0x00567E40 File Offset: 0x00566040
		// (set) Token: 0x06006035 RID: 24629 RVA: 0x00567EF0 File Offset: 0x005660F0
		public override int Min
		{
			get
			{
				short num = (short)1749896055;
				short num2 = num;
				num = (short)367872887;
				switch (num2 == num)
				{
				}
				num = (short)485031936;
				if (num != 0)
				{
				}
				num = (short)1220608000;
				short num3 = num;
				num = (short)1823014913;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset._Min;
			}
			set
			{
				short num = (short)722707418;
				short num2 = num;
				num = (short)878486490;
				switch (num2 == num)
				{
				}
				num = (short)1778909184;
				if (num != 0)
				{
				}
				num = (short)368902144;
				short num3 = num;
				num = (short)330891265;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset._Min = value;
			}
		}

		// Token: 0x06006036 RID: 24630 RVA: 0x00567FA0 File Offset: 0x005661A0
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)794382190;
			short num2 = num;
			num = (short)1490767726;
			switch (num2 == num)
			{
			}
			num = (short)1777467393;
			if (num != 0)
			{
			}
			num = (short)995098624;
			short num3 = num;
			num = (short)1809514496;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles(this);
		}

		// Token: 0x06006037 RID: 24631 RVA: 0x00568050 File Offset: 0x00566250
		internal void SetValues()
		{
			int a_ = 0;
			short num = (short)58938757;
			short num2 = num;
			num = (short)313480581;
			switch (num2 == num)
			{
			}
			num = (short)449773568;
			if (num != 0)
			{
			}
			num = (short)1114439680;
			short num3 = num;
			num = (short)1012662273;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 2077;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("胀꿂꧄臆곈꫊만뫎ꏐ뛒ꛔ高듚냜꿞軠跢胤触鷨럪뿬軮闰髲髴ퟶ본觺髼郾漀氂栄渆樈砊ⴌ䰎縐紒猔縖縘渚漜縞唠䨢䨤䤦用礪䰬䬮堰尲ᔴ朶䬸吺嬼嘾ⵀ♂㙄ᭆᭈ⩊⥌♎㹐͒❔㡖㽘㉚ㅜ㩞በ㝢ݤ୦䝨፪౬ɮᵰ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RADIOPROFILES;
			base.KeySeed = global::CommonResources.AcgResources.ID_PROFILE;
			base.DataTransferOrder = 26;
		}

		// Token: 0x06006038 RID: 24632 RVA: 0x00568150 File Offset: 0x00566350
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1932635612;
			short num2 = num;
			num = (short)924167644;
			switch (num2 == num)
			{
			}
			num = (short)271253504;
			if (num != 0)
			{
			}
			num = (short)1039859712;
			short num3 = num;
			num = (short)1563361281;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord(record);
			this.b(record);
			this.c(record);
		}

		// Token: 0x06006039 RID: 24633 RVA: 0x00568210 File Offset: 0x00566410
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)609199827;
			short num2 = num;
			num = (short)2142480083;
			switch (num2 == num)
			{
			}
			num = (short)1870462976;
			if (num != 0)
			{
			}
			num = (short)980418560;
			short num3 = num;
			num = (short)260243457;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord(record);
			this.a(record);
			this.c(record);
		}

		// Token: 0x0600603A RID: 24634 RVA: 0x005682CC File Offset: 0x005664CC
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)2081144889;
			short num2 = num;
			num = (short)184467513;
			switch (num2 == num)
			{
			}
			num = (short)2128084993;
			if (num != 0)
			{
			}
			num = (short)720502784;
			short num3 = num;
			num = (short)922353664;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600603B RID: 24635 RVA: 0x00568374 File Offset: 0x00566574
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)151692676;
			short num2 = num;
			num = (short)758752644;
			switch (num2 == num)
			{
			}
			num = (short)1347223553;
			if (num != 0)
			{
			}
			num = (short)183500800;
			short num3 = num;
			num = (short)317784064;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600603C RID: 24636 RVA: 0x00568424 File Offset: 0x00566624
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1400091077;
			short num2 = num;
			num = (short)1973006789;
			switch (num2 == num)
			{
			}
			num = (short)122093569;
			if (num != 0)
			{
			}
			num = (short)1776746496;
			short num3 = num;
			num = (short)1517223936;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600603D RID: 24637 RVA: 0x005684D4 File Offset: 0x005666D4
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (radioWideRecset.Count > 0)
					{
						num2 = (short)230424577;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					(radioWideRecset[0][10101] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DigitalAudioOptions).RadWideLabtoolDigitalAnalogBalance_A7851.CalculateValidity();
					num2 = (short)806486018;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return;
				case 3:
					for (;;)
					{
						num2 = (short)1826583723;
						short num3 = num2;
						num2 = (short)1511748779;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_107;
						}
					}
					IL_107:
					num2 = (short)1791426561;
					if (num2 != 0)
					{
					}
					num2 = (short)1437728768;
					if (num2 != 0)
					{
					}
					num2 = (short)672595968;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (radioWideRecset != null)
					{
						num2 = (short)1427243011;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_24;
			}
			return;
			IL_24:
			num2 = (short)714539008;
			short num4 = num2;
			radioWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset);
			num2 = (short)1158348804;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600603E RID: 24638 RVA: 0x00568668 File Offset: 0x00566868
		// Note: this type is marked as 'beforefieldinit'.
		static RadioProfilesRecset()
		{
			short num = (short)986371973;
			short num2 = num;
			num = (short)317249413;
			switch (num2 == num)
			{
			}
			num = (short)1469251585;
			if (num != 0)
			{
			}
			num = (short)312999936;
			short num3 = num;
			num = (short)286261248;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset._Min = 1;
		}

		// Token: 0x040025FA RID: 9722
		public static int _MaxPool;

		// Token: 0x040025FB RID: 9723
		public static int _Max;

		// Token: 0x040025FC RID: 9724
		public int _DynMax;

		// Token: 0x040025FD RID: 9725
		public static int _Min;
	}
}
