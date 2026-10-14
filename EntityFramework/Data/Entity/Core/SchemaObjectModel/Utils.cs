using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Xml;
using System.Xml.Schema;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000325 RID: 805
	internal static class Utils
	{
		// Token: 0x06002658 RID: 9816 RVA: 0x0006D73E File Offset: 0x0006B93E
		internal static void ExtractNamespaceAndName(string qualifiedTypeName, out string namespaceName, out string name)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetBeforeAndAfterLastPeriod(qualifiedTypeName, out namespaceName, out name);
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x0006D748 File Offset: 0x0006B948
		internal static string ExtractTypeName(string qualifiedTypeName)
		{
			return global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetEverythingAfterLastPeriod(qualifiedTypeName);
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x0006D750 File Offset: 0x0006B950
		private static void GetBeforeAndAfterLastPeriod(string qualifiedTypeName, out string before, out string after)
		{
			int num = qualifiedTypeName.LastIndexOf('.');
			if (num < 0)
			{
				before = null;
				after = qualifiedTypeName;
				return;
			}
			before = qualifiedTypeName.Substring(0, num);
			after = qualifiedTypeName.Substring(num + 1);
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x0006D788 File Offset: 0x0006B988
		internal static string GetEverythingBeforeLastPeriod(string qualifiedTypeName)
		{
			int num = qualifiedTypeName.LastIndexOf('.');
			if (num < 0)
			{
				return null;
			}
			return qualifiedTypeName.Substring(0, num);
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x0006D7AC File Offset: 0x0006B9AC
		private static string GetEverythingAfterLastPeriod(string qualifiedTypeName)
		{
			int num = qualifiedTypeName.LastIndexOf('.');
			if (num < 0)
			{
				return qualifiedTypeName;
			}
			return qualifiedTypeName.Substring(num + 1);
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x0006D7D1 File Offset: 0x0006B9D1
		public static bool GetString(global::System.Data.Entity.Core.SchemaObjectModel.Schema schema, global::System.Xml.XmlReader reader, out string value)
		{
			if (reader.SchemaInfo.Validity == global::System.Xml.Schema.XmlSchemaValidity.Invalid)
			{
				value = null;
				return false;
			}
			value = reader.Value;
			if (string.IsNullOrEmpty(value))
			{
				schema.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidName, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, reader, global::System.Data.Entity.Resources.Strings.InvalidName(value, reader.Name));
				return false;
			}
			return true;
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x0006D811 File Offset: 0x0006BA11
		public static bool GetDottedName(global::System.Data.Entity.Core.SchemaObjectModel.Schema schema, global::System.Xml.XmlReader reader, out string name)
		{
			return global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetString(schema, reader, out name) && global::System.Data.Entity.Core.SchemaObjectModel.Utils.ValidateDottedName(schema, reader, name);
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x0006D828 File Offset: 0x0006BA28
		internal static bool ValidateDottedName(global::System.Data.Entity.Core.SchemaObjectModel.Schema schema, global::System.Xml.XmlReader reader, string name)
		{
			if (schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
			{
				string[] array = name.Split(new char[]
				{
					'.'
				});
				for (int i = 0; i < array.Length; i++)
				{
					if (!array[i].IsValidUndottedName())
					{
						schema.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidName, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, reader, global::System.Data.Entity.Resources.Strings.InvalidName(name, reader.Name));
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x0006D880 File Offset: 0x0006BA80
		public static bool GetUndottedName(global::System.Data.Entity.Core.SchemaObjectModel.Schema schema, global::System.Xml.XmlReader reader, out string name)
		{
			if (reader.SchemaInfo.Validity == global::System.Xml.Schema.XmlSchemaValidity.Invalid)
			{
				name = null;
				return false;
			}
			name = reader.Value;
			if (string.IsNullOrEmpty(name))
			{
				schema.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidName, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, reader, global::System.Data.Entity.Resources.Strings.EmptyName(reader.Name));
				return false;
			}
			if (schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel && !name.IsValidUndottedName())
			{
				schema.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidName, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, reader, global::System.Data.Entity.Resources.Strings.InvalidName(name, reader.Name));
				return false;
			}
			return true;
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x0006D8F4 File Offset: 0x0006BAF4
		public static bool GetBool(global::System.Data.Entity.Core.SchemaObjectModel.Schema schema, global::System.Xml.XmlReader reader, out bool value)
		{
			if (reader.SchemaInfo.Validity == global::System.Xml.Schema.XmlSchemaValidity.Invalid)
			{
				value = true;
				return false;
			}
			try
			{
				value = reader.ReadContentAsBoolean();
				return true;
			}
			catch (global::System.Xml.XmlException)
			{
				schema.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.BoolValueExpected, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, reader, global::System.Data.Entity.Resources.Strings.ValueNotUnderstood(reader.Value, reader.Name));
			}
			value = true;
			return false;
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x0006D958 File Offset: 0x0006BB58
		public static bool GetInt(global::System.Data.Entity.Core.SchemaObjectModel.Schema schema, global::System.Xml.XmlReader reader, out int value)
		{
			if (reader.SchemaInfo.Validity == global::System.Xml.Schema.XmlSchemaValidity.Invalid)
			{
				value = 0;
				return false;
			}
			string value2 = reader.Value;
			value = int.MinValue;
			if (int.TryParse(value2, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out value))
			{
				return true;
			}
			schema.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.IntegerExpected, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, reader, global::System.Data.Entity.Resources.Strings.ValueNotUnderstood(reader.Value, reader.Name));
			return false;
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x0006D9B4 File Offset: 0x0006BBB4
		public static bool GetByte(global::System.Data.Entity.Core.SchemaObjectModel.Schema schema, global::System.Xml.XmlReader reader, out byte value)
		{
			if (reader.SchemaInfo.Validity == global::System.Xml.Schema.XmlSchemaValidity.Invalid)
			{
				value = 0;
				return false;
			}
			string value2 = reader.Value;
			value = 0;
			if (byte.TryParse(value2, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out value))
			{
				return true;
			}
			schema.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.ByteValueExpected, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, reader, global::System.Data.Entity.Resources.Strings.ValueNotUnderstood(reader.Value, reader.Name));
			return false;
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x0006DA09 File Offset: 0x0006BC09
		public static int CompareNames(string lhsName, string rhsName)
		{
			return string.Compare(lhsName, rhsName, global::System.StringComparison.Ordinal);
		}
	}
}
