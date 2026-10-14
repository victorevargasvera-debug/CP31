using System;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000015 RID: 21
	internal class y : global::Motorola.Common.Communication.IshHandler.IOController
	{
		// Token: 0x060000CE RID: 206 RVA: 0x0001A3A4 File Offset: 0x000185A4
		public y(global::Motorola.Common.Communication.IMessageExecutor A_0, int A_1) : base(A_0, A_1, false)
		{
			this.c = A_0;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0001A3C4 File Offset: 0x000185C4
		private void a(uint A_0, uint A_1)
		{
			global::Motorola.Common.Communication.RcmpEraseFlash rcmpEraseFlash = new global::Motorola.Common.Communication.RcmpEraseFlash(A_0, A_1);
			this.c.SendAndReceiveMessage(rcmpEraseFlash);
			short num;
			if (rcmpEraseFlash.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				num = (short)1765306028;
				short num2 = num;
				num = (short)1324707500;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1456340992;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)1268121600;
			short num3 = num;
			num = (short)475463681;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_EraseFlashFailed);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0001A494 File Offset: 0x00018694
		private void a(uint A_0, ushort A_1, byte[] A_2)
		{
			global::Motorola.Common.Communication.RcmpWriteMemory rcmpWriteMemory = new global::Motorola.Common.Communication.RcmpWriteMemory(A_0, A_1, A_2);
			this.c.SendAndReceiveMessage(rcmpWriteMemory);
			short num;
			if (rcmpWriteMemory.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				num = (short)513369934;
				short num2 = num;
				num = (short)575366990;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1238564865;
					if (num != 0)
					{
					}
					num = (short)1750401024;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)824836096;
			short num3 = num;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_WriteMemoryFailed);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0001A568 File Offset: 0x00018768
		public global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult a(byte A_0, ref byte A_1)
		{
			short num = (short)391561945;
			short num2 = num;
			num = (short)413516505;
			switch (num2 == num)
			{
			}
			num = (short)62521345;
			if (num != 0)
			{
			}
			num = (short)1860370432;
			if (num != 0)
			{
			}
			num = (short)635895808;
			short num3 = num;
			global::Motorola.Common.Communication.XcmpRadioUpdateControl xcmpRadioUpdateControl = new global::Motorola.Common.Communication.XcmpRadioUpdateControl((global::Motorola.Common.Communication.UpdateControlAction)A_0);
			this.c.SendAndReceiveMessage(xcmpRadioUpdateControl);
			A_1 = xcmpRadioUpdateControl.Value;
			return (global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult)xcmpRadioUpdateControl.ReplyResult;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0001A630 File Offset: 0x00018830
		private global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult a(byte A_0, byte A_1, ref byte A_2)
		{
			short num = (short)887554049;
			if (num != 0)
			{
			}
			num = (short)1448719090;
			short num2 = num;
			num = (short)1222554354;
			switch (num2 == num)
			{
			}
			num = (short)1612513280;
			if (num != 0)
			{
			}
			num = (short)1492516864;
			short num3 = num;
			global::Motorola.Common.Communication.XcmpRadioUpdateControl xcmpRadioUpdateControl = new global::Motorola.Common.Communication.XcmpRadioUpdateControl((global::Motorola.Common.Communication.UpdateControlAction)A_0, A_1);
			this.c.SendAndReceiveMessage(xcmpRadioUpdateControl);
			A_2 = xcmpRadioUpdateControl.Value;
			return (global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult)xcmpRadioUpdateControl.ReplyResult;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0001A6FC File Offset: 0x000188FC
		public global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult a(string A_0, string A_1, uint A_2)
		{
			short num;
			int num3;
			string text;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					num = (short)1435566080;
					short num2 = num;
					switch (num3)
					{
					case 0:
						text = A_0;
						num = (short)360382466;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (A_2 != 2U)
						{
							goto IL_109;
						}
						num = (short)2104148375;
						short num4 = num;
						num = (short)1006879127;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6F;
						default:
							num = (short)1666908160;
							if (num != 0)
							{
							}
							num = (short)1262485504;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_107;
					}
					goto IL_44;
				}
				IL_107:
				IL_109:
				global::Motorola.Common.Communication.XcmpPsdtAccess xcmpPsdtAccess = new global::Motorola.Common.Communication.XcmpPsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction.Unlock, text, text);
				this.c.SendAndReceiveMessage(xcmpPsdtAccess);
				return (global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult)xcmpPsdtAccess.ReplyResult;
			}
			}
			IL_44:
			num = (short)953483265;
			if (num != 0)
			{
			}
			text = A_1;
			IL_6F:
			num = (short)1751711745;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0001A830 File Offset: 0x00018A30
		public global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult b(string A_0, string A_1, uint A_2)
		{
			short num = (short)391839744;
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
						psdtSrcSectionId = A_1;
						text = A_0;
						num = (short)1059389441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_133;
					case 2:
						return sequenceManagerResult;
					case 3:
						if (sequenceManagerResult == global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
						{
							num = (short)385941509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return sequenceManagerResult;
					case 4:
					{
						num = (short)343315407;
						short num3 = num;
						num = (short)1479250895;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return sequenceManagerResult;
						case 1:
							break;
						default:
						{
							num = (short)1899102208;
							short num4 = num;
							break;
						}
						}
						num = (short)1202913280;
						if (num != 0)
						{
						}
						if (A_2 == 2U)
						{
							num = (short)571736064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_133;
					}
					case 5:
					{
						num = (short)2109800449;
						if (num != 0)
						{
						}
						global::Motorola.Common.Communication.XcmpPsdtAccess xcmpPsdtAccess = new global::Motorola.Common.Communication.XcmpPsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction.Copy, psdtSrcSectionId, text);
						this.c.SendAndReceiveMessage(xcmpPsdtAccess);
						sequenceManagerResult = (global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult)xcmpPsdtAccess.ReplyResult;
						num = (short)650117122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_47;
					IL_133:
					global::Motorola.Common.Communication.XcmpPsdtAccess xcmpPsdtAccess2 = new global::Motorola.Common.Communication.XcmpPsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction.Erase, text, text);
					this.c.SendAndReceiveMessage(xcmpPsdtAccess2);
					sequenceManagerResult = (global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult)xcmpPsdtAccess2.ReplyResult;
					num = (short)1558052867;
					num2 = (int)((global::System.IntPtr)num);
				}
				return sequenceManagerResult;
				IL_47:
				sequenceManagerResult = global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success;
				psdtSrcSectionId = A_0;
				text = A_1;
				num = (short)1603272708;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0001AA10 File Offset: 0x00018C10
		public void a(global::Motorola.Common.Communication.y.a A_0)
		{
			short num = (short)1990131712;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9E;
				}
				byte b;
				global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult sequenceManagerResult;
				int num5;
				byte a_2;
				for (;;)
				{
					IL_29:
					num = (short)888012800;
					short num3 = num;
					switch (num2)
					{
					case 0:
					{
						num = (short)496634666;
						short num4 = num;
						num = (short)1314327338;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1B8;
						default:
							goto IL_135;
						}
						break;
					}
					case 1:
						if (b == 100)
						{
							num = (short)2108489734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D3;
					case 2:
						num = (short)1697382401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (sequenceManagerResult == global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
						{
							goto IL_1B8;
						}
						return;
					case 4:
						num = (short)1860894728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)106889227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_258;
					case 7:
						goto IL_25D;
					case 8:
						num = (short)1648099329;
						if (num != 0)
						{
						}
						if (A_0 != null)
						{
							num = (short)642056205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25D;
					case 9:
						if (sequenceManagerResult == global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
						{
							num = (short)1791229957;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C7;
					case 10:
						goto IL_C7;
					case 11:
						if (b != 100)
						{
							num = (short)1824653316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C7;
					case 12:
						goto IL_1D3;
					case 13:
					{
						double a_ = (double)b;
						A_0(a_);
						num = (short)747831303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_29D;
					case 15:
						if (sequenceManagerResult != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
						{
							num = (short)1843003392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)686161923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (num5 > 500)
						{
							num = (short)311361550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Threading.Thread.Sleep(1000);
						num = (short)15466506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9E;
					IL_C7:
					num = (short)1588330511;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B8:
					num = (short)2021523458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D3:
					sequenceManagerResult = this.a(a_2, ref b);
					num = (short)873398281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25D:
					num5++;
					num = (short)1789329424;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_135:
				num = (short)725680128;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_BackgroundEraserPollFailed);
				IL_258:
				return;
				IL_29D:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_BackgroundEraseTimeout);
				IL_9E:
				sequenceManagerResult = global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Undefined;
				a_2 = 3;
				b = 0;
				num5 = 0;
				num = (short)893386764;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0001AD74 File Offset: 0x00018F74
		public byte a(byte A_0)
		{
			byte result = 0;
			short num;
			if (this.a(A_0, ref result) == global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
			{
				num = (short)473576619;
				short num2 = num;
				num = (short)849228971;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1178730496;
					if (num != 0)
					{
					}
					return result;
				}
			}
			num = (short)1379008512;
			short num3 = num;
			num = (short)309592065;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_GetActivePartitionFailed);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0001AE38 File Offset: 0x00019038
		public global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult a()
		{
			short num = (short)954073200;
			short num2 = num;
			num = (short)2082996336;
			switch (num2 == num)
			{
			}
			num = (short)1295908865;
			if (num != 0)
			{
			}
			num = (short)627572736;
			if (num != 0)
			{
			}
			num = (short)1689780224;
			short num3 = num;
			byte a_ = 11;
			byte a_2 = 1;
			byte b = 0;
			return this.a(a_, a_2, ref b);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0001AEF4 File Offset: 0x000190F4
		public void a(string A_0, bool A_1, int A_2, global::Motorola.Common.Communication.y.a A_3)
		{
			short num = (short)727187456;
			switch (num)
			{
			default:
			{
				num = (short)879689729;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.Common.Communication.Srecord srecord;
					int num7;
					switch (num2)
					{
					case 0:
						goto IL_C0;
					case 1:
					{
						num = (short)1436024833;
						if (num != 0)
						{
						}
						num = (short)2011234304;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_A0;
						}
						continue;
					}
					case 2:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_11A;
							}
							for (;;)
							{
								IL_CF:
								uint num4;
								global::Motorola.Common.Communication.SrecData srecData;
								byte[] array;
								int num5;
								switch (num2)
								{
								case 0:
									goto IL_1B4;
								case 1:
									goto IL_36A;
								case 2:
									if (num4 == srecord.AddressLow)
									{
										num = (short)1463549961;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(num4, (ushort)srecData.DataLen, srecData.GetData());
									num = (short)1832583179;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									this.a(srecord.AddressLow, 4, array);
									num = (short)1378091015;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									if (num5 < srecord.DataRecords.Count)
									{
										srecData = srecord.DataRecords[num5];
										num = (short)1705967621;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)558810751;
									short num6 = num;
									num = (short)1854981759;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_36A;
									default:
										num = (short)306053120;
										if (num != 0)
										{
										}
										num = (short)769261571;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									if (srecData.Type == global::Motorola.Common.Communication.SrecType.S3)
									{
										num = (short)631242753;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2E4;
								case 6:
									goto IL_1B4;
								case 7:
									goto IL_432;
								case 8:
									A_3((double)num7 / (double)srecord.MaxDataSize);
									num = (short)1369112586;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									byte[] data = srecData.GetData();
									global::System.Array.Copy(data, array, array.Length);
									byte[] array2 = new byte[srecData.DataLen - 4U];
									global::System.Array.Copy(data, 4L, array2, 0L, (long)((ulong)(srecData.DataLen - 4U)));
									this.a(num4 + 4U, (ushort)array2.Length, array2);
									num = (short)344522768;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_245;
								case 11:
									goto IL_2E4;
								case 12:
									if (!A_1)
									{
										num = (short)278593551;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_159;
								case 13:
									goto IL_159;
								case 14:
									if (A_3 != null)
									{
										num = (short)186581000;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_245;
								case 15:
									this.a(srecord.AddressLow, srecord.AddressHigh);
									num = (short)464453645;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									goto IL_2E4;
								}
								goto IL_11A;
								IL_159:
								array = new byte[4];
								num5 = 0;
								num = (short)301203456;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1B4:
								num = (short)1033437188;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_245:
								num4 = global::System.Convert.ToUInt32(srecData.Address);
								num = (short)751173634;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2E4:
								num5++;
								num = (short)1363869702;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_36A:
								num7 += (int)srecData.DataLen;
								num = (short)360579086;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_432:
							return;
							IL_11A:
							srecord.LoadData(A_0, A_2, true);
							num = (short)1929314316;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_CF;
						}
						finally
						{
							num = (short)799735809;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									((global::System.IDisposable)srecord).Dispose();
									num = (short)537722882;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_46A;
									}
									continue;
								case 2:
									goto IL_4A1;
								}
								IL_46A:
								if (srecord == null)
								{
									break;
								}
								num = (short)1429864448;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4A1:;
						}
						goto IL_4A4;
					}
					IL_A0:
					if (string.IsNullOrEmpty(A_0))
					{
						num = (short)2007695360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_4A4:
					num7 = 0;
					srecord = new global::Motorola.Common.Communication.Srecord();
					num = (short)877199362;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C0:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			}
		}

		// Token: 0x04000096 RID: 150
		private const int a = 1;

		// Token: 0x04000097 RID: 151
		private const int b = 2;

		// Token: 0x04000098 RID: 152
		private global::Motorola.Common.Communication.IMessageExecutor c;

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x060000DA RID: 218
		public delegate void a(double A_0);
	}
}
