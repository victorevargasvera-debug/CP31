using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using NLog.Common;

namespace NLog.Targets
{
	// Token: 0x0200002C RID: 44
	[global::NLog.Targets.Target("Console")]
	public sealed class ConsoleTarget : global::NLog.Targets.TargetWithLayoutHeaderAndFooter
	{
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00009ED0 File Offset: 0x000080D0
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x00009ED8 File Offset: 0x000080D8
		[global::System.ComponentModel.DefaultValue(false)]
		public bool Error { get; set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x00009EE1 File Offset: 0x000080E1
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x00009EFA File Offset: 0x000080FA
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

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x00009F17 File Offset: 0x00008117
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00009F1F File Offset: 0x0000811F
		[global::System.ComponentModel.DefaultValue(false)]
		public bool DetectConsoleAvailable { get; set; }

		// Token: 0x060004D2 RID: 1234 RVA: 0x00009F28 File Offset: 0x00008128
		public ConsoleTarget()
		{
			this._pauseLogging = false;
			this.DetectConsoleAvailable = false;
			base.OptimizeBufferReuse = true;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00009F45 File Offset: 0x00008145
		public ConsoleTarget(string name) : this()
		{
			base.Name = name;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00009F54 File Offset: 0x00008154
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
				this.WriteToOutput(base.RenderLogEvent(base.Header, global::NLog.LogEventInfo.CreateNullEvent()));
			}
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00009FD3 File Offset: 0x000081D3
		protected override void CloseTarget()
		{
			if (base.Footer != null)
			{
				this.WriteToOutput(base.RenderLogEvent(base.Footer, global::NLog.LogEventInfo.CreateNullEvent()));
			}
			base.CloseTarget();
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00009FFA File Offset: 0x000081FA
		protected override void Write(global::NLog.LogEventInfo logEvent)
		{
			if (this._pauseLogging)
			{
				return;
			}
			this.WriteToOutput(base.RenderLogEvent(this.Layout, logEvent));
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0000A018 File Offset: 0x00008218
		private void WriteToOutput(string textLine)
		{
			if (this._pauseLogging)
			{
				return;
			}
			global::System.IO.TextWriter output = this.GetOutput();
			try
			{
				output.WriteLine(textLine);
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

		// Token: 0x060004D8 RID: 1240 RVA: 0x0000A080 File Offset: 0x00008280
		private global::System.IO.TextWriter GetOutput()
		{
			if (!this.Error)
			{
				return global::System.Console.Out;
			}
			return global::System.Console.Error;
		}

		// Token: 0x0400007B RID: 123
		private bool _pauseLogging;

		// Token: 0x0400007D RID: 125
		private global::System.Text.Encoding _encoding;
	}
}
