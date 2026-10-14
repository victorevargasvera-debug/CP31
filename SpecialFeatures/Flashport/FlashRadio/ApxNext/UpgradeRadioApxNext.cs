using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpUtility;
using CommonResources;
using ConstraintHelper;
using Motorola.Acp.PackUnpack.Ish;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.PackExec;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioProfiles;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;
using Motorola.MackinawCPS.CoreFeatures.ToneSignalingList;
using Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Comms;
using SpecialFeatures.Comms.Util;
using SpecialFeatures.Flashport.FlashkeyLib;
using SpecialFeatures.Model_Configuration;
using SpecialFeatures.VoiceAnnouncements;

namespace SpecialFeatures.Flashport.FlashRadio.ApxNext
{
	// Token: 0x020000FA RID: 250
	public class UpgradeRadioApxNext
	{
		// Token: 0x06000E04 RID: 3588 RVA: 0x0000316F File Offset: 0x0000136F
		public UpgradeRadioApxNext(global::System.ComponentModel.BackgroundWorker worker, bool isRefresh)
		{
			this.b = new global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressUpdater(worker);
			this.c = isRefresh;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x001366CC File Offset: 0x001348CC
		public void FlashRadio(string upgradeFile)
		{
			int a_ = 10;
			short num = (short)501612544;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_F7;
					}
					for (;;)
					{
						IL_34:
						global::SpecialFeatures.Comms.RadioParams radioParams;
						global::SpecialFeatures.Flashport.FlashRadio.MetadataFile metadataFile;
						global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug;
						global::SpecialFeatures.Comms.IDeviceProxy deviceProxy;
						string text;
						global::SpecialFeatures.Flashport.FlashRadio.FlashCodeplug flashCodeplug;
						global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering;
						string postFlashCodeplugFields;
						string cvnHostVersion;
						switch (num2)
						{
						case 0:
						{
							bool flag2 = this.b(radioParams, metadataFile);
							bool flag3 = this.a(radioParams, metadataFile);
							if (!flag2)
							{
								num = (short)305659941;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B79;
						}
						case 1:
						{
							bool flag3;
							if (!flag3)
							{
								num = (short)1702625303;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_992;
						}
						case 2:
							goto IL_33A;
						case 3:
							if (!this.c)
							{
								num = (short)112394247;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_404;
						case 4:
							goto IL_88B;
						case 5:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_56A;
								}
								for (;;)
								{
									IL_53F:
									global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager flashkeyManager;
									switch (num2)
									{
									case 0:
										if (!flashkeyManager.ValidateKey())
										{
											num = (short)142802949;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_6B3;
									case 1:
										if (!this.c)
										{
											num = (short)599588871;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_6B3;
									case 2:
										goto IL_716;
									case 3:
										goto IL_6F6;
									case 4:
										if (!this.c && flag)
										{
											num = (short)1111228422;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_6F6;
									case 5:
										goto IL_6AE;
									case 6:
										goto IL_64F;
									case 7:
										num = (short)1575813120;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										try
										{
											global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
											pbaObject.SetCodeplug(codeplug);
											pbaObject.CodeplugData.CPVersion = global::AcpCommonLib.AppInfoManager.AppVersion;
											this.b.MaxSteps = 65;
											this.b.UpdateWorker(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.FlashingRadio, null);
											pbaObject.FWpath = upgradeFile;
											deviceProxy.UpdateDevice(radioParams, pbaObject, new global::System.ComponentModel.ProgressChangedEventHandler(this.b.UpdateRadioProgress));
											this.b.UpdateWorker(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.UploadFirmware, null);
											goto IL_589;
										}
										catch (global::System.Exception)
										{
											this.b.UpdateWorker(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.FlashingRadioError, null);
											throw;
										}
										goto IL_64F;
										IL_589:
										num = (short)528809985;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_56A;
									IL_64F:
									global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.a(flashkeyManager);
									num = (short)1734934531;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_6B3:
									num = (short)1058144260;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_6F6:
									global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.a(deviceProxy, radioParams);
									num = (short)598736898;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_6AE:
								throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.FLASHkey_Validation_failed);
								IL_716:
								goto IL_CC9;
								IL_56A:
								deviceProxy.ReadExtendedDeviceInfo();
								num = (short)1487536136;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_53F;
							}
							finally
							{
								num = (short)983367682;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										deviceProxy.Dispose();
										num = (short)652148737;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_786;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_74D;
										}
										continue;
									}
									IL_74D:
									if (deviceProxy == null)
									{
										break;
									}
									num = (short)2082668544;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_786:;
							}
							goto Block_15;
							IL_CC9:
							num = (short)1796145188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_C52;
						case 7:
						{
							global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager flashkeyManager;
							text = (string)flashkeyManager.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.FlashcodeNew);
							bool flag4 = flashkeyManager.IsModelUpgradeKey();
							num = (short)1940455437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager flashkeyManager;
							if (!flashkeyManager.FindFlashkey(radioParams.ModelNumber, text, global::SpecialFeatures.Flashport.FlashkeyLib.FindType.FindExactMatch))
							{
								num = (short)765984770;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4D7;
						}
						case 9:
							goto IL_B18;
						case 10:
							if (!this.c)
							{
								num = (short)1493434398;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_298;
						case 11:
							if (!this.c)
							{
								num = (short)442957853;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_88B;
						case 12:
						{
							global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager flashkeyManager;
							if (!flashkeyManager.ValidateKey())
							{
								num = (short)355008534;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_24B;
						}
						case 13:
						{
							bool flag4;
							if (flag4)
							{
								num = (short)751697935;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag = flashCodeplug.UpgradeCodeplug(radioParams.ModelNumber, text, flag4, true, null);
							num = (short)1381498921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							if (!this.c)
							{
								num = (short)1860763688;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_513;
						case 15:
							goto IL_1B6;
						case 16:
							if (!this.c)
							{
								num = (short)2138112034;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1BB;
						case 17:
						{
							global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager flashkeyManager;
							if ((int)flashkeyManager.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.UpgradesRemaining) <= 0)
							{
								num = (short)1667170348;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B84;
						}
						case 18:
							goto IL_161;
						case 19:
							goto IL_789;
						case 20:
							goto IL_298;
						case 21:
							goto IL_C25;
						case 22:
							goto IL_990;
						case 23:
							num = (short)1593376795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
						{
							try
							{
								modelTiering.UpdateUtilityMackModelType();
								goto IL_A32;
							}
							finally
							{
								num = (short)48562178;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										((global::System.IDisposable)modelTiering).Dispose();
										num = (short)434569217;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_3F6;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_3BF;
										}
										continue;
									}
									IL_3BF:
									if (modelTiering == null)
									{
										break;
									}
									num = (short)722075648;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_3F6:;
							}
							goto IL_3F9;
							IL_A32:
							global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.b(radioParams.SerialNumber);
							this.b.UpdateWorker(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.ValidateUserParams, null);
							string serial = global::SpecialFeatures.Flashport.FlashRadio.SerialNumberValidator.convertSerialNumberToAscii(radioParams.SerialNumber);
							global::SpecialFeatures.Flashport.FlashRadio.RadioInfoParams objectToShow = new global::SpecialFeatures.Flashport.FlashRadio.RadioInfoParams(radioParams.ModelNumber, serial, text);
							this.b.UpdateWorker(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.RadioSerialValidated, objectToShow);
							this.b.UpdateWorker(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.BasicProgress, null);
							global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager flashkeyManager = new global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager();
							num = (short)2043543591;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 25:
							num = (short)1375535105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							if (this.c)
							{
								num = (short)973471769;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_992;
						case 27:
							if (global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.a(radioParams.ModelNumber, metadataFile.BpFirmware, text))
							{
								num = (short)9437205;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_992;
						case 28:
							if (!this.c)
							{
								num = (short)685178923;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_24B;
						case 29:
						{
							global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager flashkeyManager;
							global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.b(flashkeyManager, text);
							num = (short)1553530884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 30:
						{
							global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager flashkeyManager;
							postFlashCodeplugFields = global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.b(flashkeyManager);
							num = (short)999096340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 31:
							num = (short)2116288520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 32:
							cvnHostVersion = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8c뾎ꆐ붒ꖔꞖ래ꮚ궜꾞", a_);
							goto IL_C2A;
						case 33:
						{
							try
							{
								metadataFile = global::SpecialFeatures.Flashport.FlashRadio.ApxNext.MetadataFileParser.ParseZip(upgradeFile);
								global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.a(metadataFile);
							}
							catch (global::System.Exception)
							{
								this.b.UpdateWorker(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.FirmwarePackageInvalid, null);
								throw new global::System.Exception(global::CommonResources.AppResources.Invalid_upgrade_file);
							}
							this.b.UpdateWorker(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.FindValidDevice, null);
							global::SpecialFeatures.Comms.IDeviceProxy deviceProxy2 = this.t();
							num = (short)92078099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 34:
						{
							global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager flashkeyManager;
							global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.a(flashkeyManager, radioParams.ModelNumber);
							num = (short)1719468070;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 35:
							num = (short)1681981457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 36:
							goto IL_CE2;
						case 37:
							num = (short)214499354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 38:
							goto IL_1BB;
						case 39:
							if (!this.c)
							{
								num = (short)1043988511;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4D7;
						case 40:
							num = (short)827523118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 41:
							if (!flag)
							{
								num = (short)921632777;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_404;
						case 42:
							if ((cvnHostVersion = global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ReleaseToCodeplugMapper.GetMaxSupportedCodeplug(metadataFile.TargetRelease)) == null)
							{
								num = (short)622854176;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C2A;
						case 43:
							num = (short)650575884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 44:
							goto IL_CC4;
						case 45:
							if (!this.c)
							{
								num = (short)1568079907;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B84;
						case 46:
						{
							global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager flashkeyManager;
							if (!flashkeyManager.ValidateKey())
							{
								num = (short)294649874;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_513;
						}
						}
						goto IL_F7;
						IL_1BB:
						this.b.UpdateWorker(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.BasicProgress, null);
						num = (short)1997996043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						Block_15:
						global::Motorola.Common.Communication.Pba.PbaObject pbaObject2;
						try
						{
							IL_789:
							this.b.UpdateWorker(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.ConnectDone, null);
							global::SpecialFeatures.Comms.IDeviceProxy deviceProxy2;
							radioParams = deviceProxy2.ReadExtendedDeviceInfo();
							global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.a(radioParams);
							this.b.MaxSteps = 8;
							pbaObject2 = deviceProxy2.Read(radioParams, new global::System.ComponentModel.ProgressChangedEventHandler(this.b.UpdateRadioProgress));
							goto IL_214;
						}
						finally
						{
							num = (short)985071618;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::SpecialFeatures.Comms.IDeviceProxy deviceProxy2;
								switch (num2)
								{
								case 0:
									deviceProxy2.Dispose();
									num = (short)1249640449;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_83D;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_803;
									}
									continue;
								}
								IL_803:
								if (deviceProxy2 == null)
								{
									break;
								}
								num = (short)257097728;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_83D:;
						}
						goto IL_840;
						IL_214:
						text = global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.a(pbaObject2);
						modelTiering = new global::SpecialFeatures.Model_Configuration.ModelTiering(radioParams.ModelNumber, "");
						num = (short)1842413592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_24B:
						this.b.UpdateWorker(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.BasicProgress, null);
						num = (short)2059272208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_298:
						flashCodeplug.SetPostFlashCodeplugFields(postFlashCodeplugFields);
						global::SpecialFeatures.VoiceAnnouncements.TtsDataTreeUpdater.AddTtsToFeatureManager();
						codeplug = this.d(radioParams.ModelNumber);
						num = (short)1271201806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C2A:
						if (global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioValidator.IsCPSVersionLowerThanFirmwareUpgradeVersion(cvnHostVersion, global::AcpCommonLib.AppInfoManager.AppVersion))
						{
							num = (short)988872710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1292501037;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_404:
						global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.a(radioParams, text, metadataFile.BpFirmware);
						global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.c(radioParams.ModelNumber);
						global::AcpCommonLib.ConstraintManager.Suspend();
						postFlashCodeplugFields = null;
						num = (short)300941322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4D7:
						this.b.UpdateWorker(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.BasicProgress, null);
						num = (short)2009202730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_513:
						deviceProxy = this.t();
						num = (short)423821317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_88B:
						this.b.UpdateWorker(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.BasicProgress, null);
						this.b.UpdateWorker(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.ReadTheCodeplugStart, null);
						this.b.MaxSteps = 8;
						global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pbaObject2.GetCodeplugInIshItemCollection();
						this.b.UpdateWorker(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.ReadTheCodeplugStart, null);
						global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.a(codeplugInIshItemCollection, radioParams.ModelNumber);
						flashCodeplug = new global::SpecialFeatures.Flashport.FlashRadio.FlashCodeplug();
						flashCodeplug.postCodeplugInitialization();
						global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.v();
						global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.w();
						global::SpecialFeatures.LastSetJobUuidHelper.SetLastSetJobUuidField(null);
						global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.e();
						global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.d();
						((global::AcpBusinessLayer.AcpDocument)global::AcpCommonLib.FeatureManager.ActiveDocument).Initialized(true);
						num = (short)1376649216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_992:
						num = (short)1987117059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_B84:
						this.b.UpdateWorker(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.BasicProgress, null);
						num = (short)1582366748;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_161:
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.FLASHkey_Validation_failed);
					IL_1B6:
					goto IL_3F9;
					IL_33A:
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Unable_to_find_a_valid_FLASHkey_for_this_radio);
					IL_3F9:
					throw new global::System.NotImplementedException(global::CommonResources.AppResources.Model_Number_Upgrades);
					IL_840:
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Codeplug_upgrade_failed);
					IL_990:
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.FLASHkey_Validation_failed);
					IL_B18:
					goto IL_840;
					IL_B79:
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.The_version_of_software);
					IL_C25:
					goto IL_B79;
					IL_C52:
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Unable_to_Flash_radio_Need_Latest_CPS);
					IL_CC4:
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.There_are_no_upgrades_left_on_the_FLASHkey);
					IL_CE2:
					goto IL_D58;
					IL_F7:
					global::AcpCommonLib.AppInfoManager.DragOperation = true;
					num = (short)758775841;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_34;
				}
				catch (global::Motorola.Common.CustomException.CommonException ex)
				{
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(ex.Message);
				}
				catch (global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException)
				{
					throw;
				}
				catch (global::System.Exception ex2)
				{
					if (ex2.Message != null)
					{
						num = (short)1940594095;
						short num3 = num;
						num = (short)1014635951;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)515899392;
							if (num != 0)
							{
							}
							throw;
						}
					}
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Communication_with_radio_failed_Please_cycle_radio_power_and_check_connections);
				}
				finally
				{
					global::AcpCommonLib.AppInfoManager.DragOperation = false;
				}
				IL_D58:
				num = (short)1653080064;
				short num4 = num;
				num = (short)12779521;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00137560 File Offset: 0x00135760
		private static void a(global::SpecialFeatures.Flashport.FlashRadio.MetadataFile A_0)
		{
			int a_ = 1;
			short num = (short)1604648983;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!string.IsNullOrEmpty(A_0.PostBuildIncremental))
					{
						num = (short)407437317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_106;
				case 1:
					if (string.IsNullOrEmpty(A_0.BpFirmware))
					{
						num = (short)1168179217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					if (string.IsNullOrEmpty(A_0.PreBuildIncremental))
					{
						num = (short)1090060303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					num = (short)417267713;
					if (num != 0)
					{
					}
					num = (short)1697513486;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					string text;
					if (!(text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힇ﾉﲋ", a_)))
					{
						num = (short)1164771331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)271253511;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					num = (short)999292937;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_1E0;
				case 7:
					if (!string.IsNullOrEmpty(A_0.PostBuildIncremental))
					{
						num = (short)1951203350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27C;
				case 8:
				{
					string text;
					if (!(text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﲍﲑﾕ聯", a_)))
					{
						num = (short)509083664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1398276096;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					if (!string.IsNullOrEmpty(A_0.BpFirmware))
					{
						num = (short)1802174476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_106;
				case 10:
					goto IL_101;
				case 11:
				{
					num = (short)1064763392;
					short num3 = num;
					num = (short)1369112597;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					num = (short)860487682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (!string.IsNullOrEmpty(A_0.BpFirmware))
					{
						num = (short)1305477131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27C;
				case 14:
					goto IL_2D0;
				case 15:
					goto IL_4A5;
				case 16:
					num = (short)1890189316;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_41F;
				case 18:
				{
					string text;
					if (!(text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_)))
					{
						num = (short)1663434776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1715339284;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 19:
					num = (short)1142226945;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (!string.IsNullOrEmpty(A_0.PostBuildIncremental))
					{
						num = (short)388956179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_287;
				case 21:
					if (string.IsNullOrEmpty(A_0.PreBuildIncremental))
					{
						num = (short)470745094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 22:
					num = (short)609746957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
				{
					num = (short)1993151837;
					short num4 = num;
					num = (short)312939869;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2D0;
					default:
						num = (short)464584704;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_DA;
						}
						continue;
					}
					break;
				}
				case 24:
					num = (short)587071496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_DA:
				if (string.IsNullOrEmpty(A_0.OtaPackage))
				{
					num = (short)379060234;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					string text = A_0.OtaPackage.ToLower();
					num = (short)762314770;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_101:
			throw new global::System.Exception(global::CommonResources.AppResources.Invalid_upgrade_file);
			IL_106:
			throw new global::System.Exception(global::CommonResources.AppResources.Invalid_upgrade_file);
			IL_1E0:
			IL_27C:
			throw new global::System.Exception(global::CommonResources.AppResources.Invalid_upgrade_file);
			IL_287:
			throw new global::System.Exception(global::CommonResources.AppResources.Invalid_upgrade_file);
			IL_2D0:
			throw new global::System.Exception(global::CommonResources.AppResources.Invalid_upgrade_file);
			IL_41F:
			goto IL_287;
			IL_4A5:
			goto IL_106;
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00137A18 File Offset: 0x00135C18
		private static string b(global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager A_0)
		{
			int a_ = 16;
			string text = "";
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_49;
				}
				int num;
				byte[] keySerialNumber;
				for (;;)
				{
					IL_1B:
					int num4;
					switch (num)
					{
					case 0:
						goto IL_128;
					case 1:
						goto IL_208;
					case 2:
						goto IL_13F;
					case 3:
						num2 = (short)1360986121;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						num2 = (short)781123585;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
					{
						num2 = (short)20906055;
						short num3 = num2;
						num2 = (short)1672347719;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13F;
						default:
							num2 = (short)606208000;
							if (num2 != 0)
							{
							}
							num2 = (short)1824587780;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 6:
						goto IL_128;
					case 7:
						num4 = 1;
						num2 = (short)664469510;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						if (keySerialNumber != null)
						{
							num2 = (short)1076166657;
							if (num2 != 0)
							{
							}
							num2 = (short)1947336707;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_C7;
					case 9:
						if (keySerialNumber.Length == 8)
						{
							num2 = (short)1582891015;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_C7;
					}
					goto IL_49;
					IL_128:
					num2 = (short)409993218;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_13F:
					if (num4 >= keySerialNumber.Length - 1)
					{
						num2 = (short)2134638597;
						num = (int)((global::System.IntPtr)num2);
					}
					else
					{
						text += keySerialNumber[num4].ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮒ꞔ", a_));
						num4++;
						num2 = (short)1812398080;
						num = (int)((global::System.IntPtr)num2);
					}
				}
				IL_C7:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Unable_to_get_valid_Flashkey_Id);
				IL_208:
				goto IL_216;
				IL_49:
				keySerialNumber = A_0.GetKeySerialNumber();
				num2 = (short)959905800;
				num = (int)((global::System.IntPtr)num2);
				goto IL_1B;
			}
			catch (global::System.Exception)
			{
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Unable_to_get_valid_Flashkey_Id);
			}
			IL_216:
			num2 = (short)1605959680;
			short num5 = num2;
			return text;
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00137C80 File Offset: 0x00135E80
		private static void a(global::SpecialFeatures.Comms.RadioParams A_0, string A_1, string A_2)
		{
			short num = (short)1410793473;
			if (num != 0)
			{
			}
			num = (short)1110214469;
			short num2 = num;
			num = (short)1221232453;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1949696000;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1746599936;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.d(A_1, A_0.ModelNumber);
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.q();
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.p();
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.o();
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.a(A_2);
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.c(A_2, A_1, A_0.ModelNumber);
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.l();
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.k();
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.j();
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.i();
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.b(A_0.ModelNumber, A_2, A_0.HostVersion);
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.c(A_2, A_0.HostVersion);
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.b(A_2, A_0.HostVersion);
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.a(A_2, A_0.HostVersion);
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.n();
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.m();
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.g();
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.f();
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.a();
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00137DBC File Offset: 0x00135FBC
		private static void w()
		{
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_28;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (!string.IsNullOrEmpty(radioWide.Labtool.RadioWideReqFWVersion_A42872Value))
						{
							num2 = (short)860618754;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_131;
					}
					case 1:
						num2 = (short)1937506304;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						radioWide.Labtool.RadioWideReqFWVersion_A42872.SetValue("");
						num2 = (short)1835401221;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 3:
						goto IL_14A;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide != null)
						{
							num2 = (short)2141519873;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_131;
					}
					case 5:
						goto IL_131;
					}
					goto IL_28;
					IL_131:
					num2 = (short)2109997059;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_14A:
				goto IL_158;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
					num2 = (short)754371785;
					short num3 = num2;
					num2 = (short)1533005001;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_74;
					}
				}
				IL_74:
				num2 = (short)744357888;
				if (num2 != 0)
				{
				}
				num2 = (short)1080098820;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			catch (global::System.Exception)
			{
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Codeplug_upgrade_failed);
			}
			IL_158:
			num2 = (short)1153826817;
			if (num2 != 0)
			{
			}
			num2 = (short)738131968;
			short num4 = num2;
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00137F90 File Offset: 0x00136190
		private static void v()
		{
			short num = (short)1399390209;
			if (num != 0)
			{
			}
			num = (short)1594609703;
			short num2 = num;
			num = (short)731828263;
			switch (num2 == num)
			{
			default:
			{
				num = (short)38862848;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1489895424;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.u();
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x0013803C File Offset: 0x0013623C
		private static void u()
		{
			short num;
			try
			{
				num = (short)1728388306;
				short num2 = num;
				num = (short)1289821394;
				switch (num2 == num)
				{
				}
				num = (short)290586624;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
				int radInfoLabtoolProductModelIdentifier_A37178Value = radioInformation.Labtool.RadInfoLabtoolProductModelIdentifier_A37178Value;
				string radInfoGeneralModelNumber_A8539Value = radioInformation.General.RadInfoGeneralModelNumber_A8539Value;
				global::ConstraintHelper.UtilityMack.ProductModelId = radInfoLabtoolProductModelIdentifier_A37178Value.ToString();
			}
			catch (global::System.Exception)
			{
			}
			num = (short)1848901633;
			if (num != 0)
			{
			}
			num = (short)1313472512;
			short num3 = num;
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00138130 File Offset: 0x00136330
		private static void a(global::SpecialFeatures.Comms.IDeviceProxy A_0, global::SpecialFeatures.Comms.RadioParams A_1)
		{
			short num;
			try
			{
				num = (short)458215585;
				short num2 = num;
				num = (short)1843777697;
				switch (num2 == num)
				{
				}
				num = (short)105512961;
				if (num != 0)
				{
				}
				num = (short)1460928512;
				if (num != 0)
				{
				}
				A_0.ValidateUpdate(A_1, null);
			}
			catch (global::System.Exception)
			{
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Validation_Failed);
			}
			num = (short)1488060416;
			short num3 = num;
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00138200 File Offset: 0x00136400
		private static void a(global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager A_0)
		{
			short num = (short)2034565121;
			if (num != 0)
			{
			}
			if (!A_0.UpdateUpgradesRemCounter(1))
			{
				num = (short)1590521463;
				short num2 = num;
				num = (short)434400887;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num = (short)2131427328;
					short num3 = num;
					break;
				}
				}
				num = (short)43712512;
				if (num != 0)
				{
				}
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.FLASHkey_Validation_failed);
			}
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x001382C4 File Offset: 0x001364C4
		private static void a(global::Motorola.Common.Communication.CommonUtil.IshItemCollection A_0, string A_1)
		{
			short num = (short)395706368;
			switch (num)
			{
			default:
			{
				num = (short)242089986;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)262733824;
					short num3 = num;
					global::System.Collections.Generic.Dictionary<int, byte[]> dictionary;
					switch (num2)
					{
					case 0:
						try
						{
							new global::Motorola.MackinawCPS.CoreFeatures.PackExec.PackUnpackExecutor().Unpack(dictionary, A_1);
							return;
						}
						catch (global::System.Exception)
						{
							throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_unpack_the_radio_codeplug);
						}
						goto Block_3;
					case 1:
						goto IL_134;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 3:
						goto IL_94;
					}
					IL_7C:
					if (A_0 == null)
					{
						num = (short)516554755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.Generic.Dictionary<int, global::System.IO.MemoryStream> dictionary2 = new global::SpecialFeatures.Comms.CodeplugFormatConverter().Convert(A_0);
					dictionary = new global::System.Collections.Generic.Dictionary<int, byte[]>();
					global::System.Collections.Generic.Dictionary<int, global::System.IO.MemoryStream>.Enumerator enumerator = dictionary2.GetEnumerator();
					num = (short)349831169;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_3:
					try
					{
						IL_134:
						num = (short)1930297347;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								num = (short)1968796422;
								short num4 = num;
								num = (short)1138848518;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_149;
								default:
									num = (short)1668546560;
									if (num != 0)
									{
									}
									num = (short)1257308162;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								goto IL_249;
							case 3:
								goto IL_149;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)367656960;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<int, global::System.IO.MemoryStream> keyValuePair = enumerator.Current;
								byte[] buffer = keyValuePair.Value.GetBuffer();
								dictionary.Add(keyValuePair.Key, buffer);
								num = (short)171507713;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							goto IL_16E;
							IL_149:
							switch (0)
							{
							case 0:
								IL_16E:
								goto IL_170;
							}
							continue;
							IL_170:
							num = (short)157614084;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_249:
						goto IL_BD;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					return;
					IL_BD:
					num = (short)1856897024;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_94:
				num = (short)74448897;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentNullException(global::CommonResources.AppResources.collection_of_codeplug_items_is_null);
			}
			}
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00138564 File Offset: 0x00136764
		private static void b(global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager A_0, string A_1)
		{
			short num = (short)1612709892;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A2;
				case 1:
					goto IL_59;
				case 2:
				{
					char[] trimChars;
					string text;
					if (A_1.TrimEnd(trimChars) != text.TrimEnd(trimChars))
					{
						num = (short)745209859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 3:
					num = (short)2088239109;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 5:
				{
					char[] trimChars;
					string text2;
					if (A_1.TrimEnd(trimChars) != text2.TrimEnd(trimChars))
					{
						num = (short)379650048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				}
				IL_3C:
				if (string.IsNullOrEmpty(A_1))
				{
					num = (short)1754071041;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					string text = (string)A_0.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.Flashcode);
					string text2 = (string)A_0.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.FlashcodeNew);
					char[] trimChars = new char[]
					{
						'\0',
						' '
					};
					num = (short)1058603010;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_59:
			num = (short)1769340929;
			if (num != 0)
			{
			}
			throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Verify_Flashcode_Failed);
			IL_A2:
			num = (short)482574827;
			short num3 = num;
			num = (short)705266155;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_59;
			default:
			{
				num = (short)568721408;
				short num4 = num;
				num = (short)2137391104;
				if (num != 0)
				{
				}
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Radio_FLASHcode_does_not_match_FLASHkey_FLASHcode);
			}
			}
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x0013873C File Offset: 0x0013693C
		private static void a(global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager A_0, string A_1)
		{
			short num = (short)2021457923;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_CF;
				case 1:
					goto IL_12F;
				case 2:
					goto IL_9C;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				IL_35:
				char[] trimChars;
				if (!A_0.IsModelUpgradeKey())
				{
					trimChars = new char[]
					{
						'\0',
						' '
					};
					num = (short)2071003136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1209738960;
				short num3 = num;
				num = (short)217261776;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1180237824;
					if (num != 0)
					{
					}
					num = (short)1682767874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_CF:
				if (!(((string)A_0.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.ModelNumber)).TrimEnd(trimChars) != A_1.TrimEnd(trimChars)))
				{
					return;
				}
				num = (short)1423245313;
				if (num != 0)
				{
				}
				num = (short)686620673;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9C:
			num = (short)1698037760;
			short num4 = num;
			throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Model_Num_Upg_Not_Spt_This_Release);
			IL_12F:
			throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Radio_model_number_does_not_match_FLASHke_Model_Number);
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x001388B4 File Offset: 0x00136AB4
		private bool b(global::SpecialFeatures.Comms.RadioParams A_0, global::SpecialFeatures.Flashport.FlashRadio.MetadataFile A_1)
		{
			int a_ = 7;
			short num = (short)1365966848;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				string postBuildIncremental;
				string preBuildIncremental;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_E3;
					case 1:
						goto IL_10A;
					case 2:
						num = (short)1399717888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						string bpFirmware = A_1.BpFirmware;
						postBuildIncremental = A_1.PostBuildIncremental;
						preBuildIncremental = A_1.PreBuildIncremental;
						string radioBBFSuiteVersion;
						if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(bpFirmware, radioBBFSuiteVersion) >= 0)
						{
							num = (short)1177550850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)931659777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_47;
				}
				IL_E3:
				string hostVersion;
				bool flag = global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(postBuildIncremental, hostVersion) < 0;
				goto IL_180;
				IL_10A:
				num = (short)1438470854;
				short num3 = num;
				num = (short)1000231622;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_47:
					string radioBBFSuiteVersion = A_0.RadioBBFSuiteVersion;
					hostVersion = A_0.HostVersion;
					num = (short)1563820032;
					short num4 = num;
					num = (short)1791623171;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				default:
					num = (short)812580864;
					if (num != 0)
					{
					}
					num = (short)264437761;
					if (num != 0)
					{
					}
					flag = true;
					break;
				}
				IL_180:
				string text = A_1.OtaPackage.ToLower();
				bool flag2;
				if (!(text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾝ첟", a_)))
				{
					if (!(text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﲋ톍ﾙ", a_)))
					{
						flag2 = false;
						goto IL_1CE;
					}
				}
				flag2 = (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(preBuildIncremental, hostVersion) != 0);
				IL_1CE:
				bool flag3 = flag2;
				return flag || flag3;
			}
			}
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00138A94 File Offset: 0x00136C94
		private bool a(global::SpecialFeatures.Comms.RadioParams A_0, global::SpecialFeatures.Flashport.FlashRadio.MetadataFile A_1)
		{
			int a_ = 8;
			short num = (short)83427328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				string text;
				bool flag;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						num = (short)1597374467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!(text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﺞ춠", a_)))
						{
							num = (short)1785921536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DC;
					case 2:
						num = (short)699793413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!(text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﶌ킎ﺚ", a_)))
						{
							goto IL_1F1;
						}
						return flag;
					case 4:
						if (!(text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("﶐", a_)))
						{
							num = (short)310575110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DC;
					case 5:
					{
						num = (short)1664129176;
						short num3 = num;
						num = (short)961910936;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1F1;
						default:
							goto IL_12E;
						}
						break;
					}
					case 6:
						num = (short)1511129089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_53;
					IL_1F1:
					num = (short)2080047104;
					short num4 = num;
					num = (short)1909325826;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_DC:
				bool flag2;
				return flag || flag2;
				IL_12E:
				num = (short)949157889;
				if (num != 0)
				{
				}
				num = (short)337051648;
				if (num != 0)
				{
				}
				return false;
				IL_53:
				string radioBBFSuiteVersion = A_0.RadioBBFSuiteVersion;
				string hostVersion = A_0.HostVersion;
				string bpFirmware = A_1.BpFirmware;
				string postBuildIncremental = A_1.PostBuildIncremental;
				flag = (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(bpFirmware, radioBBFSuiteVersion) > 0);
				flag2 = (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(postBuildIncremental, hostVersion) > 0);
				text = A_1.OtaPackage.ToLower();
				num = (short)999489540;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00138CDC File Offset: 0x00136EDC
		private global::Motorola.Common.Communication.CommonUtil.IshItemCollection d(string A_0)
		{
			short num;
			global::Motorola.Acp.PackUnpack.Ish.Codeplug codeplug;
			try
			{
				num = (short)952238080;
				switch (num)
				{
				default:
					codeplug = new global::Motorola.MackinawCPS.CoreFeatures.PackExec.PackUnpackExecutor().Pack(A_0);
					goto IL_23B;
				}
			}
			catch (global::System.Exception ex)
			{
				if (ex.Message == global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write)
				{
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, ex.Message);
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write);
				}
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_pack_the_radio_codeplug);
			}
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection result;
			try
			{
				global::System.Collections.Generic.Dictionary<int, global::System.IO.MemoryStream> dictionary;
				for (;;)
				{
					IL_6C:
					dictionary = new global::System.Collections.Generic.Dictionary<int, global::System.IO.MemoryStream>();
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Partition> enumerator = codeplug.Partitions.GetEnumerator();
					try
					{
						num = (short)790036482;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)992673795;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_BB;
								}
								continue;
							case 3:
								goto IL_166;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)151257088;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Acp.PackUnpack.Ish.Partition partition = enumerator.Current;
								global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(partition.Image.GetBuffer());
								memoryStream.SetLength(partition.Image.Length);
								dictionary.Add((int)partition.PartitionType, memoryStream);
								num = (short)1038417921;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_BD:
							num = (short)1895890948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_BB:
							goto IL_BD;
						}
						IL_166:;
					}
					finally
					{
						num = (short)996147202;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)297074689;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_1D2;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_19A;
								}
								continue;
							}
							IL_19A:
							if (enumerator == null)
							{
								break;
							}
							num = (short)392232960;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1D2:;
					}
					num = (short)1920727142;
					short num3 = num;
					num = (short)439941222;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_20A;
					}
				}
				IL_20A:
				num = (short)847708160;
				if (num != 0)
				{
				}
				result = new global::SpecialFeatures.Comms.CodeplugFormatConverter().Convert(dictionary);
				goto IL_241;
			}
			catch (global::System.Exception)
			{
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_pack_the_radio_codeplug);
			}
			goto IL_23B;
			IL_241:
			num = (short)1528299520;
			short num4 = num;
			num = (short)648675329;
			if (num != 0)
			{
			}
			return result;
			IL_23B:
			goto IL_6C;
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00138FCC File Offset: 0x001371CC
		private static void c(string A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (modelTiering.FindModel(A_0))
					{
						num2 = (short)473501505;
						short num3 = num2;
						num2 = (short)535170881;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_144;
						}
					}
					num2 = (short)1619525632;
					short num4 = num2;
					num2 = (short)1601634305;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_A0;
				case 2:
					try
					{
						modelTiering = new global::SpecialFeatures.Model_Configuration.ModelTiering(A_0, global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.FLASHPORT, global::SpecialFeatures.Model_Configuration.ModelTiering.TargetTypes.ALL, false);
						goto IL_3E;
					}
					catch (global::System.Exception)
					{
						global::System.Windows.Forms.MessageBox.Show(global::CommonResources.AppResources.Internal_Error_Critical_File_Mis_Crpt_0xFCF01);
						global::System.Environment.Exit(1036033);
						goto IL_3E;
					}
					goto IL_F6;
					IL_3E:
					num2 = (short)1036058624;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_A0:
			num2 = (short)1949499393;
			if (num2 != 0)
			{
			}
			IL_F6:
			throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Not_Found_In_Model_Tiering_Database.AcpStringFormat(new object[]
			{
				A_0
			}));
			IL_144:
			num2 = (short)243204096;
			if (num2 != 0)
			{
			}
			global::AcpCommonLib.ConstraintManager.Suspend();
			modelTiering.ApplyTiering(true);
			global::AcpCommonLib.ConstraintManager.Resume();
			return;
			IL_1C:
			string empty = string.Empty;
			modelTiering = null;
			num2 = (short)1577451522;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00139154 File Offset: 0x00137354
		private global::SpecialFeatures.Comms.IDeviceProxy t()
		{
			short num = (short)1969525754;
			short num2 = num;
			num = (short)1818661882;
			switch (num2 == num)
			{
			}
			num = (short)335282176;
			short num3 = num;
			num = (short)1677393921;
			if (num != 0)
			{
			}
			num = (short)1799553024;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Comms.RadioParams radioPara = new global::SpecialFeatures.Comms.RadioParams
			{
				Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio,
				ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo
				{
					ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter
				}
			};
			return global::SpecialFeatures.Comms.DeviceManagerSingleTon.Instance.CreateDeviceProxy(radioPara, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0013922C File Offset: 0x0013742C
		private static void a(global::SpecialFeatures.Comms.RadioParams A_0)
		{
			short num = (short)1963655169;
			if (num != 0)
			{
			}
			string codeplugVersion = A_0.CodeplugVersion;
			if (!global::AcpBusinessLayer.AcpDocument.ValidCodeplugVersion(codeplugVersion))
			{
				num = (short)1048989477;
				short num2 = num;
				num = (short)742412069;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1051131904;
					if (num != 0)
					{
					}
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Unable_to_flash_radio_Requires_CPS_version.AcpStringFormat(new object[]
					{
						codeplugVersion
					}));
				}
			}
			num = (short)1099759616;
			short num3 = num;
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00139304 File Offset: 0x00137504
		private static string a(global::Motorola.Common.Communication.Pba.PbaObject A_0)
		{
			short num = (short)860487682;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_51;
				case 1:
					goto IL_C6;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = A_0.GetCodeplugInIshItemCollection();
				if (codeplugInIshItemCollection == null)
				{
					num = (short)1654128640;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::Motorola.Common.Communication.CommonUtil.IshItem value = codeplugInIshItemCollection.FirstOrDefault(delegate(global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> it)
					{
						short num5 = (short)1004284738;
						short num6 = num5;
						num5 = (short)1544563522;
						switch (num6 == num5)
						{
						}
						num5 = (short)571670528;
						if (num5 != 0)
						{
						}
						num5 = (short)337838081;
						if (num5 != 0)
						{
						}
						num5 = (short)1770651648;
						short num7 = num5;
						return it.Key.IshType == 901;
					}).Value;
					num = (short)1256914945;
					if (num != 0)
					{
					}
					num = (short)188088321;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_51:
			byte[] a_ = null;
			goto IL_145;
			IL_C6:
			num = (short)1778469189;
			short num3 = num;
			num = (short)387795269;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_51;
			default:
			{
				num = (short)63045632;
				if (num != 0)
				{
				}
				num = (short)553451520;
				short num4 = num;
				global::Motorola.Common.Communication.CommonUtil.IshItem value;
				a_ = value.Data;
				break;
			}
			}
			IL_145:
			return global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.a(a_);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x0013945C File Offset: 0x0013765C
		private static string a(byte[] A_0)
		{
			short num = (short)1632501763;
			int num2 = (int)((global::System.IntPtr)num);
			byte[] array;
			for (;;)
			{
				int sourceIndex;
				switch (num2)
				{
				case 0:
					if (A_0.Length == 16)
					{
						num = (short)1161297921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_149;
				case 1:
				{
					num = (short)1295088467;
					short num3 = num;
					num = (short)1398373203;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_149;
					default:
						num = (short)1539375104;
						if (num != 0)
						{
						}
						global::System.Array.Copy(A_0, sourceIndex, array, 0, 12);
						num = (short)851836932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_196;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 4:
					goto IL_C8;
				case 5:
					goto IL_57;
				}
				IL_3D:
				if (A_0 == null)
				{
					num = (short)1187053573;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				sourceIndex = 2;
				array = global::System.Linq.Enumerable.Repeat<byte>(0, 24).ToArray<byte>();
				num = (short)1151598592;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_149:
				global::System.Array.Copy(A_0, sourceIndex, array, 0, 24);
				num = (short)33947648;
				short num4 = num;
				num = (short)1307508738;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_57:
			throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Invalid_Radio_Codeplug_Data);
			IL_C8:
			num = (short)1531379713;
			if (num != 0)
			{
			}
			IL_196:
			return global::SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(array, array.Length);
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x0013960C File Offset: 0x0013780C
		private static void b(string A_0)
		{
			short num = (short)1963458563;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					while (global::SpecialFeatures.Flashport.FlashRadio.SerialNumberValidator.ValidateSerialNumber(A_0))
					{
						num = (short)16993274;
						short num3 = num;
						num = (short)1737182202;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_124;
						}
					}
					num = (short)421265409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_BC;
				case 2:
					goto IL_51;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				}
				IL_34:
				if (global::SpecialFeatures.Flashport.FlashRadio.SerialNumberValidator.IsCBISerialNumber(A_0))
				{
					num = (short)139067394;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)956104704;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_51:
			num = (short)423559168;
			short num4 = num;
			throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Radio_has_CBI_serial_number);
			IL_BC:
			num = (short)2007433217;
			if (num != 0)
			{
			}
			throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Radio_contains_an_invalid_serial_number);
			IL_124:
			num = (short)1724579840;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00139754 File Offset: 0x00137954
		private static void d(string A_0, string A_1)
		{
			int a_ = 8;
			short num = (short)184549376;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5B;
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset dataProfilesRecset;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dataProfilesRecset.GetEnumerator();
						num = (short)339673096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)556335107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
					{
						global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable();
						flashcodeTable.InitTable(true, A_1, false);
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
						bool flag = false;
						string name = global::ConstraintHelper.UtilityMack.IsPortable() ? global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔꞖ", a_) : global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꖔꆖ", a_);
						if (flashcodeTable.IsOptionEnabledInFlashcode(name, A_0, ref flag))
						{
							radioInformation.FrequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481Value = true;
						}
						bool flag2 = false;
						name = (global::ConstraintHelper.UtilityMack.IsPortable() ? global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔꚖ", a_) : global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꆔꚖ", a_));
						if (flashcodeTable.IsOptionEnabledInFlashcode(name, A_0, ref flag2))
						{
							radioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504Value = true;
						}
						bool flag3 = false;
						name = (global::ConstraintHelper.UtilityMack.IsPortable() ? global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔꖖ", a_) : global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꆔꊖ", a_));
						if (flashcodeTable.IsOptionEnabledInFlashcode(name, A_0, ref flag3))
						{
							radioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507Value = true;
						}
						bool flag4 = false;
						name = (global::ConstraintHelper.UtilityMack.IsPortable() ? global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꎔ꺖", a_) : global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꆒꆔꎖ", a_));
						if (flashcodeTable.IsOptionEnabledInFlashcode(name, A_0, ref flag4))
						{
							num = (short)2101608453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 3:
						num = (short)123600898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return;
					case 5:
					{
						num = (short)50659329;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						radioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551Value = true;
						radioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552Value = true;
						num = (short)626327552;
						short num3 = num;
						num = (short)628031492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (dataProfilesRecset != null)
						{
							num = (short)1712062464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33F;
					case 7:
						try
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0];
							((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInner)(((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide)[10636] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplit).EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerRecset)[2]).FCCNarrowBandingFrequencySplitInnerSection.RadWideLabtoolFCCNarrowBandEndFrequency_A38271.SetValue(94000000);
						}
						catch (global::System.Exception)
						{
						}
						num = (short)1174274049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						try
						{
							num = (short)1388445704;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2D0;
								case 1:
								{
									int num4;
									if (num4.Equals(3))
									{
										num = (short)219742212;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)1463091200;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									int num4;
									if (num4.Equals(0))
									{
										num = (short)1151205386;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									dataProfiles.Features.DataProfFeaturesARSMode_A7465.SetValue(0);
									num = (short)1490681863;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1623588866;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)enumerator.Current;
									int num4 = dataProfiles.General.DataProfGeneralDataProfileType_A21320Value;
									num = (short)1764556803;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									int num4;
									if (num4.Equals(0))
									{
										num = (short)584646665;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_112;
									}
									continue;
								case 9:
								{
									num = (short)1264757930;
									short num5 = num;
									num = (short)1398189226;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
									{
										num = (short)1488060416;
										if (num != 0)
										{
										}
										global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
										int num4 = dataProfiles.Features.DataProfFeaturesARSMode_A7465Value;
										num = (short)757334017;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									int num4 = dataProfiles.General.DataProfGeneralPacketDataMode_A8689Value;
									num = (short)1420951558;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1B1:
								num = (short)1452146693;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_112:
								goto IL_1B1;
							}
							IL_2D0:;
						}
						finally
						{
							num = (short)2081751042;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1861615617;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_33C;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_305;
									}
									continue;
								}
								IL_305:
								if (enumerator == null)
								{
									break;
								}
								num = (short)854458368;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_33C:;
						}
						goto IL_33F;
					}
					goto IL_5B;
					IL_33F:
					num = (short)21757959;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_5B:
				dataProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset);
				num = (short)723582982;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00139D8C File Offset: 0x00137F8C
		private static int s()
		{
			short num = (short)811991041;
			if (num != 0)
			{
			}
			num = (short)2045310408;
			short num2 = num;
			num = (short)1851520456;
			int result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1375666176;
				if (num != 0)
				{
				}
				result = 0;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_9E;
					}
					int num3;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					for (;;)
					{
						IL_80:
						switch (num3)
						{
						case 0:
						{
							string radInfoGeneralCodeplugVersion_A7683_UIValue;
							result = int.Parse(radInfoGeneralCodeplugVersion_A7683_UIValue.Substring(1, 2).ToString());
							num = (short)1438777345;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_159;
						case 2:
							goto IL_170;
						case 3:
							if (radioInformation != null)
							{
								num = (short)812449797;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_159;
						case 4:
						{
							string radInfoGeneralCodeplugVersion_A7683_UIValue;
							if (radInfoGeneralCodeplugVersion_A7683_UIValue.Length > 2)
							{
								num = (short)1430978560;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_159;
						}
						case 5:
						{
							string radInfoGeneralCodeplugVersion_A7683_UIValue = radioInformation.General.RadInfoGeneralCodeplugVersion_A7683_UIValue;
							num = (short)1300103172;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_9E;
						IL_159:
						num = (short)1632239618;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_170:
					break;
					IL_9E:
					radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
					num = (short)937558019;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_80;
				}
				catch
				{
				}
				break;
			}
			num = (short)1459814400;
			short num4 = num;
			return result;
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00139F48 File Offset: 0x00138148
		private static int r()
		{
			short num = (short)1984642594;
			short num2 = num;
			num = (short)1105083938;
			int result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)368967680;
				if (num != 0)
				{
				}
				result = 0;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_75;
					}
					int num3;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					for (;;)
					{
						IL_57:
						switch (num3)
						{
						case 0:
							goto IL_16D;
						case 1:
						{
							string radInfoGeneralCodeplugVersion_A7683_UIValue = radioInformation.General.RadInfoGeneralCodeplugVersion_A7683_UIValue;
							num = (short)191365121;
							if (num != 0)
							{
							}
							num = (short)866779138;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							string radInfoGeneralCodeplugVersion_A7683_UIValue;
							if (radInfoGeneralCodeplugVersion_A7683_UIValue.Length > 5)
							{
								num = (short)167378949;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_156;
						}
						case 3:
							goto IL_156;
						case 4:
							if (radioInformation != null)
							{
								num = (short)365035521;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_156;
						case 5:
						{
							string radInfoGeneralCodeplugVersion_A7683_UIValue;
							result = int.Parse(radInfoGeneralCodeplugVersion_A7683_UIValue.Substring(4, 2).ToString());
							num = (short)796786691;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_75;
						IL_156:
						num = (short)1088815104;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_16D:
					break;
					IL_75:
					radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
					num = (short)810680324;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_57;
				}
				catch
				{
				}
				break;
			}
			num = (short)573308928;
			short num4 = num;
			return result;
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x0013A110 File Offset: 0x00138310
		private static void q()
		{
			short num = (short)730923008;
			switch (num)
			{
			default:
			{
				num = (short)475004935;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
					switch (num2)
					{
					case 0:
						if (radioProfilesRecset != null)
						{
							num = (short)1150550016;
							short num3 = num;
							num = (short)1552351236;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_3D1;
					case 2:
						if (global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.r() < 1)
						{
							num = (short)1778909185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						if (global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.s() == 13)
						{
							num = (short)641466376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = radioProfilesRecset.GetEnumerator();
						num = (short)753008645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						try
						{
							num = (short)803274755;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
								switch (num2)
								{
								case 0:
									goto IL_311;
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)1535639556;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2CB;
								case 2:
									try
									{
										num = (short)527302661;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_25B;
											case 1:
											{
												if (!enumerator2.MoveNext())
												{
													num = (short)763953154;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings = enumerator2.Current as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings;
												num = (short)492961795;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												num = (short)1181745152;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings != null)
												{
													num = (short)1710292998;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 4:
												goto IL_23D;
											case 5:
												switch (0)
												{
												case 0:
													goto IL_14B;
												}
												continue;
											case 6:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												audioSettings.NoiseReductionGroupSettingRadio_42584.Value = 4;
												audioSettings.NoiseReductionGroupSettingAccessory_42585.Value = 4;
												audioSettings.GainSensitivityGroupSettingRadio_42608.Value = 4;
												audioSettings.GainSensitivityGroupSettingAccessory_42610.Value = 4;
												audioSettings.AudioEqualizationGroupSettingRadio_42604.Value = 4;
												audioSettings.AudioEqualizationGroupSettingAccessory_42605.Value = 4;
												audioSettings.AudioEqualizationGroupSettingRadio_42613.Value = 4;
												audioSettings.AudioEqualizationGroupSettingAccessory_42614.Value = 4;
												num = (short)1018363908;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_14D:
											num = (short)626393089;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_14B:
											goto IL_14D;
										}
										IL_23D:
										IL_25B:
										break;
									}
									finally
									{
										num = (short)861274113;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_2C8;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_292;
												}
												continue;
											case 2:
												enumerator2.Dispose();
												num = (short)636616704;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_292:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)837877762;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_2C8:;
									}
									goto IL_2CB;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_C9;
									}
									continue;
								case 4:
									num = (short)161546240;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_CE:
								num = (short)525008897;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C9:
								goto IL_CE;
								IL_2CB:
								enumerator2 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current).FeatureSectionsCollection.GetEnumerator();
								num = (short)31784962;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_311:
							return;
						}
						finally
						{
							num = (short)1350500353;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)1062572116;
								short num4 = num;
								num = (short)1172213844;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_3CE;
								default:
								{
									num = (short)2045706240;
									if (num != 0)
									{
									}
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_3CE;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_395;
										}
										continue;
									case 2:
										enumerator.Dispose();
										num = (short)181141504;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_395:
									if (enumerator == null)
									{
										goto IL_3D0;
									}
									num = (short)1752039426;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
								}
							}
							IL_3CE:
							IL_3D0:;
						}
						goto IL_3D1;
					case 6:
						num = (short)621412355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_69;
						}
						continue;
					case 8:
						num = (short)347013122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_69:
					if (global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.s() >= 13)
					{
						num = (short)1257177094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3D1:
					radioProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2077) as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset);
					num = (short)1198653441;
					if (num != 0)
					{
					}
					num = (short)558759936;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x0013A664 File Offset: 0x00138864
		private static void p()
		{
			short num = (short)631504896;
			switch (num)
			{
			default:
			{
				num = (short)266862599;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
					switch (num2)
					{
					case 0:
						if (radioProfilesRecset != null)
						{
							num = (short)669843460;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_585;
					case 2:
						if (global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.r() < 1)
						{
							num = (short)323878913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						if (global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.s() == 13)
						{
							num = (short)1807286280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
					{
						num = (short)906362880;
						short num3 = num;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = radioProfilesRecset.GetEnumerator();
						num = (short)1579220997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						try
						{
							num = (short)1561067528;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
								global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA labtoolRAD_PROF_CDA;
								switch (num2)
								{
								case 0:
									num = (short)2134507524;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									try
									{
										num = (short)1186594824;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
												audioSettings = (acpFeatureSection as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
												num = (short)1858338818;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												goto IL_21E;
											case 3:
												num = (short)107216900;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												goto IL_2E2;
											case 5:
											{
												global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
												if (acpFeatureSection.GetType().Equals(typeof(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA)))
												{
													num = (short)1343488009;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 6:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)121044995;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = enumerator2.Current;
												num = (short)41680903;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 7:
											{
												global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
												if (acpFeatureSection.GetType().Equals(typeof(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings)))
												{
													num = (short)1792147456;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_21E;
											}
											case 8:
												switch (0)
												{
												case 0:
													goto IL_1AA;
												}
												continue;
											case 9:
											{
												global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
												labtoolRAD_PROF_CDA = (acpFeatureSection as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA);
												num = (short)396951553;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											goto IL_1AA;
											IL_21E:
											num = (short)1678770181;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_268:
											num = (short)1890975750;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1AA:
											goto IL_268;
										}
										IL_2E2:
										goto IL_11F;
									}
									finally
									{
										num = (short)1053884417;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
											switch (num2)
											{
											case 0:
												goto IL_353;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_31B;
												}
												continue;
											case 2:
												enumerator2.Dispose();
												num = (short)1204682752;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_31B:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)834666498;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_353:;
									}
									goto IL_356;
									IL_11F:
									num = (short)251592706;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (audioSettings != null)
									{
										num = (short)1436352517;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									goto IL_356;
								case 4:
									goto IL_4C3;
								case 5:
									num = (short)1703936006;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (labtoolRAD_PROF_CDA != null)
									{
										num = (short)448528387;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1385037824;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									audioSettings = null;
									labtoolRAD_PROF_CDA = null;
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2 = acpFeatureNode.FeatureSectionsCollection.GetEnumerator();
									num = (short)96403457;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_DE;
									}
									continue;
								}
								IL_E3:
								num = (short)1641152519;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_DE:
								goto IL_E3;
								IL_356:
								audioSettings.AGCGainControlOutputAccessory_42644.Value = audioSettings.RadProfAudioSettingsOutput_A8679.Value;
								audioSettings.AGCGainControlTotalAccessory_42645.Value = audioSettings.RadProfAudioSettingsTotal_A9394.Value;
								audioSettings.RadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661.Value = audioSettings.RadioProfileAudioSettingsTxDigitalAnalogBalance_A37715.Value;
								audioSettings.AnalogHighFrequencyBandAccessory_42650.Value = audioSettings.RadProfAudioSettingsAnalog_A7438.Value;
								audioSettings.DigitalHighFrequencyBandAccessory_42655.Value = audioSettings.RadProfAudioSettingsDigital_A7850.Value;
								audioSettings.SecurenetHighFrequencyBandAccessory_42660.Value = audioSettings.RadProfAudioSettingsSecurenet_A9097.Value;
								audioSettings.AnalogLowFrequencyBandAccessory_42647.Value = labtoolRAD_PROF_CDA.RadProfLabtoolAnalogBassControl_A19506.Value;
								audioSettings.DigitalLowFrequencyBandAccessory_42652.Value = labtoolRAD_PROF_CDA.RadProfLabtoolDigitalBassControl_A19507.Value;
								audioSettings.SecurenetLowFrequencyBandAccessory_42657.Value = labtoolRAD_PROF_CDA.RadProfLabtoolSecurenetBassControl_A19508.Value;
								num = (short)1391919113;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4C3:
							return;
						}
						finally
						{
							num = (short)204013569;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)807512576;
								short num4 = num;
								num = (short)846506496;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_582;
								default:
								{
									num = (short)796786688;
									if (num != 0)
									{
									}
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_582;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_547;
										}
										continue;
									case 2:
										enumerator.Dispose();
										num = (short)298319872;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_547:
									if (enumerator == null)
									{
										goto IL_584;
									}
									num = (short)1379336194;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
								}
							}
							IL_582:
							IL_584:;
						}
						goto IL_585;
					case 6:
						num = (short)1292042243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_68;
						}
						continue;
					case 8:
						num = (short)463994881;
						if (num != 0)
						{
						}
						num = (short)1353973762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_68:
					if (global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.s() >= 13)
					{
						num = (short)482344966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_585:
					radioProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2077) as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset);
					num = (short)9830400;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x0013AD6C File Offset: 0x00138F6C
		private static void o()
		{
			int a_ = 16;
			short num = (short)255655936;
			switch (num)
			{
			default:
			{
				num = (short)1670840321;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)2075983875;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_8BF;
								case 1:
									try
									{
										num = (short)819986456;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_836;
											case 2:
												num = (short)1817247777;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.RadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194.Value == 0)
												{
													num = (short)386007071;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_49B;
											}
											case 4:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1930821649;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings;
												num = (short)143654922;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												audioSettings.NoiseReductionGroupSettingAccessory_42585.Value = 4;
												num = (short)361365526;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.NoiseReductionGroupSettingAccessory_42585.Value != 2)
												{
													num = (short)922222606;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_5DE;
											}
											case 7:
												goto IL_413;
											case 8:
												num = (short)2035089414;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 9:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.RadProfExternalMicWindNoiseReductionLevelSelection_A21511.Value == 0)
												{
													num = (short)794558469;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_50D;
											}
											case 10:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings != null)
												{
													num = (short)2055667744;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 11:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (!audioSettings.RadProfAudioSettingsAnalogAGC2_A7439.Value)
												{
													num = (short)2136670227;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 12:
												goto IL_49B;
											case 13:
												goto IL_555;
											case 14:
												num = (short)1856241692;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 15:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (!audioSettings.RadProfAudioSettingsAnalogAGC1_A7440.Value)
												{
													num = (short)1036189719;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_555;
											}
											case 16:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.NoiseReductionGroupSettingRadio_42584.Value == 3)
												{
													num = (short)265420807;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_49B;
											}
											case 17:
												num = (short)162594816;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 18:
												num = (short)98959371;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 19:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												audioSettings.GainSensitivityGroupSettingAccessory_42610.Value = 4;
												num = (short)349306881;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 20:
												goto IL_5DE;
											case 21:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.NoiseReductionGroupSettingAccessory_42585.Value != 0)
												{
													num = (short)2071789576;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_5DE;
											}
											case 22:
												goto IL_50D;
											case 23:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												audioSettings.GainSensitivityGroupSettingRadio_42608.Value = 4;
												num = (short)2013462541;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 24:
												switch (0)
												{
												case 0:
													goto IL_399;
												}
												continue;
											case 25:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.GainSensitivityGroupSettingRadio_42608.Value == 0)
												{
													num = (short)1449394203;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_555;
											}
											case 26:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.GainSensitivityGroupSettingAccessory_42610.Value == 0)
												{
													num = (short)1973026834;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 27:
												num = (short)1846673423;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 28:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.NoiseReductionGroupSettingAccessory_42585.Value == 3)
												{
													num = (short)53739540;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_50D;
											}
											case 29:
												num = (short)1914372112;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 30:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.NoiseReductionGroupSettingRadio_42584.Value != 0)
												{
													num = (short)1515520002;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_413;
											}
											case 31:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												audioSettings.NoiseReductionGroupSettingRadio_42584.Value = 4;
												num = (short)615776268;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 32:
												num = (short)1242431518;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 33:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.NoiseReductionGroupSettingRadio_42584.Value != 2)
												{
													num = (short)2099380253;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_413;
											}
											}
											goto IL_399;
											IL_413:
											num = (short)1689780227;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_49B:
											num = (short)1538654233;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_50D:
											num = (short)1484849178;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_555:
											num = (short)1196294165;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_5DE:
											num = (short)1459748873;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_7B5:
											num = (short)363069444;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_399:
											goto IL_7B5;
										}
										IL_836:
										break;
									}
									finally
									{
										num = (short)486604800;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_86D;
												}
												continue;
											case 1:
												goto IL_8A4;
											case 2:
												enumerator.Dispose();
												num = (short)345899009;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_86D:
											if (enumerator == null)
											{
												break;
											}
											num = (short)870121474;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_8A4:;
									}
									goto IL_8A7;
								case 2:
									goto IL_8A7;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_231;
									}
									continue;
								case 4:
								{
									num = (short)736590946;
									short num3 = num;
									num = (short)487095394;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
									{
										num = (short)145752064;
										if (num != 0)
										{
										}
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
										if (enumerator2.MoveNext())
										{
											global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = ((global::AcpCommonLib.IAcpFeatureNode)enumerator2.Current).FeatureSectionsCollection.GetEnumerator();
											num = (short)1166016513;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									num = (short)1690238978;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_262:
								num = (short)391839748;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_231:
								goto IL_262;
								IL_8A7:
								num = (short)1173618688;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8BF:
							return;
						}
						finally
						{
							num = (short)872808448;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_8F6;
									}
									continue;
								case 1:
									goto IL_92D;
								case 2:
									enumerator2.Dispose();
									num = (short)1168441345;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_8F6:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)227147778;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_92D:;
						}
						goto IL_930;
					case 1:
					{
						num = (short)2098200576;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_A1;
						}
						continue;
					}
					case 2:
					{
						num = (short)411369473;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
						if (radioProfilesRecset != null)
						{
							num = (short)1179779075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = radioProfilesRecset.GetEnumerator();
						num = (short)616038400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						string radInfoGeneralModelNumber_A8539Value = radioInformation.General.RadInfoGeneralModelNumber_A8539Value;
						num = (short)116457478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset = global::AcpCommonLib.FeatureManager.GetFeature(2077) as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset;
						num = (short)392953858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						string radInfoGeneralModelNumber_A8539Value;
						if (radInfoGeneralModelNumber_A8539Value != null)
						{
							num = (short)1286275082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						if (radioInformation != null)
						{
							num = (short)1845035012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 8:
					{
						string radInfoGeneralModelNumber_A8539Value;
						if (radInfoGeneralModelNumber_A8539Value.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf92ꚔꞖ", a_)))
						{
							num = (short)1648754693;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
						num = (short)1509359623;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_930;
					}
					IL_A1:
					if (global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.s() < 15)
					{
						num = (short)77463561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_930:
					num = (short)2022637576;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x0013B72C File Offset: 0x0013992C
		private static void n()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_1F0;
				case 1:
					radioWide.Features.ZnChanCfgFPPProtectionFPPEnable_A8142.Value = false;
					num2 = (short)633667590;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)1340997636;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)897449985;
					if (num2 != 0)
					{
					}
					num2 = (short)1695940608;
					short num3 = num2;
					if ((global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799)
					{
						num2 = (short)1352138754;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 4:
					if (radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsProtectedZonePassword_A8766 == string.Empty)
					{
						num2 = (short)1758920704;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					if (radioWide.Features.ZnChanCfgFPPProtectionFPPEnable_A8142)
					{
						num2 = (short)1939341313;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 6:
					goto IL_15E;
				}
				goto IL_2C;
			}
			IL_15E:
			return;
			IL_1F0:
			goto IL_163;
			IL_2C:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)1346045855;
			short num4 = num2;
			num2 = (short)227215263;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_163:
				num2 = (short)398327813;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)500236288;
				if (num2 != 0)
				{
				}
				num2 = (short)1411252227;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x0013B930 File Offset: 0x00139B30
		private static void m()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num)
				{
				case 0:
					goto IL_1C1;
				case 1:
					radioProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2077) as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset);
					num2 = (short)1246953476;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)460193792;
					short num3 = num2;
					num2 = (short)648895311;
					short num4 = num2;
					num2 = (short)2068536143;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_56;
					default:
						num2 = (short)323616768;
						if (num2 != 0)
						{
						}
						num2 = (short)2106130437;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					goto IL_56;
				case 4:
					if (radioProfilesRecset != null)
					{
						num2 = (short)1136263168;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					if (radioWide.Labtool.RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548Value)
					{
						num2 = (short)1062535169;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 6:
					try
					{
						num2 = (short)1974075393;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								if (!enumerator.MoveNext())
								{
									num2 = (short)856424452;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								((global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles)enumerator.Current).AudioSettings.RadProfExternalMicWindNoiseReductionLevelSelection_A21511.SetValue(0);
								num2 = (short)925106178;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_D7;
								}
								continue;
							case 3:
								goto IL_154;
							case 4:
								num2 = (short)2121400323;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_D9:
							num2 = (short)284164096;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_D7:
							goto IL_D9;
						}
						IL_154:
						return;
					}
					finally
					{
						num2 = (short)355074048;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_189;
								}
								continue;
							case 1:
								goto IL_1BE;
							case 2:
								enumerator.Dispose();
								num2 = (short)203358209;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_189:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1730609154;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_1BE:;
					}
					goto IL_1C1;
				}
				goto IL_2C;
				IL_56:
				if (radioWide != null)
				{
					num2 = (short)1283325954;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				break;
				IL_1C1:
				num2 = (short)1795555329;
				if (num2 != 0)
				{
				}
				enumerator = radioProfilesRecset.GetEnumerator();
				num2 = (short)421330950;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2C:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)1320026115;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x0013BC28 File Offset: 0x00139E28
		private static void l()
		{
			short num = (short)1398538240;
			switch (num)
			{
			default:
			{
				num = (short)755761163;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					bool flag;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					bool flag2;
					bool flag3;
					switch (num2)
					{
					case 0:
						if (actionConsolidationRecset != null)
						{
							num = (short)646971394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
					{
						num = (short)1961032581;
						short num3 = num;
						num = (short)518519685;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5A2;
						default:
							num = (short)1632960512;
							if (num != 0)
							{
							}
							flag = radioInformation.Labtool.RadInfoLabtoolQ445FiregroundSupport_A8796.Value;
							goto IL_3DB;
						}
						break;
					}
					case 2:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = actionConsolidationRecset.GetEnumerator();
						num = (short)1620574216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_5A2;
					case 4:
						num = (short)532807689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1960181761;
						if (num != 0)
						{
						}
						goto IL_3AD;
					case 6:
						if (radioWide != null)
						{
							num = (short)2077949964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AD;
					case 7:
						flag = false;
						goto IL_3DB;
					case 8:
						try
						{
							num = (short)1820131334;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
									actionConsolidation.General.RadioErgoConfigACActionType_A42871.SetValue(3);
									num = (short)348061699;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)128385031;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1415512069;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation = (global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation)enumerator.Current;
									num = (short)245694472;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
									actionConsolidation.General.RadioErgoConfigACActionType_A42871.SetValue(1);
									num = (short)1610416139;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1992556554;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_1C4;
									}
									continue;
								case 7:
									if (flag2)
									{
										num = (short)1071710212;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1407909897;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
									if (actionConsolidation.General.RadioErgoConfigACActionType_A42871.Value == 0)
									{
										num = (short)1848180737;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									if (flag3)
									{
										num = (short)1568866304;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 10:
									goto IL_33B;
								}
								IL_2B6:
								num = (short)786300930;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1C4:
								goto IL_2B6;
							}
							IL_33B:
							return;
						}
						finally
						{
							num = (short)2134179840;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_373;
									}
									continue;
								case 1:
									goto IL_3AA;
								case 2:
									enumerator.Dispose();
									num = (short)1668939777;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_373:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1944518658;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3AA:;
						}
						goto IL_3AD;
					case 9:
						if (radioWide.Labtool.RadWideLabtoolPAAlertCapability_A42944.Value)
						{
							num = (short)63832078;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2137980935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (radioInformation != null)
						{
							num = (short)1789919237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11A;
					case 11:
						switch (0)
						{
						case 0:
							goto IL_89;
						}
						continue;
					case 12:
						num = (short)2107834371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						flag3 = false;
						flag2 = false;
						radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
						num = (short)1620705280;
						short num4 = num;
						num = (short)1613824010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						num = (short)1505951745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_AD;
					case 16:
						goto IL_11A;
					}
					IL_89:
					if (global::ConstraintHelper.UtilityMack.IsPortable())
					{
						num = (short)526581773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_AD:
					actionConsolidationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset);
					num = (short)71303168;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A2:
					if (radioInformation != null)
					{
						num = (short)1964441604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AD;
					IL_11A:
					radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					num = (short)1444347910;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3AD:
					flag2 = radioInformation.Labtool.RadInfoLabtoolMissionCriticalGeofencing_A43013.Value;
					num = (short)1020592144;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3DB:
					flag3 = flag;
					num = (short)2014773263;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x0013C218 File Offset: 0x0013A418
		private static void k()
		{
			short num = (short)1282277377;
			if (num != 0)
			{
			}
			num = (short)147193859;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				switch (num2)
				{
				case 0:
					if (radioWide.Bluetooth.RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.Value)
					{
						num = (short)688979973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					radioErgonomicsWide.Advanced.RadErgoWideAdvancedActiveMicForBTPTT_43051.SetValue(3);
					num = (short)1040121860;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1690632192;
					short num3 = num;
					num = (short)1064370176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.s() < 15)
					{
						num = (short)233046022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
				{
					num = (short)744462291;
					short num4 = num;
					num = (short)822056915;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_20D;
					default:
						num = (short)1794375680;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_BD;
						}
						continue;
					}
					break;
				}
				case 4:
					return;
				case 5:
					goto IL_15F;
				case 6:
					radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					radioErgonomicsWide = (global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
					num = (short)456917000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)460587010;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_20D;
				}
				IL_BD:
				if (global::ConstraintHelper.UtilityMack.IsPortable())
				{
					num = (short)1518731271;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_20D:
				if (!radioWide.Labtool.RadWideLabtoolActiveMicForBTPTTCapable_43053.Value)
				{
					return;
				}
				num = (short)1522597889;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_15F:
			radioErgonomicsWide.Advanced.RadErgoWideAdvancedActiveMicForBTPTT_43051.SetValue(2);
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x0013C464 File Offset: 0x0013A664
		private static void j()
		{
			switch (0)
			{
			case 0:
				goto IL_81;
			}
			short num;
			int num3;
			string value;
			for (;;)
			{
				IL_0A:
				num = (short)636122706;
				short num2 = num;
				num = (short)612529746;
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)425263104;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						if (secureWide.General.SecWideGeneralSecureOperation_A9067.Value == 3)
						{
							num = (short)549191685;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
						if (int.Parse(value.Substring(1, 2)) < 16)
						{
							num = (short)568590342;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						if (value != null)
						{
							num = (short)571736071;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						if (value.Length > 3)
						{
							num = (short)1901789192;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						goto IL_21B;
					case 6:
					{
						secureWide = (global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
						num = (short)14876672;
						short num4 = num;
						num = (short)149880833;
						if (num != 0)
						{
						}
						num = (short)1939603456;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)162856964;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1509883906;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_81;
				}
				IL_21B:
				secureWide.General.SecureWideADPAlgorithmEnable_43200.SetValue(true);
				secureWide.General.SecureWideKeyloadingSource_43204.SetValue(0);
				num = (short)963379201;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_81:
			value = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralCodeplugVersion_A7683.Value;
			num = (short)1801715715;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x0013C6C8 File Offset: 0x0013A8C8
		private static void i()
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num;
			short num2;
			bool flag;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					radioWide.Features.RadWideFeaturePreAmpUHF_A42962.SetValue(radioWide.Features.RadWideAdvancedPreAmp_A8733.Value);
					num2 = (short)936706057;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					num2 = (short)1290469384;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)310640651;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (!flag)
					{
						num2 = (short)713097218;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					goto IL_9C;
				case 5:
					num2 = (short)1804468227;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (global::ConstraintHelper.UtilityMack.IsMobile())
					{
						num2 = (short)1945698309;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 7:
				{
					num2 = (short)107282433;
					if (num2 != 0)
					{
					}
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					radioWide.Features.RadWideFeaturePreAmpVHF_A42960.SetValue(radioWide.Features.RadWideAdvancedPreAmp_A8733.Value);
					num2 = (short)334973472;
					short num3 = num2;
					num2 = (short)1491290656;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)855769088;
						if (num2 != 0)
						{
						}
						num2 = (short)2104426500;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 8:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					if (radioWide.Features.RadWideAdvancedPreAmp_A8733.Value != radioWide.Features.RadWideFeaturePreAmpVHF_A42960.Value)
					{
						num2 = (short)2135162887;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_9C;
				}
				case 9:
					return;
				case 10:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					if (radioWide.Features.RadWideAdvancedPreAmp_A8733.Value != radioWide.Features.RadWideFeaturePreAmpUHF_A42962.Value)
					{
						num2 = (short)759693312;
						short num4 = num2;
						num2 = (short)1707212800;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 11:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
					if (radioInformation.Labtool.RadInfoLabtoolW12Preamp_A9671.Value)
					{
						num2 = (short)944439297;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				}
				goto IL_49;
				IL_9C:
				num2 = (short)1875574794;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_49:
			flag = global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얃횅킇늉릋뺍ꂏ", a_));
			num2 = (short)35848198;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0013C9E4 File Offset: 0x0013ABE4
		private static void h()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					global::AcpCommonLib.IAcpRecordset feature;
					(feature[0][10101] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DigitalAudioOptions).RadWideAudioConfigurationLevel_42740.Value = 0;
					num2 = (short)397934594;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					global::AcpCommonLib.IAcpRecordset feature;
					if (!(feature[0][10093] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Labtool).RadWideLabtoolAudioEnhancement_A42736.Value)
					{
						num2 = (short)2102591488;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_100;
				}
				case 2:
					goto IL_B0;
				}
				goto IL_1C;
			}
			IL_B0:
			num2 = (short)1680211968;
			short num3 = num2;
			num2 = (short)273022977;
			if (num2 != 0)
			{
			}
			IL_100:
			num2 = (short)1457123025;
			short num4 = num2;
			num2 = (short)1969614545;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1C:
				global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2045);
				num2 = (short)1036517377;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
				num2 = (short)278134784;
				if (num2 != 0)
				{
				}
				return;
			}
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0013CB40 File Offset: 0x0013AD40
		private static void a(string A_0)
		{
			int a_ = 14;
			short num = (short)1485438976;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7B;
				}
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				int value;
				for (;;)
				{
					IL_30:
					global::AcpCommonLib.IAcpRecordset acpRecordset;
					bool flag;
					bool flag2;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerRecset txPowerLevelsByFrequencyRangeInnerRecset;
					switch (num2)
					{
					case 0:
					{
						global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = ((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10103];
						if (acpFeatureSection == null)
						{
							num = (short)1405943822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpRecordset = acpFeatureSection.EmbeddedRecset;
						goto IL_328;
					}
					case 1:
					{
						global::SpecialFeatures.Comms.Util.HostVersion hostVersion;
						flag = hostVersion.EqualTo(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햐ꊒꊔ릖ꢘꮚ뎜꾞醠", a_));
						goto IL_221;
					}
					case 2:
						if (flag2)
						{
							num = (short)2026766336;
							short num3 = num;
							num = (short)737607692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C6;
					case 3:
						num = (short)2036072449;
						if (num != 0)
						{
						}
						num = (short)1901330433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::SpecialFeatures.Comms.Util.HostVersion hostVersion;
						if (!hostVersion.GreaterThan(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햐ꊒꊔ릖ꢘꮚ뎜꾞醠", a_)))
						{
							num = (short)1488322563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)913899533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_2C6;
					case 6:
						goto IL_3A8;
					case 7:
						acpFeatureNode = txPowerLevelsByFrequencyRangeInnerRecset[3];
						if (acpFeatureNode == null)
						{
							num = (short)1797586950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3AB;
					case 8:
						return;
					case 9:
						return;
					case 10:
					{
						if (!radioInformation.FrequencyRanges.RadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.Value)
						{
							num = (short)1542782991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						value = 94000000;
						global::SpecialFeatures.Comms.Util.HostVersion hostVersion = global::SpecialFeatures.Comms.Util.HostVersion.Parse(A_0);
						num = (short)1113391108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (radioInformation == null)
						{
							num = (short)454230024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2132410378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						value = 96000000;
						num = (short)1229848581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						flag = true;
						goto IL_221;
					case 14:
						acpRecordset = null;
						goto IL_328;
					case 15:
						goto IL_107;
					case 16:
						if (txPowerLevelsByFrequencyRangeInnerRecset == null)
						{
							num = (short)1824456713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1403453447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7B;
					IL_221:
					flag2 = flag;
					radioInformation.FrequencyRanges.RadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.Value = flag2;
					radioInformation.FrequencyRanges.RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.Value = flag2;
					num = (short)873660418;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C6:
					num = (short)80740352;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_328:
					txPowerLevelsByFrequencyRangeInnerRecset = (acpRecordset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerRecset);
					num = (short)2018836496;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_107:
				num = (short)823114606;
				short num4 = num;
				num = (short)187677550;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)1811611648;
					if (num != 0)
					{
					}
					return;
				}
				return;
				IL_3A8:
				object obj = null;
				goto IL_3B7;
				IL_3AB:
				obj = acpFeatureNode[10104];
				IL_3B7:
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection = obj as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection;
				if (txPowerLevelsByFrequencyRangeInnerSection == null)
				{
					return;
				}
				txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.SetValue(value);
				return;
				IL_7B:
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num = (short)743899147;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0013CF1C File Offset: 0x0013B11C
		private static void c(string A_0, string A_1, string A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>> list;
			short num2;
			global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>>.Enumerator enumerator;
				switch (num)
				{
				case 0:
					goto IL_21D;
				case 1:
					if (list != null)
					{
						num2 = (short)1142751232;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					try
					{
						num2 = (short)445448193;
						if (num2 != 0)
						{
						}
						list = modelTiering.GetPCIBitsToBeSet(A_0);
						goto IL_14B;
					}
					finally
					{
						num2 = (short)402915329;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								((global::System.IDisposable)modelTiering).Dispose();
								num2 = (short)1054343170;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1E6;
								}
								continue;
							case 2:
								goto IL_21A;
							}
							IL_1E6:
							if (modelTiering == null)
							{
								break;
							}
							num2 = (short)1002635264;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_21A:;
					}
					goto IL_21D;
				case 3:
				{
					num2 = (short)1149960192;
					short num3 = num2;
					try
					{
						num2 = (short)160890883;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_138;
							case 1:
								if (!enumerator.MoveNext())
								{
									num2 = (short)1505820674;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.a(enumerator.Current);
								num2 = (short)230490116;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
							{
								num2 = (short)1282368381;
								short num4 = num2;
								num2 = (short)1946510205;
								switch ((num4 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num2 = (short)2041839616;
									if (num2 != 0)
									{
									}
									num2 = (short)1467875328;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_7B;
								}
								continue;
							}
							IL_7D:
							num2 = (short)75431937;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_7B:
							goto IL_7D;
						}
						IL_138:
						return;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_14B;
				}
				}
				goto IL_20;
				IL_14B:
				num2 = (short)842596353;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_21D:
				enumerator = list.GetEnumerator();
				num2 = (short)786825219;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			list = null;
			modelTiering = new global::SpecialFeatures.Model_Configuration.ModelTiering(A_2, A_1);
			num2 = (short)1753415682;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x0013D1B0 File Offset: 0x0013B3B0
		private static void a(global::System.Collections.Generic.KeyValuePair<string, bool> A_0)
		{
			int a_ = 11;
			short num = (short)460128257;
			if (num != 0)
			{
			}
			num = (short)362807296;
			short num2 = num;
			num = (short)408879104;
			switch (num)
			{
			default:
			{
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = null;
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = global::AcpCommonLib.FeatureManager.Features.GetEnumerator();
				try
				{
					num = (short)2076639233;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_934;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_CF;
							}
							continue;
						case 2:
							goto IL_91B;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1147207682;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current;
							num = (short)112197636;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::AcpCommonLib.IAcpRecordset acpRecordset;
							if (acpRecordset != null)
							{
								num = (short)1686044678;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							try
							{
								num = (short)1436745734;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator3;
									switch (num3)
									{
									case 0:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)2019557384;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpFeatureSection = enumerator2.Current;
										num = (short)1288044547;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										try
										{
											num = (short)1709244423;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
													goto IL_73A;
												case 1:
												{
													global::AcpCommonLib.IAcpField acpField;
													acpField.ParseValueFrom(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("揄", a_));
													num = (short)1527119878;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 2:
												{
													if (!enumerator3.MoveNext())
													{
														num = (short)1808269320;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::AcpCommonLib.IAcpField acpField = enumerator3.Current;
													num = (short)389545988;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 3:
													goto IL_81B;
												case 4:
												{
													global::AcpCommonLib.IAcpField acpField;
													if (acpField.Name.Equals(A_0.Key))
													{
														num = (short)1668284421;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 5:
													num = (short)1919680521;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 6:
													goto IL_7C0;
												case 7:
													switch (0)
													{
													case 0:
														goto IL_6CE;
													}
													continue;
												case 8:
													num = (short)1729953795;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 9:
												{
													if (A_0.Value)
													{
														num = (short)546832385;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::AcpCommonLib.IAcpField acpField;
													acpField.ParseValueFrom(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﺑ", a_));
													num = (short)1487011840;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												}
												IL_7C5:
												num = (short)683999234;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_6CE:
												goto IL_7C5;
											}
											IL_73A:
											IL_7C0:
											return;
											IL_81B:
											break;
										}
										finally
										{
											num = (short)1531772930;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
													goto IL_88C;
												case 1:
													enumerator3.Dispose();
													num = (short)1790836736;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													switch (0)
													{
													case 0:
														goto IL_853;
													}
													continue;
												}
												IL_853:
												if (enumerator3 == null)
												{
													break;
												}
												num = (short)1836318721;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_88C:;
										}
										goto IL_88F;
									case 2:
										num = (short)1022296073;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										if (acpFeatureSection.EmbeddedRecset != null)
										{
											num = (short)2142306306;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_656;
									case 4:
										goto IL_8A8;
									case 5:
										if (acpFeatureNode != null)
										{
											num = (short)402063370;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_656;
									case 6:
										switch (0)
										{
										case 0:
											goto IL_1D9;
										}
										continue;
									case 7:
										try
										{
											num = (short)909180931;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator4;
												switch (num3)
												{
												case 0:
													goto IL_5E6;
												case 1:
													if (!enumerator4.MoveNext())
													{
														num = (short)1421475842;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_59E;
												case 2:
													num = (short)709361664;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
													switch (0)
													{
													case 0:
														goto IL_34F;
													}
													continue;
												case 4:
													try
													{
														num = (short)1989804036;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num3)
															{
															case 0:
																goto IL_50D;
															case 1:
																goto IL_52B;
															case 2:
															{
																global::AcpCommonLib.IAcpField acpField2;
																acpField2.ParseValueFrom(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("揄", a_));
																num = (short)525533193;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 3:
															{
																if (!enumerator3.MoveNext())
																{
																	num = (short)241041415;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																global::AcpCommonLib.IAcpField acpField2 = enumerator3.Current;
																num = (short)1272053766;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 4:
																switch (0)
																{
																case 0:
																	goto IL_3DC;
																}
																continue;
															case 5:
																num = (short)1722548232;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 6:
															{
																global::AcpCommonLib.IAcpField acpField2;
																if (acpField2.Name.Equals(A_0.Key))
																{
																	num = (short)573964293;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															}
															case 7:
																num = (short)1058144257;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 8:
															{
																if (A_0.Value)
																{
																	num = (short)762511362;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																global::AcpCommonLib.IAcpField acpField2;
																acpField2.ParseValueFrom(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﺑ", a_));
																num = (short)1395589120;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 9:
																goto IL_4DA;
															}
															IL_471:
															num = (short)1700921347;
															num3 = (int)((global::System.IntPtr)num);
															continue;
															IL_3DC:
															goto IL_471;
														}
														IL_4DA:
														IL_50D:
														return;
														IL_52B:
														break;
													}
													finally
													{
														num = (short)296484865;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num3)
															{
															case 0:
																enumerator3.Dispose();
																num = (short)145817602;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 1:
																switch (0)
																{
																case 0:
																	goto IL_563;
																}
																continue;
															case 2:
																goto IL_59B;
															}
															IL_563:
															if (enumerator3 == null)
															{
																break;
															}
															num = (short)1714421760;
															num3 = (int)((global::System.IntPtr)num);
														}
														IL_59B:;
													}
													goto IL_59E;
												}
												IL_351:
												num = (short)509345793;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_34F:
												goto IL_351;
												IL_59E:
												enumerator3 = enumerator4.Current.FieldsCollection.GetEnumerator();
												num = (short)3276804;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_5E6:;
										}
										finally
										{
											num = (short)1696727042;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator4;
												switch (num3)
												{
												case 0:
													goto IL_653;
												case 1:
													enumerator4.Dispose();
													num = (short)1190395904;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													switch (0)
													{
													case 0:
														goto IL_61B;
													}
													continue;
												}
												IL_61B:
												if (enumerator4 == null)
												{
													break;
												}
												num = (short)2042560513;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_653:;
										}
										goto IL_656;
									case 8:
										goto IL_88F;
									case 9:
										if (acpFeatureSection.HasEmbeddedRecset)
										{
											num = (short)1399455755;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_656;
									case 10:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator4 = acpFeatureNode.FeatureSectionsCollection.GetEnumerator();
										num = (short)1143603207;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
										acpFeatureNode = acpFeatureSection.EmbeddedRecset[0];
										num = (short)1313669125;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_21E:
									num = (short)1063976960;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_1D9:
									goto IL_21E;
									IL_656:
									enumerator3 = acpFeatureSection.FieldsCollection.GetEnumerator();
									num = (short)488636417;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_88F:
									num = (short)1186791428;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_8A8:
								break;
							}
							finally
							{
								num = (short)143261698;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
									switch (num3)
									{
									case 0:
										goto IL_918;
									case 1:
										enumerator2.Dispose();
										num = (short)544735232;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_8E0;
										}
										continue;
									}
									IL_8E0:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1718222849;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_918:;
							}
							goto IL_91B;
						case 6:
						{
							global::AcpCommonLib.IAcpRecordset acpRecordset;
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2 = acpRecordset[0].FeatureSectionsCollection.GetEnumerator();
							num = (short)1387659269;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_101:
						num = (short)953876483;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_CF:
						goto IL_101;
						IL_91B:
						num = (short)317063168;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_934:;
				}
				finally
				{
					num = (short)1309933570;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_9F0;
						case 1:
							enumerator.Dispose();
							num = (short)375980032;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_96C;
							}
							continue;
						}
						IL_96C:
						num = (short)649937524;
						short num4 = num;
						num = (short)826360436;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1507983360;
							if (num != 0)
							{
							}
							if (enumerator == null)
							{
								goto IL_9F2;
							}
							num = (short)579534849;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_9F0:
					IL_9F2:;
				}
				return;
			}
			}
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x0013DC2C File Offset: 0x0013BE2C
		private static void b(string A_0, string A_1, string A_2)
		{
			int a_ = 10;
			short num = (short)594608128;
			switch (num)
			{
			default:
			{
				num = (short)2135425030;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
					switch (num2)
					{
					case 0:
						num = (short)380370945;
						if (num != 0)
						{
						}
						if (radioProfilesRecset != null)
						{
							num = (short)400162819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AC;
					case 1:
					{
						int num3;
						int num4;
						if (num3 < num4)
						{
							num = (short)800653319;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AC;
					}
					case 2:
						try
						{
							num = (short)1945436169;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								int num5;
								global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
								switch (num2)
								{
								case 0:
									num = (short)1605042186;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1FD;
								case 2:
									goto IL_2A3;
								case 3:
									if (num5.Equals(3))
									{
										num = (short)2049114112;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1FD;
								case 4:
									radioProfiles.AudioSettings.RadProfAudioSettingsIntMicPassAlarmFilter_A42382Value = true;
									num = (short)439156737;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)677576706;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									if (num5.Equals(3))
									{
										num = (short)508690440;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 8:
									radioProfiles.AudioSettings.RadProfAudioSettingsExternalMicPassAlarmFilter_A42386Value = true;
									num = (short)666501126;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_111;
									}
									continue;
								case 10:
								{
									string text;
									string text2;
									if (text != text2)
									{
										num = (short)1040449540;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1FD;
								}
								case 11:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)71106565;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									radioProfiles = (global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles)enumerator.Current;
									num5 = radioProfiles.AudioSettings.RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292Value;
									num = (short)118226947;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_113:
								num = (short)1075118091;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_111:
								goto IL_113;
								IL_1FD:
								num5 = radioProfiles.AudioSettings.RadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291Value;
								num = (short)400883719;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2A3:
							goto IL_4AC;
						}
						finally
						{
							num = (short)1613103106;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_360;
								case 1:
									enumerator.Dispose();
									num = (short)1139671040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2DA;
									}
									continue;
								}
								IL_2DA:
								num = (short)704297356;
								short num6 = num;
								num = (short)1266399628;
								switch ((num6 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)980156416;
									if (num != 0)
									{
									}
									if (enumerator == null)
									{
										goto IL_362;
									}
									num = (short)1959395329;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_360:
							IL_362:;
						}
						goto IL_363;
					case 3:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = radioProfilesRecset.GetEnumerator();
						num = (short)1808531458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						int num7 = int.Parse(A_1.Substring(1, 2));
						int num4 = 13;
						string text = A_0.Substring(0, 3);
						string text2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얌몎ꢐ", a_);
						if (num7 >= num4)
						{
							num = (short)209911813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AC;
					}
					case 5:
						num = (short)799473665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_71;
						}
						continue;
					case 7:
						goto IL_363;
					case 8:
					{
						num = (short)1658126336;
						short num8 = num;
						int num3 = int.Parse(A_2.Substring(1, 2));
						num = (short)2082340868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_71:
					if (A_2 != null)
					{
						num = (short)90308616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_363:
					radioProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2077) as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset);
					num = (short)1258291200;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4AC:
				global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.h();
				return;
			}
			}
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x0013E108 File Offset: 0x0013C308
		private static void c(string A_0, string A_1)
		{
			short num = (short)1760690176;
			switch (num)
			{
			default:
			{
				num = (short)1718943755;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_137;
					case 1:
						num = (short)1201864707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_C8;
					case 3:
					{
						int num4;
						if (num3 >= num4)
						{
							num = (short)1809121280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset dataProfilesRecset = global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset;
						bool flag = false;
						num = (short)936968202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						return;
					case 5:
					{
						int num5 = int.Parse(A_0.Substring(1, 2));
						int num4 = 15;
						if (num5 >= num4)
						{
							num = (short)1756954625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 6:
						try
						{
							num = (short)280952842;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
								switch (num2)
								{
								case 0:
									num = (short)1523253255;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320 != 3)
									{
										num = (short)1274478594;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_30A;
								case 2:
									num = (short)41680900;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_34E;
								case 4:
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320 != 4)
									{
										num = (short)1375862784;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_30A;
								case 6:
									num = (short)1099038721;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320 == 2)
									{
										num = (short)1039073288;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 8:
									goto IL_30A;
								case 9:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1402339339;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									dataProfiles = (enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
									num = (short)744620044;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									switch (0)
									{
									case 0:
										goto IL_197;
									}
									continue;
								case 11:
									num = (short)1763639299;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									if (dataProfiles.LTE.DataProfLTEEnabled_A42075.Value)
									{
										num = (short)1626537990;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_2CB:
								num = (short)384892937;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_197:
								goto IL_2CB;
								IL_30A:
								dataProfiles.LTE.DataProfBroadbandSource_A42858.SetValue(1);
								num = (short)243924997;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_34E:
							goto IL_55F;
						}
						finally
						{
							num = (short)1409679362;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_408;
								case 1:
									enumerator.Dispose();
									num = (short)1094254592;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_385;
									}
									continue;
								}
								IL_385:
								num = (short)98395259;
								short num6 = num;
								num = (short)1578984571;
								switch ((num6 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1742929920;
									if (num != 0)
									{
									}
									if (enumerator == null)
									{
										goto IL_40A;
									}
									num = (short)2818049;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_408:
							IL_40A:;
						}
						goto IL_40B;
					case 7:
						num = (short)735379464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						bool flag;
						if (!flag)
						{
							num = (short)93585417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset dataProfilesRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dataProfilesRecset.GetEnumerator();
						num = (short)1195900934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_49E;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						if (radioInformation != null)
						{
							num = (short)1535901708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C8;
					}
					case 11:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						bool flag = radioInformation.Labtool.RadInfoLabtoolLTEOperation_A41923.Value;
						num = (short)405536770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset dataProfilesRecset;
						if (dataProfilesRecset != null)
						{
							num = (short)1797062663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9D;
					}
					}
					IL_7C:
					if (A_1 == null)
					{
						num = (short)324141060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_40B;
					IL_C8:
					num = (short)1055653901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40B:
					num3 = int.Parse(A_1.Substring(1, 2));
					num = (short)471793669;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_9D:
				num = (short)1536622592;
				short num7 = num;
				return;
				IL_137:
				return;
				IL_49E:
				goto IL_9D;
				IL_55F:
				num = (short)2103377921;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x0013E6B8 File Offset: 0x0013C8B8
		private static void b(string A_0, string A_1)
		{
			short num = (short)1833566208;
			switch (num)
			{
			default:
			{
				num = (short)1724776453;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						int num3;
						int num4;
						if (num3 >= num4)
						{
							num = (short)1295974408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset = global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset;
						num = (short)1684799488;
						short num5 = num;
						num = (short)1596850182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_AC;
					case 2:
						return;
					case 3:
					{
						int num6 = int.Parse(A_0.Substring(1, 2));
						int num4 = 15;
						if (num6 >= num4)
						{
							num = (short)1038024708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
						num = (short)1766522880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1685848065;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_90;
						}
						continue;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
						if (conventionalPersonalityRecset == null)
						{
							num = (short)933429250;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = conventionalPersonalityRecset.GetEnumerator();
						num = (short)2019229703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_CD;
					case 8:
						goto IL_621;
					}
					IL_90:
					if (A_1 == null)
					{
						num = (short)1494482945;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						int num3 = int.Parse(A_1.Substring(1, 2));
						num = (short)970391555;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_AC:
				return;
				IL_CD:
				try
				{
					num = (short)929300485;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)1980694533;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1427308552;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner)enumerator2.Current;
										num = (short)2052915204;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										num = (short)1835532295;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
										if (frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.Value)
										{
											num = (short)1605500931;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
										frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.SetValue(7);
										num = (short)706674694;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										num = (short)1012187855;
										short num7 = num;
										num = (short)678281935;
										switch ((num7 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_302;
										default:
										{
											num = (short)2109865984;
											if (num != 0)
											{
											}
											global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
											if (frequencyOptionsInner != null)
											{
												num = (short)89128961;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										}
										break;
									}
									case 5:
										goto IL_302;
									case 7:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
										if (frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.Value == 0)
										{
											num = (short)1289617417;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 8:
										num = (short)2039414794;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
										num = (short)852688898;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
										goto IL_4E9;
									}
									goto IL_33F;
									IL_302:
									switch (0)
									{
									case 0:
										IL_33F:
										goto IL_385;
									}
									continue;
									IL_385:
									num = (short)1495334912;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_4E9:
								break;
							}
							finally
							{
								num = (short)227803137;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									switch (num2)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)155779074;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_521;
										}
										continue;
									case 2:
										goto IL_55A;
									}
									IL_521:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1217527808;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_55A:;
							}
							goto IL_55D;
						case 1:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)790560775;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1982791683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset;
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = frequencyOptionsInnerRecset.GetEnumerator();
							num = (short)479264768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset = conventionalPersonality.Features.Parent[10148].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset;
							if (conventionalPersonality != null)
							{
								num = (short)574619652;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							num = (short)947453958;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_1EB;
							}
							continue;
						case 6:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset;
							if (frequencyOptionsInnerRecset != null)
							{
								num = (short)1250033666;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
							goto IL_55D;
						case 8:
							goto IL_576;
						}
						IL_1F0:
						num = (short)1971257345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1EB:
						goto IL_1F0;
						IL_55D:
						num = (short)695664648;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_576:
					return;
				}
				finally
				{
					num = (short)1858994177;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)74317826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_5AE;
							}
							continue;
						case 2:
							goto IL_5E4;
						}
						IL_5AE:
						if (enumerator == null)
						{
							break;
						}
						num = (short)694157312;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_5E4:;
				}
				return;
				IL_621:
				return;
			}
			}
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x0013ED1C File Offset: 0x0013CF1C
		private static void a(string A_0, string A_1)
		{
			short num = (short)1234501632;
			switch (num)
			{
			default:
			{
				num = (short)139132933;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						int num3;
						int num4;
						if (num3 >= num4)
						{
							num = (short)2061107208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)747241473;
						if (num != 0)
						{
						}
						bool value = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolAstroAlertingOperHOption.Value;
						global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListRecset toneSignalingListRecset = global::AcpCommonLib.FeatureManager.GetFeature(4156) as global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListRecset;
						num = (short)196083712;
						short num5 = num;
						num = (short)1868627974;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_84;
					case 2:
						return;
					case 3:
					{
						int num6 = int.Parse(A_0.Substring(1, 2));
						int num4 = 15;
						if (num6 >= num4)
						{
							num = (short)936247300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
						num = (short)1485307904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_68;
						}
						continue;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListRecset toneSignalingListRecset;
						if (toneSignalingListRecset == null)
						{
							num = (short)914620418;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = toneSignalingListRecset.GetEnumerator();
						num = (short)953155591;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_A7;
					case 8:
						goto IL_463;
					}
					IL_68:
					if (A_1 == null)
					{
						num = (short)812908545;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						int num3 = int.Parse(A_1.Substring(1, 2));
						num = (short)419299331;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_84:
				return;
				IL_A7:
				try
				{
					num = (short)462422021;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
							num = (short)441319432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							bool value;
							if (!value)
							{
								num = (short)1876688899;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList toneSignalingList;
							toneSignalingList.AstroAlertingToneListExpander.RadErgoAstroAlertingToneListType_A43068.SetValue(0);
							num = (short)1558708224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							num = (short)1406898856;
							short num7 = num;
							num = (short)1845727912;
							switch ((num7 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1DE;
							default:
							{
								num = (short)1219231744;
								if (num != 0)
								{
								}
								global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList toneSignalingList;
								if (toneSignalingList != null)
								{
									num = (short)1628372993;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							break;
						}
						case 5:
							goto IL_1DE;
						case 6:
							num = (short)353763330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1033175049;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList toneSignalingList = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList;
							num = (short)1549860868;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList toneSignalingList;
							if (toneSignalingList.AstroAlertingToneListExpander != null)
							{
								num = (short)1225129990;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
							num = (short)394461194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_3B3;
						}
						goto IL_21B;
						IL_1DE:
						switch (0)
						{
						case 0:
							IL_21B:
							goto IL_21D;
						}
						continue;
						IL_21D:
						num = (short)1091436551;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3B3:
					return;
				}
				finally
				{
					num = (short)408354817;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1518206978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_3EC;
							}
							continue;
						case 2:
							goto IL_425;
						}
						IL_3EC:
						if (enumerator == null)
						{
							break;
						}
						num = (short)53346304;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_425:;
				}
				return;
				IL_463:
				return;
			}
			}
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0013F1AC File Offset: 0x0013D3AC
		private static void g()
		{
			short num = (short)1636237313;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1042087936;
				short num3 = num;
				switch (num2)
				{
				case 0:
					global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.c().General.CnvEmerProfGeneralTxPeriodsec2_A43600.SetValue(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.c().General.CnvEmerProfGeneralTxPeriodsec1_A8212 * 10);
					num = (short)1271922690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 2:
				{
					num = (short)418578433;
					if (num != 0)
					{
					}
					num = (short)283177043;
					short num4 = num;
					num = (short)789704787;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_11B;
					}
					break;
				}
				}
				IL_5C:
				if (global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.c() == null)
				{
					return;
				}
				num = (short)419233792;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_11B:
			num = (short)1081933824;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x0013F2EC File Offset: 0x0013D4EC
		private static void f()
		{
			short num = (short)825753601;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1712652288;
				short num3 = num;
				switch (num2)
				{
				case 0:
					global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.b().General.TrkEmerProfGeneralTxPeriodsec2_A43601.SetValue(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.b().General.TrkEmerProfGeneralTxPeriodsec1_A7939 * 10);
					num = (short)1517551618;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 2:
				{
					num = (short)905439150;
					short num4 = num;
					num = (short)1567745966;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_11C;
					}
					break;
				}
				}
				IL_5A:
				num = (short)1407975425;
				if (num != 0)
				{
				}
				if (global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.b() == null)
				{
					return;
				}
				num = (short)374276096;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_11C:
			num = (short)1148911616;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x0013F430 File Offset: 0x0013D630
		private static void e()
		{
			short num = (short)1205045551;
			short num2 = num;
			num = (short)1219922223;
			switch (num2 == num)
			{
			}
			num = (short)130875392;
			short num3 = num;
			num = (short)1369505792;
			if (num != 0)
			{
			}
			num = (short)483131393;
			if (num != 0)
			{
			}
			(global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Labtool.RadWideLabtoolSeamlessUpdateOutOfBoxExperience.Value = false;
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x0013F500 File Offset: 0x0013D700
		private static void d()
		{
			int a_ = 18;
			short num = (short)130369633;
			short num2 = num;
			num = (short)98912353;
			switch (num2 == num)
			{
			}
			num = (short)173015040;
			short num3 = num;
			num = (short)622002176;
			if (num != 0)
			{
			}
			num = (short)1991442433;
			if (num != 0)
			{
			}
			(global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Labtool.RadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugIdValue = global::System.Guid.NewGuid().ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb94", a_)).ToUpper();
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0013F5F0 File Offset: 0x0013D7F0
		private static global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles c()
		{
			short num = (short)105696559;
			short num2 = num;
			num = (short)1722273071;
			switch (num2 == num)
			{
			}
			num = (short)627638272;
			short num3 = num;
			num = (short)1426784257;
			if (num != 0)
			{
			}
			num = (short)205717504;
			if (num != 0)
			{
			}
			return global::AcpCommonLib.FeatureManager.GetFeature(2075)[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles;
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0013F6B0 File Offset: 0x0013D8B0
		private static global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles b()
		{
			short num = (short)943419431;
			short num2 = num;
			num = (short)755068967;
			switch (num2 == num)
			{
			}
			num = (short)1008664576;
			short num3 = num;
			num = (short)638320641;
			if (num != 0)
			{
			}
			num = (short)427622400;
			if (num != 0)
			{
			}
			return global::AcpCommonLib.FeatureManager.GetFeature(2076)[0] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles;
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x0013F770 File Offset: 0x0013D970
		private static void a()
		{
			int a_ = 10;
			short num = (short)1459093504;
			switch (num)
			{
			default:
			{
				num = (short)2136866821;
				int num2 = (int)((global::System.IntPtr)num);
				global::AcpBusinessLayer.AcpFieldX<string, string> acpFieldX2;
				string value;
				string value2;
				for (;;)
				{
					global::AcpBusinessLayer.AcpFieldX<string, string> acpFieldX;
					bool? flag3;
					switch (num2)
					{
					case 0:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1092550664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A7;
					}
					case 1:
						acpFieldX = null;
						goto IL_14C;
					case 2:
						goto IL_1B4;
					case 3:
					{
						if (acpFieldX2 == null)
						{
							num = (short)1214316548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						value = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("붌뾎", a_);
						value2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("붌뺎", a_);
						bool? flag = flag3;
						bool flag2 = true;
						num = (short)926482432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						num = (short)1894391362;
						short num3 = num;
						num = (short)561520194;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1B4;
						default:
							goto IL_21C;
						}
						break;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_72;
						}
						continue;
					case 6:
						if (flag3 != null)
						{
							num = (short)672268288;
							short num4 = num;
							num = (short)328335362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
						acpFieldX = null;
						goto IL_14C;
					case 8:
						goto IL_29D;
					}
					IL_72:
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
					bool? flag4;
					if (radioInformation == null)
					{
						bool? flag = null;
						flag4 = flag;
					}
					else
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool labtool = radioInformation.Labtool;
						if (labtool == null)
						{
							bool? flag = null;
							flag4 = flag;
						}
						else
						{
							global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_ = labtool.RadInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_43771;
							if (radInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_ == null)
							{
								bool? flag = null;
								flag4 = flag;
							}
							else
							{
								flag4 = new bool?(radInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_.Value);
							}
						}
					}
					flag3 = flag4;
					if (radioInformation == null)
					{
						num = (short)195166209;
						if (num != 0)
						{
						}
						num = (short)1086783489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General general = radioInformation.General;
					if (general == null)
					{
						num = (short)1429929991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					acpFieldX = general.RadInfoGeneralWiFiRegulatoryRegion_A43772;
					IL_14C:
					acpFieldX2 = acpFieldX;
					num = (short)708509702;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B4:
					num = (short)334168067;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_21C:
				num = (short)1142554624;
				if (num != 0)
				{
				}
				return;
				IL_29D:
				acpFieldX2.Value = value2;
				return;
				IL_2A7:
				acpFieldX2.Value = value;
				return;
			}
			}
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0013FA2C File Offset: 0x0013DC2C
		private static bool a(string A_0, string A_1, string A_2 = "")
		{
			short num = (short)1892352000;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool result2;
				for (;;)
				{
					IL_1F:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering;
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>> list;
					for (;;)
					{
						IL_29:
						global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>>.Enumerator enumerator;
						switch (num2)
						{
						case 0:
						{
							try
							{
								list = modelTiering.GetPCIBitsToBeSet(A_1);
							}
							finally
							{
								num = (short)1224605696;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_201;
										}
										continue;
									case 1:
										((global::System.IDisposable)modelTiering).Dispose();
										num = (short)1509818370;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_239;
									}
									IL_201:
									if (modelTiering == null)
									{
										break;
									}
									num = (short)1600782337;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_239:;
							}
							num = (short)2067398656;
							short num3 = num;
							num = (short)570294274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num = (short)359202817;
							if (num != 0)
							{
							}
							try
							{
								num = (short)951123970;
								num2 = (int)((global::System.IntPtr)num);
								bool result;
								for (;;)
								{
									switch (num2)
									{
									case 0:
										result = false;
										num = (short)1040908291;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1347354630;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.KeyValuePair<string, bool> keyValuePair = enumerator.Current;
										num = (short)1991573508;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_A9;
										}
										continue;
									case 3:
										goto IL_C4;
									case 4:
									{
										global::System.Collections.Generic.KeyValuePair<string, bool> keyValuePair;
										if (!global::SpecialFeatures.Flashport.FlashRadio.ApxNext.UpgradeRadioApxNext.a(keyValuePair.Key, true))
										{
											num = (short)1581907968;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										goto IL_166;
									case 6:
										num = (short)872349701;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_112:
									num = (short)499056641;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_A9:
									goto IL_112;
								}
								IL_C4:
								return result;
								IL_166:
								return result2;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_176;
						case 2:
						{
							num = (short)1373725299;
							short num4 = num;
							num = (short)839737971;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1F;
							default:
								num = (short)1124270080;
								if (num != 0)
								{
								}
								if (list != null)
								{
									num = (short)2033909763;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								return result2;
							}
							break;
						}
						case 3:
							goto IL_176;
						}
						break;
						IL_176:
						enumerator = list.GetEnumerator();
						num = (short)543424513;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_40:
					list = null;
					result2 = true;
					modelTiering = new global::SpecialFeatures.Model_Configuration.ModelTiering(A_0, A_2);
					num = (short)455016448;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_29;
				}
				return result2;
			}
			}
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x0013FD60 File Offset: 0x0013DF60
		private static bool a(string A_0, bool A_1)
		{
			short num = (short)894828544;
			switch (num)
			{
			default:
			{
				num = (short)16515073;
				if (num != 0)
				{
				}
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = null;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = null;
				bool result = true;
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = global::AcpCommonLib.FeatureManager.Features.GetEnumerator();
				bool result2;
				try
				{
					num = (short)1213726724;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1665597446;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current;
							num = (short)1778712579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							try
							{
								num = (short)1197998087;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator4;
									switch (num2)
									{
									case 0:
										if (acpFeatureNode2 != null)
										{
											num = (short)1687486468;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_750;
									case 1:
										if (acpFeatureSection.EmbeddedRecset != null)
										{
											num = (short)1100283913;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_750;
									case 2:
										goto IL_795;
									case 3:
										if (acpFeatureSection.HasEmbeddedRecset)
										{
											num = (short)1123024907;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_750;
									case 4:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2 = acpFeatureNode2.FeatureSectionsCollection.GetEnumerator();
										num = (short)102301704;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator3;
										if (!enumerator3.MoveNext())
										{
											num = (short)1704263686;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpFeatureSection = enumerator3.Current;
										num = (short)1860829185;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										num = (short)1189609474;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										switch (0)
										{
										case 0:
											goto IL_140;
										}
										continue;
									case 8:
										try
										{
											num = (short)2140209153;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
												switch (num2)
												{
												case 0:
													if (!enumerator2.MoveNext())
													{
														num = (short)1595736067;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_489;
												case 1:
													switch (0)
													{
													case 0:
														goto IL_2BA;
													}
													continue;
												case 2:
													try
													{
														num = (short)791805956;
														num2 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num2)
															{
															case 0:
															{
																global::AcpCommonLib.IAcpField acpField;
																if (acpField.Name.Equals(A_0))
																{
																	num = (short)1265762310;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															}
															case 1:
															{
																global::AcpCommonLib.IAcpField acpField;
																if (acpField.ToString() != A_1.ToString())
																{
																	num = (short)1554776066;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															}
															case 2:
																result2 = false;
																num = (short)1073938440;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															case 3:
															{
																if (!enumerator4.MoveNext())
																{
																	num = (short)1441857541;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																global::AcpCommonLib.IAcpField acpField = enumerator4.Current;
																num = (short)234029056;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 4:
																switch (0)
																{
																case 0:
																	goto IL_30A;
																}
																continue;
															case 5:
																num = (short)1280245767;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															case 6:
																num = (short)1164771329;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															case 7:
																goto IL_416;
															case 8:
																goto IL_3F8;
															}
															IL_30C:
															num = (short)143327235;
															num2 = (int)((global::System.IntPtr)num);
															continue;
															IL_30A:
															goto IL_30C;
														}
														IL_3F8:
														goto IL_987;
														IL_416:
														break;
													}
													finally
													{
														num = (short)139132928;
														num2 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num2)
															{
															case 0:
																switch (0)
																{
																case 0:
																	goto IL_44E;
																}
																continue;
															case 1:
																enumerator4.Dispose();
																num = (short)979566594;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															case 2:
																goto IL_486;
															}
															IL_44E:
															if (enumerator4 == null)
															{
																break;
															}
															num = (short)905445377;
															num2 = (int)((global::System.IntPtr)num);
														}
														IL_486:;
													}
													goto IL_489;
												case 3:
													num = (short)1757609988;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 4:
													goto IL_50F;
												}
												goto IL_2BA;
												IL_489:
												enumerator4 = enumerator2.Current.FieldsCollection.GetEnumerator();
												num = (short)47185922;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_4B9:
												num = (short)1675755520;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_2BA:
												goto IL_4B9;
											}
											IL_50F:
											goto IL_750;
										}
										finally
										{
											num = (short)1585184768;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
												switch (num2)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_546;
													}
													continue;
												case 1:
													enumerator2.Dispose();
													num = (short)1056833538;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													goto IL_57E;
												}
												IL_546:
												if (enumerator2 == null)
												{
													break;
												}
												num = (short)259850241;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_57E:;
										}
										goto Block_11;
									case 9:
										num = (short)1136197635;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
										goto IL_581;
									case 11:
										acpFeatureNode2 = acpFeatureSection.EmbeddedRecset[0];
										num = (short)1170210816;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_145:
									num = (short)1403387909;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									Block_11:
									try
									{
										IL_581:
										num = (short)987234308;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)1324941318;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												result2 = false;
												num = (short)1163919363;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
											{
												if (!enumerator4.MoveNext())
												{
													num = (short)1359216648;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpCommonLib.IAcpField acpField2 = enumerator4.Current;
												num = (short)1806565381;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												goto IL_5EB;
											case 4:
												switch (0)
												{
												case 0:
													goto IL_5CD;
												}
												continue;
											case 5:
											{
												global::AcpCommonLib.IAcpField acpField2;
												if (acpField2.Name.Equals(A_0))
												{
													num = (short)345899008;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 6:
											{
												global::AcpCommonLib.IAcpField acpField2;
												if (acpField2.ToString() != A_1.ToString())
												{
													num = (short)813760513;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 7:
												goto IL_6DC;
											case 8:
												num = (short)456458247;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_683:
											num = (short)690028546;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_5CD:
											goto IL_683;
										}
										IL_5EB:
										goto IL_987;
										IL_6DC:
										goto IL_145;
									}
									finally
									{
										num = (short)1167917056;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_714;
												}
												continue;
											case 1:
												enumerator4.Dispose();
												num = (short)704053250;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_74D;
											}
											IL_714:
											if (enumerator4 == null)
											{
												break;
											}
											num = (short)2029977601;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_74D:;
									}
									goto IL_750;
									IL_140:
									goto IL_145;
									IL_750:
									enumerator4 = acpFeatureSection.FieldsCollection.GetEnumerator();
									num = (short)1043857418;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_795:;
							}
							finally
							{
								num = (short)1735852032;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator3;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_7C9;
										}
										continue;
									case 1:
										enumerator3.Dispose();
										num = (short)70582274;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_800;
									}
									IL_7C9:
									if (enumerator3 == null)
									{
										break;
									}
									num = (short)649723905;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_800:;
							}
							break;
						case 2:
							if (acpFeatureNode != null)
							{
								num = (short)1206059016;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 3:
						{
							global::AcpCommonLib.IAcpRecordset acpRecordset;
							if (acpRecordset != null)
							{
								num = (short)4128773;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_A6;
							}
							continue;
						case 5:
						{
							global::AcpCommonLib.IAcpRecordset acpRecordset;
							acpFeatureNode = acpRecordset[0];
							num = (short)799735810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)525664263;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_8C8;
						case 8:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator3 = acpFeatureNode.FeatureSectionsCollection.GetEnumerator();
							num = (short)804257793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_803:
						num = (short)604110848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A6:
						goto IL_803;
					}
					IL_8C8:
					return result;
				}
				finally
				{
					num = (short)1133707264;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1209365032;
						short num3 = num;
						num = (short)93024808;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)9109504;
							if (num != 0)
							{
							}
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_949;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)903413762;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_984;
							}
							break;
						}
						IL_949:
						if (enumerator == null)
						{
							break;
						}
						num = (short)457900033;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_984:;
				}
				IL_987:
				num = (short)1622212608;
				short num4 = num;
				return result2;
			}
			}
		}

		// Token: 0x04000757 RID: 1879
		private const int a = 901;

		// Token: 0x04000758 RID: 1880
		private readonly global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressUpdater b;

		// Token: 0x04000759 RID: 1881
		private readonly bool c;
	}
}
