using System;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Motorola.CommonCPS.RadioManagement.CommonBase.Utility
{
	// Token: 0x02000003 RID: 3
	public static class MemoryCleaner
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		// (remove) Token: 0x06000005 RID: 5 RVA: 0x00002254 File Offset: 0x00000454
		public static event global::System.Action<object, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleanerEventArgs> ClearCache
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					short num2;
					global::System.Action<object, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleanerEventArgs> action;
					for (;;)
					{
						IL_0A:
						global::System.Action<object, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleanerEventArgs> action2;
						switch (num)
						{
						case 0:
							num2 = (short)1484521473;
							if (num2 != 0)
							{
							}
							goto IL_62;
						case 1:
							return;
						case 2:
						{
							num2 = (short)236938447;
							short num3 = num2;
							num2 = (short)2036360399;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)423690240;
								if (num2 != 0)
								{
								}
								num2 = (short)1808138240;
								short num4 = num2;
								if (action == action2)
								{
									num2 = (short)1707737089;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_62;
							}
							}
							break;
						}
						}
						break;
						IL_62:
						action2 = action;
						global::System.Action<object, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleanerEventArgs> value2 = (global::System.Action<object, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleanerEventArgs>)global::System.Delegate.Combine(action2, value);
						action = global::System.Threading.Interlocked.CompareExchange<global::System.Action<object, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleanerEventArgs>>(ref global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleaner.b, value2, action2);
						num2 = (short)1915355138;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					action = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleaner.b;
					num2 = (short)1571291136;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					short num2;
					global::System.Action<object, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleanerEventArgs> action;
					for (;;)
					{
						IL_0A:
						global::System.Action<object, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleanerEventArgs> action2;
						switch (num)
						{
						case 0:
							num2 = (short)1447231489;
							if (num2 != 0)
							{
							}
							goto IL_60;
						case 1:
							return;
						case 2:
						{
							num2 = (short)1482736782;
							short num3 = num2;
							num2 = (short)966247566;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)822149120;
								if (num2 != 0)
								{
								}
								num2 = (short)606601216;
								short num4 = num2;
								if (action == action2)
								{
									num2 = (short)952893441;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_60;
							}
							}
							break;
						}
						}
						break;
						IL_60:
						action2 = action;
						global::System.Action<object, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleanerEventArgs> value2 = (global::System.Action<object, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleanerEventArgs>)global::System.Delegate.Remove(action2, value);
						action = global::System.Threading.Interlocked.CompareExchange<global::System.Action<object, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleanerEventArgs>>(ref global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleaner.b, value2, action2);
						num2 = (short)1536688130;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					action = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleaner.b;
					num2 = (short)2069299200;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000238C File Offset: 0x0000058C
		public static void CleanGarbageFromMemory()
		{
			short num = (short)1821496662;
			short num2 = num;
			num = (short)569890134;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1362821120;
				if (num != 0)
				{
				}
				num = (short)918487040;
				int num3 = (int)num;
				switch (num3)
				{
				}
				break;
			}
			}
			num = (short)853803008;
			short num4 = num;
			object obj = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleaner.a;
			bool flag = false;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_BD;
				}
				int num3;
				long totalMemory2;
				for (;;)
				{
					IL_A6:
					switch (num3)
					{
					case 0:
					{
						global::System.Action<object, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleanerEventArgs> action = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleaner.b;
						if (action == null)
						{
							num = (short)688586753;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						action(null, new global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleanerEventArgs());
						num = (short)2097086466;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_127;
					case 2:
						goto IL_127;
					case 3:
						goto IL_191;
					}
					goto IL_BD;
					IL_127:
					num = (short)863502337;
					if (num != 0)
					{
					}
					global::System.Runtime.GCSettings.LargeObjectHeapCompactionMode = global::System.Runtime.GCLargeObjectHeapCompactionMode.CompactOnce;
					global::System.GC.Collect(global::System.GC.MaxGeneration, global::System.GCCollectionMode.Forced, true, true);
					global::System.GC.WaitForPendingFinalizers();
					long totalMemory = global::System.GC.GetTotalMemory(false);
					global::System.Math.Max(0L, totalMemory2 - totalMemory);
					num = (short)1969946627;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_191:
				return;
				IL_BD:
				global::System.Threading.Monitor.Enter(obj, ref flag);
				totalMemory2 = global::System.GC.GetTotalMemory(false);
				num = (short)8650752;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_A6;
			}
			finally
			{
				num = (short)1114112000;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_1C5;
						}
						continue;
					case 1:
						global::System.Threading.Monitor.Exit(obj);
						num = (short)1206190082;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1FC;
					}
					IL_1C5:
					if (!flag)
					{
						break;
					}
					num = (short)2010841089;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1FC:;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000025A8 File Offset: 0x000007A8
		// Note: this type is marked as 'beforefieldinit'.
		static MemoryCleaner()
		{
			short num = (short)1660237749;
			short num2 = num;
			num = (short)377108405;
			switch (num2 == num)
			{
			}
			num = (short)124125185;
			if (num != 0)
			{
			}
			num = (short)929628160;
			short num3 = num;
			num = (short)1429667840;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleaner.a = new object();
		}

		// Token: 0x04000003 RID: 3
		private static readonly object a;

		// Token: 0x04000004 RID: 4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::System.Action<object, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.MemoryCleanerEventArgs> b;
	}
}
