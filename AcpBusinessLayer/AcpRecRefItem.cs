using System;
using System.Runtime.CompilerServices;
using AcpBusinessLayer.UndoRedo;

namespace AcpBusinessLayer
{
	// Token: 0x02000020 RID: 32
	public class AcpRecRefItem : global::AcpBusinessLayer.ListItem
	{
		// Token: 0x060002CA RID: 714 RVA: 0x00037B10 File Offset: 0x00035D10
		public AcpRecRefItem(global::AcpBusinessLayer.AcpRecRefField parent, global::AcpBusinessLayer.FeatureNode node) : this(parent, node, true, true, false)
		{
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00037B28 File Offset: 0x00035D28
		public AcpRecRefItem(global::AcpBusinessLayer.AcpRecRefField parent, global::AcpBusinessLayer.FeatureNode node, bool valid, bool visible) : this(parent, node, valid, visible, false)
		{
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00037B44 File Offset: 0x00035D44
		public AcpRecRefItem(global::AcpBusinessLayer.AcpRecRefField parent, global::AcpBusinessLayer.FeatureNode node, bool valid, bool visible, bool temp) : base(parent, node.ReferenceKey, valid, visible, temp)
		{
			this.Node = node;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00037B6C File Offset: 0x00035D6C
		// (set) Token: 0x060002CE RID: 718 RVA: 0x00037C1C File Offset: 0x00035E1C
		internal global::AcpBusinessLayer.FeatureNode Node
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1758396416;
				short num2 = num;
				num = (short)1474574742;
				short num3 = num;
				num = (short)2058697110;
				switch (num3 == num)
				{
				}
				num = (short)1261568001;
				if (num != 0)
				{
				}
				num = (short)478740480;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2142699520;
				short num2 = num;
				num = (short)1555045159;
				short num3 = num;
				num = (short)1334713127;
				switch (num3 == num)
				{
				}
				num = (short)1654849536;
				if (num != 0)
				{
				}
				num = (short)89915393;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002CF RID: 719 RVA: 0x00037CD0 File Offset: 0x00035ED0
		internal bool ForceValid
		{
			get
			{
				short num = (short)405027009;
				short num2 = num;
				num = (short)1163868353;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_A6:
					if (this.Node == null)
					{
						return true;
					}
					num = (short)156499969;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)734920705;
					if (num != 0)
					{
					}
					num = (short)565837824;
					if (num != 0)
					{
					}
					num = (short)1020395520;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_A6;
						}
						continue;
					case 1:
					{
						num = (short)523239424;
						short num4 = num;
						num = (short)1365770243;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_13E;
					case 3:
						if (this.Node.KeyField != null)
						{
							num = (short)1717829634;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					goto IL_A6;
				}
				IL_13E:
				return this.Node.KeyField.ForceValid;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00037E20 File Offset: 0x00036020
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x00037ED4 File Offset: 0x000360D4
		public override string ItemName
		{
			get
			{
				short num = (short)899416064;
				short num2 = num;
				num = (short)235929288;
				short num3 = num;
				num = (short)854982344;
				switch (num3 == num)
				{
				}
				num = (short)1807810561;
				if (num != 0)
				{
				}
				num = (short)604241920;
				if (num != 0)
				{
				}
				return this.Node.ReferenceKey;
			}
			set
			{
				int a_ = 6;
				short num = (short)1454637056;
				short num2 = num;
				num = (short)2097917765;
				short num3 = num;
				num = (short)323202885;
				switch (num3 == num)
				{
				}
				num = (short)506462208;
				if (num != 0)
				{
				}
				num = (short)1278017537;
				if (num != 0)
				{
				}
				base.OnPropertyChanged(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("釗껙맛돝껟菡解菥", a_));
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00037F98 File Offset: 0x00036198
		protected override void Dispose(bool disposing)
		{
			short num = (short)1711013889;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!this.b)
					{
						goto IL_F9;
					}
					goto IL_205;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 2:
				{
					num = (short)1844641793;
					if (num != 0)
					{
					}
					global::AcpBusinessLayer.FeatureNode node = this.Node;
					if (node == null)
					{
						num = (short)540213254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					node.Dispose();
					num = (short)372637704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					if (disposing)
					{
						num = (short)1918107655;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6E;
				case 4:
					goto IL_89;
				case 5:
					num = (short)1679818752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_6E;
				case 7:
				{
					num = (short)1140981760;
					short num3 = num;
					num = (short)503840770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					goto IL_6E;
				case 9:
				{
					num = (short)364880901;
					short num4 = num;
					num = (short)28353541;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F9;
					default:
						num = (short)469958656;
						if (num != 0)
						{
						}
						this.b = true;
						num = (short)1092026371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_4D:
				if (!this.a)
				{
					num = (short)833617925;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_6E:
				this.a = true;
				num = (short)1509228548;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F9:
				num = (short)1053360137;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_89:
			IL_205:
			this.b = false;
			base.Dispose(disposing);
		}

		// Token: 0x04000095 RID: 149
		private bool a;

		// Token: 0x04000096 RID: 150
		private bool b;

		// Token: 0x04000097 RID: 151
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpBusinessLayer.FeatureNode c;
	}
}
