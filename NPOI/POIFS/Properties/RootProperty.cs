using System;
using NPOI.POIFS.Storage;

namespace NPOI.POIFS.Properties
{
	// Token: 0x020002C1 RID: 705
	public class RootProperty : global::NPOI.POIFS.Properties.DirectoryProperty
	{
		// Token: 0x0600137B RID: 4987 RVA: 0x0003A886 File Offset: 0x00038A86
		public RootProperty() : base("Root Entry")
		{
			base.NodeColor = 1;
			base.PropertyType = 5;
			base.StartBlock = -2;
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x0003A8A9 File Offset: 0x00038AA9
		public RootProperty(int index, byte[] array, int offset) : base(index, array, offset)
		{
		}

		// Token: 0x170003B2 RID: 946
		// (set) Token: 0x0600137D RID: 4989 RVA: 0x0003A8B4 File Offset: 0x00038AB4
		public override int Size
		{
			set
			{
				base.Size = global::NPOI.POIFS.Storage.SmallDocumentBlock.CalcSize(value);
			}
		}

		// Token: 0x04000824 RID: 2084
		private const string NAME = "Root Entry";
	}
}
