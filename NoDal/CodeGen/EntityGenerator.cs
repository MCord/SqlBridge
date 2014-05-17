namespace SqlBridge.CodeGen
{
    using System;
    using Roslyn.Compilers.CSharp;

    public class EntityGenerator : BaseGenerator
    {
        private string modelFile;

        public EntityGenerator(string modelFile)
        {
            this.modelFile = modelFile;
        }

        public void Generate()
        {
            var tree = Syntax.NamespaceDeclaration(Syntax.ParseName("Namespace"));
            tree = tree.AddUsings(Syntax.UsingDirective(Syntax.ParseName("System")));
            var @class = Syntax.ClassDeclaration("CoolClass")
                .AddMembers(CreateAutoProperty("string", "MyProperty"))
                .WithAttributeLists(CreateAttribute("MyAttribute", "\"1213\""));
            
            tree = tree.AddMembers(@class);
            tree = tree.NormalizeWhitespace();
            
            Console.WriteLine(tree);
            var diagnosticList = tree.GetDiagnostics();
            foreach (var diagnostic in diagnosticList)
            {
                Console.Error.WriteLine(diagnostic);
            }
        }

        private static PropertyDeclarationSyntax CreateAutoProperty(string type, string name)
        {
            return Syntax.PropertyDeclaration(Syntax.ParseTypeName(type), name)
                .WithModifiers(Syntax.Token(SyntaxKind.PublicKeyword))
                .WithAccessorList(Syntax.AccessorList(
                    Syntax.List(
                        Syntax.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                            .WithSemicolonToken(Syntax.Token(SyntaxKind.SemicolonToken)),
                        Syntax.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                            .WithSemicolonToken(Syntax.Token(SyntaxKind.SemicolonToken)))))
                .WithModifiers(Syntax.Token(SyntaxKind.PublicKeyword))
                .WithAttributeLists(CreateAttribute("MyAttribute", "\"1213\""));
        }

        private static AttributeListSyntax CreateAttribute(string name, string value)
        {
            return Syntax.AttributeList(Syntax.SeparatedList(Syntax.Attribute(Syntax.ParseName(name))
                .AddArgumentListArguments(
                    Syntax.AttributeArgument(
                        Syntax.LiteralExpression(
                            SyntaxKind.StringLiteralExpression, Syntax.ParseToken(value))))));
        }
    }
}