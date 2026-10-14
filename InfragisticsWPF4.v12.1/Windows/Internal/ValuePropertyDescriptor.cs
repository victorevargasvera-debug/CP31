using System;
using System.Collections;
using System.ComponentModel;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001C5 RID: 453
	public class ValuePropertyDescriptor : global::System.ComponentModel.PropertyDescriptor
	{
		// Token: 0x060010D6 RID: 4310 RVA: 0x0003CBC1 File Offset: 0x0003ADC1
		public ValuePropertyDescriptor(global::System.Type type, string name) : base(name, null)
		{
			this._type = type;
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x0003CBD2 File Offset: 0x0003ADD2
		public override global::System.Type ComponentType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0003CBDA File Offset: 0x0003ADDA
		public override bool CanResetValue(object component)
		{
			return false;
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0003CBDD File Offset: 0x0003ADDD
		public override object GetValue(object component)
		{
			return component;
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060010DA RID: 4314 RVA: 0x0003CBE0 File Offset: 0x0003ADE0
		public override global::System.Type PropertyType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x0003CBE8 File Offset: 0x0003ADE8
		public override void ResetValue(object component)
		{
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0003CBEA File Offset: 0x0003ADEA
		public override bool ShouldSerializeValue(object component)
		{
			return true;
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060010DD RID: 4317 RVA: 0x0003CBED File Offset: 0x0003ADED
		public override bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0003CBF0 File Offset: 0x0003ADF0
		public bool IsReadOnlyList(global::System.Collections.IEnumerable sourceList)
		{
			global::System.Collections.IList list = sourceList as global::System.Collections.IList;
			return list == null || list.IsReadOnly;
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0003CC0F File Offset: 0x0003AE0F
		public override void SetValue(object dataitem, object value)
		{
		}

		// Token: 0x0400086B RID: 2155
		private global::System.Type _type;
	}
}
