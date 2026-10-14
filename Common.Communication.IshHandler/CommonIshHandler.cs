using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x02000003 RID: 3
	public class CommonIshHandler
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002124 File Offset: 0x00000324
		public CommonIshHandler(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, int maxPacketSize)
		{
			if (rcmpWrapper == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (maxPacketSize <= 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			this.a = rcmpWrapper;
			this.b = maxPacketSize;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002160 File Offset: 0x00000360
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002210 File Offset: 0x00000410
		public int MaxPacketSize
		{
			get
			{
				short num = (short)1317716906;
				short num2 = num;
				num = (short)927908778;
				switch (num2 == num)
				{
				}
				num = (short)698351616;
				short num3 = num;
				num = (short)1950941184;
				if (num != 0)
				{
				}
				num = (short)2131689473;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)671328364;
				short num2 = num;
				num = (short)1079421036;
				switch (num2 == num)
				{
				}
				num = (short)380895232;
				short num3 = num;
				num = (short)2012413953;
				if (num != 0)
				{
				}
				num = (short)630980608;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022C0 File Offset: 0x000004C0
		public void DeleteIshItem(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaderList, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			short num;
			for (;;)
			{
				num = (short)1230438400;
				switch (num)
				{
				default:
				{
					num = (short)1839572640;
					short num2 = num;
					num = (short)1111533216;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_54;
					}
					break;
				}
				}
			}
			IL_54:
			num = (short)2096431104;
			short num3 = num;
			num = (short)544473088;
			if (num != 0)
			{
			}
			ishHeaderList.Sort();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>();
			global::Motorola.Common.Communication.Rcmp.RcmpDeleteIshIDs rcmpDeleteIshIDs = null;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>.Enumerator enumerator = ishHeaderList.GetEnumerator();
			try
			{
				num = (short)1148977162;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader;
					switch (num4)
					{
					case 1:
						if (rcmpDeleteIshIDs.IshType == ishHeader.IshType)
						{
							num = (short)701890565;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C3;
					case 2:
						num = (short)354549768;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!enumerator.MoveNext())
						{
							num = (short)1346502658;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						ishHeader = enumerator.Current;
						num = (short)1094320135;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)462684166;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (rcmpDeleteIshIDs.EndID + 1 == ishHeader.IshID)
						{
							num = (short)1471414283;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C3;
					case 7:
						if (rcmpDeleteIshIDs != null)
						{
							num = (short)9043977;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C3;
					case 8:
						goto IL_297;
					case 9:
						num = (short)789250049;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_FF;
						}
						continue;
					case 11:
						rcmpDeleteIshIDs.EndID = ishHeader.IshID;
						num = (short)1897791492;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_143:
					num = (short)1493434371;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_FF:
					goto IL_143;
					IL_1C3:
					rcmpDeleteIshIDs = new global::Motorola.Common.Communication.Rcmp.RcmpDeleteIshIDs(ishHeader.PartitionNumber, ishHeader.IshType, ishHeader.IshID, ishHeader.IshID);
					list.Add(rcmpDeleteIshIDs);
					num = (short)686620672;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_297:;
			}
			finally
			{
				num = (short)1787428865;
				if (num != 0)
				{
				}
				((global::System.IDisposable)enumerator).Dispose();
			}
			this.BundleSendMessages(list, progressIndicator);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000025C0 File Offset: 0x000007C0
		public void WriteIshItems(global::Motorola.Common.Communication.CommonUtil.IshItemCollection writeItems, global::Motorola.Common.Communication.IProgressIndicator progressIndicator, bool WriteToDual = false)
		{
			short num = (short)279169850;
			short num2 = num;
			num = (short)1520356154;
			switch (num2 == num)
			{
			}
			num = (short)1699217408;
			short num3 = num;
			num = (short)1132003329;
			if (num != 0)
			{
			}
			num = (short)727973888;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> rcmpMessages = this.a(writeItems, WriteToDual);
			this.BundleSendMessages(rcmpMessages, progressIndicator);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002678 File Offset: 0x00000878
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> a(global::Motorola.Common.Communication.CommonUtil.IshItemCollection A_0, bool A_1)
		{
			short num = (short)618725376;
			switch (num)
			{
			default:
			{
				num = (short)1347944448;
				short num2 = num;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>(A_0.Count);
				ushort num3 = (ushort)(this.b - (2 + global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle.HeaderSize) - (2 + global::Motorola.Common.Communication.Rcmp.RcmpWriteIshItem.HeaderSize));
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = A_0.GetEnumerator();
				try
				{
					num = (short)1201537036;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.Common.Communication.CommonUtil.IshItem value;
						ushort num5;
						ushort num7;
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
						switch (num4)
						{
						case 1:
							if (value.Data.Length == 0)
							{
								num = (short)1770651650;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num5 = 0;
							num = (short)1243283462;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_11B;
						case 3:
						{
							num = (short)1057415740;
							short num6 = num;
							num = (short)66380348;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_239;
							default:
								num = (short)2028732416;
								if (num != 0)
								{
								}
								if (num7 >= num3)
								{
									num = (short)692387853;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_120;
							}
							break;
						}
						case 4:
							num = (short)1873936394;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (value.ItemSize > 0)
							{
								goto IL_239;
							}
							goto IL_2D5;
						case 6:
							goto IL_2DC;
						case 7:
						{
							int num8 = (int)num5;
							value = keyValuePair.Value;
							if (num8 >= value.ItemSize)
							{
								num = (short)1600847872;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2DC;
						}
						case 8:
							if (!enumerator.MoveNext())
							{
								num = (short)1080164356;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							keyValuePair = enumerator.Current;
							value = keyValuePair.Value;
							global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(value.Data, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
							value = keyValuePair.Value;
							num = (short)2030960645;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							value = keyValuePair.Value;
							num = (short)406913025;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_394;
						case 11:
							goto IL_120;
						case 12:
							switch (0)
							{
							case 0:
								goto IL_D2;
							}
							continue;
						case 13:
							num7 = num3;
							num = (short)1306787851;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D2;
						IL_120:
						byte[] array = new byte[(int)num7];
						value = keyValuePair.Value;
						global::System.Buffer.BlockCopy(value.Data, (int)num5, array, 0, (int)num7);
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> list2 = list;
						byte partitionNumber = keyValuePair.Key.PartitionNumber;
						ushort ishType = keyValuePair.Key.IshType;
						ushort ishID = keyValuePair.Key.IshID;
						ushort numberOfBytes = num7;
						ushort offset = num5;
						value = keyValuePair.Value;
						list2.Add(new global::Motorola.Common.Communication.Rcmp.RcmpWriteIshItem(partitionNumber, ishType, ishID, numberOfBytes, offset, (ushort)value.ItemSize, array, A_1));
						num5 += num7;
						num = (short)1126498311;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_239:
						num = (short)992608265;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_278:
						num = (short)1917190152;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_D2:
						goto IL_278;
						IL_2DC:
						value = keyValuePair.Value;
						num7 = (ushort)(value.ItemSize - (int)num5);
						num = (short)232980483;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_11B:
					IL_2D5:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
					IL_394:;
				}
				finally
				{
					num = (short)427425793;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							num = (short)1093206017;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							num = (short)962920450;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_3CB;
							}
							continue;
						case 2:
							goto IL_428;
						}
						IL_3CB:
						if (enumerator == null)
						{
							break;
						}
						num = (short)2029453312;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_428:;
				}
				return list;
			}
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002AD0 File Offset: 0x00000CD0
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadCodeplug(byte[] partitions, global::Motorola.Common.Communication.IProgressIndicator progressIndicator, global::System.Collections.Generic.List<ushort> typesFilter = null)
		{
			short num = (short)130337195;
			short num2 = num;
			num = (short)1845479851;
			switch (num2 == num)
			{
			}
			num = (short)333447168;
			short num3 = num;
			num = (short)1983709185;
			if (num != 0)
			{
			}
			num = (short)1316552704;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			this.ReadIshPartions(ishItemCollection, partitions, progressIndicator, typesFilter);
			return ishItemCollection;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002B8C File Offset: 0x00000D8C
		public void ReadIshPartions(global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItems, byte[] partitions, global::Motorola.Common.Communication.IProgressIndicator progressIndicator, global::System.Collections.Generic.List<ushort> typesFilter = null)
		{
			short num = (short)902955008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					int num3;
					double progressRate;
					for (;;)
					{
						IL_27:
						switch (num2)
						{
						case 0:
							return;
						case 1:
						{
							if (num3 >= partitions.Length)
							{
								num = (short)593231872;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)884146176;
							short num4 = num;
							byte a_ = partitions[num3];
							this.a(ishItems, a_, new global::Motorola.Common.Communication.IteratedProgressIndicator(progressIndicator, progressRate), typesFilter);
							num3++;
							num = (short)300154883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_DD;
						case 3:
							goto IL_DD;
						}
						break;
						IL_DD:
						num = (short)290586625;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3E:
					progressRate = 1.0 / (double)partitions.Length;
					num3 = 0;
					num = (short)58176035;
					short num5 = num;
					num = (short)1614787107;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)171180033;
						if (num != 0)
						{
						}
						num = (short)1575157760;
						if (num != 0)
						{
						}
						num = (short)984416258;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_27;
					}
				}
				return;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002D10 File Offset: 0x00000F10
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadIshPartion(byte partition, global::Motorola.Common.Communication.IProgressIndicator progressIndicator, global::System.Collections.Generic.List<ushort> typesFilter = null)
		{
			short num = (short)1319935129;
			short num2 = num;
			num = (short)1577229465;
			switch (num2 == num)
			{
			}
			num = (short)817889280;
			short num3 = num;
			num = (short)2146566144;
			if (num != 0)
			{
			}
			num = (short)96534529;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			this.a(ishItemCollection, partition, progressIndicator, typesFilter);
			return ishItemCollection;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002DCC File Offset: 0x00000FCC
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadIshItems(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaders, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			short num = (short)772412619;
			short num2 = num;
			num = (short)145429707;
			switch (num2 == num)
			{
			}
			num = (short)856096768;
			short num3 = num;
			num = (short)1999241217;
			if (num != 0)
			{
			}
			num = (short)1190658048;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			ishHeaders = this.a(ishHeaders);
			this.a(ishItemCollection, ishHeaders, progressIndicator);
			return ishItemCollection;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002E90 File Offset: 0x00001090
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> a(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> A_0)
		{
			short num = (short)1590493184;
			switch (num)
			{
			default:
			{
				num = (short)252641281;
				if (num != 0)
				{
				}
				num = (short)1643249664;
				short num2 = num;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.CommonUtil.IshHeader> enumerator = A_0.GetEnumerator();
				try
				{
					num = (short)2027880454;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							try
							{
								num = (short)857669635;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										global::System.Collections.Generic.List<ushort>.Enumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1212743681;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										ushort ishId = enumerator2.Current;
										global::Motorola.Common.Communication.CommonUtil.IshHeader item;
										list.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(item.PartitionNumber, item.IshType, ishId));
										num = (short)1027145730;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										num = (short)115408900;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_26A;
									case 3:
										goto IL_1BB;
									case 4:
										goto IL_2BD;
									}
									goto IL_1E0;
									IL_1BB:
									switch (0)
									{
									case 0:
									{
										IL_1E0:
										num = (short)1445148519;
										short num4 = num;
										num = (short)2092447591;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_1BB;
										default:
											num = (short)1895301120;
											if (num != 0)
											{
											}
											goto IL_26A;
										}
										break;
									}
									}
									continue;
									IL_26A:
									num = (short)483065856;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_2BD:
								break;
							}
							finally
							{
								global::System.Collections.Generic.List<ushort>.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_2D0;
						case 1:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader item;
							if (item.IshID == 65535)
							{
								num = (short)856686594;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							list.Add(item);
							num = (short)1357316100;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader item;
							global::System.Collections.Generic.List<ushort>.Enumerator enumerator2 = this.a(item.PartitionNumber, item.IshType).GetEnumerator();
							num = (short)501088256;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1743978501;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.CommonUtil.IshHeader item = enumerator.Current;
							num = (short)230293505;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_2D0;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_C3;
							}
							continue;
						case 7:
							goto IL_2EA;
						}
						IL_F9:
						num = (short)2045050883;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C3:
						goto IL_F9;
						IL_2D0:
						num = (short)1551106055;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2EA:;
				}
				finally
				{
					num = (short)187695105;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)2099380226;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_31E;
							}
							continue;
						case 2:
							goto IL_355;
						}
						IL_31E:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1555103744;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_355:;
				}
				return list;
			}
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000322C File Offset: 0x0000142C
		public void TryReadIshItems(global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItems, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeadersToQuest, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			short num;
			for (;;)
			{
				num = (short)562692096;
				switch (num)
				{
				default:
				{
					num = (short)1008045549;
					short num2 = num;
					num = (short)531336685;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_54;
					}
					break;
				}
				}
			}
			IL_54:
			num = (short)511901697;
			if (num != 0)
			{
			}
			num = (short)1257504768;
			short num3 = num;
			num = (short)1237712896;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>(ishHeadersToQuest.Count);
			global::System.Collections.Generic.Dictionary<ushort, global::System.Collections.Generic.List<ushort>> dictionary = new global::System.Collections.Generic.Dictionary<ushort, global::System.Collections.Generic.List<ushort>>();
			global::System.Collections.Generic.Dictionary<ushort, global::System.Collections.Generic.List<ushort>> dictionary2 = new global::System.Collections.Generic.Dictionary<ushort, global::System.Collections.Generic.List<ushort>>();
			using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>.Enumerator enumerator = ishHeadersToQuest.GetEnumerator())
			{
				num = (short)2004942861;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						global::Motorola.Common.Communication.CommonUtil.IshHeader item;
						if (dictionary2[item.IshType].Contains(item.IshID))
						{
							num = (short)819789830;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						global::Motorola.Common.Communication.CommonUtil.IshHeader item;
						dictionary2.Add(item.IshType, this.a(item.PartitionNumber, item.IshType));
						num = (short)1282605070;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)78708745;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::Motorola.Common.Communication.CommonUtil.IshHeader item;
						dictionary.Add((ushort)item.PartitionNumber, this.ReadIshTypeSet(item.PartitionNumber));
						num = (short)1715208199;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::Motorola.Common.Communication.CommonUtil.IshHeader item;
						if (dictionary[(ushort)item.PartitionNumber].Contains(item.IshType))
						{
							num = (short)907804675;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
					{
						global::Motorola.Common.Communication.CommonUtil.IshHeader item;
						list.Add(item);
						num = (short)743833602;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_2C7;
					case 8:
					{
						global::Motorola.Common.Communication.CommonUtil.IshHeader item;
						if (!dictionary.ContainsKey((ushort)item.PartitionNumber))
						{
							num = (short)779157508;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C7;
					}
					case 9:
					{
						global::Motorola.Common.Communication.CommonUtil.IshHeader item;
						if (!dictionary2.ContainsKey(item.IshType))
						{
							num = (short)906493953;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EF;
					}
					case 10:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)357105676;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.CommonUtil.IshHeader item = enumerator.Current;
						num = (short)445382664;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_373;
					case 12:
						num = (short)2144862219;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						switch (0)
						{
						case 0:
							goto IL_13D;
						}
						continue;
					case 14:
						goto IL_1EF;
					}
					goto IL_13D;
					IL_1EF:
					num = (short)1721892864;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_23F:
					num = (short)1042153482;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_13D:
					goto IL_23F;
					IL_2C7:
					num = (short)838467589;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_373:;
			}
			this.a(ishItems, list, progressIndicator);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000035E4 File Offset: 0x000017E4
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> ReadIshTypeIdPairSet(byte partition, ushort[] types, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			short num = (short)1578565632;
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
				int num3;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_28F;
					case 1:
					{
						num = (short)808910849;
						if (num != 0)
						{
						}
						if (num3 >= types.Length)
						{
							num = (short)1305935874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort num4 = types[num3];
						global::System.Collections.Generic.List<ushort>.Enumerator enumerator = this.a(partition, num4).GetEnumerator();
						num = (short)682950660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_25D;
					case 3:
						if (progressIndicator != null)
						{
							num = (short)1454243845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28F;
					case 4:
						try
						{
							num = (short)1586429955;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)648085508;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Collections.Generic.List<ushort>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)831193088;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									ushort ishId = enumerator.Current;
									ushort num4;
									list.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(partition, num4, ishId));
									num = (short)2005794817;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									num = (short)1841437380;
									short num5 = num;
									num = (short)1338317508;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1EC;
									default:
										num = (short)675807232;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_166;
										}
										continue;
									}
									break;
								}
								case 4:
									goto IL_1EC;
								}
								IL_168:
								num = (short)1140195330;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_166:
								goto IL_168;
							}
							IL_1EC:
							goto IL_A5;
						}
						finally
						{
							global::System.Collections.Generic.List<ushort>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1FF;
						IL_A5:
						num = (short)1154154499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						progressIndicator.IncreaseProcess(1.0 / (double)types.Length);
						num = (short)1766457344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_1FF;
					case 7:
						goto IL_1FF;
					}
					goto IL_4E;
					IL_1FF:
					num = (short)1406140417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28F:
					num3++;
					num = (short)538247175;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_25D:
				num = (short)1926234112;
				short num6 = num;
				return list;
				IL_4E:
				list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>(types.Length);
				num3 = 0;
				num = (short)1979383814;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000038E8 File Offset: 0x00001AE8
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> BundleReadIshTypeIdPairSet(byte partition, global::System.Collections.Generic.List<ushort> types, global::Motorola.Common.Communication.IProgressIndicator progressIndicator, global::System.Collections.Generic.List<ushort> typesFilter = null)
		{
			short num = (short)1549795328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.List<ushort>.Enumerator enumerator2;
					switch (num2)
					{
					case 0:
						if (typesFilter == null)
						{
							num = (short)672071683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E0;
					case 1:
						goto IL_39F;
					case 2:
						num = (short)1675624449;
						if (num != 0)
						{
						}
						try
						{
							num = (short)396296192;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_C1;
									}
									continue;
								case 1:
								{
									ushort num3;
									if (typesFilter.Contains(num3))
									{
										num = (short)1653669895;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.List<ushort>.Enumerator enumerator = this.a(partition, num3).GetEnumerator();
									num = (short)184418306;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									try
									{
										num = (short)2101018625;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_2A1;
											case 1:
											{
												num = (short)1211801778;
												short num4 = num;
												num = (short)946380978;
												switch ((num4 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_2A1;
												default:
													num = (short)1509818368;
													if (num != 0)
													{
													}
													switch (0)
													{
													case 0:
														goto IL_21C;
													}
													continue;
												}
												break;
											}
											case 3:
												num = (short)895418368;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
											{
												global::System.Collections.Generic.List<ushort>.Enumerator enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)486604803;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												ushort ishId = enumerator.Current;
												ushort num3;
												list.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(partition, num3, ishId));
												num = (short)601489410;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_21E:
											num = (short)59572228;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_21C:
											goto IL_21E;
										}
										IL_2A1:
										break;
									}
									finally
									{
										global::System.Collections.Generic.List<ushort>.Enumerator enumerator;
										((global::System.IDisposable)enumerator).Dispose();
									}
									goto IL_2B4;
								case 3:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1422524422;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									ushort num3 = enumerator2.Current;
									num = (short)1816330241;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_2CD;
								case 6:
									goto IL_2B4;
								case 7:
								{
									ushort num3;
									list.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(partition, num3, 0));
									num = (short)1006501893;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_103:
								num = (short)643301379;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C1:
								goto IL_103;
								IL_2B4:
								num = (short)1416888324;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2CD:
							goto IL_3A4;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_2E0;
					case 3:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> a_ = this.a(partition, types, new global::Motorola.Common.Communication.IteratedProgressIndicator(progressIndicator, 0.2));
						list = this.a(a_, new global::Motorola.Common.Communication.IteratedProgressIndicator(progressIndicator, 0.8));
						num = (short)636354561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_3E;
					IL_2E0:
					num = (short)124125184;
					short num5 = num;
					enumerator2 = types.GetEnumerator();
					num = (short)1532362754;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_39F:
				IL_3A4:
				list.Sort();
				return list;
				IL_3E:
				list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
				num = (short)97189888;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003CD4 File Offset: 0x00001ED4
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> ReadIshTypeIdPairSet(byte partition, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			short num = (short)1054779362;
			short num2 = num;
			num = (short)1093380066;
			switch (num2 == num)
			{
			}
			num = (short)480903169;
			if (num != 0)
			{
			}
			num = (short)1566638080;
			if (num != 0)
			{
			}
			num = (short)829358080;
			short num3 = num;
			global::System.Collections.Generic.List<ushort> types = this.ReadIshTypeSet(partition);
			return this.BundleReadIshTypeIdPairSet(partition, types, progressIndicator, null);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003D90 File Offset: 0x00001F90
		public global::System.Collections.Generic.List<ushort> ReadIshTypeSet(byte partition)
		{
			short num = (short)612696064;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				ushort num3;
				global::System.Collections.Generic.List<ushort> list;
				ushort typeCount;
				for (;;)
				{
					IL_27:
					global::Motorola.Common.Communication.Rcmp.RcmpReadIshTypeSet rcmpReadIshTypeSet;
					switch (num2)
					{
					case 0:
						goto IL_234;
					case 1:
						num = (short)186712071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_14E;
					case 3:
						goto IL_1E9;
					case 4:
					{
						num3 += (ushort)rcmpReadIshTypeSet.Types.Length;
						num = (short)1478073995;
						short num4 = num;
						num = (short)1163501195;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1215561728;
							if (num != 0)
							{
							}
							num = (short)956235781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						if (num3 >= rcmpReadIshTypeSet.TotalTypeCount)
						{
							num = (short)1467416585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E9;
					case 6:
					{
						num = (short)507248640;
						short num5 = num;
						int num6;
						ushort[] types;
						if (num6 >= types.Length)
						{
							num = (short)1277427716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort item = types[num6];
						list.Add(item);
						num6++;
						num = (short)837287936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						if (rcmpReadIshTypeSet.TotalTypeCount == 0)
						{
							num = (short)1495072770;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)703070209;
						if (num != 0)
						{
						}
						ushort[] types = rcmpReadIshTypeSet.Types;
						int num6 = 0;
						num = (short)786038794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (rcmpReadIshTypeSet.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)74776577;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29E;
					case 9:
						return list;
					case 10:
						goto IL_234;
					}
					goto IL_5A;
					IL_1E9:
					rcmpReadIshTypeSet = this.ReadIshTypeSet(partition, typeCount, num3);
					num = (short)1321205768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_234:
					num = (short)1803091974;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_14E:
				IL_29E:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadIshTypeSetFailure);
				IL_5A:
				typeCount = (ushort)((this.b - (2 + global::Motorola.Common.Communication.Rcmp.RcmpReadIshTypeSet.HeaderSize)) / 2);
				num3 = 0;
				list = new global::System.Collections.Generic.List<ushort>();
				num = (short)1930756099;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00004048 File Offset: 0x00002248
		public void BundleSendMessages(global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> rcmpMessages, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			short num = (short)689373184;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)305309538;
				short num3 = num;
				num = (short)1235199842;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1609433088;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>.Enumerator enumerator;
					int num5;
					for (;;)
					{
						IL_72:
						switch (num2)
						{
						case 0:
							goto IL_49E;
						case 1:
							goto IL_1ED;
						case 2:
						{
							num = (short)1062928384;
							short num4 = num;
							try
							{
								num = (short)389545985;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_1DA;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_157;
										}
										continue;
									case 2:
										num = (short)1776353280;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1941438466;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.RcmpBaseMessage rcmpBaseMessage = enumerator.Current;
										num5 += ((global::Motorola.Common.Communication.ISuperBundlerMessage)rcmpBaseMessage).MaxMessageSize + 2;
										num = (short)1303117828;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_18A:
									num = (short)1211301891;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_157:
									goto IL_18A;
								}
								IL_1DA:
								goto IL_60A;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto Block_2;
						}
						}
						break;
						Block_3:
						global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle xcmpSuperBundle;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle> list;
						int num8;
						int num7;
						try
						{
							IL_49E:
							num = (short)1575354368;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.Common.Communication.RcmpBaseMessage rcmpBaseMessage2;
								int num6;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_4E4;
									}
									continue;
								case 2:
									if (!enumerator.MoveNext())
									{
										num = (short)1758003205;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									rcmpBaseMessage2 = enumerator.Current;
									num6 = ((global::Motorola.Common.Communication.ISuperBundlerMessage)rcmpBaseMessage2).MaxMessageSize + 2;
									num = (short)1843789831;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									xcmpSuperBundle = new global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle(true);
									list.Add(xcmpSuperBundle);
									num7 = num8;
									num = (short)1587412998;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_5F7;
								case 5:
									num = (short)1262813188;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_4E9;
								case 7:
									if (num7 + num6 >= this.b)
									{
										num = (short)1330642947;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4E9;
								}
								goto IL_4E4;
								IL_4E9:
								num7 += num6;
								xcmpSuperBundle.AddRcmpMessage(rcmpBaseMessage2);
								num = (short)187432961;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_59C:
								num = (short)1379794946;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4E4:
								goto IL_59C;
							}
							IL_5F7:
							goto IL_F6;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_60A;
						IL_F6:
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle>.Enumerator enumerator2 = list.GetEnumerator();
						num = (short)1181548545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						Block_2:
						try
						{
							IL_1ED:
							num = (short)1296105479;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.Common.Communication.RcmpBaseMessage rcmpBaseMessage3;
								switch (num2)
								{
								case 0:
								{
									global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle xcmpSuperBundle2;
									rcmpBaseMessage3 = xcmpSuperBundle2;
									num = (short)1649475586;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									if (rcmpBaseMessage3.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
									{
										num = (short)1277624335;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_406;
								case 2:
									goto IL_298;
								case 3:
									if (rcmpBaseMessage3.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.IshItemNotFound)
									{
										num = (short)1901723664;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									goto IL_48B;
								case 5:
									num = (short)446889988;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle xcmpSuperBundle2;
									if (xcmpSuperBundle2.ChildCount > 0)
									{
										num = (short)1858273293;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_406;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_259;
									}
									continue;
								case 8:
								{
									global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle xcmpSuperBundle2;
									if (xcmpSuperBundle2.ChildCount > 1)
									{
										num = (short)837943296;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									rcmpBaseMessage3 = xcmpSuperBundle2[0];
									num = (short)1375207436;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1937178629;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle xcmpSuperBundle2 = enumerator2.Current;
									num = (short)2099970054;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									if (progressIndicator != null)
									{
										num = (short)716046347;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 11:
									progressIndicator.IncreaseProcess(1.0 / (double)list.Count);
									num = (short)1082851342;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_298;
								case 13:
									num = (short)665059336;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									goto IL_3CD;
								case 16:
									num = (short)1451884545;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_25B:
								num = (short)9633801;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_259:
								goto IL_25B;
								IL_298:
								this.a.SendAndReceiveMessage(rcmpBaseMessage3);
								num = (short)263127043;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_406:
								num = (short)734593034;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3CD:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.BundleMessageFailure);
							IL_48B:
							return;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto Block_3;
						IL_60A:
						num8 = 2 + global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle.HeaderSize;
						list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle>();
						xcmpSuperBundle = new global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle(true);
						list.Add(xcmpSuperBundle);
						num7 = num8;
						enumerator = rcmpMessages.GetEnumerator();
						num = (short)302776320;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_85:
					num5 = 0;
					enumerator = rcmpMessages.GetEnumerator();
					num = (short)617349121;
					if (num != 0)
					{
					}
					num = (short)1596129282;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_72;
				}
				}
				return;
			}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000046F0 File Offset: 0x000028F0
		public void ReorgIshPartition(global::System.Collections.Generic.List<byte> partitionList)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_15C;
				case 1:
				{
					global::Motorola.Common.Communication.Rcmp.RcmpIshReorgControl rcmpIshReorgControl;
					if (rcmpIshReorgControl.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)205324292;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					int num3;
					num3++;
					num2 = (short)561512453;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_196;
				case 3:
				{
					int num3;
					if (num3 >= partitionList.Count)
					{
						num2 = (short)339410946;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.Common.Communication.Rcmp.RcmpIshReorgControl rcmpIshReorgControl = new global::Motorola.Common.Communication.Rcmp.RcmpIshReorgControl(partitionList[num3], 1);
					this.a.SendAndReceiveMessage(rcmpIshReorgControl);
					num2 = (short)1418002433;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					goto IL_15A;
				case 5:
					goto IL_15C;
				}
				goto IL_28;
				IL_15C:
				num2 = (short)1226899459;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_15A:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_IshReorgFailure);
			IL_196:
			return;
			IL_28:
			num2 = (short)1138976038;
			short num4 = num2;
			num2 = (short)765158694;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
			{
				num2 = (short)100925440;
				if (num2 != 0)
				{
				}
				num2 = (short)2118778881;
				if (num2 != 0)
				{
				}
				int num3 = 0;
				num2 = (short)881131520;
				short num5 = num2;
				num2 = (short)2133065728;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00004898 File Offset: 0x00002A98
		public global::Motorola.Common.Communication.Rcmp.RcmpReadIshTypeSet ReadIshTypeSet(byte partition, ushort typeCount, ushort offset)
		{
			short num = (short)1723137200;
			short num2 = num;
			num = (short)1044642992;
			switch (num2 == num)
			{
			}
			num = (short)1453457409;
			if (num != 0)
			{
			}
			num = (short)1875836928;
			if (num != 0)
			{
			}
			num = (short)1268121600;
			short num3 = num;
			global::Motorola.Common.Communication.Rcmp.RcmpReadIshTypeSet rcmpReadIshTypeSet = new global::Motorola.Common.Communication.Rcmp.RcmpReadIshTypeSet(partition, typeCount, offset);
			this.a.SendAndReceiveMessage(rcmpReadIshTypeSet);
			return rcmpReadIshTypeSet;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00004958 File Offset: 0x00002B58
		private void a(global::Motorola.Common.Communication.CommonUtil.IshItemCollection A_0, byte A_1, global::Motorola.Common.Communication.IProgressIndicator A_2, global::System.Collections.Generic.List<ushort> A_3)
		{
			switch (0)
			{
			case 0:
				goto IL_67;
			}
			short num;
			int num3;
			double num4;
			for (;;)
			{
				IL_0A:
				num = (short)943886119;
				short num2 = num;
				num = (short)835751719;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)178847744;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_109;
					case 1:
						A_2.IncreaseProcess(0.05);
						num4 -= 0.05;
						goto IL_CA;
					case 2:
						if (A_2 != null)
						{
							num = (short)1780744193;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_131;
					}
					goto IL_67;
				}
				IL_CA:
				num = (short)227606528;
				short num5 = num;
				num = (short)278528000;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_109:
			num = (short)1940258817;
			if (num != 0)
			{
			}
			IL_131:
			global::System.Collections.Generic.List<ushort> types;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> a_ = this.BundleReadIshTypeIdPairSet(A_1, types, new global::Motorola.Common.Communication.IteratedProgressIndicator(A_2, 0.2), A_3);
			num4 -= 0.2;
			this.a(A_0, a_, new global::Motorola.Common.Communication.IteratedProgressIndicator(A_2, num4));
			return;
			IL_67:
			types = this.ReadIshTypeSet(A_1);
			num4 = 1.0;
			num = (short)1621098498;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00004ACC File Offset: 0x00002CCC
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> a(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> A_0, global::Motorola.Common.Communication.IProgressIndicator A_1)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>();
			global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.CommonUtil.IshHeader> enumerator = A_0.GetEnumerator();
			short num;
			try
			{
				num = (short)1483866116;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)525074434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader = enumerator.Current;
						list.Add(new global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem(ishHeader.PartitionNumber, ishHeader.IshType, ishHeader.IshID, 0, 0));
						num = (short)1518665729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)1752672763;
						short num3 = num;
						num = (short)1495837179;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)114884608;
							if (num != 0)
							{
							}
							num = (short)40042497;
							if (num != 0)
							{
							}
							num = (short)220987395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_14A;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_48;
						}
						continue;
					}
					IL_8A:
					num = (short)700383232;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_48:
					goto IL_8A;
				}
				IL_14A:;
			}
			finally
			{
				num = (short)1377828866;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1189675009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1B1;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_17D;
						}
						continue;
					}
					IL_17D:
					if (enumerator == null)
					{
						break;
					}
					num = (short)4849664;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1B1:;
			}
			num = (short)1847721984;
			short num4 = num;
			this.BundleSendMessages(list, A_1);
			return list;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00004CDC File Offset: 0x00002EDC
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> b(global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> A_0, global::Motorola.Common.Communication.IProgressIndicator A_1)
		{
			short num = (short)932446208;
			switch (num)
			{
			default:
			{
				num = (short)1478230016;
				short num2 = num;
				num = (short)1050869761;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>(A_0.Count);
				ushort num3 = (ushort)(this.b - (2 + global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle.HeaderSize) - (2 + global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem.HeaderSize));
				using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>.Enumerator enumerator = A_0.GetEnumerator())
				{
					num = (short)201981961;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						ushort num5;
						global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem rcmpReadIshItem;
						ushort num7;
						switch (num4)
						{
						case 0:
							if (num5 >= rcmpReadIshItem.ItemSize)
							{
								num = (short)354811906;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_EB;
						case 1:
							goto IL_EB;
						case 2:
						{
							num = (short)1674562422;
							short num6 = num;
							num = (short)1091881846;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_154;
							default:
								num = (short)428867584;
								if (num != 0)
								{
								}
								break;
							}
							break;
						}
						case 3:
							if (num7 >= num3)
							{
								num = (short)388235271;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19F;
						case 4:
							goto IL_19F;
						case 5:
							if (!enumerator.MoveNext())
							{
								goto IL_154;
							}
							rcmpReadIshItem = (global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem)enumerator.Current;
							num5 = 0;
							num = (short)1907752961;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)1218052104;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num7 = num3;
							num = (short)2106523652;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_28F;
						case 9:
							switch (0)
							{
							case 0:
								goto IL_E9;
							}
							continue;
						}
						goto IL_E9;
						IL_EB:
						num7 = rcmpReadIshItem.ItemSize - num5;
						num = (short)920715267;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_132:
						num = (short)714145797;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_E9:
						goto IL_132;
						IL_154:
						num = (short)567083014;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_19F:
						list.Add(new global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem(rcmpReadIshItem.LogicalPartition, rcmpReadIshItem.IshType, rcmpReadIshItem.IshID, num7, num5));
						num5 += num7;
						num = (short)1683161088;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_28F:;
				}
				this.BundleSendMessages(list, A_1);
				return list;
			}
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00004FB0 File Offset: 0x000031B0
		private void a(global::Motorola.Common.Communication.CommonUtil.IshItemCollection A_0, global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> A_1, global::Motorola.Common.Communication.IProgressIndicator A_2)
		{
			short num = (short)106102784;
			switch (num)
			{
			default:
			{
				num = (short)138084352;
				short num2 = num;
				double num3 = 1.0;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> a_ = this.a(A_1, new global::Motorola.Common.Communication.IteratedProgressIndicator(A_2, 0.05));
				num3 -= 0.05;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>.Enumerator enumerator = this.b(a_, new global::Motorola.Common.Communication.IteratedProgressIndicator(A_2, num3)).GetEnumerator();
				try
				{
					num = (short)1471021066;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem rcmpReadIshItem;
						byte[] array;
						switch (num4)
						{
						case 0:
							if (rcmpReadIshItem.Data.Length >= (int)rcmpReadIshItem.ItemSize)
							{
								num = (short)1481637895;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							array = new byte[(int)rcmpReadIshItem.ItemSize];
							global::System.Buffer.BlockCopy(rcmpReadIshItem.Data, 0, array, 0, rcmpReadIshItem.Data.Length);
							num = (short)308609028;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader;
							global::Motorola.Common.Communication.CommonUtil.IshItem ishItem = A_0[ishHeader];
							global::System.Buffer.BlockCopy(rcmpReadIshItem.Data, 0, ishItem.Data, (int)rcmpReadIshItem.Offset, rcmpReadIshItem.Data.Length);
							num = (short)620953611;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)1604911113;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (!enumerator.MoveNext())
							{
								num = (short)459997192;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							rcmpReadIshItem = (global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem)enumerator.Current;
							num = (short)1554841612;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_FE;
						case 5:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader;
							if (A_0.ContainsHeader(ishHeader))
							{
								num = (short)1085603841;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							array = null;
							num = (short)1068411410;
							short num5 = num;
							num = (short)1318758930;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_FE;
							default:
								num = (short)1218641920;
								if (num != 0)
								{
								}
								num = (short)1872953344;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							goto IL_174;
						case 7:
							array = rcmpReadIshItem.Data;
							num = (short)2096300045;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							num = (short)498073614;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							if (rcmpReadIshItem.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
							{
								num = (short)932184070;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader = new global::Motorola.Common.Communication.CommonUtil.IshHeader(rcmpReadIshItem.LogicalPartition, rcmpReadIshItem.IshType, rcmpReadIshItem.IshID);
							num = (short)1420623877;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							switch (0)
							{
							case 0:
								goto IL_EE;
							}
							continue;
						case 12:
							if (rcmpReadIshItem.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.IshItemNotFound)
							{
								num = (short)1974009858;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 13:
							goto IL_FE;
						case 14:
							goto IL_3D0;
						}
						goto IL_EE;
						IL_FE:
						A_0.AddItem(rcmpReadIshItem.LogicalPartition, rcmpReadIshItem.IshType, rcmpReadIshItem.IshID, (int)rcmpReadIshItem.ItemSize, array);
						num = (short)1120272399;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_19E:
						num = (short)1426259971;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_EE:
						goto IL_19E;
					}
					IL_174:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadIshItemFailure);
					IL_3D0:;
				}
				finally
				{
					num = (short)660930561;
					if (num != 0)
					{
					}
					((global::System.IDisposable)enumerator).Dispose();
				}
				return;
			}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000053E0 File Offset: 0x000035E0
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> a(byte A_0, global::System.Collections.Generic.List<ushort> A_1, global::Motorola.Common.Communication.IProgressIndicator A_2)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>(A_1.Count);
			short num;
			using (global::System.Collections.Generic.List<ushort>.Enumerator enumerator = A_1.GetEnumerator())
			{
				num = (short)1904738308;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1036451842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort type = enumerator.Current;
						list.Add(new global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet(A_0, type, 1, 0));
						num = (short)1533476865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)1655184248;
						short num3 = num;
						num = (short)526850936;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)2003042305;
							if (num != 0)
							{
							}
							num = (short)1275723776;
							if (num != 0)
							{
							}
							num = (short)464388099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_13A;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_4D;
						}
						continue;
					}
					IL_7C:
					num = (short)1769472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D:
					goto IL_7C;
				}
				IL_13A:;
			}
			num = (short)2045247488;
			short num4 = num;
			this.BundleSendMessages(list, A_2);
			return list;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00005588 File Offset: 0x00003788
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> a(global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> A_0, global::Motorola.Common.Communication.IProgressIndicator A_1)
		{
			short num = (short)756350976;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>(A_0.Count);
				ushort num2 = (ushort)((this.b - (2 + global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle.HeaderSize) - (2 + global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet.HeaderSize)) / 2);
				using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>.Enumerator enumerator = A_0.GetEnumerator())
				{
					num = (short)1663893513;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						ushort num4;
						global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet rcmpReadIshIDSet;
						ushort num5;
						switch (num3)
						{
						case 1:
							if (num4 >= rcmpReadIshIDSet.TotalIdCount)
							{
								num = (short)368050176;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_32B;
						case 2:
							if (!enumerator.MoveNext())
							{
								num = (short)2021261316;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							rcmpReadIshIDSet = (global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet)enumerator.Current;
							num4 = 0;
							num = (short)1768620039;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_375;
						case 4:
							num = (short)751632392;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (num5 >= num2)
							{
								num = (short)1847787526;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_375;
						case 6:
							num5 = num2;
							num = (short)2034696195;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_32B;
						case 8:
							goto IL_433;
						case 9:
							switch (0)
							{
							case 0:
								goto IL_2E3;
							}
							continue;
						}
						goto IL_2E3;
						IL_32B:
						num5 = rcmpReadIshIDSet.TotalIdCount - num4;
						num = (short)1574174725;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_375:
						list.Add(new global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet(rcmpReadIshIDSet.LogicalPartition, rcmpReadIshIDSet.IshType, num5, num4));
						num4 += num5;
						num = (short)1700790273;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_3DB:
						num = (short)1803354114;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2E3:
						goto IL_3DB;
					}
					IL_433:
					goto IL_251;
				}
				goto IL_446;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list2;
				for (;;)
				{
					IL_251:
					num = (short)1978204160;
					short num6 = num;
					this.BundleSendMessages(list, A_1);
					list2 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
					using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>.Enumerator enumerator = list.GetEnumerator())
					{
						num = (short)134152201;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
							{
								global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet rcmpReadIshIDSet2;
								if (rcmpReadIshIDSet2.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
								{
									num = (short)1630470146;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								ushort[] ids = rcmpReadIshIDSet2.IDs;
								int num7 = 0;
								num = (short)1531117569;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_A0;
							case 2:
								goto IL_187;
							case 3:
							{
								ushort[] ids;
								int num7;
								if (num7 >= ids.Length)
								{
									num = (short)1550712839;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1220826167;
								short num8 = num;
								num = (short)238310455;
								switch ((num8 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_10F;
								default:
								{
									num = (short)1702232064;
									if (num != 0)
									{
									}
									ushort ishId = ids[num7];
									global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet rcmpReadIshIDSet2;
									list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(rcmpReadIshIDSet2.LogicalPartition, rcmpReadIshIDSet2.IshType, ishId));
									num7++;
									num = (short)1177616388;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 4:
								goto IL_A0;
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1739718662;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet rcmpReadIshIDSet2 = (global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet)enumerator.Current;
								num = (short)1261305856;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								goto IL_10F;
							case 8:
								goto IL_23E;
							case 9:
								switch (0)
								{
								case 0:
									goto IL_9E;
								}
								continue;
							}
							goto IL_9E;
							IL_A0:
							num = (short)1652621315;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_D7:
							num = (short)1388183557;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_9E:
							goto IL_D7;
							IL_10F:
							num = (short)153288712;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_187:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadIshIdSetFailure);
						IL_23E:
						break;
					}
				}
				IL_446:
				num = (short)1330839553;
				if (num != 0)
				{
				}
				return list2;
			}
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00005A38 File Offset: 0x00003C38
		private global::System.Collections.Generic.List<ushort> a(byte A_0, ushort A_1)
		{
			short num = (short)486866944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4A;
				}
				for (;;)
				{
					IL_27:
					global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet rcmpReadIshIDSet;
					ushort num3;
					switch (num2)
					{
					case 0:
						if (rcmpReadIshIDSet.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)579731458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C9;
					case 1:
						if (num3 >= rcmpReadIshIDSet.TotalIdCount)
						{
							num = (short)1209008133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_136;
					case 2:
						num = (short)1728446465;
						if (num != 0)
						{
						}
						num = (short)1711865860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_134;
					case 4:
						if (rcmpReadIshIDSet.TotalIdCount == 0)
						{
							num = (short)1870069763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18E;
					case 5:
					{
						global::System.Collections.Generic.List<ushort> list;
						return list;
					}
					case 6:
						goto IL_136;
					}
					goto IL_4A;
					IL_136:
					ushort numberOfIDs;
					rcmpReadIshIDSet = new global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet(A_0, A_1, numberOfIDs, num3);
					this.a.SendAndReceiveMessage(rcmpReadIshIDSet);
					num = (short)1155465216;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C9:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadIshIdSetFailure);
				IL_134:
				goto IL_C9;
				IL_4A:
				num = (short)2015370212;
				short num4 = num;
				num = (short)1496456164;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_18E:
					num = (short)1633419264;
					short num5 = num;
					global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet rcmpReadIshIDSet;
					global::System.Collections.Generic.List<ushort> list;
					list.AddRange(rcmpReadIshIDSet.IDs);
					ushort num3;
					num3 += (ushort)rcmpReadIshIDSet.IDs.Length;
					num = (short)1476001793;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				default:
				{
					num = (short)255721472;
					if (num != 0)
					{
					}
					ushort num3 = 0;
					ushort numberOfIDs = (ushort)((this.b - (2 + global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet.HeaderSize)) / 2);
					global::System.Collections.Generic.List<ushort> list = new global::System.Collections.Generic.List<ushort>();
					num = (short)1987379206;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
				break;
			}
			}
		}

		// Token: 0x04000003 RID: 3
		private global::Motorola.Common.Communication.IMessageExecutor a;

		// Token: 0x04000004 RID: 4
		private int b;
	}
}
