using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003B7 RID: 951
	internal class MultipleDiscriminatorPolymorphicColumnMap : global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap
	{
		// Token: 0x06002DB6 RID: 11702 RVA: 0x00091354 File Offset: 0x0008F554
		internal MultipleDiscriminatorPolymorphicColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] baseTypeColumns, global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] typeDiscriminators, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> typeChoices, global::System.Func<object[], global::System.Data.Entity.Core.Metadata.Edm.EntityType> discriminate) : base(type, name, baseTypeColumns)
		{
			this.m_typeDiscriminators = typeDiscriminators;
			this.m_typeChoices = typeChoices;
			this.m_discriminate = discriminate;
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06002DB7 RID: 11703 RVA: 0x00091377 File Offset: 0x0008F577
		internal global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] TypeDiscriminators
		{
			get
			{
				return this.m_typeDiscriminators;
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06002DB8 RID: 11704 RVA: 0x0009137F File Offset: 0x0008F57F
		internal global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> TypeChoices
		{
			get
			{
				return this.m_typeChoices;
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06002DB9 RID: 11705 RVA: 0x00091387 File Offset: 0x0008F587
		internal global::System.Func<object[], global::System.Data.Entity.Core.Metadata.Edm.EntityType> Discriminate
		{
			get
			{
				return this.m_discriminate;
			}
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x0009138F File Offset: 0x0008F58F
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept<TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitor<TArgType> visitor, TArgType arg)
		{
			visitor.Visit(this, arg);
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x00091399 File Offset: 0x0008F599
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType, TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitorWithResults<TResultType, TArgType> visitor, TArgType arg)
		{
			return visitor.Visit(this, arg);
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x000913A4 File Offset: 0x0008F5A4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string text = string.Empty;
			stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "P{{TypeId=<{0}>, ", new object[]
			{
				global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedString(this.TypeDiscriminators)
			});
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> keyValuePair in this.TypeChoices)
			{
				stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "{0}(<{1}>,{2})", new object[]
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

		// Token: 0x04000F4A RID: 3914
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] m_typeDiscriminators;

		// Token: 0x04000F4B RID: 3915
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> m_typeChoices;

		// Token: 0x04000F4C RID: 3916
		private readonly global::System.Func<object[], global::System.Data.Entity.Core.Metadata.Edm.EntityType> m_discriminate;
	}
}
