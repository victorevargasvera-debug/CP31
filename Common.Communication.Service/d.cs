using System;
using System.Collections.Generic;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x02000006 RID: 6
	internal class d : global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.Service.d>, global::System.IDisposable
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00004724 File Offset: 0x00002924
		public void b(global::Motorola.Common.Communication.Service.b A_0)
		{
			int a_ = 19;
			short num;
			for (;;)
			{
				num = (short)199426049;
				if (num != 0)
				{
				}
				this.a.EnterWriteLock();
				try
				{
					this.b[A_0.w()] = A_0;
					global::System.Console.ForegroundColor = global::System.ConsoleColor.Green;
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("얔ﾚ욠莢힦첨\ud9aa첬\udbae\ud8b0\udcb2\udbb4쒶馸諸\ud9bc\udbbe꓀Ꟃ﯆니﯊냌꣒꫖", a_), new object[]
					{
						A_0.r(),
						A_0.w()
					});
					global::System.Console.ResetColor();
					A_0.ai();
				}
				finally
				{
					this.a.ExitWriteLock();
				}
				num = (short)792216522;
				short num2 = num;
				num = (short)974209994;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_D3;
				}
			}
			IL_D3:
			num = (short)1737555968;
			if (num != 0)
			{
			}
			num = (short)1849491456;
			short num3 = num;
			global::System.Threading.ThreadPool.QueueUserWorkItem(new global::System.Threading.WaitCallback(this.a), A_0);
			int num4;
			int num5;
			global::System.Threading.ThreadPool.GetMaxThreads(out num4, out num5);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00004870 File Offset: 0x00002A70
		public static object a(global::System.IAsyncResult A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			global::Motorola.Common.CustomException.CommonException ex;
			short num2;
			global::Motorola.Common.Communication.Service.b b;
			object result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (ex == null)
					{
						num2 = (short)1463943170;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11F;
				case 1:
					ex = (b.u() as global::Motorola.Common.CustomException.CommonException);
					num2 = (short)1587281920;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					ex = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, b.u());
					num2 = (short)1385955334;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
					if (b.u() != null)
					{
						num2 = (short)1996226561;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A3;
				case 5:
					if (b.x() != global::Motorola.Common.Communication.Service.a.e)
					{
						num2 = (short)105709568;
						short num3 = num2;
						num2 = (short)2082799623;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 6:
					goto IL_167;
				case 7:
					num2 = (short)1917583361;
					if (num2 != 0)
					{
					}
					num2 = (short)1175257092;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
			}
			IL_11F:
			global::System.Console.ForegroundColor = global::System.ConsoleColor.Red;
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(ex.ToString(), global::System.Array.Empty<object>());
			global::System.Console.ResetColor();
			throw ex;
			IL_167:
			goto IL_11F;
			IL_1A3:
			result = b.s();
			b.Dispose();
			goto IL_1B0;
			IL_30:
			num2 = (short)1418740108;
			short num4 = num2;
			num2 = (short)1734492556;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1B0:
				num2 = (short)1306918915;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)643891200;
				if (num2 != 0)
				{
				}
				b = (A_0 as global::Motorola.Common.Communication.Service.b);
				b.AsyncWaitHandle.WaitOne();
				result = null;
				num2 = (short)354484229;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00004A90 File Offset: 0x00002C90
		private void a(object A_0)
		{
			int a_ = 11;
			short num = (short)1328873472;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				global::Motorola.Common.Communication.Service.b b;
				string text;
				string text2;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						try
						{
							this.b(b.w());
							this.a(b);
							try
							{
								b.aj();
								b.an();
							}
							catch (global::System.Exception a_2)
							{
								b.v(a_2);
							}
							finally
							{
								b.am();
								this.a(b.w());
							}
							goto IL_224;
						}
						catch (global::System.Exception a_3)
						{
							b.v(a_3);
							goto IL_224;
						}
						return;
					case 1:
						goto IL_26F;
					case 2:
						try
						{
							num = (short)560594947;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_213;
								case 1:
									if (this.b.ContainsKey(b.w()))
									{
										num = (short)484552347;
										short num3 = num;
										num = (short)196390555;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)539164672;
											if (num != 0)
											{
											}
											num = (short)380436480;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									num = (short)43319298;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_124;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_103;
									}
									continue;
								case 4:
									goto IL_162;
								case 5:
									num = (short)105709569;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_103:
								if (b.x() != global::Motorola.Common.Communication.Service.a.e)
								{
									num = (short)440926213;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_124:
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("\udd8cﾐﲔ練ﺘ뮚튜쒠톢쒤펦삨쒪쎬\udcae醰풴\udbb6햸\ud9ba\udcbc\udcbeꫀ评꣆뷈軌껎뷐뿒냔돖律黚돜믞蓠蟢엤", a_) + b.w(), global::System.Array.Empty<object>());
								num = (short)990380036;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_162:
							return;
							IL_213:
							goto IL_A4;
						}
						finally
						{
							this.a.ExitReadLock();
						}
						goto IL_224;
						IL_A4:
						num = (short)1153040384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_44;
					IL_224:
					global::System.Console.ForegroundColor = global::System.ConsoleColor.Green;
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("\udd8cﾐﲔ練ﺘ뮚튜쒠톢쒤펦삨쒪쎬\udcae醰풴\udbb6햸\ud9ba\udcbc\udcbeꫀ蛄ꛆꗈꟊ꣌ꯎ雒믔돖볘뿚﷜髠폢飤\ud9e6헨郪\udcec鋮쿰", a_), new object[]
					{
						text,
						text2
					});
					global::System.Console.ResetColor();
					num = (short)946012161;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_26F:
				num = (short)202309633;
				if (num != 0)
				{
				}
				return;
				IL_44:
				b = (A_0 as global::Motorola.Common.Communication.Service.b);
				text = b.r();
				text2 = b.w();
				this.a.EnterReadLock();
				num = (short)700121088;
				short num4 = num;
				num = (short)50200578;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004DF0 File Offset: 0x00002FF0
		private global::Motorola.Common.Communication.Service.a c(string operationId)
		{
			global::Motorola.Common.Communication.Service.a result = global::Motorola.Common.Communication.Service.a.a;
			this.a.EnterReadLock();
			short num;
			try
			{
				num = (short)1830813699;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_DF;
					case 1:
						goto IL_F8;
					case 2:
					{
						result = this.b[operationId].x();
						num = (short)379905025;
						short num3 = num;
						num = (short)1367663617;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_DF;
						default:
							num = (short)476577792;
							if (num != 0)
							{
							}
							num = (short)1514405888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_43;
						}
						continue;
					}
					IL_43:
					if (this.b.ContainsKey(operationId))
					{
						num = (short)2034171906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_DF:
					num = (short)1108869121;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F8:;
			}
			finally
			{
				num = (short)958529537;
				if (num != 0)
				{
				}
				this.a.ExitReadLock();
			}
			num = (short)1052246016;
			short num4 = num;
			return result;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004F64 File Offset: 0x00003164
		public bool d(string operationId)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			bool result;
			global::Motorola.Common.Communication.Service.b b;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_1CE;
				case 1:
					return result;
				case 2:
					if (b != null)
					{
						num2 = (short)660275200;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					try
					{
						num2 = (short)438960131;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_1A5;
							case 1:
								goto IL_1BD;
							case 2:
							{
								b = this.b[operationId];
								num2 = (short)1752632953;
								short num3 = num2;
								num2 = (short)621284985;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1A5;
								default:
									num2 = (short)1711865856;
									if (num2 != 0)
									{
									}
									num2 = (short)1730281472;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_10D;
								}
								continue;
							}
							IL_10D:
							if (this.b.ContainsKey(operationId))
							{
								num2 = (short)2135228418;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_1A5:
							num2 = (short)1359609857;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_1BD:
						goto IL_A0;
					}
					finally
					{
						this.a.ExitReadLock();
					}
					goto IL_1CE;
					IL_A0:
					num2 = (short)152633346;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_29;
				IL_1CE:
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("\udf8eﶒﺖﲚ붜킞토욢힤욦\udda8슪슬솮슰鎲횶ힸ\ud8ba\ud8bc펾郂뇄ꛆ믈뿊", a_) + b.w(), global::System.Array.Empty<object>());
				b.ak();
				result = true;
				this.b(operationId);
				b.Dispose();
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("\udf8eﶒﺖﲚ붜킞토욢힤욦\udda8슪슬솮슰鎲횶ힸ\ud8ba\ud8bc펾郂냄꓆꫈껊꣌ꯎ", a_) + b.w(), global::System.Array.Empty<object>());
				num2 = (short)1668743169;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_29:
			num2 = (short)872218625;
			if (num2 != 0)
			{
			}
			result = false;
			b = null;
			this.a.EnterReadLock();
			num2 = (short)588578816;
			short num4 = num2;
			num2 = (short)1459748867;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000051D0 File Offset: 0x000033D0
		public bool e(string operationId)
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			bool result;
			global::Motorola.Common.Communication.Service.b b;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					if (b != null)
					{
						num2 = (short)457768962;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					goto IL_1CB;
				case 3:
					try
					{
						num2 = (short)934215683;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_192;
							case 1:
								b = this.d[operationId];
								num2 = (short)1866661890;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_17E;
							case 3:
							{
								num2 = (short)1040110377;
								short num3 = num2;
								num2 = (short)371184425;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									num2 = (short)960626688;
									if (num2 != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_133;
									}
									continue;
								}
								break;
							}
							}
							IL_133:
							if (this.d.ContainsKey(operationId))
							{
								num2 = (short)675610625;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_17E:
							num2 = (short)1399914496;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_192:
						goto IL_7A;
					}
					finally
					{
						num2 = (short)1524170753;
						if (num2 != 0)
						{
						}
						this.c.ExitReadLock();
					}
					goto IL_1CB;
					IL_7A:
					num2 = (short)1031536641;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_29;
				IL_1CB:
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("\udb88ﺊﶒ랖쮘ﺚﲜﮞ좠춢스螦\udbaa좬\uddae킰잲\udcb4\ud8b6ힸ좺鶼꓀럂蓆꣈ꗊ껌꫎뷐뿒냔돖", a_) + b.w(), global::System.Array.Empty<object>());
				b.al();
				result = true;
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("\udb88ﺊﶒ랖쮘ﺚﲜﮞ좠춢스螦\udbaa좬\uddae킰잲\udcb4\ud8b6ힸ좺鶼ﲾꃀ귂ꛄꋆꗈ黌뫎닐냒냔닖뷘ﯚ", a_) + b.w(), global::System.Array.Empty<object>());
				num2 = (short)544866304;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_29:
			num2 = (short)1167785984;
			short num4 = num2;
			result = false;
			b = null;
			this.c.EnterReadLock();
			num2 = (short)98631683;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000542C File Offset: 0x0000362C
		private void b(string operationId)
		{
			this.a.EnterWriteLock();
			short num;
			try
			{
				num = (short)102957059;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_EB;
					case 1:
						this.b.Remove(operationId);
						num = (short)403177474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_D6;
					case 3:
					{
						num = (short)778456126;
						short num3 = num;
						num = (short)1202474046;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1334771712;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_8E;
							}
							continue;
						}
						break;
					}
					}
					IL_8E:
					if (this.b.ContainsKey(operationId))
					{
						num = (short)1693712385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D6:
					num = (short)1597833216;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_EB:;
			}
			finally
			{
				this.a.ExitWriteLock();
			}
			num = (short)143130625;
			if (num != 0)
			{
			}
			num = (short)1815871488;
			short num4 = num;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005594 File Offset: 0x00003794
		private void a(global::Motorola.Common.Communication.Service.b A_0)
		{
			int a_ = 6;
			short num = (short)1371275266;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					try
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("\uda87憐ﲑ뚕힗鍊솟횡춣즥욧\ud9a9貫풯횱톳튵颷", a_) + A_0.w(), global::System.Array.Empty<object>());
						this.d[A_0.w()] = A_0;
						return;
					}
					finally
					{
						this.c.ExitWriteLock();
					}
					goto IL_152;
				case 1:
					goto IL_152;
				case 2:
				{
					num = (short)2091304113;
					short num3 = num;
					num = (short)782156977;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						break;
					default:
					{
						num = (short)1591345152;
						short num4 = num;
						break;
					}
					}
					num = (short)935133185;
					if (num != 0)
					{
					}
					num = (short)260112384;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_D6;
					}
					continue;
				}
				}
				IL_D6:
				if (A_0.w().Contains(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("\uda87쾏톑쒓", a_)))
				{
					num = (short)588840961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_152:
				this.c.EnterWriteLock();
				num = (short)665649152;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000572C File Offset: 0x0000392C
		private void a(string operationId)
		{
			int a_ = 14;
			short num = (short)628948994;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					try
					{
						num = (short)1719664643;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1BF;
							case 1:
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("슏ﮛ뺝튡솣풥즧\udea9얫솭\udeaf솱钳\uddb7ힹ펻좽ꖿꛁ", a_) + operationId, global::System.Array.Empty<object>());
								this.d.Remove(operationId);
								num = (short)1334444034;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_1A8;
							case 3:
							{
								num = (short)830230323;
								short num3 = num;
								num = (short)2081705779;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									num = (short)1093074944;
									if (num != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_13E;
									}
									continue;
								}
								break;
							}
							}
							IL_13E:
							if (this.d.ContainsKey(operationId))
							{
								num = (short)666828801;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1A8:
							num = (short)268304384;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1BF:
						return;
					}
					finally
					{
						this.c.ExitWriteLock();
					}
					goto IL_1CD;
				case 1:
					goto IL_1CD;
				case 2:
				{
					num = (short)1274413056;
					short num4 = num;
					num = (short)2120417281;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8B;
					}
					continue;
				}
				}
				IL_8B:
				if (operationId.Contains(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("슏잗\ud999첛", a_)))
				{
					num = (short)157679617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1CD:
				this.c.EnterWriteLock();
				num = (short)2025521152;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000594C File Offset: 0x00003B4C
		protected virtual void a(bool A_0)
		{
			short num = (short)9043970;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					this.c.Dispose();
					this.a.Dispose();
					num = (short)2133262336;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)114563544;
					short num3 = num;
					num = (short)1436948952;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						break;
					default:
					{
						num = (short)962068480;
						short num4 = num;
						break;
					}
					}
					num = (short)1648820224;
					if (num != 0)
					{
					}
					num = (short)909901825;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_CD;
					}
					continue;
				}
				}
				IL_CD:
				if (!A_0)
				{
					break;
				}
				num = (short)1107689473;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005A6C File Offset: 0x00003C6C
		public void Dispose()
		{
			short num = (short)1507493526;
			short num2 = num;
			num = (short)325158550;
			switch (num2 == num)
			{
			}
			num = (short)1233649664;
			if (num != 0)
			{
			}
			num = (short)834142209;
			if (num != 0)
			{
			}
			num = (short)9109504;
			short num3 = num;
			this.a(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000019 RID: 25
		private global::System.Threading.ReaderWriterLockSlim a = new global::System.Threading.ReaderWriterLockSlim();

		// Token: 0x0400001A RID: 26
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.Service.b> b = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.Service.b>();

		// Token: 0x0400001B RID: 27
		private global::System.Threading.ReaderWriterLockSlim c = new global::System.Threading.ReaderWriterLockSlim();

		// Token: 0x0400001C RID: 28
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.Service.b> d = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.Service.b>();
	}
}
