using System;
using NPOI.DDF;
using NPOI.HSSF.Record;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200038E RID: 910
	[global::System.Serializable]
	public class HSSFTextbox : global::NPOI.HSSF.UserModel.HSSFSimpleShape
	{
		// Token: 0x06001E87 RID: 7815 RVA: 0x000579D4 File Offset: 0x00055BD4
		public HSSFTextbox(global::NPOI.DDF.EscherContainerRecord spContainer, global::NPOI.HSSF.Record.ObjRecord objRecord, global::NPOI.HSSF.Record.TextObjectRecord textObjectRecord) : base(spContainer, objRecord, textObjectRecord)
		{
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x0005D5A1 File Offset: 0x0005B7A1
		public HSSFTextbox(global::NPOI.HSSF.UserModel.HSSFShape parent, global::NPOI.HSSF.UserModel.HSSFAnchor anchor) : base(parent, anchor)
		{
			this.HorizontalAlignment = global::NPOI.HSSF.Record.HorizontalTextAlignment.Left;
			this.VerticalAlignment = global::NPOI.HSSF.Record.VerticalTextAlignment.Top;
			this.String = new global::NPOI.HSSF.UserModel.HSSFRichTextString("");
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x0005D5CC File Offset: 0x0005B7CC
		protected override global::NPOI.HSSF.Record.ObjRecord CreateObjRecord()
		{
			global::NPOI.HSSF.Record.ObjRecord objRecord = new global::NPOI.HSSF.Record.ObjRecord();
			global::NPOI.HSSF.Record.CommonObjectDataSubRecord commonObjectDataSubRecord = new global::NPOI.HSSF.Record.CommonObjectDataSubRecord();
			commonObjectDataSubRecord.ObjectType = global::NPOI.HSSF.Record.CommonObjectType.Text;
			commonObjectDataSubRecord.IsLocked = true;
			commonObjectDataSubRecord.IsPrintable = true;
			commonObjectDataSubRecord.IsAutoFill = true;
			commonObjectDataSubRecord.IsAutoline = true;
			global::NPOI.HSSF.Record.EndSubRecord o = new global::NPOI.HSSF.Record.EndSubRecord();
			objRecord.AddSubRecord(commonObjectDataSubRecord);
			objRecord.AddSubRecord(o);
			return objRecord;
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x0005D61C File Offset: 0x0005B81C
		protected override global::NPOI.DDF.EscherContainerRecord CreateSpContainer()
		{
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord = new global::NPOI.DDF.EscherContainerRecord();
			global::NPOI.DDF.EscherSpRecord escherSpRecord = new global::NPOI.DDF.EscherSpRecord();
			global::NPOI.DDF.EscherOptRecord escherOptRecord = new global::NPOI.DDF.EscherOptRecord();
			global::NPOI.DDF.EscherClientDataRecord escherClientDataRecord = new global::NPOI.DDF.EscherClientDataRecord();
			global::NPOI.DDF.EscherTextboxRecord escherTextboxRecord = new global::NPOI.DDF.EscherTextboxRecord();
			escherContainerRecord.RecordId = -4092;
			escherContainerRecord.Options = 15;
			escherSpRecord.RecordId = -4086;
			escherSpRecord.Options = 3234;
			escherSpRecord.Flags = 2560;
			escherOptRecord.RecordId = -4085;
			escherOptRecord.AddEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(128, 0));
			escherOptRecord.AddEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(133, 0));
			escherOptRecord.AddEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(135, 0));
			escherOptRecord.AddEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(959, 524288));
			escherOptRecord.AddEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(129, 0));
			escherOptRecord.AddEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(131, 0));
			escherOptRecord.AddEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(130, 0));
			escherOptRecord.AddEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(132, 0));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(462, 0));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherBoolProperty(511, 524296));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(459, 9525));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherRGBProperty(385, 134217737));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherRGBProperty(448, 134217792));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherBoolProperty(447, 65536));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherBoolProperty(959, 524288));
			global::NPOI.DDF.EscherRecord escherAnchor = base.Anchor.GetEscherAnchor();
			escherClientDataRecord.RecordId = -4079;
			escherClientDataRecord.Options = 0;
			escherTextboxRecord.RecordId = -4083;
			escherTextboxRecord.Options = 0;
			escherContainerRecord.AddChildRecord(escherSpRecord);
			escherContainerRecord.AddChildRecord(escherOptRecord);
			escherContainerRecord.AddChildRecord(escherAnchor);
			escherContainerRecord.AddChildRecord(escherClientDataRecord);
			escherContainerRecord.AddChildRecord(escherTextboxRecord);
			return escherContainerRecord;
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x0005D7F8 File Offset: 0x0005B9F8
		internal override void AfterInsert(global::NPOI.HSSF.UserModel.HSSFPatriarch patriarch)
		{
			global::NPOI.HSSF.Record.EscherAggregate boundAggregate = patriarch.GetBoundAggregate();
			boundAggregate.AssociateShapeToObjRecord(base.GetEscherContainer().GetChildById(-4079), base.GetObjRecord());
			if (base.GetTextObjectRecord() != null)
			{
				boundAggregate.AssociateShapeToObjRecord(base.GetEscherContainer().GetChildById(-4083), base.GetTextObjectRecord());
			}
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x0005D84C File Offset: 0x0005BA4C
		internal override global::NPOI.HSSF.UserModel.HSSFShape CloneShape()
		{
			global::NPOI.HSSF.Record.TextObjectRecord textObjectRecord = (base.GetTextObjectRecord() == null) ? null : ((global::NPOI.HSSF.Record.TextObjectRecord)base.GetTextObjectRecord().CloneViaReserialise());
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord = new global::NPOI.DDF.EscherContainerRecord();
			byte[] data = base.GetEscherContainer().Serialize();
			escherContainerRecord.FillFields(data, 0, new global::NPOI.DDF.DefaultEscherRecordFactory());
			global::NPOI.HSSF.Record.ObjRecord objRecord = (global::NPOI.HSSF.Record.ObjRecord)base.GetObjRecord().CloneViaReserialise();
			return new global::NPOI.HSSF.UserModel.HSSFTextbox(escherContainerRecord, objRecord, textObjectRecord);
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x0005D8AC File Offset: 0x0005BAAC
		internal override void AfterRemove(global::NPOI.HSSF.UserModel.HSSFPatriarch patriarch)
		{
			patriarch.GetBoundAggregate().RemoveShapeToObjRecord(base.GetEscherContainer().GetChildById(-4079));
			patriarch.GetBoundAggregate().RemoveShapeToObjRecord(base.GetEscherContainer().GetChildById(-4083));
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x0005D8E4 File Offset: 0x0005BAE4
		// (set) Token: 0x06001E8F RID: 7823 RVA: 0x0005D912 File Offset: 0x0005BB12
		public int MarginLeft
		{
			get
			{
				global::NPOI.DDF.EscherSimpleProperty escherSimpleProperty = (global::NPOI.DDF.EscherSimpleProperty)base.GetOptRecord().Lookup(129);
				if (escherSimpleProperty != null)
				{
					return escherSimpleProperty.PropertyValue;
				}
				return 0;
			}
			set
			{
				base.SetPropertyValue(new global::NPOI.DDF.EscherSimpleProperty(129, value));
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001E90 RID: 7824 RVA: 0x0005D928 File Offset: 0x0005BB28
		// (set) Token: 0x06001E91 RID: 7825 RVA: 0x0005D956 File Offset: 0x0005BB56
		public int MarginRight
		{
			get
			{
				global::NPOI.DDF.EscherSimpleProperty escherSimpleProperty = (global::NPOI.DDF.EscherSimpleProperty)base.GetOptRecord().Lookup(131);
				if (escherSimpleProperty != null)
				{
					return escherSimpleProperty.PropertyValue;
				}
				return 0;
			}
			set
			{
				base.SetPropertyValue(new global::NPOI.DDF.EscherSimpleProperty(131, value));
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x0005D96C File Offset: 0x0005BB6C
		// (set) Token: 0x06001E93 RID: 7827 RVA: 0x0005D99A File Offset: 0x0005BB9A
		public int MarginTop
		{
			get
			{
				global::NPOI.DDF.EscherSimpleProperty escherSimpleProperty = (global::NPOI.DDF.EscherSimpleProperty)base.GetOptRecord().Lookup(130);
				if (escherSimpleProperty != null)
				{
					return escherSimpleProperty.PropertyValue;
				}
				return 0;
			}
			set
			{
				base.SetPropertyValue(new global::NPOI.DDF.EscherSimpleProperty(130, value));
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x0005D9B0 File Offset: 0x0005BBB0
		// (set) Token: 0x06001E95 RID: 7829 RVA: 0x0005D9DE File Offset: 0x0005BBDE
		public int MarginBottom
		{
			get
			{
				global::NPOI.DDF.EscherSimpleProperty escherSimpleProperty = (global::NPOI.DDF.EscherSimpleProperty)base.GetOptRecord().Lookup(132);
				if (escherSimpleProperty != null)
				{
					return escherSimpleProperty.PropertyValue;
				}
				return 0;
			}
			set
			{
				base.SetPropertyValue(new global::NPOI.DDF.EscherSimpleProperty(132, value));
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x0005D9F1 File Offset: 0x0005BBF1
		// (set) Token: 0x06001E97 RID: 7831 RVA: 0x0005D9FE File Offset: 0x0005BBFE
		public global::NPOI.HSSF.Record.HorizontalTextAlignment HorizontalAlignment
		{
			get
			{
				return base.GetTextObjectRecord().HorizontalTextAlignment;
			}
			set
			{
				base.GetTextObjectRecord().HorizontalTextAlignment = value;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x0005DA0C File Offset: 0x0005BC0C
		// (set) Token: 0x06001E99 RID: 7833 RVA: 0x0005DA19 File Offset: 0x0005BC19
		public global::NPOI.HSSF.Record.VerticalTextAlignment VerticalAlignment
		{
			get
			{
				return base.GetTextObjectRecord().VerticalTextAlignment;
			}
			set
			{
				base.GetTextObjectRecord().VerticalTextAlignment = value;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001E9A RID: 7834 RVA: 0x0004DB6A File Offset: 0x0004BD6A
		// (set) Token: 0x06001E9B RID: 7835 RVA: 0x0004DB72 File Offset: 0x0004BD72
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

		// Token: 0x04000BBA RID: 3002
		public const short OBJECT_TYPE_TEXT = 6;
	}
}
