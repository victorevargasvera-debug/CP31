using System;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Text;
using System.Text.RegularExpressions;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration
{
	// Token: 0x020005BC RID: 1468
	internal static class CqlWriter
	{
		// Token: 0x06004751 RID: 18257 RVA: 0x000FAF9D File Offset: 0x000F919D
		internal static string GetQualifiedName(string blockName, string field)
		{
			return global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("{0}.{1}", new object[]
			{
				blockName,
				field
			});
		}

		// Token: 0x06004752 RID: 18258 RVA: 0x000FAFB7 File Offset: 0x000F91B7
		internal static void AppendEscapedTypeName(global::System.Text.StringBuilder builder, global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedName(builder, global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.GetQualifiedName(type.NamespaceName, type.Name));
		}

		// Token: 0x06004753 RID: 18259 RVA: 0x000FAFD0 File Offset: 0x000F91D0
		internal static void AppendEscapedQualifiedName(global::System.Text.StringBuilder builder, string name1, string name2)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedName(builder, name1);
			builder.Append('.');
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedName(builder, name2);
		}

		// Token: 0x06004754 RID: 18260 RVA: 0x000FAFEC File Offset: 0x000F91EC
		internal static void AppendEscapedName(global::System.Text.StringBuilder builder, string name)
		{
			if (global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter._wordIdentifierRegex.IsMatch(name) && !global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ExternalCalls.IsReservedKeyword(name))
			{
				builder.Append(name);
				return;
			}
			string value = name.Replace("]", "]]");
			builder.Append('[').Append(value).Append(']');
		}

		// Token: 0x0400194A RID: 6474
		private static readonly global::System.Text.RegularExpressions.Regex _wordIdentifierRegex = new global::System.Text.RegularExpressions.Regex("^[_A-Za-z]\\w*$", global::System.Text.RegularExpressions.RegexOptions.Compiled | global::System.Text.RegularExpressions.RegexOptions.ECMAScript);
	}
}
