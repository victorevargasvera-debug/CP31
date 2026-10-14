using System;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x0200003E RID: 62
	[global::System.Serializable]
	public enum JobType
	{
		// Token: 0x040001CD RID: 461
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.ReadWrite)]
		Read,
		// Token: 0x040001CE RID: 462
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.ReadWrite)]
		WriteNoSwitchover,
		// Token: 0x040001CF RID: 463
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.ReadWrite)]
		WriteWithSwitchover,
		// Token: 0x040001D0 RID: 464
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.ReadWrite)]
		Switchover,
		// Token: 0x040001D1 RID: 465
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.ReadWrite)]
		FactoryReset,
		// Token: 0x040001D2 RID: 466
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportArchive,
		// Token: 0x040001D3 RID: 467
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		DeleteRadios,
		// Token: 0x040001D4 RID: 468
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		CompleteRadio,
		// Token: 0x040001D5 RID: 469
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		SelectTemplate,
		// Token: 0x040001D6 RID: 470
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		SelectConfiguration,
		// Token: 0x040001D7 RID: 471
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		DeleteTemplate,
		// Token: 0x040001D8 RID: 472
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		DeleteKeys,
		// Token: 0x040001D9 RID: 473
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportLanguagePacks,
		// Token: 0x040001DA RID: 474
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		DeleteConfiguration,
		// Token: 0x040001DB RID: 475
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		DeleteSetTelePort,
		// Token: 0x040001DC RID: 476
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		DeletePackage,
		// Token: 0x040001DD RID: 477
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportFirmwarePacks,
		// Token: 0x040001DE RID: 478
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportVAPackage,
		// Token: 0x040001DF RID: 479
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportTTSPackage,
		// Token: 0x040001E0 RID: 480
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportTemplates,
		// Token: 0x040001E1 RID: 481
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ApplyMVO,
		// Token: 0x040001E2 RID: 482
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ApplyTemplate,
		// Token: 0x040001E3 RID: 483
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ApplyConfiguration,
		// Token: 0x040001E4 RID: 484
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		DiscardCodeplugChanges,
		// Token: 0x040001E5 RID: 485
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		UpgradeRadio,
		// Token: 0x040001E6 RID: 486
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportRadioFromCSV,
		// Token: 0x040001E7 RID: 487
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportCertificates,
		// Token: 0x040001E8 RID: 488
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ScheduleJob,
		// Token: 0x040001E9 RID: 489
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		MoveDevices,
		// Token: 0x040001EA RID: 490
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		Flashport,
		// Token: 0x040001EB RID: 491
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportCSV,
		// Token: 0x040001EC RID: 492
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		UpgradeFirmware,
		// Token: 0x040001ED RID: 493
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		UpgradeLanguagePack,
		// Token: 0x040001EE RID: 494
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		SelectLanguagePack,
		// Token: 0x040001EF RID: 495
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		SubmitLicenseAssignment,
		// Token: 0x040001F0 RID: 496
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		RecoverRadioLicense,
		// Token: 0x040001F1 RID: 497
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		RestoreRadioLicense,
		// Token: 0x040001F2 RID: 498
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		RecoverCMSCLicense,
		// Token: 0x040001F3 RID: 499
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		RestoreCMSCLicense,
		// Token: 0x040001F4 RID: 500
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		SubmitAppLicense,
		// Token: 0x040001F5 RID: 501
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		SubmitAppLicenseFile,
		// Token: 0x040001F6 RID: 502
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		CancelJob,
		// Token: 0x040001F7 RID: 503
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		RecoverAppLicense,
		// Token: 0x040001F8 RID: 504
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		UpdateRadio,
		// Token: 0x040001F9 RID: 505
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		CopyConfiguration,
		// Token: 0x040001FA RID: 506
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportConfiguration,
		// Token: 0x040001FB RID: 507
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ExportConfiguration,
		// Token: 0x040001FC RID: 508
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportGeneralPackages,
		// Token: 0x040001FD RID: 509
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportPBBAPKApplication,
		// Token: 0x040001FE RID: 510
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportPBBShortcut,
		// Token: 0x040001FF RID: 511
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportPBBApplicationWidget,
		// Token: 0x04000200 RID: 512
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportPBBCertificate,
		// Token: 0x04000201 RID: 513
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		SelectPBBAPKApplication,
		// Token: 0x04000202 RID: 514
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		SelectGeneralPackage,
		// Token: 0x04000203 RID: 515
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		SelectPBBFirmware,
		// Token: 0x04000204 RID: 516
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		SelectApkApplication,
		// Token: 0x04000205 RID: 517
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		SelectPBBCertificate,
		// Token: 0x04000206 RID: 518
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		DeletePBBPassword,
		// Token: 0x04000207 RID: 519
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		AddPBBPassword,
		// Token: 0x04000208 RID: 520
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ChangePBBPasswordID,
		// Token: 0x04000209 RID: 521
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ChangePBBPasswordValue,
		// Token: 0x0400020A RID: 522
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportPBBHomeSetPackages,
		// Token: 0x0400020B RID: 523
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		SelectPBBHomeSetPackage,
		// Token: 0x0400020C RID: 524
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		UpdatePBBHomeSetPackage,
		// Token: 0x0400020D RID: 525
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		DuplicatePBBHomeSetPackage,
		// Token: 0x0400020E RID: 526
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		SavePBBHomeSetPackage,
		// Token: 0x0400020F RID: 527
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		SaveAsPBBHomeSetPackage,
		// Token: 0x04000210 RID: 528
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ExportPBBHomeSetPackage,
		// Token: 0x04000211 RID: 529
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		NewPBBHomeSetPackage,
		// Token: 0x04000212 RID: 530
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		DeleteJobContainer,
		// Token: 0x04000213 RID: 531
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		MoveQueries,
		// Token: 0x04000214 RID: 532
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		DeleteQueries,
		// Token: 0x04000215 RID: 533
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		UpgradeCodeplugVersion,
		// Token: 0x04000216 RID: 534
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		DeletePBBShortcuts,
		// Token: 0x04000217 RID: 535
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		DeletePBBApplicationWidget,
		// Token: 0x04000218 RID: 536
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		DeleteSystems,
		// Token: 0x04000219 RID: 537
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ApplyIPProgramSystem,
		// Token: 0x0400021A RID: 538
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		DeleteSACRecord,
		// Token: 0x0400021B RID: 539
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		AddTGSARecords,
		// Token: 0x0400021C RID: 540
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		DeleteTGSARecords,
		// Token: 0x0400021D RID: 541
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		EditSACRecord,
		// Token: 0x0400021E RID: 542
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		EditTGSARecord,
		// Token: 0x0400021F RID: 543
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportSiSeries,
		// Token: 0x04000220 RID: 544
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportWhiteList,
		// Token: 0x04000221 RID: 545
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportSimpleTouch,
		// Token: 0x04000222 RID: 546
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		UpgradeTCMNIS,
		// Token: 0x04000223 RID: 547
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportAPNList,
		// Token: 0x04000224 RID: 548
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportCACertificatesPackage,
		// Token: 0x04000225 RID: 549
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		ImportDVRSFilesPackage,
		// Token: 0x04000226 RID: 550
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		DeviceCapabilityMigration,
		// Token: 0x04000227 RID: 551
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		GroupMigration,
		// Token: 0x04000228 RID: 552
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		VAMigration,
		// Token: 0x04000229 RID: 553
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		LPMigration,
		// Token: 0x0400022A RID: 554
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		PCRTTSMigration,
		// Token: 0x0400022B RID: 555
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		MatrixKeyMigration,
		// Token: 0x0400022C RID: 556
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		FWMigration,
		// Token: 0x0400022D RID: 557
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		RadioMigration,
		// Token: 0x0400022E RID: 558
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		JobMigration,
		// Token: 0x0400022F RID: 559
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		TemplateMigration,
		// Token: 0x04000230 RID: 560
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		CodeplugMigration,
		// Token: 0x04000231 RID: 561
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		ScheduleMigrationJob,
		// Token: 0x04000232 RID: 562
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		ApplyTemplateToRadio,
		// Token: 0x04000233 RID: 563
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		AppMigration,
		// Token: 0x04000234 RID: 564
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		ProvisioningMigration,
		// Token: 0x04000235 RID: 565
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		PBBPasswordMigration,
		// Token: 0x04000236 RID: 566
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		FirmwareMigration,
		// Token: 0x04000237 RID: 567
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		HomeSetMigration,
		// Token: 0x04000238 RID: 568
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		PBBLicenseMigration,
		// Token: 0x04000239 RID: 569
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		CodeplugApplicationPairMigration,
		// Token: 0x0400023A RID: 570
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		PBBFusionCfgMigration,
		// Token: 0x0400023B RID: 571
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		PBBFusionWifiMigration,
		// Token: 0x0400023C RID: 572
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		PBBFusionApplyToRadioMigration,
		// Token: 0x0400023D RID: 573
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		CACertificatesMigration,
		// Token: 0x0400023E RID: 574
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		DVRSFilesMigration,
		// Token: 0x0400023F RID: 575
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		RadioConversion,
		// Token: 0x04000240 RID: 576
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration)]
		TemplateConversion,
		// Token: 0x04000241 RID: 577
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation)]
		AutoAdd,
		// Token: 0x04000242 RID: 578
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.ReadWrite)]
		SyncRead,
		// Token: 0x04000243 RID: 579
		[global::Motorola.CommonCPS.Server.CommonDBConstants.JobType(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.ReadWrite)]
		ResetPassword,
		// Token: 0x04000244 RID: 580
		UnAssigned = 65535
	}
}
