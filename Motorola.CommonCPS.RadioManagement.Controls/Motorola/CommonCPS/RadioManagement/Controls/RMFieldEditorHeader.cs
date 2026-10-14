using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000060 RID: 96
	public class RMFieldEditorHeader : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x060001F9 RID: 505 RVA: 0x00021258 File Offset: 0x0001F458
		static RMFieldEditorHeader()
		{
			int a_ = 3;
			short num = (short)1247105912;
			short num2 = num;
			num = (short)1284264824;
			switch (num2 == num)
			{
			}
			num = (short)1419575297;
			if (num != 0)
			{
			}
			num = (short)1001717760;
			if (num != 0)
			{
			}
			num = (short)920649728;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditorHeader.Header1Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("펚ﺞ얠욢힤隦", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditorHeader), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditorHeader.Header2Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("펚ﺞ얠욢힤閦", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditorHeader), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditorHeader), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditorHeader)));
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0002139C File Offset: 0x0001F59C
		public RMFieldEditorHeader()
		{
			base.Loaded += this.RMFieldEditorHeader_Loaded;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000213C4 File Offset: 0x0001F5C4
		private void RMFieldEditorHeader_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 1;
			short num = (short)911147008;
			short num2 = num;
			num = (short)949157888;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor> enumerable = global::Motorola.CommonCPS.RadioManagement.Controls.Utility.d<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor>(this);
				global::System.Windows.Data.MultiBinding multiBinding = new global::System.Windows.Data.MultiBinding
				{
					Converter = new global::Motorola.CommonCPS.RadioManagement.Controls.MultiFieldsIsVisibleConverter()
				};
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor> enumerator = enumerable.GetEnumerator();
				try
				{
					num = (short)894173186;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Windows.Data.Binding binding;
						switch (num3)
						{
						case 0:
						{
							if (enumerator.MoveNext())
							{
								global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor target = enumerator.Current;
								binding = global::System.Windows.Data.BindingOperations.GetBinding(target, global::System.Windows.FrameworkElement.DataContextProperty);
								num = (short)879624195;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)893079999;
							short num4 = num;
							num = (short)1818055103;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_FA;
							default:
								num = (short)1589116928;
								if (num != 0)
								{
								}
								num = (short)682688518;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_B4;
							}
							continue;
						case 3:
							if (binding != null)
							{
								num = (short)1674051589;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 4:
							goto IL_202;
						case 5:
							goto IL_FA;
						case 6:
							num = (short)591331332;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B4;
						IL_FA:
						multiBinding.Bindings.Add(new global::System.Windows.Data.Binding
						{
							Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ꮚ놞킢캦\udaa8슪쾬쎮풰", a_), binding.Path.Path), global::System.Array.Empty<object>())
						});
						num = (short)111935489;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_FF:
						num = (short)1643184128;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_B4:
						goto IL_FF;
					}
					IL_202:;
				}
				finally
				{
					num = (short)676593665;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1969029122;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_236;
							}
							continue;
						case 2:
							goto IL_26D;
						}
						IL_236:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1340211200;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_26D:;
				}
				num = (short)640417793;
				if (num != 0)
				{
				}
				base.SetBinding(global::System.Windows.UIElement.VisibilityProperty, multiBinding);
				return;
			}
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00021694 File Offset: 0x0001F894
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00021750 File Offset: 0x0001F950
		public string Header1
		{
			get
			{
				short num = (short)2001808599;
				short num2 = num;
				num = (short)2133208279;
				switch (num2 == num)
				{
				}
				num = (short)1646854145;
				if (num != 0)
				{
				}
				num = (short)1446117376;
				if (num != 0)
				{
				}
				num = (short)338165760;
				short num3 = num;
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditorHeader.Header1Property);
			}
			set
			{
				short num = (short)1114433887;
				short num2 = num;
				num = (short)311617887;
				switch (num2 == num)
				{
				}
				num = (short)2041184257;
				if (num != 0)
				{
				}
				num = (short)560070656;
				if (num != 0)
				{
				}
				num = (short)1589575680;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditorHeader.Header1Property, value);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00021804 File Offset: 0x0001FA04
		// (set) Token: 0x060001FF RID: 511 RVA: 0x000218C0 File Offset: 0x0001FAC0
		public string Header2
		{
			get
			{
				short num = (short)1761625873;
				short num2 = num;
				num = (short)860505873;
				switch (num2 == num)
				{
				}
				num = (short)210567169;
				if (num != 0)
				{
				}
				num = (short)520683520;
				if (num != 0)
				{
				}
				num = (short)1315569664;
				short num3 = num;
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditorHeader.Header2Property);
			}
			set
			{
				short num = (short)1815467192;
				short num2 = num;
				num = (short)589681848;
				switch (num2 == num)
				{
				}
				num = (short)1248657409;
				if (num != 0)
				{
				}
				num = (short)1519124480;
				if (num != 0)
				{
				}
				num = (short)284426240;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditorHeader.Header2Property, value);
			}
		}

		// Token: 0x0400008D RID: 141
		public static readonly global::System.Windows.DependencyProperty Header1Property;

		// Token: 0x0400008E RID: 142
		public static readonly global::System.Windows.DependencyProperty Header2Property;
	}
}
