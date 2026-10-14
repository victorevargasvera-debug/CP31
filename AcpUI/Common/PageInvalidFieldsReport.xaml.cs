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
using AcpCommonLib.FieldsReport;
using AcpCommonResources;

namespace AcpUI.Common
{
	// Token: 0x02000098 RID: 152
	public partial class PageInvalidFieldsReport : Page
	{
		// Token: 0x0600063C RID: 1596 RVA: 0x000804C8 File Offset: 0x0007E6C8
		public PageInvalidFieldsReport()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000804E4 File Offset: 0x0007E6E4
		public override void OnApplyTemplate()
		{
			int a_ = 16;
			short num = (short)749010944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				Style style;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						num = (short)1321533440;
						short num3 = num;
						style = this.a.ItemContainerStyle;
						num = (short)851247106;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 1:
						num = (short)1742667777;
						if (num != 0)
						{
						}
						if (style == null)
						{
							num = (short)1488257024;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_15F;
					case 2:
						goto IL_15D;
					}
					break;
				}
				IL_43:
				num = (short)1586075223;
				short num4 = num;
				num = (short)1426822743;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_15D:
					break;
				default:
					num = (short)1625030656;
					if (num != 0)
					{
					}
					base.OnApplyTemplate();
					style = (Style)base.TryFindResource(Utility.c("솧\ud9a9\ud8ab\ud9afힱ쎳ﾵ첷\udfb9톻뒿믁ꣃꏅ談ꯉ뿋ꯍ", a_));
					num = (short)1212481537;
					num2 = (int)((IntPtr)num);
					goto IL_30;
				}
				IL_15F:
				Style style2 = new Style(typeof(ListViewItem), style);
				style2.Setters.Add(new EventSetter(Control.MouseDoubleClickEvent, new MouseButtonEventHandler(this.OnDoubleClick)));
				this.a.ItemContainerStyle = style2;
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

		// Token: 0x0600063E RID: 1598 RVA: 0x00080784 File Offset: 0x0007E984
		private void OnDoubleClick(object A_0, MouseButtonEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			ListViewItem listViewItem;
			FieldsReportInfo fieldsReportInfo;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_13C;
				case 1:
				{
					fieldsReportInfo = (listViewItem.DataContext as FieldsReportInfo);
					num2 = (short)1593966592;
					short num3 = num2;
					num2 = (short)713293826;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 2:
					if (fieldsReportInfo != null)
					{
						num2 = (short)2066219008;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 3:
				{
					num2 = (short)57556337;
					short num4 = num2;
					num2 = (short)1444429169;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1806434305;
						if (num2 != 0)
						{
						}
						num2 = (short)213188608;
						if (num2 != 0)
						{
						}
						if (listViewItem != null)
						{
							num2 = (short)1591738369;
							num = (int)((IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				}
				goto IL_20;
			}
			IL_13C:
			Utility.a(A_0, fieldsReportInfo);
			return;
			IL_20:
			listViewItem = (A_0 as ListViewItem);
			num2 = (short)1504378883;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x000808D0 File Offset: 0x0007EAD0
		private void menuItem_Click(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)2120447583;
			short num2 = num;
			num = (short)1276081759;
			switch (num2 == num)
			{
			}
			num = (short)1135017985;
			if (num != 0)
			{
			}
			num = (short)1866727424;
			short num3 = num;
			num = (short)986382336;
			if (num != 0)
			{
			}
			this.copy_Executed(null, null);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00080984 File Offset: 0x0007EB84
		private void copy_Executed(object A_0, ExecutedRoutedEventArgs A_1)
		{
			int a_ = 12;
			short num;
			try
			{
				num = (short)498794496;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					StringBuilder stringBuilder = new StringBuilder();
					IEnumerator enumerator = this.a.SelectedItems.GetEnumerator();
					try
					{
						num = (short)143065092;
						num2 = (int)((IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)367329281;
								num2 = (int)((IntPtr)num);
								continue;
							case 1:
								goto IL_182;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1999437824;
									num2 = (int)((IntPtr)num);
									continue;
								}
								FieldsReportInfo fieldsReportInfo = (FieldsReportInfo)enumerator.Current;
								stringBuilder.Append(fieldsReportInfo.Path + Utility.c("ꮡ", a_));
								stringBuilder.Append(fieldsReportInfo.Name + Utility.c("ꮡ", a_));
								stringBuilder.Append(fieldsReportInfo.FieldValue + Utility.c("ꮡ", a_));
								stringBuilder.Append(fieldsReportInfo.Message + Utility.c("ꮡ", a_));
								stringBuilder.AppendLine();
								num = (short)1997799426;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 4:
								switch (0)
								{
								case 0:
									goto IL_7A;
								}
								continue;
							}
							IL_12D:
							num = (short)1859256323;
							num2 = (int)((IntPtr)num);
							continue;
							IL_7A:
							goto IL_12D;
						}
						IL_182:;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_1A4;
						}
						IDisposable disposable;
						for (;;)
						{
							IL_191:
							switch (num2)
							{
							case 0:
								goto IL_24B;
							case 1:
							{
								num = (short)2035271513;
								short num3 = num;
								num = (short)404342617;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_24D;
								default:
									num = (short)183959552;
									if (num != 0)
									{
									}
									disposable.Dispose();
									num = (short)1526923264;
									num2 = (int)((IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								if (disposable != null)
								{
									num = (short)1307836417;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_24D;
							}
							goto IL_1A4;
						}
						IL_24B:
						IL_24D:
						goto EndFinally_8;
						IL_1A4:
						disposable = (enumerator as IDisposable);
						num = (short)479985666;
						num2 = (int)((IntPtr)num);
						goto IL_191;
						EndFinally_8:;
					}
					Clipboard.Clear();
					Clipboard.SetText(stringBuilder.ToString());
					break;
				}
				}
			}
			catch
			{
			}
			num = (short)36372481;
			if (num != 0)
			{
			}
			num = (short)1730281472;
			short num4 = num;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00080C78 File Offset: 0x0007EE78
		private void selectAllCommand_Executed(object A_0, ExecutedRoutedEventArgs A_1)
		{
			short num = (short)470181427;
			short num2 = num;
			num = (short)159082035;
			switch (num2 == num)
			{
			}
			num = (short)485031937;
			if (num != 0)
			{
			}
			num = (short)82313216;
			short num3 = num;
			num = (short)1579220992;
			if (num != 0)
			{
			}
			this.a.SelectAll();
		}
	}
}
