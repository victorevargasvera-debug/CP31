using System;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000413 RID: 1043
	internal class NextResultGenerator
	{
		// Token: 0x0600317B RID: 12667 RVA: 0x0009CB1F File Offset: 0x0009AD1F
		internal NextResultGenerator(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand, global::System.Data.Entity.Core.Metadata.Edm.EdmType[] edmTypes, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> entitySets, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool streaming, int resultSetIndex)
		{
			this._context = context;
			this._entityCommand = entityCommand;
			this._entitySets = entitySets;
			this._edmTypes = edmTypes;
			this._resultSetIndex = resultSetIndex;
			this._streaming = streaming;
			this._mergeOption = mergeOption;
		}

		// Token: 0x0600317C RID: 12668 RVA: 0x0009CB5C File Offset: 0x0009AD5C
		internal global::System.Data.Entity.Core.Objects.ObjectResult<TElement> GetNextResult<TElement>(global::System.Data.Common.DbDataReader storeReader)
		{
			bool flag = false;
			try
			{
				flag = storeReader.NextResult();
			}
			catch (global::System.Exception ex)
			{
				if (ex.IsCatchableExceptionType())
				{
					throw new global::System.Data.Entity.Core.EntityCommandExecutionException(global::System.Data.Entity.Resources.Strings.EntityClient_StoreReaderFailed, ex);
				}
				throw;
			}
			if (flag)
			{
				global::System.Data.Entity.Core.Common.Utils.MetadataHelper.CheckFunctionImportReturnType<TElement>(this._edmTypes[this._resultSetIndex], this._context.MetadataWorkspace);
				return this._context.MaterializedDataRecord<TElement>(this._entityCommand, storeReader, this._resultSetIndex, this._entitySets, this._edmTypes, null, this._mergeOption, this._streaming);
			}
			return null;
		}

		// Token: 0x0400104C RID: 4172
		private readonly global::System.Data.Entity.Core.EntityClient.EntityCommand _entityCommand;

		// Token: 0x0400104D RID: 4173
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> _entitySets;

		// Token: 0x0400104E RID: 4174
		private readonly global::System.Data.Entity.Core.Objects.ObjectContext _context;

		// Token: 0x0400104F RID: 4175
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmType[] _edmTypes;

		// Token: 0x04001050 RID: 4176
		private readonly int _resultSetIndex;

		// Token: 0x04001051 RID: 4177
		private readonly bool _streaming;

		// Token: 0x04001052 RID: 4178
		private readonly global::System.Data.Entity.Core.Objects.MergeOption _mergeOption;
	}
}
