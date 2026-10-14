using System;
using System.Collections;
using System.ComponentModel;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001F3 RID: 499
	public class ValuePropertyDescriptor : global::System.ComponentModel.PropertyDescriptor
	{
		// Token: 0x060012A7 RID: 4775 RVA: 0x00042301 File Offset: 0x00040501
		public ValuePropertyDescriptor(global::System.Type type, string name) : base(name, null)
		{
			this._type = type;
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x00042312 File Offset: 0x00040512
		public override global::System.Type ComponentType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x0004231A File Offset: 0x0004051A
		public override bool CanResetValue(object component)
		{
			return false;
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x0004231D File Offset: 0x0004051D
		public override object GetValue(object component)
		{
			return component;
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x00042320 File Offset: 0x00040520
		public override global::System.Type PropertyType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00042328 File Offset: 0x00040528
		public override void ResetValue(object component)
		{
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x0004232A File Offset: 0x0004052A
		public override bool ShouldSerializeValue(object component)
		{
			return true;
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x0004232D File Offset: 0x0004052D
		public override bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00042330 File Offset: 0x00040530
		public bool IsReadOnlyList(global::System.Collections.IEnumerable sourceList)
		{
			global::System.Collections.IList list = sourceList as global::System.Collections.IList;
			return list == null || list.IsReadOnly;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x0004234F File Offset: 0x0004054F
		public override void SetValue(object dataitem, object value)
		{
		}

		// Token: 0x040009AC RID: 2476
		private global::System.Type _type;
	}
}
