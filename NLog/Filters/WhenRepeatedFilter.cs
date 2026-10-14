using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using NLog.Internal;

namespace NLog.Filters
{
	// Token: 0x02000155 RID: 341
	[global::NLog.Filters.Filter("whenRepeated")]
	public class WhenRepeatedFilter : global::NLog.Filters.LayoutBasedFilter
	{
		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x000262E8 File Offset: 0x000244E8
		// (set) Token: 0x06000F12 RID: 3858 RVA: 0x000262F0 File Offset: 0x000244F0
		[global::System.ComponentModel.DefaultValue(10)]
		public int TimeoutSeconds { get; set; }

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x000262F9 File Offset: 0x000244F9
		// (set) Token: 0x06000F14 RID: 3860 RVA: 0x00026301 File Offset: 0x00024501
		[global::System.ComponentModel.DefaultValue(1000)]
		public int MaxLength { get; set; }

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x0002630A File Offset: 0x0002450A
		// (set) Token: 0x06000F16 RID: 3862 RVA: 0x00026312 File Offset: 0x00024512
		[global::System.ComponentModel.DefaultValue(false)]
		public bool IncludeFirst { get; set; }

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x0002631B File Offset: 0x0002451B
		// (set) Token: 0x06000F18 RID: 3864 RVA: 0x00026323 File Offset: 0x00024523
		[global::System.ComponentModel.DefaultValue(50000)]
		public int MaxFilterCacheSize { get; set; }

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x0002632C File Offset: 0x0002452C
		// (set) Token: 0x06000F1A RID: 3866 RVA: 0x00026334 File Offset: 0x00024534
		[global::System.ComponentModel.DefaultValue(1000)]
		public int DefaultFilterCacheSize { get; set; }

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x0002633D File Offset: 0x0002453D
		// (set) Token: 0x06000F1C RID: 3868 RVA: 0x00026345 File Offset: 0x00024545
		[global::System.ComponentModel.DefaultValue(null)]
		public string FilterCountPropertyName { get; set; }

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x0002634E File Offset: 0x0002454E
		// (set) Token: 0x06000F1E RID: 3870 RVA: 0x00026356 File Offset: 0x00024556
		[global::System.ComponentModel.DefaultValue(null)]
		public string FilterCountMessageAppendFormat { get; set; }

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x0002635F File Offset: 0x0002455F
		// (set) Token: 0x06000F20 RID: 3872 RVA: 0x00026367 File Offset: 0x00024567
		[global::System.ComponentModel.DefaultValue(true)]
		public bool OptimizeBufferReuse { get; set; }

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x00026370 File Offset: 0x00024570
		// (set) Token: 0x06000F22 RID: 3874 RVA: 0x00026378 File Offset: 0x00024578
		[global::System.ComponentModel.DefaultValue(1000)]
		public int OptimizeBufferDefaultLength { get; set; }

		// Token: 0x06000F23 RID: 3875 RVA: 0x00026384 File Offset: 0x00024584
		public WhenRepeatedFilter()
		{
			this.TimeoutSeconds = 10;
			this.MaxLength = 1000;
			this.DefaultFilterCacheSize = 1000;
			this.MaxFilterCacheSize = 50000;
			this.OptimizeBufferReuse = true;
			this.OptimizeBufferDefaultLength = this.MaxLength;
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00026400 File Offset: 0x00024600
		protected override global::NLog.Filters.FilterResult Check(global::NLog.LogEventInfo logEvent)
		{
			global::NLog.Filters.FilterResult result = global::NLog.Filters.FilterResult.Neutral;
			bool flag = false;
			global::System.Collections.Generic.Dictionary<global::NLog.Filters.WhenRepeatedFilter.FilterInfoKey, global::NLog.Filters.WhenRepeatedFilter.FilterInfo> repeatFilter = this._repeatFilter;
			lock (repeatFilter)
			{
				using (global::NLog.Internal.ReusableObjectCreator<global::System.Text.StringBuilder>.LockOject lockOject = this.OptimizeBufferReuse ? this.ReusableLayoutBuilder.Allocate() : this.ReusableLayoutBuilder.None)
				{
					if (this.OptimizeBufferReuse && lockOject.Result.Capacity != this.OptimizeBufferDefaultLength)
					{
						if (this.OptimizeBufferDefaultLength < 16384)
						{
							this.OptimizeBufferDefaultLength = this.MaxLength;
							while (this.OptimizeBufferDefaultLength < lockOject.Result.Capacity && this.OptimizeBufferDefaultLength < 16384)
							{
								this.OptimizeBufferDefaultLength *= 2;
							}
						}
						lockOject.Result.Capacity = this.OptimizeBufferDefaultLength;
					}
					global::NLog.Filters.WhenRepeatedFilter.FilterInfoKey filterInfoKey = this.RenderFilterInfoKey(logEvent, this.OptimizeBufferReuse ? lockOject.Result : null);
					global::NLog.Filters.WhenRepeatedFilter.FilterInfo filterInfo;
					if (!this._repeatFilter.TryGetValue(filterInfoKey, out filterInfo))
					{
						filterInfo = this.CreateFilterInfo(logEvent);
						if (this.OptimizeBufferReuse && filterInfo.StringBuffer != null)
						{
							filterInfo.StringBuffer.ClearBuilder();
							int num = global::System.Math.Min(lockOject.Result.Length, this.MaxLength);
							for (int i = 0; i < num; i++)
							{
								filterInfo.StringBuffer.Append(lockOject.Result[i]);
							}
						}
						filterInfo.Refresh(logEvent.Level, logEvent.TimeStamp, 0);
						this._repeatFilter.Add(new global::NLog.Filters.WhenRepeatedFilter.FilterInfoKey(filterInfo.StringBuffer, filterInfoKey.StringValue, new int?(filterInfoKey.StringHashCode)), filterInfo);
						flag = true;
					}
					else
					{
						if (this.IncludeFirst)
						{
							flag = filterInfo.IsObsolete(logEvent.TimeStamp, this.TimeoutSeconds);
						}
						result = this.RefreshFilterInfo(logEvent, filterInfo);
					}
				}
			}
			if (this.IncludeFirst && flag)
			{
				result = base.Action;
			}
			return result;
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x00026620 File Offset: 0x00024820
		private global::NLog.Filters.WhenRepeatedFilter.FilterInfo CreateFilterInfo(global::NLog.LogEventInfo logEvent)
		{
			if (this._objectPool.Count == 0 && this._repeatFilter.Count > this.DefaultFilterCacheSize)
			{
				int val = (this._repeatFilter.Count > this.MaxFilterCacheSize) ? (this.TimeoutSeconds * 2 / 3) : this.TimeoutSeconds;
				this.PruneFilterCache(logEvent, global::System.Math.Max(1, val));
				if (this._repeatFilter.Count > this.MaxFilterCacheSize)
				{
					this.PruneFilterCache(logEvent, global::System.Math.Max(1, this.TimeoutSeconds / 2));
				}
			}
			global::NLog.Filters.WhenRepeatedFilter.FilterInfo filterInfo;
			if (this._objectPool.Count == 0)
			{
				filterInfo = new global::NLog.Filters.WhenRepeatedFilter.FilterInfo(this.OptimizeBufferReuse ? new global::System.Text.StringBuilder(this.OptimizeBufferDefaultLength) : null);
			}
			else
			{
				filterInfo = this._objectPool.Pop().Value;
				if (this.OptimizeBufferReuse && filterInfo.StringBuffer != null && filterInfo.StringBuffer.Capacity != this.OptimizeBufferDefaultLength)
				{
					filterInfo.StringBuffer.Capacity = this.OptimizeBufferDefaultLength;
				}
			}
			return filterInfo;
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00026720 File Offset: 0x00024920
		private void PruneFilterCache(global::NLog.LogEventInfo logEvent, int aggressiveTimeoutSeconds)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::NLog.Filters.WhenRepeatedFilter.FilterInfoKey, global::NLog.Filters.WhenRepeatedFilter.FilterInfo> item in this._repeatFilter)
			{
				if (item.Value.IsObsolete(logEvent.TimeStamp, aggressiveTimeoutSeconds))
				{
					this._objectPool.Push(item);
				}
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::NLog.Filters.WhenRepeatedFilter.FilterInfoKey, global::NLog.Filters.WhenRepeatedFilter.FilterInfo> keyValuePair in this._objectPool)
			{
				this._repeatFilter.Remove(keyValuePair.Key);
			}
			if (this._repeatFilter.Count * 2 > this.DefaultFilterCacheSize && this.DefaultFilterCacheSize < this.MaxFilterCacheSize)
			{
				this.DefaultFilterCacheSize *= 2;
			}
			while (this._objectPool.Count != 0 && this._objectPool.Count > this.DefaultFilterCacheSize)
			{
				this._objectPool.Pop();
			}
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x0002683C File Offset: 0x00024A3C
		private global::NLog.Filters.WhenRepeatedFilter.FilterInfoKey RenderFilterInfoKey(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder targetBuilder)
		{
			if (targetBuilder != null)
			{
				base.Layout.RenderAppendBuilder(logEvent, targetBuilder, false);
				if (targetBuilder.Length > this.MaxLength)
				{
					targetBuilder.Length = this.MaxLength;
				}
				return new global::NLog.Filters.WhenRepeatedFilter.FilterInfoKey(targetBuilder, null, null);
			}
			string text = base.Layout.Render(logEvent) ?? string.Empty;
			if (text.Length > this.MaxLength)
			{
				text = text.Substring(0, this.MaxLength);
			}
			return new global::NLog.Filters.WhenRepeatedFilter.FilterInfoKey(null, text, null);
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x000268C8 File Offset: 0x00024AC8
		private global::NLog.Filters.FilterResult RefreshFilterInfo(global::NLog.LogEventInfo logEvent, global::NLog.Filters.WhenRepeatedFilter.FilterInfo filterInfo)
		{
			if (filterInfo.HasExpired(logEvent.TimeStamp, this.TimeoutSeconds) || logEvent.Level.Ordinal > filterInfo.LogLevel.Ordinal)
			{
				int num = filterInfo.FilterCount;
				if (num > 0 && filterInfo.IsObsolete(logEvent.TimeStamp, this.TimeoutSeconds))
				{
					num = 0;
				}
				filterInfo.Refresh(logEvent.Level, logEvent.TimeStamp, 0);
				if (num > 0)
				{
					if (!string.IsNullOrEmpty(this.FilterCountPropertyName))
					{
						object obj;
						object obj2;
						if (!logEvent.Properties.TryGetValue(this.FilterCountPropertyName, out obj))
						{
							logEvent.Properties[this.FilterCountPropertyName] = num;
						}
						else if ((obj2 = obj) is int)
						{
							int val = (int)obj2;
							num = global::System.Math.Max(val, num);
							logEvent.Properties[this.FilterCountPropertyName] = num;
						}
					}
					if (!string.IsNullOrEmpty(this.FilterCountMessageAppendFormat) && logEvent.Message != null)
					{
						logEvent.Message += string.Format(this.FilterCountMessageAppendFormat, num.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					}
				}
				return global::NLog.Filters.FilterResult.Neutral;
			}
			filterInfo.Refresh(logEvent.Level, logEvent.TimeStamp, filterInfo.FilterCount + 1);
			return base.Action;
		}

		// Token: 0x04000429 RID: 1065
		private const int MaxInitialRenderBufferLength = 16384;

		// Token: 0x04000433 RID: 1075
		internal readonly global::NLog.Internal.ReusableBuilderCreator ReusableLayoutBuilder = new global::NLog.Internal.ReusableBuilderCreator();

		// Token: 0x04000434 RID: 1076
		private readonly global::System.Collections.Generic.Dictionary<global::NLog.Filters.WhenRepeatedFilter.FilterInfoKey, global::NLog.Filters.WhenRepeatedFilter.FilterInfo> _repeatFilter = new global::System.Collections.Generic.Dictionary<global::NLog.Filters.WhenRepeatedFilter.FilterInfoKey, global::NLog.Filters.WhenRepeatedFilter.FilterInfo>(1000);

		// Token: 0x04000435 RID: 1077
		private readonly global::System.Collections.Generic.Stack<global::System.Collections.Generic.KeyValuePair<global::NLog.Filters.WhenRepeatedFilter.FilterInfoKey, global::NLog.Filters.WhenRepeatedFilter.FilterInfo>> _objectPool = new global::System.Collections.Generic.Stack<global::System.Collections.Generic.KeyValuePair<global::NLog.Filters.WhenRepeatedFilter.FilterInfoKey, global::NLog.Filters.WhenRepeatedFilter.FilterInfo>>(1000);

		// Token: 0x0200022F RID: 559
		private class FilterInfo
		{
			// Token: 0x06001365 RID: 4965 RVA: 0x0003272D File Offset: 0x0003092D
			public FilterInfo(global::System.Text.StringBuilder stringBuilder)
			{
				this.StringBuffer = stringBuilder;
			}

			// Token: 0x06001366 RID: 4966 RVA: 0x0003273C File Offset: 0x0003093C
			public void Refresh(global::NLog.LogLevel logLevel, global::System.DateTime logTimeStamp, int filterCount)
			{
				if (filterCount == 0)
				{
					this.LastLogTime = logTimeStamp;
					this.LogLevel = logLevel;
				}
				else if (this.LogLevel == null || logLevel.Ordinal > this.LogLevel.Ordinal)
				{
					this.LogLevel = logLevel;
				}
				this.LastFilterTime = logTimeStamp;
				this.FilterCount = filterCount;
			}

			// Token: 0x06001367 RID: 4967 RVA: 0x00032794 File Offset: 0x00030994
			public bool IsObsolete(global::System.DateTime logEventTime, int timeoutSeconds)
			{
				if (this.FilterCount == 0)
				{
					return this.HasExpired(logEventTime, timeoutSeconds);
				}
				return (logEventTime - this.LastFilterTime).TotalSeconds > (double)timeoutSeconds && this.HasExpired(logEventTime, timeoutSeconds * 2);
			}

			// Token: 0x06001368 RID: 4968 RVA: 0x000327D8 File Offset: 0x000309D8
			public bool HasExpired(global::System.DateTime logEventTime, int timeoutSeconds)
			{
				return (logEventTime - this.LastLogTime).TotalSeconds > (double)timeoutSeconds;
			}

			// Token: 0x17000394 RID: 916
			// (get) Token: 0x06001369 RID: 4969 RVA: 0x000327FD File Offset: 0x000309FD
			// (set) Token: 0x0600136A RID: 4970 RVA: 0x00032805 File Offset: 0x00030A05
			public global::System.Text.StringBuilder StringBuffer { get; private set; }

			// Token: 0x17000395 RID: 917
			// (get) Token: 0x0600136B RID: 4971 RVA: 0x0003280E File Offset: 0x00030A0E
			// (set) Token: 0x0600136C RID: 4972 RVA: 0x00032816 File Offset: 0x00030A16
			public global::NLog.LogLevel LogLevel { get; private set; }

			// Token: 0x17000396 RID: 918
			// (get) Token: 0x0600136D RID: 4973 RVA: 0x0003281F File Offset: 0x00030A1F
			// (set) Token: 0x0600136E RID: 4974 RVA: 0x00032827 File Offset: 0x00030A27
			private global::System.DateTime LastLogTime { get; set; }

			// Token: 0x17000397 RID: 919
			// (get) Token: 0x0600136F RID: 4975 RVA: 0x00032830 File Offset: 0x00030A30
			// (set) Token: 0x06001370 RID: 4976 RVA: 0x00032838 File Offset: 0x00030A38
			private global::System.DateTime LastFilterTime { get; set; }

			// Token: 0x17000398 RID: 920
			// (get) Token: 0x06001371 RID: 4977 RVA: 0x00032841 File Offset: 0x00030A41
			// (set) Token: 0x06001372 RID: 4978 RVA: 0x00032849 File Offset: 0x00030A49
			public int FilterCount { get; private set; }
		}

		// Token: 0x02000230 RID: 560
		private struct FilterInfoKey : global::System.IEquatable<global::NLog.Filters.WhenRepeatedFilter.FilterInfoKey>
		{
			// Token: 0x06001373 RID: 4979 RVA: 0x00032854 File Offset: 0x00030A54
			public FilterInfoKey(global::System.Text.StringBuilder stringBuffer, string stringValue, int? stringHashCode = null)
			{
				this._stringBuffer = stringBuffer;
				this.StringValue = stringValue;
				if (stringHashCode != null)
				{
					this.StringHashCode = stringHashCode.Value;
					return;
				}
				if (stringBuffer != null)
				{
					int num = stringBuffer.Length.GetHashCode();
					int num2 = global::System.Math.Min(stringBuffer.Length, 100);
					for (int i = 0; i < num2; i++)
					{
						num ^= stringBuffer[i].GetHashCode();
					}
					this.StringHashCode = num;
					return;
				}
				this.StringHashCode = global::System.StringComparer.Ordinal.GetHashCode(this.StringValue);
			}

			// Token: 0x06001374 RID: 4980 RVA: 0x000328E3 File Offset: 0x00030AE3
			public override int GetHashCode()
			{
				return this.StringHashCode;
			}

			// Token: 0x06001375 RID: 4981 RVA: 0x000328EC File Offset: 0x00030AEC
			public bool Equals(global::NLog.Filters.WhenRepeatedFilter.FilterInfoKey other)
			{
				if (this.StringValue != null)
				{
					return string.Equals(this.StringValue, other.StringValue, global::System.StringComparison.Ordinal);
				}
				if (this._stringBuffer == null || other._stringBuffer == null)
				{
					return this._stringBuffer == other._stringBuffer && this.StringValue == other.StringValue;
				}
				if (this._stringBuffer.Capacity != other._stringBuffer.Capacity)
				{
					return this._stringBuffer.EqualTo(other._stringBuffer);
				}
				return this._stringBuffer.Equals(other._stringBuffer);
			}

			// Token: 0x06001376 RID: 4982 RVA: 0x00032980 File Offset: 0x00030B80
			public override bool Equals(object obj)
			{
				if (obj is global::NLog.Filters.WhenRepeatedFilter.FilterInfoKey)
				{
					global::NLog.Filters.WhenRepeatedFilter.FilterInfoKey other = (global::NLog.Filters.WhenRepeatedFilter.FilterInfoKey)obj;
					return this.Equals(other);
				}
				return false;
			}

			// Token: 0x04000658 RID: 1624
			private readonly global::System.Text.StringBuilder _stringBuffer;

			// Token: 0x04000659 RID: 1625
			public readonly string StringValue;

			// Token: 0x0400065A RID: 1626
			public readonly int StringHashCode;
		}
	}
}
