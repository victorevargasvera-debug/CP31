using System;
using NPOI.DDF;
using NPOI.HSSF.Record;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200036E RID: 878
	[global::System.Serializable]
	public class HSSFComment : global::NPOI.HSSF.UserModel.HSSFTextbox, global::NPOI.SS.UserModel.IComment
	{
		// Token: 0x06001B61 RID: 7009 RVA: 0x00054021 File Offset: 0x00052221
		public HSSFComment(global::NPOI.DDF.EscherContainerRecord spContainer, global::NPOI.HSSF.Record.ObjRecord objRecord, global::NPOI.HSSF.Record.TextObjectRecord textObjectRecord, global::NPOI.HSSF.Record.NoteRecord _note) : base(spContainer, objRecord, textObjectRecord)
		{
			this._note = _note;
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x00054034 File Offset: 0x00052234
		public HSSFComment(global::NPOI.HSSF.UserModel.HSSFShape parent, global::NPOI.HSSF.UserModel.HSSFAnchor anchor) : this(parent, anchor, global::NPOI.HSSF.UserModel.HSSFComment.CreateNoteRecord())
		{
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x00054044 File Offset: 0x00052244
		private HSSFComment(global::NPOI.HSSF.UserModel.HSSFShape parent, global::NPOI.HSSF.UserModel.HSSFAnchor anchor, global::NPOI.HSSF.Record.NoteRecord note) : base(parent, anchor)
		{
			this._note = note;
			base.FillColor = 134217808;
			this.Visible = false;
			this.Author = "";
			((global::NPOI.HSSF.Record.CommonObjectDataSubRecord)base.GetObjRecord().SubRecords[0]).ObjectType = global::NPOI.HSSF.Record.CommonObjectType.Comment;
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0005409A File Offset: 0x0005229A
		public HSSFComment(global::NPOI.HSSF.Record.NoteRecord note, global::NPOI.HSSF.Record.TextObjectRecord txo) : this(null, new global::NPOI.HSSF.UserModel.HSSFClientAnchor(), note)
		{
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x000540A9 File Offset: 0x000522A9
		internal override void AfterInsert(global::NPOI.HSSF.UserModel.HSSFPatriarch patriarch)
		{
			base.AfterInsert(patriarch);
			patriarch.GetBoundAggregate().AddTailRecord(this.NoteRecord);
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x000540C4 File Offset: 0x000522C4
		protected override global::NPOI.DDF.EscherContainerRecord CreateSpContainer()
		{
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord = base.CreateSpContainer();
			global::NPOI.DDF.EscherOptRecord escherOptRecord = (global::NPOI.DDF.EscherOptRecord)escherContainerRecord.GetChildById(-4085);
			escherOptRecord.RemoveEscherProperty(129);
			escherOptRecord.RemoveEscherProperty(131);
			escherOptRecord.RemoveEscherProperty(130);
			escherOptRecord.RemoveEscherProperty(132);
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(959, false, false, 655362));
			return escherContainerRecord;
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x0005412C File Offset: 0x0005232C
		protected override global::NPOI.HSSF.Record.ObjRecord CreateObjRecord()
		{
			global::NPOI.HSSF.Record.ObjRecord objRecord = new global::NPOI.HSSF.Record.ObjRecord();
			global::NPOI.HSSF.Record.CommonObjectDataSubRecord commonObjectDataSubRecord = new global::NPOI.HSSF.Record.CommonObjectDataSubRecord();
			commonObjectDataSubRecord.ObjectType = (global::NPOI.HSSF.Record.CommonObjectType)202;
			commonObjectDataSubRecord.IsLocked = true;
			commonObjectDataSubRecord.IsPrintable = true;
			commonObjectDataSubRecord.IsAutoFill = false;
			commonObjectDataSubRecord.IsAutoline = true;
			global::NPOI.HSSF.Record.NoteStructureSubRecord o = new global::NPOI.HSSF.Record.NoteStructureSubRecord();
			global::NPOI.HSSF.Record.EndSubRecord o2 = new global::NPOI.HSSF.Record.EndSubRecord();
			objRecord.AddSubRecord(commonObjectDataSubRecord);
			objRecord.AddSubRecord(o);
			objRecord.AddSubRecord(o2);
			return objRecord;
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x0005418C File Offset: 0x0005238C
		private static global::NPOI.HSSF.Record.NoteRecord CreateNoteRecord()
		{
			return new global::NPOI.HSSF.Record.NoteRecord
			{
				Flags = 0,
				Author = ""
			};
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x000541A5 File Offset: 0x000523A5
		// (set) Token: 0x06001B6A RID: 7018 RVA: 0x000541B0 File Offset: 0x000523B0
		public override int ShapeId
		{
			get
			{
				return base.ShapeId;
			}
			set
			{
				if (value > 65535)
				{
					throw new global::System.ArgumentException("Cannot add more than 65535 shapes");
				}
				base.ShapeId = value;
				((global::NPOI.HSSF.Record.CommonObjectDataSubRecord)base.GetObjRecord().SubRecords[0]).ObjectId = value;
				this._note.ShapeId = value;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x000541FF File Offset: 0x000523FF
		// (set) Token: 0x06001B6C RID: 7020 RVA: 0x0005420F File Offset: 0x0005240F
		public bool Visible
		{
			get
			{
				return this._note.Flags == 2;
			}
			set
			{
				if (this._note != null)
				{
					this._note.Flags = (value ? 2 : 0);
				}
				this.SetHidden(!value);
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x00054235 File Offset: 0x00052435
		// (set) Token: 0x06001B6E RID: 7022 RVA: 0x00054248 File Offset: 0x00052448
		public global::NPOI.SS.Util.CellAddress Address
		{
			get
			{
				return new global::NPOI.SS.Util.CellAddress(this.Row, this.Column);
			}
			set
			{
				this.Row = value.Row;
				this.Column = value.Column;
			}
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x00054262 File Offset: 0x00052462
		public void SetAddress(int row, int col)
		{
			this.Row = row;
			this.Column = col;
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001B70 RID: 7024 RVA: 0x00054272 File Offset: 0x00052472
		// (set) Token: 0x06001B71 RID: 7025 RVA: 0x0005427F File Offset: 0x0005247F
		public int Row
		{
			get
			{
				return this._note.Row;
			}
			set
			{
				if (this._note != null)
				{
					this._note.Row = value;
				}
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001B72 RID: 7026 RVA: 0x00054295 File Offset: 0x00052495
		// (set) Token: 0x06001B73 RID: 7027 RVA: 0x000542A2 File Offset: 0x000524A2
		public int Column
		{
			get
			{
				return this._note.Column;
			}
			set
			{
				if (this._note != null)
				{
					this._note.Column = value;
				}
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001B74 RID: 7028 RVA: 0x000542B8 File Offset: 0x000524B8
		// (set) Token: 0x06001B75 RID: 7029 RVA: 0x000542C5 File Offset: 0x000524C5
		public string Author
		{
			get
			{
				return this._note.Author;
			}
			set
			{
				if (this._note != null)
				{
					this._note.Author = value;
				}
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x000542DB File Offset: 0x000524DB
		internal global::NPOI.HSSF.Record.NoteRecord NoteRecord
		{
			get
			{
				return this._note;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x000542E3 File Offset: 0x000524E3
		public bool HasPosition
		{
			get
			{
				return this._note != null && this.Column >= 0 && this.Row >= 0;
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x00054304 File Offset: 0x00052504
		public global::NPOI.SS.UserModel.IClientAnchor ClientAnchor
		{
			get
			{
				global::NPOI.HSSF.UserModel.HSSFAnchor anchor = base.Anchor;
				if (anchor is global::NPOI.SS.UserModel.IClientAnchor)
				{
					return (global::NPOI.SS.UserModel.IClientAnchor)anchor;
				}
				throw new global::System.InvalidCastException("Anchor can not be changed in " + typeof(global::NPOI.SS.UserModel.IClientAnchor).Name);
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x00054345 File Offset: 0x00052545
		// (set) Token: 0x06001B7A RID: 7034 RVA: 0x0004DB72 File Offset: 0x0004BD72
		public override int ShapeType
		{
			get
			{
				return base.ShapeType;
			}
			set
			{
				throw new global::System.InvalidOperationException("Shape type can not be changed in " + base.GetType().Name);
			}
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x0005434D File Offset: 0x0005254D
		internal override void AfterRemove(global::NPOI.HSSF.UserModel.HSSFPatriarch patriarch)
		{
			base.AfterRemove(patriarch);
			patriarch.GetBoundAggregate().RemoveTailRecord(this.NoteRecord);
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x00054368 File Offset: 0x00052568
		internal override global::NPOI.HSSF.UserModel.HSSFShape CloneShape()
		{
			global::NPOI.HSSF.Record.TextObjectRecord textObjectRecord = (global::NPOI.HSSF.Record.TextObjectRecord)base.GetTextObjectRecord().CloneViaReserialise();
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord = new global::NPOI.DDF.EscherContainerRecord();
			byte[] data = base.GetEscherContainer().Serialize();
			escherContainerRecord.FillFields(data, 0, new global::NPOI.DDF.DefaultEscherRecordFactory());
			global::NPOI.HSSF.Record.ObjRecord objRecord = (global::NPOI.HSSF.Record.ObjRecord)base.GetObjRecord().CloneViaReserialise();
			global::NPOI.HSSF.Record.NoteRecord note = (global::NPOI.HSSF.Record.NoteRecord)this.NoteRecord.CloneViaReserialise();
			return new global::NPOI.HSSF.UserModel.HSSFComment(escherContainerRecord, objRecord, textObjectRecord, note);
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x000543D0 File Offset: 0x000525D0
		public void SetBackgroundImage(int pictureIndex)
		{
			base.SetPropertyValue(new global::NPOI.DDF.EscherSimpleProperty(390, false, true, pictureIndex));
			base.SetPropertyValue(new global::NPOI.DDF.EscherSimpleProperty(384, false, false, 3));
			((global::NPOI.HSSF.UserModel.HSSFWorkbook)base.Patriarch.Sheet.Workbook).Workbook.GetBSERecord(pictureIndex).Ref++;
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x00054430 File Offset: 0x00052630
		public void ResetBackgroundImage()
		{
			global::NPOI.DDF.EscherSimpleProperty escherSimpleProperty = (global::NPOI.DDF.EscherSimpleProperty)base.GetOptRecord().Lookup(390);
			if (escherSimpleProperty != null)
			{
				((global::NPOI.HSSF.UserModel.HSSFWorkbook)base.Patriarch.Sheet.Workbook).Workbook.GetBSERecord(escherSimpleProperty.PropertyValue).Ref--;
				base.GetOptRecord().RemoveEscherProperty(390);
			}
			base.SetPropertyValue(new global::NPOI.DDF.EscherSimpleProperty(384, false, false, 0));
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x000544AC File Offset: 0x000526AC
		public int GetBackgroundImageId()
		{
			global::NPOI.DDF.EscherSimpleProperty escherSimpleProperty = (global::NPOI.DDF.EscherSimpleProperty)base.GetOptRecord().Lookup(390);
			if (escherSimpleProperty != null)
			{
				return escherSimpleProperty.PropertyValue;
			}
			return 0;
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x000544DC File Offset: 0x000526DC
		private void SetHidden(bool value)
		{
			global::NPOI.DDF.EscherSimpleProperty escherSimpleProperty = (global::NPOI.DDF.EscherSimpleProperty)base.GetOptRecord().Lookup(959);
			if (value)
			{
				base.SetPropertyValue(new global::NPOI.DDF.EscherSimpleProperty(959, false, false, escherSimpleProperty.PropertyValue | 16777218));
				return;
			}
			base.SetPropertyValue(new global::NPOI.DDF.EscherSimpleProperty(959, false, false, escherSimpleProperty.PropertyValue & -16777219));
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x00054540 File Offset: 0x00052740
		public override bool Equals(object obj)
		{
			if (!(obj is global::NPOI.HSSF.UserModel.HSSFComment))
			{
				return false;
			}
			global::NPOI.HSSF.UserModel.HSSFComment hssfcomment = (global::NPOI.HSSF.UserModel.HSSFComment)obj;
			return this.NoteRecord.Equals(hssfcomment.NoteRecord);
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x0005456F File Offset: 0x0005276F
		public override int GetHashCode()
		{
			return (this.Row * 17 + this.Column) * 31;
		}

		// Token: 0x04000B37 RID: 2871
		private const int FILL_TYPE_SOLID = 0;

		// Token: 0x04000B38 RID: 2872
		private const int FILL_TYPE_PICTURE = 3;

		// Token: 0x04000B39 RID: 2873
		private const int GROUP_SHAPE_PROPERTY_DEFAULT_VALUE = 655362;

		// Token: 0x04000B3A RID: 2874
		private const int GROUP_SHAPE_HIDDEN_MASK = 16777218;

		// Token: 0x04000B3B RID: 2875
		private const int GROUP_SHAPE_NOT_HIDDEN_MASK = -16777219;

		// Token: 0x04000B3C RID: 2876
		private global::NPOI.HSSF.Record.NoteRecord _note;
	}
}
