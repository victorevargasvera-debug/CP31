using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.UI.CellRangeFill.Constraints;

namespace Motorola.CommonCPS.UI.CellRangeFill.UndoRedo
{
	// Token: 0x02000027 RID: 39
	public class ContainerTask : global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoableTask
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x0000CAA0 File Offset: 0x0000ACA0
		public ContainerTask(string description)
		{
			this.IsOpen = true;
			this.a = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoableTask>();
			base.Description = description;
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000CACC File Offset: 0x0000ACCC
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x0000CB7C File Offset: 0x0000AD7C
		public bool IsOpen
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)10041200;
				short num2 = num;
				num = (short)491534192;
				switch (num2 == num)
				{
				}
				num = (short)1836318720;
				if (num != 0)
				{
				}
				num = (short)686424065;
				if (num != 0)
				{
				}
				num = (short)506134528;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1571293246;
				short num2 = num;
				num = (short)245631038;
				switch (num2 == num)
				{
				}
				num = (short)1020592129;
				if (num != 0)
				{
				}
				num = (short)2011627520;
				if (num != 0)
				{
				}
				num = (short)1074528256;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000CC2C File Offset: 0x0000AE2C
		public override void Do()
		{
			short num = (short)541786113;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoableTask>.Enumerator enumerator;
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)1332805632;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				}
				case 2:
					try
					{
						num = (short)991494145;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							num = (short)2001492610;
							short num4 = num;
							num = (short)1292130946;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1524695040;
								if (num != 0)
								{
								}
								switch (num2)
								{
								case 0:
									goto IL_1A3;
								case 1:
									goto IL_BC;
								case 3:
									num = (short)1219035136;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)1872429059;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									enumerator.Current.Do();
									num = (short)2100363266;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_129;
							}
							IL_BC:
							switch (0)
							{
							case 0:
								IL_129:
								goto IL_151;
							}
							continue;
							IL_151:
							num = (short)1921515524;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1A3:
						return;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1B3;
				case 3:
					goto IL_1B3;
				}
				IL_5D:
				if (!this.IsOpen)
				{
					num = (short)1654063105;
					if (num != 0)
					{
					}
					num = (short)912064515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.IsOpen = false;
				num = (short)198246400;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B3:
				enumerator = this.a.GetEnumerator();
				num = (short)370868226;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000CE48 File Offset: 0x0000B048
		public override void Undo()
		{
			switch (0)
			{
			case 0:
				goto IL_73;
			}
			short num;
			for (;;)
			{
				IL_0A:
				num = (short)376438785;
				if (num != 0)
				{
				}
				num = (short)1355284480;
				short num2 = num;
				int num3;
				switch (num3)
				{
				case 0:
					goto IL_E7;
				case 1:
					goto IL_E7;
				case 2:
					return;
				case 3:
				{
					int num4;
					if (num4 < 0)
					{
						num = (short)475856898;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.a[num4].Undo();
					num4--;
					num = (short)1789394944;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_73;
				IL_E7:
				num = (short)1168310275;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_73:
			num = (short)1390369469;
			short num5 = num;
			num = (short)470506173;
			switch ((num5 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num = (short)559677440;
				if (num != 0)
				{
				}
				int num4 = this.a.Count - 1;
				num = (short)1929314305;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000CFA4 File Offset: 0x0000B1A4
		public void AddTask(global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoableTask task)
		{
			int a_ = 17;
			short num = (short)877199360;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2108083059;
				short num3 = num;
				num = (short)1103219571;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_148;
				default:
					num = (short)584056832;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_8A;
						}
						continue;
					case 1:
						if (!this.IsOpen)
						{
							num = (short)1612578818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_148;
					case 2:
						goto IL_10A;
					case 3:
						goto IL_A2;
					}
					IL_8A:
					if (task == null)
					{
						num = (short)1794113539;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)298254337;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_A2:
			num = (short)1147994113;
			if (num != 0)
			{
			}
			num = (short)445644800;
			short num4 = num;
			throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("곗믙꿛뗝", a_));
			IL_10A:
			throw new global::System.InvalidOperationException();
			IL_148:
			task.Do();
			this.a.Add(task);
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000D10C File Offset: 0x0000B30C
		public int TaskCount
		{
			get
			{
				short num = (short)2052325376;
				short num2 = num;
				num = (short)1644953601;
				if (num != 0)
				{
				}
				num = (short)1734860769;
				short num3 = num;
				num = (short)881450977;
				switch (num3 == num)
				{
				}
				num = (short)2025127936;
				if (num != 0)
				{
				}
				return this.a.Count;
			}
		}

		// Token: 0x0400004A RID: 74
		private readonly global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoableTask> a;

		// Token: 0x0400004B RID: 75
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b;
	}
}
