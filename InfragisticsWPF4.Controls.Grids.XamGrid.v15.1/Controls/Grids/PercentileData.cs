using System;
using System.Collections;
using System.Linq;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200002E RID: 46
	public abstract class PercentileData
	{
		// Token: 0x06000224 RID: 548 RVA: 0x0000B72C File Offset: 0x0000992C
		protected internal static global::System.Type GetValueType(global::System.Type dataType)
		{
			if (dataType != null)
			{
				bool isGenericType = dataType.IsGenericType;
				if (isGenericType && dataType.GetGenericTypeDefinition().Equals(typeof(global::System.Nullable<>)))
				{
					global::System.Type underlyingType = global::System.Nullable.GetUnderlyingType(dataType);
					if (underlyingType.IsValueType)
					{
						return underlyingType;
					}
				}
			}
			return null;
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000B775 File Offset: 0x00009975
		// (set) Token: 0x06000226 RID: 550 RVA: 0x0000B77D File Offset: 0x0000997D
		protected global::System.Collections.IDictionary CalculatedValuesDictionary { get; set; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0000B786 File Offset: 0x00009986
		// (set) Token: 0x06000228 RID: 552 RVA: 0x0000B78E File Offset: 0x0000998E
		protected global::System.Collections.IList OriginalSortedList
		{
			get
			{
				return this._originalSortedList;
			}
			set
			{
				this._originalSortedList = value;
				this.OnOriginalSortedListSet();
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0000B79D File Offset: 0x0000999D
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0000B7A5 File Offset: 0x000099A5
		protected global::System.Linq.IQueryable CachedCastedList { get; set; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0000B7AE File Offset: 0x000099AE
		// (set) Token: 0x0600022C RID: 556 RVA: 0x0000B7B6 File Offset: 0x000099B6
		protected int ItemCount { get; set; }

		// Token: 0x0600022D RID: 557 RVA: 0x0000B7C0 File Offset: 0x000099C0
		public static global::Infragistics.Controls.Grids.PercentileData CreateGenericPercentileData(global::Infragistics.CachedTypedInfo objectDataType, string key, bool isDateColumn, global::System.Linq.IQueryable query)
		{
			global::System.Type type = global::Infragistics.DataManagerBase.ResolvePropertyTypeFromPropertyName(key, objectDataType);
			global::System.Type type2;
			if (type.GetInterface("IComparable", true) != null)
			{
				type2 = typeof(global::Infragistics.Controls.Grids.PercentileData<>).MakeGenericType(new global::System.Type[]
				{
					type
				});
			}
			else
			{
				global::System.Type valueType = global::Infragistics.Controls.Grids.PercentileData.GetValueType(type);
				type2 = typeof(global::Infragistics.Controls.Grids.PercentileData<, >).MakeGenericType(new global::System.Type[]
				{
					type,
					valueType
				});
			}
			global::Infragistics.Controls.Grids.PercentileData percentileData = (global::Infragistics.Controls.Grids.PercentileData)global::System.Activator.CreateInstance(type2, new object[0]);
			global::Infragistics.InformationContext informationContext = global::Infragistics.InformationContext.CreateGenericInformationContext(objectDataType, key, true, false, null, isDateColumn);
			percentileData.OriginalSortedList = informationContext.GetCompleteValuesList(query);
			return percentileData;
		}

		// Token: 0x0600022E RID: 558
		public abstract double GetPercentileValue(object dataValue);

		// Token: 0x0600022F RID: 559
		protected internal abstract double GetValueJustUnderPercentile(double percentile);

		// Token: 0x06000230 RID: 560
		protected internal abstract double GetValueJustOverPercentile(double percentile);

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0000B868 File Offset: 0x00009A68
		protected internal double CalculatedMinimumPercentileValue
		{
			get
			{
				double result = 0.0;
				if (this.OriginalSortedList.Count > 0)
				{
					result = this.GetPercentileValue(this.OriginalSortedList[0]);
				}
				return result;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0000B8A4 File Offset: 0x00009AA4
		protected internal double CalculatedMaximumPercentileValue
		{
			get
			{
				double result = 0.0;
				int count = this.OriginalSortedList.Count;
				if (count > 0)
				{
					result = this.GetPercentileValue(this.OriginalSortedList[count - 1]);
				}
				return result;
			}
		}

		// Token: 0x06000233 RID: 563
		protected abstract void OnOriginalSortedListSet();

		// Token: 0x04000093 RID: 147
		private global::System.Collections.IList _originalSortedList;
	}
}
