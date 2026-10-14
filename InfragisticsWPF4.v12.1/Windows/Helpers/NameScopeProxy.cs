using System;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x02000176 RID: 374
	public abstract class NameScopeProxy : global::System.Windows.Markup.INameScope
	{
		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000C93 RID: 3219
		protected abstract global::System.Windows.DependencyObject StartingElement { get; }

		// Token: 0x06000C94 RID: 3220 RVA: 0x00028B68 File Offset: 0x00026D68
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

		// Token: 0x06000C95 RID: 3221 RVA: 0x00028BA0 File Offset: 0x00026DA0
		object global::System.Windows.Markup.INameScope.FindName(string name)
		{
			global::System.Windows.Markup.INameScope nameScope = this.GetNameScope();
			if (nameScope == null)
			{
				return null;
			}
			return nameScope.FindName(name);
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00028BC0 File Offset: 0x00026DC0
		void global::System.Windows.Markup.INameScope.RegisterName(string name, object scopedElement)
		{
			global::System.Windows.Markup.INameScope nameScope = this.GetNameScope();
			if (nameScope != null)
			{
				nameScope.RegisterName(name, scopedElement);
			}
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00028BE0 File Offset: 0x00026DE0
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
