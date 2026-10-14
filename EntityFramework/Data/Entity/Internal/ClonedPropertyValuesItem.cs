using System;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000100 RID: 256
	internal class ClonedPropertyValuesItem : global::System.Data.Entity.Internal.IPropertyValuesItem
	{
		// Token: 0x06001281 RID: 4737 RVA: 0x0002F916 File Offset: 0x0002DB16
		public ClonedPropertyValuesItem(string name, object value, global::System.Type type, bool isComplex)
		{
			this._name = name;
			this._type = type;
			this._isComplex = isComplex;
			this.Value = value;
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001282 RID: 4738 RVA: 0x0002F93B File Offset: 0x0002DB3B
		// (set) Token: 0x06001283 RID: 4739 RVA: 0x0002F943 File Offset: 0x0002DB43
		public object Value { get; set; }

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x0002F94C File Offset: 0x0002DB4C
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x0002F954 File Offset: 0x0002DB54
		public bool IsComplex
		{
			get
			{
				return this._isComplex;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001286 RID: 4742 RVA: 0x0002F95C File Offset: 0x0002DB5C
		public global::System.Type Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x04000922 RID: 2338
		private readonly string _name;

		// Token: 0x04000923 RID: 2339
		private readonly bool _isComplex;

		// Token: 0x04000924 RID: 2340
		private readonly global::System.Type _type;
	}
}
