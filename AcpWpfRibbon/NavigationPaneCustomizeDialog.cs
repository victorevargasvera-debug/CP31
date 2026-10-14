using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Interop;
using System.Windows.Markup;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000063 RID: 99
	public class NavigationPaneCustomizeDialog : global::System.Windows.Window, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600048E RID: 1166 RVA: 0x000642D0 File Offset: 0x000624D0
		public NavigationPaneCustomizeDialog()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000642EC File Offset: 0x000624EC
		protected override void OnSourceInitialized(global::System.EventArgs e)
		{
			short num = (short)504886118;
			short num2 = num;
			num = (short)1524036454;
			switch (num2 == num)
			{
			}
			num = (short)1399193601;
			if (num != 0)
			{
			}
			num = (short)1941962752;
			short num3 = num;
			num = (short)1280442368;
			if (num != 0)
			{
			}
			base.OnSourceInitialized(e);
			global::System.IntPtr handle = new global::System.Windows.Interop.WindowInteropHelper(this).Handle;
			int windowLong = global::DevComponents.WpfRibbon.WinApi.GetWindowLong(handle, -20);
			global::DevComponents.WpfRibbon.WinApi.SetWindowLong(handle, -20, windowLong | 1);
			global::DevComponents.WpfRibbon.WinApi.SetWindowPos(handle, global::System.IntPtr.Zero, 0, 0, 0, 0, 39);
			this._DataChanged = false;
			this._Reordered = false;
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x000643DC File Offset: 0x000625DC
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x00064494 File Offset: 0x00062694
		public global::DevComponents.WpfRibbon.NavigationPane NavigationPane
		{
			get
			{
				short num = (short)1272136855;
				short num2 = num;
				num = (short)1570456727;
				switch (num2 == num)
				{
				}
				num = (short)451280897;
				if (num != 0)
				{
				}
				num = (short)1560936448;
				short num3 = num;
				num = (short)1783824384;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.NavigationPane)base.GetValue(global::DevComponents.WpfRibbon.NavigationPaneCustomizeDialog.NavigationPaneProperty);
			}
			set
			{
				short num = (short)1444471377;
				short num2 = num;
				num = (short)1783620177;
				switch (num2 == num)
				{
				}
				num = (short)176226305;
				if (num != 0)
				{
				}
				num = (short)1077215232;
				short num3 = num;
				num = (short)74776576;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPaneCustomizeDialog.NavigationPaneProperty, value);
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00064548 File Offset: 0x00062748
		public void Initialize(global::DevComponents.WpfRibbon.NavigationPane np)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_BE;
				case 1:
					goto IL_F0;
				case 2:
					if (!np.Items.CanSort)
					{
						num2 = (short)458752;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			IL_BE:
			this.ButtonMoveDown.IsEnabled = false;
			this.ButtonMoveUp.IsEnabled = false;
			goto IL_D8;
			IL_F0:
			num2 = (short)948502529;
			if (num2 != 0)
			{
			}
			num2 = (short)2041118720;
			short num3 = num2;
			return;
			IL_1C:
			this.NavigationPane = np;
			global::DevComponents.WpfRibbon.PaneItemDescriptionList itemsSource = new global::DevComponents.WpfRibbon.PaneItemDescriptionList(np);
			this.PaneItems.ItemsSource = itemsSource;
			num2 = (short)1114938806;
			short num4 = num2;
			num2 = (short)198745526;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_D8:
				num2 = (short)1717960705;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)646971392;
				if (num2 != 0)
				{
				}
				num2 = (short)2016280578;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00064698 File Offset: 0x00062898
		private void OkButtonClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)713687040;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				for (;;)
				{
					IL_27:
					int num3;
					global::DevComponents.WpfRibbon.NavigationPane navigationPane;
					global::DevComponents.WpfRibbon.PaneItemDescriptionList paneItemDescriptionList;
					global::System.Collections.Generic.IEnumerator<global::DevComponents.WpfRibbon.PaneItemDescription> enumerator;
					switch (num2)
					{
					case 0:
					{
						global::DevComponents.WpfRibbon.PaneItemDescription paneItemDescription;
						if (num3 != navigationPane.Items.IndexOf(paneItemDescription.PaneItem))
						{
							num = (short)1101463562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C7;
					}
					case 1:
						goto IL_327;
					case 2:
					{
						if (num3 >= paneItemDescriptionList.Count)
						{
							num = (short)25100294;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfRibbon.PaneItemDescription paneItemDescription = paneItemDescriptionList[num3];
						num = (short)250216448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_C7;
					case 4:
						try
						{
							num = (short)520290309;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::DevComponents.WpfRibbon.PaneItemDescription paneItemDescription2;
									paneItemDescription2.PaneItem.Visibility = (paneItemDescription2.IsVisible ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Collapsed);
									num = (short)776273921;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									num = (short)1210763401;
									short num4 = num;
									num = (short)2016266377;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)627507200;
										if (num != 0)
										{
										}
										num = (short)1706950660;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1811415042;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfRibbon.PaneItemDescription paneItemDescription2 = enumerator.Current;
									num = (short)1213530112;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_264;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_171;
									}
									continue;
								}
								IL_1A6:
								num = (short)516358147;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_171:
								goto IL_1A6;
							}
							IL_264:
							goto IL_427;
						}
						finally
						{
							num = (short)1988689922;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)882507777;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2D4;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_29B;
									}
									continue;
								}
								IL_29B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1381564416;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2D4:;
						}
						goto IL_2D7;
					case 5:
						goto IL_2D7;
					case 6:
						num = (short)485163009;
						if (num != 0)
						{
						}
						goto IL_A4;
					case 7:
						goto IL_327;
					case 8:
					{
						num = (short)2096037888;
						short num5 = num;
						num3 = 0;
						num = (short)951975937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (this._Reordered)
						{
							num = (short)346619912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A4;
					case 10:
					{
						global::DevComponents.WpfRibbon.PaneItemDescription paneItemDescription;
						navigationPane.Items.Remove(paneItemDescription.PaneItem);
						navigationPane.Items.Insert(num3, paneItemDescription.PaneItem);
						num = (short)1219100675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (this._DataChanged)
						{
							num = (short)376504325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_427;
					}
					goto IL_5E;
					IL_A4:
					enumerator = paneItemDescriptionList.GetEnumerator();
					num = (short)1287716868;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C7:
					num3++;
					num = (short)1433927687;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D7:
					paneItemDescriptionList = this.GetPaneItemDescriptionList();
					navigationPane = this.NavigationPane;
					num = (short)73400329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_327:
					num = (short)1974403074;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_427:
				base.Close();
				return;
				IL_5E:
				base.DialogResult = new bool?(true);
				num = (short)2102394891;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00064AF0 File Offset: 0x00062CF0
		private void CheckedChanged(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2034503834;
			short num2 = num;
			num = (short)1750798490;
			switch (num2 == num)
			{
			}
			num = (short)1078591488;
			if (num != 0)
			{
			}
			num = (short)788660224;
			short num3 = num;
			num = (short)1145634817;
			if (num != 0)
			{
			}
			this._DataChanged = true;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00064B9C File Offset: 0x00062D9C
		private void MoveItemUp(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this.PaneItems.SelectedIndex <= 0)
			{
				short num;
				for (;;)
				{
					num = (short)1099497473;
					if (num != 0)
					{
					}
					num = (short)1209815255;
					short num2 = num;
					num = (short)511070423;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_9A;
					}
					break;
				}
				num = (short)1084817408;
				short num3 = num;
				IL_9A:
				num = (short)128581632;
				if (num != 0)
				{
				}
				return;
			}
			global::DevComponents.WpfRibbon.PaneItemDescriptionList paneItemDescriptionList = this.GetPaneItemDescriptionList();
			global::DevComponents.WpfRibbon.PaneItemDescription item = paneItemDescriptionList[this.PaneItems.SelectedIndex];
			int num4 = this.PaneItems.SelectedIndex;
			paneItemDescriptionList.RemoveAt(num4);
			num4--;
			paneItemDescriptionList.Insert(num4, item);
			this.PaneItems.SelectedIndex = num4;
			this._Reordered = true;
			this._DataChanged = true;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00064CAC File Offset: 0x00062EAC
		private void MoveItemDown(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1064370177;
			if (num != 0)
			{
			}
			num = (short)167641091;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.PaneItems.SelectedIndex >= this.PaneItems.Items.Count - 1)
					{
						num = (short)1796341762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_146;
				case 1:
					num = (short)1211039744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)626625730;
					short num3 = num;
					num = (short)901483714;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_68;
					default:
						goto IL_104;
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				}
				goto IL_5A;
				IL_68:
				num = (short)556662785;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5A:
				if (this.PaneItems.SelectedIndex >= 0)
				{
					goto IL_68;
				}
				break;
			}
			return;
			IL_104:
			num = (short)1413808128;
			short num4 = num;
			num = (short)1015939072;
			if (num != 0)
			{
			}
			return;
			IL_146:
			global::DevComponents.WpfRibbon.PaneItemDescriptionList paneItemDescriptionList = this.GetPaneItemDescriptionList();
			global::DevComponents.WpfRibbon.PaneItemDescription item = paneItemDescriptionList[this.PaneItems.SelectedIndex];
			int num5 = this.PaneItems.SelectedIndex;
			paneItemDescriptionList.RemoveAt(num5);
			num5++;
			paneItemDescriptionList.Insert(num5, item);
			this.PaneItems.SelectedIndex = num5;
			this._Reordered = true;
			this._DataChanged = true;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00064E50 File Offset: 0x00063050
		private void ResetItems(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1990506467;
			short num2 = num;
			num = (short)558282723;
			switch (num2 == num)
			{
			}
			num = (short)1408106497;
			if (num != 0)
			{
			}
			num = (short)879427584;
			short num3 = num;
			num = (short)427753472;
			if (num != 0)
			{
			}
			this.Initialize(this.NavigationPane);
			this._Reordered = false;
			this._DataChanged = false;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00064F14 File Offset: 0x00063114
		private global::DevComponents.WpfRibbon.PaneItemDescriptionList GetPaneItemDescriptionList()
		{
			short num = (short)1435188121;
			short num2 = num;
			num = (short)999439257;
			switch (num2 == num)
			{
			}
			num = (short)1928593409;
			if (num != 0)
			{
			}
			num = (short)784924672;
			short num3 = num;
			num = (short)1154678784;
			if (num != 0)
			{
			}
			return this.PaneItems.ItemsSource as global::DevComponents.WpfRibbon.PaneItemDescriptionList;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00064FD0 File Offset: 0x000631D0
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.17.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 1;
			if (this._contentLoaded)
			{
				short num;
				for (;;)
				{
					num = (short)1063327419;
					short num2 = num;
					num = (short)1539053243;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_4D;
					}
				}
				IL_4D:
				num = (short)2105671680;
				short num3 = num;
				num = (short)2022309889;
				if (num != 0)
				{
				}
				num = (short)580780032;
				if (num != 0)
				{
				}
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("癘ᩚ㹜⽞㙠።ͤ㕦h४ཬnὰ䡲ᙴᡶᑸ୺ቼᅾꢆﮌﺖﺞ쾠욢誤즦좨\uddaa쒬좮킰잲\udcb4\ud8b6ힸ쮺\udcbc톾꓀ꃂ냄듆뷈꓊ꃌꛎꯐ뛒뇔뻖룘럚닜룞쿠鯢蓤諦藨", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x000650B4 File Offset: 0x000632B4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.17.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1351614466;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_D5;
				case 1:
					goto IL_153;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				num = (short)1896349697;
				if (num != 0)
				{
				}
				num = (short)2137942718;
				short num3 = num;
				num = (short)280652478;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_D5:
					num = (short)160169985;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)400097280;
					if (num != 0)
					{
					}
					switch (connectionId)
					{
					case 1:
						goto IL_19D;
					case 2:
						goto IL_118;
					case 3:
						goto IL_1B5;
					case 4:
						goto IL_D7;
					case 5:
						goto IL_158;
					default:
						num = (short)1740308480;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
			}
			IL_D7:
			num = (short)1081344000;
			short num4 = num;
			((global::System.Windows.Controls.Button)target).Click += this.ResetItems;
			return;
			IL_118:
			this.ButtonMoveUp = (global::System.Windows.Controls.Button)target;
			this.ButtonMoveUp.Click += this.MoveItemUp;
			return;
			IL_153:
			this._contentLoaded = true;
			return;
			IL_158:
			this.PaneItems = (global::System.Windows.Controls.ListBox)target;
			this.PaneItems.AddHandler(global::System.Windows.Controls.Primitives.ToggleButton.CheckedEvent, new global::System.Windows.RoutedEventHandler(this.CheckedChanged));
			this.PaneItems.AddHandler(global::System.Windows.Controls.Primitives.ToggleButton.UncheckedEvent, new global::System.Windows.RoutedEventHandler(this.CheckedChanged));
			return;
			IL_19D:
			((global::System.Windows.Controls.Button)target).Click += this.OkButtonClick;
			return;
			IL_1B5:
			this.ButtonMoveDown = (global::System.Windows.Controls.Button)target;
			this.ButtonMoveDown.Click += this.MoveItemDown;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000652A4 File Offset: 0x000634A4
		// Note: this type is marked as 'beforefieldinit'.
		static NavigationPaneCustomizeDialog()
		{
			int a_ = 18;
			short num = (short)1747947602;
			short num2 = num;
			num = (short)1007980626;
			switch (num2 == num)
			{
			}
			num = (short)40894464;
			if (num != 0)
			{
			}
			num = (short)1779630080;
			short num3 = num;
			num = (short)437387265;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.NavigationPaneCustomizeDialog.NavigationPaneProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⑩൫ᡭ᥯ᕱᕳɵᅷᕹቻ⹽", a_), typeof(global::DevComponents.WpfRibbon.NavigationPane), typeof(global::DevComponents.WpfRibbon.NavigationPaneCustomizeDialog), new global::System.Windows.UIPropertyMetadata(null));
		}

		// Token: 0x04000264 RID: 612
		private bool _DataChanged;

		// Token: 0x04000265 RID: 613
		private bool _Reordered;

		// Token: 0x04000266 RID: 614
		public static readonly global::System.Windows.DependencyProperty NavigationPaneProperty;

		// Token: 0x04000267 RID: 615
		internal global::System.Windows.Controls.Button ButtonMoveUp;

		// Token: 0x04000268 RID: 616
		internal global::System.Windows.Controls.Button ButtonMoveDown;

		// Token: 0x04000269 RID: 617
		internal global::System.Windows.Controls.ListBox PaneItems;

		// Token: 0x0400026A RID: 618
		private bool _contentLoaded;
	}
}
