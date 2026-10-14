using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Motorola.Common.Communication.CommonFile;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000009 RID: 9
	public abstract class AstroIshSequenceManager : global::Motorola.Common.Communication.AstroSequenceManager
	{
		// Token: 0x06000064 RID: 100 RVA: 0x0000D658 File Offset: 0x0000B858
		public AstroIshSequenceManager(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter) : base(rcmpWrapper, sessionParameter)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000D670 File Offset: 0x0000B870
		protected global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadRadioCodeplug()
		{
			short num = (short)1867055104;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				global::System.Collections.Generic.List<ushort> list;
				byte b;
				global::System.Collections.Generic.List<byte> list2;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						list = new global::System.Collections.Generic.List<ushort>();
						ushort num3 = 0;
						num = (short)581632005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_1C0;
					case 2:
						if (b >= 214)
						{
							num = (short)1403453440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						list2.Add(b);
						b += 2;
						num = (short)2059272196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1C2;
					case 4:
						goto IL_1C2;
					case 5:
						goto IL_134;
					case 6:
						goto IL_134;
					case 7:
					{
						num = (short)393217;
						if (num != 0)
						{
						}
						num = (short)1271005184;
						short num4 = num;
						ushort num3;
						if (num3 >= 2044)
						{
							num = (short)1958608897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1469504304;
						short num5 = num;
						num = (short)2090982192;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1460207616;
							if (num != 0)
							{
							}
							list.Add(num3);
							num3 += 1;
							num = (short)1472266246;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_4E;
					IL_134:
					num = (short)698744839;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C2:
					num = (short)1293615106;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1C0:
				return base.IshHandler.ReadCodeplug(list2.ToArray(), base.ProgressIndicator, list);
				IL_4E:
				b = 208;
				list2 = new global::System.Collections.Generic.List<byte>();
				num = (short)374931459;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000D898 File Offset: 0x0000BA98
		private int a(global::Motorola.Common.Communication.UpdateControlAction A_0, out uint A_1)
		{
			short num = (short)341573633;
			if (num != 0)
			{
			}
			num = (short)852501386;
			short num2 = num;
			num = (short)1171137418;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2117140480;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1523318784;
			if (num != 0)
			{
			}
			int result = 0;
			global::Motorola.Common.Communication.XcmpRadioUpdateControl xcmpRadioUpdateControl = new global::Motorola.Common.Communication.XcmpRadioUpdateControl(A_0);
			base.RcmpWrapper.SendAndReceiveMessage(xcmpRadioUpdateControl);
			if (xcmpRadioUpdateControl.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				uint value = (uint)xcmpRadioUpdateControl.Value;
				A_1 = value;
				return result;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_IshStatusBad);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000D980 File Offset: 0x0000BB80
		private uint c(uint A_0)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			global::Motorola.Common.Communication.XcmpPsdtAccess xcmpPsdtAccess;
			short num2;
			string psdtSrcSectionId;
			string psdtTgtSectionId;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_DE;
				case 1:
					if (xcmpPsdtAccess.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)547618821;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23D;
				case 2:
				{
					num2 = (short)2077491200;
					short num3 = num2;
					goto IL_DE;
				}
				case 3:
					goto IL_D9;
				case 4:
					if (A_0 == 2U)
					{
						num2 = (short)1320484867;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)431161350;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_12D;
				case 6:
					if (A_0 == 1U)
					{
						num2 = (short)1775173639;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DE;
				case 7:
					num2 = (short)527106049;
					if (num2 != 0)
					{
					}
					psdtSrcSectionId = global::Motorola.Common.Communication.Crc32.c("ﮪﺬ", a_);
					psdtTgtSectionId = global::Motorola.Common.Communication.Crc32.c("ﮪﺬ", a_);
					num2 = (short)1521025024;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_39;
				IL_DE:
				xcmpPsdtAccess = new global::Motorola.Common.Communication.XcmpPsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction.GetStartAddress, psdtSrcSectionId, psdtTgtSectionId);
				base.RcmpWrapper.SendAndReceiveMessage(xcmpPsdtAccess);
				num2 = (short)226033665;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D9:
			psdtSrcSectionId = global::Motorola.Common.Communication.Crc32.c("ﮪﺬ", a_);
			psdtTgtSectionId = global::Motorola.Common.Communication.Crc32.c("ﮪﺬ", a_);
			goto IL_18B;
			IL_12D:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_IshStatusBad);
			IL_23D:
			return xcmpPsdtAccess.PsdtAddress;
			IL_39:
			psdtSrcSectionId = global::Motorola.Common.Communication.Crc32.c("", a_);
			psdtTgtSectionId = global::Motorola.Common.Communication.Crc32.c("", a_);
			num2 = (short)1334491347;
			short num4 = num2;
			num2 = (short)1845868755;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_18B:
				num2 = (short)1960902658;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)1448476672;
				if (num2 != 0)
				{
				}
				num2 = (short)141688836;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000DBD0 File Offset: 0x0000BDD0
		private int b(uint A_0)
		{
			short num = (short)1276641280;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_83;
				}
				int result;
				for (;;)
				{
					IL_28:
					num = (short)973406209;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						result = 1;
						num = (short)553254913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return result;
					case 2:
						goto IL_BA;
					case 3:
						goto IL_173;
					case 4:
					{
						byte[] replyBuffer;
						byte[] array;
						if (replyBuffer[7] == array[6])
						{
							num = (short)977666056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_178;
					}
					case 5:
					{
						if (A_0 > 33554432U)
						{
							num = (short)1297809411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array = new byte[1024];
						array = global::Motorola.Common.Communication.AstroIshSequenceManager.c;
						byte[] bytes = global::System.BitConverter.GetBytes(A_0);
						array[2] = bytes[3];
						array[3] = bytes[2];
						global::Motorola.Common.Communication.Rcmp.CustomRcmpMessage customRcmpMessage = new global::Motorola.Common.Communication.Rcmp.CustomRcmpMessage(array);
						base.RcmpWrapper.SendAndReceiveMessage(customRcmpMessage);
						byte[] replyBuffer = customRcmpMessage.ReplyBuffer;
						num = (short)413073417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						byte[] replyBuffer;
						byte[] array;
						if (replyBuffer[8] == array[7])
						{
							num = (short)681443328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_178;
					}
					case 7:
						if (A_0 < 1U)
						{
							num = (short)627310594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)156565509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)428474374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						num = (short)1840119808;
						short num3 = num;
						byte[] replyBuffer;
						if (replyBuffer[0] != 130)
						{
							goto IL_178;
						}
						num = (short)1864395941;
						short num4 = num;
						num = (short)1190620325;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1659568128;
							if (num != 0)
							{
							}
							num = (short)1399586826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						num = (short)845414404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_83;
				}
				IL_BA:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
				IL_173:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
				IL_178:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_IshStatusBad);
				IL_83:
				result = 0;
				num = (short)1169489927;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000DE88 File Offset: 0x0000C088
		private int a(uint A_0)
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.XcmpPsdtAccess xcmpPsdtAccess;
			string psdtSrcSectionId;
			string psdtTgtSectionId;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1502912092;
					short num3 = num2;
					num2 = (short)676896348;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B0;
					default:
						num2 = (short)477167616;
						if (num2 != 0)
						{
						}
						if (xcmpPsdtAccess.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num2 = (short)817299459;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1B0;
					}
					break;
				}
				case 1:
					if (A_0 == 2U)
					{
						num2 = (short)2147287042;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B0;
				case 2:
					psdtSrcSectionId = global::Motorola.Common.Communication.Crc32.c("ﾫ", a_);
					psdtTgtSectionId = global::Motorola.Common.Communication.Crc32.c("ﾫ", a_);
					num2 = (short)786169860;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_170;
				case 4:
					goto IL_B0;
				}
				goto IL_2D;
				IL_B0:
				xcmpPsdtAccess = new global::Motorola.Common.Communication.XcmpPsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction.Copy, psdtSrcSectionId, psdtTgtSectionId);
				base.RcmpWrapper.SendAndReceiveMessage(xcmpPsdtAccess);
				num2 = (short)944111616;
				short num4 = num2;
				num2 = (short)1257242624;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_170:
			num2 = (short)1831010305;
			if (num2 != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_IshStatusBad);
			IL_1B0:
			return (int)xcmpPsdtAccess.ReplyResult;
			IL_2D:
			psdtSrcSectionId = global::Motorola.Common.Communication.Crc32.c("ﾫ", a_);
			psdtTgtSectionId = global::Motorola.Common.Communication.Crc32.c("ﾫ", a_);
			num2 = (short)718012417;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000E04C File Offset: 0x0000C24C
		protected override void WriteRadioCodeplug(global::Motorola.Common.Communication.Pba.PbaObject writePBA, bool forceWrite, bool hostedDepotOperation, global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader cplgHeader = null)
		{
			int a_ = 7;
			short num = (short)2119106560;
			switch (num)
			{
			default:
			{
				num = (short)826540066;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
					uint a_2;
					int num6;
					switch (num2)
					{
					case 0:
						if (base.ProgressIndicator != null)
						{
							num = (short)707067940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_757;
					case 1:
						goto IL_11B;
					case 2:
					{
						writePBA.CodeplugData.DataPartitions.RemoveAll(new global::System.Predicate<global::Motorola.Common.Communication.Pba.DataPartition>(global::Motorola.Common.Communication.AstroIshSequenceManager.<>c.<>9.a));
						base.UpdateOobeBeforeWrite(writePBA);
						base.UpdatePINPasswordBeforeWrite(writePBA);
						base.UpdateWiFiPasswordBeforeWrite(writePBA);
						base.UpdateExternalDataModemPasswordBeforeWrite(writePBA);
						num = (short)1487142912;
						short num3 = num;
						num = (short)1460011014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)871694338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_452;
					case 5:
						goto IL_757;
					case 6:
						goto IL_1D8;
					case 7:
					{
						uint num4;
						bool flag = this.a(global::Motorola.Common.Communication.UpdateControlAction.RadioUpdateCodeplug, out num4) != 0;
						uint num5 = num4;
						if (!flag)
						{
							num = (short)1545404443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_69B;
					}
					case 8:
						base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ErasingCP);
						num = (short)1465909278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1343946772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						base.UpdatePINPasswordBeforeWrite(writePBA);
						base.UpdateWiFiPasswordBeforeWrite(writePBA);
						base.UpdateExternalDataModemPasswordBeforeWrite(writePBA);
						base.UpdateMacAddressBeforeWrite(writePBA);
						num = (short)1172832287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						return;
					case 12:
					{
						if (codeplugInIshItemCollection.Count <= 0)
						{
							num = (short)622985227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num4 = 255U;
						a_2 = 255U;
						num6 = 0;
						uint num5 = 0U;
						num = (short)919273501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteCPDone);
						num = (short)1167130645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (base.ProgressIndicator != null)
						{
							num = (short)555089946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11B;
					case 15:
					{
						uint num4;
						if (num4 == 100U)
						{
							num = (short)1661009936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_69B;
					}
					case 16:
					{
						uint num4;
						this.a(global::Motorola.Common.Communication.UpdateControlAction.RadioCodeplugActive, out num4);
						a_2 = num4;
						num = (short)636944398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (hostedDepotOperation)
						{
							num = (short)1436221450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_167;
					case 18:
					{
						uint num5;
						base.ProgressIndicator.UpdateProgress(num5 / 100.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ErasingCP);
						num = (short)618922025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_2EC;
					case 20:
						if (base.ProgressIndicator != null)
						{
							num = (short)645398567;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_452;
					case 21:
						return;
					case 22:
					{
						uint num5;
						if (num5 < 50U)
						{
							num = (short)391053347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Threading.Thread.Sleep(1000);
						num = (short)114098201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						if (base.ProgressIndicator.CurrentStatus == global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ErasingCP)
						{
							num = (short)551419912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11B;
					case 24:
						if (!forceWrite)
						{
							num = (short)481820704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EC;
					case 25:
						goto IL_11B;
					case 26:
						num = (short)1213661207;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)1885405199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (base.ProgressIndicator != null)
						{
							num = (short)1792278546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26F;
					case 29:
						goto IL_5B9;
					case 30:
						goto IL_11B;
					case 31:
						goto IL_167;
					case 32:
						this.a(a_2);
						num = (short)267321363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (num6 > 65)
						{
							num = (short)435159077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Crc32.c("얣슥솧얩貫청톯톱\udfb3통쪷햹즻킽꒿ꇃ듅꧇막꧋볍ꃑꇓ룕뛗동닛망", a_), global::System.Array.Empty<object>());
						num = (short)923861014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						switch (0)
						{
						case 0:
							goto IL_F7;
						}
						continue;
					case 35:
						global::System.Threading.Thread.Sleep(5000);
						num = (short)693764097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						base.ProgressIndicator.UpdateProgress(0.2, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
						num = (short)1650196485;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_2B0;
					case 38:
					{
						uint num5;
						if (num5 == 100U)
						{
							num = (short)1430454281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B9;
					}
					case 39:
						base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
						num = (short)635109380;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
					{
						num = (short)1703007652;
						short num7 = num;
						num = (short)166909348;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_11B;
						default:
							num = (short)931463168;
							if (num != 0)
							{
							}
							if (base.ProgressIndicator != null)
							{
								num = (short)640745485;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					case 41:
						goto IL_26F;
					}
					IL_F7:
					if (!forceWrite)
					{
						num = (short)668205059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D8;
					IL_11B:
					num = (short)2019426342;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_167:
					codeplugInIshItemCollection = writePBA.GetCodeplugInIshItemCollection();
					num = (short)1478557708;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D8:
					num = (short)1217134609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26F:
					num6++;
					num = (short)1049296929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2EC:
					num = (short)205062144;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_452:
					uint a_3 = this.c(a_2);
					this.b(a_3);
					num = (short)638058520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B9:
					num = (short)1419051015;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_69B:
					num = (short)1874591745;
					if (num != 0)
					{
					}
					num = (short)417071132;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_757:
					base.IshHandler.WriteIshItems(codeplugInIshItemCollection, new global::Motorola.Common.Communication.IteratedProgressIndicator(base.ProgressIndicator, 0.8), true);
					num = (short)1155137576;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_2B0:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_BackgroundEraseTimeout);
			}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000E884 File Offset: 0x0000CA84
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList)
		{
			short num = (short)937558016;
			switch (num)
			{
			default:
			{
				num = (short)1594359815;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug;
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list;
					switch (num2)
					{
					case 0:
						base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
						num = (short)1810563075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (blockList.Any<T>())
						{
							num = (short)2051997705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F0;
					case 2:
						num = (short)1167523841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1CE;
					case 4:
						if (base.ProgressIndicator != null)
						{
							num = (short)1867382792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8F;
					case 5:
						try
						{
							global::System.Collections.Generic.IEnumerator<T> enumerator = blockList.GetEnumerator();
							try
							{
								num = (short)644284417;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1613889539;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										object obj = enumerator.Current;
										list.Add((global::Motorola.Common.Communication.CommonUtil.IshHeader)obj);
										num = (short)1494286338;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										switch (0)
										{
										case 0:
											goto IL_2EC;
										}
										continue;
									case 3:
										num = (short)1918173188;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										goto IL_370;
									}
									IL_31F:
									num = (short)1939406848;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2EC:
									goto IL_31F;
								}
								IL_370:;
							}
							finally
							{
								num = (short)1546387456;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_3A5;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)221773826;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_3DD;
									}
									IL_3A5:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1061224449;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_3DD:;
							}
							goto IL_EB;
						}
						catch (global::System.InvalidCastException systemException)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgumentType, systemException);
						}
						goto IL_3F0;
						IL_EB:
						num = (short)1890844676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (base.ProgressIndicator != null)
						{
							num = (short)514326528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_299;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_6F;
						}
						continue;
					case 8:
					{
						num = (short)678952960;
						short num3 = num;
						num = (short)1513095169;
						if (num != 0)
						{
						}
						base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
						num = (short)1948909578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						num = (short)1493253127;
						short num4 = num;
						num = (short)1295858695;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1CE;
						default:
							num = (short)384106496;
							if (num != 0)
							{
							}
							list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>(blockList.Count);
							num = (short)2007367685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						goto IL_8F;
					}
					IL_6F:
					if (blockList != null)
					{
						num = (short)297009154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3F0;
					IL_8F:
					pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
					codeplug = base.IshHandler.ReadIshItems(list, base.ProgressIndicator);
					num = (short)2127233030;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1CE:
				IL_299:
				pbaObject.SetCodeplug(codeplug);
				base.UpdateWiFiPasswordAfterRead(pbaObject);
				return pbaObject;
				IL_3F0:
				throw new global::System.ArgumentNullException();
			}
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000ECBC File Offset: 0x0000CEBC
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			short num = (short)642842624;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 1:
					goto IL_84;
				case 2:
				{
					num = (short)934805504;
					short num3 = num;
					num = (short)693567489;
					if (num != 0)
					{
					}
					goto IL_89;
				}
				case 3:
					base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
					num = (short)743899137;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (base.ProgressIndicator != null)
					{
						num = (short)560267267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_197;
				case 5:
				{
					base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
					num = (short)1829168844;
					short num4 = num;
					num = (short)452781772;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_90;
					default:
						num = (short)1235550208;
						if (num != 0)
						{
						}
						num = (short)625278978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_3D:
				if (base.ProgressIndicator != null)
				{
					num = (short)585957381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_89;
				IL_90:
				num = (short)1619263492;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_89:
				codeplug = this.ReadRadioCodeplug();
				goto IL_90;
			}
			IL_84:
			IL_197:
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
			pbaObject.SetCodeplug(codeplug);
			global::Motorola.Common.Communication.RadioParams radioParams = base.f();
			pbaObject.CodeplugData.CPVersion = radioParams.CodeplugVersion;
			base.UpdateWiFiPasswordAfterRead(pbaObject);
			base.UpdateExternalDataModemPasswordAfterRead(pbaObject);
			return pbaObject;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000EE94 File Offset: 0x0000D094
		public override global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword, bool hostedDepotOperation)
		{
			short num = (short)168845969;
			short num2 = num;
			num = (short)1003446929;
			switch (num2 == num)
			{
			}
			num = (short)1390084097;
			if (num != 0)
			{
			}
			num = (short)257032192;
			if (num != 0)
			{
			}
			num = (short)2019164160;
			short num3 = num;
			new global::Motorola.Common.Communication.Pba.PbaObject();
			byte[] buffer = writePBA.SerializeToBytes();
			base.ValidateCodeplugVersion(writePBA);
			base.WriteValidation(writePBA);
			this.WriteRadioCodeplug(writePBA, false, false, null);
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(buffer, false);
			pbaObject.CodeplugData.ArchiveSessionID = sessionID;
			return pbaObject;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000EF7C File Offset: 0x0000D17C
		// Note: this type is marked as 'beforefieldinit'.
		static AstroIshSequenceManager()
		{
			short num = (short)429795200;
			short num2 = num;
			num = (short)750397312;
			switch (num2 == num)
			{
			}
			num = (short)882376705;
			if (num != 0)
			{
			}
			num = (short)2033057792;
			if (num != 0)
			{
			}
			num = (short)2091843584;
			short num3 = num;
			global::Motorola.Common.Communication.AstroIshSequenceManager.c = new byte[]
			{
				2,
				2,
				0,
				158,
				0,
				0,
				4,
				44,
				67,
				83,
				68,
				88,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				0,
				0,
				64,
				0,
				byte.MaxValue,
				195,
				161,
				209,
				0,
				0,
				0,
				3,
				82,
				8,
				0,
				17,
				67,
				80,
				71,
				88,
				0,
				0,
				0,
				48,
				85,
				67,
				76,
				88,
				0,
				0,
				3,
				212,
				83,
				69,
				67,
				88,
				0,
				0,
				4,
				32,
				0,
				232,
				byte.MaxValue,
				byte.MaxValue,
				3,
				232,
				4,
				137,
				15,
				159,
				0,
				0,
				15,
				158,
				0,
				0,
				15,
				157,
				0,
				0,
				15,
				156,
				0,
				0,
				15,
				155,
				0,
				0,
				15,
				154,
				0,
				0,
				15,
				153,
				0,
				0,
				15,
				152,
				0,
				0,
				15,
				151,
				0,
				0,
				15,
				150,
				0,
				0,
				15,
				149,
				0,
				0,
				15,
				148,
				0,
				0,
				15,
				147,
				0,
				0,
				15,
				146,
				0,
				0,
				15,
				145,
				0,
				0,
				15,
				144,
				0,
				0,
				15,
				143,
				0,
				0,
				15,
				142,
				0,
				0,
				15,
				141,
				0,
				0,
				15,
				140,
				0,
				0,
				15,
				139,
				0,
				0,
				15,
				138,
				0,
				0,
				15,
				137,
				0,
				0,
				15,
				136,
				0,
				0,
				15,
				135,
				0,
				0,
				15,
				134,
				7,
				209,
				15,
				133,
				7,
				209,
				15,
				132,
				7,
				209,
				15,
				131,
				7,
				209,
				15,
				130,
				7,
				209,
				15,
				129,
				7,
				209,
				15,
				128,
				7,
				209,
				15,
				127,
				7,
				209,
				15,
				109,
				0,
				0,
				15,
				108,
				0,
				0,
				15,
				107,
				0,
				0,
				15,
				106,
				0,
				0,
				15,
				105,
				0,
				0,
				15,
				104,
				0,
				0,
				15,
				103,
				0,
				0,
				15,
				102,
				0,
				0,
				15,
				84,
				0,
				36,
				15,
				83,
				0,
				50,
				15,
				82,
				0,
				byte.MaxValue,
				15,
				81,
				0,
				byte.MaxValue,
				15,
				80,
				0,
				0,
				15,
				79,
				0,
				0,
				15,
				78,
				0,
				0,
				15,
				77,
				0,
				0,
				15,
				76,
				0,
				0,
				15,
				75,
				0,
				0,
				15,
				74,
				0,
				0,
				15,
				73,
				0,
				0,
				15,
				72,
				0,
				0,
				15,
				71,
				0,
				0,
				15,
				70,
				0,
				0,
				15,
				69,
				0,
				0,
				15,
				68,
				0,
				0,
				15,
				67,
				0,
				0,
				15,
				66,
				0,
				0,
				15,
				65,
				0,
				0,
				15,
				64,
				0,
				0,
				15,
				63,
				0,
				3,
				15,
				62,
				0,
				0,
				15,
				61,
				0,
				0,
				15,
				60,
				0,
				0,
				15,
				59,
				0,
				8,
				15,
				58,
				0,
				0,
				15,
				57,
				0,
				0,
				15,
				56,
				0,
				0,
				15,
				55,
				1,
				244,
				15,
				54,
				2,
				158,
				15,
				53,
				0,
				0,
				15,
				52,
				0,
				0,
				15,
				51,
				0,
				0,
				15,
				50,
				0,
				1,
				15,
				49,
				0,
				1,
				15,
				48,
				0,
				5,
				15,
				47,
				0,
				5,
				15,
				46,
				0,
				2,
				15,
				45,
				0,
				5,
				15,
				44,
				0,
				9,
				15,
				43,
				0,
				0,
				15,
				42,
				0,
				4,
				15,
				41,
				0,
				5,
				15,
				40,
				0,
				2,
				15,
				39,
				0,
				6,
				15,
				38,
				0,
				1,
				15,
				37,
				0,
				byte.MaxValue,
				15,
				36,
				1,
				169,
				15,
				35,
				0,
				byte.MaxValue,
				15,
				34,
				0,
				0,
				15,
				33,
				0,
				byte.MaxValue,
				15,
				32,
				0,
				byte.MaxValue,
				15,
				31,
				0,
				0,
				15,
				30,
				0,
				byte.MaxValue,
				15,
				29,
				1,
				149,
				15,
				28,
				0,
				96,
				15,
				27,
				0,
				96,
				15,
				26,
				0,
				0,
				15,
				25,
				0,
				96,
				15,
				24,
				0,
				96,
				15,
				23,
				0,
				96,
				15,
				22,
				0,
				0,
				15,
				21,
				1,
				44,
				15,
				20,
				0,
				0,
				15,
				19,
				0,
				50,
				15,
				18,
				0,
				0,
				15,
				17,
				1,
				244,
				15,
				16,
				1,
				244,
				15,
				15,
				2,
				117,
				15,
				14,
				1,
				244,
				15,
				13,
				0,
				0,
				15,
				12,
				0,
				200,
				15,
				11,
				0,
				200,
				15,
				10,
				0,
				0,
				15,
				9,
				0,
				200,
				15,
				8,
				1,
				144,
				15,
				7,
				0,
				200,
				15,
				6,
				0,
				0,
				15,
				5,
				0,
				200,
				15,
				4,
				0,
				0,
				15,
				3,
				0,
				200,
				15,
				2,
				0,
				0,
				15,
				1,
				0,
				200,
				15,
				0,
				0,
				0,
				14,
				byte.MaxValue,
				0,
				200,
				14,
				254,
				2,
				88,
				14,
				253,
				0,
				200,
				14,
				252,
				0,
				0,
				14,
				251,
				0,
				200,
				14,
				250,
				0,
				0,
				14,
				249,
				0,
				200,
				14,
				248,
				0,
				0,
				14,
				247,
				1,
				44,
				14,
				246,
				1,
				144,
				14,
				245,
				1,
				44,
				14,
				244,
				1,
				214,
				14,
				243,
				1,
				44,
				14,
				242,
				1,
				133,
				14,
				241,
				0,
				byte.MaxValue,
				14,
				240,
				1,
				169,
				14,
				239,
				0,
				1,
				14,
				238,
				1,
				144,
				14,
				237,
				1,
				144,
				14,
				236,
				1,
				144,
				14,
				235,
				1,
				144,
				14,
				234,
				1,
				144,
				14,
				233,
				1,
				144,
				14,
				215,
				0,
				36,
				14,
				214,
				0,
				1,
				14,
				213,
				7,
				208,
				14,
				212,
				10,
				234,
				14,
				211,
				0,
				0,
				14,
				210,
				0,
				0,
				14,
				209,
				0,
				7,
				14,
				208,
				0,
				7,
				14,
				207,
				0,
				7,
				14,
				206,
				0,
				7,
				14,
				205,
				0,
				7,
				14,
				204,
				0,
				7,
				14,
				186,
				0,
				0,
				14,
				185,
				0,
				1,
				14,
				184,
				0,
				1,
				14,
				183,
				0,
				0,
				14,
				182,
				0,
				0,
				14,
				181,
				0,
				9,
				14,
				180,
				0,
				0,
				14,
				179,
				0,
				0,
				14,
				178,
				0,
				10,
				14,
				177,
				0,
				0,
				14,
				176,
				0,
				0,
				14,
				175,
				0,
				0,
				14,
				174,
				0,
				0,
				14,
				173,
				0,
				0,
				14,
				172,
				0,
				0,
				14,
				171,
				0,
				0,
				14,
				170,
				0,
				0,
				14,
				152,
				0,
				50,
				14,
				151,
				0,
				0,
				14,
				150,
				0,
				50,
				14,
				149,
				0,
				0,
				14,
				148,
				0,
				1,
				14,
				146,
				0,
				50,
				14,
				145,
				0,
				16,
				14,
				144,
				0,
				0,
				14,
				143,
				0,
				0,
				14,
				142,
				0,
				0,
				14,
				141,
				0,
				0,
				14,
				140,
				0,
				0,
				14,
				139,
				0,
				0,
				14,
				138,
				0,
				0,
				14,
				137,
				0,
				0,
				14,
				136,
				0,
				0,
				14,
				135,
				0,
				0,
				14,
				134,
				0,
				0,
				14,
				133,
				0,
				0,
				14,
				132,
				0,
				0,
				14,
				131,
				0,
				0,
				14,
				130,
				0,
				0,
				14,
				129,
				0,
				0,
				14,
				128,
				0,
				30,
				14,
				127,
				0,
				0,
				14,
				126,
				0,
				0,
				14,
				125,
				0,
				0,
				14,
				124,
				0,
				0,
				14,
				123,
				0,
				0,
				14,
				122,
				0,
				0,
				14,
				121,
				0,
				0,
				14,
				120,
				0,
				0,
				14,
				119,
				0,
				0,
				14,
				118,
				0,
				0,
				14,
				117,
				0,
				0,
				14,
				116,
				2,
				243,
				14,
				115,
				0,
				13,
				14,
				114,
				0,
				0,
				14,
				113,
				0,
				50,
				14,
				112,
				0,
				0,
				14,
				111,
				0,
				0,
				14,
				110,
				0,
				4,
				14,
				109,
				0,
				0,
				14,
				108,
				0,
				4,
				14,
				107,
				0,
				0,
				14,
				106,
				0,
				0,
				14,
				105,
				0,
				byte.MaxValue,
				14,
				104,
				0,
				0,
				14,
				103,
				0,
				byte.MaxValue,
				14,
				102,
				0,
				0,
				14,
				98,
				0,
				5,
				14,
				99,
				0,
				50,
				14,
				91,
				0,
				0,
				0,
				18,
				byte.MaxValue,
				byte.MaxValue,
				0,
				0,
				0,
				0,
				19,
				135,
				39,
				17,
				19,
				134,
				39,
				17,
				19,
				133,
				39,
				17,
				19,
				132,
				39,
				17,
				19,
				131,
				39,
				17,
				19,
				130,
				39,
				17,
				19,
				129,
				39,
				17,
				19,
				128,
				39,
				17,
				19,
				110,
				39,
				17,
				19,
				109,
				39,
				17,
				19,
				108,
				39,
				17,
				19,
				107,
				39,
				17,
				19,
				106,
				39,
				17,
				19,
				105,
				39,
				17,
				19,
				104,
				39,
				17,
				19,
				103,
				39,
				17,
				19,
				85,
				0,
				10,
				0,
				2,
				byte.MaxValue,
				byte.MaxValue,
				3,
				132,
				3,
				135,
				3,
				231,
				0,
				10
			};
		}

		// Token: 0x04000053 RID: 83
		private const int a = 1;

		// Token: 0x04000054 RID: 84
		private const int b = 2;

		// Token: 0x04000055 RID: 85
		private static readonly byte[] c;
	}
}
