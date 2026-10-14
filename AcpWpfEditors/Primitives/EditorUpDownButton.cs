using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000069 RID: 105
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class EditorUpDownButton : global::DevComponents.WpfEditors.UpDownButton
	{
		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x000944D8 File Offset: 0x000926D8
		// (set) Token: 0x06000718 RID: 1816 RVA: 0x00094590 File Offset: 0x00092790
		public global::DevComponents.WpfEditors.Primitives.eUpDownButtonAutoChange AutoChange
		{
			get
			{
				short num = (short)197459969;
				if (num != 0)
				{
				}
				num = (short)1675298870;
				short num2 = num;
				num = (short)1391396918;
				switch (num2 == num)
				{
				}
				num = (short)311230464;
				if (num != 0)
				{
				}
				num = (short)1301020672;
				short num3 = num;
				return (global::DevComponents.WpfEditors.Primitives.eUpDownButtonAutoChange)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorUpDownButton.AutoChangeProperty);
			}
			set
			{
				short num = (short)257425409;
				if (num != 0)
				{
				}
				num = (short)1399908252;
				short num2 = num;
				num = (short)371517340;
				switch (num2 == num)
				{
				}
				num = (short)833748992;
				if (num != 0)
				{
				}
				num = (short)515702784;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorUpDownButton.AutoChangeProperty, value);
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x00094648 File Offset: 0x00092848
		// (set) Token: 0x0600071A RID: 1818 RVA: 0x00094700 File Offset: 0x00092900
		public global::DevComponents.WpfEditors.Primitives.EditorInputBase AutoChangeItem
		{
			get
			{
				short num = (short)386925269;
				short num2 = num;
				num = (short)945029845;
				switch (num2 == num)
				{
				}
				num = (short)1797455873;
				if (num != 0)
				{
				}
				num = (short)2055995392;
				if (num != 0)
				{
				}
				num = (short)1689845760;
				short num3 = num;
				return (global::DevComponents.WpfEditors.Primitives.EditorInputBase)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorUpDownButton.AutoChangeItemProperty);
			}
			set
			{
				short num = (short)195881316;
				short num2 = num;
				num = (short)307620196;
				switch (num2 == num)
				{
				}
				num = (short)80347137;
				if (num != 0)
				{
				}
				num = (short)1912733696;
				if (num != 0)
				{
				}
				num = (short)299827200;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorUpDownButton.AutoChangeItemProperty, value);
			}
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x000947B8 File Offset: 0x000929B8
		static EditorUpDownButton()
		{
			int a_ = 10;
			short num = (short)1608718522;
			short num2 = num;
			num = (short)875698362;
			switch (num2 == num)
			{
			}
			num = (short)136314881;
			if (num != 0)
			{
			}
			num = (short)1643708416;
			if (num != 0)
			{
			}
			num = (short)877920256;
			short num3 = num;
			global::DevComponents.WpfEditors.Primitives.EditorUpDownButton.AutoChangeProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("雖곘꿚닜鳞觠苢诤胦賨", a_), typeof(global::DevComponents.WpfEditors.Primitives.eUpDownButtonAutoChange), typeof(global::DevComponents.WpfEditors.Primitives.EditorUpDownButton), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfEditors.Primitives.eUpDownButtonAutoChange.None));
			global::DevComponents.WpfEditors.Primitives.EditorUpDownButton.AutoChangeItemProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("雖곘꿚닜鳞觠苢诤胦賨ꋪ駬諮鳰", a_), typeof(global::DevComponents.WpfEditors.Primitives.EditorInputBase), typeof(global::DevComponents.WpfEditors.Primitives.EditorUpDownButton), new global::System.Windows.UIPropertyMetadata(null));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.Primitives.EditorUpDownButton), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfEditors.UpDownButton.ButtonsFocusableProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.Primitives.EditorUpDownButton), new global::System.Windows.FrameworkPropertyMetadata(false));
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00094914 File Offset: 0x00092B14
		protected override void OnUpButtonClick(global::System.Windows.RoutedEventArgs eventArgs)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					goto IL_94;
				case 2:
				{
					num2 = (short)1077346305;
					if (num2 != 0)
					{
					}
					num2 = (short)1463156736;
					short num3 = num2;
					num2 = (short)643956740;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					num2 = (short)2055208966;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (this.AutoChange == global::DevComponents.WpfEditors.Primitives.eUpDownButtonAutoChange.None)
					{
						num2 = (short)1744699395;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_94;
				case 5:
					if (!eventArgs.Handled)
					{
						num2 = (short)1943666690;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 6:
					while (this.AutoChangeItem != null)
					{
						num2 = (short)817097716;
						short num4 = num2;
						num2 = (short)797633524;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)539426816;
							if (num2 != 0)
							{
							}
							num2 = (short)198443009;
							num = (int)((global::System.IntPtr)num2);
							goto IL_0A;
						}
					}
					return;
				}
				goto IL_2C;
				IL_94:
				this.c();
				num2 = (short)616562688;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2C:
			base.OnUpButtonClick(eventArgs);
			num2 = (short)1558839301;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00094ACC File Offset: 0x00092CCC
		private void c()
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			global::DevComponents.WpfEditors.Primitives.EditorElement editorElement;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (editorElement is global::DevComponents.WpfEditors.Primitives.EditorListInput)
					{
						goto IL_1C0;
					}
					goto IL_117;
				case 1:
					num2 = (short)226230284;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_117;
				case 3:
				{
					num2 = (short)1071841280;
					short num3 = num2;
					((global::DevComponents.WpfEditors.Primitives.EditorListInput)editorElement).SelectPrevious();
					num2 = (short)154861581;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					return;
				case 5:
				{
					global::DevComponents.WpfEditors.Primitives.EditorInputGroup editorInputGroup = (global::DevComponents.WpfEditors.Primitives.EditorInputGroup)base.Parent;
					editorInputGroup.IsUserInput = true;
					num2 = (short)732495880;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
				{
					if (editorElement == null)
					{
						num2 = (short)1944190990;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::DevComponents.WpfEditors.Primitives.EditorInputGroup editorInputGroup = null;
					num2 = (short)2054422535;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					if (editorElement.Parent is global::DevComponents.WpfEditors.Primitives.EditorInputGroup)
					{
						num2 = (short)5177345;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2C1;
				case 8:
					num2 = (short)1304756225;
					if (num2 != 0)
					{
					}
					goto IL_2C1;
				case 9:
				{
					global::DevComponents.WpfEditors.Primitives.EditorInputGroup editorInputGroup;
					if (editorInputGroup != null)
					{
						num2 = (short)824246287;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 10:
				{
					if (editorElement is global::DevComponents.WpfEditors.Primitives.EditorNumericInput)
					{
						num2 = (short)957874187;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1692099058;
					short num4 = num2;
					num2 = (short)1202807282;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C0;
					default:
						num2 = (short)2091974656;
						if (num2 != 0)
						{
						}
						num2 = (short)946601984;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 11:
					((global::DevComponents.WpfEditors.Primitives.EditorNumericInput)editorElement).IncreaseValue();
					num2 = (short)353959938;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (!((global::DevComponents.WpfEditors.Primitives.EditorInputGroup)base.Parent).IsUserInput)
					{
						num2 = (short)639238149;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2C1;
				case 13:
					goto IL_117;
				case 14:
					return;
				case 15:
				{
					global::DevComponents.WpfEditors.Primitives.EditorInputGroup editorInputGroup;
					editorInputGroup.IsUserInput = false;
					num2 = (short)1996423172;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_50;
				IL_117:
				num2 = (short)849412105;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1C0:
				num2 = (short)387121155;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2C1:
				num2 = (short)127467530;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_50:
			editorElement = this.b();
			num2 = (short)1768226822;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00094DDC File Offset: 0x00092FDC
		private global::DevComponents.WpfEditors.Primitives.EditorElement b()
		{
			short num = (short)1878982656;
			switch (num)
			{
			default:
			{
				global::DevComponents.WpfEditors.Primitives.EditorGroup editorGroup;
				global::System.Windows.UIElement uielement;
				global::System.Windows.UIElement uielement2;
				global::DevComponents.WpfEditors.Primitives.EditorInputGroup editorInputGroup;
				for (;;)
				{
					IL_1D:
					num = (short)1367408650;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						int num3;
						int num6;
						switch (num2)
						{
						case 0:
							if (num3 < 0)
							{
								num = (short)1678311455;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							uielement = editorGroup.Items[num3];
							num = (short)1533214753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (uielement2.Visibility == global::System.Windows.Visibility.Visible)
							{
								num = (short)1009385489;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_620;
						case 2:
							goto IL_309;
						case 3:
							num = (short)1715666962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (!editorGroup.IsKeyboardFocusWithin)
							{
								num = (short)1030029341;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_104;
						case 5:
							goto IL_309;
						case 6:
							goto IL_3D2;
						case 7:
							goto IL_3CD;
						case 8:
							if (uielement2 is global::DevComponents.WpfEditors.Primitives.EditorInputBase)
							{
								num = (short)1961164811;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_620;
						case 9:
							goto IL_3D2;
						case 10:
							switch (0)
							{
							case 0:
								goto IL_D4;
							}
							continue;
						case 11:
							num = (short)707919873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_22D;
						case 13:
						{
							num = (short)1306897811;
							short num4 = num;
							num = (short)132558227;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1D;
							default:
							{
								num = (short)191954944;
								short num5 = num;
								num = (short)689569792;
								if (num != 0)
								{
								}
								if (!(editorInputGroup.FocusedItem is global::DevComponents.WpfEditors.Primitives.EditorInputGroup))
								{
									num = (short)1929117721;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								editorInputGroup = (editorInputGroup.FocusedItem as global::DevComponents.WpfEditors.Primitives.EditorInputGroup);
								num = (short)1348993036;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 14:
							goto IL_22D;
						case 15:
							if (base.Parent != null)
							{
								num = (short)904855555;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_466;
						case 16:
							goto IL_104;
						case 17:
							goto IL_568;
						case 18:
							if (!(base.Parent is global::DevComponents.WpfEditors.Primitives.EditorGroup))
							{
								num = (short)499908636;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							editorGroup = (base.Parent as global::DevComponents.WpfEditors.Primitives.EditorGroup);
							num = (short)1364918302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							if (num6 >= editorGroup.Items.Count)
							{
								num = (short)942014480;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							uielement2 = editorGroup.Items[num6];
							num = (short)906821640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							num = (short)1987969028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
							num = (short)2024013839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							num = (short)970522659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 23:
							editorInputGroup = (editorGroup.FocusedItem as global::DevComponents.WpfEditors.Primitives.EditorInputGroup);
							num = (short)1517813774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							num = (short)247529499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 25:
							goto IL_2E0;
						case 26:
							goto IL_F8;
						case 27:
							if (uielement.Visibility == global::System.Windows.Visibility.Visible)
							{
								num = (short)416808967;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2E5;
						case 28:
							goto IL_4A9;
						case 29:
							num6 = 0;
							num = (short)169672706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							if (this.AutoChange == global::DevComponents.WpfEditors.Primitives.eUpDownButtonAutoChange.FocusedItem)
							{
								num = (short)2024538134;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num3 = editorGroup.Items.IndexOf(this);
							num = (short)731185161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 31:
							goto IL_40C;
						case 32:
							if (this.AutoChange != global::DevComponents.WpfEditors.Primitives.eUpDownButtonAutoChange.None)
							{
								num = (short)515571733;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_466;
						case 33:
							if (uielement is global::DevComponents.WpfEditors.Primitives.EditorInputBase)
							{
								num = (short)1049952280;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2E5;
						case 34:
							if (editorGroup.FocusedItem is global::DevComponents.WpfEditors.Primitives.EditorInputGroup)
							{
								num = (short)84606999;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4F5;
						case 35:
							if (editorGroup.FocusedItem == null)
							{
								num = (short)1128398868;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_104;
						}
						IL_D4:
						if (this.AutoChangeItem != null)
						{
							num = (short)816316442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)695533600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_104:
						num = (short)1109393442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_22D:
						num = (short)112590861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2E5:
						num3--;
						num = (short)704643078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_309:
						num = (short)1321992211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3D2:
						num = (short)647888896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_620:
						num6++;
						num = (short)1794375685;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_F8:
				return this.AutoChangeItem;
				IL_2E0:
				return editorInputGroup.FocusedItem;
				IL_3CD:
				return uielement as global::DevComponents.WpfEditors.Primitives.EditorInputBase;
				IL_40C:
				return null;
				IL_466:
				return null;
				IL_4A9:
				goto IL_466;
				IL_4F5:
				return editorGroup.FocusedItem;
				IL_568:
				num = (short)834863105;
				if (num != 0)
				{
				}
				return uielement2 as global::DevComponents.WpfEditors.Primitives.EditorInputBase;
			}
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00095458 File Offset: 0x00093658
		protected override void OnDownButtonClick(global::System.Windows.RoutedEventArgs eventArgs)
		{
			short num = (short)2136735745;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_53;
			}
			int num2;
			for (;;)
			{
				IL_31:
				switch (num2)
				{
				case 0:
					if (this.AutoChangeItem != null)
					{
						num = (short)119406597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
				{
					num = (short)860097205;
					short num3 = num;
					num = (short)1646660277;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DE;
					default:
						num = (short)1773338624;
						if (num != 0)
						{
						}
						if (!eventArgs.Handled)
						{
							num = (short)282132484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 2:
					return;
				case 3:
					num = (short)21233664;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)292552710;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_DE;
				case 6:
					if (this.AutoChange == global::DevComponents.WpfEditors.Primitives.eUpDownButtonAutoChange.None)
					{
						num = (short)2039021571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DE;
				}
				goto IL_53;
				IL_DE:
				this.a();
				num = (short)1839923200;
				short num4 = num;
				num = (short)1480458242;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_53:
			base.OnDownButtonClick(eventArgs);
			num = (short)563478529;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00095604 File Offset: 0x00093804
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			global::DevComponents.WpfEditors.Primitives.EditorElement editorElement;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_145;
				case 1:
					goto IL_145;
				case 2:
					((global::DevComponents.WpfEditors.Primitives.EditorNumericInput)editorElement).DecreaseValue();
					num2 = (short)240451585;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					if (editorElement == null)
					{
						num2 = (short)88604682;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::DevComponents.WpfEditors.Primitives.EditorInputGroup editorInputGroup = null;
					num2 = (short)428081159;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					global::DevComponents.WpfEditors.Primitives.EditorInputGroup editorInputGroup;
					editorInputGroup.IsUserInput = false;
					num2 = (short)2002518027;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
				{
					if (editorElement is global::DevComponents.WpfEditors.Primitives.EditorNumericInput)
					{
						num2 = (short)1456865282;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1489022534;
					short num3 = num2;
					num2 = (short)158903878;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)1691549696;
						if (num2 != 0)
						{
						}
						num2 = (short)1911226368;
						short num4 = num2;
						num2 = (short)129892361;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 6:
				{
					global::DevComponents.WpfEditors.Primitives.EditorInputGroup editorInputGroup;
					if (editorInputGroup != null)
					{
						num2 = (short)2073296900;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 7:
					if (editorElement.Parent is global::DevComponents.WpfEditors.Primitives.EditorInputGroup)
					{
						num2 = (short)26411021;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2C6;
				case 8:
					((global::DevComponents.WpfEditors.Primitives.EditorListInput)editorElement).SelectNext();
					num2 = (short)1792999424;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (editorElement is global::DevComponents.WpfEditors.Primitives.EditorListInput)
					{
						num2 = (short)339476488;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_145;
				case 10:
					return;
				case 11:
					return;
				case 12:
				{
					global::DevComponents.WpfEditors.Primitives.EditorInputGroup editorInputGroup = (global::DevComponents.WpfEditors.Primitives.EditorInputGroup)base.Parent;
					editorInputGroup.IsUserInput = true;
					num2 = (short)759169038;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 13:
					num2 = (short)1852637185;
					if (num2 != 0)
					{
					}
					num2 = (short)1927872527;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					goto IL_2C6;
				case 15:
					if (!((global::DevComponents.WpfEditors.Primitives.EditorInputGroup)base.Parent).IsUserInput)
					{
						num2 = (short)1401487372;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2C6;
				}
				goto IL_50;
				IL_145:
				num2 = (short)1444675590;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2C6:
				num2 = (short)1847459845;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_50:
			editorElement = this.b();
			num2 = (short)1372782595;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00095918 File Offset: 0x00093B18
		protected override void OnGotKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			short num = (short)1559928403;
			short num2 = num;
			num = (short)1341890131;
			switch (num2 == num)
			{
			}
			num = (short)432078848;
			short num3 = num;
			num = (short)1492975616;
			if (num != 0)
			{
			}
			num = (short)2016018433;
			if (num != 0)
			{
			}
			base.OnGotKeyboardFocus(e);
		}

		// Token: 0x040002E5 RID: 741
		public static readonly global::System.Windows.DependencyProperty AutoChangeProperty;

		// Token: 0x040002E6 RID: 742
		public static readonly global::System.Windows.DependencyProperty AutoChangeItemProperty;
	}
}
