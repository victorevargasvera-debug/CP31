using System;
using System.IO;
using System.IO.Packaging;
using System.Windows.Documents;
using System.Windows.Xps.Packaging;

namespace SpecialFeatures.AcpReportManagerLib
{
	// Token: 0x0200024F RID: 591
	internal class XPFContent
	{
		// Token: 0x06001D52 RID: 7506 RVA: 0x0000404E File Offset: 0x0000224E
		internal XPFContent(string contentPath)
		{
			this.a = contentPath;
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x002B117C File Offset: 0x002AF37C
		internal global::System.Windows.Documents.IDocumentPaginatorSource LoadViewableFixedContent(string documentName)
		{
			global::System.Windows.Xps.Packaging.XpsDocument xpsDocument = null;
			global::System.Windows.Documents.IDocumentPaginatorSource result = null;
			short num;
			try
			{
				xpsDocument = new global::System.Windows.Xps.Packaging.XpsDocument(documentName, global::System.IO.FileAccess.Read, global::System.IO.Packaging.CompressionOption.NotCompressed);
				result = xpsDocument.GetFixedDocumentSequence();
			}
			finally
			{
				num = (short)1293464475;
				short num2 = num;
				num = (short)2018161563;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_97:
					if (xpsDocument == null)
					{
						goto IL_CD;
					}
					num = (short)2024734721;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)707723264;
					if (num != 0)
					{
					}
					num = (short)182648834;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_CB;
					case 1:
						xpsDocument.Close();
						num = (short)1430585344;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_97;
						}
						continue;
					}
					goto IL_97;
				}
				IL_CB:
				IL_CD:;
			}
			num = (short)1987575809;
			if (num != 0)
			{
			}
			num = (short)781647872;
			short num4 = num;
			return result;
		}

		// Token: 0x04000EC1 RID: 3777
		private string a;
	}
}
