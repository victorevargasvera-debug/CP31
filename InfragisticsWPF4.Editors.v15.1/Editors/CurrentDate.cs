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
	// Token: 0x0200003F RID: 63
	internal sealed class CurrentDate : global::System.Windows.DependencyObject
	{
		// Token: 0x06000438 RID: 1080 RVA: 0x000123B8 File Offset: 0x000105B8
		static CurrentDate()
		{
			global::Infragistics.Windows.Editors.CurrentDate._currentDate = global::System.DateTime.Today;
			global::Infragistics.Windows.Editors.CurrentDate._instances = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.Editors.CurrentDate>();
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0001243B File Offset: 0x0001063B
		public CurrentDate()
		{
			global::Infragistics.Windows.Editors.CurrentDate.AddInstance(this);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0001244C File Offset: 0x0001064C
		private static void OnValueChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CurrentDate currentDate = d as global::Infragistics.Windows.Editors.CurrentDate;
			global::System.EventHandler valueChanged = currentDate.ValueChanged;
			if (valueChanged != null)
			{
				valueChanged(currentDate, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x00012476 File Offset: 0x00010676
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DateTime Value
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Windows.Editors.CurrentDate.ValueProperty);
			}
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00012488 File Offset: 0x00010688
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

		// Token: 0x0600043D RID: 1085 RVA: 0x00012548 File Offset: 0x00010748
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

		// Token: 0x0600043E RID: 1086 RVA: 0x00012634 File Offset: 0x00010834
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

		// Token: 0x0600043F RID: 1087 RVA: 0x00012660 File Offset: 0x00010860
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

		// Token: 0x06000440 RID: 1088 RVA: 0x0001269C File Offset: 0x0001089C
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static void HookSystemTimeChangeImpl()
		{
			global::Microsoft.Win32.SystemEvents.TimeChanged += global::Infragistics.Windows.Editors.CurrentDate.OnSystemTimeChanged;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000126AF File Offset: 0x000108AF
		private static void OnSystemTimeChanged(object sender, global::System.EventArgs e)
		{
			global::Infragistics.Windows.Editors.CurrentDate.CheckForDateChange();
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000126B6 File Offset: 0x000108B6
		private static void OnTimerTick(object sender, global::System.EventArgs e)
		{
			if (sender == global::Infragistics.Windows.Editors.CurrentDate._timer)
			{
				global::Infragistics.Windows.Editors.CurrentDate.CheckForDateChange();
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000126C8 File Offset: 0x000108C8
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

		// Token: 0x06000444 RID: 1092 RVA: 0x00012744 File Offset: 0x00010944
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

		// Token: 0x06000445 RID: 1093 RVA: 0x00012778 File Offset: 0x00010978
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static void UnhookSystemTimeChangeImpl()
		{
			global::Microsoft.Win32.SystemEvents.TimeChanged -= global::Infragistics.Windows.Editors.CurrentDate.OnSystemTimeChanged;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0001278C File Offset: 0x0001098C
		private static void UpdateCurrentDate(object param)
		{
			global::Infragistics.Windows.Editors.CurrentDate currentDate = param as global::Infragistics.Windows.Editors.CurrentDate;
			if (currentDate != null)
			{
				currentDate.SetValue(global::Infragistics.Windows.Editors.CurrentDate.ValuePropertyKey, global::Infragistics.Windows.Editors.CurrentDate._currentDate);
			}
		}

		// Token: 0x0400018D RID: 397
		private static global::Infragistics.Collections.WeakList<global::Infragistics.Windows.Editors.CurrentDate> _instances;

		// Token: 0x0400018E RID: 398
		private static object _currentDate;

		// Token: 0x0400018F RID: 399
		private static readonly object Lock = new object();

		// Token: 0x04000190 RID: 400
		private static global::System.Windows.Threading.DispatcherTimer _timer;

		// Token: 0x04000191 RID: 401
		private static bool _canHookSystemTime = true;

		// Token: 0x04000192 RID: 402
		private static readonly global::System.Windows.DependencyPropertyKey ValuePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Value", typeof(global::System.DateTime), typeof(global::Infragistics.Windows.Editors.CurrentDate), new global::System.Windows.FrameworkPropertyMetadata(global::System.DateTime.Today, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CurrentDate.OnValueChanged)));

		// Token: 0x04000193 RID: 403
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::Infragistics.Windows.Editors.CurrentDate.ValuePropertyKey.DependencyProperty;

		// Token: 0x04000194 RID: 404
		public global::System.EventHandler ValueChanged;

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x06000448 RID: 1096
		private delegate void MethodInvoker();
	}
}
