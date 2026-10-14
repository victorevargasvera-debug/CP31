using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;

namespace AcpBusinessLayer
{
	// Token: 0x0200003F RID: 63
	public class MultiRecordTaskBase : global::AcpCommonLib.UndoRedo.UndoableTask
	{
		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00065DE8 File Offset: 0x00063FE8
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00065E98 File Offset: 0x00064098
		protected int Count
		{
			get
			{
				short num = (short)982835970;
				short num2 = num;
				num = (short)1616438018;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1979056128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)618528768;
				if (num != 0)
				{
				}
				num = (short)299499521;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)394788865;
				if (num != 0)
				{
				}
				num = (short)1040842752;
				short num2 = num;
				num = (short)230262453;
				short num3 = num;
				num = (short)211846837;
				switch (num3 == num)
				{
				}
				num = (short)1854996480;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00065F48 File Offset: 0x00064148
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00065FF8 File Offset: 0x000641F8
		private protected global::AcpBusinessLayer.FeatureNode[] Records
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected get
			{
				short num = (short)440289056;
				short num2 = num;
				num = (short)555173664;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1908146176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)762183680;
				if (num != 0)
				{
				}
				num = (short)71041025;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)270237517;
				short num2 = num;
				num = (short)1667661645;
				switch (num2 == num)
				{
				default:
				{
					num = (short)192675840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)789643265;
				if (num != 0)
				{
				}
				num = (short)620691456;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x000660A4 File Offset: 0x000642A4
		protected MultiRecordTaskBase()
		{
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x000660B8 File Offset: 0x000642B8
		protected MultiRecordTaskBase(global::AcpBusinessLayer.FeatureNode[] records)
		{
			this.Records = records;
			this.a = records.Length;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x000660DC File Offset: 0x000642DC
		public override void LaunchUI()
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			global::AcpBusinessLayer.FeatureNode featureNode;
			short num2;
			for (;;)
			{
				IL_0A:
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
				switch (num)
				{
				case 0:
					goto IL_A9;
				case 1:
				{
					int count;
					acpFeatureNode = ((global::AcpBusinessLayer.Recordset)featureNode.Parent)[count - 1];
					num2 = (short)1968177159;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					if (((global::AcpBusinessLayer.Recordset)featureNode.Parent).Contains(featureNode))
					{
						num2 = (short)318767110;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					int count = ((global::AcpBusinessLayer.Recordset)featureNode.Parent).Count;
					num2 = (short)42205189;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (featureNode.Parent.IsEmbeddedRecset)
					{
						num2 = (short)730071040;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpFeatureNode = null;
					num2 = (short)138215426;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_22A;
				case 5:
				{
					int count;
					if (count > 0)
					{
						num2 = (short)846528513;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22A;
				}
				case 6:
					goto IL_195;
				case 7:
					goto IL_22A;
				case 8:
					return;
				case 9:
				{
					num2 = (short)1819643364;
					short num3 = num2;
					num2 = (short)400133604;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_195;
					default:
					{
						num2 = (short)700514304;
						if (num2 != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = acpFeatureNode.FeatureSectionsCollection.GetEnumerator();
						enumerator.MoveNext();
						global::AcpCommonLib.UndoRedo.UndoManager.GoToSection(enumerator.Current);
						num2 = (short)285802504;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 10:
					if (acpFeatureNode != null)
					{
						num2 = (short)537067529;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_3C;
				IL_195:
				acpFeatureNode = this.Records[this.a - 1];
				num2 = (short)1446379524;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_22A:
				num2 = (short)573571082;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_A9:
			num2 = (short)575406080;
			short num4 = num2;
			global::AcpCommonLib.UndoRedo.UndoManager.GoToSection(featureNode.Parent.ParentSection);
			return;
			IL_3C:
			featureNode = this.Records[0];
			num2 = (short)732626945;
			if (num2 != 0)
			{
			}
			num2 = (short)382861315;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000146 RID: 326
		private int a;

		// Token: 0x04000147 RID: 327
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpBusinessLayer.FeatureNode[] b;
	}
}
