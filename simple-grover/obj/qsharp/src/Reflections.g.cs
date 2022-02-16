//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"ReflectAboutMarked\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\vivie\\\\OneDrive\\\\Documents\\\\GitHub\\\\MyQuantumRepo\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Reflects about the basis state marked by alternating zeros and ones.\",\" This operation defines what input we are trying to find in the main\",\" search.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"ReflectAboutMarked\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\vivie\\\\OneDrive\\\\Documents\\\\GitHub\\\\MyQuantumRepo\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"ReflectAboutUniform\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\vivie\\\\OneDrive\\\\Documents\\\\GitHub\\\\MyQuantumRepo\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":34,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Reflects about the uniform superposition state.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"ReflectAboutUniform\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\vivie\\\\OneDrive\\\\Documents\\\\GitHub\\\\MyQuantumRepo\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":34,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"ReflectAboutAllOnes\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\vivie\\\\OneDrive\\\\Documents\\\\GitHub\\\\MyQuantumRepo\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":50,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Reflects about the all-ones state.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"ReflectAboutAllOnes\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\vivie\\\\OneDrive\\\\Documents\\\\GitHub\\\\MyQuantumRepo\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":50,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"PrepareUniform\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\vivie\\\\OneDrive\\\\Documents\\\\GitHub\\\\MyQuantumRepo\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":57,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Given a register in the all-zeros state, prepares a uniform\",\" superposition over all basis states.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"PrepareUniform\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\vivie\\\\OneDrive\\\\Documents\\\\GitHub\\\\MyQuantumRepo\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":57,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"PrepareUniform\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\vivie\\\\OneDrive\\\\Documents\\\\GitHub\\\\MyQuantumRepo\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":57,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Microsoft.Quantum.Samples.SimpleGrover.PrepareUniform\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"PrepareUniform\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\vivie\\\\OneDrive\\\\Documents\\\\GitHub\\\\MyQuantumRepo\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":57,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsControlled specialization for Microsoft.Quantum.Samples.SimpleGrover.PrepareUniform\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"PrepareUniform\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\vivie\\\\OneDrive\\\\Documents\\\\GitHub\\\\MyQuantumRepo\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":57,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Microsoft.Quantum.Samples.SimpleGrover.PrepareUniform\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"PrepareAllOnes\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\vivie\\\\OneDrive\\\\Documents\\\\GitHub\\\\MyQuantumRepo\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":64,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Given a register in the all-zeros state, prepares an all-ones state\",\" by flipping every qubit.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"PrepareAllOnes\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\vivie\\\\OneDrive\\\\Documents\\\\GitHub\\\\MyQuantumRepo\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":64,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"PrepareAllOnes\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\vivie\\\\OneDrive\\\\Documents\\\\GitHub\\\\MyQuantumRepo\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":64,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Microsoft.Quantum.Samples.SimpleGrover.PrepareAllOnes\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"PrepareAllOnes\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\vivie\\\\OneDrive\\\\Documents\\\\GitHub\\\\MyQuantumRepo\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":64,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsControlled specialization for Microsoft.Quantum.Samples.SimpleGrover.PrepareAllOnes\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"PrepareAllOnes\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\vivie\\\\OneDrive\\\\Documents\\\\GitHub\\\\MyQuantumRepo\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":64,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Microsoft.Quantum.Samples.SimpleGrover.PrepareAllOnes\"]}")]
#line hidden
namespace Microsoft.Quantum.Samples.SimpleGrover
{
    [SourceLocation("C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs", OperationFunctor.Body, 16, 35)]
    public partial class ReflectAboutMarked : Operation<IQArray<Qubit>, QVoid>, ICallable
    {
        public ReflectAboutMarked(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectAboutMarked";
        String ICallable.FullName => "Microsoft.Quantum.Samples.SimpleGrover.ReflectAboutMarked";
        protected ICallable<String, QVoid> Message__
        {
            get;
            set;
        }

        protected Allocate Allocate__
        {
            get;
            set;
        }

        protected Release Release__
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,IQArray<Qubit>)> Microsoft__Quantum__Canon___15fb5150ae3649958ac38a4e43ca6009_ApplyToEachA
        {
            get;
            set;
        }

        protected ICallable Length__
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> __Body__ => (__in__) =>
        {
            var inputQubits = __in__;
#line 17 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
            Message__.Apply("Reflecting about marked state...");
#line hidden
            {
#line 18 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
                var outputQubit = Allocate__.Apply();
#line hidden
                bool __arg1__ = true;
                try
                {
#line 22 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
                    Microsoft__Quantum__Intrinsic__X.Apply(outputQubit);
#line 23 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
                    Microsoft__Quantum__Intrinsic__H.Apply(outputQubit);
#line 27 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
                    Microsoft__Quantum__Canon___15fb5150ae3649958ac38a4e43ca6009_ApplyToEachA.Apply((Microsoft__Quantum__Intrinsic__X, inputQubits.Slice(new QRange(((2L < 0L) ? (inputQubits.Length - 1L) : 0L), 2L, ((2L < 0L) ? 0L : (inputQubits.Length - 1L))))));
#line 29 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
                    Microsoft__Quantum__Intrinsic__X.Controlled.Apply((inputQubits, outputQubit));
#line 16 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
                    Microsoft__Quantum__Canon___15fb5150ae3649958ac38a4e43ca6009_ApplyToEachA.Adjoint.Apply((Microsoft__Quantum__Intrinsic__X, inputQubits.Slice(new QRange(((2L < 0L) ? (inputQubits.Length - 1L) : 0L), 2L, ((2L < 0L) ? 0L : (inputQubits.Length - 1L))))));
#line 16 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
                    Microsoft__Quantum__Intrinsic__H.Adjoint.Apply(outputQubit);
#line 16 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
                    Microsoft__Quantum__Intrinsic__X.Adjoint.Apply(outputQubit);
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release__.Apply(outputQubit);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Message__ = this.__Factory__.Get<ICallable<String, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.Message));
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Canon___15fb5150ae3649958ac38a4e43ca6009_ApplyToEachA = this.__Factory__.Get<IAdjointable<(IAdjointable,IQArray<Qubit>)>>(typeof(global::Microsoft.Quantum.Canon._15fb5150ae3649958ac38a4e43ca6009_ApplyToEachA));
            this.Length__ = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __DataIn__(IQArray<Qubit> data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> inputQubits)
        {
            return __m__.Run<ReflectAboutMarked, IQArray<Qubit>, QVoid>(inputQubits);
        }
    }

    [SourceLocation("C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs", OperationFunctor.Body, 35, 51)]
    public partial class ReflectAboutUniform : Operation<IQArray<Qubit>, QVoid>, ICallable
    {
        public ReflectAboutUniform(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectAboutUniform";
        String ICallable.FullName => "Microsoft.Quantum.Samples.SimpleGrover.ReflectAboutUniform";
        protected IUnitary<IQArray<Qubit>> PrepareUniform__
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> PrepareAllOnes__
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> ReflectAboutAllOnes__
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> __Body__ => (__in__) =>
        {
            var inputQubits = __in__;
#line 38 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
            PrepareUniform__.Adjoint.Apply(inputQubits);
#line 40 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
            PrepareAllOnes__.Apply(inputQubits);
#line 45 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
            ReflectAboutAllOnes__.Apply(inputQubits);
#line 35 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
            PrepareAllOnes__.Adjoint.Apply(inputQubits);
#line 35 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
            PrepareUniform__.Adjoint.Adjoint.Apply(inputQubits);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.PrepareUniform__ = this.__Factory__.Get<IUnitary<IQArray<Qubit>>>(typeof(PrepareUniform));
            this.PrepareAllOnes__ = this.__Factory__.Get<IUnitary<IQArray<Qubit>>>(typeof(PrepareAllOnes));
            this.ReflectAboutAllOnes__ = this.__Factory__.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(ReflectAboutAllOnes));
        }

        public override IApplyData __DataIn__(IQArray<Qubit> data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> inputQubits)
        {
            return __m__.Run<ReflectAboutUniform, IQArray<Qubit>, QVoid>(inputQubits);
        }
    }

    [SourceLocation("C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs", OperationFunctor.Body, 51, 58)]
    public partial class ReflectAboutAllOnes : Operation<IQArray<Qubit>, QVoid>, ICallable
    {
        public ReflectAboutAllOnes(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectAboutAllOnes";
        String ICallable.FullName => "Microsoft.Quantum.Samples.SimpleGrover.ReflectAboutAllOnes";
        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__Z
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, IQArray<Qubit>> Microsoft__Quantum__Arrays___8ffd763c46674f93926a1160cd1a51e8_Most
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, Qubit> Microsoft__Quantum__Arrays___03013f2e0b6b48af8ec62c932e6021e8_Tail
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> __Body__ => (__in__) =>
        {
            var inputQubits = __in__;
#line 52 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
            Microsoft__Quantum__Intrinsic__Z.Controlled.Apply((Microsoft__Quantum__Arrays___8ffd763c46674f93926a1160cd1a51e8_Most.Apply(inputQubits), Microsoft__Quantum__Arrays___03013f2e0b6b48af8ec62c932e6021e8_Tail.Apply(inputQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Intrinsic__Z = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.Z));
            this.Microsoft__Quantum__Arrays___8ffd763c46674f93926a1160cd1a51e8_Most = this.__Factory__.Get<ICallable<IQArray<Qubit>, IQArray<Qubit>>>(typeof(global::Microsoft.Quantum.Arrays._8ffd763c46674f93926a1160cd1a51e8_Most));
            this.Microsoft__Quantum__Arrays___03013f2e0b6b48af8ec62c932e6021e8_Tail = this.__Factory__.Get<ICallable<IQArray<Qubit>, Qubit>>(typeof(global::Microsoft.Quantum.Arrays._03013f2e0b6b48af8ec62c932e6021e8_Tail));
        }

        public override IApplyData __DataIn__(IQArray<Qubit> data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> inputQubits)
        {
            return __m__.Run<ReflectAboutAllOnes, IQArray<Qubit>, QVoid>(inputQubits);
        }
    }

    [SourceLocation("C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs", OperationFunctor.Body, 58, 65)]
    [SourceLocation("C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs", OperationFunctor.Adjoint, 58, 65)]
    [SourceLocation("C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs", OperationFunctor.Controlled, 58, 65)]
    [SourceLocation("C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs", OperationFunctor.ControlledAdjoint, 58, 65)]
    public partial class PrepareUniform : Unitary<IQArray<Qubit>>, ICallable
    {
        public PrepareUniform(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PrepareUniform";
        String ICallable.FullName => "Microsoft.Quantum.Samples.SimpleGrover.PrepareUniform";
        protected IUnitary<(IUnitary,IQArray<Qubit>)> Microsoft__Quantum__Canon___6a717aeda39d440aae6e19523f2002a0_ApplyToEachCA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> __Body__ => (__in__) =>
        {
            var inputQubits = __in__;
#line 59 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
            Microsoft__Quantum__Canon___6a717aeda39d440aae6e19523f2002a0_ApplyToEachCA.Apply((Microsoft__Quantum__Intrinsic__H, inputQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> __AdjointBody__ => (__in__) =>
        {
            var inputQubits = __in__;
#line 58 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
            Microsoft__Quantum__Canon___6a717aeda39d440aae6e19523f2002a0_ApplyToEachCA.Adjoint.Apply((Microsoft__Quantum__Intrinsic__H, inputQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> __ControlledBody__ => (__in__) =>
        {
            var (__controlQubits__,inputQubits) = __in__;
#line 58 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
            Microsoft__Quantum__Canon___6a717aeda39d440aae6e19523f2002a0_ApplyToEachCA.Controlled.Apply((__controlQubits__, (Microsoft__Quantum__Intrinsic__H, inputQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> __ControlledAdjointBody__ => (__in__) =>
        {
            var (__controlQubits__,inputQubits) = __in__;
#line 58 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
            Microsoft__Quantum__Canon___6a717aeda39d440aae6e19523f2002a0_ApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (Microsoft__Quantum__Intrinsic__H, inputQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Canon___6a717aeda39d440aae6e19523f2002a0_ApplyToEachCA = this.__Factory__.Get<IUnitary<(IUnitary,IQArray<Qubit>)>>(typeof(global::Microsoft.Quantum.Canon._6a717aeda39d440aae6e19523f2002a0_ApplyToEachCA));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __DataIn__(IQArray<Qubit> data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> inputQubits)
        {
            return __m__.Run<PrepareUniform, IQArray<Qubit>, QVoid>(inputQubits);
        }
    }

    [SourceLocation("C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs", OperationFunctor.Body, 65, -1)]
    [SourceLocation("C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs", OperationFunctor.Adjoint, 65, -1)]
    [SourceLocation("C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs", OperationFunctor.Controlled, 65, -1)]
    [SourceLocation("C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs", OperationFunctor.ControlledAdjoint, 65, -1)]
    public partial class PrepareAllOnes : Unitary<IQArray<Qubit>>, ICallable
    {
        public PrepareAllOnes(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PrepareAllOnes";
        String ICallable.FullName => "Microsoft.Quantum.Samples.SimpleGrover.PrepareAllOnes";
        protected IUnitary<(IUnitary,IQArray<Qubit>)> Microsoft__Quantum__Canon___6a717aeda39d440aae6e19523f2002a0_ApplyToEachCA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> __Body__ => (__in__) =>
        {
            var inputQubits = __in__;
#line 66 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
            Microsoft__Quantum__Canon___6a717aeda39d440aae6e19523f2002a0_ApplyToEachCA.Apply((Microsoft__Quantum__Intrinsic__X, inputQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> __AdjointBody__ => (__in__) =>
        {
            var inputQubits = __in__;
#line 65 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
            Microsoft__Quantum__Canon___6a717aeda39d440aae6e19523f2002a0_ApplyToEachCA.Adjoint.Apply((Microsoft__Quantum__Intrinsic__X, inputQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> __ControlledBody__ => (__in__) =>
        {
            var (__controlQubits__,inputQubits) = __in__;
#line 65 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
            Microsoft__Quantum__Canon___6a717aeda39d440aae6e19523f2002a0_ApplyToEachCA.Controlled.Apply((__controlQubits__, (Microsoft__Quantum__Intrinsic__X, inputQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> __ControlledAdjointBody__ => (__in__) =>
        {
            var (__controlQubits__,inputQubits) = __in__;
#line 65 "C:\\Users\\vivie\\OneDrive\\Documents\\GitHub\\MyQuantumRepo\\simple-grover\\Reflections.qs"
            Microsoft__Quantum__Canon___6a717aeda39d440aae6e19523f2002a0_ApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (Microsoft__Quantum__Intrinsic__X, inputQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Canon___6a717aeda39d440aae6e19523f2002a0_ApplyToEachCA = this.__Factory__.Get<IUnitary<(IUnitary,IQArray<Qubit>)>>(typeof(global::Microsoft.Quantum.Canon._6a717aeda39d440aae6e19523f2002a0_ApplyToEachCA));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __DataIn__(IQArray<Qubit> data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> inputQubits)
        {
            return __m__.Run<PrepareAllOnes, IQArray<Qubit>, QVoid>(inputQubits);
        }
    }
}