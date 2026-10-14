using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using Infragistics.Collections;

namespace Infragistics.Windows.Internal
{
	// Token: 0x0200007C RID: 124
	internal class ThrottleTimer : global::System.Windows.DependencyObject
	{
		// Token: 0x060004C9 RID: 1225 RVA: 0x00013B94 File Offset: 0x00011D94
		public ThrottleTimer(long throttleInterval)
		{
			this._throttleInterval = throttleInterval;
			this._timerInterval = throttleInterval / 10L;
			this._maxTickProcessDuration = this._timerInterval / 4L;
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00013BE0 File Offset: 0x00011DE0
		private long CurrentTime
		{
			get
			{
				int tickCount = global::System.Environment.TickCount;
				if (tickCount < this._lastTickCount)
				{
					this._wrapCounter += 2147483647L;
				}
				this._lastTickCount = tickCount;
				return this._wrapCounter + (long)tickCount;
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00013C20 File Offset: 0x00011E20
		public void DoThrottledInvoke(global::Infragistics.Windows.Internal.ThrottleTimer.IAction action, bool throttleFirstInvoke)
		{
			global::Infragistics.Windows.Internal.ThrottleTimer.RegisteredCallback registeredCallback;
			if (!this._callbacks.TryGetValue(action, out registeredCallback))
			{
				registeredCallback = this.RegisterCallback(action, 0, true);
			}
			long currentTime = this.CurrentTime;
			if (throttleFirstInvoke && -1L == registeredCallback._lastCallTime)
			{
				registeredCallback._lastCallTime = currentTime;
			}
			if (currentTime - registeredCallback._lastCallTime > this._timerInterval)
			{
				registeredCallback._lastCallTime = currentTime;
				global::Infragistics.Windows.Internal.ThrottleTimer.IAction action2 = registeredCallback.Action;
				if (action2 != null)
				{
					if (registeredCallback._numberOfTimes > 0)
					{
						registeredCallback._numberOfTimes--;
					}
					action2.Perform();
					return;
				}
			}
			else
			{
				if (registeredCallback._numberOfTimes <= 0)
				{
					this._callbacksList.Add(registeredCallback);
				}
				registeredCallback._numberOfTimes = 1;
				this.EnsureTimerActive();
			}
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00013CC4 File Offset: 0x00011EC4
		public static global::Infragistics.Windows.Internal.ThrottleTimer GetInstance(long interval)
		{
			if (global::Infragistics.Windows.Internal.ThrottleTimer.g_instances == null)
			{
				global::Infragistics.Windows.Internal.ThrottleTimer.g_instances = new global::System.Collections.Generic.Dictionary<long, global::Infragistics.Windows.Internal.ThrottleTimer>();
			}
			global::System.Collections.Generic.Dictionary<long, global::Infragistics.Windows.Internal.ThrottleTimer> dictionary = global::Infragistics.Windows.Internal.ThrottleTimer.g_instances;
			global::Infragistics.Windows.Internal.ThrottleTimer throttleTimer;
			if (!dictionary.TryGetValue(interval, out throttleTimer))
			{
				throttleTimer = new global::Infragistics.Windows.Internal.ThrottleTimer(interval);
				dictionary[interval] = throttleTimer;
			}
			return throttleTimer;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00013D03 File Offset: 0x00011F03
		private void CompactStructures()
		{
			if (this._callbacksList.Count > 2 * this._lastCompactCount)
			{
				this._callbacksList.Compact();
				this._callbacks.Compact(true);
				this._lastCompactCount = this._callbacksList.Count;
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00013D42 File Offset: 0x00011F42
		private void DeactivateTimer()
		{
			if (this._isTimerActive)
			{
				this._isTimerActive = false;
				this._timer.Change(-1, -1);
			}
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00013D64 File Offset: 0x00011F64
		private void EnsureTimerActive()
		{
			if (!this._isTimerActive)
			{
				if (this._timer == null)
				{
					this._timer = new global::System.Threading.Timer(new global::System.Threading.TimerCallback(this.OnTimerTick), null, this._timerInterval, this._timerInterval);
				}
				else
				{
					this._timer.Change(this._timerInterval, this._timerInterval);
				}
				this._isTimerActive = true;
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00013DC8 File Offset: 0x00011FC8
		private void OnTimerTick(object parameter)
		{
			if (global::System.Threading.Interlocked.CompareExchange(ref this._inOnTimerTick, 1, 0) == 0)
			{
				try
				{
					base.Dispatcher.Invoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.Internal.PropertyValueTracker.MethodInvoker(this.OnTimerTick_Sync));
				}
				finally
				{
					global::System.Threading.Interlocked.Exchange(ref this._inOnTimerTick, 0);
				}
			}
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00013E20 File Offset: 0x00012020
		private void OnTimerTick_Sync()
		{
			global::Infragistics.Collections.WeakList<global::Infragistics.Windows.Internal.ThrottleTimer.RegisteredCallback> callbacksList = this._callbacksList;
			if (callbacksList != null)
			{
				this.CompactStructures();
				long currentTime = this.CurrentTime;
				int num = 0;
				for (int i = 0; i < callbacksList.Count; i++)
				{
					int index = this._indecesCounter++ % callbacksList.Count;
					global::Infragistics.Windows.Internal.ThrottleTimer.RegisteredCallback registeredCallback = callbacksList[index];
					if (registeredCallback != null && registeredCallback._numberOfTimes > 0)
					{
						num++;
						long currentTime2 = this.CurrentTime;
						if (currentTime2 - registeredCallback._lastCallTime >= this._throttleInterval)
						{
							registeredCallback._numberOfTimes--;
							registeredCallback._lastCallTime = currentTime2;
							global::Infragistics.Windows.Internal.ThrottleTimer.IAction action = registeredCallback.Action;
							if (action == null || registeredCallback._numberOfTimes == 0)
							{
								callbacksList[index] = null;
							}
							if (action != null)
							{
								action.Perform();
								if (currentTime2 - currentTime > this._maxTickProcessDuration)
								{
									break;
								}
							}
						}
					}
					else
					{
						callbacksList[index] = null;
					}
				}
				if (num < callbacksList.Count / 2)
				{
					callbacksList.Compact();
				}
				if (num == 0)
				{
					this.DeactivateTimer();
				}
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00013F28 File Offset: 0x00012128
		private global::Infragistics.Windows.Internal.ThrottleTimer.RegisteredCallback RegisterCallback(global::Infragistics.Windows.Internal.ThrottleTimer.IAction action, int numberOfTimes, bool dontAddToCallbackList)
		{
			if (numberOfTimes < 0)
			{
				throw new global::System.ArgumentOutOfRangeException();
			}
			bool flag = false;
			global::Infragistics.Windows.Internal.ThrottleTimer.RegisteredCallback registeredCallback;
			if (!this._callbacks.TryGetValue(action, out registeredCallback))
			{
				registeredCallback = new global::Infragistics.Windows.Internal.ThrottleTimer.RegisteredCallback(action);
				flag = true;
			}
			registeredCallback._numberOfTimes = numberOfTimes;
			if (flag)
			{
				this._callbacks[action] = registeredCallback;
				if (!dontAddToCallbackList)
				{
					this._callbacksList.Add(registeredCallback);
				}
				if (registeredCallback._numberOfTimes > 0)
				{
					this.EnsureTimerActive();
				}
			}
			return registeredCallback;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00013F94 File Offset: 0x00012194
		internal void Unregister(global::Infragistics.Windows.Internal.ThrottleTimer.IAction action)
		{
			global::Infragistics.Windows.Internal.ThrottleTimer.RegisteredCallback value;
			if (this._callbacks.TryGetValue(action, out value))
			{
				this._callbacks.Remove(action);
				int num = this._callbacksList.IndexOf(value);
				if (num >= 0)
				{
					this._callbacksList[num] = null;
				}
				if (this._callbacks.Count == 0)
				{
					this.DeactivateTimer();
				}
			}
		}

		// Token: 0x040001C6 RID: 454
		private const int IN_TICK = 1;

		// Token: 0x040001C7 RID: 455
		private const int NOT_IN_TICK = 0;

		// Token: 0x040001C8 RID: 456
		private global::System.Threading.Timer _timer;

		// Token: 0x040001C9 RID: 457
		private global::Infragistics.Collections.WeakList<global::Infragistics.Windows.Internal.ThrottleTimer.RegisteredCallback> _callbacksList = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.Internal.ThrottleTimer.RegisteredCallback>();

		// Token: 0x040001CA RID: 458
		private global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.Internal.ThrottleTimer.IAction, global::Infragistics.Windows.Internal.ThrottleTimer.RegisteredCallback> _callbacks = new global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.Internal.ThrottleTimer.IAction, global::Infragistics.Windows.Internal.ThrottleTimer.RegisteredCallback>(true, false);

		// Token: 0x040001CB RID: 459
		private int _indecesCounter;

		// Token: 0x040001CC RID: 460
		private long _timerInterval;

		// Token: 0x040001CD RID: 461
		private int _inOnTimerTick;

		// Token: 0x040001CE RID: 462
		private bool _isTimerActive;

		// Token: 0x040001CF RID: 463
		private int _lastCompactCount;

		// Token: 0x040001D0 RID: 464
		private long _throttleInterval;

		// Token: 0x040001D1 RID: 465
		private long _maxTickProcessDuration;

		// Token: 0x040001D2 RID: 466
		private int _lastTickCount;

		// Token: 0x040001D3 RID: 467
		private long _wrapCounter;

		// Token: 0x040001D4 RID: 468
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.Dictionary<long, global::Infragistics.Windows.Internal.ThrottleTimer> g_instances;

		// Token: 0x0200007D RID: 125
		internal interface IAction
		{
			// Token: 0x060004D4 RID: 1236
			void Perform();
		}

		// Token: 0x0200007E RID: 126
		private class RegisteredCallback
		{
			// Token: 0x060004D5 RID: 1237 RVA: 0x00013FEF File Offset: 0x000121EF
			internal RegisteredCallback(global::Infragistics.Windows.Internal.ThrottleTimer.IAction action)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(action, "action");
				this._action = new global::System.WeakReference(action);
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00014016 File Offset: 0x00012216
			internal global::Infragistics.Windows.Internal.ThrottleTimer.IAction Action
			{
				get
				{
					if (this._action == null)
					{
						return null;
					}
					return (global::Infragistics.Windows.Internal.ThrottleTimer.IAction)global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._action);
				}
			}

			// Token: 0x040001D5 RID: 469
			private global::System.WeakReference _action;

			// Token: 0x040001D6 RID: 470
			internal int _numberOfTimes;

			// Token: 0x040001D7 RID: 471
			internal long _lastCallTime = -1L;
		}
	}
}
