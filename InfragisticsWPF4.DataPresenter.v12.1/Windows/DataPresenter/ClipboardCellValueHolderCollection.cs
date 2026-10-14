using System;
using System.Collections.Generic;
using System.Globalization;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000080 RID: 128
	internal class ClipboardCellValueHolderCollection : global::Infragistics.Windows.DataPresenter.CellValueHolderCollection
	{
		// Token: 0x0600063B RID: 1595 RVA: 0x000182F6 File Offset: 0x000164F6
		internal ClipboardCellValueHolderCollection(global::Infragistics.Windows.DataPresenter.ICellValueProvider valueProvider, global::System.Collections.Generic.IDictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.CellValueHolder> labels) : base(valueProvider)
		{
			this._labels = labels;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00018308 File Offset: 0x00016508
		internal void ConvertLabelsToText()
		{
			if (this._labels != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.CellValueHolder> keyValuePair in this._labels)
				{
					global::Infragistics.Windows.DataPresenter.CellValueHolder value = keyValuePair.Value;
					if (!value.IsDisplayText)
					{
						global::Infragistics.Windows.DataPresenter.Field key = keyValuePair.Key;
						global::System.Globalization.CultureInfo defaultConverterCulture = key.DataPresenter.DefaultConverterCulture;
						string value2 = string.Empty;
						if (value.Value != null)
						{
							value2 = (global::Infragistics.CoreUtilities.ConvertDataValue(value.Value, typeof(string), defaultConverterCulture, null) as string);
						}
						value.Initialize(value2, true);
					}
				}
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000183B8 File Offset: 0x000165B8
		internal global::Infragistics.Windows.DataPresenter.CellValueHolder GetLabel(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.CellValueHolder result;
			if (this._labels == null || !this._labels.TryGetValue(field, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x000183E0 File Offset: 0x000165E0
		internal global::Infragistics.Windows.DataPresenter.CellValueHolder GetLabel(int fieldIndex)
		{
			global::Infragistics.Windows.DataPresenter.Field field = base.GetField(fieldIndex);
			return this.GetLabel(field);
		}

		// Token: 0x040001DD RID: 477
		private global::System.Collections.Generic.IDictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.CellValueHolder> _labels;
	}
}
