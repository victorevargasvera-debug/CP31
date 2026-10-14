using System;
using System.IO;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000430 RID: 1072
	public class SupBookRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002773 RID: 10099 RVA: 0x00076AA6 File Offset: 0x00074CA6
		public static global::NPOI.HSSF.Record.SupBookRecord CreateInternalReferences(short numberOfSheets)
		{
			return new global::NPOI.HSSF.Record.SupBookRecord(false, numberOfSheets);
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x00076AAF File Offset: 0x00074CAF
		public static global::NPOI.HSSF.Record.SupBookRecord CreateAddInFunctions()
		{
			return new global::NPOI.HSSF.Record.SupBookRecord(true, 1);
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x00076AB8 File Offset: 0x00074CB8
		public static global::NPOI.HSSF.Record.SupBookRecord CreateExternalReferences(string url, string[] sheetNames)
		{
			return new global::NPOI.HSSF.Record.SupBookRecord(url, sheetNames);
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x00076AC1 File Offset: 0x00074CC1
		private SupBookRecord(bool IsAddInFuncs, short numberOfSheets)
		{
			this.field_1_number_of_sheets = numberOfSheets;
			this.field_2_encoded_url = null;
			this.field_3_sheet_names = null;
			this._isAddInFunctions = IsAddInFuncs;
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x00076AE5 File Offset: 0x00074CE5
		public SupBookRecord(string url, string[] sheetNames)
		{
			this.field_1_number_of_sheets = (short)sheetNames.Length;
			this.field_2_encoded_url = url;
			this.field_3_sheet_names = sheetNames;
			this._isAddInFunctions = false;
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x00076B0C File Offset: 0x00074D0C
		public SupBookRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			int remaining = in1.Remaining;
			this.field_1_number_of_sheets = in1.ReadShort();
			if (remaining > 4)
			{
				this._isAddInFunctions = false;
				this.field_2_encoded_url = in1.ReadString();
				string[] array = new string[(int)this.field_1_number_of_sheets];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = in1.ReadString();
				}
				this.field_3_sheet_names = array;
				return;
			}
			this.field_2_encoded_url = null;
			this.field_3_sheet_names = null;
			short num = in1.ReadShort();
			if (num == 1025)
			{
				this._isAddInFunctions = false;
				return;
			}
			if (num != 14849)
			{
				throw new global::System.Exception("invalid EXTERNALBOOK code (" + global::NPOI.Util.StringUtil.ToHexString(num) + ")");
			}
			this._isAddInFunctions = true;
			if (this.field_1_number_of_sheets != 1)
			{
				throw new global::System.Exception("Expected 0x0001 for number of sheets field in 'Add-In Functions' but got (" + this.field_1_number_of_sheets.ToString() + ")");
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06002779 RID: 10105 RVA: 0x00076BEA File Offset: 0x00074DEA
		public bool IsExternalReferences
		{
			get
			{
				return this.field_3_sheet_names != null;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x00076BF5 File Offset: 0x00074DF5
		public bool IsInternalReferences
		{
			get
			{
				return this.field_3_sheet_names == null && !this._isAddInFunctions;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x0600277B RID: 10107 RVA: 0x00076C0A File Offset: 0x00074E0A
		public bool IsAddInFunctions
		{
			get
			{
				return this.field_3_sheet_names == null && this._isAddInFunctions;
			}
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x00076C1C File Offset: 0x00074E1C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SUPBOOK ");
			if (this.IsExternalReferences)
			{
				stringBuilder.Append("External References]\n");
				stringBuilder.Append(" .url     = ").Append(this.field_2_encoded_url).Append("\n");
				stringBuilder.Append(" .nSheets = ").Append(this.field_1_number_of_sheets).Append("\n");
				foreach (string value in this.field_3_sheet_names)
				{
					stringBuilder.Append("    .name = ").Append(value).Append("\n");
				}
				stringBuilder.Append("[/SUPBOOK");
			}
			else if (this._isAddInFunctions)
			{
				stringBuilder.Append("Add-In Functions");
			}
			else
			{
				stringBuilder.Append("Internal References ");
				stringBuilder.Append(" nSheets= ").Append(this.field_1_number_of_sheets);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x0600277D RID: 10109 RVA: 0x00076D18 File Offset: 0x00074F18
		protected override int DataSize
		{
			get
			{
				if (!this.IsExternalReferences)
				{
					return 4;
				}
				int num = 2;
				num += global::NPOI.Util.StringUtil.GetEncodedSize(this.field_2_encoded_url);
				for (int i = 0; i < this.field_3_sheet_names.Length; i++)
				{
					num += global::NPOI.Util.StringUtil.GetEncodedSize(this.field_3_sheet_names[i]);
				}
				return num;
			}
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x00076D64 File Offset: 0x00074F64
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_number_of_sheets);
			if (this.IsExternalReferences)
			{
				global::NPOI.Util.StringUtil.WriteUnicodeString(out1, this.field_2_encoded_url);
				for (int i = 0; i < this.field_3_sheet_names.Length; i++)
				{
					global::NPOI.Util.StringUtil.WriteUnicodeString(out1, this.field_3_sheet_names[i]);
				}
				return;
			}
			int v = this._isAddInFunctions ? 14849 : 1025;
			out1.WriteShort(v);
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x0600277F RID: 10111 RVA: 0x00076DCF File Offset: 0x00074FCF
		// (set) Token: 0x06002780 RID: 10112 RVA: 0x00076DD7 File Offset: 0x00074FD7
		public short NumberOfSheets
		{
			get
			{
				return this.field_1_number_of_sheets;
			}
			set
			{
				this.field_1_number_of_sheets = value;
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06002781 RID: 10113 RVA: 0x00076DE0 File Offset: 0x00074FE0
		public override short Sid
		{
			get
			{
				return 430;
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06002782 RID: 10114 RVA: 0x00076DE8 File Offset: 0x00074FE8
		// (set) Token: 0x06002783 RID: 10115 RVA: 0x00076E30 File Offset: 0x00075030
		public string URL
		{
			get
			{
				string text = this.field_2_encoded_url;
				switch (text[0])
				{
				case '\0':
					return text.Substring(1);
				case '\u0001':
					return global::NPOI.HSSF.Record.SupBookRecord.DecodeFileName(text);
				case '\u0002':
					return text.Substring(1);
				default:
					return text;
				}
			}
			set
			{
				this.field_2_encoded_url = this.field_2_encoded_url.Substring(0, 1) + value;
			}
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x00076E4C File Offset: 0x0007504C
		private static string DecodeFileName(string encodedUrl)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = 1; i < encodedUrl.Length; i++)
			{
				char value = encodedUrl[i];
				switch (value)
				{
				case '\u0001':
				{
					char c = encodedUrl[++i];
					if (c == '@')
					{
						stringBuilder.Append("\\\\");
					}
					else
					{
						stringBuilder.Append(c).Append(":");
					}
					break;
				}
				case '\u0002':
					stringBuilder.Append(global::NPOI.HSSF.Record.SupBookRecord.PATH_SEPERATOR);
					break;
				case '\u0003':
					stringBuilder.Append(global::NPOI.HSSF.Record.SupBookRecord.PATH_SEPERATOR);
					break;
				case '\u0004':
					stringBuilder.Append("..").Append(global::NPOI.HSSF.Record.SupBookRecord.PATH_SEPERATOR);
					break;
				case '\u0005':
					global::NPOI.HSSF.Record.SupBookRecord.logger.Log(5, "Found unexpected key: ChLongVolume - IGNORING");
					break;
				case '\u0006':
				case '\a':
				case '\b':
					global::NPOI.HSSF.Record.SupBookRecord.logger.Log(5, "EXCEL.EXE path unkown - using this directoy instead: .");
					stringBuilder.Append(".").Append(global::NPOI.HSSF.Record.SupBookRecord.PATH_SEPERATOR);
					break;
				default:
					stringBuilder.Append(value);
					break;
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06002785 RID: 10117 RVA: 0x00076F5D File Offset: 0x0007515D
		public string[] SheetNames
		{
			get
			{
				return (string[])this.field_3_sheet_names.Clone();
			}
		}

		// Token: 0x040010AB RID: 4267
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.HSSF.Record.SupBookRecord));

		// Token: 0x040010AC RID: 4268
		public const short sid = 430;

		// Token: 0x040010AD RID: 4269
		private const short SMALL_RECORD_SIZE = 4;

		// Token: 0x040010AE RID: 4270
		private const short TAG_INTERNAL_REFERENCES = 1025;

		// Token: 0x040010AF RID: 4271
		private const short TAG_ADD_IN_FUNCTIONS = 14849;

		// Token: 0x040010B0 RID: 4272
		private short field_1_number_of_sheets;

		// Token: 0x040010B1 RID: 4273
		private string field_2_encoded_url;

		// Token: 0x040010B2 RID: 4274
		private string[] field_3_sheet_names;

		// Token: 0x040010B3 RID: 4275
		private bool _isAddInFunctions;

		// Token: 0x040010B4 RID: 4276
		public const char CH_VOLUME = '\u0001';

		// Token: 0x040010B5 RID: 4277
		public const char CH_SAME_VOLUME = '\u0002';

		// Token: 0x040010B6 RID: 4278
		public const char CH_DOWN_DIR = '\u0003';

		// Token: 0x040010B7 RID: 4279
		public const char CH_UP_DIR = '\u0004';

		// Token: 0x040010B8 RID: 4280
		public const char CH_LONG_VOLUME = '\u0005';

		// Token: 0x040010B9 RID: 4281
		public const char CH_STARTUP_DIR = '\u0006';

		// Token: 0x040010BA RID: 4282
		public const char CH_ALT_STARTUP_DIR = '\a';

		// Token: 0x040010BB RID: 4283
		public const char CH_LIB_DIR = '\b';

		// Token: 0x040010BC RID: 4284
		public static readonly char PATH_SEPERATOR = global::System.IO.Path.DirectorySeparatorChar;
	}
}
