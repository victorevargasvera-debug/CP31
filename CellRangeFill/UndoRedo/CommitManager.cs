using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.UI.CellRangeFill.UndoRedo
{
	// Token: 0x02000026 RID: 38
	public static class CommitManager
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000C110 File Offset: 0x0000A310
		private static global::System.Collections.Generic.Queue<global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitableTask> CommitQueue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)923471518;
				short num2 = num;
				num = (short)1681002142;
				switch (num2 == num)
				{
				}
				num = (short)428998657;
				if (num != 0)
				{
				}
				num = (short)984940544;
				if (num != 0)
				{
				}
				num = (short)1677328384;
				short num3 = num;
				return global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.b;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000C1BC File Offset: 0x0000A3BC
		static CommitManager()
		{
			short num = (short)259447204;
			short num2 = num;
			num = (short)2121652644;
			switch (num2 == num)
			{
			}
			num = (short)2098724865;
			if (num != 0)
			{
			}
			num = (short)1442971648;
			if (num != 0)
			{
			}
			num = (short)1856438272;
			short num3 = num;
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.b = new global::System.Collections.Generic.Queue<global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitableTask>();
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000C270 File Offset: 0x0000A470
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0000C31C File Offset: 0x0000A51C
		public static bool IsActive
		{
			get
			{
				short num = (short)989257748;
				short num2 = num;
				num = (short)1241374740;
				switch (num2 == num)
				{
				}
				num = (short)1526005761;
				if (num != 0)
				{
				}
				num = (short)1298595840;
				if (num != 0)
				{
				}
				num = (short)1567490048;
				short num3 = num;
				return global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.a;
			}
			private set
			{
				short num = (short)1461782937;
				short num2 = num;
				num = (short)972294553;
				switch (num2 == num)
				{
				}
				num = (short)42008577;
				if (num != 0)
				{
				}
				num = (short)758317056;
				if (num != 0)
				{
				}
				num = (short)418578432;
				short num3 = num;
				global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.a = value;
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000C3D0 File Offset: 0x0000A5D0
		public static void CommitAll()
		{
			short num = (short)283639809;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1535705088;
				short num3 = num;
				global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitableTask commitableTask;
				switch (num2)
				{
				case 0:
					goto IL_2D1;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 2:
					num = (short)1434976259;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1407188993;
					if (num != 0)
					{
					}
					if (!global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.IsActive)
					{
						num = (short)72744960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24E;
				case 4:
					try
					{
						num = (short)135397377;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_137;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_BF;
								}
								continue;
							case 2:
								if (global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.CommitQueue.Count <= 0)
								{
									num = (short)2092236804;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								commitableTask = global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.CommitQueue.Dequeue();
								commitableTask.Commit();
								num = (short)467075075;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								num = (short)64880640;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_C1:
							num = (short)55115778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_BF:
							goto IL_C1;
						}
						IL_137:
						goto IL_2D9;
					}
					catch (global::System.Exception)
					{
						try
						{
							num = (short)631701505;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_22E;
								case 1:
									goto IL_173;
								case 2:
								{
									num = (short)906225616;
									short num4 = num;
									num = (short)1555883984;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_173;
									default:
										num = (short)799473664;
										if (num != 0)
										{
										}
										goto IL_217;
									}
									break;
								}
								case 3:
									commitableTask.Undo();
									num = (short)1967063042;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_193;
								IL_173:
								switch (0)
								{
								case 0:
									IL_193:
									if (commitableTask == null)
									{
										goto IL_217;
									}
									num = (short)1031143427;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
								continue;
								IL_217:
								num = (short)1891303424;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_22E:
							goto IL_14A;
						}
						catch (global::System.Exception)
						{
							goto IL_14A;
						}
						goto IL_239;
						IL_14A:
						if (global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.CommitQueue.Count <= 0)
						{
							goto IL_2D9;
						}
						IL_239:
						commitableTask = global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.CommitQueue.Dequeue();
						try
						{
							commitableTask.Undo();
						}
						catch (global::System.Exception)
						{
						}
						goto IL_14A;
					}
					goto IL_24E;
				}
				IL_62:
				if (global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.CanCommit)
				{
					num = (short)1058537474;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_24E:
				global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.IsActive = false;
				commitableTask = null;
				num = (short)448266244;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2D1:
			throw new global::System.InvalidOperationException();
			IL_2D9:
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.IsActive = true;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000C708 File Offset: 0x0000A908
		public static void Start()
		{
			short num = (short)1788596533;
			short num2 = num;
			num = (short)1446695221;
			switch (num2 == num)
			{
			}
			num = (short)897318913;
			if (num != 0)
			{
			}
			num = (short)1528102912;
			if (num != 0)
			{
			}
			num = (short)1196490752;
			short num3 = num;
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.IsActive = true;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000C7B8 File Offset: 0x0000A9B8
		public static void Stop()
		{
			short num = (short)2144366702;
			short num2 = num;
			num = (short)461074542;
			switch (num2 == num)
			{
			}
			num = (short)1235353601;
			if (num != 0)
			{
			}
			num = (short)707461120;
			if (num != 0)
			{
			}
			num = (short)1186922496;
			short num3 = num;
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.IsActive = false;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000C86C File Offset: 0x0000AA6C
		public static void Reset()
		{
			short num = (short)4635959;
			short num2 = num;
			num = (short)1455209783;
			switch (num2 == num)
			{
			}
			num = (short)975765505;
			if (num != 0)
			{
			}
			num = (short)453181440;
			if (num != 0)
			{
			}
			num = (short)321585152;
			short num3 = num;
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.CommitQueue.Clear();
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000C920 File Offset: 0x0000AB20
		public static void AddTask(global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitableTask task)
		{
			short num = (short)1831206913;
			if (num != 0)
			{
			}
			num = (short)2008896998;
			short num2 = num;
			num = (short)1666668006;
			switch (num2 == num)
			{
			}
			num = (short)159186944;
			if (num != 0)
			{
			}
			num = (short)1600061440;
			short num3 = num;
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.IsActive = false;
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.CommitQueue.Enqueue(task);
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.IsActive = true;
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000C9E0 File Offset: 0x0000ABE0
		public static bool CanCommit
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)1806499840;
					short num2 = num;
					num = (short)744161281;
					if (num != 0)
					{
					}
					if (global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.IsActive)
					{
						break;
					}
					num = (short)136322170;
					short num3 = num;
					num = (short)1286413434;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_9C;
					}
				}
				return global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.CommitQueue.Count > 0;
				IL_9C:
				num = (short)1227227136;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x04000048 RID: 72
		private static bool a;

		// Token: 0x04000049 RID: 73
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static readonly global::System.Collections.Generic.Queue<global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitableTask> b;
	}
}
