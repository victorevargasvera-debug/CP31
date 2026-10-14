using System;
using System.ComponentModel;

namespace NLog
{
	// Token: 0x02000007 RID: 7
	[global::System.CLSCompliant(false)]
	public interface ILoggerBase
	{
		// Token: 0x0600013D RID: 317
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void Log(global::NLog.LogLevel level, object value);

		// Token: 0x0600013E RID: 318
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, object value);

		// Token: 0x0600013F RID: 319
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, string message, object arg1, object arg2);

		// Token: 0x06000140 RID: 320
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, string message, object arg1, object arg2, object arg3);

		// Token: 0x06000141 RID: 321
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, bool argument);

		// Token: 0x06000142 RID: 322
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, string message, bool argument);

		// Token: 0x06000143 RID: 323
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, char argument);

		// Token: 0x06000144 RID: 324
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, string message, char argument);

		// Token: 0x06000145 RID: 325
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, byte argument);

		// Token: 0x06000146 RID: 326
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, string message, byte argument);

		// Token: 0x06000147 RID: 327
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, string argument);

		// Token: 0x06000148 RID: 328
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, string message, string argument);

		// Token: 0x06000149 RID: 329
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, int argument);

		// Token: 0x0600014A RID: 330
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, string message, int argument);

		// Token: 0x0600014B RID: 331
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, long argument);

		// Token: 0x0600014C RID: 332
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, string message, long argument);

		// Token: 0x0600014D RID: 333
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, float argument);

		// Token: 0x0600014E RID: 334
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, string message, float argument);

		// Token: 0x0600014F RID: 335
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, double argument);

		// Token: 0x06000150 RID: 336
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, string message, double argument);

		// Token: 0x06000151 RID: 337
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, decimal argument);

		// Token: 0x06000152 RID: 338
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, string message, decimal argument);

		// Token: 0x06000153 RID: 339
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, object argument);

		// Token: 0x06000154 RID: 340
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, string message, object argument);

		// Token: 0x06000155 RID: 341
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, sbyte argument);

		// Token: 0x06000156 RID: 342
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, string message, sbyte argument);

		// Token: 0x06000157 RID: 343
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, uint argument);

		// Token: 0x06000158 RID: 344
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, string message, uint argument);

		// Token: 0x06000159 RID: 345
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, ulong argument);

		// Token: 0x0600015A RID: 346
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, string message, ulong argument);

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600015B RID: 347
		// (remove) Token: 0x0600015C RID: 348
		event global::System.EventHandler<global::System.EventArgs> LoggerReconfigured;

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600015D RID: 349
		string Name { get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600015E RID: 350
		global::NLog.LogFactory Factory { get; }

		// Token: 0x0600015F RID: 351
		bool IsEnabled(global::NLog.LogLevel level);

		// Token: 0x06000160 RID: 352
		void Log(global::NLog.LogEventInfo logEvent);

		// Token: 0x06000161 RID: 353
		void Log(global::System.Type wrapperType, global::NLog.LogEventInfo logEvent);

		// Token: 0x06000162 RID: 354
		void Log<T>(global::NLog.LogLevel level, T value);

		// Token: 0x06000163 RID: 355
		void Log<T>(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, T value);

		// Token: 0x06000164 RID: 356
		void Log(global::NLog.LogLevel level, global::NLog.LogMessageGenerator messageFunc);

		// Token: 0x06000165 RID: 357
		[global::System.Obsolete("Use Log(LogLevel level, Exception exception, [Localizable(false)] string message, params object[] args) instead. Marked obsolete before v4.3.11")]
		void LogException(global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception);

		// Token: 0x06000166 RID: 358
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x06000167 RID: 359
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, global::System.Exception exception, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x06000168 RID: 360
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x06000169 RID: 361
		void Log(global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] string message);

		// Token: 0x0600016A RID: 362
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log(global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x0600016B RID: 363
		[global::System.Obsolete("Use Log(LogLevel level, Exception exception, [Localizable(false)] string message, params object[] args) instead. Marked obsolete before v4.3.11")]
		void Log(global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception);

		// Token: 0x0600016C RID: 364
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log<TArgument>(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument argument);

		// Token: 0x0600016D RID: 365
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log<TArgument>(global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] string message, TArgument argument);

		// Token: 0x0600016E RID: 366
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log<TArgument1, TArgument2>(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);

		// Token: 0x0600016F RID: 367
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log<TArgument1, TArgument2>(global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);

		// Token: 0x06000170 RID: 368
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log<TArgument1, TArgument2, TArgument3>(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);

		// Token: 0x06000171 RID: 369
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Log<TArgument1, TArgument2, TArgument3>(global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
	}
}
