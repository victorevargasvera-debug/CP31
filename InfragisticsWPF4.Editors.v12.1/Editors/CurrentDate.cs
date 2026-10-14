using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using Infragistics.Collections;
using Microsoft.Win32;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200003C RID: 60
	internal sealed class CurrentDate : global::System.Windows.DependencyObject
	{
		// Token: 0x06000413 RID: 1043 RVA: 0x000116F8 File Offset: 0x0000F8F8
		static CurrentDate()
		{
			global::Infragistics.Windows.Editors.CurrentDate._currentDate = global::System.DateTime.Today;
			global::Infragistics.Windows.Editors.CurrentDate._instances = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.Editors.CurrentDate>();
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0001177B File Offset: 0x0000F97B
		public CurrentDate()
		{
			global::Infragistics.Windows.Editors.CurrentDate.AddInstance(this);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0001178C File Offset: 0x0000F98C
		private static void OnValueChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CurrentDate currentDate = d as global::Infragistics.Windows.Editors.CurrentDate;
			global::System.EventHandler valueChanged = currentDate.ValueChanged;
			if (valueChanged != null)
			{
				valueChanged(currentDate, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x000117B6 File Offset: 0x0000F9B6
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DateTime Value
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Windows.Editors.CurrentDate.ValueProperty);
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000117C8 File Offset: 0x0000F9C8
		private static void AddInstance(global::Infragistics.Windows.Editors.CurrentDate item)
		{
			lock (global::Infragistics.Windows.Editors.CurrentDate.Lock)
			{
				global::Infragistics.Windows.Editors.CurrentDate._instances.Add(item);
				item.SetValue(global::Infragistics.Windows.Editors.CurrentDate.ValuePropertyKey, global::Infragistics.Windows.Editors.CurrentDate._currentDate);
				if (global::Infragistics.Windows.Editors.CurrentDate._instances.Count == 1)
				{
					global::Infragistics.Windows.Editors.CurrentDate.StartDateWatch(item.Dispatcher);
				}
				else if (global::Infragistics.Windows.Editors.CurrentDate._instances.Count % 20 == 0)
				{
					global::Infragistics.Windows.Editors.CurrentDate._instances.Compact();
					global::Infragistics.Windows.Editors.CurrentDate currentDate = global::Infragistics.Windows.Editors.CurrentDate._instances[0];
					if (currentDate == null)
					{
						global::Infragistics.Windows.Editors.CurrentDate.EndDateWatch();
					}
					else if (currentDate.Dispatcher != global::Infragistics.Windows.Editors.CurrentDate._timer.Dispatcher)
					{
						global::Infragistics.Windows.Editors.CurrentDate.EndDateWatch();
						global::Infragistics.Windows.Editors.CurrentDate.StartDateWatch(currentDate.Dispatcher);
					}
				}
			}
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00011888 File Offset: 0x0000FA88
		private static void CheckForDateChange()
		{
			global::System.DateTime today = global::System.DateTime.Today;
			global::System.DateTime d = (global::System.DateTime)global::Infragistics.Windows.Editors.CurrentDate._currentDate;
			if (today != d)
			{
				lock (global::Infragistics.Windows.Editors.CurrentDate.Lock)
				{
					global::Infragistics.Windows.Editors.CurrentDate._currentDate = today;
					foreach (global::Infragistics.Windows.Editors.CurrentDate currentDate in global::Infragistics.Windows.Editors.CurrentDate._instances)
					{
						if (currentDate.CheckAccess())
						{
							currentDate.SetValue(global::Infragistics.Windows.Editors.CurrentDate.ValuePropertyKey, global::Infragistics.Windows.Editors.CurrentDate._currentDate);
						}
						else
						{
							currentDate.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::System.Threading.SendOrPostCallback(global::Infragistics.Windows.Editors.CurrentDate.UpdateCurrentDate), currentDate);
						}
					}
					global::Infragistics.Windows.Editors.CurrentDate._instances.Compact();
					if (global::Infragistics.Windows.Editors.CurrentDate._instances.Count == 0)
					{
						global::Infragistics.Windows.Editors.CurrentDate.EndDateWatch();
					}
				}
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00011974 File Offset: 0x0000FB74
		private static void EndDateWatch()
		{
			if (global::Infragistics.Windows.Editors.CurrentDate._timer != null)
			{
				global::System.Windows.Threading.DispatcherTimer timer = global::Infragistics.Windows.Editors.CurrentDate._timer;
				global::Infragistics.Windows.Editors.CurrentDate._timer = null;
				timer.Stop();
				global::Infragistics.Windows.Editors.CurrentDate.UnhookSystemTimeChange();
			}
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000119A0 File Offset: 0x0000FBA0
		private static bool HookSystemTimeChange()
		{
			if (global::Infragistics.Windows.Editors.CurrentDate._canHookSystemTime)
			{
				try
				{
					global::Infragistics.Windows.Editors.CurrentDate.HookSystemTimeChangeImpl();
					return true;
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Editors.CurrentDate._canHookSystemTime = false;
				}
				return false;
			}
			return false;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000119DC File Offset: 0x0000FBDC
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static void HookSystemTimeChangeImpl()
		{
			global::Microsoft.Win32.SystemEvents.TimeChanged += global::Infragistics.Windows.Editors.CurrentDate.OnSystemTimeChanged;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000119EF File Offset: 0x0000FBEF
		private static void OnSystemTimeChanged(object sender, global::System.EventArgs e)
		{
			global::Infragistics.Windows.Editors.CurrentDate.CheckForDateChange();
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000119F6 File Offset: 0x0000FBF6
		private static void OnTimerTick(object sender, global::System.EventArgs e)
		{
			if (sender == global::Infragistics.Windows.Editors.CurrentDate._timer)
			{
				global::Infragistics.Windows.Editors.CurrentDate.CheckForDateChange();
			}
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00011A08 File Offset: 0x0000FC08
		private static void StartDateWatch(global::System.Windows.Threading.Dispatcher dispatcher)
		{
			global::System.TimeSpan interval;
			if (!global::Infragistics.Windows.Editors.CurrentDate.HookSystemTimeChange())
			{
				interval = global::System.TimeSpan.FromMinutes(0.2);
			}
			else
			{
				interval = global::System.DateTime.Today.AddDays(1.0).Subtract(global::System.DateTime.Now.Subtract(global::System.TimeSpan.FromMinutes(0.5)));
			}
			global::Infragistics.Windows.Editors.CurrentDate._timer = new global::System.Windows.Threading.DispatcherTimer(interval, global::System.Windows.Threading.DispatcherPriority.ContextIdle, new global::System.EventHandler(global::Infragistics.Windows.Editors.CurrentDate.OnTimerTick), dispatcher);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00011A84 File Offset: 0x0000FC84
		private static void UnhookSystemTimeChange()
		{
			if (global::Infragistics.Windows.Editors.CurrentDate._canHookSystemTime)
			{
				try
				{
					global::Infragistics.Windows.Editors.CurrentDate.UnhookSystemTimeChangeImpl();
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Editors.CurrentDate._canHookSystemTime = false;
				}
			}
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00011AB8 File Offset: 0x0000FCB8
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static void UnhookSystemTimeChangeImpl()
		{
			global::Microsoft.Win32.SystemEvents.TimeChanged -= global::Infragistics.Windows.Editors.CurrentDate.OnSystemTimeChanged;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00011ACC File Offset: 0x0000FCCC
		private static void UpdateCurrentDate(object param)
		{
			global::Infragistics.Windows.Editors.CurrentDate currentDate = param as global::Infragistics.Windows.Editors.CurrentDate;
			if (currentDate != null)
			{
				currentDate.SetValue(global::Infragistics.Windows.Editors.CurrentDate.ValuePropertyKey, global::Infragistics.Windows.Editors.CurrentDate._currentDate);
			}
		}

		// Token: 0x04000172 RID: 370
		private static global::Infragistics.Collections.WeakList<global::Infragistics.Windows.Editors.CurrentDate> _instances;

		// Token: 0x04000173 RID: 371
		private static object _currentDate;

		// Token: 0x04000174 RID: 372
		private static readonly object Lock = new object();

		// Token: 0x04000175 RID: 373
		private static global::System.Windows.Threading.DispatcherTimer _timer;

		// Token: 0x04000176 RID: 374
		private static bool _canHookSystemTime = true;

		// Token: 0x04000177 RID: 375
		private static readonly global::System.Windows.DependencyPropertyKey ValuePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Value", typeof(global::System.DateTime), typeof(global::Infragistics.Windows.Editors.CurrentDate), new global::System.Windows.FrameworkPropertyMetadata(global::System.DateTime.Today, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CurrentDate.OnValueChanged)));

		// Token: 0x04000178 RID: 376
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::Infragistics.Windows.Editors.CurrentDate.ValuePropertyKey.DependencyProperty;

		// Token: 0x04000179 RID: 377
		public global::System.EventHandler ValueChanged;

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x06000423 RID: 1059
		private delegate void MethodInvoker();
	}
}
