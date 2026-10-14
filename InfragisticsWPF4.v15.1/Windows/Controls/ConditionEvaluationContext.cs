using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000165 RID: 357
	public abstract class ConditionEvaluationContext
	{
		// Token: 0x06000C2F RID: 3119 RVA: 0x00028778 File Offset: 0x00026978
		public ConditionEvaluationContext()
		{
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000C30 RID: 3120
		public abstract global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Controls.ValueEntry> AllValues { get; }

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000C31 RID: 3121
		public abstract global::Infragistics.Windows.Controls.ValueEntry CurrentValue { get; }

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x00028780 File Offset: 0x00026980
		public virtual global::System.Collections.IComparer Comparer
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000C33 RID: 3123
		public abstract bool IgnoreCase { get; }

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000C34 RID: 3124
		public abstract global::System.Type PreferredComparisonDataType { get; }

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x00028783 File Offset: 0x00026983
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x0002878B File Offset: 0x0002698B
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

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x00028794 File Offset: 0x00026994
		internal virtual global::Infragistics.Windows.Controls.IFilterEvaluator FilterEvaluator
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00028798 File Offset: 0x00026998
		public virtual object ConvertValue(object x, global::System.Type targetType)
		{
			if (x == null || global::System.DBNull.Value == x)
			{
				return x;
			}
			global::System.Type type = x.GetType();
			if (type == targetType)
			{
				return x;
			}
			if (global::Infragistics.Windows.Utilities.IsNumericType(targetType) && global::Infragistics.Windows.Utilities.IsNumericType(type))
			{
				try
				{
					return global::System.Convert.ChangeType(x, targetType);
				}
				catch
				{
				}
			}
			global::Infragistics.Windows.Controls.ValueEntry currentValue = this.CurrentValue;
			return global::Infragistics.CoreUtilities.ConvertDataValue(x, targetType, currentValue.Culture, currentValue.Format);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00028810 File Offset: 0x00026A10
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

		// Token: 0x06000C3A RID: 3130 RVA: 0x00028840 File Offset: 0x00026A40
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

		// Token: 0x040005D6 RID: 1494
		private object _userCache;

		// Token: 0x040005D7 RID: 1495
		private global::System.Collections.Generic.Dictionary<object, object> _userCacheTable;
	}
}
