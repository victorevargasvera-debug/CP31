using System;

namespace Gibraltar.Serialization
{
	// Token: 0x020000F3 RID: 243
	internal class FieldDefinition
	{
		// Token: 0x060009F0 RID: 2544 RVA: 0x000185B4 File Offset: 0x000167B4
		public FieldDefinition(string fieldName, global::Gibraltar.Serialization.FieldType fieldType)
		{
			this.m_FieldName = fieldName;
			this.m_FieldType = fieldType;
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x000185CC File Offset: 0x000167CC
		public global::Gibraltar.Serialization.FieldType FieldType
		{
			get
			{
				return this.m_FieldType;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x000185D4 File Offset: 0x000167D4
		public string Name
		{
			get
			{
				return this.m_FieldName;
			}
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x000185DC File Offset: 0x000167DC
		public bool IsCompatible(global::Gibraltar.Serialization.FieldType type)
		{
			if (type == this.m_FieldType)
			{
				return true;
			}
			switch (type)
			{
			case global::Gibraltar.Serialization.FieldType.Int32:
				return this.m_FieldType == global::Gibraltar.Serialization.FieldType.Int64 || this.m_FieldType == global::Gibraltar.Serialization.FieldType.Double;
			case global::Gibraltar.Serialization.FieldType.Int32Array:
				return this.m_FieldType == global::Gibraltar.Serialization.FieldType.Int64Array || this.m_FieldType == global::Gibraltar.Serialization.FieldType.DoubleArray;
			case global::Gibraltar.Serialization.FieldType.Int64:
			case global::Gibraltar.Serialization.FieldType.Int64Array:
				break;
			case global::Gibraltar.Serialization.FieldType.UInt32:
				return this.m_FieldType == global::Gibraltar.Serialization.FieldType.UInt64 || this.m_FieldType == global::Gibraltar.Serialization.FieldType.Double;
			case global::Gibraltar.Serialization.FieldType.UInt32Array:
				return this.m_FieldType == global::Gibraltar.Serialization.FieldType.UInt64Array || this.m_FieldType == global::Gibraltar.Serialization.FieldType.DoubleArray;
			default:
				if (type == global::Gibraltar.Serialization.FieldType.DateTimeOffset)
				{
					return this.m_FieldType == global::Gibraltar.Serialization.FieldType.DateTime;
				}
				if (type == global::Gibraltar.Serialization.FieldType.DateTimeOffsetArray)
				{
					return this.m_FieldType == global::Gibraltar.Serialization.FieldType.DateTimeArray;
				}
				break;
			}
			return false;
		}

		// Token: 0x04000290 RID: 656
		private readonly global::Gibraltar.Serialization.FieldType m_FieldType;

		// Token: 0x04000291 RID: 657
		private readonly string m_FieldName;
	}
}
