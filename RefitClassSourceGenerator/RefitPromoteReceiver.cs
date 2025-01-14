﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace RefitClassSourceGenerator;

internal class RefitPromoteReceiver : ISyntaxReceiver
{
    public List<PropertyDeclarationSyntax> PropertiesToPromote { get; } = new();

    public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
    {
        if (syntaxNode is PropertyDeclarationSyntax propertyDeclarationSyntax)
        {
            // Process further if we have any attributes applied
            if (propertyDeclarationSyntax.AttributeLists.Count != 0)
            {
#if DEBUG
                if (!Debugger.IsAttached)
                {
                    //Debugger.Launch();
                }
#endif
                if (propertyDeclarationSyntax.AttributeLists.Any(a => a.Attributes.Any(aa => aa.Name.NormalizeWhitespace().ToFullString() == "RefitPromoteCalls")))
                {
                    PropertiesToPromote.Add(propertyDeclarationSyntax);
                }
            }
        }
    }
}