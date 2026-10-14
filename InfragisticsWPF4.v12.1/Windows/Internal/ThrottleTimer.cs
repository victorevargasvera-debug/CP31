using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using Infragistics.Collections;

namespace Infragistics.Windows.Internal
{
	// Token: 0x02000065 RID: 101
	internal class ThrottleTimer : global::System.Windows.DependencyObject
	{
		// Token: 0x06000408 RID: 1032 RVA: 0x000113E8 File Offset: 0x0000F5E8
		public ThrottleTimer(long throttleInterval)
		{
			this._throttleInterval = throttleInterval;
			this._timerInterval = throttleInterval / 10L;
			this._maxTickProcessDuration = this._timerInterval / 4L;
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x00011434 File Offset: 0x0000F634
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

		// Token: 0x0600040A RID: 1034 RVA: 0x00011474 File Offset: 0x0000F674
		public void DoThrottledInvoke(global::Infragistics.Windows.Internal.ThrottleTimer.IAction action, bool throttleFirstInvoke)
		{
			global::Infragistics.Windows.Internal.ThrottleTimer.RegisteredCallback registeredCallback;
			if (!this._callbacks.TryGetValue(action, out registeredCallback))
			{
				registeredCallback = this.RegisterCallback(action, 0);
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
				registeredCallback._numberOfTimes = 1;
				this.EnsureTimerActive();
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00011504 File Offset: 0x0000F704
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

		// Token: 0x0600040C RID: 1036 RVA: 0x00011543 File Offset: 0x0000F743
		private void CompactStructures()
		{
			if (this._callbacksList.Count > 2 * this._lastCompactCount)
			{
				this._callbacksList.Compact();
				this._callbacks.Compact(true);
				this._lastCompactCount = this._callbacksList.Count;
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00011582 File Offset: 0x0000F782
		private void DeactivateTimer()
		{
			if (this._isTimerActive)
			{
				this._isTimerActive = false;
				this._timer.Change(-1, -1);
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000115A4 File Offset: 0x0000F7A4
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

		// Token: 0x0600040F RID: 1039 RVA: 0x00011606 File Offset: 0x0000F806
		private void OnTimerTick(object parameter)
		{
			if (!this._inOnTimerTick)
			{
				base.Dispatcher.Invoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.Internal.PropertyValueTracker.MethodInvoker(this.OnTimerTick_Sync));
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0001162C File Offset: 0x0000F82C
		private void OnTimerTick_Sync()
		{
			if (this._inOnTimerTick)
			{
				return;
			}
			this._inOnTimerTick = true;
			try
			{
				global::Infragistics.Collections.WeakList<global::Infragistics.Windows.Internal.ThrottleTimer.RegisteredCallback> callbacksList = this._callbacksList;
				if (callbacksList != null)
				{
					this.CompactStructures();
					long currentTime = this.CurrentTime;
					for (int i = 0; i < callbacksList.Count; i++)
					{
						int index = this._indecesCounter++ % callbacksList.Count;
						global::Infragistics.Windows.Internal.ThrottleTimer.RegisteredCallback registeredCallback = callbacksList[index];
						if (registeredCallback != null && registeredCallback._numberOfTimes > 0)
						{
							long currentTime2 = this.CurrentTime;
							if (currentTime2 - registeredCallback._lastCallTime >= this._throttleInterval)
							{
								registeredCallback._numberOfTimes--;
								registeredCallback._lastCallTime = currentTime2;
								global::Infragistics.Windows.Internal.ThrottleTimer.IAction action = registeredCallback.Action;
								if (action == null)
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
					}
				}
			}
			finally
			{
				this._inOnTimerTick = false;
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00011724 File Offset: 0x0000F924
		private global::Infragistics.Windows.Internal.ThrottleTimer.RegisteredCallback RegisterCallback(global::Infragistics.Windows.Internal.ThrottleTimer.IAction action, int numberOfTimes)
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
				this._callbacksList.Add(registeredCallback);
				if (registeredCallback._numberOfTimes > 0)
				{
					this.EnsureTimerActive();
				}
			}
			return registeredCallback;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0001178C File Offset: 0x0000F98C
		internal void Unregister(global::Infragistics.Windows.Internal.ThrottleTimer.IAction action)
		{
			global::Infragistics.Windows.Internal.ThrottleTimer.RegisteredCallback item;
			if (this._callbacks.TryGetValue(action, out item))
			{
				this._callbacks.Remove(action);
				this._callbacksList.Remove(item);
				if (this._callbacks.Count == 0)
				{
					this.DeactivateTimer();
				}
			}
		}

		// Token: 0x04000157 RID: 343
		private global::System.Threading.Timer _timer;

		// Token: 0x04000158 RID: 344
		private global::Infragistics.Collections.WeakList<global::Infragistics.Windows.Internal.ThrottleTimer.RegisteredCallback> _callbacksList = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.Internal.ThrottleTimer.RegisteredCallback>();

		// Token: 0x04000159 RID: 345
		private global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.Internal.ThrottleTimer.IAction, global::Infragistics.Windows.Internal.ThrottleTimer.RegisteredCallback> _callbacks = new global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.Internal.ThrottleTimer.IAction, global::Infragistics.Windows.Internal.ThrottleTimer.RegisteredCallback>(true, false);

		// Token: 0x0400015A RID: 346
		private int _indecesCounter;

		// Token: 0x0400015B RID: 347
		private long _timerInterval;

		// Token: 0x0400015C RID: 348
		private bool _inOnTimerTick;

		// Token: 0x0400015D RID: 349
		private bool _isTimerActive;

		// Token: 0x0400015E RID: 350
		private int _lastCompactCount;

		// Token: 0x0400015F RID: 351
		private long _throttleInterval;

		// Token: 0x04000160 RID: 352
		private long _maxTickProcessDuration;

		// Token: 0x04000161 RID: 353
		private int _lastTickCount;

		// Token: 0x04000162 RID: 354
		private long _wrapCounter;

		// Token: 0x04000163 RID: 355
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.Dictionary<long, global::Infragistics.Windows.Internal.ThrottleTimer> g_instances;

		// Token: 0x02000066 RID: 102
		internal interface IAction
		{
			// Token: 0x06000413 RID: 1043
			void Perform();
		}

		// Token: 0x02000067 RID: 103
		private class RegisteredCallback
		{
			// Token: 0x06000414 RID: 1044 RVA: 0x000117D6 File Offset: 0x0000F9D6
			internal RegisteredCallback(global::Infragistics.Windows.Internal.ThrottleTimer.IAction action)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(action, "action");
				this._action = new global::System.WeakReference(action);
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x06000415 RID: 1045 RVA: 0x000117FD File Offset: 0x0000F9FD
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

			// Token: 0x04000164 RID: 356
			private global::System.WeakReference _action;

			// Token: 0x04000165 RID: 357
			internal int _numberOfTimes;

			// Token: 0x04000166 RID: 358
			internal long _lastCallTime = -1L;
		}
	}
}
