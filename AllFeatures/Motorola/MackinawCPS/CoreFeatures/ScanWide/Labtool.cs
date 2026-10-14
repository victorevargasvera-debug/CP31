using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ScanWide
{
	// Token: 0x0200010B RID: 267
	[global::System.Serializable]
	public class Labtool : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06002747 RID: 10055 RVA: 0x0026318C File Offset: 0x0026138C
		public Labtool(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x002631A8 File Offset: 0x002613A8
		protected Labtool(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x002631C0 File Offset: 0x002613C0
		public override void Init()
		{
			int a_ = 4;
			short num = (short)863961088;
			short num2 = num;
			num = (short)235864065;
			if (num != 0)
			{
			}
			num = (short)678844782;
			short num3 = num;
			num = (short)1664309614;
			switch (num3 == num)
			{
			}
			num = (short)544997376;
			if (num != 0)
			{
			}
			this.scanWideLabtoolLookbackTime_A8454 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("雄꓆꣈ꗊ髌ꛎ뗐뛒駔뛖믘꿚닜냞跠꿢諤裦苨觪賬賮髰ꟲ鳴髶鳸ꓺ볼쟾㔀㘂㄄", a_), global::CommonResources.AcgResources.ID_LOOKBACKTIMEMS, 0, 255, null, null, 0, 1);
			this.scanWideLabtoolLookbackTime_A8454.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.scanWideLabtoolLookbackTime_A8454.DataTransferOrder = -1;
			this.scanWideLabtoolLookbackTime_A8454.ShowHexValue = false;
			this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048 = new global::AcpBusinessLayer.AcpSimpleRangeField(6, this, global::AllFeatures.CodeplugGuid.b("雄꓆꣈ꗊ髌ꛎ뗐뛒駔뛖믘꿚닜냞跠냢蛤蛦蟨꿪裬鯮铰郲致ꏶ郸雺飼맾渀焂䘄昆笈礊搌樎挐䀒搔或簘眚縜眞縠戢ᰤᜦᴨጪ", a_), global::CommonResources.AcgResources.ID_SCANDETECTTIMEFORCARRIERSQUELCHMS, 0, 255, null, null, 0, 25);
			this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.DataTransferOrder = -1;
			this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.ShowHexValue = false;
			this.scanWideLabtoolScanDetectTimeForPL_A9049 = new global::AcpBusinessLayer.AcpSimpleRangeField(12, this, global::AllFeatures.CodeplugGuid.b("雄꓆꣈ꗊ髌ꛎ뗐뛒駔뛖믘꿚닜냞跠냢蛤蛦蟨꿪裬鯮铰郲致ꏶ郸雺飼맾渀焂唄䬆嘈䨊㐌㼎┐⨒", a_), global::CommonResources.AcgResources.ID_SCANDETECTTIMEFORPLMS, 0, 255, null, null, 0, 25);
			this.scanWideLabtoolScanDetectTimeForPL_A9049.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.scanWideLabtoolScanDetectTimeForPL_A9049.DataTransferOrder = -1;
			this.scanWideLabtoolScanDetectTimeForPL_A9049.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("规ꛆꯈ뿊ꋌꃎ뷐", a_);
			base.Id = 10047;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 4;
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x00263390 File Offset: 0x00261590
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			for (;;)
			{
				IL_09:
				short num = (short)1298792453;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_112;
					case 1:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雄꓆꣈ꗊ髌ꛎ뗐뛒駔뛖믘꿚닜냞跠꿢諤裦苨觪賬賮髰ꟲ鳴髶鳸ꓺ볼쟾㔀㘂㄄", a_)))
						{
							num = (short)1945501706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_112;
					case 2:
					{
						num = (short)857835710;
						short num3 = num;
						num = (short)742033598;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
							num = (short)2063335424;
							if (num != 0)
							{
							}
							num = (short)1645215750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雄꓆꣈ꗊ髌ꛎ뗐뛒駔뛖믘꿚닜냞跠냢蛤蛦蟨꿪裬鯮铰郲致ꏶ郸雺飼맾渀焂䘄昆笈礊搌樎挐䀒搔或簘眚縜眞縠戢ᰤᜦᴨጪ", a_)))
						{
							num = (short)1729953796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C6;
					case 4:
					{
						num = (short)351600640;
						short num4 = num;
						this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048 = new global::AcpBusinessLayer.AcpSimpleRangeField(6, this, global::AllFeatures.CodeplugGuid.b("雄꓆꣈ꗊ髌ꛎ뗐뛒駔뛖믘꿚닜냞跠냢蛤蛦蟨꿪裬鯮铰郲致ꏶ郸雺飼맾渀焂䘄昆笈礊搌樎挐䀒搔或簘眚縜眞縠戢ᰤᜦᴨጪ", a_), global::CommonResources.AcgResources.ID_SCANDETECTTIMEFORCARRIERSQUELCHMS, null, null, 0, 25);
						this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.DataTransferOrder = -1;
						this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.ShowHexValue = false;
						num = (short)1075707905;
						if (num != 0)
						{
						}
						num = (short)320667655;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					case 6:
						if (producerFields != null)
						{
							num = (short)345899019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_379;
					case 7:
						goto IL_2C6;
					case 8:
						this.scanWideLabtoolScanDetectTimeForPL_A9049 = new global::AcpBusinessLayer.AcpSimpleRangeField(12, this, global::AllFeatures.CodeplugGuid.b("雄꓆꣈ꗊ髌ꛎ뗐뛒駔뛖믘꿚닜냞跠냢蛤蛦蟨꿪裬鯮铰郲致ꏶ郸雺飼맾渀焂唄䬆嘈䨊㐌㼎┐⨒", a_), global::CommonResources.AcgResources.ID_SCANDETECTTIMEFORPLMS, null, null, 0, 25);
						this.scanWideLabtoolScanDetectTimeForPL_A9049.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.scanWideLabtoolScanDetectTimeForPL_A9049.DataTransferOrder = -1;
						this.scanWideLabtoolScanDetectTimeForPL_A9049.ShowHexValue = false;
						num = (short)905576460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雄꓆꣈ꗊ髌ꛎ뗐뛒駔뛖믘꿚닜냞跠냢蛤蛦蟨꿪裬鯮铰郲致ꏶ郸雺飼맾渀焂唄䬆嘈䨊㐌㼎┐⨒", a_)))
						{
							num = (short)1373110280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_379;
					case 10:
						this.scanWideLabtoolLookbackTime_A8454 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("雄꓆꣈ꗊ髌ꛎ뗐뛒駔뛖믘꿚닜냞跠꿢諤裦苨觪賬賮髰ꟲ鳴髶鳸ꓺ볼쟾㔀㘂㄄", a_), global::CommonResources.AcgResources.ID_LOOKBACKTIMEMS, null, null, 0, 1);
						this.scanWideLabtoolLookbackTime_A8454.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.scanWideLabtoolLookbackTime_A8454.DataTransferOrder = -1;
						this.scanWideLabtoolLookbackTime_A8454.ShowHexValue = false;
						num = (short)1043070976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)1688272897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_23B;
					}
					IL_62:
					if (global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						num = (short)465502210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_379;
					IL_112:
					num = (short)821886979;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C6:
					num = (short)900726793;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_23B:
			IL_379:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("规ꛆꯈ뿊ꋌꃎ뷐", a_);
			base.Id = 10047;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 4;
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x00263748 File Offset: 0x00261948
		public override void PopulateReferences()
		{
			short num = (short)530686035;
			short num2 = num;
			num = (short)2073731155;
			switch (num2 == num)
			{
			}
			num = (short)875757569;
			if (num != 0)
			{
			}
			num = (short)1753350144;
			short num3 = num;
			num = (short)1475936256;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x002637F4 File Offset: 0x002619F4
		public override void DropReferences()
		{
			short num = (short)1459589058;
			short num2 = num;
			num = (short)2094567362;
			switch (num2 == num)
			{
			}
			num = (short)1743650817;
			if (num != 0)
			{
			}
			num = (short)2228224;
			short num3 = num;
			num = (short)865665024;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x0026389C File Offset: 0x00261A9C
		public override void SetConstraints()
		{
			short num = (short)1878219801;
			short num2 = num;
			num = (short)1179278361;
			switch (num2 == num)
			{
			}
			num = (short)1520304128;
			if (num != 0)
			{
			}
			num = (short)1198784512;
			short num3 = num;
			num = (short)312541185;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x00263948 File Offset: 0x00261B48
		public override void SetupDependencies()
		{
			short num = (short)1412276986;
			short num2 = num;
			num = (short)466592506;
			switch (num2 == num)
			{
			}
			num = (short)1026424833;
			if (num != 0)
			{
			}
			num = (short)1690894336;
			short num3 = num;
			num = (short)1884946432;
			if (num != 0)
			{
			}
		}

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x0600274F RID: 10063 RVA: 0x002639F4 File Offset: 0x00261BF4
		public bool HasDiffs
		{
			get
			{
				short num = (short)267941163;
				short num2 = num;
				num = (short)47871275;
				switch (num2 == num)
				{
				}
				num = (short)767688705;
				if (num != 0)
				{
				}
				num = (short)1906049024;
				short num3 = num;
				num = (short)800260096;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x06002750 RID: 10064 RVA: 0x00263AA4 File Offset: 0x00261CA4
		// (set) Token: 0x06002751 RID: 10065 RVA: 0x00263B58 File Offset: 0x00261D58
		public int ScanWideLabtoolLookbackTime_A8454Value
		{
			get
			{
				short num = (short)1109502201;
				short num2 = num;
				num = (short)1132439801;
				switch (num2 == num)
				{
				}
				num = (short)921239553;
				if (num != 0)
				{
				}
				num = (short)1013972992;
				short num3 = num;
				num = (short)134348800;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolLookbackTime_A8454.Value;
			}
			set
			{
				short num = (short)994554955;
				short num2 = num;
				num = (short)486913099;
				switch (num2 == num)
				{
				}
				num = (short)602472448;
				if (num != 0)
				{
				}
				num = (short)1347682304;
				short num3 = num;
				num = (short)262864897;
				if (num != 0)
				{
				}
				this.scanWideLabtoolLookbackTime_A8454.Value = value;
			}
		}

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x06002752 RID: 10066 RVA: 0x00263C0C File Offset: 0x00261E0C
		public global::AcpBusinessLayer.AcpSimpleRangeField ScanWideLabtoolLookbackTime_A8454
		{
			get
			{
				short num = (short)287959139;
				short num2 = num;
				num = (short)308602979;
				switch (num2 == num)
				{
				}
				num = (short)1146290177;
				if (num != 0)
				{
				}
				num = (short)1316880384;
				short num3 = num;
				num = (short)2005598208;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolLookbackTime_A8454;
			}
		}

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x06002753 RID: 10067 RVA: 0x00263CBC File Offset: 0x00261EBC
		// (set) Token: 0x06002754 RID: 10068 RVA: 0x00263D70 File Offset: 0x00261F70
		public string ScanWideLabtoolLookbackTime_A8454_UIValue
		{
			get
			{
				short num = (short)961913635;
				short num2 = num;
				num = (short)231908131;
				switch (num2 == num)
				{
				}
				num = (short)337772545;
				if (num != 0)
				{
				}
				num = (short)818413568;
				short num3 = num;
				num = (short)10682368;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolLookbackTime_A8454.UIValue;
			}
			set
			{
				short num = (short)58261505;
				if (num != 0)
				{
				}
				num = (short)1960155544;
				short num2 = num;
				num = (short)1071946136;
				switch (num2 == num)
				{
				}
				num = (short)1388576768;
				short num3 = num;
				num = (short)1332477952;
				if (num != 0)
				{
				}
				this.scanWideLabtoolLookbackTime_A8454.UIValue = value;
			}
		}

		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x06002755 RID: 10069 RVA: 0x00263E28 File Offset: 0x00262028
		// (set) Token: 0x06002756 RID: 10070 RVA: 0x00263EDC File Offset: 0x002620DC
		internal int ScanWideLabtoolLookbackTime_A8454Min
		{
			get
			{
				short num = (short)598346725;
				short num2 = num;
				num = (short)930483173;
				switch (num2 == num)
				{
				}
				num = (short)10944513;
				if (num != 0)
				{
				}
				num = (short)1397227520;
				short num3 = num;
				num = (short)1789984768;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolLookbackTime_A8454.Min;
			}
			set
			{
				short num = (short)1633393987;
				short num2 = num;
				num = (short)1511300419;
				switch (num2 == num)
				{
				}
				num = (short)452722688;
				if (num != 0)
				{
				}
				num = (short)234815488;
				short num3 = num;
				num = (short)915603457;
				if (num != 0)
				{
				}
				this.scanWideLabtoolLookbackTime_A8454.Min = value;
			}
		}

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x06002757 RID: 10071 RVA: 0x00263F94 File Offset: 0x00262194
		// (set) Token: 0x06002758 RID: 10072 RVA: 0x00264048 File Offset: 0x00262248
		internal int ScanWideLabtoolLookbackTime_A8454Max
		{
			get
			{
				short num = (short)1073089410;
				short num2 = num;
				num = (short)1068174210;
				switch (num2 == num)
				{
				}
				num = (short)190316545;
				if (num != 0)
				{
				}
				num = (short)793706496;
				short num3 = num;
				num = (short)1163919360;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolLookbackTime_A8454.Max;
			}
			set
			{
				short num = (short)975242534;
				short num2 = num;
				num = (short)1561658662;
				switch (num2 == num)
				{
				}
				num = (short)1370685441;
				if (num != 0)
				{
				}
				num = (short)1040646144;
				short num3 = num;
				num = (short)302710784;
				if (num != 0)
				{
				}
				this.scanWideLabtoolLookbackTime_A8454.Max = value;
			}
		}

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x06002759 RID: 10073 RVA: 0x002640FC File Offset: 0x002622FC
		// (set) Token: 0x0600275A RID: 10074 RVA: 0x002641B0 File Offset: 0x002623B0
		internal int ScanWideLabtoolLookbackTime_A8454Step
		{
			get
			{
				short num = (short)2065832343;
				short num2 = num;
				num = (short)801315223;
				switch (num2 == num)
				{
				}
				num = (short)681115648;
				if (num != 0)
				{
				}
				num = (short)1808662528;
				short num3 = num;
				num = (short)13303809;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolLookbackTime_A8454.StepSize;
			}
			set
			{
				short num = (short)260753459;
				short num2 = num;
				num = (short)1373685811;
				switch (num2 == num)
				{
				}
				num = (short)502136833;
				if (num != 0)
				{
				}
				num = (short)87883776;
				short num3 = num;
				num = (short)1148125184;
				if (num != 0)
				{
				}
				this.scanWideLabtoolLookbackTime_A8454.StepSize = value;
			}
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x0600275B RID: 10075 RVA: 0x00264264 File Offset: 0x00262464
		// (set) Token: 0x0600275C RID: 10076 RVA: 0x0026431C File Offset: 0x0026251C
		public bool ScanWideLabtoolLookbackTime_A8454_Applicable
		{
			get
			{
				short num = (short)704948347;
				short num2 = num;
				num = (short)303933563;
				switch (num2 == num)
				{
				}
				num = (short)1139539969;
				if (num != 0)
				{
				}
				num = (short)1495924736;
				short num3 = num;
				num = (short)1900281856;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolLookbackTime_A8454.Applicable;
			}
			set
			{
				short num = (short)1523406450;
				short num2 = num;
				num = (short)1467897458;
				switch (num2 == num)
				{
				}
				num = (short)304349185;
				if (num != 0)
				{
				}
				num = (short)2113994752;
				short num3 = num;
				num = (short)1359872000;
				if (num != 0)
				{
				}
				this.scanWideLabtoolLookbackTime_A8454.Applicable = value;
			}
		}

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x0600275D RID: 10077 RVA: 0x002643D0 File Offset: 0x002625D0
		// (set) Token: 0x0600275E RID: 10078 RVA: 0x00264484 File Offset: 0x00262684
		public bool ScanWideLabtoolLookbackTime_A8454_Valid
		{
			get
			{
				short num = (short)1049862652;
				short num2 = num;
				num = (short)888775164;
				switch (num2 == num)
				{
				}
				num = (short)1159004160;
				if (num != 0)
				{
				}
				num = (short)171442176;
				short num3 = num;
				num = (short)1230766081;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolLookbackTime_A8454.Valid;
			}
			set
			{
				short num = (short)147265942;
				short num2 = num;
				num = (short)1764825494;
				switch (num2 == num)
				{
				}
				num = (short)981401601;
				if (num != 0)
				{
				}
				num = (short)974651392;
				short num3 = num;
				num = (short)688848896;
				if (num != 0)
				{
				}
				this.scanWideLabtoolLookbackTime_A8454.Valid = value;
			}
		}

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x0026453C File Offset: 0x0026273C
		// (set) Token: 0x06002760 RID: 10080 RVA: 0x002645F0 File Offset: 0x002627F0
		public bool ScanWideLabtoolLookbackTime_A8454_Visible
		{
			get
			{
				short num = (short)600554036;
				short num2 = num;
				num = (short)481147444;
				switch (num2 == num)
				{
				}
				num = (short)568590336;
				if (num != 0)
				{
				}
				num = (short)421199872;
				short num3 = num;
				num = (short)1518665729;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolLookbackTime_A8454.Visible;
			}
			set
			{
				short num = (short)2046425138;
				short num2 = num;
				num = (short)1519384626;
				switch (num2 == num)
				{
				}
				num = (short)48496641;
				if (num != 0)
				{
				}
				num = (short)1318518784;
				short num3 = num;
				num = (short)1505624064;
				if (num != 0)
				{
				}
				this.scanWideLabtoolLookbackTime_A8454.Visible = value;
			}
		}

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x06002761 RID: 10081 RVA: 0x002646A8 File Offset: 0x002628A8
		// (set) Token: 0x06002762 RID: 10082 RVA: 0x0026475C File Offset: 0x0026295C
		public bool ScanWideLabtoolLookbackTime_A8454_Editable
		{
			get
			{
				short num = (short)747633373;
				short num2 = num;
				num = (short)715324125;
				switch (num2 == num)
				{
				}
				num = (short)436469761;
				if (num != 0)
				{
				}
				num = (short)1378615296;
				short num3 = num;
				num = (short)81461248;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolLookbackTime_A8454.Editable;
			}
			set
			{
				short num = (short)405254589;
				short num2 = num;
				num = (short)1740026301;
				switch (num2 == num)
				{
				}
				num = (short)1314521089;
				if (num != 0)
				{
				}
				num = (short)1665204224;
				short num3 = num;
				num = (short)853147648;
				if (num != 0)
				{
				}
				this.scanWideLabtoolLookbackTime_A8454.Editable = value;
			}
		}

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x06002763 RID: 10083 RVA: 0x00264814 File Offset: 0x00262A14
		internal string ScanWideLabtoolLookbackTime_A8454_UILabel
		{
			get
			{
				short num = (short)1409087861;
				short num2 = num;
				num = (short)952039797;
				switch (num2 == num)
				{
				}
				num = (short)30605312;
				if (num != 0)
				{
				}
				num = (short)1851785216;
				short num3 = num;
				num = (short)61734913;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolLookbackTime_A8454.UIName;
			}
		}

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x06002764 RID: 10084 RVA: 0x002648C8 File Offset: 0x00262AC8
		// (set) Token: 0x06002765 RID: 10085 RVA: 0x0026497C File Offset: 0x00262B7C
		internal bool ScanWideLabtoolLookbackTime_A8454_HiddenStatic
		{
			get
			{
				short num = (short)661057093;
				short num2 = num;
				num = (short)1847258693;
				switch (num2 == num)
				{
				}
				num = (short)565706753;
				if (num != 0)
				{
				}
				num = (short)468582400;
				short num3 = num;
				num = (short)1765539840;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolLookbackTime_A8454.HiddenStatic;
			}
			set
			{
				short num = (short)2018422230;
				short num2 = num;
				num = (short)1350610390;
				switch (num2 == num)
				{
				}
				num = (short)582483968;
				if (num != 0)
				{
				}
				num = (short)1011089408;
				short num3 = num;
				num = (short)2030305281;
				if (num != 0)
				{
				}
				this.scanWideLabtoolLookbackTime_A8454.HiddenStatic = value;
			}
		}

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x06002766 RID: 10086 RVA: 0x00264A30 File Offset: 0x00262C30
		// (set) Token: 0x06002767 RID: 10087 RVA: 0x00264AE8 File Offset: 0x00262CE8
		internal bool ScanWideLabtoolLookbackTime_A8454_HiddenDynamic
		{
			get
			{
				short num = (short)2143771744;
				short num2 = num;
				num = (short)1604017248;
				switch (num2 == num)
				{
				}
				num = (short)1387069440;
				if (num != 0)
				{
				}
				num = (short)852099072;
				short num3 = num;
				num = (short)1835139073;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolLookbackTime_A8454.HiddenDynamic;
			}
			set
			{
				short num = (short)774449103;
				short num2 = num;
				num = (short)1450780623;
				switch (num2 == num)
				{
				}
				num = (short)623443968;
				if (num != 0)
				{
				}
				num = (short)2111176704;
				short num3 = num;
				num = (short)1571684353;
				if (num != 0)
				{
				}
				this.scanWideLabtoolLookbackTime_A8454.HiddenDynamic = value;
			}
		}

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x06002768 RID: 10088 RVA: 0x00264BA0 File Offset: 0x00262DA0
		public bool ScanWideLabtoolLookbackTime_A8454_HasDiffs
		{
			get
			{
				short num = (short)786037971;
				short num2 = num;
				num = (short)917961939;
				switch (num2 == num)
				{
				}
				num = (short)611319809;
				if (num != 0)
				{
				}
				num = (short)77332480;
				short num3 = num;
				num = (short)348192768;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolLookbackTime_A8454._HasDiffs;
			}
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x06002769 RID: 10089 RVA: 0x00264C54 File Offset: 0x00262E54
		// (set) Token: 0x0600276A RID: 10090 RVA: 0x00264D08 File Offset: 0x00262F08
		public int ScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048Value
		{
			get
			{
				short num = (short)1534825208;
				short num2 = num;
				num = (short)518623992;
				switch (num2 == num)
				{
				}
				num = (short)1088749569;
				if (num != 0)
				{
				}
				num = (short)1259405312;
				short num3 = num;
				num = (short)628162560;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.Value;
			}
			set
			{
				short num = (short)1190133761;
				if (num != 0)
				{
				}
				num = (short)205393336;
				short num2 = num;
				num = (short)472452536;
				switch (num2 == num)
				{
				}
				num = (short)1066336256;
				short num3 = num;
				num = (short)251461632;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.Value = value;
			}
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x0600276B RID: 10091 RVA: 0x00264DBC File Offset: 0x00262FBC
		public global::AcpBusinessLayer.AcpSimpleRangeField ScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048
		{
			get
			{
				short num = (short)1862704871;
				short num2 = num;
				num = (short)1287429863;
				switch (num2 == num)
				{
				}
				num = (short)1037172737;
				if (num != 0)
				{
				}
				num = (short)959709184;
				short num3 = num;
				num = (short)554958848;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048;
			}
		}

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x0600276C RID: 10092 RVA: 0x00264E68 File Offset: 0x00263068
		// (set) Token: 0x0600276D RID: 10093 RVA: 0x00264F1C File Offset: 0x0026311C
		public string ScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048_UIValue
		{
			get
			{
				short num = (short)514248819;
				short num2 = num;
				num = (short)83021939;
				switch (num2 == num)
				{
				}
				num = (short)1919352833;
				if (num != 0)
				{
				}
				num = (short)2093285376;
				short num3 = num;
				num = (short)4587520;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.UIValue;
			}
			set
			{
				short num = (short)1400032930;
				short num2 = num;
				num = (short)188731042;
				switch (num2 == num)
				{
				}
				num = (short)1419247617;
				if (num != 0)
				{
				}
				num = (short)1719205888;
				short num3 = num;
				num = (short)2027225088;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.UIValue = value;
			}
		}

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x0600276E RID: 10094 RVA: 0x00264FD4 File Offset: 0x002631D4
		// (set) Token: 0x0600276F RID: 10095 RVA: 0x00265088 File Offset: 0x00263288
		internal int ScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048Min
		{
			get
			{
				short num = (short)193791943;
				short num2 = num;
				num = (short)1783760839;
				switch (num2 == num)
				{
				}
				num = (short)591134720;
				if (num != 0)
				{
				}
				num = (short)330170368;
				short num3 = num;
				num = (short)715718657;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.Min;
			}
			set
			{
				short num = (short)1811558912;
				short num2 = num;
				num = (short)1246048768;
				switch (num2 == num)
				{
				}
				num = (short)80740353;
				if (num != 0)
				{
				}
				num = (short)2006777856;
				short num3 = num;
				num = (short)530972672;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.Min = value;
			}
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x06002770 RID: 10096 RVA: 0x00265140 File Offset: 0x00263340
		// (set) Token: 0x06002771 RID: 10097 RVA: 0x002651F8 File Offset: 0x002633F8
		internal int ScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048Max
		{
			get
			{
				short num = (short)221605231;
				short num2 = num;
				num = (short)256666991;
				switch (num2 == num)
				{
				}
				num = (short)1738407937;
				if (num != 0)
				{
				}
				num = (short)1007878144;
				short num3 = num;
				num = (short)10027008;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.Max;
			}
			set
			{
				short num = (short)1763823631;
				short num2 = num;
				num = (short)843829263;
				switch (num2 == num)
				{
				}
				num = (short)1358757889;
				if (num != 0)
				{
				}
				num = (short)2017656832;
				short num3 = num;
				num = (short)1645019136;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.Max = value;
			}
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x06002772 RID: 10098 RVA: 0x002652AC File Offset: 0x002634AC
		// (set) Token: 0x06002773 RID: 10099 RVA: 0x00265360 File Offset: 0x00263560
		internal int ScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048Step
		{
			get
			{
				short num = (short)1205879097;
				short num2 = num;
				num = (short)1679966521;
				switch (num2 == num)
				{
				}
				num = (short)1054343169;
				if (num != 0)
				{
				}
				num = (short)53739520;
				short num3 = num;
				num = (short)881852416;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.StepSize;
			}
			set
			{
				short num = (short)1961519979;
				short num2 = num;
				num = (short)2116709227;
				switch (num2 == num)
				{
				}
				num = (short)1509687297;
				if (num != 0)
				{
				}
				num = (short)1160445952;
				short num3 = num;
				num = (short)1644298240;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.StepSize = value;
			}
		}

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x06002774 RID: 10100 RVA: 0x00265414 File Offset: 0x00263614
		// (set) Token: 0x06002775 RID: 10101 RVA: 0x002654CC File Offset: 0x002636CC
		public bool ScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048_Applicable
		{
			get
			{
				short num = (short)373238053;
				short num2 = num;
				num = (short)1410410789;
				switch (num2 == num)
				{
				}
				num = (short)1796669441;
				if (num != 0)
				{
				}
				num = (short)207093760;
				short num3 = num;
				num = (short)889782272;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.Applicable;
			}
			set
			{
				short num = (short)383238131;
				short num2 = num;
				num = (short)1913307123;
				switch (num2 == num)
				{
				}
				num = (short)1643773953;
				if (num != 0)
				{
				}
				num = (short)2035154944;
				short num3 = num;
				num = (short)909049856;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.Applicable = value;
			}
		}

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x06002776 RID: 10102 RVA: 0x00265580 File Offset: 0x00263780
		// (set) Token: 0x06002777 RID: 10103 RVA: 0x00265634 File Offset: 0x00263834
		public bool ScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048_Valid
		{
			get
			{
				short num = (short)1592181438;
				short num2 = num;
				num = (short)535610046;
				switch (num2 == num)
				{
				default:
				{
					num = (short)864747520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1763704833;
				if (num != 0)
				{
				}
				num = (short)449904640;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.Valid;
			}
			set
			{
				short num = (short)945673121;
				short num2 = num;
				num = (short)2145244065;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2129920000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)868614145;
				if (num != 0)
				{
				}
				num = (short)1310261248;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.Valid = value;
			}
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x002656E8 File Offset: 0x002638E8
		// (set) Token: 0x06002779 RID: 10105 RVA: 0x0026579C File Offset: 0x0026399C
		public bool ScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048_Visible
		{
			get
			{
				short num = (short)1765517657;
				short num2 = num;
				num = (short)1981983065;
				switch (num2 == num)
				{
				default:
				{
					num = (short)512491520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)6225921;
				if (num != 0)
				{
				}
				num = (short)126943232;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.Visible;
			}
			set
			{
				short num = (short)1983902498;
				short num2 = num;
				num = (short)902886178;
				switch (num2 == num)
				{
				default:
				{
					num = (short)804847616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)403963905;
				if (num != 0)
				{
				}
				num = (short)2092105728;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.Visible = value;
			}
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x00265850 File Offset: 0x00263A50
		// (set) Token: 0x0600277B RID: 10107 RVA: 0x00265904 File Offset: 0x00263B04
		public bool ScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048_Editable
		{
			get
			{
				short num = (short)66125825;
				if (num != 0)
				{
				}
				num = (short)1078657024;
				short num2 = num;
				num = (short)2135460601;
				short num3 = num;
				num = (short)2132118265;
				switch (num3 == num)
				{
				}
				num = (short)311820288;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.Editable;
			}
			set
			{
				short num = (short)1410379425;
				short num2 = num;
				num = (short)1206300321;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1248985088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1987444737;
				if (num != 0)
				{
				}
				num = (short)775684096;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.Editable = value;
			}
		}

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x0600277C RID: 10108 RVA: 0x002659B8 File Offset: 0x00263BB8
		internal string ScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048_UILabel
		{
			get
			{
				short num = (short)466638023;
				short num2 = num;
				num = (short)1215845575;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2102001664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)8912897;
				if (num != 0)
				{
				}
				num = (short)398786560;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.UIName;
			}
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x0600277D RID: 10109 RVA: 0x00265A70 File Offset: 0x00263C70
		// (set) Token: 0x0600277E RID: 10110 RVA: 0x00265B24 File Offset: 0x00263D24
		internal bool ScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048_HiddenStatic
		{
			get
			{
				short num = (short)1278585770;
				short num2 = num;
				num = (short)670804906;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1558380544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)161546240;
				if (num != 0)
				{
				}
				num = (short)1322057729;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.HiddenStatic;
			}
			set
			{
				short num = (short)531071301;
				short num2 = num;
				num = (short)675905861;
				switch (num2 == num)
				{
				default:
				{
					num = (short)874184704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)246022144;
				if (num != 0)
				{
				}
				num = (short)272891905;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.HiddenStatic = value;
			}
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x0600277F RID: 10111 RVA: 0x00265BD8 File Offset: 0x00263DD8
		// (set) Token: 0x06002780 RID: 10112 RVA: 0x00265C8C File Offset: 0x00263E8C
		internal bool ScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048_HiddenDynamic
		{
			get
			{
				short num = (short)122421249;
				if (num != 0)
				{
				}
				num = (short)1981874176;
				short num2 = num;
				num = (short)2000538112;
				short num3 = num;
				num = (short)690145792;
				switch (num3 == num)
				{
				}
				num = (short)772603904;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.HiddenDynamic;
			}
			set
			{
				short num = (short)2022719448;
				short num2 = num;
				num = (short)188694488;
				switch (num2 == num)
				{
				default:
				{
					num = (short)881852416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)469958657;
				if (num != 0)
				{
				}
				num = (short)604897280;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.HiddenDynamic = value;
			}
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x06002781 RID: 10113 RVA: 0x00265D44 File Offset: 0x00263F44
		public bool ScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048_HasDiffs
		{
			get
			{
				short num = (short)1133432458;
				short num2 = num;
				num = (short)78630538;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1813381120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1059127297;
				if (num != 0)
				{
				}
				num = (short)1574699008;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048._HasDiffs;
			}
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x06002782 RID: 10114 RVA: 0x00265DF8 File Offset: 0x00263FF8
		// (set) Token: 0x06002783 RID: 10115 RVA: 0x00265EB0 File Offset: 0x002640B0
		public int ScanWideLabtoolScanDetectTimeForPL_A9049Value
		{
			get
			{
				short num = (short)183238657;
				if (num != 0)
				{
				}
				num = (short)1745289216;
				short num2 = num;
				num = (short)538552353;
				short num3 = num;
				num = (short)1264035873;
				switch (num3 == num)
				{
				}
				num = (short)24313856;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForPL_A9049.Value;
			}
			set
			{
				short num = (short)849253604;
				short num2 = num;
				num = (short)1154192612;
				switch (num2 == num)
				{
				default:
				{
					num = (short)80543744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)774569984;
				if (num != 0)
				{
				}
				num = (short)609288193;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForPL_A9049.Value = value;
			}
		}

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x06002784 RID: 10116 RVA: 0x00265F68 File Offset: 0x00264168
		public global::AcpBusinessLayer.AcpSimpleRangeField ScanWideLabtoolScanDetectTimeForPL_A9049
		{
			get
			{
				short num = (short)1198107227;
				short num2 = num;
				num = (short)1356245595;
				switch (num2 == num)
				{
				default:
				{
					num = (short)50135040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)68485121;
				if (num != 0)
				{
				}
				num = (short)752549888;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForPL_A9049;
			}
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x06002785 RID: 10117 RVA: 0x00266014 File Offset: 0x00264214
		// (set) Token: 0x06002786 RID: 10118 RVA: 0x002660C8 File Offset: 0x002642C8
		public string ScanWideLabtoolScanDetectTimeForPL_A9049_UIValue
		{
			get
			{
				short num = (short)383560068;
				short num2 = num;
				num = (short)742041988;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1560477696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)930873345;
				if (num != 0)
				{
				}
				num = (short)1440284672;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForPL_A9049.UIValue;
			}
			set
			{
				short num = (short)908494565;
				short num2 = num;
				num = (short)1184794341;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1460731904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1207435264;
				if (num != 0)
				{
				}
				num = (short)455147521;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForPL_A9049.UIValue = value;
			}
		}

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x06002787 RID: 10119 RVA: 0x00266178 File Offset: 0x00264378
		// (set) Token: 0x06002788 RID: 10120 RVA: 0x0026622C File Offset: 0x0026442C
		internal int ScanWideLabtoolScanDetectTimeForPL_A9049Min
		{
			get
			{
				short num = (short)401996579;
				short num2 = num;
				num = (short)1200945955;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1661403136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1571749889;
				if (num != 0)
				{
				}
				num = (short)1425473536;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForPL_A9049.Min;
			}
			set
			{
				short num = (short)75300865;
				if (num != 0)
				{
				}
				num = (short)1782906880;
				short num2 = num;
				num = (short)935221226;
				short num3 = num;
				num = (short)443635690;
				switch (num3 == num)
				{
				}
				num = (short)512032768;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForPL_A9049.Min = value;
			}
		}

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x06002789 RID: 10121 RVA: 0x002662E8 File Offset: 0x002644E8
		// (set) Token: 0x0600278A RID: 10122 RVA: 0x002663A0 File Offset: 0x002645A0
		internal int ScanWideLabtoolScanDetectTimeForPL_A9049Max
		{
			get
			{
				short num = (short)903135380;
				short num2 = num;
				num = (short)1958789268;
				switch (num2 == num)
				{
				default:
				{
					num = (short)231735296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1131937793;
				if (num != 0)
				{
				}
				num = (short)634519552;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForPL_A9049.Max;
			}
			set
			{
				short num = (short)922723919;
				short num2 = num;
				num = (short)2031396431;
				switch (num2 == num)
				{
				default:
				{
					num = (short)660078592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1754267648;
				if (num != 0)
				{
				}
				num = (short)951386113;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForPL_A9049.Max = value;
			}
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x0600278B RID: 10123 RVA: 0x00266458 File Offset: 0x00264658
		// (set) Token: 0x0600278C RID: 10124 RVA: 0x0026650C File Offset: 0x0026470C
		internal int ScanWideLabtoolScanDetectTimeForPL_A9049Step
		{
			get
			{
				short num = (short)30934688;
				short num2 = num;
				num = (short)2041710240;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1938423808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)865402881;
				if (num != 0)
				{
				}
				num = (short)1128071168;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForPL_A9049.StepSize;
			}
			set
			{
				short num = (short)1398603308;
				short num2 = num;
				num = (short)1945566764;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2124480512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1031405569;
				if (num != 0)
				{
				}
				num = (short)598474752;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForPL_A9049.StepSize = value;
			}
		}

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x0600278D RID: 10125 RVA: 0x002665C0 File Offset: 0x002647C0
		// (set) Token: 0x0600278E RID: 10126 RVA: 0x00266674 File Offset: 0x00264874
		public bool ScanWideLabtoolScanDetectTimeForPL_A9049_Applicable
		{
			get
			{
				short num = (short)1835859547;
				short num2 = num;
				num = (short)583663195;
				switch (num2 == num)
				{
				default:
				{
					num = (short)255787008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1450115073;
				if (num != 0)
				{
				}
				num = (short)401211392;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForPL_A9049.Applicable;
			}
			set
			{
				short num = (short)1700936463;
				short num2 = num;
				num = (short)1757559567;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1678573568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1806893056;
				if (num != 0)
				{
				}
				num = (short)114688001;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForPL_A9049.Applicable = value;
			}
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x00266728 File Offset: 0x00264928
		// (set) Token: 0x06002790 RID: 10128 RVA: 0x002667DC File Offset: 0x002649DC
		public bool ScanWideLabtoolScanDetectTimeForPL_A9049_Valid
		{
			get
			{
				short num = (short)9057924;
				short num2 = num;
				num = (short)1663317636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1306525696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)379715585;
				if (num != 0)
				{
				}
				num = (short)1038352384;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForPL_A9049.Valid;
			}
			set
			{
				short num = (short)1227493839;
				short num2 = num;
				num = (short)1735201231;
				switch (num2 == num)
				{
				default:
				{
					num = (short)876216320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1532690433;
				if (num != 0)
				{
				}
				num = (short)144113664;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForPL_A9049.Valid = value;
			}
		}

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x00266894 File Offset: 0x00264A94
		// (set) Token: 0x06002792 RID: 10130 RVA: 0x00266948 File Offset: 0x00264B48
		public bool ScanWideLabtoolScanDetectTimeForPL_A9049_Visible
		{
			get
			{
				short num = (short)284033025;
				if (num != 0)
				{
				}
				num = (short)1364262912;
				short num2 = num;
				num = (short)1278449203;
				short num3 = num;
				num = (short)1011717683;
				switch (num3 == num)
				{
				}
				num = (short)2117599232;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForPL_A9049.Visible;
			}
			set
			{
				short num = (short)2143107852;
				short num2 = num;
				num = (short)1390361356;
				switch (num2 == num)
				{
				default:
				{
					num = (short)740229120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1926823936;
				if (num != 0)
				{
				}
				num = (short)1134821377;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForPL_A9049.Visible = value;
			}
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x06002793 RID: 10131 RVA: 0x002669FC File Offset: 0x00264BFC
		// (set) Token: 0x06002794 RID: 10132 RVA: 0x00266AB0 File Offset: 0x00264CB0
		public bool ScanWideLabtoolScanDetectTimeForPL_A9049_Editable
		{
			get
			{
				short num = (short)679183971;
				short num2 = num;
				num = (short)1808107107;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1701773312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)991625217;
				if (num != 0)
				{
				}
				num = (short)1914961920;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForPL_A9049.Editable;
			}
			set
			{
				short num = (short)1250386115;
				short num2 = num;
				num = (short)1415340227;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1000734720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)714014721;
				if (num != 0)
				{
				}
				num = (short)1021575168;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForPL_A9049.Editable = value;
			}
		}

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x00266B64 File Offset: 0x00264D64
		internal string ScanWideLabtoolScanDetectTimeForPL_A9049_UILabel
		{
			get
			{
				short num = (short)620342826;
				short num2 = num;
				num = (short)636923434;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1003487232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1731985409;
				if (num != 0)
				{
				}
				num = (short)899350528;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForPL_A9049.UIName;
			}
		}

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x06002796 RID: 10134 RVA: 0x00266C18 File Offset: 0x00264E18
		// (set) Token: 0x06002797 RID: 10135 RVA: 0x00266CCC File Offset: 0x00264ECC
		internal bool ScanWideLabtoolScanDetectTimeForPL_A9049_HiddenStatic
		{
			get
			{
				short num = (short)745115918;
				short num2 = num;
				num = (short)1848152334;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1953169408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)66977793;
				if (num != 0)
				{
				}
				num = (short)1334575104;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForPL_A9049.HiddenStatic;
			}
			set
			{
				short num = (short)1073283073;
				if (num != 0)
				{
				}
				num = (short)2022113280;
				short num2 = num;
				num = (short)2083928127;
				short num3 = num;
				num = (short)1762015295;
				switch (num3 == num)
				{
				}
				num = (short)2127167488;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForPL_A9049.HiddenStatic = value;
			}
		}

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x06002798 RID: 10136 RVA: 0x00266D84 File Offset: 0x00264F84
		// (set) Token: 0x06002799 RID: 10137 RVA: 0x00266E38 File Offset: 0x00265038
		internal bool ScanWideLabtoolScanDetectTimeForPL_A9049_HiddenDynamic
		{
			get
			{
				short num = (short)152778783;
				short num2 = num;
				num = (short)553138207;
				switch (num2 == num)
				{
				default:
				{
					num = (short)648085504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1376976897;
				if (num != 0)
				{
				}
				num = (short)1757872128;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForPL_A9049.HiddenDynamic;
			}
			set
			{
				short num = (short)856350236;
				short num2 = num;
				num = (short)143253020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)549978112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)288620545;
				if (num != 0)
				{
				}
				num = (short)2109865984;
				if (num != 0)
				{
				}
				this.scanWideLabtoolScanDetectTimeForPL_A9049.HiddenDynamic = value;
			}
		}

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x0600279A RID: 10138 RVA: 0x00266EEC File Offset: 0x002650EC
		public bool ScanWideLabtoolScanDetectTimeForPL_A9049_HasDiffs
		{
			get
			{
				short num = (short)899960860;
				short num2 = num;
				num = (short)1052725276;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1195769856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)761200641;
				if (num != 0)
				{
				}
				num = (short)899219456;
				if (num != 0)
				{
				}
				return this.scanWideLabtoolScanDetectTimeForPL_A9049._HasDiffs;
			}
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x00266FA0 File Offset: 0x002651A0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				num = (short)22740992;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_4C;
				}
				int num3;
				for (;;)
				{
					IL_32:
					switch (num3)
					{
					case 0:
						num = (short)1630601220;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_AA;
					case 2:
						if (base.ParentRecset != null)
						{
							num = (short)1718026240;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_114;
					case 3:
						num = (short)785973249;
						if (num != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)154664961;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)535035907;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_114;
					}
					goto IL_4C;
				}
				IL_114:
				num = (short)718469923;
				short num4 = num;
				num = (short)235535139;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_148;
				}
				IL_AA:
				goto IL_114;
				IL_4C:
				result = null;
				num = (short)1270349826;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			IL_148:
			num = (short)1023934464;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x04000E62 RID: 3682
		private global::AcpBusinessLayer.AcpSimpleRangeField scanWideLabtoolLookbackTime_A8454;

		// Token: 0x04000E63 RID: 3683
		private global::AcpBusinessLayer.AcpSimpleRangeField scanWideLabtoolScanDetectTimeForCarrierSquelch_A9048;

		// Token: 0x04000E64 RID: 3684
		private global::AcpBusinessLayer.AcpSimpleRangeField scanWideLabtoolScanDetectTimeForPL_A9049;
	}
}
