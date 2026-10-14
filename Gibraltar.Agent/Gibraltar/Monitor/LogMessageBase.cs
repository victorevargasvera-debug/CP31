using System;
using System.Runtime.CompilerServices;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x02000196 RID: 406
	internal abstract class LogMessageBase
	{
		// Token: 0x06001163 RID: 4451 RVA: 0x00032220 File Offset: 0x00030420
		protected LogMessageBase(global::Loupe.Extensibility.Data.LogMessageSeverity severity, string logSystem, string categoryName)
		{
			this.m_Severity = severity;
			this.m_LogSystem = logSystem;
			this.m_CategoryName = categoryName;
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x00032240 File Offset: 0x00030440
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		protected LogMessageBase(global::Loupe.Extensibility.Data.LogMessageSeverity severity, string logSystem, string categoryName, int skipFrames, bool localOrigin, bool attributeToException, global::System.Exception exception)
		{
			this.m_Severity = severity;
			this.m_LogSystem = logSystem;
			this.m_CategoryName = categoryName;
			if (attributeToException && exception != null)
			{
				global::Gibraltar.ExceptionSourceProvider exceptionSourceProvider = new global::Gibraltar.ExceptionSourceProvider(exception);
				if (!string.IsNullOrEmpty(exceptionSourceProvider.ClassName))
				{
					this.m_MessageSourceProvider = exceptionSourceProvider;
				}
			}
			this.m_MessageSourceProvider = (this.m_MessageSourceProvider ?? new global::Gibraltar.Monitor.MessageSourceProvider(skipFrames + 1, localOrigin));
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x000322B8 File Offset: 0x000304B8
		public global::Loupe.Extensibility.Data.LogMessageSeverity Severity
		{
			get
			{
				return this.m_Severity;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x000322C0 File Offset: 0x000304C0
		public string LogSystem
		{
			get
			{
				return this.m_LogSystem;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001167 RID: 4455 RVA: 0x000322C8 File Offset: 0x000304C8
		public string CategoryName
		{
			get
			{
				return this.m_CategoryName;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x000322D0 File Offset: 0x000304D0
		// (set) Token: 0x06001169 RID: 4457 RVA: 0x000322D8 File Offset: 0x000304D8
		public string Caption
		{
			get
			{
				return this.m_Caption;
			}
			protected set
			{
				this.m_Caption = value;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x000322E4 File Offset: 0x000304E4
		// (set) Token: 0x0600116B RID: 4459 RVA: 0x000322EC File Offset: 0x000304EC
		public string Description
		{
			get
			{
				return this.m_Description;
			}
			protected set
			{
				this.m_Description = value;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x000322F8 File Offset: 0x000304F8
		// (set) Token: 0x0600116D RID: 4461 RVA: 0x00032300 File Offset: 0x00030500
		public object[] MessageArgs
		{
			get
			{
				return this.m_MessageArgs;
			}
			protected set
			{
				this.m_MessageArgs = value;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x0003230C File Offset: 0x0003050C
		// (set) Token: 0x0600116F RID: 4463 RVA: 0x00032314 File Offset: 0x00030514
		public string DetailsXml
		{
			get
			{
				return this.m_DetailsXml;
			}
			protected set
			{
				this.m_DetailsXml = value;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001170 RID: 4464 RVA: 0x00032320 File Offset: 0x00030520
		// (set) Token: 0x06001171 RID: 4465 RVA: 0x00032328 File Offset: 0x00030528
		public global::System.Exception Exception
		{
			get
			{
				return this.m_Exception;
			}
			protected set
			{
				this.m_Exception = value;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x00032334 File Offset: 0x00030534
		// (set) Token: 0x06001173 RID: 4467 RVA: 0x0003233C File Offset: 0x0003053C
		public bool AttributeToException
		{
			get
			{
				return this.m_AttributeToException;
			}
			protected set
			{
				this.m_AttributeToException = value;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x00032348 File Offset: 0x00030548
		// (set) Token: 0x06001175 RID: 4469 RVA: 0x00032350 File Offset: 0x00030550
		public global::Gibraltar.Monitor.LogWriteMode WriteMode
		{
			get
			{
				return this.m_WriteMode;
			}
			protected set
			{
				this.m_WriteMode = value;
			}
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0003235C File Offset: 0x0003055C
		protected static global::System.Exception FirstException(object[] args)
		{
			if (args == null)
			{
				return null;
			}
			for (int i = 0; i < args.Length; i++)
			{
				global::System.Exception ex = args[i] as global::System.Exception;
				if (ex != null)
				{
					return ex;
				}
			}
			return null;
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x00032398 File Offset: 0x00030598
		public void PublishToLog()
		{
			global::Gibraltar.Monitor.Log.WriteMessage(this.m_Severity, this.m_WriteMode, this.m_LogSystem, this.m_CategoryName, this.m_MessageSourceProvider, null, this.m_Exception, this.m_DetailsXml, this.m_Caption, this.m_Description, this.m_MessageArgs);
		}

		// Token: 0x040005E0 RID: 1504
		private readonly global::Loupe.Extensibility.Data.LogMessageSeverity m_Severity;

		// Token: 0x040005E1 RID: 1505
		private readonly string m_LogSystem;

		// Token: 0x040005E2 RID: 1506
		private readonly string m_CategoryName;

		// Token: 0x040005E3 RID: 1507
		private readonly global::Gibraltar.Monitor.IMessageSourceProvider m_MessageSourceProvider;

		// Token: 0x040005E4 RID: 1508
		private string m_Caption;

		// Token: 0x040005E5 RID: 1509
		private string m_Description;

		// Token: 0x040005E6 RID: 1510
		private object[] m_MessageArgs;

		// Token: 0x040005E7 RID: 1511
		private string m_DetailsXml;

		// Token: 0x040005E8 RID: 1512
		private global::System.Exception m_Exception;

		// Token: 0x040005E9 RID: 1513
		private global::Gibraltar.Monitor.LogWriteMode m_WriteMode;

		// Token: 0x040005EA RID: 1514
		private bool m_AttributeToException;
	}
}
