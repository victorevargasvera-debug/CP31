using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Controls.Maps
{
	// Token: 0x02000062 RID: 98
	public class DesignServices
	{
		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x000168D0 File Offset: 0x00014AD0
		public static bool IsInDesignModeStatic
		{
			get
			{
				if (global::Infragistics.Controls.Maps.DesignServices._isInDesignMode == null)
				{
					global::System.Windows.DependencyProperty isInDesignModeProperty = global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty;
					global::Infragistics.Controls.Maps.DesignServices._isInDesignMode = new bool?((bool)global::System.ComponentModel.DependencyPropertyDescriptor.FromProperty(isInDesignModeProperty, typeof(global::System.Windows.FrameworkElement)).Metadata.DefaultValue);
				}
				return global::Infragistics.Controls.Maps.DesignServices._isInDesignMode.Value;
			}
		}

		// Token: 0x04000260 RID: 608
		private static bool? _isInDesignMode;
	}
}
