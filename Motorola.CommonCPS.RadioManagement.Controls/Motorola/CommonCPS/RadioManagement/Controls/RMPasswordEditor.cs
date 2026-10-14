using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Infragistics.Windows.Editors;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000097 RID: 151
	public class RMPasswordEditor : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600039D RID: 925 RVA: 0x0003BC08 File Offset: 0x00039E08
		public RMPasswordEditor()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0003BC24 File Offset: 0x00039E24
		// (set) Token: 0x0600039F RID: 927 RVA: 0x0003BCDC File Offset: 0x00039EDC
		public bool IsShowingEyeButton
		{
			get
			{
				short num = (short)998782212;
				short num2 = num;
				num = (short)319960324;
				switch (num2 == num)
				{
				}
				num = (short)1247019009;
				if (num != 0)
				{
				}
				num = (short)789970944;
				short num3 = num;
				num = (short)264765440;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor.IsShowingEyeButtonProperty);
			}
			set
			{
				short num = (short)1625100281;
				short num2 = num;
				num = (short)962662393;
				switch (num2 == num)
				{
				}
				num = (short)1199177729;
				if (num != 0)
				{
				}
				num = (short)340852736;
				short num3 = num;
				num = (short)444858368;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor.IsShowingEyeButtonProperty, value);
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0003BD94 File Offset: 0x00039F94
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)635699202;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1300430848;
				short num3 = num;
				global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor rmpasswordEditor;
				switch (num2)
				{
				case 0:
					if (rmpasswordEditor != null)
					{
						num = (short)257490947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_B1;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 3:
				{
					num = (short)786589224;
					short num4 = num;
					num = (short)1946314280;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B1;
					default:
						num = (short)2027945984;
						if (num != 0)
						{
						}
						rmpasswordEditor.btnShowPassword.Visibility = global::System.Windows.Visibility.Collapsed;
						num = (short)818020356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					return;
				}
				IL_62:
				if (!(bool)A_1.NewValue)
				{
					num = (short)170983425;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_B1:
				num = (short)548012033;
				if (num != 0)
				{
				}
				rmpasswordEditor = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor);
				num = (short)935395328;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0003BF04 File Offset: 0x0003A104
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x0003BFC0 File Offset: 0x0003A1C0
		public string Password
		{
			get
			{
				short num = (short)1647351415;
				short num2 = num;
				num = (short)284399223;
				switch (num2 == num)
				{
				}
				num = (short)198377472;
				if (num != 0)
				{
				}
				num = (short)2090532864;
				short num3 = num;
				num = (short)736559105;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor.PasswordProperty);
			}
			set
			{
				short num = (short)1661869139;
				short num2 = num;
				num = (short)780082259;
				switch (num2 == num)
				{
				}
				num = (short)1612644353;
				if (num != 0)
				{
				}
				num = (short)2138898432;
				short num3 = num;
				num = (short)1929773056;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor.PasswordProperty, value);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x0003C078 File Offset: 0x0003A278
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x0003C130 File Offset: 0x0003A330
		public string Mask
		{
			get
			{
				short num = (short)682115343;
				short num2 = num;
				num = (short)1475690767;
				switch (num2 == num)
				{
				}
				num = (short)870514689;
				if (num != 0)
				{
				}
				num = (short)98762752;
				short num3 = num;
				num = (short)1633419264;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor.MaskProperty);
			}
			set
			{
				short num = (short)540309743;
				short num2 = num;
				num = (short)1985968367;
				switch (num2 == num)
				{
				}
				num = (short)1357119489;
				if (num != 0)
				{
				}
				num = (short)808714240;
				short num3 = num;
				num = (short)2022113280;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor.MaskProperty, value);
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0003C1E4 File Offset: 0x0003A3E4
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1426128896;
			short num2 = num;
			num = (short)92471296;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)245524213;
				short num4 = num;
				num = (short)596731637;
				string text;
				global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor rmpasswordEditor;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1433337856;
					if (num != 0)
					{
					}
					string text2;
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_B2;
						}
						continue;
					case 1:
						if (text != null)
						{
							num = (short)1517813765;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						goto IL_123;
					case 3:
						return;
					case 4:
						if (rmpasswordEditor != null)
						{
							num = (short)559415298;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						rmpasswordEditor = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor);
						num = (short)964165636;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						text2 = null;
						goto IL_16E;
					}
					IL_B2:
					num = (short)1652686849;
					if (num != 0)
					{
					}
					object newValue = A_1.NewValue;
					if (newValue == null)
					{
						num = (short)1605828614;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					text2 = newValue.ToString();
					IL_16E:
					text = text2;
					num = (short)1823080449;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_123:
				rmpasswordEditor.msiPassword.Mask = text;
				num = (short)1108606979;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x0003C398 File Offset: 0x0003A598
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x0003C450 File Offset: 0x0003A650
		public string IsReadOnly
		{
			get
			{
				short num = (short)182759270;
				short num2 = num;
				num = (short)1075556198;
				switch (num2 == num)
				{
				}
				num = (short)2021195777;
				if (num != 0)
				{
				}
				num = (short)1061355520;
				short num3 = num;
				num = (short)1350238208;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor.IsReadOnlyProperty);
			}
			set
			{
				short num = (short)285354278;
				short num2 = num;
				num = (short)701573414;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1482883072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1281097728;
				if (num != 0)
				{
				}
				num = (short)458753;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor.IsReadOnlyProperty, value);
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0003C508 File Offset: 0x0003A708
		private void btnShowPassword_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)6423205;
			short num2 = num;
			num = (short)335872677;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1061093376;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)822214657;
			if (num != 0)
			{
			}
			num = (short)730136576;
			if (num != 0)
			{
			}
			this.msiPassword.Visibility = global::System.Windows.Visibility.Collapsed;
			this.msiClearText.Visibility = global::System.Windows.Visibility.Visible;
			this.imgWhiteEye.Visibility = global::System.Windows.Visibility.Collapsed;
			this.imgBlackEye.Visibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0003C5E0 File Offset: 0x0003A7E0
		private void btnShowPassword_PreviewMouseLeftButtonUp(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)1808669658;
			short num2 = num;
			num = (short)1088691162;
			switch (num2 == num)
			{
			default:
			{
				num = (short)808517632;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1333592065;
			if (num != 0)
			{
			}
			num = (short)1776549888;
			if (num != 0)
			{
			}
			this.msiPassword.Visibility = global::System.Windows.Visibility.Visible;
			this.msiClearText.Visibility = global::System.Windows.Visibility.Collapsed;
			this.imgWhiteEye.Visibility = global::System.Windows.Visibility.Visible;
			this.imgBlackEye.Visibility = global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0003C6BC File Offset: 0x0003A8BC
		private void btnShowPassword_MouseLeave(object A_0, global::System.Windows.Input.MouseEventArgs A_1)
		{
			short num = (short)1234389700;
			short num2 = num;
			num = (short)472206020;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1949761536;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1944256512;
			if (num != 0)
			{
			}
			num = (short)1067122689;
			if (num != 0)
			{
			}
			this.msiPassword.Visibility = global::System.Windows.Visibility.Visible;
			this.msiClearText.Visibility = global::System.Windows.Visibility.Collapsed;
			this.imgWhiteEye.Visibility = global::System.Windows.Visibility.Visible;
			this.imgBlackEye.Visibility = global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0003C798 File Offset: 0x0003A998
		private void grdContainer_MouseLeftButtonUp(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)1606124868;
			short num2 = num;
			num = (short)2031977796;
			switch (num2 == num)
			{
			default:
			{
				num = (short)150274048;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)738590721;
			if (num != 0)
			{
			}
			num = (short)1450704896;
			if (num != 0)
			{
			}
			this.msiPassword.Focus();
			this.msiPassword.SelectAll();
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0003C858 File Offset: 0x0003AA58
		public new void Focus()
		{
			short num = (short)218458869;
			short num2 = num;
			num = (short)908815093;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2012413952;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1361248257;
			if (num != 0)
			{
			}
			num = (short)2066153472;
			if (num != 0)
			{
			}
			this.msiPassword.Focus();
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0003C90C File Offset: 0x0003AB0C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 9;
			if (this._contentLoaded)
			{
				short num = (short)2110980096;
				short num2 = num;
				num = (short)1069195752;
				short num3 = num;
				num = (short)1119855080;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)290652161;
					if (num != 0)
					{
					}
					num = (short)1239023616;
					if (num != 0)
					{
					}
					return;
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("躠쪤펦욨\ud9aa슬쎮킰鶲\ud8b6풸횺튼톾苀鏂雄鯈꫊꧌ꛎ뻐黒듔맖룘볚룜닞蓠跢釤짦ꫨ蓪菬鯮菰鳲駴蓶싸飺鋼鋾焀氂欄戆月缊∌税成瘒朔琖瘘甚検洞丠伢嘤ࠦ伨䈪䠬䌮唰嘲儴帶䴸吺似䰾湀ㅂ⡄㝆⡈㡊㹌㡎㹐⅒ㅔ㉖㵘㉚⥜ぞ፠䵢ᵤ٦Ѩݪ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0003C9F0 File Offset: 0x0003ABF0
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)361955329;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_174;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
				{
					num = (short)71082840;
					short num3 = num;
					num = (short)509649752;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_174;
					default:
						num = (short)1994784768;
						if (num != 0)
						{
						}
						num = (short)1146093568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_142;
				case 2:
					goto IL_1BB;
				case 3:
					goto IL_1AE;
				case 4:
					goto IL_10A;
				case 5:
					goto IL_B8;
				case 6:
					goto IL_1A1;
				case 7:
					goto IL_14F;
				default:
					num = (short)928186370;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_B8:
			this.btnShowPassword = (global::System.Windows.Controls.Button)target;
			this.btnShowPassword.Click += this.btnShowPassword_Click;
			this.btnShowPassword.PreviewMouseLeftButtonUp += this.btnShowPassword_PreviewMouseLeftButtonUp;
			this.btnShowPassword.MouseLeave += this.btnShowPassword_MouseLeave;
			return;
			IL_10A:
			num = (short)1069285376;
			short num4 = num;
			this.msiClearText = (global::Infragistics.Windows.Editors.XamMaskedEditor)target;
			return;
			IL_142:
			this.RmPasswordEditor = (global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor)target;
			return;
			IL_14F:
			this.imgBlackEye = (global::System.Windows.Controls.Grid)target;
			return;
			IL_174:
			num = (short)524156929;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			return;
			IL_1A1:
			this.imgWhiteEye = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1AE:
			this.msiPassword = (global::Infragistics.Windows.Editors.XamMaskedEditor)target;
			return;
			IL_1BB:
			this.grdContainer = (global::System.Windows.Controls.Grid)target;
			this.grdContainer.MouseLeftButtonUp += this.grdContainer_MouseLeftButtonUp;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0003CBE4 File Offset: 0x0003ADE4
		// Note: this type is marked as 'beforefieldinit'.
		static RMPasswordEditor()
		{
			int a_ = 15;
			short num = (short)1896682204;
			short num2 = num;
			num = (short)524358364;
			switch (num2 == num)
			{
			default:
			{
				num = (short)472317952;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)243859457;
			if (num != 0)
			{
			}
			num = (short)1415577600;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor.IsShowingEyeButtonProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udaa8얬삮우\udab2\udbb4킶ﲸ슺\ud8bcﶾ듀럂뇄꣆ꟈ", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor.b)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor.PasswordProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좨\ud8aa\udeac\ud8ae\udeb0솲톴", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor.MaskProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좨\ud8aa욬", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor.a)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor.IsReadOnlyProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udaa8寧좬캮햰ﲲ\udbb4\udbb6삸", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
		}

		// Token: 0x0400012C RID: 300
		public static readonly global::System.Windows.DependencyProperty IsShowingEyeButtonProperty;

		// Token: 0x0400012D RID: 301
		public static readonly global::System.Windows.DependencyProperty PasswordProperty;

		// Token: 0x0400012E RID: 302
		public static readonly global::System.Windows.DependencyProperty MaskProperty;

		// Token: 0x0400012F RID: 303
		public static readonly global::System.Windows.DependencyProperty IsReadOnlyProperty;

		// Token: 0x04000130 RID: 304
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordEditor RmPasswordEditor;

		// Token: 0x04000131 RID: 305
		internal global::System.Windows.Controls.Grid grdContainer;

		// Token: 0x04000132 RID: 306
		internal global::Infragistics.Windows.Editors.XamMaskedEditor msiPassword;

		// Token: 0x04000133 RID: 307
		internal global::Infragistics.Windows.Editors.XamMaskedEditor msiClearText;

		// Token: 0x04000134 RID: 308
		internal global::System.Windows.Controls.Button btnShowPassword;

		// Token: 0x04000135 RID: 309
		internal global::System.Windows.Controls.Grid imgWhiteEye;

		// Token: 0x04000136 RID: 310
		internal global::System.Windows.Controls.Grid imgBlackEye;

		// Token: 0x04000137 RID: 311
		private bool _contentLoaded;
	}
}
