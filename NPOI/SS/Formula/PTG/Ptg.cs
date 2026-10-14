using System;
using System.Collections;
using System.Collections.Generic;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x0200011F RID: 287
	[global::System.Serializable]
	public abstract class Ptg : global::System.ICloneable
	{
		// Token: 0x06000969 RID: 2409 RVA: 0x00018B0C File Offset: 0x00016D0C
		public static global::NPOI.SS.Formula.PTG.Ptg[] ReadTokens(int size, global::NPOI.Util.ILittleEndianInput in1)
		{
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList(4 + size / 2);
			int i = 0;
			bool flag = false;
			while (i < size)
			{
				global::NPOI.SS.Formula.PTG.Ptg ptg = global::NPOI.SS.Formula.PTG.Ptg.CreatePtg(in1);
				if (ptg is global::NPOI.SS.Formula.PTG.ArrayPtg.Initial)
				{
					flag = true;
				}
				i += ptg.Size;
				arrayList.Add(ptg);
			}
			if (i != size)
			{
				throw new global::System.Exception("Ptg array size mismatch");
			}
			if (flag)
			{
				global::NPOI.SS.Formula.PTG.Ptg[] array = global::NPOI.SS.Formula.PTG.Ptg.ToPtgArray(arrayList);
				for (int j = 0; j < array.Length; j++)
				{
					if (array[j] is global::NPOI.SS.Formula.PTG.ArrayPtg.Initial)
					{
						array[j] = ((global::NPOI.SS.Formula.PTG.ArrayPtg.Initial)array[j]).FinishReading(in1);
					}
				}
				return array;
			}
			return global::NPOI.SS.Formula.PTG.Ptg.ToPtgArray(arrayList);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00018BA8 File Offset: 0x00016DA8
		public static global::NPOI.SS.Formula.PTG.Ptg CreatePtg(global::NPOI.Util.ILittleEndianInput in1)
		{
			byte b = (byte)in1.ReadByte();
			if (b < 32)
			{
				return global::NPOI.SS.Formula.PTG.Ptg.CreateBasePtg(b, in1);
			}
			global::NPOI.SS.Formula.PTG.Ptg ptg = global::NPOI.SS.Formula.PTG.Ptg.CreateClassifiedPtg(b, in1);
			if (b >= 96)
			{
				ptg.PtgClass = 64;
			}
			else if (b >= 64)
			{
				ptg.PtgClass = 32;
			}
			else
			{
				ptg.PtgClass = 0;
			}
			return ptg;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00018BF8 File Offset: 0x00016DF8
		private static global::NPOI.SS.Formula.PTG.Ptg CreateClassifiedPtg(byte id, global::NPOI.Util.ILittleEndianInput in1)
		{
			switch ((id & 31) | 32)
			{
			case 32:
				return new global::NPOI.SS.Formula.PTG.ArrayPtg.Initial(in1);
			case 33:
				return global::NPOI.SS.Formula.PTG.FuncPtg.Create(in1);
			case 34:
				return global::NPOI.SS.Formula.PTG.FuncVarPtg.Create(in1);
			case 35:
				return new global::NPOI.SS.Formula.PTG.NamePtg(in1);
			case 36:
				return new global::NPOI.SS.Formula.PTG.RefPtg(in1);
			case 37:
				return new global::NPOI.SS.Formula.PTG.AreaPtg(in1);
			case 38:
				return new global::NPOI.SS.Formula.PTG.MemAreaPtg(in1);
			case 39:
				return new global::NPOI.SS.Formula.PTG.MemErrPtg(in1);
			case 41:
				return new global::NPOI.SS.Formula.PTG.MemFuncPtg(in1);
			case 42:
				return new global::NPOI.SS.Formula.PTG.RefErrorPtg(in1);
			case 43:
				return new global::NPOI.SS.Formula.PTG.AreaErrPtg(in1);
			case 44:
				return new global::NPOI.SS.Formula.PTG.RefNPtg(in1);
			case 45:
				return new global::NPOI.SS.Formula.PTG.AreaNPtg(in1);
			case 57:
				return new global::NPOI.SS.Formula.PTG.NameXPtg(in1);
			case 58:
				return new global::NPOI.SS.Formula.PTG.Ref3DPtg(in1);
			case 59:
				return new global::NPOI.SS.Formula.PTG.Area3DPtg(in1);
			case 60:
				return new global::NPOI.SS.Formula.PTG.DeletedRef3DPtg(in1);
			case 61:
				return new global::NPOI.SS.Formula.PTG.DeletedArea3DPtg(in1);
			}
			string[] array = new string[5];
			array[0] = " Unknown Ptg in Formula: 0x";
			array[1] = global::NPOI.Util.StringUtil.ToHexString((short)id);
			array[2] = " (";
			int num = 3;
			int num2 = (int)id;
			array[num] = num2.ToString();
			array[4] = ")";
			throw new global::System.NotSupportedException(string.Concat(array));
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00018D4C File Offset: 0x00016F4C
		private static global::NPOI.SS.Formula.PTG.Ptg CreateBasePtg(byte id, global::NPOI.Util.ILittleEndianInput in1)
		{
			switch (id)
			{
			case 0:
				return new global::NPOI.SS.Formula.PTG.UnknownPtg();
			case 1:
				return new global::NPOI.SS.Formula.PTG.ExpPtg(in1);
			case 2:
				return new global::NPOI.SS.Formula.PTG.TblPtg(in1);
			case 3:
				return global::NPOI.SS.Formula.PTG.AddPtg.instance;
			case 4:
				return global::NPOI.SS.Formula.PTG.SubtractPtg.instance;
			case 5:
				return global::NPOI.SS.Formula.PTG.MultiplyPtg.instance;
			case 6:
				return global::NPOI.SS.Formula.PTG.DividePtg.instance;
			case 7:
				return global::NPOI.SS.Formula.PTG.PowerPtg.instance;
			case 8:
				return global::NPOI.SS.Formula.PTG.ConcatPtg.instance;
			case 9:
				return global::NPOI.SS.Formula.PTG.LessThanPtg.instance;
			case 10:
				return global::NPOI.SS.Formula.PTG.LessEqualPtg.instance;
			case 11:
				return global::NPOI.SS.Formula.PTG.EqualPtg.instance;
			case 12:
				return global::NPOI.SS.Formula.PTG.GreaterEqualPtg.instance;
			case 13:
				return global::NPOI.SS.Formula.PTG.GreaterThanPtg.instance;
			case 14:
				return global::NPOI.SS.Formula.PTG.NotEqualPtg.instance;
			case 15:
				return global::NPOI.SS.Formula.PTG.IntersectionPtg.instance;
			case 16:
				return global::NPOI.SS.Formula.PTG.UnionPtg.instance;
			case 17:
				return global::NPOI.SS.Formula.PTG.RangePtg.instance;
			case 18:
				return global::NPOI.SS.Formula.PTG.UnaryPlusPtg.instance;
			case 19:
				return global::NPOI.SS.Formula.PTG.UnaryMinusPtg.instance;
			case 20:
				return global::NPOI.SS.Formula.PTG.PercentPtg.instance;
			case 21:
				return global::NPOI.SS.Formula.PTG.ParenthesisPtg.instance;
			case 22:
				return global::NPOI.SS.Formula.PTG.MissingArgPtg.instance;
			case 23:
				return new global::NPOI.SS.Formula.PTG.StringPtg(in1);
			case 25:
				return new global::NPOI.SS.Formula.PTG.AttrPtg(in1);
			case 28:
				return new global::NPOI.SS.Formula.PTG.ErrPtg(in1);
			case 29:
				return new global::NPOI.SS.Formula.PTG.BoolPtg(in1);
			case 30:
				return new global::NPOI.SS.Formula.PTG.IntPtg(in1);
			case 31:
				return new global::NPOI.SS.Formula.PTG.NumberPtg(in1);
			}
			throw new global::System.Exception("Unexpected base token id (" + id.ToString() + ")");
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00018EB5 File Offset: 0x000170B5
		private static global::NPOI.SS.Formula.PTG.Ptg[] ToPtgArray(global::System.Collections.ArrayList l)
		{
			if (l.Count == 0)
			{
				return global::NPOI.SS.Formula.PTG.Ptg.EMPTY_PTG_ARRAY;
			}
			return (global::NPOI.SS.Formula.PTG.Ptg[])l.ToArray(typeof(global::NPOI.SS.Formula.PTG.Ptg));
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00018EDA File Offset: 0x000170DA
		public virtual object Clone()
		{
			return this.Copy<global::NPOI.SS.Formula.PTG.Ptg>();
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00018EE4 File Offset: 0x000170E4
		public static int GetEncodedSize(global::NPOI.SS.Formula.PTG.Ptg[] ptgs)
		{
			int num = 0;
			foreach (global::NPOI.SS.Formula.PTG.Ptg ptg in ptgs)
			{
				num += ptg.Size;
			}
			return num;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00018F14 File Offset: 0x00017114
		public static int GetEncodedSizeWithoutArrayData(global::NPOI.SS.Formula.PTG.Ptg[] ptgs)
		{
			int num = 0;
			foreach (global::NPOI.SS.Formula.PTG.Ptg ptg in ptgs)
			{
				if (ptg is global::NPOI.SS.Formula.PTG.ArrayPtg)
				{
					num += 8;
				}
				else
				{
					num += ptg.Size;
				}
			}
			return num;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00018F50 File Offset: 0x00017150
		public static int SerializePtgs(global::NPOI.SS.Formula.PTG.Ptg[] ptgs, byte[] array, int offset)
		{
			global::NPOI.Util.LittleEndianByteArrayOutputStream littleEndianByteArrayOutputStream = new global::NPOI.Util.LittleEndianByteArrayOutputStream(array, offset);
			global::System.Collections.Generic.List<global::NPOI.SS.Formula.PTG.Ptg> list = null;
			foreach (global::NPOI.SS.Formula.PTG.Ptg ptg in ptgs)
			{
				ptg.Write(littleEndianByteArrayOutputStream);
				if (ptg is global::NPOI.SS.Formula.PTG.ArrayPtg)
				{
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<global::NPOI.SS.Formula.PTG.Ptg>(5);
					}
					list.Add(ptg);
				}
			}
			if (list != null)
			{
				foreach (global::NPOI.SS.Formula.PTG.Ptg ptg2 in list)
				{
					((global::NPOI.SS.Formula.PTG.ArrayPtg)ptg2).WriteTokenValueBytes(littleEndianByteArrayOutputStream);
				}
			}
			return littleEndianByteArrayOutputStream.WriteIndex - offset;
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000972 RID: 2418
		public abstract int Size { get; }

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000973 RID: 2419
		public abstract bool IsBaseToken { get; }

		// Token: 0x06000974 RID: 2420
		public abstract void Write(global::NPOI.Util.ILittleEndianOutput out1);

		// Token: 0x06000975 RID: 2421
		public abstract string ToFormulaString();

		// Token: 0x06000976 RID: 2422 RVA: 0x00018FF0 File Offset: 0x000171F0
		public override string ToString()
		{
			return base.GetType().ToString();
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x00018FFD File Offset: 0x000171FD
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x00019005 File Offset: 0x00017205
		public byte PtgClass
		{
			get
			{
				return this.ptgClass;
			}
			set
			{
				if (this.IsBaseToken)
				{
					throw new global::System.Exception("SetClass should not be called on a base token");
				}
				this.ptgClass = value;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000979 RID: 2425
		public abstract byte DefaultOperandClass { get; }

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x00019024 File Offset: 0x00017224
		public char RVAType
		{
			get
			{
				if (this.IsBaseToken)
				{
					return '.';
				}
				byte b = this.ptgClass;
				if (b == 0)
				{
					return 'R';
				}
				if (b == 32)
				{
					return 'V';
				}
				if (b != 64)
				{
					throw new global::System.InvalidOperationException("Unknown operand class (" + this.ptgClass.ToString() + ")");
				}
				return 'A';
			}
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00008C75 File Offset: 0x00006E75
		object global::System.ICloneable.Clone()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0001907C File Offset: 0x0001727C
		public static bool DoesFormulaReferToDeletedCell(global::NPOI.SS.Formula.PTG.Ptg[] ptgs)
		{
			for (int i = 0; i < ptgs.Length; i++)
			{
				if (global::NPOI.SS.Formula.PTG.Ptg.IsDeletedCellRef(ptgs[i]))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x000190A6 File Offset: 0x000172A6
		private static bool IsDeletedCellRef(global::NPOI.SS.Formula.PTG.Ptg ptg)
		{
			return ptg == global::NPOI.SS.Formula.PTG.ErrPtg.REF_INVALID || ptg is global::NPOI.SS.Formula.PTG.DeletedArea3DPtg || ptg is global::NPOI.SS.Formula.PTG.DeletedRef3DPtg || ptg is global::NPOI.SS.Formula.PTG.AreaErrPtg || ptg is global::NPOI.SS.Formula.PTG.RefErrorPtg;
		}

		// Token: 0x040004D4 RID: 1236
		public static global::NPOI.SS.Formula.PTG.Ptg[] EMPTY_PTG_ARRAY = new global::NPOI.SS.Formula.PTG.Ptg[0];

		// Token: 0x040004D5 RID: 1237
		public const byte CLASS_REF = 0;

		// Token: 0x040004D6 RID: 1238
		public const byte CLASS_VALUE = 32;

		// Token: 0x040004D7 RID: 1239
		public const byte CLASS_ARRAY = 64;

		// Token: 0x040004D8 RID: 1240
		private byte ptgClass;
	}
}
