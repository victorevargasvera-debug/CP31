using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Motorola.Common.Communication.CommonFile;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000D RID: 13
	public class AstroOtapFileSequenceManager : global::Motorola.Common.Communication.AstroFileSequenceManager, global::Motorola.Common.Communication.IDifferentialWritable, global::Motorola.Common.Communication.IFwdl, global::Motorola.Common.Communication.IUpdatesDeviceForFlash
	{
		// Token: 0x06000080 RID: 128 RVA: 0x000108A0 File Offset: 0x0000EAA0
		public AstroOtapFileSequenceManager(global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor rcmpWrapper, int inactivityTimer, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation) : base(rcmpWrapper, sessionParameter, operation)
		{
			this.a = inactivityTimer;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000108CC File Offset: 0x0000EACC
		protected override void ExitReadProgramMode()
		{
			short num = (short)1427100368;
			short num2 = num;
			num = (short)1105449680;
			switch (num2 == num)
			{
			}
			num = (short)404619264;
			short num3 = num;
			num = (short)504889344;
			if (num != 0)
			{
			}
			num = (short)1588461569;
			if (num != 0)
			{
			}
			base.IOController.ExitProgramMode(6, new byte[2]);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0001098C File Offset: 0x0000EB8C
		protected override void EnterWriteProgramMode()
		{
			short num = (short)1428122714;
			short num2 = num;
			num = (short)1024879706;
			switch (num2 == num)
			{
			}
			num = (short)54132736;
			short num3 = num;
			num = (short)1779236865;
			if (num != 0)
			{
			}
			num = (short)396558336;
			if (num != 0)
			{
			}
			byte[] data = new byte[]
			{
				(byte)(this.a / 256),
				(byte)(this.a & 255)
			};
			base.IOController.EnterProgramMode(4, data);
			((global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor)base.RcmpWrapper).ResetChecksum();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00010A78 File Offset: 0x0000EC78
		protected override void ExitWriteProgramMode()
		{
			ushort checksum = ((global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor)base.RcmpWrapper).Checksum;
			byte[] data = new byte[]
			{
				(byte)(checksum / 256),
				(byte)(checksum & 255)
			};
			short num;
			try
			{
				base.IOController.ExitProgramMode(6, data);
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure)
				{
					while (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeWriteFailure)
					{
						num = (short)2060587640;
						short num2 = num;
						num = (short)2069893752;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)992018432;
							if (num != 0)
							{
							}
							throw;
						}
					}
				}
			}
			num = (short)1834024960;
			short num3 = num;
			num = (short)1400766465;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00010B94 File Offset: 0x0000ED94
		protected override void EnterReadProgramMode()
		{
			short num = (short)1254152137;
			short num2 = num;
			num = (short)733992905;
			switch (num2 == num)
			{
			}
			num = (short)1205403648;
			short num3 = num;
			num = (short)1062207488;
			if (num != 0)
			{
			}
			num = (short)118226945;
			if (num != 0)
			{
			}
			byte[] data = new byte[]
			{
				(byte)(this.a / 256),
				(byte)(this.a & 255)
			};
			base.IOController.EnterProgramMode(5, data);
			((global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor)base.RcmpWrapper).ResetChecksum();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00010C80 File Offset: 0x0000EE80
		public override void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			int a_ = 19;
			short num = (short)343146496;
			switch (num)
			{
			default:
			{
				num = (short)1306394633;
				int num2 = (int)((global::System.IntPtr)num);
				ushort num4;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
						{
							num = (short)2036924424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1963261970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						ushort num3;
						base.IOController.ComponentSession(3, sessionID, out num3, out num4);
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Crc32.c("\ud9af삱\ud9b3솵\ud9b7좹\ud9bb麽꒿귁ꇃ뗅ꛇ룋ꏏꟑꓓꛕ럗꣙꣛ﻝꓟ诡苣胥跧飩觫胭蓯鯱闳髵\ud8f7극軻韽瓿朁", a_) + base.SessionParam.PreviousSessionID.ToString(), global::System.Array.Empty<object>());
						num = (short)1432813572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						if (base.IsRadioManagementOperation)
						{
							num = (short)1429471248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort num3;
						base.IOController.ComponentSession(3, sessionID, out num3, out num4);
						num = (short)1563688974;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (!this.DifferentialWriteCapableRadio)
						{
							num = (short)150470666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						goto IL_453;
					case 5:
						goto IL_115;
					case 6:
						if (operation != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
						{
							num = (short)552075271;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_267;
					case 7:
						num = (short)1212481556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						base.UnlockRadioPartition(212);
						this.EnterReadProgramMode();
						num = (short)28770319;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					case 10:
					{
						ushort num3;
						base.IOController.ComponentSession(7, sessionID, out num3, out num4);
						num = (short)2097872902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)20971521;
						if (num != 0)
						{
						}
						if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
						{
							num = (short)803143692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_115;
					case 12:
						base.UnlockRadioPartition(0);
						this.EnterWriteProgramMode();
						num = (short)815595537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_3C6;
					case 14:
						goto IL_397;
					case 15:
						goto IL_115;
					case 16:
						num = (short)609091587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_115;
					case 18:
						if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
						{
							num = (short)665124864;
							short num5 = num;
							num = (short)1715470349;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)593756171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1566179328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (base.isPre7_14_5_FW(base.IOController.SessionCommandReply.ReplyResult))
						{
							num = (short)635305985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_267;
					}
					IL_A2:
					if (operation != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create)
					{
						num = (short)1768947731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_115:
					num = (short)1883530628;
					short num6 = num;
					num = (short)2003854724;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_3C6:
						base.UnlockRadioPartition(212);
						this.EnterWriteProgramMode();
						num = (short)988938245;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1090781184;
						if (num != 0)
						{
						}
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Crc32.c("쒯펱쒳隵쪹\ud9bb킽釁ꇃ뗅믇ꏉꏋꃍ", a_) + base.IsRadioManagementOperation.ToString(), global::System.Array.Empty<object>());
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Crc32.c("\ud9af풱튳펵쪷\udfb9튻쪽ꦿꏁꣃ釅뫇ꏉ룋ꯍ鏏돑ꓓ럕뫗뛙맛賝臟蛡跣觥헧", a_) + this.DifferentialWriteCapableRadio.ToString(), global::System.Array.Empty<object>());
						num = (short)765591554;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_267:
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Crc32.c("ﲭﶯ銱쒵\uddb7첹햻톽떿뇁闅귇막뿋ꟍ뿏병鷓鋕ﳛ", a_) + base.SessionParam.PreviousSessionID.ToString(), global::System.Array.Empty<object>());
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Crc32.c("ﲭﶯ銱쎵쪷좹\ud9bb킽뒿韃ꏅ믇막ꗋꇍ뻏鯑郓龎", a_) + sessionID.ToString(), global::System.Array.Empty<object>());
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Crc32.c("ﲭ톯횱\uddb3\ud9b5颷惡즻첽늿ꟁ꫃닅駉꧋뷍ꏏ믑믓룕釗黙ﳛ샟", a_) + num4.ToString(), global::System.Array.Empty<object>());
				return;
				IL_397:
				return;
				IL_453:
				goto IL_267;
			}
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000111CC File Offset: 0x0000F3CC
		public override void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			short num = (short)919273476;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_8F;
				case 1:
				{
					num = (short)1696604965;
					short num3 = num;
					num = (short)1641685797;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11B;
					default:
						num = (short)1053687809;
						if (num != 0)
						{
						}
						num = (short)1198784512;
						if (num != 0)
						{
						}
						num = (short)645332994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_11B;
				case 3:
				{
					ushort num4;
					ushort num5;
					base.IOController.ComponentSession(1056, sessionID, out num4, out num5);
					base.ValidateUpdate();
					num = (short)327024640;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				}
				IL_3A:
				if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
				{
					num = (short)1965228033;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_167;
				IL_11B:
				num = (short)527302656;
				short num6 = num;
				if (pendingDeploy)
				{
					break;
				}
				num = (short)2120220675;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_59:
			this.ExitWriteProgramMode();
			return;
			IL_8F:
			goto IL_59;
			IL_167:
			base.CloseSession(sessionID, operation, pendingDeploy);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0001134C File Offset: 0x0000F54C
		public override global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword, bool hostedDepotOperation)
		{
			int a_ = 2;
			short num = (short)364904449;
			if (num != 0)
			{
			}
			num = (short)1881759385;
			short num2 = num;
			num = (short)272981657;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1673854976;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1264648192;
			if (num != 0)
			{
			}
			bool isRadioManagementOperation = base.IsRadioManagementOperation;
			new global::Motorola.Common.Communication.Pba.PbaObject();
			byte[] buffer = writePBA.SerializeToBytes();
			base.ValidateCodeplugVersion(writePBA);
			if (!this.DifferentialWriteCapableRadio)
			{
				base.WriteValidation(writePBA);
			}
			if (writePBA.LanguagePackData != null && writePBA.LanguagePackData.LanguagePacks.Count > 0)
			{
				if (base.ProgressIndicator != null)
				{
					base.ProgressIndicator.SetCurrentScope(0, 60);
				}
				if (base.ExtendedDeviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap || base.ExtendedDeviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.None)
				{
					global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = writePBA.LanguagePackData.LanguagePacks[0] as global::Motorola.Common.Communication.Pba.AstroFilePackInfo;
					if (astroFilePackInfo != null && global::System.IO.File.Exists(astroFilePackInfo.sourceFilePath))
					{
						base.WriteLanguagePacks(writePBA.LanguagePackData);
					}
					else
					{
						astroFilePackInfo.warningOTAPErrorCode = global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_LPK_update_is_not_support_via_POP25;
					}
				}
				else
				{
					base.WriteLanguagePacks(writePBA.LanguagePackData);
				}
				if (base.ProgressIndicator != null)
				{
					base.ProgressIndicator.SetCurrentScope(61, 100);
				}
			}
			global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader codeplugCommFileHeader = new global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader();
			codeplugCommFileHeader.HeaderVer = 16;
			codeplugCommFileHeader.FullDelta = (this.DifferentialWriteCapableRadio ? global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug.Delta : global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug.Full);
			codeplugCommFileHeader.Level = global::Motorola.Common.Communication.CommonFile.InfoLevel.CodeplugData;
			string text = string.Empty;
			global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo = base.ExtendedDeviceInfo;
			if (((extendedDeviceInfo != null) ? extendedDeviceInfo.SerialNumber : null) != null)
			{
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo2 = base.ExtendedDeviceInfo;
				text = ((extendedDeviceInfo2 != null) ? extendedDeviceInfo2.SerialNumber : null);
			}
			if (text != null && text.EndsWith(global::Motorola.Common.Communication.Crc32.c("ꂜ", a_), global::System.StringComparison.Ordinal))
			{
				text = global::System.Text.Encoding.ASCII.GetString(global::System.Convert.FromBase64String(text));
			}
			if (this.DifferentialWriteCapableRadio && writePBA.DifferetialCodeplugData != null)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Crc32.c("\ud99c잠얢薤\udba8슪\ud9ac쪮龰鶲", a_) + text, global::System.Array.Empty<object>());
				this.WriteRadioCodeplug(new global::Motorola.Common.Communication.Pba.PbaObject
				{
					CodeplugData = writePBA.DifferetialCodeplugData
				}, false, false, codeplugCommFileHeader);
			}
			else
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Crc32.c("\udb9c춠쾢薤\udba8슪\ud9ac쪮龰鶲", a_) + text, global::System.Array.Empty<object>());
				this.WriteRadioCodeplug(writePBA, false, false, codeplugCommFileHeader);
			}
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(buffer, false);
			pbaObject.CodeplugData.ArchiveSessionID = sessionID;
			return pbaObject;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00011630 File Offset: 0x0000F830
		public override void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionId, bool hostedDepotOperation, int? userDefersAllowed = null)
		{
			short num = (short)28311568;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (base.ExtendedDeviceInfo.ConnectionInfo.OtapConnectionType == global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.LMR)
					{
						num = (short)384761867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B7;
				case 1:
					num = (short)1658650626;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (base.ExtendedDeviceInfo.ConnectionInfo.OtapConnectionType == global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.LTE)
					{
						num = (short)1183711239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2063269888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (base.ExtendedDeviceInfo.ConnectionInfo != null)
					{
						num = (short)231014401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3A2;
				case 4:
					goto IL_21F;
				case 5:
					goto IL_2F0;
				case 6:
					if (base.SessionParam != null)
					{
						num = (short)591265801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B7;
				case 7:
					goto IL_19B;
				case 8:
					goto IL_2B2;
				case 9:
				{
					num = (short)1311637504;
					short num3 = num;
					num = (short)1556021260;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					if (base.SessionParam != null)
					{
						num = (short)1073283077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DB;
				case 11:
					num = (short)689438726;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (base.IsRadioManagementOperation)
					{
						num = (short)181534724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B7;
				case 13:
					if (!base.IsRadioManagementOperation)
					{
						num = (short)1283391503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)974127118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (base.ExtendedDeviceInfo.ConnectionInfo.OtapConnectionType == global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.NONE)
					{
						num = (short)1645281288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DE;
				case 15:
					goto IL_1D9;
				case 16:
				{
					num = (short)1811524481;
					short num4 = num;
					num = (short)619817857;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2F0;
					default:
						num = (short)994377728;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_B7;
						}
						continue;
					}
					break;
				}
				case 17:
					num = (short)433389571;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B7:
				if (base.ExtendedDeviceInfo != null)
				{
					num = (short)175964177;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_3A2;
				IL_2B7:
				num = (short)42401802;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2F0:
				num = (short)1259798541;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_DB:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Standalone_Not_Supported_LMR_OTAP);
			IL_19B:
			num = (short)902692865;
			if (num != 0)
			{
			}
			base.UpdateDevice(pbaObject, sessionId, hostedDepotOperation, null);
			return;
			IL_1D9:
			goto IL_DB;
			IL_1DE:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError);
			IL_21F:
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(pbaObject, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			global::Motorola.Common.Communication.Pba.PbaObject writePBA = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(pbaObject.SerializeToBytes(), false);
			this.WriteDeviceFlash(writePBA, 0, null, hostedDepotOperation);
			pbaObject.CodeplugData.ArchiveSessionID = sessionId;
			return;
			IL_2B2:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Not_Supported_Radio_Firmware);
			IL_3A2:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Device_Connnection_Info_Missing);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000119EC File Offset: 0x0000FBEC
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00011A9C File Offset: 0x0000FC9C
		public bool DifferentialWriteCapableRadio
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)388296524;
				short num2 = num;
				num = (short)1235414860;
				switch (num2 == num)
				{
				}
				num = (short)91619328;
				short num3 = num;
				num = (short)877658113;
				if (num != 0)
				{
				}
				num = (short)1107886080;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)521078415;
				short num2 = num;
				num = (short)131794575;
				switch (num2 == num)
				{
				}
				num = (short)2076704768;
				short num3 = num;
				num = (short)1639120896;
				if (num != 0)
				{
				}
				num = (short)1656553473;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00011B4C File Offset: 0x0000FD4C
		public bool DifferentialWriteSupported(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			int a_ = 14;
			short num = (short)1898250240;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				bool result;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						num = (short)480930223;
						short num3 = num;
						num = (short)1424320943;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1AC;
						default:
							goto IL_355;
						}
						break;
					}
					case 1:
						if (base.IsRadioManagementOperation)
						{
							num = (short)2069823495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						if (base.IOController.SessionCommandReply.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)577896448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AC;
					case 3:
						goto IL_1F6;
					case 4:
						if (operation != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
						{
							num = (short)376373254;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_236;
					case 5:
						goto IL_236;
					case 6:
						num = (short)1713963016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)490864644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
						{
							num = (short)940834821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 9:
						if (base.SessionParam.PreviousSessionID > 0)
						{
							num = (short)1945436160;
							short num4 = num;
							num = (short)1434714122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 10:
						num = (short)616562689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_63;
					IL_1AC:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Crc32.c("슪쮬즮풰솲킴\ud9b6춸튺\udcbc펾雀뇂계돆곈裊곌뿎냐뇒맔닖诘뫚맜뛞軠쏢\ud8e4쟦", a_) + this.DifferentialWriteCapableRadio.ToString(), global::System.Array.Empty<object>());
					num = (short)162463747;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_236:
					ushort num5;
					ushort num6;
					base.IOController.ComponentSession(7, sessionID, base.SessionParam.PreviousSessionID, out num5, out num6);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Crc32.c("ﮨ趬ﾮ쎰횲쎴\udeb6횸캺캼龾鋀ꛂ뛄듆ꃈ꓊ꏌ蛎闐", a_) + base.SessionParam.PreviousSessionID.ToString(), global::System.Array.Empty<object>());
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Crc32.c("ﮨ趬쒰솲잴튶ힸ쾺鶼꓀냂뛄껆ꛈꗊ蓌诎", a_) + sessionID.ToString(), global::System.Array.Empty<object>());
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Crc32.c("ﮨ쪪즬욮\udeb0鎲슶쮸즺\ud8bc톾뗀雄ꋆ뫈룊꓌ꃎ뿐髒釔ﯚ", a_) + num6.ToString(), global::System.Array.Empty<object>());
					num = (short)990314498;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1F6:
				return result;
				IL_355:
				num = (short)1920073728;
				if (num != 0)
				{
				}
				this.DifferentialWriteCapableRadio = true;
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Crc32.c("슪쮬즮풰솲킴\ud9b6춸튺\udcbc펾雀뇂계돆곈裊곌뿎냐뇒맔닖诘뫚맜뛞軠쏢\ud8e4쟦", a_) + this.DifferentialWriteCapableRadio.ToString(), global::System.Array.Empty<object>());
				return true;
				IL_63:
				result = false;
				num = (short)773586945;
				if (num != 0)
				{
				}
				num = (short)1308885001;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00011ECC File Offset: 0x000100CC
		public bool SetFWDLConfig(ushort tg, string version)
		{
			int a_ = 8;
			short num = (short)720543402;
			short num2 = num;
			num = (short)39362218;
			switch (num2 == num)
			{
			}
			num = (short)2015166464;
			if (num != 0)
			{
			}
			num = (short)1736835072;
			short num3 = num;
			num = (short)2057240577;
			if (num != 0)
			{
			}
			bool flag = base.IOController.SetDownLoadTGVersion(tg, version);
			if (!flag)
			{
				string format = string.Format(global::Motorola.Common.Communication.Crc32.c("讪삮\udfb0햲\udcb4킶馸튼튾곀ꋂꯄꏆ귊곌ꛎ뷐뛒뇔뿘듚꿜￞뗠ꓢ\udfe4쟦鋨\udbea郬쿮郰鷲釴ퟶ뿸鋺迼鋾瘀戂眄戆⤈崊栌紎成稒稔礖⌘㬚昜⸞尠", a_), tg, version);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(format, global::System.Array.Empty<object>());
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_FWDL_Xcmp_SetupCommand_Failed);
			}
			return flag;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00011FC8 File Offset: 0x000101C8
		protected override global::Motorola.Common.Communication.Pba.PbaObject WriteDeviceFlash(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword, bool hostedDepotOperation)
		{
			int a_ = 16;
			short num = (short)2029453321;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string text;
				string text2;
				global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader codeplugCommFileHeader;
				bool flag;
				switch (num2)
				{
				case 0:
					if (writePBA.DifferetialCodeplugData != null)
					{
						num = (short)1911816214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4E4;
				case 1:
					num = (short)573505536;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (text.EndsWith(global::Motorola.Common.Communication.Crc32.c("險", a_), global::System.StringComparison.Ordinal))
					{
						num = (short)651886617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3D5;
				case 3:
					goto IL_301;
				case 4:
					text2 = null;
					goto IL_2E6;
				case 5:
					base.WriteValidation(writePBA);
					num = (short)1580793864;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (!this.DifferentialWriteCapableRadio)
					{
						num = (short)469827589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AC;
				case 7:
					goto IL_152;
				case 8:
					goto IL_1AC;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_9A;
					}
					continue;
				case 10:
					num = (short)559349762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)267124737;
					if (num != 0)
					{
					}
					if (this.DifferentialWriteCapableRadio)
					{
						num = (short)1204355073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4E4;
				case 12:
					if (text != null)
					{
						num = (short)1280966666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3D5;
				case 13:
				{
					global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo = base.ExtendedDeviceInfo;
					if (extendedDeviceInfo == null)
					{
						num = (short)1638727684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					text2 = extendedDeviceInfo.SerialNumber;
					goto IL_2E6;
				}
				case 14:
					goto IL_3D5;
				case 15:
					codeplugCommFileHeader.FullDelta = (this.DifferentialWriteCapableRadio ? global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug.Delta : global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug.Full);
					codeplugCommFileHeader.Level = global::Motorola.Common.Communication.CommonFile.InfoLevel.CodeplugData;
					text = string.Empty;
					num = (short)793837589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					base.UpdateOobeBeforeWrite(writePBA);
					base.UpdatePINPasswordBeforeWrite(writePBA);
					base.UpdateWiFiPasswordBeforeWrite(writePBA);
					base.UpdateExternalDataModemPasswordBeforeWrite(writePBA);
					num = (short)642187271;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					base.ProgressIndicator.SetCurrentScope(0, 7);
					num = (short)1987969047;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (base.IsRadioManagementOperation)
					{
						num = (short)1489633296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_152;
				case 19:
					flag = (null != null);
					goto IL_284;
				case 20:
					return writePBA;
				case 21:
				{
					num = (short)150754360;
					short num3 = num;
					num = (short)1697862712;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4CB;
					default:
					{
						num = (short)395902976;
						if (num != 0)
						{
						}
						global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo2 = base.ExtendedDeviceInfo;
						if (extendedDeviceInfo2 == null)
						{
							num = (short)925696019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = (extendedDeviceInfo2.SerialNumber != null);
						goto IL_284;
					}
					}
					break;
				}
				case 22:
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Crc32.c("쒬즮ힰ鎲얶킸쾺\ud8bc醾", a_) + text, global::System.Array.Empty<object>());
					global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
					pbaObject.CodeplugData = writePBA.DifferetialCodeplugData;
					base.UpdatePINPasswordBeforeWrite(pbaObject);
					base.UpdateWiFiPasswordBeforeWrite(pbaObject);
					base.UpdateExternalDataModemPasswordBeforeWrite(pbaObject);
					this.WriteRadioCodeplug(pbaObject, true, hostedDepotOperation, codeplugCommFileHeader);
					goto IL_4CB;
				}
				case 23:
					goto IL_E3;
				case 24:
					return writePBA;
				case 25:
				{
					num = (short)85786624;
					short num4 = num;
					text = global::System.Text.Encoding.ASCII.GetString(global::System.Convert.FromBase64String(text));
					num = (short)1942814734;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 26:
					num = (short)2006450189;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9A:
				if (base.ProgressIndicator != null)
				{
					num = (short)1256128529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_E3:
				num = (short)1437925394;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_152:
				num = (short)942342150;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AC:
				codeplugCommFileHeader = new global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader();
				codeplugCommFileHeader.HeaderVer = 16;
				num = (short)558825487;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_284:
				if (flag)
				{
					num = (short)1757020186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_301;
				IL_2E6:
				text = text2;
				num = (short)645529603;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_301:
				num = (short)210305036;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3D5:
				num = (short)500039691;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4CB:
				num = (short)285081620;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4E4:
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Crc32.c("\ud8ac쎮\uddb0鎲얶킸쾺\ud8bc醾", a_) + text, global::System.Array.Empty<object>());
				this.WriteRadioCodeplug(writePBA, true, hostedDepotOperation, codeplugCommFileHeader);
				num = (short)998244376;
				num2 = (int)((global::System.IntPtr)num);
			}
			return writePBA;
		}

		// Token: 0x04000060 RID: 96
		private int a = 180;

		// Token: 0x04000061 RID: 97
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private new bool b;
	}
}
