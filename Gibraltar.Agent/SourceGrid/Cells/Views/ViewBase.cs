using System;
using System.Drawing;
using DevAge.Drawing;
using DevAge.Drawing.VisualElements;

namespace SourceGrid.Cells.Views
{
	// Token: 0x02000343 RID: 835
	[global::System.Serializable]
	internal abstract class ViewBase : global::DevAge.Drawing.VisualElements.ContainerBase, global::SourceGrid.Cells.Views.IView, global::System.ICloneable
	{
		// Token: 0x06002859 RID: 10329 RVA: 0x0008C288 File Offset: 0x0008A488
		static ViewBase()
		{
			global::SourceGrid.Cells.Views.ViewBase.Initialize();
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x0008C290 File Offset: 0x0008A490
		public static void Initialize()
		{
			if (global::SourceGrid.Cells.Views.ViewBase.t_Initialized)
			{
				return;
			}
			global::SourceGrid.Cells.Views.ViewBase.t_DefaultBorder = new global::DevAge.Drawing.RectangleBorder(new global::DevAge.Drawing.BorderLine(global::System.Drawing.Color.LightGray, 1f), new global::DevAge.Drawing.BorderLine(global::System.Drawing.Color.LightGray, 1f));
			global::SourceGrid.Cells.Views.ViewBase.t_DefaultPadding = new global::DevAge.Drawing.Padding(2f);
			global::SourceGrid.Cells.Views.ViewBase.t_DefaultBackColor = global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.Window);
			global::SourceGrid.Cells.Views.ViewBase.t_DefaultForeColor = global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.WindowText);
			global::SourceGrid.Cells.Views.ViewBase.t_DefaultAlignment = global::DevAge.Drawing.ContentAlignment.MiddleLeft;
			global::SourceGrid.Cells.Views.ViewBase.t_Initialized = true;
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x0600285B RID: 10331 RVA: 0x0008C308 File Offset: 0x0008A508
		// (set) Token: 0x0600285C RID: 10332 RVA: 0x0008C314 File Offset: 0x0008A514
		public static global::DevAge.Drawing.RectangleBorder DefaultBorder
		{
			get
			{
				global::SourceGrid.Cells.Views.ViewBase.Initialize();
				return global::SourceGrid.Cells.Views.ViewBase.t_DefaultBorder;
			}
			set
			{
				global::SourceGrid.Cells.Views.ViewBase.Initialize();
				global::SourceGrid.Cells.Views.ViewBase.t_DefaultBorder = value;
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x0600285D RID: 10333 RVA: 0x0008C324 File Offset: 0x0008A524
		// (set) Token: 0x0600285E RID: 10334 RVA: 0x0008C330 File Offset: 0x0008A530
		public static global::DevAge.Drawing.Padding DefaultPadding
		{
			get
			{
				global::SourceGrid.Cells.Views.ViewBase.Initialize();
				return global::SourceGrid.Cells.Views.ViewBase.t_DefaultPadding;
			}
			set
			{
				global::SourceGrid.Cells.Views.ViewBase.Initialize();
				global::SourceGrid.Cells.Views.ViewBase.t_DefaultPadding = value;
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x0600285F RID: 10335 RVA: 0x0008C340 File Offset: 0x0008A540
		// (set) Token: 0x06002860 RID: 10336 RVA: 0x0008C34C File Offset: 0x0008A54C
		public static global::System.Drawing.Color DefaultBackColor
		{
			get
			{
				global::SourceGrid.Cells.Views.ViewBase.Initialize();
				return global::SourceGrid.Cells.Views.ViewBase.t_DefaultBackColor;
			}
			set
			{
				global::SourceGrid.Cells.Views.ViewBase.Initialize();
				global::SourceGrid.Cells.Views.ViewBase.t_DefaultBackColor = value;
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06002861 RID: 10337 RVA: 0x0008C35C File Offset: 0x0008A55C
		// (set) Token: 0x06002862 RID: 10338 RVA: 0x0008C368 File Offset: 0x0008A568
		public static global::System.Drawing.Color DefaultForeColor
		{
			get
			{
				global::SourceGrid.Cells.Views.ViewBase.Initialize();
				return global::SourceGrid.Cells.Views.ViewBase.t_DefaultForeColor;
			}
			set
			{
				global::SourceGrid.Cells.Views.ViewBase.Initialize();
				global::SourceGrid.Cells.Views.ViewBase.t_DefaultForeColor = value;
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06002863 RID: 10339 RVA: 0x0008C378 File Offset: 0x0008A578
		// (set) Token: 0x06002864 RID: 10340 RVA: 0x0008C384 File Offset: 0x0008A584
		public static global::DevAge.Drawing.ContentAlignment DefaultAlignment
		{
			get
			{
				global::SourceGrid.Cells.Views.ViewBase.Initialize();
				return global::SourceGrid.Cells.Views.ViewBase.t_DefaultAlignment;
			}
			set
			{
				global::SourceGrid.Cells.Views.ViewBase.Initialize();
				global::SourceGrid.Cells.Views.ViewBase.t_DefaultAlignment = value;
			}
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x0008C394 File Offset: 0x0008A594
		protected ViewBase()
		{
			this.Background = new global::DevAge.Drawing.VisualElements.BackgroundSolid();
			this.Padding = global::SourceGrid.Cells.Views.ViewBase.DefaultPadding;
			this.ForeColor = global::SourceGrid.Cells.Views.ViewBase.DefaultForeColor;
			this.BackColor = global::SourceGrid.Cells.Views.ViewBase.DefaultBackColor;
			this.Border = global::SourceGrid.Cells.Views.ViewBase.DefaultBorder;
			this.TextAlignment = global::SourceGrid.Cells.Views.ViewBase.DefaultAlignment;
			this.ImageAlignment = global::SourceGrid.Cells.Views.ViewBase.DefaultAlignment;
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x0008C404 File Offset: 0x0008A604
		protected ViewBase(global::SourceGrid.Cells.Views.ViewBase p_Source) : base(p_Source)
		{
			this.ForeColor = p_Source.ForeColor;
			this.BackColor = p_Source.BackColor;
			this.Border = p_Source.Border;
			this.Padding = p_Source.Padding;
			global::System.Drawing.Font font = null;
			if (p_Source.Font != null)
			{
				font = (global::System.Drawing.Font)p_Source.Font.Clone();
			}
			this.Font = font;
			this.WordWrap = p_Source.WordWrap;
			this.TextAlignment = p_Source.TextAlignment;
			this.TrimmingMode = p_Source.TrimmingMode;
			this.ImageAlignment = p_Source.ImageAlignment;
			this.ImageStretch = p_Source.ImageStretch;
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06002867 RID: 10343 RVA: 0x0008C4B4 File Offset: 0x0008A6B4
		// (set) Token: 0x06002868 RID: 10344 RVA: 0x0008C4BC File Offset: 0x0008A6BC
		public bool ImageStretch
		{
			get
			{
				return this.m_ImageStretch;
			}
			set
			{
				this.m_ImageStretch = value;
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06002869 RID: 10345 RVA: 0x0008C4C8 File Offset: 0x0008A6C8
		// (set) Token: 0x0600286A RID: 10346 RVA: 0x0008C4D0 File Offset: 0x0008A6D0
		public global::DevAge.Drawing.ContentAlignment ImageAlignment
		{
			get
			{
				return this.m_ImageAlignment;
			}
			set
			{
				this.m_ImageAlignment = value;
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x0600286B RID: 10347 RVA: 0x0008C4DC File Offset: 0x0008A6DC
		// (set) Token: 0x0600286C RID: 10348 RVA: 0x0008C4E4 File Offset: 0x0008A6E4
		public global::System.Drawing.Font Font
		{
			get
			{
				return this.m_Font;
			}
			set
			{
				this.m_Font = value;
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x0600286D RID: 10349 RVA: 0x0008C4F0 File Offset: 0x0008A6F0
		// (set) Token: 0x0600286E RID: 10350 RVA: 0x0008C4F8 File Offset: 0x0008A6F8
		public global::System.Drawing.Color ForeColor
		{
			get
			{
				return this.m_ForeColor;
			}
			set
			{
				this.m_ForeColor = value;
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x0600286F RID: 10351 RVA: 0x0008C504 File Offset: 0x0008A704
		// (set) Token: 0x06002870 RID: 10352 RVA: 0x0008C50C File Offset: 0x0008A70C
		public bool WordWrap
		{
			get
			{
				return this.mWordWrap;
			}
			set
			{
				this.mWordWrap = value;
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06002871 RID: 10353 RVA: 0x0008C518 File Offset: 0x0008A718
		// (set) Token: 0x06002872 RID: 10354 RVA: 0x0008C520 File Offset: 0x0008A720
		public global::SourceGrid.TrimmingMode TrimmingMode
		{
			get
			{
				return this.mTrimmingMode;
			}
			set
			{
				this.mTrimmingMode = value;
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06002873 RID: 10355 RVA: 0x0008C52C File Offset: 0x0008A72C
		// (set) Token: 0x06002874 RID: 10356 RVA: 0x0008C534 File Offset: 0x0008A734
		public global::DevAge.Drawing.ContentAlignment TextAlignment
		{
			get
			{
				return this.mTextAlignment;
			}
			set
			{
				this.mTextAlignment = value;
			}
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x0008C540 File Offset: 0x0008A740
		public virtual global::System.Drawing.Font GetDrawingFont(global::SourceGrid.GridVirtual grid)
		{
			if (this.Font == null)
			{
				return grid.Font;
			}
			return this.Font;
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06002876 RID: 10358 RVA: 0x0008C55C File Offset: 0x0008A75C
		// (set) Token: 0x06002877 RID: 10359 RVA: 0x0008C584 File Offset: 0x0008A784
		public global::System.Drawing.Color BackColor
		{
			get
			{
				if (this.Background is global::DevAge.Drawing.VisualElements.BackgroundSolid)
				{
					return ((global::DevAge.Drawing.VisualElements.BackgroundSolid)this.Background).BackColor;
				}
				return global::SourceGrid.Cells.Views.ViewBase.DefaultBackColor;
			}
			set
			{
				if (this.Background is global::DevAge.Drawing.VisualElements.BackgroundSolid)
				{
					((global::DevAge.Drawing.VisualElements.BackgroundSolid)this.Background).BackColor = value;
				}
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06002878 RID: 10360 RVA: 0x0008C5A8 File Offset: 0x0008A7A8
		// (set) Token: 0x06002879 RID: 10361 RVA: 0x0008C5B0 File Offset: 0x0008A7B0
		public new global::DevAge.Drawing.IBorder Border
		{
			get
			{
				return base.Border;
			}
			set
			{
				base.Border = value;
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x0600287A RID: 10362 RVA: 0x0008C5BC File Offset: 0x0008A7BC
		// (set) Token: 0x0600287B RID: 10363 RVA: 0x0008C5C4 File Offset: 0x0008A7C4
		public new global::DevAge.Drawing.Padding Padding
		{
			get
			{
				return base.Padding;
			}
			set
			{
				base.Padding = value;
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x0600287C RID: 10364 RVA: 0x0008C5D0 File Offset: 0x0008A7D0
		// (set) Token: 0x0600287D RID: 10365 RVA: 0x0008C5D8 File Offset: 0x0008A7D8
		public new global::DevAge.Drawing.ElementsDrawMode ElementsDrawMode
		{
			get
			{
				return base.ElementsDrawMode;
			}
			set
			{
				base.ElementsDrawMode = value;
			}
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x0008C5E4 File Offset: 0x0008A7E4
		public void DrawCell(global::SourceGrid.CellContext cellContext, global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF rectangle)
		{
			this.PrepareView(cellContext);
			base.Draw(graphics, rectangle);
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x0008C5F8 File Offset: 0x0008A7F8
		protected virtual void PrepareView(global::SourceGrid.CellContext context)
		{
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x0008C5FC File Offset: 0x0008A7FC
		public global::System.Drawing.Size Measure(global::SourceGrid.CellContext cellContext, global::System.Drawing.Size maxLayoutArea)
		{
			global::System.Drawing.Size result;
			using (global::DevAge.Drawing.MeasureHelper measureHelper = new global::DevAge.Drawing.MeasureHelper(cellContext.Grid))
			{
				this.PrepareView(cellContext);
				global::System.Drawing.SizeF value = base.Measure(measureHelper, global::System.Drawing.SizeF.Empty, maxLayoutArea);
				result = global::System.Drawing.Size.Ceiling(value);
			}
			return result;
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06002881 RID: 10369 RVA: 0x0008C65C File Offset: 0x0008A85C
		// (set) Token: 0x06002882 RID: 10370 RVA: 0x0008C664 File Offset: 0x0008A864
		public new global::DevAge.Drawing.VisualElements.IVisualElement Background
		{
			get
			{
				return base.Background;
			}
			set
			{
				base.Background = value;
			}
		}

		// Token: 0x04000DF2 RID: 3570
		[global::System.ThreadStatic]
		private static global::DevAge.Drawing.RectangleBorder t_DefaultBorder;

		// Token: 0x04000DF3 RID: 3571
		[global::System.ThreadStatic]
		private static global::DevAge.Drawing.Padding t_DefaultPadding;

		// Token: 0x04000DF4 RID: 3572
		[global::System.ThreadStatic]
		private static global::System.Drawing.Color t_DefaultBackColor;

		// Token: 0x04000DF5 RID: 3573
		[global::System.ThreadStatic]
		private static global::System.Drawing.Color t_DefaultForeColor;

		// Token: 0x04000DF6 RID: 3574
		[global::System.ThreadStatic]
		private static global::DevAge.Drawing.ContentAlignment t_DefaultAlignment;

		// Token: 0x04000DF7 RID: 3575
		[global::System.ThreadStatic]
		private static bool t_Initialized;

		// Token: 0x04000DF8 RID: 3576
		private bool m_ImageStretch;

		// Token: 0x04000DF9 RID: 3577
		private global::DevAge.Drawing.ContentAlignment m_ImageAlignment;

		// Token: 0x04000DFA RID: 3578
		private global::System.Drawing.Font m_Font;

		// Token: 0x04000DFB RID: 3579
		private global::System.Drawing.Color m_ForeColor;

		// Token: 0x04000DFC RID: 3580
		private bool mWordWrap;

		// Token: 0x04000DFD RID: 3581
		private global::SourceGrid.TrimmingMode mTrimmingMode = global::SourceGrid.TrimmingMode.Char;

		// Token: 0x04000DFE RID: 3582
		private global::DevAge.Drawing.ContentAlignment mTextAlignment;
	}
}
