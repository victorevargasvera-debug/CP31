using System;
using System.Collections.Generic;
using NLog.Config;
using NLog.LayoutRenderers;
using NLog.Layouts;

namespace NLog.Targets
{
	// Token: 0x0200004B RID: 75
	[global::NLog.Targets.Target("NLogViewer")]
	public class NLogViewerTarget : global::NLog.Targets.NetworkTarget, global::NLog.IIncludeContext
	{
		// Token: 0x060006D6 RID: 1750 RVA: 0x0001112C File Offset: 0x0000F32C
		public NLogViewerTarget()
		{
			this.Parameters = new global::System.Collections.Generic.List<global::NLog.Targets.NLogViewerParameterInfo>();
			this.Renderer.Parameters = this.Parameters;
			base.OnConnectionOverflow = global::NLog.Targets.NetworkTargetConnectionsOverflowAction.Block;
			base.MaxConnections = 16;
			base.NewLine = false;
			base.OptimizeBufferReuse = (base.GetType() == typeof(global::NLog.Targets.NLogViewerTarget));
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00011197 File Offset: 0x0000F397
		public NLogViewerTarget(string name) : this()
		{
			base.Name = name;
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x000111A6 File Offset: 0x0000F3A6
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x000111B3 File Offset: 0x0000F3B3
		public bool IncludeNLogData
		{
			get
			{
				return this.Renderer.IncludeNLogData;
			}
			set
			{
				this.Renderer.IncludeNLogData = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x000111C1 File Offset: 0x0000F3C1
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x000111CE File Offset: 0x0000F3CE
		public string AppInfo
		{
			get
			{
				return this.Renderer.AppInfo;
			}
			set
			{
				this.Renderer.AppInfo = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x000111DC File Offset: 0x0000F3DC
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x000111E9 File Offset: 0x0000F3E9
		public bool IncludeCallSite
		{
			get
			{
				return this.Renderer.IncludeCallSite;
			}
			set
			{
				this.Renderer.IncludeCallSite = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x000111F7 File Offset: 0x0000F3F7
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x00011204 File Offset: 0x0000F404
		public bool IncludeSourceInfo
		{
			get
			{
				return this.Renderer.IncludeSourceInfo;
			}
			set
			{
				this.Renderer.IncludeSourceInfo = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00011212 File Offset: 0x0000F412
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x0001121F File Offset: 0x0000F41F
		public bool IncludeMdc
		{
			get
			{
				return this.Renderer.IncludeMdc;
			}
			set
			{
				this.Renderer.IncludeMdc = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x0001122D File Offset: 0x0000F42D
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x0001123A File Offset: 0x0000F43A
		public bool IncludeNdc
		{
			get
			{
				return this.Renderer.IncludeNdc;
			}
			set
			{
				this.Renderer.IncludeNdc = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x00011248 File Offset: 0x0000F448
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x00011255 File Offset: 0x0000F455
		public bool IncludeMdlc
		{
			get
			{
				return this.Renderer.IncludeMdlc;
			}
			set
			{
				this.Renderer.IncludeMdlc = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00011263 File Offset: 0x0000F463
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x00011270 File Offset: 0x0000F470
		public bool IncludeNdlc
		{
			get
			{
				return this.Renderer.IncludeNdlc;
			}
			set
			{
				this.Renderer.IncludeNdlc = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x0001127E File Offset: 0x0000F47E
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x0001128B File Offset: 0x0000F48B
		public string NdlcItemSeparator
		{
			get
			{
				return this.Renderer.NdlcItemSeparator;
			}
			set
			{
				this.Renderer.NdlcItemSeparator = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x00011299 File Offset: 0x0000F499
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x000112A6 File Offset: 0x0000F4A6
		public bool IncludeAllProperties
		{
			get
			{
				return this.Renderer.IncludeAllProperties;
			}
			set
			{
				this.Renderer.IncludeAllProperties = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x000112B4 File Offset: 0x0000F4B4
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x000112C1 File Offset: 0x0000F4C1
		public string NdcItemSeparator
		{
			get
			{
				return this.Renderer.NdcItemSeparator;
			}
			set
			{
				this.Renderer.NdcItemSeparator = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x000112CF File Offset: 0x0000F4CF
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x000112DC File Offset: 0x0000F4DC
		public global::NLog.Layouts.Layout LoggerName
		{
			get
			{
				return this.Renderer.LoggerName;
			}
			set
			{
				this.Renderer.LoggerName = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x000112EA File Offset: 0x0000F4EA
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x000112F2 File Offset: 0x0000F4F2
		[global::NLog.Config.ArrayParameter(typeof(global::NLog.Targets.NLogViewerParameterInfo), "parameter")]
		public global::System.Collections.Generic.IList<global::NLog.Targets.NLogViewerParameterInfo> Parameters { get; private set; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x000112FB File Offset: 0x0000F4FB
		public global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer Renderer
		{
			get
			{
				return this._layout.Renderer;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00011308 File Offset: 0x0000F508
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00011310 File Offset: 0x0000F510
		public override global::NLog.Layouts.Layout Layout
		{
			get
			{
				return this._layout;
			}
			set
			{
			}
		}

		// Token: 0x04000154 RID: 340
		private readonly global::NLog.Layouts.Log4JXmlEventLayout _layout = new global::NLog.Layouts.Log4JXmlEventLayout();
	}
}
