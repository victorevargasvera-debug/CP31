using System;
using NPOI.SS.UserModel;
using NPOI.XSSF.Model;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000078 RID: 120
	public class XSSFDataFormat : global::NPOI.SS.UserModel.IDataFormat
	{
		// Token: 0x060005DA RID: 1498 RVA: 0x00015F00 File Offset: 0x00014100
		public XSSFDataFormat(global::NPOI.XSSF.Model.StylesTable stylesSource)
		{
			this.stylesSource = stylesSource;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00015F10 File Offset: 0x00014110
		public short GetFormat(string format)
		{
			int num = global::NPOI.SS.UserModel.BuiltinFormats.GetBuiltinFormat(format);
			if (num == -1)
			{
				num = this.stylesSource.PutNumberFormat(format);
			}
			return (short)num;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00015F37 File Offset: 0x00014137
		public string GetFormat(short index)
		{
			return this.GetFormat((int)index & 65535);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00015F48 File Offset: 0x00014148
		public string GetFormat(int index)
		{
			string text = this.stylesSource.GetNumberFormatAt(index);
			if (text == null)
			{
				text = global::NPOI.SS.UserModel.BuiltinFormats.GetBuiltinFormat(index);
			}
			return text;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00015F6D File Offset: 0x0001416D
		public void PutFormat(short index, string format)
		{
			this.stylesSource.PutNumberFormat(index, format);
		}

		// Token: 0x040002BE RID: 702
		private global::NPOI.XSSF.Model.StylesTable stylesSource;
	}
}
