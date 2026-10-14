using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using NPOI.HSSF.Record.AutoFilter;
using NPOI.HSSF.Record.Chart;
using NPOI.HSSF.Record.PivotTable;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200040F RID: 1039
	public class RecordFactory
	{
		// Token: 0x060025DC RID: 9692 RVA: 0x0007158C File Offset: 0x0006F78C
		static RecordFactory()
		{
			global::NPOI.HSSF.Record.RecordFactory.recordClasses = new global::System.Type[]
			{
				typeof(global::NPOI.HSSF.Record.ArrayRecord),
				typeof(global::NPOI.HSSF.Record.AutoFilter.AutoFilterInfoRecord),
				typeof(global::NPOI.HSSF.Record.BackupRecord),
				typeof(global::NPOI.HSSF.Record.BlankRecord),
				typeof(global::NPOI.HSSF.Record.BOFRecord),
				typeof(global::NPOI.HSSF.Record.BookBoolRecord),
				typeof(global::NPOI.HSSF.Record.BoolErrRecord),
				typeof(global::NPOI.HSSF.Record.BottomMarginRecord),
				typeof(global::NPOI.HSSF.Record.BoundSheetRecord),
				typeof(global::NPOI.HSSF.Record.CalcCountRecord),
				typeof(global::NPOI.HSSF.Record.CalcModeRecord),
				typeof(global::NPOI.HSSF.Record.CFHeaderRecord),
				typeof(global::NPOI.HSSF.Record.CFHeader12Record),
				typeof(global::NPOI.HSSF.Record.CFRuleRecord),
				typeof(global::NPOI.HSSF.Record.CFRule12Record),
				typeof(global::NPOI.HSSF.Record.Chart.ChartRecord),
				typeof(global::NPOI.HSSF.Record.Chart.AlRunsRecord),
				typeof(global::NPOI.HSSF.Record.CodepageRecord),
				typeof(global::NPOI.HSSF.Record.ColumnInfoRecord),
				typeof(global::NPOI.HSSF.Record.ContinueRecord),
				typeof(global::NPOI.HSSF.Record.CountryRecord),
				typeof(global::NPOI.HSSF.Record.CRNCountRecord),
				typeof(global::NPOI.HSSF.Record.CRNRecord),
				typeof(global::NPOI.HSSF.Record.DateWindow1904Record),
				typeof(global::NPOI.HSSF.Record.DBCellRecord),
				typeof(global::NPOI.HSSF.Record.DConRefRecord),
				typeof(global::NPOI.HSSF.Record.DefaultColWidthRecord),
				typeof(global::NPOI.HSSF.Record.DefaultRowHeightRecord),
				typeof(global::NPOI.HSSF.Record.DeltaRecord),
				typeof(global::NPOI.HSSF.Record.DimensionsRecord),
				typeof(global::NPOI.HSSF.Record.DrawingGroupRecord),
				typeof(global::NPOI.HSSF.Record.DrawingRecord),
				typeof(global::NPOI.HSSF.Record.DrawingSelectionRecord),
				typeof(global::NPOI.HSSF.Record.DSFRecord),
				typeof(global::NPOI.HSSF.Record.DVALRecord),
				typeof(global::NPOI.HSSF.Record.DVRecord),
				typeof(global::NPOI.HSSF.Record.EOFRecord),
				typeof(global::NPOI.HSSF.Record.ExtendedFormatRecord),
				typeof(global::NPOI.HSSF.Record.ExternalNameRecord),
				typeof(global::NPOI.HSSF.Record.ExternSheetRecord),
				typeof(global::NPOI.HSSF.Record.ExtSSTRecord),
				typeof(global::NPOI.HSSF.Record.FilePassRecord),
				typeof(global::NPOI.HSSF.Record.FileSharingRecord),
				typeof(global::NPOI.HSSF.Record.FnGroupCountRecord),
				typeof(global::NPOI.HSSF.Record.FontRecord),
				typeof(global::NPOI.HSSF.Record.FooterRecord),
				typeof(global::NPOI.HSSF.Record.FormatRecord),
				typeof(global::NPOI.HSSF.Record.FormulaRecord),
				typeof(global::NPOI.HSSF.Record.GridsetRecord),
				typeof(global::NPOI.HSSF.Record.GutsRecord),
				typeof(global::NPOI.HSSF.Record.HCenterRecord),
				typeof(global::NPOI.HSSF.Record.HeaderRecord),
				typeof(global::NPOI.HSSF.Record.HeaderFooterRecord),
				typeof(global::NPOI.HSSF.Record.HideObjRecord),
				typeof(global::NPOI.HSSF.Record.HorizontalPageBreakRecord),
				typeof(global::NPOI.HSSF.Record.HyperlinkRecord),
				typeof(global::NPOI.HSSF.Record.IndexRecord),
				typeof(global::NPOI.HSSF.Record.InterfaceEndRecord),
				typeof(global::NPOI.HSSF.Record.InterfaceHdrRecord),
				typeof(global::NPOI.HSSF.Record.IterationRecord),
				typeof(global::NPOI.HSSF.Record.LabelRecord),
				typeof(global::NPOI.HSSF.Record.LabelSSTRecord),
				typeof(global::NPOI.HSSF.Record.LeftMarginRecord),
				typeof(global::NPOI.HSSF.Record.MergeCellsRecord),
				typeof(global::NPOI.HSSF.Record.MMSRecord),
				typeof(global::NPOI.HSSF.Record.MulBlankRecord),
				typeof(global::NPOI.HSSF.Record.MulRKRecord),
				typeof(global::NPOI.HSSF.Record.NameRecord),
				typeof(global::NPOI.HSSF.Record.NameCommentRecord),
				typeof(global::NPOI.HSSF.Record.NoteRecord),
				typeof(global::NPOI.HSSF.Record.NumberRecord),
				typeof(global::NPOI.HSSF.Record.ObjectProtectRecord),
				typeof(global::NPOI.HSSF.Record.ObjRecord),
				typeof(global::NPOI.HSSF.Record.PaletteRecord),
				typeof(global::NPOI.HSSF.Record.PaneRecord),
				typeof(global::NPOI.HSSF.Record.PasswordRecord),
				typeof(global::NPOI.HSSF.Record.PasswordRev4Record),
				typeof(global::NPOI.HSSF.Record.PrecisionRecord),
				typeof(global::NPOI.HSSF.Record.PrintGridlinesRecord),
				typeof(global::NPOI.HSSF.Record.PrintHeadersRecord),
				typeof(global::NPOI.HSSF.Record.PrintSetupRecord),
				typeof(global::NPOI.HSSF.Record.PrintSizeRecord),
				typeof(global::NPOI.HSSF.Record.ProtectionRev4Record),
				typeof(global::NPOI.HSSF.Record.ProtectRecord),
				typeof(global::NPOI.HSSF.Record.RecalcIdRecord),
				typeof(global::NPOI.HSSF.Record.RefModeRecord),
				typeof(global::NPOI.HSSF.Record.RefreshAllRecord),
				typeof(global::NPOI.HSSF.Record.RightMarginRecord),
				typeof(global::NPOI.HSSF.Record.RKRecord),
				typeof(global::NPOI.HSSF.Record.RowRecord),
				typeof(global::NPOI.HSSF.Record.SaveRecalcRecord),
				typeof(global::NPOI.HSSF.Record.ScenarioProtectRecord),
				typeof(global::NPOI.HSSF.Record.SCLRecord),
				typeof(global::NPOI.HSSF.Record.SelectionRecord),
				typeof(global::NPOI.HSSF.Record.Chart.SeriesRecord),
				typeof(global::NPOI.HSSF.Record.Chart.SeriesTextRecord),
				typeof(global::NPOI.HSSF.Record.SharedFormulaRecord),
				typeof(global::NPOI.HSSF.Record.SSTRecord),
				typeof(global::NPOI.HSSF.Record.StringRecord),
				typeof(global::NPOI.HSSF.Record.StyleRecord),
				typeof(global::NPOI.HSSF.Record.SupBookRecord),
				typeof(global::NPOI.HSSF.Record.TabIdRecord),
				typeof(global::NPOI.HSSF.Record.TableRecord),
				typeof(global::NPOI.HSSF.Record.TableStylesRecord),
				typeof(global::NPOI.HSSF.Record.TextObjectRecord),
				typeof(global::NPOI.HSSF.Record.TopMarginRecord),
				typeof(global::NPOI.HSSF.Record.UncalcedRecord),
				typeof(global::NPOI.HSSF.Record.UseSelFSRecord),
				typeof(global::NPOI.HSSF.Record.UserSViewBegin),
				typeof(global::NPOI.HSSF.Record.UserSViewEnd),
				typeof(global::NPOI.HSSF.Record.Chart.ValueRangeRecord),
				typeof(global::NPOI.HSSF.Record.VCenterRecord),
				typeof(global::NPOI.HSSF.Record.VerticalPageBreakRecord),
				typeof(global::NPOI.HSSF.Record.WindowOneRecord),
				typeof(global::NPOI.HSSF.Record.WindowProtectRecord),
				typeof(global::NPOI.HSSF.Record.WindowTwoRecord),
				typeof(global::NPOI.HSSF.Record.WriteAccessRecord),
				typeof(global::NPOI.HSSF.Record.WriteProtectRecord),
				typeof(global::NPOI.HSSF.Record.WSBoolRecord),
				typeof(global::NPOI.HSSF.Record.SheetExtRecord),
				typeof(global::NPOI.HSSF.Record.Chart.AreaFormatRecord),
				typeof(global::NPOI.HSSF.Record.Chart.AreaRecord),
				typeof(global::NPOI.HSSF.Record.Chart.AttachedLabelRecord),
				typeof(global::NPOI.HSSF.Record.Chart.AxcExtRecord),
				typeof(global::NPOI.HSSF.Record.Chart.AxisLineFormatRecord),
				typeof(global::NPOI.HSSF.Record.Chart.AxisParentRecord),
				typeof(global::NPOI.HSSF.Record.Chart.AxisRecord),
				typeof(global::NPOI.HSSF.Record.Chart.AxesUsedRecord),
				typeof(global::NPOI.HSSF.Record.Chart.BarRecord),
				typeof(global::NPOI.HSSF.Record.Chart.BeginRecord),
				typeof(global::NPOI.HSSF.Record.Chart.BopPopCustomRecord),
				typeof(global::NPOI.HSSF.Record.Chart.BopPopRecord),
				typeof(global::NPOI.HSSF.Record.Chart.CatLabRecord),
				typeof(global::NPOI.HSSF.Record.Chart.CatSerRangeRecord),
				typeof(global::NPOI.HSSF.Record.Chart.Chart3DBarShapeRecord),
				typeof(global::NPOI.HSSF.Record.Chart.Chart3dRecord),
				typeof(global::NPOI.HSSF.Record.Chart.ChartEndObjectRecord),
				typeof(global::NPOI.HSSF.Record.ChartFormatRecord),
				typeof(global::NPOI.HSSF.Record.Chart.ChartFRTInfoRecord),
				typeof(global::NPOI.HSSF.Record.Chart.ChartStartObjectRecord),
				typeof(global::NPOI.HSSF.Record.Chart.CrtLayout12ARecord),
				typeof(global::NPOI.HSSF.Record.Chart.CrtLayout12Record),
				typeof(global::NPOI.HSSF.Record.Chart.CrtLineRecord),
				typeof(global::NPOI.HSSF.Record.Chart.CrtLinkRecord),
				typeof(global::NPOI.HSSF.Record.Chart.CrtMlFrtContinueRecord),
				typeof(global::NPOI.HSSF.Record.Chart.CrtMlFrtRecord),
				typeof(global::NPOI.HSSF.Record.Chart.DataFormatRecord),
				typeof(global::NPOI.HSSF.Record.Chart.DataLabExtContentsRecord),
				typeof(global::NPOI.HSSF.Record.Chart.DataLabExtRecord),
				typeof(global::NPOI.HSSF.Record.Chart.DatRecord),
				typeof(global::NPOI.HSSF.Record.Chart.DefaultTextRecord),
				typeof(global::NPOI.HSSF.Record.Chart.DropBarRecord),
				typeof(global::NPOI.HSSF.Record.Chart.EndBlockRecord),
				typeof(global::NPOI.HSSF.Record.Chart.EndRecord),
				typeof(global::NPOI.HSSF.Record.Chart.LinkedDataRecord),
				typeof(global::NPOI.HSSF.Record.Chart.Fbi2Record),
				typeof(global::NPOI.HSSF.Record.Chart.FbiRecord),
				typeof(global::NPOI.HSSF.Record.Chart.FontIndexRecord),
				typeof(global::NPOI.HSSF.Record.Chart.FrameRecord),
				typeof(global::NPOI.HSSF.Record.Chart.FrtFontListRecord),
				typeof(global::NPOI.HSSF.Record.Chart.GelFrameRecord),
				typeof(global::NPOI.HSSF.Record.Chart.IFmtRecordRecord),
				typeof(global::NPOI.HSSF.Record.Chart.LegendExceptionRecord),
				typeof(global::NPOI.HSSF.Record.Chart.LegendRecord),
				typeof(global::NPOI.HSSF.Record.Chart.LineFormatRecord),
				typeof(global::NPOI.HSSF.Record.Chart.MarkerFormatRecord),
				typeof(global::NPOI.HSSF.Record.Chart.ObjectLinkRecord),
				typeof(global::NPOI.HSSF.Record.Chart.PicFRecord),
				typeof(global::NPOI.HSSF.Record.Chart.PieFormatRecord),
				typeof(global::NPOI.HSSF.Record.Chart.PieRecord),
				typeof(global::NPOI.HSSF.Record.Chart.PlotAreaRecord),
				typeof(global::NPOI.HSSF.Record.Chart.PlotGrowthRecord),
				typeof(global::NPOI.HSSF.Record.Chart.PosRecord),
				typeof(global::NPOI.HSSF.Record.Chart.RadarAreaRecord),
				typeof(global::NPOI.HSSF.Record.Chart.RadarRecord),
				typeof(global::NPOI.HSSF.Record.Chart.RichTextStreamRecord),
				typeof(global::NPOI.HSSF.Record.Chart.ScatterRecord),
				typeof(global::NPOI.HSSF.Record.Chart.SerAuxErrBarRecord),
				typeof(global::NPOI.HSSF.Record.Chart.SerAuxTrendRecord),
				typeof(global::NPOI.HSSF.Record.Chart.SerFmtRecord),
				typeof(global::NPOI.HSSF.Record.Chart.SeriesIndexRecord),
				typeof(global::NPOI.HSSF.Record.Chart.SeriesListRecord),
				typeof(global::NPOI.HSSF.Record.Chart.SerParentRecord),
				typeof(global::NPOI.HSSF.Record.Chart.SerToCrtRecord),
				typeof(global::NPOI.HSSF.Record.Chart.ShapePropsStreamRecord),
				typeof(global::NPOI.HSSF.Record.Chart.ShtPropsRecord),
				typeof(global::NPOI.HSSF.Record.Chart.StartBlockRecord),
				typeof(global::NPOI.HSSF.Record.Chart.SurfRecord),
				typeof(global::NPOI.HSSF.Record.Chart.TextPropsStreamRecord),
				typeof(global::NPOI.HSSF.Record.TextRecord),
				typeof(global::NPOI.HSSF.Record.TickRecord),
				typeof(global::NPOI.HSSF.Record.UnitsRecord),
				typeof(global::NPOI.HSSF.Record.Chart.YMultRecord),
				typeof(global::NPOI.HSSF.Record.PivotTable.DataItemRecord),
				typeof(global::NPOI.HSSF.Record.PivotTable.ExtendedPivotTableViewFieldsRecord),
				typeof(global::NPOI.HSSF.Record.PivotTable.PageItemRecord),
				typeof(global::NPOI.HSSF.Record.PivotTable.StreamIDRecord),
				typeof(global::NPOI.HSSF.Record.PivotTable.ViewDefinitionRecord),
				typeof(global::NPOI.HSSF.Record.PivotTable.ViewFieldsRecord),
				typeof(global::NPOI.HSSF.Record.PivotTable.ViewSourceRecord),
				typeof(global::NPOI.HSSF.Record.AutoFilter.AutoFilterRecord),
				typeof(global::NPOI.HSSF.Record.AutoFilter.FilterModeRecord),
				typeof(global::NPOI.HSSF.Record.Excel9FileRecord)
			};
			global::NPOI.HSSF.Record.RecordFactory._recordCreatorsById = global::NPOI.HSSF.Record.RecordFactory.RecordsToMap(global::NPOI.HSSF.Record.RecordFactory.recordClasses);
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x000721D4 File Offset: 0x000703D4
		public static global::System.Type GetRecordClass(int sid)
		{
			global::NPOI.HSSF.Record.RecordFactory.I_RecordCreator i_RecordCreator = null;
			if (global::NPOI.HSSF.Record.RecordFactory._recordCreatorsById.ContainsKey((short)sid))
			{
				i_RecordCreator = global::NPOI.HSSF.Record.RecordFactory._recordCreatorsById[(short)sid];
			}
			if (i_RecordCreator == null)
			{
				return null;
			}
			return i_RecordCreator.GetRecordClass();
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x00072209 File Offset: 0x00070409
		public static void SetCapacity(int capacity)
		{
			global::NPOI.HSSF.Record.RecordFactory.NUM_RECORDS = capacity;
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x00072214 File Offset: 0x00070414
		public static global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record> CreateRecords(global::System.IO.Stream in1)
		{
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record>(global::NPOI.HSSF.Record.RecordFactory.NUM_RECORDS);
			global::NPOI.HSSF.Record.RecordFactoryInputStream recordFactoryInputStream = new global::NPOI.HSSF.Record.RecordFactoryInputStream(in1, true);
			global::NPOI.HSSF.Record.Record item;
			while ((item = recordFactoryInputStream.NextRecord()) != null)
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x00072248 File Offset: 0x00070448
		[global::System.Obsolete]
		private static void AddAll(global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record> destList, global::NPOI.HSSF.Record.Record[] srcRecs)
		{
			for (int i = 0; i < srcRecs.Length; i++)
			{
				destList.Add(srcRecs[i]);
			}
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x0007226C File Offset: 0x0007046C
		public static global::NPOI.HSSF.Record.Record[] CreateRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			global::NPOI.HSSF.Record.Record record = global::NPOI.HSSF.Record.RecordFactory.CreateSingleRecord(in1);
			if (record is global::NPOI.HSSF.Record.DBCellRecord)
			{
				return new global::NPOI.HSSF.Record.Record[1];
			}
			if (record is global::NPOI.HSSF.Record.RKRecord)
			{
				return new global::NPOI.HSSF.Record.Record[]
				{
					global::NPOI.HSSF.Record.RecordFactory.ConvertToNumberRecord((global::NPOI.HSSF.Record.RKRecord)record)
				};
			}
			if (record is global::NPOI.HSSF.Record.MulRKRecord)
			{
				return global::NPOI.HSSF.Record.RecordFactory.ConvertRKRecords((global::NPOI.HSSF.Record.MulRKRecord)record);
			}
			return new global::NPOI.HSSF.Record.Record[]
			{
				record
			};
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x000722CC File Offset: 0x000704CC
		public static global::NPOI.HSSF.Record.BlankRecord[] ConvertBlankRecords(global::NPOI.HSSF.Record.MulBlankRecord mbk)
		{
			global::NPOI.HSSF.Record.BlankRecord[] array = new global::NPOI.HSSF.Record.BlankRecord[mbk.NumColumns];
			for (int i = 0; i < mbk.NumColumns; i++)
			{
				array[i] = new global::NPOI.HSSF.Record.BlankRecord
				{
					Column = i + mbk.FirstColumn,
					Row = mbk.Row,
					XFIndex = mbk.GetXFAt(i)
				};
			}
			return array;
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x00072328 File Offset: 0x00070528
		public static global::NPOI.HSSF.Record.Record CreateSingleRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			if (global::NPOI.HSSF.Record.RecordFactory._recordCreatorsById.ContainsKey(in1.Sid))
			{
				return global::NPOI.HSSF.Record.RecordFactory._recordCreatorsById[in1.Sid].Create(in1);
			}
			return new global::NPOI.HSSF.Record.UnknownRecord(in1);
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x00072359 File Offset: 0x00070559
		public static global::NPOI.HSSF.Record.NumberRecord ConvertToNumberRecord(global::NPOI.HSSF.Record.RKRecord rk)
		{
			return new global::NPOI.HSSF.Record.NumberRecord
			{
				Column = rk.Column,
				Row = rk.Row,
				XFIndex = rk.XFIndex,
				Value = rk.RKNumber
			};
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x00072390 File Offset: 0x00070590
		public static global::NPOI.HSSF.Record.NumberRecord[] ConvertRKRecords(global::NPOI.HSSF.Record.MulRKRecord mrk)
		{
			global::NPOI.HSSF.Record.NumberRecord[] array = new global::NPOI.HSSF.Record.NumberRecord[mrk.NumColumns];
			for (int i = 0; i < mrk.NumColumns; i++)
			{
				array[i] = new global::NPOI.HSSF.Record.NumberRecord
				{
					Column = (int)((short)(i + (int)mrk.FirstColumn)),
					Row = mrk.Row,
					XFIndex = mrk.GetXFAt(i),
					Value = mrk.GetRKNumberAt(i)
				};
			}
			return array;
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x000723FC File Offset: 0x000705FC
		public static short[] GetAllKnownRecordSIDs()
		{
			if (global::NPOI.HSSF.Record.RecordFactory._allKnownRecordSIDs == null)
			{
				short[] array = new short[global::NPOI.HSSF.Record.RecordFactory._recordCreatorsById.Count];
				int num = 0;
				foreach (global::System.Collections.Generic.KeyValuePair<short, global::NPOI.HSSF.Record.RecordFactory.I_RecordCreator> keyValuePair in global::NPOI.HSSF.Record.RecordFactory._recordCreatorsById)
				{
					array[num++] = keyValuePair.Key;
				}
				global::System.Array.Sort<short>(array);
				global::NPOI.HSSF.Record.RecordFactory._allKnownRecordSIDs = array;
			}
			return (short[])global::NPOI.HSSF.Record.RecordFactory._allKnownRecordSIDs.Clone();
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x0007248C File Offset: 0x0007068C
		private static global::System.Collections.Generic.Dictionary<short, global::NPOI.HSSF.Record.RecordFactory.I_RecordCreator> RecordsToMap(global::System.Type[] records)
		{
			global::System.Collections.Generic.Dictionary<short, global::NPOI.HSSF.Record.RecordFactory.I_RecordCreator> dictionary = new global::System.Collections.Generic.Dictionary<short, global::NPOI.HSSF.Record.RecordFactory.I_RecordCreator>();
			global::System.Collections.Hashtable hashtable = new global::System.Collections.Hashtable(records.Length * 3 / 2);
			foreach (global::System.Type type in records)
			{
				if (!typeof(global::NPOI.HSSF.Record.Record).IsAssignableFrom(type))
				{
					throw new global::System.Exception("Invalid record sub-class (" + type.Name + ")");
				}
				if (type.IsAbstract)
				{
					throw new global::System.Exception("Invalid record class (" + type.Name + ") - must not be abstract");
				}
				if (hashtable.Contains(type))
				{
					throw new global::System.Exception("duplicate record class (" + type.Name + ")");
				}
				hashtable.Add(type, type);
				short key = 0;
				try
				{
					key = (short)type.GetField("sid").GetValue(null);
				}
				catch (global::System.Exception ex)
				{
					throw new global::NPOI.Util.RecordFormatException("Unable to determine record types", ex);
				}
				if (dictionary.ContainsKey(key))
				{
					global::System.Type recordClass = dictionary[key].GetRecordClass();
					throw new global::NPOI.Util.RuntimeException(string.Concat(new string[]
					{
						"duplicate record sid 0x",
						key.ToString("X", global::System.Globalization.CultureInfo.CurrentCulture),
						" for classes (",
						type.Name,
						") and (",
						recordClass.Name,
						")"
					}));
				}
				dictionary[key] = global::NPOI.HSSF.Record.RecordFactory.GetRecordCreator(type);
			}
			return dictionary;
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x000725FC File Offset: 0x000707FC
		[global::System.Obsolete]
		private static void CheckZeros(global::System.IO.Stream in1, int avail)
		{
			int num = 0;
			for (;;)
			{
				int num2 = in1.ReadByte();
				if (num2 < 0)
				{
					break;
				}
				if (num2 != 0)
				{
					global::System.Console.Error.WriteLine(global::NPOI.Util.HexDump.ByteToHex(num2));
				}
				num++;
			}
			if (avail != num)
			{
				global::System.Console.Error.WriteLine(string.Concat(new string[]
				{
					"avail!=count (",
					avail.ToString(),
					"!=",
					num.ToString(),
					")."
				}));
			}
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x00072674 File Offset: 0x00070874
		private static global::NPOI.HSSF.Record.RecordFactory.I_RecordCreator GetRecordCreator(global::System.Type recClass)
		{
			try
			{
				global::System.Reflection.ConstructorInfo constructor = recClass.GetConstructor(global::NPOI.HSSF.Record.RecordFactory.CONSTRUCTOR_ARGS);
				if (constructor != null)
				{
					return new global::NPOI.HSSF.Record.RecordFactory.ReflectionConstructorRecordCreator(constructor);
				}
			}
			catch (global::System.Exception)
			{
			}
			global::NPOI.HSSF.Record.RecordFactory.I_RecordCreator result;
			try
			{
				result = new global::NPOI.HSSF.Record.RecordFactory.ReflectionMethodRecordCreator(recClass.GetMethod("Create", global::NPOI.HSSF.Record.RecordFactory.CONSTRUCTOR_ARGS));
			}
			catch (global::System.Exception)
			{
				throw new global::NPOI.Util.RuntimeException("Failed to find constructor or create method for (" + recClass.Name + ").");
			}
			return result;
		}

		// Token: 0x04000FE0 RID: 4064
		private static int NUM_RECORDS = 512;

		// Token: 0x04000FE1 RID: 4065
		private static global::System.Type[] recordClasses;

		// Token: 0x04000FE2 RID: 4066
		private static global::System.Type[] CONSTRUCTOR_ARGS = new global::System.Type[]
		{
			typeof(global::NPOI.HSSF.Record.RecordInputStream)
		};

		// Token: 0x04000FE3 RID: 4067
		private static global::System.Collections.Generic.Dictionary<short, global::NPOI.HSSF.Record.RecordFactory.I_RecordCreator> _recordCreatorsById = null;

		// Token: 0x04000FE4 RID: 4068
		private static short[] _allKnownRecordSIDs;

		// Token: 0x02000613 RID: 1555
		private interface I_RecordCreator
		{
			// Token: 0x0600368A RID: 13962
			global::NPOI.HSSF.Record.Record Create(global::NPOI.HSSF.Record.RecordInputStream in1);

			// Token: 0x0600368B RID: 13963
			global::System.Type GetRecordClass();
		}

		// Token: 0x02000614 RID: 1556
		private class ReflectionConstructorRecordCreator : global::NPOI.HSSF.Record.RecordFactory.I_RecordCreator
		{
			// Token: 0x0600368C RID: 13964 RVA: 0x000A6A30 File Offset: 0x000A4C30
			public ReflectionConstructorRecordCreator(global::System.Reflection.ConstructorInfo c)
			{
				this._c = c;
			}

			// Token: 0x0600368D RID: 13965 RVA: 0x000A6A40 File Offset: 0x000A4C40
			public global::NPOI.HSSF.Record.Record Create(global::NPOI.HSSF.Record.RecordInputStream in1)
			{
				object[] parameters = new object[]
				{
					in1
				};
				global::NPOI.HSSF.Record.Record result;
				try
				{
					result = (global::NPOI.HSSF.Record.Record)this._c.Invoke(parameters);
				}
				catch (global::System.Exception ex)
				{
					throw new global::NPOI.Util.RecordFormatException("Unable to construct record instance", ex.InnerException);
				}
				return result;
			}

			// Token: 0x0600368E RID: 13966 RVA: 0x000A6A90 File Offset: 0x000A4C90
			public global::System.Type GetRecordClass()
			{
				return this._c.DeclaringType;
			}

			// Token: 0x04001A81 RID: 6785
			private global::System.Reflection.ConstructorInfo _c;
		}

		// Token: 0x02000615 RID: 1557
		private class ReflectionMethodRecordCreator : global::NPOI.HSSF.Record.RecordFactory.I_RecordCreator
		{
			// Token: 0x0600368F RID: 13967 RVA: 0x000A6A9D File Offset: 0x000A4C9D
			public ReflectionMethodRecordCreator(global::System.Reflection.MethodInfo m)
			{
				this._m = m;
			}

			// Token: 0x06003690 RID: 13968 RVA: 0x000A6AAC File Offset: 0x000A4CAC
			public global::NPOI.HSSF.Record.Record Create(global::NPOI.HSSF.Record.RecordInputStream in1)
			{
				object[] parameters = new object[]
				{
					in1
				};
				global::NPOI.HSSF.Record.Record result;
				try
				{
					result = (global::NPOI.HSSF.Record.Record)this._m.Invoke(null, parameters);
				}
				catch (global::System.Exception ex)
				{
					throw new global::NPOI.Util.RecordFormatException("Unable to construct record instance", ex.InnerException);
				}
				return result;
			}

			// Token: 0x06003691 RID: 13969 RVA: 0x000A6AFC File Offset: 0x000A4CFC
			public global::System.Type GetRecordClass()
			{
				return this._m.DeclaringType;
			}

			// Token: 0x04001A82 RID: 6786
			private global::System.Reflection.MethodInfo _m;
		}
	}
}
