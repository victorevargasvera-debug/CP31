using System;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Utilities;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000452 RID: 1106
	internal abstract class ObjectQueryState
	{
		// Token: 0x060035F1 RID: 13809 RVA: 0x000ACC58 File Offset: 0x000AAE58
		protected ObjectQueryState(global::System.Type elementType, global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Objects.ObjectParameterCollection parameters, global::System.Data.Entity.Core.Objects.Span span)
		{
			this._elementType = elementType;
			this._context = context;
			this._span = span;
			this._parameters = parameters;
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x000ACC84 File Offset: 0x000AAE84
		protected ObjectQueryState(global::System.Type elementType, global::System.Data.Entity.Core.Objects.ObjectQuery query) : this(elementType, query.Context, null, null)
		{
			this._cachingEnabled = query.EnablePlanCaching;
			this.UserSpecifiedStreamingBehavior = query.QueryState.UserSpecifiedStreamingBehavior;
			this.ExecutionStrategy = query.QueryState.ExecutionStrategy;
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x060035F3 RID: 13811 RVA: 0x000ACCC4 File Offset: 0x000AAEC4
		internal bool EffectiveStreamingBehavior
		{
			get
			{
				bool? userSpecifiedStreamingBehavior = this.UserSpecifiedStreamingBehavior;
				if (userSpecifiedStreamingBehavior == null)
				{
					return this.DefaultStreamingBehavior;
				}
				return userSpecifiedStreamingBehavior.GetValueOrDefault();
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x060035F4 RID: 13812 RVA: 0x000ACCEF File Offset: 0x000AAEEF
		// (set) Token: 0x060035F5 RID: 13813 RVA: 0x000ACCF7 File Offset: 0x000AAEF7
		internal bool? UserSpecifiedStreamingBehavior { get; set; }

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x060035F6 RID: 13814 RVA: 0x000ACD00 File Offset: 0x000AAF00
		internal bool DefaultStreamingBehavior
		{
			get
			{
				return !(this.ExecutionStrategy ?? global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(this.ObjectContext.Connection, this.ObjectContext.MetadataWorkspace)).RetriesOnFailure;
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x060035F7 RID: 13815 RVA: 0x000ACD2F File Offset: 0x000AAF2F
		// (set) Token: 0x060035F8 RID: 13816 RVA: 0x000ACD37 File Offset: 0x000AAF37
		internal global::System.Data.Entity.Infrastructure.IDbExecutionStrategy ExecutionStrategy { get; set; }

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x060035F9 RID: 13817 RVA: 0x000ACD40 File Offset: 0x000AAF40
		internal global::System.Type ElementType
		{
			get
			{
				return this._elementType;
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x060035FA RID: 13818 RVA: 0x000ACD48 File Offset: 0x000AAF48
		internal global::System.Data.Entity.Core.Objects.ObjectContext ObjectContext
		{
			get
			{
				return this._context;
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x060035FB RID: 13819 RVA: 0x000ACD50 File Offset: 0x000AAF50
		internal global::System.Data.Entity.Core.Objects.ObjectParameterCollection Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x060035FC RID: 13820 RVA: 0x000ACD58 File Offset: 0x000AAF58
		internal global::System.Data.Entity.Core.Objects.ObjectParameterCollection EnsureParameters()
		{
			if (this._parameters == null)
			{
				this._parameters = new global::System.Data.Entity.Core.Objects.ObjectParameterCollection(this.ObjectContext.Perspective);
				if (this._cachedPlan != null)
				{
					this._parameters.SetReadOnly(true);
				}
			}
			return this._parameters;
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x060035FD RID: 13821 RVA: 0x000ACD92 File Offset: 0x000AAF92
		internal global::System.Data.Entity.Core.Objects.Span Span
		{
			get
			{
				return this._span;
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x060035FE RID: 13822 RVA: 0x000ACD9C File Offset: 0x000AAF9C
		internal global::System.Data.Entity.Core.Objects.MergeOption EffectiveMergeOption
		{
			get
			{
				if (this._userMergeOption != null)
				{
					return this._userMergeOption.Value;
				}
				global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan cachedPlan = this._cachedPlan;
				if (cachedPlan != null)
				{
					return cachedPlan.MergeOption;
				}
				return global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState.DefaultMergeOption;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x060035FF RID: 13823 RVA: 0x000ACDD8 File Offset: 0x000AAFD8
		// (set) Token: 0x06003600 RID: 13824 RVA: 0x000ACDE0 File Offset: 0x000AAFE0
		internal global::System.Data.Entity.Core.Objects.MergeOption? UserSpecifiedMergeOption
		{
			get
			{
				return this._userMergeOption;
			}
			set
			{
				this._userMergeOption = value;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06003601 RID: 13825 RVA: 0x000ACDE9 File Offset: 0x000AAFE9
		// (set) Token: 0x06003602 RID: 13826 RVA: 0x000ACDF1 File Offset: 0x000AAFF1
		internal bool PlanCachingEnabled
		{
			get
			{
				return this._cachingEnabled;
			}
			set
			{
				this._cachingEnabled = value;
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06003603 RID: 13827 RVA: 0x000ACDFC File Offset: 0x000AAFFC
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ResultType
		{
			get
			{
				global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan cachedPlan = this._cachedPlan;
				if (cachedPlan != null)
				{
					return cachedPlan.ResultType;
				}
				return this.GetResultType();
			}
		}

		// Token: 0x06003604 RID: 13828 RVA: 0x000ACE20 File Offset: 0x000AB020
		internal void ApplySettingsTo(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState other)
		{
			other.PlanCachingEnabled = this.PlanCachingEnabled;
			other.UserSpecifiedMergeOption = this.UserSpecifiedMergeOption;
		}

		// Token: 0x06003605 RID: 13829
		internal abstract bool TryGetCommandText(out string commandText);

		// Token: 0x06003606 RID: 13830
		internal abstract bool TryGetExpression(out global::System.Linq.Expressions.Expression expression);

		// Token: 0x06003607 RID: 13831
		internal abstract global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan GetExecutionPlan(global::System.Data.Entity.Core.Objects.MergeOption? forMergeOption);

		// Token: 0x06003608 RID: 13832
		internal abstract global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState Include<TElementType>(global::System.Data.Entity.Core.Objects.ObjectQuery<TElementType> sourceQuery, string includePath);

		// Token: 0x06003609 RID: 13833
		protected abstract global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetResultType();

		// Token: 0x0600360A RID: 13834 RVA: 0x000ACE3C File Offset: 0x000AB03C
		protected static global::System.Data.Entity.Core.Objects.MergeOption EnsureMergeOption(params global::System.Data.Entity.Core.Objects.MergeOption?[] preferredMergeOptions)
		{
			foreach (global::System.Data.Entity.Core.Objects.MergeOption mergeOption in preferredMergeOptions)
			{
				if (mergeOption != null)
				{
					return mergeOption.Value;
				}
			}
			return global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState.DefaultMergeOption;
		}

		// Token: 0x0600360B RID: 13835 RVA: 0x000ACE78 File Offset: 0x000AB078
		protected static global::System.Data.Entity.Core.Objects.MergeOption? GetMergeOption(params global::System.Data.Entity.Core.Objects.MergeOption?[] preferredMergeOptions)
		{
			foreach (global::System.Data.Entity.Core.Objects.MergeOption mergeOption in preferredMergeOptions)
			{
				if (mergeOption != null)
				{
					return new global::System.Data.Entity.Core.Objects.MergeOption?(mergeOption.Value);
				}
			}
			return null;
		}

		// Token: 0x0600360C RID: 13836 RVA: 0x000ACEBC File Offset: 0x000AB0BC
		public global::System.Data.Entity.Core.Objects.ObjectQuery CreateQuery()
		{
			return (global::System.Data.Entity.Core.Objects.ObjectQuery)global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState.CreateObjectQueryMethod.MakeGenericMethod(new global::System.Type[]
			{
				this._elementType
			}).Invoke(this, new object[0]);
		}

		// Token: 0x0600360D RID: 13837 RVA: 0x000ACEE8 File Offset: 0x000AB0E8
		public global::System.Data.Entity.Core.Objects.ObjectQuery<TResultType> CreateObjectQuery<TResultType>()
		{
			return new global::System.Data.Entity.Core.Objects.ObjectQuery<TResultType>(this);
		}

		// Token: 0x0400116C RID: 4460
		internal static readonly global::System.Data.Entity.Core.Objects.MergeOption DefaultMergeOption = global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly;

		// Token: 0x0400116D RID: 4461
		internal static readonly global::System.Reflection.MethodInfo CreateObjectQueryMethod = typeof(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState).GetOnlyDeclaredMethod("CreateObjectQuery");

		// Token: 0x0400116E RID: 4462
		private readonly global::System.Data.Entity.Core.Objects.ObjectContext _context;

		// Token: 0x0400116F RID: 4463
		private readonly global::System.Type _elementType;

		// Token: 0x04001170 RID: 4464
		private global::System.Data.Entity.Core.Objects.ObjectParameterCollection _parameters;

		// Token: 0x04001171 RID: 4465
		private readonly global::System.Data.Entity.Core.Objects.Span _span;

		// Token: 0x04001172 RID: 4466
		private global::System.Data.Entity.Core.Objects.MergeOption? _userMergeOption;

		// Token: 0x04001173 RID: 4467
		private bool _cachingEnabled = true;

		// Token: 0x04001174 RID: 4468
		protected global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan _cachedPlan;
	}
}
