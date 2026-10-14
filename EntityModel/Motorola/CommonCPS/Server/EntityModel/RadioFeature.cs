using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200008B RID: 139
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class RadioFeature : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x06000A75 RID: 2677 RVA: 0x00070C4C File Offset: 0x0006EE4C
		public static global::Motorola.CommonCPS.Server.EntityModel.RadioFeature CreateRadioFeature(global::System.Guid? radioFeatureUuid, global::System.Guid deviceUuid, int featureName, int currentStatus, int workingStatus, bool modified, int displayStatus, int licenseFrom, int featureType = 0, string featureNotice = "")
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.RadioFeature radioFeature;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (radioFeatureUuid != null)
					{
						num2 = (short)983629827;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)417923072;
					short num3 = num2;
					radioFeature.Uuid = global::System.Guid.NewGuid();
					num2 = (short)427032578;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_13C;
				case 2:
					goto IL_EE;
				case 3:
				{
					num2 = (short)849143835;
					short num4 = num2;
					num2 = (short)114812955;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1555365888;
						if (num2 != 0)
						{
						}
						radioFeature.Uuid = radioFeatureUuid.Value;
						num2 = (short)256966657;
						if (num2 != 0)
						{
						}
						num2 = (short)1137246209;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_20;
			}
			IL_EE:
			IL_13C:
			radioFeature.RadioUuid = new global::System.Guid?(deviceUuid);
			radioFeature.FeatureName = featureName;
			radioFeature.CurrentStatus = currentStatus;
			radioFeature.WorkingStatus = workingStatus;
			radioFeature.Modified = modified;
			radioFeature.DisplayStatus = displayStatus;
			radioFeature.LicenseFrom = licenseFrom;
			radioFeature.FeatureType = featureType;
			radioFeature.FeatureNotice = featureNotice;
			return radioFeature;
			IL_20:
			radioFeature = new global::Motorola.CommonCPS.Server.EntityModel.RadioFeature();
			num2 = (short)687144960;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00070DE4 File Offset: 0x0006EFE4
		public RadioFeature()
		{
			this.IsVisible = true;
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x00070E00 File Offset: 0x0006F000
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x00070EB0 File Offset: 0x0006F0B0
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? RadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1076177724;
				short num2 = num;
				num = (short)1748708156;
				switch (num2 == num)
				{
				}
				num = (short)10223617;
				if (num != 0)
				{
				}
				num = (short)734658560;
				if (num != 0)
				{
				}
				num = (short)448987136;
				short num3 = num;
				return this.<RadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1724245249;
				short num2 = num;
				num = (short)1282925825;
				switch (num2 == num)
				{
				}
				num = (short)503906305;
				if (num != 0)
				{
				}
				num = (short)1156775936;
				if (num != 0)
				{
				}
				num = (short)2097283072;
				short num3 = num;
				this.<RadioUuid>k__BackingField = value;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x00070F60 File Offset: 0x0006F160
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x00071010 File Offset: 0x0006F210
		[global::System.Runtime.Serialization.DataMember]
		public int FeatureName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1511035308;
				short num2 = num;
				num = (short)107188652;
				switch (num2 == num)
				{
				}
				num = (short)1734344705;
				if (num != 0)
				{
				}
				num = (short)1578434560;
				if (num != 0)
				{
				}
				num = (short)1887633408;
				short num3 = num;
				return this.<FeatureName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)202355693;
				short num2 = num;
				num = (short)1354019821;
				switch (num2 == num)
				{
				}
				num = (short)1589706753;
				if (num != 0)
				{
				}
				num = (short)2130182144;
				if (num != 0)
				{
				}
				num = (short)418447360;
				short num3 = num;
				this.<FeatureName>k__BackingField = value;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x000710C0 File Offset: 0x0006F2C0
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x0007116C File Offset: 0x0006F36C
		[global::System.Runtime.Serialization.DataMember]
		public int CurrentStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)669261833;
				short num2 = num;
				num = (short)115351561;
				switch (num2 == num)
				{
				}
				num = (short)1284571136;
				if (num != 0)
				{
				}
				num = (short)579469313;
				if (num != 0)
				{
				}
				num = (short)672727040;
				short num3 = num;
				return this.<CurrentStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1898165187;
				short num2 = num;
				num = (short)2058597315;
				switch (num2 == num)
				{
				}
				num = (short)310378496;
				if (num != 0)
				{
				}
				num = (short)19988481;
				if (num != 0)
				{
				}
				num = (short)111214592;
				short num3 = num;
				this.<CurrentStatus>k__BackingField = value;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x00071220 File Offset: 0x0006F420
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x000712D0 File Offset: 0x0006F4D0
		[global::System.Runtime.Serialization.DataMember]
		public int WorkingStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)404955301;
				short num2 = num;
				num = (short)101654693;
				switch (num2 == num)
				{
				}
				num = (short)981598209;
				if (num != 0)
				{
				}
				num = (short)183238656;
				if (num != 0)
				{
				}
				num = (short)858193920;
				short num3 = num;
				return this.<WorkingStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)226529659;
				short num2 = num;
				num = (short)899322235;
				switch (num2 == num)
				{
				}
				num = (short)109314049;
				if (num != 0)
				{
				}
				num = (short)1586495488;
				if (num != 0)
				{
				}
				num = (short)284229632;
				short num3 = num;
				this.<WorkingStatus>k__BackingField = value;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x00071380 File Offset: 0x0006F580
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x0007142C File Offset: 0x0006F62C
		[global::System.Runtime.Serialization.DataMember]
		public bool Modified
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)846527033;
				short num2 = num;
				num = (short)1583413817;
				switch (num2 == num)
				{
				}
				num = (short)754909185;
				if (num != 0)
				{
				}
				num = (short)1816199168;
				if (num != 0)
				{
				}
				num = (short)510787584;
				short num3 = num;
				return this.<Modified>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)179706884;
				short num2 = num;
				num = (short)1548819460;
				switch (num2 == num)
				{
				}
				num = (short)1179123712;
				if (num != 0)
				{
				}
				num = (short)1835728897;
				if (num != 0)
				{
				}
				num = (short)930021376;
				short num3 = num;
				this.<Modified>k__BackingField = value;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x000714E0 File Offset: 0x0006F6E0
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x00071590 File Offset: 0x0006F790
		[global::System.Runtime.Serialization.DataMember]
		public int DisplayStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)639107073;
				if (num != 0)
				{
				}
				num = (short)587474488;
				short num2 = num;
				num = (short)1414080056;
				switch (num2 == num)
				{
				}
				num = (short)490405888;
				if (num != 0)
				{
				}
				num = (short)172490752;
				short num3 = num;
				return this.<DisplayStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2082810752;
				short num2 = num;
				num = (short)1126968192;
				switch (num2 == num)
				{
				}
				num = (short)1698496513;
				if (num != 0)
				{
				}
				num = (short)1223032832;
				if (num != 0)
				{
				}
				num = (short)1848901632;
				short num3 = num;
				this.<DisplayStatus>k__BackingField = value;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00071640 File Offset: 0x0006F840
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x000716F4 File Offset: 0x0006F8F4
		[global::System.Runtime.Serialization.DataMember]
		[global::System.ComponentModel.DataAnnotations.Schema.NotMapped]
		public int LicenseFrom
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1555399859;
				short num2 = num;
				num = (short)1470530739;
				switch (num2 == num)
				{
				}
				num = (short)1886453761;
				if (num != 0)
				{
				}
				num = (short)880017408;
				if (num != 0)
				{
				}
				num = (short)1883832320;
				short num3 = num;
				return this.<LicenseFrom>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2038075374;
				short num2 = num;
				num = (short)1831899118;
				switch (num2 == num)
				{
				}
				num = (short)1338048513;
				if (num != 0)
				{
				}
				num = (short)1866006528;
				if (num != 0)
				{
				}
				num = (short)2022440960;
				short num3 = num;
				this.<LicenseFrom>k__BackingField = value;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x000717A4 File Offset: 0x0006F9A4
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x00071858 File Offset: 0x0006FA58
		[global::System.Runtime.Serialization.DataMember]
		public string LicenseFromEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1415148233;
				short num2 = num;
				num = (short)1525510857;
				switch (num2 == num)
				{
				}
				num = (short)146014209;
				if (num != 0)
				{
				}
				num = (short)943259648;
				if (num != 0)
				{
				}
				num = (short)201916416;
				short num3 = num;
				return this.<LicenseFromEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1921821209;
				short num2 = num;
				num = (short)2039589401;
				switch (num2 == num)
				{
				}
				num = (short)1232011265;
				if (num != 0)
				{
				}
				num = (short)1876295680;
				if (num != 0)
				{
				}
				num = (short)876347392;
				short num3 = num;
				this.<LicenseFromEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x0007190C File Offset: 0x0006FB0C
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x000719BC File Offset: 0x0006FBBC
		[global::System.Runtime.Serialization.DataMember]
		[global::System.ComponentModel.DataAnnotations.Schema.NotMapped]
		public string LicenseName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1223087090;
				short num2 = num;
				num = (short)1990775794;
				switch (num2 == num)
				{
				}
				num = (short)1491271681;
				if (num != 0)
				{
				}
				num = (short)740818944;
				if (num != 0)
				{
				}
				num = (short)1025245184;
				short num3 = num;
				return this.<LicenseName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)585846772;
				short num2 = num;
				num = (short)133386228;
				switch (num2 == num)
				{
				}
				num = (short)1205075969;
				if (num != 0)
				{
				}
				num = (short)912982016;
				if (num != 0)
				{
				}
				num = (short)868548608;
				short num3 = num;
				this.<LicenseName>k__BackingField = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00071A68 File Offset: 0x0006FC68
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x00071B18 File Offset: 0x0006FD18
		[global::System.Runtime.Serialization.DataMember]
		public string LicenseNameEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1718674814;
				short num2 = num;
				num = (short)244442494;
				switch (num2 == num)
				{
				}
				num = (short)972095489;
				if (num != 0)
				{
				}
				num = (short)168165376;
				if (num != 0)
				{
				}
				num = (short)1371537408;
				short num3 = num;
				return this.<LicenseNameEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)911972467;
				short num2 = num;
				num = (short)1862703219;
				switch (num2 == num)
				{
				}
				num = (short)194576385;
				if (num != 0)
				{
				}
				num = (short)1795817472;
				if (num != 0)
				{
				}
				num = (short)668401664;
				short num3 = num;
				this.<LicenseNameEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x00071BC8 File Offset: 0x0006FDC8
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x00071C78 File Offset: 0x0006FE78
		[global::System.Runtime.Serialization.DataMember]
		public byte[] RegisteredFlashCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1811953755;
				short num2 = num;
				num = (short)203634779;
				switch (num2 == num)
				{
				}
				num = (short)1690501121;
				if (num != 0)
				{
				}
				num = (short)675282944;
				if (num != 0)
				{
				}
				num = (short)393543680;
				short num3 = num;
				return this.<RegisteredFlashCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1331167233;
				if (num != 0)
				{
				}
				num = (short)1326412918;
				short num2 = num;
				num = (short)406156406;
				switch (num2 == num)
				{
				}
				num = (short)1068826624;
				if (num != 0)
				{
				}
				num = (short)1763377152;
				short num3 = num;
				this.<RegisteredFlashCode>k__BackingField = value;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x00071D28 File Offset: 0x0006FF28
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x00071DD8 File Offset: 0x0006FFD8
		[global::System.Runtime.Serialization.DataMember]
		public string RegisteredFlashCodeEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)282651686;
				short num2 = num;
				num = (short)935455782;
				switch (num2 == num)
				{
				}
				num = (short)1255473153;
				if (num != 0)
				{
				}
				num = (short)1891565568;
				if (num != 0)
				{
				}
				num = (short)841613312;
				short num3 = num;
				return this.<RegisteredFlashCodeEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)142789550;
				short num2 = num;
				num = (short)1781058478;
				switch (num2 == num)
				{
				}
				num = (short)1099628545;
				if (num != 0)
				{
				}
				num = (short)69140480;
				if (num != 0)
				{
				}
				num = (short)1068892160;
				short num3 = num;
				this.<RegisteredFlashCodeEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x00071E8C File Offset: 0x0007008C
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x00071F38 File Offset: 0x00070138
		[global::System.Runtime.Serialization.DataMember]
		public string SerialNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1237334518;
				short num2 = num;
				num = (short)1231370742;
				switch (num2 == num)
				{
				}
				num = (short)1954873345;
				if (num != 0)
				{
				}
				num = (short)1667170304;
				if (num != 0)
				{
				}
				num = (short)1229717504;
				short num3 = num;
				return this.<SerialNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)630609745;
				short num2 = num;
				num = (short)929060689;
				switch (num2 == num)
				{
				}
				num = (short)415170561;
				if (num != 0)
				{
				}
				num = (short)383254528;
				if (num != 0)
				{
				}
				num = (short)1580335104;
				short num3 = num;
				this.<SerialNumber>k__BackingField = value;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x00071FE8 File Offset: 0x000701E8
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x00072098 File Offset: 0x00070298
		[global::System.Runtime.Serialization.DataMember]
		public string IMEI
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2005263643;
				short num2 = num;
				num = (short)737207579;
				switch (num2 == num)
				{
				}
				num = (short)154075136;
				if (num != 0)
				{
				}
				num = (short)1691615233;
				if (num != 0)
				{
				}
				num = (short)1259601920;
				short num3 = num;
				return this.<IMEI>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)53459040;
				short num2 = num;
				num = (short)1528608864;
				switch (num2 == num)
				{
				}
				num = (short)1951465472;
				if (num != 0)
				{
				}
				num = (short)2093088769;
				if (num != 0)
				{
				}
				num = (short)1653014528;
				short num3 = num;
				this.<IMEI>k__BackingField = value;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x0007214C File Offset: 0x0007034C
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x000721FC File Offset: 0x000703FC
		[global::System.Runtime.Serialization.DataMember]
		public string ProductIdentifier
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1332440542;
				short num2 = num;
				num = (short)415722974;
				switch (num2 == num)
				{
				}
				num = (short)1700462593;
				if (num != 0)
				{
				}
				num = (short)922157056;
				if (num != 0)
				{
				}
				num = (short)322240512;
				short num3 = num;
				return this.<ProductIdentifier>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)298508250;
				short num2 = num;
				num = (short)1871372250;
				switch (num2 == num)
				{
				}
				num = (short)1264713728;
				if (num != 0)
				{
				}
				num = (short)88342529;
				if (num != 0)
				{
				}
				num = (short)475529216;
				short num3 = num;
				this.<ProductIdentifier>k__BackingField = value;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x000722AC File Offset: 0x000704AC
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x0007235C File Offset: 0x0007055C
		[global::System.Runtime.Serialization.DataMember]
		public string ModelNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1828192257;
				if (num != 0)
				{
				}
				num = (short)1248427634;
				short num2 = num;
				num = (short)1706327666;
				switch (num2 == num)
				{
				}
				num = (short)429916160;
				if (num != 0)
				{
				}
				num = (short)776732672;
				short num3 = num;
				return this.<ModelNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1762717801;
				short num2 = num;
				num = (short)1962995817;
				switch (num2 == num)
				{
				}
				num = (short)1299120129;
				if (num != 0)
				{
				}
				num = (short)1398341632;
				if (num != 0)
				{
				}
				num = (short)1554186240;
				short num3 = num;
				this.<ModelNumber>k__BackingField = value;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x0007240C File Offset: 0x0007060C
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x000724BC File Offset: 0x000706BC
		[global::System.Runtime.Serialization.DataMember]
		public string Comments
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1203538411;
				short num2 = num;
				num = (short)835160555;
				switch (num2 == num)
				{
				}
				num = (short)1808596992;
				short num3 = num;
				num = (short)1140457472;
				if (num != 0)
				{
				}
				num = (short)68747265;
				if (num != 0)
				{
				}
				return this.<Comments>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)528416769;
				if (num != 0)
				{
				}
				num = (short)1948177522;
				short num2 = num;
				num = (short)1300616306;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1345978368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)752615424;
				if (num != 0)
				{
				}
				this.<Comments>k__BackingField = value;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x0007256C File Offset: 0x0007076C
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x0007261C File Offset: 0x0007081C
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.Radio Radio
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1790959897;
				short num2 = num;
				num = (short)102228249;
				switch (num2 == num)
				{
				}
				num = (short)570359808;
				short num3 = num;
				num = (short)1072955393;
				if (num != 0)
				{
				}
				num = (short)1521025024;
				if (num != 0)
				{
				}
				return this.<Radio>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)919499919;
				short num2 = num;
				num = (short)673870991;
				switch (num2 == num)
				{
				}
				num = (short)1319763968;
				short num3 = num;
				num = (short)159776769;
				if (num != 0)
				{
				}
				num = (short)1351745536;
				if (num != 0)
				{
				}
				this.<Radio>k__BackingField = value;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x000726CC File Offset: 0x000708CC
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x00072780 File Offset: 0x00070980
		[global::System.Runtime.Serialization.DataMember]
		public int FeatureType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1379420311;
				short num2 = num;
				num = (short)337004695;
				switch (num2 == num)
				{
				}
				num = (short)721616896;
				short num3 = num;
				num = (short)1683357696;
				if (num != 0)
				{
				}
				num = (short)1549139969;
				if (num != 0)
				{
				}
				return this.<FeatureType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1391334368;
				short num2 = num;
				num = (short)1051595744;
				switch (num2 == num)
				{
				}
				num = (short)2064973824;
				short num3 = num;
				num = (short)2114191360;
				if (num != 0)
				{
				}
				num = (short)120651777;
				if (num != 0)
				{
				}
				this.<FeatureType>k__BackingField = value;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00072830 File Offset: 0x00070A30
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x000728DC File Offset: 0x00070ADC
		[global::System.Runtime.Serialization.DataMember]
		public string CMSCHostID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)773209952;
				short num2 = num;
				num = (short)965820256;
				switch (num2 == num)
				{
				}
				num = (short)226164736;
				short num3 = num;
				num = (short)883949568;
				if (num != 0)
				{
				}
				num = (short)754778113;
				if (num != 0)
				{
				}
				return this.<CMSCHostID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)597103564;
				short num2 = num;
				num = (short)951325644;
				switch (num2 == num)
				{
				}
				num = (short)1926365184;
				short num3 = num;
				num = (short)888012801;
				if (num != 0)
				{
				}
				num = (short)1260453888;
				if (num != 0)
				{
				}
				this.<CMSCHostID>k__BackingField = value;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00072988 File Offset: 0x00070B88
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x00072A34 File Offset: 0x00070C34
		[global::System.Runtime.Serialization.DataMember]
		public int CMSCRegisterQuantity
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1507248050;
				short num2 = num;
				num = (short)1886373810;
				switch (num2 == num)
				{
				}
				num = (short)1094975488;
				short num3 = num;
				num = (short)1353842689;
				if (num != 0)
				{
				}
				num = (short)1343619072;
				if (num != 0)
				{
				}
				return this.<CMSCRegisterQuantity>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)699608563;
				short num2 = num;
				num = (short)780348915;
				switch (num2 == num)
				{
				}
				num = (short)731578368;
				short num3 = num;
				num = (short)785907713;
				if (num != 0)
				{
				}
				num = (short)231145472;
				if (num != 0)
				{
				}
				this.<CMSCRegisterQuantity>k__BackingField = value;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x00072AE4 File Offset: 0x00070CE4
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x00072B94 File Offset: 0x00070D94
		[global::System.Runtime.Serialization.DataMember]
		public bool IsVisible
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1336524509;
				short num2 = num;
				num = (short)1598471901;
				switch (num2 == num)
				{
				}
				num = (short)2039611392;
				short num3 = num;
				num = (short)1398734849;
				if (num != 0)
				{
				}
				num = (short)598409216;
				if (num != 0)
				{
				}
				return this.<IsVisible>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1981994465;
				short num2 = num;
				num = (short)1543689697;
				switch (num2 == num)
				{
				}
				num = (short)780926976;
				short num3 = num;
				num = (short)1304166401;
				if (num != 0)
				{
				}
				num = (short)2026438656;
				if (num != 0)
				{
				}
				this.<IsVisible>k__BackingField = value;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x00072C48 File Offset: 0x00070E48
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x00072CFC File Offset: 0x00070EFC
		[global::System.Runtime.Serialization.DataMember]
		public string FeatureNotice
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)256348197;
				short num2 = num;
				num = (short)728338469;
				switch (num2 == num)
				{
				}
				num = (short)51642368;
				short num3 = num;
				num = (short)326238209;
				if (num != 0)
				{
				}
				num = (short)466354176;
				if (num != 0)
				{
				}
				return this.<FeatureNotice>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)153487314;
				short num2 = num;
				num = (short)1943406546;
				switch (num2 == num)
				{
				}
				num = (short)786366464;
				short num3 = num;
				num = (short)504561665;
				if (num != 0)
				{
				}
				num = (short)1742667776;
				if (num != 0)
				{
				}
				this.<FeatureNotice>k__BackingField = value;
			}
		}
	}
}
