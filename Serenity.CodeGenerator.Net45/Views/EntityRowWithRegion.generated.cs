﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Serenity.CodeGenerator.Views
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class EntityRowWithRegion : RazorGenerator.Templating.RazorTemplateBase
    {
#line hidden

    public dynamic Model { get; set; }
    public Serenity.CodeGenerator.GeneratorConfig Config { get; set; }

        public override void Execute()
        {


WriteLiteral("\r\n");



   
    var dotModule = Model.Module == null ? "" : ("." + Model.Module);
    var moduleDot = Model.Module == null ? "" : (Model.Module + ".");
    var schemaDot = Model.Schema == null ? "" : ("[" + Model.Schema + "].");

    Func<string, string, string> jf = (x, y) =>
    {
        if (x.ToLowerInvariant() == y.ToLowerInvariant())
            return y;
        else
            return x + y;
    };


WriteLiteral("namespace ");


      Write(Model.RootNamespace);


                            Write(dotModule);

WriteLiteral(".Entities\r\n{\r\n    using Serenity;\r\n    using Serenity.ComponentModel;\r\n    using " +
"Serenity.Data;\r\n    using Serenity.Data.Mapping;\r\n    using System;\r\n    using S" +
"ystem.ComponentModel;\r\n    using System.IO;\r\n\r\n    [ConnectionKey(\"");


               Write(Model.ConnectionKey);

WriteLiteral("\"), TableName(TableName)]\r\n    [DisplayName(\"");


             Write(Model.Title);

WriteLiteral("\"), InstanceName(\"");


                                           Write(Model.Title);

WriteLiteral("\"), TwoLevelCached]\r\n    [ConnectionKey(\"");


               Write(Model.ConnectionKey);

WriteLiteral("\"), DisplayName(\"");


                                                    Write(Model.Title);

WriteLiteral("\"), InstanceName(\"");


                                                                                  Write(Model.Title);

WriteLiteral("\"), TwoLevelCached]\r\n    [ReadPermission(\"");


                Write(Model.Module);

WriteLiteral(":");


                              Write(Model.Tablename);

WriteLiteral(":Read\")]\r\n    [InsertPermission(\"");


                  Write(Model.Module);

WriteLiteral(":");


                                Write(Model.Tablename);

WriteLiteral(":Insert\")]\r\n    [UpdatePermission(\"");


                  Write(Model.Module);

WriteLiteral(":");


                                Write(Model.Tablename);

WriteLiteral(":Update\")]\r\n    [DeletePermission(\"");


                  Write(Model.Module);

WriteLiteral(":");


                                Write(Model.Tablename);

WriteLiteral(":Delete\")]\r\n");


     if (Config.GenerateLookupEditor)
    {
WriteLiteral("    ");

WriteLiteral("[LookupScript(\"");


                         Write(Model.Module);

WriteLiteral(".");


                                       Write(Model.ClassName);

WriteLiteral("\")]");


                                                                      }

WriteLiteral("\r\n    public sealed class ");


                   Write(Model.RowClassName);

WriteLiteral(" : ");


                                         Write(Model.RowBaseClass);

WriteLiteral(", IIdRow");


                                                                     Write(Model.IsLookup ? ", IDbLookupRow" : "");


                                                                                                              Write(Model.NameField == null ? "" : ", INameRow");


                                                                                                                                                                WriteLiteral("\r\n    {");

      foreach (EntityField x in Model.Fields)
                {
                    var attrs = new List<string>();
                    var attrsLookupEditorForm = new List<string>();

                    attrs.Add("DisplayName(\"" + x.Title + "\")");

                    if (x.Ident != x.Name)
                    {
                        attrs.Add("Column(\"" + x.Name + "\")");
                    }

                    if ((x.Size ?? 0) != 0)
                    {
                        attrs.Add("Size(" + x.Size + ")");
                    }
                    if (x.Scale != 0)
                    {
                        attrs.Add("Scale(" + x.Scale + ")");
                    }
                    if (!String.IsNullOrEmpty(x.Flags))
                    {
                        attrs.Add(x.Flags);
                    }
                    if (!String.IsNullOrEmpty(x.PKTable))
                    {
                        attrs.Add("ForeignKey(\"" + (string.IsNullOrEmpty(x.PKSchema) ? x.PKTable : ("[" + x.PKSchema + "].[" + x.PKTable + "]")) + "\", \"" + x.PKColumn + "\")");
                        attrs.Add("LeftJoin(\"j" + x.ForeignJoinAlias + "\")");

                        attrsLookupEditorForm.Add("LookupEditor(typeof(" + Model.Module + ".Entities." + Serenity.CodeGenerator.RowGenerator.ClassNameFromTableName(x.PKTable) + "Row), InplaceAdd = true)");
        }
        if (Model.NameField == x.Ident)
        {
            attrs.Add("QuickSearch");
        }
        if (x.TextualField != null)
        {
            attrs.Add("TextualField(\"" + x.TextualField + "\")");
        }
        var attrString = String.Join(", ", attrs.ToArray());
    var attrStringLookupEditorForm = String.Join(", ", attrsLookupEditorForm.ToArray());


WriteLiteral("        ");

WriteLiteral("\r\n            #region ");


               Write(x.Title);

WriteLiteral("\r\n");


             if (!String.IsNullOrEmpty(attrString))
            {

WriteLiteral("            ");

WriteLiteral("[");


              Write(attrString);

WriteLiteral("]");

WriteLiteral("\r\n");


            }


             if (Config.GenerateLookupEditor)
            {if (!String.IsNullOrEmpty(attrStringLookupEditorForm))
            {

WriteLiteral("            ");

WriteLiteral("[");


              Write(attrStringLookupEditorForm);

WriteLiteral("]");

WriteLiteral("\r\n");


            }}

WriteLiteral("            public ");


              Write(x.DataType);


                          Write(x.IsValueType ? "?" : "");

WriteLiteral(" ");


                                                     Write(x.Ident);

WriteLiteral(" { get { return Fields.");


                                                                                     Write(x.Ident);

WriteLiteral("[this]; } set { Fields.");


                                                                                                                      Write(x.Ident);

WriteLiteral("[this] = value; } }\r\n            public partial class RowFields { public ");


                                                Write(x.FieldType);

WriteLiteral("Field ");


                                                                    Write(x.Ident);

WriteLiteral("; }\r\n            #endregion ");


                  Write(x.Ident);

WriteLiteral("\r\n        ");


               }

WriteLiteral("\r\n\r\n    #region Foreign Fields\r\n");


     foreach (EntityJoin x in Model.Joins)
            {
                foreach (EntityField y in x.Fields)
                {

WriteLiteral("            ");

WriteLiteral("\r\n                [DisplayName(\"");


                         Write(y.Title);

WriteLiteral("\"), Expression(\"");


                                                  Write("j" + x.Name + ".[" + y.Name + "]");

WriteLiteral("\")]\r\n                public ");


                  Write(y.DataType);


                              Write(y.IsValueType ? "?" : "");

WriteLiteral(" ");


                                                          Write(jf(x.Name, y.Ident));

WriteLiteral(" { get { return Fields.");


                                                                                                       Write(jf(x.Name, y.Ident));

WriteLiteral("[this]; } set { Fields.");


                                                                                                                                                    Write(jf(x.Name, y.Ident));

WriteLiteral("[this] = value; } }\r\n                public partial class RowFields { public ");


                                                    Write(y.FieldType);

WriteLiteral("Field ");


                                                                        Write(jf(x.Name, y.Ident));

WriteLiteral("; }\r\n\r\n            ");


                   }
            }

WriteLiteral("\r\n    #endregion Foreign Fields\r\n\r\n    #region Id and Name fields\r\n    IIdField I" +
"IdRow.IdField\r\n    {\r\n    get { return Fields.");


                    Write(Model.Identity);

WriteLiteral("; }\r\n    }\r\n");


     if (Model.NameField != null)
            {

WriteLiteral("        ");

WriteLiteral("\r\n            StringField INameRow.NameField\r\n            {\r\n            get { re" +
"turn Fields.");


                           Write(Model.NameField);

WriteLiteral("; }\r\n            }\r\n        ");


               }

WriteLiteral("    #endregion Id and Name fields\r\n\r\n    #region Constructor\r\n    public ");


       Write(Model.RowClassName);

WriteLiteral("()\r\n    : base(Fields)\r\n    {\r\n    }\r\n    #endregion Constructor\r\n\r\n    #region R" +
"owFields\r\n    public static readonly RowFields Fields = new RowFields().Init();\r" +
"\n\r\n    public const string TableName = \"");


                                 Write(String.IsNullOrEmpty(schemaDot) ? Model.Tablename : schemaDot + "[" + Model.Tablename + "]");

WriteLiteral("\"");


                                                                                                                                Write(string.IsNullOrEmpty(Model.FieldPrefix) ? "" : (", \"" + Model.FieldPrefix + "\""));

WriteLiteral(";\r\n\r\n    public partial class RowFields : ");


                                 Write(Model.FieldsBaseClass);

WriteLiteral("\r\n    {\r\n    public RowFields()\r\n    : base(\"");


        Write(String.IsNullOrEmpty(schemaDot) ? Model.Tablename : schemaDot + "[" + Model.Tablename + "]");

WriteLiteral("\"");


                                                                                                       Write(string.IsNullOrEmpty(Model.FieldPrefix) ? "" : (", \"" + Model.FieldPrefix + "\""));

WriteLiteral(")\r\n    {\r\n    LocalTextPrefix = \"");


                   Write(moduleDot);


                               Write(Model.ClassName);

WriteLiteral("\";\r\n    }\r\n    }\r\n    #endregion RowFields\r\n    }\r\n    }\r\n");


        }
    }
}
#pragma warning restore 1591
