using System;
using System.IO;

namespace Gibraltar.Data
{
	// Token: 0x020000D9 RID: 217
	internal class ExtentFactoryBase
	{
		// Token: 0x060008FD RID: 2301 RVA: 0x00014134 File Offset: 0x00012334
		public global::Gibraltar.Data.ExtentBase GetExtent(global::System.IO.Stream sourceStream)
		{
			if (sourceStream == null || !sourceStream.CanRead)
			{
				return null;
			}
			long position = sourceStream.Position;
			if (sourceStream.Length - position < 20L)
			{
				return null;
			}
			global::Gibraltar.Data.ExtentPreamble extentPreamble = new global::Gibraltar.Data.ExtentPreamble(sourceStream);
			if ((extentPreamble.TypeCode >> 40 | (global::Gibraltar.Data.ExtentTypeCode)8224L) != (global::Gibraltar.Data.ExtentTypeCode)7956348L)
			{
				if (sourceStream.CanSeek)
				{
					sourceStream.Position = position;
				}
				throw new global::System.InvalidOperationException("Source stream is not positioned at a valid extent preamble.");
			}
			return this.OnGetExtent(extentPreamble, sourceStream);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x000141B8 File Offset: 0x000123B8
		protected virtual global::Gibraltar.Data.ExtentBase OnGetExtent(global::Gibraltar.Data.ExtentPreamble preamble, global::System.IO.Stream sourceStream)
		{
			long position = sourceStream.Position;
			long length = sourceStream.Length;
			return null;
		}
	}
}
