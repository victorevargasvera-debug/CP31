using System;
using System.Windows;
using System.Windows.Controls;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200011F RID: 287
	public class RMLinkButton : global::System.Windows.Controls.Button
	{
		// Token: 0x06000916 RID: 2326 RVA: 0x00096768 File Offset: 0x00094968
		static RMLinkButton()
		{
			int a_ = 7;
			short num = (short)428212225;
			if (num != 0)
			{
			}
			num = (short)1224333416;
			short num2 = num;
			num = (short)1267062888;
			switch (num2 == num)
			{
			}
			num = (short)540868608;
			short num3 = num;
			num = (short)815005696;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton.RMLinkFieldEditorProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춞첤즦슨쒬쪮\uddb0ힲ펶킸쾺튼춾", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkFieldEditor), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton.a)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton.IsRMLinkFieldEditorProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("횞튠삨얪욬\ud8b0횲\ud9b4펶ﲸ\udfba풼쮾껀뇂", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton)));
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x000968B4 File Offset: 0x00094AB4
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x00096970 File Offset: 0x00094B70
		public global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkFieldEditor RMLinkFieldEditor
		{
			get
			{
				short num = (short)1178434000;
				short num2 = num;
				num = (short)200899024;
				switch (num2 == num)
				{
				}
				num = (short)1466695681;
				if (num != 0)
				{
				}
				num = (short)479068160;
				short num3 = num;
				num = (short)1238302720;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkFieldEditor)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton.RMLinkFieldEditorProperty);
			}
			set
			{
				short num = (short)1960518780;
				short num2 = num;
				num = (short)1284908156;
				switch (num2 == num)
				{
				}
				num = (short)1486880768;
				if (num != 0)
				{
				}
				num = (short)1546977280;
				short num3 = num;
				num = (short)1591738369;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton.RMLinkFieldEditorProperty, value);
			}
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00096A28 File Offset: 0x00094C28
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton rmlinkButton;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (A_1.NewValue != null)
					{
						num2 = (short)1391788034;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
				{
					rmlinkButton.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton.IsRMLinkFieldEditorProperty, true);
					num2 = (short)470782260;
					short num3 = num2;
					num2 = (short)1174442292;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3F;
					default:
					{
						num2 = (short)1360592897;
						if (num2 != 0)
						{
						}
						num2 = (short)1729757184;
						if (num2 != 0)
						{
						}
						num2 = (short)1045299200;
						short num4 = num2;
						num2 = (short)426967041;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 3:
					num2 = (short)1449066496;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_3F;
				}
				goto IL_24;
				IL_3F:
				if (rmlinkButton == null)
				{
					break;
				}
				num2 = (short)1294139395;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_24:
			rmlinkButton = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton);
			num2 = (short)1273298948;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x00096B98 File Offset: 0x00094D98
		public bool IsRMLinkFieldEditor
		{
			get
			{
				short num = (short)1577189452;
				short num2 = num;
				num = (short)2067136588;
				switch (num2 == num)
				{
				}
				num = (short)1608908801;
				if (num != 0)
				{
				}
				num = (short)1666580480;
				short num3 = num;
				num = (short)1919025152;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton.IsRMLinkFieldEditorProperty);
			}
		}

		// Token: 0x0400043B RID: 1083
		public static readonly global::System.Windows.DependencyProperty RMLinkFieldEditorProperty;

		// Token: 0x0400043C RID: 1084
		public static readonly global::System.Windows.DependencyProperty IsRMLinkFieldEditorProperty;
	}
}
