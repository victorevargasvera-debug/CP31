using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004AA RID: 1194
	public class EdmModel : global::System.Data.Entity.Core.Metadata.Edm.MetadataItem
	{
		// Token: 0x06003AC3 RID: 15043 RVA: 0x000C1154 File Offset: 0x000BF354
		private EdmModel(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer, double version = 3.0)
		{
			this._container = entityContainer;
			this.SchemaVersion = version;
		}

		// Token: 0x06003AC4 RID: 15044 RVA: 0x000C11AC File Offset: 0x000BF3AC
		internal EdmModel(global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, double schemaVersion = 3.0)
		{
			if (dataSpace != global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace && dataSpace != global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.MetadataItem_InvalidDataSpace(dataSpace, typeof(global::System.Data.Entity.Core.Metadata.Edm.EdmModel).Name), "dataSpace");
			}
			this._container = new global::System.Data.Entity.Core.Metadata.Edm.EntityContainer((dataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace) ? "CodeFirstContainer" : "CodeFirstDatabase", dataSpace);
			this._schemaVersion = schemaVersion;
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06003AC5 RID: 15045 RVA: 0x000C1246 File Offset: 0x000BF446
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataItem;
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06003AC6 RID: 15046 RVA: 0x000C124A File Offset: 0x000BF44A
		internal override string Identity
		{
			get
			{
				return "EdmModel" + this.Container.Identity;
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06003AC7 RID: 15047 RVA: 0x000C1261 File Offset: 0x000BF461
		public global::System.Data.Entity.Core.Metadata.Edm.DataSpace DataSpace
		{
			get
			{
				return this.Container.DataSpace;
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06003AC8 RID: 15048 RVA: 0x000C126E File Offset: 0x000BF46E
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> AssociationTypes
		{
			get
			{
				return this._associationTypes;
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06003AC9 RID: 15049 RVA: 0x000C1276 File Offset: 0x000BF476
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.ComplexType> ComplexTypes
		{
			get
			{
				return this._complexTypes;
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06003ACA RID: 15050 RVA: 0x000C127E File Offset: 0x000BF47E
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> EntityTypes
		{
			get
			{
				return this._entityTypes;
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06003ACB RID: 15051 RVA: 0x000C1286 File Offset: 0x000BF486
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EnumType> EnumTypes
		{
			get
			{
				return this._enumTypes;
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06003ACC RID: 15052 RVA: 0x000C128E File Offset: 0x000BF48E
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> Functions
		{
			get
			{
				return this._functions;
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06003ACD RID: 15053 RVA: 0x000C1296 File Offset: 0x000BF496
		public global::System.Data.Entity.Core.Metadata.Edm.EntityContainer Container
		{
			get
			{
				return this._container;
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06003ACE RID: 15054 RVA: 0x000C129E File Offset: 0x000BF49E
		// (set) Token: 0x06003ACF RID: 15055 RVA: 0x000C12A6 File Offset: 0x000BF4A6
		internal double SchemaVersion
		{
			get
			{
				return this._schemaVersion;
			}
			set
			{
				this._schemaVersion = value;
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06003AD0 RID: 15056 RVA: 0x000C12AF File Offset: 0x000BF4AF
		// (set) Token: 0x06003AD1 RID: 15057 RVA: 0x000C12B7 File Offset: 0x000BF4B7
		internal global::System.Data.Entity.Infrastructure.DbProviderInfo ProviderInfo
		{
			get
			{
				return this._providerInfo;
			}
			private set
			{
				this._providerInfo = value;
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06003AD2 RID: 15058 RVA: 0x000C12C0 File Offset: 0x000BF4C0
		// (set) Token: 0x06003AD3 RID: 15059 RVA: 0x000C12C8 File Offset: 0x000BF4C8
		internal global::System.Data.Entity.Core.Common.DbProviderManifest ProviderManifest
		{
			get
			{
				return this._providerManifest;
			}
			private set
			{
				this._providerManifest = value;
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06003AD4 RID: 15060 RVA: 0x000C12D1 File Offset: 0x000BF4D1
		internal virtual global::System.Collections.Generic.IEnumerable<string> NamespaceNames
		{
			get
			{
				return (from t in this.NamespaceItems
				select t.NamespaceName).Distinct<string>();
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06003AD5 RID: 15061 RVA: 0x000C1302 File Offset: 0x000BF502
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmType> NamespaceItems
		{
			get
			{
				return this._associationTypes.Concat(this._complexTypes).Concat(this._entityTypes).Concat(this._enumTypes).Concat(this._functions);
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06003AD6 RID: 15062 RVA: 0x000C1336 File Offset: 0x000BF536
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> GlobalItems
		{
			get
			{
				return this.NamespaceItems.Concat(this.Containers);
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06003AD7 RID: 15063 RVA: 0x000C1349 File Offset: 0x000BF549
		internal virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer> Containers
		{
			get
			{
				yield return this.Container;
				yield break;
			}
		}

		// Token: 0x06003AD8 RID: 15064 RVA: 0x000C1359 File Offset: 0x000BF559
		public void AddItem(global::System.Data.Entity.Core.Metadata.Edm.AssociationType item)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(item, "item");
			this.ValidateSpace(item);
			this._associationTypes.Add(item);
		}

		// Token: 0x06003AD9 RID: 15065 RVA: 0x000C137A File Offset: 0x000BF57A
		public void AddItem(global::System.Data.Entity.Core.Metadata.Edm.ComplexType item)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(item, "item");
			this.ValidateSpace(item);
			this._complexTypes.Add(item);
		}

		// Token: 0x06003ADA RID: 15066 RVA: 0x000C139B File Offset: 0x000BF59B
		public void AddItem(global::System.Data.Entity.Core.Metadata.Edm.EntityType item)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(item, "item");
			this.ValidateSpace(item);
			this._entityTypes.Add(item);
		}

		// Token: 0x06003ADB RID: 15067 RVA: 0x000C13BC File Offset: 0x000BF5BC
		public void AddItem(global::System.Data.Entity.Core.Metadata.Edm.EnumType item)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EnumType>(item, "item");
			this.ValidateSpace(item);
			this._enumTypes.Add(item);
		}

		// Token: 0x06003ADC RID: 15068 RVA: 0x000C13DD File Offset: 0x000BF5DD
		public void AddItem(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction item)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(item, "item");
			this.ValidateSpace(item);
			this._functions.Add(item);
		}

		// Token: 0x06003ADD RID: 15069 RVA: 0x000C13FE File Offset: 0x000BF5FE
		public void RemoveItem(global::System.Data.Entity.Core.Metadata.Edm.AssociationType item)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(item, "item");
			this._associationTypes.Remove(item);
		}

		// Token: 0x06003ADE RID: 15070 RVA: 0x000C1419 File Offset: 0x000BF619
		public void RemoveItem(global::System.Data.Entity.Core.Metadata.Edm.ComplexType item)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(item, "item");
			this._complexTypes.Remove(item);
		}

		// Token: 0x06003ADF RID: 15071 RVA: 0x000C1434 File Offset: 0x000BF634
		public void RemoveItem(global::System.Data.Entity.Core.Metadata.Edm.EntityType item)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(item, "item");
			this._entityTypes.Remove(item);
		}

		// Token: 0x06003AE0 RID: 15072 RVA: 0x000C144F File Offset: 0x000BF64F
		public void RemoveItem(global::System.Data.Entity.Core.Metadata.Edm.EnumType item)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EnumType>(item, "item");
			this._enumTypes.Remove(item);
		}

		// Token: 0x06003AE1 RID: 15073 RVA: 0x000C146A File Offset: 0x000BF66A
		public void RemoveItem(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction item)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(item, "item");
			this._functions.Remove(item);
		}

		// Token: 0x06003AE2 RID: 15074 RVA: 0x000C1488 File Offset: 0x000BF688
		internal virtual void Validate()
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs> validationErrors = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs>();
			global::System.Data.Entity.Core.Metadata.Edm.DataModelValidator dataModelValidator = new global::System.Data.Entity.Core.Metadata.Edm.DataModelValidator();
			dataModelValidator.OnError += delegate(object _, global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs e)
			{
				validationErrors.Add(e);
			};
			dataModelValidator.Validate(this, true);
			if (validationErrors.Count > 0)
			{
				throw new global::System.Data.Entity.ModelConfiguration.ModelValidationException(validationErrors);
			}
		}

		// Token: 0x06003AE3 RID: 15075 RVA: 0x000C14DE File Offset: 0x000BF6DE
		private void ValidateSpace(global::System.Data.Entity.Core.Metadata.Edm.EdmType item)
		{
			if (item.DataSpace != this.DataSpace)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EdmModel_AddItem_NonMatchingNamespace, "item");
			}
		}

		// Token: 0x06003AE4 RID: 15076 RVA: 0x000C14FE File Offset: 0x000BF6FE
		internal static global::System.Data.Entity.Core.Metadata.Edm.EdmModel CreateStoreModel(global::System.Data.Entity.Infrastructure.DbProviderInfo providerInfo, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, double schemaVersion = 3.0)
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.EdmModel(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace, schemaVersion)
			{
				ProviderInfo = providerInfo,
				ProviderManifest = providerManifest
			};
		}

		// Token: 0x06003AE5 RID: 15077 RVA: 0x000C1518 File Offset: 0x000BF718
		internal static global::System.Data.Entity.Core.Metadata.Edm.EdmModel CreateStoreModel(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer, global::System.Data.Entity.Infrastructure.DbProviderInfo providerInfo, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, double schemaVersion = 3.0)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmModel edmModel = new global::System.Data.Entity.Core.Metadata.Edm.EdmModel(entityContainer, schemaVersion);
			if (providerInfo != null)
			{
				edmModel.ProviderInfo = providerInfo;
			}
			if (providerManifest != null)
			{
				edmModel.ProviderManifest = providerManifest;
			}
			return edmModel;
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x000C1542 File Offset: 0x000BF742
		internal static global::System.Data.Entity.Core.Metadata.Edm.EdmModel CreateConceptualModel(double schemaVersion = 3.0)
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.EdmModel(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, schemaVersion);
		}

		// Token: 0x06003AE7 RID: 15079 RVA: 0x000C154B File Offset: 0x000BF74B
		internal static global::System.Data.Entity.Core.Metadata.Edm.EdmModel CreateConceptualModel(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer, double schemaVersion = 3.0)
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.EdmModel(entityContainer, schemaVersion);
		}

		// Token: 0x04001431 RID: 5169
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> _associationTypes = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>();

		// Token: 0x04001432 RID: 5170
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.ComplexType> _complexTypes = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>();

		// Token: 0x04001433 RID: 5171
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType> _entityTypes = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();

		// Token: 0x04001434 RID: 5172
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EnumType> _enumTypes = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EnumType>();

		// Token: 0x04001435 RID: 5173
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> _functions = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>();

		// Token: 0x04001436 RID: 5174
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntityContainer _container;

		// Token: 0x04001437 RID: 5175
		private double _schemaVersion;

		// Token: 0x04001438 RID: 5176
		private global::System.Data.Entity.Infrastructure.DbProviderInfo _providerInfo;

		// Token: 0x04001439 RID: 5177
		private global::System.Data.Entity.Core.Common.DbProviderManifest _providerManifest;
	}
}
