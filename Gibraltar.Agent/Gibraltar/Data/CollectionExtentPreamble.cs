using System;
using System.IO;

namespace Gibraltar.Data
{
	// Token: 0x020000D6 RID: 214
	[global::System.Obsolete]
	internal sealed class CollectionExtentPreamble : global::Gibraltar.Data.ExtentPreamble
	{
		// Token: 0x060008E0 RID: 2272 RVA: 0x00013798 File Offset: 0x00011998
		internal CollectionExtentPreamble(global::Gibraltar.Data.ExtentTypeCode typeCode, short majorVersion) : base(typeCode, majorVersion)
		{
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x000137A4 File Offset: 0x000119A4
		public CollectionExtentPreamble(byte[] sourceArray) : base(sourceArray)
		{
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(this.m_MemoryBuffer, out this.m_ChildOffset);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x000137C0 File Offset: 0x000119C0
		public CollectionExtentPreamble(global::System.IO.Stream sourceStream) : base(sourceStream)
		{
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(this.m_MemoryBuffer, out this.m_ChildOffset);
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x000137DC File Offset: 0x000119DC
		protected override int GetMemoryBufferLength()
		{
			return 24;
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x000137E0 File Offset: 0x000119E0
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x000137E8 File Offset: 0x000119E8
		public int ChildOffset
		{
			get
			{
				return this.m_ChildOffset;
			}
			internal set
			{
				if (this.m_ChildOffset == value)
				{
					return;
				}
				this.m_ChildOffset = value;
				base.UpdateBuffer(20, global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_ChildOffset));
				base.SetDirty();
			}
		}

		// Token: 0x040001EC RID: 492
		private const int PositionOfChildOffset = 20;

		// Token: 0x040001ED RID: 493
		private int m_ChildOffset;

		// Token: 0x040001EE RID: 494
		public const int CollectionExtentPreambleLength = 24;

		// Token: 0x040001EF RID: 495
		private const int CollectionExtentExtraLength = 4;
	}
}
