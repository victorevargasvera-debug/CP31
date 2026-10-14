using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000041 RID: 65
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJobViewSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.BatchOpJobViewSummary))]
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class JobSummaryViewEntity : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0004028C File Offset: 0x0003E48C
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x00040338 File Offset: 0x0003E538
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("JobContainerUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid JobContainerUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1241264289;
				short num2 = num;
				num = (short)613626017;
				switch (num2 == num)
				{
				default:
				{
					num = (short)200802304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)32899073;
				if (num != 0)
				{
				}
				num = (short)1930493952;
				if (num != 0)
				{
				}
				return this.<JobContainerUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)448605799;
				short num2 = num;
				num = (short)353906279;
				switch (num2 == num)
				{
				default:
				{
					num = (short)142737408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1308033024;
				if (num != 0)
				{
				}
				num = (short)309788673;
				if (num != 0)
				{
				}
				this.<JobContainerUuid>k__BackingField = value;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x000403E8 File Offset: 0x0003E5E8
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x00040498 File Offset: 0x0003E698
		[global::System.Runtime.Serialization.DataMember]
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2063076836;
				short num2 = num;
				num = (short)2101415396;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1784872960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1931673601;
				if (num != 0)
				{
				}
				num = (short)1698430976;
				if (num != 0)
				{
				}
				return this.<Name>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1000407041;
				if (num != 0)
				{
				}
				num = (short)192348160;
				short num2 = num;
				num = (short)202757086;
				short num3 = num;
				num = (short)708695006;
				switch (num3 == num)
				{
				}
				num = (short)1002831872;
				if (num != 0)
				{
				}
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x00040548 File Offset: 0x0003E748
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x000405F8 File Offset: 0x0003E7F8
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("JobType", typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobType JobType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)220135425;
				if (num != 0)
				{
				}
				num = (short)138739712;
				short num2 = num;
				num = (short)1217216881;
				short num3 = num;
				num = (short)671760753;
				switch (num3 == num)
				{
				}
				num = (short)1519321088;
				if (num != 0)
				{
				}
				return this.<JobType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1518872099;
				short num2 = num;
				num = (short)2047944227;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1180303360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)72417281;
				if (num != 0)
				{
				}
				num = (short)126681088;
				if (num != 0)
				{
				}
				this.<JobType>k__BackingField = value;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x000406A8 File Offset: 0x0003E8A8
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x00040758 File Offset: 0x0003E958
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ExecutedDate", typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
		public global::System.DateTime? ExecutedDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1987248129;
				if (num != 0)
				{
				}
				num = (short)1231945728;
				short num2 = num;
				num = (short)636079596;
				short num3 = num;
				num = (short)1329319404;
				switch (num3 == num)
				{
				}
				num = (short)1911422976;
				if (num != 0)
				{
				}
				return this.<ExecutedDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1973171982;
				short num2 = num;
				num = (short)1470510862;
				switch (num2 == num)
				{
				default:
				{
					num = (short)492109824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)901578753;
				if (num != 0)
				{
				}
				num = (short)1437794304;
				if (num != 0)
				{
				}
				this.<ExecutedDate>k__BackingField = value;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00040808 File Offset: 0x0003EA08
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x000408B8 File Offset: 0x0003EAB8
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("CreatedDate", typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
		public global::System.DateTime? CreatedDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)923467777;
				if (num != 0)
				{
				}
				num = (short)1684340736;
				short num2 = num;
				num = (short)1766263163;
				short num3 = num;
				num = (short)180291963;
				switch (num3 == num)
				{
				}
				num = (short)705560576;
				if (num != 0)
				{
				}
				return this.<CreatedDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1118664710;
				short num2 = num;
				num = (short)1363310598;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2053505024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1711800321;
				if (num != 0)
				{
				}
				num = (short)2013855744;
				if (num != 0)
				{
				}
				this.<CreatedDate>k__BackingField = value;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00040968 File Offset: 0x0003EB68
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x00040A14 File Offset: 0x0003EC14
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("JobStatus", typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus JobStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1529025855;
				short num2 = num;
				num = (short)2033653055;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1285750784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)851312641;
				if (num != 0)
				{
				}
				num = (short)1093861376;
				if (num != 0)
				{
				}
				return this.<JobStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1847024682;
				short num2 = num;
				num = (short)1011964970;
				switch (num2 == num)
				{
				default:
				{
					num = (short)517603328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1359085568;
				if (num != 0)
				{
				}
				num = (short)1672478721;
				if (num != 0)
				{
				}
				this.<JobStatus>k__BackingField = value;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x00040AC4 File Offset: 0x0003ECC4
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x00040B70 File Offset: 0x0003ED70
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("CruncherStatus", typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus CruncherStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1621671668;
				short num2 = num;
				num = (short)1660862196;
				switch (num2 == num)
				{
				}
				num = (short)1195900929;
				if (num != 0)
				{
				}
				num = (short)1264779264;
				short num3 = num;
				num = (short)1838481408;
				if (num != 0)
				{
				}
				return this.<CruncherStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1395992760;
				short num2 = num;
				num = (short)1184442552;
				switch (num2 == num)
				{
				}
				num = (short)1777598465;
				if (num != 0)
				{
				}
				num = (short)374669312;
				short num3 = num;
				num = (short)999227392;
				if (num != 0)
				{
				}
				this.<CruncherStatus>k__BackingField = value;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x00040C24 File Offset: 0x0003EE24
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x00040CD4 File Offset: 0x0003EED4
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ErrorCode", typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
		[global::System.Runtime.Serialization.DataMember]
		public int? ErrorCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)722396533;
				short num2 = num;
				num = (short)1164698997;
				switch (num2 == num)
				{
				}
				num = (short)1206321153;
				if (num != 0)
				{
				}
				num = (short)1071251456;
				short num3 = num;
				num = (short)152305664;
				if (num != 0)
				{
				}
				return this.<ErrorCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)785961312;
				short num2 = num;
				num = (short)510447968;
				switch (num2 == num)
				{
				}
				num = (short)1904541697;
				if (num != 0)
				{
				}
				num = (short)849346560;
				short num3 = num;
				num = (short)887357440;
				if (num != 0)
				{
				}
				this.<ErrorCode>k__BackingField = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x00040D80 File Offset: 0x0003EF80
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x00040E30 File Offset: 0x0003F030
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("WarningMessage", typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
		[global::System.Runtime.Serialization.DataMember]
		public string WarningMessage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)150667265;
				if (num != 0)
				{
				}
				num = (short)1315992836;
				short num2 = num;
				num = (short)1989965060;
				switch (num2 == num)
				{
				}
				num = (short)1163264000;
				short num3 = num;
				num = (short)247332864;
				if (num != 0)
				{
				}
				return this.<WarningMessage>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)436758350;
				short num2 = num;
				num = (short)69494606;
				switch (num2 == num)
				{
				}
				num = (short)309657600;
				if (num != 0)
				{
				}
				num = (short)2113601536;
				short num3 = num;
				num = (short)1700134913;
				if (num != 0)
				{
				}
				this.<WarningMessage>k__BackingField = value;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00040EE0 File Offset: 0x0003F0E0
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x00040F90 File Offset: 0x0003F190
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ErrorMessage", typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
		public string ErrorMessage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)15723233;
				short num2 = num;
				num = (short)1669393121;
				switch (num2 == num)
				{
				}
				num = (short)1106640897;
				if (num != 0)
				{
				}
				num = (short)689635328;
				short num3 = num;
				num = (short)329318400;
				if (num != 0)
				{
				}
				return this.<ErrorMessage>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1235211804;
				short num2 = num;
				num = (short)1348261404;
				switch (num2 == num)
				{
				}
				num = (short)461176833;
				if (num != 0)
				{
				}
				num = (short)63766528;
				short num3 = num;
				num = (short)281280512;
				if (num != 0)
				{
				}
				this.<ErrorMessage>k__BackingField = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00041040 File Offset: 0x0003F240
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x000410F0 File Offset: 0x0003F2F0
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("Parameters", typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
		public string Parameters
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1118387721;
				short num2 = num;
				num = (short)1186807305;
				switch (num2 == num)
				{
				}
				num = (short)224264193;
				if (num != 0)
				{
				}
				num = (short)859963392;
				short num3 = num;
				num = (short)1476722688;
				if (num != 0)
				{
				}
				return this.<Parameters>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1217436952;
				short num2 = num;
				num = (short)1348115736;
				switch (num2 == num)
				{
				}
				num = (short)1488715776;
				if (num != 0)
				{
				}
				num = (short)1587740672;
				short num3 = num;
				num = (short)461832193;
				if (num != 0)
				{
				}
				this.<Parameters>k__BackingField = value;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x000411A4 File Offset: 0x0003F3A4
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00041254 File Offset: 0x0003F454
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("Pac", typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier Pac
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1461828008;
				short num2 = num;
				num = (short)2038872488;
				switch (num2 == num)
				{
				}
				num = (short)273874945;
				if (num != 0)
				{
				}
				num = (short)901644288;
				short num3 = num;
				num = (short)1503264768;
				if (num != 0)
				{
				}
				return this.<Pac>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)278131568;
				short num2 = num;
				num = (short)771945328;
				switch (num2 == num)
				{
				}
				num = (short)1594032129;
				if (num != 0)
				{
				}
				num = (short)21102592;
				short num3 = num;
				num = (short)134938624;
				if (num != 0)
				{
				}
				this.<Pac>k__BackingField = value;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00041304 File Offset: 0x0003F504
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x000413B4 File Offset: 0x0003F5B4
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("WorkMode", typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode WorkMode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)481004718;
				short num2 = num;
				num = (short)205491374;
				switch (num2 == num)
				{
				}
				num = (short)731971585;
				if (num != 0)
				{
				}
				num = (short)568983552;
				short num3 = num;
				num = (short)1766719488;
				if (num != 0)
				{
				}
				return this.<WorkMode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1364213750;
				short num2 = num;
				num = (short)495796214;
				switch (num2 == num)
				{
				}
				num = (short)679215104;
				if (num != 0)
				{
				}
				num = (short)1432616960;
				short num3 = num;
				num = (short)419561473;
				if (num != 0)
				{
				}
				this.<WorkMode>k__BackingField = value;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00041468 File Offset: 0x0003F668
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x00041518 File Offset: 0x0003F718
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("IsMigrationJob", typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
		public bool IsMigrationJob
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1161786095;
				short num2 = num;
				num = (short)37581551;
				switch (num2 == num)
				{
				}
				num = (short)1736638464;
				if (num != 0)
				{
				}
				num = (short)1613561856;
				short num3 = num;
				num = (short)1786904577;
				if (num != 0)
				{
				}
				return this.<IsMigrationJob>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)806891953;
				short num2 = num;
				num = (short)390279601;
				switch (num2 == num)
				{
				}
				num = (short)4194305;
				if (num != 0)
				{
				}
				num = (short)143458304;
				short num3 = num;
				num = (short)1759117312;
				if (num != 0)
				{
				}
				this.<IsMigrationJob>k__BackingField = value;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x000415C4 File Offset: 0x0003F7C4
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x00041678 File Offset: 0x0003F878
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("InformationMessage", typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
		public string InformationMessage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1204435652;
				short num2 = num;
				num = (short)215366340;
				switch (num2 == num)
				{
				}
				num = (short)555024384;
				if (num != 0)
				{
				}
				num = (short)766050304;
				short num3 = num;
				num = (short)294518785;
				if (num != 0)
				{
				}
				return this.<InformationMessage>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1012685180;
				short num2 = num;
				num = (short)1265719676;
				switch (num2 == num)
				{
				}
				num = (short)2134704128;
				if (num != 0)
				{
				}
				num = (short)218497024;
				short num3 = num;
				num = (short)1584988161;
				if (num != 0)
				{
				}
				this.<InformationMessage>k__BackingField = value;
			}
		}
	}
}
