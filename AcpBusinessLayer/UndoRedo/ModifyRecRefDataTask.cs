using System;
using System.Collections.Generic;
using AcpCommonResources;
using AcpUtility;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x02000059 RID: 89
	public class ModifyRecRefDataTask : global::AcpBusinessLayer.UndoRedo.FieldTaskBase
	{
		// Token: 0x06000513 RID: 1299 RVA: 0x0006D5C4 File Offset: 0x0006B7C4
		private ModifyRecRefDataTask()
		{
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0006D5D8 File Offset: 0x0006B7D8
		public ModifyRecRefDataTask(global::AcpBusinessLayer.AcpRecRefField obj, string newValue)
		{
			int a_ = 9;
			base..ctor();
			this.field = obj;
			this.a = newValue;
			this.b = obj.ForceValid;
			base.Description = global::AcpCommonResources.AcpResources.Change.AcpStringFormat(new object[]
			{
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("ﯚￜ", a_) + this.field.UIName + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("栗", a_)
			});
			this.c = new string[obj.SlaveFieldCount];
			int num = 0;
			foreach (global::AcpBusinessLayer.AcpRecRefSlaveItem acpRecRefSlaveItem in obj.SlaveFields)
			{
				this.c[num++] = acpRecRefSlaveItem.SlaveField.UIValue;
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0006D6C0 File Offset: 0x0006B8C0
		public override void Do()
		{
			short num = (short)1663830326;
			short num2 = num;
			num = (short)1843267894;
			switch (num2 == num)
			{
			}
			num = (short)1658716161;
			if (num != 0)
			{
			}
			num = (short)949616640;
			short num3 = num;
			num = (short)90177536;
			if (num != 0)
			{
			}
			this.SwapValues();
			base.Do();
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0006D774 File Offset: 0x0006B974
		public override void Undo()
		{
			short num = (short)1183580161;
			if (num != 0)
			{
			}
			num = (short)679030484;
			short num2 = num;
			num = (short)1891053268;
			switch (num2 == num)
			{
			}
			num = (short)1416232960;
			short num3 = num;
			num = (short)698482688;
			if (num != 0)
			{
			}
			this.SwapValues();
			base.Undo();
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0006D82C File Offset: 0x0006BA2C
		protected virtual void SwapValues()
		{
			short num = (short)250937344;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3B;
				}
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
				for (;;)
				{
					IL_28:
					int num3;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefSlaveItem> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_265;
					case 1:
						try
						{
							num = (short)466681862;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpBusinessLayer.AcpRecRefSlaveItem acpRecRefSlaveItem;
								switch (num2)
								{
								case 0:
									goto IL_1DB;
								case 2:
									if (this.c.Length > num3)
									{
										num = (short)251592707;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1DB;
								case 3:
									goto IL_1A3;
								case 4:
									goto IL_1F4;
								case 5:
									if (!enumerator.MoveNext())
									{
										num = (short)1164181504;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpRecRefSlaveItem = enumerator.Current;
									num = (short)1729232898;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									num = (short)2062769985;
									short num4 = num;
									num = (short)457137985;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1A3;
									default:
										num = (short)1504772096;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_12A;
										}
										continue;
									}
									break;
								}
								}
								IL_12C:
								num = (short)216793093;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12A:
								goto IL_12C;
								IL_1A3:
								acpRecRefSlaveItem.SlaveField.UIValue = this.c[num3++];
								num = (short)296288257;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1DB:
								num = (short)1440546820;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1F4:
							return;
						}
						finally
						{
							num = (short)902758402;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1028456449;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_262;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_22D;
									}
									continue;
								}
								IL_22D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1875771392;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_262:;
						}
						goto IL_265;
					case 2:
						if (base.Done)
						{
							num = (short)1057423360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_3B;
					IL_265:
					num = (short)227606528;
					short num5 = num;
					num = (short)1290076161;
					if (num != 0)
					{
					}
					num3 = 0;
					enumerator = acpRecRefField.SlaveFields.GetEnumerator();
					num = (short)1376911361;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3B:
				acpRecRefField = (this.field as global::AcpBusinessLayer.AcpRecRefField);
				string uivalue = acpRecRefField.UIValue;
				acpRecRefField.UIValue = this.a;
				this.a = uivalue;
				num = (short)1096613890;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0400016E RID: 366
		private string a;

		// Token: 0x0400016F RID: 367
		private bool b;

		// Token: 0x04000170 RID: 368
		private string[] c;
	}
}
