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
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.FindResult;
using AcpCommonResources;
using AcpUtility;

namespace AcpUI.Common
{
	// Token: 0x02000097 RID: 151
	public partial class PageFindResults : Page
	{
		// Token: 0x06000634 RID: 1588 RVA: 0x0007F87C File Offset: 0x0007DA7C
		public PageFindResults()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0007F898 File Offset: 0x0007DA98
		public override void OnApplyTemplate()
		{
			int a_ = 4;
			short num = (short)257490944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6A;
				}
				Style style;
				for (;;)
				{
					IL_30:
					num = (short)1075838977;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						style = this.b.ItemContainerStyle;
						num = (short)883032066;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						if (style == null)
						{
							num = (short)2012610560;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_15D;
					case 2:
						goto IL_15B;
					}
					break;
				}
				IL_6A:
				num = (short)576389120;
				short num3 = num;
				num = (short)2011310869;
				short num4 = num;
				num = (short)1340615445;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_15B:
					break;
				default:
					num = (short)275906560;
					if (num != 0)
					{
					}
					base.OnApplyTemplate();
					style = (Style)base.TryFindResource(Utility.c("횙풟춣쎥\udfa7\ud8ab쮭\uddaf삳쾵풷\udfb9ﺻ\udfbd뎿ꟁ", a_));
					num = (short)1478426625;
					num2 = (int)((IntPtr)num);
					goto IL_30;
				}
				IL_15D:
				Style style2 = new Style(typeof(ListViewItem), style);
				style2.Setters.Add(new EventSetter(Control.MouseDoubleClickEvent, new MouseButtonEventHandler(this.OnMouseDoubleClick)));
				this.b.ItemContainerStyle = style2;
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
				return;
			}
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0007FB34 File Offset: 0x0007DD34
		private void OnMouseDoubleClick(object A_0, MouseButtonEventArgs A_1)
		{
			short num = (short)749207552;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5F;
				}
				FieldInfo fieldInfo;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_D7;
					case 1:
					{
						Recordset recordset;
						FeatureNode featureNode;
						if (recordset.Contains(featureNode))
						{
							num = (short)534315012;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_9B;
					}
					case 2:
					{
						Recordset recordset;
						FeatureNode featureNode;
						if (recordset.Contains(featureNode))
						{
							num = (short)126025728;
							num2 = (int)((IntPtr)num);
							continue;
						}
						AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, AcpResources.Field_Not_Found.AcpStringFormat(new object[]
						{
							fieldInfo.Name
						}));
						num = (short)686751747;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 3:
						goto IL_1B4;
					case 4:
					{
						num = (short)703725568;
						short num3 = num;
						Recordset recordset;
						FeatureNode featureNode = recordset.ParentSection.Parent as FeatureNode;
						recordset = (featureNode.Parent as Recordset);
						num = (short)1170866185;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 5:
					{
						Recordset recordset;
						if (recordset.IsEmbeddedRecset)
						{
							num = (short)1913782280;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_9B;
					}
					case 6:
						num = (short)12451841;
						if (num != 0)
						{
						}
						if (fieldInfo != null)
						{
							num = (short)658440203;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 7:
					{
						ListViewItem listViewItem;
						fieldInfo = (listViewItem.DataContext as FieldInfo);
						num = (short)5963782;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 8:
						num = (short)2063335425;
						num2 = (int)((IntPtr)num);
						continue;
					case 9:
						goto IL_9B;
					case 10:
					{
						ListViewItem listViewItem;
						if (listViewItem != null)
						{
							num = (short)911671303;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					}
					case 11:
					{
						FeatureNode featureNode = fieldInfo.Field.Parent.Parent as FeatureNode;
						Recordset recordset = featureNode.Parent as Recordset;
						num = (short)699072517;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					goto IL_5F;
					IL_9B:
					num = (short)669974530;
					num2 = (int)((IntPtr)num);
				}
				IL_D7:
				Utility.a(A_0, fieldInfo);
				return;
				IL_1B4:
				num = (short)1631462615;
				short num4 = num;
				num = (short)83109079;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_5F:
					ListViewItem listViewItem = A_0 as ListViewItem;
					num = (short)297140234;
					num2 = (int)((IntPtr)num);
					goto IL_28;
				}
				default:
					num = (short)1976238080;
					if (num != 0)
					{
					}
					break;
				}
				return;
			}
			}
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0007FE28 File Offset: 0x0007E028
		private void menuItem_Click(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)442770115;
			short num2 = num;
			num = (short)208806595;
			switch (num2 == num)
			{
			}
			num = (short)140574721;
			if (num != 0)
			{
			}
			num = (short)1087111168;
			if (num != 0)
			{
			}
			num = (short)1817575424;
			short num3 = num;
			this.copy_Executed(null, null);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0007FED8 File Offset: 0x0007E0D8
		private void copy_Executed(object A_0, ExecutedRoutedEventArgs A_1)
		{
			int a_ = 9;
			short num;
			try
			{
				num = (short)471859200;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					StringBuilder stringBuilder = new StringBuilder();
					IEnumerator enumerator = this.b.SelectedItems.GetEnumerator();
					try
					{
						num = (short)1813774339;
						num2 = (int)((IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1DD;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)977600516;
									num2 = (int)((IntPtr)num);
									continue;
								}
								FindResultInfo findResultInfo = (FindResultInfo)enumerator.Current;
								stringBuilder.Append(findResultInfo.Index.ToString() + Utility.c("隞", a_));
								stringBuilder.Append(findResultInfo.Name + Utility.c("隞", a_));
								stringBuilder.Append(findResultInfo.Path + Utility.c("隞", a_));
								stringBuilder.AppendLine();
								num = (short)325844994;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_7C;
								}
								continue;
							case 4:
							{
								num = (short)300556910;
								short num3 = num;
								num = (short)1740776046;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									num = (short)713359361;
									if (num != 0)
									{
									}
									num = (short)66650112;
									if (num != 0)
									{
									}
									num = (short)1901133824;
									num2 = (int)((IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_116:
							num = (short)28508161;
							num2 = (int)((IntPtr)num);
							continue;
							IL_7C:
							goto IL_116;
						}
						IL_1DD:;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_1FC;
						}
						IDisposable disposable;
						for (;;)
						{
							IL_1E9:
							switch (num2)
							{
							case 0:
								disposable.Dispose();
								num = (short)1377959938;
								num2 = (int)((IntPtr)num);
								continue;
							case 1:
								if (disposable != null)
								{
									num = (short)53477376;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_253;
							case 2:
								goto IL_251;
							}
							goto IL_1FC;
						}
						IL_251:
						IL_253:
						goto EndFinally_8;
						IL_1FC:
						disposable = (enumerator as IDisposable);
						num = (short)880082945;
						num2 = (int)((IntPtr)num);
						goto IL_1E9;
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
			num = (short)1186529280;
			short num4 = num;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x000801AC File Offset: 0x0007E3AC
		private void selectAllCommand_Executed(object A_0, ExecutedRoutedEventArgs A_1)
		{
			short num = (short)1597829392;
			short num2 = num;
			num = (short)9957648;
			switch (num2 == num)
			{
			}
			num = (short)1744306177;
			if (num != 0)
			{
			}
			num = (short)488243200;
			if (num != 0)
			{
			}
			num = (short)1535115264;
			short num3 = num;
			this.b.SelectAll();
		}
	}
}
