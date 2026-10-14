using System;
using System.Collections.Generic;

namespace NLog
{
	// Token: 0x02000010 RID: 16
	public sealed class LogLevel : global::System.IComparable, global::System.IEquatable<global::NLog.LogLevel>
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00007BDC File Offset: 0x00005DDC
		public static global::System.Collections.Generic.IEnumerable<global::NLog.LogLevel> AllLevels
		{
			get
			{
				return global::NLog.LogLevel.allLevels;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00007BE3 File Offset: 0x00005DE3
		public static global::System.Collections.Generic.IEnumerable<global::NLog.LogLevel> AllLoggingLevels
		{
			get
			{
				return global::NLog.LogLevel.allLoggingLevels;
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00007BEA File Offset: 0x00005DEA
		private LogLevel(string name, int ordinal)
		{
			this._name = name;
			this._ordinal = ordinal;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00007C00 File Offset: 0x00005E00
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00007C08 File Offset: 0x00005E08
		internal static global::NLog.LogLevel MaxLevel
		{
			get
			{
				return global::NLog.LogLevel.Fatal;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00007C0F File Offset: 0x00005E0F
		internal static global::NLog.LogLevel MinLevel
		{
			get
			{
				return global::NLog.LogLevel.Trace;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00007C16 File Offset: 0x00005E16
		public int Ordinal
		{
			get
			{
				return this._ordinal;
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00007C1E File Offset: 0x00005E1E
		public static bool operator ==(global::NLog.LogLevel level1, global::NLog.LogLevel level2)
		{
			if (level1 == null)
			{
				return level2 == null;
			}
			return level2 != null && level1.Ordinal == level2.Ordinal;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00007C3B File Offset: 0x00005E3B
		public static bool operator !=(global::NLog.LogLevel level1, global::NLog.LogLevel level2)
		{
			if (level1 == null)
			{
				return level2 != null;
			}
			return level2 == null || level1.Ordinal != level2.Ordinal;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00007C5B File Offset: 0x00005E5B
		public static bool operator >(global::NLog.LogLevel level1, global::NLog.LogLevel level2)
		{
			if (level1 == null)
			{
				throw new global::System.ArgumentNullException("level1");
			}
			if (level2 == null)
			{
				throw new global::System.ArgumentNullException("level2");
			}
			return level1.Ordinal > level2.Ordinal;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00007C93 File Offset: 0x00005E93
		public static bool operator >=(global::NLog.LogLevel level1, global::NLog.LogLevel level2)
		{
			if (level1 == null)
			{
				throw new global::System.ArgumentNullException("level1");
			}
			if (level2 == null)
			{
				throw new global::System.ArgumentNullException("level2");
			}
			return level1.Ordinal >= level2.Ordinal;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00007CCE File Offset: 0x00005ECE
		public static bool operator <(global::NLog.LogLevel level1, global::NLog.LogLevel level2)
		{
			if (level1 == null)
			{
				throw new global::System.ArgumentNullException("level1");
			}
			if (level2 == null)
			{
				throw new global::System.ArgumentNullException("level2");
			}
			return level1.Ordinal < level2.Ordinal;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00007D06 File Offset: 0x00005F06
		public static bool operator <=(global::NLog.LogLevel level1, global::NLog.LogLevel level2)
		{
			if (level1 == null)
			{
				throw new global::System.ArgumentNullException("level1");
			}
			if (level2 == null)
			{
				throw new global::System.ArgumentNullException("level2");
			}
			return level1.Ordinal <= level2.Ordinal;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00007D44 File Offset: 0x00005F44
		public static global::NLog.LogLevel FromOrdinal(int ordinal)
		{
			switch (ordinal)
			{
			case 0:
				return global::NLog.LogLevel.Trace;
			case 1:
				return global::NLog.LogLevel.Debug;
			case 2:
				return global::NLog.LogLevel.Info;
			case 3:
				return global::NLog.LogLevel.Warn;
			case 4:
				return global::NLog.LogLevel.Error;
			case 5:
				return global::NLog.LogLevel.Fatal;
			case 6:
				return global::NLog.LogLevel.Off;
			default:
				throw new global::System.ArgumentException("Invalid ordinal.");
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00007DAC File Offset: 0x00005FAC
		public static global::NLog.LogLevel FromString(string levelName)
		{
			if (levelName == null)
			{
				throw new global::System.ArgumentNullException("levelName");
			}
			if (levelName.Equals("Trace", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return global::NLog.LogLevel.Trace;
			}
			if (levelName.Equals("Debug", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return global::NLog.LogLevel.Debug;
			}
			if (levelName.Equals("Info", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return global::NLog.LogLevel.Info;
			}
			if (levelName.Equals("Warn", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return global::NLog.LogLevel.Warn;
			}
			if (levelName.Equals("Error", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return global::NLog.LogLevel.Error;
			}
			if (levelName.Equals("Fatal", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return global::NLog.LogLevel.Fatal;
			}
			if (levelName.Equals("Off", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return global::NLog.LogLevel.Off;
			}
			throw new global::System.ArgumentException(string.Format("Unknown log level: {0}", levelName));
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00007E63 File Offset: 0x00006063
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00007E6B File Offset: 0x0000606B
		public override int GetHashCode()
		{
			return this.Ordinal;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00007E74 File Offset: 0x00006074
		public override bool Equals(object obj)
		{
			global::NLog.LogLevel logLevel = obj as global::NLog.LogLevel;
			return logLevel != null && this.Ordinal == logLevel.Ordinal;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00007E9B File Offset: 0x0000609B
		public bool Equals(global::NLog.LogLevel other)
		{
			return other != null && this.Ordinal == other.Ordinal;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00007EB8 File Offset: 0x000060B8
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				throw new global::System.ArgumentNullException("obj");
			}
			global::NLog.LogLevel logLevel = (global::NLog.LogLevel)obj;
			return this.Ordinal - logLevel.Ordinal;
		}

		// Token: 0x04000032 RID: 50
		public static readonly global::NLog.LogLevel Trace = new global::NLog.LogLevel("Trace", 0);

		// Token: 0x04000033 RID: 51
		public static readonly global::NLog.LogLevel Debug = new global::NLog.LogLevel("Debug", 1);

		// Token: 0x04000034 RID: 52
		public static readonly global::NLog.LogLevel Info = new global::NLog.LogLevel("Info", 2);

		// Token: 0x04000035 RID: 53
		public static readonly global::NLog.LogLevel Warn = new global::NLog.LogLevel("Warn", 3);

		// Token: 0x04000036 RID: 54
		public static readonly global::NLog.LogLevel Error = new global::NLog.LogLevel("Error", 4);

		// Token: 0x04000037 RID: 55
		public static readonly global::NLog.LogLevel Fatal = new global::NLog.LogLevel("Fatal", 5);

		// Token: 0x04000038 RID: 56
		public static readonly global::NLog.LogLevel Off = new global::NLog.LogLevel("Off", 6);

		// Token: 0x04000039 RID: 57
		private static readonly global::System.Collections.Generic.IList<global::NLog.LogLevel> allLevels = new global::System.Collections.Generic.List<global::NLog.LogLevel>
		{
			global::NLog.LogLevel.Trace,
			global::NLog.LogLevel.Debug,
			global::NLog.LogLevel.Info,
			global::NLog.LogLevel.Warn,
			global::NLog.LogLevel.Error,
			global::NLog.LogLevel.Fatal,
			global::NLog.LogLevel.Off
		}.AsReadOnly();

		// Token: 0x0400003A RID: 58
		private static readonly global::System.Collections.Generic.IList<global::NLog.LogLevel> allLoggingLevels = new global::System.Collections.Generic.List<global::NLog.LogLevel>
		{
			global::NLog.LogLevel.Trace,
			global::NLog.LogLevel.Debug,
			global::NLog.LogLevel.Info,
			global::NLog.LogLevel.Warn,
			global::NLog.LogLevel.Error,
			global::NLog.LogLevel.Fatal
		}.AsReadOnly();

		// Token: 0x0400003B RID: 59
		private readonly int _ordinal;

		// Token: 0x0400003C RID: 60
		private readonly string _name;
	}
}
