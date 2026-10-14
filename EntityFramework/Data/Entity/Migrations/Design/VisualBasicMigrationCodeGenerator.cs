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
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.VisualBasic;

namespace System.Data.Entity.Migrations.Design
{
	// Token: 0x020000E8 RID: 232
	public class VisualBasicMigrationCodeGenerator : global::System.Data.Entity.Migrations.Design.MigrationCodeGenerator
	{
		// Token: 0x06001179 RID: 4473 RVA: 0x0002A0D4 File Offset: 0x000282D4
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
			from cfk in operations.OfType<global::System.Data.Entity.Migrations.Model.CreateIndexOperation>()
			where ct.Name.EqualsIgnoreCase(cfk.Table)
			select global::System.Tuple.Create<global::System.Data.Entity.Migrations.Model.CreateTableOperation, global::System.Data.Entity.Migrations.Model.CreateIndexOperation>(ct, cfk)).ToList<global::System.Tuple<global::System.Data.Entity.Migrations.Model.CreateTableOperation, global::System.Data.Entity.Migrations.Model.CreateIndexOperation>>();
			global::System.Data.Entity.Migrations.Design.ScaffoldedMigration scaffoldedMigration = new global::System.Data.Entity.Migrations.Design.ScaffoldedMigration
			{
				MigrationId = migrationId,
				Language = "vb",
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

		// Token: 0x0600117A RID: 4474 RVA: 0x0002A2BC File Offset: 0x000284BC
		protected virtual string Generate(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> operations, string @namespace, string className)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation>>(operations, "operations");
			global::System.Data.Entity.Utilities.Check.NotEmpty(className, "className");
			string result;
			using (global::System.IO.StringWriter stringWriter = new global::System.IO.StringWriter(global::System.Globalization.CultureInfo.InvariantCulture))
			{
				using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer = new global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter(stringWriter))
				{
					this.WriteClassStart(@namespace, className, writer, "Inherits DbMigration", false, this.GetNamespaces(operations));
					writer.WriteLine("Public Overrides Sub Up()");
					global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer5 = writer;
					int indent = writer5.Indent;
					writer5.Indent = indent + 1;
					operations.Except(from t in this._newTableForeignKeys
					select t.Item2).Except(from t in this._newTableIndexes
					select t.Item2).Each(delegate(dynamic o)
					{
						if (global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__3.<>p__0 == null)
						{
							global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__3.<>p__0 = global::System.Runtime.CompilerServices.CallSite<global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator, object, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.InvokeSimpleName | global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.ResultDiscarded, "Generate", null, typeof(global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
							{
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null),
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__3.<>p__0.Target(global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__3.<>p__0, this, o, writer);
					});
					global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer2 = writer;
					indent = writer2.Indent;
					writer2.Indent = indent - 1;
					writer.WriteLine("End Sub");
					writer.WriteLine();
					writer.WriteLine("Public Overrides Sub Down()");
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
						if (global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__3.<>p__1 == null)
						{
							global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__3.<>p__1 = global::System.Runtime.CompilerServices.CallSite<global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator, object, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.InvokeSimpleName | global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.ResultDiscarded, "Generate", null, typeof(global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
							{
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null),
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__3.<>p__1.Target(global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__3.<>p__1, this, o, writer);
					});
					if (flag)
					{
						writer.Write("Throw New NotSupportedException(");
						writer.Write(this.Generate(global::System.Data.Entity.Resources.Strings.ScaffoldSprocInDownNotSupported));
						writer.WriteLine(")");
					}
					global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer4 = writer;
					indent = writer4.Indent;
					writer4.Indent = indent - 1;
					writer.WriteLine("End Sub");
					this.WriteClassEnd(@namespace, writer);
				}
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x0002A580 File Offset: 0x00028780
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
					indentedTextWriter.WriteLine("' <auto-generated />");
					this.WriteClassStart(@namespace, className, indentedTextWriter, "Implements IMigrationMetadata", true, null);
					indentedTextWriter.Write("Private ReadOnly Resources As New ResourceManager(GetType(");
					indentedTextWriter.Write(className);
					indentedTextWriter.WriteLine("))");
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

		// Token: 0x0600117C RID: 4476 RVA: 0x0002A694 File Offset: 0x00028894
		protected virtual void WriteProperty(string name, string value, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("Private ReadOnly Property IMigrationMetadata_");
			writer.Write(name);
			writer.Write("() As String Implements IMigrationMetadata.");
			writer.WriteLine(name);
			int indent = writer.Indent;
			writer.Indent = indent + 1;
			writer.WriteLine("Get");
			indent = writer.Indent;
			writer.Indent = indent + 1;
			writer.Write("Return ");
			writer.WriteLine(value ?? "Nothing");
			indent = writer.Indent;
			writer.Indent = indent - 1;
			writer.WriteLine("End Get");
			indent = writer.Indent;
			writer.Indent = indent - 1;
			writer.WriteLine("End Property");
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x0002A759 File Offset: 0x00028959
		protected virtual void WriteClassAttributes(global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer, bool designer)
		{
			if (designer)
			{
				writer.WriteLine("<GeneratedCode(\"EntityFramework.Migrations\", \"{0}\")>", typeof(global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator).Assembly().GetInformationalVersion());
			}
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x0002A780 File Offset: 0x00028980
		protected virtual void WriteClassStart(string @namespace, string className, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer, string @base, bool designer = false, global::System.Collections.Generic.IEnumerable<string> namespaces = null)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			global::System.Data.Entity.Utilities.Check.NotEmpty(className, "className");
			global::System.Data.Entity.Utilities.Check.NotEmpty(@base, "base");
			(namespaces ?? this.GetDefaultNamespaces(designer)).Each(delegate(string n)
			{
				writer.WriteLine("Imports " + n);
			});
			if (!designer)
			{
				writer.WriteLine("Imports Microsoft.VisualBasic");
			}
			writer.WriteLine();
			int indent;
			if (!string.IsNullOrWhiteSpace(@namespace))
			{
				writer.Write("Namespace ");
				writer.WriteLine(@namespace);
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer2 = writer;
				indent = writer2.Indent;
				writer2.Indent = indent + 1;
			}
			this.WriteClassAttributes(writer, designer);
			writer.Write("Public ");
			if (designer)
			{
				writer.Write("NotInheritable ");
			}
			writer.Write("Partial Class ");
			writer.Write(className);
			writer.WriteLine();
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer3 = writer;
			indent = writer3.Indent;
			writer3.Indent = indent + 1;
			writer.WriteLine(@base);
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer4 = writer;
			indent = writer4.Indent;
			writer4.Indent = indent - 1;
			writer.WriteLine();
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer5 = writer;
			indent = writer5.Indent;
			writer5.Indent = indent + 1;
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x0002A8EC File Offset: 0x00028AEC
		protected virtual void WriteClassEnd(string @namespace, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			int indent = writer.Indent;
			writer.Indent = indent - 1;
			writer.WriteLine("End Class");
			if (!string.IsNullOrWhiteSpace(@namespace))
			{
				indent = writer.Indent;
				writer.Indent = indent - 1;
				writer.WriteLine("End Namespace");
			}
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x0002A944 File Offset: 0x00028B44
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.AddColumnOperation addColumnOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.AddColumnOperation>(addColumnOperation, "addColumnOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("AddColumn(");
			writer.Write(this.Quote(addColumnOperation.Table));
			writer.Write(", ");
			writer.Write(this.Quote(addColumnOperation.Column.Name));
			writer.Write(", Function(c)");
			this.Generate(addColumnOperation.Column, writer, false);
			writer.WriteLine(")");
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x0002A9CC File Offset: 0x00028BCC
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
				writer.Write("removedAnnotations := ");
				this.GenerateAnnotations(dropColumnOperation.RemovedAnnotations, writer);
				indent = writer.Indent;
				writer.Indent = indent - 1;
			}
			writer.WriteLine(")");
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x0002AA88 File Offset: 0x00028C88
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.AlterColumnOperation alterColumnOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.AlterColumnOperation>(alterColumnOperation, "alterColumnOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("AlterColumn(");
			writer.Write(this.Quote(alterColumnOperation.Table));
			writer.Write(", ");
			writer.Write(this.Quote(alterColumnOperation.Column.Name));
			writer.Write(", Function(c)");
			this.Generate(alterColumnOperation.Column, writer, false);
			writer.WriteLine(")");
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x0002AB10 File Offset: 0x00028D10
		protected internal virtual void GenerateAnnotations(global::System.Collections.Generic.IDictionary<string, object> annotations, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IDictionary<string, object>>(annotations, "annotations");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.WriteLine("New Dictionary(Of String, Object)() From _");
			writer.WriteLine("{");
			int indent = writer.Indent;
			writer.Indent = indent + 1;
			string[] array = (from k in annotations.Keys
			orderby k
			select k).ToArray<string>();
			for (int i = 0; i < array.Length; i++)
			{
				writer.Write("{ ");
				writer.Write(this.Quote(array[i]) + ", ");
				this.GenerateAnnotation(array[i], annotations[array[i]], writer);
				writer.WriteLine((i < array.Length - 1) ? " }," : " }");
			}
			indent = writer.Indent;
			writer.Indent = indent - 1;
			writer.Write("}");
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0002AC08 File Offset: 0x00028E08
		protected internal virtual void GenerateAnnotations(global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues>>(annotations, "annotations");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.WriteLine("New Dictionary(Of String, AnnotationValues)() From _");
			writer.WriteLine("{");
			int indent = writer.Indent;
			writer.Indent = indent + 1;
			if (annotations != null)
			{
				string[] array = (from k in annotations.Keys
				orderby k
				select k).ToArray<string>();
				for (int i = 0; i < array.Length; i++)
				{
					writer.WriteLine("{");
					indent = writer.Indent;
					writer.Indent = indent + 1;
					writer.WriteLine(this.Quote(array[i]) + ",");
					writer.Write("New AnnotationValues(oldValue := ");
					this.GenerateAnnotation(array[i], annotations[array[i]].OldValue, writer);
					writer.Write(", newValue := ");
					this.GenerateAnnotation(array[i], annotations[array[i]].NewValue, writer);
					writer.WriteLine(")");
					indent = writer.Indent;
					writer.Indent = indent - 1;
					writer.WriteLine((i < array.Length - 1) ? " }," : " }");
				}
			}
			indent = writer.Indent;
			writer.Indent = indent - 1;
			writer.Write("}");
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x0002AD68 File Offset: 0x00028F68
		protected internal virtual void GenerateAnnotation(string name, object annotation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			if (annotation == null)
			{
				writer.Write("Nothing");
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

		// Token: 0x06001186 RID: 4486 RVA: 0x0002ADD0 File Offset: 0x00028FD0
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.CreateProcedureOperation createProcedureOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.CreateProcedureOperation>(createProcedureOperation, "createProcedureOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			this.Generate(createProcedureOperation, "CreateStoredProcedure", writer);
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x0002ADF7 File Offset: 0x00028FF7
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.AlterProcedureOperation alterProcedureOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.AlterProcedureOperation>(alterProcedureOperation, "alterProcedureOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			this.Generate(alterProcedureOperation, "AlterStoredProcedure", writer);
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x0002AE20 File Offset: 0x00029020
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
				writer.WriteLine("Function(p) New With");
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer3 = writer;
				indent = writer3.Indent;
				writer3.Indent = indent + 1;
				writer.WriteLine("{");
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer4 = writer;
				indent = writer4.Indent;
				writer4.Indent = indent + 1;
				procedureOperation.Parameters.Each(delegate(global::System.Data.Entity.Migrations.Model.ParameterModel p, int i)
				{
					string text = this.ScrubName(p.Name);
					writer.Write(".");
					writer.Write(text);
					writer.Write(" =");
					this.Generate(p, writer, !string.Equals(p.Name, text, global::System.StringComparison.Ordinal));
					if (i < procedureOperation.Parameters.Count - 1)
					{
						writer.Write(",");
					}
					writer.WriteLine();
				});
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer5 = writer;
				indent = writer5.Indent;
				writer5.Indent = indent - 1;
				writer.WriteLine("},");
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer6 = writer;
				indent = writer6.Indent;
				writer6.Indent = indent - 1;
			}
			writer.Write("body :=");
			if (!string.IsNullOrWhiteSpace(procedureOperation.BodySql))
			{
				writer.WriteLine();
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer7 = writer;
				indent = writer7.Indent;
				writer7.Indent = indent + 1;
				string newValue = "\" & vbCrLf & _" + writer.NewLine + writer.CurrentIndentation() + "\"";
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
			writer.WriteLine(")");
			writer.WriteLine();
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x0002B044 File Offset: 0x00029244
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
				list.Add("name := " + this.Quote(parameterModel.Name));
			}
			if (parameterModel.MaxLength != null)
			{
				list.Add("maxLength := " + parameterModel.MaxLength.ToString());
			}
			if (parameterModel.Precision != null)
			{
				list.Add("precision := " + parameterModel.Precision.ToString());
			}
			if (parameterModel.Scale != null)
			{
				list.Add("scale := " + parameterModel.Scale.ToString());
			}
			if (parameterModel.IsFixedLength != null)
			{
				list.Add("fixedLength := " + parameterModel.IsFixedLength.ToString().ToLowerInvariant());
			}
			if (parameterModel.IsUnicode != null)
			{
				list.Add("unicode := " + parameterModel.IsUnicode.ToString().ToLowerInvariant());
			}
			if (parameterModel.DefaultValue != null)
			{
				if (global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__18.<>p__2 == null)
				{
					global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__18.<>p__2 = global::System.Runtime.CompilerServices.CallSite<global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Collections.Generic.List<string>, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.ResultDiscarded, "Add", null, typeof(global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
					}));
				}
				global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Collections.Generic.List<string>, object> target = global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__18.<>p__2.Target;
				global::System.Runtime.CompilerServices.CallSite <>p__ = global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__18.<>p__2;
				global::System.Collections.Generic.List<string> arg = list;
				if (global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__18.<>p__1 == null)
				{
					global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__18.<>p__1 = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, string, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::System.Linq.Expressions.ExpressionType.Add, typeof(global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType | global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.Constant, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
					}));
				}
				global::System.Func<global::System.Runtime.CompilerServices.CallSite, string, object, object> target2 = global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__18.<>p__1.Target;
				global::System.Runtime.CompilerServices.CallSite <>p__2 = global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__18.<>p__1;
				string arg2 = "defaultValue := ";
				if (global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__18.<>p__0 == null)
				{
					global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__18.<>p__0 = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.InvokeSimpleName, "Generate", null, typeof(global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
					}));
				}
				target(<>p__, arg, target2(<>p__2, arg2, global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__18.<>p__0.Target(global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__18.<>p__0, this, parameterModel.DefaultValue)));
			}
			if (!string.IsNullOrWhiteSpace(parameterModel.DefaultValueSql))
			{
				list.Add("defaultValueSql := " + this.Quote(parameterModel.DefaultValueSql));
			}
			if (!string.IsNullOrWhiteSpace(parameterModel.StoreType))
			{
				list.Add("storeType := " + this.Quote(parameterModel.StoreType));
			}
			if (parameterModel.IsOutParameter)
			{
				list.Add("outParameter := True");
			}
			writer.Write(list.Join(null, ", "));
			writer.Write(")");
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x0002B35C File Offset: 0x0002955C
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.DropProcedureOperation dropProcedureOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.DropProcedureOperation>(dropProcedureOperation, "dropProcedureOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("DropStoredProcedure(");
			writer.Write(this.Quote(dropProcedureOperation.Name));
			writer.WriteLine(")");
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0002B3AC File Offset: 0x000295AC
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
			writer.WriteLine("Function(c) New With");
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer3 = writer;
			indent = writer3.Indent;
			writer3.Indent = indent + 1;
			writer.WriteLine("{");
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer4 = writer;
			indent = writer4.Indent;
			writer4.Indent = indent + 1;
			int columnCount = createTableOperation.Columns.Count<global::System.Data.Entity.Migrations.Model.ColumnModel>();
			createTableOperation.Columns.Each(delegate(global::System.Data.Entity.Migrations.Model.ColumnModel c, int i)
			{
				string text = this.ScrubName(c.Name);
				writer.Write(".");
				writer.Write(text);
				writer.Write(" =");
				this.Generate(c, writer, !string.Equals(c.Name, text, global::System.StringComparison.Ordinal));
				if (i < columnCount - 1)
				{
					writer.Write(",");
				}
				writer.WriteLine();
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
				writer.Write("annotations := ");
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
			writer.WriteLine();
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer7 = writer;
			indent = writer7.Indent;
			writer7.Indent = indent - 1;
			writer.WriteLine();
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x0002B5E8 File Offset: 0x000297E8
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
			writer.WriteLine("Function(c) New With");
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer3 = writer;
			indent = writer3.Indent;
			writer3.Indent = indent + 1;
			writer.WriteLine("{");
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer4 = writer;
			indent = writer4.Indent;
			writer4.Indent = indent + 1;
			int columnCount = alterTableOperation.Columns.Count<global::System.Data.Entity.Migrations.Model.ColumnModel>();
			alterTableOperation.Columns.Each(delegate(global::System.Data.Entity.Migrations.Model.ColumnModel c, int i)
			{
				string text = this.ScrubName(c.Name);
				writer.Write(".");
				writer.Write(text);
				writer.Write(" =");
				this.Generate(c, writer, !string.Equals(c.Name, text, global::System.StringComparison.Ordinal));
				if (i < columnCount - 1)
				{
					writer.Write(",");
				}
				writer.WriteLine();
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
				writer.Write("annotations := ");
				this.GenerateAnnotations(alterTableOperation.Annotations, writer);
			}
			writer.Write(")");
			writer.WriteLine();
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer7 = writer;
			indent = writer7.Indent;
			writer7.Indent = indent - 1;
			writer.WriteLine();
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x0002B798 File Offset: 0x00029998
		protected virtual void GenerateInline(global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation addPrimaryKeyOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			if (addPrimaryKeyOperation != null)
			{
				writer.WriteLine(" _");
				writer.Write(".PrimaryKey(");
				this.Generate(addPrimaryKeyOperation.Columns, writer);
				if (!addPrimaryKeyOperation.HasDefaultName)
				{
					writer.Write(", name := ");
					writer.Write(this.Quote(addPrimaryKeyOperation.Name));
				}
				if (!addPrimaryKeyOperation.IsClustered)
				{
					writer.Write(", clustered := False");
				}
				writer.Write(")");
			}
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x0002B81C File Offset: 0x00029A1C
		protected virtual void GenerateInline(global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation addForeignKeyOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation>(addForeignKeyOperation, "addForeignKeyOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.WriteLine(" _");
			writer.Write(".ForeignKey(" + this.Quote(addForeignKeyOperation.PrincipalTable) + ", ");
			this.Generate(addForeignKeyOperation.DependentColumns, writer);
			if (addForeignKeyOperation.CascadeDelete)
			{
				writer.Write(", cascadeDelete := True");
			}
			writer.Write(")");
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x0002B898 File Offset: 0x00029A98
		protected virtual void GenerateInline(global::System.Data.Entity.Migrations.Model.CreateIndexOperation createIndexOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.CreateIndexOperation>(createIndexOperation, "createIndexOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.WriteLine(" _");
			writer.Write(".Index(");
			this.Generate(createIndexOperation.Columns, writer);
			this.WriteIndexParameters(createIndexOperation, writer);
			writer.Write(")");
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0002B8F4 File Offset: 0x00029AF4
		protected virtual void Generate(global::System.Collections.Generic.IEnumerable<string> columns, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<string>>(columns, "columns");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("Function(t) ");
			if (columns.Count<string>() == 1)
			{
				writer.Write("t." + this.ScrubName(columns.Single<string>()));
				return;
			}
			writer.Write("New With { " + columns.Join((string c) => "t." + this.ScrubName(c), ", ") + " }");
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x0002B978 File Offset: 0x00029B78
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
				writer.Write("New String() { ");
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
					writer.Write("New String() { ");
				}
				writer.Write(addForeignKeyOperation.PrincipalColumns.Join(new global::System.Func<string, string>(this.Quote), ", "));
				if (flag)
				{
					writer.Write(" }");
				}
			}
			if (addForeignKeyOperation.CascadeDelete)
			{
				writer.Write(", cascadeDelete := True");
			}
			if (!addForeignKeyOperation.HasDefaultName)
			{
				writer.Write(", name := ");
				writer.Write(this.Quote(addForeignKeyOperation.Name));
			}
			writer.WriteLine(")");
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0002BACC File Offset: 0x00029CCC
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
					writer.Write("New String() { ");
				}
				writer.Write(dropForeignKeyOperation.DependentColumns.Join(new global::System.Func<string, string>(this.Quote), ", "));
				if (flag)
				{
					writer.Write(" }");
				}
				writer.Write(", ");
				writer.Write(this.Quote(dropForeignKeyOperation.PrincipalTable));
			}
			writer.WriteLine(")");
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x0002BBAC File Offset: 0x00029DAC
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
				writer.Write("New String() { ");
			}
			writer.Write(addPrimaryKeyOperation.Columns.Join(new global::System.Func<string, string>(this.Quote), ", "));
			if (flag)
			{
				writer.Write(" }");
			}
			if (!addPrimaryKeyOperation.HasDefaultName)
			{
				writer.Write(", name := ");
				writer.Write(this.Quote(addPrimaryKeyOperation.Name));
			}
			if (!addPrimaryKeyOperation.IsClustered)
			{
				writer.Write(", clustered := False");
			}
			writer.WriteLine(")");
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x0002BC88 File Offset: 0x00029E88
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation dropPrimaryKeyOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation>(dropPrimaryKeyOperation, "dropPrimaryKeyOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("DropPrimaryKey(");
			writer.Write(this.Quote(dropPrimaryKeyOperation.Table));
			if (!dropPrimaryKeyOperation.HasDefaultName)
			{
				writer.Write(", name := ");
				writer.Write(this.Quote(dropPrimaryKeyOperation.Name));
			}
			writer.WriteLine(")");
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x0002BCFC File Offset: 0x00029EFC
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
				writer.Write("New String() { ");
			}
			writer.Write(createIndexOperation.Columns.Join(new global::System.Func<string, string>(this.Quote), ", "));
			if (flag)
			{
				writer.Write(" }");
			}
			this.WriteIndexParameters(createIndexOperation, writer);
			writer.WriteLine(")");
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x0002BDA8 File Offset: 0x00029FA8
		private void WriteIndexParameters(global::System.Data.Entity.Migrations.Model.CreateIndexOperation createIndexOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			if (createIndexOperation.IsUnique)
			{
				writer.Write(", unique := True");
			}
			if (createIndexOperation.IsClustered)
			{
				writer.Write(", clustered := True");
			}
			if (!createIndexOperation.HasDefaultName)
			{
				writer.Write(", name := ");
				writer.Write(this.Quote(createIndexOperation.Name));
			}
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x0002BE00 File Offset: 0x0002A000
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
				writer.Write("New String() { ");
				writer.Write(dropIndexOperation.Columns.Join(new global::System.Func<string, string>(this.Quote), ", "));
				writer.Write(" }");
			}
			writer.WriteLine(")");
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x0002BEB0 File Offset: 0x0002A0B0
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
				list.Add("name := " + this.Quote(column.Name));
			}
			bool? isNullable = column.IsNullable;
			bool flag = false;
			if (isNullable.GetValueOrDefault() == flag & isNullable != null)
			{
				list.Add("nullable := False");
			}
			if (column.MaxLength != null)
			{
				list.Add("maxLength := " + column.MaxLength.ToString());
			}
			if (column.Precision != null)
			{
				list.Add("precision := " + column.Precision.ToString());
			}
			if (column.Scale != null)
			{
				list.Add("scale := " + column.Scale.ToString());
			}
			if (column.IsFixedLength != null)
			{
				list.Add("fixedLength := " + column.IsFixedLength.ToString().ToLowerInvariant());
			}
			if (column.IsUnicode != null)
			{
				list.Add("unicode := " + column.IsUnicode.ToString().ToLowerInvariant());
			}
			if (column.IsIdentity)
			{
				list.Add("identity := True");
			}
			if (column.DefaultValue != null)
			{
				if (global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__33.<>p__2 == null)
				{
					global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__33.<>p__2 = global::System.Runtime.CompilerServices.CallSite<global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Collections.Generic.List<string>, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.ResultDiscarded, "Add", null, typeof(global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
					}));
				}
				global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Collections.Generic.List<string>, object> target = global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__33.<>p__2.Target;
				global::System.Runtime.CompilerServices.CallSite <>p__ = global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__33.<>p__2;
				global::System.Collections.Generic.List<string> arg = list;
				if (global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__33.<>p__1 == null)
				{
					global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__33.<>p__1 = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, string, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::System.Linq.Expressions.ExpressionType.Add, typeof(global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType | global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.Constant, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
					}));
				}
				global::System.Func<global::System.Runtime.CompilerServices.CallSite, string, object, object> target2 = global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__33.<>p__1.Target;
				global::System.Runtime.CompilerServices.CallSite <>p__2 = global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__33.<>p__1;
				string arg2 = "defaultValue := ";
				if (global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__33.<>p__0 == null)
				{
					global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__33.<>p__0 = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.InvokeSimpleName, "Generate", null, typeof(global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
					}));
				}
				target(<>p__, arg, target2(<>p__2, arg2, global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__33.<>p__0.Target(global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator.<>o__33.<>p__0, this, column.DefaultValue)));
			}
			if (!string.IsNullOrWhiteSpace(column.DefaultValueSql))
			{
				list.Add("defaultValueSql := " + this.Quote(column.DefaultValueSql));
			}
			if (column.IsTimestamp)
			{
				list.Add("timestamp := True");
			}
			if (!string.IsNullOrWhiteSpace(column.StoreType))
			{
				list.Add("storeType := " + this.Quote(column.StoreType));
			}
			writer.Write(list.Join(null, ", "));
			if (column.Annotations.Any<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues>>())
			{
				int indent = writer.Indent;
				writer.Indent = indent + 1;
				writer.WriteLine(list.Any<string>() ? "," : "");
				writer.Write("annotations := ");
				this.GenerateAnnotations(column.Annotations, writer);
				indent = writer.Indent;
				writer.Indent = indent - 1;
			}
			writer.Write(")");
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x0002C26A File Offset: 0x0002A46A
		protected virtual string Generate(byte[] defaultValue)
		{
			return "New Byte() {" + defaultValue.Join(null, ", ") + "}";
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x0002C288 File Offset: 0x0002A488
		protected virtual string Generate(global::System.DateTime defaultValue)
		{
			return string.Concat(new string[]
			{
				"New DateTime(",
				defaultValue.Ticks.ToString(),
				", DateTimeKind.",
				global::System.Enum.GetName(typeof(global::System.DateTimeKind), defaultValue.Kind),
				")"
			});
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x0002C2E8 File Offset: 0x0002A4E8
		protected virtual string Generate(global::System.DateTimeOffset defaultValue)
		{
			return string.Concat(new string[]
			{
				"New DateTimeOffset(",
				defaultValue.Ticks.ToString(),
				", new TimeSpan(",
				defaultValue.Offset.Ticks.ToString(),
				"))"
			});
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x0002C344 File Offset: 0x0002A544
		protected virtual string Generate(decimal defaultValue)
		{
			return defaultValue.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "D";
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x0002C35C File Offset: 0x0002A55C
		protected virtual string Generate(global::System.Guid defaultValue)
		{
			string str = "New Guid(\"";
			global::System.Guid guid = defaultValue;
			return str + guid.ToString() + "\")";
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x0002C387 File Offset: 0x0002A587
		protected virtual string Generate(long defaultValue)
		{
			return defaultValue.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0002C395 File Offset: 0x0002A595
		protected virtual string Generate(float defaultValue)
		{
			return defaultValue.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "F";
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x0002C3AD File Offset: 0x0002A5AD
		protected virtual string Generate(string defaultValue)
		{
			return this.Quote(defaultValue);
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x0002C3B8 File Offset: 0x0002A5B8
		protected virtual string Generate(global::System.TimeSpan defaultValue)
		{
			return "New TimeSpan(" + defaultValue.Ticks.ToString() + ")";
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x0002C3E3 File Offset: 0x0002A5E3
		protected virtual string Generate(global::System.Data.Entity.Hierarchy.HierarchyId defaultValue)
		{
			return "New HierarchyId(\"" + ((defaultValue != null) ? defaultValue.ToString() : null) + "\")";
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x0002C404 File Offset: 0x0002A604
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

		// Token: 0x060011A4 RID: 4516 RVA: 0x0002C450 File Offset: 0x0002A650
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

		// Token: 0x060011A5 RID: 4517 RVA: 0x0002C49A File Offset: 0x0002A69A
		protected virtual string Generate(object defaultValue)
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}", new object[]
			{
				defaultValue
			}).ToLowerInvariant();
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0002C4BC File Offset: 0x0002A6BC
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
				writer.Write("removedAnnotations := ");
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
				writer.Write("removedColumnAnnotations := ");
				writer.WriteLine("New Dictionary(Of String, IDictionary(Of String, Object)) From _");
				writer.WriteLine("{");
				indent = writer.Indent;
				writer.Indent = indent + 1;
				string[] array = (from k in removedColumnAnnotations.Keys
				orderby k
				select k).ToArray<string>();
				for (int i = 0; i < array.Length; i++)
				{
					writer.WriteLine("{");
					indent = writer.Indent;
					writer.Indent = indent + 1;
					writer.WriteLine(this.Quote(array[i]) + ",");
					this.GenerateAnnotations(removedColumnAnnotations[array[i]], writer);
					writer.WriteLine();
					indent = writer.Indent;
					writer.Indent = indent - 1;
					writer.WriteLine((i < array.Length - 1) ? " }," : " }");
				}
				indent = writer.Indent;
				writer.Indent = indent - 1;
				writer.Write("}");
				indent = writer.Indent;
				writer.Indent = indent - 1;
			}
			writer.WriteLine(")");
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x0002C694 File Offset: 0x0002A894
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.MoveTableOperation moveTableOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.MoveTableOperation>(moveTableOperation, "moveTableOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("MoveTable(name := ");
			writer.Write(this.Quote(moveTableOperation.Name));
			writer.Write(", newSchema := ");
			writer.Write(string.IsNullOrWhiteSpace(moveTableOperation.NewSchema) ? "Nothing" : this.Quote(moveTableOperation.NewSchema));
			writer.WriteLine(")");
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0002C714 File Offset: 0x0002A914
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.MoveProcedureOperation moveProcedureOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.MoveProcedureOperation>(moveProcedureOperation, "moveProcedureOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("MoveStoredProcedure(name := ");
			writer.Write(this.Quote(moveProcedureOperation.Name));
			writer.Write(", newSchema := ");
			writer.Write(string.IsNullOrWhiteSpace(moveProcedureOperation.NewSchema) ? "Nothing" : this.Quote(moveProcedureOperation.NewSchema));
			writer.WriteLine(")");
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0002C794 File Offset: 0x0002A994
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.RenameTableOperation renameTableOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.RenameTableOperation>(renameTableOperation, "renameTableOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("RenameTable(name := ");
			writer.Write(this.Quote(renameTableOperation.Name));
			writer.Write(", newName := ");
			writer.Write(this.Quote(renameTableOperation.NewName));
			writer.WriteLine(")");
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0002C800 File Offset: 0x0002AA00
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.RenameProcedureOperation renameProcedureOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.RenameProcedureOperation>(renameProcedureOperation, "renameProcedureOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("RenameStoredProcedure(name := ");
			writer.Write(this.Quote(renameProcedureOperation.Name));
			writer.Write(", newName := ");
			writer.Write(this.Quote(renameProcedureOperation.NewName));
			writer.WriteLine(")");
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0002C86C File Offset: 0x0002AA6C
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.RenameColumnOperation renameColumnOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.RenameColumnOperation>(renameColumnOperation, "renameColumnOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("RenameColumn(table := ");
			writer.Write(this.Quote(renameColumnOperation.Table));
			writer.Write(", name := ");
			writer.Write(this.Quote(renameColumnOperation.Name));
			writer.Write(", newName := ");
			writer.Write(this.Quote(renameColumnOperation.NewName));
			writer.WriteLine(")");
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0002C8F4 File Offset: 0x0002AAF4
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.RenameIndexOperation renameIndexOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.RenameIndexOperation>(renameIndexOperation, "renameIndexOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("RenameIndex(table := ");
			writer.Write(this.Quote(renameIndexOperation.Table));
			writer.Write(", name := ");
			writer.Write(this.Quote(renameIndexOperation.Name));
			writer.Write(", newName := ");
			writer.Write(this.Quote(renameIndexOperation.NewName));
			writer.WriteLine(")");
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x0002C97C File Offset: 0x0002AB7C
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.SqlOperation sqlOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.SqlOperation>(sqlOperation, "sqlOperation");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write("Sql(");
			writer.Write(this.Quote(sqlOperation.Sql));
			if (sqlOperation.SuppressTransaction)
			{
				writer.Write(", suppressTransaction := True");
			}
			writer.WriteLine(")");
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x0002C9DC File Offset: 0x0002ABDC
		protected virtual string ScrubName(string name)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			name = new global::System.Text.RegularExpressions.Regex("[^\\p{Ll}\\p{Lu}\\p{Lt}\\p{Lo}\\p{Nd}\\p{Nl}\\p{Mn}\\p{Mc}\\p{Cf}\\p{Pc}\\p{Lm}]").Replace(name, string.Empty);
			using (global::Microsoft.VisualBasic.VBCodeProvider vbcodeProvider = new global::Microsoft.VisualBasic.VBCodeProvider())
			{
				if ((!char.IsLetter(name[0]) && name[0] != '_') || !vbcodeProvider.IsValidIdentifier(name))
				{
					name = "_" + name;
				}
			}
			return name;
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x0002CA60 File Offset: 0x0002AC60
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

		// Token: 0x060011B0 RID: 4528 RVA: 0x0002CAA0 File Offset: 0x0002ACA0
		protected virtual string Quote(string identifier)
		{
			return "\"" + identifier + "\"";
		}

		// Token: 0x040008EA RID: 2282
		private global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Migrations.Model.CreateTableOperation, global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation>> _newTableForeignKeys;

		// Token: 0x040008EB RID: 2283
		private global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Migrations.Model.CreateTableOperation, global::System.Data.Entity.Migrations.Model.CreateIndexOperation>> _newTableIndexes;
	}
}
