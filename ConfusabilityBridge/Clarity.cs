using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace ConfusabilityBridge
{
	// Token: 0x02000003 RID: 3
	public class Clarity : global::System.IDisposable
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002198 File Offset: 0x00000398
		public static void clearInternalCache()
		{
			short num = (short)1769154016;
			short num2 = num;
			num = (short)1338844640;
			switch (num2 == num)
			{
			}
			num = (short)144506881;
			if (num != 0)
			{
			}
			num = (short)1098186752;
			short num3 = num;
			num = (short)1992622080;
			if (num != 0)
			{
			}
			global::ConfusabilityBridge.Clarity.d = new global::ConfusabilityBridge.Clarity.Evaluation();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000224C File Offset: 0x0000044C
		public Clarity(string languageCode = "enu")
		{
			this.b = global::ConfusabilityBridge.ConfusabilityFunctions.setup(languageCode);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002284 File Offset: 0x00000484
		public ulong compare(string a, string b)
		{
			short num = (short)1122304001;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (a.ToLower() == b.ToLower())
					{
						num = (short)1388837382;
						short num3 = num;
						num = (short)1983707654;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16A;
						case 1:
							break;
						default:
						{
							num = (short)1808531456;
							short num4 = num;
							break;
						}
						}
						num = (short)1121648641;
						if (num != 0)
						{
						}
						num = (short)1876361216;
						if (num != 0)
						{
						}
						num = (short)793772035;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_177;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 2:
					goto IL_58;
				case 3:
					goto IL_165;
				}
				IL_35:
				if (global::ConfusabilityBridge.Clarity.d.contains(a, b))
				{
					num = (short)1025703938;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					a = a.Replace(global::ConfusabilityBridge.Clarity.a, "");
					b = b.Replace(global::ConfusabilityBridge.Clarity.a, "");
					num = (short)1928724480;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_58:
			goto IL_16A;
			IL_165:
			return 100UL;
			IL_16A:
			return global::ConfusabilityBridge.Clarity.d.lookup(a, b);
			IL_177:
			global::ConfusabilityBridge.Clarity.a a2 = this.a(a);
			global::ConfusabilityBridge.Clarity.a a3 = this.a(b);
			ulong num5;
			global::ConfusabilityBridge.ConfusabilityFunctions.getConfusability(this.b, a2.a, a2.b, a3.a, a3.b, out num5);
			global::ConfusabilityBridge.Clarity.d.a(a, b, num5);
			return num5;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000244C File Offset: 0x0000064C
		private global::ConfusabilityBridge.Clarity.a a(string A_0)
		{
			short num = (short)1739128834;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::ConfusabilityBridge.Clarity.a a;
				switch (num2)
				{
				case 0:
					if (global::ConfusabilityBridge.ConfusabilityFunctions.getTranscription(this.b, A_0, out a.a, out a.b) == 0)
					{
						num = (short)1033240580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return a;
				case 1:
					return a;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 3:
					goto IL_84;
				case 4:
					this.c.TryAdd(A_0, a);
					num = (short)1731723265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_38:
				num = (short)90701824;
				short num3 = num;
				if (this.c.ContainsKey(A_0))
				{
					num = (short)1814953987;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)836727562;
					short num4 = num;
					num = (short)1558082314;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return a;
					default:
						num = (short)77725696;
						if (num != 0)
						{
						}
						a = default(global::ConfusabilityBridge.Clarity.a);
						num = (short)323944449;
						if (num != 0)
						{
						}
						num = (short)166920192;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_84:
			return this.c[A_0];
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000025E8 File Offset: 0x000007E8
		public global::ConfusabilityBridge.Clarity.Evaluation compare(string[] strs)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::ConfusabilityBridge.Clarity.Evaluation evaluation;
			short num2;
			int num5;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_EF;
				case 1:
					return evaluation;
				case 2:
					goto IL_149;
				case 3:
				{
					num2 = (short)524049852;
					short num3 = num2;
					num2 = (short)640703932;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return evaluation;
					case 1:
						break;
					default:
					{
						num2 = (short)764608512;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)402194432;
					if (num2 != 0)
					{
					}
					num5++;
					num2 = (short)551157762;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					num2 = (short)1036320769;
					if (num2 != 0)
					{
					}
					if (num5 >= strs.Length)
					{
						num2 = (short)10682369;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					int num6 = num5 + 1;
					num2 = (short)2021654528;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					goto IL_149;
				case 6:
				{
					int num6;
					if (num6 >= strs.Length)
					{
						num2 = (short)2123497475;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					evaluation.a(strs[num5], strs[num6], this.compare(strs[num5], strs[num6]));
					num6++;
					num2 = (short)470810631;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					goto IL_EF;
				}
				goto IL_30;
				IL_EF:
				num2 = (short)407437318;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_149:
				num2 = (short)285605892;
				num = (int)((global::System.IntPtr)num2);
			}
			return evaluation;
			IL_30:
			evaluation = new global::ConfusabilityBridge.Clarity.Evaluation();
			int num7 = strs.Length * (strs.Length - 1) / 2;
			num5 = 0;
			num2 = (short)236453893;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000027D4 File Offset: 0x000009D4
		public void Dispose()
		{
			short num = (short)1372782593;
			if (num != 0)
			{
			}
			num = (short)1511480153;
			short num2 = num;
			num = (short)1094671193;
			switch (num2 == num)
			{
			}
			num = (short)1499856896;
			short num3 = num;
			num = (short)90046464;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000288C File Offset: 0x00000A8C
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)517537795;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.b != global::System.IntPtr.Zero)
					{
						num = (short)251199490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
				{
					global::System.Collections.Generic.IEnumerator<global::ConfusabilityBridge.Clarity.a> enumerator = this.c.Values.GetEnumerator();
					num = (short)1142751237;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 4:
					goto IL_206;
				case 5:
				{
					try
					{
						num = (short)1075183618;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								num = (short)1640824836;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_9F;
								}
								continue;
							case 3:
							{
								global::System.Collections.Generic.IEnumerator<global::ConfusabilityBridge.Clarity.a> enumerator;
								if (enumerator.MoveNext())
								{
									global::System.IntPtr transcriptions = enumerator.Current.a;
									global::ConfusabilityBridge.ConfusabilityFunctions.returnTranscription(this.b, transcriptions);
									num = (short)855312567;
									short num3 = num;
									num = (short)1867057335;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)238288896;
										if (num != 0)
										{
										}
										num = (short)821035008;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
								}
								num = (short)1333919745;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								goto IL_174;
							}
							IL_A1:
							num = (short)1666383875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_9F:
							goto IL_A1;
						}
						IL_174:
						goto IL_24D;
					}
					finally
					{
						num = (short)428736513;
						if (num != 0)
						{
						}
						num = (short)1861812225;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::ConfusabilityBridge.Clarity.a> enumerator;
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1018298370;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1D0;
								}
								continue;
							case 2:
								goto IL_203;
							}
							IL_1D0:
							if (enumerator == null)
							{
								break;
							}
							num = (short)621346816;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_203:;
					}
					goto IL_206;
					IL_24D:
					num = (short)689766400;
					short num4 = num;
					this.c.Clear();
					global::ConfusabilityBridge.ConfusabilityFunctions.cleanup(this.b);
					this.b = global::System.IntPtr.Zero;
					num = (short)1567424513;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_3D:
				if (global::System.Threading.Interlocked.Increment(ref this.e) == 1)
				{
					num = (short)1072496644;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_206:
				num = (short)797704192;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002B94 File Offset: 0x00000D94
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1935305715;
				short num2 = num;
				num = (short)1518758899;
				switch (num2 == num)
				{
				}
				num = (short)1929314304;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				base.Finalize();
			}
			num = (short)1776680960;
			short num3 = num;
			num = (short)519045121;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002C60 File Offset: 0x00000E60
		// Note: this type is marked as 'beforefieldinit'.
		static Clarity()
		{
			int a_ = 19;
			short num = (short)1462066923;
			short num2 = num;
			num = (short)59072235;
			switch (num2 == num)
			{
			}
			num = (short)386662401;
			if (num != 0)
			{
			}
			num = (short)266207232;
			short num3 = num;
			num = (short)1229914112;
			if (num != 0)
			{
			}
			global::ConfusabilityBridge.Clarity.a = global::<Module>.b("㘌㐎", a_);
			global::ConfusabilityBridge.Clarity.d = new global::ConfusabilityBridge.Clarity.Evaluation();
		}

		// Token: 0x04000003 RID: 3
		private static string a;

		// Token: 0x04000004 RID: 4
		private global::System.IntPtr b = global::System.IntPtr.Zero;

		// Token: 0x04000005 RID: 5
		private global::System.Collections.Concurrent.ConcurrentDictionary<string, global::ConfusabilityBridge.Clarity.a> c = new global::System.Collections.Concurrent.ConcurrentDictionary<string, global::ConfusabilityBridge.Clarity.a>();

		// Token: 0x04000006 RID: 6
		private static global::ConfusabilityBridge.Clarity.Evaluation d;

		// Token: 0x04000007 RID: 7
		private int e;

		// Token: 0x02000004 RID: 4
		private struct a
		{
			// Token: 0x04000008 RID: 8
			public global::System.IntPtr a;

			// Token: 0x04000009 RID: 9
			public ulong b;
		}

		// Token: 0x02000005 RID: 5
		public class Evaluation
		{
			// Token: 0x0600000E RID: 14 RVA: 0x00002D2C File Offset: 0x00000F2C
			internal Evaluation()
			{
			}

			// Token: 0x0600000F RID: 15 RVA: 0x00002D4C File Offset: 0x00000F4C
			internal void a(string A_0, string A_1, ulong A_2)
			{
				short num = (short)1749090305;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)2099314689;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_7B;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					case 2:
					{
						num = (short)2029562459;
						short num3 = num;
						num = (short)231713371;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7B;
						case 1:
							goto IL_10C;
						}
						goto Block_2;
					}
					}
					IL_58:
					if (!this.contains(A_0, A_1))
					{
						num = (short)454557696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_7B:
					this.a.TryAdd(A_0 + global::ConfusabilityBridge.Clarity.a + A_1, A_2);
					num = (short)1320091650;
					num2 = (int)((global::System.IntPtr)num);
				}
				Block_2:
				num = (short)795344896;
				short num4 = num;
				IL_10C:
				num = (short)1365704704;
				if (num != 0)
				{
				}
			}

			// Token: 0x06000010 RID: 16 RVA: 0x00002E80 File Offset: 0x00001080
			public bool contains(string a, string b)
			{
				short num;
				for (;;)
				{
					a = a.Replace(global::ConfusabilityBridge.Clarity.a, "");
					b = b.Replace(global::ConfusabilityBridge.Clarity.a, "");
					if (this.a.ContainsKey(a + global::ConfusabilityBridge.Clarity.a + b))
					{
						return true;
					}
					num = (short)139307537;
					short num2 = num;
					num = (short)1744087569;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_76;
					}
				}
				IL_76:
				num = (short)450428928;
				short num3 = num;
				num = (short)424345601;
				if (num != 0)
				{
				}
				num = (short)1867972608;
				if (num != 0)
				{
				}
				return this.a.ContainsKey(b + global::ConfusabilityBridge.Clarity.a + a);
			}

			// Token: 0x06000011 RID: 17 RVA: 0x00002F80 File Offset: 0x00001180
			public ulong lookup(string a, string b)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						if (!this.a.ContainsKey(b + global::ConfusabilityBridge.Clarity.a + a))
						{
							goto IL_1A8;
						}
						num2 = (short)586874880;
						short num3 = num2;
						num2 = (short)2047917529;
						short num4 = num2;
						num2 = (short)1901706713;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_190;
						default:
							num2 = (short)269484032;
							if (num2 != 0)
							{
							}
							num2 = (short)1080885251;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						if (this.a.ContainsKey(a + global::ConfusabilityBridge.Clarity.a + b))
						{
							num2 = (short)1394016258;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1346502656;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_AF;
					case 3:
						goto IL_18B;
					}
					goto IL_20;
				}
				IL_AF:
				goto IL_190;
				IL_18B:
				return this.a[b + global::ConfusabilityBridge.Clarity.a + a];
				IL_190:
				return this.a[a + global::ConfusabilityBridge.Clarity.a + b];
				IL_1A8:
				return 0UL;
				IL_20:
				a = a.Replace(global::ConfusabilityBridge.Clarity.a, "");
				b = b.Replace(global::ConfusabilityBridge.Clarity.a, "");
				num2 = (short)121700353;
				if (num2 != 0)
				{
				}
				num2 = (short)1274085377;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x06000012 RID: 18 RVA: 0x00003138 File Offset: 0x00001338
			public global::System.Collections.Generic.List<string> getConfusedWith(string top, ulong confusionThreshold)
			{
				short num = (short)220266496;
				switch (num)
				{
				default:
				{
					num = (short)2103902208;
					short num2 = num;
					top = top.Replace(global::ConfusabilityBridge.Clarity.a, "");
					global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
					global::System.Collections.Generic.IEnumerator<string> enumerator = this.a.Keys.GetEnumerator();
					try
					{
						num = (short)6684681;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_14C;
							case 1:
							{
								string[] array;
								list.Add(array[1]);
								num = (short)1692336128;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								string text;
								if (this.a[text] > confusionThreshold)
								{
									num = (short)1601175559;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_14C;
							}
							case 3:
							{
								string[] array;
								if (array[1] == top)
								{
									num = (short)2035482632;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_14C;
							}
							case 4:
							{
								string[] array;
								if (array[0] == top)
								{
									num = (short)471597057;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)484573187;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								IL_244:
								goto IL_14C;
							case 6:
								num = (short)1221722123;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
							{
								string text;
								string[] array = text.Split(new string[]
								{
									global::ConfusabilityBridge.Clarity.a
								}, global::System.StringSplitOptions.None);
								num = (short)1229651972;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
							{
								string[] array;
								list.Add(array[0]);
								num = (short)1680343045;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								switch (0)
								{
								case 0:
									goto IL_C8;
								}
								continue;
							case 10:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1660682246;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								string text = enumerator.Current;
								num = (short)1866465282;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 11:
								goto IL_2C8;
							}
							goto IL_C8;
							IL_14C:
							num = (short)909712938;
							short num4 = num;
							num = (short)330505770;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_244;
							default:
								num = (short)1092943872;
								if (num != 0)
								{
								}
								num = (short)171507722;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_C8:
							num = (short)256180225;
							if (num != 0)
							{
							}
							goto IL_14C;
						}
						IL_2C8:;
					}
					finally
					{
						num = (short)986447873;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1081933826;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_2FC;
								}
								continue;
							case 2:
								goto IL_333;
							}
							IL_2FC:
							if (enumerator == null)
							{
								break;
							}
							num = (short)349634560;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_333:;
					}
					return list;
				}
				}
			}

			// Token: 0x0400000A RID: 10
			private global::System.Collections.Concurrent.ConcurrentDictionary<string, ulong> a = new global::System.Collections.Concurrent.ConcurrentDictionary<string, ulong>();
		}
	}
}
