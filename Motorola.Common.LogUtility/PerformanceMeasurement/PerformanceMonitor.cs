using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Motorola.Common.LogUtility.PerformanceMeasurement
{
	// Token: 0x0200002F RID: 47
	internal class PerformanceMonitor : global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMonitor
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000178 RID: 376 RVA: 0x000162D4 File Offset: 0x000144D4
		private global::System.Diagnostics.Process CurrentProcess
		{
			get
			{
				short num = (short)1556746996;
				short num2 = num;
				num = (short)879235828;
				switch (num2 == num)
				{
				}
				num = (short)775684096;
				if (num != 0)
				{
				}
				num = (short)156696577;
				if (num != 0)
				{
				}
				num = (short)219611136;
				short num3 = num;
				return this.d.Value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0001638C File Offset: 0x0001458C
		private bool OperationSystemCompatible
		{
			get
			{
				short num = (short)1861612986;
				short num2 = num;
				num = (short)662369722;
				switch (num2 == num)
				{
				}
				num = (short)874708993;
				if (num != 0)
				{
				}
				num = (short)1755840512;
				if (num != 0)
				{
				}
				num = (short)994770944;
				short num3 = num;
				return this.c.Value.Count > 1;
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00016448 File Offset: 0x00014648
		public global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot GetSnapshot(bool setCurrProcess)
		{
			int a_ = 11;
			short num = (short)2032795648;
			short num2 = num;
			num = (short)2144600065;
			if (num != 0)
			{
			}
			num = (short)857997312;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot result;
				for (;;)
				{
					global::System.Lazy<global::System.Collections.Generic.IDictionary<string, global::System.Diagnostics.PerformanceCounter>> obj = this.c;
					bool flag = false;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_A0;
						}
						for (;;)
						{
							IL_89:
							switch (num3)
							{
							case 0:
								if (!this.OperationSystemCompatible)
								{
									num = (short)1229520899;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3CC;
							case 1:
								try
								{
									switch (0)
									{
									case 0:
										goto IL_141;
									}
									global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot performanceSnapshot;
									byte b;
									for (;;)
									{
										IL_106:
										switch (num3)
										{
										case 0:
											num = (short)1603207178;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											num = (short)645791750;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											performanceSnapshot.SystemCpuAvailablePercentage = new byte?(b);
											num = (short)1999241223;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											if (b > 0)
											{
												num = (short)1782448129;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_2B5;
										case 4:
											if (this.CurrentProcess.Responding)
											{
												num = (short)791412741;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_395;
										case 5:
											performanceSnapshot.KernelCpuTimeMs = (uint)this.CurrentProcess.PrivilegedProcessorTime.TotalMilliseconds;
											performanceSnapshot.UserCpuTimeMs = (uint)this.CurrentProcess.UserProcessorTime.TotalMilliseconds;
											performanceSnapshot.CpuTimeMs = (uint)this.CurrentProcess.TotalProcessorTime.TotalMilliseconds;
											performanceSnapshot.MemoryMb = (ushort)(this.CurrentProcess.WorkingSet64 >> 20);
											performanceSnapshot.MemoryPeakMb = (ushort)(this.CurrentProcess.PeakWorkingSet64 >> 20);
											num = (short)218955788;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 6:
											if (b < 100)
											{
												num = (short)136445954;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_2B5;
										case 7:
											goto IL_2B5;
										case 8:
											if (setCurrProcess)
											{
												num = (short)1101594624;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_395;
										case 9:
											goto IL_3AF;
										case 10:
											if (this.CurrentProcess != null)
											{
												num = (short)1472528395;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_395;
										case 11:
											num = (short)1253441540;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 12:
											goto IL_395;
										}
										goto IL_141;
										IL_2B5:
										num = (short)307232776;
										num3 = (int)((global::System.IntPtr)num);
										continue;
										IL_395:
										result = performanceSnapshot;
										num = (short)594804745;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_3AF:
									goto IL_458;
									IL_141:
									performanceSnapshot = new global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot
									{
										SystemMemoryAvailableMb = (ushort)this.c.Value[global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("቞Ѡ๢੤ᕦၨ⽪࡬᭮ၰᩲᥴѶ", a_)].NextValue()
									};
									b = (byte)(100f - this.c.Value[global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ཞ፠ౢ٤ɦᩨᡪɬᵮ㕰ᙲŴᙶၸ᝺๼", a_)].NextValue());
									num = (short)1570963459;
									num3 = (int)((global::System.IntPtr)num);
									goto IL_106;
								}
								catch
								{
									this.c.Value.Clear();
									result = null;
									goto IL_458;
								}
								goto IL_3CC;
							case 2:
								goto IL_F7;
							case 3:
								result = null;
								num = (short)38862850;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A0;
							IL_3CC:
							num = (short)1687420929;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_F7:
						goto IL_458;
						IL_A0:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						num = (short)1020526592;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_89;
					}
					finally
					{
						num = (short)1098186754;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_455;
							case 1:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)669908992;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_41E;
								}
								continue;
							}
							IL_41E:
							if (!flag)
							{
								break;
							}
							num = (short)1316880385;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_455:;
					}
					IL_458:
					num = (short)772959401;
					short num4 = num;
					num = (short)1741253801;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_48E;
					}
				}
				IL_48E:
				num = (short)1977286656;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x040000CF RID: 207
		private const string a = "ProcessorDetails";

		// Token: 0x040000D0 RID: 208
		private const string b = "MemoryDetails";

		// Token: 0x040000D1 RID: 209
		private readonly global::System.Lazy<global::System.Collections.Generic.IDictionary<string, global::System.Diagnostics.PerformanceCounter>> c = new global::System.Lazy<global::System.Collections.Generic.IDictionary<string, global::System.Diagnostics.PerformanceCounter>>(delegate()
		{
			int a_ = 19;
			short num;
			global::System.Collections.Generic.IDictionary<string, global::System.Diagnostics.PerformanceCounter> dictionary;
			for (;;)
			{
				num = (short)1440022528;
				short num2 = num;
				num = (short)2114060289;
				if (num != 0)
				{
				}
				dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Diagnostics.PerformanceCounter>();
				try
				{
					dictionary.Add(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("㝦᭨Ѫ๬੮ɰrᩴն㵸ṺॼṾ", a_), new global::System.Diagnostics.PerformanceCounter(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("㝦᭨Ѫ๬੮ɰrᩴն", a_), global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("䉦䥨㭪ὬnተᙲٴѶᙸॺ嵼⭾", a_), global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("㡦㵨Ѫᥬ๮ᵰ", a_)));
					dictionary.Add(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("⩦౨٪ɬᵮࡰ㝲ၴͶᡸቺᅼ౾", a_), new global::System.Diagnostics.PerformanceCounter(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("⩦౨٪ɬᵮࡰ", a_), global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("♦Ὠ੪Ѭͮၰᅲᥴቶ奸㙺㽼پ", a_)));
					dictionary[global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("㝦᭨Ѫ๬੮ɰrᩴն㵸ṺॼṾ", a_)].NextValue();
					dictionary[global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("㝦᭨Ѫ๬੮ɰrᩴն㵸ṺॼṾ", a_)].NextValue();
				}
				catch
				{
				}
				num = (short)1836548859;
				short num3 = num;
				num = (short)148669179;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_145;
				}
			}
			IL_145:
			num = (short)754909184;
			if (num != 0)
			{
			}
			return dictionary;
		});

		// Token: 0x040000D2 RID: 210
		private readonly global::System.Lazy<global::System.Diagnostics.Process> d = new global::System.Lazy<global::System.Diagnostics.Process>(new global::System.Func<global::System.Diagnostics.Process>(global::System.Diagnostics.Process.GetCurrentProcess));
	}
}
