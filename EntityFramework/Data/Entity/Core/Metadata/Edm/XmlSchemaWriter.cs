using System;
using System.Text;
using System.Xml;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000506 RID: 1286
	internal abstract class XmlSchemaWriter
	{
		// Token: 0x06003FB3 RID: 16307 RVA: 0x000D32D8 File Offset: 0x000D14D8
		internal void WriteComment(string comment)
		{
			if (!string.IsNullOrEmpty(comment))
			{
				this._xmlWriter.WriteComment(comment);
			}
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x000D32EE File Offset: 0x000D14EE
		internal virtual void WriteEndElement()
		{
			this._xmlWriter.WriteEndElement();
		}

		// Token: 0x06003FB5 RID: 16309 RVA: 0x000D32FB File Offset: 0x000D14FB
		protected static string GetQualifiedTypeName(string prefix, string typeName)
		{
			return new global::System.Text.StringBuilder().Append(prefix).Append(".").Append(typeName).ToString();
		}

		// Token: 0x06003FB6 RID: 16310 RVA: 0x000D331D File Offset: 0x000D151D
		internal static string GetLowerCaseStringFromBoolValue(bool value)
		{
			if (!value)
			{
				return "false";
			}
			return "true";
		}

		// Token: 0x0400163B RID: 5691
		protected global::System.Xml.XmlWriter _xmlWriter;

		// Token: 0x0400163C RID: 5692
		protected double _version;
	}
}
