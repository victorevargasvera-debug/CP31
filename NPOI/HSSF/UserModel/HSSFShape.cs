using System;
using System.IO;
using NPOI.DDF;
using NPOI.HSSF.Record;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000388 RID: 904
	[global::System.Serializable]
	public abstract class HSSFShape
	{
		// Token: 0x06001D4D RID: 7501 RVA: 0x00058D8D File Offset: 0x00056F8D
		public HSSFShape(global::NPOI.DDF.EscherContainerRecord spContainer, global::NPOI.HSSF.Record.ObjRecord objRecord)
		{
			this._escherContainer = spContainer;
			this._objRecord = objRecord;
			this._optRecord = (global::NPOI.DDF.EscherOptRecord)spContainer.GetChildById(-4085);
			this.anchor = global::NPOI.HSSF.UserModel.HSSFAnchor.CreateAnchorFromEscher(spContainer);
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x00058DC8 File Offset: 0x00056FC8
		public HSSFShape(global::NPOI.HSSF.UserModel.HSSFShape parent, global::NPOI.HSSF.UserModel.HSSFAnchor anchor)
		{
			this.parent = parent;
			this.anchor = anchor;
			this._escherContainer = this.CreateSpContainer();
			this._optRecord = (global::NPOI.DDF.EscherOptRecord)this._escherContainer.GetChildById(-4085);
			this._objRecord = this.CreateObjRecord();
		}

		// Token: 0x06001D4F RID: 7503
		protected abstract global::NPOI.DDF.EscherContainerRecord CreateSpContainer();

		// Token: 0x06001D50 RID: 7504
		protected abstract global::NPOI.HSSF.Record.ObjRecord CreateObjRecord();

		// Token: 0x06001D51 RID: 7505
		internal abstract void AfterRemove(global::NPOI.HSSF.UserModel.HSSFPatriarch patriarch);

		// Token: 0x06001D52 RID: 7506
		internal abstract void AfterInsert(global::NPOI.HSSF.UserModel.HSSFPatriarch patriarch);

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x00058E1C File Offset: 0x0005701C
		// (set) Token: 0x06001D54 RID: 7508 RVA: 0x00058E38 File Offset: 0x00057038
		public virtual int ShapeId
		{
			get
			{
				return ((global::NPOI.DDF.EscherSpRecord)this._escherContainer.GetChildById(-4086)).ShapeId;
			}
			set
			{
				((global::NPOI.DDF.EscherSpRecord)this._escherContainer.GetChildById(-4086)).ShapeId = value;
				((global::NPOI.HSSF.Record.CommonObjectDataSubRecord)this._objRecord.SubRecords[0]).ObjectId = (int)((short)(value % 1024));
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x00058E78 File Offset: 0x00057078
		// (set) Token: 0x06001D56 RID: 7510 RVA: 0x00058E80 File Offset: 0x00057080
		public global::NPOI.HSSF.UserModel.HSSFShape Parent
		{
			get
			{
				return this.parent;
			}
			set
			{
				this.parent = value;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001D57 RID: 7511 RVA: 0x00058E89 File Offset: 0x00057089
		// (set) Token: 0x06001D58 RID: 7512 RVA: 0x00058E94 File Offset: 0x00057094
		public global::NPOI.HSSF.UserModel.HSSFAnchor Anchor
		{
			get
			{
				return this.anchor;
			}
			set
			{
				int num = -1;
				if (this.parent == null)
				{
					if (value is global::NPOI.HSSF.UserModel.HSSFChildAnchor)
					{
						throw new global::System.ArgumentException("Must use client anchors for shapes directly attached to sheet.");
					}
					global::NPOI.DDF.EscherClientAnchorRecord escherClientAnchorRecord = (global::NPOI.DDF.EscherClientAnchorRecord)this._escherContainer.GetChildById(-4080);
					if (escherClientAnchorRecord != null)
					{
						for (int i = 0; i < this._escherContainer.ChildRecords.Count; i++)
						{
							if (this._escherContainer.GetChild(i).RecordId == -4080 && i != this._escherContainer.ChildRecords.Count - 1)
							{
								num = (int)this._escherContainer.GetChild(i + 1).RecordId;
							}
						}
						this._escherContainer.RemoveChildRecord(escherClientAnchorRecord);
					}
				}
				else
				{
					if (value is global::NPOI.HSSF.UserModel.HSSFClientAnchor)
					{
						throw new global::System.ArgumentException("Must use child anchors for shapes attached to Groups.");
					}
					global::NPOI.DDF.EscherChildAnchorRecord escherChildAnchorRecord = (global::NPOI.DDF.EscherChildAnchorRecord)this._escherContainer.GetChildById(-4081);
					if (escherChildAnchorRecord != null)
					{
						for (int i = 0; i < this._escherContainer.ChildRecords.Count; i++)
						{
							if (this._escherContainer.GetChild(i).RecordId == -4081 && i != this._escherContainer.ChildRecords.Count - 1)
							{
								num = (int)this._escherContainer.GetChild(i + 1).RecordId;
							}
						}
						this._escherContainer.RemoveChildRecord(escherChildAnchorRecord);
					}
				}
				if (-1 == num)
				{
					this._escherContainer.AddChildRecord(value.GetEscherAnchor());
				}
				else
				{
					this._escherContainer.AddChildBefore(value.GetEscherAnchor(), num);
				}
				this.anchor = value;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x00059014 File Offset: 0x00057214
		// (set) Token: 0x06001D5A RID: 7514 RVA: 0x00059046 File Offset: 0x00057246
		public int LineStyleColor
		{
			get
			{
				global::NPOI.DDF.EscherRGBProperty escherRGBProperty = (global::NPOI.DDF.EscherRGBProperty)this._optRecord.Lookup(448);
				if (escherRGBProperty != null)
				{
					return escherRGBProperty.RgbColor;
				}
				return 134217792;
			}
			set
			{
				this.SetPropertyValue(new global::NPOI.DDF.EscherRGBProperty(448, value));
			}
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x00059059 File Offset: 0x00057259
		internal global::NPOI.DDF.EscherContainerRecord GetEscherContainer()
		{
			return this._escherContainer;
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x00059064 File Offset: 0x00057264
		public void SetLineStyleColor(int red, int green, int blue)
		{
			int rgbColor = blue << 16 | green << 8 | red;
			this.SetPropertyValue(new global::NPOI.DDF.EscherRGBProperty(448, rgbColor));
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x0005908D File Offset: 0x0005728D
		protected void SetPropertyValue(global::NPOI.DDF.EscherProperty property)
		{
			this._optRecord.SetEscherProperty(property);
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x0005909C File Offset: 0x0005729C
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x000590CE File Offset: 0x000572CE
		public int FillColor
		{
			get
			{
				global::NPOI.DDF.EscherRGBProperty escherRGBProperty = (global::NPOI.DDF.EscherRGBProperty)this._optRecord.Lookup(385);
				if (escherRGBProperty != null)
				{
					return escherRGBProperty.RgbColor;
				}
				return 134217737;
			}
			set
			{
				this.SetPropertyValue(new global::NPOI.DDF.EscherRGBProperty(385, value));
			}
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x000590E4 File Offset: 0x000572E4
		public void SetFillColor(int red, int green, int blue)
		{
			int rgbColor = blue << 16 | green << 8 | red;
			this.SetPropertyValue(new global::NPOI.DDF.EscherRGBProperty(385, rgbColor));
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001D61 RID: 7521 RVA: 0x00059110 File Offset: 0x00057310
		// (set) Token: 0x06001D62 RID: 7522 RVA: 0x00059142 File Offset: 0x00057342
		public int LineWidth
		{
			get
			{
				global::NPOI.DDF.EscherSimpleProperty escherSimpleProperty = (global::NPOI.DDF.EscherSimpleProperty)this._optRecord.Lookup(459);
				if (escherSimpleProperty != null)
				{
					return escherSimpleProperty.PropertyValue;
				}
				return 9525;
			}
			set
			{
				this.SetPropertyValue(new global::NPOI.DDF.EscherSimpleProperty(459, value));
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001D63 RID: 7523 RVA: 0x00059158 File Offset: 0x00057358
		// (set) Token: 0x06001D64 RID: 7524 RVA: 0x00059188 File Offset: 0x00057388
		public global::NPOI.SS.UserModel.LineStyle LineStyle
		{
			get
			{
				global::NPOI.DDF.EscherSimpleProperty escherSimpleProperty = (global::NPOI.DDF.EscherSimpleProperty)this._optRecord.Lookup(462);
				if (escherSimpleProperty == null)
				{
					return global::NPOI.SS.UserModel.LineStyle.None;
				}
				return (global::NPOI.SS.UserModel.LineStyle)escherSimpleProperty.PropertyValue;
			}
			set
			{
				this.SetPropertyValue(new global::NPOI.DDF.EscherSimpleProperty(462, (int)value));
				if (this.LineStyle != global::NPOI.SS.UserModel.LineStyle.Solid)
				{
					this.SetPropertyValue(new global::NPOI.DDF.EscherSimpleProperty(471, 0));
					if (this.LineStyle == global::NPOI.SS.UserModel.LineStyle.None)
					{
						this.SetPropertyValue(new global::NPOI.DDF.EscherBoolProperty(511, 524288));
						return;
					}
					this.SetPropertyValue(new global::NPOI.DDF.EscherBoolProperty(511, 524296));
				}
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x000591F4 File Offset: 0x000573F4
		// (set) Token: 0x06001D66 RID: 7526 RVA: 0x00059229 File Offset: 0x00057429
		public bool IsNoFill
		{
			get
			{
				global::NPOI.DDF.EscherBoolProperty escherBoolProperty = (global::NPOI.DDF.EscherBoolProperty)this._optRecord.Lookup(447);
				return escherBoolProperty == null || escherBoolProperty.PropertyValue == 1114112;
			}
			set
			{
				this.SetPropertyValue(new global::NPOI.DDF.EscherBoolProperty(447, value ? 1114112 : 65536));
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x0005924A File Offset: 0x0005744A
		// (set) Token: 0x06001D68 RID: 7528 RVA: 0x00059270 File Offset: 0x00057470
		public bool IsFlipVertical
		{
			get
			{
				return (((global::NPOI.DDF.EscherSpRecord)this.GetEscherContainer().GetChildById(-4086)).Flags & 128) != 0;
			}
			set
			{
				global::NPOI.DDF.EscherSpRecord escherSpRecord = (global::NPOI.DDF.EscherSpRecord)this.GetEscherContainer().GetChildById(-4086);
				if (value)
				{
					escherSpRecord.Flags |= 128;
					return;
				}
				escherSpRecord.Flags &= 2147483519;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x000592BB File Offset: 0x000574BB
		// (set) Token: 0x06001D6A RID: 7530 RVA: 0x000592E0 File Offset: 0x000574E0
		public bool IsFlipHorizontal
		{
			get
			{
				return (((global::NPOI.DDF.EscherSpRecord)this.GetEscherContainer().GetChildById(-4086)).Flags & 64) != 0;
			}
			set
			{
				global::NPOI.DDF.EscherSpRecord escherSpRecord = (global::NPOI.DDF.EscherSpRecord)this.GetEscherContainer().GetChildById(-4086);
				if (value)
				{
					escherSpRecord.Flags |= 64;
					return;
				}
				escherSpRecord.Flags &= 2147483583;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x00059328 File Offset: 0x00057528
		// (set) Token: 0x06001D6C RID: 7532 RVA: 0x0005939C File Offset: 0x0005759C
		public int RotationDegree
		{
			get
			{
				int result;
				using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
				{
					global::NPOI.DDF.EscherSimpleProperty escherSimpleProperty = (global::NPOI.DDF.EscherSimpleProperty)this.GetOptRecord().Lookup(4);
					if (escherSimpleProperty == null)
					{
						result = 0;
					}
					else
					{
						try
						{
							global::NPOI.Util.LittleEndian.PutInt(escherSimpleProperty.PropertyValue, memoryStream);
							result = (int)global::NPOI.Util.LittleEndian.GetShort(memoryStream.ToArray(), 2);
						}
						catch (global::System.IO.IOException)
						{
							result = 0;
						}
					}
				}
				return result;
			}
			set
			{
				this.SetPropertyValue(new global::NPOI.DDF.EscherSimpleProperty(4, value << 16));
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x00008875 File Offset: 0x00006A75
		public virtual int CountOfAllChildren
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06001D6E RID: 7534
		internal abstract global::NPOI.HSSF.UserModel.HSSFShape CloneShape();

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x000593AE File Offset: 0x000575AE
		// (set) Token: 0x06001D70 RID: 7536 RVA: 0x000593B6 File Offset: 0x000575B6
		public global::NPOI.HSSF.UserModel.HSSFPatriarch Patriarch
		{
			get
			{
				return this._patriarch;
			}
			set
			{
				this._patriarch = value;
			}
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x000593BF File Offset: 0x000575BF
		protected internal global::NPOI.HSSF.Record.ObjRecord GetObjRecord()
		{
			return this._objRecord;
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x000593C7 File Offset: 0x000575C7
		protected internal global::NPOI.DDF.EscherOptRecord GetOptRecord()
		{
			return this._optRecord;
		}

		// Token: 0x04000B84 RID: 2948
		public const int LINEWIDTH_ONE_PT = 12700;

		// Token: 0x04000B85 RID: 2949
		public const int LINEWIDTH_DEFAULT = 9525;

		// Token: 0x04000B86 RID: 2950
		public const int LINESTYLE__COLOR_DEFAULT = 134217792;

		// Token: 0x04000B87 RID: 2951
		public const int FILL__FILLCOLOR_DEFAULT = 134217737;

		// Token: 0x04000B88 RID: 2952
		public const bool NO_FILL_DEFAULT = true;

		// Token: 0x04000B89 RID: 2953
		public const int LINESTYLE_SOLID = 0;

		// Token: 0x04000B8A RID: 2954
		public const int LINESTYLE_DASHSYS = 1;

		// Token: 0x04000B8B RID: 2955
		public const int LINESTYLE_DOTSYS = 2;

		// Token: 0x04000B8C RID: 2956
		public const int LINESTYLE_DASHDOTSYS = 3;

		// Token: 0x04000B8D RID: 2957
		public const int LINESTYLE_DASHDOTDOTSYS = 4;

		// Token: 0x04000B8E RID: 2958
		public const int LINESTYLE_DOTGEL = 5;

		// Token: 0x04000B8F RID: 2959
		public const int LINESTYLE_DASHGEL = 6;

		// Token: 0x04000B90 RID: 2960
		public const int LINESTYLE_LONGDASHGEL = 7;

		// Token: 0x04000B91 RID: 2961
		public const int LINESTYLE_DASHDOTGEL = 8;

		// Token: 0x04000B92 RID: 2962
		public const int LINESTYLE_LONGDASHDOTGEL = 9;

		// Token: 0x04000B93 RID: 2963
		public const int LINESTYLE_LONGDASHDOTDOTGEL = 10;

		// Token: 0x04000B94 RID: 2964
		public const int LINESTYLE_NONE = -1;

		// Token: 0x04000B95 RID: 2965
		public const int LINESTYLE_DEFAULT = -1;

		// Token: 0x04000B96 RID: 2966
		public const int NO_FILLHITTEST_TRUE = 1114112;

		// Token: 0x04000B97 RID: 2967
		public const int NO_FILLHITTEST_FALSE = 65536;

		// Token: 0x04000B98 RID: 2968
		private global::NPOI.HSSF.UserModel.HSSFShape parent;

		// Token: 0x04000B99 RID: 2969
		[global::System.NonSerialized]
		protected global::NPOI.HSSF.UserModel.HSSFAnchor anchor;

		// Token: 0x04000B9A RID: 2970
		[global::System.NonSerialized]
		protected internal global::NPOI.HSSF.UserModel.HSSFPatriarch _patriarch;

		// Token: 0x04000B9B RID: 2971
		private global::NPOI.DDF.EscherContainerRecord _escherContainer;

		// Token: 0x04000B9C RID: 2972
		private global::NPOI.HSSF.Record.ObjRecord _objRecord;

		// Token: 0x04000B9D RID: 2973
		private global::NPOI.DDF.EscherOptRecord _optRecord;
	}
}
