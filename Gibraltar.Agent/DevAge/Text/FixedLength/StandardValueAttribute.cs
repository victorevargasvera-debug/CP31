using System;

namespace DevAge.Text.FixedLength
{
	// Token: 0x02000278 RID: 632
	[global::System.AttributeUsage(global::System.AttributeTargets.Property, AllowMultiple = true)]
	internal class StandardValueAttribute : global::System.Attribute
	{
		// Token: 0x06002076 RID: 8310 RVA: 0x000740C4 File Offset: 0x000722C4
		public StandardValueAttribute(object standardValue)
		{
			this.mStandardValue = standardValue;
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x000740D4 File Offset: 0x000722D4
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x000740DC File Offset: 0x000722DC
		public object StandardValue
		{
			get
			{
				return this.mStandardValue;
			}
			set
			{
				this.mStandardValue = value;
			}
		}

		// Token: 0x04000C05 RID: 3077
		private object mStandardValue;
	}
}
