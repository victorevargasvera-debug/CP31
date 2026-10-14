using System;
using System.Linq.Expressions;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000E9 RID: 233
	public class FilterValueProxyRowsFilter : global::Infragistics.Controls.Grids.RowsFilter
	{
		// Token: 0x060007A8 RID: 1960 RVA: 0x0001FB4E File Offset: 0x0001DD4E
		public FilterValueProxyRowsFilter(global::System.Type objectType, global::Infragistics.CachedTypedInfo typeInfo)
		{
			base.ObjectType = objectType;
			base.ObjectTypedInfo = typeInfo;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0001FB64 File Offset: 0x0001DD64
		protected override global::System.Linq.Expressions.Expression GetCurrentExpression()
		{
			global::Infragistics.FilterContext context = global::Infragistics.FilterContext.CreateGenericFilter(base.ObjectTypedInfo, typeof(global::Infragistics.Controls.Grids.Primitives.FilterValueProxy), false, false);
			return this.GetCurrentExpression(context);
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x0001FB92 File Offset: 0x0001DD92
		public override string FieldName
		{
			get
			{
				return "ContentString";
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x0001FB99 File Offset: 0x0001DD99
		public override global::System.Type FieldType
		{
			get
			{
				return typeof(string);
			}
		}
	}
}
