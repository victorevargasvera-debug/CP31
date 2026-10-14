using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace System.Data.Entity.Migrations.Edm
{
	// Token: 0x020000E0 RID: 224
	internal static class EdmXNames
	{
		// Token: 0x060010E9 RID: 4329 RVA: 0x00026B0B File Offset: 0x00024D0B
		public static string ActionAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("Action");
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x00026B22 File Offset: 0x00024D22
		public static string ColumnNameAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("ColumnName");
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x00026B39 File Offset: 0x00024D39
		public static string EntitySetAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("EntitySet");
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x00026B50 File Offset: 0x00024D50
		public static string NameAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("Name");
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x00026B67 File Offset: 0x00024D67
		public static string NamespaceAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("Namespace");
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x00026B7E File Offset: 0x00024D7E
		public static string EntityTypeAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("EntityType");
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x00026B95 File Offset: 0x00024D95
		public static string FromRoleAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("FromRole");
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x00026BAC File Offset: 0x00024DAC
		public static string ToRoleAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("ToRole");
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x00026BC3 File Offset: 0x00024DC3
		public static string NullableAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("Nullable");
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00026BDA File Offset: 0x00024DDA
		public static string MaxLengthAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("MaxLength");
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00026BF1 File Offset: 0x00024DF1
		public static string MultiplicityAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("Multiplicity");
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x00026C08 File Offset: 0x00024E08
		public static string FixedLengthAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("FixedLength");
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x00026C1F File Offset: 0x00024E1F
		public static string PrecisionAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("Precision");
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x00026C36 File Offset: 0x00024E36
		public static string ProviderAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("Provider");
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x00026C4D File Offset: 0x00024E4D
		public static string ProviderManifestTokenAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("ProviderManifestToken");
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00026C64 File Offset: 0x00024E64
		public static string RelationshipAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("Relationship");
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00026C7B File Offset: 0x00024E7B
		public static string ScaleAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("Scale");
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00026C92 File Offset: 0x00024E92
		public static string StoreGeneratedPatternAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("StoreGeneratedPattern");
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x00026CA9 File Offset: 0x00024EA9
		public static string UnicodeAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("Unicode");
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x00026CC0 File Offset: 0x00024EC0
		public static string RoleAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("Role");
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x00026CD7 File Offset: 0x00024ED7
		public static string SchemaAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("Schema");
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x00026CEE File Offset: 0x00024EEE
		public static string StoreEntitySetAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("StoreEntitySet");
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x00026D05 File Offset: 0x00024F05
		public static string TableAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("Table");
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x00026D1C File Offset: 0x00024F1C
		public static string TypeAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("Type");
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x00026D33 File Offset: 0x00024F33
		public static string TypeNameAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("TypeName");
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x00026D4A File Offset: 0x00024F4A
		public static string ValueAttribute(this global::System.Xml.Linq.XElement element)
		{
			return (string)element.Attribute("Value");
		}

		// Token: 0x040008CD RID: 2253
		private static readonly global::System.Xml.Linq.XNamespace _csdlNamespaceV2 = global::System.Xml.Linq.XNamespace.Get("http://schemas.microsoft.com/ado/2008/09/edm");

		// Token: 0x040008CE RID: 2254
		private static readonly global::System.Xml.Linq.XNamespace _mslNamespaceV2 = global::System.Xml.Linq.XNamespace.Get("http://schemas.microsoft.com/ado/2008/09/mapping/cs");

		// Token: 0x040008CF RID: 2255
		private static readonly global::System.Xml.Linq.XNamespace _ssdlNamespaceV2 = global::System.Xml.Linq.XNamespace.Get("http://schemas.microsoft.com/ado/2009/02/edm/ssdl");

		// Token: 0x040008D0 RID: 2256
		private static readonly global::System.Xml.Linq.XNamespace _csdlNamespaceV3 = global::System.Xml.Linq.XNamespace.Get("http://schemas.microsoft.com/ado/2009/11/edm");

		// Token: 0x040008D1 RID: 2257
		private static readonly global::System.Xml.Linq.XNamespace _mslNamespaceV3 = global::System.Xml.Linq.XNamespace.Get("http://schemas.microsoft.com/ado/2009/11/mapping/cs");

		// Token: 0x040008D2 RID: 2258
		private static readonly global::System.Xml.Linq.XNamespace _ssdlNamespaceV3 = global::System.Xml.Linq.XNamespace.Get("http://schemas.microsoft.com/ado/2009/11/edm/ssdl");

		// Token: 0x020007BE RID: 1982
		public static class Csdl
		{
			// Token: 0x0600584F RID: 22607 RVA: 0x00137FCB File Offset: 0x001361CB
			private static global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> Names(string elementName)
			{
				return new global::System.Collections.Generic.List<global::System.Xml.Linq.XName>
				{
					global::System.Data.Entity.Migrations.Edm.EdmXNames._csdlNamespaceV3 + elementName,
					global::System.Data.Entity.Migrations.Edm.EdmXNames._csdlNamespaceV2 + elementName
				};
			}

			// Token: 0x04002127 RID: 8487
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> AssociationNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Csdl.Names("Association");

			// Token: 0x04002128 RID: 8488
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> ComplexTypeNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Csdl.Names("ComplexType");

			// Token: 0x04002129 RID: 8489
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> EndNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Csdl.Names("End");

			// Token: 0x0400212A RID: 8490
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> EntityContainerNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Csdl.Names("EntityContainer");

			// Token: 0x0400212B RID: 8491
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> EntitySetNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Csdl.Names("EntitySet");

			// Token: 0x0400212C RID: 8492
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> EntityTypeNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Csdl.Names("EntityType");

			// Token: 0x0400212D RID: 8493
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> NavigationPropertyNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Csdl.Names("NavigationProperty");

			// Token: 0x0400212E RID: 8494
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> PropertyNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Csdl.Names("Property");

			// Token: 0x0400212F RID: 8495
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> SchemaNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Csdl.Names("Schema");
		}

		// Token: 0x020007BF RID: 1983
		public static class Msl
		{
			// Token: 0x06005851 RID: 22609 RVA: 0x00138088 File Offset: 0x00136288
			private static global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> Names(string elementName)
			{
				return new global::System.Collections.Generic.List<global::System.Xml.Linq.XName>
				{
					global::System.Data.Entity.Migrations.Edm.EdmXNames._mslNamespaceV3 + elementName,
					global::System.Data.Entity.Migrations.Edm.EdmXNames._mslNamespaceV2 + elementName
				};
			}

			// Token: 0x04002130 RID: 8496
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> AssociationSetMappingNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Msl.Names("AssociationSetMapping");

			// Token: 0x04002131 RID: 8497
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> ComplexPropertyNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Msl.Names("ComplexProperty");

			// Token: 0x04002132 RID: 8498
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> ConditionNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Msl.Names("Condition");

			// Token: 0x04002133 RID: 8499
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> EntityContainerMappingNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Msl.Names("EntityContainerMapping");

			// Token: 0x04002134 RID: 8500
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> EntitySetMappingNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Msl.Names("EntitySetMapping");

			// Token: 0x04002135 RID: 8501
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> EntityTypeMappingNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Msl.Names("EntityTypeMapping");

			// Token: 0x04002136 RID: 8502
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> MappingNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Msl.Names("Mapping");

			// Token: 0x04002137 RID: 8503
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> MappingFragmentNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Msl.Names("MappingFragment");

			// Token: 0x04002138 RID: 8504
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> ScalarPropertyNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Msl.Names("ScalarProperty");
		}

		// Token: 0x020007C0 RID: 1984
		public static class Ssdl
		{
			// Token: 0x06005853 RID: 22611 RVA: 0x00138148 File Offset: 0x00136348
			private static global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> Names(string elementName)
			{
				return new global::System.Collections.Generic.List<global::System.Xml.Linq.XName>
				{
					global::System.Data.Entity.Migrations.Edm.EdmXNames._ssdlNamespaceV3 + elementName,
					global::System.Data.Entity.Migrations.Edm.EdmXNames._ssdlNamespaceV2 + elementName
				};
			}

			// Token: 0x04002139 RID: 8505
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> AssociationNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Ssdl.Names("Association");

			// Token: 0x0400213A RID: 8506
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> DependentNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Ssdl.Names("Dependent");

			// Token: 0x0400213B RID: 8507
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> EndNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Ssdl.Names("End");

			// Token: 0x0400213C RID: 8508
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> EntityContainerNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Ssdl.Names("EntityContainer");

			// Token: 0x0400213D RID: 8509
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> EntitySetNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Ssdl.Names("EntitySet");

			// Token: 0x0400213E RID: 8510
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> EntityTypeNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Ssdl.Names("EntityType");

			// Token: 0x0400213F RID: 8511
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> KeyNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Ssdl.Names("Key");

			// Token: 0x04002140 RID: 8512
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> OnDeleteNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Ssdl.Names("OnDelete");

			// Token: 0x04002141 RID: 8513
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> PrincipalNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Ssdl.Names("Principal");

			// Token: 0x04002142 RID: 8514
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> PropertyNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Ssdl.Names("Property");

			// Token: 0x04002143 RID: 8515
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> PropertyRefNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Ssdl.Names("PropertyRef");

			// Token: 0x04002144 RID: 8516
			public static readonly global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> SchemaNames = global::System.Data.Entity.Migrations.Edm.EdmXNames.Ssdl.Names("Schema");
		}
	}
}
