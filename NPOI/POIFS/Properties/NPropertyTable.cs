using System;
using System.Collections.Generic;
using System.IO;
using NPOI.POIFS.Common;
using NPOI.POIFS.FileSystem;
using NPOI.POIFS.Storage;
using NPOI.Util;

namespace NPOI.POIFS.Properties
{
	// Token: 0x020002B7 RID: 695
	public class NPropertyTable : global::NPOI.POIFS.Properties.PropertyTableBase
	{
		// Token: 0x06001328 RID: 4904 RVA: 0x000399D9 File Offset: 0x00037BD9
		public NPropertyTable(global::NPOI.POIFS.Storage.HeaderBlock headerBlock) : base(headerBlock)
		{
			this._bigBigBlockSize = headerBlock.BigBlockSize;
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x000399EE File Offset: 0x00037BEE
		public NPropertyTable(global::NPOI.POIFS.Storage.HeaderBlock headerBlock, global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fileSystem) : base(headerBlock, global::NPOI.POIFS.Properties.NPropertyTable.BuildProperties(new global::NPOI.POIFS.FileSystem.NPOIFSStream(fileSystem, headerBlock.PropertyStart).GetEnumerator(), headerBlock.BigBlockSize))
		{
			this._bigBigBlockSize = headerBlock.BigBlockSize;
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x00039A20 File Offset: 0x00037C20
		private static global::System.Collections.Generic.List<global::NPOI.POIFS.Properties.Property> BuildProperties(global::System.Collections.Generic.IEnumerator<global::NPOI.Util.ByteBuffer> dataSource, global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize)
		{
			global::System.Collections.Generic.List<global::NPOI.POIFS.Properties.Property> list = new global::System.Collections.Generic.List<global::NPOI.POIFS.Properties.Property>();
			while (dataSource.MoveNext())
			{
				global::NPOI.Util.ByteBuffer byteBuffer = dataSource.Current;
				byte[] array;
				if (byteBuffer.HasBuffer && byteBuffer.Offset == 0 && byteBuffer.Buffer.Length == bigBlockSize.GetBigBlockSize())
				{
					array = byteBuffer.Buffer;
				}
				else
				{
					array = new byte[bigBlockSize.GetBigBlockSize()];
					int length = array.Length;
					if (byteBuffer.Remaining() < bigBlockSize.GetBigBlockSize())
					{
						length = byteBuffer.Remaining();
					}
					byteBuffer.Read(array, 0, length);
				}
				global::NPOI.POIFS.Properties.PropertyFactory.ConvertToProperties(array, list);
			}
			return list;
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x00039AA4 File Offset: 0x00037CA4
		public override int CountBlocks
		{
			get
			{
				long num = (long)(this._properties.Count * 128);
				int bigBlockSize = this._bigBigBlockSize.GetBigBlockSize();
				int num2 = (int)(num / (long)bigBlockSize);
				if (num % (long)bigBlockSize != 0L)
				{
					num2++;
				}
				return num2;
			}
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x00039AE0 File Offset: 0x00037CE0
		public void PreWrite()
		{
			global::System.Collections.Generic.List<global::NPOI.POIFS.Properties.Property> list = new global::System.Collections.Generic.List<global::NPOI.POIFS.Properties.Property>();
			int num = 0;
			foreach (global::NPOI.POIFS.Properties.Property property in this._properties)
			{
				if (property != null)
				{
					property.Index = num++;
					list.Add(property);
				}
			}
			foreach (global::NPOI.POIFS.Properties.Property property2 in list)
			{
				property2.PreWrite();
			}
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x00039B84 File Offset: 0x00037D84
		public void Write(global::NPOI.POIFS.FileSystem.NPOIFSStream stream)
		{
			global::System.IO.Stream outputStream = stream.GetOutputStream();
			try
			{
				new global::System.IO.MemoryStream();
				foreach (global::NPOI.POIFS.Properties.Property property in this._properties)
				{
					if (property != null)
					{
						property.WriteData(outputStream);
					}
				}
				outputStream.Close();
				if (this.StartBlock != stream.GetStartBlock())
				{
					this.StartBlock = stream.GetStartBlock();
				}
			}
			catch (global::System.IO.IOException ex)
			{
				throw ex;
			}
		}

		// Token: 0x040007EF RID: 2031
		private global::NPOI.POIFS.Common.POIFSBigBlockSize _bigBigBlockSize;
	}
}
