using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x020000BD RID: 189
	internal class GroupTempValueReplacement : global::System.IDisposable
	{
		// Token: 0x0600070C RID: 1804 RVA: 0x0001A0FC File Offset: 0x000182FC
		internal GroupTempValueReplacement()
		{
			this._replacements = new global::System.Collections.Generic.List<global::Infragistics.Windows.Helpers.TempValueReplacement>();
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0001A10F File Offset: 0x0001830F
		internal void Add(global::Infragistics.Windows.Helpers.TempValueReplacement replacement)
		{
			if (replacement == null)
			{
				throw new global::System.ArgumentNullException("replacement");
			}
			this._replacements.Add(replacement);
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0001A12B File Offset: 0x0001832B
		internal void Add(global::System.Windows.FrameworkElement element, global::System.Windows.DependencyProperty property)
		{
			this._replacements.Add(new global::Infragistics.Windows.Helpers.TempValueReplacement(element, property));
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0001A13F File Offset: 0x0001833F
		internal void Add(global::System.Windows.FrameworkElement element, global::System.Windows.DependencyProperty property, object newValue)
		{
			this._replacements.Add(new global::Infragistics.Windows.Helpers.TempValueReplacement(element, property, newValue));
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0001A154 File Offset: 0x00018354
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

		// Token: 0x04000395 RID: 917
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Helpers.TempValueReplacement> _replacements;
	}
}
