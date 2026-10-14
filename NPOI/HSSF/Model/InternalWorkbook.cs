using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using System.Threading;
using NPOI.DDF;
using NPOI.HSSF.Record;
using NPOI.POIFS.Crypt;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.Formula.UDF;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.Model
{
	// Token: 0x02000339 RID: 825
	[global::System.Serializable]
	public class InternalWorkbook
	{
		// Token: 0x0600180D RID: 6157 RVA: 0x00048524 File Offset: 0x00046724
		public InternalWorkbook()
		{
			this.records = new global::NPOI.HSSF.Model.WorkbookRecordList();
			this.boundsheets = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.BoundSheetRecord>();
			this.formats = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.FormatRecord>();
			this.hyperlinks = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.HyperlinkRecord>();
			this.numxfs = 0;
			this.numfonts = 0;
			this.maxformatid = -1;
			this.uses1904datewindowing = false;
			this.escherBSERecords = new global::System.Collections.Generic.List<global::NPOI.DDF.EscherBSERecord>();
			this.commentRecords = new global::System.Collections.Generic.Dictionary<string, global::NPOI.HSSF.Record.NameCommentRecord>();
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x000485A8 File Offset: 0x000467A8
		public static global::NPOI.HSSF.Model.InternalWorkbook CreateWorkbook(global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record> recs)
		{
			global::NPOI.HSSF.Model.InternalWorkbook internalWorkbook = new global::NPOI.HSSF.Model.InternalWorkbook();
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record>(recs.Count / 3);
			internalWorkbook.records.Records = list;
			int i = 0;
			while (i < recs.Count)
			{
				global::NPOI.HSSF.Record.Record record = recs[i];
				if (record.Sid == 10)
				{
					list.Add(record);
					IL_339:
					while (i < recs.Count)
					{
						global::NPOI.HSSF.Record.Record record2 = recs[i];
						if (record2.Sid == 440)
						{
							internalWorkbook.hyperlinks.Add((global::NPOI.HSSF.Record.HyperlinkRecord)record2);
						}
						i++;
					}
					if (internalWorkbook.windowOne == null)
					{
						internalWorkbook.windowOne = (global::NPOI.HSSF.Record.WindowOneRecord)global::NPOI.HSSF.Model.InternalWorkbook.CreateWindowOne();
					}
					return internalWorkbook;
				}
				short sid = record.Sid;
				if (sid <= 92)
				{
					if (sid <= 34)
					{
						if (sid <= 23)
						{
							if (sid == 18)
							{
								internalWorkbook.records.Protpos = i;
								goto IL_2F3;
							}
							if (sid != 23)
							{
								goto IL_2F3;
							}
							throw new global::System.Exception("Extern sheet is part of LinkTable");
						}
						else
						{
							if (sid == 24)
							{
								goto IL_20E;
							}
							if (sid != 34)
							{
								goto IL_2F3;
							}
							internalWorkbook.uses1904datewindowing = (((global::NPOI.HSSF.Record.DateWindow1904Record)record).Windowing == 1);
							goto IL_2F3;
						}
					}
					else if (sid <= 61)
					{
						if (sid == 49)
						{
							internalWorkbook.records.Fontpos = i;
							internalWorkbook.numfonts++;
							goto IL_2F3;
						}
						if (sid != 61)
						{
							goto IL_2F3;
						}
						internalWorkbook.windowOne = (global::NPOI.HSSF.Record.WindowOneRecord)record;
						goto IL_2F3;
					}
					else
					{
						if (sid == 64)
						{
							internalWorkbook.records.Backuppos = i;
							goto IL_2F3;
						}
						if (sid == 91)
						{
							internalWorkbook.fileShare = (global::NPOI.HSSF.Record.FileSharingRecord)record;
							goto IL_2F3;
						}
						if (sid != 92)
						{
							goto IL_2F3;
						}
						internalWorkbook.writeAccess = (global::NPOI.HSSF.Record.WriteAccessRecord)record;
						goto IL_2F3;
					}
				}
				else if (sid <= 224)
				{
					if (sid <= 134)
					{
						if (sid == 133)
						{
							internalWorkbook.boundsheets.Add((global::NPOI.HSSF.Record.BoundSheetRecord)record);
							internalWorkbook.records.Bspos = i;
							goto IL_2F3;
						}
						if (sid != 134)
						{
							goto IL_2F3;
						}
						internalWorkbook.writeProtect = (global::NPOI.HSSF.Record.WriteProtectRecord)record;
						goto IL_2F3;
					}
					else
					{
						if (sid == 146)
						{
							internalWorkbook.records.Palettepos = i;
							goto IL_2F3;
						}
						if (sid != 224)
						{
							goto IL_2F3;
						}
						internalWorkbook.records.Xfpos = i;
						internalWorkbook.numxfs++;
						goto IL_2F3;
					}
				}
				else if (sid <= 317)
				{
					if (sid == 252)
					{
						internalWorkbook.sst = (global::NPOI.HSSF.Record.SSTRecord)record;
						goto IL_2F3;
					}
					if (sid != 317)
					{
						goto IL_2F3;
					}
					internalWorkbook.records.Tabpos = i;
					goto IL_2F3;
				}
				else
				{
					if (sid == 430)
					{
						goto IL_20E;
					}
					if (sid == 1054)
					{
						internalWorkbook.formats.Add((global::NPOI.HSSF.Record.FormatRecord)record);
						internalWorkbook.maxformatid = ((internalWorkbook.maxformatid >= ((global::NPOI.HSSF.Record.FormatRecord)record).IndexCode) ? internalWorkbook.maxformatid : ((global::NPOI.HSSF.Record.FormatRecord)record).IndexCode);
						goto IL_2F3;
					}
					if (sid != 2196)
					{
						goto IL_2F3;
					}
					global::NPOI.HSSF.Record.NameCommentRecord nameCommentRecord = (global::NPOI.HSSF.Record.NameCommentRecord)record;
					internalWorkbook.commentRecords[nameCommentRecord.NameText] = nameCommentRecord;
					goto IL_2F3;
				}
				IL_2FA:
				i++;
				continue;
				IL_20E:
				internalWorkbook.linkTable = new global::NPOI.HSSF.Model.LinkTable(recs, i, internalWorkbook.records, internalWorkbook.commentRecords);
				i += internalWorkbook.linkTable.RecordCount - 1;
				goto IL_2FA;
				IL_2F3:
				list.Add(record);
				goto IL_2FA;
			}
			goto IL_339;
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x00048910 File Offset: 0x00046B10
		public global::NPOI.HSSF.Record.NameCommentRecord GetNameCommentRecord(global::NPOI.HSSF.Record.NameRecord nameRecord)
		{
			if (this.commentRecords.ContainsKey(nameRecord.NameText))
			{
				return this.commentRecords[nameRecord.NameText];
			}
			return null;
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x00048938 File Offset: 0x00046B38
		public static global::NPOI.HSSF.Model.InternalWorkbook CreateWorkbook()
		{
			global::NPOI.HSSF.Model.InternalWorkbook internalWorkbook = new global::NPOI.HSSF.Model.InternalWorkbook();
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record>(30);
			internalWorkbook.records.Records = list;
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.FormatRecord> list2 = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.FormatRecord>(8);
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateBOF());
			list.Add(new global::NPOI.HSSF.Record.InterfaceHdrRecord(1200));
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateMMS());
			list.Add(global::NPOI.HSSF.Record.InterfaceEndRecord.Instance);
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateWriteAccess());
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateCodepage());
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateDSF());
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateTabId());
			internalWorkbook.records.Tabpos = list.Count - 1;
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateFnGroupCount());
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateWindowProtect());
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateProtect());
			internalWorkbook.records.Protpos = list.Count - 1;
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreatePassword());
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateProtectionRev4());
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreatePasswordRev4());
			internalWorkbook.windowOne = (global::NPOI.HSSF.Record.WindowOneRecord)global::NPOI.HSSF.Model.InternalWorkbook.CreateWindowOne();
			list.Add(internalWorkbook.windowOne);
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateBackup());
			internalWorkbook.records.Backuppos = list.Count - 1;
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateHideObj());
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateDateWindow1904());
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreatePrecision());
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateRefreshAll());
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateBookBool());
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateFont());
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateFont());
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateFont());
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateFont());
			internalWorkbook.records.Fontpos = list.Count - 1;
			internalWorkbook.numfonts = 4;
			for (int i = 0; i <= 7; i++)
			{
				global::NPOI.HSSF.Record.Record record = global::NPOI.HSSF.Model.InternalWorkbook.CreateFormat(i);
				internalWorkbook.maxformatid = ((internalWorkbook.maxformatid >= ((global::NPOI.HSSF.Record.FormatRecord)record).IndexCode) ? internalWorkbook.maxformatid : ((global::NPOI.HSSF.Record.FormatRecord)record).IndexCode);
				list2.Add((global::NPOI.HSSF.Record.FormatRecord)record);
				list.Add(record);
			}
			internalWorkbook.formats = list2;
			for (int j = 0; j < 21; j++)
			{
				list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateExtendedFormat(j));
				internalWorkbook.numxfs++;
			}
			internalWorkbook.records.Xfpos = list.Count - 1;
			for (int k = 0; k < 6; k++)
			{
				list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateStyle(k));
			}
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateUseSelFS());
			int num = 1;
			for (int l = 0; l < num; l++)
			{
				global::NPOI.HSSF.Record.BoundSheetRecord item = (global::NPOI.HSSF.Record.BoundSheetRecord)global::NPOI.HSSF.Model.InternalWorkbook.CreateBoundSheet(l);
				list.Add(item);
				internalWorkbook.boundsheets.Add(item);
				internalWorkbook.records.Bspos = list.Count - 1;
			}
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateCountry());
			for (int m = 0; m < num; m++)
			{
				internalWorkbook.OrCreateLinkTable.CheckExternSheet(m);
			}
			internalWorkbook.sst = new global::NPOI.HSSF.Record.SSTRecord();
			list.Add(internalWorkbook.sst);
			list.Add(global::NPOI.HSSF.Model.InternalWorkbook.CreateExtendedSST());
			list.Add(global::NPOI.HSSF.Record.EOFRecord.instance);
			return internalWorkbook;
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x00048C4B File Offset: 0x00046E4B
		public global::NPOI.HSSF.Record.NameRecord GetSpecificBuiltinRecord(byte name, int sheetIndex)
		{
			return this.OrCreateLinkTable.GetSpecificBuiltinRecord(name, sheetIndex);
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x00048C5C File Offset: 0x00046E5C
		public global::NPOI.SS.Formula.ExternalName GetExternalName(int externSheetIndex, int externNameIndex)
		{
			string text = this.linkTable.ResolveNameXText(externSheetIndex, externNameIndex, this);
			if (text == null)
			{
				return null;
			}
			int ix = this.linkTable.ResolveNameXIx(externSheetIndex, externNameIndex);
			return new global::NPOI.SS.Formula.ExternalName(text, externNameIndex, ix);
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x00048C93 File Offset: 0x00046E93
		public void RemoveBuiltinRecord(byte name, int sheetIndex)
		{
			this.linkTable.RemoveBuiltinRecord(name, sheetIndex);
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001814 RID: 6164 RVA: 0x00048CA2 File Offset: 0x00046EA2
		public int NumRecords
		{
			get
			{
				return this.records.Count;
			}
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x00048CB0 File Offset: 0x00046EB0
		public global::NPOI.HSSF.Record.FontRecord GetFontRecordAt(int idx)
		{
			int num = idx;
			if (num > 4)
			{
				num--;
			}
			if (num > this.numfonts - 1)
			{
				throw new global::System.IndexOutOfRangeException("There are only " + this.numfonts.ToString() + " font records, you asked for " + idx.ToString());
			}
			return (global::NPOI.HSSF.Record.FontRecord)this.records[this.records.Fontpos - (this.numfonts - 1) + num];
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x00048D20 File Offset: 0x00046F20
		public global::NPOI.HSSF.Record.FontRecord CreateNewFont()
		{
			global::NPOI.HSSF.Record.FontRecord fontRecord = (global::NPOI.HSSF.Record.FontRecord)global::NPOI.HSSF.Model.InternalWorkbook.CreateFont();
			this.records.Add(this.records.Fontpos + 1, fontRecord);
			this.records.Fontpos = this.records.Fontpos + 1;
			this.numfonts++;
			return fontRecord;
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x00048D78 File Offset: 0x00046F78
		public void CloneDrawings(global::NPOI.HSSF.Model.InternalSheet sheet)
		{
			this.FindDrawingGroup();
			if (this.drawingManager == null)
			{
				return;
			}
			if (sheet.AggregateDrawingRecords(this.drawingManager, false) != -1)
			{
				global::NPOI.DDF.EscherContainerRecord escherContainer = ((global::NPOI.HSSF.Record.EscherAggregate)sheet.FindFirstRecordBySid(9876)).GetEscherContainer();
				if (escherContainer == null)
				{
					return;
				}
				global::NPOI.DDF.EscherDggRecord dgg = this.drawingManager.GetDgg();
				int num = (int)this.drawingManager.FindNewDrawingGroupId();
				dgg.AddCluster(num, 0);
				dgg.DrawingsSaved++;
				global::NPOI.DDF.EscherDgRecord escherDgRecord = null;
				foreach (object obj in escherContainer.ChildRecords)
				{
					if (obj is global::NPOI.DDF.EscherDgRecord)
					{
						escherDgRecord = (global::NPOI.DDF.EscherDgRecord)obj;
						escherDgRecord.Options = (short)(num << 4);
					}
					else if (obj is global::NPOI.DDF.EscherContainerRecord)
					{
						new global::System.Collections.ArrayList();
						foreach (object obj2 in ((global::NPOI.DDF.EscherContainerRecord)obj).ChildRecords)
						{
							foreach (global::NPOI.DDF.EscherRecord escherRecord in ((global::NPOI.DDF.EscherContainerRecord)obj2).ChildRecords)
							{
								int recordId = (int)escherRecord.RecordId;
								if (recordId == -4086)
								{
									global::NPOI.DDF.EscherSpRecord escherSpRecord = (global::NPOI.DDF.EscherSpRecord)escherRecord;
									int shapeId = this.drawingManager.AllocateShapeId((short)num, escherDgRecord);
									escherDgRecord.NumShapes--;
									escherSpRecord.ShapeId = shapeId;
								}
								else if (recordId == -4085)
								{
									global::NPOI.DDF.EscherSimpleProperty escherSimpleProperty = (global::NPOI.DDF.EscherSimpleProperty)((global::NPOI.DDF.EscherOptRecord)escherRecord).Lookup(260);
									if (escherSimpleProperty != null)
									{
										int propertyValue = escherSimpleProperty.PropertyValue;
										this.GetBSERecord(propertyValue).Ref++;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x00048F4C File Offset: 0x0004714C
		public int NumberOfFontRecords
		{
			get
			{
				return this.numfonts;
			}
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x00048F54 File Offset: 0x00047154
		public void SetSheetBof(int sheetIndex, int pos)
		{
			this.CheckSheets(sheetIndex);
			this.GetBoundSheetRec(sheetIndex).PositionOfBof = pos;
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x00048F6A File Offset: 0x0004716A
		public global::NPOI.HSSF.Record.BackupRecord BackupRecord
		{
			get
			{
				return (global::NPOI.HSSF.Record.BackupRecord)this.records[this.records.Backuppos];
			}
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x00048F87 File Offset: 0x00047187
		public void SetSheetName(int sheetnum, string sheetname)
		{
			this.CheckSheets(sheetnum);
			this.boundsheets[sheetnum].Sheetname = sheetname;
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x00048FA2 File Offset: 0x000471A2
		private global::NPOI.HSSF.Record.BoundSheetRecord GetBoundSheetRec(int sheetIndex)
		{
			return this.boundsheets[sheetIndex];
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x00048FB0 File Offset: 0x000471B0
		public bool ContainsSheetName(string name, int excludeSheetIdx)
		{
			string text = name;
			if (text.Length > 31)
			{
				text = text.Substring(0, 31);
			}
			for (int i = 0; i < this.boundsheets.Count; i++)
			{
				global::NPOI.HSSF.Record.BoundSheetRecord boundSheetRec = this.GetBoundSheetRec(i);
				if (excludeSheetIdx != i)
				{
					string text2 = boundSheetRec.Sheetname;
					if (text2.Length > 31)
					{
						text2 = text2.Substring(0, 31);
					}
					if (text.Equals(text2, global::System.StringComparison.OrdinalIgnoreCase))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00048F87 File Offset: 0x00047187
		public void SetSheetName(int sheetnum, string sheetname, short encoding)
		{
			this.CheckSheets(sheetnum);
			this.boundsheets[sheetnum].Sheetname = sheetname;
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x00049020 File Offset: 0x00047220
		public void SetSheetOrder(string sheetname, int pos)
		{
			int sheetIndex = this.GetSheetIndex(sheetname);
			global::NPOI.HSSF.Record.BoundSheetRecord item = this.boundsheets[sheetIndex];
			this.boundsheets.RemoveAt(sheetIndex);
			this.boundsheets.Insert(pos, item);
			int bspos = this.records.Bspos;
			int num = this.records.Bspos - (this.boundsheets.Count - 1);
			global::NPOI.HSSF.Record.Record r = this.records[num + sheetIndex];
			this.records.Remove(num + sheetIndex);
			this.records.Add(num + pos, r);
			this.records.Bspos = bspos;
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x000490BB File Offset: 0x000472BB
		public string GetSheetName(int sheetIndex)
		{
			return this.GetBoundSheetRec(sheetIndex).Sheetname;
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x000490C9 File Offset: 0x000472C9
		public bool IsSheetHidden(int sheetnum)
		{
			return this.GetBoundSheetRec(sheetnum).IsHidden;
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x000490D7 File Offset: 0x000472D7
		public bool IsSheetVeryHidden(int sheetnum)
		{
			return this.GetBoundSheetRec(sheetnum).IsVeryHidden;
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x000490E5 File Offset: 0x000472E5
		public void SetSheetHidden(int sheetnum, bool hidden)
		{
			this.boundsheets[sheetnum].IsHidden = hidden;
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x000490FC File Offset: 0x000472FC
		public void SetSheetHidden(int sheetnum, int hidden)
		{
			global::NPOI.HSSF.Record.BoundSheetRecord boundSheetRec = this.GetBoundSheetRec(sheetnum);
			bool isHidden = false;
			bool isVeryHidden = false;
			if (hidden != 0)
			{
				if (hidden == 1)
				{
					isHidden = true;
				}
				else
				{
					if (hidden != 2)
					{
						throw new global::System.ArgumentException("Invalid hidden flag " + hidden.ToString() + " given, must be 0, 1 or 2");
					}
					isVeryHidden = true;
				}
			}
			boundSheetRec.IsHidden = isHidden;
			boundSheetRec.IsVeryHidden = isVeryHidden;
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x00049150 File Offset: 0x00047350
		public int GetSheetIndex(string name)
		{
			int result = -1;
			for (int i = 0; i < this.boundsheets.Count; i++)
			{
				if (this.GetSheetName(i).Equals(name, global::System.StringComparison.OrdinalIgnoreCase))
				{
					result = i;
					break;
				}
			}
			return result;
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x0004918C File Offset: 0x0004738C
		private void CheckSheets(int sheetnum)
		{
			if (this.boundsheets.Count <= sheetnum)
			{
				if (this.boundsheets.Count + 1 <= sheetnum)
				{
					throw new global::System.Exception("Sheet number out of bounds!");
				}
				global::NPOI.HSSF.Record.BoundSheetRecord boundSheetRecord = (global::NPOI.HSSF.Record.BoundSheetRecord)global::NPOI.HSSF.Model.InternalWorkbook.CreateBoundSheet(sheetnum);
				this.records.Add(this.records.Bspos + 1, boundSheetRecord);
				this.records.Bspos = this.records.Bspos + 1;
				this.boundsheets.Add(boundSheetRecord);
				this.OrCreateLinkTable.CheckExternSheet(sheetnum);
				this.FixTabIdRecord();
			}
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x00049220 File Offset: 0x00047420
		public void RemoveSheet(int sheetIndex)
		{
			if (this.boundsheets.Count > sheetIndex)
			{
				this.records.Remove(this.records.Bspos - (this.boundsheets.Count - 1) + sheetIndex);
				this.boundsheets.RemoveAt(sheetIndex);
				this.FixTabIdRecord();
			}
			int num = sheetIndex + 1;
			for (int i = 0; i < this.NumNames; i++)
			{
				global::NPOI.HSSF.Record.NameRecord nameRecord = this.GetNameRecord(i);
				if (nameRecord.SheetNumber == num)
				{
					nameRecord.SheetNumber = 0;
				}
				else if (nameRecord.SheetNumber > num)
				{
					nameRecord.SheetNumber--;
				}
			}
			if (this.linkTable != null)
			{
				this.linkTable.RemoveSheet(sheetIndex);
			}
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x000492D0 File Offset: 0x000474D0
		private void FixTabIdRecord()
		{
			if (this.records.Tabpos <= 0)
			{
				return;
			}
			global::NPOI.HSSF.Record.TabIdRecord tabIdRecord = (global::NPOI.HSSF.Record.TabIdRecord)this.records[this.records.Tabpos];
			int recordSize = tabIdRecord.RecordSize;
			short[] array = new short[this.boundsheets.Count];
			short num = 0;
			while ((int)num < array.Length)
			{
				array[(int)num] = num;
				num += 1;
			}
			tabIdRecord.SetTabIdArray(array);
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001829 RID: 6185 RVA: 0x0004933A File Offset: 0x0004753A
		public int NumSheets
		{
			get
			{
				return this.boundsheets.Count;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x00049347 File Offset: 0x00047547
		public int NumExFormats
		{
			get
			{
				return this.numxfs;
			}
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x00049350 File Offset: 0x00047550
		public int GetFontIndex(global::NPOI.HSSF.Record.FontRecord font)
		{
			int i = 0;
			while (i <= this.numfonts)
			{
				if ((global::NPOI.HSSF.Record.FontRecord)this.records[this.records.Fontpos - (this.numfonts - 1) + i] == font)
				{
					if (i > 3)
					{
						return i + 1;
					}
					return i;
				}
				else
				{
					i++;
				}
			}
			throw new global::System.ArgumentException("Could not find that font!");
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x000493AC File Offset: 0x000475AC
		public global::NPOI.HSSF.Record.StyleRecord GetStyleRecord(int xfIndex)
		{
			bool flag = false;
			int num = this.records.Xfpos;
			while (num < this.records.Count && !flag)
			{
				global::NPOI.HSSF.Record.Record record = this.records[num];
				if (!(record is global::NPOI.HSSF.Record.ExtendedFormatRecord))
				{
					if (record is global::NPOI.HSSF.Record.StyleRecord)
					{
						global::NPOI.HSSF.Record.StyleRecord styleRecord = (global::NPOI.HSSF.Record.StyleRecord)record;
						if ((int)styleRecord.XFIndex == xfIndex)
						{
							return styleRecord;
						}
					}
					else
					{
						flag = true;
					}
				}
				num++;
			}
			return null;
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x00049410 File Offset: 0x00047610
		public global::NPOI.HSSF.Record.ExtendedFormatRecord GetExFormatAt(int index)
		{
			int num = this.records.Xfpos - (this.numxfs - 1);
			num += index;
			return (global::NPOI.HSSF.Record.ExtendedFormatRecord)this.records[num];
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x00049448 File Offset: 0x00047648
		public global::NPOI.HSSF.Record.ExtendedFormatRecord CreateCellXF()
		{
			global::NPOI.HSSF.Record.ExtendedFormatRecord extendedFormatRecord = global::NPOI.HSSF.Model.InternalWorkbook.CreateExtendedFormat();
			this.records.Add(this.records.Xfpos + 1, extendedFormatRecord);
			this.records.Xfpos = this.records.Xfpos + 1;
			this.numxfs++;
			return extendedFormatRecord;
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x0004949B File Offset: 0x0004769B
		public int AddSSTString(global::NPOI.HSSF.Record.UnicodeString str)
		{
			if (this.sst == null)
			{
				this.InsertSST();
			}
			return this.sst.AddString(str);
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x000494B7 File Offset: 0x000476B7
		public global::NPOI.HSSF.Record.UnicodeString GetSSTString(int str)
		{
			if (this.sst == null)
			{
				this.InsertSST();
			}
			return this.sst.GetString(str);
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x000494D4 File Offset: 0x000476D4
		public void InsertSST()
		{
			this.sst = new global::NPOI.HSSF.Record.SSTRecord();
			this.records.Add(this.records.Count - 1, global::NPOI.HSSF.Model.InternalWorkbook.CreateExtendedSST());
			this.records.Add(this.records.Count - 2, this.sst);
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x00049528 File Offset: 0x00047728
		public int Serialize(int offset, byte[] data)
		{
			int num = 0;
			global::NPOI.HSSF.Record.SSTRecord sstrecord = null;
			int num2 = 0;
			bool flag = false;
			for (int i = 0; i < this.records.Count; i++)
			{
				global::NPOI.HSSF.Record.Record record = this.records[i];
				if (record.Sid != 449 || ((global::NPOI.HSSF.Record.RecalcIdRecord)record).IsNeeded)
				{
					int num3 = 0;
					if (record is global::NPOI.HSSF.Record.SSTRecord)
					{
						sstrecord = (global::NPOI.HSSF.Record.SSTRecord)record;
						num2 = num;
					}
					if (record.Sid == 255 && sstrecord != null)
					{
						record = sstrecord.CreateExtSSTRecord(num2 + offset);
					}
					if (record is global::NPOI.HSSF.Record.BoundSheetRecord)
					{
						if (!flag)
						{
							for (int j = 0; j < this.boundsheets.Count; j++)
							{
								num3 += this.boundsheets[j].Serialize(num + offset + num3, data);
							}
							flag = true;
						}
					}
					else
					{
						num3 = record.Serialize(num + offset, data);
					}
					num += num3;
				}
			}
			return num;
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x00049618 File Offset: 0x00047818
		public void PreSerialize()
		{
			if (this.records.Tabpos > 0 && ((global::NPOI.HSSF.Record.TabIdRecord)this.records[this.records.Tabpos])._tabids.Length < this.boundsheets.Count)
			{
				this.FixTabIdRecord();
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001834 RID: 6196 RVA: 0x00049668 File Offset: 0x00047868
		public int Size
		{
			get
			{
				int num = 0;
				global::NPOI.HSSF.Record.SSTRecord sstrecord = null;
				for (int i = 0; i < this.records.Count; i++)
				{
					global::NPOI.HSSF.Record.Record record = this.records[i];
					if (record.Sid != 449 || ((global::NPOI.HSSF.Record.RecalcIdRecord)record).IsNeeded)
					{
						if (record is global::NPOI.HSSF.Record.SSTRecord)
						{
							sstrecord = (global::NPOI.HSSF.Record.SSTRecord)record;
						}
						if (record.Sid == 255 && sstrecord != null)
						{
							num += sstrecord.CalcExtSSTRecordSize();
						}
						else
						{
							num += record.RecordSize;
						}
					}
				}
				return num;
			}
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x000496EA File Offset: 0x000478EA
		private static global::NPOI.HSSF.Record.Record CreateBOF()
		{
			return new global::NPOI.HSSF.Record.BOFRecord
			{
				Version = 1536,
				Type = global::NPOI.HSSF.Record.BOFRecordType.Workbook,
				Build = 4307,
				BuildYear = 1996,
				HistoryBitMask = 65,
				RequiredVersion = 6
			};
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x0002BE0C File Offset: 0x0002A00C
		[global::System.Obsolete]
		protected global::NPOI.HSSF.Record.Record CreateInterfaceHdr()
		{
			return null;
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x00049728 File Offset: 0x00047928
		private static global::NPOI.HSSF.Record.Record CreateMMS()
		{
			return new global::NPOI.HSSF.Record.MMSRecord
			{
				AddMenuCount = 0,
				DelMenuCount = 0
			};
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x0002BE0C File Offset: 0x0002A00C
		[global::System.Obsolete]
		protected global::NPOI.HSSF.Record.Record CreateInterfaceEnd()
		{
			return null;
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x00049740 File Offset: 0x00047940
		private static global::NPOI.HSSF.Record.Record CreateWriteAccess()
		{
			global::NPOI.HSSF.Record.WriteAccessRecord writeAccessRecord = new global::NPOI.HSSF.Record.WriteAccessRecord();
			string text = "NPOI";
			try
			{
				string text2 = global::System.Environment.UserName;
				if (string.IsNullOrEmpty(text2))
				{
					text2 = text;
				}
				writeAccessRecord.Username = text2;
			}
			catch (global::System.Security.SecurityException)
			{
				writeAccessRecord.Username = text;
			}
			return writeAccessRecord;
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x00049790 File Offset: 0x00047990
		private static global::NPOI.HSSF.Record.Record CreateCodepage()
		{
			return new global::NPOI.HSSF.Record.CodepageRecord
			{
				Codepage = 1200
			};
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x000497A2 File Offset: 0x000479A2
		private static global::NPOI.HSSF.Record.Record CreateDSF()
		{
			return new global::NPOI.HSSF.Record.DSFRecord(false);
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x000497AC File Offset: 0x000479AC
		private static global::NPOI.HSSF.Record.Record CreateTabId()
		{
			global::NPOI.HSSF.Record.TabIdRecord tabIdRecord = new global::NPOI.HSSF.Record.TabIdRecord();
			short[] tabIdArray = new short[1];
			tabIdRecord.SetTabIdArray(tabIdArray);
			return tabIdRecord;
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x000497CE File Offset: 0x000479CE
		private static global::NPOI.HSSF.Record.Record CreateFnGroupCount()
		{
			return new global::NPOI.HSSF.Record.FnGroupCountRecord
			{
				Count = 14
			};
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x000497DD File Offset: 0x000479DD
		private static global::NPOI.HSSF.Record.Record CreateWindowProtect()
		{
			return new global::NPOI.HSSF.Record.WindowProtectRecord(false);
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x00047F78 File Offset: 0x00046178
		private static global::NPOI.HSSF.Record.ProtectRecord CreateProtect()
		{
			return new global::NPOI.HSSF.Record.ProtectRecord(false);
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00047F70 File Offset: 0x00046170
		private static global::NPOI.HSSF.Record.Record CreatePassword()
		{
			return new global::NPOI.HSSF.Record.PasswordRecord(0);
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x000497E5 File Offset: 0x000479E5
		private static global::NPOI.HSSF.Record.ProtectionRev4Record CreateProtectionRev4()
		{
			return new global::NPOI.HSSF.Record.ProtectionRev4Record(false);
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x000497ED File Offset: 0x000479ED
		private static global::NPOI.HSSF.Record.Record CreatePasswordRev4()
		{
			return new global::NPOI.HSSF.Record.PasswordRev4Record(0);
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x000497F8 File Offset: 0x000479F8
		private static global::NPOI.HSSF.Record.Record CreateWindowOne()
		{
			return new global::NPOI.HSSF.Record.WindowOneRecord
			{
				HorizontalHold = 360,
				VerticalHold = 270,
				Width = 14940,
				Height = 9150,
				Options = 56,
				ActiveSheetIndex = 0,
				FirstVisibleTab = 0,
				NumSelectedTabs = 1,
				TabWidthRatio = 600
			};
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x0004985E File Offset: 0x00047A5E
		private static global::NPOI.HSSF.Record.Record CreateBackup()
		{
			return new global::NPOI.HSSF.Record.BackupRecord
			{
				Backup = 0
			};
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x0004986C File Offset: 0x00047A6C
		private static global::NPOI.HSSF.Record.Record CreateHideObj()
		{
			global::NPOI.HSSF.Record.HideObjRecord hideObjRecord = new global::NPOI.HSSF.Record.HideObjRecord();
			hideObjRecord.SetHideObj(0);
			return hideObjRecord;
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x0004987A File Offset: 0x00047A7A
		private static global::NPOI.HSSF.Record.Record CreateDateWindow1904()
		{
			return new global::NPOI.HSSF.Record.DateWindow1904Record
			{
				Windowing = 0
			};
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00049888 File Offset: 0x00047A88
		private static global::NPOI.HSSF.Record.Record CreatePrecision()
		{
			return new global::NPOI.HSSF.Record.PrecisionRecord
			{
				FullPrecision = true
			};
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00049896 File Offset: 0x00047A96
		private static global::NPOI.HSSF.Record.Record CreateRefreshAll()
		{
			return new global::NPOI.HSSF.Record.RefreshAllRecord(false);
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x0004989E File Offset: 0x00047A9E
		private static global::NPOI.HSSF.Record.Record CreateBookBool()
		{
			return new global::NPOI.HSSF.Record.BookBoolRecord
			{
				SaveLinkValues = 0
			};
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x000498AC File Offset: 0x00047AAC
		private static global::NPOI.HSSF.Record.Record CreateFont()
		{
			return new global::NPOI.HSSF.Record.FontRecord
			{
				FontHeight = 200,
				Attributes = 0,
				ColorPaletteIndex = short.MaxValue,
				BoldWeight = 400,
				FontName = "Arial"
			};
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x000498E8 File Offset: 0x00047AE8
		private static global::NPOI.HSSF.Record.Record CreateExtendedFormat(int id)
		{
			global::NPOI.HSSF.Record.ExtendedFormatRecord extendedFormatRecord = new global::NPOI.HSSF.Record.ExtendedFormatRecord();
			switch (id)
			{
			case 0:
				extendedFormatRecord.FontIndex = 0;
				extendedFormatRecord.FormatIndex = 0;
				extendedFormatRecord.CellOptions = -11;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = 0;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 1:
				extendedFormatRecord.FontIndex = 1;
				extendedFormatRecord.FormatIndex = 0;
				extendedFormatRecord.CellOptions = -11;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = -3072;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 2:
				extendedFormatRecord.FontIndex = 1;
				extendedFormatRecord.FormatIndex = 0;
				extendedFormatRecord.CellOptions = -11;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = -3072;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 3:
				extendedFormatRecord.FontIndex = 2;
				extendedFormatRecord.FormatIndex = 0;
				extendedFormatRecord.CellOptions = -11;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = -3072;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 4:
				extendedFormatRecord.FontIndex = 2;
				extendedFormatRecord.FormatIndex = 0;
				extendedFormatRecord.CellOptions = -11;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = -3072;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 5:
				extendedFormatRecord.FontIndex = 0;
				extendedFormatRecord.FormatIndex = 0;
				extendedFormatRecord.CellOptions = -11;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = -3072;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 6:
				extendedFormatRecord.FontIndex = 0;
				extendedFormatRecord.FormatIndex = 0;
				extendedFormatRecord.CellOptions = -11;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = -3072;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 7:
				extendedFormatRecord.FontIndex = 0;
				extendedFormatRecord.FormatIndex = 0;
				extendedFormatRecord.CellOptions = -11;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = -3072;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 8:
				extendedFormatRecord.FontIndex = 0;
				extendedFormatRecord.FormatIndex = 0;
				extendedFormatRecord.CellOptions = -11;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = -3072;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 9:
				extendedFormatRecord.FontIndex = 0;
				extendedFormatRecord.FormatIndex = 0;
				extendedFormatRecord.CellOptions = -11;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = -3072;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 10:
				extendedFormatRecord.FontIndex = 0;
				extendedFormatRecord.FormatIndex = 0;
				extendedFormatRecord.CellOptions = -11;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = -3072;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 11:
				extendedFormatRecord.FontIndex = 0;
				extendedFormatRecord.FormatIndex = 0;
				extendedFormatRecord.CellOptions = -11;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = -3072;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 12:
				extendedFormatRecord.FontIndex = 0;
				extendedFormatRecord.FormatIndex = 0;
				extendedFormatRecord.CellOptions = -11;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = -3072;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 13:
				extendedFormatRecord.FontIndex = 0;
				extendedFormatRecord.FormatIndex = 0;
				extendedFormatRecord.CellOptions = -11;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = -3072;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 14:
				extendedFormatRecord.FontIndex = 0;
				extendedFormatRecord.FormatIndex = 0;
				extendedFormatRecord.CellOptions = -11;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = -3072;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 15:
				extendedFormatRecord.FontIndex = 0;
				extendedFormatRecord.FormatIndex = 0;
				extendedFormatRecord.CellOptions = 1;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = 0;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 16:
				extendedFormatRecord.FontIndex = 1;
				extendedFormatRecord.FormatIndex = 43;
				extendedFormatRecord.CellOptions = -11;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = -2048;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 17:
				extendedFormatRecord.FontIndex = 1;
				extendedFormatRecord.FormatIndex = 41;
				extendedFormatRecord.CellOptions = -11;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = -2048;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 18:
				extendedFormatRecord.FontIndex = 1;
				extendedFormatRecord.FormatIndex = 44;
				extendedFormatRecord.CellOptions = -11;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = -2048;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 19:
				extendedFormatRecord.FontIndex = 1;
				extendedFormatRecord.FormatIndex = 42;
				extendedFormatRecord.CellOptions = -11;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = -2048;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 20:
				extendedFormatRecord.FontIndex = 1;
				extendedFormatRecord.FormatIndex = 9;
				extendedFormatRecord.CellOptions = -11;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = -2048;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 21:
				extendedFormatRecord.FontIndex = 5;
				extendedFormatRecord.FormatIndex = 0;
				extendedFormatRecord.CellOptions = 1;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = 2048;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 22:
				extendedFormatRecord.FontIndex = 6;
				extendedFormatRecord.FormatIndex = 0;
				extendedFormatRecord.CellOptions = 1;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = 23552;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 23:
				extendedFormatRecord.FontIndex = 0;
				extendedFormatRecord.FormatIndex = 49;
				extendedFormatRecord.CellOptions = 1;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = 23552;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 24:
				extendedFormatRecord.FontIndex = 0;
				extendedFormatRecord.FormatIndex = 8;
				extendedFormatRecord.CellOptions = 1;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = 23552;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			case 25:
				extendedFormatRecord.FontIndex = 6;
				extendedFormatRecord.FormatIndex = 8;
				extendedFormatRecord.CellOptions = 1;
				extendedFormatRecord.AlignmentOptions = 32;
				extendedFormatRecord.IndentionOptions = 23552;
				extendedFormatRecord.BorderOptions = 0;
				extendedFormatRecord.PaletteOptions = 0;
				extendedFormatRecord.AdtlPaletteOptions = 0;
				extendedFormatRecord.FillPaletteOptions = 8384;
				break;
			default:
				throw new global::System.InvalidOperationException("Unrecognized format id: " + id.ToString());
			}
			return extendedFormatRecord;
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x0004A164 File Offset: 0x00048364
		private static global::NPOI.HSSF.Record.ExtendedFormatRecord CreateExtendedFormat()
		{
			return new global::NPOI.HSSF.Record.ExtendedFormatRecord
			{
				FontIndex = 0,
				FormatIndex = 0,
				CellOptions = 1,
				AlignmentOptions = 32,
				IndentionOptions = 0,
				BorderOptions = 0,
				PaletteOptions = 0,
				AdtlPaletteOptions = 0,
				FillPaletteOptions = 8384,
				TopBorderPaletteIdx = 8,
				BottomBorderPaletteIdx = 8,
				LeftBorderPaletteIdx = 8,
				RightBorderPaletteIdx = 8
			};
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x0004A1D8 File Offset: 0x000483D8
		public global::NPOI.HSSF.Record.StyleRecord CreateStyleRecord(int xfIndex)
		{
			global::NPOI.HSSF.Record.StyleRecord styleRecord = new global::NPOI.HSSF.Record.StyleRecord();
			styleRecord.XFIndex = (short)xfIndex;
			int num = -1;
			int num2 = this.records.Xfpos;
			while (num2 < this.records.Count && num == -1)
			{
				global::NPOI.HSSF.Record.Record record = this.records[num2];
				if (!(record is global::NPOI.HSSF.Record.ExtendedFormatRecord) && !(record is global::NPOI.HSSF.Record.StyleRecord))
				{
					num = num2;
				}
				num2++;
			}
			if (num == -1)
			{
				throw new global::System.InvalidOperationException("No XF Records found!");
			}
			this.records.Add(num, styleRecord);
			return styleRecord;
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x0004A258 File Offset: 0x00048458
		private static global::NPOI.HSSF.Record.Record CreateStyle(int id)
		{
			global::NPOI.HSSF.Record.StyleRecord styleRecord = new global::NPOI.HSSF.Record.StyleRecord();
			switch (id)
			{
			case 0:
				styleRecord.XFIndex = -32752;
				styleRecord.SetBuiltinStyle(3);
				styleRecord.OutlineStyleLevel = 255;
				break;
			case 1:
				styleRecord.XFIndex = -32751;
				styleRecord.SetBuiltinStyle(6);
				styleRecord.OutlineStyleLevel = 255;
				break;
			case 2:
				styleRecord.XFIndex = -32750;
				styleRecord.SetBuiltinStyle(4);
				styleRecord.OutlineStyleLevel = 255;
				break;
			case 3:
				styleRecord.XFIndex = -32749;
				styleRecord.SetBuiltinStyle(7);
				styleRecord.OutlineStyleLevel = 255;
				break;
			case 4:
				styleRecord.XFIndex = short.MinValue;
				styleRecord.SetBuiltinStyle(0);
				styleRecord.OutlineStyleLevel = 255;
				break;
			case 5:
				styleRecord.XFIndex = -32748;
				styleRecord.SetBuiltinStyle(5);
				styleRecord.OutlineStyleLevel = 255;
				break;
			default:
				throw new global::System.InvalidOperationException("Unrecognized style id: " + id.ToString());
			}
			return styleRecord;
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x0004A366 File Offset: 0x00048566
		private static global::NPOI.HSSF.Record.PaletteRecord CreatePalette()
		{
			return new global::NPOI.HSSF.Record.PaletteRecord();
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x0004A36D File Offset: 0x0004856D
		private static global::NPOI.HSSF.Record.UseSelFSRecord CreateUseSelFS()
		{
			return new global::NPOI.HSSF.Record.UseSelFSRecord(false);
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x0004A378 File Offset: 0x00048578
		private static global::NPOI.HSSF.Record.Record CreateBoundSheet(int id)
		{
			return new global::NPOI.HSSF.Record.BoundSheetRecord("Sheet" + (id + 1).ToString());
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x0004A3A0 File Offset: 0x000485A0
		private static global::NPOI.HSSF.Record.Record CreateCountry()
		{
			global::NPOI.HSSF.Record.CountryRecord countryRecord = new global::NPOI.HSSF.Record.CountryRecord();
			countryRecord.DefaultCountry = 1;
			if (global::System.Threading.Thread.CurrentThread.CurrentCulture.Name.Equals("ru_RU"))
			{
				countryRecord.CurrentCountry = 7;
			}
			else
			{
				countryRecord.CurrentCountry = 1;
			}
			return countryRecord;
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x0004A3E6 File Offset: 0x000485E6
		private static global::NPOI.HSSF.Record.Record CreateExtendedSST()
		{
			return new global::NPOI.HSSF.Record.ExtSSTRecord
			{
				NumStringsPerBucket = 8
			};
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x0004A3F4 File Offset: 0x000485F4
		private global::NPOI.HSSF.Model.LinkTable OrCreateLinkTable
		{
			get
			{
				return this.GetOrCreateLinkTable();
			}
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x0004A3FC File Offset: 0x000485FC
		private global::NPOI.HSSF.Model.LinkTable GetOrCreateLinkTable()
		{
			if (this.linkTable == null)
			{
				this.linkTable = new global::NPOI.HSSF.Model.LinkTable((int)((short)this.NumSheets), this.records);
			}
			return this.linkTable;
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x0004A424 File Offset: 0x00048624
		public int LinkExternalWorkbook(string name, global::NPOI.SS.UserModel.IWorkbook externalWorkbook)
		{
			return this.GetOrCreateLinkTable().LinkExternalWorkbook(name, externalWorkbook);
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x0004A434 File Offset: 0x00048634
		public string FindSheetFirstNameFromExternSheet(int externSheetIndex)
		{
			int firstInternalSheetIndexForExtIndex = this.linkTable.GetFirstInternalSheetIndexForExtIndex(externSheetIndex);
			return this.FindSheetNameFromIndex(firstInternalSheetIndexForExtIndex);
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x0004A458 File Offset: 0x00048658
		public string FindSheetLastNameFromExternSheet(int externSheetIndex)
		{
			int lastInternalSheetIndexForExtIndex = this.linkTable.GetLastInternalSheetIndexForExtIndex(externSheetIndex);
			return this.FindSheetNameFromIndex(lastInternalSheetIndexForExtIndex);
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x0004A479 File Offset: 0x00048679
		private string FindSheetNameFromIndex(int internalSheetIndex)
		{
			if (internalSheetIndex < 0)
			{
				return "";
			}
			if (internalSheetIndex >= this.boundsheets.Count)
			{
				return "";
			}
			return this.GetSheetName(internalSheetIndex);
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x0004A4A0 File Offset: 0x000486A0
		public global::NPOI.SS.Formula.ExternalSheet GetExternalSheet(int externSheetIndex)
		{
			string[] externalBookAndSheetName = this.linkTable.GetExternalBookAndSheetName(externSheetIndex);
			if (externalBookAndSheetName == null)
			{
				return null;
			}
			if (externalBookAndSheetName.Length == 2)
			{
				return new global::NPOI.SS.Formula.ExternalSheet(externalBookAndSheetName[0], externalBookAndSheetName[1]);
			}
			return new global::NPOI.SS.Formula.ExternalSheetRange(externalBookAndSheetName[0], externalBookAndSheetName[1], externalBookAndSheetName[2]);
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x0004A4DF File Offset: 0x000486DF
		public int GetFirstSheetIndexFromExternSheetIndex(int externSheetNumber)
		{
			return this.linkTable.GetFirstInternalSheetIndexForExtIndex(externSheetNumber);
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x0004A4ED File Offset: 0x000486ED
		public int GetLastSheetIndexFromExternSheetIndex(int externSheetNumber)
		{
			return this.linkTable.GetLastInternalSheetIndexForExtIndex(externSheetNumber);
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x0004A4FB File Offset: 0x000486FB
		public int CheckExternSheet(int sheetNumber)
		{
			return this.OrCreateLinkTable.CheckExternSheet(sheetNumber);
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x0004A509 File Offset: 0x00048709
		public short checkExternSheet(int firstSheetNumber, int lastSheetNumber)
		{
			return (short)this.OrCreateLinkTable.CheckExternSheet(firstSheetNumber, lastSheetNumber);
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x0004A519 File Offset: 0x00048719
		public int GetExternalSheetIndex(string workbookName, string sheetName)
		{
			return this.OrCreateLinkTable.GetExternalSheetIndex(workbookName, sheetName, sheetName);
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x0004A529 File Offset: 0x00048729
		public int GetExternalSheetIndex(string workbookName, string firstSheetName, string lastSheetName)
		{
			return this.OrCreateLinkTable.GetExternalSheetIndex(workbookName, firstSheetName, lastSheetName);
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001861 RID: 6241 RVA: 0x0004A539 File Offset: 0x00048739
		public int NumNames
		{
			get
			{
				if (this.linkTable == null)
				{
					return 0;
				}
				return this.linkTable.NumNames;
			}
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x0004A550 File Offset: 0x00048750
		public global::NPOI.SS.Formula.PTG.NameXPtg GetNameXPtg(string name, int sheetRefIndex, global::NPOI.SS.Formula.UDF.UDFFinder udf)
		{
			global::NPOI.HSSF.Model.LinkTable orCreateLinkTable = this.OrCreateLinkTable;
			global::NPOI.SS.Formula.PTG.NameXPtg nameXPtg = orCreateLinkTable.GetNameXPtg(name, sheetRefIndex);
			if (nameXPtg == null && udf.FindFunction(name) != null)
			{
				nameXPtg = orCreateLinkTable.AddNameXPtg(name);
			}
			return nameXPtg;
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x0004A582 File Offset: 0x00048782
		public global::NPOI.SS.Formula.PTG.NameXPtg GetNameXPtg(string name, global::NPOI.SS.Formula.UDF.UDFFinder udf)
		{
			return this.GetNameXPtg(name, -1, udf);
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x0004A58D File Offset: 0x0004878D
		public global::NPOI.HSSF.Record.NameRecord GetNameRecord(int index)
		{
			return this.linkTable.GetNameRecord(index);
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x0004A59B File Offset: 0x0004879B
		public global::NPOI.HSSF.Record.NameRecord CreateName()
		{
			return this.AddName(new global::NPOI.HSSF.Record.NameRecord());
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x0004A5A8 File Offset: 0x000487A8
		public global::NPOI.HSSF.Record.NameRecord AddName(global::NPOI.HSSF.Record.NameRecord name)
		{
			this.OrCreateLinkTable.AddName(name);
			return name;
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x0004A5B8 File Offset: 0x000487B8
		public global::NPOI.HSSF.Record.NameRecord CreateBuiltInName(byte builtInName, int index)
		{
			if (index == -1 || index + 1 > 32767)
			{
				throw new global::System.ArgumentException("Index is not valid [" + index.ToString() + "]");
			}
			global::NPOI.HSSF.Record.NameRecord nameRecord = new global::NPOI.HSSF.Record.NameRecord(builtInName, (int)((short)index));
			this.AddName(nameRecord);
			return nameRecord;
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0004A604 File Offset: 0x00048804
		public void RemoveName(int namenum)
		{
			if (this.linkTable.NumNames > namenum)
			{
				int num = this.FindFirstRecordLocBySid(24);
				this.records.Remove(num + namenum);
				this.linkTable.RemoveName(namenum);
			}
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x0004A644 File Offset: 0x00048844
		public void UpdateNameCommentRecordCache(global::NPOI.HSSF.Record.NameCommentRecord commentRecord)
		{
			if (this.commentRecords.ContainsValue(commentRecord))
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::NPOI.HSSF.Record.NameCommentRecord> keyValuePair in this.commentRecords)
				{
					if (keyValuePair.Value.Equals(commentRecord))
					{
						this.commentRecords.Remove(keyValuePair.Key);
						break;
					}
				}
			}
			this.commentRecords[commentRecord.NameText] = commentRecord;
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0004A6D4 File Offset: 0x000488D4
		public short GetFormat(string format, bool CreateIfNotFound)
		{
			foreach (object obj in this.formats)
			{
				global::NPOI.HSSF.Record.FormatRecord formatRecord = (global::NPOI.HSSF.Record.FormatRecord)obj;
				if (formatRecord.FormatString.Equals(format))
				{
					return (short)formatRecord.IndexCode;
				}
			}
			if (CreateIfNotFound)
			{
				return (short)this.CreateFormat(format);
			}
			return -1;
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x0600186B RID: 6251 RVA: 0x0004A72B File Offset: 0x0004892B
		public global::System.Collections.Generic.List<global::NPOI.HSSF.Record.FormatRecord> Formats
		{
			get
			{
				return this.formats;
			}
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x0004A734 File Offset: 0x00048934
		public int CreateFormat(string formatString)
		{
			this.maxformatid = (int)((this.maxformatid >= 164) ? ((short)(this.maxformatid + 1)) : 164);
			global::NPOI.HSSF.Record.FormatRecord formatRecord = new global::NPOI.HSSF.Record.FormatRecord(this.maxformatid, formatString);
			int num = 0;
			while (num < this.records.Count && this.records[num].Sid != 1054)
			{
				num++;
			}
			num += this.formats.Count;
			this.formats.Add(formatRecord);
			this.records.Add(num, formatRecord);
			return this.maxformatid;
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x0004A7CC File Offset: 0x000489CC
		private static global::NPOI.HSSF.Record.FormatRecord CreateFormat(int id)
		{
			switch (id)
			{
			case 0:
				return new global::NPOI.HSSF.Record.FormatRecord(5, global::NPOI.SS.UserModel.BuiltinFormats.GetBuiltinFormat(5));
			case 1:
				return new global::NPOI.HSSF.Record.FormatRecord(6, global::NPOI.SS.UserModel.BuiltinFormats.GetBuiltinFormat(6));
			case 2:
				return new global::NPOI.HSSF.Record.FormatRecord(7, global::NPOI.SS.UserModel.BuiltinFormats.GetBuiltinFormat(7));
			case 3:
				return new global::NPOI.HSSF.Record.FormatRecord(8, global::NPOI.SS.UserModel.BuiltinFormats.GetBuiltinFormat(8));
			case 4:
				return new global::NPOI.HSSF.Record.FormatRecord(42, global::NPOI.SS.UserModel.BuiltinFormats.GetBuiltinFormat(42));
			case 5:
				return new global::NPOI.HSSF.Record.FormatRecord(41, global::NPOI.SS.UserModel.BuiltinFormats.GetBuiltinFormat(41));
			case 6:
				return new global::NPOI.HSSF.Record.FormatRecord(44, global::NPOI.SS.UserModel.BuiltinFormats.GetBuiltinFormat(44));
			case 7:
				return new global::NPOI.HSSF.Record.FormatRecord(43, global::NPOI.SS.UserModel.BuiltinFormats.GetBuiltinFormat(43));
			default:
				throw new global::System.ArgumentException("Unexpected id " + id.ToString());
			}
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x0004A888 File Offset: 0x00048A88
		public global::NPOI.HSSF.Record.Record FindFirstRecordBySid(short sid)
		{
			foreach (object obj in this.records)
			{
				global::NPOI.HSSF.Record.Record record = (global::NPOI.HSSF.Record.Record)obj;
				if (record.Sid == sid)
				{
					return record;
				}
			}
			return null;
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x0004A8C4 File Offset: 0x00048AC4
		public int FindFirstRecordLocBySid(short sid)
		{
			int num = 0;
			global::System.Collections.IEnumerator enumerator = this.records.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (((global::NPOI.HSSF.Record.Record)enumerator.Current).Sid == sid)
				{
					return num;
				}
				num++;
			}
			return -1;
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x0004A904 File Offset: 0x00048B04
		public global::NPOI.HSSF.Record.Record FindNextRecordBySid(short sid, int pos)
		{
			int num = 0;
			foreach (object obj in this.records)
			{
				global::NPOI.HSSF.Record.Record record = (global::NPOI.HSSF.Record.Record)obj;
				if (record.Sid == sid && num++ == pos)
				{
					return record;
				}
			}
			return null;
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x0004A949 File Offset: 0x00048B49
		public global::System.Collections.IList Hyperlinks
		{
			get
			{
				return this.hyperlinks;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x0004A951 File Offset: 0x00048B51
		public global::System.Collections.IList Records
		{
			get
			{
				return this.records.Records;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x0004A95E File Offset: 0x00048B5E
		public bool IsUsing1904DateWindowing
		{
			get
			{
				return this.uses1904datewindowing;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x0004A968 File Offset: 0x00048B68
		public global::NPOI.HSSF.Record.PaletteRecord CustomPalette
		{
			get
			{
				int palettepos = this.records.Palettepos;
				global::NPOI.HSSF.Record.PaletteRecord paletteRecord;
				if (palettepos != -1)
				{
					global::NPOI.HSSF.Record.Record record = this.records[palettepos];
					if (!(record is global::NPOI.HSSF.Record.PaletteRecord))
					{
						string str = "InternalError: Expected PaletteRecord but got a '";
						global::NPOI.HSSF.Record.Record record2 = record;
						throw new global::System.Exception(str + ((record2 != null) ? record2.ToString() : null) + "'");
					}
					paletteRecord = (global::NPOI.HSSF.Record.PaletteRecord)record;
				}
				else
				{
					paletteRecord = global::NPOI.HSSF.Model.InternalWorkbook.CreatePalette();
					this.records.Add(1, paletteRecord);
					this.records.Palettepos = 1;
				}
				return paletteRecord;
			}
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x0004A9E8 File Offset: 0x00048BE8
		public global::NPOI.HSSF.Model.DrawingManager2 FindDrawingGroup()
		{
			if (this.drawingManager != null)
			{
				return this.drawingManager;
			}
			foreach (object obj in this.records)
			{
				global::NPOI.HSSF.Record.Record record = (global::NPOI.HSSF.Record.Record)obj;
				if (record is global::NPOI.HSSF.Record.DrawingGroupRecord)
				{
					global::NPOI.HSSF.Record.DrawingGroupRecord drawingGroupRecord = (global::NPOI.HSSF.Record.DrawingGroupRecord)record;
					drawingGroupRecord.ProcessChildRecords();
					global::NPOI.DDF.EscherContainerRecord escherContainer = drawingGroupRecord.GetEscherContainer();
					if (escherContainer != null)
					{
						global::NPOI.DDF.EscherDggRecord escherDggRecord = null;
						global::NPOI.DDF.EscherContainerRecord escherContainerRecord = null;
						foreach (object obj2 in escherContainer.ChildRecords)
						{
							global::NPOI.DDF.EscherRecord escherRecord = (global::NPOI.DDF.EscherRecord)obj2;
							if (escherRecord is global::NPOI.DDF.EscherDggRecord)
							{
								escherDggRecord = (global::NPOI.DDF.EscherDggRecord)escherRecord;
							}
							else if (escherRecord.RecordId == -4095)
							{
								escherContainerRecord = (global::NPOI.DDF.EscherContainerRecord)escherRecord;
							}
						}
						if (escherDggRecord != null)
						{
							this.drawingManager = new global::NPOI.HSSF.Model.DrawingManager2(escherDggRecord);
							if (escherContainerRecord != null)
							{
								foreach (global::NPOI.DDF.EscherRecord escherRecord2 in escherContainerRecord.ChildRecords)
								{
									if (escherRecord2 is global::NPOI.DDF.EscherBSERecord)
									{
										this.escherBSERecords.Add((global::NPOI.DDF.EscherBSERecord)escherRecord2);
									}
								}
							}
							return this.drawingManager;
						}
					}
				}
			}
			int num = this.FindFirstRecordLocBySid(235);
			if (num != -1)
			{
				global::NPOI.HSSF.Record.AbstractEscherHolderRecord abstractEscherHolderRecord = (global::NPOI.HSSF.Record.DrawingGroupRecord)this.records[num];
				global::NPOI.DDF.EscherDggRecord escherDggRecord2 = null;
				global::NPOI.DDF.EscherContainerRecord escherContainerRecord2 = null;
				foreach (object obj3 in abstractEscherHolderRecord.EscherRecords)
				{
					global::NPOI.DDF.EscherRecord escherRecord3 = (global::NPOI.DDF.EscherRecord)obj3;
					if (escherRecord3 is global::NPOI.DDF.EscherDggRecord)
					{
						escherDggRecord2 = (global::NPOI.DDF.EscherDggRecord)escherRecord3;
					}
					else if (escherRecord3.RecordId == -4095)
					{
						escherContainerRecord2 = (global::NPOI.DDF.EscherContainerRecord)escherRecord3;
					}
				}
				if (escherDggRecord2 != null)
				{
					this.drawingManager = new global::NPOI.HSSF.Model.DrawingManager2(escherDggRecord2);
					if (escherContainerRecord2 != null)
					{
						foreach (global::NPOI.DDF.EscherRecord escherRecord4 in escherContainerRecord2.ChildRecords)
						{
							if (escherRecord4 is global::NPOI.DDF.EscherBSERecord)
							{
								this.escherBSERecords.Add((global::NPOI.DDF.EscherBSERecord)escherRecord4);
							}
						}
					}
				}
			}
			return this.drawingManager;
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x0004AC1C File Offset: 0x00048E1C
		public void CreateDrawingGroup()
		{
			if (this.drawingManager == null)
			{
				global::NPOI.DDF.EscherContainerRecord escherContainerRecord = new global::NPOI.DDF.EscherContainerRecord();
				global::NPOI.DDF.EscherDggRecord escherDggRecord = new global::NPOI.DDF.EscherDggRecord();
				global::NPOI.DDF.EscherOptRecord escherOptRecord = new global::NPOI.DDF.EscherOptRecord();
				global::NPOI.DDF.EscherSplitMenuColorsRecord escherSplitMenuColorsRecord = new global::NPOI.DDF.EscherSplitMenuColorsRecord();
				escherContainerRecord.RecordId = -4096;
				escherContainerRecord.Options = 15;
				escherDggRecord.RecordId = -4090;
				escherDggRecord.Options = 0;
				escherDggRecord.ShapeIdMax = 1024;
				escherDggRecord.NumShapesSaved = 0;
				escherDggRecord.DrawingsSaved = 0;
				escherDggRecord.FileIdClusters = new global::NPOI.DDF.EscherDggRecord.FileIdCluster[0];
				this.drawingManager = new global::NPOI.HSSF.Model.DrawingManager2(escherDggRecord);
				global::NPOI.DDF.EscherContainerRecord escherContainerRecord2 = null;
				if (this.escherBSERecords.Count > 0)
				{
					escherContainerRecord2 = new global::NPOI.DDF.EscherContainerRecord();
					escherContainerRecord2.RecordId = -4095;
					escherContainerRecord2.Options = (short)(this.escherBSERecords.Count << 4 | 15);
					foreach (object obj in this.escherBSERecords)
					{
						global::NPOI.DDF.EscherRecord record = (global::NPOI.DDF.EscherRecord)obj;
						escherContainerRecord2.AddChildRecord(record);
					}
				}
				escherOptRecord.RecordId = -4085;
				escherOptRecord.Options = 51;
				escherOptRecord.AddEscherProperty(new global::NPOI.DDF.EscherBoolProperty(191, 524296));
				escherOptRecord.AddEscherProperty(new global::NPOI.DDF.EscherRGBProperty(385, 134217793));
				escherOptRecord.AddEscherProperty(new global::NPOI.DDF.EscherRGBProperty(448, 134217792));
				escherSplitMenuColorsRecord.RecordId = -3810;
				escherSplitMenuColorsRecord.Options = 64;
				escherSplitMenuColorsRecord.Color1 = 134217741;
				escherSplitMenuColorsRecord.Color2 = 134217740;
				escherSplitMenuColorsRecord.Color3 = 134217751;
				escherSplitMenuColorsRecord.Color4 = 268435703;
				escherContainerRecord.AddChildRecord(escherDggRecord);
				if (escherContainerRecord2 != null)
				{
					escherContainerRecord.AddChildRecord(escherContainerRecord2);
				}
				escherContainerRecord.AddChildRecord(escherOptRecord);
				escherContainerRecord.AddChildRecord(escherSplitMenuColorsRecord);
				int num = this.FindFirstRecordLocBySid(235);
				if (num == -1)
				{
					global::NPOI.HSSF.Record.DrawingGroupRecord drawingGroupRecord = new global::NPOI.HSSF.Record.DrawingGroupRecord();
					drawingGroupRecord.AddEscherRecord(escherContainerRecord);
					int num2 = this.FindFirstRecordLocBySid(140);
					this.Records.Insert(num2 + 1, drawingGroupRecord);
					return;
				}
				global::NPOI.HSSF.Record.DrawingGroupRecord drawingGroupRecord2 = new global::NPOI.HSSF.Record.DrawingGroupRecord();
				drawingGroupRecord2.AddEscherRecord(escherContainerRecord);
				this.Records[num] = drawingGroupRecord2;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001877 RID: 6263 RVA: 0x0004AE1F File Offset: 0x0004901F
		public global::NPOI.HSSF.Record.WindowOneRecord WindowOne
		{
			get
			{
				return this.windowOne;
			}
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x0004AE27 File Offset: 0x00049027
		public void RemoveFontRecord(global::NPOI.HSSF.Record.FontRecord rec)
		{
			this.records.Remove(rec);
			this.numfonts--;
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x0004AE43 File Offset: 0x00049043
		public void RemoveExFormatRecord(global::NPOI.HSSF.Record.ExtendedFormatRecord rec)
		{
			this.records.Remove(rec);
			this.numxfs--;
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x0004AE60 File Offset: 0x00049060
		public void RemoveExFormatRecord(int index)
		{
			int pos = this.records.Xfpos - (this.numxfs - 1) + index;
			this.records.Remove(pos);
			this.numxfs--;
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x0004AE9E File Offset: 0x0004909E
		public global::NPOI.DDF.EscherBSERecord GetBSERecord(int pictureIndex)
		{
			return (global::NPOI.DDF.EscherBSERecord)this.escherBSERecords[pictureIndex - 1];
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x0004AEB4 File Offset: 0x000490B4
		public int AddBSERecord(global::NPOI.DDF.EscherBSERecord e)
		{
			this.CreateDrawingGroup();
			this.escherBSERecords.Add(e);
			int index = this.FindFirstRecordLocBySid(235);
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord = (global::NPOI.DDF.EscherContainerRecord)((global::NPOI.HSSF.Record.DrawingGroupRecord)this.Records[index]).GetEscherRecord(0);
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord2;
			if (escherContainerRecord.GetChild(1).RecordId == -4095)
			{
				escherContainerRecord2 = (global::NPOI.DDF.EscherContainerRecord)escherContainerRecord.GetChild(1);
			}
			else
			{
				escherContainerRecord2 = new global::NPOI.DDF.EscherContainerRecord();
				escherContainerRecord2.RecordId = -4095;
				global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord> childRecords = escherContainerRecord.ChildRecords;
				childRecords.Insert(1, escherContainerRecord2);
				escherContainerRecord.ChildRecords = childRecords;
			}
			escherContainerRecord2.Options = (short)(this.escherBSERecords.Count << 4 | 15);
			escherContainerRecord2.AddChildRecord(e);
			return this.escherBSERecords.Count;
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x0600187D RID: 6269 RVA: 0x0004AF6F File Offset: 0x0004916F
		public global::NPOI.HSSF.Model.DrawingManager2 DrawingManager
		{
			get
			{
				return this.drawingManager;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x0004AF78 File Offset: 0x00049178
		public global::NPOI.HSSF.Record.WriteProtectRecord WriteProtect
		{
			get
			{
				if (this.writeProtect == null)
				{
					this.writeProtect = new global::NPOI.HSSF.Record.WriteProtectRecord();
					int num = 0;
					while (num < this.records.Count && !(this.records[num] is global::NPOI.HSSF.Record.BOFRecord))
					{
						num++;
					}
					this.records.Add(num + 1, this.writeProtect);
				}
				return this.writeProtect;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x0600187F RID: 6271 RVA: 0x0004AFE0 File Offset: 0x000491E0
		public global::NPOI.HSSF.Record.WriteAccessRecord WriteAccess
		{
			get
			{
				if (this.writeAccess == null)
				{
					this.writeAccess = (global::NPOI.HSSF.Record.WriteAccessRecord)global::NPOI.HSSF.Model.InternalWorkbook.CreateWriteAccess();
					int num = 0;
					while (num < this.records.Count && !(this.records[num] is global::NPOI.HSSF.Record.InterfaceEndRecord))
					{
						num++;
					}
					this.records.Add(num + 1, this.writeAccess);
				}
				return this.writeAccess;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x0004B04C File Offset: 0x0004924C
		public global::NPOI.HSSF.Record.FileSharingRecord FileSharing
		{
			get
			{
				if (this.fileShare == null)
				{
					this.fileShare = new global::NPOI.HSSF.Record.FileSharingRecord();
					int num = 0;
					while (num < this.records.Count && !(this.records[num] is global::NPOI.HSSF.Record.WriteAccessRecord))
					{
						num++;
					}
					this.records.Add(num + 1, this.fileShare);
				}
				return this.fileShare;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001881 RID: 6273 RVA: 0x0004B0B1 File Offset: 0x000492B1
		public bool IsWriteProtected
		{
			get
			{
				return this.fileShare != null && this.FileSharing.ReadOnly == 1;
			}
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x0004B0CC File Offset: 0x000492CC
		public void WriteProtectWorkbook(string password, string username)
		{
			global::NPOI.HSSF.Record.FileSharingRecord fileSharing = this.FileSharing;
			global::NPOI.HSSF.Record.WriteAccessRecord writeAccessRecord = this.WriteAccess;
			fileSharing.ReadOnly = 1;
			fileSharing.Password = (short)global::NPOI.POIFS.Crypt.CryptoFunctions.CreateXorVerifier1(password);
			fileSharing.Username = username;
			writeAccessRecord.Username = username;
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x0004B107 File Offset: 0x00049307
		public void UnwriteProtectWorkbook()
		{
			this.records.Remove(this.fileShare);
			this.records.Remove(this.WriteProtect);
			this.fileShare = null;
			this.writeProtect = null;
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x0004B139 File Offset: 0x00049339
		public string ResolveNameXText(int reFindex, int definedNameIndex)
		{
			return this.linkTable.ResolveNameXText(reFindex, definedNameIndex, this);
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x0004B14C File Offset: 0x0004934C
		public global::NPOI.HSSF.Record.NameRecord CloneFilter(int filterDbNameIndex, int newSheetIndex)
		{
			global::NPOI.HSSF.Record.NameRecord nameRecord = this.GetNameRecord(filterDbNameIndex);
			int externSheetIndex = this.CheckExternSheet(newSheetIndex);
			global::NPOI.SS.Formula.PTG.Ptg[] nameDefinition = nameRecord.NameDefinition;
			for (int i = 0; i < nameDefinition.Length; i++)
			{
				global::NPOI.SS.Formula.PTG.Ptg ptg = nameDefinition[i];
				if (ptg is global::NPOI.SS.Formula.PTG.Area3DPtg)
				{
					global::NPOI.SS.Formula.PTG.Area3DPtg area3DPtg = (global::NPOI.SS.Formula.PTG.Area3DPtg)((global::NPOI.SS.Formula.PTG.OperandPtg)ptg).Copy();
					area3DPtg.ExternSheetIndex = externSheetIndex;
					nameDefinition[i] = area3DPtg;
				}
				else if (ptg is global::NPOI.SS.Formula.PTG.Ref3DPtg)
				{
					global::NPOI.SS.Formula.PTG.Ref3DPtg ref3DPtg = (global::NPOI.SS.Formula.PTG.Ref3DPtg)((global::NPOI.SS.Formula.PTG.OperandPtg)ptg).Copy();
					ref3DPtg.ExternSheetIndex = externSheetIndex;
					nameDefinition[i] = ref3DPtg;
				}
			}
			global::NPOI.HSSF.Record.NameRecord nameRecord2 = this.CreateBuiltInName(13, newSheetIndex + 1);
			nameRecord2.NameDefinition = nameDefinition;
			nameRecord2.IsHiddenName = true;
			return nameRecord2;
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x0004B1EC File Offset: 0x000493EC
		public void UpdateNamesAfterCellShift(global::NPOI.SS.Formula.FormulaShifter shifter)
		{
			for (int i = 0; i < this.NumNames; i++)
			{
				global::NPOI.HSSF.Record.NameRecord nameRecord = this.GetNameRecord(i);
				global::NPOI.SS.Formula.PTG.Ptg[] nameDefinition = nameRecord.NameDefinition;
				if (shifter.AdjustFormula(nameDefinition, nameRecord.SheetNumber))
				{
					nameRecord.NameDefinition = nameDefinition;
				}
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x0004B230 File Offset: 0x00049430
		public global::NPOI.HSSF.Record.RecalcIdRecord RecalcId
		{
			get
			{
				global::NPOI.HSSF.Record.RecalcIdRecord recalcIdRecord = (global::NPOI.HSSF.Record.RecalcIdRecord)this.FindFirstRecordBySid(449);
				if (recalcIdRecord == null)
				{
					recalcIdRecord = new global::NPOI.HSSF.Record.RecalcIdRecord();
					int num = this.FindFirstRecordLocBySid(140);
					this.records.Add(num + 1, recalcIdRecord);
				}
				return recalcIdRecord;
			}
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x0004B273 File Offset: 0x00049473
		public bool ChangeExternalReference(string oldUrl, string newUrl)
		{
			return this.linkTable.ChangeExternalReference(oldUrl, newUrl);
		}

		// Token: 0x040009C9 RID: 2505
		private const int MAX_SENSITIVE_SHEET_NAME_LEN = 31;

		// Token: 0x040009CA RID: 2506
		public static readonly string[] WORKBOOK_DIR_ENTRY_NAMES = new string[]
		{
			"Workbook",
			"WORKBOOK",
			"BOOK"
		};

		// Token: 0x040009CB RID: 2507
		public static string OLD_WORKBOOK_DIR_ENTRY_NAME = "Book";

		// Token: 0x040009CC RID: 2508
		private const short CODEPAGE = 1200;

		// Token: 0x040009CD RID: 2509
		[global::System.NonSerialized]
		protected global::NPOI.HSSF.Model.WorkbookRecordList records = new global::NPOI.HSSF.Model.WorkbookRecordList();

		// Token: 0x040009CE RID: 2510
		[global::System.NonSerialized]
		protected global::NPOI.HSSF.Record.SSTRecord sst;

		// Token: 0x040009CF RID: 2511
		[global::System.NonSerialized]
		private global::NPOI.HSSF.Model.LinkTable linkTable;

		// Token: 0x040009D0 RID: 2512
		protected global::System.Collections.Generic.List<global::NPOI.HSSF.Record.BoundSheetRecord> boundsheets;

		// Token: 0x040009D1 RID: 2513
		protected global::System.Collections.Generic.List<global::NPOI.HSSF.Record.FormatRecord> formats;

		// Token: 0x040009D2 RID: 2514
		protected global::System.Collections.Generic.List<global::NPOI.HSSF.Record.HyperlinkRecord> hyperlinks;

		// Token: 0x040009D3 RID: 2515
		protected int numxfs;

		// Token: 0x040009D4 RID: 2516
		protected int numfonts;

		// Token: 0x040009D5 RID: 2517
		private int maxformatid = -1;

		// Token: 0x040009D6 RID: 2518
		private bool uses1904datewindowing;

		// Token: 0x040009D7 RID: 2519
		[global::System.NonSerialized]
		private global::NPOI.HSSF.Model.DrawingManager2 drawingManager;

		// Token: 0x040009D8 RID: 2520
		private global::System.Collections.IList escherBSERecords;

		// Token: 0x040009D9 RID: 2521
		[global::System.NonSerialized]
		private global::NPOI.HSSF.Record.WindowOneRecord windowOne;

		// Token: 0x040009DA RID: 2522
		[global::System.NonSerialized]
		private global::NPOI.HSSF.Record.FileSharingRecord fileShare;

		// Token: 0x040009DB RID: 2523
		[global::System.NonSerialized]
		private global::NPOI.HSSF.Record.WriteAccessRecord writeAccess;

		// Token: 0x040009DC RID: 2524
		[global::System.NonSerialized]
		private global::NPOI.HSSF.Record.WriteProtectRecord writeProtect;

		// Token: 0x040009DD RID: 2525
		private global::System.Collections.Generic.Dictionary<string, global::NPOI.HSSF.Record.NameCommentRecord> commentRecords;
	}
}
