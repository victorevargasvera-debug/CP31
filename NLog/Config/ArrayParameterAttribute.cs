using System;

namespace NLog.Config
{
	// Token: 0x02000158 RID: 344
	[global::System.AttributeUsage(global::System.AttributeTargets.Property)]
	public sealed class ArrayParameterAttribute : global::System.Attribute
	{
		// Token: 0x06000F2B RID: 3883 RVA: 0x00026A19 File Offset: 0x00024C19
		public ArrayParameterAttribute(global::System.Type itemType, string elementName)
		{
			this.ItemType = itemType;
			this.ElementName = elementName;
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x00026A2F File Offset: 0x00024C2F
		// (set) Token: 0x06000F2D RID: 3885 RVA: 0x00026A37 File Offset: 0x00024C37
		public global::System.Type ItemType { get; private set; }

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x00026A40 File Offset: 0x00024C40
		// (set) Token: 0x06000F2F RID: 3887 RVA: 0x00026A48 File Offset: 0x00024C48
		public string ElementName { get; private set; }
	}
}
