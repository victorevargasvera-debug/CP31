using System;
using System.Collections.Generic;
using NPOI.DDF;
using NPOI.HSSF.Record;
using NPOI.POIFS.FileSystem;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000358 RID: 856
	public class HSSFShapeFactory
	{
		// Token: 0x0600197D RID: 6525 RVA: 0x0004DFF8 File Offset: 0x0004C1F8
		public static void CreateShapeTree(global::NPOI.DDF.EscherContainerRecord container, global::NPOI.HSSF.Record.EscherAggregate agg, global::NPOI.HSSF.UserModel.HSSFShapeContainer out1, global::NPOI.POIFS.FileSystem.DirectoryNode root)
		{
			if (container.RecordId == -4093)
			{
				global::NPOI.HSSF.Record.ObjRecord objRecord = null;
				global::NPOI.DDF.EscherClientDataRecord escherClientDataRecord = (global::NPOI.DDF.EscherClientDataRecord)((global::NPOI.DDF.EscherContainerRecord)container.GetChild(0)).GetChildById(-4079);
				if (escherClientDataRecord != null)
				{
					objRecord = (global::NPOI.HSSF.Record.ObjRecord)agg.GetShapeToObjMapping()[escherClientDataRecord];
				}
				global::NPOI.HSSF.UserModel.HSSFShapeGroup hssfshapeGroup = new global::NPOI.HSSF.UserModel.HSSFShapeGroup(container, objRecord);
				global::System.Collections.Generic.IList<global::NPOI.DDF.EscherContainerRecord> childContainers = container.ChildContainers;
				for (int i = 0; i < childContainers.Count; i++)
				{
					global::NPOI.DDF.EscherContainerRecord container2 = childContainers[i];
					if (i != 0)
					{
						global::NPOI.HSSF.UserModel.HSSFShapeFactory.CreateShapeTree(container2, agg, hssfshapeGroup, root);
					}
				}
				out1.AddShape(hssfshapeGroup);
				return;
			}
			if (container.RecordId == -4092)
			{
				global::System.Collections.Generic.Dictionary<global::NPOI.DDF.EscherRecord, global::NPOI.HSSF.Record.Record> shapeToObjMapping = agg.GetShapeToObjMapping();
				global::NPOI.HSSF.Record.ObjRecord objRecord2 = null;
				global::NPOI.HSSF.Record.TextObjectRecord textObjectRecord = null;
				foreach (global::NPOI.DDF.EscherRecord escherRecord in container.ChildRecords)
				{
					short recordId = escherRecord.RecordId;
					if (recordId != -4083)
					{
						if (recordId == -4079)
						{
							objRecord2 = (global::NPOI.HSSF.Record.ObjRecord)shapeToObjMapping[escherRecord];
						}
					}
					else
					{
						textObjectRecord = (global::NPOI.HSSF.Record.TextObjectRecord)shapeToObjMapping[escherRecord];
					}
				}
				if (global::NPOI.HSSF.UserModel.HSSFShapeFactory.IsEmbeddedObject(objRecord2))
				{
					global::NPOI.HSSF.UserModel.HSSFObjectData shape = new global::NPOI.HSSF.UserModel.HSSFObjectData(container, objRecord2, root);
					out1.AddShape(shape);
					return;
				}
				global::NPOI.HSSF.Record.CommonObjectType objectType = ((global::NPOI.HSSF.Record.CommonObjectDataSubRecord)objRecord2.SubRecords[0]).ObjectType;
				global::NPOI.HSSF.UserModel.HSSFShape shape2;
				if (objectType <= global::NPOI.HSSF.Record.CommonObjectType.Text)
				{
					if (objectType == global::NPOI.HSSF.Record.CommonObjectType.Line)
					{
						shape2 = new global::NPOI.HSSF.UserModel.HSSFSimpleShape(container, objRecord2);
						goto IL_24C;
					}
					if (objectType == global::NPOI.HSSF.Record.CommonObjectType.Rectangle)
					{
						shape2 = new global::NPOI.HSSF.UserModel.HSSFSimpleShape(container, objRecord2, textObjectRecord);
						goto IL_24C;
					}
					if (objectType == global::NPOI.HSSF.Record.CommonObjectType.Text)
					{
						shape2 = new global::NPOI.HSSF.UserModel.HSSFTextbox(container, objRecord2, textObjectRecord);
						goto IL_24C;
					}
				}
				else if (objectType <= global::NPOI.HSSF.Record.CommonObjectType.ComboBox)
				{
					if (objectType == global::NPOI.HSSF.Record.CommonObjectType.Picture)
					{
						shape2 = new global::NPOI.HSSF.UserModel.HSSFPicture(container, objRecord2);
						goto IL_24C;
					}
					if (objectType == global::NPOI.HSSF.Record.CommonObjectType.ComboBox)
					{
						shape2 = new global::NPOI.HSSF.UserModel.HSSFCombobox(container, objRecord2);
						goto IL_24C;
					}
				}
				else
				{
					if (objectType == global::NPOI.HSSF.Record.CommonObjectType.Comment)
					{
						shape2 = new global::NPOI.HSSF.UserModel.HSSFComment(container, objRecord2, textObjectRecord, agg.GetNoteRecordByObj(objRecord2));
						goto IL_24C;
					}
					if (objectType == global::NPOI.HSSF.Record.CommonObjectType.MicrosoftOfficeDrawing)
					{
						global::NPOI.DDF.EscherOptRecord escherOptRecord = (global::NPOI.DDF.EscherOptRecord)container.GetChildById(-4085);
						if (escherOptRecord == null)
						{
							shape2 = new global::NPOI.HSSF.UserModel.HSSFSimpleShape(container, objRecord2, textObjectRecord);
							goto IL_24C;
						}
						global::NPOI.DDF.EscherProperty escherProperty = escherOptRecord.Lookup(325);
						if (escherProperty != null)
						{
							shape2 = new global::NPOI.HSSF.UserModel.HSSFPolygon(container, objRecord2, textObjectRecord);
							goto IL_24C;
						}
						shape2 = new global::NPOI.HSSF.UserModel.HSSFSimpleShape(container, objRecord2, textObjectRecord);
						goto IL_24C;
					}
				}
				shape2 = new global::NPOI.HSSF.UserModel.HSSFSimpleShape(container, objRecord2, textObjectRecord);
				IL_24C:
				out1.AddShape(shape2);
			}
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x0004E26C File Offset: 0x0004C46C
		private static bool IsEmbeddedObject(global::NPOI.HSSF.Record.ObjRecord obj)
		{
			using (global::System.Collections.Generic.List<global::NPOI.HSSF.Record.SubRecord>.Enumerator enumerator = obj.SubRecords.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current is global::NPOI.HSSF.Record.EmbeddedObjectRefSubRecord)
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}
