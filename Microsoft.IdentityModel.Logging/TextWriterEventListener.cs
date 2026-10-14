using System;
using System.Diagnostics.Tracing;
using System.IO;

namespace Microsoft.IdentityModel.Logging
{
	// Token: 0x02000005 RID: 5
	public class TextWriterEventListener : global::System.Diagnostics.Tracing.EventListener
	{
		// Token: 0x06000036 RID: 54 RVA: 0x000028D4 File Offset: 0x00000AD4
		public TextWriterEventListener()
		{
			try
			{
				global::System.IO.Stream stream = new global::System.IO.FileStream(global::Microsoft.IdentityModel.Logging.TextWriterEventListener.DefaultLogFileName, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.Write);
				this._streamWriter = new global::System.IO.StreamWriter(stream);
				this._streamWriter.AutoFlush = true;
			}
			catch (global::System.Exception innerException)
			{
				global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException("MIML10001: Cannot create the fileStream or StreamWriter to write logs. See inner exception.", innerException));
				throw;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000293C File Offset: 0x00000B3C
		public TextWriterEventListener(string filePath)
		{
			if (string.IsNullOrEmpty(filePath))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("filePath");
			}
			try
			{
				global::System.IO.Stream stream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.Write);
				this._streamWriter = new global::System.IO.StreamWriter(stream);
				this._streamWriter.AutoFlush = true;
			}
			catch (global::System.Exception innerException)
			{
				global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException("MIML10001: Cannot create the fileStream or StreamWriter to write logs. See inner exception.", innerException));
				throw;
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000029B4 File Offset: 0x00000BB4
		public TextWriterEventListener(global::System.IO.StreamWriter streamWriter)
		{
			if (streamWriter == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("streamWriter");
			}
			this._streamWriter = streamWriter;
			this._disposeStreamWriter = false;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000029E0 File Offset: 0x00000BE0
		protected override void OnEventWritten(global::System.Diagnostics.Tracing.EventWrittenEventArgs eventData)
		{
			if (eventData == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("eventData");
			}
			if (eventData.Payload == null || eventData.Payload.Count <= 0)
			{
				global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("MIML10000: eventData.Payload is null or empty. Not logging any messages.", new object[0]);
				return;
			}
			for (int i = 0; i < eventData.Payload.Count; i++)
			{
				this._streamWriter.WriteLine(eventData.Payload[i].ToString());
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002A54 File Offset: 0x00000C54
		public override void Dispose()
		{
			if (this._disposeStreamWriter && this._streamWriter != null)
			{
				this._streamWriter.Flush();
				this._streamWriter.Dispose();
			}
			base.Dispose();
		}

		// Token: 0x0400000E RID: 14
		private global::System.IO.StreamWriter _streamWriter;

		// Token: 0x0400000F RID: 15
		private bool _disposeStreamWriter = true;

		// Token: 0x04000010 RID: 16
		public static readonly string DefaultLogFileName = "IdentityModelLogs.txt";
	}
}
