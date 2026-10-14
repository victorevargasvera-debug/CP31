using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Text;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x0200050E RID: 1294
	internal class LoadMessageLogger
	{
		// Token: 0x06003FDF RID: 16351 RVA: 0x000D3A08 File Offset: 0x000D1C08
		internal LoadMessageLogger(global::System.Action<string> logLoadMessage)
		{
			this._logLoadMessage = logLoadMessage;
		}

		// Token: 0x06003FE0 RID: 16352 RVA: 0x000D3A22 File Offset: 0x000D1C22
		internal virtual void LogLoadMessage(string message, global::System.Data.Entity.Core.Metadata.Edm.EdmType relatedType)
		{
			if (this._logLoadMessage != null)
			{
				this._logLoadMessage(message);
			}
			this.LogMessagesWithTypeInfo(message, relatedType);
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x000D3A40 File Offset: 0x000D1C40
		internal virtual string CreateErrorMessageWithTypeSpecificLoadLogs(string errorMessage, global::System.Data.Entity.Core.Metadata.Edm.EdmType relatedType)
		{
			return new global::System.Text.StringBuilder(errorMessage).AppendLine(this.GetTypeRelatedLogMessage(relatedType)).ToString();
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x000D3A5C File Offset: 0x000D1C5C
		private string GetTypeRelatedLogMessage(global::System.Data.Entity.Core.Metadata.Edm.EdmType relatedType)
		{
			if (this._messages.ContainsKey(relatedType))
			{
				return new global::System.Text.StringBuilder().AppendLine().AppendLine(global::System.Data.Entity.Resources.Strings.ExtraInfo).AppendLine(this._messages[relatedType].ToString()).ToString();
			}
			return string.Empty;
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x000D3AAC File Offset: 0x000D1CAC
		private void LogMessagesWithTypeInfo(string message, global::System.Data.Entity.Core.Metadata.Edm.EdmType relatedType)
		{
			if (this._messages.ContainsKey(relatedType))
			{
				this._messages[relatedType].AppendLine(message);
				return;
			}
			this._messages.Add(relatedType, new global::System.Text.StringBuilder(message));
		}

		// Token: 0x04001649 RID: 5705
		private readonly global::System.Action<string> _logLoadMessage;

		// Token: 0x0400164A RID: 5706
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmType, global::System.Text.StringBuilder> _messages = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmType, global::System.Text.StringBuilder>();
	}
}
