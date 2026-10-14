using System;
using NPOI.OpenXmlFormats.Dml.Chart;
using NPOI.SS.UserModel.Charts;

namespace NPOI.XSSF.UserModel.Charts
{
	// Token: 0x020000B9 RID: 185
	public abstract class XSSFChartAxis : global::NPOI.SS.UserModel.Charts.IChartAxis
	{
		// Token: 0x06000B82 RID: 2946 RVA: 0x0002B061 File Offset: 0x00029261
		protected XSSFChartAxis(global::NPOI.XSSF.UserModel.XSSFChart chart)
		{
			this.chart = chart;
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000B83 RID: 2947
		public abstract long Id { get; }

		// Token: 0x06000B84 RID: 2948
		public abstract void CrossAxis(global::NPOI.SS.UserModel.Charts.IChartAxis axis);

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x0002B070 File Offset: 0x00029270
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x0002B07D File Offset: 0x0002927D
		public global::NPOI.SS.UserModel.Charts.AxisPosition Position
		{
			get
			{
				return global::NPOI.XSSF.UserModel.Charts.XSSFChartAxis.toAxisPosition(this.GetCTAxPos());
			}
			set
			{
				this.GetCTAxPos().val = global::NPOI.XSSF.UserModel.Charts.XSSFChartAxis.fromAxisPosition(value);
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x0002B090 File Offset: 0x00029290
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x0002B09D File Offset: 0x0002929D
		public string NumberFormat
		{
			get
			{
				return this.GetCTNumFmt().formatCode;
			}
			set
			{
				this.GetCTNumFmt().formatCode = value;
				this.GetCTNumFmt().sourceLinked = true;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x0002B0B7 File Offset: 0x000292B7
		public bool IsSetLogBase
		{
			get
			{
				return this.GetCTScaling().IsSetLogBase();
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x0002B0C4 File Offset: 0x000292C4
		// (set) Token: 0x06000B8B RID: 2955 RVA: 0x0002B0F0 File Offset: 0x000292F0
		public double LogBase
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.Chart.CT_LogBase logBase = this.GetCTScaling().logBase;
				if (logBase != null)
				{
					return logBase.val;
				}
				return 0.0;
			}
			set
			{
				if (value < global::NPOI.XSSF.UserModel.Charts.XSSFChartAxis.Min_LOG_BASE || global::NPOI.XSSF.UserModel.Charts.XSSFChartAxis.Max_LOG_BASE < value)
				{
					throw new global::System.ArgumentException("Axis log base must be between 2 and 1000 (inclusive), got: " + value.ToString());
				}
				global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling ctscaling = this.GetCTScaling();
				if (ctscaling.IsSetLogBase())
				{
					ctscaling.logBase.val = value;
					return;
				}
				ctscaling.AddNewLogBase().val = value;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0002B14C File Offset: 0x0002934C
		public bool IsSetMinimum
		{
			get
			{
				return this.GetCTScaling().IsSetMin();
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x0002B15C File Offset: 0x0002935C
		// (set) Token: 0x06000B8E RID: 2958 RVA: 0x0002B190 File Offset: 0x00029390
		public double Minimum
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling ctscaling = this.GetCTScaling();
				if (ctscaling.IsSetMin())
				{
					return ctscaling.min.val;
				}
				return 0.0;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling ctscaling = this.GetCTScaling();
				if (ctscaling.IsSetMin())
				{
					ctscaling.min.val = value;
					return;
				}
				ctscaling.AddNewMin().val = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x0002B1C5 File Offset: 0x000293C5
		public bool IsSetMaximum
		{
			get
			{
				return this.GetCTScaling().IsSetMax();
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x0002B1D4 File Offset: 0x000293D4
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x0002B208 File Offset: 0x00029408
		public double Maximum
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling ctscaling = this.GetCTScaling();
				if (ctscaling.IsSetMax())
				{
					return ctscaling.max.val;
				}
				return 0.0;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling ctscaling = this.GetCTScaling();
				if (ctscaling.IsSetMax())
				{
					ctscaling.max.val = value;
					return;
				}
				ctscaling.AddNewMax().val = value;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x0002B23D File Offset: 0x0002943D
		// (set) Token: 0x06000B93 RID: 2963 RVA: 0x0002B250 File Offset: 0x00029450
		public global::NPOI.SS.UserModel.Charts.AxisOrientation Orientation
		{
			get
			{
				return global::NPOI.XSSF.UserModel.Charts.XSSFChartAxis.toAxisOrientation(this.GetCTScaling().orientation);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling ctscaling = this.GetCTScaling();
				global::NPOI.OpenXmlFormats.Dml.Chart.ST_Orientation val = global::NPOI.XSSF.UserModel.Charts.XSSFChartAxis.fromAxisOrientation(value);
				if (ctscaling.IsSetOrientation())
				{
					ctscaling.orientation.val = val;
					return;
				}
				this.GetCTScaling().AddNewOrientation().val = val;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x0002B291 File Offset: 0x00029491
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x0002B29E File Offset: 0x0002949E
		public global::NPOI.SS.UserModel.Charts.AxisCrosses Crosses
		{
			get
			{
				return global::NPOI.XSSF.UserModel.Charts.XSSFChartAxis.toAxisCrosses(this.GetCTCrosses());
			}
			set
			{
				this.GetCTCrosses().val = global::NPOI.XSSF.UserModel.Charts.XSSFChartAxis.fromAxisCrosses(value);
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x0002B2B1 File Offset: 0x000294B1
		// (set) Token: 0x06000B97 RID: 2967 RVA: 0x0002B2C1 File Offset: 0x000294C1
		public bool IsVisible
		{
			get
			{
				return this.GetDelete().val == 0;
			}
			set
			{
				this.GetDelete().val = (value ? 0 : 1);
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x0002B2D5 File Offset: 0x000294D5
		// (set) Token: 0x06000B99 RID: 2969 RVA: 0x0002B2E2 File Offset: 0x000294E2
		public global::NPOI.SS.UserModel.Charts.AxisTickMark MajorTickMark
		{
			get
			{
				return global::NPOI.XSSF.UserModel.Charts.XSSFChartAxis.toAxisTickMark(this.GetMajorCTTickMark());
			}
			set
			{
				this.GetMajorCTTickMark().val = global::NPOI.XSSF.UserModel.Charts.XSSFChartAxis.fromAxisTickMark(value);
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x0002B2F5 File Offset: 0x000294F5
		// (set) Token: 0x06000B9B RID: 2971 RVA: 0x0002B302 File Offset: 0x00029502
		public global::NPOI.SS.UserModel.Charts.AxisTickMark MinorTickMark
		{
			get
			{
				return global::NPOI.XSSF.UserModel.Charts.XSSFChartAxis.toAxisTickMark(this.GetMinorCTTickMark());
			}
			set
			{
				this.GetMinorCTTickMark().val = global::NPOI.XSSF.UserModel.Charts.XSSFChartAxis.fromAxisTickMark(value);
			}
		}

		// Token: 0x06000B9C RID: 2972
		protected abstract global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos GetCTAxPos();

		// Token: 0x06000B9D RID: 2973
		protected abstract global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt GetCTNumFmt();

		// Token: 0x06000B9E RID: 2974
		protected abstract global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling GetCTScaling();

		// Token: 0x06000B9F RID: 2975
		protected abstract global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses GetCTCrosses();

		// Token: 0x06000BA0 RID: 2976
		protected abstract global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean GetDelete();

		// Token: 0x06000BA1 RID: 2977
		protected abstract global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark GetMajorCTTickMark();

		// Token: 0x06000BA2 RID: 2978
		protected abstract global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark GetMinorCTTickMark();

		// Token: 0x06000BA3 RID: 2979 RVA: 0x0002B315 File Offset: 0x00029515
		private static global::NPOI.OpenXmlFormats.Dml.Chart.ST_Orientation fromAxisOrientation(global::NPOI.SS.UserModel.Charts.AxisOrientation orientation)
		{
			if (orientation == global::NPOI.SS.UserModel.Charts.AxisOrientation.MaxToMin)
			{
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_Orientation.maxMin;
			}
			if (orientation == global::NPOI.SS.UserModel.Charts.AxisOrientation.MinToMax)
			{
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_Orientation.minMax;
			}
			throw new global::System.ArgumentException();
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0002B328 File Offset: 0x00029528
		private static global::NPOI.SS.UserModel.Charts.AxisOrientation toAxisOrientation(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Orientation ctOrientation)
		{
			global::NPOI.OpenXmlFormats.Dml.Chart.ST_Orientation val = ctOrientation.val;
			if (val == global::NPOI.OpenXmlFormats.Dml.Chart.ST_Orientation.maxMin)
			{
				return global::NPOI.SS.UserModel.Charts.AxisOrientation.MaxToMin;
			}
			if (val == global::NPOI.OpenXmlFormats.Dml.Chart.ST_Orientation.minMax)
			{
				return global::NPOI.SS.UserModel.Charts.AxisOrientation.MinToMax;
			}
			throw new global::System.ArgumentException();
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0002B34C File Offset: 0x0002954C
		private static global::NPOI.OpenXmlFormats.Dml.Chart.ST_Crosses fromAxisCrosses(global::NPOI.SS.UserModel.Charts.AxisCrosses crosses)
		{
			switch (crosses)
			{
			case global::NPOI.SS.UserModel.Charts.AxisCrosses.AutoZero:
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_Crosses.autoZero;
			case global::NPOI.SS.UserModel.Charts.AxisCrosses.Min:
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_Crosses.min;
			case global::NPOI.SS.UserModel.Charts.AxisCrosses.Max:
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_Crosses.max;
			default:
				throw new global::System.ArgumentException();
			}
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0002B370 File Offset: 0x00029570
		private static global::NPOI.SS.UserModel.Charts.AxisCrosses toAxisCrosses(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses ctCrosses)
		{
			switch (ctCrosses.val)
			{
			case global::NPOI.OpenXmlFormats.Dml.Chart.ST_Crosses.autoZero:
				return global::NPOI.SS.UserModel.Charts.AxisCrosses.AutoZero;
			case global::NPOI.OpenXmlFormats.Dml.Chart.ST_Crosses.max:
				return global::NPOI.SS.UserModel.Charts.AxisCrosses.Max;
			case global::NPOI.OpenXmlFormats.Dml.Chart.ST_Crosses.min:
				return global::NPOI.SS.UserModel.Charts.AxisCrosses.Min;
			default:
				throw new global::System.ArgumentException();
			}
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0002B3A3 File Offset: 0x000295A3
		private static global::NPOI.OpenXmlFormats.Dml.Chart.ST_AxPos fromAxisPosition(global::NPOI.SS.UserModel.Charts.AxisPosition position)
		{
			switch (position)
			{
			case global::NPOI.SS.UserModel.Charts.AxisPosition.Bottom:
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_AxPos.b;
			case global::NPOI.SS.UserModel.Charts.AxisPosition.Left:
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_AxPos.l;
			case global::NPOI.SS.UserModel.Charts.AxisPosition.Right:
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_AxPos.r;
			case global::NPOI.SS.UserModel.Charts.AxisPosition.Top:
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_AxPos.t;
			default:
				throw new global::System.ArgumentException();
			}
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x0002B3CC File Offset: 0x000295CC
		private static global::NPOI.SS.UserModel.Charts.AxisPosition toAxisPosition(global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos ctAxPos)
		{
			switch (ctAxPos.val)
			{
			case global::NPOI.OpenXmlFormats.Dml.Chart.ST_AxPos.b:
				return global::NPOI.SS.UserModel.Charts.AxisPosition.Bottom;
			case global::NPOI.OpenXmlFormats.Dml.Chart.ST_AxPos.l:
				return global::NPOI.SS.UserModel.Charts.AxisPosition.Left;
			case global::NPOI.OpenXmlFormats.Dml.Chart.ST_AxPos.r:
				return global::NPOI.SS.UserModel.Charts.AxisPosition.Right;
			case global::NPOI.OpenXmlFormats.Dml.Chart.ST_AxPos.t:
				return global::NPOI.SS.UserModel.Charts.AxisPosition.Top;
			default:
				return global::NPOI.SS.UserModel.Charts.AxisPosition.Bottom;
			}
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0002B401 File Offset: 0x00029601
		private static global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickMark fromAxisTickMark(global::NPOI.SS.UserModel.Charts.AxisTickMark tickMark)
		{
			switch (tickMark)
			{
			case global::NPOI.SS.UserModel.Charts.AxisTickMark.None:
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickMark.none;
			case global::NPOI.SS.UserModel.Charts.AxisTickMark.Cross:
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickMark.cross;
			case global::NPOI.SS.UserModel.Charts.AxisTickMark.In:
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickMark.@in;
			case global::NPOI.SS.UserModel.Charts.AxisTickMark.Out:
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickMark.@out;
			default:
				throw new global::System.ArgumentException("Unknown AxisTickMark: " + tickMark.ToString());
			}
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0002B440 File Offset: 0x00029640
		private static global::NPOI.SS.UserModel.Charts.AxisTickMark toAxisTickMark(global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark ctTickMark)
		{
			switch (ctTickMark.val)
			{
			case global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickMark.cross:
				return global::NPOI.SS.UserModel.Charts.AxisTickMark.Cross;
			case global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickMark.@in:
				return global::NPOI.SS.UserModel.Charts.AxisTickMark.In;
			case global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickMark.none:
				return global::NPOI.SS.UserModel.Charts.AxisTickMark.None;
			case global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickMark.@out:
				return global::NPOI.SS.UserModel.Charts.AxisTickMark.Out;
			default:
				return global::NPOI.SS.UserModel.Charts.AxisTickMark.Cross;
			}
		}

		// Token: 0x040003C2 RID: 962
		protected global::NPOI.XSSF.UserModel.XSSFChart chart;

		// Token: 0x040003C3 RID: 963
		private static double Min_LOG_BASE = 2.0;

		// Token: 0x040003C4 RID: 964
		private static double Max_LOG_BASE = 1000.0;
	}
}
