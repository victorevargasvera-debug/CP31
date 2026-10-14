using System;
using System.Collections;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000296 RID: 662
	public class RecordFilterActionTypeConverter : global::System.ComponentModel.EnumConverter
	{
		// Token: 0x060021F4 RID: 8692 RVA: 0x000972C6 File Offset: 0x000954C6
		public RecordFilterActionTypeConverter() : base(typeof(global::Infragistics.Windows.DataPresenter.RecordFilterAction))
		{
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x000972D8 File Offset: 0x000954D8
		public override global::System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			if (this._values == null)
			{
				global::System.ComponentModel.TypeConverter.StandardValuesCollection standardValues = base.GetStandardValues(context);
				global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList(standardValues.Count - 1);
				foreach (object obj in standardValues)
				{
					if (!(obj.ToString() == "None"))
					{
						arrayList.Add(obj);
					}
				}
				this._values = new global::System.ComponentModel.TypeConverter.StandardValuesCollection(arrayList.ToArray());
			}
			return this._values;
		}

		// Token: 0x04001034 RID: 4148
		private global::System.ComponentModel.TypeConverter.StandardValuesCollection _values;
	}
}
