using System;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.Data.Entity.Core
{
	// Token: 0x020002D1 RID: 721
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class EntityKeyMember
	{
		// Token: 0x060022ED RID: 8941 RVA: 0x000621AC File Offset: 0x000603AC
		public EntityKeyMember()
		{
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x000621B4 File Offset: 0x000603B4
		public EntityKeyMember(string keyName, object keyValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(keyName, "keyName");
			global::System.Data.Entity.Utilities.Check.NotNull<object>(keyValue, "keyValue");
			this._keyName = keyName;
			this._keyValue = keyValue;
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x000621E2 File Offset: 0x000603E2
		// (set) Token: 0x060022F0 RID: 8944 RVA: 0x000621EA File Offset: 0x000603EA
		[global::System.Runtime.Serialization.DataMember]
		public string Key
		{
			get
			{
				return this._keyName;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<string>(value, "value");
				global::System.Data.Entity.Core.EntityKeyMember.ValidateWritable(this._keyName);
				this._keyName = value;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060022F1 RID: 8945 RVA: 0x0006220A File Offset: 0x0006040A
		// (set) Token: 0x060022F2 RID: 8946 RVA: 0x00062212 File Offset: 0x00060412
		[global::System.Runtime.Serialization.DataMember]
		public object Value
		{
			get
			{
				return this._keyValue;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<object>(value, "value");
				global::System.Data.Entity.Core.EntityKeyMember.ValidateWritable(this._keyValue);
				this._keyValue = value;
			}
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x00062232 File Offset: 0x00060432
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "[{0}, {1}]", new object[]
			{
				this._keyName,
				this._keyValue
			});
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x0006225B File Offset: 0x0006045B
		private static void ValidateWritable(object instance)
		{
			if (instance != null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityKey_CannotChangeKey);
			}
		}

		// Token: 0x04000C03 RID: 3075
		private string _keyName;

		// Token: 0x04000C04 RID: 3076
		private object _keyValue;
	}
}
