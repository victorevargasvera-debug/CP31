using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Migrations.Design
{
	// Token: 0x020000E3 RID: 227
	public abstract class MigrationCodeGenerator
	{
		// Token: 0x06001141 RID: 4417
		public abstract global::System.Data.Entity.Migrations.Design.ScaffoldedMigration Generate(string migrationId, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> operations, string sourceModel, string targetModel, string @namespace, string className);

		// Token: 0x06001142 RID: 4418 RVA: 0x00029839 File Offset: 0x00027A39
		private static bool AnnotationsExist(global::System.Data.Entity.Migrations.Model.MigrationOperation[] operations)
		{
			return operations.OfType<global::System.Data.Entity.Migrations.Model.IAnnotationTarget>().Any((global::System.Data.Entity.Migrations.Model.IAnnotationTarget o) => o.HasAnnotations);
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00029868 File Offset: 0x00027A68
		protected virtual global::System.Collections.Generic.IEnumerable<string> GetNamespaces(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> operations)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation>>(operations, "operations");
			global::System.Collections.Generic.IEnumerable<string> enumerable = this.GetDefaultNamespaces(false);
			global::System.Data.Entity.Migrations.Model.MigrationOperation[] array = operations.ToArray<global::System.Data.Entity.Migrations.Model.MigrationOperation>();
			if (array.OfType<global::System.Data.Entity.Migrations.Model.AddColumnOperation>().Any((global::System.Data.Entity.Migrations.Model.AddColumnOperation o) => o.Column.Type == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography || o.Column.Type == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry))
			{
				enumerable = enumerable.Concat(new string[]
				{
					"System.Data.Entity.Spatial"
				});
			}
			if (array.OfType<global::System.Data.Entity.Migrations.Model.AddColumnOperation>().Any((global::System.Data.Entity.Migrations.Model.AddColumnOperation o) => o.Column.Type == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId))
			{
				enumerable = enumerable.Concat(new string[]
				{
					"System.Data.Entity.Hierarchy"
				});
			}
			if (global::System.Data.Entity.Migrations.Design.MigrationCodeGenerator.AnnotationsExist(array))
			{
				enumerable = enumerable.Concat(new string[]
				{
					"System.Collections.Generic",
					"System.Data.Entity.Infrastructure.Annotations"
				});
				enumerable = (from a in this.AnnotationGenerators
				select a.Value into g
				where g != null
				select g).Aggregate(enumerable, (global::System.Collections.Generic.IEnumerable<string> c, global::System.Func<global::System.Data.Entity.Infrastructure.Annotations.AnnotationCodeGenerator> g) => c.Concat(g().GetExtraNamespaces(this.AnnotationGenerators.Keys)));
			}
			return from n in enumerable.Distinct<string>()
			orderby n
			select n;
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x000299C4 File Offset: 0x00027BC4
		protected virtual global::System.Collections.Generic.IEnumerable<string> GetDefaultNamespaces(bool designer = false)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>
			{
				"System.Data.Entity.Migrations"
			};
			if (designer)
			{
				list.Add("System.CodeDom.Compiler");
				list.Add("System.Data.Entity.Migrations.Infrastructure");
				list.Add("System.Resources");
			}
			else
			{
				list.Add("System");
			}
			return from n in list
			orderby n
			select n;
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x00029A38 File Offset: 0x00027C38
		public virtual global::System.Collections.Generic.IDictionary<string, global::System.Func<global::System.Data.Entity.Infrastructure.Annotations.AnnotationCodeGenerator>> AnnotationGenerators
		{
			get
			{
				return this._annotationGenerators;
			}
		}

		// Token: 0x040008D5 RID: 2261
		private readonly global::System.Collections.Generic.IDictionary<string, global::System.Func<global::System.Data.Entity.Infrastructure.Annotations.AnnotationCodeGenerator>> _annotationGenerators = new global::System.Collections.Generic.Dictionary<string, global::System.Func<global::System.Data.Entity.Infrastructure.Annotations.AnnotationCodeGenerator>>();
	}
}
