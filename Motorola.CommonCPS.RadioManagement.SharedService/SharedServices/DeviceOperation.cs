using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using ASK.Interface;
using CommonUtility;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using SharedUtility.Arguments;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000069 RID: 105
	internal abstract class DeviceOperation : global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceOperation
	{
		// Token: 0x06000714 RID: 1812
		public abstract bool IsSerialNumberValid(string serialNumber);

		// Token: 0x06000715 RID: 1813
		public abstract void ValidateCodeplugVersion(global::Motorola.CommonCPS.Server.EntityModel.Radio radio);

		// Token: 0x06000716 RID: 1814
		public abstract void ValidateIsAllowWriteLanguage(global::Motorola.CommonCPS.Server.EntityModel.APXRadio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type);

		// Token: 0x06000717 RID: 1815
		public abstract void ValidateLanguagePackForApplyTemplateToRadio(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug codeplug, string radioFirmwareVer);

		// Token: 0x06000718 RID: 1816
		public abstract void PreImportRadioToServer(string filePath, global::Motorola.CommonCPS.Server.EntityModel.Radio deviceToImport, global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption option);

		// Token: 0x06000719 RID: 1817
		public abstract void BuildValidateSetForASTROScheduleJob(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug currentCodeplug, global::Motorola.CommonCPS.Server.EntityModel.Codeplug workingCodeplug, ref global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x0600071A RID: 1818
		public abstract global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption GetServerReadyJobtOption(bool generateTemplateOrConfig, bool applyToRadio);

		// Token: 0x0600071B RID: 1819
		public abstract global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet BuildValidateEntitySetForASTRORadioUpgrade(global::Motorola.CommonCPS.Server.EntityModel.APXRadio updatedRadio, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData syncRadioForUpgrade);

		// Token: 0x0600071C RID: 1820
		public abstract void GetSyncDataForUpgrade(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware firmware, byte[] flashCode, string iButtonSerialNumber, global::System.Collections.Generic.IList<global::System.Guid> cross712Radios, int allRadioCount, bool isRefresh, global::ASK.Interface.ISystemKeyData systemID, out global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData syncData, string codeplugVersion = null);

		// Token: 0x0600071D RID: 1821
		public abstract global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpgradeASTRORadioBatch(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Radio radioToUpgrdae, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData syncData, global::Motorola.CommonCPS.RadioManagement.SharedServices.FlashKeyInfo flashKeyInfo, global::System.Collections.Generic.IList<global::System.Guid> cross712Radios);

		// Token: 0x0600071E RID: 1822
		public abstract void CleanForUpgrade(global::System.Collections.Generic.IList<global::System.Guid> upgradeSuccessfulRadios, global::System.Collections.Generic.IList<global::System.Guid> Cross712Radios, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData syncData);

		// Token: 0x0600071F RID: 1823
		public abstract global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest HandleTemplateAndConfigForImportCSV(global::Motorola.CommonCPS.Server.EntityModel.Radio existedRadio, string templateName, string configName, string copiedRadioSN, global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest radioRq, global::Motorola.CommonCPS.RadioManagement.SharedServices.ImportCSVCache cache, ref global::System.Collections.Generic.List<string> warningList);

		// Token: 0x06000720 RID: 1824 RVA: 0x0004D348 File Offset: 0x0004B548
		public virtual global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest HandleIPProgramSystemForImportCSV(global::Motorola.CommonCPS.Server.EntityModel.Radio existedRadio, string ipProgramSystemAlias, string copiedRadioSN, global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest radioRq, global::Motorola.CommonCPS.RadioManagement.SharedServices.ImportCSVCache cache, ref global::System.Collections.Generic.List<string> warningList)
		{
			short num = (short)60293121;
			if (num != 0)
			{
			}
			num = (short)1366742210;
			short num2 = num;
			num = (short)1135072450;
			switch (num2 == num)
			{
			}
			num = (short)1538981888;
			if (num != 0)
			{
			}
			num = (short)1429798912;
			short num3 = num;
			return radioRq;
		}

		// Token: 0x06000721 RID: 1825
		public abstract bool IsQualifiedRadio(global::Motorola.CommonCPS.Server.EntityModel.Radio rd, global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest rq);

		// Token: 0x06000722 RID: 1826
		public abstract global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? GetDefaultRegion();

		// Token: 0x06000723 RID: 1827
		public abstract global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SharedServices.AppLicenseInfo> GetRegisteredAppLicenses();

		// Token: 0x06000724 RID: 1828
		public abstract bool IsAppLicenseSupport_RRP(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName?> regionList);

		// Token: 0x06000725 RID: 1829
		public abstract string GetFileNameForExportCodeplug(string serialNumber, string templateName, string configName, bool? hasPBA);

		// Token: 0x06000726 RID: 1830
		public abstract global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption GetImportOption(bool isCreateRadio, bool isCreateTemplate, bool isCreateConfig, bool isApply);

		// Token: 0x06000727 RID: 1831
		public abstract bool CanImportRadio(bool isCreateRadio, bool isCreateConfig);

		// Token: 0x06000728 RID: 1832
		public abstract bool IsInitializeImportRadio(out bool canOverride);

		// Token: 0x06000729 RID: 1833
		public abstract bool IsValidAppLicense(string licenseName);

		// Token: 0x0600072A RID: 1834
		public abstract bool CanExportCodeplug(global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus radioStatus, bool? hasPBA);

		// Token: 0x0600072B RID: 1835
		public abstract bool ValidateAstroASKRequirement(global::Motorola.CommonCPS.Server.EntityModel.APXRadio radioFromServer, out string error);

		// Token: 0x0600072C RID: 1836
		public abstract bool ValidateRadioIdWithASK(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem radioSys, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxCpg, string modelnumber, out string error, bool checkASKOnly = false);

		// Token: 0x0600072D RID: 1837
		public abstract global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> GetLoadedASKWithoutDefault(bool isAttached = false);

		// Token: 0x0600072E RID: 1838
		public abstract global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> GetLoadedASKWithDefault(bool isAttached = false);

		// Token: 0x0600072F RID: 1839
		public abstract void ResetRegionWithAppRegion(global::Motorola.CommonCPS.Server.EntityModel.Radio d);

		// Token: 0x06000730 RID: 1840 RVA: 0x0004D3F4 File Offset: 0x0004B5F4
		public void FetchPCRKeysFromServer(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData keyData)
		{
			short num = (short)1536211464;
			short num2 = num;
			num = (short)428456456;
			switch (num2 == num)
			{
			}
			num = (short)812122112;
			if (num != 0)
			{
			}
			num = (short)594477057;
			if (num != 0)
			{
			}
			num = (short)110624768;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false);
			this.FetchPCROTAPKey(keyData, instance);
			this.FetchPCRPrivacyKeys(keyData, instance);
			this.FetchPCRRASKey(keyData, instance);
			this.FetchPCRSymmetricKey(keyData, instance);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0004D4C8 File Offset: 0x0004B6C8
		public bool CheckASKFieldApplicability(byte[] flashBytes)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			short num2;
			bool flag2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_176;
				case 1:
					if (flashBytes != null)
					{
						num2 = (short)521142276;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E4;
				case 2:
					goto IL_E4;
				case 3:
					if (flashBytes != null)
					{
						num2 = (short)1494024192;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E4;
				case 4:
					num2 = (short)1998389251;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					bool flag;
					if (flag)
					{
						num2 = (short)475594760;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 6:
					if (flashBytes.Length > 4)
					{
						num2 = (short)712376327;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E4;
				case 7:
				{
					byte b = flashBytes[4];
					bool flag = (b & 8) > 0;
					flag2 = ((b & 4) > 0);
					num2 = (short)1034092546;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					goto IL_119;
				}
				goto IL_34;
				IL_E4:
				num2 = (short)2097741829;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_119:
			num2 = (short)61079553;
			if (num2 != 0)
			{
			}
			return !flag2;
			IL_34:
			num2 = (short)1155828845;
			short num3 = num2;
			num2 = (short)125471853;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_176:
				num2 = (short)1837367302;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)2061303808;
				short num4 = num2;
				num2 = (short)155910144;
				if (num2 != 0)
				{
				}
				bool flag = false;
				flag2 = false;
				num2 = (short)776208385;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000732 RID: 1842
		public abstract bool ValidateIPConflictWithLocalServerIPAddress(global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint arge, bool? locationEnable, bool? p25LocationReporting, int? arsMode, bool? directLocationRegistration, string locationServerIPAddress, out global::Motorola.Common.CustomException.CommonErrorCode error);

		// Token: 0x06000733 RID: 1843
		public abstract bool ValidataIPConflictWithBluetoothPANNetworkBaseAddress(global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint arge, string locationServerIPAddress, out global::Motorola.Common.CustomException.CommonErrorCode error);

		// Token: 0x06000734 RID: 1844
		public abstract bool ValidataIPConflictLink2IPs(global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint arge, bool IsDVRSMSUOperation, string PeerIP_Link2, string SubscriberIP_Link2, out global::Motorola.Common.CustomException.CommonErrorCode error);

		// Token: 0x06000735 RID: 1845 RVA: 0x0004D6B8 File Offset: 0x0004B8B8
		protected void FetchPCROTAPKey(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData keyData, global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor server)
		{
			short num = (short)960495616;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.List<string> identifiers = keyData.OTAPKeys.Where(delegate(global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey k)
				{
					short num5 = (short)1700945266;
					short num6 = num5;
					num5 = (short)485383538;
					switch (num6 == num5)
					{
					}
					num5 = (short)1289945089;
					if (num5 != 0)
					{
					}
					num5 = (short)1862008832;
					if (num5 != 0)
					{
					}
					num5 = (short)1644953600;
					short num7 = num5;
					return global::CommonUtility.PCRKeyUtility.IsOtapAuthenticationKeyIDValid(new int?(k.Id));
				}).Select(delegate(global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey k)
				{
					short num5 = (short)728937315;
					short num6 = num5;
					num5 = (short)625259363;
					switch (num6 == num5)
					{
					}
					num5 = (short)349962241;
					if (num5 != 0)
					{
					}
					num5 = (short)437452800;
					if (num5 != 0)
					{
					}
					num5 = (short)1986199552;
					short num7 = num5;
					return k.Id.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
				}).ToList<string>();
				global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.MatrixKey> matrixKeysByIdentifiers = server.GetMatrixKeysByIdentifiers(identifiers, global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType.OTAPKey);
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey>.Enumerator enumerator = keyData.OTAPKeys.GetEnumerator())
				{
					num = (short)505085953;
					int num2 = (int)((global::System.IntPtr)num);
					global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey matrixOTAPKey;
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1367015430;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							matrixOTAPKey = enumerator.Current;
							string key = matrixOTAPKey.Id.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
							num = (short)1753612290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_DB;
							}
							continue;
						case 2:
						{
							string key;
							if (matrixKeysByIdentifiers.ContainsKey(key))
							{
								num = (short)1465974787;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1B8;
						}
						case 3:
						{
							num = (short)916369585;
							short num3 = num;
							num = (short)970436785;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								num = (short)726007808;
								if (num != 0)
								{
								}
								num = (short)1834876932;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							string key;
							if (matrixKeysByIdentifiers[key] is global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey)
							{
								num = (short)1168244741;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1B8;
						}
						case 5:
						{
							string key;
							matrixOTAPKey.Uuid = matrixKeysByIdentifiers[key].Uuid;
							matrixOTAPKey.Alias = matrixKeysByIdentifiers[key].Alias;
							matrixOTAPKey.Value = (matrixKeysByIdentifiers[key] as global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey).Value;
							matrixOTAPKey.Timestamp = matrixKeysByIdentifiers[key].Timestamp;
							num = (short)1335820296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)1849950215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_2FA;
						case 8:
							goto IL_2A3;
						}
						goto IL_DB;
						IL_2A3:
						num = (short)1359740928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_DB:
						num = (short)1743716353;
						if (num != 0)
						{
						}
						goto IL_2A3;
					}
					IL_1B8:
					throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.CannotFoundKeyOnServer, new string[]
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType.OTAPKey.ToString(),
						matrixOTAPKey.Id.ToString(global::System.Globalization.CultureInfo.CurrentCulture)
					}));
					IL_2FA:;
				}
				num = (short)593166336;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0004DA14 File Offset: 0x0004BC14
		protected void FetchPCRPrivacyKeys(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData keyData, global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor server)
		{
			short num = (short)1673330688;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.List<string> identifiers = keyData.PrivacyKeys.Where(delegate(global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey k)
				{
					short num5 = (short)727515384;
					short num6 = num5;
					num5 = (short)378601720;
					switch (num6 == num5)
					{
					}
					num5 = (short)1036058624;
					if (num5 != 0)
					{
					}
					num5 = (short)865665025;
					if (num5 != 0)
					{
					}
					num5 = (short)811401216;
					short num7 = num5;
					return global::CommonUtility.PCRKeyUtility.IsPrivacyKeyIDValid(new int?(k.Id));
				}).Select(delegate(global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey k)
				{
					short num5 = (short)855392122;
					short num6 = num5;
					num5 = (short)1199390586;
					switch (num6 == num5)
					{
					}
					num5 = (short)722141184;
					if (num5 != 0)
					{
					}
					num5 = (short)749338625;
					if (num5 != 0)
					{
					}
					num5 = (short)195821568;
					short num7 = num5;
					return k.Id.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
				}).ToList<string>();
				global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.MatrixKey> matrixKeysByIdentifiers = server.GetMatrixKeysByIdentifiers(identifiers, global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType.PrivacyKey);
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey>.Enumerator enumerator = keyData.PrivacyKeys.GetEnumerator())
				{
					num = (short)961019905;
					int num2 = (int)((global::System.IntPtr)num);
					global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey matrixPrivacyKey;
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1358823430;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							matrixPrivacyKey = enumerator.Current;
							string key = matrixPrivacyKey.Id.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
							num = (short)1399193602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_DB;
							}
							continue;
						case 2:
						{
							num = (short)1903296513;
							if (num != 0)
							{
							}
							string key;
							if (matrixKeysByIdentifiers.ContainsKey(key))
							{
								num = (short)1936785411;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_18C;
						}
						case 3:
						{
							num = (short)1513722461;
							short num3 = num;
							num = (short)2120585821;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								num = (short)725417984;
								if (num != 0)
								{
								}
								num = (short)38666244;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							string key;
							if (matrixKeysByIdentifiers[key] is global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey)
							{
								num = (short)685244421;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_18C;
						}
						case 5:
						{
							string key;
							matrixPrivacyKey.Uuid = matrixKeysByIdentifiers[key].Uuid;
							matrixPrivacyKey.Alias = matrixKeysByIdentifiers[key].Alias;
							matrixPrivacyKey.Value = (matrixKeysByIdentifiers[key] as global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey).Value;
							matrixPrivacyKey.Timestamp = matrixKeysByIdentifiers[key].Timestamp;
							num = (short)1377304584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)527368199;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_2F6;
						}
						IL_2A0:
						num = (short)1952251904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_DB:
						goto IL_2A0;
					}
					IL_18C:
					throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.CannotFoundKeyOnServer, new string[]
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType.PrivacyKey.ToString(),
						matrixPrivacyKey.Id.ToString(global::System.Globalization.CultureInfo.CurrentCulture)
					}));
					IL_2F6:;
				}
				num = (short)1586495488;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0004DD70 File Offset: 0x0004BF70
		protected void FetchPCRRASKey(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData keyData, global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor server)
		{
			short num = (short)1949761536;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.List<string> identifiers = keyData.RASKeys.Where(delegate(global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey k)
				{
					short num5 = (short)1821883818;
					short num6 = num5;
					num5 = (short)1284816298;
					switch (num6 == num5)
					{
					}
					num5 = (short)2039021569;
					if (num5 != 0)
					{
					}
					num5 = (short)162136064;
					if (num5 != 0)
					{
					}
					num5 = (short)718209024;
					short num7 = num5;
					return global::CommonUtility.PCRKeyUtility.IsRASKeyAliasValid(k.Alias);
				}).Select(delegate(global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey k)
				{
					short num5 = (short)994377729;
					if (num5 != 0)
					{
					}
					num5 = (short)101516938;
					short num6 = num5;
					num5 = (short)1145570954;
					switch (num6 == num5)
					{
					}
					num5 = (short)1090453504;
					if (num5 != 0)
					{
					}
					num5 = (short)828833792;
					short num7 = num5;
					return k.Alias;
				}).ToList<string>();
				global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.MatrixKey> matrixKeysByIdentifiers = server.GetMatrixKeysByIdentifiers(identifiers, global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType.RASKey);
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey>.Enumerator enumerator = keyData.RASKeys.GetEnumerator())
				{
					num = (short)208404481;
					int num2 = (int)((global::System.IntPtr)num);
					global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey matrixRASKey;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (!enumerator.MoveNext())
							{
								num = (short)1229586438;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							matrixRASKey = enumerator.Current;
							num = (short)116326402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)803995649;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_102;
							}
							continue;
						case 2:
							if (matrixKeysByIdentifiers.ContainsKey(matrixRASKey.Alias))
							{
								num = (short)1195311107;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1B1;
						case 3:
						{
							num = (short)1012911878;
							short num3 = num;
							num = (short)1265946374;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								num = (short)2066481152;
								if (num != 0)
								{
								}
								num = (short)2075590660;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							if (matrixKeysByIdentifiers[matrixRASKey.Alias] is global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey)
							{
								num = (short)127008773;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1B1;
						case 5:
							matrixRASKey.Uuid = matrixKeysByIdentifiers[matrixRASKey.Alias].Uuid;
							matrixRASKey.Value = (matrixKeysByIdentifiers[matrixRASKey.Alias] as global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey).Value;
							matrixRASKey.Timestamp = matrixKeysByIdentifiers[matrixRASKey.Alias].Timestamp;
							num = (short)96337928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)2008154119;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_2D1;
						}
						IL_27A:
						num = (short)2045640704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_102:
						goto IL_27A;
					}
					IL_1B1:
					throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.CannotFoundKeyOnServer, new string[]
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType.RASKey.ToString(),
						matrixRASKey.Alias
					}));
					IL_2D1:;
				}
				num = (short)1743912960;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0004E0A4 File Offset: 0x0004C2A4
		protected void FetchPCRSymmetricKey(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData keyData, global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor server)
		{
			short num = (short)1284767744;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.List<string> identifiers = keyData.SymmetricKeys.Where(delegate(global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey k)
				{
					short num5 = (short)1032091530;
					short num6 = num5;
					num5 = (short)1939109770;
					switch (num6 == num5)
					{
					}
					num5 = (short)410386433;
					if (num5 != 0)
					{
					}
					num5 = (short)460193792;
					if (num5 != 0)
					{
					}
					num5 = (short)1489240064;
					short num7 = num5;
					return global::CommonUtility.PCRKeyUtility.IsSymmetricKeyIDValid(new int?(k.Id));
				}).Select(delegate(global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey k)
				{
					short num5 = (short)1037534781;
					short num6 = num5;
					num5 = (short)298354237;
					switch (num6 == num5)
					{
					}
					num5 = (short)333840385;
					if (num5 != 0)
					{
					}
					num5 = (short)1404567552;
					if (num5 != 0)
					{
					}
					num5 = (short)76021760;
					short num7 = num5;
					return k.Id.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
				}).ToList<string>();
				global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.MatrixKey> matrixKeysByIdentifiers = server.GetMatrixKeysByIdentifiers(identifiers, global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType.SymmetricKey);
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey>.Enumerator enumerator = keyData.SymmetricKeys.GetEnumerator())
				{
					num = (short)1943339009;
					int num2 = (int)((global::System.IntPtr)num);
					global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey matrixSymmetricKey;
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)551878662;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							matrixSymmetricKey = enumerator.Current;
							string key = matrixSymmetricKey.Id.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
							num = (short)2089156610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_DA;
							}
							continue;
						case 2:
						{
							string key;
							if (matrixKeysByIdentifiers.ContainsKey(key))
							{
								num = (short)818348035;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_18D;
						}
						case 3:
						{
							num = (short)664702691;
							short num3 = num;
							num = (short)2009960163;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								num = (short)835649536;
								if (num != 0)
								{
								}
								num = (short)2022834180;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							string key;
							if (matrixKeysByIdentifiers[key] is global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey)
							{
								num = (short)916193285;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_18D;
						}
						case 5:
						{
							string key;
							matrixSymmetricKey.Uuid = matrixKeysByIdentifiers[key].Uuid;
							matrixSymmetricKey.Alias = matrixKeysByIdentifiers[key].Alias;
							matrixSymmetricKey.Value = (matrixKeysByIdentifiers[key] as global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey).Value;
							matrixSymmetricKey.Timestamp = matrixKeysByIdentifiers[key].Timestamp;
							num = (short)1657012232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)66519047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_2F8;
						}
						IL_2A1:
						num = (short)1321533440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_DA:
						goto IL_2A1;
					}
					IL_18D:
					num = (short)772341761;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.CannotFoundKeyOnServer, new string[]
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType.SymmetricKey.ToString(),
						matrixSymmetricKey.Id.ToString(global::System.Globalization.CultureInfo.CurrentCulture)
					}));
					IL_2F8:;
				}
				num = (short)1828847616;
				short num4 = num;
				return;
			}
			}
		}
	}
}
