using System;

namespace DevAge.Text.FixedLength
{
	// Token: 0x02000277 RID: 631
	[global::System.AttributeUsage(global::System.AttributeTargets.Property, AllowMultiple = true)]
	internal class ValueMappingAttribute : global::System.Attribute
	{
		// Token: 0x06002071 RID: 8305 RVA: 0x00074084 File Offset: 0x00072284
		public ValueMappingAttribute(string stringValue, object fieldValue)
		{
			this.StringValue = stringValue;
			this.FieldValue = fieldValue;
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x0007409C File Offset: 0x0007229C
		// (set) Token: 0x06002073 RID: 8307 RVA: 0x000740A4 File Offset: 0x000722A4
		public string StringValue
		{
			get
			{
				return this.mStringValue;
			}
			set
			{
				this.mStringValue = value;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x000740B0 File Offset: 0x000722B0
		// (set) Token: 0x06002075 RID: 8309 RVA: 0x000740B8 File Offset: 0x000722B8
		public object FieldValue
		{
			get
			{
				return this.mFieldValue;
			}
			set
			{
				this.mFieldValue = value;
			}
		}

		// Token: 0x04000C03 RID: 3075
		private string mStringValue;

		// Token: 0x04000C04 RID: 3076
		private object mFieldValue;
	}
}
