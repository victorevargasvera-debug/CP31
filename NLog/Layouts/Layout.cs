using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using NLog.Common;
using NLog.Config;
using NLog.Internal;

namespace NLog.Layouts
{
	// Token: 0x0200009F RID: 159
	[global::NLog.Config.NLogConfigurationItem]
	public abstract class Layout : global::NLog.Internal.ISupportsInitialize, global::NLog.Internal.IRenderable
	{
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x0001926F File Offset: 0x0001746F
		// (set) Token: 0x060009DD RID: 2525 RVA: 0x00019277 File Offset: 0x00017477
		internal bool ThreadAgnostic { get; set; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x00019280 File Offset: 0x00017480
		// (set) Token: 0x060009DF RID: 2527 RVA: 0x00019288 File Offset: 0x00017488
		internal bool ThreadSafe { get; set; }

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x00019291 File Offset: 0x00017491
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x00019299 File Offset: 0x00017499
		internal bool MutableUnsafe { get; set; }

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x000192A2 File Offset: 0x000174A2
		// (set) Token: 0x060009E3 RID: 2531 RVA: 0x000192AA File Offset: 0x000174AA
		internal global::NLog.Config.StackTraceUsage StackTraceUsage { get; private set; }

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x000192B3 File Offset: 0x000174B3
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x000192BB File Offset: 0x000174BB
		private protected global::NLog.Config.LoggingConfiguration LoggingConfiguration { protected get; private set; }

		// Token: 0x060009E6 RID: 2534 RVA: 0x000192C4 File Offset: 0x000174C4
		public static implicit operator global::NLog.Layouts.Layout([global::System.ComponentModel.Localizable(false)] string text)
		{
			return global::NLog.Layouts.Layout.FromString(text);
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x000192CC File Offset: 0x000174CC
		public static global::NLog.Layouts.Layout FromString(string layoutText)
		{
			return global::NLog.Layouts.Layout.FromString(layoutText, global::NLog.Config.ConfigurationItemFactory.Default);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x000192D9 File Offset: 0x000174D9
		public static global::NLog.Layouts.Layout FromString(string layoutText, global::NLog.Config.ConfigurationItemFactory configurationItemFactory)
		{
			return new global::NLog.Layouts.SimpleLayout(layoutText, configurationItemFactory);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x000192E2 File Offset: 0x000174E2
		public virtual void Precalculate(global::NLog.LogEventInfo logEvent)
		{
			if (!this.ThreadAgnostic || this.MutableUnsafe)
			{
				this.Render(logEvent);
			}
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x000192FC File Offset: 0x000174FC
		public string Render(global::NLog.LogEventInfo logEvent)
		{
			if (!this._isInitialized)
			{
				this.Initialize(this.LoggingConfiguration);
			}
			object obj;
			if ((!this.ThreadAgnostic || this.MutableUnsafe) && logEvent.TryGetCachedLayoutValue(this, out obj))
			{
				return ((obj != null) ? obj.ToString() : null) ?? string.Empty;
			}
			string text = this.GetFormattedMessage(logEvent) ?? string.Empty;
			if (!this.ThreadAgnostic || this.MutableUnsafe)
			{
				logEvent.AddCachedLayoutValue(this, text);
			}
			return text;
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00019378 File Offset: 0x00017578
		internal virtual void PrecalculateBuilder(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
		{
			this.Precalculate(logEvent);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00019384 File Offset: 0x00017584
		internal void RenderAppendBuilder(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target, bool cacheLayoutResult = false)
		{
			if (!this._isInitialized)
			{
				this.Initialize(this.LoggingConfiguration);
			}
			object obj;
			if ((!this.ThreadAgnostic || this.MutableUnsafe) && logEvent.TryGetCachedLayoutValue(this, out obj))
			{
				target.Append(((obj != null) ? obj.ToString() : null) ?? string.Empty);
				return;
			}
			cacheLayoutResult = (cacheLayoutResult && !this.ThreadAgnostic);
			using (global::NLog.Internal.AppendBuilderCreator appendBuilderCreator = new global::NLog.Internal.AppendBuilderCreator(target, cacheLayoutResult))
			{
				this.RenderFormattedMessage(logEvent, appendBuilderCreator.Builder);
				if (cacheLayoutResult)
				{
					logEvent.AddCachedLayoutValue(this, appendBuilderCreator.Builder.ToString());
				}
			}
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0001943C File Offset: 0x0001763C
		internal string RenderAllocateBuilder(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder reusableBuilder = null)
		{
			int num = this._maxRenderedLength;
			if (num > 16384)
			{
				num = 16384;
			}
			global::System.Text.StringBuilder stringBuilder = reusableBuilder ?? new global::System.Text.StringBuilder(num);
			this.RenderFormattedMessage(logEvent, stringBuilder);
			if (stringBuilder.Length > this._maxRenderedLength)
			{
				this._maxRenderedLength = stringBuilder.Length;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00019492 File Offset: 0x00017692
		protected virtual void RenderFormattedMessage(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
		{
			target.Append(this.GetFormattedMessage(logEvent) ?? string.Empty);
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x000194AB File Offset: 0x000176AB
		void global::NLog.Internal.ISupportsInitialize.Initialize(global::NLog.Config.LoggingConfiguration configuration)
		{
			this.Initialize(configuration);
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x000194B4 File Offset: 0x000176B4
		void global::NLog.Internal.ISupportsInitialize.Close()
		{
			this.Close();
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x000194BC File Offset: 0x000176BC
		internal void Initialize(global::NLog.Config.LoggingConfiguration configuration)
		{
			if (!this._isInitialized)
			{
				this.LoggingConfiguration = configuration;
				this._isInitialized = true;
				this._scannedForObjects = false;
				this.InitializeLayout();
				if (!this._scannedForObjects)
				{
					global::NLog.Common.InternalLogger.Debug("Initialized Layout done but not scanned for objects");
					this.PerformObjectScanning();
				}
			}
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x000194FC File Offset: 0x000176FC
		internal void PerformObjectScanning()
		{
			global::System.Collections.Generic.List<object> source = global::NLog.Internal.ObjectGraphScanner.FindReachableObjects<object>(true, new object[]
			{
				this
			});
			this.ThreadAgnostic = source.All((object item) => item.GetType().IsDefined(typeof(global::NLog.Config.ThreadAgnosticAttribute), true));
			this.ThreadSafe = source.All((object item) => item.GetType().IsDefined(typeof(global::NLog.Config.ThreadSafeAttribute), true));
			this.MutableUnsafe = source.Any((object item) => item.GetType().IsDefined(typeof(global::NLog.Config.MutableUnsafeAttribute), true));
			this.StackTraceUsage = global::NLog.Config.StackTraceUsage.None;
			this.StackTraceUsage = source.OfType<global::NLog.Internal.IUsesStackTrace>().DefaultIfEmpty<global::NLog.Internal.IUsesStackTrace>().Max(delegate(global::NLog.Internal.IUsesStackTrace item)
			{
				if (item == null)
				{
					return global::NLog.Config.StackTraceUsage.None;
				}
				return item.StackTraceUsage;
			});
			this._scannedForObjects = true;
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x000195DE File Offset: 0x000177DE
		internal void Close()
		{
			if (this._isInitialized)
			{
				this.LoggingConfiguration = null;
				this._isInitialized = false;
				this.CloseLayout();
			}
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x000195FC File Offset: 0x000177FC
		protected virtual void InitializeLayout()
		{
			this.PerformObjectScanning();
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00019604 File Offset: 0x00017804
		protected virtual void CloseLayout()
		{
		}

		// Token: 0x060009F6 RID: 2550
		protected abstract string GetFormattedMessage(global::NLog.LogEventInfo logEvent);

		// Token: 0x060009F7 RID: 2551 RVA: 0x00019608 File Offset: 0x00017808
		public static void Register<T>(string name) where T : global::NLog.Layouts.Layout
		{
			global::System.Type typeFromHandle = typeof(T);
			global::NLog.Layouts.Layout.Register(name, typeFromHandle);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00019627 File Offset: 0x00017827
		public static void Register(string name, global::System.Type layoutType)
		{
			global::NLog.Config.ConfigurationItemFactory.Default.Layouts.RegisterDefinition(name, layoutType);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0001963A File Offset: 0x0001783A
		internal void PrecalculateBuilderInternal(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
		{
			if (!this.ThreadAgnostic || this.MutableUnsafe)
			{
				this.RenderAppendBuilder(logEvent, target, true);
			}
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00019658 File Offset: 0x00017858
		internal string ToStringWithNestedItems<T>(global::System.Collections.Generic.IList<T> nestedItems, global::System.Func<T, string> nextItemToString)
		{
			if (nestedItems != null && nestedItems.Count > 0)
			{
				string[] value = (from c in nestedItems
				select nextItemToString(c)).ToArray<string>();
				return base.GetType().Name + "=" + string.Join("|", value);
			}
			return base.ToString();
		}

		// Token: 0x0400025D RID: 605
		private bool _isInitialized;

		// Token: 0x0400025E RID: 606
		private bool _scannedForObjects;

		// Token: 0x04000263 RID: 611
		private const int MaxInitialRenderBufferLength = 16384;

		// Token: 0x04000264 RID: 612
		private int _maxRenderedLength;
	}
}
