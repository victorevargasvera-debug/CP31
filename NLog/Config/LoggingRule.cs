using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using NLog.Filters;
using NLog.Targets;

namespace NLog.Config
{
	// Token: 0x02000168 RID: 360
	[global::NLog.Config.NLogConfigurationItem]
	public class LoggingRule
	{
		// Token: 0x06000FC6 RID: 4038 RVA: 0x00028C7E File Offset: 0x00026E7E
		public LoggingRule()
		{
			this.Filters = new global::System.Collections.Generic.List<global::NLog.Filters.Filter>();
			this.ChildRules = new global::System.Collections.Generic.List<global::NLog.Config.LoggingRule>();
			this.Targets = new global::System.Collections.Generic.List<global::NLog.Targets.Target>();
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00028CBE File Offset: 0x00026EBE
		public LoggingRule(string loggerNamePattern, global::NLog.LogLevel minLevel, global::NLog.LogLevel maxLevel, global::NLog.Targets.Target target) : this()
		{
			this.LoggerNamePattern = loggerNamePattern;
			this.Targets.Add(target);
			this.EnableLoggingForLevels(minLevel, maxLevel);
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x00028CE2 File Offset: 0x00026EE2
		public LoggingRule(string loggerNamePattern, global::NLog.LogLevel minLevel, global::NLog.Targets.Target target) : this()
		{
			this.LoggerNamePattern = loggerNamePattern;
			this.Targets.Add(target);
			this.EnableLoggingForLevels(minLevel, global::NLog.LogLevel.MaxLevel);
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00028D09 File Offset: 0x00026F09
		public LoggingRule(string loggerNamePattern, global::NLog.Targets.Target target) : this()
		{
			this.LoggerNamePattern = loggerNamePattern;
			this.Targets.Add(target);
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x00028D24 File Offset: 0x00026F24
		public global::System.Collections.Generic.IList<global::NLog.Targets.Target> Targets { get; }

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x00028D2C File Offset: 0x00026F2C
		public global::System.Collections.Generic.IList<global::NLog.Config.LoggingRule> ChildRules { get; }

		// Token: 0x06000FCC RID: 4044 RVA: 0x00028D34 File Offset: 0x00026F34
		internal global::System.Collections.Generic.List<global::NLog.Config.LoggingRule> GetChildRulesThreadSafe()
		{
			global::System.Collections.Generic.IList<global::NLog.Config.LoggingRule> childRules = this.ChildRules;
			global::System.Collections.Generic.List<global::NLog.Config.LoggingRule> result;
			lock (childRules)
			{
				result = this.ChildRules.ToList<global::NLog.Config.LoggingRule>();
			}
			return result;
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00028D7C File Offset: 0x00026F7C
		internal global::System.Collections.Generic.List<global::NLog.Targets.Target> GetTargetsThreadSafe()
		{
			global::System.Collections.Generic.IList<global::NLog.Targets.Target> targets = this.Targets;
			global::System.Collections.Generic.List<global::NLog.Targets.Target> result;
			lock (targets)
			{
				result = this.Targets.ToList<global::NLog.Targets.Target>();
			}
			return result;
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00028DC4 File Offset: 0x00026FC4
		internal bool RemoveTargetThreadSafe(global::NLog.Targets.Target target)
		{
			global::System.Collections.Generic.IList<global::NLog.Targets.Target> targets = this.Targets;
			bool result;
			lock (targets)
			{
				result = this.Targets.Remove(target);
			}
			return result;
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x00028E0C File Offset: 0x0002700C
		public global::System.Collections.Generic.IList<global::NLog.Filters.Filter> Filters { get; }

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x00028E14 File Offset: 0x00027014
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x00028E1C File Offset: 0x0002701C
		public bool Final { get; set; }

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x00028E25 File Offset: 0x00027025
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x00028E30 File Offset: 0x00027030
		public string LoggerNamePattern
		{
			get
			{
				return this._loggerNamePattern;
			}
			set
			{
				this._loggerNamePattern = value;
				int num = this._loggerNamePattern.IndexOf('*');
				int num2 = this._loggerNamePattern.LastIndexOf('*');
				if (num < 0)
				{
					this._loggerNameMatchMode = global::NLog.Config.LoggingRule.MatchMode.Equals;
					this._loggerNameMatchArgument = value;
					return;
				}
				if (num == num2)
				{
					string text = this.LoggerNamePattern.Substring(0, num);
					string text2 = this.LoggerNamePattern.Substring(num + 1);
					if (text.Length > 0)
					{
						this._loggerNameMatchMode = global::NLog.Config.LoggingRule.MatchMode.StartsWith;
						this._loggerNameMatchArgument = text;
						return;
					}
					if (text2.Length > 0)
					{
						this._loggerNameMatchMode = global::NLog.Config.LoggingRule.MatchMode.EndsWith;
						this._loggerNameMatchArgument = text2;
						return;
					}
					return;
				}
				else
				{
					if (num == 0 && num2 == this.LoggerNamePattern.Length - 1)
					{
						string loggerNameMatchArgument = this.LoggerNamePattern.Substring(1, this.LoggerNamePattern.Length - 2);
						this._loggerNameMatchMode = global::NLog.Config.LoggingRule.MatchMode.Contains;
						this._loggerNameMatchArgument = loggerNameMatchArgument;
						return;
					}
					this._loggerNameMatchMode = global::NLog.Config.LoggingRule.MatchMode.None;
					this._loggerNameMatchArgument = string.Empty;
					return;
				}
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x00028F18 File Offset: 0x00027118
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::NLog.LogLevel> Levels
		{
			get
			{
				global::System.Collections.Generic.List<global::NLog.LogLevel> list = new global::System.Collections.Generic.List<global::NLog.LogLevel>();
				for (int i = global::NLog.LogLevel.MinLevel.Ordinal; i <= global::NLog.LogLevel.MaxLevel.Ordinal; i++)
				{
					if (this._logLevels[i])
					{
						list.Add(global::NLog.LogLevel.FromOrdinal(i));
					}
				}
				return list.AsReadOnly();
			}
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00028F65 File Offset: 0x00027165
		public void EnableLoggingForLevel(global::NLog.LogLevel level)
		{
			if (level == global::NLog.LogLevel.Off)
			{
				return;
			}
			this._logLevels[level.Ordinal] = true;
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00028F84 File Offset: 0x00027184
		public void EnableLoggingForLevels(global::NLog.LogLevel minLevel, global::NLog.LogLevel maxLevel)
		{
			for (int i = minLevel.Ordinal; i <= maxLevel.Ordinal; i++)
			{
				this.EnableLoggingForLevel(global::NLog.LogLevel.FromOrdinal(i));
			}
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00028FB3 File Offset: 0x000271B3
		public void DisableLoggingForLevel(global::NLog.LogLevel level)
		{
			if (level == global::NLog.LogLevel.Off)
			{
				return;
			}
			this._logLevels[level.Ordinal] = false;
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00028FD4 File Offset: 0x000271D4
		public void DisableLoggingForLevels(global::NLog.LogLevel minLevel, global::NLog.LogLevel maxLevel)
		{
			for (int i = minLevel.Ordinal; i <= maxLevel.Ordinal; i++)
			{
				this.DisableLoggingForLevel(global::NLog.LogLevel.FromOrdinal(i));
			}
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00029003 File Offset: 0x00027203
		public void SetLoggingLevels(global::NLog.LogLevel minLevel, global::NLog.LogLevel maxLevel)
		{
			this.DisableLoggingForLevels(global::NLog.LogLevel.MinLevel, global::NLog.LogLevel.MaxLevel);
			this.EnableLoggingForLevels(minLevel, maxLevel);
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00029020 File Offset: 0x00027220
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "logNamePattern: ({0}:{1})", new object[]
			{
				this._loggerNameMatchArgument,
				this._loggerNameMatchMode
			});
			stringBuilder.Append(" levels: [ ");
			for (int i = 0; i < this._logLevels.Length; i++)
			{
				if (this._logLevels[i])
				{
					stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "{0} ", new object[]
					{
						global::NLog.LogLevel.FromOrdinal(i).ToString()
					});
				}
			}
			stringBuilder.Append("] appendTo: [ ");
			foreach (global::NLog.Targets.Target target in this.GetTargetsThreadSafe())
			{
				stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "{0} ", new object[]
				{
					target.Name
				});
			}
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x0002912C File Offset: 0x0002732C
		public bool IsLoggingEnabledForLevel(global::NLog.LogLevel level)
		{
			return !(level == global::NLog.LogLevel.Off) && this._logLevels[level.Ordinal];
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x0002914C File Offset: 0x0002734C
		public bool NameMatches(string loggerName)
		{
			switch (this._loggerNameMatchMode)
			{
			case global::NLog.Config.LoggingRule.MatchMode.All:
				return true;
			case global::NLog.Config.LoggingRule.MatchMode.Equals:
				return loggerName.Equals(this._loggerNameMatchArgument, global::System.StringComparison.Ordinal);
			case global::NLog.Config.LoggingRule.MatchMode.StartsWith:
				return loggerName.StartsWith(this._loggerNameMatchArgument, global::System.StringComparison.Ordinal);
			case global::NLog.Config.LoggingRule.MatchMode.EndsWith:
				return loggerName.EndsWith(this._loggerNameMatchArgument, global::System.StringComparison.Ordinal);
			case global::NLog.Config.LoggingRule.MatchMode.Contains:
				return loggerName.IndexOf(this._loggerNameMatchArgument, global::System.StringComparison.Ordinal) >= 0;
			}
			return false;
		}

		// Token: 0x04000463 RID: 1123
		private readonly bool[] _logLevels = new bool[global::NLog.LogLevel.MaxLevel.Ordinal + 1];

		// Token: 0x04000464 RID: 1124
		private string _loggerNamePattern;

		// Token: 0x04000465 RID: 1125
		private global::NLog.Config.LoggingRule.MatchMode _loggerNameMatchMode;

		// Token: 0x04000466 RID: 1126
		private string _loggerNameMatchArgument;

		// Token: 0x0200023C RID: 572
		internal enum MatchMode
		{
			// Token: 0x04000677 RID: 1655
			All,
			// Token: 0x04000678 RID: 1656
			None,
			// Token: 0x04000679 RID: 1657
			Equals,
			// Token: 0x0400067A RID: 1658
			StartsWith,
			// Token: 0x0400067B RID: 1659
			EndsWith,
			// Token: 0x0400067C RID: 1660
			Contains
		}
	}
}
