using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000054 RID: 84
	public class EditorPopupButton : global::DevComponents.WpfEditors.Primitives.EditorButton
	{
		// Token: 0x0600051E RID: 1310 RVA: 0x00067C54 File Offset: 0x00065E54
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_46;
			}
			short num;
			int num3;
			global::DevComponents.WpfEditors.Primitives.EditorPopupButton editorPopupButton;
			for (;;)
			{
				IL_0A:
				num = (short)545980416;
				short num2 = num;
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_F2;
				case 2:
				{
					if (editorPopupButton == null)
					{
						return;
					}
					num = (short)849090421;
					short num4 = num;
					num = (short)589633397;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F2;
					default:
						num = (short)597426176;
						if (num != 0)
						{
						}
						num = (short)1856700417;
						if (num != 0)
						{
						}
						num = (short)87425025;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_46;
				IL_F2:
				editorPopupButton.OnIsPopupOpenChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
				num = (short)1397161984;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_46:
			editorPopupButton = (A_0 as global::DevComponents.WpfEditors.Primitives.EditorPopupButton);
			num = (short)964362242;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00067D90 File Offset: 0x00065F90
		protected virtual void OnIsPopupOpenChanged(bool oldValue, bool newValue)
		{
			short num = (short)1676345352;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (base.Parent is global::System.Windows.UIElement)
					{
						num = (short)1531772939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.a.PlacementTarget = this;
					num = (short)38535180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1099431938;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (newValue)
					{
						num = (short)166985735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.OnPopupClosed();
					goto IL_136;
				case 3:
					return;
				case 4:
					if (base.IsMouseCaptured)
					{
						num = (short)429129737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					goto IL_7F;
				case 6:
				{
					if (newValue)
					{
						return;
					}
					num = (short)839485996;
					short num3 = num;
					num = (short)380733996;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_136;
					default:
						num = (short)734396416;
						if (num != 0)
						{
						}
						num = (short)1855782925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					num = (short)127205376;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 9:
					base.ReleaseMouseCapture();
					num = (short)1565327363;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_7F;
				case 11:
					this.a.PlacementTarget = (global::System.Windows.UIElement)base.Parent;
					num = (short)1153564673;
					if (num != 0)
					{
					}
					num = (short)1127546890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_7F;
				case 13:
					num = (short)480378884;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5C:
				if (this.a != null)
				{
					num = (short)2015690753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_7F:
				num = (short)682885120;
				short num4 = num;
				num = (short)971309062;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_136:
				num = (short)763363333;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00068058 File Offset: 0x00066258
		protected virtual void OnPopupClosed()
		{
			short num = (short)1531051505;
			short num2 = num;
			num = (short)2008612337;
			switch (num2 == num)
			{
			}
			num = (short)462290944;
			short num3 = num;
			num = (short)1808990208;
			if (num != 0)
			{
			}
			num = (short)135856129;
			if (num != 0)
			{
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00068104 File Offset: 0x00066304
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x000681BC File Offset: 0x000663BC
		public bool IsPopupOpen
		{
			get
			{
				short num = (short)552892005;
				short num2 = num;
				num = (short)924218981;
				switch (num2 == num)
				{
				}
				num = (short)1887567872;
				short num3 = num;
				num = (short)1049755648;
				if (num != 0)
				{
				}
				num = (short)226099201;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorPopupButton.IsPopupOpenProperty);
			}
			set
			{
				short num = (short)1396563741;
				short num2 = num;
				num = (short)1082646301;
				switch (num2 == num)
				{
				}
				num = (short)809566208;
				short num3 = num;
				num = (short)116785152;
				if (num != 0)
				{
				}
				num = (short)1732378625;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorPopupButton.IsPopupOpenProperty, value);
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000523 RID: 1315 RVA: 0x00068278 File Offset: 0x00066478
		// (remove) Token: 0x06000524 RID: 1316 RVA: 0x00068330 File Offset: 0x00066530
		public event global::System.Windows.RoutedEventHandler PopupOpen
		{
			add
			{
				short num = (short)143797472;
				short num2 = num;
				num = (short)1661938912;
				switch (num2 == num)
				{
				}
				num = (short)307494912;
				short num3 = num;
				num = (short)1401815041;
				if (num != 0)
				{
				}
				num = (short)1869086720;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfEditors.Primitives.EditorPopupButton.PopupOpenEvent, value);
			}
			remove
			{
				short num = (short)165412865;
				if (num != 0)
				{
				}
				num = (short)833219296;
				short num2 = num;
				num = (short)1423108832;
				switch (num2 == num)
				{
				default:
				{
					num = (short)628031488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)807600128;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfEditors.Primitives.EditorPopupButton.PopupOpenEvent, value);
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x000683E8 File Offset: 0x000665E8
		protected virtual void OnPopupOpen()
		{
			short num = (short)223547584;
			short num2 = num;
			num = (short)447484096;
			switch (num2 == num)
			{
			}
			num = (short)922157056;
			short num3 = num;
			num = (short)486342657;
			if (num != 0)
			{
			}
			num = (short)1456275456;
			if (num != 0)
			{
			}
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.Primitives.EditorPopupButton.PopupOpenEvent);
			base.RaiseEvent(e);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x000684A4 File Offset: 0x000666A4
		public override void OnApplyTemplate()
		{
			int a_ = 17;
			short num = (short)520224773;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_10B;
				case 1:
					if (this.a != null)
					{
						num = (short)1184628736;
						short num3 = num;
						num = (short)2114453506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CA;
				case 2:
					this.a.Opened += this.a;
					num = (short)118947840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_110;
				case 4:
					goto IL_196;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				}
				IL_46:
				num = (short)674225998;
				short num4 = num;
				num = (short)1158274894;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_196:
					this.a.Opened -= this.a;
					num = (short)1417674755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
					num = (short)641466369;
					if (num != 0)
					{
					}
					num = (short)767295488;
					if (num != 0)
					{
					}
					if (this.a != null)
					{
						num = (short)1668481028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_110:
				this.a = (base.GetTemplateChild(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("軝ꇟ냡냣맥룧藩鳫鯭胯", a_)) as global::System.Windows.Controls.Primitives.Popup);
				num = (short)214237185;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10B:
			IL_1CA:
			base.OnApplyTemplate();
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00068684 File Offset: 0x00066884
		private void a(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)372899841;
			if (num != 0)
			{
			}
			num = (short)681644005;
			short num2 = num;
			num = (short)1300631525;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1951399936;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1218707456;
			if (num != 0)
			{
			}
			this.OnPopupOpen();
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00068734 File Offset: 0x00066934
		protected override void OnClick()
		{
			short num = (short)11403267;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)819200000;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_96;
				case 1:
				{
					num = (short)1625635873;
					short num4 = num;
					num = (short)463879201;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_EB;
					}
					break;
				}
				case 2:
					this.OpenPopup();
					num = (short)1607991297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				}
				IL_5D:
				if (!this.IsPopupOpen)
				{
					num = (short)97058818;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					this.ClosePopup();
					num = (short)757202944;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_96:
			goto IL_103;
			IL_EB:
			num = (short)900923392;
			if (num != 0)
			{
			}
			IL_103:
			num = (short)358154241;
			if (num != 0)
			{
			}
			base.OnClick();
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00068874 File Offset: 0x00066A74
		public virtual void ClosePopup()
		{
			short num = (short)1522548212;
			short num2 = num;
			num = (short)2132033012;
			switch (num2 == num)
			{
			}
			num = (short)641597440;
			short num3 = num;
			num = (short)838402048;
			if (num != 0)
			{
			}
			num = (short)1073610753;
			if (num != 0)
			{
			}
			this.IsPopupOpen = false;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00068924 File Offset: 0x00066B24
		public virtual void OpenPopup()
		{
			short num = (short)1571618823;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					((global::DevComponents.WpfEditors.Primitives.EditorInputGroup)base.Parent).b(true);
					num = (short)1073217542;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (!((global::DevComponents.WpfEditors.Primitives.EditorInputGroup)base.Parent).IsKeyboardFocusWithin)
					{
						num = (short)1833172992;
						short num3 = num;
						num = (short)1213595648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C1;
				case 2:
					if (base.Parent is global::DevComponents.WpfEditors.Primitives.EditorInputGroup)
					{
						num = (short)1033830404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C1;
				case 3:
					num = (short)1571618818;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)766181377;
					if (num != 0)
					{
					}
					goto IL_E5;
				case 5:
					return;
				case 6:
					goto IL_1C1;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				}
				IL_44:
				num = (short)2113370566;
				short num4 = num;
				num = (short)199522758;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_E5:
					num = (short)1968373761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
					num = (short)1524301824;
					if (num != 0)
					{
					}
					if (!this.IsPopupOpen)
					{
						num = (short)845217795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_1C1:
				this.BeforePopupOpen();
				this.IsPopupOpen = true;
				this.AfterPopupOpen();
				global::System.Windows.Input.Mouse.Capture(this, global::System.Windows.Input.CaptureMode.SubTree);
				num = (short)1629683717;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00068B28 File Offset: 0x00066D28
		protected virtual void BeforePopupOpen()
		{
			short num = (short)1193129999;
			short num2 = num;
			num = (short)991541263;
			switch (num2 == num)
			{
			}
			num = (short)1079181312;
			short num3 = num;
			num = (short)1024983041;
			if (num != 0)
			{
			}
			num = (short)1722155008;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00068BD4 File Offset: 0x00066DD4
		protected virtual void AfterPopupOpen()
		{
			short num = (short)1278410753;
			if (num != 0)
			{
			}
			num = (short)670854845;
			short num2 = num;
			num = (short)607022781;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1838350336;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1882193920;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00068C80 File Offset: 0x00066E80
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1594490892;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (!global::System.Windows.Input.Mouse.Capture(this, global::System.Windows.Input.CaptureMode.SubTree))
					{
						goto IL_1ED;
					}
					num = (short)858086369;
					short num3 = num;
					num = (short)928144353;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_174;
					default:
						num = (short)1486880769;
						if (num != 0)
						{
						}
						num = (short)991952896;
						if (num != 0)
						{
						}
						num = (short)1175912452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (global::System.Windows.Input.Mouse.Captured != null)
					{
						num = (short)669057032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_297;
				case 2:
					if (global::System.Windows.Input.Mouse.Captured == null)
					{
						num = (short)740753417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1ED;
				case 3:
					goto IL_297;
				case 4:
					goto IL_158;
				case 5:
					num = (short)722993162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_20A;
				case 7:
					if (e.OriginalSource is global::System.Windows.DependencyObject)
					{
						num = (short)1546584069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1ED;
				case 8:
					num = (short)311492619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1743257607;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_174;
				case 11:
					if (!this.b(global::System.Windows.Input.Mouse.Captured as global::System.Windows.DependencyObject))
					{
						num = (short)423690243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D2;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 13:
				{
					num = (short)1308033024;
					short num4 = num;
					num = (short)108199936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 14:
					num = (short)1166868481;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_60:
				if (this.IsPopupOpen)
				{
					num = (short)37355534;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2D2;
				IL_174:
				if (this.b((global::System.Windows.DependencyObject)e.OriginalSource))
				{
					num = (short)909246477;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1ED:
				this.ClosePopup();
				num = (short)1924071430;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_297:
				num = (short)1478688770;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_158:
			base.OnLostMouseCapture(e);
			return;
			IL_20A:
			IL_2D2:
			base.OnLostMouseCapture(e);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00068F68 File Offset: 0x00067168
		private bool b(global::System.Windows.DependencyObject A_0)
		{
			if (A_0 == null)
			{
				short num = (short)1966879459;
				short num2 = num;
				num = (short)1138766563;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1565720576;
					short num3 = num;
					num = (short)965083136;
					if (num != 0)
					{
					}
					num = (short)1080360961;
					if (num != 0)
					{
					}
					return false;
				}
				}
			}
			return this.a(this, A_0);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00069024 File Offset: 0x00067224
		private bool a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyObject A_1)
		{
			int a_ = 12;
			short num = (short)1574699030;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					A_1 = global::System.Windows.LogicalTreeHelper.GetParent(A_1);
					num = (short)1440874506;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					A_1 = global::System.Windows.LogicalTreeHelper.GetParent(A_1);
					num = (short)801112079;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					global::System.Windows.Controls.Primitives.Popup popup;
					if (this.a == popup)
					{
						num = (short)1095237638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					A_1 = popup.Parent;
					num = (short)1081344004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					return false;
				case 4:
					goto IL_227;
				case 5:
					num = (short)2101215234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)794387013;
					short num3 = num;
					num = (short)1869898309;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FC;
					default:
						goto IL_2FB;
					}
					break;
				}
				case 7:
					num = (short)1777598475;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (A_1 is global::System.Windows.FrameworkElement)
					{
						num = (short)823984135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B5;
				case 9:
					if (A_1 == A_0)
					{
						num = (short)312279060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_314;
				case 10:
					if (A_1 != null)
					{
						num = (short)1510604818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_227;
				case 11:
					if (((global::System.Windows.FrameworkElement)A_1).Name == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("觘듚규꫞釠ꃢ蓤详賨藪觬軮菰", a_))
					{
						num = (short)1616052224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B5;
				case 12:
					return true;
				case 13:
					if (A_1 == this.a.Child)
					{
						num = (short)819789845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1672413193;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
				{
					global::System.Windows.Controls.Primitives.Popup popup;
					if (popup.Parent != null)
					{
						num = (short)212860933;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B0;
				}
				case 15:
					goto IL_227;
				case 16:
					num = (short)284360718;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
				{
					if (A_1 == null)
					{
						num = (short)2100232195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Windows.Controls.Primitives.Popup popup = A_1 as global::System.Windows.Controls.Primitives.Popup;
					num = (short)1949761559;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 18:
					num = (short)605093907;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
				{
					num = (short)485163008;
					short num4 = num;
					if (!(A_1 is global::System.Windows.Controls.Primitives.Popup))
					{
						num = (short)1293352961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_227;
				}
				case 20:
					return true;
				case 21:
					return true;
				case 22:
					switch (0)
					{
					case 0:
						goto IL_92;
					}
					continue;
				case 23:
				{
					global::System.Windows.Controls.Primitives.Popup popup;
					if (popup != null)
					{
						num = (short)818348048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B0;
				}
				case 24:
					goto IL_FC;
				}
				IL_92:
				if (A_1 == A_0)
				{
					num = (short)1635909644;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_314;
				IL_B5:
				A_1 = global::DevComponents.WpfEditors.Primitives.EditorPopupButton.a(A_1);
				num = (short)810418177;
				if (num != 0)
				{
				}
				num = (short)165871640;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_227:
				num = (short)1229062157;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_FC:
				goto IL_227;
				IL_314:
				num = (short)1987117073;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3B0:
				num = (short)1847590920;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_2FB:
			num = (short)473235456;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00069488 File Offset: 0x00067688
		private static global::System.Windows.DependencyObject a(global::System.Windows.DependencyObject A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			global::System.Windows.FrameworkContentElement frameworkContentElement;
			global::System.Windows.Media.Visual visual;
			for (;;)
			{
				IL_0A:
				global::System.Windows.ContentElement contentElement;
				global::System.Windows.ContentElement contentElement2;
				switch (num)
				{
				case 0:
					if (A_0 != null)
					{
						num2 = (short)971112450;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					frameworkContentElement = (contentElement as global::System.Windows.FrameworkContentElement);
					num2 = (short)2146500609;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (frameworkContentElement != null)
					{
						num2 = (short)104464389;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_255;
				case 2:
					goto IL_217;
				case 3:
					contentElement2 = (A_0 as global::System.Windows.ContentElement);
					goto IL_21C;
				case 4:
					if (contentElement != null)
					{
						num2 = (short)1661599753;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1887109127;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_15A;
				case 6:
				{
					num2 = (short)1154940928;
					short num3 = num2;
					num2 = (short)663683080;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					if (visual != null)
					{
						num2 = (short)583008266;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_255;
				case 8:
					contentElement2 = null;
					goto IL_21C;
				case 9:
					A_0 = global::System.Windows.ContentOperations.GetParent(contentElement);
					num2 = (short)838270976;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_FF;
				case 11:
					if (visual != null)
					{
						num2 = (short)190185478;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)500629507;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_40;
				IL_21C:
				contentElement = contentElement2;
				num2 = (short)1957429252;
				num = (int)((global::System.IntPtr)num2);
			}
			return A_0;
			IL_FF:
			num2 = (short)44228204;
			short num4 = num2;
			num2 = (short)1274928748;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return A_0;
			default:
				num2 = (short)444792832;
				if (num2 != 0)
				{
				}
				num2 = (short)1850146817;
				if (num2 != 0)
				{
				}
				return global::System.Windows.Media.VisualTreeHelper.GetParent(visual);
			}
			IL_15A:
			return frameworkContentElement.Parent;
			IL_217:
			return A_0;
			IL_255:
			return null;
			IL_40:
			visual = (A_0 as global::System.Windows.Media.Visual);
			num2 = (short)1910767627;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00069700 File Offset: 0x00067900
		// Note: this type is marked as 'beforefieldinit'.
		static EditorPopupButton()
		{
			int a_ = 12;
			short num = (short)2125681590;
			short num2 = num;
			num = (short)428757942;
			switch (num2 == num)
			{
			}
			num = (short)346816512;
			short num3 = num;
			num = (short)1862008833;
			if (num != 0)
			{
			}
			num = (short)170000384;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.Primitives.EditorPopupButton.IsPopupOpenProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("郘꣚跜냞釠離闤꣦駨軪菬", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.Primitives.EditorPopupButton), new global::System.Windows.UIPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.Primitives.EditorPopupButton.a)));
			global::DevComponents.WpfEditors.Primitives.EditorPopupButton.PopupOpenEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("觘듚규꫞釠곢闤苦蟨", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.Primitives.EditorPopupButton));
		}

		// Token: 0x04000270 RID: 624
		public static readonly global::System.Windows.DependencyProperty IsPopupOpenProperty;

		// Token: 0x04000272 RID: 626
		private global::System.Windows.Controls.Primitives.Popup a;
	}
}
