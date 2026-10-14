using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.UI.CellRangeFill.UndoRedo
{
	// Token: 0x02000029 RID: 41
	public static class UndoManager
	{
		// Token: 0x060000EC RID: 236 RVA: 0x0000DE0C File Offset: 0x0000C00C
		static UndoManager()
		{
			short num = (short)1991704576;
			short num2 = num;
			num = (short)1358982532;
			short num3 = num;
			num = (short)43543940;
			switch (num3 == num)
			{
			}
			num = (short)526254081;
			if (num != 0)
			{
			}
			num = (short)428670976;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.a = new global::System.Collections.Generic.Stack<global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoableTask>();
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.b = new global::System.Collections.Generic.Stack<global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoableTask>();
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000DECC File Offset: 0x0000C0CC
		// (set) Token: 0x060000EE RID: 238 RVA: 0x0000DF78 File Offset: 0x0000C178
		public static bool IsActive
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1812529152;
				short num2 = num;
				num = (short)1238444452;
				short num3 = num;
				num = (short)1298868644;
				switch (num3 == num)
				{
				}
				num = (short)317063169;
				if (num != 0)
				{
				}
				num = (short)1662189568;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)990904320;
				short num2 = num;
				num = (short)1261023718;
				short num3 = num;
				num = (short)2009444838;
				switch (num3 == num)
				{
				}
				num = (short)152305664;
				if (num != 0)
				{
				}
				num = (short)1139212289;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.c = value;
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000E024 File Offset: 0x0000C224
		public static void Undo()
		{
			short num = (short)868220928;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 1:
					num = (short)1260322817;
					if (num != 0)
					{
					}
					num = (short)1372913666;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					if (!global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.IsActive)
					{
						goto IL_ED;
					}
					global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.IsActive = false;
					global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoableTask undoableTask = global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.a.Pop();
					num = (short)2092040198;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_105;
				case 4:
				{
					global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoableTask undoableTask;
					global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.b.Push(undoableTask);
					num = (short)1875705863;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoableTask undoableTask;
					if (undoableTask != null)
					{
						num = (short)750059524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DF;
				}
				case 6:
				{
					try
					{
						global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoableTask undoableTask;
						undoableTask.Undo();
						goto IL_107;
					}
					catch (global::System.Exception)
					{
						global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.Reset();
						global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoableTask undoableTask = null;
						goto IL_107;
					}
					goto IL_9D;
					IL_107:
					num = (short)981663744;
					short num3 = num;
					num = (short)232250990;
					short num4 = num;
					num = (short)736091758;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_ED;
					default:
						num = (short)1369702400;
						if (num != 0)
						{
						}
						num = (short)1631322117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					goto IL_C5;
				}
				IL_45:
				if (global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.CanUndo)
				{
					num = (short)83820545;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_ED:
				num = (short)649265155;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9D:
			throw new global::System.InvalidOperationException();
			IL_C5:
			goto IL_1DF;
			IL_105:
			goto IL_9D;
			IL_1DF:
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.IsActive = true;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000E228 File Offset: 0x0000C428
		public static void Redo()
		{
			short num = (short)341704704;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 1:
					num = (short)1515192322;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					if (!global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.IsActive)
					{
						goto IL_BF;
					}
					global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.IsActive = false;
					global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoableTask undoableTask = global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.b.Pop();
					num = (short)554827782;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_D7;
				case 4:
				{
					global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoableTask undoableTask;
					global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.a.Push(undoableTask);
					num = (short)1161494535;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoableTask undoableTask;
					if (undoableTask != null)
					{
						num = (short)195559425;
						if (num != 0)
						{
						}
						num = (short)644153348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DA;
				}
				case 6:
				{
					try
					{
						global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoableTask undoableTask;
						undoableTask.Do();
						goto IL_D9;
					}
					catch (global::System.Exception)
					{
						global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.Reset();
						global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoableTask undoableTask = null;
						goto IL_D9;
					}
					goto IL_73;
					IL_D9:
					num = (short)2047729204;
					short num3 = num;
					num = (short)1277812276;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BF;
					case 1:
						break;
					default:
					{
						num = (short)1615855616;
						short num4 = num;
						break;
					}
					}
					num = (short)1655635968;
					if (num != 0)
					{
					}
					num = (short)1435762693;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					goto IL_99;
				}
				IL_44:
				if (global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.CanRedo)
				{
					num = (short)1659371521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_BF:
				num = (short)1878327299;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_73:
			throw new global::System.InvalidOperationException();
			IL_99:
			goto IL_1DA;
			IL_D7:
			goto IL_73;
			IL_1DA:
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.IsActive = true;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000E428 File Offset: 0x0000C628
		public static void Start()
		{
			short num = (short)1166016512;
			short num2 = num;
			num = (short)1970046229;
			short num3 = num;
			num = (short)938902805;
			switch (num3 == num)
			{
			}
			num = (short)1519517696;
			if (num != 0)
			{
			}
			num = (short)2038038529;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.IsActive = true;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
		public static void Stop()
		{
			short num = (short)256573440;
			short num2 = num;
			num = (short)994770945;
			if (num != 0)
			{
			}
			num = (short)265691682;
			short num3 = num;
			num = (short)246620706;
			switch (num3 == num)
			{
			}
			num = (short)132907008;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.IsActive = false;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000E588 File Offset: 0x0000C788
		public static void Reset()
		{
			short num = (short)789708800;
			short num2 = num;
			num = (short)422424360;
			short num3 = num;
			num = (short)256552744;
			switch (num3 == num)
			{
			}
			num = (short)240779265;
			if (num != 0)
			{
			}
			num = (short)1856700416;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.b.Clear();
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.a.Clear();
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000E644 File Offset: 0x0000C844
		public static void AddTask(global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoableTask task)
		{
			short num = (short)1242890240;
			short num2 = num;
			num = (short)421269433;
			short num3 = num;
			num = (short)368381881;
			switch (num3 == num)
			{
			}
			num = (short)1162805249;
			if (num != 0)
			{
			}
			num = (short)263061504;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.IsActive = false;
			task.Do();
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.IsActive = true;
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.a.Push(task);
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.b.Clear();
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000E714 File Offset: 0x0000C914
		public static bool CanUndo
		{
			get
			{
				short num = (short)447741952;
				short num2 = num;
				num = (short)543364649;
				short num3 = num;
				num = (short)102307369;
				switch (num3 == num)
				{
				}
				num = (short)1554382849;
				if (num != 0)
				{
				}
				num = (short)1132396544;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.a.Count > 0;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000E7C8 File Offset: 0x0000C9C8
		public static bool CanRedo
		{
			get
			{
				short num = (short)413925376;
				short num2 = num;
				num = (short)394744028;
				short num3 = num;
				num = (short)1805603036;
				switch (num3 == num)
				{
				}
				num = (short)1668546561;
				if (num != 0)
				{
				}
				num = (short)1158414336;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.b.Count > 0;
			}
		}

		// Token: 0x04000054 RID: 84
		private static readonly global::System.Collections.Generic.Stack<global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoableTask> a;

		// Token: 0x04000055 RID: 85
		private static readonly global::System.Collections.Generic.Stack<global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoableTask> b;

		// Token: 0x04000056 RID: 86
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool c;
	}
}
