using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200008F RID: 143
	internal class ClipboardFieldArrayProvider
	{
		// Token: 0x06000728 RID: 1832 RVA: 0x0001DD44 File Offset: 0x0001BF44
		internal ClipboardFieldArrayProvider(global::Infragistics.Windows.DataPresenter.Field[] fields)
		{
			this._previousFields = fields;
			this._previousFieldLayout = ((fields != null && fields.Length > 0) ? fields[0].Owner : null);
			if (this._previousFieldLayout != null && this._previousFieldLayout.DataPresenter != null && this._previousFieldLayout.DataPresenter.IsTreeView)
			{
				this._cachedFields = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.DataPresenter.Field[]>();
				this._cachedFields[this._previousFieldLayout] = fields;
			}
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0001DDBC File Offset: 0x0001BFBC
		internal global::Infragistics.Windows.DataPresenter.Field[] GetFields(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			global::Infragistics.Windows.DataPresenter.Field[] array = this._previousFields;
			if (this._cachedFields != null && fl != this._previousFieldLayout)
			{
				if (!this._cachedFields.TryGetValue(fl, out array))
				{
					array = new global::Infragistics.Windows.DataPresenter.Field[this._previousFields.Length];
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = this._previousFields[i].GetMappedFieldInTree(fl);
					}
					this._cachedFields[fl] = array;
				}
				this._previousFields = array;
				this._previousFieldLayout = fl;
			}
			return array;
		}

		// Token: 0x04000238 RID: 568
		private global::Infragistics.Windows.DataPresenter.FieldLayout _previousFieldLayout;

		// Token: 0x04000239 RID: 569
		private global::Infragistics.Windows.DataPresenter.Field[] _previousFields;

		// Token: 0x0400023A RID: 570
		private readonly global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.DataPresenter.Field[]> _cachedFields;
	}
}
