//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a RdGen v1.11.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

using JetBrains.Core;
using JetBrains.Diagnostics;
using JetBrains.Collections;
using JetBrains.Collections.Viewable;
using JetBrains.Lifetimes;
using JetBrains.Serialization;
using JetBrains.Rd;
using JetBrains.Rd.Base;
using JetBrains.Rd.Impl;
using JetBrains.Rd.Tasks;
using JetBrains.Rd.Util;
using JetBrains.Rd.Text;


// ReSharper disable RedundantEmptyObjectCreationArgumentList
// ReSharper disable InconsistentNaming
// ReSharper disable RedundantOverflowCheckingContext


namespace org.example
{
  
  
  /// <summary>
  /// <p>Generated from: RecursivePolymorphicModel.kt:14</p>
  /// </summary>
  public class RecursivePolymorphicModel : RdExtBase
  {
    //fields
    //public fields
    [NotNull] public IViewableProperty<BeTreeGridLine> Line => _Line;
    [NotNull] public IViewableProperty<List<BeTreeGridLine>> List => _List;
    
    //private fields
    [NotNull] private readonly RdProperty<BeTreeGridLine> _Line;
    [NotNull] private readonly RdProperty<List<BeTreeGridLine>> _List;
    
    //primary constructor
    private RecursivePolymorphicModel(
      [NotNull] RdProperty<BeTreeGridLine> line,
      [NotNull] RdProperty<List<BeTreeGridLine>> list
    )
    {
      if (line == null) throw new ArgumentNullException("line");
      if (list == null) throw new ArgumentNullException("list");
      
      _Line = line;
      _List = list;
      BindableChildren.Add(new KeyValuePair<string, object>("line", _Line));
      BindableChildren.Add(new KeyValuePair<string, object>("list", _List));
    }
    //secondary constructor
    private RecursivePolymorphicModel (
    ) : this (
      new RdProperty<BeTreeGridLine>(ReadBeTreeGridLine, WriteBeTreeGridLine),
      new RdProperty<List<BeTreeGridLine>>(ReadBeTreeGridLineList, WriteBeTreeGridLineList)
    ) {}
    //deconstruct trait
    //statics
    
    public static CtxReadDelegate<BeTreeGridLine> ReadBeTreeGridLine = Polymorphic<BeTreeGridLine>.ReadAbstract(BeTreeGridLine_Unknown.Read);
    public static CtxReadDelegate<List<BeTreeGridLine>> ReadBeTreeGridLineList = Polymorphic<BeTreeGridLine>.ReadAbstract(BeTreeGridLine_Unknown.Read).List();
    
    public static  CtxWriteDelegate<BeTreeGridLine> WriteBeTreeGridLine = Polymorphic<BeTreeGridLine>.Write;
    public static  CtxWriteDelegate<List<BeTreeGridLine>> WriteBeTreeGridLineList = Polymorphic<BeTreeGridLine>.Write.List();
    
    protected override long SerializationHash => 4259101978417261843L;
    
    protected override Action<ISerializers> Register => RegisterDeclaredTypesSerializers;
    public static void RegisterDeclaredTypesSerializers(ISerializers serializers)
    {
      serializers.Register(BeTreeGridLine.Read, BeTreeGridLine.Write);
      serializers.Register(BeTreeGridLine_Unknown.Read, BeTreeGridLine_Unknown.Write);
      
      serializers.RegisterToplevelOnce(typeof(RecursivePolymorphicModelRoot), RecursivePolymorphicModelRoot.RegisterDeclaredTypesSerializers);
    }
    
    public RecursivePolymorphicModel(Lifetime lifetime, IProtocol protocol) : this()
    {
      Identify(protocol.Identities, RdId.Root.Mix("RecursivePolymorphicModel"));
      this.BindTopLevel(lifetime, protocol, "RecursivePolymorphicModel");
    }
    
    //constants
    
    //custom body
    //methods
    //equals trait
    //hash code trait
    //pretty print
    public override void Print(PrettyPrinter printer)
    {
      printer.Println("RecursivePolymorphicModel (");
      using (printer.IndentCookie()) {
        printer.Print("line = "); _Line.PrintEx(printer); printer.Println();
        printer.Print("list = "); _List.PrintEx(printer); printer.Println();
      }
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
  
  
  /// <summary>
  /// <p>Generated from: RecursivePolymorphicModel.kt:15</p>
  /// </summary>
  public class BeTreeGridLine : RdBindableBase
  {
    //fields
    //public fields
    [NotNull] public IViewableList<BeTreeGridLine> Children => _Children;
    
    //private fields
    [NotNull] protected readonly RdList<BeTreeGridLine> _Children;
    
    //primary constructor
    protected BeTreeGridLine(
      [NotNull] RdList<BeTreeGridLine> children
    )
    {
      if (children == null) throw new ArgumentNullException("children");
      
      _Children = children;
      BindableChildren.Add(new KeyValuePair<string, object>("children", _Children));
    }
    //secondary constructor
    public BeTreeGridLine (
    ) : this (
      new RdList<BeTreeGridLine>(ReadBeTreeGridLine, WriteBeTreeGridLine)
    ) {}
    //deconstruct trait
    //statics
    
    public static CtxReadDelegate<BeTreeGridLine> Read = (ctx, reader) => 
    {
      var _id = RdId.Read(reader);
      var children = RdList<BeTreeGridLine>.Read(ctx, reader, ReadBeTreeGridLine, WriteBeTreeGridLine);
      var _result = new BeTreeGridLine(children).WithId(_id);
      return _result;
    };
    public static CtxReadDelegate<BeTreeGridLine> ReadBeTreeGridLine = Polymorphic<BeTreeGridLine>.ReadAbstract(BeTreeGridLine_Unknown.Read);
    
    public static CtxWriteDelegate<BeTreeGridLine> Write = (ctx, writer, value) => 
    {
      value.RdId.Write(writer);
      RdList<BeTreeGridLine>.Write(ctx, writer, value._Children);
    };
    public static  CtxWriteDelegate<BeTreeGridLine> WriteBeTreeGridLine = Polymorphic<BeTreeGridLine>.Write;
    
    //constants
    
    //custom body
    //methods
    //equals trait
    //hash code trait
    //pretty print
    public override void Print(PrettyPrinter printer)
    {
      printer.Println("BeTreeGridLine (");
      using (printer.IndentCookie()) {
        printer.Print("children = "); _Children.PrintEx(printer); printer.Println();
      }
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
  
  
  public sealed class BeTreeGridLine_Unknown : BeTreeGridLine
  {
    //fields
    //public fields
    
    //private fields
    //primary constructor
    private BeTreeGridLine_Unknown(
      [NotNull] RdList<BeTreeGridLine> children
    ) : base (
      children
     ) 
    {
    }
    //secondary constructor
    public BeTreeGridLine_Unknown (
    ) : this (
      new RdList<BeTreeGridLine>(ReadBeTreeGridLine, WriteBeTreeGridLine)
    ) {}
    //deconstruct trait
    //statics
    
    public static new CtxReadDelegate<BeTreeGridLine_Unknown> Read = (ctx, reader) => 
    {
      var _id = RdId.Read(reader);
      var children = RdList<BeTreeGridLine>.Read(ctx, reader, ReadBeTreeGridLine, WriteBeTreeGridLine);
      var _result = new BeTreeGridLine_Unknown(children).WithId(_id);
      return _result;
    };
    public static new CtxReadDelegate<BeTreeGridLine> ReadBeTreeGridLine = Polymorphic<BeTreeGridLine>.ReadAbstract(BeTreeGridLine_Unknown.Read);
    
    public static new CtxWriteDelegate<BeTreeGridLine_Unknown> Write = (ctx, writer, value) => 
    {
      value.RdId.Write(writer);
      RdList<BeTreeGridLine>.Write(ctx, writer, value._Children);
    };
    public static  new CtxWriteDelegate<BeTreeGridLine> WriteBeTreeGridLine = Polymorphic<BeTreeGridLine>.Write;
    
    //constants
    
    //custom body
    //methods
    //equals trait
    //hash code trait
    //pretty print
    public override void Print(PrettyPrinter printer)
    {
      printer.Println("BeTreeGridLine_Unknown (");
      using (printer.IndentCookie()) {
        printer.Print("children = "); _Children.PrintEx(printer); printer.Println();
      }
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
}