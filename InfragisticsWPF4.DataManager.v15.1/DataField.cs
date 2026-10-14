using System;

namespace Infragistics
{
	// Token: 0x02000019 RID: 25
	public class DataField
	{
		// Token: 0x06000132 RID: 306 RVA: 0x00008764 File Offset: 0x00006964
		public DataField(string name, global::System.Type type)
		{
			this.Name = name;
			this.FieldType = type;
			this.AutoGenerate = true;
			this.Order = int.MaxValue;
			this.DisplayName = null;
			this.GroupName = null;
			this.FormatString = null;
			this.ApplyFormatStringInEditMode = false;
			this.NullDisplayText = null;
			this.ConvertEmptyStringToNull = false;
			this.AllowEdit = true;
			this.AllowEditingForAddNew = true;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000133 RID: 307 RVA: 0x000087CF File Offset: 0x000069CF
		// (set) Token: 0x06000134 RID: 308 RVA: 0x000087D7 File Offset: 0x000069D7
		public string Name { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000135 RID: 309 RVA: 0x000087E0 File Offset: 0x000069E0
		// (set) Token: 0x06000136 RID: 310 RVA: 0x000087E8 File Offset: 0x000069E8
		public global::System.Type FieldType { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000137 RID: 311 RVA: 0x000087F1 File Offset: 0x000069F1
		// (set) Token: 0x06000138 RID: 312 RVA: 0x000087F9 File Offset: 0x000069F9
		public bool AutoGenerate { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00008802 File Offset: 0x00006A02
		// (set) Token: 0x0600013A RID: 314 RVA: 0x0000880A File Offset: 0x00006A0A
		public string DisplayName { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00008813 File Offset: 0x00006A13
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0000881B File Offset: 0x00006A1B
		public string GroupName { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00008824 File Offset: 0x00006A24
		// (set) Token: 0x0600013E RID: 318 RVA: 0x0000882C File Offset: 0x00006A2C
		public int Order { get; set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00008835 File Offset: 0x00006A35
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0000883D File Offset: 0x00006A3D
		public string FormatString { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00008846 File Offset: 0x00006A46
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0000884E File Offset: 0x00006A4E
		public bool ApplyFormatStringInEditMode { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00008857 File Offset: 0x00006A57
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0000885F File Offset: 0x00006A5F
		public string NullDisplayText { get; set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00008868 File Offset: 0x00006A68
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00008870 File Offset: 0x00006A70
		public bool ConvertEmptyStringToNull { get; set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00008879 File Offset: 0x00006A79
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00008881 File Offset: 0x00006A81
		public bool AllowEdit { get; set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0000888A File Offset: 0x00006A8A
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00008892 File Offset: 0x00006A92
		public bool AllowEditingForAddNew { get; set; }
	}
}
