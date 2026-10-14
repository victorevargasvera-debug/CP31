System.InvalidOperationException: Operación no válida dado el estado actual del objeto.
   en Reflector.Disassembler.TranslatorBase.StackAnalyzer.AnalyzeNode(CodeNode parent, CodeNode node, StackInfo stack)
   en Reflector.Disassembler.TranslatorBase.StackAnalyzer.Analyze(CodeNode node)
   en Reflector.Disassembler.TranslatorBase.StackAnalyzer.AnalyzeNode(CodeNode parent, CodeNode node, StackInfo stack)
   en Reflector.Disassembler.TranslatorBase.StackAnalyzer.Analyze(CodeNode node)
   en Reflector.Disassembler.TranslatorBase.StackAnalyzer.AnalyzeNode(CodeNode parent, CodeNode node, StackInfo stack)
   en Reflector.Disassembler.TranslatorBase.StackAnalyzer.Analyze(CodeNode node)
   en Reflector.Disassembler.TranslatorBase.StackAnalyzer.AnalyzeWithUnreferenced(CodeNode entry)
   en Reflector.Disassembler.TranslatorBase.StackAnalyzer.AnalyzeAll()
   en Reflector.Disassembler.TranslatorBase.StackAnalyzer.Analyze(NewTranslator translator)
   en Reflector.Disassembler.NewTranslator.TranslateMethodDeclaration(IMethodDeclaration mD, IMethodBody mB)
   en Reflector.Disassembler.Disassembler.TransformMethodDeclaration(IMethodDeclaration value)
   en Reflector.CodeModel.Visitor.Transformer.TransformMethodDeclarationCollection(IMethodDeclarationCollection methods)
   en Reflector.Disassembler.Disassembler.TransformTypeDeclaration(ITypeDeclaration value)
   en Reflector.Application.Translator.TranslateTypeDeclaration(ITypeDeclaration value, Boolean memberDeclarationList, Boolean methodDeclarationBody)
   en Reflector.Application.ExportSource.CodeFile.WriteToOutput(ILanguageWriterConfiguration configuration, ILanguage language, ITranslator disassembler)
namespace SpecialFeatures.Flashport.FlashRadio.ApxNext
{
}

