using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AcpCommonLib.UndoRedo
{
	// Token: 0x02000034 RID: 52
	public static class UndoManager
	{
		// Token: 0x0600020A RID: 522 RVA: 0x0001297C File Offset: 0x00010B7C
		public static void GoToSection(global::AcpCommonLib.IAcpFeatureSection section)
		{
			short num = (short)1025376256;
			short num2 = num;
			num = (short)1253048322;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)6815745;
					if (num != 0)
					{
					}
					num = (short)688694386;
					short num4 = num;
					num = (short)1760011378;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)2007171072;
						if (num != 0)
						{
						}
						global::AcpCommonLib.UndoRedo.UndoManager.LaunchSectionHandler(section);
						num = (short)1099300865;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				}
				IL_58:
				if (global::AcpCommonLib.UndoRedo.UndoManager.LaunchSectionHandler == null)
				{
					break;
				}
				num = (short)1735589888;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00012A98 File Offset: 0x00010C98
		// (set) Token: 0x0600020C RID: 524 RVA: 0x00012B44 File Offset: 0x00010D44
		public static bool MarkForUndo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)365758689;
				short num2 = num;
				num = (short)2015496417;
				switch (num2 == num)
				{
				}
				num = (short)743636993;
				if (num != 0)
				{
				}
				num = (short)465174528;
				short num3 = num;
				num = (short)178782208;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.UndoRedo.UndoManager.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)387022497;
				short num2 = num;
				num = (short)575766177;
				switch (num2 == num)
				{
				}
				num = (short)1015283712;
				if (num != 0)
				{
				}
				num = (short)1125056512;
				short num3 = num;
				num = (short)1677590529;
				if (num != 0)
				{
				}
				global::AcpCommonLib.UndoRedo.UndoManager.c = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00012BF0 File Offset: 0x00010DF0
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00012CA0 File Offset: 0x00010EA0
		internal static global::AcpCommonLib.UndoRedo.AcpUndoHelper UndoHelper
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1589734549;
				short num2 = num;
				num = (short)1973316757;
				switch (num2 == num)
				{
				}
				num = (short)1041170433;
				if (num != 0)
				{
				}
				num = (short)1989476352;
				short num3 = num;
				num = (short)2102198272;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.UndoRedo.UndoManager.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1120747809;
				short num2 = num;
				num = (short)62931233;
				switch (num2 == num)
				{
				}
				num = (short)1884553216;
				if (num != 0)
				{
				}
				num = (short)1043660800;
				short num3 = num;
				num = (short)67502081;
				if (num != 0)
				{
				}
				global::AcpCommonLib.UndoRedo.UndoManager.d = value;
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00012D50 File Offset: 0x00010F50
		public static void AddTask(global::AcpCommonLib.UndoRedo.UndoableTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (global::AcpCommonLib.UndoRedo.UndoManager.b.Count == 0)
					{
						num2 = (short)754515970;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_28F;
				case 1:
					goto IL_26C;
				case 2:
					global::AcpCommonLib.UndoRedo.UndoManager.UndoHelper.CanRedo = false;
					num2 = (short)134086659;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_16A;
				case 4:
					if (global::AcpCommonLib.UndoRedo.UndoManager.a.Count == 1)
					{
						num2 = (short)1793916938;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1FE;
				case 5:
					if (task.Seamless)
					{
						num2 = (short)1767833600;
						short num3 = num2;
						num2 = (short)327483399;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_240;
				case 6:
					goto IL_1FE;
				case 7:
					return;
				case 8:
				{
					if (global::AcpCommonLib.UndoRedo.UndoManager.a.Count != 0)
					{
						goto IL_240;
					}
					num2 = (short)602319003;
					short num4 = num2;
					num2 = (short)1065920667;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_26C;
					default:
						num2 = (short)401670144;
						if (num2 != 0)
						{
						}
						num2 = (short)822280203;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 9:
					num2 = (short)2070740996;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					global::AcpCommonLib.UndoRedo.UndoManager.UndoHelper.CanUndo = true;
					num2 = (short)1672151046;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					num2 = (short)1509687301;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_40;
				IL_1FE:
				num2 = (short)980680704;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_240:
				global::AcpCommonLib.UndoRedo.UndoManager.a.Push(task);
				global::AcpCommonLib.UndoRedo.UndoManager.b.Clear();
				num2 = (short)969408513;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_26C:
				if (global::AcpCommonLib.UndoRedo.UndoManager.UndoHelper == null)
				{
					goto IL_28F;
				}
				num2 = (short)452788233;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_16A:
			num2 = (short)803012609;
			if (num2 != 0)
			{
			}
			IL_28F:
			global::AcpCommonLib.FeatureManager.ActiveDocument.IsDirty = true;
			return;
			IL_40:
			global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo = false;
			task.Do();
			global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo = true;
			num2 = (short)1197735944;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00012FF8 File Offset: 0x000111F8
		public static bool StopUndoRedo()
		{
			short num = (short)1512782666;
			short num2 = num;
			num = (short)1801009994;
			switch (num2 == num)
			{
			}
			num = (short)1575354368;
			if (num != 0)
			{
			}
			num = (short)565575680;
			short num3 = num;
			num = (short)860291073;
			if (num != 0)
			{
			}
			bool markForUndo = global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo;
			global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo = false;
			return markForUndo;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000130B0 File Offset: 0x000112B0
		public static void StartUndoRedo()
		{
			short num = (short)1815944896;
			short num2 = num;
			num = (short)2051481280;
			switch (num2 == num)
			{
			}
			num = (short)1457979393;
			if (num != 0)
			{
			}
			num = (short)390922240;
			short num3 = num;
			num = (short)2081423360;
			if (num != 0)
			{
			}
			global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo = true;
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0001315C File Offset: 0x0001135C
		public static bool CanUndo
		{
			get
			{
				short num = (short)655363292;
				short num2 = num;
				num = (short)1513295068;
				switch (num2 == num)
				{
				}
				num = (short)1510998017;
				if (num != 0)
				{
				}
				num = (short)676593664;
				short num3 = num;
				num = (short)1114701824;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.UndoRedo.UndoManager.a.Count > 0;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00013214 File Offset: 0x00011414
		public static bool CanRedo
		{
			get
			{
				short num = (short)1477283459;
				short num2 = num;
				num = (short)443453059;
				switch (num2 == num)
				{
				}
				num = (short)1823801345;
				if (num != 0)
				{
				}
				num = (short)164823040;
				short num3 = num;
				num = (short)1660223488;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.UndoRedo.UndoManager.b.Count > 0;
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000132CC File Offset: 0x000114CC
		public static bool Undo()
		{
			switch (0)
			{
			case 0:
				goto IL_65;
			}
			short num;
			int num2;
			global::AcpCommonLib.UndoRedo.UndoableTask undoableTask;
			for (;;)
			{
				IL_0A:
				num = (short)919011329;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_1B9;
				case 1:
				{
					num = (short)1506803712;
					short num3 = num;
					num = (short)699465731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (global::AcpCommonLib.UndoRedo.UndoManager.UndoHelper != null)
					{
						num = (short)66387969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24B;
				case 3:
					if (global::AcpCommonLib.UndoRedo.UndoManager.a.Count == 0)
					{
						num = (short)813957124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A7;
				case 4:
					goto IL_222;
				case 5:
					if (global::AcpCommonLib.UndoRedo.UndoManager.b.Count == 1)
					{
						num = (short)700317705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24B;
				case 6:
					goto IL_1BE;
				case 7:
					if (undoableTask != null)
					{
						num = (short)843448330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BE;
				case 8:
					goto IL_A7;
				case 9:
				{
					global::AcpCommonLib.UndoRedo.UndoManager.UndoHelper.CanRedo = true;
					num = (short)1411840702;
					short num4 = num;
					num = (short)1389623998;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_222;
					default:
						num = (short)1490550784;
						if (num != 0)
						{
						}
						num = (short)599523328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 10:
					undoableTask.LaunchUI();
					num = (short)1023606790;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_65;
				IL_A7:
				num = (short)799735813;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1BE:
				num = (short)72679426;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_222:
				global::AcpCommonLib.UndoRedo.UndoManager.UndoHelper.CanUndo = false;
				num = (short)1350762504;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1B9:
			IL_24B:
			global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo = true;
			return true;
			IL_65:
			global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo = false;
			undoableTask = global::AcpCommonLib.UndoRedo.UndoManager.f();
			num = (short)1149173767;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0001352C File Offset: 0x0001172C
		private static global::AcpCommonLib.UndoRedo.UndoableTask f()
		{
			global::AcpCommonLib.AppInfoManager.UndoRedoInProgress = true;
			global::AcpCommonLib.UndoRedo.UndoableTask undoableTask = global::AcpCommonLib.UndoRedo.UndoManager.a.Pop();
			global::AcpCommonLib.UndoRedo.UndoableTask result;
			try
			{
				undoableTask.Undo();
				undoableTask.LaunchUI();
				goto IL_16;
			}
			catch (global::System.ArgumentOutOfRangeException)
			{
				global::AcpCommonLib.UndoRedo.UndoManager.Reset();
				global::AcpCommonLib.AppInfoManager.UndoRedoInProgress = false;
				result = null;
			}
			return result;
			IL_16:
			short num = (short)1755185152;
			short num2 = num;
			num = (short)584788870;
			short num3 = num;
			num = (short)1088629638;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			default:
				num = (short)1764360193;
				if (num != 0)
				{
				}
				num = (short)2127298560;
				if (num != 0)
				{
				}
				global::AcpCommonLib.UndoRedo.UndoManager.b.Push(undoableTask);
				global::AcpCommonLib.AppInfoManager.UndoRedoInProgress = false;
				return undoableTask;
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00013630 File Offset: 0x00011830
		public static bool Redo()
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			global::AcpCommonLib.UndoRedo.UndoableTask undoableTask;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_1B8;
				case 1:
				{
					num2 = (short)996343808;
					short num3 = num2;
					num2 = (short)1474756611;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (global::AcpCommonLib.UndoRedo.UndoManager.UndoHelper != null)
					{
						num2 = (short)1715077121;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24A;
				case 3:
					if (global::AcpCommonLib.UndoRedo.UndoManager.a.Count == 1)
					{
						num2 = (short)1079902212;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A6;
				case 4:
					goto IL_223;
				case 5:
					if (global::AcpCommonLib.UndoRedo.UndoManager.b.Count == 0)
					{
						num2 = (short)2134310921;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24A;
				case 6:
					goto IL_1BD;
				case 7:
					num2 = (short)1326383105;
					if (num2 != 0)
					{
					}
					if (undoableTask != null)
					{
						num2 = (short)347799562;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BD;
				case 8:
					goto IL_A6;
				case 9:
				{
					global::AcpCommonLib.UndoRedo.UndoManager.UndoHelper.CanRedo = false;
					num2 = (short)1787803082;
					short num4 = num2;
					num2 = (short)452769226;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_223;
					default:
						num2 = (short)685375488;
						if (num2 != 0)
						{
						}
						num2 = (short)1390411776;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 10:
					undoableTask.LaunchUI();
					num2 = (short)1791754246;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_3C;
				IL_A6:
				num2 = (short)243466245;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1BD:
				num2 = (short)760938498;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_223:
				global::AcpCommonLib.UndoRedo.UndoManager.UndoHelper.CanUndo = true;
				num2 = (short)627900424;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1B8:
			IL_24A:
			global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo = true;
			return true;
			IL_3C:
			global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo = false;
			undoableTask = global::AcpCommonLib.UndoRedo.UndoManager.e();
			num2 = (short)1935605767;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00013890 File Offset: 0x00011A90
		private static global::AcpCommonLib.UndoRedo.UndoableTask e()
		{
			short num = (short)1395350940;
			short num2 = num;
			num = (short)1081171356;
			switch (num2 == num)
			{
			}
			num = (short)4063232;
			if (num != 0)
			{
			}
			num = (short)953810944;
			short num3 = num;
			num = (short)320798721;
			if (num != 0)
			{
			}
			global::AcpCommonLib.AppInfoManager.UndoRedoInProgress = true;
			global::AcpCommonLib.UndoRedo.UndoableTask undoableTask = global::AcpCommonLib.UndoRedo.UndoManager.b.Pop();
			undoableTask.Do();
			global::AcpCommonLib.UndoRedo.UndoManager.a.Push(undoableTask);
			global::AcpCommonLib.AppInfoManager.UndoRedoInProgress = false;
			return undoableTask;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00013964 File Offset: 0x00011B64
		internal static bool b(int A_0)
		{
			short num = (short)945422345;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpCommonLib.UndoRedo.UndoableTask undoableTask;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (undoableTask != null)
					{
						num = (short)239796230;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					if (undoableTask != null)
					{
						num = (short)1159659527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19B;
				case 2:
				{
					int num3;
					if (num3 >= A_0)
					{
						num = (short)1225129992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					undoableTask = global::AcpCommonLib.UndoRedo.UndoManager.f();
					num = (short)2106654721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_CD;
				case 4:
					return false;
				case 5:
					goto IL_CD;
				case 6:
					goto IL_1CE;
				case 7:
				{
					int num3;
					num3++;
					num = (short)1815216131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					goto IL_19B;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				}
				IL_4D:
				num = (short)16121857;
				if (num != 0)
				{
				}
				if (A_0 > global::AcpCommonLib.UndoRedo.UndoManager.a.Count)
				{
					num = (short)409862144;
					short num4 = num;
					num = (short)898629636;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1296670867;
				short num5 = num;
				num = (short)1157931155;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1411710976;
					if (num != 0)
					{
					}
					undoableTask = null;
					int num3 = 0;
					num = (short)146079749;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_CD:
				num = (short)1151991810;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_19B:
				num = (short)934019072;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_1CE:
			undoableTask.LaunchUI();
			return true;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00013B80 File Offset: 0x00011D80
		internal static bool a(int A_0)
		{
			short num = (short)1601896456;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpCommonLib.UndoRedo.UndoableTask undoableTask;
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
					goto IL_9B;
				case 1:
					num3++;
					num = (short)92733449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					if (undoableTask == null)
					{
						return false;
					}
					num = (short)1617166336;
					short num4 = num;
					num = (short)192517972;
					short num5 = num;
					num = (short)1124964180;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F2;
					default:
						num = (short)1140654080;
						if (num != 0)
						{
						}
						num = (short)1441005571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_1C3;
				case 4:
					goto IL_72;
				case 5:
					if (undoableTask != null)
					{
						num = (short)121765889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11A;
				case 6:
					goto IL_11A;
				case 7:
					if (num3 >= A_0)
					{
						num = (short)74121222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					undoableTask = global::AcpCommonLib.UndoRedo.UndoManager.e();
					num = (short)404619269;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					continue;
				case 9:
					goto IL_9B;
				}
				IL_4E:
				if (A_0 > global::AcpCommonLib.UndoRedo.UndoManager.b.Count)
				{
					num = (short)406323204;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_F2;
				IL_9B:
				num = (short)1098579975;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F2:
				undoableTask = null;
				num3 = 0;
				num = (short)1904738304;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_11A:
				num = (short)363462658;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_72:
			num = (short)1072103425;
			if (num != 0)
			{
			}
			return false;
			IL_1C3:
			undoableTask.LaunchUI();
			return true;
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00013D98 File Offset: 0x00011F98
		internal static global::System.Collections.Generic.IEnumerable<string> UndoDescriptions
		{
			get
			{
				short num = (short)1032759979;
				short num2 = num;
				num = (short)1007200939;
				switch (num2 == num)
				{
				}
				num = (short)1925513216;
				if (num != 0)
				{
				}
				num = (short)1018167297;
				if (num != 0)
				{
				}
				num = (short)956366848;
				short num3 = num;
				return new global::AcpCommonLib.UndoRedo.UndoManager.a(-2);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00013E48 File Offset: 0x00012048
		internal static global::System.Collections.Generic.IEnumerable<string> RedoDescriptions
		{
			get
			{
				short num = (short)93453424;
				short num2 = num;
				num = (short)1472265328;
				switch (num2 == num)
				{
				}
				num = (short)1729036288;
				if (num != 0)
				{
				}
				num = (short)1956249601;
				if (num != 0)
				{
				}
				num = (short)639959040;
				short num3 = num;
				return new global::AcpCommonLib.UndoRedo.UndoManager.b(-2);
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00013EF8 File Offset: 0x000120F8
		public static void Reset()
		{
			short num = (short)1061879809;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			for (;;)
			{
				IL_33:
				int num2;
				switch (num2)
				{
				case 0:
					return;
				case 1:
					if (global::AcpCommonLib.UndoRedo.UndoManager.UndoHelper != null)
					{
						num = (short)1529151490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					goto IL_D9;
				}
				goto IL_45;
			}
			return;
			IL_45:
			global::AcpCommonLib.UndoRedo.UndoManager.b.Clear();
			global::AcpCommonLib.UndoRedo.UndoManager.a.Clear();
			num = (short)676377845;
			short num3 = num;
			num = (short)720876789;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_D9:
				num = (short)1365311488;
				short num4 = num;
				global::AcpCommonLib.UndoRedo.UndoManager.UndoHelper.CanUndo = false;
				global::AcpCommonLib.UndoRedo.UndoManager.UndoHelper.CanRedo = false;
				num = (short)1869283328;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
			default:
			{
				num = (short)893976576;
				if (num != 0)
				{
				}
				num = (short)2122645505;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00014038 File Offset: 0x00012238
		internal static string NextUndoTaskDescription
		{
			get
			{
				if (global::AcpCommonLib.UndoRedo.UndoManager.a.Count != 0)
				{
					short num = (short)1432370638;
					short num2 = num;
					num = (short)1944862158;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1846870017;
						if (num != 0)
						{
						}
						num = (short)1264254976;
						if (num != 0)
						{
						}
						num = (short)948043776;
						short num3 = num;
						return global::AcpCommonLib.UndoRedo.UndoManager.a.Peek().ToString();
					}
					}
				}
				return null;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00014100 File Offset: 0x00012300
		internal static string NextRedoTaskDescription
		{
			get
			{
				if (global::AcpCommonLib.UndoRedo.UndoManager.b.Count != 0)
				{
					short num = (short)1812887106;
					short num2 = num;
					num = (short)1391490626;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1442447361;
						if (num != 0)
						{
						}
						num = (short)1772027904;
						if (num != 0)
						{
						}
						num = (short)1781268480;
						short num3 = num;
						return global::AcpCommonLib.UndoRedo.UndoManager.b.Peek().ToString();
					}
					}
				}
				return null;
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x000141C4 File Offset: 0x000123C4
		// Note: this type is marked as 'beforefieldinit'.
		static UndoManager()
		{
			short num = (short)1625358416;
			short num2 = num;
			num = (short)303431760;
			switch (num2 == num)
			{
			}
			num = (short)591593473;
			if (num != 0)
			{
			}
			num = (short)1223032832;
			if (num != 0)
			{
			}
			num = (short)217120768;
			short num3 = num;
			global::AcpCommonLib.UndoRedo.UndoManager.a = new global::System.Collections.Generic.Stack<global::AcpCommonLib.UndoRedo.UndoableTask>();
			global::AcpCommonLib.UndoRedo.UndoManager.b = new global::System.Collections.Generic.Stack<global::AcpCommonLib.UndoRedo.UndoableTask>();
			global::AcpCommonLib.UndoRedo.UndoManager.LaunchSectionHandler = null;
		}

		// Token: 0x040000A6 RID: 166
		private static global::System.Collections.Generic.Stack<global::AcpCommonLib.UndoRedo.UndoableTask> a;

		// Token: 0x040000A7 RID: 167
		private static global::System.Collections.Generic.Stack<global::AcpCommonLib.UndoRedo.UndoableTask> b;

		// Token: 0x040000A8 RID: 168
		public static global::AcpCommonLib.LaunchSection LaunchSectionHandler;

		// Token: 0x040000A9 RID: 169
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool c;

		// Token: 0x040000AA RID: 170
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpCommonLib.UndoRedo.AcpUndoHelper d;
	}
}
