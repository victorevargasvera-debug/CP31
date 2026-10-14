using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Security.Principal;
using Gibraltar.Messaging;
using Gibraltar.Serialization;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x0200021B RID: 539
	internal class LogMessagePacket : global::Gibraltar.Monitor.Internal.GibraltarPacket, global::Gibraltar.Serialization.IPacket, global::Loupe.Extensibility.Data.ILogMessage, global::System.IComparable<global::Loupe.Extensibility.Data.ILogMessage>, global::System.IEquatable<global::Loupe.Extensibility.Data.ILogMessage>, global::System.IComparable<global::Gibraltar.Monitor.Internal.LogMessagePacket>, global::System.IEquatable<global::Gibraltar.Monitor.Internal.LogMessagePacket>
	{
		// Token: 0x06001B07 RID: 6919 RVA: 0x0005E30C File Offset: 0x0005C50C
		public LogMessagePacket()
		{
			this.Id = global::System.Guid.NewGuid();
			this.m_SuppressNotification = global::Gibraltar.Messaging.Publisher.QueryThreadMustNotNotify();
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x0005E32C File Offset: 0x0005C52C
		internal LogMessagePacket(global::Gibraltar.Monitor.Internal.ISessionPacketCache sessionPacketCache)
		{
			this.m_SessionPacketCache = sessionPacketCache;
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x0005E33C File Offset: 0x0005C53C
		public void SetSourceInfo(global::Gibraltar.Monitor.IMessageSourceProvider sourceProvider)
		{
			if (sourceProvider != null)
			{
				this.MethodName = sourceProvider.MethodName;
				this.ClassName = sourceProvider.ClassName;
				this.FileName = sourceProvider.FileName;
				this.LineNumber = sourceProvider.LineNumber;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x0005E384 File Offset: 0x0005C584
		// (set) Token: 0x06001B0B RID: 6923 RVA: 0x0005E38C File Offset: 0x0005C58C
		public global::System.Guid Id
		{
			get
			{
				return this.m_ID;
			}
			private set
			{
				this.m_ID = value;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x0005E398 File Offset: 0x0005C598
		// (set) Token: 0x06001B0D RID: 6925 RVA: 0x0005E3A0 File Offset: 0x0005C5A0
		public global::Loupe.Extensibility.Data.LogMessageSeverity Severity
		{
			get
			{
				return this.m_Severity;
			}
			set
			{
				this.m_Severity = value;
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x0005E3AC File Offset: 0x0005C5AC
		// (set) Token: 0x06001B0F RID: 6927 RVA: 0x0005E3B4 File Offset: 0x0005C5B4
		public string LogSystem
		{
			get
			{
				return this.m_LogSystem;
			}
			set
			{
				this.m_LogSystem = value;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06001B10 RID: 6928 RVA: 0x0005E3C0 File Offset: 0x0005C5C0
		// (set) Token: 0x06001B11 RID: 6929 RVA: 0x0005E3C8 File Offset: 0x0005C5C8
		public string CategoryName
		{
			get
			{
				return this.m_CategoryName;
			}
			set
			{
				this.m_CategoryName = value;
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001B12 RID: 6930 RVA: 0x0005E3D4 File Offset: 0x0005C5D4
		// (set) Token: 0x06001B13 RID: 6931 RVA: 0x0005E3DC File Offset: 0x0005C5DC
		public string UserName
		{
			get
			{
				return this.m_UserName;
			}
			set
			{
				this.m_UserName = value;
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001B14 RID: 6932 RVA: 0x0005E3E8 File Offset: 0x0005C5E8
		// (set) Token: 0x06001B15 RID: 6933 RVA: 0x0005E3F0 File Offset: 0x0005C5F0
		public global::Gibraltar.Monitor.Internal.ApplicationUserPacket UserPacket { get; set; }

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x0005E3FC File Offset: 0x0005C5FC
		// (set) Token: 0x06001B17 RID: 6935 RVA: 0x0005E404 File Offset: 0x0005C604
		internal global::System.Security.Principal.IPrincipal UserPrincipal { get; set; }

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001B18 RID: 6936 RVA: 0x0005E410 File Offset: 0x0005C610
		// (set) Token: 0x06001B19 RID: 6937 RVA: 0x0005E418 File Offset: 0x0005C618
		public string MethodName
		{
			get
			{
				return this.m_MethodName;
			}
			set
			{
				this.m_MethodName = value;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001B1A RID: 6938 RVA: 0x0005E424 File Offset: 0x0005C624
		// (set) Token: 0x06001B1B RID: 6939 RVA: 0x0005E42C File Offset: 0x0005C62C
		public string ClassName
		{
			get
			{
				return this.m_ClassName;
			}
			set
			{
				this.m_ClassName = value;
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001B1C RID: 6940 RVA: 0x0005E438 File Offset: 0x0005C638
		// (set) Token: 0x06001B1D RID: 6941 RVA: 0x0005E440 File Offset: 0x0005C640
		public string FileName
		{
			get
			{
				return this.m_FileName;
			}
			set
			{
				this.m_FileName = value;
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001B1E RID: 6942 RVA: 0x0005E44C File Offset: 0x0005C64C
		// (set) Token: 0x06001B1F RID: 6943 RVA: 0x0005E454 File Offset: 0x0005C654
		public int LineNumber
		{
			get
			{
				return this.m_LineNumber;
			}
			set
			{
				this.m_LineNumber = value;
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001B20 RID: 6944 RVA: 0x0005E460 File Offset: 0x0005C660
		// (set) Token: 0x06001B21 RID: 6945 RVA: 0x0005E468 File Offset: 0x0005C668
		public int ThreadId
		{
			get
			{
				return this.m_ThreadId;
			}
			set
			{
				this.m_ThreadId = value;
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001B22 RID: 6946 RVA: 0x0005E474 File Offset: 0x0005C674
		// (set) Token: 0x06001B23 RID: 6947 RVA: 0x0005E47C File Offset: 0x0005C67C
		public int ThreadIndex
		{
			get
			{
				return this.m_ThreadIndex;
			}
			set
			{
				this.m_ThreadIndex = value;
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001B24 RID: 6948 RVA: 0x0005E488 File Offset: 0x0005C688
		// (set) Token: 0x06001B25 RID: 6949 RVA: 0x0005E490 File Offset: 0x0005C690
		public global::Gibraltar.Monitor.Internal.ThreadInfoPacket ThreadInfoPacket { get; set; }

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001B26 RID: 6950 RVA: 0x0005E49C File Offset: 0x0005C69C
		public global::Loupe.Extensibility.Data.IThreadInfo ThreadInfo
		{
			get
			{
				return this.ThreadInfoPacket;
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x0005E4A4 File Offset: 0x0005C6A4
		global::Loupe.Extensibility.Data.ISession global::Loupe.Extensibility.Data.ILogMessage.Session
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001B28 RID: 6952 RVA: 0x0005E4A8 File Offset: 0x0005C6A8
		int global::Loupe.Extensibility.Data.ILogMessage.DomainId
		{
			get
			{
				return this.ThreadInfo.DomainId;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x0005E4B8 File Offset: 0x0005C6B8
		string global::Loupe.Extensibility.Data.ILogMessage.DomainName
		{
			get
			{
				return this.ThreadInfo.DomainName;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001B2A RID: 6954 RVA: 0x0005E4C8 File Offset: 0x0005C6C8
		bool global::Loupe.Extensibility.Data.ILogMessage.IsBackground
		{
			get
			{
				return this.ThreadInfo.IsBackground;
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001B2B RID: 6955 RVA: 0x0005E4D8 File Offset: 0x0005C6D8
		bool global::Loupe.Extensibility.Data.ILogMessage.IsThreadPoolThread
		{
			get
			{
				return this.ThreadInfo.IsThreadPoolThread;
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001B2C RID: 6956 RVA: 0x0005E4E8 File Offset: 0x0005C6E8
		public bool HasThreadInfo
		{
			get
			{
				return this.ThreadInfoPacket != null;
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001B2D RID: 6957 RVA: 0x0005E4F4 File Offset: 0x0005C6F4
		public global::System.DateTime TimestampDateTime
		{
			get
			{
				return base.Timestamp.DateTime;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001B2E RID: 6958 RVA: 0x0005E514 File Offset: 0x0005C714
		public global::System.DateTimeOffset DisplayTimestamp
		{
			get
			{
				return base.Timestamp;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x0005E51C File Offset: 0x0005C71C
		public string Message
		{
			get
			{
				if (this.m_Message == null)
				{
					bool flag = !string.IsNullOrEmpty(this.m_Caption);
					bool flag2 = !string.IsNullOrEmpty(this.m_Caption);
					if (flag && flag2)
					{
						this.m_Message = global::Gibraltar.StringReference.GetReference(this.m_Caption + "\r\n" + this.m_Description);
					}
					else if (flag)
					{
						this.m_Message = this.m_Caption;
					}
					else if (flag2)
					{
						this.m_Message = this.m_Description;
					}
					else
					{
						this.m_Message = string.Empty;
					}
				}
				return this.m_Message;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001B30 RID: 6960 RVA: 0x0005E5C4 File Offset: 0x0005C7C4
		public string ThreadName
		{
			get
			{
				if (this.ThreadInfoPacket == null || string.IsNullOrEmpty(this.ThreadInfoPacket.ThreadName))
				{
					return this.ThreadId.ToString();
				}
				return this.ThreadInfoPacket.ThreadName;
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x0005E610 File Offset: 0x0005C810
		public string MethodFullName
		{
			get
			{
				if (string.IsNullOrEmpty(this.ClassName) || string.IsNullOrEmpty(this.MethodName))
				{
					return string.Empty;
				}
				return global::Gibraltar.StringReference.GetReference(this.ClassName + "." + this.MethodName);
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x0005E664 File Offset: 0x0005C864
		public string SourceCodeLocation
		{
			get
			{
				if (string.IsNullOrEmpty(this.FileName))
				{
					return string.Empty;
				}
				return global::Gibraltar.StringReference.GetReference(string.Format(global::Gibraltar.FileSystemTools.UICultureFormat, "{0} ({1:N0})", new object[]
				{
					this.FileName,
					this.LineNumber
				}));
			}
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x0005E6BC File Offset: 0x0005C8BC
		public void SetException(global::System.Exception newException)
		{
			this.m_ExceptionChain = global::Gibraltar.Monitor.Internal.LogMessagePacket.ExceptionToArray(newException);
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x0005E6CC File Offset: 0x0005C8CC
		public bool HasException
		{
			get
			{
				global::Loupe.Extensibility.Data.IExceptionInfo[] exceptions = this.Exceptions;
				return exceptions != null && exceptions.Length != 0;
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x0005E6F4 File Offset: 0x0005C8F4
		public bool HasMethodInfo
		{
			get
			{
				return !string.IsNullOrEmpty(this.ClassName);
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x0005E704 File Offset: 0x0005C904
		public bool HasSourceLocation
		{
			get
			{
				return !string.IsNullOrEmpty(this.FileName);
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x0005E714 File Offset: 0x0005C914
		public global::Loupe.Extensibility.Data.IExceptionInfo[] Exceptions
		{
			get
			{
				return this.m_ExceptionChain;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x0005E71C File Offset: 0x0005C91C
		public global::Loupe.Extensibility.Data.IExceptionInfo Exception
		{
			get
			{
				global::Loupe.Extensibility.Data.IExceptionInfo[] exceptions = this.Exceptions;
				if (exceptions == null || exceptions.Length == 0)
				{
					return null;
				}
				return exceptions[0];
			}
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x0005E74C File Offset: 0x0005C94C
		public static global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IExceptionInfo> ExceptionsList(global::Loupe.Extensibility.Data.IExceptionInfo exception)
		{
			global::System.Collections.Generic.List<global::Loupe.Extensibility.Data.IExceptionInfo> list = new global::System.Collections.Generic.List<global::Loupe.Extensibility.Data.IExceptionInfo>();
			for (global::Loupe.Extensibility.Data.IExceptionInfo exceptionInfo = exception; exceptionInfo != null; exceptionInfo = exceptionInfo.InnerException)
			{
				list.Add(exceptionInfo);
			}
			return list;
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x0005E77C File Offset: 0x0005C97C
		// (set) Token: 0x06001B3B RID: 6971 RVA: 0x0005E784 File Offset: 0x0005C984
		public string Caption
		{
			get
			{
				return this.m_Caption;
			}
			set
			{
				this.m_Caption = value;
				this.m_Message = null;
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x0005E794 File Offset: 0x0005C994
		// (set) Token: 0x06001B3D RID: 6973 RVA: 0x0005E79C File Offset: 0x0005C99C
		public string Description
		{
			get
			{
				return this.m_Description;
			}
			set
			{
				this.m_Description = value;
				this.m_Message = null;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x0005E7AC File Offset: 0x0005C9AC
		// (set) Token: 0x06001B3F RID: 6975 RVA: 0x0005E7B4 File Offset: 0x0005C9B4
		public virtual string Details
		{
			get
			{
				return this.m_Details;
			}
			set
			{
				this.m_Details = value;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x0005E7C0 File Offset: 0x0005C9C0
		public bool SuppressNotification
		{
			get
			{
				return this.m_SuppressNotification;
			}
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x0005E7C8 File Offset: 0x0005C9C8
		public override void FixData()
		{
			base.FixData();
			global::Gibraltar.StringReference.SwapReference(ref this.m_LogSystem);
			global::Gibraltar.StringReference.SwapReference(ref this.m_CategoryName);
			global::Gibraltar.StringReference.SwapReference(ref this.m_UserName);
			global::Gibraltar.StringReference.SwapReference(ref this.m_Caption);
			global::Gibraltar.StringReference.SwapReference(ref this.m_Description);
			global::Gibraltar.StringReference.SwapReference(ref this.m_Details);
			global::Gibraltar.StringReference.SwapReference(ref this.m_MethodName);
			global::Gibraltar.StringReference.SwapReference(ref this.m_ClassName);
			global::Gibraltar.StringReference.SwapReference(ref this.m_FileName);
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x0005E844 File Offset: 0x0005CA44
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "{0} {1}: {2}", new object[]
			{
				base.Timestamp.DateTime.ToShortDateString(),
				base.Timestamp.DateTime.ToShortTimeString(),
				this.Caption
			});
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0005E8A8 File Offset: 0x0005CAA8
		public int CompareTo(global::Gibraltar.Monitor.Internal.LogMessagePacket other)
		{
			return this.CompareTo(other);
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x0005E8B4 File Offset: 0x0005CAB4
		public int CompareTo(global::Loupe.Extensibility.Data.ILogMessage other)
		{
			if (this.Id == other.Id)
			{
				return 0;
			}
			return base.Sequence.CompareTo(other.Sequence);
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x0005E8F4 File Offset: 0x0005CAF4
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.LogMessagePacket);
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x0005E904 File Offset: 0x0005CB04
		public bool Equals(global::Gibraltar.Monitor.Internal.LogMessagePacket other)
		{
			return other != null && this.Equals(other);
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x0005E918 File Offset: 0x0005CB18
		public bool Equals(global::Loupe.Extensibility.Data.ILogMessage other)
		{
			return other != null && (this.Id == other.Id && this.Caption == other.Caption && this.Description == other.Description && this.Details == other.Details && this.Severity == other.Severity && this.LogSystem == other.LogSystem && this.CategoryName == other.CategoryName && this.UserName == other.UserName && this.MethodName == other.MethodName && this.ClassName == other.ClassName && this.FileName == other.FileName && this.LineNumber == other.LineNumber && this.ThreadId == other.ThreadId) && base.Equals(other);
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x0005EA4C File Offset: 0x0005CC4C
		public override int GetHashCode()
		{
			int num = base.GetHashCode();
			num ^= (int)this.Severity;
			num ^= this.Id.GetHashCode();
			if (this.Caption != null)
			{
				num ^= this.Caption.GetHashCode();
			}
			if (this.Description != null)
			{
				num ^= this.Description.GetHashCode();
			}
			if (this.Details != null)
			{
				num ^= this.Details.GetHashCode();
			}
			if (this.LogSystem != null)
			{
				num ^= this.LogSystem.GetHashCode();
			}
			if (this.CategoryName != null)
			{
				num ^= this.CategoryName.GetHashCode();
			}
			if (this.UserName != null)
			{
				num ^= this.UserName.GetHashCode();
			}
			if (this.MethodName != null)
			{
				num ^= this.MethodName.GetHashCode();
			}
			if (this.ClassName != null)
			{
				num ^= this.ClassName.GetHashCode();
			}
			if (this.FileName != null)
			{
				num ^= this.FileName.GetHashCode();
			}
			num ^= this.LineNumber;
			return num ^ this.ThreadId;
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x0005EB78 File Offset: 0x0005CD78
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			if (this.UserPacket != null)
			{
				return new global::Gibraltar.Serialization.IPacket[]
				{
					this.ThreadInfoPacket,
					this.UserPacket
				};
			}
			return new global::Gibraltar.Serialization.IPacket[]
			{
				this.ThreadInfoPacket
			};
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x0005EBBC File Offset: 0x0005CDBC
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 3, true)
			{
				Fields = 
				{
					{
						"ID",
						global::Gibraltar.Serialization.FieldType.Guid
					},
					{
						"Caption",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"Severity",
						global::Gibraltar.Serialization.FieldType.Int32
					},
					{
						"LogSystem",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"CategoryName",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"UserName",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"Description",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"Details",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"ThreadIndex",
						global::Gibraltar.Serialization.FieldType.Int32
					},
					{
						"ThreadId",
						global::Gibraltar.Serialization.FieldType.Int32
					},
					{
						"MethodName",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"ClassName",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"FileName",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"LineNumber",
						global::Gibraltar.Serialization.FieldType.Int32
					},
					{
						"TypeNames",
						global::Gibraltar.Serialization.FieldType.StringArray
					},
					{
						"Messages",
						global::Gibraltar.Serialization.FieldType.StringArray
					},
					{
						"Sources",
						global::Gibraltar.Serialization.FieldType.StringArray
					},
					{
						"StackTraces",
						global::Gibraltar.Serialization.FieldType.StringArray
					},
					{
						"ApplicationUserId",
						global::Gibraltar.Serialization.FieldType.Guid
					}
				}
			};
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x0005ED28 File Offset: 0x0005CF28
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("ID", this.m_ID);
			packet.SetField("Caption", this.m_Caption);
			packet.SetField("Severity", (int)this.m_Severity);
			packet.SetField("LogSystem", this.m_LogSystem);
			packet.SetField("CategoryName", this.m_CategoryName);
			packet.SetField("UserName", this.m_UserName);
			packet.SetField("Description", this.m_Description);
			packet.SetField("Details", this.m_Details);
			packet.SetField("ThreadIndex", this.m_ThreadIndex);
			packet.SetField("ThreadId", this.m_ThreadId);
			packet.SetField("MethodName", this.m_MethodName);
			packet.SetField("ClassName", this.m_ClassName);
			packet.SetField("FileName", this.m_FileName);
			packet.SetField("LineNumber", this.m_LineNumber);
			global::Loupe.Extensibility.Data.IExceptionInfo[] exceptions = this.Exceptions;
			int num = (exceptions == null) ? 0 : exceptions.Length;
			string[] array = new string[num];
			string[] array2 = new string[num];
			string[] array3 = new string[num];
			string[] array4 = new string[num];
			if (exceptions != null)
			{
				for (int i = 0; i < num; i++)
				{
					array[i] = exceptions[i].TypeName;
					array2[i] = exceptions[i].Message;
					array3[i] = exceptions[i].Source;
					array4[i] = exceptions[i].StackTrace;
				}
			}
			packet.SetField("TypeNames", array);
			packet.SetField("Messages", array2);
			packet.SetField("Sources", array3);
			packet.SetField("StackTraces", array4);
			packet.SetField("ApplicationUserId", (this.UserPacket == null) ? global::System.Guid.Empty : this.UserPacket.ID);
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x0005EF48 File Offset: 0x0005D148
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version - 1 <= 2)
			{
				packet.GetField("ID", out this.m_ID);
				packet.GetField("Caption", out this.m_Caption);
				int severity;
				packet.GetField("Severity", out severity);
				this.m_Severity = (global::Loupe.Extensibility.Data.LogMessageSeverity)severity;
				packet.GetField("LogSystem", out this.m_LogSystem);
				packet.GetField("CategoryName", out this.m_CategoryName);
				packet.GetField("UserName", out this.m_UserName);
				if (definition.Version >= 2)
				{
					packet.GetField("Description", out this.m_Description);
					packet.GetField("Details", out this.m_Details);
				}
				packet.GetField("ThreadId", out this.m_ThreadId);
				packet.GetField("MethodName", out this.m_MethodName);
				packet.GetField("ClassName", out this.m_ClassName);
				packet.GetField("FileName", out this.m_FileName);
				packet.GetField("LineNumber", out this.m_LineNumber);
				if (definition.Fields.ContainsKey("ThreadIndex"))
				{
					packet.GetField("ThreadIndex", out this.m_ThreadIndex);
					if (this.m_ThreadIndex == 0)
					{
						this.m_ThreadIndex = this.m_ThreadId;
					}
				}
				else
				{
					this.m_ThreadIndex = this.m_ThreadId;
				}
				global::Gibraltar.Monitor.ThreadInfo threadInfo;
				if (this.m_SessionPacketCache.Threads.TryGetValue(this.m_ThreadIndex, out threadInfo))
				{
					this.ThreadInfoPacket = threadInfo.Packet;
				}
				string[] array;
				packet.GetField("TypeNames", out array);
				string[] array2;
				packet.GetField("Messages", out array2);
				string[] array3;
				packet.GetField("Sources", out array3);
				string[] array4;
				packet.GetField("StackTraces", out array4);
				int length = array.GetLength(0);
				global::Loupe.Extensibility.Data.IExceptionInfo[] array5 = new global::Loupe.Extensibility.Data.IExceptionInfo[length];
				global::Loupe.Extensibility.Data.IExceptionInfo exceptionInfo = null;
				for (int i = 0; i < length; i++)
				{
					global::Loupe.Extensibility.Data.IExceptionInfo exceptionInfo2 = new global::Gibraltar.Monitor.Internal.ExceptionInfoPacket
					{
						TypeName = array[i],
						Message = array2[i],
						Source = array3[i],
						StackTrace = array4[i]
					};
					array5[i] = exceptionInfo2;
					if (exceptionInfo != null)
					{
						((global::Gibraltar.Monitor.Internal.ExceptionInfoPacket)exceptionInfo).InnerException = exceptionInfo2;
					}
					exceptionInfo = exceptionInfo2;
				}
				this.m_ExceptionChain = array5;
				if (definition.Version >= 3)
				{
					global::System.Guid id;
					packet.GetField("ApplicationUserId", out id);
					global::Gibraltar.Monitor.ApplicationUser applicationUser;
					if (this.m_SessionPacketCache.Users.TryGetValue(id, out applicationUser))
					{
						this.UserPacket = applicationUser.Packet;
					}
				}
			}
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x0005F1D8 File Offset: 0x0005D3D8
		public new void ReadFieldsFast(global::Gibraltar.Serialization.IFieldReader reader)
		{
			base.ReadFieldsFast(reader);
			this.m_ID = reader.ReadGuid();
			this.m_Caption = reader.ReadString();
			this.m_Severity = (global::Loupe.Extensibility.Data.LogMessageSeverity)reader.ReadInt32();
			this.m_LogSystem = reader.ReadString();
			this.m_CategoryName = reader.ReadString();
			this.m_UserName = reader.ReadString();
			this.m_Description = reader.ReadString();
			this.m_Details = reader.ReadString();
			this.m_ThreadIndex = reader.ReadInt32();
			this.m_ThreadId = reader.ReadInt32();
			this.m_MethodName = reader.ReadString();
			this.m_ClassName = reader.ReadString();
			this.m_FileName = reader.ReadString();
			this.m_LineNumber = reader.ReadInt32();
			string[] array = reader.ReadStringArray();
			string[] array2 = reader.ReadStringArray();
			string[] array3 = reader.ReadStringArray();
			string[] array4 = reader.ReadStringArray();
			global::System.Guid guid = reader.ReadGuid();
			if (this.m_ThreadIndex == 0)
			{
				this.m_ThreadIndex = this.m_ThreadId;
			}
			global::Gibraltar.Monitor.ThreadInfo threadInfo;
			if (this.m_SessionPacketCache.Threads.TryGetValue(this.m_ThreadIndex, out threadInfo))
			{
				this.ThreadInfoPacket = threadInfo.Packet;
			}
			if (guid != global::System.Guid.Empty)
			{
				global::Gibraltar.Monitor.ApplicationUser applicationUser;
				this.m_SessionPacketCache.Users.TryGetValue(guid, out applicationUser);
				this.UserPacket = applicationUser.Packet;
			}
			int length = array.GetLength(0);
			global::Loupe.Extensibility.Data.IExceptionInfo[] array5 = new global::Loupe.Extensibility.Data.IExceptionInfo[length];
			global::Loupe.Extensibility.Data.IExceptionInfo exceptionInfo = null;
			for (int i = 0; i < length; i++)
			{
				global::Loupe.Extensibility.Data.IExceptionInfo exceptionInfo2 = new global::Gibraltar.Monitor.Internal.ExceptionInfoPacket
				{
					TypeName = array[i],
					Message = array2[i],
					Source = array3[i],
					StackTrace = array4[i]
				};
				array5[i] = exceptionInfo2;
				if (exceptionInfo != null)
				{
					((global::Gibraltar.Monitor.Internal.ExceptionInfoPacket)exceptionInfo).InnerException = exceptionInfo2;
				}
				exceptionInfo = exceptionInfo2;
			}
			this.m_ExceptionChain = array5;
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x0005F3C4 File Offset: 0x0005D5C4
		private static global::Loupe.Extensibility.Data.IExceptionInfo[] ExceptionToArray(global::System.Exception exception)
		{
			if (exception == null)
			{
				return new global::Loupe.Extensibility.Data.IExceptionInfo[0];
			}
			int num = 1;
			global::System.Exception innerException;
			for (innerException = exception.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				num++;
			}
			global::Loupe.Extensibility.Data.IExceptionInfo[] array = new global::Loupe.Extensibility.Data.IExceptionInfo[num];
			array[0] = new global::Gibraltar.Monitor.Internal.ExceptionInfoPacket(exception);
			innerException = exception.InnerException;
			int num2 = 0;
			while (innerException != null)
			{
				num2++;
				array[num2] = new global::Gibraltar.Monitor.Internal.ExceptionInfoPacket(innerException);
				((global::Gibraltar.Monitor.Internal.ExceptionInfoPacket)array[num2 - 1]).InnerException = array[num2];
				innerException = innerException.InnerException;
			}
			return array;
		}

		// Token: 0x040009CD RID: 2509
		private readonly global::Gibraltar.Monitor.Internal.ISessionPacketCache m_SessionPacketCache;

		// Token: 0x040009CE RID: 2510
		private global::System.Guid m_ID;

		// Token: 0x040009CF RID: 2511
		private global::Loupe.Extensibility.Data.LogMessageSeverity m_Severity;

		// Token: 0x040009D0 RID: 2512
		private string m_LogSystem;

		// Token: 0x040009D1 RID: 2513
		private string m_CategoryName;

		// Token: 0x040009D2 RID: 2514
		private string m_UserName;

		// Token: 0x040009D3 RID: 2515
		private string m_Caption;

		// Token: 0x040009D4 RID: 2516
		private string m_Description;

		// Token: 0x040009D5 RID: 2517
		private string m_Details;

		// Token: 0x040009D6 RID: 2518
		private global::Loupe.Extensibility.Data.IExceptionInfo[] m_ExceptionChain;

		// Token: 0x040009D7 RID: 2519
		private string m_MethodName;

		// Token: 0x040009D8 RID: 2520
		private string m_ClassName;

		// Token: 0x040009D9 RID: 2521
		private string m_FileName;

		// Token: 0x040009DA RID: 2522
		private int m_LineNumber;

		// Token: 0x040009DB RID: 2523
		private int m_ThreadIndex;

		// Token: 0x040009DC RID: 2524
		private int m_ThreadId;

		// Token: 0x040009DD RID: 2525
		private readonly bool m_SuppressNotification;

		// Token: 0x040009DE RID: 2526
		private string m_Message;

		// Token: 0x040009E2 RID: 2530
		private const int SerializationVersion = 3;
	}
}
