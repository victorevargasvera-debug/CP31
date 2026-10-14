using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using NLog.Internal;

namespace NLog
{
	// Token: 0x0200000E RID: 14
	[global::System.CLSCompliant(true)]
	public class Logger : global::NLog.ILogger, global::NLog.ILoggerBase, global::NLog.ISuppress
	{
		// Token: 0x0600020E RID: 526 RVA: 0x00004220 File Offset: 0x00002420
		[global::System.Diagnostics.Conditional("DEBUG")]
		public void ConditionalDebug<T>(T value)
		{
			this.Debug<T>(value);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00004229 File Offset: 0x00002429
		[global::System.Diagnostics.Conditional("DEBUG")]
		public void ConditionalDebug<T>(global::System.IFormatProvider formatProvider, T value)
		{
			this.Debug<T>(formatProvider, value);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00004233 File Offset: 0x00002433
		[global::System.Diagnostics.Conditional("DEBUG")]
		public void ConditionalDebug(global::NLog.LogMessageGenerator messageFunc)
		{
			this.Debug(messageFunc);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000423C File Offset: 0x0000243C
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(global::System.Exception exception, string message, params object[] args)
		{
			this.Debug(exception, message, args);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00004247 File Offset: 0x00002447
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(global::System.Exception exception, global::System.IFormatProvider formatProvider, string message, params object[] args)
		{
			this.Debug(exception, formatProvider, message, args);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00004254 File Offset: 0x00002454
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(global::System.IFormatProvider formatProvider, string message, params object[] args)
		{
			this.Debug(formatProvider, message, args);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000425F File Offset: 0x0000245F
		[global::System.Diagnostics.Conditional("DEBUG")]
		public void ConditionalDebug(string message)
		{
			this.Debug(message);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00004268 File Offset: 0x00002468
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(string message, params object[] args)
		{
			this.Debug(message, args);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00004272 File Offset: 0x00002472
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug<TArgument>(global::System.IFormatProvider formatProvider, string message, TArgument argument)
		{
			this.Debug<TArgument>(formatProvider, message, argument);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000427D File Offset: 0x0000247D
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug<TArgument>(string message, TArgument argument)
		{
			this.Debug<TArgument>(message, argument);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00004287 File Offset: 0x00002487
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug<TArgument1, TArgument2>(global::System.IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2)
		{
			this.Debug<TArgument1, TArgument2>(formatProvider, message, argument1, argument2);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00004294 File Offset: 0x00002494
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
		{
			this.Debug<TArgument1, TArgument2>(message, argument1, argument2);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000429F File Offset: 0x0000249F
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug<TArgument1, TArgument2, TArgument3>(global::System.IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			this.Debug<TArgument1, TArgument2, TArgument3>(formatProvider, message, argument1, argument2, argument3);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000042AE File Offset: 0x000024AE
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			this.Debug<TArgument1, TArgument2, TArgument3>(message, argument1, argument2, argument3);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000042BB File Offset: 0x000024BB
		[global::System.Diagnostics.Conditional("DEBUG")]
		public void ConditionalDebug(object value)
		{
			this.Debug(value);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000042C4 File Offset: 0x000024C4
		[global::System.Diagnostics.Conditional("DEBUG")]
		public void ConditionalDebug(global::System.IFormatProvider formatProvider, object value)
		{
			this.Debug(formatProvider, value);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000042CE File Offset: 0x000024CE
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(string message, object arg1, object arg2)
		{
			this.Debug(message, arg1, arg2);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x000042D9 File Offset: 0x000024D9
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(string message, object arg1, object arg2, object arg3)
		{
			this.Debug(message, arg1, arg2, arg3);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000042E6 File Offset: 0x000024E6
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(global::System.IFormatProvider formatProvider, string message, bool argument)
		{
			this.Debug(formatProvider, message, argument);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000042F1 File Offset: 0x000024F1
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(string message, bool argument)
		{
			this.Debug(message, argument);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000042FB File Offset: 0x000024FB
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(global::System.IFormatProvider formatProvider, string message, char argument)
		{
			this.Debug(formatProvider, message, argument);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00004306 File Offset: 0x00002506
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(string message, char argument)
		{
			this.Debug(message, argument);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00004310 File Offset: 0x00002510
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(global::System.IFormatProvider formatProvider, string message, byte argument)
		{
			this.Debug(formatProvider, message, argument);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000431B File Offset: 0x0000251B
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(string message, byte argument)
		{
			this.Debug(message, argument);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00004325 File Offset: 0x00002525
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(global::System.IFormatProvider formatProvider, string message, string argument)
		{
			this.Debug(formatProvider, message, argument);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00004330 File Offset: 0x00002530
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(string message, string argument)
		{
			this.Debug(message, argument);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000433A File Offset: 0x0000253A
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(global::System.IFormatProvider formatProvider, string message, int argument)
		{
			this.Debug(formatProvider, message, argument);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00004345 File Offset: 0x00002545
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(string message, int argument)
		{
			this.Debug(message, argument);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000434F File Offset: 0x0000254F
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(global::System.IFormatProvider formatProvider, string message, long argument)
		{
			this.Debug(formatProvider, message, argument);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000435A File Offset: 0x0000255A
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(string message, long argument)
		{
			this.Debug(message, argument);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00004364 File Offset: 0x00002564
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(global::System.IFormatProvider formatProvider, string message, float argument)
		{
			this.Debug(formatProvider, message, argument);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000436F File Offset: 0x0000256F
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(string message, float argument)
		{
			this.Debug(message, argument);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00004379 File Offset: 0x00002579
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(global::System.IFormatProvider formatProvider, string message, double argument)
		{
			this.Debug(formatProvider, message, argument);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00004384 File Offset: 0x00002584
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(string message, double argument)
		{
			this.Debug(message, argument);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000438E File Offset: 0x0000258E
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(global::System.IFormatProvider formatProvider, string message, decimal argument)
		{
			this.Debug(formatProvider, message, argument);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00004399 File Offset: 0x00002599
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(string message, decimal argument)
		{
			this.Debug(message, argument);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000043A3 File Offset: 0x000025A3
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(global::System.IFormatProvider formatProvider, string message, object argument)
		{
			this.Debug(formatProvider, message, argument);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000043AE File Offset: 0x000025AE
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalDebug(string message, object argument)
		{
			this.Debug(message, argument);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000043B8 File Offset: 0x000025B8
		[global::System.Diagnostics.Conditional("DEBUG")]
		public void ConditionalTrace<T>(T value)
		{
			this.Trace<T>(value);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000043C1 File Offset: 0x000025C1
		[global::System.Diagnostics.Conditional("DEBUG")]
		public void ConditionalTrace<T>(global::System.IFormatProvider formatProvider, T value)
		{
			this.Trace<T>(formatProvider, value);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000043CB File Offset: 0x000025CB
		[global::System.Diagnostics.Conditional("DEBUG")]
		public void ConditionalTrace(global::NLog.LogMessageGenerator messageFunc)
		{
			this.Trace(messageFunc);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000043D4 File Offset: 0x000025D4
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(global::System.Exception exception, string message, params object[] args)
		{
			this.Trace(exception, message, args);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000043DF File Offset: 0x000025DF
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(global::System.Exception exception, global::System.IFormatProvider formatProvider, string message, params object[] args)
		{
			this.Trace(exception, formatProvider, message, args);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000043EC File Offset: 0x000025EC
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(global::System.IFormatProvider formatProvider, string message, params object[] args)
		{
			this.Trace(formatProvider, message, args);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000043F7 File Offset: 0x000025F7
		[global::System.Diagnostics.Conditional("DEBUG")]
		public void ConditionalTrace(string message)
		{
			this.Trace(message);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00004400 File Offset: 0x00002600
		[global::System.Diagnostics.Conditional("DEBUG")]
		public void ConditionalTrace(string message, params object[] args)
		{
			this.Trace(message, args);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000440A File Offset: 0x0000260A
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace<TArgument>(global::System.IFormatProvider formatProvider, string message, TArgument argument)
		{
			this.Trace<TArgument>(formatProvider, message, argument);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00004415 File Offset: 0x00002615
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace<TArgument>(string message, TArgument argument)
		{
			this.Trace<TArgument>(message, argument);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000441F File Offset: 0x0000261F
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace<TArgument1, TArgument2>(global::System.IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2)
		{
			this.Trace<TArgument1, TArgument2>(formatProvider, message, argument1, argument2);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000442C File Offset: 0x0000262C
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
		{
			this.Trace<TArgument1, TArgument2>(message, argument1, argument2);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00004437 File Offset: 0x00002637
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace<TArgument1, TArgument2, TArgument3>(global::System.IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			this.Trace<TArgument1, TArgument2, TArgument3>(formatProvider, message, argument1, argument2, argument3);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00004446 File Offset: 0x00002646
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			this.Trace<TArgument1, TArgument2, TArgument3>(message, argument1, argument2, argument3);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00004453 File Offset: 0x00002653
		[global::System.Diagnostics.Conditional("DEBUG")]
		public void ConditionalTrace(object value)
		{
			this.Trace(value);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000445C File Offset: 0x0000265C
		[global::System.Diagnostics.Conditional("DEBUG")]
		public void ConditionalTrace(global::System.IFormatProvider formatProvider, object value)
		{
			this.Trace(formatProvider, value);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00004466 File Offset: 0x00002666
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(string message, object arg1, object arg2)
		{
			this.Trace(message, arg1, arg2);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00004471 File Offset: 0x00002671
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(string message, object arg1, object arg2, object arg3)
		{
			this.Trace(message, arg1, arg2, arg3);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000447E File Offset: 0x0000267E
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(global::System.IFormatProvider formatProvider, string message, bool argument)
		{
			this.Trace(formatProvider, message, argument);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00004489 File Offset: 0x00002689
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(string message, bool argument)
		{
			this.Trace(message, argument);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00004493 File Offset: 0x00002693
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(global::System.IFormatProvider formatProvider, string message, char argument)
		{
			this.Trace(formatProvider, message, argument);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000449E File Offset: 0x0000269E
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(string message, char argument)
		{
			this.Trace(message, argument);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000044A8 File Offset: 0x000026A8
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(global::System.IFormatProvider formatProvider, string message, byte argument)
		{
			this.Trace(formatProvider, message, argument);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000044B3 File Offset: 0x000026B3
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(string message, byte argument)
		{
			this.Trace(message, argument);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000044BD File Offset: 0x000026BD
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(global::System.IFormatProvider formatProvider, string message, string argument)
		{
			this.Trace(formatProvider, message, argument);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000044C8 File Offset: 0x000026C8
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(string message, string argument)
		{
			this.Trace(message, argument);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000044D2 File Offset: 0x000026D2
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(global::System.IFormatProvider formatProvider, string message, int argument)
		{
			this.Trace(formatProvider, message, argument);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000044DD File Offset: 0x000026DD
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(string message, int argument)
		{
			this.Trace(message, argument);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000044E7 File Offset: 0x000026E7
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(global::System.IFormatProvider formatProvider, string message, long argument)
		{
			this.Trace(formatProvider, message, argument);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000044F2 File Offset: 0x000026F2
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(string message, long argument)
		{
			this.Trace(message, argument);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000044FC File Offset: 0x000026FC
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(global::System.IFormatProvider formatProvider, string message, float argument)
		{
			this.Trace(formatProvider, message, argument);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00004507 File Offset: 0x00002707
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(string message, float argument)
		{
			this.Trace(message, argument);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00004511 File Offset: 0x00002711
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(global::System.IFormatProvider formatProvider, string message, double argument)
		{
			this.Trace(formatProvider, message, argument);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000451C File Offset: 0x0000271C
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(string message, double argument)
		{
			this.Trace(message, argument);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00004526 File Offset: 0x00002726
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(global::System.IFormatProvider formatProvider, string message, decimal argument)
		{
			this.Trace(formatProvider, message, argument);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00004531 File Offset: 0x00002731
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(string message, decimal argument)
		{
			this.Trace(message, argument);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000453B File Offset: 0x0000273B
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(global::System.IFormatProvider formatProvider, string message, object argument)
		{
			this.Trace(formatProvider, message, argument);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00004546 File Offset: 0x00002746
		[global::System.Diagnostics.Conditional("DEBUG")]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void ConditionalTrace(string message, object argument)
		{
			this.Trace(message, argument);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00004550 File Offset: 0x00002750
		public bool IsTraceEnabled
		{
			get
			{
				return this._isTraceEnabled;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0000455A File Offset: 0x0000275A
		public bool IsDebugEnabled
		{
			get
			{
				return this._isDebugEnabled;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00004564 File Offset: 0x00002764
		public bool IsInfoEnabled
		{
			get
			{
				return this._isInfoEnabled;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0000456E File Offset: 0x0000276E
		public bool IsWarnEnabled
		{
			get
			{
				return this._isWarnEnabled;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00004578 File Offset: 0x00002778
		public bool IsErrorEnabled
		{
			get
			{
				return this._isErrorEnabled;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00004582 File Offset: 0x00002782
		public bool IsFatalEnabled
		{
			get
			{
				return this._isFatalEnabled;
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000458C File Offset: 0x0000278C
		public void Trace<T>(T value)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets<T>(global::NLog.LogLevel.Trace, null, value);
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000045A3 File Offset: 0x000027A3
		public void Trace<T>(global::System.IFormatProvider formatProvider, T value)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets<T>(global::NLog.LogLevel.Trace, formatProvider, value);
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000045BA File Offset: 0x000027BA
		public void Trace(global::NLog.LogMessageGenerator messageFunc)
		{
			if (this.IsTraceEnabled)
			{
				if (messageFunc == null)
				{
					throw new global::System.ArgumentNullException("messageFunc");
				}
				this.WriteToTargets(global::NLog.LogLevel.Trace, null, messageFunc());
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x000045E4 File Offset: 0x000027E4
		[global::System.Obsolete("Use Trace(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void TraceException([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception)
		{
			this.Trace(message, exception);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000045EE File Offset: 0x000027EE
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, formatProvider, message, args);
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00004606 File Offset: 0x00002806
		public void Trace([global::System.ComponentModel.Localizable(false)] string message)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, null, message);
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000461D File Offset: 0x0000281D
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace([global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, message, args);
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00004634 File Offset: 0x00002834
		[global::System.Obsolete("Use Trace(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void Trace([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, exception, message, null);
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000464C File Offset: 0x0000284C
		public void Trace(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, exception, message, null);
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00004664 File Offset: 0x00002864
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, exception, message, args);
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000467C File Offset: 0x0000287C
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(global::System.Exception exception, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, exception, formatProvider, message, args);
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00004696 File Offset: 0x00002896
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace<TArgument>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000046BC File Offset: 0x000028BC
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace<TArgument>([global::System.ComponentModel.Localizable(false)] string message, TArgument argument)
		{
			if (this.IsTraceEnabled)
			{
				if (this._configuration.ExceptionLoggingOldStyle)
				{
					global::System.Exception ex = argument as global::System.Exception;
					if (ex != null)
					{
						this.Trace(message, ex);
						return;
					}
				}
				this.WriteToTargets(global::NLog.LogLevel.Trace, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00004713 File Offset: 0x00002913
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace<TArgument1, TArgument2>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, formatProvider, message, new object[]
				{
					argument1,
					argument2
				});
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00004743 File Offset: 0x00002943
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace<TArgument1, TArgument2>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, message, new object[]
				{
					argument1,
					argument2
				});
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00004771 File Offset: 0x00002971
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace<TArgument1, TArgument2, TArgument3>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, formatProvider, message, new object[]
				{
					argument1,
					argument2,
					argument3
				});
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x000047AB File Offset: 0x000029AB
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace<TArgument1, TArgument2, TArgument3>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, message, new object[]
				{
					argument1,
					argument2,
					argument3
				});
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000047E3 File Offset: 0x000029E3
		public void Debug<T>(T value)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets<T>(global::NLog.LogLevel.Debug, null, value);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000047FA File Offset: 0x000029FA
		public void Debug<T>(global::System.IFormatProvider formatProvider, T value)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets<T>(global::NLog.LogLevel.Debug, formatProvider, value);
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00004811 File Offset: 0x00002A11
		public void Debug(global::NLog.LogMessageGenerator messageFunc)
		{
			if (this.IsDebugEnabled)
			{
				if (messageFunc == null)
				{
					throw new global::System.ArgumentNullException("messageFunc");
				}
				this.WriteToTargets(global::NLog.LogLevel.Debug, null, messageFunc());
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000483B File Offset: 0x00002A3B
		[global::System.Obsolete("Use Debug(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void DebugException([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception)
		{
			this.Debug(message, exception);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00004845 File Offset: 0x00002A45
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, formatProvider, message, args);
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000485D File Offset: 0x00002A5D
		public void Debug([global::System.ComponentModel.Localizable(false)] string message)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, null, message);
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00004874 File Offset: 0x00002A74
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug([global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, message, args);
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000488B File Offset: 0x00002A8B
		[global::System.Obsolete("Use Debug(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void Debug([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, exception, message, null);
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000048A3 File Offset: 0x00002AA3
		public void Debug(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, exception, message, null);
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x000048BB File Offset: 0x00002ABB
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, exception, message, args);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000048D3 File Offset: 0x00002AD3
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(global::System.Exception exception, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, exception, formatProvider, message, args);
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000048ED File Offset: 0x00002AED
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug<TArgument>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00004914 File Offset: 0x00002B14
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug<TArgument>([global::System.ComponentModel.Localizable(false)] string message, TArgument argument)
		{
			if (this.IsDebugEnabled)
			{
				if (this._configuration.ExceptionLoggingOldStyle)
				{
					global::System.Exception ex = argument as global::System.Exception;
					if (ex != null)
					{
						this.Debug(message, ex);
						return;
					}
				}
				this.WriteToTargets(global::NLog.LogLevel.Debug, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000496B File Offset: 0x00002B6B
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug<TArgument1, TArgument2>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, formatProvider, message, new object[]
				{
					argument1,
					argument2
				});
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000499B File Offset: 0x00002B9B
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug<TArgument1, TArgument2>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, message, new object[]
				{
					argument1,
					argument2
				});
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000049C9 File Offset: 0x00002BC9
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug<TArgument1, TArgument2, TArgument3>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, formatProvider, message, new object[]
				{
					argument1,
					argument2,
					argument3
				});
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00004A03 File Offset: 0x00002C03
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug<TArgument1, TArgument2, TArgument3>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, message, new object[]
				{
					argument1,
					argument2,
					argument3
				});
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00004A3B File Offset: 0x00002C3B
		public void Info<T>(T value)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets<T>(global::NLog.LogLevel.Info, null, value);
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00004A52 File Offset: 0x00002C52
		public void Info<T>(global::System.IFormatProvider formatProvider, T value)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets<T>(global::NLog.LogLevel.Info, formatProvider, value);
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00004A69 File Offset: 0x00002C69
		public void Info(global::NLog.LogMessageGenerator messageFunc)
		{
			if (this.IsInfoEnabled)
			{
				if (messageFunc == null)
				{
					throw new global::System.ArgumentNullException("messageFunc");
				}
				this.WriteToTargets(global::NLog.LogLevel.Info, null, messageFunc());
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00004A93 File Offset: 0x00002C93
		[global::System.Obsolete("Use Info(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void InfoException([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception)
		{
			this.Info(message, exception);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00004A9D File Offset: 0x00002C9D
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, formatProvider, message, args);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00004AB5 File Offset: 0x00002CB5
		public void Info([global::System.ComponentModel.Localizable(false)] string message)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, null, message);
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00004ACC File Offset: 0x00002CCC
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info([global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, message, args);
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00004AE3 File Offset: 0x00002CE3
		[global::System.Obsolete("Use Info(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void Info([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, exception, message, null);
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00004AFB File Offset: 0x00002CFB
		public void Info(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, exception, message, null);
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00004B13 File Offset: 0x00002D13
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, exception, message, args);
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00004B2B File Offset: 0x00002D2B
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(global::System.Exception exception, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, exception, formatProvider, message, args);
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00004B45 File Offset: 0x00002D45
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info<TArgument>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00004B6C File Offset: 0x00002D6C
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info<TArgument>([global::System.ComponentModel.Localizable(false)] string message, TArgument argument)
		{
			if (this.IsInfoEnabled)
			{
				if (this._configuration.ExceptionLoggingOldStyle)
				{
					global::System.Exception ex = argument as global::System.Exception;
					if (ex != null)
					{
						this.Info(message, ex);
						return;
					}
				}
				this.WriteToTargets(global::NLog.LogLevel.Info, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00004BC3 File Offset: 0x00002DC3
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info<TArgument1, TArgument2>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, formatProvider, message, new object[]
				{
					argument1,
					argument2
				});
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00004BF3 File Offset: 0x00002DF3
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info<TArgument1, TArgument2>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, message, new object[]
				{
					argument1,
					argument2
				});
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00004C21 File Offset: 0x00002E21
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info<TArgument1, TArgument2, TArgument3>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, formatProvider, message, new object[]
				{
					argument1,
					argument2,
					argument3
				});
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00004C5B File Offset: 0x00002E5B
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info<TArgument1, TArgument2, TArgument3>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, message, new object[]
				{
					argument1,
					argument2,
					argument3
				});
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00004C93 File Offset: 0x00002E93
		public void Warn<T>(T value)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets<T>(global::NLog.LogLevel.Warn, null, value);
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00004CAA File Offset: 0x00002EAA
		public void Warn<T>(global::System.IFormatProvider formatProvider, T value)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets<T>(global::NLog.LogLevel.Warn, formatProvider, value);
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00004CC1 File Offset: 0x00002EC1
		public void Warn(global::NLog.LogMessageGenerator messageFunc)
		{
			if (this.IsWarnEnabled)
			{
				if (messageFunc == null)
				{
					throw new global::System.ArgumentNullException("messageFunc");
				}
				this.WriteToTargets(global::NLog.LogLevel.Warn, null, messageFunc());
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00004CEB File Offset: 0x00002EEB
		[global::System.Obsolete("Use Warn(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void WarnException([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception)
		{
			this.Warn(message, exception);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00004CF5 File Offset: 0x00002EF5
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, formatProvider, message, args);
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00004D0D File Offset: 0x00002F0D
		public void Warn([global::System.ComponentModel.Localizable(false)] string message)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, null, message);
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00004D24 File Offset: 0x00002F24
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn([global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, message, args);
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00004D3B File Offset: 0x00002F3B
		[global::System.Obsolete("Use Warn(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void Warn([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, exception, message, null);
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00004D53 File Offset: 0x00002F53
		public void Warn(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, exception, message, null);
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00004D6B File Offset: 0x00002F6B
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, exception, message, args);
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00004D83 File Offset: 0x00002F83
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(global::System.Exception exception, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, exception, formatProvider, message, args);
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00004D9D File Offset: 0x00002F9D
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn<TArgument>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00004DC4 File Offset: 0x00002FC4
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn<TArgument>([global::System.ComponentModel.Localizable(false)] string message, TArgument argument)
		{
			if (this.IsWarnEnabled)
			{
				if (this._configuration.ExceptionLoggingOldStyle)
				{
					global::System.Exception ex = argument as global::System.Exception;
					if (ex != null)
					{
						this.Warn(message, ex);
						return;
					}
				}
				this.WriteToTargets(global::NLog.LogLevel.Warn, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00004E1B File Offset: 0x0000301B
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn<TArgument1, TArgument2>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, formatProvider, message, new object[]
				{
					argument1,
					argument2
				});
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00004E4B File Offset: 0x0000304B
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn<TArgument1, TArgument2>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, message, new object[]
				{
					argument1,
					argument2
				});
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00004E79 File Offset: 0x00003079
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn<TArgument1, TArgument2, TArgument3>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, formatProvider, message, new object[]
				{
					argument1,
					argument2,
					argument3
				});
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00004EB3 File Offset: 0x000030B3
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn<TArgument1, TArgument2, TArgument3>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, message, new object[]
				{
					argument1,
					argument2,
					argument3
				});
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00004EEB File Offset: 0x000030EB
		public void Error<T>(T value)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets<T>(global::NLog.LogLevel.Error, null, value);
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00004F02 File Offset: 0x00003102
		public void Error<T>(global::System.IFormatProvider formatProvider, T value)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets<T>(global::NLog.LogLevel.Error, formatProvider, value);
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00004F19 File Offset: 0x00003119
		public void Error(global::NLog.LogMessageGenerator messageFunc)
		{
			if (this.IsErrorEnabled)
			{
				if (messageFunc == null)
				{
					throw new global::System.ArgumentNullException("messageFunc");
				}
				this.WriteToTargets(global::NLog.LogLevel.Error, null, messageFunc());
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00004F43 File Offset: 0x00003143
		[global::System.Obsolete("Use Error(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void ErrorException([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception)
		{
			this.Error(message, exception);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00004F4D File Offset: 0x0000314D
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, formatProvider, message, args);
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00004F65 File Offset: 0x00003165
		public void Error([global::System.ComponentModel.Localizable(false)] string message)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, null, message);
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00004F7C File Offset: 0x0000317C
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error([global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, message, args);
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00004F93 File Offset: 0x00003193
		[global::System.Obsolete("Use Error(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void Error([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, exception, message, null);
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00004FAB File Offset: 0x000031AB
		public void Error(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, exception, message, null);
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00004FC3 File Offset: 0x000031C3
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, exception, message, args);
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00004FDB File Offset: 0x000031DB
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(global::System.Exception exception, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, exception, formatProvider, message, args);
			}
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00004FF5 File Offset: 0x000031F5
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error<TArgument>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000501C File Offset: 0x0000321C
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error<TArgument>([global::System.ComponentModel.Localizable(false)] string message, TArgument argument)
		{
			if (this.IsErrorEnabled)
			{
				if (this._configuration.ExceptionLoggingOldStyle)
				{
					global::System.Exception ex = argument as global::System.Exception;
					if (ex != null)
					{
						this.Error(message, ex);
						return;
					}
				}
				this.WriteToTargets(global::NLog.LogLevel.Error, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00005073 File Offset: 0x00003273
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error<TArgument1, TArgument2>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, formatProvider, message, new object[]
				{
					argument1,
					argument2
				});
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000050A3 File Offset: 0x000032A3
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error<TArgument1, TArgument2>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, message, new object[]
				{
					argument1,
					argument2
				});
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000050D1 File Offset: 0x000032D1
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error<TArgument1, TArgument2, TArgument3>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, formatProvider, message, new object[]
				{
					argument1,
					argument2,
					argument3
				});
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000510B File Offset: 0x0000330B
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error<TArgument1, TArgument2, TArgument3>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, message, new object[]
				{
					argument1,
					argument2,
					argument3
				});
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00005143 File Offset: 0x00003343
		public void Fatal<T>(T value)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets<T>(global::NLog.LogLevel.Fatal, null, value);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000515A File Offset: 0x0000335A
		public void Fatal<T>(global::System.IFormatProvider formatProvider, T value)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets<T>(global::NLog.LogLevel.Fatal, formatProvider, value);
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00005171 File Offset: 0x00003371
		public void Fatal(global::NLog.LogMessageGenerator messageFunc)
		{
			if (this.IsFatalEnabled)
			{
				if (messageFunc == null)
				{
					throw new global::System.ArgumentNullException("messageFunc");
				}
				this.WriteToTargets(global::NLog.LogLevel.Fatal, null, messageFunc());
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000519B File Offset: 0x0000339B
		[global::System.Obsolete("Use Fatal(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void FatalException([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception)
		{
			this.Fatal(message, exception);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000051A5 File Offset: 0x000033A5
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, formatProvider, message, args);
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000051BD File Offset: 0x000033BD
		public void Fatal([global::System.ComponentModel.Localizable(false)] string message)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, null, message);
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000051D4 File Offset: 0x000033D4
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal([global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, message, args);
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000051EB File Offset: 0x000033EB
		[global::System.Obsolete("Use Fatal(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void Fatal([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, exception, message, null);
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00005203 File Offset: 0x00003403
		public void Fatal(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, exception, message, null);
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000521B File Offset: 0x0000341B
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, exception, message, args);
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00005233 File Offset: 0x00003433
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(global::System.Exception exception, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, exception, formatProvider, message, args);
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000524D File Offset: 0x0000344D
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal<TArgument>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00005274 File Offset: 0x00003474
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal<TArgument>([global::System.ComponentModel.Localizable(false)] string message, TArgument argument)
		{
			if (this.IsFatalEnabled)
			{
				if (this._configuration.ExceptionLoggingOldStyle)
				{
					global::System.Exception ex = argument as global::System.Exception;
					if (ex != null)
					{
						this.Fatal(message, ex);
						return;
					}
				}
				this.WriteToTargets(global::NLog.LogLevel.Fatal, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x000052CB File Offset: 0x000034CB
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal<TArgument1, TArgument2>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, formatProvider, message, new object[]
				{
					argument1,
					argument2
				});
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000052FB File Offset: 0x000034FB
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal<TArgument1, TArgument2>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, message, new object[]
				{
					argument1,
					argument2
				});
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00005329 File Offset: 0x00003529
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal<TArgument1, TArgument2, TArgument3>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, formatProvider, message, new object[]
				{
					argument1,
					argument2,
					argument3
				});
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00005363 File Offset: 0x00003563
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal<TArgument1, TArgument2, TArgument3>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, message, new object[]
				{
					argument1,
					argument2,
					argument3
				});
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000539B File Offset: 0x0000359B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Log(global::NLog.LogLevel level, object value)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets<object>(level, null, value);
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000053AF File Offset: 0x000035AF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, object value)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets<object>(level, formatProvider, value);
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000053C3 File Offset: 0x000035C3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, string message, object arg1, object arg2)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, message, new object[]
				{
					arg1,
					arg2
				});
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x000053E5 File Offset: 0x000035E5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, string message, object arg1, object arg2, object arg3)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, message, new object[]
				{
					arg1,
					arg2,
					arg3
				});
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000540C File Offset: 0x0000360C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, bool argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00005430 File Offset: 0x00003630
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Log(global::NLog.LogLevel level, string message, bool argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00005452 File Offset: 0x00003652
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, char argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00005476 File Offset: 0x00003676
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Log(global::NLog.LogLevel level, string message, char argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00005498 File Offset: 0x00003698
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, byte argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000054BC File Offset: 0x000036BC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Log(global::NLog.LogLevel level, string message, byte argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000054DE File Offset: 0x000036DE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, string argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000054FD File Offset: 0x000036FD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Log(global::NLog.LogLevel level, string message, string argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000551A File Offset: 0x0000371A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, int argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000553E File Offset: 0x0000373E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Log(global::NLog.LogLevel level, string message, int argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00005560 File Offset: 0x00003760
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, long argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00005584 File Offset: 0x00003784
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Log(global::NLog.LogLevel level, string message, long argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x000055A6 File Offset: 0x000037A6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, float argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000055CA File Offset: 0x000037CA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Log(global::NLog.LogLevel level, string message, float argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000055EC File Offset: 0x000037EC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, double argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00005610 File Offset: 0x00003810
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Log(global::NLog.LogLevel level, string message, double argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00005632 File Offset: 0x00003832
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, decimal argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00005656 File Offset: 0x00003856
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Log(global::NLog.LogLevel level, string message, decimal argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00005678 File Offset: 0x00003878
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, object argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00005697 File Offset: 0x00003897
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Log(global::NLog.LogLevel level, string message, object argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000056B4 File Offset: 0x000038B4
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, sbyte argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000056D8 File Offset: 0x000038D8
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, string message, sbyte argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x000056FA File Offset: 0x000038FA
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, uint argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000571E File Offset: 0x0000391E
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, string message, uint argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00005740 File Offset: 0x00003940
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, string message, ulong argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00005764 File Offset: 0x00003964
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, string message, ulong argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00005786 File Offset: 0x00003986
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Trace(object value)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets<object>(global::NLog.LogLevel.Trace, null, value);
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000579D File Offset: 0x0000399D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Trace(global::System.IFormatProvider formatProvider, object value)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets<object>(global::NLog.LogLevel.Trace, formatProvider, value);
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000057B4 File Offset: 0x000039B4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(string message, object arg1, object arg2)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, message, new object[]
				{
					arg1,
					arg2
				});
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000057D8 File Offset: 0x000039D8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(string message, object arg1, object arg2, object arg3)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, message, new object[]
				{
					arg1,
					arg2,
					arg3
				});
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00005801 File Offset: 0x00003A01
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(global::System.IFormatProvider formatProvider, string message, bool argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00005827 File Offset: 0x00003A27
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Trace(string message, bool argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000584C File Offset: 0x00003A4C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(global::System.IFormatProvider formatProvider, string message, char argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00005872 File Offset: 0x00003A72
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Trace(string message, char argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00005897 File Offset: 0x00003A97
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(global::System.IFormatProvider formatProvider, string message, byte argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000058BD File Offset: 0x00003ABD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Trace(string message, byte argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000058E2 File Offset: 0x00003AE2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(global::System.IFormatProvider formatProvider, string message, string argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00005903 File Offset: 0x00003B03
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Trace(string message, string argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00005923 File Offset: 0x00003B23
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(global::System.IFormatProvider formatProvider, string message, int argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00005949 File Offset: 0x00003B49
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Trace(string message, int argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000596E File Offset: 0x00003B6E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(global::System.IFormatProvider formatProvider, string message, long argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00005994 File Offset: 0x00003B94
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Trace(string message, long argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000059B9 File Offset: 0x00003BB9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(global::System.IFormatProvider formatProvider, string message, float argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x000059DF File Offset: 0x00003BDF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Trace(string message, float argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00005A04 File Offset: 0x00003C04
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(global::System.IFormatProvider formatProvider, string message, double argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00005A2A File Offset: 0x00003C2A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Trace(string message, double argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00005A4F File Offset: 0x00003C4F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(global::System.IFormatProvider formatProvider, string message, decimal argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00005A75 File Offset: 0x00003C75
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Trace(string message, decimal argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00005A9A File Offset: 0x00003C9A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(global::System.IFormatProvider formatProvider, string message, object argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00005ABB File Offset: 0x00003CBB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Trace(string message, object argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00005ADB File Offset: 0x00003CDB
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(global::System.IFormatProvider formatProvider, string message, sbyte argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00005B01 File Offset: 0x00003D01
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(string message, sbyte argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00005B26 File Offset: 0x00003D26
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(global::System.IFormatProvider formatProvider, string message, uint argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00005B4C File Offset: 0x00003D4C
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(string message, uint argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00005B71 File Offset: 0x00003D71
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(global::System.IFormatProvider formatProvider, string message, ulong argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00005B97 File Offset: 0x00003D97
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Trace(string message, ulong argument)
		{
			if (this.IsTraceEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Trace, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00005BBC File Offset: 0x00003DBC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Debug(object value)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets<object>(global::NLog.LogLevel.Debug, null, value);
			}
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00005BD3 File Offset: 0x00003DD3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Debug(global::System.IFormatProvider formatProvider, object value)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets<object>(global::NLog.LogLevel.Debug, formatProvider, value);
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00005BEA File Offset: 0x00003DEA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(string message, object arg1, object arg2)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, message, new object[]
				{
					arg1,
					arg2
				});
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00005C0E File Offset: 0x00003E0E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(string message, object arg1, object arg2, object arg3)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, message, new object[]
				{
					arg1,
					arg2,
					arg3
				});
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00005C37 File Offset: 0x00003E37
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(global::System.IFormatProvider formatProvider, string message, bool argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00005C5D File Offset: 0x00003E5D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Debug(string message, bool argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00005C82 File Offset: 0x00003E82
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(global::System.IFormatProvider formatProvider, string message, char argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00005CA8 File Offset: 0x00003EA8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Debug(string message, char argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00005CCD File Offset: 0x00003ECD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(global::System.IFormatProvider formatProvider, string message, byte argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00005CF3 File Offset: 0x00003EF3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Debug(string message, byte argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00005D18 File Offset: 0x00003F18
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(global::System.IFormatProvider formatProvider, string message, string argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00005D39 File Offset: 0x00003F39
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Debug(string message, string argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00005D59 File Offset: 0x00003F59
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(global::System.IFormatProvider formatProvider, string message, int argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00005D7F File Offset: 0x00003F7F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Debug(string message, int argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00005DA4 File Offset: 0x00003FA4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(global::System.IFormatProvider formatProvider, string message, long argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00005DCA File Offset: 0x00003FCA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Debug(string message, long argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00005DEF File Offset: 0x00003FEF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(global::System.IFormatProvider formatProvider, string message, float argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00005E15 File Offset: 0x00004015
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Debug(string message, float argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00005E3A File Offset: 0x0000403A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(global::System.IFormatProvider formatProvider, string message, double argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00005E60 File Offset: 0x00004060
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Debug(string message, double argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00005E85 File Offset: 0x00004085
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(global::System.IFormatProvider formatProvider, string message, decimal argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00005EAB File Offset: 0x000040AB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Debug(string message, decimal argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00005ED0 File Offset: 0x000040D0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(global::System.IFormatProvider formatProvider, string message, object argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00005EF1 File Offset: 0x000040F1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Debug(string message, object argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00005F11 File Offset: 0x00004111
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(global::System.IFormatProvider formatProvider, string message, sbyte argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00005F37 File Offset: 0x00004137
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(string message, sbyte argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00005F5C File Offset: 0x0000415C
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(global::System.IFormatProvider formatProvider, string message, uint argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00005F82 File Offset: 0x00004182
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(string message, uint argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00005FA7 File Offset: 0x000041A7
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(global::System.IFormatProvider formatProvider, string message, ulong argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00005FCD File Offset: 0x000041CD
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Debug(string message, ulong argument)
		{
			if (this.IsDebugEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Debug, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00005FF2 File Offset: 0x000041F2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Info(object value)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets<object>(global::NLog.LogLevel.Info, null, value);
			}
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00006009 File Offset: 0x00004209
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Info(global::System.IFormatProvider formatProvider, object value)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets<object>(global::NLog.LogLevel.Info, formatProvider, value);
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00006020 File Offset: 0x00004220
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(string message, object arg1, object arg2)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, message, new object[]
				{
					arg1,
					arg2
				});
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00006044 File Offset: 0x00004244
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(string message, object arg1, object arg2, object arg3)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, message, new object[]
				{
					arg1,
					arg2,
					arg3
				});
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000606D File Offset: 0x0000426D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(global::System.IFormatProvider formatProvider, string message, bool argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00006093 File Offset: 0x00004293
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Info(string message, bool argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000060B8 File Offset: 0x000042B8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(global::System.IFormatProvider formatProvider, string message, char argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x000060DE File Offset: 0x000042DE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Info(string message, char argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00006103 File Offset: 0x00004303
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(global::System.IFormatProvider formatProvider, string message, byte argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00006129 File Offset: 0x00004329
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Info(string message, byte argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000614E File Offset: 0x0000434E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(global::System.IFormatProvider formatProvider, string message, string argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000616F File Offset: 0x0000436F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Info(string message, string argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000618F File Offset: 0x0000438F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(global::System.IFormatProvider formatProvider, string message, int argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x000061B5 File Offset: 0x000043B5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Info(string message, int argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x000061DA File Offset: 0x000043DA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(global::System.IFormatProvider formatProvider, string message, long argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00006200 File Offset: 0x00004400
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Info(string message, long argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00006225 File Offset: 0x00004425
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(global::System.IFormatProvider formatProvider, string message, float argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000624B File Offset: 0x0000444B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Info(string message, float argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00006270 File Offset: 0x00004470
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(global::System.IFormatProvider formatProvider, string message, double argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00006296 File Offset: 0x00004496
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Info(string message, double argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000062BB File Offset: 0x000044BB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(global::System.IFormatProvider formatProvider, string message, decimal argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000062E1 File Offset: 0x000044E1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Info(string message, decimal argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00006306 File Offset: 0x00004506
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(global::System.IFormatProvider formatProvider, string message, object argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00006327 File Offset: 0x00004527
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Info(string message, object argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00006347 File Offset: 0x00004547
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(global::System.IFormatProvider formatProvider, string message, sbyte argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000636D File Offset: 0x0000456D
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(string message, sbyte argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00006392 File Offset: 0x00004592
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(global::System.IFormatProvider formatProvider, string message, uint argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000063B8 File Offset: 0x000045B8
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(string message, uint argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000063DD File Offset: 0x000045DD
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(global::System.IFormatProvider formatProvider, string message, ulong argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00006403 File Offset: 0x00004603
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Info(string message, ulong argument)
		{
			if (this.IsInfoEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Info, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00006428 File Offset: 0x00004628
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Warn(object value)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets<object>(global::NLog.LogLevel.Warn, null, value);
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000643F File Offset: 0x0000463F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Warn(global::System.IFormatProvider formatProvider, object value)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets<object>(global::NLog.LogLevel.Warn, formatProvider, value);
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00006456 File Offset: 0x00004656
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(string message, object arg1, object arg2)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, message, new object[]
				{
					arg1,
					arg2
				});
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000647A File Offset: 0x0000467A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(string message, object arg1, object arg2, object arg3)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, message, new object[]
				{
					arg1,
					arg2,
					arg3
				});
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x000064A3 File Offset: 0x000046A3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(global::System.IFormatProvider formatProvider, string message, bool argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000064C9 File Offset: 0x000046C9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Warn(string message, bool argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000064EE File Offset: 0x000046EE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(global::System.IFormatProvider formatProvider, string message, char argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00006514 File Offset: 0x00004714
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Warn(string message, char argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00006539 File Offset: 0x00004739
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(global::System.IFormatProvider formatProvider, string message, byte argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000655F File Offset: 0x0000475F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Warn(string message, byte argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00006584 File Offset: 0x00004784
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(global::System.IFormatProvider formatProvider, string message, string argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x000065A5 File Offset: 0x000047A5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Warn(string message, string argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000065C5 File Offset: 0x000047C5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(global::System.IFormatProvider formatProvider, string message, int argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000065EB File Offset: 0x000047EB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Warn(string message, int argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00006610 File Offset: 0x00004810
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(global::System.IFormatProvider formatProvider, string message, long argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00006636 File Offset: 0x00004836
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Warn(string message, long argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000665B File Offset: 0x0000485B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(global::System.IFormatProvider formatProvider, string message, float argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00006681 File Offset: 0x00004881
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Warn(string message, float argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x000066A6 File Offset: 0x000048A6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(global::System.IFormatProvider formatProvider, string message, double argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000066CC File Offset: 0x000048CC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Warn(string message, double argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000066F1 File Offset: 0x000048F1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(global::System.IFormatProvider formatProvider, string message, decimal argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00006717 File Offset: 0x00004917
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Warn(string message, decimal argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000673C File Offset: 0x0000493C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(global::System.IFormatProvider formatProvider, string message, object argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000675D File Offset: 0x0000495D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Warn(string message, object argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000677D File Offset: 0x0000497D
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(global::System.IFormatProvider formatProvider, string message, sbyte argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x000067A3 File Offset: 0x000049A3
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(string message, sbyte argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000067C8 File Offset: 0x000049C8
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(global::System.IFormatProvider formatProvider, string message, uint argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x000067EE File Offset: 0x000049EE
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(string message, uint argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00006813 File Offset: 0x00004A13
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(global::System.IFormatProvider formatProvider, string message, ulong argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00006839 File Offset: 0x00004A39
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Warn(string message, ulong argument)
		{
			if (this.IsWarnEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Warn, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000685E File Offset: 0x00004A5E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Error(object value)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets<object>(global::NLog.LogLevel.Error, null, value);
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00006875 File Offset: 0x00004A75
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Error(global::System.IFormatProvider formatProvider, object value)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets<object>(global::NLog.LogLevel.Error, formatProvider, value);
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000688C File Offset: 0x00004A8C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(string message, object arg1, object arg2)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, message, new object[]
				{
					arg1,
					arg2
				});
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x000068B0 File Offset: 0x00004AB0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(string message, object arg1, object arg2, object arg3)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, message, new object[]
				{
					arg1,
					arg2,
					arg3
				});
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x000068D9 File Offset: 0x00004AD9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(global::System.IFormatProvider formatProvider, string message, bool argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x000068FF File Offset: 0x00004AFF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Error(string message, bool argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00006924 File Offset: 0x00004B24
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(global::System.IFormatProvider formatProvider, string message, char argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000694A File Offset: 0x00004B4A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Error(string message, char argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000696F File Offset: 0x00004B6F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(global::System.IFormatProvider formatProvider, string message, byte argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00006995 File Offset: 0x00004B95
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Error(string message, byte argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000366 RID: 870 RVA: 0x000069BA File Offset: 0x00004BBA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(global::System.IFormatProvider formatProvider, string message, string argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000069DB File Offset: 0x00004BDB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Error(string message, string argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x000069FB File Offset: 0x00004BFB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(global::System.IFormatProvider formatProvider, string message, int argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00006A21 File Offset: 0x00004C21
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Error(string message, int argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00006A46 File Offset: 0x00004C46
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(global::System.IFormatProvider formatProvider, string message, long argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00006A6C File Offset: 0x00004C6C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Error(string message, long argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00006A91 File Offset: 0x00004C91
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(global::System.IFormatProvider formatProvider, string message, float argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00006AB7 File Offset: 0x00004CB7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Error(string message, float argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00006ADC File Offset: 0x00004CDC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(global::System.IFormatProvider formatProvider, string message, double argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00006B02 File Offset: 0x00004D02
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Error(string message, double argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00006B27 File Offset: 0x00004D27
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(global::System.IFormatProvider formatProvider, string message, decimal argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00006B4D File Offset: 0x00004D4D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Error(string message, decimal argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00006B72 File Offset: 0x00004D72
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(global::System.IFormatProvider formatProvider, string message, object argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00006B93 File Offset: 0x00004D93
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Error(string message, object argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00006BB3 File Offset: 0x00004DB3
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(global::System.IFormatProvider formatProvider, string message, sbyte argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00006BD9 File Offset: 0x00004DD9
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(string message, sbyte argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00006BFE File Offset: 0x00004DFE
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(global::System.IFormatProvider formatProvider, string message, uint argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00006C24 File Offset: 0x00004E24
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(string message, uint argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00006C49 File Offset: 0x00004E49
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(global::System.IFormatProvider formatProvider, string message, ulong argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00006C6F File Offset: 0x00004E6F
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Error(string message, ulong argument)
		{
			if (this.IsErrorEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Error, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00006C94 File Offset: 0x00004E94
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Fatal(object value)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets<object>(global::NLog.LogLevel.Fatal, null, value);
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00006CAB File Offset: 0x00004EAB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Fatal(global::System.IFormatProvider formatProvider, object value)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets<object>(global::NLog.LogLevel.Fatal, formatProvider, value);
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00006CC2 File Offset: 0x00004EC2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(string message, object arg1, object arg2)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, message, new object[]
				{
					arg1,
					arg2
				});
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00006CE6 File Offset: 0x00004EE6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(string message, object arg1, object arg2, object arg3)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, message, new object[]
				{
					arg1,
					arg2,
					arg3
				});
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00006D0F File Offset: 0x00004F0F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(global::System.IFormatProvider formatProvider, string message, bool argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00006D35 File Offset: 0x00004F35
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Fatal(string message, bool argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00006D5A File Offset: 0x00004F5A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(global::System.IFormatProvider formatProvider, string message, char argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00006D80 File Offset: 0x00004F80
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Fatal(string message, char argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00006DA5 File Offset: 0x00004FA5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(global::System.IFormatProvider formatProvider, string message, byte argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00006DCB File Offset: 0x00004FCB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Fatal(string message, byte argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00006DF0 File Offset: 0x00004FF0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(global::System.IFormatProvider formatProvider, string message, string argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00006E11 File Offset: 0x00005011
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Fatal(string message, string argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00006E31 File Offset: 0x00005031
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(global::System.IFormatProvider formatProvider, string message, int argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00006E57 File Offset: 0x00005057
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Fatal(string message, int argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00006E7C File Offset: 0x0000507C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(global::System.IFormatProvider formatProvider, string message, long argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00006EA2 File Offset: 0x000050A2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Fatal(string message, long argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00006EC7 File Offset: 0x000050C7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(global::System.IFormatProvider formatProvider, string message, float argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00006EED File Offset: 0x000050ED
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Fatal(string message, float argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00006F12 File Offset: 0x00005112
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(global::System.IFormatProvider formatProvider, string message, double argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00006F38 File Offset: 0x00005138
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Fatal(string message, double argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00006F5D File Offset: 0x0000515D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(global::System.IFormatProvider formatProvider, string message, decimal argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00006F83 File Offset: 0x00005183
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Fatal(string message, decimal argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00006FA8 File Offset: 0x000051A8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(global::System.IFormatProvider formatProvider, string message, object argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00006FC9 File Offset: 0x000051C9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Fatal(string message, object argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00006FE9 File Offset: 0x000051E9
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(global::System.IFormatProvider formatProvider, string message, sbyte argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000700F File Offset: 0x0000520F
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(string message, sbyte argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00007034 File Offset: 0x00005234
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(global::System.IFormatProvider formatProvider, string message, uint argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000705A File Offset: 0x0000525A
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(string message, uint argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000707F File Offset: 0x0000527F
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(global::System.IFormatProvider formatProvider, string message, ulong argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000070A5 File Offset: 0x000052A5
		[global::System.CLSCompliant(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Fatal(string message, ulong argument)
		{
			if (this.IsFatalEnabled)
			{
				this.WriteToTargets(global::NLog.LogLevel.Fatal, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000070CA File Offset: 0x000052CA
		protected internal Logger()
		{
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000399 RID: 921 RVA: 0x000070E4 File Offset: 0x000052E4
		// (remove) Token: 0x0600039A RID: 922 RVA: 0x0000711C File Offset: 0x0000531C
		public event global::System.EventHandler<global::System.EventArgs> LoggerReconfigured;

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00007151 File Offset: 0x00005351
		// (set) Token: 0x0600039C RID: 924 RVA: 0x00007159 File Offset: 0x00005359
		public string Name { get; private set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00007162 File Offset: 0x00005362
		// (set) Token: 0x0600039E RID: 926 RVA: 0x0000716A File Offset: 0x0000536A
		public global::NLog.LogFactory Factory { get; private set; }

		// Token: 0x0600039F RID: 927 RVA: 0x00007173 File Offset: 0x00005373
		public bool IsEnabled(global::NLog.LogLevel level)
		{
			if (level == null)
			{
				throw new global::System.InvalidOperationException("Log level must be defined");
			}
			return this.GetTargetsForLevel(level) != null;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00007193 File Offset: 0x00005393
		public void Log(global::NLog.LogEventInfo logEvent)
		{
			if (this.IsEnabled(logEvent.Level))
			{
				this.WriteToTargets(logEvent);
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x000071AA File Offset: 0x000053AA
		public void Log(global::System.Type wrapperType, global::NLog.LogEventInfo logEvent)
		{
			if (this.IsEnabled(logEvent.Level))
			{
				this.WriteToTargets(wrapperType, logEvent);
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000071C2 File Offset: 0x000053C2
		public void Log<T>(global::NLog.LogLevel level, T value)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets<T>(level, null, value);
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x000071D6 File Offset: 0x000053D6
		public void Log<T>(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, T value)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets<T>(level, formatProvider, value);
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x000071EA File Offset: 0x000053EA
		public void Log(global::NLog.LogLevel level, global::NLog.LogMessageGenerator messageFunc)
		{
			if (this.IsEnabled(level))
			{
				if (messageFunc == null)
				{
					throw new global::System.ArgumentNullException("messageFunc");
				}
				this.WriteToTargets(level, null, messageFunc());
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00007211 File Offset: 0x00005411
		[global::System.Obsolete("Use Log(LogLevel, String, Exception) method instead. Marked obsolete before v4.3.11")]
		public void LogException(global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception)
		{
			this.Log(level, message, exception);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000721C File Offset: 0x0000541C
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, formatProvider, message, args);
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00007232 File Offset: 0x00005432
		public void Log(global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] string message)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, null, message);
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00007246 File Offset: 0x00005446
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, message, args);
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000725A File Offset: 0x0000545A
		[global::System.Obsolete("Use Log(LogLevel level, Exception exception, [Localizable(false)] string message, params object[] args) instead. Marked obsolete before v4.3.11")]
		public void Log(global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, exception, message, null);
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000726F File Offset: 0x0000546F
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, exception, message, args);
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00007285 File Offset: 0x00005485
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log(global::NLog.LogLevel level, global::System.Exception exception, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, exception, formatProvider, message, args);
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000729D File Offset: 0x0000549D
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log<TArgument>(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, formatProvider, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000072C1 File Offset: 0x000054C1
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log<TArgument>(global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] string message, TArgument argument)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, message, new object[]
				{
					argument
				});
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x000072E3 File Offset: 0x000054E3
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log<TArgument1, TArgument2>(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, formatProvider, message, new object[]
				{
					argument1,
					argument2
				});
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00007311 File Offset: 0x00005511
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log<TArgument1, TArgument2>(global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, message, new object[]
				{
					argument1,
					argument2
				});
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000733D File Offset: 0x0000553D
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log<TArgument1, TArgument2, TArgument3>(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, formatProvider, message, new object[]
				{
					argument1,
					argument2,
					argument3
				});
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00007375 File Offset: 0x00005575
		[global::NLog.MessageTemplateFormatMethod("message")]
		public void Log<TArgument1, TArgument2, TArgument3>(global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			if (this.IsEnabled(level))
			{
				this.WriteToTargets(level, message, new object[]
				{
					argument1,
					argument2,
					argument3
				});
			}
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x000073AC File Offset: 0x000055AC
		private void WriteToTargets(global::NLog.LogLevel level, global::System.Exception ex, [global::System.ComponentModel.Localizable(false)] string message, object[] args)
		{
			global::NLog.LoggerImpl.Write(this._loggerType, this.GetTargetsForLevel(level), this.PrepareLogEventInfo(global::NLog.LogEventInfo.Create(level, this.Name, ex, this.Factory.DefaultCultureInfo, message, args)), this.Factory);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x000073F4 File Offset: 0x000055F4
		private void WriteToTargets(global::NLog.LogLevel level, global::System.Exception ex, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, object[] args)
		{
			global::NLog.LoggerImpl.Write(this._loggerType, this.GetTargetsForLevel(level), this.PrepareLogEventInfo(global::NLog.LogEventInfo.Create(level, this.Name, ex, formatProvider, message, args)), this.Factory);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00007431 File Offset: 0x00005631
		private global::NLog.LogEventInfo PrepareLogEventInfo(global::NLog.LogEventInfo logEvent)
		{
			if (logEvent.FormatProvider == null)
			{
				logEvent.FormatProvider = this.Factory.DefaultCultureInfo;
			}
			return logEvent;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00007450 File Offset: 0x00005650
		public void Swallow(global::System.Action action)
		{
			try
			{
				action();
			}
			catch (global::System.Exception value)
			{
				this.Error<global::System.Exception>(value);
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00007480 File Offset: 0x00005680
		public T Swallow<T>(global::System.Func<T> func)
		{
			return this.Swallow<T>(func, default(T));
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x000074A0 File Offset: 0x000056A0
		public T Swallow<T>(global::System.Func<T> func, T fallback)
		{
			T result;
			try
			{
				result = func();
			}
			catch (global::System.Exception value)
			{
				this.Error<global::System.Exception>(value);
				result = fallback;
			}
			return result;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x000074D4 File Offset: 0x000056D4
		public async void Swallow(global::System.Threading.Tasks.Task task)
		{
			try
			{
				await task;
			}
			catch (global::System.Exception value)
			{
				this.Error<global::System.Exception>(value);
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00007518 File Offset: 0x00005718
		public async global::System.Threading.Tasks.Task SwallowAsync(global::System.Threading.Tasks.Task task)
		{
			try
			{
				await task;
			}
			catch (global::System.Exception value)
			{
				this.Error<global::System.Exception>(value);
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00007568 File Offset: 0x00005768
		public async global::System.Threading.Tasks.Task SwallowAsync(global::System.Func<global::System.Threading.Tasks.Task> asyncAction)
		{
			try
			{
				await asyncAction();
			}
			catch (global::System.Exception value)
			{
				this.Error<global::System.Exception>(value);
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000075B8 File Offset: 0x000057B8
		public async global::System.Threading.Tasks.Task<TResult> SwallowAsync<TResult>(global::System.Func<global::System.Threading.Tasks.Task<TResult>> asyncFunc)
		{
			return await this.SwallowAsync<TResult>(asyncFunc, default(TResult));
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00007608 File Offset: 0x00005808
		public async global::System.Threading.Tasks.Task<TResult> SwallowAsync<TResult>(global::System.Func<global::System.Threading.Tasks.Task<TResult>> asyncFunc, TResult fallback)
		{
			TResult result;
			try
			{
				result = await asyncFunc();
			}
			catch (global::System.Exception value)
			{
				this.Error<global::System.Exception>(value);
				result = fallback;
			}
			return result;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000765D File Offset: 0x0000585D
		internal void Initialize(string name, global::NLog.Internal.LoggerConfiguration loggerConfiguration, global::NLog.LogFactory factory)
		{
			this.Name = name;
			this.Factory = factory;
			this.SetConfiguration(loggerConfiguration);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00007674 File Offset: 0x00005874
		internal void WriteToTargets(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, object[] args)
		{
			global::NLog.LoggerImpl.Write(this._loggerType, this.GetTargetsForLevel(level), this.PrepareLogEventInfo(global::NLog.LogEventInfo.Create(level, this.Name, formatProvider, message, args)), this.Factory);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x000076A4 File Offset: 0x000058A4
		private void WriteToTargets(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message)
		{
			global::NLog.LogEventInfo logEvent = global::NLog.LogEventInfo.Create(level, this.Name, formatProvider, message, null);
			global::NLog.LoggerImpl.Write(this._loggerType, this.GetTargetsForLevel(level), this.PrepareLogEventInfo(logEvent), this.Factory);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000076E0 File Offset: 0x000058E0
		private void WriteToTargets<T>(global::NLog.LogLevel level, global::System.IFormatProvider formatProvider, T value)
		{
			global::NLog.LogEventInfo logEvent = this.PrepareLogEventInfo(global::NLog.LogEventInfo.Create(level, this.Name, formatProvider, value));
			global::NLog.LoggerImpl.Write(this._loggerType, this.GetTargetsForLevel(level), logEvent, this.Factory);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00007720 File Offset: 0x00005920
		internal void WriteToTargets(global::NLog.LogLevel level, [global::System.ComponentModel.Localizable(false)] string message, object[] args)
		{
			this.WriteToTargets(level, this.Factory.DefaultCultureInfo, message, args);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00007736 File Offset: 0x00005936
		private void WriteToTargets(global::NLog.LogEventInfo logEvent)
		{
			global::NLog.LoggerImpl.Write(this._loggerType, this.GetTargetsForLevel(logEvent.Level), this.PrepareLogEventInfo(logEvent), this.Factory);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000775C File Offset: 0x0000595C
		private void WriteToTargets(global::System.Type wrapperType, global::NLog.LogEventInfo logEvent)
		{
			global::NLog.LoggerImpl.Write(wrapperType ?? this._loggerType, this.GetTargetsForLevel(logEvent.Level), this.PrepareLogEventInfo(logEvent), this.Factory);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00007788 File Offset: 0x00005988
		internal void SetConfiguration(global::NLog.Internal.LoggerConfiguration newConfiguration)
		{
			this._configuration = newConfiguration;
			this._isTraceEnabled = newConfiguration.IsEnabled(global::NLog.LogLevel.Trace);
			this._isDebugEnabled = newConfiguration.IsEnabled(global::NLog.LogLevel.Debug);
			this._isInfoEnabled = newConfiguration.IsEnabled(global::NLog.LogLevel.Info);
			this._isWarnEnabled = newConfiguration.IsEnabled(global::NLog.LogLevel.Warn);
			this._isErrorEnabled = newConfiguration.IsEnabled(global::NLog.LogLevel.Error);
			this._isFatalEnabled = newConfiguration.IsEnabled(global::NLog.LogLevel.Fatal);
			this.OnLoggerReconfigured(global::System.EventArgs.Empty);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000781B File Offset: 0x00005A1B
		private global::NLog.Internal.TargetWithFilterChain GetTargetsForLevel(global::NLog.LogLevel level)
		{
			return this._configuration.GetTargetsForLevel(level);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000782C File Offset: 0x00005A2C
		protected virtual void OnLoggerReconfigured(global::System.EventArgs e)
		{
			global::System.EventHandler<global::System.EventArgs> loggerReconfigured = this.LoggerReconfigured;
			if (loggerReconfigured != null)
			{
				loggerReconfigured(this, e);
			}
		}

		// Token: 0x04000026 RID: 38
		private readonly global::System.Type _loggerType = typeof(global::NLog.Logger);

		// Token: 0x04000027 RID: 39
		private volatile global::NLog.Internal.LoggerConfiguration _configuration;

		// Token: 0x04000028 RID: 40
		private volatile bool _isTraceEnabled;

		// Token: 0x04000029 RID: 41
		private volatile bool _isDebugEnabled;

		// Token: 0x0400002A RID: 42
		private volatile bool _isInfoEnabled;

		// Token: 0x0400002B RID: 43
		private volatile bool _isWarnEnabled;

		// Token: 0x0400002C RID: 44
		private volatile bool _isErrorEnabled;

		// Token: 0x0400002D RID: 45
		private volatile bool _isFatalEnabled;
	}
}
