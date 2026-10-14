using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x020000A3 RID: 163
	internal class GroupTempValueReplacement : global::System.IDisposable
	{
		// Token: 0x06000628 RID: 1576 RVA: 0x000169DC File Offset: 0x00014BDC
		internal GroupTempValueReplacement()
		{
			this._replacements = new global::System.Collections.Generic.List<global::Infragistics.Windows.Helpers.TempValueReplacement>();
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x000169EF File Offset: 0x00014BEF
		internal void Add(global::Infragistics.Windows.Helpers.TempValueReplacement replacement)
		{
			if (replacement == null)
			{
				throw new global::System.ArgumentNullException("replacement");
			}
			this._replacements.Add(replacement);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00016A0B File Offset: 0x00014C0B
		internal void Add(global::System.Windows.FrameworkElement element, global::System.Windows.DependencyProperty property)
		{
			this._replacements.Add(new global::Infragistics.Windows.Helpers.TempValueReplacement(element, property));
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00016A1F File Offset: 0x00014C1F
		internal void Add(global::System.Windows.FrameworkElement element, global::System.Windows.DependencyProperty property, object newValue)
		{
			this._replacements.Add(new global::Infragistics.Windows.Helpers.TempValueReplacement(element, property, newValue));
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00016A34 File Offset: 0x00014C34
		public void Dispose()
		{
			int i = 0;
			int count = this._replacements.Count;
			while (i < count)
			{
				this._replacements[i].Dispose();
				i++;
			}
		}

		// Token: 0x040002F3 RID: 755
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Helpers.TempValueReplacement> _replacements;
	}
}
