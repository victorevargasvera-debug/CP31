using System;
using System.Collections.Generic;
using System.IO;
using NPOI.POIFS.Common;
using NPOI.POIFS.Properties;

namespace NPOI.POIFS.Storage
{
	// Token: 0x020002B0 RID: 688
	public class PropertyBlock : global::NPOI.POIFS.Storage.BigBlock
	{
		// Token: 0x060012FF RID: 4863 RVA: 0x000391CC File Offset: 0x000373CC
		protected PropertyBlock(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, global::NPOI.POIFS.Properties.Property[] properties, int offset) : base(bigBlockSize)
		{
			this._properties = new global::NPOI.POIFS.Properties.Property[bigBlockSize.GetPropertiesPerBlock()];
			for (int i = 0; i < this._properties.Length; i++)
			{
				this._properties[i] = properties[i + offset];
			}
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00039214 File Offset: 0x00037414
		public static global::NPOI.POIFS.Storage.BlockWritable[] CreatePropertyBlockArray(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, global::System.Collections.Generic.List<global::NPOI.POIFS.Properties.Property> properties)
		{
			int propertiesPerBlock = bigBlockSize.GetPropertiesPerBlock();
			int num = (properties.Count + propertiesPerBlock - 1) / propertiesPerBlock;
			global::NPOI.POIFS.Properties.Property[] array = new global::NPOI.POIFS.Properties.Property[num * propertiesPerBlock];
			global::System.Array.Copy(properties.ToArray(), 0, array, 0, properties.Count);
			for (int i = properties.Count; i < array.Length; i++)
			{
				array[i] = new global::NPOI.POIFS.Storage.PropertyBlock.AnonymousProperty();
			}
			global::NPOI.POIFS.Storage.BlockWritable[] array2 = new global::NPOI.POIFS.Storage.BlockWritable[num];
			for (int j = 0; j < num; j++)
			{
				array2[j] = new global::NPOI.POIFS.Storage.PropertyBlock(bigBlockSize, array, j * propertiesPerBlock);
			}
			return array2;
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x0003929C File Offset: 0x0003749C
		public override void WriteData(global::System.IO.Stream stream)
		{
			int propertiesPerBlock = this.bigBlockSize.GetPropertiesPerBlock();
			for (int i = 0; i < propertiesPerBlock; i++)
			{
				this._properties[i].WriteData(stream);
			}
		}

		// Token: 0x040007DF RID: 2015
		private global::NPOI.POIFS.Properties.Property[] _properties;

		// Token: 0x020005A6 RID: 1446
		private class AnonymousProperty : global::NPOI.POIFS.Properties.Property
		{
			// Token: 0x0600347C RID: 13436 RVA: 0x00019A7F File Offset: 0x00017C7F
			public override void PreWrite()
			{
			}

			// Token: 0x17000DB6 RID: 3510
			// (get) Token: 0x0600347D RID: 13437 RVA: 0x00006EB4 File Offset: 0x000050B4
			public override bool IsDirectory
			{
				get
				{
					return false;
				}
			}
		}
	}
}
