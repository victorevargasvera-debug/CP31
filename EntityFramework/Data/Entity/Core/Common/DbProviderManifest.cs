using System;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Xml;

namespace System.Data.Entity.Core.Common
{
	// Token: 0x020005EB RID: 1515
	public abstract class DbProviderManifest
	{
		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06004A12 RID: 18962
		public abstract string NamespaceName { get; }

		// Token: 0x06004A13 RID: 18963
		public abstract global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> GetStoreTypes();

		// Token: 0x06004A14 RID: 18964
		public abstract global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> GetStoreFunctions();

		// Token: 0x06004A15 RID: 18965
		public abstract global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription> GetFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType);

		// Token: 0x06004A16 RID: 18966
		public abstract global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetEdmType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage storeType);

		// Token: 0x06004A17 RID: 18967
		public abstract global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetStoreType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage edmType);

		// Token: 0x06004A18 RID: 18968
		protected abstract global::System.Xml.XmlReader GetDbInformation(string informationType);

		// Token: 0x06004A19 RID: 18969 RVA: 0x00105E54 File Offset: 0x00104054
		public global::System.Xml.XmlReader GetInformation(string informationType)
		{
			global::System.Xml.XmlReader xmlReader = null;
			try
			{
				xmlReader = this.GetDbInformation(informationType);
			}
			catch (global::System.Exception ex)
			{
				if (ex.IsCatchableExceptionType())
				{
					throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.EntityClient_FailedToGetInformation(informationType), ex);
				}
				throw;
			}
			if (xmlReader != null)
			{
				return xmlReader;
			}
			if (informationType == "ConceptualSchemaDefinitionVersion3" || informationType == "ConceptualSchemaDefinition")
			{
				return global::System.Data.Entity.Core.Common.DbProviderServices.GetConceptualSchemaDefinition(informationType);
			}
			throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.ProviderReturnedNullForGetDbInformation(informationType));
		}

		// Token: 0x06004A1A RID: 18970 RVA: 0x00105EC8 File Offset: 0x001040C8
		public virtual bool SupportsEscapingLikeArgument(out char escapeCharacter)
		{
			escapeCharacter = '\0';
			return false;
		}

		// Token: 0x06004A1B RID: 18971 RVA: 0x00105ECE File Offset: 0x001040CE
		public virtual bool SupportsParameterOptimizationInSchemaQueries()
		{
			return false;
		}

		// Token: 0x06004A1C RID: 18972 RVA: 0x00105ED1 File Offset: 0x001040D1
		public virtual string EscapeLikeArgument(string argument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(argument, "argument");
			throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.ProviderShouldOverrideEscapeLikeArgument);
		}

		// Token: 0x06004A1D RID: 18973 RVA: 0x00105EE9 File Offset: 0x001040E9
		public virtual bool SupportsInExpression()
		{
			return false;
		}

		// Token: 0x06004A1E RID: 18974 RVA: 0x00105EEC File Offset: 0x001040EC
		public virtual bool SupportsIntersectAndUnionAllFlattening()
		{
			return false;
		}

		// Token: 0x04001A1B RID: 6683
		public const string StoreSchemaDefinition = "StoreSchemaDefinition";

		// Token: 0x04001A1C RID: 6684
		public const string StoreSchemaMapping = "StoreSchemaMapping";

		// Token: 0x04001A1D RID: 6685
		public const string ConceptualSchemaDefinition = "ConceptualSchemaDefinition";

		// Token: 0x04001A1E RID: 6686
		public const string StoreSchemaDefinitionVersion3 = "StoreSchemaDefinitionVersion3";

		// Token: 0x04001A1F RID: 6687
		public const string StoreSchemaMappingVersion3 = "StoreSchemaMappingVersion3";

		// Token: 0x04001A20 RID: 6688
		public const string ConceptualSchemaDefinitionVersion3 = "ConceptualSchemaDefinitionVersion3";

		// Token: 0x04001A21 RID: 6689
		public const string MaxLengthFacetName = "MaxLength";

		// Token: 0x04001A22 RID: 6690
		public const string UnicodeFacetName = "Unicode";

		// Token: 0x04001A23 RID: 6691
		public const string FixedLengthFacetName = "FixedLength";

		// Token: 0x04001A24 RID: 6692
		public const string PrecisionFacetName = "Precision";

		// Token: 0x04001A25 RID: 6693
		public const string ScaleFacetName = "Scale";

		// Token: 0x04001A26 RID: 6694
		public const string NullableFacetName = "Nullable";

		// Token: 0x04001A27 RID: 6695
		public const string DefaultValueFacetName = "DefaultValue";

		// Token: 0x04001A28 RID: 6696
		public const string CollationFacetName = "Collation";

		// Token: 0x04001A29 RID: 6697
		public const string SridFacetName = "SRID";

		// Token: 0x04001A2A RID: 6698
		public const string IsStrictFacetName = "IsStrict";
	}
}
