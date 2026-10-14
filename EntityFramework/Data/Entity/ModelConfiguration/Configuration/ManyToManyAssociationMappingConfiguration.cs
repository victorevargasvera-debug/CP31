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
	// Token: 0x020001EF RID: 495
	public sealed class ManyToManyAssociationMappingConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.AssociationMappingConfiguration
	{
		// Token: 0x060019F7 RID: 6647 RVA: 0x00045578 File Offset: 0x00043778
		internal ManyToManyAssociationMappingConfiguration()
		{
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x000455A4 File Offset: 0x000437A4
		private ManyToManyAssociationMappingConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyAssociationMappingConfiguration source)
		{
			this._leftKeyColumnNames.AddRange(source._leftKeyColumnNames);
			this._rightKeyColumnNames.AddRange(source._rightKeyColumnNames);
			this._tableName = source._tableName;
			foreach (global::System.Collections.Generic.KeyValuePair<string, object> item in source._annotations)
			{
				this._annotations.Add(item);
			}
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x0004564C File Offset: 0x0004384C
		internal override global::System.Data.Entity.ModelConfiguration.Configuration.AssociationMappingConfiguration Clone()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyAssociationMappingConfiguration(this);
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x00045654 File Offset: 0x00043854
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyAssociationMappingConfiguration ToTable(string tableName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(tableName, "tableName");
			return this.ToTable(tableName, null);
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x0004566A File Offset: 0x0004386A
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyAssociationMappingConfiguration ToTable(string tableName, string schemaName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(tableName, "tableName");
			this._tableName = new global::System.Data.Entity.Utilities.DatabaseName(tableName, schemaName);
			return this;
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x00045686 File Offset: 0x00043886
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyAssociationMappingConfiguration HasTableAnnotation(string name, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			if (!name.IsValidUndottedName())
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.BadAnnotationName(name));
			}
			this._annotations[name] = value;
			return this;
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x000456B6 File Offset: 0x000438B6
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyAssociationMappingConfiguration MapLeftKey(params string[] keyColumnNames)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string[]>(keyColumnNames, "keyColumnNames");
			this._leftKeyColumnNames.Clear();
			this._leftKeyColumnNames.AddRange(keyColumnNames);
			return this;
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x000456DC File Offset: 0x000438DC
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyAssociationMappingConfiguration MapRightKey(params string[] keyColumnNames)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string[]>(keyColumnNames, "keyColumnNames");
			this._rightKeyColumnNames.Clear();
			this._rightKeyColumnNames.AddRange(keyColumnNames);
			return this;
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x00045704 File Offset: 0x00043904
		internal override void Configure(global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping, global::System.Data.Entity.Core.Metadata.Edm.EdmModel database, global::System.Reflection.PropertyInfo navigationProperty)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType table = associationSetMapping.Table;
			if (this._tableName != null)
			{
				table.SetTableName(this._tableName);
				table.SetConfiguration(this);
			}
			bool flag = navigationProperty.IsSameAs(associationSetMapping.SourceEndMapping.AssociationEnd.GetClrPropertyInfo());
			global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyAssociationMappingConfiguration.ConfigureColumnNames(flag ? this._leftKeyColumnNames : this._rightKeyColumnNames, associationSetMapping.SourceEndMapping.PropertyMappings.ToList<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping>());
			global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyAssociationMappingConfiguration.ConfigureColumnNames(flag ? this._rightKeyColumnNames : this._leftKeyColumnNames, associationSetMapping.TargetEndMapping.PropertyMappings.ToList<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping>());
			foreach (global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair in this._annotations)
			{
				table.AddAnnotation("http://schemas.microsoft.com/ado/2013/11/edm/customannotation:" + keyValuePair.Key, keyValuePair.Value);
			}
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x000457EC File Offset: 0x000439EC
		private static void ConfigureColumnNames(global::System.Collections.Generic.ICollection<string> keyColumnNames, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping> propertyMappings)
		{
			if (keyColumnNames.Count > 0 && keyColumnNames.Count != propertyMappings.Count)
			{
				throw global::System.Data.Entity.Resources.Error.IncorrectColumnCount(string.Join(", ", keyColumnNames));
			}
			keyColumnNames.Each(delegate(string n, int i)
			{
				propertyMappings[i].Column.Name = n;
			});
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x00045845 File Offset: 0x00043A45
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x00045850 File Offset: 0x00043A50
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool Equals(global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyAssociationMappingConfiguration other)
		{
			if (other == null)
			{
				return false;
			}
			if (this == other)
			{
				return true;
			}
			if (!object.Equals(other._tableName, this._tableName))
			{
				return false;
			}
			if (object.Equals(other._tableName, this._tableName) && ((this._leftKeyColumnNames.SequenceEqual(other._leftKeyColumnNames) && this._rightKeyColumnNames.SequenceEqual(other._rightKeyColumnNames)) || (this._leftKeyColumnNames.SequenceEqual(other._rightKeyColumnNames) && this._rightKeyColumnNames.SequenceEqual(other._leftKeyColumnNames))))
			{
				return (from a in this._annotations
				orderby a.Key
				select a).SequenceEqual(from a in other._annotations
				orderby a.Key
				select a);
			}
			return false;
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x0004593A File Offset: 0x00043B3A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return obj != null && (this == obj || (!(obj.GetType() != typeof(global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyAssociationMappingConfiguration)) && this.Equals((global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyAssociationMappingConfiguration)obj)));
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x0004596C File Offset: 0x00043B6C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			int seed = ((this._tableName != null) ? this._tableName.GetHashCode() : 0) * 397;
			seed = this._leftKeyColumnNames.Aggregate(seed, (int h, string v) => h * 397 ^ v.GetHashCode());
			seed = this._rightKeyColumnNames.Aggregate(seed, (int h, string v) => h * 397 ^ v.GetHashCode());
			return (from a in this._annotations
			orderby a.Key
			select a).Aggregate(seed, (int h, global::System.Collections.Generic.KeyValuePair<string, object> v) => h * 397 ^ v.GetHashCode());
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x00045A3D File Offset: 0x00043C3D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A8A RID: 2698
		private readonly global::System.Collections.Generic.List<string> _leftKeyColumnNames = new global::System.Collections.Generic.List<string>();

		// Token: 0x04000A8B RID: 2699
		private readonly global::System.Collections.Generic.List<string> _rightKeyColumnNames = new global::System.Collections.Generic.List<string>();

		// Token: 0x04000A8C RID: 2700
		private global::System.Data.Entity.Utilities.DatabaseName _tableName;

		// Token: 0x04000A8D RID: 2701
		private readonly global::System.Collections.Generic.IDictionary<string, object> _annotations = new global::System.Collections.Generic.Dictionary<string, object>();
	}
}
