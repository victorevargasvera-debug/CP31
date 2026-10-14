using System;
using System.Text;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200037C RID: 892
	public class HSSFName : global::NPOI.SS.UserModel.IName
	{
		// Token: 0x06001C58 RID: 7256 RVA: 0x00055DFB File Offset: 0x00053FFB
		internal HSSFName(global::NPOI.HSSF.UserModel.HSSFWorkbook book, global::NPOI.HSSF.Record.NameRecord name) : this(book, name, null)
		{
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x00055E06 File Offset: 0x00054006
		internal HSSFName(global::NPOI.HSSF.UserModel.HSSFWorkbook book, global::NPOI.HSSF.Record.NameRecord name, global::NPOI.HSSF.Record.NameCommentRecord comment)
		{
			this.book = book;
			this._definedNameRec = name;
			this._commentRec = comment;
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x00055E24 File Offset: 0x00054024
		public string SheetName
		{
			get
			{
				int externSheetNumber = this._definedNameRec.ExternSheetNumber;
				return this.book.Workbook.FindSheetFirstNameFromExternSheet(externSheetNumber);
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x00055E4E File Offset: 0x0005404E
		// (set) Token: 0x06001C5C RID: 7260 RVA: 0x00055E5C File Offset: 0x0005405C
		public string NameName
		{
			get
			{
				return this._definedNameRec.NameText;
			}
			set
			{
				this.ValidateName(value);
				this._definedNameRec.NameText = value;
				global::NPOI.HSSF.Model.InternalWorkbook workbook = this.book.Workbook;
				int sheetNumber = this._definedNameRec.SheetNumber;
				for (int i = workbook.NumNames - 1; i >= 0; i--)
				{
					global::NPOI.HSSF.Record.NameRecord nameRecord = workbook.GetNameRecord(i);
					if (nameRecord != this._definedNameRec && nameRecord.NameText.Equals(this.NameName, global::System.StringComparison.OrdinalIgnoreCase) && sheetNumber == nameRecord.SheetNumber)
					{
						string message = "The " + ((sheetNumber == 0) ? "workbook" : "sheet") + " already contains this name: " + value;
						this._definedNameRec.NameText = value + "(2)";
						throw new global::System.ArgumentException(message);
					}
				}
				if (this._commentRec != null)
				{
					string nameText = this._commentRec.NameText;
					this._commentRec.NameText = value;
					this.book.Workbook.UpdateNameCommentRecordCache(this._commentRec);
				}
			}
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x00055F48 File Offset: 0x00054148
		private void ValidateName(string name)
		{
			if (name.Length == 0)
			{
				throw new global::System.ArgumentException("Name cannot be blank");
			}
			char c = name[0];
			string text = "_";
			if (!char.IsLetter(c) && text.IndexOf(c) == -1)
			{
				throw new global::System.ArgumentException("Invalid name: '" + name + "': first character must be underscore or a letter");
			}
			text = "_\\";
			foreach (char c2 in name.ToCharArray())
			{
				if (!char.IsLetterOrDigit(c2) && text.IndexOf(c2) == -1)
				{
					throw new global::System.ArgumentException("Invalid name: '" + name + "'");
				}
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x00055FF8 File Offset: 0x000541F8
		// (set) Token: 0x06001C5F RID: 7263 RVA: 0x00056040 File Offset: 0x00054240
		public string RefersToFormula
		{
			get
			{
				if (this._definedNameRec.IsFunctionName)
				{
					throw new global::System.InvalidOperationException("Only applicable to named ranges");
				}
				global::NPOI.SS.Formula.PTG.Ptg[] nameDefinition = this._definedNameRec.NameDefinition;
				if (nameDefinition.Length < 1)
				{
					return null;
				}
				return global::NPOI.HSSF.Model.HSSFFormulaParser.ToFormulaString(this.book, nameDefinition);
			}
			set
			{
				global::NPOI.SS.Formula.PTG.Ptg[] nameDefinition = global::NPOI.HSSF.Model.HSSFFormulaParser.Parse(value, this.book, global::NPOI.SS.Formula.FormulaType.NamedRange, this.SheetIndex);
				this._definedNameRec.NameDefinition = nameDefinition;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x0005606D File Offset: 0x0005426D
		// (set) Token: 0x06001C61 RID: 7265 RVA: 0x0005607C File Offset: 0x0005427C
		public int SheetIndex
		{
			get
			{
				return this._definedNameRec.SheetNumber - 1;
			}
			set
			{
				int num = this.book.NumberOfSheets - 1;
				if (value < -1 || value > num)
				{
					throw new global::System.ArgumentException("Sheet index (" + value.ToString() + ") is out of range" + ((num == -1) ? "" : (" (0.." + num.ToString() + ")")));
				}
				this._definedNameRec.SheetNumber = value + 1;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x000560EC File Offset: 0x000542EC
		// (set) Token: 0x06001C63 RID: 7267 RVA: 0x00056138 File Offset: 0x00054338
		public string Comment
		{
			get
			{
				if (this._commentRec != null && this._commentRec.CommentText != null && this._commentRec.CommentText.Length > 0)
				{
					return this._commentRec.CommentText;
				}
				return this._definedNameRec.DescriptionText;
			}
			set
			{
				this._definedNameRec.DescriptionText = value;
			}
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x00056146 File Offset: 0x00054346
		public void SetNameDefinition(global::NPOI.SS.Formula.PTG.Ptg[] ptgs)
		{
			this._definedNameRec.NameDefinition = ptgs;
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x00056154 File Offset: 0x00054354
		public bool IsDeleted
		{
			get
			{
				return global::NPOI.SS.Formula.PTG.Ptg.DoesFormulaReferToDeletedCell(this._definedNameRec.NameDefinition);
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x00056166 File Offset: 0x00054366
		public bool IsFunctionName
		{
			get
			{
				return this._definedNameRec.IsFunctionName;
			}
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x00056173 File Offset: 0x00054373
		public void SetFunction(bool value)
		{
			this._definedNameRec.SetFunction(value);
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x00056184 File Offset: 0x00054384
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append(this._definedNameRec.NameText);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x04000B61 RID: 2913
		private global::NPOI.HSSF.UserModel.HSSFWorkbook book;

		// Token: 0x04000B62 RID: 2914
		private global::NPOI.HSSF.Record.NameRecord _definedNameRec;

		// Token: 0x04000B63 RID: 2915
		private global::NPOI.HSSF.Record.NameCommentRecord _commentRec;
	}
}
