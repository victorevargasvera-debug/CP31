using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Infragistics.Windows.Editors;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000B9 RID: 185
	public class RMPasswordBox : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060004B1 RID: 1201 RVA: 0x0004CB34 File Offset: 0x0004AD34
		public RMPasswordBox()
		{
			this.InitializeComponent();
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x0004CB50 File Offset: 0x0004AD50
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x0004CC10 File Offset: 0x0004AE10
		public bool IsShowingEyeButton
		{
			get
			{
				short num = (short)226232146;
				short num2 = num;
				num = (short)850397010;
				switch (num2 == num)
				{
				}
				num = (short)2039087105;
				if (num != 0)
				{
				}
				num = (short)17498112;
				if (num != 0)
				{
				}
				num = (short)1562968064;
				short num3 = num;
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox.IsShowingEyeButtonProperty);
			}
			set
			{
				short num = (short)1935134597;
				short num2 = num;
				num = (short)400150405;
				switch (num2 == num)
				{
				}
				num = (short)1117323265;
				if (num != 0)
				{
				}
				num = (short)1886060544;
				if (num != 0)
				{
				}
				num = (short)818479104;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox.IsShowingEyeButtonProperty, value);
			}
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0004CCCC File Offset: 0x0004AECC
		private static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			for (;;)
			{
				IL_00:
				short num = (short)641597440;
				short num2 = num;
				num = (short)1050148865;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					case 2:
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox rmpasswordBox = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox;
						rmpasswordBox.btnShowPassword.Visibility = global::System.Windows.Visibility.Collapsed;
						num = (short)270925824;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_58:
					num = (short)1778092385;
					short num4 = num;
					num = (short)1400670561;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)172228609;
						if (num != 0)
						{
						}
						num = (short)2024734720;
						if (num != 0)
						{
						}
						if ((bool)A_1.NewValue)
						{
							return;
						}
						num = (short)431030274;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x0004CDFC File Offset: 0x0004AFFC
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x0004CEB4 File Offset: 0x0004B0B4
		public bool IsHideBorder
		{
			get
			{
				short num = (short)1308168740;
				short num2 = num;
				num = (short)1036522020;
				switch (num2 == num)
				{
				}
				num = (short)951386113;
				if (num != 0)
				{
				}
				num = (short)1556480000;
				if (num != 0)
				{
				}
				num = (short)1411317760;
				short num3 = num;
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox.IsHideBorderProperty);
			}
			set
			{
				short num = (short)712470141;
				short num2 = num;
				num = (short)1411804797;
				switch (num2 == num)
				{
				}
				num = (short)160628737;
				if (num != 0)
				{
				}
				num = (short)1196425216;
				if (num != 0)
				{
				}
				num = (short)2069889024;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox.IsHideBorderProperty, value);
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0004CF6C File Offset: 0x0004B16C
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1957822464;
				short num2 = num;
				num = (short)965804033;
				if (num != 0)
				{
				}
				num = (short)1012137985;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					case 2:
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox rmpasswordBox = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox;
						rmpasswordBox.grdBorder.BorderBrush = global::System.Windows.Media.Brushes.Transparent;
						rmpasswordBox.msiPassword.Background = global::System.Windows.Media.Brushes.Transparent;
						num = (short)1944649728;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_7E:
					num = (short)501089887;
					short num4 = num;
					num = (short)1863190111;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)1619984384;
						if (num != 0)
						{
						}
						if (!(bool)A_1.NewValue)
						{
							return;
						}
						num = (short)1256783874;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x0004D0AC File Offset: 0x0004B2AC
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x0004D164 File Offset: 0x0004B364
		public string Password
		{
			get
			{
				short num = (short)744316246;
				short num2 = num;
				num = (short)1346526550;
				switch (num2 == num)
				{
				}
				num = (short)1237843969;
				if (num != 0)
				{
				}
				num = (short)816971776;
				if (num != 0)
				{
				}
				num = (short)1348468736;
				short num3 = num;
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox.PasswordProperty);
			}
			set
			{
				short num = (short)85148837;
				short num2 = num;
				num = (short)912737445;
				switch (num2 == num)
				{
				}
				num = (short)935723009;
				if (num != 0)
				{
				}
				num = (short)984743936;
				if (num != 0)
				{
				}
				num = (short)544407552;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox.PasswordProperty, value);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x0004D218 File Offset: 0x0004B418
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x0004D2D0 File Offset: 0x0004B4D0
		public string Mask
		{
			get
			{
				short num = (short)1128300367;
				short num2 = num;
				num = (short)1595113295;
				switch (num2 == num)
				{
				}
				num = (short)1851523072;
				if (num != 0)
				{
				}
				num = (short)1229651969;
				if (num != 0)
				{
				}
				num = (short)1781071872;
				short num3 = num;
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox.MaskProperty);
			}
			set
			{
				short num = (short)1538680619;
				short num2 = num;
				num = (short)2089903915;
				switch (num2 == num)
				{
				}
				num = (short)1364983808;
				if (num != 0)
				{
				}
				num = (short)204210177;
				if (num != 0)
				{
				}
				num = (short)1788739584;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox.MaskProperty, value);
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0004D388 File Offset: 0x0004B588
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)92405760;
			short num2 = num;
			num = (short)1930849118;
			short num3 = num;
			num = (short)922774366;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F4:
				num = (short)464453636;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)143654912;
				if (num != 0)
				{
				}
				num = (short)1036779523;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox rmpasswordBox = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox;
					rmpasswordBox.msiPassword.Mask = A_1.NewValue.ToString();
					num = (short)940834817;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					return;
				case 2:
					goto IL_F4;
				case 3:
					num = (short)1085997057;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_D3;
					}
					continue;
				case 4:
					if (A_1.NewValue.ToString() != string.Empty)
					{
						num = (short)1220804608;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_D3:
				if (A_1.NewValue == null)
				{
					break;
				}
				num = (short)1901330434;
				num4 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0004D50C File Offset: 0x0004B70C
		private void btnShowPassword_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)287639366;
			short num2 = num;
			num = (short)440600390;
			switch (num2 == num)
			{
			}
			num = (short)889651201;
			if (num != 0)
			{
			}
			num = (short)1348599808;
			if (num != 0)
			{
			}
			num = (short)1799618560;
			short num3 = num;
			this.msiPassword.Visibility = global::System.Windows.Visibility.Collapsed;
			this.msiClearText.Visibility = global::System.Windows.Visibility.Visible;
			this.imgWhiteEye.Visibility = global::System.Windows.Visibility.Collapsed;
			this.imgBlackEye.Visibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0004D5E8 File Offset: 0x0004B7E8
		private void btnShowPassword_PreviewMouseLeftButtonUp(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)1629410536;
			short num2 = num;
			num = (short)1304089832;
			switch (num2 == num)
			{
			}
			num = (short)1264451585;
			if (num != 0)
			{
			}
			num = (short)1166802944;
			if (num != 0)
			{
			}
			num = (short)700645376;
			short num3 = num;
			this.msiPassword.Visibility = global::System.Windows.Visibility.Visible;
			this.msiClearText.Visibility = global::System.Windows.Visibility.Collapsed;
			this.imgWhiteEye.Visibility = global::System.Windows.Visibility.Visible;
			this.imgBlackEye.Visibility = global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0004D6C4 File Offset: 0x0004B8C4
		private void btnShowPassword_MouseLeave(object A_0, global::System.Windows.Input.MouseEventArgs A_1)
		{
			short num = (short)975836730;
			short num2 = num;
			num = (short)1486427706;
			switch (num2 == num)
			{
			}
			num = (short)314703873;
			if (num != 0)
			{
			}
			num = (short)906756096;
			if (num != 0)
			{
			}
			num = (short)108855296;
			short num3 = num;
			this.msiPassword.Visibility = global::System.Windows.Visibility.Visible;
			this.msiClearText.Visibility = global::System.Windows.Visibility.Collapsed;
			this.imgWhiteEye.Visibility = global::System.Windows.Visibility.Visible;
			this.imgBlackEye.Visibility = global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0004D79C File Offset: 0x0004B99C
		public new void Focus()
		{
			short num = (short)175001528;
			short num2 = num;
			num = (short)1301499832;
			switch (num2 == num)
			{
			}
			num = (short)1753808897;
			if (num != 0)
			{
			}
			num = (short)710934528;
			if (num != 0)
			{
			}
			num = (short)244318208;
			short num3 = num;
			this.msiPassword.Focus();
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0004D850 File Offset: 0x0004BA50
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 8;
			short num;
			if (!this._contentLoaded)
			{
				num = (short)1050522293;
				short num2 = num;
				num = (short)12300981;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1291059200;
					short num3 = num;
					num = (short)366673920;
					if (num != 0)
					{
					}
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("辟쮣튥잧\ud8a9쎫슭톯鲱\ud9b5햷ힹ펻킽莿鋁韃髇ꯉ꣋ꟍ뿏鿑뗓룕맗뷙맛돝藟賡郣죥ꯧ藩苫髭苯鷱飳藵쏷駹鏻鏽烿洁樃挅昇縉⌋笍挏眑易甕眗琙栛氝伟両圣थ娧䜩尫伭䌯䄱䌳夵䨷帹帻儽㠿汁㱃❅╇♉", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
			num = (short)584122369;
			if (num != 0)
			{
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0004D930 File Offset: 0x0004BB30
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1421934593;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_22F;
				case 1:
					goto IL_16;
				case 2:
					num = (short)965607424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_32;
				IL_16:
				switch (0)
				{
				case 0:
					IL_32:
					switch (connectionId)
					{
					case 1:
						goto IL_241;
					case 2:
						goto IL_11A;
					case 3:
						goto IL_100;
					case 4:
						goto IL_19F;
					case 5:
						goto IL_234;
					case 6:
						goto IL_20B;
					case 7:
						goto IL_24E;
					case 8:
						goto IL_275;
					case 9:
						goto IL_192;
					case 10:
						goto IL_F3;
					case 11:
						goto IL_268;
					case 12:
						goto IL_127;
					case 13:
					{
						num = (short)1701998967;
						short num3 = num;
						num = (short)1670214007;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16;
						default:
							goto IL_D1;
						}
						break;
					}
					case 14:
						goto IL_25B;
					case 15:
						goto IL_10D;
					case 16:
						goto IL_1AC;
					case 17:
						goto IL_185;
					case 18:
						goto IL_1FE;
					default:
						num = (short)1802764290;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
			}
			IL_D1:
			num = (short)50724864;
			if (num != 0)
			{
			}
			this.FocusBorder = (global::System.Windows.Controls.Border)target;
			return;
			IL_F3:
			this.MainBorder = (global::System.Windows.Controls.Border)target;
			return;
			IL_100:
			this.MouseOver = (global::System.Windows.VisualState)target;
			return;
			IL_10D:
			this.msiClearText = (global::Infragistics.Windows.Editors.XamMaskedEditor)target;
			return;
			IL_11A:
			this.CommonStates = (global::System.Windows.VisualStateGroup)target;
			return;
			IL_127:
			num = (short)1390608384;
			short num4 = num;
			num = (short)81133569;
			if (num != 0)
			{
			}
			this.OverBorder = (global::System.Windows.Controls.Border)target;
			return;
			IL_185:
			this.imgWhiteEye = (global::System.Windows.Controls.Grid)target;
			return;
			IL_192:
			this.Focused = (global::System.Windows.VisualState)target;
			return;
			IL_19F:
			this.Disabled = (global::System.Windows.VisualState)target;
			return;
			IL_1AC:
			this.btnShowPassword = (global::System.Windows.Controls.Button)target;
			this.btnShowPassword.Click += this.btnShowPassword_Click;
			this.btnShowPassword.PreviewMouseLeftButtonUp += this.btnShowPassword_PreviewMouseLeftButtonUp;
			this.btnShowPassword.MouseLeave += this.btnShowPassword_MouseLeave;
			return;
			IL_1FE:
			this.imgBlackEye = (global::System.Windows.Controls.Grid)target;
			return;
			IL_20B:
			this.ReadOnly = (global::System.Windows.VisualState)target;
			return;
			IL_22F:
			this._contentLoaded = true;
			return;
			IL_234:
			this.Normal = (global::System.Windows.VisualState)target;
			return;
			IL_241:
			this.userControl = (global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox)target;
			return;
			IL_24E:
			this.FocusStates = (global::System.Windows.VisualStateGroup)target;
			return;
			IL_25B:
			this.msiPassword = (global::Infragistics.Windows.Editors.XamMaskedEditor)target;
			return;
			IL_268:
			this.grdBorder = (global::System.Windows.Controls.Border)target;
			return;
			IL_275:
			this.Unfocused = (global::System.Windows.VisualState)target;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0004DBC8 File Offset: 0x0004BDC8
		// Note: this type is marked as 'beforefieldinit'.
		static RMPasswordBox()
		{
			int a_ = 5;
			short num = (short)1986500210;
			short num2 = num;
			num = (short)144021106;
			switch (num2 == num)
			{
			}
			num = (short)1505296385;
			if (num != 0)
			{
			}
			num = (short)365756416;
			if (num != 0)
			{
			}
			num = (short)1702494208;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox.IsShowingEyeButtonProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("풜쮢쪤킦삨얪쪬좰횲슶춸쾺튼톾", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox.c)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox.IsHideBorderProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("풜쪢솤슦쒪\udfac쮮풰솲", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox.b)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox.PasswordProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("출ﺞ튠킢튤좦\udba8쾪", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox.MaskProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("킜ﺞ튠좢", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox.a)));
		}

		// Token: 0x040001C1 RID: 449
		public static readonly global::System.Windows.DependencyProperty IsShowingEyeButtonProperty;

		// Token: 0x040001C2 RID: 450
		public static readonly global::System.Windows.DependencyProperty IsHideBorderProperty;

		// Token: 0x040001C3 RID: 451
		public static readonly global::System.Windows.DependencyProperty PasswordProperty;

		// Token: 0x040001C4 RID: 452
		public static readonly global::System.Windows.DependencyProperty MaskProperty;

		// Token: 0x040001C5 RID: 453
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox userControl;

		// Token: 0x040001C6 RID: 454
		internal global::System.Windows.VisualStateGroup CommonStates;

		// Token: 0x040001C7 RID: 455
		internal global::System.Windows.VisualState MouseOver;

		// Token: 0x040001C8 RID: 456
		internal global::System.Windows.VisualState Disabled;

		// Token: 0x040001C9 RID: 457
		internal global::System.Windows.VisualState Normal;

		// Token: 0x040001CA RID: 458
		internal global::System.Windows.VisualState ReadOnly;

		// Token: 0x040001CB RID: 459
		internal global::System.Windows.VisualStateGroup FocusStates;

		// Token: 0x040001CC RID: 460
		internal global::System.Windows.VisualState Unfocused;

		// Token: 0x040001CD RID: 461
		internal global::System.Windows.VisualState Focused;

		// Token: 0x040001CE RID: 462
		internal global::System.Windows.Controls.Border MainBorder;

		// Token: 0x040001CF RID: 463
		internal global::System.Windows.Controls.Border grdBorder;

		// Token: 0x040001D0 RID: 464
		internal global::System.Windows.Controls.Border OverBorder;

		// Token: 0x040001D1 RID: 465
		internal global::System.Windows.Controls.Border FocusBorder;

		// Token: 0x040001D2 RID: 466
		internal global::Infragistics.Windows.Editors.XamMaskedEditor msiPassword;

		// Token: 0x040001D3 RID: 467
		internal global::Infragistics.Windows.Editors.XamMaskedEditor msiClearText;

		// Token: 0x040001D4 RID: 468
		internal global::System.Windows.Controls.Button btnShowPassword;

		// Token: 0x040001D5 RID: 469
		internal global::System.Windows.Controls.Grid imgWhiteEye;

		// Token: 0x040001D6 RID: 470
		internal global::System.Windows.Controls.Grid imgBlackEye;

		// Token: 0x040001D7 RID: 471
		private bool _contentLoaded;
	}
}
