using System;
using System.Windows;
using System.Windows.Controls;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000121 RID: 289
	public class RMTabItem : global::System.Windows.Controls.TabItem
	{
		// Token: 0x06000920 RID: 2336 RVA: 0x00096F7C File Offset: 0x0009517C
		static RMTabItem()
		{
			int a_ = 2;
			short num = (short)737990451;
			short num2 = num;
			num = (short)1562695475;
			switch (num2 == num)
			{
			}
			num = (short)1186004993;
			if (num != 0)
			{
			}
			num = (short)29032448;
			short num3 = num;
			num = (short)398852096;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem.HeaderStyleProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("튙鍊ﾝ쒟잡횣\udca7펩삫쮭", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMTabHeaderStyle), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem.IconProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("펙ﾛ캟", a_), typeof(global::System.Windows.FrameworkElement), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem)));
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x000970A8 File Offset: 0x000952A8
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x00097160 File Offset: 0x00095360
		public global::Motorola.CommonCPS.RadioManagement.Controls.RMTabHeaderStyle HeaderStyle
		{
			get
			{
				short num = (short)746806819;
				short num2 = num;
				num = (short)853302819;
				switch (num2 == num)
				{
				}
				num = (short)1850408961;
				if (num != 0)
				{
				}
				num = (short)1938423808;
				short num3 = num;
				num = (short)281739264;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.Controls.RMTabHeaderStyle)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem.HeaderStyleProperty);
			}
			set
			{
				short num = (short)1916724320;
				short num2 = num;
				num = (short)1963254880;
				switch (num2 == num)
				{
				}
				num = (short)1078329344;
				if (num != 0)
				{
				}
				num = (short)222822400;
				short num3 = num;
				num = (short)1291190273;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem.HeaderStyleProperty, value);
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x0009721C File Offset: 0x0009541C
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x000972D8 File Offset: 0x000954D8
		public global::System.Windows.FrameworkElement Icon
		{
			get
			{
				short num = (short)21507792;
				short num2 = num;
				num = (short)2091658960;
				switch (num2 == num)
				{
				}
				num = (short)1029373953;
				if (num != 0)
				{
				}
				num = (short)1655701504;
				short num3 = num;
				num = (short)333578240;
				if (num != 0)
				{
				}
				return (global::System.Windows.FrameworkElement)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem.IconProperty);
			}
			set
			{
				short num = (short)563297641;
				short num2 = num;
				num = (short)1074937193;
				switch (num2 == num)
				{
				}
				num = (short)828047361;
				if (num != 0)
				{
				}
				num = (short)687013888;
				short num3 = num;
				num = (short)1651703808;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTabItem.IconProperty, value);
			}
		}

		// Token: 0x0400043D RID: 1085
		public static readonly global::System.Windows.DependencyProperty HeaderStyleProperty;

		// Token: 0x0400043E RID: 1086
		public static readonly global::System.Windows.DependencyProperty IconProperty;
	}
}
