using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Threading;

namespace Infragistics.Windows.Internal
{
	// Token: 0x02000068 RID: 104
	public class PropertyValueTracker : global::System.Windows.DependencyObject, global::Infragistics.Windows.Internal.ThrottleTimer.IAction
	{
		// Token: 0x06000416 RID: 1046 RVA: 0x00011819 File Offset: 0x0000FA19
		public PropertyValueTracker(object source, string propertyPath, global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler handler) : this(source, propertyPath, handler, false)
		{
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00011828 File Offset: 0x0000FA28
		public PropertyValueTracker(object source, string propertyPath, global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler handler, bool callAsynchronously)
		{
			this._asynchronousDispatcherPriority = global::System.Windows.Threading.DispatcherPriority.Render;
			base..ctor();
			global::System.Windows.Data.Binding binding = global::Infragistics.Windows.Utilities.CreateBindingObject(propertyPath, global::System.Windows.Data.BindingMode.OneWay, source);
			this.Initialize(binding, handler, callAsynchronously);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00011855 File Offset: 0x0000FA55
		public PropertyValueTracker(object source, global::System.Windows.DependencyProperty dependencyProperty, global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler handler) : this(source, dependencyProperty, handler, false)
		{
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00011864 File Offset: 0x0000FA64
		public PropertyValueTracker(object source, global::System.Windows.DependencyProperty dependencyProperty, global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler handler, bool callAsynchronously)
		{
			this._asynchronousDispatcherPriority = global::System.Windows.Threading.DispatcherPriority.Render;
			base..ctor();
			global::System.Windows.Data.Binding binding = global::Infragistics.Windows.Utilities.CreateBindingObject(dependencyProperty, global::System.Windows.Data.BindingMode.OneWay, source);
			this.Initialize(binding, handler, callAsynchronously);
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00011891 File Offset: 0x0000FA91
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00011899 File Offset: 0x0000FA99
		public global::System.Windows.Threading.DispatcherPriority AsynchronousDispatcherPriority
		{
			get
			{
				return this._asynchronousDispatcherPriority;
			}
			set
			{
				this._asynchronousDispatcherPriority = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x000118A2 File Offset: 0x0000FAA2
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x000118AA File Offset: 0x0000FAAA
		public bool CallAsynchronously
		{
			get
			{
				return this._callAsynchronously;
			}
			set
			{
				this._callAsynchronously = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x000118B3 File Offset: 0x0000FAB3
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x000118BB File Offset: 0x0000FABB
		public object Tag
		{
			get
			{
				return this._tag;
			}
			set
			{
				this._tag = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x000118C4 File Offset: 0x0000FAC4
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x000118CC File Offset: 0x0000FACC
		public int ThrottleTime
		{
			get
			{
				return this._throttleTime;
			}
			set
			{
				if (this._throttleTime != value)
				{
					if (value < 0)
					{
						throw new global::System.ArgumentOutOfRangeException("Throttle time can't be less than 0.");
					}
					this._throttleTime = value;
				}
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x000118ED File Offset: 0x0000FAED
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x000118F5 File Offset: 0x0000FAF5
		public bool ThrottleFirstInvoke
		{
			get
			{
				return this._throttleFirstInvoke;
			}
			set
			{
				this._throttleFirstInvoke = value;
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00011900 File Offset: 0x0000FB00
		private static void OnTargetChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Internal.PropertyValueTracker propertyValueTracker = (global::Infragistics.Windows.Internal.PropertyValueTracker)dependencyObject;
			propertyValueTracker.ProcessTargetChanged();
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x0001191A File Offset: 0x0000FB1A
		internal object Target
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Internal.PropertyValueTracker.TargetProperty);
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00011927 File Offset: 0x0000FB27
		private void Initialize(global::System.Windows.Data.Binding binding, global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler handler, bool callAsynchronously)
		{
			global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Windows.Internal.PropertyValueTracker.TargetProperty, binding);
			this._handler = handler;
			this._callAsynchronously = callAsynchronously;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00011944 File Offset: 0x0000FB44
		private void DelayedInvokeHanlder()
		{
			this._hasPendingAsynchronousCallback = false;
			this.InvokeHandler();
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00011953 File Offset: 0x0000FB53
		private void InvokeHandler()
		{
			if (this._handler != null)
			{
				this._handler();
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00011968 File Offset: 0x0000FB68
		private void ProcessTargetChanged()
		{
			if (this._handler != null)
			{
				if (this._throttleTime > 0)
				{
					if (!this._hasPendingAsynchronousCallback)
					{
						if (this._cachedThrottleTimer == null)
						{
							this._cachedThrottleTimer = global::Infragistics.Windows.Internal.ThrottleTimer.GetInstance((long)this._throttleTime);
						}
						this._hasPendingAsynchronousCallback = true;
						this._cachedThrottleTimer.DoThrottledInvoke(this, this.ThrottleFirstInvoke);
						return;
					}
				}
				else if (this._callAsynchronously)
				{
					if (!this._hasPendingAsynchronousCallback)
					{
						global::System.Windows.Threading.Dispatcher dispatcher = base.Dispatcher;
						if (dispatcher != null)
						{
							dispatcher.BeginInvoke(this.AsynchronousDispatcherPriority, new global::Infragistics.Windows.Internal.PropertyValueTracker.MethodInvoker(this.DelayedInvokeHanlder));
							this._hasPendingAsynchronousCallback = true;
							return;
						}
						this.InvokeHandler();
						return;
					}
				}
				else
				{
					this.InvokeHandler();
				}
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00011A0D File Offset: 0x0000FC0D
		public void Deactivate()
		{
			this._handler = null;
			base.ClearValue(global::Infragistics.Windows.Internal.PropertyValueTracker.TargetProperty);
			if (this._cachedThrottleTimer != null)
			{
				this._cachedThrottleTimer.Unregister(this);
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00011A35 File Offset: 0x0000FC35
		void global::Infragistics.Windows.Internal.ThrottleTimer.IAction.Perform()
		{
			this._hasPendingAsynchronousCallback = false;
			this.InvokeHandler();
		}

		// Token: 0x04000167 RID: 359
		private global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler _handler;

		// Token: 0x04000168 RID: 360
		private bool _callAsynchronously;

		// Token: 0x04000169 RID: 361
		private bool _hasPendingAsynchronousCallback;

		// Token: 0x0400016A RID: 362
		private object _tag;

		// Token: 0x0400016B RID: 363
		private global::System.Windows.Threading.DispatcherPriority _asynchronousDispatcherPriority;

		// Token: 0x0400016C RID: 364
		private int _throttleTime;

		// Token: 0x0400016D RID: 365
		private global::Infragistics.Windows.Internal.ThrottleTimer _cachedThrottleTimer;

		// Token: 0x0400016E RID: 366
		private bool _throttleFirstInvoke;

		// Token: 0x0400016F RID: 367
		internal static readonly global::System.Windows.DependencyProperty TargetProperty = global::Infragistics.DependencyPropertyUtilities.Register("Target", typeof(object), typeof(global::Infragistics.Windows.Internal.PropertyValueTracker), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Internal.PropertyValueTracker.OnTargetChanged));

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x0600042E RID: 1070
		public delegate void PropertyValueChangedHandler();

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x06000432 RID: 1074
		internal delegate void MethodInvoker();
	}
}
