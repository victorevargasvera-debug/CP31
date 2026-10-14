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
	// Token: 0x02000096 RID: 150
	public partial class PageFieldsReport : Page
	{
		// Token: 0x0600062C RID: 1580 RVA: 0x0007EDB4 File Offset: 0x0007CFB4
		public PageFieldsReport()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0007EDD0 File Offset: 0x0007CFD0
		public override void OnApplyTemplate()
		{
			int a_ = 10;
			short num = (short)1297285120;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
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
						style = this.a.ItemContainerStyle;
						num = (short)477822978;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						if (style == null)
						{
							num = (short)150339584;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_133;
					case 2:
						goto IL_131;
					}
					break;
				}
				IL_44:
				num = (short)767046686;
				short num3 = num;
				num = (short)743978014;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_131:
					goto IL_133;
				case 1:
					break;
				default:
				{
					num = (short)1580924928;
					short num4 = num;
					break;
				}
				}
				num = (short)1099235328;
				if (num != 0)
				{
				}
				base.OnApplyTemplate();
				style = (Style)base.TryFindResource(Utility.c("쮡힣튥ﺧ쎩즫\ud9ad羚욱톳\udbb5캹얻튽ꖿ胁ꗃ뗅귇", a_));
				num = (short)518586369;
				num2 = (int)((IntPtr)num);
				goto IL_31;
				IL_133:
				num = (short)1938685953;
				if (num != 0)
				{
				}
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

		// Token: 0x0600062E RID: 1582 RVA: 0x0007F06C File Offset: 0x0007D26C
		private void OnDoubleClick(object A_0, MouseButtonEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			FieldsReportInfo fieldsReportInfo;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					ListViewItem listViewItem;
					fieldsReportInfo = (listViewItem.DataContext as FieldsReportInfo);
					num2 = (short)834404353;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 1:
					if (fieldsReportInfo != null)
					{
						num2 = (short)2015166464;
						short num3 = num2;
						num2 = (short)1282211843;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					ListViewItem listViewItem;
					if (listViewItem != null)
					{
						num2 = (short)818020352;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				}
				case 3:
					goto IL_144;
				}
				goto IL_20;
			}
			IL_144:
			Utility.a(A_0, fieldsReportInfo);
			return;
			IL_20:
			num2 = (short)178520065;
			if (num2 != 0)
			{
			}
			num2 = (short)1576241467;
			short num4 = num2;
			num2 = (short)414353723;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num2 = (short)872611840;
				if (num2 != 0)
				{
				}
				ListViewItem listViewItem = A_0 as ListViewItem;
				break;
			}
			}
			num2 = (short)2065498114;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0007F1C0 File Offset: 0x0007D3C0
		private void menuItem_Click(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1886846977;
			if (num != 0)
			{
			}
			num = (short)1724749460;
			short num2 = num;
			num = (short)1631688340;
			switch (num2 == num)
			{
			}
			num = (short)406585344;
			if (num != 0)
			{
			}
			num = (short)580845568;
			short num3 = num;
			this.copy_Executed(null, null);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0007F274 File Offset: 0x0007D474
		private void copy_Executed(object A_0, ExecutedRoutedEventArgs A_1)
		{
			int a_ = 0;
			short num;
			try
			{
				num = (short)1735589888;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)221118465;
					if (num != 0)
					{
					}
					StringBuilder stringBuilder = new StringBuilder();
					IEnumerator enumerator = this.a.SelectedItems.GetEnumerator();
					try
					{
						num = (short)151257091;
						num2 = (int)((IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1F8;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)339410948;
									num2 = (int)((IntPtr)num);
									continue;
								}
								FieldsReportInfo fieldsReportInfo = (FieldsReportInfo)enumerator.Current;
								stringBuilder.Append(fieldsReportInfo.Path + Utility.c("龕", a_));
								stringBuilder.Append(fieldsReportInfo.Name + Utility.c("龕", a_));
								stringBuilder.Append(fieldsReportInfo.FieldValue + Utility.c("龕", a_));
								stringBuilder.Append(fieldsReportInfo.Message + Utility.c("龕", a_));
								stringBuilder.AppendLine();
								num = (short)1933770754;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_A3;
								}
								continue;
							case 4:
							{
								num = (short)72176010;
								short num3 = num;
								num = (short)1219187082;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									num = (short)445186048;
									if (num != 0)
									{
									}
									num = (short)11141120;
									num2 = (int)((IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_156:
							num = (short)808058881;
							num2 = (int)((IntPtr)num);
							continue;
							IL_A3:
							goto IL_156;
						}
						IL_1F8:;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_217;
						}
						IDisposable disposable;
						for (;;)
						{
							IL_204:
							switch (num2)
							{
							case 0:
								disposable.Dispose();
								num = (short)1019674626;
								num2 = (int)((IntPtr)num);
								continue;
							case 1:
								if (disposable != null)
								{
									num = (short)1384316928;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_26C;
							case 2:
								goto IL_26A;
							}
							goto IL_217;
						}
						IL_26A:
						IL_26C:
						goto EndFinally_8;
						IL_217:
						disposable = (enumerator as IDisposable);
						num = (short)875757569;
						num2 = (int)((IntPtr)num);
						goto IL_204;
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
			num = (short)434044928;
			short num4 = num;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0007F560 File Offset: 0x0007D760
		private void selectAllCommand_Executed(object A_0, ExecutedRoutedEventArgs A_1)
		{
			short num = (short)161761262;
			short num2 = num;
			num = (short)1456424942;
			switch (num2 == num)
			{
			}
			num = (short)842399744;
			if (num != 0)
			{
			}
			num = (short)1449328641;
			if (num != 0)
			{
			}
			num = (short)1352204288;
			short num3 = num;
			this.a.SelectAll();
		}
	}
}
