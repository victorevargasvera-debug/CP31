using System;
using AcpCommonLib.UndoRedo;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x02000056 RID: 86
	public class FieldTaskBase : global::AcpCommonLib.UndoRedo.UndoableTask
	{
		// Token: 0x06000507 RID: 1287 RVA: 0x0006CBE0 File Offset: 0x0006ADE0
		public override void LaunchUI()
		{
			short num = (short)594895900;
			short num2 = num;
			num = (short)145581084;
			switch (num2 == num)
			{
			}
			num = (short)381419520;
			if (num != 0)
			{
			}
			num = (short)1523712000;
			short num3 = num;
			num = (short)1746862081;
			if (num != 0)
			{
			}
			global::AcpCommonLib.UndoRedo.UndoManager.GoToSection(this.field.Parent);
		}

		// Token: 0x04000167 RID: 359
		protected internal global::AcpBusinessLayer.AcpFieldBase field;
	}
}
