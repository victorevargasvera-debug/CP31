using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200054D RID: 1357
	internal class MetadataMappingHasherVisitor : global::System.Data.Entity.Core.Mapping.BaseMetadataMappingVisitor
	{
		// Token: 0x060042A0 RID: 17056 RVA: 0x000E44C4 File Offset: 0x000E26C4
		private MetadataMappingHasherVisitor(double mappingVersion, bool sortSequence) : base(sortSequence)
		{
			this.m_MappingVersion = mappingVersion;
			this.m_hashSourceBuilder = new global::System.Data.Entity.Core.Mapping.CompressingHashBuilder(global::System.Data.Entity.Core.Common.Utils.MetadataHelper.CreateMetadataHashAlgorithm(this.m_MappingVersion));
		}

		// Token: 0x060042A1 RID: 17057 RVA: 0x000E44F8 File Offset: 0x000E26F8
		protected override void Visit(global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping)
		{
			this.m_MappingVersion = entityContainerMapping.StorageMappingItemCollection.MappingVersion;
			this.m_EdmItemCollection = entityContainerMapping.StorageMappingItemCollection.EdmItemCollection;
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(entityContainerMapping, out objectIndex))
			{
				return;
			}
			if (this.m_itemsAlreadySeen.Count > 1)
			{
				this.Clean();
				this.Visit(entityContainerMapping);
				return;
			}
			this.AddObjectStartDumpToHashBuilder(entityContainerMapping, objectIndex);
			this.AddObjectContentToHashBuilder(entityContainerMapping.Identity);
			this.AddV2ObjectContentToHashBuilder(entityContainerMapping.GenerateUpdateViews, this.m_MappingVersion);
			base.Visit(entityContainerMapping);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042A2 RID: 17058 RVA: 0x000E4588 File Offset: 0x000E2788
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(entityContainer, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(entityContainer, objectIndex);
			this.AddObjectContentToHashBuilder(entityContainer.Identity);
			base.Visit(entityContainer);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042A3 RID: 17059 RVA: 0x000E45C4 File Offset: 0x000E27C4
		protected override void Visit(global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping setMapping)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(setMapping, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(setMapping, objectIndex);
			base.Visit(setMapping);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042A4 RID: 17060 RVA: 0x000E45F4 File Offset: 0x000E27F4
		protected override void Visit(global::System.Data.Entity.Core.Mapping.TypeMapping typeMapping)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(typeMapping, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(typeMapping, objectIndex);
			base.Visit(typeMapping);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042A5 RID: 17061 RVA: 0x000E4624 File Offset: 0x000E2824
		protected override void Visit(global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(mappingFragment, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(mappingFragment, objectIndex);
			this.AddV2ObjectContentToHashBuilder(mappingFragment.IsSQueryDistinct, this.m_MappingVersion);
			base.Visit(mappingFragment);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042A6 RID: 17062 RVA: 0x000E4669 File Offset: 0x000E2869
		protected override void Visit(global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping)
		{
			base.Visit(propertyMapping);
		}

		// Token: 0x060042A7 RID: 17063 RVA: 0x000E4674 File Offset: 0x000E2874
		protected override void Visit(global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping complexPropertyMapping)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(complexPropertyMapping, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(complexPropertyMapping, objectIndex);
			base.Visit(complexPropertyMapping);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042A8 RID: 17064 RVA: 0x000E46A4 File Offset: 0x000E28A4
		protected override void Visit(global::System.Data.Entity.Core.Mapping.ComplexTypeMapping complexTypeMapping)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(complexTypeMapping, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(complexTypeMapping, objectIndex);
			base.Visit(complexTypeMapping);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042A9 RID: 17065 RVA: 0x000E46D4 File Offset: 0x000E28D4
		protected override void Visit(global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping conditionPropertyMapping)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(conditionPropertyMapping, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(conditionPropertyMapping, objectIndex);
			this.AddObjectContentToHashBuilder(conditionPropertyMapping.IsNull);
			this.AddObjectContentToHashBuilder(conditionPropertyMapping.Value);
			base.Visit(conditionPropertyMapping);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042AA RID: 17066 RVA: 0x000E4720 File Offset: 0x000E2920
		protected override void Visit(global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(scalarPropertyMapping, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(scalarPropertyMapping, objectIndex);
			base.Visit(scalarPropertyMapping);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042AB RID: 17067 RVA: 0x000E474E File Offset: 0x000E294E
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase)
		{
			base.Visit(entitySetBase);
		}

		// Token: 0x060042AC RID: 17068 RVA: 0x000E4758 File Offset: 0x000E2958
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(entitySet, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(entitySet, objectIndex);
			this.AddObjectContentToHashBuilder(entitySet.Name);
			this.AddObjectContentToHashBuilder(entitySet.Schema);
			this.AddObjectContentToHashBuilder(entitySet.Table);
			base.Visit(entitySet);
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmType> sequence = from type in global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf(entitySet.ElementType, this.m_EdmItemCollection, false)
			where type != entitySet.ElementType
			select type;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType in base.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(sequence, (global::System.Data.Entity.Core.Metadata.Edm.EdmType it) => it.Identity))
			{
				this.Visit(edmType);
			}
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x000E4860 File Offset: 0x000E2A60
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(associationSet, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(associationSet, objectIndex);
			this.AddObjectContentToHashBuilder(associationSet.Identity);
			this.AddObjectContentToHashBuilder(associationSet.Schema);
			this.AddObjectContentToHashBuilder(associationSet.Table);
			base.Visit(associationSet);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042AE RID: 17070 RVA: 0x000E48B4 File Offset: 0x000E2AB4
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(entityType, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(entityType, objectIndex);
			this.AddObjectContentToHashBuilder(entityType.Abstract);
			this.AddObjectContentToHashBuilder(entityType.Identity);
			base.Visit(entityType);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042AF RID: 17071 RVA: 0x000E4900 File Offset: 0x000E2B00
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(associationSetEnd, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(associationSetEnd, objectIndex);
			this.AddObjectContentToHashBuilder(associationSetEnd.Identity);
			base.Visit(associationSetEnd);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042B0 RID: 17072 RVA: 0x000E493C File Offset: 0x000E2B3C
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(associationType, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(associationType, objectIndex);
			this.AddObjectContentToHashBuilder(associationType.Abstract);
			this.AddObjectContentToHashBuilder(associationType.Identity);
			base.Visit(associationType);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042B1 RID: 17073 RVA: 0x000E4988 File Offset: 0x000E2B88
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(edmProperty, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(edmProperty, objectIndex);
			this.AddObjectContentToHashBuilder(edmProperty.DefaultValue);
			this.AddObjectContentToHashBuilder(edmProperty.Identity);
			this.AddObjectContentToHashBuilder(edmProperty.IsStoreGeneratedComputed);
			this.AddObjectContentToHashBuilder(edmProperty.IsStoreGeneratedIdentity);
			this.AddObjectContentToHashBuilder(edmProperty.Nullable);
			base.Visit(edmProperty);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042B2 RID: 17074 RVA: 0x000E4A01 File Offset: 0x000E2C01
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty)
		{
		}

		// Token: 0x060042B3 RID: 17075 RVA: 0x000E4A04 File Offset: 0x000E2C04
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(edmMember, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(edmMember, objectIndex);
			this.AddObjectContentToHashBuilder(edmMember.Identity);
			this.AddObjectContentToHashBuilder(edmMember.IsStoreGeneratedComputed);
			this.AddObjectContentToHashBuilder(edmMember.IsStoreGeneratedIdentity);
			base.Visit(edmMember);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042B4 RID: 17076 RVA: 0x000E4A60 File Offset: 0x000E2C60
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(associationEndMember, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(associationEndMember, objectIndex);
			this.AddObjectContentToHashBuilder(associationEndMember.DeleteBehavior);
			this.AddObjectContentToHashBuilder(associationEndMember.Identity);
			this.AddObjectContentToHashBuilder(associationEndMember.IsStoreGeneratedComputed);
			this.AddObjectContentToHashBuilder(associationEndMember.IsStoreGeneratedIdentity);
			this.AddObjectContentToHashBuilder(associationEndMember.RelationshipMultiplicity);
			base.Visit(associationEndMember);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042B5 RID: 17077 RVA: 0x000E4AE0 File Offset: 0x000E2CE0
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(referentialConstraint, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(referentialConstraint, objectIndex);
			this.AddObjectContentToHashBuilder(referentialConstraint.Identity);
			base.Visit(referentialConstraint);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042B6 RID: 17078 RVA: 0x000E4B1C File Offset: 0x000E2D1C
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember relationshipEndMember)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(relationshipEndMember, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(relationshipEndMember, objectIndex);
			this.AddObjectContentToHashBuilder(relationshipEndMember.DeleteBehavior);
			this.AddObjectContentToHashBuilder(relationshipEndMember.Identity);
			this.AddObjectContentToHashBuilder(relationshipEndMember.IsStoreGeneratedComputed);
			this.AddObjectContentToHashBuilder(relationshipEndMember.IsStoreGeneratedIdentity);
			this.AddObjectContentToHashBuilder(relationshipEndMember.RelationshipMultiplicity);
			base.Visit(relationshipEndMember);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042B7 RID: 17079 RVA: 0x000E4B9C File Offset: 0x000E2D9C
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(typeUsage, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(typeUsage, objectIndex);
			base.Visit(typeUsage);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042B8 RID: 17080 RVA: 0x000E4BCA File Offset: 0x000E2DCA
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.RelationshipType relationshipType)
		{
			base.Visit(relationshipType);
		}

		// Token: 0x060042B9 RID: 17081 RVA: 0x000E4BD3 File Offset: 0x000E2DD3
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			base.Visit(edmType);
		}

		// Token: 0x060042BA RID: 17082 RVA: 0x000E4BDC File Offset: 0x000E2DDC
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.EnumType enumType)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(enumType, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(enumType, objectIndex);
			this.AddObjectContentToHashBuilder(enumType.Identity);
			this.Visit(enumType.UnderlyingType);
			base.Visit(enumType);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x000E4C24 File Offset: 0x000E2E24
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.EnumMember enumMember)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(enumMember, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(enumMember, objectIndex);
			this.AddObjectContentToHashBuilder(enumMember.Name);
			this.AddObjectContentToHashBuilder(enumMember.Value);
			base.Visit(enumMember);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x000E4C6C File Offset: 0x000E2E6C
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.CollectionType collectionType)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(collectionType, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(collectionType, objectIndex);
			this.AddObjectContentToHashBuilder(collectionType.Identity);
			base.Visit(collectionType);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042BD RID: 17085 RVA: 0x000E4CA8 File Offset: 0x000E2EA8
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.RefType refType)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(refType, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(refType, objectIndex);
			this.AddObjectContentToHashBuilder(refType.Identity);
			base.Visit(refType);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042BE RID: 17086 RVA: 0x000E4CE2 File Offset: 0x000E2EE2
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityTypeBase)
		{
			base.Visit(entityTypeBase);
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x000E4CEC File Offset: 0x000E2EEC
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.Facet facet)
		{
			if (facet.Name != "Nullable")
			{
				return;
			}
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(facet, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(facet, objectIndex);
			this.AddObjectContentToHashBuilder(facet.Identity);
			this.AddObjectContentToHashBuilder(facet.Value);
			base.Visit(facet);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042C0 RID: 17088 RVA: 0x000E4D45 File Offset: 0x000E2F45
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction)
		{
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x000E4D48 File Offset: 0x000E2F48
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(complexType, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(complexType, objectIndex);
			this.AddObjectContentToHashBuilder(complexType.Abstract);
			this.AddObjectContentToHashBuilder(complexType.Identity);
			base.Visit(complexType);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x000E4D94 File Offset: 0x000E2F94
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(primitiveType, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(primitiveType, objectIndex);
			this.AddObjectContentToHashBuilder(primitiveType.Name);
			this.AddObjectContentToHashBuilder(primitiveType.NamespaceName);
			base.Visit(primitiveType);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042C3 RID: 17091 RVA: 0x000E4DDC File Offset: 0x000E2FDC
		protected override void Visit(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter)
		{
			int objectIndex;
			if (!this.AddObjectToSeenListAndHashBuilder(functionParameter, out objectIndex))
			{
				return;
			}
			this.AddObjectStartDumpToHashBuilder(functionParameter, objectIndex);
			this.AddObjectContentToHashBuilder(functionParameter.Identity);
			this.AddObjectContentToHashBuilder(functionParameter.Mode);
			base.Visit(functionParameter);
			this.AddObjectEndDumpToHashBuilder();
		}

		// Token: 0x060042C4 RID: 17092 RVA: 0x000E4E27 File Offset: 0x000E3027
		protected override void Visit(global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x060042C5 RID: 17093 RVA: 0x000E4E29 File Offset: 0x000E3029
		internal string HashValue
		{
			get
			{
				return this.m_hashSourceBuilder.ComputeHash();
			}
		}

		// Token: 0x060042C6 RID: 17094 RVA: 0x000E4E36 File Offset: 0x000E3036
		private void Clean()
		{
			this.m_hashSourceBuilder = new global::System.Data.Entity.Core.Mapping.CompressingHashBuilder(global::System.Data.Entity.Core.Common.Utils.MetadataHelper.CreateMetadataHashAlgorithm(this.m_MappingVersion));
			this.m_instanceNumber = 0;
			this.m_itemsAlreadySeen = new global::System.Collections.Generic.Dictionary<object, int>();
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x000E4E60 File Offset: 0x000E3060
		private bool TryAddSeenItem(object o, out int indexSeen)
		{
			if (!this.m_itemsAlreadySeen.TryGetValue(o, out indexSeen))
			{
				this.m_itemsAlreadySeen.Add(o, this.m_instanceNumber);
				indexSeen = this.m_instanceNumber;
				this.m_instanceNumber++;
				return true;
			}
			return false;
		}

		// Token: 0x060042C8 RID: 17096 RVA: 0x000E4E9C File Offset: 0x000E309C
		private bool AddObjectToSeenListAndHashBuilder(object o, out int instanceIndex)
		{
			if (o == null)
			{
				instanceIndex = -1;
				return false;
			}
			if (!this.TryAddSeenItem(o, out instanceIndex))
			{
				this.AddObjectStartDumpToHashBuilder(o, instanceIndex);
				this.AddSeenObjectToHashBuilder(instanceIndex);
				this.AddObjectEndDumpToHashBuilder();
				return false;
			}
			return true;
		}

		// Token: 0x060042C9 RID: 17097 RVA: 0x000E4ECA File Offset: 0x000E30CA
		private void AddSeenObjectToHashBuilder(int instanceIndex)
		{
			this.m_hashSourceBuilder.AppendLine("Instance Reference: " + instanceIndex.ToString());
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x000E4EE8 File Offset: 0x000E30E8
		private void AddObjectStartDumpToHashBuilder(object o, int objectIndex)
		{
			this.m_hashSourceBuilder.AppendObjectStartDump(o, objectIndex);
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x000E4EF7 File Offset: 0x000E30F7
		private void AddObjectEndDumpToHashBuilder()
		{
			this.m_hashSourceBuilder.AppendObjectEndDump();
		}

		// Token: 0x060042CC RID: 17100 RVA: 0x000E4F04 File Offset: 0x000E3104
		private void AddObjectContentToHashBuilder(object content)
		{
			if (content == null)
			{
				this.m_hashSourceBuilder.AppendLine("NULL");
				return;
			}
			global::System.IFormattable formattable = content as global::System.IFormattable;
			if (formattable != null)
			{
				this.m_hashSourceBuilder.AppendLine(formattable.ToString(null, global::System.Globalization.CultureInfo.InvariantCulture));
				return;
			}
			this.m_hashSourceBuilder.AppendLine(content.ToString());
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x000E4F58 File Offset: 0x000E3158
		private void AddV2ObjectContentToHashBuilder(object content, double version)
		{
			if (version >= 2.0)
			{
				this.AddObjectContentToHashBuilder(content);
			}
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x000E4F6D File Offset: 0x000E316D
		internal static string GetMappingClosureHash(double mappingVersion, global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping, bool sortSequence = true)
		{
			global::System.Data.Entity.Core.Mapping.MetadataMappingHasherVisitor metadataMappingHasherVisitor = new global::System.Data.Entity.Core.Mapping.MetadataMappingHasherVisitor(mappingVersion, sortSequence);
			metadataMappingHasherVisitor.Visit(entityContainerMapping);
			return metadataMappingHasherVisitor.HashValue;
		}

		// Token: 0x0400177D RID: 6013
		private global::System.Data.Entity.Core.Mapping.CompressingHashBuilder m_hashSourceBuilder;

		// Token: 0x0400177E RID: 6014
		private global::System.Collections.Generic.Dictionary<object, int> m_itemsAlreadySeen = new global::System.Collections.Generic.Dictionary<object, int>();

		// Token: 0x0400177F RID: 6015
		private int m_instanceNumber;

		// Token: 0x04001780 RID: 6016
		private global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection m_EdmItemCollection;

		// Token: 0x04001781 RID: 6017
		private double m_MappingVersion;
	}
}
