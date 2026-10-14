using System;

namespace NLog.Config
{
	// Token: 0x0200016B RID: 363
	public abstract class NameBaseAttribute : global::System.Attribute
	{
		// Token: 0x06000FE7 RID: 4071 RVA: 0x00029334 File Offset: 0x00027534
		protected NameBaseAttribute(string name)
		{
			this.Name = name;
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x00029343 File Offset: 0x00027543
		// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x0002934B File Offset: 0x0002754B
		public string Name { get; private set; }
	}
}
