using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Text;
using System.Threading;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004B5 RID: 1205
	public abstract class EdmType : global::System.Data.Entity.Core.Metadata.Edm.GlobalItem, global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem
	{
		// Token: 0x06003B6C RID: 15212 RVA: 0x000C36BD File Offset: 0x000C18BD
		internal static global::System.Collections.Generic.IEnumerable<T> SafeTraverseHierarchy<T>(T startFrom) where T : global::System.Data.Entity.Core.Metadata.Edm.EdmType
		{
			global::System.Collections.Generic.HashSet<T> visitedTypes = new global::System.Collections.Generic.HashSet<T>();
			T thisType = startFrom;
			while (thisType != null && !visitedTypes.Contains(thisType))
			{
				visitedTypes.Add(thisType);
				yield return thisType;
				thisType = (thisType.BaseType as T);
			}
			yield break;
		}

		// Token: 0x06003B6D RID: 15213 RVA: 0x000C36CD File Offset: 0x000C18CD
		internal EdmType()
		{
		}

		// Token: 0x06003B6E RID: 15214 RVA: 0x000C36D5 File Offset: 0x000C18D5
		internal EdmType(string name, string namespaceName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<string>(namespaceName, "namespaceName");
			global::System.Data.Entity.Core.Metadata.Edm.EdmType.Initialize(this, name, namespaceName, dataSpace, false, null);
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06003B6F RID: 15215 RVA: 0x000C3700 File Offset: 0x000C1900
		// (set) Token: 0x06003B70 RID: 15216 RVA: 0x000C3708 File Offset: 0x000C1908
		internal string CacheIdentity { get; private set; }

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06003B71 RID: 15217 RVA: 0x000C3711 File Offset: 0x000C1911
		string global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem.Identity
		{
			get
			{
				return this.Identity;
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06003B72 RID: 15218 RVA: 0x000C371C File Offset: 0x000C191C
		internal override string Identity
		{
			get
			{
				if (this.CacheIdentity == null)
				{
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(50);
					this.BuildIdentity(stringBuilder);
					this.CacheIdentity = stringBuilder.ToString();
				}
				return this.CacheIdentity;
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06003B73 RID: 15219 RVA: 0x000C3752 File Offset: 0x000C1952
		// (set) Token: 0x06003B74 RID: 15220 RVA: 0x000C375A File Offset: 0x000C195A
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, false)]
		public virtual string Name
		{
			get
			{
				return this._name;
			}
			internal set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this._name = value;
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06003B75 RID: 15221 RVA: 0x000C3769 File Offset: 0x000C1969
		// (set) Token: 0x06003B76 RID: 15222 RVA: 0x000C3771 File Offset: 0x000C1971
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, false)]
		public virtual string NamespaceName
		{
			get
			{
				return this._namespace;
			}
			internal set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this._namespace = value;
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06003B77 RID: 15223 RVA: 0x000C3780 File Offset: 0x000C1980
		// (set) Token: 0x06003B78 RID: 15224 RVA: 0x000C378A File Offset: 0x000C198A
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean, false)]
		public bool Abstract
		{
			get
			{
				return base.GetFlag(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.IsAbstract);
			}
			internal set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				base.SetFlag(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.IsAbstract, value);
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06003B79 RID: 15225 RVA: 0x000C379B File Offset: 0x000C199B
		// (set) Token: 0x06003B7A RID: 15226 RVA: 0x000C37A3 File Offset: 0x000C19A3
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmType, false)]
		public virtual global::System.Data.Entity.Core.Metadata.Edm.EdmType BaseType
		{
			get
			{
				return this._baseType;
			}
			internal set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this.CheckBaseType(value);
				this._baseType = value;
			}
		}

		// Token: 0x06003B7B RID: 15227 RVA: 0x000C37BC File Offset: 0x000C19BC
		private void CheckBaseType(global::System.Data.Entity.Core.Metadata.Edm.EdmType baseType)
		{
			for (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = baseType; edmType != null; edmType = edmType.BaseType)
			{
				if (edmType == this)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.CannotSetBaseTypeCyclicInheritance(baseType.Name, this.Name));
				}
			}
			if (baseType != null && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityTypeBase(this) && ((global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase)baseType).KeyMembers.Count != 0 && ((global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase)this).KeyMembers.Count != 0)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.CannotDefineKeysOnBothBaseAndDerivedTypes);
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06003B7C RID: 15228 RVA: 0x000C382C File Offset: 0x000C1A2C
		public virtual string FullName
		{
			get
			{
				return this.Identity;
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06003B7D RID: 15229 RVA: 0x000C3834 File Offset: 0x000C1A34
		internal virtual global::System.Type ClrType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06003B7E RID: 15230 RVA: 0x000C3837 File Offset: 0x000C1A37
		internal override void BuildIdentity(global::System.Text.StringBuilder builder)
		{
			if (this.CacheIdentity != null)
			{
				builder.Append(this.CacheIdentity);
				return;
			}
			builder.Append(global::System.Data.Entity.Core.Metadata.Edm.EdmType.CreateEdmTypeIdentity(this.NamespaceName, this.Name));
		}

		// Token: 0x06003B7F RID: 15231 RVA: 0x000C3868 File Offset: 0x000C1A68
		internal static string CreateEdmTypeIdentity(string namespaceName, string name)
		{
			string str = string.Empty;
			if (!string.IsNullOrEmpty(namespaceName))
			{
				str = namespaceName + ".";
			}
			return str + name;
		}

		// Token: 0x06003B80 RID: 15232 RVA: 0x000C3898 File Offset: 0x000C1A98
		internal static void Initialize(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, string name, string namespaceName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, bool isAbstract, global::System.Data.Entity.Core.Metadata.Edm.EdmType baseType)
		{
			type._baseType = baseType;
			type._name = name;
			type._namespace = namespaceName;
			type.DataSpace = dataSpace;
			type.Abstract = isAbstract;
		}

		// Token: 0x06003B81 RID: 15233 RVA: 0x000C38BF File Offset: 0x000C1ABF
		public override string ToString()
		{
			return this.FullName;
		}

		// Token: 0x06003B82 RID: 15234 RVA: 0x000C38C7 File Offset: 0x000C1AC7
		public global::System.Data.Entity.Core.Metadata.Edm.CollectionType GetCollectionType()
		{
			if (this._collectionType == null)
			{
				global::System.Threading.Interlocked.CompareExchange<global::System.Data.Entity.Core.Metadata.Edm.CollectionType>(ref this._collectionType, new global::System.Data.Entity.Core.Metadata.Edm.CollectionType(this), null);
			}
			return this._collectionType;
		}

		// Token: 0x06003B83 RID: 15235 RVA: 0x000C38EA File Offset: 0x000C1AEA
		internal virtual bool IsSubtypeOf(global::System.Data.Entity.Core.Metadata.Edm.EdmType otherType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSubtypeOf(this, otherType);
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x000C38F3 File Offset: 0x000C1AF3
		internal virtual bool IsBaseTypeOf(global::System.Data.Entity.Core.Metadata.Edm.EdmType otherType)
		{
			return otherType != null && otherType.IsSubtypeOf(this);
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x000C3901 File Offset: 0x000C1B01
		internal virtual bool IsAssignableFrom(global::System.Data.Entity.Core.Metadata.Edm.EdmType otherType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsAssignableFrom(this, otherType);
		}

		// Token: 0x06003B86 RID: 15238 RVA: 0x000C390C File Offset: 0x000C1B0C
		internal override void SetReadOnly()
		{
			if (!base.IsReadOnly)
			{
				base.SetReadOnly();
				global::System.Data.Entity.Core.Metadata.Edm.EdmType baseType = this.BaseType;
				if (baseType != null)
				{
					baseType.SetReadOnly();
				}
			}
		}

		// Token: 0x06003B87 RID: 15239 RVA: 0x000C3937 File Offset: 0x000C1B37
		internal virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription> GetAssociatedFacetDescriptions()
		{
			return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetGeneralFacetDescriptions();
		}

		// Token: 0x04001484 RID: 5252
		private global::System.Data.Entity.Core.Metadata.Edm.CollectionType _collectionType;

		// Token: 0x04001485 RID: 5253
		private string _name;

		// Token: 0x04001486 RID: 5254
		private string _namespace;

		// Token: 0x04001487 RID: 5255
		private global::System.Data.Entity.Core.Metadata.Edm.EdmType _baseType;
	}
}
