using System;
using System.Collections.Generic;
using System.IO;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Rcmp;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x0200000F RID: 15
	public interface IRadioCommand
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000D2 RID: 210
		// (set) Token: 0x060000D3 RID: 211
		int MaxDataTransferSize { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000D4 RID: 212
		bool IsCommonFileCrcBigEndian { get; }

		// Token: 0x060000D5 RID: 213
		byte[] QueryRadioSerialNumber();

		// Token: 0x060000D6 RID: 214
		byte[] QueryProductSerialNumber();

		// Token: 0x060000D7 RID: 215
		byte[] QueryRemoteSerialNumber();

		// Token: 0x060000D8 RID: 216
		string QueryRadioModelNumber();

		// Token: 0x060000D9 RID: 217
		byte[] QueryRadioUUID();

		// Token: 0x060000DA RID: 218
		byte[] QueryRadioPhysicalSerialNumber();

		// Token: 0x060000DB RID: 219
		byte QueryRadioSMADate();

		// Token: 0x060000DC RID: 220
		byte QueryRadioWarrantyDate();

		// Token: 0x060000DD RID: 221
		byte QueryRadioUpdateStatus();

		// Token: 0x060000DE RID: 222
		uint QueryRadioAvailableMemory();

		// Token: 0x060000DF RID: 223
		bool IsLowBattery();

		// Token: 0x060000E0 RID: 224
		bool IsDualBoard();

		// Token: 0x060000E1 RID: 225
		bool Is32MPlatform();

		// Token: 0x060000E2 RID: 226
		byte QueryRadioRegion();

		// Token: 0x060000E3 RID: 227
		byte QueryRadioRegionByIsh(byte partition, ushort type, ushort id, ushort offset);

		// Token: 0x060000E4 RID: 228
		bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID);

		// Token: 0x060000E5 RID: 229
		string QuerySoftwareVersion();

		// Token: 0x060000E6 RID: 230
		string QueryPsdtVersion();

		// Token: 0x060000E7 RID: 231
		string QueryBootloaderVersion();

		// Token: 0x060000E8 RID: 232
		string QueryL3BootloaderVersion();

		// Token: 0x060000E9 RID: 233
		string QueryConfigurationVersion();

		// Token: 0x060000EA RID: 234
		string QueryKernelVersion();

		// Token: 0x060000EB RID: 235
		string QuerySecurityVersion();

		// Token: 0x060000EC RID: 236
		string QueryRepeaterMacAddress();

		// Token: 0x060000ED RID: 237
		string GetWLANMacAddress(global::Motorola.Common.Communication.Rcmp.MacAddressPort port);

		// Token: 0x060000EE RID: 238
		string GetMacAddressByPort(global::Motorola.Common.Communication.Rcmp.MacAddressPort port);

		// Token: 0x060000EF RID: 239
		bool IsDspCapabilityEnabled();

		// Token: 0x060000F0 RID: 240
		bool IsDTPCapabilityEnabled();

		// Token: 0x060000F1 RID: 241
		global::Motorola.Common.Communication.CommonUtil.PasswordStatus QueryPasswordStatus();

		// Token: 0x060000F2 RID: 242
		bool IsWirelineAvailable();

		// Token: 0x060000F3 RID: 243
		global::Motorola.Common.Communication.CommonUtil.FPGAStatus QueryFPGAControllerStatus();

		// Token: 0x060000F4 RID: 244
		global::Motorola.Common.Communication.CommonUtil.FPGAStatus QueryFPGAWirelineStatus();

		// Token: 0x060000F5 RID: 245
		string QueryFPGAControllerAlternativeVersion();

		// Token: 0x060000F6 RID: 246
		string QueryFPGAControllerFactoryVersion();

		// Token: 0x060000F7 RID: 247
		string QueryFPGAControllerActiveVersion();

		// Token: 0x060000F8 RID: 248
		string QueryFPGAWirelineAlternativeVersion();

		// Token: 0x060000F9 RID: 249
		string QueryFPGAWirelineFactoryVersion();

		// Token: 0x060000FA RID: 250
		string QueryFPGAWirelineActiveVersion();

		// Token: 0x060000FB RID: 251
		void SendFPGAReset(global::Motorola.Common.Communication.Rcmp.FpgaOperationID fpgaID);

		// Token: 0x060000FC RID: 252
		void SendFPGAErase(global::Motorola.Common.Communication.Rcmp.FpgaOperationID fpgaID);

		// Token: 0x060000FD RID: 253
		void EnterProgramMode(byte entry, byte[] data = null);

		// Token: 0x060000FE RID: 254
		void ResetRadio();

		// Token: 0x060000FF RID: 255
		void EnterBootMode();

		// Token: 0x06000100 RID: 256
		void RadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction action);

		// Token: 0x06000101 RID: 257
		void UpdateMACAddress(byte[] macAddress);

		// Token: 0x06000102 RID: 258
		void UnlockISHPartition(byte partition);

		// Token: 0x06000103 RID: 259
		global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password);

		// Token: 0x06000104 RID: 260
		void BundleQueryInfo(global::System.Collections.Generic.ICollection<global::Motorola.Common.Communication.RcmpBaseMessage> rcmpMessages);

		// Token: 0x06000105 RID: 261
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> ListDirectoryContents(ushort PartitionID, string directoryPath);

		// Token: 0x06000106 RID: 262
		long GetFileOrDirSize(ushort PartitionID, string fileOrDirectoryPath);

		// Token: 0x06000107 RID: 263
		global::System.IO.MemoryStream FileRead(ushort filePartition, string filePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null);

		// Token: 0x06000108 RID: 264
		void FileWrite(ushort FilePartition, string FileName, global::System.IO.Stream File, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null, bool isFileCompressed = false);

		// Token: 0x06000109 RID: 265
		void DeleteFilesOrDirectory(ushort PartitionID, global::System.Collections.Generic.List<string> filePaths);

		// Token: 0x0600010A RID: 266
		void NandWrite(ushort Partition_ID, global::System.IO.MemoryStream Data, uint OptionFlag, uint Start_ID, uint End_ID, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null);

		// Token: 0x0600010B RID: 267
		void FtlWrite(ushort Partition_ID, global::System.IO.MemoryStream Data, uint OptionFlag, uint Start_ID, uint End_ID, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null);

		// Token: 0x0600010C RID: 268
		uint GetAvailabeSpaceForLanguagePack();

		// Token: 0x0600010D RID: 269
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> ReadLanguagePackInfo();

		// Token: 0x0600010E RID: 270
		global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePackData();

		// Token: 0x0600010F RID: 271
		void DeleteLanguagePack(string languagePackID, bool bigEndianForPackID);

		// Token: 0x06000110 RID: 272
		void WriteLanguagePack(global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo languagePack, int maxXcmpPacketSize, bool bigEndianForPackID, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x06000111 RID: 273
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> ReadTTSLanguagePackInfo();

		// Token: 0x06000112 RID: 274
		global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePackData();

		// Token: 0x06000113 RID: 275
		void DeleteTTSLanguagePack(string languagePackID, bool bigEndianForPackID);

		// Token: 0x06000114 RID: 276
		void WriteTTSLanguagePack(global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo languagePack, int maxXcmpPacketSize, bool bigEndianForPackID, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x06000115 RID: 277
		void ComponentSession(ushort actions, ushort sessionID, out ushort performedActions, out ushort currentSessionId);

		// Token: 0x06000116 RID: 278
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery> TypeLevelChangeDiscoveryOfTypes(global::System.Collections.Generic.IEnumerable<ushort> ishTypes, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x06000117 RID: 279
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery> TypeLevelChangeDiscoveryInPartitions(global::System.Collections.Generic.IEnumerable<ushort> ishPartitions, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x06000118 RID: 280
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery> ItemLevelChangeDiscovery(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Rcmp.XcmpComponentTypeIdPair> typeIdPairs, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x06000119 RID: 281
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery> ItemLevelChangeDiscoveryInPartitions(global::System.Collections.Generic.IEnumerable<ushort> ishPartitions, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x0600011A RID: 282
		global::Motorola.Common.Communication.Pba.PbaObject ReadCodeplugItemsInPartitions(global::System.Collections.Generic.IEnumerable<ushort> partitions, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x0600011B RID: 283
		global::Motorola.Common.Communication.Pba.PbaObject ReadCodeplugItemsByTypes(global::System.Collections.Generic.IEnumerable<ushort> ishTypes, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x0600011C RID: 284
		global::Motorola.Common.Communication.Pba.PbaObject ReadCodeplugItems(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Rcmp.XcmpComponentTypeIdPair> items, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x0600011D RID: 285
		global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadItemsByIshHeaders(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaders, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null);

		// Token: 0x0600011E RID: 286
		global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadDifferetialCodeplugInPartitions(global::System.Collections.Generic.IEnumerable<ushort> partitions, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x0600011F RID: 287
		global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadDifferetialCodeplugByIshTypes(global::System.Collections.Generic.IEnumerable<ushort> ishTypes, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);

		// Token: 0x06000120 RID: 288
		bool StartOtapSession(ushort currentSessionID, ushort previousSessionID, bool isRead);

		// Token: 0x06000121 RID: 289
		void CommitOtapSession(ushort currentSessionID);

		// Token: 0x06000122 RID: 290
		void CommitWiFiSession(ushort currentSessionID);

		// Token: 0x06000123 RID: 291
		void CloseOtapSession(ushort currentSessionID, bool isNomal);

		// Token: 0x06000124 RID: 292
		void CreateArchiveSession(ushort currentSessionID);
	}
}
