using System;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000202 RID: 514
	public class NotImplementedFunctionException : global::System.NotImplementedException
	{
		// Token: 0x06000CD4 RID: 3284 RVA: 0x00023249 File Offset: 0x00021449
		public NotImplementedFunctionException(string functionName) : base(functionName)
		{
			this.functionName = functionName;
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00023259 File Offset: 0x00021459
		public NotImplementedFunctionException(string functionName, global::System.NotImplementedException cause) : base(functionName, cause)
		{
			this.functionName = functionName;
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x0002326A File Offset: 0x0002146A
		public string FunctionName
		{
			get
			{
				return this.functionName;
			}
		}

		// Token: 0x040005D6 RID: 1494
		private string functionName;
	}
}
