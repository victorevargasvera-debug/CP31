using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Threading;

namespace Infragistics.Windows.Internal
{
	// Token: 0x0200007F RID: 127
	public class PropertyValueTracker : global::System.Windows.DependencyObject, global::Infragistics.Windows.Internal.ThrottleTimer.IAction
	{
		// Token: 0x060004D7 RID: 1239 RVA: 0x00014032 File Offset: 0x00012232
		public PropertyValueTracker(object source, string propertyPath, global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler handler) : this(source, propertyPath, handler, false)
		{
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00014040 File Offset: 0x00012240
		public PropertyValueTracker(object source, string propertyPath, global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler handler, bool callAsynchronously)
		{
			this._asynchronousDispatcherPriority = global::System.Windows.Threading.DispatcherPriority.Render;
			base..ctor();
			global::System.Windows.Data.Binding binding = global::Infragistics.Windows.Utilities.CreateBindingObject(propertyPath, global::System.Windows.Data.BindingMode.OneWay, source);
			this.Initialize(binding, handler, callAsynchronously);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0001406D File Offset: 0x0001226D
		public PropertyValueTracker(object source, global::System.Windows.DependencyProperty dependencyProperty, global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler handler) : this(source, dependencyProperty, handler, false)
		{
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0001407C File Offset: 0x0001227C
		public PropertyValueTracker(object source, global::System.Windows.DependencyProperty dependencyProperty, global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler handler, bool callAsynchronously)
		{
			this._asynchronousDispatcherPriority = global::System.Windows.Threading.DispatcherPriority.Render;
			base..ctor();
			global::System.Windows.Data.Binding binding = global::Infragistics.Windows.Utilities.CreateBindingObject(dependencyProperty, global::System.Windows.Data.BindingMode.OneWay, source);
			this.Initialize(binding, handler, callAsynchronously);
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x000140A9 File Offset: 0x000122A9
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x000140B1 File Offset: 0x000122B1
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

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x000140BA File Offset: 0x000122BA
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x000140C2 File Offset: 0x000122C2
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

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x000140CB File Offset: 0x000122CB
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x000140D3 File Offset: 0x000122D3
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

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x000140DC File Offset: 0x000122DC
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x000140E4 File Offset: 0x000122E4
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

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00014105 File Offset: 0x00012305
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x0001410D File Offset: 0x0001230D
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

		// Token: 0x060004E5 RID: 1253 RVA: 0x00014118 File Offset: 0x00012318
		private static void OnTargetChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Internal.PropertyValueTracker propertyValueTracker = (global::Infragistics.Windows.Internal.PropertyValueTracker)dependencyObject;
			propertyValueTracker.ProcessTargetChanged();
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00014132 File Offset: 0x00012332
		internal object Target
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Internal.PropertyValueTracker.TargetProperty);
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0001413F File Offset: 0x0001233F
		private void Initialize(global::System.Windows.Data.Binding binding, global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler handler, bool callAsynchronously)
		{
			global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Windows.Internal.PropertyValueTracker.TargetProperty, binding);
			this._handler = handler;
			this._callAsynchronously = callAsynchronously;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0001415C File Offset: 0x0001235C
		private void DelayedInvokeHanlder()
		{
			this._hasPendingAsynchronousCallback = false;
			this.InvokeHandler();
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0001416B File Offset: 0x0001236B
		private void InvokeHandler()
		{
			if (this._handler != null)
			{
				this._handler();
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00014180 File Offset: 0x00012380
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

		// Token: 0x060004EB RID: 1259 RVA: 0x00014225 File Offset: 0x00012425
		public void Deactivate()
		{
			this._handler = null;
			base.ClearValue(global::Infragistics.Windows.Internal.PropertyValueTracker.TargetProperty);
			if (this._cachedThrottleTimer != null)
			{
				this._cachedThrottleTimer.Unregister(this);
			}
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0001424D File Offset: 0x0001244D
		void global::Infragistics.Windows.Internal.ThrottleTimer.IAction.Perform()
		{
			this._hasPendingAsynchronousCallback = false;
			this.InvokeHandler();
		}

		// Token: 0x040001D8 RID: 472
		private global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler _handler;

		// Token: 0x040001D9 RID: 473
		private bool _callAsynchronously;

		// Token: 0x040001DA RID: 474
		private bool _hasPendingAsynchronousCallback;

		// Token: 0x040001DB RID: 475
		private object _tag;

		// Token: 0x040001DC RID: 476
		private global::System.Windows.Threading.DispatcherPriority _asynchronousDispatcherPriority;

		// Token: 0x040001DD RID: 477
		private int _throttleTime;

		// Token: 0x040001DE RID: 478
		private global::Infragistics.Windows.Internal.ThrottleTimer _cachedThrottleTimer;

		// Token: 0x040001DF RID: 479
		private bool _throttleFirstInvoke;

		// Token: 0x040001E0 RID: 480
		internal static readonly global::System.Windows.DependencyProperty TargetProperty = global::Infragistics.DependencyPropertyUtilities.Register("Target", typeof(object), typeof(global::Infragistics.Windows.Internal.PropertyValueTracker), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Internal.PropertyValueTracker.OnTargetChanged));

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x060004EF RID: 1263
		public delegate void PropertyValueChangedHandler();

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x060004F3 RID: 1267
		internal delegate void MethodInvoker();
	}
}
