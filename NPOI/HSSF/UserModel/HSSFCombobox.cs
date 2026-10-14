using System;
using NPOI.DDF;
using NPOI.HSSF.Record;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000353 RID: 851
	public class HSSFCombobox : global::NPOI.HSSF.UserModel.HSSFSimpleShape
	{
		// Token: 0x06001944 RID: 6468 RVA: 0x0004D9C5 File Offset: 0x0004BBC5
		public HSSFCombobox(global::NPOI.DDF.EscherContainerRecord spContainer, global::NPOI.HSSF.Record.ObjRecord objRecord) : base(spContainer, objRecord)
		{
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x0004D9CF File Offset: 0x0004BBCF
		public HSSFCombobox(global::NPOI.HSSF.UserModel.HSSFShape parent, global::NPOI.HSSF.UserModel.HSSFAnchor anchor) : base(parent, anchor)
		{
			base.ShapeType = 201;
			((global::NPOI.HSSF.Record.CommonObjectDataSubRecord)base.GetObjRecord().SubRecords[0]).ObjectType = global::NPOI.HSSF.Record.CommonObjectType.ComboBox;
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x0002BE0C File Offset: 0x0002A00C
		protected override global::NPOI.HSSF.Record.TextObjectRecord CreateTextObjRecord()
		{
			return null;
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x0004DA04 File Offset: 0x0004BC04
		protected override global::NPOI.DDF.EscherContainerRecord CreateSpContainer()
		{
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord = new global::NPOI.DDF.EscherContainerRecord();
			global::NPOI.DDF.EscherSpRecord escherSpRecord = new global::NPOI.DDF.EscherSpRecord();
			global::NPOI.DDF.EscherOptRecord escherOptRecord = new global::NPOI.DDF.EscherOptRecord();
			global::NPOI.DDF.EscherClientDataRecord escherClientDataRecord = new global::NPOI.DDF.EscherClientDataRecord();
			escherContainerRecord.RecordId = -4092;
			escherContainerRecord.Options = 15;
			escherSpRecord.RecordId = -4086;
			escherSpRecord.Options = 3218;
			escherSpRecord.Flags = 2560;
			escherOptRecord.RecordId = -4085;
			escherOptRecord.AddEscherProperty(new global::NPOI.DDF.EscherBoolProperty(127, 17039620));
			escherOptRecord.AddEscherProperty(new global::NPOI.DDF.EscherBoolProperty(191, 524296));
			escherOptRecord.AddEscherProperty(new global::NPOI.DDF.EscherBoolProperty(511, 524288));
			escherOptRecord.AddEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(959, 131072));
			global::NPOI.HSSF.UserModel.HSSFClientAnchor hssfclientAnchor = (global::NPOI.HSSF.UserModel.HSSFClientAnchor)base.Anchor;
			hssfclientAnchor.AnchorType = (global::NPOI.SS.UserModel.AnchorType)1;
			global::NPOI.DDF.EscherRecord escherAnchor = hssfclientAnchor.GetEscherAnchor();
			escherClientDataRecord.RecordId = -4079;
			escherClientDataRecord.Options = 0;
			escherContainerRecord.AddChildRecord(escherSpRecord);
			escherContainerRecord.AddChildRecord(escherOptRecord);
			escherContainerRecord.AddChildRecord(escherAnchor);
			escherContainerRecord.AddChildRecord(escherClientDataRecord);
			return escherContainerRecord;
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x0004DB00 File Offset: 0x0004BD00
		protected override global::NPOI.HSSF.Record.ObjRecord CreateObjRecord()
		{
			global::NPOI.HSSF.Record.ObjRecord objRecord = new global::NPOI.HSSF.Record.ObjRecord();
			global::NPOI.HSSF.Record.CommonObjectDataSubRecord commonObjectDataSubRecord = new global::NPOI.HSSF.Record.CommonObjectDataSubRecord();
			commonObjectDataSubRecord.ObjectType = global::NPOI.HSSF.Record.CommonObjectType.ComboBox;
			commonObjectDataSubRecord.IsLocked = true;
			commonObjectDataSubRecord.IsPrintable = false;
			commonObjectDataSubRecord.IsAutoFill = true;
			commonObjectDataSubRecord.IsAutoline = false;
			global::NPOI.HSSF.Record.FtCblsSubRecord o = new global::NPOI.HSSF.Record.FtCblsSubRecord();
			global::NPOI.HSSF.Record.LbsDataSubRecord o2 = global::NPOI.HSSF.Record.LbsDataSubRecord.CreateAutoFilterInstance();
			global::NPOI.HSSF.Record.EndSubRecord o3 = new global::NPOI.HSSF.Record.EndSubRecord();
			objRecord.AddSubRecord(commonObjectDataSubRecord);
			objRecord.AddSubRecord(o);
			objRecord.AddSubRecord(o2);
			objRecord.AddSubRecord(o3);
			return objRecord;
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001949 RID: 6473 RVA: 0x0004DB6A File Offset: 0x0004BD6A
		// (set) Token: 0x0600194A RID: 6474 RVA: 0x0004DB72 File Offset: 0x0004BD72
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
	}
}
