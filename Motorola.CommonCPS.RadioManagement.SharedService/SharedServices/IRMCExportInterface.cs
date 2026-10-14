using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS;
using Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200008C RID: 140
	public interface IRMCExportInterface
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600085E RID: 2142
		// (remove) Token: 0x0600085F RID: 2143
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> ImportDeviceEvtHandler;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000860 RID: 2144
		// (remove) Token: 0x06000861 RID: 2145
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> ImportTemplateEvtHandler;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000862 RID: 2146
		// (remove) Token: 0x06000863 RID: 2147
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs> ExportDeviceEvtHandler;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000864 RID: 2148
		// (remove) Token: 0x06000865 RID: 2149
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.DeviceEventArgs> EditTemplateEvtHandler;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000866 RID: 2150
		// (remove) Token: 0x06000867 RID: 2151
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroCompatibilityEventArgs> AstroCompatibilityCheckEvtHandler;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000868 RID: 2152
		// (remove) Token: 0x06000869 RID: 2153
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROIndividualIdEditingEventArgs> ASTROIndividualIdEditingCheckEvtHandler;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600086A RID: 2154
		// (remove) Token: 0x0600086B RID: 2155
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroASKRequirementEventArgs> AstroASKRequirementEditingCheckEvtHandler;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600086C RID: 2156
		// (remove) Token: 0x0600086D RID: 2157
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs> AstroReadFlashKeyEvtHandler;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600086E RID: 2158
		// (remove) Token: 0x0600086F RID: 2159
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs> AnalysisPackageEvtHandler;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000870 RID: 2160
		// (remove) Token: 0x06000871 RID: 2161
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListLpPackageEventArgs> LanguagePackInfosEvtHandler;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000872 RID: 2162
		// (remove) Token: 0x06000873 RID: 2163
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListTTSLpPackageEventArgs> TTSLanguagePackInfosEvtHandler;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000874 RID: 2164
		// (remove) Token: 0x06000875 RID: 2165
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs> AstroLanguagePackCompatibleCheckEvtHandler;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000876 RID: 2166
		// (remove) Token: 0x06000877 RID: 2167
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrLanguagePackCompatibleCheckEventArgs> PcrLanguagePackCompatibleCheckHandler;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000878 RID: 2168
		// (remove) Token: 0x06000879 RID: 2169
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ModelTierEventArgs> ModelTierEvtHandler;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600087A RID: 2170
		// (remove) Token: 0x0600087B RID: 2171
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetVAInstallationPathEventArgs> GetVAInsallationPathEventHandler;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x0600087C RID: 2172
		// (remove) Token: 0x0600087D RID: 2173
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetTTSInstallationPathEventArgs> GetTTSInsallationPathEventHandler;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600087E RID: 2174
		// (remove) Token: 0x0600087F RID: 2175
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPINPasswordConvertEventArgs> AstroPINPasswordConvertEventHandler;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000880 RID: 2176
		// (remove) Token: 0x06000881 RID: 2177
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetPcrUserRegionArgs> GetPcrCpsUserRegionHandler;

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000882 RID: 2178
		// (remove) Token: 0x06000883 RID: 2179
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpdatePcrFwDescriptionArgs> UpdatePcrFwDescriptionHandler;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000884 RID: 2180
		// (remove) Token: 0x06000885 RID: 2181
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FirmwareUpgradeIncludeEqualEventArgs> FirmwareUpgradeIncludeEqualHandler;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000886 RID: 2182
		// (remove) Token: 0x06000887 RID: 2183
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsSameFWVersionUpgradeSupportedEventArgs> IsSameFWVersionUpgradeSupportedHandler;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000888 RID: 2184
		// (remove) Token: 0x06000889 RID: 2185
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS.QueryUpdateRadioEventArgs> QueryUpdateRadioEvtHandler;

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600088A RID: 2186
		// (remove) Token: 0x0600088B RID: 2187
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroEncodeFlashCodeEventArgs> AstroEncodeFlashCodeEvtHandler;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x0600088C RID: 2188
		// (remove) Token: 0x0600088D RID: 2189
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureCodeEventArgs> ParseFeatureCodeEvtHandler;

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x0600088E RID: 2190
		// (remove) Token: 0x0600088F RID: 2191
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureStatusEventArgs> ParseFeatureStatusEvtHandler;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000890 RID: 2192
		// (remove) Token: 0x06000891 RID: 2193
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FilterLicenseEventArgs> FilterLicenseEvtHandler;

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06000892 RID: 2194
		// (remove) Token: 0x06000893 RID: 2195
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PCRFilterLicenseEventArgs> PCRFilterLicenseEvtHandler;

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000894 RID: 2196
		// (remove) Token: 0x06000895 RID: 2197
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GenerateLicenseFilterEventArgs> GenerateLicenseFilterEvtHandler;

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06000896 RID: 2198
		// (remove) Token: 0x06000897 RID: 2199
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpgradeTemplateByFeaturesEventArgs> UpgradeTemplateByFeaturesEvtHandler;

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06000898 RID: 2200
		// (remove) Token: 0x06000899 RID: 2201
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ApplyRadioWithFeaturesEventArgs> ApplyRadioWithFeaturesEvtHandler;

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x0600089A RID: 2202
		// (remove) Token: 0x0600089B RID: 2203
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromCodeplugEventArgs> PopulateRadioFeaturesFromCodeplugEvtHandler;

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x0600089C RID: 2204
		// (remove) Token: 0x0600089D RID: 2205
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseRadioFeatureEventArgs> ParseRadioFeatureEvtHandler;

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x0600089E RID: 2206
		// (remove) Token: 0x0600089F RID: 2207
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroParseFlashCodeEventArgs> AstroParseFlashCodeEvtHandler;

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x060008A0 RID: 2208
		// (remove) Token: 0x060008A1 RID: 2209
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioCfsChangesInUpgradeEventArgs> RadioCfsChangesInUpgradeEvtHandler;

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x060008A2 RID: 2210
		// (remove) Token: 0x060008A3 RID: 2211
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsFreonEventArgs> IsFreonEvtHandler;

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x060008A4 RID: 2212
		// (remove) Token: 0x060008A5 RID: 2213
		event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> ParseAchiveEvtHandler;

		// Token: 0x060008A6 RID: 2214
		bool IsFreon(string modelNumber);

		// Token: 0x060008A7 RID: 2215
		void UpdateProgress(int curValue);

		// Token: 0x060008A8 RID: 2216
		global::Motorola.CommonCPS.Server.EntityModel.Template SaveCodeplugToServer(byte[] fileContent, global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Template templateObj);

		// Token: 0x060008A9 RID: 2217
		void ValidateASTROIndividualIdEditing(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem sysRawData, global::Motorola.CommonCPS.Server.EntityModel.Codeplug cp, string modelNumber, bool checkASKOnly = false);

		// Token: 0x060008AA RID: 2218
		string AstroPINPasswordConvert(string source, bool encrypt);

		// Token: 0x060008AB RID: 2219
		bool IsFirmwareUpgradeIncludeEqual(int productFamily, string ModelNumber, string CFS);

		// Token: 0x060008AC RID: 2220
		T[] XMLToEntityCollections<T>(string xmlData);

		// Token: 0x060008AD RID: 2221
		string EntityCollectionsToXML<T>(T[] obj);

		// Token: 0x060008AE RID: 2222
		byte[] AstroEncodeFlashCode(string flashCode);

		// Token: 0x060008AF RID: 2223
		string ParseFeatureCode(int featureCode, string modelNumber);

		// Token: 0x060008B0 RID: 2224
		global::System.Collections.Generic.Dictionary<int, string> AstroParseFlashCode(string flashCode, string modelNumber);

		// Token: 0x060008B1 RID: 2225
		string ParseFeatureStatus(global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus fs);

		// Token: 0x060008B2 RID: 2226
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> FilterLicenseList(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> originalLicenseList);

		// Token: 0x060008B3 RID: 2227
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> PopulateRadioFeaturesFromCodeplug(string serialNumber, global::Motorola.CommonCPS.Server.EntityModel.Template template, out int cfsModelType);

		// Token: 0x060008B4 RID: 2228
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrRadioEntitledLicenseSummary> PCRFilterLicenseList(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> licenseList);

		// Token: 0x060008B5 RID: 2229
		void HandleGlobalException(global::System.Exception ex);
	}
}
