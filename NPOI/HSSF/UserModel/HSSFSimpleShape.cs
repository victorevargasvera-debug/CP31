using System;
using NPOI.DDF;
using NPOI.HSSF.Record;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200038D RID: 909
	[global::System.Serializable]
	public class HSSFSimpleShape : global::NPOI.HSSF.UserModel.HSSFShape
	{
		// Token: 0x06001E72 RID: 7794 RVA: 0x0005D0AA File Offset: 0x0005B2AA
		public HSSFSimpleShape(global::NPOI.DDF.EscherContainerRecord spContainer, global::NPOI.HSSF.Record.ObjRecord objRecord, global::NPOI.HSSF.Record.TextObjectRecord textObjectRecord) : base(spContainer, objRecord)
		{
			this._textObjectRecord = textObjectRecord;
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x0005D0BB File Offset: 0x0005B2BB
		public HSSFSimpleShape(global::NPOI.DDF.EscherContainerRecord spContainer, global::NPOI.HSSF.Record.ObjRecord objRecord) : base(spContainer, objRecord)
		{
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x0005D0C5 File Offset: 0x0005B2C5
		public HSSFSimpleShape(global::NPOI.HSSF.UserModel.HSSFShape parent, global::NPOI.HSSF.UserModel.HSSFAnchor anchor) : base(parent, anchor)
		{
			this._textObjectRecord = this.CreateTextObjRecord();
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001E75 RID: 7797 RVA: 0x0005D0DB File Offset: 0x0005B2DB
		// (set) Token: 0x06001E76 RID: 7798 RVA: 0x0005D0F7 File Offset: 0x0005B2F7
		public virtual int ShapeType
		{
			get
			{
				return (int)((global::NPOI.DDF.EscherSpRecord)base.GetEscherContainer().GetChildById(-4086)).ShapeType;
			}
			set
			{
				((global::NPOI.HSSF.Record.CommonObjectDataSubRecord)base.GetObjRecord().SubRecords[0]).ObjectType = global::NPOI.HSSF.Record.CommonObjectType.MicrosoftOfficeDrawing;
				((global::NPOI.DDF.EscherSpRecord)base.GetEscherContainer().GetChildById(-4086)).ShapeType = (short)value;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001E77 RID: 7799 RVA: 0x0005D134 File Offset: 0x0005B334
		// (set) Token: 0x06001E78 RID: 7800 RVA: 0x0005D162 File Offset: 0x0005B362
		public int WrapText
		{
			get
			{
				global::NPOI.DDF.EscherSimpleProperty escherSimpleProperty = (global::NPOI.DDF.EscherSimpleProperty)base.GetOptRecord().Lookup(133);
				if (escherSimpleProperty != null)
				{
					return escherSimpleProperty.PropertyValue;
				}
				return 0;
			}
			set
			{
				base.SetPropertyValue(new global::NPOI.DDF.EscherSimpleProperty(133, false, false, value));
			}
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x0005D177 File Offset: 0x0005B377
		protected internal global::NPOI.HSSF.Record.TextObjectRecord GetTextObjectRecord()
		{
			return this._textObjectRecord;
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x0005D17F File Offset: 0x0005B37F
		protected virtual global::NPOI.HSSF.Record.TextObjectRecord CreateTextObjRecord()
		{
			return new global::NPOI.HSSF.Record.TextObjectRecord
			{
				HorizontalTextAlignment = global::NPOI.HSSF.Record.HorizontalTextAlignment.Center,
				VerticalTextAlignment = global::NPOI.HSSF.Record.VerticalTextAlignment.Center,
				IsTextLocked = true,
				TextOrientation = global::NPOI.HSSF.Record.TextOrientation.None,
				Str = new global::NPOI.HSSF.UserModel.HSSFRichTextString("")
			};
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x0005D1B2 File Offset: 0x0005B3B2
		// (set) Token: 0x06001E7C RID: 7804 RVA: 0x0005D1C0 File Offset: 0x0005B3C0
		public virtual global::NPOI.SS.UserModel.IRichTextString String
		{
			get
			{
				return this._textObjectRecord.Str;
			}
			set
			{
				if (this.ShapeType == 0 || this.ShapeType == 20)
				{
					throw new global::System.InvalidOperationException("Cannot set text for shape type: " + this.ShapeType.ToString());
				}
				global::NPOI.HSSF.UserModel.HSSFRichTextString hssfrichTextString = (global::NPOI.HSSF.UserModel.HSSFRichTextString)value;
				if (hssfrichTextString.NumFormattingRuns == 0)
				{
					hssfrichTextString.ApplyFont(0);
				}
				this.GetOrCreateTextObjRecord().Str = hssfrichTextString;
				if (value.String != null)
				{
					base.SetPropertyValue(new global::NPOI.DDF.EscherSimpleProperty(128, value.String.GetHashCode()));
				}
			}
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x0005D244 File Offset: 0x0005B444
		internal override global::NPOI.HSSF.UserModel.HSSFShape CloneShape()
		{
			global::NPOI.HSSF.Record.TextObjectRecord textObjectRecord = null;
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord = new global::NPOI.DDF.EscherContainerRecord();
			byte[] data = base.GetEscherContainer().Serialize();
			escherContainerRecord.FillFields(data, 0, new global::NPOI.DDF.DefaultEscherRecordFactory());
			global::NPOI.HSSF.Record.ObjRecord objRecord = (global::NPOI.HSSF.Record.ObjRecord)base.GetObjRecord().CloneViaReserialise();
			if (this.GetTextObjectRecord() != null && this.String != null && this.String.String != null)
			{
				textObjectRecord = (global::NPOI.HSSF.Record.TextObjectRecord)this.GetTextObjectRecord().CloneViaReserialise();
			}
			return new global::NPOI.HSSF.UserModel.HSSFSimpleShape(escherContainerRecord, objRecord, textObjectRecord);
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x0005D2B8 File Offset: 0x0005B4B8
		internal override void AfterInsert(global::NPOI.HSSF.UserModel.HSSFPatriarch patriarch)
		{
			global::NPOI.HSSF.Record.EscherAggregate boundAggregate = patriarch.GetBoundAggregate();
			boundAggregate.AssociateShapeToObjRecord(base.GetEscherContainer().GetChildById(-4079), base.GetObjRecord());
			if (this.GetTextObjectRecord() != null)
			{
				boundAggregate.AssociateShapeToObjRecord(base.GetEscherContainer().GetChildById(-4083), this.GetTextObjectRecord());
			}
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x0005D30C File Offset: 0x0005B50C
		internal override void AfterRemove(global::NPOI.HSSF.UserModel.HSSFPatriarch patriarch)
		{
			patriarch.GetBoundAggregate().RemoveShapeToObjRecord(base.GetEscherContainer().GetChildById(-4079));
			if (base.GetEscherContainer().GetChildById(-4083) != null)
			{
				patriarch.GetBoundAggregate().RemoveShapeToObjRecord(base.GetEscherContainer().GetChildById(-4083));
			}
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x0005D364 File Offset: 0x0005B564
		protected override global::NPOI.DDF.EscherContainerRecord CreateSpContainer()
		{
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord = new global::NPOI.DDF.EscherContainerRecord();
			escherContainerRecord.RecordId = -4092;
			escherContainerRecord.Options = 15;
			global::NPOI.DDF.EscherSpRecord escherSpRecord = new global::NPOI.DDF.EscherSpRecord();
			escherSpRecord.RecordId = -4086;
			escherSpRecord.Flags = 2560;
			escherSpRecord.Version = 2;
			global::NPOI.DDF.EscherClientDataRecord escherClientDataRecord = new global::NPOI.DDF.EscherClientDataRecord();
			escherClientDataRecord.RecordId = -4079;
			escherClientDataRecord.Options = 0;
			global::NPOI.DDF.EscherOptRecord escherOptRecord = new global::NPOI.DDF.EscherOptRecord();
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(462, 0));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherBoolProperty(511, 524296));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherRGBProperty(385, 134217737));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherRGBProperty(448, 134217792));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherBoolProperty(447, 65536));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherBoolProperty(511, 524296));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherShapePathProperty(324, 4));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherBoolProperty(959, 524288));
			escherOptRecord.RecordId = -4085;
			global::NPOI.DDF.EscherTextboxRecord escherTextboxRecord = new global::NPOI.DDF.EscherTextboxRecord();
			escherTextboxRecord.RecordId = -4083;
			escherTextboxRecord.Options = 0;
			escherContainerRecord.AddChildRecord(escherSpRecord);
			escherContainerRecord.AddChildRecord(escherOptRecord);
			escherContainerRecord.AddChildRecord(base.Anchor.GetEscherAnchor());
			escherContainerRecord.AddChildRecord(escherClientDataRecord);
			escherContainerRecord.AddChildRecord(escherTextboxRecord);
			return escherContainerRecord;
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x0005D4BC File Offset: 0x0005B6BC
		protected override global::NPOI.HSSF.Record.ObjRecord CreateObjRecord()
		{
			global::NPOI.HSSF.Record.ObjRecord objRecord = new global::NPOI.HSSF.Record.ObjRecord();
			global::NPOI.HSSF.Record.CommonObjectDataSubRecord commonObjectDataSubRecord = new global::NPOI.HSSF.Record.CommonObjectDataSubRecord();
			commonObjectDataSubRecord.IsLocked = true;
			commonObjectDataSubRecord.IsPrintable = true;
			commonObjectDataSubRecord.IsAutoFill = true;
			commonObjectDataSubRecord.IsAutoline = true;
			global::NPOI.HSSF.Record.EndSubRecord o = new global::NPOI.HSSF.Record.EndSubRecord();
			objRecord.AddSubRecord(commonObjectDataSubRecord);
			objRecord.AddSubRecord(o);
			return objRecord;
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x0005D504 File Offset: 0x0005B704
		private global::NPOI.HSSF.Record.TextObjectRecord GetOrCreateTextObjRecord()
		{
			if (this.GetTextObjectRecord() == null)
			{
				this._textObjectRecord = this.CreateTextObjRecord();
			}
			if ((global::NPOI.DDF.EscherTextboxRecord)base.GetEscherContainer().GetChildById(-4083) == null)
			{
				global::NPOI.DDF.EscherTextboxRecord escherTextboxRecord = new global::NPOI.DDF.EscherTextboxRecord();
				escherTextboxRecord.RecordId = -4083;
				escherTextboxRecord.Options = 0;
				base.GetEscherContainer().AddChildRecord(escherTextboxRecord);
				base.Patriarch.GetBoundAggregate().AssociateShapeToObjRecord(escherTextboxRecord, this._textObjectRecord);
			}
			return this._textObjectRecord;
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001E83 RID: 7811 RVA: 0x0005D57F File Offset: 0x0005B77F
		// (set) Token: 0x06001E84 RID: 7812 RVA: 0x0005D587 File Offset: 0x0005B787
		public bool FlipVertical { get; set; }

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001E85 RID: 7813 RVA: 0x0005D590 File Offset: 0x0005B790
		// (set) Token: 0x06001E86 RID: 7814 RVA: 0x0005D598 File Offset: 0x0005B798
		public bool FlipHorizontal { get; set; }

		// Token: 0x04000BAC RID: 2988
		public const short OBJECT_TYPE_LINE = 20;

		// Token: 0x04000BAD RID: 2989
		public const short OBJECT_TYPE_RECTANGLE = 1;

		// Token: 0x04000BAE RID: 2990
		public const short OBJECT_TYPE_OVAL = 3;

		// Token: 0x04000BAF RID: 2991
		public const short OBJECT_TYPE_ARC = 19;

		// Token: 0x04000BB0 RID: 2992
		public const short OBJECT_TYPE_PICTURE = 75;

		// Token: 0x04000BB1 RID: 2993
		public const short OBJECT_TYPE_COMBO_BOX = 201;

		// Token: 0x04000BB2 RID: 2994
		public const short OBJECT_TYPE_COMMENT = 202;

		// Token: 0x04000BB3 RID: 2995
		public const short OBJECT_TYPE_MICROSOFT_OFFICE_DRAWING = 30;

		// Token: 0x04000BB4 RID: 2996
		public const int WRAP_SQUARE = 0;

		// Token: 0x04000BB5 RID: 2997
		public const int WRAP_BY_POINTS = 1;

		// Token: 0x04000BB6 RID: 2998
		public const int WRAP_NONE = 2;

		// Token: 0x04000BB7 RID: 2999
		private global::NPOI.HSSF.Record.TextObjectRecord _textObjectRecord;
	}
}
