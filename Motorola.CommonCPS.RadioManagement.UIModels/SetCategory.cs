using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Practices.Prism.Commands;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000EA RID: 234
	public abstract class SetCategory : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::Motorola.CommonCPS.RadioManagement.UIModels.ITreeNode
	{
		// Token: 0x06000B39 RID: 2873 RVA: 0x000AA03C File Offset: 0x000A823C
		public SetCategory()
		{
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000B3A RID: 2874 RVA: 0x000AA070 File Offset: 0x000A8270
		// (remove) Token: 0x06000B3B RID: 2875 RVA: 0x000AA1A4 File Offset: 0x000A83A4
		public event global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangingEventHandler ActiveSetChanging
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)1313166955;
				short num2 = num;
				num = (short)1465407083;
				global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangingEventHandler activeSetChangingEventHandler2;
				global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangingEventHandler activeSetChangingEventHandler;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_AE:
					activeSetChangingEventHandler = activeSetChangingEventHandler2;
					global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangingEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangingEventHandler)global::System.Delegate.Combine(activeSetChangingEventHandler, value);
					activeSetChangingEventHandler2 = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangingEventHandler>(ref this.h, value2, activeSetChangingEventHandler);
					num = (short)687931393;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				case 1:
					goto IL_60;
				default:
				{
					num = (short)1087700992;
					short num4 = num;
					goto IL_60;
				}
				}
				for (;;)
				{
					IL_7F:
					switch (num3)
					{
					case 0:
						goto IL_AC;
					case 1:
						if (activeSetChangingEventHandler2 == activeSetChangingEventHandler)
						{
							num = (short)1416560642;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE;
					case 2:
						goto IL_FA;
					}
					goto IL_91;
				}
				IL_AC:
				goto IL_AE;
				IL_FA:
				num = (short)744554497;
				if (num != 0)
				{
				}
				return;
				IL_60:
				num = (short)1155661824;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_91;
				}
				goto IL_7F;
				IL_91:
				activeSetChangingEventHandler2 = this.h;
				num = (short)395247616;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7F;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)484501753;
				short num2 = num;
				num = (short)2087905529;
				global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangingEventHandler activeSetChangingEventHandler2;
				global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangingEventHandler activeSetChangingEventHandler;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_D8:
					activeSetChangingEventHandler = activeSetChangingEventHandler2;
					global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangingEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangingEventHandler)global::System.Delegate.Remove(activeSetChangingEventHandler, value);
					activeSetChangingEventHandler2 = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangingEventHandler>(ref this.h, value2, activeSetChangingEventHandler);
					num = (short)1707606017;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				case 1:
					goto IL_5E;
				default:
				{
					num = (short)1253441536;
					short num4 = num;
					goto IL_5E;
				}
				}
				for (;;)
				{
					IL_7F:
					switch (num3)
					{
					case 0:
						goto IL_AE;
					case 1:
						if (activeSetChangingEventHandler2 == activeSetChangingEventHandler)
						{
							num = (short)1962278914;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D8;
					case 2:
						return;
					}
					goto IL_91;
				}
				IL_AE:
				num = (short)1009188865;
				if (num != 0)
				{
				}
				goto IL_D8;
				IL_5E:
				num = (short)1394737152;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_91;
				}
				goto IL_7F;
				IL_91:
				activeSetChangingEventHandler2 = this.h;
				num = (short)1933901824;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7F;
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000B3C RID: 2876 RVA: 0x000AA2DC File Offset: 0x000A84DC
		// (remove) Token: 0x06000B3D RID: 2877 RVA: 0x000AA410 File Offset: 0x000A8610
		public event global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangedEventHandler ActiveSetChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)559613295;
				short num2 = num;
				num = (short)1970144623;
				global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangedEventHandler activeSetChangedEventHandler2;
				global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangedEventHandler activeSetChangedEventHandler;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_D4:
					activeSetChangedEventHandler = activeSetChangedEventHandler2;
					global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangedEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangedEventHandler)global::System.Delegate.Combine(activeSetChangedEventHandler, value);
					activeSetChangedEventHandler2 = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangedEventHandler>(ref this.i, value2, activeSetChangedEventHandler);
					num = (short)1965031425;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				case 1:
					goto IL_5D;
				default:
				{
					num = (short)1278541824;
					short num4 = num;
					goto IL_5D;
				}
				}
				for (;;)
				{
					IL_7D:
					switch (num3)
					{
					case 0:
						goto IL_AB;
					case 1:
						if (activeSetChangedEventHandler2 == activeSetChangedEventHandler)
						{
							num = (short)896008194;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D4;
					case 2:
						return;
					}
					goto IL_8F;
				}
				IL_AB:
				num = (short)195887105;
				if (num != 0)
				{
				}
				goto IL_D4;
				IL_5D:
				num = (short)1782513664;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				goto IL_7D;
				IL_8F:
				activeSetChangedEventHandler2 = this.i;
				num = (short)1826226176;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7D;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)399401848;
				short num2 = num;
				num = (short)1839555448;
				global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangedEventHandler activeSetChangedEventHandler2;
				global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangedEventHandler activeSetChangedEventHandler;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_D6:
					activeSetChangedEventHandler = activeSetChangedEventHandler2;
					global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangedEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangedEventHandler)global::System.Delegate.Remove(activeSetChangedEventHandler, value);
					activeSetChangedEventHandler2 = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangedEventHandler>(ref this.i, value2, activeSetChangedEventHandler);
					num = (short)1923743745;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				case 1:
					goto IL_5F;
				default:
				{
					num = (short)90374144;
					short num4 = num;
					goto IL_5F;
				}
				}
				for (;;)
				{
					IL_7F:
					num = (short)2106654721;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_D4;
					case 1:
						if (activeSetChangedEventHandler2 == activeSetChangedEventHandler)
						{
							num = (short)1034092546;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D6;
					case 2:
						return;
					}
					goto IL_B8;
				}
				IL_D4:
				goto IL_D6;
				IL_5F:
				num = (short)1181024256;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_B8;
				}
				goto IL_7F;
				IL_B8:
				activeSetChangedEventHandler2 = this.i;
				num = (short)1084358656;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7F;
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000B3E RID: 2878 RVA: 0x000AA548 File Offset: 0x000A8748
		// (remove) Token: 0x06000B3F RID: 2879 RVA: 0x000AA678 File Offset: 0x000A8878
		public event global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.FieldVisibilityChangedEventHandler FieldVisibilityChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)1132017815;
				short num2 = num;
				num = (short)1231763607;
				global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.FieldVisibilityChangedEventHandler fieldVisibilityChangedEventHandler2;
				global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.FieldVisibilityChangedEventHandler fieldVisibilityChangedEventHandler;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_D0:
					fieldVisibilityChangedEventHandler = fieldVisibilityChangedEventHandler2;
					global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.FieldVisibilityChangedEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.FieldVisibilityChangedEventHandler)global::System.Delegate.Combine(fieldVisibilityChangedEventHandler, value);
					fieldVisibilityChangedEventHandler2 = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.FieldVisibilityChangedEventHandler>(ref this.j, value2, fieldVisibilityChangedEventHandler);
					num = (short)1163984897;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				case 1:
					goto IL_5C;
				default:
				{
					num = (short)1782906880;
					short num4 = num;
					goto IL_5C;
				}
				}
				for (;;)
				{
					IL_7B:
					switch (num3)
					{
					case 0:
						goto IL_A8;
					case 1:
						if (fieldVisibilityChangedEventHandler2 == fieldVisibilityChangedEventHandler)
						{
							num = (short)683868162;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D0;
					case 2:
						return;
					}
					goto IL_8D;
				}
				IL_A8:
				num = (short)493027329;
				if (num != 0)
				{
				}
				goto IL_D0;
				IL_5C:
				num = (short)1488453632;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8D;
				}
				goto IL_7B;
				IL_8D:
				fieldVisibilityChangedEventHandler2 = this.j;
				num = (short)2014969856;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7B;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1646216819;
				short num2 = num;
				num = (short)907757171;
				global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.FieldVisibilityChangedEventHandler fieldVisibilityChangedEventHandler2;
				global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.FieldVisibilityChangedEventHandler fieldVisibilityChangedEventHandler;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_B1:
					fieldVisibilityChangedEventHandler = fieldVisibilityChangedEventHandler2;
					global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.FieldVisibilityChangedEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.FieldVisibilityChangedEventHandler)global::System.Delegate.Remove(fieldVisibilityChangedEventHandler, value);
					fieldVisibilityChangedEventHandler2 = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.FieldVisibilityChangedEventHandler>(ref this.j, value2, fieldVisibilityChangedEventHandler);
					num = (short)1257242625;
					if (num != 0)
					{
					}
					num = (short)1604714497;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				case 1:
					goto IL_62;
				default:
				{
					num = (short)959447040;
					short num4 = num;
					goto IL_62;
				}
				}
				for (;;)
				{
					IL_81:
					switch (num3)
					{
					case 0:
						goto IL_AF;
					case 1:
						if (fieldVisibilityChangedEventHandler2 == fieldVisibilityChangedEventHandler)
						{
							num = (short)495976450;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B1;
					case 2:
						return;
					}
					goto IL_93;
				}
				IL_AF:
				goto IL_B1;
				IL_62:
				num = (short)1178533888;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_93;
				}
				goto IL_81;
				IL_93:
				fieldVisibilityChangedEventHandler2 = this.j;
				num = (short)555155456;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_81;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x000AA7B0 File Offset: 0x000A89B0
		// (set) Token: 0x06000B41 RID: 2881 RVA: 0x000AA860 File Offset: 0x000A8A60
		public global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>> SetsBuilder
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private get
			{
				short num = (short)2049245184;
				short num2 = num;
				num = (short)1518534657;
				if (num != 0)
				{
				}
				num = (short)1785331601;
				short num3 = num;
				num = (short)939851665;
				switch (num3 == num)
				{
				}
				num = (short)217055232;
				if (num != 0)
				{
				}
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1881800704;
				short num2 = num;
				num = (short)1420374144;
				short num3 = num;
				num = (short)2012950656;
				switch (num3 == num)
				{
				}
				num = (short)1664548865;
				if (num != 0)
				{
				}
				num = (short)301137920;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x000AA910 File Offset: 0x000A8B10
		// (set) Token: 0x06000B43 RID: 2883 RVA: 0x000AA9C0 File Offset: 0x000A8BC0
		public virtual global::Motorola.CommonCPS.RadioManagement.UIModels.Set ActiveSet
		{
			get
			{
				short num = (short)1546846208;
				short num2 = num;
				num = (short)1389293756;
				short num3 = num;
				num = (short)769061052;
				switch (num3 == num)
				{
				}
				num = (short)826212353;
				if (num != 0)
				{
				}
				num = (short)1582366720;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)193605341;
				short num2 = num;
				num = (short)211168989;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_146:
					if (this.c == null)
					{
						goto IL_394;
					}
					num = (short)1789919235;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1058340864;
					if (num != 0)
					{
					}
					num = (short)1565261824;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					IL_69:
					global::Motorola.CommonCPS.RadioManagement.UIModels.Set oldSet;
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_BF;
						}
						continue;
					case 1:
						goto IL_121;
					case 2:
						num = (short)1306591239;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						this.c.Parent = this;
						num = (short)647036944;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_146;
					case 5:
						return;
					case 6:
					{
						oldSet = this.c;
						global::Motorola.CommonCPS.RadioManagement.UIModels.ActiveSetChangingEventArgs activeSetChangingEventArgs = new global::Motorola.CommonCPS.RadioManagement.UIModels.ActiveSetChangingEventArgs
						{
							NewSet = value
						};
						num = (short)1866006528;
						short num4 = num;
						num = (short)1612513295;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1841758209;
						if (num != 0)
						{
						}
						if (!value.IsNew)
						{
							num = (short)56360969;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D7;
					case 8:
						if (value != null)
						{
							num = (short)146800642;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D7;
					case 9:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ActiveSetChangingEventArgs activeSetChangingEventArgs;
						this.h(this, activeSetChangingEventArgs);
						num = (short)162201618;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_2D2;
					case 11:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ActiveSetChangingEventArgs activeSetChangingEventArgs;
						if (activeSetChangingEventArgs.IsCancelled)
						{
							num = (short)1956642821;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.c = value;
						num = (short)668729348;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						num = (short)2014183432;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_2AB;
					case 14:
						this.ParentSetCategory.ActiveSet = (global::Motorola.CommonCPS.RadioManagement.UIModels.Set)this.ActiveSet.Parent.Parent.Parent;
						num = (short)930676737;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (this.h != null)
						{
							num = (short)1873412108;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D7;
					case 16:
						if (this.IsExpandEmbeddedSet)
						{
							num = (short)623509518;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_394;
					case 17:
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.get_ActiveSet())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1168179213;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_2D7;
					case 19:
						if (!base.IsLoading)
						{
							num = (short)1632960529;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AB;
					}
					IL_BF:
					if (value != this.c)
					{
						num = (short)592838662;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_2AB:
					global::Motorola.CommonCPS.RadioManagement.UIModels.ActiveSetChangedEventArgs activeSetChangedEventArgs = new global::Motorola.CommonCPS.RadioManagement.UIModels.ActiveSetChangedEventArgs(oldSet, value);
					this.OnActiveSetChanged(this, activeSetChangedEventArgs);
					num = (short)996868106;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D7:
					num = (short)1065615371;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_121:
				goto IL_394;
				IL_2D2:
				return;
				IL_394:
				num = (short)1277231123;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_69;
			}
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x000AADCC File Offset: 0x000A8FCC
		protected virtual void OnActiveSetChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory sender, global::Motorola.CommonCPS.RadioManagement.UIModels.ActiveSetChangedEventArgs activeSetChangedEventArgs)
		{
			short num = (short)927662080;
			short num2 = num;
			num = (short)1619324802;
			short num3 = num;
			num = (short)376041346;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_87:
				switch (0)
				{
				case 0:
					goto IL_AB;
				}
				break;
			default:
				num = (short)756088832;
				if (num != 0)
				{
				}
				num = (short)1406468096;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				IL_91:
				switch (num4)
				{
				case 0:
					goto IL_87;
				case 1:
					num = (short)1838612483;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_119;
				case 3:
					if (this.i != null)
					{
						num = (short)2061893636;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					this.i(sender, activeSetChangedEventArgs);
					num = (short)588316673;
					if (num != 0)
					{
					}
					num = (short)2080636930;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_AB;
			}
			IL_119:
			return;
			IL_AB:
			if (!this.PreventInvokeActiveSetChangedEvent)
			{
				num = (short)1184759809;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_91;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x000AAF30 File Offset: 0x000A9130
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x000AAFE0 File Offset: 0x000A91E0
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> SelectedSets
		{
			get
			{
				short num = (short)830472192;
				short num2 = num;
				num = (short)594146501;
				short num3 = num;
				num = (short)317650117;
				switch (num3 == num)
				{
				}
				num = (short)523567105;
				if (num != 0)
				{
				}
				num = (short)1005584384;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)121831424;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)2079784961;
							if (num != 0)
							{
							}
							num = (short)697442383;
							short num3 = num;
							num = (short)1193091151;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)632291328;
								if (num != 0)
								{
								}
								num = (short)242876416;
								short num4 = num;
								switch (0)
								{
								case 0:
									goto IL_D7;
								}
								continue;
							}
							}
							break;
						}
						case 1:
							this.a = value;
							num = (short)2017132547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							return;
						case 3:
							if (!base.IsLoading)
							{
								num = (short)1340604420;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 4:
							base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.get_SelectedSets())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1690566658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_D7:
						if (value == this.a)
						{
							return;
						}
						num = (short)128319489;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x000AB178 File Offset: 0x000A9378
		public virtual bool IsEmpty
		{
			get
			{
				short num = (short)177537024;
				short num2 = num;
				num = (short)1420689409;
				if (num != 0)
				{
				}
				num = (short)1650626024;
				short num3 = num;
				num = (short)1490193896;
				switch (num3 == num)
				{
				}
				num = (short)1628962816;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x000AB224 File Offset: 0x000A9424
		public virtual bool IsRoot
		{
			get
			{
				short num = (short)1765670912;
				short num2 = num;
				num = (short)435756612;
				short num3 = num;
				num = (short)420945476;
				switch (num3 == num)
				{
				}
				num = (short)225771520;
				if (num != 0)
				{
				}
				num = (short)1771765761;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x000AB2D0 File Offset: 0x000A94D0
		public virtual bool IsFake
		{
			get
			{
				short num = (short)722665472;
				short num2 = num;
				num = (short)714989128;
				short num3 = num;
				num = (short)1684069960;
				switch (num3 == num)
				{
				}
				num = (short)112590849;
				if (num != 0)
				{
				}
				num = (short)2029322240;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x000AB378 File Offset: 0x000A9578
		// (set) Token: 0x06000B4B RID: 2891 RVA: 0x000AB428 File Offset: 0x000A9628
		public bool IsTopSet
		{
			get
			{
				short num = (short)910819328;
				short num2 = num;
				num = (short)1458606845;
				short num3 = num;
				num = (short)144020221;
				switch (num3 == num)
				{
				}
				num = (short)918224896;
				if (num != 0)
				{
				}
				num = (short)100007937;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1635188736;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)577634304;
						short num3 = num;
						switch (num2)
						{
						case 0:
						{
							num = (short)1334993276;
							short num4 = num;
							num = (short)264921468;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)1260650496;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_AE;
								}
								continue;
							}
							break;
						}
						case 1:
							this.d = value;
							num = (short)1556348931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							return;
						case 3:
							if (!base.IsLoading)
							{
								num = (short)1891631105;
								if (num != 0)
								{
								}
								num = (short)1793130500;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 4:
							base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.get_IsTopSet())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1350041602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_AE:
						if (value == this.d)
						{
							return;
						}
						num = (short)880672769;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x000AB5C0 File Offset: 0x000A97C0
		// (set) Token: 0x06000B4D RID: 2893 RVA: 0x000AB670 File Offset: 0x000A9870
		public bool IsExpandEmbeddedSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1791950848;
				short num2 = num;
				num = (short)1660813177;
				short num3 = num;
				num = (short)1950875513;
				switch (num3 == num)
				{
				}
				num = (short)2043019265;
				if (num != 0)
				{
				}
				num = (short)838598656;
				if (num != 0)
				{
				}
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2075656192;
				short num2 = num;
				num = (short)754135833;
				short num3 = num;
				num = (short)2023043865;
				switch (num3 == num)
				{
				}
				num = (short)560332801;
				if (num != 0)
				{
				}
				num = (short)327417856;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x000AB720 File Offset: 0x000A9920
		// (set) Token: 0x06000B4F RID: 2895 RVA: 0x000AB7D0 File Offset: 0x000A99D0
		public bool TelePortMode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1660682240;
				short num2 = num;
				num = (short)345112577;
				if (num != 0)
				{
				}
				num = (short)2020117292;
				short num3 = num;
				num = (short)194939692;
				switch (num3 == num)
				{
				}
				num = (short)1758003200;
				if (num != 0)
				{
				}
				return this.m;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1344077824;
				short num2 = num;
				num = (short)419131678;
				short num3 = num;
				num = (short)1596616990;
				switch (num3 == num)
				{
				}
				num = (short)285278209;
				if (num != 0)
				{
				}
				num = (short)1628110848;
				if (num != 0)
				{
				}
				this.m = value;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x000AB87C File Offset: 0x000A9A7C
		public virtual int UITotalNum
		{
			get
			{
				short num = (short)1103888384;
				short num2 = num;
				num = (short)881370482;
				short num3 = num;
				num = (short)2097522034;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)736690176;
					if (num != 0)
					{
					}
					if (this.Sets == null)
					{
						return 0;
					}
					break;
				}
				num = (short)203227137;
				if (num != 0)
				{
				}
				return this.Sets.Count;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x000AB93C File Offset: 0x000A9B3C
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x000AB9EC File Offset: 0x000A9BEC
		public bool IsLock
		{
			get
			{
				short num = (short)1009188864;
				short num2 = num;
				num = (short)1458598363;
				short num3 = num;
				num = (short)1104310747;
				switch (num3 == num)
				{
				}
				num = (short)2054815745;
				if (num != 0)
				{
				}
				num = (short)61079552;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1787035648;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)2093875201;
							if (num != 0)
							{
							}
							num = (short)968654414;
							short num3 = num;
							num = (short)934051406;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)1526071296;
								if (num != 0)
								{
								}
								num = (short)352583680;
								short num4 = num;
								switch (0)
								{
								case 0:
									goto IL_D9;
								}
								continue;
							}
							}
							break;
						}
						case 1:
							this.g = value;
							num = (short)1747451907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							return;
						case 3:
							if (!base.IsLoading)
							{
								num = (short)1665859588;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 4:
							base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.get_IsLock())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1358561282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_D9:
						if (value == this.g)
						{
							return;
						}
						num = (short)2080112641;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x000ABB88 File Offset: 0x000A9D88
		// (set) Token: 0x06000B54 RID: 2900 RVA: 0x000ABC3C File Offset: 0x000A9E3C
		public bool IsDisplayAllowed
		{
			get
			{
				short num = (short)1928791623;
				short num2 = num;
				num = (short)1833043527;
				switch (num2 == num)
				{
				}
				num = (short)761266177;
				if (num != 0)
				{
				}
				num = (short)1293811712;
				if (num != 0)
				{
				}
				num = (short)1044250624;
				short num3 = num;
				return this.f;
			}
			set
			{
				short num = (short)2030436353;
				if (num != 0)
				{
				}
				num = (short)28246018;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)149836840;
						short num3 = num;
						num = (short)277238824;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num = (short)1723662336;
							if (num != 0)
							{
							}
							num = (short)1822490624;
							short num4 = num;
							this.f = value;
							num = (short)210173952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_56;
						}
						continue;
					}
					IL_56:
					if (this.f == value)
					{
						break;
					}
					num = (short)84738049;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x000ABD5C File Offset: 0x000A9F5C
		public bool Visible
		{
			get
			{
				if (!this.IsDisplayAllowed)
				{
					short num = (short)1867422152;
					short num2 = num;
					num = (short)1833867720;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					case 1:
						break;
					default:
					{
						num = (short)1863057408;
						short num3 = num;
						break;
					}
					}
					num = (short)621936641;
					if (num != 0)
					{
					}
					num = (short)2124546048;
					if (num != 0)
					{
					}
					return false;
				}
				return true;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x000ABE18 File Offset: 0x000AA018
		public virtual bool IsValid
		{
			get
			{
				short num = (short)2131443926;
				short num2 = num;
				num = (short)1123893462;
				switch (num2 == num)
				{
				}
				num = (short)1751384065;
				if (num != 0)
				{
				}
				num = (short)137101312;
				if (num != 0)
				{
				}
				num = (short)328400896;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x000ABEC0 File Offset: 0x000AA0C0
		// (set) Token: 0x06000B58 RID: 2904 RVA: 0x000ABF70 File Offset: 0x000AA170
		public bool Editable
		{
			get
			{
				short num = (short)237961217;
				if (num != 0)
				{
				}
				num = (short)821768884;
				short num2 = num;
				num = (short)1610756788;
				switch (num2 == num)
				{
				}
				num = (short)569311232;
				if (num != 0)
				{
				}
				num = (short)696909824;
				short num3 = num;
				return this.e;
			}
			set
			{
				short num = (short)808124418;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.get_Editable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1701249027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1192126222;
						short num3 = num;
						num = (short)799172366;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_163;
						default:
							num = (short)307232768;
							if (num != 0)
							{
							}
							if (!base.IsLoading)
							{
								num = (short)977207296;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_163;
						}
						break;
					}
					case 2:
					{
						num = (short)479330304;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					}
					case 3:
						goto IL_D0;
					case 4:
						this.e = value;
						num = (short)28049409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_62:
					if (value == this.e)
					{
						break;
					}
					num = (short)1142489092;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D0:
				IL_163:
				num = (short)1575616513;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x000AC108 File Offset: 0x000AA308
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x000AC1B8 File Offset: 0x000AA3B8
		public bool IsSortSupported
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1634467841;
				if (num != 0)
				{
				}
				num = (short)1841400174;
				short num2 = num;
				num = (short)1305643374;
				switch (num2 == num)
				{
				}
				num = (short)1201602560;
				if (num != 0)
				{
				}
				num = (short)409534464;
				short num3 = num;
				return this.n;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)526707889;
				short num2 = num;
				num = (short)1770843313;
				switch (num2 == num)
				{
				}
				num = (short)1423245313;
				if (num != 0)
				{
				}
				num = (short)1835663360;
				if (num != 0)
				{
				}
				num = (short)1597112320;
				short num3 = num;
				this.n = value;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x000AC26C File Offset: 0x000AA46C
		public virtual bool IsShowingSetName
		{
			get
			{
				short num = (short)1535703987;
				short num2 = num;
				num = (short)918682547;
				switch (num2 == num)
				{
				}
				num = (short)458883072;
				if (num != 0)
				{
				}
				num = (short)1550123009;
				if (num != 0)
				{
				}
				num = (short)1172635648;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x000AC318 File Offset: 0x000AA518
		public virtual bool IsDirty
		{
			get
			{
				short num = (short)1916907205;
				short num2 = num;
				num = (short)1384230597;
				switch (num2 == num)
				{
				}
				num = (short)1984626688;
				if (num != 0)
				{
				}
				num = (short)608174081;
				if (num != 0)
				{
				}
				num = (short)283246592;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x000AC3C0 File Offset: 0x000AA5C0
		public virtual bool IsShareable
		{
			get
			{
				short num = (short)648937473;
				if (num != 0)
				{
				}
				num = (short)21930975;
				short num2 = num;
				num = (short)416130015;
				switch (num2 == num)
				{
				}
				num = (short)1693188096;
				if (num != 0)
				{
				}
				num = (short)1285750784;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x000AC46C File Offset: 0x000AA66C
		public virtual int MaxCapacity
		{
			get
			{
				short num = (short)1616388785;
				short num2 = num;
				num = (short)760816305;
				switch (num2 == num)
				{
				}
				num = (short)1513095169;
				if (num != 0)
				{
				}
				num = (short)1393688576;
				if (num != 0)
				{
				}
				num = (short)1336672256;
				short num3 = num;
				return int.MaxValue;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x000AC51C File Offset: 0x000AA71C
		public int MinCapacity
		{
			get
			{
				short num = (short)1988002374;
				short num2 = num;
				num = (short)1255768646;
				switch (num2 == num)
				{
				}
				num = (short)1408630785;
				if (num != 0)
				{
				}
				num = (short)677511168;
				if (num != 0)
				{
				}
				num = (short)675282944;
				short num3 = num;
				return 0;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x000AC5C4 File Offset: 0x000AA7C4
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x000AC678 File Offset: 0x000AA878
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1498252512;
				short num2 = num;
				num = (short)455771360;
				switch (num2 == num)
				{
				}
				num = (short)472186881;
				if (num != 0)
				{
				}
				num = (short)1069678592;
				if (num != 0)
				{
				}
				num = (short)969670656;
				short num3 = num;
				return this.o;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)879009100;
				short num2 = num;
				num = (short)2024316236;
				switch (num2 == num)
				{
				}
				num = (short)309854208;
				if (num != 0)
				{
				}
				num = (short)360644609;
				if (num != 0)
				{
				}
				num = (short)1321926656;
				short num3 = num;
				this.o = value;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x000AC72C File Offset: 0x000AA92C
		public virtual string UIName
		{
			get
			{
				int a_ = 17;
				if (string.IsNullOrEmpty(this.Name))
				{
					short num = (short)1278865219;
					short num2 = num;
					num = (short)395046723;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BC;
					case 1:
						break;
					default:
					{
						num = (short)247463936;
						short num3 = num;
						break;
					}
					}
					num = (short)460193792;
					if (num != 0)
					{
					}
					num = (short)1500643329;
					if (num != 0)
					{
					}
					return string.Empty;
				}
				IL_BC:
				return global::Motorola.CommonCPS.RadioManagement.CommonBase.PacResourceFactory.Instance().GetStringByResourceID(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Ջ੍ཏőㅓ≕ݗ", a_) + this.Name, null);
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x000AC81C File Offset: 0x000AAA1C
		public virtual bool SetsReadOnly
		{
			get
			{
				short num = (short)222481134;
				short num2 = num;
				num = (short)217369326;
				switch (num2 == num)
				{
				}
				num = (short)1080492032;
				if (num != 0)
				{
				}
				num = (short)2056847361;
				if (num != 0)
				{
				}
				num = (short)1173880832;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x000AC8C4 File Offset: 0x000AAAC4
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x000AC974 File Offset: 0x000AAB74
		public virtual global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> Sets
		{
			get
			{
				short num = (short)1628361867;
				short num2 = num;
				num = (short)1138218123;
				switch (num2 == num)
				{
				}
				num = (short)595329025;
				if (num != 0)
				{
				}
				num = (short)1114898432;
				if (num != 0)
				{
				}
				num = (short)843644928;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)352321542;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)1417959017;
						short num3 = num;
						num = (short)32265833;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						case 1:
							break;
						default:
						{
							num = (short)14942208;
							short num4 = num;
							break;
						}
						}
						num = (short)1435500544;
						if (num != 0)
						{
						}
						this.b.CollectionChanged -= this.a;
						num = (short)1333395460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (this.TelePortMode)
						{
							num = (short)1654784008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.b = value;
						num = (short)1364852737;
						if (num != 0)
						{
						}
						num = (short)1844969481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1A1;
					case 4:
						goto IL_22F;
					case 5:
						if (this.b != null)
						{
							num = (short)1864826881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22F;
					case 6:
						goto IL_14;
					case 7:
						num = (short)995885058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)651100165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_1A1;
					}
					goto IL_4C;
					IL_14:
					switch (0)
					{
					case 0:
						IL_4C:
						if (this.b == value)
						{
							return;
						}
						num = (short)1765736455;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					continue;
					IL_1A1:
					base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.get_Sets())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)1238171648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22F:
					this.b = value;
					this.b.CollectionChanged += this.a;
					num = (short)1860304899;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x000ACBEC File Offset: 0x000AADEC
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)248190934;
			short num2 = num;
			num = (short)722278358;
			switch (num2 == num)
			{
			}
			num = (short)903544832;
			if (num != 0)
			{
			}
			num = (short)1264320513;
			if (num != 0)
			{
			}
			num = (short)397672448;
			short num3 = num;
			base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.get_UITotalNum())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x000ACCC8 File Offset: 0x000AAEC8
		public global::System.Collections.IList Children
		{
			get
			{
				short num = (short)506730058;
				short num2 = num;
				num = (short)1142429258;
				switch (num2 == num)
				{
				}
				num = (short)354353153;
				if (num != 0)
				{
				}
				num = (short)406519808;
				if (num != 0)
				{
				}
				num = (short)89522176;
				short num3 = num;
				return this.Sets;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x000ACD74 File Offset: 0x000AAF74
		public int ChildrenCount
		{
			get
			{
				short num = (short)1797156347;
				short num2 = num;
				num = (short)912682491;
				switch (num2 == num)
				{
				}
				num = (short)440336385;
				if (num != 0)
				{
				}
				num = (short)1387986944;
				if (num != 0)
				{
				}
				num = (short)1151795200;
				short num3 = num;
				return this.Sets.Count;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x000ACE28 File Offset: 0x000AB028
		// (set) Token: 0x06000B6A RID: 2922 RVA: 0x000ACED8 File Offset: 0x000AB0D8
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ITreeNode Parent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)502753672;
				short num2 = num;
				num = (short)622553480;
				switch (num2 == num)
				{
				}
				num = (short)1160577025;
				if (num != 0)
				{
				}
				num = (short)1799225344;
				if (num != 0)
				{
				}
				num = (short)1170538496;
				short num3 = num;
				return this.p;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1126367233;
				if (num != 0)
				{
				}
				num = (short)1436488465;
				short num2 = num;
				num = (short)1072829201;
				switch (num2 == num)
				{
				}
				num = (short)2006384640;
				if (num != 0)
				{
				}
				num = (short)1301086208;
				short num3 = num;
				this.p = value;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x000ACF88 File Offset: 0x000AB188
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Set ParentSet
		{
			get
			{
				global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
				for (;;)
				{
					short num = (short)1421082624;
					short num2 = num;
					switch (0)
					{
					case 0:
						goto IL_52;
					}
					for (;;)
					{
						IL_34:
						int num3;
						switch (num3)
						{
						case 0:
							return set;
						case 1:
							goto IL_BE;
						case 2:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ITreeNode parent = parent.Parent;
							num = (short)831127557;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							if (set == null)
							{
								num = (short)2064187393;
								if (num != 0)
								{
								}
								num = (short)1141047298;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return set;
						case 4:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ITreeNode parent;
							if (parent == null)
							{
								num = (short)1324482560;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							set = (parent as global::Motorola.CommonCPS.RadioManagement.UIModels.Set);
							num = (short)1009254403;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_BE;
						}
						break;
						IL_BE:
						num = (short)1946025988;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_52:
					num = (short)2069023984;
					short num4 = num;
					num = (short)1770900720;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1367736320;
						if (num != 0)
						{
						}
						set = null;
						global::Motorola.CommonCPS.RadioManagement.UIModels.ITreeNode parent = this.Parent;
						num = (short)2039087105;
						int num3 = (int)((global::System.IntPtr)num);
						goto IL_34;
					}
					}
				}
				return set;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x000AD110 File Offset: 0x000AB310
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory ParentSetCategory
		{
			get
			{
				global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
				for (;;)
				{
					short num = (short)1214054400;
					short num2 = num;
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					for (;;)
					{
						IL_33:
						int num3;
						switch (num3)
						{
						case 0:
							return setCategory;
						case 1:
							goto IL_E6;
						case 2:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ITreeNode parent = parent.Parent;
							num = (short)74252293;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							if (setCategory == null)
							{
								num = (short)893976578;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return setCategory;
						case 4:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ITreeNode parent;
							if (parent == null)
							{
								num = (short)337248256;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							setCategory = (parent as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory);
							num = (short)2023489539;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_E6;
						}
						break;
						IL_E6:
						num = (short)998309892;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_51:
					num = (short)902889473;
					if (num != 0)
					{
					}
					num = (short)1860361067;
					short num4 = num;
					num = (short)1457118059;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1531969536;
						if (num != 0)
						{
						}
						setCategory = null;
						global::Motorola.CommonCPS.RadioManagement.UIModels.ITreeNode parent = this.Parent;
						num = (short)1321992193;
						int num3 = (int)((global::System.IntPtr)num);
						goto IL_33;
					}
					}
				}
				return setCategory;
			}
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x000AD294 File Offset: 0x000AB494
		public virtual void RaisePropertyChanged()
		{
			int a_ = 18;
			short num = (short)1308675108;
			short num2 = num;
			num = (short)1990118436;
			switch (num2 == num)
			{
			}
			num = (short)458752000;
			if (num != 0)
			{
			}
			num = (short)1938423809;
			if (num != 0)
			{
			}
			num = (short)1701642240;
			short num3 = num;
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ь㱎ݐ㉒㥔㹖㵘", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᭌ♎≐㩒㝔㭖㱘", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ь㱎ᑐ㹒╔⍖⁘", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ь㱎ᕐ㩒❔⍖⁘", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᡌَՐ㱒⅔㙖㕘ᕚ⡜㉞", a_));
			this.a();
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x000AD3B0 File Offset: 0x000AB5B0
		public virtual void Refresh(bool refreshSets = false)
		{
			short num = (short)2009009531;
			short num2 = num;
			num = (short)1431113083;
			switch (num2 == num)
			{
			}
			num = (short)816906241;
			if (num != 0)
			{
			}
			num = (short)259850240;
			if (num != 0)
			{
			}
			num = (short)1846018048;
			short num3 = num;
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x000AD45C File Offset: 0x000AB65C
		public void Accept(global::Motorola.CommonCPS.RadioManagement.UIModels.UIVisitor v, object context)
		{
			short num = (short)44433408;
			short num2 = num;
			num = (short)1640759297;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> enumerator;
				switch (num3)
				{
				case 0:
					try
					{
						num = (short)1502019585;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_129;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_B6;
								}
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1239023620;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.Set set = enumerator.Current;
								set.Accept(v, context);
								num = (short)300023810;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)1710882816;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_B8:
							num = (short)621740035;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_B6:
							goto IL_B8;
						}
						IL_129:
						return;
					}
					finally
					{
						num = (short)1561774194;
						short num4 = num;
						num = (short)73975922;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_18C:
							switch (0)
							{
							case 0:
								goto IL_1A8;
							}
							break;
						default:
							num = (short)1944977408;
							if (num != 0)
							{
							}
							num = (short)85721089;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
						for (;;)
						{
							IL_196:
							switch (num3)
							{
							case 0:
								goto IL_203;
							case 1:
								goto IL_18C;
							case 2:
								num = (short)809172993;
								if (num != 0)
								{
								}
								enumerator.Dispose();
								num = (short)1532952576;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A8;
						}
						IL_203:
						goto IL_205;
						IL_1A8:
						if (enumerator != null)
						{
							num = (short)860225538;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_196;
						}
						IL_205:;
					}
					goto IL_206;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 2:
					goto IL_206;
				}
				IL_58:
				if (this.Visible)
				{
					num = (short)1996292098;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_206:
				v.VisitSetCategory(this, context);
				enumerator = this.Sets.GetEnumerator();
				num = (short)1244069888;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x000AD6B0 File Offset: 0x000AB8B0
		private void a()
		{
			short num = (short)2012807169;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)389873664;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_9B;
				case 1:
					goto IL_15;
				case 2:
					goto IL_AE;
				case 3:
					if (this.IsTopSet)
					{
						num = (short)1214119938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1857028096;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1958739969;
					if (num != 0)
					{
					}
					num = (short)374079491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)654071536;
					short num4 = num;
					num = (short)1739609840;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						goto IL_FB;
					}
					break;
				}
				}
				goto IL_65;
				IL_15:
				switch (0)
				{
				case 0:
					IL_65:
					if (this.j == null)
					{
						goto IL_AE;
					}
					num = (short)972292100;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_AE:
				num = (short)1301676037;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9B:
			global::System.Collections.Generic.List<string> visibleItems = this.Sets.Where(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.Set s)
			{
				short num5 = (short)11927552;
				short num6 = num5;
				num5 = (short)788135937;
				if (num5 != 0)
				{
				}
				if (s.IsVisible)
				{
					num5 = (short)562587081;
					short num7 = num5;
					num5 = (short)594765257;
					switch ((num7 == num5) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num5 = (short)116588544;
						if (num5 != 0)
						{
						}
						return s.Fields != null;
					}
				}
				return false;
			}).Select(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Set, global::System.Collections.Generic.IEnumerable<string>>(this.a)).SelectMany(delegate(global::System.Collections.Generic.IEnumerable<string> x)
			{
				short num5 = (short)785038856;
				short num6 = num5;
				num5 = (short)2101460488;
				switch (num6 == num5)
				{
				}
				num5 = (short)1487798273;
				if (num5 != 0)
				{
				}
				num5 = (short)969539584;
				if (num5 != 0)
				{
				}
				num5 = (short)1366556672;
				short num7 = num5;
				return x;
			}).Distinct<string>().ToList<string>();
			global::Motorola.CommonCPS.RadioManagement.UIModels.FieldVisibilityChangedEventArgs fieldVisibilityChangedEventArgs = new global::Motorola.CommonCPS.RadioManagement.UIModels.FieldVisibilityChangedEventArgs
			{
				VisibleItems = visibleItems
			};
			this.j(this, fieldVisibilityChangedEventArgs);
			return;
			IL_FB:
			num = (short)1382350848;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x000AD8C0 File Offset: 0x000ABAC0
		public override string ToString()
		{
			short num = (short)1971316045;
			short num2 = num;
			num = (short)546825549;
			switch (num2 == num)
			{
			}
			num = (short)145227776;
			if (num != 0)
			{
			}
			num = (short)174325761;
			if (num != 0)
			{
			}
			num = (short)1499398144;
			short num3 = num;
			return this.Name;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x000AD970 File Offset: 0x000ABB70
		public virtual global::System.Collections.Generic.Dictionary<string, global::Microsoft.Practices.Prism.Commands.DelegateCommand> GetWhiteListContextMenuItems()
		{
			short num = (short)177602561;
			if (num != 0)
			{
			}
			num = (short)1602306951;
			short num2 = num;
			num = (short)65094535;
			switch (num2 == num)
			{
			}
			num = (short)1482424320;
			if (num != 0)
			{
			}
			num = (short)1011154944;
			short num3 = num;
			return new global::System.Collections.Generic.Dictionary<string, global::Microsoft.Practices.Prism.Commands.DelegateCommand>();
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x000ADA20 File Offset: 0x000ABC20
		public virtual global::System.Collections.Generic.Dictionary<string, global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>> GetWhiteListMenuItems()
		{
			short num = (short)1331598227;
			short num2 = num;
			num = (short)342659987;
			switch (num2 == num)
			{
			}
			num = (short)551550977;
			if (num != 0)
			{
			}
			num = (short)731381760;
			if (num != 0)
			{
			}
			num = (short)591527936;
			short num3 = num;
			return new global::System.Collections.Generic.Dictionary<string, global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>>();
		}

		// Token: 0x06000B74 RID: 2932
		public abstract global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.PreloadFieldInfo> GetPreloadFieldNameList();

		// Token: 0x06000B75 RID: 2933
		public abstract bool IsFieldTiedOut(string fieldName, string setCategoryName = null);

		// Token: 0x06000B76 RID: 2934
		public abstract bool IsFieldAllowDisplay(string setCategoryName, string fieldName);

		// Token: 0x06000B77 RID: 2935
		public abstract global::System.Collections.Generic.List<string> GetChildFields(string fieldName, string setType);

		// Token: 0x06000B78 RID: 2936
		public abstract string GetFieldUiLabel(string fieldName, string setType);

		// Token: 0x06000B79 RID: 2937 RVA: 0x000ADACC File Offset: 0x000ABCCC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.IEnumerable<string> a(global::Motorola.CommonCPS.RadioManagement.UIModels.Set A_0)
		{
			short num = (short)1509811498;
			short num2 = num;
			num = (short)1017177386;
			switch (num2 == num)
			{
			}
			num = (short)318046209;
			if (num != 0)
			{
			}
			num = (short)497221632;
			if (num != 0)
			{
			}
			num = (short)1817640960;
			short num3 = num;
			return A_0.Fields.Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase, bool>(this.a)).Select(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase f)
			{
				short num4 = (short)813891585;
				if (num4 != 0)
				{
				}
				num4 = (short)1917906858;
				short num5 = num4;
				num4 = (short)1498017706;
				switch (num5 == num4)
				{
				}
				num4 = (short)942080000;
				if (num4 != 0)
				{
				}
				num4 = (short)2083061760;
				short num6 = num4;
				return f.Name;
			});
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x000ADBB4 File Offset: 0x000ABDB4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase A_0)
		{
			short num = (short)1526595584;
			short num2 = num;
			if (A_0.IsVisible)
			{
				num = (short)1749234255;
				short num3 = num;
				num = (short)1253716559;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)169148416;
					if (num != 0)
					{
					}
					num = (short)1002438657;
					if (num != 0)
					{
					}
					return !this.IsFieldTiedOut(A_0.Name, null);
				}
			}
			return false;
		}

		// Token: 0x04000419 RID: 1049
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> a = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>();

		// Token: 0x0400041A RID: 1050
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> b;

		// Token: 0x0400041B RID: 1051
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Set c;

		// Token: 0x0400041C RID: 1052
		private bool d;

		// Token: 0x0400041D RID: 1053
		private bool e = true;

		// Token: 0x0400041E RID: 1054
		private bool f = true;

		// Token: 0x0400041F RID: 1055
		private bool g;

		// Token: 0x04000420 RID: 1056
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangingEventHandler h;

		// Token: 0x04000421 RID: 1057
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.ActiveSetChangedEventHandler i;

		// Token: 0x04000422 RID: 1058
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory.FieldVisibilityChangedEventHandler j;

		// Token: 0x04000423 RID: 1059
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>> k;

		// Token: 0x04000424 RID: 1060
		public bool PreventInvokeActiveSetChangedEvent;

		// Token: 0x04000425 RID: 1061
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool l;

		// Token: 0x04000426 RID: 1062
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool m = true;

		// Token: 0x04000427 RID: 1063
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool n;

		// Token: 0x04000428 RID: 1064
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string o;

		// Token: 0x04000429 RID: 1065
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ITreeNode p;

		// Token: 0x020000EB RID: 235
		// (Invoke) Token: 0x06000B7C RID: 2940
		public delegate void ActiveSetChangingEventHandler(object sender, global::Motorola.CommonCPS.RadioManagement.UIModels.ActiveSetChangingEventArgs e);

		// Token: 0x020000EC RID: 236
		// (Invoke) Token: 0x06000B80 RID: 2944
		public delegate void ActiveSetChangedEventHandler(object sender, global::Motorola.CommonCPS.RadioManagement.UIModels.ActiveSetChangedEventArgs e);

		// Token: 0x020000ED RID: 237
		// (Invoke) Token: 0x06000B84 RID: 2948
		public delegate void FieldVisibilityChangedEventHandler(object sender, global::Motorola.CommonCPS.RadioManagement.UIModels.FieldVisibilityChangedEventArgs e);
	}
}
