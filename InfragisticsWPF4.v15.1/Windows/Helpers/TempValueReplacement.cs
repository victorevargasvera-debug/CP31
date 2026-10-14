using System;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x020000BC RID: 188
	internal class TempValueReplacement : global::System.IDisposable
	{
		// Token: 0x06000708 RID: 1800 RVA: 0x0001A025 File Offset: 0x00018225
		internal TempValueReplacement(global::System.Windows.DependencyObject d, global::System.Windows.DependencyProperty property) : this(d, property, (d != null) ? d.GetValue(property) : null)
		{
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0001A03C File Offset: 0x0001823C
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

		// Token: 0x0600070A RID: 1802 RVA: 0x0001A077 File Offset: 0x00018277
		public void Dispose()
		{
			if (this._object != null)
			{
				global::Infragistics.Windows.Helpers.TempValueReplacement.RestoreValue(this._object, this._property, this._originalValue, this._originalExpression);
			}
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0001A0A0 File Offset: 0x000182A0
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

		// Token: 0x04000391 RID: 913
		private object _originalValue;

		// Token: 0x04000392 RID: 914
		private global::System.Windows.DependencyProperty _property;

		// Token: 0x04000393 RID: 915
		private global::System.Windows.DependencyObject _object;

		// Token: 0x04000394 RID: 916
		private global::System.Windows.Data.BindingExpressionBase _originalExpression;
	}
}
