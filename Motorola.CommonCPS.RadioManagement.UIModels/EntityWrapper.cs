using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000005 RID: 5
	public abstract class EntityWrapper<T> : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::Motorola.CommonCPS.RadioManagement.UIModels.ICopyable where T : global::System.ICloneable
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00004170 File Offset: 0x00002370
		public EntityWrapper(T entity)
		{
			this.Entity = entity;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0000418C File Offset: 0x0000238C
		// (set) Token: 0x06000027 RID: 39 RVA: 0x0000423C File Offset: 0x0000243C
		protected T Entity
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1770651648;
				short num2 = num;
				num = (short)1394222468;
				short num3 = num;
				num = (short)668149124;
				switch (num3 == num)
				{
				}
				num = (short)2039218177;
				if (num != 0)
				{
				}
				num = (short)1891565568;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1778778112;
				short num2 = num;
				num = (short)1112865815;
				short num3 = num;
				num = (short)536411159;
				switch (num3 == num)
				{
				}
				num = (short)2114322433;
				if (num != 0)
				{
				}
				num = (short)719323136;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000042EC File Offset: 0x000024EC
		public virtual T ToEntity()
		{
			short num = (short)709754880;
			short num2 = num;
			num = (short)315937062;
			short num3 = num;
			num = (short)760467750;
			switch (num3 == num)
			{
			}
			num = (short)1113522177;
			if (num != 0)
			{
			}
			num = (short)1489960960;
			if (num != 0)
			{
			}
			T entity = this.Entity;
			return (T)((object)entity.Clone());
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000043AC File Offset: 0x000025AC
		public override object Clone()
		{
			short num = (short)689569792;
			short num2 = num;
			num = (short)262078465;
			if (num != 0)
			{
			}
			num = (short)508193183;
			short num3 = num;
			num = (short)1974299039;
			switch (num3 == num)
			{
			}
			num = (short)1449656320;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<T> entityWrapper = (global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<T>)base.MemberwiseClone();
			global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<T> entityWrapper2 = entityWrapper;
			T entity = this.Entity;
			entityWrapper2.Entity = (T)((object)entity.Clone());
			entityWrapper.CleanEventHandler();
			return entityWrapper;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004488 File Offset: 0x00002688
		public virtual void CopyFrom(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase source)
		{
			int a_ = 10;
			short num = (short)1311309824;
			short num2 = num;
			num = (short)1556938752;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IList<string> list = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CheckObjectPublicPropertiesDifferent(source, this, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፄ♆╈≊⥌⹎═㱒❔", a_));
				global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<T> entityWrapper = (global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<T>)source;
				T entity = entityWrapper.Entity;
				this.Entity = (T)((object)entity.Clone());
				global::Motorola.CommonCPS.RadioManagement.UIModels.IUIModelValidate validator = base.Validator;
				base.Validator = null;
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CopyObjectPublicProperties(source, this, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፄ♆╈≊⥌⹎═㱒❔", a_));
				base.Validator = validator;
				global::System.Collections.Generic.IEnumerator<string> enumerator = list.GetEnumerator();
				try
				{
					num = (short)1184759808;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_FC;
							}
							continue;
						case 1:
							goto IL_177;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)606797827;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							string propertyName = enumerator.Current;
							this.RaisePropertyChanged(propertyName);
							num = (short)1122500612;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							num = (short)1232863233;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_126:
						num = (short)1640693762;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_FC:
						goto IL_126;
					}
					IL_177:;
				}
				finally
				{
					num = (short)951123970;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_25D;
						case 1:
							enumerator.Dispose();
							num = (short)2027290624;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_1AE;
							}
							continue;
						}
						IL_1AE:
						num = (short)1779764113;
						short num4 = num;
						num = (short)710478737;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_25D;
						default:
							num = (short)1171456000;
							if (num != 0)
							{
							}
							num = (short)239206401;
							if (num != 0)
							{
							}
							if (enumerator == null)
							{
								goto IL_25F;
							}
							num = (short)915275777;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_25D:
					IL_25F:;
				}
				return;
			}
			}
		}

		// Token: 0x04000005 RID: 5
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private T a;
	}
}
