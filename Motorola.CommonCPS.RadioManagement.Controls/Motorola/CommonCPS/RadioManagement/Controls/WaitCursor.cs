using System;
using System.Windows.Input;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000114 RID: 276
	public class WaitCursor : global::System.IDisposable
	{
		// Token: 0x060008C1 RID: 2241 RVA: 0x00091E8C File Offset: 0x0009008C
		public WaitCursor()
		{
			this.a = global::System.Windows.Input.Mouse.OverrideCursor;
			global::System.Windows.Input.Mouse.OverrideCursor = global::System.Windows.Input.Cursors.Wait;
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00091EB4 File Offset: 0x000900B4
		public void Dispose()
		{
			short num = (short)498270209;
			if (num != 0)
			{
			}
			num = (short)2008350720;
			short num2 = num;
			num = (short)626579243;
			short num3 = num;
			num = (short)563009323;
			switch (num3 == num)
			{
			}
			num = (short)2116878336;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00091F70 File Offset: 0x00090170
		protected virtual void Dispose(bool disposing)
		{
			if (this.b)
			{
				short num = (short)800194561;
				if (num != 0)
				{
				}
				num = (short)1129820525;
				short num2 = num;
				num = (short)1018016109;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)787283968;
					short num3 = num;
					num = (short)1199308800;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			global::System.Windows.Input.Mouse.OverrideCursor = this.a;
			this.b = true;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x0009203C File Offset: 0x0009023C
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1213654125;
				short num2 = num;
				num = (short)144237677;
				switch (num2 == num)
				{
				}
				num = (short)574160896;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				base.Finalize();
			}
			num = (short)684392449;
			if (num != 0)
			{
			}
			num = (short)1821376512;
			short num3 = num;
		}

		// Token: 0x04000412 RID: 1042
		private global::System.Windows.Input.Cursor a;

		// Token: 0x04000413 RID: 1043
		private bool b;
	}
}
