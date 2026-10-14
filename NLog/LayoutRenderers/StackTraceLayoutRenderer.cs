using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000DA RID: 218
	[global::NLog.LayoutRenderers.LayoutRenderer("stacktrace")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class StackTraceLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer, global::NLog.Internal.IUsesStackTrace
	{
		// Token: 0x06000BD1 RID: 3025 RVA: 0x0001D946 File Offset: 0x0001BB46
		public StackTraceLayoutRenderer()
		{
			this.Separator = " => ";
			this.TopFrames = 3;
			this.Format = global::NLog.LayoutRenderers.StackTraceFormat.Flat;
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x0001D967 File Offset: 0x0001BB67
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x0001D96F File Offset: 0x0001BB6F
		[global::System.ComponentModel.DefaultValue("Flat")]
		public global::NLog.LayoutRenderers.StackTraceFormat Format { get; set; }

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x0001D978 File Offset: 0x0001BB78
		// (set) Token: 0x06000BD5 RID: 3029 RVA: 0x0001D980 File Offset: 0x0001BB80
		[global::System.ComponentModel.DefaultValue(3)]
		public int TopFrames { get; set; }

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x0001D989 File Offset: 0x0001BB89
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x0001D991 File Offset: 0x0001BB91
		[global::System.ComponentModel.DefaultValue(0)]
		public int SkipFrames { get; set; }

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x0001D99A File Offset: 0x0001BB9A
		// (set) Token: 0x06000BD9 RID: 3033 RVA: 0x0001D9A2 File Offset: 0x0001BBA2
		[global::System.ComponentModel.DefaultValue(" => ")]
		public string Separator { get; set; }

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x0001D9AB File Offset: 0x0001BBAB
		global::NLog.Config.StackTraceUsage global::NLog.Internal.IUsesStackTrace.StackTraceUsage
		{
			get
			{
				if (this.Format != global::NLog.LayoutRenderers.StackTraceFormat.Raw)
				{
					return global::NLog.Config.StackTraceUsage.WithoutSource;
				}
				return global::NLog.Config.StackTraceUsage.WithSource;
			}
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x0001D9B8 File Offset: 0x0001BBB8
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			if (logEvent.StackTrace == null)
			{
				return;
			}
			int num = logEvent.UserStackFrameNumber + this.TopFrames - 1;
			if (num >= logEvent.StackTrace.GetFrameCount())
			{
				num = logEvent.StackTrace.GetFrameCount() - 1;
			}
			int endingFrame = logEvent.UserStackFrameNumber + this.SkipFrames;
			switch (this.Format)
			{
			case global::NLog.LayoutRenderers.StackTraceFormat.Raw:
				global::NLog.LayoutRenderers.StackTraceLayoutRenderer.AppendRaw(builder, logEvent, num, endingFrame);
				return;
			case global::NLog.LayoutRenderers.StackTraceFormat.Flat:
				this.AppendFlat(builder, logEvent, num, endingFrame);
				return;
			case global::NLog.LayoutRenderers.StackTraceFormat.DetailedFlat:
				this.AppendDetailedFlat(builder, logEvent, num, endingFrame);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x0001DA44 File Offset: 0x0001BC44
		private static void AppendRaw(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent, int startingFrame, int endingFrame)
		{
			for (int i = startingFrame; i >= endingFrame; i--)
			{
				global::System.Diagnostics.StackFrame frame = logEvent.StackTrace.GetFrame(i);
				builder.Append(frame.ToString());
			}
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0001DA78 File Offset: 0x0001BC78
		private void AppendFlat(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent, int startingFrame, int endingFrame)
		{
			bool flag = true;
			for (int i = startingFrame; i >= endingFrame; i--)
			{
				global::System.Diagnostics.StackFrame frame = logEvent.StackTrace.GetFrame(i);
				if (!flag)
				{
					builder.Append(this.Separator);
				}
				global::System.Reflection.MethodBase method = frame.GetMethod();
				if (!(method == null))
				{
					global::System.Type declaringType = method.DeclaringType;
					if (declaringType != null)
					{
						builder.Append(declaringType.Name);
					}
					else
					{
						builder.Append("<no type>");
					}
					builder.Append(".");
					builder.Append(method.Name);
					flag = false;
				}
			}
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x0001DB08 File Offset: 0x0001BD08
		private void AppendDetailedFlat(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent, int startingFrame, int endingFrame)
		{
			bool flag = true;
			for (int i = startingFrame; i >= endingFrame; i--)
			{
				global::System.Reflection.MethodBase method = logEvent.StackTrace.GetFrame(i).GetMethod();
				if (!(method == null))
				{
					if (!flag)
					{
						builder.Append(this.Separator);
					}
					builder.Append("[");
					builder.Append(method);
					builder.Append("]");
					flag = false;
				}
			}
		}
	}
}
