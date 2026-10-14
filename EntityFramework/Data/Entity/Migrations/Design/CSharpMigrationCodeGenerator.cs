using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Utilities;
using System.Data.Entity.Resources;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Microsoft.CSharp;
using Microsoft.CSharp.RuntimeBinder;

namespace System.Data.Entity.Migrations.Design
{
	// Token: 0x020000E2 RID: 226
	public class CSharpMigrationCodeGenerator : global::System.Data.Entity.Migrations.Design.MigrationCodeGenerator
	{
		// Token: 0x06001107 RID: 4359 RVA: 0x00026E8C File Offset: 0x0002508C
		public override global::System.Data.Entity.Migrations.Design.ScaffoldedMigration Generate(string migrationId, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> operations, string sourceModel, string targetModel, string @namespace, string className)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(migrationId, "migrationId");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation>>(operations, "operations");
			global::System.Data.Entity.Utilities.Check.NotEmpty(targetModel, "targetModel");
			global::System.Data.Entity.Utilities.Check.NotEmpty(className, "className");
			className = this.ScrubName(className);
			this._newTableForeignKeys = (from ct in operations.OfType<global::System.Data.Entity.Migrations.Model.CreateTableOperation>()
			from cfk in operations.OfType<global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation>()
			where ct.Name.EqualsIgnoreCase(cfk.DependentTable)
			select global::System.Tuple.Create<global::System.Data.Entity.Migrations.Model.CreateTableOperation, global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation>(ct, cfk)).ToList<global::System.Tuple<global::System.Data.Entity.Migrations.Model.CreateTableOperation, global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation>>();
			this._newTableIndexes = (from ct in operations.OfType<global::System.Data.Entity.Migrations.Model.CreateTableOperation>()
			from ci in operations.OfType<global::System.Data.Entity.Migrations.Model.CreateIndexOperation>()
			where ct.Name.EqualsIgnoreCase(ci.Table)
			select global::System.Tuple.Create<global::System.Data.Entity.Migrations.Model.CreateTableOperation, global::System.Data.Entity.Migrations.Model.CreateIndexOperation>(ct, ci)).ToList<global::System.Tuple<global::System.Data.Entity.Migrations.Model.CreateTableOperation, global::System.Data.Entity.Migrations.Model.CreateIndexOperation>>();
			global::System.Data.Entity.Migrations.Design.ScaffoldedMigration scaffoldedMigration = new global::System.Data.Entity.Migrations.Design.ScaffoldedMigration
			{
				MigrationId = migrationId,
				Language = "cs",
				UserCode = this.Generate(operations, @namespace, className),
				DesignerCode = this.Generate(migrationId, sourceModel, targetModel, @namespace, className)
			};
			if (!string.IsNullOrWhiteSpace(sourceModel))
			{
				scaffoldedMigration.Resources.Add("Source", sourceModel);
			}
			scaffoldedMigration.Resources.Add("Target", targetModel);
			return scaffoldedMigration;
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00027074 File Offset: 0x00025274
		protected virtual string Generate(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> operations, string @namespace, string className)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation>>(operations, "operations");
			global::System.Data.Entity.Utilities.Check.NotEmpty(className, "className");
			string result;
			using (global::System.IO.StringWriter stringWriter = new global::System.IO.StringWriter(global::System.Globalization.CultureInfo.InvariantCulture))
			{
				using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer = new global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter(stringWriter))
				{
					this.WriteClassStart(@namespace, className, writer, "DbMigration", false, this.GetNamespaces(operations));
					writer.WriteLine("public override void Up()");
					writer.WriteLine("{");
					global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer5 = writer;
					int indent = writer5.Indent;
					writer5.Indent = indent + 1;
					operations.Except(from t in this._newTableForeignKeys
					select t.Item2).Except(from t in this._newTableIndexes
					select t.Item2).Each(delegate(dynamic o)
					{
						if (global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__3.<>p__0 == null)
						{
							global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__3.<>p__0 = global::System.Runtime.CompilerServices.CallSite<global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator, object, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.InvokeSimpleName | global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.ResultDiscarded, "Generate", null, typeof(global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
							{
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null),
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__3.<>p__0.Target(global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__3.<>p__0, this, o, writer);
					});
					global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer2 = writer;
					indent = writer2.Indent;
					writer2.Indent = indent - 1;
					writer.WriteLine("}");
					writer.WriteLine();
					writer.WriteLine("public override void Down()");
					writer.WriteLine("{");
					global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer3 = writer;
					indent = writer3.Indent;
					writer3.Indent = indent + 1;
					operations = (from o in operations
					select o.Inverse into o
					where o != null
					select o).Reverse<global::System.Data.Entity.Migrations.Model.MigrationOperation>();
					bool flag = operations.Any((global::System.Data.Entity.Migrations.Model.MigrationOperation o) => o is global::System.Data.Entity.Migrations.Model.NotSupportedOperation);
					(from o in operations
					where !(o is global::System.Data.Entity.Migrations.Model.NotSupportedOperation)
					select o).Each(delegate(dynamic o)
					{
						if (global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__3.<>p__1 == null)
						{
							global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__3.<>p__1 = global::System.Runtime.CompilerServices.CallSite<global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator, object, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.InvokeSimpleName | global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.ResultDiscarded, "Generate", null, typeof(global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
							{
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null),
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__3.<>p__1.Target(global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__3.<>p__1, this, o, writer);
					});
					if (flag)
					{
						writer.Write("throw new NotSupportedException(");
						writer.Write(this.Generate(global::System.Data.Entity.Resources.Strings.ScaffoldSprocInDownNotSupported));
						writer.WriteLine(");");
					}
					global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer4 = writer;
					indent = writer4.Indent;
					writer4.Indent = indent - 1;
					writer.WriteLine("}");
					this.WriteClassEnd(@namespace, writer);
				}
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00027358 File Offset: 0x00025558
		protected virtual string Generate(string migrationId, string sourceModel, string targetModel, string @namespace, string className)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(migrationId, "migrationId");
			global::System.Data.Entity.Utilities.Check.NotEmpty(targetModel, "targetModel");
			global::System.Data.Entity.Utilities.Check.NotEmpty(className, "className");
			string result;
			using (global::System.IO.StringWriter stringWriter = new global::System.IO.StringWriter(global::System.Globalization.CultureInfo.InvariantCulture))
			{
				using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = new global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter(stringWriter))
				{
					indentedTextWriter.WriteLine("// <auto-generated />");
					this.WriteClassStart(@namespace, className, indentedTextWriter, "IMigrationMetadata", true, null);
					indentedTextWriter.Write("private readonly ResourceManager Resources = new ResourceManager(typeof(");
					indentedTextWriter.Write(className);
					indentedTextWriter.WriteLine("));");
					indentedTextWriter.WriteLine();
					this.WriteProperty("Id", this.Quote(migrationId), indentedTextWriter);
					indentedTextWriter.WriteLine();
					this.WriteProperty("Source", (sourceModel == null) ? null : "Resources.GetString(\"Source\")", indentedTextWriter);
					indentedTextWriter.WriteLine();
					this.WriteProperty("Target", "Resources.GetString(\"Target\")", indentedTextWriter);
					this.WriteClassEnd(@namespace, indentedTextWriter);
				}
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0002746C File Offset: 0x0002566C
		protected virtual void WriteProperty(string name, string value, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("string IMigrationMetadata.");
			writer.WriteLine(name);
			writer.WriteLine("{");
			int indent = writer.Indent;
			writer.Indent = indent + 1;
			writer.Write("get { return ");
			writer.Write(value ?? "null");
			writer.WriteLine("; }");
			indent = writer.Indent;
			writer.Indent = indent - 1;
			writer.WriteLine("}");
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x000274FF File Offset: 0x000256FF
		protected virtual void WriteClassAttributes(global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer, bool designer)
		{
			if (designer)
			{
				writer.WriteLine("[GeneratedCode(\"EntityFramework.Migrations\", \"{0}\")]", typeof(global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator).Assembly().GetInformationalVersion());
			}
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x00027524 File Offset: 0x00025724
		protected virtual void WriteClassStart(string @namespace, string className, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer, string @base, bool designer = false, global::System.Collections.Generic.IEnumerable<string> namespaces = null)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			global::System.Data.Entity.Utilities.Check.NotEmpty(className, "className");
			global::System.Data.Entity.Utilities.Check.NotEmpty(@base, "base");
			int indent;
			if (!string.IsNullOrWhiteSpace(@namespace))
			{
				writer.Write("namespace ");
				writer.WriteLine(@namespace);
				writer.WriteLine("{");
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer2 = writer;
				indent = writer2.Indent;
				writer2.Indent = indent + 1;
			}
			(namespaces ?? this.GetDefaultNamespaces(designer)).Each(delegate(string n)
			{
				writer.WriteLine("using " + n + ";");
			});
			writer.WriteLine();
			this.WriteClassAttributes(writer, designer);
			writer.Write("public ");
			if (designer)
			{
				writer.Write("sealed ");
			}
			writer.Write("partial class ");
			writer.Write(className);
			writer.Write(" : ");
			writer.Write(@base);
			writer.WriteLine();
			writer.WriteLine("{");
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer3 = writer;
			indent = writer3.Indent;
			writer3.Indent = indent + 1;
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00027678 File Offset: 0x00025878
		protected virtual void WriteClassEnd(string @namespace, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			int indent = writer.Indent;
			writer.Indent = indent - 1;
			writer.WriteLine("}");
			if (!string.IsNullOrWhiteSpace(@namespace))
			{
				indent = writer.Indent;
				writer.Indent = indent - 1;
				writer.WriteLine("}");
			}
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x000276D0 File Offset: 0x000258D0
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.AddColumnOperation addColumnOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.AddColumnOperation>(addColumnOperation, "addColumnOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("AddColumn(");
			writer.Write(this.Quote(addColumnOperation.Table));
			writer.Write(", ");
			writer.Write(this.Quote(addColumnOperation.Column.Name));
			writer.Write(", c =>");
			this.Generate(addColumnOperation.Column, writer, false);
			writer.WriteLine(");");
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x00027758 File Offset: 0x00025958
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.DropColumnOperation dropColumnOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.DropColumnOperation>(dropColumnOperation, "dropColumnOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("DropColumn(");
			writer.Write(this.Quote(dropColumnOperation.Table));
			writer.Write(", ");
			writer.Write(this.Quote(dropColumnOperation.Name));
			if (dropColumnOperation.RemovedAnnotations.Any<global::System.Collections.Generic.KeyValuePair<string, object>>())
			{
				int indent = writer.Indent;
				writer.Indent = indent + 1;
				writer.WriteLine(",");
				writer.Write("removedAnnotations: ");
				this.GenerateAnnotations(dropColumnOperation.RemovedAnnotations, writer);
				indent = writer.Indent;
				writer.Indent = indent - 1;
			}
			writer.WriteLine(");");
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x00027814 File Offset: 0x00025A14
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.AlterColumnOperation alterColumnOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.AlterColumnOperation>(alterColumnOperation, "alterColumnOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("AlterColumn(");
			writer.Write(this.Quote(alterColumnOperation.Table));
			writer.Write(", ");
			writer.Write(this.Quote(alterColumnOperation.Column.Name));
			writer.Write(", c =>");
			this.Generate(alterColumnOperation.Column, writer, false);
			writer.WriteLine(");");
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x0002789C File Offset: 0x00025A9C
		protected internal virtual void GenerateAnnotations(global::System.Collections.Generic.IDictionary<string, object> annotations, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IDictionary<string, object>>(annotations, "annotations");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.WriteLine("new Dictionary<string, object>");
			writer.WriteLine("{");
			int indent = writer.Indent;
			writer.Indent = indent + 1;
			foreach (string text in from k in annotations.Keys
			orderby k
			select k)
			{
				writer.Write("{ ");
				writer.Write(this.Quote(text) + ", ");
				this.GenerateAnnotation(text, annotations[text], writer);
				writer.WriteLine(" },");
			}
			indent = writer.Indent;
			writer.Indent = indent - 1;
			writer.Write("}");
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0002799C File Offset: 0x00025B9C
		protected internal virtual void GenerateAnnotations(global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues>>(annotations, "annotations");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.WriteLine("new Dictionary<string, AnnotationValues>");
			writer.WriteLine("{");
			int indent = writer.Indent;
			writer.Indent = indent + 1;
			if (annotations != null)
			{
				foreach (string text in from k in annotations.Keys
				orderby k
				select k)
				{
					writer.WriteLine("{ ");
					indent = writer.Indent;
					writer.Indent = indent + 1;
					writer.WriteLine(this.Quote(text) + ",");
					writer.Write("new AnnotationValues(oldValue: ");
					this.GenerateAnnotation(text, annotations[text].OldValue, writer);
					writer.Write(", newValue: ");
					this.GenerateAnnotation(text, annotations[text].NewValue, writer);
					writer.WriteLine(")");
					indent = writer.Indent;
					writer.Indent = indent - 1;
					writer.WriteLine("},");
				}
			}
			indent = writer.Indent;
			writer.Indent = indent - 1;
			writer.Write("}");
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00027B04 File Offset: 0x00025D04
		protected internal virtual void GenerateAnnotation(string name, object annotation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			if (annotation == null)
			{
				writer.Write("null");
				return;
			}
			global::System.Func<global::System.Data.Entity.Infrastructure.Annotations.AnnotationCodeGenerator> func;
			if (this.AnnotationGenerators.TryGetValue(name, out func) && func != null)
			{
				func().Generate(name, annotation, writer);
				return;
			}
			writer.Write(this.Quote(annotation.ToString()));
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00027B6C File Offset: 0x00025D6C
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.CreateProcedureOperation createProcedureOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.CreateProcedureOperation>(createProcedureOperation, "createProcedureOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			this.Generate(createProcedureOperation, "CreateStoredProcedure", writer);
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00027B93 File Offset: 0x00025D93
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.AlterProcedureOperation alterProcedureOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.AlterProcedureOperation>(alterProcedureOperation, "alterProcedureOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			this.Generate(alterProcedureOperation, "AlterStoredProcedure", writer);
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00027BBC File Offset: 0x00025DBC
		private void Generate(global::System.Data.Entity.Migrations.Model.ProcedureOperation procedureOperation, string methodName, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			writer.Write(methodName);
			writer.WriteLine("(");
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer2 = writer;
			int indent = writer2.Indent;
			writer2.Indent = indent + 1;
			writer.Write(this.Quote(procedureOperation.Name));
			writer.WriteLine(",");
			if (procedureOperation.Parameters.Any<global::System.Data.Entity.Migrations.Model.ParameterModel>())
			{
				writer.WriteLine("p => new");
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer3 = writer;
				indent = writer3.Indent;
				writer3.Indent = indent + 1;
				writer.WriteLine("{");
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer4 = writer;
				indent = writer4.Indent;
				writer4.Indent = indent + 1;
				procedureOperation.Parameters.Each(delegate(global::System.Data.Entity.Migrations.Model.ParameterModel p)
				{
					string text = this.ScrubName(p.Name);
					writer.Write(text);
					writer.Write(" =");
					this.Generate(p, writer, !string.Equals(p.Name, text, global::System.StringComparison.Ordinal));
					writer.WriteLine(",");
				});
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer5 = writer;
				indent = writer5.Indent;
				writer5.Indent = indent - 1;
				writer.WriteLine("},");
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer6 = writer;
				indent = writer6.Indent;
				writer6.Indent = indent - 1;
			}
			writer.Write("body:");
			if (!string.IsNullOrWhiteSpace(procedureOperation.BodySql))
			{
				writer.WriteLine();
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer7 = writer;
				indent = writer7.Indent;
				writer7.Indent = indent + 1;
				string newValue = writer.NewLine + writer.CurrentIndentation() + "  ";
				writer.Write("@");
				writer.WriteLine(this.Generate(procedureOperation.BodySql.Replace(global::System.Environment.NewLine, newValue)));
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer8 = writer;
				indent = writer8.Indent;
				writer8.Indent = indent - 1;
			}
			else
			{
				writer.WriteLine(" \"\"");
			}
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer9 = writer;
			indent = writer9.Indent;
			writer9.Indent = indent - 1;
			writer.WriteLine(");");
			writer.WriteLine();
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x00027DCC File Offset: 0x00025FCC
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.ParameterModel parameterModel, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer, bool emitName = false)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.ParameterModel>(parameterModel, "parameterModel");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write(" p.");
			writer.Write(this.TranslateColumnType(parameterModel.Type));
			writer.Write("(");
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			if (emitName)
			{
				list.Add("name: " + this.Quote(parameterModel.Name));
			}
			if (parameterModel.MaxLength != null)
			{
				list.Add("maxLength: " + parameterModel.MaxLength.ToString());
			}
			if (parameterModel.Precision != null)
			{
				list.Add("precision: " + parameterModel.Precision.ToString());
			}
			if (parameterModel.Scale != null)
			{
				list.Add("scale: " + parameterModel.Scale.ToString());
			}
			if (parameterModel.IsFixedLength != null)
			{
				list.Add("fixedLength: " + parameterModel.IsFixedLength.ToString().ToLowerInvariant());
			}
			if (parameterModel.IsUnicode != null)
			{
				list.Add("unicode: " + parameterModel.IsUnicode.ToString().ToLowerInvariant());
			}
			if (parameterModel.DefaultValue != null)
			{
				if (global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__18.<>p__2 == null)
				{
					global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__18.<>p__2 = global::System.Runtime.CompilerServices.CallSite<global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Collections.Generic.List<string>, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.ResultDiscarded, "Add", null, typeof(global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
					}));
				}
				global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Collections.Generic.List<string>, object> target = global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__18.<>p__2.Target;
				global::System.Runtime.CompilerServices.CallSite <>p__ = global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__18.<>p__2;
				global::System.Collections.Generic.List<string> arg = list;
				if (global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__18.<>p__1 == null)
				{
					global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__18.<>p__1 = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, string, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::System.Linq.Expressions.ExpressionType.Add, typeof(global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType | global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.Constant, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
					}));
				}
				global::System.Func<global::System.Runtime.CompilerServices.CallSite, string, object, object> target2 = global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__18.<>p__1.Target;
				global::System.Runtime.CompilerServices.CallSite <>p__2 = global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__18.<>p__1;
				string arg2 = "defaultValue: ";
				if (global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__18.<>p__0 == null)
				{
					global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__18.<>p__0 = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.InvokeSimpleName, "Generate", null, typeof(global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
					}));
				}
				target(<>p__, arg, target2(<>p__2, arg2, global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__18.<>p__0.Target(global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__18.<>p__0, this, parameterModel.DefaultValue)));
			}
			if (!string.IsNullOrWhiteSpace(parameterModel.DefaultValueSql))
			{
				list.Add("defaultValueSql: " + this.Quote(parameterModel.DefaultValueSql));
			}
			if (!string.IsNullOrWhiteSpace(parameterModel.StoreType))
			{
				list.Add("storeType: " + this.Quote(parameterModel.StoreType));
			}
			if (parameterModel.IsOutParameter)
			{
				list.Add("outParameter: true");
			}
			writer.Write(list.Join(null, ", "));
			writer.Write(")");
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x000280E4 File Offset: 0x000262E4
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.DropProcedureOperation dropProcedureOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.DropProcedureOperation>(dropProcedureOperation, "dropProcedureOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("DropStoredProcedure(");
			writer.Write(this.Quote(dropProcedureOperation.Name));
			writer.WriteLine(");");
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00028134 File Offset: 0x00026334
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.CreateTableOperation createTableOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.CreateTableOperation>(createTableOperation, "createTableOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.WriteLine("CreateTable(");
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer2 = writer;
			int indent = writer2.Indent;
			writer2.Indent = indent + 1;
			writer.Write(this.Quote(createTableOperation.Name));
			writer.WriteLine(",");
			writer.WriteLine("c => new");
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer3 = writer;
			indent = writer3.Indent;
			writer3.Indent = indent + 1;
			writer.WriteLine("{");
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer4 = writer;
			indent = writer4.Indent;
			writer4.Indent = indent + 1;
			createTableOperation.Columns.Each(delegate(global::System.Data.Entity.Migrations.Model.ColumnModel c)
			{
				string text = this.ScrubName(c.Name);
				writer.Write(text);
				writer.Write(" =");
				this.Generate(c, writer, !string.Equals(c.Name, text, global::System.StringComparison.Ordinal));
				writer.WriteLine(",");
			});
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer5 = writer;
			indent = writer5.Indent;
			writer5.Indent = indent - 1;
			writer.Write("}");
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer6 = writer;
			indent = writer6.Indent;
			writer6.Indent = indent - 1;
			if (createTableOperation.Annotations.Any<global::System.Collections.Generic.KeyValuePair<string, object>>())
			{
				writer.WriteLine(",");
				writer.Write("annotations: ");
				this.GenerateAnnotations(createTableOperation.Annotations, writer);
			}
			writer.Write(")");
			this.GenerateInline(createTableOperation.PrimaryKey, writer);
			(from t in this._newTableForeignKeys
			where t.Item1 == createTableOperation
			select t).Each(delegate(global::System.Tuple<global::System.Data.Entity.Migrations.Model.CreateTableOperation, global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation> t)
			{
				this.GenerateInline(t.Item2, writer);
			});
			(from t in this._newTableIndexes
			where t.Item1 == createTableOperation
			select t).Each(delegate(global::System.Tuple<global::System.Data.Entity.Migrations.Model.CreateTableOperation, global::System.Data.Entity.Migrations.Model.CreateIndexOperation> t)
			{
				this.GenerateInline(t.Item2, writer);
			});
			writer.WriteLine(";");
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer7 = writer;
			indent = writer7.Indent;
			writer7.Indent = indent - 1;
			writer.WriteLine();
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00028360 File Offset: 0x00026560
		protected internal virtual void Generate(global::System.Data.Entity.Migrations.Model.AlterTableOperation alterTableOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.AlterTableOperation>(alterTableOperation, "alterTableOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.WriteLine("AlterTableAnnotations(");
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer2 = writer;
			int indent = writer2.Indent;
			writer2.Indent = indent + 1;
			writer.Write(this.Quote(alterTableOperation.Name));
			writer.WriteLine(",");
			writer.WriteLine("c => new");
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer3 = writer;
			indent = writer3.Indent;
			writer3.Indent = indent + 1;
			writer.WriteLine("{");
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer4 = writer;
			indent = writer4.Indent;
			writer4.Indent = indent + 1;
			alterTableOperation.Columns.Each(delegate(global::System.Data.Entity.Migrations.Model.ColumnModel c)
			{
				string text = this.ScrubName(c.Name);
				writer.Write(text);
				writer.Write(" =");
				this.Generate(c, writer, !string.Equals(c.Name, text, global::System.StringComparison.Ordinal));
				writer.WriteLine(",");
			});
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer5 = writer;
			indent = writer5.Indent;
			writer5.Indent = indent - 1;
			writer.Write("}");
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer6 = writer;
			indent = writer6.Indent;
			writer6.Indent = indent - 1;
			if (alterTableOperation.Annotations.Any<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues>>())
			{
				writer.WriteLine(",");
				writer.Write("annotations: ");
				this.GenerateAnnotations(alterTableOperation.Annotations, writer);
			}
			writer.Write(")");
			writer.WriteLine(";");
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer7 = writer;
			indent = writer7.Indent;
			writer7.Indent = indent - 1;
			writer.WriteLine();
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00028504 File Offset: 0x00026704
		protected virtual void GenerateInline(global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation addPrimaryKeyOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			if (addPrimaryKeyOperation != null)
			{
				writer.WriteLine();
				writer.Write(".PrimaryKey(");
				this.Generate(addPrimaryKeyOperation.Columns, writer);
				if (!addPrimaryKeyOperation.HasDefaultName)
				{
					writer.Write(", name: ");
					writer.Write(this.Quote(addPrimaryKeyOperation.Name));
				}
				if (!addPrimaryKeyOperation.IsClustered)
				{
					writer.Write(", clustered: false");
				}
				writer.Write(")");
			}
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00028584 File Offset: 0x00026784
		protected virtual void GenerateInline(global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation addForeignKeyOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation>(addForeignKeyOperation, "addForeignKeyOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.WriteLine();
			writer.Write(".ForeignKey(" + this.Quote(addForeignKeyOperation.PrincipalTable) + ", ");
			this.Generate(addForeignKeyOperation.DependentColumns, writer);
			if (addForeignKeyOperation.CascadeDelete)
			{
				writer.Write(", cascadeDelete: true");
			}
			writer.Write(")");
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x000285FC File Offset: 0x000267FC
		protected virtual void GenerateInline(global::System.Data.Entity.Migrations.Model.CreateIndexOperation createIndexOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.CreateIndexOperation>(createIndexOperation, "createIndexOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.WriteLine();
			writer.Write(".Index(");
			this.Generate(createIndexOperation.Columns, writer);
			this.WriteIndexParameters(createIndexOperation, writer);
			writer.Write(")");
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00028654 File Offset: 0x00026854
		protected virtual void Generate(global::System.Collections.Generic.IEnumerable<string> columns, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<string>>(columns, "columns");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("t => ");
			if (columns.Count<string>() == 1)
			{
				writer.Write("t." + this.ScrubName(columns.Single<string>()));
				return;
			}
			writer.Write("new { " + columns.Join((string c) => "t." + this.ScrubName(c), ", ") + " }");
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x000286D8 File Offset: 0x000268D8
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation addPrimaryKeyOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation>(addPrimaryKeyOperation, "addPrimaryKeyOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("AddPrimaryKey(");
			writer.Write(this.Quote(addPrimaryKeyOperation.Table));
			writer.Write(", ");
			bool flag = addPrimaryKeyOperation.Columns.Count<string>() > 1;
			if (flag)
			{
				writer.Write("new[] { ");
			}
			writer.Write(addPrimaryKeyOperation.Columns.Join(new global::System.Func<string, string>(this.Quote), ", "));
			if (flag)
			{
				writer.Write(" }");
			}
			if (!addPrimaryKeyOperation.HasDefaultName)
			{
				writer.Write(", name: ");
				writer.Write(this.Quote(addPrimaryKeyOperation.Name));
			}
			if (!addPrimaryKeyOperation.IsClustered)
			{
				writer.Write(", clustered: false");
			}
			writer.WriteLine(");");
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x000287B4 File Offset: 0x000269B4
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation dropPrimaryKeyOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation>(dropPrimaryKeyOperation, "dropPrimaryKeyOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("DropPrimaryKey(");
			writer.Write(this.Quote(dropPrimaryKeyOperation.Table));
			if (!dropPrimaryKeyOperation.HasDefaultName)
			{
				writer.Write(", name: ");
				writer.Write(this.Quote(dropPrimaryKeyOperation.Name));
			}
			writer.WriteLine(");");
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00028828 File Offset: 0x00026A28
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation addForeignKeyOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation>(addForeignKeyOperation, "addForeignKeyOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("AddForeignKey(");
			writer.Write(this.Quote(addForeignKeyOperation.DependentTable));
			writer.Write(", ");
			bool flag = addForeignKeyOperation.DependentColumns.Count<string>() > 1;
			if (flag)
			{
				writer.Write("new[] { ");
			}
			writer.Write(addForeignKeyOperation.DependentColumns.Join(new global::System.Func<string, string>(this.Quote), ", "));
			if (flag)
			{
				writer.Write(" }");
			}
			writer.Write(", ");
			writer.Write(this.Quote(addForeignKeyOperation.PrincipalTable));
			if (addForeignKeyOperation.PrincipalColumns.Any<string>())
			{
				writer.Write(", ");
				if (flag)
				{
					writer.Write("new[] { ");
				}
				writer.Write(addForeignKeyOperation.PrincipalColumns.Join(new global::System.Func<string, string>(this.Quote), ", "));
				if (flag)
				{
					writer.Write(" }");
				}
			}
			if (addForeignKeyOperation.CascadeDelete)
			{
				writer.Write(", cascadeDelete: true");
			}
			if (!addForeignKeyOperation.HasDefaultName)
			{
				writer.Write(", name: ");
				writer.Write(this.Quote(addForeignKeyOperation.Name));
			}
			writer.WriteLine(");");
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0002897C File Offset: 0x00026B7C
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.DropForeignKeyOperation dropForeignKeyOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.DropForeignKeyOperation>(dropForeignKeyOperation, "dropForeignKeyOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("DropForeignKey(");
			writer.Write(this.Quote(dropForeignKeyOperation.DependentTable));
			writer.Write(", ");
			if (!dropForeignKeyOperation.HasDefaultName)
			{
				writer.Write(this.Quote(dropForeignKeyOperation.Name));
			}
			else
			{
				bool flag = dropForeignKeyOperation.DependentColumns.Count<string>() > 1;
				if (flag)
				{
					writer.Write("new[] { ");
				}
				writer.Write(dropForeignKeyOperation.DependentColumns.Join(new global::System.Func<string, string>(this.Quote), ", "));
				if (flag)
				{
					writer.Write(" }");
				}
				writer.Write(", ");
				writer.Write(this.Quote(dropForeignKeyOperation.PrincipalTable));
			}
			writer.WriteLine(");");
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00028A5C File Offset: 0x00026C5C
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.CreateIndexOperation createIndexOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.CreateIndexOperation>(createIndexOperation, "createIndexOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("CreateIndex(");
			writer.Write(this.Quote(createIndexOperation.Table));
			writer.Write(", ");
			bool flag = createIndexOperation.Columns.Count<string>() > 1;
			if (flag)
			{
				writer.Write("new[] { ");
			}
			writer.Write(createIndexOperation.Columns.Join(new global::System.Func<string, string>(this.Quote), ", "));
			if (flag)
			{
				writer.Write(" }");
			}
			this.WriteIndexParameters(createIndexOperation, writer);
			writer.WriteLine(");");
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00028B08 File Offset: 0x00026D08
		private void WriteIndexParameters(global::System.Data.Entity.Migrations.Model.CreateIndexOperation createIndexOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			if (createIndexOperation.IsUnique)
			{
				writer.Write(", unique: true");
			}
			if (createIndexOperation.IsClustered)
			{
				writer.Write(", clustered: true");
			}
			if (!createIndexOperation.HasDefaultName)
			{
				writer.Write(", name: ");
				writer.Write(this.Quote(createIndexOperation.Name));
			}
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00028B60 File Offset: 0x00026D60
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.DropIndexOperation dropIndexOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.DropIndexOperation>(dropIndexOperation, "dropIndexOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("DropIndex(");
			writer.Write(this.Quote(dropIndexOperation.Table));
			writer.Write(", ");
			if (!dropIndexOperation.HasDefaultName)
			{
				writer.Write(this.Quote(dropIndexOperation.Name));
			}
			else
			{
				writer.Write("new[] { ");
				writer.Write(dropIndexOperation.Columns.Join(new global::System.Func<string, string>(this.Quote), ", "));
				writer.Write(" }");
			}
			writer.WriteLine(");");
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00028C10 File Offset: 0x00026E10
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.ColumnModel column, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer, bool emitName = false)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.ColumnModel>(column, "column");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write(" c.");
			writer.Write(this.TranslateColumnType(column.Type));
			writer.Write("(");
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			if (emitName)
			{
				list.Add("name: " + this.Quote(column.Name));
			}
			bool? isNullable = column.IsNullable;
			bool flag = false;
			if (isNullable.GetValueOrDefault() == flag & isNullable != null)
			{
				list.Add("nullable: false");
			}
			if (column.MaxLength != null)
			{
				list.Add("maxLength: " + column.MaxLength.ToString());
			}
			if (column.Precision != null)
			{
				list.Add("precision: " + column.Precision.ToString());
			}
			if (column.Scale != null)
			{
				list.Add("scale: " + column.Scale.ToString());
			}
			if (column.IsFixedLength != null)
			{
				list.Add("fixedLength: " + column.IsFixedLength.ToString().ToLowerInvariant());
			}
			if (column.IsUnicode != null)
			{
				list.Add("unicode: " + column.IsUnicode.ToString().ToLowerInvariant());
			}
			if (column.IsIdentity)
			{
				list.Add("identity: true");
			}
			if (column.DefaultValue != null)
			{
				if (global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__33.<>p__2 == null)
				{
					global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__33.<>p__2 = global::System.Runtime.CompilerServices.CallSite<global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Collections.Generic.List<string>, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.ResultDiscarded, "Add", null, typeof(global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
					}));
				}
				global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Collections.Generic.List<string>, object> target = global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__33.<>p__2.Target;
				global::System.Runtime.CompilerServices.CallSite <>p__ = global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__33.<>p__2;
				global::System.Collections.Generic.List<string> arg = list;
				if (global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__33.<>p__1 == null)
				{
					global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__33.<>p__1 = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, string, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::System.Linq.Expressions.ExpressionType.Add, typeof(global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType | global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.Constant, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
					}));
				}
				global::System.Func<global::System.Runtime.CompilerServices.CallSite, string, object, object> target2 = global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__33.<>p__1.Target;
				global::System.Runtime.CompilerServices.CallSite <>p__2 = global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__33.<>p__1;
				string arg2 = "defaultValue: ";
				if (global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__33.<>p__0 == null)
				{
					global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__33.<>p__0 = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.InvokeSimpleName, "Generate", null, typeof(global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
					}));
				}
				target(<>p__, arg, target2(<>p__2, arg2, global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__33.<>p__0.Target(global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator.<>o__33.<>p__0, this, column.DefaultValue)));
			}
			if (!string.IsNullOrWhiteSpace(column.DefaultValueSql))
			{
				list.Add("defaultValueSql: " + this.Quote(column.DefaultValueSql));
			}
			if (column.IsTimestamp)
			{
				list.Add("timestamp: true");
			}
			if (!string.IsNullOrWhiteSpace(column.StoreType))
			{
				list.Add("storeType: " + this.Quote(column.StoreType));
			}
			writer.Write(list.Join(null, ", "));
			if (column.Annotations.Any<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues>>())
			{
				int indent = writer.Indent;
				writer.Indent = indent + 1;
				writer.WriteLine(list.Any<string>() ? "," : "");
				writer.Write("annotations: ");
				this.GenerateAnnotations(column.Annotations, writer);
				indent = writer.Indent;
				writer.Indent = indent - 1;
			}
			writer.Write(")");
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00028FCA File Offset: 0x000271CA
		protected virtual string Generate(byte[] defaultValue)
		{
			return "new byte[] {" + defaultValue.Join(null, ", ") + "}";
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00028FE8 File Offset: 0x000271E8
		protected virtual string Generate(global::System.DateTime defaultValue)
		{
			return string.Concat(new string[]
			{
				"new DateTime(",
				defaultValue.Ticks.ToString(),
				", DateTimeKind.",
				global::System.Enum.GetName(typeof(global::System.DateTimeKind), defaultValue.Kind),
				")"
			});
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00029048 File Offset: 0x00027248
		protected virtual string Generate(global::System.DateTimeOffset defaultValue)
		{
			return string.Concat(new string[]
			{
				"new DateTimeOffset(",
				defaultValue.Ticks.ToString(),
				", new TimeSpan(",
				defaultValue.Offset.Ticks.ToString(),
				"))"
			});
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x000290A4 File Offset: 0x000272A4
		protected virtual string Generate(decimal defaultValue)
		{
			return defaultValue.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "m";
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x000290BC File Offset: 0x000272BC
		protected virtual string Generate(global::System.Guid defaultValue)
		{
			string str = "new Guid(\"";
			global::System.Guid guid = defaultValue;
			return str + guid.ToString() + "\")";
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x000290E7 File Offset: 0x000272E7
		protected virtual string Generate(long defaultValue)
		{
			return defaultValue.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x000290F5 File Offset: 0x000272F5
		protected virtual string Generate(float defaultValue)
		{
			return defaultValue.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "f";
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x0002910D File Offset: 0x0002730D
		protected virtual string Generate(string defaultValue)
		{
			return this.Quote(defaultValue);
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00029118 File Offset: 0x00027318
		protected virtual string Generate(global::System.TimeSpan defaultValue)
		{
			return "new TimeSpan(" + defaultValue.Ticks.ToString() + ")";
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00029143 File Offset: 0x00027343
		protected virtual string Generate(global::System.Data.Entity.Hierarchy.HierarchyId defaultValue)
		{
			return "new HierarchyId(\"" + ((defaultValue != null) ? defaultValue.ToString() : null) + "\")";
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x00029164 File Offset: 0x00027364
		protected virtual string Generate(global::System.Data.Entity.Spatial.DbGeography defaultValue)
		{
			return string.Concat(new string[]
			{
				"DbGeography.FromText(\"",
				defaultValue.AsText(),
				"\", ",
				defaultValue.CoordinateSystemId.ToString(),
				")"
			});
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x000291B0 File Offset: 0x000273B0
		protected virtual string Generate(global::System.Data.Entity.Spatial.DbGeometry defaultValue)
		{
			return string.Concat(new string[]
			{
				"DbGeometry.FromText(\"",
				defaultValue.AsText(),
				"\", ",
				defaultValue.CoordinateSystemId.ToString(),
				")"
			});
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x000291FA File Offset: 0x000273FA
		protected virtual string Generate(object defaultValue)
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}", new object[]
			{
				defaultValue
			}).ToLowerInvariant();
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x0002921C File Offset: 0x0002741C
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.DropTableOperation dropTableOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.DropTableOperation>(dropTableOperation, "dropTableOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("DropTable(");
			writer.Write(this.Quote(dropTableOperation.Name));
			if (dropTableOperation.RemovedAnnotations.Any<global::System.Collections.Generic.KeyValuePair<string, object>>())
			{
				int indent = writer.Indent;
				writer.Indent = indent + 1;
				writer.WriteLine(",");
				writer.Write("removedAnnotations: ");
				this.GenerateAnnotations(dropTableOperation.RemovedAnnotations, writer);
				indent = writer.Indent;
				writer.Indent = indent - 1;
			}
			global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IDictionary<string, object>> removedColumnAnnotations = dropTableOperation.RemovedColumnAnnotations;
			if (removedColumnAnnotations.Any<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.IDictionary<string, object>>>())
			{
				int indent = writer.Indent;
				writer.Indent = indent + 1;
				writer.WriteLine(",");
				writer.Write("removedColumnAnnotations: ");
				writer.WriteLine("new Dictionary<string, IDictionary<string, object>>");
				writer.WriteLine("{");
				indent = writer.Indent;
				writer.Indent = indent + 1;
				foreach (string text in from k in removedColumnAnnotations.Keys
				orderby k
				select k)
				{
					writer.WriteLine("{");
					indent = writer.Indent;
					writer.Indent = indent + 1;
					writer.WriteLine(this.Quote(text) + ",");
					this.GenerateAnnotations(removedColumnAnnotations[text], writer);
					writer.WriteLine();
					indent = writer.Indent;
					writer.Indent = indent - 1;
					writer.WriteLine("},");
				}
				indent = writer.Indent;
				writer.Indent = indent - 1;
				writer.Write("}");
				indent = writer.Indent;
				writer.Indent = indent - 1;
			}
			writer.WriteLine(");");
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00029400 File Offset: 0x00027600
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.MoveTableOperation moveTableOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.MoveTableOperation>(moveTableOperation, "moveTableOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("MoveTable(name: ");
			writer.Write(this.Quote(moveTableOperation.Name));
			writer.Write(", newSchema: ");
			writer.Write(string.IsNullOrWhiteSpace(moveTableOperation.NewSchema) ? "null" : this.Quote(moveTableOperation.NewSchema));
			writer.WriteLine(");");
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x00029480 File Offset: 0x00027680
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.MoveProcedureOperation moveProcedureOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.MoveProcedureOperation>(moveProcedureOperation, "moveProcedureOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("MoveStoredProcedure(name: ");
			writer.Write(this.Quote(moveProcedureOperation.Name));
			writer.Write(", newSchema: ");
			writer.Write(string.IsNullOrWhiteSpace(moveProcedureOperation.NewSchema) ? "null" : this.Quote(moveProcedureOperation.NewSchema));
			writer.WriteLine(");");
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00029500 File Offset: 0x00027700
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.RenameTableOperation renameTableOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.RenameTableOperation>(renameTableOperation, "renameTableOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("RenameTable(name: ");
			writer.Write(this.Quote(renameTableOperation.Name));
			writer.Write(", newName: ");
			writer.Write(this.Quote(renameTableOperation.NewName));
			writer.WriteLine(");");
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x0002956C File Offset: 0x0002776C
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.RenameProcedureOperation renameProcedureOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.RenameProcedureOperation>(renameProcedureOperation, "renameProcedureOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("RenameStoredProcedure(name: ");
			writer.Write(this.Quote(renameProcedureOperation.Name));
			writer.Write(", newName: ");
			writer.Write(this.Quote(renameProcedureOperation.NewName));
			writer.WriteLine(");");
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x000295D8 File Offset: 0x000277D8
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.RenameColumnOperation renameColumnOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.RenameColumnOperation>(renameColumnOperation, "renameColumnOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("RenameColumn(table: ");
			writer.Write(this.Quote(renameColumnOperation.Table));
			writer.Write(", name: ");
			writer.Write(this.Quote(renameColumnOperation.Name));
			writer.Write(", newName: ");
			writer.Write(this.Quote(renameColumnOperation.NewName));
			writer.WriteLine(");");
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00029660 File Offset: 0x00027860
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.RenameIndexOperation renameIndexOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.RenameIndexOperation>(renameIndexOperation, "renameIndexOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("RenameIndex(table: ");
			writer.Write(this.Quote(renameIndexOperation.Table));
			writer.Write(", name: ");
			writer.Write(this.Quote(renameIndexOperation.Name));
			writer.Write(", newName: ");
			writer.Write(this.Quote(renameIndexOperation.NewName));
			writer.WriteLine(");");
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x000296E8 File Offset: 0x000278E8
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.SqlOperation sqlOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.SqlOperation>(sqlOperation, "sqlOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("Sql(@");
			writer.Write(this.Quote(sqlOperation.Sql));
			if (sqlOperation.SuppressTransaction)
			{
				writer.Write(", suppressTransaction: true");
			}
			writer.WriteLine(");");
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x00029748 File Offset: 0x00027948
		protected virtual string ScrubName(string name)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			name = new global::System.Text.RegularExpressions.Regex("[^\\p{Ll}\\p{Lu}\\p{Lt}\\p{Lo}\\p{Nd}\\p{Nl}\\p{Mn}\\p{Mc}\\p{Cf}\\p{Pc}\\p{Lm}]").Replace(name, string.Empty);
			using (global::Microsoft.CSharp.CSharpCodeProvider csharpCodeProvider = new global::Microsoft.CSharp.CSharpCodeProvider())
			{
				if ((!char.IsLetter(name[0]) && name[0] != '_') || !csharpCodeProvider.IsValidIdentifier(name))
				{
					name = "_" + name;
				}
			}
			return name;
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x000297CC File Offset: 0x000279CC
		protected virtual string TranslateColumnType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind)
		{
			switch (primitiveTypeKind)
			{
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16:
				return "Short";
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32:
				return "Int";
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64:
				return "Long";
			default:
				return global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind), primitiveTypeKind);
			}
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x0002980C File Offset: 0x00027A0C
		protected virtual string Quote(string identifier)
		{
			return "\"" + identifier + "\"";
		}

		// Token: 0x040008D3 RID: 2259
		private global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Migrations.Model.CreateTableOperation, global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation>> _newTableForeignKeys;

		// Token: 0x040008D4 RID: 2260
		private global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Migrations.Model.CreateTableOperation, global::System.Data.Entity.Migrations.Model.CreateIndexOperation>> _newTableIndexes;
	}
}
