using System;
using System.Collections.Generic;
using System.Text;

namespace NPOI.OpenXml4Net.OPC
{
	// Token: 0x02000014 RID: 20
	public class PackagePartCollection : global::System.Collections.Generic.SortedList<global::NPOI.OpenXml4Net.OPC.PackagePartName, global::NPOI.OpenXml4Net.OPC.PackagePart>
	{
		// Token: 0x060000BC RID: 188 RVA: 0x00004790 File Offset: 0x00002990
		public global::NPOI.OpenXml4Net.OPC.PackagePart Put(global::NPOI.OpenXml4Net.OPC.PackagePartName partName, global::NPOI.OpenXml4Net.OPC.PackagePart part)
		{
			string[] array = partName.URI.OriginalString.Split(new char[]
			{
				global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.FORWARD_SLASH_CHAR
			});
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (string text in array)
			{
				if (!text.Equals(""))
				{
					stringBuilder.Append(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.FORWARD_SLASH_CHAR);
				}
				stringBuilder.Append(text);
				if (this.registerPartNameStr.Contains(stringBuilder.ToString()))
				{
					throw new global::System.InvalidOperationException("You can't add a part with a part name derived from another part ! [M1.11]");
				}
			}
			this.registerPartNameStr.Add(partName.Name);
			base[partName] = part;
			return part;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00004831 File Offset: 0x00002A31
		public new void Remove(global::NPOI.OpenXml4Net.OPC.PackagePartName key)
		{
			this.registerPartNameStr.Remove(key.Name);
			base.Remove(key);
		}

		// Token: 0x0400004F RID: 79
		private static long serialVersionUID = 2515031135957635515L;

		// Token: 0x04000050 RID: 80
		private global::System.Collections.Generic.List<string> registerPartNameStr = new global::System.Collections.Generic.List<string>();
	}
}
