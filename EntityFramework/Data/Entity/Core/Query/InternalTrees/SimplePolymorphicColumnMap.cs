using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003E7 RID: 999
	internal class SimplePolymorphicColumnMap : global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap
	{
		// Token: 0x06002F0D RID: 12045 RVA: 0x00094617 File Offset: 0x00092817
		internal SimplePolymorphicColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] baseTypeColumns, global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap typeDiscriminator, global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> typeChoices) : base(type, name, baseTypeColumns)
		{
			this.m_typedColumnMap = typeChoices;
			this.m_typeDiscriminator = typeDiscriminator;
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06002F0E RID: 12046 RVA: 0x00094632 File Offset: 0x00092832
		internal global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap TypeDiscriminator
		{
			get
			{
				return this.m_typeDiscriminator;
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06002F0F RID: 12047 RVA: 0x0009463A File Offset: 0x0009283A
		internal global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> TypeChoices
		{
			get
			{
				return this.m_typedColumnMap;
			}
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x00094642 File Offset: 0x00092842
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept<TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitor<TArgType> visitor, TArgType arg)
		{
			visitor.Visit(this, arg);
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x0009464C File Offset: 0x0009284C
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType, TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitorWithResults<TResultType, TArgType> visitor, TArgType arg)
		{
			return visitor.Visit(this, arg);
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x00094658 File Offset: 0x00092858
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string text = string.Empty;
			stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "P{{TypeId={0}, ", new object[]
			{
				this.TypeDiscriminator
			});
			foreach (global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> keyValuePair in this.TypeChoices)
			{
				stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "{0}({1},{2})", new object[]
				{
					text,
					keyValuePair.Key,
					keyValuePair.Value
				});
				text = ",";
			}
			stringBuilder.Append("}");
			return stringBuilder.ToString();
		}

		// Token: 0x04000FDB RID: 4059
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap m_typeDiscriminator;

		// Token: 0x04000FDC RID: 4060
		private readonly global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> m_typedColumnMap;
	}
}
