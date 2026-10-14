using System;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq.Expressions;

namespace System.Data.Entity.Core.Common.Internal.Materialization
{
	// Token: 0x0200063D RID: 1597
	internal class RecordStateFactory
	{
		// Token: 0x06004CEE RID: 19694 RVA: 0x0010EBA0 File Offset: 0x0010CDA0
		public RecordStateFactory(int stateSlotNumber, int columnCount, global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateFactory[] nestedRecordStateFactories, global::System.Data.Entity.Core.Common.DataRecordInfo dataRecordInfo, global::System.Linq.Expressions.Expression<global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, bool>> gatherData, string[] propertyNames, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[] typeUsages, bool[] isColumnNested)
		{
			this.StateSlotNumber = stateSlotNumber;
			this.ColumnCount = columnCount;
			this.NestedRecordStateFactories = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateFactory>(nestedRecordStateFactories);
			this.DataRecordInfo = dataRecordInfo;
			this.GatherData = gatherData.Compile();
			this.Description = gatherData.ToString();
			this.ColumnNames = new global::System.Collections.ObjectModel.ReadOnlyCollection<string>(propertyNames);
			this.TypeUsages = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(typeUsages);
			this.FieldNameLookup = new global::System.Data.Entity.Core.FieldNameLookup(this.ColumnNames);
			if (isColumnNested == null)
			{
				isColumnNested = new bool[columnCount];
				int i = 0;
				while (i < columnCount)
				{
					global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind = typeUsages[i].EdmType.BuiltInTypeKind;
					if (builtInTypeKind <= global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType)
					{
						if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType && builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType)
						{
							goto IL_B2;
						}
						goto IL_A4;
					}
					else
					{
						if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType || builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
						{
							goto IL_A4;
						}
						goto IL_B2;
					}
					IL_B7:
					i++;
					continue;
					IL_A4:
					isColumnNested[i] = true;
					this.HasNestedColumns = true;
					goto IL_B7;
					IL_B2:
					isColumnNested[i] = false;
					goto IL_B7;
				}
			}
			this.IsColumnNested = new global::System.Collections.ObjectModel.ReadOnlyCollection<bool>(isColumnNested);
		}

		// Token: 0x06004CEF RID: 19695 RVA: 0x0010EC7C File Offset: 0x0010CE7C
		public RecordStateFactory(int stateSlotNumber, int columnCount, global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateFactory[] nestedRecordStateFactories, global::System.Data.Entity.Core.Common.DataRecordInfo dataRecordInfo, global::System.Linq.Expressions.Expression gatherData, string[] propertyNames, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[] typeUsages) : this(stateSlotNumber, columnCount, nestedRecordStateFactories, dataRecordInfo, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.BuildShaperLambda<bool>(gatherData), propertyNames, typeUsages, null)
		{
		}

		// Token: 0x06004CF0 RID: 19696 RVA: 0x0010ECA0 File Offset: 0x0010CEA0
		internal global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState Create(global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory coordinatorFactory)
		{
			return new global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState(this, coordinatorFactory);
		}

		// Token: 0x04001B4A RID: 6986
		internal readonly int StateSlotNumber;

		// Token: 0x04001B4B RID: 6987
		internal readonly int ColumnCount;

		// Token: 0x04001B4C RID: 6988
		internal readonly global::System.Data.Entity.Core.Common.DataRecordInfo DataRecordInfo;

		// Token: 0x04001B4D RID: 6989
		internal readonly global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, bool> GatherData;

		// Token: 0x04001B4E RID: 6990
		internal readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateFactory> NestedRecordStateFactories;

		// Token: 0x04001B4F RID: 6991
		internal readonly global::System.Collections.ObjectModel.ReadOnlyCollection<string> ColumnNames;

		// Token: 0x04001B50 RID: 6992
		internal readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> TypeUsages;

		// Token: 0x04001B51 RID: 6993
		internal readonly global::System.Collections.ObjectModel.ReadOnlyCollection<bool> IsColumnNested;

		// Token: 0x04001B52 RID: 6994
		internal readonly bool HasNestedColumns;

		// Token: 0x04001B53 RID: 6995
		internal readonly global::System.Data.Entity.Core.FieldNameLookup FieldNameLookup;

		// Token: 0x04001B54 RID: 6996
		private readonly string Description;
	}
}
