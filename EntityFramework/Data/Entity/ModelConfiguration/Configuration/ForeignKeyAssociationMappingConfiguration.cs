using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001ED RID: 493
	public sealed class ForeignKeyAssociationMappingConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.AssociationMappingConfiguration
	{
		// Token: 0x060019E4 RID: 6628 RVA: 0x00044FCD File Offset: 0x000431CD
		internal ForeignKeyAssociationMappingConfiguration()
		{
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x00044FEC File Offset: 0x000431EC
		private ForeignKeyAssociationMappingConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyAssociationMappingConfiguration source)
		{
			this._keyColumnNames.AddRange(source._keyColumnNames);
			this._tableName = source._tableName;
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Tuple<string, string>, object> item in source._annotations)
			{
				this._annotations.Add(item);
			}
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x00045078 File Offset: 0x00043278
		internal override global::System.Data.Entity.ModelConfiguration.Configuration.AssociationMappingConfiguration Clone()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyAssociationMappingConfiguration(this);
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x00045080 File Offset: 0x00043280
		public global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyAssociationMappingConfiguration MapKey(params string[] keyColumnNames)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string[]>(keyColumnNames, "keyColumnNames");
			this._keyColumnNames.Clear();
			this._keyColumnNames.AddRange(keyColumnNames);
			return this;
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x000450A6 File Offset: 0x000432A6
		public global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyAssociationMappingConfiguration HasColumnAnnotation(string keyColumnName, string annotationName, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(keyColumnName, "keyColumnName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(annotationName, "annotationName");
			this._annotations[global::System.Tuple.Create<string, string>(keyColumnName, annotationName)] = value;
			return this;
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x000450D4 File Offset: 0x000432D4
		public global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyAssociationMappingConfiguration ToTable(string tableName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(tableName, "tableName");
			return this.ToTable(tableName, null);
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x000450EA File Offset: 0x000432EA
		public global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyAssociationMappingConfiguration ToTable(string tableName, string schemaName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(tableName, "tableName");
			this._tableName = new global::System.Data.Entity.Utilities.DatabaseName(tableName, schemaName);
			return this;
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x00045108 File Offset: 0x00043308
		internal override void Configure(global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping, global::System.Data.Entity.Core.Metadata.Edm.EdmModel database, global::System.Reflection.PropertyInfo navigationProperty)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping> propertyMappings = associationSetMapping.SourceEndMapping.PropertyMappings.ToList<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping>();
			if (this._tableName != null)
			{
				global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyAssociationMappingConfiguration.<>c__DisplayClass10_1 CS$<>8__locals2 = new global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyAssociationMappingConfiguration.<>c__DisplayClass10_1();
				global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyAssociationMappingConfiguration.<>c__DisplayClass10_1 CS$<>8__locals3 = CS$<>8__locals2;
				global::System.Data.Entity.Core.Metadata.Edm.EntityType targetTable;
				if ((targetTable = (from t in database.EntityTypes
				let n = t.GetTableName()
				where n != null && n.Equals(this._tableName)
				select t).SingleOrDefault<global::System.Data.Entity.Core.Metadata.Edm.EntityType>()) == null)
				{
					targetTable = (from es in database.GetEntitySets()
					where string.Equals(es.Table, this._tableName.Name, global::System.StringComparison.Ordinal)
					select es.ElementType).SingleOrDefault<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
				}
				CS$<>8__locals3.targetTable = targetTable;
				if (CS$<>8__locals2.targetTable == null)
				{
					throw global::System.Data.Entity.Resources.Error.TableNotFound(this._tableName);
				}
				CS$<>8__locals2.sourceTable = associationSetMapping.Table;
				if (CS$<>8__locals2.sourceTable != CS$<>8__locals2.targetTable)
				{
					global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder foreignKeyBuilder = CS$<>8__locals2.sourceTable.ForeignKeyBuilders.Single((global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk) => fk.DependentColumns.SequenceEqual(from pm in propertyMappings
					select pm.Column));
					CS$<>8__locals2.sourceTable.RemoveForeignKey(foreignKeyBuilder);
					CS$<>8__locals2.targetTable.AddForeignKey(foreignKeyBuilder);
					foreignKeyBuilder.DependentColumns.Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty c)
					{
						bool isPrimaryKeyColumn = c.IsPrimaryKeyColumn;
						CS$<>8__locals2.sourceTable.RemoveMember(c);
						CS$<>8__locals2.targetTable.AddMember(c);
						if (isPrimaryKeyColumn)
						{
							CS$<>8__locals2.targetTable.AddKeyMember(c);
						}
					});
					associationSetMapping.StoreEntitySet = database.GetEntitySet(CS$<>8__locals2.targetTable);
				}
			}
			if (this._keyColumnNames.Count > 0 && this._keyColumnNames.Count != propertyMappings.Count<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping>())
			{
				throw global::System.Data.Entity.Resources.Error.IncorrectColumnCount(string.Join(", ", this._keyColumnNames));
			}
			this._keyColumnNames.Each(delegate(string n, int i)
			{
				propertyMappings[i].Column.Name = n;
			});
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Tuple<string, string>, object> keyValuePair in this._annotations)
			{
				int num = this._keyColumnNames.IndexOf(keyValuePair.Key.Item1);
				if (num == -1)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.BadKeyNameForAnnotation(keyValuePair.Key.Item1, keyValuePair.Key.Item2));
				}
				propertyMappings[num].Column.AddAnnotation("http://schemas.microsoft.com/ado/2013/11/edm/customannotation:" + keyValuePair.Key.Item2, keyValuePair.Value);
			}
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x00045388 File Offset: 0x00043588
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x00045390 File Offset: 0x00043590
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool Equals(global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyAssociationMappingConfiguration other)
		{
			if (other == null)
			{
				return false;
			}
			if (this == other)
			{
				return true;
			}
			if (object.Equals(other._tableName, this._tableName) && other._keyColumnNames.SequenceEqual(this._keyColumnNames))
			{
				return (from a in other._annotations
				orderby a.Key
				select a).SequenceEqual(from a in this._annotations
				orderby a.Key
				select a);
			}
			return false;
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x00045429 File Offset: 0x00043629
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return obj != null && (this == obj || (!(obj.GetType() != typeof(global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyAssociationMappingConfiguration)) && this.Equals((global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyAssociationMappingConfiguration)obj)));
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x0004545C File Offset: 0x0004365C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			int seed = ((this._tableName != null) ? this._tableName.GetHashCode() : 0) * 397;
			seed = this._keyColumnNames.Aggregate(seed, (int h, string v) => h * 397 ^ v.GetHashCode());
			return (from a in this._annotations
			orderby a.Key
			select a).Aggregate(seed, (int h, global::System.Collections.Generic.KeyValuePair<global::System.Tuple<string, string>, object> v) => h * 397 ^ v.GetHashCode());
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00045501 File Offset: 0x00043701
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A87 RID: 2695
		private readonly global::System.Collections.Generic.List<string> _keyColumnNames = new global::System.Collections.Generic.List<string>();

		// Token: 0x04000A88 RID: 2696
		private readonly global::System.Collections.Generic.IDictionary<global::System.Tuple<string, string>, object> _annotations = new global::System.Collections.Generic.Dictionary<global::System.Tuple<string, string>, object>();

		// Token: 0x04000A89 RID: 2697
		private global::System.Data.Entity.Utilities.DatabaseName _tableName;
	}
}
