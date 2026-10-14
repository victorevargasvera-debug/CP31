using System;

namespace DevAge.Text.FixedLength
{
	// Token: 0x02000275 RID: 629
	[global::System.AttributeUsage(global::System.AttributeTargets.Property)]
	internal class FieldAttribute : global::System.Attribute
	{
		// Token: 0x06002065 RID: 8293 RVA: 0x00073FC4 File Offset: 0x000721C4
		public FieldAttribute(int fieldIndex, int length)
		{
			this.mFieldIndex = fieldIndex;
			this.mLength = length;
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06002066 RID: 8294 RVA: 0x00073FDC File Offset: 0x000721DC
		public int FieldIndex
		{
			get
			{
				return this.mFieldIndex;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06002067 RID: 8295 RVA: 0x00073FE4 File Offset: 0x000721E4
		public int Length
		{
			get
			{
				return this.mLength;
			}
		}

		// Token: 0x04000BFD RID: 3069
		private int mFieldIndex;

		// Token: 0x04000BFE RID: 3070
		private int mLength;
	}
}
