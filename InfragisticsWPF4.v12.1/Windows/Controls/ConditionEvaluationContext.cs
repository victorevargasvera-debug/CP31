using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000147 RID: 327
	public abstract class ConditionEvaluationContext
	{
		// Token: 0x06000B2C RID: 2860 RVA: 0x00024BB4 File Offset: 0x00022DB4
		public ConditionEvaluationContext()
		{
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000B2D RID: 2861
		public abstract global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Controls.ValueEntry> AllValues { get; }

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000B2E RID: 2862
		public abstract global::Infragistics.Windows.Controls.ValueEntry CurrentValue { get; }

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x00024BBC File Offset: 0x00022DBC
		public virtual global::System.Collections.IComparer Comparer
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000B30 RID: 2864
		public abstract bool IgnoreCase { get; }

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000B31 RID: 2865
		public abstract global::System.Type PreferredComparisonDataType { get; }

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x00024BBF File Offset: 0x00022DBF
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x00024BC7 File Offset: 0x00022DC7
		[global::System.Obsolete("UserCache is replaced by GetUserCache and SetUserCache methods.", false)]
		public object UserCache
		{
			get
			{
				return this._userCache;
			}
			set
			{
				this._userCache = value;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x00024BD0 File Offset: 0x00022DD0
		internal virtual global::Infragistics.Windows.Controls.IFilterEvaluator FilterEvaluator
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00024BD4 File Offset: 0x00022DD4
		public object GetUserCache(object cacheIdentifier)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(cacheIdentifier);
			object result;
			if (this._userCacheTable != null && this._userCacheTable.TryGetValue(cacheIdentifier, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00024C04 File Offset: 0x00022E04
		public void SetUserCache(object cacheIdentifier, object cacheValue)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(cacheIdentifier);
			if (cacheValue == null)
			{
				if (this._userCacheTable != null)
				{
					this._userCacheTable.Remove(cacheIdentifier);
					return;
				}
			}
			else
			{
				if (this._userCacheTable == null)
				{
					this._userCacheTable = new global::System.Collections.Generic.Dictionary<object, object>();
				}
				this._userCacheTable[cacheIdentifier] = cacheValue;
			}
		}

		// Token: 0x0400051E RID: 1310
		private object _userCache;

		// Token: 0x0400051F RID: 1311
		private global::System.Collections.Generic.Dictionary<object, object> _userCacheTable;
	}
}
