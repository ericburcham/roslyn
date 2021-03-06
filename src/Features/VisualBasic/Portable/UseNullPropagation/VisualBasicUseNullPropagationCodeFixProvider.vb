﻿' Licensed to the .NET Foundation under one or more agreements.
' The .NET Foundation licenses this file to you under the MIT license.
' See the LICENSE file in the project root for more information.

Imports System.Composition
Imports Microsoft.CodeAnalysis.CodeFixes
Imports Microsoft.CodeAnalysis.UseNullPropagation
Imports Microsoft.CodeAnalysis.VisualBasic.Syntax

Namespace Microsoft.CodeAnalysis.VisualBasic.UseNullPropagation
    <ExportCodeFixProvider(LanguageNames.VisualBasic), [Shared]>
    Friend Class VisualBasicUseNullPropagationCodeFixProvider
        Inherits AbstractUseNullPropagationCodeFixProvider(Of
            SyntaxKind,
            ExpressionSyntax,
            TernaryConditionalExpressionSyntax,
            BinaryExpressionSyntax,
            InvocationExpressionSyntax,
            MemberAccessExpressionSyntax,
            ConditionalAccessExpressionSyntax,
            InvocationExpressionSyntax)

        <ImportingConstructor>
        Public Sub New()
        End Sub
    End Class
End Namespace
