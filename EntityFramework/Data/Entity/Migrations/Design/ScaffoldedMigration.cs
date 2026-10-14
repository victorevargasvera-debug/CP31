using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Migrations.Design
{
	// Token: 0x020000E5 RID: 229
	[global::System.Serializable]
	public class ScaffoldedMigration
	{
		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x00029B2C File Offset: 0x00027D2C
		// (set) Token: 0x0600114F RID: 4431 RVA: 0x00029B34 File Offset: 0x00027D34
		public string MigrationId
		{
			get
			{
				return this._migrationId;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotEmpty(value, "value");
				this._migrationId = value;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x00029B49 File Offset: 0x00027D49
		// (set) Token: 0x06001151 RID: 4433 RVA: 0x00029B51 File Offset: 0x00027D51
		public string UserCode
		{
			get
			{
				return this._userCode;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotEmpty(value, "value");
				this._userCode = value;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x00029B66 File Offset: 0x00027D66
		// (set) Token: 0x06001153 RID: 4435 RVA: 0x00029B6E File Offset: 0x00027D6E
		public string DesignerCode
		{
			get
			{
				return this._designerCode;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotEmpty(value, "value");
				this._designerCode = value;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x00029B83 File Offset: 0x00027D83
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x00029B8B File Offset: 0x00027D8B
		public string Language
		{
			get
			{
				return this._language;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotEmpty(value, "value");
				this._language = value;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x00029BA0 File Offset: 0x00027DA0
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x00029BA8 File Offset: 0x00027DA8
		public string Directory
		{
			get
			{
				return this._directory;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotEmpty(value, "value");
				this._directory = value;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x00029BBD File Offset: 0x00027DBD
		public global::System.Collections.Generic.IDictionary<string, object> Resources
		{
			get
			{
				return this._resources;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x00029BC5 File Offset: 0x00027DC5
		// (set) Token: 0x0600115A RID: 4442 RVA: 0x00029BCD File Offset: 0x00027DCD
		public bool IsRescaffold { get; set; }

		// Token: 0x040008D9 RID: 2265
		private string _migrationId;

		// Token: 0x040008DA RID: 2266
		private string _userCode;

		// Token: 0x040008DB RID: 2267
		private string _designerCode;

		// Token: 0x040008DC RID: 2268
		private string _language;

		// Token: 0x040008DD RID: 2269
		private string _directory;

		// Token: 0x040008DE RID: 2270
		private readonly global::System.Collections.Generic.Dictionary<string, object> _resources = new global::System.Collections.Generic.Dictionary<string, object>();
	}
}
