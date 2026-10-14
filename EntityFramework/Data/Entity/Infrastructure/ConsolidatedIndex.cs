using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200021B RID: 539
	internal class ConsolidatedIndex
	{
		// Token: 0x06001C53 RID: 7251 RVA: 0x000503BB File Offset: 0x0004E5BB
		public ConsolidatedIndex(string table, global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute index)
		{
			this._table = table;
			this._index = index;
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x000503DC File Offset: 0x0004E5DC
		public ConsolidatedIndex(string table, string column, global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute index) : this(table, index)
		{
			this._columns[index.Order] = column;
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x000503F8 File Offset: 0x0004E5F8
		public static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Infrastructure.ConsolidatedIndex> BuildIndexes(string tableName, global::System.Collections.Generic.IEnumerable<global::System.Tuple<string, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>> columns)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Infrastructure.ConsolidatedIndex> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Infrastructure.ConsolidatedIndex>();
			foreach (global::System.Tuple<string, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> tuple in columns)
			{
				using (global::System.Collections.Generic.IEnumerator<global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute> enumerator2 = (from a in tuple.Item2.Annotations
				where a.Name == "http://schemas.microsoft.com/ado/2013/11/edm/customannotation:Index"
				select a.Value).OfType<global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation>().SelectMany((global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation a) => a.Indexes).GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute index = enumerator2.Current;
						global::System.Data.Entity.Infrastructure.ConsolidatedIndex consolidatedIndex = (index.Name == null) ? null : list.FirstOrDefault((global::System.Data.Entity.Infrastructure.ConsolidatedIndex i) => i.Index.Name == index.Name);
						if (consolidatedIndex == null)
						{
							list.Add(new global::System.Data.Entity.Infrastructure.ConsolidatedIndex(tableName, tuple.Item1, index));
						}
						else
						{
							consolidatedIndex.Add(tuple.Item1, index);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001C56 RID: 7254 RVA: 0x00050570 File Offset: 0x0004E770
		public global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute Index
		{
			get
			{
				return this._index;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x00050578 File Offset: 0x0004E778
		public global::System.Collections.Generic.IEnumerable<string> Columns
		{
			get
			{
				return from c in this._columns
				orderby c.Key
				select c.Value;
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x000505D3 File Offset: 0x0004E7D3
		public string Table
		{
			get
			{
				return this._table;
			}
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x000505DC File Offset: 0x0004E7DC
		public void Add(string columnName, global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute index)
		{
			if (this._columns.ContainsKey(index.Order))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.OrderConflictWhenConsolidating(index.Name, this._table, index.Order, this._columns[index.Order], columnName));
			}
			this._columns[index.Order] = columnName;
			global::System.Data.Entity.Infrastructure.Annotations.CompatibilityResult compatibilityResult = this._index.IsCompatibleWith(index, true);
			if (!compatibilityResult)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ConflictWhenConsolidating(index.Name, this._table, compatibilityResult.ErrorMessage));
			}
			this._index = this._index.MergeWith(index, true);
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x00050688 File Offset: 0x0004E888
		public global::System.Data.Entity.Migrations.Model.CreateIndexOperation CreateCreateIndexOperation()
		{
			string[] array = this.Columns.ToArray<string>();
			global::System.Data.Entity.Migrations.Model.CreateIndexOperation createIndexOperation = new global::System.Data.Entity.Migrations.Model.CreateIndexOperation(null)
			{
				Name = (this._index.Name ?? global::System.Data.Entity.Migrations.Model.IndexOperation.BuildDefaultName(array)),
				Table = this._table
			};
			foreach (string item in array)
			{
				createIndexOperation.Columns.Add(item);
			}
			if (this._index.IsClusteredConfigured)
			{
				createIndexOperation.IsClustered = this._index.IsClustered;
			}
			if (this._index.IsUniqueConfigured)
			{
				createIndexOperation.IsUnique = this._index.IsUnique;
			}
			return createIndexOperation;
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x0005072E File Offset: 0x0004E92E
		public global::System.Data.Entity.Migrations.Model.DropIndexOperation CreateDropIndexOperation()
		{
			return (global::System.Data.Entity.Migrations.Model.DropIndexOperation)this.CreateCreateIndexOperation().Inverse;
		}

		// Token: 0x04000AEF RID: 2799
		private readonly string _table;

		// Token: 0x04000AF0 RID: 2800
		private global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute _index;

		// Token: 0x04000AF1 RID: 2801
		private readonly global::System.Collections.Generic.IDictionary<int, string> _columns = new global::System.Collections.Generic.Dictionary<int, string>();
	}
}
