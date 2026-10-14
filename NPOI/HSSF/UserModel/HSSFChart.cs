using System;
using System.Collections;
using System.Collections.Generic;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.Chart;
using NPOI.SS.Formula.PTG;
using NPOI.SS.Util;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000361 RID: 865
	public class HSSFChart
	{
		// Token: 0x060019C4 RID: 6596 RVA: 0x0004EC19 File Offset: 0x0004CE19
		private HSSFChart(global::NPOI.HSSF.UserModel.HSSFSheet sheet, global::NPOI.HSSF.Record.Chart.ChartRecord chartRecord)
		{
			this.chartRecord = chartRecord;
			this.sheet = sheet;
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x0004EC48 File Offset: 0x0004CE48
		public void CreateBarChart(global::NPOI.HSSF.UserModel.HSSFWorkbook workbook, global::NPOI.HSSF.UserModel.HSSFSheet sheet)
		{
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase>();
			list.Add(this.CreateMSDrawingObjectRecord());
			list.Add(this.CreateOBJRecord());
			list.Add(this.CreateBOFRecord());
			list.Add(new global::NPOI.HSSF.Record.HeaderRecord(string.Empty));
			list.Add(new global::NPOI.HSSF.Record.FooterRecord(string.Empty));
			list.Add(this.CreateHCenterRecord());
			list.Add(this.CreateVCenterRecord());
			list.Add(this.CreatePrintSetupRecord());
			list.Add(this.CreateFontBasisRecord1());
			list.Add(this.CreateFontBasisRecord2());
			list.Add(new global::NPOI.HSSF.Record.ProtectRecord(false));
			list.Add(this.CreateUnitsRecord());
			list.Add(this.CreateChartRecord(0, 0, 30434904, 19031616));
			list.Add(this.CreateBeginRecord());
			list.Add(this.CreateSCLRecord(1, 1));
			list.Add(this.CreatePlotGrowthRecord(65536, 65536));
			list.Add(this.CreateFrameRecord1());
			list.Add(this.CreateBeginRecord());
			list.Add(this.CreateLineFormatRecord(true));
			list.Add(this.CreateAreaFormatRecord1());
			list.Add(this.CreateEndRecord());
			list.Add(this.CreateSeriesRecord());
			list.Add(this.CreateBeginRecord());
			list.Add(this.CreateTitleLinkedDataRecord());
			list.Add(this.CreateValuesLinkedDataRecord());
			list.Add(this.CreateCategoriesLinkedDataRecord());
			list.Add(this.CreateDataFormatRecord());
			list.Add(new global::NPOI.HSSF.Record.Chart.SerToCrtRecord());
			list.Add(this.CreateEndRecord());
			list.Add(this.CreateSheetPropsRecord());
			list.Add(this.CreateDefaultTextRecord(2));
			list.Add(this.CreateAllTextRecord());
			list.Add(this.CreateBeginRecord());
			list.Add(this.CreateFontIndexRecord(5));
			list.Add(this.CreateDirectLinkRecord());
			list.Add(this.CreateEndRecord());
			list.Add(this.CreateDefaultTextRecord(3));
			list.Add(this.CreateUnknownTextRecord());
			list.Add(this.CreateBeginRecord());
			list.Add(this.CreateFontIndexRecord(6));
			list.Add(this.CreateDirectLinkRecord());
			list.Add(this.CreateEndRecord());
			list.Add(this.CreateAxisUsedRecord(1));
			this.CreateAxisRecords(list);
			list.Add(this.CreateEndRecord());
			list.Add(this.CreateDimensionsRecord());
			list.Add(this.CreateSeriesIndexRecord(2));
			list.Add(this.CreateSeriesIndexRecord(1));
			list.Add(this.CreateSeriesIndexRecord(3));
			list.Add(global::NPOI.HSSF.Record.EOFRecord.instance);
			sheet.InsertChartRecords(list);
			workbook.InsertChartRecord();
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x0004EEE4 File Offset: 0x0004D0E4
		public static global::NPOI.HSSF.UserModel.HSSFChart[] GetSheetCharts(global::NPOI.HSSF.UserModel.HSSFSheet sheet)
		{
			global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFChart> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFChart>();
			global::NPOI.HSSF.UserModel.HSSFChart hssfchart = null;
			global::NPOI.HSSF.UserModel.HSSFChart.HSSFSeries hssfseries = null;
			foreach (object obj in ((global::System.Collections.IEnumerable)sheet.Sheet.Records))
			{
				global::NPOI.HSSF.Record.RecordBase recordBase = (global::NPOI.HSSF.Record.RecordBase)obj;
				if (recordBase is global::NPOI.HSSF.Record.Chart.ChartRecord)
				{
					hssfseries = null;
					hssfchart = new global::NPOI.HSSF.UserModel.HSSFChart(sheet, (global::NPOI.HSSF.Record.Chart.ChartRecord)recordBase);
					list.Add(hssfchart);
				}
				else if (recordBase is global::NPOI.HSSF.Record.Chart.LegendRecord)
				{
					hssfchart.legendRecord = (global::NPOI.HSSF.Record.Chart.LegendRecord)recordBase;
				}
				else if (recordBase is global::NPOI.HSSF.Record.Chart.SeriesRecord)
				{
					global::NPOI.HSSF.UserModel.HSSFChart.HSSFSeries hssfseries2 = new global::NPOI.HSSF.UserModel.HSSFChart.HSSFSeries((global::NPOI.HSSF.Record.Chart.SeriesRecord)recordBase);
					hssfchart.series.Add(hssfseries2);
					hssfseries = hssfseries2;
				}
				else if (recordBase is global::NPOI.HSSF.Record.Chart.AlRunsRecord)
				{
					hssfchart.chartTitleFormat = (global::NPOI.HSSF.Record.Chart.AlRunsRecord)recordBase;
				}
				else if (recordBase is global::NPOI.HSSF.Record.Chart.SeriesTextRecord)
				{
					global::NPOI.HSSF.Record.Chart.SeriesTextRecord seriesTitleText = (global::NPOI.HSSF.Record.Chart.SeriesTextRecord)recordBase;
					if (hssfchart.legendRecord == null && hssfchart.series.Count > 0)
					{
						hssfchart.series[hssfchart.series.Count - 1].seriesTitleText = seriesTitleText;
					}
					else
					{
						hssfchart.chartTitleText = seriesTitleText;
					}
				}
				else if (recordBase is global::NPOI.HSSF.Record.Chart.LinkedDataRecord)
				{
					global::NPOI.HSSF.Record.Chart.LinkedDataRecord data = (global::NPOI.HSSF.Record.Chart.LinkedDataRecord)recordBase;
					if (hssfseries != null)
					{
						hssfseries.InsertData(data);
					}
				}
				else if (recordBase is global::NPOI.HSSF.Record.Chart.ValueRangeRecord)
				{
					hssfchart.valueRanges.Add((global::NPOI.HSSF.Record.Chart.ValueRangeRecord)recordBase);
				}
				else if (recordBase is global::NPOI.HSSF.Record.Record && hssfchart != null)
				{
					global::NPOI.HSSF.Record.Record record = (global::NPOI.HSSF.Record.Record)recordBase;
					foreach (object obj2 in global::System.Enum.GetValues(typeof(global::NPOI.HSSF.UserModel.HSSFChartType)))
					{
						int num = (int)obj2;
						if (num != 0 && (int)record.Sid == num)
						{
							hssfchart.type = (global::NPOI.HSSF.UserModel.HSSFChartType)num;
							break;
						}
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x0004F110 File Offset: 0x0004D310
		// (set) Token: 0x060019C8 RID: 6600 RVA: 0x0004F11D File Offset: 0x0004D31D
		public int ChartX
		{
			get
			{
				return this.chartRecord.X;
			}
			set
			{
				this.chartRecord.X = value;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060019C9 RID: 6601 RVA: 0x0004F12B File Offset: 0x0004D32B
		// (set) Token: 0x060019CA RID: 6602 RVA: 0x0004F138 File Offset: 0x0004D338
		public int ChartY
		{
			get
			{
				return this.chartRecord.Y;
			}
			set
			{
				this.chartRecord.Y = value;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x0004F146 File Offset: 0x0004D346
		// (set) Token: 0x060019CC RID: 6604 RVA: 0x0004F153 File Offset: 0x0004D353
		public int ChartWidth
		{
			get
			{
				return this.chartRecord.Width;
			}
			set
			{
				this.chartRecord.Width = value;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x0004F161 File Offset: 0x0004D361
		// (set) Token: 0x060019CE RID: 6606 RVA: 0x0004F16E File Offset: 0x0004D36E
		public int ChartHeight
		{
			get
			{
				return this.chartRecord.Height;
			}
			set
			{
				this.chartRecord.Height = value;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060019CF RID: 6607 RVA: 0x0004F17C File Offset: 0x0004D37C
		public global::NPOI.HSSF.UserModel.HSSFChart.HSSFSeries[] Series
		{
			get
			{
				return this.series.ToArray();
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x0004F189 File Offset: 0x0004D389
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x0004F1A0 File Offset: 0x0004D3A0
		public string ChartTitle
		{
			get
			{
				if (this.chartTitleText != null)
				{
					return this.chartTitleText.Text;
				}
				return null;
			}
			set
			{
				if (this.chartTitleText != null)
				{
					this.chartTitleText.Text = value;
					return;
				}
				throw new global::System.InvalidOperationException("No chart title found to change");
			}
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x0004F1C4 File Offset: 0x0004D3C4
		public void SetValueRange(int axisIndex, double? minimum, double? maximum, double? majorUnit, double? minorUnit)
		{
			global::NPOI.HSSF.Record.Chart.ValueRangeRecord valueRangeRecord = this.valueRanges[axisIndex];
			if (valueRangeRecord == null)
			{
				return;
			}
			if (minimum != null)
			{
				valueRangeRecord.IsAutomaticMinimum = double.IsNaN(minimum.Value);
				valueRangeRecord.MinimumAxisValue = minimum.Value;
			}
			if (maximum != null)
			{
				valueRangeRecord.IsAutomaticMaximum = double.IsNaN(maximum.Value);
				valueRangeRecord.MaximumAxisValue = maximum.Value;
			}
			if (majorUnit != null)
			{
				valueRangeRecord.IsAutomaticMajor = double.IsNaN(majorUnit.Value);
				valueRangeRecord.MajorIncrement = majorUnit.Value;
			}
			if (minorUnit != null)
			{
				valueRangeRecord.IsAutomaticMinor = double.IsNaN(minorUnit.Value);
				valueRangeRecord.MinorIncrement = minorUnit.Value;
			}
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x0004F28A File Offset: 0x0004D48A
		private global::NPOI.HSSF.Record.Chart.SeriesIndexRecord CreateSeriesIndexRecord(int index)
		{
			return new global::NPOI.HSSF.Record.Chart.SeriesIndexRecord
			{
				Index = (short)index
			};
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x0004F299 File Offset: 0x0004D499
		private global::NPOI.HSSF.Record.DimensionsRecord CreateDimensionsRecord()
		{
			return new global::NPOI.HSSF.Record.DimensionsRecord
			{
				FirstRow = 0,
				LastRow = 31,
				FirstCol = 0,
				LastCol = 1
			};
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x000476C6 File Offset: 0x000458C6
		private global::NPOI.HSSF.Record.HCenterRecord CreateHCenterRecord()
		{
			return new global::NPOI.HSSF.Record.HCenterRecord
			{
				HCenter = false
			};
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x000476D4 File Offset: 0x000458D4
		private global::NPOI.HSSF.Record.VCenterRecord CreateVCenterRecord()
		{
			return new global::NPOI.HSSF.Record.VCenterRecord
			{
				VCenter = false
			};
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x0004F2C0 File Offset: 0x0004D4C0
		private global::NPOI.HSSF.Record.PrintSetupRecord CreatePrintSetupRecord()
		{
			return new global::NPOI.HSSF.Record.PrintSetupRecord
			{
				PaperSize = 0,
				Scale = 18,
				PageStart = 1,
				FitWidth = 1,
				FitHeight = 1,
				LeftToRight = false,
				Landscape = false,
				ValidSettings = true,
				NoColor = false,
				Draft = false,
				Notes = false,
				NoOrientation = false,
				UsePage = false,
				HResolution = 0,
				VResolution = 0,
				HeaderMargin = 0.5,
				FooterMargin = 0.5,
				Copies = 15
			};
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x0004F362 File Offset: 0x0004D562
		private global::NPOI.HSSF.Record.Chart.FbiRecord CreateFontBasisRecord1()
		{
			return new global::NPOI.HSSF.Record.Chart.FbiRecord
			{
				XBasis = 9120,
				YBasis = 5640,
				HeightBasis = 200,
				Scale = 0,
				IndexToFontTable = 5
			};
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x0004F398 File Offset: 0x0004D598
		private global::NPOI.HSSF.Record.Chart.FbiRecord CreateFontBasisRecord2()
		{
			global::NPOI.HSSF.Record.Chart.FbiRecord fbiRecord = this.CreateFontBasisRecord1();
			fbiRecord.IndexToFontTable = 6;
			return fbiRecord;
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x0004F3A8 File Offset: 0x0004D5A8
		private global::NPOI.HSSF.Record.BOFRecord CreateBOFRecord()
		{
			return new global::NPOI.HSSF.Record.BOFRecord
			{
				Version = 600,
				Type = global::NPOI.HSSF.Record.BOFRecordType.Chart,
				Build = 7422,
				BuildYear = 1997,
				HistoryBitMask = 16585,
				RequiredVersion = 106
			};
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x0004F3F8 File Offset: 0x0004D5F8
		private global::NPOI.HSSF.Record.UnknownRecord CreateOBJRecord()
		{
			byte[] data = new byte[]
			{
				21,
				0,
				18,
				0,
				5,
				0,
				2,
				0,
				17,
				96,
				0,
				0,
				0,
				0,
				184,
				3,
				135,
				3,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0
			};
			return new global::NPOI.HSSF.Record.UnknownRecord(93, data);
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x0004F420 File Offset: 0x0004D620
		private global::NPOI.HSSF.Record.UnknownRecord CreateMSDrawingObjectRecord()
		{
			byte[] data = new byte[]
			{
				15,
				0,
				2,
				240,
				192,
				0,
				0,
				0,
				16,
				0,
				8,
				240,
				8,
				0,
				0,
				0,
				2,
				0,
				0,
				0,
				2,
				4,
				0,
				0,
				15,
				0,
				3,
				240,
				168,
				0,
				0,
				0,
				15,
				0,
				4,
				240,
				40,
				0,
				0,
				0,
				1,
				0,
				9,
				240,
				16,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				2,
				0,
				10,
				240,
				8,
				0,
				0,
				0,
				0,
				4,
				0,
				0,
				5,
				0,
				0,
				0,
				15,
				0,
				4,
				240,
				112,
				0,
				0,
				0,
				146,
				12,
				10,
				240,
				8,
				0,
				0,
				0,
				2,
				4,
				0,
				0,
				0,
				10,
				0,
				0,
				147,
				0,
				11,
				240,
				54,
				0,
				0,
				0,
				127,
				0,
				4,
				1,
				4,
				1,
				191,
				0,
				8,
				0,
				8,
				0,
				129,
				1,
				78,
				0,
				0,
				8,
				131,
				1,
				77,
				0,
				0,
				8,
				191,
				1,
				16,
				0,
				17,
				0,
				192,
				1,
				77,
				0,
				0,
				8,
				byte.MaxValue,
				1,
				8,
				0,
				8,
				0,
				63,
				2,
				0,
				0,
				2,
				0,
				191,
				3,
				0,
				0,
				8,
				0,
				0,
				0,
				16,
				240,
				18,
				0,
				0,
				0,
				0,
				0,
				4,
				0,
				192,
				2,
				10,
				0,
				244,
				0,
				14,
				0,
				102,
				1,
				32,
				0,
				233,
				0,
				0,
				0,
				17,
				240,
				0,
				0,
				0,
				0
			};
			return new global::NPOI.HSSF.Record.UnknownRecord(236, data);
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x0004F450 File Offset: 0x0004D650
		private void CreateAxisRecords(global::System.Collections.IList records)
		{
			records.Add(this.CreateAxisParentRecord());
			records.Add(this.CreateBeginRecord());
			records.Add(this.CreateAxisRecord(0));
			records.Add(this.CreateBeginRecord());
			records.Add(this.CreateCategorySeriesAxisRecord());
			records.Add(this.CreateAxisOptionsRecord());
			records.Add(this.CreateTickRecord1());
			records.Add(this.CreateEndRecord());
			records.Add(this.CreateAxisRecord(1));
			records.Add(this.CreateBeginRecord());
			records.Add(this.CreateValueRangeRecord());
			records.Add(this.CreateTickRecord2());
			records.Add(this.CreateAxisLineFormatRecord(global::NPOI.HSSF.Record.Chart.AxisLineFormatRecord.AXIS_TYPE_MAJOR_GRID_LINE));
			records.Add(this.CreateLineFormatRecord(false));
			records.Add(this.CreateEndRecord());
			records.Add(this.CreatePlotAreaRecord());
			records.Add(this.CreateFrameRecord2());
			records.Add(this.CreateBeginRecord());
			records.Add(this.CreateLineFormatRecord2());
			records.Add(this.CreateAreaFormatRecord2());
			records.Add(this.CreateEndRecord());
			records.Add(this.CreateChartFormatRecord());
			records.Add(this.CreateBeginRecord());
			records.Add(this.CreateBarRecord());
			records.Add(this.CreateLegendRecord());
			records.Add(this.CreateBeginRecord());
			records.Add(this.CreateTextRecord());
			records.Add(this.CreateBeginRecord());
			records.Add(this.CreateLinkedDataRecord());
			records.Add(this.CreateEndRecord());
			records.Add(this.CreateEndRecord());
			records.Add(this.CreateEndRecord());
			records.Add(this.CreateEndRecord());
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x0004F612 File Offset: 0x0004D812
		private global::NPOI.HSSF.Record.Chart.LinkedDataRecord CreateLinkedDataRecord()
		{
			return new global::NPOI.HSSF.Record.Chart.LinkedDataRecord
			{
				LinkType = global::NPOI.HSSF.Record.Chart.LinkedDataRecord.LINK_TYPE_TITLE_OR_TEXT,
				ReferenceType = global::NPOI.HSSF.Record.Chart.LinkedDataRecord.REFERENCE_TYPE_DIRECT,
				IsCustomNumberFormat = false,
				IndexNumberFmtRecord = 0,
				FormulaOfLink = null
			};
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x0004F644 File Offset: 0x0004D844
		private global::NPOI.HSSF.Record.TextRecord CreateTextRecord()
		{
			return new global::NPOI.HSSF.Record.TextRecord
			{
				HorizontalAlignment = 2,
				VerticalAlignment = 2,
				DisplayMode = 1,
				RgbColor = 0,
				X = -37,
				Y = -60,
				Width = 0,
				Height = 0,
				IsAutoColor = true,
				ShowKey = false,
				ShowValue = false,
				IsAutoGeneratedText = true,
				IsGenerated = true,
				IsAutoLabelDeleted = false,
				IsAutoBackground = true,
				ShowCategoryLabelAsPercentage = false,
				ShowValueAsPercentage = false,
				ShowBubbleSizes = false,
				ShowLabel = false,
				IndexOfColorValue = 77,
				DataLabelPlacement = 0,
				TextRotation = 0
			};
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x0004F6F4 File Offset: 0x0004D8F4
		private global::NPOI.HSSF.Record.Chart.LegendRecord CreateLegendRecord()
		{
			return new global::NPOI.HSSF.Record.Chart.LegendRecord
			{
				XAxisUpperLeft = 3542,
				YAxisUpperLeft = 1566,
				XSize = 437,
				YSize = 213,
				Type = 3,
				Spacing = 1,
				IsAutoPosition = true,
				IsAutoSeries = true,
				IsAutoXPositioning = true,
				IsAutoYPositioning = true,
				IsVertical = true,
				IsDataTable = false
			};
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x0004F76A File Offset: 0x0004D96A
		private global::NPOI.HSSF.Record.Chart.BarRecord CreateBarRecord()
		{
			return new global::NPOI.HSSF.Record.Chart.BarRecord
			{
				BarSpace = 0,
				CategorySpace = 150,
				IsHorizontal = false,
				IsStacked = false,
				IsDisplayAsPercentage = false,
				IsShadow = false
			};
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x0004F79F File Offset: 0x0004D99F
		private global::NPOI.HSSF.Record.ChartFormatRecord CreateChartFormatRecord()
		{
			return new global::NPOI.HSSF.Record.ChartFormatRecord
			{
				XPosition = 0,
				YPosition = 0,
				Width = 0,
				Height = 0,
				VaryDisplayPattern = false
			};
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x0004F7C9 File Offset: 0x0004D9C9
		private global::NPOI.HSSF.Record.Chart.PlotAreaRecord CreatePlotAreaRecord()
		{
			return new global::NPOI.HSSF.Record.Chart.PlotAreaRecord();
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x0004F7D0 File Offset: 0x0004D9D0
		private global::NPOI.HSSF.Record.Chart.AxisLineFormatRecord CreateAxisLineFormatRecord(short format)
		{
			return new global::NPOI.HSSF.Record.Chart.AxisLineFormatRecord
			{
				AxisType = format
			};
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x0004F7E0 File Offset: 0x0004D9E0
		private global::NPOI.HSSF.Record.Chart.ValueRangeRecord CreateValueRangeRecord()
		{
			return new global::NPOI.HSSF.Record.Chart.ValueRangeRecord
			{
				MinimumAxisValue = 0.0,
				MaximumAxisValue = 0.0,
				MajorIncrement = 0.0,
				MinorIncrement = 0.0,
				CategoryAxisCross = 0.0,
				IsAutomaticMinimum = true,
				IsAutomaticMaximum = true,
				IsAutomaticMajor = true,
				IsAutomaticMinor = true,
				IsAutomaticCategoryCrossing = true,
				IsLogarithmicScale = false,
				IsValuesInReverse = false,
				IsCrossCategoryAxisAtMaximum = false,
				IsReserved = true
			};
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x0004F87C File Offset: 0x0004DA7C
		private global::NPOI.HSSF.Record.TickRecord CreateTickRecord1()
		{
			return new global::NPOI.HSSF.Record.TickRecord
			{
				MajorTickType = 2,
				MinorTickType = 0,
				LabelPosition = 3,
				Background = 1,
				LabelColorRgb = 0,
				Zero1 = 0,
				Zero2 = 0,
				Zero3 = 45,
				IsAutorotate = true,
				IsAutoTextBackground = true,
				Rotation = 0,
				IsAutorotate = true,
				TickColor = 77
			};
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x0004F8EB File Offset: 0x0004DAEB
		private global::NPOI.HSSF.Record.TickRecord CreateTickRecord2()
		{
			global::NPOI.HSSF.Record.TickRecord tickRecord = this.CreateTickRecord1();
			tickRecord.Zero3 = 0;
			return tickRecord;
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x0004F8FC File Offset: 0x0004DAFC
		private global::NPOI.HSSF.Record.Chart.AxcExtRecord CreateAxisOptionsRecord()
		{
			return new global::NPOI.HSSF.Record.Chart.AxcExtRecord
			{
				MinimumDate = -28644,
				MaximumDate = -28715,
				MajorInterval = 2,
				MajorUnit = global::NPOI.HSSF.Record.Chart.DateUnit.Days,
				MinorInterval = 1,
				MinorUnit = global::NPOI.HSSF.Record.Chart.DateUnit.Days,
				BaseUnit = global::NPOI.HSSF.Record.Chart.DateUnit.Days,
				CrossDate = -28644,
				IsAutoMin = true,
				IsAutoMax = true,
				IsAutoMajor = true,
				IsAutoMinor = true,
				IsDateAxis = true,
				IsAutoBase = true,
				IsAutoCross = true,
				IsAutoDate = true
			};
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x0004F98A File Offset: 0x0004DB8A
		private global::NPOI.HSSF.Record.Chart.CatSerRangeRecord CreateCategorySeriesAxisRecord()
		{
			return new global::NPOI.HSSF.Record.Chart.CatSerRangeRecord
			{
				CrossPoint = 1,
				LabelInterval = 1,
				MarkInterval = 1,
				IsBetween = true,
				IsMaxCross = false,
				IsReverse = false
			};
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x0004F9BB File Offset: 0x0004DBBB
		private global::NPOI.HSSF.Record.Chart.AxisRecord CreateAxisRecord(short axisType)
		{
			return new global::NPOI.HSSF.Record.Chart.AxisRecord
			{
				AxisType = axisType
			};
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x0004F9C9 File Offset: 0x0004DBC9
		private global::NPOI.HSSF.Record.Chart.AxisParentRecord CreateAxisParentRecord()
		{
			return new global::NPOI.HSSF.Record.Chart.AxisParentRecord
			{
				AxisType = 0,
				X = 479,
				Y = 221,
				Width = 2995,
				Height = 2902
			};
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x0004FA03 File Offset: 0x0004DC03
		private global::NPOI.HSSF.Record.Chart.AxesUsedRecord CreateAxisUsedRecord(short numAxis)
		{
			return new global::NPOI.HSSF.Record.Chart.AxesUsedRecord
			{
				NumAxis = numAxis
			};
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x0004F612 File Offset: 0x0004D812
		private global::NPOI.HSSF.Record.Chart.LinkedDataRecord CreateDirectLinkRecord()
		{
			return new global::NPOI.HSSF.Record.Chart.LinkedDataRecord
			{
				LinkType = global::NPOI.HSSF.Record.Chart.LinkedDataRecord.LINK_TYPE_TITLE_OR_TEXT,
				ReferenceType = global::NPOI.HSSF.Record.Chart.LinkedDataRecord.REFERENCE_TYPE_DIRECT,
				IsCustomNumberFormat = false,
				IndexNumberFmtRecord = 0,
				FormulaOfLink = null
			};
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x0004FA11 File Offset: 0x0004DC11
		private global::NPOI.HSSF.Record.Chart.FontIndexRecord CreateFontIndexRecord(int index)
		{
			return new global::NPOI.HSSF.Record.Chart.FontIndexRecord
			{
				FontIndex = (short)index
			};
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x0004FA20 File Offset: 0x0004DC20
		private global::NPOI.HSSF.Record.TextRecord CreateAllTextRecord()
		{
			return new global::NPOI.HSSF.Record.TextRecord
			{
				HorizontalAlignment = 2,
				VerticalAlignment = 2,
				DisplayMode = 1,
				RgbColor = 0,
				X = -37,
				Y = -60,
				Width = 0,
				Height = 0,
				IsAutoColor = true,
				ShowKey = false,
				ShowValue = true,
				IsAutoGeneratedText = true,
				IsGenerated = true,
				IsAutoLabelDeleted = false,
				IsAutoBackground = true,
				ShowCategoryLabelAsPercentage = false,
				ShowValueAsPercentage = false,
				ShowBubbleSizes = false,
				ShowLabel = false,
				IndexOfColorValue = 77,
				DataLabelPlacement = 0,
				TextRotation = 0
			};
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x0004FAD0 File Offset: 0x0004DCD0
		private global::NPOI.HSSF.Record.TextRecord CreateUnknownTextRecord()
		{
			return new global::NPOI.HSSF.Record.TextRecord
			{
				HorizontalAlignment = 2,
				VerticalAlignment = 2,
				DisplayMode = 1,
				RgbColor = 0,
				X = -37,
				Y = -60,
				Width = 0,
				Height = 0,
				IsAutoColor = true,
				ShowKey = false,
				ShowValue = false,
				IsAutoGeneratedText = true,
				IsGenerated = true,
				IsAutoLabelDeleted = false,
				IsAutoBackground = true,
				ShowCategoryLabelAsPercentage = false,
				ShowValueAsPercentage = false,
				ShowBubbleSizes = false,
				ShowLabel = false,
				IndexOfColorValue = 77,
				DataLabelPlacement = 11088,
				TextRotation = 0
			};
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x0004FB83 File Offset: 0x0004DD83
		private global::NPOI.HSSF.Record.Chart.DefaultTextRecord CreateDefaultTextRecord(short categoryDataType)
		{
			return new global::NPOI.HSSF.Record.Chart.DefaultTextRecord
			{
				FormatType = (global::NPOI.HSSF.Record.Chart.TextFormatInfo)categoryDataType
			};
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x0004FB91 File Offset: 0x0004DD91
		private global::NPOI.HSSF.Record.Chart.ShtPropsRecord CreateSheetPropsRecord()
		{
			return new global::NPOI.HSSF.Record.Chart.ShtPropsRecord
			{
				IsManSerAlloc = false,
				IsPlotVisibleOnly = true,
				IsNotSizeWithWindow = false,
				IsManPlotArea = true,
				IsAlwaysAutoPlotArea = false
			};
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x0004FBBB File Offset: 0x0004DDBB
		private global::NPOI.HSSF.Record.Chart.DataFormatRecord CreateDataFormatRecord()
		{
			return new global::NPOI.HSSF.Record.Chart.DataFormatRecord
			{
				PointNumber = -1,
				SeriesIndex = 0,
				SeriesNumber = 0,
				UseExcel4Colors = false
			};
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x0004FBE0 File Offset: 0x0004DDE0
		private global::NPOI.HSSF.Record.Chart.LinkedDataRecord CreateCategoriesLinkedDataRecord()
		{
			global::NPOI.HSSF.Record.Chart.LinkedDataRecord linkedDataRecord = new global::NPOI.HSSF.Record.Chart.LinkedDataRecord();
			linkedDataRecord.LinkType = global::NPOI.HSSF.Record.Chart.LinkedDataRecord.LINK_TYPE_CATEGORIES;
			linkedDataRecord.ReferenceType = global::NPOI.HSSF.Record.Chart.LinkedDataRecord.REFERENCE_TYPE_WORKSHEET;
			linkedDataRecord.IsCustomNumberFormat = false;
			linkedDataRecord.IndexNumberFmtRecord = 0;
			global::NPOI.SS.Formula.PTG.Area3DPtg area3DPtg = new global::NPOI.SS.Formula.PTG.Area3DPtg(0, 31, 1, 1, false, false, false, false, 0);
			linkedDataRecord.FormulaOfLink = new global::NPOI.SS.Formula.PTG.Ptg[]
			{
				area3DPtg
			};
			return linkedDataRecord;
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x0004FC38 File Offset: 0x0004DE38
		private global::NPOI.HSSF.Record.Chart.LinkedDataRecord CreateValuesLinkedDataRecord()
		{
			global::NPOI.HSSF.Record.Chart.LinkedDataRecord linkedDataRecord = new global::NPOI.HSSF.Record.Chart.LinkedDataRecord();
			linkedDataRecord.LinkType = global::NPOI.HSSF.Record.Chart.LinkedDataRecord.LINK_TYPE_VALUES;
			linkedDataRecord.ReferenceType = global::NPOI.HSSF.Record.Chart.LinkedDataRecord.REFERENCE_TYPE_WORKSHEET;
			linkedDataRecord.IsCustomNumberFormat = false;
			linkedDataRecord.IndexNumberFmtRecord = 0;
			global::NPOI.SS.Formula.PTG.Area3DPtg area3DPtg = new global::NPOI.SS.Formula.PTG.Area3DPtg(0, 31, 0, 0, false, false, false, false, 0);
			linkedDataRecord.FormulaOfLink = new global::NPOI.SS.Formula.PTG.Ptg[]
			{
				area3DPtg
			};
			return linkedDataRecord;
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x0004F612 File Offset: 0x0004D812
		private global::NPOI.HSSF.Record.Chart.LinkedDataRecord CreateTitleLinkedDataRecord()
		{
			return new global::NPOI.HSSF.Record.Chart.LinkedDataRecord
			{
				LinkType = global::NPOI.HSSF.Record.Chart.LinkedDataRecord.LINK_TYPE_TITLE_OR_TEXT,
				ReferenceType = global::NPOI.HSSF.Record.Chart.LinkedDataRecord.REFERENCE_TYPE_DIRECT,
				IsCustomNumberFormat = false,
				IndexNumberFmtRecord = 0,
				FormulaOfLink = null
			};
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x0004FC90 File Offset: 0x0004DE90
		private global::NPOI.HSSF.Record.Chart.SeriesRecord CreateSeriesRecord()
		{
			return new global::NPOI.HSSF.Record.Chart.SeriesRecord
			{
				CategoryDataType = 1,
				ValuesDataType = 1,
				NumCategories = 32,
				NumValues = 31,
				BubbleSeriesType = 1,
				NumBubbleValues = 0
			};
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x0004FCC3 File Offset: 0x0004DEC3
		private global::NPOI.HSSF.Record.Chart.EndRecord CreateEndRecord()
		{
			return new global::NPOI.HSSF.Record.Chart.EndRecord();
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x0004FCCA File Offset: 0x0004DECA
		private global::NPOI.HSSF.Record.Chart.AreaFormatRecord CreateAreaFormatRecord1()
		{
			return new global::NPOI.HSSF.Record.Chart.AreaFormatRecord
			{
				ForegroundColor = 16777215,
				BackgroundColor = 0,
				Pattern = 1,
				IsAutomatic = true,
				IsInvert = false,
				ForecolorIndex = 78,
				BackcolorIndex = 77
			};
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x0004FD08 File Offset: 0x0004DF08
		private global::NPOI.HSSF.Record.Chart.AreaFormatRecord CreateAreaFormatRecord2()
		{
			return new global::NPOI.HSSF.Record.Chart.AreaFormatRecord
			{
				ForegroundColor = 12632256,
				BackgroundColor = 0,
				Pattern = 1,
				IsAutomatic = false,
				IsInvert = false,
				ForecolorIndex = 22,
				BackcolorIndex = 79
			};
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x0004FD46 File Offset: 0x0004DF46
		private global::NPOI.HSSF.Record.Chart.LineFormatRecord CreateLineFormatRecord(bool drawTicks)
		{
			return new global::NPOI.HSSF.Record.Chart.LineFormatRecord
			{
				LineColor = 0,
				LinePattern = 0,
				Weight = -1,
				IsAuto = true,
				IsDrawTicks = drawTicks,
				ColourPaletteIndex = 77
			};
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x0004FD78 File Offset: 0x0004DF78
		private global::NPOI.HSSF.Record.Chart.LineFormatRecord CreateLineFormatRecord2()
		{
			return new global::NPOI.HSSF.Record.Chart.LineFormatRecord
			{
				LineColor = 8421504,
				LinePattern = 0,
				Weight = 0,
				IsAuto = false,
				IsDrawTicks = false,
				IsUnknown = false,
				ColourPaletteIndex = 23
			};
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x0004FDB5 File Offset: 0x0004DFB5
		private global::NPOI.HSSF.Record.Chart.FrameRecord CreateFrameRecord1()
		{
			return new global::NPOI.HSSF.Record.Chart.FrameRecord
			{
				BorderType = 0,
				IsAutoSize = false,
				IsAutoPosition = true
			};
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x0004FDD1 File Offset: 0x0004DFD1
		private global::NPOI.HSSF.Record.Chart.FrameRecord CreateFrameRecord2()
		{
			return new global::NPOI.HSSF.Record.Chart.FrameRecord
			{
				BorderType = 0,
				IsAutoSize = true,
				IsAutoPosition = true
			};
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x0004FDED File Offset: 0x0004DFED
		private global::NPOI.HSSF.Record.Chart.PlotGrowthRecord CreatePlotGrowthRecord(int horizScale, int vertScale)
		{
			return new global::NPOI.HSSF.Record.Chart.PlotGrowthRecord
			{
				HorizontalScale = horizScale,
				VerticalScale = vertScale
			};
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x0004FE02 File Offset: 0x0004E002
		private global::NPOI.HSSF.Record.SCLRecord CreateSCLRecord(short numerator, short denominator)
		{
			return new global::NPOI.HSSF.Record.SCLRecord
			{
				Denominator = denominator,
				Numerator = numerator
			};
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x0004FE17 File Offset: 0x0004E017
		private global::NPOI.HSSF.Record.Chart.BeginRecord CreateBeginRecord()
		{
			return new global::NPOI.HSSF.Record.Chart.BeginRecord();
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x0004FE1E File Offset: 0x0004E01E
		private global::NPOI.HSSF.Record.Chart.ChartRecord CreateChartRecord(int x, int y, int width, int height)
		{
			return new global::NPOI.HSSF.Record.Chart.ChartRecord
			{
				X = x,
				Y = y,
				Width = width,
				Height = height
			};
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x0004FE42 File Offset: 0x0004E042
		private global::NPOI.HSSF.Record.UnitsRecord CreateUnitsRecord()
		{
			return new global::NPOI.HSSF.Record.UnitsRecord
			{
				Units = 0
			};
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x0004FE50 File Offset: 0x0004E050
		public global::NPOI.HSSF.UserModel.HSSFChart.HSSFSeries CreateSeries()
		{
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase>();
			bool flag = false;
			int num = 0;
			int num2 = 0;
			int num3 = -1;
			int num4 = -1;
			int num5 = -1;
			int num6 = -1;
			int num7 = 0;
			global::System.Collections.IList records = this.sheet.Sheet.Records;
			foreach (object obj in records)
			{
				global::NPOI.HSSF.Record.RecordBase recordBase = (global::NPOI.HSSF.Record.RecordBase)obj;
				num++;
				if (recordBase is global::NPOI.HSSF.Record.Chart.BeginRecord)
				{
					num2++;
				}
				else if (recordBase is global::NPOI.HSSF.Record.Chart.EndRecord)
				{
					num2--;
					if (num5 == num2)
					{
						num5 = -1;
						num6 = num;
						if (!flag)
						{
							list.Add(recordBase);
							flag = true;
						}
					}
					if (num4 == num2)
					{
						break;
					}
				}
				if (recordBase is global::NPOI.HSSF.Record.Chart.ChartRecord)
				{
					if (recordBase == this.chartRecord)
					{
						num3 = num;
						num4 = num2;
					}
				}
				else if (recordBase is global::NPOI.HSSF.Record.Chart.SeriesRecord && num3 != -1)
				{
					num7++;
					num5 = num2;
				}
				if (num5 != -1 && !flag)
				{
					list.Add(recordBase);
				}
			}
			if (num6 == -1)
			{
				return null;
			}
			num = num6 + 1;
			global::NPOI.HSSF.UserModel.HSSFChart.HSSFSeries hssfseries = null;
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> list2 = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase>();
			foreach (global::NPOI.HSSF.Record.RecordBase recordBase2 in list)
			{
				global::NPOI.HSSF.Record.Record record = null;
				if (recordBase2 is global::NPOI.HSSF.Record.Chart.BeginRecord)
				{
					record = new global::NPOI.HSSF.Record.Chart.BeginRecord();
				}
				else if (recordBase2 is global::NPOI.HSSF.Record.Chart.EndRecord)
				{
					record = new global::NPOI.HSSF.Record.Chart.EndRecord();
				}
				else if (recordBase2 is global::NPOI.HSSF.Record.Chart.SeriesRecord)
				{
					global::NPOI.HSSF.Record.Chart.SeriesRecord seriesRecord = (global::NPOI.HSSF.Record.Chart.SeriesRecord)((global::NPOI.HSSF.Record.Chart.SeriesRecord)recordBase2).Clone();
					hssfseries = new global::NPOI.HSSF.UserModel.HSSFChart.HSSFSeries(seriesRecord);
					record = seriesRecord;
				}
				else if (recordBase2 is global::NPOI.HSSF.Record.Chart.LinkedDataRecord)
				{
					global::NPOI.HSSF.Record.Chart.LinkedDataRecord linkedDataRecord = (global::NPOI.HSSF.Record.Chart.LinkedDataRecord)((global::NPOI.HSSF.Record.Chart.LinkedDataRecord)recordBase2).Clone();
					if (hssfseries != null)
					{
						hssfseries.InsertData(linkedDataRecord);
					}
					record = linkedDataRecord;
				}
				else if (recordBase2 is global::NPOI.HSSF.Record.Chart.DataFormatRecord)
				{
					global::NPOI.HSSF.Record.Chart.DataFormatRecord dataFormatRecord = (global::NPOI.HSSF.Record.Chart.DataFormatRecord)((global::NPOI.HSSF.Record.Chart.DataFormatRecord)recordBase2).Clone();
					dataFormatRecord.SeriesIndex = (short)num7;
					dataFormatRecord.SeriesNumber = (short)num7;
					record = dataFormatRecord;
				}
				else if (recordBase2 is global::NPOI.HSSF.Record.Chart.SeriesTextRecord)
				{
					global::NPOI.HSSF.Record.Chart.SeriesTextRecord seriesTextRecord = (global::NPOI.HSSF.Record.Chart.SeriesTextRecord)((global::NPOI.HSSF.Record.Chart.SeriesTextRecord)recordBase2).Clone();
					if (hssfseries != null)
					{
						hssfseries.SetSeriesTitleText(seriesTextRecord);
					}
					record = seriesTextRecord;
				}
				else if (recordBase2 is global::NPOI.HSSF.Record.Record)
				{
					record = (global::NPOI.HSSF.Record.Record)((global::NPOI.HSSF.Record.Record)recordBase2).Clone();
				}
				if (record != null)
				{
					list2.Add(record);
				}
			}
			if (hssfseries == null)
			{
				return null;
			}
			foreach (global::NPOI.HSSF.Record.RecordBase value in list2)
			{
				records.Insert(num++, value);
			}
			return hssfseries;
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x00050130 File Offset: 0x0004E330
		public bool RemoveSeries(global::NPOI.HSSF.UserModel.HSSFChart.HSSFSeries series)
		{
			int num = 0;
			int num2 = 0;
			int num3 = -1;
			int num4 = -1;
			int num5 = -1;
			bool flag = false;
			bool flag2 = false;
			bool result = false;
			global::System.Collections.IList records = this.sheet.Sheet.Records;
			foreach (object obj in records)
			{
				global::NPOI.HSSF.Record.RecordBase recordBase = (global::NPOI.HSSF.Record.RecordBase)obj;
				num++;
				if (recordBase is global::NPOI.HSSF.Record.Chart.BeginRecord)
				{
					num2++;
				}
				else if (recordBase is global::NPOI.HSSF.Record.Chart.EndRecord)
				{
					num2--;
					if (num4 == num2)
					{
						num4 = -1;
						if (flag)
						{
							flag = false;
							result = true;
							records.Remove(recordBase);
						}
					}
					if (num3 == num2)
					{
						break;
					}
				}
				if (recordBase is global::NPOI.HSSF.Record.Chart.ChartRecord)
				{
					if (recordBase == this.chartRecord)
					{
						num3 = num2;
						flag2 = true;
					}
				}
				else if (recordBase is global::NPOI.HSSF.Record.Chart.SeriesRecord)
				{
					if (flag2)
					{
						if (series.series == recordBase)
						{
							num4 = num2;
							flag = true;
						}
						else
						{
							num5++;
						}
					}
				}
				else if (recordBase is global::NPOI.HSSF.Record.Chart.DataFormatRecord && flag2 && !flag)
				{
					global::NPOI.HSSF.Record.Chart.DataFormatRecord dataFormatRecord = (global::NPOI.HSSF.Record.Chart.DataFormatRecord)recordBase;
					dataFormatRecord.SeriesIndex = (short)num5;
					dataFormatRecord.SeriesNumber = (short)num5;
				}
				if (flag)
				{
					records.Remove(recordBase);
				}
			}
			return result;
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001A06 RID: 6662 RVA: 0x00050243 File Offset: 0x0004E443
		public global::NPOI.HSSF.UserModel.HSSFChartType Type
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x04000B04 RID: 2820
		private global::NPOI.HSSF.UserModel.HSSFSheet sheet;

		// Token: 0x04000B05 RID: 2821
		private global::NPOI.HSSF.Record.Chart.ChartRecord chartRecord;

		// Token: 0x04000B06 RID: 2822
		private global::NPOI.HSSF.Record.Chart.LegendRecord legendRecord;

		// Token: 0x04000B07 RID: 2823
		private global::NPOI.HSSF.Record.Chart.AlRunsRecord chartTitleFormat;

		// Token: 0x04000B08 RID: 2824
		private global::NPOI.HSSF.Record.Chart.SeriesTextRecord chartTitleText;

		// Token: 0x04000B09 RID: 2825
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Chart.ValueRangeRecord> valueRanges = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Chart.ValueRangeRecord>();

		// Token: 0x04000B0A RID: 2826
		private global::NPOI.HSSF.UserModel.HSSFChartType type;

		// Token: 0x04000B0B RID: 2827
		private global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFChart.HSSFSeries> series = new global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFChart.HSSFSeries>();

		// Token: 0x020005FD RID: 1533
		public class HSSFSeries
		{
			// Token: 0x06003607 RID: 13831 RVA: 0x000A5597 File Offset: 0x000A3797
			public HSSFSeries(global::NPOI.HSSF.Record.Chart.SeriesRecord series)
			{
				this.series = series;
			}

			// Token: 0x06003608 RID: 13832 RVA: 0x000A55A8 File Offset: 0x000A37A8
			internal void InsertData(global::NPOI.HSSF.Record.Chart.LinkedDataRecord data)
			{
				switch (data.LinkType)
				{
				case 0:
					this.dataName = data;
					return;
				case 1:
					this.dataValues = data;
					return;
				case 2:
					this.dataCategoryLabels = data;
					return;
				case 3:
					this.dataSecondaryCategoryLabels = data;
					return;
				default:
					return;
				}
			}

			// Token: 0x06003609 RID: 13833 RVA: 0x000A55F2 File Offset: 0x000A37F2
			internal void SetSeriesTitleText(global::NPOI.HSSF.Record.Chart.SeriesTextRecord seriesTitleText)
			{
				this.seriesTitleText = seriesTitleText;
			}

			// Token: 0x17000DF8 RID: 3576
			// (get) Token: 0x0600360A RID: 13834 RVA: 0x000A55FB File Offset: 0x000A37FB
			public short NumValues
			{
				get
				{
					return this.series.NumValues;
				}
			}

			// Token: 0x17000DF9 RID: 3577
			// (get) Token: 0x0600360B RID: 13835 RVA: 0x000A5608 File Offset: 0x000A3808
			public short ValueType
			{
				get
				{
					return this.series.ValuesDataType;
				}
			}

			// Token: 0x17000DFA RID: 3578
			// (get) Token: 0x0600360C RID: 13836 RVA: 0x000A5615 File Offset: 0x000A3815
			// (set) Token: 0x0600360D RID: 13837 RVA: 0x000A562C File Offset: 0x000A382C
			public string SeriesTitle
			{
				get
				{
					if (this.seriesTitleText != null)
					{
						return this.seriesTitleText.Text;
					}
					return null;
				}
				set
				{
					if (this.seriesTitleText != null)
					{
						this.seriesTitleText.Text = value;
						return;
					}
					throw new global::System.InvalidOperationException("No series title found to Change");
				}
			}

			// Token: 0x0600360E RID: 13838 RVA: 0x000A564D File Offset: 0x000A384D
			public global::NPOI.HSSF.Record.Chart.LinkedDataRecord GetDataName()
			{
				return this.dataName;
			}

			// Token: 0x0600360F RID: 13839 RVA: 0x000A5655 File Offset: 0x000A3855
			public global::NPOI.HSSF.Record.Chart.LinkedDataRecord GetDataValues()
			{
				return this.dataValues;
			}

			// Token: 0x06003610 RID: 13840 RVA: 0x000A565D File Offset: 0x000A385D
			public global::NPOI.HSSF.Record.Chart.LinkedDataRecord GetDataCategoryLabels()
			{
				return this.dataCategoryLabels;
			}

			// Token: 0x06003611 RID: 13841 RVA: 0x000A5665 File Offset: 0x000A3865
			public global::NPOI.HSSF.Record.Chart.LinkedDataRecord GetDataSecondaryCategoryLabels()
			{
				return this.dataSecondaryCategoryLabels;
			}

			// Token: 0x06003612 RID: 13842 RVA: 0x000A566D File Offset: 0x000A386D
			public global::NPOI.HSSF.Record.Chart.SeriesRecord GetSeries()
			{
				return this.series;
			}

			// Token: 0x06003613 RID: 13843 RVA: 0x000A5678 File Offset: 0x000A3878
			private global::NPOI.SS.Util.CellRangeAddressBase GetCellRange(global::NPOI.HSSF.Record.Chart.LinkedDataRecord linkedDataRecord)
			{
				if (linkedDataRecord == null)
				{
					return null;
				}
				int firstRow = 0;
				int lastRow = 0;
				int firstCol = 0;
				int lastCol = 0;
				foreach (global::NPOI.SS.Formula.PTG.Ptg ptg in linkedDataRecord.FormulaOfLink)
				{
					if (ptg is global::NPOI.SS.Formula.PTG.AreaPtgBase)
					{
						global::NPOI.SS.Formula.PTG.AreaPtgBase areaPtgBase = (global::NPOI.SS.Formula.PTG.AreaPtgBase)ptg;
						firstRow = areaPtgBase.FirstRow;
						lastRow = areaPtgBase.LastRow;
						firstCol = areaPtgBase.FirstColumn;
						lastCol = areaPtgBase.LastColumn;
					}
				}
				return new global::NPOI.SS.Util.CellRangeAddress(firstRow, lastRow, firstCol, lastCol);
			}

			// Token: 0x06003614 RID: 13844 RVA: 0x000A56E8 File Offset: 0x000A38E8
			public global::NPOI.SS.Util.CellRangeAddressBase GetValuesCellRange()
			{
				return this.GetCellRange(this.dataValues);
			}

			// Token: 0x06003615 RID: 13845 RVA: 0x000A56F6 File Offset: 0x000A38F6
			public global::NPOI.SS.Util.CellRangeAddressBase GetCategoryLabelsCellRange()
			{
				return this.GetCellRange(this.dataCategoryLabels);
			}

			// Token: 0x06003616 RID: 13846 RVA: 0x000A5704 File Offset: 0x000A3904
			private int SetVerticalCellRange(global::NPOI.HSSF.Record.Chart.LinkedDataRecord linkedDataRecord, global::NPOI.SS.Util.CellRangeAddressBase range)
			{
				if (linkedDataRecord == null)
				{
					throw new global::System.ArgumentNullException("linkedDataRecord should not be null");
				}
				global::System.Collections.Generic.List<global::NPOI.SS.Formula.PTG.Ptg> list = new global::System.Collections.Generic.List<global::NPOI.SS.Formula.PTG.Ptg>();
				int num = range.LastRow - range.FirstRow + 1;
				int num2 = range.LastColumn - range.FirstColumn + 1;
				foreach (global::NPOI.SS.Formula.PTG.Ptg ptg in linkedDataRecord.FormulaOfLink)
				{
					if (ptg is global::NPOI.SS.Formula.PTG.AreaPtgBase)
					{
						global::NPOI.SS.Formula.PTG.AreaPtgBase areaPtgBase = (global::NPOI.SS.Formula.PTG.AreaPtgBase)ptg;
						areaPtgBase.FirstRow = range.FirstRow;
						areaPtgBase.LastRow = range.LastRow;
						areaPtgBase.FirstColumn = range.FirstColumn;
						areaPtgBase.LastColumn = range.LastColumn;
						list.Add(areaPtgBase);
					}
				}
				linkedDataRecord.FormulaOfLink = list.ToArray();
				return num * num2;
			}

			// Token: 0x06003617 RID: 13847 RVA: 0x000A57C4 File Offset: 0x000A39C4
			public void SetValuesCellRange(global::NPOI.SS.Util.CellRangeAddressBase range)
			{
				int num = this.SetVerticalCellRange(this.dataValues, range);
				this.series.NumValues = (short)num;
			}

			// Token: 0x06003618 RID: 13848 RVA: 0x000A57EC File Offset: 0x000A39EC
			public void SetCategoryLabelsCellRange(global::NPOI.SS.Util.CellRangeAddressBase range)
			{
				int num = this.SetVerticalCellRange(this.dataCategoryLabels, range);
				this.series.NumCategories = (short)num;
			}

			// Token: 0x04001A29 RID: 6697
			internal global::NPOI.HSSF.Record.Chart.SeriesRecord series;

			// Token: 0x04001A2A RID: 6698
			internal global::NPOI.HSSF.Record.Chart.SeriesTextRecord seriesTitleText;

			// Token: 0x04001A2B RID: 6699
			private global::NPOI.HSSF.Record.Chart.LinkedDataRecord dataName;

			// Token: 0x04001A2C RID: 6700
			private global::NPOI.HSSF.Record.Chart.LinkedDataRecord dataValues;

			// Token: 0x04001A2D RID: 6701
			private global::NPOI.HSSF.Record.Chart.LinkedDataRecord dataCategoryLabels;

			// Token: 0x04001A2E RID: 6702
			private global::NPOI.HSSF.Record.Chart.LinkedDataRecord dataSecondaryCategoryLabels;
		}
	}
}
