using System;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000267 RID: 615
	public class TransactionRow
	{
		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06001F4C RID: 8012 RVA: 0x00055CC8 File Offset: 0x00053EC8
		// (set) Token: 0x06001F4D RID: 8013 RVA: 0x00055CD0 File Offset: 0x00053ED0
		public global::System.Guid Id { get; set; }

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001F4E RID: 8014 RVA: 0x00055CD9 File Offset: 0x00053ED9
		// (set) Token: 0x06001F4F RID: 8015 RVA: 0x00055CE1 File Offset: 0x00053EE1
		public global::System.DateTime CreationTime { get; set; }

		// Token: 0x06001F50 RID: 8016 RVA: 0x00055CEC File Offset: 0x00053EEC
		public override bool Equals(object obj)
		{
			global::System.Data.Entity.Infrastructure.TransactionRow transactionRow = obj as global::System.Data.Entity.Infrastructure.TransactionRow;
			return transactionRow != null && this.Id == transactionRow.Id;
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x00055D18 File Offset: 0x00053F18
		public override int GetHashCode()
		{
			return this.Id.GetHashCode();
		}
	}
}
