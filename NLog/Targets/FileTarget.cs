using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using NLog.Common;
using NLog.Config;
using NLog.Internal;
using NLog.Internal.FileAppenders;
using NLog.Layouts;
using NLog.Targets.FileArchiveModes;
using NLog.Time;

namespace NLog.Targets
{
	// Token: 0x0200003A RID: 58
	[global::NLog.Targets.Target("File")]
	public class FileTarget : global::NLog.Targets.TargetWithLayoutHeaderAndFooter, global::NLog.Internal.FileAppenders.ICreateFileParameters
	{
		// Token: 0x0600058C RID: 1420 RVA: 0x0000C710 File Offset: 0x0000A910
		private global::NLog.Targets.IFileArchiveMode GetFileArchiveHelper(string archiveFilePattern)
		{
			global::NLog.Targets.IFileArchiveMode result;
			if ((result = this._fileArchiveHelper) == null)
			{
				result = (this._fileArchiveHelper = global::NLog.Targets.FileArchiveModes.FileArchiveModeFactory.CreateArchiveStyle(archiveFilePattern, this.ArchiveNumbering, this.GetArchiveDateFormatString(this.ArchiveDateFormat), this.ArchiveFileName != null, this.MaxArchiveFiles));
			}
			return result;
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0000C758 File Offset: 0x0000A958
		public FileTarget()
		{
			this.ArchiveNumbering = global::NLog.Targets.ArchiveNumberingMode.Sequence;
			this._maxArchiveFiles = 0;
			this.ConcurrentWriteAttemptDelay = 1;
			this.ArchiveEvery = global::NLog.Targets.FileArchivePeriod.None;
			this.ArchiveAboveSize = -1L;
			this.ConcurrentWriteAttempts = 10;
			this.ConcurrentWrites = true;
			this.Encoding = global::System.Text.Encoding.Default;
			this.BufferSize = 32768;
			this.AutoFlush = true;
			this.FileAttributes = global::NLog.Targets.Win32FileAttributes.Normal;
			this.LineEnding = global::NLog.Targets.LineEndingMode.Default;
			this.EnableFileDelete = true;
			this.OpenFileCacheTimeout = -1;
			this.OpenFileCacheSize = 5;
			this.CreateDirs = true;
			this.ForceManaged = false;
			this.ArchiveDateFormat = string.Empty;
			this._fileAppenderCache = global::NLog.Internal.FileAppenders.FileAppenderCache.Empty;
			this.CleanupFileName = true;
			this.WriteFooterOnArchivingOnly = false;
			base.OptimizeBufferReuse = (base.GetType() == typeof(global::NLog.Targets.FileTarget));
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0000C88A File Offset: 0x0000AA8A
		public FileTarget(string name) : this()
		{
			base.Name = name;
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0000C899 File Offset: 0x0000AA99
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x0000C8AC File Offset: 0x0000AAAC
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Layouts.Layout FileName
		{
			get
			{
				global::NLog.Internal.FilePathLayout fullFileName = this._fullFileName;
				if (fullFileName == null)
				{
					return null;
				}
				return fullFileName.GetLayout();
			}
			set
			{
				this._fullFileName = this.CreateFileNameLayout(value);
				this.ResetFileAppenders("FileName Changed");
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0000C8C6 File Offset: 0x0000AAC6
		private global::NLog.Internal.FilePathLayout CreateFileNameLayout(global::NLog.Layouts.Layout value)
		{
			if (value == null)
			{
				return null;
			}
			return new global::NLog.Internal.FilePathLayout(value, this.CleanupFileName, this.FileNameKind);
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x0000C8DF File Offset: 0x0000AADF
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		[global::System.ComponentModel.DefaultValue(true)]
		public bool CleanupFileName
		{
			get
			{
				return this._cleanupFileName;
			}
			set
			{
				if (this._cleanupFileName != value)
				{
					this._cleanupFileName = value;
					this._fullFileName = this.CreateFileNameLayout(this.FileName);
					this._fullArchiveFileName = this.CreateFileNameLayout(this.ArchiveFileName);
					this.ResetFileAppenders("CleanupFileName Changed");
				}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0000C934 File Offset: 0x0000AB34
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x0000C93C File Offset: 0x0000AB3C
		[global::System.ComponentModel.DefaultValue(global::NLog.Targets.FilePathKind.Unknown)]
		public global::NLog.Targets.FilePathKind FileNameKind
		{
			get
			{
				return this._fileNameKind;
			}
			set
			{
				if (this._fileNameKind != value)
				{
					this._fileNameKind = value;
					this._fullFileName = this.CreateFileNameLayout(this.FileName);
					this.ResetFileAppenders("FileNameKind Changed");
				}
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0000C96B File Offset: 0x0000AB6B
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x0000C973 File Offset: 0x0000AB73
		[global::System.ComponentModel.DefaultValue(true)]
		[global::NLog.Config.Advanced]
		public bool CreateDirs { get; set; }

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x0000C97C File Offset: 0x0000AB7C
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x0000C984 File Offset: 0x0000AB84
		[global::System.ComponentModel.DefaultValue(false)]
		public bool DeleteOldFileOnStartup { get; set; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x0000C98D File Offset: 0x0000AB8D
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x0000C995 File Offset: 0x0000AB95
		[global::System.ComponentModel.DefaultValue(false)]
		[global::NLog.Config.Advanced]
		public bool ReplaceFileContentsOnEachWrite { get; set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x0000C99E File Offset: 0x0000AB9E
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
		[global::System.ComponentModel.DefaultValue(false)]
		public bool KeepFileOpen
		{
			get
			{
				return this._keepFileOpen;
			}
			set
			{
				if (this._keepFileOpen != value)
				{
					this._keepFileOpen = value;
					this.ResetFileAppenders("KeepFileOpen Changed");
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0000C9C3 File Offset: 0x0000ABC3
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x0000C9CB File Offset: 0x0000ABCB
		[global::System.Obsolete("This option will be removed in NLog 5. Marked obsolete on NLog 4.5")]
		[global::System.ComponentModel.DefaultValue(0)]
		public int maxLogFilenames { get; set; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0000C9D4 File Offset: 0x0000ABD4
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x0000C9DC File Offset: 0x0000ABDC
		[global::System.ComponentModel.DefaultValue(true)]
		public bool EnableFileDelete { get; set; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0000C9E5 File Offset: 0x0000ABE5
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x0000C9ED File Offset: 0x0000ABED
		[global::NLog.Config.Advanced]
		public global::NLog.Targets.Win32FileAttributes FileAttributes { get; set; }

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0000C9F6 File Offset: 0x0000ABF6
		bool global::NLog.Internal.FileAppenders.ICreateFileParameters.IsArchivingEnabled
		{
			get
			{
				return this.IsArchivingEnabled;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x0000C9FE File Offset: 0x0000ABFE
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x0000CA06 File Offset: 0x0000AC06
		[global::NLog.Config.Advanced]
		public global::NLog.Targets.LineEndingMode LineEnding
		{
			get
			{
				return this._lineEndingMode;
			}
			set
			{
				this._lineEndingMode = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x0000CA0F File Offset: 0x0000AC0F
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x0000CA17 File Offset: 0x0000AC17
		[global::System.ComponentModel.DefaultValue(true)]
		public bool AutoFlush { get; set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x0000CA20 File Offset: 0x0000AC20
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x0000CA28 File Offset: 0x0000AC28
		[global::System.ComponentModel.DefaultValue(5)]
		[global::NLog.Config.Advanced]
		public int OpenFileCacheSize { get; set; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x0000CA31 File Offset: 0x0000AC31
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x0000CA39 File Offset: 0x0000AC39
		[global::System.ComponentModel.DefaultValue(-1)]
		[global::NLog.Config.Advanced]
		public int OpenFileCacheTimeout { get; set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x0000CA42 File Offset: 0x0000AC42
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x0000CA4A File Offset: 0x0000AC4A
		public int OpenFileFlushTimeout { get; set; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0000CA53 File Offset: 0x0000AC53
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x0000CA5B File Offset: 0x0000AC5B
		[global::System.ComponentModel.DefaultValue(32768)]
		public int BufferSize { get; set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x0000CA64 File Offset: 0x0000AC64
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x0000CA6C File Offset: 0x0000AC6C
		public global::System.Text.Encoding Encoding { get; set; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0000CA75 File Offset: 0x0000AC75
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x0000CA7D File Offset: 0x0000AC7D
		[global::System.ComponentModel.DefaultValue(false)]
		[global::NLog.Config.Advanced]
		public bool DiscardAll { get; set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x0000CA88 File Offset: 0x0000AC88
		// (set) Token: 0x060005B7 RID: 1463 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		[global::System.ComponentModel.DefaultValue(true)]
		public bool ConcurrentWrites
		{
			get
			{
				return this._concurrentWrites ?? true;
			}
			set
			{
				if (this._concurrentWrites != value)
				{
					this._concurrentWrites = new bool?(value);
					this.ResetFileAppenders("ConcurrentWrites Changed");
				}
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x0000CAF6 File Offset: 0x0000ACF6
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x0000CAFE File Offset: 0x0000ACFE
		[global::System.ComponentModel.DefaultValue(false)]
		public bool NetworkWrites { get; set; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x0000CB07 File Offset: 0x0000AD07
		// (set) Token: 0x060005BB RID: 1467 RVA: 0x0000CB0F File Offset: 0x0000AD0F
		[global::System.ComponentModel.DefaultValue(false)]
		public bool WriteBom { get; set; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x0000CB18 File Offset: 0x0000AD18
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x0000CB20 File Offset: 0x0000AD20
		[global::System.ComponentModel.DefaultValue(10)]
		[global::NLog.Config.Advanced]
		public int ConcurrentWriteAttempts { get; set; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x0000CB29 File Offset: 0x0000AD29
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x0000CB31 File Offset: 0x0000AD31
		[global::System.ComponentModel.DefaultValue(1)]
		[global::NLog.Config.Advanced]
		public int ConcurrentWriteAttemptDelay { get; set; }

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x0000CB3A File Offset: 0x0000AD3A
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x0000CB42 File Offset: 0x0000AD42
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ArchiveOldFileOnStartup { get; set; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0000CB4B File Offset: 0x0000AD4B
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x0000CB53 File Offset: 0x0000AD53
		[global::System.ComponentModel.DefaultValue("")]
		public string ArchiveDateFormat
		{
			get
			{
				return this._archiveDateFormat;
			}
			set
			{
				if (this._archiveDateFormat != value)
				{
					this._archiveDateFormat = value;
					this.ResetFileAppenders("ArchiveDateFormat Changed");
				}
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0000CB75 File Offset: 0x0000AD75
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x0000CB7D File Offset: 0x0000AD7D
		public long ArchiveAboveSize
		{
			get
			{
				return this._archiveAboveSize;
			}
			set
			{
				if (this._archiveAboveSize == -1L != (value == -1L))
				{
					this._archiveAboveSize = value;
					this.ResetFileAppenders("ArchiveAboveSize Changed");
					return;
				}
				this._archiveAboveSize = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x0000CBAA File Offset: 0x0000ADAA
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x0000CBB2 File Offset: 0x0000ADB2
		public global::NLog.Targets.FileArchivePeriod ArchiveEvery
		{
			get
			{
				return this._archiveEvery;
			}
			set
			{
				if (this._archiveEvery != value)
				{
					this._archiveEvery = value;
					this.ResetFileAppenders("ArchiveEvery Changed");
				}
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x0000CBCF File Offset: 0x0000ADCF
		// (set) Token: 0x060005C9 RID: 1481 RVA: 0x0000CBD7 File Offset: 0x0000ADD7
		public global::NLog.Targets.FilePathKind ArchiveFileKind
		{
			get
			{
				return this._archiveFileKind;
			}
			set
			{
				if (this._archiveFileKind != value)
				{
					this._archiveFileKind = value;
					this._fullArchiveFileName = this.CreateFileNameLayout(this.ArchiveFileName);
					this.ResetFileAppenders("ArchiveFileKind Changed");
				}
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x0000CC06 File Offset: 0x0000AE06
		// (set) Token: 0x060005CB RID: 1483 RVA: 0x0000CC1D File Offset: 0x0000AE1D
		public global::NLog.Layouts.Layout ArchiveFileName
		{
			get
			{
				if (this._fullArchiveFileName == null)
				{
					return null;
				}
				return this._fullArchiveFileName.GetLayout();
			}
			set
			{
				this._fullArchiveFileName = this.CreateFileNameLayout(value);
				this.ResetFileAppenders("ArchiveFileName Changed");
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x0000CC37 File Offset: 0x0000AE37
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x0000CC3F File Offset: 0x0000AE3F
		[global::System.ComponentModel.DefaultValue(0)]
		public int MaxArchiveFiles
		{
			get
			{
				return this._maxArchiveFiles;
			}
			set
			{
				if (this._maxArchiveFiles != value)
				{
					this._maxArchiveFiles = value;
					this.ResetFileAppenders("MaxArchiveFiles Changed");
				}
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x0000CC5C File Offset: 0x0000AE5C
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x0000CC64 File Offset: 0x0000AE64
		public global::NLog.Targets.ArchiveNumberingMode ArchiveNumbering
		{
			get
			{
				return this._archiveNumbering;
			}
			set
			{
				if (this._archiveNumbering != value)
				{
					this._archiveNumbering = value;
					this.ResetFileAppenders("ArchiveNumbering Changed");
				}
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x0000CC81 File Offset: 0x0000AE81
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x0000CC88 File Offset: 0x0000AE88
		public static global::NLog.Targets.IFileCompressor FileCompressor { get; set; } = new global::NLog.Targets.ZipArchiveFileCompressor();

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x0000CC90 File Offset: 0x0000AE90
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x0000CCA4 File Offset: 0x0000AEA4
		[global::System.ComponentModel.DefaultValue(false)]
		public bool EnableArchiveFileCompression
		{
			get
			{
				return this._enableArchiveFileCompression && global::NLog.Targets.FileTarget.FileCompressor != null;
			}
			set
			{
				if (this._enableArchiveFileCompression != value)
				{
					this._enableArchiveFileCompression = value;
					this.ResetFileAppenders("EnableArchiveFileCompression Changed");
				}
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x0000CCC1 File Offset: 0x0000AEC1
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x0000CCC9 File Offset: 0x0000AEC9
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ForceManaged { get; set; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x0000CCD2 File Offset: 0x0000AED2
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x0000CCDA File Offset: 0x0000AEDA
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ForceMutexConcurrentWrites { get; set; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x0000CCE3 File Offset: 0x0000AEE3
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x0000CCEB File Offset: 0x0000AEEB
		[global::System.ComponentModel.DefaultValue(false)]
		public bool WriteFooterOnArchivingOnly { get; set; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x0000CCF4 File Offset: 0x0000AEF4
		protected internal string NewLineChars
		{
			get
			{
				return this._lineEndingMode.NewLineCharacters;
			}
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0000CD04 File Offset: 0x0000AF04
		private void RefreshArchiveFilePatternToWatch(string fileName, global::NLog.LogEventInfo logEvent)
		{
			if (this._fileAppenderCache != null)
			{
				this._fileAppenderCache.CheckCloseAppenders -= this.AutoClosingTimerCallback;
				if (this.KeepFileOpen)
				{
					this._fileAppenderCache.CheckCloseAppenders += this.AutoClosingTimerCallback;
				}
				if (this.IsArchivingEnabled && this.ConcurrentWrites && this.KeepFileOpen)
				{
					string archiveFileNamePattern = this.GetArchiveFileNamePattern(fileName, logEvent);
					string text = (((!string.IsNullOrEmpty(archiveFileNamePattern)) ? this.GetFileArchiveHelper(archiveFileNamePattern) : null) != null) ? this._fileArchiveHelper.GenerateFileNameMask(archiveFileNamePattern) : string.Empty;
					string archiveFilePatternToWatch = (!string.IsNullOrEmpty(text)) ? global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(archiveFileNamePattern), text) : string.Empty;
					this._fileAppenderCache.ArchiveFilePatternToWatch = archiveFilePatternToWatch;
					return;
				}
				this._fileAppenderCache.ArchiveFilePatternToWatch = null;
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0000CDD4 File Offset: 0x0000AFD4
		public void CleanupInitializedFiles()
		{
			this.CleanupInitializedFiles(global::NLog.Time.TimeSource.Current.Time.AddDays(-2.0));
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0000CE04 File Offset: 0x0000B004
		public void CleanupInitializedFiles(global::System.DateTime cleanupThreshold)
		{
			if (global::NLog.Common.InternalLogger.IsTraceEnabled)
			{
				global::NLog.Common.InternalLogger.Trace<string, global::System.DateTime>("FileTarget(Name={0}): Cleanup Initialized Files with cleanupThreshold {1}", base.Name, cleanupThreshold);
			}
			global::System.Collections.Generic.List<string> list = null;
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.DateTime> keyValuePair in this._initializedFiles)
			{
				if (keyValuePair.Value < cleanupThreshold)
				{
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<string>();
					}
					list.Add(keyValuePair.Key);
				}
			}
			if (list != null)
			{
				foreach (string fileName in list)
				{
					this.FinalizeFile(fileName, false);
				}
			}
			global::NLog.Common.InternalLogger.Trace<string>("FileTarget(Name={0}): CleanupInitializedFiles Done", base.Name);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0000CEE4 File Offset: 0x0000B0E4
		protected override void FlushAsync(global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			try
			{
				global::NLog.Common.InternalLogger.Trace<string>("FileTarget(Name={0}): FlushAsync", base.Name);
				this._fileAppenderCache.FlushAppenders();
				asyncContinuation(null);
				global::NLog.Common.InternalLogger.Trace<string>("FileTarget(Name={0}): FlushAsync Done", base.Name);
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Warn(ex, "FileTarget(Name={0}): Exception in FlushAsync", new object[]
				{
					base.Name
				});
				if (ex.MustBeRethrown())
				{
					throw;
				}
				asyncContinuation(ex);
			}
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0000CF64 File Offset: 0x0000B164
		private global::NLog.Internal.FileAppenders.IFileAppenderFactory GetFileAppenderFactory()
		{
			if (this.DiscardAll)
			{
				return global::NLog.Internal.FileAppenders.NullAppender.TheFactory;
			}
			if (!this.KeepFileOpen)
			{
				return global::NLog.Internal.FileAppenders.RetryingMultiProcessFileAppender.TheFactory;
			}
			if (this.NetworkWrites)
			{
				return global::NLog.Internal.FileAppenders.RetryingMultiProcessFileAppender.TheFactory;
			}
			if (this.ConcurrentWrites)
			{
				if (!this.ForceMutexConcurrentWrites && global::NLog.Internal.PlatformDetector.IsDesktopWin32 && !global::NLog.Internal.PlatformDetector.IsMono)
				{
					return global::NLog.Internal.FileAppenders.WindowsMultiProcessFileAppender.TheFactory;
				}
				if (global::NLog.Internal.PlatformDetector.SupportsSharableMutex)
				{
					return global::NLog.Internal.FileAppenders.MutexMultiProcessFileAppender.TheFactory;
				}
				return global::NLog.Internal.FileAppenders.RetryingMultiProcessFileAppender.TheFactory;
			}
			else
			{
				if (this.IsArchivingEnabled)
				{
					return global::NLog.Internal.FileAppenders.CountingSingleProcessFileAppender.TheFactory;
				}
				return global::NLog.Internal.FileAppenders.SingleProcessFileAppender.TheFactory;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x0000CFE5 File Offset: 0x0000B1E5
		private bool IsArchivingEnabled
		{
			get
			{
				return this.ArchiveAboveSize != -1L || this.ArchiveEvery > global::NLog.Targets.FileArchivePeriod.None;
			}
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0000CFFC File Offset: 0x0000B1FC
		protected override void InitializeTarget()
		{
			base.InitializeTarget();
			global::NLog.Internal.FileAppenders.IFileAppenderFactory fileAppenderFactory = this.GetFileAppenderFactory();
			if (global::NLog.Common.InternalLogger.IsTraceEnabled)
			{
				global::NLog.Common.InternalLogger.Trace<string, global::System.Type>("FileTarget(Name={0}): Using appenderFactory: {1}", base.Name, fileAppenderFactory.GetType());
			}
			this._fileAppenderCache = new global::NLog.Internal.FileAppenders.FileAppenderCache(this.OpenFileCacheSize, fileAppenderFactory, this);
			if ((this.OpenFileCacheSize > 0 || this.EnableFileDelete) && (this.OpenFileCacheTimeout > 0 || this.OpenFileFlushTimeout > 0))
			{
				int num = global::System.Math.Min(global::System.Math.Max(this.OpenFileCacheTimeout, 1), global::System.Math.Max(this.OpenFileFlushTimeout, 1)) * 1000;
				global::NLog.Common.InternalLogger.Trace<string>("FileTarget(Name={0}): Start autoClosingTimer", base.Name);
				this._autoClosingTimer = new global::System.Threading.Timer(delegate(object state)
				{
					this.AutoClosingTimerCallback(this, global::System.EventArgs.Empty);
				}, null, num, num);
			}
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0000D0B8 File Offset: 0x0000B2B8
		protected override void CloseTarget()
		{
			base.CloseTarget();
			foreach (string fileName in new global::System.Collections.Generic.List<string>(this._initializedFiles.Keys))
			{
				this.FinalizeFile(fileName, false);
			}
			this._fileArchiveHelper = null;
			global::System.Threading.Timer autoClosingTimer = this._autoClosingTimer;
			if (autoClosingTimer != null)
			{
				global::NLog.Common.InternalLogger.Trace<string>("FileTarget(Name={0}): Stop autoClosingTimer", base.Name);
				this._autoClosingTimer = null;
				autoClosingTimer.WaitForDispose(global::System.TimeSpan.Zero);
			}
			this._fileAppenderCache.CloseAppenders("Dispose");
			this._fileAppenderCache.Dispose();
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0000D16C File Offset: 0x0000B36C
		private void ResetFileAppenders(string reason)
		{
			this._fileArchiveHelper = null;
			if (base.IsInitialized)
			{
				this._fileAppenderCache.CloseAppenders(reason);
				this._initializedFiles.Clear();
			}
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0000D194 File Offset: 0x0000B394
		protected override void Write(global::NLog.LogEventInfo logEvent)
		{
			string fullFileName = this.GetFullFileName(logEvent);
			if (base.OptimizeBufferReuse)
			{
				using (global::NLog.Internal.ReusableObjectCreator<global::System.IO.MemoryStream>.LockOject lockOject = this._reusableFileWriteStream.Allocate())
				{
					using (global::NLog.Internal.ReusableObjectCreator<global::System.Text.StringBuilder>.LockOject lockOject2 = this.ReusableLayoutBuilder.Allocate())
					{
						using (global::NLog.Internal.ReusableObjectCreator<char[]>.LockOject lockOject3 = this._reusableEncodingBuffer.Allocate())
						{
							this.RenderFormattedMessageToStream(logEvent, lockOject2.Result, lockOject3.Result, lockOject.Result);
						}
					}
					this.ProcessLogEvent(logEvent, fullFileName, new global::System.ArraySegment<byte>(lockOject.Result.GetBuffer(), 0, (int)lockOject.Result.Length));
					return;
				}
			}
			byte[] bytesToWrite = this.GetBytesToWrite(logEvent);
			this.ProcessLogEvent(logEvent, fullFileName, new global::System.ArraySegment<byte>(bytesToWrite));
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x0000D284 File Offset: 0x0000B484
		internal string GetFullFileName(global::NLog.LogEventInfo logEvent)
		{
			if (this._fullFileName == null)
			{
				return null;
			}
			if (base.OptimizeBufferReuse)
			{
				using (global::NLog.Internal.ReusableObjectCreator<global::System.Text.StringBuilder>.LockOject lockOject = this.ReusableLayoutBuilder.Allocate())
				{
					return this._fullFileName.RenderWithBuilder(logEvent, lockOject.Result);
				}
			}
			return this._fullFileName.Render(logEvent);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		[global::System.Obsolete("Instead override Write(IList<AsyncLogEventInfo> logEvents. Marked obsolete on NLog 4.5")]
		protected override void Write(global::NLog.Common.AsyncLogEventInfo[] logEvents)
		{
			this.Write(logEvents);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0000D2FC File Offset: 0x0000B4FC
		protected override void Write(global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo> logEvents)
		{
			if (this._getFullFileNameDelegate == null)
			{
				this._getFullFileNameDelegate = ((global::NLog.Common.AsyncLogEventInfo c) => this.GetFullFileName(c.LogEvent));
			}
			global::NLog.Internal.SortHelpers.ReadOnlySingleBucketDictionary<string, global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo>> readOnlySingleBucketDictionary = logEvents.BucketSort(this._getFullFileNameDelegate);
			using (global::NLog.Internal.ReusableObjectCreator<global::System.IO.MemoryStream>.LockOject lockOject = (base.OptimizeBufferReuse && logEvents.Count <= 1000) ? this._reusableAsyncFileWriteStream.Allocate() : this._reusableAsyncFileWriteStream.None)
			{
				using (global::System.IO.MemoryStream memoryStream = (lockOject.Result != null) ? null : new global::System.IO.MemoryStream())
				{
					global::System.IO.MemoryStream memoryStream2 = memoryStream ?? lockOject.Result;
					foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo>> keyValuePair in readOnlySingleBucketDictionary)
					{
						string key = keyValuePair.Key;
						memoryStream2.SetLength(0L);
						memoryStream2.Position = 0L;
						global::NLog.LogEventInfo logEventInfo = null;
						int count = keyValuePair.Value.Count;
						using (global::NLog.Internal.ReusableObjectCreator<global::System.Text.StringBuilder>.LockOject lockOject2 = base.OptimizeBufferReuse ? this.ReusableLayoutBuilder.Allocate() : this.ReusableLayoutBuilder.None)
						{
							using (global::NLog.Internal.ReusableObjectCreator<char[]>.LockOject lockOject3 = base.OptimizeBufferReuse ? this._reusableEncodingBuffer.Allocate() : this._reusableEncodingBuffer.None)
							{
								using (global::NLog.Internal.ReusableObjectCreator<global::System.IO.MemoryStream>.LockOject lockOject4 = base.OptimizeBufferReuse ? this._reusableFileWriteStream.Allocate() : this._reusableFileWriteStream.None)
								{
									for (int i = 0; i < count; i++)
									{
										global::NLog.Common.AsyncLogEventInfo asyncLogEventInfo = keyValuePair.Value[i];
										if (logEventInfo == null)
										{
											logEventInfo = asyncLogEventInfo.LogEvent;
										}
										if (lockOject2.Result != null && lockOject4.Result != null)
										{
											lockOject4.Result.Position = 0L;
											lockOject4.Result.SetLength(0L);
											lockOject2.Result.ClearBuilder();
											this.RenderFormattedMessageToStream(asyncLogEventInfo.LogEvent, lockOject2.Result, lockOject3.Result, lockOject4.Result);
											memoryStream2.Write(lockOject4.Result.GetBuffer(), 0, (int)lockOject4.Result.Length);
										}
										else
										{
											byte[] bytesToWrite = this.GetBytesToWrite(asyncLogEventInfo.LogEvent);
											if (memoryStream2.Capacity == 0)
											{
												memoryStream2.Capacity = this.GetMemoryStreamInitialSize(keyValuePair.Value.Count, bytesToWrite.Length);
											}
											memoryStream2.Write(bytesToWrite, 0, bytesToWrite.Length);
										}
									}
								}
							}
						}
						global::System.Exception exception;
						this.FlushCurrentFileWrites(key, logEventInfo, memoryStream2, out exception);
						for (int j = 0; j < count; j++)
						{
							keyValuePair.Value[j].Continuation(exception);
						}
					}
				}
			}
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0000D644 File Offset: 0x0000B844
		private int GetMemoryStreamInitialSize(int eventsCount, int firstEventSize)
		{
			if (eventsCount > 10)
			{
				return ((eventsCount + 1) * firstEventSize / 1024 + 1) * 1024;
			}
			if (eventsCount > 1)
			{
				return (1 + eventsCount) * firstEventSize;
			}
			return firstEventSize;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0000D66C File Offset: 0x0000B86C
		private void ProcessLogEvent(global::NLog.LogEventInfo logEvent, string fileName, global::System.ArraySegment<byte> bytesToWrite)
		{
			global::System.DateTime dateTime = this.InitializeFile(fileName, logEvent);
			bool flag = dateTime == global::System.DateTime.MinValue;
			if (flag && fileName == this._previousLogFileName && this._previousLogEventTimestamp != null)
			{
				dateTime = this._previousLogEventTimestamp.Value;
			}
			if (this.TryArchiveFile(fileName, logEvent, bytesToWrite.Count, dateTime, flag))
			{
				flag = (this.InitializeFile(fileName, logEvent) == global::System.DateTime.MinValue);
			}
			this.WriteToFile(fileName, bytesToWrite, flag);
			this._previousLogFileName = fileName;
			this._previousLogEventTimestamp = new global::System.DateTime?(logEvent.TimeStamp);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0000D6FF File Offset: 0x0000B8FF
		protected virtual string GetFormattedMessage(global::NLog.LogEventInfo logEvent)
		{
			return this.Layout.Render(logEvent);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0000D710 File Offset: 0x0000B910
		protected virtual byte[] GetBytesToWrite(global::NLog.LogEventInfo logEvent)
		{
			string formattedMessage = this.GetFormattedMessage(logEvent);
			int byteCount = this.Encoding.GetByteCount(formattedMessage);
			int byteCount2 = this.Encoding.GetByteCount(this.NewLineChars);
			byte[] array = new byte[byteCount + byteCount2];
			this.Encoding.GetBytes(formattedMessage, 0, formattedMessage.Length, array, 0);
			this.Encoding.GetBytes(this.NewLineChars, 0, this.NewLineChars.Length, array, byteCount);
			return this.TransformBytes(array);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0000D78A File Offset: 0x0000B98A
		protected virtual byte[] TransformBytes(byte[] value)
		{
			return value;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0000D78D File Offset: 0x0000B98D
		protected virtual void RenderFormattedMessageToStream(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder formatBuilder, char[] transformBuffer, global::System.IO.MemoryStream streamTarget)
		{
			this.RenderFormattedMessage(logEvent, formatBuilder);
			formatBuilder.Append(this.NewLineChars);
			this.TransformBuilderToStream(logEvent, formatBuilder, transformBuffer, streamTarget);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0000D7AF File Offset: 0x0000B9AF
		protected virtual void RenderFormattedMessage(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
		{
			this.Layout.RenderAppendBuilder(logEvent, target, false);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0000D7BF File Offset: 0x0000B9BF
		private void TransformBuilderToStream(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder builder, char[] transformBuffer, global::System.IO.MemoryStream workStream)
		{
			builder.CopyToStream(workStream, this.Encoding, transformBuffer);
			this.TransformStream(logEvent, workStream);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0000D7D9 File Offset: 0x0000B9D9
		protected virtual void TransformStream(global::NLog.LogEventInfo logEvent, global::System.IO.MemoryStream stream)
		{
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0000D7DC File Offset: 0x0000B9DC
		private void FlushCurrentFileWrites(string currentFileName, global::NLog.LogEventInfo firstLogEvent, global::System.IO.MemoryStream ms, out global::System.Exception lastException)
		{
			lastException = null;
			try
			{
				if (currentFileName != null)
				{
					global::System.ArraySegment<byte> bytesToWrite = new global::System.ArraySegment<byte>(ms.GetBuffer(), 0, (int)ms.Length);
					this.ProcessLogEvent(firstLogEvent, currentFileName, bytesToWrite);
				}
			}
			catch (global::System.Exception ex)
			{
				if (ex.MustBeRethrown())
				{
					throw;
				}
				lastException = ex;
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0000D834 File Offset: 0x0000BA34
		private void ArchiveFile(string fileName, string archiveFileName)
		{
			string directoryName = global::System.IO.Path.GetDirectoryName(archiveFileName);
			if (!global::System.IO.Directory.Exists(directoryName))
			{
				global::System.IO.Directory.CreateDirectory(directoryName);
			}
			if (string.Equals(fileName, archiveFileName, global::System.StringComparison.OrdinalIgnoreCase))
			{
				global::NLog.Common.InternalLogger.Info<string, string>("FileTarget(Name={0}): Archiving {1} skipped as ArchiveFileName equals FileName", base.Name, fileName);
				return;
			}
			if (this.EnableArchiveFileCompression)
			{
				global::NLog.Common.InternalLogger.Info<string, string, string>("FileTarget(Name={0}): Archiving {1} to compressed {2}", base.Name, fileName, archiveFileName);
				global::NLog.Targets.FileTarget.FileCompressor.CompressFile(fileName, archiveFileName);
				this.DeleteAndWaitForFileDelete(fileName);
				return;
			}
			global::NLog.Common.InternalLogger.Info<string, string, string>("FileTarget(Name={0}): Archiving {1} to {2}", base.Name, fileName, archiveFileName);
			if (global::System.IO.File.Exists(archiveFileName))
			{
				global::NLog.Common.InternalLogger.Info<string, string>("FileTarget(Name={0}): Already exists, append to {1}", base.Name, archiveFileName);
				global::System.IO.FileShare fileShare = global::System.IO.FileShare.ReadWrite;
				if (this.EnableFileDelete)
				{
					fileShare |= global::System.IO.FileShare.Delete;
				}
				using (global::System.IO.FileStream fileStream = global::System.IO.File.Open(fileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.ReadWrite, fileShare))
				{
					using (global::System.IO.FileStream fileStream2 = global::System.IO.File.Open(archiveFileName, global::System.IO.FileMode.Append))
					{
						fileStream.CopyAndSkipBom(fileStream2, this.Encoding);
						fileStream.SetLength(0L);
						if (this.EnableFileDelete && !this.DeleteOldArchiveFile(fileName))
						{
							fileShare &= ~global::System.IO.FileShare.Delete;
						}
						fileStream.Close();
						fileStream2.Flush(true);
					}
				}
				if ((fileShare & global::System.IO.FileShare.Delete) == global::System.IO.FileShare.None)
				{
					this.DeleteOldArchiveFile(fileName);
					return;
				}
			}
			else
			{
				try
				{
					global::NLog.Common.InternalLogger.Debug<string, string, string>("FileTarget(Name={0}): Move file from '{1}' to '{2}'", base.Name, fileName, archiveFileName);
					global::System.IO.File.Move(fileName, archiveFileName);
				}
				catch (global::System.IO.IOException ex)
				{
					if (this.KeepFileOpen && !this.ConcurrentWrites)
					{
						throw;
					}
					if (!this.EnableFileDelete && this.KeepFileOpen)
					{
						throw;
					}
					if (!global::NLog.Internal.PlatformDetector.SupportsSharableMutex)
					{
						throw;
					}
					global::NLog.Common.InternalLogger.Warn(ex, "FileTarget(Name={0}): Archiving failed. Checking for retry move of {1} to {2}.", new object[]
					{
						base.Name,
						fileName,
						archiveFileName
					});
					if (!global::System.IO.File.Exists(fileName) || global::System.IO.File.Exists(archiveFileName))
					{
						throw;
					}
					global::NLog.Common.AsyncHelpers.WaitForDelay(global::System.TimeSpan.FromMilliseconds(50.0));
					if (!global::System.IO.File.Exists(fileName) || global::System.IO.File.Exists(archiveFileName))
					{
						throw;
					}
					global::NLog.Common.InternalLogger.Debug<string, string, string>("FileTarget(Name={0}): Archiving retrying move of {1} to {2}.", base.Name, fileName, archiveFileName);
					global::System.IO.File.Move(fileName, archiveFileName);
				}
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0000DA38 File Offset: 0x0000BC38
		private bool DeleteOldArchiveFile(string fileName)
		{
			bool result;
			try
			{
				global::NLog.Common.InternalLogger.Info<string, string>("FileTarget(Name={0}): Deleting old archive file: '{1}'.", base.Name, fileName);
				global::System.IO.File.Delete(fileName);
				result = true;
			}
			catch (global::System.IO.DirectoryNotFoundException ex)
			{
				global::NLog.Common.InternalLogger.Debug(ex, "FileTarget(Name={0}): Failed to delete old log file '{1}' as directory is missing.", new object[]
				{
					base.Name,
					fileName
				});
				result = false;
			}
			catch (global::System.Exception ex2)
			{
				global::NLog.Common.InternalLogger.Warn(ex2, "FileTarget(Name={0}): Failed to delete old archive file: '{1}'.", new object[]
				{
					base.Name,
					fileName
				});
				if (ex2.MustBeRethrown())
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0000DACC File Offset: 0x0000BCCC
		private void DeleteAndWaitForFileDelete(string fileName)
		{
			try
			{
				global::NLog.Common.InternalLogger.Trace<string, string>("FileTarget(Name={0}): Waiting for file delete of '{1}' for 12 sec", base.Name, fileName);
				global::System.DateTime creationTime = new global::System.IO.FileInfo(fileName).CreationTime;
				if (this.DeleteOldArchiveFile(fileName) && global::System.IO.File.Exists(fileName))
				{
					for (int i = 0; i < 120; i++)
					{
						global::NLog.Common.AsyncHelpers.WaitForDelay(global::System.TimeSpan.FromMilliseconds(100.0));
						global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(fileName);
						if (!fileInfo.Exists || fileInfo.CreationTime != creationTime)
						{
							return;
						}
					}
					global::NLog.Common.InternalLogger.Warn<string, string>("FileTarget(Name={0}): Timeout while deleting old archive file: '{1}'.", base.Name, fileName);
				}
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Warn(ex, "FileTarget(Name={0}): Failed to delete old archive file: '{1}'.", new object[]
				{
					base.Name,
					fileName
				});
				if (ex.MustBeRethrown())
				{
					throw;
				}
			}
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0000DB94 File Offset: 0x0000BD94
		private string GetArchiveDateFormatString(string defaultFormat)
		{
			string text = defaultFormat;
			if (string.IsNullOrEmpty(text))
			{
				switch (this.ArchiveEvery)
				{
				case global::NLog.Targets.FileArchivePeriod.Year:
					return "yyyy";
				case global::NLog.Targets.FileArchivePeriod.Month:
					return "yyyyMM";
				case global::NLog.Targets.FileArchivePeriod.Hour:
					return "yyyyMMddHH";
				case global::NLog.Targets.FileArchivePeriod.Minute:
					return "yyyyMMddHHmm";
				}
				text = "yyyyMMdd";
			}
			return text;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0000DBF8 File Offset: 0x0000BDF8
		private global::System.DateTime? GetArchiveDate(string fileName, global::NLog.LogEventInfo logEvent, global::System.DateTime previousLogEventTimestamp)
		{
			global::System.DateTime? fileLastWriteTimeUtc = this._fileAppenderCache.GetFileLastWriteTimeUtc(fileName);
			global::NLog.Common.InternalLogger.Trace<string, global::System.DateTime?, global::System.DateTime>("FileTarget(Name={0}): Calculating archive date. File-LastModifiedUtc: {1}; Previous LogEvent-TimeStamp: {2}", base.Name, fileLastWriteTimeUtc, previousLogEventTimestamp);
			if (fileLastWriteTimeUtc != null)
			{
				global::System.DateTime dateTime = global::NLog.Time.TimeSource.Current.FromSystemTime(fileLastWriteTimeUtc.Value);
				if (previousLogEventTimestamp != global::System.DateTime.MinValue)
				{
					if (previousLogEventTimestamp > dateTime)
					{
						global::NLog.Common.InternalLogger.Trace<string, global::System.DateTime, global::System.DateTime>("FileTarget(Name={0}): Using previous LogEvent-TimeStamp {1}, because more recent than File-LastModified {2}", base.Name, previousLogEventTimestamp, dateTime);
						return new global::System.DateTime?(previousLogEventTimestamp);
					}
					if (this.PreviousLogOverlappedPeriod(logEvent, previousLogEventTimestamp, dateTime))
					{
						global::NLog.Common.InternalLogger.Trace<string, global::System.DateTime, global::System.DateTime>("FileTarget(Name={0}): Using previous LogEvent-TimeStamp {1}, because archive period is overlapping with File-LastModified {2}", base.Name, previousLogEventTimestamp, dateTime);
						return new global::System.DateTime?(previousLogEventTimestamp);
					}
					if (!this.AutoFlush && this.KeepFileOpen && !this.ConcurrentWrites && !this.NetworkWrites && previousLogEventTimestamp < dateTime)
					{
						global::NLog.Common.InternalLogger.Trace<string, global::System.DateTime, global::System.DateTime>("FileTarget(Name={0}): Using previous LogEvent-TimeStamp {1}, because AutoFlush=false affects File-LastModified {2}", base.Name, previousLogEventTimestamp, dateTime);
						return new global::System.DateTime?(previousLogEventTimestamp);
					}
				}
				global::NLog.Common.InternalLogger.Trace<string, global::System.DateTime>("FileTarget(Name={0}): Using last write time: {1}", base.Name, dateTime);
				return new global::System.DateTime?(dateTime);
			}
			if (previousLogEventTimestamp == global::System.DateTime.MinValue)
			{
				global::NLog.Common.InternalLogger.Info<string, string>("FileTarget(Name={0}): Unable to acquire useful timestamp to archive file: {1}", base.Name, fileName);
				return null;
			}
			return new global::System.DateTime?(previousLogEventTimestamp);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x0000DD20 File Offset: 0x0000BF20
		private bool PreviousLogOverlappedPeriod(global::NLog.LogEventInfo logEvent, global::System.DateTime previousLogEventTimestamp, global::System.DateTime lastFileWrite)
		{
			global::System.DateTime previousLogEventTimestamp2 = previousLogEventTimestamp;
			string archiveDateFormatString = this.GetArchiveDateFormatString(string.Empty);
			string a = lastFileWrite.ToString(archiveDateFormatString, global::System.Globalization.CultureInfo.InvariantCulture);
			string b = logEvent.TimeStamp.ToString(archiveDateFormatString, global::System.Globalization.CultureInfo.InvariantCulture);
			if (a != b)
			{
				return false;
			}
			global::System.DateTime dateTime;
			switch (this.ArchiveEvery)
			{
			case global::NLog.Targets.FileArchivePeriod.Year:
				dateTime = previousLogEventTimestamp2.AddYears(1);
				break;
			case global::NLog.Targets.FileArchivePeriod.Month:
				dateTime = previousLogEventTimestamp2.AddMonths(1);
				break;
			case global::NLog.Targets.FileArchivePeriod.Day:
				dateTime = previousLogEventTimestamp2.AddDays(1.0);
				break;
			case global::NLog.Targets.FileArchivePeriod.Hour:
				dateTime = previousLogEventTimestamp2.AddHours(1.0);
				break;
			case global::NLog.Targets.FileArchivePeriod.Minute:
				dateTime = previousLogEventTimestamp2.AddMinutes(1.0);
				break;
			case global::NLog.Targets.FileArchivePeriod.Sunday:
				dateTime = global::NLog.Targets.FileTarget.CalculateNextWeekday(previousLogEventTimestamp2, global::System.DayOfWeek.Sunday);
				break;
			case global::NLog.Targets.FileArchivePeriod.Monday:
				dateTime = global::NLog.Targets.FileTarget.CalculateNextWeekday(previousLogEventTimestamp2, global::System.DayOfWeek.Monday);
				break;
			case global::NLog.Targets.FileArchivePeriod.Tuesday:
				dateTime = global::NLog.Targets.FileTarget.CalculateNextWeekday(previousLogEventTimestamp2, global::System.DayOfWeek.Tuesday);
				break;
			case global::NLog.Targets.FileArchivePeriod.Wednesday:
				dateTime = global::NLog.Targets.FileTarget.CalculateNextWeekday(previousLogEventTimestamp2, global::System.DayOfWeek.Wednesday);
				break;
			case global::NLog.Targets.FileArchivePeriod.Thursday:
				dateTime = global::NLog.Targets.FileTarget.CalculateNextWeekday(previousLogEventTimestamp2, global::System.DayOfWeek.Thursday);
				break;
			case global::NLog.Targets.FileArchivePeriod.Friday:
				dateTime = global::NLog.Targets.FileTarget.CalculateNextWeekday(previousLogEventTimestamp2, global::System.DayOfWeek.Friday);
				break;
			case global::NLog.Targets.FileArchivePeriod.Saturday:
				dateTime = global::NLog.Targets.FileTarget.CalculateNextWeekday(previousLogEventTimestamp2, global::System.DayOfWeek.Saturday);
				break;
			default:
				return false;
			}
			string b2 = dateTime.ToString(archiveDateFormatString, global::System.Globalization.CultureInfo.InvariantCulture);
			return a == b2;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0000DE70 File Offset: 0x0000C070
		public static global::System.DateTime CalculateNextWeekday(global::System.DateTime previousLogEventTimestamp, global::System.DayOfWeek dayOfWeek)
		{
			int dayOfWeek2 = (int)previousLogEventTimestamp.DayOfWeek;
			int num = (int)dayOfWeek;
			if (num <= dayOfWeek2)
			{
				num += 7;
			}
			return previousLogEventTimestamp.AddDays((double)(num - dayOfWeek2));
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0000DE9C File Offset: 0x0000C09C
		private void DoAutoArchive(string fileName, global::NLog.LogEventInfo eventInfo, global::System.DateTime previousLogEventTimestamp, bool initializedNewFile)
		{
			global::NLog.Common.InternalLogger.Debug<string, string>("FileTarget(Name={0}): Do archive file: '{1}'", base.Name, fileName);
			global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(fileName);
			if (!fileInfo.Exists)
			{
				global::NLog.Internal.FileAppenders.BaseFileAppender baseFileAppender = this._fileAppenderCache.InvalidateAppender(fileName);
				if (baseFileAppender == null)
				{
					return;
				}
				baseFileAppender.Dispose();
				return;
			}
			else
			{
				string archiveFileNamePattern = this.GetArchiveFileNamePattern(fileName, eventInfo);
				if (string.IsNullOrEmpty(archiveFileNamePattern))
				{
					global::NLog.Common.InternalLogger.Warn<string>("FileTarget(Name={0}): Skip auto archive because archiveFilePattern is NULL", base.Name);
					return;
				}
				global::NLog.Common.InternalLogger.Trace<string, string>("FileTarget(Name={0}): Archive pattern '{1}'", base.Name, archiveFileNamePattern);
				global::NLog.Targets.IFileArchiveMode fileArchiveHelper = this.GetFileArchiveHelper(archiveFileNamePattern);
				global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> existingArchiveFiles = fileArchiveHelper.GetExistingArchiveFiles(archiveFileNamePattern);
				if (this.MaxArchiveFiles == 1)
				{
					global::NLog.Common.InternalLogger.Trace<string>("FileTarget(Name={0}): MaxArchiveFiles = 1", base.Name);
					for (int i = existingArchiveFiles.Count - 1; i >= 0; i--)
					{
						global::NLog.Targets.DateAndSequenceArchive dateAndSequenceArchive = existingArchiveFiles[i];
						if (!string.Equals(dateAndSequenceArchive.FileName, fileInfo.FullName, global::System.StringComparison.OrdinalIgnoreCase))
						{
							this.DeleteOldArchiveFile(dateAndSequenceArchive.FileName);
							existingArchiveFiles.RemoveAt(i);
						}
					}
					if (initializedNewFile && string.Equals(global::System.IO.Path.GetDirectoryName(archiveFileNamePattern), fileInfo.DirectoryName, global::System.StringComparison.OrdinalIgnoreCase))
					{
						this.DeleteOldArchiveFile(fileName);
						return;
					}
				}
				global::System.DateTime? archiveDate = this.GetArchiveDate(fileName, eventInfo, previousLogEventTimestamp);
				global::NLog.Targets.DateAndSequenceArchive dateAndSequenceArchive2 = (archiveDate != null) ? fileArchiveHelper.GenerateArchiveFileName(archiveFileNamePattern, archiveDate.Value, existingArchiveFiles) : null;
				if (dateAndSequenceArchive2 != null)
				{
					if (!initializedNewFile)
					{
						this.FinalizeFile(fileName, true);
					}
					if (string.Equals(global::System.IO.Path.GetDirectoryName(dateAndSequenceArchive2.FileName), fileInfo.DirectoryName, global::System.StringComparison.OrdinalIgnoreCase))
					{
						for (int j = 0; j < existingArchiveFiles.Count; j++)
						{
							if (string.Equals(existingArchiveFiles[j].FileName, fileInfo.FullName, global::System.StringComparison.OrdinalIgnoreCase))
							{
								existingArchiveFiles.RemoveAt(j);
								break;
							}
						}
					}
					existingArchiveFiles.Add(dateAndSequenceArchive2);
					foreach (global::NLog.Targets.DateAndSequenceArchive dateAndSequenceArchive3 in fileArchiveHelper.CheckArchiveCleanup(archiveFileNamePattern, existingArchiveFiles, this.MaxArchiveFiles))
					{
						this.DeleteOldArchiveFile(dateAndSequenceArchive3.FileName);
					}
					this.ArchiveFile(fileInfo.FullName, dateAndSequenceArchive2.FileName);
				}
				return;
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0000E0A8 File Offset: 0x0000C2A8
		private string GetArchiveFileNamePattern(string fileName, global::NLog.LogEventInfo eventInfo)
		{
			if (this._fullArchiveFileName != null)
			{
				return this._fullArchiveFileName.Render(eventInfo);
			}
			if (this.EnableArchiveFileCompression)
			{
				return global::System.IO.Path.ChangeExtension(fileName, ".zip");
			}
			return fileName;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0000E0D4 File Offset: 0x0000C2D4
		private bool TryArchiveFile(string fileName, global::NLog.LogEventInfo ev, int upcomingWriteSize, global::System.DateTime previousLogEventTimestamp, bool initializedNewFile)
		{
			if (!this.IsArchivingEnabled)
			{
				return false;
			}
			string text = string.Empty;
			global::NLog.Internal.FileAppenders.BaseFileAppender baseFileAppender = null;
			try
			{
				text = this.GetArchiveFileName(fileName, ev, upcomingWriteSize, previousLogEventTimestamp);
				if (!string.IsNullOrEmpty(text))
				{
					global::NLog.Common.InternalLogger.Trace<string, string>("FileTarget(Name={0}): Archive attempt for file '{1}'", base.Name, text);
					baseFileAppender = this._fileAppenderCache.InvalidateAppender(fileName);
					if (fileName != text)
					{
						global::NLog.Internal.FileAppenders.BaseFileAppender baseFileAppender2 = this._fileAppenderCache.InvalidateAppender(text);
						baseFileAppender = (baseFileAppender ?? baseFileAppender2);
					}
					if (!string.IsNullOrEmpty(this._previousLogFileName) && this._previousLogFileName != text && this._previousLogFileName != fileName)
					{
						global::NLog.Internal.FileAppenders.BaseFileAppender baseFileAppender3 = this._fileAppenderCache.InvalidateAppender(this._previousLogFileName);
						baseFileAppender = (baseFileAppender ?? baseFileAppender3);
					}
					this._fileAppenderCache.InvalidateAppendersForArchivedFiles();
				}
				else
				{
					this._fileAppenderCache.InvalidateAppendersForArchivedFiles();
				}
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Warn(ex, "FileTarget(Name={0}): Failed to check archive for file '{1}'.", new object[]
				{
					base.Name,
					fileName
				});
				if (ex.MustBeRethrown())
				{
					throw;
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				try
				{
					try
					{
						global::NLog.Internal.FileAppenders.BaseMutexFileAppender baseMutexFileAppender;
						if ((baseMutexFileAppender = (baseFileAppender as global::NLog.Internal.FileAppenders.BaseMutexFileAppender)) != null)
						{
							global::System.Threading.Mutex archiveMutex = baseMutexFileAppender.ArchiveMutex;
							if (archiveMutex != null)
							{
								archiveMutex.WaitOne();
							}
						}
						else if (!this.KeepFileOpen || this.ConcurrentWrites)
						{
							global::NLog.Common.InternalLogger.Info<string, string>("FileTarget(Name={0}): Archive mutex not available: {1}", base.Name, text);
						}
					}
					catch (global::System.Threading.AbandonedMutexException)
					{
					}
					string archiveFileName = this.GetArchiveFileName(fileName, ev, upcomingWriteSize, previousLogEventTimestamp);
					if (string.IsNullOrEmpty(archiveFileName))
					{
						global::NLog.Common.InternalLogger.Trace<string, string>("FileTarget(Name={0}): Archive already performed for file '{1}'", base.Name, text);
						if (text != fileName)
						{
							this._initializedFiles.Remove(fileName);
						}
						this._initializedFiles.Remove(text);
					}
					else
					{
						text = archiveFileName;
						this.DoAutoArchive(text, ev, previousLogEventTimestamp, initializedNewFile);
						this._initializedFiles.Remove(text);
					}
					if (this._previousLogFileName == text)
					{
						this._previousLogFileName = null;
						this._previousLogEventTimestamp = null;
					}
					return true;
				}
				catch (global::System.Exception ex2)
				{
					global::NLog.Common.InternalLogger.Warn(ex2, "FileTarget(Name={0}): Failed to archive file '{1}'.", new object[]
					{
						base.Name,
						text
					});
					if (ex2.MustBeRethrown())
					{
						throw;
					}
				}
				finally
				{
					global::NLog.Internal.FileAppenders.BaseMutexFileAppender baseMutexFileAppender2;
					if ((baseMutexFileAppender2 = (baseFileAppender as global::NLog.Internal.FileAppenders.BaseMutexFileAppender)) != null)
					{
						global::System.Threading.Mutex archiveMutex2 = baseMutexFileAppender2.ArchiveMutex;
						if (archiveMutex2 != null)
						{
							archiveMutex2.ReleaseMutex();
						}
					}
					if (baseFileAppender != null)
					{
						baseFileAppender.Dispose();
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0000E36C File Offset: 0x0000C56C
		private string GetArchiveFileName(string fileName, global::NLog.LogEventInfo ev, int upcomingWriteSize, global::System.DateTime previousLogEventTimestamp)
		{
			if (fileName != null || this._previousLogFileName != null)
			{
				return this.GetArchiveFileNameBasedOnFileSize(fileName, upcomingWriteSize) ?? this.GetArchiveFileNameBasedOnTime(fileName, ev, previousLogEventTimestamp);
			}
			return null;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0000E398 File Offset: 0x0000C598
		private string GetPotentialFileForArchiving(string fileName)
		{
			if (string.Equals(fileName, this._previousLogFileName, global::System.StringComparison.OrdinalIgnoreCase))
			{
				return fileName;
			}
			if (string.IsNullOrEmpty(this._previousLogFileName))
			{
				return fileName;
			}
			if (string.IsNullOrEmpty(fileName))
			{
				return this._previousLogFileName;
			}
			if (this._fileAppenderCache.GetFileLength(fileName) == null)
			{
				return this._previousLogFileName;
			}
			return fileName;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0000E3F4 File Offset: 0x0000C5F4
		private string GetArchiveFileNameBasedOnFileSize(string fileName, int upcomingWriteSize)
		{
			if (this.ArchiveAboveSize == -1L)
			{
				return null;
			}
			string potentialFileForArchiving = this.GetPotentialFileForArchiving(fileName);
			if (potentialFileForArchiving == null)
			{
				return null;
			}
			long? fileLength = this._fileAppenderCache.GetFileLength(potentialFileForArchiving);
			if (fileLength == null)
			{
				return null;
			}
			if (potentialFileForArchiving != fileName)
			{
				upcomingWriteSize = 0;
			}
			if (fileLength.Value + (long)upcomingWriteSize > this.ArchiveAboveSize)
			{
				return potentialFileForArchiving;
			}
			return null;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0000E458 File Offset: 0x0000C658
		private string GetArchiveFileNameBasedOnTime(string fileName, global::NLog.LogEventInfo logEvent, global::System.DateTime previousLogEventTimestamp)
		{
			if (this.ArchiveEvery == global::NLog.Targets.FileArchivePeriod.None)
			{
				return null;
			}
			fileName = this.GetPotentialFileForArchiving(fileName);
			if (fileName == null)
			{
				return null;
			}
			global::System.DateTime? fallbackTimeSource = (previousLogEventTimestamp != global::System.DateTime.MinValue && this.KeepFileOpen && !this.ConcurrentWrites && !this.NetworkWrites) ? new global::System.DateTime?(previousLogEventTimestamp) : null;
			global::System.DateTime? fileCreationTimeSource = this._fileAppenderCache.GetFileCreationTimeSource(fileName, fallbackTimeSource);
			if (fileCreationTimeSource == null)
			{
				return null;
			}
			if (previousLogEventTimestamp != global::System.DateTime.MinValue && previousLogEventTimestamp < fileCreationTimeSource && global::NLog.Targets.FileTarget.TruncateArchiveTime(previousLogEventTimestamp, global::NLog.Targets.FileArchivePeriod.Minute) < global::NLog.Targets.FileTarget.TruncateArchiveTime(fileCreationTimeSource.Value, global::NLog.Targets.FileArchivePeriod.Minute) && global::NLog.Internal.PlatformDetector.IsUnix)
			{
				if (this.KeepFileOpen && !this.ConcurrentWrites && !this.NetworkWrites)
				{
					global::NLog.Common.InternalLogger.Debug<string, global::System.DateTime?, global::System.DateTime>("FileTarget(Name={0}): Adjusted file creation time from {1} to {2}. Linux FileSystem probably don't support file birthtime.", base.Name, fileCreationTimeSource, previousLogEventTimestamp);
					fileCreationTimeSource = new global::System.DateTime?(previousLogEventTimestamp);
				}
				else
				{
					global::NLog.Common.InternalLogger.Debug<string, global::System.DateTime?, global::System.DateTime>("FileTarget(Name={0}): File creation time {1} newer than previous file write time {2}. Linux FileSystem probably don't support file birthtime, unless multiple applications are writing to the same file. Configure FileTarget.KeepFileOpen=true AND FileTarget.ConcurrentWrites=false, so NLog can fix this.", base.Name, fileCreationTimeSource, previousLogEventTimestamp);
				}
			}
			global::System.DateTime d = global::NLog.Targets.FileTarget.TruncateArchiveTime(fileCreationTimeSource.Value, this.ArchiveEvery);
			global::System.DateTime d2 = global::NLog.Targets.FileTarget.TruncateArchiveTime(logEvent.TimeStamp, this.ArchiveEvery);
			if (d != d2)
			{
				string archiveDateFormatString = this.GetArchiveDateFormatString(string.Empty);
				string a = fileCreationTimeSource.Value.ToString(archiveDateFormatString, global::System.Globalization.CultureInfo.InvariantCulture);
				string b = logEvent.TimeStamp.ToString(archiveDateFormatString, global::System.Globalization.CultureInfo.InvariantCulture);
				if (a != b)
				{
					return fileName;
				}
			}
			return null;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0000E5DC File Offset: 0x0000C7DC
		private static global::System.DateTime TruncateArchiveTime(global::System.DateTime input, global::NLog.Targets.FileArchivePeriod resolution)
		{
			switch (resolution)
			{
			case global::NLog.Targets.FileArchivePeriod.Year:
				return new global::System.DateTime(input.Year, 1, 1, 0, 0, 0, 0, input.Kind);
			case global::NLog.Targets.FileArchivePeriod.Month:
				return new global::System.DateTime(input.Year, input.Month, 1, 0, 0, 0, input.Kind);
			case global::NLog.Targets.FileArchivePeriod.Day:
				return input.Date;
			case global::NLog.Targets.FileArchivePeriod.Hour:
				return input.AddTicks(-(input.Ticks % 36000000000L));
			case global::NLog.Targets.FileArchivePeriod.Minute:
				return input.AddTicks(-(input.Ticks % 600000000L));
			case global::NLog.Targets.FileArchivePeriod.Sunday:
				return global::NLog.Targets.FileTarget.CalculateNextWeekday(input.Date, global::System.DayOfWeek.Sunday);
			case global::NLog.Targets.FileArchivePeriod.Monday:
				return global::NLog.Targets.FileTarget.CalculateNextWeekday(input.Date, global::System.DayOfWeek.Monday);
			case global::NLog.Targets.FileArchivePeriod.Tuesday:
				return global::NLog.Targets.FileTarget.CalculateNextWeekday(input.Date, global::System.DayOfWeek.Tuesday);
			case global::NLog.Targets.FileArchivePeriod.Wednesday:
				return global::NLog.Targets.FileTarget.CalculateNextWeekday(input.Date, global::System.DayOfWeek.Wednesday);
			case global::NLog.Targets.FileArchivePeriod.Thursday:
				return global::NLog.Targets.FileTarget.CalculateNextWeekday(input.Date, global::System.DayOfWeek.Thursday);
			case global::NLog.Targets.FileArchivePeriod.Friday:
				return global::NLog.Targets.FileTarget.CalculateNextWeekday(input.Date, global::System.DayOfWeek.Friday);
			case global::NLog.Targets.FileArchivePeriod.Saturday:
				return global::NLog.Targets.FileTarget.CalculateNextWeekday(input.Date, global::System.DayOfWeek.Saturday);
			default:
				return input;
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0000E6FC File Offset: 0x0000C8FC
		private void AutoClosingTimerCallback(object sender, global::System.EventArgs state)
		{
			try
			{
				object syncRoot = base.SyncRoot;
				lock (syncRoot)
				{
					if (base.IsInitialized)
					{
						if (sender != this)
						{
							global::NLog.Common.InternalLogger.Trace<string>("FileTarget(Name={0}): Auto Close FileAppenders after archive", base.Name);
							this._fileAppenderCache.CloseAppenders(global::System.DateTime.MinValue);
						}
						else
						{
							if (this.OpenFileCacheTimeout > 0)
							{
								global::System.DateTime expireTime = global::System.DateTime.UtcNow.AddSeconds((double)(-(double)this.OpenFileCacheTimeout));
								global::NLog.Common.InternalLogger.Trace<string>("FileTarget(Name={0}): Auto Close FileAppenders", base.Name);
								this._fileAppenderCache.CloseAppenders(expireTime);
							}
							if (this.OpenFileFlushTimeout > 0 && !this.AutoFlush)
							{
								this.ConditionalFlushOpenFileAppenders();
							}
						}
					}
				}
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Warn(ex, "FileTarget(Name={0}): Exception in AutoClosingTimerCallback", new object[]
				{
					base.Name
				});
				if (ex.MustBeRethrownImmediately())
				{
					throw;
				}
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0000E7F4 File Offset: 0x0000C9F4
		private void ConditionalFlushOpenFileAppenders()
		{
			global::System.DateTime t = global::NLog.Time.TimeSource.Current.Time.AddSeconds((double)(-(double)global::System.Math.Max(this.OpenFileFlushTimeout, 5) * 2));
			bool flag = false;
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.DateTime> keyValuePair in this._initializedFiles)
			{
				if (keyValuePair.Value > t)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				global::NLog.Common.InternalLogger.Trace<string>("FileTarget(Name={0}): Auto Flush FileAppenders", base.Name);
				this._fileAppenderCache.FlushAppenders();
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0000E898 File Offset: 0x0000CA98
		private void WriteToFile(string fileName, global::System.ArraySegment<byte> bytes, bool initializedNewFile)
		{
			if (this.ReplaceFileContentsOnEachWrite)
			{
				this.ReplaceFileContent(fileName, bytes, true);
				return;
			}
			global::NLog.Internal.FileAppenders.BaseFileAppender baseFileAppender = this._fileAppenderCache.AllocateAppender(fileName);
			try
			{
				if (initializedNewFile)
				{
					this.WriteHeaderAndBom(baseFileAppender);
				}
				baseFileAppender.Write(bytes.Array, bytes.Offset, bytes.Count);
				if (this.AutoFlush)
				{
					baseFileAppender.Flush();
				}
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Error(ex, "FileTarget(Name={0}): Failed write to file '{1}'.", new object[]
				{
					base.Name,
					fileName
				});
				global::NLog.Internal.FileAppenders.BaseFileAppender baseFileAppender2 = this._fileAppenderCache.InvalidateAppender(fileName);
				if (baseFileAppender2 != null)
				{
					baseFileAppender2.Dispose();
				}
				throw;
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0000E940 File Offset: 0x0000CB40
		private global::System.DateTime InitializeFile(string fileName, global::NLog.LogEventInfo logEvent)
		{
			if (this._initializedFiles.Count != 0 && this._previousLogEventTimestamp != null && this._previousLogFileName == fileName && logEvent.TimeStamp == this._previousLogEventTimestamp.Value)
			{
				return this._previousLogEventTimestamp.Value;
			}
			global::System.DateTime timeStamp = logEvent.TimeStamp;
			global::System.DateTime dateTime;
			if (!this._initializedFiles.TryGetValue(fileName, out dateTime))
			{
				this.ProcessOnStartup(fileName, logEvent);
				this._initializedFilesCounter++;
				if (this._initializedFilesCounter >= 25)
				{
					this._initializedFilesCounter = 0;
					this.CleanupInitializedFiles();
				}
				this._initializedFiles[fileName] = timeStamp;
				return global::System.DateTime.MinValue;
			}
			if (dateTime != timeStamp)
			{
				this._initializedFiles[fileName] = timeStamp;
			}
			return dateTime;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0000EA08 File Offset: 0x0000CC08
		private void FinalizeFile(string fileName, bool isArchiving = false)
		{
			global::NLog.Common.InternalLogger.Trace<string, string, bool>("FileTarget(Name={0}): FinalizeFile '{1}, isArchiving: {2}'", base.Name, fileName, isArchiving);
			if (isArchiving || !this.WriteFooterOnArchivingOnly)
			{
				this.WriteFooter(fileName);
			}
			global::NLog.Internal.FileAppenders.BaseFileAppender baseFileAppender = this._fileAppenderCache.InvalidateAppender(fileName);
			if (baseFileAppender != null)
			{
				baseFileAppender.Dispose();
			}
			this._initializedFiles.Remove(fileName);
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0000EA60 File Offset: 0x0000CC60
		private void WriteFooter(string fileName)
		{
			global::System.ArraySegment<byte> layoutBytes = this.GetLayoutBytes(base.Footer);
			if (layoutBytes.Count > 0 && global::System.IO.File.Exists(fileName))
			{
				this.WriteToFile(fileName, layoutBytes, false);
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0000EA98 File Offset: 0x0000CC98
		private void ProcessOnStartup(string fileName, global::NLog.LogEventInfo logEvent)
		{
			global::NLog.Common.InternalLogger.Debug<string, string>("FileTarget(Name={0}): Process file '{1}' on startup", base.Name, fileName);
			this.RefreshArchiveFilePatternToWatch(fileName, logEvent);
			if (this.ArchiveOldFileOnStartup)
			{
				try
				{
					this.DoAutoArchive(fileName, logEvent, global::System.DateTime.MinValue, true);
				}
				catch (global::System.Exception ex)
				{
					global::NLog.Common.InternalLogger.Warn(ex, "FileTarget(Name={0}): Unable to archive old log file '{1}'.", new object[]
					{
						base.Name,
						fileName
					});
					if (ex.MustBeRethrown())
					{
						throw;
					}
				}
			}
			if (this.DeleteOldFileOnStartup)
			{
				this.DeleteOldArchiveFile(fileName);
			}
			string archiveFileNamePattern = this.GetArchiveFileNamePattern(fileName, logEvent);
			if (!string.IsNullOrEmpty(archiveFileNamePattern) && global::NLog.Targets.FileArchiveModes.FileArchiveModeFactory.ShouldDeleteOldArchives(this.MaxArchiveFiles))
			{
				global::NLog.Targets.IFileArchiveMode fileArchiveHelper = this.GetFileArchiveHelper(archiveFileNamePattern);
				if (fileArchiveHelper.AttemptCleanupOnInitializeFile(archiveFileNamePattern, this.MaxArchiveFiles))
				{
					global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> existingArchiveFiles = fileArchiveHelper.GetExistingArchiveFiles(archiveFileNamePattern);
					foreach (global::NLog.Targets.DateAndSequenceArchive dateAndSequenceArchive in fileArchiveHelper.CheckArchiveCleanup(archiveFileNamePattern, existingArchiveFiles, this.MaxArchiveFiles))
					{
						this.DeleteOldArchiveFile(dateAndSequenceArchive.FileName);
					}
				}
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
		private void ReplaceFileContent(string fileName, global::System.ArraySegment<byte> bytes, bool firstAttempt)
		{
			try
			{
				using (global::System.IO.FileStream fileStream = global::System.IO.File.Create(fileName))
				{
					global::System.ArraySegment<byte> layoutBytes = this.GetLayoutBytes(base.Header);
					if (layoutBytes.Count > 0)
					{
						fileStream.Write(layoutBytes.Array, layoutBytes.Offset, layoutBytes.Count);
					}
					fileStream.Write(bytes.Array, bytes.Offset, bytes.Count);
					global::System.ArraySegment<byte> layoutBytes2 = this.GetLayoutBytes(base.Footer);
					if (layoutBytes2.Count > 0)
					{
						fileStream.Write(layoutBytes2.Array, layoutBytes2.Offset, layoutBytes2.Count);
					}
				}
			}
			catch (global::System.IO.DirectoryNotFoundException)
			{
				if (!this.CreateDirs || !firstAttempt)
				{
					throw;
				}
				global::System.IO.Directory.CreateDirectory(global::System.IO.Path.GetDirectoryName(fileName));
				this.ReplaceFileContent(fileName, bytes, false);
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0000EC94 File Offset: 0x0000CE94
		private void WriteHeaderAndBom(global::NLog.Internal.FileAppenders.BaseFileAppender appender)
		{
			if (base.Header == null && !this.WriteBom)
			{
				return;
			}
			long? fileLength = appender.GetFileLength();
			if (fileLength == null || fileLength == 0L)
			{
				if (this.WriteBom)
				{
					global::NLog.Common.InternalLogger.Trace<string, global::System.Text.Encoding>("FileTarget(Name={0}): Write byte order mark from encoding={1}", base.Name, this.Encoding);
					byte[] preamble = this.Encoding.GetPreamble();
					if (preamble.Length != 0)
					{
						appender.Write(preamble, 0, preamble.Length);
					}
				}
				if (base.Header != null)
				{
					global::NLog.Common.InternalLogger.Trace<string>("FileTarget(Name={0}): Write header", base.Name);
					global::System.ArraySegment<byte> layoutBytes = this.GetLayoutBytes(base.Header);
					if (layoutBytes.Count > 0)
					{
						appender.Write(layoutBytes.Array, layoutBytes.Offset, layoutBytes.Count);
					}
				}
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0000ED64 File Offset: 0x0000CF64
		private global::System.ArraySegment<byte> GetLayoutBytes(global::NLog.Layouts.Layout layout)
		{
			if (layout == null)
			{
				return default(global::System.ArraySegment<byte>);
			}
			if (base.OptimizeBufferReuse)
			{
				using (global::NLog.Internal.ReusableObjectCreator<global::System.Text.StringBuilder>.LockOject lockOject = this.ReusableLayoutBuilder.Allocate())
				{
					using (global::NLog.Internal.ReusableObjectCreator<char[]>.LockOject lockOject2 = this._reusableEncodingBuffer.Allocate())
					{
						global::NLog.LogEventInfo logEvent = global::NLog.LogEventInfo.CreateNullEvent();
						layout.RenderAppendBuilder(logEvent, lockOject.Result, false);
						lockOject.Result.Append(this.NewLineChars);
						using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(lockOject.Result.Length))
						{
							this.TransformBuilderToStream(logEvent, lockOject.Result, lockOject2.Result, memoryStream);
							return new global::System.ArraySegment<byte>(memoryStream.ToArray());
						}
					}
				}
			}
			string s = layout.Render(global::NLog.LogEventInfo.CreateNullEvent()) + this.NewLineChars;
			return new global::System.ArraySegment<byte>(this.TransformBytes(this.Encoding.GetBytes(s)));
		}

		// Token: 0x040000D3 RID: 211
		private const int InitializedFilesCleanupPeriod = 2;

		// Token: 0x040000D4 RID: 212
		private const int InitializedFilesCounterMax = 25;

		// Token: 0x040000D5 RID: 213
		private const int ArchiveAboveSizeDisabled = -1;

		// Token: 0x040000D6 RID: 214
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.DateTime> _initializedFiles = new global::System.Collections.Generic.Dictionary<string, global::System.DateTime>(global::System.StringComparer.OrdinalIgnoreCase);

		// Token: 0x040000D7 RID: 215
		private global::NLog.Targets.LineEndingMode _lineEndingMode = global::NLog.Targets.LineEndingMode.Default;

		// Token: 0x040000D8 RID: 216
		private global::NLog.Internal.FileAppenders.FileAppenderCache _fileAppenderCache;

		// Token: 0x040000D9 RID: 217
		private global::NLog.Targets.IFileArchiveMode _fileArchiveHelper;

		// Token: 0x040000DA RID: 218
		private global::System.Threading.Timer _autoClosingTimer;

		// Token: 0x040000DB RID: 219
		private int _initializedFilesCounter;

		// Token: 0x040000DC RID: 220
		private int _maxArchiveFiles;

		// Token: 0x040000DD RID: 221
		private global::NLog.Internal.FilePathLayout _fullFileName;

		// Token: 0x040000DE RID: 222
		private global::NLog.Internal.FilePathLayout _fullArchiveFileName;

		// Token: 0x040000DF RID: 223
		private global::NLog.Targets.FileArchivePeriod _archiveEvery;

		// Token: 0x040000E0 RID: 224
		private long _archiveAboveSize;

		// Token: 0x040000E1 RID: 225
		private bool _enableArchiveFileCompression;

		// Token: 0x040000E2 RID: 226
		private global::System.DateTime? _previousLogEventTimestamp;

		// Token: 0x040000E3 RID: 227
		private string _previousLogFileName;

		// Token: 0x040000E4 RID: 228
		private bool? _concurrentWrites;

		// Token: 0x040000E5 RID: 229
		private bool _keepFileOpen;

		// Token: 0x040000E6 RID: 230
		private bool _cleanupFileName;

		// Token: 0x040000E7 RID: 231
		private global::NLog.Targets.FilePathKind _fileNameKind;

		// Token: 0x040000E8 RID: 232
		private global::NLog.Targets.FilePathKind _archiveFileKind;

		// Token: 0x040000FB RID: 251
		private string _archiveDateFormat;

		// Token: 0x040000FC RID: 252
		private global::NLog.Targets.ArchiveNumberingMode _archiveNumbering;

		// Token: 0x04000101 RID: 257
		private readonly global::NLog.Internal.ReusableStreamCreator _reusableFileWriteStream = new global::NLog.Internal.ReusableStreamCreator(4096);

		// Token: 0x04000102 RID: 258
		private readonly global::NLog.Internal.ReusableStreamCreator _reusableAsyncFileWriteStream = new global::NLog.Internal.ReusableStreamCreator(4096);

		// Token: 0x04000103 RID: 259
		private readonly global::NLog.Internal.ReusableBufferCreator _reusableEncodingBuffer = new global::NLog.Internal.ReusableBufferCreator(1024);

		// Token: 0x04000104 RID: 260
		private global::NLog.Internal.SortHelpers.KeySelector<global::NLog.Common.AsyncLogEventInfo, string> _getFullFileNameDelegate;
	}
}
