using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using Infragistics.Controls.Menus;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200003E RID: 62
	public static class DragDropExtention
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x0000CD58 File Offset: 0x0000AF58
		public static bool GetIsDragDropSource(global::System.Windows.DependencyObject obj)
		{
			short num = (short)447165901;
			short num2 = num;
			num = (short)2004891085;
			switch (num2 == num)
			{
			}
			num = (short)1506017280;
			short num3 = num;
			num = (short)1886650369;
			if (num != 0)
			{
			}
			num = (short)985530368;
			if (num != 0)
			{
			}
			return (bool)obj.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.IsDragDropSourceProperty);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000CE10 File Offset: 0x0000B010
		public static void SetIsDragDropSource(global::System.Windows.DependencyObject obj, bool value)
		{
			short num = (short)1170799142;
			short num2 = num;
			num = (short)2110716454;
			switch (num2 == num)
			{
			}
			num = (short)734986240;
			short num3 = num;
			num = (short)1206976512;
			if (num != 0)
			{
			}
			num = (short)296222721;
			if (num != 0)
			{
			}
			obj.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.IsDragDropSourceProperty, value);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000CECC File Offset: 0x0000B0CC
		private static void OnIsDragDropSourceChanged(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree;
			short num2;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_140;
				case 1:
					while (xamDataTree != null)
					{
						num2 = (short)1422190803;
						short num3 = num2;
						num2 = (short)2007165139;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)586022912;
							if (num2 != 0)
							{
							}
							num2 = (short)2119696386;
							num = (int)((global::System.IntPtr)num2);
							goto IL_0A;
						}
					}
					return;
				case 2:
				{
					num2 = (short)1514405888;
					short num4 = num2;
					num2 = (short)745930756;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_1EE;
				case 4:
					if (flag)
					{
						num2 = (short)245891075;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					xamDataTree.PreviewMouseLeftButtonDown -= global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.a;
					xamDataTree.PreviewMouseLeftButtonUp -= global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.b;
					xamDataTree.PreviewMouseMove -= global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.b;
					xamDataTree.QueryContinueDrag -= global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.a;
					num2 = (short)218824705;
					if (num2 != 0)
					{
					}
					num2 = (short)385941504;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_140:
			return;
			IL_1EE:
			xamDataTree.PreviewMouseLeftButtonDown += global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.a;
			xamDataTree.PreviewMouseLeftButtonUp += global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.b;
			xamDataTree.PreviewMouseMove += global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.b;
			xamDataTree.QueryContinueDrag += global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.a;
			return;
			IL_24:
			xamDataTree = (A_0 as global::Infragistics.Controls.Menus.XamDataTree);
			flag = (bool)A_1.NewValue;
			num2 = (short)86114305;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000D0CC File Offset: 0x0000B2CC
		private static void a(object A_0, global::System.Windows.QueryContinueDragEventArgs A_1)
		{
			short num = (short)1181417476;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)177012737;
					if (num != 0)
					{
					}
					A_1.Action = global::System.Windows.DragAction.Cancel;
					num = (short)23461894;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (A_1.Action == global::System.Windows.DragAction.Cancel)
					{
						goto IL_116;
					}
					return;
				case 2:
				{
					num = (short)21949915;
					short num3 = num;
					num = (short)154594779;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_116;
					default:
						goto IL_1AB;
					}
					break;
				}
				case 3:
					if (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c != null)
					{
						num = (short)1859518469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 5:
				{
					num = (short)231276544;
					short num4 = num;
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.Clear();
					num = (short)57212930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_F3;
				case 7:
					num = (short)1851392003;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_44:
				if (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.Escape))
				{
					num = (short)1812463616;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_F3:
				num = (short)931594241;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_116:
				num = (short)1094254599;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1AB:
			num = (short)510394368;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000D29C File Offset: 0x0000B49C
		private static void b(object A_0, global::System.Windows.Input.MouseEventArgs A_1)
		{
			int a_ = 18;
			short num = (short)1682571264;
			switch (num)
			{
			default:
			{
				num = (short)686555149;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1807679490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDragHandler instance;
						if (instance.CanStartDrag(global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c))
						{
							num = (short)781975552;
							short num3 = num;
							num = (short)2121269271;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
					{
						global::System.Windows.Point position;
						if (global::System.Math.Abs(position.Y - global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.DragStartPoint.Y) > global::System.Windows.SystemParameters.MinimumVerticalDragDistance)
						{
							num = (short)1242169369;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 3:
					{
						object obj;
						global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.Data = obj;
						num = (short)1162346502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)1509294087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						if (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.f == null)
						{
							num = (short)611319820;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						object obj = global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.f(A_0, new global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventArgs(global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.DragItem));
						num = (short)1386020878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.Effects = global::System.Windows.DragDropEffects.Copy;
						global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.a = true;
						global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDragHandler instance;
						instance.StartDrag(global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c);
						num = (short)694812680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						object obj;
						if (global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.IsMarkedAsSerializable(obj.GetType()))
						{
							num = (short)391380995;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21D;
					}
					case 8:
						if (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.Effects != global::System.Windows.DragDropEffects.None)
						{
							num = (short)1711144982;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_2F1;
							}
							for (;;)
							{
								IL_2DA:
								switch (num2)
								{
								case 0:
									goto IL_3E3;
								case 1:
									goto IL_3CB;
								case 2:
								{
									global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDragHandler instance;
									instance.DragCancelled();
									num = (short)710410241;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::System.Windows.DragDropEffects dragDropEffects;
									if (dragDropEffects == global::System.Windows.DragDropEffects.None)
									{
										num = (short)549781506;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3CB;
								}
								}
								goto IL_2F1;
								IL_3CB:
								num = (short)256114688;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3E3:
							goto IL_3EF;
							for (;;)
							{
								IL_2F1:
								global::System.Windows.DataObject data = new global::System.Windows.DataObject(global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.Format, global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.Data);
								global::System.Windows.DragDropEffects dragDropEffects = global::System.Windows.DragDrop.DoDragDrop(global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.VisualSource, data, global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.Effects);
								num = (short)1725471613;
								short num4 = num;
								num = (short)332962685;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_35D;
								}
							}
							IL_35D:
							num = (short)650313728;
							if (num != 0)
							{
							}
							num = (short)590544899;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2DA;
						}
						catch
						{
						}
						finally
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.a = false;
						}
						IL_3EF:
						global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.Clear();
						num = (short)680394762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_411;
					case 11:
					{
						if (A_1.LeftButton == global::System.Windows.Input.MouseButtonState.Released)
						{
							num = (short)994050066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Point position = A_1.GetPosition((global::System.Windows.IInputElement)A_0);
						num = (short)836304915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_26D;
					case 13:
						switch (0)
						{
						case 0:
							goto IL_BC;
						}
						continue;
					case 14:
					{
						object obj;
						if (obj != null)
						{
							num = (short)1239285764;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21D;
					}
					case 15:
					{
						global::System.Windows.Point position;
						if (global::System.Math.Abs(position.X - global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.DragStartPoint.X) <= global::System.Windows.SystemParameters.MinimumHorizontalDragDistance)
						{
							num = (short)1547370496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_416;
					}
					case 16:
					{
						if (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.DragItem == null)
						{
							num = (short)491847704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDragHandler instance = global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDragHandler.Instance;
						num = (short)998637569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.a)
						{
							num = (short)122290202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)53608459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_218;
					case 19:
						if (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.VisualSource == A_0)
						{
							num = (short)1741619220;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 20:
						num = (short)336592897;
						if (num != 0)
						{
						}
						num = (short)1745813519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.Data != null)
						{
							num = (short)296026121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 22:
						num = (short)637141013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num = (short)441778181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_46B;
					case 25:
						goto IL_416;
					case 26:
						return;
					case 27:
						num = (short)1482883089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_BC:
					if (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c != null)
					{
						num = (short)1979777051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_416:
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.DragItem = global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.GetDragItem(global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c);
					num = (short)2112552976;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_218:
				global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.Clear();
				return;
				IL_21D:
				throw new global::System.Exception(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("鮩芫躭삯삱\udbb3삵톷\udeb9\ud9bb麽뒿꫁ꇃ곇ꯉ룋꿍껙ꗛ껝藟싡诣胥죧黩蓫语탯雱闳苵駷\udaf9賻賽濿琁洃戅洇渉Ⰻ昍焏愑㐓䔕紗栙甛缝䰟䬡帣䜥䨧䘩䤫漭䐯䘱䘳張娷伹䠻嬽", a_));
				IL_26D:
				throw new global::System.Exception(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쎫\udbad邯\udfb1솳억첷骹캻\udbbdꞿꯁ럃닅귇룉諍ꋏ돑돓鋕맗껙뷛賝藟鏡釣菥鯧黩쳫语蛯韱髳苵\ud8f7軹鏻\udefd烿瀁欃瀅愇渉椋⸍琏猑怓眕㠗簙猛氝\u001f䘡嘣䜥伧䴩䔫䀭圯", a_));
				IL_411:
				return;
				IL_46B:
				global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.Clear();
				return;
			}
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000D978 File Offset: 0x0000BB78
		private static void b(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)1492189186;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_B9;
				case 1:
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.Clear();
					num = (short)2082799616;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)57456817;
					short num3 = num;
					num = (short)1681111217;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1134100480;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					}
					break;
				}
				}
				IL_7E:
				if (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c == null)
				{
					goto IL_E3;
				}
				num = (short)786104321;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B9:
			num = (short)258736129;
			if (num != 0)
			{
			}
			IL_E3:
			num = (short)1174929408;
			short num4 = num;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000DA94 File Offset: 0x0000BC94
		private static void a(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)327090182;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.Point position;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					return;
				case 2:
					goto IL_B6;
				case 3:
					if (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c == null)
					{
						num = (short)1303642117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A2;
				case 4:
					goto IL_17A;
				case 5:
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c = global::Motorola.CommonCPS.RadioManagement.Controls.DragInfo.Instance;
					num = (short)831651842;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				}
				IL_40:
				if (A_1.ClickCount != 1)
				{
					num = (short)966393857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				position = A_1.GetPosition((global::System.Windows.IInputElement)A_0);
				num = (short)1303422814;
				short num3 = num;
				num = (short)1069197150;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)614465537;
					if (num != 0)
					{
					}
					num = (short)938606592;
					if (num != 0)
					{
					}
					num = (short)1172242432;
					short num4 = num;
					num = (short)1722286084;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_17A:
				if (global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.HitTestOnType<global::System.Windows.Controls.Primitives.RangeBase>(A_0, position))
				{
					num = (short)599588864;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)46792707;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return;
			IL_B6:
			IL_1A2:
			global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.DragStartPoint = position;
			global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c.VisualSource = (A_0 as global::System.Windows.UIElement);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000DC60 File Offset: 0x0000BE60
		public static bool GetIsDropTarget(global::System.Windows.UIElement target)
		{
			short num = (short)1307267603;
			short num2 = num;
			num = (short)581259795;
			switch (num2 == num)
			{
			}
			num = (short)2017591297;
			if (num != 0)
			{
			}
			num = (short)669057024;
			if (num != 0)
			{
			}
			num = (short)170721280;
			short num3 = num;
			return (bool)target.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.IsDropTargetProperty);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000DD18 File Offset: 0x0000BF18
		public static void SetIsDropTarget(global::System.Windows.UIElement target, bool value)
		{
			short num = (short)425005906;
			short num2 = num;
			num = (short)874451794;
			switch (num2 == num)
			{
			}
			num = (short)1480392704;
			if (num != 0)
			{
			}
			num = (short)324730881;
			if (num != 0)
			{
			}
			num = (short)1885536256;
			short num3 = num;
			target.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.IsDropTargetProperty, value);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000DDD0 File Offset: 0x0000BFD0
		private static void OnIsDropTargetChanged(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				bool flag;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_242;
					case 1:
						num2 = (short)898105346;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
					{
						num2 = (short)1689951314;
						short num3 = num2;
						num2 = (short)1774558290;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num2 = (short)1027407872;
							if (num2 != 0)
							{
							}
							num2 = (short)590807040;
							short num4 = num2;
							if (flag)
							{
								num2 = (short)360120320;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							xamDataTree.AllowDrop = false;
							xamDataTree.PreviewDragEnter -= global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.a;
							xamDataTree.PreviewDragLeave -= global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.b;
							xamDataTree.PreviewDragOver -= global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c;
							xamDataTree.PreviewMouseMove -= global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.a;
							xamDataTree.Drop -= global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.d;
							xamDataTree.GiveFeedback -= global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.a;
							num2 = (short)1202192387;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 3:
						goto IL_121;
					case 4:
						num2 = (short)1238761473;
						if (num2 != 0)
						{
						}
						if (xamDataTree != null)
						{
							num2 = (short)897187841;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				IL_24:
				xamDataTree = (A_0 as global::Infragistics.Controls.Menus.XamDataTree);
				flag = (bool)A_1.NewValue;
				num2 = (short)440729604;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_121:
			return;
			IL_242:
			xamDataTree.AllowDrop = true;
			xamDataTree.PreviewDragEnter += global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.a;
			xamDataTree.PreviewDragLeave += global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.b;
			xamDataTree.PreviewDragOver += global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c;
			xamDataTree.PreviewMouseMove += global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.a;
			xamDataTree.Drop += global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.d;
			xamDataTree.GiveFeedback += global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.a;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000E024 File Offset: 0x0000C224
		private static void a(object A_0, global::System.Windows.Input.MouseEventArgs A_1)
		{
			short num = (short)425394177;
			if (num != 0)
			{
			}
			num = (short)1385299968;
			short num2 = num;
			if (A_1.LeftButton != global::System.Windows.Input.MouseButtonState.Released)
			{
				num = (short)689725895;
				short num3 = num;
				num = (short)910123463;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)85000192;
					if (num != 0)
					{
					}
					return;
				}
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDropHandler.Instance.DetatchAdorner();
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000E0E4 File Offset: 0x0000C2E4
		private static void a(object A_0, global::System.Windows.GiveFeedbackEventArgs A_1)
		{
			short num = (short)1075184272;
			short num2 = num;
			num = (short)1910243984;
			switch (num2 == num)
			{
			}
			num = (short)763232257;
			if (num != 0)
			{
			}
			num = (short)1587216384;
			if (num != 0)
			{
			}
			num = (short)576585728;
			short num3 = num;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000E190 File Offset: 0x0000C390
		private static void d(object A_0, global::System.Windows.DragEventArgs A_1)
		{
			global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs targetDroppedEventArgs;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_28;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_1A9;
					case 1:
						num2 = (short)1842741249;
						if (num2 != 0)
						{
						}
						targetDroppedEventArgs = new global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs(global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.d.TargetItem, global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.GetDragDataFromSysMemory(A_1, global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.b), A_1.Effects);
						num2 = (short)1178009603;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						num2 = (short)191954948;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_CC;
					case 4:
					{
						if (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.d.TargetItem == null)
						{
							goto IL_191;
						}
						num2 = (short)1722312759;
						short num3 = num2;
						num2 = (short)48326711;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num2 = (short)913637376;
							if (num2 != 0)
							{
							}
							num2 = (short)1012006912;
							short num4 = num2;
							num2 = (short)355074049;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 5:
						if (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.d != null)
						{
							num2 = (short)590544898;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_191;
					}
					break;
					IL_191:
					num2 = (short)2118975488;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_28:
				global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDropHandler.Instance.Drop(global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.d);
				num2 = (short)299630597;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_CC:
			global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs> eventHandler = global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.e;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.d.VisualTarget, targetDroppedEventArgs);
			return;
			IL_1A9:
			global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs> eventHandler2 = global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.e;
			if (eventHandler2 == null)
			{
				return;
			}
			eventHandler2(null, global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs.Empty);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000E370 File Offset: 0x0000C570
		private static void c(object A_0, global::System.Windows.DragEventArgs A_1)
		{
			short num = (short)207224832;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Point position;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 1:
					if (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.d == null)
					{
						num = (short)1575288843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_318;
				case 2:
					goto IL_1CD;
				case 3:
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.d.IsDataAccepted = global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.g(A_0, new global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventArgs(global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.d.TargetItem, global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.GetDragDataFromSysMemory(A_1, global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.b), A_1.Effects));
					num = (short)1125187596;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1AA;
				case 5:
					A_1.Effects = global::System.Windows.DragDropEffects.None;
					num = (short)1472135181;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_2D6;
				case 7:
					goto IL_367;
				case 8:
					if (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.g != null)
					{
						num = (short)1986789379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_36C;
				case 9:
					goto IL_318;
				case 10:
				{
					if (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.d.VisualTarget == null)
					{
						num = (short)615448583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					position = A_1.GetPosition((global::System.Windows.IInputElement)A_0);
					num = (short)163917717;
					short num3 = num;
					num = (short)790900629;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AA;
					default:
						num = (short)1098711041;
						if (num != 0)
						{
						}
						num = (short)1497038848;
						if (num != 0)
						{
						}
						num = (short)538312708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 11:
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.d = global::Motorola.CommonCPS.RadioManagement.Controls.DropInfo.Instance;
					num = (short)327811081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (!global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.d.IsDataAccepted)
					{
						num = (short)246087685;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					A_1.Effects = global::System.Windows.DragDropEffects.Copy;
					num = (short)1552220166;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_22F;
				case 14:
					goto IL_AD;
				}
				IL_61:
				num = (short)1660354560;
				short num4 = num;
				if (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.a)
				{
					num = (short)110821390;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)859963393;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AA:
				if (global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.HitTestOnType<global::System.Windows.Controls.Primitives.RangeBase>(A_0, position))
				{
					num = (short)1603207170;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.d.TargetItem = global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.GetTargetItem(global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.d);
				global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.d.CurrentMouseLocation = position;
				num = (short)1575878664;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_318:
				global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.d.VisualTarget = (A_0 as global::System.Windows.UIElement);
				num = (short)252968970;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AD:
			A_1.Effects = global::System.Windows.DragDropEffects.None;
			A_1.Handled = true;
			return;
			IL_1CD:
			A_1.Effects = global::System.Windows.DragDropEffects.None;
			A_1.Handled = true;
			return;
			IL_22F:
			IL_2D6:
			goto IL_36C;
			IL_367:
			global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.d.Clear();
			return;
			IL_36C:
			global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDropHandler instance = global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDropHandler.Instance;
			instance.DragOver(global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.d, A_1);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000E6FC File Offset: 0x0000C8FC
		private static void b(object A_0, global::System.Windows.DragEventArgs A_1)
		{
			short num = (short)1752767255;
			short num2 = num;
			num = (short)1507597079;
			switch (num2 == num)
			{
			default:
			{
				num = (short)446038016;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2018770944;
			if (num != 0)
			{
			}
			num = (short)856489985;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDropHandler.Instance.DetatchAdorner();
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000E7B0 File Offset: 0x0000C9B0
		private static void a(object A_0, global::System.Windows.DragEventArgs A_1)
		{
			short num = (short)1799797485;
			short num2 = num;
			num = (short)993049325;
			switch (num2 == num)
			{
			default:
			{
				num = (short)511901696;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1564213249;
			if (num != 0)
			{
			}
			num = (short)536936448;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c(A_0, A_1);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000D0 RID: 208 RVA: 0x0000E860 File Offset: 0x0000CA60
		// (remove) Token: 0x060000D1 RID: 209 RVA: 0x0000E994 File Offset: 0x0000CB94
		public static event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs> TargetDropped
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs> eventHandler2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						num2 = (short)1219735522;
						short num3 = num2;
						num2 = (short)130133986;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_106;
						case 1:
							break;
						default:
						{
							num2 = (short)1330839552;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)866713600;
						if (num2 != 0)
						{
						}
						goto IL_AB;
					}
					case 2:
						goto IL_106;
					}
					goto IL_1C;
					IL_AB:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs> eventHandler = eventHandler2;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs>)global::System.Delegate.Combine(eventHandler, value);
					eventHandler2 = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs>>(ref global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.e, value2, eventHandler);
					num2 = (short)341835777;
					if (num2 != 0)
					{
					}
					num2 = (short)1427570690;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_106:
					if (eventHandler2 != eventHandler)
					{
						goto IL_AB;
					}
					num2 = (short)548208640;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				eventHandler2 = global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.e;
				num2 = (short)1670905857;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs> eventHandler2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						num2 = (short)1419212587;
						short num3 = num2;
						num2 = (short)2055501611;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_DF;
						case 1:
							break;
						default:
						{
							num2 = (short)1409089536;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)146407424;
						if (num2 != 0)
						{
						}
						goto IL_AC;
					}
					case 2:
						goto IL_DF;
					}
					goto IL_1C;
					IL_AC:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs> eventHandler = eventHandler2;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs>)global::System.Delegate.Remove(eventHandler, value);
					eventHandler2 = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs>>(ref global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.e, value2, eventHandler);
					num2 = (short)332005378;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_DF:
					if (eventHandler2 != eventHandler)
					{
						goto IL_AC;
					}
					num2 = (short)1806696449;
					if (num2 != 0)
					{
					}
					num2 = (short)1654325248;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				eventHandler2 = global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.e;
				num2 = (short)954597377;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000D2 RID: 210 RVA: 0x0000EAC4 File Offset: 0x0000CCC4
		// (remove) Token: 0x060000D3 RID: 211 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
		public static event global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler DragDataRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler dragDataRequestEventHandler2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						num2 = (short)1770389504;
						short num3 = num2;
						num2 = (short)777220572;
						short num4 = num2;
						num2 = (short)1171026396;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_107;
						default:
							num2 = (short)1341259776;
							if (num2 != 0)
							{
							}
							goto IL_D4;
						}
						break;
					}
					case 2:
						goto IL_107;
					}
					goto IL_1C;
					IL_D4:
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler dragDataRequestEventHandler = dragDataRequestEventHandler2;
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler)global::System.Delegate.Combine(dragDataRequestEventHandler, value);
					dragDataRequestEventHandler2 = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler>(ref global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.f, value2, dragDataRequestEventHandler);
					num2 = (short)1132527618;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_107:
					if (dragDataRequestEventHandler2 != dragDataRequestEventHandler)
					{
						goto IL_D4;
					}
					num2 = (short)1262682112;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				num2 = (short)86376449;
				if (num2 != 0)
				{
				}
				dragDataRequestEventHandler2 = global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.f;
				num2 = (short)156762113;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler dragDataRequestEventHandler2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_FD;
					case 1:
					{
						num2 = (short)607398273;
						short num3 = num2;
						num2 = (short)21637505;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E1;
						case 1:
							break;
						default:
						{
							num2 = (short)348192768;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)69140480;
						if (num2 != 0)
						{
						}
						goto IL_AD;
					}
					case 2:
						goto IL_E1;
					}
					goto IL_1C;
					IL_AD:
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler dragDataRequestEventHandler = dragDataRequestEventHandler2;
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler)global::System.Delegate.Remove(dragDataRequestEventHandler, value);
					dragDataRequestEventHandler2 = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler>(ref global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.f, value2, dragDataRequestEventHandler);
					num2 = (short)648413186;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_E1:
					if (dragDataRequestEventHandler2 != dragDataRequestEventHandler)
					{
						goto IL_AD;
					}
					num2 = (short)1024589824;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_FD:
				num2 = (short)694616065;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				dragDataRequestEventHandler2 = global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.f;
				num2 = (short)1900085249;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060000D4 RID: 212 RVA: 0x0000ED2C File Offset: 0x0000CF2C
		// (remove) Token: 0x060000D5 RID: 213 RVA: 0x0000EE60 File Offset: 0x0000D060
		public static event global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler AcceptDropRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler acceptDropRequestEventHandler2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						num2 = (short)815092845;
						short num3 = num2;
						num2 = (short)2137085037;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_107;
						case 1:
							break;
						default:
						{
							num2 = (short)761528320;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)1640235009;
						if (num2 != 0)
						{
						}
						num2 = (short)843710464;
						if (num2 != 0)
						{
						}
						goto IL_D4;
					}
					case 2:
						goto IL_107;
					}
					goto IL_1C;
					IL_D4:
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler acceptDropRequestEventHandler = acceptDropRequestEventHandler2;
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler)global::System.Delegate.Combine(acceptDropRequestEventHandler, value);
					acceptDropRequestEventHandler2 = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler>(ref global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.g, value2, acceptDropRequestEventHandler);
					num2 = (short)838008834;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_107:
					if (acceptDropRequestEventHandler2 != acceptDropRequestEventHandler)
					{
						goto IL_D4;
					}
					num2 = (short)204603392;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				acceptDropRequestEventHandler2 = global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.g;
				num2 = (short)1690173441;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)478740481;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				int num2;
				global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler acceptDropRequestEventHandler2;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)1650917376;
						short num3 = num;
						num = (short)792011915;
						short num4 = num;
						num = (short)1875453067;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_107;
						default:
							num = (short)1950154752;
							if (num != 0)
							{
							}
							goto IL_D4;
						}
						break;
					}
					case 2:
						goto IL_107;
					}
					goto IL_43;
					IL_D4:
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler acceptDropRequestEventHandler = acceptDropRequestEventHandler2;
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler)global::System.Delegate.Remove(acceptDropRequestEventHandler, value);
					acceptDropRequestEventHandler2 = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler>(ref global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.g, value2, acceptDropRequestEventHandler);
					num = (short)116850690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_107:
					if (acceptDropRequestEventHandler2 != acceptDropRequestEventHandler)
					{
						goto IL_D4;
					}
					num = (short)312803328;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_43:
				acceptDropRequestEventHandler2 = global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.g;
				num = (short)362414081;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000EF94 File Offset: 0x0000D194
		// Note: this type is marked as 'beforefieldinit'.
		static DragDropExtention()
		{
			int a_ = 18;
			short num = (short)2021312092;
			short num2 = num;
			num = (short)1330234972;
			switch (num2 == num)
			{
			}
			num = (short)1074659329;
			if (num != 0)
			{
			}
			num = (short)2025717760;
			short num3 = num;
			num = (short)819724288;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.b = global::System.Windows.DataFormats.Serializable;
			global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.c = null;
			global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.IsDragDropSourceProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udfab슯펱펳쪷햹첻꾿럁뛃ꗅ귇", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.OnIsDragDropSourceChanged)));
			global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.d = null;
			global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.IsDropTargetProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udfab슯\uddb1쒳\ud9b7좹\udbbb\udbbd뒿", a_), typeof(bool), typeof(global::System.Windows.DragDrop), new global::System.Windows.UIPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.OnIsDropTargetChanged)));
		}

		// Token: 0x04000012 RID: 18
		private static bool a;

		// Token: 0x04000013 RID: 19
		internal static string b;

		// Token: 0x04000014 RID: 20
		private static global::Motorola.CommonCPS.RadioManagement.Controls.DragInfo c;

		// Token: 0x04000015 RID: 21
		public static readonly global::System.Windows.DependencyProperty IsDragDropSourceProperty;

		// Token: 0x04000016 RID: 22
		private static global::Motorola.CommonCPS.RadioManagement.Controls.DropInfo d;

		// Token: 0x04000017 RID: 23
		public static readonly global::System.Windows.DependencyProperty IsDropTargetProperty;

		// Token: 0x04000018 RID: 24
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs> e;

		// Token: 0x04000019 RID: 25
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler f;

		// Token: 0x0400001A RID: 26
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler g;

		// Token: 0x0200003F RID: 63
		public class TargetDroppedEventArgs : global::System.EventArgs
		{
			// Token: 0x17000008 RID: 8
			// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000F0E0 File Offset: 0x0000D2E0
			// (set) Token: 0x060000D8 RID: 216 RVA: 0x0000F190 File Offset: 0x0000D390
			public global::System.Windows.UIElement TargetItem
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)1339361052;
					short num2 = num;
					num = (short)1675953948;
					switch (num2 == num)
					{
					}
					num = (short)949223425;
					if (num != 0)
					{
					}
					num = (short)972554240;
					short num3 = num;
					num = (short)1937768448;
					if (num != 0)
					{
					}
					return this.a;
				}
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				private set
				{
					short num = (short)1894252545;
					if (num != 0)
					{
					}
					num = (short)563384619;
					short num2 = num;
					num = (short)272077099;
					switch (num2 == num)
					{
					}
					num = (short)1891565568;
					short num3 = num;
					num = (short)1801977856;
					if (num != 0)
					{
					}
					this.a = value;
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000F244 File Offset: 0x0000D444
			// (set) Token: 0x060000DA RID: 218 RVA: 0x0000F2F0 File Offset: 0x0000D4F0
			public object Data
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)2007940284;
					short num2 = num;
					num = (short)533642428;
					switch (num2 == num)
					{
					}
					num = (short)1712455681;
					if (num != 0)
					{
					}
					num = (short)305135616;
					short num3 = num;
					num = (short)834797568;
					if (num != 0)
					{
					}
					return this.b;
				}
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				private set
				{
					short num = (short)205963335;
					short num2 = num;
					num = (short)2007416903;
					switch (num2 == num)
					{
					}
					num = (short)30605313;
					if (num != 0)
					{
					}
					num = (short)77791232;
					short num3 = num;
					num = (short)475856896;
					if (num != 0)
					{
					}
					this.b = value;
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x060000DB RID: 219 RVA: 0x0000F3A0 File Offset: 0x0000D5A0
			// (set) Token: 0x060000DC RID: 220 RVA: 0x0000F450 File Offset: 0x0000D650
			public global::System.Windows.DragDropEffects Effects
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)1051702480;
					short num2 = num;
					num = (short)934655184;
					switch (num2 == num)
					{
					}
					num = (short)372899840;
					if (num != 0)
					{
					}
					num = (short)271384576;
					short num3 = num;
					num = (short)274792449;
					if (num != 0)
					{
					}
					return this.c;
				}
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				private set
				{
					short num = (short)151555242;
					short num2 = num;
					num = (short)1588956330;
					switch (num2 == num)
					{
					}
					num = (short)160825344;
					if (num != 0)
					{
					}
					num = (short)1113522176;
					short num3 = num;
					num = (short)592510977;
					if (num != 0)
					{
					}
					this.c = value;
				}
			}

			// Token: 0x060000DD RID: 221 RVA: 0x0000F500 File Offset: 0x0000D700
			public TargetDroppedEventArgs(global::System.Windows.UIElement targetItem, object Data, global::System.Windows.DragDropEffects effects)
			{
				this.TargetItem = targetItem;
				this.Data = Data;
				this.Effects = effects;
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x060000DE RID: 222 RVA: 0x0000F528 File Offset: 0x0000D728
			public new static global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs Empty
			{
				get
				{
					short num = (short)1674313729;
					if (num != 0)
					{
					}
					num = (short)1499251533;
					short num2 = num;
					num = (short)1240908621;
					switch (num2 == num)
					{
					}
					num = (short)1442775040;
					short num3 = num;
					num = (short)1946419200;
					if (num != 0)
					{
					}
					return new global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs(null, null, global::System.Windows.DragDropEffects.None);
				}
			}

			// Token: 0x0400001B RID: 27
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private global::System.Windows.UIElement a;

			// Token: 0x0400001C RID: 28
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private object b;

			// Token: 0x0400001D RID: 29
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private global::System.Windows.DragDropEffects c;
		}

		// Token: 0x02000040 RID: 64
		public class DragDataRequestEventArgs : global::System.EventArgs
		{
			// Token: 0x1700000C RID: 12
			// (get) Token: 0x060000DF RID: 223 RVA: 0x0000F5DC File Offset: 0x0000D7DC
			// (set) Token: 0x060000E0 RID: 224 RVA: 0x0000F688 File Offset: 0x0000D888
			public global::System.Windows.UIElement SourceItem
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)1124827787;
					short num2 = num;
					num = (short)2038596235;
					switch (num2 == num)
					{
					}
					num = (short)1567817729;
					if (num != 0)
					{
					}
					num = (short)1867251712;
					short num3 = num;
					num = (short)2065104896;
					if (num != 0)
					{
					}
					return this.a;
				}
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				private set
				{
					short num = (short)172556289;
					if (num != 0)
					{
					}
					num = (short)1094211501;
					short num2 = num;
					num = (short)1653168045;
					switch (num2 == num)
					{
					}
					num = (short)462028800;
					short num3 = num;
					num = (short)1558118400;
					if (num != 0)
					{
					}
					this.a = value;
				}
			}

			// Token: 0x060000E1 RID: 225 RVA: 0x0000F738 File Offset: 0x0000D938
			public DragDataRequestEventArgs(global::System.Windows.UIElement sourceItem)
			{
				this.SourceItem = sourceItem;
			}

			// Token: 0x0400001E RID: 30
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private global::System.Windows.UIElement a;
		}

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x060000E3 RID: 227
		public delegate object DragDataRequestEventHandler(object sender, global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventArgs e);

		// Token: 0x02000042 RID: 66
		public class AcceptDropRequestEventArgs : global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs
		{
			// Token: 0x060000E6 RID: 230 RVA: 0x0000F754 File Offset: 0x0000D954
			public AcceptDropRequestEventArgs(global::System.Windows.UIElement targetItem, object Data, global::System.Windows.DragDropEffects effects) : base(targetItem, Data, effects)
			{
			}
		}

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x060000E8 RID: 232
		public delegate bool AcceptDropRequestEventHandler(object sender, global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventArgs e);
	}
}
