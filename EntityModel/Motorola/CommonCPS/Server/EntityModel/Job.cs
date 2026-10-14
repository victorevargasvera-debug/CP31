using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200003D RID: 61
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob))]
	[global::System.Serializable]
	public class Job : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x0600056D RID: 1389 RVA: 0x0003D770 File Offset: 0x0003B970
		public Job()
		{
			this.IsMigrationJob = false;
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x0003D78C File Offset: 0x0003B98C
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x0003D838 File Offset: 0x0003BA38
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? JobContainerUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1717171711;
				short num2 = num;
				num = (short)1243870719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)930611200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1087832064;
				if (num != 0)
				{
				}
				num = (short)200474625;
				if (num != 0)
				{
				}
				return this.<JobContainerUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1350258503;
				short num2 = num;
				num = (short)1088507719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2027814912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1326645249;
				if (num != 0)
				{
				}
				num = (short)2036137984;
				if (num != 0)
				{
				}
				this.<JobContainerUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x0003D8EC File Offset: 0x0003BAEC
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x0003D9A0 File Offset: 0x0003BBA0
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime? CreatedDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)355928696;
				short num2 = num;
				num = (short)1444940408;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1066401792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1592786944;
				if (num != 0)
				{
				}
				num = (short)2070347777;
				if (num != 0)
				{
				}
				return this.<CreatedDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1021345475;
				short num2 = num;
				num = (short)1364819651;
				switch (num2 == num)
				{
				default:
				{
					num = (short)59310080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1804926976;
				if (num != 0)
				{
				}
				num = (short)760676353;
				if (num != 0)
				{
				}
				this.<CreatedDate>k__BackingField = value;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x0003DA50 File Offset: 0x0003BC50
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x0003DB00 File Offset: 0x0003BD00
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime? ExecutedDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1748947289;
				short num2 = num;
				num = (short)1731645785;
				switch (num2 == num)
				{
				default:
				{
					num = (short)184418304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1705574401;
				if (num != 0)
				{
				}
				num = (short)1092419584;
				if (num != 0)
				{
				}
				return this.<ExecutedDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1323908521;
				short num2 = num;
				num = (short)1778466217;
				switch (num2 == num)
				{
				default:
				{
					num = (short)949616640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)353763329;
				if (num != 0)
				{
				}
				num = (short)1319567360;
				if (num != 0)
				{
				}
				this.<ExecutedDate>k__BackingField = value;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x0003DBAC File Offset: 0x0003BDAC
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x0003DC5C File Offset: 0x0003BE5C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus JobStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1217206293;
				short num2 = num;
				num = (short)307173397;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1089208320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1712586752;
				if (num != 0)
				{
				}
				num = (short)1646067713;
				if (num != 0)
				{
				}
				return this.<JobStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)890634241;
				if (num != 0)
				{
				}
				num = (short)98172928;
				short num2 = num;
				num = (short)1966045721;
				short num3 = num;
				num = (short)1773173273;
				switch (num3 == num)
				{
				}
				num = (short)237895680;
				if (num != 0)
				{
				}
				this.<JobStatus>k__BackingField = value;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x0003DD0C File Offset: 0x0003BF0C
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x0003DDBC File Offset: 0x0003BFBC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus CruncherStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)786526197;
				short num2 = num;
				num = (short)303919093;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1987903488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1998651393;
				if (num != 0)
				{
				}
				num = (short)174718976;
				if (num != 0)
				{
				}
				return this.<CruncherStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1929110830;
				short num2 = num;
				num = (short)1695016238;
				switch (num2 == num)
				{
				default:
				{
					num = (short)438566912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)361562113;
				if (num != 0)
				{
				}
				num = (short)1314914304;
				if (num != 0)
				{
				}
				this.<CruncherStatus>k__BackingField = value;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x0003DE6C File Offset: 0x0003C06C
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x0003DF1C File Offset: 0x0003C11C
		[global::System.Runtime.Serialization.DataMember]
		public int? ErrorCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)476620105;
				short num2 = num;
				num = (short)634496329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)30998528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1241317376;
				if (num != 0)
				{
				}
				num = (short)862519297;
				if (num != 0)
				{
				}
				return this.<ErrorCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)461090073;
				short num2 = num;
				num = (short)1544203545;
				switch (num2 == num)
				{
				default:
				{
					num = (short)43450368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1861615616;
				if (num != 0)
				{
				}
				num = (short)181862401;
				if (num != 0)
				{
				}
				this.<ErrorCode>k__BackingField = value;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0003DFCC File Offset: 0x0003C1CC
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x0003E07C File Offset: 0x0003C27C
		[global::System.Runtime.Serialization.DataMember]
		public string WarningMessage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)71227657;
				short num2 = num;
				num = (short)1911281929;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1685389312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1041563648;
				if (num != 0)
				{
				}
				num = (short)839647233;
				if (num != 0)
				{
				}
				return this.<WarningMessage>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1455281344;
				short num2 = num;
				num = (short)1859966144;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2042232832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1208614913;
				if (num != 0)
				{
				}
				num = (short)1496317952;
				if (num != 0)
				{
				}
				this.<WarningMessage>k__BackingField = value;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x0003E130 File Offset: 0x0003C330
		// (set) Token: 0x0600057D RID: 1405 RVA: 0x0003E1E4 File Offset: 0x0003C3E4
		[global::System.Runtime.Serialization.DataMember]
		public string ErrorMessage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)598864320;
				short num2 = num;
				num = (short)1821307328;
				switch (num2 == num)
				{
				default:
				{
					num = (short)358547456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)495190017;
				if (num != 0)
				{
				}
				num = (short)1033371648;
				if (num != 0)
				{
				}
				return this.<ErrorMessage>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1138517282;
				short num2 = num;
				num = (short)330917154;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1462435840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1753415681;
				if (num != 0)
				{
				}
				num = (short)860553216;
				if (num != 0)
				{
				}
				this.<ErrorMessage>k__BackingField = value;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x0003E298 File Offset: 0x0003C498
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x0003E348 File Offset: 0x0003C548
		[global::System.Runtime.Serialization.DataMember]
		public string Parameters
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)493034065;
				short num2 = num;
				num = (short)1914182225;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1747058688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1120272385;
				if (num != 0)
				{
				}
				num = (short)1871839232;
				if (num != 0)
				{
				}
				return this.<Parameters>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1041146338;
				short num2 = num;
				num = (short)461808098;
				switch (num2 == num)
				{
				default:
				{
					num = (short)341180416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1183449088;
				if (num != 0)
				{
				}
				num = (short)541982721;
				if (num != 0)
				{
				}
				this.<Parameters>k__BackingField = value;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x0003E3F8 File Offset: 0x0003C5F8
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x0003E4A8 File Offset: 0x0003C6A8
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.JobContainer JobContainer
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)810800835;
				short num2 = num;
				num = (short)696309443;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1948778496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1774845953;
				if (num != 0)
				{
				}
				num = (short)1580924928;
				if (num != 0)
				{
				}
				return this.<JobContainer>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1128660993;
				if (num != 0)
				{
				}
				num = (short)1216741376;
				short num2 = num;
				num = (short)1006552261;
				short num3 = num;
				num = (short)1060095173;
				switch (num3 == num)
				{
				}
				num = (short)190316544;
				if (num != 0)
				{
				}
				this.<JobContainer>k__BackingField = value;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x0003E558 File Offset: 0x0003C758
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x0003E60C File Offset: 0x0003C80C
		[global::System.Runtime.Serialization.DataMember]
		public string RRPLogicalID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1109655553;
				if (num != 0)
				{
				}
				num = (short)1703804928;
				short num2 = num;
				num = (short)432707224;
				short num3 = num;
				num = (short)295474840;
				switch (num3 == num)
				{
				}
				num = (short)592183296;
				if (num != 0)
				{
				}
				return this.<RRPLogicalID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1236338046;
				short num2 = num;
				num = (short)129172862;
				switch (num2 == num)
				{
				default:
				{
					num = (short)854786048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)623902720;
				if (num != 0)
				{
				}
				num = (short)391249921;
				if (num != 0)
				{
				}
				this.<RRPLogicalID>k__BackingField = value;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x0003E6BC File Offset: 0x0003C8BC
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x0003E76C File Offset: 0x0003C96C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobType JobType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)998768641;
				if (num != 0)
				{
				}
				num = (short)1799356416;
				short num2 = num;
				num = (short)923435024;
				short num3 = num;
				num = (short)505774096;
				switch (num3 == num)
				{
				}
				num = (short)539426816;
				if (num != 0)
				{
				}
				return this.<JobType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)675201861;
				short num2 = num;
				num = (short)2053161797;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1757085696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)188743681;
				if (num != 0)
				{
				}
				num = (short)600899584;
				if (num != 0)
				{
				}
				this.<JobType>k__BackingField = value;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x0003E81C File Offset: 0x0003CA1C
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x0003E8CC File Offset: 0x0003CACC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier Pac
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1891955087;
				short num2 = num;
				num = (short)1996747151;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1554055168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1462042625;
				if (num != 0)
				{
				}
				num = (short)1755381760;
				if (num != 0)
				{
				}
				return this.<Pac>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)834646880;
				short num2 = num;
				num = (short)117224288;
				switch (num2 == num)
				{
				}
				num = (short)1143341057;
				if (num != 0)
				{
				}
				num = (short)802750464;
				short num3 = num;
				num = (short)1849098240;
				if (num != 0)
				{
				}
				this.<Pac>k__BackingField = value;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x0003E97C File Offset: 0x0003CB7C
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x0003EA2C File Offset: 0x0003CC2C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily ProductFamily
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1544586651;
				short num2 = num;
				num = (short)1184204187;
				switch (num2 == num)
				{
				}
				num = (short)85983232;
				if (num != 0)
				{
				}
				num = (short)766443520;
				short num3 = num;
				num = (short)1515651073;
				if (num != 0)
				{
				}
				return this.<ProductFamily>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)820130796;
				short num2 = num;
				num = (short)882652140;
				switch (num2 == num)
				{
				}
				num = (short)1093664769;
				if (num != 0)
				{
				}
				num = (short)1677459456;
				short num3 = num;
				num = (short)1214775296;
				if (num != 0)
				{
				}
				this.<ProductFamily>k__BackingField = value;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x0003EADC File Offset: 0x0003CCDC
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x0003EB8C File Offset: 0x0003CD8C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode WorkMode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1212874753;
				if (num != 0)
				{
				}
				num = (short)1916413155;
				short num2 = num;
				num = (short)231417059;
				switch (num2 == num)
				{
				}
				num = (short)619970560;
				short num3 = num;
				num = (short)755761152;
				if (num != 0)
				{
				}
				return this.<WorkMode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)538399634;
				short num2 = num;
				num = (short)1683510162;
				switch (num2 == num)
				{
				}
				num = (short)1487470593;
				if (num != 0)
				{
				}
				num = (short)1014431744;
				short num3 = num;
				num = (short)1064763392;
				if (num != 0)
				{
				}
				this.<WorkMode>k__BackingField = value;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x0003EC3C File Offset: 0x0003CE3C
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x0003ECE8 File Offset: 0x0003CEE8
		[global::System.Runtime.Serialization.DataMember]
		public bool IsMigrationJob
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)951681928;
				short num2 = num;
				num = (short)915047304;
				switch (num2 == num)
				{
				}
				num = (short)593887232;
				if (num != 0)
				{
				}
				num = (short)2116222976;
				short num3 = num;
				num = (short)210436097;
				if (num != 0)
				{
				}
				return this.<IsMigrationJob>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1728586591;
				short num2 = num;
				num = (short)2055611231;
				switch (num2 == num)
				{
				}
				num = (short)985858049;
				if (num != 0)
				{
				}
				num = (short)459931648;
				short num3 = num;
				num = (short)1618214912;
				if (num != 0)
				{
				}
				this.<IsMigrationJob>k__BackingField = value;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x0003ED98 File Offset: 0x0003CF98
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x0003EE48 File Offset: 0x0003D048
		[global::System.Runtime.Serialization.DataMember]
		public string InformationMessage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)34961000;
				short num2 = num;
				num = (short)1012561512;
				switch (num2 == num)
				{
				}
				num = (short)1014169600;
				if (num != 0)
				{
				}
				num = (short)1096679424;
				short num3 = num;
				num = (short)865599489;
				if (num != 0)
				{
				}
				return this.<InformationMessage>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)449812601;
				short num2 = num;
				num = (short)52205689;
				switch (num2 == num)
				{
				}
				num = (short)1089667072;
				if (num != 0)
				{
				}
				num = (short)423952384;
				short num3 = num;
				num = (short)1687093249;
				if (num != 0)
				{
				}
				this.<InformationMessage>k__BackingField = value;
			}
		}
	}
}
