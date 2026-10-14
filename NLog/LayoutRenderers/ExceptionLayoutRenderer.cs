using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using NLog.Common;
using NLog.Config;
using NLog.Internal;
using NLog.MessageTemplates;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000B4 RID: 180
	[global::NLog.LayoutRenderers.LayoutRenderer("exception")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class ExceptionLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000AAE RID: 2734 RVA: 0x0001B14C File Offset: 0x0001934C
		public ExceptionLayoutRenderer()
		{
			this.Format = "message";
			this.Separator = " ";
			this.ExceptionDataSeparator = ";";
			this.InnerExceptionSeparator = global::NLog.Internal.EnvironmentHelper.NewLine;
			this.MaxInnerExceptionLevel = 0;
			this._renderingfunctions = new global::System.Collections.Generic.Dictionary<global::NLog.Config.ExceptionRenderingFormat, global::System.Action<global::System.Text.StringBuilder, global::System.Exception>>
			{
				{
					global::NLog.Config.ExceptionRenderingFormat.Message,
					new global::System.Action<global::System.Text.StringBuilder, global::System.Exception>(this.AppendMessage)
				},
				{
					global::NLog.Config.ExceptionRenderingFormat.Type,
					new global::System.Action<global::System.Text.StringBuilder, global::System.Exception>(this.AppendType)
				},
				{
					global::NLog.Config.ExceptionRenderingFormat.ShortType,
					new global::System.Action<global::System.Text.StringBuilder, global::System.Exception>(this.AppendShortType)
				},
				{
					global::NLog.Config.ExceptionRenderingFormat.ToString,
					new global::System.Action<global::System.Text.StringBuilder, global::System.Exception>(this.AppendToString)
				},
				{
					global::NLog.Config.ExceptionRenderingFormat.Method,
					new global::System.Action<global::System.Text.StringBuilder, global::System.Exception>(this.AppendMethod)
				},
				{
					global::NLog.Config.ExceptionRenderingFormat.StackTrace,
					new global::System.Action<global::System.Text.StringBuilder, global::System.Exception>(this.AppendStackTrace)
				},
				{
					global::NLog.Config.ExceptionRenderingFormat.Data,
					new global::System.Action<global::System.Text.StringBuilder, global::System.Exception>(this.AppendData)
				},
				{
					global::NLog.Config.ExceptionRenderingFormat.Serialize,
					new global::System.Action<global::System.Text.StringBuilder, global::System.Exception>(this.AppendSerializeObject)
				}
			};
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0001B248 File Offset: 0x00019448
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x0001B250 File Offset: 0x00019450
		[global::NLog.Config.DefaultParameter]
		public string Format
		{
			get
			{
				return this._format;
			}
			set
			{
				this._format = value;
				this.Formats = global::NLog.LayoutRenderers.ExceptionLayoutRenderer.CompileFormat(value);
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0001B265 File Offset: 0x00019465
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x0001B26D File Offset: 0x0001946D
		public string InnerFormat
		{
			get
			{
				return this._innerFormat;
			}
			set
			{
				this._innerFormat = value;
				this.InnerFormats = global::NLog.LayoutRenderers.ExceptionLayoutRenderer.CompileFormat(value);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0001B282 File Offset: 0x00019482
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x0001B28A File Offset: 0x0001948A
		[global::System.ComponentModel.DefaultValue(" ")]
		public string Separator { get; set; }

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0001B293 File Offset: 0x00019493
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x0001B29B File Offset: 0x0001949B
		[global::System.ComponentModel.DefaultValue(";")]
		public string ExceptionDataSeparator { get; set; }

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0001B2A4 File Offset: 0x000194A4
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x0001B2AC File Offset: 0x000194AC
		[global::System.ComponentModel.DefaultValue(0)]
		public int MaxInnerExceptionLevel { get; set; }

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0001B2B5 File Offset: 0x000194B5
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x0001B2BD File Offset: 0x000194BD
		public string InnerExceptionSeparator { get; set; }

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0001B2C6 File Offset: 0x000194C6
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x0001B2CE File Offset: 0x000194CE
		public global::System.Collections.Generic.List<global::NLog.Config.ExceptionRenderingFormat> Formats { get; private set; }

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0001B2D7 File Offset: 0x000194D7
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x0001B2DF File Offset: 0x000194DF
		public global::System.Collections.Generic.List<global::NLog.Config.ExceptionRenderingFormat> InnerFormats { get; private set; }

		// Token: 0x06000ABF RID: 2751 RVA: 0x0001B2E8 File Offset: 0x000194E8
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			global::System.Exception exception = logEvent.Exception;
			if (exception != null)
			{
				this.AppendException(exception, this.Formats, builder);
				int num = 0;
				if (num < this.MaxInnerExceptionLevel)
				{
					num = this.AppendInnerExceptionTree(exception, num, builder);
					global::System.AggregateException ex = exception as global::System.AggregateException;
					if (ex != null)
					{
						this.AppendAggregateException(ex, num, builder);
					}
				}
			}
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0001B338 File Offset: 0x00019538
		private void AppendAggregateException(global::System.AggregateException primaryException, int currentLevel, global::System.Text.StringBuilder builder)
		{
			global::System.AggregateException ex = primaryException.Flatten();
			if (ex.InnerExceptions != null)
			{
				int num = 0;
				while (num < ex.InnerExceptions.Count && currentLevel < this.MaxInnerExceptionLevel)
				{
					global::System.Exception ex2 = ex.InnerExceptions[num];
					if (ex2 != primaryException.InnerException)
					{
						if (ex2 == null)
						{
							global::NLog.Common.InternalLogger.Debug("Skipping rendering exception as exception is null");
						}
						else
						{
							this.AppendInnerException(ex2, builder);
							currentLevel++;
							currentLevel = this.AppendInnerExceptionTree(ex2, currentLevel, builder);
						}
					}
					num++;
					currentLevel++;
				}
			}
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0001B3B5 File Offset: 0x000195B5
		private int AppendInnerExceptionTree(global::System.Exception currentException, int currentLevel, global::System.Text.StringBuilder sb)
		{
			currentException = currentException.InnerException;
			while (currentException != null && currentLevel < this.MaxInnerExceptionLevel)
			{
				this.AppendInnerException(currentException, sb);
				currentLevel++;
				currentException = currentException.InnerException;
			}
			return currentLevel;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0001B3E3 File Offset: 0x000195E3
		private void AppendInnerException(global::System.Exception currentException, global::System.Text.StringBuilder builder)
		{
			builder.Append(this.InnerExceptionSeparator);
			this.AppendException(currentException, this.InnerFormats ?? this.Formats, builder);
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0001B40C File Offset: 0x0001960C
		private void AppendException(global::System.Exception currentException, global::System.Collections.Generic.IEnumerable<global::NLog.Config.ExceptionRenderingFormat> renderFormats, global::System.Text.StringBuilder builder)
		{
			int length = builder.Length;
			foreach (global::NLog.Config.ExceptionRenderingFormat key in renderFormats)
			{
				if (length != builder.Length)
				{
					length = builder.Length;
					builder.Append(this.Separator);
				}
				int length2 = builder.Length;
				this._renderingfunctions[key](builder, currentException);
				if (builder.Length == length2 && builder.Length != length)
				{
					builder.Length = length;
				}
			}
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0001B4A4 File Offset: 0x000196A4
		protected virtual void AppendMessage(global::System.Text.StringBuilder sb, global::System.Exception ex)
		{
			try
			{
				sb.Append(ex.Message);
			}
			catch (global::System.Exception ex2)
			{
				string text = string.Format("Exception in {0}.AppendMessage(): {1}.", typeof(global::NLog.LayoutRenderers.ExceptionLayoutRenderer).FullName, ex2.GetType().FullName);
				sb.Append("NLog message: ");
				sb.Append(text);
				global::NLog.Common.InternalLogger.Warn(ex2, text);
			}
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0001B514 File Offset: 0x00019714
		protected virtual void AppendMethod(global::System.Text.StringBuilder sb, global::System.Exception ex)
		{
			if (ex.TargetSite != null)
			{
				sb.Append(ex.TargetSite.ToString());
			}
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0001B536 File Offset: 0x00019736
		protected virtual void AppendStackTrace(global::System.Text.StringBuilder sb, global::System.Exception ex)
		{
			if (!string.IsNullOrEmpty(ex.StackTrace))
			{
				sb.Append(ex.StackTrace);
			}
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0001B552 File Offset: 0x00019752
		protected virtual void AppendToString(global::System.Text.StringBuilder sb, global::System.Exception ex)
		{
			sb.Append(ex.ToString());
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0001B561 File Offset: 0x00019761
		protected virtual void AppendType(global::System.Text.StringBuilder sb, global::System.Exception ex)
		{
			sb.Append(ex.GetType().FullName);
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0001B575 File Offset: 0x00019775
		protected virtual void AppendShortType(global::System.Text.StringBuilder sb, global::System.Exception ex)
		{
			sb.Append(ex.GetType().Name);
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0001B58C File Offset: 0x0001978C
		protected virtual void AppendData(global::System.Text.StringBuilder sb, global::System.Exception ex)
		{
			if (ex.Data != null && ex.Data.Count > 0)
			{
				string value = string.Empty;
				foreach (object obj in ex.Data.Keys)
				{
					sb.Append(value);
					sb.AppendFormat("{0}: {1}", obj, ex.Data[obj]);
					value = this.ExceptionDataSeparator;
				}
			}
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0001B624 File Offset: 0x00019824
		protected virtual void AppendSerializeObject(global::System.Text.StringBuilder sb, global::System.Exception ex)
		{
			global::NLog.Config.ConfigurationItemFactory.Default.ValueFormatter.FormatValue(ex, null, global::NLog.MessageTemplates.CaptureType.Serialize, null, sb);
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0001B63C File Offset: 0x0001983C
		private static global::System.Collections.Generic.List<global::NLog.Config.ExceptionRenderingFormat> CompileFormat(string formatSpecifier)
		{
			global::System.Collections.Generic.List<global::NLog.Config.ExceptionRenderingFormat> list = new global::System.Collections.Generic.List<global::NLog.Config.ExceptionRenderingFormat>();
			foreach (string text in formatSpecifier.Replace(" ", string.Empty).Split(new string[]
			{
				","
			}, global::System.StringSplitOptions.RemoveEmptyEntries))
			{
				global::NLog.Config.ExceptionRenderingFormat item;
				if (global::NLog.LayoutRenderers.ExceptionLayoutRenderer._formatsMapping.TryGetValue(text, out item))
				{
					list.Add(item);
				}
				else
				{
					global::NLog.Common.InternalLogger.Warn<string>("Unknown exception data target: {0}", text);
				}
			}
			return list;
		}

		// Token: 0x040002A6 RID: 678
		private string _format;

		// Token: 0x040002A7 RID: 679
		private string _innerFormat = string.Empty;

		// Token: 0x040002A8 RID: 680
		private readonly global::System.Collections.Generic.Dictionary<global::NLog.Config.ExceptionRenderingFormat, global::System.Action<global::System.Text.StringBuilder, global::System.Exception>> _renderingfunctions;

		// Token: 0x040002A9 RID: 681
		private static readonly global::System.Collections.Generic.Dictionary<string, global::NLog.Config.ExceptionRenderingFormat> _formatsMapping = new global::System.Collections.Generic.Dictionary<string, global::NLog.Config.ExceptionRenderingFormat>(global::System.StringComparer.OrdinalIgnoreCase)
		{
			{
				"MESSAGE",
				global::NLog.Config.ExceptionRenderingFormat.Message
			},
			{
				"TYPE",
				global::NLog.Config.ExceptionRenderingFormat.Type
			},
			{
				"SHORTTYPE",
				global::NLog.Config.ExceptionRenderingFormat.ShortType
			},
			{
				"TOSTRING",
				global::NLog.Config.ExceptionRenderingFormat.ToString
			},
			{
				"METHOD",
				global::NLog.Config.ExceptionRenderingFormat.Method
			},
			{
				"STACKTRACE",
				global::NLog.Config.ExceptionRenderingFormat.StackTrace
			},
			{
				"DATA",
				global::NLog.Config.ExceptionRenderingFormat.Data
			},
			{
				"@",
				global::NLog.Config.ExceptionRenderingFormat.Serialize
			}
		};
	}
}
