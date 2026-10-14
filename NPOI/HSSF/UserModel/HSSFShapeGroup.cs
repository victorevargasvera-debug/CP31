using System;
using System.Collections;
using System.Collections.Generic;
using NPOI.DDF;
using NPOI.HSSF.Record;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200038A RID: 906
	public class HSSFShapeGroup : global::NPOI.HSSF.UserModel.HSSFShape, global::NPOI.HSSF.UserModel.HSSFShapeContainer, global::System.Collections.Generic.IEnumerable<global::NPOI.HSSF.UserModel.HSSFShape>, global::System.Collections.IEnumerable
	{
		// Token: 0x06001D7C RID: 7548 RVA: 0x000593D0 File Offset: 0x000575D0
		public HSSFShapeGroup(global::NPOI.DDF.EscherContainerRecord spgrContainer, global::NPOI.HSSF.Record.ObjRecord objRecord) : base(spgrContainer, objRecord)
		{
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord = spgrContainer.ChildContainers[0];
			this._spgrRecord = (global::NPOI.DDF.EscherSpgrRecord)escherContainerRecord.GetChild(0);
			foreach (global::NPOI.DDF.EscherRecord escherRecord in escherContainerRecord.ChildRecords)
			{
				short recordId = escherRecord.RecordId;
				if (recordId != -4087)
				{
					if (recordId != -4081)
					{
						if (recordId == -4080)
						{
							this.anchor = new global::NPOI.HSSF.UserModel.HSSFClientAnchor((global::NPOI.DDF.EscherClientAnchorRecord)escherRecord);
						}
					}
					else
					{
						this.anchor = new global::NPOI.HSSF.UserModel.HSSFChildAnchor((global::NPOI.DDF.EscherChildAnchorRecord)escherRecord);
					}
				}
			}
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x00059494 File Offset: 0x00057694
		public HSSFShapeGroup(global::NPOI.HSSF.UserModel.HSSFShape parent, global::NPOI.HSSF.UserModel.HSSFAnchor anchor) : base(parent, anchor)
		{
			this._spgrRecord = (global::NPOI.DDF.EscherSpgrRecord)((global::NPOI.DDF.EscherContainerRecord)base.GetEscherContainer().GetChild(0)).GetChildById(-4087);
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x000594D0 File Offset: 0x000576D0
		protected override global::NPOI.DDF.EscherContainerRecord CreateSpContainer()
		{
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord = new global::NPOI.DDF.EscherContainerRecord();
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord2 = new global::NPOI.DDF.EscherContainerRecord();
			global::NPOI.DDF.EscherSpgrRecord escherSpgrRecord = new global::NPOI.DDF.EscherSpgrRecord();
			global::NPOI.DDF.EscherSpRecord escherSpRecord = new global::NPOI.DDF.EscherSpRecord();
			global::NPOI.DDF.EscherOptRecord escherOptRecord = new global::NPOI.DDF.EscherOptRecord();
			global::NPOI.DDF.EscherClientDataRecord escherClientDataRecord = new global::NPOI.DDF.EscherClientDataRecord();
			escherContainerRecord.RecordId = -4093;
			escherContainerRecord.Options = 15;
			escherContainerRecord2.RecordId = -4092;
			escherContainerRecord2.Options = 15;
			escherSpgrRecord.RecordId = -4087;
			escherSpgrRecord.Options = 1;
			escherSpgrRecord.RectX1 = 0;
			escherSpgrRecord.RectY1 = 0;
			escherSpgrRecord.RectX2 = 1023;
			escherSpgrRecord.RectY2 = 255;
			escherSpRecord.RecordId = -4086;
			escherSpRecord.Options = 2;
			if (base.Anchor is global::NPOI.HSSF.UserModel.HSSFClientAnchor)
			{
				escherSpRecord.Flags = 513;
			}
			else
			{
				escherSpRecord.Flags = 515;
			}
			escherOptRecord.RecordId = -4085;
			escherOptRecord.Options = 35;
			escherOptRecord.AddEscherProperty(new global::NPOI.DDF.EscherBoolProperty(127, 262148));
			escherOptRecord.AddEscherProperty(new global::NPOI.DDF.EscherBoolProperty(959, 524288));
			global::NPOI.DDF.EscherRecord escherAnchor = base.Anchor.GetEscherAnchor();
			escherClientDataRecord.RecordId = -4079;
			escherClientDataRecord.Options = 0;
			escherContainerRecord.AddChildRecord(escherContainerRecord2);
			escherContainerRecord2.AddChildRecord(escherSpgrRecord);
			escherContainerRecord2.AddChildRecord(escherSpRecord);
			escherContainerRecord2.AddChildRecord(escherOptRecord);
			escherContainerRecord2.AddChildRecord(escherAnchor);
			escherContainerRecord2.AddChildRecord(escherClientDataRecord);
			return escherContainerRecord;
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x0005961C File Offset: 0x0005781C
		protected override global::NPOI.HSSF.Record.ObjRecord CreateObjRecord()
		{
			global::NPOI.HSSF.Record.ObjRecord objRecord = new global::NPOI.HSSF.Record.ObjRecord();
			global::NPOI.HSSF.Record.CommonObjectDataSubRecord commonObjectDataSubRecord = new global::NPOI.HSSF.Record.CommonObjectDataSubRecord();
			commonObjectDataSubRecord.ObjectType = global::NPOI.HSSF.Record.CommonObjectType.Group;
			commonObjectDataSubRecord.IsLocked = true;
			commonObjectDataSubRecord.IsPrintable = true;
			commonObjectDataSubRecord.IsAutoFill = true;
			commonObjectDataSubRecord.IsAutoline = true;
			global::NPOI.HSSF.Record.GroupMarkerSubRecord o = new global::NPOI.HSSF.Record.GroupMarkerSubRecord();
			global::NPOI.HSSF.Record.EndSubRecord o2 = new global::NPOI.HSSF.Record.EndSubRecord();
			objRecord.AddSubRecord(commonObjectDataSubRecord);
			objRecord.AddSubRecord(o);
			objRecord.AddSubRecord(o2);
			return objRecord;
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x00059678 File Offset: 0x00057878
		internal override void AfterRemove(global::NPOI.HSSF.UserModel.HSSFPatriarch patriarch)
		{
			patriarch.GetBoundAggregate().RemoveShapeToObjRecord(base.GetEscherContainer().ChildContainers[0].GetChildById(-4079));
			for (int i = 0; i < this.shapes.Count; i++)
			{
				global::NPOI.HSSF.UserModel.HSSFShape hssfshape = this.shapes[i];
				this.RemoveShape(hssfshape);
				hssfshape.AfterRemove(base.Patriarch);
			}
			this.shapes.Clear();
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x000596F0 File Offset: 0x000578F0
		private void OnCreate(global::NPOI.HSSF.UserModel.HSSFShape shape)
		{
			if (base.Patriarch != null)
			{
				global::NPOI.DDF.EscherContainerRecord escherContainer = shape.GetEscherContainer();
				int shapeId = base.Patriarch.NewShapeId();
				shape.ShapeId = shapeId;
				base.GetEscherContainer().AddChildRecord(escherContainer);
				shape.AfterInsert(base.Patriarch);
				global::NPOI.DDF.EscherSpRecord escherSpRecord;
				if (shape is global::NPOI.HSSF.UserModel.HSSFShapeGroup)
				{
					escherSpRecord = (global::NPOI.DDF.EscherSpRecord)shape.GetEscherContainer().ChildContainers[0].GetChildById(-4086);
				}
				else
				{
					escherSpRecord = (global::NPOI.DDF.EscherSpRecord)shape.GetEscherContainer().GetChildById(-4086);
				}
				escherSpRecord.Flags |= 2;
			}
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x0005978C File Offset: 0x0005798C
		public global::NPOI.HSSF.UserModel.HSSFShapeGroup CreateGroup(global::NPOI.HSSF.UserModel.HSSFChildAnchor anchor)
		{
			global::NPOI.HSSF.UserModel.HSSFShapeGroup hssfshapeGroup = new global::NPOI.HSSF.UserModel.HSSFShapeGroup(this, anchor);
			hssfshapeGroup.Parent = this;
			hssfshapeGroup.Anchor = anchor;
			this.shapes.Add(hssfshapeGroup);
			this.OnCreate(hssfshapeGroup);
			return hssfshapeGroup;
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x000597C3 File Offset: 0x000579C3
		public void AddShape(global::NPOI.HSSF.UserModel.HSSFShape shape)
		{
			shape.Patriarch = base.Patriarch;
			shape.Parent = this;
			this.shapes.Add(shape);
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x000597E4 File Offset: 0x000579E4
		public global::NPOI.HSSF.UserModel.HSSFSimpleShape CreateShape(global::NPOI.HSSF.UserModel.HSSFChildAnchor anchor)
		{
			global::NPOI.HSSF.UserModel.HSSFSimpleShape hssfsimpleShape = new global::NPOI.HSSF.UserModel.HSSFSimpleShape(this, anchor);
			hssfsimpleShape.Parent = this;
			hssfsimpleShape.Anchor = anchor;
			this.shapes.Add(hssfsimpleShape);
			this.OnCreate(hssfsimpleShape);
			global::NPOI.DDF.EscherSpRecord escherSpRecord = (global::NPOI.DDF.EscherSpRecord)hssfsimpleShape.GetEscherContainer().GetChildById(-4086);
			if (hssfsimpleShape.Anchor.IsHorizontallyFlipped)
			{
				escherSpRecord.Flags |= 64;
			}
			if (hssfsimpleShape.Anchor.IsVerticallyFlipped)
			{
				escherSpRecord.Flags |= 128;
			}
			return hssfsimpleShape;
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x0005986C File Offset: 0x00057A6C
		public global::NPOI.HSSF.UserModel.HSSFTextbox CreateTextbox(global::NPOI.HSSF.UserModel.HSSFChildAnchor anchor)
		{
			global::NPOI.HSSF.UserModel.HSSFTextbox hssftextbox = new global::NPOI.HSSF.UserModel.HSSFTextbox(this, anchor);
			hssftextbox.Parent = this;
			hssftextbox.Anchor = anchor;
			this.shapes.Add(hssftextbox);
			this.OnCreate(hssftextbox);
			return hssftextbox;
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x000598A4 File Offset: 0x00057AA4
		public global::NPOI.HSSF.UserModel.HSSFPolygon CreatePolygon(global::NPOI.HSSF.UserModel.HSSFChildAnchor anchor)
		{
			global::NPOI.HSSF.UserModel.HSSFPolygon hssfpolygon = new global::NPOI.HSSF.UserModel.HSSFPolygon(this, anchor);
			hssfpolygon.Parent = this;
			hssfpolygon.Anchor = anchor;
			this.shapes.Add(hssfpolygon);
			this.OnCreate(hssfpolygon);
			return hssfpolygon;
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x000598DC File Offset: 0x00057ADC
		public global::NPOI.HSSF.UserModel.HSSFPicture CreatePicture(global::NPOI.HSSF.UserModel.HSSFChildAnchor anchor, int pictureIndex)
		{
			global::NPOI.HSSF.UserModel.HSSFPicture hssfpicture = new global::NPOI.HSSF.UserModel.HSSFPicture(this, anchor);
			hssfpicture.Parent = this;
			hssfpicture.Anchor = anchor;
			hssfpicture.PictureIndex = pictureIndex;
			this.shapes.Add(hssfpicture);
			this.OnCreate(hssfpicture);
			global::NPOI.DDF.EscherSpRecord escherSpRecord = (global::NPOI.DDF.EscherSpRecord)hssfpicture.GetEscherContainer().GetChildById(-4086);
			if (hssfpicture.Anchor.IsHorizontallyFlipped)
			{
				escherSpRecord.Flags |= 64;
			}
			if (hssfpicture.Anchor.IsVerticallyFlipped)
			{
				escherSpRecord.Flags |= 128;
			}
			return hssfpicture;
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x0005996B File Offset: 0x00057B6B
		public global::System.Collections.Generic.IList<global::NPOI.HSSF.UserModel.HSSFShape> Children
		{
			get
			{
				return this.shapes;
			}
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x00059973 File Offset: 0x00057B73
		public void SetCoordinates(int x1, int y1, int x2, int y2)
		{
			this._spgrRecord.RectX1 = x1;
			this._spgrRecord.RectX2 = x2;
			this._spgrRecord.RectY1 = y1;
			this._spgrRecord.RectY2 = y2;
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x000599A8 File Offset: 0x00057BA8
		public void Clear()
		{
			foreach (global::NPOI.HSSF.UserModel.HSSFShape shape in new global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFShape>(this.shapes))
			{
				this.RemoveShape(shape);
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x00059A04 File Offset: 0x00057C04
		public int X1
		{
			get
			{
				return this._spgrRecord.RectX1;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x00059A11 File Offset: 0x00057C11
		public int Y1
		{
			get
			{
				return this._spgrRecord.RectY1;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x00059A1E File Offset: 0x00057C1E
		public int X2
		{
			get
			{
				return this._spgrRecord.RectX2;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x00059A2B File Offset: 0x00057C2B
		public int Y2
		{
			get
			{
				return this._spgrRecord.RectY2;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x00059A38 File Offset: 0x00057C38
		public override int CountOfAllChildren
		{
			get
			{
				int num = this.shapes.Count;
				foreach (object obj in this.shapes)
				{
					global::NPOI.HSSF.UserModel.HSSFShape hssfshape = (global::NPOI.HSSF.UserModel.HSSFShape)obj;
					num += hssfshape.CountOfAllChildren;
				}
				return num;
			}
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x00059A84 File Offset: 0x00057C84
		internal override void AfterInsert(global::NPOI.HSSF.UserModel.HSSFPatriarch patriarch)
		{
			global::NPOI.HSSF.Record.EscherAggregate boundAggregate = patriarch.GetBoundAggregate();
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord = (global::NPOI.DDF.EscherContainerRecord)base.GetEscherContainer().GetChildById(-4092);
			boundAggregate.AssociateShapeToObjRecord(escherContainerRecord.GetChildById(-4079), base.GetObjRecord());
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x00059AC3 File Offset: 0x00057CC3
		// (set) Token: 0x06001D92 RID: 7570 RVA: 0x00059AF0 File Offset: 0x00057CF0
		public override int ShapeId
		{
			get
			{
				return ((global::NPOI.DDF.EscherSpRecord)((global::NPOI.DDF.EscherContainerRecord)base.GetEscherContainer().GetChildById(-4092)).GetChildById(-4086)).ShapeId;
			}
			set
			{
				((global::NPOI.DDF.EscherSpRecord)((global::NPOI.DDF.EscherContainerRecord)base.GetEscherContainer().GetChildById(-4092)).GetChildById(-4086)).ShapeId = value;
				((global::NPOI.HSSF.Record.CommonObjectDataSubRecord)base.GetObjRecord().SubRecords[0]).ObjectId = (int)((short)(value % 1024));
			}
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x00059B4A File Offset: 0x00057D4A
		internal override global::NPOI.HSSF.UserModel.HSSFShape CloneShape()
		{
			throw new global::System.NotImplementedException("Use method cloneShape(HSSFPatriarch patriarch)");
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x00059B58 File Offset: 0x00057D58
		internal global::NPOI.HSSF.UserModel.HSSFShape CloneShape(global::NPOI.HSSF.UserModel.HSSFPatriarch patriarch)
		{
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord = new global::NPOI.DDF.EscherContainerRecord();
			escherContainerRecord.RecordId = -4093;
			escherContainerRecord.Options = 15;
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord2 = new global::NPOI.DDF.EscherContainerRecord();
			byte[] data = ((global::NPOI.DDF.EscherContainerRecord)base.GetEscherContainer().GetChildById(-4092)).Serialize();
			escherContainerRecord2.FillFields(data, 0, new global::NPOI.DDF.DefaultEscherRecordFactory());
			escherContainerRecord.AddChildRecord(escherContainerRecord2);
			global::NPOI.HSSF.Record.ObjRecord objRecord = null;
			if (base.GetObjRecord() != null)
			{
				objRecord = (global::NPOI.HSSF.Record.ObjRecord)base.GetObjRecord().CloneViaReserialise();
			}
			global::NPOI.HSSF.UserModel.HSSFShapeGroup hssfshapeGroup = new global::NPOI.HSSF.UserModel.HSSFShapeGroup(escherContainerRecord, objRecord);
			hssfshapeGroup.Patriarch = patriarch;
			foreach (global::NPOI.HSSF.UserModel.HSSFShape hssfshape in this.Children)
			{
				global::NPOI.HSSF.UserModel.HSSFShape shape;
				if (hssfshape is global::NPOI.HSSF.UserModel.HSSFShapeGroup)
				{
					shape = ((global::NPOI.HSSF.UserModel.HSSFShapeGroup)hssfshape).CloneShape(patriarch);
				}
				else
				{
					shape = hssfshape.CloneShape();
				}
				hssfshapeGroup.AddShape(shape);
				hssfshapeGroup.OnCreate(shape);
			}
			return hssfshapeGroup;
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x00059C50 File Offset: 0x00057E50
		public bool RemoveShape(global::NPOI.HSSF.UserModel.HSSFShape shape)
		{
			bool flag = base.GetEscherContainer().RemoveChildRecord(shape.GetEscherContainer());
			if (flag)
			{
				shape.AfterRemove(base.Patriarch);
				this.shapes.Remove(shape);
			}
			return flag;
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00059C7F File Offset: 0x00057E7F
		public global::System.Collections.Generic.IEnumerator<global::NPOI.HSSF.UserModel.HSSFShape> GetEnumerator()
		{
			return this.shapes.GetEnumerator();
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x00059C7F File Offset: 0x00057E7F
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.shapes.GetEnumerator();
		}

		// Token: 0x04000B9E RID: 2974
		private global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFShape> shapes = new global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFShape>();

		// Token: 0x04000B9F RID: 2975
		private global::NPOI.DDF.EscherSpgrRecord _spgrRecord;
	}
}
