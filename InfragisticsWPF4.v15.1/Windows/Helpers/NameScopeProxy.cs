using System;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x02000198 RID: 408
	public abstract class NameScopeProxy : global::System.Windows.Markup.INameScope
	{
		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000DA8 RID: 3496
		protected abstract global::System.Windows.DependencyObject StartingElement { get; }

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0002CCF0 File Offset: 0x0002AEF0
		private global::System.Windows.Markup.INameScope GetNameScope()
		{
			for (global::System.Windows.DependencyObject dependencyObject = this.StartingElement; dependencyObject != null; dependencyObject = (global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject) ?? global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject)))
			{
				global::System.Windows.Markup.INameScope nameScope = global::System.Windows.NameScope.GetNameScope(dependencyObject);
				if (nameScope != null)
				{
					return nameScope;
				}
			}
			return null;
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0002CD28 File Offset: 0x0002AF28
		object global::System.Windows.Markup.INameScope.FindName(string name)
		{
			global::System.Windows.Markup.INameScope nameScope = this.GetNameScope();
			if (nameScope == null)
			{
				return null;
			}
			return nameScope.FindName(name);
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x0002CD48 File Offset: 0x0002AF48
		void global::System.Windows.Markup.INameScope.RegisterName(string name, object scopedElement)
		{
			global::System.Windows.Markup.INameScope nameScope = this.GetNameScope();
			if (nameScope != null)
			{
				nameScope.RegisterName(name, scopedElement);
			}
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0002CD68 File Offset: 0x0002AF68
		void global::System.Windows.Markup.INameScope.UnregisterName(string name)
		{
			global::System.Windows.Markup.INameScope nameScope = this.GetNameScope();
			if (nameScope != null)
			{
				nameScope.UnregisterName(name);
			}
		}
	}
}
