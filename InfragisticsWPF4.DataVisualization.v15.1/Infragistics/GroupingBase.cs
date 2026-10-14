using System;

namespace Infragistics
{
	// Token: 0x0200004A RID: 74
	public class GroupingBase
	{
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00010735 File Offset: 0x0000E935
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x0001073D File Offset: 0x0000E93D
		public object Key { get; set; }

		// Token: 0x06000416 RID: 1046 RVA: 0x00010746 File Offset: 0x0000E946
		public void SetObjectForKey(string key, object obj)
		{
			this.SetObjectForKeyOverride(key, obj);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00010750 File Offset: 0x0000E950
		protected virtual void SetObjectForKeyOverride(string key, object obj)
		{
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00010754 File Offset: 0x0000E954
		public T GetDefaultValue<T>()
		{
			return default(T);
		}
	}
}
