using System;
using System.Data.Entity.Core;
using System.Data.Entity.Spatial;
using System.Data.Entity.SqlServer.Resources;
using System.Data.Entity.SqlServer.Utilities;

namespace System.Data.Entity.SqlServer
{
	// Token: 0x02000003 RID: 3
	internal class DbGeographyAdapter : global::System.Data.Entity.SqlServer.IDbSpatialValue
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002158 File Offset: 0x00000358
		internal DbGeographyAdapter(global::System.Data.Entity.Spatial.DbGeography value)
		{
			this._value = value;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002167 File Offset: 0x00000367
		public bool IsGeography
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000216A File Offset: 0x0000036A
		public object ProviderValue
		{
			get
			{
				return (() => this._value.ProviderValue).NullIfNotImplemented<object>();
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000217D File Offset: 0x0000037D
		public int? CoordinateSystemId
		{
			get
			{
				return (() => new int?(this._value.CoordinateSystemId)).NullIfNotImplemented<int?>();
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002190 File Offset: 0x00000390
		public string WellKnownText
		{
			get
			{
				return (() => this._value.Provider.AsTextIncludingElevationAndMeasure(this._value)).NullIfNotImplemented<string>() ?? (() => this._value.AsText()).NullIfNotImplemented<string>();
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000021B8 File Offset: 0x000003B8
		public byte[] WellKnownBinary
		{
			get
			{
				return (() => this._value.AsBinary()).NullIfNotImplemented<byte[]>();
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000021CB File Offset: 0x000003CB
		public string GmlString
		{
			get
			{
				return (() => this._value.AsGml()).NullIfNotImplemented<string>();
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000021DE File Offset: 0x000003DE
		public global::System.Exception NotSqlCompatible()
		{
			return new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlProvider_GeographyValueNotSqlCompatible);
		}

		// Token: 0x04000003 RID: 3
		private readonly global::System.Data.Entity.Spatial.DbGeography _value;
	}
}
