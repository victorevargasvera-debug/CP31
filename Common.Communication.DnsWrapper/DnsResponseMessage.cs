using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Motorola.Common.Communication.Message;

namespace Motorola.Common.Communication
{
	// Token: 0x02000010 RID: 16
	public class DnsResponseMessage : global::Motorola.Common.Communication.DnsBaseMessage
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000074A0 File Offset: 0x000056A0
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordPTR> PTRS
		{
			get
			{
				short num = (short)1728970752;
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
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordPTR> list;
					for (;;)
					{
						IL_27:
						global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.ResourceRecord> enumerator;
						global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.ResourceRecord> answers;
						global::System.Func<global::Motorola.Common.Communication.ResourceRecord, bool> predicate;
						switch (num2)
						{
						case 0:
						{
							enumerator = base.Additionals.Where(new global::System.Func<global::Motorola.Common.Communication.ResourceRecord, bool>(global::Motorola.Common.Communication.DnsResponseMessage.<>c.<>9.b)).GetEnumerator();
							num = (short)498335744;
							short num3 = num;
							num = (short)1923022850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							try
							{
								num = (short)1173225476;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_2B0;
									case 1:
										num = (short)673316864;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1059717121;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.RecordPTR item = (global::Motorola.Common.Communication.RecordPTR)enumerator.Current;
										list.Add(item);
										num = (short)1011613698;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_235;
										}
										continue;
									}
									IL_237:
									num = (short)742850563;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_235:
									goto IL_237;
								}
								IL_2B0:;
							}
							finally
							{
								num = (short)911081474;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										goto IL_30C;
									case 1:
									{
										num = (short)278200188;
										short num4 = num;
										num = (short)498663292;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_30C;
										default:
											goto IL_358;
										}
										break;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_2E8;
										}
										continue;
									}
									IL_2E8:
									if (enumerator != null)
									{
										num = (short)625082368;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_370;
									IL_30C:
									num = (short)1640693761;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_358:
								num = (short)240058368;
								if (num != 0)
								{
								}
								IL_370:;
							}
							num = (short)1813512192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							try
							{
								num = (short)219480068;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_123;
									case 1:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)219873282;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.RecordPTR item2 = (global::Motorola.Common.Communication.RecordPTR)enumerator.Current;
										list.Add(item2);
										num = (short)809304067;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										num = (short)2092695552;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_AB;
										}
										continue;
									}
									IL_D7:
									num = (short)1159790593;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_AB:
									goto IL_D7;
								}
								IL_123:
								num = (short)1265369089;
								if (num != 0)
								{
								}
								return list;
							}
							finally
							{
								num = (short)1765015554;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)1340080129;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_1B8;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_181;
										}
										continue;
									}
									IL_181:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1343356928;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1B8:;
							}
							goto IL_1BB;
						case 3:
							answers = base.Answers;
							if ((predicate = global::Motorola.Common.Communication.DnsResponseMessage.<>c.<>9__1_0) == null)
							{
								goto IL_1BB;
							}
							goto IL_1D4;
						}
						goto IL_3E;
						IL_1D4:
						enumerator = answers.Where(predicate).GetEnumerator();
						num = (short)1150746625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1BB:
						predicate = (global::Motorola.Common.Communication.DnsResponseMessage.<>c.<>9__1_0 = new global::System.Func<global::Motorola.Common.Communication.ResourceRecord, bool>(global::Motorola.Common.Communication.DnsResponseMessage.<>c.<>9.a));
						goto IL_1D4;
					}
					return list;
					IL_3E:
					list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordPTR>();
					num = (short)1666514947;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000078D4 File Offset: 0x00005AD4
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordTXT> TXTS
		{
			get
			{
				short num = (short)550961152;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)437190657;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordTXT> list;
					for (;;)
					{
						IL_4F:
						global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.ResourceRecord> enumerator;
						global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.ResourceRecord> answers;
						global::System.Func<global::Motorola.Common.Communication.ResourceRecord, bool> predicate;
						switch (num2)
						{
						case 0:
						{
							num = (short)435617792;
							short num3 = num;
							enumerator = base.Additionals.Where(new global::System.Func<global::Motorola.Common.Communication.ResourceRecord, bool>(global::Motorola.Common.Communication.DnsResponseMessage.<>c.<>9.d)).GetEnumerator();
							num = (short)1270874114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							try
							{
								num = (short)1408499716;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_2B1;
									case 1:
										num = (short)195887104;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)141688833;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.RecordTXT item = (global::Motorola.Common.Communication.RecordTXT)enumerator.Current;
										list.Add(item);
										num = (short)1352925186;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_236;
										}
										continue;
									}
									IL_238:
									num = (short)956956675;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_236:
									goto IL_238;
								}
								IL_2B1:;
							}
							finally
							{
								num = (short)373358594;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										goto IL_30C;
									case 1:
									{
										num = (short)882761317;
										short num4 = num;
										num = (short)1557257829;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_30C;
										default:
											goto IL_356;
										}
										break;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_2E8;
										}
										continue;
									}
									IL_2E8:
									if (enumerator != null)
									{
										num = (short)1546584064;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_36D;
									IL_30C:
									num = (short)684654593;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_356:
								num = (short)1796800512;
								if (num != 0)
								{
								}
								IL_36D:;
							}
							num = (short)399572992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							try
							{
								num = (short)75104260;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_14C;
									case 1:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)174194690;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.RecordTXT item2 = (global::Motorola.Common.Communication.RecordTXT)enumerator.Current;
										list.Add(item2);
										num = (short)710737923;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										num = (short)450428928;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_D3;
										}
										continue;
									}
									IL_FF:
									num = (short)1677197313;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_D3:
									goto IL_FF;
								}
								IL_14C:
								return list;
							}
							finally
							{
								num = (short)1982332930;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)1272315905;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_1B9;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_183;
										}
										continue;
									}
									IL_183:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1068892160;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1B9:;
							}
							goto IL_1BC;
						case 3:
							answers = base.Answers;
							if ((predicate = global::Motorola.Common.Communication.DnsResponseMessage.<>c.<>9__3_0) == null)
							{
								goto IL_1BC;
							}
							goto IL_1D5;
						}
						goto IL_66;
						IL_1D5:
						enumerator = answers.Where(predicate).GetEnumerator();
						num = (short)1325924353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1BC:
						predicate = (global::Motorola.Common.Communication.DnsResponseMessage.<>c.<>9__3_0 = new global::System.Func<global::Motorola.Common.Communication.ResourceRecord, bool>(global::Motorola.Common.Communication.DnsResponseMessage.<>c.<>9.c));
						goto IL_1D5;
					}
					return list;
					IL_66:
					list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordTXT>();
					num = (short)761659395;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_4F;
				}
				}
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00007D00 File Offset: 0x00005F00
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordA> AS
		{
			get
			{
				short num = (short)880410624;
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
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordA> list;
					for (;;)
					{
						IL_27:
						global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.ResourceRecord> enumerator;
						global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.ResourceRecord> answers;
						global::System.Func<global::Motorola.Common.Communication.ResourceRecord, bool> predicate;
						switch (num2)
						{
						case 0:
						{
							num = (short)204800001;
							if (num != 0)
							{
							}
							num = (short)459079680;
							short num3 = num;
							enumerator = base.Additionals.Where(new global::System.Func<global::Motorola.Common.Communication.ResourceRecord, bool>(global::Motorola.Common.Communication.DnsResponseMessage.<>c.<>9.f)).GetEnumerator();
							num = (short)837091330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							try
							{
								num = (short)2070872068;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_284;
									case 1:
										num = (short)529989632;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)908787713;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.RecordA item = (global::Motorola.Common.Communication.RecordA)enumerator.Current;
										list.Add(item);
										num = (short)140312578;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_20B;
										}
										continue;
									}
									IL_20D:
									num = (short)1782644739;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_20B:
									goto IL_20D;
								}
								IL_284:;
							}
							finally
							{
								num = (short)1774321666;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										goto IL_2DF;
									case 1:
									{
										num = (short)27758485;
										short num4 = num;
										num = (short)220434325;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_2DF;
										default:
											goto IL_32C;
										}
										break;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_2BC;
										}
										continue;
									}
									IL_2BC:
									if (enumerator != null)
									{
										num = (short)1521418240;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_343;
									IL_2DF:
									num = (short)1844183041;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_32C:
								num = (short)1536229376;
								if (num != 0)
								{
								}
								IL_343:;
							}
							num = (short)1995702272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							try
							{
								num = (short)1368064004;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_123;
									case 1:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)675348482;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.RecordA item2 = (global::Motorola.Common.Communication.RecordA)enumerator.Current;
										list.Add(item2);
										num = (short)416874499;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										num = (short)526450688;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_A9;
										}
										continue;
									}
									IL_D5:
									num = (short)1252917249;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_A9:
									goto IL_D5;
								}
								IL_123:
								return list;
							}
							finally
							{
								num = (short)1211432962;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)144179201;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_190;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_15A;
										}
										continue;
									}
									IL_15A:
									if (enumerator == null)
									{
										break;
									}
									num = (short)671481856;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_190:;
							}
							goto IL_193;
						case 3:
							answers = base.Answers;
							if ((predicate = global::Motorola.Common.Communication.DnsResponseMessage.<>c.<>9__5_0) == null)
							{
								goto IL_193;
							}
							goto IL_1AC;
						}
						goto IL_3E;
						IL_1AC:
						enumerator = answers.Where(predicate).GetEnumerator();
						num = (short)961740801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_193:
						predicate = (global::Motorola.Common.Communication.DnsResponseMessage.<>c.<>9__5_0 = new global::System.Func<global::Motorola.Common.Communication.ResourceRecord, bool>(global::Motorola.Common.Communication.DnsResponseMessage.<>c.<>9.e));
						goto IL_1AC;
					}
					return list;
					IL_3E:
					list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordA>();
					num = (short)295632899;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000812C File Offset: 0x0000632C
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordSRV> SRVS
		{
			get
			{
				short num = (short)572325888;
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
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordSRV> list;
					for (;;)
					{
						IL_27:
						global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.ResourceRecord> enumerator;
						global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.ResourceRecord> answers;
						global::System.Func<global::Motorola.Common.Communication.ResourceRecord, bool> predicate;
						switch (num2)
						{
						case 0:
						{
							enumerator = base.Additionals.Where(new global::System.Func<global::Motorola.Common.Communication.ResourceRecord, bool>(global::Motorola.Common.Communication.DnsResponseMessage.<>c.<>9.h)).GetEnumerator();
							num = (short)1933574144;
							short num3 = num;
							num = (short)207749122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							try
							{
								num = (short)1143013380;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_28B;
									case 1:
										num = (short)432996352;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)628752385;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.RecordSRV item = (global::Motorola.Common.Communication.RecordSRV)enumerator.Current;
										list.Add(item);
										num = (short)1391001602;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_20E;
										}
										continue;
									}
									IL_210:
									num = (short)467337219;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_20E:
									goto IL_210;
								}
								IL_28B:;
							}
							finally
							{
								num = (short)1654194178;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										goto IL_2E6;
									case 1:
									{
										num = (short)752471772;
										short num4 = num;
										num = (short)1952698076;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_2E6;
										default:
											goto IL_332;
										}
										break;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_2C3;
										}
										continue;
									}
									IL_2C3:
									if (enumerator != null)
									{
										num = (short)1057030144;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_349;
									IL_2E6:
									num = (short)1861943297;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_332:
								num = (short)836632576;
								if (num != 0)
								{
								}
								IL_349:;
							}
							num = (short)2134900736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)665190401;
							if (num != 0)
							{
							}
							try
							{
								num = (short)92471300;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_125;
									case 1:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1304625154;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.RecordSRV item2 = (global::Motorola.Common.Communication.RecordSRV)enumerator.Current;
										list.Add(item2);
										num = (short)1059258371;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										num = (short)159121408;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_AB;
										}
										continue;
									}
									IL_D7:
									num = (short)1394016257;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_AB:
									goto IL_D7;
								}
								IL_125:
								return list;
							}
							finally
							{
								num = (short)348717058;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)310444033;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_193;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_15D;
										}
										continue;
									}
									IL_15D:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1037893632;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_193:;
							}
							goto IL_196;
						case 3:
							answers = base.Answers;
							if ((predicate = global::Motorola.Common.Communication.DnsResponseMessage.<>c.<>9__7_0) == null)
							{
								goto IL_196;
							}
							goto IL_1AF;
						}
						goto IL_3E;
						IL_1AF:
						enumerator = answers.Where(predicate).GetEnumerator();
						num = (short)1297612801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_196:
						predicate = (global::Motorola.Common.Communication.DnsResponseMessage.<>c.<>9__7_0 = new global::System.Func<global::Motorola.Common.Communication.ResourceRecord, bool>(global::Motorola.Common.Communication.DnsResponseMessage.<>c.<>9.g));
						goto IL_1AF;
					}
					return list;
					IL_3E:
					list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordSRV>();
					num = (short)2048720899;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00008560 File Offset: 0x00006760
		public DnsResponseMessage()
		{
			base.Header = new global::Motorola.Common.Communication.Header();
			base.Questions = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Question>();
			base.Answers = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.ResourceRecord>();
			base.Authorities = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.ResourceRecord>();
			base.Additionals = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.ResourceRecord>();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000085AC File Offset: 0x000067AC
		public int GenerateBoardcastMessage(byte[] sendBuffer, string serialNum, string modelNum)
		{
			int a_ = 12;
			short num = (short)1353842689;
			if (num != 0)
			{
			}
			num = (short)1894907904;
			short num2 = num;
			num = (short)64344961;
			short num3 = num;
			num = (short)55432065;
			switch (num3 == num)
			{
			}
			num = (short)466288640;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.RecordPTR recordPTR = new global::Motorola.Common.Communication.RecordPTR();
			recordPTR.NAME = global::Motorola.Common.Communication.Message.PCRDnsResponseMessage.b("吊戌笎瀐挒㬔䠖洘砚洜ㄞ䴠䰢䘤䘦䔨", a_);
			recordPTR.TYPE = 12;
			recordPTR.CLASS = 1;
			recordPTR.TTL = 120U;
			recordPTR.RDLENGTH = 44;
			recordPTR.RDATA = global::System.Text.Encoding.ASCII.GetBytes(global::Motorola.Common.Communication.Message.PCRDnsResponseMessage.b("䘊䈌嬎帐䜒䜔唖嘘䐚⼜縞ሠጢᔤᘦᤨጪᬬᬮ̲ܰ46स଺ጼ怾⹀㝂⑄㝆杈ᑊ㥌ⱎ⅐絒㥔㡖㩘㩚ㅜ", a_));
			base.Answers.Add(recordPTR);
			global::Motorola.Common.Communication.RecordSRV item = new global::Motorola.Common.Communication.RecordSRV();
			base.Answers.Add(item);
			global::Motorola.Common.Communication.RecordTXT item2 = new global::Motorola.Common.Communication.RecordTXT();
			base.Answers.Add(item2);
			global::Motorola.Common.Communication.RecordA item3 = new global::Motorola.Common.Communication.RecordA();
			base.Additionals.Add(item3);
			return 0;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000086F8 File Offset: 0x000068F8
		public override int BuildCommandMessage(byte[] sendBuffer)
		{
			int a_ = 0;
			short num = (short)2012086272;
			switch (num)
			{
			default:
			{
				num = (short)1674575873;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.IO.MemoryStream memoryStream;
					switch (num2)
					{
					case 0:
					{
						num = (short)381353984;
						short num3 = num;
						try
						{
							memoryStream.WriteByte((byte)((base.Header.ID & 65280) >> 8));
							memoryStream.WriteByte((byte)(base.Header.ID & 255));
							byte b = 0;
							b |= (byte)(base.Header.QR << 7);
							b |= (byte)(base.Header.OPCODE << 3);
							b |= (byte)(base.Header.AA << 2);
							b |= (byte)(base.Header.TC << 1);
							b |= base.Header.RD;
							memoryStream.WriteByte(b);
							b = 0;
							b |= (byte)(base.Header.RA << 7);
							b |= (byte)(base.Header.Z << 4);
							b |= base.Header.RCODE;
							memoryStream.WriteByte(b);
							memoryStream.WriteByte((byte)((base.Header.QDCOUNT & 65280) >> 8));
							memoryStream.WriteByte((byte)(base.Header.QDCOUNT & 255));
							memoryStream.WriteByte((byte)((base.Header.ANCOUNT & 65280) >> 8));
							memoryStream.WriteByte((byte)(base.Header.ANCOUNT & 255));
							memoryStream.WriteByte((byte)((base.Header.NSCOUNT & 65280) >> 8));
							memoryStream.WriteByte((byte)(base.Header.NSCOUNT & 255));
							memoryStream.WriteByte((byte)((base.Header.ARCOUNT & 65280) >> 8));
							memoryStream.WriteByte((byte)(base.Header.ARCOUNT & 255));
							using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Question>.Enumerator enumerator = base.Questions.GetEnumerator())
							{
								num = (short)723976203;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									num = (short)365423492;
									short num4 = num;
									num = (short)1780476804;
									global::Motorola.Common.Communication.Question question;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1937375232;
										if (num != 0)
										{
										}
										switch (num2)
										{
										case 0:
										{
											int num5;
											byte[] bytes;
											if (num5 >= bytes.Length)
											{
												num = (short)674627588;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											memoryStream.WriteByte(bytes[num5]);
											num5++;
											num = (short)1759969290;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 1:
											goto IL_39B;
										case 2:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)1936654345;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											question = enumerator.Current;
											string[] array = question.QNAME.Split(new char[]
											{
												'.'
											});
											int num6 = 0;
											num = (short)413335558;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
										{
											string[] array;
											int num6;
											if (num6 >= array.Length)
											{
												num = (short)1288765441;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											string s = array[num6];
											byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(s);
											memoryStream.WriteByte((byte)bytes.Length);
											int num5 = 0;
											num = (short)210501640;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 4:
										{
											int num6;
											num6++;
											num = (short)336134149;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 5:
											goto IL_410;
										case 6:
											goto IL_410;
										case 7:
											goto IL_517;
										case 8:
											goto IL_4BC;
										case 9:
											num = (short)1767374855;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 10:
											goto IL_4BC;
										case 11:
											switch (0)
											{
											case 0:
												goto IL_2EF;
											}
											continue;
										}
										IL_2F4:
										num = (short)640745474;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_2EF:
										goto IL_2F4;
										IL_410:
										num = (short)1277493251;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_4BC:
										num = (short)1726152704;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_39B:
									memoryStream.WriteByte(0);
									memoryStream.WriteByte((byte)((question.QTYPE & 65280) >> 8));
									memoryStream.WriteByte((byte)(question.QTYPE & 255));
									memoryStream.WriteByte((byte)((question.QClass & 65280) >> 8));
									memoryStream.WriteByte((byte)(question.QClass & 255));
									num = (short)1146159116;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_517:;
							}
							return (int)memoryStream.Position;
						}
						finally
						{
							num = (short)1880489985;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_59D;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_567;
									}
									continue;
								case 2:
									memoryStream.Dispose();
									num = (short)1068171264;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_567:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)313262082;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_59D:;
						}
						goto IL_5A0;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5B;
						}
						continue;
					case 2:
						goto IL_78;
					}
					IL_5B:
					if (sendBuffer == null)
					{
						num = (short)491716610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_5A0:
					memoryStream = new global::System.IO.MemoryStream(sendBuffer, 0, sendBuffer.Length, true);
					num = (short)1957756928;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_78:
				num = (short)422510593;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.Message.PCRDnsResponseMessage.b("鷾琀攂挄戆笈", a_));
			}
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00008D44 File Offset: 0x00006F44
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			int a_ = 18;
			short num = (short)2039939074;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1952907264;
					short num3 = num;
					if (replyBuffer.Length < global::Motorola.Common.Communication.DnsConfigConstants.DNS_BODY_START_INDEX)
					{
						num = (short)1313210369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11F;
				}
				case 1:
				{
					num = (short)1409684873;
					short num4 = num;
					num = (short)1667306889;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5D;
					default:
						goto IL_F1;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3F;
					}
					continue;
				case 3:
					goto IL_57;
				}
				IL_3F:
				if (replyBuffer == null)
				{
					num = (short)107085827;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5D:
				num = (short)1743847424;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_57:
			throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.Message.PCRDnsResponseMessage.b("猐昒猔焖簘椚", a_));
			IL_F1:
			num = (short)340525056;
			if (num != 0)
			{
			}
			return;
			IL_11F:
			num = (short)1297088513;
			if (num != 0)
			{
			}
			this.a(replyBuffer);
			this.a(replyBuffer, global::Motorola.Common.Communication.DnsConfigConstants.DNS_BODY_START_INDEX, length);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00008EAC File Offset: 0x000070AC
		private void a(byte[] A_0, int A_1, int A_2)
		{
			short num = (short)2034630656;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				int num4;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_8B;
					case 1:
						goto IL_25B;
					case 2:
					{
						int num3 = 0;
						num = (short)366542852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (num4 >= (int)base.Header.QDCOUNT)
						{
							num = (short)64880648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(A_0, ref A_1);
						num4++;
						num = (short)855244810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_215;
					case 5:
					{
						int num5;
						if (num5 >= (int)base.Header.ANCOUNT)
						{
							num = (short)1693188105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.ResolveResourceRecord(A_0, ref A_1, 0);
						num5++;
						num = (short)1646198795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						int num3;
						if (num3 >= (int)base.Header.ARCOUNT)
						{
							num = (short)1777532941;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)758191021;
						short num6 = num;
						num = (short)684528557;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8B;
						default:
							num = (short)95879168;
							if (num != 0)
							{
							}
							this.ResolveResourceRecord(A_0, ref A_1, 2);
							num3++;
							num = (short)1271332879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
					{
						int num7;
						if (num7 >= (int)base.Header.NSCOUNT)
						{
							num = (short)808779777;
							if (num != 0)
							{
							}
							num = (short)1426980866;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)337575936;
						short num8 = num;
						this.ResolveResourceRecord(A_0, ref A_1, 1);
						num7++;
						num = (short)19857408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						int num5 = 0;
						num = (short)130809857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						int num7 = 0;
						num = (short)1478033420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_113;
					case 11:
						goto IL_25B;
					case 12:
						goto IL_8B;
					case 13:
						return;
					case 14:
						goto IL_113;
					case 15:
						goto IL_215;
					}
					goto IL_6E;
					IL_8B:
					num = (short)716439559;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_113:
					num = (short)372572163;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_215:
					num = (short)1040973830;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25B:
					num = (short)634847237;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_6E:
				num4 = 0;
				num = (short)1236860942;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000091FC File Offset: 0x000073FC
		private void a(byte[] A_0)
		{
			short num = (short)1416291748;
			short num2 = num;
			num = (short)40101284;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1643511808;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)587137024;
			if (num != 0)
			{
			}
			num = (short)350617601;
			if (num != 0)
			{
			}
			base.Header.ID = ((ushort)(A_0[0] << 8) | (ushort)A_0[1]);
			base.Header.QR = (A_0[2] & 128);
			base.Header.OPCODE = (A_0[2] & 120);
			base.Header.AA = (A_0[2] & 4);
			base.Header.TC = (A_0[2] & 2);
			base.Header.RD = (A_0[2] & 1);
			base.Header.RA = (A_0[3] & 128);
			base.Header.Z = (A_0[3] & 112);
			base.Header.RCODE = (A_0[3] & 15);
			base.Header.QDCOUNT = ((ushort)(A_0[4] << 8) | (ushort)A_0[5]);
			base.Header.ANCOUNT = ((ushort)(A_0[6] << 8) | (ushort)A_0[7]);
			base.Header.NSCOUNT = ((ushort)(A_0[8] << 8) | (ushort)A_0[9]);
			base.Header.ARCOUNT = ((ushort)(A_0[10] << 8) | (ushort)A_0[11]);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000093AC File Offset: 0x000075AC
		private string a(byte[] A_0, int A_1)
		{
			int a_ = 1;
			short num = (short)1367539712;
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
				string text;
				for (;;)
				{
					IL_30:
					string str;
					byte[] array;
					switch (num2)
					{
					case 0:
					{
						int num3 = (int)(A_0[A_1] & 15) << 8;
						int num4 = (int)A_0[++A_1];
						str = this.a(A_0, num3 + num4);
						num = (short)2079326218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)892362592;
						short num5 = num;
						num = (short)587095904;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_324;
						default:
							num = (short)1683292160;
							if (num != 0)
							{
							}
							num = (short)28835848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_395;
					case 3:
						text += global::Motorola.Common.Communication.Message.PCRDnsResponseMessage.b("⻿", a_);
						num = (short)697434117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						text += global::Motorola.Common.Communication.Message.PCRDnsResponseMessage.b("⻿", a_);
						num = (short)1466892290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_1E3;
					case 6:
					{
						int num6;
						byte b;
						if (num6 >= (int)b)
						{
							num = (short)1655898113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[num6] = A_0[++A_1];
						num6++;
						num = (short)1330118669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (A_0[A_1] == 0)
						{
							num = (short)3145742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1473904656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (text.Length > 0)
						{
							num = (short)967507971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E3;
					case 9:
						goto IL_324;
					case 10:
						if (text.Length > 0)
						{
							num = (short)182124548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_395;
					case 11:
						return text;
					case 12:
						goto IL_2BD;
					case 13:
						goto IL_355;
					case 14:
						return text;
					case 15:
						goto IL_2BD;
					case 16:
					{
						if ((A_0[A_1] & 192) == 192)
						{
							num = (short)560201729;
							if (num != 0)
							{
							}
							num = (short)1406074880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = A_0[A_1];
						array = new byte[(int)b];
						int num6 = 0;
						num = (short)737738761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_7B;
					IL_1E3:
					text += global::System.Text.Encoding.ASCII.GetString(array);
					A_1++;
					num = (short)1291386892;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BD:
					num = (short)1099104263;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_355:
					num = (short)1087111174;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_324:
					goto IL_355;
					IL_395:
					text += str;
					num = (short)1002504203;
					num2 = (int)((global::System.IntPtr)num);
				}
				return text;
				IL_7B:
				text = "";
				num = (short)211550208;
				short num7 = num;
				num = (short)1409810447;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00009774 File Offset: 0x00007974
		private void a(byte[] A_0, ref int A_1)
		{
			int a_ = 5;
			short num = (short)594214912;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_99;
				}
				string text;
				int num4;
				for (;;)
				{
					IL_32:
					string str;
					byte[] array2;
					string str2;
					switch (num2)
					{
					case 0:
						if (text.Length > 0)
						{
							num = (short)88342537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_161;
					case 1:
						goto IL_1F1;
					case 2:
						goto IL_354;
					case 3:
						num = (short)1157300225;
						if (num != 0)
						{
						}
						if (text.Length > 0)
						{
							num = (short)1587085328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E8;
					case 4:
						goto IL_393;
					case 5:
					{
						int num3 = (int)(A_0[A_1] & 15) << 8;
						num4 = A_1 + 1;
						A_1 = num4;
						int num5 = (int)A_0[num4];
						str = this.a(A_0, num3 + num5);
						num = (short)1139671040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (A_0[A_1] != 0)
						{
							num = (short)1609302037;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_51C;
					case 7:
					{
						num = (short)280985865;
						short num6 = num;
						num = (short)2110161161;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_393;
						default:
						{
							num = (short)52690944;
							if (num != 0)
							{
							}
							int num7;
							byte b;
							if (num7 >= (int)b)
							{
								num = (short)602275853;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte[] array = array2;
							int num8 = num7;
							num4 = A_1 + 1;
							A_1 = num4;
							array[num8] = A_0[num4];
							num7++;
							num = (short)368181249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 8:
						goto IL_2E8;
					case 9:
						text += global::Motorola.Common.Communication.Message.PCRDnsResponseMessage.b("⨃", a_);
						num = (short)733872145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						int num9 = (int)(A_0[A_1] & 15) << 8;
						num4 = A_1 + 1;
						A_1 = num4;
						int num10 = (int)A_0[num4];
						str2 = this.a(A_0, num9 + num10);
						num = (short)981204995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_2E3;
					case 12:
					{
						if ((A_0[A_1] & 192) == 192)
						{
							num = (short)1643118602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = A_0[A_1];
						array2 = new byte[(int)b];
						int num7 = 0;
						num = (short)1829830675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						num = (short)1379467279;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_189;
					case 15:
						if (text.Length > 0)
						{
							num = (short)1260060676;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_189;
					case 16:
						text += global::Motorola.Common.Communication.Message.PCRDnsResponseMessage.b("⨃", a_);
						num = (short)1663893512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_161;
					case 18:
						goto IL_309;
					case 19:
						goto IL_1F1;
					case 20:
						goto IL_184;
					case 21:
					{
						num = (short)1578041344;
						short num11 = num;
						num = (short)918290455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						if ((A_0[A_1] & 192) == 192)
						{
							num = (short)1042743301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_354;
					case 23:
						if ((long)A_1 >= (long)A_0.Length)
						{
							num = (short)2003173387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1847721996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_99;
					IL_161:
					text += str;
					num = (short)1779171348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_189:
					text += global::System.Text.Encoding.ASCII.GetString(array2);
					A_1++;
					num = (short)534118402;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F1:
					num = (short)421134343;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E8:
					text += str2;
					num = (short)2140078098;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_354:
					num = (short)1261699078;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_393:
					text += global::Motorola.Common.Communication.Message.PCRDnsResponseMessage.b("⨃", a_);
					num = (short)1956642830;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_184:
				IL_2E3:
				IL_309:
				IL_51C:
				global::Motorola.Common.Communication.Question question = new global::Motorola.Common.Communication.Question();
				question.QNAME = text;
				global::Motorola.Common.Communication.Question question2 = question;
				num4 = A_1 + 1;
				A_1 = num4;
				byte b2 = (byte)((ushort)(A_0[num4] << 8));
				num4 = A_1 + 1;
				A_1 = num4;
				question2.QTYPE = (ushort)(b2 | A_0[num4]);
				global::Motorola.Common.Communication.Question question3 = question;
				num4 = A_1 + 1;
				A_1 = num4;
				byte b3 = (byte)((ushort)(A_0[num4] << 8));
				num4 = A_1 + 1;
				A_1 = num4;
				question3.QClass = (ushort)(b3 | A_0[num4]);
				A_1++;
				base.Questions.Add(question);
				return;
				IL_99:
				text = "";
				num = (short)1377435670;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00009D0C File Offset: 0x00007F0C
		private void a(global::Motorola.Common.Communication.ResourceRecord A_0, int A_1)
		{
			short num = (short)1615921153;
			if (num != 0)
			{
			}
			num = (short)1404766814;
			short num2 = num;
			num = (short)2013989470;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)336723968;
				if (num != 0)
				{
				}
				switch (A_1)
				{
				case 0:
					base.Answers.Add(A_0);
					return;
				case 1:
					base.Authorities.Add(A_0);
					return;
				case 2:
					base.Additionals.Add(A_0);
					return;
				}
				break;
			}
			num = (short)1998061568;
			short num3 = num;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00009DF0 File Offset: 0x00007FF0
		protected virtual void ResolveResourceRecord(byte[] bytes, ref int ind, int recordType)
		{
			int a_ = 0;
			short num = (short)537985024;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_FB;
				}
				string text;
				for (;;)
				{
					IL_30:
					ushort num3;
					int num5;
					byte[] array;
					string str2;
					switch (num2)
					{
					case 0:
						goto IL_330;
					case 1:
						if ((long)ind >= (long)bytes.Length)
						{
							num = (short)672333824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2005729306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_390;
					case 3:
						num = (short)720919;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (num3 != 41)
						{
							num = (short)564723746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.RecordOPT recordOPT = new global::Motorola.Common.Communication.RecordOPT();
						recordOPT.NAME = text;
						recordOPT.TYPE = num3;
						this.a(bytes, ref ind, recordOPT);
						this.a(recordOPT, recordType);
						num = (short)1815871495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						if (num3 != 1)
						{
							num = (short)1297547304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.RecordA recordA = new global::Motorola.Common.Communication.RecordA();
						recordA.NAME = text;
						recordA.TYPE = num3;
						this.a(bytes, ref ind, recordA);
						this.a(recordA, recordType);
						num = (short)1564868622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)1908801537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_9BE;
					case 8:
						goto IL_330;
					case 9:
						if (num3 <= 16)
						{
							num = (short)1544421401;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1808269329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1630011396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_3FA;
					case 12:
						num = (short)1123680289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_647;
					case 14:
						goto IL_770;
					case 15:
						text += global::Motorola.Common.Communication.Message.PCRDnsResponseMessage.b("퇾", a_);
						num = (short)1893597186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						if (num3 != 16)
						{
							num = (short)1148321820;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.RecordTXT recordTXT = new global::Motorola.Common.Communication.RecordTXT();
						recordTXT.NAME = text;
						recordTXT.TYPE = num3;
						this.a(bytes, ref ind, recordTXT);
						this.a(recordTXT, recordType);
						num = (short)811728915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						if (num3 != 28)
						{
							num = (short)1424162828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.RecordAAA recordAAA = new global::Motorola.Common.Communication.RecordAAA();
						recordAAA.NAME = text;
						recordAAA.TYPE = num3;
						this.a(bytes, ref ind, recordAAA);
						this.a(recordAAA, recordType);
						num = (short)592314379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						text += global::Motorola.Common.Communication.Message.PCRDnsResponseMessage.b("퇾", a_);
						num = (short)393609254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_5F2;
					case 20:
						if (text.Length > 0)
						{
							num = (short)1291059218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_614;
					case 21:
					{
						int num4 = (int)(bytes[ind] & 15) << 8;
						num5 = ind + 1;
						ind = num5;
						int num6 = (int)bytes[num5];
						string str = this.a(bytes, num4 + num6);
						num = (short)703660056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_32B;
					case 23:
						if ((bytes[ind] & 192) == 192)
						{
							num = (short)1962934293;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_647;
					case 24:
						if (text.Length > 0)
						{
							num = (short)1752498176;
							short num7 = num;
							num = (short)1277362222;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_237;
					case 25:
						num = (short)399441925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						if ((bytes[ind] & 192) == 192)
						{
							num = (short)2056192030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = bytes[ind];
						array = new byte[(int)b];
						int num8 = 0;
						num = (short)582746159;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						if (text.Length > 0)
						{
							num = (short)721223695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_390;
					case 28:
						num = (short)804519968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						num = (short)387383297;
						if (num != 0)
						{
						}
						if (num3 != 12)
						{
							num = (short)966852644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.RecordPTR recordPTR = new global::Motorola.Common.Communication.RecordPTR();
						recordPTR.NAME = text;
						recordPTR.TYPE = num3;
						this.a(bytes, ref ind, recordPTR);
						this.a(recordPTR, recordType);
						num = (short)1360789535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
					{
						int num9 = (int)(bytes[ind] & 15) << 8;
						num5 = ind + 1;
						ind = num5;
						int num10 = (int)bytes[num5];
						str2 = this.a(bytes, num9 + num10);
						num = (short)1006305307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						goto IL_232;
					case 32:
						goto IL_3FF;
					case 33:
					{
						if (num3 != 33)
						{
							num = (short)1755447306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.RecordSRV recordSRV = new global::Motorola.Common.Communication.RecordSRV();
						recordSRV.NAME = text;
						recordSRV.TYPE = num3;
						this.a(bytes, ref ind, recordSRV);
						this.a(recordSRV, recordType);
						num = (short)883752982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						num = (short)422117417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (bytes[ind] != 0)
						{
							num = (short)1584922627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_330;
					case 36:
						num = (short)501940240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_330;
					case 38:
						IL_474:
						goto IL_614;
					case 39:
						goto IL_441;
					case 40:
						num = (short)1789591581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						goto IL_3FF;
					case 42:
						goto IL_6C3;
					case 43:
						if (bytes[ind] != 0)
						{
							num = (short)1367736326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_330;
					case 44:
						num = (short)475660308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
					{
						byte b;
						int num8;
						if (num8 >= (int)b)
						{
							num = (short)576716844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array2 = array;
						int num11 = num8;
						num5 = ind + 1;
						ind = num5;
						array2[num11] = bytes[num5];
						num8++;
						num = (short)1129185322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 46:
						text += global::Motorola.Common.Communication.Message.PCRDnsResponseMessage.b("퇾", a_);
						num = (short)1159462960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						goto IL_6C3;
					case 48:
						goto IL_237;
					}
					goto IL_FB;
					IL_237:
					num = (short)117369059;
					short num12 = num;
					num = (short)199485667;
					switch ((num12 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_474;
					default:
					{
						num = (short)408616960;
						if (num != 0)
						{
						}
						string str;
						text += str;
						num = (short)1930166309;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_330:
					num5 = ind + 1;
					ind = num5;
					byte b2 = (byte)((ushort)(bytes[num5] << 8));
					num5 = ind + 1;
					ind = num5;
					num3 = (ushort)(b2 | bytes[num5]);
					num = (short)1142947849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_390:
					text += str2;
					num = (short)746258440;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FF:
					global::Motorola.Common.Communication.ResourceRecord resourceRecord = new global::Motorola.Common.Communication.ResourceRecord();
					resourceRecord.NAME = text;
					resourceRecord.TYPE = num3;
					this.a(bytes, ref ind, resourceRecord);
					this.a(resourceRecord, recordType);
					num = (short)241434663;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_614:
					text += global::System.Text.Encoding.ASCII.GetString(array);
					ind++;
					num = (short)590938125;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_647:
					num = (short)2099839019;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C3:
					num = (short)1513488429;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_232:
				IL_32B:
				IL_3FA:
				IL_441:
				IL_5F2:
				IL_770:
				IL_9BE:
				ind++;
				return;
				IL_FB:
				text = "";
				num = (short)953024547;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000A7C4 File Offset: 0x000089C4
		private void a(byte[] A_0, ref int A_1, global::Motorola.Common.Communication.RecordPTR A_2)
		{
			short num = (short)1780940800;
			short num2 = num;
			num = (short)930815605;
			short num3 = num;
			num = (short)337911413;
			switch (num3 == num)
			{
			}
			num = (short)1925971969;
			if (num != 0)
			{
			}
			num = (short)193527808;
			if (num != 0)
			{
			}
			int num4 = A_1 + 1;
			A_1 = num4;
			byte b = (byte)(A_0[num4] << 8);
			num4 = A_1 + 1;
			A_1 = num4;
			A_2.CLASS = (ushort)(b | A_0[num4]);
			num4 = A_1 + 1;
			A_1 = num4;
			uint num5 = (uint)((uint)A_0[num4] << 24);
			num4 = A_1 + 1;
			A_1 = num4;
			uint num6 = num5 | (uint)((uint)A_0[num4] << 16);
			num4 = A_1 + 1;
			A_1 = num4;
			uint num7 = num6 | (uint)((uint)A_0[num4] << 8);
			num4 = A_1 + 1;
			A_1 = num4;
			A_2.TTL = (num7 | (uint)A_0[num4]);
			num4 = A_1 + 1;
			A_1 = num4;
			byte b2 = (byte)(A_0[num4] << 8);
			num4 = A_1 + 1;
			A_1 = num4;
			A_2.RDLENGTH = (ushort)(b2 | A_0[num4]);
			string domainName = this.a(A_0, A_1 + 1);
			A_2.DomainName = domainName;
			A_1 += (int)A_2.RDLENGTH;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000A90C File Offset: 0x00008B0C
		private void a(byte[] A_0, ref int A_1, global::Motorola.Common.Communication.RecordA A_2)
		{
			byte[] array;
			for (;;)
			{
				short num = (short)1501888512;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					for (;;)
					{
						IL_27:
						num = (short)1911029760;
						short num3 = num;
						switch (num2)
						{
						case 0:
						{
							int num4;
							if (num4 >= (int)A_2.RDLENGTH)
							{
								num = (short)1534197763;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array[num4] = A_0[A_1 + num4 + 1];
							num4++;
							num = (short)1997340673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_17F;
						case 2:
							goto IL_17F;
						case 3:
							goto IL_1BC;
						}
						break;
						IL_17F:
						num = (short)2101084160;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_67:
					num = (short)1229043895;
					short num5 = num;
					num = (short)417642679;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1638334464;
						if (num != 0)
						{
						}
						num = (short)783482881;
						if (num != 0)
						{
						}
						int num6 = A_1 + 1;
						A_1 = num6;
						byte b = (byte)(A_0[num6] << 8);
						num6 = A_1 + 1;
						A_1 = num6;
						A_2.CLASS = (ushort)(b | A_0[num6]);
						num6 = A_1 + 1;
						A_1 = num6;
						uint num7 = (uint)((uint)A_0[num6] << 24);
						num6 = A_1 + 1;
						A_1 = num6;
						uint num8 = num7 | (uint)((uint)A_0[num6] << 16);
						num6 = A_1 + 1;
						A_1 = num6;
						uint num9 = num8 | (uint)((uint)A_0[num6] << 8);
						num6 = A_1 + 1;
						A_1 = num6;
						A_2.TTL = (num9 | (uint)A_0[num6]);
						num6 = A_1 + 1;
						A_1 = num6;
						byte b2 = (byte)(A_0[num6] << 8);
						num6 = A_1 + 1;
						A_1 = num6;
						A_2.RDLENGTH = (ushort)(b2 | A_0[num6]);
						array = new byte[(int)A_2.RDLENGTH];
						int num4 = 0;
						num = (short)1228537858;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_27;
					}
					}
					break;
				}
				}
			}
			IL_1BC:
			global::System.Net.IPAddress ipaddress = new global::System.Net.IPAddress((long)((ulong)global::System.BitConverter.ToUInt32(array, 0)));
			A_2.IP = ipaddress.ToString();
			A_1 += (int)A_2.RDLENGTH;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000AB28 File Offset: 0x00008D28
		private void a(byte[] A_0, ref int A_1, global::Motorola.Common.Communication.RecordTXT A_2)
		{
			short num = (short)1755250688;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_92;
				}
				int num4;
				ushort num5;
				for (;;)
				{
					IL_27:
					num = (short)2117664769;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						string[] array;
						if (array.Length == 2)
						{
							num = (short)584712206;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A4;
					}
					case 1:
					{
						ushort num3;
						A_1 += (int)num3;
						num = (short)1718419461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_175;
					case 3:
						goto IL_17A;
					case 4:
						return;
					case 5:
						goto IL_264;
					case 6:
						goto IL_343;
					case 7:
					{
						string[] array2;
						if (num4 >= array2.Length)
						{
							num = (short)947257345;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array = array2[num4].Split(new char[]
						{
							'='
						});
						num = (short)325386240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_343;
					case 9:
					{
						byte[] array3;
						string[] array2 = global::System.Text.Encoding.ASCII.GetString(array3).Split(new char[]
						{
							';'
						});
						num4 = 0;
						num = (short)1460731907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						if (num5 >= A_2.RDLENGTH)
						{
							num = (short)1522008068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = A_1 + 1;
						A_1 = num4;
						ushort num3 = (ushort)A_0[num4];
						num5 += 1;
						num5 += num3;
						byte[] array3 = new byte[(int)num3];
						int num6 = 0;
						num = (short)879362054;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_2A4;
					case 12:
						goto IL_17A;
					case 13:
					{
						ushort num3;
						int num6;
						if (num6 >= (int)num3)
						{
							num = (short)560988169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1422196736;
						short num7 = num;
						byte[] array3;
						array3[num6] = A_0[A_1 + 1 + num6];
						num6++;
						num = (short)102760456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						string[] array;
						A_2.Txts.Add(array[0], array[1]);
						num = (short)454426635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_92;
					IL_17A:
					num = (short)736362503;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A4:
					num4++;
					num = (short)400031756;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_343:
					num = (short)37617677;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_175:
				goto IL_2C5;
				IL_92:
				num4 = A_1 + 1;
				A_1 = num4;
				byte b = (byte)(A_0[num4] << 8);
				num4 = A_1 + 1;
				A_1 = num4;
				A_2.CLASS = (ushort)(b | A_0[num4]);
				num4 = A_1 + 1;
				A_1 = num4;
				uint num8 = (uint)((uint)A_0[num4] << 24);
				num4 = A_1 + 1;
				A_1 = num4;
				uint num9 = num8 | (uint)((uint)A_0[num4] << 16);
				num4 = A_1 + 1;
				A_1 = num4;
				uint num10 = num9 | (uint)((uint)A_0[num4] << 8);
				num4 = A_1 + 1;
				A_1 = num4;
				A_2.TTL = (num10 | (uint)A_0[num4]);
				num4 = A_1 + 1;
				A_1 = num4;
				byte b2 = (byte)(A_0[num4] << 8);
				num4 = A_1 + 1;
				A_1 = num4;
				A_2.RDLENGTH = (ushort)(b2 | A_0[num4]);
				num5 = 0;
				num = (short)551768537;
				short num11 = num;
				num = (short)1422283225;
				switch ((num11 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_264:
					break;
				default:
					num = (short)1005584384;
					if (num != 0)
					{
					}
					num = (short)613089282;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				IL_2C5:
				num = (short)793313290;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000AF08 File Offset: 0x00009108
		private void a(byte[] A_0, ref int A_1, global::Motorola.Common.Communication.RecordAAA A_2)
		{
			byte[] array;
			for (;;)
			{
				IL_00:
				short num = (short)1822359552;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_8C;
					}
					int num4;
					for (;;)
					{
						IL_29:
						num = (short)1463749098;
						short num3 = num;
						num = (short)804981226;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)2115436544;
							if (num != 0)
							{
							}
							switch (num2)
							{
							case 0:
								goto IL_132;
							case 1:
							{
								if (num4 >= (int)A_2.RDLENGTH)
								{
									num = (short)548995074;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								array[num4] = A_0[A_1 + num4 + 1];
								num4++;
								num = (short)1711013888;
								short num5 = num;
								num = (short)1730740227;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_16C;
							case 3:
								num = (short)338165761;
								if (num != 0)
								{
								}
								goto IL_132;
							}
							goto IL_8C;
							IL_132:
							num = (short)1942814721;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_8C:
					int num6 = A_1 + 1;
					A_1 = num6;
					byte b = (byte)(A_0[num6] << 8);
					num6 = A_1 + 1;
					A_1 = num6;
					A_2.CLASS = (ushort)(b | A_0[num6]);
					num6 = A_1 + 1;
					A_1 = num6;
					uint num7 = (uint)((uint)A_0[num6] << 24);
					num6 = A_1 + 1;
					A_1 = num6;
					uint num8 = num7 | (uint)((uint)A_0[num6] << 16);
					num6 = A_1 + 1;
					A_1 = num6;
					uint num9 = num8 | (uint)((uint)A_0[num6] << 8);
					num6 = A_1 + 1;
					A_1 = num6;
					A_2.TTL = (num9 | (uint)A_0[num6]);
					num6 = A_1 + 1;
					A_1 = num6;
					byte b2 = (byte)(A_0[num6] << 8);
					num6 = A_1 + 1;
					A_1 = num6;
					A_2.RDLENGTH = (ushort)(b2 | A_0[num6]);
					array = new byte[(int)A_2.RDLENGTH];
					num4 = 0;
					num = (short)1803878400;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_29;
				}
				}
			}
			IL_16C:
			global::System.BitConverter.ToUInt32(array, 0);
			global::System.Net.IPAddress ipaddress = new global::System.Net.IPAddress(array);
			A_2.IPV6 = ipaddress.ToString();
			A_1 += (int)A_2.RDLENGTH;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000B130 File Offset: 0x00009330
		private void a(byte[] A_0, ref int A_1, global::Motorola.Common.Communication.RecordSRV A_2)
		{
			short num = (short)1801060353;
			if (num != 0)
			{
			}
			num = (short)1614343438;
			short num2 = num;
			num = (short)1104080142;
			switch (num2 == num)
			{
			default:
			{
				num = (short)536870912;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1466040320;
			if (num != 0)
			{
			}
			int num4 = A_1 + 1;
			A_1 = num4;
			byte b = (byte)(A_0[num4] << 8);
			num4 = A_1 + 1;
			A_1 = num4;
			A_2.CLASS = (ushort)(b | A_0[num4]);
			num4 = A_1 + 1;
			A_1 = num4;
			uint num5 = (uint)((uint)A_0[num4] << 24);
			num4 = A_1 + 1;
			A_1 = num4;
			uint num6 = num5 | (uint)((uint)A_0[num4] << 16);
			num4 = A_1 + 1;
			A_1 = num4;
			uint num7 = num6 | (uint)((uint)A_0[num4] << 8);
			num4 = A_1 + 1;
			A_1 = num4;
			A_2.TTL = (num7 | (uint)A_0[num4]);
			num4 = A_1 + 1;
			A_1 = num4;
			byte b2 = (byte)(A_0[num4] << 8);
			num4 = A_1 + 1;
			A_1 = num4;
			A_2.RDLENGTH = (ushort)(b2 | A_0[num4]);
			num4 = A_1 + 1;
			A_1 = num4;
			byte b3 = (byte)(A_0[num4] << 8);
			num4 = A_1 + 1;
			A_1 = num4;
			A_2.Priority = (ushort)(b3 | A_0[num4]);
			num4 = A_1 + 1;
			A_1 = num4;
			byte b4 = (byte)(A_0[num4] << 8);
			num4 = A_1 + 1;
			A_1 = num4;
			A_2.Weight = (ushort)(b4 | A_0[num4]);
			num4 = A_1 + 1;
			A_1 = num4;
			byte b5 = (byte)(A_0[num4] << 8);
			num4 = A_1 + 1;
			A_1 = num4;
			A_2.Port = (ushort)(b5 | A_0[num4]);
			A_2.Target = this.a(A_0, A_1 + 1);
			A_1 += (int)(A_2.RDLENGTH - 6);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000B2D4 File Offset: 0x000094D4
		private void a(byte[] A_0, ref int A_1, global::Motorola.Common.Communication.RecordOPT A_2)
		{
			short num = (short)1406179158;
			short num2 = num;
			num = (short)2056099670;
			switch (num2 == num)
			{
			}
			num = (short)1867972608;
			short num3 = num;
			num = (short)1457455105;
			if (num != 0)
			{
			}
			num = (short)142671872;
			if (num != 0)
			{
			}
			A_2.CacheFlush = (A_0[A_1 + 1] & 128);
			int num4 = A_1 + 1;
			A_1 = num4;
			byte b = (byte)((A_0[num4] & 127) << 8);
			num4 = A_1 + 1;
			A_1 = num4;
			A_2.UDPPayloadSize = (ushort)(b | A_0[num4]);
			num4 = A_1 + 1;
			A_1 = num4;
			A_2.ExtendedRCODE = A_0[num4];
			num4 = A_1 + 1;
			A_1 = num4;
			A_2.EDNS0Version = A_0[num4];
			num4 = A_1 + 1;
			A_1 = num4;
			byte b2 = (byte)(A_0[num4] << 8);
			num4 = A_1 + 1;
			A_1 = num4;
			A_2.Z = (ushort)(b2 | A_0[num4]);
			num4 = A_1 + 1;
			A_1 = num4;
			byte b3 = (byte)(A_0[num4] << 8);
			num4 = A_1 + 1;
			A_1 = num4;
			A_2.RDLENGTH = (ushort)(b3 | A_0[num4]);
			A_1 += (int)A_2.RDLENGTH;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000B424 File Offset: 0x00009624
		private void a(byte[] A_0, ref int A_1, global::Motorola.Common.Communication.ResourceRecord A_2)
		{
			short num = (short)436728390;
			short num2 = num;
			num = (short)1423569478;
			switch (num2 == num)
			{
			}
			num = (short)181600256;
			short num3 = num;
			num = (short)1144913921;
			if (num != 0)
			{
			}
			num = (short)57016320;
			if (num != 0)
			{
			}
			int num4 = A_1 + 1;
			A_1 = num4;
			byte b = (byte)(A_0[num4] << 8);
			num4 = A_1 + 1;
			A_1 = num4;
			A_2.CLASS = (ushort)(b | A_0[num4]);
			num4 = A_1 + 1;
			A_1 = num4;
			uint num5 = (uint)((uint)A_0[num4] << 24);
			num4 = A_1 + 1;
			A_1 = num4;
			uint num6 = num5 | (uint)((uint)A_0[num4] << 16);
			num4 = A_1 + 1;
			A_1 = num4;
			uint num7 = num6 | (uint)((uint)A_0[num4] << 8);
			num4 = A_1 + 1;
			A_1 = num4;
			A_2.TTL = (num7 | (uint)A_0[num4]);
			num4 = A_1 + 1;
			A_1 = num4;
			byte b2 = (byte)(A_0[num4] << 8);
			num4 = A_1 + 1;
			A_1 = num4;
			A_2.RDLENGTH = (ushort)(b2 | A_0[num4]);
			A_1 += (int)A_2.RDLENGTH;
		}
	}
}
