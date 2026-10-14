using System;
using System.ComponentModel;

namespace NLog
{
	// Token: 0x02000006 RID: 6
	[global::System.CLSCompliant(false)]
	public interface ILogger : global::NLog.ILoggerBase, global::NLog.ISuppress
	{
		// Token: 0x0600001D RID: 29
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void Trace(object value);

		// Token: 0x0600001E RID: 30
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void Trace(global::System.IFormatProvider formatProvider, object value);

		// Token: 0x0600001F RID: 31
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(string message, object arg1, object arg2);

		// Token: 0x06000020 RID: 32
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(string message, object arg1, object arg2, object arg3);

		// Token: 0x06000021 RID: 33
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(global::System.IFormatProvider formatProvider, string message, bool argument);

		// Token: 0x06000022 RID: 34
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(string message, bool argument);

		// Token: 0x06000023 RID: 35
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(global::System.IFormatProvider formatProvider, string message, char argument);

		// Token: 0x06000024 RID: 36
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(string message, char argument);

		// Token: 0x06000025 RID: 37
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(global::System.IFormatProvider formatProvider, string message, byte argument);

		// Token: 0x06000026 RID: 38
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(string message, byte argument);

		// Token: 0x06000027 RID: 39
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(global::System.IFormatProvider formatProvider, string message, string argument);

		// Token: 0x06000028 RID: 40
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(string message, string argument);

		// Token: 0x06000029 RID: 41
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(global::System.IFormatProvider formatProvider, string message, int argument);

		// Token: 0x0600002A RID: 42
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(string message, int argument);

		// Token: 0x0600002B RID: 43
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(global::System.IFormatProvider formatProvider, string message, long argument);

		// Token: 0x0600002C RID: 44
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(string message, long argument);

		// Token: 0x0600002D RID: 45
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(global::System.IFormatProvider formatProvider, string message, float argument);

		// Token: 0x0600002E RID: 46
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(string message, float argument);

		// Token: 0x0600002F RID: 47
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(global::System.IFormatProvider formatProvider, string message, double argument);

		// Token: 0x06000030 RID: 48
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(string message, double argument);

		// Token: 0x06000031 RID: 49
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(global::System.IFormatProvider formatProvider, string message, decimal argument);

		// Token: 0x06000032 RID: 50
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(string message, decimal argument);

		// Token: 0x06000033 RID: 51
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(global::System.IFormatProvider formatProvider, string message, object argument);

		// Token: 0x06000034 RID: 52
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(string message, object argument);

		// Token: 0x06000035 RID: 53
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(global::System.IFormatProvider formatProvider, string message, sbyte argument);

		// Token: 0x06000036 RID: 54
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(string message, sbyte argument);

		// Token: 0x06000037 RID: 55
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(global::System.IFormatProvider formatProvider, string message, uint argument);

		// Token: 0x06000038 RID: 56
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(string message, uint argument);

		// Token: 0x06000039 RID: 57
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(global::System.IFormatProvider formatProvider, string message, ulong argument);

		// Token: 0x0600003A RID: 58
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(string message, ulong argument);

		// Token: 0x0600003B RID: 59
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void Debug(object value);

		// Token: 0x0600003C RID: 60
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void Debug(global::System.IFormatProvider formatProvider, object value);

		// Token: 0x0600003D RID: 61
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(string message, object arg1, object arg2);

		// Token: 0x0600003E RID: 62
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(string message, object arg1, object arg2, object arg3);

		// Token: 0x0600003F RID: 63
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(global::System.IFormatProvider formatProvider, string message, bool argument);

		// Token: 0x06000040 RID: 64
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(string message, bool argument);

		// Token: 0x06000041 RID: 65
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(global::System.IFormatProvider formatProvider, string message, char argument);

		// Token: 0x06000042 RID: 66
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(string message, char argument);

		// Token: 0x06000043 RID: 67
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(global::System.IFormatProvider formatProvider, string message, byte argument);

		// Token: 0x06000044 RID: 68
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(string message, byte argument);

		// Token: 0x06000045 RID: 69
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(global::System.IFormatProvider formatProvider, string message, string argument);

		// Token: 0x06000046 RID: 70
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(string message, string argument);

		// Token: 0x06000047 RID: 71
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(global::System.IFormatProvider formatProvider, string message, int argument);

		// Token: 0x06000048 RID: 72
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(string message, int argument);

		// Token: 0x06000049 RID: 73
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(global::System.IFormatProvider formatProvider, string message, long argument);

		// Token: 0x0600004A RID: 74
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(string message, long argument);

		// Token: 0x0600004B RID: 75
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(global::System.IFormatProvider formatProvider, string message, float argument);

		// Token: 0x0600004C RID: 76
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(string message, float argument);

		// Token: 0x0600004D RID: 77
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(global::System.IFormatProvider formatProvider, string message, double argument);

		// Token: 0x0600004E RID: 78
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(string message, double argument);

		// Token: 0x0600004F RID: 79
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(global::System.IFormatProvider formatProvider, string message, decimal argument);

		// Token: 0x06000050 RID: 80
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(string message, decimal argument);

		// Token: 0x06000051 RID: 81
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(global::System.IFormatProvider formatProvider, string message, object argument);

		// Token: 0x06000052 RID: 82
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(string message, object argument);

		// Token: 0x06000053 RID: 83
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(global::System.IFormatProvider formatProvider, string message, sbyte argument);

		// Token: 0x06000054 RID: 84
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(string message, sbyte argument);

		// Token: 0x06000055 RID: 85
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(global::System.IFormatProvider formatProvider, string message, uint argument);

		// Token: 0x06000056 RID: 86
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(string message, uint argument);

		// Token: 0x06000057 RID: 87
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(global::System.IFormatProvider formatProvider, string message, ulong argument);

		// Token: 0x06000058 RID: 88
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(string message, ulong argument);

		// Token: 0x06000059 RID: 89
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void Info(object value);

		// Token: 0x0600005A RID: 90
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void Info(global::System.IFormatProvider formatProvider, object value);

		// Token: 0x0600005B RID: 91
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(string message, object arg1, object arg2);

		// Token: 0x0600005C RID: 92
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(string message, object arg1, object arg2, object arg3);

		// Token: 0x0600005D RID: 93
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(global::System.IFormatProvider formatProvider, string message, bool argument);

		// Token: 0x0600005E RID: 94
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(string message, bool argument);

		// Token: 0x0600005F RID: 95
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(global::System.IFormatProvider formatProvider, string message, char argument);

		// Token: 0x06000060 RID: 96
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(string message, char argument);

		// Token: 0x06000061 RID: 97
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(global::System.IFormatProvider formatProvider, string message, byte argument);

		// Token: 0x06000062 RID: 98
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(string message, byte argument);

		// Token: 0x06000063 RID: 99
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(global::System.IFormatProvider formatProvider, string message, string argument);

		// Token: 0x06000064 RID: 100
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(string message, string argument);

		// Token: 0x06000065 RID: 101
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(global::System.IFormatProvider formatProvider, string message, int argument);

		// Token: 0x06000066 RID: 102
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(string message, int argument);

		// Token: 0x06000067 RID: 103
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(global::System.IFormatProvider formatProvider, string message, long argument);

		// Token: 0x06000068 RID: 104
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(string message, long argument);

		// Token: 0x06000069 RID: 105
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(global::System.IFormatProvider formatProvider, string message, float argument);

		// Token: 0x0600006A RID: 106
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(string message, float argument);

		// Token: 0x0600006B RID: 107
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(global::System.IFormatProvider formatProvider, string message, double argument);

		// Token: 0x0600006C RID: 108
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(string message, double argument);

		// Token: 0x0600006D RID: 109
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(global::System.IFormatProvider formatProvider, string message, decimal argument);

		// Token: 0x0600006E RID: 110
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(string message, decimal argument);

		// Token: 0x0600006F RID: 111
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(global::System.IFormatProvider formatProvider, string message, object argument);

		// Token: 0x06000070 RID: 112
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(string message, object argument);

		// Token: 0x06000071 RID: 113
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(global::System.IFormatProvider formatProvider, string message, sbyte argument);

		// Token: 0x06000072 RID: 114
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(string message, sbyte argument);

		// Token: 0x06000073 RID: 115
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(global::System.IFormatProvider formatProvider, string message, uint argument);

		// Token: 0x06000074 RID: 116
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(string message, uint argument);

		// Token: 0x06000075 RID: 117
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(global::System.IFormatProvider formatProvider, string message, ulong argument);

		// Token: 0x06000076 RID: 118
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(string message, ulong argument);

		// Token: 0x06000077 RID: 119
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void Warn(object value);

		// Token: 0x06000078 RID: 120
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void Warn(global::System.IFormatProvider formatProvider, object value);

		// Token: 0x06000079 RID: 121
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(string message, object arg1, object arg2);

		// Token: 0x0600007A RID: 122
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(string message, object arg1, object arg2, object arg3);

		// Token: 0x0600007B RID: 123
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(global::System.IFormatProvider formatProvider, string message, bool argument);

		// Token: 0x0600007C RID: 124
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(string message, bool argument);

		// Token: 0x0600007D RID: 125
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(global::System.IFormatProvider formatProvider, string message, char argument);

		// Token: 0x0600007E RID: 126
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(string message, char argument);

		// Token: 0x0600007F RID: 127
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(global::System.IFormatProvider formatProvider, string message, byte argument);

		// Token: 0x06000080 RID: 128
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(string message, byte argument);

		// Token: 0x06000081 RID: 129
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(global::System.IFormatProvider formatProvider, string message, string argument);

		// Token: 0x06000082 RID: 130
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(string message, string argument);

		// Token: 0x06000083 RID: 131
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(global::System.IFormatProvider formatProvider, string message, int argument);

		// Token: 0x06000084 RID: 132
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(string message, int argument);

		// Token: 0x06000085 RID: 133
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(global::System.IFormatProvider formatProvider, string message, long argument);

		// Token: 0x06000086 RID: 134
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(string message, long argument);

		// Token: 0x06000087 RID: 135
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(global::System.IFormatProvider formatProvider, string message, float argument);

		// Token: 0x06000088 RID: 136
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(string message, float argument);

		// Token: 0x06000089 RID: 137
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(global::System.IFormatProvider formatProvider, string message, double argument);

		// Token: 0x0600008A RID: 138
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(string message, double argument);

		// Token: 0x0600008B RID: 139
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(global::System.IFormatProvider formatProvider, string message, decimal argument);

		// Token: 0x0600008C RID: 140
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(string message, decimal argument);

		// Token: 0x0600008D RID: 141
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(global::System.IFormatProvider formatProvider, string message, object argument);

		// Token: 0x0600008E RID: 142
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(string message, object argument);

		// Token: 0x0600008F RID: 143
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(global::System.IFormatProvider formatProvider, string message, sbyte argument);

		// Token: 0x06000090 RID: 144
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(string message, sbyte argument);

		// Token: 0x06000091 RID: 145
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(global::System.IFormatProvider formatProvider, string message, uint argument);

		// Token: 0x06000092 RID: 146
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(string message, uint argument);

		// Token: 0x06000093 RID: 147
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(global::System.IFormatProvider formatProvider, string message, ulong argument);

		// Token: 0x06000094 RID: 148
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(string message, ulong argument);

		// Token: 0x06000095 RID: 149
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void Error(object value);

		// Token: 0x06000096 RID: 150
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void Error(global::System.IFormatProvider formatProvider, object value);

		// Token: 0x06000097 RID: 151
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(string message, object arg1, object arg2);

		// Token: 0x06000098 RID: 152
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(string message, object arg1, object arg2, object arg3);

		// Token: 0x06000099 RID: 153
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(global::System.IFormatProvider formatProvider, string message, bool argument);

		// Token: 0x0600009A RID: 154
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void Error(string message, bool argument);

		// Token: 0x0600009B RID: 155
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(global::System.IFormatProvider formatProvider, string message, char argument);

		// Token: 0x0600009C RID: 156
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(string message, char argument);

		// Token: 0x0600009D RID: 157
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(global::System.IFormatProvider formatProvider, string message, byte argument);

		// Token: 0x0600009E RID: 158
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void Error(string message, byte argument);

		// Token: 0x0600009F RID: 159
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(global::System.IFormatProvider formatProvider, string message, string argument);

		// Token: 0x060000A0 RID: 160
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(string message, string argument);

		// Token: 0x060000A1 RID: 161
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(global::System.IFormatProvider formatProvider, string message, int argument);

		// Token: 0x060000A2 RID: 162
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(string message, int argument);

		// Token: 0x060000A3 RID: 163
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(global::System.IFormatProvider formatProvider, string message, long argument);

		// Token: 0x060000A4 RID: 164
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(string message, long argument);

		// Token: 0x060000A5 RID: 165
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(global::System.IFormatProvider formatProvider, string message, float argument);

		// Token: 0x060000A6 RID: 166
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void Error(string message, float argument);

		// Token: 0x060000A7 RID: 167
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(global::System.IFormatProvider formatProvider, string message, double argument);

		// Token: 0x060000A8 RID: 168
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(string message, double argument);

		// Token: 0x060000A9 RID: 169
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(global::System.IFormatProvider formatProvider, string message, decimal argument);

		// Token: 0x060000AA RID: 170
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(string message, decimal argument);

		// Token: 0x060000AB RID: 171
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(global::System.IFormatProvider formatProvider, string message, object argument);

		// Token: 0x060000AC RID: 172
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(string message, object argument);

		// Token: 0x060000AD RID: 173
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(global::System.IFormatProvider formatProvider, string message, sbyte argument);

		// Token: 0x060000AE RID: 174
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(string message, sbyte argument);

		// Token: 0x060000AF RID: 175
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(global::System.IFormatProvider formatProvider, string message, uint argument);

		// Token: 0x060000B0 RID: 176
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(string message, uint argument);

		// Token: 0x060000B1 RID: 177
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(global::System.IFormatProvider formatProvider, string message, ulong argument);

		// Token: 0x060000B2 RID: 178
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(string message, ulong argument);

		// Token: 0x060000B3 RID: 179
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void Fatal(object value);

		// Token: 0x060000B4 RID: 180
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void Fatal(global::System.IFormatProvider formatProvider, object value);

		// Token: 0x060000B5 RID: 181
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(string message, object arg1, object arg2);

		// Token: 0x060000B6 RID: 182
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(string message, object arg1, object arg2, object arg3);

		// Token: 0x060000B7 RID: 183
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(global::System.IFormatProvider formatProvider, string message, bool argument);

		// Token: 0x060000B8 RID: 184
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(string message, bool argument);

		// Token: 0x060000B9 RID: 185
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(global::System.IFormatProvider formatProvider, string message, char argument);

		// Token: 0x060000BA RID: 186
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(string message, char argument);

		// Token: 0x060000BB RID: 187
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(global::System.IFormatProvider formatProvider, string message, byte argument);

		// Token: 0x060000BC RID: 188
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(string message, byte argument);

		// Token: 0x060000BD RID: 189
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(global::System.IFormatProvider formatProvider, string message, string argument);

		// Token: 0x060000BE RID: 190
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(string message, string argument);

		// Token: 0x060000BF RID: 191
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(global::System.IFormatProvider formatProvider, string message, int argument);

		// Token: 0x060000C0 RID: 192
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(string message, int argument);

		// Token: 0x060000C1 RID: 193
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(global::System.IFormatProvider formatProvider, string message, long argument);

		// Token: 0x060000C2 RID: 194
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(string message, long argument);

		// Token: 0x060000C3 RID: 195
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(global::System.IFormatProvider formatProvider, string message, float argument);

		// Token: 0x060000C4 RID: 196
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(string message, float argument);

		// Token: 0x060000C5 RID: 197
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(global::System.IFormatProvider formatProvider, string message, double argument);

		// Token: 0x060000C6 RID: 198
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(string message, double argument);

		// Token: 0x060000C7 RID: 199
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(global::System.IFormatProvider formatProvider, string message, decimal argument);

		// Token: 0x060000C8 RID: 200
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void Fatal(string message, decimal argument);

		// Token: 0x060000C9 RID: 201
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(global::System.IFormatProvider formatProvider, string message, object argument);

		// Token: 0x060000CA RID: 202
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(string message, object argument);

		// Token: 0x060000CB RID: 203
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(global::System.IFormatProvider formatProvider, string message, sbyte argument);

		// Token: 0x060000CC RID: 204
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(string message, sbyte argument);

		// Token: 0x060000CD RID: 205
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(global::System.IFormatProvider formatProvider, string message, uint argument);

		// Token: 0x060000CE RID: 206
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(string message, uint argument);

		// Token: 0x060000CF RID: 207
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(global::System.IFormatProvider formatProvider, string message, ulong argument);

		// Token: 0x060000D0 RID: 208
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(string message, ulong argument);

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000D1 RID: 209
		bool IsTraceEnabled { get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000D2 RID: 210
		bool IsDebugEnabled { get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000D3 RID: 211
		bool IsInfoEnabled { get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000D4 RID: 212
		bool IsWarnEnabled { get; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000D5 RID: 213
		bool IsErrorEnabled { get; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000D6 RID: 214
		bool IsFatalEnabled { get; }

		// Token: 0x060000D7 RID: 215
		void Trace<T>(T value);

		// Token: 0x060000D8 RID: 216
		void Trace<T>(global::System.IFormatProvider formatProvider, T value);

		// Token: 0x060000D9 RID: 217
		void Trace(global::NLog.LogMessageGenerator messageFunc);

		// Token: 0x060000DA RID: 218
		[global::System.Obsolete("Use Trace(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void TraceException([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception);

		// Token: 0x060000DB RID: 219
		void Trace(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message);

		// Token: 0x060000DC RID: 220
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x060000DD RID: 221
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(global::System.Exception exception, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x060000DE RID: 222
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x060000DF RID: 223
		void Trace([global::System.ComponentModel.Localizable(false)] string message);

		// Token: 0x060000E0 RID: 224
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace([global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x060000E1 RID: 225
		[global::System.Obsolete("Use Trace(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void Trace([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception);

		// Token: 0x060000E2 RID: 226
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace<TArgument>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument argument);

		// Token: 0x060000E3 RID: 227
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace<TArgument>([global::System.ComponentModel.Localizable(false)] string message, TArgument argument);

		// Token: 0x060000E4 RID: 228
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace<TArgument1, TArgument2>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);

		// Token: 0x060000E5 RID: 229
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace<TArgument1, TArgument2>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);

		// Token: 0x060000E6 RID: 230
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace<TArgument1, TArgument2, TArgument3>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);

		// Token: 0x060000E7 RID: 231
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Trace<TArgument1, TArgument2, TArgument3>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);

		// Token: 0x060000E8 RID: 232
		void Debug<T>(T value);

		// Token: 0x060000E9 RID: 233
		void Debug<T>(global::System.IFormatProvider formatProvider, T value);

		// Token: 0x060000EA RID: 234
		void Debug(global::NLog.LogMessageGenerator messageFunc);

		// Token: 0x060000EB RID: 235
		[global::System.Obsolete("Use Debug(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void DebugException([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception);

		// Token: 0x060000EC RID: 236
		void Debug(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message);

		// Token: 0x060000ED RID: 237
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x060000EE RID: 238
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(global::System.Exception exception, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x060000EF RID: 239
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x060000F0 RID: 240
		void Debug([global::System.ComponentModel.Localizable(false)] string message);

		// Token: 0x060000F1 RID: 241
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug([global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x060000F2 RID: 242
		[global::System.Obsolete("Use Debug(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void Debug([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception);

		// Token: 0x060000F3 RID: 243
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug<TArgument>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument argument);

		// Token: 0x060000F4 RID: 244
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug<TArgument>([global::System.ComponentModel.Localizable(false)] string message, TArgument argument);

		// Token: 0x060000F5 RID: 245
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug<TArgument1, TArgument2>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);

		// Token: 0x060000F6 RID: 246
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug<TArgument1, TArgument2>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);

		// Token: 0x060000F7 RID: 247
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug<TArgument1, TArgument2, TArgument3>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);

		// Token: 0x060000F8 RID: 248
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Debug<TArgument1, TArgument2, TArgument3>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);

		// Token: 0x060000F9 RID: 249
		void Info<T>(T value);

		// Token: 0x060000FA RID: 250
		void Info<T>(global::System.IFormatProvider formatProvider, T value);

		// Token: 0x060000FB RID: 251
		void Info(global::NLog.LogMessageGenerator messageFunc);

		// Token: 0x060000FC RID: 252
		[global::System.Obsolete("Use Info(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void InfoException([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception);

		// Token: 0x060000FD RID: 253
		void Info(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message);

		// Token: 0x060000FE RID: 254
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x060000FF RID: 255
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(global::System.Exception exception, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x06000100 RID: 256
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x06000101 RID: 257
		void Info([global::System.ComponentModel.Localizable(false)] string message);

		// Token: 0x06000102 RID: 258
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info([global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x06000103 RID: 259
		[global::System.Obsolete("Use Info(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void Info([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception);

		// Token: 0x06000104 RID: 260
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info<TArgument>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument argument);

		// Token: 0x06000105 RID: 261
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info<TArgument>([global::System.ComponentModel.Localizable(false)] string message, TArgument argument);

		// Token: 0x06000106 RID: 262
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info<TArgument1, TArgument2>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);

		// Token: 0x06000107 RID: 263
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info<TArgument1, TArgument2>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);

		// Token: 0x06000108 RID: 264
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info<TArgument1, TArgument2, TArgument3>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);

		// Token: 0x06000109 RID: 265
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Info<TArgument1, TArgument2, TArgument3>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);

		// Token: 0x0600010A RID: 266
		void Warn<T>(T value);

		// Token: 0x0600010B RID: 267
		void Warn<T>(global::System.IFormatProvider formatProvider, T value);

		// Token: 0x0600010C RID: 268
		void Warn(global::NLog.LogMessageGenerator messageFunc);

		// Token: 0x0600010D RID: 269
		[global::System.Obsolete("Use Warn(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void WarnException([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception);

		// Token: 0x0600010E RID: 270
		void Warn(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message);

		// Token: 0x0600010F RID: 271
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x06000110 RID: 272
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(global::System.Exception exception, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x06000111 RID: 273
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x06000112 RID: 274
		void Warn([global::System.ComponentModel.Localizable(false)] string message);

		// Token: 0x06000113 RID: 275
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn([global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x06000114 RID: 276
		[global::System.Obsolete("Use Warn(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void Warn([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception);

		// Token: 0x06000115 RID: 277
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn<TArgument>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument argument);

		// Token: 0x06000116 RID: 278
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn<TArgument>([global::System.ComponentModel.Localizable(false)] string message, TArgument argument);

		// Token: 0x06000117 RID: 279
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn<TArgument1, TArgument2>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);

		// Token: 0x06000118 RID: 280
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn<TArgument1, TArgument2>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);

		// Token: 0x06000119 RID: 281
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn<TArgument1, TArgument2, TArgument3>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);

		// Token: 0x0600011A RID: 282
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Warn<TArgument1, TArgument2, TArgument3>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);

		// Token: 0x0600011B RID: 283
		void Error<T>(T value);

		// Token: 0x0600011C RID: 284
		void Error<T>(global::System.IFormatProvider formatProvider, T value);

		// Token: 0x0600011D RID: 285
		void Error(global::NLog.LogMessageGenerator messageFunc);

		// Token: 0x0600011E RID: 286
		[global::System.Obsolete("Use Error(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void ErrorException([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception);

		// Token: 0x0600011F RID: 287
		void Error(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message);

		// Token: 0x06000120 RID: 288
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x06000121 RID: 289
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(global::System.Exception exception, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x06000122 RID: 290
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x06000123 RID: 291
		void Error([global::System.ComponentModel.Localizable(false)] string message);

		// Token: 0x06000124 RID: 292
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error([global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x06000125 RID: 293
		[global::System.Obsolete("Use Error(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void Error([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception);

		// Token: 0x06000126 RID: 294
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error<TArgument>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument argument);

		// Token: 0x06000127 RID: 295
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error<TArgument>([global::System.ComponentModel.Localizable(false)] string message, TArgument argument);

		// Token: 0x06000128 RID: 296
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error<TArgument1, TArgument2>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);

		// Token: 0x06000129 RID: 297
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error<TArgument1, TArgument2>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);

		// Token: 0x0600012A RID: 298
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error<TArgument1, TArgument2, TArgument3>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);

		// Token: 0x0600012B RID: 299
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Error<TArgument1, TArgument2, TArgument3>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);

		// Token: 0x0600012C RID: 300
		void Fatal<T>(T value);

		// Token: 0x0600012D RID: 301
		void Fatal<T>(global::System.IFormatProvider formatProvider, T value);

		// Token: 0x0600012E RID: 302
		void Fatal(global::NLog.LogMessageGenerator messageFunc);

		// Token: 0x0600012F RID: 303
		[global::System.Obsolete("Use Fatal(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void FatalException([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception);

		// Token: 0x06000130 RID: 304
		void Fatal(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message);

		// Token: 0x06000131 RID: 305
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(global::System.Exception exception, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x06000132 RID: 306
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(global::System.Exception exception, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x06000133 RID: 307
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x06000134 RID: 308
		void Fatal([global::System.ComponentModel.Localizable(false)] string message);

		// Token: 0x06000135 RID: 309
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal([global::System.ComponentModel.Localizable(false)] string message, params object[] args);

		// Token: 0x06000136 RID: 310
		[global::System.Obsolete("Use Fatal(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void Fatal([global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception);

		// Token: 0x06000137 RID: 311
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal<TArgument>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument argument);

		// Token: 0x06000138 RID: 312
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal<TArgument>([global::System.ComponentModel.Localizable(false)] string message, TArgument argument);

		// Token: 0x06000139 RID: 313
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal<TArgument1, TArgument2>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);

		// Token: 0x0600013A RID: 314
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal<TArgument1, TArgument2>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);

		// Token: 0x0600013B RID: 315
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal<TArgument1, TArgument2, TArgument3>(global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);

		// Token: 0x0600013C RID: 316
		[global::NLog.MessageTemplateFormatMethod("message")]
		void Fatal<TArgument1, TArgument2, TArgument3>([global::System.ComponentModel.Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
	}
}
