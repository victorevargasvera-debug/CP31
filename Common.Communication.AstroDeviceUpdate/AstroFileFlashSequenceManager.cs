using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.CommonFile;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.Common.Communication
{
	// Token: 0x02000003 RID: 3
	public class AstroFileFlashSequenceManager : global::Motorola.Common.Communication.AstroFileSeqManager, global::Motorola.Common.Communication.IFlashSequenceManager, global::Motorola.Common.Communication.IUpdatesDeviceForFlash
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002124 File Offset: 0x00000324
		public AstroFileFlashSequenceManager(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter) : base(rcmpWrapper, sessionParameter)
		{
			this.e = false;
			this.a = 1.0;
			this.c = 1368;
			this.d = new global::Motorola.Common.Communication.c(rcmpWrapper, this.c);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000216C File Offset: 0x0000036C
		public override void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			short num = (short)324665352;
			int num2 = (int)((global::System.IntPtr)num);
			ushort num4;
			ushort num5;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					base.UnlockRadioPartition(0);
					base.EnterProgramMode();
					num = (short)1446838277;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)832929316;
					short num3 = num;
					num = (short)1980333604;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_208;
					default:
						goto IL_18C;
					}
					break;
				}
				case 2:
					base.IOController.ComponentSession(7, sessionID, out num4, out num5);
					num = (short)839254022;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_DD;
				case 4:
					num = (short)1691615233;
					if (num != 0)
					{
					}
					if (base.IOController.RetryDifferentialWriteNotSupported)
					{
						num = (short)579600387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					if (base.SessionParam.ArchiveSession)
					{
						num = (short)227737602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					base.IOController.ComponentSession(3, sessionID, out num4, out num5);
					num = (short)377487361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (base.IOController.SessionCommandReply.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.InvalidParameter)
					{
						goto IL_208;
					}
					return;
				case 7:
					num = (short)325451780;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				}
				IL_48:
				if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
				{
					num = (short)2020147200;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_208:
				num = (short)777584647;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_DD:
			base.IOController.ComponentSession(3, sessionID, out num4, out num5);
			return;
			IL_18C:
			num = (short)1561067520;
			if (num != 0)
			{
			}
			num = (short)1973682176;
			short num6 = num;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000023A0 File Offset: 0x000005A0
		public override void CloseSession(ushort sessionId, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			short num = (short)699105721;
			short num2 = num;
			num = (short)1031307705;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)995491841;
				if (num != 0)
				{
				}
				num = (short)63438848;
				short num3 = num;
				num = (short)1250164736;
				if (num != 0)
				{
				}
				if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
				{
					try
					{
						num = (short)820772866;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								goto IL_1AD;
							case 1:
							{
								ushort num5;
								ushort num6;
								base.IOController.ComponentSession(1056, sessionId, out num5, out num6);
								num = (short)148111367;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_FB;
								}
								continue;
							case 3:
							{
								ushort num5;
								ushort num6;
								base.IOController.ComponentSession(32, sessionId, out num5, out num6);
								num = (short)530055179;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								goto IL_270;
							case 5:
								goto IL_28D;
							case 6:
								if (base.IOController.RetryDifferentialWriteNotSupported)
								{
									num = (short)413597699;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1AD;
							case 7:
								if (base.IOController.SessionCommandReply.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.InvalidParameter)
								{
									num = (short)1542782986;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1AD;
							case 8:
								num = (short)1248067593;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
							{
								if (base.SessionParam.ArchiveSession)
								{
									num = (short)1441005569;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								ushort num5;
								ushort num6;
								base.IOController.ComponentSession(32, sessionId, out num5, out num6);
								num = (short)1406074880;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 10:
								num = (short)537985030;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								goto IL_1AD;
							}
							IL_FB:
							if (!pendingDeploy)
							{
								num = (short)448856072;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_270;
							IL_1AD:
							this.ValidateUpdate();
							num = (short)853934084;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_270:
							base.ExitProgramMode();
							num = (short)271974405;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_28D:;
					}
					catch (global::Motorola.Common.CustomException.CommonException ex)
					{
						if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure)
						{
							if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeWriteFailure)
							{
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_CloseSession_Fail);
							}
						}
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Commit_Fail, global::Motorola.CommonCPS.ResourceRepository.Resources.Communication_SequenceManager_Astro_Commit_Fail);
					}
					catch (global::System.Exception)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_CloseSession_Fail);
					}
				}
				break;
			}
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000026B8 File Offset: 0x000008B8
		public void ValidateUpdate()
		{
			short num = (short)1187613115;
			short num2 = num;
			num = (short)1853327803;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2118516736;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_69;
				}
				int num3;
				byte b;
				for (;;)
				{
					IL_53:
					switch (num3)
					{
					case 0:
						goto IL_136;
					case 1:
						if (this.e)
						{
							num = (short)147718147;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
					{
						num = (short)6029312;
						short num4 = num;
						num = (short)978321409;
						if (num != 0)
						{
						}
						if (this.d.a(5, ref b) != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
						{
							num = (short)48496640;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 3:
						num = (short)69992450;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_69;
				}
				IL_136:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_FirmwareValidationFailed);
				IL_69:
				b = 0;
				num = (short)160694273;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_53;
			}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002800 File Offset: 0x00000A00
		public virtual void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionId, bool hostedDepotOperation, int? userDefersAllowed = null)
		{
			int a_ = 14;
			short num = (short)1166802944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A8;
				}
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo;
				for (;;)
				{
					IL_31:
					global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
					global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool> predicate;
					switch (num2)
					{
					case 0:
						base.ProgressIndicator.SetCurrentScope(65, 100);
						base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLanguages);
						(pbaObject.LanguagePackData.LanguagePacks[0] as global::Motorola.Common.Communication.Pba.AstroFilePackInfo).isFlashPortUpgradeLP = true;
						base.WriteLanguagePacks(pbaObject.LanguagePackData);
						num = (short)1758920708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (pbaObject.UpdateData.MemoryImages.Count > 0)
						{
							num = (short)613941273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_723;
					case 2:
						goto IL_690;
					case 3:
						goto IL_2AB;
					case 4:
						goto IL_68B;
					case 5:
					{
						global::Motorola.Common.Communication.Pba.RadioImage imageFromList = global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(pbaObject.UpdateData.MemoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FLASHTOFILESYSTEM);
						this.f = new global::Motorola.Common.Communication.a(imageFromList.FilePath);
						num = (short)2010906647;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (pbaObject.LanguagePackData.LanguagePacks.Count > 0)
						{
							num = (short)1241776128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_871;
					case 7:
						if (base.ProgressIndicator != null)
						{
							num = (short)68288524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_690;
					case 8:
						goto IL_330;
						try
						{
							for (;;)
							{
								IL_330:
								switch (0)
								{
								case 0:
									goto IL_34D;
								}
								for (;;)
								{
									IL_33A:
									switch (num2)
									{
									case 0:
									{
										if (!this.f.c())
										{
											goto IL_437;
										}
										num = (short)1102802647;
										short num3 = num;
										num = (short)448360151;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_330;
										default:
											num = (short)1099038720;
											if (num != 0)
											{
											}
											num = (short)1352794114;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
										goto IL_432;
									case 2:
									{
										bool a_2;
										this.a(extendedDeviceInfo, pbaObject, a_2);
										num = (short)563609601;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								IL_34D:
								global::System.GC.WaitForPendingFinalizers();
								global::Motorola.Common.Communication.AutoReleasedSemaphore.addUpgradeJobSem.WaitOne(600000);
								this.f = new global::Motorola.Common.Communication.a(pbaObject.UpdateData.MemoryImages[0].FilePath);
								num = (short)1218379776;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_33A;
							}
							IL_432:
							goto IL_723;
							IL_437:
							global::System.Diagnostics.Trace.TraceError(string.Format(global::Motorola.Common.Communication.Crc32.c("꧱迳웵藷ꟹꟻ藽ㇿ缁夃崅猇㠉焋匍䬏椑✓欕䔗䄙䤛渝䐟䌡倣䌥氧伩娫䜭匯圱ᰳ瀵吷嬹伻嘽〿ⵁ㙃㉅慇ᝉᝋ㕍摏⽑॓ൕ⍗潙⅛͝䁟❡ᱣե൧ᩩᡫݭὯᱱ乳噵ͷ䱹Ż", a_), new object[]
							{
								extendedDeviceInfo.ConnectionInfo.ConnectionType,
								extendedDeviceInfo.Family,
								extendedDeviceInfo.SerialNumber,
								extendedDeviceInfo.ModelNumber,
								extendedDeviceInfo.SoftwareVersion,
								extendedDeviceInfo.CodeplugVersion,
								global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData
							}));
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
						}
						finally
						{
							this.f = null;
							global::System.GC.Collect();
							global::Motorola.Common.Communication.AutoReleasedSemaphore.addUpgradeJobSem.Release();
						}
						goto IL_4CA;
					case 9:
						if (pbaObject.UpdateData.MemoryImages.Count > 0)
						{
							num = (short)74776597;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_262;
					case 10:
						num = (short)1313144833;
						if (num != 0)
						{
						}
						num = (short)956694534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (this.f.g())
						{
							num = (short)1804009489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F1;
					case 12:
						base.ProgressIndicator.SetCurrentScope(8, 64);
						base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeRadio);
						num = (short)1241513986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (!string.IsNullOrEmpty(extendedDeviceInfo.SoftwareVersion))
						{
							num = (short)898105344;
							short num4 = num;
							num = (short)1428684826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AB;
					case 14:
						if (extendedDeviceInfo.SoftwareVersion.Substring(1, 2) == global::Motorola.Common.Communication.Crc32.c("싱엳", a_))
						{
							num = (short)361627664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AB;
					case 15:
						if (pbaObject.LanguagePackData != null)
						{
							num = (short)946405386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_871;
					case 16:
					{
						bool a_2 = true;
						num = (short)788463619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						this.FlashRadioImageToFileSystem();
						num = (short)1881145368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						memoryImages = pbaObject.UpdateData.MemoryImages;
						if ((predicate = global::Motorola.Common.Communication.AstroFileFlashSequenceManager.<>c.<>9__10_0) == null)
						{
							predicate = (global::Motorola.Common.Communication.AstroFileFlashSequenceManager.<>c.<>9__10_0 = new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFileFlashSequenceManager.<>c.<>9.a));
							goto IL_4CA;
						}
						goto IL_4CA;
					case 19:
						if (pbaObject.UpdateData.MemoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFileFlashSequenceManager.<>c.<>9.b)))
						{
							num = (short)1448280069;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_723;
					case 20:
						goto IL_579;
					case 21:
						num = (short)218431506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						bool a_2 = false;
						num = (short)441450509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
					{
						global::Motorola.Common.Communication.Pba.RadioImage imageFromList;
						if (global::System.IO.File.Exists(imageFromList.FilePath))
						{
							num = (short)1245970459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F1;
					}
					case 24:
						goto IL_723;
					case 25:
						num = (short)1489764371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num = (short)1688535054;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)550830091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A8;
					IL_262:
					num = (short)642383873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4CA:
					if (memoryImages.Any(predicate))
					{
						num = (short)1959788566;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_262;
					IL_2AB:
					num = (short)809762824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F1:
					global::System.Diagnostics.Trace.TraceError(string.Format(global::Motorola.Common.Communication.Crc32.c("꧱迳웵藷ꟹꟻ藽ㇿ缁夃崅猇㠉焋匍䬏椑✓欕䔗䄙䤛渝䐟䌡倣䌥氧伩娫䜭匯圱ᰳ瀵吷嬹伻嘽〿ⵁ㙃㉅慇ᝉᝋ㕍摏⽑॓ൕ⍗潙⅛͝䁟❡ᱣե൧ᩩᡫݭὯᱱ乳噵ͷ䱹Ż", a_), new object[]
					{
						extendedDeviceInfo.ConnectionInfo.ConnectionType,
						extendedDeviceInfo.Family,
						extendedDeviceInfo.SerialNumber,
						extendedDeviceInfo.ModelNumber,
						extendedDeviceInfo.SoftwareVersion,
						extendedDeviceInfo.CodeplugVersion,
						global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData
					}));
					num = (short)4718612;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_690:
					num = (short)389152777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_723:
					num = (short)1943076879;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_579:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_68B:
				IL_871:
				global::System.Diagnostics.Trace.TraceInformation(string.Format(global::Motorola.Common.Communication.Crc32.c("꧱迳웵藷ꟹꟻ藽ㇿ缁夃崅猇㠉焋匍䬏椑✓欕䔗䄙望⨝崟缡缣崥ᴧ圩焫甭䬯б䤳欵ᠷ簹倻弽㌿⩁㑃⥅㩇㹉汋㭍⁏㕑♓㝕㱗㽙籛㝝፟䉡ɣཥ٧ͩὫ٭ᕯᙱ婳", a_), new object[]
				{
					extendedDeviceInfo.ConnectionInfo.ConnectionType,
					extendedDeviceInfo.Family,
					extendedDeviceInfo.SerialNumber,
					extendedDeviceInfo.ModelNumber,
					extendedDeviceInfo.OperationId,
					extendedDeviceInfo.SoftwareVersion,
					extendedDeviceInfo.CodeplugVersion
				}));
				return;
				IL_A8:
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(pbaObject, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				extendedDeviceInfo = base.ExtendedDeviceInfo;
				global::System.Diagnostics.Trace.TraceInformation(string.Format(global::Motorola.Common.Communication.Crc32.c("꧱迳웵藷ꟹꟻ藽ㇿ缁夃崅猇㠉焋匍䬏椑✓欕䔗䄙望⨝崟缡缣崥ᴧ圩焫甭䬯б䤳欵ᠷ簹倻弽㌿⩁㑃⥅㩇㹉汋㭍⁏㕑♓㝕㱗㽙籛㝝፟䉡ᝣብ१ᡩᡫ୭ᑯ山", a_), new object[]
				{
					extendedDeviceInfo.ConnectionInfo.ConnectionType,
					extendedDeviceInfo.Family,
					extendedDeviceInfo.SerialNumber,
					extendedDeviceInfo.ModelNumber,
					extendedDeviceInfo.OperationId,
					extendedDeviceInfo.SoftwareVersion,
					extendedDeviceInfo.CodeplugVersion
				}));
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject2 = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(pbaObject.SerializeToBytes(), false);
				base.WriteDevice(pbaObject2, 0, null, hostedDepotOperation, userDefersAllowed);
				pbaObject.CodeplugData.ArchiveSessionID = sessionId;
				num = (short)1234698247;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00003108 File Offset: 0x00001308
		public void PreUpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID, bool hostedDepotOperation)
		{
			short num = (short)490078208;
			short num2 = num;
			num = (short)567428742;
			short num3 = num;
			num = (short)1319782022;
			switch (num3 == num)
			{
			}
			num = (short)2038759425;
			if (num != 0)
			{
			}
			num = (short)1309147136;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000031B8 File Offset: 0x000013B8
		public bool WriteRamdownloader(string filepath)
		{
			short num = (short)1677524992;
			short num2 = num;
			num = (short)1637989900;
			short num3 = num;
			num = (short)208387596;
			switch (num3 == num)
			{
			}
			num = (short)349896705;
			if (num != 0)
			{
			}
			num = (short)1559429120;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003264 File Offset: 0x00001464
		public global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.Pba.UpdateDeviceData images)
		{
			short num = (short)1473576960;
			short num2 = num;
			num = (short)2093158544;
			short num3 = num;
			num = (short)270602384;
			switch (num3 == num)
			{
			}
			num = (short)1945763841;
			if (num != 0)
			{
			}
			num = (short)1298989056;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003314 File Offset: 0x00001514
		public override global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword, bool hostedDepotOperation)
		{
			for (;;)
			{
				IL_00:
				short num = (short)643825669;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (writePBA.DifferetialCodeplugData != null)
						{
							num = (short)1178730502;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D4;
					case 1:
					{
						num = (short)1416264452;
						short num3 = num;
						num = (short)1256028932;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1866727424;
							if (num != 0)
							{
							}
							if (base.DifferentialWriteCapableRadio)
							{
								num = (short)1936916489;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1D4;
						}
						break;
					}
					case 2:
						return writePBA;
					case 3:
					{
						num = (short)609746944;
						short num4 = num;
						base.ProgressIndicator.SetCurrentScope(0, 7);
						num = (short)447152139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (!base.DifferentialWriteCapableRadio)
						{
							num = (short)978190337;
							if (num != 0)
							{
							}
							num = (short)137625610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E2;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_55;
						}
						continue;
					case 6:
						this.WriteRadioCodeplug(new global::Motorola.Common.Communication.Pba.PbaObject
						{
							CodeplugData = writePBA.DifferetialCodeplugData
						}, true, hostedDepotOperation);
						num = (short)1723858946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						return writePBA;
					case 8:
						goto IL_E2;
					case 9:
						num = (short)564985856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						base.WriteValidation(writePBA);
						num = (short)1457782792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_16D;
					}
					IL_55:
					if (base.ProgressIndicator != null)
					{
						num = (short)685506563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16D;
					IL_E2:
					num = (short)407044097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16D:
					num = (short)1021706244;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D4:
					this.WriteRadioCodeplug(writePBA, true, hostedDepotOperation);
					num = (short)1783431175;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return writePBA;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000035A0 File Offset: 0x000017A0
		public void FlashRadioImageToFileSystem()
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			global::System.IO.MemoryStream memoryStream;
			byte[] array;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)701956097;
					if (num2 != 0)
					{
					}
					try
					{
						memoryStream.Write(array, 0, array.Length);
						base.IOController.FileWrite(0, global::Motorola.Common.Communication.Crc32.c("黪鷬诮郰蟲郴\ud9f6鯸駺鯼", a_), memoryStream, base.ProgressIndicator, false);
						goto IL_79;
					}
					finally
					{
						num2 = (short)244776960;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_115;
								}
								continue;
							case 1:
								((global::System.IDisposable)memoryStream).Dispose();
								num2 = (short)679084034;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_149;
							}
							IL_115:
							if (memoryStream == null)
							{
								break;
							}
							num2 = (short)1993277441;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_149:;
					}
					goto IL_14C;
					IL_79:
					num2 = (short)1303314434;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_14C;
				case 2:
					if (base.ProgressIndicator != null)
					{
						num2 = (short)484507649;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					goto IL_179;
				}
				goto IL_29;
				IL_14C:
				base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteSoftwareDone);
				num2 = (short)864354307;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_179:
			num2 = (short)2132082688;
			short num3 = num2;
			num2 = (short)438604750;
			short num4 = num2;
			num2 = (short)1263506382;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)804126720;
				if (num2 != 0)
				{
				}
				break;
			}
			return;
			IL_29:
			array = this.f.h();
			memoryStream = new global::System.IO.MemoryStream();
			num2 = (short)1583153152;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000037AC File Offset: 0x000019AC
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			int a_ = 15;
			short num = (short)49741824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)532676610;
				num2 = (int)((global::System.IntPtr)num);
				byte[] fileData;
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
				string cpversion;
				for (;;)
				{
					global::System.IO.MemoryStream memoryStream;
					string text2;
					string text;
					string text3;
					switch (num2)
					{
					case 0:
						goto IL_1C0;
					case 1:
						base.ProgressIndicator.SetCurrentScope(0, 7);
						base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
						num = (short)1728118784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_71;
						}
						continue;
					case 3:
						goto IL_124;
					case 4:
					{
						try
						{
							fileData = memoryStream.ToArray();
							goto IL_96;
						}
						finally
						{
							num = (short)1835925504;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_334;
									}
									continue;
								case 1:
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)1203044354;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_36B;
								}
								IL_334:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)1955594241;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_36B:;
						}
						return pbaObject;
						IL_96:
						num = (short)1626781677;
						short num3 = num;
						num = (short)226342893;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)275513344;
							if (num != 0)
							{
							}
							num = (short)2030895104;
							short num4 = num;
							num = (short)491388931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 5:
						num = (short)1265696776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						text = text2;
						goto IL_2C0;
					case 7:
						if (!string.IsNullOrEmpty(text3))
						{
							num = (short)871825413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)992477190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)679870465;
						if (num != 0)
						{
						}
						text = global::Motorola.Common.Communication.Crc32.c("\udcf2", a_) + text2;
						goto IL_2C0;
					}
					IL_71:
					if (base.ProgressIndicator != null)
					{
						num = (short)8323073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1C0:
					cpversion = base.IOController.QueryCodeplugVersion();
					ushort compInstance = 2;
					uint num5;
					base.IOController.ReadComponentFile(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, compInstance, out num5, out text3);
					text2 = 1U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + global::Motorola.Common.Communication.Crc32.c("곲", a_) + compInstance.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + global::Motorola.Common.Communication.Crc32.c("곲쓴\ud9f6髸雺跼", a_);
					text3 = text3.Trim(new char[1]);
					num = (short)8781831;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C0:
					string filePath = text;
					ushort filePartition = 0;
					fileData = null;
					memoryStream = base.IOController.FileRead(filePartition, filePath, null);
					num = (short)693829636;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_124:
				pbaObject = new global::Motorola.Common.Communication.CommonFile.PartitionCommonFile(true).Deserialize(fileData);
				pbaObject.CodeplugData.CPVersion = cpversion;
				if (base.ProgressIndicator != null)
				{
					base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
				}
				return pbaObject;
			}
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003B38 File Offset: 0x00001D38
		private void a(global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo A_0, global::Motorola.Common.Communication.Pba.PbaObject A_1, bool A_2)
		{
			int a_ = 11;
			short num = (short)199229440;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B3;
				}
				bool a_2;
				for (;;)
				{
					IL_30:
					global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage3;
					string empty3;
					switch (num2)
					{
					case 0:
					{
						this.a += 1.0;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage;
						string empty;
						this.f.a(astroMemoryImage.ComponentName, out empty);
						this.d.a(empty, a_2, this.c, new global::Motorola.Common.Communication.c.a(this.b));
						num = (short)782303245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (A_1 != null)
						{
							num = (short)650313729;
							if (num != 0)
							{
							}
							num = (short)1163788312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EB;
					case 2:
					{
						a_2 = false;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage2 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.MACE);
						string empty2 = string.Empty;
						num = (short)740098075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						this.e = true;
						num = (short)578158596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (A_2)
						{
							num = (short)887881734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_141;
					case 5:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						if (memoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFileFlashSequenceManager.<>c.<>9.e)))
						{
							num = (short)1465843724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A8;
					}
					case 6:
					{
						num = (short)382009344;
						short num3 = num;
						a_2 = false;
						num = (short)1707147293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						if (A_0 == null)
						{
							num = (short)1102643210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.d.a(new global::Motorola.Common.Communication.c.a(this.e));
						byte a_3 = this.d.a(1);
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages = A_1.UpdateData.MemoryImages;
						num = (short)1518403606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						num = (short)504739124;
						short num4 = num;
						num = (short)45004084;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1A3;
						default:
							num = (short)899743744;
							if (num != 0)
							{
							}
							goto IL_1F2;
						}
						break;
					}
					case 9:
						num = (short)1721368593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_765;
					case 11:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						if (memoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFileFlashSequenceManager.<>c.<>9.d)))
						{
							num = (short)1114963970;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F2;
					}
					case 12:
					{
						a_2 = false;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.OPTION);
						string empty = string.Empty;
						num = (short)630587408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_1A8;
					case 14:
						goto IL_53D;
					case 15:
						goto IL_1A3;
					case 16:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage;
						if (!string.IsNullOrEmpty(astroMemoryImage.ComponentName))
						{
							num = (short)633929728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7AD;
					}
					case 17:
					{
						byte a_3;
						if (this.d.b(global::Motorola.Common.Communication.Crc32.c("뿮뗰ꟲ듴", a_), global::Motorola.Common.Communication.Crc32.c("뿮뗰ꟲ럴", a_), (uint)a_3) != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
						{
							num = (short)783220766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 18:
					{
						a_2 = true;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						astroMemoryImage3 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.HOST);
						empty3 = string.Empty;
						num = (short)1800273939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						if (!string.IsNullOrEmpty(astroMemoryImage3.ComponentName))
						{
							num = (short)1736900611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D0;
					case 20:
					{
						this.a += 1.0;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage4;
						string empty4;
						this.f.a(astroMemoryImage4.ComponentName, out empty4);
						this.d.a(empty4, a_2, this.c, new global::Motorola.Common.Communication.c.a(this.a));
						num = (short)18087950;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						if (memoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFileFlashSequenceManager.<>c.<>9.f)))
						{
							num = (short)1208025111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53D;
					}
					case 22:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						if (memoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFileFlashSequenceManager.<>c.<>9.c)))
						{
							num = (short)1344274450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BA;
					}
					case 23:
					{
						a_2 = false;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage4 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.ACCY);
						string empty4 = string.Empty;
						num = (short)1644822553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						num = (short)437911559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage4;
						if (!string.IsNullOrEmpty(astroMemoryImage4.ComponentName))
						{
							num = (short)315752468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_463;
					}
					case 26:
					{
						this.a += 1.0;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage2;
						string empty2;
						this.f.a(astroMemoryImage2.ComponentName, out empty2);
						this.d.a(empty2, a_2, this.c, new global::Motorola.Common.Communication.c.a(this.c));
						num = (short)1752367112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage2;
						if (!string.IsNullOrEmpty(astroMemoryImage2.ComponentName))
						{
							num = (short)1359282202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5DC;
					}
					case 28:
						if (this.e)
						{
							num = (short)1471676425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 29:
						goto IL_141;
					case 30:
						goto IL_6E5;
					}
					goto IL_B3;
					IL_141:
					this.a += 1.0;
					this.f.a(astroMemoryImage3.ComponentName, out empty3);
					this.d.a(empty3, a_2, this.c, new global::Motorola.Common.Communication.c.a(this.d));
					num = (short)1182007311;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A8:
					num = (short)1390673941;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F2:
					num = (short)2061041669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BA:
					num = (short)523632651;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A3:
					goto IL_3BA;
					IL_53D:
					num = (short)1060438044;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1EB:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				IL_2D0:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_463:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_5DC:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_6E5:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_CopyPsdtFailed);
				IL_765:
				goto IL_1EB;
				IL_7AD:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_B3:
				a_2 = true;
				this.b = A_1.UpdateData.MemoryImages.Count<global::Motorola.Common.Communication.Pba.RadioImage>() + 2;
				this.a = 1.0;
				num = (short)2084962305;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00004368 File Offset: 0x00002568
		public override void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			short num = (short)87293953;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E4;
				case 1:
				{
					num = (short)141789998;
					short num3 = num;
					num = (short)761039662;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E6;
					default:
						num = (short)1960902657;
						if (num != 0)
						{
						}
						num = (short)1646198784;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					}
					break;
				}
				case 2:
					base.ProgressIndicator.SetCurrentScope(0, 7);
					num = (short)1164050432;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A2:
				if (base.ProgressIndicator == null)
				{
					break;
				}
				num = (short)1080033282;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E4:
			IL_E6:
			num = (short)438501376;
			short num4 = num;
			base.WriteLanguagePacks(langPackData);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000448C File Offset: 0x0000268C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void e(double A_0)
		{
			short num = (short)1809842177;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_FE;
				case 1:
				{
					num = (short)1165421376;
					short num3 = num;
					num = (short)1903618880;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_100;
					default:
						num = (short)1395785729;
						if (num != 0)
						{
						}
						num = (short)2134048768;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A9;
						}
						continue;
					}
					break;
				}
				case 2:
					base.ProgressIndicator.UpdateProgress(A_0 / 100.0 / (double)this.b, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash);
					num = (short)1219362816;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A9:
				if (base.ProgressIndicator == null)
				{
					break;
				}
				num = (short)324665346;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FE:
			IL_100:
			num = (short)954335232;
			short num4 = num;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000045C4 File Offset: 0x000027C4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void d(double A_0)
		{
			short num = (short)1863516161;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_FC;
				case 1:
				{
					num = (short)9386950;
					short num3 = num;
					num = (short)1008483270;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FE;
					default:
						num = (short)1394147329;
						if (num != 0)
						{
						}
						num = (short)367329280;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					}
					break;
				}
				case 2:
					base.ProgressIndicator.UpdateProgress(A_0 / (double)this.b + this.a / (double)this.b, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeHost);
					num = (short)827129856;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A3:
				if (base.ProgressIndicator == null)
				{
					break;
				}
				num = (short)1155661826;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FC:
			IL_FE:
			num = (short)660209664;
			short num4 = num;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000046F8 File Offset: 0x000028F8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void c(double A_0)
		{
			short num = (short)1432223745;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)783024129;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_FF;
				case 1:
				{
					num = (short)4250000;
					short num3 = num;
					num = (short)440588688;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_101;
					default:
						num = (short)2107179008;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						continue;
					}
					break;
				}
				case 2:
					base.ProgressIndicator.UpdateProgress(A_0 / (double)this.b + this.a / (double)this.b, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeMace);
					num = (short)1518469120;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A4:
				if (base.ProgressIndicator == null)
				{
					break;
				}
				num = (short)473038850;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FF:
			IL_101:
			num = (short)1305673728;
			short num4 = num;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00004830 File Offset: 0x00002A30
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b(double A_0)
		{
			short num = (short)483590145;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_FB;
				case 1:
				{
					num = (short)1196097537;
					if (num != 0)
					{
					}
					num = (short)1684635005;
					short num3 = num;
					num = (short)1386315133;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FD;
					default:
						num = (short)188153856;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					}
					break;
				}
				case 2:
					base.ProgressIndicator.UpdateProgress(A_0 / (double)this.b + this.a / (double)this.b, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeOptBrd);
					num = (short)471990272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A3:
				if (base.ProgressIndicator == null)
				{
					break;
				}
				num = (short)1953300482;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FB:
			IL_FD:
			num = (short)637534208;
			short num4 = num;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00004964 File Offset: 0x00002B64
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(double A_0)
		{
			short num = (short)2100887553;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_FD;
				case 1:
				{
					num = (short)204740604;
					short num3 = num;
					num = (short)817829884;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FF;
					default:
						num = (short)105971712;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					}
					break;
				}
				case 2:
					base.ProgressIndicator.UpdateProgress(A_0 / (double)this.b + this.a / (double)this.b, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeAccBrd);
					num = (short)381812737;
					if (num != 0)
					{
					}
					num = (short)487587840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_7B:
				if (base.ProgressIndicator == null)
				{
					break;
				}
				num = (short)1922826242;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FD:
			IL_FF:
			num = (short)2115371008;
			short num4 = num;
		}

		// Token: 0x04000003 RID: 3
		private double a;

		// Token: 0x04000004 RID: 4
		private int b;

		// Token: 0x04000005 RID: 5
		private int c;

		// Token: 0x04000006 RID: 6
		private readonly global::Motorola.Common.Communication.c d;

		// Token: 0x04000007 RID: 7
		private bool e;

		// Token: 0x04000008 RID: 8
		private global::Motorola.Common.Communication.a f;
	}
}
