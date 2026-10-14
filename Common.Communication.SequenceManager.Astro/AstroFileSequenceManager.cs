using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;
using authAES;
using Motorola.Common.Communication.CommonFile;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.Common.Communication
{
	// Token: 0x02000003 RID: 3
	public abstract class AstroFileSequenceManager : global::Motorola.Common.Communication.AstroSequenceManager, global::Motorola.Common.Communication.ILanguagePackSupport
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002558 File Offset: 0x00000758
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002608 File Offset: 0x00000808
		public global::Motorola.Common.Communication.CommonUtil.SessionParameter SessionParam
		{
			get
			{
				short num = (short)691339265;
				if (num != 0)
				{
				}
				num = (short)733282304;
				short num2 = num;
				num = (short)1426181936;
				short num3 = num;
				num = (short)1823461168;
				switch (num3 == num)
				{
				}
				num = (short)988741632;
				if (num != 0)
				{
				}
				return this.m_SessionParameter;
			}
			set
			{
				short num = (short)682046353;
				short num2 = num;
				num = (short)101725073;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1353383936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)262799361;
				if (num != 0)
				{
				}
				num = (short)1561460736;
				if (num != 0)
				{
				}
				this.m_SessionParameter = value;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000026B8 File Offset: 0x000008B8
		public AstroFileSequenceManager(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation) : base(rcmpWrapper, sessionParameter)
		{
			this.m_MaxTransportPacketSize = 1368;
			if (rcmpWrapper is global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor && this is global::Motorola.Common.Communication.AstroOtapFileSequenceManager)
			{
				if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
				{
					this.d = new global::Motorola.Common.Communication.y(rcmpWrapper, this.m_MaxTransportPacketSize);
				}
				else
				{
					this.m_MaxTransportPacketSize = 1368;
				}
			}
			base.IshHandler = new global::Motorola.Common.Communication.IshHandler.CommonIshHandler(rcmpWrapper, this.m_MaxTransportPacketSize);
			base.IOController = new global::Motorola.Common.Communication.IshHandler.IOController(rcmpWrapper, this.m_MaxTransportPacketSize, false);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000273C File Offset: 0x0000093C
		protected bool isPre7_14_5_FW(global::Motorola.Common.Communication.RcmpReplyResult ReplyResult)
		{
			if (ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.InvalidParameter)
			{
				short num = (short)2065629185;
				if (num != 0)
				{
				}
				num = (short)533721831;
				short num2 = num;
				num = (short)523498215;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1859780608;
					short num3 = num;
					num = (short)248119296;
					if (num != 0)
					{
					}
					break;
				}
				}
				return base.IOController.RetryDifferentialWriteNotSupported;
			}
			return false;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000027FC File Offset: 0x000009FC
		public override void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			short num = (short)843251713;
			if (num != 0)
			{
			}
			num = (short)1602617344;
			switch (num)
			{
			default:
			{
				num = (short)2050490376;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						ushort num3;
						ushort num4;
						base.IOController.ComponentSession(1025, sessionID, out num3, out num4);
						num = (short)247267334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						if (base.IsRadioManagementOperation)
						{
							num = (short)2092433408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort num3;
						ushort num4;
						base.IOController.ComponentSession(1, sessionID, out num3, out num4);
						num = (short)635043845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
						{
							num = (short)816513028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47D;
					case 3:
					{
						ushort num3;
						ushort num4;
						base.IOController.ComponentSession(1, sessionID, out num3, out num4);
						num = (short)105447431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_41A;
					case 5:
						goto IL_449;
					case 6:
						if (this.isPre7_14_5_FW(base.IOController.SessionCommandReply.ReplyResult))
						{
							num = (short)2094858243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_339;
					case 7:
						goto IL_478;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_93;
						}
						continue;
					case 9:
						num = (short)1767636993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_93:
					if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
					{
						num = (short)1254490121;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)85131266;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_339:
				this.ExitReadProgramMode();
				return;
				IL_41A:
				try
				{
					num = (short)1173096652;
					short num5 = num;
					num = (short)1120602316;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_1BF:
						num = (short)59965448;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)90439680;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_142;
						}
						break;
					}
					ushort num3;
					ushort num4;
					ushort actions;
					for (;;)
					{
						IL_10B:
						switch (num2)
						{
						case 0:
							goto IL_1DE;
						case 1:
							if (base.IsRadioManagementOperation)
							{
								num = (short)1908277250;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2CF;
						case 2:
							num = (short)1829044230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_2CF;
						case 4:
							if (!pendingDeploy)
							{
								num = (short)2040266757;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							base.IOController.ComponentSession(1, sessionID, out num3, out num4);
							num = (short)1323171843;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							base.IOController.ComponentSession(actions, sessionID, out num3, out num4);
							num = (short)118226945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (this.isPre7_14_5_FW(base.IOController.SessionCommandReply.ReplyResult))
							{
								num = (short)2110521351;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2CF;
						case 7:
							goto IL_2CA;
						case 8:
							goto IL_2CF;
						case 9:
							goto IL_2EE;
						case 10:
							if (base.IsRadioManagementOperation)
							{
								num = (short)55246859;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1DE;
						case 11:
							actions = 1056;
							num = (short)1694760960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_142;
						IL_1DE:
						num = (short)1336213508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2CF:
						this.ExitWriteProgramMode();
						num = (short)880869385;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2CA:
					base.IOController.ComponentSession(32, sessionID, out num3, out num4);
					goto IL_1BF;
					IL_2EE:
					goto IL_47D;
					IL_142:
					actions = 32;
					num = (short)1380188170;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_10B;
				}
				catch (global::Motorola.Common.CustomException.CommonException ex)
				{
					if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure || ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeWriteFailure)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Commit_Fail, global::Motorola.CommonCPS.ResourceRepository.Resources.Communication_SequenceManager_Astro_Commit_Fail);
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_CloseSession_Fail);
				}
				catch (global::System.Exception)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_CloseSession_Fail);
				}
				IL_449:
				IL_478:
				goto IL_339;
				IL_47D:
				num = (short)2118057984;
				short num6 = num;
				return;
			}
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002CE4 File Offset: 0x00000EE4
		protected override void WriteRadioCodeplug(global::Motorola.Common.Communication.Pba.PbaObject writePBA, bool forceWrite, bool hostedDepotOperation, global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader cplgHeader)
		{
			int a_ = 19;
			short num = (short)2032074753;
			if (num != 0)
			{
			}
			num = (short)2097217536;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition> dataPartitions;
				global::System.Predicate<global::Motorola.Common.Communication.Pba.DataPartition> match;
				global::System.IO.MemoryStream memoryStream;
				byte[] array;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_A2;
					}
					continue;
				case 1:
					if (forceWrite)
					{
						num = (short)1477902350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_41A;
				case 2:
					goto IL_C6;
				case 3:
					base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteCPDone);
					num = (short)1062666249;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					base.UpdateMacAddressBeforeWrite(writePBA);
					num = (short)1064370178;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_162;
				case 6:
					dataPartitions = writePBA.CodeplugData.DataPartitions;
					if ((match = global::Motorola.Common.Communication.AstroFileSequenceManager.<>c.<>9__12_0) == null)
					{
						match = (global::Motorola.Common.Communication.AstroFileSequenceManager.<>c.<>9__12_0 = new global::System.Predicate<global::Motorola.Common.Communication.Pba.DataPartition>(global::Motorola.Common.Communication.AstroFileSequenceManager.<>c.<>9.a));
						goto IL_393;
					}
					goto IL_393;
				case 7:
					goto IL_41A;
				case 8:
					goto IL_3E4;
				case 9:
					return;
				case 10:
					num = (short)737804294;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (hostedDepotOperation)
					{
						num = (short)728563719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F7;
				case 12:
					if (base.ProgressIndicator != null)
					{
						num = (short)140181507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 13:
					goto IL_F7;
				case 14:
					num = (short)277479435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
				{
					num = (short)1560805376;
					short num3 = num;
					if (!forceWrite)
					{
						num = (short)1713438730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E4;
				}
				case 16:
					try
					{
						memoryStream.Write(array, 0, array.Length);
						base.IOController.FileWrite(0, global::Motorola.Common.Communication.Crc32.c("龭肱螵隷\ud9b9톻캽", a_), memoryStream, base.ProgressIndicator, false);
						goto IL_273;
					}
					finally
					{
						num = (short)1657208834;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)1944059905;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_347;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_310;
								}
								continue;
							}
							IL_310:
							if (memoryStream != null)
							{
								num = (short)1761476608;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_347:
							num = (short)2056863957;
							short num4 = num;
							num = (short)2008563925;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_310;
							default:
								goto IL_37C;
							}
						}
						IL_37C:
						num = (short)1696792576;
						if (num != 0)
						{
						}
					}
					goto IL_393;
					IL_273:
					num = (short)1537736716;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
					num = (short)1326186501;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (hostedDepotOperation)
					{
						num = (short)636813316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C6;
				}
				IL_A2:
				if (base.ProgressIndicator != null)
				{
					num = (short)1604255761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_162;
				IL_C6:
				array = new global::Motorola.Common.Communication.CommonFile.PartitionCommonFile(true).Serialize(cplgHeader, writePBA);
				memoryStream = new global::System.IO.MemoryStream();
				num = (short)1997275152;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F7:
				num = (short)1687879698;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_162:
				num = (short)121110543;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_393:
				dataPartitions.RemoveAll(match);
				num = (short)1759313928;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3E4:
				num = (short)1840709633;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_41A:
				base.UpdateOobeBeforeWrite(writePBA);
				base.UpdatePINPasswordBeforeWrite(writePBA);
				base.UpdateWiFiPasswordBeforeWrite(writePBA);
				base.UpdateExternalDataModemPasswordBeforeWrite(writePBA);
				num = (short)1571553293;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00003158 File Offset: 0x00001358
		private static void a(global::System.Collections.Generic.Dictionary<global::System.Guid, string> A_0, string A_1)
		{
			int a_ = 19;
			short num = (short)13369344;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1478623232;
				short num3 = num;
				global::System.IO.Stream manifestResourceStream = global::System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(A_1);
				try
				{
					switch (0)
					{
					case 0:
						goto IL_80;
					}
					global::System.Xml.XmlNodeList xmlNodeList;
					for (;;)
					{
						IL_69:
						switch (num2)
						{
						case 0:
							goto IL_38A;
						case 1:
							try
							{
								num = (short)660602891;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Xml.XmlAttribute xmlAttribute;
										string value;
										A_0.Add(new global::System.Guid(xmlAttribute.Value), value);
										num = (short)1199898626;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										goto IL_2F6;
									case 3:
										goto IL_250;
									case 4:
									{
										global::System.Xml.XmlAttribute xmlAttribute2;
										if (xmlAttribute2 != null)
										{
											num = (short)1336606728;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_250;
									}
									case 5:
										num = (short)629407745;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
									{
										global::System.Collections.IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1890582533;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
										global::System.Xml.XmlAttribute xmlAttribute = xmlNode.Attributes[global::Motorola.Common.Communication.Crc32.c("톯\udeb1솳펵", a_)];
										global::System.Xml.XmlAttribute xmlAttribute2 = xmlNode.Attributes[global::Motorola.Common.Communication.Crc32.c("햯솱ힳ쒵톷쪹좻ힽ꾿곁", a_)];
										num = (short)358678538;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
									{
										global::System.Xml.XmlAttribute xmlAttribute;
										if (!A_0.ContainsKey(new global::System.Guid(xmlAttribute.Value)))
										{
											num = (short)1029832704;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 8:
									{
										global::System.Xml.XmlAttribute xmlAttribute2;
										string value = xmlAttribute2.Value;
										num = (short)630063107;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
									{
										string value = string.Empty;
										num = (short)440664068;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
									{
										global::System.Xml.XmlAttribute xmlAttribute;
										if (xmlAttribute != null)
										{
											num = (short)1463943177;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 11:
										switch (0)
										{
										case 0:
											goto IL_14B;
										}
										continue;
									}
									IL_177:
									num = (short)1415643142;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_14B:
									goto IL_177;
									IL_250:
									num = (short)624689159;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2F6:
								return;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_318;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_305:
									switch (num2)
									{
									case 0:
										disposable.Dispose();
										num = (short)619249665;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_36D;
									case 2:
										if (disposable != null)
										{
											num = (short)2121007104;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_36F;
									}
									goto IL_318;
								}
								IL_36D:
								IL_36F:
								goto EndFinally_12;
								IL_318:
								global::System.Collections.IEnumerator enumerator;
								disposable = (enumerator as global::System.IDisposable);
								num = (short)120520706;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_305;
								EndFinally_12:;
							}
							goto IL_370;
						case 2:
						{
							global::System.Collections.IEnumerator enumerator = xmlNodeList.GetEnumerator();
							num = (short)599719937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							if (xmlNodeList != null)
							{
								num = (short)1580072962;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_370;
						}
						goto IL_80;
						IL_370:
						num = (short)1256587264;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_38A:
					return;
					IL_80:
					global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
					xmlDocument.Load(manifestResourceStream);
					xmlNodeList = xmlDocument.SelectNodes(global::Motorola.Common.Communication.Crc32.c("삯솱펵즷쾹\ud9bb킽ꎿꟁ觃Ʂꛇꯉꯋꯍꋏ雑뗓ꋕ맗进ꯝ郟鋡诣铥鳧迩裫믭藯鯱郳뫵釷觹裻퇽嗿省洃戅", a_));
					num = (short)1908998147;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_69;
				}
				finally
				{
					num = (short)683474946;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							((global::System.IDisposable)manifestResourceStream).Dispose();
							num = (short)678690817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_421;
						case 2:
							num = (short)1469841409;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_3E9;
							}
							continue;
						}
						IL_3E9:
						if (manifestResourceStream != null)
						{
							num = (short)999161856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_421:
						num = (short)426149642;
						short num4 = num;
						num = (short)1031571210;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3E9;
						default:
							goto IL_456;
						}
					}
					IL_456:
					num = (short)745930752;
					if (num != 0)
					{
					}
				}
				return;
			}
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003608 File Offset: 0x00001808
		private static global::System.Collections.Generic.Dictionary<global::System.Guid, string> a()
		{
			int a_ = 4;
			short num = (short)2088204787;
			short num2 = num;
			num = (short)634419699;
			switch (num2 == num)
			{
			}
			num = (short)402653184;
			if (num != 0)
			{
			}
			num = (short)1300103169;
			if (num != 0)
			{
			}
			num = (short)1399848960;
			short num3 = num;
			global::System.Collections.Generic.Dictionary<global::System.Guid, string> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, string>();
			string a_2 = global::Motorola.Common.Communication.Crc32.c("튞캠힢쪤햦욨잪첬膮\udcb2\ud8b4\udab6횸햺鎼ﲾ껀껂꣄닆ꟈꋊ껌껎ꗐ뫒뫔맖飚규곞닠蛢铤鋦賨藪軬諮볰鋲鯴零黸黺迼믾怀眂搄⤆焈昊愌", a_);
			string a_3 = global::Motorola.Common.Communication.Crc32.c("튞캠힢쪤햦욨잪첬膮\udcb2\ud8b4\udab6횸햺鎼ﲾ껀껂꣄닆ꟈꋊ껌껎ꗐ뫒뫔맖飚규곞럠蛢韤鏦賨鏪뻬諮胰蛲郴駶髸黺냼黾漀戂戄戆笈伊氌笎瀐㴒洔稖甘", a_);
			global::Motorola.Common.Communication.AstroFileSequenceManager.a(dictionary, a_2);
			global::Motorola.Common.Communication.AstroFileSequenceManager.a(dictionary, a_3);
			return dictionary;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000036EC File Offset: 0x000018EC
		internal string b()
		{
			short num = (short)1071710208;
			switch (num)
			{
			default:
			{
				byte[] array = base.IOController.QueryRadioUUID();
				global::System.Guid guid = new global::System.Guid(array);
				string value;
				using (global::System.Collections.Generic.Dictionary<global::System.Guid, string>.Enumerator enumerator = global::Motorola.Common.Communication.AstroFileSequenceManager.a.Value.GetEnumerator())
				{
					num = (short)132972550;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)253653798;
						short num3 = num;
						num = (short)49509158;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1870921728;
							if (num != 0)
							{
							}
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									goto IL_121;
								}
								global::System.Collections.Generic.KeyValuePair<global::System.Guid, string> keyValuePair = enumerator.Current;
								num = (short)1183842308;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_1C1;
							case 2:
							{
								global::System.Collections.Generic.KeyValuePair<global::System.Guid, string> keyValuePair;
								value = keyValuePair.Value;
								num = (short)1305804803;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_1A7;
							case 4:
							{
								global::System.Collections.Generic.KeyValuePair<global::System.Guid, string> keyValuePair;
								if (keyValuePair.Key == guid)
								{
									num = (short)1922498562;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
								num = (short)1996619777;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_FD;
								}
								continue;
							}
							IL_FF:
							num = (short)1621622784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_FD:
							goto IL_FF;
						}
						IL_121:
						num = (short)396099589;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1A7:
					goto IL_1D4;
					IL_1C1:
					goto IL_43;
				}
				goto IL_1D4;
				IL_43:
				num = (short)1915355137;
				if (num != 0)
				{
				}
				return string.Empty;
				IL_1D4:
				num = (short)341966848;
				short num4 = num;
				return value;
			}
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003914 File Offset: 0x00001B14
		protected override global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadIshItems(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaders)
		{
			short num = (short)707635637;
			short num2 = num;
			num = (short)1441245621;
			switch (num2 == num)
			{
			}
			num = (short)569769985;
			if (num != 0)
			{
			}
			num = (short)1495793664;
			if (num != 0)
			{
			}
			num = (short)1044250624;
			short num3 = num;
			string text;
			return base.IOController.ReadItemsByIshHeaders(ishHeaders, out text, null);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000039CC File Offset: 0x00001BCC
		protected void UpdatePINPasswordAfterRead(global::Motorola.Common.Communication.Pba.PbaObject pbaForRead)
		{
			int a_ = 10;
			short num;
			try
			{
				num = (short)430505984;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_DA;
					}
					string encryptedPwd;
					for (;;)
					{
						IL_31:
						num = (short)857180346;
						short num3 = num;
						num = (short)1770752186;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1775239168;
							if (num != 0)
							{
							}
							string text;
							switch (num2)
							{
							case 0:
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.Crc32.c("슦\udea8讪ﺬ쪮튰욲잴\udeb6춸슺鶼ꃀ뇂뇄껆뷈ꋊꋌꇎꓒ볔ꏖ뇘ﯚ꧜럞蓠쏢諤详跨쯪诬蛮菰黲苴零诸黺퇼\udffe唀䬂䰄吆⤈䈊希⼎倐㌒尔外优娚儜嘞攠̢眤昦洨截戬Į", a_), global::System.Array.Empty<object>());
								num = (short)923009029;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								if (!global::Motorola.Common.Communication.AstroFileSequenceManager.a(text))
								{
									num = (short)1642987527;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1C2;
							case 2:
								text = string.Empty;
								num = (short)1586888718;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_427;
							case 4:
								goto IL_1C2;
							case 5:
								goto IL_3C8;
							case 6:
								text = global::authAES.AESCryptography.AESDecryptWithDefKey(encryptedPwd);
								num = (short)221773843;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								text = string.Empty;
								num = (short)378535940;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								if (global::Motorola.Common.Communication.v.e(pbaForRead))
								{
									num = (short)844693510;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								text = global::authAES.AESCryptography.AESDecrypt(encryptedPwd, (base.ExtendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo).ESN);
								num = (short)1261568020;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								num = (short)2026897420;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
								text = global::authAES.AESCryptography.AESDecrypt(encryptedPwd, (base.ExtendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo).ESN);
								num = (short)1741357057;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								if (!global::Motorola.Common.Communication.AstroFileSequenceManager.a(text))
								{
									num = (short)1225850882;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1C2;
							case 12:
								if (global::Motorola.Common.Communication.v.a(pbaForRead))
								{
									num = (short)248578065;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.Crc32.c("좦쒨욪\ud8ac솮\ud8b0킲풴쎶킸풺펼鋀ꛂ듄닆곈ꗊ껌꫎鳐닒믔뛖뻘뻚꿜胞ꃠ郢釤闦蛨듪ꓬ臮蟰鋲駴黶鷸ꓺ룼釾戀焂簄眆紈戊戌愎丐䌒琔搖樘氚爜洞䔠簢挤䬦䠨䰪Ĭ༮䈰嬲娴䈶唸强ᴼ夾⁀⩂⥄杆㵈⍊⡌潎㭐㱒㝔癖硘", a_), global::System.Array.Empty<object>());
								num = (short)774963218;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 13:
								if (!base.IsFirmwareSupport_ESN_Encryption_Decryption())
								{
									num = (short)1518600192;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3C8;
							case 14:
								goto IL_1C2;
							case 15:
								text = global::authAES.AESCryptography.AESDecryptWithDefKey(encryptedPwd);
								num = (short)1147011083;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 16:
								goto IL_40F;
							case 17:
								goto IL_346;
							case 18:
								goto IL_40F;
							case 19:
								if (!global::Motorola.Common.Communication.AstroFileSequenceManager.a(text))
								{
									num = (short)2112815114;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1C2;
							case 20:
								if (!global::Motorola.Common.Communication.AstroFileSequenceManager.a(text))
								{
									num = (short)212336655;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1C2;
							case 21:
								if (global::Motorola.Common.Communication.v.f(pbaForRead))
								{
									num = (short)825032713;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_40F;
							}
							goto IL_DA;
							IL_1C2:
							string a_2 = global::authAES.AESCryptography.AESEncryptWithDefKey(text);
							global::Motorola.Common.Communication.v.a(pbaForRead, a_2);
							num = (short)335478800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3C8:
							text = string.Empty;
							num = (short)1128595464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_40F:
							num = (short)1581580291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_346:
						num = (short)604962829;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_427:
					break;
					IL_DA:
					encryptedPwd = global::Motorola.Common.Communication.v.c(pbaForRead);
					num = (short)1461387285;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.Crc32.c("힦춨쪪\ud9ac쪮者﮴\ud8b8좺캼좾껀뇂ꇄ蛆꿈뿊꣌뷎菐뛒듔돖律뷚볜뛞跠蛢臤쟦黨苪駬蟮쯰폲軴쟶蓸", a_), new object[]
				{
					ex.Message
				});
				throw;
			}
			num = (short)1027866625;
			if (num != 0)
			{
			}
			num = (short)1027473408;
			short num4 = num;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003E9C File Offset: 0x0000209C
		private static bool a(string pwd)
		{
			int a_ = 5;
			short num = (short)1029498089;
			short num2 = num;
			num = (short)671474921;
			switch (num2 == num)
			{
			}
			num = (short)824115201;
			if (num != 0)
			{
			}
			num = (short)661192704;
			if (num != 0)
			{
			}
			num = (short)891224064;
			short num3 = num;
			return new global::System.Text.RegularExpressions.Regex(global::Motorola.Common.Communication.Crc32.c("ﺟ說钣讥醧膫톯龱캳颷醻黁髅雉鋍軑諕ﳗ蟙ꟛ쳟탡퓣鯥쳧", a_)).IsMatch(pwd);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003F68 File Offset: 0x00002168
		private global::Motorola.Common.Communication.Pba.PbaObject a(global::Motorola.Common.Communication.Pba.PbaObject A_0, ushort A_1)
		{
			int a_ = 4;
			short num = (short)1758593024;
			switch (num)
			{
			default:
			{
				num = (short)1502871562;
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
						num = (short)1958150151;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						try
						{
							fileData = memoryStream.ToArray();
							goto IL_9E;
						}
						finally
						{
							num = (short)755826690;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)131465217;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_375;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_339;
									}
									continue;
								}
								IL_339:
								if (memoryStream != null)
								{
									num = (short)945684480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_375:
								num = (short)1149942469;
								short num3 = num;
								num = (short)1597815493;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_339;
								default:
									goto IL_3AA;
								}
							}
							IL_3AA:
							num = (short)2034106368;
							if (num != 0)
							{
							}
						}
						goto IL_3C1;
						IL_9E:
						pbaObject = new global::Motorola.Common.Communication.CommonFile.PartitionCommonFile(true).Deserialize(fileData);
						char[] trimChars = new char[]
						{
							'\0',
							' ',
							'\r',
							'\n'
						};
						pbaObject.CodeplugData.CPVersion = text.TrimEnd(trimChars);
						num = (short)1239875589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (!string.IsNullOrEmpty(text2))
						{
							num = (short)1602027520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)214368264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
						num = (short)824377350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
						num = (short)907477001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (base.ProgressIndicator != null)
						{
							num = (short)607322116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C1;
					case 6:
						num = (short)1685979137;
						if (num != 0)
						{
						}
						goto IL_1BC;
					case 7:
					{
						num = (short)1450704896;
						short num4 = num;
						text3 = global::Motorola.Common.Communication.Crc32.c("낞", a_) + text4;
						goto IL_2BE;
					}
					case 8:
						text3 = text4;
						goto IL_2BE;
					case 9:
						goto IL_140;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_79;
						}
						continue;
					}
					IL_79:
					if (base.ProgressIndicator != null)
					{
						num = (short)427163651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1BC:
					text = base.IOController.QueryCodeplugVersion();
					ushort compInstance = 2;
					uint num5;
					base.IOController.ReadComponentFile(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, compInstance, out num5, out text2);
					text4 = 1U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + global::Motorola.Common.Communication.Crc32.c("삞", a_) + compInstance.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + global::Motorola.Common.Communication.Crc32.c("삞邠趢욤쪦\ud9a8", a_);
					text2 = text2.Trim(new char[1]);
					num = (short)186974210;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BE:
					string filePath = text3;
					ushort filePartition = 0;
					fileData = null;
					memoryStream = base.IOController.FileRead(filePartition, filePath, base.ProgressIndicator);
					num = (short)184287233;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_140:
				IL_3C1:
				this.UpdatePINPasswordAfterRead(pbaObject);
				base.UpdateWiFiPasswordAfterRead(pbaObject);
				base.UpdateExternalDataModemPasswordAfterRead(pbaObject);
				pbaObject.CodeplugData.ArchiveSessionID = A_1;
				return pbaObject;
			}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00004370 File Offset: 0x00002570
		protected global::Motorola.Common.Communication.Pba.PbaObject ManagedReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
			global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					pbaObject.LanguagePackData = languagePackData;
					num2 = (short)220372658;
					short num3 = num2;
					num2 = (short)1460510386;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return pbaObject;
					default:
						num2 = (short)1370161153;
						if (num2 != 0)
						{
						}
						num2 = (short)1104478208;
						if (num2 != 0)
						{
						}
						num2 = (short)903086081;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_F4;
				case 2:
					if (languagePackData != null)
					{
						num2 = (short)1948909568;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return pbaObject;
				}
				goto IL_1C;
			}
			IL_F4:
			num2 = (short)333840384;
			short num4 = num2;
			return pbaObject;
			IL_1C:
			pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
			pbaObject = this.a(referencePba, sessionID);
			languagePackData = this.ReadLanguagePacksInfo();
			num2 = (short)767098882;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000044A0 File Offset: 0x000026A0
		public void FlashRadioImageToFileSystem()
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_51;
			}
			short num;
			int num3;
			global::System.IO.MemoryStream memoryStream;
			byte[] array;
			for (;;)
			{
				IL_13:
				num = (short)1499529216;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_1C5;
				case 1:
					goto IL_197;
				case 2:
					if (base.ProgressIndicator != null)
					{
						num = (short)90439681;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					try
					{
						memoryStream.Write(array, 0, array.Length);
						base.IOController.FileWrite(0, global::Motorola.Common.Communication.Crc32.c("풠펢솤욦\udda8캪莬춮펰햲", a_), memoryStream, base.ProgressIndicator, false);
						goto IL_79;
					}
					finally
					{
						num = (short)660340738;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)549126145;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_14D;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_117;
								}
								continue;
							}
							IL_117:
							if (memoryStream != null)
							{
								num = (short)341180416;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_14D:
							num = (short)263192843;
							short num4 = num;
							num = (short)1130168587;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_117;
							default:
								goto IL_181;
							}
						}
						IL_181:
						num = (short)1916010496;
						if (num != 0)
						{
						}
					}
					goto IL_197;
					IL_79:
					num = (short)1848180738;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_51;
				IL_197:
				base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteSoftwareDone);
				num = (short)888668160;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_1C5:
			num = (short)846856193;
			if (num != 0)
			{
			}
			return;
			IL_51:
			array = this.f.h();
			memoryStream = new global::System.IO.MemoryStream();
			num = (short)2018639875;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000046AC File Offset: 0x000028AC
		private void a(global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo A_0, global::Motorola.Common.Communication.Pba.PbaObject A_1, bool A_2)
		{
			int a_ = 12;
			short num = (short)1344077824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B4;
				}
				bool a_2;
				for (;;)
				{
					IL_31:
					global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage;
					string empty2;
					global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage3;
					string empty3;
					switch (num2)
					{
					case 0:
						goto IL_789;
					case 1:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						if (memoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFileSequenceManager.<>c.<>9.d)))
						{
							num = (short)591069199;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_560;
					}
					case 2:
					{
						num = (short)1664811009;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						if (memoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFileSequenceManager.<>c.<>9.a)))
						{
							num = (short)73007114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36A;
					}
					case 3:
						if (!string.IsNullOrEmpty(astroMemoryImage.ComponentName))
						{
							num = (short)1507655694;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25A;
					case 4:
						if (this.e)
						{
							num = (short)1813184536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						goto IL_560;
					case 6:
					{
						this.b += 1.0;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage2;
						string empty;
						this.f.a(astroMemoryImage2.ComponentName, out empty);
						this.d.a(empty, a_2, this.m_MaxTransportPacketSize, new global::Motorola.Common.Communication.y.a(this.b));
						num = (short)1862795286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						if (memoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFileSequenceManager.<>c.<>9.b)))
						{
							num = (short)1299841049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C8;
					}
					case 8:
						goto IL_708;
					case 9:
					{
						if (A_0 == null)
						{
							num = (short)2037252096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.d.a(new global::Motorola.Common.Communication.y.a(this.e));
						byte a_3 = this.d.a(1);
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages = A_1.UpdateData.MemoryImages;
						num = (short)1560084482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						a_2 = true;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						astroMemoryImage = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.HOST);
						empty2 = string.Empty;
						num = (short)422838275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)2033713161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						a_2 = false;
						num = (short)1092878353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (A_2)
						{
							num = (short)2138439692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_118;
					case 14:
						this.e = true;
						num = (short)615776269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						a_2 = false;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						astroMemoryImage3 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.ACCY);
						empty3 = string.Empty;
						num = (short)587661331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_1C8;
					case 17:
						goto IL_118;
					case 18:
						goto IL_36A;
					case 19:
						if (!string.IsNullOrEmpty(astroMemoryImage3.ComponentName))
						{
							num = (short)2116110823;
							short num3 = num;
							num = (short)195250663;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_55B;
							case 1:
								break;
							default:
							{
								num = (short)936509440;
								short num4 = num;
								break;
							}
							}
							num = (short)1158152192;
							if (num != 0)
							{
							}
							num = (short)980156445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_412;
					case 20:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						if (memoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFileSequenceManager.<>c.<>9.c)))
						{
							num = (short)26804247;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17F;
					}
					case 21:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage2;
						if (!string.IsNullOrEmpty(astroMemoryImage2.ComponentName))
						{
							num = (short)1398013958;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7D1;
					}
					case 22:
						goto IL_17F;
					case 23:
					{
						a_2 = false;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage2 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.OPTION);
						string empty = string.Empty;
						num = (short)304414741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						num = (short)1928986650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						a_2 = false;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage4 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.MACE);
						string empty4 = string.Empty;
						num = (short)1519648795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
					{
						byte a_3;
						if (this.d.b(global::Motorola.Common.Communication.Crc32.c("ﾪ", a_), global::Motorola.Common.Communication.Crc32.c("ﾪ", a_), (uint)a_3) != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
						{
							num = (short)2015494152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 27:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage4;
						if (!string.IsNullOrEmpty(astroMemoryImage4.ComponentName))
						{
							num = (short)1528889372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5FC;
					}
					case 28:
					{
						this.b += 1.0;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage4;
						string empty4;
						this.f.a(astroMemoryImage4.ComponentName, out empty4);
						this.d.a(empty4, a_2, this.m_MaxTransportPacketSize, new global::Motorola.Common.Communication.y.a(this.c));
						num = (short)2039676944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						goto IL_55B;
					case 30:
						if (A_1 != null)
						{
							num = (short)36175883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C1;
					}
					goto IL_B4;
					IL_118:
					this.b += 1.0;
					this.f.a(astroMemoryImage.ComponentName, out empty2);
					this.d.a(empty2, a_2, this.m_MaxTransportPacketSize, new global::Motorola.Common.Communication.y.a(this.d));
					num = (short)1374093330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17F:
					num = (short)840433665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C8:
					num = (short)788856852;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36A:
					num = (short)2051145735;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_55B:
					this.b += 1.0;
					this.f.a(astroMemoryImage3.ComponentName, out empty3);
					this.d.a(empty3, a_2, this.m_MaxTransportPacketSize, new global::Motorola.Common.Communication.y.a(this.a));
					num = (short)33816581;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_560:
					num = (short)799408132;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1C1:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				IL_25A:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_412:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_5FC:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_708:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_CopyPsdtFailed);
				IL_789:
				goto IL_1C1;
				IL_7D1:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_B4:
				a_2 = true;
				this.c = A_1.UpdateData.MemoryImages.Count<global::Motorola.Common.Communication.Pba.RadioImage>() + 2;
				this.b = 1.0;
				num = (short)1609433118;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00004ED8 File Offset: 0x000030D8
		public void ValidateUpdate()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			byte b;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (this.d.a(5, ref b) != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
					{
						num2 = (short)78708737;
						if (num2 != 0)
						{
						}
						num2 = (short)86507521;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					goto IL_116;
				case 2:
					if (this.e)
					{
						num2 = (short)1524760579;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					num2 = (short)2028797952;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_116:
			num2 = (short)160563200;
			short num3 = num2;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_FirmwareValidationFailed);
			IL_20:
			b = 0;
			num2 = (short)1909873603;
			short num4 = num2;
			num2 = (short)1217682371;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
			{
				num2 = (short)1670184960;
				if (num2 != 0)
				{
				}
				num2 = (short)181010434;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000015 RID: 21
		protected abstract global::Motorola.Common.Communication.Pba.PbaObject WriteDeviceFlash(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword, bool hostedDepotOperation);

		// Token: 0x06000016 RID: 22 RVA: 0x00005028 File Offset: 0x00003228
		public virtual void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionId, bool hostedDepotOperation, int? userDefersAllowed = null)
		{
			int a_ = 19;
			short num = (short)417071104;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B0;
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
						num = (short)1409024011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_407;
							}
							for (;;)
							{
								IL_3F4:
								switch (num2)
								{
								case 0:
									goto IL_4E9;
								case 1:
								{
									if (!this.f.c())
									{
										goto IL_4EE;
									}
									num = (short)967843203;
									short num3 = num;
									num = (short)1398349187;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_4C5;
									default:
										num = (short)371982336;
										if (num != 0)
										{
										}
										num = (short)1701838850;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_4C5;
								}
								goto IL_407;
								IL_4C5:
								bool a_2;
								this.a(extendedDeviceInfo, pbaObject, a_2);
								num = (short)1610612736;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4E9:
							goto IL_2E8;
							IL_4EE:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
							IL_407:
							global::System.GC.WaitForPendingFinalizers();
							global::Motorola.Common.Communication.AutoReleasedSemaphore.addUpgradeJobSem.WaitOne(600000);
							this.f = new global::Motorola.Common.Communication.w(pbaObject.UpdateData.MemoryImages[0].FilePath);
							num = (short)1810694145;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_3F4;
						}
						finally
						{
							this.f = null;
							global::System.GC.Collect();
							global::Motorola.Common.Communication.AutoReleasedSemaphore.addUpgradeJobSem.Release();
						}
						goto IL_511;
					case 2:
						if (pbaObject.LanguagePackData != null)
						{
							num = (short)110166024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						this.FlashRadioImageToFileSystem();
						num = (short)2130378756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_2E8;
					case 5:
						if (pbaObject.UpdateData.MemoryImages.Count > 0)
						{
							num = (short)441450508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_280;
					case 6:
						if (extendedDeviceInfo.SoftwareVersion.Substring(1, 2) == global::Motorola.Common.Communication.Crc32.c("麭膯", a_))
						{
							num = (short)545718286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CA;
					case 7:
						memoryImages = pbaObject.UpdateData.MemoryImages;
						if ((predicate = global::Motorola.Common.Communication.AstroFileSequenceManager.<>c.<>9__25_1) == null)
						{
							predicate = (global::Motorola.Common.Communication.AstroFileSequenceManager.<>c.<>9__25_1 = new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFileSequenceManager.<>c.<>9.f));
							goto IL_511;
						}
						goto IL_511;
					case 8:
						num = (short)2010316820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_5B8;
					case 10:
					{
						global::Motorola.Common.Communication.Pba.RadioImage imageFromList = global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(pbaObject.UpdateData.MemoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FLASHTOFILESYSTEM);
						this.f = new global::Motorola.Common.Communication.w(imageFromList.FilePath);
						num = (short)1456799771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (this.f.g())
						{
							num = (short)313786368;
							short num4 = num;
							num = (short)385024003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_624;
					case 12:
						num = (short)1556414477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (pbaObject.UpdateData.MemoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFileSequenceManager.<>c.<>9.e)))
						{
							num = (short)485163009;
							if (num != 0)
							{
							}
							num = (short)41943059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_280;
					case 14:
					{
						bool a_2 = true;
						num = (short)477954069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						base.ProgressIndicator.SetCurrentScope(65, 100);
						base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLanguages);
						num = (short)1302659097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						base.ProgressIndicator.SetCurrentScope(8, 64);
						base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeRadio);
						num = (short)2027356184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)304021527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (!string.IsNullOrEmpty(extendedDeviceInfo.SoftwareVersion))
						{
							num = (short)1970405404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CA;
					case 19:
					{
						bool a_2 = false;
						num = (short)1142358034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (pbaObject.LanguagePackData.LanguagePacks.Count > 0)
						{
							num = (short)70844433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 21:
						goto IL_6CA;
					case 22:
						if (pbaObject.UpdateData.MemoryImages.Count > 0)
						{
							num = (short)1976041501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E8;
					case 23:
						if (base.ProgressIndicator != null)
						{
							num = (short)2062024719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_576;
					case 24:
						goto IL_704;
					case 25:
						goto IL_576;
					case 26:
						if (base.ProgressIndicator != null)
						{
							num = (short)393084944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_704;
					case 27:
					{
						global::Motorola.Common.Communication.Pba.RadioImage imageFromList;
						if (global::System.IO.File.Exists(imageFromList.FilePath))
						{
							num = (short)678297600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_624;
					}
					case 28:
						num = (short)2027028486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num = (short)488701959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B0;
					IL_280:
					num = (short)172687382;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E8:
					num = (short)490078210;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_511:
					if (memoryImages.Any(predicate))
					{
						num = (short)1114046474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E8;
					IL_576:
					(pbaObject.LanguagePackData.LanguagePacks[0] as global::Motorola.Common.Communication.Pba.AstroFilePackInfo).isFlashPortUpgradeLP = true;
					this.WriteLanguagePacks(pbaObject.LanguagePackData);
					num = (short)294387721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6CA:
					num = (short)1853423617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_704:
					num = (short)1255079941;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_5B8:
				return;
				IL_624:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_B0:
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(pbaObject, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				extendedDeviceInfo = base.ExtendedDeviceInfo;
				global::Motorola.Common.Communication.Pba.PbaObject writePBA = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(pbaObject.SerializeToBytes(), false);
				this.WriteDeviceFlash(writePBA, 0, null, hostedDepotOperation);
				pbaObject.CodeplugData.ArchiveSessionID = sessionId;
				num = (short)1169621018;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000017 RID: 23
		public abstract override global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword, bool hostedDepotOperation);

		// Token: 0x06000018 RID: 24 RVA: 0x000057C0 File Offset: 0x000039C0
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList)
		{
			short num = (short)1049100288;
			switch (num)
			{
			default:
			{
				num = (short)1440612356;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
						num = (short)2134769665;
						if (num != 0)
						{
						}
						num = (short)2139881473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1D3;
					case 2:
						list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>(blockList.Count);
						num = (short)1382809605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)940638208;
						short num3 = num;
						if (blockList.Any<T>())
						{
							num = (short)1026424834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36A;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_65;
						}
						continue;
					case 5:
						try
						{
							global::System.Collections.Generic.IEnumerator<T> enumerator = blockList.GetEnumerator();
							try
							{
								num = (short)1053097987;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_2EC;
									case 1:
										goto IL_268;
									case 2:
										num = (short)628359168;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_21C;
										}
										continue;
									case 4:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)137560066;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										object obj = enumerator.Current;
										list.Add((global::Motorola.Common.Communication.CommonUtil.IshHeader)obj);
										num = (short)2075721729;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									goto IL_21C;
									IL_268:
									num = (short)1898119172;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_21C:
									num = (short)1373590725;
									short num4 = num;
									num = (short)1744000197;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2EC;
									default:
										num = (short)471007232;
										if (num != 0)
										{
										}
										goto IL_268;
									}
								}
								IL_2EC:;
							}
							finally
							{
								num = (short)595329025;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_357;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_321;
										}
										continue;
									case 2:
										enumerator.Dispose();
										num = (short)993263616;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_321:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1793130498;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_357:;
							}
							goto IL_85;
						}
						catch (global::System.InvalidCastException systemException)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgumentType, systemException);
						}
						goto IL_36A;
						IL_85:
						num = (short)1072103431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1240203267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (base.ProgressIndicator != null)
						{
							num = (short)1853358080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E9;
					}
					IL_65:
					if (blockList == null)
					{
						goto IL_36A;
					}
					num = (short)1848115206;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E9:
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug = this.ReadIshItems(list);
				pbaObject.SetCodeplug(codeplug);
				this.UpdatePINPasswordAfterRead(pbaObject);
				base.UpdateWiFiPasswordAfterRead(pbaObject);
				base.UpdateExternalDataModemPasswordAfterRead(pbaObject);
				return pbaObject;
				IL_1D3:
				goto IL_E9;
				IL_36A:
				throw new global::System.ArgumentNullException();
			}
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00005B70 File Offset: 0x00003D70
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Motorola.Common.Communication.Pba.PbaObject result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					return result;
				case 2:
				{
					num2 = (short)1732606426;
					short num3 = num2;
					num2 = (short)1614772698;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)595918848;
						if (num2 != 0)
						{
						}
						if (this.m_SessionParameter.ArchiveSession)
						{
							num2 = (short)1628569600;
							short num4 = num2;
							num2 = (short)498401283;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = this.a(referencePba, sessionID);
						num2 = (short)2132934656;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					result = this.ManagedReadDevice(referencePba, sessionID);
					num2 = (short)565772289;
					if (num2 != 0)
					{
					}
					num2 = (short)963641345;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			return result;
			IL_20:
			result = new global::Motorola.Common.Communication.Pba.PbaObject();
			num2 = (short)1227948034;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00005CC0 File Offset: 0x00003EC0
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo()
		{
			int a_ = 14;
			short num = (short)171442176;
			switch (num)
			{
			default:
			{
				num = (short)335478785;
				if (num != 0)
				{
				}
				num = (short)1643905024;
				short num2 = num;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> list = base.IOController.ListDirectoryContents(0, global::Motorola.Common.Communication.Crc32.c("蚨ﲸ钺", a_));
				global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
				using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct>.Enumerator enumerator = list.GetEnumerator())
				{
					num = (short)1882390533;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							global::Motorola.Common.Communication.Pba.FileListItemStruct fileListItemStruct;
							if (fileListItemStruct.FileType == global::Motorola.Common.Communication.Pba.FileListItemStruct.TypeOfFile.File)
							{
								num = (short)1266614278;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_20F;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)135790596;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.Pba.FileListItemStruct fileListItemStruct = enumerator.Current;
							num = (short)570818560;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)1264386049;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_E2;
							}
							continue;
						case 6:
						{
							num = (short)215119811;
							short num4 = num;
							num = (short)2103801795;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_20F;
							default:
							{
								num = (short)214564864;
								if (num != 0)
								{
								}
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = new global::Motorola.Common.Communication.Pba.AstroFilePackInfo();
								global::Motorola.Common.Communication.Pba.FileListItemStruct fileListItemStruct;
								astroFilePackInfo.radioFilePath = fileListItemStruct.FileName;
								astroFilePackInfo.radioFileSize = fileListItemStruct.FileSize;
								languagePackData.LanguagePacks.Add(astroFilePackInfo);
								num = (short)660078595;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						}
						IL_170:
						num = (short)1215954946;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_E2:
						goto IL_170;
					}
					IL_20F:;
				}
				languagePackData.AvailableSpace = base.IOController.GetFreeSpace(0, global::Motorola.Common.Communication.Crc32.c("蚨ﲸ钺", a_));
				return languagePackData;
			}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00005F2C File Offset: 0x0000412C
		public void DeleteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			int a_ = 10;
			short num = (short)2044657664;
			switch (num)
			{
			default:
			{
				num = (short)490012672;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct>.Enumerator enumerator;
					global::System.Collections.Generic.List<string> list;
					global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
					bool flag;
					global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.LanguagePackBase> languagePacks;
					global::System.Func<global::Motorola.Common.Communication.Pba.LanguagePackBase, bool> predicate;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					case 1:
					{
						byte[] array;
						if (array != null)
						{
							num = (short)1352007689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_710;
					}
					case 2:
					{
						try
						{
							num = (short)240386049;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)262668290;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.FileListItemStruct fileListItemStruct = enumerator.Current;
									list.Add(fileListItemStruct.FileName);
									num = (short)2061697028;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1DB;
									}
									continue;
								case 2:
									num = (short)25034755;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_25C;
								}
								IL_1DD:
								num = (short)1985544192;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1DB:
								goto IL_1DD;
							}
							IL_25C:
							goto IL_5F8;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_7;
						IL_5F8:
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2 = langPackData.LanguagePacks.GetEnumerator();
						num = (short)886964225;
						if (num != 0)
						{
						}
						num = (short)786235392;
						short num3 = num;
						num = (short)642908170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)2023686152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (astroFilePackInfo.sourceFilePath != null)
						{
							num = (short)947191814;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						if (flag)
						{
							num = (short)1934622727;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
					{
						byte[] array = new global::Motorola.Common.Communication.t().a(astroFilePackInfo);
						num = (short)1638400001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)77135876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						languagePacks = langPackData.LanguagePacks;
						if ((predicate = global::Motorola.Common.Communication.AstroFileSequenceManager.<>c.<>9__30_0) == null)
						{
							goto IL_591;
						}
						goto IL_5AA;
					case 9:
					{
						byte[] array;
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array);
						num = (short)1702690827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_26F;
					case 11:
						goto IL_4F5;
					case 12:
						goto IL_5CD;
					}
					IL_81:
					if (langPackData != null)
					{
						num = (short)1714028547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_158:
					global::System.Collections.Generic.List<string> list2;
					base.IOController.DeleteFilesOrDirectory(0, list2);
					num = (short)273547269;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5AA:
					if (languagePacks.Any(predicate))
					{
						num = (short)1298989068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> list3 = base.IOController.ListDirectoryContents(0, global::Motorola.Common.Communication.Crc32.c("誤类颶", a_));
					list = new global::System.Collections.Generic.List<string>();
					list2 = new global::System.Collections.Generic.List<string>();
					astroFilePackInfo = new global::Motorola.Common.Communication.Pba.AstroFilePackInfo();
					flag = false;
					enumerator = list3.GetEnumerator();
					num = (short)1434032340;
					short num4 = num;
					num = (short)1217108180;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_158;
					default:
						num = (short)1936392192;
						if (num != 0)
						{
						}
						num = (short)851050498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_591:
					predicate = (global::Motorola.Common.Communication.AstroFileSequenceManager.<>c.<>9__30_0 = new global::System.Func<global::Motorola.Common.Communication.Pba.LanguagePackBase, bool>(global::Motorola.Common.Communication.AstroFileSequenceManager.<>c.<>9.a));
					goto IL_5AA;
					Block_8:
					try
					{
						IL_4F5:
						global::System.IO.MemoryStream memoryStream;
						base.IOController.FileWrite(0, global::Motorola.Common.Communication.Crc32.c("誤类颶", a_) + astroFilePackInfo.sourceFilePath, memoryStream, null, false);
						return;
					}
					finally
					{
						num = (short)1641218048;
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
									goto IL_555;
								}
								continue;
							case 1:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)1533804546;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_58E;
							}
							IL_555:
							if (memoryStream == null)
							{
								break;
							}
							num = (short)1685258241;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_58E:;
					}
					goto IL_591;
					Block_7:
					try
					{
						IL_26F:
						num = (short)1737359362;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)152305677;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_2D1;
								}
								continue;
							case 3:
								if (astroFilePackInfo.radioFilePath != null)
								{
									num = (short)1556348938;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 4:
							{
								flag = true;
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2;
								astroFilePackInfo = astroFilePackInfo2;
								num = (short)1071382529;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								num = (short)1813839881;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
								if (!enumerator2.MoveNext())
								{
									num = (short)77398023;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2 = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)enumerator2.Current;
								num = (short)1475411982;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								goto IL_4E2;
							case 10:
							{
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2;
								list2.Insert(0, global::Motorola.Common.Communication.Crc32.c("誤类颶", a_) + astroFilePackInfo2.radioFilePath);
								num = (short)1964900358;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 11:
							{
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2;
								if (astroFilePackInfo2.fileType == global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest)
								{
									num = (short)497680388;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 12:
							{
								flag = true;
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2;
								astroFilePackInfo = astroFilePackInfo2;
								num = (short)1998979075;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 13:
							{
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2;
								if (astroFilePackInfo2.fileType == global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest)
								{
									num = (short)479002636;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								list2.Add(global::Motorola.Common.Communication.Crc32.c("誤类颶", a_) + astroFilePackInfo2.radioFilePath);
								num = (short)786038789;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 14:
							{
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2;
								if (list.Contains(global::System.IO.Path.GetFileName(astroFilePackInfo2.radioFilePath)))
								{
									num = (short)1354891264;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1508573195;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_3EC:
							num = (short)313524232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2D1:
							goto IL_3EC;
						}
						IL_4E2:
						goto IL_158;
					}
					finally
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
						((global::System.IDisposable)enumerator2).Dispose();
					}
					goto Block_8;
				}
				IL_C6:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				IL_5CD:
				goto IL_C6;
				IL_710:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
			}
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000066A0 File Offset: 0x000048A0
		public void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			short num = (short)285286736;
			short num2 = num;
			num = (short)2089034064;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)115081217;
				if (num != 0)
				{
				}
				num = (short)527630336;
				short num3 = num;
				num = (short)856424448;
				if (num != 0)
				{
				}
				num = (short)211222528;
				int num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			}
			global::Motorola.Common.Communication.ae ae = null;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_F5;
				}
				int num4;
				global::Motorola.Common.Communication.aa aa;
				global::Motorola.Common.Communication.Pba.LanguagePackData a_;
				global::Motorola.Common.Communication.Pba.LanguagePackData langPackData2;
				global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
				for (;;)
				{
					IL_CA:
					switch (num4)
					{
					case 0:
						goto IL_27D;
					case 1:
						switch (aa)
						{
						case global::Motorola.Common.Communication.aa.a:
							goto IL_27D;
						case global::Motorola.Common.Communication.aa.b:
							this.a(a_, false);
							num = (short)1144389637;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.Communication.aa.c:
							this.a(a_, false);
							this.DeleteLanguagePacks(langPackData2);
							num = (short)363003910;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.Communication.aa.d:
							this.DeleteLanguagePacks(langPackData2);
							this.a(a_, false);
							num = (short)163184648;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.Communication.aa.e:
							this.DeleteLanguagePacks(langPackData2);
							num = (short)412876802;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.Communication.aa.f:
							this.a(a_, true);
							num = (short)1468006400;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1525481476;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 2:
						goto IL_27D;
					case 3:
						goto IL_27D;
					case 4:
						num = (short)922812419;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_27D;
					case 6:
						goto IL_27D;
					case 7:
						goto IL_2A3;
					case 8:
						goto IL_27D;
					}
					goto IL_F5;
					IL_27D:
					astroFilePackInfo.warningOTAPErrorCode = ae.e();
					num = (short)593559559;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_2A3:
				return;
				IL_F5:
				global::Motorola.Common.Communication.CommonUtil.DeviceInfo extendedDeviceInfo = base.ExtendedDeviceInfo;
				string a_2 = this.b();
				astroFilePackInfo = (langPackData.LanguagePacks[0] as global::Motorola.Common.Communication.Pba.AstroFilePackInfo);
				ae = new global::Motorola.Common.Communication.ae(a_2, langPackData.ModelType, astroFilePackInfo.sourceFilePath, astroFilePackInfo.languageUpgradeType);
				global::Motorola.Common.Communication.Pba.LanguagePackData a_3 = this.ReadLanguagePacksInfo();
				aa = ae.b(extendedDeviceInfo, a_3, out langPackData2, out a_, astroFilePackInfo.isFlashPortUpgradeLP);
				num = (short)31653889;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_CA;
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
				num = (short)1567031296;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_2E7;
						}
						continue;
					case 1:
						ae.f();
						num = (short)934543362;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_31E;
					}
					IL_2E7:
					if (ae == null)
					{
						break;
					}
					num = (short)1649672193;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_31E:;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00006A1C File Offset: 0x00004C1C
		private void a(global::Motorola.Common.Communication.Pba.LanguagePackData A_0, bool A_1)
		{
			int a_ = 18;
			short num = (short)1116209152;
			switch (num)
			{
			default:
			{
				num = (short)599851010;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.AstroFilePackInfo>.Enumerator enumerator;
					global::Motorola.Common.Communication.t t;
					double progressRate;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct>.Enumerator enumerator2;
					bool flag;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.AstroFilePackInfo> list;
					global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.LanguagePackBase> languagePacks;
					global::System.Func<global::Motorola.Common.Communication.Pba.LanguagePackBase, bool> predicate;
					global::System.Collections.Generic.List<string> list2;
					switch (num2)
					{
					case 0:
						if (astroFilePackInfo != null)
						{
							num = (short)839712785;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC7;
					case 1:
						base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteLanguagesDone);
						num = (short)652410902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_B1;
						}
						continue;
					case 3:
						base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLanguages);
						num = (short)2027945988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_D5;
					case 5:
						try
						{
							num = (short)1729232898;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									byte[] array;
									global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array);
									num = (short)1369833478;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_A26;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_718;
									}
									continue;
								case 3:
								{
									byte[] array;
									if (array != null)
									{
										num = (short)686161920;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A03;
								}
								case 4:
									num = (short)1654915073;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)719388676;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2 = enumerator.Current;
									byte[] array = t.b(astroFilePackInfo2);
									num = (short)584843267;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									try
									{
										num = (short)1476853762;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2;
											switch (num2)
											{
											case 0:
												goto IL_889;
											case 1:
												goto IL_8DC;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_75F;
												}
												continue;
											case 3:
											{
												string str = astroFilePackInfo2.sourceFilePath.Replace(global::Motorola.Common.Communication.Crc32.c("莬쎮솰", a_), global::Motorola.Common.Communication.Crc32.c("莬\udbae\uddb0쎲", a_));
												global::System.IO.MemoryStream memoryStream;
												base.IOController.FileWrite(0, global::Motorola.Common.Communication.Crc32.c("芬ﶲﲺ邾", a_) + str, memoryStream, new global::Motorola.Common.Communication.IteratedProgressIndicator(base.ProgressIndicator, progressRate), true);
												num = (short)188219396;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												goto IL_7FC;
											case 5:
											{
												global::System.IO.MemoryStream memoryStream;
												base.IOController.FileWrite(0, global::Motorola.Common.Communication.Crc32.c("芬ﶲﲺ邾", a_) + astroFilePackInfo2.sourceFilePath, memoryStream, new global::Motorola.Common.Communication.IteratedProgressIndicator(base.ProgressIndicator, progressRate), false);
												num = (short)1154023424;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
											{
												if (A_1)
												{
													num = (short)855310339;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.IO.MemoryStream memoryStream;
												base.IOController.FileWrite(0, global::Motorola.Common.Communication.Crc32.c("芬ﶲﲺ邾", a_) + astroFilePackInfo2.sourceFilePath, memoryStream, new global::Motorola.Common.Communication.IteratedProgressIndicator(base.ProgressIndicator, progressRate), true);
												num = (short)580452353;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_75F:
											if (astroFilePackInfo2.fileType == global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest)
											{
												num = (short)213319685;
												num2 = (int)((global::System.IntPtr)num);
											}
											else
											{
												num = (short)1056309254;
												num2 = (int)((global::System.IntPtr)num);
											}
										}
										IL_7FC:
										IL_889:
										IL_8DC:;
									}
									finally
									{
										num = (short)762642433;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.IO.MemoryStream memoryStream;
											switch (num2)
											{
											case 0:
												goto IL_949;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_912;
												}
												continue;
											case 2:
												((global::System.IDisposable)memoryStream).Dispose();
												num = (short)528351232;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_912:
											if (memoryStream == null)
											{
												break;
											}
											num = (short)329580546;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_949:;
									}
									break;
								}
								IL_94C:
								num = (short)1280901125;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_718:
								goto IL_94C;
							}
							IL_A03:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
							IL_A26:
							goto IL_652;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_A39;
						IL_652:
						num = (short)546963465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_AC5;
					case 7:
						if (base.ProgressIndicator != null)
						{
							num = (short)1921843203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D5;
					case 8:
					{
						try
						{
							num = (short)530710530;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator2.MoveNext())
									{
										num = (short)1988689924;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1246232579;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									flag = true;
									num = (short)403832838;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1A2;
									}
									continue;
								case 3:
									if (global::System.IO.Path.GetExtension(enumerator2.Current.FileName) == global::Motorola.Common.Communication.Crc32.c("莬슮\udfb0햲", a_))
									{
										num = (short)112590849;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									num = (short)1794113541;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_26D;
								}
								IL_1FA:
								num = (short)731512832;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A2:
								goto IL_1FA;
							}
							IL_26D:
							goto IL_32C;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_280;
						IL_32C:
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator3 = A_0.LanguagePacks.GetEnumerator();
						num = (short)1511194645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (base.ProgressIndicator != null)
						{
							num = (short)1802043393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
						goto IL_617;
					case 11:
						list.Insert(list.Count, astroFilePackInfo);
						num = (short)1585512472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1034616852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)67829779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_62F;
					case 15:
						if (astroFilePackInfo.sourceFilePath != null)
						{
							num = (short)299368459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC7;
					case 16:
						num = (short)1850867713;
						if (num != 0)
						{
						}
						num = (short)93388818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_280;
					case 18:
						if (astroFilePackInfo.radioFilePath == null)
						{
							num = (short)1053163526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_354;
					case 19:
						if (astroFilePackInfo.sourceFilePath == null)
						{
							num = (short)1289879568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_354;
					case 20:
						languagePacks = A_0.LanguagePacks;
						if ((predicate = global::Motorola.Common.Communication.AstroFileSequenceManager.<>c.<>9__32_0) == null)
						{
							predicate = (global::Motorola.Common.Communication.AstroFileSequenceManager.<>c.<>9__32_0 = new global::System.Func<global::Motorola.Common.Communication.Pba.LanguagePackBase, bool>(global::Motorola.Common.Communication.AstroFileSequenceManager.<>c.<>9.b));
							goto IL_A39;
						}
						goto IL_A39;
					case 21:
						try
						{
							num = (short)633470978;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo3;
									astroFilePackInfo = astroFilePackInfo3;
									num = (short)1789657099;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_3D8;
								case 3:
									goto IL_604;
								case 4:
									if (astroFilePackInfo.radioFilePath != null)
									{
										num = (short)1665204230;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									num = (short)2036989955;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo3;
									string item = global::Motorola.Common.Communication.Crc32.c("芬ﶲﲺ邾", a_) + astroFilePackInfo3.radioFilePath;
									list2.Add(item);
									base.IOController.DeleteFilesOrDirectory(0, list2);
									num = (short)1309147137;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									num = (short)1662930973;
									short num3 = num;
									num = (short)323964957;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_3D8;
									default:
									{
										num = (short)1379729408;
										if (num != 0)
										{
										}
										global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo3;
										if (astroFilePackInfo3.fileType == global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest)
										{
											num = (short)1137901568;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										list.Add(astroFilePackInfo3);
										num = (short)1400897545;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 8:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator3;
									if (!enumerator3.MoveNext())
									{
										num = (short)1941700613;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo3 = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)enumerator3.Current;
									num = (short)527433735;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									num = (short)710737924;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									if (flag)
									{
										num = (short)1161429002;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								goto IL_419;
								IL_3D8:
								switch (0)
								{
								case 0:
									IL_419:
									goto IL_50A;
								}
								continue;
								IL_50A:
								num = (short)1997209608;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_604:
							goto IL_2F1;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator3;
							((global::System.IDisposable)enumerator3).Dispose();
						}
						goto IL_617;
						IL_2F1:
						num = (short)787873792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_B2F;
					case 23:
						if (astroFilePackInfo != null)
						{
							num = (short)2017132557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B31;
					case 24:
						goto IL_354;
					}
					IL_B1:
					if (A_0 != null)
					{
						num = (short)310837260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_617;
					IL_D5:
					list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.AstroFilePackInfo>(A_0.LanguagePacks.Count);
					list2 = new global::System.Collections.Generic.List<string>();
					astroFilePackInfo = null;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> list3 = base.IOController.ListDirectoryContents(0, global::Motorola.Common.Communication.Crc32.c("芬ﶲﲺ邾", a_));
					flag = false;
					enumerator2 = list3.GetEnumerator();
					num = (short)977141768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_280:
					num = (short)1457586191;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_354:
					t = new global::Motorola.Common.Communication.t(A_0);
					progressRate = 1.0 / (double)A_0.LanguagePacks.Count;
					enumerator = list.GetEnumerator();
					num = (short)1287454720;
					short num4 = num;
					num = (short)1057685509;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_617:
					num = (short)1277427726;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A39:
					if (languagePacks.Any(predicate))
					{
						num = (short)181075978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)49741831;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AC7:
					num = (short)1787822103;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_62F:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				IL_AC5:
				goto IL_B31;
				IL_B2F:
				return;
				IL_B31:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
			}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00007634 File Offset: 0x00005834
		// Note: this type is marked as 'beforefieldinit'.
		static AstroFileSequenceManager()
		{
			short num = (short)728039424;
			short num2 = num;
			num = (short)1607057527;
			short num3 = num;
			num = (short)1166721143;
			switch (num3 == num)
			{
			}
			num = (short)1500577792;
			if (num != 0)
			{
			}
			num = (short)1002700801;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.AstroFileSequenceManager.a = new global::System.Lazy<global::System.Collections.Generic.Dictionary<global::System.Guid, string>>(new global::System.Func<global::System.Collections.Generic.Dictionary<global::System.Guid, string>>(global::Motorola.Common.Communication.AstroFileSequenceManager.a), global::System.Threading.LazyThreadSafetyMode.ExecutionAndPublication);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000076F4 File Offset: 0x000058F4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void e(double A_0)
		{
			short num = (short)360579073;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)392584969;
					short num3 = num;
					num = (short)1200054025;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)2109734912;
						if (num != 0)
						{
						}
						num = (short)890765313;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A0;
						}
						continue;
					}
					break;
				}
				case 2:
				{
					num = (short)238878720;
					short num4 = num;
					base.ProgressIndicator.UpdateProgress(A_0 / 100.0 / (double)this.c, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash);
					num = (short)328400896;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_A0:
				if (base.ProgressIndicator == null)
				{
					break;
				}
				num = (short)835649538;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00007824 File Offset: 0x00005A24
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void d(double A_0)
		{
			short num = (short)1673265153;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)837852878;
					short num3 = num;
					num = (short)33201870;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)2016018433;
						if (num != 0)
						{
						}
						num = (short)978059264;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A5;
						}
						continue;
					}
					break;
				}
				case 2:
				{
					num = (short)1649016832;
					short num4 = num;
					base.ProgressIndicator.UpdateProgress(A_0 / (double)this.c + this.b / (double)this.c, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeHost);
					num = (short)1852964864;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_A5:
				if (base.ProgressIndicator == null)
				{
					break;
				}
				num = (short)1132986370;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00007960 File Offset: 0x00005B60
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void c(double A_0)
		{
			short num = (short)920190977;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_104;
				case 1:
				{
					num = (short)1468601099;
					short num3 = num;
					num = (short)796267275;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)923336704;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					}
					break;
				}
				case 2:
				{
					base.ProgressIndicator.UpdateProgress(A_0 / (double)this.c + this.b / (double)this.c, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeMace);
					num = (short)1638400;
					short num4 = num;
					num = (short)1352007680;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_7C:
				if (base.ProgressIndicator == null)
				{
					return;
				}
				num = (short)125173762;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_104:
			num = (short)114491393;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00007A9C File Offset: 0x00005C9C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b(double A_0)
		{
			short num = (short)271450113;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_105;
				case 1:
				{
					num = (short)897394132;
					short num3 = num;
					num = (short)1111434708;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)993853440;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					}
					break;
				}
				case 2:
				{
					base.ProgressIndicator.UpdateProgress(A_0 / (double)this.c + this.b / (double)this.c, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeOptBrd);
					num = (short)1194721280;
					short num4 = num;
					num = (short)1454833664;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_7D:
				if (base.ProgressIndicator == null)
				{
					return;
				}
				num = (short)1605107714;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_105:
			num = (short)57671681;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00007BD8 File Offset: 0x00005DD8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(double A_0)
		{
			short num = (short)1655177217;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)808493141;
					short num3 = num;
					num = (short)1915920469;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1423704064;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					}
					break;
				}
				case 2:
				{
					num = (short)173998081;
					if (num != 0)
					{
					}
					num = (short)47251456;
					short num4 = num;
					base.ProgressIndicator.UpdateProgress(A_0 / (double)this.c + this.b / (double)this.c, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeAccBrd);
					num = (short)509673472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_7E:
				if (base.ProgressIndicator == null)
				{
					break;
				}
				num = (short)614137858;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly global::System.Lazy<global::System.Collections.Generic.Dictionary<global::System.Guid, string>> a;

		// Token: 0x04000004 RID: 4
		private double b;

		// Token: 0x04000005 RID: 5
		private int c;

		// Token: 0x04000006 RID: 6
		private readonly global::Motorola.Common.Communication.y d;

		// Token: 0x04000007 RID: 7
		private bool e;

		// Token: 0x04000008 RID: 8
		private new global::Motorola.Common.Communication.w f;
	}
}
