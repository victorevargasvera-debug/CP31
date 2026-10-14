using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x02000670 RID: 1648
	internal sealed class TypeResolver
	{
		// Token: 0x06004F00 RID: 20224 RVA: 0x0011E918 File Offset: 0x0011CB18
		internal TypeResolver(global::System.Data.Entity.Core.Metadata.Edm.Perspective perspective, global::System.Data.Entity.Core.Common.EntitySql.ParserOptions parserOptions)
		{
			this._perspective = perspective;
			this._parserOptions = parserOptions;
			this._aliasedNamespaces = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace>(parserOptions.NameComparer);
			this._namespaces = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace>(global::System.Data.Entity.Core.Common.EntitySql.MetadataMember.CreateMetadataMemberNameEqualityComparer(parserOptions.NameComparer));
			this._functionDefinitions = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionInfo>>(parserOptions.NameComparer);
			this._includeInlineFunctions = true;
			this._resolveLeftMostUnqualifiedNameAsNamespaceOnly = false;
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06004F01 RID: 20225 RVA: 0x0011E97F File Offset: 0x0011CB7F
		internal global::System.Data.Entity.Core.Metadata.Edm.Perspective Perspective
		{
			get
			{
				return this._perspective;
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x06004F02 RID: 20226 RVA: 0x0011E987 File Offset: 0x0011CB87
		internal global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace> NamespaceImports
		{
			get
			{
				return this._namespaces;
			}
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x06004F03 RID: 20227 RVA: 0x0011E98F File Offset: 0x0011CB8F
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage StringType
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String);
			}
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06004F04 RID: 20228 RVA: 0x0011E998 File Offset: 0x0011CB98
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage BooleanType
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean);
			}
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06004F05 RID: 20229 RVA: 0x0011E9A0 File Offset: 0x0011CBA0
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Int64Type
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64);
			}
		}

		// Token: 0x06004F06 RID: 20230 RVA: 0x0011E9AC File Offset: 0x0011CBAC
		internal void AddAliasedNamespaceImport(string alias, global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace @namespace, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			if (this._aliasedNamespaces.ContainsKey(alias))
			{
				string errorMessage = global::System.Data.Entity.Resources.Strings.NamespaceAliasAlreadyUsed(alias);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			this._aliasedNamespaces.Add(alias, @namespace);
		}

		// Token: 0x06004F07 RID: 20231 RVA: 0x0011E9E4 File Offset: 0x0011CBE4
		internal void AddNamespaceImport(global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace @namespace, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			if (this._namespaces.Contains(@namespace))
			{
				string errorMessage = global::System.Data.Entity.Resources.Strings.NamespaceAlreadyImported(@namespace.Name);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			this._namespaces.Add(@namespace);
		}

		// Token: 0x06004F08 RID: 20232 RVA: 0x0011EA24 File Offset: 0x0011CC24
		internal void DeclareInlineFunction(string name, global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionInfo functionInfo)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionInfo> list;
			if (!this._functionDefinitions.TryGetValue(name, out list))
			{
				list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionInfo>();
				this._functionDefinitions.Add(name, list);
			}
			if (list.Exists((global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionInfo overload) => (from p in overload.Parameters
			select p.ResultType).SequenceEqual(from p in functionInfo.Parameters
			select p.ResultType, global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.TypeUsageStructuralComparer.Instance)))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = functionInfo.FunctionDefAst.ErrCtx;
				string errorMessage = global::System.Data.Entity.Resources.Strings.DuplicatedInlineFunctionOverload(name);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			list.Add(functionInfo);
		}

		// Token: 0x06004F09 RID: 20233 RVA: 0x0011EAA0 File Offset: 0x0011CCA0
		internal global::System.IDisposable EnterFunctionNameResolution(bool includeInlineFunctions)
		{
			bool savedIncludeInlineFunctions = this._includeInlineFunctions;
			this._includeInlineFunctions = includeInlineFunctions;
			return new global::System.Data.Entity.Core.Common.EntitySql.Disposer(delegate()
			{
				this._includeInlineFunctions = savedIncludeInlineFunctions;
			});
		}

		// Token: 0x06004F0A RID: 20234 RVA: 0x0011EAD1 File Offset: 0x0011CCD1
		internal global::System.IDisposable EnterBackwardCompatibilityResolution()
		{
			this._resolveLeftMostUnqualifiedNameAsNamespaceOnly = true;
			return new global::System.Data.Entity.Core.Common.EntitySql.Disposer(delegate()
			{
				this._resolveLeftMostUnqualifiedNameAsNamespaceOnly = false;
			});
		}

		// Token: 0x06004F0B RID: 20235 RVA: 0x0011EAEC File Offset: 0x0011CCEC
		internal global::System.Data.Entity.Core.Common.EntitySql.MetadataMember ResolveMetadataMemberName(string[] name, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			global::System.Data.Entity.Core.Common.EntitySql.MetadataMember result;
			if (name.Length == 1)
			{
				result = this.ResolveUnqualifiedName(name[0], false, errCtx);
			}
			else
			{
				result = this.ResolveFullyQualifiedName(name, name.Length, errCtx);
			}
			return result;
		}

		// Token: 0x06004F0C RID: 20236 RVA: 0x0011EB1C File Offset: 0x0011CD1C
		internal global::System.Data.Entity.Core.Common.EntitySql.MetadataMember ResolveMetadataMemberAccess(global::System.Data.Entity.Core.Common.EntitySql.MetadataMember qualifier, string name, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			string fullName = global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.GetFullName(new string[]
			{
				qualifier.Name,
				name
			});
			if (qualifier.MetadataMemberClass != global::System.Data.Entity.Core.Common.EntitySql.MetadataMemberClass.Namespace)
			{
				if (qualifier.MetadataMemberClass == global::System.Data.Entity.Core.Common.EntitySql.MetadataMemberClass.Type)
				{
					global::System.Data.Entity.Core.Common.EntitySql.MetadataType metadataType = (global::System.Data.Entity.Core.Common.EntitySql.MetadataType)qualifier;
					if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEnumerationType(metadataType.TypeUsage))
					{
						global::System.Data.Entity.Core.Metadata.Edm.EnumMember enumMember;
						if (this._perspective.TryGetEnumMember((global::System.Data.Entity.Core.Metadata.Edm.EnumType)metadataType.TypeUsage.EdmType, name, this._parserOptions.NameComparisonCaseInsensitive, out enumMember))
						{
							return new global::System.Data.Entity.Core.Common.EntitySql.MetadataEnumMember(fullName, metadataType.TypeUsage, enumMember);
						}
						string errorMessage = global::System.Data.Entity.Resources.Strings.NotAMemberOfType(name, qualifier.Name);
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
					}
				}
				string errorMessage2 = global::System.Data.Entity.Resources.Strings.InvalidMetadataMemberClassResolution(qualifier.Name, qualifier.MetadataMemberClassName, global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace.NamespaceClassName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage2, null);
			}
			global::System.Data.Entity.Core.Common.EntitySql.MetadataType result;
			if (this.TryGetTypeFromMetadata(fullName, out result))
			{
				return result;
			}
			global::System.Data.Entity.Core.Common.EntitySql.MetadataFunctionGroup result2;
			if (this.TryGetFunctionFromMetadata(qualifier.Name, name, out result2))
			{
				return result2;
			}
			return new global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace(fullName);
		}

		// Token: 0x06004F0D RID: 20237 RVA: 0x0011EC04 File Offset: 0x0011CE04
		internal global::System.Data.Entity.Core.Common.EntitySql.MetadataMember ResolveUnqualifiedName(string name, bool partOfQualifiedName, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			bool flag = partOfQualifiedName && this._resolveLeftMostUnqualifiedNameAsNamespaceOnly;
			bool flag2 = !partOfQualifiedName;
			global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionGroup result;
			if (!flag && flag2 && this.TryGetInlineFunction(name, out result))
			{
				return result;
			}
			global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace result2;
			if (this._aliasedNamespaces.TryGetValue(name, out result2))
			{
				return result2;
			}
			if (!flag)
			{
				global::System.Data.Entity.Core.Common.EntitySql.MetadataType metadataType = null;
				global::System.Data.Entity.Core.Common.EntitySql.MetadataFunctionGroup metadataFunctionGroup = null;
				if (!this.TryGetTypeFromMetadata(name, out metadataType) && flag2)
				{
					string[] array = name.Split(new char[]
					{
						'.'
					});
					if (array.Length > 1)
					{
						if (array.All((string p) => p.Length > 0))
						{
							string text = array[array.Length - 1];
							string namespaceName = name.Substring(0, name.Length - text.Length - 1);
							this.TryGetFunctionFromMetadata(namespaceName, text, out metadataFunctionGroup);
						}
					}
				}
				global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace ns = null;
				foreach (global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace metadataNamespace in this._namespaces)
				{
					string fullName = global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.GetFullName(new string[]
					{
						metadataNamespace.Name,
						name
					});
					global::System.Data.Entity.Core.Common.EntitySql.MetadataType metadataType2;
					if (this.TryGetTypeFromMetadata(fullName, out metadataType2))
					{
						if (metadataType != null || metadataFunctionGroup != null)
						{
							throw global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.AmbiguousMetadataMemberName(errCtx, name, metadataNamespace, ns);
						}
						metadataType = metadataType2;
						ns = metadataNamespace;
					}
					global::System.Data.Entity.Core.Common.EntitySql.MetadataFunctionGroup metadataFunctionGroup2;
					if (flag2 && this.TryGetFunctionFromMetadata(metadataNamespace.Name, name, out metadataFunctionGroup2))
					{
						if (metadataType != null || metadataFunctionGroup != null)
						{
							throw global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.AmbiguousMetadataMemberName(errCtx, name, metadataNamespace, ns);
						}
						metadataFunctionGroup = metadataFunctionGroup2;
						ns = metadataNamespace;
					}
				}
				if (metadataType != null)
				{
					return metadataType;
				}
				if (metadataFunctionGroup != null)
				{
					return metadataFunctionGroup;
				}
			}
			return new global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace(name);
		}

		// Token: 0x06004F0E RID: 20238 RVA: 0x0011EDB0 File Offset: 0x0011CFB0
		private global::System.Data.Entity.Core.Common.EntitySql.MetadataMember ResolveFullyQualifiedName(string[] name, int length, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			global::System.Data.Entity.Core.Common.EntitySql.MetadataMember qualifier;
			if (length == 2)
			{
				qualifier = this.ResolveUnqualifiedName(name[0], true, errCtx);
			}
			else
			{
				qualifier = this.ResolveFullyQualifiedName(name, length - 1, errCtx);
			}
			string name2 = name[length - 1];
			return this.ResolveMetadataMemberAccess(qualifier, name2, errCtx);
		}

		// Token: 0x06004F0F RID: 20239 RVA: 0x0011EDEC File Offset: 0x0011CFEC
		private static global::System.Exception AmbiguousMetadataMemberName(global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx, string name, global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace ns1, global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace ns2)
		{
			string errorMessage = global::System.Data.Entity.Resources.Strings.AmbiguousMetadataMemberName(name, ns1.Name, (ns2 != null) ? ns2.Name : null);
			throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
		}

		// Token: 0x06004F10 RID: 20240 RVA: 0x0011EE1C File Offset: 0x0011D01C
		private bool TryGetTypeFromMetadata(string typeFullName, out global::System.Data.Entity.Core.Common.EntitySql.MetadataType type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
			if (this._perspective.TryGetTypeByName(typeFullName, this._parserOptions.NameComparisonCaseInsensitive, out typeUsage))
			{
				type = new global::System.Data.Entity.Core.Common.EntitySql.MetadataType(typeFullName, typeUsage);
				return true;
			}
			type = null;
			return false;
		}

		// Token: 0x06004F11 RID: 20241 RVA: 0x0011EE54 File Offset: 0x0011D054
		internal bool TryGetFunctionFromMetadata(string namespaceName, string functionName, out global::System.Data.Entity.Core.Common.EntitySql.MetadataFunctionGroup functionGroup)
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> functionMetadata;
			if (this._perspective.TryGetFunctionByName(namespaceName, functionName, this._parserOptions.NameComparisonCaseInsensitive, out functionMetadata))
			{
				functionGroup = new global::System.Data.Entity.Core.Common.EntitySql.MetadataFunctionGroup(global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.GetFullName(new string[]
				{
					namespaceName,
					functionName
				}), functionMetadata);
				return true;
			}
			functionGroup = null;
			return false;
		}

		// Token: 0x06004F12 RID: 20242 RVA: 0x0011EEA0 File Offset: 0x0011D0A0
		private bool TryGetInlineFunction(string functionName, out global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionGroup inlineFunctionGroup)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionInfo> functionMetadata;
			if (this._includeInlineFunctions && this._functionDefinitions.TryGetValue(functionName, out functionMetadata))
			{
				inlineFunctionGroup = new global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionGroup(functionName, functionMetadata);
				return true;
			}
			inlineFunctionGroup = null;
			return false;
		}

		// Token: 0x06004F13 RID: 20243 RVA: 0x0011EED4 File Offset: 0x0011D0D4
		internal static string GetFullName(params string[] names)
		{
			return string.Join(".", names);
		}

		// Token: 0x04001C8A RID: 7306
		private readonly global::System.Data.Entity.Core.Metadata.Edm.Perspective _perspective;

		// Token: 0x04001C8B RID: 7307
		private readonly global::System.Data.Entity.Core.Common.EntitySql.ParserOptions _parserOptions;

		// Token: 0x04001C8C RID: 7308
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace> _aliasedNamespaces;

		// Token: 0x04001C8D RID: 7309
		private readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace> _namespaces;

		// Token: 0x04001C8E RID: 7310
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionInfo>> _functionDefinitions;

		// Token: 0x04001C8F RID: 7311
		private bool _includeInlineFunctions;

		// Token: 0x04001C90 RID: 7312
		private bool _resolveLeftMostUnqualifiedNameAsNamespaceOnly;

		// Token: 0x02000C8D RID: 3213
		private sealed class TypeUsageStructuralComparer : global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>
		{
			// Token: 0x06006BED RID: 27629 RVA: 0x0016FD3F File Offset: 0x0016DF3F
			private TypeUsageStructuralComparer()
			{
			}

			// Token: 0x17001198 RID: 4504
			// (get) Token: 0x06006BEE RID: 27630 RVA: 0x0016FD47 File Offset: 0x0016DF47
			public static global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.TypeUsageStructuralComparer Instance
			{
				get
				{
					return global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.TypeUsageStructuralComparer._instance;
				}
			}

			// Token: 0x06006BEF RID: 27631 RVA: 0x0016FD4E File Offset: 0x0016DF4E
			public bool Equals(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage x, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage y)
			{
				return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqual(x, y);
			}

			// Token: 0x06006BF0 RID: 27632 RVA: 0x0016FD57 File Offset: 0x0016DF57
			public int GetHashCode(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage obj)
			{
				return 0;
			}

			// Token: 0x040031A4 RID: 12708
			private static readonly global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.TypeUsageStructuralComparer _instance = new global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.TypeUsageStructuralComparer();
		}
	}
}
