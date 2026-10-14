using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000028 RID: 40
	public class ConditionalFormattingSettings : global::Infragistics.Controls.Grids.SettingsBase
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000A9F7 File Offset: 0x00008BF7
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x0000AA09 File Offset: 0x00008C09
		public bool AllowConditionalFormatting
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.ConditionalFormattingSettings.AllowConditionalFormattingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ConditionalFormattingSettings.AllowConditionalFormattingProperty, value);
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000AA1C File Offset: 0x00008C1C
		private static void AllowConditionalFormattingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ConditionalFormattingSettings conditionalFormattingSettings = (global::Infragistics.Controls.Grids.ConditionalFormattingSettings)obj;
			if ((bool)e.NewValue)
			{
				global::System.Windows.Style style = new global::System.Windows.Style();
				global::System.Reflection.FieldInfo[] fields = typeof(global::System.Windows.Controls.ContentControl).GetFields(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.FlattenHierarchy);
				global::Infragistics.Controls.Grids.CellControl obj2 = new global::Infragistics.Controls.Grids.CellControl();
				foreach (global::System.Reflection.FieldInfo fieldInfo in fields)
				{
					if (fieldInfo.FieldType == typeof(global::System.Windows.DependencyProperty))
					{
						try
						{
							global::System.Windows.DependencyProperty dependencyProperty = (global::System.Windows.DependencyProperty)fieldInfo.GetValue(obj2);
							if (!dependencyProperty.ReadOnly)
							{
								style.Setters.Add(new global::System.Windows.Setter(dependencyProperty, null));
							}
						}
						catch (global::System.Exception)
						{
						}
					}
				}
			}
			conditionalFormattingSettings.OnPropertyChanged("AllowConditionalFormatting");
		}

		// Token: 0x0400007C RID: 124
		public static readonly global::System.Windows.DependencyProperty AllowConditionalFormattingProperty = global::System.Windows.DependencyProperty.Register("AllowConditionalFormatting", typeof(bool), typeof(global::Infragistics.Controls.Grids.ConditionalFormattingSettings), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ConditionalFormattingSettings.AllowConditionalFormattingChanged)));
	}
}
