using System;
using System.IO;
using NPOI.DDF;
using NPOI.HSSF.Record;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200037D RID: 893
	public class HSSFObjectData : global::NPOI.HSSF.UserModel.HSSFPicture
	{
		// Token: 0x06001C69 RID: 7273 RVA: 0x000561D7 File Offset: 0x000543D7
		public HSSFObjectData(global::NPOI.DDF.EscherContainerRecord spContainer, global::NPOI.HSSF.Record.ObjRecord objRecord, global::NPOI.POIFS.FileSystem.DirectoryEntry _root) : base(spContainer, objRecord)
		{
			this._root = _root;
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x000561E8 File Offset: 0x000543E8
		public string OLE2ClassName
		{
			get
			{
				return this.FindObjectRecord().OLEClassName;
			}
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x000561F8 File Offset: 0x000543F8
		public global::NPOI.POIFS.FileSystem.DirectoryEntry GetDirectory()
		{
			string text = "MBD" + global::NPOI.Util.HexDump.ToHex(this.FindObjectRecord().StreamId.Value);
			global::NPOI.POIFS.FileSystem.Entry entry = this._root.GetEntry(text);
			if (entry is global::NPOI.POIFS.FileSystem.DirectoryEntry)
			{
				return (global::NPOI.POIFS.FileSystem.DirectoryEntry)entry;
			}
			throw new global::System.IO.IOException("Stream " + text + " was not an OLE2 directory");
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x00056259 File Offset: 0x00054459
		public byte[] GetObjectData()
		{
			return this.FindObjectRecord().ObjectData;
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x00056268 File Offset: 0x00054468
		public bool HasDirectoryEntry()
		{
			int? streamId = this.FindObjectRecord().StreamId;
			if (streamId != null)
			{
				int? num = streamId;
				int num2 = 0;
				return !(num.GetValueOrDefault() == num2 & num != null);
			}
			return false;
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x000562A8 File Offset: 0x000544A8
		public global::NPOI.HSSF.Record.EmbeddedObjectRefSubRecord FindObjectRecord()
		{
			foreach (object obj in base.GetObjRecord().SubRecords)
			{
				if (obj is global::NPOI.HSSF.Record.EmbeddedObjectRefSubRecord)
				{
					return (global::NPOI.HSSF.Record.EmbeddedObjectRefSubRecord)obj;
				}
			}
			throw new global::System.InvalidOperationException("Object data does not contain a reference to an embedded object OLE2 directory");
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x000562F5 File Offset: 0x000544F5
		protected override global::NPOI.DDF.EscherContainerRecord CreateSpContainer()
		{
			throw new global::System.InvalidOperationException("HSSFObjectData cannot be created from scratch");
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x000562F5 File Offset: 0x000544F5
		protected override global::NPOI.HSSF.Record.ObjRecord CreateObjRecord()
		{
			throw new global::System.InvalidOperationException("HSSFObjectData cannot be created from scratch");
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x000562F5 File Offset: 0x000544F5
		internal override void AfterRemove(global::NPOI.HSSF.UserModel.HSSFPatriarch patriarch)
		{
			throw new global::System.InvalidOperationException("HSSFObjectData cannot be created from scratch");
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x00056304 File Offset: 0x00054504
		internal override void AfterInsert(global::NPOI.HSSF.UserModel.HSSFPatriarch patriarch)
		{
			patriarch.GetBoundAggregate().AssociateShapeToObjRecord(base.GetEscherContainer().GetChildById(-4079), base.GetObjRecord());
			((global::NPOI.HSSF.UserModel.HSSFWorkbook)patriarch.Sheet.Workbook).Workbook.GetBSERecord(base.PictureIndex).Ref++;
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x00056360 File Offset: 0x00054560
		internal override global::NPOI.HSSF.UserModel.HSSFShape CloneShape()
		{
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord = new global::NPOI.DDF.EscherContainerRecord();
			byte[] data = base.GetEscherContainer().Serialize();
			escherContainerRecord.FillFields(data, 0, new global::NPOI.DDF.DefaultEscherRecordFactory());
			global::NPOI.HSSF.Record.ObjRecord objRecord = (global::NPOI.HSSF.Record.ObjRecord)base.GetObjRecord().CloneViaReserialise();
			return new global::NPOI.HSSF.UserModel.HSSFObjectData(escherContainerRecord, objRecord, this._root);
		}

		// Token: 0x04000B64 RID: 2916
		private global::NPOI.POIFS.FileSystem.DirectoryEntry _root;
	}
}
