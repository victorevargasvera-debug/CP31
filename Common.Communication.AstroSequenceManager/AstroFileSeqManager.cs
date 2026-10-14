using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Motorola.Common.Communication.AmpConfigPackage;
using Motorola.Common.Communication.CommonFile;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.Common.Communication
{
	// Token: 0x02000013 RID: 19
	public class AstroFileSeqManager : global::Motorola.Common.Communication.AstroCpsSequenceManager, global::Motorola.Common.Communication.IDepotSequenceManager
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00012458 File Offset: 0x00010658
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00012508 File Offset: 0x00010708
		public new global::Motorola.Common.Communication.CommonUtil.SessionParameter SessionParam
		{
			get
			{
				short num = (short)460314827;
				short num2 = num;
				num = (short)2086852811;
				switch (num2 == num)
				{
				}
				num = (short)21102592;
				if (num != 0)
				{
				}
				num = (short)998899712;
				short num3 = num;
				num = (short)54657025;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)904043678;
				short num2 = num;
				num = (short)1723374750;
				switch (num2 == num)
				{
				}
				num = (short)628752384;
				if (num != 0)
				{
				}
				num = (short)614072320;
				short num3 = num;
				num = (short)841416705;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000125B4 File Offset: 0x000107B4
		public AstroFileSeqManager(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter) : base(rcmpWrapper, sessionParameter)
		{
			if (sessionParameter != null)
			{
				this.b = sessionParameter;
				return;
			}
			this.b = new global::Motorola.Common.Communication.CommonUtil.SessionParameter(0, false, null);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000125E4 File Offset: 0x000107E4
		public override void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			int a_ = 2;
			short num = (short)1857224704;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_60;
				}
				ushort num4;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						goto IL_336;
					case 1:
						if (operation != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create)
						{
							num = (short)1506934788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
					{
						if (this.SessionParam.ArchiveSession)
						{
							num = (short)706084873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort num3;
						base.IOController.ComponentSession(3, sessionID, out num3, out num4);
						num = (short)1536819205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						ushort num3;
						base.IOController.ComponentSession(3, sessionID, out num3, out num4);
						num = (short)1507328000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_1C8;
					case 5:
						goto IL_235;
					case 6:
						num = (short)1007550472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						num = (short)908115303;
						short num5 = num;
						num = (short)1389280615;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1C8;
						default:
							num = (short)250478592;
							if (num != 0)
							{
							}
							if (base.IOController.SessionCommandReply.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.InvalidParameter)
							{
								num = (short)248315910;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CA;
						}
						break;
					}
					case 8:
						if (base.IOController.RetryDifferentialWriteNotSupported)
						{
							num = (short)340656131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CA;
					case 9:
					{
						ushort num3;
						base.IOController.ComponentSession(7, sessionID, out num3, out num4);
						num = (short)1786839047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_60;
					IL_1C8:
					num = (short)1861025794;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CA:
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뛱鷳郵黷鿹軻鯽滿瘁洃朅搇崉縋服搏眑圓眕栗笙縛爝䔟瀡䔣䈥䄧䔩ఫጭု", a_) + base.DifferentialWriteCapableRadio.ToString(), global::System.Array.Empty<object>());
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꃱ맳훵ꣷ裹駻製槿洁焃甅⠇変椋納挏笑笓砕儗帙㰛⌝\u001f", a_) + this.SessionParam.PreviousSessionID.ToString(), global::System.Array.Empty<object>());
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꃱ맳훵믷迹軻賽旿氁瀃★嬇漉缋納礏紑稓引尗㨙ℛ㸝", a_) + sessionID.ToString(), global::System.Array.Empty<object>());
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꃱ闳鋵釷闹\udcfb뷽痿瀁瘃挅昇縉Ⰻ崍甏愑朓缕眗琙唛娝\u001fἡУ", a_) + num4.ToString(), global::System.Array.Empty<object>());
				return;
				IL_235:
				num = (short)849543169;
				if (num != 0)
				{
				}
				return;
				IL_336:
				goto IL_CA;
				IL_60:
				num = (short)2014314496;
				short num6 = num;
				base.OpenSession(sessionID, operation);
				num = (short)1636302849;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0001292C File Offset: 0x00010B2C
		public override void CloseSession(ushort sessionId, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			short num = (short)999096323;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1438253057;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					if (this.SessionParam.ArchiveSession)
					{
						num = (short)245366789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					ushort num3;
					ushort num4;
					base.IOController.ComponentSession(1, sessionId, out num3, out num4);
					num = (short)730791940;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_478;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 4:
					goto IL_543;
				case 5:
				{
					ushort num3;
					ushort num4;
					base.IOController.ComponentSession(1025, sessionId, out num3, out num4);
					num = (short)296747014;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					if (base.IOController.SessionCommandReply.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.InvalidParameter)
					{
						num = (short)258146314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_373;
				case 7:
					goto IL_4A5;
				case 8:
				{
					ushort num3;
					ushort num4;
					base.IOController.ComponentSession(1, sessionId, out num3, out num4);
					num = (short)1001717767;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
				{
					num = (short)1194262528;
					short num5 = num;
					if (base.IOController.RetryDifferentialWriteNotSupported)
					{
						num = (short)1425145864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_373;
				}
				case 10:
					num = (short)768671745;
					if (num != 0)
					{
					}
					num = (short)281477129;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
					{
						num = (short)566493186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_55:
				if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
				{
					num = (short)2066284544;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)10747915;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_373:
			this.ExitReadProgramMode();
			return;
			IL_478:
			try
			{
				num = (short)1053163526;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						ushort num3;
						ushort num4;
						base.IOController.ComponentSession(32, sessionId, out num3, out num4);
						num = (short)1460273165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						ushort num3;
						ushort num4;
						base.IOController.ComponentSession(32, sessionId, out num3, out num4);
						num = (short)484179975;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_2DF;
					case 3:
						goto IL_2C1;
					case 4:
						num = (short)1709375499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (base.IOController.SessionCommandReply.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.InvalidParameter)
						{
							num = (short)1172439054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C1;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_D8;
						}
						continue;
					case 7:
						goto IL_2C1;
					case 8:
						if (base.IOController.RetryDifferentialWriteNotSupported)
						{
							num = (short)1621426176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C1;
					case 9:
						goto IL_2C1;
					case 10:
					{
						ushort num3;
						ushort num4;
						base.IOController.ComponentSession(1056, sessionId, out num3, out num4);
						num = (short)2033909765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						if (!pendingDeploy)
						{
							num = (short)1111949322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort num3;
						ushort num4;
						base.IOController.ComponentSession(1, sessionId, out num3, out num4);
						num = (short)247529475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						if (!pendingDeploy)
						{
							num = (short)988282881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort num3;
						ushort num4;
						base.IOController.ComponentSession(1, sessionId, out num3, out num4);
						num = (short)1258946569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_2C1;
					case 14:
						num = (short)1862008840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D8:
					if (this.SessionParam.ArchiveSession)
					{
						num = (short)1874198532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2089484300;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C1:
					this.ExitWriteProgramMode();
					num = (short)833093634;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2DF:
				return;
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure)
				{
					goto IL_303;
				}
				IL_2F2:
				if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeWriteFailure)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_CloseSession_Fail);
				}
				IL_303:
				num = (short)343109587;
				short num6 = num;
				num = (short)1086615507;
				switch ((num6 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_2F2;
				default:
					num = (short)358612992;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Commit_Fail, global::Motorola.CommonCPS.ResourceRepository.Resources.Communication_SequenceManager_Astro_Commit_Fail);
				}
			}
			catch (global::System.Exception)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_CloseSession_Fail);
			}
			IL_4A5:
			IL_543:
			goto IL_373;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00012EB8 File Offset: 0x000110B8
		public override global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword, bool hostedDepotOperation)
		{
			int a_ = 9;
			short num = (short)626524161;
			if (num != 0)
			{
			}
			num = (short)1517613077;
			short num2 = num;
			num = (short)1837363221;
			switch (num2 == num)
			{
			}
			num = (short)539492352;
			short num3 = num;
			num = (short)1340342272;
			if (num != 0)
			{
			}
			new global::Motorola.Common.Communication.Pba.PbaObject();
			byte[] buffer = writePBA.SerializeToBytes();
			base.ValidateCodeplugVersion(writePBA);
			if (!base.DifferentialWriteCapableRadio)
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
						this.WriteLanguagePacks(writePBA.LanguagePackData);
					}
					else
					{
						astroFilePackInfo.warningOTAPErrorCode = global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_LPK_update_is_not_support_via_POP25;
					}
				}
				else
				{
					this.WriteLanguagePacks(writePBA.LanguagePackData);
				}
				if (base.ProgressIndicator != null)
				{
					base.ProgressIndicator.SetCurrentScope(61, 100);
				}
			}
			string text = string.Empty;
			global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo = base.ExtendedDeviceInfo;
			if (((extendedDeviceInfo != null) ? extendedDeviceInfo.SerialNumber : null) != null)
			{
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo2 = base.ExtendedDeviceInfo;
				text = ((extendedDeviceInfo2 != null) ? extendedDeviceInfo2.SerialNumber : null);
			}
			if (text != null && text.EndsWith(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("쓸", a_), global::System.StringComparison.Ordinal))
			{
				text = global::System.Text.Encoding.ASCII.GetString(global::System.Convert.FromBase64String(text));
			}
			if (base.DifferentialWriteCapableRadio && writePBA.DifferetialCodeplugData != null)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뷸鋺鯼駾℀吂眄渆紈渊⌌ℎ", a_) + text, global::System.Array.Empty<object>());
				this.WriteRadioCodeplug(new global::Motorola.Common.Communication.Pba.PbaObject
				{
					CodeplugData = writePBA.DifferetialCodeplugData
				}, false, false);
			}
			else
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뿸軺釼鏾℀吂眄渆紈渊⌌ℎ", a_) + text, global::System.Array.Empty<object>());
				this.WriteRadioCodeplug(writePBA, false, false);
			}
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(buffer, false);
			pbaObject.CodeplugData.ArchiveSessionID = sessionID;
			return pbaObject;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00013168 File Offset: 0x00011368
		public override void ForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID)
		{
			short num = (short)1844969473;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 2:
				{
					num = (short)270270464;
					short num3 = num;
					base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteCPDone);
					num = (short)1555038208;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					num = (short)215692018;
					short num4 = num;
					num = (short)1968452338;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AE;
					default:
						num = (short)1695023104;
						if (num != 0)
						{
						}
						num = (short)1727135745;
						if (num != 0)
						{
						}
						goto IL_8E;
					}
					break;
				}
				case 4:
					base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
					num = (short)808910851;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_AE;
				}
				IL_3D:
				if (base.ProgressIndicator != null)
				{
					num = (short)2043936772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_8E:
				this.WriteRadioCodeplug(writePBA, true, false);
				num = (short)916652037;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AE:
				if (base.ProgressIndicator == null)
				{
					break;
				}
				num = (short)452001794;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00013318 File Offset: 0x00011518
		public override void DepotForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID)
		{
			short num = (short)1184956417;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 2:
				{
					num = (short)220332032;
					short num3 = num;
					base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteCPDone);
					num = (short)1487405056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					num = (short)208562735;
					short num4 = num;
					num = (short)25324079;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AE;
					default:
						num = (short)1460666368;
						if (num != 0)
						{
						}
						num = (short)1527447553;
						if (num != 0)
						{
						}
						goto IL_8E;
					}
					break;
				}
				case 4:
					base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
					num = (short)1342570499;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_AE;
				}
				IL_3E:
				if (base.ProgressIndicator != null)
				{
					num = (short)1866727428;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_8E:
				this.WriteRadioCodeplug(writePBA, true, true);
				num = (short)417595397;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AE:
				if (base.ProgressIndicator == null)
				{
					break;
				}
				num = (short)1154023426;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000134CC File Offset: 0x000116CC
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			short num = (short)7470013;
			short num2 = num;
			num = (short)768932797;
			switch (num2 == num)
			{
			}
			num = (short)1966931969;
			if (num != 0)
			{
			}
			num = (short)1011941376;
			short num3 = num;
			num = (short)190447616;
			if (num != 0)
			{
			}
			return this.a(referencePba, sessionID);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00013580 File Offset: 0x00011780
		protected global::Motorola.Common.Communication.Pba.PbaObject ManagedReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData;
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_D1;
				case 1:
					num2 = (short)362610689;
					if (num2 != 0)
					{
					}
					if (languagePackData != null)
					{
						num2 = (short)238419970;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D1;
				case 2:
				{
					IL_85:
					pbaObject.LanguagePackData = languagePackData;
					num2 = (short)1116864512;
					short num3 = num2;
					num2 = (short)148111360;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
				IL_D1:
				num2 = (short)1298958943;
				short num4 = num2;
				num2 = (short)13339231;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_85;
				default:
					goto IL_105;
				}
			}
			IL_105:
			num2 = (short)1158742016;
			if (num2 != 0)
			{
			}
			return pbaObject;
			IL_1C:
			pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
			pbaObject = this.a(referencePba, sessionID);
			languagePackData = this.ReadLanguagePacksInfo();
			num2 = (short)373030913;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000136A8 File Offset: 0x000118A8
		private global::Motorola.Common.Communication.Pba.PbaObject a(global::Motorola.Common.Communication.Pba.PbaObject A_0, ushort A_1)
		{
			int a_ = 8;
			short num = (short)1323106304;
			switch (num)
			{
			default:
			{
				num = (short)44498946;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
				for (;;)
				{
					global::System.IO.MemoryStream memoryStream;
					byte[] fileData;
					string text;
					string text2;
					string text4;
					string text3;
					switch (num2)
					{
					case 0:
					{
						try
						{
							fileData = memoryStream.ToArray();
							goto IL_ED;
						}
						finally
						{
							num = (short)1577517057;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_395;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_35E;
									}
									continue;
								case 2:
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)1017839616;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_35E:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)941555714;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_395:;
						}
						goto IL_398;
						IL_ED:
						pbaObject = new global::Motorola.Common.Communication.CommonFile.PartitionCommonFile(true).Deserialize(fileData);
						char[] trimChars = new char[]
						{
							'\0',
							' ',
							'\r',
							'\n'
						};
						pbaObject.CodeplugData.CPVersion = text.TrimEnd(trimChars);
						num = (short)140902409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)781254657;
						if (num != 0)
						{
						}
						goto IL_20E;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_79;
						}
						continue;
					case 3:
						if (!string.IsNullOrEmpty(text2))
						{
							num = (short)1331953672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1207828490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_18F;
					case 5:
						base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
						num = (short)1107951617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
						num = (short)835846148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						text3 = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ퟷ", a_) + text4;
						goto IL_2E4;
					case 8:
						num = (short)1996226567;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (base.ProgressIndicator != null)
						{
							num = (short)1052246022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_398;
					case 10:
						text3 = text4;
						goto IL_2E4;
					}
					IL_79:
					num = (short)1301382303;
					short num3 = num;
					num = (short)191923359;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18F;
					default:
						num = (short)1055588352;
						if (num != 0)
						{
						}
						if (base.ProgressIndicator != null)
						{
							num = (short)1463812101;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					IL_20E:
					text = base.IOController.QueryCodeplugVersion();
					ushort compInstance = 2;
					uint num4;
					base.IOController.ReadComponentFile(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, compInstance, out num4, out text2);
					text4 = 1U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꟷ", a_) + compInstance.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꟷ쯹틻鷽淿爁", a_);
					text2 = text2.Trim(new char[1]);
					num = (short)326500355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E4:
					string filePath = text3;
					ushort filePartition = 0;
					fileData = null;
					memoryStream = base.IOController.FileRead(filePartition, filePath, base.ProgressIndicator);
					num = (short)1509621760;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_18F:
				IL_398:
				num = (short)1469251584;
				short num5 = num;
				base.UpdatePINPasswordAfterRead(pbaObject);
				base.UpdateWiFiPasswordAfterRead(pbaObject);
				base.UpdateExternalDataModemPasswordAfterRead(pbaObject);
				pbaObject.CodeplugData.ArchiveSessionID = A_1;
				return pbaObject;
			}
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00013AB0 File Offset: 0x00011CB0
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList)
		{
			short num = (short)1932066816;
			switch (num)
			{
			default:
			{
				num = (short)1836974082;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (base.ProgressIndicator != null)
						{
							num = (short)480903169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_113;
					case 1:
						base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
						num = (short)1877803011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_64;
						}
						continue;
					case 3:
						goto IL_1D7;
					case 4:
						list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>(blockList.Count);
						num = (short)814415879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (blockList.Any<T>())
						{
							num = (short)635764740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_372;
					case 6:
						num = (short)778305541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						try
						{
							global::System.Collections.Generic.IEnumerator<T> enumerator = blockList.GetEnumerator();
							try
							{
								num = (short)1358692353;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
										switch (0)
										{
										case 0:
											goto IL_21F;
										}
										continue;
									case 2:
										goto IL_2A5;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)372441092;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										object obj = enumerator.Current;
										list.Add((global::Motorola.Common.Communication.CommonUtil.IshHeader)obj);
										num = (short)1884553216;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										num = (short)738394114;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_221:
									num = (short)399376387;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_21F:
									goto IL_221;
								}
								IL_2A5:;
							}
							finally
							{
								for (;;)
								{
									num = (short)456327169;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_312;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_2DC;
											}
											continue;
										case 2:
											enumerator.Dispose();
											num = (short)174587904;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_2DC:
										if (enumerator == null)
										{
											break;
										}
										num = (short)809435138;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_314:
									num = (short)512093648;
									short num3 = num;
									num = (short)1051192784;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										goto IL_34C;
									}
									IL_312:
									goto IL_314;
								}
								IL_34C:
								num = (short)2084110336;
								if (num != 0)
								{
								}
							}
							goto IL_AD;
						}
						catch (global::System.InvalidCastException systemException)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgumentType, systemException);
						}
						goto IL_372;
						IL_AD:
						num = (short)182779904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_64:
					num = (short)1529675777;
					if (num != 0)
					{
					}
					if (blockList == null)
					{
						goto IL_372;
					}
					num = (short)263782406;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_113:
				num = (short)1241448448;
				short num4 = num;
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug = this.ReadIshItems(list);
				pbaObject.SetCodeplug(codeplug);
				base.UpdatePINPasswordAfterRead(pbaObject);
				base.UpdateWiFiPasswordAfterRead(pbaObject);
				base.UpdateExternalDataModemPasswordAfterRead(pbaObject);
				return pbaObject;
				IL_1D7:
				goto IL_113;
				IL_372:
				throw new global::System.ArgumentNullException();
			}
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00013E68 File Offset: 0x00012068
		protected override global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadIshItems(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaders)
		{
			short num = (short)2035269645;
			short num2 = num;
			num = (short)1141817357;
			switch (num2 == num)
			{
			}
			num = (short)2103050240;
			short num3 = num;
			num = (short)717357057;
			if (num != 0)
			{
			}
			num = (short)677773312;
			if (num != 0)
			{
			}
			string text;
			return base.IOController.ReadItemsByIshHeaders(ishHeaders, out text, null);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00013F20 File Offset: 0x00012120
		public override global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo()
		{
			int a_ = 17;
			short num = (short)2007508400;
			short num2 = num;
			num = (short)1672226224;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_99;
			case 1:
				break;
			default:
			{
				num = (short)1574043648;
				short num3 = num;
				break;
			}
			}
			num = (short)1474887680;
			if (num != 0)
			{
			}
			num = (short)1310392320;
			switch (num)
			{
			default:
			{
				IL_99:
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> list = base.IOController.ListDirectoryContents(0, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("⸀伂䐄䤆丈帊䰌䠎吐㰒", a_));
				global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
				using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct>.Enumerator enumerator = list.GetEnumerator())
				{
					num = (short)83755012;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							global::Motorola.Common.Communication.Pba.FileListItemStruct fileListItemStruct;
							if (fileListItemStruct.FileType == global::Motorola.Common.Communication.Pba.FileListItemStruct.TypeOfFile.File)
							{
								num = (short)851443714;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							num = (short)93585414;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = new global::Motorola.Common.Communication.Pba.AstroFilePackInfo();
							global::Motorola.Common.Communication.Pba.FileListItemStruct fileListItemStruct;
							astroFilePackInfo.radioFilePath = fileListItemStruct.FileName;
							astroFilePackInfo.radioFileSize = fileListItemStruct.FileSize;
							languagePackData.LanguagePacks.Add(astroFilePackInfo);
							num = (short)1926430725;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)157876225;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.Pba.FileListItemStruct fileListItemStruct = enumerator.Current;
							num = (short)1734606848;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_104;
							}
							continue;
						case 6:
							goto IL_1DC;
						}
						IL_144:
						num = (short)1991376899;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_104:
						goto IL_144;
					}
					IL_1DC:;
				}
				num = (short)1632370689;
				if (num != 0)
				{
				}
				languagePackData.AvailableSpace = base.IOController.GetFreeSpace(0, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("⸀伂䐄䤆丈帊䰌䠎吐㰒", a_));
				return languagePackData;
			}
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00014180 File Offset: 0x00012380
		public override void DeleteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			int a_ = 11;
			short num = (short)415170560;
			switch (num)
			{
			default:
			{
				num = (short)1814495238;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)747896832;
					short num3 = num;
					global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
					global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.LanguagePackBase> languagePacks;
					global::System.Func<global::Motorola.Common.Communication.Pba.LanguagePackBase, bool> predicate;
					bool flag;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct>.Enumerator enumerator;
					global::System.Collections.Generic.List<string> list;
					switch (num2)
					{
					case 0:
						goto IL_671;
					case 1:
						goto IL_59F;
					case 2:
					{
						byte[] array;
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array);
						num = (short)1609498625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (astroFilePackInfo.sourceFilePath != null)
						{
							num = (short)216662024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						num = (short)1147273219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						byte[] array;
						if (array != null)
						{
							num = (short)677052418;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_71A;
					}
					case 6:
						switch (0)
						{
						case 0:
							goto IL_A9;
						}
						continue;
					case 7:
						languagePacks = langPackData.LanguagePacks;
						if ((predicate = global::Motorola.Common.Communication.AstroFileSeqManager.<>c.<>9__17_0) == null)
						{
							goto IL_639;
						}
						goto IL_652;
					case 8:
					{
						byte[] array = new global::Motorola.Common.Communication.d().a(astroFilePackInfo);
						num = (short)1014104069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (flag)
						{
							num = (short)1148387332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
						num = (short)1320288263;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						try
						{
							num = (short)510001154;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)258801668;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2087714816;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.FileListItemStruct fileListItemStruct = enumerator.Current;
									list.Add(fileListItemStruct.FileName);
									num = (short)756974501;
									short num4 = num;
									num = (short)74613669;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)2101411840;
										if (num != 0)
										{
										}
										num = (short)483328003;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_232;
									}
									continue;
								case 4:
									goto IL_303;
								}
								IL_234:
								num = (short)737804289;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_232:
								goto IL_234;
							}
							IL_303:
							goto IL_69D;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_7;
						IL_69D:
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2 = langPackData.LanguagePacks.GetEnumerator();
						num = (short)1481768972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_316;
					}
					IL_A9:
					num = (short)812711937;
					if (num != 0)
					{
					}
					if (langPackData != null)
					{
						num = (short)197066762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					Block_7:
					global::System.Collections.Generic.List<string> list2;
					try
					{
						IL_316:
						num = (short)515899400;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2;
								if (list.Contains(global::System.IO.Path.GetFileName(astroFilePackInfo2.radioFilePath)))
								{
									num = (short)1321467907;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)595722245;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
							{
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2;
								list2.Insert(0, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("퓺뇼뻾伀䐂倄䘆丈上∌", a_) + astroFilePackInfo2.radioFilePath);
								num = (short)1792475146;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_58C;
							case 3:
								num = (short)1555890190;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								flag = true;
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2;
								astroFilePackInfo = astroFilePackInfo2;
								num = (short)1936719879;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
							{
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2;
								if (astroFilePackInfo2.fileType == global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest)
								{
									num = (short)1727135748;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
								if (!enumerator2.MoveNext())
								{
									num = (short)1430323211;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2 = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)enumerator2.Current;
								num = (short)1550254080;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
								switch (0)
								{
								case 0:
									goto IL_379;
								}
								continue;
							case 9:
								if (astroFilePackInfo.radioFilePath != null)
								{
									num = (short)1646067713;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 11:
								num = (short)566099970;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 13:
							{
								flag = true;
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2;
								astroFilePackInfo = astroFilePackInfo2;
								num = (short)1210646537;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 14:
							{
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2;
								if (astroFilePackInfo2.fileType == global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest)
								{
									num = (short)103940109;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								list2.Add(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("퓺뇼뻾伀䐂倄䘆丈上∌", a_) + astroFilePackInfo2.radioFilePath);
								num = (short)1916731404;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_493:
							num = (short)131078;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_379:
							goto IL_493;
						}
						IL_58C:
						goto IL_1B0;
					}
					finally
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
						((global::System.IDisposable)enumerator2).Dispose();
					}
					goto Block_8;
					IL_1B0:
					base.IOController.DeleteFilesOrDirectory(0, list2);
					num = (short)1288896521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_652:
					if (languagePacks.Any(predicate))
					{
						num = (short)192413696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> list3 = base.IOController.ListDirectoryContents(0, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("퓺뇼뻾伀䐂倄䘆丈上∌", a_));
					list = new global::System.Collections.Generic.List<string>();
					list2 = new global::System.Collections.Generic.List<string>();
					astroFilePackInfo = new global::Motorola.Common.Communication.Pba.AstroFilePackInfo();
					flag = false;
					enumerator = list3.GetEnumerator();
					num = (short)1163591691;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_639:
					predicate = (global::Motorola.Common.Communication.AstroFileSeqManager.<>c.<>9__17_0 = new global::System.Func<global::Motorola.Common.Communication.Pba.LanguagePackBase, bool>(global::Motorola.Common.Communication.AstroFileSeqManager.<>c.<>9.a));
					goto IL_652;
					Block_8:
					try
					{
						IL_59F:
						global::System.IO.MemoryStream memoryStream;
						base.IOController.FileWrite(0, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("퓺뇼뻾伀䐂倄䘆丈上∌", a_) + astroFilePackInfo.sourceFilePath, memoryStream, null, false);
						return;
					}
					finally
					{
						num = (short)1050083328;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.IO.MemoryStream memoryStream;
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_5FF;
								}
								continue;
							case 1:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)167313410;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_636;
							}
							IL_5FF:
							if (memoryStream == null)
							{
								break;
							}
							num = (short)1141833729;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_636:;
					}
					goto IL_639;
				}
				IL_11D:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				IL_671:
				goto IL_11D;
				IL_71A:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
			}
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00014900 File Offset: 0x00012B00
		public override void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			short num = (short)715733956;
			short num2 = num;
			num = (short)980827076;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_93;
			case 1:
				break;
			default:
			{
				num = (short)1754398720;
				short num3 = num;
				break;
			}
			}
			num = (short)2066022400;
			if (num != 0)
			{
			}
			num = (short)1820590080;
			int num4 = (int)num;
			switch (num4)
			{
			default:
			{
				IL_93:
				num = (short)1993277441;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.l l = null;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_F2;
					}
					global::Motorola.Common.Communication.h h;
					global::Motorola.Common.Communication.Pba.LanguagePackData a_;
					global::Motorola.Common.Communication.Pba.LanguagePackData langPackData2;
					global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
					for (;;)
					{
						IL_C7:
						switch (num4)
						{
						case 0:
							goto IL_278;
						case 1:
							goto IL_278;
						case 2:
							switch (h)
							{
							case global::Motorola.Common.Communication.h.a:
								goto IL_278;
							case global::Motorola.Common.Communication.h.b:
								this.a(a_, false);
								num = (short)1441398784;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case global::Motorola.Common.Communication.h.c:
								this.a(a_, false);
								this.DeleteLanguagePacks(langPackData2);
								num = (short)1240072200;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case global::Motorola.Common.Communication.h.d:
								this.DeleteLanguagePacks(langPackData2);
								this.a(a_, false);
								num = (short)548995075;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case global::Motorola.Common.Communication.h.e:
								this.DeleteLanguagePacks(langPackData2);
								num = (short)1339490305;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case global::Motorola.Common.Communication.h.f:
								this.a(a_, true);
								num = (short)1992818692;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							default:
								num = (short)140509190;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 3:
							goto IL_278;
						case 4:
							goto IL_278;
						case 5:
							goto IL_278;
						case 6:
							num = (short)218038277;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_29E;
						case 8:
							goto IL_278;
						}
						goto IL_F2;
						IL_278:
						astroFilePackInfo.warningOTAPErrorCode = l.e();
						num = (short)1617166343;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_29E:
					return;
					IL_F2:
					global::Motorola.Common.Communication.CommonUtil.DeviceInfo extendedDeviceInfo = base.ExtendedDeviceInfo;
					string a_2 = base.j();
					astroFilePackInfo = (langPackData.LanguagePacks[0] as global::Motorola.Common.Communication.Pba.AstroFilePackInfo);
					l = new global::Motorola.Common.Communication.l(a_2, langPackData.ModelType, astroFilePackInfo.sourceFilePath, astroFilePackInfo.languageUpgradeType);
					global::Motorola.Common.Communication.Pba.LanguagePackData a_3 = this.ReadLanguagePacksInfo();
					h = l.b(extendedDeviceInfo, a_3, out langPackData2, out a_, astroFilePackInfo.isFlashPortUpgradeLP);
					num = (short)684326914;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_C7;
				}
				catch (global::Motorola.Common.CustomException.CommonException)
				{
					throw;
				}
				catch (global::System.Exception)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.AddLanguagePackFailure);
				}
				finally
				{
					num = (short)914489344;
					num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_2E1;
							}
							continue;
						case 1:
							l.f();
							num = (short)1025638402;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_319;
						}
						IL_2E1:
						if (l == null)
						{
							break;
						}
						num = (short)615514113;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_319:;
				}
				return;
			}
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00014C78 File Offset: 0x00012E78
		private void a(global::Motorola.Common.Communication.Pba.LanguagePackData A_0, bool A_1)
		{
			int a_ = 13;
			short num = (short)960364544;
			switch (num)
			{
			default:
			{
				num = (short)288227335;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.AstroFilePackInfo> list;
					global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
					global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.LanguagePackBase> languagePacks;
					global::System.Func<global::Motorola.Common.Communication.Pba.LanguagePackBase, bool> predicate;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.AstroFilePackInfo>.Enumerator enumerator;
					global::Motorola.Common.Communication.d d;
					double progressRate;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct>.Enumerator enumerator2;
					bool flag;
					global::System.Collections.Generic.List<string> list2;
					switch (num2)
					{
					case 0:
						list.Insert(list.Count, astroFilePackInfo);
						num = (short)345440280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteLanguagesDone);
						num = (short)966393858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_B54;
					case 3:
						languagePacks = A_0.LanguagePacks;
						if ((predicate = global::Motorola.Common.Communication.AstroFileSeqManager.<>c.<>9__19_0) == null)
						{
							predicate = (global::Motorola.Common.Communication.AstroFileSeqManager.<>c.<>9__19_0 = new global::System.Func<global::Motorola.Common.Communication.Pba.LanguagePackBase, bool>(global::Motorola.Common.Communication.AstroFileSeqManager.<>c.<>9.b));
							goto IL_A31;
						}
						goto IL_A31;
					case 4:
						try
						{
							num = (short)556007425;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									byte[] array;
									global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array);
									num = (short)897908740;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_6C3;
									}
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)548536325;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2 = enumerator.Current;
									byte[] array = d.b(astroFilePackInfo2);
									num = (short)412483590;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_A1E;
								case 4:
									try
									{
										num = (short)1539768321;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2;
											switch (num2)
											{
											case 0:
												goto IL_833;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_70B;
												}
												continue;
											case 2:
											{
												global::System.IO.MemoryStream memoryStream;
												base.IOController.FileWrite(0, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("틼돾䀀䴂䈄分䠈䰊䠌‎", a_) + astroFilePackInfo2.sourceFilePath, memoryStream, new global::Motorola.Common.Communication.IteratedProgressIndicator(base.ProgressIndicator, progressRate), false);
												num = (short)1317076992;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												goto IL_887;
											case 4:
											{
												if (A_1)
												{
													num = (short)1892155398;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.IO.MemoryStream memoryStream;
												base.IOController.FileWrite(0, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("틼돾䀀䴂䈄分䠈䰊䠌‎", a_) + astroFilePackInfo2.sourceFilePath, memoryStream, new global::Motorola.Common.Communication.IteratedProgressIndicator(base.ProgressIndicator, progressRate), true);
												num = (short)1006632963;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
												goto IL_7A7;
											case 6:
											{
												string str = astroFilePackInfo2.sourceFilePath.Replace(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("폼鏾焀", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("폼课洀猂", a_));
												global::System.IO.MemoryStream memoryStream;
												base.IOController.FileWrite(0, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("틼돾䀀䴂䈄分䠈䰊䠌‎", a_) + str, memoryStream, new global::Motorola.Common.Communication.IteratedProgressIndicator(base.ProgressIndicator, progressRate), true);
												num = (short)1741619205;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_70B:
											if (astroFilePackInfo2.fileType == global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest)
											{
												num = (short)444596226;
												num2 = (int)((global::System.IntPtr)num);
											}
											else
											{
												num = (short)1592852484;
												num2 = (int)((global::System.IntPtr)num);
											}
										}
										IL_7A7:
										IL_833:
										IL_887:;
									}
									finally
									{
										num = (short)490733569;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.IO.MemoryStream memoryStream;
											switch (num2)
											{
											case 0:
												((global::System.IDisposable)memoryStream).Dispose();
												num = (short)576061442;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_8BE;
												}
												continue;
											case 2:
												goto IL_8F8;
											}
											goto IL_8BE;
											IL_8C2:
											num = (short)459276288;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_8F8:
											num = (short)422375436;
											short num3 = num;
											num = (short)468054028;
											switch ((num3 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_8C2;
											default:
												goto IL_92D;
											}
											IL_8BE:
											if (memoryStream != null)
											{
												goto IL_8C2;
											}
											goto IL_8F8;
										}
										IL_92D:
										num = (short)904855552;
										if (num != 0)
										{
										}
									}
									break;
								case 5:
									num = (short)1334640643;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									byte[] array;
									if (array != null)
									{
										num = (short)2883584;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9FA;
								}
								}
								IL_944:
								num = (short)456720386;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6C3:
								goto IL_944;
							}
							IL_9FA:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
							IL_A1E:
							goto IL_5FC;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_A31;
						IL_5FC:
						num = (short)657588236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_5D9;
					case 6:
						goto IL_2A2;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_B1;
						}
						continue;
					case 8:
						if (astroFilePackInfo.sourceFilePath != null)
						{
							num = (short)1889861632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC4;
					case 9:
					{
						num = (short)999424000;
						short num4 = num;
						num = (short)354222100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)296747011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_5C0;
					case 12:
						if (base.ProgressIndicator != null)
						{
							num = (short)504627201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 13:
						goto IL_D5;
					case 14:
						num = (short)1142816784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_ABF;
					case 16:
						if (astroFilePackInfo.radioFilePath == null)
						{
							num = (short)250281999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_376;
					case 17:
					{
						num = (short)663945217;
						if (num != 0)
						{
						}
						try
						{
							num = (short)303300609;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_271;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1C8;
									}
									continue;
								case 2:
									if (global::System.IO.Path.GetExtension(enumerator2.Current.FileName) == global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("폼鋾漀攂", a_))
									{
										num = (short)620822533;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									goto IL_28F;
								case 4:
									if (!enumerator2.MoveNext())
									{
										num = (short)75563014;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1676673026;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									flag = true;
									num = (short)1902379008;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)1911947267;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_21C:
								num = (short)755630084;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1C8:
								goto IL_21C;
							}
							IL_271:
							IL_28F:
							goto IL_34F;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_2A2;
						IL_34F:
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator3 = A_0.LanguagePacks.GetEnumerator();
						num = (short)1769996311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLanguages);
						num = (short)70582285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (astroFilePackInfo != null)
						{
							num = (short)1651179526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC4;
					case 20:
						if (astroFilePackInfo.sourceFilePath == null)
						{
							num = (short)1633353742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_376;
					case 21:
						if (astroFilePackInfo != null)
						{
							num = (short)61997065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B56;
					case 22:
						if (base.ProgressIndicator != null)
						{
							num = (short)1784545298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D5;
					case 23:
						try
						{
							num = (short)1878261764;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)847708169;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)1691549704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo3;
									string item = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("틼돾䀀䴂䈄分䠈䰊䠌‎", a_) + astroFilePackInfo3.radioFilePath;
									list2.Add(item);
									base.IOController.DeleteFilesOrDirectory(0, list2);
									num = (short)1504247810;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_411;
									}
									continue;
								case 6:
								{
									global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo3;
									if (astroFilePackInfo3.fileType == global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest)
									{
										num = (short)401801223;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									list.Add(astroFilePackInfo3);
									num = (short)1224933381;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo3;
									astroFilePackInfo = astroFilePackInfo3;
									num = (short)631832587;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_5AD;
								case 9:
									if (astroFilePackInfo.radioFilePath != null)
									{
										num = (short)1783103491;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 10:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator3;
									if (!enumerator3.MoveNext())
									{
										num = (short)1937702913;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo3 = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)enumerator3.Current;
									num = (short)144179206;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									if (!A_1 && flag)
									{
										num = (short)50266112;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_4B1:
								num = (short)389873674;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_411:
								goto IL_4B1;
							}
							IL_5AD:
							goto IL_312;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator3;
							((global::System.IDisposable)enumerator3).Dispose();
						}
						goto IL_5C0;
						IL_312:
						num = (short)1311309843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_376;
					}
					IL_B1:
					if (A_0 != null)
					{
						num = (short)1966145546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5C0;
					IL_D5:
					list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.AstroFilePackInfo>(A_0.LanguagePacks.Count);
					list2 = new global::System.Collections.Generic.List<string>();
					astroFilePackInfo = null;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> list3 = base.IOController.ListDirectoryContents(0, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("틼돾䀀䴂䈄分䠈䰊䠌‎", a_));
					flag = false;
					enumerator2 = list3.GetEnumerator();
					num = (short)535953425;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A2:
					num = (short)574619656;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_376:
					d = new global::Motorola.Common.Communication.d(A_0);
					progressRate = 1.0 / (double)A_0.LanguagePacks.Count;
					enumerator = list.GetEnumerator();
					num = (short)103809028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5C0:
					num = (short)997588997;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A31:
					if (languagePacks.Any(predicate))
					{
						num = (short)1487929355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)296812566;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AC4:
					num = (short)1782382613;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_5D9:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				IL_ABF:
				goto IL_B56;
				IL_B54:
				return;
				IL_B56:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
			}
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0001588C File Offset: 0x00013A8C
		protected override void WriteRadioCodeplug(global::Motorola.Common.Communication.Pba.PbaObject writePBA, bool forceWrite, bool hostedDepotOperation)
		{
			int a_ = 13;
			short num = (short)1240858626;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader codeplugCommFileHeader2;
				global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader codeplugCommFileHeader;
				global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug fullDelta;
				global::System.IO.MemoryStream memoryStream;
				byte[] array;
				switch (num2)
				{
				case 0:
					codeplugCommFileHeader = codeplugCommFileHeader2;
					if (!base.DifferentialWriteCapableRadio)
					{
						goto IL_346;
					}
					fullDelta = global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug.Delta;
					goto IL_464;
				case 1:
					if (!forceWrite)
					{
						num = (short)127991825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_34C;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_7D;
					}
					continue;
				case 3:
					if (hostedDepotOperation)
					{
						num = (short)679739397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EB;
				case 4:
					goto IL_34C;
				case 5:
					base.UpdateMacAddressBeforeWrite(writePBA);
					num = (short)1721171976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_20B;
				case 7:
					if (base.ProgressIndicator != null)
					{
						num = (short)1255800848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					goto IL_EB;
				case 9:
					goto IL_244;
				case 10:
					try
					{
						memoryStream.Write(array, 0, array.Length);
						base.IOController.FileWrite(0, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("쳼ꃾ㌀専㐄⤆樈昊紌", a_), memoryStream, base.ProgressIndicator, false);
						goto IL_3CE;
					}
					finally
					{
						num = (short)242089985;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)1416364034;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_310;
								}
								continue;
							case 2:
								goto IL_343;
							}
							IL_310:
							if (memoryStream == null)
							{
								break;
							}
							num = (short)998572032;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_343:;
					}
					goto IL_346;
					IL_3CE:
					num = (short)2049900551;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
				{
					if (!forceWrite)
					{
						goto IL_121;
					}
					num = (short)24489990;
					short num3 = num;
					num = (short)479440902;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_88;
					default:
						num = (short)1430847488;
						if (num != 0)
						{
						}
						num = (short)1548550163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 12:
				{
					num = (short)1588002816;
					short num4 = num;
					base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
					num = (short)2128216073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 13:
					if (hostedDepotOperation)
					{
						num = (short)1678901263;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_20B;
				case 14:
					writePBA.CodeplugData.DataPartitions.RemoveAll(new global::System.Predicate<global::Motorola.Common.Communication.Pba.DataPartition>(global::Motorola.Common.Communication.AstroFileSeqManager.<>c.<>9.a));
					num = (short)877133825;
					if (num != 0)
					{
					}
					num = (short)2113601540;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_121;
				case 16:
					base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteCPDone);
					num = (short)152043538;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)422379534;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					return;
				case 19:
					num = (short)279642125;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_7D;
				IL_88:
				num = (short)701628428;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7D:
				if (base.ProgressIndicator != null)
				{
					goto IL_88;
				}
				goto IL_244;
				IL_EB:
				codeplugCommFileHeader2 = new global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader();
				codeplugCommFileHeader2.HeaderVer = 16;
				num = (short)1621164032;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_121:
				base.UpdateOobeBeforeWrite(writePBA);
				base.UpdatePINPasswordBeforeWrite(writePBA);
				base.UpdateWiFiPasswordBeforeWrite(writePBA);
				base.UpdateExternalDataModemPasswordBeforeWrite(writePBA);
				num = (short)965345286;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_20B:
				num = (short)359071747;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_244:
				num = (short)1833697281;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_34C:
				num = (short)222625803;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_464:
				codeplugCommFileHeader.FullDelta = fullDelta;
				codeplugCommFileHeader2.Level = global::Motorola.Common.Communication.CommonFile.InfoLevel.CodeplugData;
				array = new global::Motorola.Common.Communication.CommonFile.PartitionCommonFile(true).Serialize(codeplugCommFileHeader2, writePBA);
				memoryStream = new global::System.IO.MemoryStream();
				num = (short)254148618;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_346:
				fullDelta = global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug.Full;
				goto IL_464;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00015D4C File Offset: 0x00013F4C
		protected void WriteRadioDifferentialCodeplug(global::Motorola.Common.Communication.Pba.PbaObject writePBA, bool forceWrite)
		{
			int a_ = 19;
			short num = (short)1093992448;
			short num2 = num;
			num = (short)493551619;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.IO.MemoryStream memoryStream;
				byte[] array;
				switch (num3)
				{
				case 0:
					base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
					num = (short)1915879426;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_192;
				case 2:
					goto IL_1C4;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_83;
					}
					continue;
				case 4:
					base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteCPDone);
					num = (short)2062548999;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					writePBA.CodeplugData.DataPartitions.RemoveAll(new global::System.Predicate<global::Motorola.Common.Communication.Pba.DataPartition>(global::Motorola.Common.Communication.AstroFileSeqManager.<>c.<>9.b));
					base.UpdateOobeBeforeWrite(writePBA);
					base.UpdatePINPasswordBeforeWrite(writePBA);
					base.UpdateWiFiPasswordBeforeWrite(writePBA);
					base.UpdateExternalDataModemPasswordBeforeWrite(writePBA);
					num = (short)225509386;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					try
					{
						memoryStream.Write(array, 0, array.Length);
						base.IOController.FileWrite(0, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("㈂娄㔆嘈㨊⌌氎簐挒", a_), memoryStream, base.ProgressIndicator, false);
						goto IL_223;
					}
					finally
					{
						num = (short)1168310273;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								for (;;)
								{
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)1315928154;
									short num4 = num;
									num = (short)1985771610;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_161;
									}
								}
								IL_161:
								num = (short)2033909760;
								if (num != 0)
								{
								}
								num = (short)1908146178;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_10A;
								}
								continue;
							case 2:
								goto IL_18F;
							}
							IL_10A:
							if (memoryStream == null)
							{
								break;
							}
							num = (short)2077556736;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_18F:;
					}
					goto IL_192;
					IL_223:
					num = (short)1389035528;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					return;
				case 8:
					if (base.ProgressIndicator != null)
					{
						num = (short)414580740;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 9:
					num = (short)137035777;
					if (num != 0)
					{
					}
					if (!forceWrite)
					{
						num = (short)2024669185;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E9;
				case 10:
					goto IL_2E9;
				}
				IL_83:
				if (base.ProgressIndicator != null)
				{
					num = (short)173473792;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1C4;
				IL_192:
				num = (short)1463287813;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C4:
				num = (short)1160970249;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E9:
				global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader codeplugCommFileHeader = new global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader();
				codeplugCommFileHeader.HeaderVer = 16;
				codeplugCommFileHeader.FullDelta = global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug.Delta;
				codeplugCommFileHeader.Level = global::Motorola.Common.Communication.CommonFile.InfoLevel.CodeplugData;
				array = new global::Motorola.Common.Communication.CommonFile.PartitionCommonFile(true).Serialize(codeplugCommFileHeader, writePBA);
				memoryStream = new global::System.IO.MemoryStream();
				num = (short)78905350;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0400002D RID: 45
		private const int a = 1024;

		// Token: 0x0400002E RID: 46
		private global::Motorola.Common.Communication.CommonUtil.SessionParameter b;
	}
}
