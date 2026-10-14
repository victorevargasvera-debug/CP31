using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using AcpASKLib;
using AcpCommonLib;
using AcpCommonResources;
using AcpSecurityLib;
using AcpUtility;

namespace AcpUI.Common
{
	// Token: 0x0200009A RID: 154
	public partial class PageReportSystemKeys : Page
	{
		// Token: 0x0600064B RID: 1611 RVA: 0x00081884 File Offset: 0x0007FA84
		public PageReportSystemKeys()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x000818A0 File Offset: 0x0007FAA0
		public override void OnApplyTemplate()
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			Style style;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1536819201;
					if (num2 != 0)
					{
					}
					num2 = (short)1985293418;
					short num3 = num2;
					num2 = (short)1860643946;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_106;
					default:
						num2 = (short)660865024;
						if (num2 != 0)
						{
						}
						if (style != null)
						{
							num2 = (short)1251999746;
							num = (int)((IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 1:
					return;
				case 2:
				{
					Style itemContainerStyle = new Style(typeof(ListViewItem), style);
					this.b.ItemContainerStyle = itemContainerStyle;
					goto IL_106;
				}
				}
				goto IL_25;
				IL_106:
				num2 = (short)1487208448;
				short num4 = num2;
				num2 = (short)2104098817;
				num = (int)((IntPtr)num2);
			}
			return;
			IL_25:
			base.OnApplyTemplate();
			style = (Style)base.TryFindResource(Utility.c("\udb96즞좠욢튤\udda8캪사ﲮ얰쪲\ud9b4튶﮸\udaba캼\udabe", a_));
			num2 = (short)558366720;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x000819F8 File Offset: 0x0007FBF8
		private void myListView_Loaded(object A_0, EventArgs A_1)
		{
			short num = (short)62496250;
			short num2 = num;
			num = (short)1993514490;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1615790080;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)480772097;
			if (num != 0)
			{
			}
			num = (short)344457216;
			if (num != 0)
			{
			}
			((INotifyCollectionChanged)this.b.Items).CollectionChanged += this.myListView_CollectionChanged;
			this.a();
			ContextMenu contextMenu = new ContextMenu();
			MenuItem menuItem = new MenuItem();
			menuItem.Header = AcpResources.Copy_Id;
			contextMenu.Items.Add(menuItem);
			this.b.ContextMenu = contextMenu;
			menuItem.Click += this.menuItem_Click;
			InputBinding inputBinding = new InputBinding(ApplicationCommands.Copy, new KeyGesture(Key.C, ModifierKeys.Control));
			this.b.InputBindings.Add(inputBinding);
			InputBinding inputBinding2 = new InputBinding(ApplicationCommands.SelectAll, new KeyGesture(Key.A, ModifierKeys.Control));
			this.b.InputBindings.Add(inputBinding2);
			CommandBinding commandBinding = new CommandBinding(ApplicationCommands.Copy);
			commandBinding.Executed += this.copy_Executed;
			this.b.CommandBindings.Add(commandBinding);
			CommandBinding commandBinding2 = new CommandBinding(ApplicationCommands.SelectAll);
			commandBinding2.Executed += this.selectAllCommand_Executed;
			this.b.CommandBindings.Add(commandBinding2);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00081BB0 File Offset: 0x0007FDB0
		private void a()
		{
			int a_ = 15;
			short num;
			try
			{
				num = (short)417863467;
				short num2 = num;
				num = (short)1615599403;
				switch (num2 == num)
				{
				}
				num = (short)1076559872;
				if (num != 0)
				{
				}
				ICollectionView defaultView = CollectionViewSource.GetDefaultView(this.b.ItemsSource);
				defaultView.SortDescriptions.Clear();
				SortDescription item = new SortDescription(Utility.c("\udea6\udaa8\udfaa좬슮", a_), ListSortDirection.Ascending);
				defaultView.SortDescriptions.Add(item);
				defaultView.Refresh();
			}
			catch
			{
			}
			num = (short)1145569281;
			if (num != 0)
			{
			}
			num = (short)1518206976;
			short num3 = num;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00081CB8 File Offset: 0x0007FEB8
		private void myListView_CollectionChanged(object A_0, NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)196411393;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)542703618;
					num2 = (int)((IntPtr)num);
					continue;
				case 1:
					goto IL_14;
				case 2:
					if (A_1.Action == NotifyCollectionChangedAction.Remove)
					{
						num = (short)1905590275;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 3:
					goto IL_CE;
				case 4:
					goto IL_EC;
				}
				goto IL_38;
				IL_14:
				switch (0)
				{
				case 0:
				{
					IL_38:
					if (A_1.Action == NotifyCollectionChangedAction.Add)
					{
						goto IL_CE;
					}
					num = (short)2037710848;
					short num3 = num;
					num = (short)1647254876;
					short num4 = num;
					num = (short)316546396;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)691404800;
						if (num != 0)
						{
						}
						num = (short)1295122432;
						num2 = (int)((IntPtr)num);
						break;
					}
					break;
				}
				}
				continue;
				IL_CE:
				this.a();
				num = (short)741343236;
				num2 = (int)((IntPtr)num);
			}
			IL_EC:
			num = (short)1803616257;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00081E14 File Offset: 0x00080014
		private void myListView_UnLoaded(object A_0, EventArgs A_1)
		{
			short num = (short)1963942888;
			short num2 = num;
			num = (short)1429038056;
			switch (num2 == num)
			{
			default:
			{
				num = (short)927203328;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2080047105;
			if (num != 0)
			{
			}
			num = (short)405929984;
			if (num != 0)
			{
			}
			((INotifyCollectionChanged)this.b.Items).CollectionChanged -= this.myListView_CollectionChanged;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00081EDC File Offset: 0x000800DC
		private void menuItem_Click(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)107721349;
			short num2 = num;
			num = (short)1665577605;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1757020160;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)798949377;
			if (num != 0)
			{
			}
			num = (short)943718400;
			if (num != 0)
			{
			}
			this.copy_Executed(null, null);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00081F8C File Offset: 0x0008018C
		private void copy_Executed(object A_0, ExecutedRoutedEventArgs A_1)
		{
			int a_ = 0;
			short num;
			try
			{
				num = (short)1957756928;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					StringBuilder stringBuilder = new StringBuilder();
					IEnumerator enumerator = this.b.SelectedItems.GetEnumerator();
					try
					{
						num = (short)313917440;
						num2 = (int)((IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_7A;
								}
								continue;
							case 1:
							{
								num = (short)1740501303;
								short num3 = num;
								num = (short)1595207991;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)29425664;
									if (num != 0)
									{
									}
									num = (short)1596522500;
									num2 = (int)((IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)674234369;
									num2 = (int)((IntPtr)num);
									continue;
								}
								SystemKeyData systemKeyData = (SystemKeyData)enumerator.Current;
								object obj = new DecToHexConverter().Convert(systemKeyData.SystemID, null, null, AcpResources.Culture);
								stringBuilder.Append(obj.ToString() + Utility.c("龕", a_));
								KeySrcKeyTypeConverter keySrcKeyTypeConverter = new KeySrcKeyTypeConverter();
								object[] values = new object[]
								{
									systemKeyData.Source,
									systemKeyData.Type
								};
								object obj2 = keySrcKeyTypeConverter.Convert(values, null, null, AcpResources.Culture);
								stringBuilder.Append(obj2.ToString() + Utility.c("龕", a_));
								stringBuilder.Append(systemKeyData.iBtnSerialNum + Utility.c("龕", a_));
								object obj3 = new KeyACLTypeConverter().Convert(systemKeyData.AccessLevelType, null, null, AcpResources.Culture);
								stringBuilder.Append(obj3.ToString() + Utility.c("龕", a_));
								KeyWriteProtectEnabledConverter keyWriteProtectEnabledConverter = new KeyWriteProtectEnabledConverter();
								object[] values2 = new object[]
								{
									systemKeyData.Source,
									systemKeyData.WriteProtectEnabled
								};
								object obj4 = keyWriteProtectEnabledConverter.Convert(values2, null, null, AcpResources.Culture);
								stringBuilder.Append(obj4.ToString() + Utility.c("龕", a_));
								stringBuilder.AppendLine();
								num = (short)919797763;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 4:
								goto IL_2A5;
							}
							IL_205:
							num = (short)1403781122;
							num2 = (int)((IntPtr)num);
							continue;
							IL_7A:
							goto IL_205;
						}
						IL_2A5:;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_2C4;
						}
						IDisposable disposable;
						for (;;)
						{
							IL_2B1:
							switch (num2)
							{
							case 0:
								disposable.Dispose();
								num = (short)785514498;
								num2 = (int)((IntPtr)num);
								continue;
							case 1:
								if (disposable != null)
								{
									num = (short)1184825344;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_31A;
							case 2:
								goto IL_318;
							}
							goto IL_2C4;
						}
						IL_318:
						IL_31A:
						goto EndFinally_8;
						IL_2C4:
						disposable = (enumerator as IDisposable);
						num = (short)1844641793;
						num2 = (int)((IntPtr)num);
						goto IL_2B1;
						EndFinally_8:;
					}
					Clipboard.Clear();
					Clipboard.SetText(stringBuilder.ToString());
					AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Info, AcpResources.Num_Recs_Copied_to_Clipboard.AcpStringFormat(new object[]
					{
						this.b.SelectedItems.Count
					}));
					break;
				}
				}
			}
			catch
			{
			}
			num = (short)758710272;
			short num4 = num;
			num = (short)1258094593;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00082384 File Offset: 0x00080584
		private void selectAllCommand_Executed(object A_0, ExecutedRoutedEventArgs A_1)
		{
			short num = (short)968032256;
			short num2 = num;
			num = (short)290313908;
			short num3 = num;
			num = (short)1921570484;
			switch (num3 == num)
			{
			}
			num = (short)694091776;
			if (num != 0)
			{
			}
			num = (short)1850998785;
			if (num != 0)
			{
			}
			this.b.SelectAll();
		}
	}
}
