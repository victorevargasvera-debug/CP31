using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace System.Data.Entity.Infrastructure.Annotations
{
	// Token: 0x020002C6 RID: 710
	public class IndexAnnotationSerializer : global::System.Data.Entity.Infrastructure.IMetadataAnnotationSerializer
	{
		// Token: 0x06002233 RID: 8755 RVA: 0x0005F3A8 File Offset: 0x0005D5A8
		public virtual string Serialize(string name, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<object>(value, "value");
			global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation indexAnnotation = value as global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation;
			if (indexAnnotation == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.AnnotationSerializeWrongType(value.GetType().Name, typeof(global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotationSerializer).Name, typeof(global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation).Name));
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute indexAttribute in indexAnnotation.Indexes)
			{
				stringBuilder.Append(global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotationSerializer.SerializeIndexAttribute(indexAttribute));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x0005F45C File Offset: 0x0005D65C
		internal static string SerializeIndexAttribute(global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute indexAttribute)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder("{ ");
			if (!string.IsNullOrWhiteSpace(indexAttribute.Name))
			{
				stringBuilder.Append("Name: ").Append(indexAttribute.Name.Replace(",", "\\,").Replace("{", "\\{"));
			}
			if (indexAttribute.Order != -1)
			{
				if (stringBuilder.Length > 2)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("Order: ").Append(indexAttribute.Order);
			}
			if (indexAttribute.IsClusteredConfigured)
			{
				if (stringBuilder.Length > 2)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("IsClustered: ").Append(indexAttribute.IsClustered);
			}
			if (indexAttribute.IsUniqueConfigured)
			{
				if (stringBuilder.Length > 2)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("IsUnique: ").Append(indexAttribute.IsUnique);
			}
			if (stringBuilder.Length > 2)
			{
				stringBuilder.Append(" ");
			}
			stringBuilder.Append("}");
			return stringBuilder.ToString();
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x0005F57C File Offset: 0x0005D77C
		public virtual object Deserialize(string name, string value)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotEmpty(value, "value");
			value = value.Trim();
			if (!value.StartsWith("{", global::System.StringComparison.Ordinal) || !value.EndsWith("}", global::System.StringComparison.Ordinal))
			{
				throw global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotationSerializer.BuildFormatException(value);
			}
			global::System.Collections.Generic.List<global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute> list = new global::System.Collections.Generic.List<global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute>();
			global::System.Collections.Generic.List<string> list2 = (from s in global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotationSerializer._indexesSplitter.Split(value)
			select s.Trim()).ToList<string>();
			list2[0] = list2[0].Substring(1);
			int index = list2.Count - 1;
			list2[index] = list2[index].Substring(0, list2[index].Length - 1);
			foreach (string text in list2)
			{
				global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute indexAttribute = new global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute();
				if (!string.IsNullOrWhiteSpace(text))
				{
					foreach (string text2 in from s in global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotationSerializer._indexPartsSplitter.Split(text)
					select s.Trim())
					{
						if (text2.StartsWith("Name:", global::System.StringComparison.Ordinal))
						{
							string text3 = text2.Substring(5).Trim();
							if (string.IsNullOrWhiteSpace(text3) || !string.IsNullOrWhiteSpace(indexAttribute.Name))
							{
								throw global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotationSerializer.BuildFormatException(value);
							}
							indexAttribute.Name = text3.Replace("\\,", ",").Replace("\\{", "{");
						}
						else if (text2.StartsWith("Order:", global::System.StringComparison.Ordinal))
						{
							int order;
							if (!int.TryParse(text2.Substring(6).Trim(), out order) || indexAttribute.Order != -1)
							{
								throw global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotationSerializer.BuildFormatException(value);
							}
							indexAttribute.Order = order;
						}
						else if (text2.StartsWith("IsClustered:", global::System.StringComparison.Ordinal))
						{
							bool isClustered;
							if (!bool.TryParse(text2.Substring(12).Trim(), out isClustered) || indexAttribute.IsClusteredConfigured)
							{
								throw global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotationSerializer.BuildFormatException(value);
							}
							indexAttribute.IsClustered = isClustered;
						}
						else
						{
							if (!text2.StartsWith("IsUnique:", global::System.StringComparison.Ordinal))
							{
								throw global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotationSerializer.BuildFormatException(value);
							}
							bool isUnique;
							if (!bool.TryParse(text2.Substring(9).Trim(), out isUnique) || indexAttribute.IsUniqueConfigured)
							{
								throw global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotationSerializer.BuildFormatException(value);
							}
							indexAttribute.IsUnique = isUnique;
						}
					}
				}
				list.Add(indexAttribute);
			}
			return new global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation(list);
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x0005F860 File Offset: 0x0005DA60
		private static global::System.FormatException BuildFormatException(string value)
		{
			return new global::System.FormatException(global::System.Data.Entity.Resources.Strings.AnnotationSerializeBadFormat(value, typeof(global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotationSerializer).Name, "{ Name: MyIndex, Order: 7, IsClustered: True, IsUnique: False } { } { Name: MyOtherIndex }"));
		}

		// Token: 0x04000BE4 RID: 3044
		internal const string FormatExample = "{ Name: MyIndex, Order: 7, IsClustered: True, IsUnique: False } { } { Name: MyOtherIndex }";

		// Token: 0x04000BE5 RID: 3045
		private static readonly global::System.Text.RegularExpressions.Regex _indexesSplitter = new global::System.Text.RegularExpressions.Regex("(?<!\\\\)}\\s*{", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x04000BE6 RID: 3046
		private static readonly global::System.Text.RegularExpressions.Regex _indexPartsSplitter = new global::System.Text.RegularExpressions.Regex("(?<!\\\\),", global::System.Text.RegularExpressions.RegexOptions.Compiled);
	}
}
