using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000082 RID: 130
	public class RMFieldEditor : global::System.Windows.Controls.UserControl
	{
		// Token: 0x06000305 RID: 773 RVA: 0x000316E8 File Offset: 0x0002F8E8
		public RMFieldEditor()
		{
			this.b();
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00031704 File Offset: 0x0002F904
		// (set) Token: 0x06000307 RID: 775 RVA: 0x000317C0 File Offset: 0x0002F9C0
		public string EditableIn
		{
			get
			{
				short num = (short)991494144;
				short num2 = num;
				num = (short)349397429;
				short num3 = num;
				num = (short)2131255733;
				switch (num3 == num)
				{
				}
				num = (short)87556097;
				if (num != 0)
				{
				}
				num = (short)1805516800;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.EditableInProperty);
			}
			set
			{
				short num = (short)1363804160;
				short num2 = num;
				num = (short)632939402;
				short num3 = num;
				num = (short)1717363594;
				switch (num3 == num)
				{
				}
				num = (short)1183580161;
				if (num != 0)
				{
				}
				num = (short)956301312;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.EditableInProperty, value);
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00031878 File Offset: 0x0002FA78
		// (set) Token: 0x06000309 RID: 777 RVA: 0x00031930 File Offset: 0x0002FB30
		public bool IsEditable
		{
			get
			{
				short num = (short)867172352;
				short num2 = num;
				num = (short)697744229;
				short num3 = num;
				num = (short)2145893221;
				switch (num3 == num)
				{
				}
				num = (short)2059010049;
				if (num != 0)
				{
				}
				num = (short)636485632;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.IsEditableProperty);
			}
			set
			{
				short num = (short)1903296512;
				short num2 = num;
				num = (short)1314455553;
				if (num != 0)
				{
				}
				num = (short)991449441;
				short num3 = num;
				num = (short)1397379425;
				switch (num3 == num)
				{
				}
				num = (short)498860032;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.IsEditableProperty, value);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600030A RID: 778 RVA: 0x000319EC File Offset: 0x0002FBEC
		// (set) Token: 0x0600030B RID: 779 RVA: 0x00031AA8 File Offset: 0x0002FCA8
		public bool IsValid
		{
			get
			{
				short num = (short)1096941568;
				short num2 = num;
				num = (short)702096210;
				short num3 = num;
				num = (short)25961298;
				switch (num3 == num)
				{
				}
				num = (short)2115239937;
				if (num != 0)
				{
				}
				num = (short)283508736;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.IsValidProperty);
			}
			set
			{
				short num = (short)346161152;
				short num2 = num;
				num = (short)1026559089;
				short num3 = num;
				num = (short)747637873;
				switch (num3 == num)
				{
				}
				num = (short)742457344;
				if (num != 0)
				{
				}
				num = (short)129368065;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.IsValidProperty, value);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600030C RID: 780 RVA: 0x00031B64 File Offset: 0x0002FD64
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00031C20 File Offset: 0x0002FE20
		public new bool IsVisible
		{
			get
			{
				short num = (short)1223098368;
				short num2 = num;
				num = (short)39298964;
				short num3 = num;
				num = (short)279226260;
				switch (num3 == num)
				{
				}
				num = (short)212467713;
				if (num != 0)
				{
				}
				num = (short)518455296;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.IsVisibleProperty);
			}
			set
			{
				short num = (short)1635123200;
				short num2 = num;
				num = (short)930947148;
				short num3 = num;
				num = (short)1276977228;
				switch (num3 == num)
				{
				}
				num = (short)713555969;
				if (num != 0)
				{
				}
				num = (short)101580800;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.IsVisibleProperty, value);
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00031CDC File Offset: 0x0002FEDC
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1671757824;
			short num2 = num;
			num = (short)2010874414;
			short num3 = num;
			num = (short)1544258094;
			switch (num3 == num)
			{
			}
			num = (short)256573441;
			if (num != 0)
			{
			}
			num = (short)318111744;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor = (global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor)A_0;
			rmfieldEditor.Visibility = (((bool)A_1.NewValue) ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Collapsed);
			rmfieldEditor.a();
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00031DB0 File Offset: 0x0002FFB0
		// (set) Token: 0x06000310 RID: 784 RVA: 0x00031E6C File Offset: 0x0003006C
		public string Label
		{
			get
			{
				short num = (short)1413414912;
				short num2 = num;
				num = (short)234881025;
				if (num != 0)
				{
				}
				num = (short)1424939227;
				short num3 = num;
				num = (short)83220699;
				switch (num3 == num)
				{
				}
				num = (short)1410727936;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.LabelProperty);
			}
			set
			{
				short num = (short)1648164864;
				short num2 = num;
				num = (short)1747706233;
				short num3 = num;
				num = (short)354476409;
				switch (num3 == num)
				{
				}
				num = (short)1423114241;
				if (num != 0)
				{
				}
				num = (short)61865984;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.LabelProperty, value);
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00031F20 File Offset: 0x00030120
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)97976320;
			short num2 = num;
			num = (short)1911119329;
			short num3 = num;
			num = (short)692280801;
			switch (num3 == num)
			{
			}
			num = (short)1180958720;
			if (num != 0)
			{
			}
			num = (short)2125201409;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor = (global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor)A_0;
			rmfieldEditor.LabelChanged(rmfieldEditor);
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00031FD8 File Offset: 0x000301D8
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00032090 File Offset: 0x00030290
		public string VisibleIn
		{
			get
			{
				short num = (short)1317928960;
				short num2 = num;
				num = (short)612019317;
				short num3 = num;
				num = (short)1921231989;
				switch (num3 == num)
				{
				}
				num = (short)1267924992;
				if (num != 0)
				{
				}
				num = (short)691798017;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.VisibleInProperty);
			}
			set
			{
				short num = (short)1126039552;
				short num2 = num;
				num = (short)108060296;
				short num3 = num;
				num = (short)1481105032;
				switch (num3 == num)
				{
				}
				num = (short)1686241281;
				if (num != 0)
				{
				}
				num = (short)1286733824;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.VisibleInProperty, value);
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00032148 File Offset: 0x00030348
		public virtual void SetFocus()
		{
			short num = (short)377487360;
			short num2 = num;
			num = (short)1076006041;
			short num3 = num;
			num = (short)1087212697;
			switch (num3 == num)
			{
			}
			num = (short)171638785;
			if (num != 0)
			{
			}
			num = (short)1987772416;
			if (num != 0)
			{
			}
			base.Focus();
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000321FC File Offset: 0x000303FC
		protected void SetControlID(global::System.Windows.DependencyProperty dependencyProperty, global::System.Windows.FrameworkElement control)
		{
			int a_ = 17;
			global::System.Windows.Data.Binding binding = global::System.Windows.Data.BindingOperations.GetBinding(this, dependencyProperty);
			short num;
			if (binding == null)
			{
				for (;;)
				{
					num = (short)761921537;
					if (num != 0)
					{
					}
					num = (short)212168226;
					short num2 = num;
					num = (short)1187409442;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_71;
					}
				}
				IL_71:
				num = (short)508166144;
				if (num != 0)
				{
				}
				return;
			}
			num = (short)302907392;
			short num3 = num;
			control.Name = binding.Path.Path.Replace(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("슪좬쎮햰삲", a_), string.Empty).Replace(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("", a_), string.Empty);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x000322FC File Offset: 0x000304FC
		protected virtual void SetDefaultBindings()
		{
			int a_ = 12;
			short num = (short)829095936;
			short num2 = num;
			num = (short)456989241;
			short num3 = num;
			num = (short)2033588793;
			switch (num3 == num)
			{
			}
			num = (short)1909129216;
			if (num != 0)
			{
			}
			num = (short)101908481;
			if (num != 0)
			{
			}
			base.SetBinding(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.IsValidProperty, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("향ﺧ쮩삫잭풯", a_));
			base.SetBinding(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.IsVisibleProperty, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("향ﺧ쎩\udfab잭튯\udeb1톳", a_));
			base.SetBinding(global::System.Windows.UIElement.IsEnabledProperty, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("향\udaa9\udcab슭\ud9af톱햳풵풷\udfb9", a_));
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00032400 File Offset: 0x00030600
		public virtual void LabelChanged(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor fieldEditor)
		{
			short num = (short)1918107648;
			short num2 = num;
			num = (short)331463804;
			short num3 = num;
			num = (short)1132051580;
			switch (num3 == num)
			{
			}
			num = (short)553451521;
			if (num != 0)
			{
			}
			num = (short)1202716672;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x000324A8 File Offset: 0x000306A8
		protected void AlignMainGridMaxWithEditor(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor editor, global::System.Windows.Controls.Grid grdMain)
		{
			int a_ = 10;
			short num = (short)1430978560;
			short num2 = num;
			num = (short)685703169;
			if (num != 0)
			{
			}
			num = (short)786339582;
			short num3 = num;
			num = (short)1598592766;
			switch (num3 == num)
			{
			}
			num = (short)860422144;
			if (num != 0)
			{
			}
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("잣튥\udda7쮩삫玲\ud9af횱삳\udeb5", a_));
			binding.Source = editor;
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			grdMain.SetBinding(global::System.Windows.FrameworkElement.MaxWidthProperty, binding);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00032584 File Offset: 0x00030784
		private void b()
		{
			short num = (short)1073872896;
			short num2 = num;
			num = (short)1407088481;
			short num3 = num;
			num = (short)1487828833;
			switch (num3 == num)
			{
			}
			num = (short)1656750081;
			if (num != 0)
			{
			}
			num = (short)1410007040;
			if (num != 0)
			{
			}
			base.DataContextChanged += this.a;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00032640 File Offset: 0x00030840
		private void a()
		{
			short num = (short)566831655;
			short num2 = num;
			num = (short)443427367;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_9B:
				num = (short)1688076289;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1250820096;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				break;
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.NullField nullField;
			for (;;)
			{
				switch (num3)
				{
				case 0:
					base.Visibility = global::System.Windows.Visibility.Collapsed;
					num = (short)1163853826;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (nullField != null)
					{
						num = (short)58130432;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					goto IL_E9;
				}
				goto IL_66;
			}
			IL_E9:
			num = (short)952827905;
			if (num != 0)
			{
			}
			return;
			IL_66:
			num = (short)606535680;
			short num4 = num;
			nullField = (base.DataContext as global::Motorola.CommonCPS.RadioManagement.UIModels.NullField);
			goto IL_9B;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00032764 File Offset: 0x00030964
		// Note: this type is marked as 'beforefieldinit'.
		static RMFieldEditor()
		{
			int a_ = 2;
			short num = (short)1532362752;
			short num2 = num;
			num = (short)491800424;
			short num3 = num;
			num = (short)244008808;
			switch (num3 == num)
			{
			}
			num = (short)1241186304;
			if (num != 0)
			{
			}
			num = (short)1597308929;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.EditableInProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udf99풟쎡욣쪥춧슫", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.IsEditableProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("펙\udb9d쒟쮡킣장쪧용즫", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.IsValidProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("펙좝솟캡춣슥", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.IsVisibleProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("펙좝즟톡춣쒥쒧쾩", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.b)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.LabelProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("횙ﶛﲝ얟캡", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.a)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.VisibleInProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("척즟삡좣쎥쒩", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null));
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00032964 File Offset: 0x00030B64
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)2029649920;
			short num2 = num;
			num = (short)463744830;
			short num3 = num;
			num = (short)918826814;
			switch (num3 == num)
			{
			}
			num = (short)1300234241;
			if (num != 0)
			{
			}
			num = (short)1265565696;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x040000F8 RID: 248
		public static readonly global::System.Windows.DependencyProperty EditableInProperty;

		// Token: 0x040000F9 RID: 249
		public static readonly global::System.Windows.DependencyProperty IsEditableProperty;

		// Token: 0x040000FA RID: 250
		public static readonly global::System.Windows.DependencyProperty IsValidProperty;

		// Token: 0x040000FB RID: 251
		public new static readonly global::System.Windows.DependencyProperty IsVisibleProperty;

		// Token: 0x040000FC RID: 252
		public static readonly global::System.Windows.DependencyProperty LabelProperty;

		// Token: 0x040000FD RID: 253
		public static readonly global::System.Windows.DependencyProperty VisibleInProperty;
	}
}
