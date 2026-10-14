using System;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x020000A2 RID: 162
	internal class TempValueReplacement : global::System.IDisposable
	{
		// Token: 0x06000624 RID: 1572 RVA: 0x00016905 File Offset: 0x00014B05
		internal TempValueReplacement(global::System.Windows.DependencyObject d, global::System.Windows.DependencyProperty property) : this(d, property, (d != null) ? d.GetValue(property) : null)
		{
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0001691C File Offset: 0x00014B1C
		internal TempValueReplacement(global::System.Windows.DependencyObject d, global::System.Windows.DependencyProperty property, object newValue)
		{
			this._object = d;
			this._property = property;
			if (d != null)
			{
				this._originalValue = d.ReadLocalValue(property);
				this._originalExpression = global::System.Windows.Data.BindingOperations.GetBindingExpressionBase(d, property);
				d.SetValue(property, newValue);
			}
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00016957 File Offset: 0x00014B57
		public void Dispose()
		{
			if (this._object != null)
			{
				global::Infragistics.Windows.Helpers.TempValueReplacement.RestoreValue(this._object, this._property, this._originalValue, this._originalExpression);
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00016980 File Offset: 0x00014B80
		private static void RestoreValue(global::System.Windows.DependencyObject d, global::System.Windows.DependencyProperty property, object value, global::System.Windows.Data.BindingExpressionBase originalExpression)
		{
			if (originalExpression != null)
			{
				global::System.Windows.Data.BindingOperations.SetBinding(d, property, originalExpression.ParentBindingBase);
				return;
			}
			if (value == null || property.PropertyType.IsAssignableFrom(value.GetType()))
			{
				d.SetValue(property, value);
				return;
			}
			if (value is global::System.Windows.Data.BindingBase)
			{
				global::System.Windows.Data.BindingOperations.SetBinding(d, property, (global::System.Windows.Data.BindingBase)value);
				return;
			}
			d.ClearValue(property);
		}

		// Token: 0x040002EF RID: 751
		private object _originalValue;

		// Token: 0x040002F0 RID: 752
		private global::System.Windows.DependencyProperty _property;

		// Token: 0x040002F1 RID: 753
		private global::System.Windows.DependencyObject _object;

		// Token: 0x040002F2 RID: 754
		private global::System.Windows.Data.BindingExpressionBase _originalExpression;
	}
}
