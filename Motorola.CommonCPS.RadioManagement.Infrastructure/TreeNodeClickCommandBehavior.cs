using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Controls.Menus;
using Microsoft.Practices.Prism.Commands;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000030 RID: 48
	public class TreeNodeClickCommandBehavior : global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree>
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x0000C6EC File Offset: 0x0000A8EC
		public TreeNodeClickCommandBehavior(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree dataTree) : base(dataTree)
		{
			dataTree.PreviewMouseLeftButtonDown += this.a;
			dataTree.PreviewMouseRightButtonDown += this.a;
			dataTree.KeyDown += this.a;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000C738 File Offset: 0x0000A938
		private void a(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)470876160;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5B;
				}
				global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree rmdataTree;
				for (;;)
				{
					IL_28:
					global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl;
					global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase item2;
					global::System.Windows.DependencyObject dependencyObject;
					switch (num2)
					{
					case 0:
						goto IL_269;
					case 1:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase item = (global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase)xamDataTreeNodeControl.Node.Data;
						xamDataTreeNodeControl.Focus();
						base.CommandParameter = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>
						{
							item2,
							item
						};
						global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor waitCursor = new global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor();
						num = (short)1891041290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (rmdataTree.ActiveNode != null)
						{
							num = (short)223870979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26E;
					case 3:
					{
						num = (short)178021386;
						short num3 = num;
						num = (short)1457742858;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_78;
						default:
							num = (short)1267138560;
							if (num != 0)
							{
							}
							item2 = (rmdataTree.ActiveNode.Data as global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase);
							num = (short)288423943;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						if (dependencyObject == null)
						{
							num = (short)1894514696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_163;
					case 5:
						if (xamDataTreeNodeControl != null)
						{
							num = (short)1708589057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						goto IL_78;
					case 7:
						goto IL_26E;
					case 8:
						return;
					case 9:
						return;
					case 10:
						try
						{
							num = (short)1947402241;
							if (num != 0)
							{
							}
							this.ExecuteCommand();
							goto IL_245;
						}
						finally
						{
							num = (short)351862785;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor waitCursor;
								switch (num2)
								{
								case 0:
									goto IL_160;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_128;
									}
									continue;
								case 2:
									((global::System.IDisposable)waitCursor).Dispose();
									num = (short)232652800;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_128:
								if (waitCursor == null)
								{
									break;
								}
								num = (short)609615874;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_160:;
						}
						goto IL_163;
						IL_245:
						xamDataTreeNodeControl.Node.IsSelected = true;
						num = (short)800784384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5B;
					IL_78:
					num = (short)1300758528;
					short num4 = num;
					if (rmdataTree == null)
					{
						num = (short)795607049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					item2 = null;
					num = (short)2119499778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_163:
					xamDataTreeNodeControl = global::Motorola.CommonCPS.RadioManagement.Infrastructure.TreeNodeClickCommandBehavior.a<global::Infragistics.Controls.Menus.XamDataTreeNodeControl>(dependencyObject);
					num = (short)606011397;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26E:
					dependencyObject = (A_1.OriginalSource as global::System.Windows.DependencyObject);
					num = (short)2010841092;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_269:
				return;
				IL_5B:
				rmdataTree = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree);
				num = (short)1676148742;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000CA84 File Offset: 0x0000AC84
		private void a(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			short num = (short)695402496;
			switch (num)
			{
			default:
			{
				num = (short)1535508490;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree rmdataTree;
					global::System.Windows.DependencyObject dependencyObject;
					switch (num2)
					{
					case 0:
					{
						global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl;
						global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase item = (global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase)xamDataTreeNodeControl.Node.Data;
						xamDataTreeNodeControl.Focus();
						global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase item2;
						base.CommandParameter = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>
						{
							item,
							item2
						};
						global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor waitCursor = new global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor();
						num = (short)1073545223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_10D;
					case 2:
						return;
					case 3:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase item2 = rmdataTree.ActiveNode.Data as global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase;
						num = (short)50397185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_25D;
					case 5:
					{
						num = (short)450494465;
						if (num != 0)
						{
						}
						global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl;
						if (xamDataTreeNodeControl != null)
						{
							num = (short)160235520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 6:
						if (rmdataTree.ActiveNode != null)
						{
							num = (short)1742143491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10D;
					case 7:
						try
						{
							this.ExecuteCommand();
							return;
						}
						finally
						{
							num = (short)287965185;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor waitCursor;
								switch (num2)
								{
								case 0:
									((global::System.IDisposable)waitCursor).Dispose();
									num = (short)1502609410;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1D6;
									}
									continue;
								case 2:
									goto IL_25A;
								}
								IL_1D6:
								num = (short)932998598;
								short num3 = num;
								num = (short)1708682694;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)401080320;
									if (num != 0)
									{
									}
									if (waitCursor == null)
									{
										goto IL_25C;
									}
									break;
								}
								num = (short)88014848;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_25A:
							IL_25C:;
						}
						goto IL_25D;
					case 8:
					{
						if (dependencyObject == null)
						{
							num = (short)1229520898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl = global::Motorola.CommonCPS.RadioManagement.Infrastructure.TreeNodeClickCommandBehavior.a<global::Infragistics.Controls.Menus.XamDataTreeNodeControl>(dependencyObject);
						num = (short)1112342533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_154;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					case 11:
					{
						num = (short)643956736;
						short num4 = num;
						if (A_1.Key == global::System.Windows.Input.Key.Up)
						{
							num = (short)2015559689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 12:
						return;
					case 13:
					{
						if (rmdataTree == null)
						{
							num = (short)241631244;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase item2 = null;
						num = (short)1595080710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_7D:
					if (A_1.Key != global::System.Windows.Input.Key.Down)
					{
						num = (short)198311940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_154;
					IL_10D:
					dependencyObject = (A_1.OriginalSource as global::System.Windows.DependencyObject);
					num = (short)1159856136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_154:
					rmdataTree = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree);
					num = (short)1679360013;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25D:
					num = (short)1169817611;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000CE3C File Offset: 0x0000B03C
		private static a a<a>(global::System.Windows.DependencyObject A_0) where a : class
		{
			short num = (short)301727749;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.DependencyObject dependencyObject;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)879296513;
					if (num != 0)
					{
					}
					if (dependencyObject is a)
					{
						num = (short)696123393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_66;
				case 1:
					goto IL_17B;
				case 2:
					goto IL_66;
				case 3:
					goto IL_61;
				case 4:
					num = (short)1098252288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 6:
					if (dependencyObject != null)
					{
						num = (short)109641732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17D;
				}
				IL_41:
				if (A_0 is a)
				{
					num = (short)522584067;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				dependencyObject = A_0;
				num = (short)1739587586;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_66:
				num = (short)2110174050;
				short num3 = num;
				num = (short)754168674;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1825701888;
					if (num != 0)
					{
					}
					dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
					num = (short)1069088774;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_61:
			return A_0 as a;
			IL_17B:
			IL_17D:
			num = (short)685441024;
			short num4 = num;
			return dependencyObject as a;
		}
	}
}
