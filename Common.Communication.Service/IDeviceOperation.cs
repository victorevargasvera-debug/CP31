using System;
using System.Collections;
using System.Collections.Generic;
using System.ServiceModel;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x02000008 RID: 8
	[global::System.ServiceModel.ServiceContract(CallbackContract = typeof(global::Motorola.Common.Communication.Service.IOperationServiceEvent), SessionMode = global::System.ServiceModel.SessionMode.Required)]
	public interface IDeviceOperation
	{
		// Token: 0x0600013D RID: 317
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		bool CancelOperation(string operationId);

		// Token: 0x0600013E RID: 318
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginOpenSession(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter, string operationId, global::System.AsyncCallback callback, object state, bool isRecconectRequired = false);

		// Token: 0x0600013F RID: 319
		ushort EndOpenSession(global::System.IAsyncResult asyncResult);

		// Token: 0x06000140 RID: 320
		ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter = null, bool isRecconectRequired = false);

		// Token: 0x06000141 RID: 321
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginCloseSession(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, bool pendingDeploy, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000142 RID: 322
		void EndCloseSession(global::System.IAsyncResult asyncResult);

		// Token: 0x06000143 RID: 323
		void CloseSession(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, bool pendingDeploy);

		// Token: 0x06000144 RID: 324
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginReadDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000145 RID: 325
		global::Motorola.Common.Communication.CommonUtil.DeviceInfo EndReadDeviceInfo(global::System.IAsyncResult asyncResult);

		// Token: 0x06000146 RID: 326
		global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x06000147 RID: 327
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginQueryRadioUpdateStatus(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000148 RID: 328
		byte EndQueryRadioUpdateStatus(global::System.IAsyncResult asyncResult);

		// Token: 0x06000149 RID: 329
		byte QueryRadioUpdateStatus(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x0600014A RID: 330
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginReadExtendedDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600014B RID: 331
		global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo EndReadExtendedDeviceInfo(global::System.IAsyncResult asyncResult);

		// Token: 0x0600014C RID: 332
		global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x0600014D RID: 333
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginReadDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject referencePba, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600014E RID: 334
		global::Motorola.Common.Communication.Pba.PbaObject EndReadDevice(global::System.IAsyncResult asyncResult);

		// Token: 0x0600014F RID: 335
		global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject referencePba);

		// Token: 0x06000150 RID: 336
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.ServiceKnownType(typeof(global::Motorola.Common.Communication.CommonUtil.IshHeader))]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginReadBlocks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.ICollection blockList, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000151 RID: 337
		global::Motorola.Common.Communication.Pba.PbaObject EndReadBlocks(global::System.IAsyncResult asyncResult);

		// Token: 0x06000152 RID: 338
		global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.ICollection blockList);

		// Token: 0x06000153 RID: 339
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginWriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state, int? userDefersAllowed = null);

		// Token: 0x06000154 RID: 340
		global::Motorola.Common.Communication.Pba.PbaObject EndWriteDevice(global::System.IAsyncResult asyncResult);

		// Token: 0x06000155 RID: 341
		global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, int? userDefersAllowed = null);

		// Token: 0x06000156 RID: 342
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginTurnOffRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000157 RID: 343
		bool EndTurnOffRadio(global::System.IAsyncResult asyncResult);

		// Token: 0x06000158 RID: 344
		bool TurnOffRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x06000159 RID: 345
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginLLPIsAvailable(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600015A RID: 346
		bool EndLLPIsAvailable(global::System.IAsyncResult asyncResult);

		// Token: 0x0600015B RID: 347
		bool LLPIsAvailable(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x0600015C RID: 348
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginSwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.DeviceMode mode, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600015D RID: 349
		void EndSwitchRadioMode(global::System.IAsyncResult asyncResult);

		// Token: 0x0600015E RID: 350
		void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.DeviceMode mode);

		// Token: 0x0600015F RID: 351
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginUpdateRadioDisplay(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000160 RID: 352
		void EndUpdateRadioDisplay(global::System.IAsyncResult asyncResult);

		// Token: 0x06000161 RID: 353
		void UpdateRadioDisplay(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x06000162 RID: 354
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginWriteSoftware(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000163 RID: 355
		void EndWriteSoftware(global::System.IAsyncResult asyncResult);

		// Token: 0x06000164 RID: 356
		void WriteSoftware(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject);

		// Token: 0x06000165 RID: 357
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginReadLanguagePacksInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000166 RID: 358
		global::Motorola.Common.Communication.Pba.LanguagePackData EndReadLanguagePacksInfo(global::System.IAsyncResult asyncResult);

		// Token: 0x06000167 RID: 359
		global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x06000168 RID: 360
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginWriteLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000169 RID: 361
		void EndWriteLanguagePacks(global::System.IAsyncResult asyncResult);

		// Token: 0x0600016A RID: 362
		void WriteLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData);

		// Token: 0x0600016B RID: 363
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginDeleteLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600016C RID: 364
		void EndDeleteLanguagePacks(global::System.IAsyncResult asyncResult);

		// Token: 0x0600016D RID: 365
		void DeleteLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData);

		// Token: 0x0600016E RID: 366
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginReadTTSLanguagePacksInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600016F RID: 367
		global::Motorola.Common.Communication.Pba.LanguagePackData EndReadTTSLanguagePacksInfo(global::System.IAsyncResult asyncResult);

		// Token: 0x06000170 RID: 368
		global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePacksInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x06000171 RID: 369
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginWriteTTSLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000172 RID: 370
		void EndWriteTTSLanguagePacks(global::System.IAsyncResult asyncResult);

		// Token: 0x06000173 RID: 371
		void WriteTTSLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData);

		// Token: 0x06000174 RID: 372
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginDeleteTTSLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000175 RID: 373
		void EndDeleteTTSLanguagePacks(global::System.IAsyncResult asyncResult);

		// Token: 0x06000176 RID: 374
		void DeleteTTSLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData);

		// Token: 0x06000177 RID: 375
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginReadRadioFirmwareDefinedFlashPacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000178 RID: 376
		global::Motorola.Common.Communication.Pba.LanguagePackData EndReadRadioFirmwareDefinedFlashPacks(global::System.IAsyncResult asyncResult);

		// Token: 0x06000179 RID: 377
		global::Motorola.Common.Communication.Pba.LanguagePackData ReadRadioFirmwareDefinedFlashPacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x0600017A RID: 378
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginReadFilesListInDir(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem dir, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600017B RID: 379
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> EndReadFilesListInDir(global::System.IAsyncResult asyncResult);

		// Token: 0x0600017C RID: 380
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> ReadFilesListInDir(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem dir);

		// Token: 0x0600017D RID: 381
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginReadFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600017E RID: 382
		global::Motorola.Common.Communication.Pba.FileItem EndReadFile(global::System.IAsyncResult asyncResult);

		// Token: 0x0600017F RID: 383
		global::Motorola.Common.Communication.Pba.FileItem ReadFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file);

		// Token: 0x06000180 RID: 384
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginWriteFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000181 RID: 385
		void EndWriteFile(global::System.IAsyncResult asyncResult);

		// Token: 0x06000182 RID: 386
		void WriteFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file);

		// Token: 0x06000183 RID: 387
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginDeleteFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000184 RID: 388
		void EndDeleteFile(global::System.IAsyncResult asyncResult);

		// Token: 0x06000185 RID: 389
		void DeleteFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file);

		// Token: 0x06000186 RID: 390
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginGetFileOrDirSize(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem fileOrDir, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000187 RID: 391
		long EndGetFileOrDirSize(global::System.IAsyncResult asyncResult);

		// Token: 0x06000188 RID: 392
		long GetFileOrDirSize(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem fileOrDir);

		// Token: 0x06000189 RID: 393
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginUpgradeFlashStrap(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600018A RID: 394
		void EndUpgradeFlashStrap(global::System.IAsyncResult asyncResult);

		// Token: 0x0600018B RID: 395
		void UpgradeFlashStrap(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject);

		// Token: 0x0600018C RID: 396
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginUpgradeFDT(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string destModel, string destCPVersion, string serialNumber, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x0600018D RID: 397
		void EndUpgradeFDT(global::System.IAsyncResult asyncResult);

		// Token: 0x0600018E RID: 398
		void UpgradeFDT(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string destModel, string destCPVersion, string serialNumber);

		// Token: 0x0600018F RID: 399
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginEraseRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.Generic.List<string> sections, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000190 RID: 400
		void EndEraseRadio(global::System.IAsyncResult asyncResult);

		// Token: 0x06000191 RID: 401
		void EraseRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.Generic.List<string> sections);

		// Token: 0x06000192 RID: 402
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginEraseRadioFromTo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, uint startAddress, uint size, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000193 RID: 403
		void EndEraseRadioFromTo(global::System.IAsyncResult asyncResult);

		// Token: 0x06000194 RID: 404
		void EraseRadioFromTo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, uint startAddress, uint size);

		// Token: 0x06000195 RID: 405
		[global::System.ServiceModel.ServiceKnownType(typeof(global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginWriteImage(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.MemoryImage image, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000196 RID: 406
		void EndWriteImage(global::System.IAsyncResult asyncResult);

		// Token: 0x06000197 RID: 407
		void WriteImage(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.MemoryImage image);

		// Token: 0x06000198 RID: 408
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginReadCPData(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string blockID, uint offset, uint size, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x06000199 RID: 409
		byte[] EndReadCPData(global::System.IAsyncResult asyncResult);

		// Token: 0x0600019A RID: 410
		byte[] ReadCPData(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string blockID, uint offset, uint size);

		// Token: 0x0600019B RID: 411
		bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo, global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID);

		// Token: 0x0600019C RID: 412
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginUpdateDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, bool hostedDepotOperation, string operationId, global::System.AsyncCallback callback, object state, int? userDefersAllowed = null);

		// Token: 0x0600019D RID: 413
		void EndUpdateDevice(global::System.IAsyncResult asyncResult);

		// Token: 0x0600019E RID: 414
		void UpdateDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, bool hostedDepotOperation = false, int? userDefersAllowed = null);

		// Token: 0x0600019F RID: 415
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginPreUpdateDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, bool hostedDepotOperation, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001A0 RID: 416
		void EndPreUpdateDevice(global::System.IAsyncResult asyncResult);

		// Token: 0x060001A1 RID: 417
		void PreUpdateDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, bool hostedDepotOperation = false);

		// Token: 0x060001A2 RID: 418
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginWriteRamdownloader(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string filePath, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001A3 RID: 419
		bool EndWriteRamdownloader(global::System.IAsyncResult asyncResult);

		// Token: 0x060001A4 RID: 420
		bool WriteRamdownloader(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string filePath);

		// Token: 0x060001A5 RID: 421
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginReadImage(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.UpdateDeviceData images, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001A6 RID: 422
		global::Motorola.Common.Communication.Pba.UpdateDeviceData EndReadImage(global::System.IAsyncResult asyncResult);

		// Token: 0x060001A7 RID: 423
		global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.UpdateDeviceData images);

		// Token: 0x060001A8 RID: 424
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginForceWriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001A9 RID: 425
		void EndForceWriteDevice(global::System.IAsyncResult asyncResult);

		// Token: 0x060001AA RID: 426
		void ForceWriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject);

		// Token: 0x060001AB RID: 427
		void DepotForceWriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject);

		// Token: 0x060001AC RID: 428
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginUpdateSerialNumber(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string serialNumber, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001AD RID: 429
		void EndUpdateSerialNumber(global::System.IAsyncResult asyncResult);

		// Token: 0x060001AE RID: 430
		void UpdateSerialNumber(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string serialNumber);

		// Token: 0x060001AF RID: 431
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginFactoryReset(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001B0 RID: 432
		void FactoryReset(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x060001B1 RID: 433
		void EndFactoryReset(global::System.IAsyncResult asyncResult);

		// Token: 0x060001B2 RID: 434
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginUnkillRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] authenticationValue, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001B3 RID: 435
		void EndUnkillRadio(global::System.IAsyncResult asyncResult);

		// Token: 0x060001B4 RID: 436
		void UnkillRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] authenticationValue);

		// Token: 0x060001B5 RID: 437
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginReadUnkillChallengeValue(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001B6 RID: 438
		byte[] EndReadUnkillChallengeValue(global::System.IAsyncResult asyncResult);

		// Token: 0x060001B7 RID: 439
		byte[] ReadUnkillChallengeValue(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x060001B8 RID: 440
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginUpdateMACAddress(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] macAddress, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001B9 RID: 441
		void EndUpdateMACAddress(global::System.IAsyncResult asyncResult);

		// Token: 0x060001BA RID: 442
		void UpdateMACAddress(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] macAddress);

		// Token: 0x060001BB RID: 443
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginSendUpdateIMEType(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte ime, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001BC RID: 444
		void EndSendUpdateIMEType(global::System.IAsyncResult asyncResult);

		// Token: 0x060001BD RID: 445
		void SendUpdateIMEType(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte ime);

		// Token: 0x060001BE RID: 446
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginSendUpdateDateCode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] dateCode, ushort source, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001BF RID: 447
		void EndSendUpdateDateCode(global::System.IAsyncResult asyncResult);

		// Token: 0x060001C0 RID: 448
		void SendUpdateDateCode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] dateCode, ushort source);

		// Token: 0x060001C1 RID: 449
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginCBIProgramme(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001C2 RID: 450
		void EndCBIProgramme(global::System.IAsyncResult asyncResult);

		// Token: 0x060001C3 RID: 451
		void CBIProgramme(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x060001C4 RID: 452
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginSendFPGAErase(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001C5 RID: 453
		void EndSendFPGAErase(global::System.IAsyncResult asyncResult);

		// Token: 0x060001C6 RID: 454
		void SendFPGAErase(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType);

		// Token: 0x060001C7 RID: 455
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginSendFPGAReset(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001C8 RID: 456
		void EndSendFPGAReset(global::System.IAsyncResult asyncResult);

		// Token: 0x060001C9 RID: 457
		void SendFPGAReset(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType);

		// Token: 0x060001CA RID: 458
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginValidateLocalPassword(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string password, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001CB RID: 459
		global::Motorola.Common.Communication.CommonUtil.PasswordStatus EndValidateLocalPassword(global::System.IAsyncResult asyncResult);

		// Token: 0x060001CC RID: 460
		global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string password);

		// Token: 0x060001CD RID: 461
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginGetFdtInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.FDTType fdtType, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001CE RID: 462
		global::Motorola.Common.Communication.CommonUtil.FDTInfo EndGetFdtInfo(global::System.IAsyncResult asyncResult);

		// Token: 0x060001CF RID: 463
		global::Motorola.Common.Communication.CommonUtil.FDTInfo GetFdtInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.FDTType fdtType);

		// Token: 0x060001D0 RID: 464
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginEnableFxFeature(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIds, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001D1 RID: 465
		void EndEnableFxFeature(global::System.IAsyncResult asyncResult);

		// Token: 0x060001D2 RID: 466
		void EnableFxFeature(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIds);

		// Token: 0x060001D3 RID: 467
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginReadHashInputAndValidate(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001D4 RID: 468
		string EndReadHashInputAndValidate(global::System.IAsyncResult asyncResult);

		// Token: 0x060001D5 RID: 469
		string ReadHashInputAndValidate(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList);

		// Token: 0x060001D6 RID: 470
		[global::System.ServiceModel.ServiceKnownType(typeof(global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginReadImageByAddress(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, uint startAddress, uint size, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001D7 RID: 471
		global::Motorola.Common.Communication.CommonUtil.MemoryImage EndReadImageByAddress(global::System.IAsyncResult asyncResult);

		// Token: 0x060001D8 RID: 472
		global::Motorola.Common.Communication.CommonUtil.MemoryImage ReadImageByAddress(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, uint startAddress, uint size);

		// Token: 0x060001D9 RID: 473
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginGeneralOperation(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001DA RID: 474
		void EndGeneralOperation(global::System.IAsyncResult asyncResult);

		// Token: 0x060001DB RID: 475
		void GeneralOperation(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject);

		// Token: 0x060001DC RID: 476
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginRemoveRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001DD RID: 477
		bool EndRemoveRadio(global::System.IAsyncResult asyncResult);

		// Token: 0x060001DE RID: 478
		bool RemoveRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x060001DF RID: 479
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginReadRadioParameters(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioParameterPairs paramPairs, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001E0 RID: 480
		void EndReadRadioParameters(global::System.IAsyncResult asyncResult);

		// Token: 0x060001E1 RID: 481
		void ReadRadioParameters(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioParameterPairs paramPairs);

		// Token: 0x060001E2 RID: 482
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		global::System.IAsyncResult BeginSetFWDLConfig(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, ushort tg, string version, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001E3 RID: 483
		bool EndSetFWDLConfig(global::System.IAsyncResult asyncResult);

		// Token: 0x060001E4 RID: 484
		bool SetFWDLConfig(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, ushort tg, string version);

		// Token: 0x060001E5 RID: 485
		[global::System.ServiceModel.OperationContract(AsyncPattern = true)]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		global::System.IAsyncResult BeginResetPassword(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] resetBytes, string operationId, global::System.AsyncCallback callback, object state);

		// Token: 0x060001E6 RID: 486
		bool EndResetPassword(global::System.IAsyncResult asyncResult);

		// Token: 0x060001E7 RID: 487
		bool ResetPassword(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] resetBytes);
	}
}
