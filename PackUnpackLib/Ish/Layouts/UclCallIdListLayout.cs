using System;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x0200006D RID: 109
	public class UclCallIdListLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout, global::Motorola.Acp.PackUnpack.Ish.Layouts.IUclListLayout
	{
		// Token: 0x06000356 RID: 854 RVA: 0x00044C20 File Offset: 0x00042E20
		public UclCallIdListLayout(string name, global::Motorola.Acp.PackUnpack.Ish.UclCallIdListHeaderType headerType, global::Motorola.Acp.PackUnpack.Ish.UclCallIdListListletType listletType, bool hasReferencedTypes, int listCapacity, int headerCapacity, int listletCapacity, int headerDataAreaSize, int listEntrySize) : base(name, headerType, listletType, listCapacity, headerCapacity, listletCapacity, headerDataAreaSize, listEntrySize)
		{
			this.a = hasReferencedTypes;
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00044C48 File Offset: 0x00042E48
		public new global::Motorola.Acp.PackUnpack.Ish.UclCallIdListHeaderType HeaderType
		{
			get
			{
				short num = (short)173146113;
				if (num != 0)
				{
				}
				num = (short)1811067122;
				short num2 = num;
				num = (short)1880535282;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1818361856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1948057600;
				if (num != 0)
				{
				}
				return (global::Motorola.Acp.PackUnpack.Ish.UclCallIdListHeaderType)base.HeaderType;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00044CFC File Offset: 0x00042EFC
		internal new global::Motorola.Acp.PackUnpack.Ish.UclCallIdListListletType ListletType
		{
			get
			{
				short num = (short)1093796140;
				short num2 = num;
				num = (short)147390764;
				switch (num2 == num)
				{
				}
				num = (short)147062784;
				short num3 = num;
				num = (short)1782317057;
				if (num != 0)
				{
				}
				num = (short)1724383232;
				if (num != 0)
				{
				}
				return (global::Motorola.Acp.PackUnpack.Ish.UclCallIdListListletType)base.ListletType;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000359 RID: 857 RVA: 0x00044DB4 File Offset: 0x00042FB4
		public bool HasReferencedTypes
		{
			get
			{
				short num = (short)413763479;
				short num2 = num;
				num = (short)1197180823;
				switch (num2 == num)
				{
				}
				num = (short)873136128;
				short num3 = num;
				num = (short)913113088;
				if (num != 0)
				{
				}
				num = (short)1054212097;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x04000151 RID: 337
		private bool a;
	}
}
