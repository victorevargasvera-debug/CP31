using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000076 RID: 118
	public class PushBinding : global::Motorola.CommonCPS.RadioManagement.Controls.FreezableBinding
	{
		// Token: 0x0600029D RID: 669 RVA: 0x0002B604 File Offset: 0x00029804
		private static void OnTargetPropertyListenerChanged(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)727018055;
			short num2 = num;
			num = (short)1524132423;
			switch (num2 == num)
			{
			}
			num = (short)1893269504;
			if (num != 0)
			{
			}
			num = (short)1247477760;
			short num3 = num;
			num = (short)1500053505;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding pushBinding = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding;
			pushBinding.a();
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0002B6BC File Offset: 0x000298BC
		public PushBinding()
		{
			base.Mode = global::System.Windows.Data.BindingMode.OneWayToSource;
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0002B6D8 File Offset: 0x000298D8
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x0002B790 File Offset: 0x00029990
		public object TargetPropertyMirror
		{
			get
			{
				short num = (short)1772287602;
				short num2 = num;
				num = (short)1006237298;
				switch (num2 == num)
				{
				}
				num = (short)1674182656;
				if (num != 0)
				{
				}
				num = (short)1265565696;
				short num3 = num;
				num = (short)2087321601;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding.TargetPropertyMirrorProperty);
			}
			set
			{
				short num = (short)707303063;
				short num2 = num;
				num = (short)2115475095;
				switch (num2 == num)
				{
				}
				num = (short)1757151233;
				if (num != 0)
				{
				}
				num = (short)276299776;
				short num3 = num;
				num = (short)297140224;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding.TargetPropertyMirrorProperty, value);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0002B848 File Offset: 0x00029A48
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x0002B8FC File Offset: 0x00029AFC
		public object TargetPropertyListener
		{
			get
			{
				short num = (short)1936411550;
				short num2 = num;
				num = (short)171133854;
				switch (num2 == num)
				{
				}
				num = (short)1483603968;
				if (num != 0)
				{
				}
				num = (short)165871616;
				short num3 = num;
				num = (short)251396097;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding.TargetPropertyListenerProperty);
			}
			set
			{
				short num = (short)487294894;
				short num2 = num;
				num = (short)895125422;
				switch (num2 == num)
				{
				}
				num = (short)976683009;
				if (num != 0)
				{
				}
				num = (short)1017053184;
				short num3 = num;
				num = (short)713097216;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding.TargetPropertyListenerProperty, value);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0002B9B4 File Offset: 0x00029BB4
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x0002BA64 File Offset: 0x00029C64
		[global::System.ComponentModel.DefaultValue(null)]
		public string TargetProperty
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)430118622;
				short num2 = num;
				num = (short)1105860318;
				switch (num2 == num)
				{
				}
				num = (short)848101376;
				if (num != 0)
				{
				}
				num = (short)1700069376;
				short num3 = num;
				num = (short)1770979329;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)200353101;
				short num2 = num;
				num = (short)1987323213;
				switch (num2 == num)
				{
				}
				num = (short)1254096897;
				if (num != 0)
				{
				}
				num = (short)1434058752;
				short num3 = num;
				num = (short)779681792;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0002BB18 File Offset: 0x00029D18
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x0002BBCC File Offset: 0x00029DCC
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.DependencyProperty TargetDependencyProperty
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1373475095;
				short num2 = num;
				num = (short)1032491287;
				switch (num2 == num)
				{
				}
				num = (short)492109825;
				if (num != 0)
				{
				}
				num = (short)905838592;
				short num3 = num;
				num = (short)1491730432;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)801795875;
				short num2 = num;
				num = (short)1325887267;
				switch (num2 == num)
				{
				}
				num = (short)1816985600;
				if (num != 0)
				{
				}
				num = (short)301268992;
				short num3 = num;
				num = (short)965476353;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0002BC7C File Offset: 0x00029E7C
		public void SetupTargetBinding(global::System.Windows.DependencyObject targetObject)
		{
			short num = (short)162136072;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Data.Binding binding;
				switch (num2)
				{
				case 0:
					binding.Path = new global::System.Windows.PropertyPath(this.TargetDependencyProperty);
					num = (short)1082523654;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					((global::System.Windows.FrameworkContentElement)targetObject).Loaded += this.a;
					num = (short)534315008;
					short num3 = num;
					num = (short)398131202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_1F2;
				case 3:
					if (targetObject is global::System.Windows.FrameworkContentElement)
					{
						num = (short)641204225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					return;
				case 5:
					if (targetObject is global::System.Windows.FrameworkElement)
					{
						num = (short)800456714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1360134147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_137;
				case 7:
					if (this.TargetDependencyProperty != null)
					{
						num = (short)1091895296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					binding.Path = new global::System.Windows.PropertyPath(this.TargetProperty, global::System.Array.Empty<object>());
					num = (short)1101856780;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 9:
					goto IL_F5;
				case 10:
					goto IL_195;
				case 11:
				{
					if (global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
					{
						num = (short)1669005321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					binding = new global::System.Windows.Data.Binding
					{
						Source = targetObject,
						Mode = global::System.Windows.Data.BindingMode.OneWay
					};
					num = (short)1375216674;
					short num4 = num;
					num = (short)984294434;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)240254977;
						if (num != 0)
						{
						}
						num = (short)17301504;
						if (num != 0)
						{
						}
						num = (short)1551958023;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 12:
					goto IL_137;
				}
				IL_58:
				if (targetObject == null)
				{
					num = (short)227475460;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1793589259;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_137:
				global::System.Windows.Data.BindingOperations.SetBinding(this, global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding.TargetPropertyListenerProperty, binding);
				global::System.Windows.Data.BindingOperations.SetBinding(this, global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding.TargetPropertyMirrorProperty, base.Binding);
				this.a();
				num = (short)1746010117;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_F5:
			return;
			IL_195:
			((global::System.Windows.FrameworkElement)targetObject).Loaded += this.b;
			return;
			IL_1F2:;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0002BF74 File Offset: 0x0002A174
		private void a()
		{
			short num = (short)722369879;
			short num2 = num;
			num = (short)1023442263;
			switch (num2 == num)
			{
			}
			num = (short)1514274816;
			if (num != 0)
			{
			}
			num = (short)670171136;
			short num3 = num;
			num = (short)666894337;
			if (num != 0)
			{
			}
			object value = base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding.TargetPropertyListenerProperty);
			base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding.TargetPropertyMirrorProperty, value);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0002C034 File Offset: 0x0002A234
		protected override void CloneCore(global::System.Windows.Freezable sourceFreezable)
		{
			short num = (short)656786256;
			short num2 = num;
			num = (short)1891353424;
			switch (num2 == num)
			{
			}
			num = (short)399835137;
			if (num != 0)
			{
			}
			num = (short)2004090880;
			short num3 = num;
			num = (short)174915584;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding pushBinding = sourceFreezable as global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding;
			this.TargetProperty = pushBinding.TargetProperty;
			this.TargetDependencyProperty = pushBinding.TargetDependencyProperty;
			base.CloneCore(sourceFreezable);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0002C100 File Offset: 0x0002A300
		protected override global::System.Windows.Freezable CreateInstanceCore()
		{
			short num = (short)413777283;
			short num2 = num;
			num = (short)305184131;
			switch (num2 == num)
			{
			}
			num = (short)920977409;
			if (num != 0)
			{
			}
			num = (short)775290880;
			short num3 = num;
			num = (short)1377501184;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding();
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0002C1B0 File Offset: 0x0002A3B0
		// Note: this type is marked as 'beforefieldinit'.
		static PushBinding()
		{
			int a_ = 4;
			short num = (short)1745354752;
			short num2 = num;
			num = (short)1496371910;
			short num3 = num;
			num = (short)570938054;
			switch (num3 == num)
			{
			}
			num = (short)1397424128;
			if (num != 0)
			{
			}
			num = (short)356777985;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding.TargetPropertyMirrorProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좛ﾝ튟얡솣튥\ud8a9쎫\udead햯삱삳쾵펹캻첽꾿냁", a_), typeof(object), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding));
			global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding.TargetPropertyListenerProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좛ﾝ튟얡솣튥\ud8a9쎫\udead햯삱삳쾵펹쾻쪽ꖿ곁ꇃ듅", a_), typeof(object), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding.OnTargetPropertyListenerChanged)));
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0002C2CC File Offset: 0x0002A4CC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1092091904;
			short num2 = num;
			num = (short)1533205442;
			short num3 = num;
			num = (short)994761666;
			switch (num3 == num)
			{
			}
			num = (short)956039169;
			if (num != 0)
			{
			}
			num = (short)1647771648;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0002C37C File Offset: 0x0002A57C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1667235840;
			short num2 = num;
			num = (short)28826263;
			short num3 = num;
			num = (short)287758999;
			switch (num3 == num)
			{
			}
			num = (short)1482162177;
			if (num != 0)
			{
			}
			num = (short)1482752000;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x040000BB RID: 187
		public static global::System.Windows.DependencyProperty TargetPropertyMirrorProperty;

		// Token: 0x040000BC RID: 188
		public static global::System.Windows.DependencyProperty TargetPropertyListenerProperty;

		// Token: 0x040000BD RID: 189
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x040000BE RID: 190
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.DependencyProperty b;
	}
}
