using System;

namespace Motorola.Common.CustomException
{
	// Token: 0x0200000C RID: 12
	public enum CPSErrorCodes
	{
		// Token: 0x04000CA1 RID: 3233
		ASTROUnknownIssue = 100000000,
		// Token: 0x04000CA2 RID: 3234
		DefaultValue,
		// Token: 0x04000CA3 RID: 3235
		InvalidMessageNotProvided,
		// Token: 0x04000CA4 RID: 3236
		IPAddressGeneralError,
		// Token: 0x04000CA5 RID: 3237
		IPAddressCannotBeZero,
		// Token: 0x04000CA6 RID: 3238
		InvalidValueBecauseofSystemKey,
		// Token: 0x04000CA7 RID: 3239
		AccessoryButtons_RadErgoCfgRSMConventionalBCO_A19639_1 = 100100101,
		// Token: 0x04000CA8 RID: 3240
		AccessoryButtons_RadErgoCfgRSMTrunkingBCO_A19741_1 = 100100201,
		// Token: 0x04000CA9 RID: 3241
		AccessoryButtons_RadErgoCfgRSMTrunkingBCO_A19741_2,
		// Token: 0x04000CAA RID: 3242
		AccessoryButtons_RadErgoCfgRSMTrunkingBCO_A19741_3,
		// Token: 0x04000CAB RID: 3243
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_1 = 100100401,
		// Token: 0x04000CAC RID: 3244
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_2,
		// Token: 0x04000CAD RID: 3245
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_3,
		// Token: 0x04000CAE RID: 3246
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_4,
		// Token: 0x04000CAF RID: 3247
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_5,
		// Token: 0x04000CB0 RID: 3248
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_6,
		// Token: 0x04000CB1 RID: 3249
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_7,
		// Token: 0x04000CB2 RID: 3250
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_8,
		// Token: 0x04000CB3 RID: 3251
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_9,
		// Token: 0x04000CB4 RID: 3252
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_10,
		// Token: 0x04000CB5 RID: 3253
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_11,
		// Token: 0x04000CB6 RID: 3254
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_12,
		// Token: 0x04000CB7 RID: 3255
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_13,
		// Token: 0x04000CB8 RID: 3256
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_14,
		// Token: 0x04000CB9 RID: 3257
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_15,
		// Token: 0x04000CBA RID: 3258
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_1 = 100100501,
		// Token: 0x04000CBB RID: 3259
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_2,
		// Token: 0x04000CBC RID: 3260
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_3,
		// Token: 0x04000CBD RID: 3261
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_4,
		// Token: 0x04000CBE RID: 3262
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_5,
		// Token: 0x04000CBF RID: 3263
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_6,
		// Token: 0x04000CC0 RID: 3264
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_7,
		// Token: 0x04000CC1 RID: 3265
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_8,
		// Token: 0x04000CC2 RID: 3266
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_9,
		// Token: 0x04000CC3 RID: 3267
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_10,
		// Token: 0x04000CC4 RID: 3268
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_11,
		// Token: 0x04000CC5 RID: 3269
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_12,
		// Token: 0x04000CC6 RID: 3270
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_13,
		// Token: 0x04000CC7 RID: 3271
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_14,
		// Token: 0x04000CC8 RID: 3272
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_15,
		// Token: 0x04000CC9 RID: 3273
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_16,
		// Token: 0x04000CCA RID: 3274
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_17,
		// Token: 0x04000CCB RID: 3275
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_18,
		// Token: 0x04000CCC RID: 3276
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_19,
		// Token: 0x04000CCD RID: 3277
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_20,
		// Token: 0x04000CCE RID: 3278
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_21,
		// Token: 0x04000CCF RID: 3279
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_22,
		// Token: 0x04000CD0 RID: 3280
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_23,
		// Token: 0x04000CD1 RID: 3281
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_24,
		// Token: 0x04000CD2 RID: 3282
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_25,
		// Token: 0x04000CD3 RID: 3283
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_26,
		// Token: 0x04000CD4 RID: 3284
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_27,
		// Token: 0x04000CD5 RID: 3285
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_28,
		// Token: 0x04000CD6 RID: 3286
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_29,
		// Token: 0x04000CD7 RID: 3287
		ActionConsolidation_RadioErgoConfigACSirenType_A36584_1 = 100200100,
		// Token: 0x04000CD8 RID: 3288
		ActionConsolidation_RadioErgoConfigACSirenType_A36584_2,
		// Token: 0x04000CD9 RID: 3289
		ActionConsolidation_RadioErgoConfigACSirenType_A36584_3,
		// Token: 0x04000CDA RID: 3290
		ActionConsolidation_RadioErgoConfigACGpsReport_A36587_1 = 100200200,
		// Token: 0x04000CDB RID: 3291
		ActionConsolidation_RelayPattern_1 = 100200300,
		// Token: 0x04000CDC RID: 3292
		ASTRO25FixedNetworkEquipment_TrkSysGeneralSystemID_A9239_2 = 100400202,
		// Token: 0x04000CDD RID: 3293
		ASTRO25FixedNetworkEquipment_TrkSysGeneralCoverageType_A7782_1 = 100400101,
		// Token: 0x04000CDE RID: 3294
		ASTRO25FixedNetworkEquipment_TrkSysGeneralCoverageType_A7782_2,
		// Token: 0x04000CDF RID: 3295
		ASTRO25FixedNetworkEquipment_TrkSysGeneralCoverageType_A7782_3,
		// Token: 0x04000CE0 RID: 3296
		ASTRO25FixedNetworkEquipment_TrkSysGeneralCoverageType_A7782_4,
		// Token: 0x04000CE1 RID: 3297
		ASTRO25FixedNetworkEquipment_TrkSysGeneralCoverageType_A7782_5,
		// Token: 0x04000CE2 RID: 3298
		ASTRO25FixedNetworkEquipment_TrkSysASTRO25ValidateNACAgainstSystemID_A20608_1 = 100400201,
		// Token: 0x04000CE3 RID: 3299
		ASTRO25FixedNetworkEquipment_TrkSysASTRO25ValidateNACAgainstSystemID_A20608_2 = 100400204,
		// Token: 0x04000CE4 RID: 3300
		ASTRO25FixedNetworkEquipment_TrkSysASTRO25WUIDValiditySupport_A41483_1 = 100400301,
		// Token: 0x04000CE5 RID: 3301
		ASTRO25FixedNetworkEquipment_TrkSysASTRO25F2VoiceCapable_A1395_1 = 100400401,
		// Token: 0x04000CE6 RID: 3302
		ASTRO25FNEChannelID_TrkSysASTRO25ChannelIDIdentifierEnable_A8222_1 = 100500101,
		// Token: 0x04000CE7 RID: 3303
		ASTRO25FNEChannelID_TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546_1 = 100500201,
		// Token: 0x04000CE8 RID: 3304
		ASTRO25FNEChannelID_TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546_2,
		// Token: 0x04000CE9 RID: 3305
		ASTRO25FNEChannelID_TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660_1 = 100500301,
		// Token: 0x04000CEA RID: 3306
		ASTRO25FNEChannelID_TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660_2,
		// Token: 0x04000CEB RID: 3307
		ASTRO25FNEChannelID_TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416_1 = 100500401,
		// Token: 0x04000CEC RID: 3308
		ASTRO25FNEControlChannel_TrkSysControlChannelsRxFrequencyMHz_A9018_1 = 100600101,
		// Token: 0x04000CED RID: 3309
		ASTRO25FNEControlChannel_TrkSysControlChannelsRxFrequencyMHz_A9018_2,
		// Token: 0x04000CEE RID: 3310
		ASTRO25FNEControlChannel_TrkSysControlChannelsTxFrequencyMHz_A9535_1 = 100600201,
		// Token: 0x04000CEF RID: 3311
		ASTRO25FNEControlChannel_TrkSysControlChannelsTxFrequencyMHz_A9535_2,
		// Token: 0x04000CF0 RID: 3312
		ASTRO25FNEStatusAlias_TrkSysStatusAliasStatusAliasNumber_A9190_1 = 100800101,
		// Token: 0x04000CF1 RID: 3313
		ASTRO25FNETalkgroup_TrkPerTalkgroupTalkgroup_A9274_1 = 100900101,
		// Token: 0x04000CF2 RID: 3314
		ASTRO25FNETalkgroup_TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001_1 = 100900201,
		// Token: 0x04000CF3 RID: 3315
		ASTRO25FNETalkgroup_TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900_1 = 100900301,
		// Token: 0x04000CF4 RID: 3316
		ASTRO25FNETalkgroup_TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003_1 = 100900401,
		// Token: 0x04000CF5 RID: 3317
		ASTRO25FNETalkgroup_TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902_1 = 100900501,
		// Token: 0x04000CF6 RID: 3318
		ASTRO25FNETalkgroup_TrkPerTalkgroup_42163_1 = 100900601,
		// Token: 0x04000CF7 RID: 3319
		UclAstro25TrkHotList_CallID_a00038_1 = 101200101,
		// Token: 0x04000CF8 RID: 3320
		UclAstro25Trk_IndividualID_A00013_1 = 101400101,
		// Token: 0x04000CF9 RID: 3321
		UclAstro25Trk_IndividualID_A00013_2,
		// Token: 0x04000CFA RID: 3322
		UclAstro25Trk_IndividualID_A00013_3,
		// Token: 0x04000CFB RID: 3323
		UclAstro25Trk_IndividualID_A00013_4,
		// Token: 0x04000CFC RID: 3324
		UclAstro25Trk_IndividualID_A00013_5,
		// Token: 0x04000CFD RID: 3325
		ASTRO25TrunkingOneTouch_TrkSysOneTouchFeature_A8614_1 = 101500101,
		// Token: 0x04000CFE RID: 3326
		ASTRO25TrunkingOneTouch_TrkSysOneTouchFeature_A8614_2,
		// Token: 0x04000CFF RID: 3327
		ASTRO25TrunkingOneTouch_TrkSysOneTouchFeature_A8614_3,
		// Token: 0x04000D00 RID: 3328
		ASTRO25TrunkingOneTouch_TrkSysOneTouchIndex_A8618_1 = 101500201,
		// Token: 0x04000D01 RID: 3329
		ASTRO25TrunkingOneTouch_TrkSysOneTouchIndex_A8618_2,
		// Token: 0x04000D02 RID: 3330
		ASTRO25TrunkingOneTouch_TrkSysOneTouchIndex_A8618_3,
		// Token: 0x04000D03 RID: 3331
		ASTRO25TrunkingPersonlaity_TrkPerCallPageCallAlertPageOperation_A7597_1 = 101600101,
		// Token: 0x04000D04 RID: 3332
		ASTRO25TrunkingPersonlaity_TrkPerCallPagePrivateCallOperation_A8759_1 = 101600201,
		// Token: 0x04000D05 RID: 3333
		ASTRO25TrunkingPersonlaity_TrkPerFeaturesScanListSelection_A9053_1 = 101600301,
		// Token: 0x04000D06 RID: 3334
		ASTRO25TrunkingPersonlaity_TrkPerFeaturesScanListSelection_A9053_2,
		// Token: 0x04000D07 RID: 3335
		ASTRO25TrunkingPersonlaity_TrkPerFeaturesScanListSelection_A9053_3,
		// Token: 0x04000D08 RID: 3336
		ASTRO25TrunkingPersonlaity_TrkPerFeaturesScanListSelection_A9053_4,
		// Token: 0x04000D09 RID: 3337
		ASTRO25TrunkingPersonlaity_TrkPerFeaturesScanListSelection_A9053_5,
		// Token: 0x04000D0A RID: 3338
		ASTRO25TrunkingPersonlaity_TrkPerFeaturesScanListSelection_A9053_6,
		// Token: 0x04000D0B RID: 3339
		ASTRO25TrunkingPersonlaity_TrkPerFeaturesScanListSelection_A9053_7,
		// Token: 0x04000D0C RID: 3340
		ASTRO25TrunkingPersonlaity_TrkPerFeaturesScanListSelection_A9053_8,
		// Token: 0x04000D0D RID: 3341
		ASTRO25TrunkingPersonlaity_TrkPerFeaturesStatusEnable_A9188_1 = 101600401,
		// Token: 0x04000D0E RID: 3342
		ASTRO25TrunkingPersonlaity_TrkEmerProfGeneralKeySelect_A8970_1 = 101600501,
		// Token: 0x04000D0F RID: 3343
		ASTRO25TrunkingPersonlaity_TrkEmerProfGeneralKeySelect_A8970_2,
		// Token: 0x04000D10 RID: 3344
		ASTRO25TrunkingPersonlaity_TrkEmerProfGeneralKeySelect_A8970_3,
		// Token: 0x04000D11 RID: 3345
		ASTRO25TrunkingPersonlaity_TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980_1 = 101600601,
		// Token: 0x04000D12 RID: 3346
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertZone_A41916_1 = 101600701,
		// Token: 0x04000D13 RID: 3347
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertChannel_A41917_1 = 101600801,
		// Token: 0x04000D14 RID: 3348
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertChannel_A41917_2,
		// Token: 0x04000D15 RID: 3349
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertChannel_A41917_3,
		// Token: 0x04000D16 RID: 3350
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertChannel_A41917_4,
		// Token: 0x04000D17 RID: 3351
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertChannel_A41917_5,
		// Token: 0x04000D18 RID: 3352
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertChannel_A41917_6,
		// Token: 0x04000D19 RID: 3353
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertChannel_A41917_7,
		// Token: 0x04000D1A RID: 3354
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertChannel_A41917_8,
		// Token: 0x04000D1B RID: 3355
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertChannel_A41917_9,
		// Token: 0x04000D1C RID: 3356
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertChannel_A41917_10,
		// Token: 0x04000D1D RID: 3357
		ASTRO25TrunkingPersonlaity_TrkPerAnnouncementGroupAGKeySelect_A7414_1 = 101600901,
		// Token: 0x04000D1E RID: 3358
		ASTRO25TrunkingPersonlaity_TrkPerAnnouncementGroupAGKeySelect_A7414_2,
		// Token: 0x04000D1F RID: 3359
		ASTRO25TrunkingPersonlaity_TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582_1 = 101601001,
		// Token: 0x04000D20 RID: 3360
		ASTRO25TrunkingPersonlaity_TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582_2,
		// Token: 0x04000D21 RID: 3361
		ASTRO25TrunkingPersonlaity_TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583_1 = 101601101,
		// Token: 0x04000D22 RID: 3362
		ASTRO25TrunkingPersonlaity_TrkPerGeneralTimeOutTimersec_A9379_1 = 101601201,
		// Token: 0x04000D23 RID: 3363
		TxFreqValueMismatchRxFreqValue_1,
		// Token: 0x04000D24 RID: 3364
		ASTRO25TrunkingPersonlaity_conIsBackupPTTOperationSelectionValid_1 = 101601301,
		// Token: 0x04000D25 RID: 3365
		TrunkingSystem_1 = 101700001,
		// Token: 0x04000D26 RID: 3366
		TrunkingSystem_2,
		// Token: 0x04000D27 RID: 3367
		ASTRO25TrunkingSystem_TrkSysGeneralUnitID_A12651_1 = 101700201,
		// Token: 0x04000D28 RID: 3368
		Error_RadioID_Empty,
		// Token: 0x04000D29 RID: 3369
		Error_RadioID_OutOfRange,
		// Token: 0x04000D2A RID: 3370
		Error_RadioID_OutOfASKRange,
		// Token: 0x04000D2B RID: 3371
		ASTRO25TrunkingSystem_TrkSysGeneralDataProfileSelection_A19449_1 = 101700301,
		// Token: 0x04000D2C RID: 3372
		ASTRO25TrunkingSystem_TrkSysGeneralDataProfileSelection_A19449_2,
		// Token: 0x04000D2D RID: 3373
		ASTRO25TrunkingSystem_TrkSysGeneralDataProfileSelection_A19449_3,
		// Token: 0x04000D2E RID: 3374
		ASTRO25TrunkingSystem_TrkSysGeneralDataProfileSelection_A19449_4,
		// Token: 0x04000D2F RID: 3375
		Error_OTARID_Empty,
		// Token: 0x04000D30 RID: 3376
		ASTRO25TrunkingSystem_TrkSysFixedNetworkEquipment_42165_1 = 101700401,
		// Token: 0x04000D31 RID: 3377
		ASTRO25TrunkingSystem_TrkSysFixedNetworkEquipment_42165_2,
		// Token: 0x04000D32 RID: 3378
		ASTRO25TrunkingSystem_TrkSysFixedNetworkEquipment_42165_3,
		// Token: 0x04000D33 RID: 3379
		ASTRO25TrunkingSystem_TrkSysFeaturesRadioInhibit_A8833_1 = 101700501,
		// Token: 0x04000D34 RID: 3380
		ASTRO25TrunkingSystem_TrkSysFeaturesTextMessagingService_A9373_1 = 101700601,
		// Token: 0x04000D35 RID: 3381
		ASTRO25TrunkingSystem_TrkSysFeaturesTextMessagingService_A9373_2,
		// Token: 0x04000D36 RID: 3382
		ASTRO25TrunkingSystem_TrkSysFeaturesZone_A9717_1 = 101700701,
		// Token: 0x04000D37 RID: 3383
		ASTRO25TrunkingSystem_TrkSysFeaturesZone_A9717_2,
		// Token: 0x04000D38 RID: 3384
		ASTRO25TrunkingSystem_TrkSysFeaturesChannel_A7647_1 = 101700801,
		// Token: 0x04000D39 RID: 3385
		ASTRO25TrunkingSystem_TrkSysFeaturesChannel_A7647_2,
		// Token: 0x04000D3A RID: 3386
		ASTRO25TrunkingSystem_TrkSysFeaturesChannel_A7647_3,
		// Token: 0x04000D3B RID: 3387
		ASTRO25TrunkingSystem_TrkSysFeaturesChannel_A7647_4,
		// Token: 0x04000D3C RID: 3388
		ASTRO25TrunkingSystem_SiteSelectableAlertList_A42060_1 = 101700901,
		// Token: 0x04000D3D RID: 3389
		ASTRO25TrunkingSystem_TrkSysSiteAliasSiteAliasEnable_A9148_1 = 101701001,
		// Token: 0x04000D3E RID: 3390
		ASTRO25TrunkingSystem_TrkSysSecureMultikeyKMFProfileIndex_A8382_1 = 101701101,
		// Token: 0x04000D3F RID: 3391
		ASTRO25TrunkingSystem_TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918_1 = 101701201,
		// Token: 0x04000D40 RID: 3392
		ASTRO25TrunkingSystem_TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918_2,
		// Token: 0x04000D41 RID: 3393
		ASTRO25TrunkingSystem_TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918_3,
		// Token: 0x04000D42 RID: 3394
		ASTRO25TrunkingSystem_TrkSysFeatureLocationOnPTT_43026_1 = 101701301,
		// Token: 0x04000D43 RID: 3395
		ASTRO25TrunkingTalkgroupRecSetInvalid = 101800001,
		// Token: 0x04000D44 RID: 3396
		UclAstroCnvHotList_CallID_A00044_1 = 102200101,
		// Token: 0x04000D45 RID: 3397
		UclAstroCnv_SystemAlias_A00022_1 = 102400101,
		// Token: 0x04000D46 RID: 3398
		UclAstroCnv_IndividualID_A00024_1 = 102400201,
		// Token: 0x04000D47 RID: 3399
		UclAstroCnv_IndividualID_A00024_2,
		// Token: 0x04000D48 RID: 3400
		UclAstroCnv_IndividualID_A00024_3,
		// Token: 0x04000D49 RID: 3401
		UclAstroCnv_IndividualID_A00024_4,
		// Token: 0x04000D4A RID: 3402
		UclAstroCnv_IndividualID_A00024_5,
		// Token: 0x04000D4B RID: 3403
		UclAstroCnv_IndividualID_A00024_6,
		// Token: 0x04000D4C RID: 3404
		UclAstroCnv_ListinfoCallType_A00025_1 = 102400301,
		// Token: 0x04000D4D RID: 3405
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_1 = 102500101,
		// Token: 0x04000D4E RID: 3406
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_2,
		// Token: 0x04000D4F RID: 3407
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_3,
		// Token: 0x04000D50 RID: 3408
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_4,
		// Token: 0x04000D51 RID: 3409
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_5,
		// Token: 0x04000D52 RID: 3410
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_6,
		// Token: 0x04000D53 RID: 3411
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_7,
		// Token: 0x04000D54 RID: 3412
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_8,
		// Token: 0x04000D55 RID: 3413
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_9,
		// Token: 0x04000D56 RID: 3414
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_10,
		// Token: 0x04000D57 RID: 3415
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_11,
		// Token: 0x04000D58 RID: 3416
		ConventionalOneTouch_CnvPerOneTouchIndex_A19663_1 = 102500201,
		// Token: 0x04000D59 RID: 3417
		ConventionalOneTouch_CnvPerOneTouchIndex_A19663_2,
		// Token: 0x04000D5A RID: 3418
		ConventionalOneTouch_CnvPerOneTouchIndex_A19663_3,
		// Token: 0x04000D5B RID: 3419
		ConventionalOneTouch_CnvPerOneTouchIndex_A19663_4,
		// Token: 0x04000D5C RID: 3420
		ConventionalOneTouch_CnvPerOneTouchIndex_A19663_5,
		// Token: 0x04000D5D RID: 3421
		ConventionalPersonality_CnvPerFeaturesTacticalRekeyEnable_A19309_1 = 102600101,
		// Token: 0x04000D5E RID: 3422
		ConventionalPersonality_CnvPerFeaturesTacticalRekeyEnable_A19309_2,
		// Token: 0x04000D5F RID: 3423
		ConventionalPersonality_ConPerFeatureIncidentSignalingType_A41507_1 = 102600201,
		// Token: 0x04000D60 RID: 3424
		ConventionalPersonality_ConPerFeatureIncidentSignalingType_A41507_2,
		// Token: 0x04000D61 RID: 3425
		ConventionalPersonality_ConPerFeatureIncidentSignalingType_A41507_3,
		// Token: 0x04000D62 RID: 3426
		ConventionalPersonality_ConPerFeatureIncidentSignalingType_A41507_4,
		// Token: 0x04000D63 RID: 3427
		ConventionalPersonality_ConPerFeatureIncidentSignalingType_A41507_5,
		// Token: 0x04000D64 RID: 3428
		ConventionalPersonality_CnvPerLabtoolScanListSelection_A9054_1 = 102600301,
		// Token: 0x04000D65 RID: 3429
		ConventionalPersonality_CnvPerLabtoolScanListSelection_A9054_2,
		// Token: 0x04000D66 RID: 3430
		ConventionalPersonality_CnvPerLabtoolScanListSelection_A9054_3,
		// Token: 0x04000D67 RID: 3431
		ConventionalPersonality_CnvPerLabtoolScanListSelection_A9054_4,
		// Token: 0x04000D68 RID: 3432
		ConventionalPersonality_CnvPerLabtoolScanListSelection_A9054_5,
		// Token: 0x04000D69 RID: 3433
		ConventionalPersonality_CnvPerLabtoolScanListSelection_A9054_6,
		// Token: 0x04000D6A RID: 3434
		ConventionalPersonality_CnvPerLabtoolScanListSelection_A9054_7,
		// Token: 0x04000D6B RID: 3435
		ConventionalPersonality_CnvPerLabtoolScanListSelection_A9054_8,
		// Token: 0x04000D6C RID: 3436
		ConventionalPersonality_CnvPerLabtoolScanListSelection_A9054_9,
		// Token: 0x04000D6D RID: 3437
		ConventionalPersonality_CnvPerLabtoolScanListSelection_A9054_10,
		// Token: 0x04000D6E RID: 3438
		ConventionalPersonality_CnvPerLabtoolScanListSelection_A9054_11,
		// Token: 0x04000D6F RID: 3439
		ConventionalPersonality_CnvPerFeaturesFiregroundRegistration_A33242_1 = 102600401,
		// Token: 0x04000D70 RID: 3440
		ConventionalPersonality_CnvPerFeaturesFiregroundRegistration_A33242_2,
		// Token: 0x04000D71 RID: 3441
		ConventionalPersonality_CnvPerFeaturesFiregroundRegistration_A33242_3,
		// Token: 0x04000D72 RID: 3442
		ConventionalPersonality_CnvPerFeaturesFiregroundRegistration_A33242_4,
		// Token: 0x04000D73 RID: 3443
		ConventionalPersonality_CnvPerFeaturesTxVoiceType_A9573_1 = 102600501,
		// Token: 0x04000D74 RID: 3444
		ConventionalPersonality_CnvPerTxOptionsTransmitPreEmphasis_A9411_1 = 102600601,
		// Token: 0x04000D75 RID: 3445
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_1 = 102600701,
		// Token: 0x04000D76 RID: 3446
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_2,
		// Token: 0x04000D77 RID: 3447
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_4,
		// Token: 0x04000D78 RID: 3448
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_6,
		// Token: 0x04000D79 RID: 3449
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_7,
		// Token: 0x04000D7A RID: 3450
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_8,
		// Token: 0x04000D7B RID: 3451
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_9,
		// Token: 0x04000D7C RID: 3452
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_10,
		// Token: 0x04000D7D RID: 3453
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_11,
		// Token: 0x04000D7E RID: 3454
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_12,
		// Token: 0x04000D7F RID: 3455
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_13,
		// Token: 0x04000D80 RID: 3456
		ConventionalPersonality_CnvPerSignalingRevertType_A8953_1 = 102600801,
		// Token: 0x04000D81 RID: 3457
		ConventionalPersonality_CnvPerSignalingRevertType_A8953_2,
		// Token: 0x04000D82 RID: 3458
		ConventionalPersonality_CnvPerSignalingRevertType_A8953_3,
		// Token: 0x04000D83 RID: 3459
		ConventionalPersonality_CnvPerSignalingASTRORxUnmuteRule_A9042_1 = 102600901,
		// Token: 0x04000D84 RID: 3460
		ConventionalPersonality_CnvPerSignalingASTRORxUnmuteRule_A9042_2,
		// Token: 0x04000D85 RID: 3461
		ConventionalPersonality_CnvPerSignalingASTRORxUnmuteRule_A9042_3,
		// Token: 0x04000D86 RID: 3462
		ConventionalPersonality_CnvPerTxOptionsTxVoiceSignalType_A9574_1 = 102601001,
		// Token: 0x04000D87 RID: 3463
		ConventionalPersonality_CnvPerTxOptionsTxVoiceSignalType_A9574_2,
		// Token: 0x04000D88 RID: 3464
		ConventionalPersonality_CnvPerSecureOTARTx_A8675_1 = 102601101,
		// Token: 0x04000D89 RID: 3465
		ConventionalPersonality_CnvPerSecureScanSelect_A9056_1 = 102601201,
		// Token: 0x04000D8A RID: 3466
		ConventionalPersonality_CnvPerSecureSecureVoiceSignalType_A9086_1 = 102601301,
		// Token: 0x04000D8B RID: 3467
		ConventionalPersonality_CnvPerSecureSecureVoiceSignalType_A9086_3,
		// Token: 0x04000D8C RID: 3468
		ConventionalPersonality_CnvPerSecureSecureVoiceSignalType_A9086_4,
		// Token: 0x04000D8D RID: 3469
		ConventionalPersonality_CnvPerSecureASTROOTAR_A7493_1 = 102601401,
		// Token: 0x04000D8E RID: 3470
		ConventionalPersonality_CnvPerTacticalInhibitKillOperation_A41553_1 = 102601501,
		// Token: 0x04000D8F RID: 3471
		ConventionalPersonality_CnvPerTacticalInhibitKillOperation_A41553_2,
		// Token: 0x04000D90 RID: 3472
		ConventionalPersonality_CnvPerTacticalInhibitKillOperation_A41553_3,
		// Token: 0x04000D91 RID: 3473
		ConventionalPersonality_CnvPerTacticalInhibitStunOperation_A41557_1 = 102601601,
		// Token: 0x04000D92 RID: 3474
		ConventionalPersonality_CnvPerTacticalInhibitStunOperation_A41557_2,
		// Token: 0x04000D93 RID: 3475
		ConventionalPersonality_CnvPerTacticalInhibitStunOperation_A41557_3,
		// Token: 0x04000D94 RID: 3476
		ConventionalPersonality_CnvPerNonASTROCallRTTButtonAccess_A8493_1 = 102601701,
		// Token: 0x04000D95 RID: 3477
		ConventionalPersonality_CnvPerNonASTROCallRTTButtonAccess_A8493_2,
		// Token: 0x04000D96 RID: 3478
		ConventionalPersonality_CnvPerNonASTROCallRTTButtonAccess_A8493_3,
		// Token: 0x04000D97 RID: 3479
		ConventionalPersonality_CnvPerPhonePhoneOperation_A8703_1 = 102601801,
		// Token: 0x04000D98 RID: 3480
		ConventionalPersonality_CnvPerPhonePhoneOperation_A8703_2,
		// Token: 0x04000D99 RID: 3481
		ConventionalPersonality_CnvPerPhonePhoneOperation_A8703_3,
		// Token: 0x04000D9A RID: 3482
		ConventionalPersonality_CnvPerPhonePhoneOperation_A8703_4,
		// Token: 0x04000D9B RID: 3483
		ConventionalPersonality_CnvPerPhonePhoneOperation_A8703_5,
		// Token: 0x04000D9C RID: 3484
		ConventionalPersonality_CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272_1 = 102601901,
		// Token: 0x04000D9D RID: 3485
		ConventionalPersonality_CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272_2,
		// Token: 0x04000D9E RID: 3486
		ConventionalPersonality_CnvPerRxOptionsRxVoiceSignalType_A9044_1 = 102602001,
		// Token: 0x04000D9F RID: 3487
		ConventionalPersonality_CnvPerRxOptionsRxVoiceSignalType_A9044_2,
		// Token: 0x04000DA0 RID: 3488
		ConventionalPersonality_CnvPerRxOptionsRxVoiceSignalType_A9044_3,
		// Token: 0x04000DA1 RID: 3489
		ConventionalPersonality_CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257_1 = 102602101,
		// Token: 0x04000DA2 RID: 3490
		ConventionalPersonality_CnvPerLabtoolOTACROTACSMessaging_A8663_1 = 102602201,
		// Token: 0x04000DA3 RID: 3491
		ConventionalPersonality_CnvPerFeaturesMixedVoteScanEnable_A38723_1 = 102602301,
		// Token: 0x04000DA4 RID: 3492
		ConventionalPersonality_CnvPerFeaturesMixedVoteScanEnable_A38723_2,
		// Token: 0x04000DA5 RID: 3493
		ConventionalPersonality_CnvPerSecureSecureClearStrapping1_A9090_1 = 102602401,
		// Token: 0x04000DA6 RID: 3494
		ConventionalPersonality_CnvPerSecureSecureClearStrapping1_A9090_2,
		// Token: 0x04000DA7 RID: 3495
		ConventionalPersonality_CnvPerSecureSecureClearStrapping1_A9090_3,
		// Token: 0x04000DA8 RID: 3496
		ConventionalPersonality_CnvPerSecureKMFProfileIndex_A8381_1 = 102602501,
		// Token: 0x04000DA9 RID: 3497
		ConventionalPersonality_CnvPerSignalingSignalingType_A9129_1 = 102602601,
		// Token: 0x04000DAA RID: 3498
		ConventionalPersonality_CnvPerSignalingRevertZone_A13269_1 = 102602701,
		// Token: 0x04000DAB RID: 3499
		ConventionalPersonality_CnvPerSignalingSystemNumber_A9243_1 = 102602801,
		// Token: 0x04000DAC RID: 3500
		ConventionalPersonality_CnvPerSignalingSystemNumber_A9243_2,
		// Token: 0x04000DAD RID: 3501
		ConventionalPersonality_CnvPerSignalingASTROSystem_A7498_1 = 102602901,
		// Token: 0x04000DAE RID: 3502
		ConventionalPersonality_CnvPerSignalingASTROSystem_A7498_2,
		// Token: 0x04000DAF RID: 3503
		ConventionalPersonality_CnvPerSignalingASTROSystem_A7498_3,
		// Token: 0x04000DB0 RID: 3504
		ConventionalPersonality_CnvPerSignalingASTROSystem_A7498_4,
		// Token: 0x04000DB1 RID: 3505
		ConventionalPersonality_CnvPerSignalingASTROSystem_A7498_5,
		// Token: 0x04000DB2 RID: 3506
		ConventionalPersonality_CnvPerSignalingASTROSystem_A7498_6,
		// Token: 0x04000DB3 RID: 3507
		ConventionalPersonality_CnvPerSignalingASTROSystem_A7498_7,
		// Token: 0x04000DB4 RID: 3508
		ConventionalPersonality_CnvPerSignalingDigitalModulatorType_A7857_1 = 102603001,
		// Token: 0x04000DB5 RID: 3509
		ConventionalPersonality_CnvPerRACRepeaterAccess_A8939_1 = 102603101,
		// Token: 0x04000DB6 RID: 3510
		ConventionalPersonality_CnvPerRACRepeaterAccess_A8939_2,
		// Token: 0x04000DB7 RID: 3511
		ConventionalPersonality_CnvPerRACCodeType2_A8817_1 = 102603201,
		// Token: 0x04000DB8 RID: 3512
		ConventionalPersonality_CnvPerRACCodeType2_A8817_2,
		// Token: 0x04000DB9 RID: 3513
		ConventionalPersonality_CnvPerASTROCallCallAlertRxTx_A7586_1 = 102603301,
		// Token: 0x04000DBA RID: 3514
		ConventionalPersonality_CnvPerNonASTROCallCallAlertRxTx_A7588_1 = 102603401,
		// Token: 0x04000DBB RID: 3515
		ConventionalPersonality_CnvPerNonASTROCallCallAlertRxTx_A7588_2,
		// Token: 0x04000DBC RID: 3516
		ConventionalPersonality_CnvPerNonASTROCallSelectiveCallRxTx_A9116_1 = 102603501,
		// Token: 0x04000DBD RID: 3517
		ConventionalPersonality_CnvPerNonASTROCallSelectiveCallRxTx_A9116_2,
		// Token: 0x04000DBE RID: 3518
		ConventionalPersonality_CnvPerNonASTROCallSelectiveCallRxTx_A9116_3,
		// Token: 0x04000DBF RID: 3519
		ConventionalPersonality_CnvPerFeaturesDVRSProf_A41794_1 = 102603601,
		// Token: 0x04000DC0 RID: 3520
		ConventionalPersonality_CnvPerRxOptionsRxDeEmphasis_A9010_1 = 102603701,
		// Token: 0x04000DC1 RID: 3521
		ConventionalPersonality_CnvPerRxOptionsHearClear_A36408_1 = 102603801,
		// Token: 0x04000DC2 RID: 3522
		ConventionalPersonality_CnvPerAdvancedAnalogFlatAudio_A7443_1 = 102603901,
		// Token: 0x04000DC3 RID: 3523
		ConventionalPersonality_CnvPerASTROTalkgroupOptionsTalkgroupList_A9283_1 = 102604001,
		// Token: 0x04000DC4 RID: 3524
		ConventionalPersonality_CnvPerASTROTalkgroupOptionsTalkgroupList_A9283_2,
		// Token: 0x04000DC5 RID: 3525
		ConventionalPersonality_CnvPerAGAGKeySel_A40159_1 = 102604101,
		// Token: 0x04000DC6 RID: 3526
		ConventionalPersonality_CnvPerSecureKeySelection1_A8368_1 = 102604201,
		// Token: 0x04000DC7 RID: 3527
		ConventionalPersonality_CnvPerSignalingRevertTGKeySel_A40154_1 = 102604401,
		// Token: 0x04000DC8 RID: 3528
		ConventionalPersonality_CnvPerTxOptionsAdaptivePower_A7405_1 = 102604501,
		// Token: 0x04000DC9 RID: 3529
		ConventionalPersonality_CnvPerFeatureRFModem_42485_1 = 102604601,
		// Token: 0x04000DCA RID: 3530
		ConventionalPersonality_CnvPerFeaturesAstroAlertingToneTable_1 = 102604701,
		// Token: 0x04000DCB RID: 3531
		ConventionalPersonality_CnvPerFeaturesAstroAlertingToneTable_2,
		// Token: 0x04000DCC RID: 3532
		ConventionalPersonality_CnvPerFeaturesOTARadioAliasType_42784_1 = 102604801,
		// Token: 0x04000DCD RID: 3533
		ConventionalPersonality_CnvPerFeaturesOTARadioAliasType_42784_2,
		// Token: 0x04000DCE RID: 3534
		ConventionalPersonality_CnvPerTxOptionsTimeOutTimersec_A9378_1 = 102604901,
		// Token: 0x04000DCF RID: 3535
		ConventionalPersonality_CnvPerRACCodeType1_A7680_1 = 102605001,
		// Token: 0x04000DD0 RID: 3536
		ConventionalPersonality_CnvPerRACCodeType1_A7680_2,
		// Token: 0x04000DD1 RID: 3537
		CnvPerRACSingletone_1 = 102605101,
		// Token: 0x04000DD2 RID: 3538
		ConventionalSystem_ConvConfigConvSystemFeatRSISys_A41838_1 = 102700101,
		// Token: 0x04000DD3 RID: 3539
		ConventionalSystem_CnvSysFeaturesRemoteRadioMode_A8935_1 = 102700201,
		// Token: 0x04000DD4 RID: 3540
		ConventionalSystem_CnvSysFeatureDynRegroupZone_A40145_1 = 102700301,
		// Token: 0x04000DD5 RID: 3541
		ConventionalSystem_CnvSysFeatureDynRegroupZone_A40145_2,
		// Token: 0x04000DD6 RID: 3542
		ConventionalSystem_CnvSysFeatureDynRegroupChannel_A40144_1 = 102700401,
		// Token: 0x04000DD7 RID: 3543
		ConventionalSystem_CnvSysFeatureDynRegroupChannel_A40144_2,
		// Token: 0x04000DD8 RID: 3544
		ConventionalSystem_CnvSysFeatureDynRegroupChannel_A40144_3,
		// Token: 0x04000DD9 RID: 3545
		ConventionalSystem_CnvSysFeatureDynRegroupChannel_A40144_4,
		// Token: 0x04000DDA RID: 3546
		ConventionalSystem_CnvSysFeatureDynRegroupChannel_A40144_5,
		// Token: 0x04000DDB RID: 3547
		ConventionalSystem_CnvSysFeatureCallType_A40147_1 = 102700501,
		// Token: 0x04000DDC RID: 3548
		Error_RadioID_Contain_F = 102700601,
		// Token: 0x04000DDD RID: 3549
		ConventionalSystem_CnvSysGeneralDataProfileSelection_A13266_1 = 102700701,
		// Token: 0x04000DDE RID: 3550
		ConventionalSystem_CnvSysGeneralDataProfileSelection_A13266_2,
		// Token: 0x04000DDF RID: 3551
		ConventionalSystem_CnvSysGeneralDataProfileSelection_A13266_3,
		// Token: 0x04000DE0 RID: 3552
		ConventionalSystem_CnvSysGeneralDataProfileSelection_A13266_4,
		// Token: 0x04000DE1 RID: 3553
		ConventionalSystem_CnvSysGeneralEmergencyProfileSelection_A19421_1 = 102700801,
		// Token: 0x04000DE2 RID: 3554
		ConventionalSystem_CnvSysFeaturesSelectCallInCallReset_A9102_1 = 102700901,
		// Token: 0x04000DE3 RID: 3555
		ConventionalSystem_CnvSysFeaturesSelectCallInCallReset_A9102_2,
		// Token: 0x04000DE4 RID: 3556
		ConventionalSystem_DataProfFeaturesTextMessagingService_A9372_1 = 102701001,
		// Token: 0x04000DE5 RID: 3557
		ConventionalSystem_DataProfFeaturesTextMessagingService_A9372_2,
		// Token: 0x04000DE6 RID: 3558
		ConventionalSystem_CnvSysFeaturesDynamicIDEnable_A40100_1 = 102701101,
		// Token: 0x04000DE7 RID: 3559
		ConventionalSystem_CnvSysSecureDynTGKeySel_A40133_1 = 102701201,
		// Token: 0x04000DE8 RID: 3560
		ConventionalSystem_CnvSysSecureFSKeySel_A40134_1 = 102701301,
		// Token: 0x04000DE9 RID: 3561
		ConventionalSystem_CnvSysSecureInterConnectKeySel_A40135_1 = 102701401,
		// Token: 0x04000DEA RID: 3562
		ConventionalSystem_CnvSysSecurePatchKeySel_A40136_1 = 102701501,
		// Token: 0x04000DEB RID: 3563
		ConventionalSystem_CnvSysSecurePrivateCallKeySel_A40137_1 = 102701601,
		// Token: 0x04000DEC RID: 3564
		ConventionalSystem_CnvSysFeaturesCAIDataRegistration_A7585_1 = 102701701,
		// Token: 0x04000DED RID: 3565
		ConventionalSystem_CnvSysGeneralIndividualID_A8287_1 = 102701801,
		// Token: 0x04000DEE RID: 3566
		ConventionalSystem_CnvSysGeneralIndividualID_A8287_2,
		// Token: 0x04000DEF RID: 3567
		ConventionalSystem_CnvSysFeaturesPASelection_A42880_1 = 102701901,
		// Token: 0x04000DF0 RID: 3568
		ConventionalSystem_CnvSysGeneralQc2Code_A42234_1 = 102702001,
		// Token: 0x04000DF1 RID: 3569
		ConventionalSystem_CnvSysFeaturesSendLocationToPeer_42427_1 = 102702101,
		// Token: 0x04000DF2 RID: 3570
		BacklightColor_ColorText_1 = 103100101,
		// Token: 0x04000DF3 RID: 3571
		ZnChanCfgChannelsChannelName_A7659_1 = 103300001,
		// Token: 0x04000DF4 RID: 3572
		ZnChanCfgChannelsPersonality_A8698_1 = 103300101,
		// Token: 0x04000DF5 RID: 3573
		ZnChanCfgChannelsPersonality_A8698_2,
		// Token: 0x04000DF6 RID: 3574
		ZnChanCfgChannelsPersonality_A8698_3,
		// Token: 0x04000DF7 RID: 3575
		ZnChanCfgChannelsPersonality_A8698_4,
		// Token: 0x04000DF8 RID: 3576
		ZnChanCfgChannelsPersonality_A8698_5,
		// Token: 0x04000DF9 RID: 3577
		ZnChanCfgChannelsTalkgroup_A9276_1 = 103300201,
		// Token: 0x04000DFA RID: 3578
		ZnChanCfgChannelsTalkgroup_A9276_2,
		// Token: 0x04000DFB RID: 3579
		ZnChanCfgChannelsTalkgroup_A9276_3,
		// Token: 0x04000DFC RID: 3580
		ZnChanCfgChannelsTalkgroup_A9276_4,
		// Token: 0x04000DFD RID: 3581
		ZnChanCfgChannelsTalkgroup_A9276_5,
		// Token: 0x04000DFE RID: 3582
		ZnChanCfgChannelsConventionalChannelReference_A20560_1 = 103300301,
		// Token: 0x04000DFF RID: 3583
		ZnChanCfgChannelsFiregroundSectorID_A33630_1 = 103300401,
		// Token: 0x04000E00 RID: 3584
		Channels_ChannelsChannel_1 = 103300501,
		// Token: 0x04000E01 RID: 3585
		Channels_ChannelsChannel_2,
		// Token: 0x04000E02 RID: 3586
		Channels_ChannelsChannel_3,
		// Token: 0x04000E03 RID: 3587
		Channels_ChannelsChannel_4,
		// Token: 0x04000E04 RID: 3588
		Channels_ChannelsChannel_5,
		// Token: 0x04000E05 RID: 3589
		Channels_ChannelsChannel_6,
		// Token: 0x04000E06 RID: 3590
		Channels_ChannelsChannel_7,
		// Token: 0x04000E07 RID: 3591
		Channels_ChannelsChannel_8,
		// Token: 0x04000E08 RID: 3592
		Channels_ChannelsChannel_9,
		// Token: 0x04000E09 RID: 3593
		ConsolidatedActions_RadioErgoConfigACGeneralChannel_A36593_1 = 103500101,
		// Token: 0x04000E0A RID: 3594
		ConsolidatedActions_RadioErgoConfigACActionID_A36590_1 = 103500201,
		// Token: 0x04000E0B RID: 3595
		ConsolidatedActions_RadioErgoConfigACActionID_A36590_2,
		// Token: 0x04000E0C RID: 3596
		ConsolidatedActions_RadioErgoConfigACActionID_A36590_3,
		// Token: 0x04000E0D RID: 3597
		ConsolidatedActions_RadioErgoConfigACActionID_A36590_4,
		// Token: 0x04000E0E RID: 3598
		ConsolidatedActions_RadioErgoConfigACActionID_A36590_5,
		// Token: 0x04000E0F RID: 3599
		ConsolidatedActions_RadioErgoConfigACActionID_A36590_6,
		// Token: 0x04000E10 RID: 3600
		ConsolidatedActions_RadioErgoConfigACActionID_A36590_VP_Validity,
		// Token: 0x04000E11 RID: 3601
		ConsolidatedActions_Zone_1 = 103500301,
		// Token: 0x04000E12 RID: 3602
		ConsolidatedActions_RadioErgoConfigACAlertInterval_A42877_1 = 103500401,
		// Token: 0x04000E13 RID: 3603
		ConsolidatedActions_RadioErgoConfigACAlertInterval_A42877_2,
		// Token: 0x04000E14 RID: 3604
		ConsolidatedActions_RadioErgoConfigACGeneralErrStrategy_A36594_ExitInvalid = 103500500,
		// Token: 0x04000E15 RID: 3605
		ConventionalEmergencyProfiles_CnvEmerProfMDCEnable2_A7924_1 = 104000101,
		// Token: 0x04000E16 RID: 3606
		ConventionalEmergencyProfiles_ConEmerProEmergencyAutoTransmitMode_A22532_1 = 104000201,
		// Token: 0x04000E17 RID: 3607
		ConventionalEmergencyToneList_EmerTonePeriodSec_42048_1 = 104100101,
		// Token: 0x04000E18 RID: 3608
		ConventionalWide_CnvWideConventionalCustomerID_41558_1 = 104500001,
		// Token: 0x04000E19 RID: 3609
		ConventionalWide_CnvWideGeneralDirectFrequency_A7860_1 = 104500101,
		// Token: 0x04000E1A RID: 3610
		DataProfiles_DataProfilesDACOperationalMode_A36199_1 = 104600101,
		// Token: 0x04000E1B RID: 3611
		DataProfiles_DataProfilesDACOperationalMode_A36199_2,
		// Token: 0x04000E1C RID: 3612
		DataProfiles_DataProfilesGeneralBTDUNSUIPAddress_A41126_1 = 104700101,
		// Token: 0x04000E1D RID: 3613
		DataProfiles_DataProfilesGeneralBTDUNSUIPAddress_A41126_2,
		// Token: 0x04000E1E RID: 3614
		DataProfiles_DataProfilesGeneralBTDUNSUIPAddress_A41126_3,
		// Token: 0x04000E1F RID: 3615
		DataProfiles_DataProfilesGeneralBTDUNPeerIPAddress_A41127_1 = 104700201,
		// Token: 0x04000E20 RID: 3616
		DataProfiles_DataProfilesGeneralBTDUNPeerIPAddress_A41127_2,
		// Token: 0x04000E21 RID: 3617
		DataProfiles_DataProfilesGeneralBTDUNPeerIPAddress_A41127_3,
		// Token: 0x04000E22 RID: 3618
		DataProfiles_DataProfGeneralSubscriberIPAddress_A21157_2 = 104700402,
		// Token: 0x04000E23 RID: 3619
		DataProfiles_DataProfGeneralSubscriberAirInterfaceIPAddress_A9220_1 = 104700501,
		// Token: 0x04000E24 RID: 3620
		DataProfiles_DataProfGeneralSubscriberAirInterfaceIPAddress_A9220_2,
		// Token: 0x04000E25 RID: 3621
		DataProfiles_DataProfGeneralPacketDataMode_A8689_1 = 104700601,
		// Token: 0x04000E26 RID: 3622
		DataProfiles_DataProfLTEEnabled_A42075_1 = 104700701,
		// Token: 0x04000E27 RID: 3623
		DataProfiles_DataWideGeneralNATEnable_A38866_1 = 104700801,
		// Token: 0x04000E28 RID: 3624
		DataProfiles_DatProFeaturesPADMode_A20536_1 = 104700901,
		// Token: 0x04000E29 RID: 3625
		DataProfiles_DataProfFeaturesAutomaticRegistrationServerAddress_A7524_1 = 104701001,
		// Token: 0x04000E2A RID: 3626
		DataProfiles_DataProfFeaturesAutomaticRegistrationServerAddress_A7524_2,
		// Token: 0x04000E2B RID: 3627
		DataProfiles_DatProFeaturesDestinationPort_A20544_1 = 104701101,
		// Token: 0x04000E2C RID: 3628
		DataProfiles_DatProFeaturesEscapeSequence_A20539_1 = 104701201,
		// Token: 0x04000E2D RID: 3629
		DataProfiles_DatProFeaturesStopSequence_A20538_1 = 104701301,
		// Token: 0x04000E2E RID: 3630
		DataProfiles_DatProFeaturesStartSequence_A20537_1 = 104701401,
		// Token: 0x04000E2F RID: 3631
		DataProfiles_DataProfFeaturesARSMode_A7465_1 = 104701501,
		// Token: 0x04000E30 RID: 3632
		DataProfiles_DataProfFeaturesLocServerIPAddr_A42333_1 = 104701601,
		// Token: 0x04000E31 RID: 3633
		DataProfiles_DataConigurationDataProfilePacketDataRegistrationVersion_A36210_1 = 104701701,
		// Token: 0x04000E32 RID: 3634
		DataProfiles_DataProfNLSKeySele_A36410_1 = 104701801,
		// Token: 0x04000E33 RID: 3635
		DataProfiles_DataProfNLSKeySele_A36410_2,
		// Token: 0x04000E34 RID: 3636
		DataProfiles_DatProFeaturesDestinationAddress_A20543_1 = 104701901,
		// Token: 0x04000E35 RID: 3637
		DataProfiles_DataProfNLSSecClrStrp_A36415_1 = 104702001,
		// Token: 0x04000E36 RID: 3638
		DataProfiles_DataProfBroadbandSource_A42858_1,
		// Token: 0x04000E37 RID: 3639
		DataProfiles_DataProfBroadbandSource_A42858_2,
		// Token: 0x04000E38 RID: 3640
		DataProfiles_DataProfLTEBackupPTTGatewayPort_A43618_1 = 104702101,
		// Token: 0x04000E39 RID: 3641
		DataProfiles_DataProfLTEBackupPTTGatewayPort_A43618_2,
		// Token: 0x04000E3A RID: 3642
		DataProfiles_DataProfLTEBackupPTTGatewayPort_A43618_3,
		// Token: 0x04000E3B RID: 3643
		DataProfiles_DataProfLTEBackupPTTGatewayPort_A43618_4,
		// Token: 0x04000E3C RID: 3644
		DataProfiles_DataProfLTEBackupPTTGatewayPort_A43618_5,
		// Token: 0x04000E3D RID: 3645
		DataProfiles_DataProfLTEBackupPTTGatewayPort_A43618_6,
		// Token: 0x04000E3E RID: 3646
		DataProfiles_DataProfLTEBackupPTTGatewayPort_A43618_7,
		// Token: 0x04000E3F RID: 3647
		DataProfiles_DataProfLTEBackupPTTGatewayPort_A43618_8,
		// Token: 0x04000E40 RID: 3648
		DataWide_DataWideNATListLANPort_A8385_1 = 105000101,
		// Token: 0x04000E41 RID: 3649
		DataWide_DataWideEnhDataPortListPortNum_A42008_1 = 105000201,
		// Token: 0x04000E42 RID: 3650
		DataWide_DataWideEnhDataPortListPortNum_A42008_2,
		// Token: 0x04000E43 RID: 3651
		DataWide_DataWideEnhDataPortListPortNum_A42008_3,
		// Token: 0x04000E44 RID: 3652
		DataWide_DataWideEnhDataPortListPortNum_A42008_4,
		// Token: 0x04000E45 RID: 3653
		DataWide_QuickTextMessage_1 = 105000301,
		// Token: 0x04000E46 RID: 3654
		DataWide_DataWideGeneralBTDUNSUIPAddress_A41120_2 = 105000402,
		// Token: 0x04000E47 RID: 3655
		DataWide_DataWideGeneralBTDUNSUIPAddress_A41120_3,
		// Token: 0x04000E48 RID: 3656
		DataWide_DataWideGeneralMobileSubIPAddress_A41819_2 = 105000502,
		// Token: 0x04000E49 RID: 3657
		DataWide_DataWideGeneralDVRIPAddress_A41818_2 = 105000602,
		// Token: 0x04000E4A RID: 3658
		DataWide_DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205_1 = 105000701,
		// Token: 0x04000E4B RID: 3659
		DataWide_DataWideP25LocationReportingUDPPort_42413_1 = 105000801,
		// Token: 0x04000E4C RID: 3660
		DataWide_DataWideP25LocationReportingUDPPort_42413_2,
		// Token: 0x04000E4D RID: 3661
		DataWide_DataWideP25LocationReportingUDPPort_42413_3,
		// Token: 0x04000E4E RID: 3662
		DataWide_DataWideP25LocationReportingUDPPort_42413_4,
		// Token: 0x04000E4F RID: 3663
		DataWide_DataWideP25LocationReportingUDPPort_42413_5,
		// Token: 0x04000E50 RID: 3664
		DataWide_DataWideP25LocationReportingUDPPort_42413_6,
		// Token: 0x04000E51 RID: 3665
		DataWide_DataWideGeneralInternalRadioSubnet_A42073_1 = 105000901,
		// Token: 0x04000E52 RID: 3666
		DataWide_DataWideGeneralInternalRadioSubnet_A42073_2,
		// Token: 0x04000E53 RID: 3667
		DataWide_DataWideWIFIOTAPTCPPort_42627_0 = 105001000,
		// Token: 0x04000E54 RID: 3668
		DataWide_DataWideWIFIOTAPTCPPort_42627_1,
		// Token: 0x04000E55 RID: 3669
		DataWide_DataWideWIFIOTAPTCPPort_42627_2,
		// Token: 0x04000E56 RID: 3670
		DataWide_DataWideWIFIOTAPTCPPort_42627_3,
		// Token: 0x04000E57 RID: 3671
		DataWide_DataWideWIFIOTAPTCPPort_42627_4,
		// Token: 0x04000E58 RID: 3672
		DataWide_DataWideWIFIOTAPTCPPort_42627_5,
		// Token: 0x04000E59 RID: 3673
		DataWide_DataWideWIFIOTAPTCPPort_42627_6,
		// Token: 0x04000E5A RID: 3674
		DataWide_SensorMeasurementReportingUDPPort_A43022_0,
		// Token: 0x04000E5B RID: 3675
		DataWide_SensorMeasurementReportingUDPPort_A43022_1,
		// Token: 0x04000E5C RID: 3676
		DataWide_SensorMeasurementReportingUDPPort_A43022_2,
		// Token: 0x04000E5D RID: 3677
		DataWide_SensorMeasurementReportingUDPPort_A43022_3,
		// Token: 0x04000E5E RID: 3678
		DataWide_SensorMeasurementReportingUDPPort_A43022_4,
		// Token: 0x04000E5F RID: 3679
		DataWide_SensorMeasurementReportingUDPPort_A43022_5,
		// Token: 0x04000E60 RID: 3680
		DataWide_SensorMeasurementReportingUDPPort_A43022_6,
		// Token: 0x04000E61 RID: 3681
		DataWide_DataWideDataModemPassword_A42848_1,
		// Token: 0x04000E62 RID: 3682
		DataWide_DataWideDataModemPassword_A42848_2,
		// Token: 0x04000E63 RID: 3683
		DataWide_SensorMeasurementReportingUDPPort_A43022_7,
		// Token: 0x04000E64 RID: 3684
		DataWide_DataWideKVLKeyloadingUDPPort_43205_0 = 105001100,
		// Token: 0x04000E65 RID: 3685
		DataWide_DataWideKVLKeyloadingUDPPort_43205_1,
		// Token: 0x04000E66 RID: 3686
		DataWide_DataWideKVLKeyloadingUDPPort_43205_2,
		// Token: 0x04000E67 RID: 3687
		DataWide_DataWideKVLKeyloadingUDPPort_43205_3,
		// Token: 0x04000E68 RID: 3688
		DataWide_DataWideKVLKeyloadingUDPPort_43205_4,
		// Token: 0x04000E69 RID: 3689
		DataWide_DataWideKVLKeyloadingUDPPort_43205_5,
		// Token: 0x04000E6A RID: 3690
		DataWide_DataWideKVLKeyloadingUDPPort_43205_6,
		// Token: 0x04000E6B RID: 3691
		DataWide_DataWideKVLKeyloadingUDPPort_43205_7,
		// Token: 0x04000E6C RID: 3692
		DataWide_DataWideKVLKeyloadingUDPPort_43205_8,
		// Token: 0x04000E6D RID: 3693
		DataWide_DataWideModemConnectionType_43350,
		// Token: 0x04000E6E RID: 3694
		DEKButtons_DEKButtonFeature_A21353_1 = 105100101,
		// Token: 0x04000E6F RID: 3695
		DEKButtons_DEKButtonFeature_A21353_2,
		// Token: 0x04000E70 RID: 3696
		DEKButtons_DEKButtonFeature_A21353_3,
		// Token: 0x04000E71 RID: 3697
		DEKButtons_DEKButtonIndex_A22570_1 = 105100201,
		// Token: 0x04000E72 RID: 3698
		DEKButtons_DEKButtonIndex_A22570_2,
		// Token: 0x04000E73 RID: 3699
		DEKButtons_DEKZone_A22566_1 = 105100301,
		// Token: 0x04000E74 RID: 3700
		DEKVIP_DEKVIPOutputFeature_A21346_1 = 105200101,
		// Token: 0x04000E75 RID: 3701
		DEKVIP_DEKVIPOutputFeature_A21346_2,
		// Token: 0x04000E76 RID: 3702
		DEKVIP_DEKVIPOutputFeature_A21346_3,
		// Token: 0x04000E77 RID: 3703
		DEKVIP_DEKVIPOutputFeature_A21346_4,
		// Token: 0x04000E78 RID: 3704
		DEKVIP_DEKVIPOutputFeature_A21346_5,
		// Token: 0x04000E79 RID: 3705
		DEKVIP_DEKVIPOutputFeature_A21346_6,
		// Token: 0x04000E7A RID: 3706
		DEKVIP_DEKVIPOutputFeature_A21346_7,
		// Token: 0x04000E7B RID: 3707
		DEKVIP_DEKVIPOutputFeature_A21346_8,
		// Token: 0x04000E7C RID: 3708
		DEKVIP_DEKVIPOutputFeature_A21346_9,
		// Token: 0x04000E7D RID: 3709
		DEKVIP_DEKVIPOutputFeature_A21346_10,
		// Token: 0x04000E7E RID: 3710
		DEKVIPInputFeature_A21338_1 = 105200201,
		// Token: 0x04000E7F RID: 3711
		DEKVIPInputFeature_A21338_2,
		// Token: 0x04000E80 RID: 3712
		O9DirectionalButtons_Feature_1 = 105300101,
		// Token: 0x04000E81 RID: 3713
		O9DirectionalButtons_Feature_2,
		// Token: 0x04000E82 RID: 3714
		O9DirectionalButtons_Index_1 = 105300201,
		// Token: 0x04000E83 RID: 3715
		O9DirectionalButtons_Index_2,
		// Token: 0x04000E84 RID: 3716
		O9DirectionalButtons_Index_3,
		// Token: 0x04000E85 RID: 3717
		O9DirectionalButtons_Index_4,
		// Token: 0x04000E86 RID: 3718
		O9DirectionalButtons_Prepend_Index_1 = 105300301,
		// Token: 0x04000E87 RID: 3719
		Display_ScrollConfigurationFastScrollRatems_1 = 105700101,
		// Token: 0x04000E88 RID: 3720
		Display_DefaultBacklightColor_1 = 105700201,
		// Token: 0x04000E89 RID: 3721
		Display_FeatureInactivityTimeoutsec_1 = 105700301,
		// Token: 0x04000E8A RID: 3722
		Display_FeatureInactivityAlertTone_1 = 105700401,
		// Token: 0x04000E8B RID: 3723
		Language_DispMenuAdvancedLanguageSelection_A8386_ChineseTradition = 105790001,
		// Token: 0x04000E8C RID: 3724
		Language_DispMenuAdvancedLanguageSelection_A8386_Arabic,
		// Token: 0x04000E8D RID: 3725
		DTMFTiming_PhnWideDTMFCodesDeaccess_A7803_1 = 105900101,
		// Token: 0x04000E8E RID: 3726
		DVRSProfGeneralMSUSysPTTInLocalMode_A41803_1 = 106500101,
		// Token: 0x04000E8F RID: 3727
		DVRSProfGeneralLocalTxFallback_A41806_1 = 106500201,
		// Token: 0x04000E90 RID: 3728
		EIDBypassList_DataProfEIDByPassListIPAddr_A36417_1 = 106700001,
		// Token: 0x04000E91 RID: 3729
		EIDBypassList_DataProfEIDByPassListIPAddr_A36417_2,
		// Token: 0x04000E92 RID: 3730
		EmergencyWide_EmerWideGeneralSuppressEmergencyCall_A42142_1 = 1069001001,
		// Token: 0x04000E93 RID: 3731
		EmergencyWide_EmerWideGeneralEmergencyPowerUp_A7942_1 = 1069002001,
		// Token: 0x04000E94 RID: 3732
		EmergencyWide_EmerWideGeneralUnmuteOption_A9598_1 = 1069003001,
		// Token: 0x04000E95 RID: 3733
		EmergencyWide_EmerWideGeneralKeepAlive_A8360_1 = 1069004001,
		// Token: 0x04000E96 RID: 3734
		EncryptionKeyList_SecWideMultikeyListCKR_A7665_1 = 107000101,
		// Token: 0x04000E97 RID: 3735
		EncryptionKeyList_SecWideMultikeyListKeyName_A8362_1 = 107000201,
		// Token: 0x04000E98 RID: 3736
		EncryptionKeyList_SecWideMultikeyListSelectableADPKeyID_A9107_1 = 107000301,
		// Token: 0x04000E99 RID: 3737
		EncryptionKeyList_SecWideMultikeyListSelectableADPKeyData_A9106_1 = 107000401,
		// Token: 0x04000E9A RID: 3738
		GlobalFrequencyOptions_FrequencyMustBeInValidRange = 107500000,
		// Token: 0x04000E9B RID: 3739
		GlobalFrequencyOptions_FrequencyMustBeOnValidStep,
		// Token: 0x04000E9C RID: 3740
		GlobalFrequencyOptions_NetworkIDCanotBe3966,
		// Token: 0x04000E9D RID: 3741
		GlobalFrequencyOptions_RxNetworkIDValueMustBeSameAsFirstOne,
		// Token: 0x04000E9E RID: 3742
		GlobalFrequencyOptions_TxNetworkIDValueMustBeSameAsFirstOne,
		// Token: 0x04000E9F RID: 3743
		GlobalFrequencyOptions_AstroTalkgroupIDInvalid,
		// Token: 0x04000EA0 RID: 3744
		GlobalFrequencyOptions_TxFrequencyValueMustBeSameAsFirstOne,
		// Token: 0x04000EA1 RID: 3745
		GlobalFrequencyOptions_TxDeviationSpacing,
		// Token: 0x04000EA2 RID: 3746
		GlobalFrequencyOptions_TxDeviationChannelSpacingValueMustBeSameAsFirstOne,
		// Token: 0x04000EA3 RID: 3747
		GlobalFrequencyOptions_TxFrequencyIsNotInFCCAllowedRange,
		// Token: 0x04000EA4 RID: 3748
		GlobalFrequencyOptions_DirectTalkaroundMustBeDisabled,
		// Token: 0x04000EA5 RID: 3749
		GlobalFrequencyOptions_DirectTalkaroundMustBeDisabled2,
		// Token: 0x04000EA6 RID: 3750
		GlobalFrequencyOptions_DynamiceRegroupEnableDYN,
		// Token: 0x04000EA7 RID: 3751
		GlobalFrequencyOptions_ATGtalkgroupDisabled,
		// Token: 0x04000EA8 RID: 3752
		GlobalFrequencyOptions_RxTADPLValueMustBeSameAsFirstOne,
		// Token: 0x04000EA9 RID: 3753
		GlobalFrequencyOptions_RxTADPLInvertValueMustBeSameAsFirstOne,
		// Token: 0x04000EAA RID: 3754
		GlobalFrequencyOptions_VoteScanEnableSelectPLMPL,
		// Token: 0x04000EAB RID: 3755
		GlobalFrequencyOptions_TxSquelchTypeMustBeSameAsFirstOne,
		// Token: 0x04000EAC RID: 3756
		GlobalFrequencyOptions_TxPLFreqMustBeSameAsFirstOne,
		// Token: 0x04000EAD RID: 3757
		GlobalFrequencyOptions_TxPLCodeMustBeSameAsFirstOne,
		// Token: 0x04000EAE RID: 3758
		GlobalFrequencyOptions_TxDPLInvertMustBeSameAsFirstOne,
		// Token: 0x04000EAF RID: 3759
		GlobalFrequencyOptions_TxDPLCodeMustBeSameAsFirstOne,
		// Token: 0x04000EB0 RID: 3760
		GlobalFrequencyOptions_RxTASquelchTypeMustBeSameAsFirstOne,
		// Token: 0x04000EB1 RID: 3761
		GlobalFrequencyOptions_RxTAPLFreqMustBeSameAsFirstOne,
		// Token: 0x04000EB2 RID: 3762
		GlobalFrequencyOptions_RxTAPLCodeMustBeSameAsFirstOne,
		// Token: 0x04000EB3 RID: 3763
		GlobalFrequencyOptions_25125InvalidInASTROMode,
		// Token: 0x04000EB4 RID: 3764
		GlobalFrequencyOptions_25125InvalidInNonASTROMode,
		// Token: 0x04000EB5 RID: 3765
		GlobalFrequencyOptions_TxFrequency_FrequencyMustBeInValidRange,
		// Token: 0x04000EB6 RID: 3766
		GlobalFrequencyOptions_TxFrequency_FrequencyMustBeOnValidStep,
		// Token: 0x04000EB7 RID: 3767
		GlobalFrequencyOptions_UserSelectableEnhance_MustBeDisabled,
		// Token: 0x04000EB8 RID: 3768
		GlobalFrequencyOptions_TxDeviationSpacing_InvalidWithHearClearSecurenet,
		// Token: 0x04000EB9 RID: 3769
		Error_string_must_be_16 = 107600001,
		// Token: 0x04000EBA RID: 3770
		Error_string_must_be_64,
		// Token: 0x04000EBB RID: 3771
		Error_string_must_be_124,
		// Token: 0x04000EBC RID: 3772
		Error_string_must_be_248,
		// Token: 0x04000EBD RID: 3773
		Error_string_must_be_128_or_more,
		// Token: 0x04000EBE RID: 3774
		IDDisplayTable_Display_1 = 107900101,
		// Token: 0x04000EBF RID: 3775
		KMButton_RadErgoCfgKMConventionalKMButtonFeature_A19646_1 = 108100101,
		// Token: 0x04000EC0 RID: 3776
		KMButton_RadErgoCfgKMConventionalKMButtonFeature_A19646_2,
		// Token: 0x04000EC1 RID: 3777
		KMButton_RadErgoCfgKMConventionalKMButtonFeature_A19646_3,
		// Token: 0x04000EC2 RID: 3778
		KMButton_RadErgoCfgKMConventionalKMButtonFeature_A19646_4,
		// Token: 0x04000EC3 RID: 3779
		KMButton_RadErgoCfgKMConventionalKMButtonFeature_A19646_5,
		// Token: 0x04000EC4 RID: 3780
		KMButton_RadErgoCfgKMConventionalKMButtonFeature_A19646_6,
		// Token: 0x04000EC5 RID: 3781
		KMButton_RadErgoCfgKMConventionalKMButtonFeature_A19646_7,
		// Token: 0x04000EC6 RID: 3782
		KMButton_RadErgoCfgKMConventionalKMButtonFeature_A19646_8,
		// Token: 0x04000EC7 RID: 3783
		KMButton_RadErgoCfgKMTrunkingKMButtonFeature_A19746_1 = 108100201,
		// Token: 0x04000EC8 RID: 3784
		KMButton_RadErgoCfgKMTrunkingKMButtonFeature_A19746_2,
		// Token: 0x04000EC9 RID: 3785
		KMButton_RadErgoCfgKMTrunkingKMButtonFeature_A19746_3,
		// Token: 0x04000ECA RID: 3786
		KMButton_RadErgoCfgKMTrunkingKMButtonFeature_A19746_4,
		// Token: 0x04000ECB RID: 3787
		KMButton_RadErgoCfgKMTrunkingKMButtonFeature_A19746_5,
		// Token: 0x04000ECC RID: 3788
		KMButton_RadErgoCfgKMTrunkingKMButtonFeature_A19746_6,
		// Token: 0x04000ECD RID: 3789
		KMButton_RadErgoCfgKMTrunkingKMButtonFeature_A19746_7,
		// Token: 0x04000ECE RID: 3790
		UclMDCCnvHotList_CallID_A00047_1 = 108400101,
		// Token: 0x04000ECF RID: 3791
		UclMDCCnv_PrimaryID_A00030_1 = 108600101,
		// Token: 0x04000ED0 RID: 3792
		UclMDCCnv_PrimaryID_A00030_2,
		// Token: 0x04000ED1 RID: 3793
		UclMDCCnv_PrimaryID_A00030_3,
		// Token: 0x04000ED2 RID: 3794
		UclMDCCnv_PrimaryID_A00030_4,
		// Token: 0x04000ED3 RID: 3795
		UclMDCCnv_PrimaryID_A00030_5,
		// Token: 0x04000ED4 RID: 3796
		UclMDCCnv_SystemAlias_A00028_1 = 108600201,
		// Token: 0x04000ED5 RID: 3797
		MobileControl_BtnTrunkingButtonDatatButtonFeature_A22608_1 = 109300100,
		// Token: 0x04000ED6 RID: 3798
		MobileControl_BtnTrunkingButtonDatatButtonFeature_A22608_2,
		// Token: 0x04000ED7 RID: 3799
		MobileControl_BtnTrunkingButtonDatatButtonFeature_A22608_3,
		// Token: 0x04000ED8 RID: 3800
		MobileControl_BtnTrunkingButtonDatatButtonFeature_A22608_4,
		// Token: 0x04000ED9 RID: 3801
		MobileControl_BtnTrunkingButtonDatatButtonFeature_A22608_5,
		// Token: 0x04000EDA RID: 3802
		MobileControl_BtnTrunkingButtonDatatButtonFeature_A22608_6,
		// Token: 0x04000EDB RID: 3803
		MobileControl_CHO3DataButtonConvIndex_A41419_1 = 109300200,
		// Token: 0x04000EDC RID: 3804
		MobileControl_CHO3DataButtonConvIndex_A41419_2,
		// Token: 0x04000EDD RID: 3805
		MobileControl_CHO3DataButtonConvIndex_A41419_3,
		// Token: 0x04000EDE RID: 3806
		MobileControl_CHO3DataButtonConvIndex_A41419_4,
		// Token: 0x04000EDF RID: 3807
		MobileControl_CHO3DataButtonConvIndex_A41419_5,
		// Token: 0x04000EE0 RID: 3808
		MobileControl_CHO3DataButtonConvIndex_A41419_6,
		// Token: 0x04000EE1 RID: 3809
		MobileControl_DataButtons_ConventionalFeature_1 = 109300300,
		// Token: 0x04000EE2 RID: 3810
		MobileControl_DataButtons_ConventionalFeature_2,
		// Token: 0x04000EE3 RID: 3811
		CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_1 = 109300400,
		// Token: 0x04000EE4 RID: 3812
		CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_2,
		// Token: 0x04000EE5 RID: 3813
		CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_3,
		// Token: 0x04000EE6 RID: 3814
		CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_4,
		// Token: 0x04000EE7 RID: 3815
		CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_5,
		// Token: 0x04000EE8 RID: 3816
		CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_x,
		// Token: 0x04000EE9 RID: 3817
		MobileConvMenuItems_ConventionalSelectedMenuItem_1 = 109400101,
		// Token: 0x04000EEA RID: 3818
		MobileConvMenuItems_ConventionalSelectedMenuItem_2 = 109400201,
		// Token: 0x04000EEB RID: 3819
		MobileKeypadButton_Index_1 = 109600101,
		// Token: 0x04000EEC RID: 3820
		MobileKeypadButton_Index_2,
		// Token: 0x04000EED RID: 3821
		MobileKeypadButton_Prepend_Index_1 = 109600201,
		// Token: 0x04000EEE RID: 3822
		MobileKeypadButton_Feature_1 = 109600301,
		// Token: 0x04000EEF RID: 3823
		MobileKeypadButton_Feature_2,
		// Token: 0x04000EF0 RID: 3824
		MobileKeypadButton_Feature_3,
		// Token: 0x04000EF1 RID: 3825
		MobileKeypadButton_Feature_4,
		// Token: 0x04000EF2 RID: 3826
		MobileKeypadButton_Feature_5,
		// Token: 0x04000EF3 RID: 3827
		MobileKeypadButton_Feature_6,
		// Token: 0x04000EF4 RID: 3828
		MobileKeypadButton_Feature_7,
		// Token: 0x04000EF5 RID: 3829
		MobileKeypadButton_Feature_8,
		// Token: 0x04000EF6 RID: 3830
		MobileMFKAssignmentControl_Feature_1 = 109700101,
		// Token: 0x04000EF7 RID: 3831
		MobileMFKAssignmentControl_Feature_2,
		// Token: 0x04000EF8 RID: 3832
		MobileMFKAssignmentControl_Feature_3,
		// Token: 0x04000EF9 RID: 3833
		MobileMFKAssignmentControl_Feature_4,
		// Token: 0x04000EFA RID: 3834
		O3HHCHButton_ConvAndTrkFeature_1 = 111100101,
		// Token: 0x04000EFB RID: 3835
		O3HHCHButton_ConvAndTrkFeature_2,
		// Token: 0x04000EFC RID: 3836
		O3HHCHButton_ConvAndTrkFeature_3,
		// Token: 0x04000EFD RID: 3837
		O3HHCHButton_ConvAndTrkFeature_4,
		// Token: 0x04000EFE RID: 3838
		O9BottomFuncPgmBtn_Index_1 = 111300101,
		// Token: 0x04000EFF RID: 3839
		O9BottomFuncPgmBtn_Index_2,
		// Token: 0x04000F00 RID: 3840
		O9BottomFuncPgmBtn_Index_3,
		// Token: 0x04000F01 RID: 3841
		O9BottomFuncPgmBtn_Index_4,
		// Token: 0x04000F02 RID: 3842
		O9BottomFuncPgmBtn_Index_5,
		// Token: 0x04000F03 RID: 3843
		O9BottomFuncPgmBtn_Index_6,
		// Token: 0x04000F04 RID: 3844
		O9BottomFunctionButton_CHO9BottomFunctionButtonFeature_A36664_1 = 111300201,
		// Token: 0x04000F05 RID: 3845
		O9BottomFunctionButton_CHO9BottomFunctionButtonFeature_A36664_2,
		// Token: 0x04000F06 RID: 3846
		O9BottomFunctionButton_CHO9BottomFunctionButtonFeature_A36664_3,
		// Token: 0x04000F07 RID: 3847
		O9BottomFunctionButton_CHO9BottomFunctionButtonFeature_A36664_4,
		// Token: 0x04000F08 RID: 3848
		O9BottomFunctionButton_CHO9BottomFunctionButtonFeature_A36664_5,
		// Token: 0x04000F09 RID: 3849
		O9BottomFunctionButton_CHO9BottomFunctionButtonFeature_A36664_6,
		// Token: 0x04000F0A RID: 3850
		O9BottomFunctionButton_CHO9BottomFunctionButtonFeature_A36664_7,
		// Token: 0x04000F0B RID: 3851
		OTACItem_CnvWideASTROOTACChannel_A8629_1 = 115000101,
		// Token: 0x04000F0C RID: 3852
		OTACItem_CnvWideASTROOTACChannel_A8629_2,
		// Token: 0x04000F0D RID: 3853
		OTACItem_CnvWideASTROOTACZone_A8645_1 = 115000201,
		// Token: 0x04000F0E RID: 3854
		PASirenButtons_CHO9PASirenButtonsFeature_A41540_1 = 111600101,
		// Token: 0x04000F0F RID: 3855
		PASirenButtons_CHO9PASirenButtonsFeature_A41540_2,
		// Token: 0x04000F10 RID: 3856
		PASirenButtons_CHO9PASirenButtonsFeature_A41540_3,
		// Token: 0x04000F11 RID: 3857
		PASirenButtons_CHO9PASirenButtonsFeature_A41540_4,
		// Token: 0x04000F12 RID: 3858
		PASirenButtons_CHO9PASirenButtonsFeature_A41540_5,
		// Token: 0x04000F13 RID: 3859
		PASirenButtons_CHO9PASirenButtonsFeature_A41540_6,
		// Token: 0x04000F14 RID: 3860
		PerAccList_RadioErgoConfigACReference_A42911_1 = 111600201,
		// Token: 0x04000F15 RID: 3861
		UclPhoneHotList_CallID_A00050_1 = 111700101,
		// Token: 0x04000F16 RID: 3862
		UclPhone_ListinfoPhoneCategory_A00034_1 = 111900101,
		// Token: 0x04000F17 RID: 3863
		UclPhone_PhoneNumber_A00033_1 = 111900201,
		// Token: 0x04000F18 RID: 3864
		UclPhone_PhoneNumber_A00033_2,
		// Token: 0x04000F19 RID: 3865
		PortableButton_BtnGeneralConventionalFeature_A19544_1 = 112100101,
		// Token: 0x04000F1A RID: 3866
		PortableButton_BtnGeneralConventionalFeature_A19544_2,
		// Token: 0x04000F1B RID: 3867
		PortableButton_BtnGeneralConventionalFeature_A19544_3,
		// Token: 0x04000F1C RID: 3868
		PortableButton_BtnGeneralConventionalFeature_A19544_4,
		// Token: 0x04000F1D RID: 3869
		PortableButton_BtnGeneralConventionalFeature_A19544_5,
		// Token: 0x04000F1E RID: 3870
		PortableButton_BtnGeneralConventionalFeature_A19544_6,
		// Token: 0x04000F1F RID: 3871
		PortableButton_BtnGeneralConventionalFeature_A19544_7,
		// Token: 0x04000F20 RID: 3872
		PortableButton_BtnGeneralConventionalFeature_A19544_8,
		// Token: 0x04000F21 RID: 3873
		PortableButton_BtnGeneralConventionalFeature_A19544_9,
		// Token: 0x04000F22 RID: 3874
		PortableButton_BtnGeneralConventionalFeature_A19544_10,
		// Token: 0x04000F23 RID: 3875
		PortableButton_BtnGeneralConventionalFeature_A19544_11,
		// Token: 0x04000F24 RID: 3876
		PortableButton_BtnGeneralConventionalFeature_A19544_12,
		// Token: 0x04000F25 RID: 3877
		PortableButton_BtnGeneralConventionalFeature_A19544_13,
		// Token: 0x04000F26 RID: 3878
		PortableButton_BtnGeneralConventionalFeature_A19544_14,
		// Token: 0x04000F27 RID: 3879
		PortableButton_BtnGeneralConventionalFeature_A19544_15,
		// Token: 0x04000F28 RID: 3880
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_1 = 112100201,
		// Token: 0x04000F29 RID: 3881
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_2,
		// Token: 0x04000F2A RID: 3882
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_3,
		// Token: 0x04000F2B RID: 3883
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_4,
		// Token: 0x04000F2C RID: 3884
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_5,
		// Token: 0x04000F2D RID: 3885
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_6,
		// Token: 0x04000F2E RID: 3886
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_7,
		// Token: 0x04000F2F RID: 3887
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_8,
		// Token: 0x04000F30 RID: 3888
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_9,
		// Token: 0x04000F31 RID: 3889
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_10,
		// Token: 0x04000F32 RID: 3890
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_11,
		// Token: 0x04000F33 RID: 3891
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_12,
		// Token: 0x04000F34 RID: 3892
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_13,
		// Token: 0x04000F35 RID: 3893
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_14,
		// Token: 0x04000F36 RID: 3894
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_15,
		// Token: 0x04000F37 RID: 3895
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_16,
		// Token: 0x04000F38 RID: 3896
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_17,
		// Token: 0x04000F39 RID: 3897
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_18,
		// Token: 0x04000F3A RID: 3898
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_19,
		// Token: 0x04000F3B RID: 3899
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_20,
		// Token: 0x04000F3C RID: 3900
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_21,
		// Token: 0x04000F3D RID: 3901
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_22,
		// Token: 0x04000F3E RID: 3902
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_23,
		// Token: 0x04000F3F RID: 3903
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_24,
		// Token: 0x04000F40 RID: 3904
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_25,
		// Token: 0x04000F41 RID: 3905
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_26,
		// Token: 0x04000F42 RID: 3906
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_29,
		// Token: 0x04000F43 RID: 3907
		PortConvMenuItems_ConventionalSelectedMenuItem_1 = 112200101,
		// Token: 0x04000F44 RID: 3908
		BtnSideUpDownArrowButtonPrimaryFunction_A41568_1 = 112500101,
		// Token: 0x04000F45 RID: 3909
		BtnSideUpDownArrowButtonSecondaryFunction_A41592_1 = 112500201,
		// Token: 0x04000F46 RID: 3910
		RadErgoWideAdvancedLongKeypressDurationms_A8450_1 = 113000101,
		// Token: 0x04000F47 RID: 3911
		RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451_1 = 113000201,
		// Token: 0x04000F48 RID: 3912
		RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451_2,
		// Token: 0x04000F49 RID: 3913
		RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126_1,
		// Token: 0x04000F4A RID: 3914
		RadErgoWidePASirenManualTone_A8464_1 = 113000301,
		// Token: 0x04000F4B RID: 3915
		RadErgoWideControlHeadMulCHTxAudioRouting_A38459_1 = 113000401,
		// Token: 0x04000F4C RID: 3916
		RadErgoWideControlHeadControlHeadVIPInputSource_A7724_1 = 113000501,
		// Token: 0x04000F4D RID: 3917
		RadErgoWideControlHeadControlHeadVIPInputSource_A7724_2,
		// Token: 0x04000F4E RID: 3918
		RadErgoWideAdvancedLongKeypressDurationforMFK_A38506_1 = 113000601,
		// Token: 0x04000F4F RID: 3919
		RadErgoWidePASirenSirenPAAfterReset_A9140_1 = 113000701,
		// Token: 0x04000F50 RID: 3920
		RadErgoWidePASirenSirenPAAfterReset_A9140_2,
		// Token: 0x04000F51 RID: 3921
		RadErgoWidePASirenSirenPAAfterReset_A9140_3,
		// Token: 0x04000F52 RID: 3922
		RadErgoWideHomeModeZone_A9691_1 = 113000801,
		// Token: 0x04000F53 RID: 3923
		RadErgoWideHomeModeZone_A9691_2,
		// Token: 0x04000F54 RID: 3924
		HomeModeChannel_1 = 113000901,
		// Token: 0x04000F55 RID: 3925
		HomeModeChannel_2,
		// Token: 0x04000F56 RID: 3926
		HomeModeChannel_3,
		// Token: 0x04000F57 RID: 3927
		RadErgoWideAdvancedConsoletteEnable_A37231_1 = 113001001,
		// Token: 0x04000F58 RID: 3928
		RadErgoWideControlHeadExpectedNumofControlHeads_A7982_1 = 113001101,
		// Token: 0x04000F59 RID: 3929
		RadErgoWideControlHeadExpectedNumofControlHeads_A7982_2,
		// Token: 0x04000F5A RID: 3930
		RadErgoWideControlHeadExpectedNumofControlHeads_A7982_3,
		// Token: 0x04000F5B RID: 3931
		RadErgoWideControlHeadExpectedNumofControlHeads_A7982_4,
		// Token: 0x04000F5C RID: 3932
		RadioErgonomicsWide_RadErgoWideHornandLightsHornLights_A8206_1 = 113001201,
		// Token: 0x04000F5D RID: 3933
		RadioErgonomicsWide_RadErgoWidePASirenSirenOperation_A9139_1 = 113001301,
		// Token: 0x04000F5E RID: 3934
		RadioErgonomicsWide_RadErgoWideControlHeadAggregateCableLength_A38456_1 = 113001401,
		// Token: 0x04000F5F RID: 3935
		RadioErgonomicsWide_RadErgoWideControlHeadMultiControlHead_A8550_1 = 113001501,
		// Token: 0x04000F60 RID: 3936
		RadioErgonomicsWide_RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787_1 = 113001601,
		// Token: 0x04000F61 RID: 3937
		RadErgoWideMOSCADDataEnable_A8545_1 = 113001701,
		// Token: 0x04000F62 RID: 3938
		RadErgoWideMOSCADDataEnable_A8545_2,
		// Token: 0x04000F63 RID: 3939
		RadErgoWideMOSCADDataEnable_A8545_3,
		// Token: 0x04000F64 RID: 3940
		RadErgoWideMOSCADDataEnable_A8545_4,
		// Token: 0x04000F65 RID: 3941
		McGeofencePriority_42879_1 = 113010101,
		// Token: 0x04000F66 RID: 3942
		McGeofenceRadiusInMeters_42890_1,
		// Token: 0x04000F67 RID: 3943
		McGeofenceRadiusInMeters_42890_2,
		// Token: 0x04000F68 RID: 3944
		RadioErgoConfigACActionType_A42871_1,
		// Token: 0x04000F69 RID: 3945
		RadioErgoConfigACActionType_A42871_2,
		// Token: 0x04000F6A RID: 3946
		RadioProfiles_MinimumAlertToneVolume_1 = 113100101,
		// Token: 0x04000F6B RID: 3947
		RadioProfiles_VolumeControlMinimumAudioVolume_1 = 113100201,
		// Token: 0x04000F6C RID: 3948
		RadioProfiles_TxDigitalAnalogBalance_1 = 113100301,
		// Token: 0x04000F6D RID: 3949
		RadioProfiles_IntelligentLightingDisableCallNotification_1 = 113100401,
		// Token: 0x04000F6E RID: 3950
		RadioProfiles_IntelligentLightingDisableCallNotification_2,
		// Token: 0x04000F6F RID: 3951
		RadioProfiles_IntelligentLightingDisableCriticalNotification_1 = 113100501,
		// Token: 0x04000F70 RID: 3952
		RadioProfiles_IntelligentLightingDisableCriticalNotification_2,
		// Token: 0x04000F71 RID: 3953
		RadioProfiles_IntelligentLightingDisableEmergencyNotification_1 = 113100601,
		// Token: 0x04000F72 RID: 3954
		RadioProfiles_IntelligentLightingDisableEmergencyNotification_2,
		// Token: 0x04000F73 RID: 3955
		RadioProfiles_SurveillanceModeDisableLights_1 = 113100701,
		// Token: 0x04000F74 RID: 3956
		RadioProfiles_PermanentDisableTxRxLED_1 = 113100801,
		// Token: 0x04000F75 RID: 3957
		RadioProfiles_PermanentFrontDisplayBacklight_1 = 113100901,
		// Token: 0x04000F76 RID: 3958
		RadioProfiles_NoiseReductionExternalMicBackgroundNoiseReductionLevel_1 = 113101101,
		// Token: 0x04000F77 RID: 3959
		RadioProfiles_NoiseReductionExternalMicBackgroundNoiseReductionLevel_2,
		// Token: 0x04000F78 RID: 3960
		RadioProfiles_RadProfExternalMicWindNoiseReductionLevelSelection_A21511_1 = 113101501,
		// Token: 0x04000F79 RID: 3961
		RadioProfiles_RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292_1 = 113101601,
		// Token: 0x04000F7A RID: 3962
		RadioProfiles_RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292_2,
		// Token: 0x04000F7B RID: 3963
		RadioProfiles_RadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194_1 = 113101701,
		// Token: 0x04000F7C RID: 3964
		RadioProfiles_ExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688_1 = 113101901,
		// Token: 0x04000F7D RID: 3965
		RadioProfiles_ExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687_1 = 113102001,
		// Token: 0x04000F7E RID: 3966
		RadioProfiles_ExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686_1 = 113102101,
		// Token: 0x04000F7F RID: 3967
		RadioProfiles_IntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678_1 = 113102201,
		// Token: 0x04000F80 RID: 3968
		RadioProfiles_IntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677_1 = 113102301,
		// Token: 0x04000F81 RID: 3969
		RadioProfiles_IntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676_1 = 113102401,
		// Token: 0x04000F82 RID: 3970
		RadioProfiles_RadProfAudioSettingsAnalogAGC2_A7439_1 = 113108501,
		// Token: 0x04000F83 RID: 3971
		RadioProfiles_NoRadioWide,
		// Token: 0x04000F84 RID: 3972
		RadioProfiles_RadioNOTSameAcc,
		// Token: 0x04000F85 RID: 3973
		RadioProfiles_AnalogBanalanceAcc_1,
		// Token: 0x04000F86 RID: 3974
		RadioProfiles_FieldValueDoesNotMatchTheGroupSettingDefinedValue_1,
		// Token: 0x04000F87 RID: 3975
		RadioVIP_OutputFeature_1 = 113200101,
		// Token: 0x04000F88 RID: 3976
		RadioVIP_OutputFeature_2,
		// Token: 0x04000F89 RID: 3977
		RadioVIP_OutputFeature_3,
		// Token: 0x04000F8A RID: 3978
		RadioVIP_OutputFeature_4,
		// Token: 0x04000F8B RID: 3979
		RadioVIP_OutputFeature_5,
		// Token: 0x04000F8C RID: 3980
		RadioVIP_OutputFeature_6,
		// Token: 0x04000F8D RID: 3981
		RadioVIP_OutputFeature_7,
		// Token: 0x04000F8E RID: 3982
		RadioVIP_OutputFeature_8,
		// Token: 0x04000F8F RID: 3983
		RadioVIP_OutputFeature_9,
		// Token: 0x04000F90 RID: 3984
		RadioVIP_OutputFeature_10,
		// Token: 0x04000F91 RID: 3985
		RadioVIP_OutputFeature_11,
		// Token: 0x04000F92 RID: 3986
		RadioVIP_OutputFeature_12,
		// Token: 0x04000F93 RID: 3987
		RadioVIP_OutputFeature_13,
		// Token: 0x04000F94 RID: 3988
		RadioVIP_OutputFeature_14,
		// Token: 0x04000F95 RID: 3989
		RadioVIP_OutputFeature_15,
		// Token: 0x04000F96 RID: 3990
		RadioVIP_OutputFeature_16,
		// Token: 0x04000F97 RID: 3991
		RadioVIP_InputFeature_1 = 113200201,
		// Token: 0x04000F98 RID: 3992
		RadioVIP_InputFeature_2,
		// Token: 0x04000F99 RID: 3993
		RadioVIP_InputFeature_3,
		// Token: 0x04000F9A RID: 3994
		GCAIVIP_InputFeature_1 = 113210000,
		// Token: 0x04000F9B RID: 3995
		GCAIVIP_InputFeature_2,
		// Token: 0x04000F9C RID: 3996
		AdvancedAuxTransmitSensitivity_A7530_1 = 113400101,
		// Token: 0x04000F9D RID: 3997
		SwitchConventionalSwitchesPosition1_A12643_1 = 113400201,
		// Token: 0x04000F9E RID: 3998
		SwitchConventionalSwitchesPosition1_A12643_2,
		// Token: 0x04000F9F RID: 3999
		SwitchConventionalSwitchesPosition1_A12643_3,
		// Token: 0x04000FA0 RID: 4000
		RadWideLocationUserSelectableLocationEnable_A9605_1 = 113400301,
		// Token: 0x04000FA1 RID: 4001
		RadWideLocationUserSelectableLocationEnable_A9605_2,
		// Token: 0x04000FA2 RID: 4002
		RadWideLabtoolDigitalAnalogBalance_A7851_1 = 113400401,
		// Token: 0x04000FA3 RID: 4003
		RadWideAdvancedRFModem_A8972_1 = 113400701,
		// Token: 0x04000FA4 RID: 4004
		RadWideBluetoothBluetoothPANNetworkAddress_41983_1 = 113400801,
		// Token: 0x04000FA5 RID: 4005
		RadWideBluetoothBluetoothPANNetworkAddress_41983_2,
		// Token: 0x04000FA6 RID: 4006
		RadWideBluetoothBluetoothPANNetworkAddress_41983_3,
		// Token: 0x04000FA7 RID: 4007
		RadWideBluetoothBluetoothPANNetworkAddress_41983_4,
		// Token: 0x04000FA8 RID: 4008
		RadWideBluetoothBluetoothPANNetworkAddress_41983_5,
		// Token: 0x04000FA9 RID: 4009
		RadWideBluetoothBluetoothPANNetworkAddress_41983_6,
		// Token: 0x04000FAA RID: 4010
		RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453_1 = 113400901,
		// Token: 0x04000FAB RID: 4011
		RadWideUserInformationandPasswordsRadioLock_A8836_1 = 113401001,
		// Token: 0x04000FAC RID: 4012
		RadWideBluetoothBluetoothDropTimer_A37038_1 = 113401101,
		// Token: 0x04000FAD RID: 4013
		RadWideUniversalRelayControllerEquipped_A37191_1 = 113401201,
		// Token: 0x04000FAE RID: 4014
		RadWideUniversalRelayControllerEquipped_A37191_2,
		// Token: 0x04000FAF RID: 4015
		RadWideDualRadioSecRadioTransmissionCapability_A42238_1 = 113401301,
		// Token: 0x04000FB0 RID: 4016
		RadWideDualRadioSecRadioTransmissionCapability_A42238_2,
		// Token: 0x04000FB1 RID: 4017
		RadWideDualRadioEmergencyRadio_A42239_1 = 113401401,
		// Token: 0x04000FB2 RID: 4018
		RadWideDualRadioEmergencyRadio_A42239_2,
		// Token: 0x04000FB3 RID: 4019
		RadWideDualRadioEmergencyRadio_A42239_3,
		// Token: 0x04000FB4 RID: 4020
		RadWideFeaturesTargetZoneOnOffHook_A42355,
		// Token: 0x04000FB5 RID: 4021
		RadWideFeaturesTargetChanOnOffHook_A42356,
		// Token: 0x04000FB6 RID: 4022
		RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551,
		// Token: 0x04000FB7 RID: 4023
		RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552,
		// Token: 0x04000FB8 RID: 4024
		RadWideLabtoolRadioPassword_A8837_1,
		// Token: 0x04000FB9 RID: 4025
		RadWideLabtoolRadioPassword_A8837_2,
		// Token: 0x04000FBA RID: 4026
		RadWideFeaturesExtRFRoute_A43020_1 = 113401501,
		// Token: 0x04000FBB RID: 4027
		RadWideLocationSystemManagedGeofence_43042_1 = 113401601,
		// Token: 0x04000FBC RID: 4028
		RadWideUserInformationandPasswordsProtectedZonePassword_A8766_1 = 113401701,
		// Token: 0x04000FBD RID: 4029
		RadWideUserInformationandPasswordsProtectedZonePassword_A8766_2,
		// Token: 0x04000FBE RID: 4030
		RadWideFeaturesZoneCloneEnable_43130_1 = 113401801,
		// Token: 0x04000FBF RID: 4031
		TtsAnnouncementTextRequiredForEncoding,
		// Token: 0x04000FC0 RID: 4032
		RadioLockPasswordLengthBasedOnPCIValidity_1 = 113401901,
		// Token: 0x04000FC1 RID: 4033
		RadWideGenLightBarPatternRelay1_A36506_1 = 113500101,
		// Token: 0x04000FC2 RID: 4034
		RadWideGenLightBarPatternRelay1_A36506_2,
		// Token: 0x04000FC3 RID: 4035
		RadWideGenLightBarPatternRelay2_A36507_1 = 113500201,
		// Token: 0x04000FC4 RID: 4036
		RadWideGenLightBarPatternRelay2_A36507_2,
		// Token: 0x04000FC5 RID: 4037
		RadWideGenLightBarPatternRelay3_A36508_1 = 113500301,
		// Token: 0x04000FC6 RID: 4038
		RadWideGenLightBarPatternRelay3_A36508_2,
		// Token: 0x04000FC7 RID: 4039
		RadWideGenLightBarPatternRelay4_A36509_1 = 113500401,
		// Token: 0x04000FC8 RID: 4040
		RadWideGenLightBarPatternRelay4_A36509_2,
		// Token: 0x04000FC9 RID: 4041
		RadWideGenLightBarPatternRelay5_A36510_1 = 113500501,
		// Token: 0x04000FCA RID: 4042
		RadWideGenLightBarPatternRelay5_A36510_2,
		// Token: 0x04000FCB RID: 4043
		RadWideGenLightBarPatternRelay6_A36511_1 = 113500601,
		// Token: 0x04000FCC RID: 4044
		RadWideGenLightBarPatternRelay6_A36511_2,
		// Token: 0x04000FCD RID: 4045
		RadWideGenLightBarPatternRelay7_A36512_1 = 113500701,
		// Token: 0x04000FCE RID: 4046
		RadWideGenLightBarPatternRelay7_A36512_2,
		// Token: 0x04000FCF RID: 4047
		RadWideGenLightBarPatternRelay8_A36513_1 = 113500801,
		// Token: 0x04000FD0 RID: 4048
		RadWideGenLightBarPatternRelay8_A36513_2,
		// Token: 0x04000FD1 RID: 4049
		RadWideGenLightBarPatternRelay9_A36515_1 = 113500901,
		// Token: 0x04000FD2 RID: 4050
		RadWideGenLightBarPatternRelay9_A36515_2,
		// Token: 0x04000FD3 RID: 4051
		RadWideGenLightBarPatternRelay10_A36516_1 = 113501001,
		// Token: 0x04000FD4 RID: 4052
		RadWideGenLightBarPatternRelay10_A36516_2,
		// Token: 0x04000FD5 RID: 4053
		O9ResponseSelector_Index_1 = 113800101,
		// Token: 0x04000FD6 RID: 4054
		O9ResponseSelector_Index_2,
		// Token: 0x04000FD7 RID: 4055
		O9ResponseSelector_Index_3,
		// Token: 0x04000FD8 RID: 4056
		FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017_1 = 114000101,
		// Token: 0x04000FD9 RID: 4057
		FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017_2,
		// Token: 0x04000FDA RID: 4058
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_1 = 114100101,
		// Token: 0x04000FDB RID: 4059
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_2,
		// Token: 0x04000FDC RID: 4060
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_3,
		// Token: 0x04000FDD RID: 4061
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_4,
		// Token: 0x04000FDE RID: 4062
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_5,
		// Token: 0x04000FDF RID: 4063
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_6,
		// Token: 0x04000FE0 RID: 4064
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_7,
		// Token: 0x04000FE1 RID: 4065
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_8,
		// Token: 0x04000FE2 RID: 4066
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_9,
		// Token: 0x04000FE3 RID: 4067
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_10,
		// Token: 0x04000FE4 RID: 4068
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_11,
		// Token: 0x04000FE5 RID: 4069
		ScanList_ScanLstGeneralPriority1Type_A8745_1 = 114100201,
		// Token: 0x04000FE6 RID: 4070
		ScanList_ScanLstGeneralPriorityMember1_A8747_1 = 114100301,
		// Token: 0x04000FE7 RID: 4071
		ScanList_ScanLstGeneralPriorityMember1_A8747_2,
		// Token: 0x04000FE8 RID: 4072
		ScanList_ScanLstGeneralPriorityMember1_A8747_3,
		// Token: 0x04000FE9 RID: 4073
		ScanList_ScanLstGeneralPriorityMember2_A8749_1 = 114100401,
		// Token: 0x04000FEA RID: 4074
		ScanList_ScanLstGeneralPriorityMember2_A8749_2,
		// Token: 0x04000FEB RID: 4075
		ScanList_ScanLstGeneralPriorityMember2_A8749_3,
		// Token: 0x04000FEC RID: 4076
		ScanList_ScanLstGeneralDesignatedVoiceTxMemberType_A21524_1 = 114100501,
		// Token: 0x04000FED RID: 4077
		ScanList_ScanLstGeneralDesignatedVoiceTxMember_A7830_1 = 114100601,
		// Token: 0x04000FEE RID: 4078
		ScanList_ScanLstGeneralDesignatedVoiceTxMember_A7830_2,
		// Token: 0x04000FEF RID: 4079
		ScanMemberList_ScanLstScanListChannel_A7620_1 = 114200101,
		// Token: 0x04000FF0 RID: 4080
		ScanMemberList_ScanLstScanListChannel_A7620_2,
		// Token: 0x04000FF1 RID: 4081
		ScanMemberList_ScanLstScanListChannel_A7620_3,
		// Token: 0x04000FF2 RID: 4082
		ScanMemberList_ScanLstScanListChannel_A7620_5,
		// Token: 0x04000FF3 RID: 4083
		ScanMemberList_ScanLstScanListChannel_A7620_6,
		// Token: 0x04000FF4 RID: 4084
		ScanMemberList_ScanLstScanListChannel_A7620_7,
		// Token: 0x04000FF5 RID: 4085
		ScanMemberList_ScanLstScanListChannel_A7620_8,
		// Token: 0x04000FF6 RID: 4086
		ScanMemberList_ScanLstScanListChannel_A7620_9,
		// Token: 0x04000FF7 RID: 4087
		ScanMemberList_ScanLstScanListChannel_A7620_10,
		// Token: 0x04000FF8 RID: 4088
		ScanMemberList_ScanLstScanListChannel_A7620_13,
		// Token: 0x04000FF9 RID: 4089
		ScanMemberList_ScanLstScanListChannel_A7620_14,
		// Token: 0x04000FFA RID: 4090
		ScanMemberList_ScanLstScanListChannel_A7620_15,
		// Token: 0x04000FFB RID: 4091
		ScanMemberList_ScanLstScanListChannel_A7620_16,
		// Token: 0x04000FFC RID: 4092
		ScanMemberList_ScanLstScanListChannel_A7620_17,
		// Token: 0x04000FFD RID: 4093
		ScanMemberList_ScanLstScanListChannel_A7620_18,
		// Token: 0x04000FFE RID: 4094
		ScanMemberList_ScanLstScanListChannel_A7620_19,
		// Token: 0x04000FFF RID: 4095
		ScanMemberList_ScanLstScanListChannel_A7620_20,
		// Token: 0x04001000 RID: 4096
		ScanMemberList_ScanLstScanListChannel_A7620_21,
		// Token: 0x04001001 RID: 4097
		ScanMemberList_ScanLstScanListChannel_A7620_22,
		// Token: 0x04001002 RID: 4098
		ScanMemberList_ScanLstScanListChannel_A7620_23,
		// Token: 0x04001003 RID: 4099
		ScanMemberList_ScanLstScanListChannel_A7620_25,
		// Token: 0x04001004 RID: 4100
		ScanMemberList_ScanLstScanListChannel_A7620_26,
		// Token: 0x04001005 RID: 4101
		ScanMemberList_ScanLstScanListChannel_A7620_27,
		// Token: 0x04001006 RID: 4102
		ScanMemberList_ScanLstScanListChannel_A7620_28,
		// Token: 0x04001007 RID: 4103
		ScanMemberList_ScanLstScanListChannel_A7620_29,
		// Token: 0x04001008 RID: 4104
		ScanMemberList_ScanLstScanListChannel_A7620_31,
		// Token: 0x04001009 RID: 4105
		ScanMemberList_ScanLstScanListChannel_A7620_32,
		// Token: 0x0400100A RID: 4106
		ScanMemberList_ScanLstScanListChannel_A7620_33,
		// Token: 0x0400100B RID: 4107
		ScanMemberList_ScanLstScanListChannel_A7620_34,
		// Token: 0x0400100C RID: 4108
		ScanMemberList_ScanLstScanListChannel_A7620_35,
		// Token: 0x0400100D RID: 4109
		ScanMemberList_ScanLstScanListZone_A9718_1 = 114200201,
		// Token: 0x0400100E RID: 4110
		ScanMemberList_ScanLstScanListZone_A9718_2,
		// Token: 0x0400100F RID: 4111
		ScanMemberList_ScanLstScanListZone_A9718_3,
		// Token: 0x04001010 RID: 4112
		ScanMemberList_MaxNumber_Conventional = 114200301,
		// Token: 0x04001011 RID: 4113
		ScanMemberList_MaxNumber_PriorityMon,
		// Token: 0x04001012 RID: 4114
		ScanMemberList_MaxNumber_MultiSystem,
		// Token: 0x04001013 RID: 4115
		ScanMemberList_MaxNumber_VotingScan,
		// Token: 0x04001014 RID: 4116
		ScanMemberList_MaxNumber_Default,
		// Token: 0x04001015 RID: 4117
		FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062_1 = 114400101,
		// Token: 0x04001016 RID: 4118
		FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062_2,
		// Token: 0x04001017 RID: 4119
		SecureHardwareEncryptionKeyReferencesList_SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194_1 = 114500101,
		// Token: 0x04001018 RID: 4120
		SecKmfProfDataTransportKMFIPAddress_A8375_1 = 1146001001,
		// Token: 0x04001019 RID: 4121
		SecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674_1 = 1146001101,
		// Token: 0x0400101A RID: 4122
		SecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677_1,
		// Token: 0x0400101B RID: 4123
		SecureWide_SecWideGeneralSecureOperation_A9067_1 = 1147001001,
		// Token: 0x0400101C RID: 4124
		SecureWide_SecWideGeneralSecureOperation_A9067_2,
		// Token: 0x0400101D RID: 4125
		SecureWide_SecWideGeneralSecureOperation_A9067_3,
		// Token: 0x0400101E RID: 4126
		SecureWide_SecWideASTROOTARASTROOTAREnable_A7496_1 = 1147002001,
		// Token: 0x0400101F RID: 4127
		SecureWide_SecWideASTROOTARASTROOTAREnable_A7496_2,
		// Token: 0x04001020 RID: 4128
		SecureWide_SecWideMDCOTARMDCOTAREnable_A8488_1 = 1147003001,
		// Token: 0x04001021 RID: 4129
		SecureWide_SecWideMDCOTARMDCOTARSystem_A8490_1 = 1147004001,
		// Token: 0x04001022 RID: 4130
		SecureWide_SecWideMDCOTARMDCOTARSystem_A8490_2,
		// Token: 0x04001023 RID: 4131
		SecureWide_SecWideFeaturesInfiniteKeyRetention_A8292_1 = 1147005001,
		// Token: 0x04001024 RID: 4132
		SecureWide_SecWideFeaturesClearAlertTones_A9524_1 = 1147006001,
		// Token: 0x04001025 RID: 4133
		SecureWide_SecWideInfiniteUKEKRetention_A41551_1 = 1147007001,
		// Token: 0x04001026 RID: 4134
		SecureWide_SecWideMultikeyErasePreviousOnUserChange_A8373_1 = 114700801,
		// Token: 0x04001027 RID: 4135
		SecureWide_SecWideMultikeyDisplayOnModeChange_A7877_1 = 114700901,
		// Token: 0x04001028 RID: 4136
		SecureWide_SecWideMultikeyDisplayOnModeChange_A7877_2,
		// Token: 0x04001029 RID: 4137
		SecureWide_SecWideMultikeyDisplayOnPTT_A7879_1 = 114701001,
		// Token: 0x0400102A RID: 4138
		SecureWide_SecWideMultikeyDisplayOnPTT_A7879_2,
		// Token: 0x0400102B RID: 4139
		SecureWide_SecWideMultikeyDisplayOnSecureSwitchSelect_A7881_1 = 114701101,
		// Token: 0x0400102C RID: 4140
		SecureWide_SecWideMultikeyDisplayOnSecureSwitchSelect_A7881_2,
		// Token: 0x0400102D RID: 4141
		SecureWide_SecureWideADPAlgorithmEnable_43200_1 = 114701201,
		// Token: 0x0400102E RID: 4142
		SecureWide_SecureWideKeyloadingSource_43204_1 = 114701301,
		// Token: 0x0400102F RID: 4143
		SecureWide_SecWideGeneralEnhancedADPRadioInhibit_A41461_1 = 114701401,
		// Token: 0x04001030 RID: 4144
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_1 = 115600101,
		// Token: 0x04001031 RID: 4145
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_2,
		// Token: 0x04001032 RID: 4146
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_3,
		// Token: 0x04001033 RID: 4147
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_4,
		// Token: 0x04001034 RID: 4148
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_5,
		// Token: 0x04001035 RID: 4149
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_6,
		// Token: 0x04001036 RID: 4150
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_7,
		// Token: 0x04001037 RID: 4151
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_8,
		// Token: 0x04001038 RID: 4152
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_9,
		// Token: 0x04001039 RID: 4153
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_10,
		// Token: 0x0400103A RID: 4154
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_11,
		// Token: 0x0400103B RID: 4155
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_12,
		// Token: 0x0400103C RID: 4156
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_13,
		// Token: 0x0400103D RID: 4157
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_14,
		// Token: 0x0400103E RID: 4158
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_15,
		// Token: 0x0400103F RID: 4159
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_16,
		// Token: 0x04001040 RID: 4160
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_17,
		// Token: 0x04001041 RID: 4161
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_1,
		// Token: 0x04001042 RID: 4162
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_2,
		// Token: 0x04001043 RID: 4163
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_3,
		// Token: 0x04001044 RID: 4164
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_4,
		// Token: 0x04001045 RID: 4165
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_5,
		// Token: 0x04001046 RID: 4166
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_6,
		// Token: 0x04001047 RID: 4167
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_7,
		// Token: 0x04001048 RID: 4168
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_8,
		// Token: 0x04001049 RID: 4169
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_9,
		// Token: 0x0400104A RID: 4170
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_10,
		// Token: 0x0400104B RID: 4171
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_11,
		// Token: 0x0400104C RID: 4172
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_12,
		// Token: 0x0400104D RID: 4173
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_13,
		// Token: 0x0400104E RID: 4174
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_14,
		// Token: 0x0400104F RID: 4175
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_15,
		// Token: 0x04001050 RID: 4176
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_16,
		// Token: 0x04001051 RID: 4177
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_17,
		// Token: 0x04001052 RID: 4178
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_18,
		// Token: 0x04001053 RID: 4179
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_19,
		// Token: 0x04001054 RID: 4180
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_20,
		// Token: 0x04001055 RID: 4181
		Switches_SwitchConventionalSwitchesPosition1_A7734_1 = 115800101,
		// Token: 0x04001056 RID: 4182
		Switches_SwitchConventionalSwitchesPosition1_A7734_2,
		// Token: 0x04001057 RID: 4183
		Switches_SwitchConventionalSwitchesPosition1_A7734_3,
		// Token: 0x04001058 RID: 4184
		Switches_SwitchConventionalSwitchesPosition1_A7734_4,
		// Token: 0x04001059 RID: 4185
		Switches_SwitchConventionalSwitchesPosition1_A7734_5,
		// Token: 0x0400105A RID: 4186
		Switches_SwitchConventionalSwitchesPosition1_A7734_6,
		// Token: 0x0400105B RID: 4187
		Switches_SwitchConventionalSwitchesPosition1_A7734_7,
		// Token: 0x0400105C RID: 4188
		Switches_SwitchConventionalSwitchesPosition1_A7734_8,
		// Token: 0x0400105D RID: 4189
		Switches_SwitchConventionalSwitchesPosition1_A7734_9,
		// Token: 0x0400105E RID: 4190
		Switches_SwitchConventionalSwitchesPosition1_A7734_10,
		// Token: 0x0400105F RID: 4191
		Switches_SwitchConventionalSwitchesPosition1_A7734_11,
		// Token: 0x04001060 RID: 4192
		Switches_SwitchConventionalSwitchesPosition1_A7734_12,
		// Token: 0x04001061 RID: 4193
		Switches_SwitchConventionalSwitchesPosition1_A7734_13,
		// Token: 0x04001062 RID: 4194
		Switches_SwitchConventionalSwitchesPosition1_A7734_14,
		// Token: 0x04001063 RID: 4195
		Switches_SwitchConventionalSwitchesPosition1_A7734_15,
		// Token: 0x04001064 RID: 4196
		Switches_SwitchConventionalSwitchesPosition1_A7734_16,
		// Token: 0x04001065 RID: 4197
		Switches_SwitchConventionalSwitchesPosition1_A7734_17,
		// Token: 0x04001066 RID: 4198
		Switches_SwitchConventionalSwitchesPosition1_A7734_18,
		// Token: 0x04001067 RID: 4199
		Switches_SwitchConventionalSwitchesPosition2_A7735_1 = 115800201,
		// Token: 0x04001068 RID: 4200
		Switches_SwitchConventionalSwitchesPosition2_A7735_2,
		// Token: 0x04001069 RID: 4201
		Switches_SwitchConventionalSwitchesPosition2_A7735_3,
		// Token: 0x0400106A RID: 4202
		Switches_SwitchConventionalSwitchesPosition2_A7735_4,
		// Token: 0x0400106B RID: 4203
		Switches_SwitchConventionalSwitchesPosition2_A7735_5,
		// Token: 0x0400106C RID: 4204
		Switches_SwitchConventionalSwitchesPosition2_A7735_6,
		// Token: 0x0400106D RID: 4205
		Switches_SwitchConventionalSwitchesPosition2_A7735_7,
		// Token: 0x0400106E RID: 4206
		Switches_SwitchConventionalSwitchesPosition2_A7735_8,
		// Token: 0x0400106F RID: 4207
		Switches_SwitchConventionalSwitchesPosition2_A7735_9,
		// Token: 0x04001070 RID: 4208
		Switches_SwitchConventionalSwitchesPosition2_A7735_10,
		// Token: 0x04001071 RID: 4209
		Switches_SwitchConventionalSwitchesPosition2_A7735_11,
		// Token: 0x04001072 RID: 4210
		Switches_SwitchConventionalSwitchesPosition2_A7735_12,
		// Token: 0x04001073 RID: 4211
		Switches_SwitchConventionalSwitchesPosition2_A7735_13,
		// Token: 0x04001074 RID: 4212
		Switches_SwitchConventionalSwitchesPosition2_A7735_14,
		// Token: 0x04001075 RID: 4213
		Switches_SwitchConventionalSwitchesPosition2_A7735_15,
		// Token: 0x04001076 RID: 4214
		Switches_SwitchConventionalSwitchesPosition2_A7735_16,
		// Token: 0x04001077 RID: 4215
		Switches_SwitchConventionalSwitchesPosition2_A7735_17,
		// Token: 0x04001078 RID: 4216
		Switches_SwitchConventionalSwitchesPosition2_A7735_18,
		// Token: 0x04001079 RID: 4217
		Switches_SwitchConventionalSwitchesPosition2_A7735_19,
		// Token: 0x0400107A RID: 4218
		Switches_SwitchConventionalSwitchesPosition3_A7737_1 = 115800301,
		// Token: 0x0400107B RID: 4219
		Switches_SwitchConventionalSwitchesPosition3_A7737_2,
		// Token: 0x0400107C RID: 4220
		Switches_SwitchConventionalSwitchesPosition3_A7737_3,
		// Token: 0x0400107D RID: 4221
		Switches_SwitchConventionalSwitchesPosition3_A7737_4,
		// Token: 0x0400107E RID: 4222
		Switches_SwitchConventionalSwitchesPosition3_A7737_5,
		// Token: 0x0400107F RID: 4223
		Switches_SwitchConventionalSwitchesPosition3_A7737_6,
		// Token: 0x04001080 RID: 4224
		Switches_SwitchConventionalSwitchesPosition3_A7737_7,
		// Token: 0x04001081 RID: 4225
		Switches_SwitchConventionalSwitchesPosition3_A7737_8,
		// Token: 0x04001082 RID: 4226
		Switches_SwitchConventionalSwitchesPosition3_A7737_9,
		// Token: 0x04001083 RID: 4227
		Switches_SwitchConventionalSwitchesPosition3_A7737_10,
		// Token: 0x04001084 RID: 4228
		Switches_SwitchConventionalSwitchesPosition3_A7737_11,
		// Token: 0x04001085 RID: 4229
		Switches_SwitchConventionalSwitchesPosition3_A7737_12,
		// Token: 0x04001086 RID: 4230
		Switches_SwitchConventionalSwitchesPosition3_A7737_13,
		// Token: 0x04001087 RID: 4231
		Switches_SwitchConventionalSwitchesPosition3_A7737_14,
		// Token: 0x04001088 RID: 4232
		Switches_SwitchConventionalSwitchesPosition3_A7737_15,
		// Token: 0x04001089 RID: 4233
		Switches_SwitchConventionalSwitchesPosition3_A7737_16,
		// Token: 0x0400108A RID: 4234
		Switches_SwitchConventionalSwitchesPosition3_A7737_17,
		// Token: 0x0400108B RID: 4235
		Switches_SwitchConventionalSwitchesPosition3_A7737_18,
		// Token: 0x0400108C RID: 4236
		Switches_SwitchConventionalSwitchesPosition3_A7737_19,
		// Token: 0x0400108D RID: 4237
		Switches_SwitchConventionalSwitchesPosition4_A21530_1 = 115800401,
		// Token: 0x0400108E RID: 4238
		Switches_SwitchConventionalSwitchesPosition4_A21530_2,
		// Token: 0x0400108F RID: 4239
		Switches_SwitchConventionalSwitchesPosition4_A21530_3,
		// Token: 0x04001090 RID: 4240
		Switches_SwitchConventionalSwitchesPosition4_A21530_4,
		// Token: 0x04001091 RID: 4241
		Switches_SwitchConventionalSwitchesPosition4_A21530_5,
		// Token: 0x04001092 RID: 4242
		Switches_SwitchConventionalSwitchesPosition4_A21530_6,
		// Token: 0x04001093 RID: 4243
		Switches_SwitchConventionalSwitchesPosition4_A21530_7,
		// Token: 0x04001094 RID: 4244
		Switches_SwitchConventionalSwitchesPosition4_A21530_8,
		// Token: 0x04001095 RID: 4245
		Switches_SwitchConventionalSwitchesPosition4_A21530_9,
		// Token: 0x04001096 RID: 4246
		Switches_SwitchConventionalSwitchesPosition4_A21530_10,
		// Token: 0x04001097 RID: 4247
		Switches_SwitchConventionalSwitchesPosition4_A21530_11,
		// Token: 0x04001098 RID: 4248
		Switches_SwitchConventionalSwitchesPosition4_A21530_12,
		// Token: 0x04001099 RID: 4249
		Switches_SwitchConventionalSwitchesPosition4_A21530_13,
		// Token: 0x0400109A RID: 4250
		Switches_SwitchConventionalSwitchesPosition4_A21530_14,
		// Token: 0x0400109B RID: 4251
		Switches_SwitchConventionalSwitchesPosition4_A21530_15,
		// Token: 0x0400109C RID: 4252
		Switches_SwitchConventionalSwitchesPosition4_A21530_16,
		// Token: 0x0400109D RID: 4253
		Switches_SwitchConventionalSwitchesPosition4_A21530_17,
		// Token: 0x0400109E RID: 4254
		Switches_SwitchConventionalSwitchesPosition4_A21530_18,
		// Token: 0x0400109F RID: 4255
		Switches_SwitchConventionalSwitchesPosition4_A21530_19,
		// Token: 0x040010A0 RID: 4256
		Switches_SwitchConventionalSwitchesPosition5_A21531_1 = 115800501,
		// Token: 0x040010A1 RID: 4257
		Switches_SwitchConventionalSwitchesPosition5_A21531_2,
		// Token: 0x040010A2 RID: 4258
		Switches_SwitchConventionalSwitchesPosition5_A21531_3,
		// Token: 0x040010A3 RID: 4259
		Switches_SwitchConventionalSwitchesPosition5_A21531_4,
		// Token: 0x040010A4 RID: 4260
		Switches_SwitchConventionalSwitchesPosition5_A21531_5,
		// Token: 0x040010A5 RID: 4261
		Switches_SwitchConventionalSwitchesPosition5_A21531_6,
		// Token: 0x040010A6 RID: 4262
		Switches_SwitchConventionalSwitchesPosition5_A21531_7,
		// Token: 0x040010A7 RID: 4263
		Switches_SwitchConventionalSwitchesPosition5_A21531_8,
		// Token: 0x040010A8 RID: 4264
		Switches_SwitchConventionalSwitchesPosition5_A21531_9,
		// Token: 0x040010A9 RID: 4265
		Switches_SwitchConventionalSwitchesPosition5_A21531_10,
		// Token: 0x040010AA RID: 4266
		Switches_SwitchConventionalSwitchesPosition5_A21531_11,
		// Token: 0x040010AB RID: 4267
		Switches_SwitchConventionalSwitchesPosition5_A21531_12,
		// Token: 0x040010AC RID: 4268
		Switches_SwitchConventionalSwitchesPosition5_A21531_13,
		// Token: 0x040010AD RID: 4269
		Switches_SwitchConventionalSwitchesPosition5_A21531_14,
		// Token: 0x040010AE RID: 4270
		Switches_SwitchConventionalSwitchesPosition5_A21531_15,
		// Token: 0x040010AF RID: 4271
		Switches_SwitchConventionalSwitchesPosition5_A21531_16,
		// Token: 0x040010B0 RID: 4272
		Switches_SwitchConventionalSwitchesPosition5_A21531_17,
		// Token: 0x040010B1 RID: 4273
		Switches_SwitchConventionalSwitchesPosition5_A21531_18,
		// Token: 0x040010B2 RID: 4274
		Switches_SwitchConventionalSwitchesPosition5_A21531_19,
		// Token: 0x040010B3 RID: 4275
		Switches_SwitchGeneralRotaryControl_A8984_1 = 115800601,
		// Token: 0x040010B4 RID: 4276
		Switches_SwitchGeneralRotaryControl_A8984_2,
		// Token: 0x040010B5 RID: 4277
		Switches_TrunkingSwitchesPosition1_A9466_1 = 115800701,
		// Token: 0x040010B6 RID: 4278
		Switches_TrunkingSwitchesPosition1_A9466_2,
		// Token: 0x040010B7 RID: 4279
		Switches_TrunkingSwitchesPosition1_A9466_3,
		// Token: 0x040010B8 RID: 4280
		Switches_TrunkingSwitchesPosition1_A9466_4,
		// Token: 0x040010B9 RID: 4281
		Switches_TrunkingSwitchesPosition1_A9466_5,
		// Token: 0x040010BA RID: 4282
		Switches_TrunkingSwitchesPosition1_A9466_6,
		// Token: 0x040010BB RID: 4283
		Switches_TrunkingSwitchesPosition1_A9466_7,
		// Token: 0x040010BC RID: 4284
		Switches_TrunkingSwitchesPosition1_A9466_8,
		// Token: 0x040010BD RID: 4285
		Switches_TrunkingSwitchesPosition1_A9466_9,
		// Token: 0x040010BE RID: 4286
		Switches_TrunkingSwitchesPosition1_A9466_10,
		// Token: 0x040010BF RID: 4287
		Switches_TrunkingSwitchesPosition1_A9466_11,
		// Token: 0x040010C0 RID: 4288
		Switches_TrunkingSwitchesPosition1_A9466_12,
		// Token: 0x040010C1 RID: 4289
		Switches_TrunkingSwitchesPosition1_A9466_13,
		// Token: 0x040010C2 RID: 4290
		Switches_TrunkingSwitchesPosition1_A9466_14,
		// Token: 0x040010C3 RID: 4291
		Switches_TrunkingSwitchesPosition1_A9466_15,
		// Token: 0x040010C4 RID: 4292
		Switches_TrunkingSwitchesPosition1_A9466_16,
		// Token: 0x040010C5 RID: 4293
		Switches_TrunkingSwitchesPosition1_A9466_17,
		// Token: 0x040010C6 RID: 4294
		Switches_TrunkingSwitchesPosition1_A9466_18,
		// Token: 0x040010C7 RID: 4295
		Switches_TrunkingSwitchesPosition1_A9466_19,
		// Token: 0x040010C8 RID: 4296
		Switches_TrunkingSwitchesPosition1_A9466_20,
		// Token: 0x040010C9 RID: 4297
		Switches_TrunkingSwitchesPosition1_A9466_21,
		// Token: 0x040010CA RID: 4298
		Switches_TrunkingSwitchesPosition1_A9466_22,
		// Token: 0x040010CB RID: 4299
		Switches_TrunkingSwitchesPosition1_A9466_23,
		// Token: 0x040010CC RID: 4300
		Switches_TrunkingSwitchesPosition2_A9467_1 = 115800801,
		// Token: 0x040010CD RID: 4301
		Switches_TrunkingSwitchesPosition2_A9467_2,
		// Token: 0x040010CE RID: 4302
		Switches_TrunkingSwitchesPosition2_A9467_3,
		// Token: 0x040010CF RID: 4303
		Switches_TrunkingSwitchesPosition2_A9467_4,
		// Token: 0x040010D0 RID: 4304
		Switches_TrunkingSwitchesPosition2_A9467_5,
		// Token: 0x040010D1 RID: 4305
		Switches_TrunkingSwitchesPosition2_A9467_6,
		// Token: 0x040010D2 RID: 4306
		Switches_TrunkingSwitchesPosition2_A9467_7,
		// Token: 0x040010D3 RID: 4307
		Switches_TrunkingSwitchesPosition2_A9467_8,
		// Token: 0x040010D4 RID: 4308
		Switches_TrunkingSwitchesPosition2_A9467_9,
		// Token: 0x040010D5 RID: 4309
		Switches_TrunkingSwitchesPosition2_A9467_10,
		// Token: 0x040010D6 RID: 4310
		Switches_TrunkingSwitchesPosition2_A9467_11,
		// Token: 0x040010D7 RID: 4311
		Switches_TrunkingSwitchesPosition2_A9467_12,
		// Token: 0x040010D8 RID: 4312
		Switches_TrunkingSwitchesPosition2_A9467_13,
		// Token: 0x040010D9 RID: 4313
		Switches_TrunkingSwitchesPosition2_A9467_14,
		// Token: 0x040010DA RID: 4314
		Switches_TrunkingSwitchesPosition2_A9467_15,
		// Token: 0x040010DB RID: 4315
		Switches_TrunkingSwitchesPosition2_A9467_16,
		// Token: 0x040010DC RID: 4316
		Switches_TrunkingSwitchesPosition2_A9467_17,
		// Token: 0x040010DD RID: 4317
		Switches_TrunkingSwitchesPosition2_A9467_18,
		// Token: 0x040010DE RID: 4318
		Switches_TrunkingSwitchesPosition2_A9467_19,
		// Token: 0x040010DF RID: 4319
		Switches_TrunkingSwitchesPosition2_A9467_20,
		// Token: 0x040010E0 RID: 4320
		Switches_TrunkingSwitchesPosition2_A9467_21,
		// Token: 0x040010E1 RID: 4321
		Switches_TrunkingSwitchesPosition3_A9468_1 = 115800901,
		// Token: 0x040010E2 RID: 4322
		Switches_TrunkingSwitchesPosition3_A9468_2,
		// Token: 0x040010E3 RID: 4323
		Switches_TrunkingSwitchesPosition3_A9468_3,
		// Token: 0x040010E4 RID: 4324
		Switches_TrunkingSwitchesPosition3_A9468_4,
		// Token: 0x040010E5 RID: 4325
		Switches_TrunkingSwitchesPosition3_A9468_5,
		// Token: 0x040010E6 RID: 4326
		Switches_TrunkingSwitchesPosition3_A9468_6,
		// Token: 0x040010E7 RID: 4327
		Switches_TrunkingSwitchesPosition3_A9468_7,
		// Token: 0x040010E8 RID: 4328
		Switches_TrunkingSwitchesPosition3_A9468_8,
		// Token: 0x040010E9 RID: 4329
		Switches_TrunkingSwitchesPosition3_A9468_9,
		// Token: 0x040010EA RID: 4330
		Switches_TrunkingSwitchesPosition3_A9468_10,
		// Token: 0x040010EB RID: 4331
		Switches_TrunkingSwitchesPosition3_A9468_11,
		// Token: 0x040010EC RID: 4332
		Switches_TrunkingSwitchesPosition3_A9468_12,
		// Token: 0x040010ED RID: 4333
		Switches_TrunkingSwitchesPosition3_A9468_13,
		// Token: 0x040010EE RID: 4334
		Switches_TrunkingSwitchesPosition3_A9468_14,
		// Token: 0x040010EF RID: 4335
		Switches_TrunkingSwitchesPosition3_A9468_15,
		// Token: 0x040010F0 RID: 4336
		Switches_TrunkingSwitchesPosition3_A9468_16,
		// Token: 0x040010F1 RID: 4337
		Switches_TrunkingSwitchesPosition3_A9468_17,
		// Token: 0x040010F2 RID: 4338
		Switches_TrunkingSwitchesPosition3_A9468_18,
		// Token: 0x040010F3 RID: 4339
		Switches_TrunkingSwitchesPosition3_A9468_19,
		// Token: 0x040010F4 RID: 4340
		Switches_TrunkingSwitchesPosition3_A9468_20,
		// Token: 0x040010F5 RID: 4341
		Switches_TrunkingSwitchesPosition3_A9468_21,
		// Token: 0x040010F6 RID: 4342
		Switches_TrunkingSwitchesPosition4_A21534_1 = 115801001,
		// Token: 0x040010F7 RID: 4343
		Switches_TrunkingSwitchesPosition4_A21534_2,
		// Token: 0x040010F8 RID: 4344
		Switches_TrunkingSwitchesPosition4_A21534_3,
		// Token: 0x040010F9 RID: 4345
		Switches_TrunkingSwitchesPosition4_A21534_4,
		// Token: 0x040010FA RID: 4346
		Switches_TrunkingSwitchesPosition4_A21534_5,
		// Token: 0x040010FB RID: 4347
		Switches_TrunkingSwitchesPosition4_A21534_6,
		// Token: 0x040010FC RID: 4348
		Switches_TrunkingSwitchesPosition4_A21534_7,
		// Token: 0x040010FD RID: 4349
		Switches_TrunkingSwitchesPosition4_A21534_8,
		// Token: 0x040010FE RID: 4350
		Switches_TrunkingSwitchesPosition4_A21534_9,
		// Token: 0x040010FF RID: 4351
		Switches_TrunkingSwitchesPosition4_A21534_10,
		// Token: 0x04001100 RID: 4352
		Switches_TrunkingSwitchesPosition4_A21534_11,
		// Token: 0x04001101 RID: 4353
		Switches_TrunkingSwitchesPosition4_A21534_12,
		// Token: 0x04001102 RID: 4354
		Switches_TrunkingSwitchesPosition4_A21534_13,
		// Token: 0x04001103 RID: 4355
		Switches_TrunkingSwitchesPosition4_A21534_14,
		// Token: 0x04001104 RID: 4356
		Switches_TrunkingSwitchesPosition4_A21534_15,
		// Token: 0x04001105 RID: 4357
		Switches_TrunkingSwitchesPosition4_A21534_16,
		// Token: 0x04001106 RID: 4358
		Switches_TrunkingSwitchesPosition4_A21534_17,
		// Token: 0x04001107 RID: 4359
		Switches_TrunkingSwitchesPosition4_A21534_18,
		// Token: 0x04001108 RID: 4360
		Switches_TrunkingSwitchesPosition4_A21534_19,
		// Token: 0x04001109 RID: 4361
		Switches_TrunkingSwitchesPosition4_A21534_20,
		// Token: 0x0400110A RID: 4362
		Switches_TrunkingSwitchesPosition4_A21534_21,
		// Token: 0x0400110B RID: 4363
		Switches_TrunkingSwitchesPosition5_A21535_1 = 115801101,
		// Token: 0x0400110C RID: 4364
		Switches_TrunkingSwitchesPosition5_A21535_2,
		// Token: 0x0400110D RID: 4365
		Switches_TrunkingSwitchesPosition5_A21535_3,
		// Token: 0x0400110E RID: 4366
		Switches_TrunkingSwitchesPosition5_A21535_4,
		// Token: 0x0400110F RID: 4367
		Switches_TrunkingSwitchesPosition5_A21535_5,
		// Token: 0x04001110 RID: 4368
		Switches_TrunkingSwitchesPosition5_A21535_6,
		// Token: 0x04001111 RID: 4369
		Switches_TrunkingSwitchesPosition5_A21535_7,
		// Token: 0x04001112 RID: 4370
		Switches_TrunkingSwitchesPosition5_A21535_8,
		// Token: 0x04001113 RID: 4371
		Switches_TrunkingSwitchesPosition5_A21535_9,
		// Token: 0x04001114 RID: 4372
		Switches_TrunkingSwitchesPosition5_A21535_10,
		// Token: 0x04001115 RID: 4373
		Switches_TrunkingSwitchesPosition5_A21535_11,
		// Token: 0x04001116 RID: 4374
		Switches_TrunkingSwitchesPosition5_A21535_12,
		// Token: 0x04001117 RID: 4375
		Switches_TrunkingSwitchesPosition5_A21535_13,
		// Token: 0x04001118 RID: 4376
		Switches_TrunkingSwitchesPosition5_A21535_14,
		// Token: 0x04001119 RID: 4377
		Switches_TrunkingSwitchesPosition5_A21535_15,
		// Token: 0x0400111A RID: 4378
		Switches_TrunkingSwitchesPosition5_A21535_16,
		// Token: 0x0400111B RID: 4379
		Switches_TrunkingSwitchesPosition5_A21535_17,
		// Token: 0x0400111C RID: 4380
		Switches_TrunkingSwitchesPosition5_A21535_18,
		// Token: 0x0400111D RID: 4381
		Switches_TrunkingSwitchesPosition5_A21535_19,
		// Token: 0x0400111E RID: 4382
		Switches_TrunkingSwitchesPosition5_A21535_20,
		// Token: 0x0400111F RID: 4383
		Switches_TrunkingSwitchesPosition5_A21535_21,
		// Token: 0x04001120 RID: 4384
		SwitchesMFKAssignmentCntrl_Feature_1 = 115900101,
		// Token: 0x04001121 RID: 4385
		SwitchesMFKAssignmentCntrl_Feature_2,
		// Token: 0x04001122 RID: 4386
		SwitchesMFKAssignmentCntrl_Feature_3,
		// Token: 0x04001123 RID: 4387
		SwitchesMFKAssignmentCntrl_Feature_4,
		// Token: 0x04001124 RID: 4388
		SwitchesMFKAssignmentCntrl_Feature_5,
		// Token: 0x04001125 RID: 4389
		TalkgroupTable_AstTlkgrpLstTalkgroupListKeySelectReference_A8366_1 = 116000101,
		// Token: 0x04001126 RID: 4390
		O9TopFuncPgmBtn_Index_1 = 116100101,
		// Token: 0x04001127 RID: 4391
		O9TopFuncPgmBtn_Index_2,
		// Token: 0x04001128 RID: 4392
		O9TopFunctionProgrammableButton_O9CHCnvTopFunctionButtonIndex_A36634_1,
		// Token: 0x04001129 RID: 4393
		O9TopFunctionProgrammableButton_O9CHCnvTopFunctionButtonIndex_A36634_2,
		// Token: 0x0400112A RID: 4394
		O9TopFunctionProgrammableButton_O9CHCnvTopFunctionButtonIndex_A36634_3,
		// Token: 0x0400112B RID: 4395
		O9TopFunctionProgrammableButton_O9CHCnvTopFunctionButtonIndex_A36634_4,
		// Token: 0x0400112C RID: 4396
		O9TopFunctionProgrammableButton_O9CHCnvTopFunctionButtonIndex_A36634_5,
		// Token: 0x0400112D RID: 4397
		O9TopFunctionProgrammableButton_O9CHCnvTopFunctionButtonIndex_A36634_6,
		// Token: 0x0400112E RID: 4398
		O9TopFuncPgmBtn_Prepend_Index_1 = 116100201,
		// Token: 0x0400112F RID: 4399
		O9TopFunctionProgrammableButton_CHO9CnvTopFunctionButtonLabelLine1_A36626_1 = 116100301,
		// Token: 0x04001130 RID: 4400
		O9TopFunctionProgrammableButton_CHO9CnvTopFunctionButtonLabelLine2_A36627_1 = 116100401,
		// Token: 0x04001131 RID: 4401
		O9TopFunctionPgmmbleBtn_Feature_1 = 116100501,
		// Token: 0x04001132 RID: 4402
		O9TopFunctionPgmmbleBtn_Feature_2,
		// Token: 0x04001133 RID: 4403
		O9TopFunctionPgmmbleBtn_Feature_3,
		// Token: 0x04001134 RID: 4404
		O9TopFunctionPgmmbleBtn_Feature_4,
		// Token: 0x04001135 RID: 4405
		O9TopFunctionPgmmbleBtn_Feature_5,
		// Token: 0x04001136 RID: 4406
		O9TopFunctionPgmmbleBtn_Feature_6,
		// Token: 0x04001137 RID: 4407
		O9TopFunctionPgmmbleBtn_Feature_7,
		// Token: 0x04001138 RID: 4408
		O9TopFunctionPgmmbleBtn_Feature_8,
		// Token: 0x04001139 RID: 4409
		O9TopFunctionPgmmbleBtn_StsMsgIndex_1 = 116100601,
		// Token: 0x0400113A RID: 4410
		O9TopFunctionPgmmbleBtn_StsMsgIndex_2,
		// Token: 0x0400113B RID: 4411
		O9TopFunctionPgmmbleBtn_StsMsgIndex_3,
		// Token: 0x0400113C RID: 4412
		O9TopFunctionPgmmbleBtn_StsMsgIndex_4,
		// Token: 0x0400113D RID: 4413
		O9TopFunctionPgmmbleBtn_TrunkingZone_1 = 116100701,
		// Token: 0x0400113E RID: 4414
		O9TopFunctionProgrammableButton_TopFunctionBtnCnvZone_A36942_1 = 116100801,
		// Token: 0x0400113F RID: 4415
		TrunkingEmergencyProfiles_TrkEmerProfGeneralEmergencyOperation_A7926_1 = 116200101,
		// Token: 0x04001140 RID: 4416
		TrunkingEmergencyProfiles_TrkEmerProEmergencyAutoTransmitMode_A22567_1 = 116200201,
		// Token: 0x04001141 RID: 4417
		TrunkingEmergencyProfiles_TrkEmerProfGeneralVoiceSignalType_A7500_1 = 116200301,
		// Token: 0x04001142 RID: 4418
		TrunkingEmergencyToneList_TrkEmerTonePeriodSec_42110_1 = 116300101,
		// Token: 0x04001143 RID: 4419
		TrunkingEmergencyToneList_RadErgoAstroAlertingToneTableTone2Freq,
		// Token: 0x04001144 RID: 4420
		TrunkingGroupIDList_DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204_1 = 116400001,
		// Token: 0x04001145 RID: 4421
		MobileTrunkingMenuItems_ConventionalSelectedMenuItem_1 = 1166600101,
		// Token: 0x04001146 RID: 4422
		PortTrunkingMenuItems_ConventionalSelectedMenuItem_1 = 116700101,
		// Token: 0x04001147 RID: 4423
		RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854_1 = 117200101,
		// Token: 0x04001148 RID: 4424
		RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854_2,
		// Token: 0x04001149 RID: 4425
		RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854_3,
		// Token: 0x0400114A RID: 4426
		RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855_1 = 117200201,
		// Token: 0x0400114B RID: 4427
		RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152_1 = 117300101,
		// Token: 0x0400114C RID: 4428
		RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152_2,
		// Token: 0x0400114D RID: 4429
		RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152_3,
		// Token: 0x0400114E RID: 4430
		RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175_1 = 117300201,
		// Token: 0x0400114F RID: 4431
		RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176_1 = 117300301,
		// Token: 0x04001150 RID: 4432
		RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153_1 = 117300401,
		// Token: 0x04001151 RID: 4433
		TxPowerLevelsFieldDefaultValueMismatchOption = 117300501,
		// Token: 0x04001152 RID: 4434
		FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577_1 = 117400101,
		// Token: 0x04001153 RID: 4435
		FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577_2,
		// Token: 0x04001154 RID: 4436
		FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468_1,
		// Token: 0x04001155 RID: 4437
		FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468_2,
		// Token: 0x04001156 RID: 4438
		FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777_1,
		// Token: 0x04001157 RID: 4439
		FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777_2,
		// Token: 0x04001158 RID: 4440
		FORxFrequencyList_FctOrdsRxFrequencyMHz_IsValid_1,
		// Token: 0x04001159 RID: 4441
		FORxFrequencyList_FctOrdsRxFrequencyMHz_IsValid_2,
		// Token: 0x0400115A RID: 4442
		FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534_1 = 117500101,
		// Token: 0x0400115B RID: 4443
		FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534_2,
		// Token: 0x0400115C RID: 4444
		UclT2TrkHotList_CallID_A00041_1 = 117700101,
		// Token: 0x0400115D RID: 4445
		UclT2Trk_IndividualID_A00019_1 = 117900101,
		// Token: 0x0400115E RID: 4446
		UclT2Trk_IndividualID_A00019_2,
		// Token: 0x0400115F RID: 4447
		UclT2Trk_IndividualID_A00019_3,
		// Token: 0x04001160 RID: 4448
		UclT2Trk_IndividualID_A00019_4,
		// Token: 0x04001161 RID: 4449
		UclT2Trk_IndividualID_A00019_5,
		// Token: 0x04001162 RID: 4450
		VirtualPartnerAlertAction_Invalid = 118150001,
		// Token: 0x04001163 RID: 4451
		VoiceAnnouncementList_Record_Invalid = 118200101,
		// Token: 0x04001164 RID: 4452
		VoiceAnnouncementList_VoiceFileName_A21220_Invalid = 118200200,
		// Token: 0x04001165 RID: 4453
		Zones_ZnChanCfgFPPProtectionFPPEnable_A19562_1 = 118400101,
		// Token: 0x04001166 RID: 4454
		Zones_ZnChanCfgZoneDynamicZoneEnable_A41257_1 = 118400201,
		// Token: 0x04001167 RID: 4455
		Zones_ZnChanCfgZoneDynamicZoneEnable_A41257_2,
		// Token: 0x04001168 RID: 4456
		Zones_ZnChanCfgZoneDynamicZoneEnable_A41257_3,
		// Token: 0x04001169 RID: 4457
		Zones_ZnChanCfgZoneDynamicZoneEnable_A41257_4,
		// Token: 0x0400116A RID: 4458
		Zones_ZnChanCfgZoneDynamicZoneEnable_A41257_5,
		// Token: 0x0400116B RID: 4459
		Zones_ZnChanCfgZoneDynamicZoneEnable_A41257_6,
		// Token: 0x0400116C RID: 4460
		Zones_ZoneChannelAssignmentRSIMode_A41831_1 = 118400301,
		// Token: 0x0400116D RID: 4461
		Zones_ZnChanCfgFPPProtectionProtectedZone_A8765_1 = 118400401,
		// Token: 0x0400116E RID: 4462
		Zones_ZnChanCfgZoneZoneCloningEnable_43119_1 = 118400501,
		// Token: 0x0400116F RID: 4463
		Zones_ZoneAnnouncementVoiceCommand,
		// Token: 0x04001170 RID: 4464
		Zones_ZoneAnnouncementVoiceCommandHome,
		// Token: 0x04001171 RID: 4465
		Zones_ZoneAnnouncementVoiceCommandConfusability,
		// Token: 0x04001172 RID: 4466
		ASTRO__Warning_No_Reference_From_ZoneChannel = 118500000,
		// Token: 0x04001173 RID: 4467
		Feature_NotPurchased_Enabled,
		// Token: 0x04001174 RID: 4468
		Unable_to_Apply_36009600trunking_to_target_singletrunking,
		// Token: 0x04001175 RID: 4469
		Radio_Configuration_ASKRule_Mismatch,
		// Token: 0x04001176 RID: 4470
		ASTRO_TypeIINotAllowed,
		// Token: 0x04001177 RID: 4471
		Feature_NotEnabled_ButPurchased,
		// Token: 0x04001178 RID: 4472
		ASTRO_Warning_No_Reference_From_TrkPer,
		// Token: 0x04001179 RID: 4473
		ASTRO_ForceLoadSetHasMoreThanOneReference_ASTROFNE,
		// Token: 0x0400117A RID: 4474
		ASTRO_ForceLoadSetHasMoreThanOneReference_Channel,
		// Token: 0x0400117B RID: 4475
		ASTRO_ForceLoadSetHasMoreThanOneReference_Contact,
		// Token: 0x0400117C RID: 4476
		ASTRO_ForceLoadSetHasMoreThanOneReference_GlobalFreqOptions,
		// Token: 0x0400117D RID: 4477
		ASTRO_ForceLoadSetHasMoreThanOneReference_TypeIIFNE,
		// Token: 0x0400117E RID: 4478
		Zones_NoChannelPool = 118530000,
		// Token: 0x0400117F RID: 4479
		Zones_NoCBZone,
		// Token: 0x04001180 RID: 4480
		Zones_NoNormalZone,
		// Token: 0x04001181 RID: 4481
		VoiceAnnouncement_Exceed_Max_Duration,
		// Token: 0x04001182 RID: 4482
		VoiceAnnouncement_Exceed_SingleFile_Duration,
		// Token: 0x04001183 RID: 4483
		EnhancedPrivacyKeys_Invalid,
		// Token: 0x04001184 RID: 4484
		AESKeys_Invalid,
		// Token: 0x04001185 RID: 4485
		OTAPAuthenticationKey_Invalid,
		// Token: 0x04001186 RID: 4486
		RASKeys_Invalid,
		// Token: 0x04001187 RID: 4487
		ConventionalPersonality_ChannelTypeUnsupported,
		// Token: 0x04001188 RID: 4488
		TTSRuleSetData_TooLarge = 118530011,
		// Token: 0x04001189 RID: 4489
		DMR3SelectSitesShouldHaveSameChannelPlan,
		// Token: 0x0400118A RID: 4490
		IPSettings_SameSubnet_1,
		// Token: 0x0400118B RID: 4491
		IPSettings_SameSubnet_2,
		// Token: 0x0400118C RID: 4492
		IPSettings_SameSubnet_3,
		// Token: 0x0400118D RID: 4493
		IPSettings_IPDifferent_1,
		// Token: 0x0400118E RID: 4494
		IPSettings_IPDifferent_2,
		// Token: 0x0400118F RID: 4495
		IPSettings_IPDifferent_3,
		// Token: 0x04001190 RID: 4496
		IPSettings_UdpPortDifferent_1,
		// Token: 0x04001191 RID: 4497
		IPSettings_MaskIpAddressOutOfRange_1,
		// Token: 0x04001192 RID: 4498
		ConventionalPersonality_FirmwareShouldUpgrade,
		// Token: 0x04001193 RID: 4499
		DMR3SiteSelection_ShouldHaveRecords,
		// Token: 0x04001194 RID: 4500
		MNIS_Record_Invalid,
		// Token: 0x04001195 RID: 4501
		DMR3SiteSelectionItem_Count_Invalid,
		// Token: 0x04001196 RID: 4502
		DMR3SiteSelectionItem_Count_Warning,
		// Token: 0x04001197 RID: 4503
		DMR3SiteSelectionSites_Count_Invalid,
		// Token: 0x04001198 RID: 4504
		DMR3SiteSelectionSites_Count_Warning,
		// Token: 0x04001199 RID: 4505
		DMR3SiteSelectionSites_RecordPar_Valid,
		// Token: 0x0400119A RID: 4506
		DMR3SiteSelectionSites_Count0,
		// Token: 0x0400119B RID: 4507
		DMR3FlexibleChannelPlanList_Count_Warning,
		// Token: 0x0400119C RID: 4508
		DMR3FlexibleChannelPlanList_Record_Paradise,
		// Token: 0x0400119D RID: 4509
		DMR3FlexibleChannelPlanList_Record_MNIS,
		// Token: 0x0400119E RID: 4510
		DMR3SiteSelectionItem_PAR_ItemValid,
		// Token: 0x0400119F RID: 4511
		Zones_NoOneChannelInNormalZone,
		// Token: 0x040011A0 RID: 4512
		DMR3SiteSelectionItem_SU1005_ItemValid,
		// Token: 0x040011A1 RID: 4513
		Radios_DataWideGeneralPeerIPAddress1_A8524_1 = 118900101,
		// Token: 0x040011A2 RID: 4514
		Radios_DataWideGeneralPeerIPAddress1_A8524_2,
		// Token: 0x040011A3 RID: 4515
		Radios_DataWideGeneralPeerIPAddress1_A8524_3,
		// Token: 0x040011A4 RID: 4516
		Radios_RadWideUserInformationandPasswordsSoftIDUsername_A9169_1 = 118900201,
		// Token: 0x040011A5 RID: 4517
		Radios_DataWideGeneralBTDUNPeerIPAddress_A41123_1 = 118900301,
		// Token: 0x040011A6 RID: 4518
		Radios_DataWideGeneralBTDUNPeerIPAddress_A41123_2,
		// Token: 0x040011A7 RID: 4519
		Radios_DataWideGeneralBTDUNPeerIPAddress_A41123_3,
		// Token: 0x040011A8 RID: 4520
		Radios_RadWideUserInformationandPINPassword_41303_1 = 118900401,
		// Token: 0x040011A9 RID: 4521
		Radios_RadWideUserInformationandPINPassword_41303_2,
		// Token: 0x040011AA RID: 4522
		Radios_RadWideUserInformationandUserLoginUnitID_41306_1 = 118900501,
		// Token: 0x040011AB RID: 4523
		Radios_RadWideUserInformationandUserLoginUnitID_41306_2,
		// Token: 0x040011AC RID: 4524
		Radios_DataWideGeneralSubscriberIPAddress1_A9222_1 = 118900601,
		// Token: 0x040011AD RID: 4525
		Radios_DataWideGeneralSubscriberIPAddress1_A9222_2,
		// Token: 0x040011AE RID: 4526
		Radios_RadInfoGeneralSerialNumber_A9122_1 = 118900701,
		// Token: 0x040011AF RID: 4527
		Radios_DataWideWiFiNetworkSSID_42519_1 = 118900801,
		// Token: 0x040011B0 RID: 4528
		Radios_DataWideWiFiNetworkSSID_42519_2,
		// Token: 0x040011B1 RID: 4529
		Radios_DataWideWiFiNetworkSSID_42519_3,
		// Token: 0x040011B2 RID: 4530
		Radios_DataWideWiFiNetworkEncryptedNetworkPassword_42517_1 = 118900901,
		// Token: 0x040011B3 RID: 4531
		Radios_DataWideWiFiNetworkEncryptedNetworkPassword_42517_2,
		// Token: 0x040011B4 RID: 4532
		Zone_Clone_Enable_Con_Sys_Full = 119200000,
		// Token: 0x040011B5 RID: 4533
		Zone_Clone_Enable_Astro_Talk_Group,
		// Token: 0x040011B6 RID: 4534
		Zone_Clone_Enable_Con_Per_Full,
		// Token: 0x040011B7 RID: 4535
		Zone_Clone_Enable_Channel_Full,
		// Token: 0x040011B8 RID: 4536
		Zone_Clone_Enable_NotContinuous,
		// Token: 0x040011B9 RID: 4537
		Zone_Clone_IPConflict,
		// Token: 0x040011BA RID: 4538
		Tonga_Alias_Restricted_Characters = 200000000,
		// Token: 0x040011BB RID: 4539
		Accessories_ACCY_DATARVTCHNL_1 = 200100101,
		// Token: 0x040011BC RID: 4540
		Accessories_ACCY_DATARVTCHNL_2,
		// Token: 0x040011BD RID: 4541
		Accessories_ACCY_DATARVTCHNL_3,
		// Token: 0x040011BE RID: 4542
		Accessories_MBPTTCHANSELECTION_ITEM_1 = 200100201,
		// Token: 0x040011BF RID: 4543
		Accessories_RC_EXTDIGFX_1 = 200100301,
		// Token: 0x040011C0 RID: 4544
		Accessories_RC_EXTANLGFX_1 = 200100401,
		// Token: 0x040011C1 RID: 4545
		Accessories_BR_ACCAUDIOEMPS_1 = 200100501,
		// Token: 0x040011C2 RID: 4546
		Accessories_BR_ACCAUDIOEMPS_2,
		// Token: 0x040011C3 RID: 4547
		Accessories_ACCY_RevertChannel_1 = 200100601,
		// Token: 0x040011C4 RID: 4548
		Accessories_ACCY_RevertChannel_2,
		// Token: 0x040011C5 RID: 4549
		Accessories_ACCY_RevertChannel_3,
		// Token: 0x040011C6 RID: 4550
		Accessories_ACCY_RevertChannel_4,
		// Token: 0x040011C7 RID: 4551
		ActionListItems_ALSF_CPV_1 = 200200101,
		// Token: 0x040011C8 RID: 4552
		ActionListItems_ALSF_CPV_2,
		// Token: 0x040011C9 RID: 4553
		AESKeys_KeyValueInvalid = 200300001,
		// Token: 0x040011CA RID: 4554
		AESKeys_KeyAliasInvalid,
		// Token: 0x040011CB RID: 4555
		AESKeys_KeyIDInvalid,
		// Token: 0x040011CC RID: 4556
		AutoAcknowledges_S5AUTOACK_RVTCHNLITEM_1 = 200500101,
		// Token: 0x040011CD RID: 4557
		AutoAcknowledges_S5AUTOACK_RVTCHNLITEM_2,
		// Token: 0x040011CE RID: 4558
		CallList_DigitalCalls_1 = 200600101,
		// Token: 0x040011CF RID: 4559
		CallList_DigitalCalls_SITECALL_1 = 200600103,
		// Token: 0x040011D0 RID: 4560
		CallList_DigitalCalls_MULTISITECALL_1,
		// Token: 0x040011D1 RID: 4561
		CallList_DigitalCalls_ROUTETYPE,
		// Token: 0x040011D2 RID: 4562
		CallList_DigitalCalls_UNADRESSEDCALL_1,
		// Token: 0x040011D3 RID: 4563
		CallList_MdcCalls_1 = 200600201,
		// Token: 0x040011D4 RID: 4564
		CallList_CapplusCalls_1 = 200600301,
		// Token: 0x040011D5 RID: 4565
		CallList_DigitalCalls_2 = 200600102,
		// Token: 0x040011D6 RID: 4566
		CallList_MdcCalls_2 = 200600202,
		// Token: 0x040011D7 RID: 4567
		CallList_CapplusCalls_2 = 200600302,
		// Token: 0x040011D8 RID: 4568
		CallList_QuikCallIICalls_1 = 200600401,
		// Token: 0x040011D9 RID: 4569
		CallList_PhoneCalls_1 = 200600501,
		// Token: 0x040011DA RID: 4570
		CallList_AnalogCalls_1 = 200600601,
		// Token: 0x040011DB RID: 4571
		CallList_FiveToneCalls_1 = 200600701,
		// Token: 0x040011DC RID: 4572
		CapacityPlusCalls_CAPPLUSUCL_CONNECTTYPE_1 = 200800101,
		// Token: 0x040011DD RID: 4573
		CapacityPlusDataListItems_InvalidPersonality = 201000001,
		// Token: 0x040011DE RID: 4574
		CapacityPlusDataListItems_InvalidChannelType,
		// Token: 0x040011DF RID: 4575
		CapacityPlusRXGroupListItems_CAPPLUS_RXTG_UCLCOMP_1 = 201300001,
		// Token: 0x040011E0 RID: 4576
		CapacityPlusRXGroupListItems_CAPPLUS_RXTG_UCLCOMP_2,
		// Token: 0x040011E1 RID: 4577
		CapacityPlusSiteListItems_Unique_Site_ID = 201500001,
		// Token: 0x040011E2 RID: 4578
		CapacityPlusVoiceListItems_InvalidPersonality = 201700001,
		// Token: 0x040011E3 RID: 4579
		CapacityPlusVoiceListItems_InvalidChannelType,
		// Token: 0x040011E4 RID: 4580
		ControlButtons_LongPressDuration_ms = 201800001,
		// Token: 0x040011E5 RID: 4581
		ControlButtons_GPSONOFF,
		// Token: 0x040011E6 RID: 4582
		ControlButtons_PermanentDiscoverable,
		// Token: 0x040011E7 RID: 4583
		ControlButtons_PrivacyONOFF,
		// Token: 0x040011E8 RID: 4584
		ControlButtons_ReplayTexttoSpeechMessage,
		// Token: 0x040011E9 RID: 4585
		ControlButtons_wifi,
		// Token: 0x040011EA RID: 4586
		ControlButtons_TGOPTBOARD,
		// Token: 0x040011EB RID: 4587
		ConventionalPersonality_CP_ARTSMODETYPE_1 = 202000101,
		// Token: 0x040011EC RID: 4588
		ConventionalPersonality_CP_EMPHASEL_1 = 202000201,
		// Token: 0x040011ED RID: 4589
		ConventionalPersonality_CP_EMPHASEL_2,
		// Token: 0x040011EE RID: 4590
		ConventionalPersonality_CP_EMPHASEL_3,
		// Token: 0x040011EF RID: 4591
		ConventionalPersonality_CP_TXINHXPLEN_1 = 202000301,
		// Token: 0x040011F0 RID: 4592
		ConventionalPersonality_CP_TXINHXPLEN_2,
		// Token: 0x040011F1 RID: 4593
		ConventionalPersonality_CP_TXINHXPLEN_3,
		// Token: 0x040011F2 RID: 4594
		ConventionalPersonality_CP_TXINHXPLEN_4,
		// Token: 0x040011F3 RID: 4595
		ConventionalPersonality_CP_TXINHXPLEN_5,
		// Token: 0x040011F4 RID: 4596
		ConventionalPersonality_CP_TXINHXPLEN_6,
		// Token: 0x040011F5 RID: 4597
		ConventionalPersonality_CP_TXINHXPLEN_8 = 202000308,
		// Token: 0x040011F6 RID: 4598
		ConventionalPersonality_CP_TXINHXPLEN_9,
		// Token: 0x040011F7 RID: 4599
		ConventionalPersonality_CP_GPSRVRTPERSIT_1 = 202000401,
		// Token: 0x040011F8 RID: 4600
		ConventionalPersonality_CP_GPSRVRTPERSIT_2,
		// Token: 0x040011F9 RID: 4601
		ConventionalPersonality_CP_GPSRVRTPERSIT_3,
		// Token: 0x040011FA RID: 4602
		ConventionalPersonality_CP_GPSRVRTPERSIT_4,
		// Token: 0x040011FB RID: 4603
		ConventionalPersonality_CP_GPSRVRTPERSIT_5,
		// Token: 0x040011FC RID: 4604
		ConventionalPersonality_CP_GPSRVRTPERSIT_6,
		// Token: 0x040011FD RID: 4605
		ConventionalPersonality_CP_GPSRVRTPERSIT_7,
		// Token: 0x040011FE RID: 4606
		ConventionalPersonality_CP_GPSRVRTPERSIT_8,
		// Token: 0x040011FF RID: 4607
		ConventionalPersonality_CP_GPSRVRTPERSIT_9,
		// Token: 0x04001200 RID: 4608
		ConventionalPersonality_CP_MYCALLADCRTR_1 = 202000501,
		// Token: 0x04001201 RID: 4609
		ConventionalPersonality_CP_MYCALLADCRTR_2,
		// Token: 0x04001202 RID: 4610
		ConventionalPersonality_CP_MYCALLADCRTR_3,
		// Token: 0x04001203 RID: 4611
		ConventionalPersonality_CP_ENHCPRVCYIT_1 = 202000601,
		// Token: 0x04001204 RID: 4612
		ConventionalPersonality_CP_TRUNKCHANLISTIT_1 = 202000701,
		// Token: 0x04001205 RID: 4613
		ConventionalPersonality_CP_S1SCHGPSPRWDRSV_1 = 202000801,
		// Token: 0x04001206 RID: 4614
		ConventionalPersonality_CP_S1SCHGPSPRWDRSV_2,
		// Token: 0x04001207 RID: 4615
		ConventionalPersonality_CP_S1SCHGPSPRWDRSV_3,
		// Token: 0x04001208 RID: 4616
		ConventionalPersonality_CP_S2SCHGPSPRWDRSV_1 = 202000901,
		// Token: 0x04001209 RID: 4617
		ConventionalPersonality_CP_S2SCHGPSPRWDRSV_2,
		// Token: 0x0400120A RID: 4618
		ConventionalPersonality_CP_S2SCHGPSPRWDRSV_3,
		// Token: 0x0400120B RID: 4619
		ConventionalPersonality_CP_ARSPLUS_1 = 202001001,
		// Token: 0x0400120C RID: 4620
		ConventionalPersonality_CP_ARSPLUS_2,
		// Token: 0x0400120D RID: 4621
		ConventionalPersonality_CP_ARSPLUS_3,
		// Token: 0x0400120E RID: 4622
		ConventionalPersonality_CP_ARSPLUS_4,
		// Token: 0x0400120F RID: 4623
		ConventionalPersonality_CP_SQUELCHMODE_1 = 202001101,
		// Token: 0x04001210 RID: 4624
		ConventionalPersonality_CP_SCNROAMLISTIT_1 = 202001201,
		// Token: 0x04001211 RID: 4625
		ConventionalPersonality_CP_SCNROAMLISTIT_2,
		// Token: 0x04001212 RID: 4626
		ConventionalPersonality_CP_SCNROAMLISTIT_3,
		// Token: 0x04001213 RID: 4627
		ConventionalPersonality_CP_SCNROAMLISTIT_4,
		// Token: 0x04001214 RID: 4628
		ConventionalPersonality_CP_LONEWORKEN_1 = 202001301,
		// Token: 0x04001215 RID: 4629
		ConventionalPersonality_CP_TALKAROUNDEN_1 = 202001401,
		// Token: 0x04001216 RID: 4630
		ConventionalPersonality_CP_TALKAROUNDEN_2,
		// Token: 0x04001217 RID: 4631
		ConventionalPersonality_CP_TALKAROUNDEN_3,
		// Token: 0x04001218 RID: 4632
		ConventionalPersonality_CP_TALKAROUNDEN_4,
		// Token: 0x04001219 RID: 4633
		ConventionalPersonality_CP_TALKAROUNDEN_5,
		// Token: 0x0400121A RID: 4634
		ConventionalPersonality_CP_TALKAROUNDEN_6,
		// Token: 0x0400121B RID: 4635
		ConventionalPersonality_CP_TALKAROUNDEN_7,
		// Token: 0x0400121C RID: 4636
		ConventionalPersonality_CP_CHNLBWDTH_1 = 202001501,
		// Token: 0x0400121D RID: 4637
		ConventionalPersonality_CP_CHNLBWDTH_2,
		// Token: 0x0400121E RID: 4638
		ConventionalPersonality_CP_CHNLBWDTH_3,
		// Token: 0x0400121F RID: 4639
		ConventionalPersonality_CP_CHNLBWDTH_4,
		// Token: 0x04001220 RID: 4640
		ConventionalPersonality_CP_CHNLBWDTH_5,
		// Token: 0x04001221 RID: 4641
		ConventionalPersonality_CP_UKPPERS_1 = 202001601,
		// Token: 0x04001222 RID: 4642
		ConventionalPersonality_CP_UKPPERS_2,
		// Token: 0x04001223 RID: 4643
		ConventionalPersonality_CP_UKPPERS_3,
		// Token: 0x04001224 RID: 4644
		ConventionalPersonality_CP_UKPPERS_4,
		// Token: 0x04001225 RID: 4645
		ConventionalPersonality_NONMSIDMR3_MSAC_Confict,
		// Token: 0x04001226 RID: 4646
		ConventionalPersonality_CP_TXTPLCODE_1 = 202001701,
		// Token: 0x04001227 RID: 4647
		ConventionalPersonality_CP_RXTPLCODE_1 = 202001801,
		// Token: 0x04001228 RID: 4648
		ConventionalPersonality_CP_TOCEN_1 = 202001901,
		// Token: 0x04001229 RID: 4649
		ConventionalPersonality_CP_TXREFFREQ_1 = 202002001,
		// Token: 0x0400122A RID: 4650
		ConventionalPersonality_CP_TXFREQ_1 = 202002101,
		// Token: 0x0400122B RID: 4651
		ConventionalPersonality_CP_REVBURST_1 = 202002201,
		// Token: 0x0400122C RID: 4652
		ConventionalPersonality_CP_REVBURST_2,
		// Token: 0x0400122D RID: 4653
		ConventionalPersonality_CP_RXSIGSQL_1 = 202002301,
		// Token: 0x0400122E RID: 4654
		ConventionalPersonality_CP_RXSIGSQL_2,
		// Token: 0x0400122F RID: 4655
		ConventionalPersonality_CP_RXSIGSQL_3,
		// Token: 0x04001230 RID: 4656
		ConventionalPersonality_CP_MLTSTSLTEN_1 = 202002401,
		// Token: 0x04001231 RID: 4657
		ConventionalPersonality_CP_MLTSTSLTEN_2,
		// Token: 0x04001232 RID: 4658
		ConventionalPersonality_CP_SYSTEMCONTROLLERMODE_1 = 202002501,
		// Token: 0x04001233 RID: 4659
		ConventionalPersonality_CP_SYSTEMCONTROLLERMODE_2,
		// Token: 0x04001234 RID: 4660
		ConventionalPersonality_CP_SYSTEMCONTROLLERMODE_3,
		// Token: 0x04001235 RID: 4661
		ConventionalPersonality_CP_SYSTEMCONTROLLERMODE_4,
		// Token: 0x04001236 RID: 4662
		ConventionalPersonality_CP_MANDOWNPROFILEITEM_1 = 202002601,
		// Token: 0x04001237 RID: 4663
		ConventionalPersonality_CP_MANDOWNPROFILEITEM_2,
		// Token: 0x04001238 RID: 4664
		ConventionalPersonality_CP_HCS_1 = 202002701,
		// Token: 0x04001239 RID: 4665
		ConventionalPersonality_CP_HCS_2,
		// Token: 0x0400123A RID: 4666
		ConventionalPersonality_CP_HCS_3,
		// Token: 0x0400123B RID: 4667
		ConventionalPersonality_CP_PHONEGWEN_1 = 202002801,
		// Token: 0x0400123C RID: 4668
		ConventionalPersonality_CP_PHONEGWEN_2,
		// Token: 0x0400123D RID: 4669
		ConventionalPersonality_CP_UTOSCANEN_1 = 202002901,
		// Token: 0x0400123E RID: 4670
		ConventionalPersonality_CP_MLTSTPSNLTIND_1 = 202003001,
		// Token: 0x0400123F RID: 4671
		ConventionalPersonality_CP_MLTSTPSNLTIND_2,
		// Token: 0x04001240 RID: 4672
		ConventionalPersonality_CP_MLTSTPSNLTIND_3,
		// Token: 0x04001241 RID: 4673
		ConventionalPersonality_CP_DUALSLOTDATAOPERATION_1 = 202003101,
		// Token: 0x04001242 RID: 4674
		ConventionalPersonality_CP_OTARMODE_1 = 202003201,
		// Token: 0x04001243 RID: 4675
		ConventionalPersonality_CP_RXFREQ_1 = 202003301,
		// Token: 0x04001244 RID: 4676
		ConventionalPersonality_CP_PHONESYSIT_1 = 202003401,
		// Token: 0x04001245 RID: 4677
		ConventionalPersonality_CP_625EDMEN_1 = 202003501,
		// Token: 0x04001246 RID: 4678
		ConventionalPersonality_CP_SCHGPSEN_1 = 202003601,
		// Token: 0x04001247 RID: 4679
		ConventionalPersonality_CP_SCHGPSEN_2,
		// Token: 0x04001248 RID: 4680
		ConventionalPersonality_CP_TRTEN_1 = 202003701,
		// Token: 0x04001249 RID: 4681
		ConventionalPersonality_CP_TRTEN_2,
		// Token: 0x0400124A RID: 4682
		ConventionalPersonality_CP_TRTEN_3,
		// Token: 0x0400124B RID: 4683
		ConventionalPersonality_CP_SFRENABLE_1 = 202003801,
		// Token: 0x0400124C RID: 4684
		ConventionalPersonality_CP_OBTRUNKMODE_1 = 202003901,
		// Token: 0x0400124D RID: 4685
		ConventionalPersonality_CP_OBTRUNKMODE_2,
		// Token: 0x0400124E RID: 4686
		ConventionalPersonality_CP_EMALRMINDEN_1 = 202004001,
		// Token: 0x0400124F RID: 4687
		ConventionalPersonality_CP_EMALRMINDEN_2,
		// Token: 0x04001250 RID: 4688
		ConventionalPersonality_CP_EMCALINDEN_1 = 202005001,
		// Token: 0x04001251 RID: 4689
		ConventionalPersonality_CP_AESPRVCYIT_1 = 202008001,
		// Token: 0x04001252 RID: 4690
		ConventionalPersonality_CP_VOXSTATE_1 = 202009001,
		// Token: 0x04001253 RID: 4691
		ConventionalPersonality_CP_VOICEPRIVACYEN_1 = 202010001,
		// Token: 0x04001254 RID: 4692
		ConventionalPersonality_CP_EMSYSIT_1 = 202011001,
		// Token: 0x04001255 RID: 4693
		ConventionalPersonality_CP_TGLISTIT_1 = 202012001,
		// Token: 0x04001256 RID: 4694
		ConventionalPersonality_CP_CNVPERSALIAS_1 = 202013001,
		// Token: 0x04001257 RID: 4695
		ConventionalPersonality_CP_CNVPERSALIAS_2,
		// Token: 0x04001258 RID: 4696
		ConventionalPersonality_ConventionalPersonality_1 = 202014001,
		// Token: 0x04001259 RID: 4697
		ConventionalPersonality_CP_OBTRUNKMODEy_1 = 202015001,
		// Token: 0x0400125A RID: 4698
		ConventionalPersonality_DMR3TRUNKING_1,
		// Token: 0x0400125B RID: 4699
		ConventionalPersonality_DMR3CAPACITY_1,
		// Token: 0x0400125C RID: 4700
		ConventionalPersonality_CBFREQUENCYNOTDISPLAYINSCANLIST,
		// Token: 0x0400125D RID: 4701
		ConventionalPersonality_CP_LCPSTLSTIT_1 = 202016001,
		// Token: 0x0400125E RID: 4702
		ConventionalPersonality_DMR3,
		// Token: 0x0400125F RID: 4703
		ConventionalPersonality_CP_TXCOMPUDPIPHEADEN_1 = 202017001,
		// Token: 0x04001260 RID: 4704
		ConventionalPersonality_CP_PERSTYPE_1 = 202018001,
		// Token: 0x04001261 RID: 4705
		ConventionalPersonality_CP_PERSTYPE_2,
		// Token: 0x04001262 RID: 4706
		ConventionalPersonality_CP_PERSTYPE_3,
		// Token: 0x04001263 RID: 4707
		ConventionalPersonality_CBChannelValid_1 = 202020001,
		// Token: 0x04001264 RID: 4708
		ConventionalPersonality_CP_DMR3Sites_1 = 202021001,
		// Token: 0x04001265 RID: 4709
		ConventionalPersonality_CP_DMR3Sites_Invalid_2,
		// Token: 0x04001266 RID: 4710
		ConventionalPersonality_ChannelTypeForLinkTypeCheck = 202030001,
		// Token: 0x04001267 RID: 4711
		ConventionalPersonality_CP_DMR3System_Invalid,
		// Token: 0x04001268 RID: 4712
		ConventionalPersonality_CP_DMR3System_Invalid2,
		// Token: 0x04001269 RID: 4713
		ConventionalPersonality_CP_DMR3Channels_InValid,
		// Token: 0x0400126A RID: 4714
		ConventionalPersonality_CP_RAS_Invalid,
		// Token: 0x0400126B RID: 4715
		ConventionalPersonality_DecoderDefinitionSelections_1 = 202031001,
		// Token: 0x0400126C RID: 4716
		ConventionalPersonality_OTARMODE_1 = 202041001,
		// Token: 0x0400126D RID: 4717
		ConventionalPersonality_CP_INTRPTMSGDLY_RPTR_1 = 202042001,
		// Token: 0x0400126E RID: 4718
		DecoderDefinitions_S5DECODER_AUTOACKITEM_1 = 202200101,
		// Token: 0x0400126F RID: 4719
		DecoderDefinitions_S5DECODER_DECSEQ1_1 = 202200201,
		// Token: 0x04001270 RID: 4720
		DecoderDefinitions_S5DECODER_DECSEQ1_2,
		// Token: 0x04001271 RID: 4721
		DecoderDefinitions_S5DECODER_DECSEQ1_3,
		// Token: 0x04001272 RID: 4722
		DecoderDefinitions_S5DECSTSLDLL_5TSTSNUM_1 = 202200301,
		// Token: 0x04001273 RID: 4723
		DecoderDefinitions_S5DECSTSLDLL_5TSTSNUM_2,
		// Token: 0x04001274 RID: 4724
		DecoderStatusListItems_S5DECSTSLDLL_5TSTSNUM_1 = 202300101,
		// Token: 0x04001275 RID: 4725
		DecoderStatusListItems_S5DECSTSLDLL_5TSTSNUM_2,
		// Token: 0x04001276 RID: 4726
		DecoderStatusListItems_S5DECSTSLDLL_5TSTSNUM_3,
		// Token: 0x04001277 RID: 4727
		DigitalCalls_DU_CONNECTTYPE_1 = 202400101,
		// Token: 0x04001278 RID: 4728
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_1 = 202500101,
		// Token: 0x04001279 RID: 4729
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_2,
		// Token: 0x0400127A RID: 4730
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_3,
		// Token: 0x0400127B RID: 4731
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_4,
		// Token: 0x0400127C RID: 4732
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_5,
		// Token: 0x0400127D RID: 4733
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_6,
		// Token: 0x0400127E RID: 4734
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_7,
		// Token: 0x0400127F RID: 4735
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_8,
		// Token: 0x04001280 RID: 4736
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_9,
		// Token: 0x04001281 RID: 4737
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_10,
		// Token: 0x04001282 RID: 4738
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_11,
		// Token: 0x04001283 RID: 4739
		DigitalEmergencySystems_DESS_EMERGENCYGROUPIT_NonGroupCall = 202500200,
		// Token: 0x04001284 RID: 4740
		DigitalEmergencySystems_DESS_EMERGENCYGROUPIT_NonDigitalCall,
		// Token: 0x04001285 RID: 4741
		DigitalRXGroupListItems_RXTG_DGUCLCOMP_1 = 202700101,
		// Token: 0x04001286 RID: 4742
		DigitalRXGroupListItems_RXTG_DGUCLCOMP_2,
		// Token: 0x04001287 RID: 4743
		Encoder_RC_ADDRESSMANUALDIALRANGE1MAX_1 = 202800101,
		// Token: 0x04001288 RID: 4744
		Encoder_RC_ADDRESSMANUALDIALRANGE1MIN_1 = 202800201,
		// Token: 0x04001289 RID: 4745
		Encoder_RC_ADDRESSMANUALDIALRANGE2MAX_1 = 202800301,
		// Token: 0x0400128A RID: 4746
		Encoder_RC_ADDRESSMANUALDIALRANGE2MIN_1 = 202800401,
		// Token: 0x0400128B RID: 4747
		Encoder_RC_ADDRESSMANUALDIALRANGE3MAX_1 = 202800501,
		// Token: 0x0400128C RID: 4748
		Encoder_RC_ADDRESSMANUALDIALRANGE3MIN_1 = 202800601,
		// Token: 0x0400128D RID: 4749
		Encoder_RC_STATUSMANUALDIALRANGE1MAX_1 = 202800701,
		// Token: 0x0400128E RID: 4750
		Encoder_RC_STATUSMANUALDIALRANGE1MIN_1 = 202800801,
		// Token: 0x0400128F RID: 4751
		Encoder_RC_STATUSMANUALDIALRANGE2MAX_1 = 202800901,
		// Token: 0x04001290 RID: 4752
		Encoder_RC_STATUSMANUALDIALRANGE2MIN_1 = 202801001,
		// Token: 0x04001291 RID: 4753
		Encoder_RC_STATUSMANUALDIALRANGE3MAX_1 = 202801101,
		// Token: 0x04001292 RID: 4754
		Encoder_RC_STATUSMANUALDIALRANGE3MIN_1 = 202801201,
		// Token: 0x04001293 RID: 4755
		EncoderSequences_S5ENCSEQ_PRETIME_1 = 202900101,
		// Token: 0x04001294 RID: 4756
		EncoderSequences_S5ENCSEQ_EXTFSTTDUR_1 = 202900201,
		// Token: 0x04001295 RID: 4757
		EncoderSequences_S5ENCSEQ_SEQ_1 = 202900301,
		// Token: 0x04001296 RID: 4758
		EncoderSequences_S5ENCSEQ_SEQ_2,
		// Token: 0x04001297 RID: 4759
		EncoderSequences_S5ENCSEQ_SEQ_3,
		// Token: 0x04001298 RID: 4760
		EncoderSequences_S5ENCSEQ_SEQ_4,
		// Token: 0x04001299 RID: 4761
		EncoderSequences_S5ENCSEQ_SEQ_5,
		// Token: 0x0400129A RID: 4762
		EncoderStatusListItems_S5ENCSTSLDLL_5TSTSNUM_1 = 203100101,
		// Token: 0x0400129B RID: 4763
		EncoderStatusListItems_S5ENCSTSLDLL_5TSTSNUM_2,
		// Token: 0x0400129C RID: 4764
		EncoderStatusListItems_S5ENCSTSLDLL_5TSTSNUM_3,
		// Token: 0x0400129D RID: 4765
		EnhancedPrivacyKeys_KeyValueInvalid = 203200001,
		// Token: 0x0400129E RID: 4766
		EnhancedPrivacyKeys_KeyAliasInvalid,
		// Token: 0x0400129F RID: 4767
		EnhancedPrivacyKeys_KeyIDInvalid,
		// Token: 0x040012A0 RID: 4768
		FiveToneCalls = 203300000,
		// Token: 0x040012A1 RID: 4769
		FiveToneCalls_S5CLDLL_5TCALLADD_1 = 203300101,
		// Token: 0x040012A2 RID: 4770
		FiveToneCalls_S5CLDLL_5TCALLADD_2,
		// Token: 0x040012A3 RID: 4771
		FiveToneSystems_S5CLDLL_5TCALLADD_1 = 203400101,
		// Token: 0x040012A4 RID: 4772
		FiveToneSystems_S5SS_GRPTONE_1 = 203400201,
		// Token: 0x040012A5 RID: 4773
		FiveToneSystems_S5SS_RPTTONE_1 = 203400301,
		// Token: 0x040012A6 RID: 4774
		FlexibleCapacityPlusRXGroupListItems = 203600000,
		// Token: 0x040012A7 RID: 4775
		FlexibleCapacityPlusRXGroupListItems_FLEXIBLECAPPLUSRXTGDLL_LEDITEM_1 = 203600101,
		// Token: 0x040012A8 RID: 4776
		FlexibleCapacityPlusRXGroupListItems_FLEXIBLECAPPLUSRXTGDLL_LEDITEM_2,
		// Token: 0x040012A9 RID: 4777
		GeneralSettings_RC_TXHGHPWR1_1 = 203700101,
		// Token: 0x040012AA RID: 4778
		GeneralSettings_RC_TXHGHPWR_1 = 203700201,
		// Token: 0x040012AB RID: 4779
		GeneralSettings_RC_TXLOWPWR2_1 = 203700301,
		// Token: 0x040012AC RID: 4780
		GeneralSettings_RC_TXHGHPWR2_1 = 203700401,
		// Token: 0x040012AD RID: 4781
		GeneralSettings_BR_DCTXPWER_1 = 203700501,
		// Token: 0x040012AE RID: 4782
		GeneralSettings_BR_DCTXPWER2_1 = 203700601,
		// Token: 0x040012AF RID: 4783
		GeneralSettings_RC_IMBCVINDCT_1 = 203700701,
		// Token: 0x040012B0 RID: 4784
		GeneralSettings_BR_CWID_1 = 203700801,
		// Token: 0x040012B1 RID: 4785
		GeneralSettings_RC_INTANLGFX_1 = 203700901,
		// Token: 0x040012B2 RID: 4786
		GeneralSettings_GNSSCFGCMPBLK_USERSELECTION_1 = 203701001,
		// Token: 0x040012B3 RID: 4787
		GeneralSettings_RC_FPPPWD_1 = 203701101,
		// Token: 0x040012B4 RID: 4788
		GeneralSettings_RC_FPPPWD_2,
		// Token: 0x040012B5 RID: 4789
		GeneralSettings_RC_SEL5RADIOID0_1 = 203701201,
		// Token: 0x040012B6 RID: 4790
		GeneralSettings_RC_SEL5RADIOID0_2,
		// Token: 0x040012B7 RID: 4791
		GeneralSettings_RC_IXTDIGFX_1 = 203701301,
		// Token: 0x040012B8 RID: 4792
		GeneralSettings_RC_GRPCALLHT_1 = 203701401,
		// Token: 0x040012B9 RID: 4793
		GeneralSettings_RC_GRPCALLHT_2,
		// Token: 0x040012BA RID: 4794
		GeneralSettings_PSWD_PSWDDATA_1 = 203701501,
		// Token: 0x040012BB RID: 4795
		GeneralSettings_PSWD_PSWDDATA_2,
		// Token: 0x040012BC RID: 4796
		GeneralSettings_PSWD_PSWDDATA_3,
		// Token: 0x040012BD RID: 4797
		GeneralSettings_PSWD_PSWDDATA_4,
		// Token: 0x040012BE RID: 4798
		GeneralSettings_PSWD_PSWDDATA_5,
		// Token: 0x040012BF RID: 4799
		GeneralSettings_CHECKFORPASSWORD,
		// Token: 0x040012C0 RID: 4800
		GeneralSettings_RC_DSGPWRUPCHANITEM_Zone_1 = 203701601,
		// Token: 0x040012C1 RID: 4801
		GeneralSettings_RC_DSGPWRUPCHANITEM_1 = 203701701,
		// Token: 0x040012C2 RID: 4802
		GeneralSettings_BR_VOTINGMODE_1 = 203701801,
		// Token: 0x040012C3 RID: 4803
		GeneralSettings_BR_VOTINGMODE_2,
		// Token: 0x040012C4 RID: 4804
		GeneralSetting_RC_HOMECHANNELIT_Zone_1 = 203701901,
		// Token: 0x040012C5 RID: 4805
		JobTicketsListItems = 204500000,
		// Token: 0x040012C6 RID: 4806
		JobTicketsListItems_JTSO_ACTRSPTXT_1 = 204500101,
		// Token: 0x040012C7 RID: 4807
		JobTicketsTemplatesListItems_1,
		// Token: 0x040012C8 RID: 4808
		MDCSystems_MDCSYS_MDCEMGCYPERS_1 = 205100101,
		// Token: 0x040012C9 RID: 4809
		MDCSystems_MDCSYS_MDCEMGCYPERS_2,
		// Token: 0x040012CA RID: 4810
		MDCSystems_MDCSYS_MDCEMGCYPERS_3,
		// Token: 0x040012CB RID: 4811
		MDCSystems_MDCSYS_MDCEMGCYPERS_4,
		// Token: 0x040012CC RID: 4812
		MDCSystems_MDCSYS_MDCEMGCYPERS_5,
		// Token: 0x040012CD RID: 4813
		MDCSystems_MDCSYS_MDCEMGCYPERS_6,
		// Token: 0x040012CE RID: 4814
		MDCSystems_MDCSYS_EMGCYTYPE_1 = 205100201,
		// Token: 0x040012CF RID: 4815
		MDCSystems_MDCSYS_EMGCYATYPE_1 = 205100301,
		// Token: 0x040012D0 RID: 4816
		MDCSystems_MDCSYS_PRMID_1 = 205100401,
		// Token: 0x040012D1 RID: 4817
		MDCSystems_MDCSYS_PRMID_2,
		// Token: 0x040012D2 RID: 4818
		MDCSystems_MDCSYS_PRMID_3,
		// Token: 0x040012D3 RID: 4819
		MDCSystems_MDCSYS_GRPID_1 = 205100501,
		// Token: 0x040012D4 RID: 4820
		CnvSysGeneralMDCPrimaryID_A8744_1 = 205100601,
		// Token: 0x040012D5 RID: 4821
		Menu_GPS = 205200101,
		// Token: 0x040012D6 RID: 4822
		Menu_MENU_JBTKTMMNAME_1 = 205200201,
		// Token: 0x040012D7 RID: 4823
		Network_RC_BTPPFXPINHSP_1 = 205400101,
		// Token: 0x040012D8 RID: 4824
		Network_RC_RemoteHSPAddress,
		// Token: 0x040012D9 RID: 4825
		Network_ForwardtoPC,
		// Token: 0x040012DA RID: 4826
		Network_DHCP,
		// Token: 0x040012DB RID: 4827
		Network_WifiIP1,
		// Token: 0x040012DC RID: 4828
		Network_WifiPasswordCannotBeEmpty,
		// Token: 0x040012DD RID: 4829
		Network_WifiSSIDisTooLong,
		// Token: 0x040012DE RID: 4830
		Network_WifiPhase2AuthenticationInvalid,
		// Token: 0x040012DF RID: 4831
		EncryptedNetworkPasswordIsTooLong,
		// Token: 0x040012E0 RID: 4832
		WiFiAnonymousIdentityIsTooLong,
		// Token: 0x040012E1 RID: 4833
		WiFiIdentityIsTooLong,
		// Token: 0x040012E2 RID: 4834
		RMC_ChannelNeedsToBeACapacityMaxPersonality,
		// Token: 0x040012E3 RID: 4835
		NumberKeyQuickContactAccessItems_PGK_UCLITEM_1 = 205500101,
		// Token: 0x040012E4 RID: 4836
		NumberKeyQuickContactAccessItems_PGK_UCLITEM_2,
		// Token: 0x040012E5 RID: 4837
		NumberKeyQuickContactAccessItems_PGK_UCLITEM_3,
		// Token: 0x040012E6 RID: 4838
		NumberKeyQuickContactAccessItems_PGK_UCLITEM_4,
		// Token: 0x040012E7 RID: 4839
		OneTouchAccessItems_OTC_UCLITEM_1 = 205600101,
		// Token: 0x040012E8 RID: 4840
		OneTouchAccessItems_OTC_UCLITEM_2,
		// Token: 0x040012E9 RID: 4841
		OneTouchAccessItems_OTC_UCLITEM_3,
		// Token: 0x040012EA RID: 4842
		OneTouchAccessItems_OTC_UCLITEM_4,
		// Token: 0x040012EB RID: 4843
		OneTouchAccessItems_OTC_UCLITEM_5,
		// Token: 0x040012EC RID: 4844
		OneTouchAccessItems_OTC_UCLITEM_6,
		// Token: 0x040012ED RID: 4845
		OneTouchAccessItems_OTC_HMREVTITEM_1 = 205600201,
		// Token: 0x040012EE RID: 4846
		OneTouchAccessItems_OTC_HMREVTITEM_2,
		// Token: 0x040012EF RID: 4847
		OneTouchAccessItems_OTC_HMREVTITEM_3,
		// Token: 0x040012F0 RID: 4848
		OneTouchAccessItems_OTC_HMREVTITEM_Zone_1 = 205600301,
		// Token: 0x040012F1 RID: 4849
		OneTouchAccessItems_OTC_HMREVTITEM_Zone_2,
		// Token: 0x040012F2 RID: 4850
		OneTouchAccessItems_OTC_CALLTYPE_1 = 205600401,
		// Token: 0x040012F3 RID: 4851
		OneTouchAccessItems_OTC_CALLTYPE_2,
		// Token: 0x040012F4 RID: 4852
		OneTouchAccessItems_OTC_CALLTYPE_3,
		// Token: 0x040012F5 RID: 4853
		OneTouchAccessItems_OTC_CALLTYPE_4,
		// Token: 0x040012F6 RID: 4854
		OneTouchAccessItems_OTC_CALLTYPE_5,
		// Token: 0x040012F7 RID: 4855
		OneTouchAccessItems_OTC_CALLTYPE_6,
		// Token: 0x040012F8 RID: 4856
		OneTouchAccessItems_OTC_CALLTYPE_7,
		// Token: 0x040012F9 RID: 4857
		OneTouchAccessItems_OTC_CALLTYPE_8,
		// Token: 0x040012FA RID: 4858
		OneTouchAccessItems_OTC_CALLTYPE_9,
		// Token: 0x040012FB RID: 4859
		PCRLanguageList_Dup_LanguageID = 205800001,
		// Token: 0x040012FC RID: 4860
		PCRLanguageList_Invalid_LanguageID,
		// Token: 0x040012FD RID: 4861
		PhoneSystem_BRPC_DPPPRECFGCALLTYPE_1 = 206100101,
		// Token: 0x040012FE RID: 4862
		PhoneSystem_DTMFCLELL_DEACCCODE_1 = 206100201,
		// Token: 0x040012FF RID: 4863
		PhoneSystems_DTMFCLELL_ACCCODE_1 = 206200101,
		// Token: 0x04001300 RID: 4864
		QuikCallIICalls_QU_RVRTPERS_1 = 206400101,
		// Token: 0x04001301 RID: 4865
		QuikCallIICalls_QU_RVRTPERS_2,
		// Token: 0x04001302 RID: 4866
		QuikCallIICalls_QU_RVRTPERS_3,
		// Token: 0x04001303 RID: 4867
		QuikCallIICalls_QU_CODEA_1 = 206400201,
		// Token: 0x04001304 RID: 4868
		QuikCallIICalls_QU_CODEB_1 = 206400301,
		// Token: 0x04001305 RID: 4869
		QuikCallIISystems_QCIISYS_CODEA_1 = 206500101,
		// Token: 0x04001306 RID: 4870
		RASKeysList_SecuritySet_1 = 206700001,
		// Token: 0x04001307 RID: 4871
		RASKeys_AliasLength2,
		// Token: 0x04001308 RID: 4872
		RASKeys_AliasValid3,
		// Token: 0x04001309 RID: 4873
		RASKeys_KeyValueInvalid,
		// Token: 0x0400130A RID: 4874
		RASKeys_KeyAliasInvalid,
		// Token: 0x0400130B RID: 4875
		PreSharedKeys_Records_Valid = 206700010,
		// Token: 0x0400130C RID: 4876
		PreSharedKeys_Invalid,
		// Token: 0x0400130D RID: 4877
		RoamList_SSP_CNVPERCOMP_1 = 206900101,
		// Token: 0x0400130E RID: 4878
		Scan_StartVoteRSSIThreshold_dBm = 207100101,
		// Token: 0x0400130F RID: 4879
		ScanItems_SP_DSGTXMEM_Trunking3600_1 = 207200101,
		// Token: 0x04001310 RID: 4880
		ScanItems_SP_DSGTXMEM_Trunking3600_2,
		// Token: 0x04001311 RID: 4881
		ScanItems_SP_DSGTXMEM_Trunking3600_3,
		// Token: 0x04001312 RID: 4882
		ScanItems_SP_DSGTXMEM_Trunking3600_4,
		// Token: 0x04001313 RID: 4883
		ScanItems_SP_DSGTXMEM_1 = 207200201,
		// Token: 0x04001314 RID: 4884
		ScanItems_SP_DSGTXMEM_2,
		// Token: 0x04001315 RID: 4885
		ScanItems_SP_DSGTXMEM_3,
		// Token: 0x04001316 RID: 4886
		ScanItems_SP_PR2MEM_1 = 207200301,
		// Token: 0x04001317 RID: 4887
		ScanItems_Valid_Record_1 = 207200401,
		// Token: 0x04001318 RID: 4888
		ScanListItems_SP_CNVPERCOMP_1 = 207300101,
		// Token: 0x04001319 RID: 4889
		ScanListItems_SP_CNVPERCOMP_2,
		// Token: 0x0400131A RID: 4890
		ScanListItems_SP_CNVPERCOMP_3,
		// Token: 0x0400131B RID: 4891
		Security_RC_PRVCYSVCTP_1 = 207400101,
		// Token: 0x0400131C RID: 4892
		Security_RC_PRVCYSVCTP_2,
		// Token: 0x0400131D RID: 4893
		Security_RC_OTARUKEK_HIDDEN_STRING_BUT_NOT_TEK = 207400201,
		// Token: 0x0400131E RID: 4894
		Security_RC_OTARUKEK_DEFINED_BUT_NOT_TEK,
		// Token: 0x0400131F RID: 4895
		SignalingSystems_RC_EMERGENCYREVERTCHAN_1 = 207500101,
		// Token: 0x04001320 RID: 4896
		SignalingSystems_RC_EMERGENCYREVERTCHAN_2,
		// Token: 0x04001321 RID: 4897
		SignalingSystems_RC_EMERGENCYREVERTCHAN_3,
		// Token: 0x04001322 RID: 4898
		SignalingSystems_DSS_AUTHENTICATIONPASSPHRASE_1 = 207500201,
		// Token: 0x04001323 RID: 4899
		SitesListItems_Neighbor1_1 = 207800101,
		// Token: 0x04001324 RID: 4900
		SitesListItems_Neighbor1_2,
		// Token: 0x04001325 RID: 4901
		TalkgroupsListItems = 208200000,
		// Token: 0x04001326 RID: 4902
		TalkgroupsListItems_WIFILISTDLL_PASSWORD_1 = 208200101,
		// Token: 0x04001327 RID: 4903
		TalkgroupsListItems_WIFILISTDLL_PASSWORD_2,
		// Token: 0x04001328 RID: 4904
		TalkgroupsListItems_WIFILISTDLL_PASSWORD_3,
		// Token: 0x04001329 RID: 4905
		TalkgroupsListItems_WIFILISTDLL_PASSWORD_4,
		// Token: 0x0400132A RID: 4906
		Telegrams_RC_POWERUPAUTOTELGRAM_1 = 208300101,
		// Token: 0x0400132B RID: 4907
		Telegrams_RC_POWERUPAUTOTELGRAMREVERTCHAN_1 = 208300201,
		// Token: 0x0400132C RID: 4908
		TelemetryListItems_TEL_IOCONFIG_1 = 208600101,
		// Token: 0x0400132D RID: 4909
		TelemetryListItems_TEL_IOCONFIG_2,
		// Token: 0x0400132E RID: 4910
		TelemetryListItems_TEL_IOCONFIG_3,
		// Token: 0x0400132F RID: 4911
		TelemetryListItems_TEL_OTTRPIT_1 = 208600201,
		// Token: 0x04001330 RID: 4912
		TelemetryListItems_TEL_OTTRPIT_2,
		// Token: 0x04001331 RID: 4913
		TelemetryListItems_TEL_OTTRPIT_3,
		// Token: 0x04001332 RID: 4914
		TelemetryListItems_TEL_OTTRPITZone_1,
		// Token: 0x04001333 RID: 4915
		TelemetryListItems_TEL_DUCLITEM_1 = 208600301,
		// Token: 0x04001334 RID: 4916
		TelemetryListItems_TEL_DUCLITEM_2,
		// Token: 0x04001335 RID: 4917
		TelemetryListItems_TEL_DUCLITEM_3,
		// Token: 0x04001336 RID: 4918
		TelemetryListItems_TEL_DUCLITEM_4,
		// Token: 0x04001337 RID: 4919
		TelemetryListItems_TEL_MODETYPE_1 = 208600401,
		// Token: 0x04001338 RID: 4920
		TelemetryListItems_TEL_TGTVIO_1 = 208600501,
		// Token: 0x04001339 RID: 4921
		TelemetryListItems_TEL_TGTVIO_2,
		// Token: 0x0400133A RID: 4922
		TextMessagesListItems_QTMSG_QCKTXTMSG_1 = 208700001,
		// Token: 0x0400133B RID: 4923
		TextMessages_CTMSG_MESSAGEMAXSENTLENGTH_1 = 208700101,
		// Token: 0x0400133C RID: 4924
		VoiceAnnouncement_TTS_1 = 209500001,
		// Token: 0x0400133D RID: 4925
		Zone_Zone_1 = 209700101,
		// Token: 0x0400133E RID: 4926
		Zone_Zone_2,
		// Token: 0x0400133F RID: 4927
		Zone_Zone_3,
		// Token: 0x04001340 RID: 4928
		Zone_Zone_4,
		// Token: 0x04001341 RID: 4929
		Zone_Zone_5,
		// Token: 0x04001342 RID: 4930
		Zone_Zone_6,
		// Token: 0x04001343 RID: 4931
		Zone_ZP_ZONEALIAS_1 = 209700201,
		// Token: 0x04001344 RID: 4932
		Zone_ZP_ZONEALIAS_2,
		// Token: 0x04001345 RID: 4933
		Zone_ZP_ZONEALIAS_3,
		// Token: 0x04001346 RID: 4934
		ZoneItems_ZoneItems_1 = 209800101,
		// Token: 0x04001347 RID: 4935
		ZoneItems_NotConventionalPersonality,
		// Token: 0x04001348 RID: 4936
		Radios_RadioIP_1 = 209900001,
		// Token: 0x04001349 RID: 4937
		Radios_RadioIP_2,
		// Token: 0x0400134A RID: 4938
		Radios_RC_RADIOALIAS_1 = 209900101,
		// Token: 0x0400134B RID: 4939
		Radios_RC_RadioID_CAI_IP_Dep_1 = 209900201,
		// Token: 0x0400134C RID: 4940
		WelcomeBitmap_WelcomeBitmapContent_1 = 210100101,
		// Token: 0x0400134D RID: 4941
		JobTicketsTemplatesListItems = 210200000,
		// Token: 0x0400134E RID: 4942
		JobTicketsTemplatesListItems_JTTDLL_ORIGINALTEXT_1 = 210200101,
		// Token: 0x0400134F RID: 4943
		JobTicketsTemplatesListItems_JTTDLL_ORIGINALTEXT_2,
		// Token: 0x04001350 RID: 4944
		JobTicketsTemplatesListItems_JTTDLL_ORIGINALTEXT_3,
		// Token: 0x04001351 RID: 4945
		JobTicketsTemplatesListItems_JTTDLL_ITEMTAG_1 = 210200201,
		// Token: 0x04001352 RID: 4946
		JobTicketsTemplatesListItems_JTTDLL_OPTIONLISTIT_1 = 210200301,
		// Token: 0x04001353 RID: 4947
		JobTicketsTemplates = 210300000,
		// Token: 0x04001354 RID: 4948
		JobTicketsTemplates_JTTDLH_TEMPLATETAG_1 = 210300101,
		// Token: 0x04001355 RID: 4949
		FlexibleDMR3RXGroupListItems = 210500000,
		// Token: 0x04001356 RID: 4950
		FlexibleDMR3RXGroupListItems_FLEXIBLEDMR3RXTGDLL_LEDITEM_1 = 210500101,
		// Token: 0x04001357 RID: 4951
		FlexibleDMR3RXGroupListItems_FLEXIBLEDMR3RXTGDLL_LEDITEM_2,
		// Token: 0x04001358 RID: 4952
		DMR3Channels = 210600000,
		// Token: 0x04001359 RID: 4953
		DMR3Channels_Voice_1,
		// Token: 0x0400135A RID: 4954
		DMR3Channels_Control_1,
		// Token: 0x0400135B RID: 4955
		DMR3Channels_Revert_1,
		// Token: 0x0400135C RID: 4956
		DMR3Channels_Invalid_1,
		// Token: 0x0400135D RID: 4957
		DMR3Channels_ChannelName_1 = 210600101,
		// Token: 0x0400135E RID: 4958
		DMR3Channels_ChannelName_2,
		// Token: 0x0400135F RID: 4959
		DMR3Channels_ChannelName_3,
		// Token: 0x04001360 RID: 4960
		DMR3Channels_ChannelID_1 = 210600301,
		// Token: 0x04001361 RID: 4961
		DMR3Channels_ChannelID_2,
		// Token: 0x04001362 RID: 4962
		DMR3Channels_ChannelID_3,
		// Token: 0x04001363 RID: 4963
		DMR3Channels_Type_1 = 210600401,
		// Token: 0x04001364 RID: 4964
		DMR3Systems = 210700000,
		// Token: 0x04001365 RID: 4965
		DMR3Systems_NetworkID_5 = 210700105,
		// Token: 0x04001366 RID: 4966
		DMR3Systems_DMR3SYS_DMRLA_1 = 210700301,
		// Token: 0x04001367 RID: 4967
		DMR3Systems_DMR3SYS_DMRLA_2,
		// Token: 0x04001368 RID: 4968
		DMR3Systems_DMR3SYS_DMRLA_3,
		// Token: 0x04001369 RID: 4969
		DMR3Systems_DMR3SYS_DMRLA_4,
		// Token: 0x0400136A RID: 4970
		DMR3Systems_FixedChannelPlan_1 = 210700401,
		// Token: 0x0400136B RID: 4971
		DMR3Systems_MasterKey_1 = 210700501,
		// Token: 0x0400136C RID: 4972
		DMR3Systems_ControllerIP_1 = 210700701,
		// Token: 0x0400136D RID: 4973
		DMR3Systems_Recset_Valid = 210700801,
		// Token: 0x0400136E RID: 4974
		DMR3Systems_EnhancedChannelAccess_Valid = 210700901,
		// Token: 0x0400136F RID: 4975
		DMR3Sites = 210800000,
		// Token: 0x04001370 RID: 4976
		DMR3Sites_Invalid_1,
		// Token: 0x04001371 RID: 4977
		DMR3Sites_Invalid_2,
		// Token: 0x04001372 RID: 4978
		DMR3Sites_Invalid_3,
		// Token: 0x04001373 RID: 4979
		DMR3Sites_SiteName_1 = 210800101,
		// Token: 0x04001374 RID: 4980
		DMR3Sites_SiteName_2,
		// Token: 0x04001375 RID: 4981
		DMR3Sites_SiteName_3,
		// Token: 0x04001376 RID: 4982
		DMR3Sites_SiteID_1 = 210800201,
		// Token: 0x04001377 RID: 4983
		DMR3Sites_SiteID_2,
		// Token: 0x04001378 RID: 4984
		DMR3Sites_SiteID_3,
		// Token: 0x04001379 RID: 4985
		DMR3Sites_SiteID_4,
		// Token: 0x0400137A RID: 4986
		DMR3Sites_SiteID_5,
		// Token: 0x0400137B RID: 4987
		DMR3Sites_ChannPlan_1 = 210800401,
		// Token: 0x0400137C RID: 4988
		DMR3Sites_ChannPlan_2,
		// Token: 0x0400137D RID: 4989
		DMR3Sites_BaseIP_OutMaxRang,
		// Token: 0x0400137E RID: 4990
		DMR3EmergencySystems = 211000000,
		// Token: 0x0400137F RID: 4991
		DMR3EmergencySystems_Call_1 = 211000101,
		// Token: 0x04001380 RID: 4992
		DMR3EmergencySystems_Call_2,
		// Token: 0x04001381 RID: 4993
		LinkEstablishment = 211100000,
		// Token: 0x04001382 RID: 4994
		LinkEstablishment_MTST_REPEATERTYPE_1 = 211100101,
		// Token: 0x04001383 RID: 4995
		LinkEstablishment_MTST_REPEATERTYPE_2,
		// Token: 0x04001384 RID: 4996
		AdjacentSites = 211200000,
		// Token: 0x04001385 RID: 4997
		AdjacentSite_Site_Set_Self_1 = 211200101,
		// Token: 0x04001386 RID: 4998
		AdjacentSite_Site_Duplicated_1,
		// Token: 0x04001387 RID: 4999
		AdjacentSite_Site_Overflow_1,
		// Token: 0x04001388 RID: 5000
		AdjacentSite_Site_Set_Invalid_4,
		// Token: 0x04001389 RID: 5001
		MNISSystem_MNISSYS_ENHANCED_PRIVACY_KEY_Invalid1 = 211300201,
		// Token: 0x0400138A RID: 5002
		CMB_LPSERVERADDRESSServerAddres_Valid,
		// Token: 0x0400138B RID: 5003
		CMB_SUBCOLMAPPINGCOL_Valid,
		// Token: 0x0400138C RID: 5004
		CMB_SUBCOLMAPPINGROW_Valid,
		// Token: 0x0400138D RID: 5005
		CMB_SUBCOLMAPPINGROWBRI_Valid,
		// Token: 0x0400138E RID: 5006
		CMB_TGMAPPINGCOL_Valid,
		// Token: 0x0400138F RID: 5007
		CMB_TGMAPPINGROW_Valid,
		// Token: 0x04001390 RID: 5008
		CMB_TGMAPPINGROWBRI_Valid,
		// Token: 0x04001391 RID: 5009
		CMB_VRC_AUDIO_RECEIVE_PORT_Valid,
		// Token: 0x04001392 RID: 5010
		CMB_XRT_AUDIO_RECEIVE_PORT_Valid,
		// Token: 0x04001393 RID: 5011
		MNISSites = 211400000,
		// Token: 0x04001394 RID: 5012
		MNISSites_MNISSITE_SITE_1 = 211400101,
		// Token: 0x04001395 RID: 5013
		TGSASites = 211500000,
		// Token: 0x04001396 RID: 5014
		MNISSitesList = 211600000,
		// Token: 0x04001397 RID: 5015
		MNISSitesList_DMR3SYSTEM_1 = 211600101,
		// Token: 0x04001398 RID: 5016
		MNISForwardingRules = 211700000,
		// Token: 0x04001399 RID: 5017
		MNISForwardingRules_MNISFWDR_UDP_PORT_1 = 211700101,
		// Token: 0x0400139A RID: 5018
		MNISForwardingRules_Record_1 = 211700201,
		// Token: 0x0400139B RID: 5019
		MNISAppOverrideRules = 211800000,
		// Token: 0x0400139C RID: 5020
		MNISAppOverrideRules_MNISAOR_UDP_PORT_1 = 211800101,
		// Token: 0x0400139D RID: 5021
		OTARKeys_OPC_OTARACTIVETEKKID_AboveMax = 211900100,
		// Token: 0x0400139E RID: 5022
		OTARKeys_OPC_OTARACTIVETEKKID_BelowMin,
		// Token: 0x0400139F RID: 5023
		OTARKeys_OPC_OTARACTIVETEKKID_HiddenString,
		// Token: 0x040013A0 RID: 5024
		HomeChannel_RC_HOMECHANNELIT_ChannelInvalid = 212000100,
		// Token: 0x040013A1 RID: 5025
		HomeChannel_RC_HOMECHANNELIT_ChannelNotDigital,
		// Token: 0x040013A2 RID: 5026
		HomeChannel_RC_HOMECHANNELIT_InvalidChannelFields,
		// Token: 0x040013A3 RID: 5027
		MNISNetwork_MNISNW_BM_UDP_PORT_ID_Valid = 212100100,
		// Token: 0x040013A4 RID: 5028
		MNISNetwork_MNISNW_LRRP_SERVER_PORT_Valid = 212100200,
		// Token: 0x040013A5 RID: 5029
		Indoor_Location_Anchor_UUID_Length_Error = 212200100,
		// Token: 0x040013A6 RID: 5030
		SiteAnnouncement_Valid_1 = 212300000,
		// Token: 0x040013A7 RID: 5031
		SiteAnnouncement_Valid_2,
		// Token: 0x040013A8 RID: 5032
		SiteAnnouncement_SA_SITEID_Valid_1 = 212300101,
		// Token: 0x040013A9 RID: 5033
		SiteAnnouncement_SA_SITEID_Valid_2,
		// Token: 0x040013AA RID: 5034
		Hostname_DNSAddressHostname_Invalid = 212500001,
		// Token: 0x040013AB RID: 5035
		DMR3StatusMessageListItems_DMR3SMLDLL_DMR3STATUSALIAS_1 = 212600101,
		// Token: 0x040013AC RID: 5036
		DMR3AuthDataList_DMR3SAC_DOMAIN_ID_1 = 212700101,
		// Token: 0x040013AD RID: 5037
		OTAPAuthenticationKey_KeyValueInvalid = 212800001,
		// Token: 0x040013AE RID: 5038
		OTAPAuthenticationKey_KeyAliasInvalid,
		// Token: 0x040013AF RID: 5039
		OTAPAuthenticationKey_KeyIDInvalid,
		// Token: 0x040013B0 RID: 5040
		PBBWiFiSSID_1 = 300000000,
		// Token: 0x040013B1 RID: 5041
		PBBWiFiSSID_2,
		// Token: 0x040013B2 RID: 5042
		PBBWiFiSSID_3,
		// Token: 0x040013B3 RID: 5043
		PBBWiFiSSID_4,
		// Token: 0x040013B4 RID: 5044
		PBBWiFiEncryption_1,
		// Token: 0x040013B5 RID: 5045
		PBBWiFiEncryption_2,
		// Token: 0x040013B6 RID: 5046
		PBBWiFiEncryption_3,
		// Token: 0x040013B7 RID: 5047
		PBBWiFiPassword_1,
		// Token: 0x040013B8 RID: 5048
		PBBWiFiPassword_2,
		// Token: 0x040013B9 RID: 5049
		PBBWiFiPassword_3,
		// Token: 0x040013BA RID: 5050
		Si500IsMandatory,
		// Token: 0x040013BB RID: 5051
		WhiteList_Already_Exists,
		// Token: 0x040013BC RID: 5052
		PBBWhiteListFields_Invalid,
		// Token: 0x040013BD RID: 5053
		PBBAPNMandatoryFields_Invalid,
		// Token: 0x040013BE RID: 5054
		ID_FusionConfiguration_Audio_Recording_Is_Inapplicable = 300010001,
		// Token: 0x040013BF RID: 5055
		ID_FusionConfiguration_Covert_Mode_Is_Inapplicable,
		// Token: 0x040013C0 RID: 5056
		ID_FusionConfiguration_Photo_Capture_Is_Inapplicable,
		// Token: 0x040013C1 RID: 5057
		ID_FusionConfiguration_PairedRadioConnectionTypeSelectable_Is_InValid,
		// Token: 0x040013C2 RID: 5058
		ID_FusionConfiguration_Wired_Is_Inapplicable,
		// Token: 0x040013C3 RID: 5059
		ID_FusionConfiguration_Bluetooth_Is_Inapplicable,
		// Token: 0x040013C4 RID: 5060
		ID_FusionConfiguration_Standalone_Is_Inapplicable,
		// Token: 0x040013C5 RID: 5061
		ID_FusionConfiguration_Audio_Mute_Unmute_When_Video_Recording_Is_Inapplicable,
		// Token: 0x040013C6 RID: 5062
		ID_FusionConfiguration_PreBuffering_When_User_Did_Not_Enable_VideoPreBuffering_Is_Invalid,
		// Token: 0x040013C7 RID: 5063
		CommonTypeIIFNEControlChannel_TrkSysControlChannelsTxFrequencyMHz_A9535_1,
		// Token: 0x040013C8 RID: 5064
		CommonTypeIIFNEControlChannel_TrkSysControlChannelsTxFrequencyMHz_A9535_2,
		// Token: 0x040013C9 RID: 5065
		CommonTypeIITrunkingOneTouch_FeatureNotEnabled = 600100200,
		// Token: 0x040013CA RID: 5066
		CommonTypeIITrunkingOneTouch_FeatureInvalid,
		// Token: 0x040013CB RID: 5067
		CommonTypeIITrunkingOneTouch_IndexOutofRange,
		// Token: 0x040013CC RID: 5068
		CommonTypeIITrunkingSystem_TrkSysFeaturesChannel_A7647_1 = 600200101,
		// Token: 0x040013CD RID: 5069
		CommonTypeIITrunkingSystem_TrkSysFeaturesChannel_A7647_2,
		// Token: 0x040013CE RID: 5070
		CommonTypeIITrunkingSystem_TrkSysFeaturesChannel_A7647_3,
		// Token: 0x040013CF RID: 5071
		CommonTypeIITrunkingSystem_TrkSysSiteAliasSiteAliasEnable_A9148_1 = 600200201,
		// Token: 0x040013D0 RID: 5072
		CommonTypeIITrunkingSystem_TrkSysFeaturesZone_A9717_1 = 600200301,
		// Token: 0x040013D1 RID: 5073
		CommonTypeIITrunkingSystem_TrkSysFeaturesZone_A9717_2,
		// Token: 0x040013D2 RID: 5074
		CommonTypeIITrunkingSystem_TrkSysFeaturesHearClear_A36422_1 = 600200401,
		// Token: 0x040013D3 RID: 5075
		CommonTypeIITrunkingSystem_TrkSysFeaturesRadioInhibit_A8833_1 = 600200501,
		// Token: 0x040013D4 RID: 5076
		TrunkingSystemTalkgroupIsEmpty = 600200601,
		// Token: 0x040013D5 RID: 5077
		CommonTypeIIFixedNetworkEquipment_TrkSysGeneralSystemID_A9239_1 = 600300101,
		// Token: 0x040013D6 RID: 5078
		CommonTypeIIFixedNetworkEquipment_TrkSysGeneralTypeIIFrequencyBand_A12491_1,
		// Token: 0x040013D7 RID: 5079
		CommonTypeIIFixedNetworkEquipment_TrkSysGeneralTypeIIFrequencyBand_A12491_2,
		// Token: 0x040013D8 RID: 5080
		CommonTypeIIFixedNetworkEquipment_TrkSysGeneralTypeIIFrequencyBand_A12491_3,
		// Token: 0x040013D9 RID: 5081
		CommonTypeIIFixedNetworkEquipment_TrkSysGeneralTypeIIFrequencyBand_A12491_4,
		// Token: 0x040013DA RID: 5082
		CommonTypeIIFixedNetworkEquipment_TrkSysGeneralTypeIIFrequencyBand_A12491_5,
		// Token: 0x040013DB RID: 5083
		CommonTypeIIFixedNetworkEquipment_TrkSysGeneralTypeIIFrequencyBand_A12491_6,
		// Token: 0x040013DC RID: 5084
		CommonTypeIIFixedNetworkEquipment_TrkSysGeneralUnitID_A12651_1,
		// Token: 0x040013DD RID: 5085
		CommonTypeIIFixedNetworkEquipment_ChannelBandwidthkHz,
		// Token: 0x040013DE RID: 5086
		CommonTypeIIFixedNetworkEquipment_TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001_1 = 600300201,
		// Token: 0x040013DF RID: 5087
		CommonTypeIIFixedNetworkEquipment_TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001_2,
		// Token: 0x040013E0 RID: 5088
		CommonTypeIIFixedNetworkEquipment_TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003_1 = 600300301,
		// Token: 0x040013E1 RID: 5089
		CommonTypeIIFixedNetworkEquipment_TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003_2,
		// Token: 0x040013E2 RID: 5090
		CommonTypeIIFixedNetworkEquipment_TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900_1 = 600300401,
		// Token: 0x040013E3 RID: 5091
		CommonTypeIIFixedNetworkEquipment_TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900_2,
		// Token: 0x040013E4 RID: 5092
		CommonTypeIIFixedNetworkEquipment_TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902_1 = 600300501,
		// Token: 0x040013E5 RID: 5093
		CommonTypeIIFixedNetworkEquipment_TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902_2,
		// Token: 0x040013E6 RID: 5094
		CommonTypeIIFixedNetworkEquipment_TrkPerTalkgroupSecureClearStrapping_A9095_1 = 600300601,
		// Token: 0x040013E7 RID: 5095
		CommonTypeIITrkPreferredSite_TrkPerPreferredSitesSiteID_A9151_1 = 600400101,
		// Token: 0x040013E8 RID: 5096
		CommonTypeIITrkPreferredSite_TrkPerPreferredSitesSystemID_A19466_1 = 600400201,
		// Token: 0x040013E9 RID: 5097
		CommonTypeIITrkPreferredSite_TrkPerPreferredSitesWildcard_A43586_1 = 600400301,
		// Token: 0x040013EA RID: 5098
		CommonTypeIITrunkingPersonality_TrkPerGeneralSecondaryRxFrequencyMHz_A8904_1 = 600500101,
		// Token: 0x040013EB RID: 5099
		CommonTypeIITrunkingPersonality_TrkPerGeneralSecondaryRxFrequencyMHz_A8904_2,
		// Token: 0x040013EC RID: 5100
		CommonTypeIITrunkingPersonality_TrkPerGeneralSecondaryTxFrequencyMHz_A12902_1 = 600500201,
		// Token: 0x040013ED RID: 5101
		CommonTypeIITrunkingPersonality_TrkPerGeneralSecondaryTxFrequencyMHz_A12902_2,
		// Token: 0x040013EE RID: 5102
		CommonTypeIITrunkingPersonality_TrkPerGeneralTxFrequencyMHz_A9413_1 = 600500301,
		// Token: 0x040013EF RID: 5103
		CommonTypeIITrunkingPersonality_TrkPerGeneralTxFrequencyMHz_A9413_2,
		// Token: 0x040013F0 RID: 5104
		CommonTypeIITrunkingPersonality_TrkEmerProfGeneralTalkgroup_A8969_1 = 600500401,
		// Token: 0x040013F1 RID: 5105
		CommonTypeIITrunkingPersonality_TrkEmerProfGeneralSecureClearStrapping_A9092_1 = 600500501,
		// Token: 0x040013F2 RID: 5106
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertZone_A41916_1 = 600500601,
		// Token: 0x040013F3 RID: 5107
		CommonTypeIITrunkingPersonality_TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980_1 = 600500701,
		// Token: 0x040013F4 RID: 5108
		CommonTypeIITrunkingPersonality_TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980_2,
		// Token: 0x040013F5 RID: 5109
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_1 = 600500801,
		// Token: 0x040013F6 RID: 5110
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_2,
		// Token: 0x040013F7 RID: 5111
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_3,
		// Token: 0x040013F8 RID: 5112
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_4,
		// Token: 0x040013F9 RID: 5113
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_5,
		// Token: 0x040013FA RID: 5114
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_6,
		// Token: 0x040013FB RID: 5115
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_7,
		// Token: 0x040013FC RID: 5116
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_8,
		// Token: 0x040013FD RID: 5117
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_9,
		// Token: 0x040013FE RID: 5118
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_10,
		// Token: 0x040013FF RID: 5119
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_11,
		// Token: 0x04001400 RID: 5120
		CommonTypeIITrunkingPersonality_TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583_1 = 600500901,
		// Token: 0x04001401 RID: 5121
		CommonTypeIITrunkingPersonality_TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583_2,
		// Token: 0x04001402 RID: 5122
		CommonTypeIITrunkingPersonality_TrkPerGeneralRxFrequencyMHz_A8910_1 = 600501001,
		// Token: 0x04001403 RID: 5123
		CommonTypeIITrunkingPersonality_TrkPerGeneralRxFrequencyMHz_A8910_2,
		// Token: 0x04001404 RID: 5124
		CommonTypeIITrunkingPersonality_TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582_1 = 600501101,
		// Token: 0x04001405 RID: 5125
		CommonTypeIITrunkingPersonality_TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582_2,
		// Token: 0x04001406 RID: 5126
		CommonTypeIITrunkingPersonality_TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903_1 = 600501201,
		// Token: 0x04001407 RID: 5127
		CommonTypeIITrunkingPersonality_TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903_2,
		// Token: 0x04001408 RID: 5128
		CommonTypeIITrunkingPersonality_TrkPerCallPageCallAlertPageOperation_A7597_1 = 600501301,
		// Token: 0x04001409 RID: 5129
		CommonTypeIITrunkingPersonality_TrkPerCallPagePrivateCallOperation_A8759_1 = 600501401,
		// Token: 0x0400140A RID: 5130
		CommonTypeIITrunkingPersonality_TrkPerFeaturesScanListSelection_A9053_1 = 600501501,
		// Token: 0x0400140B RID: 5131
		CommonTypeIITrunkingPersonality_TrkPerFeaturesScanListSelection_A9053_2,
		// Token: 0x0400140C RID: 5132
		CommonTypeIITrunkingPersonality_TrkPerFeaturesStatusEnable_A9188_1 = 600501601,
		// Token: 0x0400140D RID: 5133
		CommonTypeIITrunkingPersonality_TrkPerAnnouncementGroupAnnouncementGroup_A7444_1 = 600501701,
		// Token: 0x0400140E RID: 5134
		CommonTypeIITrunkingPersonality_TrkPerAnnouncementGroupAnnouncementGroup_A7444_2,
		// Token: 0x0400140F RID: 5135
		CommonTypeIITrunkingPersonality_TrkPerTalkgroupTalkgroup_A9274_1 = 600501801,
		// Token: 0x04001410 RID: 5136
		CommonTypeIITrunkingPersonality_TrkPerTalkgroupTalkgroup_A9274_2,
		// Token: 0x04001411 RID: 5137
		CommonTypeIITrunkingPersonality_TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895_1 = 600501901,
		// Token: 0x04001412 RID: 5138
		CommonTypeIITrunkingPersonality_TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895_2,
		// Token: 0x04001413 RID: 5139
		CommonTypeIITrunkingPersonality_TrkPerGeneralTimeOutTimersec_A9379_1 = 600502001,
		// Token: 0x04001414 RID: 5140
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_1 = 600600101,
		// Token: 0x04001415 RID: 5141
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_2,
		// Token: 0x04001416 RID: 5142
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_3,
		// Token: 0x04001417 RID: 5143
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_4,
		// Token: 0x04001418 RID: 5144
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_5,
		// Token: 0x04001419 RID: 5145
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_6,
		// Token: 0x0400141A RID: 5146
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012_1 = 600600201,
		// Token: 0x0400141B RID: 5147
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012_2,
		// Token: 0x0400141C RID: 5148
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012_3,
		// Token: 0x0400141D RID: 5149
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029_1 = 600600301,
		// Token: 0x0400141E RID: 5150
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029_2,
		// Token: 0x0400141F RID: 5151
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568_1 = 600600401,
		// Token: 0x04001420 RID: 5152
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568_2,
		// Token: 0x04001421 RID: 5153
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListRxEnable_A9001_1 = 600600501,
		// Token: 0x04001422 RID: 5154
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListRxEnable_A9001_2,
		// Token: 0x04001423 RID: 5155
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListTxEnable_A9517_1 = 600600601,
		// Token: 0x04001424 RID: 5156
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListTxEnable_A9517_2,
		// Token: 0x04001425 RID: 5157
		CommonTypeIIFNEStatusAlias_TrkSysStatusAliasStatusAliasNumber_A9190_1 = 600800101,
		// Token: 0x04001426 RID: 5158
		CommonTypeIIFNEStatusAlias_TrkSysStatusAliasStatusAliasNumber_A9190_2,
		// Token: 0x04001427 RID: 5159
		CommonTypeIIFNEMessageAlias_TrkSysMessageAliasMessageAliasNumber_A8500_1 = 600900101,
		// Token: 0x04001428 RID: 5160
		CommonTypeIITrunkingTalkgroup_TrkPerTalkgroup_42163_1 = 601000101,
		// Token: 0x04001429 RID: 5161
		CommonTypeIITrunkingTalkgroup_TrkPerTalkgroupTxVoiceSignalType_A9575_1 = 601000201,
		// Token: 0x0400142A RID: 5162
		BLLCore_General = 700100000,
		// Token: 0x0400142B RID: 5163
		BLCoreElement_RecSet_MandantorySetIsZero = 700100100,
		// Token: 0x0400142C RID: 5164
		BLCoreElement_RecSet_TotalNumOutOfRangeBySharedSet,
		// Token: 0x0400142D RID: 5165
		BLCoreElement_RecSet_TotalNumOutOfRangeByEmWeakTypePool,
		// Token: 0x0400142E RID: 5166
		BLCoreElement_RecSet_TotalNumOutOfRangeByEmMaxpoolNum,
		// Token: 0x0400142F RID: 5167
		BLCoreElement_RecSet_TotalNumOutOfMaxLimitation,
		// Token: 0x04001430 RID: 5168
		BLCoreElement_RecSet_TotalNumOutOfMinLimitation,
		// Token: 0x04001431 RID: 5169
		BLLCoreElement_Record_InvalidType = 700100200,
		// Token: 0x04001432 RID: 5170
		BLLCoreElement_NumericField_ValueOutOfRange = 700100300,
		// Token: 0x04001433 RID: 5171
		BLLCoreElement_NumericField_ValueOutOfRange_Rollback,
		// Token: 0x04001434 RID: 5172
		BLLCoreElement_ListField_ValueOutOfRange = 700100400,
		// Token: 0x04001435 RID: 5173
		BLLCoreElement_ListField_ValueOutTiredOut,
		// Token: 0x04001436 RID: 5174
		BLLCoreElement_ListField_RangeSectionMissed,
		// Token: 0x04001437 RID: 5175
		BLLCoreElement_StringField_ValueOutOfRange = 700100500,
		// Token: 0x04001438 RID: 5176
		BLLCoreElement_StringField_KeyFieldValueIsNullOrEmpty,
		// Token: 0x04001439 RID: 5177
		BLLCoreElement_StringField_KeyFieldValueIsNullOrEmptyOrWhiteSpace_Rollback,
		// Token: 0x0400143A RID: 5178
		BLLCoreElement_StringField_SetNameDuplicate_Rollback,
		// Token: 0x0400143B RID: 5179
		BLLCoreElement_ReferField_ValueIsNull = 700100600,
		// Token: 0x0400143C RID: 5180
		BLLCoreElement_ReferField_AviReferSetIsNull,
		// Token: 0x0400143D RID: 5181
		BLLCoreElement_ReferField_CurSetTypeError,
		// Token: 0x0400143E RID: 5182
		BLLCoreElement_ReferField_ReferRecSetNotAvailable,
		// Token: 0x0400143F RID: 5183
		BLLCoreElement_ReferField_ReferRecordNotLoad,
		// Token: 0x04001440 RID: 5184
		BLLCoreElement_ReferField_ReferRecordNotInMasterSelectRecord,
		// Token: 0x04001441 RID: 5185
		BLLCoreElement_ReferField_ReferRecordNotAvailableFromMasterField,
		// Token: 0x04001442 RID: 5186
		BLLCoreElement_ReferField_ReferRecordTieredOut,
		// Token: 0x04001443 RID: 5187
		BLLCoreElement_ReferField_PrependValueOutTieredOut,
		// Token: 0x04001444 RID: 5188
		BLLCoreElement_Field_KeyFieldValueDuplicate = 700101000,
		// Token: 0x04001445 RID: 5189
		BLLCoreElement_Field_KeyFieldValueIsEmpty,
		// Token: 0x04001446 RID: 5190
		BLLCoreElement_Field_TiredOutField_ModelVersionSensitive = 700101100,
		// Token: 0x04001447 RID: 5191
		BLLCoreElement_Field_TiredOutField_ProductFamilyTiredOut,
		// Token: 0x04001448 RID: 5192
		SpellCheck_General = 700600000,
		// Token: 0x04001449 RID: 5193
		SpellCheck_Packing_Fixup_Error,
		// Token: 0x0400144A RID: 5194
		SpellCheck_Unpacking_Fixup_Error,
		// Token: 0x0400144B RID: 5195
		SpellCheck_Compile_Valition_Failed
	}
}
