using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using NLog.Common;
using NLog.Config;

namespace NLog.Targets
{
	// Token: 0x02000029 RID: 41
	[global::NLog.Targets.Target("ColoredConsole")]
	public sealed class ColoredConsoleTarget : global::NLog.Targets.TargetWithLayoutHeaderAndFooter
	{
		// Token: 0x060004AA RID: 1194 RVA: 0x000097CA File Offset: 0x000079CA
		public ColoredConsoleTarget()
		{
			this.WordHighlightingRules = new global::System.Collections.Generic.List<global::NLog.Targets.ConsoleWordHighlightingRule>();
			this.RowHighlightingRules = new global::System.Collections.Generic.List<global::NLog.Targets.ConsoleRowHighlightingRule>();
			this.UseDefaultRowHighlightingRules = true;
			this._pauseLogging = false;
			this.DetectConsoleAvailable = false;
			base.OptimizeBufferReuse = true;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00009804 File Offset: 0x00007A04
		public ColoredConsoleTarget(string name) : this()
		{
			base.Name = name;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00009813 File Offset: 0x00007A13
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x0000981B File Offset: 0x00007A1B
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ErrorStream { get; set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00009824 File Offset: 0x00007A24
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x0000982C File Offset: 0x00007A2C
		[global::System.ComponentModel.DefaultValue(true)]
		public bool UseDefaultRowHighlightingRules { get; set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00009835 File Offset: 0x00007A35
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x0000984E File Offset: 0x00007A4E
		public global::System.Text.Encoding Encoding
		{
			get
			{
				return global::NLog.Targets.ConsoleTargetHelper.GetConsoleOutputEncoding(this._encoding, base.IsInitialized, this._pauseLogging);
			}
			set
			{
				if (global::NLog.Targets.ConsoleTargetHelper.SetConsoleOutputEncoding(value, base.IsInitialized, this._pauseLogging))
				{
					this._encoding = value;
				}
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x0000986B File Offset: 0x00007A6B
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00009873 File Offset: 0x00007A73
		[global::System.ComponentModel.DefaultValue(false)]
		public bool DetectConsoleAvailable { get; set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x0000987C File Offset: 0x00007A7C
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00009884 File Offset: 0x00007A84
		[global::NLog.Config.ArrayParameter(typeof(global::NLog.Targets.ConsoleRowHighlightingRule), "highlight-row")]
		public global::System.Collections.Generic.IList<global::NLog.Targets.ConsoleRowHighlightingRule> RowHighlightingRules { get; private set; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x0000988D File Offset: 0x00007A8D
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00009895 File Offset: 0x00007A95
		[global::NLog.Config.ArrayParameter(typeof(global::NLog.Targets.ConsoleWordHighlightingRule), "highlight-word")]
		public global::System.Collections.Generic.IList<global::NLog.Targets.ConsoleWordHighlightingRule> WordHighlightingRules { get; private set; }

		// Token: 0x060004B8 RID: 1208 RVA: 0x000098A0 File Offset: 0x00007AA0
		protected override void InitializeTarget()
		{
			this._pauseLogging = false;
			if (this.DetectConsoleAvailable)
			{
				string arg;
				this._pauseLogging = !global::NLog.Targets.ConsoleTargetHelper.IsConsoleAvailable(out arg);
				if (this._pauseLogging)
				{
					global::NLog.Common.InternalLogger.Info<string>("Console has been detected as turned off. Disable DetectConsoleAvailable to skip detection. Reason: {0}", arg);
				}
			}
			if (this._encoding != null && !this._pauseLogging)
			{
				global::System.Console.OutputEncoding = this._encoding;
			}
			base.InitializeTarget();
			if (base.Header != null)
			{
				global::NLog.LogEventInfo logEvent = global::NLog.LogEventInfo.CreateNullEvent();
				this.WriteToOutput(logEvent, base.RenderLogEvent(base.Header, logEvent));
			}
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00009924 File Offset: 0x00007B24
		protected override void CloseTarget()
		{
			if (base.Footer != null)
			{
				global::NLog.LogEventInfo logEvent = global::NLog.LogEventInfo.CreateNullEvent();
				this.WriteToOutput(logEvent, base.RenderLogEvent(base.Footer, logEvent));
			}
			base.CloseTarget();
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00009959 File Offset: 0x00007B59
		protected override void Write(global::NLog.LogEventInfo logEvent)
		{
			if (this._pauseLogging)
			{
				return;
			}
			this.WriteToOutput(logEvent, base.RenderLogEvent(this.Layout, logEvent));
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00009978 File Offset: 0x00007B78
		private void WriteToOutput(global::NLog.LogEventInfo logEvent, string message)
		{
			global::System.ConsoleColor foregroundColor = global::System.Console.ForegroundColor;
			global::System.ConsoleColor backgroundColor = global::System.Console.BackgroundColor;
			bool flag = false;
			bool flag2 = false;
			try
			{
				global::NLog.Targets.ConsoleRowHighlightingRule matchingRowHighlightingRule = this.GetMatchingRowHighlightingRule(logEvent);
				flag = global::NLog.Targets.ColoredConsoleTarget.IsColorChange(matchingRowHighlightingRule.ForegroundColor, foregroundColor);
				if (flag)
				{
					global::System.Console.ForegroundColor = (global::System.ConsoleColor)matchingRowHighlightingRule.ForegroundColor;
				}
				flag2 = global::NLog.Targets.ColoredConsoleTarget.IsColorChange(matchingRowHighlightingRule.BackgroundColor, backgroundColor);
				if (flag2)
				{
					global::System.Console.BackgroundColor = (global::System.ConsoleColor)matchingRowHighlightingRule.BackgroundColor;
				}
				try
				{
					global::System.IO.TextWriter textWriter = this.ErrorStream ? global::System.Console.Error : global::System.Console.Out;
					if (this.WordHighlightingRules.Count == 0)
					{
						textWriter.WriteLine(message);
					}
					else
					{
						message = message.Replace("\a", "\a\a");
						foreach (global::NLog.Targets.ConsoleWordHighlightingRule consoleWordHighlightingRule in this.WordHighlightingRules)
						{
							message = consoleWordHighlightingRule.ReplaceWithEscapeSequences(message);
						}
						global::NLog.Targets.ColoredConsoleTarget.ColorizeEscapeSequences(textWriter, message, new global::NLog.Targets.ColoredConsoleTarget.ColorPair(global::System.Console.ForegroundColor, global::System.Console.BackgroundColor), new global::NLog.Targets.ColoredConsoleTarget.ColorPair(foregroundColor, backgroundColor));
						textWriter.WriteLine();
						flag2 = (flag = true);
					}
				}
				catch (global::System.IndexOutOfRangeException ex)
				{
					this._pauseLogging = true;
					global::NLog.Common.InternalLogger.Warn(ex, "An IndexOutOfRangeException has been thrown and this is probably due to a race condition.Logging to the console will be paused. Enable by reloading the config or re-initialize the targets");
				}
				catch (global::System.ArgumentOutOfRangeException ex2)
				{
					this._pauseLogging = true;
					global::NLog.Common.InternalLogger.Warn(ex2, "An ArgumentOutOfRangeException has been thrown and this is probably due to a race condition.Logging to the console will be paused. Enable by reloading the config or re-initialize the targets");
				}
			}
			finally
			{
				if (flag)
				{
					global::System.Console.ForegroundColor = foregroundColor;
				}
				if (flag2)
				{
					global::System.Console.BackgroundColor = backgroundColor;
				}
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00009B18 File Offset: 0x00007D18
		private global::NLog.Targets.ConsoleRowHighlightingRule GetMatchingRowHighlightingRule(global::NLog.LogEventInfo logEvent)
		{
			foreach (global::NLog.Targets.ConsoleRowHighlightingRule consoleRowHighlightingRule in this.RowHighlightingRules)
			{
				if (consoleRowHighlightingRule.CheckCondition(logEvent))
				{
					return consoleRowHighlightingRule;
				}
			}
			if (this.UseDefaultRowHighlightingRules)
			{
				foreach (global::NLog.Targets.ConsoleRowHighlightingRule consoleRowHighlightingRule2 in global::NLog.Targets.ColoredConsoleTarget.DefaultConsoleRowHighlightingRules)
				{
					if (consoleRowHighlightingRule2.CheckCondition(logEvent))
					{
						return consoleRowHighlightingRule2;
					}
				}
			}
			return global::NLog.Targets.ConsoleRowHighlightingRule.Default;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00009BBC File Offset: 0x00007DBC
		private static bool IsColorChange(global::NLog.Targets.ConsoleOutputColor targetColor, global::System.ConsoleColor oldColor)
		{
			return targetColor != global::NLog.Targets.ConsoleOutputColor.NoChange && targetColor != (global::NLog.Targets.ConsoleOutputColor)oldColor;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00009BCC File Offset: 0x00007DCC
		private static void ColorizeEscapeSequences(global::System.IO.TextWriter output, string message, global::NLog.Targets.ColoredConsoleTarget.ColorPair startingColor, global::NLog.Targets.ColoredConsoleTarget.ColorPair defaultColor)
		{
			global::System.Collections.Generic.Stack<global::NLog.Targets.ColoredConsoleTarget.ColorPair> stack = new global::System.Collections.Generic.Stack<global::NLog.Targets.ColoredConsoleTarget.ColorPair>();
			stack.Push(startingColor);
			int i = 0;
			while (i < message.Length)
			{
				int num = i;
				while (num < message.Length && message[num] >= ' ')
				{
					num++;
				}
				if (num != i)
				{
					output.Write(message.Substring(i, num - i));
				}
				if (num >= message.Length)
				{
					i = num;
					break;
				}
				char c = message[num];
				char c2 = '\0';
				if (num + 1 < message.Length)
				{
					c2 = message[num + 1];
				}
				if (c == '\a' && c2 == '\a')
				{
					output.Write('\a');
					i = num + 2;
				}
				else if (c == '\r' || c == '\n')
				{
					global::System.Console.ForegroundColor = defaultColor.ForegroundColor;
					global::System.Console.BackgroundColor = defaultColor.BackgroundColor;
					output.Write(c);
					global::System.Console.ForegroundColor = stack.Peek().ForegroundColor;
					global::System.Console.BackgroundColor = stack.Peek().BackgroundColor;
					i = num + 1;
				}
				else if (c == '\a')
				{
					if (c2 == 'X')
					{
						stack.Pop();
						global::System.Console.ForegroundColor = stack.Peek().ForegroundColor;
						global::System.Console.BackgroundColor = stack.Peek().BackgroundColor;
						i = num + 2;
					}
					else
					{
						global::NLog.Targets.ConsoleOutputColor consoleOutputColor = (global::NLog.Targets.ConsoleOutputColor)(c2 - 'A');
						global::NLog.Targets.ConsoleOutputColor consoleOutputColor2 = (global::NLog.Targets.ConsoleOutputColor)(message[num + 2] - 'A');
						if (consoleOutputColor != global::NLog.Targets.ConsoleOutputColor.NoChange)
						{
							global::System.Console.ForegroundColor = (global::System.ConsoleColor)consoleOutputColor;
						}
						if (consoleOutputColor2 != global::NLog.Targets.ConsoleOutputColor.NoChange)
						{
							global::System.Console.BackgroundColor = (global::System.ConsoleColor)consoleOutputColor2;
						}
						stack.Push(new global::NLog.Targets.ColoredConsoleTarget.ColorPair(global::System.Console.ForegroundColor, global::System.Console.BackgroundColor));
						i = num + 3;
					}
				}
				else
				{
					output.Write(c);
					i = num + 1;
				}
			}
			if (i < message.Length)
			{
				output.Write(message.Substring(i));
			}
		}

		// Token: 0x0400005D RID: 93
		private bool _pauseLogging;

		// Token: 0x0400005E RID: 94
		private static readonly global::System.Collections.Generic.IList<global::NLog.Targets.ConsoleRowHighlightingRule> DefaultConsoleRowHighlightingRules = new global::System.Collections.Generic.List<global::NLog.Targets.ConsoleRowHighlightingRule>
		{
			new global::NLog.Targets.ConsoleRowHighlightingRule("level == LogLevel.Fatal", global::NLog.Targets.ConsoleOutputColor.Red, global::NLog.Targets.ConsoleOutputColor.NoChange),
			new global::NLog.Targets.ConsoleRowHighlightingRule("level == LogLevel.Error", global::NLog.Targets.ConsoleOutputColor.Yellow, global::NLog.Targets.ConsoleOutputColor.NoChange),
			new global::NLog.Targets.ConsoleRowHighlightingRule("level == LogLevel.Warn", global::NLog.Targets.ConsoleOutputColor.Magenta, global::NLog.Targets.ConsoleOutputColor.NoChange),
			new global::NLog.Targets.ConsoleRowHighlightingRule("level == LogLevel.Info", global::NLog.Targets.ConsoleOutputColor.White, global::NLog.Targets.ConsoleOutputColor.NoChange),
			new global::NLog.Targets.ConsoleRowHighlightingRule("level == LogLevel.Debug", global::NLog.Targets.ConsoleOutputColor.Gray, global::NLog.Targets.ConsoleOutputColor.NoChange),
			new global::NLog.Targets.ConsoleRowHighlightingRule("level == LogLevel.Trace", global::NLog.Targets.ConsoleOutputColor.DarkGray, global::NLog.Targets.ConsoleOutputColor.NoChange)
		};

		// Token: 0x04000061 RID: 97
		private global::System.Text.Encoding _encoding;

		// Token: 0x020001C8 RID: 456
		internal struct ColorPair
		{
			// Token: 0x060011E0 RID: 4576 RVA: 0x0002ED3F File Offset: 0x0002CF3F
			internal ColorPair(global::System.ConsoleColor foregroundColor, global::System.ConsoleColor backgroundColor)
			{
				this._foregroundColor = foregroundColor;
				this._backgroundColor = backgroundColor;
			}

			// Token: 0x1700034C RID: 844
			// (get) Token: 0x060011E1 RID: 4577 RVA: 0x0002ED4F File Offset: 0x0002CF4F
			internal global::System.ConsoleColor BackgroundColor
			{
				get
				{
					return this._backgroundColor;
				}
			}

			// Token: 0x1700034D RID: 845
			// (get) Token: 0x060011E2 RID: 4578 RVA: 0x0002ED57 File Offset: 0x0002CF57
			internal global::System.ConsoleColor ForegroundColor
			{
				get
				{
					return this._foregroundColor;
				}
			}

			// Token: 0x04000525 RID: 1317
			private readonly global::System.ConsoleColor _foregroundColor;

			// Token: 0x04000526 RID: 1318
			private readonly global::System.ConsoleColor _backgroundColor;
		}
	}
}
