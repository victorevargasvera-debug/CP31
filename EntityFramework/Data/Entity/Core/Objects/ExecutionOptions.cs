using System;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x0200040A RID: 1034
	public class ExecutionOptions
	{
		// Token: 0x0600311D RID: 12573 RVA: 0x0009BCC0 File Offset: 0x00099EC0
		public ExecutionOptions(global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			this.MergeOption = mergeOption;
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x0009BCCF File Offset: 0x00099ECF
		public ExecutionOptions(global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool streaming)
		{
			this.MergeOption = mergeOption;
			this.UserSpecifiedStreaming = new bool?(streaming);
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x0009BCEA File Offset: 0x00099EEA
		internal ExecutionOptions(global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool? streaming)
		{
			this.MergeOption = mergeOption;
			this.UserSpecifiedStreaming = streaming;
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06003120 RID: 12576 RVA: 0x0009BD00 File Offset: 0x00099F00
		// (set) Token: 0x06003121 RID: 12577 RVA: 0x0009BD08 File Offset: 0x00099F08
		public global::System.Data.Entity.Core.Objects.MergeOption MergeOption { get; private set; }

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06003122 RID: 12578 RVA: 0x0009BD14 File Offset: 0x00099F14
		[global::System.Obsolete("Queries are now streaming by default unless a retrying ExecutionStrategy is used. This property no longer returns an accurate value.")]
		public bool Streaming
		{
			get
			{
				return this.UserSpecifiedStreaming ?? true;
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06003123 RID: 12579 RVA: 0x0009BD3A File Offset: 0x00099F3A
		// (set) Token: 0x06003124 RID: 12580 RVA: 0x0009BD42 File Offset: 0x00099F42
		internal bool? UserSpecifiedStreaming { get; private set; }

		// Token: 0x06003125 RID: 12581 RVA: 0x0009BD4B File Offset: 0x00099F4B
		public static bool operator ==(global::System.Data.Entity.Core.Objects.ExecutionOptions left, global::System.Data.Entity.Core.Objects.ExecutionOptions right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x0009BD5F File Offset: 0x00099F5F
		public static bool operator !=(global::System.Data.Entity.Core.Objects.ExecutionOptions left, global::System.Data.Entity.Core.Objects.ExecutionOptions right)
		{
			return !(left == right);
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x0009BD6C File Offset: 0x00099F6C
		public override bool Equals(object obj)
		{
			global::System.Data.Entity.Core.Objects.ExecutionOptions executionOptions = obj as global::System.Data.Entity.Core.Objects.ExecutionOptions;
			if (executionOptions == null)
			{
				return false;
			}
			if (this.MergeOption == executionOptions.MergeOption)
			{
				bool? userSpecifiedStreaming = this.UserSpecifiedStreaming;
				bool? userSpecifiedStreaming2 = executionOptions.UserSpecifiedStreaming;
				return userSpecifiedStreaming.GetValueOrDefault() == userSpecifiedStreaming2.GetValueOrDefault() & userSpecifiedStreaming != null == (userSpecifiedStreaming2 != null);
			}
			return false;
		}

		// Token: 0x06003128 RID: 12584 RVA: 0x0009BDC4 File Offset: 0x00099FC4
		public override int GetHashCode()
		{
			return this.MergeOption.GetHashCode() ^ this.UserSpecifiedStreaming.GetHashCode();
		}

		// Token: 0x04001033 RID: 4147
		internal static readonly global::System.Data.Entity.Core.Objects.ExecutionOptions Default = new global::System.Data.Entity.Core.Objects.ExecutionOptions(global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly);
	}
}
