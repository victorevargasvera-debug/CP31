using System;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000018 RID: 24
	public interface ICommandHandler
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060000E4 RID: 228
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation AddGroupCommand { get; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060000E5 RID: 229
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation DeleteGroupCommand { get; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060000E6 RID: 230
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareMoveDeviceBatchCommand { get; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060000E7 RID: 231
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RenameGroupCommand { get; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060000E8 RID: 232
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation MoveDeviceCommand { get; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060000E9 RID: 233
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation MoveDeviceBatchCommand { get; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060000EA RID: 234
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RefreshGroupCommand { get; }

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060000EB RID: 235
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation UpdateGroupCommand { get; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060000EC RID: 236
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation AddRadioCommand { get; }

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060000ED RID: 237
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation EditCodeplugCommand { get; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060000EE RID: 238
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareScheduleJobCommand { get; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060000EF RID: 239
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ScheduleJobCommand { get; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060000F0 RID: 240
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SelectWarningRadiostoScheduleJobCommand { get; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060000F1 RID: 241
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowLanguageDetailInfoCommand { get; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060000F2 RID: 242
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowVADetailInfoCommand { get; }

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060000F3 RID: 243
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation CancelJobCommand { get; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060000F4 RID: 244
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation CompleteJobCommand { get; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060000F5 RID: 245
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareAddRadioCommand { get; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060000F6 RID: 246
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareModifyCodeplugPasswordCommand { get; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060000F7 RID: 247
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ModifyCodeplugPasswordCommand { get; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060000F8 RID: 248
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareResetRadioPasswordCommand { get; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060000F9 RID: 249
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ResetRadioPasswordCommand { get; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060000FA RID: 250
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareSelectTemplateCommand { get; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060000FB RID: 251
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation UpgradeLanguageInRadioCommand { get; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060000FC RID: 252
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SelectTemplateCommand { get; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060000FD RID: 253
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareImportRadiosCommand { get; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060000FE RID: 254
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ImportRadiosCommand { get; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060000FF RID: 255
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation DeleteRadiosCommand { get; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000100 RID: 256
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ExportRadioCommand { get; }

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000101 RID: 257
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveRadioCommand { get; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000102 RID: 258
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation AstroPrepareFlashPortCommand { get; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000103 RID: 259
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareUpgradeFirmwareCommand { get; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000104 RID: 260
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareSelectGeneralPackagesCommand { get; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000105 RID: 261
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SelectGeneralPackagesCommand { get; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000106 RID: 262
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SelectFirmwareForUpgradeCommand { get; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000107 RID: 263
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RecoverFirmwareCommand { get; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000108 RID: 264
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareResetIndentifiersCommand { get; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000109 RID: 265
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ResetIndentifiersCommand { get; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600010A RID: 266
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation DiscardCodeplugCommand { get; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600010B RID: 267
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ExportDVRS_Command { get; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600010C RID: 268
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ASTROQueryUpdateRadioCommand { get; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600010D RID: 269
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ASTROPrepareQueryUpdateRadioCommand { get; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600010E RID: 270
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SelectCodeplugVersionCommand { get; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600010F RID: 271
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareSelectCodeplugVersionCommand { get; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000110 RID: 272
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation WiFiPasswordValidationCommand { get; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000111 RID: 273
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareWiFiPasswordValidationCommand { get; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000112 RID: 274
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowRadioDetailsCommand { get; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000113 RID: 275
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ExportGridToFileCommand { get; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000114 RID: 276
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ImportFileToRadioGridCommand { get; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000115 RID: 277
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation CopyRadioIdentityCommand { get; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000116 RID: 278
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PasteRadioIdentityCommand { get; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000117 RID: 279
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SubmitPasteValueCommand { get; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000118 RID: 280
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RestoreCommand { get; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000119 RID: 281
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation CancelSaveTemplateAsCommand { get; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600011A RID: 282
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation DeleteTemplatesCommand { get; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600011B RID: 283
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation EditTemplateCommand { get; }

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600011C RID: 284
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareImportTemplatesCommand { get; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600011D RID: 285
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SelectLanguagePackCommand { get; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600011E RID: 286
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ImportTemplatesCommand { get; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600011F RID: 287
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveTemplateCommand { get; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000120 RID: 288
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveTemplateAsCommand { get; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000121 RID: 289
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveTemplateCommandFromCPS { get; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000122 RID: 290
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ApplyTemplatetoRelatedRadiosCommand { get; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000123 RID: 291
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ASTROUpgradeLanguagePackCommand { get; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000124 RID: 292
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowTemplateLanguageDetailInfoCommand { get; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000125 RID: 293
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowTemplateVADetailInfoCommand { get; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000126 RID: 294
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareImportPackagesCommand { get; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000127 RID: 295
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation DeletePackagesCommand { get; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000128 RID: 296
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ImportLanguagePackCommand { get; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000129 RID: 297
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SavePackageCommand { get; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600012A RID: 298
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareRegisterRadioLicense { get; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600012B RID: 299
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation AddSelectedDevices { get; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600012C RID: 300
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RemoveSelectedDevices { get; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600012D RID: 301
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ClearAllEIDHistory { get; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600012E RID: 302
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation QueryEIDCommand { get; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600012F RID: 303
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation FilterAvailableDevicesCommand { get; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000130 RID: 304
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RecoverApplicationLicensesCommand { get; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000131 RID: 305
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RecoverRadioLicensesCommand { get; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000132 RID: 306
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RegisterRadioLicenseCommand { get; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000133 RID: 307
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RegistRadioFeatureGroupChangeCommand { get; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000134 RID: 308
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RestoreRadioLicenseCommand { get; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000135 RID: 309
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareRegisterApplicationLicenseCommand { get; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000136 RID: 310
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RegisterApplicationLicenseCommand { get; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000137 RID: 311
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation GetHostIDCommand { get; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000138 RID: 312
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ChooseLicenseFileCommand { get; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000139 RID: 313
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation QueryApplicationLicenseEIDCommand { get; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600013A RID: 314
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveApplicationLicenseCommand { get; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600013B RID: 315
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SelectASKForCFSCommand { get; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600013C RID: 316
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveRadioLicenseCommand { get; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600013D RID: 317
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveASTRODataProfileCommand { get; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600013E RID: 318
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ExportDataProfileGridToFileCommand { get; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600013F RID: 319
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveASTROOTARProfileCommand { get; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000140 RID: 320
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ExportOtarProfileGridToFileCommand { get; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000141 RID: 321
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveASTROSystemCommand { get; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000142 RID: 322
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ExportASTROSystemGridToFileCommand { get; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000143 RID: 323
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation DeleteJobContainerCommand { get; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000144 RID: 324
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ViewProgressesCommand { get; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000145 RID: 325
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ClearBatchOpCommand { get; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000146 RID: 326
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation CancelBatchOpCommand { get; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000147 RID: 327
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation GetBatchOpCommand { get; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000148 RID: 328
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation CancelDBMigrationBacthOpCommand { get; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000149 RID: 329
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation CancelRunningJobsCommand { get; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600014A RID: 330
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveSettingsCommand { get; }

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600014B RID: 331
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveDealerInfoCommand { get; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600014C RID: 332
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ChangeRMUserPasswordCommand { get; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600014D RID: 333
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveSettingsForImportFromConsoleCommand { get; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600014E RID: 334
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowSettingsDialogCommand { get; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600014F RID: 335
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowRadioConversionDialogCommand { get; }

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000150 RID: 336
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowTemplateConversionDialogCommand { get; }

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000151 RID: 337
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowSettingsDialogForImportFromConsoleCommand { get; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000152 RID: 338
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ChangeRMAppLanguageCommand { get; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000153 RID: 339
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ChangeRMAppButtonBarModeCommand { get; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000154 RID: 340
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation GetDatabaseSizeSummaryCommand { get; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000155 RID: 341
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveHiddenMessageCommand { get; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000156 RID: 342
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation UpdateLogSettingCommand { get; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000157 RID: 343
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrintPreviewCommand { get; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000158 RID: 344
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrintViewCommand { get; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000159 RID: 345
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation StopLoadingCommand { get; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600015A RID: 346
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation FilterCommand { get; }

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600015B RID: 347
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowAboutDialogCommand { get; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600015C RID: 348
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation MigrateRadioAndCommonResourceCommand { get; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600015D RID: 349
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation QueryMigrationStatusCommand { get; }

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600015E RID: 350
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation MigrateTemplateCommand { get; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600015F RID: 351
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ConvertRadioInBatchCommand { get; }

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000160 RID: 352
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ChangeShowDialogCommand { get; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000161 RID: 353
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowUpdateLogSettingWindowCommand { get; }

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000162 RID: 354
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SelectAgencyCommand { get; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000163 RID: 355
		global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation UploadCodeplugCommand { get; }
	}
}
