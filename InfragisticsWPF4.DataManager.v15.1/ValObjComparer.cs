using System;
using System.Collections.Generic;
using System.Windows.Data;

namespace Infragistics
{
	// Token: 0x02000015 RID: 21
	internal class ValObjComparer<T> : global::System.Collections.Generic.IComparer<T>, global::System.Collections.Generic.IEqualityComparer<T>
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000734C File Offset: 0x0000554C
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00007354 File Offset: 0x00005554
		private global::System.Windows.Data.IValueConverter Converter { get; set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000735D File Offset: 0x0000555D
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00007365 File Offset: 0x00005565
		private object ConverterParameter { get; set; }

		// Token: 0x06000115 RID: 277 RVA: 0x0000736E File Offset: 0x0000556E
		protected internal ValObjComparer(global::System.Windows.Data.IValueConverter converter, object converterParam)
		{
			this.Converter = converter;
			this.ConverterParameter = converterParam;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000739C File Offset: 0x0000559C
		public int Compare(T x, T y)
		{
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
			binding.Converter = this.Converter;
			binding.ConverterParameter = this.ConverterParameter;
			binding.Source = x;
			this.tbx.SetBinding(global::Infragistics.ValObj.ValueProperty, binding);
			global::System.Windows.Data.Binding binding2 = new global::System.Windows.Data.Binding();
			binding2.Converter = this.Converter;
			binding2.ConverterParameter = this.ConverterParameter;
			binding2.Source = y;
			this.tby.SetBinding(global::Infragistics.ValObj.ValueProperty, binding2);
			return string.Compare(this.tbx.Value, this.tby.Value, global::System.StringComparison.CurrentCulture);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000743D File Offset: 0x0000563D
		bool global::System.Collections.Generic.IEqualityComparer<!0>.Equals(T x, T y)
		{
			return this.Compare(x, y) == 0;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000744C File Offset: 0x0000564C
		int global::System.Collections.Generic.IEqualityComparer<!0>.GetHashCode(T obj)
		{
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
			binding.Converter = this.Converter;
			binding.ConverterParameter = this.ConverterParameter;
			binding.Source = obj;
			this.tbx.SetBinding(global::Infragistics.ValObj.ValueProperty, binding);
			if (this.tbx.Value == null)
			{
				return 0;
			}
			return this.tbx.Value.GetHashCode();
		}

		// Token: 0x0400004C RID: 76
		private global::Infragistics.ValObj tbx = new global::Infragistics.ValObj();

		// Token: 0x0400004D RID: 77
		private global::Infragistics.ValObj tby = new global::Infragistics.ValObj();
	}
}
