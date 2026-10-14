using System;
using NPOI.DDF;
using NPOI.HSSF.Record;
using NPOI.Util;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000384 RID: 900
	public class HSSFPolygon : global::NPOI.HSSF.UserModel.HSSFSimpleShape
	{
		// Token: 0x06001CCB RID: 7371 RVA: 0x000579D4 File Offset: 0x00055BD4
		public HSSFPolygon(global::NPOI.DDF.EscherContainerRecord spContainer, global::NPOI.HSSF.Record.ObjRecord objRecord, global::NPOI.HSSF.Record.TextObjectRecord _textObjectRecord) : base(spContainer, objRecord, _textObjectRecord)
		{
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x0004D9C5 File Offset: 0x0004BBC5
		public HSSFPolygon(global::NPOI.DDF.EscherContainerRecord spContainer, global::NPOI.HSSF.Record.ObjRecord objRecord) : base(spContainer, objRecord)
		{
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x000579DF File Offset: 0x00055BDF
		public HSSFPolygon(global::NPOI.HSSF.UserModel.HSSFShape parent, global::NPOI.HSSF.UserModel.HSSFAnchor anchor) : base(parent, anchor)
		{
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x0002BE0C File Offset: 0x0002A00C
		protected override global::NPOI.HSSF.Record.TextObjectRecord CreateTextObjRecord()
		{
			return null;
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x000579EC File Offset: 0x00055BEC
		protected override global::NPOI.DDF.EscherContainerRecord CreateSpContainer()
		{
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord = new global::NPOI.DDF.EscherContainerRecord();
			global::NPOI.DDF.EscherSpRecord escherSpRecord = new global::NPOI.DDF.EscherSpRecord();
			global::NPOI.DDF.EscherOptRecord escherOptRecord = new global::NPOI.DDF.EscherOptRecord();
			global::NPOI.DDF.EscherClientDataRecord escherClientDataRecord = new global::NPOI.DDF.EscherClientDataRecord();
			escherContainerRecord.RecordId = -4092;
			escherContainerRecord.Options = 15;
			escherSpRecord.RecordId = -4086;
			escherSpRecord.Options = 2;
			if (base.Parent == null)
			{
				escherSpRecord.Flags = 2560;
			}
			else
			{
				escherSpRecord.Flags = 2562;
			}
			escherOptRecord.RecordId = -4085;
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(4, false, false, 0));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(322, false, false, 100));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(323, false, false, 100));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherShapePathProperty(324, 4));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(383, false, false, 65537));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(464, false, false, 0));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(465, false, false, 0));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(471, false, false, 0));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(462, 0));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherBoolProperty(511, 524296));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherSimpleProperty(459, 9525));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherRGBProperty(385, 134217737));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherRGBProperty(448, 134217792));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherBoolProperty(447, 1));
			escherOptRecord.SetEscherProperty(new global::NPOI.DDF.EscherBoolProperty(959, 524288));
			global::NPOI.DDF.EscherRecord escherAnchor = base.Anchor.GetEscherAnchor();
			escherClientDataRecord.RecordId = -4079;
			escherClientDataRecord.Options = 0;
			escherContainerRecord.AddChildRecord(escherSpRecord);
			escherContainerRecord.AddChildRecord(escherOptRecord);
			escherContainerRecord.AddChildRecord(escherAnchor);
			escherContainerRecord.AddChildRecord(escherClientDataRecord);
			return escherContainerRecord;
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x00057BC0 File Offset: 0x00055DC0
		protected override global::NPOI.HSSF.Record.ObjRecord CreateObjRecord()
		{
			global::NPOI.HSSF.Record.ObjRecord objRecord = new global::NPOI.HSSF.Record.ObjRecord();
			global::NPOI.HSSF.Record.CommonObjectDataSubRecord commonObjectDataSubRecord = new global::NPOI.HSSF.Record.CommonObjectDataSubRecord();
			commonObjectDataSubRecord.ObjectType = global::NPOI.HSSF.Record.CommonObjectType.MicrosoftOfficeDrawing;
			commonObjectDataSubRecord.IsLocked = true;
			commonObjectDataSubRecord.IsPrintable = true;
			commonObjectDataSubRecord.IsAutoFill = true;
			commonObjectDataSubRecord.IsAutoline = true;
			global::NPOI.HSSF.Record.EndSubRecord o = new global::NPOI.HSSF.Record.EndSubRecord();
			objRecord.AddSubRecord(commonObjectDataSubRecord);
			objRecord.AddSubRecord(o);
			return objRecord;
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x00057C10 File Offset: 0x00055E10
		internal override void AfterRemove(global::NPOI.HSSF.UserModel.HSSFPatriarch patriarch)
		{
			patriarch.GetBoundAggregate().RemoveShapeToObjRecord(base.GetEscherContainer().GetChildById(-4079));
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x00057C30 File Offset: 0x00055E30
		public int[] XPoints
		{
			get
			{
				global::NPOI.DDF.EscherArrayProperty escherArrayProperty = (global::NPOI.DDF.EscherArrayProperty)base.GetOptRecord().Lookup(325);
				if (escherArrayProperty == null)
				{
					return new int[0];
				}
				int[] array = new int[escherArrayProperty.NumberOfElementsInArray - 1];
				for (int i = 0; i < escherArrayProperty.NumberOfElementsInArray - 1; i++)
				{
					short @short = global::NPOI.Util.LittleEndian.GetShort(escherArrayProperty.GetElement(i), 0);
					array[i] = (int)@short;
				}
				return array;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001CD3 RID: 7379 RVA: 0x00057C94 File Offset: 0x00055E94
		public int[] YPoints
		{
			get
			{
				global::NPOI.DDF.EscherArrayProperty escherArrayProperty = (global::NPOI.DDF.EscherArrayProperty)base.GetOptRecord().Lookup(325);
				if (escherArrayProperty == null)
				{
					return new int[0];
				}
				int[] array = new int[escherArrayProperty.NumberOfElementsInArray - 1];
				for (int i = 0; i < escherArrayProperty.NumberOfElementsInArray - 1; i++)
				{
					short @short = global::NPOI.Util.LittleEndian.GetShort(escherArrayProperty.GetElement(i), 2);
					array[i] = (int)@short;
				}
				return array;
			}
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x00057CF8 File Offset: 0x00055EF8
		public void SetPoints(int[] xPoints, int[] yPoints)
		{
			if (xPoints.Length != yPoints.Length)
			{
				global::NPOI.HSSF.UserModel.HSSFPolygon.logger.Log(7, "xPoint.Length must be equal to yPoints.Length");
				return;
			}
			if (xPoints.Length == 0)
			{
				global::NPOI.HSSF.UserModel.HSSFPolygon.logger.Log(7, "HSSFPolygon must have at least one point");
			}
			global::NPOI.DDF.EscherArrayProperty escherArrayProperty = new global::NPOI.DDF.EscherArrayProperty(325, false, new byte[0]);
			escherArrayProperty.NumberOfElementsInArray = xPoints.Length + 1;
			escherArrayProperty.NumberOfElementsInMemory = xPoints.Length + 1;
			escherArrayProperty.SizeOfElements = -16;
			byte[] array;
			for (int i = 0; i < xPoints.Length; i++)
			{
				array = new byte[4];
				global::NPOI.Util.LittleEndian.PutShort(array, 0, (short)xPoints[i]);
				global::NPOI.Util.LittleEndian.PutShort(array, 2, (short)yPoints[i]);
				escherArrayProperty.SetElement(i, array);
			}
			int index = xPoints.Length;
			array = new byte[4];
			global::NPOI.Util.LittleEndian.PutShort(array, 0, (short)xPoints[0]);
			global::NPOI.Util.LittleEndian.PutShort(array, 2, (short)yPoints[0]);
			escherArrayProperty.SetElement(index, array);
			base.SetPropertyValue(escherArrayProperty);
			global::NPOI.DDF.EscherArrayProperty escherArrayProperty2 = new global::NPOI.DDF.EscherArrayProperty(326, false, null);
			escherArrayProperty2.SizeOfElements = 2;
			escherArrayProperty2.NumberOfElementsInArray = xPoints.Length * 2 + 4;
			escherArrayProperty2.NumberOfElementsInMemory = xPoints.Length * 2 + 4;
			escherArrayProperty2.SetElement(0, new byte[]
			{
				0,
				64
			});
			escherArrayProperty2.SetElement(1, new byte[]
			{
				0,
				172
			});
			for (int j = 0; j < xPoints.Length; j++)
			{
				global::NPOI.DDF.EscherArrayProperty escherArrayProperty3 = escherArrayProperty2;
				int index2 = 2 + j * 2;
				byte[] array2 = new byte[2];
				array2[0] = 1;
				escherArrayProperty3.SetElement(index2, array2);
				escherArrayProperty2.SetElement(3 + j * 2, new byte[]
				{
					0,
					172
				});
			}
			escherArrayProperty2.SetElement(escherArrayProperty2.NumberOfElementsInArray - 2, new byte[]
			{
				1,
				96
			});
			escherArrayProperty2.SetElement(escherArrayProperty2.NumberOfElementsInArray - 1, new byte[]
			{
				0,
				128
			});
			base.SetPropertyValue(escherArrayProperty2);
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x00057EA3 File Offset: 0x000560A3
		public void SetPolygonDrawArea(int width, int height)
		{
			base.SetPropertyValue(new global::NPOI.DDF.EscherSimpleProperty(322, width));
			base.SetPropertyValue(new global::NPOI.DDF.EscherSimpleProperty(323, height));
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x00057EC8 File Offset: 0x000560C8
		public int DrawAreaWidth
		{
			get
			{
				global::NPOI.DDF.EscherSimpleProperty escherSimpleProperty = (global::NPOI.DDF.EscherSimpleProperty)base.GetOptRecord().Lookup(322);
				if (escherSimpleProperty != null)
				{
					return escherSimpleProperty.PropertyValue;
				}
				return 100;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x00057EF8 File Offset: 0x000560F8
		public int DrawAreaHeight
		{
			get
			{
				global::NPOI.DDF.EscherSimpleProperty escherSimpleProperty = (global::NPOI.DDF.EscherSimpleProperty)base.GetOptRecord().Lookup(323);
				if (escherSimpleProperty != null)
				{
					return escherSimpleProperty.PropertyValue;
				}
				return 100;
			}
		}

		// Token: 0x04000B77 RID: 2935
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.HSSF.UserModel.HSSFPolygon));

		// Token: 0x04000B78 RID: 2936
		public new static short OBJECT_TYPE_MICROSOFT_OFFICE_DRAWING = 30;
	}
}
