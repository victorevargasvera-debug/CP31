using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000522 RID: 1314
	internal class ColumnMappingBuilder
	{
		// Token: 0x060040E4 RID: 16612 RVA: 0x000DA675 File Offset: 0x000D8875
		public ColumnMappingBuilder(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty columnProperty, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> propertyPath)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(columnProperty, "columnProperty");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>(propertyPath, "propertyPath");
			this._columnProperty = columnProperty;
			this._propertyPath = propertyPath;
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x060040E5 RID: 16613 RVA: 0x000DA6A3 File Offset: 0x000D88A3
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> PropertyPath
		{
			get
			{
				return this._propertyPath;
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x060040E6 RID: 16614 RVA: 0x000DA6AB File Offset: 0x000D88AB
		// (set) Token: 0x060040E7 RID: 16615 RVA: 0x000DA6B3 File Offset: 0x000D88B3
		public global::System.Data.Entity.Core.Metadata.Edm.EdmProperty ColumnProperty
		{
			get
			{
				return this._columnProperty;
			}
			internal set
			{
				this._columnProperty = value;
				if (this._scalarPropertyMapping != null)
				{
					this._scalarPropertyMapping.Column = this._columnProperty;
				}
			}
		}

		// Token: 0x060040E8 RID: 16616 RVA: 0x000DA6D5 File Offset: 0x000D88D5
		internal void SetTarget(global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping)
		{
			this._scalarPropertyMapping = scalarPropertyMapping;
		}

		// Token: 0x04001683 RID: 5763
		private global::System.Data.Entity.Core.Metadata.Edm.EdmProperty _columnProperty;

		// Token: 0x04001684 RID: 5764
		private readonly global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> _propertyPath;

		// Token: 0x04001685 RID: 5765
		private global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping _scalarPropertyMapping;
	}
}
