using System;
using System.Collections;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000372 RID: 882
	[global::System.Serializable]
	public class HSSFDataFormat : global::NPOI.SS.UserModel.IDataFormat
	{
		// Token: 0x06001BAF RID: 7087 RVA: 0x00054A24 File Offset: 0x00052C24
		public HSSFDataFormat(global::NPOI.HSSF.Model.InternalWorkbook workbook)
		{
			this.workbook = workbook;
			foreach (object obj in workbook.Formats)
			{
				global::NPOI.HSSF.Record.FormatRecord formatRecord = (global::NPOI.HSSF.Record.FormatRecord)obj;
				int num = this.formats.Count;
				while (this.formats.Count <= formatRecord.IndexCode)
				{
					this.formats.Add(null);
					num++;
				}
				this.formats[formatRecord.IndexCode] = formatRecord.FormatString;
			}
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x00054AB8 File Offset: 0x00052CB8
		public static global::System.Collections.Generic.List<string> GetBuiltinFormats()
		{
			return global::NPOI.HSSF.UserModel.HSSFDataFormat.builtinFormats;
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x00054AC0 File Offset: 0x00052CC0
		public static short GetBuiltinFormat(string format)
		{
			if (format.ToUpper().Equals("TEXT"))
			{
				format = "@";
			}
			short result = -1;
			for (short num = 0; num <= 49; num += 1)
			{
				string text = global::NPOI.HSSF.UserModel.HSSFDataFormat.builtinFormats[(int)num];
				if (text != null && text.Equals(format))
				{
					result = num;
					break;
				}
			}
			return result;
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00054B14 File Offset: 0x00052D14
		public short GetFormat(string pFormat)
		{
			string text;
			if (pFormat.ToUpper().Equals("TEXT"))
			{
				text = "@";
			}
			else
			{
				text = pFormat;
			}
			global::System.Collections.IEnumerator enumerator;
			int num;
			if (!this.movedBuiltins)
			{
				enumerator = global::NPOI.HSSF.UserModel.HSSFDataFormat.builtinFormats.GetEnumerator();
				num = 0;
				while (enumerator.MoveNext())
				{
					int num2 = this.formats.Count;
					while (this.formats.Count < num + 1)
					{
						this.formats.Add(null);
						num2++;
					}
					this.formats[num] = (enumerator.Current as string);
					num++;
				}
				this.movedBuiltins = true;
			}
			enumerator = this.formats.GetEnumerator();
			num = 0;
			while (enumerator.MoveNext())
			{
				if (text.Equals(enumerator.Current))
				{
					return (short)num;
				}
				num++;
			}
			num = (int)this.workbook.GetFormat(text, true);
			int num3 = this.formats.Count;
			while (this.formats.Count < num + 1)
			{
				this.formats.Add(null);
				num3++;
			}
			this.formats[num] = text;
			return (short)num;
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x00054C34 File Offset: 0x00052E34
		public string GetFormat(short index)
		{
			if (this.movedBuiltins)
			{
				return this.formats[(int)index];
			}
			if (index == -1)
			{
				return null;
			}
			string text = (this.formats.Count > (int)index) ? this.formats[(int)index] : null;
			if (global::NPOI.HSSF.UserModel.HSSFDataFormat.builtinFormats.Count <= (int)index || global::NPOI.HSSF.UserModel.HSSFDataFormat.builtinFormats[(int)index] == null)
			{
				return text;
			}
			if (text != null)
			{
				return text;
			}
			return global::NPOI.HSSF.UserModel.HSSFDataFormat.builtinFormats[(int)index];
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x00054CA6 File Offset: 0x00052EA6
		public static string GetBuiltinFormat(short index)
		{
			return global::NPOI.HSSF.UserModel.HSSFDataFormat.builtinFormats[(int)index];
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x00054CB3 File Offset: 0x00052EB3
		public static int NumberOfBuiltinBuiltinFormats
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HSSFDataFormat.builtinFormats.Count;
			}
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x00054CBF File Offset: 0x00052EBF
		private void EnsureFormatsSize(int index)
		{
			if (this.formats.Count <= index)
			{
				this.formats.Capacity = index + 1;
			}
		}

		// Token: 0x04000B45 RID: 2885
		public const int FIRST_USER_DEFINED_FORMAT_INDEX = 164;

		// Token: 0x04000B46 RID: 2886
		private static global::System.Collections.Generic.List<string> builtinFormats = new global::System.Collections.Generic.List<string>(global::NPOI.SS.UserModel.BuiltinFormats.GetAll());

		// Token: 0x04000B47 RID: 2887
		private global::System.Collections.Generic.List<string> formats = new global::System.Collections.Generic.List<string>();

		// Token: 0x04000B48 RID: 2888
		private global::NPOI.HSSF.Model.InternalWorkbook workbook;

		// Token: 0x04000B49 RID: 2889
		private bool movedBuiltins;
	}
}
