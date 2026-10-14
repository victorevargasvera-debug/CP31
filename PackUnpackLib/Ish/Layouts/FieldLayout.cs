using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x02000050 RID: 80
	public abstract class FieldLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.Layout, global::Motorola.Acp.PackUnpack.Ish.Layouts.IFieldLayout, global::Motorola.Acp.PackUnpack.Ish.Layouts.IChildLayout<global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaLayout>, global::Motorola.Acp.PackUnpack.Ish.Layouts.ILayout
	{
		// Token: 0x060002FF RID: 767 RVA: 0x00041A9C File Offset: 0x0003FC9C
		protected FieldLayout(string name, global::System.TypeCode typeCode, int offset, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification justification)
		{
			int a_ = 8;
			base..ctor(name);
			if (!global::System.Enum.IsDefined(typeof(global::System.TypeCode), typeCode))
			{
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\ud8a0펢삤욨쾪좬", a_));
			}
			if (!global::System.Enum.IsDefined(typeof(global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification), justification))
			{
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("풠킢톤캦쾨슪캬캮얰\udab2\udab4\ud9b6", a_));
			}
			if (offset >= 0)
			{
				if (offset <= 2047)
				{
					this.b = -1;
					this.c = typeCode;
					this.d = offset;
					this.e = justification;
					this.a = null;
					return;
				}
			}
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("잠얢횤슦\udda8", a_));
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000300 RID: 768 RVA: 0x00041B5C File Offset: 0x0003FD5C
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00041C0C File Offset: 0x0003FE0C
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaLayout Parent
		{
			get
			{
				short num = (short)1822444083;
				short num2 = num;
				num = (short)1161972275;
				switch (num2 == num)
				{
				}
				num = (short)514916353;
				if (num != 0)
				{
				}
				num = (short)1879375872;
				if (num != 0)
				{
				}
				num = (short)159842304;
				short num3 = num;
				return this.a;
			}
			internal set
			{
				short num = (short)584689109;
				short num2 = num;
				num = (short)520988117;
				switch (num2 == num)
				{
				}
				num = (short)1829437441;
				if (num != 0)
				{
				}
				num = (short)857669632;
				if (num != 0)
				{
				}
				num = (short)1037107200;
				short num3 = num;
				this.a = value;
				this.b = this.GetId();
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00041CC8 File Offset: 0x0003FEC8
		public global::System.TypeCode Type
		{
			get
			{
				short num = (short)748017228;
				short num2 = num;
				num = (short)34002508;
				switch (num2 == num)
				{
				}
				num = (short)12582912;
				if (num != 0)
				{
				}
				num = (short)1897857025;
				if (num != 0)
				{
				}
				num = (short)1538719744;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00041D78 File Offset: 0x0003FF78
		public int Offset
		{
			get
			{
				short num = (short)246576613;
				short num2 = num;
				num = (short)952006117;
				switch (num2 == num)
				{
				}
				num = (short)1342701568;
				if (num != 0)
				{
				}
				num = (short)364904449;
				if (num != 0)
				{
				}
				num = (short)983498752;
				short num3 = num;
				return this.d;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000304 RID: 772
		public abstract int Size { get; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000305 RID: 773 RVA: 0x00041E2C File Offset: 0x0004002C
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification Justification
		{
			get
			{
				short num = (short)2123785588;
				short num2 = num;
				num = (short)1424319860;
				switch (num2 == num)
				{
				}
				num = (short)1508179969;
				if (num != 0)
				{
				}
				num = (short)1437532160;
				if (num != 0)
				{
				}
				num = (short)500039680;
				short num3 = num;
				return this.e;
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00041EE0 File Offset: 0x000400E0
		protected virtual int GetId()
		{
			short num = (short)1370906429;
			short num2 = num;
			num = (short)757423933;
			switch (num2 == num)
			{
			}
			num = (short)1081409536;
			if (num != 0)
			{
			}
			num = (short)738787329;
			if (num != 0)
			{
			}
			num = (short)1453850624;
			short num3 = num;
			global::Motorola.Acp.PackUnpack.Ish.IshType ishType = this.a.Parent.IshTypes[0];
			int num4 = 7;
			return (ishType.Value & 65535) | (int)((int)this.a.AreaType << 16 & (global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType)536608768) | (this.d << 18 & 536608768) | num4 << 29;
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00041FD8 File Offset: 0x000401D8
		internal int Id
		{
			get
			{
				short num = (short)846025368;
				short num2 = num;
				num = (short)2089243288;
				switch (num2 == num)
				{
				}
				num = (short)1803419649;
				if (num != 0)
				{
				}
				num = (short)753991680;
				if (num != 0)
				{
				}
				num = (short)19857408;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x04000102 RID: 258
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaLayout a;

		// Token: 0x04000103 RID: 259
		private int b;

		// Token: 0x04000104 RID: 260
		private global::System.TypeCode c;

		// Token: 0x04000105 RID: 261
		private int d;

		// Token: 0x04000106 RID: 262
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification e;

		// Token: 0x04000107 RID: 263
		public const int MaxByteOffset = 2047;
	}
}
