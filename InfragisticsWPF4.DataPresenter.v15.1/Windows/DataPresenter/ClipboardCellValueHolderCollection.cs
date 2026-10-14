using System;
using System.Collections.Generic;
using System.Globalization;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000085 RID: 133
	internal class ClipboardCellValueHolderCollection : global::Infragistics.Windows.DataPresenter.CellValueHolderCollection
	{
		// Token: 0x060006B7 RID: 1719 RVA: 0x0001A886 File Offset: 0x00018A86
		internal ClipboardCellValueHolderCollection(global::Infragistics.Windows.DataPresenter.ICellValueProvider valueProvider, global::System.Collections.Generic.IDictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.CellValueHolder> labels) : base(valueProvider)
		{
			this._labels = labels;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0001A898 File Offset: 0x00018A98
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

		// Token: 0x060006B9 RID: 1721 RVA: 0x0001A948 File Offset: 0x00018B48
		internal global::Infragistics.Windows.DataPresenter.CellValueHolder GetLabel(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.CellValueHolder result;
			if (this._labels == null || !this._labels.TryGetValue(field, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0001A970 File Offset: 0x00018B70
		internal global::Infragistics.Windows.DataPresenter.CellValueHolder GetLabel(int fieldIndex)
		{
			global::Infragistics.Windows.DataPresenter.Field field = base.GetField(fieldIndex);
			return this.GetLabel(field);
		}

		// Token: 0x04000219 RID: 537
		private global::System.Collections.Generic.IDictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.CellValueHolder> _labels;
	}
}
