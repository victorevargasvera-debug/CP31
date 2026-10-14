using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000295 RID: 661
	internal class InterceptionContextMutableData
	{
		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060020F1 RID: 8433 RVA: 0x0005BA9C File Offset: 0x00059C9C
		// (set) Token: 0x060020F2 RID: 8434 RVA: 0x0005BAA4 File Offset: 0x00059CA4
		public bool HasExecuted { get; set; }

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060020F3 RID: 8435 RVA: 0x0005BAAD File Offset: 0x00059CAD
		// (set) Token: 0x060020F4 RID: 8436 RVA: 0x0005BAB5 File Offset: 0x00059CB5
		public global::System.Exception OriginalException { get; set; }

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x060020F5 RID: 8437 RVA: 0x0005BABE File Offset: 0x00059CBE
		// (set) Token: 0x060020F6 RID: 8438 RVA: 0x0005BAC6 File Offset: 0x00059CC6
		public global::System.Threading.Tasks.TaskStatus TaskStatus { get; set; }

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060020F7 RID: 8439 RVA: 0x0005BACF File Offset: 0x00059CCF
		private global::System.Collections.Generic.IDictionary<string, object> UserStateMap
		{
			get
			{
				if (this._userStateMap == null)
				{
					this._userStateMap = new global::System.Collections.Generic.Dictionary<string, object>(global::System.StringComparer.Ordinal);
				}
				return this._userStateMap;
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060020F8 RID: 8440 RVA: 0x0005BAEF File Offset: 0x00059CEF
		// (set) Token: 0x060020F9 RID: 8441 RVA: 0x0005BAFC File Offset: 0x00059CFC
		[global::System.Obsolete("Not safe when multiple interceptors are in use. Use SetUserState and FindUserState instead.")]
		public object UserState
		{
			get
			{
				return this.FindUserState("__LegacyUserState__");
			}
			set
			{
				this.SetUserState("__LegacyUserState__", value);
			}
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x0005BB0C File Offset: 0x00059D0C
		public object FindUserState(string key)
		{
			object result;
			if (this._userStateMap == null || !this.UserStateMap.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x0005BB34 File Offset: 0x00059D34
		public void SetUserState(string key, object value)
		{
			this.UserStateMap[key] = value;
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x0005BB43 File Offset: 0x00059D43
		public bool IsExecutionSuppressed
		{
			get
			{
				return this._isSuppressed;
			}
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x0005BB4B File Offset: 0x00059D4B
		public void SuppressExecution()
		{
			if (!this._isSuppressed && this.HasExecuted)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.SuppressionAfterExecution);
			}
			this._isSuppressed = true;
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060020FE RID: 8446 RVA: 0x0005BB6F File Offset: 0x00059D6F
		// (set) Token: 0x060020FF RID: 8447 RVA: 0x0005BB77 File Offset: 0x00059D77
		public global::System.Exception Exception
		{
			get
			{
				return this._exception;
			}
			set
			{
				if (!this.HasExecuted)
				{
					this.SuppressExecution();
				}
				this._exception = value;
			}
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x0005BB8E File Offset: 0x00059D8E
		public void SetExceptionThrown(global::System.Exception exception)
		{
			this.HasExecuted = true;
			this.OriginalException = exception;
			this.Exception = exception;
		}

		// Token: 0x04000B8A RID: 2954
		private const string LegacyUserState = "__LegacyUserState__";

		// Token: 0x04000B8B RID: 2955
		private global::System.Exception _exception;

		// Token: 0x04000B8C RID: 2956
		private bool _isSuppressed;

		// Token: 0x04000B8D RID: 2957
		private global::System.Collections.Generic.IDictionary<string, object> _userStateMap;
	}
}
