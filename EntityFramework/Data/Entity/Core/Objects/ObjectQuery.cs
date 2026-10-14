using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.ELinq;
using System.Data.Entity.Core.Objects.Internal;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Resources;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x0200041A RID: 1050
	public abstract class ObjectQuery : global::System.Collections.IEnumerable, global::System.Linq.IOrderedQueryable, global::System.Linq.IQueryable, global::System.ComponentModel.IListSource, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable
	{
		// Token: 0x06003253 RID: 12883 RVA: 0x000A0BC9 File Offset: 0x0009EDC9
		internal ObjectQuery(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState queryState)
		{
			this._state = queryState;
		}

		// Token: 0x06003254 RID: 12884 RVA: 0x000A0BD8 File Offset: 0x0009EDD8
		internal ObjectQuery()
		{
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06003255 RID: 12885 RVA: 0x000A0BE0 File Offset: 0x0009EDE0
		internal global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState QueryState
		{
			get
			{
				return this._state;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06003256 RID: 12886 RVA: 0x000A0BE8 File Offset: 0x0009EDE8
		internal virtual global::System.Data.Entity.Core.Objects.ELinq.ObjectQueryProvider ObjectQueryProvider
		{
			get
			{
				if (this._provider == null)
				{
					this._provider = new global::System.Data.Entity.Core.Objects.ELinq.ObjectQueryProvider(this);
				}
				return this._provider;
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06003257 RID: 12887 RVA: 0x000A0C04 File Offset: 0x0009EE04
		// (set) Token: 0x06003258 RID: 12888 RVA: 0x000A0C11 File Offset: 0x0009EE11
		internal global::System.Data.Entity.Infrastructure.IDbExecutionStrategy ExecutionStrategy
		{
			get
			{
				return this.QueryState.ExecutionStrategy;
			}
			set
			{
				this.QueryState.ExecutionStrategy = value;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06003259 RID: 12889 RVA: 0x000A0C1F File Offset: 0x0009EE1F
		bool global::System.ComponentModel.IListSource.ContainsListCollection
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x0600325A RID: 12890 RVA: 0x000A0C24 File Offset: 0x0009EE24
		public string CommandText
		{
			get
			{
				string result;
				if (!this._state.TryGetCommandText(out result))
				{
					return string.Empty;
				}
				return result;
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x0600325B RID: 12891 RVA: 0x000A0C47 File Offset: 0x0009EE47
		public global::System.Data.Entity.Core.Objects.ObjectContext Context
		{
			get
			{
				return this._state.ObjectContext;
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x0600325C RID: 12892 RVA: 0x000A0C54 File Offset: 0x0009EE54
		// (set) Token: 0x0600325D RID: 12893 RVA: 0x000A0C61 File Offset: 0x0009EE61
		public global::System.Data.Entity.Core.Objects.MergeOption MergeOption
		{
			get
			{
				return this._state.EffectiveMergeOption;
			}
			set
			{
				global::System.Data.Entity.Core.EntityUtil.CheckArgumentMergeOption(value);
				this._state.UserSpecifiedMergeOption = new global::System.Data.Entity.Core.Objects.MergeOption?(value);
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x0600325E RID: 12894 RVA: 0x000A0C7A File Offset: 0x0009EE7A
		// (set) Token: 0x0600325F RID: 12895 RVA: 0x000A0C87 File Offset: 0x0009EE87
		public bool Streaming
		{
			get
			{
				return this._state.EffectiveStreamingBehavior;
			}
			set
			{
				this._state.UserSpecifiedStreamingBehavior = new bool?(value);
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06003260 RID: 12896 RVA: 0x000A0C9A File Offset: 0x0009EE9A
		public global::System.Data.Entity.Core.Objects.ObjectParameterCollection Parameters
		{
			get
			{
				return this._state.EnsureParameters();
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06003261 RID: 12897 RVA: 0x000A0CA7 File Offset: 0x0009EEA7
		// (set) Token: 0x06003262 RID: 12898 RVA: 0x000A0CB4 File Offset: 0x0009EEB4
		public bool EnablePlanCaching
		{
			get
			{
				return this._state.PlanCachingEnabled;
			}
			set
			{
				this._state.PlanCachingEnabled = value;
			}
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x000A0CC4 File Offset: 0x0009EEC4
		[global::System.ComponentModel.Browsable(false)]
		public string ToTraceString()
		{
			return this._state.GetExecutionPlan(null).ToTraceString();
		}

		// Token: 0x06003264 RID: 12900 RVA: 0x000A0CEC File Offset: 0x0009EEEC
		public global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetResultType()
		{
			if (this._resultType == null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType = this._state.ResultType;
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
				if (!global::System.Data.Entity.Core.Common.TypeHelpers.TryGetCollectionElementType(resultType, out typeUsage))
				{
					typeUsage = resultType;
				}
				typeUsage = this._state.ObjectContext.Perspective.MetadataWorkspace.GetOSpaceTypeUsage(typeUsage);
				if (typeUsage == null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectQuery_UnableToMapResultType);
				}
				this._resultType = typeUsage;
			}
			return this._resultType;
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x000A0D50 File Offset: 0x0009EF50
		public global::System.Data.Entity.Core.Objects.ObjectResult Execute(global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentMergeOption(mergeOption);
			return this.ExecuteInternal(mergeOption);
		}

		// Token: 0x06003266 RID: 12902 RVA: 0x000A0D5F File Offset: 0x0009EF5F
		public global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult> ExecuteAsync(global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			return this.ExecuteAsync(mergeOption, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x000A0D6D File Offset: 0x0009EF6D
		public global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult> ExecuteAsync(global::System.Data.Entity.Core.Objects.MergeOption mergeOption, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentMergeOption(mergeOption);
			cancellationToken.ThrowIfCancellationRequested();
			return this.ExecuteInternalAsync(mergeOption, cancellationToken);
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x000A0D84 File Offset: 0x0009EF84
		global::System.Collections.IList global::System.ComponentModel.IListSource.GetList()
		{
			return this.GetIListSourceListInternal();
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06003269 RID: 12905 RVA: 0x000A0D8C File Offset: 0x0009EF8C
		global::System.Type global::System.Linq.IQueryable.ElementType
		{
			get
			{
				return this._state.ElementType;
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x0600326A RID: 12906 RVA: 0x000A0D99 File Offset: 0x0009EF99
		global::System.Linq.Expressions.Expression global::System.Linq.IQueryable.Expression
		{
			get
			{
				return this.GetExpression();
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x0600326B RID: 12907 RVA: 0x000A0DA1 File Offset: 0x0009EFA1
		global::System.Linq.IQueryProvider global::System.Linq.IQueryable.Provider
		{
			get
			{
				return this.ObjectQueryProvider;
			}
		}

		// Token: 0x0600326C RID: 12908 RVA: 0x000A0DA9 File Offset: 0x0009EFA9
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumeratorInternal();
		}

		// Token: 0x0600326D RID: 12909 RVA: 0x000A0DB1 File Offset: 0x0009EFB1
		global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable.GetAsyncEnumerator()
		{
			return this.GetAsyncEnumeratorInternal();
		}

		// Token: 0x0600326E RID: 12910
		internal abstract global::System.Linq.Expressions.Expression GetExpression();

		// Token: 0x0600326F RID: 12911
		internal abstract global::System.Collections.IEnumerator GetEnumeratorInternal();

		// Token: 0x06003270 RID: 12912
		internal abstract global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator GetAsyncEnumeratorInternal();

		// Token: 0x06003271 RID: 12913
		internal abstract global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult> ExecuteInternalAsync(global::System.Data.Entity.Core.Objects.MergeOption mergeOption, global::System.Threading.CancellationToken cancellationToken);

		// Token: 0x06003272 RID: 12914
		internal abstract global::System.Collections.IList GetIListSourceListInternal();

		// Token: 0x06003273 RID: 12915
		internal abstract global::System.Data.Entity.Core.Objects.ObjectResult ExecuteInternal(global::System.Data.Entity.Core.Objects.MergeOption mergeOption);

		// Token: 0x0400107F RID: 4223
		private readonly global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState _state;

		// Token: 0x04001080 RID: 4224
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _resultType;

		// Token: 0x04001081 RID: 4225
		private global::System.Data.Entity.Core.Objects.ELinq.ObjectQueryProvider _provider;
	}
}
