//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.11.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from CircuitLang.g4 by ANTLR 4.11.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="CircuitLangParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.CLSCompliant(false)]
public interface ICircuitLangListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CircuitLangParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] CircuitLangParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CircuitLangParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] CircuitLangParser.ProgramContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CircuitLangParser.module"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModule([NotNull] CircuitLangParser.ModuleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CircuitLangParser.module"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModule([NotNull] CircuitLangParser.ModuleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CircuitLangParser.module_argument_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModule_argument_list([NotNull] CircuitLangParser.Module_argument_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CircuitLangParser.module_argument_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModule_argument_list([NotNull] CircuitLangParser.Module_argument_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CircuitLangParser.module_output_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModule_output_list([NotNull] CircuitLangParser.Module_output_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CircuitLangParser.module_output_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModule_output_list([NotNull] CircuitLangParser.Module_output_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CircuitLangParser.identifier_with_array"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier_with_array([NotNull] CircuitLangParser.Identifier_with_arrayContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CircuitLangParser.identifier_with_array"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier_with_array([NotNull] CircuitLangParser.Identifier_with_arrayContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CircuitLangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] CircuitLangParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CircuitLangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] CircuitLangParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CircuitLangParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] CircuitLangParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CircuitLangParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] CircuitLangParser.AssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CircuitLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] CircuitLangParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CircuitLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] CircuitLangParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CircuitLangParser.unary_operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnary_operation([NotNull] CircuitLangParser.Unary_operationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CircuitLangParser.unary_operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnary_operation([NotNull] CircuitLangParser.Unary_operationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CircuitLangParser.binary_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBinary_operator([NotNull] CircuitLangParser.Binary_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CircuitLangParser.binary_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBinary_operator([NotNull] CircuitLangParser.Binary_operatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CircuitLangParser.unary_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnary_operator([NotNull] CircuitLangParser.Unary_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CircuitLangParser.unary_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnary_operator([NotNull] CircuitLangParser.Unary_operatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CircuitLangParser.module_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModule_call([NotNull] CircuitLangParser.Module_callContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CircuitLangParser.module_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModule_call([NotNull] CircuitLangParser.Module_callContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CircuitLangParser.variable_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable_declaration([NotNull] CircuitLangParser.Variable_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CircuitLangParser.variable_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable_declaration([NotNull] CircuitLangParser.Variable_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CircuitLangParser.truth_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTruth_table([NotNull] CircuitLangParser.Truth_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CircuitLangParser.truth_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTruth_table([NotNull] CircuitLangParser.Truth_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CircuitLangParser.truth_table_entry"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTruth_table_entry([NotNull] CircuitLangParser.Truth_table_entryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CircuitLangParser.truth_table_entry"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTruth_table_entry([NotNull] CircuitLangParser.Truth_table_entryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CircuitLangParser.literal_or_wild"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral_or_wild([NotNull] CircuitLangParser.Literal_or_wildContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CircuitLangParser.literal_or_wild"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral_or_wild([NotNull] CircuitLangParser.Literal_or_wildContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CircuitLangParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral([NotNull] CircuitLangParser.LiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CircuitLangParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral([NotNull] CircuitLangParser.LiteralContext context);
}