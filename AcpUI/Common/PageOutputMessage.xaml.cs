using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using AcpCommonLib.StatusMessage;
using AcpCommonResources;

namespace AcpUI.Common
{
	// Token: 0x02000099 RID: 153
	public partial class PageOutputMessage : Page
	{
		// Token: 0x06000644 RID: 1604 RVA: 0x00080F98 File Offset: 0x0007F198
		public PageOutputMessage()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00080FB4 File Offset: 0x0007F1B4
		public override void OnApplyTemplate()
		{
			int a_ = 11;
			short num = (short)69533696;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				for (;;)
				{
					IL_27:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					Style style;
					for (;;)
					{
						IL_31:
						switch (num2)
						{
						case 0:
						{
							Style itemContainerStyle = new Style(typeof(ListViewItem), style);
							this.a.ItemContainerStyle = itemContainerStyle;
							num = (short)283963762;
							short num3 = num;
							num = (short)1334767986;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_27;
							default:
								num = (short)698810369;
								if (num != 0)
								{
								}
								num = (short)513867776;
								if (num != 0)
								{
								}
								num = (short)1895890945;
								num2 = (int)((IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_16E;
						case 2:
						{
							num = (short)1579679744;
							short num4 = num;
							if (style != null)
							{
								num = (short)1683685376;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_170;
						}
						}
						break;
					}
					IL_44:
					base.OnApplyTemplate();
					style = (Style)base.TryFindResource(Utility.c("쪢횤펦ﾨ슪좬\ud8ae잲킴\udab6쾺쒼펾꓀臂꓄듆곈", a_));
					num = (short)1598881794;
					num2 = (int)((IntPtr)num);
					goto IL_31;
				}
				IL_16E:
				IL_170:
				ContextMenu contextMenu = new ContextMenu();
				MenuItem menuItem = new MenuItem();
				menuItem.Header = AcpResources.Copy_Id;
				contextMenu.Items.Add(menuItem);
				this.a.ContextMenu = contextMenu;
				menuItem.Click += this.menuItem_Click;
				InputBinding inputBinding = new InputBinding(ApplicationCommands.Copy, new KeyGesture(Key.C, ModifierKeys.Control));
				this.a.InputBindings.Add(inputBinding);
				InputBinding inputBinding2 = new InputBinding(ApplicationCommands.SelectAll, new KeyGesture(Key.A, ModifierKeys.Control));
				this.a.InputBindings.Add(inputBinding2);
				CommandBinding commandBinding = new CommandBinding(ApplicationCommands.Copy);
				commandBinding.Executed += this.copy_Executed;
				this.a.CommandBindings.Add(commandBinding);
				CommandBinding commandBinding2 = new CommandBinding(ApplicationCommands.SelectAll);
				commandBinding2.Executed += this.selectAllCommand_Executed;
				this.a.CommandBindings.Add(commandBinding2);
				return;
			}
			}
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00081224 File Offset: 0x0007F424
		private void menuItem_Click(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)2126595902;
			short num2 = num;
			num = (short)1480804158;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2069692416;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)102498305;
			if (num != 0)
			{
			}
			num = (short)377421824;
			if (num != 0)
			{
			}
			this.copy_Executed(null, null);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x000812D8 File Offset: 0x0007F4D8
		private void copy_Executed(object A_0, ExecutedRoutedEventArgs A_1)
		{
			int a_ = 0;
			short num;
			try
			{
				num = (short)1896192869;
				short num2 = num;
				num = (short)352754533;
				StringBuilder stringBuilder;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)445513728;
					if (num != 0)
					{
					}
					num = (short)188809216;
					int num3 = (int)num;
					switch (num3)
					{
					default:
					{
						stringBuilder = new StringBuilder();
						IEnumerator enumerator = this.a.SelectedItems.GetEnumerator();
						try
						{
							num = (short)574029825;
							num3 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_C4;
									}
									continue;
								case 2:
									num = (short)1478295555;
									num3 = (int)((IntPtr)num);
									continue;
								case 3:
									goto IL_18C;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)86966274;
										num3 = (int)((IntPtr)num);
										continue;
									}
									StatusMessageInfo statusMessageInfo = (StatusMessageInfo)enumerator.Current;
									stringBuilder.Append(statusMessageInfo.Type + Utility.c("龕", a_));
									stringBuilder.Append(statusMessageInfo.Message + Utility.c("龕", a_));
									stringBuilder.AppendLine();
									num = (short)34865152;
									num3 = (int)((IntPtr)num);
									continue;
								}
								}
								IL_134:
								num = (short)1958739972;
								num3 = (int)((IntPtr)num);
								continue;
								IL_C4:
								goto IL_134;
							}
							IL_18C:;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1AB;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_198:
								switch (num3)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1553858562;
										num3 = (int)((IntPtr)num);
										continue;
									}
									goto IL_1FF;
								case 1:
									goto IL_1FD;
								case 2:
									disposable.Dispose();
									num = (short)1234567169;
									num3 = (int)((IntPtr)num);
									continue;
								}
								goto IL_1AB;
							}
							IL_1FD:
							IL_1FF:
							break;
							IL_1AB:
							disposable = (enumerator as IDisposable);
							num = (short)1976172544;
							num3 = (int)((IntPtr)num);
							goto IL_198;
						}
						break;
					}
					}
					break;
				}
				}
				Clipboard.Clear();
				Clipboard.SetText(stringBuilder.ToString());
			}
			catch
			{
			}
			num = (short)487653377;
			if (num != 0)
			{
			}
			num = (short)310509568;
			short num4 = num;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00081580 File Offset: 0x0007F780
		private void selectAllCommand_Executed(object A_0, ExecutedRoutedEventArgs A_1)
		{
			short num = (short)957893838;
			short num2 = num;
			num = (short)1381977294;
			switch (num2 == num)
			{
			default:
			{
				num = (short)950009856;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1192689665;
			if (num != 0)
			{
			}
			num = (short)1701904384;
			if (num != 0)
			{
			}
			this.a.SelectAll();
		}
	}
}
