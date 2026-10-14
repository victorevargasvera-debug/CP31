using System;
using NPOI.OpenXmlFormats.Dml.Chart;
using NPOI.SS.UserModel.Charts;

namespace NPOI.XSSF.UserModel.Charts
{
	// Token: 0x020000BF RID: 191
	public class XSSFManualLayout : global::NPOI.SS.UserModel.Charts.IManualLayout
	{
		// Token: 0x06000BDA RID: 3034 RVA: 0x0002BAC1 File Offset: 0x00029CC1
		public XSSFManualLayout(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout ctLayout)
		{
			this.InitLayout(ctLayout);
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x0002BAD0 File Offset: 0x00029CD0
		public XSSFManualLayout(global::NPOI.XSSF.UserModel.XSSFChart chart)
		{
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_PlotArea plotArea = chart.GetCTChart().plotArea;
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout ctLayout = plotArea.IsSetLayout() ? plotArea.layout : plotArea.AddNewLayout();
			this.InitLayout(ctLayout);
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x0002BB0D File Offset: 0x00029D0D
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ManualLayout GetCTManualLayout()
		{
			return this.layout;
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0002BB15 File Offset: 0x00029D15
		public void SetWidthRatio(double ratio)
		{
			if (!this.layout.IsSetW())
			{
				this.layout.AddNewW();
			}
			this.layout.w.val = ratio;
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x0002BB41 File Offset: 0x00029D41
		public double GetWidthRatio()
		{
			if (!this.layout.IsSetW())
			{
				return 0.0;
			}
			return this.layout.w.val;
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x0002BB6A File Offset: 0x00029D6A
		public void SetHeightRatio(double ratio)
		{
			if (!this.layout.IsSetH())
			{
				this.layout.AddNewH();
			}
			this.layout.h.val = ratio;
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x0002BB96 File Offset: 0x00029D96
		public double GetHeightRatio()
		{
			if (!this.layout.IsSetH())
			{
				return 0.0;
			}
			return this.layout.h.val;
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x0002BBBF File Offset: 0x00029DBF
		public global::NPOI.SS.UserModel.Charts.LayoutTarget GetTarget()
		{
			if (!this.layout.IsSetLayoutTarget())
			{
				return global::NPOI.XSSF.UserModel.Charts.XSSFManualLayout.defaultLayoutTarget;
			}
			return this.toLayoutTarget(this.layout.layoutTarget);
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x0002BBE5 File Offset: 0x00029DE5
		public void SetTarget(global::NPOI.SS.UserModel.Charts.LayoutTarget target)
		{
			if (!this.layout.IsSetLayoutTarget())
			{
				this.layout.AddNewLayoutTarget();
			}
			this.layout.layoutTarget.val = this.fromLayoutTarget(target);
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0002BC17 File Offset: 0x00029E17
		public global::NPOI.SS.UserModel.Charts.LayoutMode GetXMode()
		{
			if (!this.layout.IsSetXMode())
			{
				return global::NPOI.XSSF.UserModel.Charts.XSSFManualLayout.defaultLayoutMode;
			}
			return this.toLayoutMode(this.layout.xMode);
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0002BC3D File Offset: 0x00029E3D
		public void SetXMode(global::NPOI.SS.UserModel.Charts.LayoutMode mode)
		{
			if (!this.layout.IsSetXMode())
			{
				this.layout.AddNewXMode();
			}
			this.layout.xMode.val = this.fromLayoutMode(mode);
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x0002BC6F File Offset: 0x00029E6F
		public global::NPOI.SS.UserModel.Charts.LayoutMode GetYMode()
		{
			if (!this.layout.IsSetYMode())
			{
				return global::NPOI.XSSF.UserModel.Charts.XSSFManualLayout.defaultLayoutMode;
			}
			return this.toLayoutMode(this.layout.yMode);
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x0002BC95 File Offset: 0x00029E95
		public void SetYMode(global::NPOI.SS.UserModel.Charts.LayoutMode mode)
		{
			if (!this.layout.IsSetYMode())
			{
				this.layout.AddNewYMode();
			}
			this.layout.yMode.val = this.fromLayoutMode(mode);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x0002BCC7 File Offset: 0x00029EC7
		public double GetX()
		{
			if (!this.layout.IsSetX())
			{
				return 0.0;
			}
			return this.layout.x.val;
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0002BCF0 File Offset: 0x00029EF0
		public void SetX(double x)
		{
			if (!this.layout.IsSetX())
			{
				this.layout.AddNewX();
			}
			this.layout.x.val = x;
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0002BD1C File Offset: 0x00029F1C
		public double GetY()
		{
			if (!this.layout.IsSetY())
			{
				return 0.0;
			}
			return this.layout.y.val;
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x0002BD45 File Offset: 0x00029F45
		public void SetY(double y)
		{
			if (!this.layout.IsSetY())
			{
				this.layout.AddNewY();
			}
			this.layout.y.val = y;
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x0002BD71 File Offset: 0x00029F71
		public global::NPOI.SS.UserModel.Charts.LayoutMode GetWidthMode()
		{
			if (!this.layout.IsSetWMode())
			{
				return global::NPOI.XSSF.UserModel.Charts.XSSFManualLayout.defaultLayoutMode;
			}
			return this.toLayoutMode(this.layout.wMode);
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x0002BD97 File Offset: 0x00029F97
		public void SetWidthMode(global::NPOI.SS.UserModel.Charts.LayoutMode mode)
		{
			if (!this.layout.IsSetWMode())
			{
				this.layout.AddNewWMode();
			}
			this.layout.wMode.val = this.fromLayoutMode(mode);
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x0002BDC9 File Offset: 0x00029FC9
		public global::NPOI.SS.UserModel.Charts.LayoutMode GetHeightMode()
		{
			if (!this.layout.IsSetHMode())
			{
				return global::NPOI.XSSF.UserModel.Charts.XSSFManualLayout.defaultLayoutMode;
			}
			return this.toLayoutMode(this.layout.hMode);
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x0002BDEF File Offset: 0x00029FEF
		public void SetHeightMode(global::NPOI.SS.UserModel.Charts.LayoutMode mode)
		{
			if (!this.layout.IsSetHMode())
			{
				this.layout.AddNewHMode();
			}
			this.layout.hMode.val = this.fromLayoutMode(mode);
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x0002BE21 File Offset: 0x0002A021
		private void InitLayout(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout ctLayout)
		{
			if (ctLayout.IsSetManualLayout())
			{
				this.layout = ctLayout.manualLayout;
				return;
			}
			this.layout = ctLayout.AddNewManualLayout();
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0002BE44 File Offset: 0x0002A044
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutMode fromLayoutMode(global::NPOI.SS.UserModel.Charts.LayoutMode mode)
		{
			if (mode == global::NPOI.SS.UserModel.Charts.LayoutMode.Edge)
			{
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutMode.edge;
			}
			if (mode != global::NPOI.SS.UserModel.Charts.LayoutMode.Factor)
			{
				throw new global::System.ArgumentException();
			}
			return global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutMode.factor;
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x0002BE58 File Offset: 0x0002A058
		private global::NPOI.SS.UserModel.Charts.LayoutMode toLayoutMode(global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode ctLayoutMode)
		{
			global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutMode val = ctLayoutMode.val;
			if (val == global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutMode.edge)
			{
				return global::NPOI.SS.UserModel.Charts.LayoutMode.Edge;
			}
			if (val != global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutMode.factor)
			{
				throw new global::System.ArgumentException();
			}
			return global::NPOI.SS.UserModel.Charts.LayoutMode.Factor;
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x0002BE44 File Offset: 0x0002A044
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutTarget fromLayoutTarget(global::NPOI.SS.UserModel.Charts.LayoutTarget target)
		{
			if (target == global::NPOI.SS.UserModel.Charts.LayoutTarget.Inner)
			{
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutTarget.inner;
			}
			if (target != global::NPOI.SS.UserModel.Charts.LayoutTarget.Outer)
			{
				throw new global::System.ArgumentException();
			}
			return global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutTarget.outer;
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x0002BE80 File Offset: 0x0002A080
		private global::NPOI.SS.UserModel.Charts.LayoutTarget toLayoutTarget(global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutTarget ctLayoutTarget)
		{
			global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutTarget val = ctLayoutTarget.val;
			if (val == global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutTarget.inner)
			{
				return global::NPOI.SS.UserModel.Charts.LayoutTarget.Inner;
			}
			if (val != global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutTarget.outer)
			{
				throw new global::System.ArgumentException();
			}
			return global::NPOI.SS.UserModel.Charts.LayoutTarget.Outer;
		}

		// Token: 0x040003C9 RID: 969
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ManualLayout layout;

		// Token: 0x040003CA RID: 970
		private static global::NPOI.SS.UserModel.Charts.LayoutMode defaultLayoutMode;

		// Token: 0x040003CB RID: 971
		private static global::NPOI.SS.UserModel.Charts.LayoutTarget defaultLayoutTarget;
	}
}
