using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Motorola.Common.CommonLib;
using Motorola.Common.Communication.CommonFile;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x0200000E RID: 14
	public class IOController : global::Motorola.Common.Communication.IshHandler.IRadioCommand
	{
		// Token: 0x06000051 RID: 81 RVA: 0x0000B128 File Offset: 0x00009328
		public global::System.IO.MemoryStream FileRead(ushort filePartition, string filePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null)
		{
			short num = (short)1754660872;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess;
				uint num3;
				switch (num2)
				{
				case 0:
					goto IL_70;
				case 1:
					num = (short)1656750090;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_23B;
				case 3:
					if (progressIndicator != null)
					{
						num = (short)1597636615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BF;
				case 4:
				{
					global::System.IO.MemoryStream memoryStream;
					if (memoryStream != null)
					{
						num = (short)451477505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_154;
				}
				case 5:
				{
					if (xcmpFileAccess.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num = (short)1984888841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3 = xcmpFileAccess.FileSize;
					global::System.IO.MemoryStream memoryStream = this.a(num3, 3, progressIndicator);
					num = (short)1247150084;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_1C9;
				case 7:
				{
					progressIndicator.IncreaseProcess(1.0);
					num = (short)1447618656;
					short num4 = num;
					num = (short)404875360;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_116;
					default:
						num = (short)1080295424;
						if (num != 0)
						{
						}
						num = (short)906362882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 9:
					num = (short)878247939;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					global::System.IO.MemoryStream memoryStream;
					if (memoryStream.Length < (long)((ulong)num3))
					{
						num = (short)632291334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return memoryStream;
				}
				}
				IL_51:
				if (string.IsNullOrEmpty(filePath))
				{
					num = (short)1920073728;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num3 = uint.MaxValue;
				xcmpFileAccess = new global::Motorola.Common.Communication.Rcmp.XcmpFileAccess(filePartition, 0, 0U, 0U, num3, (ushort)filePath.Length, filePath);
				this.a.SendAndReceiveMessage(xcmpFileAccess);
				IL_116:
				num = (short)1083375621;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_70:
			num = (short)579731457;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			IL_BF:
			num = (short)787677184;
			short num5 = num;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
			IL_154:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileReadFailure);
			IL_1C9:
			goto IL_154;
			IL_23B:
			goto IL_BF;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000B3B4 File Offset: 0x000095B4
		public void FileWrite(ushort FilePartition, string FileName, global::System.IO.Stream File, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null, bool isFileCompressed = false)
		{
			short num = (short)733020160;
			switch (num)
			{
			default:
			{
				num = (short)1757020165;
				int num2 = (int)((global::System.IntPtr)num);
				uint num5;
				double num6;
				global::Motorola.Common.Communication.XcmpTransferData.DataType a_;
				for (;;)
				{
					global::Motorola.Common.Communication.XcmpTransferData.DataType dataType;
					switch (num2)
					{
					case 0:
					{
						num = (short)637337600;
						short num3 = num;
						num = (short)652237804;
						short num4 = num;
						num = (short)857889772;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1FC;
						default:
							num = (short)680525824;
							if (num != 0)
							{
							}
							if (File == null)
							{
								num = (short)628621319;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)524550146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_2AD;
					case 2:
					{
						byte transferType = 1;
						uint optionFlag = 2U;
						ushort pathLength = (ushort)FileName.Length;
						num5 = (uint)File.Length;
						uint fileOffset = 0U;
						if (num5 == 0U)
						{
							transferType = 5;
						}
						global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess = new global::Motorola.Common.Communication.Rcmp.XcmpFileAccess(FilePartition, transferType, optionFlag, fileOffset, num5, pathLength, FileName);
						this.a.SendAndReceiveMessage(xcmpFileAccess);
						num6 = 1.0;
						num = (short)328204292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_21D;
					case 4:
						goto IL_1FC;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					case 6:
						if (!isFileCompressed)
						{
							num = (short)1568014349;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)753336330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_1B7;
					case 8:
						dataType = global::Motorola.Common.Communication.XcmpTransferData.DataType.File;
						goto IL_26F;
					case 9:
					{
						global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess;
						if (xcmpFileAccess.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1660813313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31E;
					}
					case 10:
						dataType = global::Motorola.Common.Communication.XcmpTransferData.DataType.CompressFile;
						goto IL_26F;
					case 11:
						num = (short)2095906817;
						if (num != 0)
						{
						}
						num = (short)460193792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						progressIndicator.IncreaseProcess(0.01);
						num6 -= 0.01;
						num = (short)997326851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1312030728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7D:
					if (!string.IsNullOrEmpty(FileName))
					{
						num = (short)1632763915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_1FC:
					if (progressIndicator != null)
					{
						num = (short)729350156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_21D:
					num = (short)833355782;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26F:
					a_ = dataType;
					num = (short)974258185;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_9D:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				IL_1B7:
				goto IL_9D;
				IL_2AD:
				this.a(File, progressIndicator, num5, a_, num6);
				return;
				IL_31E:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
			}
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000B6EC File Offset: 0x000098EC
		public void FileCreate(ushort FilePartition, string FileName)
		{
			short num = (short)483917824;
			switch (num)
			{
			default:
			{
				num = (short)1848115201;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_137;
					case 1:
					{
						num = (short)177143808;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					}
					case 2:
						goto IL_C3;
					case 3:
					{
						global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess;
						if (xcmpFileAccess.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1902313472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_140;
					}
					}
					IL_7E:
					num = (short)1423572993;
					if (num != 0)
					{
					}
					if (string.IsNullOrEmpty(FileName))
					{
						num = (short)1733296130;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						byte transferType = 5;
						uint optionFlag = 0U;
						ushort pathLength = (ushort)FileName.Length;
						uint fileOffset = 0U;
						global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess = new global::Motorola.Common.Communication.Rcmp.XcmpFileAccess(FilePartition, transferType, optionFlag, fileOffset, 0U, pathLength, FileName);
						this.a.SendAndReceiveMessage(xcmpFileAccess);
						num = (short)127270915;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_C3:
				goto IL_139;
				IL_137:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
				IL_139:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				IL_140:
				num = (short)1006089651;
				short num4 = num;
				num = (short)404534707;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_139;
				default:
					num = (short)1419051008;
					if (num != 0)
					{
					}
					return;
				}
				break;
			}
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000B884 File Offset: 0x00009A84
		public void FileDelete(ushort FilePartition, string FileName)
		{
			short num = (short)280821760;
			switch (num)
			{
			default:
			{
				num = (short)479068163;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)699465728;
					short num3 = num;
					switch (num2)
					{
					case 0:
					{
						byte transferType;
						uint optionFlag;
						uint fileOffset;
						ushort pathLength;
						global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess = new global::Motorola.Common.Communication.Rcmp.XcmpFileAccess(FilePartition, transferType, optionFlag, fileOffset, 0U, pathLength, FileName);
						this.a.SendAndReceiveMessage(xcmpFileAccess);
						num = (short)1447100420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_F8;
					case 2:
					{
						global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess2;
						if (xcmpFileAccess2.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)2050686976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_87;
						}
						continue;
					case 4:
					{
						global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess;
						if (xcmpFileAccess.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1903230977;
							if (num != 0)
							{
							}
							num = (short)1112080389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 5:
						goto IL_180;
					}
					IL_87:
					num = (short)1351852621;
					short num4 = num;
					num = (short)987144781;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)258605056;
						if (num != 0)
						{
						}
						if (string.IsNullOrEmpty(FileName))
						{
							num = (short)461635585;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							byte transferType = 2;
							uint optionFlag = 0U;
							ushort pathLength = (ushort)FileName.Length;
							uint fileOffset = 0U;
							global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess2 = new global::Motorola.Common.Communication.Rcmp.XcmpFileAccess(FilePartition, 4, optionFlag, 0U, 0U, pathLength, FileName);
							this.a.SendAndReceiveMessage(xcmpFileAccess2);
							num = (short)1316814850;
							num2 = (int)((global::System.IntPtr)num);
						}
						break;
					}
				}
				IL_F8:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				IL_180:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
			}
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000BA98 File Offset: 0x00009C98
		public void FtlWrite(ushort Partition_ID, global::System.IO.MemoryStream Data, uint OptionFlag, uint Start_ID, uint End_ID, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null)
		{
			short num = (short)1933967364;
			int num2 = (int)((global::System.IntPtr)num);
			double num3;
			for (;;)
			{
				global::Motorola.Common.Communication.Rcmp.XcmpFtlAccess xcmpFtlAccess;
				switch (num2)
				{
				case 0:
					progressIndicator.IncreaseProcess(0.01);
					num3 -= 0.01;
					num = (short)999424006;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_5B;
				case 2:
				{
					num = (short)977141760;
					short num4 = num;
					if (xcmpFtlAccess.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num = (short)1557921797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)800653313;
					if (num != 0)
					{
					}
					num = (short)1175499707;
					short num5 = num;
					num = (short)320451515;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_47;
					default:
						goto IL_1D0;
					}
					break;
				}
				case 3:
					if (progressIndicator != null)
					{
						num = (short)435355648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_60;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 5:
					goto IL_C3;
				case 6:
					goto IL_60;
				}
				goto IL_41;
				IL_47:
				num = (short)167968769;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_41:
				if (Data == null)
				{
					goto IL_47;
				}
				xcmpFtlAccess = new global::Motorola.Common.Communication.Rcmp.XcmpFtlAccess(1, Partition_ID, OptionFlag, Start_ID, End_ID);
				this.a.SendAndReceiveMessage(xcmpFtlAccess);
				num3 = 1.0;
				num = (short)1391591427;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_60:
				num = (short)1939472386;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5B:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			IL_C3:
			this.a(Data, progressIndicator, (uint)Data.Length, global::Motorola.Common.Communication.XcmpTransferData.DataType.FTL, num3);
			return;
			IL_1D0:
			num = (short)983564288;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000BC98 File Offset: 0x00009E98
		public void NandWrite(ushort Partition_ID, global::System.IO.MemoryStream Data, uint OptionFlag, uint Start_ID, uint End_ID, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null)
		{
			short num = (short)1478623234;
			int num2 = (int)((global::System.IntPtr)num);
			double num3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::Motorola.Common.Communication.Rcmp.XcmpNandAccess xcmpNandAccess;
					if (xcmpNandAccess.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num = (short)176291841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EB;
				}
				case 1:
					goto IL_10F;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 3:
					num = (short)611844097;
					if (num != 0)
					{
					}
					goto IL_D5;
				case 4:
					if (progressIndicator != null)
					{
						goto IL_1CE;
					}
					goto IL_D5;
				case 5:
					goto IL_D0;
				case 6:
					progressIndicator.IncreaseProcess(0.01);
					num3 -= 0.01;
					num = (short)1070727171;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_40:
				num = (short)1283167499;
				short num4 = num;
				num = (short)690722059;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1CE:
					num = (short)1809711110;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
				{
					num = (short)531169280;
					if (num != 0)
					{
					}
					if (Data == null)
					{
						num = (short)1048248320;
						short num5 = num;
						num = (short)1302003717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.Common.Communication.Rcmp.XcmpNandAccess xcmpNandAccess = new global::Motorola.Common.Communication.Rcmp.XcmpNandAccess(1, Partition_ID, OptionFlag, Start_ID, End_ID);
					this.a.SendAndReceiveMessage(xcmpNandAccess);
					num3 = 1.0;
					num = (short)446562308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_D5:
				num = (short)946012160;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D0:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			IL_10F:
			this.a(Data, progressIndicator, (uint)Data.Length, global::Motorola.Common.Communication.XcmpTransferData.DataType.Nand, num3);
			return;
			IL_1EB:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000BE9C File Offset: 0x0000A09C
		public void NandDelete(ushort Partition_ID, uint OptionFlag, uint Start_ID, uint End_ID, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null)
		{
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			short num;
			for (;;)
			{
				IL_0A:
				num = (short)822149120;
				short num2 = num;
				int num3;
				switch (num3)
				{
				case 0:
				{
					progressIndicator.IncreaseProcess(0.01);
					double num4;
					num4 -= 0.01;
					num = (short)376111108;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					global::Motorola.Common.Communication.Rcmp.XcmpNandAccess xcmpNandAccess;
					if (xcmpNandAccess.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num = (short)97714178;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 2:
					goto IL_158;
				case 3:
					if (progressIndicator != null)
					{
						num = (short)976879616;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_122;
				case 4:
					goto IL_18D;
				}
				goto IL_4C;
			}
			IL_158:
			num = (short)341966849;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
			IL_18D:
			goto IL_122;
			IL_4C:
			num = (short)1720894030;
			short num5 = num;
			num = (short)538427982;
			switch ((num5 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_122:
				num = (short)981925889;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			default:
			{
				num = (short)479068160;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Rcmp.XcmpNandAccess xcmpNandAccess = new global::Motorola.Common.Communication.Rcmp.XcmpNandAccess(2, Partition_ID, OptionFlag, Start_ID, End_ID);
				this.a.SendAndReceiveMessage(xcmpNandAccess);
				double num4 = 1.0;
				num = (short)1261764611;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000C038 File Offset: 0x0000A238
		private void a(global::System.IO.Stream A_0, global::Motorola.Common.Communication.IProgressIndicator A_1, uint A_2, global::Motorola.Common.Communication.XcmpTransferData.DataType A_3, double A_4)
		{
			short num = (short)1342373888;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6D;
				}
				ushort num5;
				for (;;)
				{
					IL_28:
					num = (short)1482096640;
					short num3 = num;
					int num4;
					uint num6;
					byte[] array;
					ushort num9;
					switch (num2)
					{
					case 0:
						num = (short)2002321410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num4 = (int)num5;
						goto IL_4FC;
					case 2:
						num4 = (int)A_2;
						goto IL_4FC;
					case 3:
						num = (short)235012097;
						if (num != 0)
						{
						}
						if (A_2 <= (uint)num5)
						{
							num = (short)1093795840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C3;
					case 4:
						try
						{
							num = (short)324730891;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								uint num7;
								global::Motorola.Common.Communication.XcmpTransferData xcmpTransferData;
								uint num8;
								switch (num2)
								{
								case 0:
									if (num6 <= 0U)
									{
										num = (short)1233256463;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1040908290;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num7 = (uint)num5;
									goto IL_253;
								case 2:
									if (num6 <= (uint)num5)
									{
										num = (short)220594183;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)721420289;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (xcmpTransferData.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
									{
										num = (short)474021896;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1657733130;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if ((long)array.Length != (long)((ulong)num8))
									{
										num = (short)487718925;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_196;
								case 6:
									if (A_1 != null)
									{
										num = (short)883163154;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_38F;
								case 7:
									num = (short)2103181328;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num9 += 1;
									num6 -= (uint)array.Length;
									num = (short)2027225091;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)1207566355;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									if (xcmpTransferData.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.TransferComplete)
									{
										num = (short)914882569;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_305;
								case 11:
									switch (0)
									{
									case 0:
										goto IL_156;
									}
									continue;
								case 12:
									goto IL_38F;
								case 13:
								{
									array = new byte[num8];
									num = (short)466547832;
									short num10 = num;
									num = (short)775746680;
									switch ((num10 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)560070656;
										if (num != 0)
										{
										}
										num = (short)1958084622;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 14:
									goto IL_196;
								case 15:
									num = (short)811925521;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									num7 = num6;
									goto IL_253;
								case 17:
									goto IL_44E;
								case 18:
								{
									double num11 = num8 / A_2 * 0.99;
									A_1.IncreaseProcess(num11);
									A_4 -= num11;
									num = (short)610533388;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 19:
									goto IL_431;
								}
								IL_15B:
								num = (short)388890624;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_156:
								goto IL_15B;
								IL_196:
								A_0.Read(array, 0, array.Length);
								xcmpTransferData = new global::Motorola.Common.Communication.XcmpTransferData(num9, (byte)A_3, (ushort)array.Length, array);
								this.a.SendAndReceiveMessage(xcmpTransferData);
								num = (short)1204158470;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_253:
								num8 = num7;
								num = (short)585170949;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_38F:
								num = (short)1949302788;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_305:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileTransferDataFailure);
							IL_431:
							IL_44E:
							return;
						}
						finally
						{
							num = (short)61865985;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									A_1.IncreaseProcess(A_4);
									num = (short)2143617026;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_486;
									}
									continue;
								case 2:
									goto IL_4C0;
								}
								IL_486:
								if (A_1 == null)
								{
									break;
								}
								num = (short)1812791296;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4C0:;
						}
						goto IL_4C3;
					}
					goto IL_6D;
					IL_4C3:
					num = (short)161808385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4FC:
					array = new byte[num4];
					num6 = A_2;
					num9 = 0;
					A_0.Position = 0L;
					num = (short)492830724;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_6D:
				num5 = (ushort)(this.MaxDataTransferSize - global::Motorola.Common.Communication.XcmpTransferData.RequestHeaderLength);
				num = (short)8192003;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000C590 File Offset: 0x0000A790
		public long GetFileOrDirSize(ushort PartitionID, string fileOrDirectoryPath)
		{
			short num = (short)929234944;
			switch (num)
			{
			default:
			{
				num = (short)530251778;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess;
				for (;;)
				{
					IL_3E:
					switch (num2)
					{
					case 0:
						goto IL_72;
					case 1:
						while (xcmpFileAccess.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)2007042994;
							short num3 = num;
							num = (short)1908411314;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)931725312;
								short num4 = num;
								num = (short)1429733376;
								if (num != 0)
								{
								}
								num = (short)1813905411;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_3E;
							}
							}
						}
						goto IL_197;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_55;
						}
						continue;
					case 3:
						goto IL_18B;
					}
					IL_55:
					if (string.IsNullOrEmpty(fileOrDirectoryPath))
					{
						num = (short)969146368;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						byte transferType = 4;
						uint optionFlag = 0U;
						uint fileOffset = 0U;
						uint maxValue = uint.MaxValue;
						ushort pathLength = (ushort)fileOrDirectoryPath.Length;
						xcmpFileAccess = new global::Motorola.Common.Communication.Rcmp.XcmpFileAccess(PartitionID, transferType, optionFlag, fileOffset, maxValue, pathLength, fileOrDirectoryPath);
						this.a.SendAndReceiveMessage(xcmpFileAccess);
						num = (short)354222081;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_72:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				IL_18B:
				num = (short)869990401;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
				IL_197:
				return (long)((ulong)xcmpFileAccess.FileSize);
			}
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000C73C File Offset: 0x0000A93C
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> ListDirectoryContents(ushort PartitionID, string directoryPath)
		{
			short num = (short)1610416131;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_57;
				case 1:
				{
					global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess;
					if (xcmpFileAccess.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num = (short)1123155970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.IO.MemoryStream memoryStream = this.a(xcmpFileAccess.FileSize, 3, null);
					num = (short)245891072;
					short num3 = num;
					num = (short)2009399300;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_205;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 4:
					goto IL_256;
				}
				IL_38:
				if (string.IsNullOrEmpty(directoryPath))
				{
					num = (short)1043595264;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess = new global::Motorola.Common.Communication.Rcmp.XcmpFileAccess(PartitionID, 3, 0U, 0U, uint.MaxValue, (ushort)directoryPath.Length, directoryPath);
					this.a.SendAndReceiveMessage(xcmpFileAccess);
					num = (short)1749483521;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_57:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			IL_19B:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
			IL_205:
			goto IL_19B;
			IL_256:
			num = (short)2044919809;
			if (num != 0)
			{
			}
			try
			{
				num = (short)493748225;
				num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> result;
				for (;;)
				{
					global::System.IO.MemoryStream memoryStream;
					switch (num2)
					{
					case 0:
						for (;;)
						{
							num = (short)1111585229;
							short num4 = num;
							num = (short)503607757;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_E9;
							}
						}
						IL_E9:
						num = (short)1656029184;
						if (num != 0)
						{
						}
						result = global::Motorola.Common.Communication.Pba.FileListItemStruct.ParseTransferData(memoryStream.ToArray());
						num = (short)808321026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_8C;
						}
						continue;
					case 2:
						goto IL_123;
					}
					IL_8C:
					global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess;
					if (memoryStream.Length < (long)((ulong)xcmpFileAccess.FileSize))
					{
						goto IL_128;
					}
					num = (short)320995328;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_123:
				return result;
				IL_128:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileDirectoryListFailure);
			}
			finally
			{
				num = (short)1006960641;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.IO.MemoryStream memoryStream;
					switch (num2)
					{
					case 0:
						((global::System.IDisposable)memoryStream).Dispose();
						num = (short)1714421762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_164;
						}
						continue;
					case 2:
						goto IL_198;
					}
					IL_164:
					if (memoryStream == null)
					{
						break;
					}
					num = (short)191954944;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_198:;
			}
			goto IL_19B;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000C9E0 File Offset: 0x0000ABE0
		public void DeleteFilesOrDirectory(ushort PartitionID, global::System.Collections.Generic.List<string> filePaths)
		{
			short num = (short)2133786624;
			switch (num)
			{
			default:
			{
				num = (short)2051145728;
				short num2 = num;
				num = (short)909705217;
				if (num != 0)
				{
				}
				using (global::System.Collections.Generic.List<string>.Enumerator enumerator = filePaths.GetEnumerator())
				{
					num = (short)921698306;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							if (!enumerator.MoveNext())
							{
								num = (short)1841627139;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)848297988;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_274;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_23A;
							}
							continue;
						case 3:
							num = (short)950665221;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (string.IsNullOrEmpty(enumerator.Current))
							{
								num = (short)1935540225;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 5:
							goto IL_2CE;
						}
						IL_276:
						num = (short)2115239936;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_23A:
						goto IL_276;
					}
					IL_274:
					throw new global::System.ArgumentNullException();
					IL_2CE:
					goto IL_1E3;
				}
				return;
				for (;;)
				{
					IL_1E3:
					byte transferType = 2;
					uint optionFlag = 0U;
					uint fileOffset = 0U;
					uint maxValue = uint.MaxValue;
					using (global::System.Collections.Generic.List<string>.Enumerator enumerator = filePaths.GetEnumerator())
					{
						num = (short)1720778754;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							num = (short)1502494359;
							short num4 = num;
							num = (short)385302167;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_146;
							default:
								num = (short)13828096;
								if (num != 0)
								{
								}
								switch (num3)
								{
								case 0:
								{
									global::Motorola.Common.Communication.Rcmp.XcmpFileAccess a_;
									string text;
									if (this.a(a_, text) != 0)
									{
										num = (short)636682243;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1471807493;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_107;
									}
									continue;
								case 3:
									goto IL_1B6;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1133379585;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text = enumerator.Current;
									ushort pathLength = (ushort)text.Length;
									global::Motorola.Common.Communication.Rcmp.XcmpFileAccess a_ = new global::Motorola.Common.Communication.Rcmp.XcmpFileAccess(PartitionID, transferType, optionFlag, fileOffset, maxValue, pathLength, text);
									num = (short)1364918272;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_1D0;
								}
								IL_109:
								num = (short)1489764356;
								num3 = (int)((global::System.IntPtr)num);
								break;
								IL_107:
								goto IL_109;
							}
						}
						IL_146:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
						IL_1B6:
						goto IL_146;
						IL_1D0:
						break;
					}
				}
				return;
			}
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000CD04 File Offset: 0x0000AF04
		public uint GetFreeSpace(ushort PartitionID, string filePath)
		{
			short num = (short)1038745600;
			switch (num)
			{
			default:
			{
				num = (short)2094989314;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess;
				for (;;)
				{
					IL_3F:
					switch (num2)
					{
					case 0:
						goto IL_74;
					case 1:
						while (xcmpFileAccess.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)719499056;
							short num3 = num;
							num = (short)1555083056;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)1382219776;
								if (num != 0)
								{
								}
								num = (short)1653997568;
								short num4 = num;
								num = (short)1024458755;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_3F;
							}
							}
						}
						goto IL_172;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_56;
						}
						continue;
					case 3:
						goto IL_166;
					}
					IL_56:
					if (string.IsNullOrEmpty(filePath))
					{
						num = (short)1773600768;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						byte transferType = 7;
						uint optionFlag = 0U;
						uint fileOffset = 0U;
						uint maxValue = uint.MaxValue;
						ushort pathLength = (ushort)filePath.Length;
						xcmpFileAccess = new global::Motorola.Common.Communication.Rcmp.XcmpFileAccess(PartitionID, transferType, optionFlag, fileOffset, maxValue, pathLength, filePath);
						this.a.SendAndReceiveMessage(xcmpFileAccess);
						num = (short)746651649;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_74:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				IL_166:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
				IL_172:
				num = (short)648675329;
				if (num != 0)
				{
				}
				return xcmpFileAccess.FileSize;
			}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000CEB4 File Offset: 0x0000B0B4
		private int a(global::Motorola.Common.Communication.Rcmp.XcmpFileAccess A_0, string A_1)
		{
			int a_ = 2;
			short num = (short)1312030726;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_B5;
				case 1:
					goto IL_261;
				case 2:
					goto IL_165;
				case 3:
					return -1;
				case 4:
				{
					num = (short)1235091456;
					short num3 = num;
					num = (short)1642266625;
					if (num != 0)
					{
					}
					num = (short)110690318;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					if (string.Equals(global::System.IO.Path.GetExtension(A_1), global::Motorola.Common.Communication.IshHandler.Validator.b("膪莬薮", a_), global::System.StringComparison.OrdinalIgnoreCase))
					{
						num = (short)2027094024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.a.SendAndReceiveMessage(A_0);
					num = (short)1085603842;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_69;
					}
					continue;
				case 7:
					goto IL_B5;
				case 8:
				{
					uint num4 = A_0.FileSize;
					num = (short)1294401543;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
				{
					if (A_0.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						return 0;
					}
					num = (short)462076540;
					short num5 = num;
					num = (short)1941355132;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_261;
					default:
						num = (short)732168192;
						if (num != 0)
						{
						}
						num = (short)977534979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 10:
					num = (short)1567817733;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
				{
					if (A_0.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num = (short)1184890892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					uint num4;
					num4 -= 1U;
					num = (short)2052587520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					return -1;
				case 13:
				{
					uint num4;
					if (num4 <= 1U)
					{
						num = (short)917508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.a.SendAndReceiveMessage(A_0);
					num = (short)462159883;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 14:
					goto IL_165;
				}
				IL_69:
				if (global::System.IO.Path.HasExtension(A_1))
				{
					num = (short)967049226;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.a.SendAndReceiveMessage(A_0);
				num = (short)1218576385;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B5:
				num = (short)1761804301;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_165:
				num = (short)558825481;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_261:
				goto IL_165;
			}
			return -1;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000D1B0 File Offset: 0x0000B3B0
		private global::System.IO.MemoryStream a(uint A_0, byte A_1, global::Motorola.Common.Communication.IProgressIndicator A_2)
		{
			short num = (short)1456603136;
			short num2 = num;
			num = (short)1660551251;
			short num3 = num;
			num = (short)1907753043;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)2032861184;
				if (num != 0)
				{
				}
				num = (short)1279524865;
				if (num != 0)
				{
				}
				num = (short)1071644672;
				switch (num)
				{
				}
				break;
			}
			byte[] buffer = null;
			ushort num4 = (ushort)(this.MaxDataTransferSize - global::Motorola.Common.Communication.XcmpTransferData.ReplyHeaderLength);
			uint num5 = A_0;
			ushort num6 = 0;
			double num7 = 1.0;
			ushort num8 = 0;
			try
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				try
				{
					num = (short)1365573642;
					int num9 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.Common.Communication.XcmpTransferData xcmpTransferData;
						ushort num10;
						switch (num9)
						{
						case 0:
							if (num5 <= 0U)
							{
								num = (short)1189216270;
								num9 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)239861778;
							num9 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_2C7;
						case 2:
							if (xcmpTransferData.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.TransferComplete)
							{
								num = (short)1983053841;
								num9 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2BC;
						case 3:
							num = (short)975044610;
							num9 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num10 = (ushort)num5;
							goto IL_25F;
						case 5:
							goto IL_381;
						case 6:
							goto IL_449;
						case 7:
							goto IL_427;
						case 8:
						{
							double num11 = (double)xcmpTransferData.Length / A_0;
							A_2.IncreaseProcess(num11);
							num7 -= num11;
							num = (short)753860613;
							num9 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							if (A_2 != null)
							{
								num = (short)737542152;
								num9 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_381;
						case 10:
							switch (0)
							{
							case 0:
								goto IL_164;
							}
							continue;
						case 11:
							if ((uint)num6 >= A_0)
							{
								num = (short)127926287;
								num9 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C7;
						case 12:
							if (xcmpTransferData.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.TransferComplete)
							{
								num = (short)409468947;
								num9 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 13:
							num10 = num4;
							goto IL_25F;
						case 14:
							goto IL_427;
						case 15:
							num5 = 0U;
							num = (short)1479999489;
							num9 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							num = (short)1878392845;
							num9 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							goto IL_3BF;
						case 18:
							if (num5 >= (uint)num4)
							{
								num = (short)287899664;
								num9 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)925171716;
							num9 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							num = (short)224526343;
							num9 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							if (xcmpTransferData.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
							{
								num = (short)1763835907;
								num9 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3BF;
						}
						IL_1E0:
						num = (short)1128333312;
						num9 = (int)((global::System.IntPtr)num);
						continue;
						IL_164:
						goto IL_1E0;
						IL_25F:
						ushort length = num10;
						xcmpTransferData = new global::Motorola.Common.Communication.XcmpTransferData(num8, A_1, length, null);
						this.a.SendAndReceiveMessage(xcmpTransferData);
						num8 += 1;
						num = (short)814743561;
						num9 = (int)((global::System.IntPtr)num);
						continue;
						IL_2C7:
						num = (short)846200844;
						num9 = (int)((global::System.IntPtr)num);
						continue;
						IL_381:
						num = (short)450756628;
						num9 = (int)((global::System.IntPtr)num);
						continue;
						IL_3BF:
						memoryStream.Write(xcmpTransferData.Data, 0, (int)xcmpTransferData.Length);
						num5 -= (uint)xcmpTransferData.Length;
						num6 += xcmpTransferData.Length;
						num = (short)257556491;
						num9 = (int)((global::System.IntPtr)num);
						continue;
						IL_427:
						buffer = memoryStream.ToArray();
						num = (short)980811782;
						num9 = (int)((global::System.IntPtr)num);
					}
					IL_2BC:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileTransferDataFailure);
					IL_449:;
				}
				finally
				{
					num = (short)34865152;
					int num9 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num9)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_480;
							}
							continue;
						case 1:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)1359151106;
							num9 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_4B7;
						}
						IL_480:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)1768357889;
						num9 = (int)((global::System.IntPtr)num);
					}
					IL_4B7:;
				}
			}
			finally
			{
				num = (short)715063296;
				int num9 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num9)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_4ED;
						}
						continue;
					case 1:
						A_2.IncreaseProcess(num7);
						num = (short)1793523714;
						num9 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_525;
					}
					IL_4ED:
					if (A_2 == null)
					{
						break;
					}
					num = (short)1050673153;
					num9 = (int)((global::System.IntPtr)num);
				}
				IL_525:;
			}
			return new global::System.IO.MemoryStream(buffer);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000D720 File Offset: 0x0000B920
		// (set) Token: 0x06000060 RID: 96 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		public bool IsCommonFileCrcBigEndian
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1587224400;
				short num2 = num;
				num = (short)603004752;
				switch (num2 == num)
				{
				default:
				{
					num = (short)217251840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1106968577;
				if (num != 0)
				{
				}
				num = (short)1808203776;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)989396993;
				if (num != 0)
				{
				}
				num = (short)594608128;
				short num2 = num;
				num = (short)146670350;
				short num3 = num;
				num = (short)693830414;
				switch (num3 == num)
				{
				}
				num = (short)437059584;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000D880 File Offset: 0x0000BA80
		// (set) Token: 0x06000062 RID: 98 RVA: 0x0000D92C File Offset: 0x0000BB2C
		public int MaxDataTransferSize
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)860823890;
				short num2 = num;
				num = (short)1196302674;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1669332992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2060517376;
				if (num != 0)
				{
				}
				num = (short)905576449;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)576950397;
				short num2 = num;
				num = (short)285773949;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1958281216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1173422081;
				if (num != 0)
				{
				}
				num = (short)851968000;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		// (set) Token: 0x06000064 RID: 100 RVA: 0x0000DA90 File Offset: 0x0000BC90
		public global::Motorola.Common.Communication.Rcmp.XcmpComponentSession SessionCommandReply
		{
			get
			{
				short num = (short)230490113;
				if (num != 0)
				{
				}
				num = (short)1132199936;
				short num2 = num;
				num = (short)1670182169;
				short num3 = num;
				num = (short)1117189401;
				switch (num3 == num)
				{
				}
				num = (short)86310912;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1416232961;
				if (num != 0)
				{
				}
				num = (short)615972864;
				short num2 = num;
				num = (short)53420852;
				short num3 = num;
				num = (short)1160586036;
				switch (num3 == num)
				{
				}
				num = (short)1802764288;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000DB44 File Offset: 0x0000BD44
		// (set) Token: 0x06000066 RID: 102 RVA: 0x0000DBF4 File Offset: 0x0000BDF4
		public bool RetryDifferentialWriteNotSupported
		{
			get
			{
				short num = (short)1622738085;
				short num2 = num;
				num = (short)2085946533;
				switch (num2 == num)
				{
				default:
				{
					num = (short)484769792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1226440705;
				if (num != 0)
				{
				}
				num = (short)866910208;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)1949207398;
				short num2 = num;
				num = (short)844073830;
				switch (num2 == num)
				{
				default:
				{
					num = (short)815071232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1631125505;
				if (num != 0)
				{
				}
				num = (short)458752;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0000DCA4 File Offset: 0x0000BEA4
		// (set) Token: 0x06000068 RID: 104 RVA: 0x0000DD54 File Offset: 0x0000BF54
		public bool MisMatchedRadioAndRMSessionId
		{
			get
			{
				short num = (short)968631582;
				short num2 = num;
				num = (short)438314270;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1722744832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)22347776;
				if (num != 0)
				{
				}
				num = (short)1536884737;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)85245290;
				short num2 = num;
				num = (short)819051882;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1881407488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1554382848;
				if (num != 0)
				{
				}
				num = (short)1013710849;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000DE04 File Offset: 0x0000C004
		public IOController(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, int maxPacketSize, bool isCommonFileCrcBigEndian)
		{
			if (rcmpWrapper == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (maxPacketSize < 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
			this.a = rcmpWrapper;
			this.b = maxPacketSize;
			this.MaxDataTransferSize = maxPacketSize;
			this.IsCommonFileCrcBigEndian = isCommonFileCrcBigEndian;
			this.d = false;
			this.e = false;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000DE5C File Offset: 0x0000C05C
		public void BundleQueryInfo(global::System.Collections.Generic.ICollection<global::Motorola.Common.Communication.RcmpBaseMessage> rcmpMessages)
		{
			short num = (short)233701376;
			short num2 = num;
			num = (short)694645682;
			short num3 = num;
			num = (short)1490777010;
			global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle xcmpSuperBundle;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1830027264;
				if (num != 0)
				{
				}
				num = (short)475201537;
				if (num != 0)
				{
				}
				xcmpSuperBundle = new global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle(true);
				global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.RcmpBaseMessage> enumerator = rcmpMessages.GetEnumerator();
				try
				{
					num = (short)736755713;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
							switch (0)
							{
							case 0:
								goto IL_E0;
							}
							continue;
						case 2:
							goto IL_150;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2052587524;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.RcmpBaseMessage rcmpMessage = enumerator.Current;
							xcmpSuperBundle.AddRcmpMessage(rcmpMessage);
							num = (short)120651776;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)771883010;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_107:
						num = (short)681246723;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_E0:
						goto IL_107;
					}
					IL_150:;
				}
				finally
				{
					num = (short)1472200704;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_184;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)193200130;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1B9;
						}
						IL_184:
						if (enumerator == null)
						{
							break;
						}
						num = (short)595263489;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1B9:;
				}
				break;
			}
			}
			this.a.SendAndReceiveMessage(xcmpSuperBundle);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000E044 File Offset: 0x0000C244
		public void EnterProgramMode(byte entry, byte[] data = null)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.Rcmp.RcmpIshProgramMode rcmpIshProgramMode;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1463843289;
					short num3 = num2;
					num2 = (short)1732606425;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_147;
					default:
						num2 = (short)1125908480;
						if (num2 != 0)
						{
						}
						rcmpIshProgramMode = new global::Motorola.Common.Communication.Rcmp.RcmpIshProgramMode(entry);
						num2 = (short)1567096838;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (data == null)
					{
						num2 = (short)371589120;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1887895554;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_147;
				case 3:
					goto IL_F7;
				case 4:
					if (rcmpIshProgramMode.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)2128674819;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					goto IL_B0;
				case 6:
					goto IL_B0;
				case 7:
					goto IL_18F;
				}
				goto IL_30;
				IL_B0:
				this.a.SendAndReceiveMessage(rcmpIshProgramMode);
				num2 = (short)1222967300;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_147:
				if (data.Length > this.b)
				{
					num2 = (short)1549402113;
					if (num2 != 0)
					{
					}
					num2 = (short)850198535;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					num2 = (short)536739840;
					short num4 = num2;
					rcmpIshProgramMode = new global::Motorola.Common.Communication.Rcmp.RcmpIshProgramMode(entry, data);
					num2 = (short)1209204741;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			IL_F7:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EnterProgramModeFailure);
			IL_18F:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.TooLongOptionalData);
			IL_30:
			rcmpIshProgramMode = null;
			num2 = (short)1133051905;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000E238 File Offset: 0x0000C438
		public bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			int a_ = 12;
			short num2;
			bool result;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_29;
				}
				global::Motorola.Common.Communication.Rcmp.XcmpComponentSession xcmpComponentSession;
				for (;;)
				{
					IL_13:
					int num;
					switch (num)
					{
					case 0:
						if (xcmpComponentSession.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							goto IL_AC;
						}
						num2 = (short)421068801;
						if (num2 != 0)
						{
						}
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.IshHandler.Validator.b("잶\uddb8\udaba즼\udabe뇂꓄ꏆꃈ꓊볎ꗐ닒ꇔꋖ꫘ﯚ믜뻞裠迢胤菦엨쯪裬鷮菰鳲蟴췶\ud9f8胺췼苾", a_), new object[]
						{
							xcmpComponentSession.ReplyResult
						});
						result = false;
						num2 = (short)1364590595;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_E0;
					case 2:
						result = true;
						num2 = (short)1765605377;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_151;
					}
					goto IL_29;
				}
				IL_E0:
				IL_151:
				goto IL_16D;
				IL_29:
				xcmpComponentSession = new global::Motorola.Common.Communication.Rcmp.XcmpComponentSession(2048, sessionID, (uint)((ushort)status));
				this.a.SendAndReceiveMessage(xcmpComponentSession);
				num2 = (short)175871269;
				short num3 = num2;
				num2 = (short)1133679909;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_AC:
					num2 = (short)1589968898;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				default:
				{
					num2 = (short)1191903232;
					if (num2 != 0)
					{
					}
					num2 = (short)1900347392;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.Message, global::System.Array.Empty<object>());
				result = false;
			}
			IL_16D:
			num2 = (short)1379270656;
			short num4 = num2;
			return result;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000E3FC File Offset: 0x0000C5FC
		public void ResetRadio()
		{
			short num = (short)499169983;
			short num2 = num;
			num = (short)1761852095;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B6;
			case 1:
				break;
			default:
			{
				num = (short)1140457472;
				short num3 = num;
				break;
			}
			}
			num = (short)2142109697;
			if (num != 0)
			{
			}
			num = (short)857604096;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Rcmp.RcmpRadioReset rcmpRadioReset = new global::Motorola.Common.Communication.Rcmp.RcmpRadioReset();
			this.a.SendAndReceiveMessage(rcmpRadioReset);
			if (rcmpRadioReset.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				return;
			}
			IL_B6:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ResetRadioFailure);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000E4CC File Offset: 0x0000C6CC
		public void ExitProgramMode(byte exit, byte[] data = null)
		{
			short num = (short)742522881;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_56;
			}
			int num2;
			global::Motorola.Common.Communication.Rcmp.RcmpIshProgramMode rcmpIshProgramMode;
			for (;;)
			{
				IL_30:
				switch (num2)
				{
				case 0:
				{
					num = (short)1485543751;
					short num3 = num;
					num = (short)92969287;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16A;
					default:
						num = (short)841089024;
						if (num != 0)
						{
						}
						rcmpIshProgramMode = new global::Motorola.Common.Communication.Rcmp.RcmpIshProgramMode(exit);
						num = (short)1589313542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (data == null)
					{
						num = (short)251920384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)68288514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_16A;
				case 3:
					goto IL_119;
				case 4:
					if (rcmpIshProgramMode.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num = (short)138608643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					goto IL_D4;
				case 6:
					goto IL_D4;
				case 7:
					goto IL_18D;
				}
				goto IL_56;
				IL_D4:
				this.a.SendAndReceiveMessage(rcmpIshProgramMode);
				num = (short)1924988932;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16A:
				if (data.Length > this.b)
				{
					num = (short)705626119;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1619132416;
					short num4 = num;
					rcmpIshProgramMode = new global::Motorola.Common.Communication.Rcmp.RcmpIshProgramMode(exit, data);
					num = (short)871563269;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_119:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ExitProgramModeFailure);
			IL_18D:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.TooLongOptionalData);
			IL_56:
			rcmpIshProgramMode = null;
			num = (short)141819905;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
		public void EnterBootMode()
		{
			short num = (short)51111647;
			short num2 = num;
			num = (short)1239148255;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_8F;
			case 1:
				break;
			default:
			{
				num = (short)1786380288;
				short num3 = num;
				break;
			}
			}
			num = (short)568590336;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Rcmp.XcmpEnterBootMode xcmpEnterBootMode = new global::Motorola.Common.Communication.Rcmp.XcmpEnterBootMode();
			this.a.SendAndReceiveMessage(xcmpEnterBootMode);
			if (xcmpEnterBootMode.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				return;
			}
			IL_8F:
			num = (short)157089793;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EnterBootModeFailure);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000E788 File Offset: 0x0000C988
		public bool IsLowBattery()
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			short num2;
			bool flag2;
			int num3;
			for (;;)
			{
				IL_0A:
				int num;
				bool flag;
				switch (num)
				{
				case 0:
					flag = false;
					goto IL_20E;
				case 1:
				{
					byte[] array;
					if (array[0] != 1)
					{
						num2 = (short)973537284;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)696123400;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_13F;
				case 3:
					if (flag2)
					{
						num2 = (short)1103101964;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag2;
				case 4:
					num2 = (short)219152384;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_13F;
				case 6:
				{
					byte[] array;
					if (array.Length != 1)
					{
						num2 = (short)65273865;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1503002625;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
				{
					byte[] array;
					if (array != null)
					{
						num2 = (short)383647754;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2BC;
				}
				case 8:
					flag = true;
					goto IL_20E;
				case 9:
					goto IL_13A;
				case 10:
					num2 = (short)1034813441;
					if (num2 != 0)
					{
					}
					num2 = (short)67764230;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
				{
					if (num3 >= 3)
					{
						num2 = (short)83558415;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					byte[] array = this.a(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition.LowBattery);
					num2 = (short)295567367;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 12:
				{
					num2 = (short)594804736;
					short num4 = num2;
					num2 = (short)1281884171;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 13:
					goto IL_244;
				case 14:
					if (flag2)
					{
						num2 = (short)1673723917;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag2;
				case 15:
					goto IL_280;
				}
				goto IL_50;
				IL_13F:
				num2 = (short)197394435;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_20E:
				flag2 = flag;
				num2 = (short)1624244238;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_13A:
			goto IL_2BC;
			IL_244:
			num3++;
			global::System.Threading.Thread.Sleep(2000);
			goto IL_CB;
			IL_280:
			return flag2;
			IL_2BC:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioStatusFailure);
			IL_50:
			num3 = 0;
			flag2 = true;
			num2 = (short)992746620;
			short num5 = num2;
			num2 = (short)602020988;
			switch ((num5 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_CB:
				num2 = (short)378077186;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1523515392;
				if (num2 != 0)
				{
				}
				num2 = (short)257425413;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000EA7C File Offset: 0x0000CC7C
		private byte[] a(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus rcmpRadioStatus;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (rcmpRadioStatus.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)1856110593;
						if (num2 != 0)
						{
						}
						num2 = (short)958857218;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1442185217;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (rcmpRadioStatus.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.InvalidParameter)
					{
						num2 = (short)853082115;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12A;
				case 2:
					goto IL_91;
				case 3:
					goto IL_121;
				}
				goto IL_20;
			}
			IL_91:
			num2 = (short)665637632;
			short num3 = num2;
			num2 = (short)381696;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)1427636224;
				if (num2 != 0)
				{
				}
				break;
			}
			return rcmpRadioStatus.Status;
			IL_121:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioStatusInvalidParameter);
			IL_12A:
			num2 = (short)418512896;
			short num4 = num2;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioStatusFailure);
			IL_20:
			rcmpRadioStatus = new global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus(A_0);
			this.a.SendAndReceiveMessage(rcmpRadioStatus);
			num2 = (short)1469186048;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000EBE8 File Offset: 0x0000CDE8
		public byte QueryRadioUpdateStatus()
		{
			switch (0)
			{
			case 0:
				goto IL_59;
			}
			short num;
			int num3;
			global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus rcmpRadioStatus;
			for (;;)
			{
				IL_0A:
				num = (short)1972043776;
				short num2 = num;
				switch (num3)
				{
				case 0:
					return 0;
				case 1:
					goto IL_18A;
				case 2:
				{
					if (rcmpRadioStatus.Status.Length != 1)
					{
						num = (short)908787713;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1043310025;
					short num4 = num;
					num = (short)1299490249;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_1C4;
					}
					break;
				}
				case 3:
					if (rcmpRadioStatus.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num = (short)897056775;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1829502982;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (rcmpRadioStatus.Status != null)
					{
						num = (short)1731854341;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E2;
				case 5:
					num = (short)1754923009;
					if (num != 0)
					{
					}
					num = (short)953548802;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (rcmpRadioStatus.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.InvalidParameter)
					{
						num = (short)1200750592;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E4;
				case 7:
					num = (short)979632132;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_59;
			}
			return 0;
			IL_E2:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioStatusFailure);
			IL_18A:
			goto IL_E2;
			IL_1C4:
			num = (short)1052901376;
			if (num != 0)
			{
			}
			return rcmpRadioStatus.Status[0];
			IL_1E4:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioStatusFailure);
			IL_59:
			rcmpRadioStatus = new global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition.RadioUpdateStatus);
			this.a.SendAndReceiveMessage(rcmpRadioStatus);
			num = (short)266141699;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000EDE4 File Offset: 0x0000CFE4
		public byte[] QueryRadioSerialNumber()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadRadioSerialNumber, null);
			this.a.SendAndReceiveMessage(rcmpReadWriteSerialNumber);
			if (rcmpReadWriteSerialNumber.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num;
				for (;;)
				{
					num = (short)1699741697;
					if (num != 0)
					{
					}
					num = (short)2110586880;
					short num2 = num;
					num = (short)1224670035;
					short num3 = num;
					num = (short)358021971;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_A7;
					}
				}
				IL_A7:
				num = (short)1622212608;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioSerialNumberFailure);
			}
			return rcmpReadWriteSerialNumber.SerialRawBytes;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000EEC0 File Offset: 0x0000D0C0
		public byte[] QueryProductSerialNumber()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadProductSerialNumber, null);
			this.a.SendAndReceiveMessage(rcmpReadWriteSerialNumber);
			if (rcmpReadWriteSerialNumber.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num;
				for (;;)
				{
					num = (short)519372801;
					if (num != 0)
					{
					}
					num = (short)392626176;
					short num2 = num;
					num = (short)1712657404;
					short num3 = num;
					num = (short)1674777596;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_A8;
					}
				}
				IL_A8:
				num = (short)317325312;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioSerialNumberFailure);
			}
			return rcmpReadWriteSerialNumber.SerialRawBytes;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000EF9C File Offset: 0x0000D19C
		public string QueryRadioModelNumber()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteModelNumber rcmpReadWriteModelNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteModelNumber(0, null);
			this.a.SendAndReceiveMessage(rcmpReadWriteModelNumber);
			if (rcmpReadWriteModelNumber.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num;
				for (;;)
				{
					num = (short)1167856618;
					short num2 = num;
					num = (short)1709970410;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_81;
					}
					break;
				}
				num = (short)293404672;
				short num3 = num;
				IL_81:
				num = (short)440467457;
				if (num != 0)
				{
				}
				num = (short)6684672;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioModelNumberFailure);
			}
			return rcmpReadWriteModelNumber.ModelNumber;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000F078 File Offset: 0x0000D278
		public uint QueryRadioAvailableMemory()
		{
			global::Motorola.Common.Communication.Rcmp.XcmpCodeplugAttribute xcmpCodeplugAttribute = new global::Motorola.Common.Communication.Rcmp.XcmpCodeplugAttribute(global::Motorola.Common.Communication.Rcmp.CodeplugAttributeOperation.Read, global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType.TotalAllowableMemory, null);
			this.a.SendAndReceiveMessage(xcmpCodeplugAttribute);
			short num;
			if (xcmpCodeplugAttribute.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				for (;;)
				{
					num = (short)881389881;
					short num2 = num;
					num = (short)21819705;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_81;
					}
					break;
				}
				num = (short)1490223104;
				short num3 = num;
				IL_81:
				num = (short)29425664;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryCodeplugAttributeFailure);
			}
			num = (short)4784129;
			if (num != 0)
			{
			}
			return xcmpCodeplugAttribute.TotalAllowableMemory;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000F158 File Offset: 0x0000D358
		public byte QueryRadioRegion()
		{
			global::Motorola.Common.Communication.Rcmp.XcmpCodeplugAttribute xcmpCodeplugAttribute = new global::Motorola.Common.Communication.Rcmp.XcmpCodeplugAttribute(global::Motorola.Common.Communication.Rcmp.CodeplugAttributeOperation.Read, global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType.RegionalInformation, null);
			this.a.SendAndReceiveMessage(xcmpCodeplugAttribute);
			if (xcmpCodeplugAttribute.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num;
				for (;;)
				{
					num = (short)23003137;
					if (num != 0)
					{
					}
					num = (short)1241382912;
					short num2 = num;
					num = (short)1060308951;
					short num3 = num;
					num = (short)176883671;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_A8;
					}
				}
				IL_A8:
				num = (short)1716649984;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryCodeplugAttributeFailure);
			}
			return xcmpCodeplugAttribute.RegionalInformation;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000F234 File Offset: 0x0000D434
		public string QueryRadioTanapaNumberByIsh(byte partition, ushort type, ushort id, ushort length, ushort offset)
		{
			short num2;
			global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem rcmpReadIshItem;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)2053898240;
						short num3 = num2;
						if (rcmpReadIshItem.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num2 = (short)360054786;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_165;
					}
					case 1:
						goto IL_6A;
					case 2:
						goto IL_125;
					case 3:
						if (rcmpReadIshItem.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.IncorrectMode)
						{
							num2 = (short)1482227713;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)657522688;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20;
				}
				IL_125:
				num2 = (short)1861248473;
				short num4 = num2;
				num2 = (short)1071801817;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_A4;
				}
				IL_20:
				rcmpReadIshItem = new global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem(partition, type, id, length, offset);
				this.a.SendAndReceiveMessage(rcmpReadIshItem);
				num2 = (short)747110403;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_6A:
			num2 = (short)993460225;
			if (num2 != 0)
			{
			}
			return rcmpReadIshItem.ReplyResult.ToString();
			IL_A4:
			num2 = (short)1934295040;
			if (num2 != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadIshItemFailure);
			IL_165:
			return global::System.Text.Encoding.Default.GetString(rcmpReadIshItem.Data);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000F3B8 File Offset: 0x0000D5B8
		public byte[] QueryBanditEEPROMByIsh(byte partition, ushort type, ushort id, ushort length, ushort offset)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem rcmpReadIshItem = new global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem(partition, type, id, length, offset);
			this.a.SendAndReceiveMessage(rcmpReadIshItem);
			if (rcmpReadIshItem.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num;
				for (;;)
				{
					num = (short)286101844;
					short num2 = num;
					num = (short)1820627284;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_85;
					}
					break;
				}
				num = (short)1978531840;
				short num3 = num;
				IL_85:
				num = (short)1907556353;
				if (num != 0)
				{
				}
				num = (short)642711552;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadIshItemFailure);
			}
			return rcmpReadIshItem.Data;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000F498 File Offset: 0x0000D698
		public byte QueryRadioRegionByIsh(byte partition, ushort type, ushort id, ushort offset)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem rcmpReadIshItem = new global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem(partition, type, id, 1, offset);
			this.a.SendAndReceiveMessage(rcmpReadIshItem);
			if (rcmpReadIshItem.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num;
				for (;;)
				{
					num = (short)737476609;
					if (num != 0)
					{
					}
					num = (short)67633152;
					short num2 = num;
					num = (short)953970355;
					short num3 = num;
					num = (short)330722995;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_AC;
					}
				}
				IL_AC:
				num = (short)280231936;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadIshItemFailure);
			}
			return rcmpReadIshItem.Data[0];
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000F57C File Offset: 0x0000D77C
		public bool Is32MPlatform()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.FlashSize);
			this.a.SendAndReceiveMessage(rcmpVersionInformation);
			if (rcmpVersionInformation.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num;
				for (;;)
				{
					num = (short)404094977;
					if (num != 0)
					{
					}
					num = (short)901971968;
					short num2 = num;
					num = (short)1889018566;
					short num3 = num;
					num = (short)1705059014;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_A7;
					}
				}
				IL_A7:
				num = (short)796524544;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryVersionInfoFailure);
			}
			return rcmpVersionInformation.FlashSizeType == global::Motorola.Common.Communication.Rcmp.FlashSizeType.FlashSize32M;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000F65C File Offset: 0x0000D85C
		public bool IsDualBoard()
		{
			short num2;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				global::Motorola.Common.Communication.Rcmp.RcmpDiscoverRemoteDevice rcmpDiscoverRemoteDevice;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (rcmpDiscoverRemoteDevice.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.OpcodeNotSupported)
						{
							num2 = (short)1040777218;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_144;
					case 1:
						return true;
					case 2:
						goto IL_13D;
					case 3:
					{
						if (rcmpDiscoverRemoteDevice.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num2 = (short)320208897;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1582301185;
						if (num2 != 0)
						{
						}
						num2 = (short)2056192000;
						short num3 = num2;
						num2 = (short)2026307584;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_20;
				}
				IL_13D:
				num2 = (short)1972724418;
				short num4 = num2;
				num2 = (short)767058626;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_9E;
				}
				IL_20:
				rcmpDiscoverRemoteDevice = new global::Motorola.Common.Communication.Rcmp.RcmpDiscoverRemoteDevice();
				this.a.SendAndReceiveMessage(rcmpDiscoverRemoteDevice);
				num2 = (short)1464926211;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return true;
			IL_9E:
			num2 = (short)837812224;
			if (num2 != 0)
			{
			}
			return false;
			IL_144:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RemoteDeviceDiscoveryFailure);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000F7B8 File Offset: 0x0000D9B8
		public byte QuerySecurityCapability(global::Motorola.Common.Communication.CommonUtil.ProductFamily family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.PCRRadio)
		{
			short num = (short)576913408;
			int num2 = (int)((global::System.IntPtr)num);
			byte result;
			for (;;)
			{
				num = (short)272750291;
				short num3 = num;
				num = (short)1167644371;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2045378561;
					if (num != 0)
					{
					}
					num = (short)2109210624;
					if (num != 0)
					{
					}
					byte b;
					byte b2;
					global::Motorola.Common.Communication.Rcmp.XcmpCodeplugAttribute xcmpCodeplugAttribute;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_C6;
						}
						continue;
					case 1:
					{
						num = (short)1965752320;
						short num4 = num;
						b = 0;
						goto IL_19D;
					}
					case 2:
						num = (short)2044657665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return result;
					case 4:
						num = (short)349241350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return result;
					case 6:
						b2 = 0;
						goto IL_22B;
					case 7:
					{
						global::Motorola.Common.Communication.Rcmp.XcmpSecureConnect xcmpSecureConnect;
						b2 = xcmpSecureConnect.SSLCertificateSupportedID;
						goto IL_22B;
					}
					case 8:
					{
						global::Motorola.Common.Communication.Rcmp.XcmpSecureConnect xcmpSecureConnect;
						if (xcmpSecureConnect.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1850998788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2064318471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						b = xcmpCodeplugAttribute.SecurityCapability;
						goto IL_19D;
					case 10:
						if (xcmpCodeplugAttribute.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1455489026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2133393417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						global::Motorola.Common.Communication.Rcmp.XcmpSecureConnect xcmpSecureConnect = new global::Motorola.Common.Communication.Rcmp.XcmpSecureConnect(global::Motorola.Common.Communication.Rcmp.FuctionOperation.ReadCertID);
						this.a.SendAndReceiveMessage(xcmpSecureConnect);
						num = (short)1331363848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_C6:
					if (global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRadio == family)
					{
						num = (short)826802187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					xcmpCodeplugAttribute = new global::Motorola.Common.Communication.Rcmp.XcmpCodeplugAttribute(global::Motorola.Common.Communication.Rcmp.CodeplugAttributeOperation.Read, global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType.CertificateSupportedID, null);
					this.a.SendAndReceiveMessage(xcmpCodeplugAttribute);
					num = (short)314900490;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19D:
					result = b;
					num = (short)377421827;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22B:
					result = b2;
					break;
				}
				}
				num = (short)116195333;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000FA2C File Offset: 0x0000DC2C
		public byte[] QueryRemoteSerialNumber()
		{
			short num = (short)601620481;
			if (num != 0)
			{
			}
			num = (short)573571072;
			short num2 = num;
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadProductSerialNumber, null);
			try
			{
				switch (0)
				{
				case 0:
					goto IL_76;
				}
				int num3;
				for (;;)
				{
					IL_64:
					switch (num3)
					{
					case 0:
						goto IL_111;
					case 1:
						goto IL_135;
					case 2:
					{
						num = (short)791609453;
						short num4 = num;
						num = (short)1104085101;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_135;
						default:
							num = (short)2020999168;
							if (num != 0)
							{
							}
							if (rcmpReadWriteSerialNumber.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
							{
								num = (short)974848000;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)16449537;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_76;
				}
				IL_111:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioSerialNumberFailure);
				IL_135:
				goto IL_13F;
				IL_76:
				ushort deviceId = this.DiscoverRemoteDevice();
				this.RemoteConnect(deviceId);
				this.a.SendAndReceiveMessage(rcmpReadWriteSerialNumber);
				num = (short)2047737858;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_64;
			}
			finally
			{
				this.RemoteDisconnect();
			}
			IL_13F:
			return rcmpReadWriteSerialNumber.SerialRawBytes;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000FB90 File Offset: 0x0000DD90
		public ushort DiscoverRemoteDevice()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpDiscoverRemoteDevice rcmpDiscoverRemoteDevice = new global::Motorola.Common.Communication.Rcmp.RcmpDiscoverRemoteDevice();
			this.a.SendAndReceiveMessage(rcmpDiscoverRemoteDevice);
			if (rcmpDiscoverRemoteDevice.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num;
				for (;;)
				{
					num = (short)237688681;
					short num2 = num;
					num = (short)786225001;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_7C;
					}
					break;
				}
				num = (short)1285750784;
				short num3 = num;
				IL_7C:
				num = (short)158334977;
				if (num != 0)
				{
				}
				num = (short)1478557696;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RemoteDeviceDiscoveryFailure);
			}
			return rcmpDiscoverRemoteDevice.BusID;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000FC6C File Offset: 0x0000DE6C
		public bool RemoteConnect(ushort deviceId)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpRemoteConnect rcmpRemoteConnect = new global::Motorola.Common.Communication.Rcmp.RcmpRemoteConnect(deviceId);
			this.a.SendAndReceiveMessage(rcmpRemoteConnect);
			short num;
			if (rcmpRemoteConnect.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				for (;;)
				{
					num = (short)401550522;
					short num2 = num;
					num = (short)1955474618;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_7E;
					}
					break;
				}
				num = (short)1696268288;
				short num3 = num;
				IL_7E:
				num = (short)274857984;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RemoteConnectFailure);
			}
			num = (short)753664001;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000FD40 File Offset: 0x0000DF40
		public bool RemoteDisconnect()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpRemoteDisconnect rcmpRemoteDisconnect = new global::Motorola.Common.Communication.Rcmp.RcmpRemoteDisconnect();
			this.a.SendAndReceiveMessage(rcmpRemoteDisconnect);
			if (rcmpRemoteDisconnect.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num;
				for (;;)
				{
					num = (short)1663306979;
					short num2 = num;
					num = (short)876416227;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_7F;
					}
					break;
				}
				num = (short)809828352;
				short num3 = num;
				IL_7F:
				num = (short)2131034113;
				if (num != 0)
				{
				}
				num = (short)696582144;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RemoteDisconnectFailure);
			}
			return true;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000FE18 File Offset: 0x0000E018
		public string QueryRepeaterMacAddress()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadMACAddress, null);
			this.a.SendAndReceiveMessage(rcmpReadWriteSerialNumber);
			if (rcmpReadWriteSerialNumber.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num;
				for (;;)
				{
					num = (short)823128463;
					short num2 = num;
					num = (short)1760948623;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_7F;
					}
					break;
				}
				num = (short)547028992;
				short num3 = num;
				IL_7F:
				num = (short)1007091713;
				if (num != 0)
				{
				}
				num = (short)742391808;
				if (num != 0)
				{
				}
				return global::System.BitConverter.ToString(rcmpReadWriteSerialNumber.SerialRawBytes);
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioSerialNumberFailure);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000FEF8 File Offset: 0x0000E0F8
		public string GetMacAddressByPort(global::Motorola.Common.Communication.Rcmp.MacAddressPort port)
		{
			string result;
			short num2;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo xcmpModuleInfo;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_DF;
					case 1:
						result = xcmpModuleInfo.MacAddressPort1;
						num2 = (short)225640450;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_128;
					case 3:
					{
						if (port == global::Motorola.Common.Communication.Rcmp.MacAddressPort.PORT1)
						{
							num2 = (short)658964481;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1744865782;
						short num3 = num2;
						num2 = (short)2053933558;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)669188096;
							if (num2 != 0)
							{
							}
							result = xcmpModuleInfo.MacAddressPort2;
							num2 = (short)1204551680;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					break;
				}
				IL_20:
				xcmpModuleInfo = new global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo(global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.FunctionType.Read, global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.ModuleID.Modem, global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.DataType.MACAddress, 1, new byte[1]);
				this.a.SendAndReceiveMessage(xcmpModuleInfo);
				result = string.Empty;
				num2 = (short)519831555;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_DF:
			num2 = (short)1777598464;
			short num4 = num2;
			IL_128:
			num2 = (short)472580097;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00010058 File Offset: 0x0000E258
		public string GetWLANMacAddress(global::Motorola.Common.Communication.Rcmp.MacAddressPort port)
		{
			string result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo xcmpModuleInfo;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return result;
					case 1:
						result = xcmpModuleInfo.WIFIMacAddressPort1;
						num2 = (short)1469841410;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						return result;
					case 3:
					{
						if (port == global::Motorola.Common.Communication.Rcmp.MacAddressPort.PORT1)
						{
							num2 = (short)1778057217;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1612221645;
						short num3 = num2;
						num2 = (short)926518477;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num2 = (short)953614337;
							if (num2 != 0)
							{
							}
							num2 = (short)983236608;
							if (num2 != 0)
							{
							}
							result = xcmpModuleInfo.WIFIMacAddressPort2;
							num2 = (short)1226964992;
							short num4 = num2;
							num2 = (short)1898577920;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					}
					break;
				}
				IL_20:
				xcmpModuleInfo = new global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo(global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.FunctionType.Read, global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.ModuleID.ExpansionBoard, global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.DataType.MACAddress, 1, new byte[1]);
				this.a.SendAndReceiveMessage(xcmpModuleInfo);
				result = string.Empty;
				num2 = (short)1319698435;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000101B8 File Offset: 0x0000E3B8
		public byte[] QueryRadioPhysicalSerialNumber()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus rcmpRadioStatus = new global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition.PhysicalSerialNumber);
			this.a.SendAndReceiveMessage(rcmpRadioStatus);
			if (rcmpRadioStatus.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num;
				for (;;)
				{
					num = (short)926320923;
					short num2 = num;
					num = (short)598051099;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_81;
					}
					break;
				}
				num = (short)1730412544;
				short num3 = num;
				IL_81:
				num = (short)1122500609;
				if (num != 0)
				{
				}
				num = (short)877264896;
				if (num != 0)
				{
				}
				return null;
			}
			return rcmpRadioStatus.Status;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0001028C File Offset: 0x0000E48C
		public byte QueryRadioSMADate()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus rcmpRadioStatus = new global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition.SMADate);
			this.a.SendAndReceiveMessage(rcmpRadioStatus);
			if (rcmpRadioStatus.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num;
				for (;;)
				{
					num = (short)999593946;
					short num2 = num;
					num = (short)1489147866;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_7F;
					}
					break;
				}
				num = (short)1015349248;
				short num3 = num;
				IL_7F:
				num = (short)1879113729;
				if (num != 0)
				{
				}
				num = (short)104267776;
				if (num != 0)
				{
				}
				return 0;
			}
			return rcmpRadioStatus.Status[0];
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00010360 File Offset: 0x0000E560
		public byte QueryRadioWarrantyDate()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus rcmpRadioStatus = new global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition.WarrantyDate);
			this.a.SendAndReceiveMessage(rcmpRadioStatus);
			if (rcmpRadioStatus.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num;
				for (;;)
				{
					num = (short)1460219699;
					short num2 = num;
					num = (short)1826041651;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_80;
					}
					break;
				}
				num = (short)1247674368;
				short num3 = num;
				IL_80:
				num = (short)1527644161;
				if (num != 0)
				{
				}
				num = (short)1107492864;
				if (num != 0)
				{
				}
				return 0;
			}
			return rcmpRadioStatus.Status[0];
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00010434 File Offset: 0x0000E634
		public global::Motorola.Common.Communication.CommonUtil.FPGAStatus QueryFPGAControllerStatus()
		{
			byte[] array;
			short num2;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (array.Length != 1)
						{
							num2 = (short)1405091842;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_138;
					case 1:
					{
						num2 = (short)715522048;
						short num3 = num2;
						num2 = (short)820051968;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						goto IL_C3;
					case 3:
						if (array != null)
						{
							num2 = (short)2112028673;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_57;
					}
					goto IL_20;
				}
				IL_C3:
				num2 = (short)1166060208;
				short num4 = num2;
				num2 = (short)1189325488;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_F7;
				}
				IL_20:
				array = this.a(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition.AlternativeImageStatusOfBanditControllerFPGA);
				num2 = (short)1282277379;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_57:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioStatusFailure);
			IL_F7:
			num2 = (short)174981120;
			if (num2 != 0)
			{
			}
			num2 = (short)2135949313;
			if (num2 != 0)
			{
			}
			goto IL_57;
			IL_138:
			return (global::Motorola.Common.Communication.CommonUtil.FPGAStatus)array[0];
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0001057C File Offset: 0x0000E77C
		public global::Motorola.Common.Communication.CommonUtil.FPGAStatus QueryFPGAWirelineStatus()
		{
			byte[] array;
			short num2;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (array.Length != 1)
						{
							num2 = (short)773521410;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_138;
					case 1:
						num2 = (short)56360961;
						if (num2 != 0)
						{
						}
						num2 = (short)417923072;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_E8;
					case 3:
						if (array != null)
						{
							num2 = (short)471072769;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_7E;
					}
					goto IL_20;
				}
				IL_E8:
				num2 = (short)427580666;
				short num3 = num2;
				num2 = (short)725376250;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_11D;
				}
				IL_20:
				array = this.a(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition.AlternativeImageStatusOfBanditWirelineFPGA);
				num2 = (short)238944259;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_7E:
			num2 = (short)1653997568;
			short num4 = num2;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioStatusFailure);
			IL_11D:
			num2 = (short)680263680;
			if (num2 != 0)
			{
			}
			goto IL_7E;
			IL_138:
			return (global::Motorola.Common.Communication.CommonUtil.FPGAStatus)array[0];
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000106C4 File Offset: 0x0000E8C4
		public bool IsWirelineAvailable()
		{
			byte[] array;
			short num2;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (array.Length != 1)
						{
							num2 = (short)1833304066;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_13B;
					case 1:
						num2 = (short)1419313153;
						if (num2 != 0)
						{
						}
						num2 = (short)53411840;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_EB;
					case 3:
						if (array != null)
						{
							num2 = (short)854917121;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_81;
					}
					goto IL_20;
				}
				IL_EB:
				num2 = (short)1792030414;
				short num3 = num2;
				num2 = (short)1403598542;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_120;
				}
				IL_20:
				array = this.a(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition.BanditWirelineBoardAvailable);
				num2 = (short)1637875715;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_81:
			num2 = (short)2129330176;
			short num4 = num2;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioStatusFailure);
			IL_120:
			num2 = (short)169738240;
			if (num2 != 0)
			{
			}
			goto IL_81;
			IL_13B:
			return array[0] == 1;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00010814 File Offset: 0x0000EA14
		public bool IsDspCapabilityEnabled()
		{
			int a_ = 12;
			short num2;
			bool isDspCapabilityEnabled;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_25;
				}
				int num;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						goto IL_6A;
					case 1:
					{
						num2 = (short)1110964297;
						short num3 = num2;
						num2 = (short)877525065;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7E;
						default:
							goto IL_CD;
						}
						break;
					}
					case 2:
						if (rcmpVersionInformation.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num2 = (short)1128136704;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						isDspCapabilityEnabled = rcmpVersionInformation.IsDspCapabilityEnabled;
						goto IL_7E;
					}
					goto IL_25;
					IL_7E:
					num2 = (short)1075314689;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_6A:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryVersionInfoFailure);
				IL_CD:
				num2 = (short)321126400;
				if (num2 != 0)
				{
				}
				goto IL_118;
				IL_25:
				rcmpVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.DspCapability);
				this.a.SendAndReceiveMessage(rcmpVersionInformation);
				num2 = (short)50135042;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			catch
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.IshHandler.Validator.b("슶\udcb8즺쒼龾藀냂뗄諈꫊뷌껎돐뫒맔뻖귘ꋚ﷜蓞髠폢飤뫦짨귪賬蛮鷰蛲蟴鋶", a_), new object[]
				{
					global::Motorola.Common.Communication.Rcmp.VersionInfoType.DspCapability.ToString()
				});
				throw;
			}
			IL_118:
			num2 = (short)577503233;
			if (num2 != 0)
			{
			}
			num2 = (short)1810759680;
			short num4 = num2;
			return isDspCapabilityEnabled;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0001099C File Offset: 0x0000EB9C
		public bool IsDTPCapabilityEnabled()
		{
			int a_ = 7;
			short num2;
			bool result;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_25;
				}
				int num;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						num2 = (short)624045722;
						short num3 = num2;
						num2 = (short)939601562;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_80;
						default:
							goto IL_CD;
						}
						break;
					}
					case 1:
						if (rcmpVersionInformation.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num2 = (short)413401090;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = rcmpVersionInformation.IsDtpCapabilityEnabled();
						goto IL_80;
					case 2:
						goto IL_6C;
					}
					goto IL_25;
					IL_80:
					num2 = (short)1833566208;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_6C:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryVersionInfoFailure);
				IL_CD:
				num2 = (short)732233728;
				if (num2 != 0)
				{
				}
				goto IL_11A;
				IL_25:
				rcmpVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.DTPCapability);
				this.a.SendAndReceiveMessage(rcmpVersionInformation);
				num2 = (short)1396047873;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			catch
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.IshHandler.Validator.b("잱톳쒵솷骹쪽낿蟃Ʂ룇ꯉ껋ꟍ볏믑ꃓ꿕臙ꟛ鷟뿡쓣ꃥ觧菩胫鯭苯韱", a_), new object[]
				{
					global::Motorola.Common.Communication.Rcmp.VersionInfoType.DTPCapability.ToString()
				});
				throw;
			}
			IL_11A:
			num2 = (short)415629313;
			if (num2 != 0)
			{
			}
			num2 = (short)975831040;
			short num4 = num2;
			return result;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00010B24 File Offset: 0x0000ED24
		public string QueryFPGAControllerAlternativeVersion()
		{
			short num = (short)1433876962;
			short num2 = num;
			num = (short)1255553506;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1877213184;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1421541377;
			if (num != 0)
			{
			}
			num = (short)706936832;
			if (num != 0)
			{
			}
			return this.b(global::Motorola.Common.Communication.Rcmp.VersionInfoType.FPGAControllerAlternativeVersion);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00010BDC File Offset: 0x0000EDDC
		public string QueryFPGAControllerFactoryVersion()
		{
			short num = (short)25952229;
			short num2 = num;
			num = (short)1454112741;
			switch (num2 == num)
			{
			default:
			{
				num = (short)823001088;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2067070976;
			if (num != 0)
			{
			}
			num = (short)763428865;
			if (num != 0)
			{
			}
			return this.b(global::Motorola.Common.Communication.Rcmp.VersionInfoType.FPGAControllerFactoryVersion);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00010C8C File Offset: 0x0000EE8C
		public string QueryFPGAControllerActiveVersion()
		{
			short num = (short)2064779151;
			short num2 = num;
			num = (short)198641551;
			switch (num2 == num)
			{
			default:
			{
				num = (short)959053824;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)30277633;
			if (num != 0)
			{
			}
			num = (short)1922629632;
			if (num != 0)
			{
			}
			return this.b(global::Motorola.Common.Communication.Rcmp.VersionInfoType.FPGAControllerActiveVersion);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00010D44 File Offset: 0x0000EF44
		public string QueryFPGAWirelineAlternativeVersion()
		{
			short num = (short)951474992;
			short num2 = num;
			num = (short)1737775920;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1251278848;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)737607681;
			if (num != 0)
			{
			}
			num = (short)604176384;
			if (num != 0)
			{
			}
			return this.b(global::Motorola.Common.Communication.Rcmp.VersionInfoType.FPGAWirelineAlternativeVersion);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00010DF8 File Offset: 0x0000EFF8
		public string QueryFPGAWirelineFactoryVersion()
		{
			short num = (short)937361409;
			if (num != 0)
			{
			}
			num = (short)2047082496;
			short num2 = num;
			num = (short)883565778;
			short num3 = num;
			num = (short)522003666;
			switch (num3 == num)
			{
			}
			num = (short)1936523264;
			if (num != 0)
			{
			}
			return this.b(global::Motorola.Common.Communication.Rcmp.VersionInfoType.FPGAWirelineFactoryVersion);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00010EB0 File Offset: 0x0000F0B0
		public string QueryFPGAWirelineActiveVersion()
		{
			short num = (short)285627728;
			short num2 = num;
			num = (short)28071248;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1428488192;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)460259329;
			if (num != 0)
			{
			}
			num = (short)1966735360;
			if (num != 0)
			{
			}
			return this.b(global::Motorola.Common.Communication.Rcmp.VersionInfoType.FPGAWirelineActiveVersion);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00010F68 File Offset: 0x0000F168
		private string b(global::Motorola.Common.Communication.Rcmp.VersionInfoType A_0)
		{
			int a_ = 7;
			short num2;
			string result;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_25;
				}
				int num;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						num2 = (short)932211607;
						short num3 = num2;
						num2 = (short)1434020759;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7D;
						default:
							goto IL_CA;
						}
						break;
					}
					case 1:
						if (rcmpVersionInformation.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num2 = (short)2028077058;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = rcmpVersionInformation.FPGAVersionInformation;
						goto IL_7D;
					case 2:
						goto IL_69;
					}
					goto IL_25;
					IL_7D:
					num2 = (short)1360068608;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_69:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryVersionInfoFailure);
				IL_CA:
				num2 = (short)93847552;
				if (num2 != 0)
				{
				}
				goto IL_121;
				IL_25:
				rcmpVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(A_0);
				this.a.SendAndReceiveMessage(rcmpVersionInformation);
				num2 = (short)630980609;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.IshHandler.Validator.b("잱톳쒵솷骹請螿菁郅귇룉뿋ꟍ뿏병跕ꏗꇛ菝샟ꓡ藣迥蓧鿩黫语탯觱엳诵", a_), new object[]
				{
					A_0.ToString(),
					ex.ToString()
				});
				result = string.Empty;
			}
			IL_121:
			num2 = (short)35192833;
			if (num2 != 0)
			{
			}
			num2 = (short)1537474560;
			short num4 = num2;
			return result;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000110F8 File Offset: 0x0000F2F8
		public void SendFPGAErase(global::Motorola.Common.Communication.Rcmp.FpgaOperationID fpgaID)
		{
			short num = (short)1068105728;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_87;
				}
				int num3;
				bool flag;
				int num6;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_CB;
					case 1:
						goto IL_271;
					case 2:
					{
						global::Motorola.Common.Communication.Rcmp.FpgaOperation fpgaOperation;
						if (fpgaOperation.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1305477124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Threading.Thread.Sleep(1000);
						num3 = 0;
						num = (short)2141519886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_26C;
					case 4:
						goto IL_3B5;
					case 5:
						goto IL_CB;
					case 6:
						num = (short)942473227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::Motorola.Common.Communication.Rcmp.FpgaOperation fpgaOperation2;
						if (fpgaOperation2.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.LockSequenceFailure)
						{
							num = (short)564199433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3++;
						num = (short)1685848074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_A8;
					case 9:
						global::System.Threading.Thread.Sleep(1000);
						num = (short)994836480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_CB;
					case 11:
					{
						if (num3 >= 3)
						{
							num = (short)1314914312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.Rcmp.FpgaOperation fpgaOperation2 = new global::Motorola.Common.Communication.Rcmp.FpgaOperation(global::Motorola.Common.Communication.Rcmp.FPGAOperationType.EraseStatus, fpgaID);
						this.a.SendAndReceiveMessage(fpgaOperation2);
						num = (short)1606025237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (!flag)
						{
							num = (short)2103246861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_235;
					case 13:
					{
						num = (short)788400487;
						short num4 = num;
						num = (short)2107378023;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A3;
						default:
						{
							num = (short)169934848;
							if (num != 0)
							{
							}
							num = (short)849412096;
							short num5 = num;
							num = (short)706215937;
							if (num != 0)
							{
							}
							num = (short)1917059090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 14:
						goto IL_CB;
					case 15:
						flag = true;
						num = (short)2091319301;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (!flag)
						{
							num = (short)1349582851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 17:
						goto IL_235;
					case 18:
					{
						if (num6 >= 3)
						{
							num = (short)1391198225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.Rcmp.FpgaOperation fpgaOperation = new global::Motorola.Common.Communication.Rcmp.FpgaOperation(global::Motorola.Common.Communication.Rcmp.FPGAOperationType.Erase, fpgaID);
						this.a.SendAndReceiveMessage(fpgaOperation);
						num = (short)1759379458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						if (!flag)
						{
							num = (short)884539398;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A8;
					case 20:
						goto IL_A3;
					case 21:
					{
						global::Motorola.Common.Communication.Rcmp.FpgaOperation fpgaOperation2;
						if (fpgaOperation2.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)171245583;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)610140167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_87;
					IL_A8:
					num6++;
					num = (short)1746272257;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CB:
					num = (short)184549395;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_235:
					num = (short)882049040;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_271:
					num = (short)1078788108;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A3:
					goto IL_271;
				}
				IL_26C:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EraseFpgaFailure);
				IL_3B5:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EraseFpgaFailure);
				IL_87:
				num6 = 0;
				num3 = 0;
				flag = false;
				num = (short)9306132;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00011524 File Offset: 0x0000F724
		public void SendFPGAReset(global::Motorola.Common.Communication.Rcmp.FpgaOperationID fpgaID)
		{
			global::Motorola.Common.Communication.Rcmp.FpgaOperation fpgaOperation = new global::Motorola.Common.Communication.Rcmp.FpgaOperation(global::Motorola.Common.Communication.Rcmp.FPGAOperationType.Reconfigure, fpgaID);
			this.a.SendAndReceiveMessage(fpgaOperation);
			short num;
			if (fpgaOperation.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				num = (short)1833811753;
				short num2 = num;
				num = (short)1489485609;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1E;
				case 1:
					break;
				default:
				{
					num = (short)56360960;
					short num3 = num;
					break;
				}
				}
				num = (short)1468596224;
				if (num != 0)
				{
				}
				return;
			}
			IL_1E:
			num = (short)1840906241;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ResetFpgaFailure);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000115F8 File Offset: 0x0000F7F8
		public string QueryCodeplugVersion()
		{
			short num = (short)173075543;
			short num2 = num;
			num = (short)1596779607;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1304690688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1731985409;
			if (num != 0)
			{
			}
			num = (short)1116798976;
			if (num != 0)
			{
			}
			return this.a(global::Motorola.Common.Communication.Rcmp.VersionInfoType.CodeplugVersion);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000116A8 File Offset: 0x0000F8A8
		public string QuerySecurityVersion()
		{
			short num = (short)84085605;
			short num2 = num;
			num = (short)1002244965;
			switch (num2 == num)
			{
			default:
			{
				num = (short)769589248;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1969815553;
			if (num != 0)
			{
			}
			num = (short)949813248;
			if (num != 0)
			{
			}
			return this.a(global::Motorola.Common.Communication.Rcmp.VersionInfoType.SecurityVersion);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00011758 File Offset: 0x0000F958
		public string QuerySoftwareVersion()
		{
			short num = (short)778834388;
			short num2 = num;
			num = (short)2026967508;
			switch (num2 == num)
			{
			default:
			{
				num = (short)158203904;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)60489728;
			if (num != 0)
			{
			}
			num = (short)648347649;
			if (num != 0)
			{
			}
			return this.a(global::Motorola.Common.Communication.Rcmp.VersionInfoType.HostSoftwareVersion);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00011808 File Offset: 0x0000FA08
		public string QueryBootloaderVersion()
		{
			short num = (short)1400510842;
			short num2 = num;
			num = (short)1021450618;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1281622016;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1867186177;
			if (num != 0)
			{
			}
			num = (short)2007040000;
			if (num != 0)
			{
			}
			return this.a(global::Motorola.Common.Communication.Rcmp.VersionInfoType.FlashBootAppVersion);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000118BC File Offset: 0x0000FABC
		public string QueryL3BootloaderVersion()
		{
			short num = (short)671285249;
			if (num != 0)
			{
			}
			num = (short)106430464;
			short num2 = num;
			num = (short)296823459;
			short num3 = num;
			num = (short)891562659;
			switch (num3 == num)
			{
			}
			num = (short)1261305856;
			if (num != 0)
			{
			}
			return this.a(global::Motorola.Common.Communication.Rcmp.VersionInfoType.L3BootloaderVersion);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00011970 File Offset: 0x0000FB70
		public string QueryConfigurationVersion()
		{
			short num = (short)1109943236;
			short num2 = num;
			num = (short)1561617348;
			switch (num2 == num)
			{
			default:
			{
				num = (short)506724352;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)495976449;
			if (num != 0)
			{
			}
			num = (short)971309056;
			if (num != 0)
			{
			}
			return this.a(global::Motorola.Common.Communication.Rcmp.VersionInfoType.ConfigurationVersion);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00011A24 File Offset: 0x0000FC24
		public string QueryKernelVersion()
		{
			short num = (short)1213707393;
			short num2 = num;
			num = (short)536196225;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2070806528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1585512448;
			if (num != 0)
			{
			}
			num = (short)2140602369;
			if (num != 0)
			{
			}
			return this.a(global::Motorola.Common.Communication.Rcmp.VersionInfoType.KernelVersion);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00011AD8 File Offset: 0x0000FCD8
		public byte[] QueryRadioUUID()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadUUID rcmpReadUUID = new global::Motorola.Common.Communication.Rcmp.RcmpReadUUID();
			this.a.SendAndReceiveMessage(rcmpReadUUID);
			if (rcmpReadUUID.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num = (short)613999071;
				short num2 = num;
				num = (short)369418719;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1151598592;
					short num3 = num;
					num = (short)1543503873;
					if (num != 0)
					{
					}
					num = (short)1887240192;
					if (num != 0)
					{
					}
					return rcmpReadUUID.UUID;
				}
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioUUIDFailure);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00011BAC File Offset: 0x0000FDAC
		public bool SetDownLoadTGVersion(ushort downloadTalkgroup, string fwVersionToDownload)
		{
			short num = (short)1081813155;
			short num2 = num;
			num = (short)1108027555;
			switch (num2 == num)
			{
			default:
			{
				num = (short)763559936;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1393295361;
			if (num != 0)
			{
			}
			num = (short)1087242240;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.XcmpRadioUpdateControl xcmpRadioUpdateControl = new global::Motorola.Common.Communication.XcmpRadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction.SetDownloadTGVersion, downloadTalkgroup, fwVersionToDownload);
			this.a.SendAndReceiveMessage(xcmpRadioUpdateControl);
			return xcmpRadioUpdateControl.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00011C74 File Offset: 0x0000FE74
		public string QueryPsdtVersion()
		{
			short num = (short)501698123;
			short num2 = num;
			num = (short)450317899;
			switch (num2 == num)
			{
			default:
			{
				num = (short)750059520;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1185284097;
			if (num != 0)
			{
			}
			num = (short)1873870848;
			if (num != 0)
			{
			}
			return this.a(global::Motorola.Common.Communication.Rcmp.VersionInfoType.PsdtVersion);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00011D28 File Offset: 0x0000FF28
		private string a(global::Motorola.Common.Communication.Rcmp.VersionInfoType A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_15A;
				case 1:
					if (rcmpVersionInformation.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.InvalidParameter)
					{
						num2 = (short)1668153344;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B9;
				case 2:
				{
					num2 = (short)1453505789;
					short num3 = num2;
					num2 = (short)1694809341;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15A;
					default:
						num2 = (short)657326080;
						if (num2 != 0)
						{
						}
						if (rcmpVersionInformation.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num2 = (short)626655235;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_15C;
					}
					break;
				}
				case 3:
				{
					num2 = (short)2082078720;
					short num4 = num2;
					num2 = (short)756350977;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_20;
			}
			IL_B9:
			num2 = (short)2084765697;
			if (num2 != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryVersionInfoFailure);
			IL_15A:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidRCMPParameter);
			IL_15C:
			return rcmpVersionInformation.VersionInformation;
			IL_20:
			rcmpVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(A_0);
			this.a.SendAndReceiveMessage(rcmpVersionInformation);
			num2 = (short)503906306;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00011E98 File Offset: 0x00010098
		public uint GetAvailabeSpaceForLanguagePack()
		{
			global::Motorola.Common.Communication.Rcmp.XcmpReadLanguagePackInfo xcmpReadLanguagePackInfo = new global::Motorola.Common.Communication.Rcmp.XcmpReadLanguagePackInfo(global::Motorola.Common.Communication.Rcmp.ReadLanguagePackInfoOperation.AllLanguagePack, null);
			this.a.SendAndReceiveMessage(xcmpReadLanguagePackInfo);
			if (xcmpReadLanguagePackInfo.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num = (short)1464664065;
				if (num != 0)
				{
				}
				num = (short)779394121;
				short num2 = num;
				num = (short)512859209;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1E;
				case 1:
					break;
				default:
				{
					num = (short)1382678528;
					short num3 = num;
					break;
				}
				}
				num = (short)302383104;
				if (num != 0)
				{
				}
				return xcmpReadLanguagePackInfo.AvailableSpace;
			}
			IL_1E:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadLanguagePackInfoFailure);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00011F74 File Offset: 0x00010174
		public void AddLanguagePack(global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation operation, string languagePackID, byte[] languagePackPayloadUnit, bool bigEndianForPackID)
		{
			short num = (short)1444806664;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.Common.Communication.Rcmp.XcmpWriteLanguagePack xcmpWriteLanguagePack;
				switch (num2)
				{
				case 0:
				{
					num = (short)737955102;
					short num3 = num;
					num = (short)878136606;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16;
					default:
						num = (short)1906114560;
						if (num != 0)
						{
						}
						num = (short)360316937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					num = (short)280100869;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_16A;
				case 3:
					goto IL_11E;
				case 4:
					goto IL_E9;
				case 5:
					if (!string.IsNullOrEmpty(languagePackID))
					{
						num = (short)1952120834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21C;
				case 6:
					if (xcmpWriteLanguagePack.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num = (short)1093926916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					if (operation == global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation.AddLanguagePackUnit)
					{
						num = (short)1913061376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_95;
				case 8:
					goto IL_16;
				case 9:
					if (languagePackPayloadUnit == null)
					{
						num = (short)901644291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_95;
				}
				goto IL_4E;
				IL_16:
				switch (0)
				{
				case 0:
					IL_4E:
					if (operation != global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation.AddLanguagePackStart)
					{
						goto IL_16A;
					}
					num = (short)1095696385;
					if (num != 0)
					{
					}
					num = (short)999948289;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_95:
				xcmpWriteLanguagePack = new global::Motorola.Common.Communication.Rcmp.XcmpWriteLanguagePack(operation, languagePackID, languagePackPayloadUnit, bigEndianForPackID);
				this.a.SendAndReceiveMessage(xcmpWriteLanguagePack);
				num = (short)1797914630;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16A:
				num = (short)620691456;
				short num4 = num;
				num = (short)1336672263;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E9:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.AddLanguagePackFailure);
			IL_11E:
			IL_21C:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000121A4 File Offset: 0x000103A4
		public void DeleteLanguagePack(string languagePackID, bool bigEndianForPackID)
		{
			switch (0)
			{
			case 0:
				goto IL_7F;
			}
			short num;
			int num3;
			global::Motorola.Common.Communication.RcmpReplyResult rcmpReplyResult;
			int num5;
			for (;;)
			{
				IL_0A:
				num = (short)143951938;
				short num2 = num;
				num = (short)1779730498;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)486080512;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
					{
						num = (short)4063232;
						short num4 = num;
						goto IL_E3;
					}
					case 1:
						goto IL_11B;
					case 2:
						if (rcmpReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)222035971;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_119;
					case 4:
						num = (short)108134406;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_E1;
					case 6:
					{
						if (num5-- < 0)
						{
							num = (short)438894592;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.Rcmp.XcmpDeleteLanguagePack xcmpDeleteLanguagePack = new global::Motorola.Common.Communication.Rcmp.XcmpDeleteLanguagePack(languagePackID, bigEndianForPackID);
						this.a.SendAndReceiveMessage(xcmpDeleteLanguagePack);
						rcmpReplyResult = xcmpDeleteLanguagePack.ReplyResult;
						num = (short)1005322241;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1155661825;
						if (num != 0)
						{
						}
						if (string.IsNullOrEmpty(languagePackID))
						{
							num = (short)1682440197;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11B;
					case 8:
						if (rcmpReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1039794180;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E3;
					}
					goto IL_7F;
					IL_E3:
					num = (short)1795555330;
					num3 = (int)((global::System.IntPtr)num);
					break;
					IL_11B:
					num = (short)823853064;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_E1:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			IL_119:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DeleteLanguagePackFailure);
			IL_7F:
			num5 = 3;
			rcmpReplyResult = global::Motorola.Common.Communication.RcmpReplyResult.Failure;
			num = (short)1180106759;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000123B0 File Offset: 0x000105B0
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> ReadLanguagePackInfo()
		{
			short num = (short)453888304;
			short num2 = num;
			num = (short)1608501552;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2129526784;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)47251456;
			if (num != 0)
			{
			}
			num = (short)1178927105;
			if (num != 0)
			{
			}
			uint num4;
			return this.b(out num4);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00012460 File Offset: 0x00010660
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePackData()
		{
			short num = (short)2054684672;
			short num2 = num;
			num = (short)150077441;
			if (num != 0)
			{
			}
			num = (short)534577152;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_89;
				}
				global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> list;
				for (;;)
				{
					IL_76:
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo>.Enumerator enumerator;
					switch (num3)
					{
					case 0:
						goto IL_D6;
						try
						{
							for (;;)
							{
								IL_D6:
								num = (short)772079618;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 1:
									{
										global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo;
										languagePackData.LanguagePacks.Add(pcrLanguagePackInfo);
										num = (short)1680343040;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										num = (short)111808337;
										short num4 = num;
										num = (short)511840081;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_D6;
										default:
											num = (short)104136704;
											if (num != 0)
											{
											}
											switch (0)
											{
											case 0:
												goto IL_161;
											}
											continue;
										}
										break;
									}
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)2084438022;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo = enumerator.Current;
										num = (short)122159108;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo;
										if (pcrLanguagePackInfo.Size > 0U)
										{
											num = (short)1274413057;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										goto IL_222;
									case 6:
										num = (short)508952581;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_163:
									num = (short)857014275;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_161:
									goto IL_163;
								}
							}
							IL_222:
							return languagePackData;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_232;
					case 1:
						if (list != null)
						{
							num = (short)1148387330;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return languagePackData;
					case 2:
						goto IL_232;
					}
					goto IL_89;
					IL_232:
					enumerator = list.GetEnumerator();
					num = (short)1111359488;
					num3 = (int)((global::System.IntPtr)num);
				}
				return languagePackData;
				IL_89:
				uint availableSpace;
				list = this.b(out availableSpace);
				languagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
				languagePackData.AvailableSpace = availableSpace;
				num = (short)1356595201;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_76;
			}
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000126E0 File Offset: 0x000108E0
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> b(out uint A_0)
		{
			short num = (short)1680736256;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3B;
				}
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> list;
				global::Motorola.Common.Communication.Rcmp.XcmpReadLanguagePackInfo xcmpReadLanguagePackInfo;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Rcmp.LanguagePackInfo>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_AF;
					case 1:
						try
						{
							num = (short)696647684;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo;
								string text;
								global::Motorola.Common.Communication.Rcmp.LanguagePackInfo languagePackInfo;
								switch (num2)
								{
								case 0:
									goto IL_1F5;
								case 1:
									num = (short)1893597189;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									num = (short)1373592081;
									short num3 = num;
									num = (short)1411799569;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2B9;
									default:
									{
										num = (short)378339328;
										if (num != 0)
										{
										}
										int num4;
										if (num4 == -1)
										{
											num = (short)1858600968;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										pcrLanguagePackInfo.PackID = text.Substring(0, num4);
										num = (short)1418854400;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 3:
									goto IL_1F5;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_12B;
									}
									continue;
								case 5:
									goto IL_2F7;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1818886145;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									languagePackInfo = enumerator.Current;
									pcrLanguagePackInfo = new global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo();
									char[] trimChars = new char[]
									{
										'\0',
										' ',
										'\r',
										'\n'
									};
									text = languagePackInfo.PackID.TrimEnd(trimChars);
									int num4 = text.IndexOf('\0');
									num = (short)1326317570;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_2B9;
								}
								goto IL_12B;
								IL_1F5:
								pcrLanguagePackInfo.Name = languagePackInfo.Name;
								pcrLanguagePackInfo.Size = languagePackInfo.Size;
								pcrLanguagePackInfo.MajorVersion = languagePackInfo.MajorVersion;
								pcrLanguagePackInfo.MinorVersion = languagePackInfo.MinorVersion;
								list.Add(pcrLanguagePackInfo);
								num = (short)1841889287;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_24B:
								num = (short)1743716358;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12B:
								goto IL_24B;
								IL_2B9:
								pcrLanguagePackInfo.PackID = text;
								num = (short)1630994435;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2F7:
							goto IL_34D;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_307;
					case 2:
						if (xcmpReadLanguagePackInfo.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)2147090432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_307;
					}
					goto IL_3B;
					IL_307:
					list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo>(xcmpReadLanguagePackInfo.LanguagePackInfo.Count);
					enumerator = xcmpReadLanguagePackInfo.LanguagePackInfo.GetEnumerator();
					num = (short)2134179841;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_AF:
				num = (short)717946880;
				short num5 = num;
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadLanguagePackInfoFailure);
				IL_34D:
				A_0 = xcmpReadLanguagePackInfo.AvailableSpace;
				return list;
				IL_3B:
				num = (short)1142947841;
				if (num != 0)
				{
				}
				xcmpReadLanguagePackInfo = new global::Motorola.Common.Communication.Rcmp.XcmpReadLanguagePackInfo(global::Motorola.Common.Communication.Rcmp.ReadLanguagePackInfoOperation.AllLanguagePack, null);
				this.a.SendAndReceiveMessage(xcmpReadLanguagePackInfo);
				num = (short)923729922;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00012A60 File Offset: 0x00010C60
		public void WriteLanguagePack(global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo languagePack, int maxXcmpPacketSize, bool bigEndianForPackID, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			short num;
			try
			{
				num = (short)811401216;
				switch (num)
				{
				default:
				{
					num = (short)195231747;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						double num6;
						global::System.IO.Stream stream;
						switch (num2)
						{
						case 0:
						{
							num = (short)175936353;
							short num3 = num;
							num = (short)385782625;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3F0;
							default:
								num = (short)406650880;
								if (num != 0)
								{
								}
								progressIndicator.UpdateProgress(0.0);
								num = (short)1700003845;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_326;
						case 2:
							if (progressIndicator != null)
							{
								num = (short)1619132417;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3DE;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_64;
							}
							continue;
						case 4:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_10F;
								}
								int num4;
								int num5;
								byte[] bytesFromStream;
								int num7;
								for (;;)
								{
									IL_D8:
									switch (num2)
									{
									case 0:
										goto IL_13C;
									case 1:
										goto IL_1ED;
									case 2:
										goto IL_2B5;
									case 3:
										goto IL_175;
									case 4:
										if (num4 > maxXcmpPacketSize - 100)
										{
											num = (short)1509228550;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num5 = num4;
										num = (short)495452168;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										num = (short)1003552770;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										num5 = maxXcmpPacketSize - 100;
										num = (short)983236611;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										if (num4 <= 0)
										{
											num = (short)18350085;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1810104324;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										goto IL_175;
									case 9:
										goto IL_13C;
									case 10:
										progressIndicator.IncreaseProcess(num6 * (double)num5 / (double)num4);
										num = (short)666501121;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 11:
										if (progressIndicator != null)
										{
											num = (short)1228537866;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1ED;
									}
									goto IL_10F;
									IL_13C:
									num = (short)188284935;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_175:
									byte[] array = new byte[num5];
									global::System.Array.Copy(bytesFromStream, num7, array, 0, num5);
									this.AddLanguagePack(global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation.AddLanguagePackUnit, null, array, bigEndianForPackID);
									num = (short)2074345483;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1ED:
									num7 += num5;
									num4 -= num5;
									num = (short)343277577;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2B5:
								goto IL_40E;
								IL_10F:
								bytesFromStream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.GetBytesFromStream(stream);
								num4 = bytesFromStream.Length;
								num5 = 0;
								num7 = 0;
								num = (short)1798111232;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_D8;
							}
							finally
							{
								num = (short)49217538;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										((global::System.IDisposable)stream).Dispose();
										num = (short)186712065;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_323;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_2EE;
										}
										continue;
									}
									IL_2EE:
									if (stream == null)
									{
										break;
									}
									num = (short)1753808896;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_323:;
							}
							goto IL_326;
							IL_40E:
							this.AddLanguagePack(global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation.AddLanguagePackEnd, null, null, bigEndianForPackID);
							num = (short)1940258817;
							if (num != 0)
							{
							}
							num = (short)2072641542;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_38B;
						case 6:
							goto IL_458;
						case 7:
							goto IL_3DE;
						}
						IL_64:
						if (progressIndicator != null)
						{
							num = (short)1372651520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38B;
						IL_326:
						progressIndicator.IncreaseProcess(0.1);
						num6 -= 0.1;
						num = (short)853147655;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_38B:
						this.AddLanguagePack(global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation.AddLanguagePackStart, languagePack.PackID, null, bigEndianForPackID);
						num6 = 1.0;
						num = (short)1816526850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3F0:
						num = (short)1383464964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3DE:
						stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(languagePack.PackFilePath, global::System.IO.FileAccess.Read);
						goto IL_3F0;
					}
					IL_458:
					break;
				}
				}
			}
			finally
			{
				num = (short)1713766402;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						progressIndicator.UpdateProgress(1.0);
						num = (short)1001717761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_4CD;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_48C;
						}
						continue;
					}
					IL_48C:
					if (progressIndicator == null)
					{
						break;
					}
					num = (short)471859200;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4CD:;
			}
			num = (short)773718016;
			short num8 = num;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00012F9C File Offset: 0x0001119C
		private void a(global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation A_0, string A_1, byte[] A_2, bool A_3)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1835466752;
				short num2 = num;
				num = (short)1583611909;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)341850918;
					short num4 = num;
					num = (short)1111571238;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
					{
						num = (short)1142292480;
						if (num != 0)
						{
						}
						global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack xcmpWriteTTSLanguagePack;
						switch (num3)
						{
						case 0:
							goto IL_16C;
						case 1:
							if (!string.IsNullOrEmpty(A_1))
							{
								num = (short)1732247556;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_21C;
						case 2:
							if (xcmpWriteTTSLanguagePack.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
							{
								num = (short)1584660489;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 3:
							num = (short)113180673;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_1B8;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_BF;
							}
							continue;
						case 6:
							num = (short)1609957377;
							if (num != 0)
							{
							}
							if (A_0 == global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation.AddTTSLanguagePackUnit)
							{
								num = (short)477560840;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E4;
						case 7:
							if (A_2 == null)
							{
								num = (short)363986944;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E4;
						case 8:
							num = (short)275972103;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							goto IL_137;
						}
						IL_BF:
						if (A_0 == global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation.AddTTSLanguagePackStart)
						{
							num = (short)2054225923;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
						goto IL_1B8;
						IL_E4:
						xcmpWriteTTSLanguagePack = new global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack(A_0, A_1, A_2, A_3);
						this.a.SendAndReceiveMessage(xcmpWriteTTSLanguagePack);
						num = (short)1123024898;
						num3 = (int)((global::System.IntPtr)num);
						break;
						IL_1B8:
						num = (short)1105723398;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
			IL_137:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.AddTTSLanguagePackFailure);
			IL_16C:
			IL_21C:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000131CC File Offset: 0x000113CC
		public void DeleteTTSLanguagePack(string languagePackID, bool bigEndianForPackID)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::Motorola.Common.Communication.RcmpReplyResult rcmpReplyResult;
			short num2;
			int num4;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (rcmpReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)1695940615;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					goto IL_194;
				case 2:
					goto IL_E5;
				case 3:
				{
					num2 = (short)884700821;
					short num3 = num2;
					num2 = (short)51082901;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)20119552;
						if (num2 != 0)
						{
						}
						num2 = (short)1592131585;
						if (num2 != 0)
						{
						}
						goto IL_194;
					}
					break;
				}
				case 4:
					if (rcmpReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)661782534;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E5;
				case 5:
				{
					if (num4-- < 0)
					{
						num2 = (short)660275202;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.Common.Communication.Rcmp.XcmpDeleteTTSLanguagePack xcmpDeleteTTSLanguagePack = new global::Motorola.Common.Communication.Rcmp.XcmpDeleteTTSLanguagePack(languagePackID, bigEndianForPackID);
					this.a.SendAndReceiveMessage(xcmpDeleteTTSLanguagePack);
					rcmpReplyResult = xcmpDeleteTTSLanguagePack.ReplyResult;
					num2 = (short)247070721;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					num2 = (short)2016542725;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_119;
				}
				goto IL_30;
				IL_E5:
				num2 = (short)774438912;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_194:
				num2 = (short)647823364;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_119:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DeleteTTSLanguagePackFailure);
			IL_30:
			num2 = (short)1370226688;
			short num5 = num2;
			num4 = 3;
			rcmpReplyResult = global::Motorola.Common.Communication.RcmpReplyResult.Failure;
			num2 = (short)305725443;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000133AC File Offset: 0x000115AC
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> ReadTTSLanguagePackInfo()
		{
			short num = (short)1479757986;
			short num2 = num;
			num = (short)274616482;
			switch (num2 == num)
			{
			}
			num = (short)1856634880;
			short num3 = num;
			num = (short)417923072;
			if (num != 0)
			{
			}
			num = (short)942604289;
			if (num != 0)
			{
			}
			uint num4;
			return this.a(out num4);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00013460 File Offset: 0x00011660
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePackData()
		{
			short num = (short)680460288;
			short num2 = num;
			num = (short)1804861440;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_62;
				}
				global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> list;
				for (;;)
				{
					IL_4F:
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo>.Enumerator enumerator;
					switch (num3)
					{
					case 0:
						goto IL_236;
					case 1:
						goto IL_DA;
						try
						{
							for (;;)
							{
								IL_DA:
								num = (short)407240706;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 1:
									{
										global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo;
										languagePackData.LanguagePacks.Add(ttslanguagePackInfo);
										num = (short)1350303744;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										num = (short)433108737;
										short num4 = num;
										num = (short)125417217;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_DA;
										default:
											num = (short)1309736960;
											if (num != 0)
											{
											}
											switch (0)
											{
											case 0:
												goto IL_167;
											}
											continue;
										}
										break;
									}
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)285736966;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo = enumerator.Current;
										num = (short)853475332;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo;
										if (ttslanguagePackInfo.Size > 0U)
										{
											num = (short)1757478913;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										goto IL_226;
									case 6:
										num = (short)2002911237;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_169:
									num = (short)1030356995;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_167:
									goto IL_169;
								}
							}
							IL_226:
							return languagePackData;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_236;
					case 2:
						if (list != null)
						{
							num = (short)1903296512;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return languagePackData;
					}
					goto IL_62;
					IL_236:
					enumerator = list.GetEnumerator();
					num = (short)1805189121;
					num3 = (int)((global::System.IntPtr)num);
				}
				return languagePackData;
				IL_62:
				num = (short)1813774337;
				if (num != 0)
				{
				}
				uint availableSpace;
				list = this.a(out availableSpace);
				languagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
				languagePackData.AvailableSpace = availableSpace;
				num = (short)682688514;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000136E4 File Offset: 0x000118E4
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> a(out uint A_0)
		{
			short num = (short)1010761728;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				global::Motorola.Common.Communication.Rcmp.XcmpReadLanguagePackInfo xcmpReadLanguagePackInfo;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> list;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						if (xcmpReadLanguagePackInfo.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.BitUnlocked)
						{
							num = (short)540409861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo>(xcmpReadLanguagePackInfo.LanguagePackInfo.Count);
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Rcmp.LanguagePackInfo>.Enumerator enumerator = xcmpReadLanguagePackInfo.LanguagePackInfo.GetEnumerator();
						num = (short)1279262726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_14F;
					case 2:
					{
						num = (short)960692224;
						short num3 = num;
						if (xcmpReadLanguagePackInfo.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)411107331;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A3;
					}
					case 3:
						num = (short)508690436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (xcmpReadLanguagePackInfo.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.BitUnlocked)
						{
							num = (short)99614721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A3;
					case 5:
						goto IL_3E0;
					case 6:
						try
						{
							num = (short)1966211076;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.Common.Communication.Rcmp.LanguagePackInfo languagePackInfo;
								global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo;
								string text;
								switch (num2)
								{
								case 1:
									num = (short)787021829;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									num = (short)831118619;
									short num4 = num;
									num = (short)798481691;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_353;
									default:
										num = (short)320864256;
										if (num != 0)
										{
										}
										goto IL_2D1;
									}
									break;
								}
								case 3:
									goto IL_2D1;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_19C;
									}
									continue;
								case 5:
									goto IL_393;
								case 6:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Rcmp.LanguagePackInfo>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)538771457;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									languagePackInfo = enumerator.Current;
									ttslanguagePackInfo = new global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo();
									char[] trimChars = new char[]
									{
										'\0',
										' ',
										'\r',
										'\n'
									};
									text = languagePackInfo.PackID.TrimEnd(trimChars);
									int num5 = text.IndexOf('\0');
									num = (short)479789064;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_353;
								case 8:
								{
									int num5;
									if (num5 == -1)
									{
										num = (short)1413218311;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									ttslanguagePackInfo.PackID = text.Substring(0, num5);
									num = (short)1630535682;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_28E:
								num = (short)273940486;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_19C:
								goto IL_28E;
								IL_2D1:
								ttslanguagePackInfo.Name = languagePackInfo.Name;
								ttslanguagePackInfo.Size = languagePackInfo.Size;
								ttslanguagePackInfo.MajorVersion = languagePackInfo.MajorVersion;
								ttslanguagePackInfo.MinorVersion = languagePackInfo.MinorVersion;
								ttslanguagePackInfo.LanguageCode = languagePackInfo.TTSLanguageCode;
								ttslanguagePackInfo.SpeakerName = languagePackInfo.TTSSpeakerName;
								ttslanguagePackInfo.VoiceGender = languagePackInfo.TTSVoiceGender;
								list.Add(ttslanguagePackInfo);
								num = (short)966656000;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_353:
								ttslanguagePackInfo.PackID = text;
								num = (short)547880963;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_393:
							goto IL_40D;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Rcmp.LanguagePackInfo>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_3A3;
					}
					goto IL_4B;
					IL_3A3:
					num = (short)1480261632;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_14F:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadTTSLanguagePackInfoFailure);
				IL_3E0:
				num = (short)497942529;
				if (num != 0)
				{
				}
				A_0 = 0U;
				return new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo>();
				IL_40D:
				A_0 = xcmpReadLanguagePackInfo.AvailableSpace;
				return list;
				IL_4B:
				xcmpReadLanguagePackInfo = new global::Motorola.Common.Communication.Rcmp.XcmpReadLanguagePackInfo(global::Motorola.Common.Communication.Rcmp.ReadLanguagePackInfoOperation.AllTTSLanguagePack, null);
				this.a.SendAndReceiveMessage(xcmpReadLanguagePackInfo);
				num = (short)900988930;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00013B24 File Offset: 0x00011D24
		public void WriteTTSLanguagePack(global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo languagePack, int maxXcmpPacketSize, bool bigEndianForPackID, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			short num;
			try
			{
				num = (short)10747904;
				switch (num)
				{
				default:
				{
					num = (short)1859387398;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						double num4;
						global::System.IO.Stream stream;
						switch (num2)
						{
						case 0:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_C8;
								}
								int num3;
								int num5;
								byte[] bytesFromStream;
								int num6;
								for (;;)
								{
									IL_91:
									switch (num2)
									{
									case 0:
										goto IL_130;
									case 1:
										goto IL_F6;
									case 2:
										goto IL_F6;
									case 3:
										num3 = maxXcmpPacketSize - 100;
										num = (short)170917894;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										progressIndicator.IncreaseProcess(num4 * (double)num3 / (double)num5);
										num = (short)1085931529;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										if (progressIndicator != null)
										{
											num = (short)2118385668;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1A9;
									case 6:
										goto IL_130;
									case 7:
										num = (short)2104950792;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										goto IL_274;
									case 9:
										goto IL_1A9;
									case 10:
										if (num5 <= 0)
										{
											num = (short)814874631;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)638255115;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 11:
										if (num5 > maxXcmpPacketSize - 100)
										{
											num = (short)1670053891;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num3 = num5;
										num = (short)1923678208;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_C8;
									IL_F6:
									num = (short)284164106;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_130:
									byte[] array = new byte[num3];
									global::System.Array.Copy(bytesFromStream, num6, array, 0, num3);
									this.a(global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation.AddTTSLanguagePackUnit, null, array, bigEndianForPackID);
									num = (short)2089615365;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1A9:
									num6 += num3;
									num5 -= num3;
									num = (short)253886466;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_274:
								goto IL_3F2;
								IL_C8:
								bytesFromStream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.GetBytesFromStream(stream);
								num5 = bytesFromStream.Length;
								num3 = 0;
								num6 = 0;
								num = (short)534970369;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_91;
							}
							finally
							{
								num = (short)379191297;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)1167720449;
										if (num != 0)
										{
										}
										((global::System.IDisposable)stream).Dispose();
										num = (short)1405485058;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_2AC;
										}
										continue;
									case 2:
										goto IL_309;
									}
									IL_2AC:
									if (stream == null)
									{
										break;
									}
									num = (short)986185728;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_309:;
							}
							goto IL_30C;
							IL_3F2:
							this.a(global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation.AddTTSLanguagePackEnd, null, null, bigEndianForPackID);
							num = (short)1284964356;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_370;
						case 2:
							goto IL_3C3;
						case 3:
							progressIndicator.UpdateProgress(0.0);
							num = (short)1692663809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_416;
						case 5:
							if (progressIndicator != null)
							{
								num = (short)1182728199;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3C3;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_65;
							}
							continue;
						case 7:
							goto IL_30C;
						}
						IL_65:
						if (progressIndicator != null)
						{
							num = (short)344195075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_370;
						IL_30C:
						progressIndicator.IncreaseProcess(0.1);
						num4 -= 0.1;
						num = (short)1478885378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_370:
						this.a(global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation.AddTTSLanguagePackStart, languagePack.PackID, null, bigEndianForPackID);
						num4 = 1.0;
						num = (short)2049114117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3C3:
						stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(languagePack.PackFilePath, global::System.IO.FileAccess.Read);
						num = (short)154664960;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_416:
					break;
				}
				}
			}
			finally
			{
				num = (short)1718483184;
				short num7 = num;
				num = (short)1619917040;
				switch ((num7 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1379401728;
					if (num != 0)
					{
					}
					num = (short)384761857;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							progressIndicator.UpdateProgress(1.0);
							num = (short)249626626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_499;
							}
							continue;
						case 2:
							goto IL_4DA;
						}
						IL_499:
						if (progressIndicator == null)
						{
							break;
						}
						num = (short)1679622144;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
				IL_4DA:;
			}
			num = (short)1340407808;
			short num8 = num;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0001406C File Offset: 0x0001226C
		public void SyncDateTime()
		{
			short num = (short)2088819004;
			short num2 = num;
			num = (short)1983633724;
			switch (num2 == num)
			{
			}
			num = (short)1866661888;
			if (num != 0)
			{
			}
			num = (short)431489025;
			if (num != 0)
			{
			}
			num = (short)137691136;
			short num3 = num;
			global::Motorola.Common.Communication.Rcmp.XcmpDateTime msg = new global::Motorola.Common.Communication.Rcmp.XcmpDateTime(global::System.DateTime.UtcNow);
			this.a.SendAndReceiveMessage(msg);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00014128 File Offset: 0x00012328
		public void UpdateSerialNumber(byte[] serailNumber)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.WriteRadioSerialNumber, serailNumber);
			this.a.SendAndReceiveMessage(rcmpReadWriteSerialNumber);
			if (rcmpReadWriteSerialNumber.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num = (short)527707127;
				short num2 = num;
				num = (short)1693723639;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)57016321;
					if (num != 0)
					{
					}
					num = (short)1018494976;
					short num3 = num;
					num = (short)1984561152;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateSerialNumberFailure);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000141FC File Offset: 0x000123FC
		public void FactoryReset()
		{
			global::Motorola.Common.Communication.Rcmp.XcmpFactoryReset xcmpFactoryReset = new global::Motorola.Common.Communication.Rcmp.XcmpFactoryReset(global::Motorola.Common.Communication.Rcmp.FactoryResetOperationType.FactoryReset);
			this.a.SendAndReceiveMessage(xcmpFactoryReset);
			if (xcmpFactoryReset.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num = (short)1522372974;
				short num2 = num;
				num = (short)1667469678;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)330039297;
					if (num != 0)
					{
					}
					num = (short)1848180736;
					short num3 = num;
					num = (short)212992000;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FactoryResetFailure);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000142CC File Offset: 0x000124CC
		public void UnkillRadio(byte[] authenticationValue)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			global::Motorola.Common.Communication.Rcmp.XcmpUnkill xcmpUnkill;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (xcmpUnkill.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.IncorrectMode)
					{
						num2 = (short)1730084864;
						short num3 = num2;
						num2 = (short)321781768;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22F;
				case 1:
				{
					num2 = (short)1702913828;
					short num4 = num2;
					num2 = (short)1755014948;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_169;
					default:
						num2 = (short)1859125248;
						if (num2 != 0)
						{
						}
						if (xcmpUnkill.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num2 = (short)1205862407;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 2:
					goto IL_F8;
				case 3:
					goto IL_131;
				case 4:
					if (xcmpUnkill.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.SecurityLocked)
					{
						num2 = (short)1834942467;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)173539333;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (xcmpUnkill.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Failure)
					{
						num2 = (short)705167362;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)484704257;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)1999110148;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_22A;
				case 8:
					goto IL_169;
				case 9:
					if (xcmpUnkill.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.OpcodeNotSupported)
					{
						num2 = (short)1403781126;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22F;
				}
				goto IL_38;
				IL_169:
				num2 = (short)1366622217;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F8:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidDerivedKey);
			IL_131:
			goto IL_22F;
			IL_22A:
			num2 = (short)2049835009;
			if (num2 != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UnkillRadioFailure);
			IL_22F:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidModeUnkill);
			IL_38:
			xcmpUnkill = new global::Motorola.Common.Communication.Rcmp.XcmpUnkill(global::Motorola.Common.Communication.Rcmp.UnkillFunction.REQUEST_FOR_UNKILL_RADIO, authenticationValue);
			this.a.SendAndReceiveMessage(xcmpUnkill);
			num2 = (short)1303183360;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00014514 File Offset: 0x00012714
		public byte[] ReadUnkillChallengeValue()
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::Motorola.Common.Communication.Rcmp.XcmpUnkill xcmpUnkill;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (xcmpUnkill.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.SecurityLocked)
					{
						num2 = (short)2132869124;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)191365122;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_128;
				case 2:
					if (xcmpUnkill.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)1751121921;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1E5;
				case 3:
					num2 = (short)1951924229;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_1E0;
				case 5:
					goto IL_177;
				case 6:
				{
					num2 = (short)560318357;
					short num3 = num2;
					num2 = (short)500811669;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_177;
					default:
						num2 = (short)1035862016;
						if (num2 != 0)
						{
						}
						num2 = (short)1535836161;
						if (num2 != 0)
						{
						}
						if (xcmpUnkill.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.IncorrectMode)
						{
							num2 = (short)138215427;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_154;
					}
					break;
				}
				case 7:
					num2 = (short)1701052416;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
				IL_177:
				if (xcmpUnkill.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.OpcodeNotSupported)
				{
					goto IL_154;
				}
				num2 = (short)457441287;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_128:
			num2 = (short)1522728960;
			short num4 = num2;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadUnkillChallengeValueFailure);
			IL_154:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidModeUnkill);
			IL_1E0:
			goto IL_154;
			IL_1E5:
			return xcmpUnkill.Values;
			IL_30:
			xcmpUnkill = new global::Motorola.Common.Communication.Rcmp.XcmpUnkill(global::Motorola.Common.Communication.Rcmp.UnkillFunction.REQUEST_FOR_CHALLENGE_VALUE, null);
			this.a.SendAndReceiveMessage(xcmpUnkill);
			num2 = (short)1949958150;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0001470C File Offset: 0x0001290C
		public void UpdateMACAddress(byte[] macAddress)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.WriteMACAddress, macAddress);
			this.a.SendAndReceiveMessage(rcmpReadWriteSerialNumber);
			if (rcmpReadWriteSerialNumber.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num = (short)1795374575;
				short num2 = num;
				num = (short)1909997039;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1903099905;
					if (num != 0)
					{
					}
					num = (short)412549120;
					short num3 = num;
					num = (short)253558784;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateMACAddressFailure);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000147E0 File Offset: 0x000129E0
		public void UnlockISHPartition(byte partition)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpIshUnlockPartition rcmpIshUnlockPartition = new global::Motorola.Common.Communication.Rcmp.RcmpIshUnlockPartition(partition);
			this.a.SendAndReceiveMessage(rcmpIshUnlockPartition);
			if (rcmpIshUnlockPartition.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num = (short)609059202;
				short num2 = num;
				num = (short)1079476610;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1172242433;
					if (num != 0)
					{
					}
					num = (short)987889664;
					short num3 = num;
					num = (short)1689911296;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SecurityUnlockFailure);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000148B4 File Offset: 0x00012AB4
		public void UpdateProductSerialNumber(byte[] serailNumber)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.WriteProductSerialNumber, serailNumber);
			this.a.SendAndReceiveMessage(rcmpReadWriteSerialNumber);
			if (rcmpReadWriteSerialNumber.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num = (short)204079105;
				if (num != 0)
				{
				}
				num = (short)1908053206;
				short num2 = num;
				num = (short)1367839958;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1300627456;
					short num3 = num;
					num = (short)563347456;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateSerialNumberFailure);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00014988 File Offset: 0x00012B88
		public void UpdateIMEType(byte ime)
		{
			global::Motorola.Common.Communication.XcmpConnectivityTest xcmpConnectivityTest = new global::Motorola.Common.Communication.XcmpConnectivityTest(global::Motorola.Common.Communication.ConnectFunction.FactoryControlHeadConnectivityTest, 2, new byte[]
			{
				byte.MaxValue,
				ime
			});
			this.a.SendAndReceiveMessage(xcmpConnectivityTest);
			if (xcmpConnectivityTest.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num = (short)608751105;
				short num2 = num;
				num = (short)1457769985;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1377173504;
					if (num != 0)
					{
					}
					num = (short)278003712;
					short num3 = num;
					num = (short)1345388545;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateIMETypeFailure);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00014A70 File Offset: 0x00012C70
		public void UpdateDateCode(byte[] datecode, ushort source)
		{
			global::Motorola.Common.Communication.RcmpDatecode rcmpDatecode = new global::Motorola.Common.Communication.RcmpDatecode(1, datecode, source);
			this.a.SendAndReceiveMessage(rcmpDatecode);
			if (rcmpDatecode.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num = (short)24735120;
				short num2 = num;
				num = (short)698576272;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1789788160;
					if (num != 0)
					{
					}
					num = (short)856031232;
					short num3 = num;
					num = (short)1199308801;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDateCodeFailure);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00014B44 File Offset: 0x00012D44
		public void EnterTestMode()
		{
			short num;
			for (;;)
			{
				global::Motorola.Common.Communication.Rcmp.RcmpEnterTestMode rcmpEnterTestMode = new global::Motorola.Common.Communication.Rcmp.RcmpEnterTestMode();
				this.a.SendAndReceiveMessage(rcmpEnterTestMode);
				if (rcmpEnterTestMode.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					break;
				}
				num = (short)151330956;
				short num2 = num;
				num = (short)870326412;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_5B;
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EnterTestModeFailure);
			IL_5B:
			num = (short)1064894464;
			short num3 = num;
			num = (short)363200512;
			if (num != 0)
			{
			}
			num = (short)726597633;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00014C18 File Offset: 0x00012E18
		public void RadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction action)
		{
			short num;
			for (;;)
			{
				global::Motorola.Common.Communication.XcmpRadioUpdateControl xcmpRadioUpdateControl = new global::Motorola.Common.Communication.XcmpRadioUpdateControl(action);
				this.a.SendAndReceiveMessage(xcmpRadioUpdateControl);
				if (xcmpRadioUpdateControl.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					break;
				}
				num = (short)1553720873;
				short num2 = num;
				num = (short)647947817;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_5D;
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateControlFailure);
			IL_5D:
			num = (short)201523200;
			short num3 = num;
			num = (short)593035265;
			if (num != 0)
			{
			}
			num = (short)1493368832;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00014CE8 File Offset: 0x00012EE8
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus QueryPasswordStatus()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			short num2;
			global::Motorola.Common.Communication.Rcmp.XcmpCodeplugPasswordLock xcmpCodeplugPasswordLock;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)358809604;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (xcmpCodeplugPasswordLock.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.OpcodeNotSupported)
					{
						num2 = (short)1006698496;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_C5;
				case 2:
					if (xcmpCodeplugPasswordLock.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)139788291;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A7;
				case 3:
					num2 = (short)799473665;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (xcmpCodeplugPasswordLock.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.SecurityLocked)
					{
						num2 = (short)1246298117;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_19C;
				case 5:
					goto IL_108;
				}
				goto IL_28;
			}
			IL_C5:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.OpcodeNotSupported);
			IL_108:
			num2 = (short)1379205120;
			short num3 = num2;
			num2 = (short)1151205377;
			if (num2 != 0)
			{
			}
			goto IL_C5;
			IL_1A7:
			return new global::Motorola.Common.Communication.CommonUtil.PasswordStatus
			{
				AlgorithmID = xcmpCodeplugPasswordLock.AlgorithmID(),
				Policy = (global::Motorola.Common.Communication.CommonUtil.PasswordPolicy)xcmpCodeplugPasswordLock.Policy(),
				Salt = xcmpCodeplugPasswordLock.Salt(),
				ConfigurationLocked = xcmpCodeplugPasswordLock.ConfigurationLocked(),
				RemainingAttempts = xcmpCodeplugPasswordLock.RemainingAttempts()
			};
			IL_28:
			xcmpCodeplugPasswordLock = new global::Motorola.Common.Communication.Rcmp.XcmpCodeplugPasswordLock(global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.RequestStatus, null);
			this.a.SendAndReceiveMessage(xcmpCodeplugPasswordLock);
			num2 = (short)865826849;
			short num4 = num2;
			num2 = (short)1890088993;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_19C:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryPasswordPolicyFailure);
			default:
			{
				num2 = (short)1664483328;
				if (num2 != 0)
				{
				}
				num2 = (short)1867251714;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00014EE0 File Offset: 0x000130E0
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password)
		{
			global::Motorola.Common.Communication.CommonUtil.PasswordStatus passwordStatus;
			global::Motorola.Common.Communication.Rcmp.XcmpCodeplugPasswordLock xcmpCodeplugPasswordLock;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_61;
				}
				short num;
				int num3;
				for (;;)
				{
					IL_0A:
					num = (short)721944576;
					short num2 = num;
					switch (num3)
					{
					case 0:
						num = (short)1149698055;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						passwordStatus.IsPasswordValidationSuccess = false;
						num = (short)2085683208;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_FB;
					case 3:
						num = (short)550240261;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)2141782017;
						if (num != 0)
						{
						}
						num = (short)2022470483;
						short num4 = num;
						num = (short)1080062803;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)2012151808;
							if (num != 0)
							{
							}
							if (xcmpCodeplugPasswordLock.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.OpcodeNotSupported)
							{
								num = (short)1087963136;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B9;
						}
						break;
					}
					case 5:
						if (xcmpCodeplugPasswordLock.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.BitLocked)
						{
							num = (short)455081985;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)548208644;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (xcmpCodeplugPasswordLock.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1876557827;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						passwordStatus.IsPasswordValidationSuccess = true;
						num = (short)2087321609;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (xcmpCodeplugPasswordLock.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.SecurityLocked)
						{
							num = (short)1466892290;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_182;
					case 8:
						goto IL_11B;
					case 9:
						goto IL_13E;
					}
					break;
				}
				IL_61:
				xcmpCodeplugPasswordLock = new global::Motorola.Common.Communication.Rcmp.XcmpCodeplugPasswordLock(global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.VerifyPassword, password);
				this.a.SendAndReceiveMessage(xcmpCodeplugPasswordLock);
				passwordStatus = new global::Motorola.Common.Communication.CommonUtil.PasswordStatus();
				num = (short)805175302;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			IL_B9:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.OpcodeNotSupported);
			IL_FB:
			goto IL_B9;
			IL_11B:
			IL_13E:
			goto IL_242;
			IL_182:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ValidateLocalPasswordFailure);
			IL_242:
			passwordStatus.RemainingAttempts = xcmpCodeplugPasswordLock.RemainingAttempts();
			return passwordStatus;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0001513C File Offset: 0x0001333C
		public int CodeplugUpdate(global::Motorola.Common.Communication.UpdateControlAction action, out uint Value)
		{
			short num = (short)336486007;
			short num2 = num;
			num = (short)684416631;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1800798208;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1456865281;
			if (num != 0)
			{
			}
			num = (short)972947456;
			if (num != 0)
			{
			}
			Value = 0U;
			int result = 0;
			uint num4 = 255U;
			global::Motorola.Common.Communication.XcmpRadioUpdateControl xcmpRadioUpdateControl = new global::Motorola.Common.Communication.XcmpRadioUpdateControl(action);
			this.a.SendAndReceiveMessage(xcmpRadioUpdateControl);
			if (xcmpRadioUpdateControl.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				num4 = (uint)xcmpRadioUpdateControl.Value;
			}
			Value = num4;
			return result;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00015218 File Offset: 0x00013418
		public void ReadComponentFile(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType compType, ushort compInstance, out uint numberOfFiles, out string filePath)
		{
			global::Motorola.Common.Communication.Rcmp.XcmpComponentRead xcmpComponentRead;
			short num;
			for (;;)
			{
				numberOfFiles = 0U;
				filePath = string.Empty;
				xcmpComponentRead = new global::Motorola.Common.Communication.Rcmp.XcmpComponentRead((ushort)compType, compInstance, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.ReadComponentData, 0);
				this.a.SendAndReceiveMessage(xcmpComponentRead);
				if (xcmpComponentRead.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					break;
				}
				num = (short)160904213;
				short num2 = num;
				num = (short)329724949;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					goto IL_CD;
				}
				goto Block_1;
			}
			num = (short)452263937;
			if (num != 0)
			{
			}
			numberOfFiles = (uint)xcmpComponentRead.NumberOfFiles;
			global::System.Text.Encoding encoding = new global::System.Text.UTF8Encoding(true, true);
			filePath = encoding.GetString(xcmpComponentRead.Information);
			return;
			Block_1:
			num = (short)230031360;
			short num3 = num;
			IL_CD:
			num = (short)2053701632;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentReadFileFailure);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00015314 File Offset: 0x00013514
		public string ReadComponentVersion(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType compType, ushort compInstance)
		{
			global::Motorola.Common.Communication.Rcmp.XcmpComponentRead xcmpComponentRead;
			short num;
			for (;;)
			{
				xcmpComponentRead = new global::Motorola.Common.Communication.Rcmp.XcmpComponentRead((ushort)compType, compInstance, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.GetVersion, 0);
				this.a.SendAndReceiveMessage(xcmpComponentRead);
				if (xcmpComponentRead.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					break;
				}
				num = (short)1696692914;
				short num2 = num;
				num = (short)2059434674;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_71;
				}
			}
			return global::System.Text.Encoding.ASCII.GetString(xcmpComponentRead.Information).TrimEnd(new char[1]);
			IL_71:
			num = (short)710082560;
			short num3 = num;
			num = (short)2023030785;
			if (num != 0)
			{
			}
			num = (short)1854930944;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentReadFileFailure);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00015404 File Offset: 0x00013604
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery> TypeLevelChangeDiscoveryOfTypes(global::System.Collections.Generic.IEnumerable<ushort> ishTypes, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			short num = (short)627230929;
			short num2 = num;
			num = (short)439601361;
			switch (num2 == num)
			{
			default:
			{
				num = (short)996343808;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1467351041;
			if (num != 0)
			{
			}
			num = (short)1436352512;
			if (num != 0)
			{
			}
			uint num4;
			return this.a(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, 2, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.GetTypeChanges, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshTypes, ishTypes, out num4, out radioFilePath, progressIndicator).CodeplugData.TypeCounters;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000154C8 File Offset: 0x000136C8
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery> TypeLevelChangeDiscoveryInPartitions(global::System.Collections.Generic.IEnumerable<ushort> ishPartitions, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			short num = (short)909063254;
			short num2 = num;
			num = (short)527643734;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2080243712;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)212336641;
			if (num != 0)
			{
			}
			num = (short)1686700032;
			if (num != 0)
			{
			}
			uint num4;
			return this.a(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, 2, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.GetTypeChanges, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshPartitions, ishPartitions, out num4, out radioFilePath, progressIndicator).CodeplugData.TypeCounters;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0001558C File Offset: 0x0001378C
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery> ItemLevelChangeDiscoveryInPartitions(global::System.Collections.Generic.IEnumerable<ushort> ishPartitions, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			short num = (short)465889411;
			short num2 = num;
			num = (short)14280835;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1728905216;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1667694593;
			if (num != 0)
			{
			}
			num = (short)752287744;
			if (num != 0)
			{
			}
			uint num4;
			return this.a(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, 2, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.GetItemChanges, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshPartitions, ishPartitions, out num4, out radioFilePath, progressIndicator).CodeplugData.IDCounters;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00015650 File Offset: 0x00013850
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery> ItemLevelChangeDiscovery(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Rcmp.XcmpComponentTypeIdPair> typeIdPairs, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			short num = (short)766786380;
			short num2 = num;
			num = (short)736574284;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1683030016;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1464336385;
			if (num != 0)
			{
			}
			num = (short)1026490368;
			if (num != 0)
			{
			}
			uint num4;
			return this.a(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, 2, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.GetItemChanges, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshTypeIds, typeIdPairs, out num4, out radioFilePath, progressIndicator).CodeplugData.IDCounters;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00015714 File Offset: 0x00013914
		public global::Motorola.Common.Communication.Pba.PbaObject ReadCodeplugItemsInPartitions(global::System.Collections.Generic.IEnumerable<ushort> partitions, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			short num = (short)1256755793;
			short num2 = num;
			num = (short)331780689;
			switch (num2 == num)
			{
			default:
			{
				num = (short)912850944;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1149239297;
			if (num != 0)
			{
			}
			num = (short)336396288;
			if (num != 0)
			{
			}
			uint num4;
			string text;
			return this.a(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, 2, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.ReadComponentData, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshPartitions, partitions, out num4, out text, progressIndicator);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000157D0 File Offset: 0x000139D0
		public global::Motorola.Common.Communication.Pba.PbaObject ReadCodeplugItemsByTypes(global::System.Collections.Generic.IEnumerable<ushort> ishTypes, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			short num = (short)915205315;
			short num2 = num;
			num = (short)2073160899;
			switch (num2 == num)
			{
			default:
			{
				num = (short)707723264;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)506003457;
			if (num != 0)
			{
			}
			num = (short)1688797184;
			if (num != 0)
			{
			}
			uint num4;
			string text;
			return this.a(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, 2, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.ReadComponentData, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshTypes, ishTypes, out num4, out text, progressIndicator);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00015888 File Offset: 0x00013A88
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadItemsByIshHeaders(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaders, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null)
		{
			short num = (short)1435172865;
			if (num != 0)
			{
			}
			num = (short)343605248;
			short num2 = num;
			num = (short)1093892003;
			short num3 = num;
			num = (short)755922851;
			switch (num3 == num)
			{
			}
			num = (short)1495334912;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Rcmp.XcmpComponentTypeIdPair> items = ishHeaders.Select(new global::System.Func<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.Rcmp.XcmpComponentTypeIdPair>(global::Motorola.Common.Communication.IshHandler.IOController.<>c.<>9.a));
			return this.ReadCodeplugItems(items, out radioFilePath, progressIndicator).GetCodeplugInIshItemCollection();
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00015968 File Offset: 0x00013B68
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadDifferetialCodeplugByIshTypes(global::System.Collections.Generic.IEnumerable<ushort> ishTypes, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			short num = (short)1542667870;
			short num2 = num;
			num = (short)898186846;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1518075904;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)458620929;
			if (num != 0)
			{
			}
			num = (short)2123825152;
			if (num != 0)
			{
			}
			uint num4;
			string text;
			return this.a(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, 2, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.ReadDifferentialData, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshTypes, ishTypes, out num4, out text, progressIndicator).GetCodeplugInIshItemCollection();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00015A28 File Offset: 0x00013C28
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadDifferetialCodeplugInPartitions(global::System.Collections.Generic.IEnumerable<ushort> partitions, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			short num = (short)824462303;
			short num2 = num;
			num = (short)2114735071;
			switch (num2 == num)
			{
			default:
			{
				num = (short)914161664;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)619577344;
			if (num != 0)
			{
			}
			num = (short)1466433537;
			if (num != 0)
			{
			}
			uint num4;
			string text;
			return this.a(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, 2, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.ReadDifferentialData, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshPartitions, partitions, out num4, out text, progressIndicator).GetCodeplugInIshItemCollection();
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00015AE4 File Offset: 0x00013CE4
		public global::Motorola.Common.Communication.Pba.PbaObject ReadCodeplugItems(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Rcmp.XcmpComponentTypeIdPair> items, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			short num = (short)696306368;
			short num2 = num;
			num = (short)668912320;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1444085760;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)570425344;
			if (num != 0)
			{
			}
			num = (short)1556152321;
			if (num != 0)
			{
			}
			uint num4;
			return this.a(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, 2, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.ReadComponentData, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshTypeIds, items, out num4, out radioFilePath, progressIndicator);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00015BA0 File Offset: 0x00013DA0
		private global::Motorola.Common.Communication.Pba.PbaObject a(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType A_0, ushort A_1, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level A_2, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure A_3, global::System.Collections.IEnumerable A_4, out uint A_5, out string A_6, global::Motorola.Common.Communication.IProgressIndicator A_7)
		{
			int a_ = 8;
			short num = (short)875692032;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_54;
				}
				string text2;
				byte[] fileData;
				for (;;)
				{
					IL_31:
					string text;
					global::System.IO.MemoryStream memoryStream;
					switch (num2)
					{
					case 0:
						if (!string.IsNullOrEmpty(A_6))
						{
							num = (short)1651113990;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27F;
					case 1:
						text = A_6 + global::Motorola.Common.Communication.IshHandler.Validator.b("麰", a_) + text2;
						goto IL_2A1;
					case 2:
						text = text2;
						goto IL_2A1;
					case 3:
						if (A_5 == 0U)
						{
							num = (short)194772996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F;
					case 4:
						goto IL_11A;
					case 5:
					{
						num = (short)1050476544;
						short num3 = num;
						try
						{
							fileData = memoryStream.ToArray();
							goto IL_330;
						}
						finally
						{
							num = (short)201654272;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_243;
									}
									continue;
								case 1:
									goto IL_27C;
								case 2:
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)128712705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_243:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)981139458;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_27C:;
						}
						goto IL_27F;
					}
					case 6:
						num = (short)1108017153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_54;
					IL_27F:
					num = (short)199884802;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A1:
					string filePath = text;
					ushort filePartition = 0;
					memoryStream = this.FileRead(filePartition, filePath, new global::Motorola.Common.Communication.IteratedProgressIndicator(A_7, 0.9));
					num = (short)2054291457;
					if (num != 0)
					{
					}
					num = (short)1217986565;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11A:
				return new global::Motorola.Common.Communication.Pba.PbaObject();
				IL_11F:
				string[] array = new string[6];
				int num4 = 0;
				ushort num5 = (ushort)A_0;
				array[num4] = num5.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
				array[1] = global::Motorola.Common.Communication.IshHandler.Validator.b("", a_);
				array[2] = A_1.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
				array[3] = global::Motorola.Common.Communication.IshHandler.Validator.b("", a_);
				array[4] = A_5.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
				array[5] = global::Motorola.Common.Communication.IshHandler.Validator.b("龰킲\ud8b4잶", a_);
				text2 = string.Concat(array);
				goto IL_18E;
				IL_330:
				return new global::Motorola.Common.Communication.CommonFile.PartitionCommonFile(this.IsCommonFileCrcBigEndian).Deserialize(fileData);
				IL_54:
				uint listItemLength = global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.GetListItemLength(A_3);
				uint a_2 = (uint)((this.b - global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.RequestHeaderLength) / (int)listItemLength * (int)listItemLength);
				byte[] a_3 = global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ConvertListItemToBytes(A_3, A_4);
				this.a(A_0, A_1, A_2, A_3, a_3, a_2, out A_5, out A_6, new global::Motorola.Common.Communication.IteratedProgressIndicator(A_7, 0.1));
				num = (short)805224943;
				short num6 = num;
				num = (short)899465711;
				switch ((num6 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_18E:
					num = (short)1366425600;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				default:
					num = (short)576716800;
					if (num != 0)
					{
					}
					num = (short)1220083715;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				break;
			}
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00015F00 File Offset: 0x00014100
		private void a(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType A_0, ushort A_1, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level A_2, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure A_3, byte[] A_4, uint A_5, out uint A_6, out string A_7, global::Motorola.Common.Communication.IProgressIndicator A_8)
		{
			short num = (short)1660289024;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_97;
				}
				int num3;
				byte b3;
				int num6;
				for (;;)
				{
					IL_28:
					byte b;
					byte b2;
					global::Motorola.Common.Communication.Rcmp.XcmpComponentRead xcmpComponentRead;
					switch (num2)
					{
					case 0:
						goto IL_190;
					case 1:
						goto IL_271;
					case 2:
						num = (short)792199177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)216989712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)504102924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (A_8 != null)
						{
							num = (short)2098724882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_271;
					case 6:
						if (num3 >= A_4.Length)
						{
							num = (short)1143013400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1467547665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)390266901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						b = 64;
						goto IL_32E;
					case 9:
						b2 = 192;
						goto IL_356;
					case 10:
					{
						if (xcmpComponentRead.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							goto IL_185;
						}
						num = (short)393293937;
						short num4 = num;
						num = (short)108605553;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_310;
						default:
							num = (short)271908864;
							if (num != 0)
							{
							}
							num = (short)733347847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 11:
						goto IL_1D5;
					case 12:
						if (b3 == 0)
						{
							goto IL_310;
						}
						goto IL_37B;
					case 13:
						goto IL_1D5;
					case 14:
						if (num3 != 0)
						{
							num = (short)1856831490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1935015937;
						if (num != 0)
						{
						}
						num = (short)872611865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						num = (short)736034816;
						short num5 = num;
						xcmpComponentRead = new global::Motorola.Common.Communication.Rcmp.XcmpComponentRead((ushort)A_0, A_1, A_2, (byte)(b3 + A_3), (num6 > 0) ? A_4.Skip(num3).Take(num6).ToArray<byte>() : null);
						this.a.SendAndReceiveMessage(xcmpComponentRead);
						num = (short)188088330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (num3 != 0)
						{
							num = (short)880541719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2094137352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if ((long)num3 + (long)((ulong)A_5) < (long)A_4.Length)
						{
							num = (short)717881347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1977221134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						A_8.IncreaseProcess((double)(num6 / A_4.Length));
						num = (short)758644756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_37B;
					case 20:
						goto IL_271;
					case 21:
						if (b3 != 192)
						{
							num = (short)207355908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_190;
					case 22:
						b = 128;
						goto IL_32E;
					case 23:
						num = (short)1885470742;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						return;
					case 25:
						b2 = 0;
						goto IL_356;
					}
					goto IL_97;
					IL_190:
					A_6 = (uint)xcmpComponentRead.NumberOfFiles;
					A_7 = global::System.Text.Encoding.UTF8.GetString(xcmpComponentRead.Information).Trim(new char[1]);
					num = (short)667287571;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D5:
					num = (short)1617887247;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_271:
					num = (short)1491140614;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_310:
					num = (short)1579483136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32E:
					b3 = b;
					num6 = (int)A_5;
					num = (short)2085945355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_356:
					b3 = b2;
					num6 = A_4.Length - num3;
					num = (short)224329741;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37B:
					num3 += num6;
					num = (short)325124101;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_185:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentReadFileFailure);
				IL_97:
				A_6 = 0U;
				A_7 = string.Empty;
				b3 = 64;
				num3 = 0;
				num6 = 0;
				num = (short)672858113;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00016404 File Offset: 0x00014604
		public void ComponentSession(ushort actions, ushort sessionID, out ushort performedActions, out ushort currentSessionId)
		{
			int a_ = 9;
			global::Motorola.Common.Communication.Rcmp.XcmpComponentSession xcmpComponentSession;
			for (;;)
			{
				IL_09:
				short num = (short)327352320;
				int num2 = (int)num;
				switch (num2)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_74;
					}
					for (;;)
					{
						IL_31:
						switch (num2)
						{
						case 0:
						{
							try
							{
								this.a.SendAndReceiveMessage(xcmpComponentSession);
								goto IL_351;
							}
							catch (global::Motorola.Common.CustomException.CommonException ex)
							{
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.IshHandler.Validator.b("첳햵\uddb7쪹좻ힽ꾿곁꧅ꛇ뿋ꯍꏏꇑ뷓맕뛗龎뿛뇝跟迡藣裥賧탩쳫", a_) + ex.Message, global::System.Array.Empty<object>());
								throw;
							}
							catch (global::System.Exception ex2)
							{
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.IshHandler.Validator.b("첳햵\uddb7쪹좻ힽ꾿곁꧅ꛇ뿋ꯍꏏꇑ뷓맕뛗龎뿛뇝跟迡藣裥賧탩쳫", a_) + ex2.Message, global::System.Array.Empty<object>());
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentSessionFailure);
							}
							goto IL_260;
							IL_351:
							ushort num3 = 1056;
							ushort num4 = 1025;
							ushort num5 = 7;
							num = (short)696123396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							if (xcmpComponentSession.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.InvalidParameter)
							{
								num = (short)1621819395;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3A2;
						case 2:
							goto IL_147;
						case 3:
							num = (short)1533280267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (xcmpComponentSession.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
							{
								num = (short)472449037;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CF;
						case 5:
							num = (short)1982726145;
							if (num != 0)
							{
							}
							num = (short)268501004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)1013121034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_260;
						case 8:
							goto IL_34C;
						case 9:
						{
							ushort num4;
							if (actions != num4)
							{
								num = (short)774176773;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_18B;
						}
						case 10:
						{
							num = (short)365007569;
							short num6 = num;
							num = (short)934122193;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
							{
								num = (short)1595867136;
								short num7 = num;
								num = (short)517275648;
								if (num != 0)
								{
								}
								ushort num4;
								if (actions == num4)
								{
									num = (short)1346502664;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_149;
							}
							}
							break;
						}
						case 11:
						{
							ushort num5;
							if (actions != num5)
							{
								num = (short)446955527;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_18B;
						}
						case 12:
						{
							ushort num3;
							if (actions == num3)
							{
								num = (short)1046085634;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3A2;
						}
						case 13:
							num = (short)268828686;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							if (xcmpComponentSession.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Failure)
							{
								num = (short)660340742;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_149;
						}
						break;
						IL_149:
						num = (short)1985019905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_260:
						num = (short)1246035977;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_74:
					xcmpComponentSession = new global::Motorola.Common.Communication.Rcmp.XcmpComponentSession(actions, sessionID);
					num = (short)1262092288;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
			}
			IL_CF:
			performedActions = xcmpComponentSession.CompletedActions;
			currentSessionId = xcmpComponentSession.ReplySessionId;
			this.SessionCommandReply = xcmpComponentSession;
			return;
			IL_147:
			IL_18B:
			performedActions = xcmpComponentSession.CompletedActions;
			currentSessionId = xcmpComponentSession.ReplySessionId;
			this.SessionCommandReply = xcmpComponentSession;
			this.RetryDifferentialWriteNotSupported = true;
			return;
			IL_34C:
			goto IL_CF;
			IL_3A2:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentSessionFailure);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000167DC File Offset: 0x000149DC
		public void ComponentSession(ushort actions, ushort sessionID, ushort previousSessionID, out ushort performedActions, out ushort currentSessionId)
		{
			short num = (short)1311506432;
			short num2 = num;
			num = (short)248053760;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C6;
				}
				ushort num4;
				global::Motorola.Common.Communication.Rcmp.XcmpComponentSession xcmpComponentSession;
				ushort num5;
				ushort num6;
				for (;;)
				{
					IL_51:
					num = (short)1610088449;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						num = (short)176422928;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (actions != num4)
						{
							num = (short)785907718;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_168;
					case 2:
						if (xcmpComponentSession.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)262602766;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)706412559;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1516568577;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (actions == num5)
						{
							num = (short)1344864261;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BD;
					case 5:
						goto IL_205;
					case 6:
						num = (short)1514930183;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (actions == num5)
						{
							num = (short)25886730;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_341;
					case 8:
						if (actions != num6)
						{
							num = (short)735903744;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25D;
					case 9:
						goto IL_1C6;
					case 10:
						goto IL_2B6;
					case 11:
						num = (short)1130561544;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						if (actions == num6)
						{
							goto IL_168;
						}
						num = (short)2003070599;
						short num7 = num;
						num = (short)610430599;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1C6;
						default:
							num = (short)190775296;
							if (num != 0)
							{
							}
							num = (short)879493123;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 13:
						if (xcmpComponentSession.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.BitLocked)
						{
							num = (short)1239023627;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BD;
					case 14:
						goto IL_126;
					case 15:
						if (xcmpComponentSession.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.InvalidParameter)
						{
							num = (short)1544814601;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_341;
					case 16:
						if (actions != num4)
						{
							num = (short)841678865;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25D;
					case 17:
						num = (short)1781071876;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C6;
					IL_1C6:
					num = (short)230031372;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_341:
					num = (short)1636302861;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_126:
				performedActions = xcmpComponentSession.CompletedActions;
				currentSessionId = xcmpComponentSession.ReplySessionId;
				this.SessionCommandReply = xcmpComponentSession;
				return;
				IL_168:
				performedActions = xcmpComponentSession.CompletedActions;
				currentSessionId = xcmpComponentSession.ReplySessionId;
				this.SessionCommandReply = xcmpComponentSession;
				this.RetryDifferentialWriteNotSupported = true;
				return;
				IL_205:
				IL_25D:
				performedActions = xcmpComponentSession.CompletedActions;
				currentSessionId = xcmpComponentSession.ReplySessionId;
				this.SessionCommandReply = xcmpComponentSession;
				this.MisMatchedRadioAndRMSessionId = true;
				return;
				IL_2B6:
				goto IL_168;
				IL_3BD:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentSessionFailure);
				IL_C6:
				xcmpComponentSession = new global::Motorola.Common.Communication.Rcmp.XcmpComponentSession(actions, sessionID, (uint)previousSessionID);
				this.a.SendAndReceiveMessage(xcmpComponentSession);
				num5 = 1056;
				num4 = 1025;
				num6 = 7;
				num = (short)653000706;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00016BB0 File Offset: 0x00014DB0
		public bool StartOtapSession(ushort currentSessionID, ushort previousSessionID, bool isRead)
		{
			int a_ = 10;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num;
			ushort num2;
			short num3;
			global::Motorola.Common.Communication.Rcmp.XcmpComponentSession xcmpComponentSession;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 |= 512;
					num3 = (short)1273954310;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 1:
					if (xcmpComponentSession.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num3 = (short)1105461258;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)943587340;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					if (currentSessionID == previousSessionID)
					{
						num3 = (short)853344263;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_338;
				case 3:
					if (!isRead)
					{
						num3 = (short)981008384;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_191;
				case 4:
					if (xcmpComponentSession.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.BitUnlocked)
					{
						num3 = (short)660013065;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_283;
				case 5:
					goto IL_301;
				case 6:
					goto IL_241;
				case 7:
					goto IL_21F;
				case 8:
					num3 = (short)22020098;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 9:
					num3 = (short)1491402763;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 10:
					goto IL_1E2;
				case 11:
				{
					if (xcmpComponentSession.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Failure)
					{
						goto IL_338;
					}
					num3 = (short)951530837;
					short num4 = num3;
					num3 = (short)419771733;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_241;
					default:
						num3 = (short)1257439232;
						if (num3 != 0)
						{
						}
						num3 = (short)196935688;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				case 12:
					if (xcmpComponentSession.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.BitLocked)
					{
						num3 = (short)1904148485;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1745813508;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				goto IL_4D;
				IL_191:
				xcmpComponentSession = new global::Motorola.Common.Communication.Rcmp.XcmpComponentSession(num2, currentSessionID, (uint)previousSessionID);
				this.a.SendAndReceiveMessage(xcmpComponentSession);
				num3 = (short)1030553601;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_241:
				goto IL_191;
			}
			IL_1E2:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.IshHandler.Validator.b("솴횶쮸쾺鶼뗀ꋂ뗄뫈껊뻌볎룐볒믔꫘껚뻜볞蓠郢雤臦鳨蟪臬雮퇰鋲鯴鏶\ud9f8裺飼賾爀樂樄椆⤈昊氌笎爐笒瀔猖㜘㬚帜樞匠儢䀤䤦崨ପ帬䨮䈰䀲尴堶圸ᬺ吼嬾慀ᡂ㹄睆㑈ᙊ癌潎⅐⅒ご⅖じ㑚⡜ⱞ䅠ၢdᑦᩨɪɬŮ兰ᩲᅴ坶≸z䱼ɾ\udc80궂", a_), new object[]
			{
				currentSessionID,
				previousSessionID
			});
			return true;
			IL_21F:
			IL_283:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.IshHandler.Validator.b("솴횶쮸쾺鶼뗀ꋂ뗄髈껊뻌볎룐볒믔鳘꧚꿜냞鏠췢엤뗦裨迪蓬胮퇰髲蛴ퟶ觸觺鋼鳾搀瀂瘄渆月氊ⴌ渎ㄐ挒朔爖漘爚爜樞删̢唤唦䘨䰪弬丮尰帲尴夶常ᬺ丼娾㉀あⱄ⡆❈歊ⱌⅎ㕐獒❔㉖⩘⭚㉜ㅞበ٢ᙤ䝦㉨ၪ嵬ቮⱰ", a_), new object[]
			{
				xcmpComponentSession.ReplyResult.ToString()
			});
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentSessionBusy);
			IL_301:
			num3 = (short)1509359617;
			if (num3 != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.IshHandler.Validator.b("솴횶쮸쾺鶼뗀ꋂ뗄뫈껊뻌볎룐볒믔꫘껚뻜볞蓠郢雤臦鳨蟪臬雮퇰鋲鯴鏶\ud9f8裺飼賾爀樂樄椆⤈䘊䐌導㰐縒琔挖稘猚砜笞༠̢昤刦嬨太䠬䄮䔰ጲ䘴制䨸䠺吼倾⽀捂ⱄ⍆楈၊㙌罎ⱐ๒湔睖⥘⥚㡜⥞ࡠౢၤᑦ䥨ᡪ࡬ᱮɰᩲᩴ᥶奸ቺ᥼彾\uda80뒄惘품ꖊ", a_), new object[]
			{
				currentSessionID,
				previousSessionID
			});
			return false;
			IL_338:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.IshHandler.Validator.b("솴횶쮸쾺鶼뗀ꋂ뗄髈껊뻌볎룐볒믔鳘꧚꿜냞鏠췢엤뗦裨迪蓬胮퇰臲郴蓶觸铺鏼賾搀瀂┄将爈㬊瀌刎", a_), new object[]
			{
				xcmpComponentSession.ReplyResult.ToString()
			});
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentSessionFailure);
			IL_4D:
			num2 = 7;
			num3 = (short)1687814144;
			short num5 = num3;
			num3 = (short)1284898819;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00016F34 File Offset: 0x00015134
		public void CloseOtapSession(ushort currentSessionID, bool isNomal)
		{
			int a_ = 15;
			global::Motorola.Common.Communication.Rcmp.XcmpComponentSession xcmpComponentSession;
			short num2;
			for (;;)
			{
				IL_09:
				switch (0)
				{
				case 0:
					goto IL_2D;
				}
				int num;
				ushort num3;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						goto IL_139;
					case 1:
						if (xcmpComponentSession.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num2 = (short)357433344;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1B1;
					case 2:
						num3 |= 4;
						num2 = (short)996999172;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (isNomal)
						{
							num2 = (short)843055106;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_A2;
					case 4:
						goto IL_A2;
					}
					break;
					IL_A2:
					num2 = (short)856567369;
					short num4 = num2;
					num2 = (short)1949052489;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_09;
					default:
						num2 = (short)1048182784;
						if (num2 != 0)
						{
						}
						xcmpComponentSession = new global::Motorola.Common.Communication.Rcmp.XcmpComponentSession(num3, currentSessionID);
						this.a.SendAndReceiveMessage(xcmpComponentSession);
						num2 = (short)1521221633;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				IL_2D:
				num3 = 1;
				num2 = (short)525205507;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			IL_139:
			num2 = (short)458752000;
			short num5 = num2;
			num2 = (short)828637185;
			if (num2 != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.IshHandler.Validator.b("﮷횹펻춽ꖿ诃닅꧇뫉鷍뗏ꇑꟓ뿕럗듙ﳛ鯝鋟郡诣铥웧쫩뻫迭铯鯱鯳훵諷鿹迻軽濿氁眃挅笇⨉國甍‏漑䤓", a_), new object[]
			{
				xcmpComponentSession.ReplyResult.ToString()
			});
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentSessionFailure);
			IL_1B1:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.IshHandler.Validator.b("﮷횹펻춽ꖿ诃닅꧇뫉뷍뗏ꇑꟓ뿕럗듙ﳛ럝蓟싡뿣鷥\ud8e7韩뇫컭華蟱音闵鷷觹迻飽痿渁栃缅☇", a_), new object[]
			{
				currentSessionID
			});
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0001711C File Offset: 0x0001531C
		public void CommitOtapSession(ushort currentSessionID)
		{
			int a_ = 8;
			short num = (short)605945856;
			short num2 = num;
			global::Motorola.Common.Communication.Rcmp.XcmpComponentSession xcmpComponentSession = new global::Motorola.Common.Communication.Rcmp.XcmpComponentSession(24, currentSessionID);
			this.a.SendAndReceiveMessage(xcmpComponentSession);
			if (xcmpComponentSession.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				num = (short)1016928484;
				short num3 = num;
				num = (short)258414820;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1954676736;
					if (num != 0)
					{
					}
					break;
				}
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.IshHandler.Validator.b("\udcb2\ud8b4\udab6킸쾺鶼뗀ꋂ뗄髈껊뻌볎룐볒믔鳘꧚꿜냞鏠췢엤뗦裨迪蓬胮퇰臲郴蓶觸铺鏼賾搀瀂┄将爈㬊瀌刎", a_), new object[]
				{
					xcmpComponentSession.ReplyResult.ToString()
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentSessionFailure);
			}
			num = (short)809304065;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.IshHandler.Validator.b("\udcb2\ud8b4\udab6킸쾺鶼뗀ꋂ뗄뫈껊뻌볎룐볒믔냘뿚﷜蓞髠폢飤뫦짨飪飬賮鋰雲蛴蓶鿸軺釼鏾砀ⴂ", a_), new object[]
			{
				currentSessionID
			});
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00017258 File Offset: 0x00015458
		public void CommitWiFiSession(ushort currentSessionID)
		{
			int a_ = 3;
			short num = (short)1996881920;
			short num2 = num;
			global::Motorola.Common.Communication.Rcmp.XcmpComponentSession xcmpComponentSession = new global::Motorola.Common.Communication.Rcmp.XcmpComponentSession(24, currentSessionID);
			xcmpComponentSession.ReadTimeout = 120000;
			this.a.SendAndReceiveMessage(xcmpComponentSession);
			if (xcmpComponentSession.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				num = (short)1110458429;
				short num3 = num;
				num = (short)474562621;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)196083712;
					if (num != 0)
					{
					}
					break;
				}
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.IshHandler.Validator.b("솭\uddaf\udfb1\uddb3습颷햻ꦿ韃ꏅ믇막ꗋꇍ뻏釓ꓕ꫗뗙껛샟냡藣若臧藩쳫鳭闯臱蓳駵雷觹駻跽⃿夁缃㘅甇圉", a_), new object[]
				{
					xcmpComponentSession.ReplyResult.ToString()
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentSessionFailure);
			}
			num = (short)204013569;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.IshHandler.Validator.b("솭\uddaf\udfb1\uddb3습颷햻ꦿ럃ꏅ믇막ꗋꇍ뻏뷓닕臙ꟛ鷟뿡쓣闥鷧觩迫语華臱鋳菵铷雹藻탽", a_), new object[]
			{
				currentSessionID
			});
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000173A0 File Offset: 0x000155A0
		public void CreateArchiveSession(ushort currentSessionID)
		{
			int a_ = 19;
			switch (0)
			{
			case 0:
				goto IL_74;
			}
			short num;
			int num3;
			global::Motorola.Common.Communication.Rcmp.XcmpComponentSession xcmpComponentSession;
			for (;;)
			{
				IL_13:
				num = (short)1813839531;
				short num2 = num;
				num = (short)304086699;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)217513984;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						num = (short)1838678017;
						if (num != 0)
						{
						}
						num = (short)656146433;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (xcmpComponentSession.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.OpcodeNotSupported)
						{
							num = (short)1875378179;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_194;
					case 2:
						goto IL_A3;
					case 3:
						goto IL_18F;
					}
					goto IL_74;
				}
				IL_A3:
				if (xcmpComponentSession.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					goto IL_194;
				}
				num = (short)978518016;
				short num4 = num;
				num = (short)1495793664;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_18F:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.IshHandler.Validator.b("ﾻ첽ꖿꏁ냃ꏅ诉뻋귍룏믑ꋓ돕觙맛귝鏟诡诣裥죧꿩黫鳭鿯胱\udaf3훵꫷鯹飻韽濿∁瘃挅笇稉挋怍挏眑朓㘕䌗愙Ⱋ挝紟", a_), new object[]
			{
				xcmpComponentSession.ReplyResult.ToString()
			});
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentSessionFailure);
			IL_194:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.IshHandler.Validator.b("ﾻ첽ꖿꏁ냃ꏅ诉뻋귍룏믑ꋓ돕꧙맛귝鏟诡诣裥죧菩裫컭꯯觱쓳诵ꗷ\udaf9迻诽揿愁愃甅笇氉礋戍簏欑㨓", a_), new object[]
			{
				currentSessionID
			});
			return;
			IL_74:
			xcmpComponentSession = new global::Motorola.Common.Communication.Rcmp.XcmpComponentSession(1025, currentSessionID);
			this.a.SendAndReceiveMessage(xcmpComponentSession);
			num = (short)873725954;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x04000013 RID: 19
		private global::Motorola.Common.Communication.IMessageExecutor a;

		// Token: 0x04000014 RID: 20
		private int b;

		// Token: 0x04000015 RID: 21
		private global::Motorola.Common.Communication.Rcmp.XcmpComponentSession c;

		// Token: 0x04000016 RID: 22
		private bool d;

		// Token: 0x04000017 RID: 23
		private bool e;

		// Token: 0x04000018 RID: 24
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool f;

		// Token: 0x04000019 RID: 25
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int g;

		// Token: 0x0400001A RID: 26
		private const int h = 20;
	}
}
