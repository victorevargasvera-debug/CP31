using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Gibraltar
{
	// Token: 0x020000BB RID: 187
	internal static class SimpleTimer
	{
		// Token: 0x060007E6 RID: 2022 RVA: 0x0000FF3C File Offset: 0x0000E13C
		public static void Start(string timerName)
		{
			object obj = global::Gibraltar.SimpleTimer.s_SyncObject;
			lock (obj)
			{
				global::Gibraltar.SimpleTimer.TimeCounter timeCounter = global::Gibraltar.SimpleTimer.FindTimer(timerName);
				if (timeCounter == null)
				{
					timeCounter = new global::Gibraltar.SimpleTimer.TimeCounter(timerName);
					global::Gibraltar.SimpleTimer.s_Timers.Add(timerName, timeCounter);
				}
				if (!timeCounter.Stopwatch.IsRunning)
				{
					timeCounter.Stopwatch.Start();
				}
				global::Gibraltar.SimpleTimer.TimeCounter timeCounter2 = timeCounter;
				int count = timeCounter2.Count;
				timeCounter2.Count = count + 1;
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0000FFBC File Offset: 0x0000E1BC
		public static void Stop(string timerName)
		{
			object obj = global::Gibraltar.SimpleTimer.s_SyncObject;
			lock (obj)
			{
				global::Gibraltar.SimpleTimer.TimeCounter timeCounter = global::Gibraltar.SimpleTimer.FindTimer(timerName);
				if (timeCounter != null)
				{
					timeCounter.Stopwatch.Stop();
				}
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00010010 File Offset: 0x0000E210
		public static void WriteLine(string timerName)
		{
			object obj = global::Gibraltar.SimpleTimer.s_SyncObject;
			lock (obj)
			{
				global::Gibraltar.SimpleTimer.TimeCounter timeCounter = global::Gibraltar.SimpleTimer.FindTimer(timerName);
				if (timeCounter == null)
				{
					global::System.Diagnostics.Trace.WriteLine("Undefined timer: " + timerName);
				}
				else
				{
					timeCounter.Stopwatch.Stop();
					string name = timeCounter.Name;
					int count = timeCounter.Count;
					long elapsedMilliseconds = timeCounter.Stopwatch.ElapsedMilliseconds;
					double num = (count == 0) ? 0.0 : ((double)elapsedMilliseconds / (double)count);
					if (count == 1)
					{
						global::System.Diagnostics.Trace.WriteLine(string.Concat(new object[]
						{
							"Timer ",
							name,
							": ",
							elapsedMilliseconds
						}));
					}
					else
					{
						global::System.Diagnostics.Trace.WriteLine(string.Concat(new object[]
						{
							"Timer ",
							name,
							": ",
							elapsedMilliseconds,
							" ms / ",
							count,
							" calls = ",
							num.ToString("F3"),
							" ms / call"
						}));
					}
					timeCounter.Reset();
				}
			}
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00010154 File Offset: 0x0000E354
		public static void Reset(string timerName)
		{
			object obj = global::Gibraltar.SimpleTimer.s_SyncObject;
			lock (obj)
			{
				global::Gibraltar.SimpleTimer.TimeCounter timeCounter = global::Gibraltar.SimpleTimer.FindTimer(timerName);
				if (timeCounter != null)
				{
					timeCounter.Reset();
				}
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0001019C File Offset: 0x0000E39C
		public static void Write(global::System.Text.StringBuilder output, string timerName, bool reset)
		{
			object obj = global::Gibraltar.SimpleTimer.s_SyncObject;
			lock (obj)
			{
				global::Gibraltar.SimpleTimer.TimeCounter timeCounter = global::Gibraltar.SimpleTimer.FindTimer(timerName);
				if (timeCounter == null)
				{
					output.AppendLine("Undefined timer: " + timerName);
				}
				else
				{
					string name = timeCounter.Name;
					int count = timeCounter.Count;
					long elapsedMilliseconds = timeCounter.Stopwatch.ElapsedMilliseconds;
					double num = (count == 0) ? 0.0 : ((double)elapsedMilliseconds / (double)count);
					output.AppendLine(string.Concat(new object[]
					{
						"Timer ",
						name,
						": ",
						elapsedMilliseconds,
						" ms / ",
						count,
						" calls = ",
						num.ToString("F3"),
						" ms / call"
					}));
					if (reset)
					{
						timeCounter.Reset();
					}
				}
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0001029C File Offset: 0x0000E49C
		public static void WriteAll(global::System.Text.StringBuilder output, bool reset)
		{
			object obj = global::Gibraltar.SimpleTimer.s_SyncObject;
			lock (obj)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::Gibraltar.SimpleTimer.TimeCounter> keyValuePair in global::Gibraltar.SimpleTimer.s_Timers)
				{
					global::Gibraltar.SimpleTimer.TimeCounter value = keyValuePair.Value;
					string name = value.Name;
					int count = value.Count;
					long elapsedMilliseconds = value.Stopwatch.ElapsedMilliseconds;
					double num = (count == 0) ? 0.0 : ((double)elapsedMilliseconds / (double)count);
					output.AppendLine(string.Concat(new object[]
					{
						"Timer ",
						name,
						": ",
						elapsedMilliseconds,
						" ms / ",
						count,
						" calls = ",
						num.ToString("F3"),
						" ms / call"
					}));
					if (reset)
					{
						value.Reset();
					}
				}
			}
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x000103C4 File Offset: 0x0000E5C4
		private static global::Gibraltar.SimpleTimer.TimeCounter FindTimer(string timerName)
		{
			global::Gibraltar.SimpleTimer.TimeCounter result;
			if (!global::Gibraltar.SimpleTimer.s_Timers.TryGetValue(timerName, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x04000195 RID: 405
		private static object s_SyncObject = new object();

		// Token: 0x04000196 RID: 406
		private static readonly global::System.Collections.Generic.Dictionary<string, global::Gibraltar.SimpleTimer.TimeCounter> s_Timers = new global::System.Collections.Generic.Dictionary<string, global::Gibraltar.SimpleTimer.TimeCounter>();

		// Token: 0x02000491 RID: 1169
		private class TimeCounter
		{
			// Token: 0x17000EB2 RID: 3762
			// (get) Token: 0x06003302 RID: 13058 RVA: 0x000B9708 File Offset: 0x000B7908
			// (set) Token: 0x06003303 RID: 13059 RVA: 0x000B9710 File Offset: 0x000B7910
			public string Name { get; private set; }

			// Token: 0x17000EB3 RID: 3763
			// (get) Token: 0x06003304 RID: 13060 RVA: 0x000B971C File Offset: 0x000B791C
			// (set) Token: 0x06003305 RID: 13061 RVA: 0x000B9724 File Offset: 0x000B7924
			public int Count { get; set; }

			// Token: 0x17000EB4 RID: 3764
			// (get) Token: 0x06003306 RID: 13062 RVA: 0x000B9730 File Offset: 0x000B7930
			// (set) Token: 0x06003307 RID: 13063 RVA: 0x000B9738 File Offset: 0x000B7938
			public global::System.Diagnostics.Stopwatch Stopwatch { get; private set; }

			// Token: 0x06003308 RID: 13064 RVA: 0x000B9744 File Offset: 0x000B7944
			public TimeCounter(string timerName)
			{
				this.Name = timerName;
				this.Count = 0;
				this.Stopwatch = new global::System.Diagnostics.Stopwatch();
			}

			// Token: 0x06003309 RID: 13065 RVA: 0x000B9774 File Offset: 0x000B7974
			public void Reset()
			{
				this.Stopwatch.Reset();
				this.Count = 0;
			}
		}
	}
}
