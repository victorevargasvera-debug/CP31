using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using NPOI.DDF;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record;
using NPOI.POIFS.FileSystem;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000380 RID: 896
	public class HSSFPatriarch : global::NPOI.HSSF.UserModel.HSSFShapeContainer, global::System.Collections.Generic.IEnumerable<global::NPOI.HSSF.UserModel.HSSFShape>, global::System.Collections.IEnumerable, global::NPOI.SS.UserModel.IDrawing
	{
		// Token: 0x06001C7D RID: 7293 RVA: 0x00056A90 File Offset: 0x00054C90
		public HSSFPatriarch(global::NPOI.HSSF.UserModel.HSSFSheet sheet, global::NPOI.HSSF.Record.EscherAggregate boundAggregate)
		{
			this._boundAggregate = boundAggregate;
			this._sheet = sheet;
			this._mainSpgrContainer = this._boundAggregate.GetEscherContainer().ChildContainers[0];
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord = (global::NPOI.DDF.EscherContainerRecord)this._boundAggregate.GetEscherContainer().ChildContainers[0].GetChild(0);
			this._spgrRecord = (global::NPOI.DDF.EscherSpgrRecord)escherContainerRecord.GetChildById(-4087);
			this.BuildShapeTree();
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x00056B18 File Offset: 0x00054D18
		public static global::NPOI.HSSF.UserModel.HSSFPatriarch CreatePatriarch(global::NPOI.HSSF.UserModel.HSSFPatriarch patriarch, global::NPOI.HSSF.UserModel.HSSFSheet sheet)
		{
			global::NPOI.HSSF.UserModel.HSSFPatriarch hssfpatriarch = new global::NPOI.HSSF.UserModel.HSSFPatriarch(sheet, new global::NPOI.HSSF.Record.EscherAggregate(true));
			hssfpatriarch.AfterCreate();
			foreach (global::NPOI.HSSF.UserModel.HSSFShape hssfshape in patriarch.Children)
			{
				global::NPOI.HSSF.UserModel.HSSFShape shape;
				if (hssfshape is global::NPOI.HSSF.UserModel.HSSFShapeGroup)
				{
					shape = ((global::NPOI.HSSF.UserModel.HSSFShapeGroup)hssfshape).CloneShape(hssfpatriarch);
				}
				else
				{
					shape = hssfshape.CloneShape();
				}
				hssfpatriarch.OnCreate(shape);
				hssfpatriarch.AddShape(shape);
			}
			return hssfpatriarch;
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x00056BA0 File Offset: 0x00054DA0
		protected internal void PreSerialize()
		{
			global::System.Collections.Generic.Dictionary<int, global::NPOI.HSSF.Record.NoteRecord> tailRecords = this._boundAggregate.TailRecords;
			global::System.Collections.Hashtable hashtable = new global::System.Collections.Hashtable(tailRecords.Count);
			foreach (global::NPOI.HSSF.Record.NoteRecord noteRecord in tailRecords.Values)
			{
				string text = new global::NPOI.SS.Util.CellReference(noteRecord.Row, noteRecord.Column).FormatAsString();
				if (hashtable.Contains(text))
				{
					throw new global::System.InvalidOperationException("found multiple cell comments for cell " + text);
				}
				hashtable.Add(text, null);
			}
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x00056C3C File Offset: 0x00054E3C
		public bool RemoveShape(global::NPOI.HSSF.UserModel.HSSFShape shape)
		{
			bool flag = this._mainSpgrContainer.RemoveChildRecord(shape.GetEscherContainer());
			if (flag)
			{
				shape.AfterRemove(this);
				this._shapes.Remove(shape);
			}
			return flag;
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x00056C68 File Offset: 0x00054E68
		internal void AfterCreate()
		{
			global::NPOI.HSSF.Model.DrawingManager2 drawingManager = ((global::NPOI.HSSF.UserModel.HSSFWorkbook)this._sheet.Workbook).Workbook.DrawingManager;
			short dgId = drawingManager.FindNewDrawingGroupId();
			this._boundAggregate.SetDgId(dgId);
			this._boundAggregate.SetMainSpRecordId(this.NewShapeId());
			drawingManager.IncrementDrawingsSaved();
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x00056CB8 File Offset: 0x00054EB8
		public global::NPOI.HSSF.UserModel.HSSFShapeGroup CreateGroup(global::NPOI.HSSF.UserModel.HSSFClientAnchor anchor)
		{
			global::NPOI.HSSF.UserModel.HSSFShapeGroup hssfshapeGroup = new global::NPOI.HSSF.UserModel.HSSFShapeGroup(null, anchor);
			this.AddShape(hssfshapeGroup);
			this.OnCreate(hssfshapeGroup);
			return hssfshapeGroup;
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x00056CDC File Offset: 0x00054EDC
		public global::NPOI.HSSF.UserModel.HSSFSimpleShape CreateSimpleShape(global::NPOI.HSSF.UserModel.HSSFClientAnchor anchor)
		{
			global::NPOI.HSSF.UserModel.HSSFSimpleShape hssfsimpleShape = new global::NPOI.HSSF.UserModel.HSSFSimpleShape(null, anchor);
			this.AddShape(hssfsimpleShape);
			this.OnCreate(hssfsimpleShape);
			return hssfsimpleShape;
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x00056D00 File Offset: 0x00054F00
		public global::NPOI.SS.UserModel.IPicture CreatePicture(global::NPOI.HSSF.UserModel.HSSFClientAnchor anchor, int pictureIndex)
		{
			global::NPOI.HSSF.UserModel.HSSFPicture hssfpicture = new global::NPOI.HSSF.UserModel.HSSFPicture(null, anchor);
			hssfpicture.PictureIndex = pictureIndex;
			this.AddShape(hssfpicture);
			this.OnCreate(hssfpicture);
			return hssfpicture;
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x00056D2B File Offset: 0x00054F2B
		public global::NPOI.SS.UserModel.IPicture CreatePicture(global::NPOI.SS.UserModel.IClientAnchor anchor, int pictureIndex)
		{
			return this.CreatePicture((global::NPOI.HSSF.UserModel.HSSFClientAnchor)anchor, pictureIndex);
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x00056D3C File Offset: 0x00054F3C
		public global::NPOI.HSSF.UserModel.HSSFObjectData CreateObjectData(global::NPOI.HSSF.UserModel.HSSFClientAnchor anchor, int storageId, int pictureIndex)
		{
			global::NPOI.HSSF.Record.ObjRecord objRecord = new global::NPOI.HSSF.Record.ObjRecord();
			objRecord.AddSubRecord(new global::NPOI.HSSF.Record.CommonObjectDataSubRecord
			{
				ObjectType = global::NPOI.HSSF.Record.CommonObjectType.Picture,
				IsLocked = true,
				IsPrintable = true,
				IsAutoFill = true,
				IsAutoline = true,
				Reserved1 = 0,
				Reserved2 = 0,
				Reserved3 = 0
			});
			global::NPOI.HSSF.Record.FtCfSubRecord ftCfSubRecord = new global::NPOI.HSSF.Record.FtCfSubRecord();
			global::NPOI.HSSF.UserModel.HSSFPictureData hssfpictureData = this.Sheet.Workbook.GetAllPictures()[pictureIndex - 1] as global::NPOI.HSSF.UserModel.HSSFPictureData;
			global::NPOI.SS.UserModel.PictureType format = (global::NPOI.SS.UserModel.PictureType)hssfpictureData.Format;
			if (format - global::NPOI.SS.UserModel.PictureType.EMF > 1)
			{
				if (format - global::NPOI.SS.UserModel.PictureType.PICT > 3)
				{
					throw new global::System.InvalidOperationException("Invalid picture type: " + hssfpictureData.Format.ToString());
				}
				ftCfSubRecord.Flags = global::NPOI.HSSF.Record.FtCfSubRecord.BITMAP_BIT;
			}
			else
			{
				ftCfSubRecord.Flags = global::NPOI.HSSF.Record.FtCfSubRecord.METAFILE_BIT;
			}
			objRecord.AddSubRecord(ftCfSubRecord);
			global::NPOI.HSSF.Record.FtPioGrbitSubRecord ftPioGrbitSubRecord = new global::NPOI.HSSF.Record.FtPioGrbitSubRecord();
			ftPioGrbitSubRecord.SetFlagByBit(global::NPOI.HSSF.Record.FtPioGrbitSubRecord.AUTO_PICT_BIT, true);
			objRecord.AddSubRecord(ftPioGrbitSubRecord);
			global::NPOI.HSSF.Record.EmbeddedObjectRefSubRecord embeddedObjectRefSubRecord = new global::NPOI.HSSF.Record.EmbeddedObjectRefSubRecord();
			global::NPOI.HSSF.Record.EmbeddedObjectRefSubRecord embeddedObjectRefSubRecord2 = embeddedObjectRefSubRecord;
			byte[] array = new byte[5];
			array[0] = 2;
			embeddedObjectRefSubRecord2.SetUnknownFormulaData(array);
			embeddedObjectRefSubRecord.OLEClassName = "Paket";
			embeddedObjectRefSubRecord.SetStorageId(storageId);
			objRecord.AddSubRecord(embeddedObjectRefSubRecord);
			objRecord.AddSubRecord(new global::NPOI.HSSF.Record.EndSubRecord());
			string name = "MBD" + global::NPOI.Util.HexDump.ToHex(storageId);
			global::NPOI.POIFS.FileSystem.DirectoryEntry root;
			try
			{
				global::NPOI.POIFS.FileSystem.DirectoryNode rootDirectory = (this._sheet.Workbook as global::NPOI.HSSF.UserModel.HSSFWorkbook).RootDirectory;
				if (rootDirectory == null)
				{
					throw new global::System.IO.FileNotFoundException();
				}
				root = (global::NPOI.POIFS.FileSystem.DirectoryEntry)rootDirectory.GetEntry(name);
			}
			catch (global::System.IO.FileNotFoundException innerException)
			{
				throw new global::System.InvalidOperationException("trying to add ole shape without actually Adding data first - use HSSFWorkbook.AddOlePackage first", innerException);
			}
			global::NPOI.DDF.EscherContainerRecord escherContainer = new global::NPOI.HSSF.UserModel.HSSFPicture(null, anchor)
			{
				PictureIndex = pictureIndex
			}.GetEscherContainer();
			(escherContainer.GetChildById(-4086) as global::NPOI.DDF.EscherSpRecord).Flags |= 16;
			global::NPOI.HSSF.UserModel.HSSFObjectData hssfobjectData = new global::NPOI.HSSF.UserModel.HSSFObjectData(escherContainer, objRecord, root);
			this.AddShape(hssfobjectData);
			this.OnCreate(hssfobjectData);
			return hssfobjectData;
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x00056F18 File Offset: 0x00055118
		public global::NPOI.HSSF.UserModel.HSSFPolygon CreatePolygon(global::NPOI.SS.UserModel.IClientAnchor anchor)
		{
			global::NPOI.HSSF.UserModel.HSSFPolygon hssfpolygon = new global::NPOI.HSSF.UserModel.HSSFPolygon(null, (global::NPOI.HSSF.UserModel.HSSFAnchor)anchor);
			this.AddShape(hssfpolygon);
			this.OnCreate(hssfpolygon);
			return hssfpolygon;
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x00056F44 File Offset: 0x00055144
		public global::NPOI.HSSF.UserModel.HSSFSimpleShape CreateTextbox(global::NPOI.SS.UserModel.IClientAnchor anchor)
		{
			global::NPOI.HSSF.UserModel.HSSFTextbox hssftextbox = new global::NPOI.HSSF.UserModel.HSSFTextbox(null, (global::NPOI.HSSF.UserModel.HSSFAnchor)anchor);
			this.AddShape(hssftextbox);
			this.OnCreate(hssftextbox);
			return hssftextbox;
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x00056F70 File Offset: 0x00055170
		public global::NPOI.HSSF.UserModel.HSSFComment CreateComment(global::NPOI.HSSF.UserModel.HSSFAnchor anchor)
		{
			global::NPOI.HSSF.UserModel.HSSFComment hssfcomment = new global::NPOI.HSSF.UserModel.HSSFComment(null, anchor);
			this.AddShape(hssfcomment);
			this.OnCreate(hssfcomment);
			return hssfcomment;
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x00056F94 File Offset: 0x00055194
		public global::NPOI.HSSF.UserModel.HSSFSimpleShape CreateComboBox(global::NPOI.HSSF.UserModel.HSSFAnchor anchor)
		{
			global::NPOI.HSSF.UserModel.HSSFCombobox hssfcombobox = new global::NPOI.HSSF.UserModel.HSSFCombobox(null, anchor);
			this.AddShape(hssfcombobox);
			this.OnCreate(hssfcombobox);
			return hssfcombobox;
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x00056FB8 File Offset: 0x000551B8
		public global::NPOI.SS.UserModel.IComment CreateCellComment(global::NPOI.SS.UserModel.IClientAnchor anchor)
		{
			return this.CreateComment((global::NPOI.HSSF.UserModel.HSSFAnchor)anchor);
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x00056FC8 File Offset: 0x000551C8
		private void SetFlipFlags(global::NPOI.HSSF.UserModel.HSSFShape shape)
		{
			global::NPOI.DDF.EscherSpRecord escherSpRecord = (global::NPOI.DDF.EscherSpRecord)shape.GetEscherContainer().GetChildById(-4086);
			if (shape.Anchor.IsHorizontallyFlipped)
			{
				escherSpRecord.Flags |= 64;
			}
			if (shape.Anchor.IsVerticallyFlipped)
			{
				escherSpRecord.Flags |= 128;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x00057026 File Offset: 0x00055226
		public global::System.Collections.Generic.IList<global::NPOI.HSSF.UserModel.HSSFShape> Children
		{
			get
			{
				return this._shapes;
			}
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x0005702E File Offset: 0x0005522E
		public void AddShape(global::NPOI.HSSF.UserModel.HSSFShape shape)
		{
			shape.Patriarch = this;
			this._shapes.Add(shape);
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x00057044 File Offset: 0x00055244
		private void OnCreate(global::NPOI.HSSF.UserModel.HSSFShape shape)
		{
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord = this._boundAggregate.GetEscherContainer().ChildContainers[0];
			global::NPOI.DDF.EscherContainerRecord escherContainer = shape.GetEscherContainer();
			int shapeId = this.NewShapeId();
			shape.ShapeId = shapeId;
			escherContainerRecord.AddChildRecord(escherContainer);
			shape.AfterInsert(this);
			this.SetFlipFlags(shape);
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001C90 RID: 7312 RVA: 0x00057090 File Offset: 0x00055290
		public int CountOfAllChildren
		{
			get
			{
				int num = this._shapes.Count;
				foreach (object obj in this._shapes)
				{
					global::NPOI.HSSF.UserModel.HSSFShape hssfshape = (global::NPOI.HSSF.UserModel.HSSFShape)obj;
					num += hssfshape.CountOfAllChildren;
				}
				return num;
			}
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x000570DA File Offset: 0x000552DA
		public void SetCoordinates(int x1, int y1, int x2, int y2)
		{
			this._spgrRecord.RectY1 = y1;
			this._spgrRecord.RectY2 = y2;
			this._spgrRecord.RectX1 = x1;
			this._spgrRecord.RectX2 = x2;
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x00057110 File Offset: 0x00055310
		public void Clear()
		{
			foreach (global::NPOI.HSSF.UserModel.HSSFShape shape in new global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFShape>(this._shapes))
			{
				this.RemoveShape(shape);
			}
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x0005716C File Offset: 0x0005536C
		internal int NewShapeId()
		{
			global::NPOI.HSSF.Model.DrawingManager2 drawingManager = ((global::NPOI.HSSF.UserModel.HSSFWorkbook)this._sheet.Workbook).Workbook.DrawingManager;
			global::NPOI.DDF.EscherDgRecord escherDgRecord = (global::NPOI.DDF.EscherDgRecord)this._boundAggregate.GetEscherContainer().GetChildById(-4088);
			short drawingGroupId = escherDgRecord.DrawingGroupId;
			return drawingManager.AllocateShapeId(drawingGroupId, escherDgRecord);
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x000571BC File Offset: 0x000553BC
		public bool ContainsChart()
		{
			global::NPOI.DDF.EscherOptRecord escherOptRecord = (global::NPOI.DDF.EscherOptRecord)this._boundAggregate.FindFirstWithId(-4085);
			if (escherOptRecord == null)
			{
				return false;
			}
			foreach (object obj in escherOptRecord.EscherProperties)
			{
				global::NPOI.DDF.EscherProperty escherProperty = (global::NPOI.DDF.EscherProperty)obj;
				if (escherProperty.PropertyNumber == 896 && escherProperty.IsComplex && global::NPOI.Util.StringUtil.GetFromUnicodeLE(((global::NPOI.DDF.EscherComplexProperty)escherProperty).ComplexData).Equals("Chart 1\0"))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x0005723F File Offset: 0x0005543F
		public int X1
		{
			get
			{
				return this._spgrRecord.RectX1;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001C96 RID: 7318 RVA: 0x0005724C File Offset: 0x0005544C
		public int Y1
		{
			get
			{
				return this._spgrRecord.RectY1;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001C97 RID: 7319 RVA: 0x00057259 File Offset: 0x00055459
		public int X2
		{
			get
			{
				return this._spgrRecord.RectX2;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x00057266 File Offset: 0x00055466
		public int Y2
		{
			get
			{
				return this._spgrRecord.RectY2;
			}
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x00057273 File Offset: 0x00055473
		internal global::NPOI.HSSF.Record.EscherAggregate GetBoundAggregate()
		{
			return this._boundAggregate;
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x0005727B File Offset: 0x0005547B
		public global::NPOI.SS.UserModel.IClientAnchor CreateAnchor(int dx1, int dy1, int dx2, int dy2, int col1, int row1, int col2, int row2)
		{
			return new global::NPOI.HSSF.UserModel.HSSFClientAnchor(dx1, dy1, dx2, dy2, (int)((short)col1), row1, (int)((short)col2), row2);
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00057291 File Offset: 0x00055491
		public global::NPOI.SS.UserModel.IChart CreateChart(global::NPOI.SS.UserModel.IClientAnchor anchor)
		{
			throw new global::NPOI.Util.RuntimeException("NotImplemented");
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x000572A0 File Offset: 0x000554A0
		public void BuildShapeTree()
		{
			global::NPOI.DDF.EscherContainerRecord escherContainer = this._boundAggregate.GetEscherContainer();
			if (escherContainer == null)
			{
				return;
			}
			global::System.Collections.Generic.IList<global::NPOI.DDF.EscherContainerRecord> childContainers = escherContainer.ChildContainers[0].ChildContainers;
			for (int i = 0; i < childContainers.Count; i++)
			{
				global::NPOI.DDF.EscherContainerRecord container = childContainers[i];
				if (i != 0)
				{
					global::NPOI.HSSF.UserModel.HSSFShapeFactory.CreateShapeTree(container, this._boundAggregate, this, ((global::NPOI.HSSF.UserModel.HSSFWorkbook)this._sheet.Workbook).RootDirectory);
				}
			}
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x00057026 File Offset: 0x00055226
		public global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFShape> GetShapes()
		{
			return this._shapes;
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0005730D File Offset: 0x0005550D
		public global::System.Collections.Generic.IEnumerator<global::NPOI.HSSF.UserModel.HSSFShape> GetEnumerator()
		{
			return this._shapes.GetEnumerator();
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0005730D File Offset: 0x0005550D
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._shapes.GetEnumerator();
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x0005731F File Offset: 0x0005551F
		protected internal global::NPOI.HSSF.UserModel.HSSFSheet Sheet
		{
			get
			{
				return this._sheet;
			}
		}

		// Token: 0x04000B66 RID: 2918
		private global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFShape> _shapes = new global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFShape>();

		// Token: 0x04000B67 RID: 2919
		private global::NPOI.HSSF.UserModel.HSSFSheet _sheet;

		// Token: 0x04000B68 RID: 2920
		private global::NPOI.DDF.EscherSpgrRecord _spgrRecord;

		// Token: 0x04000B69 RID: 2921
		private global::NPOI.DDF.EscherContainerRecord _mainSpgrContainer;

		// Token: 0x04000B6A RID: 2922
		private global::NPOI.HSSF.Record.EscherAggregate _boundAggregate;
	}
}
