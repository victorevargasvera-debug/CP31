using System;
using NPOI.SS.Formula.PTG;

namespace NPOI.SS.Formula
{
	// Token: 0x020000D5 RID: 213
	internal class OperandClassTransformer
	{
		// Token: 0x06000718 RID: 1816 RVA: 0x0001235B File Offset: 0x0001055B
		public OperandClassTransformer(global::NPOI.SS.Formula.FormulaType formulaType)
		{
			this._formulaType = formulaType;
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0001236C File Offset: 0x0001056C
		public void TransformFormula(global::NPOI.SS.Formula.ParseNode rootNode)
		{
			byte desiredOperandClass;
			switch (this._formulaType)
			{
			case global::NPOI.SS.Formula.FormulaType.Cell:
				desiredOperandClass = 32;
				goto IL_5B;
			case global::NPOI.SS.Formula.FormulaType.Array:
				desiredOperandClass = 64;
				goto IL_5B;
			case global::NPOI.SS.Formula.FormulaType.NamedRange:
			case global::NPOI.SS.Formula.FormulaType.DataValidationList:
				desiredOperandClass = 0;
				goto IL_5B;
			}
			throw new global::System.Exception("Incomplete code - formula type (" + this._formulaType.ToString() + ") not supported yet");
			IL_5B:
			this.TransformNode(rootNode, desiredOperandClass, false);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x000123E0 File Offset: 0x000105E0
		private void TransformNode(global::NPOI.SS.Formula.ParseNode node, byte desiredOperandClass, bool callerForceArrayFlag)
		{
			global::NPOI.SS.Formula.PTG.Ptg ptg = node.GetToken();
			global::NPOI.SS.Formula.ParseNode[] children = node.GetChildren();
			if (global::NPOI.SS.Formula.OperandClassTransformer.IsSimpleValueFunction(ptg))
			{
				bool callerForceArrayFlag2 = desiredOperandClass == 64;
				for (int i = 0; i < children.Length; i++)
				{
					this.TransformNode(children[i], desiredOperandClass, callerForceArrayFlag2);
				}
				this.SetSimpleValueFuncClass((global::NPOI.SS.Formula.PTG.AbstractFunctionPtg)ptg, desiredOperandClass, callerForceArrayFlag);
				return;
			}
			if (global::NPOI.SS.Formula.OperandClassTransformer.IsSingleArgSum(ptg))
			{
				ptg = global::NPOI.SS.Formula.PTG.FuncVarPtg.SUM;
			}
			if (ptg is global::NPOI.SS.Formula.PTG.ValueOperatorPtg || ptg is global::NPOI.SS.Formula.PTG.ControlPtg || ptg is global::NPOI.SS.Formula.PTG.MemFuncPtg || ptg is global::NPOI.SS.Formula.PTG.MemAreaPtg || ptg is global::NPOI.SS.Formula.PTG.UnionPtg || ptg is global::NPOI.SS.Formula.PTG.IntersectionPtg)
			{
				byte desiredOperandClass2 = (desiredOperandClass == 0) ? 32 : desiredOperandClass;
				for (int j = 0; j < children.Length; j++)
				{
					this.TransformNode(children[j], desiredOperandClass2, callerForceArrayFlag);
				}
				return;
			}
			if (ptg is global::NPOI.SS.Formula.PTG.AbstractFunctionPtg)
			{
				this.TransformFunctionNode((global::NPOI.SS.Formula.PTG.AbstractFunctionPtg)ptg, children, desiredOperandClass, callerForceArrayFlag);
				return;
			}
			if (children.Length != 0)
			{
				if (ptg is global::NPOI.SS.Formula.PTG.OperationPtg)
				{
					return;
				}
				throw new global::System.InvalidOperationException("Node should not have any children");
			}
			else
			{
				if (ptg.IsBaseToken)
				{
					return;
				}
				ptg.PtgClass = this.TransformClass(ptg.PtgClass, desiredOperandClass, callerForceArrayFlag);
				return;
			}
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x000124E6 File Offset: 0x000106E6
		private static bool IsSingleArgSum(global::NPOI.SS.Formula.PTG.Ptg token)
		{
			return token is global::NPOI.SS.Formula.PTG.AttrPtg && ((global::NPOI.SS.Formula.PTG.AttrPtg)token).IsSum;
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00012500 File Offset: 0x00010700
		private static bool IsSimpleValueFunction(global::NPOI.SS.Formula.PTG.Ptg token)
		{
			if (!(token is global::NPOI.SS.Formula.PTG.AbstractFunctionPtg))
			{
				return false;
			}
			global::NPOI.SS.Formula.PTG.AbstractFunctionPtg abstractFunctionPtg = (global::NPOI.SS.Formula.PTG.AbstractFunctionPtg)token;
			if (abstractFunctionPtg.DefaultOperandClass != 32)
			{
				return false;
			}
			for (int i = abstractFunctionPtg.NumberOfOperands - 1; i >= 0; i--)
			{
				if (abstractFunctionPtg.GetParameterClass(i) != 32)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0001254B File Offset: 0x0001074B
		private byte TransformClass(byte currentOperandClass, byte desiredOperandClass, bool callerForceArrayFlag)
		{
			if (desiredOperandClass != 0)
			{
				if (desiredOperandClass != 32)
				{
					if (desiredOperandClass != 64)
					{
						throw new global::System.InvalidOperationException("Unexpected operand class (" + desiredOperandClass.ToString() + ")");
					}
					return 64;
				}
				else
				{
					if (!callerForceArrayFlag)
					{
						return 32;
					}
					return 64;
				}
			}
			else
			{
				if (!callerForceArrayFlag)
				{
					return currentOperandClass;
				}
				return 0;
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0001258C File Offset: 0x0001078C
		private void TransformFunctionNode(global::NPOI.SS.Formula.PTG.AbstractFunctionPtg afp, global::NPOI.SS.Formula.ParseNode[] children, byte desiredOperandClass, bool callerForceArrayFlag)
		{
			byte defaultOperandClass = afp.DefaultOperandClass;
			bool callerForceArrayFlag2;
			if (callerForceArrayFlag)
			{
				if (defaultOperandClass != 0)
				{
					if (defaultOperandClass != 32)
					{
						if (defaultOperandClass != 64)
						{
							throw new global::System.InvalidOperationException("Unexpected operand class (" + defaultOperandClass.ToString() + ")");
						}
						afp.PtgClass = 64;
						callerForceArrayFlag2 = false;
					}
					else
					{
						afp.PtgClass = 64;
						callerForceArrayFlag2 = true;
					}
				}
				else
				{
					if (desiredOperandClass == 0)
					{
						afp.PtgClass = 0;
					}
					else
					{
						afp.PtgClass = 64;
					}
					callerForceArrayFlag2 = false;
				}
			}
			else if (defaultOperandClass == desiredOperandClass)
			{
				callerForceArrayFlag2 = false;
				afp.PtgClass = defaultOperandClass;
			}
			else if (desiredOperandClass != 0)
			{
				if (desiredOperandClass != 32)
				{
					if (desiredOperandClass != 64)
					{
						throw new global::System.InvalidOperationException("Unexpected operand class (" + desiredOperandClass.ToString() + ")");
					}
					if (defaultOperandClass != 0)
					{
						if (defaultOperandClass != 32)
						{
							throw new global::System.InvalidOperationException("Unexpected operand class (" + defaultOperandClass.ToString() + ")");
						}
						afp.PtgClass = 64;
					}
					else
					{
						afp.PtgClass = 0;
					}
					callerForceArrayFlag2 = (defaultOperandClass == 32);
				}
				else
				{
					afp.PtgClass = 32;
					callerForceArrayFlag2 = false;
				}
			}
			else
			{
				if (defaultOperandClass != 32)
				{
					if (defaultOperandClass != 64)
					{
						throw new global::System.InvalidOperationException("Unexpected operand class (" + defaultOperandClass.ToString() + ")");
					}
					afp.PtgClass = 64;
				}
				else
				{
					afp.PtgClass = 32;
				}
				callerForceArrayFlag2 = false;
			}
			for (int i = 0; i < children.Length; i++)
			{
				global::NPOI.SS.Formula.ParseNode node = children[i];
				byte parameterClass = afp.GetParameterClass(i);
				this.TransformNode(node, parameterClass, callerForceArrayFlag2);
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x000126FB File Offset: 0x000108FB
		private void SetSimpleValueFuncClass(global::NPOI.SS.Formula.PTG.AbstractFunctionPtg afp, byte desiredOperandClass, bool callerForceArrayFlag)
		{
			if (callerForceArrayFlag || desiredOperandClass == 64)
			{
				afp.PtgClass = 64;
				return;
			}
			afp.PtgClass = 32;
		}

		// Token: 0x040003D2 RID: 978
		private global::NPOI.SS.Formula.FormulaType _formulaType;
	}
}
