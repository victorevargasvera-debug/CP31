using System;
using System.Windows;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000024 RID: 36
	public abstract class NodeLayoutBase : global::Infragistics.DependencyObjectNotifier
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000059BE File Offset: 0x00003BBE
		// (set) Token: 0x0600010B RID: 267 RVA: 0x000059D0 File Offset: 0x00003BD0
		public string Key
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Menus.NodeLayoutBase.KeyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.NodeLayoutBase.KeyProperty, value);
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000059E0 File Offset: 0x00003BE0
		private static void KeyChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.NodeLayoutBase nodeLayoutBase = (global::Infragistics.Controls.Menus.NodeLayoutBase)obj;
			nodeLayoutBase.OnKeyChanged();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000059FA File Offset: 0x00003BFA
		protected virtual void OnKeyChanged()
		{
		}

		// Token: 0x0400004D RID: 77
		public static readonly global::System.Windows.DependencyProperty KeyProperty = global::System.Windows.DependencyProperty.Register("Key", typeof(string), typeof(global::Infragistics.Controls.Menus.NodeLayout), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.NodeLayoutBase.KeyChanged)));
	}
}
