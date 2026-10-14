using System;
using System.Collections.Generic;
using NPOI.POIFS.Storage;

namespace NPOI.POIFS.Properties
{
	// Token: 0x020002BF RID: 703
	public class PropertyFactory
	{
		// Token: 0x06001373 RID: 4979 RVA: 0x0000253E File Offset: 0x0000073E
		private PropertyFactory()
		{
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x0003A694 File Offset: 0x00038894
		public static global::System.Collections.Generic.List<global::NPOI.POIFS.Properties.Property> ConvertToProperties(global::NPOI.POIFS.Storage.ListManagedBlock[] blocks)
		{
			global::System.Collections.Generic.List<global::NPOI.POIFS.Properties.Property> list = new global::System.Collections.Generic.List<global::NPOI.POIFS.Properties.Property>();
			for (int i = 0; i < blocks.Length; i++)
			{
				global::NPOI.POIFS.Properties.PropertyFactory.ConvertToProperties(blocks[i].Data, list);
			}
			return list;
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x0003A6C4 File Offset: 0x000388C4
		public static void ConvertToProperties(byte[] data, global::System.Collections.Generic.List<global::NPOI.POIFS.Properties.Property> properties)
		{
			int num = data.Length / 128;
			int num2 = 0;
			int i = 0;
			while (i < num)
			{
				switch (data[num2 + 66])
				{
				case 1:
					properties.Add(new global::NPOI.POIFS.Properties.DirectoryProperty(properties.Count, data, num2));
					break;
				case 2:
					properties.Add(new global::NPOI.POIFS.Properties.DocumentProperty(properties.Count, data, num2));
					break;
				case 3:
				case 4:
					goto IL_74;
				case 5:
					properties.Add(new global::NPOI.POIFS.Properties.RootProperty(properties.Count, data, num2));
					break;
				default:
					goto IL_74;
				}
				IL_7B:
				num2 += 128;
				i++;
				continue;
				IL_74:
				properties.Add(null);
				goto IL_7B;
			}
		}
	}
}
