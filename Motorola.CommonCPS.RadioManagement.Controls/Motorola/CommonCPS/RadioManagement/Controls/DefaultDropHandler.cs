using System;
using System.Windows;
using Infragistics.Controls.Menus;
using Infragistics.Controls.Menus.Primitives;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000048 RID: 72
	public class DefaultDropHandler : global::Motorola.CommonCPS.RadioManagement.Controls.IDropTarget
	{
		// Token: 0x0600010D RID: 269 RVA: 0x00010E4C File Offset: 0x0000F04C
		public void DragOver(global::Motorola.CommonCPS.RadioManagement.Controls.DropInfo dropInfo, global::System.Windows.DragEventArgs e)
		{
			short num = (short)313613488;
			short num2 = num;
			num = (short)1682594992;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)662044672;
				if (num != 0)
				{
				}
				num = (short)1093533697;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			bool flag;
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_96;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_79;
					}
					continue;
				case 2:
					goto IL_10D;
				}
				IL_79:
				if (!global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDropHandler.a(dropInfo))
				{
					num = (short)1143799808;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					flag = (dropInfo.TargetItem is global::Infragistics.Controls.Menus.XamDataTreeNodeControl);
					num = (short)639369218;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			IL_96:
			num = (short)421265408;
			short num4 = num;
			num = (short)1856962561;
			if (num != 0)
			{
			}
			return;
			IL_10D:
			dropInfo.DropTargetAdornerType = (flag ? global::Motorola.CommonCPS.RadioManagement.Controls.DropTargetAdorners.Highlight : global::Motorola.CommonCPS.RadioManagement.Controls.DropTargetAdorners.Insert);
			this.b(dropInfo);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00010F88 File Offset: 0x0000F188
		public void DetatchAdorner()
		{
			while (this.a != null)
			{
				short num = (short)1155399681;
				if (num != 0)
				{
				}
				num = (short)749919937;
				short num2 = num;
				num = (short)1175183041;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1676673024;
					if (num != 0)
					{
					}
					num = (short)1654128640;
					short num3 = num;
					try
					{
						this.a.Detatch();
						this.a = null;
					}
					catch
					{
					}
					return;
				}
				}
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00011068 File Offset: 0x0000F268
		private void b(global::Motorola.CommonCPS.RadioManagement.Controls.DropInfo A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::Infragistics.Controls.Menus.Primitives.NodesPanel visualDescendent;
				switch (num)
				{
				case 0:
					this.a = global::Motorola.CommonCPS.RadioManagement.Controls.DropTargetAdorner.a(A_0.DropTargetAdornerType, visualDescendent);
					num2 = (short)337641473;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_1E3;
				case 2:
					if (A_0.DropTargetAdornerType == null)
					{
						num2 = (short)345440261;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)836763659;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)1706424425;
					short num3 = num2;
					num2 = (short)1906964585;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19C;
					default:
						num2 = (short)1175977984;
						if (num2 != 0)
						{
						}
						this.a.DropInfo = A_0;
						this.a.InvalidateVisual();
						num2 = (short)322174980;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					return;
				case 5:
					this.a = null;
					num2 = (short)1368064001;
					if (num2 != 0)
					{
					}
					num2 = (short)1120534534;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_1E3;
				case 7:
					if (this.a != null)
					{
						num2 = (short)113508355;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 8:
				{
					num2 = (short)385679360;
					short num4 = num2;
					goto IL_19C;
				}
				case 9:
					num2 = (short)660340738;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (A_0.VisualTarget != null)
					{
						num2 = (short)1181941768;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 11:
					if (!A_0.DropTargetAdornerType.IsInstanceOfType(this.a))
					{
						num2 = (short)196608;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1E3;
				case 12:
					if (visualDescendent != null)
					{
						num2 = (short)1174208521;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_44;
				IL_19C:
				visualDescendent = A_0.VisualTarget.GetVisualDescendent<global::Infragistics.Controls.Menus.Primitives.NodesPanel>();
				num2 = (short)960954380;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1E3:
				num2 = (short)1865089031;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_44:
			this.DetatchAdorner();
			num2 = (short)256638986;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0001132C File Offset: 0x0000F52C
		private static bool a(global::Motorola.CommonCPS.RadioManagement.Controls.DropInfo A_0)
		{
			if (A_0 == null)
			{
				short num = (short)284619405;
				short num2 = num;
				num = (short)395178637;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)284557313;
					if (num != 0)
					{
					}
					num = (short)86441984;
					if (num != 0)
					{
					}
					num = (short)1855586304;
					short num3 = num;
					return false;
				}
				}
			}
			return true;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000113E0 File Offset: 0x0000F5E0
		public void Drop(global::Motorola.CommonCPS.RadioManagement.Controls.DropInfo dropInfo)
		{
			short num = (short)724092264;
			short num2 = num;
			num = (short)1996408168;
			switch (num2 == num)
			{
			}
			num = (short)1541537792;
			short num3 = num;
			num = (short)1640628225;
			if (num != 0)
			{
			}
			num = (short)1396441088;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0001148C File Offset: 0x0000F68C
		private DefaultDropHandler()
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000113 RID: 275 RVA: 0x000114A0 File Offset: 0x0000F6A0
		public static global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDropHandler Instance
		{
			get
			{
				short num = (short)200867841;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_E5;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
					{
						num = (short)1299140613;
						short num3 = num;
						num = (short)1117868037;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E5;
						default:
							num = (short)467009536;
							if (num != 0)
							{
							}
							global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDropHandler.b = new global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDropHandler();
							num = (short)946470913;
							if (num != 0)
							{
							}
							num = (short)1469579264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_31:
					if (global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDropHandler.b != null)
					{
						goto IL_10F;
					}
					num = (short)1901985794;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E5:
				num = (short)33488896;
				short num4 = num;
				IL_10F:
				return global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDropHandler.b;
			}
		}

		// Token: 0x04000028 RID: 40
		private global::Motorola.CommonCPS.RadioManagement.Controls.DropTargetAdorner a;

		// Token: 0x04000029 RID: 41
		private static global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDropHandler b;
	}
}
