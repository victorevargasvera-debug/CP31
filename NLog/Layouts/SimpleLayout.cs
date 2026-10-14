using System;
using System.Collections.ObjectModel;
using System.Text;
using NLog.Common;
using NLog.Config;
using NLog.Internal;
using NLog.LayoutRenderers;

namespace NLog.Layouts
{
	// Token: 0x020000A4 RID: 164
	[global::NLog.Layouts.Layout("SimpleLayout")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	[global::NLog.Config.AppDomainFixedOutput]
	public class SimpleLayout : global::NLog.Layouts.Layout, global::NLog.Internal.IUsesStackTrace
	{
		// Token: 0x06000A24 RID: 2596 RVA: 0x0001A049 File Offset: 0x00018249
		public SimpleLayout() : this(string.Empty)
		{
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0001A056 File Offset: 0x00018256
		public SimpleLayout(string txt) : this(txt, global::NLog.Config.ConfigurationItemFactory.Default)
		{
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0001A064 File Offset: 0x00018264
		public SimpleLayout(string txt, global::NLog.Config.ConfigurationItemFactory configurationItemFactory)
		{
			this._configurationItemFactory = configurationItemFactory;
			this.Text = txt;
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0001A07A File Offset: 0x0001827A
		internal SimpleLayout(global::NLog.LayoutRenderers.LayoutRenderer[] renderers, string text, global::NLog.Config.ConfigurationItemFactory configurationItemFactory)
		{
			this._configurationItemFactory = configurationItemFactory;
			this.SetRenderers(renderers, text);
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0001A091 File Offset: 0x00018291
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x0001A099 File Offset: 0x00018299
		public string OriginalText { get; private set; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0001A0A2 File Offset: 0x000182A2
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x0001A0AC File Offset: 0x000182AC
		public string Text
		{
			get
			{
				return this._layoutText;
			}
			set
			{
				this.OriginalText = value;
				global::NLog.LayoutRenderers.LayoutRenderer[] renderers;
				string empty;
				if (value == null)
				{
					renderers = global::NLog.Internal.ArrayHelper.Empty<global::NLog.LayoutRenderers.LayoutRenderer>();
					empty = string.Empty;
				}
				else
				{
					renderers = global::NLog.Layouts.LayoutParser.CompileLayout(this._configurationItemFactory, new global::NLog.Internal.SimpleStringReader(value), false, out empty);
				}
				this.SetRenderers(renderers, empty);
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0001A0EE File Offset: 0x000182EE
		public bool IsFixedText
		{
			get
			{
				return this._fixedText != null;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0001A0F9 File Offset: 0x000182F9
		public string FixedText
		{
			get
			{
				return this._fixedText;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x0001A101 File Offset: 0x00018301
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x0001A109 File Offset: 0x00018309
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::NLog.LayoutRenderers.LayoutRenderer> Renderers { get; private set; }

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x0001A112 File Offset: 0x00018312
		public new global::NLog.Config.StackTraceUsage StackTraceUsage
		{
			get
			{
				return base.StackTraceUsage;
			}
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0001A11A File Offset: 0x0001831A
		public new static implicit operator global::NLog.Layouts.SimpleLayout(string text)
		{
			if (text == null)
			{
				return null;
			}
			return new global::NLog.Layouts.SimpleLayout(text);
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0001A127 File Offset: 0x00018327
		public static string Escape(string text)
		{
			return text.Replace("${", "${literal:text=${}");
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0001A139 File Offset: 0x00018339
		public static string Evaluate(string text, global::NLog.LogEventInfo logEvent)
		{
			return new global::NLog.Layouts.SimpleLayout(text).Render(logEvent);
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0001A147 File Offset: 0x00018347
		public static string Evaluate(string text)
		{
			return global::NLog.Layouts.SimpleLayout.Evaluate(text, global::NLog.LogEventInfo.CreateNullEvent());
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0001A154 File Offset: 0x00018354
		public override string ToString()
		{
			if (string.IsNullOrEmpty(this.Text))
			{
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::NLog.LayoutRenderers.LayoutRenderer> renderers = this.Renderers;
				if (renderers != null && renderers.Count > 0)
				{
					return base.ToStringWithNestedItems<global::NLog.LayoutRenderers.LayoutRenderer>(this.Renderers, (global::NLog.LayoutRenderers.LayoutRenderer r) => r.ToString());
				}
			}
			return "'" + this.Text + "'";
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x0001A1C8 File Offset: 0x000183C8
		internal void SetRenderers(global::NLog.LayoutRenderers.LayoutRenderer[] renderers, string text)
		{
			this.Renderers = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::NLog.LayoutRenderers.LayoutRenderer>(renderers);
			global::NLog.LayoutRenderers.LiteralLayoutRenderer literalLayoutRenderer;
			if (this.Renderers.Count == 1 && (literalLayoutRenderer = (this.Renderers[0] as global::NLog.LayoutRenderers.LiteralLayoutRenderer)) != null)
			{
				this._fixedText = literalLayoutRenderer.Text;
			}
			else
			{
				this._fixedText = null;
			}
			this._layoutText = text;
			if (base.LoggingConfiguration != null)
			{
				base.PerformObjectScanning();
			}
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0001A230 File Offset: 0x00018430
		protected override void InitializeLayout()
		{
			for (int i = 0; i < this.Renderers.Count; i++)
			{
				global::NLog.LayoutRenderers.LayoutRenderer layoutRenderer = this.Renderers[i];
				try
				{
					layoutRenderer.Initialize(base.LoggingConfiguration);
				}
				catch (global::System.Exception ex)
				{
					if (global::NLog.Common.InternalLogger.IsWarnEnabled || global::NLog.Common.InternalLogger.IsErrorEnabled)
					{
						global::NLog.Common.InternalLogger.Warn(ex, "Exception in '{0}.InitializeLayout()'", new object[]
						{
							layoutRenderer.GetType().FullName
						});
					}
					if (ex.MustBeRethrown())
					{
						throw;
					}
				}
			}
			base.InitializeLayout();
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0001A2C0 File Offset: 0x000184C0
		internal override void PrecalculateBuilder(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
		{
			base.PrecalculateBuilderInternal(logEvent, target);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0001A2CA File Offset: 0x000184CA
		protected override string GetFormattedMessage(global::NLog.LogEventInfo logEvent)
		{
			if (this.IsFixedText)
			{
				return this._fixedText;
			}
			return base.RenderAllocateBuilder(logEvent, null);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0001A2E4 File Offset: 0x000184E4
		private void RenderAllRenderers(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
		{
			for (int i = 0; i < this.Renderers.Count; i++)
			{
				global::NLog.LayoutRenderers.LayoutRenderer layoutRenderer = this.Renderers[i];
				try
				{
					layoutRenderer.RenderAppendBuilder(logEvent, target);
				}
				catch (global::System.Exception ex)
				{
					if (global::NLog.Common.InternalLogger.IsWarnEnabled || global::NLog.Common.InternalLogger.IsErrorEnabled)
					{
						global::NLog.Common.InternalLogger.Warn(ex, "Exception in '{0}.Append()'", new object[]
						{
							layoutRenderer.GetType().FullName
						});
					}
					if (ex.MustBeRethrown())
					{
						throw;
					}
				}
			}
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0001A368 File Offset: 0x00018568
		protected override void RenderFormattedMessage(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
		{
			if (this.IsFixedText)
			{
				target.Append(this._fixedText);
				return;
			}
			this.RenderAllRenderers(logEvent, target);
		}

		// Token: 0x0400026A RID: 618
		private string _fixedText;

		// Token: 0x0400026B RID: 619
		private string _layoutText;

		// Token: 0x0400026C RID: 620
		private readonly global::NLog.Config.ConfigurationItemFactory _configurationItemFactory;
	}
}
