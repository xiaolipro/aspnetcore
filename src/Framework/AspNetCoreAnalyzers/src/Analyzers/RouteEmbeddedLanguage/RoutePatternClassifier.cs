// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Analyzers.RouteEmbeddedLanguage.Infrastructure;
using Microsoft.AspNetCore.Analyzers.RouteEmbeddedLanguage.RoutePattern;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.ExternalAccess.AspNetCore.EmbeddedLanguages;

namespace Microsoft.AspNetCore.Analyzers.RouteEmbeddedLanguage;

[ExportAspNetCoreEmbeddedLanguageClassifier(name: "Route", language: LanguageNames.CSharp)]
internal sealed class RoutePatternClassifier : RoutePatternClassifierBase
{
    protected override RoutePatternOptions GetOptions(RoutePatternUsageContext context) =>
        context.IsMvcAttribute ? RoutePatternOptions.MvcAttributeRoute : RoutePatternOptions.DefaultRoute;
}
