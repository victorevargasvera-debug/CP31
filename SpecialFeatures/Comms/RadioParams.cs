using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.Common.Communication.CommonUtil;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Comms
{
	// Token: 0x02000158 RID: 344
	[global::System.Runtime.Serialization.DataContract]
	public class RadioParams
	{
		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x0600115C RID: 4444 RVA: 0x0017F19C File Offset: 0x0017D39C
		// (set) Token: 0x0600115D RID: 4445 RVA: 0x0017F248 File Offset: 0x0017D448
		public string SerialNumber
		{
			get
			{
				short num = (short)1345519616;
				short num2 = num;
				num = (short)644284810;
				short num3 = num;
				num = (short)1228276106;
				switch (num3 == num)
				{
				}
				num = (short)387776513;
				if (num != 0)
				{
				}
				num = (short)798556160;
				if (num != 0)
				{
				}
				return this.m_SerialNumber;
			}
			set
			{
				short num = (short)65536000;
				short num2 = num;
				num = (short)1216293203;
				short num3 = num;
				num = (short)73279827;
				switch (num3 == num)
				{
				}
				num = (short)230227968;
				if (num != 0)
				{
				}
				num = (short)1607335937;
				if (num != 0)
				{
				}
				this.m_SerialNumber = value;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x0017F2FC File Offset: 0x0017D4FC
		// (set) Token: 0x0600115F RID: 4447 RVA: 0x0017F3AC File Offset: 0x0017D5AC
		public byte[] ESerialNumber
		{
			get
			{
				short num = (short)1482686464;
				short num2 = num;
				num = (short)947478268;
				short num3 = num;
				num = (short)1783127804;
				switch (num3 == num)
				{
				}
				num = (short)1928134656;
				if (num != 0)
				{
				}
				num = (short)1916272641;
				if (num != 0)
				{
				}
				return this.m_ESerialNumber;
			}
			set
			{
				short num = (short)1881276416;
				short num2 = num;
				num = (short)1354496790;
				short num3 = num;
				num = (short)579926806;
				switch (num3 == num)
				{
				}
				num = (short)100728833;
				if (num != 0)
				{
				}
				num = (short)1673920512;
				if (num != 0)
				{
				}
				this.m_ESerialNumber = value;
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x0017F45C File Offset: 0x0017D65C
		// (set) Token: 0x06001161 RID: 4449 RVA: 0x0017F510 File Offset: 0x0017D710
		public string ModelNumber
		{
			get
			{
				short num = (short)338165761;
				if (num != 0)
				{
				}
				num = (short)1274006089;
				short num2 = num;
				num = (short)1725024841;
				switch (num2 == num)
				{
				}
				num = (short)878247936;
				if (num != 0)
				{
				}
				num = (short)1296367616;
				short num3 = num;
				return this.m_ModelNumber;
			}
			set
			{
				short num = (short)1081534314;
				short num2 = num;
				num = (short)1758324586;
				switch (num2 == num)
				{
				}
				num = (short)66387969;
				if (num != 0)
				{
				}
				num = (short)2004746240;
				if (num != 0)
				{
				}
				num = (short)593887232;
				short num3 = num;
				this.m_ModelNumber = value;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x0017F5C0 File Offset: 0x0017D7C0
		// (set) Token: 0x06001163 RID: 4451 RVA: 0x0017F670 File Offset: 0x0017D870
		public global::System.Guid Uuid
		{
			get
			{
				short num = (short)655236727;
				short num2 = num;
				num = (short)583671415;
				switch (num2 == num)
				{
				}
				num = (short)664469505;
				if (num != 0)
				{
				}
				num = (short)1310326784;
				if (num != 0)
				{
				}
				num = (short)1406730240;
				short num3 = num;
				return this.m_Uuid;
			}
			set
			{
				short num = (short)1854451212;
				short num2 = num;
				num = (short)13938188;
				switch (num2 == num)
				{
				}
				num = (short)11337729;
				if (num != 0)
				{
				}
				num = (short)1051066368;
				if (num != 0)
				{
				}
				num = (short)641400832;
				short num3 = num;
				this.m_Uuid = value;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x0017F724 File Offset: 0x0017D924
		// (set) Token: 0x06001165 RID: 4453 RVA: 0x0017F7D0 File Offset: 0x0017D9D0
		public string HostVersion
		{
			get
			{
				short num = (short)1160751252;
				short num2 = num;
				num = (short)1653909652;
				switch (num2 == num)
				{
				}
				num = (short)1459617793;
				if (num != 0)
				{
				}
				num = (short)1302462464;
				if (num != 0)
				{
				}
				num = (short)412286976;
				short num3 = num;
				return this.m_HostVersion;
			}
			set
			{
				short num = (short)770114466;
				short num2 = num;
				num = (short)946799522;
				switch (num2 == num)
				{
				}
				num = (short)1477312512;
				if (num != 0)
				{
				}
				num = (short)1296367617;
				if (num != 0)
				{
				}
				num = (short)1086259200;
				short num3 = num;
				this.m_HostVersion = value;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x0017F87C File Offset: 0x0017DA7C
		// (set) Token: 0x06001167 RID: 4455 RVA: 0x0017F92C File Offset: 0x0017DB2C
		public string RadioBBFSuiteVersion
		{
			get
			{
				short num = (short)1543858389;
				short num2 = num;
				num = (short)1968138453;
				switch (num2 == num)
				{
				}
				num = (short)394067968;
				if (num != 0)
				{
				}
				num = (short)1269760001;
				if (num != 0)
				{
				}
				num = (short)607911936;
				short num3 = num;
				return this.m_RadioBBFVersion;
			}
			set
			{
				short num = (short)409318963;
				short num2 = num;
				num = (short)809285171;
				switch (num2 == num)
				{
				}
				num = (short)1126432769;
				if (num != 0)
				{
				}
				num = (short)73465856;
				if (num != 0)
				{
				}
				num = (short)1514536960;
				short num3 = num;
				this.m_RadioBBFVersion = value;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x0017F9DC File Offset: 0x0017DBDC
		// (set) Token: 0x06001169 RID: 4457 RVA: 0x0017FA8C File Offset: 0x0017DC8C
		public string DspVersion
		{
			get
			{
				short num = (short)180019078;
				short num2 = num;
				num = (short)986374022;
				switch (num2 == num)
				{
				}
				num = (short)296026112;
				if (num != 0)
				{
				}
				num = (short)850526209;
				if (num != 0)
				{
				}
				num = (short)455344128;
				short num3 = num;
				return this.m_DspVersion;
			}
			set
			{
				short num = (short)1508406365;
				short num2 = num;
				num = (short)895448157;
				switch (num2 == num)
				{
				}
				num = (short)656998401;
				if (num != 0)
				{
				}
				num = (short)1796276224;
				if (num != 0)
				{
				}
				num = (short)299040768;
				short num3 = num;
				this.m_DspVersion = value;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x0017FB3C File Offset: 0x0017DD3C
		// (set) Token: 0x0600116B RID: 4459 RVA: 0x0017FBEC File Offset: 0x0017DDEC
		public string PsdtVersion
		{
			get
			{
				short num = (short)2008186836;
				short num2 = num;
				num = (short)327909332;
				switch (num2 == num)
				{
				}
				num = (short)597426177;
				if (num != 0)
				{
				}
				num = (short)757399552;
				if (num != 0)
				{
				}
				num = (short)2036858880;
				short num3 = num;
				return this.m_PsdtVersion;
			}
			set
			{
				short num = (short)954507953;
				short num2 = num;
				num = (short)612475569;
				switch (num2 == num)
				{
				}
				num = (short)369426432;
				if (num != 0)
				{
				}
				num = (short)660340737;
				if (num != 0)
				{
				}
				num = (short)982450176;
				short num3 = num;
				this.m_PsdtVersion = value;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x0017FC9C File Offset: 0x0017DE9C
		// (set) Token: 0x0600116D RID: 4461 RVA: 0x0017FD48 File Offset: 0x0017DF48
		public string BootAppVersion
		{
			get
			{
				short num = (short)1296095382;
				short num2 = num;
				num = (short)1977473174;
				switch (num2 == num)
				{
				}
				num = (short)2032861185;
				if (num != 0)
				{
				}
				num = (short)1988755456;
				if (num != 0)
				{
				}
				num = (short)1076428800;
				short num3 = num;
				return this.m_BootAppVersion;
			}
			set
			{
				short num = (short)622520305;
				short num2 = num;
				num = (short)933488625;
				switch (num2 == num)
				{
				}
				num = (short)1293352961;
				if (num != 0)
				{
				}
				num = (short)573898752;
				if (num != 0)
				{
				}
				num = (short)1978531840;
				short num3 = num;
				this.m_BootAppVersion = value;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x0017FDF8 File Offset: 0x0017DFF8
		// (set) Token: 0x0600116F RID: 4463 RVA: 0x0017FEA8 File Offset: 0x0017E0A8
		public string TuneVersion
		{
			get
			{
				short num = (short)651273260;
				short num2 = num;
				num = (short)1116185644;
				switch (num2 == num)
				{
				}
				num = (short)1318977537;
				if (num != 0)
				{
				}
				num = (short)1143341056;
				if (num != 0)
				{
				}
				num = (short)1989607424;
				short num3 = num;
				return this.m_TuneVersion;
			}
			set
			{
				short num = (short)1813866836;
				short num2 = num;
				num = (short)1795320148;
				switch (num2 == num)
				{
				}
				num = (short)86441985;
				if (num != 0)
				{
				}
				num = (short)1370292224;
				if (num != 0)
				{
				}
				num = (short)867172352;
				short num3 = num;
				this.m_TuneVersion = value;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001170 RID: 4464 RVA: 0x0017FF58 File Offset: 0x0017E158
		// (set) Token: 0x06001171 RID: 4465 RVA: 0x00180004 File Offset: 0x0017E204
		public string CodeplugVersion
		{
			get
			{
				short num = (short)1054906477;
				short num2 = num;
				num = (short)2043385965;
				switch (num2 == num)
				{
				}
				num = (short)1677983745;
				if (num != 0)
				{
				}
				num = (short)1697120256;
				if (num != 0)
				{
				}
				num = (short)778108928;
				short num3 = num;
				return this.m_CodeplugVersion;
			}
			set
			{
				short num = (short)92214860;
				short num2 = num;
				num = (short)253171276;
				switch (num2 == num)
				{
				}
				num = (short)144572417;
				if (num != 0)
				{
				}
				num = (short)1135673344;
				if (num != 0)
				{
				}
				num = (short)2008678400;
				short num3 = num;
				this.m_CodeplugVersion = value;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x001800B8 File Offset: 0x0017E2B8
		// (set) Token: 0x06001173 RID: 4467 RVA: 0x00180168 File Offset: 0x0017E368
		public string FlashCode
		{
			get
			{
				short num = (short)1440259473;
				short num2 = num;
				num = (short)2126159249;
				switch (num2 == num)
				{
				}
				num = (short)1981153281;
				if (num != 0)
				{
				}
				num = (short)1599275008;
				if (num != 0)
				{
				}
				num = (short)378798080;
				short num3 = num;
				return this.m_FlashCode;
			}
			set
			{
				short num = (short)1227274592;
				short num2 = num;
				num = (short)981317984;
				switch (num2 == num)
				{
				}
				num = (short)1275002881;
				if (num != 0)
				{
				}
				num = (short)727515136;
				if (num != 0)
				{
				}
				num = (short)1395523584;
				short num3 = num;
				this.m_FlashCode = value;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x00180218 File Offset: 0x0017E418
		// (set) Token: 0x06001175 RID: 4469 RVA: 0x001802C8 File Offset: 0x0017E4C8
		public string OptBoardName
		{
			get
			{
				short num = (short)784816020;
				short num2 = num;
				num = (short)59004820;
				switch (num2 == num)
				{
				}
				num = (short)1930100737;
				if (num != 0)
				{
				}
				num = (short)929890304;
				if (num != 0)
				{
				}
				num = (short)1106182144;
				short num3 = num;
				return this.m_OptBrdName;
			}
			set
			{
				short num = (short)669554055;
				short num2 = num;
				num = (short)606049671;
				switch (num2 == num)
				{
				}
				num = (short)1700134913;
				if (num != 0)
				{
				}
				num = (short)789053440;
				if (num != 0)
				{
				}
				num = (short)830144512;
				short num3 = num;
				this.m_OptBrdName = value;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001176 RID: 4470 RVA: 0x00180378 File Offset: 0x0017E578
		// (set) Token: 0x06001177 RID: 4471 RVA: 0x00180428 File Offset: 0x0017E628
		public string OptBrdHardwareType
		{
			get
			{
				short num = (short)1870351305;
				short num2 = num;
				num = (short)1077103561;
				switch (num2 == num)
				{
				}
				num = (short)666894337;
				if (num != 0)
				{
				}
				num = (short)805175296;
				if (num != 0)
				{
				}
				num = (short)1578696704;
				short num3 = num;
				return this.m_OptBrdHwType;
			}
			set
			{
				short num = (short)1231281287;
				short num2 = num;
				num = (short)1186847879;
				switch (num2 == num)
				{
				}
				num = (short)402653184;
				if (num != 0)
				{
				}
				num = (short)1936064513;
				if (num != 0)
				{
				}
				num = (short)2066743296;
				short num3 = num;
				this.m_OptBrdHwType = value;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001178 RID: 4472 RVA: 0x001804D8 File Offset: 0x0017E6D8
		// (set) Token: 0x06001179 RID: 4473 RVA: 0x00180588 File Offset: 0x0017E788
		public string OptBrdHwHostVersion
		{
			get
			{
				short num = (short)211786871;
				short num2 = num;
				num = (short)1443667063;
				switch (num2 == num)
				{
				}
				num = (short)372047873;
				if (num != 0)
				{
				}
				num = (short)285212672;
				if (num != 0)
				{
				}
				num = (short)2059272192;
				short num3 = num;
				return this.m_OptBrdHwHostVersion;
			}
			set
			{
				short num = (short)1214769875;
				short num2 = num;
				num = (short)861334227;
				switch (num2 == num)
				{
				}
				num = (short)372572161;
				if (num != 0)
				{
				}
				num = (short)1135738880;
				if (num != 0)
				{
				}
				num = (short)1025376256;
				short num3 = num;
				this.m_OptBrdHwHostVersion = value;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x00180638 File Offset: 0x0017E838
		// (set) Token: 0x0600117B RID: 4475 RVA: 0x001806E8 File Offset: 0x0017E8E8
		public string LTEOptBrdHwHostVersion
		{
			get
			{
				short num = (short)1480684244;
				short num2 = num;
				num = (short)597652180;
				switch (num2 == num)
				{
				}
				num = (short)1990131712;
				if (num != 0)
				{
				}
				num = (short)1706491905;
				if (num != 0)
				{
				}
				num = (short)70909952;
				short num3 = num;
				return this.m_LTEOptBrdHwHostVersion;
			}
			set
			{
				short num = (short)1188298753;
				if (num != 0)
				{
				}
				num = (short)56301872;
				short num2 = num;
				num = (short)1569200432;
				switch (num2 == num)
				{
				}
				num = (short)418185216;
				if (num != 0)
				{
				}
				num = (short)1298530304;
				short num3 = num;
				this.m_LTEOptBrdHwHostVersion = value;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x0600117C RID: 4476 RVA: 0x0018079C File Offset: 0x0017E99C
		// (set) Token: 0x0600117D RID: 4477 RVA: 0x0018084C File Offset: 0x0017EA4C
		public string OptBrdFlashImageVersion
		{
			get
			{
				short num = (short)735313921;
				if (num != 0)
				{
				}
				num = (short)709214812;
				short num2 = num;
				num = (short)1430569564;
				switch (num2 == num)
				{
				}
				num = (short)1592131584;
				if (num != 0)
				{
				}
				num = (short)1086193664;
				short num3 = num;
				return this.m_OptBrdFlashImageVersion;
			}
			set
			{
				short num = (short)813709414;
				short num2 = num;
				num = (short)1528445030;
				switch (num2 == num)
				{
				}
				num = (short)789118977;
				if (num != 0)
				{
				}
				num = (short)2137194496;
				if (num != 0)
				{
				}
				num = (short)1955004416;
				short num3 = num;
				this.m_OptBrdFlashImageVersion = value;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x001808FC File Offset: 0x0017EAFC
		// (set) Token: 0x0600117F RID: 4479 RVA: 0x001809A8 File Offset: 0x0017EBA8
		public string OptBrdFlashImageType
		{
			get
			{
				short num = (short)616429467;
				short num2 = num;
				num = (short)492107675;
				switch (num2 == num)
				{
				}
				num = (short)1469382657;
				if (num != 0)
				{
				}
				num = (short)1593507840;
				if (num != 0)
				{
				}
				num = (short)301203456;
				short num3 = num;
				return this.m_OptBrdFlashImageType;
			}
			set
			{
				short num = (short)985168856;
				short num2 = num;
				num = (short)314276824;
				switch (num2 == num)
				{
				}
				num = (short)563675137;
				if (num != 0)
				{
				}
				num = (short)11468800;
				if (num != 0)
				{
				}
				num = (short)136970240;
				short num3 = num;
				this.m_OptBrdFlashImageType = value;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x00180A58 File Offset: 0x0017EC58
		// (set) Token: 0x06001181 RID: 4481 RVA: 0x00180B08 File Offset: 0x0017ED08
		public bool OptBrdHwNotPresentFlag
		{
			get
			{
				short num = (short)1294044646;
				short num2 = num;
				num = (short)2144832998;
				switch (num2 == num)
				{
				}
				num = (short)1272315905;
				if (num != 0)
				{
				}
				num = (short)1111621632;
				if (num != 0)
				{
				}
				num = (short)670302208;
				short num3 = num;
				return this.m_OptBrdHwNotPresentFlag;
			}
			set
			{
				short num = (short)1386834122;
				short num2 = num;
				num = (short)1637640394;
				switch (num2 == num)
				{
				}
				num = (short)1723727873;
				if (num != 0)
				{
				}
				num = (short)959381504;
				if (num != 0)
				{
				}
				num = (short)1177288704;
				short num3 = num;
				this.m_OptBrdHwNotPresentFlag = value;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001182 RID: 4482 RVA: 0x00180BBC File Offset: 0x0017EDBC
		// (set) Token: 0x06001183 RID: 4483 RVA: 0x00180C6C File Offset: 0x0017EE6C
		public string ConBrdHardwareType
		{
			get
			{
				short num = (short)664175081;
				short num2 = num;
				num = (short)1676050921;
				switch (num2 == num)
				{
				}
				num = (short)294125569;
				if (num != 0)
				{
				}
				num = (short)1519648768;
				if (num != 0)
				{
				}
				num = (short)1273102336;
				short num3 = num;
				return this.m_ConBrdHwType;
			}
			set
			{
				short num = (short)2049706208;
				short num2 = num;
				num = (short)1914308832;
				switch (num2 == num)
				{
				}
				num = (short)364380161;
				if (num != 0)
				{
				}
				num = (short)1238433792;
				if (num != 0)
				{
				}
				num = (short)1899298816;
				short num3 = num;
				this.m_ConBrdHwType = value;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001184 RID: 4484 RVA: 0x00180D1C File Offset: 0x0017EF1C
		// (set) Token: 0x06001185 RID: 4485 RVA: 0x00180DCC File Offset: 0x0017EFCC
		public string ConBrdHwHostVersion
		{
			get
			{
				short num = (short)1879554862;
				short num2 = num;
				num = (short)1048099630;
				switch (num2 == num)
				{
				}
				num = (short)561184769;
				if (num != 0)
				{
				}
				num = (short)1269170176;
				if (num != 0)
				{
				}
				num = (short)688717824;
				short num3 = num;
				return this.m_ConBrdHwHostVersion;
			}
			set
			{
				short num = (short)471039777;
				short num2 = num;
				num = (short)451378977;
				switch (num2 == num)
				{
				}
				num = (short)403111937;
				if (num != 0)
				{
				}
				num = (short)2073100288;
				if (num != 0)
				{
				}
				num = (short)1731919872;
				short num3 = num;
				this.m_ConBrdHwHostVersion = value;
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001186 RID: 4486 RVA: 0x00180E7C File Offset: 0x0017F07C
		// (set) Token: 0x06001187 RID: 4487 RVA: 0x00180F2C File Offset: 0x0017F12C
		public string MaceFlashVersion
		{
			get
			{
				short num = (short)309047396;
				short num2 = num;
				num = (short)233812068;
				switch (num2 == num)
				{
				}
				num = (short)1288568832;
				if (num != 0)
				{
				}
				num = (short)365297665;
				if (num != 0)
				{
				}
				num = (short)1069350912;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)1017126446;
				short num2 = num;
				num = (short)1525554734;
				switch (num2 == num)
				{
				}
				num = (short)236781569;
				if (num != 0)
				{
				}
				num = (short)1384906752;
				if (num != 0)
				{
				}
				num = (short)1583480832;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x00180FD8 File Offset: 0x0017F1D8
		// (set) Token: 0x06001189 RID: 4489 RVA: 0x00181088 File Offset: 0x0017F288
		internal string MaceHardwareType
		{
			get
			{
				short num = (short)301031750;
				short num2 = num;
				num = (short)532570438;
				switch (num2 == num)
				{
				}
				num = (short)1213726721;
				if (num != 0)
				{
				}
				num = (short)1009385472;
				if (num != 0)
				{
				}
				num = (short)680656896;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)2096869152;
				short num2 = num;
				num = (short)508538656;
				switch (num2 == num)
				{
				}
				num = (short)1256259584;
				if (num != 0)
				{
				}
				num = (short)1913323521;
				if (num != 0)
				{
				}
				num = (short)22347776;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x00181138 File Offset: 0x0017F338
		// (set) Token: 0x0600118B RID: 4491 RVA: 0x001811E8 File Offset: 0x0017F3E8
		internal string MaceHardwareVersion
		{
			get
			{
				short num = (short)545471455;
				short num2 = num;
				num = (short)1335573471;
				switch (num2 == num)
				{
				}
				num = (short)1252655104;
				if (num != 0)
				{
				}
				num = (short)1282932737;
				if (num != 0)
				{
				}
				num = (short)1483145216;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)1770782834;
				short num2 = num;
				num = (short)2045313138;
				switch (num2 == num)
				{
				}
				num = (short)1923612673;
				if (num != 0)
				{
				}
				num = (short)425066496;
				if (num != 0)
				{
				}
				num = (short)900071424;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x0018129C File Offset: 0x0017F49C
		public override string ToString()
		{
			int a_ = 13;
			short num = (short)1016960486;
			short num2 = num;
			num = (short)1895667174;
			switch (num2 == num)
			{
			}
			num = (short)709099520;
			if (num != 0)
			{
			}
			num = (short)204996609;
			if (num != 0)
			{
			}
			num = (short)1631977472;
			short num3 = num;
			return string.Format(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슏ﾕ쪙ﶛ솟쾡힣躥ﮧ쾩\udeab잭톯\udeb1荒쎵햷\ud8b9\ud9bb첽謹링믅臋ꇍ듏럑룓飕귗럙뻛믝鋟\ud8e1鿣ퟥ闧웩쳫믭ꗯ믱냳쳵菷죹臻틽⃿䨁欃甅簇尉椋簍挏笑笓砕∗愙⼛挝టȡ怣唥堧簩䤫尭䌯嬱嬳堵ȷ䄹࠻䌽氿扁݃⥅ⱇ⽉㱋≍╏㕑ɓ㍕⩗⥙㕛ㅝ๟塡呣ṥ፧彩ᅫ䝭", a_), new object[]
			{
				this.SerialNumber,
				this.ModelNumber,
				this.Uuid,
				this.HostVersion,
				this.DspVersion,
				this.CodeplugVersion
			});
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x001813A0 File Offset: 0x0017F5A0
		// (set) Token: 0x0600118E RID: 4494 RVA: 0x0018144C File Offset: 0x0017F64C
		public global::Motorola.Common.Communication.CommonUtil.ProductFamily Family
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1118204755;
				short num2 = num;
				num = (short)1653896019;
				switch (num2 == num)
				{
				}
				num = (short)723714049;
				if (num != 0)
				{
				}
				num = (short)25296896;
				if (num != 0)
				{
				}
				num = (short)1837826048;
				short num3 = num;
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1514375316;
				short num2 = num;
				num = (short)564365460;
				switch (num2 == num)
				{
				}
				num = (short)365166592;
				if (num != 0)
				{
				}
				num = (short)1896415233;
				if (num != 0)
				{
				}
				num = (short)1605959680;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x001814FC File Offset: 0x0017F6FC
		// (set) Token: 0x06001190 RID: 4496 RVA: 0x001815AC File Offset: 0x0017F7AC
		public global::Motorola.Common.Communication.CommonUtil.ConnectionInfo ConnectionInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1171235377;
				short num2 = num;
				num = (short)1458414129;
				switch (num2 == num)
				{
				}
				num = (short)2012610561;
				if (num != 0)
				{
				}
				num = (short)1170276352;
				if (num != 0)
				{
				}
				num = (short)683606016;
				short num3 = num;
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)846818505;
				short num2 = num;
				num = (short)1442671817;
				switch (num2 == num)
				{
				}
				num = (short)1507852289;
				if (num != 0)
				{
				}
				num = (short)1226833920;
				if (num != 0)
				{
				}
				num = (short)2065301504;
				short num3 = num;
				this.e = value;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x0018165C File Offset: 0x0017F85C
		// (set) Token: 0x06001192 RID: 4498 RVA: 0x00181708 File Offset: 0x0017F908
		public string RadioID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)282248964;
				short num2 = num;
				num = (short)1942800132;
				switch (num2 == num)
				{
				}
				num = (short)782893057;
				if (num != 0)
				{
				}
				num = (short)1632108544;
				if (num != 0)
				{
				}
				num = (short)730923008;
				short num3 = num;
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)73958077;
				short num2 = num;
				num = (short)1281000125;
				switch (num2 == num)
				{
				}
				num = (short)1753088000;
				if (num != 0)
				{
				}
				num = (short)139198465;
				if (num != 0)
				{
				}
				num = (short)273612800;
				short num3 = num;
				this.f = value;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x001817B8 File Offset: 0x0017F9B8
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x00181868 File Offset: 0x0017FA68
		public global::Motorola.Common.Communication.CommonUtil.RadioState RadioState
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1179380542;
				short num2 = num;
				num = (short)598207294;
				switch (num2 == num)
				{
				}
				num = (short)1900150784;
				if (num != 0)
				{
				}
				num = (short)1220935680;
				short num3 = num;
				num = (short)1945960449;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)778668994;
				short num2 = num;
				num = (short)621710274;
				switch (num2 == num)
				{
				}
				num = (short)58130433;
				if (num != 0)
				{
				}
				num = (short)86573056;
				short num3 = num;
				num = (short)262733824;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x0018191C File Offset: 0x0017FB1C
		// (set) Token: 0x06001196 RID: 4502 RVA: 0x001819CC File Offset: 0x0017FBCC
		public global::Motorola.Common.Communication.CommonUtil.RadioStorage RadioStorage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2047255964;
				short num2 = num;
				num = (short)798533020;
				switch (num2 == num)
				{
				}
				num = (short)1293680641;
				if (num != 0)
				{
				}
				num = (short)521601024;
				short num3 = num;
				num = (short)434765824;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1447601026;
				short num2 = num;
				num = (short)968467330;
				switch (num2 == num)
				{
				}
				num = (short)78970880;
				if (num != 0)
				{
				}
				num = (short)414253056;
				short num3 = num;
				num = (short)1796997121;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x0400095A RID: 2394
		[global::System.Runtime.Serialization.DataMember]
		private string m_SerialNumber;

		// Token: 0x0400095B RID: 2395
		[global::System.Runtime.Serialization.DataMember]
		private byte[] m_ESerialNumber;

		// Token: 0x0400095C RID: 2396
		[global::System.Runtime.Serialization.DataMember]
		private string m_ModelNumber;

		// Token: 0x0400095D RID: 2397
		[global::System.Runtime.Serialization.DataMember]
		private global::System.Guid m_Uuid;

		// Token: 0x0400095E RID: 2398
		[global::System.Runtime.Serialization.DataMember]
		private string m_RadioBBFVersion;

		// Token: 0x0400095F RID: 2399
		[global::System.Runtime.Serialization.DataMember]
		private string m_HostVersion;

		// Token: 0x04000960 RID: 2400
		[global::System.Runtime.Serialization.DataMember]
		private string m_DspVersion;

		// Token: 0x04000961 RID: 2401
		[global::System.Runtime.Serialization.DataMember]
		private string m_CodeplugVersion;

		// Token: 0x04000962 RID: 2402
		[global::System.Runtime.Serialization.DataMember]
		private string m_PsdtVersion;

		// Token: 0x04000963 RID: 2403
		[global::System.Runtime.Serialization.DataMember]
		private string m_BootAppVersion;

		// Token: 0x04000964 RID: 2404
		[global::System.Runtime.Serialization.DataMember]
		private string m_TuneVersion;

		// Token: 0x04000965 RID: 2405
		[global::System.Runtime.Serialization.DataMember]
		private string m_FlashCode;

		// Token: 0x04000966 RID: 2406
		[global::System.Runtime.Serialization.DataMember]
		private string m_OptBrdName;

		// Token: 0x04000967 RID: 2407
		[global::System.Runtime.Serialization.DataMember]
		private string m_OptBrdHwType;

		// Token: 0x04000968 RID: 2408
		[global::System.Runtime.Serialization.DataMember]
		private string m_OptBrdHwHostVersion;

		// Token: 0x04000969 RID: 2409
		[global::System.Runtime.Serialization.DataMember]
		private string m_LTEOptBrdHwHostVersion;

		// Token: 0x0400096A RID: 2410
		[global::System.Runtime.Serialization.DataMember]
		private string m_OptBrdFlashImageVersion;

		// Token: 0x0400096B RID: 2411
		[global::System.Runtime.Serialization.DataMember]
		private string m_OptBrdFlashImageType;

		// Token: 0x0400096C RID: 2412
		[global::System.Runtime.Serialization.DataMember]
		private bool m_OptBrdHwNotPresentFlag;

		// Token: 0x0400096D RID: 2413
		[global::System.Runtime.Serialization.DataMember]
		private string m_ConBrdHwType;

		// Token: 0x0400096E RID: 2414
		[global::System.Runtime.Serialization.DataMember]
		private string m_ConBrdHwHostVersion;

		// Token: 0x0400096F RID: 2415
		private string a;

		// Token: 0x04000970 RID: 2416
		private string b;

		// Token: 0x04000971 RID: 2417
		private string c;

		// Token: 0x04000972 RID: 2418
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.CommonUtil.ProductFamily d;

		// Token: 0x04000973 RID: 2419
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.CommonUtil.ConnectionInfo e;

		// Token: 0x04000974 RID: 2420
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string f;

		// Token: 0x04000975 RID: 2421
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.CommonUtil.RadioState g;

		// Token: 0x04000976 RID: 2422
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.CommonUtil.RadioStorage h;
	}
}
