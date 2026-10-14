using System;

namespace Infragistics
{
	// Token: 0x02000032 RID: 50
	public interface IErrorBarCalculator
	{
		// Token: 0x060002CF RID: 719
		global::Infragistics.ErrorBarCalculatorType GetCalculatorType();

		// Token: 0x060002D0 RID: 720
		double GetIndependentValue();

		// Token: 0x060002D1 RID: 721
		double GetDependentValue(double value);

		// Token: 0x060002D2 RID: 722
		global::Infragistics.IFastItemColumn<double> GetItemColumn();

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060002D3 RID: 723
		// (remove) Token: 0x060002D4 RID: 724
		event global::System.EventHandler<global::System.EventArgs> Changed;

		// Token: 0x060002D5 RID: 725
		bool HasConstantPosition();

		// Token: 0x060002D6 RID: 726
		double GetPosition();
	}
}
