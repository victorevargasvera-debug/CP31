using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000FE RID: 254
	public class PathSelector : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000752 RID: 1874 RVA: 0x000756C4 File Offset: 0x000738C4
		public PathSelector()
		{
			this.InitializeComponent();
			this.tb.Click += this.Click;
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x000756F4 File Offset: 0x000738F4
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x000757AC File Offset: 0x000739AC
		public string Label
		{
			get
			{
				short num = (short)525664256;
				short num2 = num;
				num = (short)1269301249;
				if (num != 0)
				{
				}
				num = (short)609029418;
				short num3 = num;
				num = (short)519245098;
				switch (num3 == num)
				{
				}
				num = (short)328990720;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector.LabelProperty);
			}
			set
			{
				short num = (short)582549504;
				short num2 = num;
				num = (short)459503009;
				short num3 = num;
				num = (short)1273263521;
				switch (num3 == num)
				{
				}
				num = (short)8388609;
				if (num != 0)
				{
				}
				num = (short)114556928;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector.LabelProperty, value);
			}
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00075864 File Offset: 0x00073A64
		private static void SetLabel(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			while (A_1.NewValue == null)
			{
				short num = (short)1652148580;
				short num2 = num;
				num = (short)510904676;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1930100736;
					if (num != 0)
					{
					}
					num = (short)1869414401;
					if (num != 0)
					{
					}
					num = (short)1189675008;
					short num3 = num;
					return;
				}
				}
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector pathSelector = (global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector)A_0;
			pathSelector.tb.Content = (string)A_1.NewValue;
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x0007593C File Offset: 0x00073B3C
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x000759F4 File Offset: 0x00073BF4
		public global::System.Windows.Input.ICommand Command
		{
			get
			{
				short num = (short)1356791808;
				short num2 = num;
				num = (short)398942744;
				short num3 = num;
				num = (short)1472422424;
				switch (num3 == num)
				{
				}
				num = (short)1586495489;
				if (num != 0)
				{
				}
				num = (short)1891893248;
				if (num != 0)
				{
				}
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector.CommandProperty);
			}
			set
			{
				short num = (short)85000192;
				short num2 = num;
				num = (short)1495501523;
				short num3 = num;
				num = (short)1942784723;
				switch (num3 == num)
				{
				}
				num = (short)243138561;
				if (num != 0)
				{
				}
				num = (short)1995964416;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector.CommandProperty, value);
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00075AA8 File Offset: 0x00073CA8
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x00075B60 File Offset: 0x00073D60
		public object CommandParameter
		{
			get
			{
				short num = (short)1709506560;
				short num2 = num;
				num = (short)1527644161;
				if (num != 0)
				{
				}
				num = (short)176836877;
				short num3 = num;
				num = (short)602820877;
				switch (num3 == num)
				{
				}
				num = (short)1408630784;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector.CommandParameterProperty);
			}
			set
			{
				short num = (short)82903040;
				short num2 = num;
				num = (short)1362100225;
				if (num != 0)
				{
				}
				num = (short)480976825;
				short num3 = num;
				num = (short)423567289;
				switch (num3 == num)
				{
				}
				num = (short)703856640;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector.CommandParameterProperty, value);
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00075C14 File Offset: 0x00073E14
		private void Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1819607040;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)858259457;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				case 1:
					this.Command.Execute((A_0 as global::System.Windows.Controls.Button).Content);
					goto IL_91;
				case 2:
				{
					num = (short)955733149;
					short num3 = num;
					num = (short)1123374237;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_91;
					default:
						goto IL_DC;
					}
					break;
				}
				}
				IL_59:
				if (this.Command != null)
				{
					num = (short)1767636993;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_91:
				num = (short)215613442;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_DC:
			num = (short)615579648;
			if (num != 0)
			{
			}
			num = (short)1506869248;
			short num4 = num;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00075D3C File Offset: 0x00073F3C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 4;
			while (this._contentLoaded)
			{
				short num = (short)2034967806;
				short num2 = num;
				num = (short)1619404030;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)567017473;
					if (num != 0)
					{
					}
					num = (short)379125760;
					if (num != 0)
					{
					}
					num = (short)749404160;
					short num3 = num;
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("뎛펝쾟횡쮣풥잧용춫肭\uddb1\ud9b3\udbb5ힷ풹ﾻ鎿雃Ʂ곇ꏉꏋ菍뇏병뗓뇕뷗럙맛냝铟쳡꟣觥蛧黩黫臭鳯臱쿳闵韷韹賻釽滿朁樃爅✇缉缋欍戏焑笓砕気栙猛爝匟ഡ吣䜥尧䈩弫䬭尯圱圳䈵圷䠹ሻ䘽ℿ⽁⡃", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00075E1C File Offset: 0x0007401C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			while (connectionId == 1)
			{
				short num = (short)953152645;
				short num2 = num;
				num = (short)1352135813;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)413794304;
					if (num != 0)
					{
					}
					num = (short)49676289;
					if (num != 0)
					{
					}
					num = (short)1794375680;
					short num3 = num;
					this.tb = (global::System.Windows.Controls.Button)target;
					return;
				}
				}
			}
			this._contentLoaded = true;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00075EE0 File Offset: 0x000740E0
		// Note: this type is marked as 'beforefieldinit'.
		static PathSelector()
		{
			int a_ = 9;
			short num = (short)1811611648;
			short num2 = num;
			num = (short)1789722625;
			if (num != 0)
			{
			}
			num = (short)760694269;
			short num3 = num;
			num = (short)1633437181;
			switch (num3 == num)
			{
			}
			num = (short)907345920;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector.LabelProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("슢잤슦얨", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector.SetLabel)));
			global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector.CommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첢좤쪦좨얪즬", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector.CommandParameterProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첢좤쪦좨얪즬ﾮ킰솲풴\udab6\udcb8쾺\ud8bc춾", a_), typeof(object), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x04000360 RID: 864
		public static readonly global::System.Windows.DependencyProperty LabelProperty;

		// Token: 0x04000361 RID: 865
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x04000362 RID: 866
		public static readonly global::System.Windows.DependencyProperty CommandParameterProperty;

		// Token: 0x04000363 RID: 867
		internal global::System.Windows.Controls.Button tb;

		// Token: 0x04000364 RID: 868
		private bool _contentLoaded;
	}
}
