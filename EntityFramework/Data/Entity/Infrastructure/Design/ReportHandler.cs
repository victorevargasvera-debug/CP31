using System;

namespace System.Data.Entity.Infrastructure.Design
{
	// Token: 0x020002A3 RID: 675
	public class ReportHandler : global::System.Data.Entity.Infrastructure.Design.HandlerBase, global::System.Data.Entity.Infrastructure.Design.IReportHandler
	{
		// Token: 0x06002177 RID: 8567 RVA: 0x0005CE37 File Offset: 0x0005B037
		public ReportHandler(global::System.Action<string> errorHandler, global::System.Action<string> warningHandler, global::System.Action<string> informationHandler, global::System.Action<string> verboseHandler)
		{
			this._errorHandler = errorHandler;
			this._warningHandler = warningHandler;
			this._informationHandler = informationHandler;
			this._verboseHandler = verboseHandler;
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x0005CE5C File Offset: 0x0005B05C
		public virtual void OnError(string message)
		{
			global::System.Action<string> errorHandler = this._errorHandler;
			if (errorHandler == null)
			{
				return;
			}
			errorHandler(message);
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x0005CE6F File Offset: 0x0005B06F
		public virtual void OnWarning(string message)
		{
			global::System.Action<string> warningHandler = this._warningHandler;
			if (warningHandler == null)
			{
				return;
			}
			warningHandler(message);
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x0005CE82 File Offset: 0x0005B082
		public virtual void OnInformation(string message)
		{
			global::System.Action<string> informationHandler = this._informationHandler;
			if (informationHandler == null)
			{
				return;
			}
			informationHandler(message);
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x0005CE95 File Offset: 0x0005B095
		public virtual void OnVerbose(string message)
		{
			global::System.Action<string> verboseHandler = this._verboseHandler;
			if (verboseHandler == null)
			{
				return;
			}
			verboseHandler(message);
		}

		// Token: 0x04000BA0 RID: 2976
		private readonly global::System.Action<string> _errorHandler;

		// Token: 0x04000BA1 RID: 2977
		private readonly global::System.Action<string> _warningHandler;

		// Token: 0x04000BA2 RID: 2978
		private readonly global::System.Action<string> _informationHandler;

		// Token: 0x04000BA3 RID: 2979
		private readonly global::System.Action<string> _verboseHandler;
	}
}
