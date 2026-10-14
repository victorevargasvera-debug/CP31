using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using JetBrains.Annotations;
using NLog.Internal;
using NLog.Time;

namespace NLog.Common
{
	// Token: 0x0200018F RID: 399
	public static class InternalLogger
	{
		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x0002CF44 File Offset: 0x0002B144
		public static bool IsTraceEnabled
		{
			get
			{
				return global::NLog.LogLevel.Trace >= global::NLog.Common.InternalLogger.LogLevel;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x0002CF55 File Offset: 0x0002B155
		public static bool IsDebugEnabled
		{
			get
			{
				return global::NLog.LogLevel.Debug >= global::NLog.Common.InternalLogger.LogLevel;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x0002CF66 File Offset: 0x0002B166
		public static bool IsInfoEnabled
		{
			get
			{
				return global::NLog.LogLevel.Info >= global::NLog.Common.InternalLogger.LogLevel;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x0002CF77 File Offset: 0x0002B177
		public static bool IsWarnEnabled
		{
			get
			{
				return global::NLog.LogLevel.Warn >= global::NLog.Common.InternalLogger.LogLevel;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x0002CF88 File Offset: 0x0002B188
		public static bool IsErrorEnabled
		{
			get
			{
				return global::NLog.LogLevel.Error >= global::NLog.Common.InternalLogger.LogLevel;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x0002CF99 File Offset: 0x0002B199
		public static bool IsFatalEnabled
		{
			get
			{
				return global::NLog.LogLevel.Fatal >= global::NLog.Common.InternalLogger.LogLevel;
			}
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x0002CFAA File Offset: 0x0002B1AA
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Trace([global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			global::NLog.Common.InternalLogger.Write(null, global::NLog.LogLevel.Trace, message, args);
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x0002CFB9 File Offset: 0x0002B1B9
		public static void Trace([global::System.ComponentModel.Localizable(false)] string message)
		{
			global::NLog.Common.InternalLogger.Write(null, global::NLog.LogLevel.Trace, message, null);
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0002CFC8 File Offset: 0x0002B1C8
		public static void Trace([global::System.ComponentModel.Localizable(false)] global::System.Func<string> messageFunc)
		{
			if (global::NLog.Common.InternalLogger.IsTraceEnabled)
			{
				global::NLog.Common.InternalLogger.Write(null, global::NLog.LogLevel.Trace, messageFunc(), null);
			}
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x0002CFE3 File Offset: 0x0002B1E3
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Trace(global::System.Exception ex, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			global::NLog.Common.InternalLogger.Write(ex, global::NLog.LogLevel.Trace, message, args);
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x0002CFF2 File Offset: 0x0002B1F2
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Trace<TArgument1>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 arg0)
		{
			if (global::NLog.Common.InternalLogger.IsTraceEnabled)
			{
				global::NLog.Common.InternalLogger.Log(null, global::NLog.LogLevel.Trace, message, new object[]
				{
					arg0
				});
			}
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0002D016 File Offset: 0x0002B216
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Trace<TArgument1, TArgument2>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 arg0, TArgument2 arg1)
		{
			if (global::NLog.Common.InternalLogger.IsTraceEnabled)
			{
				global::NLog.Common.InternalLogger.Log(null, global::NLog.LogLevel.Trace, message, new object[]
				{
					arg0,
					arg1
				});
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x0002D043 File Offset: 0x0002B243
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Trace<TArgument1, TArgument2, TArgument3>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 arg0, TArgument2 arg1, TArgument3 arg2)
		{
			if (global::NLog.Common.InternalLogger.IsTraceEnabled)
			{
				global::NLog.Common.InternalLogger.Log(null, global::NLog.LogLevel.Trace, message, new object[]
				{
					arg0,
					arg1,
					arg2
				});
			}
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x0002D079 File Offset: 0x0002B279
		public static void Trace(global::System.Exception ex, [global::System.ComponentModel.Localizable(false)] string message)
		{
			global::NLog.Common.InternalLogger.Write(ex, global::NLog.LogLevel.Trace, message, null);
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x0002D088 File Offset: 0x0002B288
		public static void Trace(global::System.Exception ex, [global::System.ComponentModel.Localizable(false)] global::System.Func<string> messageFunc)
		{
			if (global::NLog.Common.InternalLogger.IsTraceEnabled)
			{
				global::NLog.Common.InternalLogger.Write(ex, global::NLog.LogLevel.Trace, messageFunc(), null);
			}
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x0002D0A3 File Offset: 0x0002B2A3
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Debug([global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			global::NLog.Common.InternalLogger.Write(null, global::NLog.LogLevel.Debug, message, args);
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x0002D0B2 File Offset: 0x0002B2B2
		public static void Debug([global::System.ComponentModel.Localizable(false)] string message)
		{
			global::NLog.Common.InternalLogger.Write(null, global::NLog.LogLevel.Debug, message, null);
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x0002D0C1 File Offset: 0x0002B2C1
		public static void Debug([global::System.ComponentModel.Localizable(false)] global::System.Func<string> messageFunc)
		{
			if (global::NLog.Common.InternalLogger.IsDebugEnabled)
			{
				global::NLog.Common.InternalLogger.Write(null, global::NLog.LogLevel.Debug, messageFunc(), null);
			}
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x0002D0DC File Offset: 0x0002B2DC
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Debug(global::System.Exception ex, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			global::NLog.Common.InternalLogger.Write(ex, global::NLog.LogLevel.Debug, message, args);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x0002D0EB File Offset: 0x0002B2EB
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Debug<TArgument1>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 arg0)
		{
			if (global::NLog.Common.InternalLogger.IsDebugEnabled)
			{
				global::NLog.Common.InternalLogger.Log(null, global::NLog.LogLevel.Debug, message, new object[]
				{
					arg0
				});
			}
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0002D10F File Offset: 0x0002B30F
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Debug<TArgument1, TArgument2>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 arg0, TArgument2 arg1)
		{
			if (global::NLog.Common.InternalLogger.IsDebugEnabled)
			{
				global::NLog.Common.InternalLogger.Log(null, global::NLog.LogLevel.Debug, message, new object[]
				{
					arg0,
					arg1
				});
			}
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x0002D13C File Offset: 0x0002B33C
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Debug<TArgument1, TArgument2, TArgument3>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 arg0, TArgument2 arg1, TArgument3 arg2)
		{
			if (global::NLog.Common.InternalLogger.IsDebugEnabled)
			{
				global::NLog.Common.InternalLogger.Log(null, global::NLog.LogLevel.Debug, message, new object[]
				{
					arg0,
					arg1,
					arg2
				});
			}
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x0002D172 File Offset: 0x0002B372
		public static void Debug(global::System.Exception ex, [global::System.ComponentModel.Localizable(false)] string message)
		{
			global::NLog.Common.InternalLogger.Write(ex, global::NLog.LogLevel.Debug, message, null);
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x0002D181 File Offset: 0x0002B381
		public static void Debug(global::System.Exception ex, [global::System.ComponentModel.Localizable(false)] global::System.Func<string> messageFunc)
		{
			if (global::NLog.Common.InternalLogger.IsDebugEnabled)
			{
				global::NLog.Common.InternalLogger.Write(ex, global::NLog.LogLevel.Debug, messageFunc(), null);
			}
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x0002D19C File Offset: 0x0002B39C
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Info([global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			global::NLog.Common.InternalLogger.Write(null, global::NLog.LogLevel.Info, message, args);
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x0002D1AB File Offset: 0x0002B3AB
		public static void Info([global::System.ComponentModel.Localizable(false)] string message)
		{
			global::NLog.Common.InternalLogger.Write(null, global::NLog.LogLevel.Info, message, null);
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x0002D1BA File Offset: 0x0002B3BA
		public static void Info([global::System.ComponentModel.Localizable(false)] global::System.Func<string> messageFunc)
		{
			if (global::NLog.Common.InternalLogger.IsInfoEnabled)
			{
				global::NLog.Common.InternalLogger.Write(null, global::NLog.LogLevel.Info, messageFunc(), null);
			}
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x0002D1D5 File Offset: 0x0002B3D5
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Info(global::System.Exception ex, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			global::NLog.Common.InternalLogger.Write(ex, global::NLog.LogLevel.Info, message, args);
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x0002D1E4 File Offset: 0x0002B3E4
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Info<TArgument1>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 arg0)
		{
			if (global::NLog.Common.InternalLogger.IsInfoEnabled)
			{
				global::NLog.Common.InternalLogger.Log(null, global::NLog.LogLevel.Info, message, new object[]
				{
					arg0
				});
			}
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x0002D208 File Offset: 0x0002B408
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Info<TArgument1, TArgument2>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 arg0, TArgument2 arg1)
		{
			if (global::NLog.Common.InternalLogger.IsInfoEnabled)
			{
				global::NLog.Common.InternalLogger.Log(null, global::NLog.LogLevel.Info, message, new object[]
				{
					arg0,
					arg1
				});
			}
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x0002D235 File Offset: 0x0002B435
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Info<TArgument1, TArgument2, TArgument3>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 arg0, TArgument2 arg1, TArgument3 arg2)
		{
			if (global::NLog.Common.InternalLogger.IsInfoEnabled)
			{
				global::NLog.Common.InternalLogger.Log(null, global::NLog.LogLevel.Info, message, new object[]
				{
					arg0,
					arg1,
					arg2
				});
			}
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x0002D26B File Offset: 0x0002B46B
		public static void Info(global::System.Exception ex, [global::System.ComponentModel.Localizable(false)] string message)
		{
			global::NLog.Common.InternalLogger.Write(ex, global::NLog.LogLevel.Info, message, null);
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x0002D27A File Offset: 0x0002B47A
		public static void Info(global::System.Exception ex, [global::System.ComponentModel.Localizable(false)] global::System.Func<string> messageFunc)
		{
			if (global::NLog.Common.InternalLogger.IsInfoEnabled)
			{
				global::NLog.Common.InternalLogger.Write(ex, global::NLog.LogLevel.Info, messageFunc(), null);
			}
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x0002D295 File Offset: 0x0002B495
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Warn([global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			global::NLog.Common.InternalLogger.Write(null, global::NLog.LogLevel.Warn, message, args);
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x0002D2A4 File Offset: 0x0002B4A4
		public static void Warn([global::System.ComponentModel.Localizable(false)] string message)
		{
			global::NLog.Common.InternalLogger.Write(null, global::NLog.LogLevel.Warn, message, null);
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x0002D2B3 File Offset: 0x0002B4B3
		public static void Warn([global::System.ComponentModel.Localizable(false)] global::System.Func<string> messageFunc)
		{
			if (global::NLog.Common.InternalLogger.IsWarnEnabled)
			{
				global::NLog.Common.InternalLogger.Write(null, global::NLog.LogLevel.Warn, messageFunc(), null);
			}
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0002D2CE File Offset: 0x0002B4CE
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Warn(global::System.Exception ex, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			global::NLog.Common.InternalLogger.Write(ex, global::NLog.LogLevel.Warn, message, args);
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0002D2DD File Offset: 0x0002B4DD
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Warn<TArgument1>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 arg0)
		{
			if (global::NLog.Common.InternalLogger.IsWarnEnabled)
			{
				global::NLog.Common.InternalLogger.Log(null, global::NLog.LogLevel.Warn, message, new object[]
				{
					arg0
				});
			}
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0002D301 File Offset: 0x0002B501
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Warn<TArgument1, TArgument2>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 arg0, TArgument2 arg1)
		{
			if (global::NLog.Common.InternalLogger.IsWarnEnabled)
			{
				global::NLog.Common.InternalLogger.Log(null, global::NLog.LogLevel.Warn, message, new object[]
				{
					arg0,
					arg1
				});
			}
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x0002D32E File Offset: 0x0002B52E
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Warn<TArgument1, TArgument2, TArgument3>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 arg0, TArgument2 arg1, TArgument3 arg2)
		{
			if (global::NLog.Common.InternalLogger.IsWarnEnabled)
			{
				global::NLog.Common.InternalLogger.Log(null, global::NLog.LogLevel.Warn, message, new object[]
				{
					arg0,
					arg1,
					arg2
				});
			}
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x0002D364 File Offset: 0x0002B564
		public static void Warn(global::System.Exception ex, [global::System.ComponentModel.Localizable(false)] string message)
		{
			global::NLog.Common.InternalLogger.Write(ex, global::NLog.LogLevel.Warn, message, null);
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x0002D373 File Offset: 0x0002B573
		public static void Warn(global::System.Exception ex, [global::System.ComponentModel.Localizable(false)] global::System.Func<string> messageFunc)
		{
			if (global::NLog.Common.InternalLogger.IsWarnEnabled)
			{
				global::NLog.Common.InternalLogger.Write(ex, global::NLog.LogLevel.Warn, messageFunc(), null);
			}
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x0002D38E File Offset: 0x0002B58E
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Error([global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			global::NLog.Common.InternalLogger.Write(null, global::NLog.LogLevel.Error, message, args);
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x0002D39D File Offset: 0x0002B59D
		public static void Error([global::System.ComponentModel.Localizable(false)] string message)
		{
			global::NLog.Common.InternalLogger.Write(null, global::NLog.LogLevel.Error, message, null);
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0002D3AC File Offset: 0x0002B5AC
		public static void Error([global::System.ComponentModel.Localizable(false)] global::System.Func<string> messageFunc)
		{
			if (global::NLog.Common.InternalLogger.IsErrorEnabled)
			{
				global::NLog.Common.InternalLogger.Write(null, global::NLog.LogLevel.Error, messageFunc(), null);
			}
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0002D3C7 File Offset: 0x0002B5C7
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Error(global::System.Exception ex, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			global::NLog.Common.InternalLogger.Write(ex, global::NLog.LogLevel.Error, message, args);
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0002D3D6 File Offset: 0x0002B5D6
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Error<TArgument1>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 arg0)
		{
			if (global::NLog.Common.InternalLogger.IsErrorEnabled)
			{
				global::NLog.Common.InternalLogger.Log(null, global::NLog.LogLevel.Error, message, new object[]
				{
					arg0
				});
			}
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0002D3FA File Offset: 0x0002B5FA
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Error<TArgument1, TArgument2>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 arg0, TArgument2 arg1)
		{
			if (global::NLog.Common.InternalLogger.IsErrorEnabled)
			{
				global::NLog.Common.InternalLogger.Log(null, global::NLog.LogLevel.Error, message, new object[]
				{
					arg0,
					arg1
				});
			}
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x0002D427 File Offset: 0x0002B627
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Error<TArgument1, TArgument2, TArgument3>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 arg0, TArgument2 arg1, TArgument3 arg2)
		{
			if (global::NLog.Common.InternalLogger.IsErrorEnabled)
			{
				global::NLog.Common.InternalLogger.Log(null, global::NLog.LogLevel.Error, message, new object[]
				{
					arg0,
					arg1,
					arg2
				});
			}
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x0002D45D File Offset: 0x0002B65D
		public static void Error(global::System.Exception ex, [global::System.ComponentModel.Localizable(false)] string message)
		{
			global::NLog.Common.InternalLogger.Write(ex, global::NLog.LogLevel.Error, message, null);
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0002D46C File Offset: 0x0002B66C
		public static void Error(global::System.Exception ex, [global::System.ComponentModel.Localizable(false)] global::System.Func<string> messageFunc)
		{
			if (global::NLog.Common.InternalLogger.IsErrorEnabled)
			{
				global::NLog.Common.InternalLogger.Write(ex, global::NLog.LogLevel.Error, messageFunc(), null);
			}
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0002D487 File Offset: 0x0002B687
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Fatal([global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			global::NLog.Common.InternalLogger.Write(null, global::NLog.LogLevel.Fatal, message, args);
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0002D496 File Offset: 0x0002B696
		public static void Fatal([global::System.ComponentModel.Localizable(false)] string message)
		{
			global::NLog.Common.InternalLogger.Write(null, global::NLog.LogLevel.Fatal, message, null);
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x0002D4A5 File Offset: 0x0002B6A5
		public static void Fatal([global::System.ComponentModel.Localizable(false)] global::System.Func<string> messageFunc)
		{
			if (global::NLog.Common.InternalLogger.IsFatalEnabled)
			{
				global::NLog.Common.InternalLogger.Write(null, global::NLog.LogLevel.Fatal, messageFunc(), null);
			}
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0002D4C0 File Offset: 0x0002B6C0
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Fatal(global::System.Exception ex, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			global::NLog.Common.InternalLogger.Write(ex, global::NLog.LogLevel.Fatal, message, args);
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0002D4CF File Offset: 0x0002B6CF
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Fatal<TArgument1>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 arg0)
		{
			if (global::NLog.Common.InternalLogger.IsFatalEnabled)
			{
				global::NLog.Common.InternalLogger.Log(null, global::NLog.LogLevel.Fatal, message, new object[]
				{
					arg0
				});
			}
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0002D4F3 File Offset: 0x0002B6F3
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Fatal<TArgument1, TArgument2>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 arg0, TArgument2 arg1)
		{
			if (global::NLog.Common.InternalLogger.IsFatalEnabled)
			{
				global::NLog.Common.InternalLogger.Log(null, global::NLog.LogLevel.Fatal, message, new object[]
				{
					arg0,
					arg1
				});
			}
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0002D520 File Offset: 0x0002B720
		[global::NLog.MessageTemplateFormatMethod("message")]
		public static void Fatal<TArgument1, TArgument2, TArgument3>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 arg0, TArgument2 arg1, TArgument3 arg2)
		{
			if (global::NLog.Common.InternalLogger.IsFatalEnabled)
			{
				global::NLog.Common.InternalLogger.Log(null, global::NLog.LogLevel.Fatal, message, new object[]
				{
					arg0,
					arg1,
					arg2
				});
			}
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0002D556 File Offset: 0x0002B756
		public static void Fatal(global::System.Exception ex, [global::System.ComponentModel.Localizable(false)] string message)
		{
			global::NLog.Common.InternalLogger.Write(ex, global::NLog.LogLevel.Fatal, message, null);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x0002D565 File Offset: 0x0002B765
		public static void Fatal(global::System.Exception ex, [global::System.ComponentModel.Localizable(false)] global::System.Func<string> messageFunc)
		{
			if (global::NLog.Common.InternalLogger.IsFatalEnabled)
			{
				global::NLog.Common.InternalLogger.Write(ex, global::NLog.LogLevel.Fatal, messageFunc(), null);
			}
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0002D580 File Offset: 0x0002B780
		static InternalLogger()
		{
			global::NLog.Common.InternalLogger.Reset();
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0002D594 File Offset: 0x0002B794
		public static void Reset()
		{
			global::NLog.Common.InternalLogger.LogToConsole = global::NLog.Common.InternalLogger.GetSetting<bool>("nlog.internalLogToConsole", "NLOG_INTERNAL_LOG_TO_CONSOLE", false);
			global::NLog.Common.InternalLogger.LogToConsoleError = global::NLog.Common.InternalLogger.GetSetting<bool>("nlog.internalLogToConsoleError", "NLOG_INTERNAL_LOG_TO_CONSOLE_ERROR", false);
			global::NLog.Common.InternalLogger.LogLevel = global::NLog.Common.InternalLogger.GetSetting("nlog.internalLogLevel", "NLOG_INTERNAL_LOG_LEVEL", global::NLog.LogLevel.Info);
			global::NLog.Common.InternalLogger.LogFile = global::NLog.Common.InternalLogger.GetSetting<string>("nlog.internalLogFile", "NLOG_INTERNAL_LOG_FILE", string.Empty);
			global::NLog.Common.InternalLogger.LogToTrace = global::NLog.Common.InternalLogger.GetSetting<bool>("nlog.internalLogToTrace", "NLOG_INTERNAL_LOG_TO_TRACE", false);
			global::NLog.Common.InternalLogger.IncludeTimestamp = global::NLog.Common.InternalLogger.GetSetting<bool>("nlog.internalLogIncludeTimestamp", "NLOG_INTERNAL_INCLUDE_TIMESTAMP", true);
			global::NLog.Common.InternalLogger.Info("NLog internal logger initialized.");
			global::NLog.Common.InternalLogger.ExceptionThrowWhenWriting = false;
			global::NLog.Common.InternalLogger.LogWriter = null;
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x0002D63D File Offset: 0x0002B83D
		// (set) Token: 0x06001125 RID: 4389 RVA: 0x0002D644 File Offset: 0x0002B844
		public static global::NLog.LogLevel LogLevel { get; set; }

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x0002D64C File Offset: 0x0002B84C
		// (set) Token: 0x06001127 RID: 4391 RVA: 0x0002D653 File Offset: 0x0002B853
		public static bool LogToConsole { get; set; }

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x0002D65B File Offset: 0x0002B85B
		// (set) Token: 0x06001129 RID: 4393 RVA: 0x0002D662 File Offset: 0x0002B862
		public static bool LogToConsoleError { get; set; }

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x0002D66A File Offset: 0x0002B86A
		// (set) Token: 0x0600112B RID: 4395 RVA: 0x0002D671 File Offset: 0x0002B871
		public static bool LogToTrace { get; set; }

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x0600112C RID: 4396 RVA: 0x0002D679 File Offset: 0x0002B879
		// (set) Token: 0x0600112D RID: 4397 RVA: 0x0002D680 File Offset: 0x0002B880
		public static string LogFile
		{
			get
			{
				return global::NLog.Common.InternalLogger._logFile;
			}
			set
			{
				global::NLog.Common.InternalLogger._logFile = value;
				if (!string.IsNullOrEmpty(global::NLog.Common.InternalLogger._logFile))
				{
					global::NLog.Common.InternalLogger.CreateDirectoriesIfNeeded(global::NLog.Common.InternalLogger._logFile);
				}
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x0002D69E File Offset: 0x0002B89E
		// (set) Token: 0x0600112F RID: 4399 RVA: 0x0002D6A5 File Offset: 0x0002B8A5
		public static global::System.IO.TextWriter LogWriter { get; set; }

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x0002D6AD File Offset: 0x0002B8AD
		// (set) Token: 0x06001131 RID: 4401 RVA: 0x0002D6B4 File Offset: 0x0002B8B4
		public static bool IncludeTimestamp { get; set; }

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x0002D6BC File Offset: 0x0002B8BC
		// (set) Token: 0x06001133 RID: 4403 RVA: 0x0002D6C3 File Offset: 0x0002B8C3
		internal static bool ExceptionThrowWhenWriting { get; private set; }

		// Token: 0x06001134 RID: 4404 RVA: 0x0002D6CB File Offset: 0x0002B8CB
		[global::JetBrains.Annotations.StringFormatMethod("message")]
		public static void Log(global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			global::NLog.Common.InternalLogger.Write(null, level, message, args);
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x0002D6D6 File Offset: 0x0002B8D6
		public static void Log(global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] string message)
		{
			global::NLog.Common.InternalLogger.Write(null, level, message, null);
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x0002D6E1 File Offset: 0x0002B8E1
		public static void Log(global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] global::System.Func<string> messageFunc)
		{
			if (level >= global::NLog.Common.InternalLogger.LogLevel)
			{
				global::NLog.Common.InternalLogger.Write(null, level, messageFunc(), null);
			}
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x0002D6FE File Offset: 0x0002B8FE
		[global::JetBrains.Annotations.StringFormatMethod("message")]
		public static void Log(global::System.Exception ex, global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] global::System.Func<string> messageFunc)
		{
			if (level >= global::NLog.Common.InternalLogger.LogLevel)
			{
				global::NLog.Common.InternalLogger.Write(ex, level, messageFunc(), null);
			}
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x0002D71B File Offset: 0x0002B91B
		[global::JetBrains.Annotations.StringFormatMethod("message")]
		public static void Log(global::System.Exception ex, global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			global::NLog.Common.InternalLogger.Write(ex, level, message, args);
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x0002D726 File Offset: 0x0002B926
		public static void Log(global::System.Exception ex, global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] string message)
		{
			global::NLog.Common.InternalLogger.Write(ex, level, message, null);
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x0002D734 File Offset: 0x0002B934
		private static void Write([global::JetBrains.Annotations.CanBeNull] global::System.Exception ex, global::NLog.LogLevel level, string message, [global::JetBrains.Annotations.CanBeNull] object[] args)
		{
			if (global::NLog.Common.InternalLogger.IsSeriousException(ex))
			{
				return;
			}
			if (!global::NLog.Common.InternalLogger.IsLoggingEnabled(level))
			{
				return;
			}
			try
			{
				string message2 = global::NLog.Common.InternalLogger.FormatMessage(ex, level, message, args);
				global::NLog.Common.InternalLogger.WriteToLogFile(message2);
				global::NLog.Common.InternalLogger.WriteToTextWriter(message2);
				global::NLog.Common.InternalLogger.WriteToConsole(message2);
				global::NLog.Common.InternalLogger.WriteToErrorConsole(message2);
				global::NLog.Common.InternalLogger.WriteToTrace(message2);
			}
			catch (global::System.Exception exception)
			{
				global::NLog.Common.InternalLogger.ExceptionThrowWhenWriting = true;
				if (exception.MustBeRethrownImmediately())
				{
					throw;
				}
			}
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x0002D7A0 File Offset: 0x0002B9A0
		private static string FormatMessage([global::JetBrains.Annotations.CanBeNull] global::System.Exception ex, global::NLog.LogLevel level, string message, [global::JetBrains.Annotations.CanBeNull] object[] args)
		{
			string text = (args == null) ? message : string.Format(global::System.Globalization.CultureInfo.InvariantCulture, message, args);
			int num = text.Length + "yyyy-MM-dd HH:mm:ss.ffff".Length;
			int? num2;
			if (ex == null)
			{
				num2 = null;
			}
			else
			{
				string text2 = ex.ToString();
				num2 = ((text2 != null) ? new int?(text2.Length) : null);
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(num + (num2 ?? 0) + 25);
			if (global::NLog.Common.InternalLogger.IncludeTimestamp)
			{
				stringBuilder.Append(global::NLog.Time.TimeSource.Current.Time.ToString("yyyy-MM-dd HH:mm:ss.ffff", global::System.Globalization.CultureInfo.InvariantCulture)).Append(" ");
			}
			stringBuilder.Append(level).Append(" ").Append(text);
			if (ex != null)
			{
				ex.MarkAsLoggedToInternalLogger();
				stringBuilder.Append(" ").Append("Exception: ").Append(ex);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x0002D894 File Offset: 0x0002BA94
		private static bool IsSeriousException(global::System.Exception exception)
		{
			return exception != null && exception.MustBeRethrownImmediately();
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x0002D8A4 File Offset: 0x0002BAA4
		private static bool IsLoggingEnabled(global::NLog.LogLevel logLevel)
		{
			return !(logLevel == global::NLog.LogLevel.Off) && !(logLevel < global::NLog.Common.InternalLogger.LogLevel) && (!string.IsNullOrEmpty(global::NLog.Common.InternalLogger.LogFile) || global::NLog.Common.InternalLogger.LogToConsole || global::NLog.Common.InternalLogger.LogToConsoleError || global::NLog.Common.InternalLogger.LogToTrace || global::NLog.Common.InternalLogger.LogWriter != null);
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x0002D8F8 File Offset: 0x0002BAF8
		private static void WriteToLogFile(string message)
		{
			string logFile = global::NLog.Common.InternalLogger.LogFile;
			if (string.IsNullOrEmpty(logFile))
			{
				return;
			}
			object lockObject = global::NLog.Common.InternalLogger.LockObject;
			lock (lockObject)
			{
				using (global::System.IO.StreamWriter streamWriter = global::System.IO.File.AppendText(logFile))
				{
					streamWriter.WriteLine(message);
				}
			}
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0002D964 File Offset: 0x0002BB64
		private static void WriteToTextWriter(string message)
		{
			global::System.IO.TextWriter logWriter = global::NLog.Common.InternalLogger.LogWriter;
			if (logWriter == null)
			{
				return;
			}
			object lockObject = global::NLog.Common.InternalLogger.LockObject;
			lock (lockObject)
			{
				logWriter.WriteLine(message);
			}
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x0002D9B0 File Offset: 0x0002BBB0
		private static void WriteToConsole(string message)
		{
			if (!global::NLog.Common.InternalLogger.LogToConsole)
			{
				return;
			}
			object lockObject = global::NLog.Common.InternalLogger.LockObject;
			lock (lockObject)
			{
				global::System.Console.WriteLine(message);
			}
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x0002D9F8 File Offset: 0x0002BBF8
		private static void WriteToErrorConsole(string message)
		{
			if (!global::NLog.Common.InternalLogger.LogToConsoleError)
			{
				return;
			}
			object lockObject = global::NLog.Common.InternalLogger.LockObject;
			lock (lockObject)
			{
				global::System.Console.Error.WriteLine(message);
			}
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x0002DA44 File Offset: 0x0002BC44
		private static void WriteToTrace(string message)
		{
			if (!global::NLog.Common.InternalLogger.LogToTrace)
			{
				return;
			}
			global::System.Diagnostics.Trace.WriteLine(message, "NLog");
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x0002DA5C File Offset: 0x0002BC5C
		public static void LogAssemblyVersion(global::System.Reflection.Assembly assembly)
		{
			try
			{
				global::System.Diagnostics.FileVersionInfo versionInfo = global::System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
				global::NLog.Common.InternalLogger.Info<string, string, string>("{0}. File version: {1}. Product version: {2}.", assembly.FullName, versionInfo.FileVersion, versionInfo.ProductVersion);
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Error(ex, "Error logging version of assembly {0}.", new object[]
				{
					assembly.FullName
				});
			}
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x0002DAC0 File Offset: 0x0002BCC0
		private static string GetAppSettings(string configName)
		{
			try
			{
				return global::System.Configuration.ConfigurationManager.AppSettings[configName];
			}
			catch (global::System.Exception exception)
			{
				if (exception.MustBeRethrownImmediately())
				{
					throw;
				}
			}
			return null;
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x0002DAFC File Offset: 0x0002BCFC
		private static string GetSettingString(string configName, string envName)
		{
			try
			{
				string appSettings = global::NLog.Common.InternalLogger.GetAppSettings(configName);
				if (appSettings != null)
				{
					return appSettings;
				}
			}
			catch (global::System.Exception exception)
			{
				if (exception.MustBeRethrownImmediately())
				{
					throw;
				}
			}
			try
			{
				string safeEnvironmentVariable = global::NLog.Internal.EnvironmentHelper.GetSafeEnvironmentVariable(envName);
				if (!string.IsNullOrEmpty(safeEnvironmentVariable))
				{
					return safeEnvironmentVariable;
				}
			}
			catch (global::System.Exception exception2)
			{
				if (exception2.MustBeRethrownImmediately())
				{
					throw;
				}
			}
			return null;
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x0002DB64 File Offset: 0x0002BD64
		private static global::NLog.LogLevel GetSetting(string configName, string envName, global::NLog.LogLevel defaultValue)
		{
			string settingString = global::NLog.Common.InternalLogger.GetSettingString(configName, envName);
			if (settingString == null)
			{
				return defaultValue;
			}
			global::NLog.LogLevel result;
			try
			{
				result = global::NLog.LogLevel.FromString(settingString);
			}
			catch (global::System.Exception exception)
			{
				if (exception.MustBeRethrownImmediately())
				{
					throw;
				}
				result = defaultValue;
			}
			return result;
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x0002DBA8 File Offset: 0x0002BDA8
		private static T GetSetting<T>(string configName, string envName, T defaultValue)
		{
			string settingString = global::NLog.Common.InternalLogger.GetSettingString(configName, envName);
			if (settingString == null)
			{
				return defaultValue;
			}
			T result;
			try
			{
				result = (T)((object)global::System.Convert.ChangeType(settingString, typeof(T), global::System.Globalization.CultureInfo.InvariantCulture));
			}
			catch (global::System.Exception exception)
			{
				if (exception.MustBeRethrownImmediately())
				{
					throw;
				}
				result = defaultValue;
			}
			return result;
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x0002DC00 File Offset: 0x0002BE00
		private static void CreateDirectoriesIfNeeded(string filename)
		{
			try
			{
				if (!(global::NLog.Common.InternalLogger.LogLevel == global::NLog.LogLevel.Off))
				{
					string directoryName = global::System.IO.Path.GetDirectoryName(filename);
					if (!string.IsNullOrEmpty(directoryName))
					{
						global::System.IO.Directory.CreateDirectory(directoryName);
					}
				}
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Error(ex, "Cannot create needed directories to '{0}'.", new object[]
				{
					filename
				});
				if (ex.MustBeRethrownImmediately())
				{
					throw;
				}
			}
		}

		// Token: 0x040004BB RID: 1211
		private static readonly object LockObject = new object();

		// Token: 0x040004BC RID: 1212
		private static string _logFile;
	}
}
