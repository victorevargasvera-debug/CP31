using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Services.Package;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000047 RID: 71
	public class ServiceContainer : global::Motorola.CommonCPS.RadioManagement.SharedServices.IServiceContainer
	{
		// Token: 0x0600062A RID: 1578 RVA: 0x0003C3D4 File Offset: 0x0003A5D4
		private ServiceContainer()
		{
			this.a = new global::System.Lazy<global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.ServiceContainerBase>(delegate()
			{
				short num = (short)73544176;
				short num2 = num;
				num = (short)1613181424;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1943470080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)832634881;
				if (num != 0)
				{
				}
				num = (short)1960116224;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.AstroServiceContainer();
			});
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x0003C418 File Offset: 0x0003A618
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.ServiceContainerBase Service
		{
			get
			{
				short num = (short)811676834;
				short num2 = num;
				num = (short)1634153634;
				switch (num2 == num)
				{
				}
				num = (short)1895432192;
				if (num != 0)
				{
				}
				num = (short)1402535937;
				if (num != 0)
				{
				}
				num = (short)1363345408;
				short num3 = num;
				return this.a.Value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x0003C4CC File Offset: 0x0003A6CC
		public static global::Motorola.CommonCPS.RadioManagement.SharedServices.IServiceContainer Instance
		{
			get
			{
				short num = (short)1450465237;
				short num2 = num;
				num = (short)521361365;
				switch (num2 == num)
				{
				}
				num = (short)1332805632;
				if (num != 0)
				{
				}
				num = (short)915931137;
				if (num != 0)
				{
				}
				num = (short)1740701696;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer();
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x0003C57C File Offset: 0x0003A77C
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IDataProviderService DataProviderService
		{
			get
			{
				short num = (short)904039867;
				short num2 = num;
				num = (short)584486331;
				switch (num2 == num)
				{
				}
				num = (short)1374027776;
				if (num != 0)
				{
				}
				num = (short)1070530561;
				if (num != 0)
				{
				}
				num = (short)1418526720;
				short num3 = num;
				return this.Service.DataProviderService;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x0003C630 File Offset: 0x0003A830
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IGroupService GroupService
		{
			get
			{
				short num = (short)1918042113;
				if (num != 0)
				{
				}
				num = (short)431220073;
				short num2 = num;
				num = (short)1343808873;
				switch (num2 == num)
				{
				}
				num = (short)799735808;
				if (num != 0)
				{
				}
				num = (short)1290403840;
				short num3 = num;
				return this.Service.GroupService;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x0003C6E8 File Offset: 0x0003A8E8
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IDBMigrationService DbMigrationService
		{
			get
			{
				short num = (short)943915009;
				if (num != 0)
				{
				}
				num = (short)186087345;
				short num2 = num;
				num = (short)878802865;
				switch (num2 == num)
				{
				}
				num = (short)1436483584;
				if (num != 0)
				{
				}
				num = (short)2047803392;
				short num3 = num;
				return this.Service.DbMigrationService;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x0003C798 File Offset: 0x0003A998
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IPackageManagementService PackageManagementService
		{
			get
			{
				short num = (short)357761025;
				if (num != 0)
				{
				}
				num = (short)2042167296;
				short num2 = num;
				num = (short)821649658;
				short num3 = num;
				num = (short)1435132154;
				switch (num3 == num)
				{
				}
				num = (short)1469906944;
				if (num != 0)
				{
				}
				return this.Service.GetPackageManagementService(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.None);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x0003C84C File Offset: 0x0003AA4C
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService RadioService
		{
			get
			{
				short num = (short)881363305;
				short num2 = num;
				num = (short)382175593;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1155334144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)126615553;
				if (num != 0)
				{
				}
				num = (short)2081619968;
				if (num != 0)
				{
				}
				return this.Service.GetRadioService();
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x0003C904 File Offset: 0x0003AB04
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioDetailService RadioDetailService
		{
			get
			{
				short num = (short)1512045650;
				short num2 = num;
				num = (short)1722022994;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1158742016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)733020161;
				if (num != 0)
				{
				}
				num = (short)1430781952;
				if (num != 0)
				{
				}
				return this.Service.GetRadioDetailService();
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x0003C9B8 File Offset: 0x0003ABB8
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService TemplateService
		{
			get
			{
				short num = (short)1803532202;
				short num2 = num;
				num = (short)802469802;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1031340032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)166461441;
				if (num != 0)
				{
				}
				num = (short)340918272;
				if (num != 0)
				{
				}
				return this.Service.GetTemplateService();
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x0003CA6C File Offset: 0x0003AC6C
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IValidationServiceBase ValidationService
		{
			get
			{
				short num = (short)2039970686;
				short num2 = num;
				num = (short)508328830;
				switch (num2 == num)
				{
				default:
				{
					num = (short)993918976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1668677633;
				if (num != 0)
				{
				}
				num = (short)914882560;
				if (num != 0)
				{
				}
				return this.Service.GetValidationService();
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x0003CB24 File Offset: 0x0003AD24
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRODataProfileService AstroDataProfileService
		{
			get
			{
				short num = (short)1896320517;
				short num2 = num;
				num = (short)1691127301;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1313800192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1584398336;
				if (num != 0)
				{
				}
				num = (short)438829057;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.AstroServiceContainer astroServiceContainer = this.Service as global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.AstroServiceContainer;
				if (astroServiceContainer == null)
				{
					return null;
				}
				return astroServiceContainer.AstroDataProfileService;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x0003CBE4 File Offset: 0x0003ADE4
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROSystemService AstroSystemService
		{
			get
			{
				short num = (short)97549254;
				short num2 = num;
				num = (short)1062173638;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1445920768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)177799168;
				if (num != 0)
				{
				}
				num = (short)620298241;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.AstroServiceContainer astroServiceContainer = this.Service as global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.AstroServiceContainer;
				if (astroServiceContainer == null)
				{
					return null;
				}
				return astroServiceContainer.AstroSystemService;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x0003CCA8 File Offset: 0x0003AEA8
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROOTARProfileService AstroOTARProfileService
		{
			get
			{
				short num = (short)2019617791;
				short num2 = num;
				num = (short)343534591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)485490688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1030356993;
				if (num != 0)
				{
				}
				num = (short)1752825856;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.AstroServiceContainer astroServiceContainer = this.Service as global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.AstroServiceContainer;
				if (astroServiceContainer == null)
				{
					return null;
				}
				return astroServiceContainer.AstroOTARProfileService;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x0003CD6C File Offset: 0x0003AF6C
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioLicenseService RadioLicenseService
		{
			get
			{
				short num = (short)250392988;
				short num2 = num;
				num = (short)1787474332;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1226702848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)920125441;
				if (num != 0)
				{
				}
				num = (short)1756168192;
				if (num != 0)
				{
				}
				return this.Service.GetRadioLicenseService();
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x0003CE20 File Offset: 0x0003B020
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.ILicenseService AppLicenseService
		{
			get
			{
				short num = (short)1023695510;
				short num2 = num;
				num = (short)1058298518;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1788739584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1490747393;
				if (num != 0)
				{
				}
				num = (short)1463746560;
				if (num != 0)
				{
				}
				return this.Service.GetAppLicenseService();
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x0003CED4 File Offset: 0x0003B0D4
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IManageRadioLicenseService ManageRadioLicenseService
		{
			get
			{
				short num = (short)1822344121;
				short num2 = num;
				num = (short)1719780281;
				switch (num2 == num)
				{
				default:
				{
					num = (short)684916736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1800536065;
				if (num != 0)
				{
				}
				num = (short)942735360;
				if (num != 0)
				{
				}
				return this.Service.GetManageRadioLicenseService();
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x0003CF88 File Offset: 0x0003B188
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceOperation DeviceOperation
		{
			get
			{
				short num = (short)203227137;
				if (num != 0)
				{
				}
				num = (short)1930756096;
				short num2 = num;
				num = (short)1553685640;
				short num3 = num;
				num = (short)1203133576;
				switch (num3 == num)
				{
				}
				num = (short)2045706240;
				if (num != 0)
				{
				}
				return this.Service.DeviceOperation;
			}
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0003D03C File Offset: 0x0003B23C
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IPackageManagementService GetPackageManagementService(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.None)
		{
			short num = (short)997519746;
			short num2 = num;
			num = (short)691466626;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1361182720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)712900609;
			if (num != 0)
			{
			}
			num = (short)694026240;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.AstroServiceContainer astroServiceContainer = this.Service as global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.AstroServiceContainer;
			if (astroServiceContainer == null)
			{
				return null;
			}
			return astroServiceContainer.GetPackageManagementService(productFamily);
		}

		// Token: 0x04000065 RID: 101
		private global::System.Lazy<global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.ServiceContainerBase> a;

		// Token: 0x02000048 RID: 72
		private abstract class ServiceContainerBase
		{
			// Token: 0x0600063D RID: 1597 RVA: 0x0003D100 File Offset: 0x0003B300
			public ServiceContainerBase()
			{
				this.serverAccessor = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false);
				this.deviceOperation = new global::Motorola.CommonCPS.RadioManagement.SharedServices.TemplateDeviceOperation();
				this.packageManagementServices = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily, global::Motorola.CommonCPS.RadioManagement.SharedServices.IPackageManagementService>();
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x0600063E RID: 1598 RVA: 0x0003D138 File Offset: 0x0003B338
			public global::Motorola.CommonCPS.RadioManagement.SharedServices.IDataProviderService DataProviderService
			{
				get
				{
					if (this.a == null)
					{
						short num = (short)1116930049;
						if (num != 0)
						{
						}
						num = (short)948947431;
						short num2 = num;
						num = (short)1414121959;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)180617216;
							if (num != 0)
							{
							}
							num = (short)914423808;
							short num3 = num;
							return this.a = new global::Motorola.CommonCPS.RadioManagement.SharedServices.DataProviderService();
						}
						}
					}
					return this.a;
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x0600063F RID: 1599 RVA: 0x0003D204 File Offset: 0x0003B404
			public global::Motorola.CommonCPS.RadioManagement.SharedServices.IGroupService GroupService
			{
				get
				{
					if (this.groupService == null)
					{
						short num = (short)1911554049;
						if (num != 0)
						{
						}
						num = (short)775716683;
						short num2 = num;
						num = (short)17727307;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)905117696;
							if (num != 0)
							{
							}
							num = (short)1733820416;
							short num3 = num;
							return this.groupService = new global::Motorola.CommonCPS.RadioManagement.SharedServices.GroupService(this.serverAccessor);
						}
						}
					}
					return this.groupService;
				}
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x06000640 RID: 1600 RVA: 0x0003D2D4 File Offset: 0x0003B4D4
			public global::Motorola.CommonCPS.RadioManagement.SharedServices.IDBMigrationService DbMigrationService
			{
				get
				{
					if (this.dbMigrationService == null)
					{
						short num = (short)2064178625;
						short num2 = num;
						num = (short)1008131521;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1514995712;
							if (num != 0)
							{
							}
							num = (short)590544897;
							if (num != 0)
							{
							}
							num = (short)50200576;
							short num3 = num;
							return this.dbMigrationService = new global::Motorola.CommonCPS.RadioManagement.SharedServices.DBMigrationService(this.serverAccessor);
						}
						}
					}
					return this.dbMigrationService;
				}
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x06000641 RID: 1601 RVA: 0x0003D3A8 File Offset: 0x0003B5A8
			public global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceOperation DeviceOperation
			{
				get
				{
					short num = (short)1738575944;
					short num2 = num;
					num = (short)1494978632;
					switch (num2 == num)
					{
					default:
					{
						num = (short)1641807872;
						short num3 = num;
						break;
					}
					case true:
						break;
					}
					num = (short)2028011520;
					if (num != 0)
					{
					}
					num = (short)505544705;
					if (num != 0)
					{
					}
					return this.deviceOperation;
				}
			}

			// Token: 0x06000642 RID: 1602
			public abstract global::Motorola.CommonCPS.RadioManagement.SharedServices.ILicenseService GetAppLicenseService();

			// Token: 0x06000643 RID: 1603
			public abstract global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService GetRadioService();

			// Token: 0x06000644 RID: 1604
			public abstract global::Motorola.CommonCPS.RadioManagement.SharedServices.IPackageManagementService GetPackageManagementService(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.None);

			// Token: 0x06000645 RID: 1605
			public abstract global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioDetailService GetRadioDetailService();

			// Token: 0x06000646 RID: 1606
			public abstract global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService GetTemplateService();

			// Token: 0x06000647 RID: 1607
			public abstract global::Motorola.CommonCPS.RadioManagement.SharedServices.IValidationServiceBase GetValidationService();

			// Token: 0x06000648 RID: 1608
			public abstract global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioLicenseService GetRadioLicenseService();

			// Token: 0x06000649 RID: 1609
			public abstract global::Motorola.CommonCPS.RadioManagement.SharedServices.IManageRadioLicenseService GetManageRadioLicenseService();

			// Token: 0x04000066 RID: 102
			protected global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor;

			// Token: 0x04000067 RID: 103
			protected global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService;

			// Token: 0x04000068 RID: 104
			protected global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioDetailService radioDetailService;

			// Token: 0x04000069 RID: 105
			protected global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService templateService;

			// Token: 0x0400006A RID: 106
			protected global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily, global::Motorola.CommonCPS.RadioManagement.SharedServices.IPackageManagementService> packageManagementServices;

			// Token: 0x0400006B RID: 107
			protected global::Motorola.CommonCPS.RadioManagement.SharedServices.IValidationServiceBase validationService;

			// Token: 0x0400006C RID: 108
			protected global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioLicenseService radioLicenseService;

			// Token: 0x0400006D RID: 109
			protected global::Motorola.CommonCPS.RadioManagement.SharedServices.IManageRadioLicenseService manageRadioLicenseService;

			// Token: 0x0400006E RID: 110
			protected global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceOperation deviceOperation;

			// Token: 0x0400006F RID: 111
			protected global::Motorola.CommonCPS.RadioManagement.SharedServices.ILicenseService licenseService;

			// Token: 0x04000070 RID: 112
			protected global::Motorola.CommonCPS.RadioManagement.SharedServices.IGroupService groupService;

			// Token: 0x04000071 RID: 113
			protected global::Motorola.CommonCPS.RadioManagement.SharedServices.IDBMigrationService dbMigrationService;

			// Token: 0x04000072 RID: 114
			private global::Motorola.CommonCPS.RadioManagement.SharedServices.IDataProviderService a;
		}

		// Token: 0x02000049 RID: 73
		private class AstroServiceContainer : global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.ServiceContainerBase
		{
			// Token: 0x0600064A RID: 1610 RVA: 0x0003D458 File Offset: 0x0003B658
			public override global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService GetRadioService()
			{
				short num = (short)436469761;
				if (num != 0)
				{
				}
				if (this.radioService == null)
				{
					num = (short)1253424215;
					short num2 = num;
					num = (short)320322647;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1479540736;
						if (num != 0)
						{
						}
						num = (short)2111307776;
						short num3 = num;
						return this.radioService = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTRORadioService(this.serverAccessor, this.GetValidationService() as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService, this.GetTemplateService() as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROTemplateService);
					}
					}
				}
				return this.radioService;
			}

			// Token: 0x0600064B RID: 1611 RVA: 0x0003D540 File Offset: 0x0003B740
			public override global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioDetailService GetRadioDetailService()
			{
				if (this.radioDetailService == null)
				{
					short num = (short)1573733117;
					short num2 = num;
					num = (short)371933949;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1569718272;
						if (num != 0)
						{
						}
						num = (short)1227882497;
						if (num != 0)
						{
						}
						num = (short)822411264;
						short num3 = num;
						return this.radioDetailService = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTRORadioDetailService(this.serverAccessor, this.GetValidationService() as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService);
					}
					}
				}
				return this.radioDetailService;
			}

			// Token: 0x0600064C RID: 1612 RVA: 0x0003D620 File Offset: 0x0003B820
			public override global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService GetTemplateService()
			{
				short num;
				if (this.templateService == null)
				{
					num = (short)593877076;
					short num2 = num;
					num = (short)1156438100;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1504313344;
						if (num != 0)
						{
						}
						return this.templateService = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROTemplateService(this.serverAccessor, this.GetValidationService() as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService);
					}
				}
				num = (short)1314193408;
				short num3 = num;
				num = (short)641925121;
				if (num != 0)
				{
				}
				return this.templateService;
			}

			// Token: 0x0600064D RID: 1613 RVA: 0x0003D6F8 File Offset: 0x0003B8F8
			public override global::Motorola.CommonCPS.RadioManagement.SharedServices.IValidationServiceBase GetValidationService()
			{
				short num = (short)102563841;
				if (num != 0)
				{
				}
				if (this.validationService == null)
				{
					num = (short)1787440760;
					short num2 = num;
					num = (short)550907512;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)312279040;
						if (num != 0)
						{
						}
						num = (short)1296891904;
						short num3 = num;
						return this.validationService = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROValidationService(this.serverAccessor);
					}
					}
				}
				return this.validationService;
			}

			// Token: 0x0600064E RID: 1614 RVA: 0x0003D7CC File Offset: 0x0003B9CC
			public override global::Motorola.CommonCPS.RadioManagement.SharedServices.IPackageManagementService GetPackageManagementService(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.None)
			{
				short num = (short)571015170;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.CommonCPS.RadioManagement.SharedServices.IPackageManagementService packageManagementService;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (this.packageManagementServices.TryGetValue(productFamily, out packageManagementService))
						{
							return packageManagementService;
						}
						num = (short)1010825645;
						short num3 = num;
						num = (short)303167917;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16E;
						default:
							num = (short)643694592;
							if (num != 0)
							{
							}
							num = (short)454426625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						packageManagementService = this.a(productFamily);
						this.packageManagementServices.Add(productFamily, packageManagementService);
						num = (short)443416581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 3:
						goto IL_AE;
					case 4:
						productFamily = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ProductFamily;
						goto IL_16E;
					case 5:
						goto IL_82;
					}
					IL_3C:
					if (productFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.None)
					{
						num = (short)583598084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AE:
					num = (short)1494745088;
					short num4 = num;
					num = (short)2087845888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16E:
					num = (short)1005518851;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_82:
				num = (short)674758657;
				if (num != 0)
				{
				}
				return packageManagementService;
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x0600064F RID: 1615 RVA: 0x0003D968 File Offset: 0x0003BB68
			public global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRODataProfileService AstroDataProfileService
			{
				get
				{
					if (this.a == null)
					{
						short num = (short)764806463;
						short num2 = num;
						num = (short)1625752895;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)468582401;
							if (num != 0)
							{
							}
							num = (short)1468923904;
							if (num != 0)
							{
							}
							num = (short)2072838144;
							short num3 = num;
							return this.a = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTRODataProfileService(this.serverAccessor, this.GetValidationService() as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService);
						}
						}
					}
					return this.a;
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x06000650 RID: 1616 RVA: 0x0003DA44 File Offset: 0x0003BC44
			public global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROSystemService AstroSystemService
			{
				get
				{
					short num = (short)1554055169;
					if (num != 0)
					{
					}
					if (this.b == null)
					{
						num = (short)1822069858;
						short num2 = num;
						num = (short)363369570;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1182334976;
							if (num != 0)
							{
							}
							num = (short)215285760;
							short num3 = num;
							return this.b = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSystemService(this.serverAccessor, this.GetValidationService() as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService);
						}
						}
					}
					return this.b;
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x06000651 RID: 1617 RVA: 0x0003DB24 File Offset: 0x0003BD24
			public global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROOTARProfileService AstroOTARProfileService
			{
				get
				{
					if (this.c == null)
					{
						short num = (short)1211940268;
						short num2 = num;
						num = (short)20823468;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1807155201;
							if (num != 0)
							{
							}
							num = (short)1301741568;
							if (num != 0)
							{
							}
							num = (short)61014016;
							short num3 = num;
							return this.c = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROOTARProfileService(this.serverAccessor, this.GetValidationService() as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService);
						}
						}
					}
					return this.c;
				}
			}

			// Token: 0x06000652 RID: 1618 RVA: 0x0003DC04 File Offset: 0x0003BE04
			private global::Motorola.CommonCPS.RadioManagement.SharedServices.IPackageManagementService a(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily A_0)
			{
				short num = (short)767688705;
				if (num != 0)
				{
				}
				num = (short)1087766530;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.CommonCPS.RadioManagement.SharedServices.IPackageManagementService result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return result;
					case 1:
						return result;
					case 2:
					{
						num = (short)1191262823;
						short num3 = num;
						num = (short)379992679;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_122;
						default:
							num = (short)585236480;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_A7;
							}
							continue;
						}
						break;
					}
					case 3:
						result = new global::Motorola.CommonCPS.RadioManagement.Services.Package.AstroAmpFirmwarePackageService(this.serverAccessor, global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance());
						goto IL_122;
					}
					IL_A7:
					if (A_0 == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP)
					{
						num = (short)2048786435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROFirmwarePackageService(this.serverAccessor);
					num = (short)1975713792;
					short num4 = num;
					num = (short)1164378112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_122:
					num = (short)200474625;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
			}

			// Token: 0x06000653 RID: 1619 RVA: 0x0003DD50 File Offset: 0x0003BF50
			public override global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioLicenseService GetRadioLicenseService()
			{
				if (this.radioLicenseService == null)
				{
					short num = (short)322374480;
					short num2 = num;
					num = (short)1573522256;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2086797313;
						if (num != 0)
						{
						}
						num = (short)1736638464;
						if (num != 0)
						{
						}
						num = (short)1855913984;
						short num3 = num;
						return this.radioLicenseService = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTRORadioLicenseService(this.serverAccessor, this.GetValidationService() as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService);
					}
					}
				}
				return this.radioLicenseService;
			}

			// Token: 0x06000654 RID: 1620 RVA: 0x0003DE2C File Offset: 0x0003C02C
			public override global::Motorola.CommonCPS.RadioManagement.SharedServices.IManageRadioLicenseService GetManageRadioLicenseService()
			{
				short num = (short)1591345153;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)2054684673;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_125;
					case 1:
					{
						num = (short)67174400;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					}
					case 2:
					{
						this.manageRadioLicenseService = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROManageRadioLicenseService(this.serverAccessor, this.GetValidationService() as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService, this.GetRadioLicenseService());
						num = (short)110267228;
						short num4 = num;
						num = (short)1333168988;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_125;
						default:
							num = (short)881131520;
							if (num != 0)
							{
							}
							num = (short)1582497792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_80:
					if (this.manageRadioLicenseService != null)
					{
						break;
					}
					num = (short)1220739074;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_125:
				return this.manageRadioLicenseService;
			}

			// Token: 0x06000655 RID: 1621 RVA: 0x0003DF68 File Offset: 0x0003C168
			public override global::Motorola.CommonCPS.RadioManagement.SharedServices.ILicenseService GetAppLicenseService()
			{
				if (this.licenseService == null)
				{
					short num = (short)65950387;
					short num2 = num;
					num = (short)1935889075;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2119565313;
						if (num != 0)
						{
						}
						num = (short)110034944;
						if (num != 0)
						{
						}
						num = (short)319488000;
						short num3 = num;
						return this.licenseService = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROLicenseService(this.serverAccessor);
					}
					}
				}
				return this.licenseService;
			}

			// Token: 0x04000073 RID: 115
			private global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRODataProfileService a;

			// Token: 0x04000074 RID: 116
			private global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROSystemService b;

			// Token: 0x04000075 RID: 117
			private global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROOTARProfileService c;
		}

		// Token: 0x0200004A RID: 74
		private class CommonServiceContainer : global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.ServiceContainerBase
		{
			// Token: 0x06000657 RID: 1623 RVA: 0x0003E050 File Offset: 0x0003C250
			public override global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService GetRadioService()
			{
				if (this.radioService == null)
				{
					short num = (short)51236939;
					short num2 = num;
					num = (short)1053478987;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)115015681;
						if (num != 0)
						{
						}
						num = (short)59179008;
						if (num != 0)
						{
						}
						num = (short)1496449024;
						short num3 = num;
						return this.radioService = new global::Motorola.CommonCPS.RadioManagement.SharedServices.CommonDeviceService(this.serverAccessor);
					}
					}
				}
				return this.radioService;
			}

			// Token: 0x06000658 RID: 1624 RVA: 0x0003E124 File Offset: 0x0003C324
			public override global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioDetailService GetRadioDetailService()
			{
				short num = (short)1322010466;
				short num2 = num;
				num = (short)443500386;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1365049344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)26738688;
				if (num != 0)
				{
				}
				num = (short)1819279361;
				if (num != 0)
				{
				}
				return null;
			}

			// Token: 0x06000659 RID: 1625 RVA: 0x0003E1D0 File Offset: 0x0003C3D0
			public override global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService GetTemplateService()
			{
				short num = (short)955179452;
				short num2 = num;
				num = (short)425910716;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1360986112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1923940352;
				if (num != 0)
				{
				}
				num = (short)705036289;
				if (num != 0)
				{
				}
				return null;
			}

			// Token: 0x0600065A RID: 1626 RVA: 0x0003E278 File Offset: 0x0003C478
			public override global::Motorola.CommonCPS.RadioManagement.SharedServices.IPackageManagementService GetPackageManagementService(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.None)
			{
				short num = (short)521674275;
				short num2 = num;
				num = (short)1029578275;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1728970752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1115947009;
				if (num != 0)
				{
				}
				num = (short)1948909568;
				if (num != 0)
				{
				}
				return null;
			}

			// Token: 0x0600065B RID: 1627 RVA: 0x0003E324 File Offset: 0x0003C524
			public override global::Motorola.CommonCPS.RadioManagement.SharedServices.IValidationServiceBase GetValidationService()
			{
				short num = (short)703004673;
				if (num != 0)
				{
				}
				num = (short)1577517056;
				short num2 = num;
				num = (short)1770033108;
				short num3 = num;
				num = (short)934121428;
				switch (num3 == num)
				{
				}
				num = (short)1284898816;
				if (num != 0)
				{
				}
				return null;
			}

			// Token: 0x0600065C RID: 1628 RVA: 0x0003E3D0 File Offset: 0x0003C5D0
			public override global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioLicenseService GetRadioLicenseService()
			{
				short num = (short)46809192;
				short num2 = num;
				num = (short)2077180008;
				switch (num2 == num)
				{
				default:
				{
					num = (short)639107072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)248971264;
				if (num != 0)
				{
				}
				num = (short)1267728385;
				if (num != 0)
				{
				}
				return null;
			}

			// Token: 0x0600065D RID: 1629 RVA: 0x0003E47C File Offset: 0x0003C67C
			public override global::Motorola.CommonCPS.RadioManagement.SharedServices.IManageRadioLicenseService GetManageRadioLicenseService()
			{
				short num = (short)94856311;
				short num2 = num;
				num = (short)1003775095;
				switch (num2 == num)
				{
				default:
				{
					num = (short)142802944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1406271489;
				if (num != 0)
				{
				}
				num = (short)1919287296;
				if (num != 0)
				{
				}
				return null;
			}

			// Token: 0x0600065E RID: 1630 RVA: 0x0003E528 File Offset: 0x0003C728
			public override global::Motorola.CommonCPS.RadioManagement.SharedServices.ILicenseService GetAppLicenseService()
			{
				short num = (short)189136806;
				short num2 = num;
				num = (short)474152870;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1486815232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)184156161;
				if (num != 0)
				{
				}
				num = (short)718405632;
				if (num != 0)
				{
				}
				return null;
			}
		}
	}
}
