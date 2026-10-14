using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000526 RID: 1318
	public class ConditionPropertyMapping : global::System.Data.Entity.Core.Mapping.PropertyMapping
	{
		// Token: 0x06004107 RID: 16647 RVA: 0x000DADF0 File Offset: 0x000D8FF0
		internal ConditionPropertyMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty propertyOrColumn, object value, bool? isNull)
		{
			global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace = propertyOrColumn.TypeUsage.EdmType.DataSpace;
			if (dataSpace != global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
			{
				if (dataSpace != global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.MetadataItem_InvalidDataSpace(dataSpace, typeof(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty).Name), "propertyOrColumn");
				}
				this._column = propertyOrColumn;
			}
			else
			{
				base.Property = propertyOrColumn;
			}
			this._value = value;
			this._isNull = isNull;
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x000DAE63 File Offset: 0x000D9063
		internal ConditionPropertyMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column, object value, bool? isNull) : base(property)
		{
			this._column = column;
			this._value = value;
			this._isNull = isNull;
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06004109 RID: 16649 RVA: 0x000DAE82 File Offset: 0x000D9082
		internal object Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x0600410A RID: 16650 RVA: 0x000DAE8A File Offset: 0x000D908A
		internal bool? IsNull
		{
			get
			{
				return this._isNull;
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x0600410B RID: 16651 RVA: 0x000DAE92 File Offset: 0x000D9092
		// (set) Token: 0x0600410C RID: 16652 RVA: 0x000DAE9A File Offset: 0x000D909A
		public override global::System.Data.Entity.Core.Metadata.Edm.EdmProperty Property
		{
			get
			{
				return base.Property;
			}
			internal set
			{
				base.Property = value;
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x0600410D RID: 16653 RVA: 0x000DAEA3 File Offset: 0x000D90A3
		// (set) Token: 0x0600410E RID: 16654 RVA: 0x000DAEAB File Offset: 0x000D90AB
		public global::System.Data.Entity.Core.Metadata.Edm.EdmProperty Column
		{
			get
			{
				return this._column;
			}
			internal set
			{
				this._column = value;
			}
		}

		// Token: 0x0400168F RID: 5775
		private global::System.Data.Entity.Core.Metadata.Edm.EdmProperty _column;

		// Token: 0x04001690 RID: 5776
		private readonly object _value;

		// Token: 0x04001691 RID: 5777
		private readonly bool? _isNull;
	}
}
