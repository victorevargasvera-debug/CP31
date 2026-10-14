using System;
using System.Drawing;
using System.IO;
using NPOI.DDF;
using NPOI.HSSF.Record;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000382 RID: 898
	public class HSSFPicture : global::NPOI.HSSF.UserModel.HSSFSimpleShape, global::NPOI.SS.UserModel.IPicture
	{
		// Token: 0x06001CAD RID: 7341 RVA: 0x0004D9C5 File Offset: 0x0004BBC5
		public HSSFPicture(global::NPOI.DDF.EscherContainerRecord spContainer, global::NPOI.HSSF.Record.ObjRecord objRecord) : base(spContainer, objRecord)
		{
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x00057459 File Offset: 0x00055659
		public HSSFPicture(global::NPOI.HSSF.UserModel.HSSFShape parent, global::NPOI.HSSF.UserModel.HSSFAnchor anchor) : base(parent, anchor)
		{
			base.ShapeType = 75;
			((global::NPOI.HSSF.Record.CommonObjectDataSubRecord)base.GetObjRecord().SubRecords[0]).ObjectType = global::NPOI.HSSF.Record.CommonObjectType.Picture;
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x00057487 File Offset: 0x00055687
		protected override global::NPOI.DDF.EscherContainerRecord CreateSpContainer()
		{
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord = base.CreateSpContainer();
			global::NPOI.DDF.EscherOptRecord escherOptRecord = (global::NPOI.DDF.EscherOptRecord)escherContainerRecord.GetChildById(-4085);
			escherOptRecord.RemoveEscherProperty(462);
			escherOptRecord.RemoveEscherProperty(511);
			escherContainerRecord.RemoveChildRecord(escherContainerRecord.GetChildById(-4083));
			return escherContainerRecord;
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x000574C6 File Offset: 0x000556C6
		public void Resize()
		{
			this.Resize(double.MaxValue);
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x000574D7 File Offset: 0x000556D7
		public void Resize(double scale)
		{
			this.Resize(scale, scale);
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x000574E4 File Offset: 0x000556E4
		public void Resize(double scaleX, double scaleY)
		{
			global::NPOI.HSSF.UserModel.HSSFClientAnchor hssfclientAnchor = (global::NPOI.HSSF.UserModel.HSSFClientAnchor)this.ClientAnchor;
			hssfclientAnchor.AnchorType = global::NPOI.SS.UserModel.AnchorType.MoveDontResize;
			global::NPOI.HSSF.UserModel.HSSFClientAnchor hssfclientAnchor2 = this.GetPreferredSize(scaleX, scaleY) as global::NPOI.HSSF.UserModel.HSSFClientAnchor;
			int row = hssfclientAnchor.Row1 + (hssfclientAnchor2.Row2 - hssfclientAnchor2.Row1);
			int num = hssfclientAnchor.Col1 + (hssfclientAnchor2.Col2 - hssfclientAnchor2.Col1);
			hssfclientAnchor.Col2 = (int)((short)num);
			hssfclientAnchor.Dx2 = hssfclientAnchor2.Dx2;
			hssfclientAnchor.Row2 = row;
			hssfclientAnchor.Dy2 = hssfclientAnchor2.Dy2;
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001CB3 RID: 7347 RVA: 0x00057564 File Offset: 0x00055764
		// (set) Token: 0x06001CB4 RID: 7348 RVA: 0x00057592 File Offset: 0x00055792
		public int PictureIndex
		{
			get
			{
				global::NPOI.DDF.EscherSimpleProperty escherSimpleProperty = (global::NPOI.DDF.EscherSimpleProperty)base.GetOptRecord().Lookup(260);
				if (escherSimpleProperty == null)
				{
					return -1;
				}
				return escherSimpleProperty.PropertyValue;
			}
			set
			{
				base.SetPropertyValue(new global::NPOI.DDF.EscherSimpleProperty(260, false, true, value));
			}
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x000575A7 File Offset: 0x000557A7
		public global::NPOI.SS.UserModel.IClientAnchor GetPreferredSize(double scale)
		{
			return this.GetPreferredSize(scale, scale);
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x000575B1 File Offset: 0x000557B1
		public global::NPOI.SS.UserModel.IClientAnchor GetPreferredSize(double scaleX, double scaleY)
		{
			global::NPOI.SS.Util.ImageUtils.SetPreferredSize(this, scaleX, scaleY);
			return this.ClientAnchor;
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x000575C2 File Offset: 0x000557C2
		public global::NPOI.SS.UserModel.IClientAnchor GetPreferredSize()
		{
			return this.GetPreferredSize(1.0);
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x000575D3 File Offset: 0x000557D3
		protected global::System.Drawing.Size GetResolution(global::System.Drawing.Image r)
		{
			return new global::System.Drawing.Size((int)r.HorizontalResolution, (int)r.VerticalResolution);
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x000575E8 File Offset: 0x000557E8
		public global::System.Drawing.Size GetImageDimension()
		{
			global::System.Drawing.Size size;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream((this._patriarch.Sheet.Workbook as global::NPOI.HSSF.UserModel.HSSFWorkbook).Workbook.GetBSERecord(this.PictureIndex).BlipRecord.PictureData))
			{
				using (global::System.Drawing.Image image = global::System.Drawing.Image.FromStream(memoryStream))
				{
					size = image.Size;
				}
			}
			return size;
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x0005766C File Offset: 0x0005586C
		public global::NPOI.SS.UserModel.IPictureData PictureData
		{
			get
			{
				return new global::NPOI.HSSF.UserModel.HSSFPictureData((this._patriarch.Sheet.Workbook as global::NPOI.HSSF.UserModel.HSSFWorkbook).Workbook.GetBSERecord(this.PictureIndex).BlipRecord);
			}
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x000576A0 File Offset: 0x000558A0
		internal override void AfterInsert(global::NPOI.HSSF.UserModel.HSSFPatriarch patriarch)
		{
			patriarch.GetBoundAggregate().AssociateShapeToObjRecord(base.GetEscherContainer().GetChildById(-4079), base.GetObjRecord());
			if (this.PictureIndex != -1)
			{
				(patriarch.Sheet.Workbook as global::NPOI.HSSF.UserModel.HSSFWorkbook).Workbook.GetBSERecord(this.PictureIndex).Ref++;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x00057704 File Offset: 0x00055904
		// (set) Token: 0x06001CBD RID: 7357 RVA: 0x00057744 File Offset: 0x00055944
		public string FileName
		{
			get
			{
				global::NPOI.DDF.EscherComplexProperty escherComplexProperty = (global::NPOI.DDF.EscherComplexProperty)base.GetOptRecord().Lookup(261);
				if (escherComplexProperty != null)
				{
					return this.Trim(global::NPOI.Util.StringUtil.GetFromUnicodeLE(escherComplexProperty.ComplexData));
				}
				return "";
			}
			set
			{
				byte[] toUnicodeLE = global::NPOI.Util.StringUtil.GetToUnicodeLE(value);
				global::NPOI.DDF.EscherComplexProperty propertyValue = new global::NPOI.DDF.EscherComplexProperty(261, true, toUnicodeLE);
				base.SetPropertyValue(propertyValue);
			}
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x0005776C File Offset: 0x0005596C
		private string Trim(string value)
		{
			int num = value.Length;
			int i = 0;
			char[] array = value.ToCharArray();
			while (i < num)
			{
				if (array[i] > ' ')
				{
					break;
				}
				i++;
			}
			while (i < num && array[num - 1] <= ' ')
			{
				num--;
			}
			if (i <= 0 && num >= value.Length)
			{
				return value;
			}
			return value.Substring(i, num - i);
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x0004DB6A File Offset: 0x0004BD6A
		// (set) Token: 0x06001CC0 RID: 7360 RVA: 0x0004DB72 File Offset: 0x0004BD72
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

		// Token: 0x06001CC1 RID: 7361 RVA: 0x000577C8 File Offset: 0x000559C8
		internal override global::NPOI.HSSF.UserModel.HSSFShape CloneShape()
		{
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord = new global::NPOI.DDF.EscherContainerRecord();
			byte[] data = base.GetEscherContainer().Serialize();
			escherContainerRecord.FillFields(data, 0, new global::NPOI.DDF.DefaultEscherRecordFactory());
			global::NPOI.HSSF.Record.ObjRecord objRecord = (global::NPOI.HSSF.Record.ObjRecord)base.GetObjRecord().CloneViaReserialise();
			return new global::NPOI.HSSF.UserModel.HSSFPicture(escherContainerRecord, objRecord);
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x0005780C File Offset: 0x00055A0C
		public global::NPOI.SS.UserModel.IClientAnchor ClientAnchor
		{
			get
			{
				global::NPOI.HSSF.UserModel.HSSFAnchor anchor = base.Anchor;
				if (!(anchor is global::NPOI.HSSF.UserModel.HSSFClientAnchor))
				{
					return null;
				}
				return (global::NPOI.HSSF.UserModel.HSSFClientAnchor)anchor;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x00057830 File Offset: 0x00055A30
		public global::NPOI.SS.UserModel.ISheet Sheet
		{
			get
			{
				return base.Patriarch.Sheet;
			}
		}

		// Token: 0x04000B6E RID: 2926
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.HSSF.UserModel.HSSFPicture));
	}
}
