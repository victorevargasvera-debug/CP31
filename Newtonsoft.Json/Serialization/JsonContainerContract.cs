using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000084 RID: 132
	[global::System.Runtime.CompilerServices.NullableContext(2)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class JsonContainerContract : global::Newtonsoft.Json.Serialization.JsonContract
	{
		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x0001C36A File Offset: 0x0001A56A
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x0001C372 File Offset: 0x0001A572
		internal global::Newtonsoft.Json.Serialization.JsonContract ItemContract
		{
			get
			{
				return this._itemContract;
			}
			set
			{
				this._itemContract = value;
				if (this._itemContract != null)
				{
					this._finalItemContract = (this._itemContract.UnderlyingType.IsSealed() ? this._itemContract : null);
					return;
				}
				this._finalItemContract = null;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x0001C3AC File Offset: 0x0001A5AC
		internal global::Newtonsoft.Json.Serialization.JsonContract FinalItemContract
		{
			get
			{
				return this._finalItemContract;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x0001C3B4 File Offset: 0x0001A5B4
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x0001C3BC File Offset: 0x0001A5BC
		public global::Newtonsoft.Json.JsonConverter ItemConverter { get; set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x0001C3C5 File Offset: 0x0001A5C5
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x0001C3CD File Offset: 0x0001A5CD
		public bool? ItemIsReference { get; set; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x0001C3D6 File Offset: 0x0001A5D6
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x0001C3DE File Offset: 0x0001A5DE
		public global::Newtonsoft.Json.ReferenceLoopHandling? ItemReferenceLoopHandling { get; set; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x0001C3E7 File Offset: 0x0001A5E7
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x0001C3EF File Offset: 0x0001A5EF
		public global::Newtonsoft.Json.TypeNameHandling? ItemTypeNameHandling { get; set; }

		// Token: 0x060006A0 RID: 1696 RVA: 0x0001C3F8 File Offset: 0x0001A5F8
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		internal JsonContainerContract(global::System.Type underlyingType) : base(underlyingType)
		{
			global::Newtonsoft.Json.JsonContainerAttribute cachedAttribute = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetCachedAttribute<global::Newtonsoft.Json.JsonContainerAttribute>(underlyingType);
			if (cachedAttribute != null)
			{
				if (cachedAttribute.ItemConverterType != null)
				{
					this.ItemConverter = global::Newtonsoft.Json.Serialization.JsonTypeReflector.CreateJsonConverterInstance(cachedAttribute.ItemConverterType, cachedAttribute.ItemConverterParameters);
				}
				this.ItemIsReference = cachedAttribute._itemIsReference;
				this.ItemReferenceLoopHandling = cachedAttribute._itemReferenceLoopHandling;
				this.ItemTypeNameHandling = cachedAttribute._itemTypeNameHandling;
			}
		}

		// Token: 0x0400023E RID: 574
		private global::Newtonsoft.Json.Serialization.JsonContract _itemContract;

		// Token: 0x0400023F RID: 575
		private global::Newtonsoft.Json.Serialization.JsonContract _finalItemContract;
	}
}
