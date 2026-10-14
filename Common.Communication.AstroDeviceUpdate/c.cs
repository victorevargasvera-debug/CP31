using System;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000D RID: 13
	internal class c : global::Motorola.Common.Communication.IshHandler.IOController
	{
		// Token: 0x0600006F RID: 111 RVA: 0x0000CDA8 File Offset: 0x0000AFA8
		public c(global::Motorola.Common.Communication.IMessageExecutor A_0, int A_1) : base(A_0, A_1, false)
		{
			this.c = A_0;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		private void a(uint A_0, uint A_1)
		{
			short num = (short)1059848192;
			short num2 = num;
			num = (short)586900334;
			short num3 = num;
			num = (short)838624110;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1119289344;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.RcmpEraseFlash rcmpEraseFlash = new global::Motorola.Common.Communication.RcmpEraseFlash(A_0, A_1);
				this.c.SendAndReceiveMessage(rcmpEraseFlash);
				if (rcmpEraseFlash.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					num = (short)2051145729;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_EraseFlashFailed);
				}
				break;
			}
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000CE98 File Offset: 0x0000B098
		private void a(uint A_0, ushort A_1, byte[] A_2)
		{
			short num = (short)707788800;
			short num2 = num;
			num = (short)1402610616;
			short num3 = num;
			num = (short)1131029432;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)862650369;
				if (num != 0)
				{
				}
				num = (short)1505361920;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.RcmpWriteMemory rcmpWriteMemory = new global::Motorola.Common.Communication.RcmpWriteMemory(A_0, A_1, A_2);
				this.c.SendAndReceiveMessage(rcmpWriteMemory);
				if (rcmpWriteMemory.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_WriteMemoryFailed);
				}
				break;
			}
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000CF6C File Offset: 0x0000B16C
		public global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult a(byte A_0, ref byte A_1)
		{
			short num = (short)217186304;
			short num2 = num;
			num = (short)2118789353;
			short num3 = num;
			num = (short)519645417;
			switch (num3 == num)
			{
			}
			num = (short)1850146816;
			if (num != 0)
			{
			}
			num = (short)855965697;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.XcmpRadioUpdateControl xcmpRadioUpdateControl = new global::Motorola.Common.Communication.XcmpRadioUpdateControl((global::Motorola.Common.Communication.UpdateControlAction)A_0);
			this.c.SendAndReceiveMessage(xcmpRadioUpdateControl);
			A_1 = xcmpRadioUpdateControl.Value;
			return (global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult)xcmpRadioUpdateControl.ReplyResult;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000D034 File Offset: 0x0000B234
		private global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult a(byte A_0, byte A_1, ref byte A_2)
		{
			short num = (short)198508544;
			short num2 = num;
			num = (short)2007433217;
			if (num != 0)
			{
			}
			num = (short)696774338;
			short num3 = num;
			num = (short)918220482;
			switch (num3 == num)
			{
			}
			num = (short)877723648;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.XcmpRadioUpdateControl xcmpRadioUpdateControl = new global::Motorola.Common.Communication.XcmpRadioUpdateControl((global::Motorola.Common.Communication.UpdateControlAction)A_0, A_1);
			this.c.SendAndReceiveMessage(xcmpRadioUpdateControl);
			A_2 = xcmpRadioUpdateControl.Value;
			return (global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult)xcmpRadioUpdateControl.ReplyResult;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000D0FC File Offset: 0x0000B2FC
		public global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult a(string A_0, string A_1, uint A_2)
		{
			string text;
			for (;;)
			{
				short num = (short)1584857088;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				for (;;)
				{
					IL_35:
					int num3;
					switch (num3)
					{
					case 0:
						if (A_2 == 2U)
						{
							num = (short)1141964801;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10D;
					case 1:
						text = A_0;
						num = (short)2138308610;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_10B;
					}
					break;
				}
				IL_47:
				text = A_1;
				num = (short)1026369170;
				short num4 = num;
				num = (short)1696999058;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1909653505;
					if (num != 0)
					{
					}
					num = (short)347668480;
					if (num != 0)
					{
					}
					num = (short)405929984;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_35;
				}
				}
			}
			IL_10B:
			IL_10D:
			global::Motorola.Common.Communication.XcmpPsdtAccess xcmpPsdtAccess = new global::Motorola.Common.Communication.XcmpPsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction.Unlock, text, text);
			this.c.SendAndReceiveMessage(xcmpPsdtAccess);
			return (global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult)xcmpPsdtAccess.ReplyResult;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000D234 File Offset: 0x0000B434
		public global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult b(string A_0, string A_1, uint A_2)
		{
			short num = (short)1379598336;
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
				string psdtSrcSectionId;
				string text;
				global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult sequenceManagerResult;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (A_2 == 2U)
						{
							num = (short)1926889473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15B;
					case 1:
					{
						num = (short)1824325632;
						short num3 = num;
						psdtSrcSectionId = A_1;
						text = A_0;
						num = (short)343080962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_15B;
					case 3:
					{
						num = (short)1322795086;
						short num4 = num;
						num = (short)1550794830;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AF;
						default:
							goto IL_11B;
						}
						break;
					}
					case 4:
						if (sequenceManagerResult == global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
						{
							num = (short)968359941;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return sequenceManagerResult;
					case 5:
						goto IL_AF;
					}
					goto IL_47;
					IL_AF:
					global::Motorola.Common.Communication.XcmpPsdtAccess xcmpPsdtAccess = new global::Motorola.Common.Communication.XcmpPsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction.Copy, psdtSrcSectionId, text);
					this.c.SendAndReceiveMessage(xcmpPsdtAccess);
					sequenceManagerResult = (global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult)xcmpPsdtAccess.ReplyResult;
					num = (short)1641676803;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15B:
					global::Motorola.Common.Communication.XcmpPsdtAccess xcmpPsdtAccess2 = new global::Motorola.Common.Communication.XcmpPsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction.Erase, text, text);
					this.c.SendAndReceiveMessage(xcmpPsdtAccess2);
					sequenceManagerResult = (global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult)xcmpPsdtAccess2.ReplyResult;
					num = (short)1503526916;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11B:
				num = (short)40632320;
				if (num != 0)
				{
				}
				num = (short)1919877121;
				if (num != 0)
				{
				}
				return sequenceManagerResult;
				IL_47:
				sequenceManagerResult = global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success;
				psdtSrcSectionId = A_0;
				text = A_1;
				num = (short)1955921920;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000D410 File Offset: 0x0000B610
		public void a(global::Motorola.Common.Communication.c.a A_0)
		{
			short num = (short)1762394112;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_73;
				}
				global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult sequenceManagerResult;
				byte b;
				int num3;
				byte a_2;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (sequenceManagerResult == global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
						{
							num = (short)1801388038;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_152;
					case 2:
						num = (short)1044054026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)872349705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						double a_ = (double)b;
						A_0(a_);
						num = (short)1255407629;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (sequenceManagerResult != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
						{
							num = (short)1007091719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1566113792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)148963339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_CE;
					case 8:
						if (sequenceManagerResult == global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
						{
							num = (short)1304100867;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A;
					case 9:
						if (b != 100)
						{
							num = (short)50266114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A;
					case 10:
						if (A_0 != null)
						{
							num = (short)757923844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_208;
					case 11:
						if (b == 100)
						{
							num = (short)1510408207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_152;
					case 12:
						if (num3 > 500)
						{
							num = (short)2100887568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Threading.Thread.Sleep(1000);
						goto IL_2BA;
					case 13:
					{
						num = (short)2129920107;
						short num4 = num;
						num = (short)563609707;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2BA;
						default:
							num = (short)1825374208;
							if (num != 0)
							{
							}
							goto IL_208;
						}
						break;
					}
					case 14:
						goto IL_9A;
					case 15:
						goto IL_203;
					case 16:
						goto IL_24A;
					}
					goto IL_73;
					IL_9A:
					num = (short)288096261;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_152:
					sequenceManagerResult = this.a(a_2, ref b);
					num = (short)818544641;
					if (num != 0)
					{
					}
					num = (short)810680328;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_208:
					num3++;
					num = (short)2119237644;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BA:
					num = (short)641728526;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CE:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_BackgroundEraserPollFailed);
				IL_203:
				return;
				IL_24A:
				num = (short)1982267392;
				short num5 = num;
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_BackgroundEraseTimeout);
				IL_73:
				sequenceManagerResult = global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Undefined;
				a_2 = 3;
				b = 0;
				num3 = 0;
				num = (short)21626881;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000D76C File Offset: 0x0000B96C
		public byte a(byte A_0)
		{
			short num = (short)1241382912;
			short num2 = num;
			num = (short)1446710022;
			short num3 = num;
			num = (short)1670974214;
			byte result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)894828545;
				if (num != 0)
				{
				}
				num = (short)1046609920;
				if (num != 0)
				{
				}
				result = 0;
				if (this.a(A_0, ref result) != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_GetActivePartitionFailed);
				}
				break;
			}
			return result;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000D830 File Offset: 0x0000BA30
		public global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult a()
		{
			short num = (short)628555776;
			short num2 = num;
			num = (short)1477672238;
			short num3 = num;
			num = (short)1226669358;
			switch (num3 == num)
			{
			}
			num = (short)785317889;
			if (num != 0)
			{
			}
			num = (short)1488191488;
			if (num != 0)
			{
			}
			byte a_ = 11;
			byte a_2 = 1;
			byte b = 0;
			return this.a(a_, a_2, ref b);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000D8EC File Offset: 0x0000BAEC
		public void a(string A_0, bool A_1, int A_2, global::Motorola.Common.Communication.c.a A_3)
		{
			short num = (short)1280837044;
			short num2 = num;
			num = (short)1582368180;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_A6:
				switch (0)
				{
				case 0:
					goto IL_ED;
				}
				break;
			default:
				num = (short)1242628097;
				if (num != 0)
				{
				}
				num = (short)1688666112;
				if (num != 0)
				{
				}
				num = (short)1327300608;
				num3 = (int)num;
				switch (num3)
				{
				default:
					num = (short)1420951552;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				break;
			}
			IL_B0:
			num = (short)1216020480;
			short num4 = num;
			global::Motorola.Common.Communication.Srecord srecord;
			int num7;
			switch (num3)
			{
			case 0:
				goto IL_A6;
			case 1:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			case 2:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_169;
					}
					for (;;)
					{
						IL_11E:
						byte[] array;
						int num5;
						global::Motorola.Common.Communication.SrecData srecData;
						uint num6;
						switch (num3)
						{
						case 0:
							this.a(srecord.AddressLow, 4, array);
							num = (short)1897529357;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (!A_1)
							{
								num = (short)1585184773;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A8;
						case 2:
							if (num5 >= srecord.DataRecords.Count)
							{
								num = (short)1098842112;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							srecData = srecord.DataRecords[num5];
							num = (short)1802043395;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (srecData.Type == global::Motorola.Common.Communication.SrecType.S3)
							{
								num = (short)1333919755;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F0;
						case 4:
							goto IL_1A8;
						case 5:
							this.a(srecord.AddressLow, srecord.AddressHigh);
							num = (short)1301151748;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (num6 == srecord.AddressLow)
							{
								num = (short)2120941576;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.a(num6, (ushort)srecData.DataLen, srecData.GetData());
							num = (short)1386807305;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_205;
						case 8:
						{
							byte[] data = srecData.GetData();
							global::System.Array.Copy(data, array, array.Length);
							byte[] array2 = new byte[srecData.DataLen - 4U];
							global::System.Array.Copy(data, 4L, array2, 0L, (long)((ulong)(srecData.DataLen - 4U)));
							this.a(num6 + 4U, (ushort)array2.Length, array2);
							num = (short)1966145548;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							goto IL_2F0;
						case 10:
							A_3((double)num7 / (double)srecord.MaxDataSize);
							num = (short)1454571534;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							num7 += (int)srecData.DataLen;
							num = (short)349896720;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_2F0;
						case 13:
							goto IL_43F;
						case 14:
							goto IL_24E;
						case 15:
							goto IL_205;
						case 16:
							if (A_3 != null)
							{
								num = (short)2059468810;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_24E;
						}
						goto IL_169;
						IL_1A8:
						array = new byte[4];
						num5 = 0;
						num = (short)121438215;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_205:
						num = (short)1595473922;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_24E:
						num6 = global::System.Convert.ToUInt32(srecData.Address);
						num = (short)1129054214;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2F0:
						num5++;
						num = (short)1607663631;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_43F:
					return;
					IL_169:
					srecord.LoadData(A_0, A_2, true);
					num = (short)931594241;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_11E;
				}
				finally
				{
					num = (short)4849664;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_476;
							}
							continue;
						case 1:
							((global::System.IDisposable)srecord).Dispose();
							num = (short)306118658;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_4AC;
						}
						IL_476:
						if (srecord == null)
						{
							break;
						}
						num = (short)1140850689;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_4AC:;
				}
				goto IL_4AF;
			}
			IL_ED:
			if (string.IsNullOrEmpty(A_0))
			{
				num = (short)724893697;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_B0;
			}
			IL_4AF:
			num7 = 0;
			srecord = new global::Motorola.Common.Communication.Srecord();
			num = (short)1613561858;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_B0;
		}

		// Token: 0x0400004F RID: 79
		private const int a = 1;

		// Token: 0x04000050 RID: 80
		private const int b = 2;

		// Token: 0x04000051 RID: 81
		private global::Motorola.Common.Communication.IMessageExecutor c;

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x0600007B RID: 123
		public delegate void a(double A_0);
	}
}
