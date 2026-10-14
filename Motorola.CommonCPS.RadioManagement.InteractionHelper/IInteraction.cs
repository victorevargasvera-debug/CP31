using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.InteractionHelper
{
	// Token: 0x02000004 RID: 4
	public interface IInteraction
	{
		// Token: 0x0600007E RID: 126
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> GetGroupCollection();

		// Token: 0x0600007F RID: 127
		bool Go(string moduleName);

		// Token: 0x06000080 RID: 128
		void ReportStatus(string status);

		// Token: 0x06000081 RID: 129
		void Redirect(string moduleName);

		// Token: 0x06000082 RID: 130
		void ShowModifyCodeplugPasswordDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext modifyCodeplugPasswordContext);

		// Token: 0x06000083 RID: 131
		void ShowResetRadioPasswordDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetRadioPasswordContext resetRadioPasswordContext);

		// Token: 0x06000084 RID: 132
		void ShowAddRadioDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.AddRadioContext addRadioContext);

		// Token: 0x06000085 RID: 133
		bool ShowConfirmationDialog(string content, string title);

		// Token: 0x06000086 RID: 134
		bool ShowDeleteJobsConfirmationDialog(int itemsToDelete);

		// Token: 0x06000087 RID: 135
		bool ShowDeleteKeysConfirmationDialog(int itemsToDelete);

		// Token: 0x06000088 RID: 136
		bool ShowDeletePackagesConfirmationDialog(int itemsToDelete);

		// Token: 0x06000089 RID: 137
		bool ShowDeleteRadiosConfirmationDialog(int itemsToDelete);

		// Token: 0x0600008A RID: 138
		bool ShowCompleteRadioJobConfirmationDialog();

		// Token: 0x0600008B RID: 139
		bool ShowDeleteTemplatesConfirmationDialog(int itemsToDelete);

		// Token: 0x0600008C RID: 140
		string ShowExportConfigurationDialog(string fileName);

		// Token: 0x0600008D RID: 141
		string ShowExportConfigurationSelectFolderDialog();

		// Token: 0x0600008E RID: 142
		void ShowImportLanguagePackDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext importLanguagePackContext);

		// Token: 0x0600008F RID: 143
		void ShowImportRadiosDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ImportRadiosContext importRadiosContext);

		// Token: 0x06000090 RID: 144
		void ShowImportTemplatesDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ImportTemplatesContext importTemplatesContext);

		// Token: 0x06000091 RID: 145
		void ShowLanguagePacksDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowLanguagePacksContext showLanguagePacksContext);

		// Token: 0x06000092 RID: 146
		void ShowVAPacksDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowVAPacksContext showVAPacksContext);

		// Token: 0x06000093 RID: 147
		void ShowTemplateLanguagePacksDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateLanguagePacksContext showTemplateLanguagePacksContext);

		// Token: 0x06000094 RID: 148
		void ShowTemplateVAPacksDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateVAPacksContext showTemplateVAPacksContext);

		// Token: 0x06000095 RID: 149
		void ShowMismatchOptionsDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowMismatchOptionsContext showMismatchOptionsContext);

		// Token: 0x06000096 RID: 150
		void ShowNotificationDialog(string content, string title);

		// Token: 0x06000097 RID: 151
		void ShowStartUpNotificationDialog(string content, string title);

		// Token: 0x06000098 RID: 152
		void ShowExceptionDialog(global::System.Exception exp);

		// Token: 0x06000099 RID: 153
		void ShowErrorMessageDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ErrorMessageContext errorMessageContext);

		// Token: 0x0600009A RID: 154
		string[] ShowOpenFileDialogForImportAstroFWs();

		// Token: 0x0600009B RID: 155
		string[] ShowFolderBrowserDialogForImportAstroFWs();

		// Token: 0x0600009C RID: 156
		string ShowOpenFileDialogForImportFromCSV(bool addAllFilesOptoin = false);

		// Token: 0x0600009D RID: 157
		string[] ShowOpenFileDialogForImportRadios();

		// Token: 0x0600009E RID: 158
		string[] ShowOpenFileDialogForImportConfiguration();

		// Token: 0x0600009F RID: 159
		string[] ShowOpenFileDialogForImportTemplates();

		// Token: 0x060000A0 RID: 160
		string[] ShowOpenFileDialogForImportVAFiles(string initialPath);

		// Token: 0x060000A1 RID: 161
		string[] ShowOpenFileDialogForImportCACertificateFiles(string initialPath);

		// Token: 0x060000A2 RID: 162
		string[] ShowOpenFileDialogForImportDVRSFiles(string initialPath);

		// Token: 0x060000A3 RID: 163
		string[] ShowOpenFileDialogForImportTTSFiles(string initialPath);

		// Token: 0x060000A4 RID: 164
		string[] ShowOpenFileDialogForImportGeneralPackageFiles();

		// Token: 0x060000A5 RID: 165
		void ShowProgressDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext progressContext);

		// Token: 0x060000A6 RID: 166
		void ShowSTAProgressWindow(global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext progressContext);

		// Token: 0x060000A7 RID: 167
		bool ShowRetryDialog(string content, string title);

		// Token: 0x060000A8 RID: 168
		string ShowSaveFileDialogForExportRadio(string fileName);

		// Token: 0x060000A9 RID: 169
		string ShowSaveFileDialogForGridToFile(string fileName);

		// Token: 0x060000AA RID: 170
		string ShowSaveFileDialogForExportToMNISXML(string fileName, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily);

		// Token: 0x060000AB RID: 171
		string ShowSaveFileDialogForExportDVRS(string fileName);

		// Token: 0x060000AC RID: 172
		string ShowOpenFileDialogForLicense();

		// Token: 0x060000AD RID: 173
		void ShowScheduleJobDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext scheduleJobContext);

		// Token: 0x060000AE RID: 174
		bool ShowSelectWarningRadiostoScheduleJobDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext selectWarningRadiostoScheduleJobContext);

		// Token: 0x060000AF RID: 175
		void ShowSelectRadiosDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRadiosContext selectRadiosContext);

		// Token: 0x060000B0 RID: 176
		string[] ShowOpenFileDialog(string filter, string title, bool multiSelect);

		// Token: 0x060000B1 RID: 177
		string[] ShowOpenFileDialogForLTE(string filter, string title, bool multiSelect);

		// Token: 0x060000B2 RID: 178
		string ShowSaveFileDialogForExportWhiteList(string fileName);

		// Token: 0x060000B3 RID: 179
		string ShowSaveFileDialogForExportSiSeries(string fileName);

		// Token: 0x060000B4 RID: 180
		string ShowSaveFileDialogForExportSimpleTouch(string fileName);

		// Token: 0x060000B5 RID: 181
		string ShowSaveFileDialogForExportAPNList(string fileName);

		// Token: 0x060000B6 RID: 182
		void ShowSelectTemplateDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext selectTemplateContext);

		// Token: 0x060000B7 RID: 183
		bool ShowWiFiPasswordValidationDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext wiFiPasswordValidationContext);

		// Token: 0x060000B8 RID: 184
		bool ShowSettingsDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext settingsContext);

		// Token: 0x060000B9 RID: 185
		bool ShowDBMigrationDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext migrationContext);

		// Token: 0x060000BA RID: 186
		bool ShowClearDataDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext context);

		// Token: 0x060000BB RID: 187
		void LoginUserDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext userLoginContext);

		// Token: 0x060000BC RID: 188
		void ChangePasswordDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ChangePasswordContext changePasswordContext);

		// Token: 0x060000BD RID: 189
		void OAuthLoginDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginContext oauthLoginContext);

		// Token: 0x060000BE RID: 190
		void ShowSelectAgencyDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext context);

		// Token: 0x060000BF RID: 191
		bool ShowTemplateRadioConversionConfirmationDialog();

		// Token: 0x060000C0 RID: 192
		void ShowTestDlg(global::Motorola.CommonCPS.RadioManagement.UIModels.TestDlgContext testDlgContext);

		// Token: 0x060000C1 RID: 193
		global::Motorola.CommonCPS.RadioManagement.UIModels.SaveTemplateAsContext ShowSaveTemplateAsDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.SaveTemplateAsContext saveTemplateAsContext);

		// Token: 0x060000C2 RID: 194
		string GetCurrentViewId();

		// Token: 0x060000C3 RID: 195
		global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo GetDataGridInfoForRadios();

		// Token: 0x060000C4 RID: 196
		global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo GetDataGridInfoForAstroSystem();

		// Token: 0x060000C5 RID: 197
		global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo GetDataGridInfoForDataProfile();

		// Token: 0x060000C6 RID: 198
		global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo GetDataGridInfoForOtarProfile();

		// Token: 0x060000C7 RID: 199
		void ShowProgressWindow(global::Motorola.CommonCPS.RadioManagement.UIModels.DockPanelNames dockPanelNames);

		// Token: 0x060000C8 RID: 200
		void ShowNewAstroRadioDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroRadio);

		// Token: 0x060000C9 RID: 201
		void ShowCompatibleTemplates(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext compatibleTemplate);

		// Token: 0x060000CA RID: 202
		void ShowRegisterApplicationLicenseDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext registerApplicationLicenseContext);

		// Token: 0x060000CB RID: 203
		void ShowRegisterRadioLicenseDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext);

		// Token: 0x060000CC RID: 204
		void ShowResetIdentifiersDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext resetIdentifiersContext);

		// Token: 0x060000CD RID: 205
		void ShowSelectFirmwareDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext selectFirmwareContext);

		// Token: 0x060000CE RID: 206
		void ShowUpdateRadio(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext updateRadioContext);

		// Token: 0x060000CF RID: 207
		void ShowSelectRunningRadiosDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRunningRadiosContext selectRunningRadiosContext);

		// Token: 0x060000D0 RID: 208
		void ShowApplyTemplatetoRelatedRadiosDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext applyTemplatetoRelatedRadiosContext);

		// Token: 0x060000D1 RID: 209
		void ShowMoveDeviceDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.MoveDeviceContext moveDeviceContext);

		// Token: 0x060000D2 RID: 210
		void ShowWaitingIndicator();

		// Token: 0x060000D3 RID: 211
		void HideWaitingIndicator();

		// Token: 0x060000D4 RID: 212
		void ShowSelectGeneralPackageDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectGeneralPackageContext context);

		// Token: 0x060000D5 RID: 213
		void ShowTemplateRadiosDetectedDialog();

		// Token: 0x060000D6 RID: 214
		bool ShowSelectASKDialogForCFS(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext selectASKForCFSContext);

		// Token: 0x060000D7 RID: 215
		void NotifyPrintView(global::Motorola.CommonCPS.RadioManagement.UIModels.PrintViewContext context);

		// Token: 0x060000D8 RID: 216
		void NotifyPrintViewPreview(global::Motorola.CommonCPS.RadioManagement.UIModels.PrintViewContext context);

		// Token: 0x060000D9 RID: 217
		void ShowSelectCodeplugversionDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectCodeplugVersionContext context);

		// Token: 0x060000DA RID: 218
		void ShowAboutDialog();

		// Token: 0x060000DB RID: 219
		void NotifyOutputPaneItemChanged(global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.DockPanelNames, int> parameter);

		// Token: 0x060000DC RID: 220
		void NotifyOutputPaneBackgroundWork(global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.DockPanelNames, global::Motorola.CommonCPS.RadioManagement.UIModels.OutputPaneBackgroundWorkStatus> parameter);

		// Token: 0x060000DD RID: 221
		void NotifyPopupPaneNewItemAdded(global::Motorola.CommonCPS.RadioManagement.UIModels.DockPanelNames dockPanelName);

		// Token: 0x060000DE RID: 222
		void ShowRadioConversionDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioConversionContext context);

		// Token: 0x060000DF RID: 223
		void ShowTemplateConversionDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateConversionContext context);

		// Token: 0x060000E0 RID: 224
		string ShowOpenFileDialogueForMcGeofenceMapFile();

		// Token: 0x060000E1 RID: 225
		string ShowSaveFileDialogueForMcGeofenceMapFile();

		// Token: 0x060000E2 RID: 226
		void ShowImportFromConsoleResult(string message);

		// Token: 0x060000E3 RID: 227
		void ShowCopyPasteWarningViewDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteWarningContext copyPasteWarningContext);

		// Token: 0x060000E4 RID: 228
		void DatabaseSpaceWarning(global::Motorola.CommonCPS.Server.CommonDBConstants.DatabaseSpaceLevel databaseSpaceWarning);

		// Token: 0x060000E5 RID: 229
		void ShowUpdateLogSettingRequestedEvent(global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting logSetting);
	}
}
