using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.Internal;

namespace System.Data.Entity.Core.Common.QueryCache
{
	// Token: 0x02000628 RID: 1576
	internal sealed class CompiledQueryCacheEntry : global::System.Data.Entity.Core.Common.QueryCache.QueryCacheEntry
	{
		// Token: 0x06004C39 RID: 19513 RVA: 0x0010B430 File Offset: 0x00109630
		internal CompiledQueryCacheEntry(global::System.Data.Entity.Core.Common.QueryCache.QueryCacheKey queryCacheKey, global::System.Data.Entity.Core.Objects.MergeOption? mergeOption) : base(queryCacheKey, null)
		{
			this.PropagatedMergeOption = mergeOption;
			this._plans = new global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan>();
		}

		// Token: 0x06004C3A RID: 19514 RVA: 0x0010B44C File Offset: 0x0010964C
		internal global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan GetExecutionPlan(global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool useCSharpNullComparisonBehavior)
		{
			string key = global::System.Data.Entity.Core.Common.QueryCache.CompiledQueryCacheEntry.GenerateLocalCacheKey(mergeOption, useCSharpNullComparisonBehavior);
			global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan result;
			this._plans.TryGetValue(key, out result);
			return result;
		}

		// Token: 0x06004C3B RID: 19515 RVA: 0x0010B474 File Offset: 0x00109674
		internal global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan SetExecutionPlan(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan newPlan, bool useCSharpNullComparisonBehavior)
		{
			string key = global::System.Data.Entity.Core.Common.QueryCache.CompiledQueryCacheEntry.GenerateLocalCacheKey(newPlan.MergeOption, useCSharpNullComparisonBehavior);
			return this._plans.GetOrAdd(key, newPlan);
		}

		// Token: 0x06004C3C RID: 19516 RVA: 0x0010B49C File Offset: 0x0010969C
		internal bool TryGetResultType(out global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType)
		{
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan> enumerator = this._plans.Values.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan objectQueryExecutionPlan = enumerator.Current;
					resultType = objectQueryExecutionPlan.ResultType;
					return true;
				}
			}
			resultType = null;
			return false;
		}

		// Token: 0x06004C3D RID: 19517 RVA: 0x0010B4FC File Offset: 0x001096FC
		internal override object GetTarget()
		{
			return this;
		}

		// Token: 0x06004C3E RID: 19518 RVA: 0x0010B500 File Offset: 0x00109700
		private static string GenerateLocalCacheKey(global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool useCSharpNullComparisonBehavior)
		{
			if (mergeOption <= global::System.Data.Entity.Core.Objects.MergeOption.NoTracking)
			{
				return string.Join("", new object[]
				{
					global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Objects.MergeOption), mergeOption),
					useCSharpNullComparisonBehavior
				});
			}
			throw new global::System.ArgumentOutOfRangeException("newPlan.MergeOption");
		}

		// Token: 0x04001A95 RID: 6805
		public readonly global::System.Data.Entity.Core.Objects.MergeOption? PropagatedMergeOption;

		// Token: 0x04001A96 RID: 6806
		private readonly global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan> _plans;
	}
}
