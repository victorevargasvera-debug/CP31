using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x02000017 RID: 23
	public class AstroManagedFileSeqManager : global::Motorola.Common.Communication.AstroFileSeqManager, global::Motorola.Common.Communication.IDepotSequenceManager
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x00017B3C File Offset: 0x00015D3C
		public AstroManagedFileSeqManager(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter) : base(rcmpWrapper, sessionParameter)
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00017B54 File Offset: 0x00015D54
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			short num = (short)1918415463;
			short num2 = num;
			num = (short)1069265511;
			switch (num2 == num)
			{
			}
			num = (short)1472856065;
			if (num != 0)
			{
			}
			num = (short)18939904;
			if (num != 0)
			{
			}
			num = (short)1650851840;
			short num3 = num;
			return base.ManagedReadDevice(referencePba, sessionID);
		}
	}
}
