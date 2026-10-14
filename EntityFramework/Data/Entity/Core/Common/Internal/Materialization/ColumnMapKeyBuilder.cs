using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.ELinq;
using System.Data.Entity.Core.Objects.Internal;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Globalization;
using System.Text;

namespace System.Data.Entity.Core.Common.Internal.Materialization
{
	// Token: 0x02000635 RID: 1589
	internal class ColumnMapKeyBuilder : global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitor<int>
	{
		// Token: 0x06004C90 RID: 19600 RVA: 0x0010D999 File Offset: 0x0010BB99
		private ColumnMapKeyBuilder(global::System.Data.Entity.Core.Objects.Internal.SpanIndex spanIndex)
		{
			this._spanIndex = spanIndex;
		}

		// Token: 0x06004C91 RID: 19601 RVA: 0x0010D9B4 File Offset: 0x0010BBB4
		internal static string GetColumnMapKey(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap, global::System.Data.Entity.Core.Objects.Internal.SpanIndex spanIndex)
		{
			global::System.Data.Entity.Core.Common.Internal.Materialization.ColumnMapKeyBuilder columnMapKeyBuilder = new global::System.Data.Entity.Core.Common.Internal.Materialization.ColumnMapKeyBuilder(spanIndex);
			columnMap.Accept<int>(columnMapKeyBuilder, 0);
			return columnMapKeyBuilder._builder.ToString();
		}

		// Token: 0x06004C92 RID: 19602 RVA: 0x0010D9DB File Offset: 0x0010BBDB
		internal void Append(string value)
		{
			this._builder.Append(value);
		}

		// Token: 0x06004C93 RID: 19603 RVA: 0x0010D9EA File Offset: 0x0010BBEA
		internal void Append(string prefix, global::System.Type type)
		{
			this.Append(prefix, type.AssemblyQualifiedName);
		}

		// Token: 0x06004C94 RID: 19604 RVA: 0x0010D9FC File Offset: 0x0010BBFC
		internal void Append(string prefix, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			if (type != null)
			{
				global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata initializerMetadata;
				if (global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.TryGetInitializerMetadata(type, out initializerMetadata))
				{
					initializerMetadata.AppendColumnMapKey(this);
				}
				this.Append(prefix, type.EdmType);
			}
		}

		// Token: 0x06004C95 RID: 19605 RVA: 0x0010DA2C File Offset: 0x0010BC2C
		internal void Append(string prefix, global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			if (type != null)
			{
				this.Append(prefix, type.NamespaceName);
				this.Append(".", type.Name);
				if (type.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType && this._spanIndex != null)
				{
					this.Append("<<");
					global::System.Collections.Generic.Dictionary<int, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> spanMap = this._spanIndex.GetSpanMap((global::System.Data.Entity.Core.Metadata.Edm.RowType)type);
					if (spanMap != null)
					{
						string value = string.Empty;
						foreach (global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> keyValuePair in spanMap)
						{
							this.Append(value);
							this.AppendValue("C", keyValuePair.Key);
							this.Append(":", keyValuePair.Value.DeclaringType);
							this.Append(".", keyValuePair.Value.Name);
							value = ",";
						}
					}
					this.Append(">>");
				}
			}
		}

		// Token: 0x06004C96 RID: 19606 RVA: 0x0010DB38 File Offset: 0x0010BD38
		private void Append(string prefix, string value)
		{
			this.Append(prefix);
			this.Append("'");
			this.Append(value);
			this.Append("'");
		}

		// Token: 0x06004C97 RID: 19607 RVA: 0x0010DB5E File Offset: 0x0010BD5E
		private void Append(string prefix, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap)
		{
			this.Append(prefix);
			this.Append("[");
			if (columnMap != null)
			{
				columnMap.Accept<int>(this, 0);
			}
			this.Append("]");
		}

		// Token: 0x06004C98 RID: 19608 RVA: 0x0010DB88 File Offset: 0x0010BD88
		private void Append(string prefix, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap> elements)
		{
			this.Append(prefix);
			this.Append("{");
			if (elements != null)
			{
				string prefix2 = string.Empty;
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap in elements)
				{
					this.Append(prefix2, columnMap);
					prefix2 = ",";
				}
			}
			this.Append("}");
		}

		// Token: 0x06004C99 RID: 19609 RVA: 0x0010DC00 File Offset: 0x0010BE00
		private void Append(string prefix, global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity entityIdentity)
		{
			this.Append(prefix);
			this.Append("[");
			this.Append(",K", entityIdentity.Keys);
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleEntityIdentity simpleEntityIdentity = entityIdentity as global::System.Data.Entity.Core.Query.InternalTrees.SimpleEntityIdentity;
			if (simpleEntityIdentity != null)
			{
				this.Append(",", simpleEntityIdentity.EntitySet);
			}
			else
			{
				global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedEntityIdentity discriminatedEntityIdentity = (global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedEntityIdentity)entityIdentity;
				this.Append("CM", discriminatedEntityIdentity.EntitySetColumnMap);
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet in discriminatedEntityIdentity.EntitySetMap)
				{
					this.Append(",E", entitySet);
				}
			}
			this.Append("]");
		}

		// Token: 0x06004C9A RID: 19610 RVA: 0x0010DC97 File Offset: 0x0010BE97
		private void Append(string prefix, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			if (entitySet != null)
			{
				this.Append(prefix, entitySet.EntityContainer.Name);
				this.Append(".", entitySet.Name);
			}
		}

		// Token: 0x06004C9B RID: 19611 RVA: 0x0010DCBF File Offset: 0x0010BEBF
		private void AppendValue(string prefix, object value)
		{
			this.Append(prefix, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}", new object[]
			{
				value
			}));
		}

		// Token: 0x06004C9C RID: 19612 RVA: 0x0010DCE1 File Offset: 0x0010BEE1
		internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ComplexTypeColumnMap columnMap, int dummy)
		{
			this.Append("C-", columnMap.Type);
			this.Append(",N", columnMap.NullSentinel);
			this.Append(",P", columnMap.Properties);
		}

		// Token: 0x06004C9D RID: 19613 RVA: 0x0010DD18 File Offset: 0x0010BF18
		internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedCollectionColumnMap columnMap, int dummy)
		{
			this.Append("DC-D", columnMap.Discriminator);
			this.AppendValue(",DV", columnMap.DiscriminatorValue);
			this.Append(",FK", columnMap.ForeignKeys);
			this.Append(",K", columnMap.Keys);
			this.Append(",E", columnMap.Element);
		}

		// Token: 0x06004C9E RID: 19614 RVA: 0x0010DD7C File Offset: 0x0010BF7C
		internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.EntityColumnMap columnMap, int dummy)
		{
			this.Append("E-", columnMap.Type);
			this.Append(",N", columnMap.NullSentinel);
			this.Append(",P", columnMap.Properties);
			this.Append(",I", columnMap.EntityIdentity);
		}

		// Token: 0x06004C9F RID: 19615 RVA: 0x0010DDD0 File Offset: 0x0010BFD0
		internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.SimplePolymorphicColumnMap columnMap, int dummy)
		{
			this.Append("SP-", columnMap.Type);
			this.Append(",D", columnMap.TypeDiscriminator);
			this.Append(",N", columnMap.NullSentinel);
			this.Append(",P", columnMap.Properties);
			foreach (global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> keyValuePair in columnMap.TypeChoices)
			{
				this.AppendValue(",K", keyValuePair.Key);
				this.Append(":", keyValuePair.Value);
			}
		}

		// Token: 0x06004CA0 RID: 19616 RVA: 0x0010DE84 File Offset: 0x0010C084
		internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.RecordColumnMap columnMap, int dummy)
		{
			this.Append("R-", columnMap.Type);
			this.Append(",N", columnMap.NullSentinel);
			this.Append(",P", columnMap.Properties);
		}

		// Token: 0x06004CA1 RID: 19617 RVA: 0x0010DEBC File Offset: 0x0010C0BC
		internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.RefColumnMap columnMap, int dummy)
		{
			this.Append("Ref-", columnMap.EntityIdentity);
			global::System.Data.Entity.Core.Metadata.Edm.EntityType type;
			global::System.Data.Entity.Core.Common.TypeHelpers.TryGetRefEntityType(columnMap.Type, out type);
			this.Append(",T", type);
		}

		// Token: 0x06004CA2 RID: 19618 RVA: 0x0010DEF4 File Offset: 0x0010C0F4
		internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap columnMap, int dummy)
		{
			string value = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "S({0}-{1}:{2})", new object[]
			{
				columnMap.CommandId,
				columnMap.ColumnPos,
				columnMap.Type.Identity
			});
			this.Append(value);
		}

		// Token: 0x06004CA3 RID: 19619 RVA: 0x0010DF48 File Offset: 0x0010C148
		internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap columnMap, int dummy)
		{
			this.Append("DC-FK", columnMap.ForeignKeys);
			this.Append(",K", columnMap.Keys);
			this.Append(",E", columnMap.Element);
		}

		// Token: 0x06004CA4 RID: 19620 RVA: 0x0010DF7D File Offset: 0x0010C17D
		internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap columnMap, int dummy)
		{
		}

		// Token: 0x06004CA5 RID: 19621 RVA: 0x0010DF7F File Offset: 0x0010C17F
		internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.MultipleDiscriminatorPolymorphicColumnMap columnMap, int dummy)
		{
			this.Append(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "MD-{0}", new object[]
			{
				global::System.Guid.NewGuid()
			}));
		}

		// Token: 0x04001B16 RID: 6934
		private readonly global::System.Text.StringBuilder _builder = new global::System.Text.StringBuilder();

		// Token: 0x04001B17 RID: 6935
		private readonly global::System.Data.Entity.Core.Objects.Internal.SpanIndex _spanIndex;
	}
}
