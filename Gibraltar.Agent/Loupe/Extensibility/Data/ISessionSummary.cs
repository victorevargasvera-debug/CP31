using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000078 RID: 120
	internal interface ISessionSummary : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x060005A9 RID: 1449
		global::Loupe.Extensibility.Data.ISession Session();

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060005AA RID: 1450
		global::System.Guid Id { get; }

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060005AB RID: 1451
		global::System.Uri Uri { get; }

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060005AC RID: 1452
		bool IsNew { get; }

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060005AD RID: 1453
		bool IsComplete { get; }

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060005AE RID: 1454
		bool IsLive { get; }

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060005AF RID: 1455
		bool HasData { get; }

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060005B0 RID: 1456
		string TimeZoneCaption { get; }

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060005B1 RID: 1457
		global::System.DateTimeOffset StartDateTime { get; }

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060005B2 RID: 1458
		global::System.DateTimeOffset DisplayStartDateTime { get; }

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060005B3 RID: 1459
		global::System.DateTimeOffset EndDateTime { get; }

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060005B4 RID: 1460
		global::System.DateTimeOffset DisplayEndDateTime { get; }

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060005B5 RID: 1461
		global::System.TimeSpan Duration { get; }

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060005B6 RID: 1462
		global::System.DateTimeOffset AddedDateTime { get; }

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060005B7 RID: 1463
		global::System.DateTimeOffset DisplayAddedDateTime { get; }

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060005B8 RID: 1464
		global::System.DateTimeOffset UpdatedDateTime { get; }

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060005B9 RID: 1465
		global::System.DateTimeOffset DisplayUpdatedDateTime { get; }

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060005BA RID: 1466
		string Caption { get; }

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060005BB RID: 1467
		string Product { get; }

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060005BC RID: 1468
		string Application { get; }

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060005BD RID: 1469
		string Environment { get; }

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060005BE RID: 1470
		string PromotionLevel { get; }

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060005BF RID: 1471
		global::Loupe.Extensibility.Data.ApplicationType ApplicationType { get; }

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060005C0 RID: 1472
		string ApplicationDescription { get; }

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060005C1 RID: 1473
		global::System.Version ApplicationVersion { get; }

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060005C2 RID: 1474
		global::System.Version AgentVersion { get; }

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060005C3 RID: 1475
		string HostName { get; }

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060005C4 RID: 1476
		string DnsDomainName { get; }

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060005C5 RID: 1477
		string FullyQualifiedUserName { get; }

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060005C6 RID: 1478
		string UserName { get; }

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060005C7 RID: 1479
		string UserDomainName { get; }

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060005C8 RID: 1480
		global::System.Version OSVersion { get; }

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060005C9 RID: 1481
		string OSServicePack { get; }

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060005CA RID: 1482
		string OSCultureName { get; }

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060005CB RID: 1483
		global::System.Reflection.ProcessorArchitecture OSArchitecture { get; }

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060005CC RID: 1484
		global::System.Windows.Forms.BootMode OSBootMode { get; }

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060005CD RID: 1485
		int OSPlatformCode { get; }

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060005CE RID: 1486
		int OSProductType { get; }

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060005CF RID: 1487
		int OSSuiteMask { get; }

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060005D0 RID: 1488
		string OSFamilyName { get; }

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060005D1 RID: 1489
		string OSEditionName { get; }

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060005D2 RID: 1490
		string OSFullName { get; }

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060005D3 RID: 1491
		string OSFullNameWithServicePack { get; }

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060005D4 RID: 1492
		global::System.Version RuntimeVersion { get; }

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060005D5 RID: 1493
		global::System.Reflection.ProcessorArchitecture RuntimeArchitecture { get; }

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060005D6 RID: 1494
		string CurrentCultureName { get; }

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060005D7 RID: 1495
		string CurrentUICultureName { get; }

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060005D8 RID: 1496
		int MemoryMB { get; }

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060005D9 RID: 1497
		int Processors { get; }

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060005DA RID: 1498
		int ProcessorCores { get; }

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060005DB RID: 1499
		bool UserInteractive { get; }

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060005DC RID: 1500
		bool TerminalServer { get; }

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060005DD RID: 1501
		int ScreenWidth { get; }

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060005DE RID: 1502
		int ScreenHeight { get; }

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060005DF RID: 1503
		int ColorDepth { get; }

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060005E0 RID: 1504
		string CommandLine { get; }

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060005E1 RID: 1505
		global::System.Guid? ComputerId { get; }

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060005E2 RID: 1506
		global::Loupe.Extensibility.Data.SessionStatus Status { get; }

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060005E3 RID: 1507
		int MessageCount { get; }

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060005E4 RID: 1508
		int CriticalCount { get; }

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060005E5 RID: 1509
		int ErrorCount { get; }

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060005E6 RID: 1510
		int WarningCount { get; }

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060005E7 RID: 1511
		global::System.Collections.Generic.IDictionary<string, string> Properties { get; }

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060005E8 RID: 1512
		global::Loupe.Extensibility.Data.IComputer Computer { get; }
	}
}
